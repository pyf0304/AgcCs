using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AGC4WApi;

namespace Agc_CsWin.frm.Test
{
    public partial class frmTestWebService : Form
    {
        public frmTestWebService()
        {
            InitializeComponent();
        }

        private void frmTestWebService_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string  strIsSuccess = clsTranslateWS.GetFieldCnNameByFieldName("0056", "PrjTab", "TabId");
            string  strIsSuccess = clsTranslateWApi.GetFieldCnNameByFieldName("0056", "PrjTab", "TabId");

            MessageBox.Show(strIsSuccess);
        }
    }
}
