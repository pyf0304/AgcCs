/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmTabFeatureFldsB_QUDI
界面名:wfmTabFeatureFlds_QUDI(00050222)
生成代码版本:2019.04.27.1
生成日期:2019/04/29 00:21:47
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:Web界面后台(WebViewControlCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

using System;
using System.Data;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;



using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using System.Linq;
using LaYumba.Functional;
using static LaYumba.Functional.F;
using static LaYumba.Functional.OptionExt;
using com.taishsoft.web.treeview;
using AGC.web.treeview;

namespace AGC.Webform
{
    /// <summary>
    /// wfmTabFeatureFldsB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmTabFeatureFldsB_QUDI : System.Web.UI.Page
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

                vsViewName = "表功能字段维护";
                vsTabName = string.Format("{0}", clsvTabFeatureFldsEN._CurrTabName);
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

                if (string.IsNullOrEmpty(clsCommonSession.qsTabId) == false)
                {
                    vsTabId = clsCommonSession.qsTabId;
                    //trHidden.Visible = false;
                    clsFieldTabBLEx.BindDdl_FldIDByTabIdEx(ddlFldIdq, clsPubVar.CurrSelPrjId, clsCommonSession.qsTabId);
                    wucTabFeatureFldsB1.SetDdl_FldId(clsCommonSession.qsTabId);
                    wucTabFeatureFldsB1.HiddenTrTabId();
                    BindTv_PrjFeature_TabFeature();
                }
                else
                {
                    //clsPrjTabBL.BindDdl_TabId(ddlTabIdq);
                    //wucTabFeatureFldsB1.SetDdl_TabId();
                }
                //1、为下拉框设置数据源,绑定列表数据

                //wucTabFeatureFldsB1.SetDdl_TabFeatureId(clsCommonSession.qsTabId);

                wucTabFeatureFldsB1.SetDdl_ValueGivingModeId();
                //wucTabFeatureFldsB1.SetDdl_FieldTypeId();
                clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureIdq, enumPrjFeatureType.TabFeature_03);

                clsFieldTypeBL.BindDdl_FieldTypeIdCache(ddlFieldTypeIdq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlInUseq);
                wucvTabFeatureFlds4Gv1.SetSortBy(string.Format("{0} Asc", convTabFeatureFlds.mId));
                //2、显示无条件的表内容在GridView中
                BindGv_vTabFeatureFlds();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                DispTabFeatureFldsListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsTabFeatureFldsBL.objCommFun4BL = new clsCommFun4BL4TabFeatureFlds();
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
            wucvTabFeatureFlds4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vTabFeatureFlds();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vTabFeatureFlds()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevTabFeatureFldsCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvTabFeatureFlds4Gv1.BindGv_TabFeatureFlds(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvTabFeatureFlds4Gv1.SetGvVisibility(convTabFeatureFlds.UpdDate, false);
                //wucvTabFeatureFlds4Gv1.SetGvVisibility(convTabFeatureFlds.UpdUser, false);
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
        protected string CombinevTabFeatureFldsCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
            try
            {
                if (string.IsNullOrEmpty(vsTabFeatureId) == false)
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convTabFeatureFlds.TabFeatureId, vsTabFeatureId);
                }

                if (string.IsNullOrEmpty(clsCommonSession.qsTabId) == false)
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convTabFeatureFlds.TabId, clsCommonSession.qsTabId);
                }
                else
                {
                    //if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
                    //{
                    //    objvTabFeatureFldsEN.TabId = this.ddlTabIdq.SelectedValue;
                    //    strWhereCond += string.Format(" And {0} = '{1}'", convTabFeatureFlds.TabId, this.ddlTabIdq.SelectedValue);
                    //}
                }
              
                    //if (this.ddlFeatureIdq.SelectedValue != "" && this.ddlFeatureIdq.SelectedValue != "0")
                    //{
                    //    objvTabFeatureFldsEN.FeatureId = this.ddlFeatureIdq.SelectedValue;
                    //    strWhereCond += string.Format(" And {0} = '{1}'", convTabFeatureFlds.FeatureId, this.ddlFeatureIdq.SelectedValue);
                    //}
              
                if (this.ddlFldIdq.SelectedValue != "" && this.ddlFldIdq.SelectedValue != "0")
                {
                    objvTabFeatureFldsEN.FldId = this.ddlFldIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convTabFeatureFlds.FldId, this.ddlFldIdq.SelectedValue);
                }
                if (this.ddlFieldTypeIdq.SelectedValue != "" && this.ddlFieldTypeIdq.SelectedValue != "0")
                {
                    objvTabFeatureFldsEN.FieldTypeId = this.ddlFieldTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convTabFeatureFlds.FieldTypeId, this.ddlFieldTypeIdq.SelectedValue);
                }
                if (this.ddlInUseq.SelectedIndex == 1)
                {
                    objvTabFeatureFldsEN.InUse = true;
                    strWhereCond += string.Format(" And {0} = '1'", convTabFeatureFlds.InUse);
                }
                else if (this.ddlInUseq.SelectedIndex == 2)
                {
                    objvTabFeatureFldsEN.InUse = false;
                    strWhereCond += string.Format(" And {0} = '0'", convTabFeatureFlds.InUse);
                }
                objvTabFeatureFldsEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineTabFeatureFldsCondition)时出错!请联系管理员!" + objException.Message);
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
            AddTabFeatureFldsRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void AddTabFeatureFldsRecord()
        {
            if (string.IsNullOrEmpty( vsTabFeatureId))
            {
                clsCommonJsFunc.Alert(this, "请在左边功能-表功能树中选中一个表功能！");
                return;
            }
            btnOKUpd.Text = "确认添加";
            btnCancelTabFeatureFldsEdit.Text = "取消添加";
            //wucTabFeatureFldsB1.mId = clsTabFeatureFldsBL.GetMaxStrId_S();
            wucTabFeatureFldsB1.TabFeatureId = vsTabFeatureId;
            wucTabFeatureFldsB1.SetDdl_FieldTypeId(vsFeatureId);
            wucTabFeatureFldsB1.OrderNum = 1;
            wucTabFeatureFldsB1.InUse = true;

            DispEditTabFeatureFldsRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddTabFeatureFldsRecordSave()
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
            clsTabFeatureFldsEN objTabFeatureFldsEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucTabFeatureFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsTabFeatureFldsEN objTabFeatureFldsEN;	//定义对象
            objTabFeatureFldsEN = new clsTabFeatureFldsEN();    //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToTabFeatureFldsClass(objTabFeatureFldsEN);      //把界面的值传到
                                                                    //5.1、检查传进去的对象属性是否合法
            try
            {
                objTabFeatureFldsEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objTabFeatureFldsEN.AddNewRecord();
                clsPrjTabBLEx.SetUpdDate(clsCommonSession.qsTabId, clsCommonSession.UserId);
                clsTabFeatureFldsBLEx.CopyToSubFeature(objTabFeatureFldsEN);
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
            BindGv_vTabFeatureFlds();
            DispTabFeatureFldsListRegion();
            wucTabFeatureFldsB1.Clear();        //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTabFeatureFldsEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId = wucvTabFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            UpdateTabFeatureFldsRecord(lngmId);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdateTabFeatureFldsRecord(long lngmId)
        {
            if (string.IsNullOrEmpty(vsTabFeatureId))
            {
                clsCommonJsFunc.Alert(this, "请在左边功能-表功能树中选中一个表功能！");
                return;
            }
            wucTabFeatureFldsB1.SetDdl_FieldTypeId(vsFeatureId);
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelTabFeatureFldsEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditTabFeatureFldsRegion();
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
            if (clsTabFeatureFldsBL.IsExist(lngmId) == false)       //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[TabFeatureFlds]中,关键字为:[lngmId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsTabFeatureFldsEN objTabFeatureFldsEN = new clsTabFeatureFldsEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsTabFeatureFldsBL.GetTabFeatureFlds(ref objTabFeatureFldsEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objTabFeatureFldsEN", objTabFeatureFldsEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromTabFeatureFldsClass(objTabFeatureFldsEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjTabFeatureFldsEN">表实体类对象</param>
        protected void GetDataFromTabFeatureFldsClass(clsTabFeatureFldsEN pobjTabFeatureFldsEN)
        {
            //wucTabFeatureFldsB1.TabId = pobjTabFeatureFldsEN.TabId;// 表ID
            wucTabFeatureFldsB1.FuncName = pobjTabFeatureFldsEN.FuncName;// DefaValue
            wucTabFeatureFldsB1.DefaultValue = pobjTabFeatureFldsEN.DefaultValue;// DefaValue
            wucTabFeatureFldsB1.TabFeatureId = pobjTabFeatureFldsEN.TabFeatureId;// 功能Id
            wucTabFeatureFldsB1.FldId = pobjTabFeatureFldsEN.FldId;// 字段Id
            wucTabFeatureFldsB1.FieldTypeId = pobjTabFeatureFldsEN.FieldTypeId;// 字段类型Id
            wucTabFeatureFldsB1.ValueGivingModeId = pobjTabFeatureFldsEN.ValueGivingModeId;// DefaValue
            wucTabFeatureFldsB1.OrderNum = pobjTabFeatureFldsEN.OrderNum ?? 0;// 序号
            wucTabFeatureFldsB1.InUse = pobjTabFeatureFldsEN.InUse;// 是否在用


            wucTabFeatureFldsB1.Memo = pobjTabFeatureFldsEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvTabFeatureFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateTabFeatureFldsRecord(lngmId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objTabFeatureFldsEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateTabFeatureFldsRecordSave(clsTabFeatureFldsEN objTabFeatureFldsEN)
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
            if (!wucTabFeatureFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToTabFeatureFldsClass(objTabFeatureFldsEN);      //把界面的值传到
                                                                    //3.1、检查传进去的对象属性是否合法
            try
            {
                objTabFeatureFldsEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objTabFeatureFldsEN.Update();
                clsPrjTabBLEx.SetUpdDate(clsCommonSession.qsTabId, clsCommonSession.UserId);
                clsTabFeatureFldsBLEx.CopyToSubFeature(objTabFeatureFldsEN);
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
            BindGv_vTabFeatureFlds();
            DispTabFeatureFldsListRegion();
            wucTabFeatureFldsB1.Clear();//添空控件中的内容
                                        //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTabFeatureFldsEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_TabFeatureFlds{0}'", objTabFeatureFldsEN.mId.ToString().Trim()), true);
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
            clsTabFeatureFldsEN objTabFeatureFldsEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddTabFeatureFldsRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddTabFeatureFldsRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objTabFeatureFldsEN = (clsTabFeatureFldsEN)Session["objTabFeatureFldsEN"];
                    UpdateTabFeatureFldsRecordSave(objTabFeatureFldsEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjTabFeatureFldsEN">数据传输的目的类对象</param>
        protected void PutDataToTabFeatureFldsClass(clsTabFeatureFldsEN pobjTabFeatureFldsEN)
        {
            pobjTabFeatureFldsEN.SetTabFeatureId(vsTabFeatureId)// 功能Id
            .SetFldId(wucTabFeatureFldsB1.FldId)// 字段Id
            .SetFieldTypeId(wucTabFeatureFldsB1.FieldTypeId)// 字段类型Id
            .SetValueGivingModeId(wucTabFeatureFldsB1.ValueGivingModeId)// DefaValue
            .SetFuncName(wucTabFeatureFldsB1.FuncName)// DefaValue
            .SetDefaultValue(wucTabFeatureFldsB1.DefaultValue)// DefaValue
            .SetPrjId(clsPubVar.CurrSelPrjId)
            .SetOrderNum(wucTabFeatureFldsB1.OrderNum)// 序号
            .SetInUse(wucTabFeatureFldsB1.InUse)// 是否在用
            .SetUpdUser(wucTabFeatureFldsB1.UpdUser)// 修改者
            .SetUpdDate(wucTabFeatureFldsB1.UpdDate)// 修改日期
            .SetMemo(wucTabFeatureFldsB1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelTabFeatureFldsEdit_Click(object sender, EventArgs e)
        {
            DispTabFeatureFldsListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<long> lstMId = wucvTabFeatureFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsTabFeatureFldsBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vTabFeatureFlds();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvTabFeatureFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteTabFeatureFldsRecord(lngmId);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteTabFeatureFldsRecord(long lngmId)
        {
            try
            {
                clsTabFeatureFldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vTabFeatureFlds();
        }

        /// <summary>
        ///置底
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PreCheck4Order)
        /// </summary>
        private bool PreCheck4Order()
        {
            if (ddlFeatureIdq.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请输入FeatureId!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlFeatureIdq.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        ///置顶
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnGoTop_Click)
        /// </summary>
        protected void btnGoTop_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strFeatureId = ddlFeatureIdq.SelectedValue;
            List<long> lstMId = wucvTabFeatureFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null)
            {
                lblMsgList.Text = "请选择需要置顶的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                //clsTabFeatureFldsBL.GoTop(lstMId, strFeatureId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevTabFeatureFldsCondition();
            wucvTabFeatureFlds4Gv1.BindGv_TabFeatureFlds(strWhereCond);
            foreach (long lngmId in lstMId)
            {
                wucvTabFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);
            }
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
            string strFeatureId = ddlFeatureIdq.SelectedValue;
            List<long> lstMId = wucvTabFeatureFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null)
            {
                lblMsgList.Text = "请选择需要置底的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                //clsTabFeatureFldsBL.GoBottom(lstMId, strFeatureId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置底出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevTabFeatureFldsCondition();
            wucvTabFeatureFlds4Gv1.BindGv_TabFeatureFlds(strWhereCond);
            foreach (long lngmId in lstMId)
            {
                wucvTabFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);
            }
        }

        /// <summary>
        ///重序
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnReOrder_Click)
        /// </summary>
        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strFeatureId = ddlFeatureIdq.SelectedValue;
            try
            {
                //clsTabFeatureFldsBL.ReOrder(strFeatureId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("重序出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevTabFeatureFldsCondition();
            wucvTabFeatureFlds4Gv1.BindGv_TabFeatureFlds(strWhereCond);
        }

        /// <summary>
        ///移动记录，包括上移和下移
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_MoveRecord)
        /// </summary>
        protected void MoveRecord(string strDirect)
        {
            if (PreCheck4Order() == false) return;
            string strFeatureId = ddlFeatureIdq.SelectedValue;
            long lngmId = wucvTabFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0)
            {
                lblMsgList.Text = string.Format("请选择需要移动({0})的记录!", strDirect);
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                //clsTabFeatureFldsBL.AdjustOrderNum(strDirect, lngmId, strFeatureId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("移动({0})记录出错。错误:{1}.({2})", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevTabFeatureFldsCondition();
            wucvTabFeatureFlds4Gv1.BindGv_TabFeatureFlds(strWhereCond);
            wucvTabFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);
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
        /// 导出Excel。根据查询区组合的查询条件,从[vTabFeatureFlds]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevTabFeatureFldsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "TabFeatureFlds信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convTabFeatureFlds.TabName); arrCnName.Add("表名");
            arrColName.Add(convTabFeatureFlds.TabCnName); arrCnName.Add("表中文名");
            arrColName.Add(convTabFeatureFlds.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convTabFeatureFlds.SqlDsTypeName); arrCnName.Add("Sql数据源名");
            arrColName.Add(convTabFeatureFlds.FuncModuleName); arrCnName.Add("功能模块名称");
            arrColName.Add(convTabFeatureFlds.OrderNum4Refer); arrCnName.Add("引用序号");
            arrColName.Add(convTabFeatureFlds.FldName); arrCnName.Add("字段名");
            arrColName.Add(convTabFeatureFlds.Caption); arrCnName.Add("标题");
            arrColName.Add(convTabFeatureFlds.DataTypeName); arrCnName.Add("数据类型名称");
            arrColName.Add(convTabFeatureFlds.IsNull); arrCnName.Add("是否可空");
            arrColName.Add(convTabFeatureFlds.DefaultValue); arrCnName.Add("缺省值");
            arrColName.Add(convTabFeatureFlds.FieldTypeName); arrCnName.Add("字段类型名");
            arrColName.Add(convTabFeatureFlds.DefaultValue); arrCnName.Add("缺省值");
            arrColName.Add(convTabFeatureFlds.OrderNum); arrCnName.Add("序号");
            arrColName.Add(convTabFeatureFlds.InUse); arrCnName.Add("是否在用");
            arrColName.Add(convTabFeatureFlds.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convTabFeatureFlds.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convTabFeatureFlds.Memo); arrCnName.Add("说明");
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
                objDT = clsvTabFeatureFldsBL.GetDataTable(strWhereCond);
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
        private void DispTabFeatureFldsListRegion()
        {
            divList.Visible = true;
            tabEditTabFeatureFldsRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditTabFeatureFldsRegion()
        {
            divList.Visible = false;
            tabEditTabFeatureFldsRegion.Visible = true;
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

    

        protected string vsTabId
        {
            get
            {
                string sTabId;
                sTabId = (string)ViewState["TabId"];
                if (sTabId == null)
                {
                    sTabId = "";
                }
                return sTabId;
            }
            set
            {
                string sTabId = value;
                ViewState.Add("TabId", sTabId);
            }
        }


        protected void btnAddTabFeature_Click(object sender, EventArgs e)
        {
            if (ddlFeatureIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个功能！");
                ddlFeatureIdq.Focus();
                return;
            }
            Func<string, string, clsTabFeatureFldsEN> GetTabFeatureFld1 = 
                (strTabFeatureId1, strFldId1)
                    => new clsTabFeatureFldsEN()
                    {
                        TabFeatureId = strTabFeatureId1,
                        FldId = strFldId1,
                        //FieldTypeId = strFieldTypeId1,

                    };
            string strTabId = clsCommonSession.qsTabId;
            Option<int> aa = None;
                        
            string strFeatureId = ddlFeatureIdq.SelectedValue;

            //string strFieldTypeId = "";
            string strCondition = "";
            string strPrjId = clsPubVar.CurrSelPrjId;
            string strUpdUser = clsCommonSession.UserId;
            //IEnumerable <clsTabFeatureFldsEN> arrTabFeatureFlds = null;
            //IEnumerable<string> arrFldId = null;
            K_FeatureId_PrjFeature objKey = new K_FeatureId_PrjFeature(strFeatureId);
            clsPrjFeatureEN objPrjFeatureEN = objKey.GetObj();
            switch (objPrjFeatureEN.FeatureName)
            {

                case "绑定下拉框":
                    try
                    {

                        clsTabFeatureFldsBLEx.AddBindDdl(clsCommonSession.qsTabId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        BindTv_PrjFeature_TabFeature();
                    }
                    catch(Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                  

                    break;
                case "调整记录次序":

                    try
                    {
                        //List<string> arrFeatureId_Sub = clsPrjFeatureBLEx.GetSubFeatureIdLstByFeatureId(strFeatureId, enumPrjFeatureType.TabFeature_03);
                        clsTabFeatureFldsBLEx.AddAdjustOrderNum(clsCommonSession.qsTabId, strFeatureId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        //foreach(string strSubFeatureId in arrFeatureId_Sub)
                        //{
                        //    clsTabFeatureFldsBLEx.AddAdjustOrderNum(clsCommonSession.qsTabId, strSubFeatureId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        //}
                        BindTv_PrjFeature_TabFeature();
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }                    
                    break;
                case "移顶":
                case "上移":
                case "下移":
                case "移底":
                case "重序":

                    try
                    {
                        List<string> arrFeatureId_Sub = clsPrjFeatureBLEx.GetSubFeatureIdLstByFeatureId(strFeatureId, enumPrjFeatureType.TabFeature_03);
                        clsTabFeatureFldsBLEx.AddAdjustOrderNum(clsCommonSession.qsTabId, strFeatureId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        foreach (string strSubFeatureId in arrFeatureId_Sub)
                        {
                            clsTabFeatureFldsBLEx.AddAdjustOrderNum(clsCommonSession.qsTabId, strSubFeatureId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        }
                        BindTv_PrjFeature_TabFeature();
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    break;

                case "设置字段值":
                    //string strFeatureId = enumPrjFeature.Tab_BindDdl_0173;
                    //string strFieldTypeId = enumFieldType.KeyField_02;

                    clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
                    //var GetTabFeatureFld6 =Apply.

                    clsTabFeatureEN objTabFeature = new clsTabFeatureEN();
                    objTabFeature.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);

                    if (objTabFeature.SetTabId(strTabId)
                                .SetPrjId(clsPubVar.CurrSelPrjId)// 表ID
                        .SetTabFeatureName(objPrjFeature.FeatureName)
                        .SetFeatureId(strFeatureId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(clsCommonSession.UserId)
                            .SetInUse(true)
                            .SetOrderNum(1)
                            .CheckUniqueness() == true)
                    {
                        objTabFeature.AddNewRecordEx(strPrjId, strUpdUser);
                        BindTv_PrjFeature_TabFeature();
                    }
                    else
                    {
                        strCondition = string.Format("{0}='{1}' and {2}='{3}' and {4}='{5}'",
                            conTabFeature.TabId, objTabFeature.TabId,
                            conTabFeature.FeatureId, strFeatureId,
                            conTabFeature.TabFeatureName, objPrjFeature.FeatureName);
                        objTabFeature = clsTabFeatureBL.GetFirstObj_S(strCondition);
                    }

                    //wucTabFeatureFldsB1.SetDdl_TabFeatureId(clsCommonSession.qsTabId);

                    wucTabFeatureFldsB1.TabFeatureId = objTabFeature.TabFeatureId;
                    //                    wucTabFeatureFldsB1.FuncName = string.Format("", strFeatureId;
                    wucTabFeatureFldsB1.OrderNum = 1;

                    wucTabFeatureFldsB1.InUse = true;
                    btnOKUpd.Text = "确认添加";
                    btnCancelTabFeatureFldsEdit.Text = "取消添加";
                    //wucTabFeatureFldsB1.mId = clsTabFeatureFldsBL.GetMaxStrId_S();
                    DispEditTabFeatureFldsRegion();
                    break;
                case "表相关事务操作":
                    clsTabFeatureEN obj1 = new clsTabFeatureEN();
                    obj1.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    
                    if (obj1.SetTabId(strTabId)
                                .SetPrjId(clsPubVar.CurrSelPrjId)// 表ID
                        .SetTabFeatureName(objPrjFeatureEN.FeatureName)
                        .SetFeatureId(strFeatureId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(clsCommonSession.UserId)
                            .SetInUse(true)
                            .CheckUniqueness() == true)
                    {
                        obj1.AddNewRecordEx(strPrjId, strUpdUser);
                        BindTv_PrjFeature_TabFeature();
                    }

                    break;
                case "XML相关操作":
                    clsTabFeatureEN obj = new clsTabFeatureEN();
                    obj.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);

                    if (obj.SetTabId(strTabId)
                                .SetPrjId(clsPubVar.CurrSelPrjId)// 表ID
                         .SetTabFeatureName(objPrjFeatureEN.FeatureName)
                        .SetFeatureId(strFeatureId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(clsCommonSession.UserId)
                            .SetInUse(true)
                            .CheckUniqueness() == true)
                    {
                        obj.AddNewRecordEx(strPrjId, strUpdUser);
                        BindTv_PrjFeature_TabFeature();
                    }

                    break;
                case "根据标志删除":
                case "恢复删除":
                    //strFieldTypeId = enumFieldType.DelSignField_12;
                    clsTabFeatureEN obj2 = new clsTabFeatureEN();
                    obj2.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);

                    if (obj2.SetTabId(strTabId)
                                .SetPrjId(clsPubVar.CurrSelPrjId)// 表ID
                         .SetTabFeatureName(objPrjFeatureEN.FeatureName)
                        .SetFeatureId(strFeatureId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(clsCommonSession.UserId)
                            .SetInUse(true)
                            .SetOrderNum(1)
                            .CheckUniqueness() == true)
                    {
                        obj2.AddNewRecordEx(strPrjId, strUpdUser);
                        BindTv_PrjFeature_TabFeature();
                    }

                    //var GetTabFeatureFld2 = GetTabFeatureFld1.Apply(obj2.TabFeatureId);
                   
                    //strCondition = string.Format("{0}='{1}' and {2}='{3}'", clsFieldTabEN.con_FieldTypeId, enumFieldType.DelSignField_12,
                    //    clsFieldTabEN.con_PrjId, clsPubVar.CurrSelPrjId);
                    //IEnumerable<clsFieldTabEN> arrObjLst = clsFieldTabBL.GetObjLst(strCondition);

                    //arrFldId = arrObjLst.Select(x=>x.FldId);

                    //arrTabFeatureFlds = arrObjLst
                    //    .Select(x=>x.FldId)
                    //    .Select(GetTabFeatureFld2)
                    //    .Where(x=>x.CheckUniqueness_TabFeatureId_FldId() == true);
                    //foreach(clsTabFeatureFldsEN objInFor in arrTabFeatureFlds)
                    //{
                    //    objInFor
                    //        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    //        .SetUpdUser(clsCommonSession.UserId)
                    //        .SetInUse(true)
                    //        .SetFieldTypeId(enumFieldType.DelSignField_12)   
                    //        .AddNewRecord();
                    //}
                    break;
            }
            clsPrjTabBLEx.SetUpdDate(strTabId, clsCommonSession.UserId);
            BindGv_vTabFeatureFlds();
        }

        private void BindTv_PrjFeature_TabFeature()
        {
            string strTabId = clsCommonSession.qsTabId;
            if (string.IsNullOrEmpty(strTabId) == true) return;
            wucTreeView4TabFeature.tmTreeModel = TreeModel.PrjFeature_TabFeature;
            wucTreeView4TabFeature.DependsOn = "Table";
            wucTreeView4TabFeature.TabId = strTabId;
            //wucTreeView4TabFeature.IsUseJsEvent = true;
            wucTreeView4TabFeature.PrjId = clsPubVar.CurrSelPrjId;// "0116";
            wucTreeView4TabFeature.BindTv();
            wucTreeView4TabFeature.Expand(1);
            //wucTreeView4TabFeature.afterSelect_Tz += wucTreeView4TabFeature_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            //wucTreeView4TabFeature.CollapseAll();
            //            wucTreeView4TabFeature.SelectNodeEx(strTypeName, strKeyId);
            wucTreeView4TabFeature.ExpandAll();

//            wucTreeView4TabFeature.Nodes[1].Expand();
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

        protected void btnRefreshTv_Click(object sender, EventArgs e)
        {
            BindTv_PrjFeature_TabFeature();
        }

        protected void wucTreeView4TabFeature_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //wucTreeView4TabFeature.CollapseAll();
            wucTreeView4TabFeature.SelectNode(strTypeName, strKeyId);
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView4TabFeature.GetCurrPathNodeKeyIdLst();
            wucTreeView4TabFeature.SelectNodeEx(arrCurrPathNodeKeyIdLst);

            if (strTypeName == clsvPrjFeatureEN._CurrTabName)
            {
                ddlFeatureIdq.SelectedValue = strKeyId;
                string strCondition = string.Format("{0}='{1}' and {2}='{3}'", 
                    conTabFeature.TabId, clsCommonSession.qsTabId,
                    conTabFeature.FeatureId, strKeyId);
                clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetFirstObj_S(strCondition);
                vsTabFeatureId = objTabFeature.TabFeatureId;
                vsFeatureId = objTabFeature.FeatureId;
                BindGv_vTabFeatureFlds();
                return;
            }
            else if (strTypeName == clsvTabFeatureEN._CurrTabName)
            {
                //ddlFeatureIdq.SelectedValue = strKeyId;
                //string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                //    conTabFeature.TabId, clsCommonSession.qsTabId,
                //    conTabFeature.FeatureId, strKeyId);

                vsTabFeatureId = strKeyId;
                clsTabFeatureEN objTabFeature2 = clsTabFeatureBL.GetObjByTabFeatureId(vsTabFeatureId);
                vsFeatureId = objTabFeature2.FeatureId;
                BindGv_vTabFeatureFlds();
                return;
            }
            if (strTypeName != clsTabFeatureEN._CurrTabName) return;
            string strTabFeatureId = strKeyId;
            vsTabFeatureId = strTabFeatureId;
            clsTabFeatureEN objTabFeature1 = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
            vsFeatureId = objTabFeature1.FeatureId;
            BindGv_vTabFeatureFlds();
        }
        protected string vsTabFeatureId
        {
            get
            {
                string sTabFeatureId;
                sTabFeatureId = (string)ViewState["TabFeatureId"];
                if (sTabFeatureId == null)
                {
                    sTabFeatureId = "";
                }
                return sTabFeatureId;
            }
            set
            {
                string sTabFeatureId = value;
                ViewState.Add("TabFeatureId", sTabFeatureId);
            }
        }

        protected string vsFeatureId
        {
            get
            {
                string sFeatureId;
                sFeatureId = (string)ViewState["FeatureId"];
                if (sFeatureId == null)
                {
                    sFeatureId = "";
                }
                return sFeatureId;
            }
            set
            {
                string sFeatureId = value;
                ViewState.Add("FeatureId", sFeatureId);
            }
        }
        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnCopyRecord_Click4OneKeyword)
        /// </summary>
        protected void btnCopyRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId = wucvTabFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
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
                K_mId_TabFeatureFlds myKey = new K_mId_TabFeatureFlds(lngmId);
                clsTabFeatureFldsEN objTabFeatureFldsEN = myKey.GetObj();
                objTabFeatureFldsEN.FldId = "";
                objTabFeatureFldsEN.AddNewRecord();
                BindGv_vTabFeatureFlds();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在克隆记录时出错！错误：{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }

        protected void btnDeleteTabFeature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( vsTabFeatureId) == true)
            {
                string strMsg = string.Format("请在树中选择一个表功能.(In {0})", clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {                
                clsTabFeatureBLEx.DelRecordEx(vsTabFeatureId, clsPubVar.CurrSelPrjId);
                clsPrjTabBLEx.SetUpdDate(clsCommonSession.qsTabId, clsCommonSession.UserId);
                BindTv_PrjFeature_TabFeature();
                BindGv_vTabFeatureFlds();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在删除记录时出错！错误：{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }
    }

}