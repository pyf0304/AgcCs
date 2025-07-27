
/*-- -- -- -- -- -- -- -- -- -- --
类名:PrjTab_QUDI
界面名:PrjTab_QUDI(00050057)
生成代码版本:2020.08.04.1
生成日期:2020/08/06 02:36:28
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.ddns.net,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:字段、表维护
模块英文名:Table_Field
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
    /// PrjTab_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class PrjTab_QUDI : System.Web.UI.Page
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
                vsPrjId_Cache = "0005";
                //1、初始化，初始化一些导出Excel要用的变量
                vsViewName = "工程表-维护";
                vsTabName = string.Format("{0}", clsPrjTabEN._CurrTabName);
                //2、用户权限管理:处理当前用户在当前界面的权限相关操作
                AccessUserPotence();
                //3、绑定查询区的下拉框
                BindDdl4QueryRegion();

                clsCacheModeBL.BindDdl_CacheModeId(ddlCacheModeId_SetFldValue, true);
                //4、设置列表区的排序字段
                PrjTab4Gv1.SetSortBy(string.Format("{0} Asc", conPrjTab.TabId));
                //5、显示无条件的表内容在GridView中
                BindGv_PrjTabByFunc();
                //7、设置逻辑层的公共函数，包含：缓存刷新函数
                //clsPrjTabBL.objCommFun4BL = new clsCommFun4BL4PrjTab();
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
                clsSQLDSTypeBL.BindDdl_SqlDsTypeId(ddlSqlDsTypeIdq);
                clsTabStateBL.BindDdl_TabStateId(ddlTabStateIdq);

                var strPrjId = "";  //相关缓存字段
                clsFuncModule_AgcBL.BindDdl_FuncModuleAgcId(ddlFuncModuleAgcIdq, strPrjId);
                clsTabTypeBL.BindDdl_TabTypeId(ddlTabTypeIdq);
                clsTabMainTypeBL.BindDdl_TabMainTypeId(ddlTabMainTypeIdq);
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
            PrjTab4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_PrjTabByFunc();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridViewByFunc)
        /// </summary>
        protected void BindGv_PrjTabByFunc()
        {
            //操作步骤:(共5步)
            //	1、设置Gv控件的某些列不可见;
            //	2、组合界面条件串；
            //	3、调用控件中的绑定GridView函数;

            string strPrjId = vsPrjId_Cache;
            try
            {
                //	1、设置Gv控件的某些列不可见；
                //PrjTab4Gv1.SetGvVisibility(conPrjTab.UpdDate, false);
                //PrjTab4Gv1.SetGvVisibility(conPrjTab.UpdUser, false);
                //	2、组合界面条件串；
                clsPrjTabEN objPrjTab_Cond = CombinePrjTabConditionObj();
                objPrjTab_Cond.SetPrjId(strPrjId, "=");
                //	3、调用控件中的绑定GridView函数；
                PrjTab4Gv1.BindGv_PrjTabByFunc(objPrjTab_Cond);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000087)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }


        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinePrjTabCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
            try
            {
                if (this.txtTabNameq.Text.Trim() != "")
                {
                    objPrjTabEN.TabName = this.txtTabNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conPrjTab.TabName, this.txtTabNameq.Text.Trim());
                }
                if (this.txtTabIdq.Text.Trim() != "")
                {
                    objPrjTabEN.TabId = this.txtTabIdq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conPrjTab.TabId, this.txtTabIdq.Text.Trim());
                }
                if (this.ddlSqlDsTypeIdq.SelectedValue != "" && this.ddlSqlDsTypeIdq.SelectedValue != "0")
                {
                    objPrjTabEN.SqlDsTypeId = this.ddlSqlDsTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.SqlDsTypeId, this.ddlSqlDsTypeIdq.SelectedValue);
                }
                if (this.ddlTabStateIdq.SelectedValue != "" && this.ddlTabStateIdq.SelectedValue != "0")
                {
                    objPrjTabEN.TabStateId = this.ddlTabStateIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.TabStateId, this.ddlTabStateIdq.SelectedValue);
                }
                if (this.ddlFuncModuleAgcIdq.SelectedValue != "" && this.ddlFuncModuleAgcIdq.SelectedValue != "0")
                {
                    objPrjTabEN.FuncModuleAgcId = this.ddlFuncModuleAgcIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.FuncModuleAgcId, this.ddlFuncModuleAgcIdq.SelectedValue);
                }
                if (this.ddlTabTypeIdq.SelectedValue != "" && this.ddlTabTypeIdq.SelectedValue != "0")
                {
                    objPrjTabEN.TabTypeId = this.ddlTabTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.TabTypeId, this.ddlTabTypeIdq.SelectedValue);
                }
                if (this.ddlTabMainTypeIdq.SelectedValue != "" && this.ddlTabMainTypeIdq.SelectedValue != "0")
                {
                    objPrjTabEN.TabMainTypeId = this.ddlTabMainTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.TabMainTypeId, this.ddlTabMainTypeIdq.SelectedValue);
                }
                objPrjTabEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombinePrjTabCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CombineConditionObj)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected clsPrjTabEN CombinePrjTabConditionObj()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
            try
            {
                if (this.txtTabNameq.Text.Trim() != "")
                {
                    objPrjTabEN.SetTabName(string.Format("{0}", this.txtTabNameq.Text.Trim()), "like");
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conPrjTab.TabName, this.txtTabNameq.Text.Trim());
                }
                if (this.txtTabIdq.Text.Trim() != "")
                {
                    objPrjTabEN.SetTabId(string.Format("{0}", this.txtTabIdq.Text.Trim()), "like");
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conPrjTab.TabId, this.txtTabIdq.Text.Trim());
                }
                if (this.ddlSqlDsTypeIdq.SelectedValue != "" && this.ddlSqlDsTypeIdq.SelectedValue != "0")
                {
                    objPrjTabEN.SetSqlDsTypeId(this.ddlSqlDsTypeIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.SqlDsTypeId, this.ddlSqlDsTypeIdq.SelectedValue);
                }
                if (this.ddlTabStateIdq.SelectedValue != "" && this.ddlTabStateIdq.SelectedValue != "0")
                {
                    objPrjTabEN.SetTabStateId(this.ddlTabStateIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.TabStateId, this.ddlTabStateIdq.SelectedValue);
                }
                if (this.ddlFuncModuleAgcIdq.SelectedValue != "" && this.ddlFuncModuleAgcIdq.SelectedValue != "0")
                {
                    objPrjTabEN.SetFuncModuleAgcId(this.ddlFuncModuleAgcIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.FuncModuleAgcId, this.ddlFuncModuleAgcIdq.SelectedValue);
                }
                if (this.ddlTabTypeIdq.SelectedValue != "" && this.ddlTabTypeIdq.SelectedValue != "0")
                {
                    objPrjTabEN.SetTabTypeId(this.ddlTabTypeIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.TabTypeId, this.ddlTabTypeIdq.SelectedValue);
                }
                if (this.ddlTabMainTypeIdq.SelectedValue != "" && this.ddlTabMainTypeIdq.SelectedValue != "0")
                {
                    objPrjTabEN.SetTabMainTypeId(this.ddlTabMainTypeIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", conPrjTab.TabMainTypeId, this.ddlTabMainTypeIdq.SelectedValue);
                }
                objPrjTabEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000086)在组合查询条件(CombinePrjTabConditionObj)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return objPrjTabEN;
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
                PrjTab_Edit1.SetDdl_SqlDsTypeId();
                PrjTab_Edit1.SetDdl_TabStateId();
                var strPrjId = "";  //相关缓存字段

                PrjTab_Edit1.SetDdl_FuncModuleAgcId(strPrjId);
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
            AddPrjTabRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void AddPrjTabRecord()
        {
            //1、绑定编辑区的下拉框
            BindDdl4EditRegion();
            //2、设置关键字字段可以编辑
            PrjTab_Edit1.SetKeyReadOnly(false);
            //3、改变相关编辑按钮的状态
            btnOKUpd.Text = "确认添加";
            btnCancelPrjTabEdit.Text = "取消添加";
            //4、设置添加时编辑区域控件的初值
            //PrjTab_Edit1.TabId = clsPrjTabBL.GetMaxStrId_S();
            DispEditPrjTabRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddPrjTabRecordSave()
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
            clsPrjTabEN objPrjTabEN;
            //1、检查控件中输入数据类型是否正确
            if (!PrjTab_Edit1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsPrjTabEN objPrjTabEN;	//定义对象
            objPrjTabEN = new clsPrjTabEN(PrjTab_Edit1.TabId);  //初始化新对象

            try
            {
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataToPrjTabClass(objPrjTabEN);      //把界面的值传到
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
                objPrjTabEN.AddRecordEx();
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
            BindGv_PrjTabByFunc();
            DispPrjTabListRegion();
            PrjTab_Edit1.Clear();       //清空控件中内容
                                        ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjTabEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strTabId = PrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            UpdatePrjTabRecord(strTabId);
        }

        /// <summary>
        ///设置字段值
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnSetFieldValue_Click)
        /// </summary>
        protected void btnSetCacheModeId_Click(object sender, System.EventArgs e)
        {
            List<string> lstTabId = PrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            if (ddlCacheModeId_SetFldValue.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请输入缓存方式Id(CacheModeId)!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlCacheModeId_SetFldValue.Focus();
                return;
            }
            string strCacheModeId = ddlCacheModeId_SetFldValue.SelectedValue;
            lblMsgList.Text = "";
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    K_TabId_PrjTab objKey = new K_TabId_PrjTab(strTabId);
                    clsPrjTabEN objPrjTab = objKey.GetObj();
                    objPrjTab.SetCacheModeId(strCacheModeId);
                    objPrjTab.Update();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000089)设置缓存方式Id不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_PrjTabByFunc();
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdatePrjTabRecord(string strTabId)
        {
            //操作步骤:(总共2步)
            //1、绑定编辑区的下拉框
            //2、显示该关键字记录的内容在界面上；
            //3、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、绑定编辑区的下拉框
            BindDdl4EditRegion();
            //2、显示该关键字记录的内容在界面上；
            ShowData(strTabId);
            //3、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            PrjTab_Edit1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelPrjTabEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditPrjTabRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ShowData)
        /// </summary>
        /// <param name = "strTabId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strTabId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strTabId == "") return;     //如果关键字为空就返回退出
                                            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsPrjTabBL.IsExist(strTabId) == false)     //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[PrjTab]中,关键字为:[strTabId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsPrjTabEN objPrjTabEN = new clsPrjTabEN(strTabId);
            //4、获取类对象的所有属性；
            try
            {
                clsPrjTabBL.GetPrjTab(ref objPrjTabEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objPrjTabEN", objPrjTabEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromPrjTabClass(objPrjTabEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjPrjTabEN">表实体类对象</param>
        protected void GetDataFromPrjTabClass(clsPrjTabEN pobjPrjTabEN)
        {
            PrjTab_Edit1.TabId = pobjPrjTabEN.TabId;// 表ID
            PrjTab_Edit1.TabName = pobjPrjTabEN.TabName;// 表名
            PrjTab_Edit1.TabCnName = pobjPrjTabEN.TabCnName;// 表中文名
            PrjTab_Edit1.SqlDsTypeId = pobjPrjTabEN.SqlDsTypeId;// 数据源类型
            PrjTab_Edit1.TabStateId = pobjPrjTabEN.TabStateId;// 表状态ID
            PrjTab_Edit1.TabNameB = pobjPrjTabEN.TabNameB;// 表名_后备
            PrjTab_Edit1.FuncModuleAgcId = pobjPrjTabEN.FuncModuleAgcId;// 功能模块
            PrjTab_Edit1.DataBaseName = pobjPrjTabEN.DataBaseName;// 数据库名
            PrjTab_Edit1.Owner = pobjPrjTabEN.Owner;// 拥有者
            PrjTab_Edit1.Memo = pobjPrjTabEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void PrjTab4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strTabId = e.KeyId;
            UpdatePrjTabRecord(strTabId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objPrjTabEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdatePrjTabRecordSave(clsPrjTabEN objPrjTabEN)
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
            if (!PrjTab_Edit1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            try
            {
                //2、把值从界面层传到逻辑层或数据实体层
                PutDataToPrjTabClass(objPrjTabEN);      //把界面的值传到
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
                objPrjTabEN.UpdateRecordEx();
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
            BindGv_PrjTabByFunc();
            DispPrjTabListRegion();
            PrjTab_Edit1.Clear();//添空控件中的内容
                                 //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjTabEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_PrjTab{0}'", objPrjTabEN.TabId.ToString().Trim()), true);
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
            clsPrjTabEN objPrjTabEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddPrjTabRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    if (btnOKUpd.CommandArgument == "AddWithMaxId")
                    {
                        //AddPrjTabRecordWithMaxIdSave();
                    }
                    else
                    {
                        AddPrjTabRecordSave();
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objPrjTabEN = (clsPrjTabEN)Session["objPrjTabEN"];
                    UpdatePrjTabRecordSave(objPrjTabEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjPrjTabEN">数据传输的目的类对象</param>
        protected void PutDataToPrjTabClass(clsPrjTabEN pobjPrjTabEN)
        {
            pobjPrjTabEN.SetTabId(PrjTab_Edit1.TabId)// 表ID
            .SetTabName(PrjTab_Edit1.TabName)// 表名
            .SetTabCnName(PrjTab_Edit1.TabCnName)// 表中文名
            .SetSqlDsTypeId(PrjTab_Edit1.SqlDsTypeId)// 数据源类型
            .SetTabStateId(PrjTab_Edit1.TabStateId)// 表状态ID
            .SetTabNameB(PrjTab_Edit1.TabNameB)// 表名_后备
            .SetFuncModuleAgcId(PrjTab_Edit1.FuncModuleAgcId)// 功能模块
            .SetDataBaseName(PrjTab_Edit1.DataBaseName)// 数据库名
            .SetOwner(PrjTab_Edit1.Owner)// 拥有者
            .SetMemo(PrjTab_Edit1.Memo)// 说明
            .SetPrjId(vsPrjId_Cache);// 工程ID
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelPrjTabEdit_Click(object sender, EventArgs e)
        {
            DispPrjTabListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<string> lstTabId = PrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strTabId in lstTabId)
                {
                    clsPrjTabBL.DelRecord(strTabId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_PrjTabByFunc();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void PrjTab4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strTabId = e.KeyId;
            DeletePrjTabRecord(strTabId);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "strTabId">给定关键字</param>
        protected void DeletePrjTabRecord(string strTabId)
        {
            try
            {
                clsPrjTabBL.DelRecord(strTabId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_PrjTabByFunc();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vPrjTab]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinePrjTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "PrjTab信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convPrjTab.TabId); arrCnName.Add("表ID");
            arrColName.Add(convPrjTab.FldNum); arrCnName.Add("FldNum");
            arrColName.Add(convPrjTab.TabName); arrCnName.Add("表名");
            arrColName.Add(convPrjTab.TabEnName); arrCnName.Add("表英文详细名");
            arrColName.Add(convPrjTab.TabCnName); arrCnName.Add("表中文名");
            arrColName.Add(convPrjTab.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convPrjTab.IsNeedTransCode); arrCnName.Add("是否需要转换代码");
            arrColName.Add(convPrjTab.SqlDsTypeName); arrCnName.Add("Sql数据源名");
            arrColName.Add(convPrjTab.TabStateName); arrCnName.Add("表状态名称");
            arrColName.Add(convPrjTab.TabNameB); arrCnName.Add("表名_后备");
            arrColName.Add(convPrjTab.IsParaTab); arrCnName.Add("是否参数表");
            arrColName.Add(convPrjTab.IsNationStandard); arrCnName.Add("是否国标");
            arrColName.Add(convPrjTab.IsArchive); arrCnName.Add("是否存档");
            arrColName.Add(convPrjTab.IsChecked); arrCnName.Add("是否核实");
            arrColName.Add(convPrjTab.FuncModuleName); arrCnName.Add("功能模块名称");
            arrColName.Add(convPrjTab.FuncModuleEnName); arrCnName.Add("功能模块英文名称");
            arrColName.Add(convPrjTab.Owner); arrCnName.Add("拥有者");
            arrColName.Add(convPrjTab.IsReleToSqlTab); arrCnName.Add("是否与SQL表相关");
            arrColName.Add(convPrjTab.Keyword); arrCnName.Add("关键字");
            arrColName.Add(convPrjTab.TabTypeName); arrCnName.Add("表类型名");
            arrColName.Add(convPrjTab.RelaTabId4View); arrCnName.Add("视图的相关表ID");
            arrColName.Add(convPrjTab.OrderNum4Refer); arrCnName.Add("引用序号");
            arrColName.Add(convPrjTab.IsNeedGeneIndexer); arrCnName.Add("是否需要生成索引器");
            arrColName.Add(convPrjTabFld.PrimaryTypeName); arrCnName.Add("主键类型名");
            arrColName.Add(convPrjTab.ParentClass); arrCnName.Add("父类");
            arrColName.Add(convPrjTab.IsUseCache); arrCnName.Add("是否使用Cache");
            //arrColName.Add(convPrjTab.KeyFldName); arrCnName.Add("关键字段名");
            arrColName.Add(convPrjTab.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convPrjTab.Memo); arrCnName.Add("说明");
            arrColName.Add(convPrjTab.DataBaseNameTab); arrCnName.Add("DataBaseNameTab");
            arrColName.Add(convPrjTab.RelaTabName4View); arrCnName.Add("RelaTabName4View");
            arrColName.Add(convPrjTab.UpdDate2); arrCnName.Add("UpdDate2");
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
                objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
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
        private void DispPrjTabListRegion()
        {
            divList.Visible = true;
            tabEditPrjTabRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditPrjTabRegion()
        {
            divList.Visible = false;
            tabEditPrjTabRegion.Visible = true;
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
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefProperty_vsCacheClassifyField)
        /// </summary>
        protected string vsPrjId_Cache
        {
            get
            {
                string sPrjId_Cache;
                sPrjId_Cache = (string)ViewState["PrjId_Cache"];
                if (sPrjId_Cache == null)
                {
                    sPrjId_Cache = "";
                }
                return sPrjId_Cache;
            }
            set
            {
                string sPrjId_Cache = value;
                ViewState.Add("PrjId_Cache", sPrjId_Cache);
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

    }
}