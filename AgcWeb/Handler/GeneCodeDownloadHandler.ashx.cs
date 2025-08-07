using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;


using System;
using System.IO;
using System.Web;

namespace AGC
{
    /// <summary>
    /// GeneCodeDownloadHandler 的摘要说明
    /// </summary>
    public class GeneCodeDownloadHandler : IHttpHandler
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
            //string strLangType = "C#.NET"; // "Java";
            clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;

            
            int intCount = 0;

            string strCodePath = "";
            string strCodeText = "";
            //string strCodeText_Sim = "";

            //string strTabId = "00420010";
            clsProjectsEN objProjectEx = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            //clsSysParaEN.strUserId = "pyf";
            clsUsersEN objUsersEN = new clsUsersEN(strUserId);
            clsUsersBL.GetUsers(ref objUsersEN);
            //clsSysParaEN.strUserName = "潘以锋";
            string strTempFiles = context.Server.MapPath(clsSysParaEN.TempWebFolder);
            string strGeneCodePath = strTempFiles + "\\" + strUserId;
            string strFileName = "";
            string strViewId = "";
            string strRe_ClsName = "";
            string strCmPrjId = "";
            string strRe_FileNameWithModuleName = "";
            //clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
            try
            {
                clsUserCodePathEN objUserCodePathEN = clsPubVar.GetUserCodePathObjByCodeTypeId("0001", strPrjId,  strUserId);
                strCodeText = AutoGC.GeneCode(cnClassName, "", ltLangType, dbtDataBaseType, strTabId,
           strViewId, strCmPrjId, strPrjId, clsPubVar.CurrPrjDataBaseId, int.Parse(strApplicationTypeId), strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                //strCodeText = clsPrjTabBLEx_GeneCode.GeneEntityLayer(strTabId, objProjectEx,clsPubVar.CurrPrjDataBaseId,
                //   strUserId,
                //    objUsersEN.UserName,
                //      strGeneCodePath,"", strCharEncodingId, ltLangType, dbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);
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
                path = path.Replace("\\\\", "\\");
                if (File.Exists(path))
                {
                    int strLenth = System.Text.UnicodeEncoding.UTF8.GetByteCount(file);
                    if (strLenth > 57)
                    {
                        FileInfo objFileInfo = new FileInfo(path);

                        strNewFile = file.Substring(0, 17) + "_" + objFileInfo.Extension;
                    }

                    context.Response.Clear();
                    context.Response.AddHeader("Pragma", "public");
                    context.Response.AddHeader("Expires", "0");
                    context.Response.AddHeader("Cache-Control", "must-revalidate, post-check=0, pre-check=0");
                    context.Response.AddHeader("Content-Type", "application/force-download");
                    context.Response.AddHeader("Content-Type", "application/octet-stream");
                    context.Response.AddHeader("Content-Type", "application/download");
                    string strEncode = context.Server.UrlEncode(strNewFile);
                    context.Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}", strEncode));
                    context.Response.AddHeader("Content-Transfer-Encoding", "binary");
                    context.Response.AddHeader("Content-Length", new FileInfo(path).Length.ToString());

                    context.Response.WriteFile(path);
                }
                else
                {
                    //System.Text.StringBuilder sbScript =new System.Text.StringBuilder();
                    path = path.Replace('\\', '/');
                    string strMsg = string.Format("<script language='javascript'> alert('需要下载的文件：{0}不存在！请检查'); </script>", path);

                    context.Response.Write(strMsg);
                    //context.Response.End();
                    return;
                }
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