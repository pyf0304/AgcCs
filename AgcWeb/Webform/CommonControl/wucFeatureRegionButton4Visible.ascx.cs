
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
    //public delegate void SelectedIndexChanged(object sender, EventArgs e);
    /// <summary>
    ///		wucEditRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucFeatureRegionButton4Visible : System.Web.UI.UserControl
    {
        //public event SelectedIndexChanged selectedIndexChanged;

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面


        }
        /// <summary>
        /// 设置标题
        /// </summary>
        public string Title
        {
            set
            {
                lblTitle.Text = value;
            }
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
        public void ShowButton4Regoin(string lngRegionId, string strTabName, string strPrjId, bool bolInUse)
        {
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);
            if (bolInUse == false)
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

            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;
            pnlControlLst.Controls.Clear();
            IEnumerable<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, strPrjId, "", true);

            //clsASPControlBLEx.GetControl_Asp();

            List<ASPControlGroupEx> arrControlGroupLst = arrControls
                 .OrderBy(x => x.OrderNum)
                .Select(clsASPControlGroupBLEx.GetControlGroup)
                .OrderBy(x => x.GroupName).ToList();


            IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);

            ASPUlEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
            objASPUlENEx.Class = "nav";
            //objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

            ASPLiEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
            objASPLiENEx.Class = "nav-item";
            objASPLiENEx.Style = "width:250px;";

            objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            //列表标题
            ASPSpanEx objASPSpanENEx = clsASPSpanBLEx.GetDataListTitle("aa", strTabName);
            objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx);


            foreach (ASPControlGroupEx objInFor in arrControlGroupLst_New.OrderBy(x=>x.OrderNum))
            {
                objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item ml-2";
                //clsASPButtonENEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                objASPLiENEx.arrSubAspControlLst2.Add(objInFor);
                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            }

            objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
            objASPLiENEx.Class = "nav-item ml-2";

            objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            //列表标题
            ASPSpanEx objASPSpanENEx_Msg = clsASPSpanBLEx.GetDataListMsg(lngRegionId);
            objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx_Msg);


            //objASPUlENEx.GeneCode(strCodeForCs);
            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objASPUlENEx.GeneHtmlControl(objDiv);// new HtmlGenericControl("");

    
            pnlControlLst.Controls.Add(objDiv);
            divFeatureRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
        }
        private void ShowButton4RegoinV2(string lngRegionId, string strRegionTitleName, string strPrjId)
        {

            lblTitle.Visible = true;
            lblTitleOutUse.Visible = false;


            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;

            List<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, strPrjId, "", true);

            //clsASPControlBLEx.GetControl_Asp();

            List<ASPControlGroupEx> arrControlGroupLst = arrControls
                 .OrderBy(x => x.OrderNum)
                .Select(clsASPControlGroupBLEx.GetControlGroup)
                .OrderBy(x => x.GroupName).ToList();

            if (arrControlGroupLst.Count == 0) return;

            IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);

            ASPUlEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
            objASPUlENEx.Class = "nav";
            //objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

            ASPLiEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
            objASPLiENEx.Class = "nav-item";
            objASPLiENEx.Style = "width:250px;";

            objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            //列表标题
            ASPSpanEx objASPSpanENEx = clsASPSpanBLEx.GetDataListTitle(string.Format("aa{0}", lngRegionId), strRegionTitleName);
            objASPSpanENEx.Text = strRegionTitleName;
            objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx);


            foreach (ASPControlGroupEx objInFor in arrControlGroupLst_New.OrderBy(x => x.OrderNum))
            {
                objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item ml-3";
                //clsASPButtonENEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                objASPLiENEx.arrSubAspControlLst2.Add(objInFor);
                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            }

            objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
            objASPLiENEx.Class = "nav-item ml-3";

            objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
            //列表标题
            ASPSpanEx objASPSpanENEx_Msg = clsASPSpanBLEx.GetDataListMsg(lngRegionId);
            objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx_Msg);


            //objASPUlENEx.GeneCode(strCodeForCs);
            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objASPUlENEx.GeneHtmlControl(objDiv);// new HtmlGenericControl("");


            pnlControlLst.Controls.Add(objDiv);
            
        }

        public void ShowButton4View(string strViewId, List<string> arrRegionTypeLst, string strCmPrjId, string strPrjId)
        {
            pnlControlLst.Controls.Clear();
            //var arrRegionTypeLst = SelectedRegionTypeLst;
           IEnumerable <clsvViewRegionENEx> arrvViewRegion = clsvViewRegionBLEx.GetObjExLstByViewIdCache(strViewId, strCmPrjId);
            arrvViewRegion = arrvViewRegion.Where(x=>x.InUseInViewId(clsCommonSession.ViewId, strCmPrjId) == true).OrderBy(x=>x.RegionTypeOrderNum);
            foreach(clsvViewRegionENEx objInFor in arrvViewRegion)
            {
                if (arrRegionTypeLst.Contains(objInFor.RegionTypeId) == false) continue;
                string strTitle = string.Format("{0}:", objInFor.RegionTypeName);
                ShowButton4RegoinV2(objInFor.RegionId, strTitle, strPrjId);
                if (objInFor.RegionTypeId == enumRegionType.FeatureRegion_0008)
                {
                    divFeatureRegion4Preview.Style["width"] = string.Format("{0}px", objInFor.Width);
                }
            }
          
        }

        public void ShowButton4View(string strRegionId, string strPrjId)
        {
            pnlControlLst.Controls.Clear();
            //var arrRegionTypeLst = SelectedRegionTypeLst;
            //IEnumerable<clsvViewRegionENEx> arrvViewRegion = clsvViewRegionBLEx.GetObjExLstByViewIdCache(strViewId, strPrjId);
            //arrvViewRegion = arrvViewRegion.Where(x => x.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId) == true).OrderBy(x => x.RegionTypeOrderNum);
            //foreach (clsvViewRegionENEx objInFor in arrvViewRegion)
            //{
            //    if (arrRegionTypeLst.Contains(objInFor.RegionTypeId) == false) continue;
            var objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(strRegionId, strPrjId);
                string strTitle = string.Format("{0}:", objvViewRegion.RegionTypeName);
                ShowButton4RegoinV2(objvViewRegion.RegionId, strTitle, strPrjId);
                if (objvViewRegion.RegionTypeId == enumRegionType.FeatureRegion_0008)
                {
                    divFeatureRegion4Preview.Style["width"] = string.Format("{0}px", objvViewRegion.Width);
                }
            //}

        }
    }
}