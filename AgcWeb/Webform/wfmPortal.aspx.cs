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
using AGC.Entity;
using AGC.FunClass;

namespace AGC.Webform
{
	/// <summary>
	/// wfmPortal 的摘要说明。
	/// </summary>
	public partial class wfmPortal : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)
			{
                if (clsCommonSession.objQxUser != null)
                {
                    lblWelComeMsg.Text = clsCommonSession.objQxUser.UserName + "，欢迎您使用本系统!";
                }
			}

		}
				
		private clsUsersEN objUserBak
		{
			get
			{
				clsUsersEN pobjUser;
				pobjUser = (clsUsersEN)Session["objUser"];
				if (pobjUser==null) 
				{
					pobjUser = null;
				}
				return pobjUser;
			}
			set
			{
				clsUsersEN pobjUser = value;
				Session.Add("objUser", pobjUser);
			}
		}

	}
}
