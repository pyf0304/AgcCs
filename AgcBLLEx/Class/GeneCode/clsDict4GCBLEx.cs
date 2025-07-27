
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDict4GCBLEx
表名:Dict4GC
生成代码版本:2017.07.08.1
生成日期:2017/08/05 16:28:52
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.07.14.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
    /// 生成代码字典(Dict4GC)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsDict4GCBLEx : clsDict4GCBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsDict4GCDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsDict4GCDAEx Dict4GCDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsDict4GCDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.      
        /// </summary>
        /// <param name = "strDictKey1">所给的关键字</param>
        /// <param name = "strDictKey2">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsDict4GCEN GetDict4GCObjByKeyCache(string strDictKey1, string strDictKey2)
        {
            if (string.IsNullOrEmpty(strDictKey1) == true) return null;
            //初始化列表缓存
            //InitListCache();
            List<clsDict4GCEN> arrObjLstCache = clsDict4GCBL.GetObjLstCache();

            IEnumerable<clsDict4GCEN> arrDict4GCObjLst_Sel1 = null;
            if (string.IsNullOrEmpty(strDictKey2) == true)
            {
                arrDict4GCObjLst_Sel1 =
                    from objDict4GCEN in arrObjLstCache
                    where objDict4GCEN.DictKey1 == strDictKey1
                    select objDict4GCEN;
            }
            else
            {
                arrDict4GCObjLst_Sel1 =
                    from objDict4GCEN in arrObjLstCache
                    where objDict4GCEN.DictKey1 == strDictKey1 
                            && objDict4GCEN.DictKey2 == strDictKey2
                    select objDict4GCEN;
            }
            List<clsDict4GCEN> arrDict4GCObjLst_Sel = new List<clsDict4GCEN>();
            foreach (clsDict4GCEN obj in arrDict4GCObjLst_Sel1)
            {
                arrDict4GCObjLst_Sel.Add(obj);
            }
            if (arrDict4GCObjLst_Sel.Count != 1)
            {
                string strMsg = string.Format("根据关键字1:[{0}],关键字2:[{1}]获取的字典值数不为1，不正确！", strDictKey1, strDictKey2);
                throw new Exception(strMsg);
            }
            return arrDict4GCObjLst_Sel[0];
        }


        /// <summary>
        /// 根据关键字获取相关字典值, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetRecObjByKeyCache)
        /// </summary>
        /// <param name = "strDictKey1">所给的关键字</param>
        /// <param name = "strDictKey2">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetDictValueByKeyCache(string strDictKey1, string strDictKey2)
        {
            if (string.IsNullOrEmpty(strDictKey1) == true) return null;
            //初始化列表缓存
            List<clsDict4GCEN> arrObjLstCache = clsDict4GCBL.GetObjLstCache();

            IEnumerable<clsDict4GCEN> arrDict4GCObjLst_Sel1 = null;
            if (string.IsNullOrEmpty(strDictKey2) == true)
            {
                arrDict4GCObjLst_Sel1 =
                    from objDict4GCEN in arrObjLstCache
                    where objDict4GCEN.DictKey1 == strDictKey1
                    select objDict4GCEN;
            }
            else
            {
                arrDict4GCObjLst_Sel1 =
                    from objDict4GCEN in arrObjLstCache
                    where objDict4GCEN.DictKey1 == strDictKey1
                            && objDict4GCEN.DictKey2 == strDictKey2
                    select objDict4GCEN;
            }
            List<clsDict4GCEN> arrDict4GCObjLst_Sel = new List<clsDict4GCEN>();
            foreach (clsDict4GCEN obj in arrDict4GCObjLst_Sel1)
            {
                arrDict4GCObjLst_Sel.Add(obj);
            }
            if (arrDict4GCObjLst_Sel.Count != 1)
            {
                string strMsg = string.Format("根据关键字1:[{0}],关键字2:[{1}]获取的字典值数不为1，不正确！", strDictKey1, strDictKey2);
                throw new Exception(strMsg);
            }
            return arrDict4GCObjLst_Sel[0].DictValue;
        }

    }
}