using AGC.web.treeview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Mvc.tzTreeViewWuc
{
    public partial class TestTreeView4Js : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsTreeViewBindDoubleTable.Bindtv_PrjFeature4Js(TreeView1);
        }
    }
}