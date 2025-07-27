
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucTabFeatureFldsB
界面名:wfmTabFeatureFlds_QUDI(00050222)
生成代码版本:2019.04.27.1
生成日期:2019/04/28 23:13:21
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
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
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucTabFeatureFldsB 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucTabFeatureFldsB : System.Web.UI.UserControl
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
        /// 表ID
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        //public string TabId
        //{
        //    get
        //    {
        //        if (ddlTabId.SelectedValue == "0")
        //            return "";
        //        return ddlTabId.SelectedValue;
        //    }
        //    set
        //    {
        //        if (ddlTabId.Items.Count > 0)
        //        {
        //            if (value == "")
        //            {
        //                ddlTabId.SelectedValue = "0";
        //            }
        //            else
        //            {
        //                ddlTabId.SelectedValue = value;
        //            }
        //        }
        //    }
        //}

        /// <summary>
        /// 功能Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string TabFeatureId
        {
            //get
            //{
            //    if (ddlTabFeatureId.SelectedValue == "0")
            //        return "";
            //    return ddlTabFeatureId.SelectedValue;
            //}
            set
            {
                vsTabFeatureId = value;
                SetCtrlPropByTabFeatureId(value);
                //if (ddlTabFeatureId.Items.Count > 0)
                //{
                //    if (value == "")
                //    {
                //        ddlTabFeatureId.SelectedValue = "0";
                //    }
                //    else
                //    {
                //        try
                //        {
                //            ddlTabFeatureId.SelectedValue = value;
                //        }
                //        catch(Exception objException)
                //        {

                //        }
                //    }
                  
                //}
            }
        }

        /// <summary>
        /// 字段Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FldId
        {
            get
            {
                if (ddlFldId.SelectedValue == "0")
                    return "";
                return ddlFldId.SelectedValue;
            }
            set
            {
                if (ddlFldId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFldId.SelectedValue = "0";
                    }
                    else
                    {
                        try
                        {
                            ddlFldId.SelectedValue = value;
                        }
                        catch(Exception objException)
                        {

                            clsPubVar.objLog.WriteDebugLog(objException.Message);
                            //string ss = "";
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 字段类型Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
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
                        try
                        {
                            ddlFieldTypeId.SelectedValue = value;
                        }
                        catch(Exception objException)
                        {

                            clsPubVar.objLog.WriteDebugLog(objException.Message);
                            //string ss = "";
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 给值方式Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ValueGivingModeId
        {
            get
            {
                if (ddlValueGivingModeId.SelectedValue == "0")
                    return "";
                return ddlValueGivingModeId.SelectedValue;
            }
            set
            {
                if (ddlValueGivingModeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlValueGivingModeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlValueGivingModeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 函数名
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
        /// DefaValue
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
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
        /// 序号
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
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
        /// 是否在用
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
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
        /// 修改者
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string UpdUser
        {
            get
            {
                return clsCommonSession.UserId;
            }
        }

        /// <summary>
        /// 修改日期
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string UpdDate
        {
            get
            {
                return clsDateTime.getTodayDateTimeStr(1);
            }
        }

        /// <summary>
        /// 说明
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
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
   //         ddlTabId.SelectedIndex = 0;
            //ddlTabFeatureId.SelectedIndex = 0;
            ddlFldId.SelectedIndex = 0;
            ddlFieldTypeId.SelectedIndex = 0;
            txtDefaultValue.Text = "";
            txtOrderNum.Text = "0";
            chkInUse.Checked = false;
            
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
            //ddlTabId.SelectedIndex = 0;
            //ddlTabFeatureId.SelectedIndex = 0;
            ddlFldId.SelectedIndex = 0;
            ddlFieldTypeId.SelectedIndex = 0;
            txtDefaultValue.Text = "";
            txtOrderNum.Text = "0";
            chkInUse.Checked = false;
            
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[PrjTab]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetTabId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TabId, TabName from PrjTab ";
            clsSpecSQLforSql mySql = clsPrjTabBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTabId();
            objDDL.DataValueField = conPrjTab.TabId;
            objDDL.DataTextField = conPrjTab.TabName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[PrjFeature]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFeatureId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FeatureId, FeatureName from PrjFeature ";
            clsSpecSQLforSql mySql = clsPrjFeatureBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FeatureId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFeatureId();
            objDDL.DataValueField = conPrjFeature.FeatureId;
            objDDL.DataTextField = conPrjFeature.FeatureName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[FieldTab]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFldId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FldId, FldName from FieldTab ";
            clsSpecSQLforSql mySql = clsFieldTabBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FldId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFldId();
            objDDL.DataValueField = conFieldTab.FldId;
            objDDL.DataTextField = conFieldTab.FldName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[FieldType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFieldTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FieldTypeId, FieldTypeName from FieldType ";
            clsSpecSQLforSql mySql = clsFieldTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
   


        /// <summary>
        /// 设置绑定下拉框，针对字段:[TabId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        //public void SetDdl_TabId()
        //{
        //    clsPrjTabBL.BindDdl_TabId(ddlTabId);
        //}

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FeatureId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        //public void SetDdl_TabFeatureId(string strTabId)
        //{
        //    //conPrjFeature.FeatureTypeId
        //    clsTabFeatureBLEx.BindDdl_TabFeatureIdExByTabId(ddlTabFeatureId, strTabId);
        //}

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FldId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FldId(string strTabId)
        {
            clsFieldTabBLEx.BindDdl_FldIDByTabIdEx(ddlFldId, clsPubVar.CurrSelPrjId, strTabId);
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[FieldTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FieldTypeId(string strFeatureId)
        {
            clsFieldTypeBLEx.BindDdl_FieldTypeIdByFeatureIdCache(ddlFieldTypeId, strFeatureId);
        }
        public void HiddenTrTabId()
        {
            //trHidden.Visible = false;
        }

        protected void ddlValueGivingModeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlValueGivingModeId.SelectedIndex <= 0) return;
            string strValueGivingModeId = ddlValueGivingModeId.SelectedValue;
            if (strValueGivingModeId == enumValueGivingMode.DefaultValue_01)
            {
                txtDefaultValue.Enabled = true;
            }
            else
            {
                txtDefaultValue.Enabled = false;
            }
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[ValueGivingModeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ValueGivingModeId()
        {
            clsValueGivingModeBL.BindDdl_ValueGivingModeIdCache(ddlValueGivingModeId);
        }

        protected void ddlFldId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFldId.SelectedIndex <= 0) return;
            //if (ddlTabFeatureId.SelectedIndex <= 0) return;
            
            clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureIdCache(vsTabFeatureId, clsPubVar.CurrSelPrjId);
            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objTabFeatureEN.FeatureId);
                        
            string strFldId = ddlFldId.SelectedValue;
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
            switch (objPrjFeatureEN.FeatureName)
            {
                case "设置字段值":
                    string strFuncName = string.Format("Set{0}", objFieldTab.FldName);
                    if (objFieldTab.DataTypeId == enumDataTypeAbbr.bit_03)
                    {
                        string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                            conTabFeatureFlds.TabFeatureId, vsTabFeatureId,
                            conTabFeatureFlds.FuncName, strFuncName);
                        if (clsTabFeatureFldsBL.IsExistRecord(strCondition) == false)
                        {
                            txtFuncName.Text = strFuncName;
                        }
                        else
                        {
                            strFuncName = string.Format("SetNot{0}", objFieldTab.FldName);
                            txtFuncName.Text = strFuncName;
                        }
                    }
                    else
                    {
                        txtFuncName.Text = strFuncName;
                    }
                    break;
                case "复制记录":

                    break;
                default:
                    break;
            }
        }

  
        protected void SetCtrlPropByTabFeatureId(string strTabFeatureId)
        {
            if (string.IsNullOrEmpty(strTabFeatureId)) return;
            clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);

            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objTabFeatureEN.FeatureId);
            string strFldId = ddlFldId.SelectedValue;
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
            switch (objPrjFeatureEN.FeatureName)
            {
                case "绑定下拉框":
                    trDefaultValue.Visible = true;                    
                    trFuncName.Visible = false;
                    trValueGivingModeId.Visible = true;
                    break;
                case "设置字段值":
                    lblDefaultValue.Text = "缺省值";
                    trFuncName.Visible = true;
                    trValueGivingModeId.Visible = true;
                    break;
                case "复制记录":
                    lblDefaultValue.Text = "复制前缀";
                    if (string.IsNullOrEmpty(DefaultValue))
                    {
                        DefaultValue = "Copy_";
                    }
                    trFuncName.Visible = false;
                    trValueGivingModeId.Visible = false;
                    FieldTypeId = enumFieldType.AdditionalCopyField_15;
                    break;
                case "调整记录次序":
                    DefaultValue = "";
                    trDefaultValue.Visible = false;
                    FuncName = "";
                    trFuncName.Visible = false;

                    trValueGivingModeId.Visible = false;

                    break;
                default:
                    break;
            }
        }

        protected void ddlTabFeatureId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCtrlPropByTabFeatureId(vsTabFeatureId);
        }
        protected string vsTabFeatureId
        {
            get
            {
                string sTabFeatureId;
                sTabFeatureId = (string)ViewState["TabFeatureId"];
                if (sTabFeatureId == null)
                {
                    sTabFeatureId = "";
                }
                return sTabFeatureId;
            }
            set
            {
                string sTabFeatureId = value;
                ViewState.Add("TabFeatureId", sTabFeatureId);
            }
        }
    }
}