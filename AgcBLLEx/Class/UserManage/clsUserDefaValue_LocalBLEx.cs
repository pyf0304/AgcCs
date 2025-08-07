
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUserDefaValue_LocalBLEx
表名:UserDefaValue_Local
生成代码版本:2018.03.11.1
生成日期:2018/03/17 01:02:56
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC_CSV7
工程ID:0005
模块中文名:用户管理
模块英文名:UserManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
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
    /// <summary>
    /// 用户缺省值(UserDefaValue_Local)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsUserDefaValue_LocalBLEx : clsUserDefaValue_LocalBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsUserDefaValue_LocalDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsUserDefaValue_LocalDAEx UserDefaValue_LocalDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsUserDefaValue_LocalDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 获取用户缺省值
        /// </summary>
        /// <param name="strCurrPrjId">当前工程Id</param>
        /// <param name="strCurrSelPrjId">当前用户选择的工程Id</param>
        /// <param name="strUserId"></param>
        /// <param name="strDefaValName"></param>
        /// <returns></returns>
        public static string getUserDefaValue(string strCurrPrjId, string strCurrSelPrjId, string strUserId, string strDefaValName)
        {
            //操作步骤:
            //1、根据缺省值名称()获取相应的编号(DefaValNameId)；如果不存在该编号，说明该缺省值不存在，返回空值。
            //2、根据用户ID()和编号(DefaValNameId)到用户缺省值表去查找相应的记录以便获取相应缺省值名称的缺省值，
            //  并返回此值。
            //3、如果不存在相应的缺省值，就根据缺省值编号到系统缺省值表()去查找系统定义的缺省值，并返回该值。

            List<string> arrLst = new List<string>();
            StringBuilder strCondition = new StringBuilder();
            string strDefaValNameId;
            string strUserDefaValue;
            //操作步骤的实现:
            //1、根据缺省值名称()获取相应的编号(DefaValNameId)；如果不存在该编号，说明该缺省值不存在，返回空值。
            strCondition.AppendFormat("PrjId = '{0}'", strCurrPrjId);
            strCondition.AppendFormat(" and DefaValName = '{0}'", strDefaValName);
            arrLst = clsSysDefaValNameBL.GetFldValue("DefaValNameId", strCondition.ToString());
            if (arrLst.Count == 0) return "";
            strDefaValNameId = arrLst[0].ToString();
            //2、根据用户ID()和编号(DefaValNameId)到用户缺省值表去查找相应的记录以便获取相应缺省值名称的缺省值，
            //  并返回此值。
            strCondition = new StringBuilder();
            strCondition.AppendFormat("UserId = '{0}'", strUserId);
            strCondition.AppendFormat(" and DefaValNameId = '{0}'", strDefaValNameId);
            strCondition.AppendFormat(" and {0} = '{1}'", conUserDefaValue_Local.PrjId, strCurrSelPrjId);
            arrLst = clsUserDefaValue_LocalBL.GetFldValue("UserDefaValue", strCondition.ToString());
            if (arrLst.Count > 0)
            {
                strUserDefaValue = arrLst[0].ToString();
                return strUserDefaValue;
            }
            return "";
            //3、如果不存在相应的缺省值，就根据缺省值编号到系统缺省值表()去查找系统定义的缺省值，并返回该值。
            //strCondition = new StringBuilder();
            //strCondition.AppendFormat("DefaValNameId = '{0}'", strDefaValNameId);
            //arrLst = clsSysDefaValNameBL.GetFldValue("SysDefaValue", strCondition.ToString());
            //strUserDefaValue = arrLst[0].ToString();
            //return strUserDefaValue;
        }

        /// <summary>
        /// 设置用户默认值
        /// </summary>
        /// <param name = "strCurrPrjId">当前工程</param>
        /// <param name = "strCurrSelPrjId">当前用户选择的工程Id</param>
        /// <param name = "strUserId"></param>
        /// <param name = "strDefaValName"></param>
        /// <param name = "strUserDefaValue"></param>
        /// <returns></returns>
        public static bool setUserDefaValue(string strCurrPrjId, string strCurrSelPrjId,
            string strUserId, string strDefaValName, string strUserDefaValue)
        {
            //操作步骤:
            //1、根据缺省值名称()获取相应的编号(DefaValNameId)；如果不存在该编号，说明该缺省值不存在，返回空值。
            //2、根据用户ID()和编号(DefaValNameId)到用户缺省值表去查找相应的记录以便获取相应缺省值名称的缺省值，
            //  并返回此值。
            //3、如果不存在相应的缺省值，就根据缺省值编号到系统缺省值表()去查找系统定义的缺省值，并返回该值。

            List<string> arrLst = new List<string>();
            StringBuilder strCondition = new StringBuilder();
            string strDefaValNameId;
            //string strUserDefaValue;
            //操作步骤的实现:
            //1、根据缺省值名称()获取相应的编号(DefaValNameId)；如果不存在该编号，说明该缺省值不存在，返回空值。
            strCondition.AppendFormat("PrjId = '{0}'", strCurrPrjId);
            strCondition.AppendFormat(" and DefaValName = '{0}'", strDefaValName);
            List<clsSysDefaValNameEN> arrSysDefaValNameObjLst_Sel = clsSysDefaValNameBLEx.GetAllSysDefaValNameObjLstCacheEx(strDefaValName, strCurrPrjId);
            if (arrSysDefaValNameObjLst_Sel.Count == 0)
            {
                string strMsg = string.Format("在系统默认值名称中，没有默认值名:{0}, 请检查!({1})",
                    strDefaValName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            strDefaValNameId = arrSysDefaValNameObjLst_Sel[0].DefaValNameId;
            //2、根据用户ID()和编号(DefaValNameId)到用户缺省值表去查找相应的记录以便获取相应缺省值名称的缺省值，
            //  并返回此值。
            strCondition = new StringBuilder();
            strCondition.AppendFormat("UserId = '{0}'", strUserId);
            strCondition.AppendFormat(" and DefaValNameId = '{0}'", strDefaValNameId);
            strCondition.AppendFormat(" and {0} = '{1}'", conUserDefaValue_Local.PrjId, strCurrSelPrjId);
            List<clsUserDefaValue_LocalEN> arrUserDefaValueObjLst_Sel = GetAllUserDefaValueObjLstCacheEx(strUserId, strDefaValNameId, strCurrSelPrjId);
            if (arrUserDefaValueObjLst_Sel.Count > 0)
            {
                clsUserDefaValue_LocalEN objUserDefaValueEN = arrUserDefaValueObjLst_Sel[0];
                if (objUserDefaValueEN.UserDefaValue == strUserDefaValue) return true;
                objUserDefaValueEN.UserDefaValue = strUserDefaValue;
                objUserDefaValueEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objUserDefaValueEN.UpdUserId = strUserId;
                clsUserDefaValue_LocalBL.UpdateBySql2(objUserDefaValueEN);
                return true;
            }
            else
            {
                clsUserDefaValue_LocalEN objUserDefaValueEN = new clsUserDefaValue_LocalEN();
                objUserDefaValueEN.PrjId = strCurrSelPrjId;
                objUserDefaValueEN.UserId = strUserId;

                objUserDefaValueEN.DefaValNameId = strDefaValNameId;
                objUserDefaValueEN.UserDefaValue = strUserDefaValue;
                objUserDefaValueEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objUserDefaValueEN.UpdUserId = strUserId;
                clsUserDefaValue_LocalBL.AddNewRecordBySql2(objUserDefaValueEN);
                return true;
            }

        }
        /// <summary>
        /// 从缓存中获取所有正在使用的用户缺省值对象列表.
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <param name = "strUserId"></param>
        /// <param name = "strDefaValNameId"></param>
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsUserDefaValue_LocalEN> GetAllUserDefaValueObjLstCacheEx(string strUserId, string strDefaValNameId, string strPrjId)
        {
            List<clsUserDefaValue_LocalEN> arrObjLstCache = clsUserDefaValue_LocalBL.GetObjLstCache();


            List<clsUserDefaValue_LocalEN> arrUserDefaValueObjLst = new List<clsUserDefaValue_LocalEN>();

            IEnumerable<clsUserDefaValue_LocalEN> arrUserDefaValueObjLst_Sel1 =
                from objUserDefaValueEN in arrObjLstCache
                where objUserDefaValueEN.UserId == strUserId
                && objUserDefaValueEN.DefaValNameId == strDefaValNameId
                && objUserDefaValueEN.PrjId == strPrjId
                select objUserDefaValueEN;


            List<clsUserDefaValue_LocalEN> arrUserDefaValueObjLst_Sel = new List<clsUserDefaValue_LocalEN>();
            foreach (clsUserDefaValue_LocalEN obj in arrUserDefaValueObjLst_Sel1)
            {
                arrUserDefaValueObjLst_Sel.Add(obj);
            }

            return arrUserDefaValueObjLst_Sel;
        }
        
    }
}