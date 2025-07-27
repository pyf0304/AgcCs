
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTabExWApi
表名:vPrjTab(00050124)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:00:04
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
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
    public static class clsvPrjTabExWApi_Static
    {
        public static string PrimaryTypeId(this clsvPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldWApi.GetObjLstCache(objPrjTab.TabId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldTypeWA.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";

            return arrPrjTabFld_Sel[0].PrimaryTypeId;
        }
        public static string KeyFldId(this clsvPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldWApi.GetObjLstCache(objPrjTab.TabId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldTypeWA.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";

            return arrPrjTabFld_Sel[0].FldId;
        }

        public static string KeyFldNames(this clsvPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldWApi.GetObjLstCache(objPrjTab.TabId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldTypeWA.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";
            string strKeyFldNames = "";
            foreach (var objInFor in arrPrjTabFld_Sel)
            {
                var objFieldTab = clsFieldTabWApi.GetObjByFldId(arrPrjTabFld_Sel[0].FldId);
                strKeyFldNames += string.Format("{0},", objFieldTab.FldName);
            }
            strKeyFldNames = strKeyFldNames.TrimEnd(',');
            return strKeyFldNames;
        }
        public static string KeyFldName_Types(this clsvPrjTabEN objPrjTab, List<clsPrjTabFldEN> arrObjLst_P)
        {
            var arrPrjTabFld = clsPrjTabFldWApi.GetObjLstCacheFromObjLst(objPrjTab.TabId, arrObjLst_P);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldTypeWA.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";
            string strKeyFldName_Types = "";
            foreach (var objInFor in arrPrjTabFld_Sel)
            {
                var objFieldTab = clsvFieldTab_SimWApi.GetObjByFldIdCache(arrPrjTabFld_Sel[0].FldId, objPrjTab.PrjId);
                var objPrimaryType = objInFor.ObjPrimaryType();
                strKeyFldName_Types += string.Format("{0}({1}),", objFieldTab.FldName, objPrimaryType.PrimaryTypeName);
            }
            strKeyFldName_Types = strKeyFldName_Types.TrimEnd(',');
            return strKeyFldName_Types;
        }
    }

    /// <summary>
    /// v工程表(vPrjTab)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvPrjTabExWApi
    {
        //private static readonly string mstrApiControllerName = "vPrjTabExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvPrjTabEN> arrvPrjTabObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsvPrjTabExWApi()
        {
        }
        public static clsvPrjTabENEx CopyToEx(clsvPrjTabEN objPrjTabENS)
        {
            try
            {
                clsvPrjTabENEx objPrjTabENT = new clsvPrjTabENEx();
                clsvPrjTabWApi.CopyTo(objPrjTabENS, objPrjTabENT);
                return objPrjTabENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}