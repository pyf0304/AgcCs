
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMRequirementBLEx
表名:CMRequirement(00050075)
生成代码版本:2019.11.08.1
生成日期:2019/11/11 23:54:37
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
    public static class clsCMRequirementBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMRequirementENS">源对象</param>
        /// <returns>目标对象=>clsCMRequirementEN:objCMRequirementENT</returns>
        public static clsCMRequirementENEx CopyToEx(this clsCMRequirementEN objCMRequirementENS)
        {
            try
            {
                clsCMRequirementENEx objCMRequirementENT = new clsCMRequirementENEx();
                clsCMRequirementBL.CopyTo(objCMRequirementENS, objCMRequirementENT);
                return objCMRequirementENT;
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
        /// <param name = "objCMRequirementENS">源对象</param>
        /// <returns>目标对象=>clsCMRequirementEN:objCMRequirementENT</returns>
        public static clsCMRequirementEN CopyTo(this clsCMRequirementENEx objCMRequirementENS)
        {
            try
            {
                clsCMRequirementEN objCMRequirementENT = new clsCMRequirementEN();
                clsCMRequirementBL.CopyTo(objCMRequirementENS, objCMRequirementENT);
                return objCMRequirementENT;
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
    /// 项目需求(CMRequirement)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMRequirementBLEx : clsCMRequirementBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMRequirementDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMRequirementDAEx CMRequirementDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMRequirementDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strReqId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strReqId, string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
                //删除与表:[CMRequirement]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'",
                        conCMRequirement.UpReqId,
                        strReqId);
                clsCMRequirementBL.DelCMRequirementsByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);

                clsCMRequirementBL.DelRecord(strReqId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCMRequirementBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strReqId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clsCMRequirementENEx> GetObjExLst(string strCondition)
        {
            List<clsCMRequirementEN> arrObjLst = clsCMRequirementBL.GetObjLst(strCondition);
            List<clsCMRequirementENEx> arrObjExLst = new List<clsCMRequirementENEx>();
            foreach (clsCMRequirementEN objInFor in arrObjLst)
            {
                clsCMRequirementENEx objCMRequirementENEx = new clsCMRequirementENEx();
                clsCMRequirementBL.CopyTo(objInFor, objCMRequirementENEx);
                arrObjExLst.Add(objCMRequirementENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strReqId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMRequirementENEx GetObjExByReqId(string strReqId)
        {
            clsCMRequirementEN objCMRequirementEN = clsCMRequirementBL.GetObjByReqId(strReqId);
            clsCMRequirementENEx objCMRequirementENEx = new clsCMRequirementENEx();
            clsCMRequirementBL.CopyTo(objCMRequirementEN, objCMRequirementENEx);
            return objCMRequirementENEx;
        }

        public static void BindDdl_PrjIdEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工程]...", "0");
            string strCondition = string.Format("{0} in (Select {0} From {1} ) Order By {2}",
                conProjects.PrjId, convCMRequirement._CurrTabName,
                conProjects.PrjName);

            IEnumerable<clsProjectsEN> arrObjLst = clsProjectsBL.GetObjLst(strCondition)
                .Where(x=>x.UseStateId == enumUseState.InUse_0001)
                .OrderBy(x=>x.PrjName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conProjects.PrjId;
            objDDL.DataTextField = conProjects.PrjName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        public static void BindDdl_UserIdEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[用户]...", "0");
            string strCondition = string.Format("{0} in (Select {1} From {2} ) Order By {3}",
                conUsers.UserId, convCMRequirement.UpdUser, convCMRequirement._CurrTabName,
                conUsers.UserName);
            IEnumerable<clsUsersEN> arrObjLst = clsUsersBL.GetObjLst(strCondition);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conUsers.UserId;
            objDDL.DataTextField = conUsers.UserName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="strReqId">strReqId</param>
        /// <param name="strUserId">strUserId</param>
        /// <returns></returns>
        public static clsCMRequirementEN CloneRecord(string strReqId, string strUserId)
        {
            clsCMRequirementEN objCMRequirementEN = clsCMRequirementBL.GetObjByReqId(strReqId);
            objCMRequirementEN.ReqId = clsCMRequirementBL.GetMaxStrIdByPrefix_S(objCMRequirementEN.PrjId);
            objCMRequirementEN.RequirementName = "Copy_" + objCMRequirementEN.RequirementName;
            //if (string.IsNullOrEmpty(objCMRequirementEN.ReturnTypeId))
            //{
            //    objCMRequirementEN.ReturnTypeId = "29";
            //}
            objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objCMRequirementEN.UpdUser = strUserId;

            try
            {
                clsCMRequirementBL.AddNewRecordBySql2(objCMRequirementEN);
           
                return objCMRequirementEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(strFuncId4GC:{1})({2})",
                    objException.Message,
                    strReqId,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

    }
}