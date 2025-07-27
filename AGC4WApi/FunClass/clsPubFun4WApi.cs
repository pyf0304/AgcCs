
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.file;

namespace AGC4WApi
{
    /// <summary>
    /// 针对转换类的公共类函数
    /// </summary>
    public class clsPubFun4WApi
    {
        public static IDictionary<string, clsUserCodePrjMainPathEN> dicKey_UserCodePrjMainPath = null;

        /// <summary>
        /// 获取Web服务的地址
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        public static string GetWebApiUrlBak(string strApiControllerName, string strAction)
        {
            String strServiceUrl = String.Empty;

            if (clsSysPara4WebApi_Agc.bolIsLocalHost == false)
            {

                strServiceUrl = String.Format("{0}/{1}/api/{2}/{3}",
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort, clsSysPara4WebApi_Agc.strCurrPrx, strApiControllerName, strAction);

            }
            else
            {
                strServiceUrl = String.Format("{0}/{1}/api/{2}/{3}",
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort_Local,
                    clsSysPara4WebApi_Agc.strCurrPrx,
                    strApiControllerName, strAction);

            }
            return strServiceUrl;
        }


        public static string GetWebApiUrl(string strApiControllerName, string strAction)
        {
            String strServiceUrl = String.Empty;

            if (clsSysPara4WebApi_Agc.bolIsLocalHost == false)
            {
                if (string.IsNullOrEmpty(clsSysPara4WebApi_Agc.strCurrPrx))
                {
                    strServiceUrl = String.Format("{0}/{1}/{2}",
                     clsSysPara4WebApi_Agc.strCurrIPAddressAndPort_Local,
                     strApiControllerName, strAction);
                }
                else
                {
                    strServiceUrl = String.Format("{0}/{1}/{2}/{3}",
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort, clsSysPara4WebApi_Agc.strCurrPrx, strApiControllerName, strAction);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(clsSysPara4WebApi_Agc.strCurrPrx))
                {
                    strServiceUrl = String.Format("{0}/{1}/{2}",
                     clsSysPara4WebApi_Agc.strCurrIPAddressAndPort_Local,
                     strApiControllerName, strAction);
                }
                else
                {
                    strServiceUrl = String.Format("{0}/{1}/{2}/{3}",
                        clsSysPara4WebApi_Agc.strCurrIPAddressAndPort_Local,
                        clsSysPara4WebApi_Agc.strCurrPrx,
                        strApiControllerName, strAction);
                }
            }
            return strServiceUrl;
        }


        /// <summary>
        /// 生成最终URL
        /// </summary>
        /// <param name="strApiControllerName">基准URL（不含查询串）</param>
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <returns>最终URL</returns>
        public static string GetLastUrl(string strApiControllerName, string strAction, Dictionary<string, string> dictParam)
        {
            //string baseUrl = GetServiceUrl();
            string strWebApiUrl = GetWebApiUrl(strApiControllerName, strAction);
            var sbUrl = new StringBuilder(strWebApiUrl);
            if (dictParam != null && dictParam.Count > 0)
            {
                sbUrl.Append("?");
                int index = 0;
                foreach (var item in dictParam)
                {
                    sbUrl.Append(string.Format("{0}={1}", item.Key,
                        HttpUtility.UrlEncode(item.Value, Encoding.UTF8)));
                    if (index < dictParam.Count - 1)
                    {
                        sbUrl.Append("&");
                    }
                    index++;
                }
            }
            var url = sbUrl.ToString();
            return url;
        }


        /// <summary>
        /// 生成最终URL
        /// </summary>
        /// <param name="strApiControllerName">基准URL（不含查询串）</param>
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <returns>最终URL</returns>
        public static string GetLastUrl4Delete(string strApiControllerName, string strAction, string id)
        {
            //string baseUrl = GetServiceUrl();
            string strWebApiUrl = GetWebApiUrl(strApiControllerName, strAction);
            var sbUrl = new StringBuilder(strWebApiUrl);
            if (string.IsNullOrEmpty(id) == false)
            {
                sbUrl.AppendFormat("?Id={0}", id);
            }
            else
            {
                throw new Exception("删除WebApi时id不能为空！");
            }
            var url = sbUrl.ToString();
            return url;
        }
        /// <summary>
        /// 生成最终URL
        /// </summary>
        /// <param name="strApiControllerName">基准URL（不含查询串）</param>
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <returns>最终URL</returns>
        public static string GetLastUrl4DeleteBak(string strApiControllerName, string strAction, string id)
        {
            //string baseUrl = GetServiceUrl();
            string strWebApiUrl = GetWebApiUrl(strApiControllerName, strAction);
            var sbUrl = new StringBuilder(strWebApiUrl);
            if (string.IsNullOrEmpty(id) == false)
            {
                sbUrl.AppendFormat("/{0}", id);
            }
            else
            {
                throw new Exception("删除WebApi时id不能为空！");
            }
            var url = sbUrl.ToString();
            return url;
        }
        /// <summary>
        /// GET方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>        
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Get(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var tmpResult = client.GetAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {              
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Get)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Get)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);               
                }
            }

        }

        /// <summary>
        /// GET方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Get4WebApi(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            string url = "";
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var tmpResult = client.GetAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Get)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Get)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);                    
                }
            }

        }

        /// <summary>
        /// GET方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool GetObjLst4WebApi(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var tmpResult = client.GetAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Get)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Get)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);                  
                }
            }

        }

        /// <summary>
        /// POST方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Post(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            var url = GetLastUrl(strApiControllerName, strAction, dictParam);
            StringContent content = null;
      
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
               
                    content = new StringContent(parseData, Encoding.UTF8);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var tmpResult = client.PostAsync(url, content).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Post)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Post)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);                  
                }
              
            }
        }

        /// <summary>
        /// POST方式调用Web Api
        /// </summary>
        /// <param name="baseUrl">基准URL（不含查询串）</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        //public static bool Post(string baseUrl, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        //{
        //    errMsg = string.Empty;
        //    result = string.Empty;
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var url = GetLastUrl(baseUrl, dictParam);
        //            var content = new StringContent(parseData, Encoding.UTF8);
        //            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //            var tmpResult = client.PostAsJsonAsync(url, content).Result;
        //            tmpResult.EnsureSuccessStatusCode();
        //            result = tmpResult.Content.ReadAsStringAsync().Result;
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        errMsg = ex.Message;
        //        return false;
        //    }
        //}

        /// <summary>
        /// Put方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Put(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var content = new StringContent(parseData, Encoding.UTF8);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var tmpResult = client.PutAsync(url, content).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
            
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Put)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Put)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }

            }
        }


        /// <summary>
        /// POST方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Deletes(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var content = new StringContent(parseData, Encoding.UTF8);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var tmpResult = client.PostAsync(url, content).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
            
                string strMsg = "";
                string strUrl = GetLastUrl(strApiControllerName, strAction, dictParam);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Post)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Post)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }

            }
        }

        /// <summary>
        /// Delete方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Delete(string strApiControllerName, string strAction, string id, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl4Delete(strApiControllerName, strAction, id);
                    var tmpResult = client.DeleteAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {               
                string strMsg = "";
                string strUrl = GetLastUrl4Delete(strApiControllerName, strAction, id);
                if (ex.Message.Contains("404"))
                {
                    strMsg = string.Format("(Delete)WebApi地址:[{0}]不存在，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }
                else
                {
                    strMsg = string.Format("访问(Delete)WebApi地址:[{0}]时出错，请检查！(错误:{1})", strUrl, ex.Message);
                    throw new Exception(strMsg);
                }

            }
        }
        public static clsUserCodePrjMainPathEN GetUserCodePrjMainPath(string strUserCodePrjMainPathId, string strPrjId)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = null;

            if (clsPubFun4WApi.dicKey_UserCodePrjMainPath == null)
            {
                clsPubFun4WApi.dicKey_UserCodePrjMainPath = new Dictionary<string, clsUserCodePrjMainPathEN>();
                clsUserCodePrjMainPathEN objUserCodePrjMainPath_p = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathIdCache(strUserCodePrjMainPathId, strPrjId);
                clsPubFun4WApi.dicKey_UserCodePrjMainPath.Add(strUserCodePrjMainPathId, objUserCodePrjMainPath_p);
            }


            if (clsPubFun4WApi.dicKey_UserCodePrjMainPath.ContainsKey(strUserCodePrjMainPathId) == false)
            {
                objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
                clsPubFun4WApi.dicKey_UserCodePrjMainPath.Add(strUserCodePrjMainPathId, objUserCodePrjMainPath);
            }
            objUserCodePrjMainPath = clsPubFun4WApi.dicKey_UserCodePrjMainPath[strUserCodePrjMainPathId];
            if (objUserCodePrjMainPath == null)
            {
                objUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
                clsPubFun4WApi.dicKey_UserCodePrjMainPath.Add(strUserCodePrjMainPathId, objUserCodePrjMainPath);
            }
            return objUserCodePrjMainPath;
        }
        public static bool ClearCache4GeneCode(string strPrjId)
        {
            //clsFieldSet.arrFieldObjLst = null;
            //clsFieldSet.arrFieldTabObjLst = null;

            //clsFieldTabWApi.arrFieldTabObjLst_Cache = null;
            clsUserCodePathWApi.objCommFun4WApi.ReFreshCache();

            clsFieldTabExWApi.arrFieldTabENExObjLst4WinApp = null;

            clsFieldTabExWApi.arrFieldTabENExObjLstOrderByFldId_Cache = null;
            string strMsg = string.Format("已经清除了有关生成代码的缓存。({0})", clsStackTrace.GetCurrClassFunctionByLevel(2));
            clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
            var bol1 = AutoGeneCodeWApi.ReFresh4GC(strPrjId);
            return bol1;
            //if (bol1 == true)
            //{
            //    strMsg = string.Format("刷新WebApi后台数据成功！");
            //}
            //else
            //{
            //    strMsg = string.Format("刷新WebApi后台数据不成功！");
            //}
            
            //ErrorInformationWApi.AddInformation(clsStackTrace.GetCurrClassFunctionByLevel(2),
            //    clsStackTrace.GetCurrFunctionByLevel(2), strMsg, "debug");
        }
        /// <summary>
        /// 保存类内容到内容
        /// </summary>
        /// <param name="strClassFName">类文件名（全名）</param>
        /// <param name="strClassContent">类内容</param>
        /// <param name="strFolderName_Root">根文件目录名</param>
        /// <param name="strBackupFolderName">备份文件的目录</param>
        /// <returns></returns>
        public static bool SaveClassContentToFile(string strClassFName, string strClassContent, string strFolderName_Root, string strBackupFolderName, Encoding myEncoding)
        {
            strClassFName = strClassFName.Replace("/", "\\");
            string strFolder = clsString.ParentDir_S(strClassFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
                string strMsg = string.Format("[建立目录成功！]为文件：{2}建立了目录：{0}({1})",
                    strFolder, clsStackTrace.GetCurrClassFunctionByLevel(2),
                    strClassFName);
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
            }
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("[建立目录不成功！]文件：{2}建立目录：{0}。({1})",
                    strFolder, clsStackTrace.GetCurrClassFunctionByLevel(2),
                  strClassFName);
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            if (clsSysParaEN_Local.IsBackupForGeneCode == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    if (string.IsNullOrEmpty(strBackupFolderName) == false)
                    {
                        clsFile.FileBackup(strFindFileFullFile, strBackupFolderName);
                        File.Delete(strFindFileFullFile);
                    }
                    strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);

                }
            }
            try
            {
                clsFile.CreateFileByString(strClassFName, strClassContent, myEncoding);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("[建立文件不成功！]文件：{0}时发生错误：{1}.({2})", strClassFName, objException.Message, clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            return true;
        }
        /// <summary>
        /// 保存类内容到内容, 不需要备份原来的文件, 原文件不能被覆盖
        /// </summary>
        /// <param name="strClassFName">类文件名（全名）</param>
        /// <param name="strClassContent">类内容</param>
        /// <param name="strFolderName_Root">根文件目录名</param>
        /// <param name="myEncoding">生成文件的代码类型</param> 
        /// <returns></returns>
        public static Tuple<bool, string> SaveClassContentToFile_NoCover(string strClassFName, string strClassContent, string strFolderName_Root, clsvCodeType_SimEN objCodeTypeEN, Encoding myEncoding)
        {
            string strFolder = clsString.ParentDir_S(strClassFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = "";
                    if (objCodeTypeEN != null)
                    {
                        strMsg = string.Format("\r\n[文件已经存在!]({2})",
                            strFindFileFullFile,
                            clsStackTrace.GetCurrClassFunctionByLevel(2), objCodeTypeEN.CodeTypeName);
                    }
                    else
                    {
                        strMsg = string.Format("\r\n[文件已经存在!]",
                            strFindFileFullFile,
                            clsStackTrace.GetCurrClassFunctionByLevel(2));
                    }
                    return Tuple.Create(false, strMsg);

                }
            }
            clsFile.CreateFileByString(strClassFName, strClassContent, myEncoding);
            return Tuple.Create(true, "");
        }

        public static Tuple<bool, string> SaveClassContentToFile_NoCover4View(string strFolderName_Root, string strClassFName, string strClassContent, clsvCodeType_SimEN objCodeTypeEN, Encoding myEncoding)
        {
            string strFolder = clsString.ParentDir_S(strClassFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            //string strFolderName_Root = strFolder;
            if (clsSysParaEN_Local.IsBackupForGeneCode == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    var strTemp = strFindFileFullFile;
                    if (strFindFileFullFile == strClassFName)
                    {
                        strTemp = "";
                    }
                    string strMsg = string.Format("\r\n[文件已经存在!{0}]({2})",
                        strTemp,
                        clsStackTrace.GetCurrClassFunctionByLevel(2), objCodeTypeEN.CodeTypeName);
                    return Tuple.Create(false, strMsg);
                }
            }
            clsFile.CreateFileByString(strClassFName, strClassContent, myEncoding);
            return Tuple.Create(true, "");
        }

        public static bool WriteLogFile(string strLogFName, string strLogContent, Encoding myEncoding)
        {
            string strFolder = clsString.ParentDir_S(strLogFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            clsFile.CreateFileByString(strLogFName, strLogContent, myEncoding);
            return true;
        }
    }
}
