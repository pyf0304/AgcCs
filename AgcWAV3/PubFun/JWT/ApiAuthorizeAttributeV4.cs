using Comm.PubFun;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AgcWA.Controllers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiAuthorizeAttributeV4 : Attribute, IAuthorizationFilter
    {
        private readonly ILogger<ApiAuthorizeAttributeV4> _logger;

        //private readonly ILogger _logger;

        public ApiAuthorizeAttributeV4(ILogger<ApiAuthorizeAttributeV4> logger)
        {
            _logger = logger;
        }
        //public ApiAuthorizeAttributeV4()
        //{
        //    //_logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        //    //_logger = new LoggerConfiguration()
        //    //    .WriteTo.Console()
        //    //    .MinimumLevel.Information() // 设置日志级别
        //    //    .CreateLogger();
        //    _logger = Log.ForContext<ApiAuthorizeAttributeV4>();
        //}

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var request = context.HttpContext.Request;

            // 假设 Windows 调用使用一个自定义的 User-Agent 或者来自某些特定的 IP
            var userAgent = request.Headers["User-Agent"].ToString();
            var remoteIpAddress = context.HttpContext.Connection.RemoteIpAddress?.ToString();

            // 假设我们认为 User-Agent 包含 "WindowsApp" 的请求为 Windows 调用，无需授权
            if (userAgent.Contains("WindowsApp"))
            {
                return;
            }

            var actionName = context.ActionDescriptor.DisplayName;
            _logger.LogInformation("授权过滤:Authorization filter executing. actionName: {ActionName}", actionName);

            var hasAllowAnonymous = context.ActionDescriptor.EndpointMetadata
                .Any(em => em.GetType() == typeof(AllowAnonymousAttribute));

            if (hasAllowAnonymous || context.Filters.Any(item => item is IAllowAnonymousFilter))
            {
                _logger.LogInformation("可匿名访问: {ActionName}", actionName);
                return;
            }

            var authorizationHeader = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            if (authorizationHeader == null)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var token = authorizationHeader.StartsWith("Bearer ") ? authorizationHeader.Substring("Bearer ".Length).Trim() : authorizationHeader;

            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(token);
                string secretKey = ConfigHelper.GetSectionValue("JwtSettings:SigningKey");

                if (string.IsNullOrEmpty(secretKey) || secretKey.Length < 32)
                {
                    throw new SecurityTokenException("Invalid Signing Key");
                }

                var signingKey = Encoding.ASCII.GetBytes(secretKey);
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(signingKey),
                    ValidateIssuer = true,
                    ValidIssuer = ConfigHelper.GetSectionValue("JwtSettings:Issuer"),
                    ValidateAudience = true,
                    ValidAudience = ConfigHelper.GetSectionValue("JwtSettings:Audience"),
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };

                SecurityToken securityToken;
                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);

                if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                {
                    throw new SecurityTokenException("Invalid token");
                }

                string strUserName = GetUserNameFromToken(token, secretKey);

                _logger.LogInformation("用户名: {UserName}", strUserName);

                context.HttpContext.User = principal;
            }
            catch (SecurityTokenException ex)
            {
                _logger.LogError(ex, "令牌验证失败");
                context.Result = new UnauthorizedResult();
                return;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "授权出错:An error occurred during authorization");
                context.Result = new UnauthorizedResult();
                return;
            }
        }

        public string GetUserNameFromToken(string token, string secretKey)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };

            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var claimsPrincipal = jwtTokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);

            return claimsPrincipal.FindFirst(ClaimTypes.Name)?.Value;
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
