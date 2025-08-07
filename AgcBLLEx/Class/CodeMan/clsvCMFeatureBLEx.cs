
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvCMFeatureBLEx
表名:vCMFeature(00050519)
生成代码版本:2019.11.08.1
生成日期:2019/11/12 16:14:46
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
    public static class clsvCMFeatureBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvCMFeatureENS">源对象</param>
        /// <returns>目标对象=>clsvCMFeatureEN:objvCMFeatureENT</returns>
        public static clsvCMFeatureENEx CopyToEx(this clsvCMFeatureEN objvCMFeatureENS)
        {
            try
            {
                clsvCMFeatureENEx objvCMFeatureENT = new clsvCMFeatureENEx();
                clsvCMFeatureBL.CopyTo(objvCMFeatureENS, objvCMFeatureENT);
                return objvCMFeatureENT;
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
        /// <param name = "objvCMFeatureENS">源对象</param>
        /// <returns>目标对象=>clsvCMFeatureEN:objvCMFeatureENT</returns>
        public static clsvCMFeatureEN CopyTo(this clsvCMFeatureENEx objvCMFeatureENS)
        {
            try
            {
                clsvCMFeatureEN objvCMFeatureENT = new clsvCMFeatureEN();
                clsvCMFeatureBL.CopyTo(objvCMFeatureENS, objvCMFeatureENT);
                return objvCMFeatureENT;
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
    /// vCMFeature(vCMFeature)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvCMFeatureBLEx : clsvCMFeatureBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvCMFeatureDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvCMFeatureDAEx vCMFeatureDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvCMFeatureDAEx();
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
        public static List<clsvCMFeatureENEx> GetObjExLst(string strCondition)
        {
            List<clsvCMFeatureEN> arrObjLst = clsvCMFeatureBL.GetObjLst(strCondition);
            List<clsvCMFeatureENEx> arrObjExLst = new List<clsvCMFeatureENEx>();
            foreach (clsvCMFeatureEN objInFor in arrObjLst)
            {
                clsvCMFeatureENEx objvCMFeatureENEx = new clsvCMFeatureENEx();
                clsvCMFeatureBL.CopyTo(objInFor, objvCMFeatureENEx);
                arrObjExLst.Add(objvCMFeatureENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCmFeatureId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvCMFeatureENEx GetObjExByCmFeatureId(string strCmFeatureId)
        {
            clsvCMFeatureEN objvCMFeatureEN = clsvCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);
            clsvCMFeatureENEx objvCMFeatureENEx = new clsvCMFeatureENEx();
            clsvCMFeatureBL.CopyTo(objvCMFeatureEN, objvCMFeatureENEx);
            return objvCMFeatureENEx;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvCMFeatureENS">源对象</param>
        /// <returns>目标对象=>clsvCMFeatureEN:objvCMFeatureENT</returns>
        public static clsvCMFeatureENEx CopyToEx(clsvCMFeatureEN objvCMFeatureENS)
        {
            try
            {
                clsvCMFeatureENEx objvCMFeatureENT = new clsvCMFeatureENEx();
                clsvCMFeatureBL.vCMFeatureDA.CopyTo(objvCMFeatureENS, objvCMFeatureENT);
                if (string.IsNullOrEmpty(objvCMFeatureENS.CmParentFeatureId) == false)
                {
                    objvCMFeatureENT.CMFeatureNameTitle = "子功能";
                    objvCMFeatureENT.IsSubFeature = true;
                }
                else
                {
                    objvCMFeatureENT.CMFeatureNameTitle = "功能";
                    objvCMFeatureENT.IsSubFeature = false;
                }
                return objvCMFeatureENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}