using Agc;
using AGC;
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform.A_Sample
{
    public partial class GeneCodeByJs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public static string GeneCode(string strCodeTypeId, string strTabId, string strViewId, int intApplicationTypeId)
        {
            //string strFeatureId = wucTreeView1.NodeData.FeatureId;
            //string strFuncId4Code = wucTreeView1.NodeData.FuncId4Code;
            //string strFuncId4GC = wucTreeView1.NodeData.FuncId4GC;
            //string strExamBatchId = wucTreeView1.NodeData.ExamBatchId;
            //string strApplicationTypeId = wucTreeView1.NodeData.ApplicationTypeId;

            ////string strViewId = wucTreeView1.NodeData.ViewId;
            ////string strProgLangTypeId = wucTreeView1.NodeData.ProgLangTypeId;
            ////string strCodeTypeId = wucTreeView1.NodeData.CodeTypeId;
            //string strExamDate = wucTreeView1.NodeData.ExamDate;


            //            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            clsPubVar.CurrSelPrjId = "0116";
            clsPubVar.CurrPrjDataBaseId = "0111";
            string strCmPrjId = "";


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
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }

        /// <summary>
        /// 当前所选择的类型参数：可有：界面类型、类型其他参数等
        /// </summary>
        protected string vsTypeParas
        {
            get
            {
                string strTypeParas = "";
                //if (ViewState["TypeParas"] == null)
                //{
                //    if (ddlAppPageTypeId.SelectedIndex > 0)
                //    {
                //        string strAppPageTypeId = ddlAppPageTypeId.SelectedValue;
                //        clsAppPageTypeEN objAppPageTypeEN = clsAppPageTypeBL.GetObjByAppPageTypeIdCache(strAppPageTypeId);
                //        strTypeParas = strTypeParas + string.Format("{0}|",
                //            objAppPageTypeEN.AppPageTypeENName);
                //        return strTypeParas;
                //    }
                //}
                //strTypeParas = (string)ViewState["TypeParas"];

                return strTypeParas;
            }
            set
            {
                string strTypeParas = value;
                ViewState.Add("TypeParas", strTypeParas);
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
    }
}