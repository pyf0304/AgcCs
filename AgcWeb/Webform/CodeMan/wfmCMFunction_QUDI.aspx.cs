
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmCMFunction_QUDI
表名:CMFunction
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:50:50
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
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
using AGC.BusinessLogic;using AGC.FunClass;


using AGC.BusinessLogicEx;


namespace AGC.Webform
{
    /// <summary>
    /// wfmCMFunction_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCode)
    /// </summary>
    public partial class wfmCMFunction_QUDI : System.Web.UI.Page
    {

        #region 页面启动函数
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPage_LoadCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {

                vsViewName = "函数名4Code维护";
                vsTabName = string.Format("{0}", clsvCMFunctionEN._CurrTabName);
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
                wucCMFunctionB1.SetDdl_ReturnTypeID();


                //wucCMFunctionB1.SetDdl_CodeTypeId();
                                
                clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq);
                
                vsSortCMFunctionBy = string.Format("{0} Asc", conCMFunction.FunctionName);

                if (qsFuncTypeId == enumFunctionType.ExGCFunc_13)
                {
                    ddlApplicationTypeIdq.Visible = false;
                    lblApplicationTypeIdq.Visible = false;
                
                    //绑定针对记录查询值的下拉控件
                    BindDdl4QueryValue();

                }
                else
                {
                    lblClassName.Visible = false;
                    ddlClassName.Visible = false;
                    lblTabName.Visible = false;
                    ddlTabName.Visible = false;
             
                }
                RestoreQueryValue();
                //2、显示无条件的表内容在GridView中
                //	1、组合界面条件串；
                string strWhereCond = CombineCMFunctionCondition();
                wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucCMFunctionB1.SetKeyReadOnly(true);
                DispCMFunctionListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsCMFunctionBL.objCommFun4BL = new clsCommFun4BL4CMFunction();
                seIsShowGCDiv = "false";
                SetStyle4Full();
            }
        }

        #endregion 页面启动函数

        protected void btnClose_Click(object sender, System.EventArgs e)
        {
            seIsShowGCDiv = "false";
            string strWhereCond = CombineCMFunctionCondition();
            wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
            SetStyle4Full();
        }
            #region 查询相关函数
            /// <summary>
            /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
            /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnQuery_ClickCode)
            /// </summary>
            /// <param name = "sender"></param>
            /// <param name = "e"></param>
            protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            wucCMFunction4GV1.PageIndex = 0;
            //把表记录的内容显示在GridView中
            string strWhereCond = CombineCMFunctionCondition();
            wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
            //记录查询框的值
            RecordQueryValue();
            if (seIsShowGCDiv == "true")
            {
                SetStyle4Half();
            }
            else
            {
                SetStyle4Full();
            }
        }
        /// <summary>
        /// 记录查询框的值
        /// </summary>
        private void RecordQueryValue()
        {
            if (string.IsNullOrEmpty(ddlTabName.SelectedValue) == false)
            {
                seTabNameq = ddlTabName.SelectedValue;
            }
            if (string.IsNullOrEmpty(ddlClassName.SelectedValue) == false)
            {
                seClassNameq = ddlClassName.SelectedValue;
            }     
        }
        /// <summary>
        /// 恢复已经记录的查询框的值
        /// </summary>
        private void RestoreQueryValue()
        {
            if (string.IsNullOrEmpty(seTabNameq) == false)
            {
               ddlTabName.SelectedValue = seTabNameq;
            }
            if (string.IsNullOrEmpty(seClassNameq) == false)
            {
                 ddlClassName.SelectedValue = seClassNameq;
            }
   

        }
        /// <summary>
        /// 绑定针对记录查询值的下拉控件
        /// </summary>
        private void BindDdl4QueryValue()
        {
            //clsCMFunctionBLEx.BindDdl_ClassNameEx(ddlClassName, clsPubVar.CurrSelPrjId);
            //clsCMFunctionBLEx.BindDdl_TabNameEx(ddlTabName, clsPubVar.CurrSelPrjId);

        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineCMFunctionCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = string.Format(" 1 = 1  ");
            //if (qsFuncTypeId == enumFunctionType.ExGCFunc_13)
            //{
            //    strWhereCond += string.Format(" And {0} = '{1}'", convCMFunction.PrjId, clsPubVar.CurrSelPrjId);
            //}
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
            try
            {
                //if (this.ddlCodeTypeIdq.SelectedValue != "" && this.ddlCodeTypeIdq.SelectedValue != "0")
                //{
                //    objvCMFunctionEN.CodeTypeId = this.ddlCodeTypeIdq.SelectedValue;
                //    strWhereCond += string.Format(" And {0} = '{1}'", clsvAppCodeTypeRelaEN.con_CodeTypeId, this.ddlCodeTypeIdq.SelectedValue);
                //}
                //if (this.ddlApplicationTypeIdq.SelectedValue != "" && this.ddlApplicationTypeIdq.SelectedValue != "0")
                //{
                //    objvCMFunctionEN.ApplicationTypeId = int.Parse(this.ddlApplicationTypeIdq.SelectedValue.ToString());
                //    strWhereCond += string.Format(" And {0} = {1}", 
                //        convCMFunction.ApplicationTypeId, 
                //        this.ddlApplicationTypeIdq.SelectedValue);
                //}

              
                if (this.txtCmFunctionIdq.Text.Trim() != "")
                {
                    objvCMFunctionEN.CmFunctionId = this.txtCmFunctionIdq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMFunction.CmFunctionId, this.txtCmFunctionIdq.Text.Trim());
                }

                if (this.txtFunctionNameq.Text.Trim() != "")
                {
                    objvCMFunctionEN.FunctionName = this.txtFunctionNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMFunction.FunctionName, this.txtFunctionNameq.Text.Trim());
                }
                clsvCMFunctionBL.CheckProperty4Condition(objvCMFunctionEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineCMFunctionCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
        /// </summary>
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                ViewState.Add("PageSize", strPageSize);
            }
        }

        #endregion 查询相关函数


        #region 排序相关函数

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortCMFunctionBy
        {
            get
            {
                string sSortCMFunctionBy;
                sSortCMFunctionBy = (string)ViewState["SortCMFunctionBy"];
                if (sSortCMFunctionBy == null)
                {
                    sSortCMFunctionBy = "";
                }
                return sSortCMFunctionBy;
            }
            set
            {
                string sSortCMFunctionBy = value;
                ViewState.Add("SortCMFunctionBy", sSortCMFunctionBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddCMFunctionRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddCMFunctionRecord()
        {
            wucCMFunctionB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelCMFunctionEdit.Text = "取消添加";
            wucCMFunctionB1.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
            
            DispEditCMFunctionRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddCMFunctionRecordSave()
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
            clsCMFunctionEN objCMFunctionEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucCMFunctionB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsCMFunctionEN objCMFunctionEN;	//定义对象
            objCMFunctionEN = new clsCMFunctionEN(wucCMFunctionB1.CmFunctionId);    //初始化新对象
                                                                                            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId)) //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000004)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToCMFunctionClass(objCMFunctionEN);        //把界面的值传到
   
            //objCMFunctionEN.CodeTypeId = enumCodeType.BusinessLogicEx_0021;
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsCMFunctionBL.CheckPropertyNew(objCMFunctionEN);
                //6、把数据实体层的数据存贮到数据库中
                clsCMFunctionBL.AddNewRecordBySql2(objCMFunctionEN);
                //绑定针对记录查询值的下拉控件
                BindDdl4QueryValue();
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
            //恢复已经记录的查询框的值
            RestoreQueryValue();

            string strWhereCond = CombineCMFunctionCondition();
            wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
          
            DispCMFunctionListRegion();
            wucCMFunctionB1.Clear();     //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFunctionEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddCMFunctionRecordSaveV5()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsCMFunctionEN objCMFunctionEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucCMFunctionB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000006)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsCMFunctionEN objCMFunctionEN;	//定义对象
            objCMFunctionEN = new clsCMFunctionEN(wucCMFunctionB1.CmFunctionId);    //初始化新对象
                                                                                            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId)) //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000007)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToCMFunctionClass(objCMFunctionEN);        //把界面的值传到
        
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsCMFunctionBL.CheckPropertyNew(objCMFunctionEN);
                //6、把数据实体层的数据存贮到数据库中
                clsCMFunctionBL.AddNewRecordBySql2(objCMFunctionEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI000008)添加记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中

            string strWhereCond = CombineCMFunctionCondition();
            wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
            DispCMFunctionListRegion();
            wucCMFunctionB1.Clear();     //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFunctionEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加相关函数


        #region 修改相关函数

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpdate4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {

            string strCmFunctionId = wucCMFunction4GV1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strCmFunctionId) == true) return;

            UpdateCMFunctionRecord(strCmFunctionId);
        }
        ///
        //protected void gvCMFunction_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    string strCmFunctionId = gvCMFunction.DataKeys[e.RowIndex]["CmFunctionId"].ToString();
        //    UpdateCMFunctionRecord(strCmFunctionId);
        //}

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strCmFunctionId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strCmFunctionId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strCmFunctionId == "") return;       //如果关键字为空就返回退出
                                                    //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsCMFunctionBL.IsExist(strCmFunctionId) == false)        //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[CMFunction]中,关键字为:[strCmFunctionId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN(strCmFunctionId);
            //4、获取类对象的所有属性；
            try
            {
                clsCMFunctionBL.GetCMFunction(ref objCMFunctionEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objCMFunctionEN", objCMFunctionEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromCMFunctionClass(objCMFunctionEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjCMFunctionEN">表实体类对象</param>
        protected void GetDataFromCMFunctionClass(clsCMFunctionEN pobjCMFunctionEN)
        {
            wucCMFunctionB1.CmFunctionId = pobjCMFunctionEN.CmFunctionId;// 函数Id4Code
            wucCMFunctionB1.FunctionName = pobjCMFunctionEN.FunctionName;// 函数名4Code
            //wucCMFunctionB1.ApplicationTypeId = pobjCMFunctionEN.ApplicationTypeId;// 函数签名
            wucCMFunctionB1.FunctionSignature = pobjCMFunctionEN.FunctionSignature;// 函数签名
            wucCMFunctionB1.ReturnTypeID = pobjCMFunctionEN.ReturnTypeId;// 返回类型ID
            //wucCMFunctionB1.FuncTypeId = pobjCMFunctionEN.FuncTypeId;// 函数类型ID
            //wucCMFunctionB1.CodeTypeId = pobjCMFunctionEN.CodeTypeId;// 函数类型ID

            wucCMFunctionB1.Memo = pobjCMFunctionEN.Memo;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateCMFunctionRecord(string strCmFunctionId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strCmFunctionId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucCMFunctionB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelCMFunctionEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditCMFunctionRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objCMFunctionEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateCMFunctionRecordSave(clsCMFunctionEN objCMFunctionEN)
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
            if (!wucCMFunctionB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToCMFunctionClass(objCMFunctionEN);        //把界面的值传到
           
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsCMFunctionBL.CheckPropertyNew(objCMFunctionEN);
                //4、把数据实体层的数据存贮到数据库中
                clsCMFunctionBL.UpdateBySql2(objCMFunctionEN);
                //绑定针对记录查询值的下拉控件
                BindDdl4QueryValue();

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
            //恢复已经记录的查询框的值
            RestoreQueryValue();
            string strWhereCond = CombineCMFunctionCondition();
            wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
           
            DispCMFunctionListRegion();
            wucCMFunctionB1.Clear();//添空控件中的内容
                                       //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFunctionEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_CMFunction{0}'", objCMFunctionEN.CmFunctionId.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objCMFunctionEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateCMFunctionRecordSaveV5(clsCMFunctionEN objCMFunctionEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucCMFunctionB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000012)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToCMFunctionClass(objCMFunctionEN);        //把界面的值传到
                                                                    //3.1、检查传进去的对象属性是否合法
            try
            {
                clsCMFunctionBL.CheckPropertyNew(objCMFunctionEN);
                //4、把数据实体层的数据存贮到数据库中
                clsCMFunctionBL.UpdateBySql2(objCMFunctionEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "修改记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            string strWhereCond = CombineCMFunctionCondition();
            wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
            DispCMFunctionListRegion();
            wucCMFunctionB1.Clear();//添空控件中的内容
                                       //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFunctionEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_CMFunction{0}'", objCMFunctionEN.CmFunctionId.ToString().Trim()), true);
            return true;
        }
        #endregion 修改相关函数


        #region 添加修改共用函数
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnOKUpd_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsCMFunctionEN objCMFunctionEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddCMFunctionRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddCMFunctionRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objCMFunctionEN = (clsCMFunctionEN)Session["objCMFunctionEN"];
                    UpdateCMFunctionRecordSave(objCMFunctionEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelCMFunctionEdit_Click(object sender, EventArgs e)
        {
            DispCMFunctionListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjCMFunctionEN">数据传输的目的类对象</param>
        protected void PutDataToCMFunctionClass(clsCMFunctionEN pobjCMFunctionEN)
        {
            pobjCMFunctionEN.CmFunctionId = wucCMFunctionB1.CmFunctionId;// 函数Id4Code
            pobjCMFunctionEN.FunctionName = wucCMFunctionB1.FunctionName;// 函数名4Code
            //pobjCMFunctionEN.ApplicationTypeId = wucCMFunctionB1.ApplicationTypeId;// 函数签名
            pobjCMFunctionEN.FunctionSignature = wucCMFunctionB1.FunctionSignature;// 函数签名
            pobjCMFunctionEN.ReturnTypeId = wucCMFunctionB1.ReturnTypeID;// 返回类型ID
            //if (qsFuncTypeId == enumFunctionType.ExGCFunc_13)
            //{
            //    pobjCMFunctionEN.FuncTypeId = enumFunctionType.ExGCFunc_13;
            //}
            //else
            //{
            //    pobjCMFunctionEN.FuncTypeId = wucCMFunctionB1.FuncTypeId;// 函数类型ID
            //}
            //pobjCMFunctionEN.CodeTypeId = wucCMFunctionB1.CodeTypeId;// 函数类型ID
            //pobjCMFunctionEN.OrderNum = wucCMFunctionB1.OrderNum;// 序号
            pobjCMFunctionEN.UpdDate = wucCMFunctionB1.UpdDate;// 修改日期
            pobjCMFunctionEN.UpdUser = wucCMFunctionB1.UpdUser;// 修改者
            pobjCMFunctionEN.Memo = wucCMFunctionB1.Memo;// 说明
            //pobjCMFunctionEN.PrjId = clsPubVar.CurrSelPrjId;
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {

            List<string> lstCmFunctionId = wucCMFunction4GV1.GetAllCheckedKeysFromGv();
            if (lstCmFunctionId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strCmFunctionId in lstCmFunctionId)
                {
                    clsCMFunctionBLEx.DelRecordEx(strCmFunctionId, clsPubVar.CurrSelPrjId);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            string strWhereCond = CombineCMFunctionCondition();
            wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
        }
        /// <summary>
        /// 事件函数:在GridView中，进行行删除(RowDeleting)
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowDeleting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        //protected void gvCMFunction_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    string strCmFunctionId = gvCMFunction.DataKeys[e.RowIndex]["CmFunctionId"].ToString();
        //    DeleteCMFunctionRecord(strCmFunctionId);
        //}
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strCmFunctionId">给定关键字</param>
        protected void DeleteCMFunctionRecord(string strCmFunctionId)
        {
            try
            {
                clsCMFunctionBL.DelRecord(strCmFunctionId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }

            string strWhereCond = CombineCMFunctionCondition();
            wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
        }
        #endregion 删除相关函数


        #region 导出函数

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }


        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vCMFunction]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineCMFunctionCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "CMFunction信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convCMFunction.CmFunctionId); arrCnName.Add("函数Id4Code");
            arrColName.Add(convCMFunction.FunctionName); arrCnName.Add("函数名4Code");
            arrColName.Add(convCMFunction.FunctionSignature); arrCnName.Add("函数签名");
            arrColName.Add(convCMFunction.ReturnTypeId); arrCnName.Add("返回类型ID");


            arrColName.Add(convCMFunction.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convCMFunction.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convCMFunction.Memo); arrCnName.Add("说明");
            //arrColName.Add(convCMFunction.ReturnTypeName); arrCnName.Add("返回类型名");
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
                objDT = clsvCMFunctionBL.GetDataTable(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispEditCMFunctionRegion()
        {
            divList.Visible = false;
            tabEditCMFunctionRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispCMFunctionListRegion()
        {
            divList.Visible = true;
            tabEditCMFunctionRegion.Visible = false;
        }
        #endregion 布局控制函数


        #region 错误处理函数

        /// <summary>
        /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenErrMessageSession)
        /// </summary>
        protected string seErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)Session["ErrMessage"];
                if (strErrMessage == null)
                {
                    strErrMessage = "";
                }
                return strErrMessage;
            }
            set
            {
                string strErrMessage = value;
                Session.Add("ErrMessage", strErrMessage);
            }
        }


        /// <summary>
        /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBackLinkStrSession)
        /// </summary>
        protected string seBackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }

        #endregion 错误处理函数


        #region 权限处理函数

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
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
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
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

        protected string seTabNameq
        {
            get
            {
                string sTabNameq;
                sTabNameq = (string)Session["TabNameq"];
                if (sTabNameq == null)
                {
                    sTabNameq = "";
                }
                return sTabNameq;
            }
            set
            {
                string sTabNameq = value;
                Session.Add("TabNameq", sTabNameq);
            }
        }
        protected string seIsShowGCDiv
        {
            get
            {
                string sIsShowGCDiv;
                sIsShowGCDiv = (string)Session["IsShowGCDiv"];
                if (sIsShowGCDiv == null)
                {
                    sIsShowGCDiv = "";
                }
                return sIsShowGCDiv;
            }
            set
            {
                string sIsShowGCDiv = value;
                Session.Add("IsShowGCDiv", sIsShowGCDiv);
            }
        }
        protected string seClassNameq
        {
            get
            {
                string sClassNameq;
                sClassNameq = (string)Session["ClassNameq"];
                if (sClassNameq == null)
                {
                    sClassNameq = "";
                }
                return sClassNameq;
            }
            set
            {
                string sClassNameq = value;
                Session.Add("ClassNameq", sClassNameq);
            }
        }
                     

        /// <summary>
        /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。
        /// 姓名:
        /// 日期:
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
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
        /// 函数类型
        /// </summary>
        private string qsFuncTypeId
        {
            get
            {
                string strFuncTypeId = Request.QueryString["FuncTypeId"] ?? "".ToString();
                if ((strFuncTypeId != null) && (strFuncTypeId != ""))
                {
                    return strFuncTypeId;
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 与权限相关的界面编号
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号


        /// <summary>
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceLevelProperty)
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
        /// Session属性:登录的用户ID,用于检查用户权限
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenLoginUserSession)
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



        #endregion 权限处理函数

  
        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public string conCurrPageName
        {
            get
            {
                return "wfmCMFunction_QUDI.aspx";
            }
        }

        protected void btnEditPara_Click(object sender, EventArgs e)
        {
            string strCmFunctionId = wucCMFunction4GV1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strCmFunctionId) == true) return;
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            //clsCMFuncParaRelaEN objCMFuncParaRela = clsCMFuncParaRelaBL.GetObjBymId(long.Parse(strMid));
            string strHtml = string.Format("wfmCMFuncParaRela_QUDI.aspx?{0}={1}&FuncTypeId={2}",
                conCMFuncParaRela.CmFunctionId,
               strCmFunctionId, qsFuncTypeId);
            Response.Redirect(strHtml);
        }

        protected void btnCloneNewRec4Gv_Click(object sender, EventArgs e)
        {
            List<string> lstCmFunctionId = wucCMFunction4GV1.GetAllCheckedKeysFromGv();
            if (lstCmFunctionId == null) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            foreach (string strFuncId4GC in lstCmFunctionId)
            {
                try
                {
                    clsCMFunctionEN objCMFunctionEN = clsCMFunctionBLEx.CloneRecord(strFuncId4GC, clsCommonSession.UserId);               
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                }
            }
            string strWhereCond = CombineCMFunctionCondition();
            wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
        }
        /// <summary>
        /// 从列表中获取所有选择的关键字
        /// </summary>
        /// <returns>返回所有选择的关键字列表</returns>
        //private List<string> GetAllCheckedKeysFromGv()
        //   {
        //       List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvCMFunction, "chkCheckRec", conCMFunction.CmFunctionId);
        //       if (lstKeyValues.Count == 0)
        //       {
        //           clsCommonJsFunc.Alert(this, "没有选择记录，请选择一个有效的表记录!");
        //           return null;
        //       }
        //       List<string> arrCmFunctionIdLst = new List<string>();
        //       foreach (string strKeyValue in lstKeyValues)
        //       {
        //           string[] strKeys = strKeyValue.Split(',');
        //           string strCmFunctionId = strKeys[0].ToString();
        //           arrCmFunctionIdLst.Add(strCmFunctionId);
        //       }
        //       return arrCmFunctionIdLst;
        //   }

    
        private void SetStyle4Full()
        {
            divLeft.Style.Clear();
            divLeft.Style.Add("width", "100%");
      
            string strJS = string.Format("SetStyle4Full();");
            this.ClientScript.RegisterStartupScript(this.GetType(), "SetStyle4Full", strJS, true);
        }


        private void SetStyle4Half()
        {
            divLeft.Style.Clear();
            divLeft.Style.Add("width", "45%");
            divLeft.Style.Add("float", "left");

      
            string strJS = string.Format("SetStyle4Half();");
            this.ClientScript.RegisterStartupScript(this.GetType(), "SetStyle4Half", strJS, true);
        }
    
            protected void BindGv_CMFunction()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombineCMFunctionCondition();
                //	2、调用控件中的绑定GridView函数；
                wucCMFunction4GV1.BindGv_CMFunction(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucExamType4Gv1.SetGvVisibility(conExamType.UpdDate, false);
                //wucExamType4Gv1.SetGvVisibility(conExamType.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }

    }
}