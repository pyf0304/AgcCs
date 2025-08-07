
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMProjectPrjTabExWApi
表名:CMProjectPrjTab(00050530)
生成代码版本:2020.04.08.1
生成日期:2020/04/08 09:17:09
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:代码管理
模块英文名:CodeMan
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq; 

namespace AGC4WApi
{
    public static class clsCMProjectPrjTabExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMProjectPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsCmProjectPrjTabEN:objCMProjectPrjTabENT</returns>
        public static clsCmProjectPrjTabENEx CopyToEx(this clsCmProjectPrjTabEN objCMProjectPrjTabENS)
        {
            try
            {
                clsCmProjectPrjTabENEx objCMProjectPrjTabENT = new clsCmProjectPrjTabENEx();
                clsCmProjectPrjTabWApi.CopyTo(objCMProjectPrjTabENS, objCMProjectPrjTabENT);
                return objCMProjectPrjTabENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_EditRecordEx)
        /// </summary>
        /// <param name = "objCMProjectPrjTabEN">需要添加的实体对象</param>
        /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
        public static bool EditRecordEx(this clsCmProjectPrjTabEN objCMProjectPrjTabEN)
        {
            try
            {
                objCMProjectPrjTabEN.sfUpdFldSetStr = objCMProjectPrjTabEN.getsfUpdFldSetStr();
                bool bolResult = clsCMProjectPrjTabExWApi.EditRecordEx(objCMProjectPrjTabEN);
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                clsCmProjectPrjTabWApi.ReFreshCache();
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000006)编辑记录出错,{1}!(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// CM项目工程表关系(CMProjectPrjTab)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsCMProjectPrjTabExWApi
    {
        private static readonly string mstrApiControllerName = "CMProjectPrjTabExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsCmProjectPrjTabEN> arrCMProjectPrjTabObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsCMProjectPrjTabExWApi()
        {
        }

        /// <summary>
        /// 修改记录
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
        /// </summary>
        /// <returns>是否成功?</returns>
        public static bool EditRecordEx(clsCmProjectPrjTabEN objCMProjectPrjTabEN)
        {
            if (string.IsNullOrEmpty(objCMProjectPrjTabEN.sfUpdFldSetStr) == true)
            {
                string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
                objCMProjectPrjTabEN.mId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strAction = "EditRecordEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJson = clsJSON.GetJsonFromObj<clsCmProjectPrjTabEN>(objCMProjectPrjTabEN);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var bolReturnBool = (bool)jobjReturn["returnBool"];
                        return bolReturnBool;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 删除Cm工程与表的关系
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCmPrjId">CM工程Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>返回对象列表</returns>
        public static int DelRela(string strCmPrjId, string strTabId)
        {
            string strAction = "DelRela";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strCmPrjId"] = strCmPrjId,
                ["strTabId"] = strTabId,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (int)jobjReturn["returnInt"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return 0;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("删除Cm工程与表的关系出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
    }
}