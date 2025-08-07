
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvCmProjectAppRelaExWApi
表名:vCmProjectAppRela(00050634)
* 版本:2024.08.31.1(服务器:WIN-SRV103-116)
日期:2024/08/31 18:01:36
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理(CodeMan)
框架-层名:WA_访问扩展层(CS)(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

    public static class clsvCmProjectAppRelaExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvCmProjectAppRelaENS">源对象</param>
        /// <returns>目标对象=>clsvCmProjectAppRelaEN:objvCmProjectAppRelaENT</returns>
        public static clsvCmProjectAppRelaENEx CopyToEx(this clsvCmProjectAppRelaEN objvCmProjectAppRelaENS)
        {
            try
            {
                clsvCmProjectAppRelaENEx objvCmProjectAppRelaENT = new clsvCmProjectAppRelaENEx();
                clsvCmProjectAppRelaWApi.CopyTo(objvCmProjectAppRelaENS, objvCmProjectAppRelaENT);
                return objvCmProjectAppRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
               
    }
    /// <summary>
    /// vCmProjectAppRela(vCmProjectAppRela)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvCmProjectAppRelaExWApi
    {
        private static readonly string mstrApiControllerName = "vCmProjectAppRelaExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLstCache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;
        public static clsvCmProjectAppRelaENEx CopyToEx(clsvCmProjectAppRelaEN objvCmProjectAppRelaENS)
        {
            try
            {
                clsvCmProjectAppRelaENEx objvCmProjectAppRelaENT = new clsvCmProjectAppRelaENEx();
                clsvCmProjectAppRelaWApi.CopyTo(objvCmProjectAppRelaENS, objvCmProjectAppRelaENT);
                return objvCmProjectAppRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsvUserCodePrjMainPathEN CopyTovUserCodePrjMainPath(clsvCmProjectAppRelaEN objvCmProjectAppRelaENS)
        {
            try
            {
                clsvUserCodePrjMainPathEN objvUserCodePrjMainPath = new clsvUserCodePrjMainPathEN();
                objvUserCodePrjMainPath.AppOrderNum = objvCmProjectAppRelaENS.AppOrderNum;
                objvUserCodePrjMainPath.CmPrjId = objvCmProjectAppRelaENS.CmPrjId;
                objvUserCodePrjMainPath.CmPrjName = objvCmProjectAppRelaENS.CmPrjName;
                objvUserCodePrjMainPath.ApplicationTypeId = objvCmProjectAppRelaENS.ApplicationTypeId;
                objvUserCodePrjMainPath.ApplicationTypeName = objvCmProjectAppRelaENS.ApplicationTypeName;
                objvUserCodePrjMainPath.ApplicationTypeSimName = objvCmProjectAppRelaENS.ApplicationTypeSimName;
                objvUserCodePrjMainPath.PrjId = objvCmProjectAppRelaENS.PrjId;
                objvUserCodePrjMainPath.UpdDate = objvCmProjectAppRelaENS.UpdDate;
                objvUserCodePrjMainPath.UpdUserId = objvCmProjectAppRelaENS.UpdUser;
                objvUserCodePrjMainPath.CMProjectAppRelaId= objvCmProjectAppRelaENS.CMProjectAppRelaId;


                return objvUserCodePrjMainPath;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000002)CopyTovUserCodePrjMainPath表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        
    }
}