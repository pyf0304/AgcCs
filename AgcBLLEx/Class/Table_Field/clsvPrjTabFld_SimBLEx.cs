
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTabFld_SimBLEx
表名:vPrjTabFld_Sim(00050589)
生成代码版本:2021.07.03.1
生成日期:2021/07/04 00:46:19
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:AGC
工程ID:0005
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
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
    public static class clsvPrjTabFld_SimBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvPrjTabFld_SimENS">源对象</param>
        /// <returns>目标对象=>clsvPrjTabFld_SimEN:objvPrjTabFld_SimENT</returns>
        public static clsvPrjTabFld_SimENEx CopyToEx(this clsvPrjTabFld_SimEN objvPrjTabFld_SimENS)
        {
            try
            {
                clsvPrjTabFld_SimENEx objvPrjTabFld_SimENT = new clsvPrjTabFld_SimENEx();
                clsvPrjTabFld_SimBL.vPrjTabFld_SimDA.CopyTo(objvPrjTabFld_SimENS, objvPrjTabFld_SimENT);
                return objvPrjTabFld_SimENT;
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
        /// <param name = "objvPrjTabFld_SimENS">源对象</param>
        /// <returns>目标对象=>clsvPrjTabFld_SimEN:objvPrjTabFld_SimENT</returns>
        public static clsvPrjTabFld_SimEN CopyTo(this clsvPrjTabFld_SimENEx objvPrjTabFld_SimENS)
        {
            try
            {
                clsvPrjTabFld_SimEN objvPrjTabFld_SimENT = new clsvPrjTabFld_SimEN();
                clsvPrjTabFld_SimBL.CopyTo(objvPrjTabFld_SimENS, objvPrjTabFld_SimENT);
                return objvPrjTabFld_SimENT;
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
    /// vPrjTabFld_Sim(vPrjTabFld_Sim)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvPrjTabFld_SimBLEx : clsvPrjTabFld_SimBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvPrjTabFld_SimDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvPrjTabFld_SimDAEx vPrjTabFld_SimDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvPrjTabFld_SimDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvPrjTabFld_SimENEx> GetObjExLst(string strCondition)
        {
            List<clsvPrjTabFld_SimEN> arrObjLst = clsvPrjTabFld_SimBL.GetObjLst(strCondition);
            List<clsvPrjTabFld_SimENEx> arrObjExLst = new List<clsvPrjTabFld_SimENEx>();
            foreach (clsvPrjTabFld_SimEN objInFor in arrObjLst)
            {
                clsvPrjTabFld_SimENEx objvPrjTabFld_SimENEx = new clsvPrjTabFld_SimENEx();
                clsvPrjTabFld_SimBL.CopyTo(objInFor, objvPrjTabFld_SimENEx);
                arrObjExLst.Add(objvPrjTabFld_SimENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvPrjTabFld_SimENEx GetObjExBymId(long lngmId)
        {
            clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = clsvPrjTabFld_SimBL.GetObjBymId(lngmId);
            clsvPrjTabFld_SimENEx objvPrjTabFld_SimENEx = new clsvPrjTabFld_SimENEx();
            clsvPrjTabFld_SimBL.CopyTo(objvPrjTabFld_SimEN, objvPrjTabFld_SimENEx);
            return objvPrjTabFld_SimENEx;
        }
        public static List<clsvPrjTabFld_SimEN> GetObjLstByFldIdCache(string strFldId, string strPrjIdId)
        {
            //初始化列表缓存
            var arrObjLstCache = clsvPrjTabFld_SimBL.GetObjLstCache(strPrjIdId);
            var arrPrjTabFldObjLst_Sel = arrObjLstCache.Where(x => x.FldId == strFldId).ToList();            
            return arrPrjTabFldObjLst_Sel;
        }
        public static List<clsvPrjTabFld_SimEN> getObjLstByFldIdAndFldType(string strFldId, string strFldTypeId)
        {
            // 构建查询条件
            string strCondition = $"FldId = '{strFldId}' AND FieldTypeId = '{strFldTypeId}'";

            // 获取对象列表
            List<clsvPrjTabFld_SimEN> objLst = clsvPrjTabFld_SimBL.GetObjLst(strCondition);

            return objLst;
        }

    }
}