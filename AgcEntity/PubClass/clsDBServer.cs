using System;
using com.taishsoft.common;

namespace AGC.Entity
{
	/// <summary>
	/// clsDBServer 的摘要说明。
	/// </summary>
	public class clsDBServer
	{

		private string mstrServer;	//目标IP或服务器名
		private string mstrDataBase;	//用户数据库名
		private string mstrUserIDForMaster;	//用户ID For Master库
		private string mstrUserIDForDB;	//用户ID	for DataBase
		private string mstrPassWordForMaster;		//用户口令
		private string mstrPassWordForDB;		//用户口令
		private string mstrTabName;			//当前用户选择的表名
		private int mintTabIndex;			//当前所选表的索引
		private string mstrMainFunc;		//生成代码的主要功能
		private string mstrCodeFunction;		//生成代码的功能：
		private bool mbolIsUseCtl;			//是否使用控件
		private string mstrNameSpace;		//域名
		private string mstrUserId;			//使用本系统的用户ID
		//		AutoGenFile.clsTabInfo objTabInfo=null;

		/// <summary>
		/// 生成代码的功能共分6类，分别如下：
		/// 0：全部代码；
		/// 1：定义私有变量
		/// 2: 插入记录
		/// 3: 修改记录
		/// 4: 删除记录
		/// 5: 显示表记录
		/// 
		/// </summary>
		public clsDBServer()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//

		}
		/// <summary>
		/// 生成代码的功能共分6类，分别如下：
		/// 0：全部代码；
		/// 1：定义私有变量
		/// 2: 插入记录
		/// 3: 修改记录
		/// 4: 删除记录
		/// 5: 显示表记录
		/// 
		/// </summary>
		public string MainFunc
		{
			get
			{
				return mstrMainFunc;
			}
			set 
			{
				mstrMainFunc = value;
			}
		}

		public string UserId
		{
			get 
			{
				return mstrUserId;
			}
			set
			{
				mstrUserId = value;
			}
		}
		public string MyNameSpace
		{
			get
			{
				return mstrNameSpace;
			}
			set
			{
				mstrNameSpace = value;
			}
		}
		
		public string CodeFunction
		{
			get
			{
				return mstrCodeFunction;
			}
			set 
			{
				mstrCodeFunction = value;
			}
		}
		public bool IsUseCtl
		{
			get
			{
				return mbolIsUseCtl;
			}
			set
			{
				mbolIsUseCtl = value;
			}
		}
		public string Server
		{
			get
			{
				return mstrServer;
			}
			set
			{
				mstrServer = value;
			}
		}
		public string DataBase
		{
			get 
			{
				return mstrDataBase;
			}
			set 
			{
				mstrDataBase = value;
			}
		}
		public string UserIDForMaster
		{
			get
			{
				return mstrUserIDForMaster;
			}
			set
			{
				mstrUserIDForMaster= value;
			}
		}
		public string UserIDForDB
		{
			get
			{
				return mstrUserIDForDB;
			}
			set
			{
				mstrUserIDForDB= value;
			}
		}

		public string PassWordForMaster
		{
			get
			{
				return mstrPassWordForMaster;
			}
			set
			{
				mstrPassWordForMaster = value;
			}
		}
		public string PassWordForDB
		{
			get
			{
				return mstrPassWordForDB;
			}
			set
			{
				mstrPassWordForDB = value;
			}
		}

		public string TabName
		{
			get
			{
				return mstrTabName;
			}
			set 
			{
				mstrTabName = value;
				new clsString().FstUcase(ref mstrTabName);	//	使表名的第一个字母为大写
			}
		}
		public int TabIndex 
		{
			get 
			{
				return mintTabIndex;
			}
			set
			{
				mintTabIndex = value;
			}
		}
		public string ClsName
		{
			get
			{
				string strClsName;
				strClsName = "cls" + mstrTabName;
				return strClsName;
			}
		}

	}
}
