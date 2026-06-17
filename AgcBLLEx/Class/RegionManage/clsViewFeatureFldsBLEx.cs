
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace AGC.BusinessLogicEx
{
    public static class clsViewFeatureFldsBLEx_Static
    {
        //public static string PrjId(this clsViewFeatureFldsEN objFeatureRegionFldsEN)
        //{
        //    var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(objFeatureRegionFldsEN.CmPrjId);
        //    return objCmProject.PrjId;
        //}
        public static bool IsNumberType(this clsViewFeatureFldsEN objViewFeatureFlds)
        {
            switch (objViewFeatureFlds.ObjFieldTab1().ObjDataTypeAbbr().CsType)
            {
                case "Int":
                case "int":
                case "long":
                case "float":
                case "short":
                case "double":
                    return true;
                default:
                    return false;
            }
        }
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

        public static List<clsViewFeatureFldsEN> GetObjLstByViewFeatureIdCache(string strViewFeatureId, string strPrjId)
        {
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                conViewFeatureFlds.ViewFeatureId,
                clsvFeatureRegionFldsEN._CurrTabName,
                convFeatureRegionFlds.ViewFeatureId, strViewFeatureId);

            List<clsViewFeatureFldsEN> arrObjLstCache = clsViewFeatureFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsViewFeatureFldsEN> arrObjLst_Sel = arrObjLstCache.Where(x=>x.ViewFeatureId == strViewFeatureId);
            return arrObjLst_Sel.ToList();
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

        /// <summary>
        /// 根据界面ID获取下拉框选项信息列表
        /// </summary>
        /// <param name="strViewId">界面ID</param>
        /// <param name="strPrjId">工程ID</param>
        /// <returns>下拉框选项信息列表</returns>
        public static List<DdlOptionsInfo> GetDdlOptionInfoLstByViewId(string strViewId, string strPrjId)
        {
            // 修正：使用 GetObjExLstByViewIdCache 替代 GetObjExLstEx
            var arrViewFeatureFldsENEx = GetObjExLstByViewIdCache(strViewId, false, strPrjId);
            
            if (arrViewFeatureFldsENEx == null || arrViewFeatureFldsENEx.Count == 0)
            {
                return new List<DdlOptionsInfo>();
            }
            
            List<DdlOptionsInfo> arrDdlOptionsInfo = GetDdlOptionInfoLst(arrViewFeatureFldsENEx);
            return arrDdlOptionsInfo;
        }


        /// <summary>
        /// 根据查询区域字段列表获取下拉框选项信息列表
        /// </summary>
        /// <param name="arrViewFeatureFldsENEx">查询区域字段扩展对象列表</param>
        /// <returns>下拉框选项信息列表</returns>
        public static List<DdlOptionsInfo> GetDdlOptionInfoLst(List<clsViewFeatureFldsENEx> arrViewFeatureFldsENEx)
        {
            List<DdlOptionsInfo> arrDdlOptionsInfo = new List<DdlOptionsInfo>();

            try
            {
                // 1. 筛选出下拉框类型且非布尔类型的字段
                var arrDropDownFields = arrViewFeatureFldsENEx
                    .Where(x => (x.CtlTypeId == enumCtlType.DropDownList_06 || x.CtlTypeId == enumCtlType.DropDownList_Bool_18)
                             && x.InUse == true)
                    .ToList();

                // 2. 对每个下拉框字段生成选项信息
                foreach (var fld in arrDropDownFields)
                {
                    try
                    {
                        var optionInfo = GetOptionsInfoFromDataSource(fld);
                        if (optionInfo != null)
                        {
                            arrDdlOptionsInfo.Add(optionInfo);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"处理下拉框字段 {fld.FldId} 时出错: {ex.Message}");
                    }
                }

                // 3. 去重：按 Key 分组，每个 Key 只保留一个
                var uniqueOptions = arrDdlOptionsInfo
                    .GroupBy(x => x.Key)
                    .Select(g => g.First())
                    .ToList();

                return uniqueOptions;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取下拉框选项信息列表出错,{1}.({0})",
                    clsStackTrace.GetCurrClassFunction(),
                    objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 从数据源表和表功能获取选项信息（包含参数信息）
        /// </summary>
        private static DdlOptionsInfo GetOptionsInfoFromDataSource(clsViewFeatureFldsENEx objViewFeatureFldsENEx)
        {
            try
            {
                string optionKey = "";
                List<DdlOptionParam> parameters = new List<DdlOptionParam>();

                // 5. 获取字段名
                string fldName = objViewFeatureFldsENEx.ObjFieldTabENEx?.FldName;
                if (string.IsNullOrEmpty(fldName))
                {
                    return null;
                }
                if (objViewFeatureFldsENEx.CtlTypeId == enumCtlType.DropDownList_Bool_18)
                {
                    optionKey = ToCamelCase(fldName) + "_f";

                    var optionInfo0 = new DdlOptionsInfo
                    {
                        Key = optionKey,
                        ControlType = "select4Bool",
                        AuxControlType = "select4Bool",
                        AuxControlId = objViewFeatureFldsENEx.CtrlId,
                        AuxControlOptionsKey = optionKey,                        
                        OptionsKey = optionKey,
                        Parameters = parameters
                    };

                    return optionInfo0;
                }
                // 1. 检查是否有数据源表ID
                string dsTabId = objViewFeatureFldsENEx.DsTabId;
                if (string.IsNullOrEmpty(dsTabId))
                {
                    return null;
                }

                // 2. 获取数据源表对象
                var objDsTab = clsPrjTabBL.GetObjByTabIdCache(dsTabId, objViewFeatureFldsENEx.PrjId);
                if (objDsTab == null)
                {
                    Console.WriteLine($"找不到数据源表: {dsTabId}");
                    return null;
                }

                // 3. 获取表的功能模块
                var objFuncModule = objDsTab.ObjFuncModule();
                string moduleName = objFuncModule?.FuncModuleEnName ?? "SysPara";

                // 4. WApi 类名 = 数据源表名
                string wApiClass = objDsTab.TabName;

                optionKey = ToCamelCase(fldName) + "_f";

                // 🔥 关键修复：调用 GetDsFieldNames 获取值字段和文本字段
                var (valueFieldName, textFieldName) = GetDsFieldNames(objViewFeatureFldsENEx);

                // 6. 默认函数名
                string getDdlDataFuncName = $"{wApiClass}_GetArr{wApiClass}";

                string strArrayVariableName = "arr" + wApiClass;
                bool isExtendedClass = false;
                
                // 7. 如果有表功能ID
                string tabFeatureId = objViewFeatureFldsENEx.TabFeatureId4Ddl;
                if (!string.IsNullOrEmpty(tabFeatureId))
                {
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(tabFeatureId, objViewFeatureFldsENEx.PrjId);
                    if (objTabFeature != null && objTabFeature.IsForTypeScript)
                    {
                        isExtendedClass = objTabFeature.IsExtendedClass;

                        // 获取函数名
                        
                        if (string.IsNullOrEmpty(objTabFeature.GetDdlDataFuncName4Ex))
                        {
                            var strConditionFieldName = clsTabFeatureBLEx.GetConditionFieldNameByTabFeatureId(tabFeatureId, objViewFeatureFldsENEx.PrjId);

                            if (string.IsNullOrEmpty(strConditionFieldName))
                            {
                                getDdlDataFuncName = $"{wApiClass}_{objTabFeature.GetDdlDataFuncName4Ex}";
                            }
                            else
                            {
                                getDdlDataFuncName = $"{wApiClass}_GetArr{wApiClass}By{strConditionFieldName}";
                            }
                            objTabFeature.GetDdlDataFuncName4Ex = getDdlDataFuncName;
                            objTabFeature.Update();
                        }
                       
                        // 获取参数（从查询字段的 VarIdCond1, VarIdCond2）
                        parameters = GetFunctionParameters(objViewFeatureFldsENEx, objTabFeature, objViewFeatureFldsENEx.PrjId);
                    }
                }

                // 8. 生成选项键（转为驼峰命名）
                optionKey = ToCamelCase(fldName) + "_f";

                // 9. 构建 DdlOptionsInfo 对象
                var optionInfo = new DdlOptionsInfo
                {
                    FldId = objViewFeatureFldsENEx.ReleFldId,
                    Key = optionKey,
                    IsNumberType = objViewFeatureFldsENEx.IsNumberType(),
                    OptionsKey = optionKey,
                    ControlType = "select",
                    ValueFieldName = valueFieldName,
                    TextFieldName = textFieldName,
                    AuxControlId = objViewFeatureFldsENEx.CtrlId,
                    AuxControlOptionsKey = optionKey,
                    AuxControlType = "select",
                    AuxControlLabel = objViewFeatureFldsENEx.LabelCaption,
                    WApiClass = wApiClass,
                    ModuleName = moduleName,
                    ArrayVariableName = strArrayVariableName,
                    GetDdlDataFuncName = getDdlDataFuncName,
                    IsExtendedClass = isExtendedClass,
                    WApiPath = isExtendedClass ? "L3ForWApiEx" : "L3ForWApi",
                    WApiFileName = isExtendedClass
                        ? $"cls{wApiClass}ExWApi"
                        : $"cls{wApiClass}WApi",
                    Parameters = parameters
                };

                return optionInfo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取选项信息失败: {ex.Message}\n{ex.StackTrace}");
                return null;
            }
        }

        /// <summary>
        /// 从查询字段的条件变量获取参数信息
        /// </summary>
        private static List<DdlOptionParam> GetFunctionParameters(clsViewFeatureFldsENEx fld, clsTabFeatureEN objTabFeature, string strPrjId)
        {
            var parameters = new List<DdlOptionParam>();

            try
            {
                // 从查询字段的条件变量字段获取参数
                var conditionVarIds = new List<(string VarId, int Order, string FldId)>();

                // 检查 VarIdCond1
                if (!string.IsNullOrEmpty(fld.VarIdCond1))
                {
                    conditionVarIds.Add((fld.VarIdCond1, 1, fld.FldIdCond1));
                }

                // 检查 VarIdCond2
                if (!string.IsNullOrEmpty(fld.VarIdCond2))
                {
                    conditionVarIds.Add((fld.VarIdCond2, 2, fld.FldIdCond2));
                }

                if (conditionVarIds.Count == 0)
                {
                    return parameters;
                }

                // 按顺序处理每个条件变量
                foreach (var (varId, order, fldId) in conditionVarIds.OrderBy(x => x.Order))
                {
                    try
                    {
                        // 从 GCVariable 获取变量对象
                        var objVariable = clsGCVariableBLEx.GetObjByVarIdCache(varId);
                        if (objVariable != null)
                        {
                            // 构建共享变量名：去掉 "str" 前缀，加上 "_Static" 后缀
                            string sharedVarName = objVariable.VarName;

                            // 去掉 "str" 前缀（如果有且后面是大写字母）
                            if (sharedVarName.StartsWith("str") && sharedVarName.Length > 3 && char.IsUpper(sharedVarName[3]))
                            {
                                sharedVarName = sharedVarName.Substring(3);
                            }

                            // 添加 "_Static" 后缀（如果还没有）
                            if (!sharedVarName.EndsWith("_Static"))
                            {
                                sharedVarName = sharedVarName + "_Static";
                            }

                            // 获取字段名（用于生成参数名）
                            string paramName = null;
                            if (!string.IsNullOrEmpty(fldId))
                            {
                                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(fldId, strPrjId);
                                if (objFieldTab != null)
                                {
                                    paramName = ToCamelCase(objFieldTab.FldName);
                                }
                            }

                            // 构建参数信息
                            var param = new DdlOptionParam
                            {
                                ParamName = paramName ?? ToCamelCase(objVariable.VarName),
                                SharedVarName = sharedVarName,
                                FldId = fldId,
                                VarId = varId
                            };

                            parameters.Add(param);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"处理条件变量失败: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取函数参数失败: {ex.Message}\n{ex.StackTrace}");
            }

            return parameters;
        }
        /// <summary>
        /// 🔥 修正：获取数据源的值字段名和文本字段名
        /// 从 QryRegionFlds.TabFeatureId4Ddl → TabFeature → TabFeatureFlds 中获取
        /// </summary>
        private static (string ValueFieldName, string TextFieldName) GetDsFieldNames(clsViewFeatureFldsENEx field)
        {
            try
            {
                // 如果是布尔类型的下拉框，返回固定值
                if (field.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                {
                    return ("value", "text");
                }

                if (!IsSelectControl(field))
                {
                    return (null, null);
                }

                // 🔥 核心逻辑：通过 TabFeatureId4Ddl 直接找到 TabFeature
                if (string.IsNullOrEmpty(field.TabFeatureId4Ddl))
                {
                    Console.WriteLine($"  ⚠️ 字段 {field.ObjFieldTabENEx.FldName} 未配置 TabFeatureId4Ddl");
                    return GetDefaultFieldNames(field);
                }

                // 1. 获取 TabFeature 对象（不需要通过名称查找，直接通过ID获取）
                var tabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(field.TabFeatureId4Ddl, field.PrjId);
                if (tabFeature == null)
                {
                    Console.WriteLine($"  ⚠️ 未找到 TabFeatureId: {field.TabFeatureId4Ddl}");
                    return GetDefaultFieldNames(field);
                }

                // 2. 获取该 TabFeature 的字段配置
                var arrTabFeatureFlds = clsTabFeatureFldsBL.GetObjLstCache(field.PrjId)
                    .Where(x => x.TabFeatureId == field.TabFeatureId4Ddl)
                    .ToList();

                if (arrTabFeatureFlds == null || arrTabFeatureFlds.Count == 0)
                {
                    Console.WriteLine($"  ⚠️ TabFeature {tabFeature.TabFeatureName} 未配置字段");
                    return GetDefaultFieldNames(field);
                }

                // 3. 查找值字段（KeyField_01）和文本字段（TextField_02）
                var valueFieldConfig = arrTabFeatureFlds.FirstOrDefault(x => x.FieldTypeId == enumFieldType.KeyField_02);
                var textFieldConfig = arrTabFeatureFlds.FirstOrDefault(x => x.FieldTypeId == enumFieldType.NameField_03);

                if (valueFieldConfig == null || textFieldConfig == null)
                {
                    Console.WriteLine($"  ⚠️ TabFeatureFlds 中未找到值字段或文本字段配置");
                    Console.WriteLine($"     TabFeature: {tabFeature.TabFeatureName}");
                    Console.WriteLine($"     TabFeatureFlds 数量: {arrTabFeatureFlds.Count}");
                    Console.WriteLine($"     valueFieldConfig: {valueFieldConfig != null}");
                    Console.WriteLine($"     textFieldConfig: {textFieldConfig != null}");
                    return GetDefaultFieldNames(field);
                }

                // 4. 获取字段对象
                var valueFieldObj = clsFieldTabBL.GetObjByFldIdCache(valueFieldConfig.FldId, field.PrjId);
                var textFieldObj = clsFieldTabBL.GetObjByFldIdCache(textFieldConfig.FldId, field.PrjId);

                if (valueFieldObj == null || textFieldObj == null)
                {
                    Console.WriteLine($"  ⚠️ 字段对象获取失败");
                    Console.WriteLine($"     valueFieldObj: {valueFieldObj != null} (FldId: {valueFieldConfig.FldId})");
                    Console.WriteLine($"     textFieldObj: {textFieldObj != null} (FldId: {textFieldConfig.FldId})");
                    return GetDefaultFieldNames(field);
                }

                // 5. 转换为 camelCase
                string valueFieldName = ToCamelCase(valueFieldObj.FldName);
                string textFieldName = ToCamelCase(textFieldObj.FldName);

                Console.WriteLine($"  ✅ 下拉框字段: {field.ObjFieldTabENEx.FldName}");
                Console.WriteLine($"     TabFeature: {tabFeature.TabFeatureName} (ID: {field.TabFeatureId4Ddl})");
                Console.WriteLine($"     数据源表: {field.DsTabId}");
                Console.WriteLine($"     值字段: {valueFieldName} (来源: {valueFieldObj.FldName})");
                Console.WriteLine($"     文本字段: {textFieldName} (来源: {textFieldObj.FldName})");

                return (valueFieldName, textFieldName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  ❌ 获取数据源字段名失败: {ex.Message}");
                Console.WriteLine($"  堆栈跟踪: {ex.StackTrace}");
                return GetDefaultFieldNames(field);
            }
        }
        /// <summary>
        /// 🔥 新增：获取默认字段名（回退方案）
        /// 例如：FunctionTemplate → functionTemplateId / functionTemplateName
        /// </summary>
        private static (string ValueFieldName, string TextFieldName) GetDefaultFieldNames(clsViewFeatureFldsENEx field)
        {
            var wApiClass = GetOptionsWApiClass(field);
            if (!string.IsNullOrEmpty(wApiClass))
            {
                string defaultValueField = ToCamelCase(wApiClass) + "Id";
                string defaultTextField = ToCamelCase(wApiClass) + "Name";

                Console.WriteLine($"  ⚠️ 使用默认命名: {field.ObjFieldTabENEx.FldName} → {defaultValueField} / {defaultTextField}");

                return (defaultValueField, defaultTextField);
            }

            return (null, null);
        }

        /// <summary>
        /// 🔥 修改：获取选项数据源的 WApi 类名
        /// 需要与 Ai3Query 中的逻辑一致，基于数据源表名
        /// </summary>
        private static string GetOptionsWApiClass(clsViewFeatureFldsENEx field)
        {
            if (!IsSelectControl(field)) return null;
            if (field.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04) return null;
            try
            {
                // 🔥 如果有数据源表ID，使用表名作为 WApi 类名
                if (!string.IsNullOrEmpty(field.DsTabId))
                {
                    var objDsTab = clsPrjTabBL.GetObjByTabIdCache(field.DsTabId, field.PrjId);
                    if (objDsTab != null)
                    {
                        return objDsTab.TabName;  // 返回表名，如 FunctionTemplate, RegionType
                    }
                }

                // 🔥 回退逻辑：从字段名推断
                string fieldName = field.ObjFieldTabENEx.FldName;
                if (fieldName.EndsWith("Id", StringComparison.OrdinalIgnoreCase))
                {
                    fieldName = fieldName.Substring(0, fieldName.Length - 2);
                }
                return char.ToUpper(fieldName[0]) + fieldName.Substring(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取 WApi 类名失败: {ex.Message}");
                return null;
            }
        }
        /// <summary>
        /// 判断查询字段是否为下拉框控件
        /// </summary>
        private static bool IsSelectControl(clsViewFeatureFldsENEx field)
        {
            if (field == null) return false;

            string ctlTypeName = field.ObjCtlType?.CtlTypeENName?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(ctlTypeName)) return false;

            ctlTypeName = ctlTypeName.ToLowerInvariant();

            return ctlTypeName == "select"
                || ctlTypeName == "ddl"
                || ctlTypeName == "dropdownlist"
                || ctlTypeName == "combobox"
                || ctlTypeName == "combo";
        }
        /// <summary>
        /// 将字符串转换为驼峰命名（首字母小写）
        /// </summary>
        private static string ToCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            // 首字母转小写
            return char.ToLower(str[0]) + str.Substring(1);
        }
    }
}