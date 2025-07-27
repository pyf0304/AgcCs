namespace DynamicCompilerWin
{
    partial class frmLexicalAnalysis4Xml
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGeneElementLst = new System.Windows.Forms.Button();
            this.tvNodeObjLst = new System.Windows.Forms.TreeView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGeneScript = new System.Windows.Forms.Button();
            this.btnGeneCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(866, 195);
            this.textBox1.TabIndex = 0;
            // 
            // txtCode2
            // 
            this.txtCode2.Location = new System.Drawing.Point(38, 234);
            this.txtCode2.Multiline = true;
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode2.Size = new System.Drawing.Size(532, 317);
            this.txtCode2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(975, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "词法分析";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(975, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "打开文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(975, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "保存文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGeneElementLst
            // 
            this.btnGeneElementLst.Location = new System.Drawing.Point(975, 76);
            this.btnGeneElementLst.Name = "btnGeneElementLst";
            this.btnGeneElementLst.Size = new System.Drawing.Size(75, 23);
            this.btnGeneElementLst.TabIndex = 5;
            this.btnGeneElementLst.Text = "生成元素";
            this.btnGeneElementLst.UseVisualStyleBackColor = true;
            this.btnGeneElementLst.Click += new System.EventHandler(this.btnGeneElementLst_Click);
            // 
            // tvNodeObjLst
            // 
            this.tvNodeObjLst.Location = new System.Drawing.Point(576, 234);
            this.tvNodeObjLst.Name = "tvNodeObjLst";
            this.tvNodeObjLst.Size = new System.Drawing.Size(474, 388);
            this.tvNodeObjLst.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 557);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(532, 65);
            this.textBox3.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(935, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "建立元素位置范围";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGeneScript
            // 
            this.btnGeneScript.Location = new System.Drawing.Point(975, 105);
            this.btnGeneScript.Name = "btnGeneScript";
            this.btnGeneScript.Size = new System.Drawing.Size(75, 23);
            this.btnGeneScript.TabIndex = 9;
            this.btnGeneScript.Text = "生成脚本";
            this.btnGeneScript.UseVisualStyleBackColor = true;
            this.btnGeneScript.Click += new System.EventHandler(this.btnGeneScript_Click);
            // 
            // btnGeneCode
            // 
            this.btnGeneCode.Location = new System.Drawing.Point(975, 135);
            this.btnGeneCode.Name = "btnGeneCode";
            this.btnGeneCode.Size = new System.Drawing.Size(75, 23);
            this.btnGeneCode.TabIndex = 10;
            this.btnGeneCode.Text = "生成代码";
            this.btnGeneCode.UseVisualStyleBackColor = true;
            this.btnGeneCode.Click += new System.EventHandler(this.btnGeneCode_Click);
            // 
            // frmLexicalAnalysis4Xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 634);
            this.Controls.Add(this.btnGeneCode);
            this.Controls.Add(this.btnGeneScript);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tvNodeObjLst);
            this.Controls.Add(this.btnGeneElementLst);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCode2);
            this.Controls.Add(this.textBox1);
            this.Name = "frmLexicalAnalysis4Xml";
            this.Text = "词法分析1。0--Xml";
            this.Load += new System.EventHandler(this.frmLexicalAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtCode2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGeneElementLst;
        private System.Windows.Forms.TreeView tvNodeObjLst;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGeneScript;
        private System.Windows.Forms.Button btnGeneCode;
    }
}