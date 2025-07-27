
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucFrontAndBack4AppTypeB
表名:FrontAndBack4AppType(00050423)
生成代码版本:2019.02.16.1
生成日期:2019/02/16 15:24:34
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
框架-层名:Web用户控件后台代码(WebCtlControlCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.12.07.01
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

    /// <summary>
    ///		wucFrontAndBack4AppTypeB 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucFrontAndBack4AppTypeB : System.Web.UI.UserControl
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
        /// 应用类型Id4Front
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public int AppTypeId4Front
        {
            get
            {
                if (ddlAppTypeId4Front.SelectedValue == "0")
                    return 0;
                return int.Parse(ddlAppTypeId4Front.SelectedValue);
            }
            set
            {
                if (ddlAppTypeId4Front.Items.Count > 0)
                {
                    if (value == 0)
                    {
                        ddlAppTypeId4Front.SelectedValue = "0";
                    }
                    else
                    {
                        ddlAppTypeId4Front.SelectedValue = value.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// 应用类型Id4Back
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        public int AppTypeId4Back
        {
            get
            {
                if (ddlAppTypeId4Back.SelectedValue == "0")
                    return 0;
                return int.Parse(ddlAppTypeId4Back.SelectedValue);
            }
            set
            {
                if (ddlAppTypeId4Back.Items.Count > 0)
                {
                    if (value == 0)
                    {
                        ddlAppTypeId4Back.SelectedValue = "0";
                    }
                    else
                    {
                        ddlAppTypeId4Back.SelectedValue = value.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// 修改日期
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>	
        public void Clear()
        {
            ddlAppTypeId4Front.SelectedIndex = 0;
            ddlAppTypeId4Back.SelectedIndex = 0;
            
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            ComValid_AppTypeId4Front.Validate();
            if (!ComValid_AppTypeId4Front.IsValid) return false;
            ComValid_AppTypeId4Back.Validate();
            if (!ComValid_AppTypeId4Back.IsValid) return false;
            if (clsString.IsNumeric(ddlAppTypeId4Front.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            if (clsString.IsNumeric(ddlAppTypeId4Back.Text) == false)
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
            ddlAppTypeId4Front.SelectedIndex = 0;
            ddlAppTypeId4Back.SelectedIndex = 0;
            
            txtMemo.Text = "";
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[ApplicationType]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetAppTypeId4Front()
        {
            //获取某学院所有专业信息
            string strSQL = "select ApplicationTypeId, ApplicationTypeName from ApplicationType ";
            clsSpecSQLforSql mySql = clsFrontAndBack4AppTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_AppTypeId4Front(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetAppTypeId4Front();
            objDDL.DataValueField = conApplicationType.ApplicationTypeId;
            objDDL.DataTextField = conApplicationType.ApplicationTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[ApplicationType]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetAppTypeId4Back()
        {
            //获取某学院所有专业信息
            string strSQL = "select ApplicationTypeId, ApplicationTypeName from ApplicationType ";
            clsSpecSQLforSql mySql = clsFrontAndBack4AppTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_AppTypeId4Back(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetAppTypeId4Back();
            objDDL.DataValueField = conApplicationType.ApplicationTypeId;
            objDDL.DataTextField = conApplicationType.ApplicationTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_AppTypeId4Front()
        {
            clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlAppTypeId4Front);
        }
        public void SetDdl_AppTypeId4Back()
        {
            clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlAppTypeId4Back);
        }
    }
}