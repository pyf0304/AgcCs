

using Agc;
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.common;
using com.taishsoft.json;
//using SqlSv; 
using CommFunc4WebForm;

///生成查询，修改，删除，添加记录的控制层代码
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmViewInfo_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wucGenViewCode : CommBaseControl4CallbackEventHandler
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
            }
    

        }

        public void ShowCodeTypeButton()
        {

            int intAppTypeId = vsApplicationTypeId;
            clsApplicationTypeEN obj = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            lblPageTitle.Text = string.Format("生成{0}-{1}({2})界面",
                obj.ApplicationTypeName, obj.ApplicationTypeENName, obj.ApplicationTypeId);

            //FlowLayoutPanel objFLP = getflowLayoutPanel();
            //if (objFLP == null)
            //{
            //    MessageBox.Show("在当前Tab中没有找到相应的FlowLayoutPanel");
            //    return;
            //}
            pnlCodeTypeLst.Controls.Clear();
            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(intAppTypeId);

            arrObjLst.Sort((clsvAppCodeTypeRelaENEx h1, clsvAppCodeTypeRelaENEx h2) =>
            {
                if (h1.GroupName.CompareTo(h2.GroupName) == 1) return 1;
                else if (h1.GroupName.CompareTo(h2.GroupName) == -1) return -1;
                else
                {
                    if (h1.OrderNum < h2.OrderNum)
                    {
                        return -1;//左值小于右值，返回-1，为升序，如果返回1，就是降序  
                    }
                    else if (h1.OrderNum == h2.OrderNum)//左值等于右值，返回0  
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;//左值大于右值，返回1，为升序，如果返回-1，就是降序  
                    }
                }
            });
            int intCount = 0;
            string strGroupName = "";
            IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_V2 = arrObjLst.Where(x => x.DependsOn == "View");
            if (vsvViewRegion != null)
            {
                arrObjLst_V2 = arrObjLst_V2.Where(x => x.RegionTypeId == vsvViewRegion.RegionTypeId);
            }
            foreach (clsvAppCodeTypeRelaENEx objInFor in arrObjLst_V2)
            {
                if (objInFor.GroupName != strGroupName)
                {
                    if (string.IsNullOrEmpty(strGroupName) == false)
                    {
                        Label objLabel_Br = new Label();
                        objLabel_Br.Text = string.Format("<br/>", objInFor.GroupName);
                        //objLabel.AutoSize = true;
                        pnlCodeTypeLst.Controls.Add(objLabel_Br);
                    }
                    Label objLabel = new Label();
                    objLabel.Text = string.Format("{0}", objInFor.GroupName);
                    //objLabel.AutoSize = true;
                    objLabel.ID = string.Format("lbl{0}", objInFor.CodeTypeId);
                    //string strToolTip = string.Format("生成：[{0}({1})({2})]的代码。", objInFor.CodeTypeName, objInFor.CodeTypeId, objInFor.ProgLangTypeId4CodeType);
                    //toolTip1.SetToolTip(objLabel, strToolTip);                    
                    objLabel.CssClass = "title2";
                    objLabel.Attributes["Style"] = "margin-right:10px;margin-top:5px;left:0px;min-width:100px;";
                    pnlCodeTypeLst.Controls.Add(objLabel);
                    strGroupName = objInFor.GroupName;
                }
                // Create the ToolTip and associate with the Form container.
                //ToolTip toolTip1 = new ToolTip();

                //// Set up the delays for the ToolTip.
                //toolTip1.AutoPopDelay = 5000;
                //toolTip1.InitialDelay = 1000;
                //toolTip1.ReshowDelay = 500;
                //// Force the ToolTip text to be displayed whether or not the form is active.
                //toolTip1.ShowAlways = true;

                //// Set up the ToolTip text for the Button and Checkbox.


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
                //objButton.Command += new CommandEventHandler(this.btnCodeType_Click);
                pnlCodeTypeLst.Controls.Add(objButton);
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
            string strViewId = vsViewId;
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
            //int intApplicationTypeId = clsCommonSession.ApplicationTypeId;
            try
            {
                strCodeText = AutoGC.GeneCode(objCodeTypeEN.CodeTypeENName, "",
                                              ltLangType, vsDataBaseType, strTabId, strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                                              clsCommonSession.ApplicationTypeId,    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            }
            catch (Exception objException)
            {
                lblMsg2.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            }

            ShowCode(strCodeText);
            txtFileName4GenCode.Text = strRe_ClsName;
            vsSimpleFName = strRe_ClsName;
            txtFolderName4GenCode.Text = strRe_FileNameWithModuleName;

            //txtCodePath.Text = strClassFName;
            //tabViewInfoListCode.SelectedIndex = 1;//.TabPages[1].Focus();
            //BindLv_vViewInfo();
        }

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
                    clsCommForWebForm.CheckUserId(strUserId, this.Page);
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }
   

        public string vsViewId
        {
            get
            {
                string strViewId;
                strViewId = (string)ViewState["ViewId"];
                if (strViewId == null)
                {
                    strViewId = "";
                }
                return strViewId;
            }
            set
            {
                string strViewId = value;
                clsvViewInfoEN objvViewInfoEN = clsvViewInfoBL.GetObjByViewId(strViewId);
                vsApplicationTypeId = objvViewInfoEN.ApplicationTypeId;
                ViewState.Add("ViewId", strViewId);
            }
        }




        private int vsApplicationTypeId
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
        public string vsRegionId
        {
            get
            {
                string strRegionId;
                strRegionId = (string)ViewState["RegionId"];
                if (strRegionId == null)
                {
                    return "";
                }
                return strRegionId;
            }
            set
            {
                string strRegionId = value.ToString();
                clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionIdCache(value, clsPubVar.CurrSelPrjId);
                vsvViewRegion = objvViewRegionEN;
                vsApplicationTypeId = objvViewRegionEN.ApplicationTypeId ?? 0;
                //vsViewId = objvViewRegionEN.ViewId;
                ViewState.Add("RegionId", strRegionId);
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


    }
}