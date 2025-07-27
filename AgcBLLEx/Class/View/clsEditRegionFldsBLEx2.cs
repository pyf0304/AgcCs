using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.commexception;

using System.Collections.Generic;
using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.common;
using System.Linq;

namespace AGC.BusinessLogicEx
{
    
    public partial class clsEditRegionFldsBLEx
    {
        public List<clsPrjTabFldENEx> arrFieldTabExObjLst = null;			//界面相关详细表字段集合

        public clsPrjTabFldENEx objPrjTabFldENEx = null;
        public clsCtlTypeEN objCtlType = null;
        private string mstrCtlName;


        public string FldName_Java
        {
            get
            {
                return objPrjTabFldENEx.ObjFieldTabENEx.FldName.ToLower();
            }
        }
        public string CtrlId
        {
            get
            {
                mstrCtlName = objCtlType.CtlTypeAbbr + objPrjTabFldENEx.ObjFieldTabENEx.FldName;
                return mstrCtlName;
            }
            set
            {
                mstrCtlName = value;
            }
        }
        /// <summary>
        /// 针对WINDOWS应用的控件名
        /// </summary>
        public string CtlName4Win
        {
            get
            {
                mstrCtlName = objCtlType.CtlTypeAbbr + objPrjTabFldENEx.ObjFieldTabENEx.FldName;

                return mstrCtlName.Replace("ddl", "cbo");
            }
            set
            {
                mstrCtlName = value;
            }
        }
        //public string CodeTabNameBAK
        //{
        //    get
        //    {
        //        return 1new clsFieldTabENEx(objViewInfoENEx.Ds_DataTextFieldId, true).FldName;
        //    }
        //}

        /// <summary>
        /// 转换代码表
        /// </summary>
        public static string InitDsTabName4Get(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsENEx.DsTabId, objEditRegionFldsENEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.DsTabId))
            {
                clsvFieldTabEN objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表。",
                    objPrjTabEN.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
                    objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", 当前类为:{0}", objEditRegionFldsENEx.GetType().ToString());
                string strINTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", 当前相关输入表:{0}", strINTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            //objEditRegionFldsENEx.DS_TabName = objPrjTabEN.TabName;
            return objPrjTabEN.TabName;

        }

        public static clsPrjTabEN InitDs_PrjTab4Get(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsENEx.DsTabId, objEditRegionFldsENEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.DsTabId))
            {
                clsvFieldTabEN objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);

                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表。",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
                    objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", 当前类为:{0}", objEditRegionFldsENEx.GetType().ToString());
                string strINTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", 当前输入表:{0}", strINTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            //objEditRegionFldsENEx.DS_TabName = objPrjTabEN.TabName;
            return objPrjTabEN;

        }

     

        public static List<clsEditRegionFldsENEx> GetObjLstEx(string strCondition)
        {
            List<clsEditRegionFldsENEx> arrObjList = new List<clsEditRegionFldsENEx>();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from EditRegionFlds where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsEditRegionFldsENEx objEditRegionFldsEN = new clsEditRegionFldsENEx();
                objEditRegionFldsEN.mId = Int32.Parse(objRow["mId"].ToString().Trim());
                objEditRegionFldsEN.RegionId = objRow["RegionId"].ToString().Trim();
                objEditRegionFldsEN.FldId = objRow["FldId"].ToString().Trim();
                objEditRegionFldsEN.CtlTypeId = objRow["CtlTypeId"].ToString().Trim();
                objEditRegionFldsEN.DdlItemsOptionId = objRow["DdlItemsOptionId"].ToString().Trim();
                objEditRegionFldsEN.DsTabId = objRow["DsTabId"].ToString().Trim();
                //objEditRegionFldsEN.DsDataValueFieldId = objRow["DsDataValueFieldId"].ToString().Trim();
                //objEditRegionFldsEN.Ds_DataTextFieldId = objRow["Ds_DataTextFieldId"].ToString().Trim();
                objEditRegionFldsEN.DsCondStr = objRow["DsCondStr"].ToString().Trim();
                objEditRegionFldsEN.DsSqlStr = objRow["DsSqlStr"].ToString().Trim();
                objEditRegionFldsEN.ItemsString = objRow["ItemsString"].ToString().Trim();
                objEditRegionFldsEN.SeqNum = clsGeneralTab2.TransNullToInt_S(objRow["SeqNum"].ToString().Trim());
                objEditRegionFldsEN.UpdUser = objRow["UpdUser"].ToString().Trim();
                objEditRegionFldsEN.Memo = objRow["Memo"].ToString().Trim();
                objEditRegionFldsEN.UpdDate = objRow["UpdDate"].ToString().Trim();
                objEditRegionFldsEN.InOutTypeId = objRow["InOutTypeId"].ToString().Trim();
                arrObjList.Add(objEditRegionFldsEN);
            }
            objDT = null;
            return arrObjList;
        }




        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_EditRegionFlds(System.Windows.Forms.ListView lvEditRegionFlds, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviEditRegionFlds;
            List<clsEditRegionFldsEN> arrEditRegionFldsObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrEditRegionFldsObjList = clsEditRegionFldsBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvEditRegionFlds.Items.Clear();//清除原来所有Item
            lvEditRegionFlds.Columns.Clear();//清除原来所有列头信息
            lvEditRegionFlds.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("区域Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("字段ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("控件类型号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("下拉框列表选项ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("数据源表ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("数据源值字段Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("数据源文本字段Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("数据源条件串", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("数据源SQL串", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("列表项串", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("字段序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvEditRegionFlds.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrEditRegionFldsObjList)
            {
                lviEditRegionFlds = new System.Windows.Forms.ListViewItem();
                lviEditRegionFlds.Tag = objEditRegionFldsEN.mId;
                lviEditRegionFlds.Text = objEditRegionFldsEN.mId.ToString();
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.RegionId.ToString());
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.FldId.ToString());
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.CtlTypeId);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DdlItemsOptionId);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DsTabId);
                //lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DsDataValueFieldId);
                //lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.Ds_DataTextFieldId);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DsCondStr);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.DsSqlStr);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.ItemsString);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.SeqNum.ToString());
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.UpdUser);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.Memo);
                lviEditRegionFlds.SubItems.Add(objEditRegionFldsEN.UpdDate);
                lvEditRegionFlds.Items.Add(lviEditRegionFlds);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrEditRegionFldsObjList.Count;
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

            clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(lngMid);
            intSeqNum = objEditRegionFldsEN.SeqNum ?? 0;
            intPrevSeqNum = intSeqNum - 1;
            intNextSeqNum = intSeqNum + 1;
            //3、如果当前序号是否是末端序号,
            //		3.1 如果是末端序号,就退出,
            strCurrRegionId = objEditRegionFldsEN.RegionId;		//获取当前记录的{表ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond(clsEditRegionFldsEN._CurrTabName, "RegionId = '" + strCurrRegionId + "'");	//获取当前{表ID}的记录数
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
            ///		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
            ///		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
            ///		    如果是向上移动,就判断当前序号是否“大于”1,
            ///		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。

            //4、获取下(上)一个序号字段的关键字Mid
            if (strDirect == "UP")
            {
                strCondition.AppendFormat("RegionId = '{0}' and SeqNum = {1}",
                    strCurrRegionId, intSeqNum - 1);
                arrID = clsEditRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
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
                arrID = clsEditRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
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
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", intSeqNum - 1, "MId = " + lngMid);
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", intPrevSeqNum + 1, "MId = " + lngPrevMid);
                clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);
            }
            else if (strDirect == "DOWN")
            {
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", intSeqNum + 1, "MId = " + lngMid);
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", intNextSeqNum - 1, "MId = " + lngNextMid);
                clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);
            }
            else if (strDirect == "FIRST")
            {
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", 0, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect == "LAST")
            {
                clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, "SeqNum", 1000, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            //7、重新显示DATAGRID
            return true;
        }
        public new static void ReOrder(string lngRegionId)
        {
            IEnumerable<clsEditRegionFldsEN> arrEditRegionFldsObjList = clsEditRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            arrEditRegionFldsObjList = arrEditRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);
            int intIndex = 1;
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrEditRegionFldsObjList)
            {
                objEditRegionFldsEN.SeqNum = intIndex;
                clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN);
                intIndex++;
            }
        }

        /// <summary>
        /// 转换代码表--文本字段
        /// </summary>
        public static string InitDs_DataTextFieldBak20230309(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            //clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objEditRegionFldsENEx.Ds_DataTextFieldId, objEditRegionFldsENEx.PrjId());
            //if (objFieldTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.Ds_DataTextFieldId))
            //{
            //    var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);
            //    clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
            //    StringBuilder sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表--文本字段。",
            //        objvViewRegion.TabName, objvPrjTabFld.FldName);
            //    sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
            //        objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
            //    sbMessage.AppendFormat(", 当前类为:{0}", objEditRegionFldsENEx.GetType().ToString());
            //    string strINTabName = objvViewRegion.TabName;
            //    sbMessage.AppendFormat(", 当前输入表:{0}", strINTabName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            ////objEditRegionFldsENEx.DS_DataTextField = objFieldTabEN.FldName;
            //return objFieldTabEN.FldName;
            return "";
        }
        /// <summary>
        /// 转换代码表--值字段
        /// </summary>
        public static string InitDs_DataValueFieldBak20230309(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            //clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objEditRegionFldsENEx.DsDataValueFieldId, objEditRegionFldsENEx.PrjId());
            //if (objFieldTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.DsDataValueFieldId))
            //{
            //    clsvFieldTabEN objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);
            //    clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
            //    StringBuilder sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表--值字段。",
            //        objvViewRegion.TabName, objvPrjTabFld.FldName);
            //    sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
            //        objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
            //    sbMessage.AppendFormat(", 当前类为:{0}", objEditRegionFldsENEx.GetType().ToString());
            //    string strINTabName = objvViewRegion.TabName;
            //    sbMessage.AppendFormat(", 当前输入表:{0}", strINTabName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            //return objFieldTabEN.FldName;
            return "";
        }

        /// <summary>
        /// 转换代码表
        /// </summary>
        public static void InitCodeTab(clsEditRegionFldsENEx objEditRegionFldsENEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsENEx.DsTabId, objEditRegionFldsENEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objEditRegionFldsENEx.DsTabId))
            {
                clsvFieldTabEN objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objEditRegionFldsENEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objEditRegionFldsENEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表。",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
                    objEditRegionFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", 当前类为:{0}", objEditRegionFldsENEx.GetType().ToString());
                string strINTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", 当前输入表:{0}", strINTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            objEditRegionFldsENEx.CodeTab = objPrjTabEN.TabName;

        }

        public static bool CheckRegionFldsUp(string strRegionId, string strViewId, string strCmPrjId, string strOpUserId)
        {
            var strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var objErrMsg_New = CheckRegionFlds(strRegionId, strCmPrjId, strOpUserId, strViewId);
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
    }
}