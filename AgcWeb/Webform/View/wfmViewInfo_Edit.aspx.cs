
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmViewRegion_QUDI
界面名:wfmViewRegion_QUDI(00050304)
生成代码版本:2020.09.24.1
生成日期:2020/10/04 00:19:42
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.ddns.net,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:Web界面后台(WebViewControlCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
using AGC.web.treeview;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.web.treeview;
using CommFunc4WebForm;

namespace AGC.Webform
{
    /// <summary>
    /// wfmViewRegion_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.WebViewControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wfmViewInfo_Edit : System.Web.UI.Page
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
                string strCmPrjId = clsUserDefaValue_LocalBLEx.getUserDefaValue( clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认CM工程");
                vsCmPrjId = strCmPrjId;

                vsPrjId_Cache = "";
                //1、初始化，初始化一些导出Excel要用的变量
                vsViewName = "界面区域维护";
                vsTabName = string.Format("{0}", clsvViewRegionEN._CurrTabName);
                //2、用户权限管理:处理当前用户在当前界面的权限相关操作
                AccessUserPotence();
                //3、绑定查询区的下拉框
                BindDdl4QueryRegion();
                if (ddlApplicationTypeId.SelectedValue == "0")
                {
                    ddlApplicationTypeId.SelectedValue = "2";
                }
                vsApplicationTypeId = int.Parse( ddlApplicationTypeId.SelectedValue.ToString());
                BindTv_ViewFeatureRela();
                //4、设置列表区的排序字段

                //5、显示无条件的表内容在GridView中
                BindGv_vViewRegion();
                //7、设置逻辑层的公共函数，包含：缓存刷新函数
                //clsViewRegionBL.objCommFun4BL = new clsCommFun4BL4ViewRegion();
            }
        }


        /// <summary>
        /// 函数功能:为查询区控件绑定下拉框。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindDropDownLst4QueryRegion)
        /// </summary>
        protected void BindDdl4QueryRegion()
        {

            try
            {
                clsRegionTypeBL.BindDdl_RegionTypeId(ddlRegionTypeIdq);
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeId, clsPubVar.CurrSelPrjId);
                if (string.IsNullOrEmpty(vsCmPrjId) == false)
                {
                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(vsCmPrjId);
                    ddlApplicationTypeId.SelectedValue = objCMProject.ApplicationTypeId.ToString();
                }
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjIdq, clsPubVar.CurrSelPrjId);
                if (string.IsNullOrEmpty(vsCmPrjId) == false) ddlCmPrjIdq.SelectedValue = vsCmPrjId;

            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000044)绑定查询区下拉框出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
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
            //wucvViewRegion4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            //BindGv_vViewRegion();
            BindTv_ViewFeatureRela();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vViewRegion()
        {
            //操作步骤:(共5步)
            //	1、设置Gv控件的某些列不可见;
            //	2、组合界面条件串；
            //	3、调用控件中的绑定GridView函数;

            try
            {
                //	1、设置Gv控件的某些列不可见；
                //wucvViewRegion4Gv1.SetGvVisibility(convViewRegion.UpdDate, false);
                //wucvViewRegion4Gv1.SetGvVisibility(convViewRegion.UpdUser, false);
                //	2、组合界面条件串；
                string strWhereCond = CombinevViewRegionCondition();
                //	3、调用控件中的绑定GridView函数；
                //wucvViewRegion4Gv1.BindGv_vViewRegion(strWhereCond);
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
        protected string CombinevViewRegionCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
            try
            {
                if (ddlCmPrjIdq.SelectedIndex > 0)
                {
                    strWhereCond += string.Format(" and {0} = '{1}'", conViewInfo.PrjId, ddlCmPrjIdq.SelectedValue);
                }
                //if (this.txtRegionNameq.Text.Trim() != "")
                //{
                //    objvViewRegionEN.RegionName = this.txtRegionNameq.Text.Trim();
                //    strWhereCond += string.Format(" And {0} like '%{1}%'", convViewRegion.RegionName, this.txtRegionNameq.Text.Trim());
                //}
                if (this.ddlRegionTypeIdq.SelectedValue != "" && this.ddlRegionTypeIdq.SelectedValue != "0")
                {
                    objvViewRegionEN.RegionTypeId = this.ddlRegionTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convViewRegion.RegionTypeId, this.ddlRegionTypeIdq.SelectedValue);
                }

                objvViewRegionEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineViewRegionCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CombineConditionObj)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected clsvViewRegionEN CombinevViewRegionConditionObj()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
            try
            {
                if (ddlCmPrjIdq.SelectedIndex > 0)
                {
                    objvViewRegionEN.SetPrjId(ddlCmPrjIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" and {0} in (Select ViewId From {1} Where CmPrjId= '{2}')", 
                        conViewInfo.ViewId,
                        conViewInfoCmPrjIdRela._CurrTabName,
                        ddlCmPrjIdq.SelectedValue);
                }
                //if (this.txtRegionNameq.Text.Trim() != "")
                //{
                //    objvViewRegionEN.SetRegionName(string.Format("{0}", this.txtRegionNameq.Text.Trim()), "like");
                //    strWhereCond += string.Format(" And {0} like '%{1}%'", convViewRegion.RegionName, this.txtRegionNameq.Text.Trim());
                //}
                if (this.ddlRegionTypeIdq.SelectedValue != "" && this.ddlRegionTypeIdq.SelectedValue != "0")
                {
                    objvViewRegionEN.SetRegionTypeId(this.ddlRegionTypeIdq.SelectedValue, "=");
                    strWhereCond += string.Format(" And {0} = '{1}'", convViewRegion.RegionTypeId, this.ddlRegionTypeIdq.SelectedValue);
                }

                objvViewRegionEN.CheckProperty4Condition();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000086)在组合查询条件(CombineViewRegionConditionObj)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return objvViewRegionEN;
        }

        /// <summary>
        /// 专门用于记录当前界面是否绑定编辑区的下拉框
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_vsIsBindDdl4Edit)
        /// </summary>
        public bool vsIsBindDdl4Edit
        {
            get
            {
                string strIsBindDdl4Edit;
                strIsBindDdl4Edit = (string)ViewState["IsBindDdl4Edit"];
                if (strIsBindDdl4Edit == null)
                {
                    return false;
                }
                return bool.Parse(strIsBindDdl4Edit);
            }
            set
            {
                string strIsBindDdl4Edit = value.ToString();
                ViewState.Add("IsBindDdl4Edit", strIsBindDdl4Edit);
            }
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


        /// <summary>
        /// 函数功能:为编辑区控件绑定下拉框。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindDropDownLst4EditRegion)
        /// </summary>
        protected void BindDdl4EditRegion()
        {

           
        }


        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        /// <summary>
        ///添加新记录的事件过程 
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnAddNewRecordWithMaxId_Click)
        /// </summary>
        protected void btnAddRelaRegion_Click(object sender, System.EventArgs e)
        {
            divRename.Visible = false;
            divAddRelaRegion.Visible = true;
            AddRelaRegion();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AddNewRecordWithMaxId)
        /// </summary>
        protected void AddRelaRegion()
        {
            string strViewId = GetViewIdFromTV();
            if (string.IsNullOrEmpty(strViewId))
            {
                clsCommonJsFunc.Alert(this, "请在树中选择一个界面！");
                return;
            }
            string strRegionId = lstViewRegion.SelectedValue;
            if (string.IsNullOrEmpty(strRegionId))
            {
                clsCommonJsFunc.Alert(this, "请在列表中选择一个界面区域！");
                return;
            }
            clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();    //初始化新对象

            objViewRegionRelaEN.RegionId = strRegionId;
            objViewRegionRelaEN.ViewId = strViewId;
            objViewRegionRelaEN.PrjId = clsPubVar.CurrSelPrjId;
            objViewRegionRelaEN.InUse = true;
            objViewRegionRelaEN.IsDisp = true;
            objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objViewRegionRelaEN.UpdUser = clsCommonSession.UserId;
            objViewRegionRelaEN.EditRecordEx();


            string strAppId = ddlApplicationTypeId.SelectedValue;
            int intAppId = int.Parse(strAppId);
            clsViewRegionBLEx.BindLst_RegionIdByViewIdEx(lstViewRegion, strViewId, intAppId, clsPubVar.CurrSelPrjId);

            BindTv_ViewFeatureRela();

            wucTreeView1.SelectNodeEx(strViewId);
            wucTreeView1.CurrNode.Expand();
            ////1、绑定编辑区的下拉框
            //BindDdl4EditRegion();
            ////2、设置关键字字段可以编辑
            //ViewRegion1.SetKeyReadOnly(false);
            ////3、改变相关编辑按钮的状态
            //btnOKUpd.Text = "确认添加";
            //btnOKUpd.CommandArgument = "AddWithMaxId";
            //btnCancelViewRegionEdit.Text = "取消添加";
            ////4、设置添加时编辑区域控件的初值
            //DispEditViewRegionRegion();
        }

   

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnUpdateRecord_Click4OneKeyword)
        /// </summary>
        protected void btnUpdateRecord_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            //string strRegionId = wucvViewRegion4Gv1.GetFirstCheckedKeyFromGv();
            //if (string.IsNullOrEmpty(strRegionId) == true) return;
            //UpdateViewRegionRecord(strRegionId);
        }
                
        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnDelRecord_Click4OneKeyword)
        /// </summary>
        protected void btnDelRecord_Click(object sender, System.EventArgs e)
        {
            string strKeyId = wucTreeView1.CurrNodeKeyId;
            string strTypeName = wucTreeView1.CurrNodeType;
            switch (strTypeName)
            {
                case conViewInfo._CurrTabName:
                    //iRegionEdit.Src = string.Format("../View/wfmGenViewCode_Edit.aspx?ViewId={0}", strKeyId);

                    break;
                case conViewRegion._CurrTabName:
                    TreeNode objViewRegion = wucTreeView1.CurrNode;
                    TreeNode objViewInfo = objViewRegion.Parent;

                    string strViewId = objViewInfo.Value.Split(",".ToCharArray())[1];
                    string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conViewRegionRela.ViewId, strViewId,
                        conViewRegionRela.RegionId, strKeyId);
                    clsViewRegionRelaBL.DelViewRegionRelasByCond(strCondition);
                    BindTv_ViewFeatureRela();
                    wucTreeView1.SelectNodeEx(strViewId);
                    wucTreeView1.CurrNode.Expand();
                    break;
            }
            //List<string> lstRegionId = wucvViewRegion4Gv1.GetAllCheckedKeysFromGv();
            //if (lstRegionId == null) return;
            //lblMsgList.Text = "";
            //try
            //{
            //    foreach (string strRegionId in lstRegionId)
            //    {
            //        clsViewRegionBL.DelRecord(strRegionId);
            //    }
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = "(errid:WebI000025)删除记录不成功!" + objException.Message;
            //    clsCommonJsFunc.Alert(this, strMsg);
            //    lblMsgList.Text = strMsg;
            //    return;
            //}
            //BindGv_vViewRegion();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvViewRegion4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strRegionId = e.KeyId;
            DeleteViewRegionRecord(strRegionId);
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "strRegionId">给定关键字</param>
        protected void DeleteViewRegionRecord(string strRegionId)
        {
            try
            {
                clsViewRegionBL.DelRecord(strRegionId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vViewRegion();
        }

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnExportExcel_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vViewRegion]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevViewRegionCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ViewRegion信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convViewRegion.RegionId); arrCnName.Add("区域Id");
            arrColName.Add(convViewRegion.RegionName); arrCnName.Add("区域名称");
            arrColName.Add(convViewRegion.RegionTypeName); arrCnName.Add("区域类型名称");
            arrColName.Add(convViewRegion.RegionTypeSimName); arrCnName.Add("区域类型简名");
            arrColName.Add(convViewRegion.RegionTypeOrderNum); arrCnName.Add("区域类型序号");
            //arrColName.Add(convViewRegion.RegionFunction); arrCnName.Add("区域功能");
            arrColName.Add(convViewRegion.ClsName); arrCnName.Add("类名");
            arrColName.Add(convViewRegion.FileName); arrCnName.Add("文件名");
            arrColName.Add(convViewRegion.Height); arrCnName.Add("高度");
            arrColName.Add(convViewRegion.Width); arrCnName.Add("宽");
            arrColName.Add(convViewRegion.ColNum); arrCnName.Add("列数");
            arrColName.Add(convViewRegion.ContainerTypeName); arrCnName.Add("容器类型名");
            arrColName.Add(convViewRegion.PageDispModeName); arrCnName.Add("页面显示模式名称");
            arrColName.Add(convViewRegion.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convViewRegion.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convViewRegion.Memo); arrCnName.Add("说明");
            arrColName.Add(convViewRegion.InOutTypeName); arrCnName.Add("INOUT类型");
            arrColName.Add(convViewRegion.TabName); arrCnName.Add("表");

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
                objDT = clsvViewRegionBL.GetDataTable(strWhereCond);
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
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DefProperty_vsCacheClassifyField)
        /// </summary>
        protected string vsPrjId_Cache
        {
            get
            {
                string sPrjId_Cache;
                sPrjId_Cache = (string)ViewState["PrjId_Cache"];
                if (sPrjId_Cache == null)
                {
                    sPrjId_Cache = "";
                }
                return sPrjId_Cache;
            }
            set
            {
                string sPrjId_Cache = value;
                ViewState.Add("PrjId_Cache", sPrjId_Cache);
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


        /// <summary>
        /// 用户权限管理:处理当前用户在当前界面的权限相关操作
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_AccessUserPotence)
        /// </summary>
        protected bool AccessUserPotence()
        {
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
            return true;
        }


        #region 备用函数

        #endregion 备用函数

        protected void btnSetTabId_Click(object sender, EventArgs e)
        {
            try
            {
                int intCount = clsViewRegionBLEx.SetDataTabId();
                string strMsg = string.Format("共转换了:{0}条记录！", intCount);
                clsCommonJsFunc.Alert(this, strMsg);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void btnSetDefaRegionName_Click(object sender, EventArgs e)
        {
            try
            {
                int intCount = clsViewRegionBLEx.SetDefaRegionName();
                string strMsg = string.Format("共转换了:{0}条记录！", intCount);
                clsCommonJsFunc.Alert(this, strMsg);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }
        private void BindTv_ViewFeatureRela()
        {
            //clsCommonSession.ViewId = "00050304";
            // wucTreeView1.tmTreeModel = TreeModel.ViewInfo_PrjFeature_Function4Code;
            if (ddlCmPrjIdq.SelectedIndex < 0)
            {
                return;
            }
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;

            wucTreeView1.tmTreeModel = TreeModel.FuncModule_Agc_ViewInfo_ViewRegion;
            wucTreeView1.CmPrjId = strCmPrjId;// clsCommonSession.ViewId;
            wucTreeView1.PrjId = clsPubVar.CurrSelPrjId;// clsCommonSession.ViewId;

            wucTreeView1.ApplicationTypeId = vsApplicationTypeId;// clsCommonSession.ViewId;
            if (ddlRegionTypeIdq.SelectedIndex > 0)
            {
                wucTreeView1.RegionTypeId = ddlRegionTypeIdq.SelectedValue;// clsCommonSession.ViewId;
            }
            wucTreeView1.BindTv();
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            //wucTreeView1.ExpandLevel1();
            wucTreeView1.CollapseAll();
            wucTreeView1.Expand(1);
            if (wucTreeView1.Nodes.Count > 0)
            {
                var tnFirstModule = wucTreeView1.Nodes[0];
                if (tnFirstModule.ChildNodes.Count > 0)
                {
                    var tnFirstView = tnFirstModule.ChildNodes[0];
                    tnFirstView.Expand();
                }
            }
            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

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

        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView1.CollapseAll();
            //wucTreeView1.SelectNodeEx(strKeyId);
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView1.GetCurrPathNodeKeyIdLst();
            wucTreeView1.SelectNodeEx(arrCurrPathNodeKeyIdLst);


            //string strFeatureId = wucTreeView1.NodeData.FeatureId;//
            //string strHtml = string.Format("~/Webform/PrjFunction/wfmFeatureFuncRelaB_QUDI.aspx?FeatureId={0}&ParentPage=../View/wfmViewFeatureRelaB_InMasterPage.aspx",
            //    strFeatureId);
            //Response.Redirect(strHtml);
            switch (strTypeName)
            {
                case conViewInfo._CurrTabName:
                    iRegionEdit.Src = string.Format("../View/wfmGenViewCode_Edit.aspx?ViewId={0}", strKeyId);

                    break;
                case conViewRegion._CurrTabName:

                    var objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(strKeyId, clsPubVar.CurrSelPrjId);
                    if (objViewRegion.FldCount() == 0)
                    {
                        iRegionEdit.Src = "";
                        clsCommonJsFunc.Alert(this, "所选界面区域没有相关字段！");
                        return;
                    }
                    switch (objViewRegion.RegionTypeId)
                    {
                        case enumRegionType.EditRegion_0003:
                            iRegionEdit.Src = string.Format("../RegionManage/wfmEditRegionFlds_Edit.aspx?RegionId={0}", strKeyId);
                            break;
                        case enumRegionType.QueryRegion_0001:
                            iRegionEdit.Src = string.Format("../RegionManage/wfmQryRegionFlds_Edit.aspx?RegionId={0}", strKeyId);
                            break;
                        case enumRegionType.DetailRegion_0006:
                            iRegionEdit.Src = string.Format("../RegionManage/wfmDetailRegionFlds_Edit.aspx?RegionId={0}", strKeyId);
                            break;
                        case enumRegionType.FeatureRegion_0008:
                            iRegionEdit.Src = string.Format("../RegionManage/wfmFeatureRegionFldsB_Edit.aspx?RegionId={0}", strKeyId);
                            break;
                        case enumRegionType.ExcelExportRegion_0007:
                            iRegionEdit.Src = string.Format("../RegionManage/wfmExcelExportRegionFlds_Edit.aspx?RegionId={0}", strKeyId);
                            break;
                        case enumRegionType.ListRegion_0002:
                            iRegionEdit.Src = string.Format("../RegionManage/wfmDGRegionFlds_Edit.aspx?RegionId={0}", strKeyId);
                            break;

                    }
                    break;

            }
            //   btnGetCurrNodeRelaValue_Click(null, null);
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
        protected int vsApplicationTypeId
        {
            get
            {
                string sApplicationTypeId;
                sApplicationTypeId = (string)ViewState["ApplicationTypeId"];
                if (sApplicationTypeId == null)
                {
                    return 0;
                }
                return int.Parse(sApplicationTypeId);
            }
            set
            {
                string sApplicationTypeId = value.ToString();
                ViewState.Add("ApplicationTypeId", sApplicationTypeId);
            }
        }

        protected void ddlApplicationTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlApplicationTypeId.SelectedIndex <= 0) return;
            vsApplicationTypeId = int.Parse(ddlApplicationTypeId.SelectedValue.ToString());
            BindTv_ViewFeatureRela();
        }

        private string GetViewIdFromTV()
        {
            string strViewId = "";
            string strKeyId = wucTreeView1.CurrNodeKeyId;
            string strTypeName = wucTreeView1.CurrNodeType;
            switch (strTypeName)
            {
                case conViewInfo._CurrTabName:
                    strViewId = strKeyId;
                    //iRegionEdit.Src = string.Format("../View/wfmGenViewCode_Edit.aspx?ViewId={0}", strKeyId);


                    break;
                case conViewRegion._CurrTabName:
                    TreeNode objViewRegion = wucTreeView1.CurrNode;
                    TreeNode objViewInfo = objViewRegion.Parent;

                    strViewId = objViewInfo.Value.Split(",".ToCharArray())[1];

                    break;
            }
            return strViewId;
        }
        protected void btnAddRegion_Click(object sender, EventArgs e)
        {
            divAddNewRegion.Visible = false;
            divRename.Visible = false;
            //string strCondition = "";
            string strViewId = GetViewIdFromTV();
            //List<string> arrRelaTabId = null;
            string strAppId = ddlApplicationTypeId.SelectedValue;
            int intAppId = int.Parse(strAppId);

            if (string.IsNullOrEmpty(strViewId)==true)
            {
                clsCommonJsFunc.Alert(this, "请在树中选择一个界面！");
                return;
            }
            divAddRelaRegion.Visible = true;
            if (clsViewRegionBLEx.BindLst_RegionIdByViewIdEx(lstViewRegion, strViewId, intAppId, clsPubVar.CurrSelPrjId) == false)
            {
                lstViewRegion.Visible = false;
                btnAddRelaRegion.Visible = false;
                clsCommonJsFunc.Alert(this, "该界面没有其他的相关区域，可以选择添加新区域！");
            }
            else
            {
                lstViewRegion.Visible = true;
                btnAddRelaRegion.Visible = true;
                btnAddRelaRegion.Text = "确认添加";

            }
        }
        protected void btnStartGene_Click(object sender, System.EventArgs e)
        {
            string strViewId = GetViewIdFromTV();

            if (string.IsNullOrEmpty(strViewId))
            {
                clsCommonJsFunc.Alert(this, "请在树中选择一个界面！");
                return;
            }
            StringBuilder sbWhereCond = new StringBuilder();
            //如果选择查询区域
            try
            {
                try
                {
                    clsViewReferFilesBLEx.CopyFromTempplate(strViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                }
                catch (Exception objException2)
                {
                    string strMsg = string.Format("复制模板记录出错,请联系管理员！错误:{0}.({1})",
                    objException2.Message, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                if (chkCopyReferFilesTemplate.Checked == true)
                {
                    clsViewReferFilesBLEx.CopyFromTempplate(strViewId, clsPubVar.CurrSelPrjId, //视图ID(ViewId)
                        clsCommonSession.UserId);              //用户Id
                }

                if (chkQueryRegion.Checked == true)
                {
                    ///添加区域及区域字段，该函数是ViewInfo的相关函数，
                    ///有三个参数：1、视图ID(ViewId)
                    ///				2、区域类型()
                    ///				3、数据源类型ID
                    ///				4、数据源表ID()
                    ///		
                    clsViewInfoBLEx.ImportRegionAndFlds1(strViewId, //视图ID(ViewId)
                        clsRegionTypeENEx.QUERYREGION,              //区域类型                        
                        clsCommonSession.UserId               //区域名称
                        );
                }
                //如果选择列表区域
                if (chkDGRegion.Checked == true)
                {
                    clsViewInfoBLEx.ImportRegionAndFlds1(strViewId, //视图ID(ViewId)
                        clsRegionTypeENEx.DGREGION,             //区域类型
                        clsCommonSession.UserId                  //区域名称
                        );
                }
                ////如果选择ListView区域
                //if (chkListViewRegion.Checked == true && txtFileName_ListViewRegion.Text.Trim() != "")
                //{
                //    clsViewInfoBLEx.ImportRegionAndFlds(strViewId, //视图ID(ViewId)
                //        clsRegionTypeENEx.LISTVIEWREGION,               //区域类型
                //        txtFileName_ListViewRegion.Text.Trim()                              //区域名称
                //        );
                //}
                //如果选择编辑区域
                if (chkEditRegion.Checked == true)
                {
                    clsViewInfoBLEx.ImportRegionAndFlds1(strViewId, //视图ID(ViewId)
                        clsRegionTypeENEx.EDITREGION,               //区域类型
                        clsCommonSession.UserId      //区域名称
                        );
                }
                //如果选择Excel导出区域
                if (chkExcelExportRegion.Checked == true)
                {
                    clsViewInfoBLEx.ImportRegionAndFlds1(strViewId, //视图ID(ViewId)
                        clsRegionTypeENEx.EXCELEXPORT_REGION,               //区域类型
                        clsCommonSession.UserId                      //区域名称
                        );
                }

                //如果选择功能区域
                if (chkFeatureRegion.Checked == true)
                {
                    clsViewInfoBLEx.ImportRegionAndFlds1(strViewId, //视图ID(ViewId)
                        clsRegionTypeENEx.FEATUREREGION,               //功能区域
                        clsCommonSession.UserId                         //区域名称
                        );
                }
                //如果选择详细信息区域
                if (chkDetailRegion.Checked == true)
                {
                    clsViewInfoBLEx.ImportRegionAndFlds1(strViewId, //视图ID(ViewId)
                        clsRegionTypeENEx.DETAILREGION,                //区域类型
                        clsCommonSession.UserId, ""       //区域名称
                        );
                }
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsViewRegionBLEx.SetClassName4ViewInfo(clsCommonSession.ViewId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在设置ViewId:[{0}]的类名时出错，{1}. (In {2})",
                    clsCommonSession.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar.objLog.WriteDebugLog(strMsg);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate(strViewId);

            BindTv_ViewFeatureRela();
            divAddNewRegion.Visible = false;
        }

        protected void btnAddNewRegion_Click(object sender, EventArgs e)
        {
            string strViewId = GetViewIdFromTV();

            if (string.IsNullOrEmpty(strViewId))
            {
                clsCommonJsFunc.Alert(this, "请在树中选择一个界面！");
                return;
            }
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBLEx.GetObjLstByViewId(strViewId);
            chkDetailRegion.Visible = true;
            chkEditRegion.Visible = true;
            chkExcelExportRegion.Visible = true;
            chkFeatureRegion.Visible = true;
            chkDGRegion.Visible = true;
            chkQueryRegion.Visible = true;
            chkTreeViewRegion.Visible = true;

            chkDetailRegion.Checked = false;
            chkEditRegion.Checked = false;
            chkExcelExportRegion.Checked = false;
            chkFeatureRegion.Checked = false;
            chkDGRegion.Checked = false;
            chkQueryRegion.Checked = false;
            chkTreeViewRegion.Checked = false;

            foreach (clsViewRegionEN objViewRegion in arrViewRegion)
            {
                switch (objViewRegion.RegionTypeId)
                {
                    case enumRegionType.DetailRegion_0006:
                        chkDetailRegion.Visible = false;
                        break;
                    case enumRegionType.EditRegion_0003:
                        chkEditRegion.Visible = false;
                        break;
                    case enumRegionType.ExcelExportRegion_0007:
                        chkExcelExportRegion.Visible = false;
                        break;
                    case enumRegionType.FeatureRegion_0008:
                        chkFeatureRegion.Visible = false;
                        break;
                    case enumRegionType.ListRegion_0002:
                        chkDGRegion.Visible = false;
                        break;
                    case enumRegionType.QueryRegion_0001:
                        chkQueryRegion.Visible = false;
                        break;
                    case enumRegionType.TreeViewRegion_0005:
                        chkTreeViewRegion.Visible = false;
                        break;

                }
            }
            divAddRelaRegion.Visible = false;
            divAddNewRegion.Visible = true;
        }

        protected void btnCloseDiv_Click(object sender, EventArgs e)
        {
            divAddNewRegion.Visible = false;
        }

        protected void btnCloseDiv4RelaRegion_Click(object sender, EventArgs e)
        {
            divAddRelaRegion.Visible = false;
        }

        protected void btnRename_Click(object sender, EventArgs e)
        {
            string strKeyId = wucTreeView1.CurrNodeKeyId;
            string strTypeName = wucTreeView1.CurrNodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);

            //string strHtml = string.Format("~/Webform/PrjFunction/wfmFeatureFuncRelaB_QUDI.aspx?FeatureId={0}&ParentPage=../View/wfmViewFeatureRelaB_InMasterPage.aspx",
            //    strFeatureId);
            //Response.Redirect(strHtml);
            if (strTypeName != conViewRegion._CurrTabName) return;

            var objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(strKeyId, clsPubVar.CurrSelPrjId);
            txtNewRegionName.Text = objViewRegion.RegionName;

            divAddNewRegion.Visible = false;
            divAddRelaRegion.Visible = false;
            divRename.Visible = true;
        }

        protected void btnConfirmRename_Click(object sender, EventArgs e)
        {
            string strKeyId = wucTreeView1.CurrNodeKeyId;
            string strTypeName = wucTreeView1.CurrNodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);

            //string strHtml = string.Format("~/Webform/PrjFunction/wfmFeatureFuncRelaB_QUDI.aspx?FeatureId={0}&ParentPage=../View/wfmViewFeatureRelaB_InMasterPage.aspx",
            //    strFeatureId);
            //Response.Redirect(strHtml);
            if (strTypeName != conViewRegion._CurrTabName) return;

            var objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(strKeyId, clsPubVar.CurrSelPrjId);
            var strNewRegionName = txtNewRegionName.Text;
            objViewRegion.RegionName = strNewRegionName;
            objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objViewRegion.UpdUser = clsCommonSession.UserId;

            objViewRegion.UpdateRecordEx();
            //clsViewRegionBLEx.SetFldCount(objViewRegion);
            //clsViewRegionBLEx.SetFldCountInUse(objViewRegion);

            BindTv_ViewFeatureRela();
            wucTreeView1.SelectNodeEx(objViewRegion.RegionId);
            divRename.Visible = false;

        }

        protected void btnCloseDiv4Rename_Click(object sender, EventArgs e)
        {
            divRename.Visible = false;
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

        protected void ddlCmPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            BindTv_ViewFeatureRela();
        }
    }
}