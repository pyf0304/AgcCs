
/*-- -- -- -- -- -- -- -- -- -- --
类名:clswf_WorkFlowBLEx
表名:wf_WorkFlow(00050482)
生成代码版本:2019.08.22.1
生成日期:2019/08/25 10:24:28
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

using System.Web.UI.WebControls;

namespace AGC.BusinessLogicEx
{
    public static class clswf_WorkFlowBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objwf_WorkFlowENS">源对象</param>
        /// <returns>目标对象=>clswf_WorkFlowEN:objwf_WorkFlowENT</returns>
        public static clswf_WorkFlowENEx CopyToEx(this clswf_WorkFlowEN objwf_WorkFlowENS)
        {
            try
            {
                clswf_WorkFlowENEx objwf_WorkFlowENT = new clswf_WorkFlowENEx();
                clswf_WorkFlowBL.CopyTo(objwf_WorkFlowENS, objwf_WorkFlowENT);
                return objwf_WorkFlowENT;
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
        /// <param name = "objwf_WorkFlowENS">源对象</param>
        /// <returns>目标对象=>clswf_WorkFlowEN:objwf_WorkFlowENT</returns>
        public static clswf_WorkFlowEN CopyTo(this clswf_WorkFlowENEx objwf_WorkFlowENS)
        {
            try
            {
                clswf_WorkFlowEN objwf_WorkFlowENT = new clswf_WorkFlowEN();
                clswf_WorkFlowBL.CopyTo(objwf_WorkFlowENS, objwf_WorkFlowENT);
                return objwf_WorkFlowENT;
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
    /// 工作流(wf_WorkFlow)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clswf_WorkFlowBLEx : clswf_WorkFlowBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clswf_WorkFlowDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clswf_WorkFlowDAEx wf_WorkFlowDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clswf_WorkFlowDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strWorkFlowId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strWorkFlowId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clswf_WorkFlowDA.GetSpecSQLObj();
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
                //删除与表:[wf_WorkFlow]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conwf_WorkFlow.WorkFlowId,
                //strWorkFlowId);
                //        clswf_WorkFlowBL.Delwf_WorkFlowsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clswf_WorkFlowBL.DelRecord(strWorkFlowId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clswf_WorkFlowBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strWorkFlowId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clswf_WorkFlowENEx> GetObjExLst(string strCondition)
        {
            List<clswf_WorkFlowEN> arrObjLst = clswf_WorkFlowBL.GetObjLst(strCondition);
            List<clswf_WorkFlowENEx> arrObjExLst = new List<clswf_WorkFlowENEx>();
            foreach (clswf_WorkFlowEN objInFor in arrObjLst)
            {
                clswf_WorkFlowENEx objwf_WorkFlowENEx = new clswf_WorkFlowENEx();
                clswf_WorkFlowBL.CopyTo(objInFor, objwf_WorkFlowENEx);
                arrObjExLst.Add(objwf_WorkFlowENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strWorkFlowId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clswf_WorkFlowENEx GetObjExByWorkFlowId(string strWorkFlowId)
        {
            clswf_WorkFlowEN objwf_WorkFlowEN = clswf_WorkFlowBL.GetObjByWorkFlowId(strWorkFlowId);
            clswf_WorkFlowENEx objwf_WorkFlowENEx = new clswf_WorkFlowENEx();
            clswf_WorkFlowBL.CopyTo(objwf_WorkFlowEN, objwf_WorkFlowENEx);
            return objwf_WorkFlowENEx;
        }

        public static bool CopyWorkFlow(string strWorkFlowIdT, string strWorkFlowIdS, string strUserId)
        {
            string strCurrDate = clsDateTime_Db.GetDataBaseDate8();

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("WorkFlowId='{0}'", strWorkFlowIdS);

            List<clswf_StepProcessRelaEN> lstWorkFlowStepProcessRelaObj = clswf_StepProcessRelaBL.GetObjLst(sbCondition.ToString());

            List<clswf_StepPointRelaEN> lstWorkFlowStepPointRelaObj = clswf_StepPointRelaBL.GetObjLst(sbCondition.ToString());
            foreach (clswf_StepPointRelaEN objWorkFlowStepPointRelaEN_S in lstWorkFlowStepPointRelaObj)
            {
                clswf_StepPointRelaEN objWorkFlowStepPointRelaEN_T = new clswf_StepPointRelaEN();
                objWorkFlowStepPointRelaEN_T.WorkFlowId = strWorkFlowIdT;
                objWorkFlowStepPointRelaEN_T.PointId = objWorkFlowStepPointRelaEN_S.PointId;
                objWorkFlowStepPointRelaEN_T.PointTypeId = objWorkFlowStepPointRelaEN_S.PointTypeId; ;
                objWorkFlowStepPointRelaEN_T.OrderNum = objWorkFlowStepPointRelaEN_S.OrderNum; ;
                objWorkFlowStepPointRelaEN_T.Memo = "通过复制而得:" + strCurrDate;

                try
                {
                    clswf_StepPointRelaBL.AddNewRecordBySql2(objWorkFlowStepPointRelaEN_T);
                }
                catch (Exception objException)
                {
                    string ss = strCurrDate + objException.Message;
                }
            }

            foreach (clswf_StepProcessRelaEN objvWorkFlowStepProcessRelaEN_S in lstWorkFlowStepProcessRelaObj)
            {

                clswf_StepProcessRelaEN objvWorkFlowStepProcessRelaEN_T = new clswf_StepProcessRelaEN();
                objvWorkFlowStepProcessRelaEN_T.WorkFlowId = strWorkFlowIdT;

                objvWorkFlowStepProcessRelaEN_T.ProcessId = objvWorkFlowStepProcessRelaEN_S.ProcessId; //过程ID
                objvWorkFlowStepProcessRelaEN_T.OrderNum = objvWorkFlowStepProcessRelaEN_S.OrderNum; //排序
                objvWorkFlowStepProcessRelaEN_T.RoleId = objvWorkFlowStepProcessRelaEN_S.RoleId; //角色ID
                objvWorkFlowStepProcessRelaEN_T.PageName = objvWorkFlowStepProcessRelaEN_S.PageName; //页面名称
                objvWorkFlowStepProcessRelaEN_T.DepartmentId = objvWorkFlowStepProcessRelaEN_S.DepartmentId; //部门ID
                objvWorkFlowStepProcessRelaEN_T.UpdDate = strCurrDate; //修改日期
                objvWorkFlowStepProcessRelaEN_T.UpdUser = strUserId; //修改人
                objvWorkFlowStepProcessRelaEN_T.Memo = "通过复制而得"; //备注
                try
                {
                    clswf_StepProcessRelaBL.AddNewRecordBySql2(objvWorkFlowStepProcessRelaEN_T);
                }
                catch (Exception objException)
                {
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                    string ss = strCurrDate;
                }

            }
            return true;
        }

        public static bool CheckProcessInValidPoint(string strWorkFlowId, string strUserId)
        {
            string strCurrDate = clsDateTime_Db.GetDataBaseDate8();

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("WorkFlowId='{0}'", strWorkFlowId);
            List<clsvwf_StepProcessRelaEN> lstWorkFlowStepProcessRelaObj
                = clsvwf_StepProcessRelaBL.GetObjLst(sbCondition.ToString());

            foreach (clsvwf_StepProcessRelaEN objvWorkFlowStepProcessRelaEN_S in lstWorkFlowStepProcessRelaObj)
            {
                sbCondition = new StringBuilder();
                sbCondition.AppendFormat(" WorkFlowId='{0}' and PointId='{1}'", strWorkFlowId, objvWorkFlowStepProcessRelaEN_S.StartPoint);
                if (clsvwf_StepPointRelaBL.IsExistRecord(sbCondition.ToString()) == false)
                {
                    clswf_StepProcessRelaEN objWorkFlowStepProcessRelaEN = clswf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(objvWorkFlowStepProcessRelaEN_S.WorkFlowStepProcessRelaId);

                    objWorkFlowStepProcessRelaEN.Memo = string.Format("开始点非法！");
                    clswf_StepProcessRelaBL.UpdateBySql2(objWorkFlowStepProcessRelaEN);
                    continue;
                }
                sbCondition = new StringBuilder();
                sbCondition.AppendFormat(" WorkFlowId='{0}' and PointId='{1}'", strWorkFlowId, objvWorkFlowStepProcessRelaEN_S.EndPoint);
                if (clsvwf_StepPointRelaBL.IsExistRecord(sbCondition.ToString()) == false)
                {
                    clswf_StepProcessRelaEN objWorkFlowStepProcessRelaEN1 = clswf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(objvWorkFlowStepProcessRelaEN_S.WorkFlowStepProcessRelaId);
                    objWorkFlowStepProcessRelaEN1.Memo = string.Format("结束点非法！");
                    clswf_StepProcessRelaBL.UpdateBySql2(objWorkFlowStepProcessRelaEN1);
                    continue;
                }
                clswf_StepProcessRelaEN objWorkFlowStepProcessRelaEN2 = clswf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(objvWorkFlowStepProcessRelaEN_S.WorkFlowStepProcessRelaId);

                objWorkFlowStepProcessRelaEN2.Memo = string.Format("结点OK！");
                clswf_StepProcessRelaBL.UpdateBySql2(objWorkFlowStepProcessRelaEN2);

            }
            return true;
        }
        /// <summary>
        /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strWorkFlowId">所给的关键字</param>
        /// <returns>根据关键字获取的名称</returns>
        public static string GetWorkFlowNameSimByWorkFlowId(string strWorkFlowId)
        {
            List<clswf_WorkFlowEN> arrObjLstCache = clswf_WorkFlowBL.GetObjLstCache();

            foreach (clswf_WorkFlowEN objWorkFlowEN in arrObjLstCache)
            {
                if (objWorkFlowEN.WorkFlowId == strWorkFlowId)
                {
                    return objWorkFlowEN.WorkFlowNameSim;
                }
            }
            return "";
        }
        public static bool SetLevelNoByWorkFlowId(string strWorkFlowId)
        {
            string strStartPointId, strEndPointId;
            clswf_StepPointRelaBLEx.CalcStepPointInOutDegree(strWorkFlowId);
            IEnumerable<clsvwf_StepProcessRelaEN> arrwf_StepProcessRelaLst = clsvwf_StepProcessRelaBLEx.GetObjLstByWorkFlowId(strWorkFlowId);
            IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRelaLst = clswf_StepPointRelaBLEx.GetObjLstByWorkFlowId(strWorkFlowId);
            IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRelaLst_Sub = arrwf_StepPointRelaLst.Where(x => x.PointTypeId == enumwf_PointType.StartPoint_01);
            if (arrwf_StepPointRelaLst_Sub.Count() == 0)
            {
                clswf_WorkFlowEN objwf_WorkFlowEN = clswf_WorkFlowBL.GetObjByWorkFlowIdCache(strWorkFlowId);
                string strMsg = string.Format("工作流:{0}({1})没有起点！", objwf_WorkFlowEN.WorkFlowName, objwf_WorkFlowEN.WorkFlowId);
                throw new Exception(strMsg);
            }
            if (arrwf_StepPointRelaLst_Sub.Count() > 1)
            {
                clswf_WorkFlowEN objwf_WorkFlowEN = clswf_WorkFlowBL.GetObjByWorkFlowIdCache(strWorkFlowId);
                string strMsg = string.Format("工作流:{0}({1})的起点多于1个，不正确！", objwf_WorkFlowEN.WorkFlowName, objwf_WorkFlowEN.WorkFlowId);
                throw new Exception(strMsg);
            }
            strStartPointId = arrwf_StepPointRelaLst_Sub.First().PointId;
            arrwf_StepPointRelaLst_Sub = arrwf_StepPointRelaLst.Where(x => x.PointTypeId == enumwf_PointType.EndPoint_02);
            if (arrwf_StepPointRelaLst_Sub.Count() == 0)
            {
                clswf_WorkFlowEN objwf_WorkFlowEN = clswf_WorkFlowBL.GetObjByWorkFlowIdCache(strWorkFlowId);
                string strMsg = string.Format("工作流:{0}({1})没有终点！", objwf_WorkFlowEN.WorkFlowName, objwf_WorkFlowEN.WorkFlowId);
                throw new Exception(strMsg);
            }
            if (arrwf_StepPointRelaLst_Sub.Count() > 1)
            {
                clswf_WorkFlowEN objwf_WorkFlowEN = clswf_WorkFlowBL.GetObjByWorkFlowIdCache(strWorkFlowId);
                string strMsg = string.Format("工作流:{0}({1})的终点多于1个，不正确！", objwf_WorkFlowEN.WorkFlowName, objwf_WorkFlowEN.WorkFlowId);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                //throw new Exception(strMsg);
            }
            strEndPointId = arrwf_StepPointRelaLst_Sub.First().PointId;
            arrwf_StepPointRelaLst_Sub = arrwf_StepPointRelaLst.Where(x => x.PointTypeId == enumwf_PointType.StartPoint_01);
            arrwf_StepPointRelaLst_Sub
                .ToList()
                .ForEach(x =>
            {
                x.LevelNo = 0;
                x.Update();
            });
            int intCount = 0;
            int intLevelNo = 0;
            while (intCount < 100)
            {
                List<string> arrStartPointId = arrwf_StepPointRelaLst_Sub.Select(x => x.PointId).ToList();
                IEnumerable<clsvwf_StepProcessRelaEN> arrwf_StepProcessRelaLst_Sub
                    = arrwf_StepProcessRelaLst.Where(x => arrStartPointId.Contains(x.StartPoint));
                int intPointCount = arrwf_StepProcessRelaLst_Sub.Count();
                List<string> arrEndPointId = arrwf_StepProcessRelaLst_Sub.Select(x => x.EndPoint).ToList();
                arrwf_StepPointRelaLst_Sub = arrwf_StepPointRelaLst.Where(x => arrEndPointId.Contains(x.PointId));
                int intPointCount_End = arrwf_StepPointRelaLst_Sub.Count();
                foreach (clswf_StepPointRelaEN objInFor in arrwf_StepPointRelaLst_Sub)
                {
                    objInFor.LevelNo = intLevelNo + 1;
                    objInFor.Update();
                }
                if (arrEndPointId.Contains(strEndPointId)) break;
                arrwf_StepPointRelaLst_Sub = arrwf_StepPointRelaLst.Where(x => arrEndPointId.Contains(x.PointId));
                intCount++;
                intLevelNo++;
            }
            return true;
        }


        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">工程Id</param>
        public static void BindDdl_WorkFlowIdByPrjIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工作流表]...", "0");
            List<clswf_WorkFlowEN> arrwf_WorkFlowObjLst = GetAllwf_WorkFlowObjLstCache();
            IEnumerable<clswf_WorkFlowEN> arrwf_WorkFlowObjLst_Sub = arrwf_WorkFlowObjLst.Where(x => x.PrjId == strPrjId).OrderBy(x => x.WorkFlowName);
            objDDL.DataValueField = conwf_WorkFlow.WorkFlowId;
            objDDL.DataTextField = conwf_WorkFlow.WorkFlowName;
            objDDL.DataSource = arrwf_WorkFlowObjLst_Sub;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
      
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetCurrUseWorkFlowIdCache(string strPrjId)
        {
            //初始化列表缓存
            List<clswf_WorkFlowEN> arrObjLstCache = clswf_WorkFlowBL.GetObjLstCache();

            IEnumerable<clswf_WorkFlowEN> arrwf_WorkFlowObjLst_Sel =
            arrObjLstCache
            .Where(x => x.IsCurrentUse == true);
            if (arrwf_WorkFlowObjLst_Sel.Count() == 0)
            {
                clswf_WorkFlowEN obj_Cond = new clswf_WorkFlowEN();
                obj_Cond.SetIsCurrentUse(true, "=")
                    .SetPrjId(strPrjId, "=");

                clswf_WorkFlowEN obj = clswf_WorkFlowBL.GetFirstObj_S(obj_Cond.GetCombineCondition());
                if (obj != null)
                {
                    //clswf_WorkFlowBL.arrwf_WorkFlowObjLstCache = null;
                    CacheHelper.Remove(clswf_WorkFlowEN._CurrTabName);

                    return obj.WorkFlowId;
                }
                return "";
            }
            return arrwf_WorkFlowObjLst_Sel.First().WorkFlowId;
        }
    }
}