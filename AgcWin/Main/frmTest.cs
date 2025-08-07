using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AGC4WApi;

namespace Agc_CsWin.Main
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnGetFileFromFolder_Click(object sender, EventArgs e)
        {
            string strFolder = @"E:\AspNet2011\GeneralPlatform07";
            string strFileName = "clsSysPara1.cs";
            string strFindFileName = clsUserCodePathExWApi.GetFileFromFolder(strFolder, strFileName);

            lblResult.Text = strFindFileName;
        }

        private void btnSetColor4Text_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("AAA");
            richTextBox1.Select(0, 3);
            richTextBox1.SelectionColor = Color.Red;
            int intStart = richTextBox1.Text.Length;
            richTextBox1.AppendText("BBB");
            int intEnd = richTextBox1.Text.Length;
            richTextBox1.Select(intStart, intEnd);
            richTextBox1.SelectionColor = Color.Blue;
     

            intStart = richTextBox1.Text.Length;

            richTextBox1.AppendText("CCC");
            intEnd = richTextBox1.Text.Length;
            richTextBox1.Select(intStart, intEnd);
            richTextBox1.SelectionColor = Color.Black;

        }
    }
}
