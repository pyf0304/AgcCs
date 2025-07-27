using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.taishsoft.json;
using Newtonsoft.Json;

namespace AgcMvc3.Webform.A_Sample
{
    public partial class T_JSON1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCombineVarToJSON_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("AAA", "111");
            dictParam.Add("BBB", "222");
            string strJson = clsJSON.GetJsonFromObj(dictParam);
            lblMsg.Text = strJson;
            Dictionary<string, string> objM1 = clsJSON.GetObjFromJson<Dictionary<string, string>>(strJson);
            string strMsg = string.Format("AAA={0}, BBB={1}", objM1["AAA"], objM1["BBB"]);
            lblMsg1.Text = strMsg;
        }
        class myObject {
            public string firstName { get; set; }
            public string lastName { get; set; }

        }
        protected void btnCombineVarToJSON2_Click(object sender, EventArgs e)
        {
            Object objMy = new object();
            string jsonText = " {\"firstName\":\"Bill\",\"lastName\":\"Gates\"} ";
            myObject rb = JsonConvert.DeserializeObject<myObject>(jsonText);

            string strMsg = string.Format("firstName={0}, lastName={1}", rb.firstName, rb.lastName);
            lblMsg1.Text = strMsg;
        }
    }
}