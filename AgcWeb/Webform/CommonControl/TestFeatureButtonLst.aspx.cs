using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform.CommonControl
{
    public partial class TestFeatureButtonLst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindBtn_PrjFeature();
        }
        private void BindBtn_PrjFeature()
        {
            // wucTreeView4ViewRegion.tmTreeModel = TreeModel.ViewInfo_PrjFeature_Function4Code;
            wucFeatureButtonLst1.ShowFeatureLst(0);
            //wucTreeView4ViewRegion.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            //string strKeyId = vsKeyId;
            //string strTypeName = vsTreeNodeType;
        }
    }
}