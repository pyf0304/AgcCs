
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsSQLDSTypeExWApi
表名:SQLDSType(00050014)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:27
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

namespace AGC4WApi
{
    /// <summary>
    /// Sql数据源类型(SQLDSType)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsSQLDSTypeExWApi
    {
        //private static readonly string mstrApiControllerName = "SQLDSTypeExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsSQLDSTypeEN> arrSQLDSTypeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsSQLDSTypeExWApi()
        {
        }

        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

        public static void BindCbo_SqlDsTypeIdCache(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("1 =1 Order By {0}", conSQLDSType.SqlDsTypeId);
            List<clsSQLDSTypeEN> arrObjLst = clsSQLDSTypeWApi.GetObjLstCache();
            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsSQLDSTypeEN objSQLDSTypeEN = new clsSQLDSTypeEN()
            {
                SqlDsTypeId = "0",
                SqlDsTypeName = "选[数据源类型]..."
            };
            arrObjLst.Insert(0, objSQLDSTypeEN);
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conSQLDSType.SqlDsTypeId;
            objComboBox.DisplayMember = conSQLDSType.SqlDsTypeName;
            objComboBox.DataSource = arrObjLst;
            objComboBox.SelectedIndex = 0;
        }

    }
}