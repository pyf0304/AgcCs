
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFeatureButtonRelaBLEx
表名:vFeatureButtonRela(00050428)
生成代码版本:2019.03.05.1
生成日期:2019/03/06 10:17:21
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
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.02.22.01
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
    /// vFeatureButtonRela(vFeatureButtonRela)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public class clsvFeatureButtonRelaBLEx : clsvFeatureButtonRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFeatureButtonRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFeatureButtonRelaDAEx vFeatureButtonRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFeatureButtonRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据功能获取相关对象列表, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <param name = "strFeatureId">功能Id</param>        
        /// <returns>根据关键字获取的对象</returns>
        public static List< clsvFeatureButtonRelaEN> GetObjLstByFeatureIdCacheEx(int intApplicationTypeId, string strFeatureId)
        {
            //初始化列表缓存
            List<clsvFeatureButtonRelaEN> arrObjLstCache = clsvFeatureButtonRelaBL.GetObjLstCache();

            IEnumerable<clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLst_Sel1 =
            from objvFeatureButtonRelaEN in arrObjLstCache
            where objvFeatureButtonRelaEN.ApplicationTypeId == intApplicationTypeId && objvFeatureButtonRelaEN.FeatureId == strFeatureId
            select objvFeatureButtonRelaEN;
            List<clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLst_Sel = new List<clsvFeatureButtonRelaEN>();
            foreach (clsvFeatureButtonRelaEN obj in arrvFeatureButtonRelaObjLst_Sel1)
            {
                arrvFeatureButtonRelaObjLst_Sel.Add(obj);
            }
            if (arrvFeatureButtonRelaObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvFeatureButtonRelaObjLst_Sel;
        }

    }
}