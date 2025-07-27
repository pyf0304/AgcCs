using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AgcWA.Test
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static async Task Invoke(HttpContext context)
        {
            HttpRequest request = context.Request;
            Stream straem = request.Body;
            Encoding encoding = Encoding.UTF8;
            string date = string.Empty;
            using (StreamReader reader = new StreamReader(straem, encoding))
            {
                //date就是post传过来的值json格式
                date = reader.ReadToEndAsync().Result;
            }
        }

        //[Fact]
        private void WebApiTest_AddProduct()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:1661/");

                var requestJson = JsonConvert.SerializeObject(
                    new
                    {
                        id = "1",
                        name = "2"
                    });

                HttpContent httpContent = new StringContent(requestJson);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var result = client.PostAsync("api/Product/AddProduct", httpContent).Result.Content.ReadAsStringAsync().Result;
            }
        }

        //public static async Task<(bool, string)> HttpPostAsyncOptimizeFormUrl(string requestUrl, Dictionary<string, string> dicUrl)
        //{
        //    try
        //    {
        //        using (HttpClient httpClient = new HttpClient())
        //        {
        //            StringBuilder builder = new StringBuilder();
        //            int i = 0;
        //            foreach (var item in dicUrl)
        //            {
        //                if (i > 0)
        //                    builder.Append("&");
        //                builder.AppendFormat("{0}={1}", item.Key, item.Value);
        //                i++;
        //            }
        //            var responseResult = httpClient.PostAsync(requestUrl, new StringContent(builder.ToString(), System.Text.Encoding.UTF8, "application/x-www-form-urlencoded")).Result;
        //            if (responseResult.StatusCode == HttpStatusCode.OK)
        //            {
        //                return (true, await responseResult.Content.ReadAsStringAsync());
        //            }
        //            else
        //            {
        //                return (false, $"接口地址返回错误状态码:{responseResult.StatusCode}");
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        //[HttpPost("Tel/FromFormTest")]
        //public async Task<ActionResult<ResponseMessageWrap<string>>> FromFormTest([FromForm] TelOutPos telOutPos)
        //{
        //    await Task.CompletedTask;
        //    return new ResponseMessageWrap<string> { Data = telOutPos.agNo };
        //}

        //[HttpPost]
        //public async Task<string> Post1()
        //{
        //    //StreamReader sr = new StreamReader(Request.Body);
        //    //string data = await sr.ReadToEndAsync();

        //    string data = "";

        //    //Request.EnableBuffering();可以实现多次读取Body
        //    Request.EnableBuffering();
        //    StreamReader sr = new StreamReader(Request.Body);
        //    data = await sr.ReadToEndAsync();
        //    logger.LogInformation("data=" + data);
        //    Request.Body.Seek(0, SeekOrigin.Begin);

        //    //再次读取 依然可以成功读到
        //    Request.EnableBuffering();
        //    StreamReader sr2 = new StreamReader(Request.Body);
        //    string data2 = await sr2.ReadToEndAsync();
        //    logger.LogInformation("data2=" + data2);
        //    Request.Body.Seek(0, SeekOrigin.Begin);


        //    string header = $"请求头:\r\n";
        //    foreach (var item in Request.Headers)
        //    {
        //        header += $"{item.Key}:{item.Value}\r\n";
        //    }
        //    logger.LogInformation(header);

        //    var ip = Request.Headers["X-Forwarded-For"].FirstOrDefault();
        //    if (string.IsNullOrEmpty(ip))
        //    {
        //        //ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
        //        //ip = Request.HttpContext.Connection.LocalIpAddress.MapToIPv4().ToString();
        //        ip = Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        //    }
        //    logger.LogInformation("ip=" + ip);

        //    //...
        //}
    }
}
