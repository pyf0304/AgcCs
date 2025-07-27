
using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.commexception;

using System.Collections.Generic;
using AGC.Entity;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public partial class clsViewGroupBLEx
    {

        public static bool InitViewGroupENEx1(clsViewGroupENEx objViewGroupENEx, bool bolIsFstLcase)
        {
            clsViewGroupEN objViewGroupEN = new clsViewGroupEN(objViewGroupENEx.ViewGroupId);
            
            //以输出表作为主表

            clsViewGroupBL.CopyTo(objViewGroupEN, objViewGroupENEx);

            //检查界面组有没有相应的添加、修改、详细信息、列表界面,如果没有,就不能生成相应的Manager
            string strViewId;
            //初始化添加界面
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0013' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewAdd =        new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewAdd, bolIsFstLcase, objViewGroupENEx.PrjId);
            //初始化修改界面
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0016' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewUpdate = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewUpdate, bolIsFstLcase, objViewGroupENEx.PrjId);
            //初始化查询界面
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0015' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewQuery = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewQuery, bolIsFstLcase, objViewGroupENEx.PrjId);
            //初始化详细信息界面
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0017' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewDetail = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewDetail, bolIsFstLcase, objViewGroupENEx.PrjId);
            //初始化列表界面
            strViewId = clsViewInfoBL.GetFirstID_S("PrjId = '" + objViewGroupENEx.PrjId + "' and ViewTypeCode = '0014' and ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            objViewGroupENEx.objViewList = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewGroupENEx.objViewList, bolIsFstLcase, objViewGroupENEx.PrjId);
            objViewGroupENEx.arrDetailFldSet = new ArrayList();
            initDGRegionFldSet(objViewGroupENEx);
            initEditRegionFldSet(objViewGroupENEx);
            initEditRegionFldSet_Update(objViewGroupENEx);
            initQryRegionFldSet(objViewGroupENEx);
            initViewRelaTabFldSet(objViewGroupENEx);
            //objViewGroupENEx.arrvViewGroupFldSet = clsvViewGroupFldsBL.GetObjLst(" ViewGroupId = '" + objViewGroupENEx.ViewGroupId + "'");
            //string strCondition = string.Format("PrjId = '{0}'", objViewGroupENEx.PrjId);
            //objViewGroupENEx.arrFieldTabExObjLstBak = clsFieldTabBLEx.GetObjLstEx(strCondition);
            return true;
        }

        //public string FolderName
        //{
        //    get
        //    {
        //        return mstrFolderName; // '文件目录名
        //    }
        //    set
        //    {
        //        mstrFolderName = value;
        //    }
        //}
        //public string FileName
        //{
        //    get
        //    {
        //        return mstrFileName;
        //    }
        //    set
        //    {
        //        mstrFileName = value;
        //    }
        //}


        public static void initQryRegionFldSet(clsViewGroupENEx objViewGroupENEx)
        {
            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(objViewGroupENEx.objViewQuery.ViewId,
                clsRegionTypeENEx.QUERYREGION , objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //objViewGroupENEx. objQueryRegion = (clsQueryRegionENEx) clsQueryRegionBLEx.GetObjByRegionIdCacheEx(lngRegionId, objViewGroupENEx.PrjId);
            //clsQueryRegionBLEx.InitViewRegion(objViewGroupENEx.objQueryRegion);
            objViewGroupENEx.arrQryRegionFldSet_Query = clsQryRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewGroupENEx.arrQryRegionFldSet_Query)
            {
                //objQryRegionFldsEx.arrFieldTabExObjLstBak = objViewGroupENEx.arrFieldTabExObjLstBak;
                
                objQryRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objQryRegionFldsEx.FldId, objViewGroupENEx.PrjId);
                
                objQryRegionFldsEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objQryRegionFldsEx.CtlTypeId);
            }
        }

        public static void initEditRegionFldSet(clsViewGroupENEx objViewGroupENEx)
        {
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //  然后存到集合中
            //3、            
            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(objViewGroupENEx.objViewAdd.ViewId ,
                clsRegionTypeENEx.EDITREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //初始化添加界面编辑区域字段列表
            objViewGroupENEx.arrEditRegionFldSet_Add = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Add)
            {
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }
            //初始化<修改>界面编辑区域字段列表
            lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2( objViewGroupENEx.objViewUpdate.ViewId ,
                clsRegionTypeENEx.EDITREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrEditRegionFldSet_Update = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Update)
            {
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }

            //初始化<详细信息>界面编辑区域字段列表
            lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2( objViewGroupENEx.objViewDetail.ViewId ,
                clsRegionTypeENEx.DETAILREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrEditRegionFldSet_Detail = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Detail)
            {
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }
        }

        public static void initEditRegionFldSet_Update(clsViewGroupENEx objViewGroupENEx)
        {
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //  然后存到集合中
            //3、
            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(objViewGroupENEx.objViewUpdate.ViewId ,
                clsRegionTypeENEx.EDITREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //初始化添加界面编辑区域字段列表
            objViewGroupENEx.arrEditRegionFldSet_Add = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Add)
            {
               
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }
            //初始化<修改>界面编辑区域字段列表
            lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2( objViewGroupENEx.objViewUpdate.ViewId ,
                clsRegionTypeENEx.EDITREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrEditRegionFldSet_Update = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Update)
            {
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);


                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }

            //初始化<详细信息>界面编辑区域字段列表
            lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2( objViewGroupENEx.objViewDetail.ViewId ,
                clsRegionTypeENEx.DETAILREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrEditRegionFldSet_Detail = clsEditRegionFldsBLEx.GetObjLstEx("RegionId = " + lngRegionId);
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewGroupENEx.arrEditRegionFldSet_Detail)
            {

                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objEditRegionFldsENEx.FldId, objViewGroupENEx.PrjId);

                objEditRegionFldsENEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFldsENEx.CtlTypeId);
                InsertToDetailFldSet(objEditRegionFldsENEx, objViewGroupENEx);
            }
        }


        public static void initDGRegionFldSet(clsViewGroupENEx objViewGroupENEx)
        {
            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2( objViewGroupENEx.objViewList.ViewId ,
                clsRegionTypeENEx.DGREGION, objViewGroupENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            objViewGroupENEx.arrDGRegionFldSet_List = clsDGRegionFldsBLEx.GetObjExLst("RegionId = " + lngRegionId);
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewGroupENEx.arrDGRegionFldSet_List)
            {                
                objDGRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId());
            }
        }
        public static void initViewRelaTabFldSet(clsViewGroupENEx objViewGroupENEx)
        {
            if (objViewGroupENEx.OutRelaTabId !=  "")
            {
                objViewGroupENEx .objOUTPrjTab = new clsPrjTabENEx(objViewGroupENEx.OutRelaTabId);
                     objViewGroupENEx.objOUTPrjTab.GetObjAllInfoEx();
              objViewGroupENEx .arrOUTTabFldSet = clsPrjTabFldBLEx.GetObjLstEx("TabId = '" + objViewGroupENEx.OutRelaTabId + "'");
            }
            if (objViewGroupENEx.InRelaTabId !=  "")
            {
                objViewGroupENEx .objINPrjTab = new clsPrjTabENEx(objViewGroupENEx.InRelaTabId);
                 objViewGroupENEx.objINPrjTab.GetObjAllInfoEx();
          objViewGroupENEx .arrINTabFldSet = clsPrjTabFldBLEx.GetObjLstEx("TabId = '" + objViewGroupENEx.InRelaTabId + "'");
            }
            //获取表字段对象(PrjTabFld)的字段(FieldTab)对象属性
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewGroupENEx.arrOUTTabFldSet)
            {
                //objPrjtabFldEx.arrFieldTabExObjLstBak = objViewGroupENEx. arrFieldTabExObjLstBak;
                //clsPrjTabFldBLEx.InitFieldTab(objPrjtabFldEx);
                objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);

                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.KeyField_02)
                {
                    objViewGroupENEx.objMainTabKeyFld = objPrjTabFldENEx;
                }

            }
            if (objViewGroupENEx.objMainTabKeyFld  ==  null)
            {
                string strOutRelaTabName = clsPrjTabBL.GetObjByTabId(objViewGroupENEx.OutRelaTabId).TabName;
                throw new clsDbObjException("在输出数据源:" + strOutRelaTabName + "中没有设置表关键字!");
            }
            if (objViewGroupENEx.arrINTabFldSet !=  null)
            {
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewGroupENEx.arrINTabFldSet)
                {
                    //objPrjtabFldEx.arrFieldTabExObjLstBak = objViewGroupENEx. arrFieldTabExObjLstBak;
                    //clsPrjTabFldBLEx.InitFieldTab(objPrjtabFldEx);
                    objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);

                    if (objPrjTabFldENEx.FieldTypeId == enumFieldType.KeyField_02)
                    {
                        objViewGroupENEx. objDetailTabKeyFld = objPrjTabFldENEx;
                    }
                }
            }
        }

        private static void InsertToDetailFldSet(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewGroupENEx objViewGroupENEx)
        {
            string strNewFldName = objEditRegionFldsEx.ObjFieldTabENEx.FldName;
            bool bolIsExist = false;
            foreach (clsEditRegionFldsENEx objDetailFld in objViewGroupENEx.arrDetailFldSet)
            {
                if (objDetailFld.ObjFieldTabENEx.FldName  ==  strNewFldName)
                {
                    bolIsExist = true;
                    break;
                }
            }
            if (bolIsExist  ==  false)
            {
                objViewGroupENEx.arrDetailFldSet.Add(objEditRegionFldsEx);
            }
        }


        public static System.Data.DataTable GetViewGroupId(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup where PrjId = '" + strPrjId + "'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindCbo_ViewGroupIdEx(System.Windows.Forms.ComboBox objComboBox, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetViewGroupId(strPrjId);
            clsViewGroupEN objViewGroup;
            //初始化一个对象列表
            ArrayList ViewGroupList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objViewGroup = new clsViewGroupEN();
            objViewGroup.ViewGroupId = "0";
            objViewGroup.ViewGroupName = "请选择...";
            ViewGroupList.Add(objViewGroup);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objViewGroup = new clsViewGroupEN();
                objViewGroup.ViewGroupId = objRow["ViewGroupId"].ToString();
                objViewGroup.ViewGroupName = objRow["ViewGroupName"].ToString();
                ViewGroupList.Add(objViewGroup);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = ViewGroupList;
            objComboBox.ValueMember = "ViewGroupId";
            objComboBox.DisplayMember = "ViewGroupName";
            objComboBox.SelectedIndex = 0;
        }

        public static void BindDdl_ViewGroupIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
//            System.Data.DataTable objDT = GetViewGroupId(strPrjId);
            List<clsViewGroupEN> arrViewGroupObjLst = clsViewGroupBLEx.GetViewGroupObjLstByPrjIdCache(strPrjId);
            objDDL.DataValueField = "ViewGroupId";
            objDDL.DataTextField = "ViewGroupName";
            objDDL.DataSource = arrViewGroupObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_ViewGroup(System.Windows.Forms.ListView lvViewGroup, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviViewGroup;
            List<clsViewGroupEN> arrViewGroupObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrViewGroupObjList = clsViewGroupBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvViewGroup.Items.Clear();//清除原来所有Item
            lvViewGroup.Columns.Clear();//清除原来所有列头信息
            lvViewGroup.Columns.Add("界面组ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("界面组名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("输入数据源表ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("输入数据源类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("输出数据源表ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("域/包名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("工程ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.Columns.Add("输出数据源类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewGroup.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsViewGroupEN objViewGroup in arrViewGroupObjList)
            {
                lviViewGroup = new System.Windows.Forms.ListViewItem();
                lviViewGroup.Tag = objViewGroup.ViewGroupId;
                lviViewGroup.Text = objViewGroup.ViewGroupId;
                lviViewGroup.SubItems.Add(objViewGroup.ViewGroupName);
                lviViewGroup.SubItems.Add(objViewGroup.InRelaTabId);
                lviViewGroup.SubItems.Add(objViewGroup.InSqlDsTypeId);
                lviViewGroup.SubItems.Add(objViewGroup.OutRelaTabId);
                lviViewGroup.SubItems.Add(objViewGroup.PrjDomain);
                lviViewGroup.SubItems.Add(objViewGroup.PrjId);
                lviViewGroup.SubItems.Add(objViewGroup.UserId);
                lviViewGroup.SubItems.Add(objViewGroup.UpdDate);
                lviViewGroup.SubItems.Add(objViewGroup.Memo);
                lviViewGroup.SubItems.Add(objViewGroup.OutSqlDsTypeId);
                lvViewGroup.Items.Add(lviViewGroup);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrViewGroupObjList.Count;
        }
    }
}
