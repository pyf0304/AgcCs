
/*-- -- -- -- -- -- -- -- -- -- --
类名:clswf_StepProcessRelaBLEx
表名:wf_StepProcessRela(00050493)
生成代码版本:2019.08.22.1
生成日期:2019/08/25 10:24:44
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

namespace AGC.BusinessLogicEx
{
    public static class clswf_StepProcessRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objwf_StepProcessRelaENS">源对象</param>
        /// <returns>目标对象=>clswf_StepProcessRelaEN:objwf_StepProcessRelaENT</returns>
        public static clswf_StepProcessRelaENEx CopyToEx(this clswf_StepProcessRelaEN objwf_StepProcessRelaENS)
        {
            try
            {
                clswf_StepProcessRelaENEx objwf_StepProcessRelaENT = new clswf_StepProcessRelaENEx();
                clswf_StepProcessRelaBL.CopyTo(objwf_StepProcessRelaENS, objwf_StepProcessRelaENT);
                return objwf_StepProcessRelaENT;
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
        /// <param name = "objwf_StepProcessRelaENS">源对象</param>
        /// <returns>目标对象=>clswf_StepProcessRelaEN:objwf_StepProcessRelaENT</returns>
        public static clswf_StepProcessRelaEN CopyTo(this clswf_StepProcessRelaENEx objwf_StepProcessRelaENS)
        {
            try
            {
                clswf_StepProcessRelaEN objwf_StepProcessRelaENT = new clswf_StepProcessRelaEN();
                clswf_StepProcessRelaBL.CopyTo(objwf_StepProcessRelaENS, objwf_StepProcessRelaENT);
                return objwf_StepProcessRelaENT;
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
    /// 工作流与过程关系(wf_StepProcessRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clswf_StepProcessRelaBLEx : clswf_StepProcessRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clswf_StepProcessRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clswf_StepProcessRelaDAEx wf_StepProcessRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clswf_StepProcessRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="lngWorkFlowStepProcessRelaId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(long lngWorkFlowStepProcessRelaId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clswf_StepProcessRelaDA.GetSpecSQLObj();
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
                //删除与表:[wf_StepProcessRela]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conwf_StepProcessRela.WorkFlowStepProcessRelaId,
                //lngWorkFlowStepProcessRelaId);
                //        clswf_StepProcessRelaBL.Delwf_StepProcessRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clswf_StepProcessRelaBL.DelRecord(lngWorkFlowStepProcessRelaId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clswf_StepProcessRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                lngWorkFlowStepProcessRelaId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clswf_StepProcessRelaENEx> GetObjExLst(string strCondition)
        {
            List<clswf_StepProcessRelaEN> arrObjLst = clswf_StepProcessRelaBL.GetObjLst(strCondition);
            List<clswf_StepProcessRelaENEx> arrObjExLst = new List<clswf_StepProcessRelaENEx>();
            foreach (clswf_StepProcessRelaEN objInFor in arrObjLst)
            {
                clswf_StepProcessRelaENEx objwf_StepProcessRelaENEx = new clswf_StepProcessRelaENEx();
                clswf_StepProcessRelaBL.CopyTo(objInFor, objwf_StepProcessRelaENEx);
                arrObjExLst.Add(objwf_StepProcessRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngWorkFlowStepProcessRelaId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clswf_StepProcessRelaENEx GetObjExByWorkFlowStepProcessRelaId(long lngWorkFlowStepProcessRelaId)
        {
            clswf_StepProcessRelaEN objwf_StepProcessRelaEN = clswf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(lngWorkFlowStepProcessRelaId);
            clswf_StepProcessRelaENEx objwf_StepProcessRelaENEx = new clswf_StepProcessRelaENEx();
            clswf_StepProcessRelaBL.CopyTo(objwf_StepProcessRelaEN, objwf_StepProcessRelaENEx);
            return objwf_StepProcessRelaENEx;
        }
        /// <summary>
        /// 根据工作流Id和考核过程Id获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strWorkFlowId">工作流Id</param>
        /// <param name="strProcessId">考核过程Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clswf_StepProcessRelaEN GetObjByWorkFlowIdAndProcessId(string strWorkFlowId, string strProcessId)
        {
            List<clswf_StepProcessRelaEN> arrObjLstCache = clswf_StepProcessRelaBL.GetObjLstCache();

            foreach (clswf_StepProcessRelaEN objWorkFlowStepProcessRelaEN in arrObjLstCache)
            {
                if (objWorkFlowStepProcessRelaEN.WorkFlowId == strWorkFlowId && objWorkFlowStepProcessRelaEN.ProcessId == strProcessId)
                {
                    return objWorkFlowStepProcessRelaEN;
                }
            }
            return null;
        }

        /// <summary>
        /// 根据工作流Id和考核过程Id获取相关对象关键字, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strWorkFlowId">工作流Id</param>
        /// <param name="strProcessId">考核过程Id</param>
        /// <returns>根据关键字获取的对象关键字</returns>
        public static long GetWorkFlowStepProcessRelaIdByWorkFlowIdAndProcessId(string strWorkFlowId, string strProcessId)
        {
            List<clswf_StepProcessRelaEN> arrObjLstCache = clswf_StepProcessRelaBL.GetObjLstCache();

            foreach (clswf_StepProcessRelaEN objWorkFlowStepProcessRelaEN in arrObjLstCache)
            {
                if (objWorkFlowStepProcessRelaEN.WorkFlowId == strWorkFlowId && objWorkFlowStepProcessRelaEN.ProcessId == strProcessId)
                {
                    return objWorkFlowStepProcessRelaEN.WorkFlowStepProcessRelaId;
                }
            }
            return 0;
        }
        public static IEnumerable<clswf_StepProcessRelaEN> GetObjLstByWorkFlowIdCache(string strWorkFlowId)
        {
            //初始化列表缓存
            List<clswf_StepProcessRelaEN> arrObjLstCache = clswf_StepProcessRelaBL.GetObjLstCache();

            IEnumerable<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst_Sel =
           arrObjLstCache
            .Where(x => x.WorkFlowId == strWorkFlowId);
            return arrwf_StepProcessRelaObjLst_Sel;
        }

        public static IEnumerable<string> GetNextPointLstCache(string strWorkFlowId, string    strPointId)
        {
            //初始化列表缓存
            IEnumerable<clsvwf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst = clsvwf_StepProcessRelaBLEx.GetObjLstByWorkFlowIdCache(strWorkFlowId);

            IEnumerable<clsvwf_StepProcessRelaEN> arrvwf_StepProcessRelaObjLst_Sel
                = arrwf_StepProcessRelaObjLst
                                    .Where(x => x.StartPoint == strPointId);
            IEnumerable<string> arrEndPoints = arrvwf_StepProcessRelaObjLst_Sel.Select(x => x.EndPoint);

            return arrEndPoints;
        }

        public static IEnumerable<string> GetPrevPointLstCache(string strWorkFlowId, string strPointId)
        {
            //初始化列表缓存
            IEnumerable<clsvwf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst = clsvwf_StepProcessRelaBLEx.GetObjLstByWorkFlowIdCache(strWorkFlowId);

            IEnumerable<clsvwf_StepProcessRelaEN> arrvwf_StepProcessRelaObjLst_Sel
                = arrwf_StepProcessRelaObjLst
                                    .Where(x => x.EndPoint == strPointId);
            IEnumerable<string> arrStartPoints = arrvwf_StepProcessRelaObjLst_Sel.Select(x => x.StartPoint);

            return arrStartPoints;
        }
        public static IEnumerable<string> GetProcessIdLstByWorkFlowIdCache(string strWorkFlowId)
        {
            //初始化列表缓存
            List<clswf_StepProcessRelaEN> arrObjLstCache = clswf_StepProcessRelaBL.GetObjLstCache();

            IEnumerable<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst_Sel =
            arrObjLstCache
            .Where(x => x.WorkFlowId == strWorkFlowId);
            return arrwf_StepProcessRelaObjLst_Sel.Select(x=>x.ProcessId);
        }


        public static IEnumerable<clswf_StepProcessRelaEN> GetObjLstByWorkFlowId(string strWorkFlowId)
        {
            string strCondition = string.Format("{0}='{1}'", conwf_StepProcessRela.WorkFlowId, strWorkFlowId);
            List<clswf_StepProcessRelaEN> arrObjLst = clswf_StepProcessRelaBL.GetObjLst(strCondition);
            return arrObjLst;
        }

        public static clswf_StepProcessRelaEN CreateStepProcessRela(string strWorkFlowId, string strProcessId, string strOpUserId)
        {
            clswf_StepProcessRelaEN objwf_StepProcessRelaEN_Cond = new clswf_StepProcessRelaEN();
            objwf_StepProcessRelaEN_Cond.SetWorkFlowId(strWorkFlowId, "=")
                .SetProcessId(strProcessId, "=");

            string strCondition = objwf_StepProcessRelaEN_Cond.GetCombineCondition();

            clswf_StepProcessRelaEN objwf_StepProcessRelaEN = clswf_StepProcessRelaBL.GetFirstObj_S(strCondition);
            if (objwf_StepProcessRelaEN == null)
            {
                objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();

                objwf_StepProcessRelaEN.SetWorkFlowId(strWorkFlowId)
                      .SetProcessId(strProcessId)
                      .SetOrderNum(1)
                      .SetUpdDate(clsDateTime.getTodayStr(0))
                      .SetUpdUser(strOpUserId)
                      .AddNewRecord();
            }
            else
            {
                objwf_StepProcessRelaEN.SetWorkFlowId(strWorkFlowId)
                      .SetProcessId(strProcessId)
                    .SetOrderNum(1)                
                      .SetUpdDate(clsDateTime.getTodayStr(0))
                      .SetUpdUser(strOpUserId)
                      .UpdateWithCondition(strCondition);
            }
            return objwf_StepProcessRelaEN;
        }

    }
}