
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFieldTab4CodeConvBLEx
表名:FieldTab4CodeConv(00050593)
生成代码版本:2021.08.17.1
生成日期:2021/08/18 17:41:08
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
    public static class clsFieldTab4CodeConvBLEx_Static
    {

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
        /// </summary>
        /// <param name = "objFieldTab4CodeConv">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx(this clsFieldTab4CodeConvEN objFieldTab4CodeConv)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsFieldTab4CodeConvEN objFieldTab4CodeConv_Cond = new clsFieldTab4CodeConvEN();
            string strCondition = objFieldTab4CodeConv_Cond
            .SetFldId(objFieldTab4CodeConv.FldId, "=")
            .GetCombineCondition();
            objFieldTab4CodeConv._IsCheckProperty = true;
            bool bolIsExist = clsFieldTab4CodeConvBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objFieldTab4CodeConv.UpdateWithCondition(strCondition);
            }
            else
            {             
                objFieldTab4CodeConv.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objFieldTab4CodeConvENS">源对象</param>
        /// <returns>目标对象=>clsFieldTab4CodeConvEN:objFieldTab4CodeConvENT</returns>
        public static clsFieldTab4CodeConvENEx CopyToEx(this clsFieldTab4CodeConvEN objFieldTab4CodeConvENS)
        {
            try
            {
                clsFieldTab4CodeConvENEx objFieldTab4CodeConvENT = new clsFieldTab4CodeConvENEx();
                clsFieldTab4CodeConvBL.FieldTab4CodeConvDA.CopyTo(objFieldTab4CodeConvENS, objFieldTab4CodeConvENT);
                return objFieldTab4CodeConvENT;
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
        /// <param name = "objFieldTab4CodeConvENS">源对象</param>
        /// <returns>目标对象=>clsFieldTab4CodeConvEN:objFieldTab4CodeConvENT</returns>
        public static clsFieldTab4CodeConvEN CopyTo(this clsFieldTab4CodeConvENEx objFieldTab4CodeConvENS)
        {
            try
            {
                clsFieldTab4CodeConvEN objFieldTab4CodeConvENT = new clsFieldTab4CodeConvEN();
                clsFieldTab4CodeConvBL.CopyTo(objFieldTab4CodeConvENS, objFieldTab4CodeConvENT);
                return objFieldTab4CodeConvENT;
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
    /// 字段4代码转换(FieldTab4CodeConv)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsFieldTab4CodeConvBLEx : clsFieldTab4CodeConvBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFieldTab4CodeConvDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFieldTab4CodeConvDAEx FieldTab4CodeConvDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFieldTab4CodeConvDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objFieldTab4CodeConvENS">源对象</param>
        /// <returns>目标对象=>clsFieldTab4CodeConvEN:objFieldTab4CodeConvENT</returns>
        public static clsFieldTab4CodeConvENEx CopyToEx(clsFieldTab4CodeConvEN objFieldTab4CodeConvENS)
        {
            try
            {
                clsFieldTab4CodeConvENEx objFieldTab4CodeConvENT = new clsFieldTab4CodeConvENEx();
                clsFieldTab4CodeConvBL.FieldTab4CodeConvDA.CopyTo(objFieldTab4CodeConvENS, objFieldTab4CodeConvENT);
                return objFieldTab4CodeConvENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
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
        public static List<clsFieldTab4CodeConvENEx> GetObjExLst(string strCondition)
        {
            List<clsFieldTab4CodeConvEN> arrObjLst = clsFieldTab4CodeConvBL.GetObjLst(strCondition);
            List<clsFieldTab4CodeConvENEx> arrObjExLst = new List<clsFieldTab4CodeConvENEx>();
            foreach (clsFieldTab4CodeConvEN objInFor in arrObjLst)
            {
                clsFieldTab4CodeConvENEx objFieldTab4CodeConvENEx = new clsFieldTab4CodeConvENEx();
                clsFieldTab4CodeConvBL.CopyTo(objInFor, objFieldTab4CodeConvENEx);
                arrObjExLst.Add(objFieldTab4CodeConvENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFldId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsFieldTab4CodeConvENEx GetObjExByFldId(string strFldId)
        {
            clsFieldTab4CodeConvEN objFieldTab4CodeConvEN = clsFieldTab4CodeConvBL.GetObjByFldId(strFldId);
            clsFieldTab4CodeConvENEx objFieldTab4CodeConvENEx = new clsFieldTab4CodeConvENEx();
            clsFieldTab4CodeConvBL.CopyTo(objFieldTab4CodeConvEN, objFieldTab4CodeConvENEx);
            return objFieldTab4CodeConvENEx;
        }
    }
}