using AGC.BusinessLogic;
using AGC.Entity;
using System.Collections.Generic;

namespace AGC.BusinessLogicEx
{
    public partial class clsPrimaryTypeNameBLEx 
	{

		public const string 
			NONE_PRIMARYKEY = "00",
			PRIMARYKEY = "01",
			IDENTITY_PRIMARYKEY = "02";
		


		///生成绑定ListView的代码
		/// <summary>
		/// 函数功能:根据界面上查询控件中所设置内容查询表记录,
		///			 并显示在ListView中。
		/// </summary>
		public static int BindLv_PrimaryTypeName(System.Windows.Forms.ListView lvPrimaryTypeName, string strWhereCond)
		{
			//操作步骤:(共4步)
			//	1、组合界面条件串；
			//	2、根据条件串获取该表满足条件的DataTable；
			//	3、设置ListView的列头信息
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			//		在本界面中是把状态显示在控件lblRecCount中。

			System.Windows.Forms.ListViewItem lviPrimaryTypeName;
            List<clsPrimaryTypeEN> arrPrimaryTypeNameObjList;
			//	2、根据条件串获取该表满足条件的DataTable；
			arrPrimaryTypeNameObjList = clsPrimaryTypeBL.GetObjLst(strWhereCond);
			//	3、设置ListView的列头信息
			lvPrimaryTypeName.Items.Clear();//清除原来所有Item
			lvPrimaryTypeName.Columns.Clear();//清除原来所有列头信息
			lvPrimaryTypeName.Columns.Add("主键类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvPrimaryTypeName.Columns.Add("主键类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvPrimaryTypeName.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvPrimaryTypeName.View = System.Windows.Forms.View.Details;
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			foreach (clsPrimaryTypeEN objPrimaryType in arrPrimaryTypeNameObjList)
			{
				lviPrimaryTypeName = new System.Windows.Forms.ListViewItem();
				lviPrimaryTypeName.Tag = objPrimaryType.PrimaryTypeId;
				lviPrimaryTypeName.Text = objPrimaryType.PrimaryTypeId;
				lviPrimaryTypeName.SubItems.Add(objPrimaryType.PrimaryTypeName);
				lviPrimaryTypeName.SubItems.Add(objPrimaryType.Memo);
				lvPrimaryTypeName.Items.Add(lviPrimaryTypeName);
			}
			//	4、设置记录数的状态,
			//		在本界面中是把状态显示在控件txtRecCount中。
			return arrPrimaryTypeNameObjList.Count;
		}
	}
}