
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
            var arrObjLst = arrObjLstCache.Where(x => x.TabId == strTabId).ToList();
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
        public static clsPrjConstraintENEx GetObjExByPrjConstraintIdCache(string strPrjConstraintId, string strPrjId)
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



        /// <summary>
        /// 替换字段,在整个工程中替换字段
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strSourceFldId">源字段Id</param>
        /// <param name = "strTargetFldId">目标字段Id</param>
        /// <returns></returns>
        //public static bool ReplaceField(string strPrjId, string strSourceFldId, string strTargetFldId)
        //{
        //    clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
        //    string strSQL;
        //    strSQL = $"Update PrjConstraint Set {conPrjConstraint.FldId} = '{strTargetFldId}' where PrjId = '{strPrjId}' And {conPrjConstraint.FldId} = '{strSourceFldId}'";
        //    return objSQL.ExecSql(strSQL);
        //}

        public static string AddPrjConstraintWithFieldCheck(AddPrjConstraintWithFieldCheckRequest request)
        {
            if (request == null) throw new Exception("request不能为空!");
            if (string.IsNullOrEmpty(request.strPrjId)) throw new Exception("strPrjId不能为空!");
            if (string.IsNullOrEmpty(request.strTabName)) throw new Exception("strTabName不能为空!");
            if (string.IsNullOrEmpty(request.strConstraintName)) throw new Exception("strConstraintName不能为空!");
            if (string.IsNullOrEmpty(request.strConstraintTypeName)) throw new Exception("strConstraintTypeName不能为空!");
            if (string.IsNullOrEmpty(request.strOpUser)) throw new Exception("strOpUser不能为空!");
            if (request.arrFieldInfo == null || request.arrFieldInfo.Count == 0) throw new Exception("arrFieldInfo不能为空!");

            string strPrjId = request.strPrjId.Trim();
            string strTabName = request.strTabName.Trim();
            string strConstraintName = request.strConstraintName.Trim();
            string strConstraintTypeName = request.strConstraintTypeName.Trim();

            List<clsPrjTabEN> arrPrjTabCache = clsPrjTabBL.GetObjLstCache(strPrjId);
            clsPrjTabEN objPrjTab = arrPrjTabCache.FirstOrDefault(x => x.TabName == strTabName);
            if (objPrjTab == null) throw new Exception($"表名[{strTabName}]在工程[{strPrjId}]中不存在!");

            List<clsConstraintTypeEN> arrConstraintType = clsConstraintTypeBL.GetObjLstCache();
            clsConstraintTypeEN objConstraintType = arrConstraintType.FirstOrDefault(x =>
                x.ConstraintTypeName == strConstraintTypeName || x.ConstraintTypeNameEN == strConstraintTypeName);
            if (objConstraintType == null) throw new Exception($"约束类型[{strConstraintTypeName}]不存在!");

            string strCondition = $"{conPrjConstraint.ConstraintName}='{strConstraintName.Replace("'", "''")}'"
                + $" and {conPrjConstraint.PrjId}='{strPrjId.Replace("'", "''")}'"
                + $" and {conPrjConstraint.TabId}='{objPrjTab.TabId.Replace("'", "''")}'";
            if (clsPrjConstraintBL.IsExistRecord(strCondition))
            {
                throw new Exception($"约束[{strConstraintName}]已存在!");
            }

            List<clsFieldTabEN> arrFieldTab = clsFieldTabBL.GetObjLstCache(strPrjId);
            List<string> arrFldIdInTab = clsPrjTabFldBLEx.GetFldIdLstByTabIdCache(objPrjTab.TabId, strPrjId);
            List<clsSortTypeEN> arrSortType = clsSortTypeBL.GetObjLstCache();

            clsSpecSQLforSql objSQL = clsPrjConstraintDA.GetSpecSQLObj();
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            string strPrjConstraintId = "";

            try
            {
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                objSqlTransaction = objConnection.BeginTransaction();

                clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
                objPrjConstraintEN.PrjConstraintId = clsPrjConstraintBL.GetMaxStrId_S();
                objPrjConstraintEN.ConstraintName = strConstraintName;
                objPrjConstraintEN.PrjId = strPrjId;
                objPrjConstraintEN.TabId = objPrjTab.TabId;
                objPrjConstraintEN.ConstraintTypeId = objConstraintType.ConstraintTypeId;
                objPrjConstraintEN.ConstraintDescription = request.strConstraintDescription ?? "";
                objPrjConstraintEN.CreateUserId = request.strOpUser;
                objPrjConstraintEN.IsNullable = false;
                objPrjConstraintEN.InUse = true;
                objPrjConstraintEN.UpdUser = request.strOpUser;
                objPrjConstraintEN.Memo = "";
                clsPrjConstraintBL.AccessFldValueNull(objPrjConstraintEN);

                strPrjConstraintId = clsPrjConstraintBL.PrjConstraintDA.AddNewRecordBySQL2WithReturnKey(
                    objPrjConstraintEN, objConnection, objSqlTransaction);

                for (int i = 0; i < request.arrFieldInfo.Count; i++)
                {
                    ConstraintFieldImportInfo objFieldInfo = request.arrFieldInfo[i];
                    if (objFieldInfo == null) throw new Exception($"第{i + 1}个字段信息为空!");
                    if (string.IsNullOrEmpty(objFieldInfo.FldName)) throw new Exception($"第{i + 1}个字段名为空!");

                    clsFieldTabEN objFieldTab = arrFieldTab.FirstOrDefault(x => x.FldName == objFieldInfo.FldName);
                    if (objFieldTab == null) throw new Exception($"字段[{objFieldInfo.FldName}]不存在!");

                    if (arrFldIdInTab.Contains(objFieldTab.FldId) == false)
                    {
                        throw new Exception($"字段[{objFieldInfo.FldName}]不在表[{strTabName}]中!");
                    }

                    string strSortTypeId = "01";
                    string strSortTypeName = string.IsNullOrEmpty(objFieldInfo.SortTypeName) ? "升序" : objFieldInfo.SortTypeName.Trim();
                    clsSortTypeEN objSortType = arrSortType.FirstOrDefault(x =>
                        x.SortTypeName == strSortTypeName || x.SortTypeENName == strSortTypeName);
                    if (objSortType != null)
                    {
                        strSortTypeId = objSortType.SortTypeId;
                    }

                    clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
                    objConstraintFieldsEN.PrjConstraintId = strPrjConstraintId;
                    objConstraintFieldsEN.TabId = objPrjTab.TabId;
                    objConstraintFieldsEN.FldId = objFieldTab.FldId;
                    objConstraintFieldsEN.MaxValue = objFieldInfo.MaxValue ?? "";
                    objConstraintFieldsEN.MinValue = objFieldInfo.MinValue ?? "";
                    objConstraintFieldsEN.SortTypeId = strSortTypeId;
                    objConstraintFieldsEN.InUse = objFieldInfo.InUse ?? true;
                    objConstraintFieldsEN.OrderNum = objFieldInfo.OrderNum ?? (i + 1);
                    objConstraintFieldsEN.PrjId = strPrjId;
                    objConstraintFieldsEN.UpdUser = request.strOpUser;
                    objConstraintFieldsEN.Memo = objFieldInfo.Memo ?? "";
                    clsConstraintFieldsBL.AccessFldValueNull(objConstraintFieldsEN);

                    clsConstraintFieldsBL.ConstraintFieldsDA.AddNewRecordBySQL2(
                        objConstraintFieldsEN, objConnection, objSqlTransaction);
                }

                objSqlTransaction.Commit();
                clsPrjConstraintBL.ReFreshCache(strPrjId);
                clsConstraintFieldsBL.ReFreshCache(strPrjId);

                return strPrjConstraintId;
            }
            catch (Exception objException)
            {
                if (objSqlTransaction != null) objSqlTransaction.Rollback();
                string strMsg = $"添加约束及约束字段失败:{objException.Message}({clsStackTrace.GetCurrClassFunction()})";
                throw new Exception(strMsg);
            }
            finally
            {
                if (objConnection != null) objConnection.Close();
            }
        }
    }

    public class AddPrjConstraintWithFieldCheckRequest
    {
        public string strPrjId { get; set; }
        public string strTabName { get; set; }
        public string strConstraintName { get; set; }
        public string strConstraintTypeName { get; set; } // 唯一性/Uniqueness/最大最小值/MaxMinValue
        public string strConstraintDescription { get; set; }
        public List<ConstraintFieldImportInfo> arrFieldInfo { get; set; }
        public string strOpUser { get; set; }
    }

    public class ConstraintFieldImportInfo
    {
        public string FldName { get; set; }
        public string SortTypeName { get; set; } // 升序/降序
        public string MaxValue { get; set; }
        public string MinValue { get; set; }
        public int? OrderNum { get; set; }
        public bool? InUse { get; set; }
        public string Memo { get; set; }
    }
}
 