using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    public partial class Main1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbFileDown_Click(object sender, EventArgs e)
        {
            string c1 = "<script language='javascript'>window.open('../DownLoad/wfmDownLoadClsFile.aspx','FileDown'); </script>";
            Response.Write(c1);
        }
    }
}