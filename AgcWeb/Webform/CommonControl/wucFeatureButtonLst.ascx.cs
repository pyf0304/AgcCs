
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
    ///		wucEditRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucFeatureButtonLst : System.Web.UI.UserControl
    {

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
        public void ShowFeatureLst(int intApplicationTypeId)
        {
            string strWhereCond = string.Format(" 1 = 1 And {0}='{1}' And {2}='1' ",          
                conPrjFeature.FeatureTypeId,
                enumPrjFeatureType.FrontInterface_01,
                conPrjFeature.InUse);
            IEnumerable<clsPrjFeatureEN> arrPrjFeature = clsPrjFeatureBL.GetObjLstCache()
                                    .Where(x => x.FeatureTypeId == enumPrjFeatureType.FrontInterface_01 && x.InUse == true);

            
                lblTitle.Visible = true;
                lblTitleOutUse.Visible = false;


            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;
            pnlFeatureLst.Controls.Clear();
            IEnumerable<ASPControlEx> arrControls = arrPrjFeature.SelectMany(x=> clsASPButtonBLEx.GetButton(x, intApplicationTypeId));


            
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControls, 2);


            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objTable.GeneHtmlControl(objDiv);

            pnlFeatureLst.Controls.Add(objDiv);
        }
    
    }
}