
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFuncParaRelaBLEx
表名:vFuncParaRela(00050499)
生成代码版本:2019.08.30.1
生成日期:2019/09/14 15:57:03
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:函数管理
模块英文名:PrjFunction
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;


using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;


namespace AGC.BusinessLogicEx
{
    public static class clsvFuncParaRelaBLEx_Static
    {
        public static string GetParaTypeName4Rela(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strProgLangTypeId)
        {
            clsDataTypeAbbrEN objDataTypeAbbr = null;
            string strParameterType = "";
            //            throw new NotImplementedException();
            switch (objvFuncParaRelaEN.DataTypeId)
            {
                case enumDataTypeAbbr.Object_29:
                    if (string.IsNullOrEmpty(objvFuncParaRelaEN.ParameterType) == false) return objvFuncParaRelaEN.ParameterType;
                    objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objvFuncParaRelaEN.DataTypeId);
                    return objDataTypeAbbr.GetTypeString(strProgLangTypeId);


                case enumDataTypeAbbr.ObjectLst_30:
                    strParameterType = objvFuncParaRelaEN.ParameterType.Replace("[", "<")
                              .Replace("]", ">");
                    if (string.IsNullOrEmpty(strParameterType) == false) return strParameterType;
                    objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objvFuncParaRelaEN.DataTypeId);
                    return objDataTypeAbbr.GetTypeString(strProgLangTypeId);
                case enumDataTypeAbbr.Array_31:
                    strParameterType = objvFuncParaRelaEN.ParameterType.Replace("[", "<")
                              .Replace("]", ">");
                    if (string.IsNullOrEmpty(strParameterType) == false) return strParameterType;
                    objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objvFuncParaRelaEN.DataTypeId);
                    return objDataTypeAbbr.GetTypeString(strProgLangTypeId);
                default:
                    objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objvFuncParaRelaEN.DataTypeId);
                    return objDataTypeAbbr.GetTypeString(strProgLangTypeId);
            }
            //return "";
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvFuncParaRelaENS">源对象</param>
        /// <returns>目标对象=>clsvFuncParaRelaEN:objvFuncParaRelaENT</returns>
        public static clsvFuncParaRelaENEx CopyToEx(this clsvFuncParaRelaEN objvFuncParaRelaENS)
        {
            try
            {
                clsvFuncParaRelaENEx objvFuncParaRelaENT = new clsvFuncParaRelaENEx();
                clsvFuncParaRelaBL.CopyTo(objvFuncParaRelaENS, objvFuncParaRelaENT);
                return objvFuncParaRelaENT;
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
        /// <param name = "objvFuncParaRelaENS">源对象</param>
        /// <returns>目标对象=>clsvFuncParaRelaEN:objvFuncParaRelaENT</returns>
        public static clsvFuncParaRelaEN CopyTo(this clsvFuncParaRelaENEx objvFuncParaRelaENS)
        {
            try
            {
                clsvFuncParaRelaEN objvFuncParaRelaENT = new clsvFuncParaRelaEN();
                clsvFuncParaRelaBL.CopyTo(objvFuncParaRelaENS, objvFuncParaRelaENT);
                return objvFuncParaRelaENT;
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
    /// vFuncParaRela(vFuncParaRela)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvFuncParaRelaBLEx : clsvFuncParaRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFuncParaRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFuncParaRelaDAEx vFuncParaRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFuncParaRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvFuncParaRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsvFuncParaRelaEN> arrObjLst = clsvFuncParaRelaBL.GetObjLst(strCondition);
            List<clsvFuncParaRelaENEx> arrObjExLst = new List<clsvFuncParaRelaENEx>();
            foreach (clsvFuncParaRelaEN objInFor in arrObjLst)
            {
                clsvFuncParaRelaENEx objvFuncParaRelaENEx = new clsvFuncParaRelaENEx();
                clsvFuncParaRelaBL.CopyTo(objInFor, objvFuncParaRelaENEx);
                arrObjExLst.Add(objvFuncParaRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvFuncParaRelaENEx GetObjExBymId(long lngmId)
        {
            clsvFuncParaRelaEN objvFuncParaRelaEN = clsvFuncParaRelaBL.GetObjBymId(lngmId);
            clsvFuncParaRelaENEx objvFuncParaRelaENEx = new clsvFuncParaRelaENEx();
            clsvFuncParaRelaBL.CopyTo(objvFuncParaRelaEN, objvFuncParaRelaENEx);
            return objvFuncParaRelaENEx;
        }

        /// <summary>
        /// 根据函数Id4Code获取相关参数对象列表, 从缓存的对象列表中获取.没有就返回null.     
        /// </summary>
        /// <param name = "strFuncId4Code">函数Id4Code</param>
        /// <returns>根据函数Id4Code获取相关参数对象列表</returns>
        public static List<clsvFuncParaRelaEN> GetObjListByFuncId4CodeCacheEx(string strFuncId4Code)
        {
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return null;

            //初始化列表缓存
            List<clsvFuncParaRelaEN> arrObjLstCache = clsvFuncParaRelaBL.GetObjLstCache();

            IEnumerable<clsvFuncParaRelaEN> arrFuncParaRelaObjLst_Sel1 =
            from objFuncParaRelaEN in arrObjLstCache
            where objFuncParaRelaEN.FuncId4Code == strFuncId4Code
            select objFuncParaRelaEN;
            if (arrFuncParaRelaObjLst_Sel1.Count() == 0)
            {
                return null;
            }
            arrFuncParaRelaObjLst_Sel1 = arrFuncParaRelaObjLst_Sel1.OrderBy(x => x.OrderNum);        
            return arrFuncParaRelaObjLst_Sel1.ToList();
        }

    }
}