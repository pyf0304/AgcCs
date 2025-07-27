using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CommFunc4WebForm;
using com.taishsoft.commexception;
using com.taishsoft.common;

using com.taishsoft.sql;
using com.taishsoft.commdb;


using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
using AGC.Entity;



namespace AGC.Webform
{

    public partial class wfmGeneSP4MsSql_QUDI2 : System.Web.UI.Page
    {
        //定义从外面传来的ObjId(对象ID)
        private string ObjId_qs
        {
            get
            {
                string strObjId = Request.QueryString["ObjId"] ?? "".ToString();
                if ((strObjId != null) && (strObjId != ""))
                {
                    return strObjId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        //定义从外面传来的ObjId(对象ID)
        private string TabId_qs
        {
            get
            {
                string strTabId = Request.QueryString["TabId"] ?? "".ToString();
                if ((strTabId != null) && (strTabId != ""))
                {
                    return strTabId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        //定义从外面传来的FromWebForm(从什么页面传来)
        private string FromWebForm_qs
        {
            get
            {
                string strFromWebForm = Request.QueryString["FromWebForm"] ?? "".ToString();
                if ((strFromWebForm != null) && (strFromWebForm != ""))
                {
                    return strFromWebForm;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(ObjId_qs) == false)
                {
                    new clsCommonSession().ObjId = ObjId_qs;

                    string strTabId = clsPrjTabBLEx.GetTabIdByObjId(ObjId_qs);
                    clsCommonSession.TabId = strTabId;

                    //编辑工程对象
                    //EditPrjObject(ObjId_qs);
                }
                else if (string.IsNullOrEmpty(TabId_qs) == false)
                {
                    clsCommonSession.TabId = TabId_qs;

                    //转换成相关表ID(TabId)
                    //string strObjId = clsPrjTabBLEx.GetObjIdByTabId(TabId_qs);
                    //new clsCommonSession().ObjId = strObjId;


                    //编辑工程对象
                    //EditPrjTab(TabId_qs);
                }
                else if (string.IsNullOrEmpty(FromWebForm_qs) == false)
                {

                }
                else
                {
                    DispGeneStoreProcedure();
                }
            }
        }

        protected void lbDispObjList_Click(object sender, System.EventArgs e)
        {
            DispObjList();
        }

        private void DispObjList()
        {
            //tabQuery.Visible = true;
            //tabLayout.Visible = false;
        }

        #region "生成MSSQL的存储过程"
        private void DispGeneStoreProcedure()
        {
            //显示不同操作显示区域
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);

            string strTabId = clsCommonSession.TabId;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            lblTabName.Text = string.Format("{0}({1})", objPrjTabEN.TabName, objPrjTabEN.TabCnName);
            clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjIdCache(objPrjTabEN.PrjId);
            string strStoreProcedure = "";
            bool bolIsExist;
            strStoreProcedure = objPrjTabEN.TabName + "_Add";
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(clsPubVar.CurrPrjDataBaseId);
            bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            if (bolIsExist == true)
            {
                chkStoreProcedure_Add.Checked = true;
                chkStoreProcedure_Add.Enabled = false;
            }
            else
            {
                chkStoreProcedure_Add.Checked = false;
            }

            strStoreProcedure = objPrjTabEN.TabName + "_Update";
            bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            if (bolIsExist == true)
            {
                chkStoreProcedure_Update.Checked = true;
                chkStoreProcedure_Update.Enabled = false;
            }
            else
            {
                chkStoreProcedure_Update.Checked = false;
            }

            strStoreProcedure = objPrjTabEN.TabName + "_Delete";
            bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            if (bolIsExist == true)
            {
                chkStoreProcedure_Delete.Checked = true;
                chkStoreProcedure_Delete.Enabled = false;
            }
            else
            {
                chkStoreProcedure_Delete.Checked = false;
            }

            strStoreProcedure = objPrjTabEN.TabName + "_Select";
            bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            if (bolIsExist == true)
            {
                chkStoreProcedure_Select.Checked = true;
                chkStoreProcedure_Select.Enabled = false;
            }
            else
            {
                chkStoreProcedure_Select.Checked = false;
            }
            strStoreProcedure = objPrjTabEN.TabName + "_SelectOne";
            bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            if (bolIsExist == true)
            {
                chkStoreProcedure_SelectOne.Checked = true;
                chkStoreProcedure_SelectOne.Enabled = false;
            }
            else
            {
                chkStoreProcedure_SelectOne.Checked = false;
            }

            strStoreProcedure = objPrjTabEN.TabName + "_SelectByCond";
            bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            if (bolIsExist == true)
            {
                chkStoreProcedure_SelectByCond.Checked = true;
                chkStoreProcedure_SelectByCond.Enabled = false;
            }
            else
            {
                chkStoreProcedure_SelectByCond.Checked = false;
            }

            strStoreProcedure = objPrjTabEN.TabName + "_SelectTop1ByCond";
            bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            if (bolIsExist == true)
            {
                chkStoreProcedure_SelTop1ByCond.Checked = true;
                chkStoreProcedure_SelTop1ByCond.Enabled = false;
            }
            else
            {
                chkStoreProcedure_SelTop1ByCond.Checked = false;
            }
            strStoreProcedure = objPrjTabEN.TabName + "_IsExist";
            bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            if (bolIsExist == true)
            {
                chkStoreProcedure_IsExist.Checked = true;
                chkStoreProcedure_IsExist.Enabled = false;
            }
            else
            {
                chkStoreProcedure_IsExist.Checked = false;
            }
        }

        protected void btnGeneStoreProcedure_Click(object sender, EventArgs e)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(clsPubVar.CurrPrjDataBaseId);
            //string strStoreProcedure = "";
            //bool bolIsExist;

            string strTabId = clsCommonSession.TabId;

            //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
            //clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjIdCache(autoGC5Cs_M.objPrjTabENEx.PrjId);
            //string strTabName = autoGC5Cs_M.objPrjTabENEx.TabName;
            //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
            //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
            //autoGC5Cs_M.objPrjTabENEx.UserId = clsCommonSession.UserId;

            //string strSql = "";
            //try
            //{
            //    if (chkStoreProcedure_Add.Enabled == true
            //        && chkStoreProcedure_Add.Checked == true)
            //    {
            //        strStoreProcedure = autoGC5Cs_M.objPrjTabENEx.TabName + "_Add";
            //        bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            //        if (bolIsExist == false)
            //        {
            //            strSql = autoGC5Cs_M.A_GenStoreProcedure_Add(clsPubVar.CurrPrjDataBaseId);	//已完成
            //            txtCode4StoreProcedure.Text = strSql;
            //            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            //            if (objSQL.ExecSql(strSql) == true)
            //            {
            //                lblMsg_Add.Text = string.Format("新建存储过程:{0} 成功!", strStoreProcedure);
            //            }
            //        }
            //    }
            //    if (chkStoreProcedure_Update.Enabled == true
            //            && chkStoreProcedure_Update.Checked == true)
            //    {
            //        strStoreProcedure = autoGC5Cs_M.objPrjTabENEx.TabName + "_Update";

            //        bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            //        if (bolIsExist == false)
            //        {
            //            strSql = autoGC5Cs_M.A_GenStoreProcedure_Update(clsPubVar.CurrPrjDataBaseId);	//已完成
            //            txtCode4StoreProcedure.Text += strSql;

            //            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            //            if (objSQL.ExecSql(strSql) == true)
            //            {
            //                lblMsg_Update.Text = string.Format("新建存储过程:{0} 成功!", strStoreProcedure);
            //            }
            //        }
            //    }
            //    if (chkStoreProcedure_Delete.Enabled == true
            //            && chkStoreProcedure_Delete.Checked == true)
            //    {
            //        strStoreProcedure = autoGC5Cs_M.objPrjTabENEx.TabName + "_Delete";
            //        bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            //        if (bolIsExist == false)
            //        {
            //            strSql = autoGC5Cs_M.A_GenStoreProcedure_Delete(clsPubVar.CurrPrjDataBaseId);	//已完成
            //            txtCode4StoreProcedure.Text += strSql;
            //            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            //            if (objSQL.ExecSql(strSql) == true)
            //            {
            //                lblMsg_Delete.Text = string.Format("新建存储过程:{0} 成功!", strStoreProcedure);
            //            }
            //        }
            //    }
            //    if (chkStoreProcedure_Select.Enabled == true
            //            && chkStoreProcedure_Select.Checked == true)
            //    {
            //        strStoreProcedure = autoGC5Cs_M.objPrjTabENEx.TabName + "_Select";
            //        bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            //        if (bolIsExist == false)
            //        {
            //            strSql = autoGC5Cs_M.A_GenStoreProcedure_Select(clsPubVar.CurrPrjDataBaseId);	//已完成
            //            txtCode4StoreProcedure.Text += strSql;
            //            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            //            if (objSQL.ExecSql(strSql) == true)
            //            {
            //                lblMsg_Select.Text = string.Format("新建存储过程:{0} 成功!", strStoreProcedure);
            //            }
            //        }
            //    }

            //    if (chkStoreProcedure_SelectOne.Enabled == true
            //            && chkStoreProcedure_SelectOne.Checked == true)
            //    {
            //        strStoreProcedure = autoGC5Cs_M.objPrjTabENEx.TabName + "_SelectOne";
            //        bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            //        if (bolIsExist == false)
            //        {
            //            strSql = autoGC5Cs_M.A_GenStoreProcedure_SelectOne(clsPubVar.CurrPrjDataBaseId);	//已完成
            //            txtCode4StoreProcedure.Text += strSql;
            //            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            //            if (objSQL.ExecSql(strSql) == true)
            //            {
            //                lblMsg_SelectOne.Text = string.Format("新建存储过程:{0} 成功!", strStoreProcedure);
            //            }
            //        }
            //    }

            //    if (chkStoreProcedure_SelectByCond.Enabled == true
            //            && chkStoreProcedure_SelectByCond.Checked == true)
            //    {
            //        strStoreProcedure = autoGC5Cs_M.objPrjTabENEx.TabName + "_SelectByCond";
            //        bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            //        if (bolIsExist == false)
            //        {
            //            strSql = autoGC5Cs_M.A_GenStoreProcedure_SelectByCond(clsPubVar.CurrPrjDataBaseId);	//已完成
            //            txtCode4StoreProcedure.Text += strSql;
            //            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            //            if (objSQL.ExecSql(strSql) == true)
            //            {
            //                lblMsg_SelectByCond.Text = string.Format("新建存储过程:{0} 成功!", strStoreProcedure);
            //            }
            //        }
            //    }
            //    if (chkStoreProcedure_SelTop1ByCond.Enabled == true
            //            && chkStoreProcedure_SelTop1ByCond.Checked == true)
            //    {
            //        strStoreProcedure = autoGC5Cs_M.objPrjTabENEx.TabName + "_SelectTop1ByCond";
            //        bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            //        if (bolIsExist == false)
            //        {
            //            strSql = autoGC5Cs_M.A_GenStoreProcedure_SelectTop1ByCond(clsPubVar.CurrPrjDataBaseId);	//已完成
            //            txtCode4StoreProcedure.Text += strSql;
            //            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            //            if (objSQL.ExecSql(strSql) == true)
            //            {
            //                lblMsg_SelTop1ByCond.Text = string.Format("新建存储过程:{0} 成功!", strStoreProcedure);
            //            }
            //        }
            //    }

            //    if (chkStoreProcedure_IsExist.Enabled == true
            //            && chkStoreProcedure_IsExist.Checked == true)
            //    {
            //        strStoreProcedure = autoGC5Cs_M.objPrjTabENEx.TabName + "_IsExist";
            //        bolIsExist = clsSqlObject.IsExistStoreProcedure(strConnectString, strStoreProcedure, objPrjDataBase.DatabaseOwner);
            //        if (bolIsExist == false)
            //        {
            //            strSql = autoGC5Cs_M.A_GenStoreProcedure_IsExist(clsPubVar.CurrPrjDataBaseId);	//已完成
            //            txtCode4StoreProcedure.Text += strSql;
            //            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            //            if (objSQL.ExecSql(strSql) == true)
            //            {
            //                lblMsg_IsExist.Text = string.Format("新建存储过程:{0} 成功!", strStoreProcedure);
            //            }
            //        }
            //    }

            //}
            //catch (Exception objException)
            //{
            //    if (objException.Message.Length < 30)
            //    {
            //        lblMsg4GeneStoreProcedure.Text = objException.Message;
            //    }
            //    else
            //    {
            //        clsCommonSession.seErrMessage = objException.Message;
            //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
            //        clsPubFun4Web.AccessError(this, conCurrPageName);
            //    }
            //}
        }

        protected void btnGeneSPXmlPara_Click(object sender, EventArgs e)
        {


            string strTabId = clsCommonSession.TabId;

            //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
            //clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjIdCache(autoGC5Cs_M.objPrjTabENEx.PrjId);
            //string strTabName = autoGC5Cs_M.objPrjTabENEx.TabName;
            //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
            //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
            //autoGC5Cs_M.objPrjTabENEx.UserId = clsCommonSession.UserId;

            //string strSql = "";
            //try
            //{
            //    if (chkStoreProcedure_Add.Checked == true)
            //    {
            //        strSql = autoGC5Cs_M.A_GenStoreProcedureXmlParameter_Add();	//已完成
            //        txtCode4StoreProcedure.Text = strSql;
            //    }
            //    if (chkStoreProcedure_Update.Checked == true)
            //    {
            //        strSql = autoGC5Cs_M.A_GenStoreProcedureXmlParameter_Update();	//已完成
            //        txtCode4StoreProcedure.Text += strSql;
            //    }
            //    if (chkStoreProcedure_Delete.Checked == true)
            //    {
            //        strSql = autoGC5Cs_M.A_GenStoreProcedureXmlParameter_Delete();	//已完成
            //        txtCode4StoreProcedure.Text += strSql;
            //    }
            //    if (chkStoreProcedure_Select.Checked == true)
            //    {
            //        strSql = autoGC5Cs_M.A_GenStoreProcedureXmlParameter_Select();	//已完成
            //        txtCode4StoreProcedure.Text += strSql;
            //    }
            //    if (chkStoreProcedure_SelectByCond.Checked == true)
            //    {
            //        strSql = autoGC5Cs_M.A_GenStoreProcedureXmlParameter_SelectByCond();	//已完成
            //        txtCode4StoreProcedure.Text += strSql;
            //    }
            //    if (chkStoreProcedure_SelectOne.Checked == true)
            //    {
            //        strSql = autoGC5Cs_M.A_GenStoreProcedureXmlParameter_SelectOne();	//已完成
            //        txtCode4StoreProcedure.Text += strSql;
            //    }
            //    if (chkStoreProcedure_SelTop1ByCond.Checked == true)
            //    {
            //        strSql = autoGC5Cs_M.A_GenStoreProcedureXmlParameter_SelectTop1ByCond();	//已完成
            //        txtCode4StoreProcedure.Text += strSql;
            //    }
            //    if (chkStoreProcedure_IsExist.Checked == true)
            //    {
            //        strSql = autoGC5Cs_M.A_GenStoreProcedureXmlParameter_IsExist();	//已完成
            //        txtCode4StoreProcedure.Text += strSql;
            //    }
            //}
            //catch (Exception objException)
            //{
            //    if (objException.Message.Length < 30)
            //    {
            //        lblMsg4GeneStoreProcedure.Text = objException.Message;
            //    }
            //    else
            //    {
            //        clsCommonSession.seErrMessage = objException.Message;
            //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
            //        clsPubFun4Web.AccessError(this, conCurrPageName);
            //    }
            //}

        }
        #endregion

    }
}