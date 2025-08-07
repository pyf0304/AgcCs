
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucCMClass
界面名:wfmCMClass_QUDI(00050256)
生成代码版本:2019.10.24.1
生成日期:2019/11/02 11:22:32
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理
模块英文名:CodeMan
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
    using System.Collections.Generic;
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
    using AGC.BusinessLogic;
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucCMClass 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucCMClass : System.Web.UI.UserControl
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
        /// 应用程序类型ID
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
        /// 类Id
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string CmClassId
        {
            get
            {
                return txtCmClassId.Text.Trim();
            }
            set
            {
                txtCmClassId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 类名
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
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

        /// <summary>
        /// 编程语言类型Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
        /// 表名
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
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
        /// 域名
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string NameSpace
        {
            get
            {
                return txtNameSpace.Text.Trim();
            }
            set
            {
                txtNameSpace.Text = value.ToString();
            }
        }
        public string ProjectPath
        {
            get
            {
                return txtProjectPath.Text.Trim();
            }
            set
            {
                txtProjectPath.Text = value.ToString();
            }
        }
        /// <summary>
        /// 文件路径
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FilePath
        {
            get
            {
                return txtFilePath.Text.Trim();
            }
            set
            {
                txtFilePath.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文件名
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FileName
        {
            get
            {
                return txtFileName.Text.Trim();
            }
            set
            {
                txtFileName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文件内容
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FileText
        {
            get
            {
                return txtFileText.Text.Trim();
            }
            set
            {
                txtFileText.Text = value.ToString();
            }
        }

        /// <summary>
        /// 功能模块Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FuncModuleAgcId
        {
            get
            {
                if (ddlFuncModuleAgcId.SelectedValue == "0")
                    return "";
                return ddlFuncModuleAgcId.SelectedValue;
            }
            set
            {
                if (ddlFuncModuleAgcId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncModuleAgcId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncModuleAgcId.SelectedValue = value;
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
                        try
                        {
                            ddlCodeTypeId.SelectedValue = value;
                        }
                        catch(Exception objException)
                        {
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);

                            //string ss = "";
                        }
                    }
                }
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtCmClassId.ReadOnly = bolReadonly;
        }


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            txtCmClassId.Text = "";
            txtClassName.Text = "";
            ddlProgLangTypeId.SelectedIndex = 0;
            txtTabName.Text = "";
            txtNameSpace.Text = "";
            txtFilePath.Text = "";
            txtFileName.Text = "";
            txtFileText.Text = "";
            ddlFuncModuleAgcId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
        
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
            txtCmClassId.Text = "";
            txtClassName.Text = "";
            ddlProgLangTypeId.SelectedIndex = 0;
            txtTabName.Text = "";
            txtNameSpace.Text = "";
            txtFilePath.Text = "";
            txtFileName.Text = "";
            txtFileText.Text = "";
            ddlFuncModuleAgcId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
     
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[ProgLangType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetProgLangTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ProgLangTypeId, ProgLangTypeName from ProgLangType ";
            clsSpecSQLforSql mySql = clsProgLangTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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
        /// 为下拉框获取数据,从表:[FuncModule_Agc]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFuncModuleAgcId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FuncModuleAgcId, FuncModuleName from FuncModule_Agc ";
            clsSpecSQLforSql mySql = clsFuncModule_AgcBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FuncModuleAgcId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFuncModuleAgcId();
            objDDL.DataValueField = conFuncModule_Agc.FuncModuleAgcId;
            objDDL.DataTextField = conFuncModule_Agc.FuncModuleName;
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
        /// 为下拉框获取数据,从表:[Users]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = clsUsersBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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

        /// <summary>
        /// 为下拉框获取数据,从表:[Projects]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetPrjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjId, PrjName from Projects ";
            clsSpecSQLforSql mySql = clsProjectsBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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
        /// 设置绑定下拉框，针对字段:[ProgLangTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ProgLangTypeId()
        {
            clsProgLangTypeBLEx.BindDdl_ProgLangTypeIdExCache(ddlProgLangTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FuncModuleAgcId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FuncModuleAgcId(string strPrjId)
        {
            clsFuncModule_AgcBLEx.BindDdl_FuncModuleIdExCache(ddlFuncModuleAgcId, strPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[CodeTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_CodeTypeId( string strProgLangTypeId)
        {
            clsCodeTypeBLEx.BindDdl_CodeTypeIdByProgLangTypeidEx(ddlCodeTypeId, strProgLangTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[PrjId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>


        protected void ddlProgLangTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProgLangTypeId.SelectedIndex <= 0) return;
            string strProgLangTypeId = ddlProgLangTypeId.SelectedValue;
            SetDdl_CodeTypeId(strProgLangTypeId);
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[ApplicationTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ApplicationTypeId()
        {
            clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeId);
        }

        protected void ddlApplicationTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlApplicationTypeId.SelectedIndex <= 0) return;
            int intApplicationTypeId = int.Parse(ddlApplicationTypeId.SelectedValue.ToString());
            clsCodeTypeBLEx.BindDdl_CodeTypeIdByApplicationTypeidEx(ddlCodeTypeId, intApplicationTypeId);
        }
    }
}