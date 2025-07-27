
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFunction4GeneCode_SimBLEx
表名:vFunction4GeneCode_Sim(00050605)
生成代码版本:2022.01.25.1
生成日期:2022/01/25 05:42:26
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:函数管理(PrjFunction)
框架-层名:业务逻辑扩展层(BusinessLogicEx)
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
    public static class clsvFunction4GeneCode_SimBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvFunction4GeneCode_SimENS">源对象</param>
        /// <returns>目标对象=>clsvFunction4GeneCode_SimEN:objvFunction4GeneCode_SimENT</returns>
        public static clsvFunction4GeneCode_SimENEx CopyToEx(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENS)
        {
            try
            {
                clsvFunction4GeneCode_SimENEx objvFunction4GeneCode_SimENT = new clsvFunction4GeneCode_SimENEx();
                clsvFunction4GeneCode_SimBL.vFunction4GeneCode_SimDA.CopyTo(objvFunction4GeneCode_SimENS, objvFunction4GeneCode_SimENT);
                return objvFunction4GeneCode_SimENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objvFunction4GeneCode_SimENS">源对象</param>
        /// <returns>目标对象=>clsvFunction4GeneCode_SimEN:objvFunction4GeneCode_SimENT</returns>
        public static clsvFunction4GeneCode_SimEN CopyTo(this clsvFunction4GeneCode_SimENEx objvFunction4GeneCode_SimENS)
        {
            try
            {
                clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENT = new clsvFunction4GeneCode_SimEN();
                clsvFunction4GeneCode_SimBL.CopyTo(objvFunction4GeneCode_SimENS, objvFunction4GeneCode_SimENT);
                return objvFunction4GeneCode_SimENT;
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
    /// v函数4GC_Sim(vFunction4GeneCode_Sim)
    /// 数据源类型:视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvFunction4GeneCode_SimBLEx : clsvFunction4GeneCode_SimBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFunction4GeneCode_SimDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFunction4GeneCode_SimDAEx vFunction4GeneCode_SimDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFunction4GeneCode_SimDAEx();
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
        public static List<clsvFunction4GeneCode_SimENEx> GetObjExLst(string strCondition)
        {
            List<clsvFunction4GeneCode_SimEN> arrObjLst = clsvFunction4GeneCode_SimBL.GetObjLst(strCondition);
            List<clsvFunction4GeneCode_SimENEx> arrObjExLst = new List<clsvFunction4GeneCode_SimENEx>();
            foreach (clsvFunction4GeneCode_SimEN objInFor in arrObjLst)
            {
                clsvFunction4GeneCode_SimENEx objvFunction4GeneCode_SimENEx = new clsvFunction4GeneCode_SimENEx();
                clsvFunction4GeneCode_SimBL.CopyTo(objInFor, objvFunction4GeneCode_SimENEx);
                arrObjExLst.Add(objvFunction4GeneCode_SimENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFuncId4GC">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvFunction4GeneCode_SimENEx GetObjExByFuncId4GC(string strFuncId4GC)
        {
            clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = clsvFunction4GeneCode_SimBL.GetObjByFuncId4GC(strFuncId4GC);
            clsvFunction4GeneCode_SimENEx objvFunction4GeneCode_SimENEx = new clsvFunction4GeneCode_SimENEx();
            clsvFunction4GeneCode_SimBL.CopyTo(objvFunction4GeneCode_SimEN, objvFunction4GeneCode_SimENEx);
            return objvFunction4GeneCode_SimENEx;
        }

        public static clsvFunction4GeneCode_SimEN GetObjByFuncId4GCEx(string strFuncId4GC)
        {
            clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = clsvFunction4GeneCode_SimBL.GetObjByFuncId4GC(strFuncId4GC);
            if (objvFunction4GeneCode_SimEN == null)
            {
                throw new Exception($"FuncId4GC:{strFuncId4GC} 在Function4GeneCode表中不存在！");
            }

            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
            objFunction4GeneCodeEN.UsedTimes = objFunction4GeneCodeEN.UsedTimes ?? 0 + 1;
            if (objFunction4GeneCodeEN.UsedTimes == 0) objFunction4GeneCodeEN.UsedTimes = 1;
            objFunction4GeneCodeEN.Update();
            return objvFunction4GeneCode_SimEN;
        }
    }
}