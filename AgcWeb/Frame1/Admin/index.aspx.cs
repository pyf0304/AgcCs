using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AGC.WebSrv;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;

using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace FrameSet.Frame1.Admin
{
    public partial class index : CommWebPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strFunName = Request.Form["FunName"] != null ? Request.Form["FunName"] : "";
            string strMid = Request.Form["hidMid"] != null ? Request.Form["hidMid"] : "";
            //根据传回来的值决定调用哪个函数
            switch (strFunName)
            {
                case "SwitchPrj_Click":
                    SwitchPrj_Click(strMid); //调用该函数
                    break;
                case "其他":
                    //调用其他函数
                  
                    break;
                default:
                    //调用默认函数
                    //lblMsg.Text = "调用默认函数";
                    break;
            }
            if (!IsPostBack)
            {
                string strCurrPrjId = clsPubVar.CurrPrjId;// "0150";
                string strCurrSelPrjId = clsPubVar.CurrSelPrjId;// "0150";
                string strCurrUserRoleId = clsCommonSession.RoleId;// clsPubVar. "00000001";
                string strUserId = clsCommonSession.UserId; //"admin";
                string strCurrPrjDataBaseId = clsPubVar.CurrPrjDataBaseId; //"admin";
                
                BindUserPrj(strUserId);
                SetUserState();
                string strHtml;     //需要插入的HTML代码

                strHtml = clsGeneMenuBLEx.GetUserMenuHTML2(strCurrPrjId, strCurrSelPrjId, strCurrPrjDataBaseId, strCurrUserRoleId, strUserId);

                //6、把菜单HTML菜单串显示到界面上。						
                this.ulPARENT.InnerHtml = strHtml.ToString();
            }
        }
        private void BindUserPrj(string strUserId)
        {
            string strWhereCond = string.Format("UserId='{0}' order by {1} desc, visitednum desc",
              strUserId,
              convUserPrjGrant.LastVisitedDate);
            //System.Data.DataTable objDT = clsUserPrjGrantBL.GetUserPrjGrantT(strWhereCond);
            System.Data.DataTable objDT = clsvUserPrjGrantBL.GetDataTable(strWhereCond);
            List<clsvUserPrjGrantEN> arrvUserPrjGrantObjLst = clsvUserPrjGrantBL.GetObjLst(strWhereCond);
            StringBuilder sbHtml = new StringBuilder();
            sbHtml.AppendFormat(" <ul class=\"header-dropdown-menu\">");
            foreach (clsvUserPrjGrantEN objvUserPrjGrantEN in arrvUserPrjGrantObjLst)
            {
                //ulPrjList.Controls
                //< li >< a href = "./wfmSelectProject.aspx" > 切换项目 </ a ></ li >
                sbHtml.AppendFormat("<li>");
                //sbHtml.AppendFormat("<asp:LinkButton ID=\"lbSwitchPrj{0}\" OnClick = \"lbSwitchPrj_Click\" CommandArgument=\"{0}\" runat=\"server\">{1}|{2}|{3}|{4}</asp:LinkButton>",
                //    objvUserPrjGrantEN.mId, objvUserPrjGrantEN.PrjName);
                sbHtml.AppendFormat("<a id=\"lbSwitchPrj{0}\" href=\"javascript:SwitchPrj('SwitchPrj_Click', '{0}')\">{1}{2}|{3}|{4}|{5}</a>",
                    objvUserPrjGrantEN.mId, objvUserPrjGrantEN.PrjId, objvUserPrjGrantEN.PrjName, objvUserPrjGrantEN.RoleName, objvUserPrjGrantEN.LastVisitedDate, objvUserPrjGrantEN.VisitedNum);

                sbHtml.AppendFormat("</li>");
            }
            sbHtml.AppendFormat("</ul>");
            ulPrjList.InnerHtml = sbHtml.ToString();
        }
        private void SetUserState()
        {
            try
            {
                lblUserName.Text = clsCommonSession. objQxUser.UserName;
                lblRoleName.Text = clsUserRolesBL.GetRoleNameByRoleIdCache(clsCommonSession.RoleId);
                clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);
                clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = clsUserDefaPrjDataBaseBLEx.GetvUserDefaPrjDataBaseObjByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                if (objvUserDefaPrjDataBaseEN != null)
                {
                    lblCurrProject.Text = string.Format("{0}{1}({2}{3})",
                       objProject.PrjId, objProject.PrjName,
                      objvUserDefaPrjDataBaseEN.PrjDataBaseId, objvUserDefaPrjDataBaseEN.PrjDataBaseName);
                }
                else
                {
                    lblCurrProject.Text = string.Format("{0}{1}({2}{3})",
                         objProject.PrjId, objProject.PrjName,
                           objPrjDataBase.PrjDataBaseId, objPrjDataBase.PrjDataBaseName);
                }

            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
            }
        }

     

        protected void SwitchPrj_Click(string strMid)
        {
            //string strMid = lbSwitchPrj.CommandArgument;// this.dgUserPrjGrant.SelectedItem.Cells[0].Text;
            long lngMid = long.Parse(strMid);
            clsUserPrjGrantEN objUserPrjGrant = null;
            try
            {
                StringBuilder sbSql = new StringBuilder();
                sbSql.AppendFormat("Update {0} ", "UserPrjGrant");
                sbSql.AppendFormat(" Set VisitedNum = VisitedNum + 1, {1}='{2}' where Mid = {0} ",
                    lngMid,
                    conUserPrjGrant.LastVisitedDate,
                    clsDateTime.getTodayDateTimeStr(1));
                clsSpecSQLforSql objSql = new clsSpecSQLforSql();
                objSql.ExecSql(sbSql.ToString());
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改访问次数不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //clsPrjTabBLEx.arrPrjTabObjLst = null;
            //clsPrjTabBLEx.arrPrjViewObjLst = null;
            objUserPrjGrant = clsUserPrjGrantBL.GetObjBymId(lngMid);
            new clsCommFun4BL4PrjTab().ReFreshCache(objUserPrjGrant.PrjId);
            
         
            clsPubVar.CurrSelPrjId = objUserPrjGrant.PrjId;
            WS_FieldName.autoCompleteWordList = null;
            WS_FieldName.strPrjId = objUserPrjGrant.PrjId;

            //clsPubVar.CurrSelPrjId = PrjId;
            //clsSysParaEN.strCurrPrjConnectString = clsPubVar.objCurrSelProject.ConnectString;
            ///设置默认的数据库
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objUserPrjGrant.PrjId);
            clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = clsUserDefaPrjDataBaseBLEx.GetvUserDefaPrjDataBaseObjByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            if (objvUserDefaPrjDataBaseEN != null)
            {
                clsPubVar.CurrPrjDataBaseId = objvUserDefaPrjDataBaseEN.PrjDataBaseId;
                new clsCommonSession().PrjDataBaseName = objvUserDefaPrjDataBaseEN.PrjDataBaseName;
            }
            else
            {
                string strDefaPrjDataBaseId = "";
                string strCondition = string.Format("PrjId='{0}'", clsPubVar.CurrSelPrjId);
                clsProjectDatabaseRelEN objProjectDatabaseRelEN = clsProjectDatabaseRelBL.GetFirstObj_S(strCondition);
                if (objProjectDatabaseRelEN == null)
                {
                    string strMsg = string.Format("工程：{0}({1})没有设置相关数据库，请与管理员联系！", objProject.PrjName, objProject.PrjId);

                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                strDefaPrjDataBaseId = objProjectDatabaseRelEN.PrjDataBaseId;
                clsUserDefaPrjDataBaseBLEx.SetPrjDataBaseIdByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId, strDefaPrjDataBaseId);
                clsPubVar.CurrPrjDataBaseId = strDefaPrjDataBaseId;
                clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                clsPubVar.CurrDataBaseTypeId = objPrjDataBase.DataBaseTypeId;
                string strPrjDataBaseName;
                strPrjDataBaseName = objPrjDataBase.DataBaseName;
                new clsCommonSession().PrjDataBaseName = strPrjDataBaseName;
            }
            try
            {
                clsSqlViewBLEx.p_Set_InitLog4CreateView4Sql(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);

                clsDataBaseModuleRelaBLEx.SetDefaDataBaseModuleRela(objProject.PrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("wfmSelectProject", "dgUserPrjGrant_SelectedIndexChanged", objException.Message, clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, objException.Message);
            }
           
            clsCommonSession.RoleId = objUserPrjGrant.RoleId;
            SetUserState();
        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            string strScript = "<script language='javascript'>window.parent.location.href='../../Webform/Index/Index.aspx'; </script>";
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Logout", strScript);
        }

        protected void lbDownLoad_Click(object sender, EventArgs e)
        {
            string strScript = "<script language='javascript'>window.open('../../Webform/DownLoad/wfmDownLoadClsFile.aspx','FileDown'); </script>";
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "FileDownLoad", strScript);
        }
        #region 处理父页面信息以及跳转到其他页面

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":
                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":
                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                                        
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":
                    clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);             
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息

        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }
    }
}