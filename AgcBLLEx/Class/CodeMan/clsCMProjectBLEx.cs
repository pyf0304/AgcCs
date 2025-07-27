
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMProjectBLEx
表名:CMProject(00050512)
生成代码版本:2019.10.24.1
生成日期:2019/11/07 13:13:21
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
    public static class clsCMProjectBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMProjectENS">源对象</param>
        /// <returns>目标对象=>clsCMProjectEN:objCMProjectENT</returns>
        public static clsCMProjectENEx CopyToEx(this clsCMProjectEN objCMProjectENS)
        {
            try
            {
                clsCMProjectENEx objCMProjectENT = new clsCMProjectENEx();
                clsCMProjectBL.CopyTo(objCMProjectENS, objCMProjectENT);
                return objCMProjectENT;
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
        /// <param name = "objCMProjectENS">源对象</param>
        /// <returns>目标对象=>clsCMProjectEN:objCMProjectENT</returns>
        public static clsCMProjectEN CopyTo(this clsCMProjectENEx objCMProjectENS)
        {
            try
            {
                clsCMProjectEN objCMProjectENT = new clsCMProjectEN();
                clsCMProjectBL.CopyTo(objCMProjectENS, objCMProjectENT);
                return objCMProjectENT;
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
    /// CM项目(CMProject)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMProjectBLEx : clsCMProjectBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMProjectDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMProjectDAEx CMProjectDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMProjectDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strCmPrjId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strCmPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsCMProjectDA.GetSpecSQLObj();
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
                //删除与表:[CMProject]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conCMProject.CmPrjId,
                //strCmPrjId);
                //        clsCMProjectBL.DelCMProjectsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsCMProjectBL.DelRecord(strCmPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCMProjectBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strCmPrjId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clsCMProjectENEx> GetObjExLst(string strCondition)
        {
            List<clsCMProjectEN> arrObjLst = clsCMProjectBL.GetObjLst(strCondition);
            List<clsCMProjectENEx> arrObjExLst = new List<clsCMProjectENEx>();
            foreach (clsCMProjectEN objInFor in arrObjLst)
            {
                clsCMProjectENEx objCMProjectENEx = new clsCMProjectENEx();
                clsCMProjectBL.CopyTo(objInFor, objCMProjectENEx);
                arrObjExLst.Add(objCMProjectENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCmPrjId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMProjectENEx GetObjExByCmPrjId(string strCmPrjId)
        {
            clsCMProjectEN objCMProjectEN = clsCMProjectBL.GetObjByCmPrjId(strCmPrjId);
            clsCMProjectENEx objCMProjectENEx = new clsCMProjectENEx();
            clsCMProjectBL.CopyTo(objCMProjectEN, objCMProjectENEx);
            return objCMProjectENEx;
        }
        public static string GetPrjIdByCmPrjIdCache(string strCmPrjId)
        {
            clsCMProjectEN objCMProjectEN = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            return objCMProjectEN.PrjId;
        }
        /// <summary>
        /// 同步满足条件的学生信息到Web
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //public static int SynchToServerByCondition(string strCondition, string strUserId)
        //{
        //    //string strCondition = string.Format("id_CurrEduClass='{0}'", strId_TransferCourses);
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
        //    clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //    List<clsCMProjectEN> arrCMProjectENObjLst = clsCMProjectBL.GetObjLst(strCondition);
        //    foreach (clsCMProjectEN objCMProjectEN4Web in arrCMProjectENObjLst)
        //    {

        //        objCMProjectEN4Web.IsSynchToServer = true;
        //        objCMProjectEN4Web.SynchToServerDate = strCurrDate14;
        //        objCMProjectEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsCMProjectEN objCMProjectEN4Web2 = new clsCMProjectEN();
        //            clsCMProjectBL.CopyTo(objCMProjectEN4Web, objCMProjectEN4Web2);
        //            objCMProjectEN4Web2.SynSource = "Client";

        //            strCondition = objCMProjectEN4Web.GetUniquenessConditionString();

        //            clsCMProjectEN objCMProject_Target = clsCMProjectBL.GetFirstObj_S(strCondition);

        //            if (objCMProject_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objCMProject_Target.UpdDate.CompareTo(objCMProjectEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {
        //                    objCMProjectEN4Web2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                //if (clsFieldTabBL.IsExist(objCMProjectEN4Web2.ReqId) == false)
        //                //{
        //                //    clsFieldTabBLEx.SynchToServerByReqId(objCMProjectEN4Web2.ReqId, strUserId);
        //                //}
        //                clsCMProjectBL.AddNewRecordBySql2(objCMProjectEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsCMProjectBL.UpdateBySql2(objCMProjectEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，CM工程表字段：{0}({1})时出错。({3}).[上级抛错:{2}]", objCMProjectEN4Web.CmPrjId,
        //                        objCMProjectEN4Web.CmPrjName, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        /// <summary>
        /// 同步满足条件的学生信息到Web
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //public static int SynchToClientByCondition(string strCondition, string strUserId)
        //{
        //    //string strCondition = string.Format("id_CurrEduClass='{0}'", strId_TransferCourses);
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    List<clsCMProjectEN> arrCMProjectENObjLst = clsCMProjectBL.GetObjLst(strCondition);

        //    foreach (clsCMProjectEN objCMProjectEN4Main in arrCMProjectENObjLst)
        //    {

        //        objCMProjectEN4Main.IsSynchToClient = true;
        //        objCMProjectEN4Main.SynchToClientDate = strCurrDate14;
        //        objCMProjectEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";

        //        try
        //        {
        //            clsCMProjectEN objCMProjectEN4Main2 = new clsCMProjectEN();
        //            clsCMProjectBL.CopyTo(objCMProjectEN4Main, objCMProjectEN4Main2);
        //            objCMProjectEN4Main2.SynSource = "Server";

        //            strCondition = objCMProjectEN4Main.GetUniquenessConditionString();
        //            clsCMProjectEN objCMProject_Target = clsCMProjectBL.GetFirstObj_S(strCondition);

        //            if (objCMProject_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objCMProject_Target.UpdDate.CompareTo(objCMProjectEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {
        //                    objCMProjectEN4Main2.SetCmPrjId(objCMProject_Target.CmPrjId);   
        //                    objCMProjectEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                //if (clsFieldTabBL.IsExist(objCMProjectEN4Main2.ReqId) == false)
        //                //{
        //                //    clsFieldTabBLEx.SynchToClientByReqId(objCMProjectEN4Main2.ReqId, strUserId);
        //                //}
        //                clsCMProjectBL.AddNewRecordBySql2(objCMProjectEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsCMProjectBL.UpdateBySql2(objCMProjectEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表字段：{0}({1})时出错。({3}).[上级抛错:{2}]", objCMProjectEN4Main.CmPrjId,
        //                        objCMProjectEN4Main.CmPrjName, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">工程ID</param>
        public static void BindDdl_CmPrjIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM项目]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conCMProject.CmPrjId);
            IEnumerable<clsCMProjectEN> arrObjLst = clsCMProjectBL.GetObjLstCache();// strCondition);

            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conCMProject.CmPrjId;
            objDDL.DataTextField = conCMProject.CmPrjName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        //public static List<clsCMProjectEN> GetObjLstCache(string strPrjId)
        //{
        //    //初始化列表缓存
        //    InitListCache(strPrjId);
        //    return arrCMProjectObjLstCache;
        //}
        public static void BindDdl_PrjIdCacheEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            List<clsProjectsEN> arrProjectsObjLst = clsProjectsBL.GetObjLstCache();//正在使用中的工程对象
            IEnumerable<clsCMProjectEN> arrObjLst = clsCMProjectBL.GetObjLstCache();// strCondition);
            List<string> arrPrjId = arrObjLst.Select(x=>x.PrjId).ToList();
            arrProjectsObjLst = arrProjectsObjLst.Where(x=> arrPrjId.Contains( x.PrjId)).ToList();
            objDDL.DataValueField = conProjects.PrjId;
            objDDL.DataTextField = conProjects.PrjName;
            objDDL.DataSource = arrProjectsObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}