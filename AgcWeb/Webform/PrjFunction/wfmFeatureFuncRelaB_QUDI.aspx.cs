
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmFeatureFuncRelaB_QUDI
表名:FeatureFuncRela
生成代码版本:2018.03.19.1
生成日期:2018/03/20 00:16:26
生成者:
工程名称:AGC
工程ID:0005
模块中文名:函数管理
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
    /// wfmFeatureFuncRelaB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCode)
    /// </summary>
    public partial class wfmFeatureFuncRelaB_QUDI : System.Web.UI.Page
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

                vsViewName = "功能函数关系维护";
                vsTabName = string.Format("{0}", clsvFeatureFuncRelaEN._CurrTabName);
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
                wucFeatureFuncRelaB1.SetDdl_ApplicationTypeId();
                wucFeatureFuncRelaB1.SetDdl_FeatureId(new List<string> { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03 });
                wucFeatureFuncRelaB1.SetDdl_FuncId4GC((int)enumApplicationType.WebApp_2);

                clsPrjFeatureTypeBL.BindDdl_FeatureTypeId(ddlFeatureTypeIdq);
                clsFunction4GeneCodeBLEx.BindDdl_FuncId4GCByAppliationTypeId(ddlFuncId4GCq, (int)enumApplicationType.WebApp_2);

                clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureIdq,
                    new List<string> { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03 });

                clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureId, 
                    new List<string> { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03 });
                clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq);


                clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeIdq);

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
                    //HideDiv4BatchUpdate();
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }


                ddlApplicationTypeIdq.SelectedValue = "2";
                if (string.IsNullOrEmpty(qsFeatureId) == false)
                {
                    ddlFeatureId.SelectedValue = qsFeatureId;
                    ddlFeatureIdq.SelectedValue = qsFeatureId;
                    ddlFeatureIdq.Enabled = false;
                    ddlFeatureId.Enabled = false;
                    hidIsDispTreeView.Value = "false";
                }
                else
                {
                    hidIsDispTreeView.Value = "true";
                }
                if (string.IsNullOrEmpty(qsParentPage) == false)
                {
                    btnReturn.Visible = true;
                }
                else
                {
                    btnReturn.Visible = false;
                }
               wucvFeatureFuncRela4Gv1.SetSortBy(string.Format("{0} Asc", conFeatureFuncRela.mId));
                //2、显示无条件的表内容在GridView中
                BindGv_vFeatureFuncRela();
                BindTv_PrjFeature_Function4GeneCodeByAppId();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                DispFeatureFuncRelaListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsFeatureFuncRelaBL.objCommFun4BL = new clsCommFun4BL4FeatureFuncRela();
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
            this.wucvFeatureFuncRela4Gv1.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_vFeatureFuncRela();
            BindTv_PrjFeature_Function4GeneCodeByAppId();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vFeatureFuncRela()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            if (ddlApplicationTypeIdq.SelectedIndex <= 0)
            {
                ddlApplicationTypeIdq.Focus();
                clsCommonJsFunc.Alert(this, "请选择一个应用类型！");
                return;

            }
            int intApplicationTypeId = int.Parse(ddlApplicationTypeIdq.SelectedValue);
            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevFeatureFuncRelaCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvFeatureFuncRela4Gv1.PageSize = "15";
                wucvFeatureFuncRela4Gv1.BindGv_FeatureFuncRela(strWhereCond, intApplicationTypeId);
           
                //	3、设置Gv控件的某些列不可见；
                wucvFeatureFuncRela4Gv1.SetGvVisibility(convFeatureFuncRela.FeatureName, false);
                wucvFeatureFuncRela4Gv1.SetGvVisibility(convFeatureFuncRela.ApplicationTypeId, false);
                wucvFeatureFuncRela4Gv1.SetGvVisibility(convFeatureFuncRela.KeyWords, false);

                wucvFeatureFuncRela4Gv1.SetGvVisibility(convFeatureFuncRela.UpdDate, false);
                wucvFeatureFuncRela4Gv1.SetGvVisibility(convFeatureFuncRela.UpdUser, false);
                wucvFeatureFuncRela4Gv1.SetGvVisibility(convFeatureFuncRela.FeatureTypeName, true);
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
        protected string CombinevFeatureFuncRelaCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
            try
            {
                if (this.ddlApplicationTypeIdq.SelectedValue != "" && this.ddlApplicationTypeIdq.SelectedValue != "0")
                {
                    objvFeatureFuncRelaEN.ApplicationTypeId = int.Parse(this.ddlApplicationTypeIdq.SelectedValue.ToString());
                    strWhereCond += string.Format(" And {0} = {1}", convFeatureFuncRela.ApplicationTypeId, this.ddlApplicationTypeIdq.SelectedValue);
                }
                if (this.ddlFeatureIdq.SelectedValue != "" && this.ddlFeatureIdq.SelectedValue != "0")
                {
                    objvFeatureFuncRelaEN.FeatureId = this.ddlFeatureIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFeatureFuncRela.FeatureId, this.ddlFeatureIdq.SelectedValue);
                }
                if (this.txtKeyWordsq.Text.Trim() != "")
                {
                    objvFeatureFuncRelaEN.KeyWords = this.txtKeyWordsq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFeatureFuncRela.KeyWords, this.txtKeyWordsq.Text.Trim());
                }
                if (this.ddlFeatureTypeIdq.SelectedValue != "" && this.ddlFeatureTypeIdq.SelectedValue != "0")
                {
                    objvFeatureFuncRelaEN.FeatureTypeId = this.ddlFeatureTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFeatureFuncRela.FeatureTypeId, this.ddlFeatureTypeIdq.SelectedValue);
                }
                if (this.ddlFuncId4GCq.SelectedValue != "" && this.ddlFuncId4GCq.SelectedValue != "0")
                {
                    objvFeatureFuncRelaEN.FuncId4Code = this.ddlFuncId4GCq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFeatureFuncRela.FuncId4Code, this.ddlFuncId4GCq.SelectedValue);
                }
                if (this.txtFuncName4GCq.Text.Trim() != "")
                {
                    objvFeatureFuncRelaEN.FuncName4Code = this.txtFuncName4GCq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFeatureFuncRela.FuncName, this.txtFuncName4GCq.Text.Trim());
                }

                if (this.ddlProgLangTypeIdq.SelectedValue != "" && this.ddlProgLangTypeIdq.SelectedValue != "0")
                {
                    seProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
                    //strWhereCond += string.Format(" And {0} = '{1}'", convFeatureFuncRela.ProgLangTypeId, this.ddlProgLangTypeIdq.SelectedValue);
                }
                else
                {
                    seProgLangTypeId = "";
                }
                if (this.ddlCodeTypeIdq.SelectedValue != "" && this.ddlCodeTypeIdq.SelectedValue != "0")
                {
                    seCodeTypeId = ddlCodeTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFeatureFuncRela.FuncCodeTypeId, this.ddlCodeTypeIdq.SelectedValue);
                }
                else
                {
                    seCodeTypeId = "";
                }

                clsvFeatureFuncRelaBL.CheckProperty4Condition(objvFeatureFuncRelaEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineFeatureFuncRelaCondition)时出错!请联系管理员!" + objException.Message);
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
            AddFeatureFuncRelaRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddFeatureFuncRelaRecord()
        {
            if (ddlApplicationTypeIdq.SelectedIndex <= 0)
            {
                ddlApplicationTypeIdq.Focus();
                clsCommonJsFunc.Alert(this, "请选择一个应用类型！");
                return;
            }
            int intApplicationTypeId = int.Parse(ddlApplicationTypeIdq.SelectedValue);
            btnOKUpd.Text = "确认添加";
            btnCancelFeatureFuncRelaEdit.Text = "取消添加";
            wucFeatureFuncRelaB1.ApplicationTypeId = intApplicationTypeId;
            wucFeatureFuncRelaB1.SetDdl_FuncId4GC(intApplicationTypeId);
            DispEditFeatureFuncRelaRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddFeatureFuncRelaRecordSave()
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
            clsFeatureFuncRelaEN objFeatureFuncRelaEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucFeatureFuncRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsFeatureFuncRelaEN objFeatureFuncRelaEN;	//定义对象
            objFeatureFuncRelaEN = new clsFeatureFuncRelaEN();  //初始化新对象
                                                                //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                                                                //4、把值从界面层传到逻辑层或数据实体层
            PutDataToFeatureFuncRelaClass(objFeatureFuncRelaEN);        //把界面的值传到
                                                                        //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFeatureFuncRelaBL.CheckPropertyNew(objFeatureFuncRelaEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFeatureFuncRelaBL.AddNewRecordBySql2(objFeatureFuncRelaEN);
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
            BindGv_vFeatureFuncRela();
            DispFeatureFuncRelaListRegion();
            wucFeatureFuncRelaB1.Clear();       //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFeatureFuncRelaEdit.Text = "取消编辑";
            return true;
        }
      
        #endregion 添加相关函数


        #region 修改相关函数

        ///// <summary>
        /////从列表中获取选择的第一个关键字
        ///// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetFirstCheckedKeyFromGv)
        ///// </summary>/// <returns>返回选择的第一个关键字</returns>
        //private long GetFirstCheckedKeyFromGv()
        //{
        //    List<string> lstMId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvFeatureFuncRela, conFeatureFuncRela.mId);
        //    if (lstMId.Count == 0)
        //    {
        //        lblMsgList.Text = "(errid:WebI000015)没有选择记录,请选择有效的表记录!";
        //        return 0;
        //    }
        //    lblMsgList.Text = "";
        //    //1、显示该关键字的数据让用户修改该关键字记录；
        //    long lngmId = long.Parse(lstMId[0]);
        //    return lngmId;
        //}

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpdate4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            if (ddlApplicationTypeIdq.SelectedIndex <= 0)
            {
                ddlApplicationTypeIdq.Focus();
                clsCommonJsFunc.Alert(this, "请选择一个应用类型！");
                return;
            }
            int intApplicationTypeId = int.Parse(ddlApplicationTypeIdq.SelectedValue);
            wucFeatureFuncRelaB1.SetDdl_FuncId4GC(intApplicationTypeId);
            long lngmId = wucvFeatureFuncRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            UpdateFeatureFuncRelaRecord(lngmId);
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
            if (clsFeatureFuncRelaBL.IsExist(lngmId) == false)      //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[FeatureFuncRela]中,关键字为:[lngmId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsFeatureFuncRelaEN objFeatureFuncRelaEN = new clsFeatureFuncRelaEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsFeatureFuncRelaBL.GetFeatureFuncRela(ref objFeatureFuncRelaEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objFeatureFuncRelaEN", objFeatureFuncRelaEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromFeatureFuncRelaClass(objFeatureFuncRelaEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjFeatureFuncRelaEN">表实体类对象</param>
        protected void GetDataFromFeatureFuncRelaClass(clsFeatureFuncRelaEN pobjFeatureFuncRelaEN)
        {
            wucFeatureFuncRelaB1.ApplicationTypeId = pobjFeatureFuncRelaEN.ApplicationTypeId;// 应用程序类型ID
            wucFeatureFuncRelaB1.FeatureId = pobjFeatureFuncRelaEN.FeatureId;// 功能Id
            //wucFeatureFuncRelaB1.FuncId4Code = pobjFeatureFuncRelaEN.FuncId4Code;// 函数Id4Code

            wucFeatureFuncRelaB1.FuncId4GC = pobjFeatureFuncRelaEN.FuncId4GC;// 函数Id4Code
            wucFeatureFuncRelaB1.Memo = pobjFeatureFuncRelaEN.Memo;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateFeatureFuncRelaRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelFeatureFuncRelaEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditFeatureFuncRelaRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objFeatureFuncRelaEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateFeatureFuncRelaRecordSave(clsFeatureFuncRelaEN objFeatureFuncRelaEN)
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
            if (!wucFeatureFuncRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToFeatureFuncRelaClass(objFeatureFuncRelaEN);        //把界面的值传到
                                                                        //3.1、检查传进去的对象属性是否合法
            try
            {
                clsFeatureFuncRelaBL.CheckPropertyNew(objFeatureFuncRelaEN);
                //4、把数据实体层的数据存贮到数据库中
                clsFeatureFuncRelaBL.UpdateBySql2(objFeatureFuncRelaEN);
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
            BindGv_vFeatureFuncRela();
            DispFeatureFuncRelaListRegion();
            wucFeatureFuncRelaB1.Clear();//添空控件中的内容
                                         //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelFeatureFuncRelaEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_FeatureFuncRela{0}'", objFeatureFuncRelaEN.mId.ToString().Trim()), true);
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
            clsFeatureFuncRelaEN objFeatureFuncRelaEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddFeatureFuncRelaRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddFeatureFuncRelaRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objFeatureFuncRelaEN = (clsFeatureFuncRelaEN)Session["objFeatureFuncRelaEN"];
                    UpdateFeatureFuncRelaRecordSave(objFeatureFuncRelaEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelFeatureFuncRelaEdit_Click(object sender, EventArgs e)
        {
            DispFeatureFuncRelaListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjFeatureFuncRelaEN">数据传输的目的类对象</param>
        protected void PutDataToFeatureFuncRelaClass(clsFeatureFuncRelaEN pobjFeatureFuncRelaEN)
        {
            pobjFeatureFuncRelaEN.ApplicationTypeId = wucFeatureFuncRelaB1.ApplicationTypeId;// 应用程序类型ID
            pobjFeatureFuncRelaEN.FeatureId = wucFeatureFuncRelaB1.FeatureId;// 功能Id
            pobjFeatureFuncRelaEN.FuncId4GC = wucFeatureFuncRelaB1.FuncId4GC;// 函数Id4Code
            pobjFeatureFuncRelaEN.UpdDate = wucFeatureFuncRelaB1.UpdDate;// 修改日期
            pobjFeatureFuncRelaEN.UpdUser = wucFeatureFuncRelaB1.UpdUser;// 修改者
            pobjFeatureFuncRelaEN.Memo = wucFeatureFuncRelaB1.Memo;// 说明
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        ///// <summary>
        /////从列表中获取所有选择的关键字
        ///// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetAllCheckedKeysFromGv)
        ///// </summary>/// <returns>返回所有选择的关键字列表</returns>
        //private List<long> GetAllCheckedKeysFromGv()
        //{
        //    List<string> lstMId = clsCommForWebForm.GetAllCheckedItemFromGv(gvFeatureFuncRela, conFeatureFuncRela.mId);
        //    if (lstMId.Count == 0)
        //    {
        //        lblMsgList.Text = "(errid:WebI000016)没有选择记录,请选择有效的表记录!";
        //        return null;
        //    }
        //    lblMsgList.Text = "";
        //    List<long> arrMIdLst = new List<long>();
        //    //1、显示该关键字的数据让用户修改该关键字记录；
        //    foreach (string strMId in lstMId)
        //    {
        //        long lngmId = long.Parse(strMId);
        //        arrMIdLst.Add(lngmId);
        //    }
        //    return arrMIdLst;
        //}

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<long> lstMId = wucvFeatureFuncRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsFeatureFuncRelaBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_vFeatureFuncRela();
        }
       
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteFeatureFuncRelaRecord(long lngmId)
        {
            try
            {
                clsFeatureFuncRelaBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_vFeatureFuncRela();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vFeatureFuncRela]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevFeatureFuncRelaCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FeatureFuncRela信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convFeatureFuncRela.FeatureId); arrCnName.Add("功能Id");
            arrColName.Add(convFeatureFuncRela.FeatureName); arrCnName.Add("功能名称");
            arrColName.Add(convFeatureFuncRela.KeyWords); arrCnName.Add("关键字");
            arrColName.Add(convFeatureFuncRela.FeatureTypeId); arrCnName.Add("功能类型Id");
            arrColName.Add(convFeatureFuncRela.FeatureTypeName); arrCnName.Add("功能类型名称");
            arrColName.Add(convFeatureFuncRela.FuncId4Code); arrCnName.Add("函数Id4Code");
            arrColName.Add(convFeatureFuncRela.FuncName4Code); arrCnName.Add("函数名4Code");
            arrColName.Add(convFeatureFuncRela.FunctionSignature); arrCnName.Add("函数签名");
            arrColName.Add(convFeatureFuncRela.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convFeatureFuncRela.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convFeatureFuncRela.Memo); arrCnName.Add("说明");
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
                objDT = clsvFeatureFuncRelaBL.GetDataTable(strWhereCond);
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
        private void DispEditFeatureFuncRelaRegion()
        {
            divList.Visible = false;
            tabEditFeatureFuncRelaRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispFeatureFuncRelaListRegion()
        {
            divList.Visible = true;
            tabEditFeatureFuncRelaRegion.Visible = false;
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

        private string qsFeatureId
        {
            get
            {
                string strFeatureId = Request.QueryString["FeatureId"] ?? "".ToString();
                if ((strFeatureId != null) && (strFeatureId != ""))
                {
                    return strFeatureId;
                }
                else
                {
                    return "";
                }
            }
        }

        private string qsParentPage
        {
            get
            {
                string strParentPage = Request.QueryString["ParentPage"] ?? "".ToString();
                if ((strParentPage != null) && (strParentPage != ""))
                {
                    return strParentPage;
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
        /// 功能Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FeatureId
        {
            get
            {
                if (ddlFeatureId.SelectedValue == "0")
                    return "";
                return ddlFeatureId.SelectedValue;
            }
            set
            {
                if (ddlFeatureId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFeatureId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFeatureId.SelectedValue = value;
                    }
                }
            }
        }
        /// <summary>
        /// 功能Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public int ApplicationTypeId
        {
            get
            {
                if (ddlApplicationTypeIdq.SelectedValue == "0")
                    return 0;
                return int.Parse( ddlApplicationTypeIdq.SelectedValue);
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

        protected void btnBatchAddFunc_Click(object sender, EventArgs e)
        {
            if (ddlApplicationTypeIdq.SelectedIndex <= 0)
            {
                ddlApplicationTypeIdq.Focus();
                clsCommonJsFunc.Alert(this, "请选择一个应用类型！");
                return;

            }
            int intApplicationTypeId = int.Parse(ddlApplicationTypeIdq.SelectedValue);
            if (ddlFeatureId.SelectedIndex<=0)
            {
                ddlFeatureId.Focus();
                clsCommonJsFunc.Alert(this, "请选择一个功能！");
                return;

            }
            //gvFeatureFuncRela.Visible = false
            wucvFunction4GeneCode4Gv1.SetVisible (true);
            wucvFunction4GeneCode4Gv1.SetGvVisibility("修改", false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility("删除", false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.FunctionSignature, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.FuncTypeName, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.UpdDate, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.UpdUser, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.ReturnTypeName, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.Memo, false);
            //wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.ParaNum, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.Order4FeatureNum, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.ReturnTypeName, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.IsTemplate, false);

            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.FuncTypeName, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.FuncGCTypeName, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.SqlDsTypeName, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.OrderNum, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.FeatureTypeName, false);
            wucvFunction4GeneCode4Gv1.SetGvVisibility(convFunction4GeneCode.FuncId4GC, false);

            string strWhereCond = CombineFunction4GeneCodeCondition();
            wucvFunction4GeneCode4Gv1.PageSize = "15";
            wucvFunction4GeneCode4Gv1.BindGv_Function4GeneCode(strWhereCond, intApplicationTypeId);
        }
        
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

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineFunction4GeneCodeCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = string.Format(" 1 = 1 And {0} not in (Select {0} From {1} Where {2} ={3} and {4} ='{5}') ",
                convFunction4GeneCode.FuncId4GC, clsFeatureFuncRelaEN._CurrTabName,
                conFeatureFuncRela.ApplicationTypeId,
                ApplicationTypeId,
                conFeatureFuncRela.FeatureId,
                FeatureId,
                convFunction4GeneCode.FuncTypeId,
                enumFunctionType.ViewBackgroundFunction_11);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
            try
            {
              
                if (this.ddlApplicationTypeIdq.SelectedValue != "" && this.ddlApplicationTypeIdq.SelectedValue != "0")
                {
                    int intApplicationTypeId = int.Parse(this.ddlApplicationTypeIdq.SelectedValue);
                    List<string> arrProgLangTypeIdLst = clsApplicationTypeBLEx.GetProgLangTypeIdLst(intApplicationTypeId);
                    string sstrProgLangTypeId = clsArray.GetSqlInStrByArray(arrProgLangTypeIdLst, true);
                    //objvFunction4GeneCodeEN.ApplicationTypeId = int.Parse(this.ddlApplicationTypeIdq.SelectedValue.ToString());
                    strWhereCond += string.Format(" And {0} in ({1})",
                        convFunction4GeneCode.ProgLangTypeId, sstrProgLangTypeId);
                }
                if (this.txtFuncName4GCq.Text.Trim() != "")
                {
                    objvFunction4GeneCodeEN.FuncName = this.txtFuncName4GCq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", 
                        convFunction4GeneCode.FuncName, this.txtFuncName4GCq.Text.Trim());
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
               
                clsvFunction4GeneCodeBL.CheckProperty4Condition(objvFunction4GeneCodeEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineFunction4CodeCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        protected void btnConfirmBatchAddFunc_Click(object sender, EventArgs e)
        {
            if (ddlApplicationTypeIdq.SelectedIndex <= 0)
            {
                ddlApplicationTypeIdq.Focus();
                clsCommonJsFunc.Alert(this, "请选择一个应用类型！");
                return;

            }
            int intApplicationTypeId = int.Parse(ddlApplicationTypeIdq.SelectedValue);
            if (ddlFeatureId.SelectedIndex <= 0)
            {
                ddlFeatureId.Focus();
                clsCommonJsFunc.Alert(this, "请选择一个功能！");
                return;
            }

            List<string> lstFuncId4GC = wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncId4GC == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strFuncId4GC in lstFuncId4GC)
                {
                    clsFeatureFuncRelaBLEx.AddFeatureFuncRelaRecordSave(intApplicationTypeId, FeatureId, strFuncId4GC, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            wucvFunction4GeneCode4Gv1.SetVisible ( false);
            BindGv_vFeatureFuncRela();
            BindTv_PrjFeature_Function4GeneCodeByAppId();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(qsParentPage) == false)
            {
                Response.Redirect(qsParentPage);
            }
        }

        protected void ddlApplicationTypeId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlApplicationTypeIdq.SelectedIndex <= 0) return;
            int intApplicationTypeId = int.Parse(ddlApplicationTypeIdq.SelectedValue);
            wucFeatureFuncRelaB1.SetDdl_FuncId4GC(intApplicationTypeId);
            clsFunction4GeneCodeBLEx.BindDdl_FuncId4GCByAppliationTypeId(ddlFuncId4GCq, intApplicationTypeId);

        }
        private void BindTv_PrjFeature_Function4GeneCodeByAppId()
        {
            wucTreeView1.tmTreeModel = TreeModel.PrjFeatureType_PrjFeature_Function4GeneCode;
            wucTreeView1.ApplicationTypeId = ApplicationTypeId;
            try
            {
                wucTreeView1.BindTv();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            wucTreeView1.Expand(1);
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucTreeView1.ExpandLevel1();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }

        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView1.GetCurrPathNodeKeyIdLst();
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(arrCurrPathNodeKeyIdLst);
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

        protected void ddlFeatureTypeId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFeatureTypeIdq.SelectedIndex == 0)
            {
                clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureIdq,
                    new List<string> { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03 });

                clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureId,
                    new List<string> { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.TabFeature_03 });
                return;
            }
            string strPrjFeatureTypeId = ddlFeatureTypeIdq.SelectedValue;
            clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureId, strPrjFeatureTypeId);
            clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureIdq, strPrjFeatureTypeId);

        }

        protected void btnCopyToNewAppId_Click(object sender, EventArgs e)
        {
            if (ddlApplicationTypeId.SelectedIndex == 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个新应用");
                ddlApplicationTypeId.Focus();
                return;
            }
            List<long> lstMId = new List<long>();// wucvFunction4GeneCode4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsFeatureFuncRelaEN obj = clsFeatureFuncRelaBL.GetObjBymId(lngmId);
                    obj.ApplicationTypeId = int.Parse(ddlApplicationTypeId.SelectedValue);
                    obj.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(clsCommonSession.UserId);
                    obj.EditRecordEx();

                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_vFeatureFuncRela();
        }

    }
}