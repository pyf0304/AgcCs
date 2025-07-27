/*-- -- -- -- -- -- -- -- -- -- --
 类名:wfmReferFilesB_QUDI
 界面名:wfmReferFiles_QUDI(00050224)
 生成代码版本:2019.05.17.1
 生成日期:2019/05/17 11:30:39
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码
 模块英文名:GeneCode
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
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC;
namespace AGC.Webform
{
    /// <summary>
    /// wfmReferFilesB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmReferFilesB_QUDI : System.Web.UI.Page
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

                vsViewName = "引用文件维护";
                vsTabName = string.Format("{0}", clsvReferFilesEN._CurrTabName);
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
                wucvReferFiles4Gv1.SetSortBy(string.Format("{0} Asc", convReferFiles.ReferFileId));
                //2、显示无条件的表内容在GridView中
                BindGv_vReferFiles();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucReferFilesB1.SetKeyReadOnly(true);
                DispReferFilesListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsReferFilesBL.objCommFun4BL = new clsCommFun4BL4ReferFiles();
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
            wucvReferFiles4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vReferFiles();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vReferFiles()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevReferFilesCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvReferFiles4Gv1.BindGv_ReferFiles(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvReferFiles4Gv1.SetGvVisibility(convReferFiles.UpdDate, false);
                //wucvReferFiles4Gv1.SetGvVisibility(convReferFiles.UpdUser, false);
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
        protected string CombinevReferFilesCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
            try
            {
                if (this.txtFileNameq.Text.Trim() != "")
                {
                    objvReferFilesEN.FileName = this.txtFileNameq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convReferFiles.FileName, this.txtFileNameq.Text.Trim());
                }
                if (this.txtVersionq.Text.Trim() != "")
                {
                    objvReferFilesEN.Version = this.txtVersionq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convReferFiles.Version, this.txtVersionq.Text.Trim());
                }
                if (this.txtFilePathq.Text.Trim() != "")
                {
                    objvReferFilesEN.FilePath = this.txtFilePathq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convReferFiles.FilePath, this.txtFilePathq.Text.Trim());
                }
                if (this.txtUpdUserIdq.Text.Trim() != "")
                {
                    objvReferFilesEN.UpdUserId = this.txtUpdUserIdq.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convReferFiles.UpdUserId, this.txtUpdUserIdq.Text.Trim());
                }
                if (this.chkIsNeedDownLoadq.Checked == true)
                {
                    objvReferFilesEN.IsNeedDownLoad = true;
                    strWhereCond += string.Format(" And {0} = '1'", convReferFiles.IsNeedDownLoad);
                }
                else
                {
                    objvReferFilesEN.IsNeedDownLoad = false;
                    strWhereCond += string.Format(" And {0} = '0'", convReferFiles.IsNeedDownLoad);
                }
                objvReferFilesEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineReferFilesCondition)时出错!请联系管理员!" + objException.Message);
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
            AddReferFilesRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecord)
        /// </summary>
        protected void AddReferFilesRecord()
        {
            wucReferFilesB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelReferFilesEdit.Text = "取消添加";
            wucReferFilesB1.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
            wucReferFilesB1.OrderNum = clsReferFilesBL.GetRecCount() + 1;
            DispEditReferFilesRegion();
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordSave)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddReferFilesRecordSave()
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
            clsReferFilesEN objReferFilesEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucReferFilesB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsReferFilesEN objReferFilesEN;	//定义对象
            objReferFilesEN = new clsReferFilesEN(wucReferFilesB1.ReferFileId); //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

            //因为是字符型自增主键，不需要检查主键是否已经存在，在添加时，再获取 最大值作为主键
            //if (clsReferFilesBL.IsExist(objReferFilesEN.ReferFileId))	//判断是否有相同的关键字
            //{
            //strMsg = "(errid:WebI000004)关键字字段已有相同的值";
            //clsCommonJsFunc.Alert(this, strMsg);
            //return false;
            //}
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToReferFilesClass(objReferFilesEN);      //把界面的值传到
                                                            //5.1、检查传进去的对象属性是否合法
            try
            {
                objReferFilesEN.CheckPropertyNew();
                //因为是字符型自增主键，所以在添加时，自动获取主键值。
                if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true || clsReferFilesBL.IsExist(objReferFilesEN.ReferFileId) == true)
                {
                    objReferFilesEN.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
                }
                //6、把数据实体层的数据存贮到数据库中
                objReferFilesEN.AddNewRecord();
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
            BindGv_vReferFiles();
            DispReferFilesListRegion();
            wucReferFilesB1.Clear();        //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelReferFilesEdit.Text = "取消编辑";
            return true;
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnCopyRecord_Click4OneKeyword)
        /// </summary>
        protected void btnCopyRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strReferFileId = wucvReferFiles4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strReferFileId) == true) return;
            CopyRecord(strReferFileId);
        }

        /// <summary>
        /// 复制记录,把给定关键字的记录内容复制一个新记录，把名称字段值的前面加上"Copy_"
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CopyRecord)
        /// </summary>
        protected void CopyRecord(string strReferFileId)
        {
            try
            {
                K_ReferFileId_ReferFiles myKey = new K_ReferFileId_ReferFiles(strReferFileId);
                clsReferFilesEN objReferFilesEN = myKey.GetObj();
                objReferFilesEN.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
                objReferFilesEN.SetFileName("Copy_" + objReferFilesEN.FileName);
                objReferFilesEN.AddNewRecord();
                BindGv_vReferFiles();
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
            string strReferFileId = wucvReferFiles4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strReferFileId) == true) return;
            UpdateReferFilesRecord(strReferFileId);
        }

        /// <summary>
        ///设置字段值
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnSetFieldValue_Click)
        /// </summary>
        protected void btnSetInUse_Click(object sender, System.EventArgs e)
        {
            List<string> lstReferFileId = wucvReferFiles4Gv1.GetAllCheckedKeysFromGv();
            if (lstReferFileId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strReferFileId in lstReferFileId)
                {
                    K_ReferFileId_ReferFiles objKey = new K_ReferFileId_ReferFiles(strReferFileId);
                    clsReferFilesEN objReferFiles = objKey.GetObj();
                    objReferFiles.SetInUse(bool.Parse("true"));
                    objReferFiles.Update();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000027)设置是否在用不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vReferFiles();
        }
        /// <summary>
        ///设置字段值
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnSetFieldValue_Click)
        /// </summary>
        protected void btnSetNotInUse_Click(object sender, System.EventArgs e)
        {
            List<string> lstReferFileId = wucvReferFiles4Gv1.GetAllCheckedKeysFromGv();
            if (lstReferFileId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strReferFileId in lstReferFileId)
                {
                    K_ReferFileId_ReferFiles objKey = new K_ReferFileId_ReferFiles(strReferFileId);
                    clsReferFilesEN objReferFiles = objKey.GetObj();
                    objReferFiles.SetInUse(bool.Parse("false"));
                    objReferFiles.Update();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000029)设置是否在用不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vReferFiles();
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecord)
        /// </summary>
        protected void UpdateReferFilesRecord(string strReferFileId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strReferFileId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucReferFilesB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelReferFilesEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditReferFilesRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ShowData)
        /// </summary>
        /// <param name = "strReferFileId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strReferFileId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strReferFileId == "") return;       //如果关键字为空就返回退出
                                                    //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsReferFilesBL.IsExist(strReferFileId) == false)       //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[ReferFiles]中,关键字为:[strReferFileId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsReferFilesEN objReferFilesEN = new clsReferFilesEN(strReferFileId);
            //4、获取类对象的所有属性；
            try
            {
                clsReferFilesBL.GetReferFiles(ref objReferFilesEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }
            Session.Add("objReferFilesEN", objReferFilesEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromReferFilesClass(objReferFilesEN);
        }

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_GetDataFromClass)
        /// </summary>
        /// <param name = "pobjReferFilesEN">表实体类对象</param>
        protected void GetDataFromReferFilesClass(clsReferFilesEN pobjReferFilesEN)
        {
            wucReferFilesB1.ReferFileId = pobjReferFilesEN.ReferFileId;// 引用文件Id
            wucReferFilesB1.FileName = pobjReferFilesEN.FileName;// 文件名
            wucReferFilesB1.FilePath = pobjReferFilesEN.FilePath;// 文件路径
            wucReferFilesB1.IsNeedDownLoad = pobjReferFilesEN.IsNeedDownLoad;// 是否需要下载
            wucReferFilesB1.Version = pobjReferFilesEN.Version;// 版本
            wucReferFilesB1.InUse = pobjReferFilesEN.InUse;// 是否在用
            wucReferFilesB1.OrderNum = pobjReferFilesEN.OrderNum;// 序号
            wucReferFilesB1.Memo = pobjReferFilesEN.Memo;// 说明
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvReferFiles4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strReferFileId = e.KeyId;
            UpdateReferFilesRecord(strReferFileId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_UpdateRecordSave)
        /// </summary>
        /// <param name = "objReferFilesEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateReferFilesRecordSave(clsReferFilesEN objReferFilesEN)
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
            if (!wucReferFilesB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToReferFilesClass(objReferFilesEN);      //把界面的值传到
                                                            //3.1、检查传进去的对象属性是否合法
            try
            {
                objReferFilesEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objReferFilesEN.Update();
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
            BindGv_vReferFiles();
            DispReferFilesListRegion();
            wucReferFilesB1.Clear();//添空控件中的内容
                                    //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelReferFilesEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_ReferFiles{0}'", objReferFilesEN.ReferFileId.ToString().Trim()), true);
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
            clsReferFilesEN objReferFilesEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddReferFilesRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddReferFilesRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objReferFilesEN = (clsReferFilesEN)Session["objReferFilesEN"];
                    UpdateReferFilesRecordSave(objReferFilesEN);
                    break;
            }
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_PutDataToClass)
        /// </summary>
        /// <param name = "pobjReferFilesEN">数据传输的目的类对象</param>
        protected void PutDataToReferFilesClass(clsReferFilesEN pobjReferFilesEN)
        {
            pobjReferFilesEN.SetReferFileId(wucReferFilesB1.ReferFileId)// 引用文件Id
            .SetFileName(wucReferFilesB1.FileName)// 文件名
            .SetFilePath(wucReferFilesB1.FilePath)// 文件路径
            .SetIsNeedDownLoad(wucReferFilesB1.IsNeedDownLoad)// 是否需要下载
            .SetVersion(wucReferFilesB1.Version)// 版本
            .SetInUse(wucReferFilesB1.InUse)// 是否在用
            .SetOrderNum(wucReferFilesB1.OrderNum)// 序号
            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))//(字段类型:string,字段长度:14,是否可空:14)
            .SetUpdUserId(clsCommonSession.UserId)//(字段类型:string,字段长度:20,是否可空:20)
            .SetMemo(wucReferFilesB1.Memo);// 说明
        }


        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelReferFilesEdit_Click(object sender, EventArgs e)
        {
            DispReferFilesListRegion();
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            List<string> lstReferFileId = wucvReferFiles4Gv1.GetAllCheckedKeysFromGv();
            if (lstReferFileId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strReferFileId in lstReferFileId)
                {
                    clsReferFilesBL.DelRecord(strReferFileId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vReferFiles();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvReferFiles4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strReferFileId = e.KeyId;
            DeleteReferFilesRecord(strReferFileId);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "strReferFileId">给定关键字</param>
        protected void DeleteReferFilesRecord(string strReferFileId)
        {
            try
            {
                clsReferFilesBL.DelRecord(strReferFileId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vReferFiles();
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
            List<string> lstReferFileId = wucvReferFiles4Gv1.GetAllCheckedKeysFromGv();
            if (lstReferFileId == null)
            {
                lblMsgList.Text = "请选择需要置顶的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsReferFilesBL.GoTop(lstReferFileId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevReferFilesCondition();
            wucvReferFiles4Gv1.BindGv_ReferFiles(strWhereCond);
            foreach (string strReferFileId in lstReferFileId)
            {
                wucvReferFiles4Gv1.SetCheckedItemForGv(strReferFileId);
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
            List<string> lstReferFileId = wucvReferFiles4Gv1.GetAllCheckedKeysFromGv();
            if (lstReferFileId == null)
            {
                lblMsgList.Text = "请选择需要置底的记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsReferFilesBL.GoBottom(lstReferFileId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置底出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevReferFilesCondition();
            wucvReferFiles4Gv1.BindGv_ReferFiles(strWhereCond);
            foreach (string strReferFileId in lstReferFileId)
            {
                wucvReferFiles4Gv1.SetCheckedItemForGv(strReferFileId);
            }
        }

        /// <summary>
        ///移动记录，包括上移和下移
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_MoveRecord)
        /// </summary>
        protected void MoveRecord(string strDirect)
        {
            if (PreCheck4Order() == false) return;
            string strReferFileId = wucvReferFiles4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strReferFileId) == true)
            {
                lblMsgList.Text = string.Format("请选择需要移动({0})的记录!", strDirect);
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsReferFilesBL.AdjustOrderNum(strDirect, strReferFileId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("移动({0})记录出错。错误:{1}.({2})", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevReferFilesCondition();
            wucvReferFiles4Gv1.BindGv_ReferFiles(strWhereCond);
            wucvReferFiles4Gv1.SetCheckedItemForGv(strReferFileId);
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
        /// 导出Excel。根据查询区组合的查询条件,从[vReferFiles]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevReferFilesCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ReferFiles信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convReferFiles.FileName); arrCnName.Add("文件名");
            arrColName.Add(convReferFiles.Version); arrCnName.Add("版本");
            arrColName.Add(convReferFiles.FilePath); arrCnName.Add("文件路径");
            arrColName.Add(convReferFiles.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convReferFiles.IsNeedDownLoad); arrCnName.Add("是否需要下载");
            arrColName.Add(convReferFiles.Memo); arrCnName.Add("说明");
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
                objDT = clsvReferFilesBL.GetDataTable(strWhereCond);
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
        private void DispReferFilesListRegion()
        {
            divList.Visible = true;
            tabEditReferFilesRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DispEditRegion)
        /// </summary>
        private void DispEditReferFilesRegion()
        {
            divList.Visible = false;
            tabEditReferFilesRegion.Visible = true;
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