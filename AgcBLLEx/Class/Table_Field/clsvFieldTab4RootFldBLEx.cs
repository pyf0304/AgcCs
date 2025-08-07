
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFieldTab4RootFldBLEx
表名:vFieldTab4RootFld
生成代码版本:2018.04.29.1
生成日期:2018/04/30 10:51:13
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
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

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// vFieldTab4RootFld(vFieldTab4RootFld)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvFieldTab4RootFldBLEx : clsvFieldTab4RootFldBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFieldTab4RootFldDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFieldTab4RootFldDAEx vFieldTab4RootFldDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFieldTab4RootFldDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strTabName">表名</param>
        /// <param name = "strFldName">字段名</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvFieldTab4RootFldEN GetObjByTabNameAndFldNameCache(string strPrjId, string strTabName , string strFldName)
        {
            //初始化列表缓存
        

            IEnumerable<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId);

            IEnumerable<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLst_Sel1 =
            from objvFieldTab4RootFldEN in arrvFieldTab4RootFldObjLstCache
            where objvFieldTab4RootFldEN.PrjId == strPrjId && objvFieldTab4RootFldEN.TabName == strTabName && objvFieldTab4RootFldEN.FldName == strFldName
            select objvFieldTab4RootFldEN;
            List<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLst_Sel = new List<clsvFieldTab4RootFldEN>();
            foreach (clsvFieldTab4RootFldEN obj in arrvFieldTab4RootFldObjLst_Sel1)
            {
                arrvFieldTab4RootFldObjLst_Sel.Add(obj);
            }
            if (arrvFieldTab4RootFldObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvFieldTab4RootFldObjLst_Sel[0];
        }

    }
}