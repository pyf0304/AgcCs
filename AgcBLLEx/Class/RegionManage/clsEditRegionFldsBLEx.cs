using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

using com.taishsoft.commexception;
using AGC.BusinessLogic;
using com.taishsoft.common;
using AGC.DAL;
using com.taishsoft.datetime;
using com.taishsoft.commdb;
using AGC.PureClass;
using AGC.PureClassEx;
using System.Diagnostics.Eventing.Reader;
//using AGC.PureClassEx;

namespace AGC.BusinessLogicEx
{

    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_EditRegionFldsEx : RelatedActions_EditRegionFlds
    {

        public override bool UpdRelaTabDate(long lngmId, string strOpUser)
        {
            var objEditRegionFlds = clsEditRegionFldsBL.GetObjBymId(lngmId);
            var objViewRegion = clsViewRegionBL.GetObjByRegionId(objEditRegionFlds.RegionId);
            if (objViewRegion == null) return false;
            clsViewRegionBL.SetUpdDate(objEditRegionFlds.RegionId, strOpUser);
            return true;
        }
    }
    public static class clsEditRegionFldsBLEx_Static
    {

        /// <summary>
        /// 是否是表字段
        /// </summary>
        /// <param name="objEditRegionFldsEx"></param>
        /// <returns></returns>
        public static bool IsTabField(this clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.FldId, objEditRegionFldsEx.PrjId());
            if (objPrjTabFld == null) return false;
            return true;
        }
        public static clsFieldTabEN ObjFieldTab1(this clsEditRegionFldsENEx objEditRegionFldsEN)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objEditRegionFldsEN.FldId, objEditRegionFldsEN.PrjId);
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据查询区字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objEditRegionFldsEN"></param>
        /// <returns></returns>
        public static string PropertyName(this clsEditRegionFldsENEx objEditRegionFldsEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objEditRegionFldsEN.FldName;
            }
            else
            {
                return clsString.FstLcaseS(objEditRegionFldsEN.FldName);
            }
        }
    
        //public static string PrimaryTypeId(this clsEditRegionFldsENEx objEditRegionFldsEx, string strCmPrjId)
        //{
        //    var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, strCmPrjId).TabId;
        //    var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId, objEditRegionFldsEx.PrjId());
        //    if (objPrjTabFld == null)
        //    {
        //        objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldId(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId);
        //        if (objPrjTabFld != null) clsPrjTabFldBL.ReFreshCache(objEditRegionFldsEx.PrjId());
        //        else return "";
        //    }
        //    return objPrjTabFld.PrimaryTypeId;
        //}
        public static bool IsTabNullable(this clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId, objEditRegionFldsEx.PrjId());
            if (objPrjTabFld == null) return true;
            return objPrjTabFld.IsTabNullable;
        }
        public static bool IsTabForeignKey(this clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId, objEditRegionFldsEx.PrjId());
            return objPrjTabFld.IsTabForeignKey;
        }
        public static bool IsTabUnique(this clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId, objEditRegionFldsEx.PrjId());
            return objPrjTabFld.IsTabUnique;
        }
        public static bool IsPrimaryKey_Identity(this clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId, objEditRegionFldsEx.PrjId());
            if (objPrjTabFld == null) return false;
            if (objPrjTabFld.PrimaryTypeId == enumPrimaryType.Identity_02) return true;
            else return false;
        }

        public static string MemoInTab(this clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId, objEditRegionFldsEx.PrjId());
            return objPrjTabFld.MemoInTab;
        }

        public static string FldOpTypeId(this clsEditRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId, objEditRegionFldsEx.PrjId());
            if (objPrjTabFld == null) return enumFldOperationType.ReadWrite_0001;
            return objPrjTabFld.FldOpTypeId;
        }


        /// <summary>
        /// 控件输入是否正确
        /// </summary>
        /// <param name="objEditRegionFldsEx"></param>
        /// <returns></returns>
        public static string GC_IsValid_CtrlInput(this clsEditRegionFldsENEx objEditRegionFldsEx, string strCmPrjId)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                     && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId == enumCtlType.DropDownList_06) return "";
            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int" ||
                objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "long" ||
                objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "short" ||
                objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "DateTime" ||
                objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "double" ||
                objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "single")
            {
                strCodeForCs.AppendFormat("\r\n" + "ComValid_{0}.Validate();",
                    objEditRegionFldsEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "if (!ComValid_{0}.IsValid) return false;",
                    objEditRegionFldsEx.FldName);
            }

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 输入的数据类型是否正确
        /// </summary>
        /// <param name="objEditRegionFldsEx"></param>
        /// <returns></returns>
        public static string GC_IsValidDataType(this clsEditRegionFldsENEx objEditRegionFldsEx, string strCmPrjId)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                      && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
            {
                case "int":
                case "long":
                case "short":
                    strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text)  ==  false)",
                        objEditRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的整型!\";");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                case "double":
                case "float":
                case "single":
                    strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text)  ==  false)",
                        objEditRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的浮点型!\";");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                case "DateTime":
                    strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text)  ==  false)",
                        objEditRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的日期型!\";");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                case "bool":
                    break;
                default:
                    break;
            }

            return strCodeForCs.ToString();
        }


        public static string GC_DefFldProperty(this clsEditRegionFldsENEx objEditRegionFldsEx, string strCmPrjId)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}",
                objEditRegionFldsEx.LabelCaption);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                objEditRegionFldsEx.FldName);
            strCodeForCs.Append("\r\n" + "{");
            switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
            {
                case "Button":
                    break;
                case "CheckBox":
                    strCodeForCs.Append("\r\n" + "get");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                        objEditRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "set");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                        objEditRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                case "CheckBoxList":
                    break;
                case "DataGrid":
                    break;
                case "DataList":
                    break;

                case "DropDownList":    //如果控件是下拉框;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                    {
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                            objEditRegionFldsEx.CtrlId);
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
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int"
                        || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bigint"
                        || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "short"
                       )
                    {
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue  ==  \"0\")",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.AppendFormat("\r\n" + "return 0;");
                        strCodeForCs.AppendFormat("\r\n" + "return {1}.Parse({0}.SelectedValue);",
                            objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.CsType());
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "set");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "if (value  ==  0)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value.ToString();",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue  ==  \"0\")",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                        strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue;",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "set");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                            objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    break;

                case "HyperLink":
                    break;

                case "Image":
                    break;

                case "ImageButton":
                    break;

                case "Label":
                    break;

                case "Link1Button":
                    break;

                case "ListBox":
                    break;

                case "Panel":
                    break;

                case "RadioButton":
                    break;

                case "RadioButtonList":
                    break;

                case "TextBox":     //如果控件类型是文本框;
                    strCodeForCs.Append("\r\n" + "get");
                    strCodeForCs.Append("\r\n" + "{");
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;

                        case "short":
                            strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;

                        case "double":

                            strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        case "DateTime":

                            strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        case "bool":
                            strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "set");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                default:

                    strCodeForCs.Append("\r\n" + "get");
                    strCodeForCs.Append("\r\n" + "{");
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;

                        case "short":
                            strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;

                        case "double":
                            strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        case "bool":
                            strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "set");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "}");
                    break;
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public static string GC_SetDefaultValue(this clsEditRegionFldsENEx objEditRegionFldsEx, string strCmPrjId)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                      && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
            {
                case "Button":
                    break;
                case "CheckBox":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objEditRegionFldsEx.CtrlId);
                    break;
                case "CheckBoxList":
                    break;
                case "DataGrid":
                    break;
                case "DataList":
                    break;
                case "DropDownList":    //如果控件是下拉框;
                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                        objEditRegionFldsEx.CtrlId);
                    break;
                case "HyperLink":
                    break;
                case "Image":
                    break;
                case "ImageButton":
                    break;
                case "Label":
                    break;
                case "Link1Button":
                    break;
                case "ListBox":
                    break;
                case "Panel":
                    break;
                case "RadioButton":
                    break;
                case "RadioButtonList":
                    break;
                case "TextBox":     //如果控件类型是文本框;
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";", objEditRegionFldsEx.CtrlId);
                            break;
                        case "double":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        case "bool":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"false\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                    }
                    break;
                default:
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";", objEditRegionFldsEx.CtrlId);
                            break;
                        case "double":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        case "bool":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"false\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                                objEditRegionFldsEx.CtrlId);
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"\";",
                                objEditRegionFldsEx.CtrlId);
                            break;

                    }
                    break;

            }

            return strCodeForCs.ToString();
        }
    }

    public partial class clsEditRegionFldsBLEx : clsEditRegionFldsBL
    {
        public static string strPrjIdCache_Init = "";
        public static int intKeyNum = 0;
        public static IEnumerable<ASPControlGroupEx> GetControlGroup(string lngRegionId, string strCmPrjId,  string strPrjId, string strItemName4MultiModel, bool bolIs4PureHtml = false)
        {
            clsvViewRegionEN objViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(lngRegionId, strCmPrjId);
            bool bolIs4PureHtml_p = bolIs4PureHtml;
            if (bolIs4PureHtml_p == false)
            {
                switch(                objViewRegion.ApplicationTypeId)
                {
                    case (int)enumApplicationType.WebApp_2:
                        break;
                    case (int)enumApplicationType.SpaAppInCore_TS_18:
                    case (int)enumApplicationType.WebApp_JS_RJ_28:
                        bolIs4PureHtml_p = true;
                        break;
                    default:
                        bolIs4PureHtml_p = true;
                        break;
                }
            }
            //Func<clsEditRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4MultiModel = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, strItemName4MultiModel);
            List<clsEditRegionFldsENEx> arrEditRegionFlds = clsEditRegionFldsBLEx.GetObjExLstByRegionIdCacheEx2(lngRegionId, strPrjId);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst = arrEditRegionFlds.Select(x=> clsASPControlGroupBLEx.GetControlGroup_Asp(x, strCmPrjId, strItemName4MultiModel, bolIs4PureHtml_p));
            //把查询按钮加进来
            //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
            //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
            //arrButtonObjLst.Add(objASPControlGroup);

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = clsFeatureRegionFldsBLEx.GetObjExLstByRegionIdEx(lngRegionId, strPrjId);//  objViewInfoENEx.arrFeatureRegionFlds;
            if (arrFeatureRegionFldsObjLst == null)
            {

                string strMsg = string.Format("界面功能区为空，请添加界面功能！区域输入表:{0}. (In {1})", objViewRegion.TabName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            bool bolIsHasExport = true;
            //if (objViewInfoENEx.objViewRegion_ExportExcel == null) bolIsHasExport = false;
            IEnumerable<ASPControlGroupEx> arrButtonGroupLst = arrFeatureRegionFldsObjLst
                    .Where(x => x.RegionId == lngRegionId)
                    .Select(obj => clsFeatureRegionFldsBLEx.GetButtonGroup(obj, objViewRegion.ApplicationTypeId ?? 0, bolIsHasExport));

            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);

            arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonGroupLst);
            return arrASPControlGroupObjLst;

        }

       
        public static void initEditRegionFldSet(clsViewInfoENEx objViewInfoENEx, bool bolIsFstLcase)
        {
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //  然后存到集合中
            //3、
            //
            objViewInfoENEx.TabKeyFldNum = 0;

            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(objViewInfoENEx.ViewId,
                clsRegionTypeENEx.EDITREGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }

            objViewInfoENEx.arrEditRegionFldSet4InUse = clsEditRegionFldsBLEx.GetObjExLstByRegionId4InUse2(lngRegionId, bolIsFstLcase, objViewInfoENEx.PrjId, objViewInfoENEx.ViewId);
            objViewInfoENEx.arrEditRegionFldSet = clsEditRegionFldsBLEx.GetObjExLstByRegionId1(lngRegionId, objViewInfoENEx.PrjId);
            objViewInfoENEx.arrPrjFeature = clsPrjFeatureBLEx.GetObjExLstByViewIdCache(objViewInfoENEx.ViewId, objViewInfoENEx.ApplicationTypeId, 
                objViewInfoENEx.PrjId);
            objViewInfoENEx.arrButtonTab = new List<clsButtonTabENEx>();
            foreach (clsPrjFeatureENEx objInFor in objViewInfoENEx.arrPrjFeature)
            {
                foreach (clsvFeatureButtonRelaEN objInFor2 in objInFor.ButtonSet)
                {
                    clsButtonTabEN objButtonTabEN = clsButtonTabBL.GetObjByButtonIdCache(objInFor2.ButtonId);
                    clsButtonTabENEx objButtonTabENEx = new clsButtonTabENEx();
                    clsButtonTabBL.CopyTo(objButtonTabEN, objButtonTabENEx);
                    objViewInfoENEx.arrButtonTab.Add(objButtonTabENEx);
                }
            }
            //if (objViewInfoENEx.arrEditRegionFldSet4InUse  ==  null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count  ==  0)
            //{
            //    intViewFldNum = 0;
            //    return;
            //}
            //objViewInfoENEx.objEditRegionENEx.FieldNum = objViewInfoENEx.arrEditRegionFldSet4InUse.Count;
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {                
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
            }
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewInfoENEx.arrEditRegionFldSet)
            {

                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
            }
        }

        //public static void initDetailRegionFldSet(clsViewInfoENEx objViewInfoENEx)
        //{
        //    //步骤:
        //    //1、判断初始数据是否合法
        //    //2、把表中相关信息初始化到一个类对象中,
        //    //  然后存到集合中
        //    //3、
        //    ///
        //    objViewInfoENEx.TabKeyFldNum = 0;
        //    //objViewInfoENEx.TabName = objViewInfoENEx.objMainPrjTab.TabName;            

        //    //获取区域ID
        //    string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache(objViewInfoENEx.ViewId, clsRegionTypeENEx.DETAILREGION, objViewInfoENEx.PrjId);
        //    if (string.IsNullOrEmpty( lngRegionId )== true)
        //    {
        //        return;
        //    }
        //    objViewInfoENEx.objEditRegionENEx = new clsEditRegionENEx(lngRegionId);
        //    clsEditRegionBLEx.GetEditRegionEx(ref objViewInfoENEx.objEditRegionENEx, objViewInfoENEx.PrjId);
        //    //objViewInfoENEx.objEditRegionENEx.InitViewRegion();

        //    objViewInfoENEx.arrDetailRegionFldSet = clsEditRegionFldsBLEx.GetObjExLstByRegionId4InUse(lngRegionId, objViewInfoENEx.PrjId);
        //    //if (objViewInfoENEx.arrDetailRegionFldSet  ==  null || objViewInfoENEx.arrDetailRegionFldSet.Count  ==  0)
        //    //{
        //    //    intViewFldNum = 0;
        //    //    return;
        //    //}
        //    objViewInfoENEx.objEditRegionENEx.FieldNum = objViewInfoENEx.arrDetailRegionFldSet.Count;
        //    foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewInfoENEx.arrDetailRegionFldSet)
        //    {
         
        //        objEditRegionFldsENEx.ObjPrjTabFldENEx = clsPrjTabFldBLEx.InitPrjTabFld(objEditRegionFldsENEx.TabFldId, objViewInfoENEx.PrjId);

        //        objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
        //    }
        //}

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "lngRegionId">所给的关键字</param>
        /// <param name = "strPrjId"></param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsEditRegionFldsEN> GetObjLstByRegionIdCache4InUseEx2(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsEditRegionFldsEN> arrObjLstCache = clsEditRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel =
arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
.OrderBy(x => x.SeqNum).ToList();
            return arrEditRegionFldsObjLst_Sel;
        }             

        public static List<clsEditRegionFldsEN> GetObjLstByRegionIdCacheEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsEditRegionFldsEN> arrObjLstCache = clsEditRegionFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel1 =
            from objEditRegionFldsEN in arrObjLstCache
            where objEditRegionFldsEN.RegionId == lngRegionId
            orderby objEditRegionFldsEN.SeqNum
            select objEditRegionFldsEN;
            List<clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel = new List<clsEditRegionFldsEN>();
            foreach (clsEditRegionFldsEN obj in arrEditRegionFldsObjLst_Sel1)
            {
                arrEditRegionFldsObjLst_Sel.Add(obj);
            }          
            return arrEditRegionFldsObjLst_Sel;
        }

        public static List<clsEditRegionFldsENEx> GetEditRegionFldsENExObjListBak20180404(string strCondition)
        {

            List<clsEditRegionFldsENEx> arrObjENExList = new List<clsEditRegionFldsENEx>();
            List<clsEditRegionFldsEN> arrObjList = GetObjLst(strCondition);
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrObjList)
            {
                clsEditRegionFldsENEx objEditRegionFldsENEx = new clsEditRegionFldsENEx();
                CopyTo(objEditRegionFldsEN, objEditRegionFldsENEx);
    
                arrObjENExList.Add(objEditRegionFldsENEx);
            }
            return arrObjENExList;
        }
              
        public static List<clsEditRegionFldsENEx> GetObjExLstByRegionId4InUse2(string lngRegionId, bool bolIsFstLcase, string strPrjId, string strViewId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conEditRegionFlds.InUse);

            List<clsEditRegionFldsENEx> arrObjENExList = new List<clsEditRegionFldsENEx>();
            List<clsEditRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx2(lngRegionId, strPrjId);
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrObjList)
            {
                clsEditRegionFldsENEx objEditRegionFldsENEx = new clsEditRegionFldsENEx();
                CopyTo(objEditRegionFldsEN, objEditRegionFldsENEx);
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objEditRegionFldsENEx.PrjId());
                if (string.IsNullOrEmpty( objEditRegionFldsEN.TabFeatureId4Ddl ) == false)
                {
                    clsTabFeatureENEx4Ddl objTabFeatureENEx4Ddl;
                    try
                    {
                        objTabFeatureENEx4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objEditRegionFldsEN.TabFeatureId4Ddl, objEditRegionFldsENEx.PrjId(), bolIsFstLcase, strViewId);
                    }
                    catch(Exception objException)
                    {
                        string strMsg = $"在获取编辑区的扩展对象列表，获取下拉框的表功能时，出错:【{objException.Message}】.in ({clsStackTrace.GetCurrClassFunction()})";
                        throw new Exception(strMsg);
                    }
                    if (objTabFeatureENEx4Ddl != null)
                    {
                        objEditRegionFldsENEx.ValueFieldName = objTabFeatureENEx4Ddl.ValueFieldName;
                        objEditRegionFldsENEx.TextFieldName = objTabFeatureENEx4Ddl.TextFieldName;

                    }
                }
                arrObjENExList.Add(objEditRegionFldsENEx);
            }
            return arrObjENExList;
        }

        public static List<clsEditRegionFldsENEx> GetObjExLstByRegionId1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conEditRegionFlds.InUse);

            List<clsEditRegionFldsENEx> arrObjENExList = new List<clsEditRegionFldsENEx>();
            List<clsEditRegionFldsEN> arrObjList = GetObjLstByRegionIdCacheEx1(lngRegionId, strCmPrjId);
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrObjList)
            {
                clsEditRegionFldsENEx objEditRegionFldsENEx = new clsEditRegionFldsENEx();
                CopyTo(objEditRegionFldsEN, objEditRegionFldsENEx);
                
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objEditRegionFldsENEx.PrjId());
                arrObjENExList.Add(objEditRegionFldsENEx);
            }
            return arrObjENExList;
        }
        public static List<clsEditRegionFldsENEx> GetObjExLstByRegionIdEx2(string lngRegionId, string strPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conEditRegionFlds.InUse);

            List<clsEditRegionFldsENEx> arrObjENExList = new List<clsEditRegionFldsENEx>();
            List<clsEditRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx2(lngRegionId, strPrjId);
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrObjList)
            {
                clsEditRegionFldsENEx objEditRegionFldsENEx = new clsEditRegionFldsENEx();
                CopyTo(objEditRegionFldsEN, objEditRegionFldsENEx);
                
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objEditRegionFldsENEx.PrjId());

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBLEx.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                arrObjENExList.Add(objEditRegionFldsENEx);
            }
            return arrObjENExList;
        }


        /// <summary>
        /// 功能:设置字段可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置可用的记录数</returns>
        public static int SetInUse(List<long> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(strMid);
                    objEditRegionFldsEN.InUse = true;
                    objEditRegionFldsEN.UpdUser = strUpdUser;
                    objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static int SetMultiLine(List<long> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(strMid);
                    if (objEditRegionFldsEN.IsMultiRow)
                    {
                        objEditRegionFldsEN.IsMultiRow = false;
                    }
                    else
                    {
                        objEditRegionFldsEN.IsMultiRow = true;
                    }
                    objEditRegionFldsEN.InUse = true;
                    objEditRegionFldsEN.UpdUser = strUpdUser;
                    objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 功能:设置字段可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "intColSpan">跨列数</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置可用的记录数</returns>
        public static int SetColSpan(List<long> arrmIdLst, int intColSpan, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(strMid);
                    objEditRegionFldsEN.ColSpan = intColSpan;
                    objEditRegionFldsEN.UpdUser = strUpdUser;
                    objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段跨列数出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static int SetWidth(List<long> arrmIdLst, int intWidth, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(strMid);
                    objEditRegionFldsEN.Width = intWidth;
                    objEditRegionFldsEN.UpdUser = strUpdUser;
                    objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段跨列数出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 功能:设置字段不可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置不可用的记录数</returns>
        public static int SetNotInUse(List<long> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(strMid);
                    objEditRegionFldsEN.InUse = false;
                    objEditRegionFldsEN.UpdUser = strUpdUser;
                    objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段不可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 获取扩展对象列表，同时获取相关表对象属性
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsEditRegionFldsENEx> GetObjExLstEx(string strViewId, string strPrjId)
        {
            //获取区域ID
            string strRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId,
                    enumRegionType.EditRegion_0003, strPrjId);
            if (strRegionId.Length ==0)
            {
                return new List<clsEditRegionFldsENEx>();
                //StringBuilder sbMsg = new StringBuilder();
                //sbMsg.AppendFormat("界面Id:{0},编辑区为空，(in {1})", strViewId, 
                //    clsStackTrace.GetCurrClassFunction());
                //throw new Exception(sbMsg.ToString());
            }
            if (string.IsNullOrEmpty(strRegionId) == true)
            {
                return null;
            }

            List<clsEditRegionFldsENEx> arrEditRegionFldSet = clsEditRegionFldsBLEx.GetObjExList(strRegionId, strPrjId);

            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in arrEditRegionFldSet)
            {
                try
                {
                    objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, strPrjId);
                    if (objEditRegionFldsENEx.FldId.Length > 0 && objEditRegionFldsENEx.ObjFieldTabENEx == null)
                    {
                        continue;
                    }
                    objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                }
                catch (Exception objEx1)
                {
                    if (objEx1.Message.IndexOf("没有字段Id") > -1) continue;
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("界面Id:{0},获取查询字段扩展信息出错，错误:{{1}}.(in {2})",
                        strViewId, objEx1.Message,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(sbMsg.ToString());
                }
            }
            return arrEditRegionFldSet;
        }

        public static List<clsEditRegionFldsENEx> GetObjExList(string lngRegionId, string strPrjId)
        {
            //string strCondition = string.Format("{0}={1} and {2}1='1' order by SeqNum", 
            //    conEditRegionFlds.RegionId, lngRegionId, conEditRegionFlds.InUse);
            List<clsEditRegionFldsENEx> arrObjENExList = new List<clsEditRegionFldsENEx>();
            List<clsEditRegionFldsEN> arrObjList = GetObjLstByRegionIdEx(lngRegionId);
            foreach (clsEditRegionFldsEN objEditRegionENExFldsEN in arrObjList)
            {
                clsEditRegionFldsENEx objEditRegionENExFldsENEx = new clsEditRegionFldsENEx();
                CopyTo(objEditRegionENExFldsEN, objEditRegionENExFldsENEx);
                arrObjENExList.Add(objEditRegionENExFldsENEx);
            }
            return arrObjENExList;
        }

        /// <summary>
        /// 根据区域Id获取相关列表字段对象列表.
        /// </summary>
        /// <param name = "lngRegionId">区域Id</param>
        /// <returns>根据区域Id获取的对象列表</returns>
        public static List<clsEditRegionFldsEN> GetObjLstByRegionIdEx(string lngRegionId)
        {
            //初始化列表缓存
            string strCondition = string.Format("{0}={1}", conEditRegionFlds.RegionId, lngRegionId);
            List<clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel = clsEditRegionFldsBL.GetObjLst(strCondition);
            return arrEditRegionFldsObjLst_Sel;
       
        }

        public static clsEditRegionFldsEN GetObjByvPrjTabFld(clsvPrjTabFldEN objPrjTabFldEN)
        {
            //string lngRegionId = 0;
            string strUserId = "";
            //int intRecNum = 0;
            clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
          
            //2、获取相关主表ID的字段的对象列表;

            if (objPrjTabFldEN.PrimaryTypeId == "02" && objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
            {
                return null;
            }
            //objEditRegionFldsEN.FldId = objPrjTabFldEN.mId;
            //objEditRegionFldsEN.TabId = objPrjTabFldEN.TabId;
            objEditRegionFldsEN.FldId = objPrjTabFldEN.FldId;

            //objEditRegionFldsEN.RegionId = lngRegionId;
            objEditRegionFldsEN.LabelCaption = objPrjTabFldEN.Caption;
            objEditRegionFldsEN.Width = 150;
            switch (objPrjTabFldEN.DataTypeName)
            {
                case "bit":
                    objEditRegionFldsEN.CtlTypeId = "02";
                    break;
                default:
                    objEditRegionFldsEN.CtlTypeId = "16";
                    break;
            }
            var objvFieldTab4CodeConv = objPrjTabFldEN.ObjvFieldTab4CodeConv();
            //判断该字段是否为相关表中的关键字
            if ( (clsEditRegionFldsBLEx.intKeyNum>1 || objPrjTabFldEN.FieldTypeId != enumFieldType.KeyField_02)
                && objvFieldTab4CodeConv != null
                && objvFieldTab4CodeConv.CodeTab != ""
                && objvFieldTab4CodeConv.CodeTabCode != ""
                && objvFieldTab4CodeConv.CodeTabName != "")
            {
                objEditRegionFldsEN.CtlTypeId = "06";
                objEditRegionFldsEN.DdlItemsOptionId = "02";
        
                string strDsTabId = clsPrjTabBL.GetFirstID_S("PrjId = '" + objPrjTabFldEN.PrjId + "' and TabName = '" 
                    + objvFieldTab4CodeConv.CodeTab + "'");
                if (strDsTabId != "")
                {
                    objEditRegionFldsEN.DsTabId = strDsTabId;

                    objEditRegionFldsEN.TabFeatureId4Ddl = clsTabFeatureBLEx.GetFstFeatureIdByTabId(objEditRegionFldsEN.DsTabId, objPrjTabFldEN.PrjId);

                }
            }
            else
            {
                objEditRegionFldsEN.DdlItemsOptionId = "00";
                objEditRegionFldsEN.DsTabId = "";
                objEditRegionFldsEN.TabFeatureId4Ddl = "";
            }
            if (clsPrjTabBL.GetObjByTabIdCache(objPrjTabFldEN.TabId, objPrjTabFldEN.PrjId).SqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
            {
                objEditRegionFldsEN.InOutTypeId = clsInOutTypeBLEx.OUT_Type;
            }
            else
            {
                objEditRegionFldsEN.InOutTypeId = clsInOutTypeBLEx.OUTIN_Type;
            }
            //if (clsViewRegionBL.GetObjByRegionId(lngRegionId).RegionTypeId == clsRegionTypeBLEx.DETAILREGION)
            //{
            //    objEditRegionFldsEN.InOutTypeId = clsInOutTypeBLEx.OUT_Type;
            //    objEditRegionFldsEN.CtlTypeId = clsCtlTypeBLEx.LABELTYPE;

            //}
            objEditRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
            objEditRegionFldsEN.UpdUser = strUserId;
     
            //5、检查传进去的对象属性是否合法
            if (objPrjTabFldEN.FldName.StartsWith("_"))
            {
                objEditRegionFldsEN.InUse = false;
            }
            else
            {
                if (objPrjTabFldEN.FieldTypeId == enumFieldType.Log_UpdDate_13 || objPrjTabFldEN.FieldTypeId == enumFieldType.Log_UpdUser_14)
                {
                    objEditRegionFldsEN.InUse = false;
                }
                else
                {
                    objEditRegionFldsEN.InUse = true;
                }
            }
     //       clsEditRegionFldsBL.CheckPropertyNew(objEditRegionFldsEN);

            //6、把数据实体层的数据存贮到数据库中
            //long lngTabFldId = objEditRegionFldsEN.TabFldId;
                       

            return objEditRegionFldsEN;

        }

        public static IEnumerable<ASPControlEx> GetControlLst4Regoin(string lngRegionId, bool bolIsFstLcase, string strPrjId, string strCmPrjId,string strViewId, string strItemName4MultiModel = "")
        {
            clsvViewRegionEN objViewRegion = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //clsViewInfoENEx objViewInfoENEx = clsViewInfoBLEx.GetObjExByViewId(objViewRegion.ViewId, objViewRegion.PrjId);


            List<clsEditRegionFldsENEx> arrEditRegionFlds = clsEditRegionFldsBLEx.GetObjExLstByRegionId4InUse2(lngRegionId, bolIsFstLcase, strPrjId,strViewId);
         
            Func<clsViewFeatureFldsENEx, ASPControlEx> GetControl_Asp4MultiModel = obj => clsASPControlBLEx.GetControl_Asp(obj, strItemName4MultiModel);

            IEnumerable<ASPControlEx> arrControls = arrEditRegionFlds.Select(x=>clsASPControlBLEx.GetControl_Asp(x, strCmPrjId));
            return arrControls;
                       
        }

        /// <summary>
        /// 同步满足条件的DG信息到Server
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //public static int SynchToServerByCondition(string strCondition, string strUserId)
        //{
        //    //string strCondition = string.Format("id_CurrEduClass='{0}'", strId_TransferCourses);
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

        //    clsSysParaEN.strConnectStrName = "ConnectionStringWeb";

        //    List<clsEditRegionFldsEN> arrEditRegionFldsENObjLst = clsEditRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsEditRegionFldsEN objEditRegionFldsEN4Web in arrEditRegionFldsENObjLst)
        //    {

        //        objEditRegionFldsEN4Web.IsSynchToServer = true;
        //        objEditRegionFldsEN4Web.SynchToServerDate = strCurrDate14;
        //        objEditRegionFldsEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsEditRegionFldsEN objEditRegionFldsEN4Web2 = new clsEditRegionFldsEN();
        //            clsEditRegionFldsBL.CopyTo(objEditRegionFldsEN4Web, objEditRegionFldsEN4Web2);
        //            objEditRegionFldsEN4Web2.SynSource = "Client";
        //            strCondition = objEditRegionFldsEN4Web.GetUniquenessConditionString();
        //            clsEditRegionFldsEN objEditRegionFlds_Target = clsEditRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objEditRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objEditRegionFlds_Target.UpdDate.CompareTo(objEditRegionFldsEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    objEditRegionFldsEN4Web2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsEditRegionFldsBL.AddNewRecordBySql2(objEditRegionFldsEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objEditRegionFldsEN4Web.RegionId,
        //                        objEditRegionFldsEN4Web.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        /// <summary>
        /// 同步满足条件的信息到Client
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //public static int SynchToClientByCondition(string strCondition, string strUserId)
        //{
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    List<clsEditRegionFldsEN> arrEditRegionFldsENObjLst = clsEditRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsEditRegionFldsEN objEditRegionFldsEN4Main in arrEditRegionFldsENObjLst)
        //    {

        //        objEditRegionFldsEN4Main.IsSynchToClient = true;
        //        objEditRegionFldsEN4Main.SynchToClientDate = strCurrDate14;
        //        objEditRegionFldsEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        try
        //        {
        //            clsEditRegionFldsEN objEditRegionFldsEN4Main2 = new clsEditRegionFldsEN();
        //            clsEditRegionFldsBL.CopyTo(objEditRegionFldsEN4Main, objEditRegionFldsEN4Main2);
        //            objEditRegionFldsEN4Main2.SynSource = "Server";
        //            strCondition = objEditRegionFldsEN4Main.GetUniquenessConditionString();
        //            clsEditRegionFldsEN objEditRegionFlds_Target = clsEditRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objEditRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objEditRegionFlds_Target.UpdDate.CompareTo(objEditRegionFldsEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {
        //                    objEditRegionFldsEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsEditRegionFldsBL.AddNewRecordBySql2(objEditRegionFldsEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objEditRegionFldsEN4Main.RegionId,
        //                        objEditRegionFldsEN4Main.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}

        /// <summary>
        /// 根据区域Id获取相关
        /// </summary>
        /// <param name="lngRegionId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsEditRegionFldsENEx> GetObjExLstByRegionIdCacheEx2(string lngRegionId, string strPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} order by SeqNum", lngRegionId);
            List<clsEditRegionFldsENEx> arrObjENExList = new List<clsEditRegionFldsENEx>();
            List<clsEditRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx2(lngRegionId, strPrjId);
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrObjList)
            {
                clsEditRegionFldsENEx objEditRegionFldsENEx = new clsEditRegionFldsENEx();
                CopyTo(objEditRegionFldsEN, objEditRegionFldsENEx);
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objEditRegionFldsENEx.PrjId());

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                arrObjENExList.Add(objEditRegionFldsENEx);
            }
            return arrObjENExList;
        }
        public static bool ImportRelaFlds(string lngRegionId, string strPrjId, string strUserId)
        {
            //string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            int intRecNum = 0;
            //clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();


            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            //2、获取相关主表ID的字段的对象列表;
            IEnumerable<clsvPrjTabFldEN> arrRelaTabFldObjList =
                clsvPrjTabFldBL.GetObjLst("TabId = '" + strRelaTabId + "' order by SequenceNumber");
            arrRelaTabFldObjList = arrRelaTabFldObjList.Where(x=>x.IsForExtendClass == false);
            List<string> arrNoNeedFieldTypeId = new List<string>() {
                enumFieldType.ManageField_04,
                enumFieldType.BeingNot_18,
                enumFieldType.SynField_08,
                enumFieldType.CalcField_11
            };


            arrRelaTabFldObjList = arrRelaTabFldObjList.Where(x => arrNoNeedFieldTypeId.Contains(x.FieldTypeId) == false);
            clsEditRegionFldsBLEx.intKeyNum = arrRelaTabFldObjList.Count(x => x.FieldTypeId == enumFieldType.KeyField_02);

            IEnumerable<clsEditRegionFldsEN> arrEditRegionFlds = arrRelaTabFldObjList
                .Where(x => x.PrimaryTypeId != enumPrimaryType.Identity_02)
                .Select(clsEditRegionFldsBLEx.GetObjByvPrjTabFld);
            intRecNum = clsGeneralTab2.funGetRecCountByCond(clsEditRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);

            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrEditRegionFlds)
            {

                objEditRegionFldsEN.SetUpdDate(clsDateTime.getTodayStr(0))
                    .SetUpdUser(strUserId)
                    .SetPrjId(strPrjId)
                    .SetRegionId(lngRegionId);



                //5、检查传进去的对象属性是否合法

                clsEditRegionFldsBL.CheckPropertyNew(objEditRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中
                //long lngTabFldId = objEditRegionFldsEN.TabFldId;
                if (string.IsNullOrEmpty(objEditRegionFldsEN.TabFeatureId4Ddl) == true) objEditRegionFldsEN.TabFeatureId4Ddl = null;

                string strCondition = string.Format("{0}={1} and {2}='{3}'",
                    conEditRegionFlds.RegionId, lngRegionId,
                    conEditRegionFlds.FldId, objEditRegionFldsEN.FldId);
                if (clsEditRegionFldsBL.IsExistRecord(strCondition) == false)
                {
                    objEditRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsEditRegionFldsBL.AddNewRecordBySql2(objEditRegionFldsEN) == false)
                    {
                        var objEditRegionFldsENEx = CopyToEx(objEditRegionFldsEN);
                        throw new clsDbObjException("添加编辑区域字段不成功!" + clsFieldTabBL.GetFldNameByFldIdCache(objEditRegionFldsEN.FldId, objEditRegionFldsENEx.PrjId()));
                    }

                }

            }
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate4RegionId(lngRegionId);

            return true;

        }
        public static bool ImportRelaFlds_Detail(string lngRegionId, string strPrjId, string strUserId)
        {
            //string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            int intRecNum = 0;
            clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();

            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            //2、获取相关主表ID的字段的对象列表;
            IEnumerable<clsvPrjTabFldEN> arrRelaTabFldObjList =
                clsvPrjTabFldBL.GetObjLst("TabId = '" + strRelaTabId + "' order by SequenceNumber");

            List<string> arrNoNeedFieldTypeId = new List<string>() {
                enumFieldType.ManageField_04,
                enumFieldType.BeingNot_18,
                enumFieldType.SynField_08
            };

            arrRelaTabFldObjList = arrRelaTabFldObjList.Where(x => arrNoNeedFieldTypeId.Contains(x.FieldTypeId) == false);
            int intKeyNum = arrRelaTabFldObjList.Count(x => x.FieldTypeId == enumFieldType.KeyField_02);
            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrRelaTabFldObjList)
            {
                if (objPrjTabFldEN.PrimaryTypeId == "02" && objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                objEditRegionFldsEN.FldId = objPrjTabFldEN.FldId;
                objEditRegionFldsEN.RegionId = lngRegionId;
                switch (objPrjTabFldEN.DataTypeName)
                {
                    case "bit":
                        objEditRegionFldsEN.CtlTypeId = "02";
                        break;
                    default:
                        objEditRegionFldsEN.CtlTypeId = "16";
                        break;
                }
                var objvFieldTab4CodeConv = objPrjTabFldEN.ObjvFieldTab4CodeConv();
                //判断该字段是否为相关表中的关键字
                if ((intKeyNum > 1 || objPrjTabFldEN.FieldTypeId != enumFieldType.KeyField_02)
                    && objvFieldTab4CodeConv != null
                    && objvFieldTab4CodeConv.CodeTab != ""
                    && objvFieldTab4CodeConv.CodeTabCode != ""
                    && objvFieldTab4CodeConv.CodeTabName != "")
                {
                    objEditRegionFldsEN.CtlTypeId = "06";
                    objEditRegionFldsEN.DdlItemsOptionId = "02";
                    string strDsTabId = clsPrjTabBL.GetFirstID_S("PrjId = '" + strPrjId + "' and TabName = '" 
                        + objvFieldTab4CodeConv.CodeTab + "'");
                    if (strDsTabId != "")
                    {
                        objEditRegionFldsEN.DsTabId = strDsTabId;
                        objEditRegionFldsEN.TabFeatureId4Ddl = clsTabFeatureBLEx.GetFstFeatureIdByTabId(objEditRegionFldsEN.DsTabId, strPrjId);

                    }
                }
                else
                {
                    objEditRegionFldsEN.DdlItemsOptionId = "00";
                    objEditRegionFldsEN.DsTabId = "";
                    objEditRegionFldsEN.TabFeatureId4Ddl= "";

                }
                objEditRegionFldsEN.InOutTypeId = clsInOutTypeBLEx.OUT_Type;		//输出类型
                objEditRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
                objEditRegionFldsEN.UpdUser = strUserId;
                objEditRegionFldsEN.PrjId = strPrjId;

                //5、检查传进去的对象属性是否合法

                clsEditRegionFldsBL.CheckPropertyNew(objEditRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中
                string strFldId = objEditRegionFldsEN.FldId;
                string strFldName = clsFieldTabBL.GetObjByFldId(strFldId).FldName;
                intRecNum = clsGeneralTab2.funGetRecCountByCond(clsEditRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);
                if (clsvEditRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == false)
                {
                    objEditRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsEditRegionFldsBL.AddNewRecordBySql2(objEditRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加编辑区域字段不成功!" + clsFieldTabBL.GetNameByFldIdCache(objEditRegionFldsEN.FldId, strPrjId));
                    }
                    else
                    {
                    }
                }

            }
            return true;

        }


        public static bool ImportRelaFlds(string lngRegionId, List<clsvPrjTabFldEN> arrRelaTabFldObjList, string strPrjId, string strUserId)
        {
            //string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            int intRecNum = 0;
            //clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();

            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            clsPrjTabEN objRelaPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, strPrjId);

            IEnumerable<clsEditRegionFldsEN> arrEditRegionFldsObjLst = arrRelaTabFldObjList.Where(x => x.PrimaryTypeId != enumPrimaryType.Identity_02).Select(clsEditRegionFldsBLEx.GetObjByvPrjTabFld);

            //2、获取相关主表ID的字段的对象列表;
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrEditRegionFldsObjLst)
            {
                objEditRegionFldsEN.RegionId = lngRegionId;

                objEditRegionFldsEN.UpdUser = strUserId;
                objEditRegionFldsEN.PrjId = strPrjId;

                //5、检查传进去的对象属性是否合法

                clsEditRegionFldsBL.CheckPropertyNew(objEditRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中
                
                string strFldName = clsFieldTabBL.GetObjByFldId(objEditRegionFldsEN.FldId).FldName;
                if (clsvEditRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == false)
                {
                    objEditRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsEditRegionFldsBL.AddNewRecordBySql2(objEditRegionFldsEN) == false)
                    {
                        var objEditRegionFldsENEx = CopyToEx(objEditRegionFldsEN);
                        throw new clsDbObjException("添加编辑区域字段不成功!" + clsFieldTabBL.GetNameByFldIdCache(objEditRegionFldsEN.FldId, objEditRegionFldsENEx.PrjId()));
                    }
                    else
                    {
                    }
                }

            }
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate(lngRegionId);

            return true;

        }
        public static bool CopyTo1(string lngRegionId_S, string lngRegionId_T, string strCmPrjId, string strUpdUser)
        {
            List<clsEditRegionFldsEN> arrEditRegionFldsObjLst = clsEditRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(lngRegionId_S, strCmPrjId);
            foreach (clsEditRegionFldsEN objInfor2 in arrEditRegionFldsObjLst)
            {
                clsEditRegionFldsEN objInfor2_T = new clsEditRegionFldsEN();
                clsEditRegionFldsBL.CopyTo(objInfor2, objInfor2_T);
                objInfor2_T.RegionId = lngRegionId_T;
                objInfor2_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
.SetUpdUser(strUpdUser);
                objInfor2_T.EditRecordEx();
            }
            return true;
        }

        public static List<clsGCVariableEN> GetGcVarLst4DefaValue2(string lngRegionId, string strPrjId)
        {
            List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
            var arrEditRegionFlds = GetObjLstByRegionIdCache4InUseEx2(lngRegionId, strPrjId)
                .Where(x => arrCtlType.Contains(x.CtlTypeId));
            var arrEditRegionFldsEx = arrEditRegionFlds.Select(CopyToEx);
             var arrGCVariable = new List<clsGCVariableEN>();

            foreach (var objInFor in arrEditRegionFldsEx)
            {
                var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                if (objVar != null)
                {
                    objVar.DataTypeId = objInFor.ObjFieldTab().DataTypeId;
                    objVar.Memo = "编辑区缺省值";
                    arrGCVariable.Add(objVar);
                }
            }

            return arrGCVariable;
        }

        public static List<clsGCVariableEN> GetGcVarLst4DdlCond2(string lngRegionId, string strPrjId)
        {
            List<string> arrCtlType = new List<string>() { enumCtlType.DropDownList_06 };
            var arrEditRegionFlds = GetObjLstByRegionIdCache4InUseEx2(lngRegionId, strPrjId)
                .Where(x => arrCtlType.Contains(x.CtlTypeId));
            var arrEditRegionFldsEx = arrEditRegionFlds.Select(CopyToEx);
            var arrGCVariable = new List<clsGCVariableEN>();

            foreach (var objInFor in arrEditRegionFldsEx)
            {
                {
                    var objVar_Cond1 = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarIdCond1);
                    if (objVar_Cond1 != null)
                    {
                        var objField = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldIdCond1, objInFor.PrjId());
                        objVar_Cond1.DataTypeId = objField.DataTypeId;
                        objVar_Cond1.Memo = "编辑区下拉框条件变量1";
                        arrGCVariable.Add(objVar_Cond1);
                    }
                }
                {
                    var objVar_Cond2 = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarIdCond2);
                    if (objVar_Cond2 != null)
                    {
                        var objField = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldIdCond2, objInFor.PrjId());
                        objVar_Cond2.DataTypeId = objField.DataTypeId;
                        objVar_Cond2.Memo = "编辑区下拉框条件变量2";
                        arrGCVariable.Add(objVar_Cond2);
                    }
                }
            }

            return arrGCVariable;
        }

        public static int GetRecCount4InUseCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsEditRegionFldsEN> arrObjLstCache = clsEditRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrEditRegionFldsObjLst_Sel.Count;
        }


        public static int GetRecCountCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsEditRegionFldsEN> arrObjLstCache = clsEditRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrEditRegionFldsObjLst_Sel.Count;
        }

        public static bool SetCmPrjId1(string strRegionId, string strPrjId, string strUserId)
        {
            try
            {
                List<clsEditRegionFldsEN> arrEditRegionFlds = clsEditRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);

                foreach (var objInFor in arrEditRegionFlds)
                {
                    try
                    {
                        objInFor
                            .SetPrjId(strPrjId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                            .SetUpdUser(strUserId)
                            .Update();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                return true;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }


        public static clsEditRegionFldsENEx GetObjEx(clsEditRegionFldsEN objEditRegionFlds)
        {
            clsEditRegionFldsENEx objEditRegionFldsENEx = new clsEditRegionFldsENEx();
            CopyTo(objEditRegionFlds, objEditRegionFldsENEx);
            return objEditRegionFldsENEx;
        }

        public static clsErrMsgENEx CheckRegionFlds(string strRegionId, string strCmPrjId, string strUserId, string strViewId )
        {
            string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            //1、获取当前区域ID的相关主表ID；
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            string strMsg = "";
            int intErrCount = 0;
            var arrEditRegionFlds = clsEditRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
            var arrEditRegionFldsEx = arrEditRegionFlds.Select(clsEditRegionFldsBLEx.GetObjEx).ToList();
            //StringBuilder sbErrMsg = new StringBuilder();
            //try
            //{

            foreach (var objInFor in arrEditRegionFldsEx)
            {
                if (objInFor.InUse == false) continue;
                try
                {
                    if (string.IsNullOrEmpty(objInFor.FldId) == true)
                    {
                        strMsg = $"控件:[{objInFor.LabelCaption}]的字段Id(FldId)为空！({clsStackTrace.GetCurrClassFunctionByLevel(2)})" ;
                        throw new Exception(strMsg);
                    }
                    if (objInFor.IsTabField() == false)
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldId, objInFor.PrjId);
                        strMsg = $"控件:[{objInFor.LabelCaption}]的字段:[{objFieldTab.FldName}({objInFor.FldId})]，不在查询区的相关表中，请检查！({clsStackTrace.GetCurrClassFunctionByLevel(2)})" ;
                        throw new Exception(strMsg);
                    }
                    switch (objInFor.CtlTypeId)
                    {
                        case enumCtlType.DropDownList_06:
                            clsPubFun4BLEx.CheckComboBox(objInFor, strViewId, strCmPrjId);
                            break;
                        case enumCtlType.DropDownList_Bool_18:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.TextBox_16:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.CheckBox_02:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.GivenValue_35:
                            break;
                        case enumCtlType.DefaultValue_36:
                            if (string.IsNullOrEmpty( objInFor.DefaultValue) == true)
                            {
                                strMsg = string.Format("控件:[{0}]中，缺省值不能为空.({1})",
               objInFor.LabelCaption,
             clsStackTrace.GetCurrClassFunctionByLevel(2));
                                throw new Exception(strMsg);
                            }
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;

                        case enumCtlType.ViewVariable_38:
                        

                            clsPubFun4BLEx.CheckSessionStorageVar(objInFor);
                            break;
                        case enumCtlType.TextArea_41:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;

                        default:
                            var objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objInFor.CtlTypeId);
                            strMsg = string.Format("控件类型:[{0}]({1})没有被处理！(in {2})",
                                      objCtlType.CtlTypeName, objCtlType.CtlTypeId,
                                      clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                }
                catch (Exception ex)
                {
                    objInFor.ErrMsg = ex.Message;

                    objInFor.Update();
                    intErrCount++;
                    continue;
                }
                if (objInFor.ErrMsg != null && objInFor.ErrMsg.Length>0)
                {
                    objInFor.ErrMsg = "";
                    objInFor.Update();
                    continue;
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    sbErrMsg.AppendLine(ex.Message);
            //}
            //2、获取相关主表ID的字段的对象列表;
            var objErrMsg = new clsErrMsgENEx(conErrType.EditRegion, intErrCount);
            var objViewRegion = clsViewRegionBL.GetObjByRegionId(strRegionId);
            if (objViewRegion != null)
            {
                if (intErrCount > 0)
                {
                    objViewRegion.ErrMsg = objErrMsg.ToString();
                    objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewRegion.Update();
                }
                else
                {
                    objViewRegion.ErrMsg = "";
                    objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewRegion.Update();
                }
            }
            return objErrMsg;

        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objEditRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsEditRegionFldsEN:objEditRegionFldsENT</returns>
        public static clsEditRegionFldsENEx CopyToEx(clsEditRegionFldsEN objEditRegionFldsENS)
        {
            try
            {
                clsEditRegionFldsENEx objEditRegionFldsENT = new clsEditRegionFldsENEx();
                clsEditRegionFldsBL.EditRegionFldsDA.CopyTo(objEditRegionFldsENS, objEditRegionFldsENT);
                return objEditRegionFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}
