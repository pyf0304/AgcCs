
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewRegionRelaExWApi
表名:ViewRegionRela(00050573)
生成代码版本:2020.09.24.1
生成日期:2020/10/02 01:07:50
生成者:pyf
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:区域管理
模块英文名:RegionManage
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
using System.Linq;

namespace AGC4WApi
{
    public static class clsViewRegionRelaExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objViewRegionRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewRegionRelaEN:objViewRegionRelaENT</returns>
        public static clsViewRegionRelaENEx CopyToEx(this clsViewRegionRelaEN objViewRegionRelaENS)
        {
            try
            {
                clsViewRegionRelaENEx objViewRegionRelaENT = new clsViewRegionRelaENEx();
                clsViewRegionRelaWApi.CopyTo(objViewRegionRelaENS, objViewRegionRelaENT);
                return objViewRegionRelaENT;
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
        /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
        /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
        public static bool EditRecordEx(this clsViewRegionRelaEN objViewRegionRelaEN)
        {
            try
            {
                objViewRegionRelaEN.sfUpdFldSetStr = objViewRegionRelaEN.getsfUpdFldSetStr();
                bool bolResult = clsViewRegionRelaExWApi.EditRecordEx(objViewRegionRelaEN);
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                clsViewRegionRelaWApi.ReFreshCache(objViewRegionRelaEN.PrjId);
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
    /// 界面区域关系(ViewRegionRela)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsViewRegionRelaExWApi
    {
        private static readonly string mstrApiControllerName = "ViewRegionRelaExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsViewRegionRelaEN> arrViewRegionRelaObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsViewRegionRelaExWApi()
        {
        }

        /// <summary>
        /// 修改记录
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
        /// </summary>
        /// <returns>是否成功?</returns>
        public static bool EditRecordEx(clsViewRegionRelaEN objViewRegionRelaEN)
        {
            if (string.IsNullOrEmpty(objViewRegionRelaEN.sfUpdFldSetStr) == true)
            {
                string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
                objViewRegionRelaEN.mId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strAction = "EditRecordEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJson = clsJSON.GetJsonFromObj<clsViewRegionRelaEN>(objViewRegionRelaEN);
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

        public static List<string> GetRegionIdLstByViewIdCache(string strViewId, string strCmPrjId)
        {
            //string strCondition = string.Format("{0}='{1}'", clsViewRegionRelaEN.con_ViewId, strViewId);
            IEnumerable<clsViewRegionRelaEN> arrObjLst_Cache = clsViewRegionRelaWApi.GetObjLstCache(strCmPrjId);
            IEnumerable<clsViewRegionRelaEN> arrObjLst = arrObjLst_Cache.Where(x => x.ViewId == strViewId);
            List<string> arrRegionId = arrObjLst.Select(x => x.RegionId).ToList();
            //List<string> arrRegionId  = clsViewRegionRelaWApi.GetPrimaryKeyID_S(strCondition).Select(x => long.Parse(x)).ToList();
            return arrRegionId;
        }

        //public static int GetRegionNumByViewIdCache(string strViewId, string strCmPrjId)
        //{
        //    //string strCondition = string.Format("{0}='{1}'", clsViewRegionRelaEN.con_ViewId, strViewId);
        //    IEnumerable<clsViewRegionRelaEN> arrObjLst_Cache = clsViewRegionRelaWApi.GetObjLstCache(strCmPrjId);
        //    IEnumerable<clsViewRegionRelaEN> arrObjLst = arrObjLst_Cache.Where(x => x.ViewId == strViewId);
        //    List<string> arrRegionId = arrObjLst.Select(x => x.RegionId).ToList();
        //    //List<string> arrRegionId  = clsViewRegionRelaWApi.GetPrimaryKeyID_S(strCondition).Select(x => long.Parse(x)).ToList();
        //    return arrRegionId.Count;
        //}

        /// <summary>
        /// 获取界面的区域数
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <returns>返回对象列表</returns>
        public static int GetRegionNumByViewIdBak(string strViewId)
        {
            string strAction = "GetRegionNumByViewId";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strViewId"] = strViewId,
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
                        string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return 0;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取界面的区域数出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
    }
}