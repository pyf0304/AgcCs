
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmFunction4Code_FuncGC
表名:Function4Code
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

using AGC.web.treeview;
using com.taishsoft.web.treeview;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFunction4Code_FuncGC 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCode)
    /// </summary>
    public partial class wfmFunction4Code_FuncGC : System.Web.UI.Page
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
                vsTabName = string.Format("{0}", clsvFunction4CodeEN._CurrTabName);
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
                wucFunction4CodeB1.SetDdl_ReturnTypeID();
                wucFunction4CodeB1.SetDdl_FuncTypeID();
                wucFunction4CodeB1.SetDdl_ApplicationTypeId();
          
                clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeId);
                clsFuncAccessModeBL.BindDdl_FuncAccessModeIdCache(ddlFuncAccessModeId);
                vsSortFunction4CodeBy = string.Format("{0} Asc", conFunction4Code.FuncName4Code);

                if (qsFuncTypeId == enumFunctionType.ExGCFunc_13)
                {
                 
                    ddlApplicationTypeId.Visible = false;
                    btnApplicationTypeId.Visible = false;
                    btnSynchToFunction4GC.Visible = false;
                  
                    //绑定针对记录查询值的下拉控件             

                }
              
                //2、显示无条件的表内容在GridView中
                //	1、组合界面条件串；
    
                BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucFunction4CodeB1.SetKeyReadOnly(true);
                DispFunction4CodeListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsFunction4CodeBL.objCommFun4BL = new clsCommFun4BL4Function4Code();
                seIsShowGCDiv = "true";
                SetStyle4Full();
            }
        }

        #endregion 页面启动函数

        protected void btnClose_Click(object sender, System.EventArgs e)
        {
            seIsShowGCDiv = "false";
            string strWhereCond = CombineFunction4CodeCondition();
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
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
            //wucFunction4Code4GV1.PageIndex = 0;
            //把表记录的内容显示在GridView中
            string strWhereCond = CombineFunction4CodeCondition();
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();


        }
     


        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineFunction4CodeCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = string.Format(" 1 = 1 and {0}='0' and {1}='0' ",
                convFunction4Code.IsAsyncFunc,
                convFunction4Code.IsSysFunction);
            if (qsFuncTypeId == enumFunctionType.ExGCFunc_13)
            {
                strWhereCond += string.Format(" And {0} = '{1}'", convFunction4Code.PrjId, clsPubVar.CurrSelPrjId);
            }
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
            try
            {              
                
                if (this.txtFuncId4Codeq.Text.Trim() != "")
                {
                    objvFunction4CodeEN.FuncId4Code = this.txtFuncId4Codeq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFunction4Code.FuncId4Code, this.txtFuncId4Codeq.Text.Trim());
                }

                if (this.txtFuncName4Codeq.Text.Trim() != "")
                {
                    objvFunction4CodeEN.FuncName4Code = this.txtFuncName4Codeq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFunction4Code.FuncName4Code, this.txtFuncName4Codeq.Text.Trim());
                }
               
                clsvFunction4CodeBL.CheckProperty4Condition(objvFunction4CodeEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineFunction4CodeCondition)时出错!请联系管理员!" + objException.Message);
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
        protected string vsSortFunction4CodeBy
        {
            get
            {
                string sSortFunction4CodeBy;
                sSortFunction4CodeBy = (string)ViewState["SortFunction4CodeBy"];
                if (sSortFunction4CodeBy == null)
                {
                    sSortFunction4CodeBy = "";
                }
                return sSortFunction4CodeBy;
            }
            set
            {
                string sSortFunction4CodeBy = value;
                ViewState.Add("SortFunction4CodeBy", sSortFunction4CodeBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddFunction4CodeRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddFunction4CodeRecord()
        {
            wucFunction4CodeB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelFunction4CodeEdit.Text = "取消添加";
            wucFunction4CodeB1.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
            wucFunction4CodeB1.OrderNum = 1;
            DispEditFunction4CodeRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddFunction4CodeRecordSave()
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
            clsFunction4CodeEN objFunction4CodeEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFunction4CodeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFunction4CodeEN objFunction4CodeEN;	//定义对象
            objFunction4CodeEN = new clsFunction4CodeEN(wucFunction4CodeB1.FuncId4Code);    //初始化新对象
                                                                                            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code)) //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000004)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFunction4CodeClass(objFunction4CodeEN);        //把界面的值传到
            objFunction4CodeEN.RootFuncId = objFunction4CodeEN.FuncId4Code;
            objFunction4CodeEN.CodeTypeId = enumCodeType.BusinessLogicEx_0021;
            if (qsFuncTypeId == enumFunctionType.ExGCFunc_13)
            {
                objFunction4CodeEN.FuncPurposeId = enumFunctionPurpose.ForFunctionGene_02;
            }
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFunction4CodeBL.CheckPropertyNew(objFunction4CodeEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFunction4CodeBL.AddNewRecordBySql2(objFunction4CodeEN);
                //绑定针对记录查询值的下拉控件
           
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
      

            string strWhereCond = CombineFunction4CodeCondition();
            
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
            DispFunction4CodeListRegion();
            wucFunction4CodeB1.Clear();     //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunction4CodeEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddFunction4CodeRecordSaveV5()
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
            clsFunction4CodeEN objFunction4CodeEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFunction4CodeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000006)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFunction4CodeEN objFunction4CodeEN;	//定义对象
            objFunction4CodeEN = new clsFunction4CodeEN(wucFunction4CodeB1.FuncId4Code);    //初始化新对象
                                                                                            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code)) //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000007)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFunction4CodeClass(objFunction4CodeEN);        //把界面的值传到
            objFunction4CodeEN.RootFuncId = objFunction4CodeEN.FuncId4Code;
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFunction4CodeBL.CheckPropertyNew(objFunction4CodeEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFunction4CodeBL.AddNewRecordBySql2(objFunction4CodeEN);
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

            string strWhereCond = CombineFunction4CodeCondition();
            
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
            DispFunction4CodeListRegion();
            wucFunction4CodeB1.Clear();     //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunction4CodeEdit.Text = "取消编辑";
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
            if (vsTreeNodeType != conFunction4Code._CurrTabName)
            {
                clsCommonJsFunc.Alert(this, "请选择一个函数");
                return;
            }
            string strFuncId4Code = vsKeyId;
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return;

            UpdateFunction4CodeRecord(strFuncId4Code);
        }
        ///
        //protected void gvFunction4Code_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    string strFuncId4Code = gvFunction4Code.DataKeys[e.RowIndex]["FuncId4Code"].ToString();
        //    UpdateFunction4CodeRecord(strFuncId4Code);
        //}

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strFuncId4Code">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strFuncId4Code)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strFuncId4Code == "") return;       //如果关键字为空就返回退出
                                                    //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsFunction4CodeBL.IsExist(strFuncId4Code) == false)        //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[Function4Code]中,关键字为:[strFuncId4Code]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN(strFuncId4Code);
            //4、获取类对象的所有属性；
            try
            {
                clsFunction4CodeBL.GetFunction4Code(ref objFunction4CodeEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objFunction4CodeEN", objFunction4CodeEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromFunction4CodeClass(objFunction4CodeEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjFunction4CodeEN">表实体类对象</param>
        protected void GetDataFromFunction4CodeClass(clsFunction4CodeEN pobjFunction4CodeEN)
        {
            wucFunction4CodeB1.FuncId4Code = pobjFunction4CodeEN.FuncId4Code;// 函数Id4Code
            wucFunction4CodeB1.FuncName4Code = pobjFunction4CodeEN.FuncName4Code;// 函数名4Code
            wucFunction4CodeB1.FuncCHName4Code = pobjFunction4CodeEN.FuncCHName4Code;// 函数中文名4Code
            wucFunction4CodeB1.ApplicationTypeId = pobjFunction4CodeEN.ApplicationTypeId;// 函数签名
            //wucFunction4CodeB1.FunctionSignature = pobjFunction4CodeEN.FunctionSignature;// 函数签名
            wucFunction4CodeB1.ReturnTypeID = pobjFunction4CodeEN.ReturnTypeId;// 返回类型ID
            wucFunction4CodeB1.ReturnTypeNameCustom = pobjFunction4CodeEN.ReturnTypeNameCustom;// 返回类型ID
            wucFunction4CodeB1.FuncTypeId = pobjFunction4CodeEN.FuncTypeId;// 函数类型ID
            //wucFunction4CodeB1.CodeTypeId = pobjFunction4CodeEN.CodeTypeId;// 函数类型ID
            wucFunction4CodeB1.ClsName = pobjFunction4CodeEN.ClsName;// 函数类型ID
            wucFunction4CodeB1.TabName = pobjFunction4CodeEN.TabName;// 函数类型ID

            wucFunction4CodeB1.OrderNum = pobjFunction4CodeEN.OrderNum;// 序号

            wucFunction4CodeB1.Memo = pobjFunction4CodeEN.Memo;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateFunction4CodeRecord(string strFuncId4Code)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strFuncId4Code);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucFunction4CodeB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelFunction4CodeEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditFunction4CodeRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objFunction4CodeEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateFunction4CodeRecordSave(clsFunction4CodeEN objFunction4CodeEN)
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
            if (!wucFunction4CodeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFunction4CodeClass(objFunction4CodeEN);        //把界面的值传到
            if (objFunction4CodeEN.CodeTypeId == enumCodeType.BusinessLogicEx_0021)
            {
                objFunction4CodeEN.RootFuncId = objFunction4CodeEN.FuncId4Code;
            }
                                                                    //3.1、检查传进去的对象属性是否合法
            try
            {
                clsFunction4CodeBL.CheckPropertyNew(objFunction4CodeEN);
                //4、把数据实体层的数据存贮到数据库中
                clsFunction4CodeBL.UpdateBySql2(objFunction4CodeEN);
                //绑定针对记录查询值的下拉控件
            

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
       
            string strWhereCond = CombineFunction4CodeCondition();

            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
            wucTreeView4PrjTab.SelectNodeEx(vsKeyId);
            DispFunction4CodeListRegion();
            wucFunction4CodeB1.Clear();//添空控件中的内容
                                       //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunction4CodeEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_Function4Code{0}'", objFunction4CodeEN.FuncId4Code.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objFunction4CodeEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateFunction4CodeRecordSaveV5(clsFunction4CodeEN objFunction4CodeEN)
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
            if (!wucFunction4CodeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000012)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFunction4CodeClass(objFunction4CodeEN);        //把界面的值传到
                                                                    //3.1、检查传进去的对象属性是否合法
            try
            {
                clsFunction4CodeBL.CheckPropertyNew(objFunction4CodeEN);
                //4、把数据实体层的数据存贮到数据库中
                clsFunction4CodeBL.UpdateBySql2(objFunction4CodeEN);
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
            string strWhereCond = CombineFunction4CodeCondition();
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
            DispFunction4CodeListRegion();
            wucFunction4CodeB1.Clear();//添空控件中的内容
                                       //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunction4CodeEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_Function4Code{0}'", objFunction4CodeEN.FuncId4Code.ToString().Trim()), true);
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
            clsFunction4CodeEN objFunction4CodeEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddFunction4CodeRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddFunction4CodeRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objFunction4CodeEN = (clsFunction4CodeEN)Session["objFunction4CodeEN"];
                    UpdateFunction4CodeRecordSave(objFunction4CodeEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelFunction4CodeEdit_Click(object sender, EventArgs e)
        {
            DispFunction4CodeListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjFunction4CodeEN">数据传输的目的类对象</param>
        protected void PutDataToFunction4CodeClass(clsFunction4CodeEN pobjFunction4CodeEN)
        {
            pobjFunction4CodeEN.FuncId4Code = wucFunction4CodeB1.FuncId4Code;// 函数Id4Code
            pobjFunction4CodeEN.FuncName4Code = wucFunction4CodeB1.FuncName4Code;// 函数名4Code
            pobjFunction4CodeEN.FuncCHName4Code = wucFunction4CodeB1.FuncCHName4Code;// 函数中文名4Code
            pobjFunction4CodeEN.ApplicationTypeId = wucFunction4CodeB1.ApplicationTypeId;// 函数签名
            //pobjFunction4CodeEN.FunctionSignature = wucFunction4CodeB1.FunctionSignature;// 函数签名
            pobjFunction4CodeEN.ReturnTypeId = wucFunction4CodeB1.ReturnTypeID;// 返回类型ID
            pobjFunction4CodeEN.ReturnTypeNameCustom = wucFunction4CodeB1.ReturnTypeNameCustom;// 返回类型ID
            if (qsFuncTypeId == enumFunctionType.ExGCFunc_13)
            {
                pobjFunction4CodeEN.FuncTypeId = enumFunctionType.ExGCFunc_13;
            }
            else
            {
                pobjFunction4CodeEN.FuncTypeId = wucFunction4CodeB1.FuncTypeId;// 函数类型ID
            }
            //pobjFunction4CodeEN.CodeTypeId = wucFunction4CodeB1.CodeTypeId;// 函数类型ID
            pobjFunction4CodeEN.ClsName = wucFunction4CodeB1.ClsName;// 函数类型ID
            pobjFunction4CodeEN.TabName = wucFunction4CodeB1.TabName;// 函数类型ID
            pobjFunction4CodeEN.OrderNum = wucFunction4CodeB1.OrderNum;// 序号
            pobjFunction4CodeEN.UpdDate = wucFunction4CodeB1.UpdDate;// 修改日期
            pobjFunction4CodeEN.UpdUser = wucFunction4CodeB1.UpdUser;// 修改者
            pobjFunction4CodeEN.Memo = wucFunction4CodeB1.Memo;// 说明
            pobjFunction4CodeEN.PrjId = clsPubVar.CurrSelPrjId;
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {

            if (vsTreeNodeType != conFunction4Code._CurrTabName)
            {
                clsCommonJsFunc.Alert(this, "请选择一个函数");
                return;
            }
            string strFuncId4Code = vsKeyId;
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return;
            lblMsgList.Text = "";
            try
            {
                clsFunction4CodeBLEx.DelRecordEx(strFuncId4Code);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
      
            //string strWhereCond = CombineFunction4CodeCondition();
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
        }
        /// <summary>
        /// 事件函数:在GridView中，进行行删除(RowDeleting)
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowDeleting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        //protected void gvFunction4Code_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    string strFuncId4Code = gvFunction4Code.DataKeys[e.RowIndex]["FuncId4Code"].ToString();
        //    DeleteFunction4CodeRecord(strFuncId4Code);
        //}
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strFuncId4Code">给定关键字</param>
        protected void DeleteFunction4CodeRecord(string strFuncId4Code)
        {
            try
            {
                clsFunction4CodeBL.DelRecord(strFuncId4Code);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }

            string strWhereCond = CombineFunction4CodeCondition();
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vFunction4Code]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineFunction4CodeCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "Function4Code信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convFunction4Code.FuncId4Code); arrCnName.Add("函数Id4Code");
            arrColName.Add(convFunction4Code.FuncName4Code); arrCnName.Add("函数名4Code");
            arrColName.Add(convFunction4Code.FuncCHName4Code); arrCnName.Add("函数中文名4Code");
            arrColName.Add(convFunction4Code.FunctionSignature); arrCnName.Add("函数签名");
            arrColName.Add(convFunction4Code.ReturnTypeId); arrCnName.Add("返回类型ID");
            arrColName.Add(convFunction4Code.FuncTypeId); arrCnName.Add("函数类型ID");
            arrColName.Add(convFunction4Code.FuncTypeName); arrCnName.Add("函数类型名");

            arrColName.Add(convFunction4Code.OrderNum); arrCnName.Add("序号");
            arrColName.Add(convFunction4Code.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convFunction4Code.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convFunction4Code.Memo); arrCnName.Add("说明");
            arrColName.Add(convFunction4Code.ReturnTypeName); arrCnName.Add("返回类型名");
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
                objDT = clsvFunction4CodeBL.GetDataTable(strWhereCond);
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
        private void DispEditFunction4CodeRegion()
        {
            divList.Visible = false;
            tabEditFunction4CodeRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispFunction4CodeListRegion()
        {
            divList.Visible = true;
            tabEditFunction4CodeRegion.Visible = false;
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

        protected string seTabName_q
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
        protected string seClassName_q
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

        protected string seRootFuncId_q
        {
            get
            {
                string sRootFuncIdq;
                sRootFuncIdq = (string)Session["RootFuncIdq"];
                if (sRootFuncIdq == null)
                {
                    sRootFuncIdq = "";
                }
                return sRootFuncIdq;
            }
            set
            {
                string sRootFuncIdq = value;
                Session.Add("RootFuncIdq", sRootFuncIdq);
            }
        }
        protected string seCodeTypeId_q
        {
            get
            {
                string sCodeTypeIdq;
                sCodeTypeIdq = (string)Session["CodeTypeIdq"];
                if (sCodeTypeIdq == null)
                {
                    sCodeTypeIdq = "";
                }
                return sCodeTypeIdq;
            }
            set
            {
                string sCodeTypeIdq = value;
                Session.Add("CodeTypeIdq", sCodeTypeIdq);
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
                return "wfmFunction4Code_FuncGC.aspx";
            }
        }

        protected void btnEditPara_Click(object sender, EventArgs e)
        {
            if (vsTreeNodeType != conFunction4Code._CurrTabName)
            {
                clsCommonJsFunc.Alert(this, "请选择一个函数");
                return;
            }
            string strFuncId4Code = vsKeyId;
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return;
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            //clsFuncParaRelaEN objFuncParaRela = clsFuncParaRelaBL.GetObjBymId(long.Parse(strMid));
            string strHtml = string.Format("wfmFuncParaRela_QUDI.aspx?{0}={1}&FuncTypeId={2}&PrevPage=wfmFunction4Code_FuncGC",
                conFuncParaRela.FuncId4Code,
               strFuncId4Code, qsFuncTypeId);
            Response.Redirect(strHtml);
        }

        protected void btnCloneNewRec4Gv_Click(object sender, EventArgs e)
        {
            if (vsTreeNodeType != conFunction4Code._CurrTabName)
            {
                clsCommonJsFunc.Alert(this, "请选择一个函数");
                return;
            }
            string strFuncId4Code = vsKeyId;
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return;

            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；

            try
            {
                clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBLEx.CloneRecord(strFuncId4Code, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
            wucTreeView4PrjTab.SelectNodeEx(vsKeyId);
            //string strWhereCond = CombineFunction4CodeCondition();
            //wucFunction4Code4GV1.BindGv_Function4Code(strWhereCond, 0);
        }
        /// <summary>
        /// 从列表中获取所有选择的关键字
        /// </summary>
        /// <returns>返回所有选择的关键字列表</returns>
        //private List<string> GetAllCheckedKeysFromGv()
        //   {
        //       List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvFunction4Code, "chkCheckRec", conFunction4Code.FuncId4Code);
        //       if (lstKeyValues.Count == 0)
        //       {
        //           clsCommonJsFunc.Alert(this, "没有选择记录，请选择一个有效的表记录!");
        //           return null;
        //       }
        //       List<string> arrFuncId4CodeLst = new List<string>();
        //       foreach (string strKeyValue in lstKeyValues)
        //       {
        //           string[] strKeys = strKeyValue.Split(',');
        //           string strFuncId4Code = strKeys[0].ToString();
        //           arrFuncId4CodeLst.Add(strFuncId4Code);
        //       }
        //       return arrFuncId4CodeLst;
        //   }

        protected void btnSetType4Func_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //string strFuncTypeId = ddlFuncTypeIDq.SelectedValue;
            //List<string> lstFuncId4Code = wucFunction4Code4GV1.GetAllCheckedKeysFromGv();
            //if (lstFuncId4Code == null) return;
            //if (ddlFuncTypeIDq.SelectedIndex <= 0)
            //{
            //    clsCommonJsFunc.Alert(this, "请选择函数类型!");
            //    ddlFuncTypeIDq.Focus();
            //    return;
            //}

            //string strFuncTypeID = ddlFuncTypeIDq.SelectedValue;
            //foreach (string strFuncId4GC in lstFuncId4Code)
            //{

            //    clsFunction4CodeEN objcc_Function4Code = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4GC);
            //    objcc_Function4Code.FuncTypeId = strFuncTypeID;

            //    objcc_Function4Code.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            //    objcc_Function4Code.UpdUser = clsCommonSession.UserId;

            //    clsFunction4CodeBL.UpdateBySql2(objcc_Function4Code);
            //    i++;
            //}

            //clsCommonJsFunc.Alert(this, string.Format("设置Code函数成功！共设置了[{0}]条记录！", i));
            //string strWhereCond = CombineFunction4CodeCondition();
            //lblMsgList.Text = "";
            //try
            //{
            //    foreach (string strFuncId4Code in lstFuncId4Code)
            //    {
            //        clsFunction4CodeBL.DelRecord(strFuncId4Code);
            //    }
            //}
            //catch (Exception objException)
            //{
            //    seErrMessage = objException.Message;
            //    seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    Response.Redirect(clsSysParaEN.ErrorPage);
            //}
            //wucFunction4Code4GV1.BindGv_Function4Code(strWhereCond, 0);
        }

        protected void btnSynchToFunction4GC_Click(object sender, EventArgs e)
        {
            //List<string> lstFuncId4Code = wucFunction4Code4GV1.GetAllCheckedKeysFromGv();
            //if (lstFuncId4Code == null) return;
            //lblMsgList.Text = "";
            //try
            //{
            //    int intCount = 0;
            //    foreach (string strFuncId4Code in lstFuncId4Code)
            //    {
            //        clsFunction4CodeEN objFunction4CodeEN =  clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
            //        clsFunction4GeneCodeEN pobjFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
            //        pobjFunction4GeneCodeEN.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();// 函数ID
            //        pobjFunction4GeneCodeEN.FuncName = objFunction4CodeEN.FuncName4Code;// 函数名
            //        pobjFunction4GeneCodeEN.FuncId4Code = objFunction4CodeEN.FuncId4Code;// 函数名          
            //        pobjFunction4GeneCodeEN.FunctionSignature = objFunction4CodeEN.FunctionSignature;// 函数名
            //        string strCondition_Feature = string.Format("{0}='{1}'", conFeatureFuncRela.FuncId4GC, 
            //            objFunction4CodeEN.FuncId4Code);
            //        clsFeatureFuncRelaEN objFeatureFuncRelaEN = clsFeatureFuncRelaBL.GetFirstObj_S(strCondition_Feature);
            //        if (objFeatureFuncRelaEN != null)
            //        {
            //            pobjFunction4GeneCodeEN.FeatureId = objFeatureFuncRelaEN.FeatureId;// 功能Id

            //        }
            //        else
            //        {
            //            pobjFunction4GeneCodeEN.FeatureId = "";
            //        }
            //        pobjFunction4GeneCodeEN.ProgLangTypeId = enumProgLangType.CSharp_01;// wucFunction4GeneCodeB1.ProgLangTypeId;// 编程语言类型Id
            //        pobjFunction4GeneCodeEN.CodeTypeId = "0001";// 
            //        pobjFunction4GeneCodeEN.SqlDsTypeId = "01";// wucFunction4GeneCodeB1.SqlDsTypeId;// 程序分层类型Id

            //        pobjFunction4GeneCodeEN.PrjId = clsPubVar.CurrSelPrjId;// wucFunction4GeneCodeB1.PrjId;// 工程ID
            //        pobjFunction4GeneCodeEN.ReturnTypeID = objFunction4CodeEN.ReturnTypeID;// 返回类型ID
            //        pobjFunction4GeneCodeEN.FuncTypeId = objFunction4CodeEN.FuncTypeId;// 函数类型ID
            //        pobjFunction4GeneCodeEN.IsTemplate = false;// wucFunction4GeneCodeB1.IsTemplate;// 是否模板
            //        pobjFunction4GeneCodeEN.FuncCode = "";// wucFunction4GeneCodeB1.FuncCode;// 函数代码
            //        pobjFunction4GeneCodeEN.UserId = clsCommonSession.UserId;// wucFunction4GeneCodeB1.UserId;// 用户ID
            //        pobjFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);// wucFunction4GeneCodeB1.UpdDate;// 修改日期
            //        pobjFunction4GeneCodeEN.UpdUser = clsCommonSession.UserId;//wucFunction4GeneCodeB1.UpdUser;// 修改者
            //        pobjFunction4GeneCodeEN.Memo = string.Format("从Function4Code-{0}同步！", clsDateTime.getTodayStr2(0));// wucFunction4GeneCodeB1.Memo;// 说明
            //        pobjFunction4GeneCodeEN.OrderNum = objFunction4CodeEN.OrderNum;// 序号
            //        pobjFunction4GeneCodeEN.InUse = true;// 序号
            //        pobjFunction4GeneCodeEN.FuncGCTypeId = "01";
            //        clsFunction4GeneCodeBL.AddNewRecordBySql2(pobjFunction4GeneCodeEN);
            //        intCount++;
            //    }
            //    string strMsg = string.Format("已经同步了[{0}]条记录！", intCount);
            //    clsCommonJsFunc.Alert(this, strMsg);
            //}
            //catch (Exception objException)
            //{
            //    seErrMessage = objException.Message;
            //    seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    Response.Redirect(clsSysParaEN.ErrorPage);
            //}
            //string strWhereCond = CombineFunction4CodeCondition();
            //wucFunction4Code4GV1.BindGv_Function4Code(strWhereCond, 0);
        }
        protected void btnFuncAccessModeId_Click(object sender, EventArgs e)
        {
            if (ddlFuncAccessModeId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择应用类型!");
                ddlFuncAccessModeId.Focus();
                return;
            }

            string strFuncAccessModeId = ddlFuncAccessModeId.SelectedValue;

            string strFuncId4Code = vsKeyId;
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return;
            lblMsgList.Text = "";
            try
            {
               
                    clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
                    objFunction4CodeEN.FuncAccessModeId = strFuncAccessModeId;
                    clsFunction4CodeBL.UpdateBySql2(objFunction4CodeEN);
               
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            string strWhereCond = CombineFunction4CodeCondition();
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
            wucTreeView4PrjTab.SelectNodeEx(vsKeyId);
        }

        protected void btnApplicationTypeId_Click(object sender, EventArgs e)
        {
            //if (ddlApplicationTypeId.SelectedIndex <= 0)
            //{
            //    clsCommonJsFunc.Alert(this, "请选择应用类型!");
            //    ddlApplicationTypeId.Focus();
            //    return;
            //}

            //int intApplicationTypeId = int.Parse( ddlApplicationTypeId.SelectedValue);

            //List<string> lstFuncId4Code = wucFunction4Code4GV1.GetAllCheckedKeysFromGv();
            //if (lstFuncId4Code == null) return;
            //lblMsgList.Text = "";
            //try
            //{
            //    foreach (string strFuncId4Code in lstFuncId4Code)
            //    {
            //        clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
            //        objFunction4CodeEN.ApplicationTypeId = intApplicationTypeId;
            //        clsFunction4CodeBL.UpdateBySql2(objFunction4CodeEN);
            //    }
            //}
            //catch (Exception objException)
            //{
            //    seErrMessage = objException.Message;
            //    seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    Response.Redirect(clsSysParaEN.ErrorPage);
            //}
            //string strWhereCond = CombineFunction4CodeCondition();
            //wucFunction4Code4GV1.BindGv_Function4Code(strWhereCond, 0);
        }

        protected void btnGC_Function4Code_Click(object sender, EventArgs e)
        {
            if (vsTreeNodeType != conFunction4Code._CurrTabName)
            {
                clsCommonJsFunc.Alert(this, "请选择一个函数");
                return;
            }
            string strFuncId4Code = vsKeyId;
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return;
            divGC_Function4Code.Visible = true;
            divGF_Function4Code.Visible = false;
            wucGC_Function4CodeB1.FuncId4CodeV2 = strFuncId4Code;
            seIsShowGCDiv = "true";
            //string strWhereCond = CombineFunction4CodeCondition();
            //wucFunction4Code4GV1.BindGv_Function4Code(strWhereCond, 0);
            SetStyle4Half();
        }

        protected void btnGeneFunction_Click(object sender, EventArgs e)
        {
            if (vsTreeNodeType != conFunction4Code._CurrTabName)
            {
                clsCommonJsFunc.Alert(this, "请选择一个函数");
                return;
            }
            string strFuncId4Code = vsKeyId;
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return;
            divGF_Function4Code.Visible = true;
            divGC_Function4Code.Visible = false;
            wucGF_Function4Code1.SetDdl_FuncAccessModeId();
            wucGF_Function4Code1.FuncId4Code = strFuncId4Code;
            seIsShowGCDiv = "true";
            string strWhereCond = CombineFunction4CodeCondition();
            //wucFunction4Code4GV1.BindGv_Function4Code(strWhereCond, 0);
            //wucFunction4Code4GV1.SetCheckedItemForGv(strFuncId4Code);
            SetStyle4Half();
        }

        private void SetStyle4Full()
        {
            divLeft.Style.Clear();
            divLeft.Style.Add("width", "100%");
            divRight.Visible = false;
            string strJS = string.Format("SetStyle4Full();");
            this.ClientScript.RegisterStartupScript(this.GetType(), "SetStyle4Full", strJS, true);
        }


        private void SetStyle4Half()
        {
            divLeft.Style.Clear();
            divLeft.Style.Add("width", "45%");
            divLeft.Style.Add("float", "left");

            divRight.Visible = true;
            string strJS = string.Format("SetStyle4Half();");
            this.ClientScript.RegisterStartupScript(this.GetType(), "SetStyle4Half", strJS, true);
        }
        protected void wucGF_Function4Code1_onGFFinished()
        {
            //string strWhereCond = CombineFunction4CodeCondition();
            //wucFunction4Code4GV1.BindGv_Function4Code(strWhereCond, 0);
        }

     

        protected void btnCopyTemplateFunction_Click(object sender, EventArgs e)
        {
            string strCondition = string.Format("{0}='1'", conFunction4Code.IsTemplate);
            List<clsFunction4CodeEN> arrFunction4Code = clsFunction4CodeBL.GetObjLst(strCondition);
            arrFunction4Code.ForEach(x=>
            {
                try
                {
                    bool bolResult = clsFunction4CodeBLEx.CloneRecordFromTemplate(x.FuncId4Code, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            });
             strCondition = string.Format("{0}='1'", conFuncPara4Code.IsTemplate);
            List<clsFuncPara4CodeEN> arrFuncPara4Code = clsFuncPara4CodeBL.GetObjLst(strCondition);
            arrFuncPara4Code.ForEach(x =>
            {
                try
                {
                    clsFuncPara4CodeEN objFuncPara4CodeEN = clsFuncPara4CodeBLEx.CloneRecordFromTemplate(x.FuncParaId4Code, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            });
            BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName();
        }
     
        protected void btnCalcFuncSignature_Click(object sender, EventArgs e)
        {

            //List<string> lstFuncId4Code = wucFunction4Code4GV1.GetAllCheckedKeysFromGv();
            //if (lstFuncId4Code == null) return;
            //lblMsgList.Text = "";
            //try
            //{
            //    foreach (string strFuncId4Code in lstFuncId4Code)
            //    {
            //        K_FuncId4Code_Function4Code objKey = strFuncId4Code;
            //        clsFunction4CodeEN objFunction4Code = objKey.GetObj();
            //        string strFuncSignature = objFunction4Code.GetFunctionSignature();
            //        string strFuncSignature_Sim = objFunction4Code.GetFunctionSignatureSim();
            //        objFunction4Code.SetFunctionSignature(strFuncSignature)
            //            .SetFunctionSignatureSim(strFuncSignature_Sim)
            //            .Update();
            //    }
            //}
            //catch (Exception objException)
            //{
            //    seErrMessage = objException.Message;
            //    seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    Response.Redirect(clsSysParaEN.ErrorPage);
            //}
            //BindGv_Function4Code();
        }

      

        private void BindTv_FuncModule_Agc_PrjTab_ClassName_FuncName()
        {
            //string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            //if (string.IsNullOrEmpty(strTabId) == true) return;
            wucTreeView4PrjTab.tmTreeModel = TreeModel.FuncModule_Agc_PrjTab_ClassName_FuncName;
            wucTreeView4PrjTab.DependsOn = "Table";
            wucTreeView4PrjTab.FunctionTemplateId = "0001";
            //wucTreeView4PrjTab.IsUseJsEvent = true;
            wucTreeView4PrjTab.PrjId = clsPubVar.CurrSelPrjId;// "0116";
            wucTreeView4PrjTab.BindTv();
            wucTreeView4PrjTab.Expand(1);
            //wucTreeView4PrjTab.afterSelect_Tz += wucTreeView4PrjTab_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView4PrjTab.CollapseAll();
            //            wucTreeView4PrjTab.SelectNodeEx(strTypeName, strKeyId);
            wucTreeView4PrjTab.ExpandLevel1();
            if (wucTreeView4PrjTab.Nodes.Count > 1)
            {
                wucTreeView4PrjTab.Nodes[1].Expand();
            }
        }
        protected string vsTreeNodeType
        {
            get
            {
                string sTreeNodeType;
                sTreeNodeType = (string)ViewState["TreeNodeType"];
                if (sTreeNodeType == null)
                {
                    sTreeNodeType = "";
                }
                return sTreeNodeType;
            }
            set
            {
                string sTreeNodeType = value;
                ViewState.Add("TreeNodeType", sTreeNodeType);
            }
        }


        protected string vsKeyId
        {
            get
            {
                string sKeyId;
                sKeyId = (string)ViewState["KeyId"];
                if (sKeyId == null)
                {
                    sKeyId = "";
                }
                return sKeyId;
            }
            set
            {
                string sKeyId = value;
                ViewState.Add("KeyId", sKeyId);
            }
        }
        protected void wucTreeView4PrjTab_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            vsTreeNodeType = strTypeName;
            vsKeyId = strKeyId;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView4PrjTab.CollapseAll();
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView4PrjTab.GetCurrPathNodeKeyIdLst();
            //            wucTreeView4PrjTab.SelectNodeEx(arrCurrPathNodeKeyIdLst);

            string strFuncId = strKeyId;
            //string strFuncModuleAgcId = wucTreeView1.NodeData.FuncModuleAgcId;
            //            if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return;
            if (strTypeName != conFunction4Code._CurrTabName)
            {
                wucTreeView4PrjTab.SelectNodeEx(arrCurrPathNodeKeyIdLst);
                return;
            }
            wucTreeView4PrjTab.SelectNodeEx(strFuncId);
            //string strTabId = wucvPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            //BindTv_ApplicationType_CodeType_Function4GeneCode(strTabId);

            //throw new NotImplementedException();
        }


    }
}