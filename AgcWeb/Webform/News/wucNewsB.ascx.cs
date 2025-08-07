
//生成与表相关的控件控制层代码
namespace CompanyPage.Webform
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.commdb;
    using AGC.FunClass;


    /// <summary>
    ///		wucNewsB 的摘要说明。
    /// </summary>
    public partial class wucNewsB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            DotNetTextBox();

        }
        public void DotNetTextBox()
        {
            txtNewsContent.UploadFolder = "../NewUpload/News/" + clsCommonSession.UserId + "/";
            txtNewsContent.Skin = "skin/xp/";
            //txtnewscontent.menuconfig = "all_3row.config";
            txtNewsContent.MenuConfig = "all.config";
            txtNewsContent.LeftAreaAlign = "left";
            txtNewsContent.Width = 800;
            txtNewsContent.Height = 400;
        }
        /// <summary>
        /// 标题
        /// </summary>
        public string NewsTitle
        {
            get
            {
                return txtNewsTitle.Text.Trim();
            }
            set
            {
                txtNewsTitle.Text = value.ToString();
            }
        }

        /// <summary>
        /// 资讯类型
        /// </summary>
        public string NewsTypeId
        {
            get
            {
                if (ddlNewsTypeId.SelectedValue == "0")
                    return "";
                return ddlNewsTypeId.SelectedValue;
            }
            set
            {
                if (ddlNewsTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlNewsTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlNewsTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop
        {
            get
            {
                return chkIsTop.Checked;
            }
            set
            {
                chkIsTop.Checked = value;
            }
        }

        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImgPath
        {
            get
            {
                if (ImgUrl.ImageUrl == "" || fupImageUrl.PostedFile.FileName != "")
                {

                    string path = fupImageUrl.PostedFile.FileName;
                    if (path.Length != 0)
                    {
                        //Page.ClientScript.RegisterStartupScript(typeof(wucPhotoNewsB), "a", "<script>alert('请选择你要上传的文件！')</script>");
                        //return;
                        string c = path.Substring(path.LastIndexOf("\\") + 1);
                        path = "~/Upload/News/" + c;
                        this.fupImageUrl.PostedFile.SaveAs(Server.MapPath("~/Upload//News//") + c);
                        return path;
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    string path = ImgUrl.ImageUrl;
                    return path;
                }


            }
            set
            {
                ImgUrl.ImageUrl = value.ToString();
            }
        }

        /// <summary>
        /// 内容
        /// </summary>
        public string NewsContent
        {
            get
            {
                return txtNewsContent.Text.Trim();
            }
            set
            {
                txtNewsContent.Text = value.ToString();
            }
        }

        /// <summary>
        /// 编辑人员
        /// </summary>
        public string EditPeople
        {
            get
            {
                return txtEditPeople.Text.Trim();
            }
            set
            {
                txtEditPeople.Text = value.ToString();
            }
        }

        /// <summary>
        /// 编辑时间
        /// </summary>
        public string EditTime
        {
            get
            {
                return txtEditTime.Text.Trim();
            }
            set
            {
                txtEditTime.Text = value.ToString();
            }
        }

        /// <summary>
        /// 来源
        /// </summary>
        public string Source
        {
            get
            {
                return txtSource.Text.Trim();
            }
            set
            {
                txtSource.Text = value.ToString();
            }
        }

        /// <summary>
        /// 浏览量
        /// </summary>
        public int Views
        {
            get
            {
                return int.Parse(txtViews.Text.Trim());
            }
            set
            {
                txtViews.Text = value.ToString();
            }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get
            {
                return txtMemo.Text.Trim();
            }
            set
            {
                txtMemo.Text = value.ToString();
            }
        }


        public void Clear()
        {
            txtNewsTitle.Text = "";
            ddlNewsTypeId.SelectedIndex = 0;
            chkIsTop.Checked = false;

            txtNewsContent.Text = "";
            txtEditPeople.Text = "";
            txtEditTime.Text = "";
            txtSource.Text = "";
            txtViews.Text = "0";
            txtMemo.Text = "";
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则：
        ///		1、首先校验类型：整型、浮点型、日期型等，
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值，即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// </summary>
        /// <returns></returns>

        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则：
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// </summary>
        public void SetDefaultValue()
        {
            txtNewsTitle.Text = "";
            ddlNewsTypeId.SelectedIndex = 0;
            chkIsTop.Checked = false;

            txtNewsContent.Text = "";
            txtEditPeople.Text = "";
            txtEditTime.Text = "";
            txtSource.Text = "";
            txtViews.Text = "0";
            txtMemo.Text = "";
        }
        public System.Data.DataTable GetNewsTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select NewsTypeId, NewsTypeName from NewsType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_NewsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetNewsTypeId();
            objDDL.DataValueField = "NewsTypeId";
            objDDL.DataTextField = "NewsTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_NewsTypeId()
        {
            BindDdl_NewsTypeId(ddlNewsTypeId);
        }
    }
}