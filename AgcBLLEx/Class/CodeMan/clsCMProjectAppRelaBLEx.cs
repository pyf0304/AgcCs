
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMProjectAppRelaBLEx
表名:CMProjectAppRela(00050600)
生成代码版本:2021.12.24.1
生成日期:2021/12/24 11:58:41
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理(CodeMan)
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;
using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public static class clsCMProjectAppRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMProjectAppRelaENS">源对象</param>
        /// <returns>目标对象=>clsCMProjectAppRelaEN:objCMProjectAppRelaENT</returns>
        public static clsCMProjectAppRelaENEx CopyToEx(this clsCMProjectAppRelaEN objCMProjectAppRelaENS)
        {
            try
            {
                clsCMProjectAppRelaENEx objCMProjectAppRelaENT = new clsCMProjectAppRelaENEx();
                clsCMProjectAppRelaBL.CMProjectAppRelaDA.CopyTo(objCMProjectAppRelaENS, objCMProjectAppRelaENT);
                return objCMProjectAppRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objCMProjectAppRelaENS">源对象</param>
        /// <returns>目标对象=>clsCMProjectAppRelaEN:objCMProjectAppRelaENT</returns>
        public static clsCMProjectAppRelaEN CopyTo(this clsCMProjectAppRelaENEx objCMProjectAppRelaENS)
        {
            try
            {
                clsCMProjectAppRelaEN objCMProjectAppRelaENT = new clsCMProjectAppRelaEN();
                clsCMProjectAppRelaBL.CopyTo(objCMProjectAppRelaENS, objCMProjectAppRelaENT);
                return objCMProjectAppRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// CM项目应用关系(CMProjectAppRela)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMProjectAppRelaBLEx : clsCMProjectAppRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMProjectAppRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMProjectAppRelaDAEx CMProjectAppRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMProjectAppRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objCMProjectAppRelaENS">源对象</param>
        /// <returns>目标对象=>clsCMProjectAppRelaEN:objCMProjectAppRelaENT</returns>
        public static clsCMProjectAppRelaENEx CopyToEx(clsCMProjectAppRelaEN objCMProjectAppRelaENS)
        {
            try
            {
                clsCMProjectAppRelaENEx objCMProjectAppRelaENT = new clsCMProjectAppRelaENEx();
                clsCMProjectAppRelaBL.CMProjectAppRelaDA.CopyTo(objCMProjectAppRelaENS, objCMProjectAppRelaENT);
                return objCMProjectAppRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsCMProjectAppRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsCMProjectAppRelaEN> arrObjLst = clsCMProjectAppRelaBL.GetObjLst(strCondition);
            List<clsCMProjectAppRelaENEx> arrObjExLst = new List<clsCMProjectAppRelaENEx>();
            foreach (clsCMProjectAppRelaEN objInFor in arrObjLst)
            {
                clsCMProjectAppRelaENEx objCMProjectAppRelaENEx = new clsCMProjectAppRelaENEx();
                clsCMProjectAppRelaBL.CopyTo(objInFor, objCMProjectAppRelaENEx);
                arrObjExLst.Add(objCMProjectAppRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMProjectAppRelaENEx GetObjExBymId(long lngCMProjectAppRelaId)
        {
            clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaBL.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
            clsCMProjectAppRelaENEx objCMProjectAppRelaENEx = new clsCMProjectAppRelaENEx();
            clsCMProjectAppRelaBL.CopyTo(objCMProjectAppRelaEN, objCMProjectAppRelaENEx);
            return objCMProjectAppRelaENEx;
        }

        public static int DelCmProjectApp(string strCmPrjId, int intApplicationTypeId)
        {
            string strCondition = string.Format("{0}='{1}' and {2}={3}", conCMProjectAppRela.CmPrjId, strCmPrjId,
                conCMProjectAppRela.ApplicationTypeId, intApplicationTypeId);
            var objCMProjectAppRela = clsCMProjectAppRelaBL.GetFirstObj_S(strCondition);
            if (objCMProjectAppRela != null)
            {
                clsUserCodePrjMainPathBLEx.DelRecordByCMProjectAppRelaIdEx(objCMProjectAppRela.CMProjectAppRelaId, objCMProjectAppRela.PrjId);
                clsUserCodePathBLEx.DelRecordByCMProjectAppRelaIdEx(objCMProjectAppRela.CMProjectAppRelaId, objCMProjectAppRela.PrjId);
            }
            int intRec = clsCMProjectAppRelaBL.DelCMProjectAppRelasByCond(strCondition);
            return intRec;
        }
        public static long getCMProjectAppRelaId(string strCmPrjId, int intApplicationTypeId, string strPrjId)
        {
            var arrCMProjectAppRelaObjLst_Cache = clsCMProjectAppRelaBL.GetObjLstCache(strPrjId);
            try
            {
                var arrCMProjectAppRela_Sel = arrCMProjectAppRelaObjLst_Cache.Where(x =>
                x.CmPrjId == strCmPrjId && x.ApplicationTypeId == intApplicationTypeId).ToList();
                if (arrCMProjectAppRela_Sel.Count > 0)
                {
                    return arrCMProjectAppRela_Sel[0].CMProjectAppRelaId;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("错误:[{0}]. \n根据Cm工程Id:[{1}]获取相应的对象列表不成功!(in {2}.{3})", objException.Message, strCmPrjId, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }

    }
}