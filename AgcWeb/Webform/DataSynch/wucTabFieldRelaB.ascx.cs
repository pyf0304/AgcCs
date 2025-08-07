

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
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucTabFieldRelaB 的摘要说明。
    /// </summary>
    public partial class wucTabFieldRelaB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 字段ID
        /// </summary>
        public string FldId
        {
            get
            {
                if (ddlFldID.SelectedValue == "0")
                    return "";
                return ddlFldID.SelectedValue;
            }
            set
            {
                if (ddlFldID.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFldID.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFldID.SelectedValue = value;
                    }
                }
            }
        }

      

        /// <summary>
        /// Sql字段名称
        /// </summary>
        public string SqlFldName
        {
            get
            {
                return txtSqlFldName.Text.Trim();
            }
            set
            {
                txtSqlFldName.Text = value.ToString();
            }
        }

    

        /// <summary>
        /// Excel字段名称
        /// </summary>
        public string ExcelFieldName
        {
            get
            {
                return txtExcelFieldName.Text.Trim();
            }
            set
            {
                txtExcelFieldName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 缺省值
        /// </summary>
        public string DefaultValue
        {
            get
            {
                return txtDefaultValue.Text.Trim();
            }
            set
            {
                txtDefaultValue.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否需要转换
        /// </summary>
        public bool IsNeedTrans
        {
            get
            {
                return chkIsNeedTrans.Checked;
            }
            set
            {
                chkIsNeedTrans.Checked = value;
            }
        }

        /// <summary>
        /// 转换方式ID
        /// </summary>
        public string TransWayId
        {
            get
            {
                return txtTransWayId.Text.Trim();
            }
            set
            {
                txtTransWayId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 转换表名
        /// </summary>
        public string TransTabName
        {
            get
            {
                return txtTransTabName.Text.Trim();
            }
            set
            {
                txtTransTabName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 转换IN字段名
        /// </summary>
        public string TransInFldName
        {
            get
            {
                return txtTransInFldName.Text.Trim();
            }
            set
            {
                txtTransInFldName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 转换Out字段名
        /// </summary>
        public string TransOutFldName
        {
            get
            {
                return txtTransOutFldName.Text.Trim();
            }
            set
            {
                txtTransOutFldName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否作为表中主键
        /// </summary>
        public bool IsTabPrimary
        {
            get
            {
                return chkIsTabPrimary.Checked;
            }
            set
            {
                chkIsTabPrimary.Checked = value;
            }
        }

        /// <summary>
        /// 是否表外键
        /// </summary>
        public bool IsTabForeignKey
        {
            get
            {
                return chkIsTabForeignKey.Checked;
            }
            set
            {
                chkIsTabForeignKey.Checked = value;
            }
        }

        /// <summary>
        /// 主键类型ID
        /// </summary>
        public string PrimaryTypeId
        {
            get
            {
                return txtPrimaryTypeId.Text.Trim();
            }
            set
            {
                txtPrimaryTypeId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否Identity
        /// </summary>
        public bool IsIdentity
        {
            get
            {
                return chkIsIdentity.Checked;
            }
            set
            {
                chkIsIdentity.Checked = value;
            }
        }

        /// <summary>
        /// 是否表中唯一
        /// </summary>
        public bool IsTabUnique
        {
            get
            {
                return chkIsTabUnique.Checked;
            }
            set
            {
                chkIsTabUnique.Checked = value;
            }
        }

        /// <summary>
        /// 是否表中可空
        /// </summary>
        public bool IsTabNullable
        {
            get
            {
                return chkIsTabNullable.Checked;
            }
            set
            {
                chkIsTabNullable.Checked = value;
            }
        }

        /// <summary>
        /// 字段类型Id
        /// </summary>
        public string FieldTypeId
        {
            get
            {
                if (ddlFieldTypeId.SelectedValue == "0")
                    return "";
                return ddlFieldTypeId.SelectedValue;
            }
            set
            {
                if (ddlFieldTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFieldTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFieldTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 是否检查主外键
        /// </summary>
        public bool IsNeedCheckPriForeignKey
        {
            get
            {
                return chkIsNeedCheckPriForeignKey.Checked;
            }
            set
            {
                chkIsNeedCheckPriForeignKey.Checked = value;
            }
        }

        /// <summary>
        /// 主键表
        /// </summary>
        public string PrimaryKeyTabName
        {
            get
            {
                return txtPrimaryKeyTabName.Text.Trim();
            }
            set
            {
                txtPrimaryKeyTabName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 主键字段名
        /// </summary>
        public string PrimaryKeyFieldName
        {
            get
            {
                return txtPrimaryKeyFieldName.Text.Trim();
            }
            set
            {
                txtPrimaryKeyFieldName.Text = value.ToString();
            }
        }

         

        /// <summary>
        /// 转换失败值
        /// </summary>
        public string TransMissingValue
        {
            get
            {
                return txtTransMissingValue.Text.Trim();
            }
            set
            {
                txtTransMissingValue.Text = value.ToString();
            }
        }

        /// <summary>
        /// 转换空值
        /// </summary>
        public string TransNullValue
        {
            get
            {
                return txtTransNullValue.Text.Trim();
            }
            set
            {
                txtTransNullValue.Text = value.ToString();
            }
        }

     

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool IsVisible
        {
            get
            {
                return chkIsVisible.Checked;
            }
            set
            {
                chkIsVisible.Checked = value;
            }
        }

        /// <summary>
        /// 顺序号
        /// </summary>
        public int SequenceNumber
        {
            get
            {
                return int.Parse(txtSequenceNumber.Text.Trim());
            }
            set
            {
                txtSequenceNumber.Text = value.ToString();
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
            ddlFldID.SelectedIndex = 0;
      
            txtSqlFldName.Text = "";
         
            txtExcelFieldName.Text = "";
            txtDefaultValue.Text = "";
            chkIsNeedTrans.Checked = false;
            txtTransWayId.Text = "";
            txtTransTabName.Text = "";
            txtTransInFldName.Text = "";
            txtTransOutFldName.Text = "";
            chkIsTabPrimary.Checked = false;
            chkIsTabForeignKey.Checked = false;
            txtPrimaryTypeId.Text = "";
            chkIsIdentity.Checked = false;
            chkIsTabUnique.Checked = false;
            chkIsTabNullable.Checked = false;
            ddlFieldTypeId.SelectedIndex = 0;
            chkIsNeedCheckPriForeignKey.Checked = false;
            txtPrimaryKeyTabName.Text = "";
            txtPrimaryKeyFieldName.Text = "";
            
          
            txtTransMissingValue.Text = "";
            txtTransNullValue.Text = "";
         
            chkIsVisible.Checked = false;
            txtSequenceNumber.Text = "0";
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
           
            ComValid_SequenceNumber.Validate();
            if (!ComValid_SequenceNumber.IsValid) return false;
          
            if (clsString.IsNumeric(txtSequenceNumber.Text) == false)
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
            ddlFldID.SelectedIndex = 0;
        
            txtSqlFldName.Text = "";
     
            txtExcelFieldName.Text = "";
            txtDefaultValue.Text = "";
            chkIsNeedTrans.Checked = false;
            txtTransWayId.Text = "";
            txtTransTabName.Text = "";
            txtTransInFldName.Text = "";
            txtTransOutFldName.Text = "";
            chkIsTabPrimary.Checked = false;
            chkIsTabForeignKey.Checked = false;
            txtPrimaryTypeId.Text = "";
            chkIsIdentity.Checked = false;
            chkIsTabUnique.Checked = false;
            chkIsTabNullable.Checked = false;
            ddlFieldTypeId.SelectedIndex = 0;
            chkIsNeedCheckPriForeignKey.Checked = false;
            txtPrimaryKeyTabName.Text = "";
            txtPrimaryKeyFieldName.Text = "";
           
            txtTransMissingValue.Text = "";
            txtTransNullValue.Text = "";
        
        
            chkIsVisible.Checked = false;
            txtSequenceNumber.Text = "0";
            txtMemo.Text = "";
        }
       
        public void SetDdl_FldID(string strPrjId)
        {
            clsFieldTabBLEx.BindDdl_FldIDEx(ddlFldID, strPrjId);
        }
       
        public void SetDdl_FieldTypeId()
        {
            clsFieldTypeBL.BindDdl_FieldTypeIdCache(ddlFieldTypeId);
        }
       
     
    }
}