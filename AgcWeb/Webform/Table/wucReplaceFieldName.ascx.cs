

using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    public partial class wucReplaceFieldName : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string vsTabId
        {
            get
            {
                string strTabId;
                strTabId = (string)ViewState["TabId"];
                if (strTabId == null)
                {
                    strTabId = "";
                }
                return strTabId;
            }
            set
            {
                string strTabId = value;
                ViewState.Add("TabId", strTabId);
            }
        }
        protected void btnSumbitReplace_Click(object sender, EventArgs e)
        {
            string strSourceFieldStr = txtSourceField.Text;
            string strTargetFieldStr = txtTargetField.Text;
            try
            {
                clsPrjTabFldBLEx.ReplaceStringInField(clsPubVar.CurrSelPrjId, vsTabId, strSourceFieldStr, strTargetFieldStr, clsCommonSession.UserId);
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this.Page, objException.Message);
            }
        }
    }
}