
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TzAdvancedLib;

namespace AGC.BusinessLogicEx
{
    public class DnFuncMapComparer : IEqualityComparer<clsDnFuncMapEN>
    {
        public bool Equals(clsDnFuncMapEN t1, clsDnFuncMapEN t2)
        {
            return (t1.DnFuncMapId == t2.DnFuncMapId);
        }
        public int GetHashCode(clsDnFuncMapEN t)
        {
            return t.ToString().GetHashCode();
        }
    }

    public static class clsDnFuncMapBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDnFuncMapENS">源对象</param>
        /// <returns>目标对象=>clsDnFuncMapEN:objDnFuncMapENT</returns>
        public static clsDnFuncMapENEx CopyToEx(this clsDnFuncMapEN objDnFuncMapENS)
        {
            try
            {
                clsDnFuncMapENEx objDnFuncMapENT = new clsDnFuncMapENEx();
                clsDnFuncMapBL.DnFuncMapDA.CopyTo(objDnFuncMapENS, objDnFuncMapENT);
                return objDnFuncMapENT;
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
        /// <param name = "objDnFuncMapENS">源对象</param>
        /// <returns>目标对象=>clsDnFuncMapEN:objDnFuncMapENT</returns>
        public static clsDnFuncMapEN CopyTo(this clsDnFuncMapENEx objDnFuncMapENS)
        {
            try
            {
                clsDnFuncMapEN objDnFuncMapENT = new clsDnFuncMapEN();
                clsDnFuncMapBL.CopyTo(objDnFuncMapENS, objDnFuncMapENT);
                return objDnFuncMapENT;
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
    /// 数据结点函数映射(DnFuncMap)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsDnFuncMapBLEx : clsDnFuncMapBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsDnFuncMapDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsDnFuncMapDAEx DnFuncMapDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsDnFuncMapDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objDnFuncMapENS">源对象</param>
        /// <returns>目标对象=>clsDnFuncMapEN:objDnFuncMapENT</returns>
        public static clsDnFuncMapENEx CopyToEx(clsDnFuncMapEN objDnFuncMapENS)
        {
            try
            {
                clsDnFuncMapENEx objDnFuncMapENT = new clsDnFuncMapENEx();
                clsDnFuncMapBL.DnFuncMapDA.CopyTo(objDnFuncMapENS, objDnFuncMapENT);
                return objDnFuncMapENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsDnFuncMapENEx> GetObjExLst(string strCondition)
        {
            List<clsDnFuncMapEN> arrObjLst = clsDnFuncMapBL.GetObjLst(strCondition);
            List<clsDnFuncMapENEx> arrObjExLst = new List<clsDnFuncMapENEx>();
            foreach (clsDnFuncMapEN objInFor in arrObjLst)
            {
                clsDnFuncMapENEx objDnFuncMapENEx = new clsDnFuncMapENEx();
                clsDnFuncMapBL.CopyTo(objInFor, objDnFuncMapENEx);
                arrObjExLst.Add(objDnFuncMapENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsDnFuncMapENEx GetObjExByDnFuncMapId(string strDnFuncMapId)
        {
            clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapId(strDnFuncMapId);
            clsDnFuncMapENEx objDnFuncMapENEx = new clsDnFuncMapENEx();
            clsDnFuncMapBL.CopyTo(objDnFuncMapEN, objDnFuncMapENEx);
            return objDnFuncMapENEx;
        }

        /// <summary>
        /// 获取一个函数映射的两表连接( Join) 的 OnCondition
        /// </summary>
        /// <param name="strDnFuncMapId"></param>
        /// <returns></returns>
        public static (string strFuncTabName, string strOnCondition) GetOnConditionByDnFuncMapId(string strDnFuncMapId, string strPrjId)
        {
            clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapIdCache(strDnFuncMapId, strPrjId);
            if (objDnFuncMapEN == null) return ("", "");
            if (objDnFuncMapEN.FuncMapModeId == enumFuncMapMode.Table_01) return ("", "");
            if (string.IsNullOrEmpty(objDnFuncMapEN.DnFunctionId) == true) return ("", "");
            var obj = clsDnFunctionBL.GetObjByDnFunctionIdCache(objDnFuncMapEN.DnFunctionId, strPrjId);
            if (obj == null) return (string.Empty,string.Empty);
            if (obj.DnFunctionName != "equal") return ("", "");
            var objDataNodeIn = clsDataNodeBL.GetObjByDataNodeIdCache(objDnFuncMapEN.InDataNodeId, strPrjId);
            var objDataNodeOut = clsDataNodeBL.GetObjByDataNodeIdCache(objDnFuncMapEN.OutDataNodeId, strPrjId);
            string strOnCondition = $"{objDataNodeIn.TabName()}.{objDataNodeIn.FldName()} = {objDataNodeOut.TabName()}.{objDataNodeOut.FldName()}";
            string strLinkTabName = clsPrjTabBL.GetTabNameByTabIdCache(objDataNodeOut.TabId, strPrjId);
            return (strLinkTabName, strOnCondition);
        }


        public static string GetWhereConditionByDnFuncMapId(string strDnFuncMapId,string strQueryOptionId, string strPrjId)
        {
            clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapIdCache(strDnFuncMapId, strPrjId);
            if (objDnFuncMapEN == null) return "";
            if (objDnFuncMapEN.FuncMapModeId != enumFuncMapMode.Table_01) return "";

            //var obj = clsDnFunctionBL.GetObjByDnFunctionIdCache(objDnFuncMapEN.DnFunctionId, strPrjId);
            //if (obj == null) return string.Empty;

            var objDataNodeIn = clsDataNodeBL.GetObjByDataNodeIdCache(objDnFuncMapEN.InDataNodeId, strPrjId);
            var objDataNodeOut = clsDataNodeBL.GetObjByDataNodeIdCache(objDnFuncMapEN.OutDataNodeId, strPrjId);
            string strWhereCondition = "";
            if (objDataNodeOut.ObjFieldTab().IsNumberType())
            {
                strWhereCondition = $" {objDataNodeIn.FldName()} in (Select {objDataNodeIn.FldName()} from {objDataNodeOut.TabName()} where {objDataNodeOut.FldName()} = {{0}})";
            }
            else
            {
                if (strQueryOptionId == enumQueryOption.EqualQuery_01)
                {
                    strWhereCondition = $" {objDataNodeIn.FldName()} in (Select {objDataNodeIn.FldName()} from {objDataNodeOut.TabName()} where {objDataNodeOut.FldName()} = '{{0}}')";
                }
                else
                {
                    strWhereCondition = $" {objDataNodeIn.FldName()} in (Select {objDataNodeIn.FldName()} from {objDataNodeOut.TabName()} where {objDataNodeOut.FldName()} like '%{{0}}%')";
                }
            }
            return strWhereCondition;
        }

        public static List<clsDataNodeEN> CheckGraphRing(string strPrjId)
        {
            Graph g = clsDataNodeBLEx.InitGraph(strPrjId);
            var arrDataNode = clsDataNodeBLEx.GetDataNodeLst4Graph(strPrjId);
            //int intStart = clsDataNodeBLEx.GetIndexByDataNodeId(strStartNodeId, arrDataNode);
            //int intEnd = clsDataNodeBLEx.GetIndexByDataNodeId(strEndNodeId, arrDataNode);
            //List<string> arrDataNodeId = null;
            try
            {
                var arrConnectedNode = g.CheckRing();
                if (arrConnectedNode == null) return null;

                List<clsDataNodeEN> arrDataNode_Result = arrConnectedNode.Select(x => clsDataNodeBLEx.GetDataNodeByVertex(x, strPrjId)).ToList();
                return arrDataNode_Result;

                //arrDataNodeId = arrPath.Select(x => x.KeyId).ToList();
            }
            catch (Exception objException)
            {
                //var objStartNode = clsDataNodeBL.GetObjByDataNodeIdCache(strStartNodeId, strPrjId);
                //var objEndNode = clsDataNodeBL.GetObjByDataNodeIdCache(strEndNodeId, strPrjId);

                //string strMsg = string.Format("在{0}({1})-->{2}({3})之间未找到路径！",
                //    objStartNode.DataNodeName, objStartNode.DataNodeId,
                //    objEndNode.DataNodeName, objEndNode.DataNodeId);
                string strMsg = objException.Message;
                throw new Exception(strMsg);
            }

            //List<clsDnFuncMapEN> arrDataNode_Result = new List<clsDnFuncMapEN>();// arrDataNodeId.Select(x => clsDataNodeBL.GetObjByDataNodeIdCache(x, strPrjId)).ToList();
            //return arrDataNode_Result;
        }

        public static List<clsDataNodeEN> DepthFirstSearch(string strPrjId)
        {
            Graph g = clsDataNodeBLEx.InitGraph(strPrjId);
            var arrDataNode = clsDataNodeBLEx.GetDataNodeLst4Graph(strPrjId);

            //List<string> arrDataNodeId = null;
            try
            {
                var arrConnectedNode = g.DepthFirstSearch();
                if (arrConnectedNode == null) return null;

                List<clsDataNodeEN> arrDataNode_Result = arrConnectedNode.Select(x => clsDataNodeBLEx.GetDataNodeByVertex(x, strPrjId)).ToList();
                return arrDataNode_Result;


            }
            catch (Exception objException)
            {

                string strMsg = objException.Message;
                throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 获取环的结点列表
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsDataNodeEN> GetRingNodeLst(string strPrjId)
        {
            Graph g = clsDataNodeBLEx.InitGraph(strPrjId);
            var arrDataNode = clsDataNodeBLEx.GetDataNodeLst4Graph(strPrjId);
            //int intStart = clsDataNodeBLEx.GetIndexByDataNodeId(strStartNodeId, arrDataNode);
            //int intEnd = clsDataNodeBLEx.GetIndexByDataNodeId(strEndNodeId, arrDataNode);
            //List<string> arrDataNodeId = null;
            try
            {
                var arrConnectedNode = g.GetRingLst();
                if (arrConnectedNode == null) return null;

                List<clsDataNodeEN> arrDataNode_Result = arrConnectedNode.Select(x => clsDataNodeBLEx.GetDataNodeByVertex(x, strPrjId)).ToList();
                return arrDataNode_Result;

                //arrDataNodeId = arrPath.Select(x => x.KeyId).ToList();
            }
            catch (Exception objException)
            {
                //var objStartNode = clsDataNodeBL.GetObjByDataNodeIdCache(strStartNodeId, strPrjId);
                //var objEndNode = clsDataNodeBL.GetObjByDataNodeIdCache(strEndNodeId, strPrjId);

                //string strMsg = string.Format("在{0}({1})-->{2}({3})之间未找到路径！",
                //    objStartNode.DataNodeName, objStartNode.DataNodeId,
                //    objEndNode.DataNodeName, objEndNode.DataNodeId);
                string strMsg = string.Format("没有找到环！{0} (In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取环的边列表
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns>边关系关键字的列表</returns>
        public static List<string> GetRingEdgeLst(string strPrjId)
        {
            Graph g = clsDataNodeBLEx.InitGraph(strPrjId);
            var arrDataNode = clsDataNodeBLEx.GetDataNodeLst4Graph(strPrjId);
            try
            {
                var arrConnectedNode = g.GetRingLst();
                if (arrConnectedNode == null) return null;

                List<clsDataNodeEN> arrDataNode_Result = arrConnectedNode.Select(x => clsDataNodeBLEx.GetDataNodeByVertex(x, strPrjId)).ToList();
                List<string> arrDnFuncMapId = new List<string>();
                if (arrDataNode_Result.Count == 0) return arrDnFuncMapId;
                for (int i = 0; i < arrDataNode_Result.Count - 1; i++)
                {
                    string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                        conDnFuncMap.InDataNodeId, arrDataNode_Result[i].DataNodeId,
                        conDnFuncMap.OutDataNodeId, arrDataNode_Result[i + 1].DataNodeId);
                    arrDnFuncMapId = clsDnFuncMapBL.GetPrimaryKeyID_S(strCondition);

                    //conDnFuncMap.DnFuncMapId
                    //foreach (var lngMid in arrlngMid)
                    //{
                    //    arrMid.Add(lngMid);
                    //}
                }

                return arrDnFuncMapId;
            }
            catch (Exception objException)
            {

                string strMsg = string.Format("没有找到环！{0} (In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 根据输入，输出结点获取相关路径列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>        
        /// <param name = "strStartNodeId">In结点</param>
        /// <param name = "strEndNodeId">Out结点</param>
        /// <param name = "strPrjId">缓存的分类字段</param>            
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsDnFuncMapEN> GetGraphPath(long strStartNodeId, long strEndNodeId, string strPrjId)
        {
            var arrPath_Map = new List<clsDnFuncMapEN>();
            var arrPath_Node = clsDataNodeBLEx.GetGraphPath(strStartNodeId, strEndNodeId, strPrjId);
            for (int i = 0; i < arrPath_Node.Count - 1; i++)
            {
                var objDataNode_Start = arrPath_Node[i];
                var objDataNode_End = arrPath_Node[i + 1];
                var objDataNode_Map = clsDnFuncMapBLEx.GetObjByInOutDataNodeIdCacheEx(objDataNode_Start.DataNodeId, objDataNode_End.DataNodeId, strPrjId);
                if (objDataNode_Map == null)
                {
                    string strMsg = string.Format("从[{0}({1})]-->[{2}({3})]的映射不存在。(工程名:{4})",
                        objDataNode_Start.DataNodeName, objDataNode_Start.DataNodeId,
                        objDataNode_End.DataNodeName, objDataNode_End.DataNodeId,
                        clsProjectsBL.GetNameByPrjIdCache(strPrjId));
                    throw new Exception(strMsg);
                }
                arrPath_Map.Add(objDataNode_Map);
            }
            return arrPath_Map;

        }



        /// <summary>
        /// 根据输入，输出结点获取相关路径列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>        
        /// <param name = "objDnPath">Dn路径对象</param>
        /// <param name = "strPrjId">缓存的分类字段</param>            
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsDnFuncMapEN> GetObjLstByDnPath(clsDnPathEN objDnPath, string strPrjId)
        {

            //string strStartNodeId, string strEndNodeId
            var strDnLst = objDnPath.DnPathNodeLst;
            var arrDnLstS = strDnLst.Split(',');
            var arrDnLst = arrDnLstS.Select(x=>long.Parse(x)).ToList();
            var DnNum = arrDnLst.Count;
            var arrPath_Map = new List<clsDnFuncMapEN>();

            for (int i = 0; i < DnNum - 1; i++)
            {
                var strDataNode_StartId = arrDnLst[i];
                var strDataNode_EndId = arrDnLst[i + 1];
                var objDataNode_Map = clsDnFuncMapBLEx.GetObjByInOutDataNodeIdCacheEx(strDataNode_StartId, strDataNode_EndId, strPrjId);
                arrPath_Map.Add(objDataNode_Map);
            }
            return arrPath_Map;

        }



        /// <summary>
        /// 根据输入，输出结点获取相关路径, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>
        /// <param name = "strInDataNodeId">In结点</param>
        /// <param name = "strOutDataNodeId">Out结点</param>
        /// <param name = "strPrjId">缓存的分类字段</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsDnFuncMapEN GetObjByInOutDataNodeIdCacheEx(long strInDataNodeId, long strOutDataNodeId, string strPrjId)
        {
            //string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strPrjId);
            //获取缓存中的对象列表
            string strKey = string.Format("{0}_{1}", clsDnFuncMapEN._CurrTabName, strPrjId);
            List<clsDnFuncMapEN> arrDnFuncMapObjLstCache = GetObjLstCache(strPrjId);
            IEnumerable<clsDnFuncMapEN> arrDnFuncMapObjLst_Sel =
            arrDnFuncMapObjLstCache
            .Where(x => x.InDataNodeId == strInDataNodeId && x.OutDataNodeId == strOutDataNodeId);
            if (arrDnFuncMapObjLst_Sel.Count() == 0)
            {
                string strCondition = new clsDnFuncMapEN()
                    .SetInDataNodeId(strInDataNodeId, "=")
                    .SetOutDataNodeId(strOutDataNodeId, "=")
                    .GetCombineCondition();
                clsDnFuncMapEN obj = clsDnFuncMapBL.GetFirstObj_S(strCondition);
                if (obj != null)
                {
                    //if (obj.CmPrjId == strCmPrjId)
                    //{
                    CacheHelper.Remove(strKey);
                    //}
                    //else
                    //{
                    //    string strMsg = string.Format("错误: In结点:{0}, Out结点:{1} 之间不存在路径，在CM工程:{2}中,请检查！(In {3})",
                    //        strInDataNodeId, strOutDataNodeId, strCmPrjId, clsStackTrace.GetCurrClassFunction());
                    //    clsSysParaEN.objLog.WriteDebugLog(strMsg);
                    //}
                    return obj;
                }
                return null;
            }
            foreach (var objInFor in arrDnFuncMapObjLst_Sel)
            {
                if (objInFor.FuncMapModeId == enumFuncMapMode.Table_01)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, strPrjId);
                    if (objPrjTab == null)
                    {
                        string strMsg = string.Format("表id:[{0}]在PrjTab表不存在.(in {1})", objInFor.TabId, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                    if (objPrjTab.CacheModeId == enumCacheMode.sessionStorage_04 
                        || objPrjTab.CacheModeId == enumCacheMode.localStorage_03
                        || objPrjTab.CacheModeId == enumCacheMode.VueXStore_06
                        || objPrjTab.CacheModeId == enumCacheMode.PiniaStore_07)
                    {
                        return objInFor;
                    }
                    else
                    {
                        string strMsg = string.Format("表:[{0}({1})]不能作为映射关系表, 因为缓存方式不是sessionStorage或者localStorage.(in {2})", objPrjTab.TabName, objPrjTab.TabId, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                }
                else
                {
                    return objInFor;
                }
            }
            return null;
        }

        public static clsDnFuncMapEN GetObjByInOutDataNodeIdEx(long strInDataNodeId, long strOutDataNodeId, string strPrjId)
        {
            //string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strPrjId);
            //获取缓存中的对象列表
            //string strKey = string.Format("{0}_{1}", clsDnFuncMapEN._CurrTabName, strPrjId);
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conDnFuncMap.InDataNodeId, strInDataNodeId,
                conDnFuncMap.OutDataNodeId, strOutDataNodeId);
            //List<clsDnFuncMapEN> arrDnFuncMapObjLstCache = GetObjLstCache(strPrjId);
            //IEnumerable<clsDnFuncMapEN> arrDnFuncMapObjLst_Sel =
            //arrDnFuncMapObjLstCache
            //.Where(x => x.InDataNodeId == strInDataNodeId && x.OutDataNodeId == strOutDataNodeId);
            List<clsDnFuncMapEN> arrDnFuncMapObjLst_Sel = GetObjLst(strCondition);
            if (arrDnFuncMapObjLst_Sel.Count() == 0)
            {
                return null;
            }
            foreach (var objInFor in arrDnFuncMapObjLst_Sel)
            {
                if (objInFor.FuncMapModeId == enumFuncMapMode.Table_01)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, strPrjId);
                    if (objPrjTab == null)
                    {
                        string strMsg = string.Format("表id:[{0}]在PrjTab表不存在.(in {1})", objInFor.TabId, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                    if (objPrjTab.CacheModeId == enumCacheMode.sessionStorage_04 
                        || objPrjTab.CacheModeId == enumCacheMode.localStorage_03
                        || objPrjTab.CacheModeId == enumCacheMode.VueXStore_06
                        || objPrjTab.CacheModeId == enumCacheMode.PiniaStore_07)
                    {
                        return objInFor;
                    }
                    else
                    {
                        string strMsg = string.Format("表:[{0}({1})]不能作为映射关系表, 因为缓存方式不是sessionStorage或者localStorage.(in {2})", objPrjTab.TabName, objPrjTab.TabId, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                }
                else
                {
                    return objInFor;
                }
            }
            return null;
        }



        /// <summary>
        /// 根据输入结点获取相关路径列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>
        /// <param name = "strInDataNodeId">In结点</param>        
        /// <param name = "strPrjId">缓存的分类字段</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsDnFuncMapEN> GetObjLstByInDataNodeIdCacheEx(long strInDataNodeId, string strPrjId)
        {
            //获取缓存中的对象列表
            string strKey = string.Format("{0}_{1}", clsDnFuncMapEN._CurrTabName, strPrjId);
            List<clsDnFuncMapEN> arrDnFuncMapObjLstCache = GetObjLstCache(strPrjId);
            IEnumerable<clsDnFuncMapEN> arrDnFuncMapObjLst_Sel =
            arrDnFuncMapObjLstCache
            .Where(x => x.InDataNodeId == strInDataNodeId);

            return arrDnFuncMapObjLst_Sel.ToList();
        }
        public static List<string> GetDnFuncMapIdLstByInDataNodeIdEx(long strInDataNodeId)
        {
            //获取缓存中的对象列表
            string strCondition = string.Format("{0}='{1}'", conDnFuncMap.InDataNodeId, strInDataNodeId);
            List<string> arrDnFuncMapId = GetFldValue(conDnFuncMap.DnFuncMapId, strCondition);
            return arrDnFuncMapId;
        }

        public static List<string> GetDnFuncMapIdLstByOutDataNodeIdEx(long strOutDataNodeId)
        {
            //获取缓存中的对象列表
            string strCondition = string.Format("{0}='{1}'", conDnFuncMap.OutDataNodeId, strOutDataNodeId);
            List<string> arrDnFuncMapId = GetFldValue(conDnFuncMap.DnFuncMapId, strCondition);
            return arrDnFuncMapId;
        }


        /// <summary>
        /// 根据输出结点获取相关路径列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>        
        /// <param name = "strOutDataNodeId">Out结点</param>
        /// <param name = "strPrjId">缓存的分类字段</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsDnFuncMapEN> GetObjLstByOutDataNodeIdCacheEx(long strOutDataNodeId, string strPrjId)
        {
            //获取缓存中的对象列表
            string strKey = string.Format("{0}_{1}", clsDnFuncMapEN._CurrTabName, strPrjId);
            List<clsDnFuncMapEN> arrDnFuncMapObjLstCache = GetObjLstCache(strPrjId);
            IEnumerable<clsDnFuncMapEN> arrDnFuncMapObjLst_Sel =
            arrDnFuncMapObjLstCache
            .Where(x => x.OutDataNodeId == strOutDataNodeId);

            return arrDnFuncMapObjLst_Sel.ToList();
        }

        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
        /// </summary>
        /// <param name = "arrDnFuncMapIdLst">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        public static int DelDnFuncMapsEx(List<string> arrDnFuncMapIdLst)
        {
            if (arrDnFuncMapIdLst.Count == 0) return 0;
            try
            {
                clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapId(arrDnFuncMapIdLst[0]);
                int intDelRecNum = 0;
                foreach (string strDnFuncMapId in arrDnFuncMapIdLst)
                {
                    DelRecordEx(strDnFuncMapId, objDnFuncMapEN.PrjId);
                    intDelRecNum++;
                }
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                ReFreshCache(objDnFuncMapEN.PrjId);
                return intDelRecNum;
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="strDnFuncMapId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strDnFuncMapId, string strPrjId)
        {
            clsSpecSQLforSql objSQL;
            //获取连接对象
            objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
                //删除与表:[DnFuncMap]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition_RemovePathRela = $" {conDnPath.DnPathId} in (select {conDnPathFuncMapRela.DnPathId} from {conDnPathFuncMapRela._CurrTabName} where {conDnPathFuncMapRela.DnFuncMapId} = '{strDnFuncMapId}')";
                clsPrjTabFldBL.SetFldValue(conPrjTabFld._CurrTabName, conPrjTabFld.DnPathId, "[null]", strCondition_RemovePathRela);
                clsPrjTabRelationBL.SetFldValue(conPrjTabRelation._CurrTabName, conPrjTabRelation.DnPathId, "[null]", strCondition_RemovePathRela);
                List<string> arrDnPathId = clsDnPathFuncMapRelaBL.GetFldValue(conDnPathFuncMapRela.DnPathId, strCondition_RemovePathRela);
                string strCondition = string.Format("{0} = '{1}'",
                conDnFuncMap.DnFuncMapId,
                strDnFuncMapId);

                clsDnPathCmPrjIdRelaBLEx.DelRecordByCond(strCondition_RemovePathRela, objConnection, objSqlTransaction);
                
                clsDnPathFuncMapRelaBLEx.DelRecordByCond(strCondition_RemovePathRela, objConnection, objSqlTransaction);
                if (arrDnPathId.Count > 0)
                {
                    string strCondition_DelPath = $" {conDnPath.DnPathId} in ({clsArray.GetSqlInStrByArray(arrDnPathId, true)})";
                    clsDnPathBLEx.DelRecordByCond(strCondition_DelPath, strPrjId, objConnection, objSqlTransaction);
                }
                clsDnFuncMapBL.DelRecord(strDnFuncMapId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsDnFuncMapBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
                objException.Message,
                strDnFuncMapId, clsStackTrace.GetCurrClassFunction());
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


        public static bool DelRecordEx(string strDnFuncMapId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
        {
            //clsSpecSQLforSql objSQL;
            //获取连接对象
            //objSQL = clsDnFuncMapDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            try
            {
                //
                //删除与表:[DnFuncMap]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'",
                conDnFuncMap.DnFuncMapId,
                strDnFuncMapId);
                clsDnPathFuncMapRelaBLEx.DelRecordByCond(strCondition, objSqlConnection, objSqlTransaction);
                clsDnFuncMapBL.DelRecord(strDnFuncMapId, strPrjId, objSqlConnection, objSqlTransaction);

                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsDnFuncMapBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
                objException.Message,
                strDnFuncMapId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);

                throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 检查结点关系，如果有结点关系的相关表为空，或者相关表的缓存模式不正确就抛错.
        /// </summary>        
        /// <param name = "strPrjId">strPrjId</param>
        /// <param name = "strOpUser">操作用户</param>            
        /// <returns>返回检查出错误的结点数</returns>
        public static int CheckDnFuncMapByPrjId(string strPrjId, string strOpUser)
        {
            List<clsDnFuncMapEN> arrObjLstCache = clsDnFuncMapBL.GetObjLstCache(strPrjId);
            int intCount = 0;
            foreach (var objInFor in arrObjLstCache)
            {
                try
                {
                    bool bolResult = CheckDnFuncMap(objInFor, strOpUser);
                    if (bolResult) intCount++;
                }
                catch(Exception objException)
                {
                    Console.WriteLine(objException.ToString());
                    var strMsg = string.Format("在检查");
                }
            }
            return intCount;
        }
        /// <summary>
        /// 检查结点，如果有结点的相关表为空，或者相关表的缓存模式不正确就抛错.
        /// </summary>        
        /// <param name = "strDnFuncMapId">结点映射Id</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <param name = "strOpUser">操作用户</param>            
        /// <returns>如果检查错误就返回false,正确就返回true</returns>
        public static bool CheckDnFuncMap(string strDnFuncMapId, string strPrjId, string strOpUser)
        {
            clsDnFuncMapEN objDnFuncMap = clsDnFuncMapBL.GetObjByDnFuncMapIdCache(strDnFuncMapId, strPrjId);
            return CheckDnFuncMap(objDnFuncMap, strOpUser);
        }
        /// <summary>
        /// 检查结点，如果有结点的相关表为空，或者相关表的缓存模式不正确就抛错.
        /// </summary>        
        /// <param name = "objDataNode">数据结点</param>
        /// <param name = "strOpUser">操作用户</param>            
        /// <returns>如果检查错误就返回false,正确就返回true</returns>
        public static bool CheckDnFuncMap(clsDnFuncMapEN objDnFuncMap, string strOpUser)
        {
            var objProject = clsProjectsBL.GetObjByPrjIdCache(objDnFuncMap.PrjId);
            var strPrjId = objDnFuncMap.PrjId;
            clsDataNodeEN objInDataNode = null;
            try
            {
                objInDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnFuncMap.InDataNodeId, objDnFuncMap.PrjId.ToString());
            }
            catch (Exception e)
            {
                if (e.Message.IndexOf("不属于分类") > 0)
                {
                    var objDataNode = clsDataNodeBL.GetObjByDataNodeId(objDnFuncMap.InDataNodeId);
                    string strMsg = string.Format("结点：[{0}({1})]不属性工程:[{2}({3})], 请检查！",
                        objDataNode.DataNodeName, objDataNode.DataNodeId,
                        objProject.PrjName, objProject.PrjId);
                    objDnFuncMap.ErrMsg = strMsg;
                    objDnFuncMap.UpdUser = strOpUser;
                    objDnFuncMap.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objDnFuncMap.Update();
                    return false;
                    throw new Exception(strMsg);
                }
            }
            if (objInDataNode == null)
            {
                string strMsg = string.Format("在结点关系:{0}中，InDataNodeId:[{1}]相关结点不存在。 PrjId={2}({3})，请检查！(In {4})",
                    objDnFuncMap.DnFuncMapId, objDnFuncMap.InDataNodeId,
                    objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                //objDataNode.IsHasErr = true;
                objDnFuncMap.ErrMsg = strMsg;
                objDnFuncMap.UpdUser = strOpUser;
                objDnFuncMap.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objDnFuncMap.Update();
                return false;
            }

            clsDataNodeEN objOutDataNode = null;
            try
            {
                objOutDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnFuncMap.OutDataNodeId, objDnFuncMap.PrjId.ToString());
            }
            catch (Exception e)
            {
                if (e.Message.IndexOf("不属于分类") > 0)
                {
                    var objDataNode = clsDataNodeBL.GetObjByDataNodeId(objDnFuncMap.OutDataNodeId);
                    string strMsg = string.Format("结点：[{0}({1})]不属性工程:[{2}({3})], 请检查！",
                        objDataNode.DataNodeName, objDataNode.DataNodeId,
                        objProject.PrjName, objProject.PrjId);
                    objDnFuncMap.ErrMsg = strMsg;
                    objDnFuncMap.UpdUser = strOpUser;
                    objDnFuncMap.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objDnFuncMap.Update();
                    return false;// throw new Exception(strMsg);
                }
            }
            if (objOutDataNode == null)
            {
                string strMsg = string.Format("在结点关系:{0}中，OutDataNodeId:[{1}]相关结点不存在。 PrjId={2}({3})，请检查！(In {4})",
                    objDnFuncMap.DnFuncMapId, objDnFuncMap.OutDataNodeId,
                    objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                //objDataNode.IsHasErr = true;
                objDnFuncMap.ErrMsg = strMsg;
                objDnFuncMap.UpdUser = strOpUser;
                objDnFuncMap.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objDnFuncMap.Update();
                return false;
            }
            if (objDnFuncMap.FuncMapModeId == enumFuncMapMode.Table_01)
            {
                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objDnFuncMap.TabId, objDnFuncMap.PrjId);
                if (objPrjTab == null)
                {
                    string strMsg = string.Format("在结点关系从[{0}({1})]-->[{2}({3})]的相关表:[{4}]不存在。 PrjId={5}({6})，请检查！(In {7})",
                        objInDataNode.DataNodeName, objInDataNode.DataNodeId, objOutDataNode.DataNodeName, objOutDataNode.DataNodeId,
                        objDnFuncMap.TabId,
                        objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                    //objDnFuncMap.IsHasErr = true;
                    objDnFuncMap.ErrMsg = strMsg;
                    objDnFuncMap.UpdUser = strOpUser;
                    objDnFuncMap.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objDnFuncMap.Update();
                    return false;
                    //throw new Exception(strMsg);
                }

                var arrCacheModeId = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
                if (arrCacheModeId.Contains(objPrjTab.CacheModeId) == false)
                {
                    var objCacheMode = clsCacheModeBL.GetObjByCacheModeIdCache(objDnFuncMap.FuncMapModeId);
                    string strMsg = string.Format("在结点关系从[{0}({1})]-->[{2}({3})]的相关表:[{4}]的缓存模式:[{5}]不存在。 PrjId={6}({7})，请检查！(In {8})",
                        objInDataNode.DataNodeName, objInDataNode.DataNodeId, objOutDataNode.DataNodeName, objOutDataNode.DataNodeId,
                        objPrjTab.TabName, objCacheMode.CacheModeName,
                        objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                    //objDnFuncMap.IsHasErr = true;
                    objDnFuncMap.ErrMsg = strMsg;
                    objDnFuncMap.UpdUser = strOpUser;
                    objDnFuncMap.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objDnFuncMap.Update();
                    return false;
                    //throw new Exception(strMsg);
                }
            }
            else if (objDnFuncMap.FuncMapModeId == enumFuncMapMode.Function_02)
            {
                if (string.IsNullOrEmpty(objDnFuncMap.DnFunctionId) == true)
                {
                    var objCacheMode = clsCacheModeBL.GetObjByCacheModeIdCache(objDnFuncMap.FuncMapModeId);
                    string strMsg = string.Format("在结点关系从[{0}({1})]-->[{2}({3})]的映射模式为函数，但函数为空。 PrjId={4}({5})，请检查！(In {6})",
                        objInDataNode.DataNodeName, objInDataNode.DataNodeId, objOutDataNode.DataNodeName, objOutDataNode.DataNodeId,
                        objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                    //objDnFuncMap.IsHasErr = true;
                    objDnFuncMap.ErrMsg = strMsg;
                    objDnFuncMap.UpdUser = strOpUser;
                    objDnFuncMap.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objDnFuncMap.Update();
                    return false;
                    //throw new Exception(strMsg);
                }
                var objDnFunction = clsDnFunctionBL.GetObjByDnFunctionIdCache(objDnFuncMap.DnFunctionId, strPrjId);
                if (objDnFunction == null)
                {
                    string strMsg = string.Format("在结点关系从[{0}({1})]-->[{2}({3})]的映射模式为函数，但函数对象(Id:[{4}])为空。 PrjId={5}({6})，请检查！(In {7})",
                        objInDataNode.DataNodeName, objInDataNode.DataNodeId, objOutDataNode.DataNodeName, objOutDataNode.DataNodeId,
                        objDnFuncMap.DnFunctionId,
                        objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                    //objDnFuncMap.IsHasErr = true;
                    objDnFuncMap.ErrMsg = strMsg;
                    objDnFuncMap.UpdUser = strOpUser;
                    objDnFuncMap.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objDnFuncMap.Update();
                    return false;
                    //throw new Exception(strMsg);
                }
            }

            if (objDnFuncMap.ErrMsg != null && objDnFuncMap.ErrMsg.Length > 0)
            {
                objDnFuncMap.ErrMsg = "";
                objDnFuncMap.UpdUser = strOpUser;
                objDnFuncMap.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objDnFuncMap.Update();
            }
            return true;

        }

    }
}