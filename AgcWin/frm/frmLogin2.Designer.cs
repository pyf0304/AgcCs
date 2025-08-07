using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Data;
using CommFunc4Win;
using AGC.Entity;

using com.taishsoft.common;
using GeneralPlatform4WApi;
using GeneralPlatform.Entity;
using AGC4WApi;

namespace Agc_CsWin
{
    partial class frmLogin2
    {
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdatePassWord;
        private System.Windows.Forms.Button btnGetbackPassWord;
        private System.Windows.Forms.Button btnEnterSys;
        private System.Windows.Forms.PictureBox icon_name;
        private System.Windows.Forms.Label lbshan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Label label7;
        private Label label8;
        private Label label9;
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

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdatePassWord = new System.Windows.Forms.Button();
            this.btnGetbackPassWord = new System.Windows.Forms.Button();
            this.btnEnterSys = new System.Windows.Forms.Button();
            this.icon_name = new System.Windows.Forms.PictureBox();
            this.lbshan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(432, 272);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(160, 23);
            this.txtUserID.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(432, 312);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(160, 23);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassWord_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(424, 360);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(64, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登  陆";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(496, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "取消";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdatePassWord
            // 
            this.btnUpdatePassWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdatePassWord.Location = new System.Drawing.Point(771, 472);
            this.btnUpdatePassWord.Name = "btnUpdatePassWord";
            this.btnUpdatePassWord.Size = new System.Drawing.Size(76, 23);
            this.btnUpdatePassWord.TabIndex = 6;
            this.btnUpdatePassWord.Text = "修改密码";
            this.btnUpdatePassWord.Visible = false;
            this.btnUpdatePassWord.Click += new System.EventHandler(this.btnUpdatePassWord_Click);
            // 
            // btnGetbackPassWord
            // 
            this.btnGetbackPassWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetbackPassWord.Location = new System.Drawing.Point(695, 472);
            this.btnGetbackPassWord.Name = "btnGetbackPassWord";
            this.btnGetbackPassWord.Size = new System.Drawing.Size(75, 23);
            this.btnGetbackPassWord.TabIndex = 7;
            this.btnGetbackPassWord.Text = "找回密码";
            this.btnGetbackPassWord.Visible = false;
            this.btnGetbackPassWord.Click += new System.EventHandler(this.btnGetbackPassWord_Click);
            // 
            // btnEnterSys
            // 
            this.btnEnterSys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnterSys.Location = new System.Drawing.Point(613, 472);
            this.btnEnterSys.Name = "btnEnterSys";
            this.btnEnterSys.Size = new System.Drawing.Size(82, 23);
            this.btnEnterSys.TabIndex = 8;
            this.btnEnterSys.Text = "进入系统";
            this.btnEnterSys.Visible = false;
            // 
            // icon_name
            // 
            this.icon_name.Location = new System.Drawing.Point(80, 424);
            this.icon_name.Name = "icon_name";
            this.icon_name.Size = new System.Drawing.Size(688, 8);
            this.icon_name.TabIndex = 23;
            this.icon_name.TabStop = false;
            // 
            // lbshan
            // 
            this.lbshan.Location = new System.Drawing.Point(176, 488);
            this.lbshan.Name = "lbshan";
            this.lbshan.Size = new System.Drawing.Size(100, 23);
            this.lbshan.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(285, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "版权所有：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(365, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "上海师范大学泰泽信息有限公司";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(365, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "13917217410";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(285, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "电话 ：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(285, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "联系信箱：";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(120, 192);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(592, 8);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("华文行楷", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(241, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 64);
            this.label6.TabIndex = 0;
            this.label6.Text = "代码生成系统";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.linkLabel1.Location = new System.Drawing.Point(365, 472);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(184, 16);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "pyf@shnu.edu.cn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(574, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "Version 20210625";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label8.Location = new System.Drawing.Point(574, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 26;
            this.label8.Text = "2007年";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(574, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "通过WebApi访问数据";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(301, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 31;
            this.label10.Text = "密码";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(301, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 14);
            this.label11.TabIndex = 32;
            this.label11.Text = "用户名";
            // 
            // frmLogin2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(888, 526);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbshan);
            this.Controls.Add(this.icon_name);
            this.Controls.Add(this.btnEnterSys);
            this.Controls.Add(this.btnGetbackPassWord);
            this.Controls.Add(this.btnUpdatePassWord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserID);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "frmLogin2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登陆界面20210625";
            this.Load += new System.EventHandler(this.frmLogin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Label label10;
        private Label label11;
    }
}