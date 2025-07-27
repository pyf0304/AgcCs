
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmCMRequirement_QUDI
界面名:wfmCMRequirement_QUDI(00050066)
生成代码版本:2019.11.08.1
生成日期:2019/11/12 08:43:45
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
    /// wfmCMRequirement_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmCMRequirement_QUDI : System.Web.UI.Page
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

                vsViewName = "项目需求维护";
                vsTabName = string.Format("{0}", clsvCMRequirementEN._CurrTabName);
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
                wucCMRequirement1.SetDdl_RequirementTypeId();
                //wucCMRequirement1.SetDdl_UpReqId();
                wucCMRequirement1.SetDdl_FuncModuleAgcId(clsPubVar.CurrSelPrjId);
                wucCMRequirement1.SetDdl_CmPrjId(clsPubVar.CurrSelPrjId);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleAgcIdEx(ddlFuncModuleAgcIdq, clsPubVar.CurrSelPrjId);
                clsCMRequirementTypeBL.BindDdl_RequirementTypeIdCache(ddlRequirementTypeIdq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsFinishedq);
                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjIdq, clsPubVar.CurrSelPrjId);
                clsCMRequirementTypeBL.BindDdl_RequirementTypeIdCache(ddlRequirementTypeId_SetFldValue);
                wucvCMRequirement4Gv1.SetSortBy(string.Format("{0} Asc", convCMRequirement.ReqId));
                //2、显示无条件的表内容在GridView中
                BindGv_vCMRequirement();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucCMRequirement1.SetKeyReadOnly(true);
                DispCMRequirementListRegion();
                if ( new List<string>() { "00050001", "00050005", "00050006"}.Contains(clsCommonSession.RoleId))
                {
                    lblPrjIdq.Visible = true;
                    ddlPrjIdq.Visible = true;
                }
                else
                {
                    lblPrjIdq.Visible = false;
                    ddlPrjIdq.Visible = false;
                }

                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsCMRequirementBL.objCommFun4BL = new clsCommFun4BL4CMRequirement();
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
            wucvCMRequirement4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vCMRequirement();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
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
                if (this.txtReqIdq.Text.Trim() != "")
                {
                    objvCMRequirementEN.ReqId = this.txtReqIdq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMRequirement.ReqId, this.txtReqIdq.Text.Trim());
                }
                if (this.txtRequirementNameq.Text.Trim() != "")
                {
                    objvCMRequirementEN.RequirementName = this.txtRequirementNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convCMRequirement.RequirementName, this.txtRequirementNameq.Text.Trim());
                }
                if (this.ddlFuncModuleAgcIdq.SelectedValue != "" && this.ddlFuncModuleAgcIdq.SelectedValue != "0")
                {
                    objvCMRequirementEN.FuncModuleAgcId = this.ddlFuncModuleAgcIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMRequirement.FuncModuleAgcId, this.ddlFuncModuleAgcIdq.SelectedValue);
                }
                if (this.ddlRequirementTypeIdq.SelectedValue != "" && this.ddlRequirementTypeIdq.SelectedValue != "0")
                {
                    objvCMRequirementEN.RequirementTypeId = this.ddlRequirementTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMRequirement.RequirementTypeId, this.ddlRequirementTypeIdq.SelectedValue);
                }
                if (this.ddlIsFinishedq.SelectedIndex == 1)
                {
                    objvCMRequirementEN.IsFinished = true;
                    strWhereCond += string.Format(" And {0} = '1'", convCMRequirement.IsFinished);
                }
                else if (this.ddlIsFinishedq.SelectedIndex == 2)
                {
                    objvCMRequirementEN.IsFinished = false;
                    strWhereCond += string.Format(" And {0} = '0'", convCMRequirement.IsFinished);
                }
                if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
                {
                    objvCMRequirementEN.PrjId = this.ddlPrjIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convCMRequirement.PrjId, this.ddlPrjIdq.SelectedValue);
                }
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
            AddCMRequirementRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void AddCMRequirementRecord()
        {
            wucCMRequirement1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelCMRequirementEdit.Text = "取消添加";
            wucCMRequirement1.ReqId = clsCMRequirementBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            DispEditCMRequirementRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddCMRequirementRecordSave()
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
            clsCMRequirementEN objCMRequirementEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucCMRequirement1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            wucCMRequirement1.ReqId = clsCMRequirementBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            //2、定义对象并初始化对象
            //clsCMRequirementEN objCMRequirementEN;	//定义对象
            objCMRequirementEN = new clsCMRequirementEN(wucCMRequirement1.ReqId);   //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsCMRequirementBL.IsExist(objCMRequirementEN.ReqId))   //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000004)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            try
            {
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataToCMRequirementClass(objCMRequirementEN);        //把界面的值传到
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
                objCMRequirementEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objCMRequirementEN.AddNewRecord();
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
            BindGv_vCMRequirement();
            DispCMRequirementListRegion();
            wucCMRequirement1.Clear();      //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMRequirementEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnCopyRecord_Click4OneKeyword)
        /// </summary>
        protected void btnCopyRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strReqId = wucvCMRequirement4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strReqId) == true) return;
            CopyRecord(strReqId);
        }

        /// <summary>
        /// 复制记录,把给定关键字的记录内容复制一个新记录，把名称字段值的前面加上"Copy_"
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CopyRecord)
        /// </summary>
        protected void CopyRecord(string strReqId)
        {
            try
            {
                K_ReqId_CMRequirement myKey = new K_ReqId_CMRequirement(strReqId);
                clsCMRequirementEN objCMRequirementEN = myKey.GetObj();
                objCMRequirementEN.ReqId = clsCMRequirementBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId); 
                objCMRequirementEN.AddNewRecord();
                BindGv_vCMRequirement();
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
            string strReqId = wucvCMRequirement4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strReqId) == true) return;
            UpdateCMRequirementRecord(strReqId);
        }

        /// <summary>
        ///设置字段值
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnSetFieldValue_Click)
        /// </summary>
        protected void btnSetRequirementTypeId_Click(object sender, System.EventArgs e)
        {
            List<string> lstReqId = wucvCMRequirement4Gv1.GetAllCheckedKeysFromGv();
            if (lstReqId == null) return;
            if (ddlRequirementTypeId_SetFldValue.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请输入需求类型Id(RequirementTypeId)!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlRequirementTypeId_SetFldValue.Focus();
                return;
            }
            string strRequirementTypeId = ddlRequirementTypeId_SetFldValue.SelectedValue;
            lblMsgList.Text = "";
            try
            {
                foreach (string strReqId in lstReqId)
                {
                    K_ReqId_CMRequirement objKey = new K_ReqId_CMRequirement(strReqId);
                    clsCMRequirementEN objCMRequirement = objKey.GetObj();
                    objCMRequirement.SetRequirementTypeId(strRequirementTypeId);
                    objCMRequirement.Update();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000041)设置需求类型Id不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vCMRequirement();
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdateCMRequirementRecord(string strReqId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strReqId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucCMRequirement1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelCMRequirementEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditCMRequirementRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ShowData)
        /// </summary>
        /// <param name = "strReqId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strReqId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strReqId == "") return;     //如果关键字为空就返回退出
                                            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsCMRequirementBL.IsExist(strReqId) == false)      //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[CMRequirement]中,关键字为:[strReqId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN(strReqId);
            //4、获取类对象的所有属性；
            try
            {
                clsCMRequirementBL.GetCMRequirement(ref objCMRequirementEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objCMRequirementEN", objCMRequirementEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromCMRequirementClass(objCMRequirementEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjCMRequirementEN">表实体类对象</param>
        protected void GetDataFromCMRequirementClass(clsCMRequirementEN pobjCMRequirementEN)
        {
            wucCMRequirement1.ReqId = pobjCMRequirementEN.ReqId;// 需求Id
            wucCMRequirement1.RequirementName = pobjCMRequirementEN.RequirementName;// 名称
            wucCMRequirement1.ReqContent = pobjCMRequirementEN.ReqContent;// 内容
            wucCMRequirement1.RequirementTypeId = pobjCMRequirementEN.RequirementTypeId;// 需求类型Id
            //wucCMRequirement1.UpReqId = pobjCMRequirementEN.UpReqId;// 上级需求
            wucCMRequirement1.IsFinished = pobjCMRequirementEN.IsFinished;// 是否完成
            wucCMRequirement1.FuncModuleAgcId = pobjCMRequirementEN.FuncModuleAgcId;// 模块
            wucCMRequirement1.CmPrjId = pobjCMRequirementEN.CmPrjId;// CM工程Id            
            wucCMRequirement1.Memo = pobjCMRequirementEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvCMRequirement4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strReqId = e.KeyId;
            UpdateCMRequirementRecord(strReqId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objCMRequirementEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateCMRequirementRecordSave(clsCMRequirementEN objCMRequirementEN)
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
            if (!wucCMRequirement1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            try
            {
                //2、把值从界面层传到逻辑层或数据实体层
                PutDataToCMRequirementClass(objCMRequirementEN);        //把界面的值传到
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
                objCMRequirementEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objCMRequirementEN.Update();
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
            BindGv_vCMRequirement();
            DispCMRequirementListRegion();
            wucCMRequirement1.Clear();//添空控件中的内容
                                      //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelCMRequirementEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_CMRequirement{0}'", objCMRequirementEN.ReqId.ToString().Trim()), true);
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
            clsCMRequirementEN objCMRequirementEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddCMRequirementRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddCMRequirementRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objCMRequirementEN = (clsCMRequirementEN)Session["objCMRequirementEN"];
                    UpdateCMRequirementRecordSave(objCMRequirementEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjCMRequirementEN">数据传输的目的类对象</param>
        protected void PutDataToCMRequirementClass(clsCMRequirementEN pobjCMRequirementEN)
        {
            pobjCMRequirementEN.SetReqId(wucCMRequirement1.ReqId)// 需求Id
            .SetRequirementName(wucCMRequirement1.RequirementName)// 名称
            .SetReqContent(wucCMRequirement1.ReqContent)// 内容
            .SetRequirementTypeId(wucCMRequirement1.RequirementTypeId)// 需求类型Id
            //.SetUpReqId(wucCMRequirement1.UpReqId)// 上级需求
            .SetIsFinished(wucCMRequirement1.IsFinished)// 是否完成
            .SetFuncModuleAgcId(wucCMRequirement1.FuncModuleAgcId)// 模块
            .SetCmPrjId(wucCMRequirement1.CmPrjId)// CM工程Id
            .SetPrjId(clsPubVar.CurrSelPrjId)// CM工程Id
            .SetUpdUser(wucCMRequirement1.UpdUser)// 修改者
            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))//(字段类型:string,字段长度:20,是否可空:20)
            .SetMemo(wucCMRequirement1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelCMRequirementEdit_Click(object sender, EventArgs e)
        {
            DispCMRequirementListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<string> lstReqId = wucvCMRequirement4Gv1.GetAllCheckedKeysFromGv();
            if (lstReqId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strReqId in lstReqId)
                {
                    clsCMRequirementBL.DelRecord(strReqId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vCMRequirement();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvCMRequirement4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strReqId = e.KeyId;
            DeleteCMRequirementRecord(strReqId);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "strReqId">给定关键字</param>
        protected void DeleteCMRequirementRecord(string strReqId)
        {
            try
            {
                clsCMRequirementBL.DelRecord(strReqId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vCMRequirement();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vCMRequirement]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevCMRequirementCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "CMRequirement信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convCMRequirement.ReqId); arrCnName.Add("需求Id");
            arrColName.Add(convCMRequirement.RequirementName); arrCnName.Add("需求名称");
            arrColName.Add(convCMRequirement.FuncModuleName); arrCnName.Add("功能模块名称");
            arrColName.Add(convCMRequirement.ReqContent); arrCnName.Add("需求内容");
            arrColName.Add(convCMRequirement.RequirementTypeName); arrCnName.Add("需求类型名");
            arrColName.Add(convCMRequirement.IsFinished); arrCnName.Add("是否完成");
            arrColName.Add(convCMRequirement.CmPrjName); arrCnName.Add("CM工程名");
            arrColName.Add(convCMRequirement.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convCMRequirement.ApplicationTypeSimName); arrCnName.Add("应用程序类型简称");
            arrColName.Add(convCMRequirement.ProjectFileName); arrCnName.Add("工程文件名");
            arrColName.Add(convCMRequirement.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convCMRequirement.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convCMRequirement.Memo); arrCnName.Add("说明");
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
                objDT = clsvCMRequirementBL.GetDataTable(strWhereCond);
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
        private void DispCMRequirementListRegion()
        {
            divList.Visible = true;
            tabEditCMRequirementRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditCMRequirementRegion()
        {
            divList.Visible = false;
            tabEditCMRequirementRegion.Visible = true;
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