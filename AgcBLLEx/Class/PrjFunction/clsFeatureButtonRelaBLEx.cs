
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFeatureButtonRelaBLEx
表名:FeatureButtonRela(00050426)
生成代码版本:2019.03.05.1
生成日期:2019/03/06 10:17:19
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
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.02.22.01
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

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 功能按钮关系(FeatureButtonRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public class clsFeatureButtonRelaBLEx : clsFeatureButtonRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFeatureButtonRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFeatureButtonRelaDAEx FeatureButtonRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFeatureButtonRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="lngmId">表关键字</param>
        /// <returns></returns>
        private new static bool DelRecordEx(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFeatureButtonRelaDA.GetSpecSQLObj();
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
                //删除与表:[FeatureButtonRela]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsFeatureButtonRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsFeatureButtonRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFeatureId">strFeatureId</param>
        /// <param name = "intAppTypeId">intAppTypeId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsFeatureButtonRelaEN> GetObjLstByFeatureIdCache(string strFeatureId, int intAppTypeId)
        {
            //获取缓存中的对象列表
            string strKey = string.Format("{0}", clsFeatureButtonRelaEN._CurrTabName);
            List<clsFeatureButtonRelaEN> arrFeatureButtonRelaObjLstCache = GetObjLstCache();
            IEnumerable<clsFeatureButtonRelaEN> arrFeatureButtonRelaObjLst_Sel =
            arrFeatureButtonRelaObjLstCache
            .Where(x => x.FeatureId == strFeatureId && x.ApplicationTypeId == intAppTypeId);
            if (arrFeatureButtonRelaObjLst_Sel.Count() == 0)
            {
                clsFeatureButtonRelaEN obj_Cond = new clsFeatureButtonRelaEN();
                string strCondtion =  obj_Cond.SetApplicationTypeId(intAppTypeId, "=")
                    .SetFeatureId(strFeatureId, "=")
                    .GetCombineCondition();
            List<clsFeatureButtonRelaEN> arrObj = clsFeatureButtonRelaBL.GetObjLst(strCondtion);
                if (arrObj.Count >0)
                {
                    CacheHelper.Remove(strKey);
                    return arrObj;
                }
                return null;
            }
            return arrFeatureButtonRelaObjLst_Sel.ToList();
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFeatureId">strFeatureId</param>
        /// <param name = "intAppTypeId">intAppTypeId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsButtonTabEN> GetButtonTabLstByFeatureIdCache(string strFeatureId, int intAppTypeId)
        {
            //获取缓存中的对象列表
            string strKey = string.Format("{0}", clsFeatureButtonRelaEN._CurrTabName);
            List<clsFeatureButtonRelaEN> arrFeatureButtonRelaObjLstCache = GetObjLstByFeatureIdCache(strFeatureId, intAppTypeId);
            var arrButtonId = arrFeatureButtonRelaObjLstCache.Select(x=>x.ButtonId).ToList();
            var arrButtonTab = arrButtonId.Select(x => clsButtonTabBL.GetObjByButtonIdCache(x)).ToList();
            return arrButtonTab;
        }

    }
}