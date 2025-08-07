using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;


using System;
using System.Web;

namespace AGC
{
    /// <summary>
    /// GeneCodeDownloadHandler 的摘要说明
    /// </summary>
    public class GeneCodeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
          
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            string strTabId = context.Request.QueryString["TabId"];
            string strPrjId = context.Request.QueryString["PrjId"];
            string strUserId = context.Request.QueryString["UserId"];
            string strApplicationTypeId = context.Request.QueryString["ApplicationTypeId"];

            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString( context.Request.QueryString["LangType"]);
            clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.GetDataBaseTypeByString( context.Request.QueryString["DataBaseType"]);
            
            int intCount = 0;
            string strCodePath = "";
      
            //string strTabId = "00420010";
            clsProjectsEN objProjectEx = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            //clsSysParaEN.strUserId = "pyf";
            clsUsersEN objUsersEN = new clsUsersEN(strUserId);
            clsUsersBL.GetUsers(ref objUsersEN);
            //clsSysParaEN.strUserName = "潘以锋";
            string strTempFiles = context.Server.MapPath(clsSysParaEN.TempWebFolder);
            string strGeneCodePath = strTempFiles + "\\" + strUserId;
            string strFileName = "";
            string strCmPrjId = "";
            try
            {
                clsUserCodePathEN objUserCodePathEN = clsPubVar.GetUserCodePathObjByCodeTypeId("0001", strPrjId,  strUserId);
                string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;
                clsPubConst.ClassName cnClassNameSim = clsPubConst.ClassName.EntityLayer_Sim;

                string strCodeText = AutoGC.GeneCode(cnClassName, "", ltLangType, dbtDataBaseType, strTabId,
                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, int.Parse(strApplicationTypeId), clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);
                string strCodeText_Sim = AutoGC.GeneCode(cnClassNameSim, "", ltLangType, dbtDataBaseType, strTabId,
                                    strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, int.Parse( strApplicationTypeId), clsCommonSession.UserId, ref strRe_ClsName,
                                    ref strRe_FileNameWithModuleName);


                //strCodeText = clsPrjTabBLEx_GeneCode.GeneEntityLayer(strTabId, objProjectEx, clsPubVar.CurrPrjDataBaseId,
                //   strUserId,
                //    objUsersEN.UserName,
                //      strGeneCodePath,"",
                //        strCharEncodingId, ltLangType, dbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);
                //txtCode_Sim.Text = strCodeText_Sim;
                intCount++;
            }
            catch (Exception objException)
            {

                ErrorInformationBL.AddInformation("GeneCodeDownloadHandler", "ProcessRequest", objException.Message, strUserId);
                context.Response.Clear();
                context.Response.End();
            }
            try
            {


                string file = strFileName;//  context.Request.QueryString["file"];
                string strNewFile = file;// "abcd.doc";
                string path = strCodePath + "\\" + file;// context.Server.MapPath(string.Format(clsSysParaEN.TempWebFolder + "/{0}", file));
                strGeneCodePath = strGeneCodePath.Replace("\\\\", "\\");
                strCodePath = strCodePath.Replace("\\\\", "\\");
                string strModuleName = strCodePath.Substring(strGeneCodePath.Length);
                string strHost = context.Request.Url.AbsoluteUri.Substring(0, context.Request.Url.AbsoluteUri.IndexOf("Handler"));
                string strFileWebName = strHost + "TempFiles/" + strUserId + "/" + strModuleName + "/" + strFileName;
                //strFileWebName = strFileWebName.Replace("\\\\", "\\");
                strFileWebName = strFileWebName.Replace("\\", "");
                context.Response.Write(strFileWebName);
               
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("GeneCodeDownloadHandler", "ProcessRequest", objException.Message, strUserId);
                context.Response.Clear();
                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}