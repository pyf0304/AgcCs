
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvCMFeatureRequirementBLEx
表名:vCMFeatureRequirement(00050521)
生成代码版本:2020.01.06.1
生成日期:2020/01/11 15:55:04
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:代码管理
模块英文名:CodeMan
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
    public static class clsvCMFeatureRequirementBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvCMFeatureRequirementENS">源对象</param>
        /// <returns>目标对象=>clsvCMFeatureRequirementEN:objvCMFeatureRequirementENT</returns>
        public static clsvCMFeatureRequirementENEx CopyToEx(this clsvCMFeatureRequirementEN objvCMFeatureRequirementENS)
        {
            try
            {
                clsvCMFeatureRequirementENEx objvCMFeatureRequirementENT = new clsvCMFeatureRequirementENEx();
                clsvCMFeatureRequirementBL.vCMFeatureRequirementDA.CopyTo(objvCMFeatureRequirementENS, objvCMFeatureRequirementENT);
                return objvCMFeatureRequirementENT;
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
        /// <param name = "objvCMFeatureRequirementENS">源对象</param>
        /// <returns>目标对象=>clsvCMFeatureRequirementEN:objvCMFeatureRequirementENT</returns>
        public static clsvCMFeatureRequirementEN CopyTo(this clsvCMFeatureRequirementENEx objvCMFeatureRequirementENS)
        {
            try
            {
                clsvCMFeatureRequirementEN objvCMFeatureRequirementENT = new clsvCMFeatureRequirementEN();
                clsvCMFeatureRequirementBL.CopyTo(objvCMFeatureRequirementENS, objvCMFeatureRequirementENT);
                return objvCMFeatureRequirementENT;
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
    /// vCM功能需求关系(vCMFeatureRequirement)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvCMFeatureRequirementBLEx : clsvCMFeatureRequirementBL
    {
        public static string strPrjIdCache_Init = "";
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvCMFeatureRequirementDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvCMFeatureRequirementDAEx vCMFeatureRequirementDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvCMFeatureRequirementDAEx();
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
        public static List<clsvCMFeatureRequirementENEx> GetObjExLst(string strCondition)
        {
            List<clsvCMFeatureRequirementEN> arrObjLst = clsvCMFeatureRequirementBL.GetObjLst(strCondition);
            List<clsvCMFeatureRequirementENEx> arrObjExLst = new List<clsvCMFeatureRequirementENEx>();
            foreach (clsvCMFeatureRequirementEN objInFor in arrObjLst)
            {
                clsvCMFeatureRequirementENEx objvCMFeatureRequirementENEx = new clsvCMFeatureRequirementENEx();
                clsvCMFeatureRequirementBL.CopyTo(objInFor, objvCMFeatureRequirementENEx);
                arrObjExLst.Add(objvCMFeatureRequirementENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvCMFeatureRequirementENEx GetObjExBymId(long lngmId)
        {
            clsvCMFeatureRequirementEN objvCMFeatureRequirementEN = clsvCMFeatureRequirementBL.GetObjBymId(lngmId);
            clsvCMFeatureRequirementENEx objvCMFeatureRequirementENEx = new clsvCMFeatureRequirementENEx();
            clsvCMFeatureRequirementBL.CopyTo(objvCMFeatureRequirementEN, objvCMFeatureRequirementENEx);
            return objvCMFeatureRequirementENEx;
        }
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsCMFeatureRequirementBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsCMFeatureRequirementBL没有刷新缓存机制(clsCMFeatureRequirementBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsFuncModule_AgcBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsCMRequirementBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsCMRequirementBL没有刷新缓存机制(clsCMRequirementBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsCMRequirementTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsCMRequirementTypeBL没有刷新缓存机制(clsCMRequirementTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsCMFeatureBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsCMFeatureBL没有刷新缓存机制(clsCMFeatureBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsCMFeatureTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsCMFeatureTypeBL没有刷新缓存机制(clsCMFeatureTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsProjectsBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsApplicationTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsUseStateBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsCMProjectBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrvCMFeatureRequirementObjLstCache = null;

        //    //初始化列表缓存
        //    string strWhereCond = string.Format("{0} = '{1}' order by mId", convCMFeatureRequirement.PrjId, strPrjId);
        //    if (arrvCMFeatureRequirementObjLstCache == null)
        //    {
        //        arrvCMFeatureRequirementObjLstCache = vCMFeatureRequirementDA.GetObjLst(strWhereCond);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strCmFeatureId">所给的关键字</param>
        /// <param name = "strPrjId">所给的PrjId</param>
        /// <returns>根据关键字获取的对象列表</returns>
        public static IEnumerable<clsvCMFeatureRequirementEN> GetObjLstByCmFeatureIdCache(string strCmFeatureId, string strPrjId)
        {
            //初始化列表缓存
            List<clsvCMFeatureRequirementEN> arrObjLstCache = clsvCMFeatureRequirementBL.GetObjLstCache(strPrjId);

            IEnumerable<clsvCMFeatureRequirementEN> arrvCMFeatureRequirementObjLst_Sel =
                    arrObjLstCache
            .Where(x => x.CmFeatureId == strCmFeatureId);


            //if (arrvCMFeatureRequirementObjLst_Sel.Count() == 0)
            //{
            //    clsvCMFeatureRequirementEN obj = clsvCMFeatureRequirementBL.GetObjBymId(lngmId);
            //    if (obj != null)
            //    {
            //        clsvCMFeatureRequirementBL.arrvCMFeatureRequirementObjLstCache = null;
            //        return obj;
            //    }
            //    return null;
            //}
            return arrvCMFeatureRequirementObjLst_Sel;
        }

    }
}