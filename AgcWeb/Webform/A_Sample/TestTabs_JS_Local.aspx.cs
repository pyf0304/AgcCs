using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestBootStrap.Webform.A_Samples
{
    public partial class TestTabs_JS_Local : System.Web.UI.Page
    {
        public string CurrTabClass(int intTabIndex)
        {
            if (vsCurrTabIndex == intTabIndex)
            {
                return "nav-item active";
            }
            else
            {
                return "nav-item";
            }

        }
        public string TabClass
        {
            get
            {
                return ".myRed";
            }

        }
        public int vsCurrTabIndex
        {
            get
            {
                string sCurrTabIndex;
                sCurrTabIndex = (string)ViewState["CurrTabIndex"];
                if (sCurrTabIndex == null)
                {
                    return 0;
                }
                return int.Parse(sCurrTabIndex);
            }
            set
            {
                string sCurrTabIndex = value.ToString();
                ViewState.Add("CurrTabIndex", sCurrTabIndex);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}