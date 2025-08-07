
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewInfoExWApi
表名:ViewInfo(00050006)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:24
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:界面管理
模块英文名:PrjInterface
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
    /// 界面(ViewInfo)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsViewInfoExWApi
    {
        //private static readonly string mstrApiControllerName = "ViewInfoExApi";

        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsViewInfoExWApi()
        {
        }
     
        /// <summary>
        /// 根据区域Id获取用户绑定下拉框的相关表Id
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<string> getRelaTabId4Ddl(string strViewId, string strCmPrjId, string strPrjId)
        {
            List<string> arrTabId = new List<string>();
            {
                string lngRegionId_Edit = clsViewRegionExWApi.GetRegionIdByTypeCache(strViewId, clsRegionTypeENEx.EDITREGION, strCmPrjId);
                if (string.IsNullOrEmpty( lngRegionId_Edit ) == false)
                {
                    List<string> arrTabId_Edit = clsEditRegionFldsExWApi.getRelaTabId4Ddl(lngRegionId_Edit, strPrjId);
                    arrTabId.AddRange(arrTabId_Edit);
                }
            }
            {
                string lngRegionId_Qry = clsViewRegionExWApi.GetRegionIdByTypeCache(strViewId, clsRegionTypeENEx.QUERYREGION, strCmPrjId);
                if (string.IsNullOrEmpty(lngRegionId_Qry) == false )
                {
                    List<string> arrTabId_Qry = clsQryRegionFldsExWApi.getRelaTabId4Ddl(lngRegionId_Qry, strPrjId);
                    foreach (string strTabId in arrTabId_Qry)
                    {
                        if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
                    }
                }
            }

            return arrTabId;
        }
        /// <summary>
        /// 根据界面Id获取输入输出的相关表Id
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<string> getRelaTabId4InOut(string strViewId, string strPrjId)
        {
            List<string> arrTabId = new List<string>();
            {
                clsViewInfoEN objViewInfoEN = clsViewInfoWApi.GetObjByViewIdCache(strViewId, strPrjId);
                string strTabId_In = objViewInfoEN.InRelaTabId;
                string strTabId_Out = objViewInfoEN.OutRelaTabId;

                if (string.IsNullOrEmpty(strTabId_In) == false)
                {
                    if (arrTabId.Contains(strTabId_In) == false) arrTabId.Add(strTabId_In);
                }
                if (string.IsNullOrEmpty(strTabId_Out) == false)
                {
                    if (arrTabId.Contains(strTabId_Out) == false) arrTabId.Add(strTabId_Out);
                }
            }

            return arrTabId;
        }
     
    }
}