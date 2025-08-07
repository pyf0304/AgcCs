
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucPrjConstraintB
界面名:wfmPrjConstraint_QUDI(00050172)
生成代码版本:2019.04.19.1
生成日期:2019/04/25 17:37:36
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
    
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;
    using CommFunc4WebForm;
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucPrjConstraintB 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucPrjConstraintB : System.Web.UI.UserControl
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
        /// 约束表Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string PrjConstraintId
        {
            get
            {
                return txtPrjConstraintId.Text.Trim();
            }
            set
            {
                txtPrjConstraintId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 约束表名称
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ConstraintName
        {
            get
            {
                return txtConstraintName.Text.Trim();
            }
            set
            {
                txtConstraintName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 工程ID
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string PrjId
        {
            get
            {
                return clsPubVar.CurrSelPrjId;
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
        /// 约束类型Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ConstraintTypeId
        {
            get
            {
                if (ddlConstraintTypeId.SelectedValue == "0")
                    return "";
                return ddlConstraintTypeId.SelectedValue;
            }
            set
            {
                if (ddlConstraintTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlConstraintTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlConstraintTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 约束说明
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ConstraintDescription
        {
            get
            {
                return txtConstraintDescription.Text.Trim();
            }
            set
            {
                txtConstraintDescription.Text = value.ToString();
            }
        }

        /// <summary>
        /// 建立用户Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string CreateUserId
        {
            get
            {
                return clsCommonSession.UserId;
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
                if (ddlInUse.SelectedIndex == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    if (ddlInUse.Items.Count > 0)
                    {
                        ddlInUse.SelectedIndex = 1;
                    }
                    else
                    {
                        ddlInUse.SelectedIndex = 2;
                    }
                }
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtPrjConstraintId.ReadOnly = bolReadonly;
        }


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            txtPrjConstraintId.Text = "";
            txtConstraintName.Text = "";
            if (trHidden.Visible == true)
            {
                ddlTabId.SelectedIndex = 0;
            }
            ddlConstraintTypeId.SelectedIndex = 0;
            txtConstraintDescription.Text = "";
    
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
            txtPrjConstraintId.Text = "";
            txtConstraintName.Text = "";
            ddlTabId.SelectedIndex = 0;
            ddlConstraintTypeId.SelectedIndex = 0;
            txtConstraintDescription.Text = "";
          
            ddlInUse.SelectedIndex = 0;
          
            txtMemo.Text = "";
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
        /// 为下拉框获取数据,从表:[ConstraintType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetConstraintTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ConstraintTypeId, ConstraintTypeName from ConstraintType ";
            clsSpecSQLforSql mySql = clsConstraintTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
      


        /// <summary>
        /// 设置绑定下拉框，针对字段:[PrjId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        //public void SetDdl_PrjId()
        //{
        //    clsProjectsBL.BindDdl_PrjId(ddlPrjId);
        //}

        /// <summary>
        /// 设置绑定下拉框，针对字段:[TabId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_TabId()
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabId, clsPubVar.CurrSelPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[ConstraintTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ConstraintTypeId()
        {
            clsConstraintTypeBL.BindDdl_ConstraintTypeIdCache(ddlConstraintTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[InUse]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_InUse()
        {
            clsCommForWebForm.BindDdl_TrueAndFalse(ddlInUse);

        }

        public void HiddenTrTabId()
        {
            trHidden.Visible = false;
        }
    }
}