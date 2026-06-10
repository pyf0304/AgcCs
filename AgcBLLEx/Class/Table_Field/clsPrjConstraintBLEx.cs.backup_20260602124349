
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AGC.BusinessLogicEx
{
    public static class clsPrjConstraintBLEx_Static
    {

        public static string ConstraintName4GC(this clsPrjConstraintEN objPrjConstraintENS)
        {
            string strConstraintName4GC = objPrjConstraintENS.ConstraintName;
            return strConstraintName4GC;

        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objPrjConstraintENS">源对象</param>
        /// <returns>目标对象=>clsPrjConstraintEN:objPrjConstraintENT</returns>
        public static clsPrjConstraintENEx CopyToEx(this clsPrjConstraintEN objPrjConstraintENS)
        {
            try
            {
                clsPrjConstraintENEx objPrjConstraintENT = new clsPrjConstraintENEx();
                clsPrjConstraintBL.CopyTo(objPrjConstraintENS, objPrjConstraintENT);
                return objPrjConstraintENT;
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
        /// <param name = "objPrjConstraintENS">源对象</param>
        /// <returns>目标对象=>clsPrjConstraintEN:objPrjConstraintENT</returns>
        public static clsPrjConstraintEN CopyTo(this clsPrjConstraintENEx objPrjConstraintENS)
        {
            try
            {
                clsPrjConstraintEN objPrjConstraintENT = new clsPrjConstraintEN();
                clsPrjConstraintBL.CopyTo(objPrjConstraintENS, objPrjConstraintENT);
                return objPrjConstraintENT;
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
    /// 约束表(PrjConstraint)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsPrjConstraintBLEx : clsPrjConstraintBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsPrjConstraintDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsPrjConstraintDAEx PrjConstraintDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsPrjConstraintDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strPrjConstraintId">表关键字</param>
        /// <param name="strPrjId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strPrjConstraintId, string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPrjConstraintDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[PrjConstraint]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'",
                conConstraintFields.PrjConstraintId,
                strPrjConstraintId);
                clsConstraintFieldsBL.DelConstraintFieldssByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);

                clsPrjConstraintBL.DelRecord(strPrjConstraintId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsPrjConstraintBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strPrjConstraintId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsPrjConstraintENEx> GetObjExLst(string strCondition)
        {
            List<clsPrjConstraintEN> arrObjLst = clsPrjConstraintBL.GetObjLst(strCondition);
            List<clsPrjConstraintENEx> arrObjExLst = new List<clsPrjConstraintENEx>();
            foreach (clsPrjConstraintEN objInFor in arrObjLst)
            {
                clsPrjConstraintENEx objPrjConstraintENEx = new clsPrjConstraintENEx();
                clsPrjConstraintBL.CopyTo(objInFor, objPrjConstraintENEx);
                arrObjExLst.Add(objPrjConstraintENEx);
            }
            return arrObjExLst;
        }

        public static List<clsPrjConstraintENEx> GetObjExLstByTabId(string strTabId, string strPrjId)
        {
            string strCondition = $"{conPrjConstraint.TabId} = '{strTabId}'";
            List<clsPrjConstraintEN> arrObjLstCache = clsPrjConstraintBL.GetObjLstCache(strPrjId);
            var arrObjLst = arrObjLstCache.Where(x=>x.TabId == strTabId).ToList();
            List<clsPrjConstraintENEx> arrObjExLst = new List<clsPrjConstraintENEx>();
            foreach (clsPrjConstraintEN objInFor in arrObjLst)
            {
                clsPrjConstraintENEx objPrjConstraintENEx = new clsPrjConstraintENEx();
                clsPrjConstraintBL.CopyTo(objInFor, objPrjConstraintENEx);
                arrObjExLst.Add(objPrjConstraintENEx);
            }
            return arrObjExLst;
        }


        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strPrjConstraintId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsPrjConstraintENEx GetObjExByPrjConstraintIdCache(string strPrjConstraintId,string strPrjId)
        {
            clsPrjConstraintEN objPrjConstraintEN = clsPrjConstraintBL.GetObjByPrjConstraintIdCache(strPrjConstraintId, strPrjId);
            clsPrjConstraintENEx objPrjConstraintENEx = new clsPrjConstraintENEx();
            clsPrjConstraintBL.CopyTo(objPrjConstraintEN, objPrjConstraintENEx);
            return objPrjConstraintENEx;
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strTabId"></param>
        public static void BindDdl_PrjConstraintIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strTabId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[约束表]...", "0");
            string strCondition = string.Format("{0}='{1}' Order By {2}",
                conPrjConstraint.TabId, strTabId,
                conPrjConstraint.PrjConstraintId);
            List<clsPrjConstraintEN> arrObjLst = clsPrjConstraintBL.GetObjLst(strCondition);
            //arrObjLst
            objDDL.DataValueField = conPrjConstraint.PrjConstraintId;
            objDDL.DataTextField = conPrjConstraint.ConstraintName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static bool CheckUniqueness(string strTabId, string strPrjId)
        {
            var arrPrjConstraint = clsPrjConstraintBL.GetObjLstCache(strPrjId);
            var arr = arrPrjConstraint.Where(x => x.TabId == strTabId && x.ConstraintTypeId == enumConstraintType.Uniqueness_01);
            if (arr.Count() > 0) return true;
            else return false;
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objPrjConstraintENS">源对象</param>
        /// <returns>目标对象=>clsPrjConstraintEN:objPrjConstraintENT</returns>
        public static clsPrjConstraintENEx CopyToEx(clsPrjConstraintEN objPrjConstraintENS)
        {
            try
            {
                clsPrjConstraintENEx objPrjConstraintENT = new clsPrjConstraintENEx();
                clsPrjConstraintBL.PrjConstraintDA.CopyTo(objPrjConstraintENS, objPrjConstraintENT);
                return objPrjConstraintENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool CheckConstraintFld(string strPrjConstraintId, string strPrjId, string strUserId)
        {

            //1、获取当前区域ID的相关主表ID；
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            string strMsg = "";
            //int intErrCount = 0;
            var objPrjConstraint = clsPrjConstraintBL.GetObjByPrjConstraintId(strPrjConstraintId);
            var arrConstraintFld = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(strPrjConstraintId, strPrjId);
            var arrFldId = clsPrjTabFldBLEx.GetFldIdLstByTabIdCache(objPrjConstraint.TabId, strPrjId);

            foreach (var objInFor in arrConstraintFld)
            {

                if (arrFldId.Contains(objInFor.FldId) == false)
                {
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldId, strPrjId);
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjConstraint.TabId, strPrjId);
                    if (objPrjTab == null)
                    {
                        strMsg += $"表Id:[{objPrjConstraint.TabId}]在表中不存在.({clsStackTrace.GetCurrClassFunctionByLevel(2)});";
                    }
                    else
                    {
                        strMsg += $"字段:[{objFieldTab.FldName}({objFieldTab.FldId})]在表[{objPrjTab.TabName}]中不存在.({clsStackTrace.GetCurrClassFunctionByLevel(2)});";
                    }
                }

            }
            if (strMsg.Length > 0)
            {
                objPrjConstraint.ErrMsg = strMsg;
                objPrjConstraint.CheckDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjConstraint.Update();
                return true;
            }
            if (objPrjConstraint.ErrMsg != null && objPrjConstraint.ErrMsg.Length > 0)
            {
                objPrjConstraint.ErrMsg = "";
                objPrjConstraint.CheckDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjConstraint.Update();
                return true;
            }
            else
            {
                objPrjConstraint.ErrMsg = "";
                objPrjConstraint.CheckDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjConstraint.Update();
                return true;
            }
            return true;
        }

    }
}