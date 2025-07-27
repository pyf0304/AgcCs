using System;
using System.Data; 
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using System.Collections.Generic;


namespace AGC.Entity
{
	public class clsWorkStepPointEN : clsGeneralTab
	{
		public const string CurrTabName_S = "WorkStepPoint";    //当前表名，与该类相关的表名
		public const string CurrTabKeyFldName_S = "PointID";    //当前表中的关键字名称，与该类相关的表中关键字名
		//以下是属性变量
		///该函数不存在:

		protected string mstrPointID;
		protected string mstrPointName;
		protected int mintpLeft;
		protected int mintpTop;
		protected string mstrMemo;
		protected string mstrImgFile;

		public clsWorkStepPointEN()
		{
			SetInit();
			_CurrTabName = "WorkStepPoint";
			KeyFldName = "PointID";
		}

		public clsWorkStepPointEN(string strPointID)
		{

			mstrPointID=strPointID;
			SetInit();
			_CurrTabName = "WorkStepPoint";
			KeyFldName = "PointID";
		}

		public clsWorkStepPointEN(string strPointID, bool bolIsGetWorkStepPoint)
		{

			mstrPointID=strPointID;
			SetInit();
			if (bolIsGetWorkStepPoint==true)
			{
				GetWorkStepPoint();
			}
			_CurrTabName = "WorkStepPoint";
			KeyFldName = "PointID";
		}


		public string PointID
		{
			get
			{
				return mstrPointID;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrPointID = value;
				}
				else
				{
					mstrPointID = value;
				}
			}
		}
		public string PointName
		{
			get
			{
				return mstrPointName;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrPointName = value;
				}
				else
				{
					mstrPointName = value;
				}
			}
		}
		public int pLeft
		{
			get
			{
				return mintpLeft;
			}
			set
			{
				mintpLeft = value;
			}
		}
		public int pTop
		{
			get
			{
				return mintpTop;
			}
			set
			{
				mintpTop = value;
			}
		}
		public string Memo
		{
			get
			{
				return mstrMemo;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrMemo = value;
				}
				else
				{
					mstrMemo = value;
				}
			}
		}
		public string ImgFile
		{
			get
			{
				return mstrImgFile;
			}
			set
			{
				if (value == "")
				{
					mintErrNo = 1;
					mstrImgFile = value;
				}
				else
				{
					mstrImgFile = value;
				}
			}
		}

		public override bool AddNewRecord()
		{
			string strSQL; 
			System.Data.SqlClient.SqlDataAdapter objDA ; 
			System.Data.DataSet objDS = new System.Data.DataSet();
			System.Data.SqlClient.SqlCommandBuilder objCB ; 
			System.Data.DataRow objRow; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from WorkStepPoint where 1=2";
			objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
			objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
			objDA.Fill(objDS, "WorkStepPoint");
			objRow = objDS.Tables["WorkStepPoint"].NewRow();
			objRow["PointID"] = mstrPointID;
			objRow["PointName"] = mstrPointName;
			objRow["pLeft"] = mintpLeft;
			objRow["pTop"] = mintpTop;
			if (mstrMemo != "")
			{
				objRow["Memo"] = mstrMemo;
			}
			objRow["ImgFile"] = mstrImgFile;
			objDS.Tables["WorkStepPoint"].Rows.Add(objRow);
			try
			{
				objDA.Update(objDS, "WorkStepPoint");
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				objDA = null;
				objDS = null;
				objCB = null;
				objRow = null;
			}
			return true;
		}



		public bool AddnewWorkStepPointBySP() 
		{
			//通过存储过程来
			//直接使用
			if ( mintErrNo != 0 ) 
			{
				//MsgBox(mstrErrMsg(mintErrNo))
				return false;
			}
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			objSQL.SPConfigXMLFile ="..\\XML\\XMLSP.xml";
			//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
			ArrayList values = new ArrayList();
			values.Add(mstrPointID);
			values.Add(mstrPointName);
			values.Add(mintpLeft);
			values.Add(mintpTop);
			values.Add(mstrMemo);
			values.Add(mstrImgFile);
			objSQL.ExecSP("AddnewWorkStepPoint",values);
			return true;
		}

		/// <summary>
		/// 把多条记录同时插入到表中!
		/// </summary>
		/// <param name="oDT"></param>
		/// <param name="strResult"></param>
		/// <returns></returns>
		public  bool AddnewWorkStepPoints(System.Data.DataTable oDT, ref string strResult) 
		{
			string strSQL;
			System.Data.SqlClient.SqlDataAdapter objDA;
			System.Data.DataSet objDS = new System.Data.DataSet();
			System.Data.SqlClient.SqlCommandBuilder objCB; 
			System.Data.DataRow objRow;
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			if (mintErrNo != 0 ) 
			{
				strResult = "错误号为：" + mintErrNo.ToString();
				return false;
			}
			strSQL = "Select * from WorkStepPoint where PointID='111'";
			objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
			objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
			objDA.Fill(objDS, "WorkStepPoint");
			//检查关键字的唯一性
			foreach(System.Data.DataRow oRow in oDT.Rows)
			{
				string strPointID =oRow["PointID"].ToString().Trim();
				if (IsExist(strPointID))
				{
					strResult = "关键字PointID为：" + strPointID + "的记录已存在，不能重复插入!" ;
					return false;
				}
			}
			//把多条记录插入到表中
			foreach(System.Data.DataRow oRow in oDT.Rows)
			{
				objRow = objDS.Tables["WorkStepPoint"].NewRow();
				objRow["PointID"] = oRow["PointID"].ToString().Trim();
				objRow["PointName"] = oRow["PointName"].ToString().Trim();
				objRow["pLeft"] = oRow["pLeft"].ToString().Trim();
				objRow["pTop"] = oRow["pTop"].ToString().Trim();
				objRow["Memo"] = oRow["Memo"].ToString().Trim();
				objRow["ImgFile"] = oRow["ImgFile"].ToString().Trim();
				objDS.Tables["WorkStepPoint"].Rows.Add(objRow);
			}
			try
			{
				objDA.Update(objDS, "WorkStepPoint");
			}
			catch(Exception objException) 
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				objDA = null;
				objDS = null;
				objCB = null;
				objRow = null;
				objSQL.SQLConnect.Close();
				objSQL = null;
			}
			return true;
		}

		public override bool Update() 
		{
			string strSQL ;
			System.Data.SqlClient.SqlDataAdapter objDA ;
			System.Data.DataSet objDS = new System.Data.DataSet();
			System.Data.SqlClient.SqlCommandBuilder objCB ;
			System.Data.DataRow objRow ;
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from WorkStepPoint where PointID=" + "'"+ mstrPointID+"'";
			objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
			objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
			objDA.Fill(objDS, "WorkStepPoint");
			if (objDS.Tables["WorkStepPoint"].Rows.Count == 0 )
			{
				//MsgBox("没有相应的ID号：PointID=" + "'"+ mstrPointID+"'");
				return false;
			}
			objRow = objDS.Tables["WorkStepPoint"].Rows[0];
			objRow["PointName"] = mstrPointName;
			objRow["pLeft"] = mintpLeft;
			objRow["pTop"] = mintpTop;
			objRow["Memo"] = mstrMemo;
			objRow["ImgFile"] = mstrImgFile;
			try
			{
				objDA.Update(objDS, "WorkStepPoint");
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				objDA = null;
				objDS = null;
				objCB = null;
				objRow = null;
			}
			return true;
		}



		/// <summary>
		/// 功能：修改多条记录
		/// </summary>
		/// <param name="strCondition"></param>
		/// <returns></returns>
		public override int UpdateMultiRec(string strCondition) 
		{
			string strSQL ;
			System.Data.SqlClient.SqlDataAdapter objDA ;
			System.Data.DataSet objDS = new System.Data.DataSet();
			System.Data.SqlClient.SqlCommandBuilder objCB ;
			//			System.Data.DataRow objRow ;
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			int intRecCount;
			if (strCondition == "")
			{
				return 0;   //表示删除0条记录，实际上是不能该表的所有记录
			}
			strSQL = "Select * from WorkStepPoint where " + strCondition;
			objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
			objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
			objDA.Fill(objDS, "WorkStepPoint");
			if (objDS.Tables["WorkStepPoint"].Rows.Count == 0 )
			{
				return 0;
			}
			intRecCount = objDS.Tables["WorkStepPoint"].Rows.Count;
			foreach(System.Data.DataRow objRow in objDS.Tables["WorkStepPoint"].Rows)
			{
				objRow["PointName"] = mstrPointName;
				objRow["pLeft"] = mintpLeft;
				objRow["pTop"] = mintpTop;
				objRow["Memo"] = mstrMemo;
				objRow["ImgFile"] = mstrImgFile;
			}
			try
			{
				objDA.Update(objDS, "WorkStepPoint");
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				objDA = null;
				objDS = null;
				objCB = null;
			}
			return intRecCount;
		}


		public override bool DelRecord() 
		{
			string strSQL = "";
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			//删除WorkStepPoint本表中与当前对象有关的记录
			strSQL = strSQL + "Delete from WorkStepPoint where PointID=" + "'"+ mstrPointID+"'";
			return objSQL.ExecSql(strSQL);
		}


		//同时删除多条记录
		public static bool DelWorkStepPoint(ArrayList lstKey)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
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
			//删除WorkStepPoint本表中与当前对象有关的记录
			strSQL = strSQL + "Delete from WorkStepPoint where PointID in (" + strKeyList + ")";
			return objSQL.ExecSql(strSQL);
		}

		public static bool DelRecord(string strPointID) 
		{
			//删除单条记录
			string strSQL = "";
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			//删除WorkStepPoint本表中与当前对象有关的记录
			strSQL = strSQL + "Delete from WorkStepPoint where PointID=" + "'"+ strPointID+"'";
			return objSQL.ExecSql(strSQL);
		}


		/// <summary>
		/// 功能：删除多条记录，带条件的删除
		/// </summary>
		/// <param name="strCondition">需要删除的记录条件</param>
		/// <returns>返回删除的记录0。</returns>
		public static int DelWorkStepPoint(string strCondition)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strSQL;
			if (strCondition == "")
			{
				return 0;	//表示删除0条记录，实际上是不能该表的所有记录
			}
			else
			{
				strSQL =  "Delete from WorkStepPoint where " + strCondition ;
			}
			int intRecoCount =  objSQL.ExecSql2(strSQL);
			return intRecoCount;
		}


		public bool GetWorkStepPoint()
		{
			string strSQL ;
			System.Data.DataTable objDT ; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from WorkStepPoint where PointID=" + "'"+ mstrPointID+"'";
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return false;
			}
			mstrPointID=objDT.Rows[0]["PointID"].ToString().Trim();
			mstrPointName=objDT.Rows[0]["PointName"].ToString().Trim();
			mintpLeft=TransNullToInt(objDT.Rows[0]["pLeft"].ToString().Trim());
			mintpTop=TransNullToInt(objDT.Rows[0]["pTop"].ToString().Trim());
			mstrMemo=objDT.Rows[0]["Memo"].ToString().Trim();
			mstrImgFile=objDT.Rows[0]["ImgFile"].ToString().Trim();
			objDT = null;
			return true;
		}

		public static System.Data.DataTable GetWorkStepPoint(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from WorkStepPoint where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}



		/// <summary>
		/// 功能：获取某一条件的相关表视图(View)
		/// </summary>
		/// <param name="strCondition">条件串</param>
		/// <returns>返回已经转换代码的DataTable</returns>
		public static System.Data.DataTable GetWorkStepPointV(string strCondition)
		{
			StringBuilder strSQL = new StringBuilder(); 
			System.Data.DataTable objDT=null; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL.Append("Select vWorkStepPoint.* ");
			strSQL.Append(" from vWorkStepPoint ");
			strSQL.Append(" where " + strCondition); 
			objDT = objSQL.GetDataTable(strSQL.ToString());
			return objDT;
		}


		public override bool IsExist()
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			if (objSQL.IsExistRecord("WorkStepPoint", "PointID=" + "'"+ mstrPointID+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool IsExist(string strPointID)
		{
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			if (objSQL.IsExistRecord("WorkStepPoint", "+PointID=" + "'"+ strPointID+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool CheckProperty(ref string strResult)
		{
			if (Object.Equals(null, mstrPointID ) 
				|| (!Object.Equals(null, mstrPointID ) && mstrPointID .ToString() == "")
				)
			{
				strResult = "字段[PointID]不能为空(NULL)!";
				return false;
			}
			if (Object.Equals(null, mstrPointName ) 
				|| (!Object.Equals(null, mstrPointName ) && mstrPointName .ToString() == "")
				)
			{
				strResult = "字段[PointName]不能为空(NULL)!";
				return false;
			}
			if (Object.Equals(null, mstrImgFile ) 
				|| (!Object.Equals(null, mstrImgFile ) && mstrImgFile .ToString() == "")
				)
			{
				strResult = "字段[图像文件]不能为空(NULL)!";
				return false;
			}
			if (!Object.Equals(null, mstrPointID)  && getStrLen(mstrPointID) > 8)
			{
				strResult = "字段[PointID]的长度不能超过8!";
				return false;
			}
			if (!Object.Equals(null, mstrPointName)  && getStrLen(mstrPointName) > 100)
			{
				strResult = "字段[PointName]的长度不能超过100!";
				return false;
			}
			if (!Object.Equals(null, mstrMemo)  && getStrLen(mstrMemo) > 1000)
			{
				strResult = "字段[说明]的长度不能超过1000!";
				return false;
			}
			if (!Object.Equals(null, mstrImgFile)  && getStrLen(mstrImgFile) > 100)
			{
				strResult = "字段[图像文件]的长度不能超过100!";
				return false;
			}
			return true;
		}

        public override List<string> GetID(string strCondtion) 
		{
			string strSQL ;
			System.Data.DataTable objDT ;
            List<string> arrList = new List<string>();
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			int iRow, iCol; 
			string strKeyValue; 
			strSQL = "Select PointID from WorkStepPoint where " + strCondtion;
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
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strKeyValue; 
			strSQL = "Select PointID from WorkStepPoint where " + strCondtion;
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
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			string strKeyValue; 
			strSQL = "Select PointID from WorkStepPoint where " + strCondtion;
			try
			{
				objDT = objSQL.GetDataTable(strSQL);
			}
			catch (Exception objException )
			{
				LogErrorS(objException, "clsWorkStepPoint");
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