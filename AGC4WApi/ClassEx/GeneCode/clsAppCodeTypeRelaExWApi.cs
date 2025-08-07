
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAppCodeTypeRelaExWApi
表名:AppCodeTypeRela(00050418)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:02:27
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
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
    /// 应用程序代码类型关系(AppCodeTypeRela)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsAppCodeTypeRelaExWApi
    {
        //private static readonly string mstrApiControllerName = "AppCodeTypeRelaExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsAppCodeTypeRelaExWApi()
        {
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static IEnumerable< clsAppCodeTypeRelaEN > GetObjLstByApplicationTypeIdCache(int intApplicationTypeId)
        {
            //初始化列表缓存
            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Cache = clsAppCodeTypeRelaWApi.GetObjLstCache();
            IEnumerable<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel1 =
            from objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjLst_Cache
            where objAppCodeTypeRelaEN.ApplicationTypeId == intApplicationTypeId
            select objAppCodeTypeRelaEN;
            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel = new List<clsAppCodeTypeRelaEN>();
            foreach (clsAppCodeTypeRelaEN obj in arrAppCodeTypeRelaObjLst_Sel1)
            {
                arrAppCodeTypeRelaObjLst_Sel.Add(obj);
            }
            //if (arrAppCodeTypeRelaObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return arrAppCodeTypeRelaObjLst_Sel;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsAppCodeTypeRelaEN GetObjByAppAndCodeType(int intApplicationTypeId, string strCodeTypeId)
        {
            //初始化列表缓存
            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Cache = clsAppCodeTypeRelaWApi.GetObjLstCache();
            IEnumerable<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel1 =
            from objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjLst_Cache
            where objAppCodeTypeRelaEN.ApplicationTypeId == intApplicationTypeId
            && objAppCodeTypeRelaEN.CodeTypeId == strCodeTypeId
            select objAppCodeTypeRelaEN;

            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel = new List<clsAppCodeTypeRelaEN>();
            foreach (clsAppCodeTypeRelaEN obj in arrAppCodeTypeRelaObjLst_Sel1)
            {
                arrAppCodeTypeRelaObjLst_Sel.Add(obj);
            }
            if (arrAppCodeTypeRelaObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrAppCodeTypeRelaObjLst_Sel[0];
        }
    }
}