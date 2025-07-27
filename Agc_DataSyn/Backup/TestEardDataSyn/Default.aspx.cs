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
using EcardDataClass;

namespace TestEardDataSyn
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               // gerSSS();
            }
        }

        private void gerSSS()
        {
            clsv_pfy_person objclsv_pfy_person = new clsv_pfy_person("1000008671");
            try
            {
                objclsv_pfy_person.Getv_pfy_person();
                TextBox1.Text = objclsv_pfy_person.Name;
            }
            catch (Exception e)
            {
                Response.Write("<script>alert(" + e.Message + ")</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (EardDadaSyn4Lz())
            {
                TextBox1.Text = "同步成功！";
            }
        }
        public bool EardDadaSyn()
        {
            clsEcardDataSyn objEcardDataSyn = new clsEcardDataSyn();
            objEcardDataSyn.ConditionStr_S = System.Configuration.ConfigurationManager.AppSettings["ConditionStr_S"].ToString();
            objEcardDataSyn.CurrDir = System.Configuration.ConfigurationManager.AppSettings["LogDir"].ToString();
            objEcardDataSyn.ConnectString_S = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString_S"].ToString();
            objEcardDataSyn.ConnectString_T = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString_T"].ToString();
            bool isSuccss = false;
            try
            {
                objEcardDataSyn.DataSynFromEcard();
                isSuccss=true;
            }
            catch(Exception objException)
            {
                TextBox1.Text = objException.Message;
                return isSuccss;
            }
            return isSuccss;

        }

        public bool EardDadaSyn4Lz()
        {
            clsEcardDataSyn objEcardDataSyn = new clsEcardDataSyn();
            objEcardDataSyn.ConditionStr_S = System.Configuration.ConfigurationManager.AppSettings["ConditionStr_S"].ToString();
            objEcardDataSyn.CurrDir = System.Configuration.ConfigurationManager.AppSettings["LogDir"].ToString();
            objEcardDataSyn.ConnectString_S = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString_S"].ToString();
            objEcardDataSyn.ConnectString_T = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString_T"].ToString();
            bool isSuccss = false;
            try
            {
                objEcardDataSyn.DataSynFromEcard4Lz();
                isSuccss = true;
            }
            catch (Exception objException)
            {
                TextBox1.Text = objException.Message;
                return isSuccss;
            }
            return isSuccss;

        }
 
    }
}
