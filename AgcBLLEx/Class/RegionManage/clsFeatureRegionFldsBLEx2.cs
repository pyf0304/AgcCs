
///----------------------
///生成代码版本:2012.01.02.1
///生成日期:2012/10/08
///生成者:潘以锋
///工程名称:AGC
///工程ID:0005
///模块中文名:区域管理
///模块英文名:RegionManage
///注意:1、需要数据底层(PubDataBase.dll)的版本:2011.05.08.1
///       2、需要公共函数层(TzPubFunction.dll)的版本:2011.05.08.1
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;

using System.Collections.Generic;
using AGC.Entity;
using AGC.DAL;
using AGC.BusinessLogic;


using com.taishsoft.common;
using System.Linq;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 功能区域字段列表(FeatureRegionFlds)
    /// </summary>
    public partial class clsFeatureRegionFldsBLEx 
    {
        public clsCtlTypeEN objCtlType = null;
        public static void initFeatureRegionFldSet(clsViewInfoENEx objViewInfoENEx)
        {
            List<string> arrRegionId  = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
            //			clsViewFldInfo objViewFldInfo = new clsViewFldInfo(objViewInfoENEx.ViewId);
            objViewInfoENEx.TabKeyFldNum = 0;

            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(objViewInfoENEx.ViewId,
                clsRegionTypeENEx.FEATUREREGION, objViewInfoENEx.PrjId);
            if (string.IsNullOrEmpty( lngRegionId )== true)
            {
                return;
            }
            //objViewInfoENEx.objFeatureRegionENEx = new clsFeatureRegionENEx(lngRegionId);
            //clsFeatureRegionBLEx.GetFeatureRegionEx(ref objViewInfoENEx.objFeatureRegionENEx, objViewInfoENEx.PrjId);

            objViewInfoENEx.arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjExLst1(arrRegionId, objViewInfoENEx.PrjId);

            //objViewInfoENEx.objFeatureRegionENEx.FieldNum = objViewInfoENEx.arrFeatureRegionFlds.Count;
            objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst = new List<clsvFunction4GeneCodeEN>();
            foreach (clsFeatureRegionFldsENEx objFeatureRegionFldsEx in objViewInfoENEx.arrFeatureRegionFlds)
            {
                if (string.IsNullOrEmpty(objFeatureRegionFldsEx.ReleFldId) == false)
                {
                    objFeatureRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objFeatureRegionFldsEx.ReleFldId, objViewInfoENEx.PrjId);
                }
                objFeatureRegionFldsEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objFeatureRegionFldsEx.CtlTypeId);
                IEnumerable<clsvFunction4GeneCodeEN> arrObjLst = clsvFunction4GeneCodeBLEx.GetObjLstByFeatureIdCache(objFeatureRegionFldsEx.FeatureId);
                foreach(clsvFunction4GeneCodeEN objInFor in arrObjLst)
                {
                    if (objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst.Find(x=>x.FuncId4GC == objInFor.FuncId4GC) == null)
                    {
                        objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst.Add(objInFor);
                    }
                }
            }
          
        }


        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_FeatureRegionFlds(System.Windows.Forms.ListView lvFeatureRegionFlds, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviFeatureRegionFlds;
            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrFeatureRegionFldsObjList = clsFeatureRegionFldsBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvFeatureRegionFlds.Items.Clear();//清除原来所有Item
            lvFeatureRegionFlds.Columns.Clear();//清除原来所有列头信息
            lvFeatureRegionFlds.Columns.Add("界面功能Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("区域Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("按钮名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("文本内容", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("控件类型号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("高度", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("宽", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("字段序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("样式表", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("图片资源", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegionFlds.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsFeatureRegionFldsEN objFeatureRegionFlds in arrFeatureRegionFldsObjList)
            {
                lviFeatureRegionFlds = new System.Windows.Forms.ListViewItem();
                lviFeatureRegionFlds.Tag = objFeatureRegionFlds.ViewFeatureId;
                lviFeatureRegionFlds.Text = objFeatureRegionFlds.ViewFeatureId.ToString();
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.ButtonName);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.Text);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.Height.ToString());
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.Width.ToString());
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.SeqNum.ToString());
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.CssClass);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.ImageUrl);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.UpdUser);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.UpdDate);
                lviFeatureRegionFlds.SubItems.Add(objFeatureRegionFlds.Memo);
                lvFeatureRegionFlds.Items.Add(lviFeatureRegionFlds);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrFeatureRegionFldsObjList.Count;
        }

        ///// <summary>
        ///// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        ///// </summary>
        ///// <param name = "lngmId">所给的关键字</param>
        ///// <returns>根据关键字获取的对象</returns>
        //public static clsFeatureRegionFldsEN GetFeatureRegionFldsObjBymId(long lngmId)
        //{
        //    if (arrFeatureRegionFldsObjLst  ==  null)
        //    {
        //        arrFeatureRegionFldsObjLst = clsFeatureRegionFldsBL.GetObjLst("1 = 1");
        //    }
        //    foreach (clsFeatureRegionFldsEN objFeatureRegionFlds in arrFeatureRegionFldsObjLst)
        //    {
        //        if (objFeatureRegionFlds.mId  ==  lngmId)
        //        {
        //            return objFeatureRegionFlds;
        //        }
        //    }
        //    return null;
        //}

        /// <summary>
        /// 获取满足条件的所有记录对象列表,用对象列表的形式表示
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>满足条件的所有记录对象列表</returns>
        public List<clsFeatureRegionFldsENEx> GetObjLstEx(string strCondition)
        {
            List<clsFeatureRegionFldsENEx> arrObjList = new List<clsFeatureRegionFldsENEx>();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
            strSQL = "Select * from FeatureRegionFlds where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count  ==  0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsFeatureRegionFldsENEx objFeatureRegionFlds = new clsFeatureRegionFldsENEx();
                objFeatureRegionFlds.ViewFeatureId = objRow["ViewFeatureId"].ToString().Trim(); //mId
                objFeatureRegionFlds.RegionId = objRow["RegionId"].ToString().Trim(); //区域Id
                objFeatureRegionFlds.ButtonName = objRow["ButtonName"].ToString().Trim(); //按钮名称
                objFeatureRegionFlds.Text = objRow["Text"].ToString().Trim(); //文本内容
                objFeatureRegionFlds.CtlTypeId = objRow["CtlTypeId"].ToString().Trim(); //控件类型号
                objFeatureRegionFlds.Height = clsGeneralTab2. TransNullToInt_S(objRow["Height"].ToString().Trim()); //高度
                objFeatureRegionFlds.Width = clsGeneralTab2. TransNullToInt_S(objRow["Width"].ToString().Trim()); //宽
                objFeatureRegionFlds.SeqNum = clsGeneralTab2. TransNullToInt_S(objRow["SeqNum"].ToString().Trim()); //字段序号
                objFeatureRegionFlds.CssClass = objRow["CssClass"].ToString().Trim(); //样式表
                objFeatureRegionFlds.ImageUrl = objRow["ImageUrl"].ToString().Trim(); //图片资源
                objFeatureRegionFlds.UpdUser = objRow["UpdUser"].ToString().Trim(); //用户ID
                objFeatureRegionFlds.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
                objFeatureRegionFlds.Memo = objRow["Memo"].ToString().Trim(); //说明
                objFeatureRegionFlds.ClearUpdateState();//清除修改状态,即清除脏字段信息
                arrObjList.Add(objFeatureRegionFlds);
            }
            objDT = null;
            return arrObjList;
        }
        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="strViewFeatureId">表关键字</param>
        /// <returns></returns>
        public static bool DelRecordEx(string strViewFeatureId, string strPrjId, string strOpUserId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[FeatureRegionFlds]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'",
                conFeatureRegionFlds.ViewFeatureId,                strViewFeatureId);
                clsViewFeatureFldsBL.DelViewFeatureFldssByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);

                clsFeatureRegionFldsBL.DelRecord(strViewFeatureId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsFeatureRegionFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strViewFeatureId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }
        public static void ReOrderEx(string lngRegionId)
        {
            IEnumerable<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjList = clsFeatureRegionFldsBL.GetObjLst("RegionId = '" + lngRegionId + "' order by SeqNum ");
            arrFeatureRegionFldsObjList = arrFeatureRegionFldsObjList.OrderByDescending(x => x.InUse).ThenBy(x => x.SeqNum);
            int intIndex = 1;
            foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrFeatureRegionFldsObjList)
            {
                objFeatureRegionFldsEN.SeqNum = intIndex;
                clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
                intIndex++;
            }
        }

        public static clsFeatureRegionFldsENEx GetObjEx(clsFeatureRegionFldsEN objFeatureRegionFlds)
        {
            clsFeatureRegionFldsENEx objFeatureRegionFldsENEx = new clsFeatureRegionFldsENEx();
            CopyTo(objFeatureRegionFlds, objFeatureRegionFldsENEx);
            return objFeatureRegionFldsENEx;
        }

        public static List<clsFeatureRegionFldsEN> GetObjLstByRegionIdEx(string lngRegionId)
        {
            //初始化列表缓存
            string strCondition = string.Format("{0}={1}", conFeatureRegionFlds.RegionId, lngRegionId);
            List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel = clsFeatureRegionFldsBL.GetObjLst(strCondition);
            return arrFeatureRegionFldsObjLst_Sel;

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
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
            var arrFeatureRegionFldsEx = arrFeatureRegionFlds.Select(clsFeatureRegionFldsBLEx.GetObjEx).ToList();
            //StringBuilder sbErrMsg = new StringBuilder();
            //try
            //{

            foreach (var objInFor in arrFeatureRegionFldsEx)
            {
                if (objInFor.InUse == false) continue;
                try
                {
                    switch (objInFor.CtlTypeId)
                    {
                        case enumCtlType.DropDownList_06:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.DropDownList_Bool_18:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.TextBox_16:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.CheckBox_02:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.Button_01:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
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

                    objInFor.Update();
                    intErrCount++;
                    continue;
                }
                if (objInFor.ErrMsg != null && objInFor.ErrMsg.Length > 0)
                {
                    objInFor.ErrMsg = "";
                    objInFor.Update();
                    continue;
                }
            }

            var objErrMsg = new clsErrMsgENEx(conErrType.FeatureRegion, intErrCount);
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

        public static List<clsFeatureRegionFldsENEx> GetObjExLstEx(string strViewId, string strPrjId)
        {
            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId,
                    enumRegionType.FeatureRegion_0008, strPrjId);
            if (string.IsNullOrEmpty(lngRegionId) == true)
            {
                return new List<clsFeatureRegionFldsENEx>();
            }

            List<clsFeatureRegionFldsENEx> arrFeatureRegionFldSet = clsFeatureRegionFldsBLEx.GetObjExLstByRegionIdEx(lngRegionId, strPrjId);

            foreach (clsFeatureRegionFldsENEx objFeatureRegionFldsEx in arrFeatureRegionFldSet)
            {
                if (string.IsNullOrEmpty(objFeatureRegionFldsEx.ReleFldId)) continue;
                try
                {
                    objFeatureRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objFeatureRegionFldsEx.ReleFldId, strPrjId);
                    if (objFeatureRegionFldsEx.ReleFldId.Length > 0 && objFeatureRegionFldsEx.ObjFieldTabENEx == null)
                    {
                        continue;
                    }

                    objFeatureRegionFldsEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objFeatureRegionFldsEx.CtlTypeId);
                }
                catch (Exception objEx1)
                {
                    if (objEx1.Message.IndexOf("没有字段Id") > -1) continue;
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("界面Id:{0},获取功能字段扩展信息出错，错误:{1}.(in {2})",
                        strViewId, objEx1.Message,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(sbMsg.ToString());
                }
            }
            return arrFeatureRegionFldSet;
        }


    }
}