
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucFileResource
界面名:wfmFileResourceB_QUDI(00050277)
生成代码版本:2020.05.09.1
生成日期:2020/05/12 00:14:15
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.ddns.net,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:资源管理
模块英文名:ResourceMan
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
    ///		wucFileResource 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucFileResource : System.Web.UI.UserControl
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
        /// 文件目录名
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FileDirName
        {
            get
            {
                return txtFileDirName.Text.Trim();
            }
            set
            {
                txtFileDirName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文件名
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
        /// 扩展名
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string Extension
        {
            get
            {
                return txtExtension.Text.Trim();
            }
            set
            {
                txtExtension.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文件长度
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public long FileLength
        {
            get
            {
                return long.Parse(txtFileLength.Text.Trim());
            }
            set
            {
                txtFileLength.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文件类型
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FileType
        {
            get
            {
                return txtFileType.Text.Trim();
            }
            set
            {
                txtFileType.Text = value.ToString();
            }
        }

        /// <summary>
        /// 建立时间
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string CreationTime
        {
            get
            {
                return txtCreationTime.Text.Trim();
            }
            set
            {
                txtCreationTime.Text = value.ToString();
            }
        }

        /// <summary>
        /// 修改日期
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string LastWriteTime
        {
            get
            {
                return txtLastWriteTime.Text.Trim();
            }
            set
            {
                txtLastWriteTime.Text = value.ToString();
            }
        }

        /// <summary>
        /// CheckDateTime
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string CheckDateTime
        {
            get
            {
                return txtCheckDateTime.Text.Trim();
            }
            set
            {
                txtCheckDateTime.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否在用
        /// (AGC.PureClassEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
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
        /// 是否存在文件
        /// (AGC.PureClassEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public bool IsExistFile
        {
            get
            {
                return chkIsExistFile.Checked;
            }
            set
            {
                chkIsExistFile.Checked = value;
            }
        }

        /// <summary>
        /// 工程ID
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
        /// CM工程Id
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
        /// 服务器
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string IpAddress
        {
            get
            {
                return txtIpAddress.Text.Trim();
            }
            set
            {
                txtIpAddress.Text = value.ToString();
            }
        }

        /// <summary>
        /// FTP资源流水号
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string IdFtpResource
        {
            get
            {
                return txtIdFtpResource.Text.Trim();
            }
            set
            {
                txtIdFtpResource.Text = value.ToString();
            }
        }

        /// <summary>
        /// 说明
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
            txtFileDirName.Text = "";
            txtFileName.Text = "";
            txtExtension.Text = "";
            txtFileLength.Text = "0";
            txtFileType.Text = "";
            txtCreationTime.Text = "";
            txtLastWriteTime.Text = "";
            txtCheckDateTime.Text = "";
            chkInUse.Checked = false;
            chkIsExistFile.Checked = false;
            ddlPrjId.SelectedIndex = 0;
            ddlCmPrjId.SelectedIndex = 0;
            txtIpAddress.Text = "";
            txtIdFtpResource.Text = "";
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
            ComValid_FileLength.Validate();
            if (!ComValid_FileLength.IsValid) return false;
            if (clsString.IsNumeric(txtFileLength.Text) == false)
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
            txtFileDirName.Text = "";
            txtFileName.Text = "";
            txtExtension.Text = "";
            txtFileLength.Text = "0";
            txtFileType.Text = "";
            txtCreationTime.Text = "";
            txtLastWriteTime.Text = "";
            txtCheckDateTime.Text = "";
            chkInUse.Checked = false;
            chkIsExistFile.Checked = false;
            ddlPrjId.SelectedIndex = 0;
            ddlCmPrjId.SelectedIndex = 0;
            txtIpAddress.Text = "";
            txtIdFtpResource.Text = "";
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[Projects]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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
        /// 为下拉框获取数据,从表:[CMProject]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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
        /// 设置绑定下拉框，针对字段:[PrjId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_PrjId()
        {
            clsProjectsBL.BindDdl_PrjId(ddlPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[CmPrjId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_CmPrjId(string strPrjId)
        {
            clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjId, strPrjId);
        }

    }
}