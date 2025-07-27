
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFunction4CodeBLEx
表名:vFunction4Code
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:32:55
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
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

    public static class clsvFunction4CodeBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objvFunction4CodeENS">源对象</param>
        /// <returns>目标对象=>clsvFunction4CodeEN:objvFunction4CodeENT</returns>
        public static clsFunction4CodeEN CopyToFromViewToTab(this clsvFunction4CodeEN objvFunction4CodeENS)
        {
            try
            {
                clsFunction4CodeEN objFunction4CodeENT = new clsFunction4CodeEN();
                objFunction4CodeENT.FuncId4Code = objvFunction4CodeENS.FuncId4Code; //函数Id4Code
                objFunction4CodeENT.FuncName4Code = objvFunction4CodeENS.FuncName4Code; //函数名4Code
                objFunction4CodeENT.FuncCHName4Code = objvFunction4CodeENS.FuncCHName4Code; //函数中文名4Code
                objFunction4CodeENT.PrevFuncId = objvFunction4CodeENS.PrevFuncId; //前函数Id
                objFunction4CodeENT.RootFuncId = objvFunction4CodeENS.RootFuncId; //根函数Id
                objFunction4CodeENT.ApplicationTypeId = objvFunction4CodeENS.ApplicationTypeId; //应用程序类型ID
                //objFunction4CodeENT.ApplicationTypeName = objvFunction4CodeENS.ApplicationTypeName; //应用程序类型名称
                objFunction4CodeENT.FuncGCTypeId = objvFunction4CodeENS.FuncGCTypeId; //函数生成代码类型Id
                //objFunction4CodeENT.FuncGCTypeName = objvFunction4CodeENS.FuncGCTypeName; //函数生成代码类型名
                //objFunction4CodeENT.FuncGCTypeENName = objvFunction4CodeENS.FuncGCTypeENName; //函数生成代码类型英文名
                objFunction4CodeENT.FunctionSignature = objvFunction4CodeENS.FunctionSignature; //函数签名
                objFunction4CodeENT.ReturnType = objvFunction4CodeENS.ReturnType; //返回类型
                objFunction4CodeENT.ReturnTypeId = objvFunction4CodeENS.ReturnTypeId; //返回类型ID
                objFunction4CodeENT.ReturnTypeNameCustom = objvFunction4CodeENS.ReturnTypeNameCustom; //定制返回类型名
                objFunction4CodeENT.CodeTypeId = objvFunction4CodeENS.CodeTypeId; //代码类型Id
                //objFunction4CodeENT.CodeTypeName = objvFunction4CodeENS.CodeTypeName; //代码类型名
                //objFunction4CodeENT.ProgLangTypeId = objvFunction4CodeENS.ProgLangTypeId; //编程语言类型Id
                objFunction4CodeENT.FuncAccessModeId = objvFunction4CodeENS.FuncAccessModeId; //函数操作模式Id
                //objFunction4CodeENT.FuncAccessModeName = objvFunction4CodeENS.FuncAccessModeName; //函数操作模式名
                objFunction4CodeENT.TabName = objvFunction4CodeENS.TabName; //表名
                objFunction4CodeENT.ClsName = objvFunction4CodeENS.ClsName; //类名
                objFunction4CodeENT.FuncTypeId = objvFunction4CodeENS.FuncTypeId; //函数类型ID
                //objFunction4CodeENT.FuncTypeName = objvFunction4CodeENS.FuncTypeName; //函数类型名
                objFunction4CodeENT.IsAsyncFunc = objvFunction4CodeENS.IsAsyncFunc; //是否异步函数
                objFunction4CodeENT.IsSysFunction = objvFunction4CodeENS.IsSysFunction; //是否系统函数
                objFunction4CodeENT.OrderNum = objvFunction4CodeENS.OrderNum; //序号
                objFunction4CodeENT.PrjId = objvFunction4CodeENS.PrjId; //工程ID
                objFunction4CodeENT.UpdDate = objvFunction4CodeENS.UpdDate; //修改日期
                objFunction4CodeENT.UpdUser = objvFunction4CodeENS.UpdUser; //修改者
                objFunction4CodeENT.Memo = objvFunction4CodeENS.Memo; //说明
                //objFunction4CodeENT.ReturnTypeName = objvFunction4CodeENS.ReturnTypeName; //返回类型名
                //objFunction4CodeENT.Func4GCCount = objvFunction4CodeENS.Func4GCCount; //函数4GC数
                //objFunction4CodeENT.ParaNum = objvFunction4CodeENS.ParaNum; //参数个数
                //objFunction4CodeENT.FeatureCount = objvFunction4CodeENS.FeatureCount; //功能数



                return objFunction4CodeENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvFunction4CodeENS">源对象</param>
        /// <returns>目标对象=>clsvFunction4CodeEN:objvFunction4CodeENT</returns>
        public static clsvFunction4CodeENEx CopyToEx(this clsvFunction4CodeEN objvFunction4CodeENS)
        {
            try
            {
                clsvFunction4CodeENEx objvFunction4CodeENT = new clsvFunction4CodeENEx();
                clsvFunction4CodeBL.CopyTo(objvFunction4CodeENS, objvFunction4CodeENT);
                return objvFunction4CodeENT;
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
        /// <param name = "objvFunction4CodeENS">源对象</param>
        /// <returns>目标对象=>clsvFunction4CodeEN:objvFunction4CodeENT</returns>
        public static clsvFunction4CodeEN CopyTo(this clsvFunction4CodeENEx objvFunction4CodeENS)
        {
            try
            {
                clsvFunction4CodeEN objvFunction4CodeENT = new clsvFunction4CodeEN();
                clsvFunction4CodeBL.CopyTo(objvFunction4CodeENS, objvFunction4CodeENT);
                return objvFunction4CodeENT;
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
    /// v函数4Code(vFunction4Code)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvFunction4CodeBLEx : clsvFunction4CodeBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFunction4CodeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFunction4CodeDAEx vFunction4CodeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFunction4CodeDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据函数名称获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFuncName4Code">所给的函数名称</param>
        /// <returns>根据函数名称获取的对象</returns>
        public static clsvFunction4CodeEN GetObjByFuncName4CodeCache(string strFuncName4Code)
        {
            if (string.IsNullOrEmpty(strFuncName4Code) == true) return null;
            //初始化列表缓存
            List<clsvFunction4CodeEN> arrObjLstCache = clsvFunction4CodeBL.GetObjLstCache();

            IEnumerable<clsvFunction4CodeEN> arrFunction4CodeObjLst_Sel1 =
            from objFunction4CodeEN in arrObjLstCache
            where objFunction4CodeEN.FuncName4Code == strFuncName4Code
            select objFunction4CodeEN;
            List<clsvFunction4CodeEN> arrFunction4CodeObjLst_Sel = new List<clsvFunction4CodeEN>();
            foreach (clsvFunction4CodeEN obj in arrFunction4CodeObjLst_Sel1)
            {
                arrFunction4CodeObjLst_Sel.Add(obj);
            }
            if (arrFunction4CodeObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrFunction4CodeObjLst_Sel[0];
        }

        /// <summary>
        /// 判断在一个函数对象列表中，是否存在某一个函数名的对象
        /// </summary>
        /// <param name="arrvFunction4CodeObjLst">函数对象列表</param>
        /// <param name="strFuncName4Code">所给的函数名</param>
        /// <returns></returns>
        public static bool IsExistFuncNameInObjLst(List<clsvFunction4CodeEN> arrvFunction4CodeObjLst, string strFuncName4Code)
        {
            foreach (clsvFunction4CodeEN objFunction4CodeEN in arrvFunction4CodeObjLst)
            {
                if (objFunction4CodeEN.FuncName4Code == strFuncName4Code) return true;
            }
            return false;
        }

        /// <summary>
        /// 根据功能Id获取函数对象列表
        /// </summary>
        /// <param name="strFeatureId">功能Id</param>
        /// <returns>函数对象列表</returns>
        public static List<clsvFunction4CodeEN> GetObjLstByFeatureIdBak(string strFeatureId)
        {
            string strCondtion = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                convFunction4Code.FuncId4Code,
                clsFeatureFuncRelaEN._CurrTabName,
                conFeatureFuncRela.FeatureId,
                strFeatureId);
            List<clsvFunction4CodeEN> arrFunction4CodeObjLst = clsvFunction4CodeBLEx.GetObjLst(strCondtion);
            return arrFunction4CodeObjLst;
        }


        public static List<clsvFunction4CodeEN> GetObjLstByFeatureIdCacheBak20200204(string strFeatureId)
        {
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                convFunction4Code.FuncId4Code,
                clsFeatureFuncRelaEN._CurrTabName,
                conFeatureFuncRela.FeatureId,
                strFeatureId);
            List<clsFeatureFuncRelaEN> arrFeatureFuncRelaCache = clsFeatureFuncRelaBL.GetObjLstCache();
            List<clsFeatureFuncRelaEN> arrFeatureFuncRela = arrFeatureFuncRelaCache.Where(x=>x.FeatureId == strFeatureId).ToList();
            List<string> arrFuncId4GC = arrFeatureFuncRela.Select(x => x.FuncId4GC)
                .ToList();    
            strCondition = string.Format("{0}='{1}'", convFunction4Code.FuncPurposeId, enumFunctionPurpose.GeneCode_01);

            string strKey = string.Format("{0}_GeneCode", clsvFunction4CodeEN._CurrTabName);
            List<clsvFunction4CodeEN> arrvFunction4CodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
            //return arrFeatureFuncRelaObjLstCache;

            List<clsvFunction4CodeEN> arrFunction4CodeObjLst = arrvFunction4CodeObjLstCache.Where(x=> arrFuncId4GC.Contains(x.FuncId4Code)).ToList();
            return arrFunction4CodeObjLst;
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetDataTable4Tab)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>返回数据表,用DataTable表示</returns>
        public static DataTable GetDataTableByAppId(string strWhereCond, int intApplicationTypeId)
        {
            DataTable objDT = null;
            try
            {
                objDT = vFunction4CodeDAEx.GetDataTableByAppId(strWhereCond, intApplicationTypeId);
                return objDT;
            }
            catch (Exception objException)
            {
                    string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {2}, intApplicationTypeId=[{4}])({0}->{1})\r\n{3}",
                clsStackTrace.GetCurrClassFunctionByLevel(2),
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message,
                intApplicationTypeId);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFuncId4Code">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsvFunction4CodeEN> GetObjByFuncId4CodeCacheExBak(string strFeatureId)
        {
            if (string.IsNullOrEmpty(strFeatureId) == true) return null;
            //初始化列表缓存
            List<clsvFunction4CodeEN> arrObjLstCache = clsvFunction4CodeBL.GetObjLstCache();

            IEnumerable<clsvFunction4CodeEN> arrvFunction4CodeObjLst_Sel1 =
            from objvFunction4CodeEN in arrObjLstCache
            where objvFunction4CodeEN.FuncId4Code == strFeatureId
            select objvFunction4CodeEN;
            List<clsvFunction4CodeEN> arrvFunction4CodeObjLst_Sel = new List<clsvFunction4CodeEN>();
            foreach (clsvFunction4CodeEN obj in arrvFunction4CodeObjLst_Sel1)
            {
                arrvFunction4CodeObjLst_Sel.Add(obj);
            }
            //if (arrvFunction4CodeObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return arrvFunction4CodeObjLst_Sel;
        }

    }
 
    }