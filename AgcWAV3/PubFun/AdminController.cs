using com.taishsoft.common;
using Comm.PubFun;
using Comm.WebApi;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

using Microsoft.IdentityModel.Tokens;
using Svg;
using System.Drawing;
using System.Drawing.Imaging;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;

namespace UserAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class adminController : ControllerBase
    {
        private readonly int _captchaWidth = 120;
        private readonly int _captchaHeight = 40;
        //private readonly int _captchaCodeLength = 4;
        //private readonly string _captchaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        private readonly Random _random = new Random();
        const string CAPTCHA_CACHE_KEY = "Captcha_Image";
        private readonly IMemoryCache _cache;
        private readonly IConfiguration _configuration;
        private readonly ILogger<adminController> _logger;
        //public adminController(IConfiguration configuration, ILogger<adminController> logger)
        //{            
        //    _configuration = configuration;
        //    _logger = logger;
        //}
        //public adminController(IMemoryCache memoryCache)
        //{
        //    _cache = memoryCache;
        //}

        public adminController(IMemoryCache memoryCache, IConfiguration configuration, ILogger<adminController> logger)
        {
            _cache = memoryCache ?? throw new ArgumentNullException(nameof(memoryCache));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        [HttpGet]
        public IActionResult GetCaptcha()
        {
            var captchaCode = GenerateCaptchaCode(4);
            var imageBytes = GenerateCaptchaImage(captchaCode);
            _cache.Set("captcha-code", captchaCode, TimeSpan.FromMinutes(5));
            return File(imageBytes, "image/jpeg");
        }

        private string GenerateCaptchaCode(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Range(0, length).Select(x => chars[random.Next(chars.Length)]).ToArray());
        }

        private byte[] GenerateCaptchaImageBak(string captchaCode)
        {
            var imageWidth = 120;
            var imageHeight = 40;
            using var bitmap = new Bitmap(imageWidth, imageHeight);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            using var font = new Font("Arial", 20, FontStyle.Bold);
            using var brush = new SolidBrush(Color.Black);
            graphics.DrawString(captchaCode, font, brush, 10, 10);
            using var memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }
        //[HttpGet]
        //public IActionResult GetCaptchaImage([FromServices] IMemoryCache memoryCache)
        //{
        //    string captchaCode = GenerateCaptchaCode(4);
        //    byte[] captchaBytes = GenerateCaptchaImage(captchaCode);
        //    memoryCache.Set("Captcha", captchaCode, TimeSpan.FromMinutes(5));
        //    return File(captchaBytes, "image/jpeg");
        //}



        private byte[] GenerateCaptchaImage(string captchaCode)
        {
            int width = 160;
            int height = 40;
            using (var bitmap = new Bitmap(width, height))
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
                using (var pen = new Pen(Color.LightGray, 1))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int x1 = RandomNumber(0, width);
                        int y1 = RandomNumber(0, height);
                        int x2 = RandomNumber(0, width);
                        int y2 = RandomNumber(0, height);
                        graphics.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
                using (var font = new Font("Arial", 18))
                using (var brush = new SolidBrush(Color.Black))
                {
                    graphics.DrawString(captchaCode, font, brush, 25, 8);
                }
                using (var memoryStream = new MemoryStream())
                {
                    bitmap.Save(memoryStream, ImageFormat.Jpeg);
                    return memoryStream.ToArray();
                }
            }
        }

        private int RandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        /// <summary>
        /// 新的方法，解决全黑，字符和背景一样的颜色
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("captchaImg2")]
        public IActionResult captchaImg2(int width = 100, int height = 40)
        {
            // 生成随机字符串
            string captchaText = GenerateRandomString(4);

            // 创建缓存位图
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            // 创建Graphics对象
            Graphics graphics = Graphics.FromImage(bmp);

            // 填充背景
            graphics.FillRectangle(Brushes.White, 0, 0, width, height);

            // 添加噪点
            Random random = new Random();
            for (int i = 0; i < width * height / 50; i++)
            {
                int x = random.Next(width);
                int y = random.Next(height);
                bmp.SetPixel(x, y, Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
            }

            // 绘制字符
            for (int i = 0; i < captchaText.Length; i++)
            {
                // 随机颜色
                Color color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));

                // 绘制字符
                Font font = new Font(FontFamily.GenericSerif, 20, FontStyle.Bold);
                graphics.DrawString(captchaText[i].ToString(), font, new SolidBrush(color), i * 20, random.Next(10, 20));
            }

            // 将验证码添加到缓存
            string captchaKey = Guid.NewGuid().ToString();
            _cache.Set(captchaKey, captchaText, TimeSpan.FromMinutes(5));
            HttpContext.Response.Cookies.Append("captchaKey", captchaKey);

            // 将图像转换为流并返回
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
            return File(ms.ToArray(), "image/jpeg");
        }

        private static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        [AllowAnonymous]
        [HttpGet("test")]
        public ActionResult test()
        {
            //调用方法：~/api/MyCalc/Plus?a=2&b=3
            var returnStr = "Hello world!";
            return Ok(new { errorId = 0, errorMsg = "", ReturnStr = returnStr });
        }

        [HttpGet("GenerateCaptchaImage")]
        public IActionResult GenerateCaptchaImage(int width = 100, int height = 40)
        {
            // 生成验证码
            string captchaCode = GenerateCaptchaCode(4);

            // 将验证码保存到缓存中
            _cache.Set(CAPTCHA_CACHE_KEY, captchaCode, TimeSpan.FromMinutes(3));

            // 创建 Bitmap 对象
            Bitmap bitmap = new Bitmap(width, height);

            // 获取 Graphics 对象
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                //using var font = new Font("Arial", 20, FontStyle.Bold);
                //using var brush = new SolidBrush(Color.Black);
                //graphics.DrawString(captchaCode, font, brush, 10, 10);

                // 绘制验证码字符串
                graphics.DrawString(captchaCode, new Font("Arial", 20), Brushes.Black, new PointF(0, 0));
            }

            // 将 Bitmap 对象转换为 MemoryStream
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Jpeg);

            // 将验证码图片作为字节数组返回
            return File(ms.ToArray(), "image/jpeg");
        }
        //[EnableCors("AllowSpecificOrigin")]
        [AllowAnonymous]
        [HttpPost("loginBak")]
        public async Task<IActionResult> LoginBak(LoginParams model)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();

            dictParam.Add("c-Bak-aptchaId", model.captchaId);
            dictParam.Add("password", model.password);
            dictParam.Add("username", model.username);
            dictParam.Add("verifyCode", model.verifyCode);


            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            string strCondition = $"{conQxUsersV2.UserName}='{model.username}'";
            clsQxUsersV2EN objQxUsersV2EN = clsQxUsersV2BL.GetFirstObj_S(strCondition);
            if (objQxUsersV2EN == null)
            {
                return Unauthorized(new { message = $"Username:{model.username} 不存在！" });
            }
            if (objQxUsersV2EN.Password != model.password)
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
                if (cachedCaptcha != null)
                {

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

            // return basic user info and authentication token
            //return Ok(new
            //{
            //    UserId = model.username,
            //    Token = tokenString
            //});

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
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginParams model)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            strFunctionName = "adminController-Login";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();

            dictParam.Add("captchaId", model.captchaId);
            dictParam.Add("password", model.password);
            dictParam.Add("username", model.username);
            dictParam.Add("verifyCode", model.verifyCode);

            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            string strCondition = $"{conQxUsersV2.UserName}='{model.username}'";
            clsQxUsersV2EN objQxUsersV2EN = clsQxUsersV2BL.GetFirstObj_S(strCondition);
            if (objQxUsersV2EN == null)
            {
                return Unauthorized(new { message = $"Username:{model.username} 不存在！" });
            }
            if (objQxUsersV2EN.Password != model.password)
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
                if (cachedCaptcha != null)
                {

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
            }

            // 生成JWT token
            var tokenString = GenerateJwtToken(model.username);
            _logger.LogInformation($"用户登录: User logged in: {model.username}");
            // 设置HttpContext.User
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, model.username),
        // 其他需要的声明
    };
            var identity = new ClaimsIdentity(claims, "login");
            HttpContext.User = new ClaimsPrincipal(identity);

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

        private string GenerateJwtToken(string userId)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var strToken = ConfigHelper.GetSectionValue("JwtSettings:SigningKey");
                var key = Encoding.ASCII.GetBytes(strToken);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim(ClaimTypes.Name, userId)
                }),
                    Expires = DateTime.UtcNow.AddHours(7),
                    Issuer = ConfigHelper.GetSectionValue("JwtSettings:Issuer"),
                    Audience = ConfigHelper.GetSectionValue("JwtSettings:Audience"),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {
                // 记录错误日志
                //Console.WriteLine($"Error generating JWT token: {ex.Message}");
                _logger.LogError(ex, "生成JWT信息出错:Error generating JWT token");
                throw;
            }
        }
        //public string GenerateJwtToken(string userId, string secretKey, string issuer, string audience)
        //{
        //    try
        //    {
        //        var tokenHandler = new JwtSecurityTokenHandler();
        //        var key = Encoding.ASCII.GetBytes(secretKey);
        //        var tokenDescriptor = new SecurityTokenDescriptor
        //        {
        //            Subject = new ClaimsIdentity(new[] {
        //        new Claim("id", userId)
        //    }),
        //            Expires = DateTime.UtcNow.AddHours(1),
        //            Issuer = issuer,
        //            Audience = audience,
        //            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //        };
        //        var token = tokenHandler.CreateToken(tokenDescriptor);
        //        var tokenString = tokenHandler.WriteToken(token);
        //        return tokenString;
        //    }
        //    catch (Exception ex)
        //    {
        //        // 记录错误日志
        //        Console.WriteLine($"Error generating JWT token: {ex.Message}");
        //        throw;
        //    }
        //}
        /// <summary>
        /// 提供captchaId和图片服务
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("GetCaptchaImage")]
        public IActionResult GetCaptchaImage()
        {
            var captchaCode = GenerateCaptchaCode();
            var imageBytes = GenerateCaptchaImage(captchaCode);
            var captchaId = Guid.NewGuid().ToString("N");

            // 将验证码图片和验证码 ID 缓存到内存缓存中
            _cache.Set(captchaId, captchaCode, new MemoryCacheEntryOptions()
            {
                // 设置过期时间
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            });

            // 返回包含验证码图片和验证码 ID 的响应
            return new ObjectResult(new
            {
                captchaId = captchaId,
                captchaImage = Convert.ToBase64String(imageBytes)
            });
        }

        private string GenerateCaptchaCode()
        {
            // 生成随机验证码
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var captchaCode = new string(Enumerable.Repeat(chars, 4)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            return captchaCode;
        }

        //private byte[] GenerateCaptchaImage(string captchaCode)
        //{
        //    // 生成验证码图片
        //    var image = new Bitmap(100, 40);
        //    var graphics = Graphics.FromImage(image);
        //    graphics.Clear(Color.LightGray);
        //    graphics.DrawString(captchaCode, new Font("Arial", 20), Brushes.Black, new PointF(10, 10));
        //    var stream = new MemoryStream();
        //    image.Save(stream, ImageFormat.Jpeg);
        //    return stream.ToArray();
        //}
        [AllowAnonymous]
        [HttpGet("captchaImg")]
        //[EnableCors("AllowSpecificOrigin")]
        public IActionResult captchaImg([FromQuery] int width = 100, int height = 39)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();

            dictParam.Add("width", width.ToString());
            dictParam.Add("height", height.ToString());

            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            // Generate captcha code
            string captchaCode = GenerateCaptchaCode();
            var captchaId = Guid.NewGuid().ToString("N");
            _cache.Set<string>(CAPTCHA_CACHE_KEY + captchaId, captchaCode, TimeSpan.FromMinutes(5));
            // Generate captcha image
            SvgDocument svgDocument = GenerateCaptchaImageV2(captchaCode, width, height);

            // Convert SVG document to Base64 string
            string svgString = ConvertSvgToBase64String(svgDocument);

            // Return captcha code and image as JSON object
            //            return Ok(new { CaptchaId = Guid.NewGuid(), CaptchaCode = captchaCode, CaptchaImage = svgString });
            //return Ok(new { id = captchaId, img = svgString});
            _logger.LogInformation($"获取校验码:{captchaCode},图像信息: {svgString}");
            // 封装数据结构
            var result = new
            {
                data = new { img = svgString, id = captchaId },
                code = 200,
                message = "success"
            };
            return Ok(result);
        }
        /// <summary>
        /// 带干扰信息
        /// </summary>
        /// <param name="captchaCode"></param>
        /// <returns></returns>
        private SvgDocument GenerateCaptchaImageV2(string captchaCode, int intWidth = 100, int intHeight = 40)
        {
            // Create SVG document
            SvgDocument svgDocument = new SvgDocument();

            // 添加一个随机背景色的矩形
            var background = new SvgRectangle()
            {
                Width = new SvgUnit(SvgUnitType.Percentage, intWidth),
                Height = new SvgUnit(SvgUnitType.Percentage, intHeight),
                Fill = new SvgColourServer(Color.White)
            };
            svgDocument.Children.Add(background);
            // Create SVG text element

            var random = new Random();
            var text = new SvgText()
            {
                FontFamily = "Arial",//new SvgFont(new FontFamily(), 16),
                FontSize = 16,
                Fill = new SvgColourServer(Color.Black),
                Stroke = null,
                Text = captchaCode,
                X = new SvgUnitCollection() { new SvgUnit(SvgUnitType.Percentage, 0) },
                Y = new SvgUnitCollection() { new SvgUnit(SvgUnitType.Percentage, 50) }
            };
            for (int i = 0; i < captchaCode.Length; i++)
            {
                var dx = random.Next(-10, 10);
                var dy = random.Next(-10, 10);
                var line = new SvgLine()
                {
                    StartX = new SvgUnit(SvgUnitType.Pixel, (i * 20) + 10 + dx),
                    StartY = new SvgUnit(SvgUnitType.Percentage, 50 + dy),
                    EndX = new SvgUnit(SvgUnitType.Pixel, (i * 20) + 10 + dx),
                    EndY = new SvgUnit(SvgUnitType.Percentage, 60 + dy),
                    Stroke = new SvgColourServer(Color.Blue),
                    StrokeWidth = new SvgUnit(SvgUnitType.Pixel, 1),
                    StrokeDashArray = new SvgUnitCollection() { new SvgUnit(SvgUnitType.Pixel, 1), new SvgUnit(SvgUnitType.Pixel, 2) }
                };
                text.Children.Add(line);
            }
            svgDocument.Children.Add(text);

            // Set SVG document width and height
            svgDocument.Width = new SvgUnit(SvgUnitType.Pixel, _captchaWidth);
            svgDocument.Height = new SvgUnit(SvgUnitType.Pixel, _captchaHeight);

            return svgDocument;
        }

        private string ConvertSvgToBase64String(SvgDocument svgDocument)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                // Write SVG document to stream
                svgDocument.Write(stream, true);

                // Convert stream to byte array
                byte[] bytes = stream.ToArray();

                // Convert byte array to Base64 string
                string base64String = Convert.ToBase64String(bytes);

                // Return Base64 string
                return "data:image/svg+xml;base64," + base64String;
            }
        }
    }
}

