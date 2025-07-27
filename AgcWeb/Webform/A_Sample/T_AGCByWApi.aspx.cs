using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AGC.BusinessLogic;
using AGC4WApi;
using AgcCommBase;

namespace AgcMvc3.Webform.A_Sample
{
    public partial class T_AGCByWApi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAGCByWApi_Click(object sender, EventArgs e)
        {
            clsGCPara objGCPara = new clsGCPara()
            {
                applicationTypeId = (int)AGC4WApi.enumApplicationType.PubApp4WinWeb_7,
                codeTypeId = enumCodeType.BusinessLogic_0003,
                dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType( clsPubConst.DataBaseType.MsSql),
                tabId = "01160063",
                viewId="",
                gcUserId = "pyf",
                prjDataBaseId = "0111",
                prjId ="0116",
                typeParas=""
            };
          clsGCResult objGCResult = AutoGeneCodeWApi.GeneCode(objGCPara);
            txtCode.Text = objGCResult.codeText;
        }
    }
}