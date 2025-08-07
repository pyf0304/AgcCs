using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform.JsInvokeCs
{
    public partial class wfmTestPrjTabByWS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTabName.Attributes.Add("onblur", "txtTabName_onblur();");
            txtTabCnName.Attributes.Add("onblur", "txtTabName_onblur();");
            //txtTabName.Attributes.Add("onchange", "txtTabName_onchange();");
            //txtTabCnName.Attributes.Add("onchange", "txtTabName_onchange();");
            //txtTabName.Attributes.Add("onPropertyChange", "txtTabName_onchange();");
            //txtTabCnName.Attributes.Add("onPropertyChange", "txtTabName_onchange();");

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            lblResult.Text = "通过Js函数来单击成功！FldId:" + hidTabId.Value;

        }
    }
}