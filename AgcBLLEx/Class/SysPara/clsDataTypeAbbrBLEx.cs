using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

using AGC.DAL;
using AGC.BusinessLogic;
using com.taishsoft.common;
using com.taishsoft.json;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 全静态类，包含全静态函数，相当于全局函数
    /// </summary>
    public static class clsDataTypeAbbrBLEx_Static
    {
        /// <summary>
        /// 是否数字类型
        /// </summary>
        /// <param name="objDataTypeAbbrEN"></param>
        /// <returns></returns>
        public static bool IsNumberType(this clsDataTypeAbbrEN objDataTypeAbbrEN)
        {
            switch (objDataTypeAbbrEN.CsType)
            {
                case "Int":
                case "int":
                case "long":
                case "float":
                case "short":
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// 根据语言获取数据类型串
        /// </summary>
        /// <param name="objDataTypeAbbrEN">数据类型对象</param>
        /// <param name="strProgLangTypeId">语言类型Id</param>
        /// <returns>数据类型串</returns>
        public static string GetTypeString(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strProgLangTypeId)
        {
            switch (strProgLangTypeId)
            {
                case enumProgLangType.CSharp_01:
                    return objDataTypeAbbrEN.CsType;
                case enumProgLangType.JAVA_02:
                    return objDataTypeAbbrEN.JavaType;
                case enumProgLangType.TypeScript_09:
                    return objDataTypeAbbrEN.TypeScriptType;
                case enumProgLangType.JavaScript_04:
                    return objDataTypeAbbrEN.TypeScriptType;
                case enumProgLangType.Html_10:
                    return objDataTypeAbbrEN.TypeScriptType;

                case enumProgLangType.Swift4_08:
                case enumProgLangType.Swift_03:
                case enumProgLangType.Swift3_07:
                    return objDataTypeAbbrEN.SwiftType;
                case enumProgLangType.SilverLight_05:
                    return objDataTypeAbbrEN.CsType;
                default:
                    string strMsg = string.Format("数据类型:{0}在函数中没有被处理！(In {1})", strProgLangTypeId, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据语言获取不同数据类型的初始值,为控件赋值
        /// </summary>
        /// <param name="objDataTypeAbbrEN">数据类型对象</param>
        /// <param name="strProgLangTypeId">语言类型Id</param>
        /// <returns>数据类型串</returns>
        public static string GetInitValue(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strProgLangTypeId)
        {
            switch (strProgLangTypeId)
            {
                case enumProgLangType.CSharp_01:
                    switch (objDataTypeAbbrEN.CsType)
                    {
                        case "int":
                            return "\"0\"";

                        case "double":
                            return "\"0.0\"";
                        case "DateTime":
                            return "\"0\"";
                        case "bool":
                            return "false";

                        case "float":
                            return "\"0.0\"";

                        case "long":
                            return "\"0\"";
                        default:
                            return "\"\"";
                    }
                case enumProgLangType.JAVA_02:
                    return objDataTypeAbbrEN.JavaType;
                case enumProgLangType.TypeScript_09:
                    switch (objDataTypeAbbrEN.CsType)
                    {
                        case "int":
                            return "0";

                        case "double":
                            return "\"0.0\"";
                        case "DateTime":
                            return "\"0\"";
                        case "bool":
                            return "false";

                        case "float":
                            return "\"0.0\"";

                        case "long":
                            return "\"0\"";
                        default:
                            return "\"\"";
                    }

                    //return objDataTypeAbbrEN.TypeScriptType;
                case enumProgLangType.Swift4_08:
                case enumProgLangType.Swift_03:
                case enumProgLangType.Swift3_07:
                    return objDataTypeAbbrEN.SwiftType;
                case enumProgLangType.SilverLight_05:
                    return objDataTypeAbbrEN.CsType;
                default:
                    string strMsg = string.Format("数据类型:{0}在函数中没有被处理！(In {1})", strProgLangTypeId, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据语言获取不同数据类型的初始值,为变量赋值
        /// </summary>
        /// <param name="objDataTypeAbbrEN">数据类型对象</param>
        /// <param name="strProgLangTypeId">语言类型Id</param>
        /// <returns>数据类型串</returns>
        public static string GetInitValue4Var(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strProgLangTypeId)
        {
            switch (strProgLangTypeId)
            {
                case enumProgLangType.CSharp_01:
                    switch (objDataTypeAbbrEN.CsType)
                    {
                        case "int":
                            return "0";

                        case "double":
                            return "0.0";
                        case "DateTime":
                            return "0";
                        case "bool":
                            return "false";

                        case "float":
                            return "0.0";

                        case "long":
                            return "0";
                        case "byte":
                            return "0";
                        case "byte[]":
                            return "0";
                        case "DataSet":
                            return "0";
                        case "List":
                            return "null";
                        case "Object":
                            return "null";
                        case "ObjectLst":
                            return "null";
                        case "short":
                            return "0";
                        case "string":
                            return "\"\"";
                        case "void":
                            return "0";
                        default:
                            return "\"\"";
                    }
                case enumProgLangType.JAVA_02:
                    return objDataTypeAbbrEN.JavaType;
                case enumProgLangType.TypeScript_09:
                case enumProgLangType.Html_10:

                    switch (objDataTypeAbbrEN.TypeScriptType)
                    {
                        case "Array(string)":
                            return "null";
                        case "boolean":
                            return "false";
                        case "byte":
                            return "null";
                        case "byte[]":
                            return "null";
                        case "DataSet":
                            return "null";
                        case "Date":
                            return "2001-01-01";
                        case "DateTime":
                            return "2001-01-01";
                        case "number":
                            return "0";
                        case "Object":
                            return "null";
                        case "ObjectLst":
                            return "null";
                        case "string":
                            return "\"\"";
                        case "void":
                            return "null";
                        default:
                            return "\"\"";
                    }
                case enumProgLangType.Swift4_08:
                case enumProgLangType.Swift_03:
                case enumProgLangType.Swift3_07:
                    switch (objDataTypeAbbrEN.SwiftType)
                    {
                        case "Int":
                            return "0";
                        case "Int32":
                            return "0";
                        case "Short":
                        case "CShort":
                            return "0";
                        case "double":
                            return "0.0";
                        case "DateTime":
                            return "0";
                        case "Bool":
                            return "false";
                        case "float":
                        case "Float":
                            return "0.0";
                        case "long":
                            return "0";
                        case "String":
                            return "\"\"";
                        default:
                            return "\"\"";
                    }
                case enumProgLangType.SilverLight_05:
                    return objDataTypeAbbrEN.CsType;
                default:
                    string strMsg = string.Format("数据类型:{0}在函数中没有被处理！(In {1})", strProgLangTypeId, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDataTypeAbbrENS">源对象</param>
        /// <returns>目标对象=>clsDataTypeAbbrEN:objDataTypeAbbrENT</returns>
        public static clsDataTypeAbbrENEx CopyToEx(this clsDataTypeAbbrEN objDataTypeAbbrENS)
        {
            try
            {
                clsDataTypeAbbrENEx objDataTypeAbbrENT = new clsDataTypeAbbrENEx();
                clsDataTypeAbbrBL.CopyTo(objDataTypeAbbrENS, objDataTypeAbbrENT);
                return objDataTypeAbbrENT;
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
        /// <param name = "objDataTypeAbbrENS">源对象</param>
        /// <returns>目标对象=>clsDataTypeAbbrEN:objDataTypeAbbrENT</returns>
        public static clsDataTypeAbbrEN CopyTo(this clsDataTypeAbbrENEx objDataTypeAbbrENS)
        {
            try
            {
                clsDataTypeAbbrEN objDataTypeAbbrENT = new clsDataTypeAbbrEN();
                clsDataTypeAbbrBL.CopyTo(objDataTypeAbbrENS, objDataTypeAbbrENT);
                return objDataTypeAbbrENT;
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

    public partial class clsDataTypeAbbrBLEx : clsDataTypeAbbrBL
    {
        public static string GetReturnTypeIdByReturnType(string strReturnType)
        {
            string strReturnTypeId = "";
            clsDataTypeAbbrEN objDataTypeAbbrEN = GetDataTypeAbbrObjByNetSysTypeCache(strReturnType);
            if (objDataTypeAbbrEN != null)
            {
                strReturnTypeId = objDataTypeAbbrEN.DataTypeId;
                return strReturnTypeId;
            }
            switch (strReturnType)
            {
                case "System.IAsyncResult":
                    strReturnTypeId = "99";
                    break;
                case "System.Web.Services.Protocols.SoapProtocolVersion":
                    strReturnTypeId = "98";
                    break;
                case "System.Net.CookieContainer":
                    strReturnTypeId = "97";
                    break;
                case "System.Security.Cryptography.X509Certificates.X509CertificateCollection":
                    strReturnTypeId = "96";
                    break;
                case "System.Net.IWebProxy":
                    strReturnTypeId = "95";
                    break;
                case "System.Net.ICredentials":
                    strReturnTypeId = "94";
                    break;
                case "System.Text.Encoding":
                    strReturnTypeId = "93";
                    break;
                case "System.ComponentModel.ISite":
                    strReturnTypeId = "92";
                    break;
                case "System.ComponentModel.IContainer":
                    strReturnTypeId = "91";
                    break;
                case "System.Object":
                    strReturnTypeId = "90";
                    break;
                case "System.Runtime.Remoting.ObjRef":
                    strReturnTypeId = "89";
                    break;
                case "System.Type":
                    strReturnTypeId = "88";
                    break;
                case "System.AsyncCallback":
                    strReturnTypeId = "87";
                    break;
                case "System.String&":
                    strReturnTypeId = "86";
                    break;

                default:
                    string strMsg = string.Format("返回类型：{0}在相应函数中没有被处理!({1}->{2})",
                        strReturnType,
                        clsStackTrace.GetCurrClassFunctionByLevel(2),
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            return strReturnTypeId;
        }
        /// <summary>
        /// 根据数据类型名获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strDataTypeName">所给的数据类型名</param>
        /// <returns>根据数据类型名获取的对象</returns>
        public static clsDataTypeAbbrEN GetDataTypeAbbrObjByNetSysTypeCache(string strNetSysType)
        {
            List<clsDataTypeAbbrEN> arrObjLstCache = clsDataTypeAbbrBL.GetObjLstCache();

            foreach (clsDataTypeAbbrEN objDataTypeAbbrEN in arrObjLstCache)
            {
                if (objDataTypeAbbrEN.NetSysType.Equals(strNetSysType, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return objDataTypeAbbrEN;
                }
            }
            return null;
        }


        /// <summary>
        /// 根据数据类型名获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strDataTypeName">所给的数据类型名</param>
        /// <returns>根据数据类型名获取的对象</returns>
        public static clsDataTypeAbbrEN GetObjByDataTypeNameCache(string strDataTypeName)
        {
            List<clsDataTypeAbbrEN> arrObjLstCache = clsDataTypeAbbrBL.GetObjLstCache();

            foreach (clsDataTypeAbbrEN objDataTypeAbbrEN in arrObjLstCache)
            {
                if (objDataTypeAbbrEN.DataTypeName.Equals(strDataTypeName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return objDataTypeAbbrEN;
                }
            }
            return null;
        }
        static Func<clsDataTypeAbbrEN, string, string, bool> IsMatchType = (x, strProgLangTypeId, strTypeName) =>
       {
           switch (strProgLangTypeId)
           {
               case enumProgLangType.CSharp_01:
                   if (x.CsType == strTypeName) return true;
                   break;
               case enumProgLangType.JAVA_02:
                   if (x.JavaType == strTypeName) return true;
                   break;
               case enumProgLangType.Swift_03:
                   if (x.SwiftType == strTypeName) return true;
                   break;
               case enumProgLangType.JavaScript_04:
                   if (x.TypeScriptType == strTypeName) return true;
                   break;
               case enumProgLangType.SilverLight_05:
                   if (x.CsType == strTypeName) return true;
                   break;
               case enumProgLangType.VB_06:
                   if (x.VbNetType == strTypeName) return true;
                   break;
               case enumProgLangType.Swift3_07:
                   if (x.SwiftType == strTypeName) return true;
                   break;
               case enumProgLangType.Swift4_08:
                   if (x.SwiftType == strTypeName) return true;
                   break;
               case enumProgLangType.TypeScript_09:
                   if (x.TypeScriptType == strTypeName) return true;
                   break;
           }
           return false;
       };

        /// <summary>
        /// 根据数据类型名获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strDataTypeName">所给的数据类型名</param>
        /// <returns>根据数据类型名获取的对象</returns>
        public static clsDataTypeAbbrEN GetObjByDataTypeNameCache(string strDataTypeName, string strProgLangTypeId)
        {
            List<clsDataTypeAbbrEN> arrObjLstCache = clsDataTypeAbbrBL.GetObjLstCache();

            IEnumerable<clsDataTypeAbbrEN> arrDataTypeAbbr_Sel = arrObjLstCache.Where(x => IsMatchType(x, strProgLangTypeId, strDataTypeName));
            if (arrDataTypeAbbr_Sel.Count() > 0)
            {
                return arrDataTypeAbbr_Sel.First();
            }
            if (strDataTypeName.IndexOf("List(") >= 0)
            {
                strDataTypeName = "ObjectLst";
            }
            else if (strDataTypeName.IndexOf("cls") >= 0)
            {
                strDataTypeName = "Object";
            }

            IEnumerable<clsDataTypeAbbrEN> arrDataTypeAbbr_Sel2 = arrObjLstCache.Where(x => IsMatchType(x, strProgLangTypeId, strDataTypeName));
            if (arrDataTypeAbbr_Sel2.Count() > 0)
            {
                return arrDataTypeAbbr_Sel2.First();
            }

            return null;
        }

        /// <summary>
        /// 获取相关对象列表, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns>获取相关对象列表</returns>
        public static List<clsDataTypeAbbrEN> GetObjLstForBindDdl()
        {
            List<clsDataTypeAbbrEN> arrObjLstCache = clsDataTypeAbbrBL.GetObjLstCache();

            return arrObjLstCache;
        }

        public static string GetDataTypeIdByName(string strDataTypeName)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("DataTypeName = '{0}'", strDataTypeName);
            string strDataTypeId = clsDataTypeAbbrBL.GetFirstID_S(sbCondition.ToString());
            return strDataTypeId;
        }

        public static clsDataTypeAbbrEN GetObjByName(string strDataTypeName)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("DataTypeName = '{0}'", strDataTypeName);

            clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetFirstObj_S(sbCondition.ToString());
            return objDataTypeAbbrEN;
        }
        /// <summary>
        /// 是否数字类型
        /// </summary>
        /// <param name="objDataTypeAbbrEN"></param>
        /// <returns></returns>
        public static bool IsNumberType(clsDataTypeAbbrEN objDataTypeAbbrEN)
        {
            switch (objDataTypeAbbrEN.CsType)
            {
                case "Int":
                case "int":
                case "long":
                case "float":
                case "short":
                    return true;
                default:
                    return false;
            }
        }
        public static string GetTypeString(string strDataTypeId, string strProgLangTypeId)
        {
            clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(strDataTypeId);
            if (objDataTypeAbbrEN == null)
            {
                string strMsg = string.Format("数据类型Id:{0}不存在！(In {1})", strDataTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strTypeString = objDataTypeAbbrEN.GetTypeString(strProgLangTypeId);
            return strTypeString;
        }
        public static string GetTypeStringByArrayTypeBak(string strArrayType)
        {
            int intStartPos = strArrayType.IndexOf("[");
            int intEndPos = strArrayType.IndexOf("]");
            if (intEndPos == 0 || intStartPos == 0 || intEndPos <= intStartPos)
            {
                string strMsg = string.Format("对象列表类型串:[{0}]格式不正确！", strArrayType);
                throw new Exception(strMsg);
                throw new Exception();
            }
            string strTypeString = strArrayType.Substring(intStartPos + 1, intEndPos - intStartPos - 1);
            return strTypeString;
        }
        public static string GetTypeNameByArrayType(string strDataType)
        {
            int intStartPos = strDataType.IndexOf("<");
            int intEndPos = strDataType.IndexOf(">");
            if (intStartPos <= 0 || intEndPos <= 0 || intStartPos >= intEndPos)
            {
                string strMsg = string.Format("对象列表数据类型:[{0}]格式不正确！(In {1})", strDataType, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strObjType = strDataType.Substring(intStartPos + 1, intEndPos - intStartPos - 1);
            return strObjType;
        }

        /// <summary>
        /// 根据条件获取JSON对象列表
        /// </summary>
        /// <returns>返回对象列表</returns>
        public static string GetJSONObjLstCacheEx()
        {
            List<clsDataTypeAbbrEN> arrObjLst = GetObjLstCache();
            string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
            return strJSON;
        }
  
        public static List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLst = null;
               
        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_DataTypeAbbr(System.Windows.Forms.ListView lvDataTypeAbbr, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviDataTypeAbbr;
            List<clsDataTypeAbbrEN> arrDataTypeAbbrObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrDataTypeAbbrObjList = clsDataTypeAbbrBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvDataTypeAbbr.Items.Clear();//清除原来所有Item
            lvDataTypeAbbr.Columns.Clear();//清除原来所有列头信息
            lvDataTypeAbbr.Columns.Add("数据类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("DataTypeName", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("数据类型中文名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("数据类型缩写", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("NET系统类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("VBNET类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("CS类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("JAVA类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("JAVA对象类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("是否需要引号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("Ora数据类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.Columns.Add("IsReturnType", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDataTypeAbbr.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsDataTypeAbbrEN objDataTypeAbbr in arrDataTypeAbbrObjList)
            {
                lviDataTypeAbbr = new System.Windows.Forms.ListViewItem();
                lviDataTypeAbbr.Tag = objDataTypeAbbr.DataTypeId;
                lviDataTypeAbbr.Text = objDataTypeAbbr.DataTypeId.ToString();
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.DataTypeName);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.DataCnName);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.DataTypeAbbr);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.NetSysType);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.VbNetType);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.CsType);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.JavaType);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.JavaObjType);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.IsNeedQuote.ToString());
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.Memo);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.OraDbType);
                lviDataTypeAbbr.SubItems.Add(objDataTypeAbbr.IsReturnType.ToString());
                lvDataTypeAbbr.Items.Add(lviDataTypeAbbr);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrDataTypeAbbrObjList.Count;
        }
        //public static clsDataTypeAbbrEN GetDataTypeAbbrObjByName(string strDataTypeName)
        //{
        //    StringBuilder sbCondition = new StringBuilder();
        //    sbCondition.AppendFormat("DataTypeName = '{0}'", strDataTypeName);

        //    clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetFirstDataTypeAbbr(sbCondition.ToString());
        //    return objDataTypeAbbr;
        //}
        //public static string  GetDataTypeIdByName(string strDataTypeName)
        //{
        //    StringBuilder sbCondition = new StringBuilder();
        //    sbCondition.AppendFormat("DataTypeName = '{0}'", strDataTypeName);
        //    string strDataTypeId = clsDataTypeAbbrBL.GetFirstID_S(sbCondition.ToString());
        //    return strDataTypeId;
        //}


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strDataTypeId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsDataTypeAbbrEN GetDataTypeAbbrObjByDataTypeId(string strDataTypeId)
        {
            if (arrDataTypeAbbrObjLst == null)
            {
                arrDataTypeAbbrObjLst = clsDataTypeAbbrBL.GetObjLst("1 = 1");
            }
            foreach (clsDataTypeAbbrEN objDataTypeAbbr in arrDataTypeAbbrObjLst)
            {
                if (objDataTypeAbbr.DataTypeId == strDataTypeId)
                {
                    return objDataTypeAbbr;
                }
            }
            return null;
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strDataTypeId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetDataTypeNameByDataTypeId(string strDataTypeId)
        {
            if (arrDataTypeAbbrObjLst == null)
            {
                arrDataTypeAbbrObjLst = clsDataTypeAbbrBL.GetObjLst("1 = 1");
            }
            foreach (clsDataTypeAbbrEN objDataTypeAbbr in arrDataTypeAbbrObjLst)
            {
                if (objDataTypeAbbr.DataTypeId == strDataTypeId)
                {
                    return objDataTypeAbbr.DataTypeName;
                }
            }
            return null;
        }

    }
}
