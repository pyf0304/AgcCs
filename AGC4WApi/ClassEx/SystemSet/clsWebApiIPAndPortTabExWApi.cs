
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsWebApiIPAndPortTabExWApi
表名:WebApiIPAndPortTab(00050529)
生成代码版本:2020.01.01.1
生成日期:2020/01/02 12:12:11
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:WA_访问扩展层(WA_AccessEx)
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

namespace AGC4WApi
{
    /// <summary>
    /// WebApiIP表(WebApiIPAndPortTab)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsWebApiIPAndPortTabExWApi
    {
        //private static readonly string mstrApiControllerName = "WebApiIPAndPortTabExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsWebApiIPAndPortTabExWApi()
        {
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "strFeatureTypeId">需要绑定当前表的下拉框</param>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_WebApiIPAndPortVirtualPath(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format(" 1=1  Order by {0}",
            conWebApiIPAndPortTab.OrderNum);

            List<clsWebApiIPAndPortTabEN> arrObjLst = clsWebApiIPAndPortTabWApi.GetObjLst(strCondition);
            arrObjLst.ForEach(x => x.WebApiIPAndPort = string.Format("{0}/{1}/Api/", x.WebApiIPAndPort, x.WebApiVirtualPath));
            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN()
            {
                mId = 0,
                WebApiIPAndPort = "选[WApiIP]..."
            };
            arrObjLst.Insert(0, objWebApiIPAndPortTabEN);
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conWebApiIPAndPortTab.mId;
            objComboBox.DisplayMember = conWebApiIPAndPortTab.WebApiIPAndPort;
            objComboBox.DataSource = arrObjLst;
            objComboBox.SelectedIndex = 0;
        }

    }
}