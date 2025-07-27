using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform.JsInvokeCs
{
    public partial class wfmTestFieldTabByWS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Attributes.Add("onblur", "TestClickByJs();");
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            lblResult.Text = "通过Js函数来单击成功！FldId:" + hidFldId.Value;

        }
    }
}