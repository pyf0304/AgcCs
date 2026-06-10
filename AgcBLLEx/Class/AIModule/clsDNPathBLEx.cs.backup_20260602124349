
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDnPathBLEx
表名:DnPath(00050591)
生成代码版本:2021.07.15.1
生成日期:2021/07/15 23:00:29
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:AGC
工程ID:0005
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:AI模块
模块英文名:AIModule
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
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

namespace AGC.BusinessLogicEx
{
    public static class clsDnPathBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDnPathENS">源对象</param>
        /// <returns>目标对象=>clsDnPathEN:objDnPathENT</returns>
        public static clsDnPathENEx CopyToEx(this clsDnPathEN objDnPathENS)
        {
            try
            {
                clsDnPathENEx objDnPathENT = new clsDnPathENEx();
                clsDnPathBL.DnPathDA.CopyTo(objDnPathENS, objDnPathENT);
                return objDnPathENT;
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
        /// <param name = "objDnPathENS">源对象</param>
        /// <returns>目标对象=>clsDnPathEN:objDnPathENT</returns>
        public static clsDnPathEN CopyTo(this clsDnPathENEx objDnPathENS)
        {
            try
            {
                clsDnPathEN objDnPathENT = new clsDnPathEN();
                clsDnPathBL.CopyTo(objDnPathENS, objDnPathENT);
                return objDnPathENT;
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
    /// 数据结点路径(DnPath)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsDnPathBLEx : clsDnPathBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsDnPathDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsDnPathDAEx DnPathDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsDnPathDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objDnPathENS">源对象</param>
        /// <returns>目标对象=>clsDnPathEN:objDnPathENT</returns>
        public static clsDnPathENEx CopyToEx(clsDnPathEN objDnPathENS)
        {
            try
            {
                clsDnPathENEx objDnPathENT = new clsDnPathENEx();
                clsDnPathBL.DnPathDA.CopyTo(objDnPathENS, objDnPathENT);
                return objDnPathENT;
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
        public static List<clsDnPathENEx> GetObjExLst(string strCondition)
        {
            List<clsDnPathEN> arrObjLst = clsDnPathBL.GetObjLst(strCondition);
            List<clsDnPathENEx> arrObjExLst = new List<clsDnPathENEx>();
            foreach (clsDnPathEN objInFor in arrObjLst)
            {
                clsDnPathENEx objDnPathENEx = new clsDnPathENEx();
                clsDnPathBL.CopyTo(objInFor, objDnPathENEx);
                arrObjExLst.Add(objDnPathENEx);
            }
            return arrObjExLst;
        }

        public static List<clsDnPathENEx> GetObjExLstByPrjId(string strPrjId)
        {
            var strCondition = string.Format("{0}='{1}'", conDnPath.PrjId, strPrjId);

            List<clsDnPathEN> arrObjLst = clsDnPathBL.GetObjLst(strCondition);
            List<clsDnPathENEx> arrObjExLst = new List<clsDnPathENEx>();
            foreach (clsDnPathEN objInFor in arrObjLst)
            {
                clsDnPathENEx objDnPathENEx = new clsDnPathENEx();
                clsDnPathBL.CopyTo(objInFor, objDnPathENEx);
                arrObjExLst.Add(objDnPathENEx);
            }
            return arrObjExLst;
        }

        public static List<clsDnPathEN> GetObjLstByPrjId(string strPrjId)
        {
            var strCondition = string.Format("{0}='{1}'", conDnPath.PrjId, strPrjId);
            List<clsDnPathEN> arrObjLst = clsDnPathBL.GetObjLst(strCondition);
            return arrObjLst;
        }
        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strDnPathId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsDnPathENEx GetObjExByDnPathId(string strDnPathId)
        {
            clsDnPathEN objDnPathEN = clsDnPathBL.GetObjByDnPathId(strDnPathId);
            clsDnPathENEx objDnPathENEx = new clsDnPathENEx();
            clsDnPathBL.CopyTo(objDnPathEN, objDnPathENEx);
            return objDnPathENEx;
        }
        /// <summary>
        /// 自动建立路径
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strOpUserId"></param>
        /// <returns></returns>
        public static int AutoCreatePath(string strPrjId, string strOpUserId)
        {

            //获取所有的结点
            List<clsDataNodeEN> arrObjLstCache = clsDataNodeBL.GetObjLstCache(strPrjId);
            int intCount = 0;
            foreach (clsDataNodeEN objStartDN in arrObjLstCache)
            {
                try
                {
                    //获取本表中的所有结点
                    List<clsDataNodeEN> arrObjLst_CurrTab = clsDataNodeBLEx.GetObjLstByTabIdCache(objStartDN.TabId, strPrjId);
                    List<long> arrDataNodeId_CurrTab = arrObjLst_CurrTab.Select(x => x.DataNodeId).ToList();
                    List<clsDataNodeEN> arrObjLst_Connct = clsDataNodeBLEx.GetConnectedNode(objStartDN.DataNodeId, strPrjId);
                    if (arrObjLst_Connct == null) continue;
                    List<clsDataNodeEN> arrObjLst_Connct_Sel = arrObjLst_Connct.Where(x => arrDataNodeId_CurrTab.Contains(x.DataNodeId) == false).ToList();
                    foreach (clsDataNodeEN objEndDN in arrObjLst_Connct_Sel)
                    {
                        List<clsDnFuncMapEN> arrDnFuncMap;
                        try
                        {
                            arrDnFuncMap = clsDnFuncMapBLEx.GetGraphPath(objStartDN.DataNodeId, objEndDN.DataNodeId, strPrjId);
                        }
                        catch (Exception objException)
                        {
                            Console.WriteLine(objException.ToString());
                            continue;
                        }
                        if (arrDnFuncMap == null || arrDnFuncMap.Count == 0) continue;
                        string strDnPathNodeLst = objStartDN.DataNodeId.ToString();
                        string strAssociationMappingId = enumAssociationMapping.OneToOne_01;
                        foreach (var objDnFuncMap in arrDnFuncMap)
                        {
                            strDnPathNodeLst += string.Format(",{0}", objDnFuncMap.OutDataNodeId);
                            if (objDnFuncMap.AssociationMappingId == enumAssociationMapping.OneToMany_02)
                                strAssociationMappingId = enumAssociationMapping.OneToMany_02;

                        }

                        clsDnPathEN objDnPath = new clsDnPathEN();
                        objDnPath.DnPathName = string.Format("{0}-{1}", objStartDN.DataNodeName, objEndDN.DataNodeName);    //DN路径Id
                        objDnPath.InDataNodeId = objStartDN.DataNodeId;    //In数据结点Id
                        objDnPath.OutDataNodeId = objEndDN.DataNodeId;    //Out数据结点Id
                        objDnPath.DnPathNodeLst = strDnPathNodeLst;    //DN路径Id
                        objDnPath.AssociationMappingId = strAssociationMappingId;    //关联关系映射Id
                        objDnPath.PrjId = objStartDN.PrjId;    //工程ID                        
                        objDnPath.UpdDate = clsDateTime.getTodayDateTimeStr(1);    //修改日期
                        objDnPath.UpdUser = strOpUserId;    //修改者
                        string strCondition = objDnPath.GetUniCondStr();
                        clsDnPathEN objDnPathV2 = clsDnPathBL.GetFirstObj_S(strCondition);
                        string strDnPathId = "";
                        if (objDnPathV2 == null)
                        {
                            objDnPath.Memo = string.Format("自动创建-{0}", objDnPath.UpdDate);    //说明
                            strDnPathId = objDnPath.AddNewRecordWithMaxId();

                        }
                        else
                        {
                            if (objDnPathV2.DnPathNodeLst != strDnPathNodeLst)
                            {
                                objDnPathV2.DnPathNodeLstV2 = strDnPathNodeLst;
                                objDnPathV2.Memo = string.Format("两个路径-自建-{0}", objDnPath.UpdDate);    //说明
                                objDnPathV2.UpdateWithCondition(strCondition);
                            }
                            strDnPathId = objDnPathV2.DnPathId;
                        }
                        strCondition = string.Format("{0}='{1}'", conDnPathFuncMapRela.DnPathId, strDnPathId);
                        clsDnPathFuncMapRelaBL.DelDnPathFuncMapRelasByCond(strCondition);
                        foreach (var objDnFuncMap in arrDnFuncMap)
                        {
                            clsDnPathFuncMapRelaBLEx.CreateRela(strPrjId, strDnPathId, objDnFuncMap.DnFuncMapId, strOpUserId);
                        }
                        intCount++;
                    }
                }
                catch (Exception objException)
                {
                    var strMsg = string.Format("自动建立路径时出错。起始点：{0}。错误：{1}(in {2})",
                        objStartDN.DataNodeName,
                        objException.Message, clsStackTrace.GetCurrClassFunction());
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    //throw new Exception(strMsg);
                }
            }
            return intCount;
        }

        /// <summary>
        /// 根据起止结点Id获取路径
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strInDataNodeId"></param>
        /// <param name="strOutDataNodeId"></param>
        /// <returns>返回路径对象</returns>
        public static clsDnPathEN GetDnPathByInOutDataNodeCache(string strPrjId, long strInDataNodeId, long strOutDataNodeId)
        {
            //获取所有的结点
            //List<clsDataNodeEN> arrObjLstCache = clsDataNodeBL.GetObjLstCache(strC1mPrjId);

            try
            {
                var arrDnPath = clsDnPathBL.GetObjLstCache(strPrjId);
                var objDnPath = arrDnPath.Find(x => x.InDataNodeId == strInDataNodeId && x.OutDataNodeId == strOutDataNodeId);
                return objDnPath;
            }
            catch (Exception objException)
            {
                var strMsg = "";
                var objDataNode_In = clsDataNodeBL.GetObjByDataNodeIdCache(strInDataNodeId, strPrjId);
                var objDataNode_Out = clsDataNodeBL.GetObjByDataNodeIdCache(strOutDataNodeId, strPrjId);
                if (objDataNode_In == null)
                {
                    strMsg = string.Format("结点Id：[{0}]没有相应的结点。(in {1})",
                       strInDataNodeId, clsStackTrace.GetCurrClassFunction());
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                }
                if (objDataNode_Out == null)
                {
                    strMsg = string.Format("结点Id：[{0}]没有相应的结点。(in {1})",
                       strOutDataNodeId, clsStackTrace.GetCurrClassFunction());
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                }
                strMsg = string.Format("根据起止结点获取路径时出错。起始点：[{0}({1})]，结束点:[{2}({3})]。错误：{4}(in {5})",
                    objDataNode_In.DataNodeName, objDataNode_In.DataNodeId,
                    objDataNode_Out.DataNodeName, objDataNode_Out.DataNodeId,
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 根据起止结点Id获取路径
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strInDataNodeId"></param>
        /// <param name="strOutDataNodeId"></param>
        /// <returns>返回路径对象</returns>
        public static clsDnPathEN GetDnPathByInOutDataNodeCache(string strPrjId, string strInTabId, string strInFldId, long strOutDataNodeId)
        {
            //获取所有的结点
            //List<clsDataNodeEN> arrObjLstCache = clsDataNodeBL.GetObjLstCache(strPrjId);
            var strMsg = "";
            clsDataNodeEN objInDataNode = null;
            try
            {
                objInDataNode = clsDataNodeBLEx.GetObjByTabIdAndFldIdCache(strInTabId, strInFldId, 0, strPrjId);
                if (objInDataNode == null)
                {

                    strMsg = string.Format("错误: 表:{0}、字段:{1}不属于工程Id:{2},请检查！(In {3})",
                       strInTabId, strInFldId, strPrjId, clsStackTrace.GetCurrClassFunction());

                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                }
                var arrDnPath = clsDnPathBL.GetObjLstCache(strPrjId);
                var objDnPath = arrDnPath.Find(x => x.InDataNodeId == objInDataNode.DataNodeId && x.OutDataNodeId == strOutDataNodeId);
                return objDnPath;
            }
            catch (Exception objException)
            {
                //var objDataNode_In = clsDataNodeBL.GetObjByDataNodeIdCache(strInDataNodeId, strPrjId);
                var objDataNode_Out = clsDataNodeBL.GetObjByDataNodeIdCache(strOutDataNodeId, strPrjId);

                if (objDataNode_Out == null)
                {
                    strMsg = string.Format("结点Id：[{0}]没有相应的结点。(in {1})",
                       strOutDataNodeId, clsStackTrace.GetCurrClassFunction());
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                }
                strMsg = string.Format("根据起止结点获取路径时出错。起始点：[{0}({1})]，结束点:[{2}({3})]。错误：{4}(in {5})",
                    objInDataNode.DataNodeName, objInDataNode.DataNodeId,
                    objDataNode_Out.DataNodeName, objDataNode_Out.DataNodeId,
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }



        /// <summary>
        /// 根据输入，输出结点获取相关路径列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>        
        /// <param name = "objDnPath">Dn路径对象</param>
        /// <param name = "strPrjId">缓存的分类字段</param>            
        /// <returns>根据关键字获取的对象</returns>
        public static List<string> GetTabIdLst4MapFuncByDnPath(clsDnPathEN objDnPath)
        {
            List<string> arrTabId4MapFunc = new List<string>();

            //string strStartNodeId, string strEndNodeId
            var strDnLst = objDnPath.DnPathNodeLst;
            var arrDnLstS = strDnLst.Split(',');
            var arrDnLst = arrDnLstS.Select(x => long.Parse(x)).ToList();
            var DnNum = arrDnLst.Count;
            //var arrPath_Map = new List<clsDnFuncMapEN>();

            //var arrPath_Node = clsDataNodeBLEx.GetGraphPath(strStartNodeId, strEndNodeId, strPrjId);
            for (int i = 0; i < DnNum - 1; i++)
            {
                var strDataNode_StartId = arrDnLst[i];
                var strDataNode_EndId = arrDnLst[i + 1];
                var objDataNode_Map = clsDnFuncMapBLEx.GetObjByInOutDataNodeIdCacheEx(strDataNode_StartId, strDataNode_EndId,
                    objDnPath.PrjId);
                if (objDataNode_Map == null) continue;
                if (objDataNode_Map.FuncMapModeId == enumFuncMapMode.Table_01)
                {
                    if (arrTabId4MapFunc.Contains(objDataNode_Map.TabId) == false)
                    {
                        arrTabId4MapFunc.Add(objDataNode_Map.TabId);
                    }
                }
                //arrPath_Map.Add(objDataNode_Map);
            }
            return arrTabId4MapFunc;

        }

        public static List<string> GetTabIdLst4MapFuncByDnPathId(string strDnPathId, string strPrjId)
        {
            clsDnPathEN objDnPath = clsDnPathBL.GetObjByDnPathIdCache(strDnPathId, strPrjId);
            List<string> arrTabId4MapFunc = new List<string>();

            //string strStartNodeId, string strEndNodeId
            var strDnLst = objDnPath.DnPathNodeLst;

            var arrDnLstS = strDnLst.Split(',');
            var arrDnLst = arrDnLstS.Select(x => long.Parse(x)).ToList();
            var DnNum = arrDnLst.Count;

            //var arrPath_Map = new List<clsDnFuncMapEN>();

            //var arrPath_Node = clsDataNodeBLEx.GetGraphPath(strStartNodeId, strEndNodeId, strPrjId);
            for (int i = 0; i < DnNum - 1; i++)
            {
                var strDataNode_StartId = arrDnLst[i];
                var strDataNode_EndId = arrDnLst[i + 1];
                var objDataNode_Map = clsDnFuncMapBLEx.GetObjByInOutDataNodeIdCacheEx(strDataNode_StartId, strDataNode_EndId,
                    objDnPath.PrjId);
                if (objDataNode_Map == null) continue;
                if (objDataNode_Map.FuncMapModeId == enumFuncMapMode.Table_01)
                {
                    if (arrTabId4MapFunc.Contains(objDataNode_Map.TabId) == false)
                    {
                        arrTabId4MapFunc.Add(objDataNode_Map.TabId);
                    }
                }
                //arrPath_Map.Add(objDataNode_Map);
            }
            return arrTabId4MapFunc;

        }

        public static List<(string, string)> GetOnConditionByDnPathId(string strDnPathId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strDnPathId)) return null;
            clsDnPathEN objDnPath = clsDnPathBL.GetObjByDnPathIdCache(strDnPathId, strPrjId);
            List<(string, string)> arrOnCondition4MapFunc = new List<(string, string)>();

            //string strStartNodeId, string strEndNodeId
            var strDnLst = objDnPath.DnPathNodeLst;

            var arrDnLstS = strDnLst.Split(',');
            var arrDnLst = arrDnLstS.Select(x => long.Parse(x)).ToList();
            var DnNum = arrDnLst.Count;

            //var arrPath_Map = new List<clsDnFuncMapEN>();

            //var arrPath_Node = clsDataNodeBLEx.GetGraphPath(strStartNodeId, strEndNodeId, strPrjId);
            for (int i = 0; i < DnNum - 1; i++)
            {
                var strDataNode_StartId = arrDnLst[i];
                var strDataNode_EndId = arrDnLst[i + 1];
                var objDataNode_Map = clsDnFuncMapBLEx.GetObjByInOutDataNodeIdCacheEx(strDataNode_StartId, strDataNode_EndId,
                    objDnPath.PrjId);
                if (objDataNode_Map == null) continue;
              var (strLinkTabName, strOnCondition )= clsDnFuncMapBLEx.GetOnConditionByDnFuncMapId(objDataNode_Map.DnFuncMapId, strPrjId);
                if (strOnCondition != "" && strLinkTabName != ""
                    && arrOnCondition4MapFunc.Contains((strLinkTabName, strOnCondition)) == false)
                {
                    arrOnCondition4MapFunc.Add((strLinkTabName, strOnCondition));
                }
                //arrPath_Map.Add(objDataNode_Map);
            }
            return arrOnCondition4MapFunc;

        }

        public static List<string> GetWhereConditionByDnPathId(string strDnPathId, string strQueryOptionId, string strPrjId)
        {
            List<string> arrWhereCondition4MapFunc = new List<string>();
            if (strDnPathId == null) return arrWhereCondition4MapFunc;
            clsDnPathEN objDnPath = clsDnPathBL.GetObjByDnPathIdCache(strDnPathId, strPrjId);
  

            //string strStartNodeId, string strEndNodeId
            var strDnLst = objDnPath.DnPathNodeLst;

            var arrDnLstS = strDnLst.Split(',');
            var arrDnLst = arrDnLstS.Select(x => long.Parse(x)).ToList();
            var DnNum = arrDnLst.Count;


            //var arrPath_Map = new List<clsDnFuncMapEN>();

            //var arrPath_Node = clsDataNodeBLEx.GetGraphPath(strStartNodeId, strEndNodeId, strPrjId);
            for (int i = 0; i < DnNum - 1; i++)
            {
                var strDataNode_StartId = arrDnLst[i];
                var strDataNode_EndId = arrDnLst[i + 1];
                var objDataNode_Map = clsDnFuncMapBLEx.GetObjByInOutDataNodeIdCacheEx(strDataNode_StartId, strDataNode_EndId,
                    objDnPath.PrjId);
                if (objDataNode_Map == null) continue;
                string strWhereCondition = clsDnFuncMapBLEx.GetWhereConditionByDnFuncMapId(objDataNode_Map.DnFuncMapId, strQueryOptionId, strPrjId);
                if (strWhereCondition != ""
                    && arrWhereCondition4MapFunc.Contains(strWhereCondition) == false)
                {
                    arrWhereCondition4MapFunc.Add(strWhereCondition);
                }
                //arrPath_Map.Add(objDataNode_Map);
            }
            return arrWhereCondition4MapFunc;

        }

        public static string GetLeftJoinTabIdByDnPathId(string strThisTabId, string strDnPathId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strDnPathId)) return "";
            List<string> arrTabId4MapFunc = GetTabIdLst4MapFuncByDnPathId(strDnPathId, strPrjId);
            foreach (string strTabId in arrTabId4MapFunc)
            {
                if (strTabId != strThisTabId) return strTabId;
            }
            return "";
        }

        /// <summary>
        /// 根据输入，输出结点获取相关路径列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>        
        /// <param name = "objDnPath">Dn路径对象</param>
        /// <param name = "strPrjId">缓存的分类字段</param>            
        /// <returns>根据关键字获取的对象</returns>
        public static List<string> GetDnFunctionIdLst4MapFuncByDnPath(clsDnPathEN objDnPath)
        {
            List<string> arrDnFunctionId4MapFunc = new List<string>();

            //string strStartNodeId, string strEndNodeId
            var strDnLst = objDnPath.DnPathNodeLst;

            var arrDnLstS = strDnLst.Split(',');
            var arrDnLst = arrDnLstS.Select(x => long.Parse(x)).ToList();
            var DnNum = arrDnLst.Count;

            //var arrPath_Map = new List<clsDnFuncMapEN>();

            //var arrPath_Node = clsDataNodeBLEx.GetGraphPath(strStartNodeId, strEndNodeId, strCstrPrjIdmPrjId);
            for (int i = 0; i < DnNum - 1; i++)
            {
                var strDataNode_StartId = arrDnLst[i];
                var strDataNode_EndId = arrDnLst[i + 1];
                var objDataNode_Map = clsDnFuncMapBLEx.GetObjByInOutDataNodeIdCacheEx(strDataNode_StartId, strDataNode_EndId,
                    objDnPath.PrjId);
                if (objDataNode_Map == null) continue;
                if (objDataNode_Map.FuncMapModeId == enumFuncMapMode.Function_02)
                {
                    if (arrDnFunctionId4MapFunc.Contains(objDataNode_Map.DnFunctionId) == false)
                    {
                        arrDnFunctionId4MapFunc.Add(objDataNode_Map.DnFunctionId);
                    }
                }
                //arrPath_Map.Add(objDataNode_Map);
            }
            return arrDnFunctionId4MapFunc;

        }
        /// <summary>
        /// 检查结点路径，如果有同一个In结点有相同的Out字段名就抛错.
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static int CheckDnPathDuplicate(string strPrjId, string strOpUser)
        {
            var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            
            clsDnPathBL.SetFldValue(conDnPath._CurrTabName, conDnPath.IsHasErr, "0", string.Format("{0}='{1}'", conDnPath.PrjId, strPrjId));
            clsDnPathBL.SetFldValue(conDnPath._CurrTabName, conDnPath.ErrMsg, "", string.Format("{0}='{1}'", conDnPath.PrjId, strPrjId));

            List<clsDnPathENEx> arrDnPathEx = clsDnPathBLEx.GetObjExLstByPrjId(strPrjId);
            foreach (var objInFor in arrDnPathEx)
            {
                objInFor.InFldId = clsDataNodeBLEx.GetFldIdByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                objInFor.OutFldId = clsDataNodeBLEx.GetFldIdByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
            }
            arrDnPathEx = arrDnPathEx.OrderBy(x => x.InDataNodeId).OrderBy(x => x.OutFldId).ToList();
            int i = 0;
            int j = i + 1;
            int intCount = 0;
            while (i < arrDnPathEx.Count)
            {
                var objDnPath_i = arrDnPathEx[i];
                var objDnPath_j = arrDnPathEx[j];
                if (arrDnPathEx[j].InDataNodeId == arrDnPathEx[i].InDataNodeId && arrDnPathEx[j].OutFldId == arrDnPathEx[i].OutFldId)
                {
                    var objOutFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDnPath_i.OutFldId, strPrjId);
                    var strMsg = string.Format("在结点路径:{0}({1})中，In结点:[{2}]有相同的Out字段({3})不存在。 PrjId={4}({5})，请检查！(In {6})",
                        objDnPath_i.DnPathName, objDnPath_i.DnPathId, objDnPath_i.InDataNodeId, objOutFieldTab.FldName,
                        objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                    if (objDnPath_i.ErrMsg.Length == 0)
                    {
                        objDnPath_i.IsHasErr = true;
                        objDnPath_i.ErrMsg = strMsg;
                        objDnPath_i.UpdUser = strOpUser;
                        objDnPath_i.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objDnPath_i.Update();
                        intCount++;
                    }

                    strMsg = string.Format("在结点路径:{0}({1})中，In结点:[{2}]有相同的Out字段({3})不存在。 PrjId={4}({5})，请检查！(In {6})",
                    objDnPath_j.DnPathName, objDnPath_j.DnPathId, objDnPath_j.InDataNodeId, objOutFieldTab.FldName,
                    objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());

                    objDnPath_j.IsHasErr = true;
                    objDnPath_j.ErrMsg = strMsg;
                    objDnPath_j.UpdUser = strOpUser;
                    objDnPath_j.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objDnPath_j.Update();
                    intCount++;
                    i = j;
                    j = i + 1;
                }
                else
                {
                    i = j;
                    j = i + 1;
                }
                if (j == arrDnPathEx.Count) break;
            }

            return intCount;

        }

        /// <summary>
        /// 自动删除重复路径.
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static int DelDnPathDuplicate(string strPrjId, string strOpUser)
        {
            var strMsg = "";

            List<clsDnPathENEx> arrDnPathEx = clsDnPathBLEx.GetObjExLstByPrjId(strPrjId);
            arrDnPathEx = arrDnPathEx.Where(x => x.ErrMsg != null && x.ErrMsg.Length > 0).ToList();
            foreach (var objInFor in arrDnPathEx)
            {
                objInFor.InFldId = clsDataNodeBLEx.GetFldIdByDataNodeIdCache(objInFor.InDataNodeId, strPrjId);
                objInFor.OutFldId = clsDataNodeBLEx.GetFldIdByDataNodeIdCache(objInFor.OutDataNodeId, strPrjId);
            }
            arrDnPathEx = arrDnPathEx.OrderBy(x => x.InDataNodeId).OrderBy(x => x.OutFldId).ToList();
            string strTabId = "";
            string strFldId = "";
            //string strRegionId = "";
            string strRelaErrMsg = "";
            //string strRelaViewNameRegionType = "";
            int i = 0;
            int j = i + 1;
            int intCount = 0;
            while (i < arrDnPathEx.Count)
            {
                var objDnPath_i = arrDnPathEx[i];
                var objDnPath_j = arrDnPathEx[j];
                var objOutFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDnPath_i.OutFldId, strPrjId);

                if (arrDnPathEx[j].InDataNodeId == arrDnPathEx[i].InDataNodeId && arrDnPathEx[j].OutFldId == arrDnPathEx[i].OutFldId)
                {
                    if (objDnPath_i.EdgeNum > objDnPath_j.EdgeNum)
                    {
                        try
                        {
                            objDnPath_i.Delete();
                            intCount++;
                        }
                        catch (Exception objException)
                        {
                            string strRelaTabName = GetErrRelaTab(objException.Message);

                            switch (strRelaTabName)
                            {
                                case conPrjTabFld._CurrTabName:
                                    strTabId = clsPrjTabFldBLEx.GetTabIdByDnPathId(objDnPath_i.DnPathId);
                                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                                    if (objPrjTab != null)
                                    {
                                        strRelaErrMsg = string.Format("相关表:[{0}]引用该路径.", objPrjTab.TabName);
                                    }
                                    strFldId = clsPrjTabFldBLEx.GetFldIdByDnPathId(objDnPath_i.DnPathId);
                                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, strPrjId);

                                    if (objFieldTab != null)
                                    {
                                        strRelaErrMsg += string.Format("字段:[{0}].", objFieldTab.FldName);
                                    }
                                    break;
                              
                            }
                            strMsg = string.Format("在结点路径:{0}({1})中，Out字段名:[{2}],发生重复，边数：[{3}]大于其他，自动删除出错,{4}, 错误：{5}，请检查！(In {6})",
                       objDnPath_i.DnPathName, objDnPath_i.DnPathId, objOutFieldTab.FldName, objDnPath_i.EdgeNum,
                  strRelaErrMsg, objException.Message, clsStackTrace.GetCurrClassFunction());

                            objDnPath_i.IsHasErr = true;
                            objDnPath_i.ErrMsg = strMsg;
                            objDnPath_i.UpdUser = strOpUser;
                            objDnPath_i.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objDnPath_i.Update();
                        }
                    }
                    else
                    {
                        try
                        {
                            objDnPath_j.Delete();
                            intCount++;
                        }
                        catch (Exception objException)
                        {
                            string strRelaTabName = GetErrRelaTab(objException.Message);

                            switch (strRelaTabName)
                            {
                                case conPrjTabFld._CurrTabName:
                                    strTabId = clsPrjTabFldBLEx.GetTabIdByDnPathId(objDnPath_j.DnPathId);
                                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                                    if (objPrjTab != null)
                                    {
                                        strRelaErrMsg = string.Format("相关表:[{0}]引用该路径.", objPrjTab.TabName);
                                    }
                                    strFldId = clsPrjTabFldBLEx.GetFldIdByDnPathId(objDnPath_j.DnPathId);
                                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, strPrjId);

                                    if (objFieldTab != null)
                                    {
                                        strRelaErrMsg += string.Format("字段:[{0}].", objFieldTab.FldName);
                                    }
                                    break;
                               

                            }
                            strMsg = string.Format("在结点路径:{0}({1})中，Out字段名:[{2}],发生重复，边数：[{3}]大于其他，自动删除出错,{4}, 错误：{5}，请检查！(In {6})",
                       objDnPath_j.DnPathName, objDnPath_j.DnPathId, objOutFieldTab.FldName, objDnPath_i.EdgeNum,
                  strRelaErrMsg, objException.Message, clsStackTrace.GetCurrClassFunction());
                            objDnPath_j.IsHasErr = true;
                            objDnPath_j.ErrMsg = strMsg;
                            objDnPath_j.UpdUser = strOpUser;
                            objDnPath_j.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objDnPath_j.Update();
                        }
                    }


                    i = j;
                    j = i + 1;
                }
                else
                {
                    i = j;
                    j = i + 1;
                }
                if (j == arrDnPathEx.Count) break;
            }

            return intCount;

        }
        /// <summary>
        /// 删除路径,如果出错，进行错误分析
        /// </summary>
        /// <param name="strDnPathId"></param>
        /// <param name="strPrjId"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static int DelDnPath(string strDnPathId, string strPrjId, string strOpUser)
        {
            var strMsg = "";

            clsDnPathEN objDnPath = clsDnPathBL.GetObjByDnPathId(strDnPathId);
            string strTabId = "";
            string strFldId = "";
            //string strRegionId = "";
            clsFieldTabEN objFieldTab;
            string strRelaErrMsg = "";
            //string strRelaViewNameRegionType = "";
          
            int intCount = 0;
            try
            {
                clsDnPathBLEx.DelRecordEx(strDnPathId, strPrjId);
                intCount++;
            }
            catch (Exception objException)
            {
                string strRelaTabName = GetErrRelaTab(objException.Message);

                switch (strRelaTabName)
                {
                    case conPrjTabFld._CurrTabName:

                        strTabId = clsPrjTabFldBLEx.GetTabIdByDnPathId(objDnPath.DnPathId);
                        clsPrjTabEN objPrjTab = null;
                        try
                        {
                            objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        }
                        catch(Exception objException1)
                        {
                            Console.WriteLine(objException1.ToString());
                            objPrjTab = clsPrjTabBL.GetObjByTabId(strTabId);
                        }
                        strFldId = clsPrjTabFldBLEx.GetFldIdByDnPathId(objDnPath.DnPathId);
                        try
                        {
                            objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, strPrjId);
                        }
                        catch(Exception objException2)
                        {
                            Console.WriteLine(objException2.ToString());
                            objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
                        }
                        if (objPrjTab != null)
                        {
                            strRelaErrMsg = string.Format("相关表:[{0}]引用该路径.", objPrjTab.TabName);
                        }
                        if (objFieldTab != null)
                        {
                            strRelaErrMsg += string.Format("字段:[{0}].", objFieldTab.FldName);
                        }
                        break;
                   

                }
                strMsg = string.Format("在删除路径:{0}({1})中，出错,{2}, 错误：{3}，请检查！(In {4})",
           objDnPath.DnPathName, objDnPath.DnPathId, 
      strRelaErrMsg, objException.Message, clsStackTrace.GetCurrClassFunction());

                objDnPath.IsHasErr = true;
                objDnPath.ErrMsg = strMsg;
                objDnPath.UpdUser = strOpUser;
                objDnPath.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objDnPath.Update();
            }

            return intCount;

        }


        public static string GetErrRelaTab(string strErrMsg)
        {
            int intStartIndex = strErrMsg.IndexOf("表\"");
            if (intStartIndex == -1) return "";
            int intEndIndex = strErrMsg.IndexOf("\",", intStartIndex);
            if (intEndIndex == -1) return "";

            var strTabName = strErrMsg.Substring(intStartIndex, intEndIndex - intStartIndex);
            strTabName = strTabName.Replace("表\"", "");
            strTabName = strTabName.Replace("dbo.", "");

            return strTabName;
        }
        /// <summary>
        /// 计算每个路径的边数
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static int CalcDnPathEdgeNum(string strPrjId, string strOpUser)
        {
            clsDnPathBL.SetFldValue(conDnPath._CurrTabName, conDnPath.IsHasErr, "0", string.Format("{0}='{1}'", conDnPath.PrjId, strPrjId));
            clsDnPathBL.SetFldValue(conDnPath._CurrTabName, conDnPath.ErrMsg, "", string.Format("{0}='{1}'", conDnPath.PrjId, strPrjId));

            List<clsDnPathEN> arrDnPath = clsDnPathBLEx.GetObjLstByPrjId(strPrjId);
            int intCount = 0;
            foreach (var objInFor in arrDnPath)
            {
                var intDataNodeNum = objInFor.DnPathNodeLst.Split(",".ToCharArray()).Length;
                objInFor.EdgeNum = intDataNodeNum - 1;
                objInFor.UpdUser = strOpUser;
                objInFor.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objInFor.Update();
                intCount++;
            }
            return intCount;
        }


        /// <summary>
        /// 检查结点路径，如果有结点为空，或者映射函数为空就抛错.
        /// </summary>        
        /// <param name = "objDnPath">Dn路径对象</param>
        /// <param name = "strOpUser">缓存的分类字段</param>            
        /// <returns>根据关键字获取的对象</returns>
        public static bool CheckDnPath(clsDnPathEN objDnPath, string strOpUser)
        {
            var strDnLst = objDnPath.DnPathNodeLst;

            var arrDnLstS = strDnLst.Split(',');
            var arrDnLst = arrDnLstS.Select(x => long.Parse(x)).ToList();
            var DnNum = arrDnLst.Count;

            //var arrPath_Map = new List<clsDnFuncMapEN>();
            for (int i = 0; i < DnNum; i++)
            {
                var strDataNodeId = arrDnLst[i];
                var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(strDataNodeId, objDnPath.PrjId);
                if (objDataNode == null)
                {
                    var objProject = clsProjectsBL.GetObjByPrjIdCache(objDnPath.PrjId);
                    string strMsg = string.Format("在结点路径:{0}({1})中，第{2}个结点({3})不存在。 PrjId={4}({5})，请检查！(In {6})",
                        objDnPath.DnPathName, objDnPath.DnPathId, i, strDataNodeId,
                        objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                    objDnPath.IsHasErr = true;
                    objDnPath.ErrMsg = strMsg;
                    objDnPath.UpdUser = strOpUser;
                    objDnPath.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objDnPath.Update();
                    return false;
                    //throw new Exception(strMsg);
                }
            }
            for (int i = 0; i < DnNum - 1; i++)
            {
                var strDataNode_StartId = arrDnLst[i];
                var strDataNode_EndId = arrDnLst[i + 1];
                var objDataNode_Map = clsDnFuncMapBLEx.GetObjByInOutDataNodeIdEx(strDataNode_StartId, strDataNode_EndId,
                    objDnPath.PrjId);
                if (objDataNode_Map == null)
                {
                    var objProject = clsProjectsBL.GetObjByPrjIdCache(objDnPath.PrjId);
                    string strMsg = string.Format("在结点路径:{0}({1})中，第{2}-{3}个结点之间映射函数不存在。 PrjId={4}({5})，请检查！(In {6})",
                        objDnPath.DnPathName, objDnPath.DnPathId, i, i + 1,
                        objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                    objDnPath.IsHasErr = true;
                    objDnPath.ErrMsg = strMsg;
                    objDnPath.UpdUser = strOpUser;
                    objDnPath.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objDnPath.Update();
                    return false;
                    //throw new Exception(strMsg);
                }
            }
            return true;

        }

        /// <summary>
        /// 检查结点路径，如果有结点为空，或者映射函数为空就抛错.
        /// </summary>        
        /// <param name = "strDnPathId">Dn路径Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static bool CheckDnPath(string strDnPathId, string strOpUserId)
        {
            var objDnPath = clsDnPathBL.GetObjByDnPathId(strDnPathId);
            bool bolResult = CheckDnPath(objDnPath, strOpUserId);
            if (bolResult == true)
            {
                objDnPath.IsHasErr = false;
                objDnPath.ErrMsg = "";
                objDnPath.UpdUser = strOpUserId;
                objDnPath.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objDnPath.Update();
            }
            else
            {
                //开始修复(repair)
                bolResult = RepairDnPath(strDnPathId, strOpUserId);
                return bolResult;
            }
            return true;
        }


        /// <summary>
        /// 根据起止结点Id获取路径
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strInTabId"></param>    
        /// <returns>返回路径对象</returns>
        public static List<clsDnPathEN> GetObjLstByInDataNodeByTabIdCache(string strPrjId, string strInTabId)
        {
            //获取所有的结点
            //List<clsDataNodeEN> arrObjLstCache = clsDataNodeBL.GetObjLstCache(strPrjId);
            var strMsg = "";

            try
            {
                List<clsDataNodeEN> arrInDataNode = clsDataNodeBLEx.GetObjLstByTabIdCache(strInTabId, strPrjId);

                if (arrInDataNode.Count == 0)
                {

                    strMsg = string.Format("错误: 表:{0}(工程Id:{1})没有相关结点,请检查！(In {2})",
                       strInTabId, strPrjId, clsStackTrace.GetCurrClassFunction());

                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                }
                var arrInDataNodeId = arrInDataNode.Select(x => x.DataNodeId).ToList();
                var arrDnPath = clsDnPathBL.GetObjLstCache(strPrjId);
                var arrDnPath_Sel = arrDnPath.Where(x => arrInDataNodeId.Contains(x.InDataNodeId) == true).ToList();
                return arrDnPath_Sel;
            }
            catch (Exception objException)
            {
                var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                var objPrjTab_In = clsPrjTabBL.GetObjByTabIdCache(strInTabId, objProject.PrjId);
                strMsg = string.Format("根据表的所有字段获取所有路径时出错。工程：[{0}({1})]，表:[{2}({3})]。错误：{4}(in {5})",
                    objProject.PrjName, objProject.PrjId,
                    objPrjTab_In.TabName, objPrjTab_In.TabId,
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 根据起止结点Id获取路径
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strInDataNodeId"></param>
        /// <param name="strOutDataNodeId"></param>
        /// <returns>返回路径对象</returns>
        public static List<string> GetTabIdLst4FunMapByInDataNodeInTabIdCache(string strPrjId, string strInTabId)
        {
            //获取所有的结点
            //List<clsDataNodeEN> arrObjLstCache = clsDataNodeBL.GetObjLstCache(strPrjId);
            var strMsg = "";

            try
            {
                List<clsDataNodeEN> arrInDataNode = clsDataNodeBLEx.GetObjLstByTabIdCache(strInTabId, strPrjId);

                if (arrInDataNode.Count == 0)
                {

                    strMsg = string.Format("错误: 表:{0}(工程Id:{1})没有相关结点,请检查！(In {2})",
                       strInTabId, strPrjId, clsStackTrace.GetCurrClassFunction());

                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                }
                var arrInDataNodeId = arrInDataNode.Select(x => x.DataNodeId).ToList();
                var arrDnPath = clsDnPathBL.GetObjLstCache(strPrjId);
                var arrDnPath_Sel = arrDnPath.Where(x => arrInDataNodeId.Contains(x.InDataNodeId) == true).ToList();
                //return arrDnPath_Sel;
                List<string> arrTabId4MapFunc_All = new List<string>();

                foreach (var objInFor in arrDnPath_Sel)
                {
                    List<string> arrTabId4MapFunc = GetTabIdLst4MapFuncByDnPath(objInFor);
                    arrTabId4MapFunc.ForEach(x => { if (arrTabId4MapFunc_All.Contains(x) == false) arrTabId4MapFunc_All.Add(x); });
                }
                return arrTabId4MapFunc_All;
            }
            catch (Exception objException)
            {
                var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                var objPrjTab_In = clsPrjTabBL.GetObjByTabIdCache(strInTabId, objProject.PrjId);
                strMsg = string.Format("根据表的所有字段获取所有路径时出错。Cm工程：[{0}({1})]，表:[{2}({3})]。错误：{4}(in {5})",
                    objProject.PrjName, objProject.PrjId,
                    objPrjTab_In.TabName, objPrjTab_In.TabId,
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }


        public static List<string> GetDnFunctionIdLst4FunMapByInDataNodeInTabIdCache(string strPrjId, string strInTabId)
        {
            //获取所有的结点
            //List<clsDataNodeEN> arrObjLstCache = clsDataNodeBL.GetObjLstCache(strPrjId);
            var strMsg = "";

            try
            {
                List<clsDataNodeEN> arrInDataNode = clsDataNodeBLEx.GetObjLstByTabIdCache(strInTabId, strPrjId);

                if (arrInDataNode.Count == 0)
                {

                    strMsg = string.Format("错误: 表:{0}(工程Id:{1})没有相关结点,请检查！(In {2})",
                       strInTabId, strPrjId, clsStackTrace.GetCurrClassFunction());

                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                }
                var arrInDataNodeId = arrInDataNode.Select(x => x.DataNodeId).ToList();
                var arrDnPath = clsDnPathBL.GetObjLstCache(strPrjId);
                var arrDnPath_Sel = arrDnPath.Where(x => arrInDataNodeId.Contains(x.InDataNodeId) == true).ToList();
                //return arrDnPath_Sel;
                List<string> arrDnFunctionId4MapFunc_All = new List<string>();

                foreach (var objInFor in arrDnPath_Sel)
                {
                    List<string> arrDnFunctionId4MapFunc = GetDnFunctionIdLst4MapFuncByDnPath(objInFor);
                    arrDnFunctionId4MapFunc.ForEach(x => { if (arrDnFunctionId4MapFunc_All.Contains(x) == false) arrDnFunctionId4MapFunc_All.Add(x); });
                }
                return arrDnFunctionId4MapFunc_All;
            }
            catch (Exception objException)
            {
                var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                var objPrjTab_In = clsPrjTabBL.GetObjByTabIdCache(strInTabId, objProject.PrjId);
                strMsg = string.Format("根据表的所有字段获取所有路径时出错。工程：[{0}({1})]，表:[{2}({3})]。错误：{4}(in {5})",
                    objProject.PrjName, objProject.PrjId,
                    objPrjTab_In.TabName, objPrjTab_In.TabId,
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }

        }


        public static clsDnPathEN CreateDnPath(string strPrjId, long strInDataNodeId, long strOutDataNodeId, string strOpUserId)
        {
            List<clsDnFuncMapEN> arrDnFuncMap = null;
            clsDataNodeEN objDataNode_Out = null;
            clsDataNodeEN objDataNode_In = null;

            try
            {
                objDataNode_Out = clsDataNodeBL.GetObjByDataNodeIdCache(strOutDataNodeId, strPrjId);

                if (objDataNode_Out == null)
                {
                    var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                    string strMsg = string.Format("结点Id:[{0}]的结点不存在。PrjId=[{1}({2})]，请检查！(In {3})",
                        strOutDataNodeId, objProject.PrjName, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                objDataNode_In = clsDataNodeBL.GetObjByDataNodeIdCache(strInDataNodeId, strPrjId);

                if (objDataNode_In == null)
                {
                    var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                    string strMsg = string.Format("结点Id:[{0}]的结点不存在。PrjId=[{1}({2})]，请检查！(In {3})",
                        strInDataNodeId, objProject.PrjName, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrDnFuncMap = clsDnFuncMapBLEx.GetGraphPath(strInDataNodeId, strOutDataNodeId, strPrjId);

                if (arrDnFuncMap == null || arrDnFuncMap.Count == 0) return null;

                string strDnPathNodeLst = strInDataNodeId.ToString();
                string strAssociationMappingId = enumAssociationMapping.OneToOne_01;
                int intEdgeNum = arrDnFuncMap.Count;
                int intIndex = 1;
                foreach (var objDnFuncMap in arrDnFuncMap)
                {
                    intIndex++;
                    if (objDnFuncMap == null)
                    {
                        string strMsg = string.Format("获取路径时，第二个映射为空。(in {0})", clsStackTrace.GetCurrFunction());
                        throw new Exception(strMsg);
                    }
                    strDnPathNodeLst += string.Format(",{0}", objDnFuncMap.OutDataNodeId);
                    if (objDnFuncMap.AssociationMappingId == enumAssociationMapping.OneToMany_02)
                        strAssociationMappingId = enumAssociationMapping.OneToMany_02;
                    
                }

                clsDnPathEN objDnPath = new clsDnPathEN();
                objDnPath.DnPathName = string.Format("{0}-{1}", objDataNode_In.DataNodeName, objDataNode_Out.DataNodeName);    //DN路径Id
                objDnPath.InDataNodeId = strInDataNodeId;    //In数据结点Id
                objDnPath.OutDataNodeId = strOutDataNodeId;    //Out数据结点Id
                objDnPath.DnPathNodeLst = strDnPathNodeLst;    //DN路径Id
                objDnPath.EdgeNum = intEdgeNum;
                objDnPath.AssociationMappingId = strAssociationMappingId;    //关联关系映射Id
                objDnPath.PrjId = objDataNode_In.PrjId;    //工程ID
                
                objDnPath.UpdDate = clsDateTime.getTodayDateTimeStr(1);    //修改日期
                objDnPath.UpdUser = strOpUserId;    //修改者
                string strCondition = objDnPath.GetUniCondStr();
                if (clsDnPathBL.IsExistRecord(strCondition) == false)
                {
                    objDnPath.Memo = string.Format("自动创建-{0}", objDnPath.UpdDate);    //说明
                    objDnPath.AddNewRecordWithMaxId();
                }
                else
                {
                    objDnPath.UpdateWithCondition(strCondition);
                    objDnPath.DnPathId = clsDnPathBL.GetPrimaryKeyID_S(strCondition)[0];
                }

                strCondition = string.Format("{0}='{1}'", conDnPathFuncMapRela.DnPathId, objDnPath.DnPathId);
                clsDnPathFuncMapRelaBL.DelDnPathFuncMapRelasByCond(strCondition);
                foreach (var objDnFuncMap in arrDnFuncMap)
                {
                    clsDnPathFuncMapRelaBLEx.CreateRela(strPrjId, objDnPath.DnPathId, objDnFuncMap.DnFuncMapId, strOpUserId);
                }
                return objDnPath;
            }
            catch (Exception objException)
            {
                var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                string strMsg = string.Format("In结点:{0}({1}),Out结点:[{2}({3})]在获取路径时，出错:{4}。 PrjId={5}({6})，请检查！(In {7})",
                    objDataNode_In.DataNodeName, objDataNode_In.DataNodeId,
                    objDataNode_Out.DataNodeName, objDataNode_Out.DataNodeId,
                    objException.Message,
                    objProject.PrjName, strPrjId,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


        public static bool RepairDnPath(string strDnPathId, string strOpUserId)
        {
            var objDnPath = clsDnPathBL.GetObjByDnPathId(strDnPathId);
            var strPrjId = objDnPath.PrjId;
            long strInDataNodeId = objDnPath.InDataNodeId;
            long strOutDataNodeId = objDnPath.OutDataNodeId;
            List<clsDnFuncMapEN> arrDnFuncMap = null;
            clsDataNodeEN objDataNode_Out = null;
            clsDataNodeEN objDataNode_In = null;

            try
            {
                objDataNode_Out = clsDataNodeBL.GetObjByDataNodeIdCache(strOutDataNodeId, strPrjId);

                if (objDataNode_Out == null)
                {
                    var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                    string strMsg = string.Format("结点Id:[{0}]的结点不存在。PrjId=[{1}({2})]，请检查！(In {3})",
                        strOutDataNodeId, objProject.PrjName, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                objDataNode_In = clsDataNodeBL.GetObjByDataNodeIdCache(strInDataNodeId, strPrjId);

                if (objDataNode_In == null)
                {
                    var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                    string strMsg = string.Format("结点Id:[{0}]的结点不存在。PrjId=[{1}({2})]，请检查！(In {3})",
                        strInDataNodeId, objProject.PrjName, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrDnFuncMap = clsDnFuncMapBLEx.GetGraphPath(strInDataNodeId, strOutDataNodeId, strPrjId);

                if (arrDnFuncMap == null || arrDnFuncMap.Count == 0) return false;

                string strDnPathNodeLst = strInDataNodeId.ToString();
                string strAssociationMappingId = enumAssociationMapping.OneToOne_01;
                int intEdgeNum = arrDnFuncMap.Count;
                int intIndex = 1;
                foreach (var objDnFuncMap in arrDnFuncMap)
                {
                    intIndex++;
                    if (objDnFuncMap == null)
                    {
                        string strMsg = string.Format("获取路径时，第二个映射为空。(in {0})", clsStackTrace.GetCurrFunction());
                        throw new Exception(strMsg);
                    }
                    strDnPathNodeLst += string.Format(",{0}", objDnFuncMap.OutDataNodeId);
                    if (objDnFuncMap.AssociationMappingId == enumAssociationMapping.OneToMany_02)
                        strAssociationMappingId = enumAssociationMapping.OneToMany_02;
                }
                               
                objDnPath.DnPathName = string.Format("{0}-{1}", objDataNode_In.DataNodeName, objDataNode_Out.DataNodeName);    //DN路径Id
                objDnPath.InDataNodeId = strInDataNodeId;    //In数据结点Id
                objDnPath.OutDataNodeId = strOutDataNodeId;    //Out数据结点Id
                objDnPath.DnPathNodeLst = strDnPathNodeLst;    //DN路径Id
                objDnPath.EdgeNum = intEdgeNum;
                objDnPath.AssociationMappingId = strAssociationMappingId;    //关联关系映射Id
                objDnPath.PrjId = objDataNode_In.PrjId;    //工程ID
                objDnPath.ErrMsg = "";
                objDnPath.UpdDate = clsDateTime.getTodayDateTimeStr(1);    //修改日期
                objDnPath.UpdUser = strOpUserId;    //修改者
              
                objDnPath.Update();

                var strCondition = string.Format("{0}='{1}'", conDnPathFuncMapRela.DnPathId, objDnPath.DnPathId);
                clsDnPathFuncMapRelaBL.DelDnPathFuncMapRelasByCond(strCondition);
                foreach (var objDnFuncMap in arrDnFuncMap)
                {
                    clsDnPathFuncMapRelaBLEx.CreateRela(strPrjId, objDnPath.DnPathId, objDnFuncMap.DnFuncMapId, strOpUserId);
                }
                return true;
            }
            catch (Exception objException)
            {
                var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                string strMsg = string.Format("In结点:{0}({1}),Out结点:[{2}({3})]在获取路径时，出错:{4}。 PrjId={5}({6})，请检查！(In {7})",
                    objDataNode_In.DataNodeName, objDataNode_In.DataNodeId,
                    objDataNode_Out.DataNodeName, objDataNode_Out.DataNodeId,
                    objException.Message,
                    objProject.PrjName, strPrjId,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //return false;
        }



        public static List<string> GetCacheClassifyFieldLst(List<string> arrDnPathId, string strPrjId)
        {
            List<string> arrCacheClassifyFieldLst = new List<string>();
            
            foreach (var strDnPathId in arrDnPathId)
            {
                var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(strDnPathId, strPrjId);
                if (objDnPath == null) continue;
                var arrDataNodeLstS = objDnPath.DnPathNodeLst.Split(',');
                
                var arrDataNodeLst = arrDataNodeLstS.Select(x => long.Parse(x)).ToList();
                
                bool bolIsHasErr = false;
                for (int i = 0; i < arrDataNodeLst.Count - 1; i++)
                {
                    var objDn_Start = clsDataNodeBL.GetObjByDataNodeIdCache(arrDataNodeLst[i], strPrjId);
                    if (objDn_Start == null)
                    {
                        bolIsHasErr = true;
                        break;
                    }
                    var objDn_End = clsDataNodeBL.GetObjByDataNodeIdCache(arrDataNodeLst[i + 1], strPrjId);
                    if (objDn_End == null)
                    {
                        bolIsHasErr = true;
                        break;
                    }
                    var objDnFuncMap = clsDnFuncMapBLEx.GetObjByInOutDataNodeIdCacheEx(arrDataNodeLst[i], arrDataNodeLst[i + 1], strPrjId);
                    if (objDnFuncMap == null)
                    {
                        bolIsHasErr = true;
                        break;
                    }
                    if (objDnFuncMap.FuncMapModeId == enumFuncMapMode.Table_01)
                    {
                        var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objDnFuncMap.TabId, strPrjId);
                        if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
                        {
                            arrCacheClassifyFieldLst.Add(objPrjTab.CacheClassifyFieldTS);
                        }
                        if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField2TS) == false)
                        {
                            arrCacheClassifyFieldLst.Add(objPrjTab.CacheClassifyField2TS);
                        }

                    }
                }
                if (bolIsHasErr == true) continue;

            }
            return arrCacheClassifyFieldLst;
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="strDnPathId">表关键字</param>
        /// <param name = "strPrjId">缓存的分类字段</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strDnPathId, string strPrjId)
        {
            clsSpecSQLforSql objSQL;
            //获取连接对象
            objSQL = clsDnPathDA.GetSpecSQLObj();
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
                //删除与表:[DnPath]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'", conDnPath.DnPathId, strDnPathId);
                clsDnPathFuncMapRelaBL.DelDnPathFuncMapRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                
                clsDnPathBL.DelRecord(strDnPathId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsDnPathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
                objException.Message,
                strDnPathId, clsStackTrace.GetCurrClassFunction());
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
        public static bool DelRecordByCond(string strCondition, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
        {
            try
            {
                string strSQL = "";
                clsSpecSQLforSql objSQL;
                //获取连接对象
                objSQL = clsDnPathDA.GetSpecSQLObj();
                //删除DnPath本表中与当前对象有关的记录
                strSQL = strSQL + "Delete from DnPath where " + strCondition + "";
                bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);

                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                ReFreshCache(strPrjId);
                return bolResult;
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

    }
}