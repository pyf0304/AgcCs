namespace Agc_CsWin.frm.Test
{
    partial class frm扩展对象列表
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
            this.btnBindExObjLst = new System.Windows.Forms.Button();
            this.chkIsForSilverLight = new System.Windows.Forms.CheckBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnCtlControlCode_Web = new System.Windows.Forms.Button();
            this.btnGenControlCode_Web = new System.Windows.Forms.Button();
            this.btnGenViewCode_Web = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBindExObjLst
            // 
            this.btnBindExObjLst.Location = new System.Drawing.Point(31, 14);
            this.btnBindExObjLst.Name = "btnBindExObjLst";
            this.btnBindExObjLst.Size = new System.Drawing.Size(120, 27);
            this.btnBindExObjLst.TabIndex = 0;
            this.btnBindExObjLst.Text = "绑定对象列表";
            this.btnBindExObjLst.UseVisualStyleBackColor = true;
            this.btnBindExObjLst.Click += new System.EventHandler(this.btnBindExObjLst_Click);
            // 
            // chkIsForSilverLight
            // 
            this.chkIsForSilverLight.AutoSize = true;
            this.chkIsForSilverLight.Location = new System.Drawing.Point(205, 34);
            this.chkIsForSilverLight.Name = "chkIsForSilverLight";
            this.chkIsForSilverLight.Size = new System.Drawing.Size(131, 18);
            this.chkIsForSilverLight.TabIndex = 20;
            this.chkIsForSilverLight.Text = "针对SilverLight";
            this.chkIsForSilverLight.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(31, 128);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode.Size = new System.Drawing.Size(692, 282);
            this.txtCode.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 27);
            this.button3.TabIndex = 24;
            this.button3.Text = "表控件View代码";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(316, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(49, 14);
            this.lblMsg.TabIndex = 25;
            this.lblMsg.Text = "label1";
            // 
            // btnCtlControlCode_Web
            // 
            this.btnCtlControlCode_Web.Location = new System.Drawing.Point(168, 96);
            this.btnCtlControlCode_Web.Name = "btnCtlControlCode_Web";
            this.btnCtlControlCode_Web.Size = new System.Drawing.Size(148, 26);
            this.btnCtlControlCode_Web.TabIndex = 26;
            this.btnCtlControlCode_Web.Text = "表控件Control代码";
            // 
            // btnGenControlCode_Web
            // 
            this.btnGenControlCode_Web.Location = new System.Drawing.Point(437, 96);
            this.btnGenControlCode_Web.Name = "btnGenControlCode_Web";
            this.btnGenControlCode_Web.Size = new System.Drawing.Size(138, 26);
            this.btnGenControlCode_Web.TabIndex = 28;
            this.btnGenControlCode_Web.Text = "界面Control代码";
            // 
            // btnGenViewCode_Web
            // 
            this.btnGenViewCode_Web.Location = new System.Drawing.Point(316, 96);
            this.btnGenViewCode_Web.Name = "btnGenViewCode_Web";
            this.btnGenViewCode_Web.Size = new System.Drawing.Size(108, 26);
            this.btnGenViewCode_Web.TabIndex = 27;
            this.btnGenViewCode_Web.Text = "界面View代码";
            // 
            // frm扩展对象列表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 497);
            this.Controls.Add(this.btnCtlControlCode_Web);
            this.Controls.Add(this.btnGenControlCode_Web);
            this.Controls.Add(this.btnGenViewCode_Web);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.chkIsForSilverLight);
            this.Controls.Add(this.btnBindExObjLst);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frm扩展对象列表";
            this.Text = "frm扩展对象列表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBindExObjLst;
   
        private System.Windows.Forms.CheckBox chkIsForSilverLight;
        private System.Windows.Forms.TextBox txtCode;
    

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnCtlControlCode_Web;
        private System.Windows.Forms.Button btnGenControlCode_Web;
        private System.Windows.Forms.Button btnGenViewCode_Web;
    }
}