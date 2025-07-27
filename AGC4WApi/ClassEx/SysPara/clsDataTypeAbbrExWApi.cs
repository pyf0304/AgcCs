
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDataTypeAbbrExWApi
表名:DataTypeAbbr(00050023)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:31
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统参数
模块英文名:SysPara
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;

using System.Collections.Generic;
using com.taishsoft.json;
using System.Linq;

namespace AGC4WApi
{
    /// <summary>
    /// 数据类型(DataTypeAbbr)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsDataTypeAbbrExWApi
    {
        //private static readonly string mstrApiControllerName = "DataTypeAbbrExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsDataTypeAbbrExWApi()
        {
        }
        /// <summary>
        /// 根据数据类型名获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strDataTypeName">所给的数据类型名</param>
        /// <returns>根据数据类型名获取的对象</returns>
        public static clsDataTypeAbbrEN GetObjByDataTypeNameCache(string strDataTypeName)
        {
            if (arrDataTypeAbbrObjLst_Cache == null)
            {
                arrDataTypeAbbrObjLst_Cache =  clsDataTypeAbbrWApi.GetObjLst("1 = 1");
            }
            foreach (clsDataTypeAbbrEN objDataTypeAbbrEN in arrDataTypeAbbrObjLst_Cache)
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
                case enumProgLangTypeWA.CSharp_01:
                    if (x.CsType == strTypeName) return true;
                    break;
                case enumProgLangTypeWA.JAVA_02:
                    if (x.JavaType == strTypeName) return true;
                    break;
                case enumProgLangTypeWA.Swift_03:
                    if (x.SwiftType == strTypeName) return true;
                    break;
                case enumProgLangTypeWA.JavaScript_04:
                    if (x.TypeScriptType == strTypeName) return true;
                    break;
                case enumProgLangTypeWA.SilverLight_05:
                    if (x.CsType == strTypeName) return true;
                    break;
                case enumProgLangTypeWA.VB_06:
                    if (x.VbNetType == strTypeName) return true;
                    break;
                case enumProgLangTypeWA.Swift3_07:
                    if (x.SwiftType == strTypeName) return true;
                    break;
                case enumProgLangTypeWA.Swift4_08:
                    if (x.SwiftType == strTypeName) return true;
                    break;
                case enumProgLangTypeWA.TypeScript_09:
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
            if (arrDataTypeAbbrObjLst_Cache == null)
            {
                arrDataTypeAbbrObjLst_Cache = clsDataTypeAbbrWApi.GetObjLst("1 = 1");
            }
            IEnumerable<clsDataTypeAbbrEN> arrDataTypeAbbr_Sel = arrDataTypeAbbrObjLst_Cache.Where(x => IsMatchType(x, strProgLangTypeId, strDataTypeName));
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

            IEnumerable<clsDataTypeAbbrEN> arrDataTypeAbbr_Sel2 = arrDataTypeAbbrObjLst_Cache.Where(x => IsMatchType(x, strProgLangTypeId, strDataTypeName));
            if (arrDataTypeAbbr_Sel2.Count() > 0)
            {
                return arrDataTypeAbbr_Sel2.First();
            }

            return null;
        }

    }
}