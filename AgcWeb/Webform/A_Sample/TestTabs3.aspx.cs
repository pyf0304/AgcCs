using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform.A_Samples
{
    public partial class TestTabs3 : System.Web.UI.Page
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                vsCurrTabIndex = 1;
                //li1.arr
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

    }
}