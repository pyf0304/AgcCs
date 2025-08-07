
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmPrjFeatureB_QUDI
表名:PrjFeature
生成代码版本:2017.03.30.1
生成日期:2017/03/31
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.02.21.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
/// == == == == == == == == == == == == 
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
using com.taishsoft.web.treeview;

using AGC.web.treeview;

namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjFeatureB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCode)
    /// </summary>
    public partial class wfmPrjFeatureB_QUDI : CommWebPageBase
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

                vsViewName = "功能维护";
                vsTabName = string.Format("{0}", clsvPrjFeatureEN._CurrTabName);
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
                wucPrjFeatureB1.SetDdl_FeatureTypeId();
                wucPrjFeatureB1.SetDdl_FunctionGroupId();
                wucPrjFeatureB1.SetDdl_RegionTypeId();
                wucPrjFeatureB1.SetDdl_InOutTypeId();
                wucPrjFeatureB1.SetDdl_ParentFeatureId();

                clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq);
                ddlApplicationTypeIdq.SelectedValue = "2";
                clsPrjFeatureTypeBL.BindDdl_FeatureTypeIdCache(ddlFeatureTypeIdq);
                //clsFunctionGroupBL.BindDdlFunctionGroupId(ddlFunctionGroupIdq);
                clsRegionTypeBL.BindDdl_RegionTypeIdCache(ddlRegionTypeId);
    
                wucvPrjFeature4Gv1.SetSortBy(string.Format("{0} Asc", convPrjFeature.OrderNum));
                //2、显示无条件的表内容在GridView中
                BindTv_PrjFeatureType();
                BindGv_vPrjFeature();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucPrjFeatureB1.SetKeyReadOnly(true);
                DispPrjFeatureListRegion();
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
            wucvPrjFeature4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vPrjFeature();
        }
      
        protected void BindGv_vPrjFeature()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;
            if (ApplicationTypeId == 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个应用类型！");
                ddlApplicationTypeIdq.Focus();
                return;
            }
            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevPrjFeatureCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvPrjFeature4Gv1.BindGv_PrjFeature(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvPrjFeature4Gv1.SetGvVisibility(convPrjFeature.UpdDate, false);
                //wucvPrjFeature4Gv1.SetGvVisibility(convPrjFeature.UpdUser, false);
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
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinevPrjFeatureCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try
            {
                if (this.txtFeatureIdq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convPrjFeature.FeatureId, this.txtFeatureIdq.Text.Trim());
                }
                if (this.txtFeatureNameq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convPrjFeature.FeatureName, this.txtFeatureNameq.Text.Trim());
                }
                if (this.ddlFunctionGroupIdq.SelectedValue != "" && this.ddlFunctionGroupIdq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convPrjFeature.FunctionGroupId, this.ddlFunctionGroupIdq.SelectedValue);
                }
                if (this.ddlFeatureTypeIdq.SelectedValue != "" && this.ddlFeatureTypeIdq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convPrjFeature.FeatureTypeId, this.ddlFeatureTypeIdq.SelectedValue);
                }
                if (this.txtCreateUserIdq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convPrjFeature.CreateUserId, this.txtCreateUserIdq.Text.Trim());
                }
                if (this.txtKeyWordsq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convPrjFeature.KeyWords, this.txtKeyWordsq.Text.Trim());
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI002727)在组合查询条件(CombinePrjFeatureCondition)时出错!请联系管理员!" + objException.Message);
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


   


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddPrjFeatureRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddPrjFeatureRecord()
        {
            wucPrjFeatureB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelPrjFeatureEdit.Text = "取消添加";
            wucPrjFeatureB1.FeatureId = clsPrjFeatureBL.GetMaxStrId_S();
            wucPrjFeatureB1.CreateUserId = clsCommonSession.UserId;
            DispEditPrjFeatureRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddPrjFeatureRecordSave()
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
            clsPrjFeatureEN objPrjFeatureEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjFeatureB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002728)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsPrjFeatureEN objPrjFeatureEN;	//定义对象
            objPrjFeatureEN = new clsPrjFeatureEN(wucPrjFeatureB1.FeatureId);   //初始化新对象
                                                                                //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsPrjFeatureBL.IsExist(objPrjFeatureEN.FeatureId)) //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002729)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjFeatureClass(objPrjFeatureEN);      //把界面的值传到
                                                            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsPrjFeatureBL.CheckPropertyNew(objPrjFeatureEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjFeatureBL.AddNewRecordBySql2(objPrjFeatureEN);
                clstz_CommKeyWordsBLEx.EditTableKeyWords(clsPrjFeatureEN._CurrTabName, objPrjFeatureEN.FeatureId, objPrjFeatureEN.KeyWords, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI002730)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_vPrjFeature();
            DispPrjFeatureListRegion();
            wucPrjFeatureB1.Clear();        //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjFeatureEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddPrjFeatureRecordSaveV5()
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
            clsPrjFeatureEN objPrjFeatureEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjFeatureB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002731)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsPrjFeatureEN objPrjFeatureEN;	//定义对象
            objPrjFeatureEN = new clsPrjFeatureEN(wucPrjFeatureB1.FeatureId);   //初始化新对象
                                                                                //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsPrjFeatureBL.IsExist(objPrjFeatureEN.FeatureId)) //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002732)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjFeatureClass(objPrjFeatureEN);      //把界面的值传到
                                                            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsPrjFeatureBL.CheckPropertyNew(objPrjFeatureEN);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjFeatureBL.AddNewRecordBySql2(objPrjFeatureEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002733)添加记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_vPrjFeature();
            DispPrjFeatureListRegion();
            wucPrjFeatureB1.Clear();        //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjFeatureEdit.Text = "取消编辑";
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
            string strFeatureId = wucvPrjFeature4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strFeatureId) == true) 
            {
                lblMsgList.Text = "(errid:WebI002734)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
     
            UpdatePrjFeatureRecord(strFeatureId);
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strFeatureId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strFeatureId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strFeatureId == "") return;     //如果关键字为空就返回退出
                                                //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsPrjFeatureBL.IsExist(strFeatureId) == false)     //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI002735)在表[PrjFeature]中,关键字为:[strFeatureId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN(strFeatureId);
            //4、获取类对象的所有属性；
            try
            {
                clsPrjFeatureBL.GetPrjFeature(ref objPrjFeatureEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objPrjFeatureEN", objPrjFeatureEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromPrjFeatureClass(objPrjFeatureEN);
            vsKeyWords = objPrjFeatureEN.KeyWords;
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjPrjFeatureEN">表实体类对象</param>
        protected void GetDataFromPrjFeatureClass(clsPrjFeatureEN pobjPrjFeatureEN)
        {
            wucPrjFeatureB1.FeatureId = pobjPrjFeatureEN.FeatureId;// 功能Id
            wucPrjFeatureB1.FeatureName = pobjPrjFeatureEN.FeatureName;// 功能名称
            wucPrjFeatureB1.DefaButtonName = pobjPrjFeatureEN.DefaButtonName;// 功能名称
            wucPrjFeatureB1.GroupName = pobjPrjFeatureEN.GroupName;// 功能名称
            wucPrjFeatureB1.RegionTypeId = pobjPrjFeatureEN.RegionTypeId;// 功能名称
            wucPrjFeatureB1.InOutTypeId = pobjPrjFeatureEN.InOutTypeId;// INOUT类型ID
            wucPrjFeatureB1.KeyWords = pobjPrjFeatureEN.KeyWords;// 关键字
            wucPrjFeatureB1.ParentFeatureId = pobjPrjFeatureEN.ParentFeatureId;// 函数组Id
            wucPrjFeatureB1.FunctionGroupId = pobjPrjFeatureEN.FunctionGroupId;// 函数组Id
            wucPrjFeatureB1.FeatureTypeId = pobjPrjFeatureEN.FeatureTypeId;// 功能类型Id
            wucPrjFeatureB1.FeatureDescription = pobjPrjFeatureEN.FeatureDescription;// 功能类型Id
            wucPrjFeatureB1.InUse = pobjPrjFeatureEN.InUse;// 功能类型Id

            wucPrjFeatureB1.CreateUserId = pobjPrjFeatureEN.CreateUserId;// 建立用户Id        
            wucPrjFeatureB1.Memo = pobjPrjFeatureEN.Memo;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdatePrjFeatureRecord(string strFeatureId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strFeatureId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucPrjFeatureB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelPrjFeatureEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditPrjFeatureRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objPrjFeatureEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdatePrjFeatureRecordSave(clsPrjFeatureEN objPrjFeatureEN)
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
            if (!wucPrjFeatureB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002736)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjFeatureClass(objPrjFeatureEN);      //把界面的值传到
                                                            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsPrjFeatureBL.CheckPropertyNew(objPrjFeatureEN);
                //4、把数据实体层的数据存贮到数据库中
                clsPrjFeatureBL.UpdateBySql2(objPrjFeatureEN);
                if (vsKeyWords.CompareTo(objPrjFeatureEN.KeyWords) != 0)
                {
                    clstz_CommKeyWordsBLEx.EditTableKeyWords(clsPrjFeatureEN._CurrTabName, objPrjFeatureEN.FeatureId, objPrjFeatureEN.KeyWords, clsCommonSession.UserId);
                }
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
            BindGv_vPrjFeature();
            DispPrjFeatureListRegion();
            wucPrjFeatureB1.Clear();//添空控件中的内容
                                    //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjFeatureEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_PrjFeature{0}'", objPrjFeatureEN.FeatureId.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objPrjFeatureEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdatePrjFeatureRecordSaveV5(clsPrjFeatureEN objPrjFeatureEN)
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
            if (!wucPrjFeatureB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002737)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjFeatureClass(objPrjFeatureEN);      //把界面的值传到
                                                            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsPrjFeatureBL.CheckPropertyNew(objPrjFeatureEN);
                //4、把数据实体层的数据存贮到数据库中
                clsPrjFeatureBL.UpdateBySql2(objPrjFeatureEN);
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
            BindGv_vPrjFeature();
            DispPrjFeatureListRegion();
            wucPrjFeatureB1.Clear();//添空控件中的内容
                                    //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjFeatureEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_PrjFeature{0}'", objPrjFeatureEN.FeatureId.ToString().Trim()), true);
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
            clsPrjFeatureEN objPrjFeatureEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddPrjFeatureRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddPrjFeatureRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objPrjFeatureEN = (clsPrjFeatureEN)Session["objPrjFeatureEN"];
                    UpdatePrjFeatureRecordSave(objPrjFeatureEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelPrjFeatureEdit_Click(object sender, EventArgs e)
        {
            DispPrjFeatureListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjPrjFeatureEN">数据传输的目的类对象</param>
        protected void PutDataToPrjFeatureClass(clsPrjFeatureEN pobjPrjFeatureEN)
        {
            pobjPrjFeatureEN.SetFeatureId(wucPrjFeatureB1.FeatureId)// 功能Id
                .SetInOutTypeId(wucPrjFeatureB1.InOutTypeId);// INOUT类型ID;
            pobjPrjFeatureEN.FeatureName = wucPrjFeatureB1.FeatureName;// 功能名称
            pobjPrjFeatureEN.KeyWords = wucPrjFeatureB1.KeyWords;// 关键字
            pobjPrjFeatureEN.ParentFeatureId = wucPrjFeatureB1.ParentFeatureId;// 函数组Id
            if (string.IsNullOrEmpty(pobjPrjFeatureEN.ParentFeatureId) == false)
            {
                pobjPrjFeatureEN.ParentFeatureName = clsPrjFeatureBL.GetObjByFeatureId(pobjPrjFeatureEN.ParentFeatureId).FeatureName;
            }
            else
            {
                pobjPrjFeatureEN.ParentFeatureName = "";
            }
            pobjPrjFeatureEN.FunctionGroupId = wucPrjFeatureB1.FunctionGroupId;// 函数组Id

            pobjPrjFeatureEN.RegionTypeId = wucPrjFeatureB1.RegionTypeId;// 功能类型Id
            pobjPrjFeatureEN.FeatureTypeId = wucPrjFeatureB1.FeatureTypeId;// 功能类型Id
            pobjPrjFeatureEN.FeatureDescription = wucPrjFeatureB1.FeatureDescription;// 功能类型Id
            pobjPrjFeatureEN.CreateUserId = wucPrjFeatureB1.CreateUserId;// 建立用户Id
            pobjPrjFeatureEN.UpdDate = wucPrjFeatureB1.UpdDate;// 修改日期
            pobjPrjFeatureEN.UpdUser = wucPrjFeatureB1.UpdUser;// 修改者
            pobjPrjFeatureEN.Memo = wucPrjFeatureB1.Memo;// 说明
            pobjPrjFeatureEN.SetDefaButtonName(wucPrjFeatureB1.DefaButtonName)
                .SetGroupName(wucPrjFeatureB1.GroupName)// 组名
                .SetInUse(wucPrjFeatureB1.InUse);// 默认按钮名
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstFeatureId = wucvPrjFeature4Gv1.GetAllCheckedKeysFromGv();
            if (lstFeatureId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strFeatureId in lstFeatureId)
                {
                    clsPrjFeatureBL.DelRecord(strFeatureId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vPrjFeature();
        }
       
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strFeatureId">给定关键字</param>
        protected void DeletePrjFeatureRecord(string strFeatureId)
        {
            try
            {
                clsPrjFeatureBL.DelRecord(strFeatureId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vPrjFeature();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vPrjFeature]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevPrjFeatureCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "PrjFeature信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convPrjFeature.FeatureId); arrCnName.Add("功能Id");
            arrColName.Add(convPrjFeature.FeatureName); arrCnName.Add("功能名称");
            arrColName.Add(convPrjFeature.FeatureTypeId); arrCnName.Add("功能类型Id");
            arrColName.Add(convPrjFeature.FeatureTypeName); arrCnName.Add("功能类型名称");
            arrColName.Add(convPrjFeature.CreateUserId); arrCnName.Add("建立用户Id");
            arrColName.Add(convPrjFeature.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convPrjFeature.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convPrjFeature.Memo); arrCnName.Add("说明");
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
                objDT = clsvPrjFeatureBL.GetDataTable(strWhereCond);
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
        private void DispEditPrjFeatureRegion()
        {
            divList.Visible = false;
            tabEditPrjFeatureRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispPrjFeatureListRegion()
        {
            divList.Visible = true;
            tabEditPrjFeatureRegion.Visible = false;
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


        /// <summary>
        /// KeyWords:关键字
        /// </summary>
        protected string vsKeyWords
        {
            get
            {
                string sKeyWords;
                sKeyWords = (string)ViewState["KeyWords"];
                if (sKeyWords == null)
                {
                    sKeyWords = "";
                }
                return sKeyWords;
            }
            set
            {
                string sKeyWords = value;
                ViewState.Add("KeyWords", sKeyWords);
            }
        }

        protected void btnCloneNewRec4Gv_Click(object sender, EventArgs e)
        {
            List<string> lstFeatureId = wucvPrjFeature4Gv1.GetAllCheckedKeysFromGv();
            //if (lstFeatureId == null) return;
            if (lstFeatureId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            //string[] strKeys = lstKeyValue[0].Split(',');
            string strFeatureId = lstFeatureId[0];
            clsPrjFeatureEN obj = new clsPrjFeatureEN(strFeatureId);
            clsPrjFeatureBL.GetPrjFeature(ref obj);
            obj.FeatureId = clsPrjFeatureBL.GetMaxStrId_S();
            obj.FeatureName = "Copy_" + obj.FeatureName;
            try
            {
                clsPrjFeatureBL.AddNewRecordBySql2(obj);
                BindGv_vPrjFeature();
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void btnUpMove_Click(object sender, EventArgs e)
        {
            MoveRecord("UP");
        }
        protected void btnDownMove_Click(object sender, EventArgs e)
        {
            MoveRecord("DOWN");
        }
        protected void btnReOrder_Click(object sender, EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strFeatureTypeId = ddlFeatureTypeIdq.SelectedValue;
            try
            {
                clsPrjFeatureBL.ReOrder(strFeatureTypeId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("重序出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevPrjFeatureCondition();
            wucvPrjFeature4Gv1.BindGv_PrjFeature(strWhereCond);
        }

        /// <summary>
        ///移动记录，包括上移和下移
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_MoveRecord)
        /// </summary>
        protected void MoveRecord(string strDirect)
        {
            if (PreCheck4Order() == false) return;
            string strFeatureTypeId = ddlFeatureTypeIdq.SelectedValue;
            string strFeatureId = wucvPrjFeature4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strFeatureId) == true)
            {
                lblMsgList.Text = string.Format("请选择需要移动({0})的记录!", strDirect);
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsPrjFeatureBL.AdjustOrderNum(strDirect, strFeatureId, strFeatureTypeId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("移动({0})记录出错。错误:{1}.({2})", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevPrjFeatureCondition();
            wucvPrjFeature4Gv1.BindGv_PrjFeature(strWhereCond);
            wucvPrjFeature4Gv1.SetCheckedItemForGv(strFeatureId);
        }

        /// <summary>
        ///置底
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PreCheck4Order)
        /// </summary>
        private bool PreCheck4Order()
        {
            if (ddlFeatureTypeIdq.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请输入FeatureTypeId!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlFeatureTypeIdq.Focus();
                return false;
            }
            return true;
        }

        protected void btnGoTop_Click(object sender, EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strFeatureTypeId = ddlFeatureTypeIdq.SelectedValue;
            List<string> arrFeatureId = wucvPrjFeature4Gv1.GetAllCheckedKeysFromGv();
            if (arrFeatureId == null)
            {
                lblMsgList.Text = "请选择需要置顶的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsPrjFeatureBL.GoTop(arrFeatureId, strFeatureTypeId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevPrjFeatureCondition();
            wucvPrjFeature4Gv1.BindGv_PrjFeature(strWhereCond);
            wucvPrjFeature4Gv1.SetCheckedItemsForGv(arrFeatureId);
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strFeatureTypeId = ddlFeatureTypeIdq.SelectedValue;
            List<string> arrFeatureId = wucvPrjFeature4Gv1.GetAllCheckedKeysFromGv();
            if (arrFeatureId == null)
            {
                lblMsgList.Text = "请选择需要置底的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsPrjFeatureBL.GoBottom(arrFeatureId, strFeatureTypeId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置底出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevPrjFeatureCondition();
            wucvPrjFeature4Gv1.BindGv_PrjFeature(strWhereCond);
            wucvPrjFeature4Gv1.SetCheckedItemsForGv(arrFeatureId);
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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", 
                        qsParentPage, clsStackTrace.GetCurrClassFunction()));
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
        /// <summary>
        /// 应用程序类型ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public int ApplicationTypeId
        {
            get
            {
                if (ddlApplicationTypeIdq.SelectedValue == "0")
                    return 0;
                return int.Parse(ddlApplicationTypeIdq.SelectedValue);
            }
            set
            {
                if (ddlApplicationTypeIdq.Items.Count > 0)
                {
                    if (value == 0)
                    {
                        ddlApplicationTypeIdq.SelectedValue = "0";
                    }
                    else
                    {
                        ddlApplicationTypeIdq.SelectedValue = value.ToString();
                    }
                }
            }
        }

        protected void btnSetIsNeedField_Click(object sender, EventArgs e)
        {
            List<string> lstFeatureId = wucvPrjFeature4Gv1.GetAllCheckedKeysFromGv();
            if (lstFeatureId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002738)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strFeatureId in lstFeatureId)
                {
                    K_FeatureId_PrjFeature objKey = new K_FeatureId_PrjFeature(strFeatureId);
                    clsPrjFeatureEN objPrjFeature = objKey.GetObj();
                    objPrjFeature
                        .SetIsNeedField(!objPrjFeature.IsNeedField)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId)
                        .Update();
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vPrjFeature();
        }

        protected void btnSetRegionTypeId_Click(object sender, EventArgs e)
        {
            List<string> lstFeatureId = wucvPrjFeature4Gv1.GetAllCheckedKeysFromGv();
            if (lstFeatureId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002734)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            if (ddlRegionTypeId.SelectedIndex<=0)
            {
                lblMsgList.Text = "请选择区域类型!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlRegionTypeId.Focus();
                return;
            }
            string strRegionTypeId = ddlRegionTypeId.SelectedValue;
            lblMsgList.Text = "";
            try
            {
                foreach (string strFeatureId in lstFeatureId)
                {
                    K_FeatureId_PrjFeature objKey = new K_FeatureId_PrjFeature(strFeatureId);
                    clsPrjFeatureEN objPrjFeature = objKey.GetObj();
                    objPrjFeature.SetRegionTypeId(strRegionTypeId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId)
                        .Update();

                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000032)设置区域类型Id不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vPrjFeature();
        }



        private void BindTv_PrjFeatureType()
        {
            //string strProgLangTypeId = "";
            //if (ddlProgLangTypeIdq.SelectedIndex <= 0)
            //{
            //    lblMsgList.Text = "请选择语言!";
            //    //clsCommonJsFunc.Alert(this, lblMsgList.Text);
            //    //ddlProgLangTypeIdq.Focus();
            //    //return;
            //}
            //else
            //{
            //    strProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
            //}

            //if (ddlDependsOn.SelectedIndex <= 0)
            //{
            //    lblMsgList.Text = "请选择依赖!";
            //    clsCommonJsFunc.Alert(this, lblMsgList.Text);
            //    ddlDependsOn.Focus();
            //    return;
            //}
            //string strDependsOn = ddlDependsOn.SelectedValue;
            //string strGroupName = "";
            //if (ddlGroupName.SelectedIndex > 0)
            //{
            //    strGroupName = ddlGroupName.SelectedValue;
            //}



            wucTreeView1.tmTreeModel = TreeModel.PrjFeatureType;
            //wucTreeView1.ProgLangTypeId = strProgLangTypeId;
            //wucTreeView1.DependsOn = strDependsOn;
            //wucTreeView1.GroupName = strGroupName;

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
              
                case conPrjFeatureType._CurrTabName:
                    ddlFeatureTypeIdq.SelectedValue = wucTreeView1.NodeData.PrjFeatureTypeId;
                   
                    break;

            }

            vsKeyId = strKeyId;
            vsTreeNodeType = strTypeName;
            wucTreeView1.SelectNodeEx(arrCurrPathNodeKeyIdLst);
            BindGv_vPrjFeature();
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
    }
}