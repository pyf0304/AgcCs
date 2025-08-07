

namespace AGC.Webform
{
    using AGC.BusinessLogicEx;
    using AGC.FunClass;
    using com.taishsoft.datetime;
    using CommFunc4WebForm;
    using System;

    /// <summary>
    ///		wucErrorIdManageB 的摘要说明。
    /// </summary>
    public partial class wucErrorIdManageB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 错误Id
        /// </summary>
        public string ErrID
        {
            get
            {
                return txtErrID.Text.Trim();
            }
            set
            {
                txtErrID.Text = value.ToString();
            }
        }

        /// <summary>
        /// 工程ID
        /// </summary>
        public string PrjId
        {
            get
            {
                if (ddlPrjId.SelectedValue == "0")
                    return "";
                return ddlPrjId.SelectedValue;
            }
            set
            {
                if (ddlPrjId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPrjId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlPrjId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 程序分层类型
        /// </summary>
        public string CodeTypeId
        {
            get
            {
                if (ddlCodeTypeId.SelectedValue == "0")
                    return "";
                return ddlCodeTypeId.SelectedValue;
            }
            set
            {
                if (ddlCodeTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlCodeTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlCodeTypeId.SelectedValue = value;
                    }
                }
            }
        }

       

        /// <summary>
        /// 功能名称
        /// </summary>
        public string FunctionName
        {
            get
            {
                return txtFunctionName.Text.Trim();
            }
            set
            {
                txtFunctionName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 说明
        /// </summary>
        public string Explanation
        {
            get
            {
                return txtExplanation.Text.Trim();
            }
            set
            {
                txtExplanation.Text = value.ToString();
            }
        }

        /// <summary>
        /// 修改日期
        /// </summary>
        public string UpdDate
        {
            get
            {
                return clsDateTime.getTodayDateTimeStr(1);
            }
           
        }

        /// <summary>
        /// 修改用户Id
        /// </summary>
        public string UpdUserId
        {
            get
            {
                return clsCommonSession.UserId;
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
            txtErrID.Text = "";
            ddlPrjId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
       
            txtFunctionName.Text = "";
            txtExplanation.Text = "";
       
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
            txtErrID.Text = "";
            ddlPrjId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
          
            txtFunctionName.Text = "";
            txtExplanation.Text = "";
  
            txtMemo.Text = "";
        }
     
      
        public void SetDdl_PrjId()
        {
          clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
        public void SetDdl_CodeTypeId()
        {
            clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeId);
        }

        protected void ddlCodeTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCodeTypeId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个分层类型！(errid:WucL000001)");
                return;
            }
            string strCodeTypeId = ddlCodeTypeId.SelectedValue;
            string strErrId = clsErrorIdManageBLEx.GetMaxErrId(strCodeTypeId);
            txtErrID.Text = strErrId;
        }
    }
}