
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AGC.WebSrv;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using System;
using System.Data;
using System.Text;
using System.Web.UI;

namespace AGC.Webform
{
    /// <summary>
    /// roles 的摘要说明。
    /// </summary>
    public partial class wfmSelectProject : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

            if (!IsPostBack)
            {
                clsPubFun.AddReferencedAssemblies(this);
                if (this.UserId == "0")
                {
                    this.ReturnLoginView();
                }
                if (clsCommonSession.CurrPrjId == "0")
                {
                    this.ReturnLoginView();
                }
                this.BindDg_UserPrjGrant();
                this.Check_UserRole();
            }
        }


        public string UserId
        {
            get
            {
                if (Session["UserId"] != null)
                {
                    return Session["UserId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                Session.Add("UserId", value);

            }

        }

        public string UserStateId
        {
            get
            {
                if (Session["UserStateId"] != null)
                {
                    return Session["UserStateId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                Session.Add("UserStateId", value);

            }
        }




        private void BindDg_UserPrjGrant()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //	4、设置DATAGRID的数据源(DataSource)；
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            //string strWhereCond = CombineCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            string strWhereCond = string.Format("UserId='{0}' order by {1} desc, visitednum desc",
                UserId,
                convUserPrjGrant.LastVisitedDate);
            //System.Data.DataTable objDT = clsUserPrjGrantBL.GetUserPrjGrantT(strWhereCond);
            System.Data.DataTable objDT = clsvUserPrjGrantBL.GetDataTable(strWhereCond);
            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //		3.1 首先计算页数；
            //		3.2 如果当前页大于页数就为最后一页
            //	4、设置DATAGRID的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            this.dgUserPrjGrant.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgUserPrjGrant.DataBind();
            //	6、设置记录数的状态，
        }

        protected void dgUserPrjGrant_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            //string strMid = this.dgUserPrjGrant.SelectedItem.Cells[0].Text;
            //long lngMid = long.Parse(strMid);
            //try
            //{
   
            //    clsCommonSession.RoleId = objUserLoginInfo.RoleId;
            //    //Response.Redirect("../FrameSet.htm");  //在这里跳到自己工程的主框架界面

            //    clsPubVar.objLog.WriteDebugLog(clsSysParaEN.getAllSysPara());
            //    clsPubVar.objLog.WriteDebugLog(clsCommonSession.getAllCommonSession());


            //}
            //catch (Exception objException)
            //{
            //    clsCommonSession.seErrMessage = objException.Message;
            //    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    clsPubFun4Web.AccessError(this, conCurrPageName);
            //    return;
            //}
            //Response.Redirect("~/Frame1/Admin/index.aspx");
            string strMid = this.dgUserPrjGrant.SelectedItem.Cells[0].Text;
            long lngMid = long.Parse(strMid);
            stuUserLoginInfo objUserLoginInfo = clsUserPrjGrantBLEx.GetUserLoginInfo(lngMid);
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
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
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
            Response.Write("<script>alert('登陆成功！')</script>");
            clsCommonSession.RoleId = objUserPrjGrant.RoleId;
            //Response.Redirect("../FrameSet.htm");  //在这里跳到自己工程的主框架界面

            clsPubVar.objLog.WriteDebugLog(clsSysParaEN.getAllSysPara());
            clsPubVar.objLog.WriteDebugLog(clsCommonSession.getAllCommonSession());

            Response.Redirect("~/Frame1/Admin/index.aspx");
        }

        private void Check_UserRole()
        {
            if (this.dgUserPrjGrant.Items.Count == 0)
            {
                this.ReturnLoginView();
            }
            else if (this.dgUserPrjGrant.Items.Count == 1)
            {
                clsCommonSession.RoleId = this.dgUserPrjGrant.Items[0].Cells[2].Text;
                Response.Redirect("../FrameSet.htm"); //在这里跳到自己工程的主框架界面
            }
        }

        private void ReturnLoginView()
        {

            Session.Clear();
            string strMsg;
            strMsg = "对不起你的帐号状态不正确，请重新登录!";
            clsCommonJsFunc.Alert(this, strMsg);
            string ss = "<script language='javascript'> parent.window.location.href='../Index.aspx'</script>";
            Response.Write(ss);
            //			Response.Redirect("index.aspx"); //当出现以外状况的时候，跳回到登陆界面

        }
        private string BackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }
        private string ErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)Session["ErrMessage"];
                if (strErrMessage == null)
                {
                    strErrMessage = "";
                }
                return strErrMessage;
            }
            set
            {
                string strErrMessage = value;
                Session.Add("ErrMessage", strErrMessage);
            }
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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage,                         
                        clsStackTrace.GetCurrClassFunction()));
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
