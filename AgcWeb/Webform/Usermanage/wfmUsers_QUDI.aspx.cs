
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmUsers_QUDI
界面名:wfmUsers_QUDI(00050114)
生成代码版本:2019.11.08.1
生成日期:2019/11/08 16:26:23
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:用户管理
模块英文名:UserManage
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
    /// wfmUsers_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmUsers_QUDI : System.Web.UI.Page
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

                vsViewName = "用于用户管理维护";
                vsTabName = string.Format("{0}", clsvUsersEN._CurrTabName);
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


                //1、为下拉框设置数据源,绑定列表数据
                wucUsers1.SetDdl_DepartmentId();
                wucUsers1.SetDdl_IdentityID();
                clsDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentIdq);
                clsUserIdentityBL.BindDdlIdentityID(ddlIdentityIDq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsGpUserq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsRegisterq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsAuditq);
                wucvUsers4Gv1.SetSortBy(string.Format("{0} Asc", convUsers.UserId));
                //2、显示无条件的表内容在GridView中
                BindGv_vUsers();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucUsers1.SetKeyReadOnly(true);
                DispUsersListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsUsersBL.objCommFun4BL = new clsCommFun4BL4Users();
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
            wucvUsers4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vUsers();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vUsers()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	3、设置Gv控件的某些列不可见；
                wucvUsers4Gv1.SetGvVisibility(convUsers.Password, false);
                wucvUsers4Gv1.SetGvVisibility(convUsers.RegisterPassword, false);
                wucvUsers4Gv1.SetGvVisibility(convUsers.DepartmentName, false);
                wucvUsers4Gv1.SetGvVisibility(convUsers.DepartmentTypeName, false);
                wucvUsers4Gv1.SetGvVisibility(convUsers.UpDepartmentName, false);

                wucvUsers4Gv1.SetGvVisibility(convUsers.UpdDate, false);
                wucvUsers4Gv1.SetGvVisibility(convUsers.UpdUser, false);
                //	1、组合界面条件串；
                string strWhereCond = CombinevUsersCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvUsers4Gv1.BindGv_Users(strWhereCond);
               
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
        protected string CombinevUsersCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvUsersEN objvUsersEN = new clsvUsersEN();
            try
            {
                if (this.txtUserIdq.Text.Trim() != "")
                {
                    objvUsersEN.UserId = this.txtUserIdq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convUsers.UserId, this.txtUserIdq.Text.Trim());
                }
                if (this.txtUserNameq.Text.Trim() != "")
                {
                    objvUsersEN.UserName = this.txtUserNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convUsers.UserName, this.txtUserNameq.Text.Trim());
                }
                if (this.ddlDepartmentIdq.SelectedValue != "" && this.ddlDepartmentIdq.SelectedValue != "0")
                {
                    objvUsersEN.DepartmentId = this.ddlDepartmentIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convUsers.DepartmentId, this.ddlDepartmentIdq.SelectedValue);
                }
                if (this.txtUserStateIdq.Text.Trim() != "")
                {
                    objvUsersEN.UserStateId = this.txtUserStateIdq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convUsers.UserStateId, this.txtUserStateIdq.Text.Trim());
                }
                if (this.ddlIdentityIDq.SelectedValue != "" && this.ddlIdentityIDq.SelectedValue != "0")
                {
                    objvUsersEN.IdentityID = this.ddlIdentityIDq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convUsers.IdentityID, this.ddlIdentityIDq.SelectedValue);
                }
                if (this.ddlIsGpUserq.SelectedIndex == 1)
                {
                    objvUsersEN.IsGpUser = true;
                    strWhereCond += string.Format(" And {0} = '1'", convUsers.IsGpUser);
                }
                else if (this.ddlIsGpUserq.SelectedIndex == 2)
                {
                    objvUsersEN.IsGpUser = false;
                    strWhereCond += string.Format(" And {0} = '0'", convUsers.IsGpUser);
                }
                if (this.ddlIsRegisterq.SelectedIndex == 1)
                {
                    objvUsersEN.IsRegister = true;
                    strWhereCond += string.Format(" And {0} = '1'", convUsers.IsRegister);
                }
                else if (this.ddlIsRegisterq.SelectedIndex == 2)
                {
                    objvUsersEN.IsRegister = false;
                    strWhereCond += string.Format(" And {0} = '0'", convUsers.IsRegister);
                }
                if (this.ddlIsAuditq.SelectedIndex == 1)
                {
                    objvUsersEN.IsAudit = true;
                    strWhereCond += string.Format(" And {0} = '1'", convUsers.IsAudit);
                }
                else if (this.ddlIsAuditq.SelectedIndex == 2)
                {
                    objvUsersEN.IsAudit = false;
                    strWhereCond += string.Format(" And {0} = '0'", convUsers.IsAudit);
                }
                objvUsersEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineUsersCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
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


        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        /// <summary>
        ///添加新记录的事件过程 
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnAddNewRecord_Click)
        /// </summary>
        protected void btnAddNewRecord_Click(object sender, System.EventArgs e)
        {
            AddUsersRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void AddUsersRecord()
        {
            wucUsers1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelUsersEdit.Text = "取消添加";
            //wucUsers1.UserId = clsUsersBL.GetMaxStrId_S();
            DispEditUsersRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddUsersRecordSave()
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
            clsUsersEN objUsersEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucUsers1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsUsersEN objUsersEN;	//定义对象
            objUsersEN = new clsUsersEN(wucUsers1.UserId);  //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsUsersBL.IsExist(objUsersEN.UserId))  //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000004)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            try
            {
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataToUsersClass(objUsersEN);        //把界面的值传到
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
                //5.1、检查传进去的对象属性是否合法
                objUsersEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objUsersEN.AddNewRecord();
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
            BindGv_vUsers();
            DispUsersListRegion();
            wucUsers1.Clear();      //清空控件中内容
                                    ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUsersEdit.Text = "取消编辑";
            return true;
        }

        ///// <summary>
        /////修改当前被选记录
        ///// (AutoGCLib.WebViewControlCode4CSharp:GenbtnCopyRecord_Click4OneKeyword)
        ///// </summary>
        //protected void btnCopyRecord_Click(object sender, System.EventArgs e)
        //{
        //    //1、显示该关键字的数据让用户修改该关键字记录；
        //    string strUserId = wucvUsers4Gv1.GetFirstCheckedKeyFromGv();
        //    if (string.IsNullOrEmpty(strUserId) == true) return;
        //    CopyRecord(strUserId);
        //}

        /// <summary>
        /// 复制记录,把给定关键字的记录内容复制一个新记录，把名称字段值的前面加上"Copy_"
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CopyRecord)
        /// </summary>
        //protected void CopyRecord(string strUserId)
        //{
        //    try
        //    {
        //        K_UserId_Users myKey = new K_UserId_Users(strUserId);
        //        clsUsersEN objUsersEN = myKey.GetObj();
        //        objUsersEN.UserId = clsUsersBL.GetMaxStrId_S();
        //        objUsersEN.AddNewRecord();
        //        BindGv_vUsers();
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("在克隆记录时出错！错误：{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
        //        clsCommonJsFunc.Alert(this, strMsg);
        //    }
        //}

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strUserId = wucvUsers4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strUserId) == true) return;
            UpdateUsersRecord(strUserId);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdateUsersRecord(string strUserId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strUserId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucUsers1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelUsersEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditUsersRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ShowData)
        /// </summary>
        /// <param name = "strUserId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strUserId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strUserId == "") return;        //如果关键字为空就返回退出
                                                //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsUsersBL.IsExist(strUserId) == false)     //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[Users]中,关键字为:[strUserId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsUsersEN objUsersEN = new clsUsersEN(strUserId);
            //4、获取类对象的所有属性；
            try
            {
                clsUsersBL.GetUsers(ref objUsersEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objUsersEN", objUsersEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromUsersClass(objUsersEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjUsersEN">表实体类对象</param>
        protected void GetDataFromUsersClass(clsUsersEN pobjUsersEN)
        {
            wucUsers1.UserId = pobjUsersEN.UserId;// 用户ID
            wucUsers1.UserName = pobjUsersEN.UserName;// 用户名
            wucUsers1.UserStateId = pobjUsersEN.UserStateId;// 用户状态号
            wucUsers1.DepartmentId = pobjUsersEN.DepartmentId;// 部门ID
            wucUsers1.qxdj = pobjUsersEN.qxdj ?? 0;// 权限等级
            wucUsers1.EffectiveDate = pobjUsersEN.EffectiveDate;// EffectiveDate
            wucUsers1.EffitiveBeginDate = pobjUsersEN.EffitiveBeginDate;// EffitiveBeginDate
            wucUsers1.EffitiveEndDate = pobjUsersEN.EffitiveEndDate;// EffitiveEndDate
            wucUsers1.Password = pobjUsersEN.Password;// 口令
            wucUsers1.RoleId = pobjUsersEN.RoleId;// 角色ID
            wucUsers1.IdentityID = pobjUsersEN.IdentityID;// 身份编号
            wucUsers1.Email = pobjUsersEN.Email;// 电子邮箱
            wucUsers1.IsGpUser = pobjUsersEN.IsGpUser;// 是否平台用户
            wucUsers1.RegisterPassword = pobjUsersEN.RegisterPassword;// 注册密码
            wucUsers1.IsRegister = pobjUsersEN.IsRegister;// 是否注册
            wucUsers1.RegisterDate = pobjUsersEN.RegisterDate;// 注册日期
            wucUsers1.IsAudit = pobjUsersEN.IsAudit;// 是否审核
            wucUsers1.AuditUser = pobjUsersEN.AuditUser;// 审核人
            wucUsers1.AuditDate = pobjUsersEN.AuditDate;// 审核日期
            wucUsers1.Memo = pobjUsersEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvUsers4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strUserId = e.KeyId;
            UpdateUsersRecord(strUserId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objUsersEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateUsersRecordSave(clsUsersEN objUsersEN)
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
            if (!wucUsers1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            try
            {
                //2、把值从界面层传到逻辑层或数据实体层
                PutDataToUsersClass(objUsersEN);        //把界面的值传到
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
                //3.1、检查传进去的对象属性是否合法
                objUsersEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objUsersEN.Update();
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
            BindGv_vUsers();
            DispUsersListRegion();
            wucUsers1.Clear();//添空控件中的内容
                              //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUsersEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_Users{0}'", objUsersEN.UserId.ToString().Trim()), true);
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
            clsUsersEN objUsersEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddUsersRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddUsersRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objUsersEN = (clsUsersEN)Session["objUsersEN"];
                    UpdateUsersRecordSave(objUsersEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjUsersEN">数据传输的目的类对象</param>
        protected void PutDataToUsersClass(clsUsersEN pobjUsersEN)
        {
            pobjUsersEN.SetUserId(wucUsers1.UserId)// 用户ID
            .SetUserName(wucUsers1.UserName)// 用户名
            .SetUserStateId(wucUsers1.UserStateId)// 用户状态号
            .SetDepartmentId(wucUsers1.DepartmentId)// 部门ID
            .Setqxdj(wucUsers1.qxdj)// 权限等级
            .SetEffectiveDate(wucUsers1.EffectiveDate)// EffectiveDate
            .SetEffitiveBeginDate(wucUsers1.EffitiveBeginDate)// EffitiveBeginDate
            .SetEffitiveEndDate(wucUsers1.EffitiveEndDate)// EffitiveEndDate
            .SetPassword(wucUsers1.Password)// 口令
            .SetRoleId(wucUsers1.RoleId)// 角色ID
            .SetIdentityID(wucUsers1.IdentityID)// 身份编号
            .SetEmail(wucUsers1.Email)// 电子邮箱
            .SetIsGpUser(wucUsers1.IsGpUser)// 是否平台用户
            .SetRegisterPassword(wucUsers1.RegisterPassword)// 注册密码
            .SetIsRegister(wucUsers1.IsRegister)// 是否注册
            .SetRegisterDate(wucUsers1.RegisterDate)// 注册日期
            .SetIsAudit(wucUsers1.IsAudit)// 是否审核
            .SetAuditUser(wucUsers1.AuditUser)// 审核人
            .SetAuditDate(wucUsers1.AuditDate)// 审核日期
            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))//(字段类型:string,字段长度:20,是否可空:20)
            .SetUpdUser(clsCommonSession.UserId)//(字段类型:string,字段长度:20,是否可空:20)
            .SetMemo(wucUsers1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelUsersEdit_Click(object sender, EventArgs e)
        {
            DispUsersListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<string> lstUserId = wucvUsers4Gv1.GetAllCheckedKeysFromGv();
            if (lstUserId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strUserId in lstUserId)
                {
                    clsUsersBLEx.DelRecordEx(strUserId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vUsers();
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "strUserId">给定关键字</param>
        protected void DeleteUsersRecord(string strUserId)
        {
            try
            {
                clsUsersBLEx.DelRecordEx(strUserId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vUsers();
        }

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vUsers]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevUsersCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "Users信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convUsers.UserId); arrCnName.Add("用户Id");
            arrColName.Add(convUsers.UserName); arrCnName.Add("用户名");
            arrColName.Add(convUsers.DepartmentName); arrCnName.Add("部门名称");
            arrColName.Add(convUsers.DepartmentAbbrName); arrCnName.Add("部门简称");
            arrColName.Add(convUsers.DepartmentTypeName); arrCnName.Add("部门类型");
            arrColName.Add(convUsers.UpDepartmentName); arrCnName.Add("上级部门名");
            arrColName.Add(convUsers.UserStateName); arrCnName.Add("用户状态名");
            arrColName.Add(convUsers.EffectiveDate); arrCnName.Add("有效日期");
            arrColName.Add(convUsers.EffitiveBeginDate); arrCnName.Add("有效开始日期");
            arrColName.Add(convUsers.EffitiveEndDate); arrCnName.Add("有效结束日期");
            arrColName.Add(convUsers.Password); arrCnName.Add("口令");
            arrColName.Add(convUsers.IdentityDesc); arrCnName.Add("身份描述");
            arrColName.Add(convUsers.Email); arrCnName.Add("电子邮箱");
            arrColName.Add(convUsers.IsGpUser); arrCnName.Add("是否平台用户");
            arrColName.Add(convUsers.RegisterPassword); arrCnName.Add("注册密码");
            arrColName.Add(convUsers.IsRegister); arrCnName.Add("是否注册");
            arrColName.Add(convUsers.RegisterDate); arrCnName.Add("注册日期");
            arrColName.Add(convUsers.IsAudit); arrCnName.Add("是否审核");
            arrColName.Add(convUsers.AuditUser); arrCnName.Add("审核人");
            arrColName.Add(convUsers.AuditDate); arrCnName.Add("审核日期");
            arrColName.Add(convUsers.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convUsers.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convUsers.Memo); arrCnName.Add("说明");
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
                objDT = clsvUsersBL.GetDataTable(strWhereCond);
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
        private void DispUsersListRegion()
        {
            divList.Visible = true;
            tabEditUsersRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditUsersRegion()
        {
            divList.Visible = false;
            tabEditUsersRegion.Visible = true;
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


    }
}