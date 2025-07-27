
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Collections;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;
    using AGC.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using AGC.PureClass;
    using AGC.PureClassEx;

    /// <summary>
    ///		wucQryRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucQryRegion4PreviewV2 : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面


        }
        public class ControlIdComparer : IEqualityComparer<ASPControlEx>
        {
            public bool Equals(ASPControlEx t1, ASPControlEx t2)
            {
                return (t1.CtrlId == t2.CtrlId);
            }
            public int GetHashCode(ASPControlEx t)
            {
                return t.ToString().GetHashCode();
            }
        }
        public void ShowControl4Regoin(string lngRegionId, string strPrjId)
        {
            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;
            clsViewRegionEN obj = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);
            if (obj.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId) == false)
            {
                lblTitle.Visible = false;
                lblTitleOutUse.Visible = true;
                pnlControlLst.Controls.Clear();
                return;
            }
            else
            {
                lblTitle.Visible = true;
                lblTitleOutUse.Visible = false;
            }

            IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroupV2(lngRegionId, clsPubVar.CurrCmPrjId, strPrjId, "");

            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, obj.ColNum ?? 0);

            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objDiv.ID = "container";
            objTable.GeneHtmlControl(objDiv);
            
            pnlControlLst.Controls.Add(objDiv);
            
        }
    }
}