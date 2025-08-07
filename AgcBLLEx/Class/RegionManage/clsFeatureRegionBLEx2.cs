
///----------------------
///生成代码版本:2012.01.02.1
///生成日期:2012/10/08
///生成者:潘以锋
///工程名称:AGC
///工程ID:0005
///模块中文名:区域管理
///模块英文名:RegionManage
///注意:1、需要数据底层(PubDataBase.dll)的版本:2011.05.08.1
///       2、需要公共函数层(TzPubFunction.dll)的版本:2011.05.08.1
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;using CommonTable.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 功能区域信息(FeatureRegion)
    /// </summary>
    public partial class clsFeatureRegionBLEx 
    {

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_FeatureRegion(System.Windows.Forms.ListView lvFeatureRegion, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviFeatureRegion;
            List<clsFeatureRegionEN> arrFeatureRegionObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrFeatureRegionObjList = clsFeatureRegionBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvFeatureRegion.Items.Clear();//清除原来所有Item
            lvFeatureRegion.Columns.Clear();//清除原来所有列头信息
            lvFeatureRegion.Columns.Add("区域Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegion.Columns.Add("按钮样式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegion.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegion.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsFeatureRegionEN objFeatureRegion in arrFeatureRegionObjList)
            {
                lviFeatureRegion = new System.Windows.Forms.ListViewItem();
                lviFeatureRegion.Tag = objFeatureRegion.RegionId;
                lviFeatureRegion.Text = objFeatureRegion.RegionId.ToString();
                lviFeatureRegion.SubItems.Add(objFeatureRegion.Memo);
                lvFeatureRegion.Items.Add(lviFeatureRegion);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrFeatureRegionObjList.Count;
        }

        public void InitViewRegion(clsFeatureRegionENEx objFeatureRegionENEx)
        {
     
            objFeatureRegionENEx.objViewRegionEN = clsViewRegionBL.GetObjByRegionId(objFeatureRegionENEx.RegionId);
	
        }
    }
}