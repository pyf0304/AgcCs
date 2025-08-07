using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using AGC.BusinessLogic;
using System.Collections.Generic;

namespace AGC.BusinessLogicEx
{
	public class clsOperationTypeBLEx 
	{
		public const string 
			ADD_RECORD                           =    "0001", //添加记录
			UPDATE_RECORD                        =    "0002", //修改记录
			DELETE_RECORD		                 =    "0003", //删除记录
			QUERY_RECORD		                 =    "0004", //查询记录
			LOGIN		                         =    "0005", //登录
			LOGOUT		                         =    "0006"; //注销
		
	


		public static System.Data.DataTable GetOpTypeId()
		{
			//获取某学院所有专业信息
			string strSQL = "select OpTypeId, OpTypeName from OperationType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public static void BindCbo_OpTypeId(System.Windows.Forms.ComboBox objComboBox)
		{
			//为数据源为表的下拉框设置内容
			System.Data.DataTable objDT = GetOpTypeId();
			clsOperationTypeEN objOperationType;
			//初始化一个对象列表
			ArrayList OperationTypeList = new ArrayList();
			//插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
			objOperationType = new clsOperationTypeEN();
			objOperationType.OpTypeId = "0";
			objOperationType.OpTypeName = "请选择...";
			OperationTypeList.Add(objOperationType);
			//把DataTable中的所有项均加到对象列表中
			foreach(DataRow objRow in objDT.Rows)
			{
				objOperationType = new clsOperationTypeEN();
				objOperationType.OpTypeId = objRow["OpTypeId"].ToString();
				objOperationType.OpTypeName = objRow["OpTypeName"].ToString();
				OperationTypeList.Add(objOperationType);
			}
			//设置下拉框的数据源、以及设置值项、显示项
			objComboBox.DataSource = OperationTypeList;
			objComboBox.ValueMember="OpTypeId";
			objComboBox.DisplayMember="OpTypeName";
			objComboBox.SelectedIndex = 0;
		}

		///绑定下拉框的函数代码
		public static void BindDdl_OpTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			System.Web.UI.WebControls.ListItem li=new System.Web.UI.WebControls.ListItem("请选择...","0");
			System.Data.DataTable objDT = GetOpTypeId();
			objDDL.DataValueField="OpTypeId";
			objDDL.DataTextField="OpTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}

		///生成绑定ListView的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在ListView中。
		/// </summary>
		public static int BindLv_OperationType(System.Windows.Forms.ListView lvOperationType, string strWhereCond)
		{
			//操作步骤：(共4步)
			//	1、组合界面条件串；
			//	2、根据条件串获取该表满足条件的DataTable；
			//	3、设置ListView的列头信息
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			//		在本界面中是把状态显示在控件lblRecCount中。

			System.Windows.Forms.ListViewItem lviOperationType;
            List<clsOperationTypeEN> arrOperationTypeObjList;
			//	2、根据条件串获取该表满足条件的DataTable；
			arrOperationTypeObjList = clsOperationTypeBL.GetObjLst(strWhereCond);
			//	3、设置ListView的列头信息
			lvOperationType.Items.Clear();//清除原来所有Item
			lvOperationType.Columns.Clear();//清除原来所有列头信息
			lvOperationType.Columns.Add("操作类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvOperationType.Columns.Add("操作类型名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvOperationType.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvOperationType.View = System.Windows.Forms.View.Details;
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			foreach (clsOperationTypeEN objOperationType in arrOperationTypeObjList)
			{
				lviOperationType = new System.Windows.Forms.ListViewItem();
				lviOperationType.Tag = objOperationType.OpTypeId;
				lviOperationType.Text = objOperationType.OpTypeId;
				lviOperationType.SubItems.Add(objOperationType.OpTypeName);
				lviOperationType.SubItems.Add(objOperationType.Memo);
				lvOperationType.Items.Add(lviOperationType);
			}
			//	4、设置记录数的状态，
			//		在本界面中是把状态显示在控件txtRecCount中。
			return arrOperationTypeObjList.Count;
		}
	}
}