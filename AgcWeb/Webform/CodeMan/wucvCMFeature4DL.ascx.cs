
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucCMFeatureB
表名:CMFeature
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
    using AGC.BusinessLogic;
    using AGC.FunClass;
    using CommFunc4WebForm;
    using System.Collections.Generic;
    using BusinessLogicEx;
    using System.Text;
    
    using System.Linq;

    /// <summary>
    ///		wucCMFeatureB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucvCMFeature4DL : System.Web.UI.UserControl
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
            //this.dlCMFeature.PageIndex = 0;
            ////把表记录的内容显示在GridView中
            //BindDl_CMFeature();
        }

     
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// </summary>
        public void BindDl_CMFeature(string strWhereCond)
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            vsFuncModuleName = "";
            int intRecCount = 0;
            int intPageCount = 0;
            IEnumerable<clsvCMFeatureEN> arrvCMFeature = null;
            List<clsvCMFeatureENEx> arrvCMFeatureEx = null;
            try
            {
                vsWhereCond = strWhereCond;
                intRecCount = clsvCMFeatureBL.GetRecCountByCond(vsWhereCond);
                vsRecCount = intRecCount;
                intPageCount = GetPageCount(intRecCount, vsPageSize);
                vsPageCount = intPageCount;
                //	2、根据条件串获取该表满足条件的DataTable；
                arrvCMFeature = clsvCMFeatureBL.GetObjLstByPager(vsPageIndex, vsPageSize, strWhereCond, vsSortCMFeatureBy);
                arrvCMFeatureEx = arrvCMFeature.Select(clsvCMFeatureBLEx.CopyToEx)
                    .OrderBy(x => x.FuncModuleAgcId).ThenBy(x => x.OrderNum).ToList();
                arrvCMFeatureEx.ForEach(x => x.FeatureDescription = clsWebString.HtmlEncode(x.FeatureDescription.TrimStart(" \t".ToCharArray())));
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WucL000001)获取数据表(DataTable)不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            //DataView objDV = objDT.DefaultView;
            //objDV.Sort = vsSortCMFeatureBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
            //                                 ///设置GridView中每页的记录数
            //if (vsPageSize > 0)
            //{
            //    int intPageSize = vsPageSize;
            //    dlCMFeature.PageSize = intPageSize;
            //}
            //else
            //{
            //    vsPageSize = 15;
            //    dlCMFeature.PageSize = vsPageSize;
            //}
            this.dlCMFeature.DataSource = arrvCMFeatureEx;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.dlCMFeature.DataBind();
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
                    BindDl_CMFeature(vsWhereCond);
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


        public string vsCmPrjId
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


        #endregion 查询相关函数


        #region 排序相关函数
        /// <summary>
        /// 事件函数:在GridView中，单击列头进行排序所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void dlCMFeature_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortCMFeatureBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortCMFeatureBy = e.SortExpression + " Asc";
                BindDl_CMFeature(vsWhereCond);
                return;
            }
            //检查原来是升序
            intIndex = vsSortCMFeatureBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortCMFeatureBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortCMFeatureBy = e.SortExpression + " Desc";
            }
            BindDl_CMFeature(vsWhereCond);
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortCMFeatureBy
        {
            get
            {
                string sSortCMFeatureBy;
                sSortCMFeatureBy = (string)ViewState["SortCMFeatureBy"];
                if (sSortCMFeatureBy == null)
                {
                    sSortCMFeatureBy = "";
                }
                return sSortCMFeatureBy;
            }
            set
            {
                string sSortCMFeatureBy = value;
                ViewState.Add("SortCMFeatureBy", sSortCMFeatureBy);
            }
        }
        public void SetSortBy(string strSortBy)
        {
            vsSortCMFeatureBy = strSortBy;
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
        //    List<string> lstCmFeatureId = clsCommForWebForm.GetFirstCheckedItemFromGv(dlCMFeature, clsCMFeatureEN.con_CmFeatureId);
        //    if (lstCmFeatureId.Count == 0)
        //    {
        //        clsCommonJsFunc.Alert(this, "(errid:WebI000015)没有选择记录,请选择有效的表记录!");
        //        return "";
        //    }

        //    //1、显示该关键字的数据让用户修改该关键字记录；
        //    string strCmFeatureId = lstCmFeatureId[0];
        //    return strCmFeatureId;
        //}
        /// <summary>
        ///从列表中获取所有选择的关键字
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetAllCheckedKeysFromGv)
        /// </summary>/// <returns>返回所有选择的关键字列表</returns>
        //public List<string> GetAllCheckedKeysFromGv()
        //{
        //    List<string> lstCmFeatureId = clsCommForWebForm.GetAllCheckedItemFromGv(dlCMFeature, "chkCheckRec", clsCMFeatureEN.con_CmFeatureId);
        //    if (lstCmFeatureId.Count == 0)
        //    {
        //        clsCommonJsFunc.Alert(this, "(errid:WebI000016)没有选择记录,请选择有效的表记录!");
        //        return null;
        //    }
        //    return lstCmFeatureId;
        //}
        public bool SetCheckedItemForGv(string strCmFeatureId)
        {
            //clsCommForWebForm.SetCheckedItemForGv(dlCMFeature, 1, strCmFeatureId);
            return true;
        }

        public void SetVisible(bool bolVisible)
        {
            dlCMFeature.Visible = bolVisible;
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strCmFeatureId">给定关键字</param>
        protected void DeleteCMFeatureRecord(string strCmFeatureId)
        {
            try
            {
                clsCMFeatureBL.DelRecord(strCmFeatureId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }

            string strWhereCond = vsWhereCond;
            BindDl_CMFeature(vsWhereCond);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateCMFeatureRecord(string strCmFeatureId)
        {
            ////操作步骤:(总共2步)
            ////1、显示该关键字记录的内容在界面上；
            ////2、清空提示信息的内容,同时使<确定修改>按钮可用；

            ////1、显示该关键字记录的内容在界面上；
            //ShowData(strCmFeatureId);
            ////2、清空提示信息的内容,同时使<确定修改>按钮可用；
            //btnOKUpd.Enabled = true;
            //wucCMFeatureB1.SetKeyReadOnly(true);
            //btnOKUpd.Text = "确认修改";
            //btnCancelCMFeatureEdit.Text = "取消修改";
            //lblMsgEdit.Text = "";
            //DispEditCMFeatureRegion();
        }
        /// <summary>
        /// 设置GridView可视性
        /// </summary>
        /// <param name="strColumnName">列名 or 字段名</param>
        /// <param name="bolIsVisible">是否可见</param>
        //public void SetGvVisibility(string strColumnName, bool bolIsVisible)
        //{
        //    clsCommForWebForm.SetGvVisibility(dlCMFeature, strColumnName, bolIsVisible);
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

        protected void dlCMFeature_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            ///找到添加控件的Panel
            // Panel ItemPanel = (Panel)e.Item.FindControl("ItemPanel");
            DataList oblDataList = (DataList)sender;
            if (e.Item.ItemIndex < 0)
            {
                return;
            }
          
            clsvCMFeatureEN objvCMFeatureEN = (clsvCMFeatureEN)e.Item.DataItem;
            if (objvCMFeatureEN == null) return;
            //objvCMFeatureEN.QuestionID = strQuestionID;
            ////StringBuilder sbCondition = new StringBuilder();
            ////sbCondition.AppendFormat( "QuestionID='{0}'", strQuestionID);

            //clsvCMFeatureBL.GetvCMFeature(ref objvCMFeatureEN);

            //string strAnswerTypeId = "";

            Literal litTR4FuncModule = (Literal)e.Item.FindControl("litTR4FuncModule");
            if (vsFuncModuleName != objvCMFeatureEN.FuncModuleName)
            {
                StringBuilder sbTR1 = new StringBuilder();
                //sbTR.Append("<table>");
                sbTR1.Append("<tr>");
                sbTR1.Append("<td colspan=\"2\" class=\"h5 mb-2\">");
                sbTR1.AppendFormat("<div class=\"mb-2\">{0}</div>", objvCMFeatureEN.FuncModuleName);
                sbTR1.Append("</td>");
                sbTR1.Append("</tr>");
                //sbTR.Append("</table>");
                vsFuncModuleName = objvCMFeatureEN.FuncModuleName;
                litTR4FuncModule.Text = sbTR1.ToString();

            }
            if (objvCMFeatureEN.CmReqCount>0)
            {

                Literal litRelaRequirement = (Literal)e.Item.FindControl("litRelaRequirement");
                List<clsvCMFeatureRequirementEN> arrvCMFeatureRequirement = clsvCMFeatureRequirementBLEx.GetObjLstByCmFeatureIdCache(objvCMFeatureEN.CmFeatureId, objvCMFeatureEN.PrjId)
                    .OrderBy(x=>x.OrderNum)
                    .ToList();
                if (arrvCMFeatureRequirement.Count()>0)
                {
                    StringBuilder sbTR1 = new StringBuilder();
                    int intOrder = 1;
                    arrvCMFeatureRequirement.ToList().ForEach(x => { 
                    sbTR1.Append("<tr>");
                    sbTR1.AppendFormat("<td style=\"text-align:right; vertical-align: top;\" class=\"text-info\">需求:{0}</td>", intOrder ++);
                    sbTR1.Append("<td class=\"mb-2\">");
                    sbTR1.AppendFormat("<div class=\"mb-2\"><span class=\"text-info\"><strong>{0}</strong></span><br/><span class=\"text-secondary\">{1}</span></div>", x.RequirementName, x.ReqContent);
                    sbTR1.Append("</td>");
                    sbTR1.Append("</tr>");
                    });
                
                    litRelaRequirement.Text = sbTR1.ToString();

                }
            }

            Literal litTR = (Literal)e.Item.FindControl("litTR");
            if (string.IsNullOrEmpty(objvCMFeatureEN.CmParentFeatureId) == true)
            {
                StringBuilder sbTR = new StringBuilder();
                sbTR.Append("<ul class=\"nav\">");
                sbTR.AppendFormat("<li class=\"nav-item ml-1\"><strong>{0}、{1}({2})</strong></li>", objvCMFeatureEN.OrderNum, objvCMFeatureEN.FeatureName, objvCMFeatureEN.CmFeatureId);
                if (string.IsNullOrEmpty(objvCMFeatureEN.KeyWords) == false)
                {
                    sbTR.Append("<li class=\"nav-item ml-3\">关键字:</li>");
                    sbTR.AppendFormat("<li class=\"nav-item ml-1\">{0}", objvCMFeatureEN.KeyWords);
                }
                if (objvCMFeatureEN.CmReqCount > 0)
                {
                    sbTR.Append("<li class=\"nav-item ml-3\">需求数:</li>");
                    sbTR.AppendFormat("<li class=\"nav-item ml-1\">{0}", objvCMFeatureEN.CmReqCount);
                }

                //sbTR.Append("<li class=\"nav-item ml-3\">模块:</li>");
                //sbTR.AppendFormat("<li class=\"nav-item ml-1\">{0}", objvCMFeatureEN.FuncModuleName);
                //sbTR.Append("</li>");
                sbTR.Append("<li class=\"nav-item ml-3\">用户:</li>");
                sbTR.AppendFormat("<li class=\"nav-item ml-1\">{0}", objvCMFeatureEN.UpdUser);
                sbTR.Append("</li>");
                sbTR.Append("<li class=\"nav-item ml-3\">日期:</li>");
                sbTR.AppendFormat("<li class=\"nav-item ml-1\">{0}", clsDateTime.getDateStr(objvCMFeatureEN.UpdDate, 2));
                sbTR.Append("</li>");
                sbTR.Append("<li class=\"nav-item ml-3\"></li>");
                sbTR.Append("</ul>");
                litTR.Text = sbTR.ToString();
            }
            else
            {
                StringBuilder sbTR = new StringBuilder();
                sbTR.Append("<ul class=\"nav\">");
                sbTR.AppendFormat("<li class=\"nav-item ml-1\">{0}、{1}({2})</li>", objvCMFeatureEN.OrderNum, objvCMFeatureEN.FeatureName, objvCMFeatureEN.CmFeatureId);

                sbTR.Append("</ul>");
                litTR.Text = sbTR.ToString();
            }
            Button btnUpdate = (Button)e.Item.FindControl("btnUpdate");
            Button btnDelete = (Button)e.Item.FindControl("btnDelete");
            Button btnClone = (Button)e.Item.FindControl("btnClone");
            if (vsOperate == "Edit")
            {
                btnClone.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;

            }
            else
            {
                btnClone.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;

            }
        }

        protected void dlCMFeature_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string strCmFeatureId = e.CommandArgument.ToString();
            string strMsg;
            //hidvalue.Value = ExamID;
            try
            {
                List<string> arrCmFeatureId = new List<string>();
                switch (e.CommandName)
                {
                    case "Update":
                        if (DlUpdateClick != null)
                        {
                            clsEventArgs4Update objEventArgs4Update = new clsEventArgs4Update()
                            {
                                KeyId = strCmFeatureId.ToString()
                            };
                            DlUpdateClick(this, objEventArgs4Update);
                        }
                        break;
                    case "Delete":
                        if (DlDeleteClick != null)
                        {
                            clsEventArgs4Delete objEventArgs4Delete = new clsEventArgs4Delete()
                            {
                                KeyId = strCmFeatureId.ToString()
                            };
                            DlDeleteClick(this, objEventArgs4Delete);
                        }
                        break;
                    case "Clone":
                        if (DlCloneClick != null)
                        {
                            clsEventArgs4Clone objEventArgs4Clone = new clsEventArgs4Clone()
                            {
                                KeyId = strCmFeatureId.ToString()
                            };
                            DlCloneClick(this, objEventArgs4Clone);
                        }
                        break;
                    case "GoTop":
                        clsCMFeatureBLEx.GoTopEx(new List<string> { strCmFeatureId });
                        BindDl_CMFeature(vsWhereCond);
                        break;
                    case "GoBottum":
                        clsCMFeatureBLEx.GoBottomEx(new List<string> { strCmFeatureId });
                        BindDl_CMFeature(vsWhereCond);
                        break;
                    case "UpMove":
                        clsCMFeatureBLEx.AdjustOrderNumEx("UP", strCmFeatureId);
                        BindDl_CMFeature(vsWhereCond);
                        break;
                    case "DownMove":
                        clsCMFeatureBLEx.AdjustOrderNumEx("DOWN", strCmFeatureId);
                        BindDl_CMFeature(vsWhereCond);
                        break;
                    case "ReOrder":
                        clsCMFeatureBLEx.ReOrderEx(strCmFeatureId);
                        BindDl_CMFeature(vsWhereCond);
                        break;
                    case "EditPara":
                        if (DlEditParaClick != null)
                        {
                            clsEventArgs4EditPara objEventArgs4EditPara = new clsEventArgs4EditPara()
                            {
                                KeyId = strCmFeatureId.ToString()
                            };
                            DlEditParaClick(this, objEventArgs4EditPara);
                        }
                        break;

                    case "EditQuestion":
                        vsOperate = "EditQuestionByCourse";
                        UpdateCMFeatureRecord(strCmFeatureId);
                        break;
                    case "CloneQuestion":



                        break;

                    default:
                        strMsg = string.Format("命令名称:{0}相应函数中没有被处理，请检查！{1}",
                          e.CommandName, clsStackTrace.GetCurrClassFunction());
                        clsCommonJsFunc.Alert(this, strMsg);
                        break;
                }
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
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
        /// 模块名
        /// </summary>
        public string vsFuncModuleName
        {
            get
            {
                string strFuncModuleName;
                strFuncModuleName = (string)ViewState["FuncModuleName"];
                if (strFuncModuleName == null)
                {
                    strFuncModuleName = "";
                }
                return strFuncModuleName;
            }
            set
            {
                string strFuncModuleName = value;
                ViewState.Add("FuncModuleName", strFuncModuleName);
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
                    if (pageindex <=1)
                    {
                        clsCommonJsFunc.Alert(this, "已经是第一页！");
                        return;
                    }
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

            BindDl_CMFeature(vsWhereCond);
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
            //    clsCMFeatureBLEx.ReOrderByCourseByChapter(getCourseId);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = objException.Message;
            //    clsCommonJsFunc.Alert(this, strMsg);
            //}
            BindDl_CMFeature(vsWhereCond);

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
            //    clsCMFeatureBLEx.ReOrderByCourse(getCourseId);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = objException.Message;
            //    clsCommonJsFunc.Alert(this, strMsg);
            //}
            BindDl_CMFeature(vsWhereCond);

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
            if (vsPageIndex > vsPageCount)
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
            //    BindDl_CMFeature(vsWhereCond);
            //    //this.dlCMFeature.DataSource = objPds;
            //    //this.dlCMFeature.DataBind();
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = string.Format("绑定DataList不成功!错误:{0}.(In {1})",
            //        objException.Message, clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}
        }

        protected void dlCMFeature_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}