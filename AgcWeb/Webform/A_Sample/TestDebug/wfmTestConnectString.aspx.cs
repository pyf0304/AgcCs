using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OracleClient;

public partial class Webform_TestDebug_wfmTestConnectString : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnConnect_Click(object sender, EventArgs e)
    {
        //OracleConnection objConn = new OracleConnection();
        //objConn.ConnectionString = txtConnectstring.Text;
        //try
        //{
        //    objConn.Open();
        //    Label1.Text = "连接成功!";
        //}
        //catch (Exception objException)
        //{
        //    Label1.Text = objException.Message;
        //}
    }
}
