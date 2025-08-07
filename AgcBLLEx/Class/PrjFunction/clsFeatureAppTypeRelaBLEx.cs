
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFeatureAppTypeRelaBLEx
表名:FeatureAppTypeRela(00050430)
生成代码版本:2019.03.09.1
生成日期:2019/03/09 17:38:31
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:函数管理
模块英文名:PrjFunction
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
    /// <summary>
    /// 功能应用关系(FeatureAppTypeRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsFeatureAppTypeRelaBLEx : clsFeatureAppTypeRelaBL
    {
        /// <summary>
        /// 设置启用
        /// </summary>
        /// <param name="lngmId"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static bool SetInUse(long lngmId, string strUserId)
        {
            clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = clsFeatureAppTypeRelaBL.GetObjBymId(lngmId);
            objFeatureAppTypeRelaEN.InUse = true;
            objFeatureAppTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFeatureAppTypeRelaEN.UpdUser = strUserId;
            return clsFeatureAppTypeRelaBL.UpdateBySql2(objFeatureAppTypeRelaEN);

        }
        /// <summary>
        /// 设置不用
        /// </summary>
        /// <param name="lngmId"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static bool SetNotInUse(long lngmId, string strUserId)
        {
            clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = clsFeatureAppTypeRelaBL.GetObjBymId(lngmId);
            objFeatureAppTypeRelaEN.InUse = false;
            objFeatureAppTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFeatureAppTypeRelaEN.UpdUser = strUserId;
            return clsFeatureAppTypeRelaBL.UpdateBySql2(objFeatureAppTypeRelaEN);

        }

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFeatureAppTypeRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFeatureAppTypeRelaDAEx FeatureAppTypeRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFeatureAppTypeRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="lngmId">表关键字</param>
        /// <returns></returns>
        private new static bool DelRecordEx(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFeatureAppTypeRelaDA.GetSpecSQLObj();
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
                //删除与表:[FeatureAppTypeRela]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsFeatureAppTypeRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsFeatureAppTypeRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                lngmId, clsStackTrace.GetCurrClassFunction());
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
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsFeatureAppTypeRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsFeatureAppTypeRelaEN> arrObjLst = clsFeatureAppTypeRelaBL.GetObjLst(strCondition);
            List<clsFeatureAppTypeRelaENEx> arrObjExLst = new List<clsFeatureAppTypeRelaENEx>();
            foreach (clsFeatureAppTypeRelaEN objInFor in arrObjLst)
            {
                clsFeatureAppTypeRelaENEx objFeatureAppTypeRelaENEx = new clsFeatureAppTypeRelaENEx();
                clsFeatureAppTypeRelaBL.CopyTo(objInFor, objFeatureAppTypeRelaENEx);
                arrObjExLst.Add(objFeatureAppTypeRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsFeatureAppTypeRelaENEx GetObjExBymId(long lngmId)
        {
            clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = clsFeatureAppTypeRelaBL.GetObjBymId(lngmId);
            clsFeatureAppTypeRelaENEx objFeatureAppTypeRelaENEx = new clsFeatureAppTypeRelaENEx();
            clsFeatureAppTypeRelaBL.CopyTo(objFeatureAppTypeRelaEN, objFeatureAppTypeRelaENEx);
            return objFeatureAppTypeRelaENEx;
        }
        /// <summary>
        /// 为所有应用导入所有功能
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <returns>共导入的记录数</returns>
        public static int ImportAllFeature4AllAppType(string strUserId)
        {
            List<clsPrjFeatureENEx> arrPrjFeatureObjLst = clsPrjFeatureBLEx.GetObjExLst4FrontEnd();
            List<clsApplicationTypeEN> arrAppTypeObjLst = clsApplicationTypeBLEx.GetObjLst4Visible();
            int intCount = 0;
            foreach (clsApplicationTypeEN objAppType in arrAppTypeObjLst)
            {
                foreach (clsPrjFeatureENEx objFeature in arrPrjFeatureObjLst)
                {
                    clsFeatureAppTypeRelaEN objFeatureAppType = new clsFeatureAppTypeRelaEN();
                    objFeatureAppType.ApplicationTypeId = objAppType.ApplicationTypeId;
                    objFeatureAppType.FeatureId = objFeature.FeatureId;
                    objFeatureAppType.InUse = true;
                    objFeatureAppType.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objFeatureAppType.UpdUser = strUserId;
                    if (objFeatureAppType.CheckUniqueness() == true)
                    {
                        clsFeatureAppTypeRelaBL.AddNewRecordBySql2(objFeatureAppType);
                        intCount++;
                    }
                }
            }
            return intCount;
        }
    }
}