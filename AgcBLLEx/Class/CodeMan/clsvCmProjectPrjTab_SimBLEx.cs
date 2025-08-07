
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvCmProjectPrjTab_SimBLEx
表名:vCmProjectPrjTab_Sim(00050639)
* 版本:2025.06.13.1(服务器:WIN-SRV103-116)
日期:2025/06/18 00:05:49
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,8433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理(CodeMan)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx,0021)
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
    public class RelatedActions_vCmProjectPrjTab_SimEx : RelatedActions_vCmProjectPrjTab_Sim
    {
        public override bool UpdRelaTabDate(string strCmPrjId, string strTabId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsvCmProjectPrjTab_SimBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvCmProjectPrjTab_SimENS">源对象</param>
        /// <returns>目标对象=>clsvCmProjectPrjTab_SimEN:objvCmProjectPrjTab_SimENT</returns>
        public static clsvCmProjectPrjTab_SimENEx CopyToEx(this clsvCmProjectPrjTab_SimEN objvCmProjectPrjTab_SimENS)
        {
            try
            {
                clsvCmProjectPrjTab_SimENEx objvCmProjectPrjTab_SimENT = new clsvCmProjectPrjTab_SimENEx();
                clsvCmProjectPrjTab_SimBL.vCmProjectPrjTab_SimDA.CopyTo(objvCmProjectPrjTab_SimENS, objvCmProjectPrjTab_SimENT);
                return objvCmProjectPrjTab_SimENT;
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
        /// <param name = "objvCmProjectPrjTab_SimENS">源对象</param>
        /// <returns>目标对象=>clsvCmProjectPrjTab_SimEN:objvCmProjectPrjTab_SimENT</returns>
        public static clsvCmProjectPrjTab_SimEN CopyTo(this clsvCmProjectPrjTab_SimENEx objvCmProjectPrjTab_SimENS)
        {
            try
            {
                clsvCmProjectPrjTab_SimEN objvCmProjectPrjTab_SimENT = new clsvCmProjectPrjTab_SimEN();
                clsvCmProjectPrjTab_SimBL.CopyTo(objvCmProjectPrjTab_SimENS, objvCmProjectPrjTab_SimENT);
                return objvCmProjectPrjTab_SimENT;
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
    /// vCmProjectPrjTab_Sim(vCmProjectPrjTab_Sim)
    /// 数据源类型:视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvCmProjectPrjTab_SimBLEx : clsvCmProjectPrjTab_SimBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvCmProjectPrjTab_SimDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvCmProjectPrjTab_SimDAEx vCmProjectPrjTab_SimDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvCmProjectPrjTab_SimDAEx();
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
        public static List<clsvCmProjectPrjTab_SimENEx> GetObjExLst(string strCondition)
        {
            List<clsvCmProjectPrjTab_SimEN> arrObjLst = clsvCmProjectPrjTab_SimBL.GetObjLst(strCondition);
            List<clsvCmProjectPrjTab_SimENEx> arrObjExLst = new List<clsvCmProjectPrjTab_SimENEx>();
            foreach (clsvCmProjectPrjTab_SimEN objInFor in arrObjLst)
            {
                clsvCmProjectPrjTab_SimENEx objvCmProjectPrjTab_SimENEx = new clsvCmProjectPrjTab_SimENEx();
                clsvCmProjectPrjTab_SimBL.CopyTo(objInFor, objvCmProjectPrjTab_SimENEx);
                arrObjExLst.Add(objvCmProjectPrjTab_SimENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCmPrjId">表关键字</param>
        /// <param name = "strTabId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvCmProjectPrjTab_SimENEx GetObjExByKeyLst(string strCmPrjId, string strTabId)
        {
            clsvCmProjectPrjTab_SimEN objvCmProjectPrjTab_SimEN = clsvCmProjectPrjTab_SimBL.GetObjByKeyLst(strCmPrjId, strTabId);
            clsvCmProjectPrjTab_SimENEx objvCmProjectPrjTab_SimENEx = new clsvCmProjectPrjTab_SimENEx();
            clsvCmProjectPrjTab_SimBL.CopyTo(objvCmProjectPrjTab_SimEN, objvCmProjectPrjTab_SimENEx);
            return objvCmProjectPrjTab_SimENEx;
        }
    }
}