using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using AGC.Entity;


using AGC4WApi;

namespace AGC_CSWin
{
	/// <summary>
	/// UpdatePassword 的摘要说明。
	/// </summary>
	public class UpdatePassword : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtpwd;
		private System.Windows.Forms.TextBox txtNewped;
		private System.Windows.Forms.TextBox txtAgainpwd;
		private System.Windows.Forms.Button btnUpdatepwd;
		private System.Windows.Forms.Button btncancel;
        //string strUserID;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UpdatePassword()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtpwd = new System.Windows.Forms.TextBox();
			this.txtNewped = new System.Windows.Forms.TextBox();
			this.txtAgainpwd = new System.Windows.Forms.TextBox();
			this.btnUpdatepwd = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "更改您的密码";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(64, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "键入您当前的密码";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(64, 96);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "输入一个新密码";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(56, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "再次输入密码以确认";
			// 
			// txtpwd
			// 
			this.txtpwd.Location = new System.Drawing.Point(184, 64);
			this.txtpwd.Name = "txtpwd";
			this.txtpwd.Size = new System.Drawing.Size(152, 21);
			this.txtpwd.TabIndex = 4;
			this.txtpwd.Text = "";
			// 
			// txtNewped
			// 
			this.txtNewped.Location = new System.Drawing.Point(184, 96);
			this.txtNewped.Name = "txtNewped";
			this.txtNewped.Size = new System.Drawing.Size(152, 21);
			this.txtNewped.TabIndex = 5;
			this.txtNewped.Text = "";
			// 
			// txtAgainpwd
			// 
			this.txtAgainpwd.Location = new System.Drawing.Point(184, 128);
			this.txtAgainpwd.Name = "txtAgainpwd";
			this.txtAgainpwd.Size = new System.Drawing.Size(152, 21);
			this.txtAgainpwd.TabIndex = 6;
			this.txtAgainpwd.Text = "";
			// 
			// btnUpdatepwd
			// 
			this.btnUpdatepwd.Location = new System.Drawing.Point(112, 208);
			this.btnUpdatepwd.Name = "btnUpdatepwd";
			this.btnUpdatepwd.TabIndex = 7;
			this.btnUpdatepwd.Text = "更改密码";
			this.btnUpdatepwd.Click += new System.EventHandler(this.btnUpdatepwd_Click);
			// 
			// btncancel
			// 
			this.btncancel.Location = new System.Drawing.Point(240, 208);
			this.btncancel.Name = "btncancel";
			this.btncancel.TabIndex = 8;
			this.btncancel.Text = "取消";
			this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
			// 
			// UpdatePassword
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(576, 373);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnUpdatepwd);
			this.Controls.Add(this.txtAgainpwd);
			this.Controls.Add(this.txtNewped);
			this.Controls.Add(this.txtpwd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UpdatePassword";
			this.Text = "UpdatePassword";
			this.ResumeLayout(false);

		}
		#endregion
	   /// <summary>
	   /// 判断3个文本框是否为空
	   /// </summary>
	   /// <returns></returns>
		private bool isempty()
		{
			string strMsg;
			if(txtpwd.Text == "")
			{
				strMsg = "请输入旧密码!";
				MessageBox.Show(strMsg);
				return false;
			}
			if(txtNewped.Text == "")
			{
				strMsg = "请输入新密码!";
				MessageBox.Show(strMsg);
				return false;
			}
			if(txtAgainpwd.Text == "")
			{
				strMsg = "请再次输入新密码!";
				MessageBox.Show(strMsg);
			    return false;
			}

				return true;
			
		}
		/// <summary>
		/// 判断两次密码是否一致
		/// </summary>
		/// <returns></returns>
		private bool isPassWordSame()
		{
			string strMsg;
			if(this.txtNewped.Text == this.txtAgainpwd.Text)
			{
				return true;
			}
			else
			{
				strMsg = "请两次输入密码一致!";
				MessageBox.Show(strMsg);
				return false;
			}
		}
		/// <summary>
		/// 判断旧密码是否正确
		/// </summary>
		/// <returns></returns>
		private bool isPassWordright()
		{
			string strMsg;
			clsUsersEN objUser = clsUsersWApi.GetObjByUserId(clsSysParaEN.strUserId);
			
            if (objUser != null)
			{
				string pwd = objUser.Password.ToString();
				if(pwd.Trim()==txtpwd.Text)//strPassWord.Trim())
					return true;
				else
				{
					strMsg = "您输入的密码不真确!";
					MessageBox.Show(strMsg);
					return false;
				}
			}
			else
			{  
				return false;
			}
		}

		private void btnUpdatepwd_Click(object sender, System.EventArgs e)
		{
		    //判断3个文本框是否为空
			if(isempty() == false )
			{
			   return;
			}
			//判断旧密码是否正确
			if(isPassWordright()==false)
			{
				return;
			}
			//判断两次密码是否一致
			if(isPassWordSame()==false)
			{
				return;
			}

			//更新用户表中的pwd字段
			string NewPassWord = this.txtNewped.Text.Trim();

           
			string strMsg;
			try
			{
                string strCondition = string.Format("UserID = '{0}'", clsSysParaEN.strUserId);
                clsUsersEN objUsers = clsUsersWApi.GetFirstObj(strCondition);
                objUsers.Password = NewPassWord;
                objUsers.Update();

				strMsg = "修改密码成功!";
				MessageBox.Show(strMsg);
			    return; 
			}
			catch
			{
				strMsg = "修改不成功";
				MessageBox.Show(strMsg);
				return;
			}	
			
		}

		private void btncancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
