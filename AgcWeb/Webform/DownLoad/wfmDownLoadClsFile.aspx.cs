using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmDownLoadClsFile 的摘要说明。
    /// </summary>
    public partial class wfmDownLoadClsFile : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (qsParentPage == "HomePage")
            {
                spanReturn.Visible = false;
            }
            else
            {
                spanReturn.Visible = true;
            }
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

        protected void lbDownSQL_Click(object sender, System.EventArgs e)
        {
            string strFileName = "clsSQL.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownSpecSQL_Click(object sender, System.EventArgs e)
        {
            string strFileName = "clsSpecSQLforSql.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownGeneTab_Click1(object sender, EventArgs e)
        {
            string strFileName = "clsGeneralTab.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownPubDataBase_Click(object sender, EventArgs e)
        {
            string strFileName = "数据底层.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownCommFunc4Web_Click(object sender, EventArgs e)
        {
            string strFileName = "基于Web的常用函数.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownCommFunc4Win_Click(object sender, EventArgs e)
        {
            string strFileName = "基于Win的常用函数.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownExportExcel_Click(object sender, EventArgs e)
        {
            string strFileName = "用于Excel导出的公共类.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        
        }

        protected void lbDownGeneralPlatform4WS_Click(object sender, EventArgs e)
        {
            string strFileName = "用户管理统一平台操作类.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownSimplePrj_Click(object sender, EventArgs e)
        {
            string strFileName = "SamplePrj2016.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownWinClient_Click(object sender, EventArgs e)
        {
            string strFileName = "Agc_CsWinSetup.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }
        //定义从外面传来的ObjId(对象ID)
        private string qsParentPage
        {
            get
            {
                string strParentPage = Request.QueryString["ParentPage"] ?? "".ToString();
                if ((strParentPage != null) && (strParentPage != ""))
                {
                    return strParentPage;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        protected void lbDownAndroidSample_Click(object sender, EventArgs e)
        {
            string strFileName = "ExamLib.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }
    }
}
