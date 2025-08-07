
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucCMFunctionB
表名:CMFunction
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:50:51
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//生成与表相关的控件控制层代码
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.datetime;
    using com.taishsoft.commdb;
    
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;
    using CommFunc4WebForm;
    using System.Collections.Generic;
    using BusinessLogicEx;
    using System.Text;
    
    using System.Linq;

    /// <summary>
    ///		wucCMFunctionB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucvCMFunction4DL : System.Web.UI.UserControl
    {

        /// <summary>
        /// 在DataList中，单击[修改]按钮时，所引发的修改事件
        /// </summary>
        public event OnDlUpdateClick DlUpdateClick;
        /// <summary>
        /// 在DataList中，单击[删除]按钮时，所引发的修改事件
        /// </summary>
        public event OnDlDeleteClick DlDeleteClick;

        /// <summary>
        /// 在DataList中，单击[克隆]按钮时，所引发的修改事件
        /// </summary>
        public event OnDlCloneClick DlCloneClick;

        /// <summary>
        /// 在DataList中，单击[克隆]按钮时，所引发的修改事件
        /// </summary>
        public event OnDlEditParaClick DlEditParaClick;

        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }

        #region 查询相关函数
        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnQuery_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            ////把GridView的当前页索引设置为0,即第1页。
            ////当单击查询时,首先显示的是表记录内容的第一部分内容。
            //this.dlCMFunction.PageIndex = 0;
            ////把表记录的内容显示在GridView中
            //BindDl_CMFunction();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// </summary>
        public void BindDl_CMFunction(string strWhereCond)
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。

            int intRecCount = 0;
            int intPageCount = 0;
       List<clsvCMFunctionEN> arrvCMFunction = null;
            try
            {
                vsWhereCond = strWhereCond;
                intRecCount = clsvCMFunctionBL.GetRecCountByCond(vsWhereCond);
                vsRecCount = intRecCount;
                intPageCount = GetPageCount(intRecCount, vsPageSize);
                vsPageCount = intPageCount;
                //	2、根据条件串获取该表满足条件的DataTable；
                arrvCMFunction = clsvCMFunctionBL.GetObjLstByPager(vsPageIndex, vsPageSize, strWhereCond, vsSortCMFunctionBy);
             
                arrvCMFunction.ForEach(x=>x.FuncContent = clsWebString.HtmlEncode( x.FuncContent.TrimStart(" \t".ToCharArray())));
                arrvCMFunction.ForEach(x => x.FuncComments = clsWebString.HtmlEncode(x.FuncComments.TrimStart(" \t".ToCharArray())));
                arrvCMFunction.ForEach(x => x.UpdDate = clsDateTime.getDateStr(x.UpdDate, 1));


                //     string ss = arrvCMFunction[0].FuncContent;

                //List<string> arrCmFunctionId = arrvCMFunction.Select(x=>x.CmFunctionId).ToList();
                //if (arrCmFunctionId.Count > 0)
                //{
                //    string strCondition = string.Format("{0} in ({1})", clsvCMClassFuncRelaEN.con_CmFunctionId, clsArray.GetSqlInStrByArray(arrCmFunctionId, true));
                //    IEnumerable<clsvCMClassFuncRelaEN> arrvCMClassFuncRela = clsvCMClassFuncRelaBL.GetObjLst(strCondition);
                //    foreach (clsvCMFunctionEN objvCMFunction in arrvCMFunction)
                //    {
                //        string strCmFunctionId = objvCMFunction.CmFunctionId;
                //        IEnumerable<clsvCMClassFuncRelaEN> arrvCMClassFuncRela_Sel = arrvCMClassFuncRela.Where(x => x.CmFunctionId == strCmFunctionId);
                //        List<string> arrClassName = arrvCMClassFuncRela_Sel.Select(x => x.ClsName).ToList();
                //        string strClassNameLst = clsArray.GetSqlInStrByArray(arrClassName, false);
                //        string strTemp = string.Format("{0}", strClassNameLst)
                //            .Replace(",,", ",")
                //            .TrimEnd(",".ToCharArray())
                //            .TrimStart(",".ToCharArray());
                //        objvCMFunction.ClassNameLst = strTemp;
                //    }
                //}
                //arrvCMFunction.ForEach(x=>x.ClassNameLst = "");

                //objDT.Columns.Add("ClassName");
                //foreach (DataRow objRow in objDT.Rows)
                //{
                //    objRow["ClassName"] = "";
                //}
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WucL000001)获取数据表(DataTable)不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            //DataView objDV = objDT.DefaultView;
            //objDV.Sort = vsSortCMFunctionBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
            //                                 ///设置GridView中每页的记录数
            //if (vsPageSize > 0)
            //{
            //    int intPageSize = vsPageSize;
            //    dlCMFunction.PageSize = intPageSize;
            //}
            //else
            //{
            //    vsPageSize = 15;
            //    dlCMFunction.PageSize = vsPageSize;
            //}
            this.dlCMFunction.DataSource = arrvCMFunction;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.dlCMFunction.DataBind();
            SetPager();

        }



       


        /// <summary>
        /// 事件函数:在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理:改变GridView的每页记录数。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenddlPagerRecCount_SelectedIndexChanged)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize = intPageSize.ToString();
                    BindDl_CMFunction(vsWhereCond);
                }
            }
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

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsWhereCond
        {
            get
            {
                string sWhereCond;
                sWhereCond = (string)ViewState["WhereCond"];
                if (sWhereCond == null)
                {
                    sWhereCond = "";
                }
                return sWhereCond;
            }
            set
            {
                string sWhereCond = value;
                ViewState.Add("WhereCond", sWhereCond);
            }
        }

        #endregion 查询相关函数


        #region 排序相关函数
        /// <summary>
        /// 事件函数:在GridView中，单击列头进行排序所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void dlCMFunction_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortCMFunctionBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortCMFunctionBy = e.SortExpression + " Asc";
                BindDl_CMFunction(vsWhereCond);
                return;
            }
            //检查原来是升序
            intIndex = vsSortCMFunctionBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortCMFunctionBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortCMFunctionBy = e.SortExpression + " Desc";
            }
            BindDl_CMFunction(vsWhereCond);
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortCMFunctionBy
        {
            get
            {
                string sSortCMFunctionBy;
                sSortCMFunctionBy = (string)ViewState["SortCMFunctionBy"];
                if (sSortCMFunctionBy == null)
                {
                    sSortCMFunctionBy = "";
                }
                return sSortCMFunctionBy;
            }
            set
            {
                string sSortCMFunctionBy = value;
                ViewState.Add("SortCMFunctionBy", sSortCMFunctionBy);
            }
        }
        public void SetSortBy(string strSortBy)
        {
            vsSortCMFunctionBy = strSortBy;
        }
        #endregion 排序相关函数
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


        /// <summary>
        ///从列表中获取选择的第一个关键字
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetFirstCheckedKeyFromGv)
        /// </summary>/// <returns>返回选择的第一个关键字</returns>
        //public string GetFirstCheckedKeyFromGv()
        //{
        //    List<string> lstCmFunctionId = clsCommForWebForm.GetFirstCheckedItemFromGv(dlCMFunction, clsCMFunctionEN.con_CmFunctionId);
        //    if (lstCmFunctionId.Count == 0)
        //    {
        //        clsCommonJsFunc.Alert(this, "(errid:WebI000015)没有选择记录,请选择有效的表记录!");
        //        return "";
        //    }

        //    //1、显示该关键字的数据让用户修改该关键字记录；
        //    string strCmFunctionId = lstCmFunctionId[0];
        //    return strCmFunctionId;
        //}
        /// <summary>
        ///从列表中获取所有选择的关键字
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetAllCheckedKeysFromGv)
        /// </summary>/// <returns>返回所有选择的关键字列表</returns>
        //public List<string> GetAllCheckedKeysFromGv()
        //{
        //    List<string> lstCmFunctionId = clsCommForWebForm.GetAllCheckedItemFromGv(dlCMFunction, "chkCheckRec", clsCMFunctionEN.con_CmFunctionId);
        //    if (lstCmFunctionId.Count == 0)
        //    {
        //        clsCommonJsFunc.Alert(this, "(errid:WebI000016)没有选择记录,请选择有效的表记录!");
        //        return null;
        //    }
        //    return lstCmFunctionId;
        //}
        public bool SetCheckedItemForGv(string strCmFunctionId)
        {
            //clsCommForWebForm.SetCheckedItemForGv(dlCMFunction, 1, strCmFunctionId);
            return true;
        }
     
        public void SetVisible(bool bolVisible)
        {
            dlCMFunction.Visible = bolVisible;
        }
       
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strCmFunctionId">给定关键字</param>
        protected void DeleteCMFunctionRecord(string strCmFunctionId)
        {
            try
            {
                clsCMFunctionBL.DelRecord(strCmFunctionId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }

            string strWhereCond = vsWhereCond;
            BindDl_CMFunction(vsWhereCond);
        }
                
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateCMFunctionRecord(string strCmFunctionId)
        {
            ////操作步骤:(总共2步)
            ////1、显示该关键字记录的内容在界面上；
            ////2、清空提示信息的内容,同时使<确定修改>按钮可用；

            ////1、显示该关键字记录的内容在界面上；
            //ShowData(strCmFunctionId);
            ////2、清空提示信息的内容,同时使<确定修改>按钮可用；
            //btnOKUpd.Enabled = true;
            //wucCMFunctionB1.SetKeyReadOnly(true);
            //btnOKUpd.Text = "确认修改";
            //btnCancelCMFunctionEdit.Text = "取消修改";
            //lblMsgEdit.Text = "";
            //DispEditCMFunctionRegion();
        }
        /// <summary>
        /// 设置GridView可视性
        /// </summary>
        /// <param name="strColumnName">列名 or 字段名</param>
        /// <param name="bolIsVisible">是否可见</param>
        //public void SetGvVisibility(string strColumnName, bool bolIsVisible)
        //{
        //    clsCommForWebForm.SetGvVisibility(dlCMFunction, strColumnName, bolIsVisible);
        //}

        /// <summary>
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected int vsApplicationTypeId
        {
            get
            {
                int sApplicationTypeId;
                sApplicationTypeId = (int)ViewState["ApplicationTypeId"];
                if (ViewState["ApplicationTypeId"] == null)
                {
                    sApplicationTypeId = 0;
                }
                return sApplicationTypeId;
            }
            set
            {
                int sApplicationTypeId = value;
                ViewState.Add("ApplicationTypeId", sApplicationTypeId);
            }
        }

        protected void dlCMFunction_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView drv = (DataRowView)e.Row.DataItem;
                //DataRow objDR = (DataRow)e.Row.DataItem ;

                clsvCMFunctionEN objCurr = clsvCMFunctionBL.GetObjByDataRow_S(drv);//.DataItem
                //if (string.IsNullOrEmpty(objCurr.CodeTypeId) == false)
                //{
                //    //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
                //    //e.Row.Attributes["class"] = "text-muted bg-info";
                //    //e.Row.CssClass = "text-muted bg-info";
                //    clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCurr.ProgLangTypeId);
                //    clsvwf_StepPointRelaEN objvwf_StepPointRela = clsvwf_StepPointRelaBLEx.GetObjByWorkFlowIdAndTabKeyIdCache(clsPubVar.CurrWorkFlowId, objCurr.CodeTypeId);
                    //if (objvwf_StepPointRela != null)
                    //{
                    //    e.Row.Cells[intIndex4Key].Text = string.Format("{2}-{0}({1})", 
                    //        objCurr.CodeTypeName, objProgLangTypeEN.ProgLangTypeSimName, objvwf_StepPointRela.LevelNo);
                    //}
                    //else
                    //{
                    //    e.Row.Cells[intIndex4Key].Text = string.Format("{0}({1})", objCurr.CodeTypeName, objProgLangTypeEN.ProgLangTypeSimName);
                    //}
                    //if (objCurr.ClsName.Contains(objCurr.TabName) == false)
                    //{
                    //    intIndex4Key = clsCommForWebForm.GetIndexByDataField4GridView(dlCMFunction,
                    //       clsvCMFunctionEN.con_ClassName);
                    //    e.Row.Cells[intIndex4Key].Text = string.Format("{0}({1})", objCurr.ClsName, objCurr.TabName);
                    //}
                //}
                //if (string.IsNullOrEmpty(objCurr.ReturnTypeNameCustom) == false)
                //{
                //    //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
                //    //e.Row.Attributes["class"] = "text-muted bg-info";
                //    //e.Row.CssClass = "text-muted bg-info";
                //    int intIndex4Key = clsCommForWebForm.GetIndexByDataField4GridView(dlCMFunction,
                //       clsvCMFunctionEN.con_ReturnTypeName);
                //    e.Row.Cells[intIndex4Key].Text = string.Format("{0}", objCurr.ReturnTypeNameCustom);
                //}
                if (objCurr.ParaNum>0 && string.IsNullOrEmpty(objCurr.ProgLangTypeId) == false)
                {
                    //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
                    //e.Row.Attributes["class"] = "text-muted bg-info";
                    //e.Row.CssClass = "text-muted bg-info";
                    //int intIndex4Key = clsCommForWebForm.GetIndexByDataField4GridView(dlCMFunction,
                    //   "FuncParaLst");
                    //IEnumerable<clsCMFuncParaRelaEN> arrFuncParaRela = clsCMFuncParaRelaBLEx.GetObjListByCmFunctionIdCacheEx(objCurr.CmFunctionId);
                    
                    //if (arrFuncParaRela != null)
                    //{
                    //    arrFuncParaRela = arrFuncParaRela.OrderBy(x=>x.OrderNum);
                    //    StringBuilder sbParaList = new StringBuilder();
                    //    foreach (clsCMFuncParaRelaEN objInFor in arrFuncParaRela)
                    //    {
                    //        clsCMFuncParaEN objCMFuncPara = clsCMFuncParaBL.GetObjByCmFuncParaIdCache(objInFor.CmFuncParaId);
                   
                    //        string strParameterType = objCMFuncPara.GetParaTypeName(objCurr.ProgLangTypeId); 
                    //        switch (objCurr.ProgLangTypeId)
                    //        {
                    //            case enumProgLangType.CSharp_01:

                    //                if (strParameterType == "Int32") strParameterType = "int";
                    //                break;
                    //        }
                    //        sbParaList.AppendFormat("{0} {1}, ", strParameterType, objCMFuncPara.ParaName);

                    //    }
                    //    sbParaList.Remove(sbParaList.Length - 2, 2);
                    //    e.Row.Cells[intIndex4Key].Text = string.Format("{0}", sbParaList.ToString());
                    //}
                }
            }
        }
       
        protected string seIsShowGCDiv
        {
            get
            {
                string sIsShowGCDiv;
                sIsShowGCDiv = (string)Session["IsShowGCDiv"];
                if (sIsShowGCDiv == null)
                {
                    sIsShowGCDiv = "";
                }
                return sIsShowGCDiv;
            }
            set
            {
                string sIsShowGCDiv = value;
                Session.Add("IsShowGCDiv", sIsShowGCDiv);
            }
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenPageSizeViewState)
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
        /// 设置GridView中的页序号
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageIndex)
        /// </summary>
        public int vsPageIndex
        {
            get
            {
                string strPageIndex;
                strPageIndex = (string)ViewState["PageIndex"];
                if (strPageIndex == null)
                {
                    strPageIndex = "";
                    return 1;
                }
                return int.Parse(strPageIndex);
            }
            set
            {
                string strPageIndex = value.ToString();
                ViewState.Add("PageIndex", strPageIndex);
            }
        }



        /// <summary>
        /// 设置GridView中的总页数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageCount)
        /// </summary>
        public int vsPageCount
        {
            get
            {
                string strPageCount;
                strPageCount = (string)ViewState["PageCount"];
                if (strPageCount == null)
                {
                    strPageCount = "";
                    return 1;
                }
                return int.Parse(strPageCount);
            }
            set
            {
                string strPageCount = value.ToString();
                ViewState.Add("PageCount", strPageCount);
            }
        }

        /// <summary>
        /// 设置GridView中的总页数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_RecCount)
        /// </summary>
        public int vsRecCount
        {
            get
            {
                string strRecCount;
                strRecCount = (string)ViewState["RecCount"];
                if (strRecCount == null)
                {
                    strRecCount = "";
                    return 1;
                }
                return int.Parse(strRecCount);
            }
            set
            {
                string strRecCount = value.ToString();
                ViewState.Add("RecCount", strRecCount);
            }
        }



        /// <summary>
        /// 函数功能:计算当前页数，根据记录数和每页记录数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenGetPageCount)
        /// </summary>
        /// <param name = "intRecCount">总记录数</param>
        /// <param name = "intPageSize">每页记录数</param>
        private int GetPageCount(int intRecCount, int intPageSize)
        {
            if (intRecCount == 0) return 0;
            int intPageCount = intRecCount / intPageSize;
            if (intRecCount % intPageSize == 0) return intPageCount;
            return intPageCount + 1;
        }

        protected void dlCMFunction_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            ///找到添加控件的Panel
            // Panel ItemPanel = (Panel)e.Item.FindControl("ItemPanel");
            DataList oblDataList = (DataList)sender;
            if (e.Item.ItemIndex < 0)
            {
                return;
            }
            string strQuestionID = oblDataList.DataKeys[e.Item.ItemIndex].ToString();
            
            clsvCMFunctionEN objvCMFunctionEN = (clsvCMFunctionEN)e.Item.DataItem;
            //objvCMFunctionEN.QuestionID = strQuestionID;
            ////StringBuilder sbCondition = new StringBuilder();
            ////sbCondition.AppendFormat( "QuestionID='{0}'", strQuestionID);

            //clsvCMFunctionBL.GetvCMFunction(ref objvCMFunctionEN);

            //string strAnswerTypeId = "";
            Button btnEditPara = (Button)e.Item.FindControl("btnEditPara");
            Button btnUpdate = (Button)e.Item.FindControl("btnUpdate");
            Button btnDelete = (Button)e.Item.FindControl("btnDelete");
            Button btnClone = (Button)e.Item.FindControl("btnClone");
            if (vsOperate == "Edit")
            {
                btnClone.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnEditPara.Visible = true;
            }
            else
            {
                btnClone.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnEditPara.Visible = false;
            }
            Label lblAdditionalMemo = (Label)e.Item.FindControl("lblIsHaveAdditionalMemo");
            Label lblQuestionName = (Label)e.Item.FindControl("lblQuestionName");
            Label lblQuestionName_Add = (Label)e.Item.FindControl("lblQuestionName_Add");
            TextBox txtAnswerText = (TextBox)e.Item.FindControl("txtAnswerText");
            DropDownList ddlAnswerInQuestion = (DropDownList)e.Item.FindControl("ddlAnswerInQuestion");
            DropDownList ddlQuestionOptions = (DropDownList)e.Item.FindControl("ddlQuestionOptions");

            HtmlTableCell objCell_QuestionName = (HtmlTableCell)e.Item.FindControl("tdQuestionName");

      


        }

        protected void dlCMFunction_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string strCmFunctionId = e.CommandArgument.ToString();
            string strMsg;
            //hidvalue.Value = ExamID;

            List<string> arrCmFunctionId = new List<string>();
            switch (e.CommandName)
            {
                case "Update":
                    if (DlUpdateClick != null)
                    {
                        clsEventArgs4Update objEventArgs4Update = new clsEventArgs4Update()
                        {
                            KeyId = strCmFunctionId.ToString()
                        };
                        DlUpdateClick(this, objEventArgs4Update);
                    }
                    break;
                case "Delete":
                    if (DlDeleteClick != null)
                    {
                        clsEventArgs4Delete objEventArgs4Delete = new clsEventArgs4Delete()
                        {
                            KeyId = strCmFunctionId.ToString()
                        };
                        DlDeleteClick(this, objEventArgs4Delete);
                    }
                    break;
                case "Clone":
                    if (DlCloneClick != null)
                    {
                        clsEventArgs4Clone objEventArgs4Clone = new clsEventArgs4Clone()
                        {
                            KeyId = strCmFunctionId.ToString()
                        };
                        DlCloneClick(this, objEventArgs4Clone);
                    }
                    break;
                case "EditPara":
                    if (DlEditParaClick != null)
                    {
                        clsEventArgs4EditPara objEventArgs4EditPara = new clsEventArgs4EditPara()
                        {
                            KeyId = strCmFunctionId.ToString()
                        };
                        DlEditParaClick(this, objEventArgs4EditPara);
                    }
                    break;
                case "EditReferResource"://编辑引用资源

                    string strHtml2 = string.Format("../QuestionaireEdit/wfmQuestionReferAdd.aspx?CmFunctionId={0}&UserId={1}&CourseId={2}",
                        strCmFunctionId,
                        getUserId,
                        getCourseId);
                    Response.Redirect(strHtml2);
                    break;
                case "EditQuestion":
                    //this.ClientScript.RegisterStartupScript(this.GetType(), "EditQuestion", string.Format("EditQuestion('{0}','{1}', '{2}', '{3}', 900, 700)",
                    //    strCmFunctionId, getCourseId, qsFunctionName, getUserId), true);
                    vsOperate = "EditQuestionByCourse";
                    UpdateCMFunctionRecord(strCmFunctionId);
                    //                clsPubFun_CMFunctionByCourse.EditQuestion(this, strCmFunctionId, getCourseId, qsFunctionName, qsCourseExamPaperId, getUserId);
                    break;
                case "CloneQuestion":
             
                    //vsOperate = "EditQuestionByCourse";
                    //clsCMFunctionEN objCMFunctionEN = clsCMFunctionBL.GetObjByCmFunctionId(strCmFunctionId);
                    //objCMFunctionEN.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
                    //objCMFunctionEN.FunctionName = "C_" + objCMFunctionEN.FunctionName;
                    //string strCondition_Exist = string.Format("{0}='{1}'", conCMFunction.FunctionName, objCMFunctionEN.FunctionName);
                    //if (clsCMFunctionBL.IsExistRecord(strCondition_Exist) == true)
                    //{
                    //    strMsg = string.Format("新题目名称:[{0}]已经存在，不能复制！", objCMFunctionEN.FunctionName);
                    //    clsCommonJsFunc.Alert(this, strMsg);//  throw new Exception(strMsg);
                    //    return;
                    //}
                    //objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    //objCMFunctionEN.UpdUser = clsCommonSession.UserId;
                    //clsCMFunctionBL.AddNewRecordBySql2(objCMFunctionEN);
                    //clsQuestionOptionsBLEx.CopyTo(strCmFunctionId, objCMFunctionEN.CmFunctionId);
                    

                    //clsContentTypeEN objContentTypeEN =
                    //    clsContentTypeBLEx.GetContentTypeObjByTableNameAndFldName(clsCMFunctionEN._CurrTabName,
                    //        clsCMFunctionEN.con_QuestionContent);

                    //if (objContentTypeEN == null)
                    //{
                    //    strMsg = string.Format("根据表名:[{0}]和字段名:[{1}]获取内容类型对象,为空！请添加！",
                    //        clsCMFunctionEN._CurrTabName, clsCMFunctionEN.con_QuestionContent);
                    //    throw new Exception(strMsg);
                    //}

                    //string strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                    //    contz_ContentAttachment.ContentTypeId,
                    //    "0001",
                    //    contz_ContentAttachment.TableNameKey,
                    //    strCmFunctionId);
                    //List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst = clstz_ContentAttachmentBL.GetObjLst(strCondition);
                    //foreach (clstz_ContentAttachmentEN objInfor in arrtz_ContentAttachmentObjLst)
                    //{
                    //    objInfor.TableNameKey = objCMFunctionEN.CmFunctionId;
                    //    objInfor.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    //    objInfor.UpdUserId = clsCommonSession.UserId;
                    //    clstz_ContentAttachmentBL.AddNewRecordBySql2(objInfor);
                    //}
                    //strCondition = string.Format("{0}='{1}'",
                    //    concc_KnowledgesExamLibRela.CmFunctionId,
                    //   strCmFunctionId);
                    //List<clscc_KnowledgesExamLibRelaEN> arrcc_KnowledgesExamLibRelaObjLst = clscc_KnowledgesExamLibRelaBL.GetObjLst(strCondition);
                    //foreach (clscc_KnowledgesExamLibRelaEN objInfor in arrcc_KnowledgesExamLibRelaObjLst)
                    //{
                    //    objInfor.CmFunctionId = objCMFunctionEN.CmFunctionId;
                    //    objInfor.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    //    objInfor.UpdUserId = clsCommonSession.UserId;
                    //    clscc_KnowledgesExamLibRelaBL.AddNewRecordBySql2(objInfor);
                    //}

                    //Bind_dlwenjuan();
                    //BindDl_dlQuestionTypeNum();

                    break;
                case "DelQuestion":
                    DeleteCMFunctionRecord(strCmFunctionId);
                    
                    BindDl_CMFunction(vsWhereCond);

                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "UpMove", string.Format("this.location.href='#A{0}'",
                   strCmFunctionId), true);
                    break;
                case "EditAnswers":

              
                    vsOperate = "EditAnswersByCourse";
                    //divEditAnswer.Visible = true;
                    //clsPubFun_CMFunctionByCourse.EditAnswers(this, Iframe11, strCmFunctionId, getCourseId, getUserId);
                    break;
              
                default:
                    strMsg = string.Format("命令名称:{0}相应函数中没有被处理，请检查！{1}",
                      e.CommandName, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    break;
            }
        }
        /// <summary>
        /// 操作类型pageindex
        /// </summary>
        public string vsOperate
        {
            get
            {
                string strOperate;
                strOperate = (string)ViewState["Operate"];
                if (strOperate == null)
                {
                    strOperate = "";
                }
                return strOperate;
            }
            set
            {
                string strOperate = value;
                ViewState.Add("Operate", strOperate);
            }
        }


        /// <summary>
        /// 根据传递参数和选择参数决定的课程Id
        /// 功能：如果选择参数不为空，就返回选择参数课程Id，
        ///       否则就返回传递参数课程Id
        /// </summary>
        protected string getUserId
        {
            get
            {
                if (string.IsNullOrEmpty(clsCommonSession.UserId4get) == false) return clsCommonSession.UserId4get;
                if (string.IsNullOrEmpty(qsUserId) == false) return qsUserId;
                return "";
            }
            set
            {
                clsCommonSession.UserId4get = value;
            }
        }
        /// <summary>
        /// 用户Id。例如：“pyf”, "lyl"等
        ///         
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        private string qsUserId
        {
            get
            {
                if (Request.QueryString["UserId"] != null)
                {
                    return Request.QueryString["UserId"].ToString().Trim();
                }
                return "";
            }
        }
        /// <summary>
        /// 根据传递参数和选择参数决定的课程Id
        /// 功能：如果选择参数不为空，就返回选择参数课程Id，
        ///       否则就返回传递参数课程Id
        /// </summary>
        protected string getCourseId
        {
            get
            {
                if (string.IsNullOrEmpty(vsCourseId) == false) return vsCourseId;
                if (string.IsNullOrEmpty(qsCourseId) == false) return qsCourseId;
                return seCourseId;
            }
        }


        public string seCourseId
        {
            get
            {
                string strCourseId = clsCommonSession.CourseId;
                return strCourseId;
            }
            set
            {
                clsCommonSession.CourseId = value;
            }
        }
        /// <summary>
        /// 课程Id（用于记录用户自己选择的课程Id)
        /// </summary>
        protected string vsCourseId
        {
            get
            {
                string sCourseId;
                sCourseId = (string)ViewState["CourseId"];
                if (sCourseId == null)
                {
                    sCourseId = "";
                }
                return sCourseId;
            }
            set
            {
                string sCourseId = value;
                ViewState.Add("CourseId", sCourseId);
            }
        }
        /// <summary>
        /// 课程Id。例如：“00510023”等
        ///         
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        public string qsCourseId
        {
            get
            {
                if (Request.QueryString["CourseId"] != null)
                {
                    return Request.QueryString["CourseId"].ToString().Trim();
                }
                return "";
            }
        }
        protected void IndexChanging(object sender, EventArgs e)
        {
            string strCommand = ((LinkButton)sender).CommandArgument.ToString();

            int pageindex = vsPageIndex;

            switch (strCommand)
            {
                case "pre"://前一页

                    pageindex = pageindex - 1;
                    break;
                case "next":
                    pageindex = pageindex + 1;
                    break;
                case "FirstPage":
                    pageindex = 0;
                    break;
                case "LastPage":
                    pageindex = 10000;
                    break;
            }

            vsPageIndex = pageindex;

            BindDl_CMFunction(vsWhereCond);
            //BindDl_dlQuestionTypeNum();

        }
      
        /// <summary>
        /// 函数功能：按章重序 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReOrderByChapter_Click(object sender, System.EventArgs e)
        {

            //arrQuestionID.Add(strQuestionID);
            //try
            //{
            //    clsCMFunctionBLEx.ReOrderByCourseByChapter(getCourseId);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = objException.Message;
            //    clsCommonJsFunc.Alert(this, strMsg);
            //}
            BindDl_CMFunction(vsWhereCond);

            // this.ClientScript.RegisterStartupScript(this.GetType(), "UpMove", string.Format("this.location.href='#A{0}'",
            //strQuestionID), true);
        }

        /// <summary>
        /// 函数功能：按课程重序 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReOrderByCource_Click(object sender, System.EventArgs e)
        {

            //try
            //{
            //    clsCMFunctionBLEx.ReOrderByCourse(getCourseId);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = objException.Message;
            //    clsCommonJsFunc.Alert(this, strMsg);
            //}
            BindDl_CMFunction(vsWhereCond);

        }
        protected void lbAddQuestion_Click(object sender, EventArgs e)
        {
            vsOperate = "AddQuestionByCourse";
            //AddQuestionnaireRecord();

        }
        protected void chkIsShowChapterTv_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkIsShowChapterTv.Checked == false)
            //{
            //    //tdTree.Visible = false;
            //}
            //else
            //{
            //    //tdTree.Visible = true;
            //}

        }
        private void SetPager()
        {
            //Books book = new Books();  //Books是我一个操作数据库表的类
            //DataTable objTable = book.GetNewBooks(24);//book有个函数，返回结果是DataTable类型，大家根据自己的情况修改此处代码就行了。
            //if (objTable != null && objTable.Rows.Count > 0)
            //{
            //    DataView objView = objTable.DefaultView;
            //PagedDataSource objPds = new PagedDataSource();
            //objPds.DataSource = objView;


            //objPds.AllowPaging = true;
            //objPds.PageSize = 10;
            if (vsPageIndex >= vsPageCount)
            {
                vsPageIndex = vsPageCount - 1;
            }
            //objPds.CurrentPageIndex = vsPageIndex;// int.Parse(ViewState["pageindex"].ToString());


            lblRecCount.Text = vsRecCount.ToString();
            lblRecCount2.Text = vsRecCount.ToString();

            //当前页数
            lblAllPages.Text = vsPageCount.ToString();
            lblAllPages2.Text = vsPageCount.ToString();
            //当前页序数
            lblCurrentPage.Text = vsPageIndex.ToString();
            lblCurrentPage2.Text = vsPageIndex.ToString();
            ////当前即将跳到的页序数
            //txtJump2Page.Text = (this.gvtz_ContentAttachment.PageIndex + 1).ToString();

            //int ii = objPds.FirstIndexInPage;
            if (vsPageIndex != 1)
            {
                lkPre.Enabled = true;
                lbFirstPage.Enabled = true;
            }
            else
            {
                lkPre.Enabled = false;
                lbFirstPage.Enabled = false;
            }

            if (vsPageIndex != vsPageCount)
            {
                lkNext.Enabled = true;
                lbLastPage.Enabled = true;
            }
            else
            {
                lkNext.Enabled = false;
                lbLastPage.Enabled = false;
            }
            //try
            //{
            //    BindDl_CMFunction(vsWhereCond);
            //    //this.dlCMFunction.DataSource = objPds;
            //    //this.dlCMFunction.DataBind();
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = string.Format("绑定DataList不成功!错误:{0}.(In {1})",
            //        objException.Message, clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}
        }

        protected void dlCMFunction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnEditPara_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdate4Gv_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnDelete4Gv_Click(object sender, EventArgs e)
        {

        }

        protected void btnCloneNewRec4Gv_Click(object sender, EventArgs e)
        {

        }
    }
}