
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucSelfDefDataTypeB
表名:SelfDefDataType
生成代码版本:2017.07.08.1
生成日期:2017/07/29 23:01:23
生成者:
工程名称:AGC
工程ID:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.07.14.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
    ///		wucSelfDefDataTypeB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucSelfDefDataTypeB : System.Web.UI.UserControl
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
        /// 自定义数据类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string SdDataTypeId
        {
            get
            {
                return txtSdDataTypeId.Text.Trim();
            }
            set
            {
                txtSdDataTypeId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 数据类型名称
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string DataTypeName
        {
            get
            {
                return txtDataTypeName.Text.Trim();
            }
            set
            {
                txtDataTypeName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否对象
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsObject
        {
            get
            {
                return chkIsObject.Checked;
            }
            set
            {
                chkIsObject.Checked = value;
            }
        }

        /// <summary>
        /// 默认变量名
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string DefaVarName
        {
            get
            {
                return txtDefaVarName.Text.Trim();
            }
            set
            {
                txtDefaVarName.Text = value.ToString();
            }
        }


        /// <summary>
        /// 数据类型中文名称
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string DataCnName
        {
            get
            {
                return txtDataCnName.Text.Trim();
            }
            set
            {
                txtDataCnName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 数据类型缩写
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string DataTypeAbbr
        {
            get
            {
                return txtDataTypeAbbr.Text.Trim();
            }
            set
            {
                txtDataTypeAbbr.Text = value.ToString();
            }
        }

        /// <summary>
        /// VBNET类型
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string VbNetType
        {
            get
            {
                return txtVbNetType.Text.Trim();
            }
            set
            {
                txtVbNetType.Text = value.ToString();
            }
        }

        /// <summary>
        /// CS类型
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string CsType
        {
            get
            {
                return txtCsType.Text.Trim();
            }
            set
            {
                txtCsType.Text = value.ToString();
            }
        }

        /// <summary>
        /// JAVA类型
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string JavaType
        {
            get
            {
                return txtJavaType.Text.Trim();
            }
            set
            {
                txtJavaType.Text = value.ToString();
            }
        }

        /// <summary>
        /// JAVA对象类型
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string JavaObjType
        {
            get
            {
                return txtJavaObjType.Text.Trim();
            }
            set
            {
                txtJavaObjType.Text = value.ToString();
            }
        }

        /// <summary>
        /// SwiftType
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string SwiftType
        {
            get
            {
                return txtSwiftType.Text.Trim();
            }
            set
            {
                txtSwiftType.Text = value.ToString();
            }
        }

      

        /// <summary>
        /// Ora数据类型
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string OraDbType
        {
            get
            {
                return txtOraDbType.Text.Trim();
            }
            set
            {
                txtOraDbType.Text = value.ToString();
            }
        }

        

        /// <summary>
        /// SQL参数类型
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string SqlParaType
        {
            get
            {
                return txtSqlParaType.Text.Trim();
            }
            set
            {
                txtSqlParaType.Text = value.ToString();
            }
        }

        /// <summary>
        /// MySqlType
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string MySqlType
        {
            get
            {
                return txtMySqlType.Text.Trim();
            }
            set
            {
                txtMySqlType.Text = value.ToString();
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
            txtSdDataTypeId.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            txtSdDataTypeId.Text = "";
            txtDataTypeName.Text = "";
            txtDataCnName.Text = "";
            txtDataTypeAbbr.Text = "";
            txtVbNetType.Text = "";
            txtCsType.Text = "";
            txtJavaType.Text = "";
            txtJavaObjType.Text = "";
            txtSwiftType.Text = "";          
            txtOraDbType.Text = "";        
            txtSqlParaType.Text = "";
            txtMySqlType.Text = "";
            ddlPrjId.SelectedIndex = 0;           
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
            txtSdDataTypeId.Text = "";
            txtDataTypeName.Text = "";
            txtDataCnName.Text = "";
            txtDataTypeAbbr.Text = "";
            txtVbNetType.Text = "";
            txtCsType.Text = "";
            txtJavaType.Text = "";
            txtJavaObjType.Text = "";
            txtSwiftType.Text = "";           
            txtOraDbType.Text = "";         
            txtSqlParaType.Text = "";
            txtMySqlType.Text = "";          
            ddlPrjId.SelectedIndex = 0;
          
            txtMemo.Text = "";
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
            clsSpecSQLforSql mySql = clsSelfDefDataTypeBL.GetSpecSQLObj();
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
        public void SetDdl_PrjId()
        {
            clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
    }
}