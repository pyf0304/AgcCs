namespace AGC.Webform.JCXX
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.SessionState;
	using System.Web.UI;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using MailServer;

	/// <summary>
	///		wucSendEmail 的摘要说明。
	/// </summary>
	public partial class wucSendEmail : System.Web.UI.UserControl
	{
		
		private ArrayList EmptyArr=new ArrayList();
		private ArrayList EmailArr;

		public clsEmail objEmail
		{
			get
			{
				if(Session["objEmail"]!=null)
				{
					return	(clsEmail)Session["objEmail"];
				}
				else
				{
					clsEmail objEmail=new clsEmail(); 
					Session.Add("objEmail",objEmail);
					return (clsEmail)Session["objEmail"];
				}
			}
	
		}

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			
            

		}

		protected void btnAdd_Mailto_Click(object sender, System.EventArgs e)
		{
			this.lblMailTo.Text="";
			EmailArr=new ArrayList();
			EmailArr.Add(this.txtMailTo.Text);
			objEmail.MailTo=EmailArr;
			foreach(object mailto in objEmail.MailTo)
			{
				this.lblMailTo.Text+=mailto.ToString()+";";
			}
		}

		protected void btnClear_Mailto_Click(object sender, System.EventArgs e)
		{
			objEmail.MailTo=EmptyArr;
			this.lblMailTo.Text="";
			
		}

		protected void btnAdd_CopytoWithSender_Click(object sender, System.EventArgs e)
		{
			this.lblCopytoWithSender.Text="";
			EmailArr=new ArrayList();
			EmailArr.Add(this.txtCopytoWithSender.Text);
			objEmail.CopyToWithSender=EmailArr;
			foreach(object CopytoWithSender in objEmail.CopyToWithSender)
			{
				this.lblCopytoWithSender.Text+=CopytoWithSender.ToString()+";";
			}
		
		}

		protected void btnClear_CopytoWithSender_Click(object sender, System.EventArgs e)
		{
			objEmail.CopyToWithSender=EmptyArr;
			this.lblCopytoWithSender.Text="";
		
		}

		protected void btnAdd_CopytoWithoutSender_Click(object sender, System.EventArgs e)
		{
			this.lblCopytoWithoutSender.Text="";
			EmailArr=new ArrayList();
			EmailArr.Add(this.txtCopytoWithoutSender.Text);
			objEmail.CopyToWithoutSender=EmailArr;
			foreach(object CopytoWithoutSender in objEmail.CopyToWithoutSender)
			{
				this.lblCopytoWithoutSender.Text+=CopytoWithoutSender.ToString()+";";
			}
		
		}

		protected void btnClear_CopytoWithoutSender_Click(object sender, System.EventArgs e)
		{
			objEmail.CopyToWithoutSender=EmptyArr;
			this.lblCopytoWithoutSender.Text="";
		
		}

		protected void btn_SendMail_Click(object sender, System.EventArgs e)
		{
			objEmail.MailSubject=txtSubject.Text;
			objEmail.MailBody=txtBody.Text;
			objEmail.SendEmail();
			this.lblErrorMsg.Text=objEmail.ErrorMsg;
			
		}


		
	}
}
