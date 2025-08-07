using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.commexception;
using com.taishsoft.common;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
	public partial class clsQueryRegionBLEx 
	{
        /// <summary>
        /// 根据区域Id获取用户绑定下拉框的相关表Id
        /// </summary>
        /// <param name="lngRegionId"></param>
        /// <returns></returns>
        public static List<string> getRelaTabId4Ddl2(string lngRegionId, bool bolIsFstLcase, string strPrjId, string strViewId)
        {
            string strCondition = string.Format("{0}={1}",
                conQryRegionFlds.RegionId, lngRegionId);

            List<string> arrTabId = new List<string>();
            List<clsQryRegionFldsENEx> arrObjENExList = clsQryRegionFldsBLEx.GetObjExLstByRegionIdCache4InUse2(lngRegionId, bolIsFstLcase, strPrjId, strViewId);

            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in arrObjENExList)
            {
                if (objQryRegionFldsEx.CtlTypeId != enumCtlType.DropDownList_06) continue;
                string strTabId = objQryRegionFldsEx.DsTabId;
                if (string.IsNullOrEmpty(strTabId) == true) continue;
                if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
            }

            return arrTabId;
        }

  //      public static void InitViewRegion(clsQueryRegionENEx objQueryRegionENEx)
		//{
  //          objQueryRegionENEx.objViewRegionEN = clsViewRegionBL.GetObjByRegionId(objQueryRegionENEx.RegionId);
		//}


		/////生成绑定ListView的代码
		///// <summary>
		///// 函数功能:根据界面上查询控件中所设置内容查询表记录,
		/////			 并显示在ListView中。
		///// </summary>
		//public static int BindLv_QueryRegion(System.Windows.Forms.ListView lvQueryRegion, string strWhereCond)
		//{
		//	//操作步骤:(共4步)
		//	//	1、组合界面条件串；
		//	//	2、根据条件串获取该表满足条件的DataTable；
		//	//	3、设置ListView的列头信息
		//	//	4、设置ListView的Item信息。即把所有记录显示在ListView中
		//	//		在本界面中是把状态显示在控件lblRecCount中。

		//	System.Windows.Forms.ListViewItem lviQueryRegion;
  //          List<clsQueryRegionEN> arrQueryRegionObjList;
		//	//	2、根据条件串获取该表满足条件的DataTable；
		//	arrQueryRegionObjList = clsQueryRegionBL.GetObjLst(strWhereCond);
		//	//	3、设置ListView的列头信息
		//	lvQueryRegion.Items.Clear();//清除原来所有Item
		//	lvQueryRegion.Columns.Clear();//清除原来所有列头信息
		//	lvQueryRegion.Columns.Add("区域Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvQueryRegion.Columns.Add("列数", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvQueryRegion.Columns.Add("是否使用控件", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvQueryRegion.View = System.Windows.Forms.View.Details;
		//	//	4、设置ListView的Item信息。即把所有记录显示在ListView中
		//	foreach (clsQueryRegionEN objQueryRegion in arrQueryRegionObjList)
		//	{
		//		lviQueryRegion = new System.Windows.Forms.ListViewItem();
		//		lviQueryRegion.Tag = objQueryRegion.RegionId;
		//		lviQueryRegion.Text = objQueryRegion.RegionId.ToString();
		//		//lviQueryRegion.SubItems.Add(objQueryRegion.ColNum.ToString());
		//		lviQueryRegion.SubItems.Add(objQueryRegion.IsUseCtrl.ToString());
		//		lvQueryRegion.Items.Add(lviQueryRegion);
		//	}
		//	//	4、设置记录数的状态,
		//	//		在本界面中是把状态显示在控件txtRecCount中。
		//	return arrQueryRegionObjList.Count;
		//}
	
	}
}