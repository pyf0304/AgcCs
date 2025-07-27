
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using com.taishsoft.commdb;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{

    public class RelatedActions_DetailRegionFldsEx : RelatedActions_DetailRegionFlds
    {

        public override bool UpdRelaTabDate(long lngmId, string strOpUser)
        {
            var objDetailRegionFlds = clsDetailRegionFldsBL.GetObjBymId(lngmId);
            if (objDetailRegionFlds == null) return false;
            var objViewRegion = clsViewRegionBL.GetObjByRegionId(objDetailRegionFlds.RegionId);
            if (objViewRegion == null) return false;
            clsViewRegionBL.SetUpdDate(objDetailRegionFlds.RegionId, strOpUser);
            var arrViewId = clsViewRegionRelaBL.GetFldValueNoDistinct(conViewRegionRela.ViewId, string.Format("{0}='{1}'", conViewRegionRela.RegionId,
                objDetailRegionFlds.RegionId));
            foreach (var strViewId in arrViewId)
            {
                clsViewInfoBL.SetUpdDate(strViewId, strOpUser);
            }
            return true;
        }
       
    }

    public static class clsDetailRegionFldsBLEx_Static
    {
        //public static string TabId(this clsDetailRegionFldsEN objDetailRegionFldsEN)
        //{
        //    try
        //    {
        //        clsViewRegionEN objViewRegion = clsViewRegionBLEx.GetObjByRegionIdCache(objDetailRegionFldsEN.RegionId, objDetailRegionFldsEN.CmPrjId);
        //        if (objViewRegion == null) return null;
        //        return objViewRegion.TabId;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}
        //public static string DnPathId(this clsDetailRegionFldsEN objDetailRegionFldsEN)
        //{
        //    try
        //    {
        //        string strTabId = objDetailRegionFldsEN.TabId();
        //        if (strTabId == null) return null;
        //        string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(objDetailRegionFldsEN.CmPrjId);
        //        var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objDetailRegionFldsEN.OutFldId, strPrjId);
        //        if (objPrjTabFld == null) return null;
        //        return objPrjTabFld.DnPathId;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}

        //public static bool IsUseFunc(this clsDetailRegionFldsEN objDetailRegionFldsEN)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(objDetailRegionFldsEN.OutFldId)) return false;
        //        else return true;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}
        //public static string DataPropertyName(this clsDetailRegionFldsEN objDetailRegionFldsEN)
        //{
        //    try
        //    {
        //        string strTabId = objDetailRegionFldsEN.TabId();
        //        if (strTabId == null) return null;
        //        string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(objDetailRegionFldsEN.CmPrjId);
        //        var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objDetailRegionFldsEN.OutFldId, strPrjId);
        //        if (objPrjTabFld == null) return null;
        //        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, strPrjId);
        //        if (objFieldTab == null) return null;
        //        return objFieldTab.FldName;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}
        //public static clsFieldTabEN ObjFieldTab0(this clsDetailRegionFldsEN objDetailRegionFlds)
        //{
        //    string strPrjId_p = clsCMProjectBL.GetObjByCmPrjIdCache(objDetailRegionFlds.PrjId).PrjId;
        //    clsFieldTabEN objPrjTabFld = clsFieldTabBL.GetObjByFldIdCache(objDetailRegionFlds.FldId, strPrjId_p);
        //    return objPrjTabFld;
        //}




        //public static clsViewRegionEN ObjViewRegion(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strCmPrjId)
        //{
        //    try
        //    {
        //        clsViewRegionEN objViewRegion = clsViewRegionBLEx.GetObjByRegionIdCache(objDetailRegionFldsEN.RegionId, strCmPrjId);
        //        return objViewRegion;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}

        /// <summary>
        /// 是否是表字段
        /// </summary>
        /// <param name="objEditRegionFldsEx"></param>
        /// <returns></returns>
        public static bool IsTabField(this clsDetailRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.FldId, objEditRegionFldsEx.PrjId());
            if (objPrjTabFld == null) return false;
            return true;
        }

        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objDetailRegionFldsEN"></param>
        /// <returns></returns>
        public static string PropertyName(this clsDetailRegionFldsENEx objDetailRegionFldsEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objDetailRegionFldsEN.FldName;
            }
            else
            {
                return clsString.FstLcaseS(objDetailRegionFldsEN.FldName);
            }
        }



        /// <summary>
        /// 控件输入是否正确
        /// </summary>
        /// <param name="objDetailRegionFldsEx"></param>
        /// <returns></returns>
        public static string GC_IsValid_CtrlInput(this clsDetailRegionFldsENEx objDetailRegionFldsEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                     && objDetailRegionFldsEx.ObjFieldTabENEx.DataTypeId == enumDataTypeAbbr.bigint_01)
            {
                return "";
            }
            if (objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "int" ||
                objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "long" ||
                objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "short" ||
                objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "DateTime" ||
                objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "double" ||
                objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "single")
            {
                strCodeForCs.AppendFormat("\r\n" + "ComValid_{0}.Validate();",
                    objDetailRegionFldsEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "if (!ComValid_{0}.IsValid) return false;",
                    objDetailRegionFldsEx.FldName);
            }

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 输入的数据类型是否正确
        /// </summary>
        /// <param name="objDetailRegionFldsEx"></param>
        /// <returns></returns>
        public static string GC_IsValidDataType(this clsDetailRegionFldsENEx objDetailRegionFldsEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                      && objDetailRegionFldsEx.ObjFieldTabENEx.DataTypeId == enumDataTypeAbbr.bigint_01)
            {
                return "";
            }
            switch (objDetailRegionFldsEx.ObjFieldTabENEx.CsType())
            {
                case "int":
                case "long":
                case "short":
                    strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text)  ==  false)",
                        objDetailRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的整型!\";");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                case "double":
                case "float":
                case "single":
                    strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text)  ==  false)",
                        objDetailRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的浮点型!\";");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                case "DateTime":
                    strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text)  ==  false)",
                        objDetailRegionFldsEx.CtrlId);
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


        public static string GC_DefFldProperty(this clsDetailRegionFldsENEx objDetailRegionFldsEx, string strCmPrjId)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;

            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}",
                objDetailRegionFldsEx.LabelCaption);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                objDetailRegionFldsEx.ObjFieldTabENEx.CsType(),
                objDetailRegionFldsEx.FldName);
            strCodeForCs.Append("\r\n" + "{");
            switch (objDetailRegionFldsEx.objCtlType.CtlTypeName)
            {
                case "Button":
                    break;
                case "CheckBox":
                    strCodeForCs.Append("\r\n" + "get");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                        objDetailRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "set");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                        objDetailRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                case "CheckBoxList":
                    break;
                case "DataGrid":
                    break;
                case "DataList":
                    break;

                case "DropDownList":    //如果控件是下拉框;
                    if (objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                    {
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex  ==  1)",
                            objDetailRegionFldsEx.CtrlId);
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
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "int"
                        || objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "bigint"
                        || objDetailRegionFldsEx.ObjFieldTabENEx.CsType() == "short"
                       )
                    {
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue  ==  \"0\")",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.AppendFormat("\r\n" + "return 0;");
                        strCodeForCs.AppendFormat("\r\n" + "return {1}.Parse({0}.SelectedValue);",
                            objDetailRegionFldsEx.CtrlId, objDetailRegionFldsEx.ObjFieldTabENEx.CsType());
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "set");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "if (value  ==  0)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value.ToString();",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue  ==  \"0\")",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                        strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue;",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "set");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "if (value  ==  \"\")");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                            objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                            objDetailRegionFldsEx.CtrlId);
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
                    switch (objDetailRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;

                        case "short":
                            strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;

                        case "double":

                            strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "DateTime":

                            strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "bool":
                            strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objDetailRegionFldsEx.CtrlId);
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "set");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objDetailRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "}");
                    break;
                default:

                    strCodeForCs.Append("\r\n" + "get");
                    strCodeForCs.Append("\r\n" + "{");
                    switch (objDetailRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;

                        case "short":
                            strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;

                        case "double":
                            strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "bool":
                            strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objDetailRegionFldsEx.CtrlId);
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objDetailRegionFldsEx.CtrlId);
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "set");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objDetailRegionFldsEx.CtrlId);
                    strCodeForCs.Append("\r\n" + "}");
                    break;
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public static string GC_SetDefaultValue(this clsDetailRegionFldsENEx objDetailRegionFldsEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            //如果该字段不为标识递增型就生成该字段控件,否则就不生成;
            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                      && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            switch (objDetailRegionFldsEx.objCtlType.CtlTypeName)
            {
                case "Button":
                    break;
                case "CheckBox":
                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objDetailRegionFldsEx.CtrlId);
                    break;
                case "CheckBoxList":
                    break;
                case "DataGrid":
                    break;
                case "DataList":
                    break;
                case "DropDownList":    //如果控件是下拉框;
                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                        objDetailRegionFldsEx.CtrlId);
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
                    switch (objDetailRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "double":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        case "bool":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"false\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                    }
                    break;
                default:
                    switch (objDetailRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";", objDetailRegionFldsEx.CtrlId);
                            break;
                        case "double":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        case "bool":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"false\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0.0\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"0\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"\";",
                                objDetailRegionFldsEx.CtrlId);
                            break;

                    }
                    break;

            }

            return strCodeForCs.ToString();
        }




        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDetailRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsDetailRegionFldsEN:objDetailRegionFldsENT</returns>
        public static clsDetailRegionFldsENEx CopyToEx(this clsDetailRegionFldsEN objDetailRegionFldsENS)
        {
            try
            {
                clsDetailRegionFldsENEx objDetailRegionFldsENT = new clsDetailRegionFldsENEx();
                clsDetailRegionFldsBL.DetailRegionFldsDA.CopyTo(objDetailRegionFldsENS, objDetailRegionFldsENT);
                return objDetailRegionFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objDetailRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsDetailRegionFldsEN:objDetailRegionFldsENT</returns>
        public static clsDetailRegionFldsEN CopyTo(this clsDetailRegionFldsENEx objDetailRegionFldsENS)
        {
            try
            {
                clsDetailRegionFldsEN objDetailRegionFldsENT = new clsDetailRegionFldsEN();
                clsDetailRegionFldsBL.CopyTo(objDetailRegionFldsENS, objDetailRegionFldsENT);
                return objDetailRegionFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 详细区域字段(DetailRegionFlds)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsDetailRegionFldsBLEx : clsDetailRegionFldsBL
    {
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsDetailRegionFldsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsDetailRegionFldsDAEx DetailRegionFldsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsDetailRegionFldsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objDetailRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsDetailRegionFldsEN:objDetailRegionFldsENT</returns>
        public static clsDetailRegionFldsENEx CopyToEx(clsDetailRegionFldsEN objDetailRegionFldsENS)
        {
            try
            {
                clsDetailRegionFldsENEx objDetailRegionFldsENT = new clsDetailRegionFldsENEx();
                clsDetailRegionFldsBL.DetailRegionFldsDA.CopyTo(objDetailRegionFldsENS, objDetailRegionFldsENT);
                return objDetailRegionFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsDetailRegionFldsENEx> GetObjExLst(string strCondition)
        {
            List<clsDetailRegionFldsEN> arrObjLst = clsDetailRegionFldsBL.GetObjLst(strCondition);
            List<clsDetailRegionFldsENEx> arrObjExLst = new List<clsDetailRegionFldsENEx>();
            foreach (clsDetailRegionFldsEN objInFor in arrObjLst)
            {
                clsDetailRegionFldsENEx objDetailRegionFldsENEx = new clsDetailRegionFldsENEx();
                clsDetailRegionFldsBL.CopyTo(objInFor, objDetailRegionFldsENEx);
                arrObjExLst.Add(objDetailRegionFldsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsDetailRegionFldsENEx GetObjExBymId(long lngmId)
        {
            clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(lngmId);
            clsDetailRegionFldsENEx objDetailRegionFldsENEx = new clsDetailRegionFldsENEx();
            clsDetailRegionFldsBL.CopyTo(objDetailRegionFldsEN, objDetailRegionFldsENEx);
            return objDetailRegionFldsENEx;
        }


        public static IEnumerable<ASPControlGroupEx> GetControlGroupV3(string lngRegionId, string strCmPrjId, string strPrjId, string strItemName4MultiModel, DataRow objDR = null)
        {
            clsvViewRegionEN objViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(lngRegionId, strCmPrjId);

            //Func<clsDetailRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4MultiModel = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, strItemName4MultiModel);
            List<clsDetailRegionFldsENEx> arrDetailRegionFlds = clsDetailRegionFldsBLEx.GetObjExLstByRegionIdCacheEx1(lngRegionId, strCmPrjId);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst = arrDetailRegionFlds.Select(x => clsASPControlGroupBLEx.GetControlGroup_Asp(x, strCmPrjId, objDR, strItemName4MultiModel));
            //把查询按钮加进来
            //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
            //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
            //arrButtonObjLst.Add(objASPControlGroup);

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = clsFeatureRegionFldsBLEx.GetObjExLstByRegionIdEx(lngRegionId, strPrjId);//  objViewInfoENEx.arrFeatureRegionFlds;
            if (arrFeatureRegionFldsObjLst == null)
            {

                string strMsg = string.Format("界面功能区为空，请添加界面功能！当前输出表:{0}. (In {1})", objViewRegion.TabName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            bool bolIsHasExport = true;
            //if (objViewInfoENEx.objViewRegion_ExportExcel == null) bolIsHasExport = false;
            Func<clsFeatureRegionFldsENEx, ASPControlGroupEx> GetButtonGroupV2 = obj => clsFeatureRegionFldsBLEx.GetButtonGroup(obj, objViewRegion.ApplicationTypeId ?? 0, bolIsHasExport);

            IEnumerable<ASPControlGroupEx> arrButtonGroupLst = arrFeatureRegionFldsObjLst
                    .Where(x => x.RegionId == lngRegionId)
                    .Select(GetButtonGroupV2);

            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);

            arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonGroupLst);
            return arrASPControlGroupObjLst;

        }


        public static void initDetailRegionFldSet(clsViewInfoENEx objViewInfoENEx)
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
                clsRegionTypeENEx.DETAILREGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty(lngRegionId) == true)
            {
                return;
            }
            //objViewInfoENEx.objDetailRegionENEx = new clsDetailRegionENEx(lngRegionId);
            //clsDetailRegionBLEx.GetDetailRegionEx(ref objViewInfoENEx.objDetailRegionENEx, objViewInfoENEx.PrjId);
            //objViewInfoENEx.objDetailRegionENEx.InitViewRegion();

            objViewInfoENEx.arrDetailRegionFldSet4InUse = clsDetailRegionFldsBLEx.GetObjExLstByRegionId4InUse1(lngRegionId, objViewInfoENEx.PrjId);
            objViewInfoENEx.arrDetailRegionFldSet = clsDetailRegionFldsBLEx.GetObjExLstByRegionId1(lngRegionId, objViewInfoENEx.PrjId);
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
            //if (objViewInfoENEx.arrDetailRegionFldSet4InUse  ==  null || objViewInfoENEx.arrDetailRegionFldSet4InUse.Count  ==  0)
            //{
            //    intViewFldNum = 0;
            //    return;
            //}
            //objViewInfoENEx.objDetailRegionENEx.FieldNum = objViewInfoENEx.arrDetailRegionFldSet4InUse.Count;
            foreach (clsDetailRegionFldsENEx objDetailRegionFldsENEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
            {
                objDetailRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDetailRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                objDetailRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objDetailRegionFldsENEx.CtlTypeId);
            }
            foreach (clsDetailRegionFldsENEx objDetailRegionFldsENEx in objViewInfoENEx.arrDetailRegionFldSet)
            {
                objDetailRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDetailRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                objDetailRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objDetailRegionFldsENEx.CtlTypeId);
            }
        }

        public static void initDetailRegionFldSetBak20200526(clsViewInfoENEx objViewInfoENEx)
        {
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //  然后存到集合中
            //3、

            objViewInfoENEx.TabKeyFldNum = 0;
            //objViewInfoENEx.TabName = objViewInfoENEx.objMainPrjTab.TabName;            

            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(objViewInfoENEx.ViewId, clsRegionTypeENEx.DETAILREGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty(lngRegionId) == true)
            {
                return;
            }

            //objViewInfoENEx.objDetailRegionENEx.InitViewRegion();

            objViewInfoENEx.arrDetailRegionFldSet = clsDetailRegionFldsBLEx.GetObjExLstByRegionId4InUse1(lngRegionId, objViewInfoENEx.PrjId);
            //if (objViewInfoENEx.arrDetailRegionFldSet  ==  null || objViewInfoENEx.arrDetailRegionFldSet.Count  ==  0)
            //{
            //    intViewFldNum = 0;
            //    return;
            //}
            //objViewInfoENEx.objViewRegion_Detail.FieldNum = objViewInfoENEx.arrDetailRegionFldSet.Count;
            foreach (clsDetailRegionFldsENEx objDetailRegionFldsENEx in objViewInfoENEx.arrDetailRegionFldSet)
            {

                objDetailRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDetailRegionFldsENEx.FldId, objViewInfoENEx.PrjId);

                objDetailRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objDetailRegionFldsENEx.CtlTypeId);
            }
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "lngRegionId">所给的关键字</param>
        /// <param name = "strPrjId"></param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsDetailRegionFldsEN> GetObjLstByRegionIdCache4InUseEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDetailRegionFldsEN> arrObjLstCache = clsDetailRegionFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel1 =
            from objDetailRegionFldsEN in arrObjLstCache
            where objDetailRegionFldsEN.RegionId == lngRegionId && objDetailRegionFldsEN.InUse == true
            orderby objDetailRegionFldsEN.SeqNum
            select objDetailRegionFldsEN;
            List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel = new List<clsDetailRegionFldsEN>();
            foreach (clsDetailRegionFldsEN obj in arrDetailRegionFldsObjLst_Sel1)
            {
                arrDetailRegionFldsObjLst_Sel.Add(obj);
            }
            //if (arrDetailRegionFldsObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return arrDetailRegionFldsObjLst_Sel;
        }


        public static List<clsDetailRegionFldsEN> GetObjLstByRegionIdCacheEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDetailRegionFldsEN> arrObjLstCache = clsDetailRegionFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel1 =
            from objDetailRegionFldsEN in arrObjLstCache
            where objDetailRegionFldsEN.RegionId == lngRegionId
            orderby objDetailRegionFldsEN.SeqNum
            select objDetailRegionFldsEN;
            List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel = new List<clsDetailRegionFldsEN>();
            foreach (clsDetailRegionFldsEN obj in arrDetailRegionFldsObjLst_Sel1)
            {
                arrDetailRegionFldsObjLst_Sel.Add(obj);
            }
            return arrDetailRegionFldsObjLst_Sel;
        }

        public static List<clsDetailRegionFldsENEx> GetDetailRegionFldsENExObjListBak20180404(string strCondition)
        {

            List<clsDetailRegionFldsENEx> arrObjENExList = new List<clsDetailRegionFldsENEx>();
            List<clsDetailRegionFldsEN> arrObjList = GetObjLst(strCondition);
            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrObjList)
            {
                clsDetailRegionFldsENEx objDetailRegionFldsENEx = new clsDetailRegionFldsENEx();
                CopyTo(objDetailRegionFldsEN, objDetailRegionFldsENEx);

                arrObjENExList.Add(objDetailRegionFldsENEx);
            }
            return arrObjENExList;
        }

        public static List<clsDetailRegionFldsENEx> GetObjExLstByRegionId4InUse1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conDetailRegionFlds.InUse);

            List<clsDetailRegionFldsENEx> arrObjENExList = new List<clsDetailRegionFldsENEx>();
            List<clsDetailRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId);
            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrObjList)
            {
                clsDetailRegionFldsENEx objDetailRegionFldsENEx = new clsDetailRegionFldsENEx();
                CopyTo(objDetailRegionFldsEN, objDetailRegionFldsENEx);
                objDetailRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objDetailRegionFldsENEx.FldId, objDetailRegionFldsENEx.PrjId());
                arrObjENExList.Add(objDetailRegionFldsENEx);
            }
            return arrObjENExList;
        }

        public static List<clsDetailRegionFldsENEx> GetObjExLstByRegionId1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conDetailRegionFlds.InUse);

            List<clsDetailRegionFldsENEx> arrObjENExList = new List<clsDetailRegionFldsENEx>();
            List<clsDetailRegionFldsEN> arrObjList = GetObjLstByRegionIdCacheEx1(lngRegionId, strCmPrjId);
            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrObjList)
            {
                clsDetailRegionFldsENEx objDetailRegionFldsENEx = new clsDetailRegionFldsENEx();
                CopyTo(objDetailRegionFldsEN, objDetailRegionFldsENEx);

                objDetailRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDetailRegionFldsENEx.FldId, objDetailRegionFldsENEx.PrjId());

                arrObjENExList.Add(objDetailRegionFldsENEx);
            }
            return arrObjENExList;
        }
        public static List<clsDetailRegionFldsENEx> GetObjExLstByRegionIdEx1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conDetailRegionFlds.InUse);

            List<clsDetailRegionFldsENEx> arrObjENExList = new List<clsDetailRegionFldsENEx>();
            List<clsDetailRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId);
            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrObjList)
            {
                clsDetailRegionFldsENEx objDetailRegionFldsENEx = new clsDetailRegionFldsENEx();
                CopyTo(objDetailRegionFldsEN, objDetailRegionFldsENEx);


                objDetailRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDetailRegionFldsENEx.FldId, objDetailRegionFldsENEx.PrjId());
                objDetailRegionFldsENEx.objCtlType = clsCtlTypeBLEx.GetObjByCtlTypeIdCache(objDetailRegionFldsENEx.CtlTypeId);
                arrObjENExList.Add(objDetailRegionFldsENEx);
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
                    clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(strMid);
                    objDetailRegionFldsEN.InUse = true;
                    objDetailRegionFldsEN.UpdUser = strUpdUser;
                    objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEN);
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
                    clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(strMid);
                    if (objDetailRegionFldsEN.IsMultiRow)
                    {
                        objDetailRegionFldsEN.IsMultiRow = false;
                    }
                    else
                    {
                        objDetailRegionFldsEN.IsMultiRow = true;
                    }
                    objDetailRegionFldsEN.InUse = true;
                    objDetailRegionFldsEN.UpdUser = strUpdUser;
                    objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEN);
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
                    clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(strMid);
                    objDetailRegionFldsEN.ColSpan = intColSpan;
                    objDetailRegionFldsEN.UpdUser = strUpdUser;
                    objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEN);
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
                    clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(strMid);
                    objDetailRegionFldsEN.Width = intWidth;
                    objDetailRegionFldsEN.UpdUser = strUpdUser;
                    objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEN);
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
                    clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(strMid);
                    objDetailRegionFldsEN.InUse = false;
                    objDetailRegionFldsEN.UpdUser = strUpdUser;
                    objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEN);
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
        public static List<clsDetailRegionFldsENEx> GetObjExLstEx(string strViewId, string strPrjId)
        {
            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId,
                    enumRegionType.DetailRegion_0006, strPrjId);
            if (string.IsNullOrEmpty(lngRegionId) == true)
            {
                return null;
            }

            List<clsDetailRegionFldsENEx> arrDetailRegionFldSet = clsDetailRegionFldsBLEx.GetObjExList(lngRegionId, strPrjId);

            foreach (clsDetailRegionFldsENEx objDetailRegionFldsENEx in arrDetailRegionFldSet)
            {

                objDetailRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDetailRegionFldsENEx.FldId, strPrjId);
                objDetailRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objDetailRegionFldsENEx.CtlTypeId);

            }
            return arrDetailRegionFldSet;
        }

        public static List<clsDetailRegionFldsENEx> GetObjExList(string lngRegionId, string strPrjId)
        {
            //string strCondition = string.Format("{0}={1} and {2}1='1' order by SeqNum", 
            //    conDetailRegionFlds.RegionId, lngRegionId, conDetailRegionFlds.InUse);
            List<clsDetailRegionFldsENEx> arrObjENExList = new List<clsDetailRegionFldsENEx>();
            List<clsDetailRegionFldsEN> arrObjList = GetObjLstByRegionIdEx(lngRegionId);
            foreach (clsDetailRegionFldsEN objDetailRegionENExFldsEN in arrObjList)
            {
                clsDetailRegionFldsENEx objDetailRegionENExFldsENEx = new clsDetailRegionFldsENEx();
                CopyTo(objDetailRegionENExFldsEN, objDetailRegionENExFldsENEx);
                arrObjENExList.Add(objDetailRegionENExFldsENEx);
            }
            return arrObjENExList;
        }

        /// <summary>
        /// 根据区域Id获取相关列表字段对象列表.
        /// </summary>
        /// <param name = "lngRegionId">区域Id</param>
        /// <returns>根据区域Id获取的对象列表</returns>
        public static List<clsDetailRegionFldsEN> GetObjLstByRegionIdEx(string lngRegionId)
        {
            //初始化列表缓存
            string strCondition = string.Format("{0}={1}", conDetailRegionFlds.RegionId, lngRegionId);
            List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel = clsDetailRegionFldsBL.GetObjLst(strCondition);
            return arrDetailRegionFldsObjLst_Sel;

        }

        public static clsDetailRegionFldsEN GetObjByvPrjTabFld(clsPrjTabFldEN objPrjTabFldEN)
        {
            //string lngRegionId = 0;
            string strUserId = "";
            //int intRecNum = 0;
            clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();

            //2、获取相关主表ID的字段的对象列表;

            if (objPrjTabFldEN.PrimaryTypeId == "02" && objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
            {
                return null;
            }
            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
            string strFldName = objFieldTab.FldName;
            //objDetailRegionFldsEN.RegionId = lngRegionId;
            objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
            objDetailRegionFldsEN.UpdUser = strUserId;
            objDetailRegionFldsEN.PrjId = objPrjTabFldEN.PrjId;

            if (objPrjTabFldEN.IsForExtendClass)
            {
                //if (string.IsNullOrEmpty(objPrjTabFldEN.DnPathId) == true) return null;
                //var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objPrjTabFldEN.DnPathId, strCmPrjId);
                //if (objDnPath == null) return null;
                //var objInDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.InDataNodeId, strCmPrjId);
                //if (objInDataNode == null) return null;
                objDetailRegionFldsEN.FldId = objPrjTabFldEN.InFldId;
                objDetailRegionFldsEN.OutFldId = objPrjTabFldEN.FldId;

                //objDetailRegionFldsEN.IsUseFunc = true;
                objDetailRegionFldsEN.LabelCaption = objFieldTab.Caption;
                //objDetailRegionFldsEN.DnPathId = objPrjTabFldEN.DnPathId;
                //objDetailRegionFldsEN.DataPropertyName = objFieldTab.FldName;
                //objDetailRegionFldsEN.OutDataNodeId = objDnPath.OutDataNodeId;
                objDetailRegionFldsEN.CtlTypeId = enumCtlType.Label_10;// "16";
                objDetailRegionFldsEN.InUse = true;

            }
            else
            {

                objDetailRegionFldsEN.FldId = objPrjTabFldEN.FldId;


                //objDetailRegionFldsEN.FldId = objPrjTabFldEN.FldId;
                //objDetailRegionFldsEN.TabId = objPrjTabFldEN.TabId;
                objDetailRegionFldsEN.FldId = objPrjTabFldEN.FldId;

                //objDetailRegionFldsEN.RegionId = lngRegionId;
                objDetailRegionFldsEN.LabelCaption = objFieldTab.Caption;
                objDetailRegionFldsEN.Width = 150;
                switch (objFieldTab.DataTypeId)
                {
                    case enumDataTypeAbbr.bit_03:
                        objDetailRegionFldsEN.CtlTypeId = enumCtlType.Label_10;
                        break;
                    default:
                        objDetailRegionFldsEN.CtlTypeId = enumCtlType.Label_10;// "16";
                        break;
                }
                //判断该字段是否为相关表中的关键字
                if (objPrjTabFldEN.FieldTypeId != enumFieldType.KeyField_02
                    && objFieldTab.IsNeedTransCode == true)
                {
                    objDetailRegionFldsEN.CtlTypeId = enumCtlType.Label_10;
                }
                else
                {
                    objDetailRegionFldsEN.CtlTypeId = enumCtlType.Label_10;
                }
                if (clsPrjTabBL.GetObjByTabIdCache(objPrjTabFldEN.TabId, objPrjTabFldEN.PrjId).SqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    objDetailRegionFldsEN.InOutTypeId = clsInOutTypeBLEx.OUT_Type;
                }
                else
                {
                    objDetailRegionFldsEN.InOutTypeId = clsInOutTypeBLEx.OUTIN_Type;
                }
                //if (clsViewRegionBL.GetObjByRegionId(lngRegionId).RegionTypeId == clsRegionTypeBLEx.DETAILREGION)
                //{
                //    objDetailRegionFldsEN.InOutTypeId = clsInOutTypeBLEx.OUT_Type;
                //    objDetailRegionFldsEN.CtlTypeId = clsCtlTypeBLEx.LABELTYPE;

                //}
                objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
                objDetailRegionFldsEN.UpdUser = strUserId;

                //5、检查传进去的对象属性是否合法
                if (objFieldTab.FldName.StartsWith("_"))
                {
                    objDetailRegionFldsEN.InUse = false;
                }
                else
                {
                    if (objPrjTabFldEN.FieldTypeId == enumFieldType.Log_UpdDate_13 || objPrjTabFldEN.FieldTypeId == enumFieldType.Log_UpdUser_14)
                    {
                        objDetailRegionFldsEN.InUse = false;
                    }
                    else
                    {
                        objDetailRegionFldsEN.InUse = true;
                    }
                }
                //       clsDetailRegionFldsBL.CheckPropertyNew(objDetailRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中

            }

            return objDetailRegionFldsEN;

        }

        public static IEnumerable<ASPControlEx> GetControlLst4Regoin(string lngRegionId, string strPrjId, string strCmPrjId, string strItemName4MultiModel = "")
        {
            clsvViewRegionEN objViewRegion = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //clsViewInfoENEx objViewInfoENEx = clsViewInfoBLEx.GetObjExByViewId(objViewRegion.ViewId, objViewRegion.PrjId);


            List<clsDetailRegionFldsENEx> arrDetailRegionFlds = clsDetailRegionFldsBLEx.GetObjExLstByRegionId4InUse1(lngRegionId, strCmPrjId);

            Func<clsViewFeatureFldsENEx, ASPControlEx> GetControl_Asp4MultiModel = obj => clsASPControlBLEx.GetControl_Asp(obj, strItemName4MultiModel);

            IEnumerable<ASPControlEx> arrControls = arrDetailRegionFlds.Select(x => clsASPControlBLEx.GetControl_Asp(x, strCmPrjId));
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

        //    List<clsDetailRegionFldsEN> arrDetailRegionFldsENObjLst = clsDetailRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsDetailRegionFldsEN objDetailRegionFldsEN4Web in arrDetailRegionFldsENObjLst)
        //    {

        //        objDetailRegionFldsEN4Web.IsSynchToServer = true;
        //        objDetailRegionFldsEN4Web.SynchToServerDate = strCurrDate14;
        //        objDetailRegionFldsEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsDetailRegionFldsEN objDetailRegionFldsEN4Web2 = new clsDetailRegionFldsEN();
        //            clsDetailRegionFldsBL.CopyTo(objDetailRegionFldsEN4Web, objDetailRegionFldsEN4Web2);
        //            objDetailRegionFldsEN4Web2.SynSource = "Client";
        //            strCondition = objDetailRegionFldsEN4Web.GetUniquenessConditionString();
        //            clsDetailRegionFldsEN objDetailRegionFlds_Target = clsDetailRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objDetailRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objDetailRegionFlds_Target.UpdDate.CompareTo(objDetailRegionFldsEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    objDetailRegionFldsEN4Web2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsDetailRegionFldsBL.AddNewRecordBySql2(objDetailRegionFldsEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objDetailRegionFldsEN4Web.RegionId,
        //                        objDetailRegionFldsEN4Web.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
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

        //    List<clsDetailRegionFldsEN> arrDetailRegionFldsENObjLst = clsDetailRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsDetailRegionFldsEN objDetailRegionFldsEN4Main in arrDetailRegionFldsENObjLst)
        //    {

        //        objDetailRegionFldsEN4Main.IsSynchToClient = true;
        //        objDetailRegionFldsEN4Main.SynchToClientDate = strCurrDate14;
        //        objDetailRegionFldsEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        try
        //        {
        //            clsDetailRegionFldsEN objDetailRegionFldsEN4Main2 = new clsDetailRegionFldsEN();
        //            clsDetailRegionFldsBL.CopyTo(objDetailRegionFldsEN4Main, objDetailRegionFldsEN4Main2);
        //            objDetailRegionFldsEN4Main2.SynSource = "Server";
        //            strCondition = objDetailRegionFldsEN4Main.GetUniquenessConditionString();
        //            clsDetailRegionFldsEN objDetailRegionFlds_Target = clsDetailRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objDetailRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objDetailRegionFlds_Target.UpdDate.CompareTo(objDetailRegionFldsEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {
        //                    objDetailRegionFldsEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsDetailRegionFldsBL.AddNewRecordBySql2(objDetailRegionFldsEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objDetailRegionFldsEN4Main.RegionId,
        //                        objDetailRegionFldsEN4Main.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
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
        public static List<clsDetailRegionFldsENEx> GetObjExLstByRegionIdCacheEx1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} order by SeqNum", lngRegionId);
            List<clsDetailRegionFldsENEx> arrObjENExList = new List<clsDetailRegionFldsENEx>();
            List<clsDetailRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId);
            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrObjList)
            {
                clsDetailRegionFldsENEx objDetailRegionFldsENEx = new clsDetailRegionFldsENEx();
                CopyTo(objDetailRegionFldsEN, objDetailRegionFldsENEx);
                objDetailRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDetailRegionFldsENEx.FldId, objDetailRegionFldsENEx.PrjId());

                objDetailRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objDetailRegionFldsENEx.CtlTypeId);
                arrObjENExList.Add(objDetailRegionFldsENEx);
            }
            return arrObjENExList;
        }
        public static bool AdjustSequenceNumber(string strDirect, long lngMid)
        {
            //操作步骤:
            //1、获取当前所选中的关键字Mid。
            //2、根据关键字Mid来获取字的序号
            //3、如果当前序号是否是末端序号,
            //		3.1 如果是末端序号,就退出,
            //		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
            //		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
            //		    如果是向上移动,就判断当前序号是否“大于”1,
            //		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字Mid
            //5、把当前关键字Mid的序号加(减)1
            //6、把下一个序号的关键字Mid减(加)1
            //7、重新显示DATAGRID

            int intSeqNum;	//当前记录的序号
            int intPrevSeqNum, intNextSeqNum;	//上下两条记录的序号
            //			string strMid;
            long lngPrevMid = 0;	//上一条序号的关键字MId
            long lngNextMid = 0;	//下一条序号的关键字MId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrRegionId;
            List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(lngMid);
            intSeqNum = objDetailRegionFldsEN.SeqNum ?? 0;
            intPrevSeqNum = intSeqNum - 1;
            intNextSeqNum = intSeqNum + 1;
            //3、如果当前序号是否是末端序号,
            //		3.1 如果是末端序号,就退出,
            strCurrRegionId = objDetailRegionFldsEN.RegionId;		//获取当前记录的{表ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond(clsDetailRegionFldsEN._CurrTabName, "RegionId = '" + strCurrRegionId + "'");	//获取当前{表ID}的记录数
            if (strDirect == "UP")
            {
                if (intSeqNum <= 1)
                {
                    throw new clsDbObjException("已经是第一条记录,不能再上移!");
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intSeqNum >= intTabRecNum)	//如果当前序号大于表记录数
                {
                    throw new clsDbObjException("已经是最后一条记录,不能再下移!");
                }
            }
            //		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
            //		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
            //		    如果是向上移动,就判断当前序号是否“大于”1,
            //		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。

            //4、获取下(上)一个序号字段的关键字Mid
            if (strDirect == "UP")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum - 1);
                arrID = clsDetailRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new clsDbObjException("获取上一条记录的关键字出错!");

                }
                if (arrID.Count <= 0)
                {
                    throw new clsDbObjException("获取上一条记录的关键字出错!");
                }
                lngPrevMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum + 1);
                arrID = clsDetailRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new clsDbObjException("获取下一条记录的关键字出错!");

                }
                if (arrID.Count <= 0)
                {
                    throw new clsDbObjException("获取下一条记录的关键字出错!");
                }
                lngNextMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect == "FIRST")
            {
            }
            else if (strDirect == "LAST")
            {
            }
            else
            {
                throw new clsDbObjException("方向参数出错!");
            }
            //5、把当前关键字Mid的序号加(减)1
            //6、把下一个序号的关键字Mid减(加)1
            if (strDirect == "UP")
            {
                clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, "SeqNum", intSeqNum - 1, "MId = " + lngMid);
                clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, "SeqNum", intPrevSeqNum + 1, "MId = " + lngPrevMid);
                clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);
            }
            else if (strDirect == "DOWN")
            {
                clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, "SeqNum", intSeqNum + 1, "MId = " + lngMid);
                clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, "SeqNum", intNextSeqNum - 1, "MId = " + lngNextMid);
                clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);
            }
            else if (strDirect == "FIRST")
            {
                clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, "SeqNum", 0, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect == "LAST")
            {
                clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, "SeqNum", 1000, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            //7、重新显示DATAGRID
            return true;
        }
        public new static void ReOrder(string lngRegionId)
        {
            IEnumerable<clsDetailRegionFldsEN> arrDetailRegionFldsObjList = clsDetailRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            arrDetailRegionFldsObjList = arrDetailRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);
            int intIndex = 1;
            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrDetailRegionFldsObjList)
            {
                objDetailRegionFldsEN.SeqNum = intIndex;
                clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEN);
                intIndex++;
            }
        }
        public static bool ImportRelaFlds(string lngRegionId, string strPrjId, string strUserId)
        {
            //string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            int intRecNum = 0;
            //clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();


            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, strPrjId).TabId;
            //2、获取相关主表ID的字段的对象列表;
            IEnumerable<clsPrjTabFldEN> arrRelaTabFldObjList =
                clsPrjTabFldBL.GetObjLst("TabId = '" + strRelaTabId + "' order by SequenceNumber");

            List<string> arrNoNeedFieldTypeId = new List<string>() {
                enumFieldType.ManageField_04,
                enumFieldType.BeingNot_18,
                enumFieldType.SynField_08,
                enumFieldType.CalcField_11
            };


            arrRelaTabFldObjList = arrRelaTabFldObjList.Where(x => arrNoNeedFieldTypeId.Contains(x.FieldTypeId) == false);


            List<clsDetailRegionFldsEN> arrDetailRegionFlds = arrRelaTabFldObjList
                .Where(x => x.PrimaryTypeId != enumPrimaryType.Identity_02)
                .Select(x => clsDetailRegionFldsBLEx.GetObjByvPrjTabFld(x)).ToList();
            intRecNum = clsGeneralTab2.funGetRecCountByCond(clsDetailRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);

            var arrPrjTabFld = clsvPrjTabFld_SimBL.GetObjLstCache(strPrjId);

            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrDetailRegionFlds)
            {
                if (string.IsNullOrEmpty(objDetailRegionFldsEN.FldId) == true) continue;
                if (objDetailRegionFldsEN == null) continue;
                var objPrjTabFld = arrPrjTabFld.Find(x => x.FldId == objDetailRegionFldsEN.FldId && x.FieldTypeId == enumFieldType.KeyField_02);
                if (objPrjTabFld != null)
                {
                    var objPrjTabFld_Name = arrPrjTabFld.Find(x => x.TabId == objPrjTabFld.TabId && x.FieldTypeId == enumFieldType.NameField_03);
                    if (objPrjTabFld_Name != null)
                    {
                        if (arrDetailRegionFlds.Find(x => x != null && x.FldId == objPrjTabFld_Name.FldId) != null)
                        {
                            objDetailRegionFldsEN.InUse = false;
                        }
                    }
                }
                objDetailRegionFldsEN.SetUpdDate(clsDateTime.getTodayStr(0))
                    .SetUpdUser(strUserId)
                    .SetPrjId(strPrjId)
                    .SetRegionId(lngRegionId);

                //5、检查传进去的对象属性是否合法

                clsDetailRegionFldsBL.CheckPropertyNew(objDetailRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中
                //long lngTabFldId = objDetailRegionFldsEN.TabFldId;
                //                string strFldName = clsFieldTabBL.GetObjByFldId(objDetailRegionFldsEN.FldId).FldName;

                string strCondition = objDetailRegionFldsEN.GetUniCondStr();
                if (clsDetailRegionFldsBL.IsExistRecord(strCondition) == false)
                {
                    objDetailRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsDetailRegionFldsBL.AddNewRecordBySql2(objDetailRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加编辑区域字段不成功!" + clsFieldTabBL.GetNameByFldIdCache(objDetailRegionFldsEN.FldId, strPrjId));
                    }

                }

            }
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate(lngRegionId);

            return true;

        }
        public static bool ImportRelaFlds_Detail(string lngRegionId, string strPrjId, string strUserId)
        {

            int intRecNum = 0;
            clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();

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

            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrRelaTabFldObjList)
            {
                if (objPrjTabFldEN.PrimaryTypeId == "02" && objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                objDetailRegionFldsEN.FldId = objPrjTabFldEN.FldId;
                objDetailRegionFldsEN.RegionId = lngRegionId;
                switch (objPrjTabFldEN.DataTypeName)
                {
                    case "bit":
                        objDetailRegionFldsEN.CtlTypeId = enumCtlType.Label_10;// "02";
                        break;
                    default:
                        objDetailRegionFldsEN.CtlTypeId = enumCtlType.Label_10;//"16";
                        break;
                }
                //判断该字段是否为相关表中的关键字
                if (objPrjTabFldEN.FieldTypeId != enumFieldType.KeyField_02
                    && objPrjTabFldEN.IsNeedTransCode == true)
                {
                    objDetailRegionFldsEN.CtlTypeId = enumCtlType.Label_10;
                }
                else
                {
                    objDetailRegionFldsEN.CtlTypeId = enumCtlType.Label_10;
                }
                objDetailRegionFldsEN.InOutTypeId = clsInOutTypeBLEx.OUT_Type;		//输出类型
                objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
                objDetailRegionFldsEN.UpdUser = strUserId;
                objDetailRegionFldsEN.PrjId = strPrjId;

                //5、检查传进去的对象属性是否合法

                clsDetailRegionFldsBL.CheckPropertyNew(objDetailRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中

                string strFldName = clsFieldTabBL.GetObjByFldId(objDetailRegionFldsEN.FldId).FldName;
                intRecNum = clsGeneralTab2.funGetRecCountByCond(clsDetailRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);
                if (clsvDetailRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == false)
                {
                    objDetailRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsDetailRegionFldsBL.AddNewRecordBySql2(objDetailRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加编辑区域字段不成功!" + clsFieldTabBL.GetFldNameByFldIdCache(objDetailRegionFldsEN.FldId, strPrjId));
                    }
                    else
                    {
                    }
                }

            }
            return true;

        }


        public static bool ImportRelaFlds(string lngRegionId, List<clsPrjTabFldEN> arrRelaTabFldObjList, string strPrjId, string strUserId)
        {
            int intRecNum = 0;
            //clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();

            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            clsPrjTabEN objRelaPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, strPrjId);

            IEnumerable<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst = arrRelaTabFldObjList.Where(x => x.PrimaryTypeId != enumPrimaryType.Identity_02)
                .Select(x => clsDetailRegionFldsBLEx.GetObjByvPrjTabFld(x));

            //2、获取相关主表ID的字段的对象列表;
            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrDetailRegionFldsObjLst)
            {
                objDetailRegionFldsEN.RegionId = lngRegionId;

                objDetailRegionFldsEN.UpdUser = strUserId;
                objDetailRegionFldsEN.PrjId = strPrjId;

                //5、检查传进去的对象属性是否合法

                clsDetailRegionFldsBL.CheckPropertyNew(objDetailRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中

                string strFldName = clsFieldTabBL.GetObjByFldId(objDetailRegionFldsEN.FldId).FldName;
                if (clsvDetailRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == false)
                {
                    objDetailRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsDetailRegionFldsBL.AddNewRecordBySql2(objDetailRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加编辑区域字段不成功!" + clsFieldTabBL.GetFldNameByFldIdCache(objDetailRegionFldsEN.FldId, strPrjId));
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


            List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst = clsDetailRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(lngRegionId_S, strCmPrjId);
            foreach (clsDetailRegionFldsEN objInfor2 in arrDetailRegionFldsObjLst)
            {
                clsDetailRegionFldsEN objInfor2_T = new clsDetailRegionFldsEN();
                clsDetailRegionFldsBL.CopyTo(objInfor2, objInfor2_T);
                objInfor2_T.RegionId = lngRegionId_T;
                objInfor2_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strUpdUser);
                objInfor2_T.EditRecordEx();
            }
            return true;
        }

        public static bool AddColumn_SourceTabName(ref System.Data.DataTable objDT)
        {
            objDT.Columns.Add("SourceTabName");
            foreach (DataRow objDR in objDT.Rows)
            {
                string strPrjId = objDR[convDetailRegionFlds.PrjId].ToString();
                //string 1strFldID = objDR[convDetailRegionFlds.FldId].ToString();
                string strFldName = objDR[convDetailRegionFlds.FldName].ToString();
                string strTabId = objDR[convDetailRegionFlds.TabId].ToString();
                if (string.IsNullOrEmpty(strTabId) == true) continue;
                try
                {

                    //var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
                    clsvSqlViewFldEN objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFieldAliasesExCache(strPrjId, strTabId, strFldName);
                    if (objvSqlViewFldEN == null)
                    {
                        objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFldNameExCache(strPrjId, strTabId, strFldName);

                    }
                    if (objvSqlViewFldEN != null)
                    {
                        objDR["SourceTabName"] = objvSqlViewFldEN.TabName;
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                }
            }

            return true;
        }
        public static bool CheckOutFldId(clsDetailRegionFldsENEx objDetailRegionFldsEx, bool bolIsFstLcase, string strPrjId, string strOpUser)
        {
            string strMsg = "";
            string strOutFldId = objDetailRegionFldsEx.OutFldId;

            try
            {
                var objFieldTab_Out = clsFieldTabBL.GetObjByFldIdCache(strOutFldId, strPrjId);

                if (objFieldTab_Out == null)
                {

                    var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);

                    strMsg = string.Format("检查Out字段时, 输出字段:[{0}]不存在。在 PrjId={1}({2})，请检查！(In {3})",
                         strOutFldId, strPrjId, objProject.PrjName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);


                }
                return true;
            }
            catch (Exception objException)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDetailRegionFldsEx.FldId, objDetailRegionFldsEx.PrjId());
                var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                strMsg = string.Format("检查OutFldId:[{0}({1})], 属性:[{2}])，出错:{3}。 CmPrjId={4}({5})，请检查！(In {6})",
                    strOutFldId, objFieldTab.FldName, objDetailRegionFldsEx.DataPropertyName(),
                    objException.Message,
                    strPrjId, objProject.PrjName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        //public static bool CheckOutDataNodeId(clsDetailRegionFldsEN objDetailRegionFldsEx, string strCmPrjId, string strOpUser)
        //{
        //    string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
        //    string strMsg = "";
        //    long strOutDataNodeId = objDetailRegionFldsEx.OutDataNodeId;
        //    try
        //    {
        //        var objDataNode_Out = clsDataNodeBL.GetObjByDataNodeIdCache(strOutDataNodeId, strCmPrjId);

        //        if (objDataNode_Out == null)
        //        {
        //            var strDataNodeId_New = clsDataNodeBLEx.GetNewDataNodeIdByCmPrjId(strOutDataNodeId, strCmPrjId);
        //            if (string.IsNullOrEmpty(strDataNodeId_New) == true)
        //            {
        //                var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);

        //                var objDataNode = clsDataNodeBL.GetObjByDataNodeId(strOutDataNodeId);
        //                if (objDataNode == null)
        //                {
        //                    strMsg = string.Format("检查Out结点时, 输出结点:[{0}]不存在。在 CmPrjId={1}({2})，请检查！(In {3})",
        //                         strOutDataNodeId, strCmPrjId, objCMProject.CmPrjName,
        //                        clsStackTrace.GetCurrClassFunction());
        //                    throw new Exception(strMsg);
        //                }
        //                strMsg = string.Format("转换函数中，属性:[{0}], 输出结点:[{1}]({2}), 不存在。在 VersionNo=1, CmPrjId={3}，请检查！(In {4})",
        //                     objDetailRegionFldsEx.DataPropertyName,
        //                    objDataNode.DataNodeName, objDataNode.DataNodeId, strCmPrjId, objCMProject.CmPrjName,
        //                    clsStackTrace.GetCurrClassFunction());
        //                throw new Exception(strMsg);
        //            }
        //            else
        //            {
        //                strOutDataNodeId = strDataNodeId_New;
        //                objDetailRegionFldsEx.OutDataNodeId = strDataNodeId_New;
        //                objDetailRegionFldsEx.UpdDate = clsDateTime.getTodayDateTimeStr(1);
        //                objDetailRegionFldsEx.UpdUser = strOpUser;
        //                clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEx);
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception objException)
        //    {
        //        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDetailRegionFldsEx.FldId, strPrjId_p);
        //        var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
        //        strMsg = string.Format("检查OutDataNodeId:[{0}]时(字段:[{1}({2})], 属性:[{3}])，出错:{4}。 CmPrjId={5}({6})，请检查！(In {7})",
        //            strOutDataNodeId, objFieldTab.FldName, objDetailRegionFldsEx.FldId, objDetailRegionFldsEx.DataPropertyName,
        //            objException.Message,
        //            strCmPrjId, objCMProject.CmPrjName,
        //            clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //}

        public static List<clsDetailRegionFldsEN> GetObjLstByPrjIdCache(string strPrjId)
        {
            //初始化列表缓存
            List<clsDetailRegionFldsEN> arrObjLstCache = clsDetailRegionFldsBL.GetObjLstCache(strPrjId);
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBLEx.GetObjLstByPrjIdCache(strPrjId);
            List<string> arrRegionId = arrViewRegion.Select(x => x.RegionId).ToList();
            List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId) == true && x.InUse == true)
                .OrderBy(x => x.SeqNum)
                .ToList();
            return arrDetailRegionFldsObjLst_Sel;
        }
        public static clsDetailRegionFldsENEx GetObjExBymIdCache(long lngMid, string strPrjId)
        {
            //初始化列表缓存
            clsDetailRegionFldsEN objDetailRegionFlds = clsDetailRegionFldsBL.GetObjBymIdCache(lngMid, strPrjId);
            var objEx = CopyToEx(objDetailRegionFlds);
            return objEx;
        }


        public static bool ImportExtendFld(long lngMid, string strPrjId, string strUserId)
        {
            //JumpOtherPages("CheckConsistency");
            var objDetailRegionFlds = clsDetailRegionFldsBLEx.GetObjExBymIdCache(lngMid, strPrjId);
            var objDetailRegionFldsEx = GetObjEx(objDetailRegionFlds);
            if (objDetailRegionFlds.IsUseFunc() == false)
            {
                string strMsg = string.Format("当前区域字段:[{0}]没有使用扩展字段功能，不需要导入到表中！(in {1})", lngMid, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            };

            if (string.IsNullOrEmpty(objDetailRegionFlds.DataPropertyName()) == true) return false;
            return true;
            //var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDetailRegionFlds.OutDataNodeId, strCmPrjId);
            //if (objDataNode == null) return false;
            //return clsPubRegionFldsBLEx.AddExtendClassToPrjTabFld(objDataNode, objViewRegion, objDetailRegionFlds.DataPropertyName, objDetailRegionFlds.LabelCaption, objDetailRegionFlds.DnPathId, strUserId);

        }

        public static int GetRecCount4InUseCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDetailRegionFldsEN> arrObjLstCache = clsDetailRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrDetailRegionFldsObjLst_Sel.Count;
        }


        public static int GetRecCountCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDetailRegionFldsEN> arrObjLstCache = clsDetailRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrDetailRegionFldsObjLst_Sel.Count;
        }
        public static bool SetCmPrjId1(string strRegionId, string strPrjId, string strUserId)
        {
            try
            {
                List<clsDetailRegionFldsEN> arrDetailRegionFlds = clsDetailRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
                foreach (var objInFor in arrDetailRegionFlds)
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

        public static clsDetailRegionFldsENEx GetObjEx(clsDetailRegionFldsEN objDetailRegionFlds)
        {
            clsDetailRegionFldsENEx objDetailRegionFldsENEx = new clsDetailRegionFldsENEx();
            CopyTo(objDetailRegionFlds, objDetailRegionFldsENEx);
            return objDetailRegionFldsENEx;
        }

        public static clsErrMsgENEx CheckRegionFlds(string strRegionId, string strCmPrjId, string strOpUserId)
        {
            string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            //1、获取当前区域ID的相关主表ID；
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            string strMsg = "";
            int intErrCount = 0;
            var arrDetailRegionFlds = clsDetailRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
            var arrDetailRegionFldsEx = arrDetailRegionFlds.Select(clsDetailRegionFldsBLEx.GetObjEx).ToList();
            //StringBuilder sbErrMsg = new StringBuilder();
            //try
            //{

            foreach (var objInFor in arrDetailRegionFldsEx)
            {
                if (objInFor.InUse == false) continue;
                try
                {
                    if (string.IsNullOrEmpty(objInFor.FldId) == true)
                    {
                        strMsg = $"控件:[{objInFor.LabelCaption}]的字段Id(FldId)为空！({clsStackTrace.GetCurrClassFunctionByLevel(2)})";
                        throw new Exception(strMsg);
                    }
                    if (objInFor.IsTabField() == false)
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldId, objInFor.PrjId);
                        strMsg = $"控件:[{objInFor.LabelCaption}]的字段:[{objFieldTab.FldName}({objInFor.FldId})]，不在查询区的相关表中，请检查！({clsStackTrace.GetCurrClassFunctionByLevel(2)})";
                        throw new Exception(strMsg);
                    }

                    switch (objInFor.CtlTypeId)
                    {
                        case enumCtlType.DropDownList_06:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
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
                        case enumCtlType.Label_10:
                            if (objInFor.DnPathId() == null)
                            {
                            }
                            else
                            {
                                var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objInFor.DnPathId(), objInFor.PrjId);
                                clsDnPathBLEx.CheckDnPath(objDnPath, strOpUserId);
                                if (objDnPath.ErrMsg != null && objDnPath.ErrMsg.Length > 0)
                                {
                                    strMsg = string.Format("控件:[{0}]中，路径出错:[{1}].({2})",
                  objInFor.LabelCaption, objDnPath.ErrMsg,
                clsStackTrace.GetCurrClassFunctionByLevel(2));
                                    throw new Exception(strMsg);
                                }
                            }
                            //clsPubFun4BLEx.CheckDnPath_In(objInFor);
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
                    //if (objInFor.DnPathId == "") objInFor.DnPathId = null;
                    objInFor.Update();
                    intErrCount++;
                    continue;
                }
                if (objInFor.ErrMsg != null && objInFor.ErrMsg.Length > 0)
                {
                    objInFor.ErrMsg = "";
                    //if (objInFor.DnPathId == "") objInFor.DnPathId = null;
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
            var objErrMsg = new clsErrMsgENEx(conErrType.DetailRegion, intErrCount);
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

        public static bool CheckRegionFldsUp(string strRegionId, string strCmPrjId, string strOpUserId)
        {
            var strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var objErrMsg_New = CheckRegionFlds(strRegionId, strCmPrjId, strOpUserId);
            var arrViewId = clsViewRegionRelaBLEx.GetViewIdLstByRegionIdCache(strRegionId, strPrjId_p);
            var arrViewInfo = clsViewInfoBL.GetObjLstByViewIdLstCache(arrViewId, strPrjId_p);
            if (objErrMsg_New.ErrNum == 0)
            {
                foreach (var objInFor in arrViewInfo)
                {
                    if (objInFor.ErrMsg == null) continue;
                    if (objInFor.ErrMsg.Length == 0) continue;
                    var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
                    if (arrErrMsg == null) continue;
                    if (arrErrMsg.Count == 0) continue;
                    var arrErrMsg_Del = arrErrMsg.Where(x => x.ErrType != objErrMsg_New.ErrType).ToList();
                    string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg_Del);
                    objInFor.ErrMsg = strErrMsg_New;
                    objInFor.Update();
                }
            }
            else
            {

                foreach (var objInFor in arrViewInfo)
                {
                    var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
                    clsErrMsgBLEx.AddObj(arrErrMsg, objErrMsg_New);
                    string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg);
                    objInFor.ErrMsg = strErrMsg_New;
                    objInFor.Update();
                }
            }
            return true;
        }

        //public static string GetRegionIdByDnPathId(string strDnPathId)
        //{
        //    string strCondition = string.Format("{0}='{1}'", conDetailRegionFlds.DnPathId, strDnPathId);
        //    var objDetailRegionFlds = GetFirstObj_S(strCondition);
        //    if (objDetailRegionFlds == null) return "";
        //    return objDetailRegionFlds.RegionId;
        //}

        //public static clsDetailRegionFldsEN GetObjByDnPathId(string strDnPathId)
        //{
        //    string strCondition = string.Format("{0}='{1}'", conDetailRegionFlds.DnPathId, strDnPathId);
        //    var objDetailRegionFlds = GetFirstObj_S(strCondition);
        //    if (objDetailRegionFlds == null) return null;
        //    return objDetailRegionFlds;
        //}

    }
}
