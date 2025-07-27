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

namespace AGC.Webform
{
	/// <summary>
	/// wfmTestWebDraw 的摘要说明。
	/// </summary>
	public partial class wfmTestWebDraw : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string strFileName = Server.MapPath("~") + "\\aa.jpg";
			Bitmap bm = new Bitmap ( 600 , 250 ) ;
			//创建一个长度为600，宽带为250的Bitmap实例
			Graphics g ;
			g = Graphics.FromImage ( bm ) ;
			//由此Bitmap实例创建Graphic实例
			g . Clear ( Color . Snow ) ;
//			Brush brush = new Brush();
			Pen mThinPen = new Pen(Color.Red, 1.0f);
			g.DrawLine(mThinPen,new Point(10,10), new Point(200,200));
			//用Snow色彩为背景色填充此绘画图面
			g . DrawString ( " ××公司××器件2002年度销售情况一览表" , new Font ( "宋体" , 16 ) , Brushes . Black , new Point ( 5 , 5 ) ) ;
			//在绘画图面的指定位置，以指定的字体、指定的颜色绘制指定的字符串。即为图表标题
			//以下代码是是实现图01中的右上部
			Point myRec = new Point ( 535 , 30 ) ;
			Point myDec = new Point ( 560 , 26 ) ;
			//以上是在图01中为下面绘制定位
			g . DrawString ( "单位：万套" , new Font ( "宋体" , 9 ) , Brushes . Black , new Point ( 525 , 12 ) ) ;
			//以下代码是绘制图01中的边框，并形成Jpeg文件，供浏览器显示出来
			Pen p = new Pen ( Color.Black , 2 ) ;
			g.DrawRectangle ( p , 1 , 1 , 598 , 248 ) ;
//			HouseManLib.clsMyObj objTT1 = new HouseManLib.clsMyObj();
//			objTT1.Draw(g);
//			bm.Save(Response.OutputStream , System.Drawing.Imaging.ImageFormat.Jpeg ) ;
				bm.Save(strFileName , System.Drawing.Imaging.ImageFormat.Jpeg ) ;
			Image1.ImageUrl = "\\AGC\\aa.jpg";
				
		}
	}
}
