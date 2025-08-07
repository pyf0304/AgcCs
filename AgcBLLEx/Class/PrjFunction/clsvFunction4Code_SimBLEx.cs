
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFunction4Code_SimBLEx
表名:vFunction4Code_Sim(00050602)
生成代码版本:2022.01.17.1
生成日期:2022/01/20 01:23:36
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
    public static class clsvFunction4Code_SimBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvFunction4Code_SimENS">源对象</param>
        /// <returns>目标对象=>clsvFunction4Code_SimEN:objvFunction4Code_SimENT</returns>
        public static clsvFunction4Code_SimENEx CopyToEx(this clsvFunction4Code_SimEN objvFunction4Code_SimENS)
        {
            try
            {
                clsvFunction4Code_SimENEx objvFunction4Code_SimENT = new clsvFunction4Code_SimENEx();
                clsvFunction4Code_SimBL.vFunction4Code_SimDA.CopyTo(objvFunction4Code_SimENS, objvFunction4Code_SimENT);
                return objvFunction4Code_SimENT;
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
        /// <param name = "objvFunction4Code_SimENS">源对象</param>
        /// <returns>目标对象=>clsvFunction4Code_SimEN:objvFunction4Code_SimENT</returns>
        public static clsvFunction4Code_SimEN CopyTo(this clsvFunction4Code_SimENEx objvFunction4Code_SimENS)
        {
            try
            {
                clsvFunction4Code_SimEN objvFunction4Code_SimENT = new clsvFunction4Code_SimEN();
                clsvFunction4Code_SimBL.CopyTo(objvFunction4Code_SimENS, objvFunction4Code_SimENT);
                return objvFunction4Code_SimENT;
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
    /// v函数4Code_Sim(vFunction4Code_Sim)
    /// 数据源类型:视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvFunction4Code_SimBLEx : clsvFunction4Code_SimBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFunction4Code_SimDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFunction4Code_SimDAEx vFunction4Code_SimDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFunction4Code_SimDAEx();
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
        public static List<clsvFunction4Code_SimENEx> GetObjExLst(string strCondition)
        {
            List<clsvFunction4Code_SimEN> arrObjLst = clsvFunction4Code_SimBL.GetObjLst(strCondition);
            List<clsvFunction4Code_SimENEx> arrObjExLst = new List<clsvFunction4Code_SimENEx>();
            foreach (clsvFunction4Code_SimEN objInFor in arrObjLst)
            {
                clsvFunction4Code_SimENEx objvFunction4Code_SimENEx = new clsvFunction4Code_SimENEx();
                clsvFunction4Code_SimBL.CopyTo(objInFor, objvFunction4Code_SimENEx);
                arrObjExLst.Add(objvFunction4Code_SimENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFuncId4Code">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvFunction4Code_SimENEx GetObjExByFuncId4Code(string strFuncId4Code)
        {
            clsvFunction4Code_SimEN objvFunction4Code_SimEN = clsvFunction4Code_SimBL.GetObjByFuncId4Code(strFuncId4Code);
            clsvFunction4Code_SimENEx objvFunction4Code_SimENEx = new clsvFunction4Code_SimENEx();
            clsvFunction4Code_SimBL.CopyTo(objvFunction4Code_SimEN, objvFunction4Code_SimENEx);
            return objvFunction4Code_SimENEx;
        }

        public static clsvFunction4Code_SimEN GetObjByFuncId4CodeEx(string strFuncId4Code)
        {
            clsvFunction4Code_SimEN objvFunction4Code_SimEN = clsvFunction4Code_SimBL.GetObjByFuncId4Code(strFuncId4Code);
            if (objvFunction4Code_SimEN == null)
            {
                throw new Exception($"FuncId4Code:{strFuncId4Code} 在Function4Code表中不存在！");
            }
           
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
            objFunction4CodeEN.UsedTimes = objFunction4CodeEN.UsedTimes ?? 0 + 1;
            if (objFunction4CodeEN.UsedTimes == 0) objFunction4CodeEN.UsedTimes = 1;
            objFunction4CodeEN.Update();
            return objvFunction4Code_SimEN;
        }
    }
}