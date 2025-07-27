using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AgcMvc3.Webform.A_Sample
{
    public partial class TestPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HtmlInputText objHtmlInputText = new HtmlInputText();
            objHtmlInputText.Attributes["class"] = "form-control";
            objHtmlInputText.Size = 10;
            objHtmlInputText.ID = "aa1";
            objHtmlInputText.Attributes.Add("onclick", "btn_Click()");
            panel1.Controls.Add(objHtmlInputText);

        }
    }
}