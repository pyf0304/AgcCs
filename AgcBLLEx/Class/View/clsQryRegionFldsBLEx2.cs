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
using AGC.PureClass;
using AGC.PureClassEx;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    public partial class clsQryRegionFldsBLEx
    {
        public List<clsPrjTabFldENEx> arrFieldTabExObjLst = null;           //界面相关详细表字段集合
        public static void initQryRegionFldSet(clsViewInfoENEx objViewInfoENEx, bool bolIsFstLcase)
        {
           
            objViewInfoENEx.TabKeyFldNum = 0;
            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(objViewInfoENEx.ViewId,
                clsRegionTypeENEx.QUERYREGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //objViewInfoENEx.objQueryRegionENEx = new clsQueryRegionENEx(lngRegionId);
            //clsQueryRegionBLEx.GetQueryRegionEx(ref objViewInfoENEx.objQueryRegionENEx, objViewInfoENEx.PrjId);

            //objViewInfoENEx.objQueryRegionENEx.InitViewRegion();
            objViewInfoENEx.arrQryRegionFldSet = clsQryRegionFldsBLEx.GetObjExLstByRegionIdCache4InUse2(lngRegionId, bolIsFstLcase, objViewInfoENEx.PrjId, objViewInfoENEx.ViewId);
            //if (objViewInfoENEx.arrQryRegionFldSet  ==  null || objViewInfoENEx.arrQryRegionFldSet.Count  ==  0)
            //{
            //    intViewFldNum = 0;
            //    return;
            //}
            //objViewInfoENEx.objQueryRegionENEx.FieldNum = objViewInfoENEx.arrQryRegionFldSet.Count;
            objViewInfoENEx.ViewFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                //objQryRegionFldsEx.arrFieldTabExObjLstBak = objViewInfoENEx.arrFieldTabExObjLstBak;
                if (string.IsNullOrEmpty(objQryRegionFldsEx.FldId) == true) continue;
                if (objQryRegionFldsEx.ObjPrjTabFld() == null)
                {
                    objQryRegionFldsEx.IsForExtendClass = false;
                }
                else
                {
                    objQryRegionFldsEx.IsForExtendClass = objQryRegionFldsEx.ObjPrjTabFld().IsForExtendClass;
                }
                objQryRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objQryRegionFldsEx.FldId, objViewInfoENEx.PrjId);

                objQryRegionFldsEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objQryRegionFldsEx.CtlTypeId);
                if (string.IsNullOrEmpty( objQryRegionFldsEx.DsTabId ) == false)
                {
                    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objQryRegionFldsEx.DsTabId, objViewInfoENEx.PrjId);
                    if (objPrjTabEN != null) objQryRegionFldsEx.DS_TabName = objPrjTabEN.TabName;
                }
            }
        }

        //public clsPrjTabFldENEx objPrjTabFldENEx = null;
        //public clsCtlTypeEN objCtlType = null;
        //private string mstrCtlName;


        //public string FldName_Java
        //{
        //    get
        //    {
        //        return CommProgramSet.clsComm.FstLcaseS(objViewInfoENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName.ToLower());
        //    }
        //}
        //public string CtrlId
        //{
        //    get
        //    {
        //        mstrCtlName = objViewInfoENEx.objCtlType.CtlTypeAbbr + objViewInfoENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
        //        return mstrCtlName;
        //    }
        //    set
        //    {
        //        mstrCtlName = value;
        //    }
        //}
        //public string CtlName4Win
        //{
        //    get
        //    {
        //        mstrCtlName = objViewInfoENEx.objCtlType.CtlTypeAbbr + objViewInfoENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

        //        return mstrCtlName.Replace("ddl", "cbo");
        //    }
        //    set
        //    {
        //        mstrCtlName = value;
        //    }
        //}
        /// <summary>
        /// 转换代码表
        /// </summary>
        public static string CodeTab4Get(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(objQryRegionFldsEx.DsTabId);
            if (objPrjTabEN  ==  null || string.IsNullOrEmpty(objQryRegionFldsEx.DsTabId))
            {

                var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表。",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
                    objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", 当前类为:{0}", objQryRegionFldsEx.GetType().ToString());
                string strOUTTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", 当前输出表:{0}", strOUTTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            return objPrjTabEN.TabName;

        }
        //public string CodeTabNameBak
        //{
        //    get
        //    {
        //        return 1new clsFieldTabENEx(objViewInfoENEx.Ds_DataTextFieldId, true).FldName;
        //    }
        //}
        /// <summary>
        /// 转换代码表
        /// </summary>
        public static string DsTabName4Get(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(objQryRegionFldsEx.DsTabId);
            if (objPrjTabEN  ==  null || string.IsNullOrEmpty(objQryRegionFldsEx.DsTabId))
            {
                var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表。",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
                    objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", 当前类为:{0}", objQryRegionFldsEx.GetType().ToString());
                string strOUTTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", 当前输出表:{0}", strOUTTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            return objPrjTabEN.TabName;

        }
        public static clsPrjTabEN Ds_PrjTab4Get(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objQryRegionFldsEx.DsTabId, objQryRegionFldsEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objQryRegionFldsEx.DsTabId))
            {
                var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表。",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
                    objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", 当前类为:{0}", objQryRegionFldsEx.GetType().ToString());
                string strOUTTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", 当前输出表:{0}", strOUTTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            return objPrjTabEN;

        }
        public static string InitDS_TabName4Get(clsQryRegionFldsENEx objQryRegionFldsEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objQryRegionFldsEx.DsTabId, objQryRegionFldsEx.PrjId());
            if (objPrjTabEN == null || string.IsNullOrEmpty(objQryRegionFldsEx.DsTabId))
            {
                var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表。",
                    objvViewRegion.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
                    objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", 当前类为:{0}", objQryRegionFldsEx.GetType().ToString());
                string strOUTTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", 当前界面名称:{0}", strOUTTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            //objQryRegionFldsEx.DS_TabName = objPrjTabEN.TabName;
            return objPrjTabEN.TabName;

        }

        /// <summary>
        /// 转换代码表--文本字段
        /// </summary>
        public static  string Ds_DataTextField4GetBak20230309(clsQryRegionFldsENEx objQryRegionFldsEx)
        {
            //clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objQryRegionFldsEx.Ds_DataTextFieldId, objQryRegionFldsEx.PrjId());
            //if (objFieldTabEN  ==  null || string.IsNullOrEmpty(objQryRegionFldsEx.Ds_DataTextFieldId))
            //{
            //    var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
            //    clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
            //    StringBuilder sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表--文本字段。",
            //        objvViewRegion.TabName, objvPrjTabFld.FldName);
            //    sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
            //        objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
            //    sbMessage.AppendFormat(", 当前类为:{0}", objQryRegionFldsEx.GetType().ToString());
            //    string strOUTTabName = objvViewRegion.TabName;
            //    sbMessage.AppendFormat(", 当前界面名称:{0}", strOUTTabName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            //return objFieldTabEN.FldName;
            return "";
        }
        /// <summary>
        /// 转换代码表--值字段
        /// </summary>
        public static  string Ds_DataValueField4GetBak20230309(clsQryRegionFldsENEx objQryRegionFldsEx)
        {
            return "";
            //clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objQryRegionFldsEx.DsDataValueFieldId, objQryRegionFldsEx.PrjId());
            //if (objFieldTabEN  ==  null || string.IsNullOrEmpty(objQryRegionFldsEx.DsDataValueFieldId))
            //{
            //    var objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objQryRegionFldsEx.FldId);
            //    clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objQryRegionFldsEx.RegionId);
            //    StringBuilder sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表--值字段。",
            //        objvViewRegion.TabName, objvPrjTabFld.FldName);
            //    sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
            //        objQryRegionFldsEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
            //    sbMessage.AppendFormat(", 当前类为:{0}", objQryRegionFldsEx.GetType().ToString());
            //    string strOUTTabName = objvViewRegion.TabName;
            //    sbMessage.AppendFormat(", 当前界面名称:{0}", strOUTTabName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            //return objFieldTabEN.FldName;

        }

       
        public static ArrayList GetObjLstEx(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from QryRegionFlds where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count  ==  0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQryRegionFldsENEx objQryRegionFldsEN = new clsQryRegionFldsENEx();
                objQryRegionFldsEN.mId = Int32.Parse(objRow["mId"].ToString().Trim());
                objQryRegionFldsEN.RegionId = objRow["RegionId"].ToString().Trim();
                objQryRegionFldsEN.FldId = objRow["FldId"].ToString().Trim();
                objQryRegionFldsEN.CtlTypeId = objRow["CtlTypeId"].ToString().Trim();
                objQryRegionFldsEN.DsTabId = objRow["DsTabId"].ToString().Trim();
                objQryRegionFldsEN.QueryOptionId = objRow["QueryOptionId"].ToString().Trim();
                objQryRegionFldsEN.DdlItemsOptionId = objRow["DdlItemsOptionId"].ToString().Trim();
                objQryRegionFldsEN.DsSqlStr = objRow["DsSqlStr"].ToString().Trim();
                //objQryRegionFldsEN.Ds_DataTextFieldId = objRow["Ds_DataTextFieldId"].ToString().Trim();
                //objQryRegionFldsEN.DsDataValueFieldId = objRow["DsDataValueFieldId"].ToString().Trim();
                objQryRegionFldsEN.ItemsString = objRow["ItemsString"].ToString().Trim();
                objQryRegionFldsEN.DsCondStr = objRow["DsCondStr"].ToString().Trim();
                objQryRegionFldsEN.SeqNum = clsGeneralTab2.TransNullToInt_S(objRow["SeqNum"].ToString().Trim());
                objQryRegionFldsEN.UpdDate = objRow["UpdDate"].ToString().Trim();
                objQryRegionFldsEN.UpdUser = objRow["UpdUser"].ToString().Trim();
                objQryRegionFldsEN.Memo = objRow["Memo"].ToString().Trim();
                arrObjList.Add(objQryRegionFldsEN);
            }
            objDT = null;
            return arrObjList;
        }




        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_QryRegionFlds(System.Windows.Forms.ListView lvQryRegionFlds, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviQryRegionFlds;
            List<clsQryRegionFldsEN> arrQryRegionFldsObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrQryRegionFldsObjList = clsQryRegionFldsBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvQryRegionFlds.Items.Clear();//清除原来所有Item
            lvQryRegionFlds.Columns.Clear();//清除原来所有列头信息
            lvQryRegionFlds.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("区域Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("表字段ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("控件类型号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("数据源表ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("查询方式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("下拉框列表选项ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("数据源SQL串", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("数据源文本字段Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("数据源值字段Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("列表项串", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("数据源条件串", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("字段序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("修改时间", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQryRegionFlds.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQryRegionFldsEN objQryRegionFldsEN in arrQryRegionFldsObjList)
            {
                lviQryRegionFlds = new System.Windows.Forms.ListViewItem();
                lviQryRegionFlds.Tag = objQryRegionFldsEN.mId;
                lviQryRegionFlds.Text = objQryRegionFldsEN.RegionId.ToString();
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.FldId.ToString());
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.CtlTypeId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DsTabId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.QueryOptionId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DdlItemsOptionId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DsSqlStr);
                //lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.Ds_DataTextFieldId);
                //lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DsDataValueFieldId);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.ItemsString);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.DsCondStr);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.SeqNum.ToString());
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.UpdDate);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.UpdUser);
                lviQryRegionFlds.SubItems.Add(objQryRegionFldsEN.Memo);
                lvQryRegionFlds.Items.Add(lviQryRegionFlds);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrQryRegionFldsObjList.Count;
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

            var objQryRegionFldsEN = clsQryRegionFldsBLEx.GetObjBymId(lngMid);
            //var objQryRegionFldsENEx = CopyToEx(objQryRegionFldsEN);
            intSeqNum = objQryRegionFldsEN.SeqNum??0;
            intPrevSeqNum = intSeqNum - 1;
            intNextSeqNum = intSeqNum + 1;
            //3、如果当前序号是否是末端序号,
            //		3.1 如果是末端序号,就退出,
            strCurrRegionId = objQryRegionFldsEN.RegionId;		//获取当前记录的{表ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond(clsQryRegionFldsEN._CurrTabName, "RegionId = '" + strCurrRegionId + "'");	//获取当前{表ID}的记录数
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
                    strCurrRegionId, intSeqNum - 1);
                arrID = clsQryRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
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
                arrID = clsQryRegionFldsBL.GetPrimaryKeyID_S(strCondition.ToString());
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
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intSeqNum - 1, "MId = " + lngMid);
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intPrevSeqNum + 1, "MId = " + lngPrevMid);
            }
            else if (strDirect  ==  "DOWN")
            {
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intSeqNum + 1, "MId = " + lngMid);
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intNextSeqNum - 1, "MId = " + lngNextMid);
            }
            else if (strDirect  ==  "FIRST")
            {
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", 0, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            else if (strDirect  ==  "LAST")
            {
                clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, "SeqNum", intTabRecNum + 1, "MId = " + lngMid);
                ReOrder(strCurrRegionId);
            }
            //7、重新显示DATAGRID
            clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);
            return true;
        }
        public new static void ReOrder(string lngRegionId)
        {
            IEnumerable<clsQryRegionFldsEN> arrQryRegionFldsObjList = clsQryRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");

            arrQryRegionFldsObjList = arrQryRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);

            int intIndex = 1;
            foreach (clsQryRegionFldsEN objQryRegionFldsEN in arrQryRegionFldsObjList)
            {
                objQryRegionFldsEN.SeqNum = intIndex;
                clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                intIndex++;
            }
        }

        public static bool AddColumn_SourceTabName(ref System.Data.DataTable objDT)
        {
            objDT.Columns.Add("SourceTabName");
            foreach (DataRow objDR in objDT.Rows)
            {
                string strPrjId = objDR[convQryRegionFlds.PrjId].ToString();
                //string 1strFldID = objDR[convQryRegionFlds.FldId].ToString();
                string strFldName = objDR[convQryRegionFlds.FldName].ToString();
                string strTabId = objDR[convQryRegionFlds.TabId].ToString();
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

        public static List<ASPControlGroupEx> GetControlGroup(string lngRegionId, clsViewInfoENEx objViewInfoENEx, string strItemName4MultiModel)
        {
                       
            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst = objViewInfoENEx.arrQryRegionFldSet.Select(obj=> clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, strItemName4MultiModel));
            //把查询按钮加进来
            //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
            //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
            //arrButtonObjLst.Add(objASPControlGroup);

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst0 = objViewInfoENEx.arrFeatureRegionFlds.GroupBy(x => x.FeatureId)
                .Select(g => g.First()); 
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("界面功能区为空，请添加界面功能！界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            IEnumerable<ASPControlGroupEx> arrButtonGroupLst = null;
            bool bolIsHasExport = true;
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) bolIsHasExport = false;
            arrButtonGroupLst = arrFeatureRegionFldsObjLst0
                .Where(x => x.ViewImplId == enumViewImplementation.QueryRegion_0003)
                .Select(x => clsFeatureRegionFldsBLEx.GetButtonGroup(x, objViewInfoENEx.ApplicationTypeId, bolIsHasExport));

            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);
            // 去重
            //arrButtonGroupLst = arrButtonGroupLst
            //    .GroupBy(x => x.FeatureId)
            //    .Select(g => g.First());
            arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonGroupLst);
            return arrASPControlGroupObjLst.ToList();

        }

        //public static IEnumerable<VueControlGroupEx> GetControlGroup_Vue(string lngRegionId, clsViewInfoENEx objViewInfoENEx, string strItemName4MultiModel, bool bolIs4PureHtml = false)
        //{

        //    IEnumerable<VueControlGroupEx> arrASPControlGroupObjLst = objViewInfoENEx.arrQryRegionFldSet.Select(obj => clsVueControlGroupBLEx.GetControlGroup_Asp(obj, strItemName4MultiModel, bolIs4PureHtml));
        //    //把查询按钮加进来
        //    //VueControlGroupEx objASPControlGroup = clsVueControlGroupBLEx.GetbtnQuery();
        //    //List<VueControlGroupEx> arrButtonObjLst = new List<VueControlGroupEx>();
        //    //arrButtonObjLst.Add(objASPControlGroup);

        //    IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
        //    if (objViewInfoENEx.arrFeatureRegionFlds == null)
        //    {
        //        string strMsg = string.Format("界面功能区为空，请添加界面功能！界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    IEnumerable<VueControlGroupEx> arrButtonGroupLst = null;
        //    arrButtonGroupLst = objViewInfoENEx.arrFeatureRegionFlds
        //            .Where(x => x.RegionId == lngRegionId)
        //            .Select(clsFeatureRegionFldsBLEx.GetButtonGroup4Vue);
            
        //    //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);

        //    arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonGroupLst);
        //    return arrASPControlGroupObjLst;

        //}

        public static IEnumerable<ASPControlGroupEx> GetControlGroupV2(string lngRegionId,    string strCmPrjId, string strPrjId,
            string strItemName4MultiModel, bool bolIs4PureHtml = false)
        {
            clsvViewRegionEN objViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(lngRegionId, strCmPrjId);

            //Func<clsQryRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4MultiModel = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, strItemName4MultiModel);
            List<clsQryRegionFldsENEx> arrQryRegionFlds = clsQryRegionFldsBLEx.GetObjExLstByRegionIdCacheEx(lngRegionId, strCmPrjId);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst = arrQryRegionFlds.Select(x=> clsASPControlGroupBLEx.GetControlGroup_Asp(x, strCmPrjId,  strItemName4MultiModel));
            //把查询按钮加进来
            //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
            //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
            //arrButtonObjLst.Add(objASPControlGroup);

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = clsFeatureRegionFldsBLEx.GetObjExLstByRegionIdEx(lngRegionId, strPrjId);//  objViewInfoENEx.arrFeatureRegionFlds;
            if (arrFeatureRegionFldsObjLst == null)
            {
                
                string strMsg = string.Format("界面功能区为空，请添加界面功能！当前输出表:{0}. (In {1})", objViewRegion.TabName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            bool bolIsHasExport = true;
            //if (objViewInfoENEx.objViewRegion_ExportExcel == null) bolIsHasExport = false;
            Func<clsFeatureRegionFldsENEx, ASPControlGroupEx> GetButtonGroupV2 = obj => clsFeatureRegionFldsBLEx.GetButtonGroup(obj, objViewRegion.ApplicationTypeId ?? 0, bolIsHasExport);

            IEnumerable<ASPControlGroupEx> arrButtonGroupLst = arrFeatureRegionFldsObjLst
                    .Where(x => x.RegionId == lngRegionId)
                    .Select(GetButtonGroupV2);

            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);

            arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonGroupLst);
            return arrASPControlGroupObjLst;

        }
        /// <summary>
        /// 功能:设置字段可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "intColSpan">跨列数</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置可用的记录数</returns>
        public static int SetColSpan(List<long> arrmIdLst, int intColSpan, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(strMid);
                    objQryRegionFldsEN.ColSpan = intColSpan;
                    objQryRegionFldsEN.UpdUser = strUpdUser;
                    objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段跨列数出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static int SetWidth(List<long> arrmIdLst, int intWidth, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(strMid);
                    objQryRegionFldsEN.Width = intWidth;
                    objQryRegionFldsEN.UpdUser = strUpdUser;
                    objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段跨列数出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsQryRegionFldsENEx GetObjExBymIdCache(long lngMid, string strCmPrjId)
        {
            //初始化列表缓存
            clsQryRegionFldsEN objQryRegionFlds = clsQryRegionFldsBL.GetObjBymIdCache(lngMid, strCmPrjId);
            var objEx = CopyToEx(objQryRegionFlds);
            return objEx;
        }
    }
}