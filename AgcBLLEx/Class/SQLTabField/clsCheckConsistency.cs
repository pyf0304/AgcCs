using AGC.Entity;

using com.taishsoft.commdb;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 功能：
    /// 1、检查一致性
    /// 2、如果不错的记录，在前面的CHECKBOX框中打勾
    /// </summary>
    public class clsCheckConsistency
    {
        /// <summary>
        /// 检查生成代码中表字段与Sql数据库中表字段是否一致
        /// </summary>
        /// <param name="gvAGC">生成代码表字段列表</param>
        /// <param name="gvSQL">Sql数据库中表字段列表</param>
        /// <param name="strTabId">表Id</param>
        public static void CheckConsistency(System.Web.UI.WebControls.GridView gvAGC,
                System.Web.UI.WebControls.GridView gvSQL, string strTabId, string strPrjId)
        {
            //bool bolIsHaveWrong;    //是否有错
            System.Data.DataTable objDT = null;
            string strWhereCond = string.Format( "TabId='{0}' and {1}='0'", strTabId,  convPrjTabFld.IsForExtendClass);    // CombinePrjTabFldCondion();
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
      
            //检查SQL数据库表字段与生成代码中的差异
            if (gvSQL.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow di in gvSQL.Rows)
                {
                    //bolIsHaveWrong = false;
                    string strFldName = di.Cells[1].Text.ToString();
                    clsvPrjTabFldEN objvPrjTabFld = null;
                    di.Cells[6].Text = "";
                    if (IsExistFieldInDT(strFldName, objDT, "FldName") == false)
                    {
                        di.Cells[6].Text = "在生成代码中不存在!";
                        di.Cells[6].ForeColor = System.Drawing.Color.Red;
                        //bolIsHaveWrong = true;
                    }
                    else
                    {
                        string strTypeName = di.Cells[2].Text.ToString();
                        int intLenght = int.Parse(di.Cells[3].Text.ToString());
                        int intPrecision = clsGeneralTab2.TransNullToInt_S(di.Cells[4].Text.ToString());

                        bool bolIs_Nullable_SQL = false;
                        if (di.Cells[5].Text.ToString() == "YES")
                        {
                            bolIs_Nullable_SQL = true;
                        }
                        if (di.Cells[5].Text.ToString() == "Y")
                        {
                            bolIs_Nullable_SQL = true;
                        }

                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("TabId = '{0}'", strTabId);
                        sbCondition.AppendFormat(" and FldName = '{0}'", strFldName);
                        //objvPrjTabFld = clsvPrjTabFldBL.GetFirstObj_S(sbCondition.ToString());
                        List<clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel
                            = clsvPrjTabFldBLEx.GetObjLstByTabIdAndFldNameExCache(strPrjId, strTabId, strFldName);
                        if (arrvPrjTabFldObjLst_Sel.Count == 0) continue;
                        objvPrjTabFld = arrvPrjTabFldObjLst_Sel[0];
                        if (objvPrjTabFld.DataTypeName != strTypeName && objvPrjTabFld.OraDbType != strTypeName)
                        {
                            if (objvPrjTabFld.DataTypeName.ToLower() == "bigint" && strTypeName == "bigint identity"
                                || objvPrjTabFld.DataTypeName.ToLower() == "int" && strTypeName == "int identity")
                            {
                            }
                            else
                            {

                                di.Cells[6].Text = "类型不一致!";
                                di.Cells[6].ForeColor = System.Drawing.Color.Red;
                                //bolIsHaveWrong = true;
                            }
                        }
                        if (objvPrjTabFld.FldLength != intLenght 
                            && objvPrjTabFld.DataTypeName.ToLower() != "decimal"
                            && objvPrjTabFld.DataTypeName.ToLower() != "text"
                            && objvPrjTabFld.DataTypeName.ToLower() != "image")
                        {
                            di.Cells[6].Text += "长度不一致!";
                            di.Cells[6].ForeColor = System.Drawing.Color.Red;
                            //bolIsHaveWrong = true;
                        }

                        if (objvPrjTabFld.FldPrecision != intPrecision
                        && objvPrjTabFld.DataTypeName.ToLower() != "char"
                         && objvPrjTabFld.DataTypeName.ToLower() != "datetime"                
                && objvPrjTabFld.DataTypeName.ToLower() != "text"
                && objvPrjTabFld.DataTypeName.ToLower() != "nvarchar"
                && objvPrjTabFld.DataTypeName.ToLower() != "bool"
                && objvPrjTabFld.DataTypeName.ToLower() != "int"
                && objvPrjTabFld.DataTypeName.ToLower() != "bigint"
                        && objvPrjTabFld.DataTypeName.ToLower() != "varchar")
                        {
                            di.Cells[6].Text += "小数不一致!";
                            di.Cells[6].ForeColor = System.Drawing.Color.Red;
                            //bolIsHaveWrong = true;
                        }
                        if (objPrjTabEN.SqlDsTypeId == "01")
                        {
                            if (objvPrjTabFld.IsTabNullable != bolIs_Nullable_SQL)
                            {

                                di.Cells[6].Text += "<可空>不一致!";
                                di.Cells[6].ForeColor = System.Drawing.Color.Red;
                                //bolIsHaveWrong = true;
                            }
                        }

                    }
                    //if (bolIsHaveWrong==false)
                    //{
                    //    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    //    if (cb != null)
                    //    {
                    //        cb.Checked = true;
                    //    }
                    //}
                }
            }
            bool bolIsSameFldName = false;      //字段名是否一致
            //检查生成代码中表字段与SQL数据库的差异
            if (gvAGC.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow gvrAgc in gvAGC.Rows)
                {
                    string strFldName_Agc = gvrAgc.Cells[5].Text.ToString();
                    string strFldType_Agc = gvrAgc.Cells[6].Text.ToString();
                    int intFldLenght_Agc = int.Parse(gvrAgc.Cells[7].Text.ToString());
                    int intFldPrecision_Agc = clsGeneralTab2.TransNullToInt_S(gvrAgc.Cells[8].Text.ToString());

                    bool bolIs_Nullable_Agc = bool.Parse(gvrAgc.Cells[9].Text.ToString());

                    strFldName_Agc = strFldName_Agc.ToLower().Trim();
                    bolIsSameFldName = false;
                    //bolIsHaveWrong = false;
                    gvrAgc.Cells[14].Text = "";
                    foreach (GridViewRow gvrSQL in gvSQL.Rows)
                    {
                        string strFldName_Sql = gvrSQL.Cells[1].Text.ToString();
                        strFldName_Sql = strFldName_Sql.ToLower().Trim();
                        if (strFldName_Agc == strFldName_Sql)
                        {
                            bolIsSameFldName = true;
                            string strFldType_SQL = gvrSQL.Cells[2].Text.ToString();
                            int intFldLenght_SQL = int.Parse(gvrSQL.Cells[3].Text.ToString());
                            int intFldPrecision_SQL = clsGeneralTab2.TransNullToInt_S(gvrSQL.Cells[4].Text.ToString());

                            bool bolIs_Nullable_SQL = false;
                            if (gvrSQL.Cells[5].Text.ToString() == "YES")
                            {
                                bolIs_Nullable_SQL = true;
                            };
                            if (gvrSQL.Cells[5].Text.ToString() == "Y")
                            {
                                bolIs_Nullable_SQL = true;
                            };
                            if (strFldType_SQL != strFldType_Agc)
                            {
                                if (strFldType_Agc.ToLower() == "bigint" && strFldType_SQL == "bigint identity"
                                    || strFldType_Agc.ToLower() == "int" && strFldType_SQL == "int identity")
                                {
                                }
                                else
                                {
                                    gvrAgc.Cells[14].Text = "类型不一致!";
                                    gvrAgc.Cells[14].ForeColor = System.Drawing.Color.Red;
                                    //bolIsHaveWrong = true;
                                }
                            }
                            if (intFldLenght_SQL != intFldLenght_Agc 
                                && strFldType_SQL != "decimal"
                            && strFldType_SQL != "text"
                            && strFldType_SQL != "image")
                            {
                                gvrAgc.Cells[14].Text += "长度不一致!";
                                gvrAgc.Cells[14].ForeColor = System.Drawing.Color.Red;
                                //bolIsHaveWrong = true;
                            }
                            if (intFldPrecision_SQL != intFldPrecision_Agc
                        && strFldType_SQL != "char"
                                 && strFldType_SQL.ToLower() != "datetime"
                && strFldType_SQL.ToLower() != "text"
                && strFldType_SQL.ToLower() != "nvarchar"
                && strFldType_SQL.ToLower() != "bool"
                && strFldType_SQL.ToLower() != "int"
                && strFldType_SQL.ToLower() != "bigint"
                        && strFldType_SQL != "varchar")
                            {
                                gvrAgc.Cells[14].Text += "小数不一致!";
                                gvrAgc.Cells[14].ForeColor = System.Drawing.Color.Red;
                                //bolIsHaveWrong = true;
                            }
                            if (objPrjTabEN.SqlDsTypeId == "01")
                            {
                                if (bolIs_Nullable_SQL != bolIs_Nullable_Agc)
                                {
                                    gvrAgc.Cells[14].ForeColor = System.Drawing.Color.Red;
                                    gvrAgc.Cells[14].Text += "可空不一致!";
                                    //bolIsHaveWrong = true;
                                }
                            }
                            break;
                        }
                    }
                    if (bolIsSameFldName == false)
                    {
                        gvrAgc.Cells[14].Text = "在SQL库中不存在!";
                        gvrAgc.Cells[14].ForeColor = System.Drawing.Color.Red;
                        //bolIsHaveWrong = true;
                    }
                    //if (bolIsHaveWrong==false)
                    //{
                    //    CheckBox cb = (CheckBox)gvrAgc.FindControl("chkCheckRec");
                    //    if (cb != null)
                    //    {
                    //        cb.Checked = true;
                    //    }
                    //}
                }
            }

        }

        public static void CheckConsistencyBak(System.Web.UI.WebControls.GridView gvAGC,
    System.Web.UI.WebControls.GridView gvSQL, string strTabId)
        {
            //bool bolIsHaveWrong;    //是否有错
            System.Data.DataTable objDT = null;
            string strWhereCond = "TabId='" + strTabId + "'";    // CombinePrjTabFldCondion();
            objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);

            //检查SQL数据库表字段与生成代码中的差异
            if (gvSQL.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow di in gvSQL.Rows)
                {
                    //bolIsHaveWrong = false;
                    string strFldName = di.Cells[1].Text.ToString();
                    clsvPrjTabFldEN objvPrjTabFld = null;
                    di.Cells[5].Text = "";
                    if (IsExistFieldInDT(strFldName, objDT, "FldName") == false)
                    {
                        di.Cells[5].Text = "在生成代码中不存在!";
                        di.Cells[5].ForeColor = System.Drawing.Color.Red;
                        //bolIsHaveWrong = true;
                    }
                    else
                    {
                        string strTypeName = di.Cells[2].Text.ToString();
                        int intLenght = int.Parse(di.Cells[3].Text.ToString());
                        bool bolIs_Nullable_SQL = false;
                        if (di.Cells[4].Text.ToString() == "YES")
                        {
                            bolIs_Nullable_SQL = true;
                        }
                        if (di.Cells[4].Text.ToString() == "Y")
                        {
                            bolIs_Nullable_SQL = true;
                        }

                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("TabId = '{0}'", strTabId);
                        sbCondition.AppendFormat(" and FldName = '{0}'", strFldName);
                        objvPrjTabFld = clsvPrjTabFldBL.GetFirstObj_S(sbCondition.ToString());
                        if (objvPrjTabFld.DataTypeName != strTypeName)
                        {
                            di.Cells[5].Text = "类型不一致!";
                            di.Cells[5].ForeColor = System.Drawing.Color.Red;
                            //bolIsHaveWrong = true;
                        }
                        if (objvPrjTabFld.FldLength != intLenght
                             && strTypeName != "decimal"
                            && strTypeName != "text"
                            && strTypeName != "image")
                        {
                            di.Cells[5].Text += "长度不一致!";
                            di.Cells[5].ForeColor = System.Drawing.Color.Red;
                            //bolIsHaveWrong = true;
                        }
                        if (objvPrjTabFld.IsTabNullable != bolIs_Nullable_SQL)
                        {
                            di.Cells[5].Text += "<可空>不一致!";
                            di.Cells[5].ForeColor = System.Drawing.Color.Red;
                            //bolIsHaveWrong = true;
                        }

                    }
                    //if (bolIsHaveWrong==false)
                    //{
                    //    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    //    if (cb != null)
                    //    {
                    //        cb.Checked = true;
                    //    }
                    //}
                }
            }
            bool bolIsSameFldName = false;      //字段名是否一致
            //检查生成代码中表字段与SQL数据库的差异
            if (gvAGC.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow gvrAgc in gvAGC.Rows)
                {
                    string strFldName_Agc = gvrAgc.Cells[5].Text.ToString();
                    string strFldType_Agc = gvrAgc.Cells[6].Text.ToString();
                    int intFldLenght_Agc = int.Parse(gvrAgc.Cells[7].Text.ToString());
                    bool bolIs_Nullable_Agc = bool.Parse(gvrAgc.Cells[8].Text.ToString());

                    strFldName_Agc = strFldName_Agc.ToLower().Trim();
                    bolIsSameFldName = false;
                    //bolIsHaveWrong = false;
                    gvrAgc.Cells[14].Text = "";
                    foreach (GridViewRow gvrSQL in gvSQL.Rows)
                    {
                        string strFldName_Sql = gvrSQL.Cells[1].Text.ToString();
                        strFldName_Sql = strFldName_Sql.ToLower().Trim();
                        if (strFldName_Agc == strFldName_Sql)
                        {
                            bolIsSameFldName = true;
                            string strFldType_SQL = gvrSQL.Cells[2].Text.ToString();
                            int intFldLenght_SQL = int.Parse(gvrSQL.Cells[3].Text.ToString());
                            bool bolIs_Nullable_SQL = false;
                            if (gvrSQL.Cells[4].Text.ToString() == "YES")
                            {
                                bolIs_Nullable_SQL = true;
                            };
                            if (gvrSQL.Cells[4].Text.ToString() == "Y")
                            {
                                bolIs_Nullable_SQL = true;
                            };
                            if (strFldType_SQL != strFldType_Agc)
                            {
                                gvrAgc.Cells[14].Text = "类型不一致!";
                                gvrAgc.Cells[14].ForeColor = System.Drawing.Color.Red;
                                //bolIsHaveWrong = true;
                            }
                            if (intFldLenght_SQL != intFldLenght_Agc
                                && strFldType_SQL != "decimal"
                            && strFldType_SQL != "text"
                            && strFldType_SQL != "image")
                            {
                                gvrAgc.Cells[14].Text += "长度不一致!";
                                gvrAgc.Cells[14].ForeColor = System.Drawing.Color.Red;
                                //bolIsHaveWrong = true;
                            }
                            if (bolIs_Nullable_SQL != bolIs_Nullable_Agc)
                            {
                                gvrAgc.Cells[14].ForeColor = System.Drawing.Color.Red;
                                gvrAgc.Cells[14].Text += "可空不一致!";
                                //bolIsHaveWrong = true;
                            }
                            break;
                        }
                    }
                    if (bolIsSameFldName == false)
                    {
                        gvrAgc.Cells[14].Text = "在SQL库中不存在!";
                        gvrAgc.Cells[14].ForeColor = System.Drawing.Color.Red;
                        //bolIsHaveWrong = true;
                    }
                    //if (bolIsHaveWrong==false)
                    //{
                    //    CheckBox cb = (CheckBox)gvrAgc.FindControl("chkCheckRec");
                    //    if (cb != null)
                    //    {
                    //        cb.Checked = true;
                    //    }
                    //}
                }
            }

        }

        public static bool IsExistFieldInDT(string strFldName, System.Data.DataTable objDT, string strColumnName)
        {

            foreach (System.Data.DataRow objRow in objDT.Rows)
            {
                string strFldNameB = objRow[strColumnName].ToString().ToLower().Trim();
                if (strFldNameB == strFldName.ToLower().Trim())
                {
                    return true;
                }
            }
            return false;
        }

    }

}
