
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvwf_StepProcessRelaBLEx
表名:vwf_StepProcessRela(00050494)
生成代码版本:2019.08.22.1
生成日期:2019/08/25 10:24:46
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:工作流管理
模块英文名:WorkFlow
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
    /// <summary>
    /// 
    /// </summary>
    public static class clsvwf_StepProcessRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvwf_StepProcessRelaENS">源对象</param>
        /// <returns>目标对象=>clsvwf_StepProcessRelaEN:objvwf_StepProcessRelaENT</returns>
        public static clsvwf_StepProcessRelaENEx CopyToEx(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENS)
        {
            try
            {
                clsvwf_StepProcessRelaENEx objvwf_StepProcessRelaENT = new clsvwf_StepProcessRelaENEx();
                clsvwf_StepProcessRelaBL.CopyTo(objvwf_StepProcessRelaENS, objvwf_StepProcessRelaENT);
                return objvwf_StepProcessRelaENT;
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
        /// <param name = "objvwf_StepProcessRelaENS">源对象</param>
        /// <returns>目标对象=>clsvwf_StepProcessRelaEN:objvwf_StepProcessRelaENT</returns>
        public static clsvwf_StepProcessRelaEN CopyTo(this clsvwf_StepProcessRelaENEx objvwf_StepProcessRelaENS)
        {
            try
            {
                clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENT = new clsvwf_StepProcessRelaEN();
                clsvwf_StepProcessRelaBL.CopyTo(objvwf_StepProcessRelaENS, objvwf_StepProcessRelaENT);
                return objvwf_StepProcessRelaENT;
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
    /// v工作流步骤过程关系(vwf_StepProcessRela)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvwf_StepProcessRelaBLEx : clsvwf_StepProcessRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvwf_StepProcessRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvwf_StepProcessRelaDAEx vwf_StepProcessRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvwf_StepProcessRelaDAEx();
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
        public static List<clsvwf_StepProcessRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsvwf_StepProcessRelaEN> arrObjLst = clsvwf_StepProcessRelaBL.GetObjLst(strCondition);
            List<clsvwf_StepProcessRelaENEx> arrObjExLst = new List<clsvwf_StepProcessRelaENEx>();
            foreach (clsvwf_StepProcessRelaEN objInFor in arrObjLst)
            {
                clsvwf_StepProcessRelaENEx objvwf_StepProcessRelaENEx = new clsvwf_StepProcessRelaENEx();
                clsvwf_StepProcessRelaBL.CopyTo(objInFor, objvwf_StepProcessRelaENEx);
                arrObjExLst.Add(objvwf_StepProcessRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngWorkFlowStepProcessRelaId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvwf_StepProcessRelaENEx GetObjExByWorkFlowStepProcessRelaId(long lngWorkFlowStepProcessRelaId)
        {
            clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = clsvwf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(lngWorkFlowStepProcessRelaId);
            clsvwf_StepProcessRelaENEx objvwf_StepProcessRelaENEx = new clsvwf_StepProcessRelaENEx();
            clsvwf_StepProcessRelaBL.CopyTo(objvwf_StepProcessRelaEN, objvwf_StepProcessRelaENEx);
            return objvwf_StepProcessRelaENEx;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWorkFlowId"></param>
        /// <returns></returns>
        public static IEnumerable<clsvwf_StepProcessRelaEN> GetObjLstByWorkFlowId(string strWorkFlowId)
        {
            string strCondition = string.Format("{0}='{1}'", convwf_StepProcessRela.WorkFlowId, strWorkFlowId);
            List<clsvwf_StepProcessRelaEN> arrObjLst = clsvwf_StepProcessRelaBL.GetObjLst(strCondition);
            return arrObjLst;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWorkFlowId"></param>
        /// <returns></returns>
        public static IEnumerable<clsvwf_StepProcessRelaEN> GetObjLstByWorkFlowIdCache(string strWorkFlowId)
        {
            //初始化列表缓存
            List<clsvwf_StepProcessRelaEN> arrObjLstCache = clsvwf_StepProcessRelaBL.GetObjLstCache();

            IEnumerable<clsvwf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst_Sel =
            arrObjLstCache
            .Where(x => x.WorkFlowId == strWorkFlowId);
            return arrwf_StepProcessRelaObjLst_Sel;
        }


    }
}