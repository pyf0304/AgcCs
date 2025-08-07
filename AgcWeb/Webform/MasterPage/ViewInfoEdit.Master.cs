using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using System.Linq;

namespace AGC.Webform
{
    public partial class ViewInfoEdit : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsViewInfoEN objViewInfo = clsViewInfoBLEx.GetObjByViewIdCache(getViewId, clsCommonSession.CurrSelPrjId);

            lblViewName.Text = string.Format("{0}({1})", objViewInfo.ViewName, objViewInfo.ViewId);
            lblApplicationTypeName.Text = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(objViewInfo.ApplicationTypeId);
            lblInTabName.Text = clsPrjTabBL.GetNameByTabIdCache(objViewInfo.InRelaTabId, objViewInfo.PrjId);
            lblOutTabName.Text = clsPrjTabBL.GetNameByTabIdCache(objViewInfo.OutRelaTabId, objViewInfo.PrjId);
            lblCmPrjName.Text = clsCMProjectBL.GetNameByCmPrjIdCache(objViewInfo.PrjId);

        }

        //定义从外面传来的ViewId
        private string qsViewId
        {
            get
            {
                string strViewId = Request.QueryString["ViewId"] ?? "".ToString();
                if ((strViewId != null) && (strViewId != ""))
                {
                    return strViewId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        //定义从外面传来的ParentPage(前调用页面)
        private string qsParentPage
        {
            get
            {
                string strParentPage = Request.QueryString["ParentPage"] ?? "".ToString();
                if ((strParentPage != null) && (strParentPage != ""))
                {
                    return strParentPage;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 根据传递参数和选择参数决定的课程Id
        /// 功能：如果选择参数不为空，就返回选择参数课程Id，
        ///       否则就返回传递参数课程Id
        /// </summary>
        protected string getViewId
        {
            get
            {
                if (string.IsNullOrEmpty(qsViewId) == false) return qsViewId;
                return "";
            }
            //set
            //{
            //    clsCommonSession.ViewId4get = value;
            //}
        }

        protected void lbReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../View/wfmViewInfo_QUDI.aspx");
        }
    }
}
