
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
            if (arrUserCodePrjMainPath_MachineName == null || arrUserCodePrjMainPath_MachineName .Count ==0) return "";
            arrUserCodePrjMainPath_MachineName = arrUserCodePrjMainPath_MachineName.OrderByDescending(x=>x.UpdDate).ToList();
            var arrMachineName = arrUserCodePrjMainPath_MachineName.Select(x => x.MachineName).ToList();
            return arrMachineName[0];
        }
    }
}