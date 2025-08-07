
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDataNodeBLEx
表名:DataNode(00050547)
生成代码版本:2020.05.28.1
生成日期:2020/06/02 01:32:57
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:AI模块
模块英文名:AIModule
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
using TzAdvancedLib;
using System.Web.UI.WebControls;
using com.taishsoft.util;

namespace AGC.BusinessLogicEx
{
    public static class clsDataNodeBLEx_Static
    {
        public static clsFieldTabEN ObjFieldTab(this clsDataNodeEN objDataNodeEN)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objDataNodeEN.FldId, objDataNodeEN.PrjId);
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static string StandardDataNodeName(this clsDataNodeEN objDataNodeEN)
        {
            try
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objDataNodeEN.TabId, objDataNodeEN.PrjId);
                if (objPrjTab == null) return "";
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objDataNodeEN.FldId, objDataNodeEN.PrjId);
                if (objFieldTab == null) return "";
                return $"{objPrjTab.TabName}-{objFieldTab.FldName}";
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static string FldName(this clsDataNodeEN objDataNodeEN)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objDataNodeEN.FldId, objDataNodeEN.PrjId);
                if (objFieldTab == null) return "";
                return objFieldTab.FldName;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsPrjTabEN ObjPrjTab(this clsDataNodeEN objDataNodeEN)
        {
            try
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objDataNodeEN.TabId, objDataNodeEN.PrjId);
                return objPrjTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取表对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static string TabName(this clsDataNodeEN objDataNodeEN)
        {
            try
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objDataNodeEN.TabId, objDataNodeEN.PrjId);
                if (objPrjTab != null) return objPrjTab.TabName;
                return "";
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取表对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }


        public static string DataNodeName4GC(this clsDataNodeEN objDataNodeEN)
        {
            string strDataNodeName4GC = objDataNodeEN.DataNodeName.Replace("_", "").Replace("-","");
            return strDataNodeName4GC;
        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDataNodeENS">源对象</param>
        /// <returns>目标对象=>clsDataNodeEN:objDataNodeENT</returns>
        public static clsDataNodeENEx CopyToEx(this clsDataNodeEN objDataNodeENS)
        {
            try
            {
                clsDataNodeENEx objDataNodeENT = new clsDataNodeENEx();
                clsDataNodeBL.DataNodeDA.CopyTo(objDataNodeENS, objDataNodeENT);
                return objDataNodeENT;
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
        /// <param name = "objDataNodeENS">源对象</param>
        /// <returns>目标对象=>clsDataNodeEN:objDataNodeENT</returns>
        public static clsDataNodeEN CopyTo(this clsDataNodeENEx objDataNodeENS)
        {
            try
            {
                clsDataNodeEN objDataNodeENT = new clsDataNodeEN();
                clsDataNodeBL.CopyTo(objDataNodeENS, objDataNodeENT);
                return objDataNodeENT;
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
    /// 数据结点(DataNode)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsDataNodeBLEx : clsDataNodeBL
    {
        private static Graph objGraph = null;
        private static string strCreateGraphTime = "";
        private static string strPrjId_CreateGraph = "";
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsDataNodeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsDataNodeDAEx DataNodeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsDataNodeDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objDataNodeENS">源对象</param>
        /// <returns>目标对象=>clsDataNodeEN:objDataNodeENT</returns>
        public static clsDataNodeENEx CopyToEx(clsDataNodeEN objDataNodeENS)
        {
            try
            {
                clsDataNodeENEx objDataNodeENT = new clsDataNodeENEx();
                clsDataNodeBL.DataNodeDA.CopyTo(objDataNodeENS, objDataNodeENT);
                return objDataNodeENT;
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
        public static List<clsDataNodeENEx> GetObjExLst(string strCondition)
        {
            List<clsDataNodeEN> arrObjLst = clsDataNodeBL.GetObjLst(strCondition);
            List<clsDataNodeENEx> arrObjExLst = new List<clsDataNodeENEx>();
            foreach (clsDataNodeEN objInFor in arrObjLst)
            {
                clsDataNodeENEx objDataNodeENEx = new clsDataNodeENEx();
                clsDataNodeBL.CopyTo(objInFor, objDataNodeENEx);
                arrObjExLst.Add(objDataNodeENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strDataNodeId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsDataNodeENEx GetObjExByDataNodeId(long strDataNodeId)
        {
            clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId(strDataNodeId);
            clsDataNodeENEx objDataNodeENEx = new clsDataNodeENEx();
            clsDataNodeBL.CopyTo(objDataNodeEN, objDataNodeENEx);
            return objDataNodeENEx;
        }
        public static string GetFldIdByDataNodeIdCache(long strDataNodeId, string strPrjId)
        {
            clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeIdCache(strDataNodeId, strPrjId);
            if (objDataNodeEN == null) return "";
            return objDataNodeEN.FldId;
        }
        public static long GetKeyIdByName(string strDataNodeName, string strPrjId)
        {
            string strCondition = new clsDataNodeEN()
                .SetPrjId(strPrjId, "=")
                .SetDataNodeName(strDataNodeName, "=")
                .GetCombineCondition();
            long strKeyId = GetFirstID_S(strCondition);
            return strKeyId;
        }
        public static long GetKeyIdByNameCache(string strDataNodeName, string strPrjId)
        {
            string strCondition = new clsDataNodeEN()
                .SetPrjId(strPrjId, "=")
                .SetDataNodeName(strDataNodeName, "=")
                .GetCombineCondition();
            var arrDataNodeCache = clsDataNodeBL.GetObjLstCache(strPrjId);
            var objDataNode = arrDataNodeCache.Find(x => x.DataNodeName == strDataNodeName);
            if (objDataNode != null) return objDataNode.DataNodeId;
            return 0;
        }
        public static int ImportNode4TabId(string strTabId, string strPrjId)
        {
            int intCount = 0;
            string[] arrFieldTypeId = { enumFieldType.KeyField_02, enumFieldType.NameField_03 };
            
            var arrPrjTabFld_Sel = clsvPrjTabFld_SimBL.GetObjLstCache(strPrjId);

            Func<clsvPrjTabFld_SimEN, clsDataNodeEN> GetDataNodeByPrjTabFld2 = obj => GetDataNodeByPrjTabFld(obj, strPrjId);

            var arrDataNode_All = arrPrjTabFld_Sel.Select(GetDataNodeByPrjTabFld2).ToList();

            var arrDataNodeName = clsDataNodeBL.GetObjLstCache(strPrjId).Select(x => x.DataNodeName);

            //var arrDataNode_Add = arrDataNode_All.Where(x => arrDataNodeName.Contains(x.DataNodeName) == false);
            foreach (var objInFor in arrDataNode_All)
            {
                //objInFor.DataNodeId = GetMaxStrId_S();
                if (arrDataNodeName.Contains(objInFor.DataNodeName))
                {
                    objInFor.DataNodeId = GetKeyIdByName(objInFor.DataNodeName, strPrjId);
                    continue;
                }
                
                string strCondition = objInFor.GetUniCondStr();
                if (clsDataNodeBL.IsExistRecord(strCondition) == false)
                {
                    objInFor.AddNewRecord();
                    clsDataNodeBL.ReFreshCache(strPrjId);
                }
                intCount++;
            }

            var arrDataNode_Key = arrDataNode_All.Where(x => x.DataNodeTypeId == enumDataNodeType.Keyword_01);
            if (arrDataNode_Key.Count() > 1)
            {
                string strMsg = string.Format("当前表:[{0}]的关键字超过1个，在当前程序没有被处理。(In {1})",
                    clsPrjTabBL.GetNameByTabIdCache(strTabId, strPrjId), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (arrDataNode_Key.Count() == 0)
            {
                string strMsg = string.Format("当前表:[{0}]的没有关键字，非正常表，请处理。(In {1})",
                    clsPrjTabBL.GetNameByTabIdCache(strTabId, strPrjId), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            var objDataNode_Key = arrDataNode_Key.First();
            var arrDataNode_NotKey = arrDataNode_All.Where(x => x.DataNodeTypeId != enumDataNodeType.Keyword_01);

            foreach (var objDataNode_NotKey in arrDataNode_NotKey)
            {
                if (objDataNode_NotKey != null)
                {
                    if (objDataNode_Key.DataNodeId == 0) continue;
                    var objDnFuncMap = new clsDnFuncMapEN();
                    objDnFuncMap.InDataNodeId = objDataNode_Key.DataNodeId;// In数据结点
                    objDnFuncMap.OutDataNodeId = objDataNode_NotKey.DataNodeId;// Out数据结点
                    objDnFuncMap.AssociationMappingId = enumAssociationMapping.OneToOne_01;// 关系映射
                    objDnFuncMap.FuncMapModeId = enumFuncMapMode.Table_01;// 映射模式
                    objDnFuncMap.TabId = objDataNode_Key.TabId;// 表
                    
                    objDnFuncMap.PrjId = objDataNode_NotKey.PrjId;// 工程ID
                    objDnFuncMap.Memo = "自动生成In" + clsStackTrace.GetCurrClassFunction();// 说明
                    objDnFuncMap.UpdUser = "sys";// 修改者
                    objDnFuncMap.EditRecordEx();
                    clsDnFuncMapBL.ReFreshCache(strPrjId);
                }
            }
            return intCount;
            //            throw new NotImplementedException();
        }
        public static int ImportNode4KeyAndName(string strCmPrjId)
        {
            int intCount = 0;
            string[] arrFieldTypeId = { enumFieldType.KeyField_02, enumFieldType.NameField_03 };
            string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var arrPrjTab = clsPrjTabBLEx.GetObjLstByCmPrjIdCacheEx(strPrjId, strCmPrjId);
            if (arrPrjTab.Count == 0)
            {
                var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
                string strMsg = string.Format("CM工程:[{0}({1})]的相关表为空，请检查！", objCMProject.CmPrjName, objCMProject.CmPrjId);
                throw new Exception(strMsg);
            }
            var arrTabId_Tab = arrPrjTab
                .Where(x => x.TabStateId == enumTabState.Normal_01)
                .Where(x => x.SqlDsTypeId == enumSQLDSType.SqlTab_01).Select(x => x.TabId).ToList();
            var arrPrjTabFld = clsvPrjTabFld_SimBL.GetObjLstCache(strPrjId).Where(x => arrTabId_Tab.Contains(x.TabId)).ToList();
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => arrFieldTypeId.Contains(x.FieldTypeId)).ToList();
            Func<clsvPrjTabFld_SimEN, clsDataNodeEN> GetDataNodeByPrjTabFld2 = obj => GetDataNodeByPrjTabFld(obj, strPrjId);

            var arrDataNode_All = arrPrjTabFld_Sel.Select(GetDataNodeByPrjTabFld2).ToList();

            var arrDataNodeCache = clsDataNodeBL.GetObjLstCache(strPrjId);

            var arrDataNodeName = arrDataNodeCache.Select(x => x.DataNodeName).ToList();


            var arrDataNode_Add = arrDataNode_All.Where(x => arrDataNodeName.Contains(x.DataNodeName) == false);
            foreach (var objInFor in arrDataNode_Add)
            {
                
                //objInFor.DataNodeId = GetMaxStrId_S();
                var strCondition = objInFor.GetUniCondStr();
                if (clsDataNodeBL.IsExistRecord(strCondition) == true) continue;
                long strDataNodeId = long.Parse( objInFor.AddNewRecordWithReturnKey());
                objInFor.DataNodeId = strDataNodeId;
                intCount++;
            }
            clsDataNodeBL.ReFreshCache(strPrjId);
            arrDataNodeCache = clsDataNodeBL.GetObjLstCache(strPrjId);

            var arrDataNode_Key = arrDataNodeCache.Where(x => x.DataNodeTypeId == enumDataNodeType.Keyword_01);
            foreach (var objDataNode_Key in arrDataNode_Key)
            {
                var objDataNode_Name = arrDataNodeCache.Find(x => x.DataNodeTypeId == enumDataNodeType.NameNode_02 && x.TabId == objDataNode_Key.TabId);
                if (objDataNode_Name != null)
                {
                    var objDnFuncMap = new clsDnFuncMapEN();
                    objDnFuncMap.InDataNodeId = objDataNode_Key.DataNodeId;// In数据结点
                    objDnFuncMap.OutDataNodeId = objDataNode_Name.DataNodeId;// Out数据结点
                    objDnFuncMap.AssociationMappingId = enumAssociationMapping.OneToOne_01;// 关系映射
                    objDnFuncMap.FuncMapModeId = enumFuncMapMode.Table_01;// 映射模式
                    objDnFuncMap.TabId = objDataNode_Key.TabId;// 表

                    
                    objDnFuncMap.PrjId = objDataNode_Name.PrjId;// 工程ID
                    objDnFuncMap.Memo = "自动生成In" + clsStackTrace.GetCurrClassFunction();// 说明
                    objDnFuncMap.UpdUser = "sys";// 修改者
                    objDnFuncMap.EditRecordEx();
                }
            }
            return intCount;
            //            throw new NotImplementedException();
        }
        public static int ImportSameSourceBy4KeyNode(string strCmPrjId)
        {
            int intCount = 0;
            string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            //string[] arrFieldTypeId = { enumFieldType.KeyField_02, enumFieldType.NameField_03 };
            var arrPrjTab = clsPrjTabBLEx.GetObjLstByCmPrjIdCacheEx(strPrjId, strCmPrjId).Where(x => x.TabStateId == enumTabState.Normal_01);
            var arrTabId_Tab = arrPrjTab.Where(x => x.SqlDsTypeId == enumSQLDSType.SqlTab_01).Select(x => x.TabId);

            //var arrPrjTabFld = clsPrjTabFldBL.GetObjLstCache(strPrjId)
            //    .Where(x => x.PrimaryTypeId != enumPrimaryType.Identity_02)
            //    .Where(x => arrTabId_Tab.Contains(x.TabId));

            var arrDataNode_Key = clsDataNodeBL.GetObjLstCache(strPrjId).Where(x => x.DataNodeTypeId == enumDataNodeType.Keyword_01);

            //var arrFldId = arrDataNode_Key.Select(x => x.FldId);

            //var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => arrFldId.Contains(x.FldId));

            //var arrDataNode_All = arrPrjTabFld_Sel.Select(GetDataNodeByPrjTabFld);

            var arrDataNodeId = clsDataNodeBL.GetObjLstCache(strPrjId).Select(x => x.DataNodeId);

            //var arrDataNode_Add = arrDataNode_All.Where(x => arrDataNodeName.Contains(x.DataNodeName) == false);


            var arrDnFunction_Eq = clsDnFunctionBL.GetObjLstCache(strPrjId).Where(x => x.DnFunctionName == "equal").First();

            foreach (var objInFor_KeyA in arrDataNode_Key)
            {
                foreach (var objInFor_KeyB in arrDataNode_Key)
                {
                    if (objInFor_KeyA.FldId != objInFor_KeyB.FldId) continue;
                    if (objInFor_KeyA.TabId == objInFor_KeyB.TabId) continue;

                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor_KeyA.FldId, objInFor_KeyA.PrjId);
                    if (objFieldTab.FldName == "mId") continue;
                    if (objFieldTab.FldName == "PrimaryTypeId")
                    {
                        //string ss = "";
                    }
                    var objDnFuncMap = new clsDnFuncMapEN();
                    objDnFuncMap.InDataNodeId = objInFor_KeyA.DataNodeId;// In数据结点
                    objDnFuncMap.OutDataNodeId = objInFor_KeyB.DataNodeId;// Out数据结点
                    objDnFuncMap.AssociationMappingId = enumAssociationMapping.OneToOne_01;// 关系映射
                    objDnFuncMap.FuncMapModeId = enumFuncMapMode.Function_02;// 映射模式
                    objDnFuncMap.TabId = "";// 表
                    
                    objDnFuncMap.PrjId = objInFor_KeyB.PrjId;// 工程ID
                    objDnFuncMap.DnFunctionId = arrDnFunction_Eq.DnFunctionId;// DN函数
                    objDnFuncMap.Memo = "自动生成In" + clsStackTrace.GetCurrClassFunction();// 说明
                    objDnFuncMap.UpdUser = "sys";// 修改者
                    objDnFuncMap.EditRecordEx();
                    intCount++;

                    clsDnFuncMapBL.ReFreshCache(strPrjId);
                }
            }

            foreach (var objInFor_Key in arrDataNode_Key)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor_Key.FldId, objInFor_Key.PrjId);

                if (objFieldTab.FldName == "mId") continue;
                var arrPrjTabFld_Sel = clsvPrjTabFld_SimBLEx.GetObjLstByFldIdCache(objInFor_Key.FldId, objInFor_Key.PrjId);
                arrPrjTabFld_Sel = arrPrjTabFld_Sel
                    .Where(x => arrTabId_Tab.Contains(x.TabId) == true)
                    .Where(x => x.TabId != objInFor_Key.TabId).ToList();
                Func<clsvPrjTabFld_SimEN, clsDataNodeEN> GetDataNodeByPrjTabFld2 = obj => GetDataNodeByPrjTabFld(obj, strPrjId);

                var arrDataNode_All = arrPrjTabFld_Sel.Select(GetDataNodeByPrjTabFld2);
                
                var arrDataNode_All_Sel = arrDataNode_All.Where(x => arrDataNodeId.Contains(x.DataNodeId) == false);
                
                foreach (var objInFor in arrDataNode_All_Sel)
                {
                    //objInFor.DataNodeId = GetMaxStrId_S();
                    if (objInFor.DataNodeTypeId == enumDataNodeType.Unknown_05) objInFor.DataNodeTypeId = enumDataNodeType.GeneralCode_03;
                    try
                    {
                        
                        long strDataNodeId = long.Parse( objInFor.AddNewRecordWithReturnKey());
                        objInFor.DataNodeId = strDataNodeId;
                        clsDataNodeBL.ReFreshCache(strPrjId);
                    }
                    catch (Exception objException)
                    {
                        string ss = objException.Message;
                        continue;
                    }
                    if (objInFor.DataNodeId == 0) continue;
                }
                foreach (var objInFor in arrDataNode_All)
                {
                    if (objInFor.DataNodeId == 0)
                    {
                        var obj = clsDataNodeBLEx.GetObjByTabIdAndFldIdCache(objInFor.TabId, objInFor.FldId, objInFor.VersionNo, objInFor.PrjId);
                        objInFor.DataNodeId = obj.DataNodeId;
                        if (objInFor.DataNodeId == 2425)
                        {
                            //string ss = "";
                        }
                    }
                    var arrId = new List<long>() { 1219, 7354 };
                    if (arrId.Contains(objInFor.DataNodeId) == true)
                    {
                        //string ss = "";
                    }
                    var objDnFuncMap = new clsDnFuncMapEN();
                    objDnFuncMap.InDataNodeId = objInFor.DataNodeId;// In数据结点
                    objDnFuncMap.OutDataNodeId = objInFor_Key.DataNodeId;// Out数据结点
                    objDnFuncMap.AssociationMappingId = enumAssociationMapping.OneToOne_01;// 关系映射
                    objDnFuncMap.FuncMapModeId = enumFuncMapMode.Function_02;// 映射模式
                    objDnFuncMap.TabId = "";// 表
                    
                    objDnFuncMap.PrjId = objInFor.PrjId;// 工程ID
                    objDnFuncMap.DnFunctionId = arrDnFunction_Eq.DnFunctionId;// DN函数
                    objDnFuncMap.Memo = "自动生成In" + clsStackTrace.GetCurrClassFunction();// 说明
                    objDnFuncMap.UpdUser = "sys";// 修改者
                    objDnFuncMap.EditRecordEx();
                    intCount++;
                    clsDnFuncMapBL.ReFreshCache(strPrjId);
                }
            }
            return intCount;
            //            throw new NotImplementedException();
        }

        public static clsDataNodeEN GetDataNodeByPrjTabFld(clsvPrjTabFld_SimEN objPrjTabFld, string strPrjId)
        {
            clsDataNodeEN objDataNode = new clsDataNodeEN();
            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabFld.TabId, strPrjId);
            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, strPrjId);
            objDataNode.DataNodeName = string.Format("{0}_{1}", objPrjTab.TabName, objFieldTab.FldName);
            objDataNode.TabId = objPrjTabFld.TabId;
            objDataNode.FldId = objPrjTabFld.FldId;
            objDataNode.VersionNo = 1;
            

            objDataNode.PrjId = objPrjTabFld.PrjId;
            objDataNode.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objDataNode.UpdUser = "sys";
            if (objPrjTabFld.FieldTypeId == enumFieldType.KeyField_02) objDataNode.DataNodeTypeId = enumDataNodeType.Keyword_01;
            else if (objPrjTabFld.FieldTypeId == enumFieldType.NameField_03) objDataNode.DataNodeTypeId = enumDataNodeType.NameNode_02;
            else objDataNode.DataNodeTypeId = enumDataNodeType.Unknown_05;
            return objDataNode;
        }

        public static Graph InitGraph(string strPrjId)
        {
            string strLastRefreshTime_DnFuncMap = clsDnFuncMapBL.GetLastRefreshTime();
            string strLastRefreshTime_DataNode = clsDataNodeBL.GetLastRefreshTime();
            bool bolIsNeedReCreate = false;
            if (clsDataNodeBLEx.strCreateGraphTime == "" || clsDataNodeBLEx.strPrjId_CreateGraph != strPrjId)
            {
                bolIsNeedReCreate = true;
            }
            else
            {
                if (strLastRefreshTime_DnFuncMap == "" && strLastRefreshTime_DataNode == "") bolIsNeedReCreate = false;
                if (clsDataNodeBLEx.strCreateGraphTime.CompareTo(strLastRefreshTime_DnFuncMap) > 0
                    && clsDataNodeBLEx.strCreateGraphTime.CompareTo(strLastRefreshTime_DataNode) > 0)
                {
                    bolIsNeedReCreate = false;
                }
                else
                {
                    bolIsNeedReCreate = true;
                }
            }
            if (bolIsNeedReCreate == true)
            { 
                Graph g = new Graph();

                var arrDnFuncMap = clsDnFuncMapBL.GetObjLstCache(strPrjId);
                var arrDataNode_InOut = GetDataNodeLst4Graph(strPrjId);

                InitGraph(g, arrDataNode_InOut, arrDnFuncMap);
                clsDataNodeBLEx.objGraph = g;
                clsDataNodeBLEx.strCreateGraphTime = clsDateTime.getTodayDateTimeStr(0);
                clsDataNodeBLEx.strPrjId_CreateGraph = strPrjId;
            }
            return clsDataNodeBLEx.objGraph;
        }

        public static List<clsDataNodeEN> GetDataNodeLst4Graph(string strPrjId)
        {

            var arrDataNode = clsDataNodeBL.GetObjLstCache(strPrjId);
            if (arrDataNode.Count == 0)
            {
                clsDataNodeBL.ReFreshCache(strPrjId);
                arrDataNode = clsDataNodeBL.GetObjLstCache(strPrjId);
                if (arrDataNode.Count == 0)
                {
                    var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                    string strMsg = string.Format("工程:[{0}({1})]的结点数为空，请检查！", objProject.PrjName, objProject.PrjId);
                    throw new Exception(strMsg);
                }
            }
            var arrDnFuncMap = clsDnFuncMapBL.GetObjLstCache(strPrjId);
            if (arrDnFuncMap.Count == 0)
            {
                clsDnFuncMapBL.ReFreshCache(strPrjId);
                arrDnFuncMap = clsDnFuncMapBL.GetObjLstCache(strPrjId);
                if (arrDnFuncMap.Count == 0)
                {
                    var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                    string strMsg = string.Format("工程:[{0}({1})]的结点函数映射数为空，请检查！", objProject.PrjName, objProject.PrjId);
                    throw new Exception(strMsg);
                }
            }
            var arrInDataNodeId = arrDnFuncMap.Select(x => x.InDataNodeId);
            var arrOutDataNodeId = arrDnFuncMap.Select(x => x.OutDataNodeId);
            var arrInOutDataNodeId = arrInDataNodeId.Union(arrOutDataNodeId).Distinct();
            var arrDataNode_InOut = arrDataNode.Where(x => arrInOutDataNodeId.Contains(x.DataNodeId)).OrderBy(x => x.DataNodeId).ToList();
            return arrDataNode_InOut;

        }

        private static void InitGraph(Graph g, List<clsDataNodeEN> arrDataNode, List<clsDnFuncMapEN> arrDnFuncMap, string strDirect = "")
        {
            if (arrDataNode.Count > 10000)
            {
                string strMsg = "当前CM工程的数据结点的个数超过10000个, 请联系管理员！";
                throw new Exception(strMsg);
            }
            //string strCondition = string.Format("PrjId = '{0}' Order By {1}",
            //    strPrjId, conDataNode.TabName);
            //string strCondition2 = string.Format("PrjId = '{0}'", strPrjId);

            //g.AddVertex("Tab-Root");

            foreach (clsDataNodeEN objDataNodeEN in arrDataNode)
            {
                //string strText = string.Format("{0}-{1}",
                //    objDataNodeEN.TabId, objDataNodeEN.TabName);
                try
                {
                    g.AddVertex(objDataNodeEN.DataNodeId.ToString(), objDataNodeEN.DataNodeName);
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }
            foreach (clsDnFuncMapEN objDnFuncMapEN in arrDnFuncMap)
            {
                if (objDnFuncMapEN.InDataNodeId == 15423)
                {
                    string ss = "15423";
                }
                int intStart = clsDataNodeBLEx.GetIndexByDataNodeId(objDnFuncMapEN.InDataNodeId, arrDataNode);
                int intEnd = clsDataNodeBLEx.GetIndexByDataNodeId(objDnFuncMapEN.OutDataNodeId, arrDataNode);
                if (intStart != -1 && intEnd != -1)
                {
                    if (strDirect == "ToUp")
                    {
                        g.AddEdge(intEnd, intStart);
                    }
                    else
                    {
                        g.AddEdge(intStart, intEnd);
                    }
                }
            }
            //g.AddVertex("Root");
            //g.AddVertex("Users");
            //g.AddVertex("Dept");
            //g.AddVertex("Student");
            //g.AddVertex("Teacher");


            //g.AddEdge(0, 1);
            //g.AddEdge(0, 2);
            //g.AddEdge(0, 3);
            //g.AddEdge(0, 4);

            //g.AddEdge(1, 5);
            //g.AddEdge(1, 6);
            //g.AddEdge(1, 7);


        }

        private static int GetIndexByDataNodeId(long inDataNodeId, List<clsDataNodeEN> arrDataNode)
        {
            if (inDataNodeId == 0) return -1;
            for (int intIndex = 0; intIndex < arrDataNode.Count; intIndex++)
            {
                if (arrDataNode[intIndex].DataNodeId == inDataNodeId)
                {
                    return intIndex;
                }
            }
            return -1;
        }

        public static long GetNewDataNodeIdByPrjId(long strDataNodeId, string strPrjId)
        {
            var objDataNode = clsDataNodeBL.GetObjByDataNodeId(strDataNodeId);
            if (objDataNode == null) return 0;
            var strDataNodeId_T = clsDataNodeBLEx.GetKeyIdByNameCache(objDataNode.DataNodeName, strPrjId);
            return strDataNodeId_T;
        }
        /// <summary>
        /// 获取两个端点之间的路径，以结点列表的形式
        /// </summary>
        /// <param name="strStartNodeId">起点</param>
        /// <param name="strEndNodeId">终点</param>
        /// <param name="strPrjId">Cm工程</param>
        /// <returns></returns>
        public static List<clsDataNodeEN> GetGraphPath(long strStartNodeId, long strEndNodeId, string strPrjId)
        {
            Graph g = clsDataNodeBLEx.InitGraph(strPrjId);
            var arrDataNode = GetDataNodeLst4Graph(strPrjId);
            g.SetAllVertexNoVisited();
            int intStart = clsDataNodeBLEx.GetIndexByDataNodeId(strStartNodeId, arrDataNode);
            int intEnd = clsDataNodeBLEx.GetIndexByDataNodeId(strEndNodeId, arrDataNode);
            if (strStartNodeId == 0)
            {
                string strMsg = string.Format("在查找路径时缺少开始结点！");
                throw new Exception(strMsg);
            }
            if (strEndNodeId == 0)
            {
                string strMsg = string.Format("在查找路径时缺少结束结点！");
                throw new Exception(strMsg);
            }
            List<long> arrDataNodeId = null;
            try
            {
                var arrPath = g.GetPathByBFS(intStart, intEnd);
                arrDataNodeId = arrPath.Select(x => long.Parse(x.KeyId)).ToList();
            }
            catch (Exception objException)
            {
                string strMsg = "";
                var objStartNode = clsDataNodeBL.GetObjByDataNodeIdCache(strStartNodeId, strPrjId);
                if (objStartNode == null)
                {
                    strMsg = string.Format("端点:{0}不存在。(In {1})", strStartNodeId, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                var objEndNode = clsDataNodeBL.GetObjByDataNodeIdCache(strEndNodeId, strPrjId);
                if (objEndNode == null)
                {
                    strMsg = string.Format("端点:{0}不存在。(In {1})", strEndNodeId, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                strMsg = string.Format("在{0}({1})-->{2}({3})之间未找到路径！错误:{4}",
                    objStartNode.DataNodeName, objStartNode.DataNodeId,
                    objEndNode.DataNodeName, objEndNode.DataNodeId, objException.Message);
                throw new Exception(strMsg);
            }

            List<clsDataNodeEN> arrDataNode_Result = arrDataNodeId.Select(x => clsDataNodeBL.GetObjByDataNodeIdCache(x, strPrjId)).ToList();
            return arrDataNode_Result;
        }

        public static List<clsDataNodeEN> GetConnectedNode(long strStartNodeId, string strPrjId)
        {
            Graph g = clsDataNodeBLEx.InitGraph(strPrjId);
            var arrDataNode = GetDataNodeLst4Graph(strPrjId);
            g.SetAllVertexNoVisited();
            int intStart = clsDataNodeBLEx.GetIndexByDataNodeId(strStartNodeId, arrDataNode);
            if (intStart == -1) return null;
            List<long> arrDataNodeId = null;

            try
            {
                var arrConnectedNode = g.GetConnectedNodeByBFS(intStart);
                arrDataNodeId = arrConnectedNode.Select(x => long.Parse(x.KeyId)).ToList();
                List<clsDataNodeEN> arrDataNode_Result = arrConnectedNode.Select(x => GetDataNodeByVertex(x, strPrjId)).ToList();
                return arrDataNode_Result;
            }
            catch (Exception objException)
            {
                throw objException;
            }

            //List<clsDataNodeEN> arrDataNode_Result = arrDataNodeId.Select(x => clsDataNodeBL.GetObjByDataNodeIdCache(x, strPrjId)).ToList();
            //return arrDataNode_Result;
        }


        public static List<clsDataNodeEN> GetConnectedNode_Prev(long strEndNodeId, string strPrjId)
        {
            Graph g = clsDataNodeBLEx.InitGraph(strPrjId);
            var arrDataNode = GetDataNodeLst4Graph(strPrjId);
            int intEnd = clsDataNodeBLEx.GetIndexByDataNodeId(strEndNodeId, arrDataNode);
            List<long> arrDataNodeId = null;
            try
            {
                var arrConnectedNode = g.GetConnectedNodeByBFS_Prev(intEnd);
                arrDataNodeId = arrConnectedNode.Select(x => long.Parse(x.KeyId)).ToList();
                List<clsDataNodeEN> arrDataNode_Result = arrConnectedNode.Select(x => GetDataNodeByVertex(x, strPrjId)).ToList();
                return arrDataNode_Result;
            }
            catch (Exception objException)
            {
                throw objException;
            }
            //List<clsDataNodeEN> arrDataNode_Result = arrDataNodeId.Select(x => clsDataNodeBL.GetObjByDataNodeIdCache(x, strPrjId)).ToList();
            //return arrDataNode_Result;
        }
        public static clsDataNodeEN GetDataNodeByVertex(Vertex objVertex, string strPrjId)
        {
            var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(long.Parse(objVertex.KeyId), strPrjId);
            objDataNode.Depth = objVertex.Depth;
            objDataNode.SubGraphName = string.Format("图-{0:D4}", objVertex.SubGraph_Index);

            if (objVertex.PrevVertex != null) objDataNode.PrevDataNodeId = long.Parse( objVertex.PrevVertex.KeyId);
            if (objVertex.NextVertex != null) objDataNode.NextDataNodeId = long.Parse(objVertex.NextVertex.KeyId);
            return objDataNode;
        }
        /// <summary>
        /// 在CM工程中获取与表Id相关的所有数据结点，即以该表的字段作为起点的所有相关结点
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <param name="strPrjId">CM工程Id</param>
        /// <returns></returns>
        public static List<clsDataNodeEN> GetConnectedNodeByTabId(string strTabId, string strPrjId)
        {
            Graph g = clsDataNodeBLEx.InitGraph(strPrjId);
            var arrDataNode = GetDataNodeLst4Graph(strPrjId);
            var arrDataNode_Start = arrDataNode.Where(x => x.TabId == strTabId);
            IEnumerable<long> arrDataNodeId_All = new List<long>();
            foreach (clsDataNodeEN objInFor in arrDataNode_Start)
            {
                long strStartNodeId = objInFor.DataNodeId;
                int intStart = clsDataNodeBLEx.GetIndexByDataNodeId(strStartNodeId, arrDataNode);
                IEnumerable<long> arrDataNodeId = null;
                try
                {
                    var arrConnectedNode = g.GetConnectedNodeByBFS(intStart);
                    arrDataNodeId = arrConnectedNode.Select(x => long.Parse(x.KeyId));
                    arrDataNodeId_All = arrDataNodeId_All.Union(arrDataNodeId);
                }
                catch (Exception objException)
                {

                    throw objException;
                }
            }
            arrDataNodeId_All = arrDataNodeId_All.Distinct();
            List<clsDataNodeEN> arrDataNode_Result = arrDataNodeId_All.Select(x => clsDataNodeBL.GetObjByDataNodeIdCache(x, strPrjId)).ToList();
            return arrDataNode_Result;
        }


        public static void BindDdl_ConnectedNode(DropDownList objDDL, long strStartNodeId, string strPrjId)
        {
            List<clsDataNodeEN> arrConnectedNode = clsDataNodeBLEx.GetConnectedNode(strStartNodeId, strPrjId);
            var objStartNode = clsDataNodeBL.GetObjByDataNodeIdCache(strStartNodeId, strPrjId);
            //var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objStartNode.TabId, vsPrjIdCache);
            //var arrFldId = arrPrjTabFld.Select(x => x.FldId);
            var arrDataNode_TabId = clsDataNodeBLEx.GetObjLstByTabIdCache(objStartNode.TabId, strPrjId);
            var arrDataNodeId = arrDataNode_TabId.Select(x => x.DataNodeId);
            arrConnectedNode = arrConnectedNode
                .Where(x => arrDataNodeId.Contains(x.DataNodeId) == false).ToList();
            //.OrderBy(x => x.DataNodeName).ToList();

            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conDataNode.DataNodeId);
            //IEnumerable<clsDataNodeEN> arrObjLst = clsDataNodeBL.GetObjLst(strCondition).OrderBy(x => x.DataNodeName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conDataNode.DataNodeId;
            objDDL.DataTextField = conDataNode.DataNodeName;
            objDDL.DataSource = arrConnectedNode;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        public static void BindDdl_ConnectedNodeV2(DropDownList objDDL, long strStartNodeId, string strPrjId, bool IsExcludeCurrTab = true)
        {
            List<clsDataNodeEN> arrConnectedNode = clsDataNodeBLEx.GetConnectedNode(strStartNodeId, strPrjId);
            if (IsExcludeCurrTab == true)
            {
                
                var objStartNode = clsDataNodeBL.GetObjByDataNodeIdCache(strStartNodeId, strPrjId);
                var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objStartNode.TabId, strPrjId);
                var arrFldId = arrPrjTabFld.Select(x => x.FldId);
                //var arrDataNode_TabId = clsDataNodeBLEx.GetObjLstByTabIdCache(objStartNode.TabId, vsPrjIdCache);
                //var arrDataNodeId = arrDataNode_TabId.Select(x => x.DataNodeId);
                arrConnectedNode = arrConnectedNode
                    .Where(x => arrFldId.Contains(x.FldId) == false)
                    .OrderBy(x => x.DataNodeName).ToList();
            }
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conDataNode.DataNodeId);
            //IEnumerable<clsDataNodeEN> arrObjLst = clsDataNodeBL.GetObjLst(strCondition).OrderBy(x => x.DataNodeName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conDataNode.DataNodeId;
            objDDL.DataTextField = conDataNode.DataNodeName;
            objDDL.DataSource = arrConnectedNode;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_ConnectedNodeV2_Prev(DropDownList objDDL, long strEndNodeId, string strPrjId)
        {
            List<clsDataNodeEN> arrConnectedNode = clsDataNodeBLEx.GetConnectedNode_Prev(strEndNodeId, strPrjId);
            var objEndNode = clsDataNodeBL.GetObjByDataNodeIdCache(strEndNodeId, strPrjId);
            
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objEndNode.TabId, strPrjId);
            //var arrFldId = arrPrjTabFld.Select(x => x.FldId);

            //arrConnectedNode = arrConnectedNode
            //    .Where(x => arrFldId.Contains(x.FldId) == false)
            //    .OrderBy(x => x.DataNodeName).ToList();

            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conDataNode.DataNodeId);
            //IEnumerable<clsDataNodeEN> arrObjLst = clsDataNodeBL.GetObjLst(strCondition).OrderBy(x => x.DataNodeName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conDataNode.DataNodeId;
            objDDL.DataTextField = conDataNode.DataNodeName;
            objDDL.DataSource = arrConnectedNode;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        public static void BindDdl_ConnectedNodeV3(DropDownList objDDL, string strTabId, string strPrjId)
        {

            List<clsDataNodeEN> arrConnectedNode = clsDataNodeBLEx.GetConnectedNodeByTabId(strTabId, strPrjId);
            //var objStartNode = clsDataNodeBL.GetObjByDataNodeIdCache(strStartNodeId, vsPrjIdCache);
            

            var arrDataNode_CurrTab = clsDataNodeBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            var arrDataNodeId_CurrTab = arrDataNode_CurrTab.Select(x => x.DataNodeId);
            //var arrDataNode_TabId = clsDataNodeBLEx.GetObjLstByTabIdCache(objStartNode.TabId, vsPrjIdCache);
            //var arrDataNodeId = arrDataNode_TabId.Select(x => x.DataNodeId);
            arrConnectedNode = arrConnectedNode
                .Where(x => arrDataNodeId_CurrTab.Contains(x.DataNodeId) == false || x.VersionNo > 1)
                .OrderBy(x => x.DataNodeName).ToList();

            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conDataNode.DataNodeId);
            //IEnumerable<clsDataNodeEN> arrObjLst = clsDataNodeBL.GetObjLst(strCondition).OrderBy(x => x.DataNodeName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conDataNode.DataNodeId;
            objDDL.DataTextField = conDataNode.DataNodeName;
            objDDL.DataSource = arrConnectedNode;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }



        public static void BindDdl_PathNode(DropDownList objDDL, long strStartNodeId, long strEndNodeId, string strPrjId)
        {

            List<clsDataNodeEN> arrPath = clsDataNodeBLEx.GetGraphPath(strStartNodeId, strEndNodeId, strPrjId);
            //arrPath = arrPath.OrderBy(x => x.DataNodeName).ToList();

            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conDataNode.DataNodeId);
            //IEnumerable<clsDataNodeEN> arrObjLst = clsDataNodeBL.GetObjLst(strCondition).OrderBy(x => x.DataNodeName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conDataNode.DataNodeId;
            objDDL.DataTextField = conDataNode.DataNodeName;
            objDDL.DataSource = arrPath;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static List<clsDataNodeEN> GetObjLstByTabIdCache(string strTabId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDataNodeEN> arrObjLstCache = clsDataNodeBL.GetObjLstCache(strPrjId);

            IEnumerable<clsDataNodeEN> arrDataNodeObjLst_Sel1 =
            from objDataNodeEN in arrObjLstCache
            where objDataNodeEN.TabId == strTabId
            select objDataNodeEN;
            List<clsDataNodeEN> arrDataNodeObjLst_Sel = new List<clsDataNodeEN>();
            foreach (clsDataNodeEN obj in arrDataNodeObjLst_Sel1)
            {
                arrDataNodeObjLst_Sel.Add(obj);
            }
            //if (arrDataNodeObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return arrDataNodeObjLst_Sel;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strTabId">所给的表Id</param>
        /// <param name = "strFldId">所给的字段Id</param>
        /// <param name = "intVersionNo">版本号</param>
        /// <param name = "strPrjId">缓存分类字段</param>        
        /// <returns>根据关键字获取的对象</returns>
        public static clsDataNodeEN GetObjByTabIdAndFldIdCache(string strTabId, string strFldId, int intVersionNo, string strPrjId)
        {
            if (string.IsNullOrEmpty(strTabId) == true) return null;
            if (string.IsNullOrEmpty(strFldId) == true) return null;

            //获取缓存中的对象列表
            string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
            List<clsDataNodeEN> arrDataNodeObjLstCache = GetObjLstCache(strPrjId);
            IEnumerable<clsDataNodeEN> arrDataNodeObjLst_Sel;
            if (intVersionNo == 0)
            {
                arrDataNodeObjLst_Sel =
                arrDataNodeObjLstCache
                .Where(x => x.TabId == strTabId && x.FldId == strFldId);
                if (arrDataNodeObjLst_Sel.Count() == 0)
                {
                    var strCond = new clsDataNodeEN()
                        .SetTabId(strTabId, "=")
                        .SetFldId(strFldId, "=")
                        .GetCombineCondition();
                    clsDataNodeEN obj = clsDataNodeBL.GetFirstObj_S(strCond);
                    if (obj != null)
                    {
                       
                            clsDataNodeBL.ReFreshCache(obj.PrjId);
                        //}
                        //else
                        //{
                        //    string strMsg = string.Format("错误: 表:{0}、字段:{1}不属于Cm工程Id:{2},请检查！(In {3})",
                        //        strTabId, strFldId, strPrjId, clsStackTrace.GetCurrClassFunction());
                        //    clsSysParaEN.objLog.WriteDebugLog(strMsg);
                        //}
                        return obj;
                    }
                    return null;
                }
            }
            else
            {
                arrDataNodeObjLst_Sel =
                 arrDataNodeObjLstCache
                 .Where(x => x.TabId == strTabId && x.FldId == strFldId && x.VersionNo == intVersionNo);
                if (arrDataNodeObjLst_Sel.Count() == 0)
                {
                    var strCond = new clsDataNodeEN()
                        .SetTabId(strTabId, "=")
                        .SetFldId(strFldId, "=")                        
                        .GetCombineCondition();
                    clsDataNodeEN obj = clsDataNodeBL.GetFirstObj_S(strCond);
                    if (obj != null)
                    {
                        //if (obj.C1mPrjId == strC1mPrjId)
                        //{
                            clsDataNodeBL.ReFreshCache(obj.PrjId);
                        //}
                        //else
                        //{
                        //    string strMsg = string.Format("错误: 表:{0}、字段:{1}不属于Cm工程Id:{2},请检查！(In {3})",
                        //        strTabId, strFldId, strC1mPrjId, clsStackTrace.GetCurrClassFunction());
                        //    clsSysParaEN.objLog.WriteDebugLog(strMsg);
                        //}
                        return obj;
                    }
                    return null;
                }
            }
            return arrDataNodeObjLst_Sel.First();
        }



        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="strDataNodeId">表关键字</param>
        /// <returns></returns>
        public static bool DelRecordEx1(long strDataNodeId, string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsDataNodeDA.GetSpecSQLObj();
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
                //删除与表:[DataNode]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}' ",
                conDnFuncMap.InDataNodeId,
                strDataNodeId );
                clsDnFuncMapBL.DelDnFuncMapsByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);

                string strCondition2 = string.Format("{0} = '{1}' ",
                conDnFuncMap.OutDataNodeId,
                strDataNodeId);
                clsDnFuncMapBL.DelDnFuncMapsByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);


                clsDataNodeBL.DelRecord(strDataNodeId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsDataNodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strDataNodeId, clsStackTrace.GetCurrClassFunction());
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

        public static List<clsDataNodeEN> GetAllConnectedSubGroup(string strPrjId)
        {
            Graph g = clsDataNodeBLEx.InitGraph(strPrjId);
            var arrDataNode = GetDataNodeLst4Graph(strPrjId);

            List<long> arrDataNodeId = null;
            try
            {
                var arrConnectedNode = g.GetAllConnectedSubGroup();
                arrDataNodeId = arrConnectedNode.Select(x => long.Parse(x.KeyId)).ToList();
                List<clsDataNodeEN> arrDataNode_Result = arrConnectedNode.Select(x => GetDataNodeByVertex(x, strPrjId)).ToList();
                arrDataNode_Result.ForEach(x =>
                {
                    var objDataNode = arrDataNode.Find(y => y.DataNodeId == x.DataNodeId);
                    if (objDataNode != null)
                    {
                        objDataNode.SubGraphName = x.SubGraphName;
                        objDataNode.Update();
                    }
                });
                clsDataNodeBL.ReFreshCache(strPrjId);
                return arrDataNode_Result;
            }
            catch (Exception objException)
            {
                throw objException;
            }
            //List<clsDataNodeEN> arrDataNode_Result = arrDataNodeId.Select(x => clsDataNodeBL.GetObjByDataNodeIdCache(x, strPrjId)).ToList();
            //return arrDataNode_Result;
        }

        public static void BindDdl_SubGraphName(DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            IEnumerable<clsDataNodeEN> arrDataNode = GetDataNodeLst4Graph(strPrjId);
            var arrSubGraphName_GroupBy = arrDataNode.GroupBy(x => x.SubGraphName).Select(g => (new { SubGraphName = g.Key, Count = g.Count() })).ToList();

            //var listCu = list.GroupBy(a => a.Year).Select(g => (new { year = g.Key, avg = g.Average(m => m.Cu), max = g.Max(n => n.Cu), count = g.Count() }));

            //List<string> arrSubGraphName = arrSubGraphName_GroupBy.Select(x => string.Format("{0}({1})", x.SubGraphName, x.Count)).ToList();
            //List<string> arrSubGraphName_Split = new List<string>();

            //arrSubGraphName.ForEach(x =>
            //{
            //    string[] sstrSubGraphName = x.Split(",".ToCharArray());
            //    foreach (string strInFor in sstrSubGraphName)
            //    {
            //        if (string.IsNullOrEmpty(strInFor) == true) continue;
            //        if (arrSubGraphName_Split.Contains(strInFor) == false) arrSubGraphName_Split.Add(strInFor);
            //    }
            //});


            IEnumerable<clsCboObject> arrCboObject = arrSubGraphName_GroupBy
                    .OrderBy(x => x.SubGraphName)
                    .Select(x => new clsCboObject(x.SubGraphName, string.Format("{0}({1})", x.SubGraphName, x.Count)));
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;

        }
        public static void BindDdl_DataNodeIdByPrjId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点]...", "0");
            string strCondition = string.Format("1 =1 Order By {0}", conDataNode.DataNodeId);
            IEnumerable<clsDataNodeEN> arrObjLst = clsDataNodeBL.GetObjLstCache(strPrjId).OrderBy(x => x.DataNodeName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conDataNode.DataNodeId;
            objDDL.DataTextField = conDataNode.DataNodeName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 功能:同时删除多条记录,删除给定关键字列表的记录        
        /// </summary>
        /// <param name = "arrDataNodeIdLst">给定的关键字值列表</param>
        /// <returns>返回删除的记录数</returns>
        public static int DelDataNodesEx(List<long> arrDataNodeIdLst)
        {
            if (arrDataNodeIdLst.Count == 0) return 0;
            try
            {
                clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId(arrDataNodeIdLst[0]);
                int intDelRecNum = 0;
                IEnumerable<clsDnFuncMapEN> arrDnFuncMapObjLst_All = null;// new IEnumerable<clsDnFuncMapEN>();
                foreach (long strDataNodeId in arrDataNodeIdLst)
                {
                    var arrDnFuncMap_In = clsDnFuncMapBLEx.GetObjLstByInDataNodeIdCacheEx(strDataNodeId, objDataNodeEN.PrjId);
                    var arrDnFuncMap_Out = clsDnFuncMapBLEx.GetObjLstByOutDataNodeIdCacheEx(strDataNodeId, objDataNodeEN.PrjId);
                    if (arrDnFuncMapObjLst_All == null)
                    {
                        arrDnFuncMapObjLst_All = arrDnFuncMap_In
                            .Union(arrDnFuncMap_Out);
                    }
                    else
                    {
                        arrDnFuncMapObjLst_All = arrDnFuncMapObjLst_All
                            .Union(arrDnFuncMap_In)
                            .Union(arrDnFuncMap_Out);
                    }
                }
                arrDnFuncMapObjLst_All = arrDnFuncMapObjLst_All.Distinct(new DnFuncMapComparer());
                foreach (var objDnFuncMap in arrDnFuncMapObjLst_All)
                {
                    clsDnFuncMapBLEx.DelRecordEx(objDnFuncMap.DnFuncMapId, objDataNodeEN.PrjId);
                    intDelRecNum++;
                }
                var arrDataNodeIdLst1 = arrDataNodeIdLst.Select(x=>x.ToString()).ToList();
                clsDataNodeBL.DelDataNodes(arrDataNodeIdLst1);


                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                ReFreshCache(objDataNodeEN.PrjId);
                return arrDataNodeIdLst.Count;
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
        /// <param name="strDataNodeId">表关键字</param>
        /// <param name="strPrjId">strPrjId</param>
        /// <returns></returns>
        public new static bool DelRecordEx(long strDataNodeId, string strPrjId)
        {
            clsSpecSQLforSql objSQL;
            //获取连接对象
            objSQL = clsDataNodeDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId(strDataNodeId);
                int intDelRecNum = 0;
                List<string> arrDnFuncMapIdLst_All = null;// new IEnumerable<clsDnFuncMapEN>();

                List<string> arrDnFuncMapId_In = clsDnFuncMapBLEx.GetDnFuncMapIdLstByInDataNodeIdEx(strDataNodeId);
                List<string> arrDnFuncMapId_Out = clsDnFuncMapBLEx.GetDnFuncMapIdLstByOutDataNodeIdEx(strDataNodeId);
                clsAggregate.UniteTwoAggr(ref arrDnFuncMapId_In, arrDnFuncMapId_Out);
                arrDnFuncMapIdLst_All = arrDnFuncMapId_In;
             //获取连接对象
             objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[DataNode]相关的表的代码，需要时去除注释，编写相关的代码
                foreach (var strDnFuncMapId in arrDnFuncMapIdLst_All)
                {
                    clsDnFuncMapBLEx.DelRecordEx(strDnFuncMapId, objDataNodeEN.PrjId, objConnection, objSqlTransaction);
                    clsDnPathFuncMapRelaBLEx.DelRecordByDnFuncMapId(strDnFuncMapId, objConnection, objSqlTransaction);
                    intDelRecNum++;
                }
                clsDataNodeBL.DelRecord(strDataNodeId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsDataNodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
                objException.Message,
                strDataNodeId, clsStackTrace.GetCurrClassFunction());
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
        /// 检查结点，如果有结点的相关表为空，或者相关表的缓存模式不正确就抛错.
        /// </summary>        
        /// <param name = "strPrjId">strPrjId</param>
        /// <param name = "strOpUser">操作用户</param>            
        /// <returns>返回检查出错误的结点数</returns>
        public static int CheckDataNodeByPrjId(string strPrjId, string strOpUser)
        {
            List<clsDataNodeEN> arrObjLstCache = clsDataNodeBL.GetObjLstCache(strPrjId);
            int intCount = 0;
            foreach(var objInFor in arrObjLstCache)
            {
                bool bolResult = CheckDataNode(objInFor, strOpUser);
                if (bolResult) intCount++;    
            }
            return intCount;
        }
        /// <summary>
        /// 检查结点，如果有结点的相关表为空，或者相关表的缓存模式不正确就抛错.
        /// </summary>        
        /// <param name = "strDataNodeId">数据结点Id</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <param name = "strOpUser">操作用户</param>            
        /// <returns>如果检查错误就返回false,正确就返回true</returns>
        public static bool CheckDataNode(long strDataNodeId, string strPrjId, string strOpUser)
        {
            clsDataNodeEN objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(strDataNodeId, strPrjId);
            return CheckDataNode(objDataNode, strOpUser);
        }
        /// <summary>
        /// 检查结点，如果有结点的相关表为空，或者相关表的缓存模式不正确就抛错.
        /// </summary>        
        /// <param name = "objDataNode">数据结点</param>
        /// <param name = "strOpUser">操作用户</param>            
        /// <returns>如果检查错误就返回false,正确就返回true</returns>
        public static bool CheckDataNode(clsDataNodeEN objDataNode, string strOpUser)
        {
            
            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objDataNode.TabId, objDataNode.PrjId);
            if (objPrjTab == null)
            {
                var objProject = clsProjectsBL.GetObjByPrjIdCache(objDataNode.PrjId);
                string strMsg = string.Format("在结点:{0}({1})中，相关表:[{2}]不存在。 PrjId={3}({4})，请检查！(In {5})",
                    objDataNode.DataNodeName, objDataNode.DataNodeId, objDataNode.TabId,
                    objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                //objDataNode.IsHasErr = true;
                objDataNode.ErrMsg = strMsg;
                objDataNode.UpdUser = strOpUser;
                objDataNode.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objDataNode.Update();
                return false;
                //throw new Exception(strMsg);
            }
           
            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDataNode.FldId, objDataNode.PrjId);
            if (objFieldTab == null)
            {
                var objProject = clsProjectsBL.GetObjByPrjIdCache(objDataNode.PrjId);
                string strMsg = string.Format("在结点:{0}({1})中，相关字段:[{2}]不存在。 PrjId={3}({4})，请检查！(In {5})",
                    objDataNode.DataNodeName, objDataNode.DataNodeId, objDataNode.FldId,
                    objProject.PrjName, objProject.PrjId, clsStackTrace.GetCurrClassFunction());
                //objDataNode.IsHasErr = true;
                objDataNode.ErrMsg = strMsg;
                objDataNode.UpdUser = strOpUser;
                objDataNode.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objDataNode.Update();
                return false;
                //throw new Exception(strMsg);
            }
            if (objDataNode.ErrMsg != null && objDataNode.ErrMsg.Length>0)
            {
                objDataNode.ErrMsg = "";
                objDataNode.UpdUser = strOpUser;
                objDataNode.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objDataNode.Update();
            }
            return true;

        }
        public static string GetStandardDataNodeName(long lngDataNodeId)
        {
            try
            {
                clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId(lngDataNodeId);
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objDataNodeEN.TabId, objDataNodeEN.PrjId);
                if (objPrjTab == null) return "";
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objDataNodeEN.FldId, objDataNodeEN.PrjId);
                if (objFieldTab == null) return "";
                return $"{objPrjTab.TabName}-{objFieldTab.FldName}";
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据datanodeId获取标准结点名出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static int SetAllStandardDataNodeName(string strPrjId)
        {
            try
            {
                var arrDataNode = clsDataNodeBL.GetObjLstCache(strPrjId);
                int intCount = 0;
                foreach(var objNode in arrDataNode )
                {
                    if (objNode == null) continue;
                    string strStandardDataNodeName = objNode.StandardDataNodeName();
                    objNode.DataNodeName = strStandardDataNodeName;
                    objNode.Update();
                    intCount++;
                }
                return intCount;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)设置某工程下所有结点标准名称出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}