
using System;
using System.Web;
using System.IO;
using com.taishsoft.common;
/// <summary>
/// 下载应用程序（EXE文件）专用工具
/// </summary>
public class GeneCodeDownloadHandler : IHttpHandler
{
    //定义从外面传来的ObjId(对象ID)
    private string clsCommonSession.qsTabId
    {
        get
        {
            string strTabId = Request.QueryString["TabId"] ?? "".ToString();
            if ((strTabId != null) && (strTabId != ""))
            {
                return strTabId;//Request.QueryString["id"] ?? "";
            }
            else
            {
                return "";
            }
        }
    }
    public void ProcessRequest(HttpContext context)
    {
        try
        {
            string strTabId = context.Request.QueryString["TabId"];

            int intCount = 0;
            
            string strCodePath = "";
            string strCodeText = "";

            //string strTabId = "00420010";
            clsPubVar.objCurrSelProjectEx = new clsProjectsEN("0042", true);
            clsSysParaEN.strUserId = "pyf";
            clsPubVar.CurrSelPrjId = "0042";
            clsSysParaEN.strUserName = "潘以锋";
            try
            {
                clsUserCodePathEN objUserCodePathEN = clsPubVar.GetUserCodePathObjByCodeTypeId("0001");

                strCodeText = clsPrjTabBLEx.GeneEntityLayer(strTabId, clsPubVar.objCurrSelProjectEx,
                   clsSysParaEN.strUserId,
                    clsSysParaEN.strUserName,
                      objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                  false, ref strClsName, ref strCodePath);
                intCount++;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;

            }

            ShowCode(strCodeText);
          
            
            string file = context.Request.QueryString["file"];
            string strNewFile = file;// "abcd.doc";
            string path = context.Server.MapPath(string.Format("~/Upload/{0}", file));
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
            AGC.ErrorInformationBL.AddInformation("DownloadHandler", "ProcessRequest", objException.Message, new AGC.clsCommonSession().UserId);
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