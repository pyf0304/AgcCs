using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform.CommonControl
{
    public partial class TestwucQryRegion4PreviewV2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //            wucQryRegion4Preview1.ShowButton4Regoin(16691, "0116");
            wucQryRegion4Preview1.ShowControl4Regoin("0000017025", "0116");
        }
    }
}