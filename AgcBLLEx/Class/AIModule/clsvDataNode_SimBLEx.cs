
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvDataNode_SimBLEx
表名:vDataNode_Sim(00050592)
生成代码版本:2021.07.15.1
生成日期:2021/07/17 01:53:03
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
    public static class clsvDataNode_SimBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvDataNode_SimENS">源对象</param>
        /// <returns>目标对象=>clsvDataNode_SimEN:objvDataNode_SimENT</returns>
        public static clsvDataNode_SimENEx CopyToEx(this clsvDataNode_SimEN objvDataNode_SimENS)
        {
            try
            {
                clsvDataNode_SimENEx objvDataNode_SimENT = new clsvDataNode_SimENEx();
                clsvDataNode_SimBL.vDataNode_SimDA.CopyTo(objvDataNode_SimENS, objvDataNode_SimENT);
                return objvDataNode_SimENT;
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
        /// <param name = "objvDataNode_SimENS">源对象</param>
        /// <returns>目标对象=>clsvDataNode_SimEN:objvDataNode_SimENT</returns>
        public static clsvDataNode_SimEN CopyTo(this clsvDataNode_SimENEx objvDataNode_SimENS)
        {
            try
            {
                clsvDataNode_SimEN objvDataNode_SimENT = new clsvDataNode_SimEN();
                clsvDataNode_SimBL.CopyTo(objvDataNode_SimENS, objvDataNode_SimENT);
                return objvDataNode_SimENT;
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
    /// vDataNode_Sim(vDataNode_Sim)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvDataNode_SimBLEx : clsvDataNode_SimBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvDataNode_SimDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvDataNode_SimDAEx vDataNode_SimDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvDataNode_SimDAEx();
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
        public static List<clsvDataNode_SimENEx> GetObjExLst(string strCondition)
        {
            List<clsvDataNode_SimEN> arrObjLst = clsvDataNode_SimBL.GetObjLst(strCondition);
            List<clsvDataNode_SimENEx> arrObjExLst = new List<clsvDataNode_SimENEx>();
            foreach (clsvDataNode_SimEN objInFor in arrObjLst)
            {
                clsvDataNode_SimENEx objvDataNode_SimENEx = new clsvDataNode_SimENEx();
                clsvDataNode_SimBL.CopyTo(objInFor, objvDataNode_SimENEx);
                arrObjExLst.Add(objvDataNode_SimENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strDataNodeId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvDataNode_SimENEx GetObjExByDataNodeId(long strDataNodeId)
        {
            clsvDataNode_SimEN objvDataNode_SimEN = clsvDataNode_SimBL.GetObjByDataNodeId(strDataNodeId);
            clsvDataNode_SimENEx objvDataNode_SimENEx = new clsvDataNode_SimENEx();
            clsvDataNode_SimBL.CopyTo(objvDataNode_SimEN, objvDataNode_SimENEx);
            return objvDataNode_SimENEx;
        }
        public static clsvDataNode_SimEN GetObjByDataNodeIdEx(long strDataNodeId, string strPrjId)
        {
            clsvDataNode_SimEN objvDataNode_SimEN = clsvDataNode_SimBL.GetObjByDataNodeId(strDataNodeId);
            if (objvDataNode_SimEN == null)
            {
                throw new Exception($"DataNodeId:{strDataNodeId} 在DataNode表中不存在！");
            }
            if (objvDataNode_SimEN.PrjId != strPrjId)
            {
                throw new Exception($"DataNodeId:{strDataNodeId} 在DataNode表中不属于工程Id:{strPrjId},请检查！");
            }
            clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId(strDataNodeId);
            objDataNodeEN.UsedTimes = objDataNodeEN.UsedTimes ?? 0 + 1;
            if (objDataNodeEN.UsedTimes == 0) objDataNodeEN.UsedTimes = 1;
            objDataNodeEN.UpdUser = $"pyf-test-{objDataNodeEN.UsedTimes}";
            objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);

            objDataNodeEN.Update();
            return objvDataNode_SimEN;
        }

        public static List<clsvDataNode_SimEN> GetObjLstByTabIdEx(string strTabId )
        {
            List<clsvDataNode_SimEN> arrvDataNode_SimEN = clsvDataNode_SimBL.GetObjLst($"{convDataNode_Sim.TabId}='{strTabId}'");
            List<clsDataNodeEN> arrDataNode = clsDataNodeBL.GetObjLst($"{conDataNode.TabId}='{strTabId}'");

            foreach (var objDataNodeEN in arrDataNode)
            {             
                objDataNodeEN.UsedTimes = objDataNodeEN.UsedTimes ?? 0 + 1;
                if (objDataNodeEN.UsedTimes == 0) objDataNodeEN.UsedTimes = 1;
                objDataNodeEN.Update();
            }
            return arrvDataNode_SimEN;
        }
    }
}