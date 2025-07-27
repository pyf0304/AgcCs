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
using System.Xml;

using com.taishsoft.commdb;
using com.taishsoft.encrypt;

public partial class Webform_wfmEncrypt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 加载xml文档
    /// </summary>
    /// <param name="xmlfilename">xml文件名</param>
    /// <returns></returns>
    public System.Xml.XmlDocument LoadXML(string xmlfilename)
    {
        //加载xml文档
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.PreserveWhitespace = true;
        //string url = Server.MapPath(xmlfilename);
        xmldoc.Load(xmlfilename);
        return xmldoc;
    }
    protected void btnEncrypt_Click(object sender, EventArgs e)
    {
        try
        {
            clsEncrypt objEncrypt = new clsEncrypt();
            //TestPubDataBase.exe.config
            //string strFileName = @"E:\WinApp2005\TestPubDataBase\TestPubDataBase\app.config";
            string strFileName =Server.MapPath( clsSpecSQLforSql.strWebRoot )+ @"Web.Config";
            string strNewFileName = objEncrypt.EncryptXmlDoc(strFileName, "connectionStrings/add");//加密
            XmlDocument xmldoc = LoadXML(strNewFileName);
            TextBox1.Text = xmldoc.InnerXml;
        }
        catch (Exception exc)
        {
            TextBox1.Text = exc.Message;
        }

        finally
        {

        }
    }
    
    protected void btnDecrypt_Click(object sender, EventArgs e)
    {
        try
        {
            clsEncrypt objEncrypt = new clsEncrypt();
            string strFileName = Server.MapPath(clsSpecSQLforSql.strWebRoot) + @"Web4EnCrypt.Config";
            string strNewFilename = objEncrypt.DecryptXmlDoc(strFileName, "connectionStrings/add");//加密
            XmlDocument xmldoc = LoadXML(strNewFilename);

            TextBox1.Text = xmldoc.InnerXml;
        }
        catch (Exception exc)
        {
            TextBox1.Text = exc.Message;
        }

        finally
        {

        }
    }
    protected void btnGetConnectString4Encrypt_Click(object sender, EventArgs e)
    {
        try
        {
            clsEncrypt objEncrypt = new clsEncrypt();
            string strFileName = Server.MapPath(clsSpecSQLforSql.strWebRoot) + @"Web4EnCrypt.Config";
            string strConnectString = objEncrypt.GetConnectStringForEncrypt(strFileName, "connectionStrings/add");//加密
            //XmlDocument xmldoc = LoadXML("Web4EnCrypt.Config");

            TextBox1.Text = strConnectString;
        }
        catch (Exception exc)
        {
            TextBox1.Text = exc.Message;
        }

        finally
        {

        }
    }
}
