
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewTypeCodeTabExWApi
表名:ViewTypeCodeTab(00050104)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:55
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
using System.Windows.Forms;
using System.Linq;


namespace AGC4WApi
{
    /// <summary>
    /// 界面类型码表(ViewTypeCodeTab)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsViewTypeCodeTabExWApi
    {
        public static List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst = null;
        public static bool bolIsSelectIndexAfterBindCbo = false;
        //private static readonly string mstrApiControllerName = "ViewTypeCodeTabExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        //public static List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsViewTypeCodeTabExWApi()
        {
        }

        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction_Cache)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strApplicationTypeId">需要绑定当前表的下拉框</param>
        public static void BindCbo_ViewTypeCodeByAppIdCache(ComboBox objComboBox, int intApplicationTypeId)
        {
            if (intApplicationTypeId == 0) return;
            bolIsSelectIndexAfterBindCbo = true;
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            arrViewTypeCodeTabObjLst = clsViewTypeCodeTabWApi.GetObjLstCache()
                .Where(x => x.ApplicationTypeId == intApplicationTypeId)
                .OrderBy(x=>x.OrderNum)
                .ToList();
                //GetViewTypeCodeTabObjLstByApplicationTypeIdCache(strApplicationTypeId);
            if (arrViewTypeCodeTabObjLst == null)
            {
                string strMsg = string.Format("应用:[{0}]没有相应的页面类型，请联系管理员！", clsApplicationTypeWApi.GetNameByApplicationTypeIdCache(intApplicationTypeId));
                throw new Exception(strMsg);
            }
            //List<clsViewTypeCodeTabEN> arrObjLst_Sel = arrViewTypeCodeTabObjLst.ToList();
            clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
            objViewTypeCodeTabEN.ViewTypeCode = 0;
            objViewTypeCodeTabEN.ViewTypeName = "请选择...";
            arrViewTypeCodeTabObjLst.Insert(0, objViewTypeCodeTabEN);
            objComboBox.DataSource = arrViewTypeCodeTabObjLst;
            objComboBox.ValueMember = conViewTypeCodeTab.ViewTypeCode;
            objComboBox.DisplayMember = conViewTypeCodeTab.ViewTypeName;
            bolIsSelectIndexAfterBindCbo = true;
            if (arrViewTypeCodeTabObjLst.Count > 1)
            {
         
                objComboBox.SelectedIndex = 1;
            }
            else
            {
                objComboBox.SelectedIndex = 0;
            }
        }

    }
}