using AGC;
using AGC.FunClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform.CommonControl
{
    public partial class TestwucExcelExportRegion4Preview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //vsPrjId = "0116";
            clsPubVar.CurrPrjDataBaseId = "0111";

            //            wucExcelExportRegion4Preview1.ShowButton4Regoin(16691, "0116");
            wucExcelExportRegion4Preview1.ShowControl4Regoin("0000017028", "0116", 5, true);
        }
    }
}