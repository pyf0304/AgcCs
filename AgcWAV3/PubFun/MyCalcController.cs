
using AGCWA.PubFun;
using com.taishsoft.json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; using Comm.WebApi;
using System.Threading.Tasks;

namespace AgcWA.Controllers
{
    public class myObject
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string JsonStr { get; set; }


    }
    public class myObject2
    {
        public string AAA { get; set; }
        public string BBB { get; set; }


    }
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
    //public class TodoItem
    //{
    //    public long Id { get; set; }
    //    public string? Name { get; set; }
    //    public bool IsComplete { get; set; }
    //    public string? Secret { get; set; }
    //}
    [ApiController]
    [Route("[controller]")]
    public class MyCalcApiController : ControllerBase
    {
      
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            //_context.TodoItems.Add(todoItem);
            //await _context.SaveChangesAsync();
            string ss = todoItem.Name;
            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
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
        [ApiAuthorize]
        [HttpGet("Plus")]
        public int Plus(int a, int b)
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

        [HttpPost("TestJSON")]
        public string TestJSON([FromBody] myObject rb)
        {
            string strMsg = string.Format("firstName={0}, lastName={1}, JsonStr={2}",
                rb.firstName, rb.lastName, rb.JsonStr);
            //lblMsg1.Text = strMsg;
            myObject2 obj2 = JsonConvert.DeserializeObject<myObject2>(rb.JsonStr);
            //JsonObjectAttribute.JsonObjectAttribute("");
            JObject objJ1 = JObject.Parse(rb.JsonStr);
            string objAAA = objJ1["AAA"].ToString();
            //JSONObject Json = new JSONObject();
            //JSONArray JsonArray = new JSONArray();
            //Json.put("key", "value");//JSONObject对象中添加键值对 


            return strMsg;
        }
        [HttpPost("TestException")]
        public ActionResult TestException([FromBody] myObject rb)
        {
            string strMsg = string.Format("firstName={0}, lastName={1}, JsonStr={2}",
                rb.firstName, rb.lastName, rb.JsonStr);
            //lblMsg1.Text = strMsg;
            myObject2 obj2 = JsonConvert.DeserializeObject<myObject2>(rb.JsonStr);
            //JsonObjectAttribute.JsonObjectAttribute("");
            JObject objJ1 = JObject.Parse(rb.JsonStr);
            string objAAA = objJ1["AAA"].ToString();
            JObject jObj = new JObject();
            jObj["ErrorId"] = "0";
            jObj["ErrorMsg"] = "";
            jObj["returnStr"] = "";
            jObj["ObjStr"] = "{'AAA':'111', 'BBB':'222'}";

            string jsonText = jObj.ToString();
            //JSONObject Json = new JSONObject();
            //JSONArray JsonArray = new JSONArray();
            //Json.put("key", "value");//JSONObject对象中添加键值对 
            if (objAAA == "111")
            {
                jObj["ErrorId"] = "1";
                jObj["ErrorMsg"] = "Return TestException";
                jObj["returnStr"] = "";
                //jsonText = jObj.ToString();

                return Ok(new { errorId = 0, errorMsg = "", returnStr = "true" });
                //throw new Exception("Return TestException");
            }

            return Ok(new { errorId = 0, errorMsg = "Return TestException", returnStr = strMsg });
            //            return strMsg;
        }
  
       
        [HttpGet("Test")]
        public string Test()
        {
            return "测试成功";
        }
       
       
    }
}