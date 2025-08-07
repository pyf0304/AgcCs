namespace Agc_CsWin.frm.SystemSet
{
    partial class frmWebServiceSet
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboWebApiIPVirtualPath = new System.Windows.Forms.ComboBox();
            this.btnTestWebApiAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(81, 97);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 27);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "WebApiIP\\虚拟目录";
            // 
            // cboWebApiIPVirtualPath
            // 
            this.cboWebApiIPVirtualPath.FormattingEnabled = true;
            this.cboWebApiIPVirtualPath.Location = new System.Drawing.Point(216, 55);
            this.cboWebApiIPVirtualPath.Name = "cboWebApiIPVirtualPath";
            this.cboWebApiIPVirtualPath.Size = new System.Drawing.Size(279, 22);
            this.cboWebApiIPVirtualPath.TabIndex = 11;
            // 
            // btnTestWebApiAddress
            // 
            this.btnTestWebApiAddress.Location = new System.Drawing.Point(81, 145);
            this.btnTestWebApiAddress.Name = "btnTestWebApiAddress";
            this.btnTestWebApiAddress.Size = new System.Drawing.Size(195, 27);
            this.btnTestWebApiAddress.TabIndex = 12;
            this.btnTestWebApiAddress.Text = "测试WebApi地址是否可用";
            this.btnTestWebApiAddress.UseVisualStyleBackColor = true;
            this.btnTestWebApiAddress.Click += new System.EventHandler(this.btnTestWebApiAddress_Click);
            // 
            // frmWebServiceSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.btnTestWebApiAddress);
            this.Controls.Add(this.cboWebApiIPVirtualPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmWebServiceSet";
            this.Text = "frmWebServiceSet";
            this.Load += new System.EventHandler(this.frmWebServiceSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboWebApiIPVirtualPath;
        private System.Windows.Forms.Button btnTestWebApiAddress;
    }
}