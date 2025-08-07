/*-- -- -- -- -- -- -- -- -- -- --
类名:wucViewReferFilesB
界面名:wfmViewReferFiles_QUDI(00050226)
生成代码版本:2019.05.17.1
生成日期:2019/05/18 11:13:16
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
框架-层名:Web用户控件后台(WebCtlControlCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//生成与表相关的控件控制层代码
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
    using com.taishsoft.datetime;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;

    /// <summary>
    ///		wucViewReferFilesB 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucViewReferFilesB : System.Web.UI.UserControl
    {

        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Page_Load)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }


        /// <summary>
        /// 界面Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ViewId
        {
            get
            {
                if (ddlViewId.SelectedValue == "0")
                    return "";
                return ddlViewId.SelectedValue;
            }
            set
            {
                if (ddlViewId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlViewId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlViewId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 代码类型Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
        /// 引用文件Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ReferFileId
        {
            get
            {
                if (ddlReferFileId.SelectedValue == "0")
                    return "";
                return ddlReferFileId.SelectedValue;
            }
            set
            {
                if (ddlReferFileId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlReferFileId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlReferFileId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 是否在用
        /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public bool InUse
        {
            get
            {
                return chkInUse.Checked;
            }
            set
            {
                chkInUse.Checked = value;
            }
        }

        /// <summary>
        /// 序号
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public int OrderNum
        {
            get
            {
                return int.Parse(txtOrderNum.Text.Trim());
            }
            set
            {
                txtOrderNum.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否模板
        /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public bool IsTemplate
        {
            get
            {
                return chkIsTemplate.Checked;
            }
            set
            {
                chkIsTemplate.Checked = value;
            }
        }

        /// <summary>
        /// 说明
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            ddlViewId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
            ddlReferFileId.SelectedIndex = 0;
            chkInUse.Checked = false;
            txtOrderNum.Text = "0";
            chkIsTemplate.Checked = false;
            txtMemo.Text = "";
        }


        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则:
        ///		1、首先校验类型:整型、浮点型、日期型等,
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值,即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_IsValid)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            ComValid_OrderNum.Validate();
            if (!ComValid_OrderNum.IsValid) return false;
            if (clsString.IsNumeric(txtOrderNum.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            return true;
        }


        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则:
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetDefaultValue)
        /// </summary>
        public void SetDefaultValue()
        {
            ddlViewId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
            ddlReferFileId.SelectedIndex = 0;
            chkInUse.Checked = false;
            txtOrderNum.Text = "0";
            chkIsTemplate.Checked = false;
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[ViewInfo]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetViewId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewId, ViewName from ViewInfo ";
            clsSpecSQLforSql mySql = clsViewInfoBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ViewId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetViewId();
            objDDL.DataValueField = conViewInfo.ViewId;
            objDDL.DataTextField = conViewInfo.ViewName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[CodeType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetCodeTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select CodeTypeId, CodeTypeName from CodeType ";
            clsSpecSQLforSql mySql = clsCodeTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_CodeTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetCodeTypeId();
            objDDL.DataValueField = conCodeType.CodeTypeId;
            objDDL.DataTextField = conCodeType.CodeTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[ReferFiles]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetReferFileId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ReferFileId, FileName from ReferFiles ";
            clsSpecSQLforSql mySql = clsReferFilesBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ReferFileId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetReferFileId();
            objDDL.DataValueField = conReferFiles.ReferFileId;
            objDDL.DataTextField = conReferFiles.FileName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[ViewId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ViewId()
        {
            clsViewInfoBL.BindDdl_ViewId(ddlViewId, clsPubVar.CurrSelPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[CodeTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_CodeTypeId(string strProgLangTypeId)
        {
            clsCodeTypeBL.BindDdl_CodeTypeId(ddlCodeTypeId, strProgLangTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[ReferFileId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ReferFileId()
        {
            clsReferFilesBL.BindDdl_ReferFileId(ddlReferFileId);
        }

    }
}