using AGCWA.PubFun;
using com.taishsoft.common;
using Comm.PubFun;
using Comm.WebApi;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace UserAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class accountController : ControllerBase
    {
        //private readonly int _captchaWidth = 120;
        //private readonly int _captchaHeight = 40;
        //private readonly int _captchaCodeLength = 4;
        //private readonly string _captchaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        private readonly Random _random = new Random();
        const string CAPTCHA_CACHE_KEY = "Captcha_Image";
        private readonly IMemoryCache _cache;
        private readonly ILogger<accountController> _logger;
        public accountController(IMemoryCache memoryCache, ILogger<accountController> logger)
        {
            _cache = memoryCache;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }



        //[HttpGet]
        //public IActionResult GetCaptchaImage([FromServices] IMemoryCache memoryCache)
        //{
        //    string captchaCode = GenerateCaptchaCode(4);
        //    byte[] captchaBytes = GenerateCaptchaImage(captchaCode);
        //    memoryCache.Set("Captcha", captchaCode, TimeSpan.FromMinutes(5));
        //    return File(captchaBytes, "image/jpeg");
        //}


        /// <summary>
        /// 新的方法，解决全黑，字符和背景一样的颜色
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        //[AllowAnonymous]
        [HttpGet("info")]
        public IActionResult info()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
                
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            var userName = HttpContext.User.Identity.Name;
            if (userName == null)
            {
                string strMsg = $"HttpContext.User.Identity.Name 为null, 请检查！";
                _logger.LogInformation($"用户身份为空");
                return Ok(new
                {
                    data = "",
                    code = 201,
                    message = strMsg
                });
            }
            _logger.LogInformation($"用户身份: {userName}");
            var ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
            string strCondition = string.Format("{0}='{1}'", conQxUsersV2.UserName, userName);
            var objQxUsersV2 = clsQxUsersV2BL.GetFirstObj_S(strCondition);
            if (objQxUsersV2 == null)
            {
                return Ok(new
                {
                    data = "",
                    code = 201,
                    message = "fail"
                });
            }
            // 封装数据结构
            var result = new
            {
                data = new
                {
                    email = objQxUsersV2.Email==null?"": objQxUsersV2.Email,// "qa894178522@qq.com",
                    headImg = objQxUsersV2.headImg == null ? "" : objQxUsersV2.headImg,// "https://buqiyuan.gitee.io/img/logo.jpg",
                    loginIp = ipAddress,//"180.158.97.113",
                    name = objQxUsersV2.name,//"路飞",
                    nickName = objQxUsersV2.nickName == null ? "" : objQxUsersV2.nickName,//"",
                    phone = objQxUsersV2.phone,//"15622472425",
                    remark = objQxUsersV2.remark == null ? "" : objQxUsersV2.remark//"null"
                },
                code = 200,
                message = "success"
            };
            _logger.LogInformation($"获取用户信息成功: {userName}");
            return Ok(result);

        }
        /// <summary>
        /// 新的方法，解决全黑，字符和背景一样的颜色
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [HttpGet("permmenu")]
        public IActionResult permmenu()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            string strQxPrjId = "0005";
            //获取数据的流程
            //1、获取当前用户名userName
            //2、根据用户获取角色
            //3、根据角色获取相关的菜单列表
            var userName = HttpContext.User.Identity.Name;
            var ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
            string strCondition = string.Format("{0}='{1}'", conQxUsersV2.UserName, userName);
            var arrRId = clsQxUserRoleRelationV2BLEx.GetRIdLstByUserName(userName);
            if (arrRId == null || arrRId.Count == 0)
            {
                return Ok(new
                {
                    data = string.Format("登录用户:{0}没有设置相关角色！", userName),
                    code = 201,
                    message = "fail"
                });
            }
            var arrPrjMenusV2 = clsQxRoleMenusV2BLEx.GetObjLstByRIds(arrRId, strQxPrjId);
            List<Object> arrObjs = new List<Object>();
            foreach (var objInFor in arrPrjMenusV2)
            {
                var obj = new
                {
                    createTime = objInFor.createdAt,
                    updateTime = objInFor.updatedAt,
                    id = objInFor.id,
                    parentId = objInFor.parentMenuId,
                    name = objInFor.MenuName,
                    router = objInFor.router,
                    perms = objInFor.perms,
                    /** 当前菜单类型 0: 目录 | 1: 菜单 | 2: 权限 */
                    type = objInFor.type,
                    icon = objInFor.icon,
                    orderNum = objInFor.OrderNum,
                    viewPath = objInFor.viewPath,
                    keepalive = objInFor.keepalive,
                    isShow = objInFor.isShow,
                    /** 是否外链 */
                    isExt = objInFor.isExt,
                    /** 外链打开方式
                     * 1: 新窗口打开
                     * 2: iframe
                     */
                    openMode = objInFor.openMode
                };
                arrObjs.Add(obj);
            }

            List<string> arrPermss = clsQxRolePotenceV2BLEx.GetPotenceNameLstByRIds(arrRId, strQxPrjId);
            // 封装数据结构
            var result = new
            {
                data = new { menus = arrObjs, perms = arrPermss },
                code = 200,
                message = "success"
            };
            return Ok(result);

        }

        [HttpPost("logout")]
        public IActionResult logout()
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            var result = new
            {
                code = 200,
                message = "success"
            };
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginParams model)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            if (model.username != "account" || model.password != "account")
            {
                //return new HttpResult() { Success = false, Message = "用户名和密码不正确！" };
                return Unauthorized(new { message = "Username or password is incorrect" });
            }
            else
            {
                // 获取用户输入的验证码内容和图片ID
                string captchaId = model.captchaId;
                string captchaCode = model.verifyCode;

                // 从缓存中获取验证码
                string cachedCaptcha = _cache.Get<string>(CAPTCHA_CACHE_KEY + captchaId);

                // 比较用户输入的验证码和缓存中的验证码是否一致
                if (model.verifyCode == cachedCaptcha)
                {
                    // 验证通过
                    //return Ok("登录成功！");
                }
                else
                {
                    // 验证码错误
                    return BadRequest("验证码错误！");
                }
            }
            //var user = await _userService.Authenticate(model.Username, model.Password);

            //if (user == null)
            //{
            //    return Unauthorized(new { message = "Username or password is incorrect" });
            //}

            var tokenHandler = new JwtSecurityTokenHandler();
            var strToken = ConfigHelper.GetSectionValue("JwtSettings:SigningKey");
            //var strToken2 = ConfigHelper.GetSectionValue2("JwtSettings:SigningKey");

            var key = Encoding.ASCII.GetBytes(strToken);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim(ClaimTypes.Name, model.username)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            var result = new
            {
                data = new
                {
                    //UserId = model.username,
                    token = tokenString
                },
                code = 200,
                message = "success"
            };
            return Ok(result);
        }
    }
}

