using Microsoft.AspNetCore.Mvc;

namespace AGCWA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyCalc2Controller : ControllerBase
    {
        //public class MyCalcApiController : ApiController
        //{
       
        [HttpGet("Test")]
        public ActionResult Test()
        {
            //Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("a", a.ToString());
            //dictParam.Add("b", b.ToString());
            //clsPubFun_WebApi.Log4Debug(this, "Plus", dictParam);
            //var c = a + b;
            return Ok(new { T = "aa", b = "测试成功" });

        }
        [HttpGet("Plus3")]
        public ActionResult<int> Plus3(int a, int b)
        {
            //Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("a", a.ToString());
            //dictParam.Add("b", b.ToString());
            //clsPubFun_WebApi.Log4Debug(this, "Plus", dictParam);
            var c = a + b;
            return c;
            //return Json(new { success = true, status = 0, message = c.ToString() }); ;

        }


        //调用正确：http://localhost:44342/AgcWA/MyCalc2/Test2
        [HttpGet("Test2")]
        public ActionResult<string> Test2()
        {
            //Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("a", a.ToString());
            //dictParam.Add("b", b.ToString());
            //clsPubFun_WebApi.Log4Debug(this, "Plus", dictParam);
            //var c = a + b;
            return "测试成功2";
        }
     
        [HttpPost("Plus2")]
        public int Plus2([FromBody] string value)
        {
            string strA = value;// 
            //string strB = HttpContext.Current.Request.Form[0];
            int a = 11;
            int b = 22;
            return a + b;
        }
                
        [HttpGet("Plus/{a},{b}")]
        public ActionResult<int> Plus(int a, int b)
        {
            return a + b;
        }
        [HttpGet("Minus")]
        public int Minus(int a, int b)
        {
            return a - b;
        }

        [HttpGet("Multiply")]
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        [HttpGet("Divided")]
        public int Divided(int a, int b)
        {
            return a / b;
        }

      
    }
   
}