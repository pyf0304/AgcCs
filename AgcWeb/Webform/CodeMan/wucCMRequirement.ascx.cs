
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucCMRequirement
界面名:wfmCMRequirement_QUDI(00050066)
生成代码版本:2019.11.08.1
生成日期:2019/11/12 08:42:26
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
    ///		wucCMRequirement 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucCMRequirement : System.Web.UI.UserControl
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
        /// 需求Id
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ReqId
        {
            get
            {
                return txtReqId.Text.Trim();
            }
            set
            {
                txtReqId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 名称
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string RequirementName
        {
            get
            {
                return txtRequirementName.Text.Trim();
            }
            set
            {
                txtRequirementName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 内容
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ReqContent
        {
            get
            {
                return txtReqContent.Text.Trim();
            }
            set
            {
                txtReqContent.Text = value.ToString();
            }
        }

        /// <summary>
        /// 需求类型Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string RequirementTypeId
        {
            get
            {
                if (ddlRequirementTypeId.SelectedValue == "0")
                    return "";
                return ddlRequirementTypeId.SelectedValue;
            }
            set
            {
                if (ddlRequirementTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlRequirementTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlRequirementTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 上级需求
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        //public string UpReqId
        //{
        //    get
        //    {
        //        if (ddlUpReqId.SelectedValue == "0")
        //            return "";
        //        return ddlUpReqId.SelectedValue;
        //    }
        //    set
        //    {
        //        if (ddlUpReqId.Items.Count > 0)
        //        {
        //            if (value == "")
        //            {
        //                ddlUpReqId.SelectedValue = "0";
        //            }
        //            else
        //            {
        //                ddlUpReqId.SelectedValue = value;
        //            }
        //        }
        //    }
        //}

        /// <summary>
        /// 是否完成
        /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public bool IsFinished
        {
            get
            {
                return chkIsFinished.Checked;
            }
            set
            {
                chkIsFinished.Checked = value;
            }
        }

        /// <summary>
        /// 模块
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
        /// CM工程Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string CmPrjId
        {
            get
            {
                if (ddlCmPrjId.SelectedValue == "0")
                    return "";
                return ddlCmPrjId.SelectedValue;
            }
            set
            {
                if (ddlCmPrjId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlCmPrjId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlCmPrjId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 修改者
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string UpdUser
        {
            get
            {
                return clsCommonSessionBase.UserId;
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
            txtReqId.ReadOnly = bolReadonly;
        }


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            txtReqId.Text = "";
            txtRequirementName.Text = "";
            txtReqContent.Text = "";
            ddlRequirementTypeId.SelectedIndex = 0;
            //ddlUpReqId.SelectedIndex = 0;
            chkIsFinished.Checked = false;
            ddlFuncModuleAgcId.SelectedIndex = 0;
            ddlCmPrjId.SelectedIndex = 0;
            
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
            txtReqId.Text = "";
            txtRequirementName.Text = "";
            txtReqContent.Text = "";
            ddlRequirementTypeId.SelectedIndex = 0;
            //ddlUpReqId.SelectedIndex = 0;
            chkIsFinished.Checked = false;
            ddlFuncModuleAgcId.SelectedIndex = 0;
            ddlCmPrjId.SelectedIndex = 0;
            
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[CMRequirementType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetRequirementTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select RequirementTypeId, RequirementTypeName from CMRequirementType ";
            clsSpecSQLforSql mySql = clsCMRequirementTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_RequirementTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetRequirementTypeId();
            objDDL.DataValueField = conCMRequirementType.RequirementTypeId;
            objDDL.DataTextField = conCMRequirementType.RequirementTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[CMRequirement]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetUpReqId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ReqId, RequirementName from CMRequirement ";
            clsSpecSQLforSql mySql = clsCMRequirementBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_UpReqId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUpReqId();
            objDDL.DataValueField = conCMRequirement.ReqId;
            objDDL.DataTextField = conCMRequirement.RequirementName;
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
        /// 为下拉框获取数据,从表:[CMProject]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetCmPrjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select CmPrjId, CmPrjName from CMProject ";
            clsSpecSQLforSql mySql = clsCMProjectBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_CmPrjId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetCmPrjId();
            objDDL.DataValueField = conCMProject.CmPrjId;
            objDDL.DataTextField = conCMProject.CmPrjName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[RequirementTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_RequirementTypeId()
        {
            clsCMRequirementTypeBL.BindDdl_RequirementTypeIdCache(ddlRequirementTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[UpReqId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        //public void SetDdl_UpReqId(string strCmPrjId)
        //{
        //    clsCMRequirementBL.BindDdl_ReqId(ddlUpReqId, strCmPrjId);
        //}

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FuncModuleAgcId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FuncModuleAgcId(string strPrjId)
        {
            clsFuncModule_AgcBLEx.BindDdl_FuncModuleAgcIdEx(ddlFuncModuleAgcId, strPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[CmPrjId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_CmPrjId(string strPrjId)
        {
            clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjId, strPrjId);
        }

        protected void ddlCmPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCmPrjId.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjId.SelectedValue;
            //clsCMRequirementBL.BindDdl_ReqId(ddlUpReqId, strCmPrjId);
        }
    }
}