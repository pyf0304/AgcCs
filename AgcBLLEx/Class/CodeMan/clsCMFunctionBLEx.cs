
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMFunctionBLEx
表名:CMFunction(00050502)
生成代码版本:2019.10.24.1
生成日期:2019/10/27 10:44:54
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
    public static class clsCMFunctionBLEx_Static
    {

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsCMFunctionEN objCMFunctionEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

            //因为是字符型自增主键，不需要检查主键是否已经存在，在添加时，再获取 最大值作为主键
            //if (clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId))	//判断是否有相同的关键字
            //{
            //strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
            //throw new Exception(strMsg);
            //}
            try
            {
                //2、检查传进去的对象属性是否合法
                objCMFunctionEN.CheckPropertyNew();
                //因为是字符型自增主键，所以在添加时，自动获取主键值。
                if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true || clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId) == true)
                {
                    objCMFunctionEN.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
                }
                //6、把数据实体层的数据存贮到数据库中
                objCMFunctionEN.AddNewRecord();
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
        /// <param name = "objCMFunctionEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsCMFunctionEN objCMFunctionEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objCMFunctionEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objCMFunctionEN.Update();
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
        /// <param name = "objCMFunction">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsCMFunctionEN objCMFunction)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsCMFunctionEN objCMFunction_Cond = new clsCMFunctionEN();
            string strCondition = objCMFunction_Cond
            .SetFunctionName(objCMFunction.FunctionName, "=")
            .SetFuncParaLst(objCMFunction.FuncParaLst, "=")
            .SetCmClassId(objCMFunction.CmClassId, "=")
            .GetCombineCondition();
            objCMFunction._IsCheckProperty = true;
            bool bolIsExist = clsCMFunctionBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objCMFunction.CmFunctionId = clsCMFunctionBL.GetFirstID_S(strCondition);
                objCMFunction.UpdateWithCondition(strCondition);
            }
            else
            {
                objCMFunction.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
                objCMFunction.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMFunctionENS">源对象</param>
        /// <returns>目标对象=>clsCMFunctionEN:objCMFunctionENT</returns>
        public static clsCMFunctionENEx CopyToEx(this clsCMFunctionEN objCMFunctionENS)
        {
            try
            {
                clsCMFunctionENEx objCMFunctionENT = new clsCMFunctionENEx();
                clsCMFunctionBL.CopyTo(objCMFunctionENS, objCMFunctionENT);
                return objCMFunctionENT;
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
        /// <param name = "objCMFunctionENS">源对象</param>
        /// <returns>目标对象=>clsCMFunctionEN:objCMFunctionENT</returns>
        public static clsCMFunctionEN CopyTo(this clsCMFunctionENEx objCMFunctionENS)
        {
            try
            {
                clsCMFunctionEN objCMFunctionENT = new clsCMFunctionEN();
                clsCMFunctionBL.CopyTo(objCMFunctionENS, objCMFunctionENT);
                return objCMFunctionENT;
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
    /// CM函数(CMFunction)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMFunctionBLEx : clsCMFunctionBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMFunctionDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMFunctionDAEx CMFunctionDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMFunctionDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strCmFunctionId">表关键字</param>
        /// <returns></returns>
        public static bool DelRecordEx(string strCmFunctionId, string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsCMFunctionDA.GetSpecSQLObj();
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
                //删除与表:[CMFunction]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'",
                conCMFunction.CmFunctionId,
                strCmFunctionId);
                clsCMFuncParaRelaBL.DelCMFuncParaRelasByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);

                clsCMFunctionBL.DelRecord(strCmFunctionId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCMFunctionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strCmFunctionId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clsCMFunctionENEx> GetObjExLst(string strCondition)
        {
            List<clsCMFunctionEN> arrObjLst = clsCMFunctionBL.GetObjLst(strCondition);
            List<clsCMFunctionENEx> arrObjExLst = new List<clsCMFunctionENEx>();
            foreach (clsCMFunctionEN objInFor in arrObjLst)
            {
                clsCMFunctionENEx objCMFunctionENEx = new clsCMFunctionENEx();
                clsCMFunctionBL.CopyTo(objInFor, objCMFunctionENEx);
                arrObjExLst.Add(objCMFunctionENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCmFunctionId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMFunctionENEx GetObjExByCmFunctionId(string strCmFunctionId)
        {
            clsCMFunctionEN objCMFunctionEN = clsCMFunctionBL.GetObjByCmFunctionId(strCmFunctionId);
            clsCMFunctionENEx objCMFunctionENEx = new clsCMFunctionENEx();
            clsCMFunctionBL.CopyTo(objCMFunctionEN, objCMFunctionENEx);
            return objCMFunctionENEx;
        }

        public static clsCMFunctionEN AddCMFunction(clsCMFunctionEN objCMFunction)
        {
            clsCMFunctionEN objCMFunction_Cond = new clsCMFunctionEN();
            string strCondition = objCMFunction_Cond
                .SetCmClassId(objCMFunction.CmClassId, "=")
                .SetFunctionName(objCMFunction.FunctionName, "=")                            
                .SetFuncParaLst(objCMFunction.FuncParaLst, "=")
               //.SetPrjId(objCMFunction.PrjId, "=")
                .GetUniCondStr();

            bool bolIsExist = clsCMFunctionBL.IsExistRecord(strCondition);

            if (bolIsExist)
            {
                objCMFunction.CmFunctionId = clsCMFunctionBL.GetFirstID_S(strCondition);
                objCMFunction.UpdateWithCondition(strCondition);
            }
            else
            {
  
                objCMFunction.SetCmFunctionId(clsCMFunctionBL.GetMaxStrId_S());
                objCMFunction.AddNewRecord();
            }

            return objCMFunction;
        }

        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="strCmFunctionId">strCmFunctionId</param>
        /// <param name="strUserId">strUserId</param>
        /// <returns></returns>
        public static clsCMFunctionEN CloneRecord(string strCmFunctionId, string strUserId)
        {
            clsCMFunctionEN objCMFunctionEN = clsCMFunctionBL.GetObjByCmFunctionId(strCmFunctionId);
            objCMFunctionEN.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
            objCMFunctionEN.FunctionName = "Copy_" + objCMFunctionEN.FunctionName;
            if (string.IsNullOrEmpty(objCMFunctionEN.ReturnTypeId))
            {
                objCMFunctionEN.ReturnTypeId = "29";
            }
            objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objCMFunctionEN.UpdUser = strUserId;
            
            try
            {
                clsCMFunctionBL.AddNewRecordBySql2(objCMFunctionEN);
                List<string> arrmId = clsCMFuncParaRelaBLEx.GetmIdLstByCmFunctionId(strCmFunctionId);
                IEnumerable<long> lstmId = arrmId.Select(x => long.Parse(x));
                foreach (long strFuncParaId4Code in lstmId)
                {
                    clsCMFuncParaRelaEN objCMFuncParaRelaEN = clsCMFuncParaRelaBLEx.CloneRecord(strFuncParaId4Code, strUserId);
                    objCMFuncParaRelaEN.CmFunctionId = objCMFunctionEN.CmFunctionId;
                    clsCMFuncParaRelaBL.UpdateBySql2(objCMFuncParaRelaEN);
                }
                return objCMFunctionEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(strFuncId4GC:{1})({2})",
                    objException.Message,
                    strCmFunctionId,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_CmFunctionIdEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("1 = 1 and {0}='0' And {1}='0' Order By {2}",
                conCMFunction.IsSysFunction,
                conCMFunction.IsAsyncFunc,
                conCMFunction.FunctionName);
            System.Data.DataTable objDT = clsCMFunctionBL.GetDataTable(strCondition);
            objDDL.DataValueField = conCMFunction.CmFunctionId;
            objDDL.DataTextField = conCMFunction.FunctionName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 同步满足条件的记录，从Server到Client
        /// </summary>
        /// <param name="strCondition">同步的条件</param>
        /// <param name="strOpUserId">操作同步的用户</param>
        /// <returns></returns>
        public static int SynchToClientByCondition(string strCondition, string strOpUserId)
        {
            if (string.IsNullOrEmpty(strOpUserId) == true)
            {
                throw new Exception("上传到Client库时，同步人不能为空！");
            }
            int intCount = 0;
            string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
            clsSysParaEN.strConnectStrName = "ConnectionString";

            List<clsCMFunctionEN> arrCMFunctionENObjLst = clsCMFunctionBL.GetObjLst(strCondition);

            foreach (clsCMFunctionEN objCMFunctionEN4Main in arrCMFunctionENObjLst)
            {
                //如果这条记录的来源就是Client,就不需要同步了
                if (objCMFunctionEN4Main.SynSource == "Client") continue;
                objCMFunctionEN4Main.IsSynchToClient = true;
                objCMFunctionEN4Main.SynchToClientDate = strCurrDate14;
                objCMFunctionEN4Main.SynchToClientUser = strOpUserId;
                clsSysParaEN.strConnectStrName = "ConnectionStringClient";

                try
                {
                    clsCMFunctionEN objCMFunctionEN4Main2 = new clsCMFunctionEN();
                    clsCMFunctionBL.CopyTo(objCMFunctionEN4Main, objCMFunctionEN4Main2);
                    objCMFunctionEN4Main2.SynSource = "Server";
                    strCondition = objCMFunctionEN4Main.GetUniCondStr();
                    clsCMFunctionEN objCMFunction_Target = clsCMFunctionBL.GetFirstObj_S(strCondition);

                    if (objCMFunction_Target != null)
                    {
                        //如果目标地的对象日期小于来源对象的日期就更新
                        int intResult = objCMFunction_Target.UpdDate.CompareTo(objCMFunctionEN4Main.UpdDate);
                        if (intResult < 0)
                        {

                            objCMFunctionEN4Main2.UpdateWithCondition(strCondition);
                            intCount++;
                        }
                    }
                    else
                    {
                        //string strPrjId = clsCMProjectBLEx.GetObjByCmPrjIdCache(objCMFunctionEN4Main2.CmPrjId).PrjId;
                        objCMFunctionEN4Main2.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
                        objCMFunctionEN4Main2.AddRecordEx();
                        intCount++;
                    }

                    clsSysParaEN.strConnectStrName = "ConnectionString";
                    objCMFunctionEN4Main.UpdateRecordEx();
                }
                catch (Exception objException)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("在同步到Client库，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]", objCMFunctionEN4Main.CmFunctionId,
                                objCMFunctionEN4Main.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(sbMsg.ToString());
                }
            }
            clsSysParaEN.strConnectStrName = "ConnectionString";
            return intCount;
        }

        /// <summary>
        /// 同步满足条件的记录，从Client到Server
        /// </summary>
        /// <param name="strCondition">同步的条件</param>
        /// <param name="strOpUserId">操作同步的用户</param>
        /// <returns></returns>
        public static int SynchToServerByCondition(string strCondition, string strOpUserId)
        {

            if (string.IsNullOrEmpty(strOpUserId) == true)
            {
                throw new Exception("同步到服务端时，同步人不能为空！");
            }
            int intCount = 0;

            string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
            clsSysParaEN.strConnectStrName = "ConnectionStringClient";

            List<clsCMFunctionEN> arrCMFunctionENObjLst = clsCMFunctionBL.GetObjLst(strCondition);

            foreach (clsCMFunctionEN objCMFunctionEN4Web in arrCMFunctionENObjLst)
            {
                //如果这条记录的来源就是Server,就不需要同步了
                if (objCMFunctionEN4Web.SynSource == "Server") continue;
                objCMFunctionEN4Web.IsSynchToServer = true;
                objCMFunctionEN4Web.SynchToServerDate = strCurrDate14;
                objCMFunctionEN4Web.SynchToServerUser = strOpUserId;
                clsSysParaEN.strConnectStrName = "ConnectionString";

                objCMFunctionEN4Web.SynSource = "Client";
                try
                {
                    strCondition = objCMFunctionEN4Web.GetUniCondStr();
                    clsCMFunctionEN objCMFunction_Target = clsCMFunctionBL.GetFirstObj_S(strCondition);
                    if (objCMFunction_Target != null)
                    {
                        int intResult = (objCMFunction_Target.UpdDate.CompareTo(objCMFunctionEN4Web.UpdDate));
                        if (intResult < 0)
                        {
                            objCMFunctionEN4Web.UpdateWithCondition(strCondition);
                        }
                    }
                    else
                    {
                        //string strPrjId = clsCMProjectBLEx.GetObjByCmPrjIdCache(objCMFunctionEN4Web.CmPrjId).PrjId;
                        objCMFunctionEN4Web.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
                        objCMFunctionEN4Web.AddRecordEx();
                    }

                    clsSysParaEN.strConnectStrName = "ConnectionStringClient";
                    objCMFunctionEN4Web.UpdateRecordEx();
                }
                catch (Exception objException)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("在同步到Server端时，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]",
                                clsCMFunctionEN._CurrTabName,
                                objCMFunctionEN4Web.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(sbMsg.ToString());
                }
            }
            clsSysParaEN.strConnectStrName = "ConnectionString";
            return intCount;
        }
    }
}