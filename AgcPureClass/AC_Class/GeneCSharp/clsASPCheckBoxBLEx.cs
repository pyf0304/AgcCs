
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPCheckBoxBLEx
表名:ASPNETCheckBox(00050233)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:28
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
    /// ASPNET复选框(ASPNETCheckBox)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPCheckBoxBLEx_Static
    {

        public static string GC_SetDefaultValue(this ASPCheckBoxEx objASPCheckBoxEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objASPCheckBoxEx.CtrlId);
       
            return strCodeForCs.ToString();
        }

        public static string GC_DefFldProperty(this ASPCheckBoxEx objASPCheckBoxEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}",
                objASPCheckBoxEx.Caption);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                objASPCheckBoxEx.CSType,
                objASPCheckBoxEx.FldName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                objASPCheckBoxEx.CtrlId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "set");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                objASPCheckBoxEx.CtrlId);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }


        public static void GeneCode(this ASPCheckBoxEx objASPCheckBoxENEx, StringBuilder strCodeForCs)
        {
            if (objASPCheckBoxENEx.Is4PureHtml == true)
            {
                objASPCheckBoxENEx.GeneCode4Html(strCodeForCs);
                return;
            }
            //<asp:CheckBox ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:CheckBox>
            strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox ", objASPCheckBoxENEx.AspControlId);
            //生成控件的Id、Name

            clsASPControlBLEx.GC4IdName(objASPCheckBoxENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPCheckBoxENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat(" CssClass = \"{0}\"  ", objASPCheckBoxENEx.CssClass);
            }
            if (objASPCheckBoxENEx.Width > 0)
            {
                strCodeForCs.AppendFormat(" Width = \"{0}px\"  ", objASPCheckBoxENEx.Width);
            }
            if (objASPCheckBoxENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPCheckBoxENEx.Height);
            }

            if (string.IsNullOrEmpty(objASPCheckBoxENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("Text = \"{0}\"  ", objASPCheckBoxENEx.Text);
            }
            if (string.IsNullOrEmpty(objASPCheckBoxENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objASPCheckBoxENEx.OnClick);
            }
            strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPCheckBoxENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:CheckBox>");

        }

        public static void GeneCode4Html(this ASPCheckBoxEx objASPCheckBoxENEx, StringBuilder strCodeForCs)
        {
            //<asp:CheckBox ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:CheckBox>
            //    < span class="Check_Defa">
            //<input id = "wucAllDataTypeB1_chkmBool" type="checkbox" name="wucAllDataTypeB1$chkmBool"><label for="wucAllDataTypeB1_chkmBool">布尔型</label></span>
            string strCssClass = objASPCheckBoxENEx.CssClass;
            if (string.IsNullOrEmpty(strCssClass))
            {
                strCssClass = objASPCheckBoxENEx.Class;
            }
            if (objASPCheckBoxENEx.Width > 0)
            {
                objASPCheckBoxENEx.Style += string.Format("width:{0}px;", objASPCheckBoxENEx.Width);
                objASPCheckBoxENEx.Width = 0;
            }
            //if (objASPCheckBoxENEx.Height > 0)
            //{
            //    objASPCheckBoxENEx.Style += string.Format("height:{0}px;", objASPCheckBoxENEx.Height);
            //    objASPCheckBoxENEx.Height = 0;
            //}


            strCodeForCs.AppendFormat("\r\n" + "<span class=\"{0}\" ", strCssClass);
            if (string.IsNullOrEmpty(objASPCheckBoxENEx.Style) == false)
            {
                strCodeForCs.AppendFormat(" style=\"{0}\"",
                    objASPCheckBoxENEx.Style);
            }

            strCodeForCs.AppendFormat(">", objASPCheckBoxENEx.Style);
            strCodeForCs.AppendFormat("\r\n" + "<input type=\"checkbox\" ", objASPCheckBoxENEx.AspControlId);
            //生成控件的Id、Name

            clsASPControlBLEx.GC4IdName(objASPCheckBoxENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(strCssClass) == false)
            //{
            //    strCodeForCs.AppendFormat(" class = \"{0}\"  ", strCssClass);
            //}
            //if (objASPCheckBoxENEx.Width > 0)
            //{
            //    strCodeForCs.AppendFormat(" Width = \"{0}px\"  ", objASPCheckBoxENEx.Width);
            //}
            //if (objASPCheckBoxENEx.Height > 0)
            //{
            //    strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPCheckBoxENEx.Height);
            //}

            if (string.IsNullOrEmpty(objASPCheckBoxENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("Text = \"{0}\"  ", objASPCheckBoxENEx.Text);
            }
            if (string.IsNullOrEmpty(objASPCheckBoxENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objASPCheckBoxENEx.OnClick);
            }
            //strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.Append(">");
            strCodeForCs.AppendFormat("<label for=\"{0}\">{1}</label>", objASPCheckBoxENEx.CtrlId, objASPCheckBoxENEx.Text);
            strCodeForCs.Append("</span>");
            foreach (ASPControlEx objSubASPControlENEx in objASPCheckBoxENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
       

        }

        public static void GeneCode4Mvc(this ASPCheckBoxEx objASPCheckBoxENEx, StringBuilder strCodeForCs)
        {
            //<asp:CheckBox ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:CheckBox>
            if (objASPCheckBoxENEx.Is4PureHtml == true)
            {
                objASPCheckBoxENEx.GeneCode4Html(strCodeForCs);
                return;
            }
            string strFldName = objASPCheckBoxENEx.FldName;
            if (string.IsNullOrEmpty(objASPCheckBoxENEx.ItemName4MultiModel) == false)
            {
                strFldName = string.Format("{0}.{1}", objASPCheckBoxENEx.ItemName4MultiModel, objASPCheckBoxENEx.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox ", objASPCheckBoxENEx.AspControlId);
            //生成控件的Id、Name

            clsASPControlBLEx.GC4IdName(objASPCheckBoxENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPCheckBoxENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat(" CssClass = \"{0}\"  ", objASPCheckBoxENEx.CssClass);
            }
            if (objASPCheckBoxENEx.Width > 0)
            {
                strCodeForCs.AppendFormat(" Width = \"{0}px\"  ", objASPCheckBoxENEx.Width);
            }
            if (objASPCheckBoxENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPCheckBoxENEx.Height);
            }

            if (string.IsNullOrEmpty(objASPCheckBoxENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("Text = \"{0}\"  ", objASPCheckBoxENEx.Text);
            }
            if (string.IsNullOrEmpty(objASPCheckBoxENEx.OnClick) == false)
            {
                strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objASPCheckBoxENEx.OnClick);
            }
            strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPCheckBoxENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:CheckBox>");

        }

        public static void GeneHtmlControl(this ASPCheckBoxEx objASPCheckBoxENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPCheckBoxENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPCheckBoxENEx.mKey);
            }
            HtmlGenericControl objLabel = new HtmlGenericControl("Label");
            objLabel.Attributes["for"] = "CtrlId";
     

            if (objASPCheckBoxENEx.IsCheckBox == true)
            {
                HtmlInputCheckBox objInputCheckBox0 = new HtmlInputCheckBox();
                //objInputCheckBox0.Attributes["class"] = "form-control";
                objInputCheckBox0.ID = objASPCheckBoxENEx.CtrlId+"0";
                objInputCheckBox0.Name = objASPCheckBoxENEx.CtrlName;
                //objInputCheckBox.Value = objASPCheckBoxENEx.Text;
                objContainer.Controls.Add(objInputCheckBox0);
                return;
            }
            if (objASPCheckBoxENEx.Parent != null
          && objASPCheckBoxENEx.Parent.Parent != null)
            {
                switch (objASPCheckBoxENEx.Parent.Parent.RowType)
                {
                    case "headrow":

                        HtmlGenericControl objSpan = new HtmlGenericControl("span");
                        objSpan.Attributes["class"] = objASPCheckBoxENEx.Class;
                        objSpan.ID = objASPCheckBoxENEx.CtrlId;
                        objSpan.InnerHtml = objASPCheckBoxENEx.Caption;

                        objContainer.Controls.Add(objSpan);
                        return;
                    case "datarow":
                        if (objASPCheckBoxENEx.Parent.Parent.objDataRow == null)
                        {
                            throw new Exception("表行没有设置相应的DataRow.");
                        }
                        DataRow objDR = objASPCheckBoxENEx.Parent.Parent.objDataRow;
                        HtmlInputCheckBox objCheck_Data = new HtmlInputCheckBox();
                        objCheck_Data.Attributes["class"] = objASPCheckBoxENEx.Class;
                        objCheck_Data.ID = objASPCheckBoxENEx.CtrlId;
                        try
                        {
                            string strValue = objDR[objASPCheckBoxENEx.FldName].ToString();
                            objCheck_Data.Checked = bool.Parse(strValue);
                        }
                        catch(Exception objExcepton)
                        {

                        }
                        objContainer.Controls.Add(objCheck_Data);
                        return;
                }
            }
            HtmlInputCheckBox objInputCheckBox = new HtmlInputCheckBox();
            //objInputCheckBox.Attributes["class"] = "form-control";
            objInputCheckBox.ID = objASPCheckBoxENEx.CtrlId;
            objInputCheckBox.Name = objASPCheckBoxENEx.CtrlName;
            objInputCheckBox.Value = objASPCheckBoxENEx.Text;
            objLabel.Attributes["for"] = objASPCheckBoxENEx.CtrlId;
            objLabel.InnerText = objASPCheckBoxENEx.Text;
            

            objContainer.Controls.Add(objInputCheckBox);
            objContainer.Controls.Add(objLabel);


        }
    }
    /// <summary>
    /// ASPNET复选框(ASPNETCheckBox)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPCheckBoxBLEx 
    {

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPCheckBoxENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCodeBak(ASPCheckBoxEx objASPCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPCheckBoxENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPCheckBoxENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPCheckBoxENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPCheckBoxENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPCheckBoxENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPCheckBoxENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPCheckBoxENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(objASPCheckBoxENEx.OnClick) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
            //        objASPCheckBoxENEx.OnClick);
            //}
            strCodeForCs.AppendFormat("\r\n" + "android:text=\"{0}\"",
                objASPCheckBoxENEx.Text);
            if (string.IsNullOrEmpty(objASPCheckBoxENEx.scaleX) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:scaleX=\"{0}\"",
                    objASPCheckBoxENEx.scaleX);
            }
            if (string.IsNullOrEmpty(objASPCheckBoxENEx.scaleY) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:scaleY=\"{0}\"",
                    objASPCheckBoxENEx.scaleY);
            }
            //if (objASPCheckBoxENEx.ems > 0)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:ems=\"{0}\"",
            //        objASPCheckBoxENEx.ems);
            //}
            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPCheckBoxENEx, strCodeForCs);
            strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("/>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPCheckBoxENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(strCodeForCs);
            //}
        }
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPCheckBoxEx objASPCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private CheckBox {0};",
                objASPCheckBoxENEx.CtrlId);
        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPCheckBoxEx objASPCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (CheckBox)findViewById(R.id.{0}); ",
                objASPCheckBoxENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPCheckBoxEx objASPCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (CheckBox)view.findViewById(R.id.{0}); ",
                objASPCheckBoxENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objASPCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(ASPCheckBoxEx objASPCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            //strCodeForCs.AppendFormat("\r\n return {0}.getText().toString();", objASPCheckBoxENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n return {0}.isChecked();", objASPCheckBoxENEx.CtrlId);
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(ASPCheckBoxEx objASPCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
               objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()",
                objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, strTemp);
            strCodeForCs.Append("\r\n {");
            //            strCodeForCs.AppendFormat("\r\n return {0}.getText().toString();", objASPCheckBoxENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n return {0}.isChecked();", objASPCheckBoxENEx.CtrlId);
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(ASPCheckBoxEx objASPCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
              objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setChecked({1});", objASPCheckBoxENEx.CtrlId, "value");

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPCheckBoxENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(ASPCheckBoxEx objASPCheckBoxENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setChecked({1});",
    objASPCheckBoxENEx.CtrlId, "value");

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPCheckBoxENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPCheckBoxEx objASPCheckBoxENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.setChecked(obj{0}EN.get{2}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objASPCheckBoxENEx.CtrlId, objASPCheckBoxENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objASPCheckBoxENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(ASPCheckBoxEx objASPCheckBoxENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "{0}.setChecked(false);",
               objASPCheckBoxENEx.CtrlId);
            strCodeForCs.AppendFormat("// {0}", objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldLength,
            objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.IsNull,
            objASPCheckBoxENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.MemoInTab);

        }
    }
}