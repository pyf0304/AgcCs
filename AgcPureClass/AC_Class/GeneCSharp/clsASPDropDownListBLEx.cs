
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPDropDownListBLEx
表名:ASPNETDropDownList(00050414)
生成代码版本:2018.06.28.1
生成日期:2018/06/29 13:56:07
生成者:潘以锋
生成服务器IP:202.121.63.42
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
using System.Collections.Generic;
using com.taishsoft.common;



using AGC.PureClass;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using AgcCommBase;
using System.Web.UI.HtmlControls;
using AGC.Entity;
using Agc.PureClass;

namespace AGC.PureClassEx
{

    public static class clsASPDropDownListBLEx_Static
    {
        public static string GC_SetDefaultValue(this ASPDropDownListEx objASPDropDownListEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                        objASPDropDownListEx.CtrlId);
                   

            return strCodeForCs.ToString();
        }

        public static string GC_DefFldProperty(this ASPDropDownListEx objASPDropDownListEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}",
                objASPDropDownListEx.Caption);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                objASPDropDownListEx.CSType,
                objASPDropDownListEx.FldName);
            strCodeForCs.Append("\r\n" + "{");


            if (objASPDropDownListEx.CSType == "bool")
            {
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (value  ==  true)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (objASPDropDownListEx.CSType == "int"
                || objASPDropDownListEx.CSType == "bigint"
                || objASPDropDownListEx.CSType == "short"
               )
            {
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue  ==  \"0\")",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.AppendFormat("\r\n" + "return 0;");
                strCodeForCs.AppendFormat("\r\n" + "return {1}.Parse({0}.SelectedValue);",
                    objASPDropDownListEx.CtrlId, objASPDropDownListEx.CSType);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (value  ==  0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value.ToString();",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue  ==  \"0\")",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue;",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                    objASPDropDownListEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public static void GeneCode4Html(this ASPDropDownListEx objASPDropDownListENEx,
       StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPDropDownListENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPDropDownListENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<select");
            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPDropDownListENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPDropDownListENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPDropDownListENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPDropDownListENEx.CssClass);
            }
            if (string.IsNullOrEmpty(objASPDropDownListENEx.Class) == false)
            {
                strCodeForCs.AppendFormat(" class=\"{0}\"",
                    objASPDropDownListENEx.Class);
            }

            if (objASPDropDownListENEx.Width > 0)
            {
                objASPDropDownListENEx.Style += string.Format("width:{0}px;", objASPDropDownListENEx.Width);
                objASPDropDownListENEx.Width = 0;
            }
            if (objASPDropDownListENEx.Height > 0)
            {
                objASPDropDownListENEx.Style += string.Format("height:{0}px;", objASPDropDownListENEx.Height);
                objASPDropDownListENEx.Height = 0;
            }
            if (string.IsNullOrEmpty(objASPDropDownListENEx.Style) == false)
            {
                strCodeForCs.AppendFormat(" style=\"{0}\"",
                    objASPDropDownListENEx.Style);
            }
           

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPDropDownListENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPDropDownListENEx, strCodeForCs);

            //   clsASPControlBLEx.GC4Text(objASPDropDownListENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPDropDownListENEx.entries) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:entries=\"{0}\"",
                    objASPDropDownListENEx.entries);
            }

            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPDropDownListENEx, strCodeForCs);
            //strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("/>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPDropDownListENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(strCodeForCs);
            //}


        }
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPDropDownListENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPDropDownListEx objASPDropDownListENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPDropDownListENEx.Is4PureHtml == true)
            {
                objASPDropDownListENEx.GeneCode4Html(strCodeForCs);
                return;
            }
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPDropDownListENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPDropDownListENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<asp:DropDownList");
            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPDropDownListENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPDropDownListENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPDropDownListENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPDropDownListENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPDropDownListENEx, strCodeForCs);

            //   clsASPControlBLEx.GC4Text(objASPDropDownListENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPDropDownListENEx.entries) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:entries=\"{0}\"",
                    objASPDropDownListENEx.entries);
            }

            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPDropDownListENEx, strCodeForCs);
            strCodeForCs.AppendFormat(" runat=\"server\" ");

            strCodeForCs.AppendFormat("/>");

            //foreach (ASPControlEx objSubASPControlENEx in objASPDropDownListENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlTypeAbbr.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(strCodeForCs);
            //}


        }

        public static void GeneCode4Mvc(this ASPDropDownListEx objASPDropDownListENEx,
      StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPDropDownListENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPDropDownListENEx.mKey);
            }
            string strFldName = objASPDropDownListENEx.FldName;
            if (string.IsNullOrEmpty(objASPDropDownListENEx.ItemName4MultiModel) == false)
            {
                strFldName = string.Format("{0}.{1}", objASPDropDownListENEx.ItemName4MultiModel, objASPDropDownListENEx.FldName);
            }
            if (objASPDropDownListENEx.DDLItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
            {
                strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.{1}, ViewData[\"TrueAndFalseList\"] as List<SelectListItem>, new {{ Name=\"{2}\" }})",
                    objASPDropDownListENEx.TabName, strFldName, objASPDropDownListENEx.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.{1}, ViewData[\"{2}List\"] as List<SelectListItem>, new {{ Name=\"{3}\" }})",
                    objASPDropDownListENEx.TabName, strFldName, objASPDropDownListENEx.DS_TabName, objASPDropDownListENEx.FldName);
            }
            
        }

        public static void GeneHtmlControl(this ASPDropDownListEx objASPDropDownListENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPDropDownListENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPDropDownListENEx.mKey);
            }
            HtmlSelect objSelect = new HtmlSelect();
            objSelect.Attributes["class"]= "form-control";
            objSelect.ID = objASPDropDownListENEx.CtrlId;
            objSelect.Name = objASPDropDownListENEx.CtrlName;
            objContainer.Controls.Add(objSelect);
            return;

        }

        /// <summary>
        /// 生成绑定下拉框的代码
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <returns></returns>
        public static string GC_BindDdl(this ASPDropDownListEx objASPDropDownListENEx)
        {
            string strCodeForCs = "";
            if (objASPDropDownListENEx.CSType == "bool")
            {
                strCodeForCs = string.Format("clsCommForWebForm.BindDdl_TrueAndFalse({0});", objASPDropDownListENEx.CtrlId);

            }
            else
            {

                if (objASPDropDownListENEx.objPrjTabEN_CodeTab == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源表没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objASPDropDownListENEx.objFieldTabEN_ValueField == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源值字段没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objASPDropDownListENEx.objFieldTabEN_TextField == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源文本字段没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                strCodeForCs = string.Format("cls{2}BL.BindDdl_{0}({1});",
                        objASPDropDownListENEx.objFieldTabEN_ValueField.FldName,
                        objASPDropDownListENEx.CtrlId,
                        objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName);
            }
            return strCodeForCs;
        }

        public static string GC_BindDdl4WA_TS(this ASPDropDownListEx objASPDropDownListENEx)
        {
            string strCodeForCs = "";
            if (objASPDropDownListENEx.CSType == "bool")
            {
                strCodeForCs = string.Format("clsCommForWebForm.BindDdl_TrueAndFalse({0});", objASPDropDownListENEx.CtrlId);

            }
            else
            {

                if (objASPDropDownListENEx.objPrjTabEN_CodeTab == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源表没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objASPDropDownListENEx.objFieldTabEN_ValueField == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源值字段没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objASPDropDownListENEx.objFieldTabEN_TextField == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源文本字段没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                strCodeForCs = string.Format("cls{2}WApi.BindDdl_{0}_Cache({1});",
                        objASPDropDownListENEx.objFieldTabEN_ValueField.FldName,
                        objASPDropDownListENEx.CtrlId,
                        objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName);
            }
            return strCodeForCs;
        }


        /// <summary>
        /// 生成绑定下拉框的代码
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <returns></returns>
        public static string GC_BindDdl4Mvc(this ASPDropDownListEx objASPDropDownListENEx)
        {
            string strCodeForCs = "";
            if (objASPDropDownListENEx.CSType == "bool")
            {
                //strCodeForCs = string.Format("clsCommForWebForm.BindDdl_TrueAndFalse({0});", objASPDropDownListENEx.CtrlId);
                strCodeForCs = string.Format("  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
            }
            else
            {

                if (objASPDropDownListENEx.objPrjTabEN_CodeTab == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源表没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objASPDropDownListENEx.objFieldTabEN_ValueField == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源值字段没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objASPDropDownListENEx.objFieldTabEN_TextField == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源文本字段没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                //strCodeForCs = string.Format("cls{2}BL.BindDdl_{0}({1});",
                //        objASPDropDownListENEx.objFieldTabEN_ValueField.FldName,
                //        objASPDropDownListENEx.CtrlId,
                //        objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName);
                strCodeForCs = string.Format("ViewData[\"{0}List\"] = cls{0}BL4Mvc.GetObjLst4SelectListItem(\"1=1\");",
                                      objASPDropDownListENEx.DS_TabName);

            }
            return strCodeForCs;
        }



        /// <summary>
        /// 生成绑定下拉框的代码
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <returns></returns>
        public static string GC_SetBindDdl(this ASPDropDownListEx objASPDropDownListENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objASPDropDownListENEx.CSType == "bool")
            {
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 设置绑定下拉框，针对字段:[{0}]",
                  objASPDropDownListENEx.FldName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public void SetDdl_{0}()", objASPDropDownListENEx.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("clsCommForWebForm.BindDdl_TrueAndFalse({0});", objASPDropDownListENEx.CtrlId);
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {

                if (objASPDropDownListENEx.objPrjTabEN_CodeTab == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源表没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objASPDropDownListENEx.objFieldTabEN_ValueField == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源值字段没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objASPDropDownListENEx.objFieldTabEN_TextField == null)
                {
                    string strMsg = string.Format("在界面查询区，{0}下拉框的数据源文本字段没有设置，请检查！({1})",
                        objASPDropDownListENEx.CtrlName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// 设置绑定下拉框，针对字段:[{0}]",
                  objASPDropDownListENEx.FldName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public void SetDdl_{0}()", objASPDropDownListENEx.FldName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("cls{2}BL.BindDdl_{0}({1});",
                        objASPDropDownListENEx.objFieldTabEN_ValueField.FldName,
                        objASPDropDownListENEx.CtrlId,
                        objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成绑定下拉框的代码
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <returns></returns>
        public static string GC_BindDdlFunc(this ASPDropDownListEx objASPDropDownListENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objASPDropDownListENEx.CSType == "bool") return "";

            if (objASPDropDownListENEx.objPrjTabEN_CodeTab == null)
            {
                string strMsg = string.Format("在界面查询区，{0}下拉框的数据源表没有设置，请检查！({1})",
                    objASPDropDownListENEx.CtrlName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (objASPDropDownListENEx.objFieldTabEN_ValueField == null)
            {
                string strMsg = string.Format("在界面查询区，{0}下拉框的数据源值字段没有设置，请检查！({1})",
                    objASPDropDownListENEx.CtrlName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (objASPDropDownListENEx.objFieldTabEN_TextField == null)
            {
                string strMsg = string.Format("在界面查询区，{0}下拉框的数据源文本字段没有设置，请检查！({1})",
                    objASPDropDownListENEx.CtrlName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            //strCodeForCs = string.Format("cls{2}BL.BindDdl_{0}({1});",
            //        objASPDropDownListENEx.objFieldTabEN_ValueField.FldName,
            //        objASPDropDownListENEx.CtrlId,
            //        objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName);

            switch (objASPDropDownListENEx.DDLItemsOptionId)
            {
                case "01": ///列表项串;
                    //									string strTemp2 ;
                    string delimStr = " ,.:";
                    char[] delimiter = delimStr.ToCharArray();
                    //									string words = "one two,three:four.";
                    string[] split = null;
                    int iItemNums;
                    int i;
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n ///绑定下拉框:{0}的函数。", objASPDropDownListENEx.CtrlId);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    objASPDropDownListENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                    split = objASPDropDownListENEx.ItemsString.Split(delimiter);
                    iItemNums = split.GetUpperBound(0);
                    for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                    }
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "//为下拉框设置内容的样例,该下拉框的列表项是直接添加的");
                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"男\");");
                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"女\");");
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                case "02": ///列表项数据源表;
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从表:[{0}]中获取",
                      objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>");

                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()",
                    objASPDropDownListENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");

                    if (objASPDropDownListENEx.DS_CondStr.Trim() == "")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                        objASPDropDownListENEx.objFieldTabEN_ValueField.FldName, objASPDropDownListENEx.objFieldTabEN_TextField.FldName, objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";",
                        objASPDropDownListENEx.objFieldTabEN_ValueField.FldName, objASPDropDownListENEx.objFieldTabEN_TextField.FldName, objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName, objASPDropDownListENEx.DS_CondStr);
                    }

                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName);

                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objDT;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Web的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                      objASPDropDownListENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                    objASPDropDownListENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                      objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName, objASPDropDownListENEx.objFieldTabEN_ValueField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                      objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName, objASPDropDownListENEx.objFieldTabEN_TextField.FldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                case "03": ///列表项数据源SQL串;
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从Sql串:[{0}]中获取",
                       objASPDropDownListENEx.DS_SQLStr);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <returns>获取自定义的Sql串中两列的所有记录记录的DataTable</returns>");

                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                    objASPDropDownListENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName);

                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                    objASPDropDownListENEx.DS_SQLStr);
                    strCodeForCs.Append("\r\n" + "return objDT;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Web的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">需要绑定当前表的下拉框</param>");

                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    objASPDropDownListENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                    objASPDropDownListENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                      objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName,
                      objASPDropDownListENEx.objFieldTabEN_ValueField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                      objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName, objASPDropDownListENEx.objFieldTabEN_TextField.FldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                    break;
            }
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();


        }
    }
    /// <summary>
    /// ASPNET下拉框(ASPNETDropDownList)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPDropDownListBLEx 
    {



        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPDropDownListEx objASPDropDownListENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private DropDownList {0};",
                objASPDropDownListENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPDropDownListEx objASPDropDownListENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (DropDownList)findViewById(R.id.{0}); ",
                objASPDropDownListENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPDropDownListEx objASPDropDownListENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (DropDownList)view.findViewById(R.id.{0}); ",
                objASPDropDownListENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(ASPDropDownListEx objASPDropDownListENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            string strDdlTabName = objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n" + "String {0} = mobjddlBind{1}.getDdlAdapter{1}().get{2}((int){3}.getSelectedItemId());",
                             objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                             strDdlTabName,
                             objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                         objASPDropDownListENEx.CtrlId);

            //strCodeForCs.AppendFormat("\r\n" + "String {0} = (String){1}.getSelectedItem();",
            //  objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
            //  objASPDropDownListENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n" + " if ({0} == null) return \"\";",
              objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                              string.Format("{0}", objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName)));


            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(ASPDropDownListEx objASPDropDownListENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            string strDdlTabName = objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            //String strCollegeId = mobjddlBindCollege.getDdlAdapterCollege().getCollegeId((int)spnCollegeId.getSelectedItemId());

            strCodeForCs.AppendFormat("\r\n" + "String {0} = mobjddlBind{1}.getDdlAdapter{1}().get{2}((int){3}.getSelectedItemId());",
                                objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                                strDdlTabName,
                                objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName,
                            objASPDropDownListENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n" + " if ({0} == null) return \"\";",
                objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                              string.Format("{0}", objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName)));

            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(ASPDropDownListEx objASPDropDownListENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setSelection(1);",
                objASPDropDownListENEx.CtrlId,
                AgcPubFun.getToStringCode4DataType4Java(objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(ASPDropDownListEx objASPDropDownListENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption,
                objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setSelection(1);",
 objASPDropDownListENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPDropDownListEx objASPDropDownListENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objASPDropDownListENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlBak20180403(ASPDropDownListEx objASPDropDownListENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPDropDownListENEx.objEditRegionFldsENEx != null)
            {
                string strTabName_Ddl = objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                strCodeForCs.AppendFormat("\r\n" + "ac{0}_UnitTestEx.BindDdl_{1}(spn{1}, this);",
                   strTabName_Ddl,
                   objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            }
            if (objASPDropDownListENEx.objQryRegionFldsENEx != null)
            {
                string strTabName_Ddl = objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                strCodeForCs.AppendFormat("\r\n" + "ac{0}_UnitTestEx.BindDdl_{1}(spn{1}, this);",
                   strTabName_Ddl,
                   objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            }

        }

        /// <summary>
        /// 绑定下拉框 
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdl(ASPDropDownListEx objASPDropDownListENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPDropDownListENEx.objEditRegionFldsENEx != null)
            {
                string strTabName_Ddl = objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;

                strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindDdl_{0}\", {1}, mobjddlBind{0});",
                   strTabName_Ddl,
                   objASPDropDownListENEx.CtrlId);

            }
            if (objASPDropDownListENEx.objQryRegionFldsENEx != null)
            {
                string strTabName_Ddl = objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;

                strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindDdl_{0}_q\", {1}, mobjddlBind{0});",
                   strTabName_Ddl,
                   objASPDropDownListENEx.CtrlId);

            }

        }

        /// <summary>
        /// 绑定下拉框, 在任务队列中 
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlInTaskQueue(ASPDropDownListEx objASPDropDownListENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objASPDropDownListENEx.objEditRegionFldsENEx != null)
            {
                string strTabName_Ddl = objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                string strValueFld = objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTab_Code;
                strCodeForCs.AppendFormat("\r\n" + "case \"BindDdl_{0}\":", strTabName_Ddl);

                strCodeForCs.AppendFormat("\r\n" + "ddlBind{0} objDdlBind{0} = (ddlBind{0})myTask.getDdlBind();",
                    strTabName_Ddl);
                strCodeForCs.AppendFormat("\r\n" + "objDdlBind{0}.BindDdl_{1}(myTask.getDropDownList(), myTask.getActivity());",
                    strTabName_Ddl, strValueFld);
                strCodeForCs.Append("\r\n" + "break;");


            }
            if (objASPDropDownListENEx.objQryRegionFldsENEx != null)
            {
                string strTabName_Ddl = objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                string strValueFld = objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTab_Code;

                strCodeForCs.AppendFormat("\r\n" + "case \"BindDdl_{0}_q\":", strTabName_Ddl);

                strCodeForCs.AppendFormat("\r\n" + "ddlBind{0} objDdlBind{0}_q = (ddlBind{0})myTask.getDdlBind();",
                    strTabName_Ddl);
                strCodeForCs.AppendFormat("\r\n" + "objDdlBind{0}_q.BindDdl_{1}(myTask.getDropDownList(), myTask.getActivity());",
                    strTabName_Ddl, strValueFld);
                strCodeForCs.Append("\r\n" + "break;");


            }

        }


        /// <summary>
        /// 绑定下拉框 
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>        
        /// <param name="strCodeForCs"></param>
        /// <param name="arrDdlBindObjLst"></param>
        public static void Gen_DefDdlBindObj(ASPDropDownListEx objASPDropDownListENEx, StringBuilder strCodeForCs, List<string> arrDdlBindObjLst)
        {
            if (objASPDropDownListENEx.objEditRegionFldsENEx != null)
            {
                string strTabName_Ddl = objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                string strDdlBindObjName = string.Format("mobjddlBind{0}", strTabName_Ddl);
                if (arrDdlBindObjLst.Contains(strDdlBindObjName) == false)
                {
                    arrDdlBindObjLst.Add(strDdlBindObjName);
                    strCodeForCs.AppendFormat("\r\n" + "private ddlBind{0} {1} = null;",
                       strTabName_Ddl,
                       strDdlBindObjName);
                }
            }
            if (objASPDropDownListENEx.objQryRegionFldsENEx != null)
            {
                string strTabName_Ddl = objASPDropDownListENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName;
                string strDdlBindObjName = string.Format("mobjddlBind{0}", strTabName_Ddl);
                if (arrDdlBindObjLst.Contains(strDdlBindObjName) == false)
                {
                    arrDdlBindObjLst.Add(strDdlBindObjName);
                    strCodeForCs.AppendFormat("\r\n" + "private ddlBind{0} {1} = null;",
                       strTabName_Ddl,
                       strDdlBindObjName);
                }
            }

        }


        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objASPDropDownListENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(ASPDropDownListEx objASPDropDownListENEx, StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "{0}.setSelection(0);",
               objASPDropDownListENEx.CtrlId);
            strCodeForCs.AppendFormat("// {0}", objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldLength,
            objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.IsNull,
            objASPDropDownListENEx.objEditRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.MemoInTab);

        }

        //public static ASPDropDownListEx GetDropDownLst_Asp(clsViewFeatureFldsENEx objViewFeatureFldsEx)
        //{
        //    if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
        //    ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();


        //    ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
        //    objASPDropDownListENEx.CtrlId = objViewFeatureFldsEx.CtrlId;
        //    objASPDropDownListENEx.Width = 200;
        //    objASPDropDownListENEx.CssClass = "form-control";
        //    objASPDropDownListENEx.objViewFeatureFldsENEx = objViewFeatureFldsEx;
        //    objASPDropDownListENEx.CSType = objViewFeatureFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.CSType;
        //    if (objViewFeatureFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.CSType == "bool")
        //    {
        //    }
        //    else
        //    {
        //        objASPDropDownListENEx.objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objViewFeatureFldsEx.DS_TabId);
        //        objASPDropDownListENEx.objFieldTabEN_ValueField = clsFieldTabBLEx.GetObjByFldID_Cache(objViewFeatureFldsEx.DS_DataValueFieldId, 
        //            objViewFeatureFldsEx.ObjFieldTabENEx.PrjId);
        //        objASPDropDownListENEx.objFieldTabEN_TextField = clsFieldTabBLEx.GetObjByFldID_Cache(objViewFeatureFldsEx.DS_DataTextFieldId, 
        //            objViewFeatureFldsEx.ObjFieldTabENEx.PrjId);

        //    }
        //    return objASPDropDownListENEx;
        //}


        public static ASPDropDownListEx GetDropDownLst_Asp(clsvViewFeatureFldsENEx objViewFeatureFldsEx, IGetTabFieldObj objGetTabFieldObj)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();


            ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
            objASPDropDownListENEx.CtrlId = objViewFeatureFldsEx.CtrlId;
            objASPDropDownListENEx.Width = 200;
            objASPDropDownListENEx.CssClass = "form-control";
            objASPDropDownListENEx.objViewFeatureFldsENEx = objViewFeatureFldsEx;
            objASPDropDownListENEx.CSType = objViewFeatureFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.CSType;
            if (objViewFeatureFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.CSType == "bool")
            {
                objASPDropDownListENEx.DS_TabName = "TrueAndFalse";
            }
            else
            {
                objASPDropDownListENEx.objPrjTabEN_CodeTab = objGetTabFieldObj.GetObjByTabId(objViewFeatureFldsEx.DS_TabId, objViewFeatureFldsEx.ObjFieldTabENEx.PrjId);
                objASPDropDownListENEx.objFieldTabEN_ValueField = objGetTabFieldObj.GetObjByFldId(objViewFeatureFldsEx.DS_DataValueFieldId,
                    objViewFeatureFldsEx.ObjFieldTabENEx.PrjId);
                objASPDropDownListENEx.objFieldTabEN_TextField = objGetTabFieldObj.GetObjByFldId(objViewFeatureFldsEx.DS_DataTextFieldId,
                    objViewFeatureFldsEx.ObjFieldTabENEx.PrjId);
                objASPDropDownListENEx.DS_TabName = objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName;

            }
            return objASPDropDownListENEx;
        }


        public static ASPDropDownListEx GetDropDownLst_Asp(clsQryRegionFldsENEx objQryRegionFldsEx, IGetTabFieldObj objGetTabFieldObj)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();


            ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
            objASPDropDownListENEx.CtrlId = objQryRegionFldsEx.CtrlId;
            objASPDropDownListENEx.Width = 200;
            objASPDropDownListENEx.CssClass = "form-control";
            objASPDropDownListENEx.objQryRegionFldsENEx = objQryRegionFldsEx;
            objASPDropDownListENEx.CSType = objQryRegionFldsEx.objPrjTabFldENEx.CSType;
            if (objQryRegionFldsEx.objPrjTabFldENEx.CSType == "bool")
            {
                objASPDropDownListENEx.DS_TabName = "TrueAndFalse";
            }
            else
            {
                objASPDropDownListENEx.objPrjTabEN_CodeTab = objGetTabFieldObj.GetObjByTabId(objQryRegionFldsEx.DS_TabId, objQryRegionFldsEx.objPrjTabFldENEx.PrjId);
                objASPDropDownListENEx.objFieldTabEN_ValueField = objGetTabFieldObj.GetObjByFldId(objQryRegionFldsEx.DS_DataValueFieldId, 
                    objQryRegionFldsEx.objPrjTabFldENEx.PrjId);
                objASPDropDownListENEx.objFieldTabEN_TextField = objGetTabFieldObj.GetObjByFldId(objQryRegionFldsEx.DS_DataTextFieldId, objQryRegionFldsEx.objPrjTabFldENEx.PrjId);
                objASPDropDownListENEx.DS_TabName = objASPDropDownListENEx.objPrjTabEN_CodeTab.TabName;
            }
            return objASPDropDownListENEx;
        }


        public static ASPDropDownListEx GetDropDownLst_Asp(clsEditRegionFldsENEx objEditRegionFldsEx, IGetTabFieldObj objGetTabFieldObj)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            ASPControlGroupEx objASPControlGroupENEx = new ASPControlGroupEx();


            ASPDropDownListEx objASPDropDownListENEx = new ASPDropDownListEx();
            objASPDropDownListENEx.CtrlId = objEditRegionFldsEx.CtrlId;
            objASPDropDownListENEx.Width = 200;
            objASPDropDownListENEx.CssClass = "form-control";
            objASPDropDownListENEx.objEditRegionFldsENEx = objEditRegionFldsEx;
            objASPDropDownListENEx.CSType = objEditRegionFldsEx.ObjPrjTabFldENEx.CSType;
            objASPDropDownListENEx.FldName = objEditRegionFldsEx.ObjPrjTabFldENEx.FldName;
            objASPDropDownListENEx.ItemsString = objEditRegionFldsEx.ItemsString;
            objASPDropDownListENEx.DS_CondStr = objEditRegionFldsEx.DS_CondStr;
            objASPDropDownListENEx.DS_SQLStr = objEditRegionFldsEx.DS_SQLStr;

            objASPDropDownListENEx.DDLItemsOptionId = objEditRegionFldsEx.DDLItemsOptionId;
            if (objEditRegionFldsEx.ObjPrjTabFldENEx.CSType == "bool")
            {
            }
            else
            {
                objASPDropDownListENEx.objPrjTabEN_CodeTab = objGetTabFieldObj.GetObjByTabId(objEditRegionFldsEx.DS_TabId, objEditRegionFldsEx.ObjPrjTabFldENEx.PrjId);
                objASPDropDownListENEx.objFieldTabEN_ValueField = objGetTabFieldObj.GetObjByFldId(objEditRegionFldsEx.DS_DataValueFieldId, objEditRegionFldsEx.ObjPrjTabFldENEx.PrjId);
                objASPDropDownListENEx.objFieldTabEN_TextField = objGetTabFieldObj.GetObjByFldId(objEditRegionFldsEx.DS_DataTextFieldId, objEditRegionFldsEx.ObjPrjTabFldENEx.PrjId);

            }
            return objASPDropDownListENEx;
        }

      

    }
}