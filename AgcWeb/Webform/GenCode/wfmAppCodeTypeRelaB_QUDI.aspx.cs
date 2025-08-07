
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmAppCodeTypeRelaB_QUDI
表名:AppCodeTypeRela(00050418)
生成代码版本:2018.09.02.1
生成日期:2018/09/03 08:09:20
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
框架-层名:Web界面后台代码(WebViewControlCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
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

using AgcCommBase;

namespace AGC.Webform
{
    /// <summary>
    /// wfmAppCodeTypeRelaB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCodeWithWuc4Gv)
    /// </summary>
    public partial class wfmAppCodeTypeRelaB_QUDI : System.Web.UI.Page
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

                vsViewName = "应用程序代码类型关系维护";
                vsTabName = string.Format("{0}", clsvAppCodeTypeRelaEN._CurrTabName);
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
                wucAppCodeTypeRelaB1.SetDdl_ApplicationTypeId();
                wucAppCodeTypeRelaB1.SetDdl_CodeTypeId();
                
                wucAppCodeTypeRelaB1.SetDdl_TabMainTypeIdCache();

                clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq);
                clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeId);
                clsProgLangTypeBLEx.BindDdl_ProgLangTypeIdExCache(ddlProgLangTypeIdq);
                clsProgLangTypeBLEx.BindDdl_ProgLangTypeIdExCache(ddlProgLangTypeId4CodeType);
                clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeIdq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsVisibleq);
                clsAppCodeTypeRelaBLEx.BindDdl_DependsOn(ddlDependsOnq);
                clsAppCodeTypeRelaBLEx.BindDdl_FrontOrBack(ddlFrontOrBackq);

                wucvAppCodeTypeRela4Gv1.SetSortBy(string.Format("{0} Asc", convAppCodeTypeRela.mId));
                //2、显示无条件的表内容在GridView中
                BindGv_vAppCodeTypeRela();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                DispAppCodeTypeRelaListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsAppCodeTypeRelaBL.objCommFun4BL = new clsCommFun4BL4AppCodeTypeRela();
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
            wucvAppCodeTypeRela4Gv1.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_vAppCodeTypeRela();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vAppCodeTypeRela()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                wucvAppCodeTypeRela4Gv1.SetGvVisibility("修改", false);
                wucvAppCodeTypeRela4Gv1.SetGvVisibility("删除", false);
                //	1、组合界面条件串；
                string strWhereCond = CombinevAppCodeTypeRelaCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvAppCodeTypeRela4Gv1.BindGv_AppCodeTypeRela(strWhereCond);
                //	3、设置Gv控件的某些列不可见；

                //wucvAppCodeTypeRela4Gv1.SetGvVisibility(convAppCodeTypeRela.UpdUser, false);
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
        protected string CombinevAppCodeTypeRelaCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 and {0} in (Select {0} From {1} where {2}='1')",
                    conApplicationType.ApplicationTypeId, conApplicationType._CurrTabName, conApplicationType.IsVisible);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
            try
            {
                if (this.ddlApplicationTypeIdq.SelectedValue != "" && this.ddlApplicationTypeIdq.SelectedValue != "0")
                {
                    objvAppCodeTypeRelaEN.ApplicationTypeId = int.Parse(this.ddlApplicationTypeIdq.SelectedValue.ToString());
                    strWhereCond += string.Format(" And {0} = {1}", convAppCodeTypeRela.ApplicationTypeId, this.ddlApplicationTypeIdq.SelectedValue);
                }
                if (this.ddlProgLangTypeIdq.SelectedValue != "" && this.ddlProgLangTypeIdq.SelectedValue != "0")
                {
                    objvAppCodeTypeRelaEN.ProgLangTypeId = this.ddlProgLangTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convAppCodeTypeRela.ProgLangTypeId, this.ddlProgLangTypeIdq.SelectedValue);
                }
                if (this.ddlProgLangTypeId4CodeType.SelectedValue != "" && this.ddlProgLangTypeId4CodeType.SelectedValue != "0")
                {
                    objvAppCodeTypeRelaEN.ProgLangTypeId = this.ddlProgLangTypeId4CodeType.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convAppCodeTypeRela.ProgLangTypeId, 
                        this.ddlProgLangTypeId4CodeType.SelectedValue);
                }
                if (this.ddlCodeTypeIdq.SelectedValue != "" && this.ddlCodeTypeIdq.SelectedValue != "0")
                {
                    objvAppCodeTypeRelaEN.CodeTypeId = this.ddlCodeTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convAppCodeTypeRela.CodeTypeId, this.ddlCodeTypeIdq.SelectedValue);
                }
                if (this.ddlIsVisibleq.SelectedIndex == 1)
                {
                    objvAppCodeTypeRelaEN.IsVisible = true;
                    strWhereCond += string.Format(" And {0} = '1'", convAppCodeTypeRela.IsVisible);
                }
                else if (this.ddlIsVisibleq.SelectedIndex == 2)
                {
                    objvAppCodeTypeRelaEN.IsVisible = false;
                    strWhereCond += string.Format(" And {0} = '0'", convAppCodeTypeRela.IsVisible);
                }
                if (this.ddlDependsOnq.SelectedValue != "" && this.ddlDependsOnq.SelectedValue != "0")
                {                 
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conCodeType.DependsOn, this.ddlDependsOnq.SelectedValue.Trim());
                }
                if (this.ddlFrontOrBackq.SelectedValue != "" && this.ddlFrontOrBackq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conCodeType.FrontOrBack, this.ddlFrontOrBackq.SelectedValue.Trim());
                }
                clsvAppCodeTypeRelaBL.CheckProperty4Condition(objvAppCodeTypeRelaEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineAppCodeTypeRelaCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
        /// </summary>
        public string PageSize
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
        /// <summary>
        ///添加新记录的事件过程 
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnAddNewRec4Gv_Click)
        /// </summary>
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddAppCodeTypeRelaRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddAppCodeTypeRelaRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelAppCodeTypeRelaEdit.Text = "取消添加";
            //wucAppCodeTypeRelaB1.mId = clsAppCodeTypeRelaBL.GetMaxStrId_S();
            DispEditAppCodeTypeRelaRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddAppCodeTypeRelaRecordSave()
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
            clsAppCodeTypeRelaEN objAppCodeTypeRelaEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucAppCodeTypeRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsAppCodeTypeRelaEN objAppCodeTypeRelaEN;	//定义对象
            objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();  //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToAppCodeTypeRelaClass(objAppCodeTypeRelaEN);        //把界面的值传到
                                                                        //5.1、检查传进去的对象属性是否合法
            try
            {
                clsAppCodeTypeRelaBL.CheckPropertyNew(objAppCodeTypeRelaEN);
                //6、把数据实体层的数据存贮到数据库中
                clsAppCodeTypeRelaBL.AddNewRecordBySql2(objAppCodeTypeRelaEN);
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
            BindGv_vAppCodeTypeRela();
            DispAppCodeTypeRelaListRegion();
            wucAppCodeTypeRelaB1.Clear();       //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelAppCodeTypeRelaEdit.Text = "取消编辑";
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
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId = wucvAppCodeTypeRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            UpdateAppCodeTypeRelaRecord(lngmId);
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
            if (clsAppCodeTypeRelaBL.IsExist(lngmId) == false)      //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[AppCodeTypeRela]中,关键字为:[lngmId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsAppCodeTypeRelaBL.GetAppCodeTypeRela(ref objAppCodeTypeRelaEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objAppCodeTypeRelaEN", objAppCodeTypeRelaEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromAppCodeTypeRelaClass(objAppCodeTypeRelaEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjAppCodeTypeRelaEN">表实体类对象</param>
        protected void GetDataFromAppCodeTypeRelaClass(clsAppCodeTypeRelaEN pobjAppCodeTypeRelaEN)
        {
            wucAppCodeTypeRelaB1.ApplicationTypeId = pobjAppCodeTypeRelaEN.ApplicationTypeId;// 应用程序类型ID
            wucAppCodeTypeRelaB1.CodeTypeId = pobjAppCodeTypeRelaEN.CodeTypeId;// 代码类型Id
            
            wucAppCodeTypeRelaB1.TabMainTypeId = pobjAppCodeTypeRelaEN.TabMainTypeId;// 代码类型Id

            wucAppCodeTypeRelaB1.IsVisible = pobjAppCodeTypeRelaEN.IsVisible;// 是否显示
            wucAppCodeTypeRelaB1.IsInGroupGeneCode = pobjAppCodeTypeRelaEN.IsInGroupGeneCode;// 是否显示
            
            //wucAppCodeTypeRelaB1.GroupName = pobjAppCodeTypeRelaEN.GroupName;// 
            wucAppCodeTypeRelaB1.OrderNum = pobjAppCodeTypeRelaEN.OrderNum;// 序号
            wucAppCodeTypeRelaB1.Memo = pobjAppCodeTypeRelaEN.Memo;// 说明
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvAppCodeTypeRela4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateAppCodeTypeRelaRecord(lngmId);
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateAppCodeTypeRelaRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelAppCodeTypeRelaEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditAppCodeTypeRelaRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objAppCodeTypeRelaEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateAppCodeTypeRelaRecordSave(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
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
            if (!wucAppCodeTypeRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToAppCodeTypeRelaClass(objAppCodeTypeRelaEN);        //把界面的值传到
                                                                        //3.1、检查传进去的对象属性是否合法
            try
            {
                clsAppCodeTypeRelaBL.CheckPropertyNew(objAppCodeTypeRelaEN);
                //4、把数据实体层的数据存贮到数据库中
                clsAppCodeTypeRelaBL.UpdateBySql2(objAppCodeTypeRelaEN);
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
            BindGv_vAppCodeTypeRela();
            DispAppCodeTypeRelaListRegion();
            wucAppCodeTypeRelaB1.Clear();//添空控件中的内容
                                         //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelAppCodeTypeRelaEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_AppCodeTypeRela{0}'", objAppCodeTypeRelaEN.mId.ToString().Trim()), true);
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
            clsAppCodeTypeRelaEN objAppCodeTypeRelaEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddAppCodeTypeRelaRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddAppCodeTypeRelaRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objAppCodeTypeRelaEN = (clsAppCodeTypeRelaEN)Session["objAppCodeTypeRelaEN"];
                    UpdateAppCodeTypeRelaRecordSave(objAppCodeTypeRelaEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelAppCodeTypeRelaEdit_Click(object sender, EventArgs e)
        {
            DispAppCodeTypeRelaListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjAppCodeTypeRelaEN">数据传输的目的类对象</param>
        protected void PutDataToAppCodeTypeRelaClass(clsAppCodeTypeRelaEN pobjAppCodeTypeRelaEN)
        {
            pobjAppCodeTypeRelaEN.ApplicationTypeId = wucAppCodeTypeRelaB1.ApplicationTypeId;// 应用程序类型ID
            pobjAppCodeTypeRelaEN.CodeTypeId = wucAppCodeTypeRelaB1.CodeTypeId;// 代码类型Id

            pobjAppCodeTypeRelaEN.TabMainTypeId = wucAppCodeTypeRelaB1.TabMainTypeId;// 代码类型Id

            pobjAppCodeTypeRelaEN.IsVisible = wucAppCodeTypeRelaB1.IsVisible;// 是否显示
            pobjAppCodeTypeRelaEN.IsInGroupGeneCode = wucAppCodeTypeRelaB1.IsInGroupGeneCode;// 是否显示
            //pobjAppCodeTypeRelaEN.GroupName = wucAppCodeTypeRelaB1.GroupName;// 
            pobjAppCodeTypeRelaEN.OrderNum = wucAppCodeTypeRelaB1.OrderNum;// 序号
            pobjAppCodeTypeRelaEN.UpdDate = wucAppCodeTypeRelaB1.UpdDate;// 修改日期
            pobjAppCodeTypeRelaEN.UpdUser = wucAppCodeTypeRelaB1.UpdUser;// 修改者
            pobjAppCodeTypeRelaEN.Memo = wucAppCodeTypeRelaB1.Memo;// 说明
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<long> lstMId = wucvAppCodeTypeRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsAppCodeTypeRelaBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000021)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vAppCodeTypeRela();
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvAppCodeTypeRela4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteAppCodeTypeRelaRecord(lngmId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteAppCodeTypeRelaRecord(long lngmId)
        {
            try
            {
                clsAppCodeTypeRelaBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vAppCodeTypeRela();
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
        /// 导出Excel。根据查询区组合的查询条件,从[vAppCodeTypeRela]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevAppCodeTypeRelaCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "AppCodeTypeRela信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convAppCodeTypeRela.ApplicationTypeId); arrCnName.Add("应用程序类型ID");
            arrColName.Add(convAppCodeTypeRela.ApplicationTypeName); arrCnName.Add("应用程序类型名称");
            arrColName.Add(convAppCodeTypeRela.ApplicationTypeENName); arrCnName.Add("应用类型英文名");
            arrColName.Add(convAppCodeTypeRela.ProgLangTypeId); arrCnName.Add("编程语言类型Id");
            arrColName.Add(convAppCodeTypeRela.CodeTypeId); arrCnName.Add("代码类型Id");
            arrColName.Add(convAppCodeTypeRela.CodeTypeName); arrCnName.Add("代码类型名");
            arrColName.Add(convAppCodeTypeRela.CodeTypeENName); arrCnName.Add("代码类型英文名");
            arrColName.Add(convAppCodeTypeRela.IsVisible); arrCnName.Add("是否显示");
            arrColName.Add(convAppCodeTypeRela.OrderNum); arrCnName.Add("序号");
            arrColName.Add(convAppCodeTypeRela.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convAppCodeTypeRela.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convAppCodeTypeRela.Memo); arrCnName.Add("说明");
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
                objDT = clsvAppCodeTypeRelaBL.GetDataTable(strWhereCond);
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
                    BusinessLogicEx.clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
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
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListRegion)
        /// </summary>
        private void DispAppCodeTypeRelaListRegion()
        {
            divList.Visible = true;
            tabEditAppCodeTypeRelaRegion.Visible = false;
        }
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispEditRegion)
        /// </summary>
        private void DispEditAppCodeTypeRelaRegion()
        {
            divList.Visible = false;
            tabEditAppCodeTypeRelaRegion.Visible = true;
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

        protected void btnGeneCodeType_Click(object sender, EventArgs e)
        {

            List<clsCodeTypeEN> arrObjLst = clsCodeTypeBL.GetTopObjLst(200, "1=1", "");
            foreach (clsCodeTypeEN objInFor in arrObjLst)
            {
                int intApplicationTypeId = 0;
                string strCodeTypeName = objInFor.CodeTypeName;
                if (objInFor.IsWin == true)
                {
                    intApplicationTypeId = (int)enumApplicationType.WinApp_1;

                    AddNewAppCodeTypeRela(objInFor, intApplicationTypeId);
                }
                if (objInFor.IsWeb == true)
                {
                    intApplicationTypeId = (int)enumApplicationType.WebApp_2;

                    AddNewAppCodeTypeRela(objInFor, intApplicationTypeId);
                }

                if (objInFor.IsAspMvc == true)
                {
                    intApplicationTypeId = (int)enumApplicationType.AspMvcApp_13;

                    AddNewAppCodeTypeRela(objInFor, intApplicationTypeId);
                }

                if (objInFor.IsPubApp4WinWeb == true)
                {
                    intApplicationTypeId = (int)enumApplicationType.PubApp4WinWeb_7;

                    AddNewAppCodeTypeRela(objInFor, intApplicationTypeId);
                }

                if (objInFor.IsTableFldConst == true)
                {
                    intApplicationTypeId = (int)enumApplicationType.TableFldConst_11;

                    AddNewAppCodeTypeRela(objInFor, intApplicationTypeId);
                }
                if (objInFor.IsWebSrvAccess == true)
                {
                    intApplicationTypeId = (int)enumApplicationType.WebSrvAccess_10;

                    AddNewAppCodeTypeRela(objInFor, intApplicationTypeId);
                }
                if (objInFor.IsMobileApp == true)
                {
                    intApplicationTypeId = (int)enumApplicationType.AndroidApp_5;

                    AddNewAppCodeTypeRela(objInFor, intApplicationTypeId);
                }
            }
        }
        private void AddNewAppCodeTypeRela(clsCodeTypeEN objInFor, int intApplicationTypeId)
        {
            string strCondition = string.Format("{0}={1} And {2}='{3}'",
                       conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId,
                       conAppCodeTypeRela.CodeTypeId, objInFor.CodeTypeId);
            if (clsAppCodeTypeRelaBL.IsExistRecord(strCondition) == false)
            {
                clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
                objAppCodeTypeRelaEN.CodeTypeId = objInFor.CodeTypeId;
                objAppCodeTypeRelaEN.ApplicationTypeId = intApplicationTypeId;
                objAppCodeTypeRelaEN.IsVisible = true;
                objAppCodeTypeRelaEN.OrderNum = objInFor.OrderNum ?? 0;
                objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objAppCodeTypeRelaEN.UpdUser = clsCommonSession.UserId;
                clsAppCodeTypeRelaBL.AddNewRecordBySql2(objAppCodeTypeRelaEN);
            }
        }


        /// <summary>
        /// 获取所给语言类型的代码类型对象列表
        /// </summary>
        /// <param name="objCodeTypeEN"></param>
        /// <param name="intApplicationTypeId"></param>
        /// <returns></returns>
        public static bool IsMatchLangType(clsCodeTypeEN objCodeTypeEN, int intApplicationTypeId)
        {
            clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intApplicationTypeId);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objApplicationTypeEN.ProgLangTypeId);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:
                    if (objCodeTypeEN.IsCSharp == false) return false;

                    if (objCodeTypeEN.IsWin == true && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WinApp_1)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsAspMvc == true
                      && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.AspMvcApp_13)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsPubApp4WinWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.PubApp4WinWeb_7)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsTableFldConst == true
                      && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.TableFldConst_11)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWebSrvAccess == true
                    && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSrvAccess_10)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.JAVA:
                    if (objCodeTypeEN.IsJava == false) return false;
                    if (objCodeTypeEN.IsMobileApp == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.AndroidApp_5)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWin == true && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WinApp_1)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsPubApp4WinWeb == true
                      && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.PubApp4WinWeb_7)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsTableFldConst == true
                          && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.TableFldConst_11)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWebSrvAccess == true
                  && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSrvAccess_10)
                    {
                        return true;
                    }
                    else return false;

                case clsPubConst.LangType.Swift:
                case clsPubConst.LangType.Swift3:
                case clsPubConst.LangType.Swift4:
                    if (objCodeTypeEN.IsSwift == false) return false;
                    if (objCodeTypeEN.IsMobileApp == true
                       && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.IOSApp_6)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWin == true && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WinApp_1)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsPubApp4WinWeb == true
                      && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.PubApp4WinWeb_7)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsTableFldConst == true
                          && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.TableFldConst_11)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWebSrvAccess == true
                  && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSrvAccess_10)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.JavaScript:
                    if (objCodeTypeEN.IsJavaScript == false) return false;
                    if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSite_4)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.TypeScript:
                    if (objCodeTypeEN.IsTypeScript == false) return false;
                    if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSite_4)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.SilverLight:
                    if (objCodeTypeEN.IsSilverLight == false) return false;
                    if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.SilverLightApp_8)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.VB:
                    if (objCodeTypeEN.IsVB == true) return true;
                    else return false;
                default:
                    string strMsg = string.Format("处理是否匹配中，该类型:[{0}]没有处理。({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }


        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            long lngmId = wucvAppCodeTypeRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            string strApplicationTypeId = ddlApplicationTypeIdq.SelectedValue;
            lblMsgList.Text = "";


            try
            {
                clsAppCodeTypeRelaBLEx.AdjustOrderNum("UP", lngmId, int.Parse( strApplicationTypeId));
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
            BindGv_vAppCodeTypeRela();
            wucvAppCodeTypeRela4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            long lngmId = wucvAppCodeTypeRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            string strApplicationTypeId = ddlApplicationTypeIdq.SelectedValue;

            lblMsgList.Text = "";

            try
            {
                clsAppCodeTypeRelaBLEx.AdjustOrderNum("DOWN", lngmId, int.Parse(strApplicationTypeId));
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
            BindGv_vAppCodeTypeRela();
            wucvAppCodeTypeRela4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;

            string strApplicationTypeId = ddlApplicationTypeIdq.SelectedValue;

            try
            {
                clsAppCodeTypeRelaBLEx.ReOrder(int.Parse(strApplicationTypeId));
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            BindGv_vAppCodeTypeRela();

        }
        private bool PreCheck4Order()
        {

            if (ddlApplicationTypeIdq.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请编程应用程序类型!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlApplicationTypeIdq.Focus();
                return false;
            }
           
            return true;
        }

        protected void btnGoTop_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvAppCodeTypeRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            List<string> arrMid = new List<string>();
            foreach(long mid in lstMId)
            {
                arrMid.Add(mid.ToString());
            }
            if (PreCheck4Order() == false) return;
            string strApplicationTypeId = ddlApplicationTypeIdq.SelectedValue;
            lblMsgList.Text = "";

            try
            {
                clsAppCodeTypeRelaBLEx.GoTop(lstMId, int.Parse( strApplicationTypeId));
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, objException.Message);
            }

            BindGv_vAppCodeTypeRela();
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvAppCodeTypeRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            List<string> arrMid = new List<string>();
            foreach (long mid in lstMId)
            {
                arrMid.Add(mid.ToString());
            }
            if (PreCheck4Order() == false) return;
            string strApplicationTypeId = ddlApplicationTypeIdq.SelectedValue;

            lblMsgList.Text = "";
            try
            {
                clsAppCodeTypeRelaBLEx.GoBottom(lstMId, int.Parse(strApplicationTypeId));
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
             clsCommonJsFunc.Alert(this, objException.Message);
            }

            BindGv_vAppCodeTypeRela();
        }

        protected void btnCopyTo_Click(object sender, EventArgs e)
        {

            if (ddlApplicationTypeId.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请编程应用程序类型!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlApplicationTypeId.Focus();
                return ;
            }
            string strApplicationTypeId = ddlApplicationTypeId.SelectedValue;

            List<long> lstMId = wucvAppCodeTypeRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            int intCount = 0;
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsAppCodeTypeRelaEN obj =  clsAppCodeTypeRelaBL.GetObjBymId(lngmId);
                    obj.ApplicationTypeId = int.Parse(strApplicationTypeId);
                    obj.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    obj.UpdUser = clsCommonSession.UserId;
                    string strCondition = string.Format("{0}={1} and {2}='{3}'", 
                        conAppCodeTypeRela.ApplicationTypeId, strApplicationTypeId,
                        conAppCodeTypeRela.CodeTypeId, obj.CodeTypeId);
                    if (clsAppCodeTypeRelaBL.IsExistRecord(strCondition) == false)
                    {
                        clsAppCodeTypeRelaBL.AddNewRecordBySql2(obj);
                        intCount++;
                    };
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000021)复制记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vAppCodeTypeRela();
            string strMsg1 = string.Format("复制成功！共计:{0}", intCount);
            clsCommonJsFunc.Alert(this, strMsg1);

        }

        protected void btnSetGroupName_Click(object sender, EventArgs e)
        {
            string strGroupName = txtGroupName.Text;
            if (string.IsNullOrEmpty(strGroupName) == true)
            {
                clsCommonJsFunc.Alert(this, "请输入新的组名！");
                txtGroupName.Focus();
                return;
            }
            List<long> lstmId = wucvAppCodeTypeRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstmId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002673)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            foreach (long lngMid in lstmId)
            {

                clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = clsAppCodeTypeRelaBL.GetObjBymIdCache(lngMid);
                clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objAppCodeTypeRelaEN.CodeTypeId);
                objCodeType.GroupName = strGroupName;
                objCodeType.UpdUser = clsCommonSession.UserId;
                objCodeType.UpdDate = clsDateTime.getTodayDateTimeStr(1);

                clsCodeTypeBL.UpdateBySql2(objCodeType);
            }
            BindGv_vAppCodeTypeRela();
        }
    }
}