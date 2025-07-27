
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPLabelBLEx
表名:ASPNETLabel(00050222)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:17
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
using System.Web.UI.HtmlControls;
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET标签(ASPNETLabel)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPLabelBLEx_Static
    {

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPLabelENEx">文本视图对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPLabelEx objASPLabelENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPLabelENEx.Is4PureHtml)
            {
                objASPLabelENEx.GeneCode4Html(strCodeForCs);
                return;
            }
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPLabelENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPLabelENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPLabelENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPLabelENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPLabelENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPLabelENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPLabelENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(objASPLabelENEx.OnClick) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
            //        objASPLabelENEx.OnClick);
            //}

            //生成控件的样式
            clsASPControlBLEx.GC4Text(objASPLabelENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPLabelENEx, strCodeForCs);
            strCodeForCs.AppendFormat(" runat=\"server\" ");
            strCodeForCs.AppendFormat("/>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPLabelENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(strCodeForCs);
            //}
        }

        public static void GeneCode4Html(this ASPLabelEx objASPLabelENEx,
        StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPLabelENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPLabelENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<Label");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPLabelENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPLabelENEx, strCodeForCs);
            if (objASPLabelENEx.Style == null) objASPLabelENEx.Style = "";
            if (objASPLabelENEx.Width>0)
            {
                objASPLabelENEx.Style += string.Format("width:{0}px;", objASPLabelENEx.Width);
                objASPLabelENEx.Width = 0;
            }
            if (objASPLabelENEx.Height > 0)
            {
                objASPLabelENEx.Style += string.Format("height:{0}px;", objASPLabelENEx.Height);
                objASPLabelENEx.Height = 0;
            }
            objASPLabelENEx.Style = objASPLabelENEx.Style.Replace(";;", ";");
            //生成控件的样式
            //clsASPControlBLEx.GC4Style(objASPLabelENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPLabelENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPLabelENEx.CssClass);
            }
            if (string.IsNullOrEmpty(objASPLabelENEx.Class) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPLabelENEx.Class);
            }
            if (string.IsNullOrEmpty(objASPLabelENEx.Style) == false)
            {
                strCodeForCs.AppendFormat(" style=\"{0}\"",
                    objASPLabelENEx.Style);
            }
            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPLabelENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPLabelENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(objASPLabelENEx.OnClick) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
            //        objASPLabelENEx.OnClick);
            //}

          
            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPLabelENEx, strCodeForCs);
            //strCodeForCs.AppendFormat(" runat=\"server\" ");
            strCodeForCs.Append(">");
            //生成控件的样式

            if (string.IsNullOrEmpty(objASPLabelENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("{0}",
                    objASPLabelENEx.Text);
            }
            strCodeForCs.Append("\r\n" + "</Label>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPLabelENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(strCodeForCs);
            //}
        }

        public static void GeneCode4Mvc(this ASPLabelEx objASPLabelENEx,
       StringBuilder strCodeForCs)
        {
            if (objASPLabelENEx.Is4PureHtml)
            {
                objASPLabelENEx.GeneCode4Html(strCodeForCs);
                return;

            }
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPLabelENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPLabelENEx.mKey);
            }
            string strClass = string.IsNullOrEmpty(objASPLabelENEx.Class) ? objASPLabelENEx.CssClass : objASPLabelENEx.Class;
            string strFldName = objASPLabelENEx.FldName;
            if (string.IsNullOrEmpty(objASPLabelENEx.ItemName4MultiModel) == false)
            {
                strFldName = string.Format("{0}.{1}", objASPLabelENEx.ItemName4MultiModel, objASPLabelENEx.FldName);
            }
            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{1}, htmlAttributes: new {{ @class = \"{3}\", style = \"{2}\" }})",
                  objASPLabelENEx.TabName, strFldName, objASPLabelENEx.Style, strClass);
            
        }
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPLabelENEx">编辑文本框对象</param>      
        public static void GeneHtmlControl(this ASPLabelEx objASPLabelENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();

            HtmlGenericControl objSpan = new HtmlGenericControl("span");
            objSpan.Attributes["class"] = objASPLabelENEx.Class;
            objSpan.ID = objASPLabelENEx.CtrlId;
            objSpan.InnerHtml = objASPLabelENEx.Text;
            objContainer.Controls.Add(objSpan);
            foreach (ASPControlEx objSubASPControlENEx in objASPLabelENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneHtmlControl(objSpan);
                
            }
            //return objSpan;
        }
    }
        /// <summary>
        /// ASPNET标签(ASPNETLabel)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsASPLabelBLEx 
        {


        public static void GeneCodeBak20180630(ASPLabelEx objASPLabelENEx, StringBuilder strCodeForCs)
        {
            //<asp:Label ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:Label>
            strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"{0}\" runat = \"server\" ", objASPLabelENEx.AspControlId);
            if (string.IsNullOrEmpty(objASPLabelENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objASPLabelENEx.CssClass);
            }
            if (objASPLabelENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPLabelENEx.Height);
            }
            strCodeForCs.AppendFormat(">{0}", objASPLabelENEx.Text);

            foreach (ASPControlEx objSubASPControlENEx in objASPLabelENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:Label>");

        }

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPLabelENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPLabelEx objASPLabelENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Label {0};",
                objASPLabelENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPLabelENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPLabelEx objASPLabelENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Label)findViewById(R.id.{0});",
                objASPLabelENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPLabelENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPLabelEx objASPLabelENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Label)view.findViewById(R.id.{0});",
                objASPLabelENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objASPLabelENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(ASPLabelEx objASPLabelENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
          AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                  string.Format("{0}.getText().toString()", objASPLabelENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPLabelENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(ASPLabelEx objASPLabelENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                              string.Format("{0}.getText().toString()", objASPLabelENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPLabelENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(ASPLabelEx objASPLabelENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
    objASPLabelENEx.CtrlId,
    AgcPubFun.getToStringCode4DataType4Java(objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPLabelENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(ASPLabelEx objASPLabelENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp,
                objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
                objASPLabelENEx.CtrlId,
                AgcPubFun.getToStringCode4DataType4Java(objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));
            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPLabelENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPLabelEx objASPLabelENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPLabelENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            //strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
            //   objViewInfoENEx.objOutRelaTab.TabName,
            //   objASPLabelENEx.objDGRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n" + "tv{0}.setText({1});",
            objASPLabelENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName,
            AgcPubFun.getToStringCode4DataType4Java(
                objASPLabelENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                string.Format("obj{0}EN.get{1}()",
                objViewInfoENEx.objOutRelaTab.TabName,
                objASPLabelENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName)));

            //strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objASPLabelENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(ASPLabelEx objASPLabelENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "tv{0}.setText(\"\");",
               objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("// {0}", objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldLength,
            objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.IsNull,
            objASPLabelENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.MemoInTab);

        }

        /// <summary>
        /// 建立[存放功能按钮的表]
        /// </summary>
        /// <returns></returns>
        public static ASPLabelEx GetDataListTitle(clsViewInfoENEx objViewInfoENEx, bool bolIs4PureHtml = false)
        {
            //strCodeForCs.AppendFormat("\r\n" + "<asp:label id = \"lbl{0}List\" runat = \"server\" style = \"z-index: 105; \" ",
            //  objViewInfoENEx.objMainPrjTab.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}列表</asp:label>",
            //  objViewInfoENEx.objInRelaTab.TabCnName);

            ASPLabelEx objASPLabelENEx = new ASPLabelEx();
            objASPLabelENEx.Is4PureHtml = bolIs4PureHtml;
            objASPLabelENEx.CtrlId = string.Format("lbl{0}List", objViewInfoENEx.objMainPrjTab.TabName);
            objASPLabelENEx.Text = string.Format("{0}列表", objViewInfoENEx.objInRelaTab.TabCnName);
            //objASPLabelENEx.Style = "z-index: 105; ";
            objASPLabelENEx.CssClass = "col-form-label text-info";
            objASPLabelENEx.Width = 250;
            objASPLabelENEx.Height = 0;
            return objASPLabelENEx;
        }

        public static ASPLabelEx GetLabel4ErrMsg(string strID, bool bolIs4PureHtml = false)
        {
            //strCodeForCs.AppendFormat("\r\n" + "<asp:label id = \"lbl{0}List\" runat = \"server\" style = \"z-index: 105; \" ",
            //  objViewInfoENEx.objMainPrjTab.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}列表</asp:label>",
            //  objViewInfoENEx.objInRelaTab.TabCnName);

            ASPLabelEx objASPLabelENEx = new ASPLabelEx();
            objASPLabelENEx.Is4PureHtml = bolIs4PureHtml;
            objASPLabelENEx.CtrlId = string.Format("{0}", strID);
            objASPLabelENEx.Text = string.Format("");
            //objASPLabelENEx.Style = "z-index: 105; ";
            objASPLabelENEx.CssClass = "text-warning";
            objASPLabelENEx.Width = 250;
            objASPLabelENEx.Height = 0;
            return objASPLabelENEx;
        }
        /// <summary>
        /// 建立[空行td]
        /// </summary>
        /// <returns></returns>
        public static ASPLabelEx GetEmptyLabel()
        {
            ASPLabelEx objASPLabelENEx = new ASPLabelEx();
            //objASPLabelENEx.CtrlId = "tr1";         
            //objASPLabelENEx.Style = "width: 100%; height: 32px; ";
            //objASPLabelENEx.Class = "msgtable";
            return objASPLabelENEx;
        }

        /// <summary>
        /// 查询区域字段转换成安卓标签控件
        /// </summary>
        /// <param name="objDGRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓标签控件</returns>
        public static ASPLabelEx GetObjByDGFld(clsDGRegionFldsENEx objDGRegionFldsEx)
        {
            ASPLabelEx objASPLabelENEx_TextBox = new ASPLabelEx();
            objASPLabelENEx_TextBox.CtrlId = string.Format("tv{0}", objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            objASPLabelENEx_TextBox.Style = "tvStyle4ListItem";
            objASPLabelENEx_TextBox.Width = 30;
            objASPLabelENEx_TextBox.Height = 22;
            objASPLabelENEx_TextBox.Text = objDGRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
            objASPLabelENEx_TextBox.objDGRegionFldsENEx = objDGRegionFldsEx;
            return objASPLabelENEx_TextBox;

        }

        /// <summary>
        /// 编辑区域字段转换成安卓标签控件
        /// </summary>
        /// <param name="objEditRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓标签控件</returns>
        public static ASPLabelEx GetObjByEditFld(clsEditRegionFldsENEx objEditRegionFldsEx)
        {

            switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    ASPLabelEx objASPLabelENEx = new ASPLabelEx();
                    objASPLabelENEx.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objASPLabelENEx.Width = 100;
                    objASPLabelENEx.Height = 0;
                    objASPLabelENEx.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPLabelENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objASPLabelENEx;


                case "TextBox":
                    ASPLabelEx objASPLabelENEx_TextBox = new ASPLabelEx();
                    objASPLabelENEx_TextBox.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPLabelENEx_TextBox.Width = 100;
                    objASPLabelENEx_TextBox.Height = 22;
                    objASPLabelENEx_TextBox.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPLabelENEx_TextBox.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objASPLabelENEx_TextBox;

                case "DropDownList":
                    ASPLabelEx objASPLabelENEx_DropDownList = new ASPLabelEx();
                    objASPLabelENEx_DropDownList.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPLabelENEx_DropDownList.Width = 100;
                    objASPLabelENEx_DropDownList.Height = 0;
                    objASPLabelENEx_DropDownList.Text = objEditRegionFldsEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPLabelENEx_DropDownList.objEditRegionFldsENEx = objEditRegionFldsEx;
                    return objASPLabelENEx_DropDownList;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }


        /// <summary>
        /// 查询区域字段转换成安卓标签控件
        /// </summary>
        /// <param name="objQryRegionFldsEx">查询区域字段对象</param>
        /// <returns>转换成的安卓标签控件</returns>
        public static ASPLabelEx GetObjByQryFld(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
            {
                case "CheckBox":
                    ASPLabelEx objASPLabelENEx = new ASPLabelEx();
                    objASPLabelENEx.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                    objASPLabelENEx.Width = 100;
                    objASPLabelENEx.Height = 0;
                    objASPLabelENEx.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPLabelENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objASPLabelENEx;


                case "TextBox":
                    ASPLabelEx objASPLabelENEx_TextBox = new ASPLabelEx();
                    objASPLabelENEx_TextBox.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPLabelENEx_TextBox.Width = 100;
                    objASPLabelENEx_TextBox.Height = 22;
                    objASPLabelENEx_TextBox.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPLabelENEx_TextBox.objQryRegionFldsENEx = objQryRegionFldsEx;
                    return objASPLabelENEx_TextBox;

                case "DropDownList":
                    ASPLabelEx objASPLabelENEx_DropDownList = new ASPLabelEx();
                    objASPLabelENEx_DropDownList.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    objASPLabelENEx_DropDownList.Width = 100;
                    objASPLabelENEx_DropDownList.Height = 0;
                    objASPLabelENEx_DropDownList.Text = objQryRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    objASPLabelENEx_DropDownList.objQryRegionFldsENEx = objQryRegionFldsEx;

                    return objASPLabelENEx_DropDownList;

                default:
                    string strMsg = string.Format("查询区域字段转换成安卓控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

    }
}
