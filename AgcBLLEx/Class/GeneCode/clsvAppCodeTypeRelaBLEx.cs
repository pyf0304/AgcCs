
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvAppCodeTypeRelaBLEx
表名:vAppCodeTypeRela(00050419)
生成代码版本:2018.09.02.1
生成日期:2018/09/03 08:09:43
生成者:潘以锋
生成服务器IP:202.121.63.42
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:工程管理
模块英文名:PrjManage
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
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
    /// <summary>
    /// vAppCodeTypeRela(vAppCodeTypeRela)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvAppCodeTypeRelaBLEx : clsvAppCodeTypeRelaBL
    {
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
        /// </summary>
        public static List<clsvAppCodeTypeRelaENEx> arrvAppCodeTypeRelaObjExLstCache = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvAppCodeTypeRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvAppCodeTypeRelaDAEx vAppCodeTypeRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvAppCodeTypeRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
        /// </summary>
        public static void InitListCacheEx()
        {
            //检查缓存刷新机制
            string strMsg = "";
            if (clsApplicationTypeBL.objCommFun4BL == null)
            {
                strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsAppCodeTypeRelaBL.objCommFun4BL == null)
            {
                strMsg = string.Format("类clsAppCodeTypeRelaBL没有刷新缓存机制(clsAppCodeTypeRelaBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsCodeTypeBL.objCommFun4BL == null)
            {
                strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (clsProgLangTypeBL.objCommFun4BL == null)
            {
                strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //初始化列表缓存
            string strWhereCond = string.Format("1 = 1 order by mId");
            if (arrvAppCodeTypeRelaObjExLstCache == null)
            {
                arrvAppCodeTypeRelaObjExLstCache = GetObjExLst(strWhereCond);
            }
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsvAppCodeTypeRelaENEx> GetObjExLstByApplicationTypeIdExCache(int intApplicationTypeId)
        {
            //初始化列表缓存
            InitListCacheEx();
            IEnumerable<clsvAppCodeTypeRelaENEx> arrvAppCodeTypeRelaObjLst_Sel1 =
            from objvAppCodeTypeRelaEN in clsvAppCodeTypeRelaBLEx.arrvAppCodeTypeRelaObjExLstCache
            where objvAppCodeTypeRelaEN.ApplicationTypeId == intApplicationTypeId
            select objvAppCodeTypeRelaEN;
            List<clsvAppCodeTypeRelaENEx> arrvAppCodeTypeRelaObjLst_Sel = new List<clsvAppCodeTypeRelaENEx>();
            foreach (clsvAppCodeTypeRelaENEx obj in arrvAppCodeTypeRelaObjLst_Sel1)
            {
                arrvAppCodeTypeRelaObjLst_Sel.Add(obj);
            }
            if (arrvAppCodeTypeRelaObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvAppCodeTypeRelaObjLst_Sel;
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvAppCodeTypeRelaENEx> GetObjExLstByApplicationTypeId(int intApplicationTypeId)
        {
            string strCondition = string.Format("{0}={1}", convAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId);
            List<clsvAppCodeTypeRelaEN> arrObjLst = clsvAppCodeTypeRelaBL.GetObjLst(strCondition);
            List<clsvAppCodeTypeRelaENEx> arrObjExLst = new List<clsvAppCodeTypeRelaENEx>();
            foreach (clsvAppCodeTypeRelaEN objInFor in arrObjLst)
            {
                clsvAppCodeTypeRelaENEx objvAppCodeTypeRelaENEx = new clsvAppCodeTypeRelaENEx();
                clsvAppCodeTypeRelaBL.CopyTo(objInFor, objvAppCodeTypeRelaENEx);
                arrObjExLst.Add(objvAppCodeTypeRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvAppCodeTypeRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsvAppCodeTypeRelaEN> arrObjLst = clsvAppCodeTypeRelaBL.GetObjLst(strCondition);
            List<clsvAppCodeTypeRelaENEx> arrObjExLst = new List<clsvAppCodeTypeRelaENEx>();
            foreach (clsvAppCodeTypeRelaEN objInFor in arrObjLst)
            {
                clsvAppCodeTypeRelaENEx objvAppCodeTypeRelaENEx = new clsvAppCodeTypeRelaENEx();
                clsvAppCodeTypeRelaBL.CopyTo(objInFor, objvAppCodeTypeRelaENEx);
                arrObjExLst.Add(objvAppCodeTypeRelaENEx);
            }
            return arrObjExLst;
        }
        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvAppCodeTypeRelaENEx GetObjExBymId(long lngmId)
        {
            clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = clsvAppCodeTypeRelaBL.GetObjBymId(lngmId);
            clsvAppCodeTypeRelaENEx objvAppCodeTypeRelaENEx = new clsvAppCodeTypeRelaENEx();
            clsvAppCodeTypeRelaBL.CopyTo(objvAppCodeTypeRelaEN, objvAppCodeTypeRelaENEx);
            return objvAppCodeTypeRelaENEx;
        }
    }
}
