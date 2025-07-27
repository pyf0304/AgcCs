using AGC.BusinessLogic;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHtmlTest.WebForm.News
{
    public partial class NewList : System.Web.UI.Page
    {
        public string NewstypeID
        {
            get
            {
                string NewstypeID;
                NewstypeID = (string)System.Web.HttpContext.Current.Session["NewstypeID"];
                if (NewstypeID == null)
                {
                    NewstypeID = "";
                }
                return NewstypeID;
            }
            set
            {
                string NewstypeID = value;
                System.Web.HttpContext.Current.Session.Add("NewstypeID", NewstypeID);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Page.Title = "资讯";
                //菜单控制
                
                ////判断
                if (Request.QueryString["ID"].ToString() != "")
                {
                    NewstypeID = Request.QueryString["ID"].ToString();


                    clsNewsTypeEN objNewsType = new clsNewsTypeEN();
                    objNewsType = clsNewsTypeBL.GetObjByNewsTypeId(NewstypeID);

                    //lblNewsName.Text = objNewsType.NewsTypeName;
                }


                //得到没有置顶的新闻信息
                GetNewsNotByIstop(NewstypeID);
            }
        }


        //新闻信息
        public void GetNewsNotByIstop(string NewstypeID)
        {

            int intCountPage = Convert.ToInt32(this.Labelye.Text);  //获取当前页面

            PagedDataSource objPds = new PagedDataSource();
            string strWhere = "NewsTypeId = '" + NewstypeID + "'  order by  EditTime desc";
            DataTable objDT = clsvNewsBL.GetDataTable(strWhere);


            objPds.DataSource = objDT.DefaultView;
            objPds.AllowPaging = true;

            objPds.PageSize = 10;
            objPds.CurrentPageIndex = intCountPage - 1;  //获取或实置当前页的索引         
            this.lblPageCount.Text = Convert.ToString(objPds.PageCount);  //统计共有多少页
            this.lbtn_Up.Enabled = true;
            this.lbtn_Next.Enabled = true;
            if (intCountPage == 1)
            {
                this.lbtn_Up.Enabled = false;//如果当前页等于"1"，那么"btn_Up"不可用

            }
            if (intCountPage == objPds.PageCount)
            {
                this.lbtn_Next.Enabled = false;//如果当前页等于"尾页"，那么"btn_Next"不可用
            }

            this.ltRecordCount.Text = Convert.ToString(objDT.Rows.Count);
            PageCount = objPds.PageCount;
            //rpNews.DataSource = objPds;
            //rpNews.DataBind();






            this.rpNewsNotIstop.DataSource = objPds;
            // this.rpNewsNotIstop.DataSource = datalistbind(dt);
            this.rpNewsNotIstop.DataBind();
        }




        protected void lbtn_One_Click(object sender, EventArgs e)
        {
            //string strWhereCond = CombineExperimentCondition();
            this.Labelye.Text = "1"; //获取首页
            GetNewsNotByIstop(NewstypeID); //绑定数据源
        }

        protected void lbtn_Up_Click(object sender, EventArgs e)
        {
            //string strWhereCond = CombineExperimentCondition();
            this.Labelye.Text = Convert.ToString(Convert.ToInt32(this.Labelye.Text) - 1); //获取当前的页数
            GetNewsNotByIstop(NewstypeID); //绑定数据源
        }

        protected void lbtn_Next_Click(object sender, EventArgs e)
        {
            // string strWhereCond = CombineExperimentCondition();
            this.Labelye.Text = Convert.ToString(Convert.ToInt32(this.Labelye.Text) + 1); //获取下一页的页数
            GetNewsNotByIstop(NewstypeID);  //绑定数据源
        }

        protected void lbtn_End_Click(object sender, EventArgs e)
        {
            //string strWhereCond = CombineExperimentCondition();
            this.Labelye.Text = PageCount.ToString(); //获取尾页
            GetNewsNotByIstop(NewstypeID);  //绑定数据源

        }

        protected int PageCount
        {
            get
            {
                int intPageCount = 0;
                intPageCount = (int)ViewState["PageCount"];
                return intPageCount;
            }
            set
            {
                int intPageCount = value;
                ViewState.Add("PageCount", intPageCount);
            }
        }
        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// </summary>
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                ViewState.Add("PageSize", strPageSize);
            }
        }
    }
}