
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFuncModule_AgcExWApi
表名:FuncModule_Agc(00050015)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:27
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
using System.Linq;

namespace AGC4WApi
{
    /// <summary>
    /// 功能模块_Agc(FuncModule_Agc)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsFuncModule_AgcExWApi
    {
        //private static readonly string mstrApiControllerName = "FuncModule_AgcExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsFuncModule_AgcExWApi()
        {
        }
        public static void BindCbo_FuncModuleIdCache(System.Windows.Forms.ComboBox objComboBox, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("PrjId = '{0}' And UseStateId = '0001' Order by FuncModuleName", strPrjId);
            List<clsFuncModule_AgcEN> arrObjLst = clsFuncModule_AgcWApi.GetObjLstCache(strPrjId);
            arrObjLst = arrObjLst.Where(x => x.UseStateId == "0001").OrderBy(x=>x.FuncModuleName).ToList() ;
            clsFuncModule_AgcEN objFuncModuleEN;
            //初始化一个对象列表
            ArrayList FuncModuleList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objFuncModuleEN = new clsFuncModule_AgcEN();
            objFuncModuleEN.FuncModuleAgcId = "0";
            objFuncModuleEN.FuncModuleName = "请选择...";
            FuncModuleList.Add(objFuncModuleEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsFuncModule_AgcEN objInFor in arrObjLst)
            {          
                FuncModuleList.Add(objInFor);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = FuncModuleList;
            objComboBox.ValueMember = "FuncModuleAgcId";
            objComboBox.DisplayMember = "FuncModuleName";
            objComboBox.SelectedIndex = 0;
        }

    }
}