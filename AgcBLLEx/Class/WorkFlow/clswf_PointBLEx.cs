
/*-- -- -- -- -- -- -- -- -- -- --
类名:clswf_PointBLEx
表名:wf_Point(00050485)
生成代码版本:2019.08.22.1
生成日期:2019/08/25 10:24:34
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
    public static class clswf_PointBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objwf_PointENS">源对象</param>
        /// <returns>目标对象=>clswf_PointEN:objwf_PointENT</returns>
        public static clswf_PointENEx CopyToEx(this clswf_PointEN objwf_PointENS)
        {
            try
            {
                clswf_PointENEx objwf_PointENT = new clswf_PointENEx();
                clswf_PointBL.CopyTo(objwf_PointENS, objwf_PointENT);
                return objwf_PointENT;
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
        /// <param name = "objwf_PointENS">源对象</param>
        /// <returns>目标对象=>clswf_PointEN:objwf_PointENT</returns>
        public static clswf_PointEN CopyTo(this clswf_PointENEx objwf_PointENS)
        {
            try
            {
                clswf_PointEN objwf_PointENT = new clswf_PointEN();
                clswf_PointBL.CopyTo(objwf_PointENS, objwf_PointENT);
                return objwf_PointENT;
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
    /// 工作流结点表(wf_Point)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clswf_PointBLEx : clswf_PointBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clswf_PointDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clswf_PointDAEx wf_PointDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clswf_PointDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strPointId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strPointId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clswf_PointDA.GetSpecSQLObj();
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
                //删除与表:[wf_Point]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conwf_Point.PointId,
                //strPointId);
                //        clswf_PointBL.Delwf_PointsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clswf_PointBL.DelRecord(strPointId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clswf_PointBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strPointId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clswf_PointENEx> GetObjExLst(string strCondition)
        {
            List<clswf_PointEN> arrObjLst = clswf_PointBL.GetObjLst(strCondition);
            List<clswf_PointENEx> arrObjExLst = new List<clswf_PointENEx>();
            foreach (clswf_PointEN objInFor in arrObjLst)
            {
                clswf_PointENEx objwf_PointENEx = new clswf_PointENEx();
                clswf_PointBL.CopyTo(objInFor, objwf_PointENEx);
                arrObjExLst.Add(objwf_PointENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strPointId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clswf_PointENEx GetObjExByPointId(string strPointId)
        {
            clswf_PointEN objwf_PointEN = clswf_PointBL.GetObjByPointId(strPointId);
            clswf_PointENEx objwf_PointENEx = new clswf_PointENEx();
            clswf_PointBL.CopyTo(objwf_PointEN, objwf_PointENEx);
            return objwf_PointENEx;
        }
        public static clswf_PointEN CreatePoint(string strPrjId, string strPointName, string strTabName, string strTabKeyId, string strOpUserId)
        {
            clswf_PointEN objwf_PointEN_Cond = new clswf_PointEN();
            objwf_PointEN_Cond.SetPrjId(strPrjId, "=")
                //.SetPointName(strPointName, "=")
                .SetTabName(strTabName, "=")
                .SetTabKeyId(strTabKeyId, "=");

            string strCondition = objwf_PointEN_Cond.GetCombineCondition();

            clswf_PointEN objwf_PointEN = clswf_PointBL.GetFirstObj_S(strCondition);
            if (objwf_PointEN == null)
            {
                objwf_PointEN = new clswf_PointEN();

              objwf_PointEN.SetPrjId(strPrjId)
                    .SetPointId(GetMaxStrId_S())
                    .SetPointName(strPointName)
                    .SetTabName(strTabName)
                    .SetTabKeyId(strTabKeyId)
                    .SetUpdDate(clsDateTime.getTodayStr(0))
                    .SetUpdUser(strOpUserId)
                    .AddNewRecord();
            }
            else
            {
                objwf_PointEN.SetPrjId(strPrjId)                      
                      .SetPointName(strPointName)
                      .SetTabName(strTabName)
                      .SetTabKeyId(strTabKeyId)
                      .SetUpdDate(clsDateTime.getTodayStr(0))
                      .SetUpdUser(strOpUserId)
                      .UpdateWithCondition(strCondition);
            }
            return objwf_PointEN;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWorkFlowId"></param>
        /// <param name="intLevelNo"></param>
        /// <returns></returns>
        public static IEnumerable<clswf_PointEN> GetObjLstByWorkFlowIdAndLevelNo(string strWorkFlowId, int intLevelNo)
        {
            clswf_WorkFlowEN objwf_WorkFlow = clswf_WorkFlowBL.GetObjByWorkFlowIdCache(strWorkFlowId);
            IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRela = clswf_StepPointRelaBLEx.GetObjLstByWorkFlowIdAndLevelNo(strWorkFlowId, intLevelNo);
            IEnumerable<string> arrPointId = arrwf_StepPointRela.Select(x=>x.PointId);

            IEnumerable<clswf_PointEN> arrwf_Point_Sub = GetObjLstByPrjIdCache(objwf_WorkFlow.PrjId)
                                                            .Where(x=>arrPointId.Contains( x.PointId));
            return arrwf_Point_Sub;
        }

        /// <summary>
        /// 在某工作流中，获取某结点的前驱结点
        /// </summary>
        /// <param name="strWorkFlowId"></param>
        /// <param name="strPoint"></param>
        /// <returns></returns>
        public static IEnumerable<clswf_PointEN> GetPrevPointObjLst(string strWorkFlowId, string strPoint)
        {
            clswf_WorkFlowEN objwf_WorkFlow = clswf_WorkFlowBL.GetObjByWorkFlowIdCache(strWorkFlowId);
            IEnumerable<clswf_ProcessEN> arrwf_Process = clswf_ProcessBLEx.GetObjByEndPoint(strPoint);

            IEnumerable<string> arrPrevPointId1 = arrwf_Process.Select(x => x.StartPoint);
            IEnumerable<clswf_StepPointRelaEN> arrwf_StepPointRela_Prev 
                = clswf_StepPointRelaBLEx.GetObjLstByWorkFlowIdCache(strWorkFlowId)
                .Where(x=> arrPrevPointId1.Contains(x.PointId));

            IEnumerable<string> arrPrevPointId = arrwf_StepPointRela_Prev.Select(x => x.PointId);

            IEnumerable<clswf_PointEN> arrwf_Point_Sub = GetObjLstByPrjIdCache(objwf_WorkFlow.PrjId)
                                                            .Where(x => arrPrevPointId.Contains(x.PointId));
            return arrwf_Point_Sub;
        }

        /// <summary>
        /// 根据工程Id获取相关对象列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static IEnumerable<clswf_PointEN> GetObjLstByPrjIdCache(string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true) return null;
            //初始化列表缓存
            List<clswf_PointEN> arrObjLstCache = clswf_PointBL.GetObjLstCache();

            IEnumerable<clswf_PointEN> arrwf_PointObjLst_Sel =
            arrObjLstCache
            .Where(x => x.PrjId == strPrjId);
            return arrwf_PointObjLst_Sel;
        }


        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_PointIdByPrjIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工作流结点表]...", "0");
            List<clswf_PointEN> arrwf_PointObjLst = GetAllwf_PointObjLstCache();
            IEnumerable<clswf_PointEN> arrwf_PointObjLst_Sub = arrwf_PointObjLst.Where(x=>x.PrjId == strPrjId && x.InUse==true).OrderBy(x=>x.PointName);
            objDDL.DataValueField = conwf_Point.PointId;
            objDDL.DataTextField = conwf_Point.PointName;
            objDDL.DataSource = arrwf_PointObjLst_Sub;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strPointId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clswf_PointEN GetObjByPointIdCache(string strPrjId, string strPointId)
        {
            if (string.IsNullOrEmpty(strPointId) == true) return null;
            //初始化列表缓存
            List<clswf_PointEN> arrObjLstCache = clswf_PointBL.GetObjLstCache();

            IEnumerable<clswf_PointEN> arrwf_PointObjLst_Sel =
            arrObjLstCache
            .Where(x => x.PointId == strPointId);
            if (arrwf_PointObjLst_Sel.Count() == 0)
            {
                clswf_PointEN obj = clswf_PointBL.GetObjByPointId(strPointId);
                if (obj != null)
                {
                    //clswf_PointBL.arrwf_PointObjLstCache = null;
                    CacheHelper.Remove(clswf_PointEN._CurrTabName);

                    return obj;
                }
                return null;
            }
            return arrwf_PointObjLst_Sel.First();
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <param name = "strTabName">所给的关键字</param>
        /// <param name = "strTabKeyId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clswf_PointEN GetObjByTabKeyIdCache(string strTabName, string strTabKeyId)
        {
            if (string.IsNullOrEmpty(strTabKeyId) == true) return null;
            //初始化列表缓存
            List<clswf_PointEN> arrObjLstCache = clswf_PointBL.GetObjLstCache();

            IEnumerable<clswf_PointEN> arrwf_PointObjLst_Sel =
            arrObjLstCache
            .Where(x => x.TabName == strTabName && x.TabKeyId == strTabKeyId);
            if (arrwf_PointObjLst_Sel.Count() == 0)
            {
          string strCondition = new clswf_PointEN()
                    .SetTabName(strTabName, "=")
                    .SetTabKeyId(strTabKeyId, "=")
                    .GetCombineCondition();
                clswf_PointEN obj = clswf_PointBL.GetFirstObj_S(strCondition);
                if (obj != null)
                {
                    //clswf_PointBL.arrwf_PointObjLstCache = null;
                    CacheHelper.Remove(clswf_PointEN._CurrTabName);

                    return obj;
                }
                return null;
            }
            return arrwf_PointObjLst_Sel.First();
        }

        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clswf_PointBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clswf_PointBL没有刷新缓存机制(clswf_PointBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    //初始化列表缓存
        //    string strWhereCond = string.Format("{0} = '{1}' order by PointId", conwf_Point.PrjId, strPrjId);
        //    if (arrwf_PointObjLstCache == null)
        //    {
        //        arrwf_PointObjLstCache = wf_PointDA.GetObjLst(strWhereCond);
        //    }
        //}

    }
}