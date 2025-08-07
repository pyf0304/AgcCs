namespace DynamicCompilerWin
{
    partial class frmTestMultTree
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateTree = new System.Windows.Forms.Button();
            this.btnGetTree = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreateTree
            // 
            this.btnCreateTree.Location = new System.Drawing.Point(48, 27);
            this.btnCreateTree.Name = "btnCreateTree";
            this.btnCreateTree.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTree.TabIndex = 0;
            this.btnCreateTree.Text = "建立树";
            this.btnCreateTree.UseVisualStyleBackColor = true;
            this.btnCreateTree.Click += new System.EventHandler(this.btnCreateTree_Click);
            // 
            // btnGetTree
            // 
            this.btnGetTree.Location = new System.Drawing.Point(48, 69);
            this.btnGetTree.Name = "btnGetTree";
            this.btnGetTree.Size = new System.Drawing.Size(75, 23);
            this.btnGetTree.TabIndex = 1;
            this.btnGetTree.Text = "获取树";
            this.btnGetTree.UseVisualStyleBackColor = true;
            this.btnGetTree.Click += new System.EventHandler(this.btnGetTree_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(227, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 2;
            // 
            // frmTestMultTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 384);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGetTree);
            this.Controls.Add(this.btnCreateTree);
            this.Name = "frmTestMultTree";
            this.Text = "测试树";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTree;
        private System.Windows.Forms.Button btnGetTree;
        private System.Windows.Forms.ListBox listBox1;
    }
}

