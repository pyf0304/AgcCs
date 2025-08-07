using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.commdb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AGC.BusinessLogicEx
{
    public partial class clsViewTypeCodeTabBLEx : clsViewTypeCodeTabBL
    {
        public const enumViewTypeCodeTab
            JAVA_ADD = enumViewTypeCodeTab.Table_Insert_1,// "0013", //JAVA单表插入
            JAVA_LIST = enumViewTypeCodeTab.Table_List_14,// "0014", //JAVA列表界面
            JAVA_QUERY = enumViewTypeCodeTab.Table_Query_3,//  "0015", //JAVA单表查询
            JAVA_UPDATE = enumViewTypeCodeTab.Table_Update_2,// "0016", //JAVA单表修改
            JAVA_DETAIL = enumViewTypeCodeTab.Table_Detail_17;// "0017"; //JAVA详细信息界面


      
        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_ViewTypeCodeTab(System.Windows.Forms.ListView lvViewTypeCodeTab, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviViewTypeCodeTab;
            List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrViewTypeCodeTabObjList = clsViewTypeCodeTabBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvViewTypeCodeTab.Items.Clear();//清除原来所有Item
            lvViewTypeCodeTab.Columns.Clear();//清除原来所有列头信息
            lvViewTypeCodeTab.Columns.Add("界面类型码", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("界面类型名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("界面功能", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("操作流程", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("界面说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("应用程序类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsViewTypeCodeTabEN objViewTypeCodeTab in arrViewTypeCodeTabObjList)
            {
                lviViewTypeCodeTab = new System.Windows.Forms.ListViewItem();
                lviViewTypeCodeTab.Tag = objViewTypeCodeTab.ViewTypeCode;
                lviViewTypeCodeTab.Text = objViewTypeCodeTab.ViewTypeCode.ToString("00");
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.ViewTypeName);
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.ViewFunction);
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.OptProcess);
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.ViewDetail);
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.ApplicationTypeId.ToString("00"));
                lvViewTypeCodeTab.Items.Add(lviViewTypeCodeTab);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrViewTypeCodeTabObjList.Count;
        }
        /// <summary>
        /// 所给的界面类型代码是否是Win应用
        /// </summary>
        /// <param name="thisViewTypeCodeTab">所给的界面类型代码</param>
        /// <returns></returns>
        public static bool IsWinViewTypeCode(enumViewTypeCodeTab thisViewTypeCodeTab)
        {
            clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCode((int)thisViewTypeCodeTab);
            return objViewTypeCodeTabEN.IsWinApp;
        }

        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunctionCache)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strApplicationTypeId">需要绑定当前表的下拉框</param>
        public static void BindDdl_ViewTypeCodeByAppIdCache(System.Web.UI.WebControls.DropDownList objDDL, int strApplicationTypeId)
        {
            if (strApplicationTypeId == 0) return;
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst = GetViewTypeCodeTabObjLstByApplicationTypeIdCache(strApplicationTypeId);
            if (arrViewTypeCodeTabObjLst == null)
            {
                return;
                //string strMsg = string.Format("应用:[{0}]没有相应的页面类型，请联系管理员！", clsApplicationTypeBL.GetNameByApplicationTypeIdCache(strApplicationTypeId));
                //throw new Exception(strMsg);
            }
            IEnumerable<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel = arrViewTypeCodeTabObjLst.OrderBy(x => x.OrderNum);
            objDDL.DataValueField = conViewTypeCodeTab.ViewTypeCode;
            objDDL.DataTextField = conViewTypeCodeTab.ViewTypeName;
            objDDL.DataSource = arrViewTypeCodeTabObjLst_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetRecObjByKeyCache)
        /// </summary>
        /// <param name = "intApplicationTypeId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsViewTypeCodeTabEN> GetViewTypeCodeTabObjLstByApplicationTypeIdCache(int intApplicationTypeId)
        {
            //初始化列表缓存
            List<clsViewTypeCodeTabEN> arrObjLstCache = clsViewTypeCodeTabBL.GetObjLstCache();

            IEnumerable<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel1 =
            from objViewTypeCodeTabEN in arrObjLstCache
            where objViewTypeCodeTabEN.ApplicationTypeId == intApplicationTypeId
            select objViewTypeCodeTabEN;
            List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel = new List<clsViewTypeCodeTabEN>();
            foreach (clsViewTypeCodeTabEN obj in arrViewTypeCodeTabObjLst_Sel1)
            {
                arrViewTypeCodeTabObjLst_Sel.Add(obj);
            }
            if (arrViewTypeCodeTabObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrViewTypeCodeTabObjLst_Sel;
        }

    }
}