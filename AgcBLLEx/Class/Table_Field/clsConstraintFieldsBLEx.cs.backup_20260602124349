
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
    public static class clsConstraintFieldsBLEx_Static
    {
        public static clsFieldTabEN ObjFieldTab(this clsConstraintFieldsEN objConstraintFields)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objConstraintFields.FldId, objConstraintFields.PrjId);
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表功能字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsPrjTabFldEN ObjPrjTabFld(this clsConstraintFieldsEN objConstraintFields)
        {
            try
            {
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objConstraintFields.TabId, objConstraintFields.FldId, objConstraintFields.PrjId);
                return objPrjTabFld;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表约束功能字段获取表字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objConstraintFieldsENS">源对象</param>
        /// <returns>目标对象=>clsConstraintFieldsEN:objConstraintFieldsENT</returns>
        public static clsConstraintFieldsENEx CopyToEx(this clsConstraintFieldsEN objConstraintFieldsENS)
        {
            try
            {
                clsConstraintFieldsENEx objConstraintFieldsENT = new clsConstraintFieldsENEx();
                clsConstraintFieldsBL.CopyTo(objConstraintFieldsENS, objConstraintFieldsENT);
                return objConstraintFieldsENT;
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
        /// <param name = "objConstraintFieldsENS">源对象</param>
        /// <returns>目标对象=>clsConstraintFieldsEN:objConstraintFieldsENT</returns>
        public static clsConstraintFieldsEN CopyTo(this clsConstraintFieldsENEx objConstraintFieldsENS)
        {
            try
            {
                clsConstraintFieldsEN objConstraintFieldsENT = new clsConstraintFieldsEN();
                clsConstraintFieldsBL.CopyTo(objConstraintFieldsENS, objConstraintFieldsENT);
                return objConstraintFieldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
        /// </summary>
        /// <param name = "objConstraintFieldsEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsConstraintFieldsEN objConstraintFieldsEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objConstraintFieldsEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objConstraintFieldsEN.Update();
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_EditRecordEx)
        /// </summary>
        /// <param name = "objConstraintFields">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsConstraintFieldsEN objConstraintFields)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsConstraintFieldsEN objConstraintFields_Cond = new clsConstraintFieldsEN();
            string strCondition = objConstraintFields_Cond
            .SetPrjConstraintId(objConstraintFields.PrjConstraintId, "=")
            .SetFldId(objConstraintFields.FldId, "=")
            .GetCombineCondition();
            objConstraintFields._IsCheckProperty = true;
            bool bolIsExist = clsConstraintFieldsBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objConstraintFields.mId = clsConstraintFieldsBL.GetFirstID_S(strCondition);
                objConstraintFields.UpdateWithCondition(strCondition);
            }
            else
            {
                objConstraintFields.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsConstraintFieldsEN objConstraintFieldsEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            try
            {
                //2、检查传进去的对象属性是否合法
                objConstraintFieldsEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objConstraintFieldsEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }
    }
    /// <summary>
    /// 约束字段(ConstraintFields)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsConstraintFieldsBLEx : clsConstraintFieldsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsConstraintFieldsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsConstraintFieldsDAEx ConstraintFieldsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsConstraintFieldsDAEx();
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
        private new static bool DelRecordEx(long lngmId, string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
                //删除与表:[ConstraintFields]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsConstraintFieldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsConstraintFieldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
        public static List<clsConstraintFieldsENEx> GetObjExLst(string strCondition)
        {
            List<clsConstraintFieldsEN> arrObjLst = clsConstraintFieldsBL.GetObjLst(strCondition);
            List<clsConstraintFieldsENEx> arrObjExLst = new List<clsConstraintFieldsENEx>();
            foreach (clsConstraintFieldsEN objInFor in arrObjLst)
            {
                clsConstraintFieldsENEx objConstraintFieldsENEx = new clsConstraintFieldsENEx();
                clsConstraintFieldsBL.CopyTo(objInFor, objConstraintFieldsENEx);
                arrObjExLst.Add(objConstraintFieldsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsConstraintFieldsENEx GetObjExBymId(long lngmId)
        {
            clsConstraintFieldsEN objConstraintFieldsEN = clsConstraintFieldsBL.GetObjBymId(lngmId);
            clsConstraintFieldsENEx objConstraintFieldsENEx = new clsConstraintFieldsENEx();
            clsConstraintFieldsBL.CopyTo(objConstraintFieldsEN, objConstraintFieldsENEx);
            return objConstraintFieldsENEx;
        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objConstraintFieldsENS">源对象</param>
        /// <returns>目标对象=>clsConstraintFieldsEN:objConstraintFieldsENT</returns>
        public static clsConstraintFieldsENEx CopyToEx(clsConstraintFieldsEN objConstraintFieldsENS)
        {
            try
            {
                clsConstraintFieldsENEx objConstraintFieldsENT = new clsConstraintFieldsENEx();
                clsConstraintFieldsBL.ConstraintFieldsDA.CopyTo(objConstraintFieldsENS, objConstraintFieldsENT);
                return objConstraintFieldsENT;
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
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.      
        /// </summary>
        /// <param name = "strPrjConstraintId">strPrjConstraintId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static IEnumerable<clsConstraintFieldsEN> GetObjLstByPrjConstraintIdCache(string strPrjConstraintId, string strPrjId)
        {
            //初始化列表缓存
            List<clsConstraintFieldsEN> arrObjLstCache = clsConstraintFieldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsConstraintFieldsEN> arrConstraintFieldsObjLst_Sel =
            arrObjLstCache
            .Where(x => x.PrjConstraintId == strPrjConstraintId);

            return arrConstraintFieldsObjLst_Sel;
        }
    }
}