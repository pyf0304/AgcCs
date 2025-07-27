namespace Agc_CsWin.frm.Test
{
    partial class frmTestGCByIncludeTab
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
            this.btnGCPubApp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCharEncodingId = new System.Windows.Forms.ComboBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGCPubApp
            // 
            this.btnGCPubApp.Location = new System.Drawing.Point(242, 76);
            this.btnGCPubApp.Name = "btnGCPubApp";
            this.btnGCPubApp.Size = new System.Drawing.Size(139, 23);
            this.btnGCPubApp.TabIndex = 0;
            this.btnGCPubApp.Text = "生成公共应用后台";
            this.btnGCPubApp.UseVisualStyleBackColor = true;
            this.btnGCPubApp.Click += new System.EventHandler(this.btnGCPubApp_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(22, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "生成文件字符编码";
            // 
            // cboCharEncodingId
            // 
            this.cboCharEncodingId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCharEncodingId.Location = new System.Drawing.Point(158, 214);
            this.cboCharEncodingId.Name = "cboCharEncodingId";
            this.cboCharEncodingId.Size = new System.Drawing.Size(620, 20);
            this.cboCharEncodingId.TabIndex = 35;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(148, 135);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(41, 12);
            this.lblMsg.TabIndex = 37;
            this.lblMsg.Text = "label1";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(527, 104);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 38;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // frmTestGCByIncludeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCharEncodingId);
            this.Controls.Add(this.btnGCPubApp);
            this.Name = "frmTestGCByIncludeTab";
            this.Text = "测试通过包含文件来生成代码";
            this.Load += new System.EventHandler(this.frmTestGCByIncludeTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGCPubApp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCharEncodingId;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnBuild;
    }
}