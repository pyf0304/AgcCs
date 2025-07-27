namespace DynamicCompilerWin
{
    partial class frmLexicalAnalysis4TzGCScript
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
            this.txtCode_In = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtCode_Out = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtCode_In
            // 
            this.txtCode_In.Location = new System.Drawing.Point(38, 22);
            this.txtCode_In.Multiline = true;
            this.txtCode_In.Name = "txtCode_In";
            this.txtCode_In.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode_In.Size = new System.Drawing.Size(866, 195);
            this.txtCode_In.TabIndex = 0;
            // 
            // txtCode_Out
            // 
            this.txtCode_Out.Location = new System.Drawing.Point(38, 296);
            this.txtCode_Out.Multiline = true;
            this.txtCode_Out.Name = "txtCode_Out";
            this.txtCode_Out.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode_Out.Size = new System.Drawing.Size(866, 287);
            this.txtCode_Out.TabIndex = 1;
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
            this.button2.Location = new System.Drawing.Point(975, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "打开文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(975, 133);
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
            // frmLexicalAnalysis4TzGCScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 619);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCode_Out);
            this.Controls.Add(this.txtCode_In);
            this.Name = "frmLexicalAnalysis4TzGCScript";
            this.Text = "词法分析TzGCScript1.0";
            this.Load += new System.EventHandler(this.frmLexicalAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode_In;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtCode_Out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}