using System;
using System.Data; 
using System.Text; 
using System.Collections; 
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdbfororacle;
using System.Data.OracleClient;

namespace AGC.Entity
{
	public class clsALL_VIEWSEN : clsGeneralTab
	{
		public const string CurrTabName_S = "ALL_VIEWS";    //当前表名，与该类相关的表名
		public const string CurrTabKeyFldName_S = "OwnerView_Name";    //当前表中的关键字名称，与该类相关的表中关键字名
		protected const int mintAttributeCount = 5;
		public static string[] AttributeName = new string[] {"OwnerView_Name", "Owner", "View_Name", "Text_Length", "Text"};
		//以下是属性变量

		protected string mstrOwnerView_Name;
		protected string mstrOwner;
		protected string mstrView_Name;
		protected int mintText_Length;
		protected string mstrText;

		public clsALL_VIEWSEN()
		{
			SetInit();
			_CurrTabName = "ALL_VIEWS";
			KeyFldName = "OwnerView_Name";
		}

		public clsALL_VIEWSEN(string strOwnerView_Name)
		{

			mstrOwnerView_Name=strOwnerView_Name;
			SetInit();
			_CurrTabName = "ALL_VIEWS";
			KeyFldName = "OwnerView_Name";
		}

		public clsALL_VIEWSEN(string strOwnerView_Name, bool bolIsGetALL_VIEWS)
		{

			mstrOwnerView_Name=strOwnerView_Name;
			SetInit();
			if (bolIsGetALL_VIEWS==true)
			{
				GetALL_VIEWS();
			}
			_CurrTabName = "ALL_VIEWS";
			KeyFldName = "OwnerView_Name";
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
				if (strAttributeName == "OwnerView_Name")
				{
					return mstrOwnerView_Name;
				}
				else if (strAttributeName == "Owner")
				{
					return mstrOwner;
				}
				else if (strAttributeName == "View_Name")
				{
					return mstrView_Name;
				}
				else if (strAttributeName == "Text_Length")
				{
					return mintText_Length;
				}
				else if (strAttributeName == "Text")
				{
					return mstrText;
				}
				return null;
			}
			set
			{
				if (strAttributeName == "OwnerView_Name")
				{
					mstrOwnerView_Name = value.ToString();
				}
				else if (strAttributeName == "Owner")
				{
					mstrOwner = value.ToString();
				}
				else if (strAttributeName == "View_Name")
				{
					mstrView_Name = value.ToString();
				}
				else if (strAttributeName == "Text_Length")
				{
					mintText_Length = TransNullToInt(value.ToString());
				}
				else if (strAttributeName == "Text")
				{
					mstrText = value.ToString();
				}
			}
		}
		public object this[int intIndex]
		{
			get
			{
				if ("OwnerView_Name" == AttributeName[intIndex])
				{
					return mstrOwnerView_Name;
				}
				else if ("Owner" == AttributeName[intIndex])
				{
					return mstrOwner;
				}
				else if ("View_Name" == AttributeName[intIndex])
				{
					return mstrView_Name;
				}
				else if ("Text_Length" == AttributeName[intIndex])
				{
					return mintText_Length;
				}
				else if ("Text" == AttributeName[intIndex])
				{
					return mstrText;
				}
				return null;
			}
			set
			{
				if ("OwnerView_Name" == AttributeName[intIndex])
				{
					mstrOwnerView_Name = value.ToString();
				}
				else if ("Owner" == AttributeName[intIndex])
				{
					mstrOwner = value.ToString();
				}
				else if ("View_Name" == AttributeName[intIndex])
				{
					mstrView_Name = value.ToString();
				}
				else if ("Text_Length" == AttributeName[intIndex])
				{
					mintText_Length = TransNullToInt(value.ToString());
				}
				else if ("Text" == AttributeName[intIndex])
				{
					mstrText = value.ToString();
				}
			}
		}

		public string OwnerView_Name
		{
			get
			{
				return mstrOwnerView_Name;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrOwnerView_Name = value;
				}
				else
				{
					mstrOwnerView_Name = value;
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
		public string View_Name
		{
			get
			{
				return mstrView_Name;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrView_Name = value;
				}
				else
				{
					mstrView_Name = value;
				}
			}
		}
		public int Text_Length
		{
			get
			{
				return mintText_Length;
			}
			set
			{
				mintText_Length = value;
			}
		}
		public string Text
		{
			get
			{
				return mstrText;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrText = value;
				}
				else
				{
					mstrText = value;
				}
			}
		}

		//public override bool AddNewRecord()
		//{
		//	string strSQL; 
		//	OracleDataAdapter objDA; 
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB ; 
		//	System.Data.DataRow objRow; 
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	strSQL = "Select * from ALL_VIEWS where 1=2";
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "ALL_VIEWS");
		//	objRow = objDS.Tables["ALL_VIEWS"].NewRow();
		//	objRow["OwnerView_Name"] = mstrOwnerView_Name;
		//	objRow["Owner"] = mstrOwner;
		//	objRow["View_Name"] = mstrView_Name;
		//	objRow["Text_Length"] = mintText_Length;
		//	objRow["Text"] = mstrText;
		//	objDS.Tables["ALL_VIEWS"].Rows.Add(objRow);
		//	try
		//	{
		//		objDA.Update(objDS, "ALL_VIEWS");
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
		//public  bool AddnewALL_VIEWSs(System.Data.DataTable oDT, ref string strResult) 
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
		//	strSQL = "Select * from ALL_VIEWS where OwnerView_Name='111'";
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "ALL_VIEWS");
		//	//检查关键字的唯一性
		//	foreach(System.Data.DataRow oRow in oDT.Rows)
		//	{
		//		string strOwnerView_Name =oRow["OwnerView_Name"].ToString().Trim();
		//		if (IsExist(strOwnerView_Name))
		//		{
		//			strResult = "关键字OwnerView_Name为：" + strOwnerView_Name + "的记录已存在，不能重复插入!" ;
		//			return false;
		//		}
		//	}
		//	//把多条记录插入到表中
		//	foreach(System.Data.DataRow oRow in oDT.Rows)
		//	{
		//		objRow = objDS.Tables["ALL_VIEWS"].NewRow();
		//		objRow["OwnerView_Name"] = oRow["OwnerView_Name"].ToString().Trim();
		//		objRow["Owner"] = oRow["Owner"].ToString().Trim();
		//		objRow["View_Name"] = oRow["View_Name"].ToString().Trim();
		//		objRow["Text_Length"] = oRow["Text_Length"].ToString().Trim();
		//		objRow["Text"] = oRow["Text"].ToString().Trim();
		//		objDS.Tables["ALL_VIEWS"].Rows.Add(objRow);
		//	}
		//	try
		//	{
		//		objDA.Update(objDS, "ALL_VIEWS");
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

  //      public override bool Update() 
		//{
		//	string strSQL ;
		//	OracleDataAdapter objDA ;
		//	System.Data.DataSet objDS = new System.Data.DataSet();
		//	OracleCommandBuilder objCB ;
		//	System.Data.DataRow objRow ;
		//	clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
		//	strSQL = "Select * from ALL_VIEWS where OwnerView_Name=" + "'"+ mstrOwnerView_Name+"'";
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "ALL_VIEWS");
		//	if (objDS.Tables["ALL_VIEWS"].Rows.Count == 0 )
		//	{
		//		//MsgBox("没有相应的ID号：OwnerView_Name=" + "'"+ mstrOwnerView_Name+"'");
		//		return false;
		//	}
		//	objRow = objDS.Tables["ALL_VIEWS"].Rows[0];
		//	objRow["Owner"] = mstrOwner;
		//	objRow["View_Name"] = mstrView_Name;
		//	objRow["Text_Length"] = mintText_Length;
		//	objRow["Text"] = mstrText;
		//	try
		//	{
		//		objDA.Update(objDS, "ALL_VIEWS");
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
		//public override int UpdateMultiRec(string strCondition) 
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
		//	strSQL = "Select * from ALL_VIEWS where " + strCondition;
		//	objDA = new OracleDataAdapter(strSQL, objSQL.OracleConnect);
		//	objCB = new OracleCommandBuilder(objDA);
		//	objDA.Fill(objDS, "ALL_VIEWS");
		//	if (objDS.Tables["ALL_VIEWS"].Rows.Count == 0 )
		//	{
		//		return 0;
		//	}
		//	intRecCount = objDS.Tables["ALL_VIEWS"].Rows.Count;
		//	foreach(System.Data.DataRow objRow in objDS.Tables["ALL_VIEWS"].Rows)
		//	{
		//		objRow["Owner"] = mstrOwner;
		//		objRow["View_Name"] = mstrView_Name;
		//		objRow["Text_Length"] = mintText_Length;
		//		objRow["Text"] = mstrText;
		//	}
		//	try
		//	{
		//		objDA.Update(objDS, "ALL_VIEWS");
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


		public override bool DelRecord() 
		{
			string strSQL = "";
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			//删除ALL_VIEWS本表中与当前对象有关的记录
			strSQL = strSQL + "Delete from ALL_VIEWS where OwnerView_Name=" + "'"+ mstrOwnerView_Name+"'";
			return objSQL.ExecSql(strSQL);
		}


		//同时删除多条记录
		public static bool DelALL_VIEWS(ArrayList lstKey)
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
			//删除ALL_VIEWS本表中与当前对象有关的记录
			strSQL = strSQL + "Delete from ALL_VIEWS where OwnerView_Name in (" + strKeyList + ")";
			return objSQL.ExecSql(strSQL);
		}

		public static bool DelRecord(string strOwnerView_Name) 
		{
			//删除单条记录
			string strSQL = "";
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			//删除ALL_VIEWS本表中与当前对象有关的记录
			strSQL = strSQL + "Delete from ALL_VIEWS where OwnerView_Name=" + "'"+ strOwnerView_Name+"'";
			return objSQL.ExecSql(strSQL);
		}


		/// <summary>
		/// 功能：删除多条记录，带条件的删除
		/// </summary>
		/// <param name="strCondition">需要删除的记录条件</param>
		/// <returns>返回删除的记录0。</returns>
		public static int DelALL_VIEWS(string strCondition)
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			string strSQL;
			if (strCondition == "")
			{
				return 0;	//表示删除0条记录，实际上是不能该表的所有记录
			}
			else
			{
				strSQL =  "Delete from ALL_VIEWS where " + strCondition ;
			}
			int intRecoCount =  objSQL.ExecSql2(strSQL);
			return intRecoCount;
		}


		public bool GetALL_VIEWS()
		{
			string strSQL ;
			System.Data.DataTable objDT ; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from ALL_VIEWS where OwnerView_Name=" + "'"+ mstrOwnerView_Name+"'";
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return false;
			}
			mstrOwnerView_Name=objDT.Rows[0]["OwnerView_Name"].ToString().Trim();
			mstrOwner=objDT.Rows[0]["Owner"].ToString().Trim();
			mstrView_Name=objDT.Rows[0]["View_Name"].ToString().Trim();
			mintText_Length=Int32.Parse(objDT.Rows[0]["Text_Length"].ToString().Trim());
			mstrText=objDT.Rows[0]["Text"].ToString().Trim();
			objDT = null;
			return true;
		}

		public static System.Data.DataTable GetALL_VIEWS(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from ALL_VIEWS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}

		public ArrayList GetALL_VIEWSObjList(string strCondition)
		{
			ArrayList arrObjList = new ArrayList(); 
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from ALL_VIEWS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return arrObjList;
			}
			foreach(DataRow objRow in objDT.Rows)
			{
				clsALL_VIEWSEN objALL_VIEWS = new clsALL_VIEWSEN();
				objALL_VIEWS.OwnerView_Name = objRow["OwnerView_Name"].ToString().Trim();
				objALL_VIEWS.Owner = objRow["Owner"].ToString().Trim();
				objALL_VIEWS.View_Name = objRow["View_Name"].ToString().Trim();
				objALL_VIEWS.Text_Length = Int32.Parse(objRow["Text_Length"].ToString().Trim());
				objALL_VIEWS.Text = objRow["Text"].ToString().Trim();
				arrObjList.Add(objALL_VIEWS);
			}
			objDT = null;
			return arrObjList;
		}

		public clsALL_VIEWSEN GetFirstALL_VIEWS(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select * from ALL_VIEWS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return null;
			}
			DataRow objRow = objDT.Rows[0];
			clsALL_VIEWSEN objALL_VIEWS = new clsALL_VIEWSEN();
			objALL_VIEWS.OwnerView_Name = objRow["OwnerView_Name"].ToString().Trim();
			objALL_VIEWS.Owner = objRow["Owner"].ToString().Trim();
			objALL_VIEWS.View_Name = objRow["View_Name"].ToString().Trim();
			objALL_VIEWS.Text_Length = Int32.Parse(objRow["Text_Length"].ToString().Trim());
			objALL_VIEWS.Text = objRow["Text"].ToString().Trim();
			objDT = null;
			return objALL_VIEWS;
		}



		/// <summary>
		/// 功能：获取某一条件的相关表视图(View)
		/// </summary>
		/// <param name="strCondition">条件串</param>
		/// <returns>返回已经转换代码的DataTable</returns>
		public static System.Data.DataTable GetALL_VIEWSV(string strCondition)
		{
			StringBuilder strSQL = new StringBuilder(); 
			System.Data.DataTable objDT=null; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL.Append("Select vALL_VIEWS.* ");
			strSQL.Append(" from vALL_VIEWS ");
			strSQL.Append(" where " + strCondition); 
			objDT = objSQL.GetDataTable(strSQL.ToString());
			return objDT;
		}


		public override bool IsExist()
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			if (objSQL.IsExistRecord("ALL_VIEWS", "OwnerView_Name=" + "'"+ mstrOwnerView_Name+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool IsExist(string strOwnerView_Name)
		{
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			if (objSQL.IsExistRecord("ALL_VIEWS", "OwnerView_Name=" + "'"+ strOwnerView_Name+"'") )
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
			if (Object.Equals(null, mstrOwnerView_Name ) 
				|| (!Object.Equals(null, mstrOwnerView_Name ) && mstrOwnerView_Name .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[拥有者视图名]不能为空(NULL)!");
			}
			if (Object.Equals(null, mstrOwner ) 
				|| (!Object.Equals(null, mstrOwner ) && mstrOwner .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[拥有者]不能为空(NULL)!");
			}
			if (Object.Equals(null, mstrView_Name ) 
				|| (!Object.Equals(null, mstrView_Name ) && mstrView_Name .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[视图名]不能为空(NULL)!");
			}
			if (Object.Equals(null, mintText_Length ) 
				|| (!Object.Equals(null, mintText_Length ) && mintText_Length .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[文本长度]不能为空(NULL)!");
			}
			if (Object.Equals(null, mstrText ) 
				|| (!Object.Equals(null, mstrText ) && mstrText .ToString() == "")
				)
			{
				throw new clsDbObjException("字段[文本内容]不能为空(NULL)!");
			}
			if (!Object.Equals(null, mstrOwnerView_Name)  && getStrLen(mstrOwnerView_Name) > 100)
			{
				throw new clsDbObjException("字段[拥有者视图名]的长度不能超过100!");
			}
			if (!Object.Equals(null, mstrOwner)  && getStrLen(mstrOwner) > 30)
			{
				throw new clsDbObjException("字段[拥有者]的长度不能超过30!");
			}
			if (!Object.Equals(null, mstrView_Name)  && getStrLen(mstrView_Name) > 30)
			{
				throw new clsDbObjException("字段[视图名]的长度不能超过30!");
			}
		}

		public override ArrayList GetID(string strCondtion ) 
		{
			string strSQL ;
			System.Data.DataTable objDT ;
			ArrayList arrList = new ArrayList();
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			int iRow, iCol; 
			string strKeyValue; 
			strSQL = "Select OwnerView_Name from ALL_VIEWS where " + strCondtion;
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
			strSQL = "Select OwnerView_Name from ALL_VIEWS where " + strCondtion;
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
			strSQL = "Select OwnerView_Name from ALL_VIEWS where " + strCondtion;
			try
			{
				objDT = objSQL.GetDataTable(strSQL);
			}
			catch (Exception objException )
			{
				LogErrorS(objException, "clsALL_VIEWSEN");
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