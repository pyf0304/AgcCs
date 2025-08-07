
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AGC.BusinessLogicEx
{
    public static class clsTabFeatureFldsBLEx_Static
    {
        
        public static string PrivFuncName(this clsTabFeatureFldsEN objTabFeatureFlds)
        {
            if (objTabFeatureFlds.ObjFieldTab() == null) return "";
            return objTabFeatureFlds.ObjFieldTab().PrivFuncName1();
        }
        public static string FldName(this clsTabFeatureFldsEN objTabFeatureFlds)
        {
            return objTabFeatureFlds.ObjFieldTab().FldName;
        }

        public static string CsType(this clsTabFeatureFldsEN objTabFeatureFlds)
        {
            if (objTabFeatureFlds.ObjFieldTab() == null) return "";
            return objTabFeatureFlds.ObjFieldTab().ObjDataTypeAbbr1().CsType;
        }
        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
        /// </summary>
        /// <param name = "objTabFeatureFlds">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx(this clsTabFeatureFldsEN objTabFeatureFlds)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsTabFeatureFldsEN objTabFeatureFlds_Cond = new clsTabFeatureFldsEN();
            string strCondition = objTabFeatureFlds_Cond
            .SetFieldTypeId(objTabFeatureFlds.FieldTypeId, "=")
            .SetTabFeatureId(objTabFeatureFlds.TabFeatureId, "=")
            .SetFldId(objTabFeatureFlds.FldId, "=")
            .GetCombineCondition();
            objTabFeatureFlds._IsCheckProperty = true;
            bool bolIsExist = clsTabFeatureFldsBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objTabFeatureFlds.mId = clsTabFeatureFldsBL.GetFirstID_S(strCondition);
                objTabFeatureFlds.UpdateWithCondition(strCondition);
            }
            else
            {
                objTabFeatureFlds.AddNewRecord();
            }
            return true;
        }
        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objFieldTabEN"></param>
        /// <returns></returns>
        public static string PropertyName(this clsTabFeatureFldsENEx objTabFeatureFldsEx, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objTabFeatureFldsEx.ObjFieldTabENEx.FldName;
            }
            else
            {
                return clsString.FstLcaseS(objTabFeatureFldsEx.ObjFieldTabENEx.FldName);
            }
        }
        //public static Func<T2, R> Apply<T1, T2, R>
        //    (this Func<T1, T2, R> f, T1 t1)
        //    => t2 => f(t1, t2);

        //public static Func<T2, T3, R> Apply<T1, T2, T3, R>
        //    (this Func<T1, T2, T3, R> f, T1 t1)
        //    => (t2,t3) => f(t1, t2, t3);

        //public static Func<T2, T3, T4, R> Apply<T1, T2, T3, T4, R>
        //    (this Func<T1, T2, T3, T4, R> f, T1 t1)
        //    => (t2, t3, t4) => f(t1, t2, t3,t4);


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objTabFeatureFldsENS">源对象</param>
        /// <returns>目标对象=>clsTabFeatureFldsEN:objTabFeatureFldsENT</returns>
        public static clsTabFeatureFldsENEx CopyToEx(this clsTabFeatureFldsEN objTabFeatureFldsENS)
        {
            try
            {
                clsTabFeatureFldsENEx objTabFeatureFldsENT = new clsTabFeatureFldsENEx();
                clsTabFeatureFldsBL.CopyTo(objTabFeatureFldsENS, objTabFeatureFldsENT);
                return objTabFeatureFldsENT;
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
        /// <param name = "objTabFeatureFldsENS">源对象</param>
        /// <returns>目标对象=>clsTabFeatureFldsEN:objTabFeatureFldsENT</returns>
        public static clsTabFeatureFldsEN CopyTo(this clsTabFeatureFldsENEx objTabFeatureFldsENS)
        {
            try
            {
                clsTabFeatureFldsEN objTabFeatureFldsENT = new clsTabFeatureFldsEN();
                clsTabFeatureFldsBL.CopyTo(objTabFeatureFldsENS, objTabFeatureFldsENT);
                return objTabFeatureFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static clsFieldTabEN ObjFieldTab(this clsTabFeatureFldsEN objTabFeatureFlds)
        {
            try
            {
                if (string.IsNullOrEmpty(objTabFeatureFlds.FldId) == true) return null;
                clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objTabFeatureFlds.FldId, objTabFeatureFlds.PrjId);
                if (objFieldTab == null)
                {
                    string strMsg = string.Format("工程Id:[{0}], 字段Id:[{1}]查找的字段为空，请检查.({2})",
          objTabFeatureFlds.PrjId, objTabFeatureFlds.FldId,     clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表功能字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsFieldTabENEx ObjFieldTabEx(this clsTabFeatureFldsENEx objTabFeatureFldsENS)
        {
            try
            {
                clsFieldTabENEx objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objTabFeatureFldsENS.FldId, objTabFeatureFldsENS.PrjId);
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表功能字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 表功能字段(TabFeatureFlds)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsTabFeatureFldsBLEx : clsTabFeatureFldsBL
    {
        public static string FldName(clsTabFeatureFldsEN objTabFeatureFlds)
        {
            if (objTabFeatureFlds == null) { return ""; }
            if (objTabFeatureFlds.ObjFieldTab() == null) return "";
            return objTabFeatureFlds.ObjFieldTab().FldName;
        }
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsTabFeatureFldsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsTabFeatureFldsDAEx TabFeatureFldsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsTabFeatureFldsDAEx();
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
        private new static bool DelRecordEx(long lngmId, string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsTabFeatureFldsDA.GetSpecSQLObj();
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
                //删除与表:[TabFeatureFlds]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsTabFeatureFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTabFeatureFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
        public static List<clsTabFeatureFldsENEx> GetObjExLst(string strCondition)
        {
            List<clsTabFeatureFldsEN> arrObjLst = clsTabFeatureFldsBL.GetObjLst(strCondition);
            List<clsTabFeatureFldsENEx> arrObjExLst = new List<clsTabFeatureFldsENEx>();
            foreach (clsTabFeatureFldsEN objInFor in arrObjLst)
            {
                clsTabFeatureFldsENEx objTabFeatureFldsENEx = new clsTabFeatureFldsENEx();
                clsTabFeatureFldsBL.CopyTo(objInFor, objTabFeatureFldsENEx);
                arrObjExLst.Add(objTabFeatureFldsENEx);
            }
            return arrObjExLst;
        }


        /// <summary>
        /// 根据strTabFeatureId获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strTabFeatureId">strTabFeatureId</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsTabFeatureFldsENEx> GetObjExLstByTabFeatureId(string strTabFeatureId, string strPrjId)
        {
            IEnumerable<clsTabFeatureFldsEN> arrObjLst = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(strTabFeatureId, strPrjId);
            List<clsTabFeatureFldsENEx> arrObjExLst = new List<clsTabFeatureFldsENEx>();
            foreach (clsTabFeatureFldsEN objInFor in arrObjLst)
            {
                clsTabFeatureFldsENEx objTabFeatureFldsENEx = new clsTabFeatureFldsENEx();
                clsTabFeatureFldsBL.CopyTo(objInFor, objTabFeatureFldsENEx);
                arrObjExLst.Add(objTabFeatureFldsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsTabFeatureFldsENEx GetObjExBymId(long lngmId)
        {
            clsTabFeatureFldsEN objTabFeatureFldsEN = clsTabFeatureFldsBL.GetObjBymId(lngmId);
            clsTabFeatureFldsENEx objTabFeatureFldsENEx = new clsTabFeatureFldsENEx();
            clsTabFeatureFldsBL.CopyTo(objTabFeatureFldsEN, objTabFeatureFldsENEx);
            return objTabFeatureFldsENEx;
        }


        

        public static bool AddBindDdl(string strTabId, string strPrjId, string strUserId)
        {
            List<clsPrjTabFldEN> arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            if (arrPrjTabFld.Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
            {
                throw new Exception("当前表没有名称字段，不能添加绑定下拉框功能！");

            }
            if (arrPrjTabFld.Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
            {
                throw new Exception("当前表没有关键字段，不能添加绑定下拉框功能！");

            }
            clsPrjTabFldEN objField_Key = arrPrjTabFld.Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
            clsPrjTabFldEN objField_Name = arrPrjTabFld.Find(x => x.FieldTypeId == enumFieldType.NameField_03);
            string strFeatureId = enumPrjFeature.Tab_BindDdl_0173;
            string strFieldTypeId = enumFieldType.KeyField_02;

            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
            //var GetTabFeatureFld6 =Apply.

            clsTabFeatureEN objTabFeature = new clsTabFeatureEN();
            objTabFeature.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(strPrjId);

            if (objTabFeature.SetTabId(strTabId)
                .SetTabFeatureName(objPrjFeature.FeatureName)
                .SetFeatureId(strFeatureId)
                .SetPrjId(strPrjId)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strUserId)
                    .SetInUse(true)
                    .SetOrderNum(1)
                    .CheckUniqueness() == true)
            {
                objTabFeature.AddNewRecordEx(strPrjId);
            }



            clsTabFeatureFldsEN obj2 = new clsTabFeatureFldsEN();

            if (obj2.SetTabFeatureId(objTabFeature.TabFeatureId)
                .SetFieldTypeId(strFieldTypeId)
                .SetFldId(objField_Key.FldId)
                   .SetPrjId(strPrjId)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strUserId)
                    .SetInUse(true)
                    .SetOrderNum(1)

                    .CheckUniqueness() == true)
            {
                obj2.AddNewRecord();
            }

            strFieldTypeId = enumFieldType.NameField_03;
            if (obj2.SetTabFeatureId(objTabFeature.TabFeatureId)
                
                .SetFieldTypeId(strFieldTypeId)
                .SetFldId(objField_Name.FldId)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(strUserId)
                .SetInUse(true)
                .CheckUniqueness() == true)
            {
                obj2.AddNewRecord();
            }
            return true;
        }

        public static bool AddAdjustOrderNum(string strTabId, string strFeatureId, string strPrjId, string strUserId)
        {
            List<clsPrjTabFldEN> arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            if (arrPrjTabFld.Exists(x => x.FieldTypeId == enumFieldType.OrderNumField_09) == false)
            {
                throw new Exception("当前表没有序号字段，不能添加调整记录次序功能！");
            }
           
            clsPrjTabFldEN objField_OrderNum = arrPrjTabFld.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09);
            //string strFeatureId = enumPrjFeature.Tab_AdjustOrderNum_0167;
            string strFieldTypeId = enumFieldType.OrderNumField_09;


            //var GetTabFeatureFld6 =Apply.
            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
            //var GetTabFeatureFld6 =Apply.

            clsTabFeatureEN objTabFeature = new clsTabFeatureEN();
            objTabFeature.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(strPrjId);

            if (objTabFeature.SetTabId(strTabId)
                .SetTabFeatureName(objPrjFeature.FeatureName)
                .SetFeatureId(strFeatureId)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strUserId)
                    .SetPrjId(strPrjId)
                    .SetInUse(true)
                    .SetOrderNum(1)
                    .CheckUniqueness() == true)
            {
                objTabFeature.AddNewRecordEx(strPrjId);
            }


            clsTabFeatureFldsEN obj2 = new clsTabFeatureFldsEN();

            if (obj2.SetTabFeatureId(objTabFeature.TabFeatureId)
                .SetFieldTypeId(strFieldTypeId)
                .SetFldId(objField_OrderNum.FldId)
                .SetPrjId(strPrjId)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strUserId)
                    .SetInUse(true)
                    .SetOrderNum(objPrjFeature.OrderNum)
                    .CheckUniqueness() == true)
            {
                obj2.AddNewRecord();
            }
            if (arrPrjTabFld.Exists(x => x.FieldTypeId == enumFieldType.ClassificationField_10) == false)
            {
                return true;
            }
            clsPrjTabFldEN objField_ClassificationField = arrPrjTabFld.Find(x => x.FieldTypeId == enumFieldType.ClassificationField_10);

            strFieldTypeId = enumFieldType.ClassificationField_10;
                        
            if (obj2.SetTabFeatureId(objTabFeature.TabFeatureId)
                .SetFieldTypeId(strFieldTypeId)
                .SetFldId(objField_ClassificationField.FldId)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(strUserId)
                .SetInUse(true)
                .SetOrderNum(objPrjFeature.OrderNum)
                .CheckUniqueness() == true)
            {
                obj2.AddNewRecord();
            }
            return true;
        }

        public static void CopyToSubFeature(clsTabFeatureFldsEN objTabFeatureFldsEN)
        {
            //clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetObjByTabFeatureId(objTabFeatureFldsEN.TabFeatureId);
            //clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(objTabFeature.FeatureId);
            //List<string> arrSubFeatureId = clsPrjFeatureBLEx.GetSubFeatureIdLstByFeatureId(objPrjFeature.FeatureId);
            List<clsTabFeatureEN> arrSubTabFeature = clsTabFeatureBLEx.GetSubTabFeatureLst(objTabFeatureFldsEN.TabFeatureId);
            if (arrSubTabFeature == null || arrSubTabFeature.Count == 0) return;
            foreach(clsTabFeatureEN objInFor in arrSubTabFeature)
            {
                objTabFeatureFldsEN.TabFeatureId = objInFor.TabFeatureId;
                
                string strCondition = objTabFeatureFldsEN.GetUniCondStr();
                if (clsTabFeatureFldsBL.IsExistRecord(strCondition) == true)
                {
                    clsTabFeatureFldsEN objTabFeatureFldsEN_New = clsTabFeatureFldsBL.GetFirstObj_S(strCondition);
                    objTabFeatureFldsEN.mId = objTabFeatureFldsEN_New.mId;
                    objTabFeatureFldsEN.Update();
                }
                else
                {
                    objTabFeatureFldsEN.AddNewRecord();
                }
            }
//            throw new NotImplementedException();
        }

  
        public static clsTabFeatureFldsEN GetObjByViewFeatureFlds(clsViewFeatureFldsENEx objViewFeatureFldsEx)
        {
            clsTabFeatureFldsEN objTabFeatureFlds = new clsTabFeatureFldsEN();

            objTabFeatureFlds.FldId = objViewFeatureFldsEx.ReleFldId;
            objTabFeatureFlds.FieldTypeId = objViewFeatureFldsEx.FieldTypeId;
            //objTabFeatureFlds.ViewFeatureId = strViewFeatureId;
            //objTabFeatureFlds.LabelCaption = objViewFeatureFldsEx.Caption;
           
            objTabFeatureFlds.UpdDate = clsDateTime.getTodayStr(0);
            //objTabFeatureFlds.UpdUser = strUserId;
            objTabFeatureFlds.InUse = true;
            //5、检查传进去的对象属性是否合法


            return objTabFeatureFlds;


            //            throw new NotImplementedException();
        }
        internal static clsTabFeatureFldsEN GetObjByFeatureRegionFlds(clsFeatureRegionFldsEN objFeatureRegionFlds)
        {
            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFlds.FeatureId);
            string strFeatureId4Tab = clsPrjFeatureBLEx.GetRelaFeatureId4Tab(objFeatureRegionFlds.ViewFeatureId);

            if (string.IsNullOrEmpty(strFeatureId4Tab) == true) return null;
            clsTabFeatureFldsEN objTabFeature = new clsTabFeatureFldsEN()
            {
                FldId = objFeatureRegionFlds.ReleFldId,
                FieldTypeId=objFeatureRegionFlds.FieldTypeId,
                InUse = true,
                UpdDate = clsDateTime.getTodayDateTimeStr(1)
            };
            return objTabFeature;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.      
        /// </summary>
        /// <param name = "strTabFeatureId">strTabFeatureId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsTabFeatureFldsEN> GetObjLstByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
        {
            //初始化列表缓存
            List<clsTabFeatureFldsEN> arrObjLstCache = clsTabFeatureFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsTabFeatureFldsEN> arrTabFeatureFldsObjLst_Sel = arrObjLstCache
                                    .Where(x => x.TabFeatureId == strTabFeatureId);
           
            return arrTabFeatureFldsObjLst_Sel.ToList();
        }

        public static int GetRecNumByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
        {            
            List<clsTabFeatureFldsEN> arrObjLstCache = clsTabFeatureFldsBL.GetObjLstCache(strPrjId);
            IEnumerable<clsTabFeatureFldsEN> arrObjLst_Sel = arrObjLstCache.Where(x => x.TabFeatureId == strTabFeatureId);
            return arrObjLst_Sel.Count();
        }
    }
}