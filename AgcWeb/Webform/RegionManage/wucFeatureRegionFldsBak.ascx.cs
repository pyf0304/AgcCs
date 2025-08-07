

namespace AGC.Webform
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
    using AGC.Entity;
    using CommonTable.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;
    using CommonTable.BusinessLogic;
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucFeatureRegionFldsB 的摘要说明。
    /// </summary>
    public partial class wucFeatureRegionFldsBak : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 区域Id
        /// </summary>
        public long RegionId
        {
            get
            {
                return long.Parse(txtRegionId.Text.Trim());
            }
            set
            {
                txtRegionId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 按钮名称
        /// </summary>
        public string ButtonName
        {
            get
            {
                return txtButtonName.Text.Trim();
            }
            set
            {
                txtButtonName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文本内容
        /// </summary>
        public string Text
        {
            get
            {
                return txtText.Text.Trim();
            }
            set
            {
                txtText.Text = value.ToString();
            }
        }

        /// <summary>
        /// 控件类型号
        /// </summary>
        public string CtlTypeId
        {
            get
            {
                if (ddlCtlTypeId.SelectedValue == "0")
                    return "";
                return ddlCtlTypeId.SelectedValue;
            }
            set
            {
                if (ddlCtlTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlCtlTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlCtlTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 高度
        /// </summary>
        public int Height
        {
            get
            {
                return int.Parse(txtHeight.Text.Trim());
            }
            set
            {
                txtHeight.Text = value.ToString();
            }
        }

        /// <summary>
        /// 宽
        /// </summary>
        public int Width
        {
            get
            {
                return int.Parse(txtWidth.Text.Trim());
            }
            set
            {
                txtWidth.Text = value.ToString();
            }
        }

        /// <summary>
        /// 字段序号
        /// </summary>
        public int SeqNum
        {
            get
            {
                return int.Parse(txtSeqNum.Text.Trim());
            }
            set
            {
                txtSeqNum.Text = value.ToString();
            }
        }

        /// <summary>
        /// 样式表
        /// </summary>
        public string CssClass
        {
            get
            {
                return txtCssClass.Text.Trim();
            }
            set
            {
                txtCssClass.Text = value.ToString();
            }
        }

        /// <summary>
        /// 图片资源
        /// </summary>
        public string ImageUrl
        {
            get
            {
                return txtImageUrl.Text.Trim();
            }
            set
            {
                txtImageUrl.Text = value.ToString();
            }
        }

        /// <summary>
        /// 说明
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
            txtRegionId.Text = "0";
            txtButtonName.Text = "";
            txtText.Text = "";
            ddlCtlTypeId.SelectedIndex = 0;
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtSeqNum.Text = "0";
            txtCssClass.Text = "";
            txtImageUrl.Text = "";
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
        public bool IsValid(ref string strResult)
        {
            ComValid_RegionId.Validate();
            if (!ComValid_RegionId.IsValid) return false;
            ComValid_Height.Validate();
            if (!ComValid_Height.IsValid) return false;
            ComValid_Width.Validate();
            if (!ComValid_Width.IsValid) return false;
            ComValid_SeqNum.Validate();
            if (!ComValid_SeqNum.IsValid) return false;
            if (clsString.IsNumeric(txtRegionId.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            if (clsString.IsNumeric(txtHeight.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            if (clsString.IsNumeric(txtWidth.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            if (clsString.IsNumeric(txtSeqNum.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            return true;
        }
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
            txtRegionId.Text = "0";
            txtButtonName.Text = "";
            txtText.Text = "";
            ddlCtlTypeId.SelectedIndex = 0;
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtSeqNum.Text = "0";
            txtCssClass.Text = "";
            txtImageUrl.Text = "";
            txtMemo.Text = "";
        }
        public void SetDdl_CtlTypeId()
        {
            clsCtlTypeAbbrBL.BindDdl_CtlTypeId(ddlCtlTypeId);
        }
    }
}