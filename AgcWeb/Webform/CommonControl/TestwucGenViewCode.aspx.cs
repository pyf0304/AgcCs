using AGC;
using AGC.FunClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AGC.Webform.CommonControl
{
    public partial class TestwucGenViewCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsPubVar.CurrSelPrjId = "0116";
            clsPubVar.CurrPrjDataBaseId = "0111";
            wucGenViewCode1.vsViewId = "01160092";
            //wucGenViewCode1.vsRegionId = 17097;
            wucGenViewCode1.ShowCodeTypeButton();
            //wucGenViewCode1.ShowControl4Regoin(17027, "0116");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //HtmlInputCheckBox objInputCheckBox = new HtmlInputCheckBox();
            ////objInputCheckBox.Attributes["class"] = "form-control";
            //objInputCheckBox.ID = "CtrlId";
            //objInputCheckBox.Name = "CtrlName";
            //objInputCheckBox.Value = "BBB";
            //HtmlGenericControl objLabel = new HtmlGenericControl("Label");
            //objLabel.Attributes["for"] = "CtrlId";
            //objLabel.InnerText = "BBB";
            HtmlGenericControl objDiv = new HtmlGenericControl("div");
           getCheckBox(objDiv);
            Panel1.Controls.Add(objDiv);
      

  
        }
        private void getCheckBox( HtmlContainerControl objContainer)
        {
            HtmlInputCheckBox objInputCheckBox = new HtmlInputCheckBox();
            //objInputCheckBox.Attributes["class"] = "form-control";
            objInputCheckBox.ID = "CtrlId";
            objInputCheckBox.Name = "CtrlName";
            objInputCheckBox.Value = "BBB";
            HtmlGenericControl objLabel = new HtmlGenericControl("Label");
            objLabel.Attributes["for"] = "CtrlId";
            objLabel.InnerText = "BBB";
            objContainer.Controls.Add(objInputCheckBox);
            objContainer.Controls.Add(objLabel);

            //return Tuple.Create(objInputCheckBox, objLabel);
        }
    }
}