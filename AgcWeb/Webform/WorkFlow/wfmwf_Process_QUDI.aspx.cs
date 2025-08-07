
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmwf_Process_QUDI
界面名:wfmwf_Process_QUDI(00050252)
生成代码版本:2019.08.27.1
生成日期:2019/08/29 08:45:30
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

namespace AGC.Webform
{
    /// <summary>
    /// wfmwf_Process_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmwf_Process_QUDI : System.Web.UI.Page
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

                vsViewName = "工作流过程表维护";
                vsTabName = string.Format("{0}", clsvwf_ProcessEN._CurrTabName);
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
                wucwf_Process1.SetDdl_StartPoint();
                wucwf_Process1.SetDdl_EndPoint();

                clswf_ProjectsBL.BindDdl_PrjId(ddlPrjIdq);
                ddlPrjIdq.SelectedValue = clsPubVar.CurrPrjId;
                ddlPrjIdq.Enabled = false;

                clswf_PointBLEx.BindDdl_PointIdByPrjIdCache(ddlEndPointq, clsPubVar.CurrSelPrjId);

                clswf_PointBLEx.BindDdl_PointIdByPrjIdCache(ddlStartPointq, clsPubVar.CurrSelPrjId);
     
                clswf_ProjectsBL.BindDdl_PrjId(ddlPrjId_OrderNum);
                ddlPrjId_OrderNum.SelectedValue = clsPubVar.CurrPrjId;
                ddlPrjId_OrderNum.Enabled = false;
                wucvwf_Process4Gv1.SetSortBy(string.Format("{0} Asc", convwf_Process.OrderNum));
                //2、显示无条件的表内容在GridView中
                BindGv_vwf_Process();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucwf_Process1.SetKeyReadOnly(true);
                Dispwf_ProcessListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clswf_ProcessBL.objCommFun4BL = new clsCommFun4BL4wf_Process();
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
            wucvwf_Process4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vwf_Process();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vwf_Process()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = Combinevwf_ProcessCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvwf_Process4Gv1.BindGv_wf_Process(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvwf_Process4Gv1.SetGvVisibility(convwf_Process.UpdDate, false);
                //wucvwf_Process4Gv1.SetGvVisibility(convwf_Process.UpdUser, false);
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
        protected string Combinevwf_ProcessCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
            try
            {
                if (this.txtProcessIdq.Text.Trim() != "")
                {
                    objvwf_ProcessEN.ProcessId = this.txtProcessIdq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convwf_Process.ProcessId, this.txtProcessIdq.Text.Trim());
                }
                if (this.txtProcessNameq.Text.Trim() != "")
                {
                    objvwf_ProcessEN.ProcessName = this.txtProcessNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convwf_Process.ProcessName, this.txtProcessNameq.Text.Trim());
                }
                if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
                {
                    objvwf_ProcessEN.PrjId = this.ddlPrjIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convwf_Process.PrjId, this.ddlPrjIdq.SelectedValue);
                }
                if (this.ddlEndPointq.SelectedValue != "" && this.ddlEndPointq.SelectedValue != "0")
                {
                    objvwf_ProcessEN.EndPoint = this.ddlEndPointq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convwf_Process.EndPoint, this.ddlEndPointq.SelectedValue);
                }
                if (this.ddlStartPointq.SelectedValue != "" && this.ddlStartPointq.SelectedValue != "0")
                {
                    objvwf_ProcessEN.StartPoint = this.ddlStartPointq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convwf_Process.StartPoint, this.ddlStartPointq.SelectedValue);
                }
                objvwf_ProcessEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(Combinewf_ProcessCondition)时出错!请联系管理员!" + objException.Message);
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
            Addwf_ProcessRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void Addwf_ProcessRecord()
        {
            wucwf_Process1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelwf_ProcessEdit.Text = "取消添加";
            wucwf_Process1.ProcessId = clswf_ProcessBL.GetMaxStrId_S();
            wucwf_Process1.OrderNum = clswf_ProcessBL.GetRecCount() + 1;
            DispEditwf_ProcessRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool Addwf_ProcessRecordSave()
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
            clswf_ProcessEN objwf_ProcessEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucwf_Process1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clswf_ProcessEN objwf_ProcessEN;	//定义对象
            objwf_ProcessEN = new clswf_ProcessEN(wucwf_Process1.ProcessId);    //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clswf_ProcessBL.IsExist(objwf_ProcessEN.ProcessId)) //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000004)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            try
            {
                //4、把值从界面层传到逻辑层或数据实体层
                PutDataTowf_ProcessClass(objwf_ProcessEN);      //把界面的值传到
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
                objwf_ProcessEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objwf_ProcessEN.AddNewRecord();
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
            BindGv_vwf_Process();
            Dispwf_ProcessListRegion();
            wucwf_Process1.Clear();     //清空控件中内容
                                        ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelwf_ProcessEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strProcessId = wucvwf_Process4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strProcessId) == true) return;
            Updatewf_ProcessRecord(strProcessId);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void Updatewf_ProcessRecord(string strProcessId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strProcessId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucwf_Process1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelwf_ProcessEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditwf_ProcessRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ShowData)
        /// </summary>
        /// <param name = "strProcessId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strProcessId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strProcessId == "") return;     //如果关键字为空就返回退出
                                                //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clswf_ProcessBL.IsExist(strProcessId) == false)     //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[wf_Process]中,关键字为:[strProcessId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN(strProcessId);
            //4、获取类对象的所有属性；
            try
            {
                clswf_ProcessBL.Getwf_Process(ref objwf_ProcessEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objwf_ProcessEN", objwf_ProcessEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromwf_ProcessClass(objwf_ProcessEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjwf_ProcessEN">表实体类对象</param>
        protected void GetDataFromwf_ProcessClass(clswf_ProcessEN pobjwf_ProcessEN)
        {
            wucwf_Process1.ProcessId = pobjwf_ProcessEN.ProcessId;// 过程ID
            wucwf_Process1.ProcessName = pobjwf_ProcessEN.ProcessName;// 过程名称
            wucwf_Process1.StartPoint = pobjwf_ProcessEN.StartPoint;// 起点
            wucwf_Process1.EndPoint = pobjwf_ProcessEN.EndPoint;// 终点
            wucwf_Process1.OrderNum = pobjwf_ProcessEN.OrderNum ?? 0;// 序号
            
            wucwf_Process1.Memo = pobjwf_ProcessEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvwf_Process4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strProcessId = e.KeyId;
            Updatewf_ProcessRecord(strProcessId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objwf_ProcessEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool Updatewf_ProcessRecordSave(clswf_ProcessEN objwf_ProcessEN)
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
            if (!wucwf_Process1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            try
            {
                //2、把值从界面层传到逻辑层或数据实体层
                PutDataTowf_ProcessClass(objwf_ProcessEN);      //把界面的值传到
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
                objwf_ProcessEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objwf_ProcessEN.Update();
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
            BindGv_vwf_Process();
            Dispwf_ProcessListRegion();
            wucwf_Process1.Clear();//添空控件中的内容
                                   //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelwf_ProcessEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_wf_Process{0}'", objwf_ProcessEN.ProcessId.ToString().Trim()), true);
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
            clswf_ProcessEN objwf_ProcessEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    Addwf_ProcessRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    Addwf_ProcessRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objwf_ProcessEN = (clswf_ProcessEN)Session["objwf_ProcessEN"];
                    Updatewf_ProcessRecordSave(objwf_ProcessEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjwf_ProcessEN">数据传输的目的类对象</param>
        protected void PutDataTowf_ProcessClass(clswf_ProcessEN pobjwf_ProcessEN)
        {
            pobjwf_ProcessEN.SetProcessId(wucwf_Process1.ProcessId)// 过程ID
            .SetProcessName(wucwf_Process1.ProcessName)// 过程名称
            .SetStartPoint(wucwf_Process1.StartPoint)// 起点
            .SetEndPoint(wucwf_Process1.EndPoint)// 终点
            .SetOrderNum(wucwf_Process1.OrderNum)// 序号
            .SetUpdDate(wucwf_Process1.UpdDate)// 修改日期
            .SetUpdUser(wucwf_Process1.UpdUser)// 修改者
            .SetPrjId(clsPubVar.CurrSelPrjId)
            .SetMemo(wucwf_Process1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelwf_ProcessEdit_Click(object sender, EventArgs e)
        {
            Dispwf_ProcessListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<string> lstProcessId = wucvwf_Process4Gv1.GetAllCheckedKeysFromGv();
            if (lstProcessId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strProcessId in lstProcessId)
                {
                    clswf_ProcessBL.DelRecord(strProcessId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vwf_Process();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvwf_Process4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strProcessId = e.KeyId;
            Deletewf_ProcessRecord(strProcessId);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "strProcessId">给定关键字</param>
        protected void Deletewf_ProcessRecord(string strProcessId)
        {
            try
            {
                clswf_ProcessBL.DelRecord(strProcessId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vwf_Process();
        }

        /// <summary>
        ///置底
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PreCheck4Order)
        /// </summary>
        private bool PreCheck4Order()
        {
            if (ddlPrjId_OrderNum.SelectedIndex <= 0)
            {
                lblMsgList.Text = "请输入PrjId!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                ddlPrjId_OrderNum.Focus();
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
            string strPrjId = ddlPrjId_OrderNum.SelectedValue;
            vsPrjId_OrderNum = strPrjId;
            List<string> arrProcessId = wucvwf_Process4Gv1.GetAllCheckedKeysFromGv();
            if (arrProcessId == null)
            {
                lblMsgList.Text = "请选择需要置顶的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clswf_ProcessBL.GoTop(arrProcessId, vsPrjId_OrderNum);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = Combinevwf_ProcessCondition();
            wucvwf_Process4Gv1.BindGv_wf_Process(strWhereCond);
            wucvwf_Process4Gv1.SetCheckedItemsForGv(arrProcessId);
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
            string strPrjId = ddlPrjId_OrderNum.SelectedValue;
            vsPrjId_OrderNum = strPrjId;
            List<string> arrProcessId = wucvwf_Process4Gv1.GetAllCheckedKeysFromGv();
            if (arrProcessId == null)
            {
                lblMsgList.Text = "请选择需要置底的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clswf_ProcessBL.GoBottom(arrProcessId, vsPrjId_OrderNum);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置底出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = Combinevwf_ProcessCondition();
            wucvwf_Process4Gv1.BindGv_wf_Process(strWhereCond);
            wucvwf_Process4Gv1.SetCheckedItemsForGv(arrProcessId);
        }

        /// <summary>
        ///重序
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnReOrder_Click)
        /// </summary>
        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strPrjId = ddlPrjId_OrderNum.SelectedValue;
            vsPrjId_OrderNum = strPrjId;
            try
            {
                clswf_ProcessBL.ReOrder(vsPrjId_OrderNum);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("重序出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = Combinevwf_ProcessCondition();
            wucvwf_Process4Gv1.BindGv_wf_Process(strWhereCond);
        }

        /// <summary>
        ///移动记录，包括上移和下移
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_MoveRecord)
        /// </summary>
        protected void MoveRecord(string strDirect)
        {
            if (PreCheck4Order() == false) return;
            string strPrjId = ddlPrjId_OrderNum.SelectedValue;
            vsPrjId_OrderNum = strPrjId;
            string strProcessId = wucvwf_Process4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strProcessId) == true)
            {
                lblMsgList.Text = string.Format("请选择需要移动({0})的记录!", strDirect);
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clswf_ProcessBL.AdjustOrderNum(strDirect, strProcessId, vsPrjId_OrderNum);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("移动({0})记录出错。错误:{1}.({2})", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = Combinevwf_ProcessCondition();
            wucvwf_Process4Gv1.BindGv_wf_Process(strWhereCond);
            wucvwf_Process4Gv1.SetCheckedItemForGv(strProcessId);
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
        /// 导出Excel。根据查询区组合的查询条件,从[vwf_Process]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = Combinevwf_ProcessCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "wf_Process信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convwf_Process.ProcessId); arrCnName.Add("过程ID");
            arrColName.Add(convwf_Process.ProcessName); arrCnName.Add("过程名称");
            arrColName.Add(convwf_Process.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convwf_Process.EndPoint); arrCnName.Add("终点");
            arrColName.Add(convwf_Process.StartPoint); arrCnName.Add("起点");
            arrColName.Add(convwf_Process.WorkPage); arrCnName.Add("工作页面");
            arrColName.Add(convwf_Process.OrderNum); arrCnName.Add("序号");
            arrColName.Add(convwf_Process.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convwf_Process.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convwf_Process.Memo); arrCnName.Add("说明");
            arrColName.Add(convwf_Process.StartPointName); arrCnName.Add("起点名");
            arrColName.Add(convwf_Process.EndPointName); arrCnName.Add("终点名");
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
                objDT = clsvwf_ProcessBL.GetDataTable(strWhereCond);
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
        private void Dispwf_ProcessListRegion()
        {
            divList.Visible = true;
            tabEditwf_ProcessRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditwf_ProcessRegion()
        {
            divList.Visible = false;
            tabEditwf_ProcessRegion.Visible = true;
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
        protected string vsPrjId_OrderNum
        {
            get
            {
                string sClassificationField;
                sClassificationField = (string)ViewState["PrjId_OrderNum"];
                if (sClassificationField == null)
                {
                    sClassificationField = "";
                }
                return sClassificationField;
            }
            set
            {
                string sClassificationField = value;
                ViewState.Add("PrjId_OrderNum", sClassificationField);
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

        protected void btnNormalizedName_Click(object sender, EventArgs e)
        {
            List<string> lstProcessId = wucvwf_Process4Gv1.GetAllCheckedKeysFromGv();
            if (lstProcessId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strProcessId in lstProcessId)
                {
                    clswf_ProcessEN objProcess = clswf_ProcessBL.GetObjByProcessId(strProcessId);
                    clswf_PointEN objPoint_Start = clswf_PointBL.GetObjByPointIdCache(objProcess.StartPoint);
                    clswf_PointEN objPoint_End = clswf_PointBL.GetObjByPointIdCache(objProcess.EndPoint);

                    objProcess.ProcessName = string.Format("{0}==>{1}", objPoint_Start.PointName, objPoint_End.PointName);
                    objProcess.Update();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vwf_Process();
        }
    }
}