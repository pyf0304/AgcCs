/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmwf_StepPointRela_QUDI
界面名:wfmwf_StepPointRela_QUDI(00050250)
生成代码版本:2019.08.27.1
生成日期:2019/08/28 17:17:33
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:工作流管理
模块英文名:WorkFlow
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
using System.Linq;

namespace AGC.Webform
{
    /// <summary>
    /// wfmwf_StepPointRela_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmwf_StepPointRela_QUDI : System.Web.UI.Page
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

                vsViewName = "工作流与结点关系维护";
                vsTabName = string.Format("{0}", clsvwf_StepPointRelaEN._CurrTabName);
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
                wucwf_StepPointRela1.SetDdl_PointId();
                wucwf_StepPointRela1.SetDdl_PointTypeId();

                clswf_WorkFlowBL.BindDdlWorkFlowId(ddlWorkFlowIdq);
                if (string.IsNullOrEmpty( clsPubVar.CurrWorkFlowId) == true)
                {
                    clsCommonJsFunc.Alert(this, "当前没有设置默认的工作流Id,请去相关界面设置！");
                    return;
                }
                ddlWorkFlowIdq.SelectedValue = clsPubVar.CurrWorkFlowId;
                ddlWorkFlowIdq.Enabled = false;

                clswf_PointBLEx.BindDdl_PointIdByPrjIdCache(ddlPointIdq, clsPubVar.CurrSelPrjId);
                clswf_PointTypeBL.BindDdlPointTypeId(ddlPointTypeIdq);
                clswf_WorkFlowBL.BindDdlWorkFlowId(ddlWorkFlowId_OrderNum);

                ddlWorkFlowId_OrderNum.SelectedValue = clsPubVar.CurrWorkFlowId;
                ddlWorkFlowId_OrderNum.Enabled = false;

                wucvwf_StepPointRela4Gv1.SetSortBy(string.Format("{0} Asc", convwf_StepPointRela.OrderNum));
                //2、显示无条件的表内容在GridView中
                BindGv_vwf_StepPointRela();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                Dispwf_StepPointRelaListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clswf_StepPointRelaBL.objCommFun4BL = new clsCommFun4BL4wf_StepPointRela();
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
            wucvwf_StepPointRela4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vwf_StepPointRela();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vwf_StepPointRela()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = Combinevwf_StepPointRelaCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvwf_StepPointRela4Gv1.BindGv_wf_StepPointRela(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvwf_StepPointRela4Gv1.SetGvVisibility(convwf_StepPointRela.UpdDate, false);
                //wucvwf_StepPointRela4Gv1.SetGvVisibility(convwf_StepPointRela.UpdUser, false);
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
        protected string Combinevwf_StepPointRelaCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
            try
            {
                if (this.ddlWorkFlowIdq.SelectedValue != "" && this.ddlWorkFlowIdq.SelectedValue != "0")
                {
                    objvwf_StepPointRelaEN.WorkFlowId = this.ddlWorkFlowIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convwf_StepPointRela.WorkFlowId, this.ddlWorkFlowIdq.SelectedValue);
                }
               
                if (this.ddlPointIdq.SelectedValue != "" && this.ddlPointIdq.SelectedValue != "0")
                {
                    objvwf_StepPointRelaEN.PointId = this.ddlPointIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convwf_StepPointRela.PointId, this.ddlPointIdq.SelectedValue);
                }
                if (this.ddlPointTypeIdq.SelectedValue != "" && this.ddlPointTypeIdq.SelectedValue != "0")
                {
                    objvwf_StepPointRelaEN.PointTypeId = this.ddlPointTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convwf_StepPointRela.PointTypeId, this.ddlPointTypeIdq.SelectedValue);
                }
                objvwf_StepPointRelaEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(Combinewf_StepPointRelaCondition)时出错!请联系管理员!" + objException.Message);
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
            Addwf_StepPointRelaRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void Addwf_StepPointRelaRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelwf_StepPointRelaEdit.Text = "取消添加";
            //wucwf_StepPointRela1.WorkFlowStepPointRelaId = clswf_StepPointRelaBL.GetMaxStrId_S();
            string strWorkFlowId = "";
            string strCondition = string.Format("{0}='{1}'", conwf_StepPointRela.WorkFlowId, strWorkFlowId);
            wucwf_StepPointRela1.OrderNum = clswf_StepPointRelaBL.GetRecCountByCond(strCondition) + 1;
            DispEditwf_StepPointRelaRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool Addwf_StepPointRelaRecordSave()
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
            clswf_StepPointRelaEN objwf_StepPointRelaEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucwf_StepPointRela1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clswf_StepPointRelaEN objwf_StepPointRelaEN;	//定义对象
            objwf_StepPointRelaEN = new clswf_StepPointRelaEN();    //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            try
            {
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataTowf_StepPointRelaClass(objwf_StepPointRelaEN);      //把界面的值传到
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
                objwf_StepPointRelaEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objwf_StepPointRelaEN.AddNewRecord();
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
            BindGv_vwf_StepPointRela();
            Dispwf_StepPointRelaListRegion();
            wucwf_StepPointRela1.Clear();       //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelwf_StepPointRelaEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngWorkFlowStepPointRelaId = wucvwf_StepPointRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngWorkFlowStepPointRelaId == 0) return;
            Updatewf_StepPointRelaRecord(lngWorkFlowStepPointRelaId);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void Updatewf_StepPointRelaRecord(long lngWorkFlowStepPointRelaId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngWorkFlowStepPointRelaId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelwf_StepPointRelaEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditwf_StepPointRelaRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ShowData)
        /// </summary>
        /// <param name = "lngWorkFlowStepPointRelaId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(long lngWorkFlowStepPointRelaId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngWorkFlowStepPointRelaId == 0) return;        //如果关键字为空就返回退出
                                                                //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clswf_StepPointRelaBL.IsExist(lngWorkFlowStepPointRelaId) == false)     //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[wf_StepPointRela]中,关键字为:[lngWorkFlowStepPointRelaId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN(lngWorkFlowStepPointRelaId);
            //4、获取类对象的所有属性；
            try
            {
                clswf_StepPointRelaBL.Getwf_StepPointRela(ref objwf_StepPointRelaEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objwf_StepPointRelaEN", objwf_StepPointRelaEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromwf_StepPointRelaClass(objwf_StepPointRelaEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjwf_StepPointRelaEN">表实体类对象</param>
        protected void GetDataFromwf_StepPointRelaClass(clswf_StepPointRelaEN pobjwf_StepPointRelaEN)
        {
            //wucwf_StepPointRela1.WorkFlowId = pobjwf_StepPointRelaEN.WorkFlowId;// 工作流Id
            wucwf_StepPointRela1.PointId = pobjwf_StepPointRelaEN.PointId;// 结点Id
            wucwf_StepPointRela1.PointTypeId = pobjwf_StepPointRelaEN.PointTypeId;// 工作流结点类型Id
            wucwf_StepPointRela1.OrderNum = pobjwf_StepPointRelaEN.OrderNum ?? 0;// 序号
            wucwf_StepPointRela1.Memo = pobjwf_StepPointRelaEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvwf_StepPointRela4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngWorkFlowStepPointRelaId = long.Parse(e.KeyId);
            Updatewf_StepPointRelaRecord(lngWorkFlowStepPointRelaId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objwf_StepPointRelaEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool Updatewf_StepPointRelaRecordSave(clswf_StepPointRelaEN objwf_StepPointRelaEN)
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
            if (!wucwf_StepPointRela1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            try
            {
                //2、把值从界面层传到逻辑层或数据实体层
                PutDataTowf_StepPointRelaClass(objwf_StepPointRelaEN);      //把界面的值传到
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
                objwf_StepPointRelaEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objwf_StepPointRelaEN.Update();
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
            BindGv_vwf_StepPointRela();
            Dispwf_StepPointRelaListRegion();
            wucwf_StepPointRela1.Clear();//添空控件中的内容
                                         //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelwf_StepPointRelaEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_wf_StepPointRela{0}'", objwf_StepPointRelaEN.WorkFlowStepPointRelaId.ToString().Trim()), true);
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
            clswf_StepPointRelaEN objwf_StepPointRelaEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    Addwf_StepPointRelaRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    Addwf_StepPointRelaRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objwf_StepPointRelaEN = (clswf_StepPointRelaEN)Session["objwf_StepPointRelaEN"];
                    Updatewf_StepPointRelaRecordSave(objwf_StepPointRelaEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjwf_StepPointRelaEN">数据传输的目的类对象</param>
        protected void PutDataTowf_StepPointRelaClass(clswf_StepPointRelaEN pobjwf_StepPointRelaEN)
        {
            pobjwf_StepPointRelaEN.SetWorkFlowId(clsPubVar.CurrWorkFlowId)// 工作流Id
            .SetPointId(wucwf_StepPointRela1.PointId)// 结点Id
            .SetPointTypeId(wucwf_StepPointRela1.PointTypeId)// 工作流结点类型Id
            .SetOrderNum(wucwf_StepPointRela1.OrderNum)// 序号
            .SetUpdDate(wucwf_StepPointRela1.UpdDate)// 修改日期
            .SetUpdUser(wucwf_StepPointRela1.UpdUser)// 修改者
            .SetMemo(wucwf_StepPointRela1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelwf_StepPointRelaEdit_Click(object sender, EventArgs e)
        {
            Dispwf_StepPointRelaListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<long> lstWorkFlowStepPointRelaId = wucvwf_StepPointRela4Gv1.GetAllCheckedKeysFromGv();
            if (lstWorkFlowStepPointRelaId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (long lngWorkFlowStepPointRelaId in lstWorkFlowStepPointRelaId)
                {
                    clswf_StepPointRelaBL.DelRecord(lngWorkFlowStepPointRelaId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vwf_StepPointRela();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvwf_StepPointRela4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngWorkFlowStepPointRelaId = long.Parse(e.KeyId);
            Deletewf_StepPointRelaRecord(lngWorkFlowStepPointRelaId);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "lngWorkFlowStepPointRelaId">给定关键字</param>
        protected void Deletewf_StepPointRelaRecord(long lngWorkFlowStepPointRelaId)
        {
            try
            {
                clswf_StepPointRelaBL.DelRecord(lngWorkFlowStepPointRelaId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vwf_StepPointRela();
        }

        /// <summary>
        ///置底
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PreCheck4Order)
        /// </summary>
        private bool PreCheck4Order()
        {
            if (ddlWorkFlowId_OrderNum.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请输入WorkFlowId!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlWorkFlowId_OrderNum.Focus();
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
            string strWorkFlowId = ddlWorkFlowId_OrderNum.SelectedValue;
            vsWorkFlowId_OrderNum = strWorkFlowId;
            List<long> arrWorkFlowStepPointRelaId = wucvwf_StepPointRela4Gv1.GetAllCheckedKeysFromGv();
            if (arrWorkFlowStepPointRelaId == null)
            {
                lblMsgList.Text = "请选择需要置顶的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clswf_StepPointRelaBL.GoTop(arrWorkFlowStepPointRelaId, vsWorkFlowId_OrderNum);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = Combinevwf_StepPointRelaCondition();
            wucvwf_StepPointRela4Gv1.BindGv_wf_StepPointRela(strWhereCond);
            wucvwf_StepPointRela4Gv1.SetCheckedItemsForGv(arrWorkFlowStepPointRelaId);
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
            string strWorkFlowId = ddlWorkFlowId_OrderNum.SelectedValue;
            vsWorkFlowId_OrderNum = strWorkFlowId;
            List<long> arrWorkFlowStepPointRelaId = wucvwf_StepPointRela4Gv1.GetAllCheckedKeysFromGv();
            if (arrWorkFlowStepPointRelaId == null)
            {
                lblMsgList.Text = "请选择需要置底的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clswf_StepPointRelaBL.GoBottom(arrWorkFlowStepPointRelaId, vsWorkFlowId_OrderNum);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置底出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = Combinevwf_StepPointRelaCondition();
            wucvwf_StepPointRela4Gv1.BindGv_wf_StepPointRela(strWhereCond);
            wucvwf_StepPointRela4Gv1.SetCheckedItemsForGv(arrWorkFlowStepPointRelaId);
        }

        /// <summary>
        ///重序
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnReOrder_Click)
        /// </summary>
        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strWorkFlowId = ddlWorkFlowId_OrderNum.SelectedValue;
            vsWorkFlowId_OrderNum = strWorkFlowId;
            try
            {
                clswf_StepPointRelaBL.ReOrder(vsWorkFlowId_OrderNum);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("重序出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = Combinevwf_StepPointRelaCondition();
            wucvwf_StepPointRela4Gv1.BindGv_wf_StepPointRela(strWhereCond);
        }

        /// <summary>
        ///移动记录，包括上移和下移
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_MoveRecord)
        /// </summary>
        protected void MoveRecord(string strDirect)
        {
            if (PreCheck4Order() == false) return;
            string strWorkFlowId = ddlWorkFlowId_OrderNum.SelectedValue;
            vsWorkFlowId_OrderNum = strWorkFlowId;
            long lngWorkFlowStepPointRelaId = wucvwf_StepPointRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngWorkFlowStepPointRelaId == 0)
            {
                lblMsgList.Text = string.Format("请选择需要移动({0})的记录!", strDirect);
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clswf_StepPointRelaBL.AdjustOrderNum(strDirect, lngWorkFlowStepPointRelaId, vsWorkFlowId_OrderNum);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("移动({0})记录出错。错误:{1}.({2})", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = Combinevwf_StepPointRelaCondition();
            wucvwf_StepPointRela4Gv1.BindGv_wf_StepPointRela(strWhereCond);
            wucvwf_StepPointRela4Gv1.SetCheckedItemForGv(lngWorkFlowStepPointRelaId);
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
        /// 导出Excel。根据查询区组合的查询条件,从[vwf_StepPointRela]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = Combinevwf_StepPointRelaCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "wf_StepPointRela信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convwf_StepPointRela.WorkFlowName); arrCnName.Add("工作流名称");
            arrColName.Add(convwf_StepPointRela.WorkFlowNameSim); arrCnName.Add("工作流简称");
            arrColName.Add(convwf_StepPointRela.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convwf_StepPointRela.PointName); arrCnName.Add("结点名称");
            arrColName.Add(convwf_StepPointRela.PointTypeName); arrCnName.Add("工作流结点类型名称");
            arrColName.Add(convwf_StepPointRela.LevelNo); arrCnName.Add("层序号");
            arrColName.Add(convwf_StepPointRela.InDegree); arrCnName.Add("入度");
            arrColName.Add(convwf_StepPointRela.OutDegree); arrCnName.Add("出度");
            arrColName.Add(convwf_StepPointRela.OrderNum); arrCnName.Add("序号");
            arrColName.Add(convwf_StepPointRela.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convwf_StepPointRela.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convwf_StepPointRela.Memo); arrCnName.Add("说明");
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
                objDT = clsvwf_StepPointRelaBL.GetDataTable(strWhereCond);
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
        private void Dispwf_StepPointRelaListRegion()
        {
            divList.Visible = true;
            tabEditwf_StepPointRelaRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditwf_StepPointRelaRegion()
        {
            divList.Visible = false;
            tabEditwf_StepPointRelaRegion.Visible = true;
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
        protected string vsWorkFlowId_OrderNum
        {
            get
            {
                string sClassificationField;
                sClassificationField = (string)ViewState["WorkFlowId_OrderNum"];
                if (sClassificationField == null)
                {
                    sClassificationField = "";
                }
                return sClassificationField;
            }
            set
            {
                string sClassificationField = value;
                ViewState.Add("WorkFlowId_OrderNum", sClassificationField);
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

        protected void btnSetLevelNo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsPubVar.CurrWorkFlowId) == true)
            {
                clsCommonJsFunc.Alert(this, "当前没有设置默认的工作流Id,请去相关界面设置！");
                return;
            }
            if (clswf_WorkFlowBLEx.SetLevelNoByWorkFlowId(clsPubVar.CurrWorkFlowId))
            {
                BindGv_vwf_StepPointRela();
                clsCommonJsFunc.Alert(this, "设置层成功！");
            };
        }
        private string GetPointName(string strPointId)
        {
            string strPointName = clswf_PointBL.GetNameByPointIdCache(strPointId);
            return strPointName;
        }
        protected void btnGetNextPoint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsPubVar.CurrWorkFlowId) == true)
            {
                clsCommonJsFunc.Alert(this, "当前没有设置默认的工作流Id,请去相关界面设置！");

                return;
            }
            long lngWorkFlowStepPointRelaId = wucvwf_StepPointRela4Gv1.GetFirstCheckedKeyFromGv();
            if (lngWorkFlowStepPointRelaId == 0) return;
            clswf_StepPointRelaEN obj = clswf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);

           IEnumerable<string> arrEndPoints =   clswf_StepProcessRelaBLEx.GetNextPointLstCache(clsPubVar.CurrWorkFlowId, obj.PointId);
            string strPointNameLst = "";
            List<string> arrEndPointNames = arrEndPoints.Select(clswf_PointBL.GetNameByPointIdCache).ToList();
            strPointNameLst = clsArray.GetSqlInStrByArray(arrEndPointNames, false);
            clsCommonJsFunc.Alert(this, strPointNameLst);
        }
    }
}