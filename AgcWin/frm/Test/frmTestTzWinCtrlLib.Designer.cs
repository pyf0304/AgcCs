namespace Agc_CsWin.frm.Test
{
    partial class frmTestTzWinCtrlLib
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
            this.tzRadioButtonList1 = new TzWinCtrlLib.TzRadioButtonList();
            this.btnBindData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tzRadioButtonList1
            // 
            this.tzRadioButtonList1.DataSource = null;
            this.tzRadioButtonList1.DisplayMember = null;
            this.tzRadioButtonList1.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.tzRadioButtonList1.Location = new System.Drawing.Point(30, 33);
            this.tzRadioButtonList1.Name = "tzRadioButtonList1";
            this.tzRadioButtonList1.Size = new System.Drawing.Size(164, 27);
            this.tzRadioButtonList1.TabIndex = 0;
            this.tzRadioButtonList1.Value = null;
            this.tzRadioButtonList1.ValueMember = null;
            // 
            // btnBindData
            // 
            this.btnBindData.Location = new System.Drawing.Point(199, 156);
            this.btnBindData.Name = "btnBindData";
            this.btnBindData.Size = new System.Drawing.Size(132, 23);
            this.btnBindData.TabIndex = 2;
            this.btnBindData.Text = "绑定单选按钮列表";
            this.btnBindData.UseVisualStyleBackColor = true;
            this.btnBindData.Click += new System.EventHandler(this.btnBindData_Click);
            // 
            // frmTestTzWinCtrlLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 360);
            this.Controls.Add(this.btnBindData);
            this.Controls.Add(this.tzRadioButtonList1);
            this.Name = "frmTestTzWinCtrlLib";
            this.Text = "frmTestTzWinCtrlLib";
            this.ResumeLayout(false);

        }

        #endregion

        private TzWinCtrlLib.TzRadioButtonList tzRadioButtonList1;
        private System.Windows.Forms.Button btnBindData;
    }
}