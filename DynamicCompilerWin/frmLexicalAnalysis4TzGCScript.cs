using com.taishsoft.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicCompilerWin
{
    public partial class frmLexicalAnalysis4TzGCScript : Form
    {
        //List<clsWord_LA> arrWord = new List<clsWord_LA>();
        //private static string[] 保留字1 ={"bool","break","case","char","do","double","else",
        //"false","float","for","if","int","long","main","new","null","private","protected","public",
        //"static","true","try","typeof","unit","void","while","return","short","sizeof","switch"
        //};
        //全局变量，保留字表
        //        private static string[] reserveWord = {"auto", "break", "case", "char", "const", "continue",
        //"default", "do", "double", "else", "enum", "extern",
        //"float", "for", "goto", "if", "int", "long",
        //"register", "return", "short", "signed", "sizeof", "static",
        //"struct", "switch", "typedef", "union", "unsigned", "void",
        //"volatile", "while"
        //};
       
        public frmLexicalAnalysis4TzGCScript()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //arrWord = new List<clsWord_LA>();
            //arrUserClassTbl = new List<string>();
            //IDentifierTbl = null;
            string strCode_In = txtCode_In.Text;
            if (strCode_In == "")
            {
                MessageBox.Show("您没有输入任何字符！");
                return;
            }
            clsLexicalAnalysis4TzGCScript objLexicalAnalysis4TzGCScript = new clsLexicalAnalysis4TzGCScript(strCode_In);
            objLexicalAnalysis4TzGCScript.CodeLines = txtCode_In.Lines;
          //  strCode_In = objLexicalAnalysis4TzGCScript.fnPretreatment();
            string strCode_Out = null;
            try
            {
                objLexicalAnalysis4TzGCScript.fnAnalyzeV3();

                strCode_Out = objLexicalAnalysis4TzGCScript.fnShowAllWordType();
                txtCode_Out.Text = strCode_Out;
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string dir = openFileDialog1.FileName;
                string text = null;
                StreamReader sr;
                try
                {
                    sr = new StreamReader(dir, System.Text.Encoding.Default);

                }
                catch
                {

                    MessageBox.Show("操作失败");
                    return;
                }
                while (sr.Peek() != -1)
                {
                    text += sr.ReadLine();
                    text += Environment.NewLine;
                }

                sr.Close();
                txtCode_In.Text = text;

                clsLexicalAnalysis4TzGCScript objLexicalAnalysis4TzGCScript = new clsLexicalAnalysis4TzGCScript(text);
                objLexicalAnalysis4TzGCScript.CodeLines = txtCode_In.Lines;
                string strCode_Out = objLexicalAnalysis4TzGCScript.fnPretreatment();

                txtCode_Out.Text = strCode_Out;
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string dir = saveFileDialog1.FileName;
                StreamWriter sw;
                try
                {
                    sw = File.CreateText(dir);

                }
                catch
                {
                    MessageBox.Show("文件创建失败");
                    return;
                }
                string[] text = txtCode_Out.Lines;
                for (int i = 0; i < text.Length; i++)
                {
                    sw.WriteLine(text[i]);
                }
                sw.Close();
            }
        }


        private void frmLexicalAnalysis_Load(object sender, EventArgs e)
        {
            txtCode_In.Text = "int i = 10 ; /*注释部分 */ ?";
        }
     
    }
}
