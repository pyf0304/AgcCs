
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDnPathFuncMapRelaBLEx
表名:DnPathFuncMapRela(00050601)
生成代码版本:2022.01.15.1
生成日期:2022/01/15 20:50:47
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:AI模块(AIModule)
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
using com.taishsoft.datetime;
using com.taishsoft.commdb;

namespace AGC.BusinessLogicEx
{
    public static class clsDnPathFuncMapRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDnPathFuncMapRelaENS">源对象</param>
        /// <returns>目标对象=>clsDnPathFuncMapRelaEN:objDnPathFuncMapRelaENT</returns>
        public static clsDnPathFuncMapRelaENEx CopyToEx(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaENS)
        {
            try
            {
                clsDnPathFuncMapRelaENEx objDnPathFuncMapRelaENT = new clsDnPathFuncMapRelaENEx();
                clsDnPathFuncMapRelaBL.DnPathFuncMapRelaDA.CopyTo(objDnPathFuncMapRelaENS, objDnPathFuncMapRelaENT);
                return objDnPathFuncMapRelaENT;
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
        /// <param name = "objDnPathFuncMapRelaENS">源对象</param>
        /// <returns>目标对象=>clsDnPathFuncMapRelaEN:objDnPathFuncMapRelaENT</returns>
        public static clsDnPathFuncMapRelaEN CopyTo(this clsDnPathFuncMapRelaENEx objDnPathFuncMapRelaENS)
        {
            try
            {
                clsDnPathFuncMapRelaEN objDnPathFuncMapRelaENT = new clsDnPathFuncMapRelaEN();
                clsDnPathFuncMapRelaBL.CopyTo(objDnPathFuncMapRelaENS, objDnPathFuncMapRelaENT);
                return objDnPathFuncMapRelaENT;
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
    /// Dn路径函数映射关系(DnPathFuncMapRela)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsDnPathFuncMapRelaBLEx : clsDnPathFuncMapRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsDnPathFuncMapRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsDnPathFuncMapRelaDAEx DnPathFuncMapRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsDnPathFuncMapRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objDnPathFuncMapRelaENS">源对象</param>
        /// <returns>目标对象=>clsDnPathFuncMapRelaEN:objDnPathFuncMapRelaENT</returns>
        public static clsDnPathFuncMapRelaENEx CopyToEx(clsDnPathFuncMapRelaEN objDnPathFuncMapRelaENS)
        {
            try
            {
                clsDnPathFuncMapRelaENEx objDnPathFuncMapRelaENT = new clsDnPathFuncMapRelaENEx();
                clsDnPathFuncMapRelaBL.DnPathFuncMapRelaDA.CopyTo(objDnPathFuncMapRelaENS, objDnPathFuncMapRelaENT);
                return objDnPathFuncMapRelaENT;
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
        public static List<clsDnPathFuncMapRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsDnPathFuncMapRelaEN> arrObjLst = clsDnPathFuncMapRelaBL.GetObjLst(strCondition);
            List<clsDnPathFuncMapRelaENEx> arrObjExLst = new List<clsDnPathFuncMapRelaENEx>();
            foreach (clsDnPathFuncMapRelaEN objInFor in arrObjLst)
            {
                clsDnPathFuncMapRelaENEx objDnPathFuncMapRelaENEx = new clsDnPathFuncMapRelaENEx();
                clsDnPathFuncMapRelaBL.CopyTo(objInFor, objDnPathFuncMapRelaENEx);
                arrObjExLst.Add(objDnPathFuncMapRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsDnPathFuncMapRelaENEx GetObjExBymId(long lngmId)
        {
            clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN = clsDnPathFuncMapRelaBL.GetObjBymId(lngmId);
            clsDnPathFuncMapRelaENEx objDnPathFuncMapRelaENEx = new clsDnPathFuncMapRelaENEx();
            clsDnPathFuncMapRelaBL.CopyTo(objDnPathFuncMapRelaEN, objDnPathFuncMapRelaENEx);
            return objDnPathFuncMapRelaENEx;
        }
        /// <summary>
        /// 建立Cm工程与表的关系
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>修改是否成功？</returns>
        public static bool CreateRela(string strPrjId, string strDnPathId, string strDnFuncMapId, string strOpUserId)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中

            clsDnPathFuncMapRelaEN objDnPathFuncMapRela_Cond = new clsDnPathFuncMapRelaEN();
            string strCondition = objDnPathFuncMapRela_Cond
            .SetDnPathId(strDnPathId, "=")
            .SetDnFuncMapId(strDnFuncMapId, "=")
            .GetCombineCondition();
            objDnPathFuncMapRela_Cond._IsCheckProperty = true;
            bool bolIsExist = clsDnPathFuncMapRelaBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                //objDnPathFuncMapRela_Cond.mId = clsDnPathFuncMapRelaBL.GetFirstID_S(strCondition);
                //objDnPathFuncMapRela_Cond.UpdateWithCondition(strCondition);
            }
            else
            {
                //objDnPathFuncMapRela_Cond.OrderNum = 1;
                objDnPathFuncMapRela_Cond.SetPrjId(strPrjId, "=");
                objDnPathFuncMapRela_Cond.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objDnPathFuncMapRela_Cond.UpdUser = strOpUserId;
                
                objDnPathFuncMapRela_Cond.PrjId = strPrjId;
                objDnPathFuncMapRela_Cond.AddNewRecord();
            }
            return true;
        }
        /// <summary>
        /// 功能:删除关键字所指的记录,使用事务
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
        /// </summary>
        /// <param name = "lngmId">给定的关键字值</param>
        /// <param name = "objSqlConnection">Sql连接对象</param>
        /// <param name = "objSqlTransaction">Sql事务对象</param>
        /// <returns>返回删除是否成功?</returns>
        public static bool DelRecordByCond(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
        {
            try
            {                
                string strSQL = "";
                clsSpecSQLforSql objSQL;
                //获取连接对象
                objSQL = clsDnPathFuncMapRelaDA.GetSpecSQLObj();
                //删除DnPathFuncMapRela本表中与当前对象有关的记录
                strSQL = strSQL + "Delete from DnPathFuncMapRela where " + strCondition + "";
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
        public static bool DelRecordByDnFuncMapId(string strDnFuncMapId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
        {
            try
            {
                string strSQL = "";
                clsSpecSQLforSql objSQL;
                //获取连接对象
                objSQL = clsDnPathFuncMapRelaDA.GetSpecSQLObj();
                //删除DnPathFuncMapRela本表中与当前对象有关的记录
                strSQL = strSQL + String.Format("Delete from DnPathFuncMapRela where {0}='{1}'", conDnPathFuncMapRela.DnFuncMapId, strDnFuncMapId);
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

        /// <summary>
        /// 功能:删除关键字所指的记录,使用事务
        /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
        /// </summary>
        /// <param name = "lngmId">给定的关键字值</param>
        /// <param name = "objSqlConnection">Sql连接对象</param>
        /// <param name = "objSqlTransaction">Sql事务对象</param>
        /// <returns>返回删除是否成功?。</returns>
        public new bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL;
            //获取连接对象
            objSQL = clsDnPathFuncMapRelaDA.GetSpecSQLObj();
            //删除DnPathFuncMapRela本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from DnPathFuncMapRela where mId = " + "" + lngmId + "";
            return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
        }
    }
}