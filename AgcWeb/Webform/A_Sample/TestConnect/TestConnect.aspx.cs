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
using System.IO;
using com.taishsoft.commdb;

namespace AGC.Webform
{
    public partial class TestConnect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            Label4.Text = objSQL.ConnectionString;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            Label4.Text = objSQL.ConnectionString;
            try
            {
                if (clsSpecSQLforSql.TestConnect(objSQL.ConnectionString) == true)
                {
                    Label5.Text = "测试连接成功!";
                }
            }
            catch (Exception objException)
            {
                Label5.Text = objException.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string strFileName = com.taishsoft.commdb.clsSpecSQLforSql.WebConfigFileName;
            Label2.Text = com.taishsoft.commdb.clsSpecSQLforSql.WebConfigFileName;
            if (File.Exists(strFileName) == true)
            {
                Label3.Text = strFileName + "存在!";
            }
            else
            {
                Label3.Text = strFileName + "不存在!";
                return;
            }
        }
    }
}
