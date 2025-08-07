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
using AGC.BusinessLogic;using AGC.FunClass;

namespace AGC.Webform
{
	/// <summary>
	/// wfmTestDataList 的摘要说明。
	/// </summary>
	public partial class wfmTestDataList : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{

//			<A href="<%# DataBinder.Eval(Container.DataItem, "LinkFile") %>" >
//										<FONT color="#0000ff" size="2">
//											<STRONG><%# DataBinder.Eval(Container.DataItem, "Author") %></STRONG>
//										</FONT>
//									</A>
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)
			{
				clsOptMemoEN objOptMemo = new clsOptMemoEN();
				System.Data.DataTable objDT = clsOptMemoBL.GetDataTable_OptMemo("1=1");
				Label1.Text = objDT.Rows.Count.ToString();
				dlOptMemo.DataSource = objDT.DefaultView;
				dlOptMemo.DataBind();
			}
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
		
			System.Data.DataTable objDT = clsOptMemoBL.GetDataTable_OptMemo("1=1");
			Label1.Text = objDT.Rows.Count.ToString();
			dlOptMemo.DataSource = objDT.DefaultView;
			dlOptMemo.DataBind();
		}

		private void dlOptMemo_ItemCreated(object sender, System.Web.UI.WebControls.DataListItemEventArgs e)
		{
			
		}

		private void dlOptMemo_EditCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
		{
			int intIndex = e.Item.ItemIndex;
			Label1.Text = dlOptMemo.DataKeys[intIndex].ToString();
		}

		private void dlOptMemo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

	}
}
