using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    public partial class wfmTestJsInvokeCs : System.Web.UI.Page, ICallbackEventHandler
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Button1.Attributes["onclick"] = string.Format("CallServer('BindTextBox|'+'1',{0})", divTest.ClientID);
                //Button2.Attributes["onclick"] = string.Format("CallServer('BindTextBox|'+'1',{0})", divTest.ClientID);

            }
        }
        #region 注册脚本(javascript)
        /// <summary>
        /// 注册脚本(javascript)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_PreRender(object sender, EventArgs e)
        {
            RegClientScript();
            //BindFreeSenate("0");
            //       Page.RegisterStartupScript("tdClick", "<script>document.all.freesenate.click();</script>");
            //ClientScript.RegisterStartupScript(this.GetType(), "tdClick", "<script>document.all.freesenate.click();</script>");
        }
        //protected new void PreRenderComplete(object sender, EventArgs e)
        //{
        //    BindFreeSenate("0");
        //}
        private void RegClientScript()
        {
            string CallServer = @"function CallServer(arg, context){context.innerHTML = 'Loading';" + ClientScript.GetCallbackEventReference(this, "arg", "ReceiveServerData", "context") + "}";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "CallServer", CallServer, true);
        }
        #endregion

        #region 相关信息

      
        #region ICallbackEventHandler Members


        private string _callbackEventArgument;

        public string GetCallbackResult()
        {
            string[] parts = _callbackEventArgument.Split('|');
            object[] args = null;
            string result = "";

            if (parts.Length > 1)
            {
                args = new object[parts.Length - 1];
                Array.Copy(parts, 1, args, 0, args.Length);
            }

            MethodInfo method = this.GetType().GetMethod(parts[0]);
            if (method != null)
            {
                try
                {
                    result = (string)method.Invoke(this, args);
                }
                catch (Exception objException)
                {
                    //ErrorInformationBL.AddInformation("CommCasePlayBase", "GetCallbackResult", "_callbackEventArgument" + _callbackEventArgument + objException.Message, clsCommonSession.UserId);
                    clsCommonJsFunc.Alert(this, objException.Message);
                }
            }
            return result;
        }

        public void RaiseCallbackEvent(string eventArgument)
        {
            _callbackEventArgument = eventArgument;
        }

        void ICallbackEventHandler.RaiseCallbackEvent(string eventArgument)
        {
            this.RaiseCallbackEvent(eventArgument);
        }

        string ICallbackEventHandler.GetCallbackResult()
        {
            return this.GetCallbackResult();
        }
        #endregion

        /// <summary>
        /// 相关信息
        /// </summary>
        /// <param name="Temp"></param>
        /// <returns></returns>
        public string BindTextBox(string Temp)
        {
            TextBox1.Text = "AAA\r\nBBB";

            return RenderControl(TextBox1);
            ////}
            ////else
            ////{
            //return "此课例没有相关信息!";
            ////}
        }
        #endregion

        #region 输出页面的数据流
        /// <summary>
        /// 输出页面的数据流
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private string RenderControl(Control control)
        {
            StringWriter writer1 = new StringWriter(CultureInfo.InvariantCulture);
            HtmlTextWriter writer2 = new HtmlTextWriter(writer1);
            control.RenderControl(writer2);
            writer2.Flush();
            writer2.Close();
            return writer1.ToString();
        }
        #endregion
    }
}