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
    public partial class Empty : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsViewRegionEN objViewRegion = clsViewRegionBLEx.GetObjByRegionIdCache(getRegionId, clsCommonSession.CurrSelPrjId);
            
            //clsCommonSession.ApplicationTypeId = objViewRegion.ApplicationTypeId;

            //lblRegionName.Text = objViewRegion.RegionName;
            //lblRegionTypeName.Text = clsRegionTypeBL.GetNameByRegionTypeIdCache(objViewRegion.RegionTypeId);
        }
      
        //定义从外面传来的RegionId
        private string qsRegionId
        {
            get
            {
                string strRegionId = Request.QueryString["RegionId"] ?? "".ToString();
                if ((strRegionId != null) && (strRegionId != ""))
                {
                    return strRegionId;//Request.QueryString["id"] ?? "";
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
        protected string getRegionId
        {
            get
            {
                if (string.IsNullOrEmpty(qsRegionId) == false) return qsRegionId;
                return "";
            }
            //set
            //{
            //    clsCommonSession.RegionId4get = value;
            //}
        }

        protected void lbReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../View/wfmViewRegion_QUDI.aspx");
        }
    }
}
