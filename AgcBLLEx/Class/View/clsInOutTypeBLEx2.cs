using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
	public partial class clsInOutTypeBLEx 
	{
		
		

        //public static System.Data.DataTable GetInOutTypeId()
        //{
        //    //获取某学院所有专业信息
        //    string strSQL = "select InOutTypeId, InOutTypeName from InOutType ";
        //    clsSpecSQLforSql mySql = new clsSpecSQLforSql();
        //    System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
        //    return objDT;
        //}
        //public static void BindCbo_InOutTypeId(System.Windows.Forms.ComboBox objComboBox)
        //{
        //    //为数据源为表的下拉框设置内容
        //    System.Data.DataTable objDT = GetInOutTypeId();
        //    clsInOutTypeEN objInOutType;
        //    //初始化一个对象列表
        //    ArrayList InOutTypeList = new ArrayList();
        //    //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
        //    objInOutType = new clsInOutTypeEN();
        //    objInOutType.InOutTypeId = "0";
        //    objInOutType.InOutTypeName = "请选择...";
        //    InOutTypeList.Add(objInOutType);
        //    //把DataTable中的所有项均加到对象列表中
        //    foreach(DataRow objRow in objDT.Rows)
        //    {
        //        objInOutType = new clsInOutTypeEN();
        //        objInOutType.InOutTypeId = objRow["InOutTypeId"].ToString();
        //        objInOutType.InOutTypeName = objRow["InOutTypeName"].ToString();
        //        InOutTypeList.Add(objInOutType);
        //    }
        //    //设置下拉框的数据源、以及设置值项、显示项
        //    objComboBox.DataSource = InOutTypeList;
        //    objComboBox.ValueMember = "InOutTypeId";
        //    objComboBox.DisplayMember = "InOutTypeName";
        //    objComboBox.SelectedIndex = 0;
        //}

		///绑定下拉框的函数 代码
        //public static void BindDdl_InOutTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...","0");
        //    System.Data.DataTable objDT = GetInOutTypeId();
        //    objDDL.DataValueField = "InOutTypeId";
        //    objDDL.DataTextField = "InOutTypeName";
        //    objDDL.DataSource = objDT;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}

		///生成绑定ListView的代码
		/// <summary>
		/// 函数功能:根据界面上查询控件中所设置内容查询表记录,
		///			 并显示在ListView中。
		/// </summary>
		public static int BindLv_InOutType(System.Windows.Forms.ListView lvInOutType, string strWhereCond)
		{
			//操作步骤:(共4步)
			//	1、组合界面条件串；
			//	2、根据条件串获取该表满足条件的DataTable；
			//	3、设置ListView的列头信息
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			//		在本界面中是把状态显示在控件lblRecCount中。

			System.Windows.Forms.ListViewItem lviInOutType;
            List<clsInOutTypeEN> arrInOutTypeObjList;
			//	2、根据条件串获取该表满足条件的DataTable；
			arrInOutTypeObjList = clsInOutTypeBL.GetObjLst(strWhereCond);
			//	3、设置ListView的列头信息
			lvInOutType.Items.Clear();//清除原来所有Item
			lvInOutType.Columns.Clear();//清除原来所有列头信息
			lvInOutType.Columns.Add("INOUT类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvInOutType.Columns.Add("INOUT类型名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvInOutType.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvInOutType.View = System.Windows.Forms.View.Details;
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			foreach (clsInOutTypeEN objInOutType in arrInOutTypeObjList)
			{
				lviInOutType = new System.Windows.Forms.ListViewItem();
				lviInOutType.Tag = objInOutType.InOutTypeId;
				lviInOutType.Text = objInOutType.InOutTypeId;
				lviInOutType.SubItems.Add(objInOutType.InOutTypeName);
				lviInOutType.SubItems.Add(objInOutType.Memo);
				lvInOutType.Items.Add(lviInOutType);
			}
			//	4、设置记录数的状态,
			//		在本界面中是把状态显示在控件txtRecCount中。
			return arrInOutTypeObjList.Count;
		}
	}
}