
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucFunction4CodeB
表名:Function4Code
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:50:51
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//生成与表相关的控件控制层代码
namespace AGC.Webform
{
    using System;
    using System.Web.UI.WebControls;
    using AGC.BusinessLogic;
    using AGC.Entity;
    using AGC.FunClass;
    using BusinessLogicEx;
    using com.taishsoft.commdb;
    using com.taishsoft.common;
    using com.taishsoft.datetime;

    /// <summary>
    ///		wucFunction4CodeB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucFunction4CodeB : System.Web.UI.UserControl
    {
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (qsFuncTypeId == enumFunctionType.ExGCFunc_13)
            {
                trFuncTypeID.Visible = false;
                trApplicationTypeId.Visible = false;
                //trFunctionSignature.Visible = false;
                trOrderNum.Visible = false;

            }
        }
        /// <summary>
        /// 函数Id4Code
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncId4Code
        {
            get
            {
                return txtFuncId4Code.Text.Trim();
            }
            set
            {
                txtFuncId4Code.Text = value.ToString();
            }
        }

        /// <summary>
        /// 函数名4Code
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncName4Code
        {
            get
            {
                return txtFuncName4Code.Text.Trim();
            }
            set
            {
                txtFuncName4Code.Text = value.ToString();
            }
        }
        /// <summary>
        /// 用户定制的返回类型
        /// </summary>
        public string ReturnTypeNameCustom
        {
            get
            {
                return txtReturnTypeNameCustom.Text.Trim();
            }
            set
            {
                txtReturnTypeNameCustom.Text = value.ToString();
            }
        }

        /// <summary>
        /// 函数中文名4Code
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncCHName4Code
        {
            get
            {
                return txtFuncCHName4Code.Text.Trim();
            }
            set
            {
                txtFuncCHName4Code.Text = value.ToString();
            }
        }

        public string ClsName
        {
            get
            {
                return txtClassName.Text.Trim();
            }
            set
            {
                txtClassName.Text = value.ToString();
            }
        }

        public string TabName
        {
            get
            {
                return txtTabName.Text.Trim();
            }
            set
            {
                txtTabName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 函数签名
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        //public string FunctionSignature
        //{
        //    get
        //    {
        //        return txtFunctionSignature.Text.Trim();
        //    }
        //    set
        //    {
        //        txtFunctionSignature.Text = value.ToString();
        //    }
        //}

        /// <summary>
        /// 返回类型ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ReturnTypeID
        {
            get
            {
                if (ddlReturnTypeID.SelectedValue == "0")
                    return "";
                return ddlReturnTypeID.SelectedValue;
            }
            set
            {
                if (ddlReturnTypeID.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlReturnTypeID.SelectedValue = "0";
                    }
                    else
                    {
                        try
                        {
                            ddlReturnTypeID.SelectedValue = value;
                        }
                        catch(Exception objException)
                        {
                            string strSS = objException.Message;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 函数类型ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncTypeId
        {
            get
            {
                if (ddlFuncTypeID.SelectedValue == "0")
                    return "";
                return ddlFuncTypeID.SelectedValue;
            }
            set
            {
                if (ddlFuncTypeID.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncTypeID.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncTypeID.SelectedValue = value;
                    }
                }
            }
        }
        //public string CodeTypeId
        //{
        //    get
        //    {
        //        if (ddlCodeTypeId.SelectedValue == "0")
        //            return "";
        //        return ddlCodeTypeId.SelectedValue;
        //    }
        //    set
        //    {
        //        if (ddlCodeTypeId.Items.Count > 0)
        //        {
        //            if (value == "")
        //            {
        //                ddlCodeTypeId.SelectedValue = "0";
        //            }
        //            else
        //            {
        //                ddlCodeTypeId.SelectedValue = value;
        //            }
        //        }
        //    }
        //}
        /// <summary>
        /// 应用程序类型ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public int ApplicationTypeId
        {
            get
            {
                if (ddlApplicationTypeId.SelectedValue == "0")
                    return 0;
                return int.Parse(ddlApplicationTypeId.SelectedValue);
            }
            set
            {
                if (ddlApplicationTypeId.Items.Count > 0)
                {
                    if (value == 0)
                    {
                        ddlApplicationTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlApplicationTypeId.SelectedValue = value.ToString();
                    }
                }
            }
        }
        /// <summary>
        /// 序号
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 修改日期
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string UpdDate
        {
            get
            {
                return clsDateTime.getTodayDateTimeStr(1);
            }
         
        }

        /// <summary>
        /// 修改者
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string UpdUser
        {
            get
            {
                return clsCommonSession.UserId;
            }       
        }

        /// <summary>
        /// 说明
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtFuncId4Code.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            txtFuncId4Code.Text = "";
            txtFuncName4Code.Text = "";
            txtFuncCHName4Code.Text = "";
            //txtFunctionSignature.Text = "";
            ddlReturnTypeID.SelectedIndex = 0;
            ddlFuncTypeID.SelectedIndex = 0;            
            txtOrderNum.Text = "0";
            
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
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDefaultValue()
        {
            txtFuncId4Code.Text = "";
            txtFuncName4Code.Text = "";
            txtFuncCHName4Code.Text = "";
            //txtFunctionSignature.Text = "";
            ddlReturnTypeID.SelectedIndex = 0;
            ddlFuncTypeID.SelectedIndex = 0;
         
            txtOrderNum.Text = "0";
            
            txtMemo.Text = "";
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[DataTypeAbbr]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetReturnTypeID()
        {
            //获取某学院所有专业信息
            string strSQL = "select DataTypeId, DataTypeName from DataTypeAbbr ";
            clsSpecSQLforSql mySql = clsFunction4CodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ReturnTypeID(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetReturnTypeID();
            objDDL.DataValueField = conDataTypeAbbr.DataTypeId;
            objDDL.DataTextField = conDataTypeAbbr.DataTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
       
        /// <summary>
        /// 为下拉框获取数据,从表:[Users]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = clsFunction4CodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUserId();
            objDDL.DataValueField = conUsers.UserId;
            objDDL.DataTextField = conUsers.UserName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_ReturnTypeID()
        {
            clsDataTypeAbbrBL.BindDdl_DataTypeIdCache(ddlReturnTypeID);
        }
        public void SetDdl_FuncTypeID()
        {
            clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeID);
        }

        //public void SetDdl_CodeTypeId()
        //{
        //    clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeId);
        //}
        public void SetDdl_ApplicationTypeId()
        {
            clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeId);
            //            clsFunction4CodeBL.BindDdl_FuncId4Code(ddlFuncId4Code);
        }

        protected void ddlReturnTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlReturnTypeID.SelectedIndex <= 0) return;
            string strReturnTypeID = ddlReturnTypeID.SelectedValue;
            switch(strReturnTypeID)
            {
                case enumDataTypeAbbr.Object_29:
                case enumDataTypeAbbr.ObjectLst_30:
                    txtReturnTypeNameCustom.Visible = true;
                    break;
                default:
                    txtReturnTypeNameCustom.Text = "";
                    txtReturnTypeNameCustom.Visible = false;

                    break;
            }
        }
        /// <summary>
        /// 函数类型
        /// </summary>
        private string qsFuncTypeId
        {
            get
            {
                string strFuncTypeId = Request.QueryString["FuncTypeId"] ?? "".ToString();
                if ((strFuncTypeId != null) && (strFuncTypeId != ""))
                {
                    return strFuncTypeId;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}