namespace Agc_CsWin.Main
{
    partial class frmTest
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
            this.btnGetFileFromFolder = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSetColor4Text = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetFileFromFolder
            // 
            this.btnGetFileFromFolder.Location = new System.Drawing.Point(49, 33);
            this.btnGetFileFromFolder.Name = "btnGetFileFromFolder";
            this.btnGetFileFromFolder.Size = new System.Drawing.Size(108, 23);
            this.btnGetFileFromFolder.TabIndex = 0;
            this.btnGetFileFromFolder.Text = "从目录找文件";
            this.btnGetFileFromFolder.UseVisualStyleBackColor = true;
            this.btnGetFileFromFolder.Click += new System.EventHandler(this.btnGetFileFromFolder_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(178, 38);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(29, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(528, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnSetColor4Text
            // 
            this.btnSetColor4Text.Location = new System.Drawing.Point(66, 185);
            this.btnSetColor4Text.Name = "btnSetColor4Text";
            this.btnSetColor4Text.Size = new System.Drawing.Size(187, 23);
            this.btnSetColor4Text.TabIndex = 3;
            this.btnSetColor4Text.Text = "设置多颜色文本";
            this.btnSetColor4Text.UseVisualStyleBackColor = true;
            this.btnSetColor4Text.Click += new System.EventHandler(this.btnSetColor4Text_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 349);
            this.Controls.Add(this.btnSetColor4Text);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGetFileFromFolder);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetFileFromFolder;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSetColor4Text;
    }
}