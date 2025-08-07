
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucConstraintFieldsB
表名:ConstraintFields
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
    ///		wucConstraintFieldsB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucConstraintFields4DL : System.Web.UI.UserControl
    {

        /// <summary>
        /// 在DataList中，单击[修改]按钮时，所引发的修改事件
        /// </summary>
        public event OnDlUpdateClick DlUpdateClick;
        ///// <summary>
        ///// 在DataList中，单击[删除]按钮时，所引发的修改事件
        ///// </summary>
        //public event OnDlDeleteClick DlDeleteClick;

        ///// <summary>
        ///// 在DataList中，单击[克隆]按钮时，所引发的修改事件
        ///// </summary>
        //public event OnDlCloneClick DlCloneClick;

        ///// <summary>
        ///// 在DataList中，单击[克隆]按钮时，所引发的修改事件
        ///// </summary>
        //public event OnDlEditParaClick DlEditParaClick;

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
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// </summary>
        public void BindDl_ConstraintFields(string strPrjConstraintId)
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            if (vsOperate == "Add")
            {
                //int intRecCount = 0;
                //int intPageCount = 0;
                List<clsConstraintFieldsEN> arrConstraintFields = vsArrConstraintFields;
                List<clsConstraintFieldsENEx> arrConstraintFieldsEx = arrConstraintFields
                    .Select(clsConstraintFieldsBLEx.CopyToEx)
                    .ToList();
                arrConstraintFieldsEx.ForEach(x=> { x.FldName = clsFieldTabBL.GetNameByFldIdCache(x.FldId, x.PrjId); });
                this.dlConstraintFields.DataSource = arrConstraintFieldsEx;
                //	5、绑定GridView,即把DataTable的内容显示在GridView中
                this.dlConstraintFields.DataBind();

            }
            else
            {
                int intRecCount = 0;
                int intPageCount = 0;
                IEnumerable<clsvConstraintFieldsEN> arrvConstraintFields = null;
                //List<clsvConstraintFieldsENEx> arrvConstraintFieldsEx = null;
                try
                {
                    vsWhereCond = string.Format("{0}='{1}' and {2}='1'",
                        convConstraintFields.PrjConstraintId, strPrjConstraintId,
                        convConstraintFields.InUse);
                    intRecCount = clsvConstraintFieldsBL.GetRecCountByCond(vsWhereCond);
                    vsRecCount = intRecCount;
                    intPageCount = GetPageCount(intRecCount, vsPageSize);
                    vsPageCount = intPageCount;
                    //	2、根据条件串获取该表满足条件的DataTable；
                    arrvConstraintFields = clsvConstraintFieldsBL.GetObjLstByPager(vsPageIndex, vsPageSize, vsWhereCond, vsSortConstraintFieldsBy);
                }
                catch (Exception objException)
                {
                    seErrMessage = "(errid:WucL000001)获取数据表(DataTable)不成功!" + objException.Message;
                    seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    Response.Redirect(clsSysParaEN.ErrorPage);
                }

                this.dlConstraintFields.DataSource = arrvConstraintFields;
                //	5、绑定GridView,即把DataTable的内容显示在GridView中
                this.dlConstraintFields.DataBind();

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
        protected void dlConstraintFields_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortConstraintFieldsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortConstraintFieldsBy = e.SortExpression + " Asc";
                BindDl_ConstraintFields(vsPrjConstraintId);
                return;
            }
            //检查原来是升序
            intIndex = vsSortConstraintFieldsBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortConstraintFieldsBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortConstraintFieldsBy = e.SortExpression + " Desc";
            }
            BindDl_ConstraintFields(vsPrjConstraintId);
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortConstraintFieldsBy
        {
            get
            {
                string sSortConstraintFieldsBy;
                sSortConstraintFieldsBy = (string)ViewState["SortConstraintFieldsBy"];
                if (sSortConstraintFieldsBy == null)
                {
                    sSortConstraintFieldsBy = "";
                }
                return sSortConstraintFieldsBy;
            }
            set
            {
                string sSortConstraintFieldsBy = value;
                ViewState.Add("SortConstraintFieldsBy", sSortConstraintFieldsBy);
            }
        }
        public void SetSortBy(string strSortBy)
        {
            vsSortConstraintFieldsBy = strSortBy;
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
        //    List<string> lstmId = clsCommForWebForm.GetFirstCheckedItemFromGv(dlConstraintFields, clsConstraintFieldsEN.con_mId);
        //    if (lstmId.Count == 0)
        //    {
        //        clsCommonJsFunc.Alert(this, "(errid:WebI000015)没有选择记录,请选择有效的表记录!");
        //        return "";
        //    }

        //    //1、显示该关键字的数据让用户修改该关键字记录；
        //    string strmId = lstmId[0];
        //    return strmId;
        //}
        /// <summary>
        ///从列表中获取所有选择的关键字
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetAllCheckedKeysFromGv)
        /// </summary>/// <returns>返回所有选择的关键字列表</returns>
        //public List<string> GetAllCheckedKeysFromGv()
        //{
        //    List<string> lstmId = clsCommForWebForm.GetAllCheckedItemFromGv(dlConstraintFields, "chkCheckRec", clsConstraintFieldsEN.con_mId);
        //    if (lstmId.Count == 0)
        //    {
        //        clsCommonJsFunc.Alert(this, "(errid:WebI000016)没有选择记录,请选择有效的表记录!");
        //        return null;
        //    }
        //    return lstmId;
        //}
        public bool SetCheckedItemForGv(string strmId)
        {
            //clsCommForWebForm.SetCheckedItemForGv(dlConstraintFields, 1, strmId);
            return true;
        }

        public void SetVisible(bool bolVisible)
        {
            dlConstraintFields.Visible = bolVisible;
        }

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strmId">给定关键字</param>
        protected void DeleteConstraintFieldsRecord(string strmId)
        {
            try
            {
                clsConstraintFieldsBL.DelRecord(long.Parse( strmId));
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }

            string strWhereCond = vsWhereCond;
            BindDl_ConstraintFields(vsPrjConstraintId);
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateConstraintFieldsRecord(string strmId)
        {
            ////操作步骤:(总共2步)
            ////1、显示该关键字记录的内容在界面上；
            ////2、清空提示信息的内容,同时使<确定修改>按钮可用；

            ////1、显示该关键字记录的内容在界面上；
            //ShowData(strmId);
            ////2、清空提示信息的内容,同时使<确定修改>按钮可用；
            //btnOKUpd.Enabled = true;
            //wucConstraintFieldsB1.SetKeyReadOnly(true);
            //btnOKUpd.Text = "确认修改";
            //btnCancelConstraintFieldsEdit.Text = "取消修改";
            //lblMsgEdit.Text = "";
            //DispEditConstraintFieldsRegion();
        }
        /// <summary>
        /// 设置GridView可视性
        /// </summary>
        /// <param name="strColumnName">列名 or 字段名</param>
        /// <param name="bolIsVisible">是否可见</param>
        //public void SetGvVisibility(string strColumnName, bool bolIsVisible)
        //{
        //    clsCommForWebForm.SetGvVisibility(dlConstraintFields, strColumnName, bolIsVisible);
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

        protected void dlConstraintFields_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            ///找到添加控件的Panel
            // Panel ItemPanel = (Panel)e.Item.FindControl("ItemPanel");
            DataList oblDataList = (DataList)sender;
            if (e.Item.ItemIndex < 0)
            {
                return;
            }
          
            //clsvConstraintFieldsEN objvConstraintFieldsEN = (clsvConstraintFieldsEN)e.Item.DataItem;
            //if (objvConstraintFieldsEN == null) return;
            //objvConstraintFieldsEN.QuestionID = strQuestionID;
            ////StringBuilder sbCondition = new StringBuilder();
            ////sbCondition.AppendFormat( "QuestionID='{0}'", strQuestionID);

            //clsvConstraintFieldsBL.GetvConstraintFields(ref objvConstraintFieldsEN);

            //string strAnswerTypeId = "";

            Literal litTR4FuncModule = (Literal)e.Item.FindControl("litTR4FuncModule");
        
            Literal litTR = (Literal)e.Item.FindControl("litTR");      
      
            Button btnDelete = (Button)e.Item.FindControl("btnDelete");
      
            if (vsOperate == "Edit")
            {      
                btnDelete.Visible = true;
            }
            else
            {      
                btnDelete.Visible = false;
            }
        }

        protected void dlConstraintFields_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string strmId = e.CommandArgument.ToString();
            long lngMid = long.Parse(strmId);
            string strMsg;
            //hidvalue.Value = ExamID;
            try
            {
                List<string> arrmId = new List<string>();
                switch (e.CommandName)
                {
                    case "Update":
                        if (DlUpdateClick != null)
                        {
                            clsEventArgs4Update objEventArgs4Update = new clsEventArgs4Update()
                            {
                                KeyId = strmId.ToString()
                            };
                            DlUpdateClick(this, objEventArgs4Update);
                        }
                        break;
                    case "Delete":

                        DeleteConstraintFieldsRecord(long.Parse( strmId));
                       
                        break;
                    case "UpMove":
                        clsConstraintFieldsBL.AdjustOrderNum("UP", lngMid, vsPrjConstraintId);
                        BindDl_ConstraintFields(vsPrjConstraintId);
                        break;
                    case "DownMove":
                        clsConstraintFieldsBLEx.AdjustOrderNum("DOWN", lngMid, vsPrjConstraintId);
                        BindDl_ConstraintFields(vsPrjConstraintId);
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
        /// 根据给定关键字删除记录
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_DelRecord)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteConstraintFieldsRecord(long lngmId)
        {
            try
            {
                clsConstraintFieldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000122)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);                
                return;
            }
            BindDl_ConstraintFields(vsPrjConstraintId);
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
        public string vsPrjConstraintId
        {
            get
            {
                string strPrjConstraintId;
                strPrjConstraintId = (string)ViewState["PrjConstraintId"];
                if (strPrjConstraintId == null)
                {
                    strPrjConstraintId = "";
                }
                return strPrjConstraintId;
            }
            set
            {
                string strPrjConstraintId = value;
                ViewState.Add("PrjConstraintId", strPrjConstraintId);
                if (string.IsNullOrEmpty(value) == false)
                {
                    clsPrjConstraintEN objPrjConstraint = clsPrjConstraintBL.GetObjByPrjConstraintIdCache(value, clsPubVar.CurrSelPrjId);
                    lblConstraintName.Text = string.Format("约束:{0}的字段列表如下:", objPrjConstraint.ConstraintName);
                    //lblConstraintTypeName.Text = clsConstraintTypeBL.GetNameByConstraintTypeIdCache(objPrjConstraint.ConstraintTypeId);
                }
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
        /// 课程Id（用于记录用户自己选择的课程Id)
        /// </summary>
        public string vsTabId
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
                if (string.IsNullOrEmpty(value) == false)
                {
                    clsFieldTabBLEx.BindDdl_FldIDByTabIdEx(ddlFldId, clsPubVar.CurrSelPrjId, value);
                }
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

           
        }

        protected void dlConstraintFields_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ddlFldId.SelectedIndex<=0)
            {
                clsCommonJsFunc.Alert(this, "请选择字段！");
                return;
            }
            string strFldId = ddlFldId.SelectedValue;
            clsConstraintFieldsEN pobjConstraintFieldsEN = new clsConstraintFieldsEN()
                //.SetPrjConstraintId(vsPrjConstraintId)// 约束表Id
            .SetTabId(clsCommonSession.qsTabId)// 表ID
            .SetPrjId(clsPubVar.CurrSelPrjId)// 表ID
            .SetFldId(strFldId)// 字段Id
            .SetInUse(true)// 字段Id
            .SetSortTypeId(enumSortType.AscendingOrder_01)// 排序类型Id
            .SetMaxValue("0")
            .SetMinValue("0")
            .SetOrderNum(100)
            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))// 修改日期
            .SetUpdUser(clsCommonSession.UserId)// 修改者
            .SetMemo("");// 说明
            if (vsOperate == "Add")
            {
                List<clsConstraintFieldsEN> arrConstraintFields = vsArrConstraintFields;
                pobjConstraintFieldsEN.OrderNum = arrConstraintFields.Count + 1;
                arrConstraintFields.Add(pobjConstraintFieldsEN);
                vsArrConstraintFields = arrConstraintFields;
                List<clsConstraintFieldsENEx> arrConstraintFieldsEx = arrConstraintFields
                 .Select(clsConstraintFieldsBLEx.CopyToEx)
                 .ToList();
                arrConstraintFieldsEx.ForEach(x => { x.FldName = clsFieldTabBL.GetNameByFldIdCache(x.FldId, x.PrjId); });
                IEnumerable<string> arrFldName = arrConstraintFieldsEx.Select(x=>x.FldName);
                string strFldNames = string.Join("_", arrFldName);
                ConstraintName = strFldNames;
                ConstraintDescription = strFldNames;
                List<string> arrFldId = arrConstraintFields.Select(x=>x.FldId).ToList();
                clsFieldTabBLEx.BindDdl_FldIDByTabIdEx(ddlFldId, clsPubVar.CurrSelPrjId, clsCommonSession.qsTabId, arrFldId);
            }
            else
            {
                pobjConstraintFieldsEN
                    .SetPrjConstraintId(vsPrjConstraintId)// 约束表Id
                    .EditRecordEx();
                clsConstraintFieldsBL.ReOrder(vsPrjConstraintId);
            }
            BindDl_ConstraintFields(vsPrjConstraintId);
        }


        /// <summary>
        /// 约束表Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string PrjConstraintId
        {
            get
            {
                return vsPrjConstraintId;
            }
            set
            {
                vsPrjConstraintId = value.ToString();
            }
        }

        /// <summary>
        /// 约束表名称
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ConstraintName
        {
            get
            {
                return txtConstraintName.Text.Trim();
            }
            set
            {
                txtConstraintName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 工程ID
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string PrjId
        {
            get
            {
                return clsPubVar.CurrSelPrjId;
            }

        }

        /// <summary>
        /// 表ID
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string TabId
        {
            get
            {
                if (ddlTabId.SelectedValue == "0")
                    return "";
                return ddlTabId.SelectedValue;
            }
            set
            {
                if (ddlTabId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTabId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlTabId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 约束类型Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ConstraintTypeId
        {
            get
            {
                if (ddlConstraintTypeId.SelectedValue == "0")
                    return "";
                return ddlConstraintTypeId.SelectedValue;
            }
            set
            {
                if (ddlConstraintTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlConstraintTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlConstraintTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 约束说明
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ConstraintDescription
        {
            get
            {
                return txtConstraintDescription.Text.Trim();
            }
            set
            {
                txtConstraintDescription.Text = value.ToString();
            }
        }

        /// <summary>
        /// 建立用户Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string CreateUserId
        {
            get
            {
                return clsCommonSession.UserId;
            }
        }

        /// <summary>
        /// 是否在用
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public bool InUse
        {
            get
            {
                if (ddlInUse.SelectedIndex == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    if (ddlInUse.Items.Count > 0)
                    {
                        ddlInUse.SelectedIndex = 1;
                    }
                    else
                    {
                        ddlInUse.SelectedIndex = 2;
                    }
                }
            }
        }

        /// <summary>
        /// 修改日期
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string UpdDate
        {
            get
            {
                return clsDateTime.getTodayDateTimeStr(1);
            }
        }

        /// <summary>
        /// 修改者
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string UpdUser
        {
            get
            {
                return clsCommonSession.UserId;
            }
        }

        /// <summary>
        /// 说明
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string Memo
        {
            get
            {
                return txtMemo.Text.Trim();
            }
            set
            {
                txtMemo.Text = value.ToString();
            }
        }


        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            //txtPrjConstraintId.ReadOnly = bolReadonly;
        }


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            //txtPrjConstraintId.Text = "";
            txtConstraintName.Text = "";
            if (trHidden.Visible == true)
            {
                ddlTabId.SelectedIndex = 0;
            }
            ddlConstraintTypeId.SelectedIndex = 0;
            txtConstraintDescription.Text = "";

            txtMemo.Text = "";
        }


        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则:
        ///		1、首先校验类型:整型、浮点型、日期型等,
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值,即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_IsValid)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            return true;
        }


        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则:
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetDefaultValue)
        /// </summary>
        public void SetDefaultValue()
        {
            //txtPrjConstraintId.Text = "";
            txtConstraintName.Text = "";
            ddlTabId.SelectedIndex = 0;
            ddlConstraintTypeId.SelectedIndex = 0;
            txtConstraintDescription.Text = "";

            ddlInUse.SelectedIndex = 0;

            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[PrjTab]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetTabId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TabId, TabName from PrjTab ";
            clsSpecSQLforSql mySql = clsPrjTabBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTabId();
            objDDL.DataValueField = conPrjTab.TabId;
            objDDL.DataTextField = conPrjTab.TabName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[ConstraintType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetConstraintTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ConstraintTypeId, ConstraintTypeName from ConstraintType ";
            clsSpecSQLforSql mySql = clsConstraintTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[TabId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_TabId()
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabId, clsPubVar.CurrSelPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[ConstraintTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ConstraintTypeId()
        {
            clsConstraintTypeBL.BindDdl_ConstraintTypeIdCache(ddlConstraintTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[InUse]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_InUse()
        {
            clsCommForWebForm.BindDdl_TrueAndFalse(ddlInUse);

        }
        public List<clsConstraintFieldsEN> vsArrConstraintFields
        {
            get
            {
                List<clsConstraintFieldsEN> arrConstraintFields;
                arrConstraintFields = (List<clsConstraintFieldsEN>)ViewState["arrConstraintFields"];
                if (arrConstraintFields == null) arrConstraintFields = new List<clsConstraintFieldsEN>();
                return arrConstraintFields;
            }
            set
            {
                List<clsConstraintFieldsEN> sarrConstraintFields = value;
                ViewState.Add("arrConstraintFields", sarrConstraintFields);
            }
        }
        public void HiddenTrTabId()
        {
            trHidden.Visible = false;
        }
    }
}