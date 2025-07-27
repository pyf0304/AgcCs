
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUsersBLEx
表名:Users
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC_CSV7
工程ID:0005
模块中文名:用户管理
模块英文名:UserManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
using GeneralPlatform.Entity;



namespace AGC.BusinessLogicEx
{

    public static class clsUsersBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objUsersENS">源对象</param>
        /// <returns>目标对象=>clsUsersEN:objUsersENT</returns>
        public static clsUsersENEx CopyToEx(this clsUsersEN objUsersENS)
        {
            try
            {
                clsUsersENEx objUsersENT = new clsUsersENEx();
                clsUsersBL.CopyTo(objUsersENS, objUsersENT);
                return objUsersENT;
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
        /// <param name = "objUsersENS">源对象</param>
        /// <returns>目标对象=>clsUsersEN:objUsersENT</returns>
        public static clsUsersEN CopyTo(this clsUsersENEx objUsersENS)
        {
            try
            {
                clsUsersEN objUsersENT = new clsUsersEN();
                clsUsersBL.CopyTo(objUsersENS, objUsersENT);
                return objUsersENT;
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
    /// 用于用户管理(Users)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsUsersBLEx : clsUsersBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsUsersDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsUsersDAEx UsersDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsUsersDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strUserId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strUserId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUsersDA.GetSpecSQLObj();
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
                //删除与表:[Users]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'",
                conUserPrjGrant.UserId,
                strUserId);
                clsUserPrjGrantBL.DelUserPrjGrantsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);

                string strCondition_UserMenus = string.Format("{0} = '{1}'",
                conUserMenus.UserId,
                strUserId);
                clsUserMenusBL.DelUserMenussByCondWithTransaction_S(strCondition_UserMenus, objConnection, objSqlTransaction);

                string strCondition_UserDefaValue_Local = string.Format("{0} = '{1}'",
                conUserDefaValue_Local.UserId,
                strUserId);
                clsUserDefaValue_LocalBL.DelUserDefaValue_LocalsByCondWithTransaction_S(strCondition_UserDefaValue_Local, objConnection, objSqlTransaction);
                               
                clsUsersBL.DelRecord(strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsUsersBLEx", "DelRecordEx", objException.Message, Entity.clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strUserId, clsStackTrace.GetCurrClassFunction());
                Entity.clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
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
        public static List<clsUsersENEx> GetObjExLst(string strCondition)
        {
            List<clsUsersEN> arrObjLst = clsUsersBL.GetObjLst(strCondition);
            List<clsUsersENEx> arrObjExLst = new List<clsUsersENEx>();
            foreach (clsUsersEN objInFor in arrObjLst)
            {
                clsUsersENEx objUsersENEx = new clsUsersENEx();
                clsUsersBL.CopyTo(objInFor, objUsersENEx);
                arrObjExLst.Add(objUsersENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strUserId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsUsersENEx GetObjExByUserId(string strUserId)
        {
            clsUsersEN objUsersEN = clsUsersBL.GetObjByUserId(strUserId);
            clsUsersENEx objUsersENEx = new clsUsersENEx();
            clsUsersBL.CopyTo(objUsersEN, objUsersENEx);
            return objUsersENEx;
        }
   

        private ArrayList arrUsersPotence = new ArrayList();




        public static bool DelRecordExBak(string strUserId)
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //删除Users本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from UserGroupPotence where UserId=" + "'" + strUserId + "'";
            strSQL = strSQL + "; Delete from UserDefaValue where UserId=" + "'" + strUserId + "'";
            strSQL = strSQL + "; Delete from UserMenuDetail where UserId=" + "'" + strUserId + "'";
            strSQL = strSQL + "; Delete from UserMenus where UserId=" + "'" + strUserId + "'";
            strSQL = strSQL + "; Delete from UserPrjGrant where UserId=" + "'" + strUserId + "'";
            strSQL = strSQL + "; Delete from Users where UserId=" + "'" + strUserId + "'";
            return objSQL.ExecSql(strSQL);
        }

        /// <summary>
        /// 通过ArrayList获取用户的个人权限以及此人所在组的所有权限
        /// </summary>
        /// <returns></returns>
        public ArrayList GetUsersPotenceByArrayList(string strUserId)
        {
            string uid = strUserId;
            string prjid = System.Configuration.ConfigurationManager.AppSettings["PrjId"];
            StringBuilder wherecon = new StringBuilder();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            wherecon.Append("Select PotenceId from UserGroupPotence where ");
            wherecon.AppendFormat("UserId = " + "'{0}'" + " and PrjId = " + "'{1}'", uid, prjid);
            wherecon.Append(" union ");
            wherecon.Append("select potenceid  from usergrouppotence where groupid in ");
            wherecon.Append("(select groupid  from usergrouprelation where userid =");
            wherecon.AppendFormat("'{0}'" + " and prjid= " + "'{1}'" + ")", uid, prjid);
            string SQL = wherecon.ToString().Trim();
            objDT = objSQL.GetDataTable(SQL);

            foreach (DataRow row in objDT.Rows)
            {
                string PotenceId = row[0].ToString().Trim();
                arrUsersPotence.Add(PotenceId);

            }

            return arrUsersPotence;
        }


        public System.Data.DataTable UserLogin(string uid, string pwd)
        {

            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select DepartmentId,Memo,RoleName from Users where UserId='" + uid + "' and PassWord='" + pwd + "'";
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public static string GetUserName(string uid)
        {

            string strSQL, UsersXM;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select UserName from Users where UserId='" + uid + "' ";
            objDT = objSQL.GetDataTable(strSQL);
            UsersXM = objDT.Rows[0][0].ToString().Trim();
            return UsersXM;
        }

        public static string GetUserId(string uname)
        {

            string strSQL, UsersId;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select UserId from Users where UserName='" + uname + "' ";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count > 0)
            {
                UsersId = objDT.Rows[0][0].ToString().Trim();
            }
            else
            {
                UsersId = "";
            }
            return UsersId;
        }

        public static int SynchUsersToStudentAndPlatform(List<string> arrUserIdLst, string strSchoolId, string strOpUserId)
        {
            int intCount = 0;
            string strCurrDate = clsDateTime.getTodayStr(0);
            string strCondition = string.Format("{0} in ({1})", conUsers.UserId, clsArray.GetSqlInStrByArray(arrUserIdLst, true));
            List<clsUsersEN> arrUserObjLst = clsUsersBL.GetObjLst(strCondition);
            foreach (clsUsersEN objUsersEN in arrUserObjLst)
            {

                if (objUsersEN.IsAudit == true)
                {
                    continue;
                    //objUsersEN.UserId = strUserId;

                    //objUsersEN.IsAudit = false;
                    //clsUsersBL.UpdateBySql2(objUsersEN);
                }
                else
                {
                    clsUserIdentityEN objUserIdentityEN = clsUserIdentityBL.GetObjByIdentityIDCache(objUsersEN.IdentityID);
                    switch (objUserIdentityEN.IdentityDesc)
                    {
                        case "学生":
                        case "教师":
                            SynchUsersToPlatform(objUsersEN.UserId, strSchoolId, strOpUserId);
                            intCount++;
                            break;
                        //clsTeacherInfoBLEx.SynchTeacherToPlatform(objTeacherInfoEN.id_Teacher, strSchoolId, strOpUserId);
                        default:
                            SynchUsersToPlatform(objUsersEN.UserId, strSchoolId, strOpUserId);
                            intCount++;
                            break;
                    }
                    objUsersEN.IsAudit = true;
                    objUsersEN.AuditDate = strCurrDate;
                    objUsersEN.AuditUser = strOpUserId;
                    clsUsersBL.UpdateBySql2(objUsersEN);

                }

            }
            return intCount;
        }
        /// <summary>
        /// 同步学生对象到用户权限统一平台
        /// </summary>
        /// <param name="strId_Users">学生流水号</param>
        /// <param name="strSchoolId">学校Id</param>
        /// <param name="strOpUserId">操作用户Id</param>
        /// <returns>是否成功?</returns>
        public static bool SynchUsersToPlatform(string strId_Users, string strSchoolId, string strOpUserId)
        {
            //string strCondition = string.Format("{0}='{1}' And {2}='学生' order by {3}",
            // convPlatDefaRole.SchoolId, strSchoolId,
            // convPlatDefaRole.PersonType,
            // convPlatDefaRole.QxPrjId);
            //List<clsvPlatDefaRoleEN> arrvPlatDefaRoleobjLst = clsvPlatDefaRoleBL.GetObjLst(strCondition);

            //List<string> arrPrjIdLst = new List<string>();
            //foreach (clsvPlatDefaRoleEN objvPlatDefaRoleEN in arrvPlatDefaRoleobjLst)
            //{
            //    if (arrPrjIdLst.Contains(objvPlatDefaRoleEN.QxPrjId) == false)
            //    {
            //        arrPrjIdLst.Add(objvPlatDefaRoleEN.QxPrjId);
            //    }
            //}
            //if (arrPrjIdLst.Count == 0)
            //{
            //    //clsRsStaffTypeEN objStaffTypeEN = clsRsStaffTypeBL.GetStaffTypeObjByid_StaffTypeCache(qsid_StaffType);
            //    string strMsg = string.Format("没有为[学生]在统一平台中设置相应的角色，请联系管理员!");
            //    throw new Exception(strMsg);
            //}

            //string strCurrDate = clsDateTime_Db.GetDataBaseDate8();
            //clsvUsersEN objUsers = clsvUsersBL.GetObjByUserId(strId_Users);
            //if (string.IsNullOrEmpty(objUsers.DepartmentId) == true)
            //{
            //    string strMsg = string.Format("该用户：{0}({1})没有相关学院部门，请设置学院部门再同步到统一平台！",
            //        objUsers.UserName, objUsers.UserId);
            //    throw new Exception(strMsg);
            //}

            //clsQxUsersEN objUsersEN = new clsQxUsersEN();
            //objUsersEN.UserId = objUsers.UserId;
            //objUsersEN.UserName = objUsers.UserName;
            //objUsersEN.UserStateId = "01";
            ////objUsersEN.IdentityID = "04";
            //if (string.IsNullOrEmpty(objUsers.DepartmentId) == true)
            //{
            //    objUsersEN.DepartmentId = "000000";
            //}
            //else
            //{
            //    try
            //    {
            //        string strDepartmentIdInGP = clsDepartmentInfoBLEx.GetDepartmentIdInGPByLocalId(objUsers.DepartmentId);
            //        if (string.IsNullOrEmpty(strDepartmentIdInGP) == true)
            //        {
            //            objUsersEN.DepartmentId = "000000";
            //        }
            //        else
            //        {
            //            objUsersEN.DepartmentId = strDepartmentIdInGP;
            //        }
            //    }
            //    catch (Exception objException)
            //    {
            //        throw objException;
            //    }
            //}
            //objUsersEN.StuTeacherId = objUsers.UserId;
            //if (string.IsNullOrEmpty(objUsers.RegisterPassword) == true)
            //{
            //    objUsersEN.Password = "111111";
            //}
            //else
            //{
            //    objUsersEN.Password = objUsers.RegisterPassword;
            //}
            //objUsersEN.UpdDate = strCurrDate;
            //objUsersEN.UpdUser = strOpUserId;
            //objUsersEN.Memo = "由教育高地导入到统一平台:" + strCurrDate;

            //foreach (string strPrjId in arrPrjIdLst)
            //{
            //    bool bolIsFirst = true;
            //    foreach (clsvPlatDefaRoleEN objvPlatDefaRoleEN in arrvPlatDefaRoleobjLst)
            //    {
            //        if (objvPlatDefaRoleEN.QxPrjId != strPrjId) continue;
            //        if (bolIsFirst == true)
            //        {
            //            clsQxUsersExWApi.AddNewUsers(objUsersEN, strPrjId, objvPlatDefaRoleEN.RoleId);
            //            bolIsFirst = false;
            //        }
            //        else
            //        {
            //            clsQxUsersExWApi.AddUserRoleRelation(objUsersEN.UserId, objvPlatDefaRoleEN.RoleId);
            //        }
            //    }
            //}

            ////GeneralPlatform4WS.clsQxUsersExWS.AddNewUsers(objUsersEN, "0062", "00620003");
            ////GeneralPlatform4WS.clsQxUsersExWS.AddUserRoleRelation(objUsersEN.UserId, "00620005");
            //clsUsersEN objUsers1 = clsUsersBL.GetObjByUserId(strId_Users);
            //objUsers1.IsGpUser = true;
            //clsUsersBL.UpdateBySql2(objUsers1);

            ////objUsers4Plat.UserId = objUsers4Local.UserId;

            ////objUsers4Plat.UserName = objUsers4Local.UserName;

            ////objUsers4Plat.UserStateId = objUsers4Local.UserStateId;
            ////if (string.IsNullOrEmpty(objUsers4Local.DepartmentId) == true)
            ////{
            ////    objUsers4Plat.DepartmentId = "000000";
            ////}
            ////else
            ////{
            ////    string strDepartmentIdInGP = clsDepartmentInfoBLEx.GetDepartmentIdInGPByLocalId(objUsers4Local.DepartmentId);
            ////    if (string.IsNullOrEmpty(strDepartmentIdInGP) == true)
            ////    {
            ////        objUsers4Plat.DepartmentId = "000000";
            ////    }
            ////    else
            ////    {
            ////        objUsers4Plat.DepartmentId = strDepartmentIdInGP;
            ////    }
            ////}
            ////objUsers4Plat.IdentityID = objUsers4Local.IdentityID; ;

            ////objUsers4Plat.StuIdTeacherId = objUsers4Local.StuIdTeacherId;

            ////objUsers4Plat.Password = objUsers4Local.Password;

            ////objUsers4Plat.Memo = "由任务管理系统导入到统一平台:" + strCurrDate;

            ////GeneralPlatform4WS.clsQxUsersExWS.AddNewUsers(objUsers4Plat, "0101", "01010009");
            ////objUsers4Local.Memo = "已经同步到统一平台：" + strCurrDate;
            ////objUsers4Local.IsGpUser = true;
            ////clsUsersBL.UpdateBySql2(objUsers4Local);
            return true;
        }

    }
}