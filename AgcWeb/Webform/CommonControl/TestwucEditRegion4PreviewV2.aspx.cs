using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AGC.Webform.CommonControl
{
    public partial class TestwucEditRegion4PreviewV2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //            wucEditRegion4Preview1.ShowButton4Regoin(16691, "0116");
            wucEditRegion4Preview1.ShowControl4Regoin("0000017027", "0116",true, true);
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