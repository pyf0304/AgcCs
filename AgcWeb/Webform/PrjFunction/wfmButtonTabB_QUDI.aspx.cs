
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmButtonTabB_QUDI
表名:ButtonTab(00050427)
生成代码版本:2019.03.09.1
生成日期:2019/03/11 07:46:12
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
框架-层名:Web界面后台代码(WebViewControlCode)
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
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC;
namespace AGC.Webform
{
    /// <summary>
    /// wfmButtonTabB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCodeWithWuc4Gv)
    /// </summary>
    public partial class wfmButtonTabB_QUDI : System.Web.UI.Page
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

                vsViewName = "ButtonTab维护";
                vsTabName = string.Format("{0}", clsButtonTabEN._CurrTabName);
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
                wucButtonTab4Gv1.SetSortBy(string.Format("{0} Asc", conButtonTab.ButtonId));
                //2、显示无条件的表内容在GridView中
                BindGv_ButtonTab();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucButtonTabB1.SetKeyReadOnly(true);
                DispButtonTabListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsButtonTabBL.objCommFun4BL = new clsCommFun4BL4ButtonTab();
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
            wucButtonTab4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_ButtonTab();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_ButtonTab()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombineButtonTabCondition();
                //	2、调用控件中的绑定GridView函数；
                wucButtonTab4Gv1.BindGv_ButtonTab(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucButtonTab4Gv1.SetGvVisibility(conButtonTab.UpdDate, false);
                //wucButtonTab4Gv1.SetGvVisibility(conButtonTab.UpdUser, false);
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
        protected string CombineButtonTabCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
            try
            {
                if (this.txtButtonIdq.Text.Trim() != "")
                {
                    objButtonTabEN.ButtonId = this.txtButtonIdq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conButtonTab.ButtonId, this.txtButtonIdq.Text.Trim());
                }
                if (this.txtButtonNameq.Text.Trim() != "")
                {
                    objButtonTabEN.ButtonName = this.txtButtonNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conButtonTab.ButtonName, this.txtButtonNameq.Text.Trim());
                }
                if (this.txtTextq.Text.Trim() != "")
                {
                    objButtonTabEN.Text = this.txtTextq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conButtonTab.Text, this.txtTextq.Text.Trim());
                }
                if (this.txtCssClassq.Text.Trim() != "")
                {
                    objButtonTabEN.CssClass = this.txtCssClassq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conButtonTab.CssClass, this.txtCssClassq.Text.Trim());
                }
                clsButtonTabBL.CheckProperty4Condition(objButtonTabEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineButtonTabCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
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

        #endregion 查询相关函数



        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        /// <summary>
        ///添加新记录的事件过程 
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnAddNewRec4Gv_Click)
        /// </summary>
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddButtonTabRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddButtonTabRecord()
        {
            wucButtonTabB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelButtonTabEdit.Text = "取消添加";
            wucButtonTabB1.ButtonId = clsButtonTabBL.GetMaxStrId_S();
            DispEditButtonTabRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddButtonTabRecordSave()
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
            clsButtonTabEN objButtonTabEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucButtonTabB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsButtonTabEN objButtonTabEN;	//定义对象
            objButtonTabEN = new clsButtonTabEN(wucButtonTabB1.ButtonId);   //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsButtonTabBL.IsExist(objButtonTabEN.ButtonId))    //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000004)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToButtonTabClass(objButtonTabEN);        //把界面的值传到
                                                            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsButtonTabBL.CheckPropertyNew(objButtonTabEN);
                //6、把数据实体层的数据存贮到数据库中
                clsButtonTabBL.AddNewRecordBySql2(objButtonTabEN);
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
            BindGv_ButtonTab();
            DispButtonTabListRegion();
            wucButtonTabB1.Clear();     //清空控件中内容
                                        ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelButtonTabEdit.Text = "取消编辑";
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
            string strButtonId = wucButtonTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strButtonId) == true) return;
            UpdateButtonTabRecord(strButtonId);
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strButtonId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strButtonId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strButtonId == "") return;      //如果关键字为空就返回退出
                                                //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsButtonTabBL.IsExist(strButtonId) == false)       //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[ButtonTab]中,关键字为:[strButtonId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsButtonTabEN objButtonTabEN = new clsButtonTabEN(strButtonId);
            //4、获取类对象的所有属性；
            try
            {
                clsButtonTabBL.GetButtonTab(ref objButtonTabEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objButtonTabEN", objButtonTabEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromButtonTabClass(objButtonTabEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjButtonTabEN">表实体类对象</param>
        protected void GetDataFromButtonTabClass(clsButtonTabEN pobjButtonTabEN)
        {
            wucButtonTabB1.ButtonId = pobjButtonTabEN.ButtonId;// 按钮Id
            wucButtonTabB1.ButtonName = pobjButtonTabEN.ButtonName;// 按钮名称
            wucButtonTabB1.Text = pobjButtonTabEN.Text;// 文本
            wucButtonTabB1.Height = pobjButtonTabEN.Height ?? 0;// 高度
            wucButtonTabB1.Width = pobjButtonTabEN.Width ?? 0;// 宽
            wucButtonTabB1.CssClass = pobjButtonTabEN.CssClass;// 样式表
            wucButtonTabB1.ImageUrl = pobjButtonTabEN.ImageUrl;// 图片资源
            wucButtonTabB1.InUse = pobjButtonTabEN.InUse;// 是否在用
            wucButtonTabB1.OrderNum = pobjButtonTabEN.OrderNum ?? 0;// 序号
            
            wucButtonTabB1.Memo = pobjButtonTabEN.Memo;// 说明
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucButtonTab4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strButtonId = e.KeyId;
            UpdateButtonTabRecord(strButtonId);
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateButtonTabRecord(string strButtonId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strButtonId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucButtonTabB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelButtonTabEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditButtonTabRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objButtonTabEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateButtonTabRecordSave(clsButtonTabEN objButtonTabEN)
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
            if (!wucButtonTabB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToButtonTabClass(objButtonTabEN);        //把界面的值传到
                                                            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsButtonTabBL.CheckPropertyNew(objButtonTabEN);
                //4、把数据实体层的数据存贮到数据库中
                clsButtonTabBL.UpdateBySql2(objButtonTabEN);
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
            BindGv_ButtonTab();
            DispButtonTabListRegion();
            wucButtonTabB1.Clear();//添空控件中的内容
                                   //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelButtonTabEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_ButtonTab{0}'", objButtonTabEN.ButtonId.ToString().Trim()), true);
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
            clsButtonTabEN objButtonTabEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddButtonTabRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddButtonTabRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objButtonTabEN = (clsButtonTabEN)Session["objButtonTabEN"];
                    UpdateButtonTabRecordSave(objButtonTabEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelButtonTabEdit_Click(object sender, EventArgs e)
        {
            DispButtonTabListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjButtonTabEN">数据传输的目的类对象</param>
        protected void PutDataToButtonTabClass(clsButtonTabEN pobjButtonTabEN)
        {
            pobjButtonTabEN.ButtonId = wucButtonTabB1.ButtonId;// 按钮Id
            pobjButtonTabEN.ButtonName = wucButtonTabB1.ButtonName;// 按钮名称
            pobjButtonTabEN.Text = wucButtonTabB1.Text;// 文本
            pobjButtonTabEN.Height = wucButtonTabB1.Height;// 高度
            pobjButtonTabEN.Width = wucButtonTabB1.Width;// 宽
            pobjButtonTabEN.CssClass = wucButtonTabB1.CssClass;// 样式表
            pobjButtonTabEN.ImageUrl = wucButtonTabB1.ImageUrl;// 图片资源
            pobjButtonTabEN.InUse = wucButtonTabB1.InUse;// 是否在用
            pobjButtonTabEN.OrderNum = wucButtonTabB1.OrderNum;// 序号
            pobjButtonTabEN.UpdUser = wucButtonTabB1.UpdUser;// 修改者
            pobjButtonTabEN.UpdDate = wucButtonTabB1.UpdDate;// 修改日期
            pobjButtonTabEN.Memo = wucButtonTabB1.Memo;// 说明
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstButtonId = wucButtonTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstButtonId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strButtonId in lstButtonId)
                {
                    clsButtonTabBL.DelRecord(strButtonId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000021)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_ButtonTab();
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucButtonTab4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strButtonId = e.KeyId;
            DeleteButtonTabRecord(strButtonId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "strButtonId">给定关键字</param>
        protected void DeleteButtonTabRecord(string strButtonId)
        {
            try
            {
                clsButtonTabBL.DelRecord(strButtonId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_ButtonTab();
        }
        #endregion 删除相关函数


        #region 排序相关函数

        /// <summary>
        ///置底
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPreCheck4Order)
        /// </summary>
        private bool PreCheck4Order()
        {
            return true;
        }

        /// <summary>
        ///移动记录，包括上移和下移
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenMoveRecord)
        /// </summary>
        protected void MoveRecord(string strDirect)
        {
            if (PreCheck4Order() == false) return;
            string strButtonId = wucButtonTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strButtonId) == true)
            {
                lblMsgList.Text = string.Format("请选择需要移动({0})的记录!", strDirect);
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsButtonTabBL.AdjustOrderNum(strDirect, strButtonId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("移动({0})记录出错。错误:{1}.({2})", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombineButtonTabCondition();
            wucButtonTab4Gv1.BindGv_ButtonTab(strWhereCond);
            wucButtonTab4Gv1.SetCheckedItemForGv(strButtonId);
        }

        /// <summary>
        ///置顶
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnGoTop_Click)
        /// </summary>
        protected void btnGoTop_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;

            List<string> lstButtonId = wucButtonTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstButtonId == null)
            {
                lblMsgList.Text = "请选择需要置顶的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsButtonTabBL.GoTop(lstButtonId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombineButtonTabCondition();
            wucButtonTab4Gv1.BindGv_ButtonTab(strWhereCond);
        }

        /// <summary>
        ///置底
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnGoBottum_Click)
        /// </summary>
        protected void btnGoBottum_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            List<string> lstButtonId = wucButtonTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstButtonId == null)
            {
                lblMsgList.Text = "请选择需要置底的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsButtonTabBL.GoBottom(lstButtonId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置底出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombineButtonTabCondition();
            wucButtonTab4Gv1.BindGv_ButtonTab(strWhereCond);
        }

        /// <summary>
        ///上移
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpMove_Click)
        /// </summary>
        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            MoveRecord("UP");
        }

        /// <summary>
        ///下移
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDownMove_Click)
        /// </summary>
        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            MoveRecord("DOWN");
        }

        /// <summary>
        ///重序
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnReOrder_Click)
        /// </summary>
        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            try
            {
                clsButtonTabBL.ReOrder();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("重序出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombineButtonTabCondition();
            wucButtonTab4Gv1.BindGv_ButtonTab(strWhereCond);
        }
        #endregion 排序相关函数


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
        /// 导出Excel。根据查询区组合的查询条件,从[ButtonTab]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineButtonTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ButtonTab信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(conButtonTab.ButtonId); arrCnName.Add("按钮Id");
            arrColName.Add(conButtonTab.ButtonName); arrCnName.Add("按钮名称");
            arrColName.Add(conButtonTab.Text); arrCnName.Add("文本");
            arrColName.Add(conButtonTab.Height); arrCnName.Add("高度");
            arrColName.Add(conButtonTab.Width); arrCnName.Add("宽");
            arrColName.Add(conButtonTab.CssClass); arrCnName.Add("样式表");
            arrColName.Add(conButtonTab.ImageUrl); arrCnName.Add("图片资源");
            arrColName.Add(conButtonTab.InUse); arrCnName.Add("是否在用");
            arrColName.Add(conButtonTab.OrderNum); arrCnName.Add("序号");
            arrColName.Add(conButtonTab.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(conButtonTab.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(conButtonTab.Memo); arrCnName.Add("说明");
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
                objDT = clsButtonTabBL.GetDataTable(strWhereCond);
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
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListRegion)
        /// </summary>
        private void DispButtonTabListRegion()
        {
            divList.Visible = true;
            tabEditButtonTabRegion.Visible = false;
        }
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispEditRegion)
        /// </summary>
        private void DispEditButtonTabRegion()
        {
            divList.Visible = false;
            tabEditButtonTabRegion.Visible = true;
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

    }
}