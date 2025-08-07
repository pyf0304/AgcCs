using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.commexception;

using System.Collections.Generic;
using AGC.Entity;
using AGC.BusinessLogic;
using System.Linq;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
   
    public partial class clsDGRegionFldsBLEx
    {

        public List<clsPrjTabFldENEx> arrFieldTabExObjLst = null;           //界面相关详细表字段集合

        public static void initDGRegionFldSet(clsViewInfoENEx objViewInfoENEx, bool bolIsFstLcase)
        {
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //  然后存到集合中
            //3、
            //
            objViewInfoENEx.TabKeyFldNum = 0;


            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(objViewInfoENEx.ViewId,
                clsRegionTypeENEx.DGREGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty(lngRegionId) == true)
            {
                return;
            }
            //objViewInfoENEx.objDGRegionENEx = new clsDGRegionENEx(lngRegionId);
            //clsDGRegionBLEx.GetDGRegionEx(ref objViewInfoENEx.objDGRegionENEx, objViewInfoENEx.PrjId);
            objViewInfoENEx.arrDGRegionFldSet = clsDGRegionFldsBLEx.GetObjExList4InUse1(lngRegionId, objViewInfoENEx.PrjId);

            //objViewInfoENEx.objDGRegionENEx.FieldNum = objViewInfoENEx.arrDGRegionFldSet.Count;

            clsDGRegionFldsENEx objDGRegionFlds_Sel = objViewInfoENEx.arrDGRegionFldSet.Find(x => x.IsDefaultSort == true);
            if (objDGRegionFlds_Sel != null)
            {
                //clsPrjTabFldENEx ObjPrjTabFldENEx = clsPrjTabFldBLEx.InitPrjTabFld(objDGRegionFlds_Sel.TabFldId, objViewInfoENEx.PrjId);         
                objViewInfoENEx.FirstSortField = clsFieldTabBL.GetNameByFldIdCache(objDGRegionFlds_Sel.FldId, objDGRegionFlds_Sel.PrjId());
            }

            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet.FindAll(x => string.IsNullOrEmpty(x.FldId) == false))
            {
                objDGRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDGRegionFldsEx.FldId, objViewInfoENEx.PrjId);
                //if (objViewInfoENEx.objSortField_Out == null && objDGRegionFldsEx.ObjPrjTabFldENEx.PrimaryTypeId != enumPrimaryType.Identity_02)
                //{
                //    objViewInfoENEx.objSortField_Out = objDGRegionFldsEx.ObjPrjTabFldENEx;
                //}

                //if (objDGRegionFldsEx.ObjPrjTabFldENEx.IsSortFld == true)
                //{
                //    objViewInfoENEx.objSortField_Out = objDGRegionFldsEx.ObjPrjTabFldENEx;
                //}

                if (string.IsNullOrEmpty(objViewInfoENEx.FirstSortField) == false) continue;
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    objViewInfoENEx.FirstSortField = objDGRegionFldsEx.ObjFieldTabENEx.PropertyName(bolIsFstLcase);
                }
            }
        }
        /// <summary>
        /// 获取扩展对象列表，同时获取相关表对象属性
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsDGRegionFldsENEx> GetObjExLstEx(string strViewId, string strPrjId)
        {
            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId,
                clsRegionTypeENEx.DGREGION, strPrjId);
            if (string.IsNullOrEmpty(lngRegionId) == true)
            {
                return null;
            }

            List<clsDGRegionFldsENEx> arrDGRegionFldSet = clsDGRegionFldsBLEx.GetObjExList(lngRegionId, strPrjId);

            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in arrDGRegionFldSet)
            {
                //if (objDGRegionFldsEx.TabFldId == 0) continue;
                objDGRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDGRegionFldsEx.FldId, strPrjId);
            }
            return arrDGRegionFldSet;
        }


        /// <summary>
        /// 获取扩展对象列表
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static List<clsDGRegionFldsENEx> GetObjExLst(string strCondition)
        {
            List<clsDGRegionFldsEN> arrObjList = clsDGRegionFldsBL.GetObjLst(strCondition);
            List<clsDGRegionFldsENEx> arrObjExLst = new List<clsDGRegionFldsENEx>();

            foreach (clsDGRegionFldsEN objInFor in arrObjList)
            {
                clsDGRegionFldsENEx objDGRegionFldsENEx = new clsDGRegionFldsENEx();
                clsDGRegionFldsBL.CopyTo(objInFor, objDGRegionFldsENEx);
                arrObjExLst.Add(objDGRegionFldsENEx);
            }

            return arrObjExLst;
        }



        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_DGRegionFlds(System.Windows.Forms.ListView lvDGRegionFlds, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviDGRegionFlds;
            List<clsDGRegionFldsEN> arrDGRegionFldsObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrDGRegionFldsObjList = clsDGRegionFldsBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvDGRegionFlds.Items.Clear();//清除原来所有Item
            lvDGRegionFlds.Columns.Clear();//清除原来所有列头信息
            lvDGRegionFlds.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("是否需要排序", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("列序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("列标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("是否转换成CheckBox", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("区域Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("是否显示", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("是否功能字段", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("Dg功能类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("控件类型号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("修改时间", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.Columns.Add("表字段ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvDGRegionFlds.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsDGRegionFldsEN objDGRegionFlds in arrDGRegionFldsObjList)
            {
                lviDGRegionFlds = new System.Windows.Forms.ListViewItem();
                lviDGRegionFlds.Tag = objDGRegionFlds.mId;
                lviDGRegionFlds.Text = objDGRegionFlds.mId.ToString();
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.IsNeedSort.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.SeqNum.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.HeaderText);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.IsTransToChkBox.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.RegionId.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.IsVisible.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.IsFuncFld.ToString());
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.DgFuncTypeId);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.CtlTypeId);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.UpdUser);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.Memo);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.UpdDate);
                lviDGRegionFlds.SubItems.Add(objDGRegionFlds.FldId.ToString());
                lvDGRegionFlds.Items.Add(lviDGRegionFlds);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrDGRegionFldsObjList.Count;
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
            //
            int intSeqNum;	//当前记录的序号
            int intPrevSeqNum, intNextSeqNum;	//上下两条记录的序号
            //			string strMid;
            long lngPrevMid = 0;	//上一条序号的关键字MId
            long lngNextMid = 0;	//下一条序号的关键字MId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrRegionId;
            List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsDGRegionFldsEN objDGRegionFlds = clsDGRegionFldsBL.GetObjBymId(lngMid);
            intSeqNum = objDGRegionFlds.SeqNum;
            intPrevSeqNum = intSeqNum - 1;
            intNextSeqNum = intSeqNum + 1;
            //3、如果当前序号是否是末端序号,
            //		3.1 如果是末端序号,就退出,
            strCurrRegionId = objDGRegionFlds.RegionId;		//获取当前记录的{表ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond(clsDGRegionFldsEN._CurrTabName, "RegionId = '" + strCurrRegionId + "'");	//获取当前{表ID}的记录数
            if (strDirect == "UP")
            {
                if (intSeqNum <= 1)
                {
                    throw new clsDbObjException("已经是第一条记录,不能再上移!");
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intSeqNum >= intTabRecNum)	//如果当前序号大于表记录数
                {
                    throw new clsDbObjException("已经是最后一条记录,不能再下移!");
                }
            }
            //		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
            //		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
            //		    如果是向上移动,就判断当前序号是否“大于”1,
            //		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。

            //4、获取下(上)一个序号字段的关键字Mid
            if (strDirect == "UP")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum - 1);
                arrID = clsDGRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new clsDbObjException("获取上一条记录的关键字出错!");

                }
                if (arrID.Count <= 0)
                {
                    throw new clsDbObjException("获取上一条记录的关键字出错!");
                }
                lngPrevMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum + 1);
                arrID = clsDGRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new clsDbObjException("获取下一条记录的关键字出错!");

                }
                if (arrID.Count <= 0)
                {
                    throw new clsDbObjException("获取下一条记录的关键字出错!");
                }
                lngNextMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect == "FIRST")
            {
            }
            else if (strDirect == "LAST")
            {
            }
            else
            {
                throw new clsDbObjException("方向参数出错!");
            }
            //5、把当前关键字Mid的序号加(减)1
            //6、把下一个序号的关键字Mid减(加)1
            if (strDirect == "UP")
            {
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intSeqNum - 1, "MId = " + lngMid);
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intPrevSeqNum + 1, "MId = " + lngPrevMid);
                clsDGRegionFldsBL.ReFreshCache(objDGRegionFlds.PrjId);
            }
            else if (strDirect == "DOWN")
            {
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intSeqNum + 1, "MId = " + lngMid);
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intNextSeqNum - 1, "MId = " + lngNextMid);
                clsDGRegionFldsBL.ReFreshCache(objDGRegionFlds.PrjId);
            }
            else if (strDirect == "FIRST")
            {
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", 0, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect == "LAST")
            {
                clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, "SeqNum", intTabRecNum + 1, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            //7、重新显示DATAGRID
            clsDGRegionFldsBL.ReFreshCache(objDGRegionFlds.PrjId);
            return true;
        }
        public new static void ReOrder(string lngRegionId)
        {
            IEnumerable<clsDGRegionFldsEN> arrDGRegionFldsObjList = clsDGRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            arrDGRegionFldsObjList = arrDGRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);
            int intIndex = 1;
            foreach (clsDGRegionFldsEN objDGRegionFlds in arrDGRegionFldsObjList)
            {
                objDGRegionFlds.SeqNum = intIndex;
                clsDGRegionFldsBL.UpdateBySql2(objDGRegionFlds);
                intIndex++;
            }
        }


        public static bool AddColumn_SourceTabName(ref System.Data.DataTable objDT)
        {
            objDT.Columns.Add("SourceTabName");
            foreach (DataRow objDR in objDT.Rows)
            {
                string strPrjId = objDR[convDGRegionFlds.PrjId].ToString();
                //string 1strFldID = objDR[convDGRegionFlds.FldId].ToString();
                string strFldName = objDR[convDGRegionFlds.FldName].ToString();
                string strTabId = objDR[convDGRegionFlds.TabId].ToString();
                if (string.IsNullOrEmpty(strTabId) == true) continue;
                try
                {


                    clsvSqlViewFldEN objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFieldAliasesExCache(strPrjId, strTabId, strFldName);
                    if (objvSqlViewFldEN == null)
                    {
                        objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFldNameExCache(strPrjId, strTabId, strFldName);

                    }
                    if (objvSqlViewFldEN != null)
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
        public static List<clsDGRegionFldsENEx> GetObjExLstByRegionIdEx1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, clsDGRegionFldsEN.con_InUse);

            List<clsDGRegionFldsENEx> arrObjENExList = new List<clsDGRegionFldsENEx>();
            List<clsDGRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId);
            foreach (clsDGRegionFldsEN objDGRegionFldsEN in arrObjList)
            {
                clsDGRegionFldsENEx objDGRegionFldsENEx = new clsDGRegionFldsENEx();
                CopyTo(objDGRegionFldsEN, objDGRegionFldsENEx);
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldId) == false)
                {
                    objDGRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDGRegionFldsEN.FldId, objDGRegionFldsENEx.PrjId());
                }
                objDGRegionFldsENEx.objCtlType = clsCtlTypeBLEx.GetObjByCtlTypeIdCache(objDGRegionFldsENEx.CtlTypeId);
                arrObjENExList.Add(objDGRegionFldsENEx);
            }
            return arrObjENExList;
        }

        public static List<clsDGRegionFldsEN> GetObjLstByTabIdCache(string strTabId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDGRegionFldsEN> arrObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            List<string> arrRegionId = arrViewRegion.Select(x => x.RegionId).ToList();
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId) == true && x.InUse == true)
                .OrderBy(x => x.SeqNum)
                .ToList();
            return arrDGRegionFldsObjLst_Sel;
        }
        public static List<clsDGRegionFldsEN> GetObjLstByPrjIdCache(string strPrjId)
        {
            //初始化列表缓存
            List<clsDGRegionFldsEN> arrObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBLEx.GetObjLstByPrjIdCache(strPrjId);
            List<string> arrRegionId = arrViewRegion.Select(x => x.RegionId).ToList();
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId) == true && x.InUse == true)
                .OrderBy(x => x.SeqNum)
                .ToList();
            return arrDGRegionFldsObjLst_Sel;
        }

        //public static bool CheckOutDataNodeIdBak(clsDGRegionFldsEN objDGRegionFldsEx, string strCmPrjId, string strOpUser)
        //{
        //    string strMsg = "";
        //  long strOutDataNodeId = objDGRegionFldsEx.OutDataNodeId;
        //    try
        //    {
        //        var objDataNode_Out = clsDataNodeBL.GetObjByDataNodeIdCache(strOutDataNodeId, strCmPrjId);

        //        if (objDataNode_Out == null)
        //        {
        //            var strDataNodeId_New = clsDataNodeBLEx.GetNewDataNodeIdByCmPrjId(strOutDataNodeId, strCmPrjId);
        //            if (string.IsNullOrEmpty(strDataNodeId_New) == true)
        //            {
        //                var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
        //                var objDataNode = clsDataNodeBL.GetObjByDataNodeId(strOutDataNodeId);
        //                if (objDataNode == null)
        //                {
        //                    strMsg = string.Format("检查Out结点时, 输出结点:[{0}]不存在。在 CmPrjId={1}({2})，请检查！(In {3})",
        //                         strOutDataNodeId, strCmPrjId, objCMProject.CmPrjName,
        //                        clsStackTrace.GetCurrClassFunction());
        //                    throw new Exception(strMsg);
        //                }

        //                 strMsg = string.Format("转换函数中，属性:[{0}], 输出结点:[{1}]({2}), 不存在。在 VersionNo=1, CmPrjId={3}，请检查！(In {4})",
        //                     objDGRegionFldsEx.DataPropertyName,
        //                    objDataNode.DataNodeName, objDataNode.DataNodeId, strCmPrjId, objCMProject.CmPrjName,
        //                    clsStackTrace.GetCurrClassFunction());
        //                throw new Exception(strMsg);
        //            }
        //            else
        //            {
        //                strOutDataNodeId = strDataNodeId_New;
        //                objDGRegionFldsEx.OutDataNodeId = strDataNodeId_New;
        //                objDGRegionFldsEx.UpdDate = clsDateTime.getTodayDateTimeStr(1);
        //                objDGRegionFldsEx.UpdUser = strOpUser;
        //                clsDGRegionFldsBL.UpdateBySql2(objDGRegionFldsEx);
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception objException)
        //    {
        //        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId());
        //        var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
        //        strMsg = string.Format("检查OutDataNodeId:[{0}]时(字段:[{1}({2})], 属性:[{3}])，出错:{4}。 CmPrjId={5}({6})，请检查！(In {7})",
        //            strOutDataNodeId, objFieldTab.FldName, objDGRegionFldsEx.FldId, objDGRegionFldsEx.DataPropertyName(),
        //            objException.Message,
        //            strCmPrjId, objCMProject.CmPrjName,
        //            clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //}

        public static bool CheckOutFldId(clsDGRegionFldsENEx objDGRegionFldsEx, bool bolIsFstLcase, string strCmPrjId, string strOpUser)
        {
            string strMsg = "";
            string strOutFldId = objDGRegionFldsEx.OutFldId;
            string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            try
            {
                var objFieldTab_Out = clsFieldTabBL.GetObjByFldIdCache(strOutFldId, strPrjId);

                if (objFieldTab_Out == null)
                {

                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);

                    strMsg = string.Format("检查Out字段时, 输出字段:[{0}]不存在。在 CmPrjId={1}({2})，请检查！(In {3})",
                         strOutFldId, strCmPrjId, objCMProject.CmPrjName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);


                }
                return true;
            }
            catch (Exception objException)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId());
                var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
                strMsg = string.Format("检查OutFldId:[{0}({1})], 属性:[{2}])，出错:{3}。 CmPrjId={4}({5})，请检查！(In {6})",
                    strOutFldId, objFieldTab.FldName, objDGRegionFldsEx.DataPropertyName(),
                    objException.Message,
                    strCmPrjId, objCMProject.CmPrjName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


        public static clsDGRegionFldsENEx GetObjEx(clsDGRegionFldsEN objDGRegionFlds)
        {
            clsDGRegionFldsENEx objDGRegionFldsENEx = new clsDGRegionFldsENEx();
            CopyTo(objDGRegionFlds, objDGRegionFldsENEx);
            return objDGRegionFldsENEx;
        }
        public static clsErrMsgENEx CheckRegionFlds(string strViewId, string strRegionId, string strCmPrjId, string strOpUserId)
        {
            string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            //1、获取当前区域ID的相关主表ID；
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            string strMsg = "";
            int intErrCount = 0;
            var arrDGRegionFlds = clsDGRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
            var arrDGRegionFldsEx = arrDGRegionFlds.Select(clsDGRegionFldsBLEx.GetObjEx).ToList();
            var objViewRegion = clsViewRegionBL.GetObjByRegionId(strRegionId);

            //StringBuilder sbErrMsg = new StringBuilder();
            //try
            //{

            foreach (var objInFor in arrDGRegionFldsEx)
            {
                if (objInFor.InUse == false) continue;
                try
                {
                    if (objInFor.CtlTypeId == enumCtlType.Button_01)
                    {
                        objInFor.ErrMsg = "";
                        objInFor.Update();
                        continue;
                    }
                    if (string.IsNullOrEmpty(objInFor.FldId) == true)
                    {
                        strMsg = $"控件:[{objInFor.HeaderText}]的字段Id(FldId)为空！({clsStackTrace.GetCurrClassFunctionByLevel(2)})";
                        throw new Exception(strMsg);
                    }
                    if (objInFor.IsTabField() == false)
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldId, objInFor.PrjId);
                        strMsg = $"控件:[{objInFor.HeaderText}]的字段:[{objFieldTab.FldName}({objInFor.FldId})]，不在查询区的相关表中，请检查！({clsStackTrace.GetCurrClassFunctionByLevel(2)})";
                        throw new Exception(strMsg);
                    }
                    switch (objInFor.CtlTypeId)
                    {
                        case enumCtlType.DropDownList_06:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.DropDownList_Bool_18:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                
                        case enumCtlType.CheckBox_02:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.Button_01:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.Icon_46:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.TextBox_16:
                        case enumCtlType.Label_10:
                            if (objInFor.DnPathId() != null)
                            {
                                var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objInFor.DnPathId(), objInFor.PrjId);
                                if (objDnPath != null)
                                {
                                    clsDnPathBLEx.CheckDnPath(objDnPath, strOpUserId);
                                    if (objDnPath.ErrMsg != null && objDnPath.ErrMsg.Length > 0)
                                    {
                                        strMsg = string.Format("控件:[{0}]中，路径出错:[{1}].({2})",
                      objInFor.HeaderText, objDnPath.ErrMsg,
                    clsStackTrace.GetCurrClassFunctionByLevel(2));
                                        throw new Exception(strMsg);
                                    }
                                }
                                var strTabName_Out4ListRegion4GC = objViewRegion.TabId;
                                var strExportFldId = objInFor.OutFldId;
                                var arrAddiFldId = clsPrjTabFldBLEx.GetEdgeAddiFldIdLst(strTabName_Out4ListRegion4GC, strExportFldId, strPrjId_p);

                                if (arrAddiFldId.Count > 0)
                                {
                                    foreach (string strEdgeAddiFldId in arrAddiFldId)
                                    {
                                        var bolIsExist = clsViewIdGCVariableRelaBLEx.IsExistViewVarNameByFldId(strViewId, strEdgeAddiFldId, strPrjId_p);
                                        if (bolIsExist == false)
                                        {
                                            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldId, objInFor.PrjId);
                                            var objFieldTab_Addi = clsFieldTabBL.GetObjByFldIdCache(strEdgeAddiFldId, strPrjId_p);
                                            strMsg = $"控件:[{objInFor.HeaderText}](字段:[{objFieldTab.FldName}]),映射过程缺乏相应的字段:[{objFieldTab_Addi.FldName}({strEdgeAddiFldId})]映射附加变量，请在界面变量中添加！";
                                            throw new Exception(strMsg);
                                        }
                                    }
                                }
                            }
                            //clsPubFun4BLEx.CheckDnPath_In(objInFor);
                            break;
                        default:
                            var objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objInFor.CtlTypeId);
                            strMsg = string.Format("控件类型:[{0}]({1})没有被处理！(in {2})",
                                      objCtlType.CtlTypeName, objCtlType.CtlTypeId,
                                      clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
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
            var objErrMsg = new clsErrMsgENEx(conErrType.ListRegion, intErrCount);
            
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

        public static bool CheckRegionFldsUp(string strViewId, string strRegionId, string strCmPrjId, string strOpUserId)
        {
            var strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var objErrMsg_New = CheckRegionFlds(strViewId, strRegionId, strCmPrjId, strOpUserId);
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

        public static clsDGRegionFldsENEx GetObjExBymIdCache(long lngMid, string strPrjId)
        {
            //初始化列表缓存
            clsDGRegionFldsEN objDGRegionFlds = clsDGRegionFldsBL.GetObjBymIdCache(lngMid, strPrjId);
            var objDGRegionFldsEx = CopyToEx(objDGRegionFlds);
            return objDGRegionFldsEx;
        }

        public static bool IsFuncFld(string strFldId, string strTabId, string strPrjId)
        {
            //初始化列表缓存
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            List<clsDGRegionFldsEN> arrObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);
            List<string> arrRegionId = arrViewRegion.Where(x=>x.TabId == strTabId).Select(x => x.RegionId).ToList();
            //List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId) == true && x.InUse == true)
            //    .OrderBy(x => x.SeqNum)
            //    .ToList();

            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId) == true && x.InUse == true && x.FldId == strFldId)
                .ToList();
            if (arrDGRegionFldsObjLst_Sel.Count == 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(arrDGRegionFldsObjLst_Sel[0].OutFldId) == false) return true;
            return arrDGRegionFldsObjLst_Sel[0].IsFuncFld;
        }
    }
}