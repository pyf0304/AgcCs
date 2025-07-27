
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDnPathCmPrjIdRelaBLEx
表名:DnPathCmPrjIdRela(00050620)
* 版本:2023.03.02.1(服务器:WIN-SRV103-116)
日期:2023/03/05 04:14:53
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
using com.taishsoft.commdb;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_DnPathCmPrjIdRelaEx : RelatedActions_DnPathCmPrjIdRela
    {
        public override bool UpdRelaTabDate(string strDnPathId, string strCmPrjId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsDnPathCmPrjIdRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDnPathCmPrjIdRelaENS">源对象</param>
        /// <returns>目标对象=>clsDnPathCmPrjIdRelaEN:objDnPathCmPrjIdRelaENT</returns>
        public static clsDnPathCmPrjIdRelaENEx CopyToEx(this clsDnPathCmPrjIdRelaEN objDnPathCmPrjIdRelaENS)
        {
            try
            {
                clsDnPathCmPrjIdRelaENEx objDnPathCmPrjIdRelaENT = new clsDnPathCmPrjIdRelaENEx();
                clsDnPathCmPrjIdRelaBL.DnPathCmPrjIdRelaDA.CopyTo(objDnPathCmPrjIdRelaENS, objDnPathCmPrjIdRelaENT);
                return objDnPathCmPrjIdRelaENT;
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
        /// <param name = "objDnPathCmPrjIdRelaENS">源对象</param>
        /// <returns>目标对象=>clsDnPathCmPrjIdRelaEN:objDnPathCmPrjIdRelaENT</returns>
        public static clsDnPathCmPrjIdRelaEN CopyTo(this clsDnPathCmPrjIdRelaENEx objDnPathCmPrjIdRelaENS)
        {
            try
            {
                clsDnPathCmPrjIdRelaEN objDnPathCmPrjIdRelaENT = new clsDnPathCmPrjIdRelaEN();
                clsDnPathCmPrjIdRelaBL.CopyTo(objDnPathCmPrjIdRelaENS, objDnPathCmPrjIdRelaENT);
                return objDnPathCmPrjIdRelaENT;
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
    /// 数据结点路径CmPrjId关系(DnPathCmPrjIdRela)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsDnPathCmPrjIdRelaBLEx : clsDnPathCmPrjIdRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsDnPathCmPrjIdRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsDnPathCmPrjIdRelaDAEx DnPathCmPrjIdRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsDnPathCmPrjIdRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objDnPathCmPrjIdRelaENS">源对象</param>
        /// <returns>目标对象=>clsDnPathCmPrjIdRelaEN:objDnPathCmPrjIdRelaENT</returns>
        public static clsDnPathCmPrjIdRelaENEx CopyToEx(clsDnPathCmPrjIdRelaEN objDnPathCmPrjIdRelaENS)
        {
            try
            {
                clsDnPathCmPrjIdRelaENEx objDnPathCmPrjIdRelaENT = new clsDnPathCmPrjIdRelaENEx();
                clsDnPathCmPrjIdRelaBL.DnPathCmPrjIdRelaDA.CopyTo(objDnPathCmPrjIdRelaENS, objDnPathCmPrjIdRelaENT);
                return objDnPathCmPrjIdRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
        public static List<clsDnPathCmPrjIdRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsDnPathCmPrjIdRelaEN> arrObjLst = clsDnPathCmPrjIdRelaBL.GetObjLst(strCondition);
            List<clsDnPathCmPrjIdRelaENEx> arrObjExLst = new List<clsDnPathCmPrjIdRelaENEx>();
            foreach (clsDnPathCmPrjIdRelaEN objInFor in arrObjLst)
            {
                clsDnPathCmPrjIdRelaENEx objDnPathCmPrjIdRelaENEx = new clsDnPathCmPrjIdRelaENEx();
                clsDnPathCmPrjIdRelaBL.CopyTo(objInFor, objDnPathCmPrjIdRelaENEx);
                arrObjExLst.Add(objDnPathCmPrjIdRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strDnPathId">表关键字</param>
        /// <param name = "strCmPrjId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsDnPathCmPrjIdRelaENEx GetObjExByKeyLst(string strDnPathId, string strCmPrjId)
        {
            clsDnPathCmPrjIdRelaEN objDnPathCmPrjIdRelaEN = clsDnPathCmPrjIdRelaBL.GetObjByKeyLst(strDnPathId, strCmPrjId);
            clsDnPathCmPrjIdRelaENEx objDnPathCmPrjIdRelaENEx = new clsDnPathCmPrjIdRelaENEx();
            clsDnPathCmPrjIdRelaBL.CopyTo(objDnPathCmPrjIdRelaEN, objDnPathCmPrjIdRelaENEx);
            return objDnPathCmPrjIdRelaENEx;
        }

        public static bool DelRecordByCond(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
        {
            try
            {
                string strSQL = "";
                clsSpecSQLforSql objSQL;
                //获取连接对象
                objSQL = clsDnPathCmPrjIdRelaDA.GetSpecSQLObj();
                //删除DnPathCmPrjIdRela本表中与当前对象有关的记录
                strSQL = strSQL + "Delete from DnPathCmPrjIdRela where " + strCondition + "";
                bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);

                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                ReFreshCache();
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