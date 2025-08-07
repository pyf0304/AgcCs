
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmFunction4GeneCodeB_QUDI
表名:Function4GeneCode
生成代码版本:2017.03.27.1
生成日期:2017/03/28
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.02.21.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
/// == == == == == == == == == == == == 
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
using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.web.treeview;
using AGC.web.treeview;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFunction4GeneCodeB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCode)
    /// </summary>
    public partial class wfmFunction4GeneCode_Tv : CommWebPageBase
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

                vsViewName = "函数4GeneCode维护";
                vsTabName = string.Format("{0}", clsvFunction4GeneCodeEN._CurrTabName);
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
                wucFunction4GeneCodeB1.SetDdl_ProgLangTypeId();
                wucFunction4GeneCodeB1.SetDdl_CodeTypeId();
                wucFunction4GeneCodeB1.SetDdl_PrjId();
                wucFunction4GeneCodeB1.SetDdl_ReturnTypeID();
                wucFunction4GeneCodeB1.SetDdl_FuncTypeID();

                wucFunction4GeneCodeB1.SetDdl_FeatureId();
                wucFunction4GeneCodeB1.SetDdl_SqlDsTypeId();
                wucFunction4GeneCodeB1.SetDdl_TabId(clsPubVar.CurrSelPrjId);
                wucFunction4GeneCodeB1.SetDdl_FuncId4Code();

                //wucFunction4GC4BatchUpdate1.SetDdl_ProgLangTypeId();
                //wucFunction4GC4BatchUpdate1.SetDdl_CodeTypeId();              
                //wucFunction4GC4BatchUpdate1.SetDdl_ReturnTypeID();
                //wucFunction4GC4BatchUpdate1.SetDdl_FuncTypeID();
                //wucFunction4GC4BatchUpdate1.SetDdl_FeatureId();
                //wucFunction4GC4BatchUpdate1.SetDdl_SqlDsTypeId();


                clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeIdq);
                clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeId4CodeTypeq);

                //ddlProgLangTypeIdq.SelectedValue = enumProgLangType.CSharp_01;
                if (string.IsNullOrEmpty(seProgLangTypeId) == true)
                {
                    ddlProgLangTypeIdq.SelectedValue = enumProgLangType.CSharp_01;
                    ddlProgLangTypeId4CodeTypeq.SelectedValue = enumProgLangType.CSharp_01;

                }
                else
                {
                    ddlProgLangTypeIdq.SelectedValue = seProgLangTypeId;
                    ddlProgLangTypeId4CodeTypeq.SelectedValue = seProgLangTypeId;
                }
                clsCodeTypeBLEx.BindDdl_DependsOn(ddlDependsOn, ddlProgLangTypeId4CodeTypeq.SelectedValue);
                ddlDependsOn.SelectedValue = "Table";
                clsCodeTypeBLEx.BindDdl_GroupNameByDependsOn(ddlGroupName, "Table", ddlProgLangTypeId4CodeTypeq.SelectedValue);



                clsSQLDSTypeBL.BindDdl_SqlDsTypeIdCache(ddlSqlDsTypeIdq);
                clsSQLDSTypeBL.BindDdl_SqlDsTypeIdCache(ddlSqlDsTypeId);

                clsFuncGCTypeBL.BindDdl_FuncGCTypeIdCache(ddlFuncGCTypeIdq);
                clsFuncGCTypeBL.BindDdl_FuncGCTypeIdCache(ddlFuncGCTypeId);

                clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeIDq);
                clsFunction4CodeBLEx.BindDdl_FuncId4CodeWithSignatureEx(ddlFuncId4Code);

                clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureId, enumPrjFeatureType.GeneralFeature_05);
                clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureIdq, enumPrjFeatureType.GeneralFeature_05);

                try
                {
                    if (string.IsNullOrEmpty(seProgLangTypeId) == false)
                    {
                        ddlProgLangTypeIdq.SelectedValue = seProgLangTypeId;
                        clsCodeTypeBLEx.BindDdl_CodeTypeIdByProgLangTypeidEx(ddlCodeTypeIdq, seProgLangTypeId);
                    }
                    else
                    {
                        clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeIdq);
                    }
                }
                catch (Exception objException)
                {
                    HideDiv4BatchUpdate();
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
                if (string.IsNullOrEmpty(seCodeTypeId) == false)
                {
                    ddlCodeTypeIdq.SelectedValue = seCodeTypeId;
                }

                vsSortFunction4GeneCodeBy = string.Format("{0} Asc", conFunction4GeneCode.OrderNum);
                //2、显示无条件的表内容在GridView中
                BindGv_vFunction4GeneCode();
                BindTv_CodeType_PrjFeature_Function4GeneCode();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucFunction4GeneCodeB1.SetKeyReadOnly(true);
                DispFunction4GeneCodeListRegion();
                vsIsShowDivBatchUpdate = "false";
            }
            if (vsIsShowDivBatchUpdate == "false")
            {
                HideDiv4BatchUpdate();
            }
            else
            {
                ShowDiv4BatchUpdate();
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
            wucvFunction4GeneCode4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vFunction4GeneCode();
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineFunction4GeneCodeCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = string.Format(" 1 = 1 And {0}='1'", convFunction4GeneCode.InUse);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try
            {
                if (this.txtFuncId4GCq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFunction4GeneCode.FuncId4GC, this.txtFuncId4GCq.Text.Trim());
                }
                if (this.txtFuncNameq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFunction4GeneCode.FuncName, this.txtFuncNameq.Text.Trim());
                }
                if (this.ddlProgLangTypeIdq.SelectedValue != "" && this.ddlProgLangTypeIdq.SelectedValue != "0")
                {
                    seProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunction4GeneCode.ProgLangTypeId, this.ddlProgLangTypeIdq.SelectedValue);
                }
                else
                {
                    seProgLangTypeId = "";
                }
                if (this.ddlCodeTypeIdq.SelectedValue != "" && this.ddlCodeTypeIdq.SelectedValue != "0")
                {
                    seCodeTypeId = ddlCodeTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunction4GeneCode.FuncCodeTypeId, this.ddlCodeTypeIdq.SelectedValue);
                }
                else
                {
                    seCodeTypeId = "";
                }

                if (chkFeatureIdq.Checked)
                {
                    if (this.ddlFeatureIdq.SelectedValue != "" && this.ddlFeatureIdq.SelectedValue != "0")
                    {
                        strWhereCond += string.Format(" And {0} = '{1}'", convFunction4GeneCode.FeatureId,
                            this.ddlFeatureIdq.SelectedValue);
                    }
                }

                if (this.ddlSqlDsTypeIdq.SelectedValue != "" && this.ddlSqlDsTypeIdq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunction4GeneCode.SqlDsTypeId,
                        this.ddlSqlDsTypeIdq.SelectedValue);
                }

                if (this.ddlFuncGCTypeIdq.SelectedValue != "" && this.ddlFuncGCTypeIdq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunction4GeneCode.FuncGCTypeId,
                        this.ddlFuncGCTypeIdq.SelectedValue);
                }

                if (this.ddlFuncTypeIDq.SelectedValue != ""
                    && this.ddlFuncTypeIDq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunction4GeneCode.FuncTypeId,
                        this.ddlFuncTypeIDq.SelectedValue);
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI002666)在组合查询条件(CombineFunction4GeneCodeCondition)时出错!请联系管理员!" + objException.Message);
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
        protected void gvFunction4GeneCode_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortFunction4GeneCodeBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortFunction4GeneCodeBy = e.SortExpression + " Asc";
                BindGv_vFunction4GeneCode();
                return;
            }
            //检查原来是升序
            intIndex = vsSortFunction4GeneCodeBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortFunction4GeneCodeBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortFunction4GeneCodeBy = e.SortExpression + " Desc";
            }
            BindGv_vFunction4GeneCode();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortFunction4GeneCodeBy
        {
            get
            {
                string sSortFunction4GeneCodeBy;
                sSortFunction4GeneCodeBy = (string)ViewState["SortFunction4GeneCodeBy"];
                if (sSortFunction4GeneCodeBy == null)
                {
                    sSortFunction4GeneCodeBy = "";
                }
                return sSortFunction4GeneCodeBy;
            }
            set
            {
                string sSortFunction4GeneCodeBy = value;
                ViewState.Add("SortFunction4GeneCodeBy", sSortFunction4GeneCodeBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddFunction4GeneCodeRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddFunction4GeneCodeRecord()
        {
            wucFunction4GeneCodeB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelFunction4GeneCodeEdit.Text = "取消添加";
            wucFunction4GeneCodeB1.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
            DispEditFunction4GeneCodeRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddFunction4GeneCodeRecordSave()
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
            clsFunction4GeneCodeEN objFunction4GeneCodeEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFunction4GeneCodeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002667)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFunction4GeneCodeEN objFunction4GeneCodeEN;	//定义对象
            objFunction4GeneCodeEN = new clsFunction4GeneCodeEN(wucFunction4GeneCodeB1.FuncId4GC);  //初始化新对象
                                                                                                    //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC))   //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002668)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFunction4GeneCodeClass(objFunction4GeneCodeEN);        //把界面的值传到
                                                                            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFunction4GeneCodeBL.objCommFun4BL = new clsCommFun4BL4Function4GeneCode();

                clsFunction4GeneCodeBL.CheckPropertyNew(objFunction4GeneCodeEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFunction4GeneCodeBL.AddNewRecordBySql2(objFunction4GeneCodeEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI002669)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_vFunction4GeneCode();
            DispFunction4GeneCodeListRegion();
            wucFunction4GeneCodeB1.Clear();     //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunction4GeneCodeEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddFunction4GeneCodeRecordSaveV5()
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
            clsFunction4GeneCodeEN objFunction4GeneCodeEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFunction4GeneCodeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002670)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFunction4GeneCodeEN objFunction4GeneCodeEN;	//定义对象
            objFunction4GeneCodeEN = new clsFunction4GeneCodeEN(wucFunction4GeneCodeB1.FuncId4GC);  //初始化新对象
                                                                                                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC))   //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002671)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFunction4GeneCodeClass(objFunction4GeneCodeEN);        //把界面的值传到
                                                                            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFunction4GeneCodeBL.CheckPropertyNew(objFunction4GeneCodeEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFunction4GeneCodeBL.AddNewRecordBySql2(objFunction4GeneCodeEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002672)添加记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_vFunction4GeneCode();
            DispFunction4GeneCodeListRegion();
            wucFunction4GeneCodeB1.Clear();     //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunction4GeneCodeEdit.Text = "取消编辑";
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
            string strFuncId4GC = wucvFunction4GeneCode4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strFuncId4GC) == true) return;
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            UpdateFunction4GeneCodeRecord(strFuncId4GC);
        }


        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strFuncId4GC">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strFuncId4GC)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strFuncId4GC == "") return;     //如果关键字为空就返回退出
                                                //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsFunction4GeneCodeBL.IsExist(strFuncId4GC) == false)      //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI002674)在表[Function4GeneCode]中,关键字为:[strFuncId4GC]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN(strFuncId4GC);
            //4、获取类对象的所有属性；
            try
            {
                clsFunction4GeneCodeBL.GetFunction4GeneCode(ref objFunction4GeneCodeEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objFunction4GeneCodeEN", objFunction4GeneCodeEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromFunction4GeneCodeClass(objFunction4GeneCodeEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjFunction4GeneCodeEN">表实体类对象</param>
        protected void GetDataFromFunction4GeneCodeClass(clsFunction4GeneCodeEN pobjFunction4GeneCodeEN)
        {
            wucFunction4GeneCodeB1.FuncId4GC = pobjFunction4GeneCodeEN.FuncId4GC;// 函数ID
            wucFunction4GeneCodeB1.FuncName = pobjFunction4GeneCodeEN.FuncName;// 函数名

            wucFunction4GeneCodeB1.FuncId4Code = pobjFunction4GeneCodeEN.FuncId4Code;// 函数名
            //wucFunction4GeneCodeB1.FunctionSignature = pobjFunction4GeneCodeEN.FunctionSignature;// 函数名

            wucFunction4GeneCodeB1.FeatureId = pobjFunction4GeneCodeEN.FeatureId;// 编程语言类型Id
            wucFunction4GeneCodeB1.ProgLangTypeId = pobjFunction4GeneCodeEN.ProgLangTypeId;// 编程语言类型Id
            wucFunction4GeneCodeB1.FuncCodeTypeId = pobjFunction4GeneCodeEN.FuncCodeTypeId;// 程序分层类型Id
            wucFunction4GeneCodeB1.SqlDsTypeId = pobjFunction4GeneCodeEN.SqlDsTypeId;// 程序分层类型Id
            wucFunction4GeneCodeB1.PrjId = pobjFunction4GeneCodeEN.PrjId;// 工程ID
            wucFunction4GeneCodeB1.ReturnTypeID = pobjFunction4GeneCodeEN.ReturnTypeId;// 返回类型ID
            wucFunction4GeneCodeB1.FuncTypeId = pobjFunction4GeneCodeEN.FuncTypeId;// 函数类型ID
            wucFunction4GeneCodeB1.IsTemplate = pobjFunction4GeneCodeEN.IsTemplate;// 是否模板
            wucFunction4GeneCodeB1.FuncCode = pobjFunction4GeneCodeEN.FuncCode;// 函数代码

            wucFunction4GeneCodeB1.Memo = pobjFunction4GeneCodeEN.Memo;// 说明
            wucFunction4GeneCodeB1.OrderNum = pobjFunction4GeneCodeEN.OrderNum;// 序号
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateFunction4GeneCodeRecord(string strFuncId4GC)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strFuncId4GC);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucFunction4GeneCodeB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelFunction4GeneCodeEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditFunction4GeneCodeRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objFunction4GeneCodeEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateFunction4GeneCodeRecordSave(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
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
            if (!wucFunction4GeneCodeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002675)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFunction4GeneCodeClass(objFunction4GeneCodeEN);        //把界面的值传到
                                                                            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsFunction4GeneCodeBL.objCommFun4BL = new clsCommFun4BL4Function4GeneCode();
                clsFunction4GeneCodeBL.CheckPropertyNew(objFunction4GeneCodeEN);
                //4、把数据实体层的数据存贮到数据库中
                clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCodeEN);
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
            BindGv_vFunction4GeneCode();
            BindTv_CodeType_PrjFeature_Function4GeneCode();
            DispFunction4GeneCodeListRegion();
            wucFunction4GeneCodeB1.Clear();//添空控件中的内容
                                           //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunction4GeneCodeEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_Function4GeneCode{0}'", objFunction4GeneCodeEN.FuncId4GC.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objFunction4GeneCodeEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateFunction4GeneCodeRecordSaveV5(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
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
            if (!wucFunction4GeneCodeB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002676)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFunction4GeneCodeClass(objFunction4GeneCodeEN);        //把界面的值传到
                                                                            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsFunction4GeneCodeBL.CheckPropertyNew(objFunction4GeneCodeEN);
                //4、把数据实体层的数据存贮到数据库中
                clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCodeEN);
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
            BindGv_vFunction4GeneCode();
            DispFunction4GeneCodeListRegion();
            wucFunction4GeneCodeB1.Clear();//添空控件中的内容
                                           //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFunction4GeneCodeEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_Function4GeneCode{0}'", objFunction4GeneCodeEN.FuncId4GC.ToString().Trim()), true);
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
            clsFunction4GeneCodeEN objFunction4GeneCodeEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddFunction4GeneCodeRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddFunction4GeneCodeRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objFunction4GeneCodeEN = (clsFunction4GeneCodeEN)Session["objFunction4GeneCodeEN"];
                    UpdateFunction4GeneCodeRecordSave(objFunction4GeneCodeEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelFunction4GeneCodeEdit_Click(object sender, EventArgs e)
        {
            DispFunction4GeneCodeListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjFunction4GeneCodeEN">数据传输的目的类对象</param>
        protected void PutDataToFunction4GeneCodeClass(clsFunction4GeneCodeEN pobjFunction4GeneCodeEN)
        {
            pobjFunction4GeneCodeEN.FuncId4GC = wucFunction4GeneCodeB1.FuncId4GC;// 函数ID
            pobjFunction4GeneCodeEN.FuncName = wucFunction4GeneCodeB1.FuncName;// 函数名
            pobjFunction4GeneCodeEN.FuncId4Code = wucFunction4GeneCodeB1.FuncId4Code;// 函数名          
            //pobjFunction4GeneCodeEN.FunctionSignature = wucFunction4GeneCodeB1.FunctionSignature;// 函数名
            pobjFunction4GeneCodeEN.FeatureId = wucFunction4GeneCodeB1.FeatureId;// 功能Id

            pobjFunction4GeneCodeEN.ProgLangTypeId = wucFunction4GeneCodeB1.ProgLangTypeId;// 编程语言类型Id
            pobjFunction4GeneCodeEN.FuncCodeTypeId = wucFunction4GeneCodeB1.FuncCodeTypeId;// 程序分层类型Id
            pobjFunction4GeneCodeEN.SqlDsTypeId = wucFunction4GeneCodeB1.SqlDsTypeId;// 程序分层类型Id

            pobjFunction4GeneCodeEN.PrjId = wucFunction4GeneCodeB1.PrjId;// 工程ID
            pobjFunction4GeneCodeEN.ReturnTypeId = wucFunction4GeneCodeB1.ReturnTypeID;// 返回类型ID
            pobjFunction4GeneCodeEN.FuncTypeId = wucFunction4GeneCodeB1.FuncTypeId;// 函数类型ID
            pobjFunction4GeneCodeEN.IsTemplate = wucFunction4GeneCodeB1.IsTemplate;// 是否模板
            pobjFunction4GeneCodeEN.FuncCode = wucFunction4GeneCodeB1.FuncCode;// 函数代码
            pobjFunction4GeneCodeEN.UserId = wucFunction4GeneCodeB1.UserId;// 用户ID
            pobjFunction4GeneCodeEN.UpdDate = wucFunction4GeneCodeB1.UpdDate;// 修改日期
            pobjFunction4GeneCodeEN.UpdUser = wucFunction4GeneCodeB1.UpdUser;// 修改者
            pobjFunction4GeneCodeEN.Memo = wucFunction4GeneCodeB1.Memo;// 说明
            pobjFunction4GeneCodeEN.OrderNum = wucFunction4GeneCodeB1.OrderNum;// 序号
            pobjFunction4GeneCodeEN.InUse = true;// 序号

        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            if (lstFuncId4GC.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002677)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strFuncId4GC in lstFuncId4GC)
                {
                    clsFunction4GeneCodeBL.DelRecord(strFuncId4GC);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFunction4GeneCode();
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strFuncId4GC">给定关键字</param>
        protected void DeleteFunction4GeneCodeRecord(string strFuncId4GC)
        {
            try
            {
                clsFunction4GeneCodeBL.DelRecord(strFuncId4GC);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFunction4GeneCode();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vFunction4GeneCode]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineFunction4GeneCodeCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "Function4GeneCode信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convFunction4GeneCode.FuncId4GC); arrCnName.Add("函数ID");
            arrColName.Add(convFunction4GeneCode.FuncName); arrCnName.Add("函数名");
            arrColName.Add(convFunction4GeneCode.ProgLangTypeId); arrCnName.Add("编程语言类型Id");
            arrColName.Add(convFunction4GeneCode.ProgLangTypeName); arrCnName.Add("编程语言类型名");
            arrColName.Add(convFunction4GeneCode.FuncCodeTypeId); arrCnName.Add("程序分层类型Id");
            arrColName.Add(convFunction4GeneCode.IsTemplate); arrCnName.Add("是否模板");
            arrColName.Add(convFunction4GeneCode.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convFunction4GeneCode.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convFunction4GeneCode.Memo); arrCnName.Add("说明");
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
                objDT = clsvFunction4GeneCodeBL.GetDataTable(strWhereCond);
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
        private void DispEditFunction4GeneCodeRegion()
        {
            divList4GC.Visible = false;
            tabEditFunction4GeneCodeRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispFunction4GeneCodeListRegion()
        {
            divList4GC.Visible = true;
            tabEditFunction4GeneCodeRegion.Visible = false;
        }

        private void HideFunction4GCBatchUpdateRegion()
        {
            //divList.Visible = true;
            //divBatchUpdate.Visible = false;
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
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected string vsIsShowDivBatchUpdate
        {
            get
            {
                string sIsShowDivBatchUpdate;
                sIsShowDivBatchUpdate = (string)ViewState["IsShowDivBatchUpdate"];
                if (sIsShowDivBatchUpdate == null)
                {
                    sIsShowDivBatchUpdate = "";
                }
                return sIsShowDivBatchUpdate;
            }
            set
            {
                string sIsShowDivBatchUpdate = value;
                ViewState.Add("IsShowDivBatchUpdate", sIsShowDivBatchUpdate);
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

        protected void btnSetSqlDsTypeId_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            if (lstFuncId4GC.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "没有选择记录，请选择一个有效的表记录!");
                return;
            }
            if (ddlSqlDsTypeId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择数据源类型!");
                ddlSqlDsTypeId.Focus();
                return;
            }

            string strSqlDsTypeId = ddlSqlDsTypeId.SelectedValue;
            foreach (string strFuncId4GC in lstFuncId4GC)
            {

                clsFunction4GeneCodeEN objcc_Function4GeneCode = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
                objcc_Function4GeneCode.SqlDsTypeId = strSqlDsTypeId;

                objcc_Function4GeneCode.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objcc_Function4GeneCode.UpdUser = clsCommonSession.UserId;

                clsFunction4GeneCodeBL.UpdateBySql2(objcc_Function4GeneCode);
                i++;

            }

            clsCommonJsFunc.Alert(this, string.Format("设置数据库类型成功！共设置了[{0}]条记录！", i));
            BindGv_vFunction4GeneCode();
        }

        protected void btnCloneNewRec4Gv_Click(object sender, EventArgs e)
        {
            if (wucTreeView1.CurrNodeType != convFunction4GeneCode._CurrTabName && wucTreeView1.CurrNodeType != conFunction4GeneCode._CurrTabName)
            {
         
                lblMsgList.Text = "请在树中选择一个函数!";
                return;
            }
            string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;

            clsFunction4GeneCodeEN obj = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
            if (obj == null)
            {
                lblMsgList.Text = "当前树中选择的结点不是一个函数!";
                return;
            }
            obj.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
            obj.FuncName = "Copy_" + obj.FuncName;
            try
            {
                clsFunction4GeneCodeBL.AddNewRecordBySql2(obj);

            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }

            BindTv_CodeType_PrjFeature_Function4GeneCode();
        }

        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strFuncId4GC = wucvFunction4GeneCode4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strFuncId4GC) == true) return;
            if (strFuncId4GC == null || strFuncId4GC.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";


            try
            {
                clsFunction4GeneCodeBLEx.AdjustSequenceNumber("UP", strFuncId4GC);
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
            BindGv_vFunction4GeneCode();

            wucvFunction4GeneCode4Gv1.SetCheckedItemForGv(strFuncId4GC);
        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strFuncId4GC = wucvFunction4GeneCode4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strFuncId4GC) == true) return;

            if (strFuncId4GC == null || strFuncId4GC.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";

            try
            {
                clsFunction4GeneCodeBLEx.AdjustSequenceNumber("DOWN", strFuncId4GC);
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
            BindGv_vFunction4GeneCode();

            wucvFunction4GeneCode4Gv1.SetCheckedItemForGv(strFuncId4GC);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;

            string strCodeTypeId = ddlCodeTypeIdq.SelectedValue;
            string strProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
            try
            {
                clsFunction4GeneCodeBLEx.ReOrder(strCodeTypeId, strProgLangTypeId);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            BindGv_vFunction4GeneCode();

        }
        private bool PreCheck4Order()
        {

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
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;

            if (lstFuncId4GC == null || lstFuncId4GC.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }

            if (PreCheck4Order() == false) return;
            string strCodeTypeId = ddlCodeTypeIdq.SelectedValue;
            string strProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
            lblMsgList.Text = "";

            try
            {
                clsFunction4GeneCodeBLEx.GoTop(lstFuncId4GC, strCodeTypeId, strProgLangTypeId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFunction4GeneCode();
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            if (lstFuncId4GC == null || lstFuncId4GC.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            if (PreCheck4Order() == false) return;
            string strCodeTypeId = ddlCodeTypeIdq.SelectedValue;
            string strProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;

            lblMsgList.Text = "";
            try
            {
                clsFunction4GeneCodeBLEx.GoBottom(lstFuncId4GC, strCodeTypeId, strProgLangTypeId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFunction4GeneCode();
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
                sCodeTypeId = (string)Session["FuncCodeTypeId"];
                if (sCodeTypeId == null)
                {
                    sCodeTypeId = "";
                }
                return sCodeTypeId;
            }
            set
            {
                string sCodeTypeId = value;
                Session.Add("FuncCodeTypeId", sCodeTypeId);
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

        protected void btnSetFuncId4Code_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            if (lstFuncId4GC.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "没有选择记录，请选择一个有效的表记录!");
                return;
            }
            if (ddlFuncId4Code.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择Code函数!");
                ddlFuncId4Code.Focus();
                return;
            }

            string strFuncId4Code = ddlFuncId4Code.SelectedValue;
            foreach (string strFuncId4GC in lstFuncId4GC)
            {
                clsFunction4GeneCodeEN objcc_Function4GeneCode = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
                objcc_Function4GeneCode.FuncId4Code = strFuncId4Code;

                objcc_Function4GeneCode.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objcc_Function4GeneCode.UpdUser = clsCommonSession.UserId;

                clsFunction4GeneCodeBL.UpdateBySql2(objcc_Function4GeneCode);
                i++;
            }

            clsCommonJsFunc.Alert(this, string.Format("设置Code函数成功！共设置了[{0}]条记录！", i));
            BindGv_vFunction4GeneCode();
            BindTv_CodeType_PrjFeature_Function4GeneCode();
        }

        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            if (lstFuncId4GC.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002677)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strFuncId4GC in lstFuncId4GC)
                {
                    clsFunction4GeneCodeBLEx.SetInUse(strFuncId4GC, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFunction4GeneCode();
        }

        protected void btnSetFuncGcType_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            if (lstFuncId4GC.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "没有选择记录，请选择一个有效的表记录!");
                return;
            }
            if (ddlFuncGCTypeId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择函数代码类型!");
                ddlFuncGCTypeId.Focus();
                return;
            }

            string strFuncGCTypeId = ddlFuncGCTypeId.SelectedValue;
            foreach (string strFuncId4GC in lstFuncId4GC)
            {

                clsFunction4GeneCodeEN objcc_Function4GeneCode = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
                objcc_Function4GeneCode.FuncGCTypeId = strFuncGCTypeId;

                objcc_Function4GeneCode.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objcc_Function4GeneCode.UpdUser = clsCommonSession.UserId;

                clsFunction4GeneCodeBL.UpdateBySql2(objcc_Function4GeneCode);
                i++;
            }

            clsCommonJsFunc.Alert(this, string.Format("设置函数代码类型成功！共设置了[{0}]条记录！", i));
            BindGv_vFunction4GeneCode();
        }

        protected void btnBatchUpdate_Click(object sender, EventArgs e)
        {
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            if (lstFuncId4GC.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "没有选择记录，请选择一些有效的表记录!");
                return;
            }
            vsIsShowDivBatchUpdate = "true";
            ShowDiv4BatchUpdate();

        }
        private void HideDiv4BatchUpdate()
        {
            string strJs = string.Format("HideDiv4BatchUpdate();");
            this.ClientScript.RegisterStartupScript(this.GetType(), "HideDiv4BatchUpdate", strJs, true);
        }
        private void ShowDiv4BatchUpdate()
        {
            string strJs = string.Format("ShowDiv4BatchUpdate();");
            this.ClientScript.RegisterStartupScript(this.GetType(), "ShowDiv4BatchUpdate", strJs, true);
        }
        //protected void btnOKBatchUpdate_Click(object sender, EventArgs e)
        //{
        //    vsIsShowDivBatchUpdate = "false";
        //    List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
        //    if (lstFuncId4GC == null) return;
        //    if (lstFuncId4GC.Count == 0)
        //    {
        //        lblMsgList.Text = "(errid:WebI002677)没有选择记录,请选择一些有效的表记录!";
        //        return;
        //    }
        //    lblMsgList.Text = "";
        //    try
        //    {
        //        int intCount = 0;
        //        foreach (string strFuncId4GC in lstFuncId4GC)
        //        {
        //            clsFunction4GeneCodeEN objFunction4GeneCode = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
        //            if (string.IsNullOrEmpty( wucFunction4GC4BatchUpdate1.SourceStr) == false
        //                && string.IsNullOrEmpty(wucFunction4GC4BatchUpdate1.TargetStr) == false)
        //            {
        //                objFunction4GeneCode.FuncName = objFunction4GeneCode.FuncName.Replace(wucFunction4GC4BatchUpdate1.SourceStr, wucFunction4GC4BatchUpdate1.TargetStr);
        //            }

        //            if (string.IsNullOrEmpty(wucFunction4GC4BatchUpdate1.AdditionalPrefix) == false)
        //            {
        //                objFunction4GeneCode.FuncName = wucFunction4GC4BatchUpdate1.AdditionalPrefix+ 
        //                                                    objFunction4GeneCode.FuncName;
        //            }

        //            if (string.IsNullOrEmpty(wucFunction4GC4BatchUpdate1.ProgLangTypeId) == false)
        //            {
        //                objFunction4GeneCode.ProgLangTypeId = wucFunction4GC4BatchUpdate1.ProgLangTypeId;
        //            }

        //            if (string.IsNullOrEmpty(wucFunction4GC4BatchUpdate1.FuncCodeTypeId) == false)
        //            {
        //                objFunction4GeneCode.FuncCodeTypeId = wucFunction4GC4BatchUpdate1.FuncCodeTypeId;
        //            }
        //            if (string.IsNullOrEmpty(wucFunction4GC4BatchUpdate1.FeatureId) == false)
        //            {
        //                objFunction4GeneCode.FeatureId = wucFunction4GC4BatchUpdate1.FeatureId;
        //            }
        //            objFunction4GeneCode.UpdDate = clsDateTime.getTodayDateTimeStr(1);
        //            objFunction4GeneCode.UpdUser = clsCommonSession.UserId;

        //            clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCode);
        //            intCount++;
        //        }
        //        string strMsg = string.Format("已经批量修改了[{0}]条记录！", intCount);
        //        clsCommonJsFunc.Alert(this, strMsg);
        //    }
        //    catch (Exception objException)
        //    {
        //        vsIsShowDivBatchUpdate = "true";
        //        seErrMessage = objException.Message;
        //        clsCommonJsFunc.Alert(this, seErrMessage);
        //        return;
        //    }
        //    BindGv_vFunction4GeneCode();
        //    HideDiv4BatchUpdate();
        //}

        //protected void btnClear_Click(object sender, EventArgs e)
        //{
        //    wucFunction4GC4BatchUpdate1.Clear();
        //    TestShowModal();
        //}

        protected void ddlProgLangTypeId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProgLangTypeIdq.SelectedIndex == 0)
            {
                clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeIdq);
                return;
            }
            string strProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
            clsCodeTypeBLEx.BindDdl_CodeTypeIdByProgLangTypeidEx(ddlCodeTypeIdq, strProgLangTypeId);
            BindTv_CodeType_PrjFeature_Function4GeneCode();
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
            BindTv_CodeType_PrjFeature_Function4GeneCode();
        }


        protected void btnSetCodeTypeByLang_Click(object sender, EventArgs e)
        {
            vsIsShowDivBatchUpdate = "false";
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            if (lstFuncId4GC.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002677)没有选择记录,请选择一些有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                int intCount = 0;
                foreach (string strFuncId4GC in lstFuncId4GC)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCode = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
                    clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objFunction4GeneCode.FuncCodeTypeId);
                    if (objFunction4GeneCode.ProgLangTypeId == objCodeTypeEN.ProgLangTypeId) continue;
                    string strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                        conCodeType.ProgLangTypeId, objFunction4GeneCode.ProgLangTypeId,
                        conCodeType.CodeTypeName, objCodeTypeEN.CodeTypeName);
                    clsCodeTypeEN objCodeTypeEN_New = clsCodeTypeBL.GetFirstObj_S(strCondition);
                    if (objCodeTypeEN_New == null) continue;
                    objFunction4GeneCode.FuncCodeTypeId = objCodeTypeEN_New.CodeTypeId;

                    objFunction4GeneCode.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objFunction4GeneCode.UpdUser = clsCommonSession.UserId;

                    clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCode);
                    intCount++;
                }
                string strMsg = string.Format("已经批量修改了[{0}]条记录！", intCount);
                clsCommonJsFunc.Alert(this, strMsg);
            }
            catch (Exception objException)
            {
                vsIsShowDivBatchUpdate = "true";
                seErrMessage = objException.Message;
                clsCommonJsFunc.Alert(this, seErrMessage);
                return;
            }
            BindGv_vFunction4GeneCode();
            HideDiv4BatchUpdate();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //lblMsgEdit.Text = "AA";
            //TestShowModal();


        }
        private void TestShowModal()
        {
            string strJs = string.Format("TestShowModal();");
            this.ClientScript.RegisterStartupScript(this.GetType(), "TestShowModal", strJs, true);
        }

        protected void btnCopyAndCreateNewFuncName_Click(object sender, EventArgs e)
        {
            string strFuncName4New = txtFuncName4New.Text;
            if (string.IsNullOrEmpty(strFuncName4New) == true)
            {
                clsCommonJsFunc.Alert(this, "请输入新的函数名！");
                txtFuncName4New.Focus();
                return;
            }
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            if (lstFuncId4GC.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002673)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strFuncId4GC = lstFuncId4GC[0];
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(strFuncId4GC);
            clsFunction4CodeEN objFunction4Code = null;
            string strCondition = string.Format("{0}='{1}'",
                conFunction4Code.FuncName4Code, strFuncName4New);
            if (clsFunction4CodeBL.IsExistRecord(strCondition) == true)
            {
                objFunction4Code = clsFunction4CodeBL.GetFirstObj_S(strCondition);
            }
            else
            {
                objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4Code(objFunction4GeneCodeEN.FuncId4Code);
                objFunction4Code.FuncName4Code = strFuncName4New;
                objFunction4Code.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
                objFunction4Code.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objFunction4Code.UpdUser = clsCommonSession.UserId;

                clsFunction4CodeBL.AddNewRecordBySql2(objFunction4Code);
            }
            objFunction4GeneCodeEN.FuncId4Code = objFunction4Code.FuncId4Code;
            objFunction4GeneCodeEN.UpdUser = clsCommonSession.UserId;
            objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);

            clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCodeEN);
            BindGv_vFunction4GeneCode();
        }

        protected void gvFunction4GeneCode_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //DataRowView drv = (DataRowView)e.Row.DataItem;
                ////DataRow objDR = (DataRow)e.Row.DataItem ;

                //clsvFunction4GeneCodeEN objCurr = clsvFunction4GeneCodeBL.GetObjByDataRow_S(drv);//.DataItem
                //if (string.IsNullOrEmpty(objCurr.FuncId4Code)) return;
                //clsvFunction4CodeEN objvFunction4Code = clsvFunction4CodeBL.GetObjByFuncId4CodeCache(objCurr.FuncId4Code);

                //if (objvFunction4Code.ParaNum > 0)
                //{

                //    clsFunction4CodeEN objFunction4Code = objvFunction4Code.CopyToFromViewToTab();
                //    string strFunctionSignatureSim = objFunction4Code.GetFunctionSignatureSim(objCurr.ProgLangTypeId);
                //    //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
                //    //e.Row.Attributes["class"] = "text-muted bg-info";
                //    //e.Row.CssClass = "text-muted bg-info";
                //    int intIndex4Key = clsCommForWebForm.GetIndexByDataField4GridView(gvFunction4GeneCode,
                //       convFunction4GeneCode.FuncName4Code);
                //    e.Row.Cells[intIndex4Key].Text = string.Format("{0}", strFunctionSignatureSim);

                //}
            }
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vFunction4GeneCode()
        {
            //操作步骤:(共5步)
            //	1、设置Gv控件的某些列不可见;
            //	2、组合界面条件串；
            //	3、调用控件中的绑定GridView函数;

            try
            {
                //	1、设置Gv控件的某些列不可见；
                wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.FuncName4Code, false);
                wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.FuncCHName4Code, false);


                //wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.FeatureCount, false);
                //wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.UpdUser, false);
                //	2、组合界面条件串；
                string strWhereCond = CombineFunction4GeneCodeCondition();
                //	3、调用控件中的绑定GridView函数；
                wucvFunction4GeneCode4Gv1.BindGv_Function4GeneCode(strWhereCond, 0);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFunction4GeneCode4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strFuncId4GC = e.KeyId;
            DeleteFunction4GeneCodeRecord(strFuncId4GC);
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFunction4GeneCode4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strFuncId4GC = e.KeyId;
            UpdateFunction4GeneCodeRecord(strFuncId4GC);
        }

        protected void btnSetFeatureId_Click(object sender, EventArgs e)
        {
            if (ddlFeatureId.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请选择功能!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlFeatureId.Focus();
                return;
            }
            string strFeatureId = ddlFeatureId.SelectedValue;
            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            try
            {
                foreach (string strFuncId4GC in lstFuncId4GC)
                {
                    clsFunction4GeneCodeEN obj = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
                    obj.SetFeatureId(strFeatureId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId)
                        .SetMemo("用户设置")
                        .UpdateRecordEx();
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFunction4GeneCode();
            BindTv_CodeType_PrjFeature_Function4GeneCode();
        }

        private void BindTv_CodeType_PrjFeature_Function4GeneCode()
        {
            string strProgLangTypeId = "";
            if (ddlProgLangTypeId4CodeTypeq.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请选择语言!";
                //clsCommonJsFunc.Alert(this, lblMsgList.Text);
                //ddlProgLangTypeIdq.Focus();
                //return;
            }
            else
            {
                strProgLangTypeId = ddlProgLangTypeId4CodeTypeq.SelectedValue;
            }

            if (ddlDependsOn.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请选择依赖!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlDependsOn.Focus();
                return;
            }
            string strDependsOn = ddlDependsOn.SelectedValue;
            string strGroupName = "";
            if (ddlGroupName.SelectedIndex > 0)
            {
                strGroupName = ddlGroupName.SelectedValue;
            }   


            wucTreeView1.tmTreeModel = TreeModel.CodeType_PrjFeature_Function4GeneCode;
            wucTreeView1.ProgLangTypeId = strProgLangTypeId;
            wucTreeView1.DependsOn = strDependsOn;
            wucTreeView1.GroupName = strGroupName;

            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.CollapseAll();
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            //wucTreeView1.ExpandLevel1();
            if (string.IsNullOrEmpty(strTypeName) == false && string.IsNullOrEmpty(strKeyId) == false)
            {
                wucTreeView1.SelectNodeEx(strTypeName, strKeyId);
            }
            if (strTypeName == convPrjFeature._CurrTabName)
            {
                wucTreeView1.CurrNode.Expand();
            }
        }

        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView1.GetCurrPathNodeKeyIdLst();
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            //wucTreeView1.CollapseAll();
            switch (strTypeName)
            {
                case conCodeType._CurrTabName:
                    ddlCodeTypeIdq.SelectedValue = strKeyId;
                    ddlFeatureIdq.SelectedIndex = 0;
                    break;
                case convPrjFeature._CurrTabName:
                    ddlCodeTypeIdq.SelectedValue = wucTreeView1.NodeData.CodeTypeId;
                    string[] arr = strKeyId.Split("-".ToCharArray());
                    try
                    {
                        ddlFeatureIdq.SelectedValue = arr[1];
                    }
                    catch (Exception objException)
                    {
                        clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);

                    }
                    break;
                case convFunction4GeneCode._CurrTabName:
                    ddlCodeTypeIdq.SelectedValue = wucTreeView1.NodeData.CodeTypeId;

                    break;
            }

            vsKeyId = strKeyId;
            vsTreeNodeType = strTypeName;
            wucTreeView1.SelectNodeEx(arrCurrPathNodeKeyIdLst);
            BindGv_vFunction4GeneCode();
            //btnGetCurrNodeRelaValue_Click(null, null);
            //throw new NotImplementedException();
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

        protected void ibRefreshFuncId4Code_Click(object sender, ImageClickEventArgs e)
        {
            clsFunction4CodeBLEx.BindDdl_FuncId4CodeWithSignatureEx(ddlFuncId4Code);
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            BindTv_CodeType_PrjFeature_Function4GeneCode();
        }

        protected void ddlDependsOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDependsOn.SelectedIndex > 0 )
            {
                if (ddlProgLangTypeIdq.SelectedIndex > 0)
                {
                    clsCodeTypeBLEx.BindDdl_GroupNameByDependsOn(ddlGroupName, ddlDependsOn.SelectedValue, ddlProgLangTypeIdq.SelectedValue);
                }
                else
                {
                    clsCodeTypeBLEx.BindDdl_GroupNameByDependsOn(ddlGroupName, ddlDependsOn.SelectedValue);
                }
            }
            BindTv_CodeType_PrjFeature_Function4GeneCode();

        }

        protected void ddlGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindTv_CodeType_PrjFeature_Function4GeneCode();
        }

    }
}