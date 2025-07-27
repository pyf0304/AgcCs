using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using com.taishsoft.datetime;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
	/// <summary>
	/// clsSysLogSever 的摘要说明。
	/// </summary>
	public class clsSysLogServerBLEx
	{
		private static bool IsAddJournalWin;
		/// <summary>
		/// 代表添加
		/// </summary>
		public static string Add="0001";

		/// <summary>
		/// 代表删除
		/// </summary>
		public static string Delete="0002";
		/// <summary>
		/// 代表修改
		/// </summary>
		public static string Update="0003";

		public clsSysLogServerBLEx()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		/// <summary>
		/// 内部函数
		/// </summary>
		/// <param name="objSysLog"></param>
		/// <param name="strUserId">用户编号</param>
		/// <param name="strUserIp">用户IP</param>
		/// <param name="strOperationType">用户操作类型</param>
		/// <param name="strTableName">数据表的名称</param>
		/// <param name="strTableKey">数据表的关键字段名称</param>
		/// <param name="strJournal">日志内容</param>
		private static void PutDataToSysLogClass(clsSysLogEN pobjSysLog,
			string strUserId,
			string strUserIp,
			string strOperationTypeId,
			string strTableName,
			string strTableKey,
			string strJournal,
			string strPrjId)
		{
			pobjSysLog.UserId = strUserId;
			//pobjSysLog.UserName = wucSysLog1.UserName;
			pobjSysLog.UserIp = strUserIp;
			pobjSysLog.OpDate = clsDateTime.getTodayStr(0);
			pobjSysLog.OpTime = DateTime.Now.ToShortTimeString();
			pobjSysLog.OpTypeId = strOperationTypeId;
			pobjSysLog.TableName = strTableName;
			pobjSysLog.TableKey = strTableKey;
			pobjSysLog.OpContent = strJournal;
			pobjSysLog.PrjId = strPrjId;
		}
		/// <summary>
		/// 执行基本信息日志的添加
		/// </summary>
		/// <param name="strUserId">用户编号</param>
		/// <param name="strUserIp">用户IP</param>
		/// <param name="strOperationTypeId">操作类型号</param>
		/// <param name="strTableName">数据表名</param>
		/// <returns></returns>
		public  static bool AddSystemBaseJournalInfo(string strUserId,string strUserIp,string strOperationTypeId,string strTableName)
		{
			clsSysLogEN objSysLog=new clsSysLogEN();
			PutDataToSysLogClass(objSysLog,strUserId, strUserIp,strOperationTypeId,strTableName,null,null,null);	
			if (clsSysLogBL .AddNewRecordBySql2(objSysLog) == false) 
			{
				IsAddJournalWin=false;
			}
			else
			{
				IsAddJournalWin=true;
			}
			return IsAddJournalWin;
		}
		
		/// <summary>
		/// 日志添加操作(详细信息)
		/// </summary>
		/// <param name="strUserId">用户编号</param>
		/// <param name="strUserIp">用户IP</param>
		/// <param name="strOperationType">用户操作类型号</param>
		/// <param name="strTableName">数据表的名称</param>
		/// <param name="strTableKey">数据表的关键字段名称</param>
		/// <param name="strJournal">日志内容</param>
		/// <returns>返回成功与否的标志,bool类型</returns>
		public static  bool AddSysLogInfo(string strUserId,
			string strUserIp,
			string strOperationTypeId,
			string strTableName,
			string strTableKey,
			string strJournal,
			string strPrjId)
		{
			clsSysLogEN objSysLog=new clsSysLogEN();
			PutDataToSysLogClass(
				objSysLog,
				strUserId, 
				strUserIp,
				strOperationTypeId,
				strTableName,
				strTableKey,
				strJournal,
				strPrjId);
			try
			{
				if (clsSysLogBL.AddNewRecordBySql2(objSysLog) == false)
				{
					IsAddJournalWin = false;
				}
				else
				{
					IsAddJournalWin = true;
				}
			}
			catch(Exception objException)
            {
				clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
            }
			return IsAddJournalWin;
		}
	}
}
