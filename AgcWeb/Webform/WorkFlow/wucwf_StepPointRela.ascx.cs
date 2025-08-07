/*-- -- -- -- -- -- -- -- -- -- --
类名:wucwf_StepPointRela
界面名:wfmwf_StepPointRela_QUDI(00050250)
生成代码版本:2019.08.30.1
生成日期:2019/08/30 01:10:04
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:工作流管理
模块英文名:WorkFlow
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
    using AGC.FunClass;

    /// <summary>
    ///		wucwf_StepPointRela 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucwf_StepPointRela : System.Web.UI.UserControl
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
        /// 结点Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string PointId
        {
            get
            {
                if (ddlPointId.SelectedValue == "0")
                    return "";
                return ddlPointId.SelectedValue;
            }
            set
            {
                if (ddlPointId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPointId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlPointId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 工作流结点类型Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string PointTypeId
        {
            get
            {
                if (ddlPointTypeId.SelectedValue == "0")
                    return "";
                return ddlPointTypeId.SelectedValue;
            }
            set
            {
                if (ddlPointTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPointTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlPointTypeId.SelectedValue = value;
                    }
                }
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
        /// 修改日期
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
          
            ddlPointId.SelectedIndex = 0;
            ddlPointTypeId.SelectedIndex = 0;
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
       
            ddlPointId.SelectedIndex = 0;
            ddlPointTypeId.SelectedIndex = 0;
            txtOrderNum.Text = "0";
            
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[wf_WorkFlow]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetWorkFlowId()
        {
            //获取某学院所有专业信息
            string strSQL = "select WorkFlowId, WorkFlowName from wf_WorkFlow ";
            clsSpecSQLforSql mySql = clswf_WorkFlowBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdlWorkFlowId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetWorkFlowId();
            objDDL.DataValueField = conwf_WorkFlow.WorkFlowId;
            objDDL.DataTextField = conwf_WorkFlow.WorkFlowName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[wf_Point]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetPointId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PointId, PointName from wf_Point ";
            clsSpecSQLforSql mySql = clswf_PointBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_PointId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPointId();
            objDDL.DataValueField = conwf_Point.PointId;
            objDDL.DataTextField = conwf_Point.PointName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[wf_PointType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetPointTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PointTypeId, PointTypeName from wf_PointType ";
            clsSpecSQLforSql mySql = clswf_PointTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_PointTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPointTypeId();
            objDDL.DataValueField = conwf_PointType.PointTypeId;
            objDDL.DataTextField = conwf_PointType.PointTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[PointId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_PointId()
        {
 
            clswf_PointBLEx.BindDdl_PointIdByPrjIdCache(ddlPointId, clsPubVar.CurrSelPrjId);

        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[PointTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_PointTypeId()
        {
            clswf_PointTypeBL.BindDdlPointTypeId(ddlPointTypeId);
        }

    }
}