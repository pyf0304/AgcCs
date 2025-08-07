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
using AGC.FunClass;

namespace AGC.Webform
{
	/// <summary>
	/// error 的摘要说明。
	/// </summary>
	public partial class error : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			DIV2.Visible = false;
			if (clsCommonSession.seErrMessage != "")
			{
				string strErrMsg = ErrMessage.Replace("\r\n","<BR/>");
				lblErrMsg.Text = strErrMsg;
			}
		}
		private string BackErrPageLinkStr
		{
			get
			{
				string strBackErrPageLinkStr;
				strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
				if (strBackErrPageLinkStr==null) 
				{
					strBackErrPageLinkStr = "";
				}
				return strBackErrPageLinkStr;
			}
			set
			{
				string strBackErrPageLinkStr = value;
				Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
			}
		}
		private string ErrMessage
		{
			get
			{
				string strErrMessage;
				strErrMessage = (string)Session["ErrMessage"];
				if (strErrMessage==null) 
				{
					strErrMessage = "";
				}
				return strErrMessage;
			}
			set
			{
				string strErrMessage = value;
				Session.Add("ErrMessage", strErrMessage);
			}
		}
		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			//Response.Redirect("load.aspx");
			string c1 = "<script language='javascript'>window.parent.location.href='./Webform/index.aspx'; </script>";
			Response.Write(c1);
		}

		protected void lbGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackErrPageLinkStr);
		}
	}
}
