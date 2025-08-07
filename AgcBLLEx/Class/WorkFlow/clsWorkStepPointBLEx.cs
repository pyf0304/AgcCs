using System;
using System.Collections;
using System.Data;
using com.taishsoft.commdb;
using AGC.Entity;

namespace AGC.BusinessLogicEx
{
	/// <summary>
	/// clsWorkStepPointEx 的摘要说明。
	/// </summary>
	public class clsWorkStepPointBLEx
	{
		public clsWorkStepPointBLEx()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public static ArrayList  GetWorkStepPointList(string strCondition)
		{
			string strSQL ;
			System.Data.DataTable objDT ; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from WorkStepPoint where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return null;
			}
			ArrayList arrList = new ArrayList();
			clsWorkStepPointEN objWordStepPoint;
			foreach(DataRow objRow in objDT.Rows)
			{
				objWordStepPoint = new clsWorkStepPointEN();

				objWordStepPoint.PointID=objRow["PointID"].ToString().Trim();
				objWordStepPoint.PointName=objRow["PointName"].ToString().Trim();
				objWordStepPoint.pLeft=TransNullToInt1(objRow["pLeft"].ToString().Trim());
				objWordStepPoint.pTop=TransNullToInt1(objRow["pTop"].ToString().Trim());
				objWordStepPoint.Memo=objRow["Memo"].ToString().Trim();
				objWordStepPoint.ImgFile=objRow["ImgFile"].ToString().Trim();
				arrList.Add(objWordStepPoint);
			}
			objDT = null;
			return arrList;
		}
		private static int TransNullToInt1(Object obj ) 
		{
			if (obj.ToString()=="")
			{
				return 0;
			}
			else
			{
				return Int32.Parse(obj.ToString());
			}
		}
	}
}
