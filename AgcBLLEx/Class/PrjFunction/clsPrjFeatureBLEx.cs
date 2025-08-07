using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 功能类的扩展类
    /// </summary>
    public partial class clsPrjFeatureBLEx
    {
        internal static bool IsNeedFlds(string featureId)
        {
            clsPrjFeatureEN objFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(featureId);
            if (objFeature == null) return false;
            return objFeature.IsNeedField;
        }

        /// <summary>
        /// 获取前台(前端)的所有功能对象列表
        /// </summary>
        /// <returns>功能对象列表</returns>
        public static List<clsPrjFeatureENEx> GetObjExLst4FrontEnd()
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conPrjFeature.InUse);

            List<clsPrjFeatureENEx> arrObjENExList = new List<clsPrjFeatureENEx>();
            string strCondition = string.Format("{0} = '{1}'",
                conPrjFeature.FeatureTypeId, enumPrjFeatureType.FrontInterface_01);
            List<clsPrjFeatureEN> arrObjList = clsPrjFeatureBL.GetObjLst(strCondition);
            foreach (clsPrjFeatureEN objPrjFeatureEN in arrObjList)
            {
                clsPrjFeatureENEx objPrjFeatureENEx = new clsPrjFeatureENEx();
                CopyTo(objPrjFeatureEN, objPrjFeatureENEx);
                arrObjENExList.Add(objPrjFeatureENEx);
            }
            return arrObjENExList;
        }

        /// <summary>
        /// 获取后台(后端)的所有功能对象列表
        /// </summary>
        /// <returns>功能对象列表</returns>
        public static List<clsPrjFeatureENEx> GetObjExLst4BackEnd()
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conPrjFeature.InUse);

            List<clsPrjFeatureENEx> arrObjENExList = new List<clsPrjFeatureENEx>();
            string strCondition = string.Format("{0} = '{1}'",
                conPrjFeature.FeatureTypeId, enumPrjFeatureType.BackgroundFunction_02);
            List<clsPrjFeatureEN> arrObjList = clsPrjFeatureBL.GetObjLst(strCondition);
            foreach (clsPrjFeatureEN objPrjFeatureEN in arrObjList)
            {
                clsPrjFeatureENEx objPrjFeatureENEx = new clsPrjFeatureENEx();
                CopyTo(objPrjFeatureEN, objPrjFeatureENEx);
                arrObjENExList.Add(objPrjFeatureENEx);
            }
            return arrObjENExList;
        }



        /// <summary>
        /// 绑定基于Web的下拉框， 按功能名排序
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_FeatureIdExBak20170415(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format(" 1=1 Order by {0}", conPrjFeature.FeatureName);
            System.Data.DataTable objDT =  clsPrjFeatureBL.GetDataTable_PrjFeature(strCondition);
            objDDL.DataValueField = conPrjFeature.FeatureId;
            objDDL.DataTextField = conPrjFeature.FeatureName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定基于Web的下拉框， 按功能名排序
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_FeatureIdExByOrderNum(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format(" 1=1 Order by {0}", conPrjFeature.OrderNum);
           List<clsPrjFeatureEN> arrObjCache = clsPrjFeatureBL.GetObjLstCache()
                .OrderBy(x=>x.OrderNum)
                .ToList();
            objDDL.DataValueField = conPrjFeature.FeatureId;
            objDDL.DataTextField = conPrjFeature.FeatureName;
            objDDL.DataSource = arrObjCache;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定基于Web的下拉框， 按功能名排序
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strFeatureTypeId">需要绑定当前表的下拉框</param>
        public static void BindDdl_FeatureIdExByFeatureTypeId(System.Web.UI.WebControls.DropDownList objDDL, string strFeatureTypeId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
                      
            IEnumerable < clsvPrjFeatureEN > arrvPrjFeature =  clsvPrjFeatureBL.GetObjLstCache()
                .Where(x=>x.FeatureTypeId == strFeatureTypeId && x.InUse == true)
                .OrderBy(x=>x.OrderNum);

            objDDL.DataValueField = conPrjFeature.FeatureId;
            objDDL.DataTextField = conPrjFeature.FeatureName;
            objDDL.DataSource = arrvPrjFeature;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "strFeatureTypeId">需要绑定当前表的下拉框</param>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_FeatureIdExByFeatureTypeId(System.Windows.Forms.ComboBox objComboBox, string strFeatureTypeId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format(" 1=1 And {0}='{1}' and {2}='1' Order by {3}",
            conPrjFeature.FeatureTypeId,
            strFeatureTypeId,
            conPrjFeature.InUse,
            conPrjFeature.OrderNum);

            List<clsPrjFeatureEN> arrObjLst = clsPrjFeatureBL.GetObjLst(strCondition);
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

        public static void BindDdl_FeatureIdExByFeatureTypeId(System.Web.UI.WebControls.DropDownList objDDL, List<string> arrFeatureTypeId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format(" 1=1 And {0} in ({1}) Order by {2}, {3}",
            //    conPrjFeature.FeatureTypeId,
            //    clsArray.GetSqlInStrByArray(arrFeatureTypeId, true), conPrjFeature.FeatureTypeId, conPrjFeature.OrderNum);
            IEnumerable<clsvPrjFeatureEN> arrvPrjFeature = clsvPrjFeatureBL.GetObjLstCache()
           .Where(x => arrFeatureTypeId.Contains( x.FeatureTypeId ) && x.InUse == true)
           .OrderBy(x => x.FeatureTypeId)
            .ThenBy(x => x.OrderNum);

            List<clsvPrjFeatureEN> arrObjLst = arrvPrjFeature.ToList();
            arrObjLst.ForEach(x => {
                if (x.FeatureName.Contains(x.FeatureTypeName) == false) x.FeatureName = string.Format("{0}-{1}", x.FeatureName, x.FeatureTypeName); });
            objDDL.DataValueField = conPrjFeature.FeatureId;
            objDDL.DataTextField = conPrjFeature.FeatureName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据区域Id获取相关
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="intAppTypeId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsPrjFeatureENEx> GetObjExLstByViewIdBak(string strViewId, int intAppTypeId, string strPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conPrjFeature.InUse);
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);

            List<clsPrjFeatureENEx> arrObjENExList = new List<clsPrjFeatureENEx>();
            string strCondition = string.Format("{0} in (select {0} From {1} where {2} in ({3}))",
                conPrjFeature.FeatureId, clsvFeatureRegionFldsEN._CurrTabName, 
                convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));

            List<clsPrjFeatureEN> arrObjList = clsPrjFeatureBL.GetObjLst(strCondition);
            foreach (clsPrjFeatureEN objPrjFeatureEN in arrObjList)
            {
                clsPrjFeatureENEx objPrjFeatureENEx = new clsPrjFeatureENEx();
                CopyTo(objPrjFeatureEN, objPrjFeatureENEx);
                objPrjFeatureENEx.ButtonSet = clsvFeatureButtonRelaBLEx.GetObjLstByFeatureIdCacheEx(intAppTypeId, objPrjFeatureEN.FeatureId);
                if (objPrjFeatureENEx.ButtonSet == null)
                {
                    string strMsg = string.Format("应用:{0}({1}),功能:{2}({3})没有相关的按钮，请管理员！",
                        clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId).ApplicationTypeName, intAppTypeId,
                        objPrjFeatureEN.FeatureName, objPrjFeatureEN.FeatureId);
                    throw new Exception(strMsg);
                }
                arrObjENExList.Add(objPrjFeatureENEx);
            }
            return arrObjENExList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="intAppTypeId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsPrjFeatureENEx> GetObjExLstByViewIdCache(string strViewId, int intAppTypeId, string strPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conPrjFeature.InUse);

            List<clsPrjFeatureENEx> arrObjENExList = new List<clsPrjFeatureENEx>();
            //string strCondition = string.Format("{0} in (select {0} From {1} where {2}='{3}')",
            //    conPrjFeature.FeatureId, clsvFeatureRegionFldsEN._CurrTabName,
            //    convFeatureRegionFlds.ViewId, strViewId);
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);

            List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsCache = clsvFeatureRegionFldsBL.GetObjLstCache(strPrjId);
            
            List<clsvFeatureRegionFldsEN> arrvFeatureRegionFlds = arrvFeatureRegionFldsCache
                .Where(x => arrRegionId.Contains( x.RegionId))
                .ToList();

            IEnumerable<string> arrFeatureId = arrvFeatureRegionFlds.Select(x=>x.FeatureId);
            IEnumerable<clsPrjFeatureEN> arrObjListCache = clsPrjFeatureBL.GetObjLstCache();

            List<clsPrjFeatureEN> arrObjList = arrObjListCache
                .Where(x=>arrFeatureId.Contains(x.FeatureId))
                .ToList();
            
            foreach (clsPrjFeatureEN objPrjFeatureEN in arrObjList)
            {
                clsPrjFeatureENEx objPrjFeatureENEx = new clsPrjFeatureENEx();
                CopyTo(objPrjFeatureEN, objPrjFeatureENEx);
                objPrjFeatureENEx.ButtonSet = clsvFeatureButtonRelaBLEx.GetObjLstByFeatureIdCacheEx(intAppTypeId, objPrjFeatureEN.FeatureId);
                if (objPrjFeatureENEx.ButtonSet == null)
                {
                    string strMsg = string.Format("应用:{0}({1}),功能:{2}({3})没有相关的按钮，请管理员！",
                        clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId).ApplicationTypeName, intAppTypeId,
                        objPrjFeatureEN.FeatureName, objPrjFeatureEN.FeatureId);
                    throw new Exception(strMsg);
                }
                arrObjENExList.Add(objPrjFeatureENEx);
            }
            return arrObjENExList;
        }


        /// <summary>
        /// 根据界面Id获取功能Id列表
        /// </summary>
        /// <param name="strViewId"></param>
        /// <returns></returns>
        public static List<string> GetFeatureIdLstByViewIdBak(string strViewId, string strPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conPrjFeature.InUse);

            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            
            string strCondition = string.Format("{0} in (select {0} From {1} where {2} in ({3}))",
                conPrjFeature.FeatureId, clsvFeatureRegionFldsEN._CurrTabName,
            convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));
            List<string> arrFeatureId = clsPrjFeatureBL.GetPrimaryKeyID_S(strCondition);
            if (arrFeatureId == null) arrFeatureId = new List<string>();
            return arrFeatureId;
        }

        public static List<string> GetFeatureIdLstByViewIdCache(string strViewId, string strPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conPrjFeature.InUse);


            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);

            List<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsCache = clsvFeatureRegionFldsBL.GetObjLstCache(strPrjId);
            
            List<clsvFeatureRegionFldsEN> arrvFeatureRegionFlds = arrvFeatureRegionFldsCache
                .Where(x=> arrRegionId.Contains(x.RegionId)).ToList();
            //string strCondition = string.Format("{0} in (select {0} From {1} where {2}='{3}')",
            //    conPrjFeature.FeatureId, clsvFeatureRegionFldsEN._CurrTabName, convFeatureRegionFlds.ViewId, strViewId);
            List<string> arrFeatureId = arrvFeatureRegionFlds.Select(x=>x.FeatureId).ToList();// clsPrjFeatureBL.GetPrimaryKeyID_S(strCondition);
            if (arrFeatureId == null) arrFeatureId = new List<string>();
            return arrFeatureId;
        }
        /// <summary>
        /// 获取功能Id的子功能Id列表
        /// </summary>
        /// <param name="strFeatureId">功能Id</param>
        /// <param name="strFeatureTypeId">功能类型Id</param>
        /// <returns>子功能Id列表</returns>
        public static List<string> GetSubFeatureIdLstByFeatureId(string strFeatureId, string strFeatureTypeId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conPrjFeature.InUse);

            string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                conPrjFeature.ParentFeatureId, strFeatureId, conPrjFeature.FeatureTypeId, strFeatureTypeId);
            List<string> arrFeatureId = clsPrjFeatureBL.GetPrimaryKeyID_S(strCondition);
            if (arrFeatureId == null) arrFeatureId = new List<string>();
            return arrFeatureId;
        }
        /// <summary>
        /// 为界面功能获取相关的表功能
        /// </summary>
        /// <param name="strViewFeatureId">界面功能Id</param>
        /// <returns>表功能TabFeatureId</returns>
        public static string GetRelaFeatureId4Tab(string strViewFeatureId)
        {
            clsvFeatureRegionFldsEN obj = clsvFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
            if (obj == null) return "";
            if (string.IsNullOrEmpty(obj.FeatureName) == true) return "";
            string strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                conPrjFeature.FeatureName, obj.FeatureName,
                conPrjFeature.FeatureTypeId, enumPrjFeatureType.TabFeature_03);
            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetFirstObj_S(strCondition);
            if (objPrjFeature == null) return "";
            return objPrjFeature.FeatureId;
        }
    }
}
