
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMFuncParaRelaBLEx
表名:CMFuncParaRela(00050504)
生成代码版本:2019.10.24.1
生成日期:2019/10/27 10:44:49
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理
模块英文名:CodeMan
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
    public static class clsCMFuncParaRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMFuncParaRelaENS">源对象</param>
        /// <returns>目标对象=>clsCMFuncParaRelaEN:objCMFuncParaRelaENT</returns>
        public static clsCMFuncParaRelaENEx CopyToEx(this clsCMFuncParaRelaEN objCMFuncParaRelaENS)
        {
            try
            {
                clsCMFuncParaRelaENEx objCMFuncParaRelaENT = new clsCMFuncParaRelaENEx();
                clsCMFuncParaRelaBL.CopyTo(objCMFuncParaRelaENS, objCMFuncParaRelaENT);
                return objCMFuncParaRelaENT;
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
        /// <param name = "objCMFuncParaRelaENS">源对象</param>
        /// <returns>目标对象=>clsCMFuncParaRelaEN:objCMFuncParaRelaENT</returns>
        public static clsCMFuncParaRelaEN CopyTo(this clsCMFuncParaRelaENEx objCMFuncParaRelaENS)
        {
            try
            {
                clsCMFuncParaRelaEN objCMFuncParaRelaENT = new clsCMFuncParaRelaEN();
                clsCMFuncParaRelaBL.CopyTo(objCMFuncParaRelaENS, objCMFuncParaRelaENT);
                return objCMFuncParaRelaENT;
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
    /// CM函数参数关系(CMFuncParaRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMFuncParaRelaBLEx : clsCMFuncParaRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMFuncParaRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMFuncParaRelaDAEx CMFuncParaRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMFuncParaRelaDAEx();
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
        public new static bool DelRecordEx(long lngmId, string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsCMFuncParaRelaDA.GetSpecSQLObj();
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
                //删除与表:[CMFuncParaRela]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conCMFuncParaRela.mId,
                //lngmId);
                //        clsCMFuncParaRelaBL.DelCMFuncParaRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsCMFuncParaRelaBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCMFuncParaRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
        public static List<clsCMFuncParaRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsCMFuncParaRelaEN> arrObjLst = clsCMFuncParaRelaBL.GetObjLst(strCondition);
            List<clsCMFuncParaRelaENEx> arrObjExLst = new List<clsCMFuncParaRelaENEx>();
            foreach (clsCMFuncParaRelaEN objInFor in arrObjLst)
            {
                clsCMFuncParaRelaENEx objCMFuncParaRelaENEx = new clsCMFuncParaRelaENEx();
                clsCMFuncParaRelaBL.CopyTo(objInFor, objCMFuncParaRelaENEx);
                arrObjExLst.Add(objCMFuncParaRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMFuncParaRelaENEx GetObjExBymId(long lngmId)
        {
            clsCMFuncParaRelaEN objCMFuncParaRelaEN = clsCMFuncParaRelaBL.GetObjBymId(lngmId);
            clsCMFuncParaRelaENEx objCMFuncParaRelaENEx = new clsCMFuncParaRelaENEx();
            clsCMFuncParaRelaBL.CopyTo(objCMFuncParaRelaEN, objCMFuncParaRelaENEx);
            return objCMFuncParaRelaENEx;
        }

        public static clsCMFuncParaRelaEN AddCMFuncParaRela(clsCMFuncParaRelaEN objCMFuncParaRela)
        {
            clsCMFuncParaRelaEN objCMFuncParaRela_Cond = new clsCMFuncParaRelaEN();
            string strCondition = objCMFuncParaRela_Cond
                        .SetCmFuncParaId(objCMFuncParaRela.CmFuncParaId, "=")
                        .SetCmFunctionId(objCMFuncParaRela.CmFunctionId, "=")
                        .GetUniCondStr();

            bool bolIsExist = clsCMFuncParaRelaBL.IsExistRecord(strCondition);

            if (bolIsExist)
            {
                objCMFuncParaRela.mId = clsCMFuncParaRelaBL.GetFirstID_S(strCondition);
                objCMFuncParaRela.UpdateWithCondition(strCondition);
            }
            else
            {
                objCMFuncParaRela.AddNewRecord();
            }

            return objCMFuncParaRela;
        }
        /// <summary>
        /// 根据函数Id4Code获取相关参数对象列表, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strCmFunctionId">函数Id4Code</param>
        /// <returns>根据函数Id4Code获取相关参数对象列表</returns>
        public static List<clsCMFuncParaRelaEN> GetObjListByCmFunctionIdCacheEx(string strCmFunctionId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strCmFunctionId) == true) return null;
            //初始化列表缓存
            //InitListCache();
            List<clsCMFuncParaRelaEN> arrObjLstCache = clsCMFuncParaRelaBL.GetObjLstCache(strPrjId);

            IEnumerable<clsCMFuncParaRelaEN> arrCMFuncParaRelaObjLst_Sel1 =
            from objCMFuncParaRelaEN in arrObjLstCache
            where objCMFuncParaRelaEN.CmFunctionId == strCmFunctionId
            select objCMFuncParaRelaEN;
            List<clsCMFuncParaRelaEN> arrCMFuncParaRelaObjLst_Sel = new List<clsCMFuncParaRelaEN>();
            foreach (clsCMFuncParaRelaEN obj in arrCMFuncParaRelaObjLst_Sel1)
            {
                arrCMFuncParaRelaObjLst_Sel.Add(obj);
            }
            if (arrCMFuncParaRelaObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrCMFuncParaRelaObjLst_Sel;
        }

        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="lngMid">strFuncParaId4Code</param>
        /// <returns></returns>
        public static clsCMFuncParaRelaEN CloneRecord(long lngMid, string strUserId)
        {
            clsCMFuncParaRelaEN objCMFuncParaRelaEN = clsCMFuncParaRelaBL.GetObjBymId(lngMid);

            //objCMFuncParaRelaEN.FuncParaId4Code = clsCMFuncParaRelaBL.GetMaxStrId_S();
            //objCMFuncParaRelaEN.ParaName = "Copy_" + objCMFuncParaRelaEN.ParaName;
            objCMFuncParaRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objCMFuncParaRelaEN.UpdUser = strUserId;
            //if (string.IsNullOrEmpty(obj.ReturnTypeId))
            //{
            //    obj.ReturnTypeId = "29";
            //}
            try
            {
                clsCMFuncParaRelaBL.AddNewRecordBySql2(objCMFuncParaRelaEN);
                return objCMFuncParaRelaEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(mId:{1})({2})",
                     objException.Message,
                     lngMid,
                     clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCmFunctionId"></param>
        /// <returns></returns>
        public static List<string> GetmIdLstByCmFunctionId(string strCmFunctionId)
        {
            string strCondition = string.Format("{0}='{1}'", conCMFuncParaRela.CmFunctionId, strCmFunctionId);

            List<string> arrmIdLst = clsCMFuncParaRelaBL.GetFldValue(conCMFuncParaRela.mId, strCondition);
            return arrmIdLst;
        }
    }
}