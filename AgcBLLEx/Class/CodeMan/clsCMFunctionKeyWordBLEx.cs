
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMFunctionKeyWordBLEx
表名:CMFunctionKeyWord(00050515)
生成代码版本:2019.11.08.1
生成日期:2019/11/11 11:51:40
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
using com.taishsoft.util;

namespace AGC.BusinessLogicEx
{
    public static class clsCMFunctionKeyWordBLEx_Static
    {
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
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
                objCMFunctionKeyWordEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objCMFunctionKeyWordEN.AddNewRecord();
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
        /// <param name = "objCMFunctionKeyWordEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objCMFunctionKeyWordEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objCMFunctionKeyWordEN.Update();
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
        /// <param name = "objCMFunctionKeyWord">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsCMFunctionKeyWordEN objCMFunctionKeyWord)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsCMFunctionKeyWordEN objCMFunctionKeyWord_Cond = new clsCMFunctionKeyWordEN();
            string strCondition = objCMFunctionKeyWord_Cond
            .SetCmFunctionId(objCMFunctionKeyWord.CmFunctionId, "=")
            .SetKeyword(objCMFunctionKeyWord.Keyword, "=")
            .GetCombineCondition();
            objCMFunctionKeyWord._IsCheckProperty = true;
            bool bolIsExist = clsCMFunctionKeyWordBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objCMFunctionKeyWord.mId = clsCMFunctionKeyWordBL.GetFirstID_S(strCondition);
                objCMFunctionKeyWord.UpdateWithCondition(strCondition);
            }
            else
            {
                objCMFunctionKeyWord.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMFunctionKeyWordENS">源对象</param>
        /// <returns>目标对象=>clsCMFunctionKeyWordEN:objCMFunctionKeyWordENT</returns>
        public static clsCMFunctionKeyWordENEx CopyToEx(this clsCMFunctionKeyWordEN objCMFunctionKeyWordENS)
        {
            try
            {
                clsCMFunctionKeyWordENEx objCMFunctionKeyWordENT = new clsCMFunctionKeyWordENEx();
                clsCMFunctionKeyWordBL.CopyTo(objCMFunctionKeyWordENS, objCMFunctionKeyWordENT);
                return objCMFunctionKeyWordENT;
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
        /// <param name = "objCMFunctionKeyWordENS">源对象</param>
        /// <returns>目标对象=>clsCMFunctionKeyWordEN:objCMFunctionKeyWordENT</returns>
        public static clsCMFunctionKeyWordEN CopyTo(this clsCMFunctionKeyWordENEx objCMFunctionKeyWordENS)
        {
            try
            {
                clsCMFunctionKeyWordEN objCMFunctionKeyWordENT = new clsCMFunctionKeyWordEN();
                clsCMFunctionKeyWordBL.CopyTo(objCMFunctionKeyWordENS, objCMFunctionKeyWordENT);
                return objCMFunctionKeyWordENT;
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
    /// CM函数关键字(CMFunctionKeyWord)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMFunctionKeyWordBLEx : clsCMFunctionKeyWordBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMFunctionKeyWordDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMFunctionKeyWordDAEx CMFunctionKeyWordDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMFunctionKeyWordDAEx();
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
        public new static bool DelRecordEx(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
                //删除与表:[CMFunctionKeyWord]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conCMFunctionKeyWord.mId,
                //lngmId);
                //        clsCMFunctionKeyWordBL.DelCMFunctionKeyWordsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsCMFunctionKeyWordBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCMFunctionKeyWordBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
        public static List<clsCMFunctionKeyWordENEx> GetObjExLst(string strCondition)
        {
            List<clsCMFunctionKeyWordEN> arrObjLst = clsCMFunctionKeyWordBL.GetObjLst(strCondition);
            List<clsCMFunctionKeyWordENEx> arrObjExLst = new List<clsCMFunctionKeyWordENEx>();
            foreach (clsCMFunctionKeyWordEN objInFor in arrObjLst)
            {
                clsCMFunctionKeyWordENEx objCMFunctionKeyWordENEx = new clsCMFunctionKeyWordENEx();
                clsCMFunctionKeyWordBL.CopyTo(objInFor, objCMFunctionKeyWordENEx);
                arrObjExLst.Add(objCMFunctionKeyWordENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMFunctionKeyWordENEx GetObjExBymId(long lngmId)
        {
            clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = clsCMFunctionKeyWordBL.GetObjBymId(lngmId);
            clsCMFunctionKeyWordENEx objCMFunctionKeyWordENEx = new clsCMFunctionKeyWordENEx();
            clsCMFunctionKeyWordBL.CopyTo(objCMFunctionKeyWordEN, objCMFunctionKeyWordENEx);
            return objCMFunctionKeyWordENEx;
        }
        /// <summary>
        /// 编辑函数关键字
        /// </summary>
        /// <param name="strCmFunctionId">函数Id</param>
        /// <param name="strKeyWords_Old">原来的关键字列表</param>
        /// <param name="strKeyWords_New">新的关键字列表</param>
        /// <param name="strUserId">编辑的用户</param>
        /// <returns></returns>
        public static bool EditCMFunctionKeyWord(string strCmFunctionId, string strKeyWords_New, string strUserId)
        {
            string strCondition_Old = string.Format("{0}='{1}'", conCMFunctionKeyWord.CmFunctionId, strCmFunctionId);
            List<string> arrKeyWord_Old = clsCMFunctionKeyWordBL.GetFldValue(conCMFunctionKeyWord.Keyword, strCondition_Old);
            List<string> arrKeyWord_New = strKeyWords_New.Split(";".ToCharArray()).ToList();
            List<string> arrKeyWord_Delete = clsAggregate.TwoAggrDiff(arrKeyWord_Old, arrKeyWord_New);
            List<string> arrKeyWord_Add = clsAggregate.TwoAggrDiff(arrKeyWord_New, arrKeyWord_Old);
            if (arrKeyWord_Delete.Count > 0)
            {
                string strCondition_Del = string.Format("{0}='{1}' and {2} in ({3})", conCMFunctionKeyWord.CmFunctionId, strCmFunctionId, 
                    conCMFunctionKeyWord.Keyword, clsArray.GetSqlInStrByArray(arrKeyWord_Delete, true));
                clsCMFunctionKeyWordBL.DelCMFunctionKeyWordsByCond(strCondition_Del);
            }
            List<clsCMFunctionKeyWordEN> arrCMFunctionKeyWord = arrKeyWord_Add.Where(x=>x!="").Select(x=> new clsCMFunctionKeyWordEN() {
                CmFunctionId = strCmFunctionId,
                Keyword = x,
                UpdDate = clsDateTime.getTodayDateTimeStr(1),
                UpdUser = strUserId
            }
            ).ToList();
            arrCMFunctionKeyWord.ForEach(x=>x.AddNewRecord());
            return true;
        }
        public static void BindDdl_KeyWordEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId = "")
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选[关键字]...", "0");
            string strCondition = " 1=1 ";
            if (string.IsNullOrEmpty(strPrjId) == false)
            {
                strCondition = string.Format("{0} in (Select {0} From {1}='{3}' ) Order By {2}",
                    conCMFunctionKeyWord.CmFunctionId, convCMFunction._CurrTabName,
                    convCMFunction.PrjId, strPrjId,
                    conCMFunctionKeyWord.Keyword);
            }
            IEnumerable<string> arrKeyWord = clsCMFunctionKeyWordBL.GetFldValue(conCMFunctionKeyWord.Keyword, strCondition);


                IEnumerable<clsCboObject> arrObjLst = arrKeyWord.Select(x =>  new clsCboObject() { Text = x, Value = x } );

            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrObjLst;
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

            List<clsCMFunctionKeyWordEN> arrCMFunctionKeyWordENObjLst = clsCMFunctionKeyWordBL.GetObjLst(strCondition);

            foreach (clsCMFunctionKeyWordEN objCMFunctionKeyWordEN4Main in arrCMFunctionKeyWordENObjLst)
            {
                //如果这条记录的来源就是Client,就不需要同步了
                if (objCMFunctionKeyWordEN4Main.SynSource == "Client") continue;
                objCMFunctionKeyWordEN4Main.IsSynchToClient = true;
                objCMFunctionKeyWordEN4Main.SynchToClientDate = strCurrDate14;
                objCMFunctionKeyWordEN4Main.SynchToClientUser = strOpUserId;
                clsSysParaEN.strConnectStrName = "ConnectionStringClient";

                try
                {
                    clsCMFunctionKeyWordEN objCMFunctionKeyWordEN4Main2 = new clsCMFunctionKeyWordEN();
                    clsCMFunctionKeyWordBL.CopyTo(objCMFunctionKeyWordEN4Main, objCMFunctionKeyWordEN4Main2);
                    objCMFunctionKeyWordEN4Main2.SynSource = "Server";
                    strCondition = objCMFunctionKeyWordEN4Main.GetUniCondStr();
                    clsCMFunctionKeyWordEN objCMFunctionKeyWord_Target = clsCMFunctionKeyWordBL.GetFirstObj_S(strCondition);

                    if (objCMFunctionKeyWord_Target != null)
                    {
                        //如果目标地的对象日期小于来源对象的日期就更新
                        int intResult = objCMFunctionKeyWord_Target.UpdDate.CompareTo(objCMFunctionKeyWordEN4Main.UpdDate);
                        if (intResult < 0)
                        {

                            objCMFunctionKeyWordEN4Main2.UpdateWithCondition(strCondition);
                            intCount++;
                        }
                    }
                    else
                    {
                        //string strPrjId = clsCMProjectBLEx.GetObjByCmPrjIdCache(objCMFunctionKeyWordEN4Main2.CmPrjId).PrjId;
                        //objCMFunctionKeyWordEN4Main2.CMFunctionKeyWordId = clsCMFunctionKeyWordBL.GetMaxStrIdByPrefix_S(strPrjId);
                        objCMFunctionKeyWordEN4Main2.AddRecordEx();
                        intCount++;
                    }

                    clsSysParaEN.strConnectStrName = "ConnectionString";
                    objCMFunctionKeyWordEN4Main.UpdateRecordEx();
                }
                catch (Exception objException)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("在同步到Client库，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]", objCMFunctionKeyWordEN4Main.mId,
                                objCMFunctionKeyWordEN4Main.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
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

            List<clsCMFunctionKeyWordEN> arrCMFunctionKeyWordENObjLst = clsCMFunctionKeyWordBL.GetObjLst(strCondition);

            foreach (clsCMFunctionKeyWordEN objCMFunctionKeyWordEN4Web in arrCMFunctionKeyWordENObjLst)
            {
                //如果这条记录的来源就是Server,就不需要同步了
                if (objCMFunctionKeyWordEN4Web.SynSource == "Server") continue;
                objCMFunctionKeyWordEN4Web.IsSynchToServer = true;
                objCMFunctionKeyWordEN4Web.SynchToServerDate = strCurrDate14;
                objCMFunctionKeyWordEN4Web.SynchToServerUser = strOpUserId;
                clsSysParaEN.strConnectStrName = "ConnectionString";

                objCMFunctionKeyWordEN4Web.SynSource = "Client";
                try
                {
                    strCondition = objCMFunctionKeyWordEN4Web.GetUniCondStr();
                    clsCMFunctionKeyWordEN objCMFunctionKeyWord_Target = clsCMFunctionKeyWordBL.GetFirstObj_S(strCondition);
                    if (objCMFunctionKeyWord_Target != null)
                    {
                        int intResult = (objCMFunctionKeyWord_Target.UpdDate.CompareTo(objCMFunctionKeyWordEN4Web.UpdDate));
                        if (intResult < 0)
                        {
                            objCMFunctionKeyWordEN4Web.UpdateWithCondition(strCondition);
                        }
                    }
                    else
                    {
                        //string strPrjId = clsCMProjectBLEx.GetObjByCmPrjIdCache(objCMFunctionKeyWordEN4Web.CmPrjId).PrjId;
                        //objCMFunctionKeyWordEN4Web.CMFunctionKeyWordId = clsCMFunctionKeyWordBL.GetMaxStrIdByPrefix_S(strPrjId);
                        objCMFunctionKeyWordEN4Web.AddRecordEx();
                    }

                    clsSysParaEN.strConnectStrName = "ConnectionStringClient";
                    objCMFunctionKeyWordEN4Web.UpdateRecordEx();
                }
                catch (Exception objException)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("在同步到Server端时，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]",
                                clsCMFunctionKeyWordEN._CurrTabName,
                                objCMFunctionKeyWordEN4Web.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(sbMsg.ToString());
                }
            }
            clsSysParaEN.strConnectStrName = "ConnectionString";
            return intCount;
        }
    }
}