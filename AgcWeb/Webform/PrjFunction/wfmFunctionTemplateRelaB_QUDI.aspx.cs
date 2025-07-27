
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmFunctionTemplateRelaB_QUDI
表名:FunctionTemplateRela
生成代码版本:2017.03.27.1
生成日期:2017/03/28
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.02.21.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 == == == == == == == == == == == == 
*/
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;


using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;

using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFunctionTemplateRelaB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCode)
    /// </summary>
    public partial class wfmFunctionTemplateRelaB_QUDI : CommWebPageBase
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
                clsFunctionTemplateRelaBLEx.p_Set_ProgLangType4FuncTempRela();
                vsViewName = "函数与模板关系维护";
                vsTabName = string.Format("{0}", clsvFunctionTemplateRelaEN._CurrTabName);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
                switch (vsPotenceLevel)
                {
                    case "0":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "1":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "2":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "3":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "4":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "9":
                        break;
                    default:
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                }

                //1、为下拉框设置数据源,绑定列表数据
                wucFunctionTemplateRelaB1.SetDdl_FunctionTemplateId();
                wucFunctionTemplateRelaB1.SetDdl_FuncId4GC();
                clsFunctionTemplateBL.BindDdl_FunctionTemplateIdCache(ddlFunctionTemplateIdq);
                clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeIdq);
                clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeId4CodeTypeq);

                //clsFunction4GeneCodeBL.BindDdl_FuncId4GC(ddlFuncId4GCq);
                clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeIDq);

                if (string.IsNullOrEmpty(seProgLangTypeId) == false)
                {
                    ddlProgLangTypeIdq.SelectedValue = seProgLangTypeId;
                    ddlProgLangTypeId4CodeTypeq.SelectedValue = seProgLangTypeId;

                    clsCodeTypeBLEx.BindDdl_CodeTypeIdByProgLangTypeidEx(ddlCodeTypeIdq, seProgLangTypeId);
                    clsCodeTypeBLEx.BindDdl_CodeTypeIdByProgLangTypeidEx(ddlCodeTypeId, seProgLangTypeId);
                }
                else
                {
                    clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeIdq);
                    clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeId);
                }
                if (string.IsNullOrEmpty(seCodeTypeId) == false)
                {
                    ddlCodeTypeIdq.SelectedValue = seCodeTypeId;
                }
                if (string.IsNullOrEmpty(seFunctionTemplateId) == false)
                {
                    ddlFunctionTemplateIdq.SelectedValue = seFunctionTemplateId;
                }


                vsSortFunctionTemplateRelaBy = string.Format("{0} Asc", conFunctionTemplateRela.OrderNum);
                //2、显示无条件的表内容在GridView中
                BindGv_vFunctionTemplateRela();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                DispFunctionTemplateRelaListRegion();
            }
        }

        #endregion 页面启动函数


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
            wucvFunctionTemplateRela4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vFunctionTemplateRela();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// </summary>
        protected void BindGv_vFunctionTemplateRela()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。

            //System.Data.DataTable objDT = null;
            try
            {
                wucvFunctionTemplateRela4Gv1.SetGvVisibility("修改", false);
                wucvFunctionTemplateRela4Gv1.SetGvVisibility("删除", false);
                wucvFunctionTemplateRela4Gv1.SetGvVisibility(convFunctionTemplateRela.FuncTypeName, false);
                wucvFunctionTemplateRela4Gv1.SetGvVisibility(convFunctionTemplateRela.IsTemplate, false);

                //	1、组合界面条件串；                
                string strWhereCond = CombinevFunctionTemplateRelaCondition();
                //	3、调用控件中的绑定GridView函数；
                wucvFunctionTemplateRela4Gv1.BindGv_FunctionTemplateRela(strWhereCond);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002691)获取数据表(DataTable)不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }


        protected string CombinevFunctionTemplateRelaCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try
            {
                if (this.ddlFunctionTemplateIdq.SelectedValue != "" && this.ddlFunctionTemplateIdq.SelectedValue != "0")
                {
                    seFunctionTemplateId = ddlFunctionTemplateIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunctionTemplateRela.FunctionTemplateId, this.ddlFunctionTemplateIdq.SelectedValue);
                }
                else
                {
                    seFunctionTemplateId = "";
                }
                if (this.ddlCodeTypeIdq.SelectedValue != "" && this.ddlCodeTypeIdq.SelectedValue != "0")
                {
                    seCodeTypeId = ddlCodeTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunctionTemplateRela.CodeTypeId, this.ddlCodeTypeIdq.SelectedValue);
                }
                else
                {
                    seCodeTypeId = "";
                }
                if (this.ddlProgLangTypeIdq.SelectedValue != "" && this.ddlProgLangTypeIdq.SelectedValue != "0")
                {
                    seProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunctionTemplateRela.ProgLangTypeId, this.ddlProgLangTypeIdq.SelectedValue);
                }
                else
                {
                    seProgLangTypeId = "";
                }
                if (this.txtCreateUserIdq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFunctionTemplateRela.CreateUserId, this.txtCreateUserIdq.Text.Trim());
                }
                if (this.ddlFuncId4GCq.SelectedValue != "" && this.ddlFuncId4GCq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunctionTemplateRela.FuncId4GC, this.ddlFuncId4GCq.SelectedValue);
                }
                if (this.ddlFuncTypeIDq.SelectedValue != ""
                  && this.ddlFuncTypeIDq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunction4GeneCode.FuncTypeId,
                        this.ddlFuncTypeIDq.SelectedValue);
                }
                if (this.txtFuncNameq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFunctionTemplateRela.FuncName4Code,
                        this.txtFuncNameq.Text.Trim());
                }
                if (this.txtFuncName_GC.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFunctionTemplateRela.FuncName,
                        this.txtFuncName_GC.Text.Trim());
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI002692)在组合查询条件(CombinevFunctionTemplateRelaCondition)时出错!请联系管理员!" + objException.Message);
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
        /// 事件函数:在GridView中，单击列头进行排序所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvFunctionTemplateRela_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortFunctionTemplateRelaBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortFunctionTemplateRelaBy = e.SortExpression + " Asc";
                BindGv_vFunctionTemplateRela();
                return;
            }
            //检查原来是升序
            intIndex = vsSortFunctionTemplateRelaBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortFunctionTemplateRelaBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortFunctionTemplateRelaBy = e.SortExpression + " Desc";
            }
            BindGv_vFunctionTemplateRela();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortFunctionTemplateRelaBy
        {
            get
            {
                string sSortFunctionTemplateRelaBy;
                sSortFunctionTemplateRelaBy = (string)ViewState["SortFunctionTemplateRelaBy"];
                if (sSortFunctionTemplateRelaBy == null)
                {
                    sSortFunctionTemplateRelaBy = "";
                }
                return sSortFunctionTemplateRelaBy;
            }
            set
            {
                string sSortFunctionTemplateRelaBy = value;
                ViewState.Add("SortFunctionTemplateRelaBy", sSortFunctionTemplateRelaBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddFunctionTemplateRelaRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddFunctionTemplateRelaRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelFunctionTemplateRelaEdit.Text = "取消添加";
            //wucFunctionTemplateRelaB1.mId = clsFunctionTemplateRelaBL.GetMaxStrId_S();
            DispEditFunctionTemplateRelaRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddFunctionTemplateRelaRecordSave()
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
            clsFunctionTemplateRelaEN objFunctionTemplateRelaEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFunctionTemplateRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002693)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFunctionTemplateRelaEN objFunctionTemplateRelaEN;	//定义对象
            objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();    //初始化新对象
                                                                            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                                                                            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFunctionTemplateRelaClass(objFunctionTemplateRelaEN);      //把界面的值传到
                                                                                //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFunctionTemplateRelaBL.objCommFun4BL = new clsCommFun4BL4FunctionTemplateRela();

                clsFunctionTemplateRelaBL.CheckPropertyNew(objFunctionTemplateRelaEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFunctionTemplateRelaBL.AddNewRecordBySql2(objFunctionTemplateRelaEN);

            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI002694)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_vFunctionTemplateRela();
            DispFunctionTemplateRelaListRegion();
            wucFunctionTemplateRelaB1.Clear();      //清空控件中内容
                                                    ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunctionTemplateRelaEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddFunctionTemplateRelaRecordSaveV5()
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
            clsFunctionTemplateRelaEN objFunctionTemplateRelaEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFunctionTemplateRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002695)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFunctionTemplateRelaEN objFunctionTemplateRelaEN;	//定义对象
            objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();    //初始化新对象
                                                                            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                                                                            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFunctionTemplateRelaClass(objFunctionTemplateRelaEN);      //把界面的值传到
                                                                                //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFunctionTemplateRelaBL.CheckPropertyNew(objFunctionTemplateRelaEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFunctionTemplateRelaBL.AddNewRecordBySql2(objFunctionTemplateRelaEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002696)添加记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_vFunctionTemplateRela();
            DispFunctionTemplateRelaListRegion();
            wucFunctionTemplateRelaB1.Clear();      //清空控件中内容
                                                    ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunctionTemplateRelaEdit.Text = "取消编辑";
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
            long lngmId = wucvFunctionTemplateRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;

            UpdateFunctionTemplateRelaRecord(lngmId);
        }


        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
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
            if (clsFunctionTemplateRelaBL.IsExist(lngmId) == false)     //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI002698)在表[FunctionTemplateRela]中,关键字为:[lngmId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsFunctionTemplateRelaBL.GetFunctionTemplateRela(ref objFunctionTemplateRelaEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objFunctionTemplateRelaEN", objFunctionTemplateRelaEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromFunctionTemplateRelaClass(objFunctionTemplateRelaEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjFunctionTemplateRelaEN">表实体类对象</param>
        protected void GetDataFromFunctionTemplateRelaClass(clsFunctionTemplateRelaEN pobjFunctionTemplateRelaEN)
        {
            wucFunctionTemplateRelaB1.FunctionTemplateId = pobjFunctionTemplateRelaEN.FunctionTemplateId;// 函数模板Id
            wucFunctionTemplateRelaB1.FuncId4GC = pobjFunctionTemplateRelaEN.FuncId4GC;// 函数ID

            wucFunctionTemplateRelaB1.Memo = pobjFunctionTemplateRelaEN.Memo;// 说明
            wucFunctionTemplateRelaB1.OrderNum = pobjFunctionTemplateRelaEN.OrderNum;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateFunctionTemplateRelaRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelFunctionTemplateRelaEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditFunctionTemplateRelaRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objFunctionTemplateRelaEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateFunctionTemplateRelaRecordSave(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
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
            if (!wucFunctionTemplateRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002699)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFunctionTemplateRelaClass(objFunctionTemplateRelaEN);      //把界面的值传到
                                                                                //3.1、检查传进去的对象属性是否合法
            try
            {
                clsFunctionTemplateRelaBL.objCommFun4BL = new clsCommFun4BL4FunctionTemplateRela();

                clsFunctionTemplateRelaBL.CheckPropertyNew(objFunctionTemplateRelaEN);
                //4、把数据实体层的数据存贮到数据库中
                clsFunctionTemplateRelaBL.UpdateBySql2(objFunctionTemplateRelaEN);

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
            BindGv_vFunctionTemplateRela();
            DispFunctionTemplateRelaListRegion();
            wucFunctionTemplateRelaB1.Clear();//添空控件中的内容
                                              //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunctionTemplateRelaEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_FunctionTemplateRela{0}'", objFunctionTemplateRelaEN.mId.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objFunctionTemplateRelaEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateFunctionTemplateRelaRecordSaveV5(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
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
            if (!wucFunctionTemplateRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002700)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFunctionTemplateRelaClass(objFunctionTemplateRelaEN);      //把界面的值传到
                                                                                //3.1、检查传进去的对象属性是否合法
            try
            {
                clsFunctionTemplateRelaBL.CheckPropertyNew(objFunctionTemplateRelaEN);
                //4、把数据实体层的数据存贮到数据库中
                clsFunctionTemplateRelaBL.UpdateBySql2(objFunctionTemplateRelaEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "修改记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_vFunctionTemplateRela();
            DispFunctionTemplateRelaListRegion();
            wucFunctionTemplateRelaB1.Clear();//添空控件中的内容
                                              //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunctionTemplateRelaEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_FunctionTemplateRela{0}'", objFunctionTemplateRelaEN.mId.ToString().Trim()), true);
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
            clsFunctionTemplateRelaEN objFunctionTemplateRelaEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddFunctionTemplateRelaRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddFunctionTemplateRelaRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objFunctionTemplateRelaEN = (clsFunctionTemplateRelaEN)Session["objFunctionTemplateRelaEN"];
                    UpdateFunctionTemplateRelaRecordSave(objFunctionTemplateRelaEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelFunctionTemplateRelaEdit_Click(object sender, EventArgs e)
        {
            DispFunctionTemplateRelaListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjFunctionTemplateRelaEN">数据传输的目的类对象</param>
        protected void PutDataToFunctionTemplateRelaClass(clsFunctionTemplateRelaEN pobjFunctionTemplateRelaEN)
        {
            pobjFunctionTemplateRelaEN.FunctionTemplateId = wucFunctionTemplateRelaB1.FunctionTemplateId;// 函数模板Id
            pobjFunctionTemplateRelaEN.FuncId4GC = wucFunctionTemplateRelaB1.FuncId4GC;// 函数ID
            pobjFunctionTemplateRelaEN.UpdDate = wucFunctionTemplateRelaB1.UpdDate;// 修改日期
            pobjFunctionTemplateRelaEN.UpdUser = wucFunctionTemplateRelaB1.UpdUser;// 修改者
            pobjFunctionTemplateRelaEN.Memo = wucFunctionTemplateRelaB1.Memo;// 说明
            pobjFunctionTemplateRelaEN.OrderNum = wucFunctionTemplateRelaB1.OrderNum;// 说明
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<long> lstMId = wucvFunctionTemplateRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsFunctionTemplateRelaBL.DelRecord(lngmId);
                }

            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFunctionTemplateRela();
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteFunctionTemplateRelaRecord(long lngmId)
        {
            try
            {
                clsFunctionTemplateRelaBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFunctionTemplateRela();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vFunctionTemplateRela]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevFunctionTemplateRelaCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FunctionTemplateRela信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convFunctionTemplateRela.mId); arrCnName.Add("mId");
            arrColName.Add(convFunctionTemplateRela.FunctionTemplateId); arrCnName.Add("函数模板Id");
            arrColName.Add(convFunctionTemplateRela.FunctionTemplateName); arrCnName.Add("函数模板名");
            arrColName.Add(convFunctionTemplateRela.CodeTypeId); arrCnName.Add("程序分层类型Id");
            arrColName.Add(convFunctionTemplateRela.ProgLangTypeId); arrCnName.Add("编程语言类型Id");
            arrColName.Add(convFunctionTemplateRela.ProgLangTypeName); arrCnName.Add("编程语言类型名");
            arrColName.Add(convFunctionTemplateRela.CreateUserId); arrCnName.Add("建立用户Id");
            arrColName.Add(convFunctionTemplateRela.FuncId4GC); arrCnName.Add("函数ID");
            arrColName.Add(convFunctionTemplateRela.FuncName); arrCnName.Add("函数名");
            arrColName.Add(convFunctionTemplateRela.IsTemplate); arrCnName.Add("是否模板");
            arrColName.Add(convFunctionTemplateRela.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convFunctionTemplateRela.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convFunctionTemplateRela.Memo); arrCnName.Add("说明");
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
                objDT = clsvFunctionTemplateRelaBL.GetDataTable(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispEditFunctionTemplateRelaRegion()
        {
            divList.Visible = false;
            tabEditFunctionTemplateRelaRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispFunctionTemplateRelaListRegion()
        {
            divList.Visible = true;
            tabEditFunctionTemplateRelaRegion.Visible = false;
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

        protected void btnAddBatch_Click(object sender, EventArgs e)
        {
            if (ddlFunctionTemplateIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个模板！");
                return;
            }
            if (ddlCodeTypeIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个代码类型！");
                return;
            }
            string strFunctionTemplateId = ddlFunctionTemplateIdq.SelectedValue;
            string strCodeTypeId = ddlCodeTypeIdq.SelectedValue;
            string strPageName = string.Format("wfmFunctionTemplateRelaB_I.aspx?UserId={0}&FunctionTemplateId={1}&CodeTypeId={2}",
                clsCommonSession.UserId, strFunctionTemplateId, strCodeTypeId);
            Response.Redirect(strPageName);
        }
        //定义从外面传来的ParentPage(前调用页面)
        //private string qsParentPage
        //{
        //    get
        //    {
        //        string strParentPage = Request.QueryString["ParentPage"] ?? "".ToString();
        //        if ((strParentPage != null) && (strParentPage != ""))
        //        {
        //            return strParentPage;//Request.QueryString["id"] ?? "";
        //        }
        //        else
        //        {
        //            return "";
        //        }
        //    }
        //}

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(qsParentPage) == true)
            {
                Response.Redirect(qsParentPage);
            }
            else
            {
                Response.Redirect("wfmFunctionTemplateB_QUDI.aspx");
            }
        }

        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            long lngmId = wucvFunctionTemplateRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsgList.Text = "";


            try
            {
                clsFunctionTemplateRelaBLEx.AdjustSequenceNumber("UP", lngmId);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"./GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFunctionTemplateRela();
            wucvFunctionTemplateRela4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            long lngmId = wucvFunctionTemplateRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsgList.Text = "";

            try
            {
                clsFunctionTemplateRelaBLEx.AdjustSequenceNumber("DOWN", lngmId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFunctionTemplateRela();
            wucvFunctionTemplateRela4Gv1.SetCheckedItemForGv(lngmId);
        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strFunctionTemplateId = ddlFunctionTemplateIdq.SelectedValue;
            string strCodeTypeId = ddlCodeTypeIdq.SelectedValue;

            try
            {
                clsFunctionTemplateRelaBLEx.ReOrder(strFunctionTemplateId, strCodeTypeId);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            BindGv_vFunctionTemplateRela();

        }
        private bool PreCheck4Order()
        {
            if (ddlFunctionTemplateIdq.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请选择模板!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlFunctionTemplateIdq.Focus();
                return false;
            }

            if (ddlProgLangTypeIdq.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请编程语言!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlProgLangTypeIdq.Focus();
                return false;
            }
            if (ddlCodeTypeIdq.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请层语言!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlCodeTypeIdq.Focus();
                return false;
            }
            return true;
        }

        protected void btnGoTop_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvFunctionTemplateRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            if (PreCheck4Order() == false) return;
            string strFunctionTemplateId = ddlFunctionTemplateIdq.SelectedValue;
            string strCodeTypeId = ddlCodeTypeIdq.SelectedValue;

            lblMsgList.Text = "";

            try
            {
                clsFunctionTemplateRelaBLEx.GoTop(lstMId, strFunctionTemplateId, strCodeTypeId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFunctionTemplateRela();
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvFunctionTemplateRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            
            if (PreCheck4Order() == false) return;
            string strFunctionTemplateId = ddlFunctionTemplateIdq.SelectedValue;
            string strCodeTypeId = ddlCodeTypeIdq.SelectedValue;
            
            lblMsgList.Text = "";
            try
            {
                clsFunctionTemplateRelaBLEx.GoBottom(lstMId, strFunctionTemplateId, strCodeTypeId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFunctionTemplateRela();
        }

        /// <summary>
        /// 编程语言类型Id。ddlProgLangTypeId
        /// </summary>
        protected string seProgLangTypeId
        {
            get
            {
                string sProgLangTypeId;
                sProgLangTypeId = (string)Session["ProgLangTypeId"];
                if (sProgLangTypeId == null)
                {
                    sProgLangTypeId = "";
                }
                return sProgLangTypeId;
            }
            set
            {
                string sProgLangTypeId = value;
                Session.Add("ProgLangTypeId", sProgLangTypeId);
            }
        }

        /// <summary>
        /// 编程层类型Id。ddlCodeTypeId
        /// </summary>
        protected string seCodeTypeId
        {
            get
            {
                string sCodeTypeId;
                sCodeTypeId = (string)Session["CodeTypeId"];
                if (sCodeTypeId == null)
                {
                    sCodeTypeId = "";
                }
                return sCodeTypeId;
            }
            set
            {
                string sCodeTypeId = value;
                Session.Add("CodeTypeId", sCodeTypeId);
            }
        }
        /// <summary>
        /// 函数模板Id。ddlFunctionTemplateId
        /// </summary>
        protected string seFunctionTemplateId
        {
            get
            {
                string sFunctionTemplateId;
                sFunctionTemplateId = (string)Session["FunctionTemplateId"];
                if (sFunctionTemplateId == null)
                {
                    sFunctionTemplateId = "";
                }
                return sFunctionTemplateId;
            }
            set
            {
                string sFunctionTemplateId = value;
                Session.Add("FunctionTemplateId", sFunctionTemplateId);
            }
        }

        #region 处理父页面信息以及跳转到其他页面

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);


                    //{

                    //}
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":

                    clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息

        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }

        protected void ddlCodeTypeId_q_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvFunctionTemplateRela_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = (clsvFunctionTemplateRelaEN) e.Row.DataItem;
            //clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunctionTemplateRelaEN.FuncId4Code);
            //objvFunctionTemplateRelaEN.FuncCHName4Code
            //            clsvQuestionnaireEN objQuestionnaireEN = (clsvQuestionnaireEN)e.Item.DataItem;


        }

        protected void ddlProgLangTypeId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProgLangTypeIdq.SelectedIndex == 0)
            {
                clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeIdq);
                return;
            }
            string strProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
            clsCodeTypeBLEx.BindDdl_CodeTypeIdByProgLangTypeidEx(ddlCodeTypeIdq, strProgLangTypeId);
        }


        protected void ddlProgLangTypeId4CodeType_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProgLangTypeId4CodeTypeq.SelectedIndex == 0)
            {
                clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeIdq);
                return;
            }
            string strProgLangTypeId = ddlProgLangTypeId4CodeTypeq.SelectedValue;
            clsCodeTypeBLEx.BindDdl_CodeTypeIdByProgLangTypeidEx(ddlCodeTypeIdq, strProgLangTypeId);
            clsCodeTypeBLEx.BindDdl_CodeTypeIdByProgLangTypeidEx(ddlCodeTypeId, strProgLangTypeId);
        }

        protected void btnCopyToNewCopyTypeId_Click(object sender, EventArgs e)
        {
            if (ddlCodeTypeId.SelectedIndex == 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个新代码类型");
                ddlCodeTypeId.Focus();
                return;
            }
            List<long> lstMId = wucvFunctionTemplateRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;

            lblMsgList.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {            
                    clsFunctionTemplateRelaEN obj = clsFunctionTemplateRelaBL.GetObjBymId(lngmId);
                    obj.CodeTypeId = ddlCodeTypeId.SelectedValue;
                    obj.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId);
                    obj.EditRecordEx();

                }

            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFunctionTemplateRela();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFunctionTemplateRela4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteFunctionTemplateRelaRecord(lngmId);
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFunctionTemplateRela4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateFunctionTemplateRelaRecord(lngmId);

        }
    }
}