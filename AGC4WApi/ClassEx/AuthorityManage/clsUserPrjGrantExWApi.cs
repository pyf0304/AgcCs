
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUserPrjGrantExWApi
表名:UserPrjGrant(00050092)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:51
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:权限管理
模块英文名:AuthorityManage
框架-层名:WebApi访问扩展层(WA_AccessEx)
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
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using AgcCommBase;


namespace AGC4WApi
{
    /// <summary>
    /// UserPrjGrant(UserPrjGrant)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsUserPrjGrantExWApi
    {
        private static readonly string mstrApiControllerName = "UserPrjGrantExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<stuUserLoginInfo> arrUserPrjGrantObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsUserPrjGrantExWApi()
        {
        }

        /// <summary>
        /// 根据关键字获取用户登录信息,用对象的形式表示.
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表对象</returns>
        public static stuUserLoginInfo GetUserLoginInfo(long lngmId)
        {
            string strAction = "GetUserLoginInfo";
            string strErrMsg = string.Empty;
            string strResult = "";
            stuUserLoginInfo objUserLoginInfo = null;
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["mId"] = lngmId.ToString()
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    objUserLoginInfo = clsJSON.GetObjFromJson<stuUserLoginInfo>(strResult);
                    return objUserLoginInfo;
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 获取某用户的项目数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>该用户的项目数</returns>
        public static clsUserPrjGrantEN GetFirstUserPrjGrantByUserId(string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId='{0}'", strUserId);
            return clsUserPrjGrantWApi.GetFirstObj(sbCondition.ToString());
        }

        /// <summary>
        /// 获取某用户的项目数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>该用户的项目数</returns>
        public static int GetPrjCountByUserId(string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId='{0}'", strUserId);
            //if (clsSysParaEN.bolIsUseXmlDataSource == true)
            //{
            //    return clsSysParaEN.objSpecSqlForXml.funGetRecCount(clsUserPrjGrantEN._CurrTabName, sbCondition.ToString());
            //}
            //else
            //{
            return clsUserPrjGrantWApi.GetRecCountByCond(sbCondition.ToString());
            //}
        }
        public static bool IsExistSameRec(string strUserId, string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId='{0}'", strUserId);
            sbCondition.AppendFormat(" and PrjId='{0}'", strPrjId);
            return clsUserPrjGrantWApi.IsExistRecord(sbCondition.ToString());
        }
        public static clsUserPrjGrantEN GetUserPrjGrantByCondition(string strUserId,
           string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId='{0}'", strUserId);
            sbCondition.AppendFormat(" and PrjId='{0}'", strPrjId);
            return clsUserPrjGrantWApi.GetFirstObj(sbCondition.ToString());
        }
    }
}