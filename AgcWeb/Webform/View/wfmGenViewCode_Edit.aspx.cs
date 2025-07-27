
///生成查询，修改，删除，添加记录的控制层代码
using System;
using System.Collections.Generic;
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
using com.taishsoft.common;
using com.taishsoft.json;
//using SqlSv; 
using CommFunc4WebForm;


namespace AGC.Webform
{
    /// <summary>
    /// wfmGenViewCode 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmGenViewCode_Edit : CommBasePage4CallbackEventHandler
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                ///隐藏应该隐藏的控件内容
                ///
                if (clsCommForWebForm.SystemStatus == "DEBUG")
                {

                }
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(getViewId, clsPubVar.CurrSelPrjId);
                vsApplicationTypeId = objViewInfo.ApplicationTypeId;
                clsApplicationTypeEN obj = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(vsApplicationTypeId);
                lblPageTitle.Text = string.Format("应用:{0}({2}) 界面",
                    obj.ApplicationTypeName, obj.ApplicationTypeENName, obj.ApplicationTypeId);

                if (string.IsNullOrEmpty( qsRegionId) == false)
                {
                    clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionIdCache(qsRegionId, clsPubVar.CurrSelPrjId);
                    vsvViewRegion = objvViewRegionEN;
                }
                myIframe1.Src = string.Format("wfmPreviewViewRegion_Edit.aspx?ViewId={0}", getViewId);
                               
            }
            ShowCodeTypeButton();
            
        }
        
        private void ShowCodeTypeButton()
        {


      
            //FlowLayoutPanel objFLP = getflowLayoutPanel();
            //if (objFLP == null)
            //{
            //    MessageBox.Show("在当前Tab中没有找到相应的FlowLayoutPanel");
            //    return;
            //}
            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(getViewId, clsPubVar.CurrSelPrjId);
            vsApplicationTypeId = objViewInfo.ApplicationTypeId;

            pnlCodeTypeLst.Controls.Clear();
            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(vsApplicationTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
           
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(vsApplicationTypeId);
            arrObjLst.ForEach(x => {
                string strGroupName1 = x.GroupName;
                string[] arrGroupName1 = strGroupName1.Split(",".ToCharArray());
                x.GroupName = arrGroupName1[0];
            });
            arrObjLst = arrObjLst                
                .OrderBy(x=>x.GroupName).ThenBy(x=>x.OrderNum)
                .ToList();
                       
            int intCount = 0;
            //string strGroupName = "";
            IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_V2 = arrObjLst.Where(x=>x.DependsOn == "View");
            if (vsvViewRegion != null)
            {
                arrObjLst_V2 = arrObjLst_V2.Where(x=>x.RegionTypeId == vsvViewRegion.RegionTypeId).OrderBy(x=>x.OrderNum);
            }
            List<string> arrGroupName = arrObjLst_V2.Select(x=>x.GroupName).Distinct().ToList();
            bool bolIsFirst = true;
            foreach (string strGroupName in arrGroupName)
            {
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
                    
                    Label objLabel = new Label();
                    objLabel.Text = string.Format("{0}: ", strGroupName);
                    //objLabel.AutoSize = true;
                    objLabel.ID = string.Format("lbl{0}", strGroupName);
                    //string strToolTip = string.Format("生成：[{0}({1})({2})]的代码。", objInFor.CodeTypeName, objInFor.CodeTypeId, objInFor.ProgLangTypeId4CodeType);
                    //toolTip1.SetToolTip(objLabel, strToolTip);                    
                    objLabel.CssClass = "text-secondary font-weight-bold";
                    objLabel.Attributes["style"] = "margin-right:10px;margin-top:35px;left:0px;width:150px;";
                    pnlCodeTypeLst.Controls.Add(objLabel);
                }
                foreach (clsvAppCodeTypeRelaENEx objInFor in arrObjLst_V2)
                {
                    if (objInFor.GroupName != strGroupName) continue;
                                 

                    Button objButton = new Button();
                    objButton.Text = string.Format("{0}({1})",
                        objInFor.CodeTypeName, objInFor.ProgLangTypeName);
                    //objButton.AutoSize = true;
                    objButton.ID = string.Format("btn{0}", objInFor.CodeTypeId);
                    //string strToolTip = string.Format("生成：[{0}({1})({2})]的代码。", objInFor.CodeTypeName, objInFor.CodeTypeId, objInFor.ProgLangTypeId4CodeType);
                    //toolTip1.SetToolTip(objButton, strToolTip);


                    objButton.Click += btnCodeType_Click;
                    objButton.CssClass = "btn btn-outline-primary btn-sm";
                    objButton.Attributes["Style"] = "margin-right:10px;margin-top:5px;left:0px;";
                    //pnlCodeTypeLst.Controls.Add(objButton);

                    HtmlInputButton objHtmlInputButton = new HtmlInputButton();
                    objHtmlInputButton.ID = string.Format("btn{0}1", objInFor.CodeTypeId); 

                    objHtmlInputButton.Name = string.Format("btn{0}1", objInFor.CodeTypeId); 
                    objHtmlInputButton.Attributes["class"] = "btn btn-outline-primary btn-sm ml-2";
                    objHtmlInputButton.Value = string.Format("{0}({1})",
                        objInFor.CodeTypeSimName, objInFor.ProgLangTypeSimName);



                    objHtmlInputButton.Attributes.Add("onclick", string.Format("GeneCode('{0}','{1}','{2}')", objInFor.CodeTypeId, getViewId, vsApplicationTypeId));
                    objButton.Attributes["Style"] = "margin-right:10px;margin-top:5px;left:0px;";

                    //objButton.Command += new CommandEventHandler(this.btnCodeType_Click);
                    pnlCodeTypeLst.Controls.Add(objHtmlInputButton);
                    intCount++;
                }
                if (intCount == 0)
                {
                    string strMsg = string.Format("应用:{0}({1})没有用于[View]相应的代码类型.(In {2})",
                        objvApplicationTypeEN.ApplicationTypeName, objvApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }
        }

        protected void btnCodeType_Click(object sender, EventArgs e)
        {
            Button objButton = sender as Button;
            string strCodeTypeId = objButton.ID.Substring(3);
            //           MessageBox.Show(strCodeTypeId);

            //List<string> arrViewIdLst = GetSelectedViewId();
            //if (arrViewIdLst == null)
            //{
            //    return;
            //}
            string strViewId = getViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            string strTabId = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            string strCmPrjId = "";

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            //int intCount = 0;
            string strCodeText = "";
            //lblMsg.Text = "";

            //Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WA_Access;

            //string strClassFName = "";

            try
            {
                strCodeText = AutoGC.GeneCode(objCodeTypeEN.CodeTypeENName, "",
                                              ltLangType, vsDataBaseType, strTabId, strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                                              vsApplicationTypeId,
                                              clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            }
            catch (Exception objException)
            {
                lblMsg2.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            }

            ShowCode(strCodeText);
            //txtClassName4GC.Text = strRe_ClsName;
            vsSimpleFName = strRe_ClsName;
            //txtFolderName4GenCode.Text = strRe_FileNameWithModuleName;

        }

        private string seFuncModuleAgcId
        {
            get
            {
                string strFuncModuleId;
                strFuncModuleId = (string)Session["FuncModuleAgcId4Qry"];
                if (strFuncModuleId == null)
                {
                    strFuncModuleId = "";
                }
                return strFuncModuleId;
            }
            set
            {
                string strFuncModuleId = value;
                Session.Add("FuncModuleAgcId4Qry", strFuncModuleId);
            }
        }

        private string ViewTypeCode
        {
            get
            {
                string intViewTypeCode;
                intViewTypeCode = (string)Session["ViewTypeCode"];
                if (intViewTypeCode == null)
                {
                    intViewTypeCode = "";
                }
                return intViewTypeCode;
            }
            set
            {
                string intViewTypeCode = value;
                Session.Add("ViewTypeCode", intViewTypeCode);
            }
        }

        private string ViewName
        {
            get
            {
                string strViewName;
                strViewName = (string)Session["ViewName"];
                if (strViewName == null)
                {
                    strViewName = "";
                }
                return strViewName;
            }
            set
            {
                string strViewName = value;
                Session.Add("ViewName", strViewName);
            }
        }


        private string vsSimpleFName
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
        private clsUsersEN objUserBak
        {
            get
            {
                clsUsersEN pobjUser;
                pobjUser = (clsUsersEN)Session["objUser"];
                if (pobjUser == null)
                {
                    pobjUser = null;
                    string strErrMessage = "用户对象为空,可能不用时间超时,Session丢失,需要重新登录!";
                    Session.Add("ErrMessage", strErrMessage);
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }

        protected string getViewId
        {
            get
            {
                if (string.IsNullOrEmpty(qsViewId) == false) return qsViewId;
                return "";
            }

        }
        private string qsViewId
        {
            get
            {
                string strViewId = Request.QueryString["ViewId"] ?? "".ToString();
                if ((strViewId != null) && (strViewId != ""))
                {
                    return strViewId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }


        private string BackGeneCode4WebV5LinkStr
        {
            get
            {
                string strBackGeneCode4WebV5LinkStr;
                strBackGeneCode4WebV5LinkStr = (string)Session["BackGeneCode4WebV5LinkStr"];
                if (strBackGeneCode4WebV5LinkStr == null)
                {
                    strBackGeneCode4WebV5LinkStr = "";
                }
                return strBackGeneCode4WebV5LinkStr;
            }
            set
            {
                string strBackGeneCode4WebV5LinkStr = value;
                Session.Add("BackGeneCode4WebV5LinkStr", strBackGeneCode4WebV5LinkStr);
            }
        }

        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 and  PrjId='" + clsPubVar.CurrSelPrjId + "'";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            return strWhereCond;
        }

      
        protected void btnGenGeneLogicCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            string strViewId = getViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }


            lblMsg2.Text = "";
            ///根据ViewId获取编辑主表的TabId

            try
            {
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;
                if (CheckTabFieldBySqlTab(strTabId) == false)
                {
                    return;
                }

                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_M.A_GenGeneralLogicCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

       
        protected void lbDownLoadFile_Click(object sender, System.EventArgs e)
        {
            string strFileName = UserId + "\\" + vsSimpleFName;
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("/ClsFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strFileContent, string strFileName)
        {
            //			string path = "D:\\澳客网开发编码约定.doc";		//WORD文件可以直接下载
            ///			string path = "D:\\1000010811.JPG";	//JPG文件必须先显示再右击下载
            Response.Clear();
            //			Response.AddHeader("Content-Disposition", "inline; filename=" + ); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(strFileName));
            //			Response.AddHeader("Content-Length", strFileContent.Length.ToString()); 
            Response.ContentType = "application/octet-stream";
            Response.Write(strFileContent);
            Response.Write("\r\r\n");
            Response.End();
            return true;
        }

        protected void btnPreView_Click(object sender, System.EventArgs e)
        {

            string strViewId = getViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            BackGeneCode4WebV5LinkStr = Page.Request.Url.AbsolutePath;
            Response.Redirect("../View/wfmPreviewViewRegion.aspx?ParentPage=GeneCode4WebV5");
        }


        protected void btnGenGeneExLogicCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);


            string strViewId = getViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }


            lblMsg2.Text = "";
            ///根据ViewId获取编辑主表的TabId
            try
            {
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;
                if (CheckTabFieldBySqlTab(strTabId) == false)
                {
                    return;
                }


            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnCtlViewCode4Query_Click(object sender, System.EventArgs e)
        {


            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            string strViewId = getViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx,clsPubVar.CurrSelPrjId);
            lblMsg2.Text = "";
            WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
            if (objViewInfoENEx.ViewFldNum == 0)
            {
                ShowCode("界面中字段数为0，不能生成界面代码");
                return;

            }
            objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
            objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
            ShowCode(autoGC5Cs_VWeb.A_GenCtlViewCodeforTab4Query(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName));
            //txtClassName4GC.Text = strRe_ClsName;
            vsSimpleFName = strRe_ClsName;
            //txtFolderName4GenCode.Text = strRe_FileNameWithModuleName;

        }
             
      

        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            //			string path = "D:\\澳客网开发编码约定.doc";		//WORD文件可以直接下载
            ///			string path = "D:\\1000010811.JPG";	//JPG文件必须先显示再右击下载
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            //Response.AddHeader("Content-Disposition", "inline; filename=" + HttpUtility.UrlEncode(file.Name)); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }

        protected void btnGeneCode_Click(object sender, EventArgs e)
        {
            string strViewId = getViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
            string c1 = @"<script language='javascript'>window.open('../GenCode/wfmGenViewCodeV6.aspx','aa'); </script>";
            Response.Write(c1);
        }
        private bool CheckTabFieldBySqlTab(string strTabId)
        {
            try
            {
                //判断是否可以删除
                if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(strTabId,
                    clsPubVar.CurrSelPrjId,
                    clsPubVar.CurrPrjDataBaseId) == false)
                {
                    lblMsg2.Text = "检查表字段不成功!";
                    return false;
                }
            }
            catch (Exception objException)
            {
                lblMsg2.Text = objException.Message;
                clsCommonJsFunc.Alert(this.Page, objException.Message);
                return false;

            }
            return true;
        }

        protected void btnCtlControlCode4Query_Click(object sender, EventArgs e)
        {

        }

        protected void lbGeneStoreProcedure_Click(object sender, EventArgs e)
        {
            try
            {
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(getViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;
                if (CheckTabFieldBySqlTab(strTabId) == false)
                {
                    return;
                }
                clsCommonSession.TabId = strTabId;
                string c1 = @"<script language='javascript'>window.open('../Table/wfmGeneStoreProcedure.aspx','生成存储过程'); </script>";
                Response.Write(c1);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }


        public override string GenControlCode(string strFlag)
        {


            string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            string strViewId = getViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return "";
            }
            lblMsg2.Text = "";
            string strCmPrjId = "";
            string strTabId = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewControlCode;

            try
            {

                string strCodeText = AutoGC.GeneCode(cnClassName, "",
                               vsLangType, vsDataBaseType, strTabId, strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                              clsCommonSession.ApplicationTypeId,   clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                //strCodeText = clsViewInfoBLEx_GeneCode.GeneControlCode(strViewId, rblNetVersion.SelectedValue,
                //    clsPubVar.objCurrSelProject,
                //    clsCommonSession.UserId,
                //    clsCommonSession.UserName, "", "", strCharEncodingId,
                //    ref strFileName4GenCode, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                //txtClassName4GC.Text = strRe_ClsName;
                vsSimpleFName = strRe_ClsName;
                //txtFolderName4GenCode.Text = strRe_FileNameWithModuleName;
                return RenderControl(divCodeRegion);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                return ErrMessage;
                //clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                //clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //return "生成代码有问题！";
        }


        public override string GenCtlControlCode(string strFlag)
        {

            string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            string strViewId = getViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return "";
            }
            lblMsg2.Text = "";

            string strTabId = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            string strCmPrjId = "";
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewControlCode;

            try
            {

                string strCodeText = AutoGC.GeneCode(cnClassName, "",
                               vsLangType, vsDataBaseType, strTabId, strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                             clsCommonSession.ApplicationTypeId,  clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlControlCode(strViewId, rblNetVersion.SelectedValue,
                //    clsPubVar.objCurrSelProject,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "", strCharEncodingId,
                //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                //txtClassName4GC.Text = strRe_ClsName;
                vsSimpleFName = strRe_ClsName;
                //txtFolderName4GenCode.Text = strRe_FileNameWithModuleName;
                return RenderControl(divCodeRegion);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                //clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                //clsPubFun4Web.AccessError(this, conCurrPageName);
                return ErrMessage;
            }
        }
        /// <summary>
        /// 当前所选择的语言类型：分为： "C#.NET"; "Java";SqlOrOracle
        /// </summary>
        protected clsPubConst.LangType vsLangType
        {
            get
            {
                clsPubConst.LangType strLangType;
                if (ViewState["LangType"] == null)
                {
                    strLangType = clsPubConst.LangType.CSharp;//"Java";
                    return strLangType;
                }
                strLangType = (clsPubConst.LangType)ViewState["LangType"];

                return strLangType;
            }
            set
            {
                clsPubConst.LangType strLangType = value;
                ViewState.Add("LangType", strLangType);
            }
        }




        /// <summary>
        /// 当前所选择的语言类型：分为："Ms Sql", "Oracle"; "MySql";
        /// </summary>
        protected clsPubConst.DataBaseType vsDataBaseType
        {
            get
            {
                clsPubConst.DataBaseType strDataBaseType;

                if (ViewState["DataBaseType"] == null)
                {
                    return clsPubConst.DataBaseType.MsSql;
                }
                strDataBaseType = (clsPubConst.DataBaseType)ViewState["DataBaseType"];
                return strDataBaseType;
            }
            set
            {
                clsPubConst.DataBaseType strDataBaseType = value;
                ViewState.Add("DataBaseType", strDataBaseType);
            }
        }

        protected clsvViewRegionEN vsvViewRegion
        {
            get
            {
                clsvViewRegionEN objvViewRegion;

                if (ViewState["vViewRegion"] == null)
                {
                    return null;
                }
                objvViewRegion = (clsvViewRegionEN)ViewState["vViewRegion"];
                return objvViewRegion;
            }
            set
            {
                clsvViewRegionEN objvViewRegion = value;
                ViewState.Add("vViewRegion", objvViewRegion);
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

        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            litCode.Text = sbJs.ToString();
        }

        /// <summary>
        /// RegionId属性:通过QueryString传递过来的RegionId参数。
        /// 姓名:
        /// 日期:
        /// </summary>
        private string qsRegionId
        {
            get
            {
                string strRegionId = Request.QueryString["RegionId"] ?? "".ToString();
                if (string.IsNullOrEmpty(strRegionId) == false) 
                {
                    return strRegionId;
                }
                else
                {
                    return "";
                }
            }
        }

        //public void ShowCode(string strCode)
        //{
        //    StringBuilder sbJs = new StringBuilder();
        //    //sbJs.Append("<script type=\"text/javascript\">");
        //    sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
        //    sbJs.AppendFormat("{0}", strCode);
        //    sbJs.AppendFormat("</textarea>", strCode);
        //    //sbJs.Append("</script>");
        //    //litCode.Text = sbJs.ToString();
        //}

        [WebMethod]
        public static string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public static string GeneCode(string strCodeTypeId, string strTabId, string strViewId, string strCmPrjId, int intApplicationTypeId)
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

                string strCodeText = AutoGC.GeneCode(strCodeTypeId, "", clsPubConst.DataBaseType.MsSql, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                //txtFileName4GC.Text = strRe_ClsName;
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
                clsGCType objGCType1 = new clsGCType();
                objGCType1.Code = objException.Message;
                return clsJSON.GetJsonFromObj(objGCType1);
                //      return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
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
    }
}