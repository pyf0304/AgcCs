
/*-- -- -- -- -- -- -- -- -- -- --
类名:clswf_ProcessBLEx
表名:wf_Process(00050484)
生成代码版本:2019.08.22.1
生成日期:2019/08/25 10:24:32
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
    public static class clswf_ProcessBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objwf_ProcessENS">源对象</param>
        /// <returns>目标对象=>clswf_ProcessEN:objwf_ProcessENT</returns>
        public static clswf_ProcessENEx CopyToEx(this clswf_ProcessEN objwf_ProcessENS)
        {
            try
            {
                clswf_ProcessENEx objwf_ProcessENT = new clswf_ProcessENEx();
                clswf_ProcessBL.CopyTo(objwf_ProcessENS, objwf_ProcessENT);
                return objwf_ProcessENT;
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
        /// <param name = "objwf_ProcessENS">源对象</param>
        /// <returns>目标对象=>clswf_ProcessEN:objwf_ProcessENT</returns>
        public static clswf_ProcessEN CopyTo(this clswf_ProcessENEx objwf_ProcessENS)
        {
            try
            {
                clswf_ProcessEN objwf_ProcessENT = new clswf_ProcessEN();
                clswf_ProcessBL.CopyTo(objwf_ProcessENS, objwf_ProcessENT);
                return objwf_ProcessENT;
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
    /// 工作流过程表(wf_Process)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clswf_ProcessBLEx : clswf_ProcessBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clswf_ProcessDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clswf_ProcessDAEx wf_ProcessDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clswf_ProcessDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strProcessId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strProcessId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
                //删除与表:[wf_Process]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conwf_Process.ProcessId,
                //strProcessId);
                //        clswf_ProcessBL.Delwf_ProcesssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clswf_ProcessBL.DelRecord(strProcessId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clswf_ProcessBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strProcessId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clswf_ProcessENEx> GetObjExLst(string strCondition)
        {
            List<clswf_ProcessEN> arrObjLst = clswf_ProcessBL.GetObjLst(strCondition);
            List<clswf_ProcessENEx> arrObjExLst = new List<clswf_ProcessENEx>();
            foreach (clswf_ProcessEN objInFor in arrObjLst)
            {
                clswf_ProcessENEx objwf_ProcessENEx = new clswf_ProcessENEx();
                clswf_ProcessBL.CopyTo(objInFor, objwf_ProcessENEx);
                arrObjExLst.Add(objwf_ProcessENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strProcessId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clswf_ProcessENEx GetObjExByProcessId(string strProcessId)
        {
            clswf_ProcessEN objwf_ProcessEN = clswf_ProcessBL.GetObjByProcessId(strProcessId);
            clswf_ProcessENEx objwf_ProcessENEx = new clswf_ProcessENEx();
            clswf_ProcessBL.CopyTo(objwf_ProcessEN, objwf_ProcessENEx);
            return objwf_ProcessENEx;
        }

        /// <summary>
        /// 给定一个边,获取其开始节点
        /// </summary>
        /// <param name="ProcessId"></param>
        /// <returns></returns>
        public static string Get_StartPointOfProcess(string ProcessId)
        {
            return clswf_ProcessBL.GetObjByProcessIdCache(ProcessId).StartPoint;
        }



        /// <summary>
        /// 给定一个边,获取其结束节点
        /// </summary>
        /// <param name="ProcessId"></param>
        /// <returns></returns>
        public static string Get_EndPointOfProcess(string ProcessId)
        {
            return clswf_ProcessBL.GetObjByProcessIdCache(ProcessId).EndPoint;
        }

        ///绑定下拉框的函数代码
        public static void BindDdl_ProcessIDByPostId(System.Web.UI.WebControls.DropDownList objDDL, string strWorkFlowId)
        {
            //string strWorkFlowId = clsPostInfoBLEx.GetWorkFlowIdByPostId(strPostId);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" ProcessId in (select ProcessId from wf_StepProcessRela where WorkFlowId='{0}')", strWorkFlowId);
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = clswf_ProcessBL.GetDataTable(sbCondition.ToString());
            objDDL.DataValueField = "ProcessID";
            objDDL.DataTextField = "ProcessName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static clswf_ProcessEN CreateProcess(string strPrjId, string strProcessName, string strStartPoint, string strEndPoint, string strOpUserId)
        {
            clswf_ProcessEN objwf_ProcessEN_Cond = new clswf_ProcessEN();
            objwf_ProcessEN_Cond.SetPrjId(strPrjId, "=")
                .SetStartPoint(strStartPoint, "=")
                .SetEndPoint(strEndPoint, "=");

            string strCondition = objwf_ProcessEN_Cond.GetCombineCondition();

            clswf_ProcessEN objwf_ProcessEN = clswf_ProcessBL.GetFirstObj_S(strCondition);
            if (objwf_ProcessEN == null)
            {
                objwf_ProcessEN = new clswf_ProcessEN();

                objwf_ProcessEN.SetPrjId(strPrjId)
                      .SetProcessId(GetMaxStrId_S())
                      .SetProcessName(strProcessName)
                      .SetStartPoint(strStartPoint)
                      .SetEndPoint(strEndPoint)
                      .SetUpdDate(clsDateTime.getTodayStr(0))
                      .SetUpdUser(strOpUserId)
                      .AddNewRecord();
            }
            else
            {
                objwf_ProcessEN.SetPrjId(strPrjId)
                      .SetProcessName(strProcessName)
                      .SetStartPoint(strStartPoint)
                      .SetEndPoint(strEndPoint)
                      .SetUpdDate(clsDateTime.getTodayStr(0))
                      .SetUpdUser(strOpUserId)
                      .UpdateWithCondition(strCondition);
            }
            return objwf_ProcessEN;
        }

        public static IEnumerable<clswf_ProcessEN> GetObjByEndPoint(string strPoint)
        {
            //初始化列表缓存
            List<clswf_ProcessEN> arrObjLstCache = clswf_ProcessBL.GetObjLstCache();

            IEnumerable<clswf_ProcessEN> arrwf_ProcessObjLst_Sel
                = arrObjLstCache
                .Where(x => x.EndPoint == strPoint);
            return arrwf_ProcessObjLst_Sel;

        }

        public static IEnumerable<clswf_ProcessEN> GetObjLstByWorkFlowIdCache(string strWorkFlowId)
        {
            IEnumerable<string> arrProcessId = clswf_StepProcessRelaBLEx.GetProcessIdLstByWorkFlowIdCache(strWorkFlowId);
            //初始化列表缓存
            List<clswf_ProcessEN> arrObjLstCache = clswf_ProcessBL.GetObjLstCache();

            IEnumerable<clswf_ProcessEN> arrwf_ProcessObjLst_Sel
                = arrObjLstCache
                .Where(x => arrProcessId.Contains( x.ProcessId));
            return arrwf_ProcessObjLst_Sel;

        }

        public static void BindDdl_ProcessIdByPrjIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工作流过程表]...", "0");
            string strCondition = string.Format("{0} ='{1}' Order By {2}",
                conwf_Process.PrjId, strPrjId,
                conwf_Process.ProcessName);
            IEnumerable<clswf_ProcessEN> arrObjLst = clswf_ProcessBL.GetObjLst(strCondition);
            objDDL.DataValueField = conwf_Process.ProcessId;
            objDDL.DataTextField = conwf_Process.ProcessName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}