
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucPrjFeatureB
表名:PrjFeature
生成代码版本:2017.03.30.1
生成日期:2017/03/31
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.02.21.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 == == == == == == == == == == == == 
*/

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
    using System.Collections.Generic;

    /// <summary>
    ///		wucPrjFeatureB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucPrjFeatureB : System.Web.UI.UserControl
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
        /// 功能Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FeatureId
        {
            get
            {
                return txtFeatureId.Text.Trim();
            }
            set
            {
                txtFeatureId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 功能名称
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FeatureName
        {
            get
            {
                return txtFeatureName.Text.Trim();
            }
            set
            {
                txtFeatureName.Text = value.ToString();
            }
        }
        /// <summary>
        /// 默认按钮名
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public string DefaButtonName
        {
            get
            {
                return txtDefaButtonName.Text.Trim();
            }
            set
            {
                txtDefaButtonName.Text = value.ToString();
            }
        }
        /// <summary>
        /// 关键字
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string KeyWords
        {
            get
            {
                return txtKeyWords.Text.Trim();
            }
            set
            {
                txtKeyWords.Text = value.ToString();
            }
        }
        /// <summary>
        /// 区域类型Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string RegionTypeId
        {
            get
            {
                if (ddlRegionTypeId.SelectedValue == "0")
                    return "";
                return ddlRegionTypeId.SelectedValue;
            }
            set
            {
                if (ddlRegionTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlRegionTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlRegionTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// INOUT类型ID
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string InOutTypeId
        {
            get
            {
                if (ddlInOutTypeId.SelectedValue == "0")
                    return "";
                return ddlInOutTypeId.SelectedValue;
            }
            set
            {
                if (ddlInOutTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlInOutTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlInOutTypeId.SelectedValue = value;
                    }
                }
            }
        }
        /// <summary>
        /// 父功能Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ParentFeatureId
        {
            get
            {
                if (ddlParentFeatureId.SelectedValue == "0")
                    return "";
                return ddlParentFeatureId.SelectedValue;
            }
            set
            {
                if (ddlParentFeatureId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlParentFeatureId.SelectedValue = "0";
                    }
                    else
                    {
                        try
                        {
                            ddlParentFeatureId.SelectedValue = value;
                        }
                        catch(Exception objException)
                        {

                            clsPubVar.objLog.WriteDebugLog(objException.Message);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 函数组Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FunctionGroupId
        {
            get
            {
                if (ddlFunctionGroupId.SelectedValue == "0")
                    return "";
                return ddlFunctionGroupId.SelectedValue;
            }
            set
            {
                if (ddlFunctionGroupId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFunctionGroupId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFunctionGroupId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 功能类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FeatureTypeId
        {
            get
            {
                if (ddlFeatureTypeId.SelectedValue == "0")
                    return "";
                return ddlFeatureTypeId.SelectedValue;
            }
            set
            {
                if (ddlFeatureTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFeatureTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFeatureTypeId.SelectedValue = value;
                    }
                }
            }
        }
        /// <summary>
        /// 组名
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
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
        /// 功能说明
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FeatureDescription
        {
            get
            {
                return txtFeatureDescription.Text.Trim();
            }
            set
            {
                txtFeatureDescription.Text = value.ToString();
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
        /// 建立用户Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string CreateUserId
        {
            get
            {
                return txtCreateUserId.Text.Trim();
            }
            set
            {
                txtCreateUserId.Text = value.ToString();
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
            txtFeatureId.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            txtFeatureId.Text = "";
            txtFeatureName.Text = "";
            ddlFeatureTypeId.SelectedIndex = 0;
            txtCreateUserId.Text = "";
   
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
            txtFeatureId.Text = "";
            txtFeatureName.Text = "";
            ddlFeatureTypeId.SelectedIndex = 0;
            txtCreateUserId.Text = "";

            txtMemo.Text = "";
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[PrjFeatureType]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFeatureTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FeatureTypeId, FeatureTypeName from PrjFeatureType ";
            clsSpecSQLforSql mySql = clsPrjFeatureBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FeatureTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFeatureTypeId();
            objDDL.DataValueField = conPrjFeatureType.FeatureTypeId;
            objDDL.DataTextField = conPrjFeatureType.FeatureTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_FeatureTypeId()
        {
            clsPrjFeatureTypeBL.BindDdl_FeatureTypeIdCache(ddlFeatureTypeId);
        }
        public void SetDdl_FunctionGroupId()
        {
            //clsFunctionGroupBL.BindDdlFunctionGroupId(ddlFunctionGroupId);
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[RegionTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_RegionTypeId()
        {
            clsRegionTypeBL.BindDdl_RegionTypeIdCache(ddlRegionTypeId);
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[InOutTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_InOutTypeId()
        {
            clsInOutTypeBL.BindDdl_InOutTypeIdCache(ddlInOutTypeId);
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[ParentFeatureId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ParentFeatureId()
        {
            clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlParentFeatureId,
                new List<string>() { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03});
        }
    }
}