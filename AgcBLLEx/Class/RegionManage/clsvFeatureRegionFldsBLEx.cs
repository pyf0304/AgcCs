
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFeatureRegionFldsBLEx
表名:vFeatureRegionFlds(00050197)
生成代码版本:2019.04.12.1
生成日期:2019/04/12 07:48:10
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:区域管理
模块英文名:RegionManage
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
    public static class clsvFeatureRegionFldsBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvFeatureRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsvFeatureRegionFldsEN:objvFeatureRegionFldsENT</returns>
        public static clsvFeatureRegionFldsENEx CopyToEx(this clsvFeatureRegionFldsEN objvFeatureRegionFldsENS)
        {
            try
            {
                clsvFeatureRegionFldsENEx objvFeatureRegionFldsENT = new clsvFeatureRegionFldsENEx();
                clsvFeatureRegionFldsBL.CopyTo(objvFeatureRegionFldsENS, objvFeatureRegionFldsENT);
                return objvFeatureRegionFldsENT;
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
        /// <param name = "objvFeatureRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsvFeatureRegionFldsEN:objvFeatureRegionFldsENT</returns>
        public static clsvFeatureRegionFldsEN CopyTo(this clsvFeatureRegionFldsENEx objvFeatureRegionFldsENS)
        {
            try
            {
                clsvFeatureRegionFldsEN objvFeatureRegionFldsENT = new clsvFeatureRegionFldsEN();
                clsvFeatureRegionFldsBL.CopyTo(objvFeatureRegionFldsENS, objvFeatureRegionFldsENT);
                return objvFeatureRegionFldsENT;
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
    /// v功能区域字段列表(vFeatureRegionFlds)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvFeatureRegionFldsBLEx : clsvFeatureRegionFldsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFeatureRegionFldsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFeatureRegionFldsDAEx vFeatureRegionFldsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFeatureRegionFldsDAEx();
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
        public static List<clsvFeatureRegionFldsENEx> GetObjExLst(string strCondition)
        {
            List<clsvFeatureRegionFldsEN> arrObjLst = clsvFeatureRegionFldsBL.GetObjLst(strCondition);
            List<clsvFeatureRegionFldsENEx> arrObjExLst = new List<clsvFeatureRegionFldsENEx>();
            foreach (clsvFeatureRegionFldsEN objInFor in arrObjLst)
            {
                clsvFeatureRegionFldsENEx objvFeatureRegionFldsENEx = new clsvFeatureRegionFldsENEx();
                clsvFeatureRegionFldsBL.CopyTo(objInFor, objvFeatureRegionFldsENEx);
                arrObjExLst.Add(objvFeatureRegionFldsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvFeatureRegionFldsENEx GetObjExBymId(string lngmId)
        {
            clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = clsvFeatureRegionFldsBL.GetObjByViewFeatureId(lngmId);
            clsvFeatureRegionFldsENEx objvFeatureRegionFldsENEx = new clsvFeatureRegionFldsENEx();
            clsvFeatureRegionFldsBL.CopyTo(objvFeatureRegionFldsEN, objvFeatureRegionFldsENEx);
            return objvFeatureRegionFldsENEx;
        }
    }
}