namespace Agc_CsWin.frm.Test
{
    partial class frm建立界面结构树
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateInterfaceHtmlTree = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnGeneCode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateInterfaceHtmlTree
            // 
            this.btnCreateInterfaceHtmlTree.Location = new System.Drawing.Point(37, 30);
            this.btnCreateInterfaceHtmlTree.Name = "btnCreateInterfaceHtmlTree";
            this.btnCreateInterfaceHtmlTree.Size = new System.Drawing.Size(129, 23);
            this.btnCreateInterfaceHtmlTree.TabIndex = 0;
            this.btnCreateInterfaceHtmlTree.Text = "建立界面结构树";
            this.btnCreateInterfaceHtmlTree.UseVisualStyleBackColor = true;
            this.btnCreateInterfaceHtmlTree.Click += new System.EventHandler(this.btnCreateInterfaceHtmlTree_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(37, 78);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(409, 404);
            this.treeView1.TabIndex = 1;
            // 
            // btnGeneCode
            // 
            this.btnGeneCode.Location = new System.Drawing.Point(471, 30);
            this.btnGeneCode.Name = "btnGeneCode";
            this.btnGeneCode.Size = new System.Drawing.Size(129, 23);
            this.btnGeneCode.TabIndex = 2;
            this.btnGeneCode.Text = "根据树生成代码";
            this.btnGeneCode.UseVisualStyleBackColor = true;
            this.btnGeneCode.Click += new System.EventHandler(this.btnGeneCode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(471, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 284);
            this.textBox1.TabIndex = 3;
            // 
            // frm建立界面结构树
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 485);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGeneCode);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnCreateInterfaceHtmlTree);
            this.Name = "frm建立界面结构树";
            this.Text = "frm建立界面结构树";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateInterfaceHtmlTree;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnGeneCode;
        private System.Windows.Forms.TextBox textBox1;
    }
}