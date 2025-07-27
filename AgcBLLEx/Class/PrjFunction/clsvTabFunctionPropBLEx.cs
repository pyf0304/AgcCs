
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvTabFunctionPropBLEx
表名:vTabFunctionProp(00050524)
生成代码版本:2019.11.16.1
生成日期:2019/11/19 11:23:02
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:函数管理
模块英文名:PrjFunction
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
    public static class clsvTabFunctionPropBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvTabFunctionPropENS">源对象</param>
        /// <returns>目标对象=>clsvTabFunctionPropEN:objvTabFunctionPropENT</returns>
        public static clsvTabFunctionPropENEx CopyToEx(this clsvTabFunctionPropEN objvTabFunctionPropENS)
        {
            try
            {
                clsvTabFunctionPropENEx objvTabFunctionPropENT = new clsvTabFunctionPropENEx();
                clsvTabFunctionPropBL.CopyTo(objvTabFunctionPropENS, objvTabFunctionPropENT);
                return objvTabFunctionPropENT;
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
        /// <param name = "objvTabFunctionPropENS">源对象</param>
        /// <returns>目标对象=>clsvTabFunctionPropEN:objvTabFunctionPropENT</returns>
        public static clsvTabFunctionPropEN CopyTo(this clsvTabFunctionPropENEx objvTabFunctionPropENS)
        {
            try
            {
                clsvTabFunctionPropEN objvTabFunctionPropENT = new clsvTabFunctionPropEN();
                clsvTabFunctionPropBL.CopyTo(objvTabFunctionPropENS, objvTabFunctionPropENT);
                return objvTabFunctionPropENT;
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
    /// vTabFunctionProp(vTabFunctionProp)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvTabFunctionPropBLEx : clsvTabFunctionPropBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvTabFunctionPropDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvTabFunctionPropDAEx vTabFunctionPropDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvTabFunctionPropDAEx();
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
        public static List<clsvTabFunctionPropENEx> GetObjExLst(string strCondition)
        {
            List<clsvTabFunctionPropEN> arrObjLst = clsvTabFunctionPropBL.GetObjLst(strCondition);
            List<clsvTabFunctionPropENEx> arrObjExLst = new List<clsvTabFunctionPropENEx>();
            foreach (clsvTabFunctionPropEN objInFor in arrObjLst)
            {
                clsvTabFunctionPropENEx objvTabFunctionPropENEx = new clsvTabFunctionPropENEx();
                clsvTabFunctionPropBL.CopyTo(objInFor, objvTabFunctionPropENEx);
                arrObjExLst.Add(objvTabFunctionPropENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvTabFunctionPropENEx GetObjExBymId(long lngmId)
        {
            clsvTabFunctionPropEN objvTabFunctionPropEN = clsvTabFunctionPropBL.GetObjBymId(lngmId);
            clsvTabFunctionPropENEx objvTabFunctionPropENEx = new clsvTabFunctionPropENEx();
            clsvTabFunctionPropBL.CopyTo(objvTabFunctionPropEN, objvTabFunctionPropENEx);
            return objvTabFunctionPropENEx;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvTabFunctionPropENS">源对象</param>
        /// <returns>目标对象=>clsvTabFunctionPropEN:objvTabFunctionPropENT</returns>
        public static clsvTabFunctionPropEN CopyToEx(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENS)
        {
            try
            {
                clsvTabFunctionPropEN objvTabFunctionPropENT = new clsvTabFunctionPropEN();
                objvTabFunctionPropENT.mId = objvFunctionTemplateRelaENS.mId; //mId
                //objvTabFunctionPropENT.TabId = objvFunctionTemplateRelaENS.TabId; //表ID
                //objvTabFunctionPropENT.TabName = objvFunctionTemplateRelaENS.TabName; //表名
                //objvTabFunctionPropENT.TabCnName = objvFunctionTemplateRelaENS.TabCnName; //表中文名
                objvTabFunctionPropENT.FunctionTemplateId = objvFunctionTemplateRelaENS.FunctionTemplateId; //函数模板Id
                objvTabFunctionPropENT.FunctionTemplateName = objvFunctionTemplateRelaENS.FunctionTemplateName; //函数模板名
                objvTabFunctionPropENT.CodeTypeId = objvFunctionTemplateRelaENS.CodeTypeId; //代码类型Id
                objvTabFunctionPropENT.CodeTypeName = objvFunctionTemplateRelaENS.CodeTypeName; //代码类型名
                objvTabFunctionPropENT.CodeTypeENName = objvFunctionTemplateRelaENS.CodeTypeENName; //代码类型英文名
                objvTabFunctionPropENT.FuncId4GC = objvFunctionTemplateRelaENS.FuncId4GC; //函数ID
                objvTabFunctionPropENT.FuncName = objvFunctionTemplateRelaENS.FuncName; //函数名
                objvTabFunctionPropENT.FuncId4Code = objvFunctionTemplateRelaENS.FuncId4Code; //函数Id4Code
                objvTabFunctionPropENT.FuncName4Code = objvFunctionTemplateRelaENS.FuncName4Code; //函数名4Code
                objvTabFunctionPropENT.FuncCHName4Code = objvFunctionTemplateRelaENS.FuncCHName4Code; //函数中文名4Code
                objvTabFunctionPropENT.ProgLangTypeId = objvFunctionTemplateRelaENS.ProgLangTypeId; //编程语言类型Id
                objvTabFunctionPropENT.ProgLangTypeName = objvFunctionTemplateRelaENS.ProgLangTypeName; //编程语言类型名
                //objvTabFunctionPropENT.MethodModifierId = objvFunctionTemplateRelaENS.MethodModifierId; //函数修饰语Id
                //objvTabFunctionPropENT.MethodModifierName = objvFunctionTemplateRelaENS.MethodModifierName; //函数修饰语名称
                //objvTabFunctionPropENT.IsForAllTemplate = objvFunctionTemplateRelaENS.IsForAllTemplate; //是否针对所有模板
                objvTabFunctionPropENT.UpdDate = objvFunctionTemplateRelaENS.UpdDate; //修改日期
                objvTabFunctionPropENT.UpdUser = objvFunctionTemplateRelaENS.UpdUser; //修改者
                objvTabFunctionPropENT.Memo = objvFunctionTemplateRelaENS.Memo; //说明
                //objvTabFunctionPropENT.Order4Func = objvFunctionTemplateRelaENS.Order4Func; //Order4函数

                return objvTabFunctionPropENT;
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