
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMFeatureRequirementBLEx
表名:CMFeatureRequirement(00050520)
生成代码版本:2019.11.08.1
生成日期:2019/11/12 22:58:06
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


namespace AGC.BusinessLogicEx
{
    public static class clsCMFeatureRequirementBLEx_Static
    {

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsCMFeatureRequirementEN objCMFeatureRequirementEN)
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
                objCMFeatureRequirementEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objCMFeatureRequirementEN.AddNewRecord();
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
        /// <param name = "objCMFeatureRequirementEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsCMFeatureRequirementEN objCMFeatureRequirementEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objCMFeatureRequirementEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objCMFeatureRequirementEN.Update();
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
        /// <param name = "objCMFeatureRequirement">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsCMFeatureRequirementEN objCMFeatureRequirement)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsCMFeatureRequirementEN objCMFeatureRequirement_Cond = new clsCMFeatureRequirementEN();
            string strCondition = objCMFeatureRequirement_Cond
            .SetCmFeatureId(objCMFeatureRequirement.CmFeatureId, "=")
            .SetReqId(objCMFeatureRequirement.ReqId, "=")
            .GetCombineCondition();
            objCMFeatureRequirement._IsCheckProperty = true;
            bool bolIsExist = clsCMFeatureRequirementBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objCMFeatureRequirement.mId = clsCMFeatureRequirementBL.GetFirstID_S(strCondition);
                objCMFeatureRequirement.UpdateWithCondition(strCondition);
            }
            else
            {
                objCMFeatureRequirement.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMFeatureRequirementENS">源对象</param>
        /// <returns>目标对象=>clsCMFeatureRequirementEN:objCMFeatureRequirementENT</returns>
        public static clsCMFeatureRequirementENEx CopyToEx(this clsCMFeatureRequirementEN objCMFeatureRequirementENS)
        {
            try
            {
                clsCMFeatureRequirementENEx objCMFeatureRequirementENT = new clsCMFeatureRequirementENEx();
                clsCMFeatureRequirementBL.CopyTo(objCMFeatureRequirementENS, objCMFeatureRequirementENT);
                return objCMFeatureRequirementENT;
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
        /// <param name = "objCMFeatureRequirementENS">源对象</param>
        /// <returns>目标对象=>clsCMFeatureRequirementEN:objCMFeatureRequirementENT</returns>
        public static clsCMFeatureRequirementEN CopyTo(this clsCMFeatureRequirementENEx objCMFeatureRequirementENS)
        {
            try
            {
                clsCMFeatureRequirementEN objCMFeatureRequirementENT = new clsCMFeatureRequirementEN();
                clsCMFeatureRequirementBL.CopyTo(objCMFeatureRequirementENS, objCMFeatureRequirementENT);
                return objCMFeatureRequirementENT;
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
    /// CM功能需求关系(CMFeatureRequirement)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMFeatureRequirementBLEx : clsCMFeatureRequirementBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMFeatureRequirementDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMFeatureRequirementDAEx CMFeatureRequirementDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMFeatureRequirementDAEx();
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
        public static bool DelRecordEx(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsCMFeatureRequirementDA.GetSpecSQLObj();
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
                //删除与表:[CMFeatureRequirement]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conCMFeatureRequirement.mId,
                //lngmId);
                //        clsCMFeatureRequirementBL.DelCMFeatureRequirementsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsCMFeatureRequirementBL.DelRecord(lngmId,"", objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCMFeatureRequirementBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
        public static List<clsCMFeatureRequirementENEx> GetObjExLst(string strCondition)
        {
            List<clsCMFeatureRequirementEN> arrObjLst = clsCMFeatureRequirementBL.GetObjLst(strCondition);
            List<clsCMFeatureRequirementENEx> arrObjExLst = new List<clsCMFeatureRequirementENEx>();
            foreach (clsCMFeatureRequirementEN objInFor in arrObjLst)
            {
                clsCMFeatureRequirementENEx objCMFeatureRequirementENEx = new clsCMFeatureRequirementENEx();
                clsCMFeatureRequirementBL.CopyTo(objInFor, objCMFeatureRequirementENEx);
                arrObjExLst.Add(objCMFeatureRequirementENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMFeatureRequirementENEx GetObjExBymId(long lngmId)
        {
            clsCMFeatureRequirementEN objCMFeatureRequirementEN = clsCMFeatureRequirementBL.GetObjBymId(lngmId);
            clsCMFeatureRequirementENEx objCMFeatureRequirementENEx = new clsCMFeatureRequirementENEx();
            clsCMFeatureRequirementBL.CopyTo(objCMFeatureRequirementEN, objCMFeatureRequirementENEx);
            return objCMFeatureRequirementENEx;
        }

        /// <summary>
        /// 同步满足条件的学生信息到Web
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static int SynchToServerByCondition(string strCondition, string strUserId)
        {
            //string strCondition = string.Format("id_CurrEduClass='{0}'", strId_TransferCourses);
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                throw new Exception("上传到WEB库时，同步人不能为空！");
            }
            int intCount = 0;
            clsSysParaEN.strConnectStrName = "ConnectionString";
            string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();               
            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
            List<clsCMFeatureRequirementEN> arrCMFeatureRequirementENObjLst = clsCMFeatureRequirementBL.GetObjLst(strCondition);
            foreach (clsCMFeatureRequirementEN objCMFeatureRequirementEN4Web in arrCMFeatureRequirementENObjLst)
            {

                objCMFeatureRequirementEN4Web.IsSynchToServer = true;
                objCMFeatureRequirementEN4Web.SynchToServerDate = strCurrDate14;
                objCMFeatureRequirementEN4Web.SynchToServerUser = strUserId;
                clsSysParaEN.strConnectStrName = "ConnectionString";

                try
                {
                    clsCMFeatureRequirementEN objCMFeatureRequirementEN4Web2 = new clsCMFeatureRequirementEN();
                    clsCMFeatureRequirementBL.CopyTo(objCMFeatureRequirementEN4Web, objCMFeatureRequirementEN4Web2);
                    objCMFeatureRequirementEN4Web2.SynSource = "Client";

                    strCondition = objCMFeatureRequirementEN4Web.GetUniCondStr();

                    clsCMFeatureRequirementEN objCMFeatureRequirement_Target = clsCMFeatureRequirementBL.GetFirstObj_S(strCondition);

                    if (objCMFeatureRequirement_Target != null)
                    {
                        //如果目标地的对象日期小于来源对象的日期就更新
                        int intResult = objCMFeatureRequirement_Target.UpdDate.CompareTo(objCMFeatureRequirementEN4Web.UpdDate);
                        if (intResult < 0)
                        {
                            objCMFeatureRequirementEN4Web2.UpdateWithCondition(strCondition);
                            intCount++;
                        }
                    }
                    else
                    {
                        //if (clsFieldTabBL.IsExist(objCMFeatureRequirementEN4Web2.ReqId) == false)
                        //{
                        //    clsFieldTabBLEx.SynchToServerByReqId(objCMFeatureRequirementEN4Web2.ReqId, strUserId);
                        //}
                        clsCMFeatureRequirementBL.AddNewRecordBySql2(objCMFeatureRequirementEN4Web2);
                        intCount++;
                    }

                    clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
                    clsCMFeatureRequirementBL.UpdateBySql2(objCMFeatureRequirementEN4Web);
                }
                catch (Exception objException)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("在同步到Main库，工程表字段：{0}({1})时出错。({3}).[上级抛错:{2}]", objCMFeatureRequirementEN4Web.mId,
                                objCMFeatureRequirementEN4Web.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(sbMsg.ToString());
                }
            }
            clsSysParaEN.strConnectStrName = "ConnectionString";
            return intCount;
        }


        /// <summary>
        /// 同步满足条件的学生信息到Web
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static int SynchToClientByCondition(string strCondition, string strUserId)
        {
            //string strCondition = string.Format("id_CurrEduClass='{0}'", strId_TransferCourses);
            if (string.IsNullOrEmpty(strUserId) == true)
            {
                throw new Exception("上传到WEB库时，同步人不能为空！");
            }
            int intCount = 0;
            clsSysParaEN.strConnectStrName = "ConnectionString";
            string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
                       
            clsSysParaEN.strConnectStrName = "ConnectionString";

            List<clsCMFeatureRequirementEN> arrCMFeatureRequirementENObjLst = clsCMFeatureRequirementBL.GetObjLst(strCondition);

            foreach (clsCMFeatureRequirementEN objCMFeatureRequirementEN4Main in arrCMFeatureRequirementENObjLst)
            {

                objCMFeatureRequirementEN4Main.IsSynchToClient = true;
                objCMFeatureRequirementEN4Main.SynchToClientDate = strCurrDate14;
                objCMFeatureRequirementEN4Main.SynchToClientUser = strUserId;
                clsSysParaEN.strConnectStrName = "ConnectionStringWeb";

                try
                {
                    clsCMFeatureRequirementEN objCMFeatureRequirementEN4Main2 = new clsCMFeatureRequirementEN();
                    clsCMFeatureRequirementBL.CopyTo(objCMFeatureRequirementEN4Main, objCMFeatureRequirementEN4Main2);
                    objCMFeatureRequirementEN4Main2.SynSource = "Server";
            
                    strCondition = objCMFeatureRequirementEN4Main.GetUniCondStr();
                    clsCMFeatureRequirementEN objCMFeatureRequirement_Target = clsCMFeatureRequirementBL.GetFirstObj_S(strCondition);

                    if (objCMFeatureRequirement_Target != null)
                    {
                        //如果目标地的对象日期小于来源对象的日期就更新
                        int intResult = objCMFeatureRequirement_Target.UpdDate.CompareTo(objCMFeatureRequirementEN4Main.UpdDate);
                        if (intResult < 0)
                        {
                            objCMFeatureRequirementEN4Main2.SetmId(objCMFeatureRequirement_Target.mId);
                            objCMFeatureRequirementEN4Main2.UpdateWithCondition(strCondition);
                            intCount++;
                        }
                    }
                    else
                    {
                        //if (clsFieldTabBL.IsExist(objCMFeatureRequirementEN4Main2.ReqId) == false)
                        //{
                        //    clsFieldTabBLEx.SynchToClientByReqId(objCMFeatureRequirementEN4Main2.ReqId, strUserId);
                        //}
                        clsCMFeatureRequirementBL.AddNewRecordBySql2(objCMFeatureRequirementEN4Main2);
                        intCount++;
                    }

                    clsSysParaEN.strConnectStrName = "ConnectionString";
                    clsCMFeatureRequirementBL.UpdateBySql2(objCMFeatureRequirementEN4Main);
                }
                catch (Exception objException)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("在同步到Web库，工程表字段：{0}({1})时出错。({3}).[上级抛错:{2}]", objCMFeatureRequirementEN4Main.mId,
                                objCMFeatureRequirementEN4Main.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(sbMsg.ToString());
                }
            }
            clsSysParaEN.strConnectStrName = "ConnectionString";
            return intCount;
        }
    }
}