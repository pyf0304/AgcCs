using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.taishsoft.datetime;

namespace AgcMvc3.Webform.A_Sample
{
    public partial class TestDateWeek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strBeginDate = txtBeginDate.Text;//2020-06-01
            clsDateTime objDT = new clsDateTime(strBeginDate);
            DateTime objBeginDate = objDT.GetDateTime();

            string strCurrDate = txtCurrDate.Text;//2020-08-01
            clsDateTime objDT2 = new clsDateTime(strCurrDate);
            DateTime objCurrDate = objDT2.GetDateTime();
            var aa = objCurrDate - objBeginDate;
            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("当前日期：{0} 周：{1}", objBeginDate.ToLongDateString(), objBeginDate.DayOfWeek.ToString());
            sbMsg.AppendFormat("现在距开始日期的天数：{0}", aa.TotalDays);

            lblMsg.Text = sbMsg.ToString();
           ;
        }
    }
}