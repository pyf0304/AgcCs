///生成查询，修改，删除，添加记录的控制层代码


using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Agc;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using CommFunc4WebForm;


namespace AGC.Webform
{
    /// <summary>
    /// wfmDGRegionFlds_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmDGRegionFlds_Edit : CommWebPageBase
    {



        //生成有关的变量定义代码
        private const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            vsIsDisp = false;
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (strPotenceLevel)
                {
                    case "0":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "1":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "2":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "3":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "4":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "9":
                        break;
                    default:
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                }
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(getRegionId, clsPubVar.CurrSelPrjId);


                //1、为下拉框设置数据源，绑定列表数据
                wucDGRegionFlds1.SetDdl_CtlTypeId(false);
                wucDGRegionFlds1.SetDdl_DgFuncTypeId();
                wucDGRegionFlds1.SetDdl_FldId(objvViewRegion.TabId);
                wucDGRegionFlds1.vsTabId = objvViewRegion.TabId;
                wucDGRegionFlds1.SetDdl_DataNodeIdByTabId(objvViewRegion.TabId, objvViewRegion.PrjId);

                strSortDGRegionFldsBy = "SeqNum Asc";
               
                vsInOutTypeId = objvViewRegion.InOutTypeId;
                
                txtWidth.Text = objvViewRegion.Width.ToString();
                if (string.IsNullOrEmpty(objvViewRegion.ClsName) == true)
                {
                    clsViewRegionBLEx.SetClassName(getRegionId,0);
                    objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(getRegionId, clsPubVar.CurrSelPrjId);
                }
                txtClassName.Text = objvViewRegion.ClsName;
                txtFileName.Text = objvViewRegion.FileName;
                vsApplicationTypeId = objvViewRegion.ApplicationTypeId ?? 0;
                //2、显示无条件的表内容在DATAGRID中
                BindGv_vDGRegionFlds();
                
                //tabEditDGRegionFldsRegion.Visible = false;
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
            }
            ShowCodeTypeButton();
            if (vsIsDisp == false)
            {
                try
                {
                    wucListRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5, true, clsPubVar.CurrCmPrjId);
                    //	3、设置Gv控件的某些列不可见；

                    //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
                }
                catch (Exception objException)
                {
                    string strMsg = "(errid:WebI000119)可视化显示功能区出错!" + objException.Message;
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }
        }
        private string BackErrPageLinkStr
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
        private string ErrMessage
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

        //生成权限等级的属性
        private string strPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }



        private string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                    clsCommForWebForm.CheckUserId(strUserId, this);
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }
        ///private clsUsersEN objUserBak
        ///{
        ///get
        ///{
        ///clsUsersEN pobjUser;
        ///pobjUser = (clsUsersEN)Session["objUser"];
        ///if (pobjUser==null) 
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
        private string BackViewRegionLinkStr
        {
            get
            {
                string strBackViewRegionLinkStr;
                strBackViewRegionLinkStr = (string)Session["BackViewRegionLinkStr"];
                if (strBackViewRegionLinkStr == null)
                {
                    strBackViewRegionLinkStr = "";
                }
                return strBackViewRegionLinkStr;
            }
            set
            {
                string strBackViewRegionLinkStr = value;
                Session.Add("BackViewRegionLinkStr", strBackViewRegionLinkStr);
            }
        }



        private string SimpleFName
        {
            get
            {
                string strSimpleFName;
                strSimpleFName = (string)ViewState["SimpleFName"];
                if (strSimpleFName == null)
                {
                    strSimpleFName = "";
                }
                return strSimpleFName;
            }
            set
            {
                string strSimpleFName = value;
                ViewState.Add("SimpleFName", strSimpleFName);
            }
        }




        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombinevDGRegionFldsCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            strWhereCond += " And RegionId='" + getRegionId + "'";
            if (chkOnlyShowFldInUse.Checked == true)
            {
                strWhereCond += string.Format(" And {0}='1'", conDGRegionFlds.InUse);
            }

            return strWhereCond;
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vDGRegionFlds()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.HeaderText, false);
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.InUse, false);
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.DgFuncTypeName, false);
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.IsFuncFld, false);
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.IsVisible, false);
                //	1、组合界面条件串；
                string strWhereCond = CombinevDGRegionFldsCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvDGRegionFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convDGRegionFlds.InUse));
                wucvDGRegionFlds4Gv1.SetSortBy(string.Format("{0}", convDGRegionFlds.SeqNum));
                wucvDGRegionFlds4Gv1.BindGv_DGRegionFlds(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
           
                wucvDGRegionFlds4Gv1.SetGvVisibility("修改", false);
                wucvDGRegionFlds4Gv1.SetGvVisibility("删除", false);
                //wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                wucListRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5,true, clsPubVar.CurrCmPrjId);
                vsIsDisp = true;
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000119)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }


        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_DGRegionFldsBak()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //	4、设置DATAGRID的数据源(DataSource)；
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombinevDGRegionFldsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvDGRegionFldsBL.GetDataTable(strWhereCond + " order by SeqNum");

            if (vsInOutTypeId == "02")//视图
            {
                clsDGRegionFldsBLEx.AddColumn_SourceTabName(ref objDT);
            }
            else
            {
                objDT.Columns.Add("SourceTabName");
            }

            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //		3.1 首先计算页数；
            //		3.2 如果当前页大于页数就为最后一页
            //int intPages = CalcPages(objDT.Rows.Count, this.dgDGRegionFlds.PageSize);
            //if (intPages == 0)
            //{
            //    this.dgDGRegionFlds.CurrentPageIndex = 0;
            //}
            //else if (this.dgDGRegionFlds.CurrentPageIndex > intPages - 1)
            //{
            //    this.dgDGRegionFlds.CurrentPageIndex = intPages - 1;
            //}
            ////	4、设置DATAGRID的数据源(DataSource)；
            //DataView objDV = objDT.DefaultView;
            //objDV.Sort = strSortDGRegionFldsBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            //this.dgDGRegionFlds.DataSource = objDV;
            ////	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //this.dgDGRegionFlds.DataBind();


            ////当前记录数
            //this.lblDGRegionFldsRecCount.Text = objDT.Rows.Count.ToString();
            ////当前页数
            //this.lblDGRegionFldsAllPages.Text = this.dgDGRegionFlds.PageCount.ToString();
            ////当前页序数
            //this.lblDGRegionFldsCurrentPage.Text = (this.dgDGRegionFlds.CurrentPageIndex + 1).ToString();
            ////当前即将跳到的页序数
            //this.txtDGRegionFldsJump2Page.Text = (this.dgDGRegionFlds.CurrentPageIndex + 1).ToString();
            ////如果当前页序数为0，则<前一页>按钮无效
            //if (this.dgDGRegionFlds.CurrentPageIndex == 0)
            //{
            //    clsPubFun.SetButtonEnabled(btnDGRegionFldsPrevPage, false);
            //}
            //else
            //{
            //    clsPubFun.SetButtonEnabled(btnDGRegionFldsPrevPage, true);
            //}
            ////如果当前页序数已为最后一页，则<前一页>按钮无效
            //if (this.dgDGRegionFlds.CurrentPageIndex == this.dgDGRegionFlds.PageCount - 1)
            //{
            //    clsPubFun.SetButtonEnabled(btnDGRegionFldsNextPage, false);
            //}
            //else
            //{
            //    clsPubFun.SetButtonEnabled(btnDGRegionFldsNextPage, true);
            //}
            ////7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
            //if (objDT.Rows.Count > 0)
            //{
            //    this.tabDGRegionFldsJumpPage.Visible = true;
            //}
            //else
            //{
            //    this.tabDGRegionFldsJumpPage.Visible = false;
            //}
        }

        /// <summary>
        /// 功能：计算DataGrid的页数
        /// </summary>
        /// <param name="intRecCount">总共的记录数</param>
        /// <param name="intPageSize">每页的记录数</param>
        /// <returns>计算出来的页数</returns>
        private int CalcPages(int intRecCount, int intPageSize)
        {
            int intPages;
            intPages = intRecCount / intPageSize;
            if (intRecCount % intPageSize != 0) intPages++;
            return intPages;
        }

        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把DATAGRID的当前页索引设置为0，即第1页。
            //当单击查询时，首先显示的是表记录内容的第一部分内容。
            wucvDGRegionFlds4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vDGRegionFlds();
        }

        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(long lngmId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngmId == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsDGRegionFldsBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + lngmId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsBL.GetObjBymId(lngmId);
            //4、获取类对象的所有属性；
            //clsDGRegionFldsBL.GetDGRegionFlds();
            Session.Add("objDGRegionFlds", objDGRegionFldsEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromDGRegionFldsClass(objDGRegionFldsEN);
            //DispEditDGRegionFldsRegion();
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjDGRegionFlds">表实体类对象</param>
        private void GetDataFromDGRegionFldsClass(clsDGRegionFldsEN pobjDGRegionFlds)
        {

      
            wucDGRegionFlds1.FldId = pobjDGRegionFlds.FldId;
            //if (string.IsNullOrEmpty(pobjDGRegionFlds.OutDataNodeId) == false)
            //{
            //    wucDGRegionFlds1.SetDdl_DataNodeId(pobjDGRegionFlds.FldId);
            try
            {
                var objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(pobjDGRegionFlds.RegionId, clsPubVar.CurrSelPrjId);
                wucDGRegionFlds1.vsCmPrjId = objViewRegion.PrjId;
                //wucDGRegionFlds1.DataNodeId = pobjDGRegionFlds.OutDataNodeId;
            }
            catch(Exception objException)
            {

                clsPubVar.objLog.WriteDebugLog(objException.Message);
                //string ss = "";
            }
            //wucDGRegionFlds1.DataPropertyName = pobjDGRegionFlds.DataPropertyName;
            wucDGRegionFlds1.SortExpression = pobjDGRegionFlds.SortExpression;

            //}
            //clsvDGRegionFldsEN objvDGRegionFlds = clsvDGRegionFldsBL.GetFirstObj_S("RegionId = '" + getRegionId + "' and TabFldId = " + pobjDGRegionFlds.TabFldId);
            //wucDGRegionFlds1.FldName = objvDGRegionFlds.FldName;

            wucDGRegionFlds1.CtlTypeId = pobjDGRegionFlds.CtlTypeId;
            wucDGRegionFlds1.ColCaption = pobjDGRegionFlds.HeaderText;
            wucDGRegionFlds1.IsNeedSort = pobjDGRegionFlds.IsNeedSort;
            wucDGRegionFlds1.IsTransToChkBox = pobjDGRegionFlds.IsTransToChkBox;
            wucDGRegionFlds1.IsVisible = pobjDGRegionFlds.IsVisible;
            wucDGRegionFlds1.IsFuncFld = pobjDGRegionFlds.IsFuncFld;
            wucDGRegionFlds1.DgFuncTypeId = pobjDGRegionFlds.DgFuncTypeId;
            wucDGRegionFlds1.SeqNum = pobjDGRegionFlds.SeqNum;
            wucDGRegionFlds1.Memo = pobjDGRegionFlds.Memo;
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            string strCommandText;
            clsDGRegionFldsEN objDGRegionFldsEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    btnOKUpd.Text = "确认添加";
                    wucDGRegionFlds1.SeqNum = 1;
                    wucDGRegionFlds1.CtlTypeId = enumCtlType.Label_10;
                    wucDGRegionFlds1.DgFuncTypeId = enumDgFuncType.Unknown_0000;
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    //操作步骤：
                    //1、检查控件中输入数据类型是否正确
                    //2、定义对象并初始化对象
                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    //4、把值从界面层传到逻辑层或数据实体层
                    //5、检查传进去的对象属性是否合法
                    //6、把数据实体层的数据存贮到数据库中
                    //7、把新添的记录内容显示在DATAGRID中
                    //1、检查控件中输入数据类型是否正确
                    if (!wucDGRegionFlds1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、定义对象并初始化对象
                    //clsDGRegionFldsEN objDGRegionFldsEN;	//定义对象
                    objDGRegionFldsEN = new clsDGRegionFldsEN();	//初始化新对象
                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    //4、把值从界面层传到逻辑层或数据实体层
                    PutDataToDGRegionFldsClass(objDGRegionFldsEN);		//把界面的值传到
                    //5、检查传进去的对象属性是否合法
                    try
                    {
                        clsDGRegionFldsBL.CheckPropertyNew(objDGRegionFldsEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6、把数据实体层的数据存贮到数据库中
                    if (clsDGRegionFldsBL.AddNewRecordBySql2(objDGRegionFldsEN) == false)
                    {
                        strMsg = "添加不成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "添加记录不成功!";
                    }
                    else
                    {
                        //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        strMsg = "添加记录成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "添加记录成功!";
                    }
                    //7、把新添的记录内容显示在DATAGRID中
                    BindGv_vDGRegionFlds();
                    wucDGRegionFlds1.Clear();		//清空控件中内容
                    ///恢复<确认添加>变成<添加>
                    btnOKUpd.Text = "添加";
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    //操作步骤：
                    //1、检查控件中输入数据类型是否正确
                    //2、把值从界面层传到逻辑层或数据实体层
                    //3、检查传进去的对象属性是否合法
                    //4、把数据实体层的数据存贮到数据库中
                    //5、把修改后的内容显示在DATAGRID中
                    //1、检查控件中输入数据类型是否正确
                    if (!wucDGRegionFlds1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、把值从界面层传到逻辑层或数据实体层
                    objDGRegionFldsEN = (clsDGRegionFldsEN)Session["objDGRegionFlds"];
                    PutDataToDGRegionFldsClass(objDGRegionFldsEN);		//把界面的值传到
                    //3、检查传进去的对象属性是否合法
                    try
                    {
                        clsDGRegionFldsBL.CheckPropertyNew(objDGRegionFldsEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //4、把数据实体层的数据修改同步到数据库中
                    if (clsDGRegionFldsBL.UpdateBySql2(objDGRegionFldsEN) == false)
                    {
                        strMsg = "修改记录不成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "修改记录不成功!";
                    }
                    else
                    {
                        //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        strMsg = "修改记录成功!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "修改记录成功!";
                    }
                    //5、把修改后的内容显示在DATAGRID中
                    BindGv_vDGRegionFlds();
                    wucDGRegionFlds1.Clear();//添空控件中的内容
                    //恢复<确认修改>变成<添加>
                    btnOKUpd.Text = "添加";
                    DispDGRegionFldsInfo();
                    break;
            }
        }

        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjDGRegionFlds">数据传输的目的类对象</param>
        private void PutDataToDGRegionFldsClass(clsDGRegionFldsEN pobjDGRegionFlds)
        {
            pobjDGRegionFlds.FldId = wucDGRegionFlds1.FldId;
            //pobjDGRegionFlds.OutDataNodeId = wucDGRegionFlds1.DataNodeId;

            //if (string.IsNullOrEmpty(pobjDGRegionFlds.OutDataNodeId) == false)
            //{
            //    pobjDGRegionFlds.IsUseFunc = true;
            //}
            //else
            //{
            //    pobjDGRegionFlds.IsUseFunc = false;
            //}
            //pobjDGRegionFlds.DataPropertyName = wucDGRegionFlds1.DataPropertyName;
            pobjDGRegionFlds.SortExpression = wucDGRegionFlds1.SortExpression;
            if (string.IsNullOrEmpty(pobjDGRegionFlds.SortExpression) == true)
            {
                //if (string.IsNullOrEmpty(pobjDGRegionFlds.DataPropertyName) == false)
                //{
                //    pobjDGRegionFlds.SortExpression = pobjDGRegionFlds.DataPropertyName;
                //}
                //else
                //{
                //    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(pobjDGRegionFlds.FldId, pobjDGRegionFlds.PrjId);
                //    if (objFieldTab != null)
                //    {
                //        pobjDGRegionFlds.SortExpression = objFieldTab.FldName;
                //    }
                //}
            }
            pobjDGRegionFlds.CtlTypeId = wucDGRegionFlds1.CtlTypeId;
            pobjDGRegionFlds.HeaderText = wucDGRegionFlds1.ColCaption;
            pobjDGRegionFlds.IsNeedSort = wucDGRegionFlds1.IsNeedSort;
            pobjDGRegionFlds.IsTransToChkBox = wucDGRegionFlds1.IsTransToChkBox;
            pobjDGRegionFlds.IsVisible = wucDGRegionFlds1.IsVisible;
            pobjDGRegionFlds.IsFuncFld = wucDGRegionFlds1.IsFuncFld;
            pobjDGRegionFlds.DgFuncTypeId = wucDGRegionFlds1.DgFuncTypeId;
            pobjDGRegionFlds.SeqNum = wucDGRegionFlds1.SeqNum;
            pobjDGRegionFlds.InUse = true;
            pobjDGRegionFlds.UpdUser = UserId;
            pobjDGRegionFlds.UpdDate = clsDateTime.getTodayStr(0);
            pobjDGRegionFlds.Memo = wucDGRegionFlds1.Memo;
            pobjDGRegionFlds.RegionId = qsRegionId;
            pobjDGRegionFlds.PrjId = clsPubVar.CurrCmPrjId;


        }


        private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
        {
            if (objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }
            }
        }

        //当前记录数
        protected void btnAddNewRec4Dg_Click(object sender, System.EventArgs e)
        {
            DispPrjTabFldsInfo();
            
            //			btnOKUpd.Text = "确认添加";

        }


        //当前记录数
        protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevDGRegionFldsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "DGRegionFlds信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("mId"); arrCnName.Add("mId");
            arrColName.Add("RegionId"); arrCnName.Add("区域Id");
            arrColName.Add("TabFldId"); arrCnName.Add("表字段ID");
            arrColName.Add("CtlTypeId"); arrCnName.Add("控件类型号");
            arrColName.Add("ColCaption"); arrCnName.Add("列标题");
            arrColName.Add("IsNeedSort"); arrCnName.Add("是否需要排序");
            arrColName.Add("IsTransToChkBox"); arrCnName.Add("是否转换成CheckBox");
            arrColName.Add("IsVisible"); arrCnName.Add("是否显示");
            arrColName.Add("IsFuncFld"); arrCnName.Add("是否功能字段");
            arrColName.Add("DgFuncTypeId"); arrCnName.Add("Dg功能类型Id");
            arrColName.Add("SeqNum"); arrCnName.Add("列序号");
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            strFolderName = Server.MapPath("~") + "\\TempFiles\\";
            strDownLoadFileName = strFolderName + strFileName;
            try
            {
                objDT = clsDGRegionFldsBL.GetDataTable_DGRegionFlds(strWhereCond);

                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            DownLoadFile(strDownLoadFileName);
        }
        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }


        //当前记录数
        protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
        {
            List<long> lstMId = wucvDGRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            //lblMsgList.Text = "";
            lblMsg1.Text = "";
            foreach (long lngmId in lstMId)
            {
                clsDGRegionFldsBLEx.DelRecordEx(lngmId, clsPubVar.CurrSelPrjId);
            }
            //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            clsDGRegionFldsBLEx.ReOrder(getRegionId);
            //clsViewRegionBLEx.SetFldCount(getRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

            BindGv_vDGRegionFlds();
        }


        //当前记录数
        protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
        {

            long lngmId = 0;
            try
            {
                if (string.IsNullOrEmpty(hidCtrlId.Value) == false)
                {

                    lblMsg1.Text = "";
                    //1、显示该关键字记录的内容在界面上；

                    ShowData(hidCtrlId.Value);
                    //2、清空提示信息的内容,同时使<确定修改>按钮可用；
                    clsPubFun.SetButtonEnabled(btnOKUpd, true);
                    btnOKUpd.Text = "确认修改";
                    return;
                }
            }
            catch(Exception objException)
            {

                clsPubVar.objLog.WriteDebugLog(objException.Message);

                lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
                if (lngmId == 0) return;
                UpdateDGRegionFldsRecord(lngmId);
                return;
            }
            lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            UpdateDGRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateDGRegionFldsRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            //btnCancelDGRegionFldsEdit.Text = "取消修改";
            lblMsg1.Text = "";
            //DispEditDGRegionFldsRegion();
        }

        public System.Data.DataTable GetDgFuncTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DgFuncTypeId, DgFuncTypeName from DgFuncType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_DgFuncTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDgFuncTypeId();
            objDDL.DataValueField = "DgFuncTypeId";
            objDDL.DataTextField = "DgFuncTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUserId();
            objDDL.DataValueField = "UserId";
            objDDL.DataTextField = "UserName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        private string strSortDGRegionFldsBy
        {
            get
            {
                string sSortDGRegionFldsBy;
                sSortDGRegionFldsBy = (string)ViewState["SortDGRegionFldsBy"];
                if (sSortDGRegionFldsBy == null)
                {
                    sSortDGRegionFldsBy = "";
                }
                return sSortDGRegionFldsBy;
            }
            set
            {
                string sSortDGRegionFldsBy = value;
                ViewState.Add("SortDGRegionFldsBy", sSortDGRegionFldsBy);
            }
        }


        protected void btnCopyFldFromRelaTab_Click(object sender, System.EventArgs e)
        {
            //操作步骤：
            //1、获取当前区域ID的相关主表ID；
            //2、获取相关主表ID的字段ID的对象列表;
            //2、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中


            clsDGRegionFldsBLEx.ImportRelaFlds(getRegionId, clsPubVar.CurrCmPrjId, UserId);
            //clsViewRegionBLEx.SetFldCount(getRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

            //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vDGRegionFlds();
            ///恢复<确认添加>变成<添加>
            //		lbDispFldList_Click(new object(), new System.EventArgs());
            Response.Write("<script>alert('与界面相关的主表字段信息复制成功！！')</script>");
        }

     
        protected void LinkButton1_Click(object sender, System.EventArgs e)
        {
            DispDGRegionFldsInfo();
        }

      
        protected void btnGoBack_Click(object sender, System.EventArgs e)
        {
            Response.Redirect(BackViewRegionLinkStr);
        }

      
        private void DispDGRegionFldsInfo()
        {
            tabDGRegionFldsDataGrid.Visible = true;
            //tabDGRegionFldsJumpPage.Visible = true;
            //tabEditDGRegionFldsRegion.Visible = false;
      

            //tabCode.Visible = true;
        }
        private void DispPrjTabFldsInfo()
        {
            
            //tabEditDGRegionFldsRegion.Visible = false;
            tabDGRegionFldsDataGrid.Visible = false;
            //tabDGRegionFldsJumpPage.Visible = false;
            //tabCode.Visible = false;
        }
        private void DispEditDGRegionFldsRegionBak()
        {
            tabDGRegionFldsDataGrid.Visible = false;
            //tabDGRegionFldsJumpPage.Visible = false;
            //tabEditDGRegionFldsRegion.Visible = true;
            
        }


        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vDGRegionFlds();
            wucvDGRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vDGRegionFlds();
            wucvDGRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsDGRegionFldsBLEx.ReOrder(getRegionId);
            //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vDGRegionFlds();

        }

        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            DispDGRegionFldsInfo();
        }
        protected void lbDownLoadFile_Click(object sender, EventArgs e)
        {
            string strFileName = UserId + "\\" + SimpleFName;
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("/ClsFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownLoadExcelFileTempolate_Click(object sender, System.EventArgs e)
        {
            string strFileName = "通用SQL数据库设计模板.xlt";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("/AGC_CS/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("FIRST", lngmId);
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vDGRegionFlds();
            wucvDGRegionFlds4Gv1.SetCheckedItemForGv(lngmId);
        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("LAST", lngmId);
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vDGRegionFlds();
            wucvDGRegionFlds4Gv1.SetCheckedItemForGv(lngmId);
        }

        /// <summary>
        /// Sql数据类型Id， 参数：01：表；02:视图；
        /// </summary>
        public string vsInOutTypeId
        {
            get
            {
                string strInOutTypeId;
                strInOutTypeId = (string)ViewState["InOutTypeId"];
                if (strInOutTypeId == null)
                {
                    strInOutTypeId = "";
                }
                return strInOutTypeId;
            }
            set
            {
                string strInOutTypeId = value;
                ViewState.Add("InOutTypeId", strInOutTypeId);
            }
        }

        public bool vsIsDisp
        {
            get
            {
                string strIsDisp;
                strIsDisp = (string)ViewState["IsDisp"];
                if (strIsDisp == null)
                {
                    return false;
                }
                return bool.Parse(strIsDisp);
            }
            set
            {
                string strIsDisp = value.ToString();
                ViewState.Add("IsDisp", strIsDisp);
            }
        }
        #region 处理父页面信息以及跳转到其他页面

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);


                    //{

                    //}
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":

                    clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息

        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }


        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvDGRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsDGRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsDGRegionFldsBLEx.ReOrder(getRegionId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vDGRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvDGRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsDGRegionFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                clsDGRegionFldsBLEx.ReOrder(getRegionId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vDGRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void chkOnlyShowFldInUse_CheckedChanged(object sender, EventArgs e)
        {
            BindGv_vDGRegionFlds();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvDGRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteDGRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteDGRegionFldsRecord(long lngmId)
        {
            try
            {
                clsDGRegionFldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                return;
            }
            BindGv_vDGRegionFlds();
        }
        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvDGRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateDGRegionFldsRecord(lngmId);
        }
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            //litCode.Text = sbJs.ToString();
        }

        private void ShowCodeTypeButton()
        {
            pnlCodeTypeLst.Controls.Clear();
            
            int intAppTypeId = vsApplicationTypeId;
                       

            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionSet_0004,
                            "",
                            enumRegionType.ListRegion_0002)
                            .OrderBy(x => x.OrderNum).ToList();

            //添加与表-功能相关的函数

            int intCount4 = arrvFunction4GeneCodeObjLst.Count();

            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(intAppTypeId)
                .Where(x => x.ViewTypeCode > 0 )
                .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                .ToList();

            int intCount = 0;
            //string strGroupName = "";
            IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_V2 = arrObjLst.Where(x => x.DependsOn == "View");
            //if (vsvViewRegion != null)
            //{
            //    arrObjLst_V2 = arrObjLst_V2.Where(x => x.RegionTypeId == vsvViewRegion.RegionTypeId).OrderBy(x => x.OrderNum);
            //}
            List<string> arrGroupName = arrObjLst_V2.Select(x => x.GroupName).Distinct().ToList();
            bool bolIsFirst = true;
            Label objLabel = null;
            foreach (string strGroupName in arrGroupName)
            {
                IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_Sel =
                    arrObjLst_V2.Where(x => x.GroupName == strGroupName);
                IEnumerable<string> arrCodeTypeId = arrObjLst_Sel.Select(x => x.CodeTypeId);
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel1 =
                   arrvFunction4GeneCodeObjLst.Where(x => arrCodeTypeId.Contains(x.FuncCodeTypeId));

                if (arrvFunction4GeneCodeObjLst_Sel1.Count() == 0)
                {
                    continue;
                }
                if (string.IsNullOrEmpty(strGroupName) == false)
                {
                    if (bolIsFirst == false)
                    {
                        Label objLabel_Br = new Label();
                        objLabel_Br.Text = string.Format("<br/>", strGroupName);
                        //objLabel.AutoSize = true;
                        pnlCodeTypeLst.Controls.Add(objLabel_Br);
                    }
                    else
                    {
                        bolIsFirst = false;
                    }
                    objLabel = new Label();
                    objLabel.Text = string.Format("{0}: ", strGroupName);
                    //objLabel.AutoSize = true;
                    objLabel.ID = string.Format("lbl{0}", strGroupName);
                    //string strToolTip = string.Format("生成：[{0}({1})({2})]的代码。", objInFor.CodeTypeName, objInFor.CodeTypeId, objInFor.ProgLangTypeId4CodeType);
                    //toolTip1.SetToolTip(objLabel, strToolTip);                    
                    objLabel.CssClass = "text-secondary font-weight-bold";
                    objLabel.Attributes["Style"] = "margin-right:10px;margin-top:35px;left:0px;min-width:150px;";
                    pnlCodeTypeLst.Controls.Add(objLabel);
                }
                foreach (clsvAppCodeTypeRelaENEx objInFor in arrObjLst_V2)
                {
                    if (objInFor.GroupName != strGroupName) continue;
                    List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel =
                        arrvFunction4GeneCodeObjLst.Where(x => x.FuncCodeTypeId == objInFor.CodeTypeId).ToList();

                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCode in arrvFunction4GeneCodeObjLst_Sel)
                    {
                        HtmlInputButton objHtmlInputButton = new HtmlInputButton();
                        objHtmlInputButton.ID = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);

                        objHtmlInputButton.Name = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);
                        objHtmlInputButton.Attributes["class"] = "btn btn-outline-primary btn-sm";
                        objHtmlInputButton.Value = string.Format("{0}-{1}({2})",
                            objInFor.CodeTypeName, objvFunction4GeneCode.FuncCHName4Code,
                            objInFor.ProgLangTypeName);

                        objHtmlInputButton.Attributes.Add("onclick", string.Format("GeneCode4Func('{0}','{1}','{2}','{3}')",
                            objInFor.CodeTypeId, clsCommonSession.ViewId, objvFunction4GeneCode.FuncId4GC, intAppTypeId));

                        //objButton.Attributes["Style"] = "margin-right:10px;margin-top:5px;left:0px;";

                        //objButton.Command += new CommandEventHandler(this.btnCodeType_Click);
                        pnlCodeTypeLst.Controls.Add(objHtmlInputButton);
                        intCount++;
                    }
                }

            }
            if (intCount == 0)
            {
                string strMsg = string.Format("应用:{0}({1})没有用于[View]相应的代码类型.(In {2})",
                    objvApplicationTypeEN.ApplicationTypeName, objvApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        [WebMethod]
        public static string GeneCode4Func(string strCodeTypeId, string strTabId, string strFuncId, string strViewId, string strCmPrjId, int intApplicationTypeId)
        {

            if (strCodeTypeId.StartsWith("C"))
            {
                strCodeTypeId = strCodeTypeId.Substring(1);
            }
            //clsPubVar.CurrSelPrjId = "0116";
            //clsPubVar.CurrPrjDataBaseId = "0111";

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            ////clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                //string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                //string strCodeText1 = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, clsPubConst.DataBaseType.MsSql, strTabId,
                //    strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                //    ref strRe_FileNameWithModuleName);
                //string str
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId, clsPubConst.DataBaseType.MsSql, strTabId,
               strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
               ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);

                //txtFileName4GenCode.Text = strRe_ClsName;
                //ShowCode(strCodeText);
                clsGCType objGCType = new clsGCType();
                objGCType.Code = strCodeText;
                objGCType.ClsName = strRe_ClsName;
                objGCType.FileName = strRe_FileNameWithModuleName;
                return clsJSON.GetJsonFromObj(objGCType);
                //                return strCodeText;
            }
            catch (Exception objException)
            {
                //lblMsg.Text = objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }



        private void ShowData(string strCtrlId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            //if (lngmId == 0) return;        //如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；

            //if (clsDGRegionFldsBL.IsExist(lngmId) == false)       //检查该关键字的记录是否存在
            //{
            //    string ss = "关键字为：" + lngmId + "的不存在!";
            //    clsCommonJsFunc.Alert(this, ss);
            //    return;
            //}
            //3、用提供的关键字初始化一个类对象；
            string strFldName = "";
            string strDataNodeName = "";
            long lngMid = 0;
            string strCondition = "";
            if (strCtrlId.Substring(0, 3) == "dn_")
            {
                string strCtrlId4DataNode = strCtrlId.Substring(3);


                strDataNodeName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId4DataNode);
                if (string.IsNullOrEmpty(strDataNodeName) == true)
                {
                    string strMsg = string.Format("根据[结点控件Id:{0}]获取结点名(strDataNodeName)不成功！", strCtrlId4DataNode);
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                if (strCtrlId4DataNode.Substring(0, 3) == "btn") return;

                strCondition = new clsvDGRegionFldsEN()
          //.SetDataNodeName(strDataNodeName, "=")
          .SetRegionId(getRegionId, "=")
          .GetCombineCondition();
                 lngMid = clsvDGRegionFldsBL.GetFirstID_S(strCondition);
            }
            else
            {
                strFldName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId);
                if (string.IsNullOrEmpty(strFldName) == true)
                {
                    string strMsg = string.Format("根据[控件Id:{0}]获取字段名(FldName)不成功！", strCtrlId);
                    throw new Exception(strMsg);
                }
                if (strCtrlId.Substring(0, 3) == "btn") return;
                strCondition = new clsvDGRegionFldsEN()
          .SetFldName(strFldName, "=")
          .SetRegionId(getRegionId, "=")
          .GetCombineCondition();
                lngMid = clsvDGRegionFldsBL.GetFirstID_S(strCondition);
            }

      
            if (lngMid == 0)
            {
                string strMsg = string.Format("根据条件[{0}]获取关键字不成功！", strCondition);
                throw new Exception(strMsg);
            }
            clsDGRegionFldsEN objDGRegionFlds = new clsDGRegionFldsEN(lngMid);
            //4、获取类对象的所有属性；
            clsDGRegionFldsBL.GetDGRegionFlds(ref objDGRegionFlds);
            Session.Add("objDGRegionFlds", objDGRegionFlds);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromDGRegionFldsClass(objDGRegionFlds);

        }

        protected void btnSetColNum_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtColNum.Text) == true)
            //{
            //    clsCommonJsFunc.Alert(this, "请输入列数！");
            //    txtColNum.Focus();
            //}
            //int intColNum = int.Parse(txtColNum.Text);

            if (string.IsNullOrEmpty(txtWidth.Text) == false)
            {
                try
                {
                    int intWidth = int.Parse(txtWidth.Text);
                    clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionId(getRegionId);
                    if (string.IsNullOrEmpty(txtWidth.Text) == false)
                    {
                        objViewRegion.SetWidth(intWidth)
                                 .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
                        //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);

                }
            }
            //clsEditRegionEN obj = clsEditRegionBL.GetObjByRegionId(getRegionId);
            //obj.SetColNum(intColNum)
            //    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
            //    .SetUpdUser(clsCommonSession.UserId)
            //    .Update();
            try
            {
                wucListRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5, true, clsPubVar.CurrCmPrjId);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        //protected string vsViewId
        //{
        //    get
        //    {
        //        string sViewId;
        //        sViewId = (string)ViewState["ViewId"];
        //        if (sViewId == null)
        //        {
        //            sViewId = "";
        //        }
        //        return sViewId;
        //    }
        //    set
        //    {
        //        string sViewId = value;
        //        ViewState.Add("ViewId", sViewId);
        //    }
        //}

        protected void btnSetDefaSort_Click(object sender, EventArgs e)
        {
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            
            lblMsg1.Text = "";
            try
            {
                List<clsDGRegionFldsEN> arrDGRegionFlds = clsDGRegionFldsBLEx.GetObjLstByRegionId4InUseExCache1(getRegionId, clsPubVar.CurrCmPrjId);
                foreach(clsDGRegionFldsEN objInFor in arrDGRegionFlds)
                {
                    if (objInFor.mId == lngmId)
                    {
                        if (objInFor.IsDefaultSort == false)
                        {
                            objInFor.IsDefaultSort = true;
                            objInFor.UpdateRecordEx();
                        }
                    }
                    else
                    {
                        if (objInFor.IsDefaultSort == true)
                        {
                            objInFor.IsDefaultSort = false;
                            objInFor.UpdateRecordEx();
                        }
                    }
                }

                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vDGRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void txtClassName_TextChanged(object sender, EventArgs e)
        {

            int intApplicationTypeId = vsApplicationTypeId;
            switch (intApplicationTypeId)
            {
                case (int)enumApplicationType.WinApp_1:
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".cs";

                    break;
                case (int)enumApplicationType.WebApp_2:

                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".aspx";

                    break;
                case (int)enumApplicationType.AndroidApp_5://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".xml";

                    break;
                case (int)enumApplicationType.WebApp_JS_RJ_28://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".html";

                    break;
                case (int)enumApplicationType.SpaAppInCore_TS_18://                        enumApplicationType.AndroidApp_5
                case (int)enumApplicationType.SpaInCoreUT_27://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".cshtml";

                    break;
                case (int)enumApplicationType.VueAppInCore_TS_30://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".vue";

                    break;
                default:
                    string strMsg = string.Format("应用:{0}在函数中没有被处理！", clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId));
                    clsCommonJsFunc.Alert(this, strMsg);
                    break;
            }
            try
            {
                wucListRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5, true, clsPubVar.CurrCmPrjId);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnSetClassName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassName.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "请输入类名！");
                txtClassName.Focus();
            }
            if (string.IsNullOrEmpty(txtFileName.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "请输入文件名！");
                txtFileName.Focus();
            }
            string strClassName = txtClassName.Text;
            string strFileName = txtFileName.Text;
            try
            {
                clsViewRegionEN obj = clsViewRegionBL.GetObjByRegionId(getRegionId);
                obj.SetClsName(strClassName)
                    //.SetFileName(strFileName)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(clsCommonSession.UserId)
                    .Update();
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                //wucViewRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        /// <summary>
        /// Sql数据类型Id， 参数：01：表；02:视图；
        /// </summary>
        public int vsApplicationTypeId
        {
            get
            {
                string strApplicationTypeId;
                strApplicationTypeId = (string)ViewState["ApplicationTypeId"];
                if (strApplicationTypeId == null)
                {
                    return 0;
                }
                return int.Parse(strApplicationTypeId);
            }
            set
            {
                string strApplicationTypeId = value.ToString();
                ViewState.Add("ApplicationTypeId", strApplicationTypeId);
            }
        }
        protected string getRegionId
        {
            get
            {
                if (string.IsNullOrEmpty(qsRegionId) == false) return qsRegionId;
                return "";
            }

        }
        private string qsRegionId
        {
            get
            {
                string strRegionId = Request.QueryString["RegionId"] ?? "".ToString();
                if ((strRegionId != null) && (strRegionId != ""))
                {
                    return strRegionId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summa
    }
}