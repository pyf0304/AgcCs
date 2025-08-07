
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPTemplateFieldBLEx
表名:ASPNETTemplateField(00050227)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:33
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;


using AGC.PureClass;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET模板字段(ASPNETTemplateField)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPTemplateFieldBLEx_Static
    {
        public static void GeneCode(this ASPTemplateFieldEx objASPTemplateFieldENEx, StringBuilder strCodeForCs)
        {
            //<asp:TemplateField ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:TemplateField>
            strCodeForCs.AppendFormat("\r\n" + "<asp:TemplateField ", objASPTemplateFieldENEx.AspControlId);

            if (objASPTemplateFieldENEx.Width > 0)
            {
                strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPTemplateFieldENEx.Width);
            }
            if (objASPTemplateFieldENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPTemplateFieldENEx.Height);
            }

            if (string.IsNullOrEmpty(objASPTemplateFieldENEx.HeaderText) == false)
            {
                strCodeForCs.AppendFormat("HeaderText = \"{0}\"  ", objASPTemplateFieldENEx.HeaderText);
            }

            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPTemplateFieldENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:TemplateField>");

        }

    }
    /// <summary>
    /// ASPNET模板字段(ASPNETTemplateField)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPTemplateFieldBLEx 
        {

       
        //<asp:TemplateField HeaderText = "全选">
        //                             <HeaderStyle Width = "30px" />
        //                             <HeaderTemplate>
        //                                 <asp:LinkButton ID = "lbSelAll" CommandName = "lbSelAll" runat = "server" CssClass = "DgSelAll">全选</asp:LinkButton>
        //                             </HeaderTemplate>
        //                             <ItemTemplate>
        //                                 <asp:CheckBox ID = "chkCheckRec" runat = "server"></asp:CheckBox>
        //                             </ItemTemplate>
        //                         </asp:TemplateField>

        
    }
}
