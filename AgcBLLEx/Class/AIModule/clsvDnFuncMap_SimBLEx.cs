
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvDnFuncMap_SimBLEx
表名:vDnFuncMap_Sim(00050625)
* 版本:2023.07.16.1(服务器:PYF-THINKPAD)
日期:2023/07/18 17:14:07
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:AI模块(AIModule)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

using com.taishsoft.comm_db_obj;
using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_vDnFuncMap_SimEx : RelatedActions_vDnFuncMap_Sim
    {
        public override bool UpdRelaTabDate(string strDnFuncMapId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsvDnFuncMap_SimBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvDnFuncMap_SimENS">源对象</param>
        /// <returns>目标对象=>clsvDnFuncMap_SimEN:objvDnFuncMap_SimENT</returns>
        public static clsvDnFuncMap_SimENEx CopyToEx(this clsvDnFuncMap_SimEN objvDnFuncMap_SimENS)
        {
            try
            {
                clsvDnFuncMap_SimENEx objvDnFuncMap_SimENT = new clsvDnFuncMap_SimENEx();
                clsvDnFuncMap_SimBL.vDnFuncMap_SimDA.CopyTo(objvDnFuncMap_SimENS, objvDnFuncMap_SimENT);
                return objvDnFuncMap_SimENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objvDnFuncMap_SimENS">源对象</param>
        /// <returns>目标对象=>clsvDnFuncMap_SimEN:objvDnFuncMap_SimENT</returns>
        public static clsvDnFuncMap_SimEN CopyTo(this clsvDnFuncMap_SimENEx objvDnFuncMap_SimENS)
        {
            try
            {
                clsvDnFuncMap_SimEN objvDnFuncMap_SimENT = new clsvDnFuncMap_SimEN();
                clsvDnFuncMap_SimBL.CopyTo(objvDnFuncMap_SimENS, objvDnFuncMap_SimENT);
                return objvDnFuncMap_SimENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// v结点函数映射_Sim(vDnFuncMap_Sim)
    /// 数据源类型:视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvDnFuncMap_SimBLEx : clsvDnFuncMap_SimBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvDnFuncMap_SimDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvDnFuncMap_SimDAEx vDnFuncMap_SimDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvDnFuncMap_SimDAEx();
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
        public static List<clsvDnFuncMap_SimENEx> GetObjExLst(string strCondition)
        {
            List<clsvDnFuncMap_SimEN> arrObjLst = clsvDnFuncMap_SimBL.GetObjLst(strCondition);
            List<clsvDnFuncMap_SimENEx> arrObjExLst = new List<clsvDnFuncMap_SimENEx>();
            foreach (clsvDnFuncMap_SimEN objInFor in arrObjLst)
            {
                clsvDnFuncMap_SimENEx objvDnFuncMap_SimENEx = new clsvDnFuncMap_SimENEx();
                clsvDnFuncMap_SimBL.CopyTo(objInFor, objvDnFuncMap_SimENEx);
                arrObjExLst.Add(objvDnFuncMap_SimENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strDnFuncMapId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvDnFuncMap_SimENEx GetObjExByDnFuncMapId(string strDnFuncMapId)
        {
            clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = clsvDnFuncMap_SimBL.GetObjByDnFuncMapId(strDnFuncMapId);
            clsvDnFuncMap_SimENEx objvDnFuncMap_SimENEx = new clsvDnFuncMap_SimENEx();
            clsvDnFuncMap_SimBL.CopyTo(objvDnFuncMap_SimEN, objvDnFuncMap_SimENEx);
            return objvDnFuncMap_SimENEx;
        }
        public static clsvDnFuncMap_SimEN GetObjByDnFuncMapIdEx(string strDnFuncMapId, string strPrjId)
        {
            clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = clsvDnFuncMap_SimBL.GetObjByDnFuncMapId(strDnFuncMapId);
            if (objvDnFuncMap_SimEN == null)
            {
                throw new Exception($"DnFuncMapId:{strDnFuncMapId} 在DnFuncMap表中不存在！");
            }
            if (objvDnFuncMap_SimEN.PrjId != strPrjId)
            {
                throw new Exception($"DnFuncMapId:{strDnFuncMapId} 在DnFuncMap表中不属于工程Id:{strPrjId},请检查！");
            }
            clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapId(strDnFuncMapId);
            objDnFuncMapEN.UsedTimes = objDnFuncMapEN.UsedTimes ?? 0 + 1;
            if (objDnFuncMapEN.UsedTimes == 0) objDnFuncMapEN.UsedTimes = 1;
            objDnFuncMapEN.Update();
            return objvDnFuncMap_SimEN;
        }

        public static List< clsvDnFuncMap_SimEN> GetObjLstByOutDataNodeIdEx(long strOutDataNodeId)
        {

            List<clsvDnFuncMap_SimEN> arrvDnFuncMap_Sim = clsvDnFuncMap_SimBL.GetObjLst($"{convDnFuncMap_Sim.OutDataNodeId} = '{strOutDataNodeId}'");
            foreach (var objInfor in arrvDnFuncMap_Sim)
            {
                clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapId(objInfor.DnFuncMapId);
                objDnFuncMapEN.UsedTimes = objDnFuncMapEN.UsedTimes ?? 0 + 1;
                if (objDnFuncMapEN.UsedTimes == 0) objDnFuncMapEN.UsedTimes = 1;
                objDnFuncMapEN.Update();
            }
            return arrvDnFuncMap_Sim;
        }

        public static List<clsvDnFuncMap_SimEN> GetObjLstByInDataNodeIdEx(long strInDataNodeId)
        {

            List<clsvDnFuncMap_SimEN> arrvDnFuncMap_Sim = clsvDnFuncMap_SimBL.GetObjLst($"{convDnFuncMap_Sim.InDataNodeId} = '{strInDataNodeId}'");
            foreach (var objInfor in arrvDnFuncMap_Sim)
            {
                clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapId(objInfor.DnFuncMapId);
                objDnFuncMapEN.UsedTimes = objDnFuncMapEN.UsedTimes ?? 0 + 1;
                if (objDnFuncMapEN.UsedTimes == 0) objDnFuncMapEN.UsedTimes = 1;
                objDnFuncMapEN.Update();
            }
            return arrvDnFuncMap_Sim;
        }

        public static clsvDnFuncMap_SimEN GetObjByInOutDataNodeIdEx(long strInDataNodeId, long strOutDataNodeId)
        {

            List<clsvDnFuncMap_SimEN> arrvDnFuncMap_Sim
                = clsvDnFuncMap_SimBL.GetObjLst($"{convDnFuncMap_Sim.InDataNodeId} = '{strInDataNodeId}' and {convDnFuncMap_Sim.OutDataNodeId} = '{strOutDataNodeId}'");
            if (arrvDnFuncMap_Sim.Count > 1)
            {
                throw new Exception($"{convDnFuncMap_Sim.InDataNodeId} = '{strInDataNodeId}' and {convDnFuncMap_Sim.OutDataNodeId} = '{strOutDataNodeId}' 在DnFuncMap表中有多条记录，不合理！");
            }
            if (arrvDnFuncMap_Sim.Count == 0) return null;
            clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapId(arrvDnFuncMap_Sim[0].DnFuncMapId);
            objDnFuncMapEN.UsedTimes = objDnFuncMapEN.UsedTimes ?? 0 + 1;
            if (objDnFuncMapEN.UsedTimes == 0) objDnFuncMapEN.UsedTimes = 1;
            objDnFuncMapEN.Update();

            return arrvDnFuncMap_Sim[0];
        }
    }
}