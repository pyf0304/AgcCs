using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AGC.BusinessLogic;

namespace AGC.Webform.CommonControl
{
    public partial class TestwucFeatureRegionButton4Visible : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //            wucFeatureRegionButton4Visible1.ShowButton4Regoin(16691, "0116");
            var arrRegionType = new List<string> { enumRegionType.FeatureRegion_0008};
            wucFeatureRegionButton4Visible1.ShowButton4View("", arrRegionType,"", "0116");
        }
    }
}