
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucFunction4GeneCodeB
表名:Function4GeneCode
生成代码版本:2017.03.27.1
生成日期:2017/03/28
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.02.21.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
/// == == == == == == == == == == == == 
*/

namespace AGC.Webform
{
    using System;
    using System.Web.UI.WebControls;
    using AGC.BusinessLogic;
    using AGC.Entity;
    using AGC.FunClass;
    using AutoGCLib;
    using BusinessLogicEx;
    using com.taishsoft.commdb;
    using com.taishsoft.datetime;
    using CommFunc4WebForm;

    /// <summary>
    ///		wucFunction4GeneCodeB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucFunction4GeneCodeB : System.Web.UI.UserControl
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

        }
        /// <summary>
        /// 函数ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncId4GC
        {
            get
            {
                return txtFuncId4GC.Text.Trim();
            }
            set
            {
                txtFuncId4GC.Text = value.ToString();
            }
        }

        /// <summary>
        /// 函数名
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncName
        {
            get
            {
                return txtFuncName.Text.Trim();
            }
            set
            {
                txtFuncName.Text = value.ToString();
            }
        }
        
        
        /// <summary>
        /// 功能Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncId4Code
        {
            get
            {
                if (ddlFuncId4Code.SelectedValue == "0")
                    return "";
                return ddlFuncId4Code.SelectedValue;
            }
            set
            {
                if (ddlFuncId4Code.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncId4Code.SelectedValue = "0";
                    }
                    else
                    {
                        try
                        {
                            ddlFuncId4Code.SelectedValue = value;
                        }
                        catch(Exception objException)
                        {
                            string strSS = objException.Message;
                        }
                    }
                }
            }
        }
        ///// <summary>
        ///// 函数签名
        ///// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        ///// </summary>
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
        /// 功能Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FeatureId
        {
            get
            {
                if (ddlFeatureId.SelectedValue == "0")
                    return "";
                return ddlFeatureId.SelectedValue;
            }
            set
            {
                if (ddlFeatureId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFeatureId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFeatureId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 编程语言类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ProgLangTypeId
        {
            get
            {
                if (ddlProgLangTypeId.SelectedValue == "0")
                    return "";
                return ddlProgLangTypeId.SelectedValue;
            }
            set
            {
                if (ddlProgLangTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlProgLangTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlProgLangTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 程序分层类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncCodeTypeId
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
        /// 数据源类型
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string SqlDsTypeId
        {
            get
            {
                if (ddlSqlDsTypeId.SelectedValue == "0")
                    return "";
                return ddlSqlDsTypeId.SelectedValue;
            }
            set
            {
                if (ddlSqlDsTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlSqlDsTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlSqlDsTypeId.SelectedValue = value;
                    }
                }
            }
        }


        /// <summary>
        /// 工程ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
                        ddlReturnTypeID.SelectedValue = value;
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

        /// <summary>
        /// 是否模板
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 函数代码
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncCode
        {
            get
            {
                return txtFuncCode.Text.Trim();
            }
            set
            {
                txtFuncCode.Text = value.ToString();
            }
        }

        /// <summary>
        /// 用户ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string UserId
        {
            get
            {              
                return clsCommonSession.UserId;
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtFuncId4GC.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            txtFuncId4GC.Text = "";
            txtFuncName.Text = "";
            ddlProgLangTypeId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
            ddlReturnTypeID.SelectedIndex = 0;
            ddlFuncTypeID.SelectedIndex = 0;
            chkIsTemplate.Checked = false;
            txtFuncCode.Text = "";
           
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
            txtFuncId4GC.Text = "";
            txtFuncName.Text = "";
            ddlProgLangTypeId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
            ddlReturnTypeID.SelectedIndex = 0;
            ddlFuncTypeID.SelectedIndex = 0;
            chkIsTemplate.Checked = false;
            txtFuncCode.Text = "";
            
            txtMemo.Text = "";
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[ProgLangType]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetProgLangTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ProgLangTypeId, ProgLangTypeName from ProgLangType ";
            clsSpecSQLforSql mySql = clsFunction4GeneCodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ProgLangTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetProgLangTypeId();
            objDDL.DataValueField = conProgLangType.ProgLangTypeId;
            objDDL.DataTextField = conProgLangType.ProgLangTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

       
        /// <summary>
        /// 为下拉框获取数据,从表:[Projects]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetPrjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjId, PrjName from Projects ";
            clsSpecSQLforSql mySql = clsFunction4GeneCodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_PrjId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPrjId();
            objDDL.DataValueField = conProjects.PrjId;
            objDDL.DataTextField = conProjects.PrjName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
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
            clsSpecSQLforSql mySql = clsFunction4GeneCodeBL.GetSpecSQLObj();
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
            clsSpecSQLforSql mySql = clsFunction4GeneCodeBL.GetSpecSQLObj();
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
        public void SetDdl_ProgLangTypeId()
        {
            clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeId);
        }
        public void SetDdl_CodeTypeId()
        {
            clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeId);
        }
        public void SetDdl_PrjId()
        {
            clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
        public void SetDdl_ReturnTypeID()
        {
            clsDataTypeAbbrBL.BindDdl_DataTypeIdCache(ddlReturnTypeID);
        }

        public void SetDdl_FuncId4Code()
        {
            clsFunction4CodeBLEx.BindDdl_FuncId4CodeEx(ddlFuncId4Code);
        }
        public void SetDdl_FuncTypeID()
        {
            clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeID);
        }
        public void SetDdl_SqlDsTypeId()
        {
            clsSQLDSTypeBL.BindDdl_SqlDsTypeIdCache(ddlSqlDsTypeId);
        }
        public void SetDdl_FeatureId()
        {
            clsPrjFeatureBLEx.BindDdl_FeatureIdExByOrderNum(ddlFeatureId);
        }

        protected void btnGeneCode_Click(object sender, EventArgs e)
        {
            string strFuncId = this.FuncId4GC;
            string strTabId = ddlTabId.SelectedValue;
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                clsCommonJsFunc.Alert(this, "请选择一个测试表！");
                ddlTabId.Focus();
            }
            string strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(strFuncId,
                              strTabId, clsPubVar.CurrPrjDataBaseId, clsPubVar.CurrSelPrjId);
            txtGeneCode.Text = strTemp;
        }
        public void SetDdl_TabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabId, strPrjId);

        }
    }
}