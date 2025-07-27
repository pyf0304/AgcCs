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
using System.Data.SqlClient;
using CommFunc4WebForm;
using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;

namespace AGC.Webform
{
	/// <summary>
	/// chpwd 的摘要说明。
	/// </summary>
	public partial class wfmChangePassWord : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			//if(Session.Count==0)		Response.Redirect("welcome.html");
			
		}

		protected void btnSubmit_Click(object sender, System.EventArgs e)
		{
			//操作步骤：
			//1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
			//2、检查当前用户输入的密码是否正确, 如果不正确，就返回；若正确就执行下一步
			//3、检查用户输入的两个密码是否一致，若不一致就退出，若一致就执行下一行
			//4、把当前用户的UserId设置成新密码。
			//5、调用逻辑的<修改>命令，执行修改操作。

			string strNewPassWord;		//新的口令
			string strMsg;
			///操作步骤CODE实现：
			//1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
			clsUsersEN objUser;
			objUser = (clsUsersEN)Session["objUser"];
			if (objUser == null) 
			{
				lblMsg.Text = "当前用户不存在或超时，请重新登录!";
				return ;
			}
			//2、检查当前用户输入的密码是否正确,如果不正确，就返回；若正确就执行下一步;
			if(txtOldpwd.Text != objUser.Password )
			{
				Response.Write("<script>alert('密码不正确！')</script>");
				return;
			}
			//3、检查用户输入的两个密码是否一致，若不一致就退出，若一致就执行下一行
			strNewPassWord = txtNewpwd.Text;
			if(strNewPassWord != txtNewpwd2.Text)
			{
				Response.Write("<script>alert('确认密码不符')</script>");
				return;
			}

			//4、把当前用户的UserId设置成新密码。
			objUser.Password = strNewPassWord;
			//5、调用逻辑的<修改>命令，执行修改操作。
			if (clsUsersBL .UpdateBySql2(objUser) ==false)
			{
				strMsg = "修改密码不成功!";
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = "修改密码不成功!";
			}
			else
			{
				strMsg = "修改密码成功!";
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = "修改密码成功!";
			}
							
		}
        
}
}
