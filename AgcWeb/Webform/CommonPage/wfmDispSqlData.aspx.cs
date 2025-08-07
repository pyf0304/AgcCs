using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using com.taishsoft.common;
using CommFunc4WebForm;
using System;
using System.Data;
using System.IO;
using System.Xml;

namespace AGC.Webform
{
    public partial class wfmDispSqlData : CommWebPageBase
    {


       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsCommonSession.qsTabId) == true)
            {
                string strMsg = "QueryString参数：TabId为空，不正确，请检查！";
                clsCommonSession.seErrMessage = strMsg;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            ShowSqlData(clsCommonSession.qsTabId);
        }
        private void ShowSqlData(string strTabId)
        {
            clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN(strTabId);
            clsSqlDataSynBL.GetSqlDataSyn(ref objSqlDataSynEN);
            string xmlText =objSqlDataSynEN.SqlData;// "<xml>my data</xml>";
StringReader strReader = new 
   StringReader(xmlText);
XmlTextReader reader = new 
   XmlTextReader(strReader);

            DataSet objDS = new DataSet();
            objDS.ReadXml(reader);
            DataTable objDT = objDS.Tables[0];

            gvDataTable.DataSource = objDT;
            gvDataTable.DataBind();

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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
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
    }
}