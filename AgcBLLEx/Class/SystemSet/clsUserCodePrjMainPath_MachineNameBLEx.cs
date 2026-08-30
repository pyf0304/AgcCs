
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUserCodePrjMainPath_MachineNameBLEx
表名:UserCodePrjMainPath_MachineName(00050614)
生成代码版本:2022.11.24.1
生成日期:2022/12/03 17:47:59
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统设置(SystemSet)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

using com.taishsoft.comm_db_obj;
using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using com.taishsoft.commdb;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_UserCodePrjMainPath_MachineNameEx : RelatedActions_UserCodePrjMainPath_MachineName
    {
        public override bool UpdRelaTabDate(string strUserCodePrjMainPathId, string strMachineName, string strOpUser)
        {
            return true;
        }
    }
    public static class clsUserCodePrjMainPath_MachineNameBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objUserCodePrjMainPath_MachineNameENS">源对象</param>
        /// <returns>目标对象=>clsUserCodePrjMainPath_MachineNameEN:objUserCodePrjMainPath_MachineNameENT</returns>
        public static clsUserCodePrjMainPath_MachineNameENEx CopyToEx(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENS)
        {
            try
            {
                clsUserCodePrjMainPath_MachineNameENEx objUserCodePrjMainPath_MachineNameENT = new clsUserCodePrjMainPath_MachineNameENEx();
                clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.CopyTo(objUserCodePrjMainPath_MachineNameENS, objUserCodePrjMainPath_MachineNameENT);
                return objUserCodePrjMainPath_MachineNameENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objUserCodePrjMainPath_MachineNameENS">源对象</param>
        /// <returns>目标对象=>clsUserCodePrjMainPath_MachineNameEN:objUserCodePrjMainPath_MachineNameENT</returns>
        public static clsUserCodePrjMainPath_MachineNameEN CopyTo(this clsUserCodePrjMainPath_MachineNameENEx objUserCodePrjMainPath_MachineNameENS)
        {
            try
            {
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENT = new clsUserCodePrjMainPath_MachineNameEN();
                clsUserCodePrjMainPath_MachineNameBL.CopyTo(objUserCodePrjMainPath_MachineNameENS, objUserCodePrjMainPath_MachineNameENT);
                return objUserCodePrjMainPath_MachineNameENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 用户生成项目主路径_PC(UserCodePrjMainPath_MachineName)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsUserCodePrjMainPath_MachineNameBLEx : clsUserCodePrjMainPath_MachineNameBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsUserCodePrjMainPath_MachineNameDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsUserCodePrjMainPath_MachineNameDAEx UserCodePrjMainPath_MachineNameDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsUserCodePrjMainPath_MachineNameDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objUserCodePrjMainPath_MachineNameENS">源对象</param>
        /// <returns>目标对象=>clsUserCodePrjMainPath_MachineNameEN:objUserCodePrjMainPath_MachineNameENT</returns>
        public static clsUserCodePrjMainPath_MachineNameENEx CopyToEx(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENS)
        {
            try
            {
                clsUserCodePrjMainPath_MachineNameENEx objUserCodePrjMainPath_MachineNameENT = new clsUserCodePrjMainPath_MachineNameENEx();
                clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.CopyTo(objUserCodePrjMainPath_MachineNameENS, objUserCodePrjMainPath_MachineNameENT);
                return objUserCodePrjMainPath_MachineNameENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsUserCodePrjMainPath_MachineNameENEx> GetObjExLst(string strCondition)
        {
            List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = clsUserCodePrjMainPath_MachineNameBL.GetObjLst(strCondition);
            List<clsUserCodePrjMainPath_MachineNameENEx> arrObjExLst = new List<clsUserCodePrjMainPath_MachineNameENEx>();
            foreach (clsUserCodePrjMainPath_MachineNameEN objInFor in arrObjLst)
            {
                clsUserCodePrjMainPath_MachineNameENEx objUserCodePrjMainPath_MachineNameENEx = new clsUserCodePrjMainPath_MachineNameENEx();
                clsUserCodePrjMainPath_MachineNameBL.CopyTo(objInFor, objUserCodePrjMainPath_MachineNameENEx);
                arrObjExLst.Add(objUserCodePrjMainPath_MachineNameENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strUserCodePrjMainPathId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsUserCodePrjMainPath_MachineNameENEx GetObjExByUserCodePrjMainPathId(string strUserCodePrjMainPathId, string strMachineName)
        {
            clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(strUserCodePrjMainPathId, strMachineName);
            clsUserCodePrjMainPath_MachineNameENEx objUserCodePrjMainPath_MachineNameENEx = new clsUserCodePrjMainPath_MachineNameENEx();
            clsUserCodePrjMainPath_MachineNameBL.CopyTo(objUserCodePrjMainPath_MachineNameEN, objUserCodePrjMainPath_MachineNameENEx);
            return objUserCodePrjMainPath_MachineNameENEx;
        }

        public static string GetRelaMachineName(string userCodePrjMainPathId)
        {
            string strCondition = string.Format("{0}='{1}'", conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, userCodePrjMainPathId);
            var arrUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameBL.GetObjLst(strCondition);
            if (arrUserCodePrjMainPath_MachineName == null || arrUserCodePrjMainPath_MachineName.Count == 0) return "";
            arrUserCodePrjMainPath_MachineName = arrUserCodePrjMainPath_MachineName.OrderByDescending(x => x.UpdDate).ToList();
            var arrMachineName = arrUserCodePrjMainPath_MachineName.Select(x => x.MachineName).ToList();
            return arrMachineName[0];
        }
        //public static string GetUserGCRootPath(string strUserId, string strMachineName, string strPrjId, string strCmPrjId, int intApplicationTypeId)
        /// <summary>
        /// 根据用户ID、机器名、项目ID、CM工程ID和应用类型ID获取用户生成代码根路径
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strMachineName">机器名称</param>
        /// <param name="strPrjId">项目ID</param>
        /// <param name="strCmPrjId">CM工程ID</param>
        /// <param name="intApplicationTypeId">应用类型ID</param>
        /// <returns>用户生成代码根路径</returns>
        public static string GetUserGCRootPath(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId)
        {
            try
            {
                // 1. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 2. 获取用户代码项目主路径对象
                clsUserCodePrjMainPathEN objUserCodePrjMainPath =
                    clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);

                if (objUserCodePrjMainPath == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}的用户:{2}在项目:{3}的代码主路径配置，请先配置UserCodePrjMainPath表！(from {4})",
                        strCmPrjName, strAppName, strUserId, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 3. 获取特定机器的代码路径
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}在机器:{2}上的代码路径配置，请先配置UserCodePrjMainPath_MachineName表！(from {3})",
                        strCmPrjName, strAppName, strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 4. 验证代码路径是否为空
                if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineName.CodePath))
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "CM工程:{0}(ID:{1})的应用:{2}(ID:{3})在机器:{4}中生成代码路径为空，请检查UserCodePrjMainPath_MachineName表！(from {5})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId, strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }
                
                // 5. 返回代码路径
                return objUserCodePrjMainPath_MachineName.CodePath;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format(
                    "{0}.(from {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg, objException);
            }
        }
        /// <summary>
        /// 根据用户ID、机器名、项目ID、CM工程ID和应用类型ID获取用户生成代码根路径及备份路径
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strMachineName">机器名称</param>
        /// <param name="strPrjId">项目ID</param>
        /// <param name="strCmPrjId">CM工程ID</param>
        /// <param name="intApplicationTypeId">应用类型ID</param>
        /// <returns>元组：(CodePath, CodePathBackup)</returns>
        public static (string CodePath, string CodePathBackup) GetUserGCRootPathWithBackup(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId)
        {
            try
            {
                // 1. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 2. 获取用户代码项目主路径对象
                clsUserCodePrjMainPathEN objUserCodePrjMainPath =
                    clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);

                if (objUserCodePrjMainPath == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}的用户:{2}在项目:{3}的代码主路径配置，请先配置UserCodePrjMainPath表！(from {4})",
                        strCmPrjName, strAppName, strUserId, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 3. 获取特定机器的代码路径
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}在机器:{2}上的代码路径配置，请先配置UserCodePrjMainPath_MachineName表！(from {3})",
                        strCmPrjName, strAppName, strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 4. 验证代码路径是否为空
                if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineName.CodePath))
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "CM工程:{0}(ID:{1})的应用:{2}(ID:{3})在机器:{4}中生成代码路径为空，请检查UserCodePrjMainPath_MachineName表！(from {5})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId, strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 5. 返回代码路径和备份路径
                return (objUserCodePrjMainPath_MachineName.CodePath,
                        objUserCodePrjMainPath_MachineName.CodePathBackup);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format(
                    "{0}.(from {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg, objException);
            }
        }


        /// <summary>
        /// 设置用户生成代码根路径及备份路径
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strMachineName">机器名称</param>
        /// <param name="strPrjId">项目ID</param>
        /// <param name="strCmPrjId">CM工程ID</param>
        /// <param name="intApplicationTypeId">应用类型ID</param>
        /// <param name="strCodePath">代码路径</param>
        /// <param name="strCodePathBackup">备份代码路径</param>
        /// <returns>是否设置成功</returns>
        public static bool SetUserGCRootPathWithBackupBak(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            string strCodePath,
            string strCodePathBackup)
        {
            try
            {
                // 1. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 2. 获取用户代码项目主路径对象
                clsUserCodePrjMainPathEN objUserCodePrjMainPath =
                    clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);

                if (objUserCodePrjMainPath == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}的用户:{2}在项目:{3}的代码主路径配置，请先配置UserCodePrjMainPath表！(from {4})",
                        strCmPrjName, strAppName, strUserId, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 3. 获取或创建特定机器的代码路径记录
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                string strCurrDate = clsDateTime_Db.GetDataBaseDateTime14();

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    // 创建新记录
                    objUserCodePrjMainPath_MachineName = new clsUserCodePrjMainPath_MachineNameEN();
                    objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
                    objUserCodePrjMainPath_MachineName.MachineName = strMachineName;
                    objUserCodePrjMainPath_MachineName.CodePath = strCodePath;
                    objUserCodePrjMainPath_MachineName.CodePathBackup = strCodePathBackup;
                    objUserCodePrjMainPath_MachineName.PrjId = strPrjId;
                    objUserCodePrjMainPath_MachineName.UpdDate = strCurrDate;
                    objUserCodePrjMainPath_MachineName.UpdUserId = strUserId;

                    return clsUserCodePrjMainPath_MachineNameBL.AddNewRecordBySql2(objUserCodePrjMainPath_MachineName);
                }
                else
                {
                    // 更新现有记录
                    objUserCodePrjMainPath_MachineName.CodePath = strCodePath;
                    objUserCodePrjMainPath_MachineName.CodePathBackup = strCodePathBackup;
                    objUserCodePrjMainPath_MachineName.UpdDate = strCurrDate;
                    objUserCodePrjMainPath_MachineName.UpdUserId = strUserId;

                    return clsUserCodePrjMainPath_MachineNameBL.UpdateBySql2(objUserCodePrjMainPath_MachineName);
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format(
                    "{0}.(from {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg, objException);
            }
        }
        public static bool SetUserGCRootPathWithBackup(
    string strUserId,
    string strMachineName,
    string strPrjId,
    string strCmPrjId,
    int intApplicationTypeId,
    string strCodePath,
    string strCodePathBackup)
        {
            try
            {
                // 1. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    string strErrMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strErrMsg);
                }

                // 2. 获取用户代码项目主路径对象（若不存在则先创建）
                clsUserCodePrjMainPathEN objUserCodePrjMainPath = null;
                try
                {
                    objUserCodePrjMainPath = clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);
                }
                catch
                {
                    // 忽略，进入自动创建流程
                }

                if (objUserCodePrjMainPath == null)
                {
                    // 先在 UserCodePrjMainPath 建立一条记录
                    string strUserCodePrjMainPathId = clsUserCodePrjMainPathBLEx.SetGeneCodeRootPath(
                        strCmPrjId,
                        intApplicationTypeId,
                        strUserId,
                        strUserId);

                    if (string.IsNullOrEmpty(strUserCodePrjMainPathId))
                    {
                        throw new Exception("自动创建UserCodePrjMainPath记录失败！");
                    }

                    objUserCodePrjMainPath = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathIdCache(
                        strUserCodePrjMainPathId,
                        strPrjId);

                    if (objUserCodePrjMainPath == null)
                    {
                        throw new Exception("自动创建后仍无法获取UserCodePrjMainPath记录！");
                    }
                }

                // 3. 获取或创建特定机器的代码路径记录
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                string strCurrDate = clsDateTime_Db.GetDataBaseDateTime14();

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    objUserCodePrjMainPath_MachineName = new clsUserCodePrjMainPath_MachineNameEN();
                    objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
                    objUserCodePrjMainPath_MachineName.MachineName = strMachineName;
                    objUserCodePrjMainPath_MachineName.CodePath = strCodePath;
                    objUserCodePrjMainPath_MachineName.CodePathBackup = strCodePathBackup;
                    objUserCodePrjMainPath_MachineName.PrjId = strPrjId;
                    objUserCodePrjMainPath_MachineName.UpdDate = strCurrDate;
                    objUserCodePrjMainPath_MachineName.UpdUserId = strUserId;

                    return clsUserCodePrjMainPath_MachineNameBL.AddNewRecordBySql2(objUserCodePrjMainPath_MachineName);
                }
                else
                {
                    objUserCodePrjMainPath_MachineName.CodePath = strCodePath;
                    objUserCodePrjMainPath_MachineName.CodePathBackup = strCodePathBackup;
                    objUserCodePrjMainPath_MachineName.UpdDate = strCurrDate;
                    objUserCodePrjMainPath_MachineName.UpdUserId = strUserId;

                    return clsUserCodePrjMainPath_MachineNameBL.UpdateBySql2(objUserCodePrjMainPath_MachineName);
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format(
                    "{0}.(from {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg, objException);
            }
        }
    }
}
    