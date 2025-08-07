using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

using System.Collections.Generic;
using AGC.Entity;
using AGC.BusinessLogic;
using System.Linq;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{

    public partial class clsExcelExportRegionFldsBLEx 
	{
        public List<clsPrjTabFldENEx> arrFieldTabExObjLst = null;			//界面相关详细表字段集合

		public clsPrjTabFldENEx objPrjTabFldENEx = null;

        public static void initExcelExportRegionFldSet(clsViewInfoENEx objViewInfoENEx)
        {
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //  然后存到集合中
            //3、
            ///
            objViewInfoENEx.TabKeyFldNum = 0;

            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(objViewInfoENEx.ViewId,
                clsRegionTypeENEx.EXCELEXPORT_REGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //objViewInfoENEx.objExcelExportRegionENEx = new clsExcelExportRegionENEx(lngRegionId);
            //clsExcelExportRegionBLEx.GetExcelExportRegionEx(ref objViewInfoENEx.objExcelExportRegionENEx, objViewInfoENEx.PrjId);

            objViewInfoENEx.arrExcelExportRegionFldSet = clsExcelExportRegionFldsBLEx.GetObjExLst4InUse1(lngRegionId, objViewInfoENEx.PrjId);

            //objViewInfoENEx.objExcelExportRegionENEx.FieldNum = objViewInfoENEx.arrExcelExportRegionFldSet.Count;
            foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
            {
				try
				{
					objExcelExportRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objExcelExportRegionFldsEx.FldId, objViewInfoENEx.PrjId);
				}
				catch(Exception objException)
                {
                    Console.WriteLine(objException.ToString());
                }
            }
        }


      



        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_ExcelExportRegionFlds(System.Windows.Forms.ListView lvExcelExportRegionFlds, string strWhereCond)
		{
			//操作步骤:(共4步)
			//	1、组合界面条件串；
			//	2、根据条件串获取该表满足条件的DataTable；
			//	3、设置ListView的列头信息
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			//		在本界面中是把状态显示在控件lblRecCount中。

			System.Windows.Forms.ListViewItem lviExcelExportRegionFlds;
            List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjList;
			//	2、根据条件串获取该表满足条件的DataTable；
			arrExcelExportRegionFldsObjList = clsExcelExportRegionFldsBL.GetObjLst(strWhereCond);
			//	3、设置ListView的列头信息
			lvExcelExportRegionFlds.Items.Clear();//清除原来所有Item
			lvExcelExportRegionFlds.Columns.Clear();//清除原来所有列头信息
			lvExcelExportRegionFlds.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("区域Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("列标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("表字段ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvExcelExportRegionFlds.View = System.Windows.Forms.View.Details;
			//	4、设置ListView的Item信息。即把所有记录显示在ListView中
			foreach (clsExcelExportRegionFldsEN objExcelExportRegionFldsEN in arrExcelExportRegionFldsObjList)
			{
				lviExcelExportRegionFlds = new System.Windows.Forms.ListViewItem();
				lviExcelExportRegionFlds.Tag = objExcelExportRegionFldsEN.mId;
				lviExcelExportRegionFlds.Text = objExcelExportRegionFldsEN.mId.ToString();
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.RegionId.ToString());
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.SeqNum.ToString());
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.ColCaption);
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.FldId.ToString());
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.UpdDate);
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.UpdUser);
				lviExcelExportRegionFlds.SubItems.Add(objExcelExportRegionFldsEN.Memo);
				lvExcelExportRegionFlds.Items.Add(lviExcelExportRegionFlds);
			}
			//	4、设置记录数的状态,
			//		在本界面中是把状态显示在控件txtRecCount中。
			return arrExcelExportRegionFldsObjList.Count;
		}
        public static ArrayList GetObjLstEx(string strCondition)
		{
			ArrayList arrObjList = new ArrayList(); 
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
			strSQL = "Select * from ExcelExportRegionFlds where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count  ==  0)
			{
				objDT = null;
				return arrObjList;
			}
			foreach(DataRow objRow in objDT.Rows)
			{
				clsExcelExportRegionFldsENEx objExcelExportRegionFldsEN = new clsExcelExportRegionFldsENEx();
				objExcelExportRegionFldsEN.mId = Int32.Parse(objRow["mId"].ToString().Trim());
				objExcelExportRegionFldsEN.RegionId = objRow["RegionId"].ToString().Trim();
				objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow["SeqNum"].ToString().Trim());
				objExcelExportRegionFldsEN.ColCaption = objRow["ColCaption"].ToString().Trim();
				objExcelExportRegionFldsEN.FldId = objRow["FldId"].ToString().Trim();
				objExcelExportRegionFldsEN.UpdDate = objRow["UpdDate"].ToString().Trim();
				objExcelExportRegionFldsEN.UpdUser = objRow["UpdUser"].ToString().Trim();
				objExcelExportRegionFldsEN.Memo = objRow["Memo"].ToString().Trim();
				arrObjList.Add(objExcelExportRegionFldsEN);
			}
			objDT = null;
			return arrObjList;
		}
		public new static void ReOrder(string lngRegionId)
		{
            IEnumerable<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjList = clsExcelExportRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            arrExcelExportRegionFldsObjList = arrExcelExportRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);

            int intIndex = 1;
			foreach(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN in arrExcelExportRegionFldsObjList)
			{
				objExcelExportRegionFldsEN.SeqNum = intIndex;
                clsExcelExportRegionFldsBL.UpdateBySql2(objExcelExportRegionFldsEN);
				intIndex ++;
			}
		}
		public static bool AdjustSequenceNumber(string strDirect, long lngMid)
		{
			//操作步骤:
			//1、获取当前所选中的关键字Mid。
			//2、根据关键字Mid来获取字的序号
			//3、如果当前序号是否是末端序号,
			//		3.1 如果是末端序号,就退出,
			//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
			//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
			//		    如果是向上移动,就判断当前序号是否“大于”1,
			//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
			//4、获取下(上)一个序号字段的关键字Mid
			//5、把当前关键字Mid的序号加(减)1
			//6、把下一个序号的关键字Mid减(加)1
			//7、重新显示DATAGRID
			///
			int intSeqNum;	//当前记录的序号
			int intPrevSeqNum, intNextSeqNum;	//上下两条记录的序号
			//			string strMid;
			long lngPrevMid = 0;	//上一条序号的关键字MId
			long lngNextMid = 0;	//下一条序号的关键字MId
			int intTabRecNum;       //当前表中字段的记录数
            string strCurrRegionId;
			List<string > arrID;
			StringBuilder strCondition = new StringBuilder();
			//1、获取当前所选中的字段ID。

            clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsBL.GetObjBymId(lngMid);
			intSeqNum = objExcelExportRegionFldsEN.SeqNum;
			intPrevSeqNum = intSeqNum - 1;
			intNextSeqNum = intSeqNum + 1;
			//3、如果当前序号是否是末端序号,
			//		3.1 如果是末端序号,就退出,
			strCurrRegionId = objExcelExportRegionFldsEN.RegionId;		//获取当前记录的{表ID}
			intTabRecNum = clsGeneralTab2.funGetRecCountByCond(clsExcelExportRegionFldsEN._CurrTabName, "RegionId = '" + strCurrRegionId + "'");	//获取当前{表ID}的记录数
			if (strDirect  ==  "UP")
			{
				if (intSeqNum <=  1)
				{
					throw new clsDbObjException("已经是第一条记录,不能再上移!");
				}
			}
			else if (strDirect  ==  "DOWN")
			{
				if (intSeqNum >=  intTabRecNum)	//如果当前序号大于表记录数
				{
					throw new clsDbObjException("已经是最后一条记录,不能再下移!");
				}
			}
			///		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
			///		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
			///		    如果是向上移动,就判断当前序号是否“大于”1,
			///		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。

			//4、获取下(上)一个序号字段的关键字Mid
			if (strDirect  ==  "UP")
			{
				strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}", 
					strCurrRegionId, intSeqNum -1);
				arrID = clsExcelExportRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
				if (arrID  ==  null)
				{
					throw new clsDbObjException("获取上一条记录的关键字出错!");
					
				}
				if (arrID.Count <=  0)
				{
					throw new clsDbObjException("获取上一条记录的关键字出错!");
				}
				lngPrevMid = long.Parse((string)arrID[0]);
			}
			else if (strDirect  ==  "DOWN")
			{
				strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}", 
					strCurrRegionId, intSeqNum + 1);
				arrID = clsExcelExportRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
				if (arrID  ==  null)
				{
					throw new clsDbObjException("获取下一条记录的关键字出错!");
					
				}
				if (arrID.Count <=  0)
				{
					throw new clsDbObjException("获取下一条记录的关键字出错!");
				}
				lngNextMid = long.Parse((string)arrID[0]);
			}
            else if (strDirect  ==  "FIRST")
            {
            }
            else if (strDirect  ==  "LAST")
            {
            }
			else 
			{
				throw new clsDbObjException("方向参数出错!");
			}
			//5、把当前关键字Mid的序号加(减)1
			//6、把下一个序号的关键字Mid减(加)1
			if (strDirect  ==  "UP")
			{
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intSeqNum-1, "MId = " + lngMid);
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intPrevSeqNum + 1, "MId = " + lngPrevMid);
			}
			else if (strDirect  ==  "DOWN")
			{
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intSeqNum + 1, "MId = " + lngMid);
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intNextSeqNum - 1, "MId = " + lngNextMid);
			}
            else if (strDirect  ==  "FIRST")
            {
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", 0, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect  ==  "LAST")
            {
                clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, "SeqNum", intTabRecNum + 1, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            //7、重新显示DATAGRID
            clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

            return true;
		}


        public static bool AddColumn_SourceTabName(ref System.Data.DataTable objDT)
        {
            objDT.Columns.Add("SourceTabName");
            foreach (DataRow objDR in objDT.Rows)
            {
                string strPrjId = objDR[convExcelExportRegionFlds.PrjId].ToString();
                //string 1strFldID = objDR[convExcelExportRegionFlds.FldId].ToString();
                string strFldName = objDR[convExcelExportRegionFlds.FldName].ToString();
                string strTabId = objDR[convExcelExportRegionFlds.TabId].ToString();
                try
                {

					//var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
					clsvSqlViewFldEN objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFieldAliasesExCache(strPrjId, strTabId, strFldName);
                    if (objvSqlViewFldEN  ==  null)
                    {
                        objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFldNameExCache(strPrjId, strTabId, strFldName);

                    }
                    if (objvSqlViewFldEN !=  null)
                    {
                        objDR["SourceTabName"] = objvSqlViewFldEN.TabName;
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                }
            }

            return true;
        }

		public static clsExcelExportRegionFldsENEx GetObjEx(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
		{
			clsExcelExportRegionFldsENEx objExcelExportRegionFldsENEx = new clsExcelExportRegionFldsENEx();
			CopyTo(objExcelExportRegionFlds, objExcelExportRegionFldsENEx);
			return objExcelExportRegionFldsENEx;
		}

		public static List<clsExcelExportRegionFldsEN> GetObjLstByRegionIdEx(string lngRegionId)
		{
			//初始化列表缓存
			string strCondition = string.Format("{0}={1}", conExcelExportRegionFlds.RegionId, lngRegionId);
			List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel = clsExcelExportRegionFldsBL.GetObjLst(strCondition);
			return arrExcelExportRegionFldsObjLst_Sel;

		}

		public static clsErrMsgENEx CheckRegionFlds(string strRegionId, string strCmPrjId, string strOpUserId)
		{
            string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            //1、获取当前区域ID的相关主表ID；
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            string strMsg = "";
			int intErrCount = 0;
			var arrExcelExportRegionFlds = clsExcelExportRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
			var arrExcelExportRegionFldsEx = arrExcelExportRegionFlds.Select(clsExcelExportRegionFldsBLEx.GetObjEx).ToList();
			//StringBuilder sbErrMsg = new StringBuilder();
			//try
			//{

			foreach (var objInFor in arrExcelExportRegionFldsEx)
			{
				if (objInFor.InUse == false) continue;
				try
				{
                    if (string.IsNullOrEmpty(objInFor.FldId) == true)
                    {
                        strMsg = $"控件:[{objInFor.ColCaption}]的字段Id(FldId)为空！({clsStackTrace.GetCurrClassFunctionByLevel(2)})";
                        throw new Exception(strMsg);
                    }
                    if (objInFor.IsTabField() == false)
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldId, objInFor.PrjId);
                        strMsg = $"控件:[{objInFor.ColCaption}]的字段:[{objFieldTab.FldName}({objInFor.FldId})]，不在查询区的相关表中，请检查！({clsStackTrace.GetCurrClassFunctionByLevel(2)})";
                        throw new Exception(strMsg);
                    }

                    if (objInFor.DnPathId() != null )
                    {
						var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objInFor.DnPathId(), objInFor.PrjId);
						clsDnPathBLEx.CheckDnPath(objDnPath, strOpUserId);
						if (objDnPath.ErrMsg != null && objDnPath.ErrMsg.Length > 0)
                        {
							strMsg = string.Format("控件:[{0}]中，路径出错:[{1}].({2})",
		  objInFor.ColCaption, objDnPath.ErrMsg,
		clsStackTrace.GetCurrClassFunctionByLevel(2));
							throw new Exception(strMsg);
						}
						//clsPubFun4BLEx.CheckDnPath_In(objInFor);
					}
					
				}
				catch (Exception ex)
				{
					objInFor.ErrMsg = ex.Message;
					//if (objInFor.DnPathId == "") objInFor.DnPathId = null;
					objInFor.Update();
					intErrCount++;
					continue;
				}
				if (objInFor.ErrMsg != null && objInFor.ErrMsg.Length > 0)
				{
					objInFor.ErrMsg = "";
					//if (objInFor.DnPathId == "") objInFor.DnPathId = null;
					objInFor.Update();
					continue;
				}
			}
			//}
			//catch (Exception ex)
			//{
			//    sbErrMsg.AppendLine(ex.Message);
			//}
			//2、获取相关主表ID的字段的对象列表;
			var objErrMsg = new clsErrMsgENEx(conErrType.ExcelExportRegion, intErrCount);
			var objViewRegion = clsViewRegionBL.GetObjByRegionId(strRegionId);
			if (objViewRegion != null)
			{
				if (intErrCount > 0)
				{
					objViewRegion.ErrMsg = objErrMsg.ToString();
					objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(0);
					objViewRegion.Update();
				}
				else
				{
					objViewRegion.ErrMsg = "";
					objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(0);
					objViewRegion.Update();
				}
			}
			return objErrMsg;
		}

		public static bool CheckRegionFldsUp(string strRegionId, string strCmPrjId, string strOpUserId)
		{
            var strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var objErrMsg_New = CheckRegionFlds(strRegionId, strCmPrjId, strOpUserId);
			var arrViewId = clsViewRegionRelaBLEx.GetViewIdLstByRegionIdCache(strRegionId, strPrjId_p);
			var arrViewInfo = clsViewInfoBL.GetObjLstByViewIdLstCache(arrViewId, strPrjId_p);
			if (objErrMsg_New.ErrNum == 0)
			{
				foreach (var objInFor in arrViewInfo)
				{
                    if (objInFor.ErrMsg == null) continue;
                    if (objInFor.ErrMsg.Length == 0) continue;
					var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
					if (arrErrMsg == null) continue;
					if (arrErrMsg.Count == 0) continue;
					var arrErrMsg_Del = arrErrMsg.Where(x => x.ErrType != objErrMsg_New.ErrType).ToList();
					string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg_Del);
					objInFor.ErrMsg = strErrMsg_New;
					objInFor.Update();
				}
			}
			else
			{

				foreach (var objInFor in arrViewInfo)
				{
					var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
					clsErrMsgBLEx.AddObj(arrErrMsg, objErrMsg_New);
					string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg);
					objInFor.ErrMsg = strErrMsg_New;
					objInFor.Update();
				}
			}
			return true;
		}

		public static clsExcelExportRegionFldsENEx GetObjExBymIdCache(long lngMid, string strPrjId)
		{
			//初始化列表缓存
			clsExcelExportRegionFldsEN objExcelExportRegionFlds = clsExcelExportRegionFldsBL.GetObjBymIdCache(lngMid, strPrjId);
			var objEx = CopyToEx(objExcelExportRegionFlds);
			return objEx;
		}
	}
}