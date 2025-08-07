using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using AGC.BusinessLogic;
using com.taishsoft.datetime;
using AGC.PureClass;
using AGC.BusinessLogicEx;
using CodeStruct;

namespace AutoGCLib
{
    public class ASPDropDownListComparer : IEqualityComparer<ASPDropDownListEx>
    {
        public bool Equals(ASPDropDownListEx t1, ASPDropDownListEx t2)
        {
            return (t1.CtrlId == t2.CtrlId);
        }
        public int GetHashCode(ASPDropDownListEx t)
        {
            return t.ToString().GetHashCode();
        }
    }
    public class ASPDropDownListEx4GCComparer : IEqualityComparer<ASPDropDownListEx>
    {
        public bool Equals(ASPDropDownListEx t1, ASPDropDownListEx t2)
        {
            return (t1.CtrlId == t2.CtrlId);
        }
        public int GetHashCode(ASPDropDownListEx t)
        {
            return t.ToString().GetHashCode();
        }
    }
    //public class ASPDropDownListComparer : IEqualityComparer<ASPDropDownListEx>
    //{
    //    public bool Equals(ASPDropDownListEx t1, ASPDropDownListEx t2)
    //    {
    //        return (t1.CtrlId == t2.CtrlId);
    //    }
    //    public int GetHashCode(ASPDropDownListEx t)
    //    {
    //        return t.ToString().GetHashCode();
    //    }
    //}


    public class DsTabNameComparer : IEqualityComparer<ASPDropDownListEx>
    {
        public bool Equals(ASPDropDownListEx t1, ASPDropDownListEx t2)
        {
            return (t1.DsTabName == t2.DsTabName);
        }
        public int GetHashCode(ASPDropDownListEx t)
        {
            return t.ToString().GetHashCode();
        }
    }

    public class PropertyDef4GCComparer : IEqualityComparer<clsPropertyDef4GC>
    {
        public bool Equals(clsPropertyDef4GC t1, clsPropertyDef4GC t2)
        {
            return (t1.OperateType == t2.OperateType && t1.PropertyName == t2.PropertyName);
        }
        public int GetHashCode(clsPropertyDef4GC t)
        {
            return t.ToString().GetHashCode();
        }
    }

    //public class PropertyDef4GCComparer : IEqualityComparer<clsPropertyDef4GC>
    //{
    //    public bool Equals(clsPropertyDef4GC t1, clsPropertyDef4GC t2)
    //    {
    //        return (t1.OperateType == t2.OperateType && t1.PropertyName == t2.PropertyName);
    //    }
    //    public int GetHashCode(clsPropertyDef4GC t)
    //    {
    //        return t.ToString().GetHashCode();
    //    }
    //}

    public class ImportClass4GCComparer : IEqualityComparer<ImportClass>
    {
        public bool Equals(ImportClass t1, ImportClass t2)
        {
            return (t1.ClsName == t2.ClsName);
        }
        public int GetHashCode(ImportClass t)
        {
            return t.ToString().GetHashCode();
        }
    }

    class VFunction4GeneCodeComparer2 : IEqualityComparer<clsvFunction4GeneCodeEN>
    {
        // Products are equal if their names and product numbers are equal.
        public bool Equals(clsvFunction4GeneCodeEN x, clsvFunction4GeneCodeEN y)
        {

            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.FuncId4GC == y.FuncId4GC;
        }

        // If Equals() returns true for a pair of objects 
        // then GetHashCode() must return the same value for these objects.

        public int GetHashCode(clsvFunction4GeneCodeEN product)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(product, null)) return 0;

            //Get hash code for the Name field if it is not null.
            int hashProductName = product.FuncName == null ? 0 : product.FuncName.GetHashCode();

            //Get hash code for the Code field.
            int hashProductCode = product.FuncId4GC.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductName ^ hashProductCode;
        }

    }
    //public class PropertyDef4GCComparer : IEqualityComparer<clsPropertyDef4GC>
    //{
    //    public bool Equals(clsPropertyDef4GC t1, clsPropertyDef4GC t2)
    //    {
    //        return (t1.OperateType == t2.OperateType && t1.PropertyName == t2.PropertyName);
    //    }
    //    public int GetHashCode(clsPropertyDef4GC t)
    //    {
    //        return t.ToString().GetHashCode();
    //    }
    //}

    public class clsPubFun4GC : clsGeneCodeBase4Tab
    {

        public clsPubFun4GC(string strTabId, string strPrjDataBaseId, string strPrjId)
         : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public static List<ImportClass> ImportClass_RemoveDup(List<ImportClass> arrImportClass)
        {

            var arrImportClass_sort = arrImportClass.OrderBy(x => x.FilePath).ToList();

            var arrImportClass_RemoveDup = new List<ImportClass>();
            foreach (var objInFor in arrImportClass)
            {
                var obj_New = arrImportClass_RemoveDup.Find(x => x.FilePath == objInFor.FilePath);
                if (obj_New == null)
                {
                    arrImportClass_RemoveDup.Add(objInFor);
                }
                else
                {
                    var arrClass = obj_New.ClsName.Split(",".ToCharArray()).Select(x => x.Trim()).ToList();
                    HashSet<string> set1 = new HashSet<string>(arrClass);

                    var arrClass_New = objInFor.ClsName.Split(",".ToCharArray()).Select(x => x.Trim()).ToList();
                    HashSet<string> set2 = new HashSet<string>(arrClass_New);
                    set1.UnionWith(set2);
                    obj_New.ClsName = string.Join(",", set1);
                }
            }
            return arrImportClass_RemoveDup;
        }

        public static void GC_CheckCode4CacheClassifyFld(StringBuilder strCodeForCs, int intFldLen, string strVarName, string strClassName)
        {
            string strTemp = clsString.combineStrS("9", intFldLen - 1) + "1";
            strCodeForCs.AppendFormat("\r\n" + "if ({1} == \"{0}\")", strTemp, strVarName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"{1}.{2}Cache='{0}',还没有被赋正确的值,请检查!\");", strTemp, strClassName, strVarName);
            strCodeForCs.Append("\r\n" + "throw (strMsg)");
            strCodeForCs.Append("\r\n" + "}");
        }
        public static string GC_GetToken(clsPrjTabENEx objPrjTabENEx, IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.ApplicationTypeId == (int)enumApplicationType.VueAppInCore_TS_30)
            {
                strCodeForCs.Append("\r\n" + "const token = Storage.get(ACCESS_TOKEN_KEY);");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "const token = clsPublocalStorage.token;");
                objImportClass.AddImportClass("", "/PubFun/clsPublocalStorage.js", "clsPublocalStorage", enumImportObjType.CustomFunc, strBaseUrl);
            }
            return strCodeForCs.ToString();
        }


        public static void Gen_WApi_Ts_ControlProperty4One_NotInDiv(StringBuilder strCodeForCs, clsPropertyDef4GC x, IImportClass objImportClass, string strBaseUrl)
        {
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
            //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            string strIsStatic = "";
            if (x.IsStatic) strIsStatic = "static";
            switch (x.OperateType)
            {
                case "get":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":

                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":


                            if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "const str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                objImportClass.AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                                strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            }
                            //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                        case "button":
                            if (x.ThisClsName.IndexOf("_Detail") >= 0)
                            {
                                strCodeForCs.Append("\r\n" + $"const strValue = ref{x.ThisClsName}.value.{x.RefVarName};");
                                strCodeForCs.Append("\r\n" + "return strValue;");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + $"const strValue = ref{x.ThisClsName}.value.{x.RefVarName};");
                                strCodeForCs.Append("\r\n" + "return strValue;");
                            }
                            break;

                        case "dropdownlist":
                        case "DropDownList":

                            if (x.DataType == "boolean")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                            }
                            else if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "CacheClassifyFieldTS":
                            strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return Number(strValue);");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return strValue;");
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return 0;");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return \"\";");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                    }
                    break;
                case "set":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);


                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value !== null ? value.toString() : '');", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "button":

                            //strCodeForCs.AppendFormat("\r\n" + " SetButtonHtmlByIdInDivObj({0}, \"{1}\", value);", x.ParentDivName, x.CtrlId);
                            //objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetButtonHtmlByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);
                            if (x.ThisClsName.IndexOf("_Detail") >= 0)
                            {
                                strCodeForCs.Append("\r\n" + $"ref{x.ThisClsName}.value.{x.RefVarName} = value;");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + $"ref{x.ThisClsName}.value.{x.RefVarName} = value;");
                            }
                            break;
                        case "Label":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value !== null ? value.toString() : '');");
                            break;
                        case "CacheClassifyFieldTS":
                            strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value !== null ? value.toString() : '');");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                    }
                    break;
            }
            strCodeForCs.Append("\r\n" + "}");

        }
        /// <summary>
        /// 获取函数名的附加参数
        /// </summary>
        /// <param name="objPrjTabENEx"></param>
        /// <returns></returns>
        public static string Gen_WApi_Ts_GetFuncAddiPara(clsPrjTabENEx objPrjTabENEx)
        {
            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.ObjCacheClassifyFld_TS != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.ObjCacheClassifyFld_TS.FldName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + ", {0}Classfy: {1}",
                     objPrjTabENEx.ObjCacheClassifyFld_TS.PrivFuncName, objPrjTabENEx.ObjCacheClassifyFld_TS.TypeScriptType);

            }
            if (objPrjTabENEx.ObjCacheClassifyFld2_TS != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.ObjCacheClassifyFld2_TS.FldName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + ", {0}Classfy: {1}",
                     objPrjTabENEx.ObjCacheClassifyFld2_TS.PrivFuncName, objPrjTabENEx.ObjCacheClassifyFld2_TS.TypeScriptType);
            }
            return strCodeForCs.ToString();
        }

        public static string Gen_4BL_GetFuncAddiPara(clsPrjTabENEx objPrjTabENEx)
        {
            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.objCacheClassifyFld != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.objCacheClassifyFld.FldName) == false)
            {
                strCodeForCs.AppendFormat(", {1} {0}",
                     objPrjTabENEx.objCacheClassifyFld.PrivFuncName, objPrjTabENEx.objCacheClassifyFld.CsType);

            }
            if (objPrjTabENEx.objCacheClassifyFld2 != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.objCacheClassifyFld2.FldName) == false)
            {
                strCodeForCs.AppendFormat(", {1} {0}",
                     objPrjTabENEx.objCacheClassifyFld2.PrivFuncName, objPrjTabENEx.objCacheClassifyFld2.CsType);
            }
            return strCodeForCs.ToString();
        }

        public static MyResult ChkWhereFormatBack(clsPrjTabENEx objPrjTabENEx)
        {

            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objPrjTabENEx.TabId, objPrjTabENEx.objCacheClassifyFld.FldId, objPrjTabENEx.PrjId);
                if (objPrjTabFld.IsForExtendClass == true && string.IsNullOrEmpty(objPrjTabENEx.WhereFormatBack) == true)
                {
                    string strMsg = string.Format($"当前表:[{objPrjTabENEx.TabName}]有后台缓存分类字段：[{objPrjTabENEx.objCacheClassifyFld.FldName}],属于扩展类字段,但后台条件格式为空,不正确!");
                    return new MyResult(false, strMsg);
                }

            }
            return new MyResult(true, "");
        }


        public static string Gen_4BL_GetFuncAddiParaVar(clsPrjTabENEx objPrjTabENEx)
        {
            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.objCacheClassifyFld != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.objCacheClassifyFld.FldName) == false)
            {
                strCodeForCs.AppendFormat(", {0}",
                     objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            if (objPrjTabENEx.objCacheClassifyFld2 != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.objCacheClassifyFld2.FldName) == false)
            {
                strCodeForCs.AppendFormat(", {0}",
                     objPrjTabENEx.objCacheClassifyFld2.PrivFuncName);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 获取函数名的附加参数
        /// </summary>
        /// <param name="objPrjTabENEx"></param>
        /// <returns></returns>
        public static string Gen_WApi_Ts_GetFuncAddiParam(clsPrjTabENEx objPrjTabENEx)
        {
            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.ObjCacheClassifyFld_TS != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.ObjCacheClassifyFld_TS.FldName) == false)
            {
                strCodeForCs.AppendFormat("\r\n @param {0}:缓存的分类字段", objPrjTabENEx.ObjCacheClassifyFld_TS.PrivFuncName);
            }
            if (objPrjTabENEx.ObjCacheClassifyFld2_TS != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.ObjCacheClassifyFld_TS.FldName) == false)
            {
                strCodeForCs.AppendFormat("\r\n @param {0}:缓存的分类字段", objPrjTabENEx.ObjCacheClassifyFld2_TS.PrivFuncName);
            }
            return strCodeForCs.ToString();
        }

        public static string Gen_4BL_GetFuncAddiParam(clsPrjTabENEx objPrjTabENEx)
        {
            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.objCacheClassifyFld != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.objCacheClassifyFld.FldName) == false)
            {

                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">缓存的分类字段</param>", objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            if (objPrjTabENEx.objCacheClassifyFld2 != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.objCacheClassifyFld2.FldName) == false)
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">缓存的分类字段</param>", objPrjTabENEx.objCacheClassifyFld2.PrivFuncName);
            }
            return strCodeForCs.ToString();
        }
        public static bool IsPrjmaryKeyFldNameContainsCacheFldName(clsPrjTabENEx objPrjTabENEx, string strFldName)
        {
            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            if (arrPrjmaryKeyFldName.Contains(strFldName) == false)
            {
                return false;
            }
            return true;
        }

        public static bool IsPrjmaryKeyFldNameContainsCache1FldName(clsPrjTabENEx objPrjTabENEx)
        {
            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            if (objPrjTabENEx.objCacheClassifyFld != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.objCacheClassifyFld.FldName) == false)
            {
                return false;
            }
            return true;
        }

        public static bool IsPrjmaryKeyFldNameContainsCache2FldName(clsPrjTabENEx objPrjTabENEx)
        {
            List<string> arrPrjmaryKeyFldName = new List<string>();
            arrPrjmaryKeyFldName = objPrjTabENEx.arrKeyFldSet.Select(x => x.FldName).ToList();

            if (objPrjTabENEx.objCacheClassifyFld2 != null && arrPrjmaryKeyFldName.Contains(objPrjTabENEx.objCacheClassifyFld2.FldName) == false)
            {
                return false;
            }
            return true;
        }

        public static void Gen_WApi_Ts_ControlProperty(StringBuilder strCodeForCs, List<clsPropertyDef4GC> arrPropertyDef4GC, string strDivName, IImportClass objImportClass, string strBaseUrl)
        {
            var arrNoAccess = new List<string> { "sessionStorage", "CacheClassifyField", "DefaultValue" };
            var arrPropertyDef4GC2 = arrPropertyDef4GC
                .Where(x => arrNoAccess.Contains(x.ControlType) == false)
                .OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.ParentDivName) == true)
                {
                    Gen_WApi_Ts_ControlProperty4One_NotInDiv(strCodeForCs, x, objImportClass, strBaseUrl);
                    return;
                }
                if (string.IsNullOrEmpty(x.ParentDivName) == false) strDivName = x.ParentDivName;
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                string strIsStatic = "";
                if (x.IsStatic) strIsStatic = "static";
                switch (x.OperateType)
                {
                    case "get":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                //strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);

                                //strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                //strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                //strCodeForCs.Append("\r\n" + "return objDiv.find(strId).prop(\"checked\");");

                                strCodeForCs.AppendFormat("\r\n" + "const bolValue = GetCheckBoxValueInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckBoxValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                strCodeForCs.Append("\r\n" + "return bolValue;");
                                break;
                            case "input":
                            case "TextBox":

                                if (x.DataType == "number")
                                {

                                    strCodeForCs.AppendFormat("\r\n" + "const strValue = GetInputValueInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return 0;");
                                    strCodeForCs.AppendFormat("\r\n" + "else if (IsNullOrEmpty(strValue) == true) return 0;");
                                    objImportClass.AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                                    objImportClass.AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                                    strCodeForCs.AppendFormat("\r\n" + "else return Number(strValue);");

                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const strValue = GetInputValueInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                    objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetInputValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                    strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "else return strValue.toString();");
                                }
                                break;
                            case "TextArea":

                                strCodeForCs.AppendFormat("\r\n" + "const strValue = GetTextAreaValueInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetTextAreaValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return \"\";");
                                strCodeForCs.AppendFormat("\r\n" + "else return strValue.toString();");

                                break;

                            case "button":
                                //strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);

                                //strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                //strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                //strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                strCodeForCs.AppendFormat("\r\n" + "const strValue = GetButtonHtmlInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetButtonHtmlInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                strCodeForCs.Append("\r\n" + "return strValue;");
                                break;
                            case "label":
                                //strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);
                                //strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);
                                //strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                //strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                strCodeForCs.AppendFormat("\r\n" + "const strValue = GetLabelHtmlInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetLabelHtmlInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                strCodeForCs.Append("\r\n" + "return strValue;");
                                break;
                            case "dropdownlist":
                            case "DropDownList":

                                switch (x.DataType)
                                {
                                    case "boolean":
                                        //strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);

                                        //strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                        //strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);
                                        ////                                strCodeForCs.AppendFormat("\r\n" + "const objElem: JQuery <HTMLElement> = objDiv.find(strId);");
                                        //strCodeForCs.AppendFormat("\r\n" + "const objElem = objDiv.find(strId);");
                                        //strCodeForCs.AppendFormat("\r\n" + "if (objElem == undefined) return false;");
                                        //strCodeForCs.AppendFormat("\r\n" + "else");
                                        //strCodeForCs.Append("\r\n" + "{");
                                        //strCodeForCs.AppendFormat("\r\n" + "const strValue = objElem.val();");
                                        //strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return false;");
                                        //strCodeForCs.AppendFormat("\r\n" + "else return strValue;");

                                        strCodeForCs.AppendFormat("\r\n" + "const strValue = GetSelectValueInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                        objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                        strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return false;");
                                        //strCodeForCs.AppendFormat("\r\n" + "else if (strValue == \"0\") return 0;");
                                        strCodeForCs.AppendFormat("\r\n" + "else return Boolean(strValue);");
                                        //strCodeForCs.Append("\r\n" + "}");
                                        break;
                                    case "number":

                                        strCodeForCs.AppendFormat("\r\n" + "const strValue = GetSelectValueInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                        objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                        strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return 0;");
                                        strCodeForCs.AppendFormat("\r\n" + "else if (strValue == \"0\") return 0;");
                                        strCodeForCs.AppendFormat("\r\n" + "else return Number(strValue);");

                                        //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "const strValue = GetSelectValueInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                        objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                        strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return \"\";");
                                        strCodeForCs.AppendFormat("\r\n" + "else if (strValue == \"0\") return \"\";");
                                        strCodeForCs.AppendFormat("\r\n" + "else return strValue;");

                                        break;
                                }



                                //strCodeForCs.AppendFormat("\r\n" + "return objDiv.find(strId).val();", x.CtrlId);
                                break;
                            case "DropDownList_Bool":

                                switch (x.DataType)
                                {
                                    case "boolean":
                                        strCodeForCs.AppendFormat("\r\n" + "const {1} = GetSelectObjInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                        objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectObjInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.selectedIndex == 1) return true;", x.CtrlId);
                                        strCodeForCs.AppendFormat("\r\n" + "else return false;");
                                        break;
                                    case "number":

                                        strCodeForCs.AppendFormat("\r\n" + "const strValue = GetSelectValueInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);

                                        objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                        strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return 0;");
                                        strCodeForCs.AppendFormat("\r\n" + "else if (strValue == \"0\") return 0;");
                                        strCodeForCs.AppendFormat("\r\n" + "else return Number(strValue);");

                                        //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "const strValue = GetSelectValueInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                        objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                        strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return \"\";");
                                        strCodeForCs.AppendFormat("\r\n" + "else if (strValue == \"0\") return \"\";");
                                        strCodeForCs.AppendFormat("\r\n" + "else return strValue;");

                                        break;
                                }



                                //strCodeForCs.AppendFormat("\r\n" + "return objDiv.find(strId).val();", x.CtrlId);
                                break;

                            case "ViewVariable":

                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "CacheClassifyFieldTS":

                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "GivenValue":
                                strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);

                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return Number(strValue);");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return strValue;");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return 0;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return \"\";");
                                }
                                break;
                            case "CacheClassifyField":
                                break;
                            case "DefaultValue":
                                break;

                            default:
                                strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                        }
                        break;
                    case "set":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);


                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + " SetCheckBoxValueByIdInDivObj({0}, \"{1}\", value);", x.ParentDivName, x.CtrlId);
                                //IImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckBoxValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);
                                objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckBoxValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                break;
                            case "input":
                            case "TextBox":
                                //strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);
                                //strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);
                                //strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                //strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                if (x.DataType == "boolean" || x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " SetInputValueInDivObj({0}, \"{1}\", value !== null ? value.toString() : '');", x.ParentDivName, x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " SetInputValueInDivObj({0}, \"{1}\", value);", x.ParentDivName, x.CtrlId);
                                }
                                objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetInputValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                break;
                            case "TextArea":
                                strCodeForCs.AppendFormat("\r\n" + " SetTextAreaValueInDivObj({0}, \"{1}\", value);", x.ParentDivName, x.CtrlId);
                                objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetTextAreaValueInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                break;
                            case "button":
                                //strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                //strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                //strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + " SetButtonHtmlByIdInDivObj({0}, \"{1}\", value);", x.ParentDivName, x.CtrlId);
                                //objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetButtonHtmlByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);
                                if (x.ThisClsName.IndexOf("_Detail") >= 0)
                                {
                                    strCodeForCs.Append("\r\n" + $"ref{x.ThisClsName}.value.{x.RefVarName} = value;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + $"ref{x.ThisClsName}.value.{x.RefVarName} = value;");
                                }
                                break;
                            case "label":
                                //strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);
                                //strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                //strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                //strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                strCodeForCs.AppendFormat("\r\n" + " SetLabelHtmlByIdInDivObj({0}, \"{1}\", value);", x.ParentDivName, x.CtrlId);
                                objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetLabelHtmlByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                break;
                            case "Label":
                                //strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);
                                //strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                //strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                if (x.DataType == "boolean" || x.DataType == "number")
                                {
                                    //strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value !== null ? value.toString() : '');");
                                    strCodeForCs.AppendFormat("\r\n" + " SetLabelHtmlByIdInDivObj({0}, \"{1}\", value !== null ? value.toString() : '');", x.ParentDivName, x.CtrlId);

                                }
                                else
                                {
                                    //strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                    strCodeForCs.AppendFormat("\r\n" + " SetLabelHtmlByIdInDivObj({0}, \"{1}\", value);", x.ParentDivName, x.CtrlId);

                                }
                                objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetLabelHtmlByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                //strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);
                                //strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                //strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);
                                if (x.DataType == "boolean" || x.DataType == "number")
                                {
                                    //strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value !== null ? value.toString() : '');");
                                    strCodeForCs.AppendFormat("\r\n" + "SetSelectValueByIdInDivObj({0}, \"{1}\", value !== null ? value.toString() : '');", strDivName, x.CtrlId);
                                    objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetSelectValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "SetSelectValueByIdInDivObj({0}, \"{1}\", value);", strDivName, x.CtrlId);
                                    objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetSelectValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                    //strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                }
                                break;
                            case "DropDownList_Bool":
                                if (x.DataType == "boolean")
                                {
                                    //strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value !== null ? value.toString() : '');");
                                    strCodeForCs.AppendFormat("\r\n" + "//SetSelectValueByIdInDivObj({0}, \"{1}\", value !== null ? value.toString() : '');", strDivName, x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = GetSelectObjInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + "if (value == true) {1}.selectedIndex = 1;", strDivName, x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + "else {1}.selectedIndex = 2;", strDivName, x.CtrlId);
                                }
                                else if (x.DataType == "number")
                                {
                                    //strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value !== null ? value.toString() : '');");
                                    strCodeForCs.AppendFormat("\r\n" + "//SetSelectValueByIdInDivObj({0}, \"{1}\", value !== null ? value.toString() : '');", strDivName, x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = GetSelectObjInDivObj({0}, \"{1}\");", strDivName, x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + "if (value == true) {1}.selectedIndex = 1;", strDivName, x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + "else {1}.selectedIndex = 2;", strDivName, x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "SetSelectValueByIdInDivObj({0}, \"{1}\", value);", strDivName, x.CtrlId);
                                    objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetSelectValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                    //strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                }
                                break;

                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value !== null ? value.toString() : '');");
                                break;
                            case "CacheClassifyFieldTS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value !== null ? value.toString() : '');");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                }
                                break;
                            case "CacheClassifyField":
                                break;
                            case "DefaultValue":
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);
                                if (x.DataType == "boolean" || x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value !== null ? value.toString() : '');", x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                }
                                break;
                        }
                        break;
                }
                strCodeForCs.Append("\r\n" + "}");
            });
        }

        public static void Gen_Vue_Ts_ControlPropertyBak(StringBuilder strCodeForCs, List<clsPropertyDef4GC> arrPropertyDef4GC, IImportClass objImportClass, string strBaseUrl)
        {
            var arrPropertyDef4GC2 = arrPropertyDef4GC.OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.ParentDivName) == true)
                {
                    Gen_WApi_Ts_ControlProperty4One_NotInDiv(strCodeForCs, x, objImportClass, strBaseUrl);
                    return;
                }

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                string strIsStatic = "";
                if (x.IsStatic) strIsStatic = "static";
                switch (x.OperateType)
                {
                    case "get":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);

                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + "return objDiv.find(strId).prop(\"checked\");");
                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);

                                if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const objElem: JQuery <HTMLElement> = objDiv.find(strId);");
                                    strCodeForCs.AppendFormat("\r\n" + "if (objElem == undefined) return 0;");
                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strValue = objElem.val();");
                                    strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return 0;");
                                    strCodeForCs.AppendFormat("\r\n" + "else return Number(strValue.toString());");
                                    strCodeForCs.Append("\r\n" + "}");

                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const objElem: JQuery <HTMLElement> = objDiv.find(strId);");
                                    strCodeForCs.AppendFormat("\r\n" + "if (objElem == undefined) return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strValue = objElem.val();");
                                    strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "else return strValue.toString();");
                                    strCodeForCs.Append("\r\n" + "}");
                                    //strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                    //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                }
                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "label":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "const objElem: JQuery <HTMLElement> = objDiv.find(strId);");

                                if (x.DataType == "boolean")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (objElem == undefined) return false;");
                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strValue = objElem.val();");
                                    strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return false;");
                                    strCodeForCs.AppendFormat("\r\n" + "else return strValue;");


                                    //strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return false;", x.CtrlId);
                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                                }
                                else if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (objElem == undefined) return 0;");
                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strValue = objElem.val();");
                                    strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return 0;");
                                    strCodeForCs.AppendFormat("\r\n" + "else if (strValue == \"0\") return 0;");
                                    strCodeForCs.AppendFormat("\r\n" + "else return Number(strValue);");

                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (objElem == undefined) return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strValue = objElem.val();");
                                    strCodeForCs.AppendFormat("\r\n" + "if (strValue == undefined) return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "else if (strValue == \"0\") return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "else return strValue.toString();");
                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                                }

                                strCodeForCs.Append("\r\n" + "}");

                                //strCodeForCs.AppendFormat("\r\n" + "return objDiv.find(strId).val();", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "CacheClassifyFieldTS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return Number(strValue);");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return strValue;");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return 0;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return \"\";");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                        }
                        break;
                    case "set":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);


                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).attr(\"checked\", value !== null ? value.toString() : '');");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "label":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "Label":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value !== null ? value.toString() : '');");
                                break;
                            case "CacheClassifyFieldTS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value !== null ? value.toString() : '');");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                        }
                        break;
                }
                strCodeForCs.Append("\r\n" + "}");
            });
        }

        /// <summary>
        /// 生成与
        /// </summary>
        /// <param name="strVarName"></param>
        /// <param name="strTypeScriptType"></param>
        /// <param name="strDataTypeId"></param>
        /// <param name="strClassName"></param>
        /// <param name="strFuncName"></param>
        /// <param name="intFldLen"></param>
        /// <param name="bolIsCheckLength"></param>
        /// <param name="objImportClass"></param>
        /// <param name="strBaseUrl"></param>
        /// <returns></returns>
        public static string Gc_CheckVarEmpty_Ts(string strVarName, string strTypeScriptType, string strDataTypeId, string strClassName, string strFuncName, int intFldLen, bool bolIsCheckLength, IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder sbCheckEmpty = new StringBuilder();
            if (strTypeScriptType == "number")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if ({0} == 0)", strVarName);
                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = Format(\"参数:[{0}]不能为空!(In {1}.{2})\");",
                    strVarName, strClassName, strFuncName);
                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
            }
            else if (strTypeScriptType == "string")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", strVarName);
                objImportClass.AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = Format(\"参数:[{0}]不能为空!(In {1}.{2})\");",
                    strVarName, strClassName, strFuncName);
                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
                if (bolIsCheckLength == true && strDataTypeId == enumDataTypeAbbr.char_04)
                {
                    sbCheckEmpty.AppendFormat("\r\n" + "if ({0}.length != {1})", strVarName, intFldLen);
                    sbCheckEmpty.Append("\r\n" + "{");
                    sbCheckEmpty.AppendFormat("\r\n" + "const strMsg = Format(\"缓存分类变量:[{0}]的长度:[{{0}}]不正确!({1}.{2})\", {0}.length);",
                        strVarName, strClassName, strFuncName);
                    sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                    sbCheckEmpty.Append("\r\n" + "throw (strMsg);");
                    sbCheckEmpty.Append("\r\n" + "}");
                }
            }
            return sbCheckEmpty.ToString();
        }

        public static string Gc_IfVarNotEmpty_Ts(List<clsPrjTabFldENEx> arrKeyFldSet, IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder sbCheckEmpty = new StringBuilder();
            sbCheckEmpty.Append("\r\n" + "if (");
            foreach (var objKeyFld in arrKeyFldSet)
            {
                if (objKeyFld.TypeScriptType == "number")
                {
                    sbCheckEmpty.AppendFormat("\r\n" + "{0} != 0 &&", objKeyFld.PrivFuncName);
                }
                else if (objKeyFld.TypeScriptType == "string")
                {
                    sbCheckEmpty.AppendFormat("\r\n" + "IsNullOrEmpty({0}) == false &&", objKeyFld.PrivFuncName);
                    objImportClass.AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);
                }
            }
            sbCheckEmpty = sbCheckEmpty.Remove(sbCheckEmpty.Length - 2, 2);
            sbCheckEmpty.Append(")");
            return sbCheckEmpty.ToString();
        }

        public static List<string> Gc_GetPrivaryVarNameLst(List<clsPrjTabFldENEx> arrKeyFldSet)
        {
            List<string> arrLst = new List<string>();

            foreach (var objKeyFld in arrKeyFldSet)
            {
                arrLst.Add(objKeyFld.PrivFuncName);
            }
            return arrLst;
        }


        public static string Gc_CheckVarEmpty_Cs(string strVarName, string strCsType, string strDataTypeId, int intFldLen, bool bolIsCheckLength, IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder sbCheckEmpty = new StringBuilder();

            if (strCsType == "string")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strVarName);

                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  var strMsg = string.Format(\"参数:[{0}]不能为空!(In {{0}})\", clsStackTrace.GetCurrClassFunction());",
                    strVarName);


                sbCheckEmpty.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw new Exception (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
                if (bolIsCheckLength == true && strDataTypeId == enumDataTypeAbbr.char_04)
                {
                    sbCheckEmpty.AppendFormat("\r\n" + "if ({0}.Length != {1})", strVarName, intFldLen);
                    sbCheckEmpty.Append("\r\n" + "{");
                    sbCheckEmpty.AppendFormat("\r\n" + "var strMsg = string.Format(\"缓存分类变量:[{0}]的长度:[{{0}}]不正确!(In {{1}})\", {0}.Length, clsStackTrace.GetCurrClassFunction());", strVarName);
                    sbCheckEmpty.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
                    sbCheckEmpty.Append("\r\n" + " throw new Exception (strMsg);");
                    sbCheckEmpty.Append("\r\n" + "}");
                }
            }
            else
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if ({0} == 0)", strVarName);
                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  var strMsg = string.Format(\"参数:[{0}]不能为空!(In {{0}})\", clsStackTrace.GetCurrClassFunction());",
                            strVarName);

                sbCheckEmpty.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw new Exception (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");

            }
            return sbCheckEmpty.ToString();
        }
        public static string GetFuncParaDef4CacheClassfy(clsGeneCodeBase4Tab objGeneCodeBase4Tab, bool bolIsFrontend, string strProgLangTypeId)
        {
            var objFuncParaLst = new FuncParaLst("ReFreshThisCache", objGeneCodeBase4Tab.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            if (bolIsFrontend == true)
            {
                
                objFuncParaLst.AddParaByCacheClassify(objGeneCodeBase4Tab.thisCacheClassify_TS, arrCondFldId, strProgLangTypeId);
            }
            else
            {                
                objFuncParaLst.AddParaByCacheClassify(objGeneCodeBase4Tab.thisCacheClassify, arrCondFldId, strProgLangTypeId);
            }
            //objFuncParaLst.AddParaByCacheClassify(objGeneCodeBase4Tab.thisCacheClassify, arrCondFldId, enumProgLangType.CSharp_01);
            string strCode = objFuncParaLst.Gc_FuncParaDef(strProgLangTypeId);
            return strCode;
            //string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            //string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Cs(objGeneCodeBase4Tab.ThisClsName, strFuncName, true);


        }

        public static string Gc_CheckVarEmpty4CacheClassfy(clsGeneCodeBase4Tab objGeneCodeBase4Tab, bool bolIsFrontend, string strProgLangTypeId, string ThisClsName, string strFuncName, IImportClass objImportClass=null, string strBaseUrl="")
        {
            var objFuncParaLst = new FuncParaLst("ReFreshThisCache", objGeneCodeBase4Tab.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            if (bolIsFrontend == true)
            {

                objFuncParaLst.AddParaByCacheClassify(objGeneCodeBase4Tab.thisCacheClassify_TS, arrCondFldId, strProgLangTypeId);
            }
            else
            {
                objFuncParaLst.AddParaByCacheClassify(objGeneCodeBase4Tab.thisCacheClassify, arrCondFldId, strProgLangTypeId);
            }
            //objFuncParaLst.AddParaByCacheClassify(objGeneCodeBase4Tab.thisCacheClassify, arrCondFldId, enumProgLangType.CSharp_01);
            //string strCode = objFuncParaLst.Gc_FuncParaDef(strProgLangTypeId);
            string strCheckEmptyCode = "";
            switch (strProgLangTypeId)
            {
                case enumProgLangType.CSharp_01:
                    strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Cs(ThisClsName, strFuncName, true);
                    break;
                case enumProgLangType.TypeScript_09:
                    strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(ThisClsName, strFuncName, true, objImportClass, strBaseUrl);
                    break;
                default:
                    var objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
                    string strMsg = string.Format("在定义函数参数过程中，语言:{0}没有处理！", objProgLangType.ProgLangTypeName);
                    throw new Exception(strMsg);
            }
            return strCheckEmptyCode;
        }


        /// <summary>
        /// 生成系统中共用的一些校验函数,例如
        /// 判断字符串是否是数值型
        /// 判断字符串是否是浮点型
        /// 判断字符串是否是日期型
        /// </summary>
        /// <returns></returns>
        public static string GenIsNumeric()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 判断是否是整型数值");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name = \"strValue\">需要判断的字符串</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>True/False</returns>");
            strCodeForCs.Append("\r\n" + "public bool IsNumeric(string strValue)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "int intLen = strValue.Length;");
            strCodeForCs.Append("\r\n" + "for(int i = 0; i<intLen; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (char.IsDigit(strValue, i)  ==  false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public static string GenIsDigit()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 判断是否是数字");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name = \"strValue\">需要判断的字符串</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>True/False</returns>");
            strCodeForCs.Append("\r\n" + "public bool IsDigit(string strValue)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "int intLen = strValue.Length;");
            strCodeForCs.Append("\r\n" + "for(int i = 0; i<intLen; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (char.IsDigit(strValue, i)  ==  false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public static string GenIsFloat()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 判断是否是浮点型数值");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name = \"strValue\">需要判断的字符串</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>True/False</returns>");
            strCodeForCs.Append("\r\n" + "public bool IsFloat(string strValue)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "int intPointNum = 0;");
            strCodeForCs.Append("\r\n" + "char [] arrChar = strValue.ToCharArray();");
            strCodeForCs.Append("\r\n" + "int intLen = strValue.Length;");
            strCodeForCs.Append("\r\n" + "for(int i = 0; i<intLen; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (char.IsDigit(strValue, i)  ==  true || arrChar[i]  ==  '.')");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (arrChar[i]  ==  '.') intPointNum++;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//检查总共有几个小数点,如果有多于1个小数点,就不正确");
            strCodeForCs.Append("\r\n" + "if (intPointNum>1) return false;");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public static string GenIsDate()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 判断给定字符串是否是日期型数据");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name = \"strValue\">需要判断的字符串</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>True/False</returns>");
            strCodeForCs.Append("\r\n" + "public bool IsDate(string strValue)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strDate = \"\";");
            strCodeForCs.Append("\r\n" + "if (strValue  ==  \"\") return true;");
            strCodeForCs.Append("\r\n" + "if (strValue.Length <8) ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (strValue.Length  ==  8)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strDate = strValue.Substring(0,4) + \"-\" + strValue.Substring(4,2) + \"-\" + strValue.Substring(6,2);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "strDate = strValue;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "DateTime dt = DateTime.Parse(strDate);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception expt)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public static string GenGetTodayStr()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 功能:获取当前日期的字符串");
            strCodeForCs.Append("\r\n" + "/// 日期格式:");
            strCodeForCs.Append("\r\n" + "///    日期的字符串的格式有三种:");
            strCodeForCs.Append("\r\n" + "///		1、YYYYMMDD。	例如20050120");
            strCodeForCs.Append("\r\n" + "///		2、YYYY-MM-DD	例如2005-01-20");
            strCodeForCs.Append("\r\n" + "///		3、YYYY/MM/DD	例如2005/01/20");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name = \"intFormat\">日期格式,共有3种,传入参数0,1,2");
            strCodeForCs.Append("\r\n" + "///							参数不同,函数返回值就不同,");
            strCodeForCs.Append("\r\n" + "///							参见上面的日期格式");
            strCodeForCs.Append("\r\n" + "///	</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>返回当前日期的字符串</returns>");
            strCodeForCs.Append("\r\n" + "public string getTodayStr(int intFormat)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strToday;");
            strCodeForCs.Append("\r\n" + "string strYear, strMonth, strDay;");
            strCodeForCs.Append("\r\n" + "int intYear, intMonth, intDay;");
            strCodeForCs.Append("\r\n" + "intYear = System.DateTime.Today.Year;");
            strCodeForCs.Append("\r\n" + "intMonth = System.DateTime.Today.Month;");
            strCodeForCs.Append("\r\n" + "intDay = System.DateTime.Today.Day;");
            strCodeForCs.Append("\r\n" + "strYear = intYear.ToString().Trim();");
            strCodeForCs.Append("\r\n" + "if (intMonth>9) strMonth = intMonth.ToString().Trim();");
            strCodeForCs.Append("\r\n" + "else strMonth = \"0\" + intMonth.ToString().Trim();");
            strCodeForCs.Append("\r\n" + "if (intDay>9) strDay = intDay.ToString().Trim();");
            strCodeForCs.Append("\r\n" + "else strDay = \"0\" + intDay.ToString().Trim();");
            strCodeForCs.Append("\r\n" + "strToday = strYear + strMonth + strDay;");
            strCodeForCs.Append("\r\n" + "switch(intFormat)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case 0:");
            strCodeForCs.Append("\r\n" + "strToday = strYear + strMonth + strDay;");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 1:");
            strCodeForCs.Append("\r\n" + "strToday = strYear + \"-\" + strMonth + \"-\" + strDay;");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 2:");
            strCodeForCs.Append("\r\n" + "strToday = strYear + \"/\" + strMonth + \"/\" + strDay;");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return strToday;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public static string GenGetCurrMonth()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 功能:获取当前月的字符串");
            strCodeForCs.Append("\r\n" + "/// 月的格式:");
            strCodeForCs.Append("\r\n" + "///    月的字符串的格式有三种:");
            strCodeForCs.Append("\r\n" + "///		1、YYYYMM。	例如200501");
            strCodeForCs.Append("\r\n" + "///		2、YYYY-MM-DD	例如2005-01");
            strCodeForCs.Append("\r\n" + "///		3、YYYY/MM/DD	例如2005/01");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name = \"intFormat\">月的格式,共有3种,传入参数0,1,2");
            strCodeForCs.Append("\r\n" + "///							参数不同,函数返回值就不同,");
            strCodeForCs.Append("\r\n" + "///							参见上面的月的格式");
            strCodeForCs.Append("\r\n" + "///	</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>返回当前月的字符串</returns>");
            strCodeForCs.Append("\r\n" + "public string getCurrMonth(int intFormat)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strCurrMonth;");
            strCodeForCs.Append("\r\n" + "string strYear, strMonth;");
            strCodeForCs.Append("\r\n" + "int intYear, intMonth;");
            strCodeForCs.Append("\r\n" + "intYear = System.DateTime.Today.Year;");
            strCodeForCs.Append("\r\n" + "intMonth = System.DateTime.Today.Month;");
            strCodeForCs.Append("\r\n" + "strYear = intYear.ToString().Trim();");
            strCodeForCs.Append("\r\n" + "if (intMonth>9) strMonth = intMonth.ToString().Trim();");
            strCodeForCs.Append("\r\n" + "else strMonth = \"0\" + intMonth.ToString().Trim();");
            strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + strMonth;");
            strCodeForCs.Append("\r\n" + "switch(intFormat)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case 0:");
            strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + strMonth;");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 1:");
            strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + \"-\" + strMonth;");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 2:");
            strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + \"/\" + strMonth;");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return strCurrMonth;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public static string GenUserInfoAndDate4Projects(string strCurrUserName, clsProjectsEN objProjectsEN, string strCmPrjId,
            string strClassName, clsPubConst.LangType ltLangType)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objProjectsEN.PrjName, objProjectsEN.PrjId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);

            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");

            strCodeForCs.AppendFormat("\r\n 工程域名:{0}", objProjectsEN.PrjDomain);
            strCodeForCs.AppendFormat("\r\n 语言类型:{0}", clsPubConst.GetLangTypeStringByLangType(ltLangType));

            strCodeForCs.AppendFormat("\r\n 注意:1、需要数据底层(PubDataBase.dll)的版本:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n      2、需要公共函数层(TzPubFunction.dll)的版本:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }
        public static string GenUserInfoAndDate(string strCurrUserName, clsPrjTabENEx objPrjTabENEx, string strCmPrjId)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " 类名:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " 表名:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);

            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n 生成服务器IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            if (string.IsNullOrEmpty(objCMProject.FunctionTemplateId) == true)
            {
                string strMsg = $"Cm项目:{objCMProject.CmPrjName}({objCMProject.CmPrjId})函数模板为空，请检查！";
                throw new Exception(strMsg);
            }
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);

            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");

            if (string.IsNullOrEmpty(objPrjTabENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objPrjTabENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n 相关数据库:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n 模块中文名:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n 框架-层名:{0}({1},{2})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName, objCodeTypeEN.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n 编程语言:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));
            strCodeForCs.AppendFormat("\r\n 注意:1、需要数据底层(PubDataBase.dll)的版本:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n        2、需要公共函数层(TzPubFunction.dll)的版本:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate4PureClass(string strCurrUserName, clsPrjTabENEx objPrjTabENEx, string strCmPrjId)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " 类名:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " 表名:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);

            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n 生成服务器IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);

            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");

            strCodeForCs.AppendFormat("\r\n 模块中文名:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());

            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n 框架-层名:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);
            strCodeForCs.AppendFormat("\r\n 编程语言:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));
            strCodeForCs.AppendFormat("\r\n 注意:1、需要公共函数层(TzPubFunction.dll)的版本:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }


        public static string GenUserInfoAndDate4TypeScript(string strCurrUserName, clsPrjTabENEx objPrjTabENEx, string strCmPrjId)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            var objAppType = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(objPrjTabENEx.ApplicationTypeId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /**");
            strCodeForCs.AppendFormat("\r\n" + " * 类名:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " * 表名:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);

            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n * 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n * 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n * 生成服务器IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n 应用类型:{0}({1})", objAppType.ApplicationTypeName, objAppType.ApplicationTypeId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);

            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");

            if (string.IsNullOrEmpty(objPrjTabENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objPrjTabENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n * 相关数据库:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n * PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n 模块中文名:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId);

            strCodeForCs.AppendFormat("\r\n * 框架-层名:{0}({1},{2})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName, objCodeTypeEN.CodeTypeId);

            strCodeForCs.AppendFormat("\r\n * 编程语言:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));
            strCodeForCs.AppendFormat("\r\n * 注意:1、需要数据底层(PubDataBase.dll)的版本:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n   *      2、需要公共函数层(TzPubFunction.dll)的版本:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate4Java(string strCurrUserName, clsPrjTabENEx objPrjTabENEx, string strCmPrjId)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * -- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + "* 类名:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "*  表名:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);
            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n * 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n * 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n * 生成服务器IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);


            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");

            if (string.IsNullOrEmpty(objPrjTabENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objPrjTabENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n 相关数据库:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n * 模块中文名:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
            strCodeForCs.AppendFormat("\r\n * 框架-层名:{0}-{1}", objPrjTabENEx.CodeTypeId,
                clsCodeTypeBL.GetNameByCodeTypeIdCache(objPrjTabENEx.CodeTypeId));
            strCodeForCs.AppendFormat("\r\n * 编程语言:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));
            strCodeForCs.AppendFormat("\r\n * 注意:1、需要数据底层(PubDataBase.dll)的版本:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n * 2、需要公共函数层(TzPubFunction.dll)的版本:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n * == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate(string strCurrUserName, clsWebSrvClassENEx objWebSrvClassENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(objWebSrvClassENEx.CmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " 类名:{0}", objWebSrvClassENEx.ClsName);
            //strCodeForCs.AppendFormat("\r\n" + " 表名:{0}", objWebSrvClassENEx.TabName);
            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n 生成服务器IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objWebSrvClassENEx.objProjectsEN.PrjName, objWebSrvClassENEx.PrjId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);

            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");

            if (string.IsNullOrEmpty(objWebSrvClassENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objWebSrvClassENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n 相关数据库:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n 模块中文名:{0}({1})", objWebSrvClassENEx.ObjFuncModule.FuncModuleName, objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC());
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objWebSrvClassENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n 框架-层名:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);

            strCodeForCs.AppendFormat("\r\n 编程语言:{0}", clsPubConst.GetLangTypeStringByLangType(objWebSrvClassENEx.LangType));
            strCodeForCs.AppendFormat("\r\n 注意:1、需要数据底层(PubDataBase.dll)的版本:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n        2、需要公共函数层(TzPubFunction.dll)的版本:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate(string strCurrUserName, clsViewInfoENEx objViewInfoENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(objViewInfoENEx.PrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " 类名:{0}", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " 界面名:{0}({1})", objViewInfoENEx.ViewName, objViewInfoENEx.ViewId);

            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objViewInfoENEx.objProjectsEN.PrjName, objViewInfoENEx.PrjId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);


            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");


            if (string.IsNullOrEmpty(objViewInfoENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objViewInfoENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n 相关数据库:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n 模块中文名:{0}({1})", objViewInfoENEx.ObjFuncModule.FuncModuleName, objViewInfoENEx.ObjFuncModule.FuncModuleEnName4GC());
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n 框架-层名:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);

            strCodeForCs.AppendFormat("\r\n 编程语言:{0}", clsPubConst.GetLangTypeStringByLangType(objViewInfoENEx.LangType));

            strCodeForCs.AppendFormat("\r\n 注意:1、需要数据底层(PubDataBase.dll)的版本:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n      2、需要公共函数层(TzPubFunction.dll)的版本:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate4WebApi(string strCurrUserName, clsViewInfoENEx objViewInfoENEx, string strCmPrjId)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.AppendFormat("\r\n" + " * 类名:{0}(界面:{1},{2})",
                objViewInfoENEx.ClsName, objViewInfoENEx.ViewName, objViewInfoENEx.ViewId);
            strCodeForCs.AppendFormat("\r\n" + " * 表名:{0}({1})", objViewInfoENEx.TabName, objViewInfoENEx.MainTabId);

            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n * 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n * 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objViewInfoENEx.objProjectsEN.PrjName, objViewInfoENEx.PrjId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);

            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");

            if (string.IsNullOrEmpty(objViewInfoENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objViewInfoENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n * 相关数据库:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n * PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n * 模块中文名:{0}({1})", objViewInfoENEx.ObjFuncModule.FuncModuleName, objViewInfoENEx.ObjFuncModule.FuncModuleEnName4GC());
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n * 框架-层名:{0}({1},{2})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName, objCodeTypeEN.CodeTypeId);

            strCodeForCs.AppendFormat("\r\n * 编程语言:{0}", clsPubConst.GetLangTypeStringByLangType(objViewInfoENEx.LangType));
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate4WebApi(string strCurrUserName, clsPrjTabENEx objPrjTabENEx, string strCmPrjId)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.AppendFormat("\r\n" + " * 类名:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " * 表名:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);

            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n * 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n * 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);


            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");

            if (string.IsNullOrEmpty(objPrjTabENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objPrjTabENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n * 相关数据库:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n * PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n 模块中文名:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC());
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n * 框架-层名:{0}({1},{2})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName, objCodeTypeEN.CodeTypeId);

            strCodeForCs.AppendFormat("\r\n * 编程语言:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));

            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }


        public static string GenUserInfoAndDate4Java(string strCurrUserName, clsViewInfoENEx objViewInfoENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(objViewInfoENEx.PrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " 类名:{0}", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " 表名:{0}({1})", objViewInfoENEx.TabName, objViewInfoENEx.MainTabId);

            strCodeForCs.AppendFormat("\r\n * 版本:{0}(服务器:{1})", clsSysParaEN_Local.strVersion, Environment.MachineName);
            //strCodeForCs.AppendFormat("\r\n ///作者:{0}", "潘以锋");
            strCodeForCs.AppendFormat("\r\n 日期:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n 生成者:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n 工程名称:{0}({1})", objViewInfoENEx.objProjectsEN.PrjName, objViewInfoENEx.PrjId);
            var strFunctionTemplateId = objCMProject.FunctionTemplateId;
            var objFunctionTemplate = clsFunctionTemplateBL.GetObjByFunctionTemplateIdCache(strFunctionTemplateId);


            string strIsFstLcase = objCMProject.IsFstLcase ? "小写" : "不限定";
            strCodeForCs.Append($"\r\n CM工程:{objCMProject.CmPrjName}({objCMProject.CmPrjId}, 变量首字母{strIsFstLcase})-{objFunctionTemplate.FunctionTemplateName}");

            if (string.IsNullOrEmpty(objViewInfoENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objViewInfoENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n 相关数据库:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n 模块中文名:{0}({1})", objViewInfoENEx.ObjFuncModule.FuncModuleName, objViewInfoENEx.ObjFuncModule.FuncModuleEnName4GC());
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n 框架-层名:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);
            strCodeForCs.AppendFormat("\r\n 编程语言:{0}", clsPubConst.GetLangTypeStringByLangType(objViewInfoENEx.LangType));
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }
        public static ImportClass AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath, List<ImportClass> arrImportClass, string strPrjId)
        {
            string strFuncModuleEnName = "";
            clsPrjTabEN objPrjTab = null;//= clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            if (string.IsNullOrEmpty(strTabId) == false)
            {
                objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                if (objPrjTab != null)
                {
                    var pobjFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTab.FuncModuleAgcId, strPrjId);

                    strFuncModuleEnName = pobjFuncModule.FuncModuleEnName4GC();

                    //if (objPrjTab.IsShare) strFuncModuleEnName += "_1Share";
                }
            }
            var objImportClass = new ImportClass();
            objImportClass.RefFuncName = clsStackTrace.GetCurrFunctionByLevel(3);
            switch (strImportObjType)
            {
                case "WApiExtendClassFunc":

                    objImportClass.ClsName = string.Format("{0}Ex_{1}", objPrjTab.TabName, strFuncName);
                    objImportClass.FilePath = string.Format("{0}/L3ForWApiEx/{1}/cls{2}WApi.js", strBasePath, strFuncModuleEnName,
                                   strClassName);
                    if (objPrjTab.IsShare)
                    {
                        objImportClass.FilePath = objImportClass.FilePath.Replace("L3ForWApiEx/", "L3ForWApiExShare/");
                    }
                    break;
                case "WApiClassFunc":

                    objImportClass.ClsName = string.Format("{0}_{1}", objPrjTab.TabName, strFuncName);
                    objImportClass.FilePath = string.Format("{0}/L3ForWApi/{1}/cls{2}WApi.js", strBasePath, strFuncModuleEnName,
                                   strClassName);
                    break;
                case enumImportObjType.WApiClassFuncInExWApi:

                    objImportClass.ClsName = string.Format("{0}_{1}", objPrjTab.TabName, strFuncName);
                    objImportClass.FilePath = string.Format("{0}/L3ForWApi/{1}/cls{2}WApi.js", strBasePath, strFuncModuleEnName,
                                   strClassName);
                    break;

                case enumImportObjType.BLClass:
                    objImportClass.ClsName = string.Format("{0}", strFuncName);
                    objImportClass.FilePath = string.Format("{0}/L2_Bll/{1}/cls{2}BL.js", strBasePath, strFuncModuleEnName,
                                   strClassName);
                    break;
                case enumImportObjType.BLClassFunc:
                    objImportClass.ClsName = string.Format("{0}_{1}", objPrjTab.TabName, strFuncName);
                    objImportClass.FilePath = string.Format("{0}/L2_Bll/{1}/cls{2}BL.js", strBasePath, strFuncModuleEnName,
                                   strClassName);
                    break;
                case "ENClass":

                    objImportClass.ClsName = string.Format("{0}", strFuncName);
                    objImportClass.FilePath = string.Format("{0}/L0Entity/{1}/cls{2}EN.js", strBasePath, strFuncModuleEnName,
                                   strClassName);
                    break;
                case enumImportObjType.ENClassInWApi:

                    objImportClass.ClsName = string.Format("{0}", strFuncName);
                    objImportClass.FilePath = string.Format("{0}/L0Entity/{1}/cls{2}EN.js", strBasePath, strFuncModuleEnName,
                                   strClassName);
                    break;
                case enumImportObjType.ENExClass:

                    objImportClass.ClsName = string.Format("{0}Ex", strFuncName);
                    objImportClass.FilePath = string.Format("{0}/L0Entity/{1}/cls{2}ENEx.js", strBasePath, strFuncModuleEnName,
                                   strClassName);
                    break;
                case enumImportObjType.CustomFunc:

                    objImportClass.ClsName = strFuncName;
                    if (strClassName.Substring(0, 1) == "@")
                    {
                        objImportClass.FilePath = strClassName;
                    }
                    else
                    {
                        objImportClass.FilePath = string.Format("{0}/{1}", strBasePath, strClassName);
                    }

                    objImportClass.FilePath = objImportClass.FilePath.Replace("//", "/");
                    break;
                case enumImportObjType.StoreModule:

                    objImportClass.ClsName = strFuncName;
                    if (strClassName.Substring(0, 1) == "@")
                    {
                        objImportClass.FilePath = strClassName;
                    }
                    else
                    {
                        objImportClass.FilePath = string.Format("{0}/{1}", strBasePath, strClassName);
                    }

                    objImportClass.FilePath = objImportClass.FilePath.Replace("//", "/");
                    break;
                default:
                    string strMsg = string.Format("导入对象类型:[{0}]在函数中没有被处理.(in {1})", strImportObjType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            arrImportClass.Add(objImportClass);
            return objImportClass;
        }
        public static CodeElement GetCodeElementByImportClass(ImportClass objImportClass)
        {
            string strCodeContent = string.Format("\r\n" + "import {{ {0} }} from \"{1}\";",
                objImportClass.ClsName,
                  objImportClass.FilePath.Replace(".js", "")
                        .Replace("../../TS/", "@/ts/")
                        .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                        .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/")
                        .Replace("../TS/", "@/ts/"));

            CodeElement objCodeElement = new CodeElement
            {
                Name = objImportClass.ClsName,
                CodeContent = strCodeContent,
                ElementType = CodeElementType.Import,
                RefFuncName = objImportClass.RefFuncName,
                From = objImportClass.FilePath
            };
            return objCodeElement;
        }
        public static string Gene_GetKeyData(clsTabFeatureFldsEN objInFor)
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType == "string")
            {

                strBuilder.AppendFormat("\r\n" + "{0} {1} = \"\";",
                    objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType,
                    objInFor.ObjFieldTab().PrivFuncName1());
                strBuilder.AppendFormat("\r\n" + "if (jobjOrderByData.ContainsKey(\"{0}\"))", clsString.FstLcaseS(objInFor.ObjFieldTab().FldName));
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "{1} = jobjOrderByData[\"{0}\"].ToString();",
                    clsString.FstLcaseS(objInFor.ObjFieldTab().FldName), objInFor.ObjFieldTab().PrivFuncName1());
                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "else if (jobjOrderByData.ContainsKey(\"{0}\"))", objInFor.ObjFieldTab().FldName.ToLower());
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "{1} = jobjOrderByData[\"{0}\"].ToString();",
                    objInFor.ObjFieldTab().FldName.ToLower(), objInFor.ObjFieldTab().PrivFuncName1());
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");

                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"在从前台传来的OrderByData的数据中不存在关键字:[{0}]的数据,请检查!\", \"{0}|{1}\");",
                    clsString.FstLcaseS(objInFor.ObjFieldTab().FldName), objInFor.ObjFieldTab().FldName.ToLower());
                strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
                strBuilder.Append("\r\n" + "}");

            }
            else
            {

                strBuilder.AppendFormat("\r\n" + "{0} {1} = 0;",
                    objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType,
                    objInFor.ObjFieldTab().PrivFuncName1());
                strBuilder.AppendFormat("\r\n" + "if (jobjOrderByData.ContainsKey(\"{0}\"))", clsString.FstLcaseS(objInFor.ObjFieldTab().FldName));
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "{1} = {0}.Parse(jobjOrderByData[\"{2}\"].ToString());",
                    objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType, objInFor.ObjFieldTab().PrivFuncName1(), clsString.FstLcaseS(objInFor.ObjFieldTab().FldName));
                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "else if (jobjOrderByData.ContainsKey(\"{0}\"))", objInFor.ObjFieldTab().FldName.ToLower());
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "{1} = {0}.Parse(jobjOrderByData[\"{2}\"].ToString());",
                    objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType, objInFor.ObjFieldTab().PrivFuncName1(), objInFor.ObjFieldTab().FldName.ToLower());
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"在从前台传来的OrderByData的数据中不存在关键字:[{0}]的数据,请检查!\", \"{0}|{1}\");",
                    clsString.FstLcaseS(objInFor.ObjFieldTab().FldName), objInFor.ObjFieldTab().FldName.ToLower());
                strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
                strBuilder.Append("\r\n" + "}");

            }
            return strBuilder.ToString();
        }


        public static string GenFilterCondition(string strVarName, clsPrjTabENEx objPrjTabENEx, bool bolIsFstLcase)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + " {3}.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(bolIsFstLcase),
                objInFor.PrivFuncName, strVarName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " && {3}.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(bolIsFstLcase),
                objInFor.PrivFuncName, strVarName);
                }
                intIndex++;
            }
            return strCodeForCs.ToString();
        }


        public static string GenInFldNameLst(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                strCodeForCs.Append("strInFldName:string");
                return strCodeForCs.ToString();
            }
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat(" strInFldName{0}:string ",
                intIndex + 1);
                }
                else
                {
                    strCodeForCs.AppendFormat(", strInFldName{0}:string ",
                intIndex + 1);
                }
                intIndex++;
            }
            return strCodeForCs.ToString();
        }
        public static string GenInValueLst(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                strCodeForCs.Append("strInValue:string");
                return strCodeForCs.ToString();
            }
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat(" strInValue{0}:{1} ",
                        intIndex + 1, objInFor.ObjFieldTab().TypeScriptType());
                }
                else
                {
                    strCodeForCs.AppendFormat(", strInValue{0}:{1} ",
                        intIndex + 1, objInFor.ObjFieldTab().TypeScriptType());
                }
                intIndex++;
            }
            return strCodeForCs.ToString();
        }
        public static string GetDefaUserIdExpress(string strPrjId)
        {
            var objGCVariable = clsGCVariableBLEx.GetObjByVarNameAndType("UserId", enumGCVariableType.localStorage_0003, strPrjId);
            if (objGCVariable == null)
            {
                string strMsg = $"本地缓存的变量:[UserId]在变量表没有定义!(in {clsStackTrace.GetCurrFunction()});";
                throw new Exception(strMsg);
            }
            return objGCVariable.VarExpression;
        }
        public static string GetCurrDateTimeExpress(string strPrjId)
        {
            var objGCVariable = clsGCVariableBLEx.GetObjByVarNameAndType("CurrDateTime", enumGCVariableType.Function_0008, strPrjId);
            if (objGCVariable == null)
            {
                string strMsg = $"本地缓存的变量:[CurrDateTime]在变量表没有定义!(in {clsStackTrace.GetCurrFunction()});";
                throw new Exception(strMsg);
            }
            return objGCVariable.VarExpression;
        }

        public static string GetFileNameWithModuleName(clsFuncModule_AgcEN objFuncModule, clsPrjTabENEx objPrjTabENEx)
        {
            //string strIsShare = objPrjTabENEx.IsShare == true ? "_1Share" : "";
            string strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName);
            return strRe_FileNameWithModuleName;
        }

        public static string GetFileNameWithModuleName(clsCodeTypeEN objCodeType, clsFuncModule_AgcEN objFuncModule, clsViewInfoENEx objViewInfoENEx, string strTabName)
        {
            //    string strIsShare = objViewInfoENEx.IsShare == true ? "Share" : "";
            string strIsShare = objViewInfoENEx.IsShare == true ? "" : "";
            string strRe_FileNameWithModuleName;
            if (objCodeType.IsDirByTabName == false)
            {
                strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName, strIsShare);
            }
            else
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", strTabName, objViewInfoENEx.WebFormFName, strIsShare);
            }
            return strRe_FileNameWithModuleName;
        }
        public static string GetFileNameWithModuleName(clsFuncModule_AgcEN objFuncModule, clsViewInfoENEx objViewInfoENEx)
        {
            //string strIsShare = objViewInfoENEx.IsShare == true ? "_1Share" : "";
            string strRe_FileNameWithModuleName;
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);
            return strRe_FileNameWithModuleName;
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            throw new NotImplementedException();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            throw new NotImplementedException();
        }

        public override void GetClsName()
        {
            throw new NotImplementedException();
        }

        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            throw new NotImplementedException();
        }
        public static string Gen_GetFirstCheckedValue(CodeElement objCodeElement_Parent, TabProp objTabProp, string strFeatureName, IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objTabProp.KeyFldCount > 1)
            {
                strCodeForCs.Append("\r\n" + $"const strKeyLst = GetFirstCheckedKeyLstInDivObj(divVarSet.refDivList);");
                ImportClass myImportClass = objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetFirstCheckedKeyLstInDivObj", enumImportObjType.CustomFunc, strBaseUrl);
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(myImportClass);
                                
                clsPubFun4GC.AddCodeElement_Import(objCodeElement_Parent, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "if (strKeyLst == 'undefined')");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strMsg = `在{strFeatureName}记录时，获取记录关键字为:${{ strKeyLst}},不成功!`;");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"const {{ {objTabProp.PropertyNamePrivVarNameLstrStr} }} = {objTabProp.TabName}_SplitKeyLst(strKeyLst);");
                //strCodeForCs.AppendFormat("\r\n" + "import {{ {0}_SplitKeyLst }} from \"@/ts/L3ForWApi/{1}/cls{0}WApi\";",
                //    TabName_In4Edit,
                //    thisEditTabProp_TS.FuncModuleEnName4GC);
                ImportClass myImportClass2 = objImportClass.AddImportClass(objTabProp.TabId, objTabProp.TabName, $"SplitKeyLst", enumImportObjType.WApiClassFunc, strBaseUrl);
                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(myImportClass2);

                clsPubFun4GC.AddCodeElement_Import(objCodeElement_Parent, objCodeElement_Import2);
                //strCodeForCs.Append("\r\n" + $"const {{ {objTabProp.KeyPrivVarNameLstStr} }} = {{ {objTabProp.PropertyNameLstrStr} }};");

            }
            else
            {
                strCodeForCs.Append("\r\n" + $"strKeyId = GetFirstCheckedKeyIdInDivObj(divVarSet.refDivList);");
                ImportClass myImportClass3 = objImportClass.AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetFirstCheckedKeyIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(myImportClass3);

                clsPubFun4GC.AddCodeElement_Import(objCodeElement_Parent, objCodeElement_Import3);

                strCodeForCs.Append("\r\n" + "if (strKeyId == 'undefined')");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"strMsg = `在{strFeatureName}记录时，获取记录关键字为:${{ strKeyId }},不成功!`;");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                if (objTabProp.IsNumberType)
                {
                    strCodeForCs.Append("\r\n" + $"const {objTabProp.PriVarName} = Number(strKeyId);");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const {objTabProp.PriVarName} = strKeyId;");
                }
            }
            return strCodeForCs.ToString();
        }
        public static void AddCodeElement_Import(CodeElement objCodeElement_Parent, CodeElement objCodeElement_Import)
        {
            objCodeElement_Import.CodeContent = ReplaceImportStr(objCodeElement_Import.CodeContent);
            objCodeElement_Import.From = ReplaceImportStr(objCodeElement_Import.From);


            if (objCodeElement_Parent.ElementType != CodeElementType.Import) return;
            if (objCodeElement_Import == null ||
               string.IsNullOrEmpty( objCodeElement_Import.From) == true)
            {
                string strMsg = $"代码元素：{objCodeElement_Import.Name} 的From 不能为空！";
                throw new Exception(strMsg);
            }
            if (objCodeElement_Parent.ElementType != CodeElementType.Import)
            {
                string strMsg = $"导入元素的父元素{objCodeElement_Parent.Name} 类型应该是Improt类型！";
                throw new Exception(strMsg);
            }


            if (objCodeElement_Parent.Children == null)
                objCodeElement_Parent.Children = new List<CodeElement>();

            // 1. 检查是否已存在相同 Name 的导入
            var sameNameElement = objCodeElement_Parent.Children.FirstOrDefault(x => x.Name == objCodeElement_Import.Name);
            if (sameNameElement != null)
            {
                // 合并 RefFuncName
                MergeRefFuncName(sameNameElement, objCodeElement_Import);
                return;
            }

            // 2. 检查是否已存在相同 From 的导入
            string importFrom = GetFromPath(objCodeElement_Import);
            var sameFromElement = objCodeElement_Parent.Children
                .FirstOrDefault(x => GetFromPath(x) == importFrom);

            if (sameFromElement != null)
            {
                // 已有相同From，检查Name是否已包含
                var existNames = sameFromElement.Name.Split(',').Select(n => n.Trim()).ToList();
                var importNames = objCodeElement_Import.Name.Split(',').Select(n => n.Trim()).ToList();

                // 需要添加的Name
                var toAddNames = importNames.Where(n => !existNames.Contains(n)).ToList();
                if (toAddNames.Count == 0)
                {
                    // RefFuncName 合并
                    MergeRefFuncName(sameFromElement, objCodeElement_Import);
                    return; // 已全部包含，无需添加
                }
                // 合并Name
                existNames.AddRange(toAddNames);
                sameFromElement.Name = string.Join(", ", existNames.Distinct());

                // 更新CodeContent（假设格式为 import { A, B } from "xxx";）
                string fromStr = importFrom;
                sameFromElement.CodeContent = $"import {{ {sameFromElement.Name} }} from \"{fromStr}\";";

                // RefFuncName 合并
                MergeRefFuncName(sameFromElement, objCodeElement_Import);
                return;
            }

            // 3. 否则直接添加
            objCodeElement_Parent.Children.Add(objCodeElement_Import);
        }

        public static void AddCodeElement_Method(CodeElement objCodeElement_Parent, CodeElement objCodeElement_Method)
        {

            //if (objCodeElement_Parent.ElementType != CodeElementType.Import) return;
            if (objCodeElement_Method == null ||
               string.IsNullOrEmpty(objCodeElement_Method.Name) == true)
            {
                string strMsg = $"代码元素：{objCodeElement_Method.Name} 的Name 不能为空！";
                throw new Exception(strMsg);
            }

            if (objCodeElement_Method.ElementType != CodeElementType.Method 
                && objCodeElement_Method.ElementType != CodeElementType.Delegate
                && objCodeElement_Method.ElementType != CodeElementType.Constructor)
            {
                string strMsg = $"代码元素：{objCodeElement_Method.Name} 的类型必须 为方法！";
                throw new Exception(strMsg);
            }
            if (objCodeElement_Parent.Children == null)
                objCodeElement_Parent.Children = new List<CodeElement>();

            // 1. 检查是否已存在相同 Name 的导入
            var sameNameElement = objCodeElement_Parent.Children.FirstOrDefault(x => x.Name == objCodeElement_Method.Name);
            if (sameNameElement != null)
            {
                // 合并 RefFuncName
                return;
            }

            // 3. 否则直接添加
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
        }

        public static void AddCodeElement_Property(CodeElement objCodeElement_Parent, CodeElement objCodeElement_Property)
        {

            //if (objCodeElement_Parent.ElementType != CodeElementType.Import) return;
            if (objCodeElement_Property == null ||
               string.IsNullOrEmpty(objCodeElement_Property.Name) == true)
            {
                string strMsg = $"代码元素：{objCodeElement_Property.Name} 的Name 不能为空！";
                throw new Exception(strMsg);
            }

            if (objCodeElement_Property.ElementType != CodeElementType.Property
                && objCodeElement_Property.ElementType != CodeElementType.Constant
                && objCodeElement_Property.ElementType != CodeElementType.StaticVar
                && objCodeElement_Property.ElementType != CodeElementType.ReactiveConstant
                && objCodeElement_Property.ElementType != CodeElementType.RefConstant
                )
            {
                string strMsg = $"代码元素：{objCodeElement_Property.Name} 的类型必须 为属性、常量、变量等！";
                throw new Exception(strMsg);
            }
            if (objCodeElement_Parent.Children == null)
                objCodeElement_Parent.Children = new List<CodeElement>();

            // 1. 检查是否已存在相同 Name 的导入
            var sameNameElement = objCodeElement_Parent.Children.FirstOrDefault(x => x.Name == objCodeElement_Property.Name);
            if (sameNameElement != null)
            {
                // 合并 RefFuncName
                return;
            }

            // 3. 否则直接添加
            objCodeElement_Parent.Children.Add(objCodeElement_Property);
        }


        // 辅助方法：从CodeContent中提取from路径
        private static string GetFromPath(CodeElement ce)
        {
            if (ce == null || string.IsNullOrEmpty(ce.CodeContent))
                return string.Empty;
            // 例：import { A, B } from "@/ts/xxx";
            var match = System.Text.RegularExpressions.Regex.Match(ce.CodeContent, @"from\s+[""']([^""']+)[""']");
            if (match.Success == false && ce.From.Length > 0) return ce.From;
            return match.Success ? match.Groups[1].Value : string.Empty;
        }

        // 合并 RefFuncName，避免重复
        private static void MergeRefFuncName(CodeElement target, CodeElement source)
        {
            if (string.IsNullOrEmpty(source.RefFuncName))
                return;
            if (string.IsNullOrEmpty(target.RefFuncName))
            {
                target.RefFuncName = source.RefFuncName;
                return;
            }
            var refList = target.RefFuncName.Split(',').Select(x => x.Trim()).ToList();
            var addList = source.RefFuncName.Split(',').Select(x => x.Trim()).ToList();
            foreach (var add in addList)
            {
                if (!refList.Contains(add))
                    refList.Add(add);
            }
            target.RefFuncName = string.Join(", ", refList);
        }
        public static string ReplaceImportStr(string strSourse)
        {
            string strTarget = strSourse.Replace(".js", "")
                .Replace("../../PubFun/","@/ts/PubFun/")
                        .Replace("../../TS/", "@/ts/")
                        .Replace("../TS/", "@/ts/")
                           .Replace("../../L0Entity/", "@/ts/L0Entity/")
                              .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                              .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/");
            return strTarget;
        }
    }
}
