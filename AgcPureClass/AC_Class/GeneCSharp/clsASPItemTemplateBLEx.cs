
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPItemTemplateBLEx
表名:ASPNETItemTemplate(00050229)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:13
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
    /// ASPNET项模板(ASPNETItemTemplate)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPItemTemplateBLEx_Static
    {
        public static void GeneCode(this ASPItemTemplateEx objASPItemTemplateENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "<ItemTemplate", objASPItemTemplateENEx.AspControlId);

            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPItemTemplateENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</ItemTemplate>");

        }
    }
        /// <summary>
        /// ASPNET项模板(ASPNETItemTemplate)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsASPItemTemplateBLEx 
        {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPItemTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPItemTemplateEx objASPItemTemplateENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private LinearLayout ll{0};",
                objASPItemTemplateENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPItemTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPItemTemplateEx objASPItemTemplateENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "ll{0} = (LinearLayout)findViewById(R.id.ll{0}); ",
                objASPItemTemplateENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPItemTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPItemTemplateEx objASPItemTemplateENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "ll{0} = (LinearLayout)view.findViewById(R.id.ll{0}); ",
                objASPItemTemplateENEx.CtrlId);

        }

        //class clsASPItemTemplateBLEx : clsASPItemTemplateBL
        //{
        //<asp:TemplateField HeaderText = "全选">
        //                             <HeaderStyle Width = "30px" />
        //                             <HeaderTemplate>
        //                                 <asp:LinkButton ID = "lbSelAll" CommandName = "lbSelAll" runat = "server" CssClass = "DgSelAll">全选</asp:LinkButton>
        //                             </HeaderTemplate>
        //                             <ItemTemplate>
        //                                 <asp:CheckBox ID = "chkCheckRec" runat = "server"></asp:CheckBox>
        //                             </ItemTemplate>
        //                         </asp:TemplateField>

    

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPItemTemplateENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCodeBak(ASPItemTemplateEx objASPItemTemplateENEx,
            StringBuilder strCodeForCs)
        {
            //    string strActionId = AgcPubFun.getASPNETID();
            //      < android.support.design.widget.ItemTemplate
            //android: layout_width = "match_parent"
            //android: layout_height = "wrap_content"
            //android: theme = "@style/AppTheme.AppBarOverlay" >

            strCodeForCs.AppendFormat("\r\n" + "<android.support.design.widget.ItemTemplate");
            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPItemTemplateENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPItemTemplateENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPItemTemplateENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPItemTemplateENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objASPItemTemplateENEx.theme) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:theme=\"{0}\"",
                    objASPItemTemplateENEx.theme);
            }
            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPItemTemplateENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</android.support.design.widget.ItemTemplate>");
        }
    }
}
