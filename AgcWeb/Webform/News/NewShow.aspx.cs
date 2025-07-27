using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHtmlTest.WebForm.News
{
    public partial class NewShow : System.Web.UI.Page
    {
        //存储资讯ID
        public string NewsID
        {
            get
            {
                string NewsID;
                NewsID = (string)System.Web.HttpContext.Current.Session["NewsID"];
                if (NewsID == null)
                {
                    NewsID = "";
                }
                return NewsID;
            }
            set
            {
                string NewsID = value;
                System.Web.HttpContext.Current.Session.Add("NewsID", NewsID);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Page.Title = "资讯信息";
                //菜单控制

                if (Request.QueryString["IDNew"].ToString() != "")
                {
                    NewsID = Request.QueryString["IDNew"].ToString();
                    GetNewsShow();
                    //GetNews();
                }

            }

        }

        public void GetNewsShow()
        {
            clsNewsEN objNew = new clsNewsEN();
            string strWhere = "Id_News =" + NewsID;
            objNew = clsNewsBL.GetFirstObj_S(strWhere);
            lblNewsTitle.Text = objNew.NewsTitle;
            lblEditTime.Text = objNew.EditTime;
            lblSource.Text = objNew.Source;
            lblViews.Text = objNew.Views.ToString();
            lblNewsContent.Text = objNew.NewsContent;



            //增加浏览量方法
            clsNewsEN newsEn = clsNewsBL.GetObjById_News(int.Parse(NewsID));
            newsEn.Views++;
            clsNewsBL.UpdateBySql2(newsEn);
        }

        //public void GetNews()
        //{
        //    stuTopPara objTopPara = new stuTopPara();
        //    objTopPara.topSize = 5;
        //    objTopPara.whereCond = " NewsTypeId = 1 ";
        //    objTopPara.orderBy = " IsTop desc,  EditTime desc";
        //    DataTable dt = clsNewsBL.GetDataTable_Top(objTopPara);
        //    this.rpTopNews.DataSource = dt;
        //    this.rpTopNews.DataBind();
        //}
    }
}