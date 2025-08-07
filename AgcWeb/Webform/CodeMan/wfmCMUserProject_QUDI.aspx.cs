
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmCMUserProject_QUDI
界面名:wfmCMUserProject_QUDI(00050260)
生成代码版本:2019.10.24.1
生成日期:2019/11/07 16:34:40
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理
模块英文名:CodeMan
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
    /// wfmCMUserProject_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmCMUserProject_QUDI : System.Web.UI.Page
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

                vsViewName = "CM用户工程维护";
                vsTabName = string.Format("{0}", clsvCMUserProjectEN._CurrTabName);
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
                wucCMUserProject1.SetDdl_UserId();
                wucCMUserProject1.SetDdl_CmPrjId(clsPubVar.CurrSelPrjId);
                clsUsersBL.BindDdl_UserId(ddlUserIdq);
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjIdq, clsPubVar.CurrSelPrjId);
                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq);
                wucvCMUserProject4Gv1.SetSortBy(string.Format("{0} Asc", convCMUserProject.mId));
                //2、显示无条件的表内容在GridView中
                BindGv_vCMUserProject();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                DispCMUserProjectListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsCMUserProjectBL.objCommFun4BL = new clsCommFun4BL4CMUserProject();
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
            wucvCMUserProject4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vCMUserProject();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vCMUserProject()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevCMUserProjectCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvCMUserProject4Gv1.BindGv_CMUserProject(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvCMUserProject4Gv1.SetGvVisibility(convCMUserProject.UpdDate, false);
                //wucvCMUserProject4Gv1.SetGvVisibility(convCMUserProject.UpdUser, false);
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
        protected string CombinevCMUserProjectCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
            try
            {
                if (this.ddlUserIdq.SelectedValue != "" && this.ddlUserIdq.SelectedValue != "0")
                {
                    objvCMUserProjectEN.UserId = this.ddlUserIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMUserProject.UserId, this.ddlUserIdq.SelectedValue);
                }
                if (this.ddlCmPrjIdq.SelectedValue != "" && this.ddlCmPrjIdq.SelectedValue != "0")
                {
                    objvCMUserProjectEN.CmPrjId = this.ddlCmPrjIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMUserProject.CmPrjId, this.ddlCmPrjIdq.SelectedValue);
                }
                if (this.txtCmPrjNameq.Text.Trim() != "")
                {
                    objvCMUserProjectEN.CmPrjName = this.txtCmPrjNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMUserProject.CmPrjName, this.txtCmPrjNameq.Text.Trim());
                }
                if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
                {
                    objvCMUserProjectEN.PrjId = this.ddlPrjIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMUserProject.PrjId, this.ddlPrjIdq.SelectedValue);
                }
                if (this.ddlApplicationTypeIdq.SelectedValue != "" && this.ddlApplicationTypeIdq.SelectedValue != "0")
                {
                    objvCMUserProjectEN.ApplicationTypeId = int.Parse(this.ddlApplicationTypeIdq.SelectedValue.ToString());
                    strWhereCond += string.Format(" And {0} = {1}", convCMUserProject.ApplicationTypeId, this.ddlApplicationTypeIdq.SelectedValue);
                }
                objvCMUserProjectEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineCMUserProjectCondition)时出错!请联系管理员!" + objException.Message);
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
            AddCMUserProjectRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void AddCMUserProjectRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelCMUserProjectEdit.Text = "取消添加";
            //wucCMUserProject1.mId = clsCMUserProjectBL.GetMaxStrId_S();
            wucCMUserProject1.UserId = clsCommonSession.UserId;
            DispEditCMUserProjectRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddCMUserProjectRecordSave()
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
            clsCMUserProjectEN objCMUserProjectEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucCMUserProject1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsCMUserProjectEN objCMUserProjectEN;	//定义对象
            objCMUserProjectEN = new clsCMUserProjectEN();  //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            try
            {
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataToCMUserProjectClass(objCMUserProjectEN);        //把界面的值传到
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
                objCMUserProjectEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objCMUserProjectEN.AddNewRecord();
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
            BindGv_vCMUserProject();
            DispCMUserProjectListRegion();
            wucCMUserProject1.Clear();      //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMUserProjectEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId = wucvCMUserProject4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            UpdateCMUserProjectRecord(lngmId);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdateCMUserProjectRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelCMUserProjectEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditCMUserProjectRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ShowData)
        /// </summary>
        /// <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(long lngmId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngmId == 0) return;        //如果关键字为空就返回退出
                                            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsCMUserProjectBL.IsExist(lngmId) == false)        //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[CMUserProject]中,关键字为:[lngmId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsCMUserProjectEN objCMUserProjectEN = new clsCMUserProjectEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsCMUserProjectBL.GetCMUserProject(ref objCMUserProjectEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objCMUserProjectEN", objCMUserProjectEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromCMUserProjectClass(objCMUserProjectEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjCMUserProjectEN">表实体类对象</param>
        protected void GetDataFromCMUserProjectClass(clsCMUserProjectEN pobjCMUserProjectEN)
        {
            wucCMUserProject1.UserId = pobjCMUserProjectEN.UserId;// 用户Id
            wucCMUserProject1.CmPrjId = pobjCMUserProjectEN.CmPrjId;// CM工程Id
            wucCMUserProject1.ProjectPath = pobjCMUserProjectEN.ProjectPath;// 工程路径
            wucCMUserProject1.Memo = pobjCMUserProjectEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvCMUserProject4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateCMUserProjectRecord(lngmId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objCMUserProjectEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateCMUserProjectRecordSave(clsCMUserProjectEN objCMUserProjectEN)
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
            if (!wucCMUserProject1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            try
            {
                //2、把值从界面层传到逻辑层或数据实体层
                PutDataToCMUserProjectClass(objCMUserProjectEN);        //把界面的值传到
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
                objCMUserProjectEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objCMUserProjectEN.Update();
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
            BindGv_vCMUserProject();
            DispCMUserProjectListRegion();
            wucCMUserProject1.Clear();//添空控件中的内容
                                      //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMUserProjectEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_CMUserProject{0}'", objCMUserProjectEN.mId.ToString().Trim()), true);
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
            clsCMUserProjectEN objCMUserProjectEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddCMUserProjectRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddCMUserProjectRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objCMUserProjectEN = (clsCMUserProjectEN)Session["objCMUserProjectEN"];
                    UpdateCMUserProjectRecordSave(objCMUserProjectEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjCMUserProjectEN">数据传输的目的类对象</param>
        protected void PutDataToCMUserProjectClass(clsCMUserProjectEN pobjCMUserProjectEN)
        {
            pobjCMUserProjectEN.SetUserId(wucCMUserProject1.UserId)// 用户Id
            .SetCmPrjId(wucCMUserProject1.CmPrjId)// CM工程Id
            .SetProjectPath(wucCMUserProject1.ProjectPath)// 工程路径
            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))//(字段类型:string,字段长度:20,是否可空:20)
            .SetUpdUserId(clsCommonSession.UserId)//(字段类型:string,字段长度:20,是否可空:20)
            .SetMemo(wucCMUserProject1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelCMUserProjectEdit_Click(object sender, EventArgs e)
        {
            DispCMUserProjectListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<long> lstMId = wucvCMUserProject4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsCMUserProjectBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vCMUserProject();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvCMUserProject4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteCMUserProjectRecord(lngmId);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteCMUserProjectRecord(long lngmId)
        {
            try
            {
                clsCMUserProjectBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vCMUserProject();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vCMUserProject]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevCMUserProjectCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "CMUserProject信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convCMUserProject.UserName); arrCnName.Add("用户名");
            arrColName.Add(convCMUserProject.CmPrjName); arrCnName.Add("CM工程名");
            arrColName.Add(convCMUserProject.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convCMUserProject.ApplicationTypeSimName); arrCnName.Add("应用程序类型简称");
            arrColName.Add(convCMUserProject.ProjectFileName); arrCnName.Add("工程文件名");
            arrColName.Add(convCMUserProject.ProjectPath); arrCnName.Add("工程路径");
            arrColName.Add(convCMUserProject.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convCMUserProject.Memo); arrCnName.Add("说明");
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
                objDT = clsvCMUserProjectBL.GetDataTable(strWhereCond);
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
        private void DispCMUserProjectListRegion()
        {
            divList.Visible = true;
            tabEditCMUserProjectRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditCMUserProjectRegion()
        {
            divList.Visible = false;
            tabEditCMUserProjectRegion.Visible = true;
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

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnCopyRecord_Click4OneKeyword)
        /// </summary>
        protected void btnCopyRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId = wucvCMUserProject4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            CopyRecord(lngmId);
        }

        /// <summary>
        /// 复制记录,把给定关键字的记录内容复制一个新记录，把名称字段值的前面加上"Copy_"
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CopyRecord)
        /// </summary>
        protected void CopyRecord(long lngmId)
        {
            try
            {
                K_mId_CMUserProject myKey = new K_mId_CMUserProject(lngmId);
                clsCMUserProjectEN objCMUserProjectEN = myKey.GetObj();
                objCMUserProjectEN.AddNewRecord();
                BindGv_vCMUserProject();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在克隆记录时出错！错误：{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }

    }
}