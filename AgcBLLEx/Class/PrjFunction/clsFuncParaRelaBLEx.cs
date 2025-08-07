
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFuncParaRelaBLEx
表名:FuncParaRela(00050498)
生成代码版本:2019.08.30.1
生成日期:2019/09/14 15:54:26
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

using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    public static class clsFuncParaRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objFuncParaRelaENS">源对象</param>
        /// <returns>目标对象=>clsFuncParaRelaEN:objFuncParaRelaENT</returns>
        public static clsFuncParaRelaENEx CopyToEx(this clsFuncParaRelaEN objFuncParaRelaENS)
        {
            try
            {
                clsFuncParaRelaENEx objFuncParaRelaENT = new clsFuncParaRelaENEx();
                clsFuncParaRelaBL.CopyTo(objFuncParaRelaENS, objFuncParaRelaENT);
                return objFuncParaRelaENT;
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
        /// <param name = "objFuncParaRelaENS">源对象</param>
        /// <returns>目标对象=>clsFuncParaRelaEN:objFuncParaRelaENT</returns>
        public static clsFuncParaRelaEN CopyTo(this clsFuncParaRelaENEx objFuncParaRelaENS)
        {
            try
            {
                clsFuncParaRelaEN objFuncParaRelaENT = new clsFuncParaRelaEN();
                clsFuncParaRelaBL.CopyTo(objFuncParaRelaENS, objFuncParaRelaENT);
                return objFuncParaRelaENT;
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
    /// FuncParaRela(FuncParaRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsFuncParaRelaBLEx : clsFuncParaRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFuncParaRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFuncParaRelaDAEx FuncParaRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFuncParaRelaDAEx();
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
        public static List<clsFuncParaRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsFuncParaRelaEN> arrObjLst = clsFuncParaRelaBL.GetObjLst(strCondition);
            List<clsFuncParaRelaENEx> arrObjExLst = new List<clsFuncParaRelaENEx>();
            foreach (clsFuncParaRelaEN objInFor in arrObjLst)
            {
                clsFuncParaRelaENEx objFuncParaRelaENEx = new clsFuncParaRelaENEx();
                clsFuncParaRelaBL.CopyTo(objInFor, objFuncParaRelaENEx);
                arrObjExLst.Add(objFuncParaRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsFuncParaRelaENEx GetObjExBymId(long lngmId)
        {
            clsFuncParaRelaEN objFuncParaRelaEN = clsFuncParaRelaBL.GetObjBymId(lngmId);
            clsFuncParaRelaENEx objFuncParaRelaENEx = new clsFuncParaRelaENEx();
            clsFuncParaRelaBL.CopyTo(objFuncParaRelaEN, objFuncParaRelaENEx);
            return objFuncParaRelaENEx;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strFuncId4Code"></param>
        /// <returns></returns>
        public static List<string> GetmIdLstByFuncId4Code(string strFuncId4Code)
        {
            string strCondition = string.Format("{0}='{1}'", conFuncParaRela.FuncId4Code, strFuncId4Code);

            List<string> arrmIdLst = clsFuncParaRelaBL.GetFldValue(conFuncParaRela.mId, strCondition);
            return arrmIdLst;
        }

        /// <summary>
        /// 根据函数Id4Code获取相关参数对象列表, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFuncId4Code">函数Id4Code</param>
        /// <returns>根据函数Id4Code获取相关参数对象列表</returns>
        public static List<clsFuncParaRelaEN> GetObjListByFuncId4CodeCacheEx(string strFuncId4Code)
        {
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return null;
            //初始化列表缓存
            List<clsFuncParaRelaEN> arrObjLstCache = clsFuncParaRelaBL.GetObjLstCache();

            IEnumerable<clsFuncParaRelaEN> arrFuncParaRelaObjLst_Sel1 =
            from objFuncParaRelaEN in arrObjLstCache
            where objFuncParaRelaEN.FuncId4Code == strFuncId4Code
            select objFuncParaRelaEN;
            List<clsFuncParaRelaEN> arrFuncParaRelaObjLst_Sel = new List<clsFuncParaRelaEN>();
            foreach (clsFuncParaRelaEN obj in arrFuncParaRelaObjLst_Sel1)
            {
                arrFuncParaRelaObjLst_Sel.Add(obj);
            }
            if (arrFuncParaRelaObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrFuncParaRelaObjLst_Sel;
        }

        /// <summary>
        /// 根据函数Id4Code获取相关参数对象列表, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFuncId4Code">函数Id4Code</param>
        /// <returns>根据函数Id4Code获取相关参数对象列表</returns>
        public static IEnumerable<string> GetFuncParaIdLstByFuncId4CodeCacheEx(string strFuncId4Code)
        {
            if (string.IsNullOrEmpty(strFuncId4Code) == true) return null;
            //初始化列表缓存
            List<clsFuncParaRelaEN> arrObjLstCache = clsFuncParaRelaBL.GetObjLstCache();

            IEnumerable<clsFuncParaRelaEN> arrFuncParaRelaObjLst_Sel1 =
            from objFuncParaRelaEN in arrObjLstCache
            where objFuncParaRelaEN.FuncId4Code == strFuncId4Code
            select objFuncParaRelaEN;
            if (arrFuncParaRelaObjLst_Sel1.Count() == 0)
            {
                return null;
            }
            arrFuncParaRelaObjLst_Sel1 = arrFuncParaRelaObjLst_Sel1.OrderBy(x => x.OrderNum);

            IEnumerable<string> arrFuncParaId4Code = arrFuncParaRelaObjLst_Sel1
                .OrderBy(x=>x.OrderNum)
                .Select(x=>x.FuncParaId4Code);
            return arrFuncParaId4Code;
        }
        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="lngMid">strFuncParaId4Code</param>
        /// <returns></returns>
        public static clsFuncParaRelaEN CloneRecord(long lngMid, string strUserId)
        {
            clsFuncParaRelaEN objFuncParaRelaEN = clsFuncParaRelaBL.GetObjBymId(lngMid);

            //objFuncParaRelaEN.FuncParaId4Code = clsFuncParaRelaBL.GetMaxStrId_S();
            //objFuncParaRelaEN.ParaName = "Copy_" + objFuncParaRelaEN.ParaName;
            objFuncParaRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFuncParaRelaEN.UpdUser = strUserId;
            //if (string.IsNullOrEmpty(obj.ReturnTypeId))
            //{
            //    obj.ReturnTypeId = "29";
            //}
            try
            {
                clsFuncParaRelaBL.AddNewRecordBySql2(objFuncParaRelaEN);
                return objFuncParaRelaEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(mId:{1})({2})",
                     objException.Message,
                     lngMid,
                     clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        public static clsFuncParaRelaEN CloneRecordFromTemplate(long lngMid, string strUserId)
        {
            clsFuncParaRelaEN objFuncParaRelaEN = clsFuncParaRelaBL.GetObjBymId(lngMid);

            //objFuncParaRelaEN.FuncParaId4Code = clsFuncParaRelaBL.GetMaxStrId_S();
            //objFuncParaRelaEN.ParaName = "Copy_" + objFuncParaRelaEN.ParaName;
            objFuncParaRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFuncParaRelaEN.UpdUser = strUserId;
            //if (string.IsNullOrEmpty(obj.ReturnTypeId))
            //{
            //    obj.ReturnTypeId = "29";
            //}
            try
            {
                clsFuncParaRelaBL.AddNewRecordBySql2(objFuncParaRelaEN);
                return objFuncParaRelaEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(mId:{1})({2})",
                     objException.Message,
                     lngMid,
                     clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

    }
}
    