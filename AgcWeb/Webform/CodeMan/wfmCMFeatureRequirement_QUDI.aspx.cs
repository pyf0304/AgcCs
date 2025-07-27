
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmCMFeatureRequirement_QUDI
界面名:wfmCMFeatureRequirement_QUDI(00050262)
生成代码版本:2019.11.08.1
生成日期:2019/11/13 08:42:14
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
using AGC.web.treeview;
using com.taishsoft.web.treeview;
using System.Linq;

namespace AGC.Webform
{
    /// <summary>
    /// wfmCMFeatureRequirement_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmCMFeatureRequirement_QUDI : System.Web.UI.Page
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

                vsViewName = "CM功能需求关系维护";
                vsTabName = string.Format("{0}", clsvCMFeatureRequirementEN._CurrTabName);
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
                //wucCMFeatureRequirement1.SetDdl_CmFeatureId();
                //wucCMFeatureRequirement1.SetDdl_ReqId();
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjIdq, clsPubVar.CurrSelPrjId);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleAgcIdEx(ddlFuncModuleAgcIdq, clsPubVar.CurrSelPrjId);

                ddlCmPrjIdq.SelectedIndex = 1;
                string strCmPrjId = ddlCmPrjIdq.SelectedValue;
                //if (string.IsNullOrEmpty(strCmPrjId) == false)
                //{
                //    vsCmPrjId = strCmPrjId;
                //    clsCMProjectEN objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(vsCmPrjId);
                //    if (objCMProject != null)
                //    {
                //        lblLstTitle4CMFeatureRequirement.Text = string.Format("功能:[{0}]的相关需求如下:", objCMProject.CmPrjName);
                //    }
                //}

                clsCMFeatureBLEx.BindDdl_UserIdEx(ddlUserIdq);

                wucvCMFeatureRequirement4Gv1.SetSortBy(string.Format("{0} Asc", convCMFeatureRequirement.OrderNum));

                BindTv_ApplicationType_CMProject_FuncModule_Agc4Feature();

                //2、显示无条件的表内容在GridView中
                BindGv_vCMFeatureRequirement();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                DispCMFeatureRequirementListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsCMFeatureRequirementBL.objCommFun4BL = new clsCommFun4BL4CMFeatureRequirement();
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
            wucvCMFeatureRequirement4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vCMFeatureRequirement();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vCMFeatureRequirement()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevCMFeatureRequirementCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvCMFeatureRequirement4Gv1.BindGv_CMFeatureRequirement(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvCMFeatureRequirement4Gv1.SetGvVisibility(convCMFeatureRequirement.UpdDate, false);
                //wucvCMFeatureRequirement4Gv1.SetGvVisibility(convCMFeatureRequirement.UpdUser, false);
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
        protected string CombinevCMFeatureRequirementCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = new clsvCMFeatureRequirementEN();
            try
            {
                if (string.IsNullOrEmpty(vsCmFeatureId) == false)
                {
                    List<string> arrSubCmFeatureId = vsSubCmFeatureIdLst;
                    if (arrSubCmFeatureId == null)
                    {
                        objvCMFeatureRequirementEN.CmFeatureId = vsCmFeatureId;
                        strWhereCond += string.Format(" And {0} = '{1}'", convCMFeatureRequirement.CmFeatureId,
                            vsCmFeatureId);
                    }
                    else
                    {
                        arrSubCmFeatureId.Add(vsCmFeatureId);
                        strWhereCond += string.Format(" And {0} in ({1})", 
                            convCMFeatureRequirement.CmFeatureId,
                            clsArray.GetSqlInStrByArray( arrSubCmFeatureId, true));
                    }
                }
                if (this.ddlCmPrjIdq.SelectedValue != "" && this.ddlCmPrjIdq.SelectedValue != "0")
                {
                    objvCMFeatureRequirementEN.CmPrjId = this.ddlCmPrjIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMFeatureRequirement.CmPrjId, this.ddlCmPrjIdq.SelectedValue);
                }
                if (string.IsNullOrEmpty(vsFuncModuleAgcId) == false)
                {
                    objvCMFeatureRequirementEN.FuncModuleAgcId = vsFuncModuleAgcId;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMFeatureRequirement.FuncModuleAgcId,
                        vsFuncModuleAgcId);
                }
                if (this.ddlCmFeatureIdq.SelectedValue != "" && this.ddlCmFeatureIdq.SelectedValue != "0")
                {
                    objvCMFeatureRequirementEN.CmFeatureId = this.ddlCmFeatureIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMFeatureRequirement.CmFeatureId, this.ddlCmFeatureIdq.SelectedValue);
                }
                if (this.ddlReqIdq.SelectedValue != "" && this.ddlReqIdq.SelectedValue != "0")
                {
                    objvCMFeatureRequirementEN.ReqId = this.ddlReqIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMFeatureRequirement.ReqId, this.ddlReqIdq.SelectedValue);
                }
                objvCMFeatureRequirementEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineCMFeatureRequirementCondition)时出错!请联系管理员!" + objException.Message);
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
            //AddCMFeatureRequirementRecord();
            if (string.IsNullOrEmpty(vsCmFeatureId) == true)
            {
                string strMsg = "功能Id不能为空!请在树中选择一个功能！";
                clsCommonJsFunc.Alert(this, strMsg);
                //lblMsgEdit.Text = strMsg;
                return;
            }
            clsCMFeatureEN objCMFeature = clsCMFeatureBL.GetObjByCmFeatureId(vsCmFeatureId);
            btnOKUpd2.Text = string.Format("把所选的需求添加到功能:[{0}]中", objCMFeature.FeatureName);
            BindGv_vCMRequirement();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void AddCMFeatureRequirementRecord()
        {
            if (ddlCmPrjIdq.SelectedIndex<=0)
            {
                ddlCmPrjIdq.Focus();
                clsCommonJsFunc.Alert(this, "请选择CM工程！");
                return;
            }
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            wucCMFeatureRequirement1.SetDdl_CmFeatureId(strCmPrjId);
            wucCMFeatureRequirement1.SetDdl_ReqId(strCmPrjId);

            btnOKUpd.Text = "确认添加";
            btnCancelCMFeatureRequirementEdit.Text = "取消添加";
            //wucCMFeatureRequirement1.mId = clsCMFeatureRequirementBL.GetMaxStrId_S();
            wucCMFeatureRequirement1.OrderNum = clsCMFeatureRequirementBL.GetRecCount() + 1;
            DispEditCMFeatureRequirementRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddCMFeatureRequirementRecordSave()
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
            clsCMFeatureRequirementEN objCMFeatureRequirementEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucCMFeatureRequirement1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsCMFeatureRequirementEN objCMFeatureRequirementEN;	//定义对象
            objCMFeatureRequirementEN = new clsCMFeatureRequirementEN();    //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            try
            {
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataToCMFeatureRequirementClass(objCMFeatureRequirementEN);      //把界面的值传到
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
                objCMFeatureRequirementEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objCMFeatureRequirementEN.AddNewRecord();
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
            BindGv_vCMFeatureRequirement();
            DispCMFeatureRequirementListRegion();
            wucCMFeatureRequirement1.Clear();       //清空控件中内容
                                                    ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFeatureRequirementEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId = wucvCMFeatureRequirement4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            UpdateCMFeatureRequirementRecord(lngmId);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdateCMFeatureRequirementRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            if (ddlCmPrjIdq.SelectedIndex <= 0)
            {
                ddlCmPrjIdq.Focus();
                clsCommonJsFunc.Alert(this, "请选择CM工程！");
                return;
            }
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            wucCMFeatureRequirement1.SetDdl_CmFeatureId(strCmPrjId);
            wucCMFeatureRequirement1.SetDdl_ReqId(strCmPrjId);


            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelCMFeatureRequirementEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditCMFeatureRequirementRegion();
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
            if (clsCMFeatureRequirementBL.IsExist(lngmId) == false)     //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[CMFeatureRequirement]中,关键字为:[lngmId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsCMFeatureRequirementEN objCMFeatureRequirementEN = new clsCMFeatureRequirementEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsCMFeatureRequirementBL.GetCMFeatureRequirement(ref objCMFeatureRequirementEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objCMFeatureRequirementEN", objCMFeatureRequirementEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromCMFeatureRequirementClass(objCMFeatureRequirementEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjCMFeatureRequirementEN">表实体类对象</param>
        protected void GetDataFromCMFeatureRequirementClass(clsCMFeatureRequirementEN pobjCMFeatureRequirementEN)
        {
            wucCMFeatureRequirement1.CmFeatureId = pobjCMFeatureRequirementEN.CmFeatureId;// 功能
            wucCMFeatureRequirement1.ReqId = pobjCMFeatureRequirementEN.ReqId;// 需求
            wucCMFeatureRequirement1.OrderNum = pobjCMFeatureRequirementEN.OrderNum;// 序号
            wucCMFeatureRequirement1.Memo = pobjCMFeatureRequirementEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvCMFeatureRequirement4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateCMFeatureRequirementRecord(lngmId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objCMFeatureRequirementEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateCMFeatureRequirementRecordSave(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
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
            if (!wucCMFeatureRequirement1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            try
            {
                //2、把值从界面层传到逻辑层或数据实体层
                PutDataToCMFeatureRequirementClass(objCMFeatureRequirementEN);      //把界面的值传到
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
                objCMFeatureRequirementEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objCMFeatureRequirementEN.Update();
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
            BindGv_vCMFeatureRequirement();
            DispCMFeatureRequirementListRegion();
            wucCMFeatureRequirement1.Clear();//添空控件中的内容
                                             //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMFeatureRequirementEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_CMFeatureRequirement{0}'", objCMFeatureRequirementEN.mId.ToString().Trim()), true);
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
            clsCMFeatureRequirementEN objCMFeatureRequirementEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddCMFeatureRequirementRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddCMFeatureRequirementRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objCMFeatureRequirementEN = (clsCMFeatureRequirementEN)Session["objCMFeatureRequirementEN"];
                    UpdateCMFeatureRequirementRecordSave(objCMFeatureRequirementEN);
                    break;
            }
        }

        protected void btnOKUpd2_Click(object sender, System.EventArgs e)
        {
            string strMsg = "";
            List<string> arrReqId = wucvCMRequirement4Gv1.GetAllCheckedKeysFromGv();
            if (string.IsNullOrEmpty( vsCmFeatureId) == true)
            {
                strMsg = "功能Id不能为空!请在树中选择一个功能！";
                clsCommonJsFunc.Alert(this, strMsg);
                //lblMsgEdit.Text = strMsg;
                return ;
            }
            
            arrReqId.ForEach(x=> {
                clsCMFeatureRequirementEN pobjCMFeatureRequirementEN = new clsCMFeatureRequirementEN();
                pobjCMFeatureRequirementEN.SetCmFeatureId(vsCmFeatureId)// 功能
    .SetReqId(x)// 需求
    .SetOrderNum(0)// 序号
    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))//(字段类型:string,字段长度:20,是否可空:20)
    .SetUpdUser(clsCommonSession.UserId)//(字段类型:string,字段长度:20,是否可空:20)
    .SetMemo(wucCMFeatureRequirement1.Memo);// 说明
                pobjCMFeatureRequirementEN.EditRecordEx();
            });
            strMsg = string.Format("已经添加了{0}条功能需求关系!", arrReqId.Count);
            clsCommonJsFunc.Alert(this, strMsg);

        }


        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjCMFeatureRequirementEN">数据传输的目的类对象</param>
        protected void PutDataToCMFeatureRequirementClass(clsCMFeatureRequirementEN pobjCMFeatureRequirementEN)
        {
            pobjCMFeatureRequirementEN.SetCmFeatureId(wucCMFeatureRequirement1.CmFeatureId)// 功能
            .SetReqId(wucCMFeatureRequirement1.ReqId)// 需求
            .SetOrderNum(wucCMFeatureRequirement1.OrderNum)// 序号
            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))//(字段类型:string,字段长度:20,是否可空:20)
            .SetUpdUser(clsCommonSession.UserId)//(字段类型:string,字段长度:20,是否可空:20)
            .SetMemo(wucCMFeatureRequirement1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelCMFeatureRequirementEdit_Click(object sender, EventArgs e)
        {
            DispCMFeatureRequirementListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<long> lstMId = wucvCMFeatureRequirement4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsCMFeatureRequirementBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vCMFeatureRequirement();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvCMFeatureRequirement4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteCMFeatureRequirementRecord(lngmId);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteCMFeatureRequirementRecord(long lngmId)
        {
            try
            {
                clsCMFeatureRequirementBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vCMFeatureRequirement();
        }

        /// <summary>
        ///置底
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PreCheck4Order)
        /// </summary>
        private bool PreCheck4Order()
        {
            return true;
        }

        /// <summary>
        ///置顶
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnGoTop_Click)
        /// </summary>
        protected void btnGoTop_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            List<long> arrmId = wucvCMFeatureRequirement4Gv1.GetAllCheckedKeysFromGv();
            if (arrmId == null)
            {
                lblMsgList.Text = "请选择需要置顶的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsCMFeatureRequirementBL.GoTop(arrmId, vsCmFeatureId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevCMFeatureRequirementCondition();
            wucvCMFeatureRequirement4Gv1.BindGv_CMFeatureRequirement(strWhereCond);
            wucvCMFeatureRequirement4Gv1.SetCheckedItemsForGv(arrmId);
        }

        /// <summary>
        ///上移
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnUpMove_Click)
        /// </summary>
        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            MoveRecord("UP");
        }

        /// <summary>
        ///下移
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnDownMove_Click)
        /// </summary>
        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            MoveRecord("DOWN");
        }

        /// <summary>
        ///置底
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnGoBottum_Click)
        /// </summary>
        protected void btnGoBottum_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            List<long> arrmId = wucvCMFeatureRequirement4Gv1.GetAllCheckedKeysFromGv();
            if (arrmId == null)
            {
                lblMsgList.Text = "请选择需要置底的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsCMFeatureRequirementBL.GoBottom(arrmId, vsCmFeatureId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置底出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevCMFeatureRequirementCondition();
            wucvCMFeatureRequirement4Gv1.BindGv_CMFeatureRequirement(strWhereCond);
            wucvCMFeatureRequirement4Gv1.SetCheckedItemsForGv(arrmId);
        }

        /// <summary>
        ///重序
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnReOrder_Click)
        /// </summary>
        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            try
            {
                clsCMFeatureRequirementBL.ReOrder(vsCmFeatureId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("重序出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevCMFeatureRequirementCondition();
            wucvCMFeatureRequirement4Gv1.BindGv_CMFeatureRequirement(strWhereCond);
        }

        /// <summary>
        ///移动记录，包括上移和下移
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_MoveRecord)
        /// </summary>
        protected void MoveRecord(string strDirect)
        {
            if (PreCheck4Order() == false) return;
            long lngmId = wucvCMFeatureRequirement4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0)
            {
                lblMsgList.Text = string.Format("请选择需要移动({0})的记录!", strDirect);
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsCMFeatureRequirementBL.AdjustOrderNum(strDirect, lngmId, vsCmFeatureId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("移动({0})记录出错。错误:{1}.({2})", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevCMFeatureRequirementCondition();
            wucvCMFeatureRequirement4Gv1.BindGv_CMFeatureRequirement(strWhereCond);
            wucvCMFeatureRequirement4Gv1.SetCheckedItemForGv(lngmId);
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
        /// 导出Excel。根据查询区组合的查询条件,从[vCMFeatureRequirement]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevCMFeatureRequirementCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "CMFeatureRequirement信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convCMFeatureRequirement.FeatureName); arrCnName.Add("功能名称");
            arrColName.Add(convCMFeatureRequirement.RequirementName); arrCnName.Add("需求名称");
            arrColName.Add(convCMFeatureRequirement.OrderNum); arrCnName.Add("序号");
            arrColName.Add(convCMFeatureRequirement.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convCMFeatureRequirement.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convCMFeatureRequirement.Memo); arrCnName.Add("说明");
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
                objDT = clsvCMFeatureRequirementBL.GetDataTable(strWhereCond);
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
        private void DispCMFeatureRequirementListRegion()
        {
            divList.Visible = true;
            tabEditCMFeatureRequirementRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditCMFeatureRequirementRegion()
        {
            divList.Visible = false;
            tabEditCMFeatureRequirementRegion.Visible = true;
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
        /// ViewState属性:当前记录排序的分类名称
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefProperty_vsClassificationFieldName)
        /// </summary>
        protected string vs
        {
            get
            {
                string sClassificationField;
                sClassificationField = (string)ViewState[""];
                if (sClassificationField == null)
                {
                    sClassificationField = "";
                }
                return sClassificationField;
            }
            set
            {
                string sClassificationField = value;
                ViewState.Add("", sClassificationField);
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

        protected void ddlCmPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsCMFeatureBL.BindDdl_CmFeatureIdCache(ddlCmFeatureIdq, strCmPrjId);
            clsCMRequirementBL.BindDdl_ReqId(ddlReqIdq, strCmPrjId,"");
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


            vsFuncModuleAgcId = "";
            vsApplicationTypeId = "";
            vsCmFeatureId = "";
            vsCmPrjId = "";
            DispCMRequirementLst(false);
            switch (strTypeName)
            {
                case "Root":
                    vsFuncModuleAgcId = "";
                    break;
                case conApplicationType._CurrTabName:
                    vsApplicationTypeId = strKeyId;
                    break;
                case conCMProject._CurrTabName:
                    vsCmPrjId = strKeyId;
                    ddlCmPrjIdq.SelectedValue = strKeyId;
                    clsCMFeatureBL.BindDdl_CmFeatureId(ddlCmFeatureIdq, vsCmPrjId,"");
                    clsCMRequirementBL.BindDdl_ReqId(ddlReqIdq, vsCmPrjId,"");

                    clsCMProjectEN objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(vsCmPrjId);
                    lblLstTitle4CMFeatureRequirement.Text = string.Format("CM项目:[{0}]的相关需求如下:",
                        objCMProject.CmPrjName);
                    //UpdateCMFeatureRecord(vsCmFeatureId);
                    BindGv_vCMFeatureRequirement();


                    //BindData();
                    break;
                case conFuncModule_Agc._CurrTabName:
                    vsFuncModuleAgcId = strKeyId;
                    clsFuncModule_AgcEN objFuncModule_Agc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(vsFuncModuleAgcId, clsPubVar.CurrSelPrjId);
                    lblLstTitle4CMFeatureRequirement.Text = string.Format("模块:[{0}]的相关需求如下:",
                        objFuncModule_Agc.FuncModuleName);
                    //UpdateCMFeatureRecord(vsCmFeatureId);
                    BindGv_vCMFeatureRequirement();
                    break;
                case conCMFeature._CurrTabName:
                    vsCmFeatureId = strKeyId;
                    vsCmPrjId = wucTreeView1.NodeData.CmPrjId;
                    if (string.IsNullOrEmpty(vsCmPrjId) == false)
                    {
                        ddlCmPrjIdq.SelectedValue = vsCmPrjId;
                    }

                    DispCMRequirementLst(true);

                    clsCMFeatureEN objCMFeature = clsCMFeatureBLEx.GetObjByCmFeatureIdExCache(vsCmFeatureId, clsPubVar.CurrSelPrjId);
                    if (string.IsNullOrEmpty( objCMFeature.CmParentFeatureId) == true)
                    {
                        List<string> arrSubCmFeatureId = clsCMFeatureBLEx.GetSubFeatureIdLstByCmFeatureIdCache(objCMFeature.CmFeatureId, clsPubVar.CurrSelPrjId).ToList();
                        vsSubCmFeatureIdLst = arrSubCmFeatureId;
                    }
                    lblLstTitle4CMFeatureRequirement.Text = string.Format("功能:[{0}]的相关需求如下:", objCMFeature.FeatureName);
                    btnOKUpd2.Text = string.Format("把所选的需求添加到功能:[{0}]中", objCMFeature.FeatureName);
                    //UpdateCMFeatureRecord(vsCmFeatureId);
                    BindGv_vCMFeatureRequirement();
                    if (wucvCMRequirement4Gv1.Visible == true)
                    {
                        BindGv_vCMRequirement();
                    }
                    break;

            }

            //btnGetCurrNodeRelaValue_Click(null, null);
            //throw new NotImplementedException();
        }
        private void DispCMRequirementLst(bool bolIsVisible)
        {
            lblTitle4CMRequirementLst.Visible = bolIsVisible;
            btnOKUpd2.Visible = bolIsVisible;
            wucvCMRequirement4Gv1.Visible = bolIsVisible;
        }
        private void BindTv_ApplicationType_CMProject_FuncModule_Agc4Feature()
        {
            wucTreeView1.tmTreeModel = TreeModel.ApplicationType_CMProject_FuncModule_Agc4Feature;
            //if (qsOperateType == "Disp")
            //{
            //    //if (ddlPrjIdq.SelectedIndex > 0)
            //    //{
            //    //    wucTreeView1.PrjId = ddlPrjIdq.SelectedValue;
            //    //}
            //    //else
            //    //{
            //    wucTreeView1.PrjId = clsPubVar.CurrSelPrjId;
            //    //}
            //    if (ddlUserIdq.SelectedIndex > 0)
            //    {
            //        wucTreeView1.UserId = ddlUserIdq.SelectedValue;
            //    }
            //    else
            //    {
            //        wucTreeView1.UserId = "";
            //    }

            //}
            //else
            //{
            //    if (ddlUserIdq.SelectedIndex > 0)
            //    {
            //        wucTreeView1.UserId = ddlUserIdq.SelectedValue;
            //    }
            //    else
            //    {
            //        wucTreeView1.UserId = "";
            //    }
            //    //wucTreeView1.DispNoFunctionClass = chkDispNoFunctionClass.Checked;
            //    wucTreeView1.PrjId = clsPubVar.CurrSelPrjId;
            //}
            try
            {
                wucTreeView1.PrjId = clsPubVar.CurrSelPrjId;
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
            //wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);
            vsFuncModuleAgcId = "";
            vsApplicationTypeId = "";
            //vsCmPrjId = "";
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
        protected string vsApplicationTypeId
        {
            get
            {
                string sApplicationTypeId;
                sApplicationTypeId = (string)ViewState["ApplicationTypeId"];
                if (sApplicationTypeId == null)
                {
                    sApplicationTypeId = "";
                }
                return sApplicationTypeId;
            }
            set
            {
                string sApplicationTypeId = value;
                ViewState.Add("ApplicationTypeId", sApplicationTypeId);
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

        protected string vsFuncModuleAgcId
        {
            get
            {

                string sFuncModuleAgcId;
                sFuncModuleAgcId = (string)ViewState["FuncModuleAgcId"];
                if (sFuncModuleAgcId == null)
                {
                    sFuncModuleAgcId = "";
                }
                return sFuncModuleAgcId;
            }
            set
            {
                string sFuncModuleAgcId = value;
                ViewState.Add("FuncModuleAgcId", sFuncModuleAgcId);
            }
        }

        protected List<string> vsSubCmFeatureIdLst
        {
            get
            {
                List<string> sCmFeatureId;
                sCmFeatureId = (List<string>)ViewState["SubCmFeatureIdLst"];
                return sCmFeatureId;
            }
            set
            {
                List<string> sCmFeatureId = value;
                ViewState.Add("SubCmFeatureIdLst", sCmFeatureId);
            }
        }


        protected string vsCmFeatureId
        {
            get
            {
                string sCmFeatureId;
                sCmFeatureId = (string)ViewState["CmFeatureId"];
                if (sCmFeatureId == null)
                {
                    sCmFeatureId = "";
                }
                return sCmFeatureId;
            }
            set
            {
                string sCmFeatureId = value;
                ViewState.Add("CmFeatureId", sCmFeatureId);
            }
        }
        protected void ddlPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindTv_ApplicationType_CMProject_FuncModule_Agc4Feature();
            //BindData();
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            BindTv_ApplicationType_CMProject_FuncModule_Agc4Feature();
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinevCMRequirementCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = string.Format(" {0} = '{1}' ", convCMRequirement.PrjId, clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvCMRequirementEN objvCMRequirementEN = new clsvCMRequirementEN();
            try
            {
                //if (this.txtReqIdq.Text.Trim() != "")
                //{
                //    objvCMRequirementEN.ReqId = this.txtReqIdq.Text.Trim();
                //    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMRequirement.ReqId, this.txtReqIdq.Text.Trim());
                //}
                //if (this.txtRequirementNameq.Text.Trim() != "")
                //{
                //    objvCMRequirementEN.RequirementName = this.txtRequirementNameq.Text.Trim();
                //    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMRequirement.RequirementName, this.txtRequirementNameq.Text.Trim());
                //}
                if (this.ddlFuncModuleAgcIdq.SelectedValue != "" && this.ddlFuncModuleAgcIdq.SelectedValue != "0")
                {
                    objvCMRequirementEN.FuncModuleAgcId = this.ddlFuncModuleAgcIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMRequirement.FuncModuleAgcId, this.ddlFuncModuleAgcIdq.SelectedValue);
                }
               
                //if (this.ddlIsFinishedq.SelectedIndex == 1)
                //{
                //    objvCMRequirementEN.IsFinished = true;
                //    strWhereCond += string.Format(" And {0} = '1'", convCMRequirement.IsFinished);
                //}
                //else if (this.ddlIsFinishedq.SelectedIndex == 2)
                //{
                //    objvCMRequirementEN.IsFinished = false;
                //    strWhereCond += string.Format(" And {0} = '0'", convCMRequirement.IsFinished);
                //}
     
                if (this.ddlCmPrjIdq.SelectedValue != "" && this.ddlCmPrjIdq.SelectedValue != "0")
                {
                    objvCMRequirementEN.CmPrjId = this.ddlCmPrjIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMRequirement.CmPrjId, this.ddlCmPrjIdq.SelectedValue);
                }
                objvCMRequirementEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineCMRequirementCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }
        protected void BindGv_vCMRequirement()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	3、设置Gv控件的某些列不可见；
                wucvCMRequirement4Gv1.SetGvVisibility(convCMRequirement.PrjName, false);
                wucvCMRequirement4Gv1.SetGvVisibility(convCMRequirement.ApplicationTypeSimName, false);
                wucvCMRequirement4Gv1.SetGvVisibility(convCMRequirement.Memo, false);
                wucvCMRequirement4Gv1.SetGvVisibility("修改", false);
                wucvCMRequirement4Gv1.SetGvVisibility("删除", false);
                //wucvCMRequirement4Gv1.SetGvVisibility(convCMRequirement.UpdUser, false);
                //	1、组合界面条件串；
                string strWhereCond = CombinevCMRequirementCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvCMRequirement4Gv1.BindGv_CMRequirement(strWhereCond);

            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }

        protected void btnDispCMFeatureRequirementLst_Click(object sender, EventArgs e)
        {
            if (wucvCMFeatureRequirement4Gv1.Visible == true)
            {
                wucvCMFeatureRequirement4Gv1.Visible = false;
                btnDispCMFeatureRequirementLst.Text = "显示功能需求关系列表";
            }
            else
            {
                wucvCMFeatureRequirement4Gv1.Visible = true;
                btnDispCMFeatureRequirementLst.Text = "隐藏功能需求关系列表";
            }
        }
    }
}