using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;

using System.Collections.Generic;
using AGC.Entity;
using AGC.BusinessLogicEx;

namespace AGC.Webform
{
	/// <summary>
	/// wfmTestMoveImg 的摘要说明。
	/// </summary>
	public partial class wfmTestMoveImg : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)
			{
//				ReadData();
				
			}
		}

		private void ReadData()
		{
			//clsWorkStepPointEN objWorkStepPoint = new clsWorkStepPointEN();
			StringBuilder strHTML = new StringBuilder();
			ArrayList arrWorkStepList = clsWorkStepPointBLEx.GetWorkStepPointList(" 1= 1");
			foreach(clsWorkStepPointEN objWorkStepPoint in arrWorkStepList)
			{
				strHTML.AppendFormat("<IMG id = \"{0}\" Name = \"wsPoint\" onmousedown=\"Img_onMouseDown()\" onmouseup=\"Img_onMouseUp()\" onmousemove=\"Img_onMouseMove()\" ",
					objWorkStepPoint.PointID);
				strHTML.AppendFormat("style=\"z-index: 108; left: {0}px; width: 80px; position: absolute; top: {1}px; height: 30px\" ",
					objWorkStepPoint.pLeft, objWorkStepPoint.pTop);
					strHTML.Append(" alt=\"\" src=\"../../pic/logo_shnu.gif\"  runat=\"server\">	");
				span1.InnerHtml = strHTML.ToString();
			}
//			sqlConn.ConnectionString=strConn;
//			strSql="select rtrim([id]) [id],[left],[top] from test ";
//			sqlCmd=new SqlCommand(strSql,sqlConn);
//			sqlAdpt=new SqlDataAdapter(strSql,strConn);
//			DoSql();
//			sqlAdpt.Fill(DT);
//			try
//			{
//				for(int i=0;i<DT.Rows.Count;i++)
//				{
//					strP_id=DT.Rows[i]["id"].ToString();
//					
//					strP_left=DT.Rows[i]["left"].ToString();
//					strP_top=DT.Rows[i]["top"].ToString();
//
//					foreach(Control a in Page.Controls)
//					{
//						if(a.ClientID==strP_id)
//						{
//							((System.Web.UI.WebControls.Image)a).Style["left"]=strP_left;
//							((System.Web.UI.WebControls.Image)a).Style["top"]=strP_top;
//						}
//					}
//				}
//			}
//			catch(Exception err)
//			{
//			}
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
////			System.Web.UI.HtmlControls.HtmlImage myImage;
////			myImage = (System.Web.UI.HtmlControls.HtmlImage )this.FindControl("IMG1");
//			TextBox1.Text = hidString.Value;
//			string [] strPoints = TextBox1.Text.Split(";".ToCharArray());
//			string [] strTemp;
//            List<string> arrId = clsWorkStepPointBLEx.GetID("1=1");
//			//ArrayList arrWorkStepList = clsWorkStepPointEx.GetWorkStepPointList(" 1= 1");
////			string strLeft, strTop;
//			int ii = Page.Controls.Count;
//			TextBox1.Text = "cc=" + ii.ToString();
//			foreach(string strPoint in strPoints)
//			{
//				strTemp = strPoint.Split(",".ToCharArray());
//				if(arrId.Contains(strTemp[0]))
//				{
//					clsWorkStepPointEN objWorkStepPoint = new clsWorkStepPointEN(strTemp[0], true);
////					strLeft = re ((System.Web.UI.WebControls.Image)imgCtl).Style["left"];
////					strTop = ((System.Web.UI.WebControls.Image)imgCtl).Style["top"];
//					objWorkStepPoint.pLeft = int.Parse(strTemp[1].TrimEnd("px".ToCharArray()));
//					objWorkStepPoint.pTop = int.Parse(strTemp[2].TrimEnd("px".ToCharArray()));
//					objWorkStepPoint.Update();
//				}
//			}
//			ReadData();
//			System.Web.UI.WebControls.Button btn = new Button();
//			btn.Width = 100;
//			btn.Height = 30;
//			btn.Text = "AAAAA";
////			this.document.
////			System.Web.UI.WebControls.webfo this.FindControl("Form1")
////				.Add(btn);
		}
	}
}
