using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AGC.BusinessLogicEx
{

    public class clsProgLangTypeBLEx : clsProgLangTypeBL
    {
        protected static int intFindFailCount = 0;
        /// <summary>
        /// 根据语言类型获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name = "cnLangType">所给的语言类型</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsProgLangTypeEN GetObjByLangTypeCache(clsPubConst.LangType cnLangType)
        {
            string strLangTypeName = clsPubConst.GetLangTypeStringByLangType(cnLangType);


            List<clsProgLangTypeEN> arrObjLstCache = clsProgLangTypeBL.GetObjLstCache();

            foreach (clsProgLangTypeEN objProgLangTypeEN in arrObjLstCache)
            {
                if (objProgLangTypeEN.ProgLangTypeName == strLangTypeName)
                {
                    intFindFailCount = 0;
                    return objProgLangTypeEN;
                }
            }
            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用

            CacheHelper.Remove(clsProgLangTypeEN._CurrTabName);
            if (intFindFailCount == 1) return GetObjByLangTypeCache(cnLangType);
            string strErrMsgForGetObjById = string.Format("在ProgLangType对象缓存列表中,找不到记录[cnLangType = {0}][intFindFailCount = {1}](函数:GetProgLangTypeObjByLangTypeCache)", strLangTypeName, intFindFailCount);
            clsLog.LogErrorS2("clsProgLangTypeBLEx", "GetProgLangTypeObjByLangTypeCache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        /// <summary>
        /// 根据语言类型获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name = "cnLangType">所给的语言类型</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetProgLangTypeIdByLangTypeCache(clsPubConst.LangType cnLangType)
        {
            string strLangTypeName = clsPubConst.GetLangTypeStringByLangType(cnLangType);


            List<clsProgLangTypeEN> arrObjLstCache = clsProgLangTypeBL.GetObjLstCache();

            foreach (clsProgLangTypeEN objProgLangTypeEN in arrObjLstCache)
            {
                if (objProgLangTypeEN.ProgLangTypeName == strLangTypeName)
                {
                    intFindFailCount = 0;
                    return objProgLangTypeEN.ProgLangTypeId;
                }
            }
            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            CacheHelper.Remove(clsProgLangTypeEN._CurrTabName);

            if (intFindFailCount == 1) return GetProgLangTypeIdByLangTypeCache(cnLangType);
            string strErrMsgForGetObjById = string.Format("在ProgLangType对象缓存列表中,找不到记录[cnLangType = {0}][intFindFailCount = {1}](函数:GetProgLangTypeIdByLangTypeCache)", strLangTypeName, intFindFailCount);
            clsLog.LogErrorS2("clsProgLangTypeBLEx", "GetProgLangTypeIdByLangTypeCache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objRadioButtonList">需要绑定当前表的下拉框</param>
        public static void BindRbl_ProgLangTypeIdEx(TzWinCtrlLib.TzRadioButtonList objRadioButtonList)
        {
            string strCondition = string.Format("{0}='1' order by {1}",
             conProgLangType.IsVisible,
             conProgLangType.OrderNum);
            DataTable objDT = clsProgLangTypeBL.GetDataTable(strCondition);
            objRadioButtonList.DisplayMember = conProgLangType.ProgLangTypeName;
            objRadioButtonList.ValueMember = conProgLangType.ProgLangTypeId;
            objRadioButtonList.DataSource = objDT;
            //tzRadioButtonList1.DataSource = arrKcCrsTypeObjLst;
            objRadioButtonList.DataBind();

        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_ProgLangTypeIdEx(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0}='1' Order by {1}",
                conProgLangType.IsVisible, conProgLangType.OrderNum);
            System.Data.DataTable objDT = clsProgLangTypeBL.GetDataTable(strCondition);
            clsProgLangTypeEN objProgLangTypeEN;
            //初始化一个对象列表
            ArrayList ProgLangTypeList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objProgLangTypeEN = new clsProgLangTypeEN();
            objProgLangTypeEN.ProgLangTypeId = "0";
            objProgLangTypeEN.ProgLangTypeName = "请选择...";
            ProgLangTypeList.Add(objProgLangTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objProgLangTypeEN = new clsProgLangTypeEN();
                objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString();
                objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString();
                ProgLangTypeList.Add(objProgLangTypeEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conProgLangType.ProgLangTypeId;
            objComboBox.DisplayMember = conProgLangType.ProgLangTypeName;
            objComboBox.DataSource = ProgLangTypeList;
            objComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_ProgLangTypeIdExCache(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format(" {0} = '1' Order By {1}", 
            //    conProgLangType.IsVisible,
            //    conProgLangType.ProgLangTypeId);
            IEnumerable<clsProgLangTypeEN> arrObjLst
                = clsProgLangTypeBL.GetObjLstCache()
                .Where(x => x.IsVisible == true);
            //System.Data.DataTable objDT = clsProgLangTypeBL.GetDataTable(strCondition);
            objDDL.DataValueField = conProgLangType.ProgLangTypeId;
            objDDL.DataTextField = conProgLangType.ProgLangTypeName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
  
        //protected static int intFindFailCount = 0;
        /// <summary>
        /// 根据语言类型获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name = "cnLangType">所给的语言类型</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsProgLangTypeEN GetObjByLangType_Cache(clsPubConst.LangType cnLangType)
        {
            string strLangTypeName = clsPubConst.GetLangTypeStringByLangType(cnLangType);


            List<clsProgLangTypeEN> arrObjLst_Cache = clsProgLangTypeBL.GetObjLstCache();

            foreach (clsProgLangTypeEN objProgLangTypeEN in arrObjLst_Cache)
            {
                if (objProgLangTypeEN.ProgLangTypeName == strLangTypeName)
                {
                    intFindFailCount = 0;
                    return objProgLangTypeEN;
                }
            }
            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            
            CacheHelper.Remove(clsProgLangTypeEN._CurrTabName);
            if (intFindFailCount == 1) return GetObjByLangType_Cache(cnLangType);
            string strErrMsgForGetObjById = string.Format("在ProgLangType对象缓存列表中,找不到记录[cnLangType = {0}][intFindFailCount = {1}](函数:GetProgLangTypeObjByLangType_Cache)", strLangTypeName, intFindFailCount);
            clsLog.LogErrorS2("clsProgLangTypeBLEx", "GetProgLangTypeObjByLangType_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        /// <summary>
        /// 根据语言类型获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name = "cnLangType">所给的语言类型</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetProgLangTypeIdByLangType_Cache(clsPubConst.LangType cnLangType)
        {
            string strLangTypeName = clsPubConst.GetLangTypeStringByLangType(cnLangType);


            List<clsProgLangTypeEN> arrObjLst_Cache = clsProgLangTypeBL.GetObjLstCache();

            foreach (clsProgLangTypeEN objProgLangTypeEN in arrObjLst_Cache)
            {
                if (objProgLangTypeEN.ProgLangTypeName == strLangTypeName)
                {
                    intFindFailCount = 0;
                    return objProgLangTypeEN.ProgLangTypeId;
                }
            }
            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            CacheHelper.Remove(clsProgLangTypeEN._CurrTabName);

            if (intFindFailCount == 1) return GetProgLangTypeIdByLangType_Cache(cnLangType);
            string strErrMsgForGetObjById = string.Format("在ProgLangType对象缓存列表中,找不到记录[cnLangType = {0}][intFindFailCount = {1}](函数:GetProgLangTypeIdByLangType_Cache)", strLangTypeName, intFindFailCount);
            clsLog.LogErrorS2("clsProgLangTypeBLEx", "GetProgLangTypeIdByLangType_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }
        ///// <summary>
        ///// 绑定基于Win的下拉框
        ///// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        ///// </summary>
        ///// <param name = "objRadioButtonList">需要绑定当前表的下拉框</param>
        //public static void BindRbl_ProgLangTypeIdEx(TzWinCtrlLib.TzRadioButtonList objRadioButtonList)
        //{
        //    string strCondition = string.Format("{0}='1' order by {1}",
        //     conProgLangType.IsVisible,
        //     conProgLangType.OrderNum);
        //    DataTable objDT = clsProgLangTypeBL.GetDataTable(strCondition);
        //    objRadioButtonList.DisplayMember = conProgLangType.ProgLangTypeName;
        //    objRadioButtonList.ValueMember = conProgLangType.ProgLangTypeId;
        //    objRadioButtonList.DataSource = objDT;
        //    //tzRadioButtonList1.DataSource = arrKcCrsTypeObjLst;
        //    objRadioButtonList.DataBind();

        //}
        ///// <summary>
        ///// 绑定基于Win的下拉框
        ///// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        ///// </summary>
        ///// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        //public static void BindCbo_ProgLangTypeIdEx(System.Windows.Forms.ComboBox objComboBox)
        //{
        //    //为数据源为表的下拉框设置内容
        //    string strCondition = string.Format("{0}='1' Order by {1}", 
        //        conProgLangType.IsVisible, conProgLangType.OrderNum);
        //    System.Data.DataTable objDT =  clsProgLangTypeBL.GetDataTable(strCondition);
        //    clsProgLangTypeEN objProgLangTypeEN;
        //    //初始化一个对象列表
        //    ArrayList ProgLangTypeList = new ArrayList();
        //    //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
        //    objProgLangTypeEN = new clsProgLangTypeEN();
        //    objProgLangTypeEN.ProgLangTypeId = "0";
        //    objProgLangTypeEN.ProgLangTypeName = "请选择...";
        //    ProgLangTypeList.Add(objProgLangTypeEN);
        //    //把DataTable中的所有项均加到对象列表中
        //    foreach (DataRow objRow in objDT.Rows)
        //    {
        //        objProgLangTypeEN = new clsProgLangTypeEN();
        //        objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString();
        //        objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString();
        //        ProgLangTypeList.Add(objProgLangTypeEN);
        //    }
        //    //设置下拉框的数据源、以及设置值项、显示项
        //    objComboBox.ValueMember = conProgLangType.ProgLangTypeId;
        //    objComboBox.DisplayMember = conProgLangType.ProgLangTypeName;
        //    objComboBox.DataSource = ProgLangTypeList;
        //    objComboBox.SelectedIndex = 0;
        //}
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_ProgLangTypeIdEx_Cache(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format(" {0} = '1' Order By {1}", 
            //    conProgLangType.IsVisible,
            //    conProgLangType.ProgLangTypeId);
            IEnumerable<clsProgLangTypeEN> arrObjLst 
                = clsProgLangTypeBL.GetObjLstCache()
                .Where(x => x.IsVisible == true);
            //System.Data.DataTable objDT = clsProgLangTypeBL.GetDataTable(strCondition);
            objDDL.DataValueField = conProgLangType.ProgLangTypeId;
            objDDL.DataTextField = conProgLangType.ProgLangTypeName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}
