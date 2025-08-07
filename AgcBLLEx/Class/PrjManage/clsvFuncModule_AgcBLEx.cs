
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFuncModule_AgcBLEx
表名:vFuncModule_Agc
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC
工程ID:0005
模块中文名:工程管理
模块英文名:PrjManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
    /// v功能模块_Agc(vFuncModule_Agc)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvFuncModule_AgcBLEx : clsvFuncModule_AgcBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFuncModule_AgcDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFuncModule_AgcDAEx vFuncModule_AgcDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFuncModule_AgcDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsProjectsBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsFuncModule_AgcBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    //if (clsPrjObjectsBL.objCommFun4BL == null)
        //    //{
        //    //    strMsg = string.Format("类clsPrjObjectsBL没有刷新缓存机制(clsPrjObjectsBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //    //    throw new Exception(strMsg);
        //    //}
        //    if (clsPrjTabBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsViewInfoBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsViewInfoBL没有刷新缓存机制(clsViewInfoBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    //初始化列表缓存
        //    string strWhereCond = string.Format("PrjId = '{0}' order by FuncModuleAgcId", clsvFuncModule_AgcEN.con_PrjId);
        //    if (clsvFuncModule_AgcBL.arrvFuncModule_AgcObjLstCache == null)
        //    {
        //        clsvFuncModule_AgcBL.arrvFuncModule_AgcObjLstCache = clsvFuncModule_AgcBL.GetObjLst(strWhereCond);
        //    }
        //}
        /// <summary>
        /// 获取功能模块对象列表
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <returns></returns>
        public static List<clsvFuncModule_AgcEN> GetFuncModuleObjLst(string strPrjId)
        {
            List<clsvFuncModule_AgcEN> arrObjLstCache = clsvFuncModule_AgcBL.GetObjLstCache(strPrjId).Where(x=>x.PrjId == strPrjId).ToList();

            return arrObjLstCache;
        }
    }
}