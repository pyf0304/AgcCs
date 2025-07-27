
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTabBLEx
表名:vPrjTab
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC
工程ID:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public static class clsvPrjTabBLEx_Static
    {
        public static string PrimaryTypeId(this clsvPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";

            return arrPrjTabFld_Sel[0].PrimaryTypeId;
        }
        public static string KeyFldId(this clsvPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";

            return arrPrjTabFld_Sel[0].FldId;
        }

        public static string KeyFldNames(this clsvPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";
            string strKeyFldNames = "";
            foreach (var objInFor in arrPrjTabFld_Sel)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(arrPrjTabFld_Sel[0].FldId, objPrjTab.PrjId);
                strKeyFldNames += string.Format("{0},", objFieldTab.FldName);
            }
            strKeyFldNames = strKeyFldNames.TrimEnd(',');
            return strKeyFldNames;
        }
        public static string KeyFldName_Types(this clsvPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";
            string strKeyFldName_Types = "";
            foreach (var objInFor in arrPrjTabFld_Sel)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(arrPrjTabFld_Sel[0].FldId, objPrjTab.PrjId);
                var objPrimaryType = objInFor.ObjPrimaryType();
                strKeyFldName_Types += string.Format("{0}({1}),", objFieldTab.FldName, objPrimaryType.PrimaryTypeName);
            }
            strKeyFldName_Types = strKeyFldName_Types.TrimEnd(',');
            return strKeyFldName_Types;
        }
    }

    /// <summary>
    /// v工程表(vPrjTab)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvPrjTabBLEx : clsvPrjTabBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvPrjTabDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvPrjTabDAEx vPrjTabDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvPrjTabDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        public static List<clsvPrjTabEN> GetPrjTabObjLst(string strPrjId)
        {
            //string strWhereCond = string.Format("{0} = '{1}' ",
            //    clsvPrjTabEN.con_PrjId, strPrjId);
            //if (clsvPrjTabBL.arrvPrjTabObjLstCache == null)
            //{
            //    clsvPrjTabBL.arrvPrjTabObjLstCache = new clsvPrjTabDA().GetObjLst(strWhereCond);
            //}
            //string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
            List<clsvPrjTabEN> arrvPrjTabObjLstCache = GetObjLstCache(strPrjId); 

            List<clsvPrjTabEN> arrvPrjTabObjLst = new List<clsvPrjTabEN>();
            IEnumerable<clsvPrjTabEN> arrvPrjTabObjLst_Sel1 =
            from objvPrjTabEN in arrvPrjTabObjLstCache
            where objvPrjTabEN.SqlDsTypeId == "01"
            orderby objvPrjTabEN.TabName
            select objvPrjTabEN;
            List<clsvPrjTabEN> arrvPrjTabObjLst_Sel = new List<clsvPrjTabEN>();
            foreach (clsvPrjTabEN obj in arrvPrjTabObjLst_Sel1)
            {
                arrvPrjTabObjLst_Sel.Add(obj);
            }
            return arrvPrjTabObjLst_Sel;


            //if (arrPrjTabObjLst == null)
            //{
            //    StringBuilder strCondition = new StringBuilder();
            //    strCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            //    strCondition.AppendFormat(" and SqlDsTypeId = '01'");

            //    arrPrjTabObjLst = clsvPrjTabBL.GetObjLst(strCondition.ToString() + " Order by TabName");
            //}

            //return arrPrjTabObjLst;
        }

        public static List<clsvPrjTabEN> GetPrjViewObjLst(string strPrjId)
        {
            //string strWhereCond = string.Format("{0} = '{1}' ",
            //   clsvPrjTabEN.con_PrjId, strPrjId);
            //if (clsvPrjTabBL.arrvPrjTabObjLstCache == null)
            //{
            //    clsvPrjTabBL.arrvPrjTabObjLstCache = new clsvPrjTabDA().GetObjLst(strWhereCond);
            //}
            //InitListCache();
            //string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
            List<clsvPrjTabEN> arrvPrjTabObjLstCache = GetObjLstCache(strPrjId); 

            List<clsvPrjTabEN> arrvPrjTabObjLst = new List<clsvPrjTabEN>();
            IEnumerable<clsvPrjTabEN> arrvPrjTabObjLst_Sel1 =
            from objvPrjTabEN in arrvPrjTabObjLstCache
            where objvPrjTabEN.SqlDsTypeId == "02"
            orderby objvPrjTabEN.TabName
            select objvPrjTabEN;
            List<clsvPrjTabEN> arrvPrjTabObjLst_Sel = new List<clsvPrjTabEN>();
            foreach (clsvPrjTabEN obj in arrvPrjTabObjLst_Sel1)
            {
                arrvPrjTabObjLst_Sel.Add(obj);
            }
            return arrvPrjTabObjLst_Sel;

            //if (arrPrjViewObjLst == null)
            //{
            //    StringBuilder strCondition = new StringBuilder();
            //    strCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            //    strCondition.AppendFormat(" and SqlDsTypeId = '02'");

            //    arrPrjViewObjLst = clsvPrjTabBL.GetObjLst(strCondition.ToString() + " Order by TabName");
            //}
            //return arrPrjViewObjLst;
        }

        public static List<clsvPrjTabEN> GetPrjTabViewObjLst(string strPrjId, string strSqlDsTypeId)
        {
            if (strSqlDsTypeId == clsSQLDSTypeENEx.SQLTAB)
            {
                return GetPrjTabObjLst(strPrjId);
            }
            else if (strSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
            {
                return GetPrjViewObjLst(strPrjId);
            }
            return null;
        }
        public static List<clsvPrjTabEN> GetPrjTabViewObjLst(string strPrjId)
        {
            List<clsvPrjTabEN> arrPrjTabViewObjLst = null;
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            arrPrjTabViewObjLst = clsvPrjTabBL.GetObjLst(strCondition.ToString() + " Order by TabName");

            return arrPrjTabViewObjLst;
        }

    }
}