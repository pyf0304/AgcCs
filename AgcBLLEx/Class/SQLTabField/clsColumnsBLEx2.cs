using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.sql;
namespace AGC.BusinessLogicEx
{
    public class clsColumnsBLEx : clsColumns
    {


        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_Columns(System.Windows.Forms.ListView lvColumns, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviColumns;
            ArrayList arrColumnsObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrColumnsObjList = new clsColumns().GetColumnsObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvColumns.Items.Clear();//清除原来所有Item
            lvColumns.Columns.Clear();//清除原来所有列头信息
            lvColumns.Columns.Add("列名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvColumns.Columns.Add("数据类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvColumns.Columns.Add("字段长度", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvColumns.Columns.Add("是否可空", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvColumns.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsColumns objColumns in arrColumnsObjList)
            {
                lviColumns = new System.Windows.Forms.ListViewItem();
                lviColumns.Tag = objColumns.Column_Name;
                lviColumns.Text = objColumns.Column_Name;
                lviColumns.SubItems.Add(objColumns.Type_Name);
                lviColumns.SubItems.Add(objColumns.length.ToString());
                lviColumns.SubItems.Add(objColumns.Is_Nullable);
                lvColumns.Items.Add(lviColumns);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrColumnsObjList.Count;
        }
    }
}