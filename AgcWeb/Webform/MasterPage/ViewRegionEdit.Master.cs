using AGC.BusinessLogic;
using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using System.Linq;
using com.taishsoft.common;

namespace AGC.Webform
{
    public partial class ViewRegionEdit : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsvViewRegionEN objViewRegion = clsvViewRegionBLEx.GetObjByRegionIdCache(getRegionId, clsCommonSession.CurrSelPrjId);

            clsCommonSession.ApplicationTypeId = objViewRegion.ApplicationTypeId ?? 0;

            lblApplicationTypeName.Text = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(objViewRegion.ApplicationTypeId ?? 0);
            lblRegionName.Text = string.Format("{0}({1})", objViewRegion.RegionName, objViewRegion.RegionId);
            lblRegionTypeName.Text = objViewRegion.RegionTypeName;
            lblTabName.Text = objViewRegion.TabName;

            //lblFldCount.Text = objViewRegion.FldCount.ToString();
            //lblFldCountInUse.Text = objViewRegion.FldCountInUse.ToString();
            List<clsvViewRegionRelaEN> arrViewRegionRela = clsvViewRegionRelaBL.GetObjLstCache(clsCommonSession.CurrSelPrjId).ToList();

            var arrViewRegionRela_Sel = arrViewRegionRela.Where(x => x.RegionId == getRegionId).ToList();

            var arrViewName = arrViewRegionRela_Sel.Select(x => x.ViewName).ToList();
            var strViewNameList = "无";
            if (arrViewName.Count > 0)
            {
                strViewNameList = clsArray.GetSqlInStrByArray(arrViewName, false);
            }

            lblViewNameLst.Text = string.Format("界面数:{0}(列表:{1})", arrViewName.Count, strViewNameList);
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
