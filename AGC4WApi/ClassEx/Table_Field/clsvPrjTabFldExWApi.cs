
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTabFldExWApi
表名:vPrjTabFld(00050122)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:00:03
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using System.Linq;

namespace AGC4WApi
{
    /// <summary>
    /// vPrjTabFld(vPrjTabFld)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvPrjTabFldExWApi
    {
        //private static readonly string mstrApiControllerName = "vPrjTabFldExApi";
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsvPrjTabFldExWApi()
        {
        }
       
        /// <summary>
        /// 根据[表Id(TabId)]获取相关对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>根据[表Id(TabId)]获取的相关对象子表</returns>
        public static List<clsvPrjTabFldEN> GetObjLstByTabIdCache(string strPrjId, string strTabId)
        {
            if (strTabId.Substring(0, 4) != strPrjId)
            {
                string strMsg = string.Format("(errid:BlEx000040)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!在({4}-{3}-{2})",
                    strPrjId, strTabId,
                    clsStackTrace.GetCurrClassFunctionByLevel(1),
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunctionByLevel(3));
                throw new Exception(strMsg);
            }

            List<clsvPrjTabFldEN> arrvPrjTabFldObjLst_Cache = clsvPrjTabFldWApi.GetObjLstCache(strPrjId);


            IEnumerable<clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel1 =
                from objvPrjTabFldEN in arrvPrjTabFldObjLst_Cache
                where objvPrjTabFldEN.TabId == strTabId
                select objvPrjTabFldEN;


            List<clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel = new List<clsvPrjTabFldEN>();
            foreach (clsvPrjTabFldEN obj in arrvPrjTabFldObjLst_Sel1)
            {
                arrvPrjTabFldObjLst_Sel.Add(obj);
            }
            //clsvPrjTabFldWApi.SortvPrjTabFldObjLstByTabId(arrvPrjTabFldObjLst_Sel, System.Data.SqlClient.SortOrder.Ascending);
            arrvPrjTabFldObjLst_Sel = arrvPrjTabFldObjLst_Sel.OrderBy(x=>x.TabId).ToList();
            return arrvPrjTabFldObjLst_Sel;
        }

    }
}