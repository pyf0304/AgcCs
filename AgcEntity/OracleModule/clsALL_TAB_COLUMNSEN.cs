using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdbfororacle;
using System.Data.OracleClient;
//using System.Data.OracleClient;

namespace AGC.Entity
{
	public class clsALL_TAB_COLUMNSEN : clsGeneralTab2
	{
		public const string CurrTabName_S = "ALL_TAB_COLUMNS";    //当前表名，与该类相关的表名
		public const string CurrTabKeyFldName_S = "OwnerTable_Name";    //当前表中的关键字名称，与该类相关的表中关键字名
		protected const int mintAttributeCount = 10;
		public static string[] AttributeName = new string[] {"OwnerTable_Name", "Owner", "Table_Name", "Column_Name", "Data_Type", "Data_Length", "Data_Precision", "Data_Scale", "Nullable", "Column_Id"};
		//以下是属性变量

		protected string mstrOwnerTable_Name;
		protected string mstrOwner;
		protected string mstrTable_Name;
		protected string mstrColumn_Name;
		protected string mstrData_Type;
		protected int mintData_Length;
		protected int mintData_Precision;
		protected string mstrData_Scale;
		protected string mstrNullable;
		protected int mintColumn_Id;

		public clsALL_TAB_COLUMNSEN()
		{
			SetInit();
			_CurrTabName = "ALL_TAB_COLUMNS";
			//KeyFldName = "OwnerTable_Name";
		}

		public clsALL_TAB_COLUMNSEN(string strOwnerTable_Name)
		{

			mstrOwnerTable_Name=strOwnerTable_Name;
			SetInit();
			_CurrTabName = "ALL_TAB_COLUMNS";
			//KeyFldName = "OwnerTable_Name";
		}

		public clsALL_TAB_COLUMNSEN(string strOwnerTable_Name, bool bolIsGetALL_TAB_COLUMNS)
		{

			mstrOwnerTable_Name=strOwnerTable_Name;
			SetInit();
			if (bolIsGetALL_TAB_COLUMNS==true)
			{
				GetALL_TAB_COLUMNS();
			}
			_CurrTabName = "ALL_TAB_COLUMNS";
			//KeyFldName = "OwnerTable_Name";
		}


		public static int AttributeCount
		{
			get
			{
				return mintAttributeCount;
			}
		}
		public object this[string strAttributeName]
		{
			get
			{
				if (strAttributeName == "OwnerTable_Name")
				{
					return mstrOwnerTable_Name;
				}
				else if (strAttributeName == "Owner")
				{
					return mstrOwner;
				}
				else if (strAttributeName == "Table_Name")
				{
					return mstrTable_Name;
				}
				else if (strAttributeName == "Column_Name")
				{
					return mstrColumn_Name;
				}
				else if (strAttributeName == "Data_Type")
				{
					return mstrData_Type;
				}
				else if (strAttributeName == "Data_Length")
				{
					return mintData_Length;
				}
				else if (strAttributeName == "Data_Precision")
				{
					return mintData_Precision;
				}
				else if (strAttributeName == "Data_Scale")
				{
					return mstrData_Scale;
				}
				else if (strAttributeName == "Nullable")
				{
					return mstrNullable;
				}
				else if (strAttributeName == "Column_Id")
				{
					return mintColumn_Id;
				}
				return null;
			}
			set
			{
				if (strAttributeName == "OwnerTable_Name")
				{
					mstrOwnerTable_Name = value.ToString();
				}
				else if (strAttributeName == "Owner")
				{
					mstrOwner = value.ToString();
				}
				else if (strAttributeName == "Table_Name")
				{
					mstrTable_Name = value.ToString();
				}
				else if (strAttributeName == "Column_Name")
				{
					mstrColumn_Name = value.ToString();
				}
				else if (strAttributeName == "Data_Type")
				{
					mstrData_Type = value.ToString();
				}
				else if (strAttributeName == "Data_Length")
				{
					mintData_Length = TransNullToInt(value.ToString());
				}
				else if (strAttributeName == "Data_Precision")
				{
					mintData_Precision = TransNullToInt(value.ToString());
				}
				else if (strAttributeName == "Data_Scale")
				{
					mstrData_Scale = value.ToString();
				}
				else if (strAttributeName == "Nullable")
				{
					mstrNullable = value.ToString();
				}
				else if (strAttributeName == "Column_Id")
				{
					mintColumn_Id = TransNullToInt(value.ToString());
				}
			}
		}
		public object this[int intIndex]
		{
			get
			{
				if ("OwnerTable_Name" == AttributeName[intIndex])
				{
					return mstrOwnerTable_Name;
				}
				else if ("Owner" == AttributeName[intIndex])
				{
					return mstrOwner;
				}
				else if ("Table_Name" == AttributeName[intIndex])
				{
					return mstrTable_Name;
				}
				else if ("Column_Name" == AttributeName[intIndex])
				{
					return mstrColumn_Name;
				}
				else if ("Data_Type" == AttributeName[intIndex])
				{
					return mstrData_Type;
				}
				else if ("Data_Length" == AttributeName[intIndex])
				{
					return mintData_Length;
				}
				else if ("Data_Precision" == AttributeName[intIndex])
				{
					return mintData_Precision;
				}
				else if ("Data_Scale" == AttributeName[intIndex])
				{
					return mstrData_Scale;
				}
				else if ("Nullable" == AttributeName[intIndex])
				{
					return mstrNullable;
				}
				else if ("Column_Id" == AttributeName[intIndex])
				{
					return mintColumn_Id;
				}
				return null;
			}
			set
			{
				if ("OwnerTable_Name" == AttributeName[intIndex])
				{
					mstrOwnerTable_Name = value.ToString();
				}
				else if ("Owner" == AttributeName[intIndex])
				{
					mstrOwner = value.ToString();
				}
				else if ("Table_Name" == AttributeName[intIndex])
				{
					mstrTable_Name = value.ToString();
				}
				else if ("Column_Name" == AttributeName[intIndex])
				{
					mstrColumn_Name = value.ToString();
				}
				else if ("Data_Type" == AttributeName[intIndex])
				{
					mstrData_Type = value.ToString();
				}
				else if ("Data_Length" == AttributeName[intIndex])
				{
					mintData_Length = TransNullToInt(value.ToString());
				}
				else if ("Data_Precision" == AttributeName[intIndex])
				{
					mintData_Precision = TransNullToInt(value.ToString());
				}
				else if ("Data_Scale" == AttributeName[intIndex])
				{
					mstrData_Scale = value.ToString();
				}
				else if ("Nullable" == AttributeName[intIndex])
				{
					mstrNullable = value.ToString();
				}
				else if ("Column_Id" == AttributeName[intIndex])
				{
					mintColumn_Id = TransNullToInt(value.ToString());
				}
			}
		}

		public string OwnerTable_Name
		{
			get
			{
				return mstrOwnerTable_Name;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrOwnerTable_Name = value;
				}
				else
				{
					mstrOwnerTable_Name = value;
				}
			}
		}
		public string Owner
		{
			get
			{
				return mstrOwner;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrOwner = value;
				}
				else
				{
					mstrOwner = value;
				}
			}
		}
		public string Table_Name
		{
			get
			{
				return mstrTable_Name;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrTable_Name = value;
				}
				else
				{
					mstrTable_Name = value;
				}
			}
		}
		public string Column_Name
		{
			get
			{
				return mstrColumn_Name;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrColumn_Name = value;
				}
				else
				{
					mstrColumn_Name = value;
				}
			}
		}
		public string Data_Type
		{
			get
			{
				return mstrData_Type;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrData_Type = value;
				}
				else
				{
					mstrData_Type = value;
				}
			}
		}
		public int Data_Length
		{
			get
			{
				return mintData_Length;
			}
			set
			{
				mintData_Length = value;
			}
		}
		public int Data_Precision
		{
			get
			{
				return mintData_Precision;
			}
			set
			{
				mintData_Precision = value;
			}
		}
		public string Data_Scale
		{
			get
			{
				return mstrData_Scale;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrData_Scale = value;
				}
				else
				{
					mstrData_Scale = value;
				}
			}
		}
		public string Nullable
		{
			get
			{
				return mstrNullable;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrNullable = value;
				}
				else
				{
					mstrNullable = value;
				}
			}
		}
		public int Column_Id
		{
			get
			{
				return mintColumn_Id;
			}
			set
			{
				mintColumn_Id = value;
			}
		}

		//public bool AddNewRecord()
		//{
		//	string strSQL; 
		//	OracleDataAdapter objDA; 
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB ; 
		//	System.Data.DataRow objRow; 
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	strSQL = "Select * from ALL_TAB_COLUMNS where 1=2";
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "ALL_TAB_COLUMNS");
		//	objRow = objDS.Tables["ALL_TAB_COLUMNS"].NewRow();
		//	objRow["OwnerTable_Name"] = mstrOwnerTable_Name;
		//	objRow["Owner"] = mstrOwner;
		//	objRow["Table_Name"] = mstrTable_Name;
		//	objRow["Column_Name"] = mstrColumn_Name;
		//	objRow["Data_Type"] = mstrData_Type;
		//	objRow["Data_Length"] = mintData_Length;
		//	objRow["Data_Precision"] = mintData_Precision;
		//	objRow["Data_Scale"] = mstrData_Scale;
		//	objRow["Nullable"] = mstrNullable;
		//	objRow["Column_Id"] = mintColumn_Id;
		//	objDS.Tables["ALL_TAB_COLUMNS"].Rows.Add(objRow);
		//	try
		//	{
		//		objDA.Update(objDS, "ALL_TAB_COLUMNS");
		//	}
		//	catch (Exception objException )
		//	{
		//		LogError(objException);
		//		throw new Exception(EXCEPTION_MSG + objException.Message, objException);
		//	}
		//	finally
		//	{
		//		objDA = null;
		//		objDS = null;
		//		objCB = null;
		//		objRow = null;
		//	}
		//	return true;
		//}



		/// <summary>
		/// 把多条记录同时插入到表中!
		/// </summary>
		/// <param name="oDT"></param>
		/// <param name="strResult"></param>
		/// <returns></returns>
		//public  bool AddnewALL_TAB_COLUMNSs(System.Data.DataTable oDT, ref string strResult) 
		//{
		//	string strSQL;
		//	OracleDataAdapter objDA;
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB; 
		//	System.Data.DataRow objRow;
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	if (mintErrNo != 0 ) 
		//	{
		//		strResult = "错误号为：" + mintErrNo.ToString();
		//		return false;
		//	}
		//	strSQL = "Select * from ALL_TAB_COLUMNS where OwnerTable_Name='111'";
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "ALL_TAB_COLUMNS");
		//	//检查关键字的唯一性
		//	foreach(System.Data.DataRow oRow in oDT.Rows)
		//	{
		//		string strOwnerTable_Name =oRow["OwnerTable_Name"].ToString().Trim();
		//		if (IsExist(strOwnerTable_Name))
		//		{
		//			strResult = "关键字OwnerTable_Name为：" + strOwnerTable_Name + "的记录已存在，不能重复插入!" ;
		//			return false;
		//		}
		//	}
		//	//把多条记录插入到表中
		//	foreach(System.Data.DataRow oRow in oDT.Rows)
		//	{
		//		objRow = objDS.Tables["ALL_TAB_COLUMNS"].NewRow();
		//		objRow["OwnerTable_Name"] = oRow["OwnerTable_Name"].ToString().Trim();
		//		objRow["Owner"] = oRow["Owner"].ToString().Trim();
		//		objRow["Table_Name"] = oRow["Table_Name"].ToString().Trim();
		//		objRow["Column_Name"] = oRow["Column_Name"].ToString().Trim();
		//		objRow["Data_Type"] = oRow["Data_Type"].ToString().Trim();
		//		objRow["Data_Length"] = oRow["Data_Length"].ToString().Trim();
		//		objRow["Data_Precision"] = oRow["Data_Precision"].ToString().Trim();
		//		objRow["Data_Scale"] = oRow["Data_Scale"].ToString().Trim();
		//		objRow["Nullable"] = oRow["Nullable"].ToString().Trim();
		//		objRow["Column_Id"] = oRow["Column_Id"].ToString().Trim();
		//		objDS.Tables["ALL_TAB_COLUMNS"].Rows.Add(objRow);
		//	}
		//	try
		//	{
		//		objDA.Update(objDS, "ALL_TAB_COLUMNS");
		//	}
		//	catch(Exception objException) 
		//	{
		//		LogError(objException);
		//		throw new Exception(EXCEPTION_MSG + objException.Message, objException);
		//	}
		//	finally
		//	{
		//		objDA = null;
		//		objDS = null;
		//		objCB = null;
		//		objRow = null;
		//		objSQL.OracleConnect.Close();
		//		objSQL = null;
		//	}
		//	return true;
		//}

		//public bool Update() 
		//{
		//	string strSQL ;
		//	OracleDataAdapter objDA ;
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB ;
		//	System.Data.DataRow objRow ;
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	strSQL = "Select * from ALL_TAB_COLUMNS where OwnerTable_Name=" + "'"+ mstrOwnerTable_Name+"'";
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "ALL_TAB_COLUMNS");
		//	if (objDS.Tables["ALL_TAB_COLUMNS"].Rows.Count == 0 )
		//	{
		//		//MsgBox("没有相应的ID号：OwnerTable_Name=" + "'"+ mstrOwnerTable_Name+"'");
		//		return false;
		//	}
		//	objRow = objDS.Tables["ALL_TAB_COLUMNS"].Rows[0];
		//	objRow["Owner"] = mstrOwner;
		//	objRow["Table_Name"] = mstrTable_Name;
		//	objRow["Column_Name"] = mstrColumn_Name;
		//	objRow["Data_Type"] = mstrData_Type;
		//	objRow["Data_Length"] = mintData_Length;
		//	objRow["Data_Precision"] = mintData_Precision;
		//	objRow["Data_Scale"] = mstrData_Scale;
		//	objRow["Nullable"] = mstrNullable;
		//	objRow["Column_Id"] = mintColumn_Id;
		//	try
		//	{
		//		objDA.Update(objDS, "ALL_TAB_COLUMNS");
		//	}
		//	catch (Exception objException )
		//	{
		//		LogError(objException);
		//		throw new Exception(EXCEPTION_MSG + objException.Message, objException);
		//	}
		//	finally
		//	{
		//		objDA = null;
		//		objDS = null;
		//		objCB = null;
		//		objRow = null;
		//	}
		//	return true;
		//}



		/// <summary>
		/// 功能：修改多条记录
		/// </summary>
		/// <param name="strCondition"></param>
		/// <returns></returns>
		//public int UpdateMultiRec(string strCondition) 
		//{
		//	string strSQL ;
		//	OracleDataAdapter objDA ;
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB ;
		//	//			System.Data.DataRow objRow ;
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	int intRecCount;
		//	if (strCondition == "")
		//	{
		//		return 0;   //表示删除0条记录，实际上是不能该表的所有记录
		//	}
		//	strSQL = "Select * from ALL_TAB_COLUMNS where " + strCondition;
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "ALL_TAB_COLUMNS");
		//	if (objDS.Tables["ALL_TAB_COLUMNS"].Rows.Count == 0 )
		//	{
		//		return 0;
		//	}
		//	intRecCount = objDS.Tables["ALL_TAB_COLUMNS"].Rows.Count;
		//	foreach(System.Data.DataRow objRow in objDS.Tables["ALL_TAB_COLUMNS"].Rows)
		//	{
		//		objRow["Owner"] = mstrOwner;
		//		objRow["Table_Name"] = mstrTable_Name;
		//		objRow["Column_Name"] = mstrColumn_Name;
		//		objRow["Data_Type"] = mstrData_Type;
		//		objRow["Data_Length"] = mintData_Length;
		//		objRow["Data_Precision"] = mintData_Precision;
		//		objRow["Data_Scale"] = mstrData_Scale;
		//		objRow["Nullable"] = mstrNullable;
		//		objRow["Column_Id"] = mintColumn_Id;
		//	}
		//	try
		//	{
		//		objDA.Update(objDS, "ALL_TAB_COLUMNS");
		//	}
		//	catch (Exception objException )
		//	{
		//		LogError(objException);
		//		throw new Exception(EXCEPTION_MSG + objException.Message, objException);
		//	}
		//	finally
		//	{
		//		objDA = null;
		//		objDS = null;
		//		objCB = null;
		//	}
		//	return intRecCount;
		//}


		public bool DelRecord() 
		{
			string strSQL = "";
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			//删除ALL_TAB_COLUMNS本表中与当前对象有关的记录
			strSQL = strSQL + "Delete from ALL_TAB_COLUMNS where OwnerTable_Name=" + "'"+ mstrOwnerTable_Name+"'";
			return objSQL.ExecSql(strSQL);
		}


		//同时删除多条记录
		public static bool DelALL_TAB_COLUMNS(ArrayList lstKey)
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			string strSQL;
			string strKeyList;
			if (lstKey.Count ==0) return true;
			strKeyList = "";
			for (int i=0; i<lstKey.Count; i++)
			{
				if (i==0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
				else strKeyList += ","  + "'" + lstKey[i].ToString() + "'";
			}
			strSQL = "";
			//删除ALL_TAB_COLUMNS本表中与当前对象有关的记录
			strSQL = strSQL + "Delete from ALL_TAB_COLUMNS where OwnerTable_Name in (" + strKeyList + ")";
			return objSQL.ExecSql(strSQL);
		}

		public static bool DelRecord(string strOwnerTable_Name) 
		{
			//删除单条记录
			string strSQL = "";
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			//删除ALL_TAB_COLUMNS本表中与当前对象有关的记录
			strSQL = strSQL + "Delete from ALL_TAB_COLUMNS where OwnerTable_Name=" + "'"+ strOwnerTable_Name+"'";
			return objSQL.ExecSql(strSQL);
		}


		/// <summary>
		/// 功能：删除多条记录，带条件的删除
		/// </summary>
		/// <param name="strCondition">需要删除的记录条件</param>
		/// <returns>返回删除的记录0。</returns>
		public static int DelALL_TAB_COLUMNS(string strCondition)
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			string strSQL;
			if (strCondition == "")
			{
				return 0;	//表示删除0条记录，实际上是不能该表的所有记录
			}
			else
			{
				strSQL =  "Delete from ALL_TAB_COLUMNS where " + strCondition ;
			}
			int intRecoCount =  objSQL.ExecSql2(strSQL);
			return intRecoCount;
		}


		public bool GetALL_TAB_COLUMNS()
		{
			string strSQL ;
			System.Data.DataTable objDT ; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from ALL_TAB_COLUMNS where OwnerTable_Name=" + "'"+ mstrOwnerTable_Name+"'";
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return false;
			}
			mstrOwnerTable_Name=objDT.Rows[0]["OwnerTable_Name"].ToString().Trim();
			mstrOwner=objDT.Rows[0]["Owner"].ToString().Trim();
			mstrTable_Name=objDT.Rows[0]["Table_Name"].ToString().Trim();
			mstrColumn_Name=objDT.Rows[0]["Column_Name"].ToString().Trim();
			mstrData_Type=objDT.Rows[0]["Data_Type"].ToString().Trim();
			mintData_Length=Int32.Parse(objDT.Rows[0]["Data_Length"].ToString().Trim());
			mintData_Precision=Int32.Parse(objDT.Rows[0]["Data_Precision"].ToString().Trim());
			mstrData_Scale=objDT.Rows[0]["Data_Scale"].ToString().Trim();
			mstrNullable=objDT.Rows[0]["Nullable"].ToString().Trim();
			mintColumn_Id=Int32.Parse(objDT.Rows[0]["Column_Id"].ToString().Trim());
			objDT = null;
			return true;
		}

		public static System.Data.DataTable GetALL_TAB_COLUMNS(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from ALL_TAB_COLUMNS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}

		public ArrayList GetALL_TAB_COLUMNSObjList(string strCondition)
		{
			ArrayList arrObjList = new ArrayList(); 
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from ALL_TAB_COLUMNS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return arrObjList;
			}
			foreach(DataRow objRow in objDT.Rows)
			{
				clsALL_TAB_COLUMNSEN objALL_TAB_COLUMNS = new clsALL_TAB_COLUMNSEN();
				objALL_TAB_COLUMNS.OwnerTable_Name = objRow["OwnerTable_Name"].ToString().Trim();
				objALL_TAB_COLUMNS.Owner = objRow["Owner"].ToString().Trim();
				objALL_TAB_COLUMNS.Table_Name = objRow["Table_Name"].ToString().Trim();
				objALL_TAB_COLUMNS.Column_Name = objRow["Column_Name"].ToString().Trim();
				objALL_TAB_COLUMNS.Data_Type = objRow["Data_Type"].ToString().Trim();
				objALL_TAB_COLUMNS.Data_Length = Int32.Parse(objRow["Data_Length"].ToString().Trim());
				objALL_TAB_COLUMNS.Data_Precision = Int32.Parse(objRow["Data_Precision"].ToString().Trim());
				objALL_TAB_COLUMNS.Data_Scale = objRow["Data_Scale"].ToString().Trim();
				objALL_TAB_COLUMNS.Nullable = objRow["Nullable"].ToString().Trim();
				objALL_TAB_COLUMNS.Column_Id = Int32.Parse(objRow["Column_Id"].ToString().Trim());
				arrObjList.Add(objALL_TAB_COLUMNS);
			}
			objDT = null;
			return arrObjList;
		}

		public clsALL_TAB_COLUMNSEN GetFirstALL_TAB_COLUMNS(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from ALL_TAB_COLUMNS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return null;
			}
			DataRow objRow = objDT.Rows[0];
			clsALL_TAB_COLUMNSEN objALL_TAB_COLUMNS = new clsALL_TAB_COLUMNSEN();
			objALL_TAB_COLUMNS.OwnerTable_Name = objRow["OwnerTable_Name"].ToString().Trim();
			objALL_TAB_COLUMNS.Owner = objRow["Owner"].ToString().Trim();
			objALL_TAB_COLUMNS.Table_Name = objRow["Table_Name"].ToString().Trim();
			objALL_TAB_COLUMNS.Column_Name = objRow["Column_Name"].ToString().Trim();
			objALL_TAB_COLUMNS.Data_Type = objRow["Data_Type"].ToString().Trim();
			objALL_TAB_COLUMNS.Data_Length = Int32.Parse(objRow["Data_Length"].ToString().Trim());
			objALL_TAB_COLUMNS.Data_Precision = Int32.Parse(objRow["Data_Precision"].ToString().Trim());
			objALL_TAB_COLUMNS.Data_Scale = objRow["Data_Scale"].ToString().Trim();
			objALL_TAB_COLUMNS.Nullable = objRow["Nullable"].ToString().Trim();
			objALL_TAB_COLUMNS.Column_Id = Int32.Parse(objRow["Column_Id"].ToString().Trim());
			objDT = null;
			return objALL_TAB_COLUMNS;
		}



		/// <summary>
		/// 功能：获取某一条件的相关表视图(View)
		/// </summary>
		/// <param name="strCondition">条件串</param>
		/// <returns>返回已经转换代码的DataTable</returns>
		public static System.Data.DataTable GetALL_TAB_COLUMNSV(string strCondition)
		{
			StringBuilder strSQL = new StringBuilder(); 
			System.Data.DataTable objDT=null; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL.Append("Select vALL_TAB_COLUMNS.* ");
			strSQL.Append(" from vALL_TAB_COLUMNS ");
			strSQL.Append(" where " + strCondition); 
			objDT = objSQL.GetDataTable(strSQL.ToString());
			return objDT;
		}


		public bool IsExist()
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			if (objSQL.IsExistRecord("ALL_TAB_COLUMNS", "OwnerTable_Name=" + "'"+ mstrOwnerTable_Name+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool IsExist(string strOwnerTable_Name)
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			if (objSQL.IsExistRecord("ALL_TAB_COLUMNS", "OwnerTable_Name=" + "'"+ strOwnerTable_Name+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void CheckPropertyNew()
		{
			if (Object.Equals(null, mstrOwnerTable_Name ) 
				|| (!Object.Equals(null, mstrOwnerTable_Name ) && mstrOwnerTable_Name .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[拥有者表名]不能为空(NULL)!");
			}
			if (Object.Equals(null, mstrOwner ) 
				|| (!Object.Equals(null, mstrOwner ) && mstrOwner .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[拥有者]不能为空(NULL)!");
			}
			if (Object.Equals(null, mstrTable_Name ) 
				|| (!Object.Equals(null, mstrTable_Name ) && mstrTable_Name .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[表名]不能为空(NULL)!");
			}
			if (Object.Equals(null, mstrColumn_Name ) 
				|| (!Object.Equals(null, mstrColumn_Name ) && mstrColumn_Name .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[列名]不能为空(NULL)!");
			}
			if (Object.Equals(null, mstrData_Type ) 
				|| (!Object.Equals(null, mstrData_Type ) && mstrData_Type .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[数据类型]不能为空(NULL)!");
			}
			if (Object.Equals(null, mintData_Length ) 
				|| (!Object.Equals(null, mintData_Length ) && mintData_Length .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[数据长度]不能为空(NULL)!");
			}
			if (Object.Equals(null, mintData_Precision ) 
				|| (!Object.Equals(null, mintData_Precision ) && mintData_Precision .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[数据精度]不能为空(NULL)!");
			}
			if (Object.Equals(null, mstrData_Scale ) 
				|| (!Object.Equals(null, mstrData_Scale ) && mstrData_Scale .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[Data_Scale]不能为空(NULL)!");
			}
			if (Object.Equals(null, mstrNullable ) 
				|| (!Object.Equals(null, mstrNullable ) && mstrNullable .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[可空]不能为空(NULL)!");
			}
			if (Object.Equals(null, mintColumn_Id ) 
				|| (!Object.Equals(null, mintColumn_Id ) && mintColumn_Id .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[列号]不能为空(NULL)!");
			}
			if (!Object.Equals(null, mstrOwnerTable_Name)  && getStrLen(mstrOwnerTable_Name) > 100)
			{
				throw new clsDbObjException("字段[拥有者表名]的长度不能超过100!");
			}
			if (!Object.Equals(null, mstrOwner)  && getStrLen(mstrOwner) > 30)
			{
				throw new clsDbObjException("字段[拥有者]的长度不能超过30!");
			}
			if (!Object.Equals(null, mstrTable_Name)  && getStrLen(mstrTable_Name) > 50)
			{
				throw new clsDbObjException("字段[表名]的长度不能超过50!");
			}
			if (!Object.Equals(null, mstrColumn_Name)  && getStrLen(mstrColumn_Name) > 50)
			{
				throw new clsDbObjException("字段[列名]的长度不能超过50!");
			}
			if (!Object.Equals(null, mstrData_Type)  && getStrLen(mstrData_Type) > 50)
			{
				throw new clsDbObjException("字段[数据类型]的长度不能超过50!");
			}
			if (!Object.Equals(null, mstrData_Scale)  && getStrLen(mstrData_Scale) > 10)
			{
				throw new clsDbObjException("字段[Data_Scale]的长度不能超过10!");
			}
			if (!Object.Equals(null, mstrNullable)  && getStrLen(mstrNullable) > 10)
			{
				throw new clsDbObjException("字段[可空]的长度不能超过10!");
			}
		}

		public ArrayList GetID(string strCondtion ) 
		{
			string strSQL ;
			System.Data.DataTable objDT ;
			ArrayList arrList = new ArrayList();
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			int iRow, iCol; 
			string strKeyValue; 
			strSQL = "Select OwnerTable_Name from ALL_TAB_COLUMNS where " + strCondtion;
			try
			{
				objDT = objSQL.GetDataTable(strSQL);
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
			}

			if (objDT.Rows.Count == 0 )
			{
				objDT = null;
				return null;
			}
			for (iRow = 0; iRow<= objDT.Rows.Count - 1;iRow++)
			{
				strKeyValue = "";
				for (iCol = 0; iCol<= objDT.Columns.Count - 1;iCol++)
				{
					if (iCol == 0 )
					{
						strKeyValue += objDT.Rows[iRow][iCol].ToString();
					}
					else
					{
						strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
					}
				}
				arrList.Add(strKeyValue);
			}
			objDT = null;
			return arrList;
		}

		public string GetFirstID(string strCondtion ) 
		{
			string strSQL ;
			System.Data.DataTable objDT ;
			ArrayList arrList = new ArrayList();
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			string strKeyValue; 
			strSQL = "Select OwnerTable_Name from ALL_TAB_COLUMNS where " + strCondtion;
			try
			{
				objDT = objSQL.GetDataTable(strSQL);
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
			}

			if (objDT.Rows.Count == 0 )
			{
				objDT = null;
				return null;
			}
			strKeyValue = objDT.Rows[0][0].ToString();
			objDT = null;
			return strKeyValue;
		}

		public static string GetFirstID_S(string strCondtion ) 
		{
			string strSQL ;
			System.Data.DataTable objDT ;
			ArrayList arrList = new ArrayList();
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			string strKeyValue; 
			strSQL = "Select OwnerTable_Name from ALL_TAB_COLUMNS where " + strCondtion;
			try
			{
				objDT = objSQL.GetDataTable(strSQL);
			}
			catch (Exception objException )
			{
				LogErrorS(objException, "clsALL_TAB_COLUMNSEN");
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
			}

			if (objDT.Rows.Count == 0 )
			{
				objDT = null;
				return null;
			}
			strKeyValue = objDT.Rows[0][0].ToString();
			objDT = null;
			return strKeyValue;
		}
	}
}