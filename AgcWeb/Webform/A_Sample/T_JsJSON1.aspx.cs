using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommFunc4WebForm;
using Newtonsoft.Json;

namespace AgcMvc3.Webform.A_Sample
{
    public partial class T_JsJSON1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInVokeParseJson_Click(object sender, EventArgs e)
        {
            //            string jsonText = " {\"firstName\":\"Bill\",\"lastName\":\"Gates\"} ";
            //string jsonText = " \"AA\",\"BB\",\"CC\",\"DD\" ";
            string arrJsonObj = "[{ label: \"My First dataset\", fillColor: \"rgba(220,220,220, 0.2)\", strokeColor: \"#14aae4\", pointColor: \"#14aae4\", pointStrokeColor: \"#fff\", pointHighlightFill: \"#fff\", pointHighlightStroke: \"#14aae4\", data: [23,90,238,162,128,0,51,3,314,0]},"+
                        "{ label: \"My First dataset\",fillColor: \"rgba(220,220,220, 0.2)\",strokeColor: \"#97bbcd\",pointColor: \"#97bbcd\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"#97bbcd\",data: [57,97,152,49,8,207,138,25,38,96]},"+
                        "{ label: \"My First dataset\",fillColor: \"rgba(220,220,220, 0.2)\",strokeColor: \"#FDB45C\",pointColor: \"#FDB45C\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"#FDB45C\",data: [104,28,140,28,112,301,137,28,44,72]},"+
                        "{ label: \"My First dataset\",fillColor: \"rgba(220,220,220, 0.2)\",strokeColor: \"#949FB1\",pointColor: \"#949FB1\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"#949FB1\",data: [36,22,178,114,85,311,131,6,186,198]},"+
                        "{ label: \"My First dataset\",fillColor: \"rgba(220,220,220, 0.2)\",strokeColor: \"#8775a7\",pointColor: \"#8775a7\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"#8775a7\",data: [44,40,171,79,44,293,116,6,114,134]},"+
                        "{ label: \"My First dataset\",fillColor: \"rgba(220,220,220, 0.2)\",strokeColor: \"#4f5c65\",pointColor: \"#4f5c65\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"#4f5c65\",data: [85,47,127,90,233,354,165,48,113,139]},"+
                        "{ label: \"My First dataset\",fillColor: \"rgba(220,220,220, 0.2)\",strokeColor: \"#dcdcdc\",pointColor: \"#dcdcdc\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"#dcdcdc\",data: [53,69,171,90,102,336,211,7,229,32]},"+
                        "{ label: \"My First dataset\",fillColor: \"rgba(220,220,220, 0.2)\",strokeColor: \"red\",pointColor: \"red\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"red\",data: [36,123,110,98,277,271,188,28,29,211]},"+
                        "{ label: \"My First dataset\",fillColor: \"rgba(220,220,220, 0.2)\",strokeColor: \"red\",pointColor: \"red\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"red\",data: [50,69,126,90,245,336,190,19,103,109]}]";
            string arrStr2 = "";
            try
            {
                var arr = JsonConvert.DeserializeObject(arrJsonObj);
                arrStr2 = JsonConvert.SerializeObject(arr);
            }
            catch(Exception objException)
            {
                string str = objException.Message;
            }
        
            hidJsonStr.Value = arrStr2;
            clsCommonJsFunc.RunJs4PageEnd(this, "T_ParseJSONArr()", "T_ParseJSONArr");
        }
    }
}