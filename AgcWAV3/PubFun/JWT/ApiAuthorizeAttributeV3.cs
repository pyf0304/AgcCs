
using AGCWA.PubFun;
using Comm.PubFun;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Sinks;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace AgcWA.Controllers
{
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiAuthorizeAttributeV3 : Attribute, IAuthorizationFilter
    {
        private readonly Serilog.ILogger _logger;

        public ApiAuthorizeAttributeV3()
        {
            _logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var actionName = context.ActionDescriptor.DisplayName;
            _logger.Information("Authorization filter executing. actionName:", actionName);
            //foreach(var obj in context.Filters)
            //  {
            //      var aa = obj as ApiAuthorizeAttribute;
            //      Console.WriteLine(aa);
            //  }

            var hasAllowAnonymous = context.ActionDescriptor.EndpointMetadata
      .Any(em => em.GetType() == typeof(AllowAnonymousAttribute));
            if (hasAllowAnonymous)
            {
                // do something
                return;
            }

            if (context.Filters.Any(item => item is IAllowAnonymousFilter))
            {
                // 如果应用了 AllowAnonymous 特性，则跳过授权检查
                return;
            }


            var authorizationHeader = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            if (authorizationHeader == null)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var token = authorizationHeader;//.Substring("Bearer ".Length).Trim();
            var arrClaims = GetClaimsFromToken(token);
            Console.WriteLine(arrClaims);
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(token);
                string secretKey = ConfigHelper.GetSectionValue("JwtSettings:SigningKey");
                // JWT token validation parameters
                var jwtSigningKey = ConfigHelper.GetSectionValue("JwtSettings:SigningKey"); // Replace with your own secret key
                var jwtIssuer = ConfigHelper.GetSectionValue("JwtSettings:Issuer"); // Replace with your own issuer
                var jwtAudience = ConfigHelper.GetSectionValue("JwtSettings:Audience"); // Replace with your own audience


                var signingKey = Encoding.ASCII.GetBytes(secretKey);
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(signingKey),
                    ValidateIssuer = false,
                    ValidIssuer = jwtIssuer,//"your-issuer",
                    ValidateAudience = false,
                    ValidAudience = jwtAudience, //   "your-audience",
                    //ValidateLifetime = true,
                    //ClockSkew = TimeSpan.Zero
                };
                //bool bolResult = IsTokenValid(token, tokenValidationParameters);
                //if (bolResult == false)
                //{
                //    throw new SecurityTokenException("Invalid token");
                //}
                SecurityToken securityToken;
                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);

                if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                {
                    throw new SecurityTokenException("Invalid token");
                }
                string strUserName = GetUserNameFromToken(token, secretKey);
                // 输出调试信息

                Console.WriteLine("UserName:", strUserName);
                _logger.Information("UserName:", strUserName);

                context.HttpContext.User = principal;

                //base.OnAuthorization(context);
            }
            catch (SecurityTokenException)
            {
                context.Result = new UnauthorizedResult();
                return;
            }
        }
        // 验证token并解析Payload部分
        public string GetUserNameFromToken(string token, string secretKey)
        {
            // 配置TokenValidationParameters
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };

            // 验证token
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var claimsPrincipal = jwtTokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);

            // 从Payload部分获取用户名
            var userName = claimsPrincipal.FindFirst(ClaimTypes.Name)?.Value;

            return userName;
        }
        public static bool IsTokenValid(string token, TokenValidationParameters validationParameters)
        {
            var handler = new JwtSecurityTokenHandler();
            try
            {
                var claimsPrincipal = handler.ValidateToken(token, validationParameters, out var validatedToken);
                return true;
            }
            catch (SecurityTokenException)
            {
                return false;
            }
        }
        public static IEnumerable<Claim> GetClaimsFromToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            return jwtToken.Claims;
        }
    }

}
