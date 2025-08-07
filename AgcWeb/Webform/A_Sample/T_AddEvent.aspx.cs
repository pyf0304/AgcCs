using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgcMvc3.Webform.A_Sample
{
    public partial class T_AddEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtSetAttr.Attributes.Add("CtrlId", "abc123");
        }
    }
}