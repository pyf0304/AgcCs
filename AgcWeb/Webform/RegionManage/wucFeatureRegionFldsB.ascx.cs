
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucFeatureRegionFldsB
界面名:wfmFeatureRegionFlds_QUDI(00050127)
生成代码版本:2019.04.12.1
生成日期:2019/04/12 10:07:37
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:区域管理
模块英文名:RegionManage
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
    
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;
    using AGC.BusinessLogicEx;
    using System.Text;

    /// <summary>
    ///		wucFeatureRegionFldsB 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucFeatureRegionFldsB : System.Web.UI.UserControl
    {
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 区域Id
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string RegionId
        {
            get
            {
                return txtRegionId.Text.Trim();
            }
            set
            {
                txtRegionId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 功能Id
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
                    SetCtrlPropByFeatureId(value);
                }
            }
        }

        public string KeyIdGetModeId
        {
            get
            {
                if (ddlKeyIdGetModeId.SelectedValue == "0")
                    return "";
                return ddlKeyIdGetModeId.SelectedValue;
            }
            set
            {
                if (ddlKeyIdGetModeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlKeyIdGetModeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlKeyIdGetModeId.SelectedValue = value;
                    }                    
                }
            }
        }

        /// <summary>
        /// 功能说明
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        //public string FeatureDescription
        //{
        //    get
        //    {
        //        return txtFeatureDescription.Text.Trim();
        //    }
        //    set
        //    {
        //        txtFeatureDescription.Text = value.ToString();
        //    }
        //}

        public string GroupName
        {
            get
            {
                return txtGroupName.Text.Trim();
            }
            set
            {
                txtGroupName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 按钮名称
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// 按钮名称4Mvc
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string ButtonName4Mvc
        {
            get
            {
                return txtButtonName4Mvc.Text.Trim();
            }
            set
            {
                txtButtonName4Mvc.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文本
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// 表ID
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string TabId
        {
            get
            {
                if (ddlTabId.SelectedValue == "0")
                    return "";
                return ddlTabId.SelectedValue;
            }
            set
            {
                if (ddlTabId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTabId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlTabId.SelectedValue = value;
                    }
                }
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
                        ddlFldId.SelectedValue = value;
                    }
                }
            }
        }
        /// <summary>
        /// 字段类型Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
                        SetFldVisibilityByFieldTypeId(value);
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
        /// </summary>
        public string EventFuncName
        {
            get
            {
                return txtEventFuncName.Text.Trim().Replace("''", "'").Replace("''", "'").Replace("''", "'");
            }
            set
            {
                txtEventFuncName.Text = value.ToString().Replace("''", "'").Replace("''", "'");
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
                return txtFuncName.Text.Trim().Replace("''", "'");
            }
            set
            {
                txtFuncName.Text = value.ToString().Replace("''", "'");
            }
        }

        /// <summary>
        /// 缺省值
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
        /// 界面实现Id
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string ViewImplId
        {
            get
            {
                if (ddlViewImplId.SelectedValue == "0")
                    return "";
                return ddlViewImplId.SelectedValue;
            }
            set
            {
                if (ddlViewImplId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlViewImplId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlViewImplId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 控件类型号
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// 样式表
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// 表功能Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string TabFeatureId
        {
            get
            {
                if (ddlTabFeatureId.SelectedValue == "0")
                    return "";
                return ddlTabFeatureId.SelectedValue;
            }
            set
            {
                if (ddlTabFeatureId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTabFeatureId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlTabFeatureId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 是否在用
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// 宽
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// 说明
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        //public string Memo
        //{
        //    get
        //    {
        //        return txtMemo.Text.Trim();
        //    }
        //    set
        //    {
        //        txtMemo.Text = value.ToString();
        //    }
        //}


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>	
        public void Clear()
        {
            txtRegionId.Text = "0";
            ddlFeatureId.SelectedIndex = 0;
            //txtFeatureDescription.Text = "";
            txtButtonName.Text = "";
            txtText.Text = "";
            ddlViewImplId.SelectedIndex = 0;
            ddlCtlTypeId.SelectedIndex = 0;
            txtCssClass.Text = "";
            txtImageUrl.Text = "";
            chkInUse.Checked = false;
            txtWidth.Text = "0";
            txtSeqNum.Text = "0";
            
            //txtMemo.Text = "";
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则:
        ///		1、首先校验类型:整型、浮点型、日期型等,
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值,即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            ComValid_RegionId.Validate();
            if (!ComValid_RegionId.IsValid) return false;
            ComValid_Width.Validate();
            if (!ComValid_Width.IsValid) return false;
            ComValid_SeqNum.Validate();
            if (!ComValid_SeqNum.IsValid) return false;
            if (clsString.IsNumeric(txtRegionId.Text) == false)
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
        /// 一般规则:
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public void SetDefaultValue()
        {
            txtRegionId.Text = "0";
            ddlFeatureId.SelectedIndex = 0;
            //txtFeatureDescription.Text = "";
            txtButtonName.Text = "";
            txtText.Text = "";
            ddlViewImplId.SelectedIndex = 0;
            ddlCtlTypeId.SelectedIndex = 0;
            txtCssClass.Text = "";
            txtImageUrl.Text = "";
            chkInUse.Checked = false;
            txtWidth.Text = "0";
            txtSeqNum.Text = "0";
            
            //txtMemo.Text = "";
        }
        
        public void SetDdl_FeatureId()
        {
            clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureId, enumPrjFeatureType.FrontInterface_01);
        }
        public void SetDdl_ViewImplId()
        {
            clsViewImplementationBL.BindDdl_ViewImplId(ddlViewImplId);
        }
        public void SetVisible4ButtonName4Mvc(bool bolIsVisible)
        {
            trButtonName4Mvc.Visible = bolIsVisible;
        }
        public void SetVisible4ButtonName(bool bolIsVisible)
        {
            trButtonName.Visible = bolIsVisible;
        }
        public void SetVisible4FieldTypeId(bool bolIsVisible)
        {
            trFieldTypeId.Visible = bolIsVisible;
        }
        public void SetVisible4FldId(bool bolIsVisible)
        {
            trFldId.Visible = bolIsVisible;
        }
        public void SetVisible4ValueGivingModeId(bool bolIsVisible)
        {
            trValueGivingModeId.Visible = bolIsVisible;
        }
        
        public void SetDdl_CtlTypeId(bool bolIsForApple)
        {
            clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeId, bolIsForApple);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[ValueGivingModeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ValueGivingModeId()
        {
            clsValueGivingModeBL.BindDdl_ValueGivingModeIdCache(ddlValueGivingModeId);
        }
        public void HiddenTrTabId()
        {
            trHidden.Visible = false;
            trHidden2.Visible = false;
            trHidden3.Visible = false;
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[FldId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FldId(string strTabId)
        {
            clsFieldTabBLEx.BindDdl_FldIDByTabIdEx(ddlFldId, clsPubVar.CurrSelPrjId, strTabId);
        }

        protected void ddlFldId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFldId.SelectedIndex <= 0) return;
            if (ddlFeatureId.SelectedIndex <= 0) return;

            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(this.FeatureId);
            string strFuncName = "";
           string strFldId = ddlFldId.SelectedValue;
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
            switch (objPrjFeatureEN.FeatureName)
            {
                case "设置字段值":

                    strFuncName = string.Format("Set{0}", objFieldTab.FldName);
                    this.ButtonName = string.Format("btnSet{0}", objFieldTab.FldName);
                    this.Text = string.Format("设置{0}", objFieldTab.Caption);
                    if (objFieldTab.DataTypeId == enumDataTypeAbbr.bit_03)
                    {

                        string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                            conFeatureRegionFlds.RegionId, "",
                            conFeatureRegionFlds.FuncName, strFuncName);
                        if (clsFeatureRegionFldsBL.IsExistRecord(strCondition) == false)
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
                    strFuncName = "";// string.Format("Copy{0}", objFieldTab.FldName);
                    this.ButtonName = string.Format("btnCopyRecord", objFieldTab.FldName);
                    this.Text = string.Format("复制记录", objFieldTab.Caption);
                    txtFuncName.Text = strFuncName;
                    break;
                default:
                    break;
            }
        }
        public string vsMainTabId
        {
            get
            {
                string sMainTabId;
                sMainTabId = (string)ViewState["MainTabId"];
                if (sMainTabId == null)
                {
                    sMainTabId = "";
                }
                return sMainTabId;
            }
            set
            {
                string sMainTabId = value;
                ViewState.Add("MainTabId", sMainTabId);
            }
        }

        protected void SetCtrlPropByFeatureId(string strFeatureId)
        {
            if (string.IsNullOrEmpty(strFeatureId)) return;
            trEventFuncName.Visible = false;
            trFuncName.Visible = false;
            trKeyIdGetModeId.Visible = false;
            trValueGivingModeId.Visible = false;
            trFieldTypeId.Visible = false;

            //clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);

            //string strFldId = ddlFldId.SelectedValue;
            //clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
            switch (strFeatureId)
            {
                case enumPrjFeature.SetFieldValue_0148:
                    lblDefaultValue.Text = "缺省值";
                    trEventFuncName.Visible = true;
                    trFuncName.Visible = true;
                    //if (string.IsNullOrEmpty( this.EventFuncName))
                    //{
                    //    this.EventFuncName = string.Format("btn_Click('{0}')", this.ButtonName.Substring(3));
                    //}
                    //if (string.IsNullOrEmpty(this.FuncName))
                    //{
                    //    this.FuncName = string.Format("{0}_Click()", this.ButtonName);
                    //}
                    trValueGivingModeId.Visible = true;
                    trKeyIdGetModeId.Visible = true;
                    break;
                case enumPrjFeature.UpMove_0160:
                case enumPrjFeature.DownMove_0161:
                case enumPrjFeature.GoTop_0159:
                case enumPrjFeature.GoButton_0162:
                case enumPrjFeature.ReOrder_0163:
                    trEventFuncName.Visible = true;
                    trFuncName.Visible = true;
                    trKeyIdGetModeId.Visible = true;

                    break;
                case enumPrjFeature.DefaultFeature_0240:
                    //lblDefaultValue.Text = "缺省值";
                    trEventFuncName.Visible = true;
                    trFuncName.Visible = true;
                    //if (string.IsNullOrEmpty(this.EventFuncName))
                    //{
                    //    this.EventFuncName = string.Format("btn_Click('{0}')", this.ButtonName.Substring(3));
                    //}
                    //if (string.IsNullOrEmpty(this.FuncName))
                    //{
                    //    this.FuncName = string.Format("{0}_Click()", this.ButtonName);
                    //}
                    break;
                case enumPrjFeature.CopyRecord_0141:
                case enumPrjFeature.CopyRecord_0198:
                    lblDefaultValue.Text = "复制前缀";
                    if (string.IsNullOrEmpty(DefaultValue))
                    {
                        DefaultValue = "Copy_";
                    }
                    trKeyIdGetModeId.Visible = true;
                    FieldTypeId = enumFieldType.AdditionalCopyField_15;
                    break;
                case enumPrjFeature.AddNewRecord_0136:
                case enumPrjFeature.AddNewRecord_0197:
                case enumPrjFeature.UpdateRecord_0137:
                case enumPrjFeature.UpdateRecord_0199:
                    trKeyIdGetModeId.Visible = true;
                    break;
                default:
                    break;
            }
        }

        public void SetDefaEventName(string strCtrlId)
        {
            string strKey = strCtrlId;
            if (strCtrlId.Length > 3) strKey = strCtrlId.Substring(3);
            string strDefaFuncName = string.Format("{0}_Click", strCtrlId);
            string strDefaEventFuncName = string.Format("btn_Click('{0}')", strKey);

            txtFuncName.Attributes.Add("DefaFuncName", strDefaFuncName);
            txtEventFuncName.Attributes.Add("DefaEventFuncName", strDefaEventFuncName);
            txtFuncName.Attributes.Add("placeholder", "单击添加函数名");
            txtEventFuncName.Attributes.Add("placeholder", "单击添加相关事件函数名");

            StringBuilder sbScript = new StringBuilder();
            sbScript.AppendFormat("txtFuncName='{0}';", txtFuncName.ClientID);
            sbScript.AppendFormat("txtEventFuncName='{0}';", txtEventFuncName.ClientID);
            sbScript.AppendFormat("SetDefaEventName();");
            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "SetDefaEventName", sbScript.ToString(), true);

        }

        protected void ddlFeatureId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCtrlPropByFeatureId(this.FeatureId);
        }
        

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FieldTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FieldTypeId()
        {
            clsFieldTypeBL.BindDdl_FieldTypeIdCache(ddlFieldTypeId);
        }


        public void SetDdl_KeyIdGetModeId()
        {
            clsGCKeyIdGetModeBL.BindDdl_KeyIdGetModeIdCache(ddlKeyIdGetModeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[TabFeatureId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_TabFeatureId(string strTabId, string strPrjId)
        {
            clsTabFeatureBLEx.BindDdl_TabFeatureIdExByTabId(ddlTabFeatureId, strTabId, strPrjId);
        }

        protected void ddlFieldTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFieldTypeId.SelectedIndex <= 0) return;
            SetFldVisibilityByFieldTypeId(FieldTypeId);
        }
        public void SetFldVisibilityByFieldTypeId(string strFieldTypeId)
        {
            trValueGivingModeId.Visible = true;
            trFuncName.Visible = true;
            switch (strFieldTypeId)
            {
                case enumFieldType.OrderNumField_09:
                    trValueGivingModeId.Visible = false;
                    trFuncName.Visible = false;
                    break;
            }
        }
    }
}