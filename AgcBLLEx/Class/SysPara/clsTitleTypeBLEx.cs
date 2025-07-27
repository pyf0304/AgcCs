using AGC.BusinessLogic;
using AGC.Entity;

using com.taishsoft.commdb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Collections;

namespace AGC.BusinessLogicEx
{
    public partial class clsTitleStyleBLEx
    {
        public static string GetDefaTitleStyle(string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            sbCondition.Append(" and IsDefault = '1'");
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetFirstObj_S(sbCondition.ToString());
            if (objTitleStyle == null)
            {
                return "";
            }
            return objTitleStyle.TitleStyleId;
        }

        public static System.Data.DataTable GetTitleStyleId(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = "select TitleStyleId, TitleStyleName from TitleStyle where PrjId = '" + strPrjId + "'";
            clsSpecSQLforSql mySql = clsTitleStyleBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_TitleStyleId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTitleStyleId(strPrjId);
            objDDL.DataValueField = "TitleStyleId";
            objDDL.DataTextField = "TitleStyleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 从另一个工程复制标题模式
        /// </summary>
        /// <param name = "strPrjId_T">目标工程ID</param>
        /// <param name = "strPrjId_S">源工程ID</param>
        /// <returns>复制的记录数</returns>
        public static int CopyTitleStyle(string strPrjId_T, string strPrjId_S)
        {
            string strSQL;
            string strTitleStyleId;
            int intRecNum;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow_New;
            ArrayList arrRow = new ArrayList();
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from TitleStyle where PrjId = " + "'" + strPrjId_S + "'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "TitleStyle");
            if (objDS.Tables["TitleStyle"].Rows.Count == 0)
            {
                //MsgBox("没有相应的ID号:TitleStyleId = " + "'"+ objViewInfoENEx.TitleStyleId+"'");
                return 0;
            }
            intRecNum = objDS.Tables["TitleStyle"].Rows.Count;
            int intAdditionValue = 0;
            foreach (System.Data.DataRow objRow in objDS.Tables["TitleStyle"].Rows)
            {
                objRow_New = objDS.Tables["TitleStyle"].NewRow();
                strTitleStyleId = clsGeneralTab.GetMaxStrId("TitleStyle", "TitleStyleId", 8, strPrjId_T, intAdditionValue++);
                objRow_New["TitleStyleId"] = strTitleStyleId;
                objRow_New["PrjId"] = strPrjId_T;
                objRow_New["TitleStyleName"] = objRow["TitleStyleName"];
                objRow_New["TabHeight"] = objRow["TabHeight"];
                objRow_New["TitleTypeId"] = objRow["TitleTypeId"];
                objRow_New["BackColor"] = objRow["BackColor"];
                objRow_New["ImgFile"] = objRow["ImgFile"];
                objRow_New["TabWidth"] = objRow["TabWidth"];
                objRow_New["ForeColor"] = objRow["ForeColor"];
                objRow_New["FontSize"] = objRow["FontSize"];
                objRow_New["FontName"] = objRow["FontName"];
                arrRow.Add(objRow_New);
            }
            foreach (System.Data.DataRow objRow in arrRow)
            {
                objDS.Tables["TitleStyle"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "TitleStyle");
            }
            catch (Exception objException)
            {
                clsGeneralTab2.LogErrorS(objException, "clsTitleStyleEx");
                throw objException;
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
            }
            //			objRow = null;
            return intRecNum;

        }


    }
}
