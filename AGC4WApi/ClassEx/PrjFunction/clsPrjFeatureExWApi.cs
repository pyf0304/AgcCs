
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPrjFeatureExWApi
表名:PrjFeature(00050322)
生成代码版本:2020.01.01.1
生成日期:2020/01/02 14:43:59
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:函数管理
模块英文名:PrjFunction
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
using AGC.Entity;

using System.Collections.Generic;
using com.taishsoft.json;
using System.Linq;

namespace AGC4WApi
{
    /// <summary>
    /// 功能(PrjFeature)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsPrjFeatureExWApi
    {
        //private static readonly string mstrApiControllerName = "PrjFeatureExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsPrjFeatureEN> arrPrjFeatureObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsPrjFeatureExWApi()
        {
        }
        public static void BindCbo_FeatureIdExByFeatureTypeIdCache(System.Windows.Forms.ComboBox objComboBox, string strFeatureTypeId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format(" 1=1 And {0}='{1}' and {2}='1' Order by {3}",
            conPrjFeature.FeatureTypeId,
            strFeatureTypeId,
            conPrjFeature.InUse,
            conPrjFeature.OrderNum);

            List<clsPrjFeatureEN> arrObjLst = clsPrjFeatureWApi.GetObjLstCache();// (strCondition);
            arrObjLst = arrObjLst.Where(x => x.FeatureTypeId == strFeatureTypeId && x.InUse == true).OrderBy(x=>x.OrderNum).ToList();
            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN()
            {
                FeatureId = "0",
                FeatureName = "请选择[功能]..."
            };
            arrObjLst.Insert(0, objPrjFeatureEN);
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conPrjFeature.FeatureId;
            objComboBox.DisplayMember = conPrjFeature.FeatureName;
            objComboBox.DataSource = arrObjLst;
            objComboBox.SelectedIndex = 0;
        }

    }
}