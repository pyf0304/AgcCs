
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvSetFieldVisibilityBLEx
表名:vSetFieldVisibility(00050243)
生成代码版本:2020.05.28.1
生成日期:2020/05/28 18:16:14
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:系统设置
模块英文名:SystemSet
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
    public static class clsvSetFieldVisibilityBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvSetFieldVisibilityENS">源对象</param>
        /// <returns>目标对象=>clsvSetFieldVisibilityEN:objvSetFieldVisibilityENT</returns>
        public static clsvSetFieldVisibilityENEx CopyToEx(this clsvSetFieldVisibilityEN objvSetFieldVisibilityENS)
        {
            try
            {
                clsvSetFieldVisibilityENEx objvSetFieldVisibilityENT = new clsvSetFieldVisibilityENEx();
                clsvSetFieldVisibilityBL.vSetFieldVisibilityDA.CopyTo(objvSetFieldVisibilityENS, objvSetFieldVisibilityENT);
                return objvSetFieldVisibilityENT;
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
        /// <param name = "objvSetFieldVisibilityENS">源对象</param>
        /// <returns>目标对象=>clsvSetFieldVisibilityEN:objvSetFieldVisibilityENT</returns>
        public static clsvSetFieldVisibilityEN CopyTo(this clsvSetFieldVisibilityENEx objvSetFieldVisibilityENS)
        {
            try
            {
                clsvSetFieldVisibilityEN objvSetFieldVisibilityENT = new clsvSetFieldVisibilityEN();
                clsvSetFieldVisibilityBL.CopyTo(objvSetFieldVisibilityENS, objvSetFieldVisibilityENT);
                return objvSetFieldVisibilityENT;
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
    /// v设置字段可视性(vSetFieldVisibility)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvSetFieldVisibilityBLEx : clsvSetFieldVisibilityBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvSetFieldVisibilityDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvSetFieldVisibilityDAEx vSetFieldVisibilityDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvSetFieldVisibilityDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        public static bool IsVisible(string strSchoolId, string strFieldName)
        {
            var arrvSetFieldVisibilityObjLstCache = clsvSetFieldVisibilityBL.GetObjLstCache();
            foreach (clsvSetFieldVisibilityEN objSetFieldVisibilityEN in arrvSetFieldVisibilityObjLstCache)
            {
                if (objSetFieldVisibilityEN.SchoolId == strSchoolId && objSetFieldVisibilityEN.FieldName == strFieldName)
                {
                    return objSetFieldVisibilityEN.IsVisible;
                }
            }
            return true;
        }

        public static bool IsVisible(string strSchoolId, string strViewName, string strFieldName)
        {
            var arrvSetFieldVisibilityObjLstCache = clsvSetFieldVisibilityBL.GetObjLstCache();

            foreach (clsvSetFieldVisibilityEN objSetFieldVisibilityEN in arrvSetFieldVisibilityObjLstCache)
            {
                if (objSetFieldVisibilityEN.SchoolId == strSchoolId &&
                    objSetFieldVisibilityEN.ViewName == strViewName &&
                    objSetFieldVisibilityEN.FieldName == strFieldName)
                {
                    return objSetFieldVisibilityEN.IsVisible;
                }
            }
            return true;
        }
        public static clsvSetFieldVisibilityEN GetvSetFieldVisibilityObjByFieldNameCache(string strSchoolId, string strViewName, string strFieldName)
        {

            var arrvSetFieldVisibilityObjLstCache = clsvSetFieldVisibilityBL.GetObjLstCache();

            foreach (clsvSetFieldVisibilityEN objSetFieldVisibilityEN in arrvSetFieldVisibilityObjLstCache)
            {
                if (objSetFieldVisibilityEN.SchoolId == strSchoolId &&
                    objSetFieldVisibilityEN.ViewName == strViewName &&
                    objSetFieldVisibilityEN.FieldName == strFieldName)
                {
                    return objSetFieldVisibilityEN;
                }
            }
            return null;
        }
    }
}