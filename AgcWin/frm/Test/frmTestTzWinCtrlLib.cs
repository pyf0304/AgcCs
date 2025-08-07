
using AGC.Entity;
using AGC4WApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agc_CsWin.frm.Test
{
    public partial class frmTestTzWinCtrlLib : Form
    {
        public frmTestTzWinCtrlLib()
        {
            InitializeComponent();
        }

        private void btnBindData_Click(object sender, EventArgs e)
        {
            //List<clsKcCrsTypeEN> arrKcCrsTypeObjLst = clsKcCrsTypeWApi.GetObjLst("1=1");
            string strCondition = string.Format("{0}='1' order by {1}",
                conProgLangType.IsVisible,
                conProgLangType.OrderNum);
            List<clsProgLangTypeEN> arrObj = clsProgLangTypeWApi.GetObjLst(strCondition);
            tzRadioButtonList1.DisplayMember = conProgLangType.ProgLangTypeName;
            tzRadioButtonList1.ValueMember = conProgLangType.ProgLangTypeId;
            tzRadioButtonList1.DataSource = arrObj;
            //tzRadioButtonList1.DataSource = arrKcCrsTypeObjLst;
            tzRadioButtonList1.DataBind();
        }
    }
}
