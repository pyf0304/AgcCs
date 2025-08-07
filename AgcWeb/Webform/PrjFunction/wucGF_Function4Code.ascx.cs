
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
    using System.Collections.Generic;
    using System.Web.UI.WebControls;
    using AGC.BusinessLogic;
    using AGC.Entity;
    using AGC.FunClass;
    using BusinessLogicEx;
    using com.taishsoft.commdb;
    using com.taishsoft.datetime;
    using CommFunc4WebForm;

    /// <summary>
    /// 定义delegate对象类型，它有两个参数，第一个参数是事件发送者对象，第二个参数是事件参数类对象
    /// 声明一个:发生在单击登录之后的事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void OnGFFinished();

    /// <summary>
    ///		wucFunction4CodeB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucGF_Function4Code : System.Web.UI.UserControl
    {
        /// <summary>
        /// 在GridView中，单击[修改]按钮时，所引发的修改事件
        /// </summary>
        public event OnGFFinished onGFFinished;


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
        /// 返回类型ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncAccessModeId
        {
            get
            {
                if (ddlFuncAccessModeId.SelectedValue == "0")
                    return "";
                return ddlFuncAccessModeId.SelectedValue;
            }
            set
            {
                if (ddlFuncAccessModeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncAccessModeId.SelectedValue = "0";
                    }
                    else
                    {
                        try
                        {
                            ddlFuncAccessModeId.SelectedValue = value;
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            //txtFuncId4Code.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            ddlFuncAccessModeId.SelectedIndex = 0;
       
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
            ddlFuncAccessModeId.SelectedIndex = 0;          
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
        public void SetDdl_FuncAccessModeId()
        {
            clsFuncAccessModeBL.BindDdl_FuncAccessModeIdCache(ddlFuncAccessModeId);
        }

        protected void ddlFuncAccessModeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFuncAccessModeId.SelectedIndex <= 0) return;
            string strReturnTypeID = ddlFuncAccessModeId.SelectedValue;
            switch(strReturnTypeID)
            {
                case enumDataTypeAbbr.Object_29:
                case enumDataTypeAbbr.ObjectLst_30:
                    break;
                default:
                    break;
            }
        }

        protected void btnGeneCode_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            string strCodeTypeId = objButton.ToolTip;
            if (string.IsNullOrEmpty(strCodeTypeId) == true) return;
            string strFuncId4Code = vsFuncId4Code;
            string strCode = clsFunction4CodeBLEx.GeneCode(strFuncId4Code);


          
        }
        public string FuncId4Code
        {
            set
            {
                if (string.IsNullOrEmpty(value) == true) return;
                vsFuncId4Code = value;
                clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(vsFuncId4Code);
                if (string.IsNullOrEmpty(objFunction4Code.CodeTypeId) == true) return;
                if (string.IsNullOrEmpty(clsPubVar.CurrWorkFlowId) == true)
                {
                    clsCommonJsFunc.Alert(this, "当前没有设置默认的工作流Id,请去相关界面设置！");
                    return;
                }
                clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objFunction4Code.CodeTypeId);
                clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
                clsFuncAccessModeEN objFuncAccessMode = clsFuncAccessModeBL.GetObjByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId);
                string strFuncAccessModeName = "";
                if (objFuncAccessMode != null) strFuncAccessModeName = objFuncAccessMode.FuncAccessModeName;

                litFuncName.Text = string.Format("当前函数:<span class=\"text-primary b\">[{0}]</span>, 属于:<span class=\"text-secondary\">[{1}({2})]</span>层函数, 函数访问模式:<span class=\"text-secondary\">[{3}]</span>", 
                    objFunction4Code.FuncName4Code, objCodeType.CodeTypeName , 
                    objProgLangType.ProgLangTypeSimName, strFuncAccessModeName);
                if (objFuncAccessMode != null)
                {
                    ddlFuncAccessModeId.SelectedValue = objFuncAccessMode.FuncAccessModeId;
                    ddlFuncAccessModeId.Enabled = false;
                }
                else
                {
                    ddlFuncAccessModeId.Enabled = true;
                }

                clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = clsvwf_StepPointRelaBLEx.GetObjByWorkFlowIdAndTabKeyIdCache(clsPubVar.CurrWorkFlowId, objFunction4Code.CodeTypeId);
                btnGeneFunction0.Visible = false;
                btnGeneFunction1.Visible = false;
                btnGeneFunction2.Visible = false;
                btnGeneFunction3.Visible = false;
                IEnumerable<string> arrEndPoints = clswf_StepProcessRelaBLEx.GetNextPointLstCache(clsPubVar.CurrWorkFlowId, objvwf_StepPointRelaEN.PointId);
                int i = 0;
                foreach (string strEndPoint in arrEndPoints)
                {
                    
                    clswf_PointEN objwf_Point = clswf_PointBLEx.GetObjByPointIdCache(strEndPoint);
                    if (objwf_Point.PointName == "起点") continue;
                    if (objwf_Point.PointName == "终点") continue;

                     objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objwf_Point.TabKeyId);
                     objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
                    if (i == 0)
                    {
                        btnGeneFunction0.Text = string.Format("生成函数-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneFunction0.ToolTip = objCodeType.CodeTypeId;
                        btnGeneFunction0.Visible = true;
                    }
                    else if (i == 1)
                    {
                        btnGeneFunction1.Text = string.Format("生成函数-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneFunction1.ToolTip = objCodeType.CodeTypeId;
                        btnGeneFunction1.Visible = true;
                    }
                    else if (i == 2)
                    {
                        btnGeneFunction2.Text = string.Format("生成函数-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneFunction2.ToolTip = objCodeType.CodeTypeId;
                        btnGeneFunction2.Visible = true;
                    }
                    else if (i == 3)
                    {
                        btnGeneFunction3.Text = string.Format("生成函数-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneFunction3.ToolTip = objCodeType.CodeTypeId;
                        btnGeneFunction3.Visible = true;
                    }
                    i++;
                }

            }
        }

        public string FuncId4CodeV2
        {
            set
            {
                if (string.IsNullOrEmpty(value) == true) return;
                vsFuncId4Code = value;
                clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(vsFuncId4Code);
                if (string.IsNullOrEmpty(objFunction4Code.CodeTypeId) == true) return;
                if (string.IsNullOrEmpty(clsPubVar.CurrWorkFlowId) == true)
                {
                    clsCommonJsFunc.Alert(this, "当前没有设置默认的工作流Id,请去相关界面设置！");
                    return;
                }
                clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objFunction4Code.CodeTypeId);
                clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
                clsFuncAccessModeEN objFuncAccessMode = clsFuncAccessModeBL.GetObjByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId);
                string strFuncAccessModeName = "";
                if (objFuncAccessMode != null) strFuncAccessModeName = objFuncAccessMode.FuncAccessModeName;

                litFuncName.Text = string.Format("当前函数:<span class=\"text-primary b\">[{0}]</span>, 属于:<span class=\"text-secondary\">[{1}({2})]</span>层函数, 函数访问模式:<span class=\"text-secondary\">[{3}]</span>",
                    objFunction4Code.FuncName4Code, objCodeType.CodeTypeName,
                    objProgLangType.ProgLangTypeSimName, strFuncAccessModeName);
                if (objFuncAccessMode != null)
                {
                    ddlFuncAccessModeId.SelectedValue = objFuncAccessMode.FuncAccessModeId;
                    ddlFuncAccessModeId.Enabled = false;
                }
                else
                {
                    ddlFuncAccessModeId.Enabled = true;
                }

                clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = clsvwf_StepPointRelaBLEx.GetObjByWorkFlowIdAndTabKeyIdCache(clsPubVar.CurrWorkFlowId, objFunction4Code.CodeTypeId);
                btnGeneFunction0.Visible = false;
                btnGeneFunction1.Visible = false;
                btnGeneFunction2.Visible = false;
                btnGeneFunction3.Visible = false;
                IEnumerable<string> arrEndPoints = clswf_StepProcessRelaBLEx.GetNextPointLstCache(clsPubVar.CurrWorkFlowId, objvwf_StepPointRelaEN.PointId);
                int i = 0;
                foreach (string strEndPoint in arrEndPoints)
                {

                    clswf_PointEN objwf_Point = clswf_PointBLEx.GetObjByPointIdCache(strEndPoint);
                    if (objwf_Point.PointName == "起点") continue;
                    if (objwf_Point.PointName == "终点") continue;

                    objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objwf_Point.TabKeyId);
                    objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
                    if (i == 0)
                    {
                        btnGeneFunction0.Text = string.Format("生成函数-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneFunction0.ToolTip = objCodeType.CodeTypeId;
                        btnGeneFunction0.Visible = true;
                    }
                    else if (i == 1)
                    {
                        btnGeneFunction1.Text = string.Format("生成函数-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneFunction1.ToolTip = objCodeType.CodeTypeId;
                        btnGeneFunction1.Visible = true;
                    }
                    else if (i == 2)
                    {
                        btnGeneFunction2.Text = string.Format("生成函数-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneFunction2.ToolTip = objCodeType.CodeTypeId;
                        btnGeneFunction2.Visible = true;
                    }
                    else if (i == 3)
                    {
                        btnGeneFunction3.Text = string.Format("生成函数-{0}({1})", objCodeType.CodeTypeName, objProgLangType.ProgLangTypeSimName);
                        btnGeneFunction3.ToolTip = objCodeType.CodeTypeId;
                        btnGeneFunction3.Visible = true;
                    }
                    i++;
                }

            }
        }

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected string vsFuncId4Code
        {
            get
            {
                string sFuncId4Code;
                sFuncId4Code = (string)ViewState["FuncId4Code"];
                if (sFuncId4Code == null)
                {
                    sFuncId4Code = "";
                }
                return sFuncId4Code;
            }
            set
            {
                string sFuncId4Code = value;
                ViewState.Add("FuncId4Code", sFuncId4Code);
            }
        }

        protected void btnGeneFunction_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            string strCodeTypeId = objButton.ToolTip;
            if (string.IsNullOrEmpty(strCodeTypeId) == true) return;
            string strFuncId4Code = vsFuncId4Code;
            try
            {
                clsFunction4CodeEN objFunction4Code_New = clsFunction4CodeBLEx.GeneFunction(strFuncId4Code, strCodeTypeId, clsCommonSession.UserId, FuncAccessModeId);
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            if (onGFFinished != null)
            {
                onGFFinished();
            }
        }
    }
}