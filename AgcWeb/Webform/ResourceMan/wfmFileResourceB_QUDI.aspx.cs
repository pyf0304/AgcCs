
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmFileResourceB_QUDI
界面名:wfmFileResourceB_QUDI(00050277)
生成代码版本:2020.05.09.1
生成日期:2020/05/12 00:20:07
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.ddns.net,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:资源管理
模块英文名:ResourceMan
框架-层名:Web界面后台(WebViewControlCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;



using AGC.Entity;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC;
using AGC.FunClass;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFileResourceB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmFileResourceB_QUDI : System.Web.UI.Page
    {


        #region 页面启动函数

        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Page_Load)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {
                //1、初始化，初始化一些导出Excel要用的变量
                vsViewName = "文件资源-维护";
                vsTabName = string.Format("{0}", clsvFileResourceEN._CurrTabName);
                //2、用户权限管理:处理当前用户在当前界面的权限相关操作
                AccessUserPotence();
                //3、绑定查询区的下拉框
                BindDdl4QueryRegion();

                //4、设置列表区的排序字段
                wucvFileResource4Gv1.SetSortBy(string.Format("{0} Asc", convFileResource.FileResourceID));
                //5、显示无条件的表内容在GridView中
                BindGv_vFileResource();
                //7、设置逻辑层的公共函数，包含：缓存刷新函数
                //clsFileResourceBL.objCommFun4BL = new clsCommFun4BL4FileResource();
            }
        }


        /// <summary>
        /// 函数功能:为查询区控件绑定下拉框。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindDropDownLst4QueryRegion)
        /// </summary>
        protected void BindDdl4QueryRegion()
        {

            try
            {
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjIdq, clsPubVar.CurrSelPrjId);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsGeneCodeq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsCanDelq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsCurrPrjq);

                clsPrjTabBLEx.BindDdl_TabIdExCacheNoPureClass(ddlTabIdq, clsPubVar.CurrSelPrjId);
                clsTabStateBL.BindDdl_TabStateId(ddlTabStateIdq);
                clsFuncModule_AgcBL.BindDdl_FuncModuleAgcId(ddlFuncModuleAgcIdq, clsPubVar.CurrSelPrjId);
                clsFileResourceBLEx.BindDdlIn_ExtensionEx(ddlExtensionq, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000044)绑定查询区下拉框出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }


        #endregion 页面启动函数

        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnQuery_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            wucvFileResource4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vFileResource();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vFileResource()
        {
            //操作步骤:(共5步)
            //	1、设置Gv控件的某些列不可见;
            //	2、组合界面条件串；
            //	3、调用控件中的绑定GridView函数;

            try
            {
                //	1、设置Gv控件的某些列不可见；
                //wucvFileResource4Gv1.SetGvVisibility(convFileResource.UpdDate, false);
                //wucvFileResource4Gv1.SetGvVisibility(convFileResource.UpdUser, false);
                //	2、组合界面条件串；
                string strWhereCond = CombinevFileResourceCondition();
                if (strWhereCond == " 1=1 ") return;
                wucvFileResource4Gv1.vsUserPath = vsUserPath;
                //	3、调用控件中的绑定GridView函数；
                wucvFileResource4Gv1.BindGv_FileResource(strWhereCond);
                if (ddlCmPrjIdq.SelectedIndex>0)
                {
                    wucvFileResource4Gv1.SetGvVisibility(convFileResource.CmPrjName, false);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }


        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinevFileResourceCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            //List<string> arrInclude = new List<string>() { ".cs", ".cshtml", ".txt", ".ttf", ".ts", ".rar", ".png", ".map", ".log", ".js", ".html", ".gif", ".css" };

            //string strWhereCond = string.Format(" 1 = 1 and {0} in ({1}) ", convFileResource.Extension, clsArray.GetSqlInStrByArray(arrInclude, true));
            string strWhereCond = string.Format(" 1 = 1 ");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
            try
            {
                if (chkUnUpdateFile.Checked == true)
                {
                    strWhereCond += string.Format(" And {0} = {1}", convFileResource.CreationTime, convFileResource.LastWriteTime);
                }
                if (this.txtFileDirNameq.Text.Trim() != "")
                {
                    objvFileResourceEN.FileDirName = this.txtFileDirNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFileResource.FileDirName, this.txtFileDirNameq.Text.Trim());
                }
                if (this.txtFileNameq.Text.Trim() != "")
                {
                    objvFileResourceEN.FileName = this.txtFileNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFileResource.FileName, this.txtFileNameq.Text.Trim());
                }
                if (this.ddlExtensionq.SelectedIndex>0)
                {
                    objvFileResourceEN.Extension = this.ddlExtensionq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.Extension, this.ddlExtensionq.SelectedValue);
                }
                if (this.ddlCmPrjIdq.SelectedValue != "" && this.ddlCmPrjIdq.SelectedValue != "0")
                {
                    objvFileResourceEN.CmPrjId = this.ddlCmPrjIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.CmPrjId, this.ddlCmPrjIdq.SelectedValue);
                }
                if (this.ddlIsGeneCodeq.SelectedIndex == 1)
                {
                    objvFileResourceEN.IsGeneCode = true;
                    strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsGeneCode);
                }
                else if (this.ddlIsGeneCodeq.SelectedIndex == 2)
                {
                    objvFileResourceEN.IsGeneCode = false;
                    strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsGeneCode);
                }
                if (this.ddlIsCanDelq.SelectedIndex == 1)
                {
                    objvFileResourceEN.IsCanDel = true;
                    strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsCanDel);
                }
                else if (this.ddlIsCanDelq.SelectedIndex == 2)
                {
                    objvFileResourceEN.IsCanDel = false;
                    strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsCanDel);
                }

                if (this.ddlIsCurrPrjq.SelectedIndex == 1)
                {
                    objvFileResourceEN.IsBelongsCurrCMPrj = true;
                    strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsBelongsCurrCMPrj);
                }
                else if (this.ddlIsCurrPrjq.SelectedIndex == 2)
                {
                    objvFileResourceEN.IsBelongsCurrCMPrj = false;
                    strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsBelongsCurrCMPrj);
                }


                if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
                {
                    objvFileResourceEN.TabId = this.ddlTabIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.TabId, this.ddlTabIdq.SelectedValue);
                }
                if (this.ddlTabStateIdq.SelectedValue != "" && this.ddlTabStateIdq.SelectedValue != "0")
                {
                    objvFileResourceEN.TabStateId = this.ddlTabStateIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.TabStateId, this.ddlTabStateIdq.SelectedValue);
                }
                if (this.ddlFuncModuleAgcIdq.SelectedValue != "" && this.ddlFuncModuleAgcIdq.SelectedValue != "0")
                {
                    objvFileResourceEN.FuncModuleAgcId = this.ddlFuncModuleAgcIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.FuncModuleAgcId, this.ddlFuncModuleAgcIdq.SelectedValue);
                }
                objvFileResourceEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineFileResourceCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CombineConditionObj)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected clsvFileResourceEN CombinevFileResourceConditionObj()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
            try
            {
                if (this.txtFileDirNameq.Text.Trim() != "")
                {
                    objvFileResourceEN.SetFileDirName(string.Format("{0}", this.txtFileDirNameq.Text.Trim()), "like");
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFileResource.FileDirName, this.txtFileDirNameq.Text.Trim());
                }
                if (this.txtFileNameq.Text.Trim() != "")
                {
                    objvFileResourceEN.SetFileName(string.Format("{0}", this.txtFileNameq.Text.Trim()), "like");
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFileResource.FileName, this.txtFileNameq.Text.Trim());
                }
                if (this.ddlExtensionq.SelectedIndex>0)
                {
                    objvFileResourceEN.SetExtension(string.Format("{0}", this.ddlExtensionq.SelectedValue), "like");
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFileResource.Extension, this.ddlExtensionq.SelectedValue);
                }
                if (this.ddlCmPrjIdq.SelectedValue != "" && this.ddlCmPrjIdq.SelectedValue != "0")
                {
                    objvFileResourceEN.SetCmPrjId(this.ddlCmPrjIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.CmPrjId, this.ddlCmPrjIdq.SelectedValue);
                }
                if (this.ddlIsGeneCodeq.SelectedIndex == 1)
                {
                    objvFileResourceEN.IsGeneCode = true;
                    strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsGeneCode);
                }
                else if (this.ddlIsGeneCodeq.SelectedIndex == 2)
                {
                    objvFileResourceEN.IsGeneCode = false;
                    strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsGeneCode);
                }
                if (this.ddlIsCanDelq.SelectedIndex == 1)
                {
                    objvFileResourceEN.IsCanDel = true;
                    strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsCanDel);
                }
                else if (this.ddlIsCanDelq.SelectedIndex == 2)
                {
                    objvFileResourceEN.IsCanDel = false;
                    strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsCanDel);
                }
                if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
                {
                    objvFileResourceEN.SetTabId(this.ddlTabIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.TabId, this.ddlTabIdq.SelectedValue);
                }
                if (this.ddlTabStateIdq.SelectedValue != "" && this.ddlTabStateIdq.SelectedValue != "0")
                {
                    objvFileResourceEN.SetTabStateId(this.ddlTabStateIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.TabStateId, this.ddlTabStateIdq.SelectedValue);
                }
                if (this.ddlFuncModuleAgcIdq.SelectedValue != "" && this.ddlFuncModuleAgcIdq.SelectedValue != "0")
                {
                    objvFileResourceEN.SetFuncModuleAgcId(this.ddlFuncModuleAgcIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convFileResource.FuncModuleAgcId, this.ddlFuncModuleAgcIdq.SelectedValue);
                }
                objvFileResourceEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000086)在组合查询条件(CombineFileResourceConditionObj)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return objvFileResourceEN;
        }

        /// <summary>
        /// 专门用于记录当前界面是否绑定编辑区的下拉框
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_vsIsBindDdl4Edit)
        /// </summary>
        public bool vsIsBindDdl4Edit
        {
            get
            {
                string strIsBindDdl4Edit;
                strIsBindDdl4Edit = (string)ViewState["IsBindDdl4Edit"];
                if (strIsBindDdl4Edit == null)
                {
                    return false;
                }
                return bool.Parse(strIsBindDdl4Edit);
            }
            set
            {
                string strIsBindDdl4Edit = value.ToString();
                ViewState.Add("IsBindDdl4Edit", strIsBindDdl4Edit);
            }
        }


        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_vsPageSize)
        /// </summary>
        public int vsPageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                    return 15;
                }
                return int.Parse(strPageSize);
            }
            set
            {
                string strPageSize = value.ToString();
                ViewState.Add("PageSize", strPageSize);
            }
        }


        /// <summary>
        /// 函数功能:为编辑区控件绑定下拉框。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindDropDownLst4EditRegion)
        /// </summary>
        protected void BindDdl4EditRegion()
        {

            if (vsIsBindDdl4Edit == true) return;
            try
            {
                wucFileResource1.SetDdl_PrjId();
                wucFileResource1.SetDdl_CmPrjId(clsPubVar.CurrSelPrjId);
                vsIsBindDdl4Edit = true;
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000043)绑定编辑区下拉框出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }


        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        /// <summary>
        ///添加新记录的事件过程 
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnAddNewRecord_Click)
        /// </summary>
        protected void btnAddNewRecord_Click(object sender, System.EventArgs e)
        {
            AddFileResourceRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void AddFileResourceRecord()
        {
            //1、绑定编辑区的下拉框
            BindDdl4EditRegion();
            //2、设置关键字字段可以编辑
            //3、改变相关编辑按钮的状态
            btnOKUpd.Text = "确认添加";
            btnCancelFileResourceEdit.Text = "取消添加";
            //4、设置添加时编辑区域控件的初值
            //wucFileResource1.FileResourceID = clsFileResourceBL.GetMaxStrId_S();
            DispEditFileResourceRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddFileResourceRecordSave()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsFileResourceEN objFileResourceEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFileResource1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFileResourceEN objFileResourceEN;	//定义对象
            objFileResourceEN = new clsFileResourceEN();    //初始化新对象

            try
            {
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataToFileResourceClass(objFileResourceEN);      //把界面的值传到
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI000034)为对象赋值不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            try
            {
                //5、使用扩展添加方法，到逻辑层去添加
                objFileResourceEN.AddRecordEx();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI000005)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_vFileResource();
            DispFileResourceListRegion();
            wucFileResource1.Clear();       //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFileResourceEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngFileResourceID = wucvFileResource4Gv1.GetFirstCheckedKeyFromGv();
            if (lngFileResourceID == 0) return;
            UpdateFileResourceRecord(lngFileResourceID);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdateFileResourceRecord(long lngFileResourceID)
        {
            //操作步骤:(总共2步)
            //1、绑定编辑区的下拉框
            //2、显示该关键字记录的内容在界面上；
            //3、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、绑定编辑区的下拉框
            BindDdl4EditRegion();
            //2、显示该关键字记录的内容在界面上；
            ShowData(lngFileResourceID);
            //3、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelFileResourceEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditFileResourceRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ShowData)
        /// </summary>
        /// <param name = "lngFileResourceID">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(long lngFileResourceID)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngFileResourceID == 0) return;     //如果关键字为空就返回退出
                                                    //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsFileResourceBL.IsExist(lngFileResourceID) == false)      //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[FileResource]中,关键字为:[lngFileResourceID]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsFileResourceEN objFileResourceEN = new clsFileResourceEN(lngFileResourceID);
            //4、获取类对象的所有属性；
            try
            {
                clsFileResourceBL.GetFileResource(ref objFileResourceEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objFileResourceEN", objFileResourceEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromFileResourceClass(objFileResourceEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjFileResourceEN">表实体类对象</param>
        protected void GetDataFromFileResourceClass(clsFileResourceEN pobjFileResourceEN)
        {
            wucFileResource1.FileDirName = pobjFileResourceEN.FileDirName;// 文件目录名
            wucFileResource1.FileName = pobjFileResourceEN.FileName;// 文件名
            wucFileResource1.Extension = pobjFileResourceEN.Extension;// 扩展名
            wucFileResource1.FileLength = pobjFileResourceEN.FileLength ?? 0;// 文件长度
            wucFileResource1.FileType = pobjFileResourceEN.FileType;// 文件类型
            wucFileResource1.CreationTime = pobjFileResourceEN.CreationTime;// 建立时间
            wucFileResource1.LastWriteTime = pobjFileResourceEN.LastWriteTime;// 修改日期
            wucFileResource1.CheckDateTime = pobjFileResourceEN.CheckDateTime;// CheckDateTime
            wucFileResource1.InUse = pobjFileResourceEN.InUse;// 是否在用
            wucFileResource1.IsExistFile = pobjFileResourceEN.IsExistFile;// 是否存在文件
            wucFileResource1.PrjId = pobjFileResourceEN.PrjId;// 工程ID
            wucFileResource1.CmPrjId = pobjFileResourceEN.CmPrjId;// CM工程Id
            wucFileResource1.IpAddress = pobjFileResourceEN.IpAddress;// 服务器
            wucFileResource1.IdFtpResource = pobjFileResourceEN.IdFtpResource;// FTP资源流水号
            wucFileResource1.Memo = pobjFileResourceEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFileResource4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngFileResourceID = long.Parse(e.KeyId);
            UpdateFileResourceRecord(lngFileResourceID);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objFileResourceEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateFileResourceRecordSave(clsFileResourceEN objFileResourceEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucFileResource1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            try
            {
                //2、把值从界面层传到逻辑层或数据实体层
                PutDataToFileResourceClass(objFileResourceEN);      //把界面的值传到
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI000035)为对象赋值不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            try
            {
                //3、使用扩展修改方法，到扩展逻辑层去修改
                objFileResourceEN.UpdateRecordEx();
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_vFileResource();
            DispFileResourceListRegion();
            wucFileResource1.Clear();//添空控件中的内容
                                     //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFileResourceEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_FileResource{0}'", objFileResourceEN.FileResourceID.ToString().Trim()), true);
            return true;
        }

        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnOkUpd_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsFileResourceEN objFileResourceEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddFileResourceRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    if (btnOKUpd.CommandArgument == "AddWithMaxId")
                    {
                        //AddFileResourceRecordWithMaxIdSave();
                    }
                    else
                    {
                        AddFileResourceRecordSave();
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objFileResourceEN = (clsFileResourceEN)Session["objFileResourceEN"];
                    UpdateFileResourceRecordSave(objFileResourceEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjFileResourceEN">数据传输的目的类对象</param>
        protected void PutDataToFileResourceClass(clsFileResourceEN pobjFileResourceEN)
        {
            pobjFileResourceEN.SetFileDirName(wucFileResource1.FileDirName)// 文件目录名
            .SetFileName(wucFileResource1.FileName)// 文件名
            .SetExtension(wucFileResource1.Extension)// 扩展名
            .SetFileLength(wucFileResource1.FileLength)// 文件长度
            .SetFileType(wucFileResource1.FileType)// 文件类型
            .SetCreationTime(wucFileResource1.CreationTime)// 建立时间
            .SetLastWriteTime(wucFileResource1.LastWriteTime)// 修改日期
            .SetCheckDateTime(wucFileResource1.CheckDateTime)// CheckDateTime
            .SetInUse(wucFileResource1.InUse)// 是否在用
            .SetIsExistFile(wucFileResource1.IsExistFile)// 是否存在文件
            .SetPrjId(wucFileResource1.PrjId)// 工程ID
            .SetCmPrjId(wucFileResource1.CmPrjId)// CM工程Id
            .SetIpAddress(wucFileResource1.IpAddress)// 服务器
            .SetIdFtpResource(wucFileResource1.IdFtpResource)// FTP资源流水号
            .SetMemo(wucFileResource1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelFileResourceEdit_Click(object sender, EventArgs e)
        {
            DispFileResourceListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<long> lstFileResourceID = wucvFileResource4Gv1.GetAllCheckedKeysFromGv();
            if (lstFileResourceID == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngFileResourceID in lstFileResourceID)
                {
                    clsFileResourceBL.DelRecord(lngFileResourceID);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vFileResource();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFileResource4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngFileResourceID = long.Parse(e.KeyId);
            DeleteFileResourceRecord(lngFileResourceID);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "lngFileResourceID">给定关键字</param>
        protected void DeleteFileResourceRecord(long lngFileResourceID)
        {
            try
            {
                clsFileResourceBL.DelRecord(lngFileResourceID);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vFileResource();
        }

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnExportExcel_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vFileResource]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevFileResourceCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FileResource信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convFileResource.FileDirName); arrCnName.Add("文件目录名");
            arrColName.Add(convFileResource.FileName); arrCnName.Add("文件名");
            arrColName.Add(convFileResource.Extension); arrCnName.Add("扩展名");
            arrColName.Add(convFileResource.FileLength); arrCnName.Add("文件长度");
            arrColName.Add(convFileResource.FileType); arrCnName.Add("文件类型");
            arrColName.Add(convFileResource.CreationTime); arrCnName.Add("建立时间");
            arrColName.Add(convFileResource.LastWriteTime); arrCnName.Add("最后修改日期");
            arrColName.Add(convFileResource.InUse); arrCnName.Add("是否在用");
            arrColName.Add(convFileResource.IsExistFile); arrCnName.Add("是否存在文件");
            arrColName.Add(convFileResource.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convFileResource.CmPrjName); arrCnName.Add("CM工程名");
            arrColName.Add(convFileResource.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convFileResource.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convFileResource.Memo); arrCnName.Add("说明");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvFileResourceBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取数据出错,请联系管理员！错误:{0}.({1})",
                objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                try
                {
                    clsSysParaEN.objErrorLog.WriteDebugLog(objException.Message);
                    GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                    //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
                }
                catch (Exception objException2)
                {
                    string strMsg = string.Format("导出Excel出错,请联系管理员！错误:{0}.({1})",
                    objException2.Message, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }

        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispListRegion)
        /// </summary>
        private void DispFileResourceListRegion()
        {
            divList.Visible = true;
            tabEditFileResourceRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditFileResourceRegion()
        {
            divList.Visible = false;
            tabEditFileResourceRegion.Visible = true;
        }

        /// <summary>
        /// Session属性:登录的用户ID,用于检查用户权限
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefProperty_seUserId)
        /// </summary>
        protected string seUserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }
        ///protected clsUsersEN objUser
        ///{
        ///get
        ///{
        ///clsUsersEN pobjUser;
        ///pobjUser = (clsUsersEN)Session["objUser"];
        ///if (pobjUser == null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsUsersEN pobjUser = value;
        ///Session.Add("objUser", pobjUser);
        ///}
        ///}


        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefProperty_vsViewName)
        /// </summary>
        protected string vsViewName
        {
            get
            {
                string sViewName;
                sViewName = (string)ViewState["ViewName"];
                if (sViewName == null)
                {
                    sViewName = "";
                }
                return sViewName;
            }
            set
            {
                string sViewName = value;
                ViewState.Add("ViewName", sViewName);
            }
        }


        /// <summary>
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefProperty_vsTabName)
        /// </summary>
        protected string vsTabName
        {
            get
            {
                string sTabName;
                sTabName = (string)ViewState["TabName"];
                if (sTabName == null)
                {
                    sTabName = "";
                }
                return sTabName;
            }
            set
            {
                string sTabName = value;
                ViewState.Add("TabName", sTabName);
            }
        }

        /// <summary>
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefProperty_vsTabName)
        /// </summary>
        protected string vsUserPath
        {
            get
            {
                string sUserPath;
                sUserPath = (string)ViewState["UserPath"];
                if (sUserPath == null)
                {
                    sUserPath = "";
                }
                return sUserPath;
            }
            set
            {
                string sUserPath = value;
                ViewState.Add("UserPath", sUserPath);
            }
        }

        /// <summary>
        /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。
        /// 姓名:
        /// 日期:
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefProperty_qsUserId)
        /// </summary>
        private string qsUserId
        {
            get
            {
                string strUserId = Request.QueryString["UserId"] ?? "".ToString();
                if ((strUserId != null) && (strUserId != ""))
                {
                    return strUserId;
                }
                else
                {
                    return "";
                }
            }
        }


        /// <summary>
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefProperty_vsPotenceLevel)
        /// </summary>
        protected string vsPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        /// <summary>
        /// 与权限相关的界面编号
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefConst_ViewId4Potence)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号


        /// <summary>
        /// 用户权限管理:处理当前用户在当前界面的权限相关操作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AccessUserPotence)
        /// </summary>
        protected bool AccessUserPotence()
        {
            //生成权限有关判断权限的代码
            //根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
            switch (vsPotenceLevel)
            {
                case "0":
                    Response.Redirect("../error.aspx");
                    break;
                case "1":
                    Response.Redirect("../error.aspx");
                    break;
                case "2":
                    Response.Redirect("../error.aspx");
                    break;
                case "3":
                    Response.Redirect("../error.aspx");
                    break;
                case "4":
                    Response.Redirect("../error.aspx");
                    break;
                case "9":
                    break;
                default:
                    Response.Redirect("../error.aspx");
                    break;
            }
            return true;
        }


        #region 备用函数

        #endregion 备用函数

        protected void btnAnalysisFileByGenerateCode_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择代码项目！");
                ddlCmPrjIdq.Focus();
                return;
            }
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            List<long> lstFileResourceID = wucvFileResource4Gv1.GetAllCheckedKeysFromGv();
            //if (lstFileResourceID == null) return;
            try
            {
                clsFileResourceBLEx.AnalysisFileByGenerateCode(strCmPrjId, lstFileResourceID);
                BindGv_vFileResource();
            }
            catch(Exception objException)
            {
                string strMsg = string.Format("出现错误:{0}. In ({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);

            }

        }

        protected void btnDelFileFromCmPrjId_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择代码项目！");
                ddlCmPrjIdq.Focus();
                return;
            }
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;

            List<long> lstFileResourceID = wucvFileResource4Gv1.GetAllCheckedKeysFromGv();
            if (lstFileResourceID == null) return;

            lblMsgList.Text = "";
            try
            {
                var arrTabIdSet = new List<string>();
                foreach (long lngFileResourceID in lstFileResourceID)
                {
                    var obj = clsFileResourceBL.GetObjByFileResourceIDCache(lngFileResourceID);
                    if (string.IsNullOrEmpty(obj.TabId) == true) continue;
                    if (arrTabIdSet.Contains(obj.TabId) == false) arrTabIdSet.Add(obj.TabId);
                }
                arrTabIdSet.ForEach(x=> {
                    string strCondition_Del = new clsCMProjectPrjTabEN()
                        .SetTabId(x, "=")
                        .SetCmPrjId(strCmPrjId, "=")
                        .GetCombineCondition();
                    clsCMProjectPrjTabBL.DelCMProjectPrjTabsByCond(strCondition_Del);
                });

            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vFileResource();

        }
        /// <summary>
        ///设置字段值
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnSetFieldValue_Click)
        /// </summary>
        protected void btnSetCanDelete_Click(object sender, System.EventArgs e)
        {
            List<long> lstFileResourceID = wucvFileResource4Gv1.GetAllCheckedKeysFromGv();
            if (lstFileResourceID == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngFileResourceID in lstFileResourceID)
                {
                    K_FileResourceID_FileResource objKey = new K_FileResourceID_FileResource(lngFileResourceID);
                    clsFileResourceEN objFileResource = objKey.GetObj();
                    objFileResource.SetIsCanDel(true);
                    objFileResource.Update();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000091)设置可删除不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vFileResource();
        }

        protected void btnSetCanNotDelete_Click(object sender, System.EventArgs e)
        {
            List<long> lstFileResourceID = wucvFileResource4Gv1.GetAllCheckedKeysFromGv();
            if (lstFileResourceID == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngFileResourceID in lstFileResourceID)
                {
                    K_FileResourceID_FileResource objKey = new K_FileResourceID_FileResource(lngFileResourceID);
                    clsFileResourceEN objFileResource = objKey.GetObj();
                    objFileResource.SetIsCanDel(false);
                    objFileResource.Update();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000091)设置可删除不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vFileResource();
        }
        private void GetUserPath()
        {
            lblUserPath.Text = "";
            if (ddlCmPrjIdq.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue.ToString();
            clsCMProjectEN objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            string strCondtion = new clsUserCodePrjMainPathEN()
                  .SetUserId(clsCommonSession.UserId, "=")
             .SetApplicationTypeId(objCMProject.ApplicationTypeId, "=")
             .SetPrjId(clsPubVar.CurrSelPrjId, "=")
.SetCmPrjId(strCmPrjId, "=")

             .GetCombineCondition();
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsUserCodePrjMainPathBL.GetFirstObj_S(strCondtion);
            if (objUserCodePrjMainPath == null)
            {
                clsApplicationTypeEN objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(objCMProject.ApplicationTypeId);
                lblUserPath.Text = string.Format("当前CmPrjId对应的主项目为：{0}, 没有相关的用户[{1}]路径，请检查！", objApp.ApplicationTypeName, clsSysParaEN_Local.strUserId);
                clsCommonJsFunc.Alert(this,  lblUserPath.Text);
                return;
            }
            var strMachineName = clsUserCodePrjMainPath_MachineNameBLEx.GetRelaMachineName(objUserCodePrjMainPath.UserCodePrjMainPathId);

            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathBLEx.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName);

            lblUserPath.Text = objUserCodePrjMainPathEx.CodePath;
            vsUserPath = objUserCodePrjMainPathEx.CodePath;
            BindGv_vFileResource();
        }

        protected void ddlCmPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserPath();
        }
    }
}