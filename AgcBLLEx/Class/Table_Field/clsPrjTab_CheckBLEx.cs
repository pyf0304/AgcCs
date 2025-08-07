
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPrjTab_CheckBLEx
表名:PrjTab_Check(00050564)
生成代码版本:2020.06.05.2
生成日期:2020/06/11 00:34:34
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;

using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    public static class clsPrjTab_CheckBLEx_Static
    {

        public static bool AddErrMsg(this clsPrjTab_CheckEN objPrjTabEN, string strErrMsg)
        {
            if (string.IsNullOrEmpty(strErrMsg) == true) return true;
            string strCurrDate = clsDateTime.getTodayStr(0);
            string strOldErrMsg = objPrjTabEN.ErrMsg;
            strOldErrMsg = strOldErrMsg.Replace(strCurrDate, "");
            strOldErrMsg = strOldErrMsg.Replace(":", "; ");
            string strNewErrMsg = "";
            if (string.IsNullOrEmpty(strOldErrMsg) == false)
            {
                strNewErrMsg = strCurrDate + ":" + strErrMsg + strOldErrMsg;
            }
            else
            {
                strNewErrMsg = strCurrDate + ":" + strErrMsg;
            }
            int intRecNum = 0;
            try
            {
                intRecNum = clsPrjTab_CheckBL.SetFldValue(conPrjTab_Check._CurrTabName, conPrjTab_Check.ErrMsg, strNewErrMsg, string.Format("TabId = '{0}'", objPrjTabEN.TabId));
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsPrjTabBLEx", "AddErrMsg", objException.Message + "::" + strErrMsg, "pyfdebug");

            }
            if (intRecNum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objPrjTab_CheckENS">源对象</param>
        /// <returns>目标对象=>clsPrjTab_CheckEN:objPrjTab_CheckENT</returns>
        public static clsPrjTab_CheckENEx CopyToEx(this clsPrjTab_CheckEN objPrjTab_CheckENS)
        {
            try
            {
                clsPrjTab_CheckENEx objPrjTab_CheckENT = new clsPrjTab_CheckENEx();
                clsPrjTab_CheckBL.PrjTab_CheckDA.CopyTo(objPrjTab_CheckENS, objPrjTab_CheckENT);
                return objPrjTab_CheckENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objPrjTab_CheckENS">源对象</param>
        /// <returns>目标对象=>clsPrjTab_CheckEN:objPrjTab_CheckENT</returns>
        public static clsPrjTab_CheckEN CopyTo(this clsPrjTab_CheckENEx objPrjTab_CheckENS)
        {
            try
            {
                clsPrjTab_CheckEN objPrjTab_CheckENT = new clsPrjTab_CheckEN();
                clsPrjTab_CheckBL.CopyTo(objPrjTab_CheckENS, objPrjTab_CheckENT);
                return objPrjTab_CheckENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 工程表_检查(PrjTab_Check)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsPrjTab_CheckBLEx : clsPrjTab_CheckBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsPrjTab_CheckDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsPrjTab_CheckDAEx PrjTab_CheckDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsPrjTab_CheckDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objPrjTab_CheckENS">源对象</param>
        /// <returns>目标对象=>clsPrjTab_CheckEN:objPrjTab_CheckENT</returns>
        public static clsPrjTab_CheckENEx CopyToEx(clsPrjTab_CheckEN objPrjTab_CheckENS)
        {
            try
            {
                clsPrjTab_CheckENEx objPrjTab_CheckENT = new clsPrjTab_CheckENEx();
                clsPrjTab_CheckBL.PrjTab_CheckDA.CopyTo(objPrjTab_CheckENS, objPrjTab_CheckENT);
                return objPrjTab_CheckENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
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
        public static List<clsPrjTab_CheckENEx> GetObjExLst(string strCondition)
        {
            List<clsPrjTab_CheckEN> arrObjLst = clsPrjTab_CheckBL.GetObjLst(strCondition);
            List<clsPrjTab_CheckENEx> arrObjExLst = new List<clsPrjTab_CheckENEx>();
            foreach (clsPrjTab_CheckEN objInFor in arrObjLst)
            {
                clsPrjTab_CheckENEx objPrjTab_CheckENEx = new clsPrjTab_CheckENEx();
                clsPrjTab_CheckBL.CopyTo(objInFor, objPrjTab_CheckENEx);
                arrObjExLst.Add(objPrjTab_CheckENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTabId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsPrjTab_CheckENEx GetObjExByTabId(string strTabId)
        {
            clsPrjTab_CheckEN objPrjTab_CheckEN = clsPrjTab_CheckBL.GetObjByTabId(strTabId);
            clsPrjTab_CheckENEx objPrjTab_CheckENEx = new clsPrjTab_CheckENEx();
            clsPrjTab_CheckBL.CopyTo(objPrjTab_CheckEN, objPrjTab_CheckENEx);
            return objPrjTab_CheckENEx;
        }

public static clsPrjTab_CheckEN GetObjByTabId_CacheEx(string strTabId, string strPrjId)
        {
            clsPrjTab_CheckEN objPrjTab_CheckEN = clsPrjTab_CheckBL.GetObjByTabIdCache(strTabId, strPrjId);
            if (objPrjTab_CheckEN == null)
            {
                objPrjTab_CheckEN = new clsPrjTab_CheckEN();
                objPrjTab_CheckEN.TabId = strTabId;
                objPrjTab_CheckEN.PrjId = strPrjId;
                objPrjTab_CheckEN.AddNewRecord();

            }
            return objPrjTab_CheckEN;
        }
    }
}