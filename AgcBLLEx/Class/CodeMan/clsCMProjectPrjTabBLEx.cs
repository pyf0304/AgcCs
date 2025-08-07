
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCmProjectPrjTabBLEx
表名:CMProjectPrjTab(00050530)
生成代码版本:2020.01.15.1
生成日期:2020/01/16 00:00:29
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
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
    public static class clsCmProjectPrjTabBLEx_Static
    {

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsCmProjectPrjTabEN objCMProjectPrjTabEN)
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
                objCMProjectPrjTabEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objCMProjectPrjTabEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
        /// </summary>
        /// <param name = "objCMProjectPrjTabEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsCmProjectPrjTabEN objCMProjectPrjTabEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objCMProjectPrjTabEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objCMProjectPrjTabEN.Update();
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
        /// <param name = "objCMProjectPrjTab">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsCmProjectPrjTabEN objCMProjectPrjTab)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsCmProjectPrjTabEN objCMProjectPrjTab_Cond = new clsCmProjectPrjTabEN();
            string strCondition = objCMProjectPrjTab_Cond
            .SetTabId(objCMProjectPrjTab.TabId, "=")
            .SetCmPrjId(objCMProjectPrjTab.CmPrjId, "=")
            .GetCombineCondition();
            objCMProjectPrjTab._IsCheckProperty = true;
            bool bolIsExist = clsCmProjectPrjTabBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objCMProjectPrjTab.mId = clsCmProjectPrjTabBL.GetFirstID_S(strCondition);
                objCMProjectPrjTab.UpdateWithCondition(strCondition);
            }
            else
            {
                objCMProjectPrjTab.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMProjectPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsCmProjectPrjTabEN:objCMProjectPrjTabENT</returns>
        public static clsCmProjectPrjTabENEx CopyToEx(this clsCmProjectPrjTabEN objCMProjectPrjTabENS)
        {
            try
            {
                clsCmProjectPrjTabENEx objCMProjectPrjTabENT = new clsCmProjectPrjTabENEx();
                clsCmProjectPrjTabBL.CmProjectPrjTabDA.CopyTo(objCMProjectPrjTabENS, objCMProjectPrjTabENT);
                return objCMProjectPrjTabENT;
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
        /// <param name = "objCMProjectPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsCmProjectPrjTabEN:objCMProjectPrjTabENT</returns>
        public static clsCmProjectPrjTabEN CopyTo(this clsCmProjectPrjTabENEx objCMProjectPrjTabENS)
        {
            try
            {
                clsCmProjectPrjTabEN objCMProjectPrjTabENT = new clsCmProjectPrjTabEN();
                clsCmProjectPrjTabBL.CopyTo(objCMProjectPrjTabENS, objCMProjectPrjTabENT);
                return objCMProjectPrjTabENT;
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
    /// CM项目工程表关系(CMProjectPrjTab)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCmProjectPrjTabBLEx : clsCmProjectPrjTabBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCmProjectPrjTabDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCmProjectPrjTabDAEx CmProjectPrjTabDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCmProjectPrjTabDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 建立Cm工程与表的关系
        /// </summary>
        /// <param name = "strCmPrjId">Cm工程Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>修改是否成功？</returns>
        public static bool CreateRela(string strCmPrjId, string strTabId, string strOpUserId)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsCmProjectPrjTabEN objCMProjectPrjTab_Cond = new clsCmProjectPrjTabEN();
            string strCondition = objCMProjectPrjTab_Cond
            .SetTabId(strTabId, "=")
            .SetCmPrjId(strCmPrjId, "=")
            .GetCombineCondition();
            objCMProjectPrjTab_Cond._IsCheckProperty = true;
            bool bolIsExist = clsCmProjectPrjTabBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                //objCMProjectPrjTab_Cond.mId = clsCmProjectPrjTabBL.GetFirstID_S(strCondition);
                //objCMProjectPrjTab_Cond.UpdateWithCondition(strCondition);
            }
            else
            {
                objCMProjectPrjTab_Cond.OrderNum = 1;
                objCMProjectPrjTab_Cond.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objCMProjectPrjTab_Cond.UpdUser = strOpUserId;
                var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
                //objCMProjectPrjTab_Cond.PrjId = objCmProject.PrjId;
                objCMProjectPrjTab_Cond.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 删除Cm工程与表的关系
        /// </summary>
        /// <param name = "strCmPrjId">Cm工程Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>删除记录数</returns>
        public static int DelRela(string strCmPrjId, string strTabId)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsCmProjectPrjTabEN objCMProjectPrjTab_Cond = new clsCmProjectPrjTabEN();
            string strCondition = objCMProjectPrjTab_Cond
            .SetTabId(strTabId, "=")
            .SetCmPrjId(strCmPrjId, "=")
            .GetCombineCondition();            
            int intRecNum = clsCmProjectPrjTabBL.DelCmProjectPrjTabsByCond(strCondition);
            return intRecNum;
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
            objSQL = clsCmProjectPrjTabDA.GetSpecSQLObj();
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
                //删除与表:[CMProjectPrjTab]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conCmProjectPrjTab.mId,
                //lngmId);
                //        clsCmProjectPrjTabBL.DelCmProjectPrjTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsCmProjectPrjTabBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCmProjectPrjTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
        public static List<clsCmProjectPrjTabENEx> GetObjExLst(string strCondition)
        {
            List<clsCmProjectPrjTabEN> arrObjLst = clsCmProjectPrjTabBL.GetObjLst(strCondition);
            List<clsCmProjectPrjTabENEx> arrObjExLst = new List<clsCmProjectPrjTabENEx>();
            foreach (clsCmProjectPrjTabEN objInFor in arrObjLst)
            {
                clsCmProjectPrjTabENEx objCMProjectPrjTabENEx = new clsCmProjectPrjTabENEx();
                clsCmProjectPrjTabBL.CopyTo(objInFor, objCMProjectPrjTabENEx);
                arrObjExLst.Add(objCMProjectPrjTabENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCmProjectPrjTabENEx GetObjExBymId(long lngmId)
        {
            clsCmProjectPrjTabEN objCMProjectPrjTabEN = clsCmProjectPrjTabBL.GetObjBymId(lngmId);
            clsCmProjectPrjTabENEx objCMProjectPrjTabENEx = new clsCmProjectPrjTabENEx();
            clsCmProjectPrjTabBL.CopyTo(objCMProjectPrjTabEN, objCMProjectPrjTabENEx);
            return objCMProjectPrjTabENEx;
        }
        
        /// <summary>
        /// 根据CmPrjId获取表Id列表
        /// </summary>
        /// <param name = "strCmPrjId">条件对象</param>
        /// <returns>获取表Id列表</returns>
        public static List<string> GetTabIdLstCache(string strCmPrjId)
        {
            List<clsCmProjectPrjTabEN> arrObjLstCache = GetObjLstCache(strCmPrjId);
            List<string> arrTabId_Sel = arrObjLstCache.Where(x => x.CmPrjId == strCmPrjId).Select(x=>x.TabId).ToList();
            return arrTabId_Sel;
        }

        public static clsCmProjectPrjTabEN GetObjByTabIdCache(string strCmPrjId, string strTabId)
        {
            List<clsCmProjectPrjTabEN> arrObjLstCache = GetObjLstCache(strCmPrjId);
            List<clsCmProjectPrjTabEN> arrObjLst_Sel = arrObjLstCache.Where(x => x.TabId == strTabId).ToList();
            if (arrObjLst_Sel.Count > 0)
            {
                return arrObjLst_Sel[0];
            }
            else return null;
        }
        //public static string GetFirstCmPrjIdByTabIdCache(string strTabId_Out4ListRegion)
        //{
        //    List<clsCmProjectPrjTabEN> arrObjLstCache = GetObjLstCache();
        //    List<string> arrCmPrjId_Sel = arrObjLstCache.Where(x => x.TabId == strTabId_Out4ListRegion).Select(x => x.CmPrjId).ToList();
        //    return arrCmPrjId_Sel[0];
        //}

        /// <summary>
        /// 功能:判断是否存在某一条件的记录
        /// </summary>
        /// <param name = "strCmPrjId">CM工程</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
        public static bool IsExistRecord(string strCmPrjId, string strTabId)
        {
            //检测记录是否存在
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conCmProjectPrjTab.CmPrjId, strCmPrjId, convCmProjectPrjTab.TabId, strTabId);
            bool bolIsExist = CmProjectPrjTabDA.IsExistCondRec(strCondition);
            return bolIsExist;
        }
    }
}