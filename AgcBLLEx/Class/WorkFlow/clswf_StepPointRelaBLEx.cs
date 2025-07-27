
/*-- -- -- -- -- -- -- -- -- -- --
类名:clswf_StepPointRelaBLEx
表名:wf_StepPointRela(00050486)
生成代码版本:2019.08.22.1
生成日期:2019/08/25 10:24:36
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

using com.taishsoft.datetime;
//using System.Tuple;


namespace AGC.BusinessLogicEx
{
    public static class clswf_StepPointRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objwf_StepPointRelaENS">源对象</param>
        /// <returns>目标对象=>clswf_StepPointRelaEN:objwf_StepPointRelaENT</returns>
        public static clswf_StepPointRelaENEx CopyToEx(this clswf_StepPointRelaEN objwf_StepPointRelaENS)
        {
            try
            {
                clswf_StepPointRelaENEx objwf_StepPointRelaENT = new clswf_StepPointRelaENEx();
                clswf_StepPointRelaBL.CopyTo(objwf_StepPointRelaENS, objwf_StepPointRelaENT);
                return objwf_StepPointRelaENT;
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
        /// <param name = "objwf_StepPointRelaENS">源对象</param>
        /// <returns>目标对象=>clswf_StepPointRelaEN:objwf_StepPointRelaENT</returns>
        public static clswf_StepPointRelaEN CopyTo(this clswf_StepPointRelaENEx objwf_StepPointRelaENS)
        {
            try
            {
                clswf_StepPointRelaEN objwf_StepPointRelaENT = new clswf_StepPointRelaEN();
                clswf_StepPointRelaBL.CopyTo(objwf_StepPointRelaENS, objwf_StepPointRelaENT);
                return objwf_StepPointRelaENT;
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
    /// 工作流与结点关系(wf_StepPointRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clswf_StepPointRelaBLEx : clswf_StepPointRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clswf_StepPointRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clswf_StepPointRelaDAEx wf_StepPointRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clswf_StepPointRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="lngWorkFlowStepPointRelaId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(long lngWorkFlowStepPointRelaId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clswf_StepPointRelaDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[wf_StepPointRela]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conwf_StepPointRela.WorkFlowStepPointRelaId,
                //lngWorkFlowStepPointRelaId);
                //        clswf_StepPointRelaBL.Delwf_StepPointRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clswf_StepPointRelaBL.DelRecord(lngWorkFlowStepPointRelaId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clswf_StepPointRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                lngWorkFlowStepPointRelaId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clswf_StepPointRelaENEx> GetObjExLst(string strCondition)
        {
            List<clswf_StepPointRelaEN> arrObjLst = clswf_StepPointRelaBL.GetObjLst(strCondition);
            List<clswf_StepPointRelaENEx> arrObjExLst = new List<clswf_StepPointRelaENEx>();
            foreach (clswf_StepPointRelaEN objInFor in arrObjLst)
            {
                clswf_StepPointRelaENEx objwf_StepPointRelaENEx = new clswf_StepPointRelaENEx();
                clswf_StepPointRelaBL.CopyTo(objInFor, objwf_StepPointRelaENEx);
                arrObjExLst.Add(objwf_StepPointRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clswf_StepPointRelaENEx GetObjExByWorkFlowStepPointRelaId(long lngWorkFlowStepPointRelaId)
        {
            clswf_StepPointRelaEN objwf_StepPointRelaEN = clswf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);
            clswf_StepPointRelaENEx objwf_StepPointRelaENEx = new clswf_StepPointRelaENEx();
            clswf_StepPointRelaBL.CopyTo(objwf_StepPointRelaEN, objwf_StepPointRelaENEx);
            return objwf_StepPointRelaENEx;
        }
        public static IEnumerable<clswf_StepPointRelaEN> GetObjLstByWorkFlowId(string strWorkFlowId)
        {
            string strCondition = string.Format("{0}='{1}'", conwf_StepPointRela.WorkFlowId, strWorkFlowId);
            List<clswf_StepPointRelaEN> arrObjLst = clswf_StepPointRelaBL.GetObjLst(strCondition);
            return arrObjLst;
        }


        /// <summary>
        /// 根据工作流Id和层序号获取的对象列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>
        /// <param name = "strWorkFlowId">工作流Id</param>
        /// <param name = "intLevelNo">层序号</param>
        /// <returns>根据工作流Id获取的对象列表</returns>
        public static IEnumerable<clswf_StepPointRelaEN> GetObjLstByWorkFlowIdAndLevelNo(string strWorkFlowId, int intLevelNo)
        {
            //初始化列表缓存
            List<clswf_StepPointRelaEN> arrObjLstCache = clswf_StepPointRelaBL.GetObjLstCache();

            IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel 
                = arrObjLstCache
                .Where(x => x.WorkFlowId == strWorkFlowId && x.LevelNo == intLevelNo);            
            return arrwf_StepPointRelaObjLst_Sel;
        }

        public static clswf_StepPointRelaEN GetObjByWorkFlowIdAndPointIdCache(string strWorkFlowId, string strPointId)
        {
            //初始化列表缓存
            List<clswf_StepPointRelaEN> arrObjLstCache = clswf_StepPointRelaBL.GetObjLstCache();

            IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel
                = arrObjLstCache
                .Where(x => x.WorkFlowId == strWorkFlowId && x.PointId == strPointId);
            if (arrwf_StepPointRelaObjLst_Sel.Count() == 0)
            {
                clswf_StepPointRelaEN obj = clswf_StepPointRelaBLEx.GetObjByWorkFlowIdAndPointId(strWorkFlowId, strPointId);
                if (obj != null)
                {
                    //clswf_StepPointRelaBL.arrwf_StepPointRelaObjLstCache = null;
                    CacheHelper.Remove(clswf_StepPointRelaEN._CurrTabName);

                    return obj;
                }
                return null;
            }
            return arrwf_StepPointRelaObjLst_Sel.First();
        }

        public static Tuple<int , int> GetInOutDegreeByWorkFlowIdAndPointIdCache(string strWorkFlowId, string strPointId)
        {
            //初始化列表缓存
            List<clswf_StepPointRelaEN> arrObjLstCache = clswf_StepPointRelaBL.GetObjLstCache();

            IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel
                = arrObjLstCache
                .Where(x => x.WorkFlowId == strWorkFlowId && x.PointId == strPointId);
            if (arrwf_StepPointRelaObjLst_Sel.Count() == 0)
            {
                clswf_StepPointRelaEN obj = clswf_StepPointRelaBLEx.GetObjByWorkFlowIdAndPointId(strWorkFlowId, strPointId);
                if (obj != null)
                {
                    //clswf_StepPointRelaBL.arrwf_StepPointRelaObjLstCache = null;
                    CacheHelper.Remove(clswf_StepPointRelaEN._CurrTabName);

                    return Tuple.Create(obj.InDegree ?? 0, obj.OutDegree ?? 0);
                }
                return Tuple.Create(0,0);
            }
            clswf_StepPointRelaEN obj1 = arrwf_StepPointRelaObjLst_Sel.First();
            //(int intInDegree, int intOutDegree) = (obj1.InDegree, obj1.OutDegree);
            return Tuple.Create(obj1.InDegree ?? 0, obj1.OutDegree ?? 0);
        }


        private static clswf_StepPointRelaEN GetObjByWorkFlowIdAndPointId(string strWorkFlowId, string strPointId)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", 
                conwf_StepPointRela.WorkFlowId, strWorkFlowId,
                conwf_StepPointRela.PointId, strPointId);
           clswf_StepPointRelaEN Obj = clswf_StepPointRelaBL.GetFirstObj_S(strCondition);
            return Obj;
        }

        /// <summary>
        /// 根据工作流Id获取的对象列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>
        /// <param name = "strWorkFlowId">工作流Id</param>        
        /// <returns>根据工作流Id获取的对象列表</returns>
        public static IEnumerable<clswf_StepPointRelaEN> GetObjLstByWorkFlowIdCache(string strWorkFlowId)
        {
            //初始化列表缓存
            List<clswf_StepPointRelaEN> arrObjLstCache = clswf_StepPointRelaBL.GetObjLstCache();

            IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel
                = arrObjLstCache
                .Where(x => x.WorkFlowId == strWorkFlowId);
            return arrwf_StepPointRelaObjLst_Sel;
        }

        public static clswf_StepPointRelaEN CreateStepPointRela(string strWorkFlowId, string strPointId, string strPointTypeId, string strOpUserId)
        {
            clswf_StepPointRelaEN objwf_StepPointRelaEN_Cond = new clswf_StepPointRelaEN();
            objwf_StepPointRelaEN_Cond.SetWorkFlowId(strWorkFlowId, "=")
                .SetPointId(strPointId, "=");

            string strCondition = objwf_StepPointRelaEN_Cond.GetCombineCondition();

            clswf_StepPointRelaEN objwf_StepPointRelaEN = clswf_StepPointRelaBL.GetFirstObj_S(strCondition);
            if (objwf_StepPointRelaEN == null)
            {
                objwf_StepPointRelaEN = new clswf_StepPointRelaEN();

                objwf_StepPointRelaEN.SetWorkFlowId(strWorkFlowId)
                      .SetPointId(strPointId)
                      .SetPointTypeId(strPointTypeId)
                      .SetOrderNum(1)
                      .SetUpdDate(clsDateTime.getTodayStr(0))
                      .SetUpdUser(strOpUserId)
                      .AddNewRecord();
            }
            else
            {
                objwf_StepPointRelaEN.SetWorkFlowId(strWorkFlowId)
                      .SetPointId(strPointId)
                      .SetPointTypeId(strPointTypeId)
                    .SetOrderNum(1)
                      .SetUpdDate(clsDateTime.getTodayStr(0))
                      .SetUpdUser(strOpUserId)
                      .UpdateWithCondition(strCondition);
            }
            return objwf_StepPointRelaEN;
        }
        
        /// <summary>
        /// 计算工作流中每个结点的入度和出度
        /// </summary>
        /// <param name="strWorkFlowId">工作流Id</param>
        /// <returns></returns>
        public static bool CalcStepPointInOutDegree(string strWorkFlowId)
        {            
            string strCondition = string.Format("{0}='{1}'", conwf_StepPointRela.WorkFlowId, strWorkFlowId);
            List<clswf_StepPointRelaEN> arrwf_StepPointRela = clswf_StepPointRelaBL.GetObjLst(strCondition);
            IEnumerable<clswf_ProcessEN> arrwf_Process = clswf_ProcessBLEx.GetObjLstByWorkFlowIdCache(strWorkFlowId);

            arrwf_StepPointRela.ForEach(x=> {
                int intInDegree = arrwf_Process.Where(y => y.EndPoint == x.PointId).Count();
                int intOutDegree = arrwf_Process.Where(y => y.StartPoint == x.PointId).Count();
                x.SetInDegree(intInDegree)
                .SetOutDegree(intOutDegree)
                .Update();
            });
            return true;
        }

    }
}