
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMProjectExWApi
表名:CMProject(00050512)
生成代码版本:2020.01.01.1
生成日期:2020/01/02 12:09:36
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:代码管理
模块英文名:CodeMan
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
using System.Linq;
using AGC.BusinessLogic;

namespace AGC4WApi
{
    /// <summary>
    /// CM项目(CMProject)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsCMProjectExWApi
    {
        //private static readonly string mstrApiControllerName = "CMProjectExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsCMProjectEN> arrCMProjectObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsCMProjectExWApi()
        {
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">工程ID</param>
        public static void BindCbo_CmPrjIdEx0(System.Windows.Forms.ComboBox objComboBox, string strPrjId, int intApplicationTypeId, string strUserId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("1 =1 Order By {0}", conCMProject.CmPrjId);
            List<clsCMProjectEN> arrObjLst = clsCMProjectWApi.GetObjLst(strCondition);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId).ToList();


            List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLst_Cache = clsvCmProjectAppRelaWApi.GetObjLstCache(strPrjId);
            
            var arrvCmProjectAppRela_Sel = arrvCmProjectAppRelaObjLst_Cache.Where(x => x.ApplicationTypeId == intApplicationTypeId
                                 && x.PrjId == strPrjId);
            var arrvCmProjectAppRelaEx = arrvCmProjectAppRela_Sel.Select(clsvCmProjectAppRelaExWApi.CopyToEx).ToList();

            foreach(var objInFor in arrvCmProjectAppRelaEx)
            {
                objInFor.CmPrjAppName = $"{objInFor.CmPrjName}-{objInFor.ApplicationTypeSimName}";
            }
            if (arrvCmProjectAppRelaEx.Count == 0)
            {
                objComboBox.Enabled = false;
            }
            //var arrObjLst_Sel = arrObjLst.Where(x => arrCmPrjId_Sel.Contains(x.CmPrjId) == true).ToList();

            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsvCmProjectAppRelaENEx objCMProjectEN = new clsvCmProjectAppRelaENEx()
            {
                CMProjectAppRelaId = 0,
                CmPrjAppName = "选[CM项目]..."
            };
            arrvCmProjectAppRelaEx.Insert(0, objCMProjectEN);
            List<clsCMProjectEN> arrCMProject = new List<clsCMProjectEN>();

            foreach (var objInFor in arrvCmProjectAppRelaEx)
            {
                clsCMProjectEN objCMProject = new clsCMProjectEN();
                objCMProject.CmPrjId = objInFor.CmPrjId;
                objCMProject.CmPrjName = objInFor.CmPrjAppName;
                arrCMProject.Add(objCMProject);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conCMProject.CmPrjId;
            objComboBox.DisplayMember = conCMProject.CmPrjName;
            objComboBox.DataSource = arrCMProject;
            objComboBox.SelectedIndex = 0;
        }
        public static void BindCbo_CmPrjIdAppEx0(System.Windows.Forms.ComboBox objComboBox, string strPrjId, int intApplicationTypeId, string strUserId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("1 =1 Order By {0}", conCMProject.CmPrjId);
            List<clsCMProjectEN> arrObjLst = clsCMProjectWApi.GetObjLst(strCondition);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId).ToList();


            List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLst_Cache = clsvCmProjectAppRelaWApi.GetObjLstCache(strPrjId);

            var arrvCmProjectAppRela_Sel = arrvCmProjectAppRelaObjLst_Cache.Where(x => x.ApplicationTypeId == intApplicationTypeId
                                 && x.PrjId == strPrjId);
            var arrvCmProjectAppRelaEx = arrvCmProjectAppRela_Sel.Select(clsvCmProjectAppRelaExWApi.CopyToEx).ToList();

            foreach (var objInFor in arrvCmProjectAppRelaEx)
            {
                objInFor.CmPrjAppName = $"{objInFor.CmPrjName}-{objInFor.ApplicationTypeSimName}";
            }
            if (arrvCmProjectAppRelaEx.Count == 0)
            {
                objComboBox.Enabled = false;
            }
            //var arrObjLst_Sel = arrObjLst.Where(x => arrCmPrjId_Sel.Contains(x.CmPrjId) == true).ToList();

            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsvCmProjectAppRelaENEx objCMProjectEN = new clsvCmProjectAppRelaENEx()
            {
                CMProjectAppRelaId = 0,
                CmPrjAppName = "选[CM项目]..."
            };
            arrvCmProjectAppRelaEx.Insert(0, objCMProjectEN);
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conCMProjectAppRela.CMProjectAppRelaId;
            objComboBox.DisplayMember = "CmPrjAppName";
            objComboBox.DataSource = arrvCmProjectAppRelaEx;
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

        public static void BindCbo_CmPrjIdCacheEx(System.Windows.Forms.ComboBox objComboBox, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0} ='{1}' Order By {0}", conCMProject.PrjId, strPrjId, conCMProject.CmPrjId);
            List<clsCMProjectEN> arrObjLst = clsCMProjectWApi.GetObjLstCache();// (strPrjId);// (strCondition);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId).OrderBy(x=>x.CmPrjId).ToList();
            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsCMProjectEN objCMProjectEN = new clsCMProjectEN()
            {
                CmPrjId = "0",
                CmPrjName = "选[CM项目]..."
            };
            arrObjLst.Insert(0, objCMProjectEN);
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conCMProject.CmPrjId;
            objComboBox.DisplayMember = conCMProject.CmPrjName;
            objComboBox.DataSource = arrObjLst;
            objComboBox.SelectedIndex = 0;
        }

        public static List<clsCMProjectEN> GetObjLstByPrjIdExCache(string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("1 =1 Order By {0}", conCMProject.CmPrjId);
            List<clsCMProjectEN> arrObjLst = clsCMProjectWApi.GetObjLst(strCondition);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId).ToList();
            return arrObjLst;
        }
        public static string GetPrjIdByCmPrjIdCache(string strCmPrjId)
        {
            clsCMProjectEN objCMProjectEN = clsCMProjectWApi.GetObjByCmPrjIdCache(strCmPrjId);
            return objCMProjectEN.PrjId;
        }
    }
}