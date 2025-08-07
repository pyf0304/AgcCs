
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPrjDataBaseExWApi
表名:PrjDataBase(00050176)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:00:27
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:工程管理
模块英文名:PrjManage
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
    /// 数据库对象(PrjDataBase)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsPrjDataBaseExWApi
    {
        //private static readonly string mstrApiControllerName = "PrjDataBaseExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsPrjDataBaseEN> arrPrjDataBaseObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsPrjDataBaseExWApi()
        {
        }
        public static void BindCbo_PrjDataBaseIdEx(System.Windows.Forms.ComboBox objComboBox, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("UseStateId = '0001' and PrjDataBaseId in (Select PrjDataBaseId from ProjectDatabaseRel where PrjId = '{0}')  Order By PrjDataBaseName", strPrjId);
            List<clsPrjDataBaseEN> arrObj = clsPrjDataBaseWApi.GetObjLst(strCondition);
            clsPrjDataBaseEN objPrjDataBaseEN;
            //初始化一个对象列表
            ArrayList PrjDataBaseList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objPrjDataBaseEN = new clsPrjDataBaseEN();
            objPrjDataBaseEN.PrjDataBaseId = "0";
            objPrjDataBaseEN.PrjDataBaseName = "请选择...";
            PrjDataBaseList.Add(objPrjDataBaseEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsPrjDataBaseEN objRow in arrObj)
            {
                PrjDataBaseList.Add(objRow);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjDataBaseList;
            objComboBox.ValueMember = "PrjDataBaseId";
            objComboBox.DisplayMember = "PrjDataBaseName";
            objComboBox.SelectedIndex = 0;
        }

    }
}