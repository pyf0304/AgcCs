
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsApplicationTypeExWApi
表名:ApplicationType(00050127)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:00:06
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

namespace AGC4WApi
{
    /// <summary>
    /// 应用程序类型(ApplicationType)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsApplicationTypeExWApi
    {
        public const int
           WINDOWSAPP = 1, //命令按钮
           DOTNETWEBAPP = 2, //检查框
           AspMvcAPP = 13, //检查框
           JAVAWEBAPP = 3, //检查框列表
           ANDROIDAPP = 5; //检查框列表

        //private static readonly string mstrApiControllerName = "ApplicationTypeExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsApplicationTypeEN> arrApplicationTypeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsApplicationTypeExWApi()
        {
        }

        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_ApplicationTypeIdEx(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0} = '1' Order By {1}", conApplicationType.IsVisible, conApplicationType.OrderNum);
        List<clsApplicationTypeEN>    arrObj = clsApplicationTypeWApi.GetObjLst(strCondition);
            clsApplicationTypeEN objApplicationTypeEN;
            //初始化一个对象列表
            ArrayList ApplicationTypeList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objApplicationTypeEN = new clsApplicationTypeEN();
            objApplicationTypeEN.ApplicationTypeId = 0;
            objApplicationTypeEN.ApplicationTypeName = "请选择...";
            ApplicationTypeList.Add(objApplicationTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsApplicationTypeEN objRow in arrObj)
            {
            
                ApplicationTypeList.Add(objRow);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conApplicationType.ApplicationTypeId;
            objComboBox.DisplayMember = conApplicationType.ApplicationTypeName;
            objComboBox.DataSource = ApplicationTypeList;
            objComboBox.SelectedIndex = 0;
        }

    }
}