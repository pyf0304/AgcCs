using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgcWA.WebApi
{

    public class MyJsonConvert<T> where T : class
    {
        #region 转换
        /// <summary>
        /// json参数 转对象
        /// </summary>
        /// <param name="json">json参数</param>
        /// <returns></returns>
        public T ToObj(string json)
        {
            T parameter = null;
            try
            {
                //参数为空
                if (string.IsNullOrEmpty(json) || json == "")
                {
                    return null;
                }

                parameter = Activator.CreateInstance<T>();
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
                {
                    DataContractJsonSerializer dcj = new DataContractJsonSerializer(typeof(T));
                    parameter = (T)dcj.ReadObject(ms);
                }

                if (parameter == null)
                    throw new Exception("参数错误");
            }
            catch (Exception e)
            {
                throw new Exception("参数错误:" + e.Message);
            }

            return parameter;
        }

        /// <summary>/// 
        /// 对象 转 json 
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public string ToJson(T obj)
        {
            string jsonStr;
            if (obj is string || obj is char)
            {
                jsonStr = obj.ToString();
            }
            else
            {
                //对象 转json
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(T));
                using (MemoryStream stream = new MemoryStream())
                {
                    json.WriteObject(stream, obj);
                    jsonStr = Encoding.UTF8.GetString(stream.ToArray());
                }

                //jsonStr = new JavaScriptSerializer().Serialize(obj);
            }

            //时间格式化
            jsonStr = Regex.Replace(jsonStr, @"\\/Date\((\d+)\)\\/", match =>
            {
                DateTime dt = new DateTime(1970, 1, 1);
                dt = dt.AddMilliseconds(long.Parse(match.Groups[1].Value));
                dt = dt.ToLocalTime();
                return dt.ToString("yyyy-MM-dd HH:mm:ss");
            });

            return jsonStr;
        }
        #endregion


        /// <summary>
        /// 校验
        /// </summary>
        /// <param name="json">参数json</param>
        /// <param name="verifyFiled">要判定的字段</param>
        /// <param name="msg">返回内容</param>
        /// <returns></returns>
        //public bool Verify(T parameter, string[] verifyFiled)
        //{
        //    if (parameter == null)
        //    {
        //        throw new Exception("参数错误");
        //    }
        //    else
        //    {
        //        Type t = parameter.GetType();//获得该类的Type
        //        foreach (string filed in verifyFiled)
        //        {
        //            //查询 当前要判定的属性
        //            PropertyInfo pi = t.GetProperties().Where(p => p.Name == filed).FirstOrDefault();
        //            if (pi != null)
        //            {
        //                object value = pi.GetValue(parameter, null);//用pi.GetValue获得值

        //                switch (pi.Name)
        //                {
        //                    case "UserId":
        //                        IsInt(value);
        //                        break;
        //                    case "Mobile":
        //                        IsMobile(value);
        //                        break;
        //                    case "CardInfo":
        //                        IsCardInfo(value);
        //                        break;
        //                    default:
        //                        IsNull(value);
        //                        break;
        //                }
        //            }
        //        }

        //        return true;
        //    }
        //}


        /// <summary>
        /// return httpResponse
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        //public HttpResponseMessage ToHttpResponse(string val)
        //{
        //    HttpResponseMessage result = new HttpResponseMessage
        //    {
        //        Content = new StringContent(val, Encoding.GetEncoding("UTF-8"),
        //         "application/json"),
        //    };

        //    return result;
        //}
    }

}
