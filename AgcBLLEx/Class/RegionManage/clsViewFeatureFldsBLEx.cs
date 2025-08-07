
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;


using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using System.Drawing;

namespace AGC.BusinessLogicEx
{
    public static class clsViewFeatureFldsBLEx_Static
    {
        //public static string PrjId(this clsViewFeatureFldsEN objFeatureRegionFldsEN)
        //{
        //    var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(objFeatureRegionFldsEN.CmPrjId);
        //    return objCmProject.PrjId;
        //}

        public static clsFieldTabEN ObjFieldTab1(this clsViewFeatureFldsEN objViewFeatureFldsEN)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objViewFeatureFldsEN.ReleFldId, objViewFeatureFldsEN.PrjId);
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据查询区字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
        /// </summary>
        /// <param name = "objViewFeatureFlds">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx(this clsViewFeatureFldsEN objViewFeatureFlds)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsViewFeatureFldsEN objViewFeatureFlds_Cond = new clsViewFeatureFldsEN();
            string strCondition = objViewFeatureFlds_Cond
            .SetFieldTypeId(objViewFeatureFlds.FieldTypeId, "=")
            .SetViewFeatureId(objViewFeatureFlds.ViewFeatureId, "=")
            .GetCombineCondition();
            objViewFeatureFlds._IsCheckProperty = true;
            bool bolIsExist = clsViewFeatureFldsBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objViewFeatureFlds.mId = clsViewFeatureFldsBL.GetFirstID_S(strCondition);
                objViewFeatureFlds.UpdateWithCondition(strCondition);
            }
            else
            {
                objViewFeatureFlds.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objViewFeatureFldsENS">源对象</param>
        /// <returns>目标对象=>clsViewFeatureFldsEN:objViewFeatureFldsENT</returns>
        public static clsViewFeatureFldsENEx CopyToEx(this clsViewFeatureFldsEN objViewFeatureFldsENS)
        {
            try
            {
                clsViewFeatureFldsENEx objViewFeatureFldsENT = new clsViewFeatureFldsENEx();
                clsViewFeatureFldsBL.CopyTo(objViewFeatureFldsENS, objViewFeatureFldsENT);
                return objViewFeatureFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objViewFeatureFldsENS">源对象</param>
        /// <returns>目标对象=>clsViewFeatureFldsEN:objViewFeatureFldsENT</returns>
        public static clsViewFeatureFldsEN CopyTo(this clsViewFeatureFldsENEx objViewFeatureFldsENS)
        {
            try
            {
                clsViewFeatureFldsEN objViewFeatureFldsENT = new clsViewFeatureFldsEN();
                clsViewFeatureFldsBL.CopyTo(objViewFeatureFldsENS, objViewFeatureFldsENT);
                return objViewFeatureFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 界面功能字段(ViewFeatureFlds)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsViewFeatureFldsBLEx : clsViewFeatureFldsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsViewFeatureFldsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsViewFeatureFldsDAEx ViewFeatureFldsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsViewFeatureFldsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="lngmId">表关键字</param>
        /// <returns></returns>
        private static bool DelRecordEx(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
                //删除与表:[ViewFeatureFlds]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsViewFeatureFldsBL.DelRecord(lngmId, "", objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsViewFeatureFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                lngmId, clsStackTrace.GetCurrClassFunction());
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

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewFeatureFldsENEx> GetObjExLst(string strCondition)
        {
            List<clsViewFeatureFldsEN> arrObjLst = clsViewFeatureFldsBL.GetObjLst(strCondition);
            List<clsViewFeatureFldsENEx> arrObjExLst = new List<clsViewFeatureFldsENEx>();
            foreach (clsViewFeatureFldsEN objInFor in arrObjLst)
            {
                clsViewFeatureFldsENEx objViewFeatureFldsENEx = new clsViewFeatureFldsENEx();
                clsViewFeatureFldsBL.CopyTo(objInFor, objViewFeatureFldsENEx);
                arrObjExLst.Add(objViewFeatureFldsENEx);
            }
            return arrObjExLst;
        }

        public static List<clsViewFeatureFldsENEx> GetObjExLstByViewIdCache(string strViewId, bool bolIsFstLcase, string strPrjId)
        {

            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            if (arrRegionId.Count == 0) return null;


            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2} in ({3}))",
                conViewFeatureFlds.ViewFeatureId,
                clsvFeatureRegionFldsEN._CurrTabName,
                convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));
            var arrvViewFeatureFldsCache = clsvViewFeatureFldsBL.GetObjLstCache(strPrjId);
            var arrViewFeatureFldsCache = clsViewFeatureFldsBL.GetObjLstCache(strPrjId);

            var arrSel = arrvViewFeatureFldsCache.Where(x => arrRegionId.Contains(x.RegionId)).Select(x=>x.mId).ToList();

            var arrObjLst = arrViewFeatureFldsCache.Where(x=> arrSel.Contains( x.mId)).ToList();
            //List<clsViewFeatureFldsEN> arrObjLst = clsViewFeatureFldsBL.GetObjLst(strCondition);
            List<clsViewFeatureFldsENEx> arrObjExLst = new List<clsViewFeatureFldsENEx>();
            arrObjLst = arrObjLst.Where(x => x.ReleFldId.Count() > 0).ToList();
            foreach (clsViewFeatureFldsEN objInFor in arrObjLst)
            {
                var objFeatureRegionFlds = clsFeatureRegionFldsBL.GetObjByViewFeatureIdCache(objInFor.ViewFeatureId, objInFor.PrjId);
                clsViewFeatureFldsENEx objViewFeatureFldsENEx = new clsViewFeatureFldsENEx();
                clsViewFeatureFldsBL.CopyTo(objInFor, objViewFeatureFldsENEx);

                objViewFeatureFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objViewFeatureFldsENEx.ReleFldId, strPrjId);
                objViewFeatureFldsENEx.ObjFieldTabENEx.objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objViewFeatureFldsENEx.ObjFieldTabENEx.DataTypeId).CopyToEx();
                objViewFeatureFldsENEx.RegionId = objFeatureRegionFlds.RegionId;
                objViewFeatureFldsENEx.FeatureId = objFeatureRegionFlds.FeatureId;
                objViewFeatureFldsENEx.ValueGivingModeId = objFeatureRegionFlds.ValueGivingModeId;
                objViewFeatureFldsENEx.FldId = objFeatureRegionFlds.ReleFldId;
                objViewFeatureFldsENEx.VarName = clsGCVariableBL.GetNameByVarIdCache( objInFor.VarId);
                //objViewFeatureFldsENEx.ObjFeatureRegionFldsENEx = objFeatureRegionFlds;
                objViewFeatureFldsENEx.CtlTypeName  = clsCtlTypeBL.GetNameByCtlTypeIdCache(objInFor.CtlTypeId);
                objViewFeatureFldsENEx.SeqNum = objFeatureRegionFlds.SeqNum ?? 0;
                objViewFeatureFldsENEx.GroupName = objFeatureRegionFlds.GroupName;
              

                if (string.IsNullOrEmpty(objViewFeatureFldsENEx.TabFeatureId4Ddl) == false)
                {
                    clsTabFeatureENEx4Ddl objTabFeatureENEx4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objViewFeatureFldsENEx.TabFeatureId4Ddl,strPrjId, bolIsFstLcase, strViewId);
                    if (objTabFeatureENEx4Ddl != null)
                    {
                        objViewFeatureFldsENEx.ValueFieldName = objTabFeatureENEx4Ddl.ValueFieldName;
                        objViewFeatureFldsENEx.TextFieldName = objTabFeatureENEx4Ddl.TextFieldName;
                        objViewFeatureFldsENEx.DsTabName = objTabFeatureENEx4Ddl.TabName4GC;


                    }
                }
                arrObjExLst.Add(objViewFeatureFldsENEx);
            }
            return arrObjExLst;
        }

        public static List<clsViewFeatureFldsENEx> GetObjExLstByViewFeatureId(string strViewFeatureId, string strPrjId)
        {
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                conViewFeatureFlds.ViewFeatureId,
                clsvFeatureRegionFldsEN._CurrTabName,
                convFeatureRegionFlds.ViewFeatureId, strViewFeatureId);

            List<clsViewFeatureFldsEN> arrObjLst = clsViewFeatureFldsBL.GetObjLst(strCondition);
            List<clsViewFeatureFldsENEx> arrObjExLst = new List<clsViewFeatureFldsENEx>();
            foreach (clsViewFeatureFldsEN objInFor in arrObjLst)
            {
                clsViewFeatureFldsENEx objViewFeatureFldsENEx = new clsViewFeatureFldsENEx();
                clsViewFeatureFldsBL.CopyTo(objInFor, objViewFeatureFldsENEx);

                objViewFeatureFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objViewFeatureFldsENEx.ReleFldId, strPrjId);
                objViewFeatureFldsENEx.ObjFieldTabENEx.objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objViewFeatureFldsENEx.ObjFieldTabENEx.DataTypeId).CopyToEx();

                arrObjExLst.Add(objViewFeatureFldsENEx);
            }
            return arrObjExLst;
        }

        public static IEnumerable<clsViewFeatureFldsEN> GetObjLstByViewFeatureIdCache(string strViewFeatureId, string strPrjId)
        {
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                conViewFeatureFlds.ViewFeatureId,
                clsvFeatureRegionFldsEN._CurrTabName,
                convFeatureRegionFlds.ViewFeatureId, strViewFeatureId);

            List<clsViewFeatureFldsEN> arrObjLstCache = clsViewFeatureFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsViewFeatureFldsEN> arrObjLst_Sel = arrObjLstCache.Where(x=>x.ViewFeatureId == strViewFeatureId);
            return arrObjLst_Sel;
        }
        public static int GetRecNumByViewFeatureIdCache(string strViewFeatureId, string strPrjId)
        {
            //string strCondition = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
            //    conViewFeatureFlds.ViewFeatureId,
            //    clsvFeatureRegionFldsEN._CurrTabName,
            //    convFeatureRegionFlds.ViewFeatureId, strViewFeatureId);

            List<clsViewFeatureFldsEN> arrObjLstCache = clsViewFeatureFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsViewFeatureFldsEN> arrObjLst_Sel = arrObjLstCache.Where(x => x.ViewFeatureId == strViewFeatureId);
            return arrObjLst_Sel.Count();
        }

        public static List<clsViewFeatureFldsEN> GetObjLstByViewFeatureId(string strViewFeatureId)
        {
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                conViewFeatureFlds.ViewFeatureId,
                clsvFeatureRegionFldsEN._CurrTabName,
                convFeatureRegionFlds.ViewFeatureId, strViewFeatureId);

            List<clsViewFeatureFldsEN> arrObjLst = clsViewFeatureFldsBL.GetObjLst(strCondition);

            return arrObjLst;
        }


        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsViewFeatureFldsENEx GetObjExBymId(long lngmId)
        {
            clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsBL.GetObjBymId(lngmId);
            clsViewFeatureFldsENEx objViewFeatureFldsENEx = new clsViewFeatureFldsENEx();
            clsViewFeatureFldsBL.CopyTo(objViewFeatureFldsEN, objViewFeatureFldsENEx);
            return objViewFeatureFldsENEx;
        }

        /// <summary>
        /// 功能:设置字段可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置可用的记录数</returns>
        public static int SetInUse(List<long> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsBL.GetObjBymId(strMid);
                    objViewFeatureFldsEN.InUse = true;
                    objViewFeatureFldsEN.UpdUser = strUpdUser;
                    objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsViewFeatureFldsBL.UpdateBySql2(objViewFeatureFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 功能:设置字段不可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置不可用的记录数</returns>
        public static int SetNotInUse(List<long> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsBL.GetObjBymId(strMid);
                    objViewFeatureFldsEN.InUse = false;
                    objViewFeatureFldsEN.UpdUser = strUpdUser;
                    objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsViewFeatureFldsBL.UpdateBySql2(objViewFeatureFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段不可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 绑定基于Web的下拉框， 按功能名排序
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "lngRegionId">需要绑定当前表的下拉框</param>
        public static void BindDdl_FeatureIdExByRegionId(System.Web.UI.WebControls.DropDownList objDDL, string lngRegionId)
        {
            //为数据源于表的下拉框设置内容
            //System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format(" {0} in (Select {0} From {1} Where {2}={3})",
            //    conViewFeatureFlds.FeatureId,
            //    clsViewFeatureFldsEN._CurrTabName,
            //    conViewFeatureFlds.RegionId,   lngRegionId);
            //List<clsPrjFeatureEN> arrObjLst= clsPrjFeatureBL.GetObjLst(strCondition);
            //arrObjLst = arrObjLst.FindAll(x=>x.IsNeedField == true);
            //objDDL.DataValueField = conPrjFeature.FeatureId;
            //objDDL.DataTextField = conPrjFeature.FeatureName;
            //objDDL.DataSource = arrObjLst;
            //objDDL.DataBind();
            //objDDL.Items.Insert(0, li);
            //objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_FeatureIdExByViewId1(System.Web.UI.WebControls.DropDownList objDDL, string strViewId, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            
            string strCondition = string.Format(" {0} in (Select {0} From {1} Where {2} in ({3}))",
                convViewFeatureFlds.FeatureId,
                clsvViewFeatureFldsEN._CurrTabName,
                 convViewFeatureFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));
            List<clsPrjFeatureEN> arrObjLst = clsPrjFeatureBL.GetObjLst(strCondition);
            arrObjLst = arrObjLst.FindAll(x => x.IsNeedField == true);
            objDDL.DataValueField = conPrjFeature.FeatureId;
            objDDL.DataTextField = conPrjFeature.FeatureName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        //public static bool ImportRelaFlds(string strViewId, string lngRegionId, string strFeatureId, string strPrjId, string strUserId)
        //{
        //    int intRecNum = 0;
        //    K_ViewId_ViewInfo objKey = new K_ViewId_ViewInfo(strViewId);
        //    clsViewInfoEN objViewInfoEN = objKey.GetObj();

        //    List<clsvPrjTabFldEN> arrPrjTabFld = clsvPrjTabFldBLEx.GetObjLstByTabIdExCache(objViewInfoEN.PrjId, objViewInfoEN.MainTabId);
        //    IEnumerable<clsViewFeatureFldsEN> arrViewFeatureFldsObjLst = arrPrjTabFld.Where(x => x.PrimaryTypeId != enumPrimaryType.Identity_02).Select(clsViewFeatureFldsBLEx.GetObjByvPrjTabFld);

        //    foreach (clsViewFeatureFldsEN objInFor in arrViewFeatureFldsObjLst)
        //    {

        //        if (objInFor.CheckUniqueness_ViewFeatureId_FldId() == true)
        //        {
        //            objInFor.SetRegionId(lngRegionId)
        //                //.SetTabFldId(objInFor.mId)
        //                //.SetLabelCaption(objInFor.Caption)
        //                .SetFeatureId(strFeatureId)              
        //                .SetInUse(true)
        //                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
        //                .SetUpdUser(strUserId)
        //                .AddNewRecord();
        //        }
        //    }

        //    return true;

        //}


        public static clsViewFeatureFldsEN GetObjByvPrjTabFld(clsvPrjTabFldEN objPrjTabFldEN, string strViewFeatureId)
        {
 
            string strUserId = "";
  
            clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
         
            objViewFeatureFldsEN.ReleFldId = objPrjTabFldEN.FldId;
            objViewFeatureFldsEN.ViewFeatureId = strViewFeatureId;
            objViewFeatureFldsEN.LabelCaption = objPrjTabFldEN.Caption;
            switch (objPrjTabFldEN.DataTypeName)
            {
                case "bit":
                    objViewFeatureFldsEN.CtlTypeId = "02";
                    break;
                default:
                    objViewFeatureFldsEN.CtlTypeId = "16";
                    break;
            }
            var objvFieldTab4CodeConv = objPrjTabFldEN.ObjvFieldTab4CodeConv();
            //判断该字段是否为相关表中的关键字
            if (objPrjTabFldEN.FieldTypeId != enumFieldType.KeyField_02
                && objvFieldTab4CodeConv != null
                && objvFieldTab4CodeConv.CodeTab != ""
                && objvFieldTab4CodeConv.CodeTabCode != ""
                && objvFieldTab4CodeConv.CodeTabName != "")
            {
                objViewFeatureFldsEN.CtlTypeId = "06";
                objViewFeatureFldsEN.DdlItemsOptionId = "02";
                string strDsTabId = clsPrjTabBL.GetFirstID_S("PrjId = '" + objPrjTabFldEN.PrjId + "' and TabName = '" 
                    + objvFieldTab4CodeConv.CodeTab + "'");
                if (strDsTabId != "")
                {
                    objViewFeatureFldsEN.DsTabId = strDsTabId;
                    //string strDsDataValueFieldId = clsFieldTabBL.GetFirstID_S("PrjId = '" + objPrjTabFldEN.PrjId 
                    //    + "' and FldName = '" + objvFieldTab4CodeConv.CodeTabCode + "'");
                    //if (strDsDataValueFieldId != "")
                    //{
                    //    objViewFeatureFldsEN.DsDataValueFieldId = strDsDataValueFieldId;
                    //}
                    //string strDs_DataTextFieldId = clsFieldTabBL.GetFirstID_S("PrjId = '" + objPrjTabFldEN.PrjId 
                    //    + "' and FldName = '" + objvFieldTab4CodeConv.CodeTabName + "'");
                    //if (strDs_DataTextFieldId != "")
                    //{
                    //    objViewFeatureFldsEN.Ds_DataTextFieldId = strDs_DataTextFieldId;
                    //}
                    objViewFeatureFldsEN.TabFeatureId4Ddl = clsTabFeatureBLEx.GetFstFeatureIdByTabId(objViewFeatureFldsEN.DsTabId, objPrjTabFldEN.PrjId);

                }
            }
      else
            {
                objViewFeatureFldsEN.DdlItemsOptionId = "00";
                objViewFeatureFldsEN.DsTabId = "";
                objViewFeatureFldsEN.TabFeatureId4Ddl = "";
            }
            objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayStr(0);
            objViewFeatureFldsEN.UpdUser = strUserId;
            objViewFeatureFldsEN.InUse = true;
            //5、检查传进去的对象属性是否合法


            return objViewFeatureFldsEN;

        }
        public static clsViewFeatureFldsEN GetObjByvPrjTabFld(clsvPrjTabFldEN objPrjTabFldEN)
        { 
            
            clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
           
            //2、获取相关主表ID的字段的对象列表;

            if (objPrjTabFldEN.PrimaryTypeId == "02" && objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
            {
                return null;
            }
            objViewFeatureFldsEN.ReleFldId = objPrjTabFldEN.FldId;
            //objViewFeatureFldsEN.RegionId = lngRegionId;
            objViewFeatureFldsEN.LabelCaption = objPrjTabFldEN.Caption;
            switch (objPrjTabFldEN.DataTypeName)
            {
                case "bit":
                    objViewFeatureFldsEN.CtlTypeId = "02";
                    break;
                default:
                    objViewFeatureFldsEN.CtlTypeId = "16";
                    break;
            }
            var objvFieldTab4CodeConv = objPrjTabFldEN.ObjvFieldTab4CodeConv();
            //判断该字段是否为相关表中的关键字
            if (objPrjTabFldEN.FieldTypeId != enumFieldType.KeyField_02
                && objvFieldTab4CodeConv != null
                && objvFieldTab4CodeConv.CodeTab != ""
                && objvFieldTab4CodeConv.CodeTabCode != ""
                && objvFieldTab4CodeConv.CodeTabName != "")
            {
                objViewFeatureFldsEN.CtlTypeId = enumCtlType.DropDownList_06;
                objViewFeatureFldsEN.DdlItemsOptionId = enumDDLItemsOption.DataSourceTable_02;
                string strDsTabId = clsPrjTabBL.GetFirstID_S("PrjId = '" + objPrjTabFldEN.PrjId + "' and TabName = '" 
                    + objvFieldTab4CodeConv.CodeTab + "'");
                if (strDsTabId != "")
                {
                    objViewFeatureFldsEN.DsTabId = strDsTabId;
                    //string strDsDataValueFieldId = clsFieldTabBL.GetFirstID_S("PrjId = '" + objPrjTabFldEN.PrjId 
                    //    + "' and FldName = '" + objvFieldTab4CodeConv.CodeTabCode + "'");
                    //if (strDsDataValueFieldId != "")
                    //{
                    //    objViewFeatureFldsEN.DsDataValueFieldId = strDsDataValueFieldId;
                    //}
                    //string strDs_DataTextFieldId = clsFieldTabBL.GetFirstID_S("PrjId = '" + objPrjTabFldEN.PrjId 
                    //    + "' and FldName = '" + objvFieldTab4CodeConv.CodeTabName + "'");
                    //if (strDs_DataTextFieldId != "")
                    //{
                    //    objViewFeatureFldsEN.Ds_DataTextFieldId = strDs_DataTextFieldId;
                    //}
                    objViewFeatureFldsEN.TabFeatureId4Ddl = clsTabFeatureBLEx.GetFstFeatureIdByTabId(objViewFeatureFldsEN.DsTabId, objPrjTabFldEN.PrjId);
                }
            }
            else
            {
                objViewFeatureFldsEN.DdlItemsOptionId = "00";
                objViewFeatureFldsEN.DsTabId = "";
                //objViewFeatureFldsEN.DsDataValueFieldId = "";
                //objViewFeatureFldsEN.Ds_DataTextFieldId = "";
                objViewFeatureFldsEN.TabFeatureId4Ddl = "";
            }
            
            //if (clsViewRegionBL.GetObjByRegionId(lngRegionId).RegionTypeId == clsRegionTypeBLEx.DETAILREGION)
            //{            
            //    objViewFeatureFldsEN.CtlTypeId = clsCtlTypeBLEx.LABELTYPE;
            //}
            objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayStr(0);
            //objViewFeatureFldsEN.UpdUser = strUserId;

            //5、检查传进去的对象属性是否合法
            if (objPrjTabFldEN.FldName.StartsWith("_"))
            {
                objViewFeatureFldsEN.InUse = false;
            }
            else
            {
                objViewFeatureFldsEN.InUse = true;
            }

            return objViewFeatureFldsEN;

        }

       
        public static clsViewFeatureFldsEN GetObjByvTabFeatureFlds(clsvTabFeatureFldsEN objTabFeatureFldsEN)
        {
            //string lngRegionId = "";
            string strUserId = "";
            //int intRecNum = 0;
            clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();



            objViewFeatureFldsEN.ReleFldId = objTabFeatureFldsEN.FldId;
            objViewFeatureFldsEN.FieldTypeId = objTabFeatureFldsEN.FieldTypeId;
            //objViewFeatureFldsEN.ViewFeatureId = strViewFeatureId;
            objViewFeatureFldsEN.LabelCaption = objTabFeatureFldsEN.Caption;
            switch (objTabFeatureFldsEN.DataTypeName)
            {
                case "bit":
                    objViewFeatureFldsEN.CtlTypeId = "02";
                    break;
                default:
                    objViewFeatureFldsEN.CtlTypeId = "16";
                    break;
            }
           


            objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayStr(0);
            objViewFeatureFldsEN.UpdUser = strUserId;
            objViewFeatureFldsEN.InUse = true;
            //5、检查传进去的对象属性是否合法


            return objViewFeatureFldsEN;

        }
        /// <summary>
        /// 转换代码表
        /// </summary>
        public static string InitDsTabName4Get(clsViewFeatureFldsENEx objViewFeatureFldsENEx)
        {

            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objViewFeatureFldsENEx.DsTabId, objViewFeatureFldsENEx.PrjId);
            if (objPrjTabEN == null || string.IsNullOrEmpty(objViewFeatureFldsENEx.DsTabId))
            {
                clsvFieldTabEN objvPrjTabFld = clsvFieldTabBL.GetObjByFldId(objViewFeatureFldsENEx.FldId);
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionId(objViewFeatureFldsENEx.RegionId);
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在表[{0}]中,表字段[{1}]不存在转换代码表。",
                    objPrjTabEN.TabName, objvPrjTabFld.FldName);
                sbMessage.AppendFormat(", 区域ID = {0},区域名称 = {1}, 区域类型 = {2}",
                    objViewFeatureFldsENEx.RegionId, objvViewRegion.RegionName, objvViewRegion.RegionTypeName);
                sbMessage.AppendFormat(", 当前类为:{0}", objViewFeatureFldsENEx.GetType().ToString());
                string strINTabName = objvViewRegion.TabName;
                sbMessage.AppendFormat(", 当前相关输入表:{0}", strINTabName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            //objViewFeatureFldsENEx.DS_TabName = objPrjTabEN.TabName;
            return objPrjTabEN.TabName;

        }

        public static void initViewFeatureFlds(clsViewInfoENEx objViewInfoENEx, bool bolIsFstLcase)
        {
            
            objViewInfoENEx.arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjExLstByViewIdCache(objViewInfoENEx.ViewId, bolIsFstLcase, objViewInfoENEx.PrjId);
            if (objViewInfoENEx.arrViewFeatureFlds == null) return;
            foreach (clsViewFeatureFldsENEx objViewFeatureFldsEx in objViewInfoENEx.arrViewFeatureFlds)
            {               

                objViewFeatureFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objViewFeatureFldsEx.ReleFldId, objViewInfoENEx.PrjId);
                if (string.IsNullOrEmpty(objViewFeatureFldsEx.CtlTypeId) == false)
                {
                    objViewFeatureFldsEx.ObjCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objViewFeatureFldsEx.CtlTypeId);
                }
            }
        }

        public static List<clsViewFeatureFldsENEx> GetObjExLstByRegionId(string lngRegionId, string strPrjId)
        {
  
            string strCondition = string.Format("{0} in (Select {0} From {1} where {2}={3})",
                conViewFeatureFlds.ViewFeatureId,
                clsFeatureRegionFldsEN._CurrTabName, 
                conFeatureRegionFlds.RegionId, lngRegionId);

            List<clsViewFeatureFldsEN> arrObjLst = clsViewFeatureFldsBL.GetObjLst(strCondition);
            List<clsViewFeatureFldsENEx> arrObjExLst = new List<clsViewFeatureFldsENEx>();
            foreach (clsViewFeatureFldsEN objInFor in arrObjLst)
            {
                clsViewFeatureFldsENEx objViewFeatureFldsENEx = new clsViewFeatureFldsENEx();
                clsViewFeatureFldsBL.CopyTo(objInFor, objViewFeatureFldsENEx);
                if (string.IsNullOrEmpty(objViewFeatureFldsENEx.ReleFldId) == false) objViewFeatureFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objViewFeatureFldsENEx.ReleFldId, strPrjId);
                if (string.IsNullOrEmpty(objViewFeatureFldsENEx.CtlTypeId) == false)
                {
                    objViewFeatureFldsENEx.ObjCtlType = clsCtlTypeBLEx.GetObjByCtlTypeIdCache(objViewFeatureFldsENEx.CtlTypeId);
                }
                arrObjExLst.Add(objViewFeatureFldsENEx);
            }
            return arrObjExLst;
        }


        public static IEnumerable<clsViewFeatureFldsEN> GetObjLstByRegionIdCache2(string lngRegionId, string strPrjId)
        {
            var arrViewFeatureId = clsFeatureRegionFldsBL.GetObjLstCache(strPrjId)
                .Where(x=>x.RegionId == lngRegionId)
                .Select(x=>x.ViewFeatureId);
            IEnumerable<clsViewFeatureFldsEN> arrObjLst = clsViewFeatureFldsBL.GetObjLstCache(strPrjId).Where(x=> arrViewFeatureId.Contains(x.ViewFeatureId));
            return arrObjLst;
        }

        public static string GetCtrlId(clsViewFeatureFldsEN objViewFeatureFlds)
        {  
            if (string.IsNullOrEmpty( objViewFeatureFlds.ReleFldId)) return "";
            if (string.IsNullOrEmpty(objViewFeatureFlds.CtlTypeId)) return "";
            clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureIdCache(objViewFeatureFlds.ViewFeatureId, objViewFeatureFlds.PrjId);
            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFldsEN.FeatureId);

            string strFldId = objViewFeatureFlds.ReleFldId;
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
            switch (objPrjFeatureEN.FeatureName)
            {
                case "设置字段值":
                    return  string.Format("{0}", clsCtlTypeBLEx.GetCtrlId(objViewFeatureFlds.CtlTypeId, objFieldTab.FldName));
                    
                case "复制记录":
                    return "";
                case "调整记录次序":
                case "移顶":
                case "上移":
                case "下移":
                case "移底":
                case "重序":
                    return string.Format("{0}_OrderNum", clsCtlTypeBLEx.GetCtrlId(objViewFeatureFlds.CtlTypeId, objFieldTab.FldName));
              
                default:
                    return "";
            }

        }

        public static List<clsGCVariableEN> GetGcVarLst4ViewVar2(string lngRegionId, string strPrjId)
        {
            List<string> arrCtlType = new List<string>() {  enumCtlType.ViewVariable_38 };
            var arrViewFeatureFlds = GetObjLstByRegionIdCache2(lngRegionId, strPrjId)
                .Where(x => arrCtlType.Contains(x.CtlTypeId));
            var arrGCVariable = new List<clsGCVariableEN>();

            foreach (var objInFor in arrViewFeatureFlds)
            {
                var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                if (objVar != null)
                {
                    objVar.DataTypeId = objInFor.ObjFieldTab1().DataTypeId;
                    objVar.Memo = "编辑区缺省值";
                    arrGCVariable.Add(objVar);
                }
            }

            return arrGCVariable;
        }


        public static List<clsGCVariableEN> GetGcVarLst4DdlCond2(string lngRegionId, string strPrjId)
        {
            List<string> arrCtlType = new List<string>() { enumCtlType.DropDownList_06 };
            var arrViewFeatureFlds = GetObjLstByRegionIdCache2(lngRegionId, strPrjId)
                .Where(x => arrCtlType.Contains(x.CtlTypeId));
            var arrGCVariable = new List<clsGCVariableEN>();

            foreach (var objInFor in arrViewFeatureFlds)
            {
                {
                    var objVar_Cond1 =
                        string.IsNullOrEmpty(objInFor.VarIdCond1) ? null :
                        clsGCVariableBL.GetObjByVarIdCache(objInFor.VarIdCond1);
                    if (objVar_Cond1 != null)
                    {
                        var objField = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldIdCond1, objInFor.PrjId);
                        objVar_Cond1.DataTypeId = objField.DataTypeId;
                        objVar_Cond1.Memo = "功能区下拉框条件变量1";
                        arrGCVariable.Add(objVar_Cond1);
                    }
                }
                {
                    var objVar_Cond2 =
                        string.IsNullOrEmpty(objInFor.VarIdCond2) ?null:
                        clsGCVariableBL.GetObjByVarIdCache(objInFor.VarIdCond2);
                    if (objVar_Cond2 != null)
                    {
                        var objField = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldIdCond2, objInFor.PrjId);
                        objVar_Cond2.DataTypeId = objField.DataTypeId;
                        objVar_Cond2.Memo = "功能区下拉框条件变量2";
                        arrGCVariable.Add(objVar_Cond2);
                    }
                }
            }

            return arrGCVariable;
        }
        public static bool SetPrjId(string strViewFeatureId, string strPrjId, string strUserId)
        {
            try
            {
                List<clsViewFeatureFldsEN> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjLstByViewFeatureId(strViewFeatureId);
                foreach (var objInFor in arrViewFeatureFlds)
                {
                    try
                    {
                        objInFor
                            .SetPrjId(strPrjId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                            .SetUpdUser(strUserId)
                            .Update();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                return true;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

    }
}