
/*-- -- -- -- -- -- -- -- -- -- --
类名:DataNode_QUDI
界面名:DataNode_QUDI(00050298)
生成代码版本:2020.07.21.1
生成日期:2020/07/23 03:59:08
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.ddns.net,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:AI模块
模块英文名:AIModule
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
using TzAdvancedLib;

namespace AGC.Webform
{
    /// <summary>
    /// DataNode_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class DataNode_QUDI : System.Web.UI.Page
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
                //vsPrjId_Cache = "0116";
                //vsPrjId_Cache = "0005";
                vsPrjId_Cache = clsPubVar.CurrSelPrjId;// 当前用户选择的工程Id;
                string strCmPrjId = clsUserDefaValue_LocalBLEx.getUserDefaValue(clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程");
                vsCmPrjId = strCmPrjId;
                //1、初始化，初始化一些导出Excel要用的变量
                vsViewName = "数据结点维护";
                vsTabName = string.Format("{0}", clsvDataNodeEN._CurrTabName);
                //2、用户权限管理:处理当前用户在当前界面的权限相关操作
                AccessUserPotence();
                //3、绑定查询区的下拉框
                BindDdl4QueryRegion();

                //4、设置列表区的排序字段
                DataNode4Gv1.SetSortBy(string.Format("{0} Asc", convDataNode.DataNodeId));
                //5、显示无条件的表内容在GridView中

                BindGv_vDataNodeCache();
                //7、设置逻辑层的公共函数，包含：缓存刷新函数
                //clsDataNodeBL.objCommFun4BL = new clsCommFun4BL4DataNode();
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

                var strPrjId = vsPrjId_Cache;  //相关缓存字段
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjIdq, clsPubVar.CurrSelPrjId);
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjId_Copy, clsPubVar.CurrSelPrjId);
                if (string.IsNullOrEmpty(vsCmPrjId) == false)
                {
                    ddlCmPrjIdq.SelectedValue = vsCmPrjId;
                    clsPrjTabBLEx.BindDdl_TabIdByCmPrjIdExCacheNoPureClass(ddlTabIdq, strPrjId, vsCmPrjId);

                    clsDataNodeBLEx.BindDdl_SubGraphName(ddlSubGraphNameq, vsCmPrjId);
                    clsFieldTabBLEx.BindDdl_FldIdByCmPrjIdCache(ddlFldIdq, strPrjId, vsCmPrjId);
                }


                clsDataNodeTypeBL.BindDdl_DataNodeTypeId(ddlDataNodeTypeIdq);

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

            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }
            try
            {
                string strCmPrjId = ddlCmPrjIdq.SelectedValue;
                clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
                vsCmPrjId = strCmPrjId;

                //把GridView的当前页索引设置为0,即第1页。
                //当单击查询时,首先显示的是表记录内容的第一部分内容。
                DataNode4Gv1.vsPageIndex = 1;
                //把表记录的内容显示在GridView中
                BindGv_vDataNodeCache();
            }
            catch(Exception objException)
            {
                string strMsg = string.Format("{0}", objException.Message);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage_Cache)
        /// </summary>
        protected void BindGv_vDataNodeCache()
        {
            //操作步骤:(共5步)
            //	1、设置Gv控件的某些列不可见;
            //	2、组合界面条件串；
            //	3、调用控件中的绑定GridView函数;

            string strCmPrjId = vsCmPrjId;
            if (string.IsNullOrEmpty(strCmPrjId)) return;
            try
            {
                //	1、设置Gv控件的某些列不可见；
                //DataNode4Gv1.SetGvVisibility(convDataNode.UpdDate, false);
                //DataNode4Gv1.SetGvVisibility(convDataNode.UpdUser, false);
                //	2、组合界面条件串；
                clsvDataNodeEN objvDataNode_Cond = CombinevDataNodeConditionObj();
                //objvDataNode_Cond.SetCmPrjId(strCmPrjId, "=");
                //	3、调用控件中的绑定GridView函数；
                DataNode4Gv1.BindGv_DataNodeCache(objvDataNode_Cond);
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
        protected string CombinevDataNodeCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
            try
            {
                if (this.txtDataNodeIdq.Text.Trim() != "")
                {
                    objvDataNodeEN.DataNodeId = this.txtDataNodeIdq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convDataNode.DataNodeId, this.txtDataNodeIdq.Text.Trim());
                }
                if (this.txtDataNodeNameq.Text.Trim() != "")
                {
                    objvDataNodeEN.DataNodeName = this.txtDataNodeNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convDataNode.DataNodeName, this.txtDataNodeNameq.Text.Trim());
                }
                if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
                {
                    objvDataNodeEN.TabId = this.ddlTabIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convDataNode.TabId, this.ddlTabIdq.SelectedValue);
                }
                if (this.ddlFldIdq.SelectedValue != "" && this.ddlFldIdq.SelectedValue != "0")
                {
                    objvDataNodeEN.FldId = this.ddlFldIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convDataNode.FldId, this.ddlFldIdq.SelectedValue);
                }
                if (this.ddlDataNodeTypeIdq.SelectedValue != "" && this.ddlDataNodeTypeIdq.SelectedValue != "0")
                {
                    objvDataNodeEN.DataNodeTypeId = this.ddlDataNodeTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convDataNode.DataNodeTypeId, this.ddlDataNodeTypeIdq.SelectedValue);
                }
                objvDataNodeEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineDataNodeCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CombineConditionObj)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected clsvDataNodeEN CombinevDataNodeConditionObj()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
            try
            {
                if (this.txtDataNodeIdq.Text.Trim() != "")
                {
                    objvDataNodeEN.SetDataNodeId(string.Format("{0}", this.txtDataNodeIdq.Text.Trim()), "like");
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convDataNode.DataNodeId, this.txtDataNodeIdq.Text.Trim());
                }
                if (this.txtDataNodeNameq.Text.Trim() != "")
                {
                    objvDataNodeEN.SetDataNodeName(string.Format("{0}", this.txtDataNodeNameq.Text.Trim()), "like");
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convDataNode.DataNodeName, this.txtDataNodeNameq.Text.Trim());
                }
                if (this.ddlCmPrjIdq.SelectedValue != "" && this.ddlCmPrjIdq.SelectedValue != "0")
                {
                    //objvDataNodeEN.SetCmPrjId(this.ddlCmPrjIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convDataNode.PrjId, this.ddlCmPrjIdq.SelectedValue);
                }

                if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
                {
                    objvDataNodeEN.SetTabId(this.ddlTabIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convDataNode.TabId, this.ddlTabIdq.SelectedValue);
                }
                if (this.ddlFldIdq.SelectedValue != "" && this.ddlFldIdq.SelectedValue != "0")
                {
                    objvDataNodeEN.SetFldId(this.ddlFldIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convDataNode.FldId, this.ddlFldIdq.SelectedValue);
                }
                if (this.ddlDataNodeTypeIdq.SelectedValue != "" && this.ddlDataNodeTypeIdq.SelectedValue != "0")
                {
                    objvDataNodeEN.SetDataNodeTypeId(this.ddlDataNodeTypeIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convDataNode.DataNodeTypeId, this.ddlDataNodeTypeIdq.SelectedValue);
                }
                if (this.ddlSubGraphNameq.SelectedValue != "" && this.ddlSubGraphNameq.SelectedValue != "0")
                {
                    objvDataNodeEN.SetSubGraphName(this.ddlSubGraphNameq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convDataNode.SubGraphName, this.ddlSubGraphNameq.SelectedValue);
                }
                objvDataNodeEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000086)在组合查询条件(CombineDataNodeConditionObj)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return objvDataNodeEN;
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
                var strPrjId = vsPrjId_Cache;  //相关缓存字段
                DataNode_Edit1.SetDdl_TabId(strPrjId, vsCmPrjId);
                DataNode_Edit1.SetDdl_FldId(strPrjId, vsCmPrjId);
                DataNode_Edit1.SetDdl_DataNodeTypeId();
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
            AddDataNodeRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void AddDataNodeRecord()
        {
            //1、绑定编辑区的下拉框
            BindDdl4EditRegion();
            //2、设置关键字字段可以编辑
            DataNode_Edit1.SetKeyReadOnly(false);
            //3、改变相关编辑按钮的状态
            btnOKUpd.Text = "确认添加";
            btnCancelDataNodeEdit.Text = "取消添加";
            //4、设置添加时编辑区域控件的初值
            DataNode_Edit1.DataNodeId = clsDataNodeBL.GetMaxStrId_S();
            DispEditDataNodeRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddDataNodeRecordSave()
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
            clsDataNodeEN objDataNodeEN;
            //1、检查控件中输入数据类型是否正确
            if (!DataNode_Edit1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsDataNodeEN objDataNodeEN;	//定义对象
            objDataNodeEN = new clsDataNodeEN(DataNode_Edit1.DataNodeId);   //初始化新对象

            try
            {
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataToDataNodeClass(objDataNodeEN);      //把界面的值传到
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
                objDataNodeEN.AddRecordEx();
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
            BindGv_vDataNodeCache();
            DispDataNodeListRegion();
            DataNode_Edit1.Clear();     //清空控件中内容
                                        ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDataNodeEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnCopyRecord_Click4OneKeyword)
        /// </summary>
        protected void btnCopyRecord_Click(object sender, System.EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;

                //1、显示该关键字的数据让用户修改该关键字记录；
                string strDataNodeId = DataNode4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strDataNodeId) == true) return;
            CopyRecord(strDataNodeId, strCmPrjId);
        }

        /// <summary>
        /// 复制记录,把给定关键字的记录内容复制一个新记录，把名称字段值的前面加上"Copy_"
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CopyRecord)
        /// </summary>
        protected void CopyRecord(string strDataNodeId, string strPrjId)
        {
            try
            {
                K_DataNodeId_DataNode myKey = new K_DataNodeId_DataNode(strDataNodeId);
                clsDataNodeEN objDataNodeEN = myKey.GetObj();
                objDataNodeEN.DataNodeId = clsDataNodeBL.GetMaxStrId_S();
                objDataNodeEN.VersionNo+=1;
                var strCondition = new clsDataNodeEN()
                    .SetFldId(objDataNodeEN.FldId, "=")
                    .SetTabId(objDataNodeEN.TabId, "=")
                    .SetPrjId(strPrjId, "=")
                    .SetVersionNo(objDataNodeEN.VersionNo, "=")
                    .GetCombineCondition();
                if (clsDataNodeBL.IsExistRecord(strCondition) == true)
                {
                    string strMsg = string.Format("该结点的下一版本已经存在，请选择此结点的最新版本，然后再复制！(In {0})", clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                //string strVersionNo = "";
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDataNodeEN.FldId, objDataNodeEN.PrjId);
                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objDataNodeEN.TabId, objDataNodeEN.PrjId);

                if (objFieldTab == null || objPrjTab == null)
                {
                    string strMsg = string.Format("该结点的表或者字段不存在，请检查，然后再复制！(In {0})", clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                objDataNodeEN.DataNodeName = string.Format("{0}_{1}V{2}", objPrjTab.TabName, objFieldTab.FldName, objDataNodeEN.VersionNo);
                objDataNodeEN.AddNewRecord();
                BindGv_vDataNodeCache();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在克隆记录时出错！错误：{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strDataNodeId = DataNode4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strDataNodeId) == true) return;
            UpdateDataNodeRecord(strDataNodeId);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdateDataNodeRecord(string strDataNodeId)
        {
            //操作步骤:(总共2步)
            //1、绑定编辑区的下拉框
            //2、显示该关键字记录的内容在界面上；
            //3、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、绑定编辑区的下拉框
            BindDdl4EditRegion();
            //2、显示该关键字记录的内容在界面上；
            ShowData(strDataNodeId);
            //3、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            DataNode_Edit1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelDataNodeEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditDataNodeRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ShowData)
        /// </summary>
        /// <param name = "strDataNodeId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strDataNodeId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strDataNodeId == "") return;        //如果关键字为空就返回退出
                                                    //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsDataNodeBL.IsExist(strDataNodeId) == false)      //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[DataNode]中,关键字为:[strDataNodeId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsDataNodeEN objDataNodeEN = new clsDataNodeEN(strDataNodeId);
            //4、获取类对象的所有属性；
            try
            {
                clsDataNodeBL.GetDataNode(ref objDataNodeEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objDataNodeEN", objDataNodeEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromDataNodeClass(objDataNodeEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjDataNodeEN">表实体类对象</param>
        protected void GetDataFromDataNodeClass(clsDataNodeEN pobjDataNodeEN)
        {
            DataNode_Edit1.DataNodeId = pobjDataNodeEN.DataNodeId;// 数据结点Id
            DataNode_Edit1.TabId = pobjDataNodeEN.TabId;// 表
            DataNode_Edit1.FldId = pobjDataNodeEN.FldId;// 字段
            DataNode_Edit1.DataNodeName = pobjDataNodeEN.DataNodeName;// 结点名
            DataNode_Edit1.DataNodeTypeId = pobjDataNodeEN.DataNodeTypeId;// 结点类型
            DataNode_Edit1.Memo = pobjDataNodeEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void DataNode4Gv_Cache1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strDataNodeId = e.KeyId;
            UpdateDataNodeRecord(strDataNodeId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objDataNodeEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateDataNodeRecordSave(clsDataNodeEN objDataNodeEN)
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
            if (!DataNode_Edit1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            try
            {
                //2、把值从界面层传到逻辑层或数据实体层
                PutDataToDataNodeClass(objDataNodeEN);      //把界面的值传到
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
                objDataNodeEN.UpdateRecordEx();
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
            BindGv_vDataNodeCache();
            DispDataNodeListRegion();
            DataNode_Edit1.Clear();//添空控件中的内容
                                   //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDataNodeEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_DataNode{0}'", objDataNodeEN.DataNodeId.ToString().Trim()), true);
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
            clsDataNodeEN objDataNodeEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddDataNodeRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    if (btnOKUpd.CommandArgument == "AddWithMaxId")
                    {
                        //AddDataNodeRecordWithMaxIdSave();
                    }
                    else
                    {
                        AddDataNodeRecordSave();
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objDataNodeEN = (clsDataNodeEN)Session["objDataNodeEN"];
                    UpdateDataNodeRecordSave(objDataNodeEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjDataNodeEN">数据传输的目的类对象</param>
        protected void PutDataToDataNodeClass(clsDataNodeEN pobjDataNodeEN)
        {
            pobjDataNodeEN.SetDataNodeId(DataNode_Edit1.DataNodeId)// 数据结点Id
            .SetTabId(DataNode_Edit1.TabId)// 表
            .SetFldId(DataNode_Edit1.FldId)// 字段
            .SetDataNodeName(DataNode_Edit1.DataNodeName)// 结点名
            .SetPrjId(vsPrjId_Cache)// 工程ID
            .SetDataNodeTypeId(DataNode_Edit1.DataNodeTypeId)// 结点类型
            .SetMemo(DataNode_Edit1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelDataNodeEdit_Click(object sender, EventArgs e)
        {
            DispDataNodeListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {

            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }
       

                List<string> lstDataNodeId = DataNode4Gv1.GetAllCheckedKeysFromGv();
            if (lstDataNodeId == null) return;
            lblMsgList.Text = "";
            try
            {

                string strCmPrjId = ddlCmPrjIdq.SelectedValue;
                clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
                vsCmPrjId = strCmPrjId;
                foreach (string strDataNodeId in lstDataNodeId)
                {
                    clsDataNodeBLEx.DelRecordEx(strDataNodeId, strCmPrjId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vDataNodeCache();
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "strDataNodeId">给定关键字</param>
        protected void DeleteDataNodeRecord(string strDataNodeId)
        {
            try
            {
                clsDataNodeBL.DelRecord(strDataNodeId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vDataNodeCache();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vDataNode]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevDataNodeCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "DataNode信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convDataNode.DataNodeId); arrCnName.Add("数据结点Id");
            arrColName.Add(convDataNode.DataNodeName); arrCnName.Add("数据结点名");
            arrColName.Add(convDataNode.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convDataNode.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convDataNode.Memo); arrCnName.Add("说明");
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
                objDT = clsvDataNodeBL.GetDataTable(strWhereCond);
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
        private void DispDataNodeListRegion()
        {
            divList.Visible = true;
            tabEditDataNodeRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditDataNodeRegion()
        {
            divList.Visible = false;
            tabEditDataNodeRegion.Visible = true;
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

        protected string vsCmPrjId
        {
            get
            {
                string sCmPrjId;
                sCmPrjId = (string)ViewState["CmPrjId"];
                if (sCmPrjId == null)
                {
                    sCmPrjId = "";
                }
                return sCmPrjId;
            }
            set
            {
                string sCmPrjId = value;
                ViewState.Add("CmPrjId", sCmPrjId);
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

        protected void btnAddNewRecordWithMaxId_Click(object sender, EventArgs e)
        {

        }

        protected void btnSetStartNode_Click(object sender, EventArgs e)
        {
            string strDataNodeId = DataNode4Gv1.GetFirstCheckedKeyFromGv();
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            if (ddlCmPrjIdq.SelectedIndex<=0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }
     
            if (string.IsNullOrEmpty(strDataNodeId) == true) return;
            var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(strDataNodeId, strCmPrjId);
            txtStartNode.Text = objDataNode.DataNodeName;
            txtStartNode.ToolTip = objDataNode.DataNodeId;
        }

        protected void btnSetEndNode_Click(object sender, EventArgs e)
        {
            string strDataNodeId = DataNode4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strDataNodeId) == true) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }
            var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(strDataNodeId, strCmPrjId);
            txtEndNode.Text = objDataNode.DataNodeName;
            txtEndNode.ToolTip = objDataNode.DataNodeId;
        }

        protected void btnGetGraphPath_Click(object sender, EventArgs e)
        {

            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }

            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
            vsCmPrjId = strCmPrjId;
            //Graph g1 =   clsDataNodeBLEx.InitGraph(vsCmPrjId);
            string strStartNodeId = txtStartNode.ToolTip;
            string strEndNodeId = txtEndNode.ToolTip;
            try
            {
                clsDataNodeBLEx.BindDdl_PathNode(ddlGraphPath, strStartNodeId, strEndNodeId, vsCmPrjId);

                //List<clsDataNodeEN> arrPath = clsDataNodeBLEx.GetGraphPath(g, strStartNodeId, strEndNodeId, vsPrjId_Cache);
                //ListBox1.Items.Clear();
                //foreach (var objInFor in arrPath)
                //{
                //    ListBox1.Items.Add(objInFor.DataNodeName);
                //}
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnGetConnectedNode_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }

            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsUserDefaValue_LocalBLEx.setUserDefaValue( clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
            vsCmPrjId = strCmPrjId;

            //Graph g1 = clsDataNodeBLEx.InitGraph(vsCmPrjId);
            string strStartNodeId = txtStartNode.ToolTip;
            //string strEndNodeId = txtEndNode.ToolTip;
            try
            {
                //List<clsDataNodeEN> arrConnectedNode = clsDataNodeBLEx.GetConnectedNode(g, strStartNodeId, vsPrjId_Cache);
                //ListBox2.Items.Clear();
                clsDataNodeBLEx.BindDdl_ConnectedNodeV2(ddlConnectedNode, strStartNodeId, strCmPrjId, false);
                //foreach (var objInFor in arrConnectedNode)
                //{
                //    ListBox2.Items.Add(objInFor.DataNodeName);
                //}
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnImportNode4TabId_Click(object sender, EventArgs e)
        {
            if (ddlTabIdq.SelectedIndex<=0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个表！");
                ddlTabIdq.Focus();
                return;
            }
            var strTabId = ddlTabIdq.SelectedValue;

            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }

            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
            vsCmPrjId = strCmPrjId;

            try
            {
                int intCount = clsDataNodeBLEx.ImportNode4TabId(strTabId, vsCmPrjId);
                string strMsg = string.Format("共导入:[{0}]个数据结点。(In {1})",
                        intCount, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                clsDataNodeBL.ReFreshCache(vsPrjId_Cache);
                BindGv_vDataNodeCache();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnImportNode4KeyAndName_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }

            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
         

            try
            {
                clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
                vsCmPrjId = strCmPrjId;
                int intCount = clsDataNodeBLEx.ImportNode4KeyAndName( strCmPrjId);
                string strMsg = string.Format("共导入:[{0}]个数据结点。(In {1})",
                        intCount, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                clsDataNodeBL.ReFreshCache(vsPrjId_Cache);
                BindGv_vDataNodeCache();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnImportSameSourceBy4KeyNode_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }

            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
            vsCmPrjId = strCmPrjId;

            try
            {
                int intCount = clsDataNodeBLEx.ImportSameSourceBy4KeyNode(strCmPrjId);
                string strMsg = string.Format("共导入:[{0}]个数据结点。(In {1})",
                        intCount, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                clsDataNodeBL.ReFreshCache(vsPrjId_Cache);
                BindGv_vDataNodeCache();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void ddlConnectedNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strDataNodeId = ddlConnectedNode.SelectedValue;
            if (string.IsNullOrEmpty(strDataNodeId) == true) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }
            var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(strDataNodeId, strCmPrjId);
            txtEndNode.Text = objDataNode.DataNodeName;
            txtEndNode.ToolTip = objDataNode.DataNodeId;
        }

        protected void ddlConnectedNode4TabId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strDataNodeId = ddlConnectedNode4TabId.SelectedValue;
            if (string.IsNullOrEmpty(strDataNodeId) == true) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }
            var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(strDataNodeId, strCmPrjId);
            txtEndNode.Text = objDataNode.DataNodeName;
            txtEndNode.ToolTip = objDataNode.DataNodeId;
        }

        protected void ddlConnectedNodeByEndNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strDataNodeId = ddlConnectedNodeByEndNode.SelectedValue;
            if (string.IsNullOrEmpty(strDataNodeId) == true) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }
            var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(strDataNodeId, strCmPrjId);
            txtStartNode.Text = objDataNode.DataNodeName;
            txtStartNode.ToolTip = objDataNode.DataNodeId;
        }

        protected void btnGetConnectedNodeByEndNode_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }

            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsUserDefaValue_LocalBLEx.setUserDefaValue( clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
            vsCmPrjId = strCmPrjId;

            //Graph g1 = clsDataNodeBLEx.InitGraph(vsCmPrjId);
            string strEndNodeId = txtEndNode.ToolTip;
            //string strEndNodeId = txtEndNode.ToolTip;
            try
            {
                //List<clsDataNodeEN> arrConnectedNode = clsDataNodeBLEx.GetConnectedNode(g, strStartNodeId, vsPrjId_Cache);
                //ListBox2.Items.Clear();
                clsDataNodeBLEx.BindDdl_ConnectedNodeV2_Prev(ddlConnectedNodeByEndNode, strEndNodeId, strCmPrjId);
                //foreach (var objInFor in arrConnectedNode)
                //{
                //    ListBox2.Items.Add(objInFor.DataNodeName);
                //}
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnGetAllConnectedSubGroup_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个CM工程");
                ddlCmPrjIdq.Focus();
                return;
            }

            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, vsPrjId_Cache, clsCommonSession.UserId, "默认CM工程", strCmPrjId);
            vsCmPrjId = strCmPrjId;

            //Graph g1 = clsDataNodeBLEx.InitGraph(strCmPrjId);
            string strEndNodeId = txtEndNode.ToolTip;
            //string strEndNodeId = txtEndNode.ToolTip;
            try
            {
                List<clsDataNodeEN> arrConnectedNode = clsDataNodeBLEx.GetAllConnectedSubGroup(strCmPrjId);
                //ListBox2.Items.Clear();

                //foreach (var objInFor in arrConnectedNode)
                //{
                //    ListBox2.Items.Add(objInFor.DataNodeName);
                //}
                clsDataNodeBLEx.BindDdl_SubGraphName(ddlSubGraphNameq, vsCmPrjId);

                BindGv_vDataNodeCache();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }
        protected void ddlCmPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            //clsCMProjectFuncModuleBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, strCmPrjId);
            clsPrjTabBLEx.BindDdl_TabIdByCmPrjIdExCacheNoPureClass(ddlTabIdq, clsPubVar.CurrSelPrjId, strCmPrjId);
            clsDataNodeBLEx.BindDdl_SubGraphName(ddlSubGraphNameq, strCmPrjId);

            clsFieldTabBLEx.BindDdl_FldIdByCmPrjIdCache(ddlFldIdq, clsPubVar.CurrSelPrjId, strCmPrjId);
        }

        protected void btnCopyTo_Click(object sender, EventArgs e)
        {
            List<string> lstDataNodeId = DataNode4Gv1.GetAllCheckedKeysFromGv();
            if (lstDataNodeId == null) return;
            if (ddlCmPrjId_Copy.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个目标CM项目！");
                ddlCmPrjId_Copy.Focus();
                return;
            }
            string strCmPrjId_T = ddlCmPrjId_Copy.SelectedValue;
            if (strCmPrjId_T == vsCmPrjId)
            {
                var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(vsCmPrjId);
                clsCommonJsFunc.Alert(this,
                    string.Format("请选择一个与当前CM项目:[{0}]不同的CM项目！", objCMProject.CmPrjName));
                ddlCmPrjId_Copy.Focus();
                return;
            }
            lblMsgList.Text = "";
            try
            {
                int intIndex = 0;
                foreach (string strDataNodeId in lstDataNodeId)
                {
                    var objDataNode = clsDataNodeBL.GetObjByDataNodeId(strDataNodeId);
                    objDataNode.PrjId = strCmPrjId_T;
                    objDataNode.DataNodeId = clsDataNodeBL.GetMaxStrId_S();
                    string strCondition = objDataNode.GetUniCondStr();
                    if (clsDataNodeBL.IsExistRecord(strCondition) == false)
                    {
                        clsDataNodeBL.AddNewRecordBySql2(objDataNode);
                        intIndex++;
                    }
                }
                clsCommonJsFunc.Alert(this,
                   string.Format("共复制了[{0}]个表到目标CM项目！", intIndex));
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000055)复制到新CM项目不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
        }
    }
}