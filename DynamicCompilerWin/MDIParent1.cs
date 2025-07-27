using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicCompilerWin
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void 测试动态编译生成代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTestGeneCodeByDynamicCompiler().Show();
        }

        private void 词法分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLexicalAnalysis().Show();
        }

        private void 词法分析v2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLexicalAnalysisV2().Show();
        }
              

        private void 词法分析CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLexicalAnalysis4CSharp().Show();
        }

        private void 词法分析JsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmLexicalAnalysis4Js().Show();
        }

        private void 测试家庭树ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTestFamilyTree().Show();
        }

        private void 词法分析TzGCScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLexicalAnalysis4TzGCScript().Show();
        }

        private void 测试动态编译生成代码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmTestGeneCodeByDynamicCompiler().Show();
        }

        private void 通过串名称调用属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInvokePropertyByString().Show();
        }

        private void 词法分析SqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLexicalAnalysis4Sql().Show();
        }

        private void 词法分析XmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLexicalAnalysis4Xml().Show();
        }
    }
}
