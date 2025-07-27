using System;
using System.Collections.Generic;

using System.Text;
using AGC.Entity;
using com.taishsoft.common;
using System.Data;
using com.taishsoft.commdb;

using com.taishsoft.sql;
using com.taishsoft.datetime;
using AGC.BusinessLogic;
using System.Linq;

namespace AGC.BusinessLogicEx
{

    /// <summary>
    /// 导出Excel设置(ExportExcelSet)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsExportExcelSetBLEx_Static
    {
        public static bool CheckAndSynchDataColumn(this clsExportExcelSetENEx objExportExcelSetENEx, ITranslate objTranslate)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
            sbCondition.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
            sbCondition.AppendFormat(" And UserId='{0}'", objExportExcelSetENEx.UserId);

            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            List<clsColumns> arrColumnsObjLst = clsSqlObject.GetColumnObjList(objExportExcelSetENEx.TabName, mySql.ConnectionString);

            List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst = clsvExportExcel4UsersBL.GetObjLst(sbCondition.ToString());


            int intOrderNum = arrvExportExcel4UsersObjLst.Count + 1;
            foreach (clsColumns objColumns in arrColumnsObjLst)
            {
                string strFieldName = objColumns.Column_Name;
                if (IsContain(arrvExportExcel4UsersObjLst, strFieldName) == true) continue;

                //  string strFieldCnName = clsTranslateWS.GetFieldCnNameByFieldName(objExportExcelSetENEx.strPrjId, objExportExcelSetENEx.TabName, strFieldName);
                string strFieldCnName = objTranslate.GetFieldCnNameByFieldName(objExportExcelSetENEx.strPrjId, objExportExcelSetENEx.TabName, strFieldName);
                if (string.IsNullOrEmpty(strFieldCnName) == true)
                {
                    strFieldCnName = strFieldName;
                }
                clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
                objExportExcel4UsersEN.IdExportExcel4Users = objExportExcelSetENEx.IdExportExcel4Users;
                objExportExcel4UsersEN.FieldName = strFieldName;
                objExportExcel4UsersEN.FieldCnName = strFieldCnName;
                objExportExcel4UsersEN.IsExport = true;
                objExportExcel4UsersEN.UpdDate = objExportExcelSetENEx.UpdDate;
                objExportExcel4UsersEN.UpdUserId = objExportExcelSetENEx.UpdUserId;
                objExportExcel4UsersEN.Memo = "通过自动生成！" + clsDateTime.getTodayStr(0);
                objExportExcel4UsersEN.OrderNum = intOrderNum++;
                clsExportExcel4UsersBL.AddNewRecordBySql2(objExportExcel4UsersEN);
                //arrvExportExcel4UsersObjLst.Add(objExportExcel4UsersEN);
            }

            foreach (clsvExportExcel4UsersEN objExportExcel4UsersEN in arrvExportExcel4UsersObjLst)
            {
                string strFieldName = objExportExcel4UsersEN.FieldName;
                if (arrColumnsObjLst.IsContain(strFieldName) == true) continue;
                clsExportExcel4UsersBL.DelRecord(objExportExcel4UsersEN.mId);
            }
            return true;
        }

        public static bool IsContain(this List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLst, string strColName)
        {
            foreach (clsExportExcel4UsersEN objExportExcel4UsersEN in arrExportExcel4UsersObjLst)
            {
                if (objExportExcel4UsersEN.FieldName.Equals(strColName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsContain(this List<clsvExportExcel4UsersEN> arrExportExcel4UsersObjLst, string strColName)
        {
            foreach (clsvExportExcel4UsersEN objExportExcel4UsersEN in arrExportExcel4UsersObjLst)
            {
                if (objExportExcel4UsersEN.FieldName.Equals(strColName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsContain(this List<clsColumns> arrColumnsObjLst, string strColName)
        {
            foreach (clsColumns objColumns in arrColumnsObjLst)
            {
                if (objColumns.Column_Name.Equals(strColName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class clsExportExcelSetBLEx : clsExportExcelSetBL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strTabAttributeName"></param>
        /// <param name="objExportExcelSetENEx"></param>
        /// <returns></returns>
        public static bool GetExportExcelSetInfo(string[] strTabAttributeName, ITranslate objTranslate, ref clsExportExcelSetENEx objExportExcelSetENEx)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
            sbCondition.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
            sbCondition.Append(" And IsDefaultUser='1'");
            bool bolExist = clsExportExcelSetBL.IsExistRecord(sbCondition.ToString());

            if (bolExist == false)
            {
                objExportExcelSetENEx.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
                objExportExcelSetENEx.IsDefaultUser = true;
                objExportExcelSetENEx.Memo = "通过自动生成！" + clsDateTime.getTodayStr(0);
                clsExportExcelSetBL.AddNewRecordBySql2(objExportExcelSetENEx);
                objExportExcelSetENEx.CheckAndSynchDataColumn(objTranslate);

                if (objExportExcelSetENEx.arrCnName.Count == 0)
                {
                    GetExportExcel4UsersInfo(strTabAttributeName, ref objExportExcelSetENEx);
                }
            }
            else
            {
                objExportExcelSetENEx.IdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
                int intRecCount4TabName = GetColumnCount(objExportExcelSetENEx.TabName);
                int intRecCount4ExportExcel = clsGeneralTab2.funGetRecCountByCond("vExportExcel4Users", sbCondition.ToString());
                if (intRecCount4ExportExcel != intRecCount4TabName)
                {

                    objExportExcelSetENEx.CheckAndSynchDataColumn(objTranslate);
                }
                else
                {
                    CopyExportExcelSetFromDefaultUser(objExportExcelSetENEx);
                    GetExportExcel4UsersInfo(strTabAttributeName, ref objExportExcelSetENEx);

                }
            }
            return true;
        }
        public static bool GetExportExcelSetInfo(ref clsExportExcelSetENEx objExportExcelSetENEx, ITranslate objTranslate)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
            sbCondition.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
            sbCondition.Append(" And IsDefaultUser='1'");
            bool bolExist = clsExportExcelSetBL.IsExistRecord(sbCondition.ToString());

            if (bolExist == false)
            {
                objExportExcelSetENEx.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
                objExportExcelSetENEx.IsDefaultUser = true;
                objExportExcelSetENEx.Memo = "通过自动生成！" + clsDateTime.getTodayStr(0);
                clsExportExcelSetBL.AddNewRecordBySql2(objExportExcelSetENEx);
                objExportExcelSetENEx.CheckAndSynchDataColumn(objTranslate);

                if (objExportExcelSetENEx.arrCnName.Count == 0)
                {
                    GetExportExcel4UsersInfo(ref objExportExcelSetENEx);
                }
            }
            else
            {
                objExportExcelSetENEx.IdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
                int intRecCount4TabName = GetColumnCount(objExportExcelSetENEx.TabName);
                if (intRecCount4TabName == 0)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("表：{0}不存在，或者表:{0}不存在！请检查！", objExportExcelSetENEx.TabName);
                    throw new Exception(sbMsg.ToString());
                }
                int intRecCount4ExportExcel = clsGeneralTab2.funGetRecCountByCond("vExportExcel4Users", sbCondition.ToString());
                if (intRecCount4ExportExcel != intRecCount4TabName)
                {

                    objExportExcelSetENEx.CheckAndSynchDataColumn(objTranslate);
                }
                else
                {
                    CopyExportExcelSetFromDefaultUser(objExportExcelSetENEx);
                    GetExportExcel4UsersInfo(ref objExportExcelSetENEx);

                }
            }
            return true;
        }

        //public static bool GetExportExcelSetInfoBak20161208(ref clsExportExcelSetENEx objExportExcelSetENEx)
        //{
        //    StringBuilder sbCondition = new StringBuilder();
        //    sbCondition.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
        //    sbCondition.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
        //    sbCondition.Append(" And IsDefaultUser='1'");
        //    bool bolExist = clsExportExcelSetBL.IsExistRecord(sbCondition.ToString());

        //    if (bolExist == false)
        //    {
        //        objExportExcelSetENEx.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
        //        objExportExcelSetENEx.IsDefaultUser = true;
        //        objExportExcelSetENEx.Memo = "通过自动生成！" + clsDateTime.getTodayStr(0);
        //        clsExportExcelSetBL.AddNewRecordBySql2(objExportExcelSetENEx);
        //        CheckAndSynchDataColumn(objExportExcelSetENEx);

        //        if (objExportExcelSetENEx.arrCnName.Count == 0)
        //        {
        //            GetExportExcel4UsersInfo(ref objExportExcelSetENEx);
        //        }
        //    }
        //    else
        //    {
        //        objExportExcelSetENEx.IdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
        //        int intRecCount4TabName = GetColumnCount(objExportExcelSetENEx.TabName);
        //        int intRecCount4ExportExcel = clsGeneralTab2.funGetRecCountByCond("vExportExcel4Users", sbCondition.ToString());
        //        if (intRecCount4ExportExcel != intRecCount4TabName)
        //        {

        //            CheckAndSynchDataColumn(objExportExcelSetENEx);
        //        }
        //        else
        //        {
        //            CopyExportExcelSetFromDefaultUser(objExportExcelSetENEx);
        //            GetExportExcel4UsersInfo(ref objExportExcelSetENEx);

        //        }
        //    }
        //    return true;
        //}
        public static bool IsContain(List<string> arrColName, string strColName)
        {
            foreach (string strSourceCol in arrColName)
            {
                if (strSourceCol.Equals(strColName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return true;
                }
            }
            return false;
        }


        public static int GetColumnCount(string strTabName)
        {
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            int intColumnCount = mySql.GetColumnsCount(strTabName);
            return intColumnCount;
        }
        public static bool CheckAndSynchDataColumn(string strId_ExportExcel4Users, ITranslate objTranslate)
        {
            clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN(strId_ExportExcel4Users);
            clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);

            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = objExportExcelSetEN.ViewName;
            objExportExcelSetENEx.TabName = objExportExcelSetEN.TabName;
            objExportExcelSetENEx.UserId = objExportExcelSetEN.UserId;
            objExportExcelSetENEx.IdExportExcel4Users = strId_ExportExcel4Users;
            return objExportExcelSetENEx.CheckAndSynchDataColumn(objTranslate);
        }

        public static bool GetExportExcel4UsersInfo(string[] strTabAttributeName, ref clsExportExcelSetENEx objExportExcelSetENEx)
        {
            StringBuilder sbCondition4 = new StringBuilder();
            sbCondition4.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
            sbCondition4.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
            sbCondition4.AppendFormat(" And UserId='{0}'", objExportExcelSetENEx.UserId);
            sbCondition4.Append(" And  IsExport='1'");
            sbCondition4.Append(" Order by OrderNum");

            List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst = clsvExportExcel4UsersBL.GetObjLst(sbCondition4.ToString());
            if (arrvExportExcel4UsersObjLst.Count == 0) return true;
            objExportExcelSetENEx.arrColName = new List<string>();
            objExportExcelSetENEx.arrCnName = new List<string>();
            objExportExcelSetENEx.ExportFileName = arrvExportExcel4UsersObjLst[0].ExportFileName;
            foreach (clsvExportExcel4UsersEN objExportExcel4UsersEN in arrvExportExcel4UsersObjLst)
            {
                if (objExportExcelSetENEx.arrCnName.Contains(objExportExcel4UsersEN.FieldCnName) == true)
                {
                    continue;
                }
                if (strTabAttributeName.Contains(objExportExcel4UsersEN.FieldName) == true)
                {
                    objExportExcelSetENEx.arrColName.Add(objExportExcel4UsersEN.FieldName);
                    objExportExcelSetENEx.arrCnName.Add(objExportExcel4UsersEN.FieldCnName);
                }
            }
            return true;
        }
        public static bool GetExportExcel4UsersInfoBak20161208(ref clsExportExcelSetENEx objExportExcelSetENEx)
        {
            StringBuilder sbCondition4 = new StringBuilder();
            sbCondition4.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
            sbCondition4.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
            sbCondition4.AppendFormat(" And UserId='{0}'", objExportExcelSetENEx.UserId);
            sbCondition4.Append(" And  IsExport='1'");
            sbCondition4.Append(" Order by OrderNum");

            List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst = clsvExportExcel4UsersBL.GetObjLst(sbCondition4.ToString());
            if (arrvExportExcel4UsersObjLst.Count == 0) return true;
            objExportExcelSetENEx.arrColName = new List<string>();
            objExportExcelSetENEx.arrCnName = new List<string>();
            objExportExcelSetENEx.ExportFileName = arrvExportExcel4UsersObjLst[0].ExportFileName;
            foreach (clsvExportExcel4UsersEN objExportExcel4UsersEN in arrvExportExcel4UsersObjLst)
            {
                if (objExportExcelSetENEx.arrCnName.Contains(objExportExcel4UsersEN.FieldCnName) == true)
                {
                    continue;
                }
                objExportExcelSetENEx.arrColName.Add(objExportExcel4UsersEN.FieldName);
                objExportExcelSetENEx.arrCnName.Add(objExportExcel4UsersEN.FieldCnName);
            }
            return true;
        }

        public static bool CopyExportExcelField4UsersFromDefaultUser(string strId_ExportExcel4Users)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("Id_ExportExcel4Users='{0}'", strId_ExportExcel4Users);
            clsExportExcel4UsersBL.DelExportExcel4UserssByCond(sbCondition.ToString());

            clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN(strId_ExportExcel4Users);
            clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);

            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = objExportExcelSetEN.ViewName;
            objExportExcelSetENEx.TabName = objExportExcelSetEN.TabName;
            objExportExcelSetENEx.UserId = objExportExcelSetEN.UserId;
            objExportExcelSetENEx.IdExportExcel4Users = strId_ExportExcel4Users;
            return CopyExportExcelField4UsersFromDefaultUser(objExportExcelSetENEx);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objExportExcelSetENEx"></param>
        /// <returns></returns>
        public static bool CopyExportExcelSetFromDefaultUser(clsExportExcelSetENEx objExportExcelSetENEx)
        {
            StringBuilder sbCondition2 = new StringBuilder();
            sbCondition2.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
            sbCondition2.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
            sbCondition2.AppendFormat(" And UserId='{0}'", objExportExcelSetENEx.UserId);
            bool bolExist2 = clsExportExcelSetBL.IsExistRecord(sbCondition2.ToString());
            if (bolExist2 == false)
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
                sbCondition.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
                sbCondition.Append(" And IsDefaultUser='1'");

                //如果该用户不存在Excel导出的字段设置
                clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.GetFirstObj_S(sbCondition.ToString());
                objExportExcelSetEN.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
                objExportExcelSetEN.UserId = objExportExcelSetENEx.UserId;
                objExportExcelSetEN.UpdDate = objExportExcelSetENEx.UpdDate;
                objExportExcelSetEN.UpdUserId = objExportExcelSetENEx.UpdUserId;
                objExportExcelSetEN.IsDefaultUser = false;
                objExportExcelSetEN.Memo = "通过复制缺省设置生成！" + clsDateTime.getTodayStr(0);

                clsExportExcelSetBL.AddNewRecordBySql2(objExportExcelSetEN);

                //StringBuilder sbCondition3 = new StringBuilder();
                //sbCondition3.AppendFormat("IdExportExcel4Users='{0}'", objExportExcelSetENEx.IdExportExcel4Users);
                //sbCondition3.Append(" And IdExportExcel4Users in (select IdExportExcel4Users From  ExportExcel4Users IsDefaultUser='1'");
                List<clsvExportExcel4UsersEN> arrExportExcel4UsersObjLst = clsvExportExcel4UsersBL.GetObjLst(sbCondition.ToString());
                foreach (clsvExportExcel4UsersEN objvExportExcel4UsersEN in arrExportExcel4UsersObjLst)
                {
                    clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
                    objExportExcel4UsersEN.FieldName = objvExportExcel4UsersEN.FieldName;
                    objExportExcel4UsersEN.FieldCnName = objvExportExcel4UsersEN.FieldCnName;
                    objExportExcel4UsersEN.IsExport = objvExportExcel4UsersEN.IsExport;
                    objExportExcel4UsersEN.OrderNum = objvExportExcel4UsersEN.OrderNum ?? 0;

                    objExportExcel4UsersEN.IdExportExcel4Users = objExportExcelSetEN.IdExportExcel4Users;
                    objExportExcel4UsersEN.UpdDate = objExportExcelSetEN.UpdDate;
                    objExportExcel4UsersEN.UpdUserId = objExportExcelSetEN.UpdUserId;
                    objExportExcel4UsersEN.Memo = "通过复制缺省设置生成！" + clsDateTime.getTodayStr(0);
                    string strCondition4Exist = string.Format("IdExportExcel4Users='{0}' And FieldName='{1}'",
                        objExportExcel4UsersEN.IdExportExcel4Users, objExportExcel4UsersEN.FieldName);
                    if (clsExportExcel4UsersBL.IsExistRecord(strCondition4Exist) == false)
                    {
                        clsExportExcel4UsersBL.AddNewRecordBySql2(objExportExcel4UsersEN);
                    }
                }
            }

            return true;
        }
        public static bool CopyExportExcelField4UsersFromDefaultUser(clsExportExcelSetENEx objExportExcelSetENEx)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
            sbCondition.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
            sbCondition.Append(" And IsDefaultUser='1'");

            List<clsvExportExcel4UsersEN> arrExportExcel4UsersObjLst = clsvExportExcel4UsersBL.GetObjLst(sbCondition.ToString());
            foreach (clsvExportExcel4UsersEN objvExportExcel4UsersEN in arrExportExcel4UsersObjLst)
            {
                clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
                objExportExcel4UsersEN.FieldName = objvExportExcel4UsersEN.FieldName;
                objExportExcel4UsersEN.FieldCnName = objvExportExcel4UsersEN.FieldCnName;
                objExportExcel4UsersEN.IsExport = objvExportExcel4UsersEN.IsExport;
                objExportExcel4UsersEN.OrderNum = objvExportExcel4UsersEN.OrderNum ?? 0;

                objExportExcel4UsersEN.IdExportExcel4Users = objExportExcelSetENEx.IdExportExcel4Users;
                objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayStr(0);
                objExportExcel4UsersEN.UpdUserId = objExportExcelSetENEx.UpdUserId;
                objExportExcel4UsersEN.Memo = "通过复制缺省设置生成！" + clsDateTime.getTodayStr(0);
                clsExportExcel4UsersBL.AddNewRecordBySql2(objExportExcel4UsersEN);
            }

            return true;
        }
        public static bool GetExportExcel4UsersInfo(ref clsExportExcelSetENEx objExportExcelSetENEx)
        {
            StringBuilder sbCondition4 = new StringBuilder();
            sbCondition4.AppendFormat("ViewName='{0}'", objExportExcelSetENEx.ViewName);
            sbCondition4.AppendFormat(" And TabName='{0}'", objExportExcelSetENEx.TabName);
            sbCondition4.AppendFormat(" And UserID='{0}'", objExportExcelSetENEx.UserId);
            sbCondition4.Append(" And  IsExport='1'");
            sbCondition4.Append(" Order by OrderNum");

            List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst = clsvExportExcel4UsersBL.GetObjLst(sbCondition4.ToString());
            if (arrvExportExcel4UsersObjLst.Count == 0) return true;
            objExportExcelSetENEx.arrColName = new List<string>();
            objExportExcelSetENEx.arrCnName = new List<string>();
            objExportExcelSetENEx.ExportFileName = arrvExportExcel4UsersObjLst[0].ExportFileName;
            foreach (clsvExportExcel4UsersEN objExportExcel4UsersEN in arrvExportExcel4UsersObjLst)
            {
                objExportExcelSetENEx.arrColName.Add(objExportExcel4UsersEN.FieldName);
                objExportExcelSetENEx.arrCnName.Add(objExportExcel4UsersEN.FieldCnName);
            }
            return true;
        }

        public static bool CheckAndSynchDataColumn(string strId_ExportExcel4Users, string strCurrPrjId4AgcCs, string strUpdUserId, ITranslate objTranslate)
        {

            clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN(strId_ExportExcel4Users);
            clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);

            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = objExportExcelSetEN.ViewName;
            objExportExcelSetENEx.TabName = objExportExcelSetEN.TabName;
            objExportExcelSetENEx.UserId = objExportExcelSetEN.UserId;
            objExportExcelSetENEx.IdExportExcel4Users = strId_ExportExcel4Users;
            objExportExcelSetENEx.strPrjId = strCurrPrjId4AgcCs;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objExportExcelSetENEx.UpdUserId = strUpdUserId;
            return objExportExcelSetENEx.CheckAndSynchDataColumn(objTranslate);
        }
    }
}
