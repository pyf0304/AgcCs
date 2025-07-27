
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPHeaderTemplateBLEx
表名:ASPNETHeaderTemplate(00050231)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:58
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
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsASPHeaderTemplateBLEx_Static
    {
        public static void GeneCode(this ASPHeaderTemplateEx objASPHeaderTemplateENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "<HeaderTemplate", objASPHeaderTemplateENEx.AspControlId);

            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPHeaderTemplateENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</HeaderTemplate>");

        }
    }
        /// <summary>
        /// ASPNET头模板(ASPNETHeaderTemplate)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsASPHeaderTemplateBLEx 
    {

       

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPHeaderTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPHeaderTemplateEx objASPHeaderTemplateENEx,
            StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "private HeaderTemplate {0};",
                objASPHeaderTemplateENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHeaderTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPHeaderTemplateEx objASPHeaderTemplateENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (HeaderTemplate)findViewById(R.id.{0}); ",
                objASPHeaderTemplateENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHeaderTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4HeaderTemplate(ASPHeaderTemplateEx objASPHeaderTemplateENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (HeaderTemplate)view.findViewById(R.id.{0}); ",
                objASPHeaderTemplateENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objASPHeaderTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(ASPHeaderTemplateEx objASPHeaderTemplateENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                              string.Format("{0}.getText().toString()", objASPHeaderTemplateENEx.CtrlId)));

            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPHeaderTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(ASPHeaderTemplateEx objASPHeaderTemplateENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPHeaderTemplateENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objASPHeaderTemplateENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPHeaderTemplateENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                              string.Format("{0}.getText().toString()", objASPHeaderTemplateENEx.CtrlId)));

            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPHeaderTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(ASPHeaderTemplateEx objASPHeaderTemplateENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPHeaderTemplateENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objASPHeaderTemplateENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objASPHeaderTemplateENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPHeaderTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(ASPHeaderTemplateEx objASPHeaderTemplateENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPHeaderTemplateENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPHeaderTemplateENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPHeaderTemplateENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objASPHeaderTemplateENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
 objASPHeaderTemplateENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objASPHeaderTemplateENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }


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
        /// <param name="objASPHeaderTemplateENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCodeBak(ASPHeaderTemplateEx objASPHeaderTemplateENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPHeaderTemplateENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPHeaderTemplateENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<HeaderTemplate");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPHeaderTemplateENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPHeaderTemplateENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPHeaderTemplateENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPHeaderTemplateENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPHeaderTemplateENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            //if (string.IsNullOrEmpty(objASPHeaderTemplateENEx.orientation) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
            //        objASPHeaderTemplateENEx.orientation);
            //}
            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPHeaderTemplateENEx, strCodeForCs);
            if (objASPHeaderTemplateENEx.arrSubAspControlLst2.Count == 0)
            {
                strCodeForCs.AppendFormat("/>");
            }
            else
            {
                strCodeForCs.AppendFormat(">");

                foreach (ASPControlEx objSubASPControlENEx in objASPHeaderTemplateENEx.arrSubAspControlLst2)
                {
                    //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
                    objSubASPControlENEx.GeneCode(strCodeForCs);
                }
                strCodeForCs.AppendFormat("\r\n" + "</HeaderTemplate>");
            }
        }
    }
}