
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsTabFeatureBLEx
表名:TabFeature(00050463)
生成代码版本:2019.05.09.1
生成日期:2019/05/09 23:11:18
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
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
using LaYumba.Functional;
using AGC.PureClassEx;
using AgcCommBase;

namespace AGC.BusinessLogicEx
{
    public static class clsTabFeatureBLEx_Static
    {

        public static List<string> GetCondFldIdLst(this clsTabFeatureEN objTabFeature)
        {
            var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objTabFeature.PrjId).ToList();
            var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
            var arrFldId = arrTabFeatureFlds_Cond.Select(x => x.FldId).ToList();
            return arrFldId;
        }

        public static List<clsTabFeatureFldsEN> arrTabFeatureFldsSet(this clsTabFeatureEN objTabFeature)
        {
            var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objTabFeature.PrjId).ToList();
            return arrTabFeatureFlds;
        }
        public static List<clsTabFeatureFldsENEx> arrTabFeatureFldsSetEx(this clsTabFeatureEN objTabFeature)
        {
            var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objTabFeature.PrjId).ToList();
            var arrTabFeatureFldsEx = arrTabFeatureFlds.Select(x => x.CopyToEx()).ToList();
            foreach (var objInFor in arrTabFeatureFldsEx)
            {
                var obj = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objTabFeature.TabId, objInFor.FldId, objInFor.PrjId);
                if (obj == null) objInFor.IsForExtendClass = true;
                else objInFor.IsForExtendClass = obj.IsForExtendClass;
            }
            return arrTabFeatureFldsEx;
        }


        public static bool AddNewRecordEx(this clsTabFeatureEN objTabFeatureEN, string strPrjId, string strUpdUser = "")
        {
            //IEnumerable<string> arrFldId = null;
            IEnumerable<clsTabFeatureFldsEN> arrTabFeatureFlds = null;
            IEnumerable<clsPrjTabFldEN> arrPrjTabFlds = null;
            Func<string, string, clsTabFeatureFldsEN> GetTabFeatureFld1 =
          (strTabFeatureId1, strFldId1)
              => new clsTabFeatureFldsEN()
              {
                  TabFeatureId = strTabFeatureId1,
                  FldId = strFldId1,
                  //FieldTypeId = strFieldTypeId1,
              };

            Func<string, string, clsPrjTabFldEN> GetPrjTabFld1 =
          (strTabId1, strFldId1)
              => new clsPrjTabFldEN()
              {
                  TabId = strTabId1,
                  FldId = strFldId1,
                  //FieldTypeId = strFieldTypeId1,
              };

            try
            {
                if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true || clsTabFeatureBL.IsExist(objTabFeatureEN.TabFeatureId) == true)
                {
                    objTabFeatureEN.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(strPrjId);
                }
                bool bolResult = clsTabFeatureBL.TabFeatureDA.AddNewRecordBySQL2(objTabFeatureEN);
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);
                switch (objTabFeatureEN.FeatureId)
                {
                    case enumPrjFeature.Tab_DelRecordBySign_0168:
                    case enumPrjFeature.Tab_UnDelRecordBySign_0169:
                        string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conFieldTab.FieldTypeId, enumFieldType.DelSignField_12,
                      conFieldTab.PrjId, strPrjId);
                        IEnumerable<clsFieldTabEN> arrObjLst = clsFieldTabBL.GetObjLst(strCondition);

                        //arrFldId = arrObjLst.Select(x => x.FldId);
                        var GetTabFeatureFld2 = GetTabFeatureFld1.Apply(objTabFeatureEN.TabFeatureId);

                        arrTabFeatureFlds = arrObjLst
                            .Select(x => x.FldId)
                            .Select(GetTabFeatureFld2)
                            .Where(x => x.CheckUniqueness() == true);
                        foreach (clsTabFeatureFldsEN objInFor in arrTabFeatureFlds)
                        {
                            objInFor
                                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                                .SetUpdUser(strUpdUser)
                                .SetInUse(true)
                                .SetFieldTypeId(enumFieldType.DelSignField_12)
                                .AddNewRecord();
                        }

                        var GetPrjTabFld2 = GetPrjTabFld1.Apply(objTabFeatureEN.TabId);

                        arrPrjTabFlds = arrObjLst
                            .Select(x => x.FldId)
                            .Select(GetPrjTabFld2)
                            .Where(x => x.CheckUniqueness() == true);
                        foreach (clsPrjTabFldEN objInFor in arrPrjTabFlds)
                        {
                            objInFor
                                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                                .SetUpdUser(strUpdUser)
                                .SetPrjId(strPrjId)
                                .SetIsTabNullable(true)
                                .SetSequenceNumber(100)
                                .SetFldOpTypeId(enumFldOperationType.ReadWrite_0001)
                                .SetPrimaryTypeId(enumPrimaryType.NonPrimaryKey_00)
                                .SetFieldTypeId(enumFieldType.DelSignField_12)
                                .AddNewRecord();
                        }

                        break;
                }
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objTabFeatureENS">源对象</param>
        /// <returns>目标对象=>clsTabFeatureEN:objTabFeatureENT</returns>
        public static clsTabFeatureENEx CopyToEx(this clsTabFeatureEN objTabFeatureENS)
        {
            try
            {
                clsTabFeatureENEx objTabFeatureENT = new clsTabFeatureENEx();
                clsTabFeatureBL.CopyTo(objTabFeatureENS, objTabFeatureENT);
                return objTabFeatureENT;
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
        /// <param name = "objTabFeatureENS">源对象</param>
        /// <returns>目标对象=>clsTabFeatureEN:objTabFeatureENT</returns>
        public static clsTabFeatureEN CopyTo(this clsTabFeatureENEx objTabFeatureENS)
        {
            try
            {
                clsTabFeatureEN objTabFeatureENT = new clsTabFeatureEN();
                clsTabFeatureBL.CopyTo(objTabFeatureENS, objTabFeatureENT);
                return objTabFeatureENT;
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
    /// 表功能(TabFeature)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsTabFeatureBLEx : clsTabFeatureBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsTabFeatureDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsTabFeatureDAEx TabFeatureDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsTabFeatureDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strTabFeatureId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strTabFeatureId, string strPrjId)
        {
            if (IsExistParentFeature(strTabFeatureId) == true)
            {
                string strMsg = "该功能有父功能，请先删除父功能后，再删除该功能！";
                throw new Exception(strMsg);
            }

            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
                //删除与表:[TabFeature]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'", conTabFeature.TabFeatureId,
                    strTabFeatureId);
                clsTabFeatureFldsBL.DelTabFeatureFldssByCondWithTransaction_S(strCondition, strPrjId, objConnection, objSqlTransaction);

                clsTabFeatureBL.DelRecord(strTabFeatureId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTabFeatureBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strTabFeatureId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clsTabFeatureENEx> GetObjExLst(string strCondition)
        {
            List<clsTabFeatureEN> arrObjLst = clsTabFeatureBL.GetObjLst(strCondition);
            List<clsTabFeatureENEx> arrObjExLst = new List<clsTabFeatureENEx>();
            foreach (clsTabFeatureEN objInFor in arrObjLst)
            {
                clsTabFeatureENEx objTabFeatureENEx = new clsTabFeatureENEx();
                clsTabFeatureBL.CopyTo(objInFor, objTabFeatureENEx);
                arrObjExLst.Add(objTabFeatureENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.        
        /// </summary>
        /// <param name = "strTabFeatureId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsTabFeatureENEx GetObjExByTabFeatureId(string strTabFeatureId)
        {
            clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
            clsTabFeatureENEx objTabFeatureENEx = new clsTabFeatureENEx();
            clsTabFeatureBL.CopyTo(objTabFeatureEN, objTabFeatureENEx);
            //objTabFeatureENEx.arrTabFeatureFldsSet() = clsTabFeatureFldsBLEx.GetObjExLstByTabFeatureId(strTabFeatureId, objTabFeatureEN.PrjId);
            return objTabFeatureENEx;
        }

        public static clsTabFeatureENEx4Ddl GetObjEx4DdlByTabFeatureId(string strTabFeatureId, string strPrjId, bool bolIsFstLcase)
        {
            clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureIdCache(strTabFeatureId,strPrjId);
            if (objTabFeatureEN == null) return null;

            clsPrjTabENEx objPrjTabENEx = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeatureEN.TabId, objTabFeatureEN.PrjId);
            return GetObjEx4DdlByTabFeatureId(objTabFeatureEN, bolIsFstLcase, objPrjTabENEx);

        }

        public static clsTabFeatureENEx4Ddl GetObjEx4DdlByTabFeatureId4View(string strTabFeatureId, string strPrjId, bool bolIsFstLcase, string strViewId)
        {
            clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureIdCache(strTabFeatureId, strPrjId);
            if (objTabFeatureEN == null) return null;

            clsPrjTabENEx objPrjTabENEx = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeatureEN.TabId, objTabFeatureEN.PrjId);
            return GetObjEx4DdlByTabFeatureId4View(objTabFeatureEN, bolIsFstLcase, objPrjTabENEx, strViewId);

        }


        public static clsTabFeatureENEx4Ddl GetObjEx4DdlByTabFeatureId(string strTabFeatureId, bool bolIsFstLcase, clsPrjTabENEx objPrjTabENEx)
        {
            clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
            if (objTabFeatureEN == null) return null;

            return GetObjEx4DdlByTabFeatureId(objTabFeatureEN, bolIsFstLcase, objPrjTabENEx);

        }


        public static clsTabFeatureENEx4Ddl GetObjEx4DdlByTabFeatureId4View(string strTabFeatureId, bool bolIsFstLcase, clsPrjTabENEx objPrjTabENEx, string strViewId)
        {
            clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
            if (objTabFeatureEN == null) return null;

            return GetObjEx4DdlByTabFeatureId4View(objTabFeatureEN, bolIsFstLcase, objPrjTabENEx, strViewId);

        }
        public static clsTabFeatureENEx4Ddl GetObjEx4DdlByTabFeatureId(clsTabFeatureEN objTabFeatureEN, bool bolIsFstLcase, 
            clsPrjTabENEx objPrjTabENEx)
        {
            if (objTabFeatureEN == null) return null;

            clsTabFeatureENEx4Ddl objTabFeatureENEx = new clsTabFeatureENEx4Ddl();
            clsTabFeatureBL.CopyTo(objTabFeatureEN, objTabFeatureENEx);
            

            var objFuncModule_Agc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            if (objFuncModule_Agc != null)
            {
                objTabFeatureENEx.FuncModuleEnName = objFuncModule_Agc.FuncModuleEnName;
            }
            List<string> arrCondFldId = objTabFeatureEN.GetCondFldIdLst();
            List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeatureEN.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
            var thisCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx);
            var objFuncParaLst = new FuncParaLst("DdlParaLst", bolIsFstLcase, enumAppLevel.DefindFunc);
            objFuncParaLst.AddParaByTabFeature(objTabFeatureEN, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
            //预检查

            objFuncParaLst.AddParaByTabFeature(objTabFeatureEN, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
            string strFuncPara = objFuncParaLst.GetCondFldLst4Para();
            string strPrivFuncName_Additional = objFuncParaLst.GetCondFldLst();
            //string strCodeText_CheckEmpty = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName,
            //    objTabFeatureEN.FuncNameJs, true, this, this.strBaseUrl);
            objTabFeatureENEx.FuncRemark = objFuncParaLst.GetFuncRemark();

            //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//该表没有使用Cache,不需要生成[{objTabFeatureEN.FuncNameJs}Cache]函数;(in {clsStackTrace.GetCurrClassFunction()} )";
            var strIsCache = "Cache";
            if (objPrjTabENEx.IsUseStorageCache_TS() == false) strIsCache = "";
            string strFuncName_Temp = $"{objTabFeatureEN.FuncNameJs}{strIsCache}";


            objTabFeatureENEx.FuncName_Js_Gc = $"{objPrjTabENEx.TabName}_{strFuncName_Temp}";


            if (objTabFeatureEN.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
            {
                objTabFeatureENEx.ErrMsg_Ddl = "下拉框功能字段没有名称字段！";
                objTabFeatureENEx.IsHasErr = true;
                return objTabFeatureENEx;
                //                        throw new Exception("当前表没有名称字段,不能添加绑定下拉框功能!");
            }
            if (objTabFeatureEN.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
            {
                objTabFeatureENEx.ErrMsg_Ddl = "下拉框功能字段没有关键字段！";
                objTabFeatureENEx.IsHasErr = true;
                return objTabFeatureENEx;
                //                        throw new Exception("当前表没有关键字段,不能添加绑定下拉框功能!");
            }

            clsTabFeatureFldsEN objField_Key = objTabFeatureEN.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
            clsTabFeatureFldsEN objField_Name = objTabFeatureEN.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.NameField_03);
            clsTabFeatureFldsEN objField_Condition = objTabFeatureEN.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.ConditionField_16);
            objTabFeatureENEx.TextFieldName = objField_Name.ObjFieldTab().FldName;
            objTabFeatureENEx.ValueFieldName = objField_Key.ObjFieldTab().FldName;
            if (objField_Condition != null) objTabFeatureENEx.ConditionFieldName = objField_Condition.ObjFieldTab().FldName;
            
            objTabFeatureENEx.IsNumberType = objField_Key.ObjFieldTab().IsNumberType();

            var bolIsForExtendClassFld = clsPrjTabFldBLEx.IsForExtendClassCache(objTabFeatureEN.TabId, objField_Name.FldId, objPrjTabENEx.PrjId);
            objTabFeatureENEx.IsForExtendClassFld = bolIsForExtendClassFld;
            //var strIsForExtendClass = "";
            //if (bolIsForExtendClass == true) strIsForExtendClass = "Ex";
            //第0步:把控件中下拉框ComboBox转换成ComboBox

            if (objTabFeatureENEx.ValueFieldName == "")
            {
                objTabFeatureENEx.ErrMsg_Ddl = "下拉框值字段名为空！";
                objTabFeatureENEx.IsHasErr = true;
                return objTabFeatureENEx;
            }

            if (objTabFeatureENEx.TextFieldName == "")
            {
                objTabFeatureENEx.ErrMsg_Ddl = "下拉框文本字段名为空！";
                objTabFeatureENEx.IsHasErr = true;
                return objTabFeatureENEx;
            }


            objTabFeatureENEx.TabName4GC = objPrjTabENEx.TabName ;
            objTabFeatureENEx.TabCnName4GC = objPrjTabENEx.TabCnName ;

            //生成过滤条件语句
            string strFilterCondition = objFuncParaLst.GeneFilterCondition(objTabFeatureENEx.IsForExtendClassFld);
            objTabFeatureENEx.ConditionStr = objFuncParaLst.GeneConditionStr();
            objTabFeatureENEx.FilterCondition = strFilterCondition;


            var strLetOrConst = "const";
            var strLetOrConst2 = "const";
            if (string.IsNullOrEmpty(strFilterCondition) == false)
            {
                strLetOrConst = "let";
            }
            if (objTabFeatureEN.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
            {
                strLetOrConst = "let";
                strLetOrConst2 = "let";
            }
            objTabFeatureENEx.LetOrConst = strLetOrConst;
            objTabFeatureENEx.LetOrConst2 = strLetOrConst2;

            if (objTabFeatureEN.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
            {
                clsTabFeatureFldsEN objField_Sort = objTabFeatureEN.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                switch (objField_Sort.ObjFieldTab().TypeScriptType())
                {
                    case "string":
                        objTabFeatureENEx.SortStr = $"(x, y) => x.{objField_Sort.ObjFieldTab().PropertyName(bolIsFstLcase)}.localeCompare(y.{objField_Sort.ObjFieldTab().PropertyName(bolIsFstLcase)})";
                        break;
                    case "number":
                    case "boolean":
                        objTabFeatureENEx.SortStr = $"(x, y) => x.{objField_Sort.ObjFieldTab().PropertyName(bolIsFstLcase)} - y.{objField_Sort.ObjFieldTab().PropertyName(bolIsFstLcase)}";
                        break;
                }
            }

            return objTabFeatureENEx;
        }


        public static clsTabFeatureENEx4Ddl GetObjEx4DdlByTabFeatureId4View(clsTabFeatureEN objTabFeatureEN, bool bolIsFstLcase,
          clsPrjTabENEx objPrjTabENEx, string strViewId)
        {
            if (objTabFeatureEN == null) return null;

            clsTabFeatureENEx4Ddl objTabFeatureENEx = new clsTabFeatureENEx4Ddl();
            clsTabFeatureBL.CopyTo(objTabFeatureEN, objTabFeatureENEx);


            var objFuncModule_Agc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            if (objFuncModule_Agc != null)
            {
                objTabFeatureENEx.FuncModuleEnName = objFuncModule_Agc.FuncModuleEnName;
            }
            List<string> arrCondFldId = objTabFeatureEN.GetCondFldIdLst();
            List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeatureEN.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
            //var thisCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx);
            var objFuncParaLst = new FuncParaLst("DdlParaLst", bolIsFstLcase, enumAppLevel.DefindFunc);
            objFuncParaLst.AddParaByTabFeature(objTabFeatureEN, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
            //预检查

            objFuncParaLst.AddParaByTabFeature(objTabFeatureEN, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
            //try
            //{
            //    objFuncParaLst.AddParaByCacheClassify4View(thisCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, strViewId, objPrjTabENEx.PrjId);
            //}
            //catch(Exception objException)
            //{
            //    string strTabName_TabFeature = clsPrjTabBL.GetNameByTabIdCache(objTabFeatureEN.TabId, objPrjTabENEx.PrjId);
            //    string strMsg = $"在获取下拉框功能扩展对象时(表:[{strTabName_TabFeature}]-功能:{objTabFeatureEN.TabFeatureName})出错:{objException.Message}";
            //    throw new Exception(strMsg);
            //}
            string strFuncPara = objFuncParaLst.GetCondFldLst4Para();
            string strPrivFuncName_Additional = objFuncParaLst.GetCondFldLst();
            //string strCodeText_CheckEmpty = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName,
            //    objTabFeatureEN.FuncNameJs, true, this, this.strBaseUrl);
            objTabFeatureENEx.FuncRemark = objFuncParaLst.GetFuncRemark();

            //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//该表没有使用Cache,不需要生成[{objTabFeatureEN.FuncNameJs}Cache]函数;(in {clsStackTrace.GetCurrClassFunction()} )";
            var strIsCache = "Cache";
            if (objPrjTabENEx.IsUseStorageCache_TS() == false) strIsCache = "";
            string strFuncName_Temp = $"{objTabFeatureEN.FuncNameJs}{strIsCache}";


            objTabFeatureENEx.FuncName_Js_Gc = $"{objPrjTabENEx.TabName}_{strFuncName_Temp}";


            if (objTabFeatureEN.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
            {
                objTabFeatureENEx.ErrMsg_Ddl = "下拉框功能字段没有名称字段！";
                objTabFeatureENEx.IsHasErr = true;
                return objTabFeatureENEx;
                //                        throw new Exception("当前表没有名称字段,不能添加绑定下拉框功能!");
            }
            if (objTabFeatureEN.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
            {
                objTabFeatureENEx.ErrMsg_Ddl = "下拉框功能字段没有关键字段！";
                objTabFeatureENEx.IsHasErr = true;
                return objTabFeatureENEx;
                //                        throw new Exception("当前表没有关键字段,不能添加绑定下拉框功能!");
            }

            clsTabFeatureFldsEN objField_Key = objTabFeatureEN.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
            clsTabFeatureFldsEN objField_Name = objTabFeatureEN.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.NameField_03);
            clsTabFeatureFldsEN objField_Condition = objTabFeatureEN.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.ConditionField_16);
            objTabFeatureENEx.TextFieldName = objField_Name.ObjFieldTab().FldName;
            objTabFeatureENEx.ValueFieldName = objField_Key.ObjFieldTab().FldName;
            if (objField_Condition != null) objTabFeatureENEx.ConditionFieldName = objField_Condition.ObjFieldTab().FldName;

            objTabFeatureENEx.IsNumberType = objField_Key.ObjFieldTab().IsNumberType();

            var bolIsForExtendClassFld = clsPrjTabFldBLEx.IsForExtendClassCache(objTabFeatureEN.TabId, objField_Name.FldId, objPrjTabENEx.PrjId);
            objTabFeatureENEx.IsForExtendClassFld = bolIsForExtendClassFld;
            //var strIsForExtendClass = "";
            //if (bolIsForExtendClass == true) strIsForExtendClass = "Ex";
            //第0步:把控件中下拉框ComboBox转换成ComboBox

            if (objTabFeatureENEx.ValueFieldName == "")
            {
                objTabFeatureENEx.ErrMsg_Ddl = "下拉框值字段名为空！";
                objTabFeatureENEx.IsHasErr = true;
                return objTabFeatureENEx;
            }

            if (objTabFeatureENEx.TextFieldName == "")
            {
                objTabFeatureENEx.ErrMsg_Ddl = "下拉框文本字段名为空！";
                objTabFeatureENEx.IsHasErr = true;
                return objTabFeatureENEx;
            }


            objTabFeatureENEx.TabName4GC = objPrjTabENEx.TabName;
            objTabFeatureENEx.TabCnName4GC = objPrjTabENEx.TabCnName;

            //生成过滤条件语句
            string strFilterCondition = objFuncParaLst.GeneFilterCondition(objTabFeatureENEx.IsForExtendClassFld);
            objTabFeatureENEx.ConditionStr = objFuncParaLst.GeneConditionStr();
            objTabFeatureENEx.FilterCondition = strFilterCondition;


            var strLetOrConst = "const";
            var strLetOrConst2 = "const";
            if (string.IsNullOrEmpty(strFilterCondition) == false)
            {
                strLetOrConst = "let";
            }
            if (objTabFeatureEN.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
            {
                strLetOrConst = "let";
                strLetOrConst2 = "let";
            }
            objTabFeatureENEx.LetOrConst = strLetOrConst;
            objTabFeatureENEx.LetOrConst2 = strLetOrConst2;

            if (objTabFeatureEN.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
            {
                clsTabFeatureFldsEN objField_Sort = objTabFeatureEN.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                switch (objField_Sort.ObjFieldTab().TypeScriptType())
                {
                    case "string":
                        objTabFeatureENEx.SortStr = $"(x, y) => x.{objField_Sort.ObjFieldTab().PropertyName(bolIsFstLcase)}.localeCompare(y.{objField_Sort.ObjFieldTab().PropertyName(bolIsFstLcase)})";
                        break;
                    case "number":
                    case "boolean":
                        objTabFeatureENEx.SortStr = $"(x, y) => x.{objField_Sort.ObjFieldTab().PropertyName(bolIsFstLcase)} - y.{objField_Sort.ObjFieldTab().PropertyName(bolIsFstLcase)}";
                        break;
                }
            }

            return objTabFeatureENEx;
        }


        /// <summary>
        /// 根据TabId获取FeatureId列表
        /// </summary>
        /// <param name = "strTabId">给定条件</param>
        /// <returns>返回arrFeatureId列表</returns>
        public static List<string> GetFeatureIdLstByTabId(string strTabId)
        {
            string strCondition = string.Format("{0}='{1}'", conTabFeature.TabId, strTabId);

            List<string> arrFeatureId = clsTabFeatureBL.GetFldValue(conTabFeature.FeatureId, strCondition);
            return arrFeatureId;

        }
        public static string GetFstFeatureIdByTabId(string strTabId, string strPrjId)
        {
            string strCondition = string.Format("{0}='{1}'", conTabFeature.TabId, strTabId);

            List<string> arrTabFeatureId = clsTabFeatureBL.GetFldValue(conTabFeature.TabFeatureId, strCondition);
            if (arrTabFeatureId.Count == 1) return arrTabFeatureId[0];
            int intMinFldCount = 100;
            string strTabFeatureId_Sel = "";
            foreach (string strTabFeatureId in arrTabFeatureId)
            {
                int intFldCount = clsTabFeatureFldsBLEx.GetRecNumByTabFeatureIdCache(strTabFeatureId, strPrjId);
                if (intMinFldCount > intFldCount)
                {
                    strTabFeatureId_Sel = strTabFeatureId;
                    intMinFldCount = intFldCount;
                }
            }
            return strTabFeatureId_Sel;
        }

        /// <summary>
        /// 绑定基于Web的下拉框， 按功能名排序
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strTabId">strTabId</param>
        /// <param name = "strPrjId">strPrjId</param>
        public static void BindDdl_TabFeatureIdExByTabId(System.Web.UI.WebControls.DropDownList objDDL,
            string strTabId, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format(" 1=1 And {0}='{1}' Order by {2}",
                conTabFeature.TabId,
                strTabId, conTabFeature.OrderNum);
            var objDT = clsTabFeatureBL.GetObjLstCache(strPrjId).Where(x => x.TabId == strTabId).OrderBy(x => x.OrderNum);
            objDDL.DataValueField = conTabFeature.TabFeatureId;
            objDDL.DataTextField = conTabFeature.TabFeatureName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 绑定基于Web的下拉框， 按功能名排序
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strTabId">strTabId</param>
        /// <param name = "strPrjId">strPrjId</param>
        public static void BindDdl_TabFeatureIdExByFldId(System.Web.UI.WebControls.DropDownList objDDL,
            string strFldId, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            var arrTabFeatureFld = clsTabFeatureFldsBL.GetObjLstCache(strPrjId).Where(x => x.FieldTypeId == enumFieldType.KeyField_02 && x.FldId == strFldId);
            var arrTabFeatureId = arrTabFeatureFld.Select(x => x.TabFeatureId).ToList();
            var arrTabFeature = clsTabFeatureBL.GetObjLstCache(strPrjId).Where(x => arrTabFeatureId.Contains(x.TabFeatureId)).OrderBy(x => x.TabFeatureName);
            foreach (clsTabFeatureEN objTabFeature in arrTabFeature)
            {
                clsTabFeatureBLEx.UpdateNormalName(objTabFeature);
            }
            objDDL.DataValueField = conTabFeature.TabFeatureId;
            objDDL.DataTextField = conTabFeature.TabFeatureName;
            objDDL.DataSource = arrTabFeature;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        private static void UpdateNormalName(clsTabFeatureEN objTabFeature)
        {
            switch (objTabFeature.TabFeatureName)
            {
                case "绑定下拉框":
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objTabFeature.TabId, objTabFeature.PrjId);
                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objTabFeature.PrjId);
                    var objTabFeatureFlds_Key = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).First();
                    if (objPrjTab == null) return;
                    if (objTabFeatureFlds_Key == null) return;
                    var objvFieldTab = clsvFieldTab_Sim2BL.GetObjByFldIdCache(objTabFeatureFlds_Key.FldId, objTabFeatureFlds_Key.PrjId);
                    var strName = string.Format("绑定下拉框_{0}({1})", objvFieldTab.FldName, objPrjTab.TabName);
                    objTabFeature.TabFeatureName = strName;
                    objTabFeature.UpdateRecordEx();
                    break;
            }

        }

        internal static List<clsTabFeatureEN> GetSubTabFeatureLst(string strTabFeatureId)
        {
            clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(objTabFeature.FeatureId);
            List<string> arrSubFeatureId = clsPrjFeatureBLEx.GetSubFeatureIdLstByFeatureId(objPrjFeature.FeatureId, objPrjFeature.FeatureTypeId);
            if (arrSubFeatureId.Count == 0) return null;
            string strCondition = string.Format("{0}='{1}' and {2} in ({3})",
                conTabFeature.TabId, objTabFeature.TabId,
                conTabFeature.FeatureId, clsArray.GetSqlInStrByArray(arrSubFeatureId, true));
            List<clsTabFeatureEN> arrSubTabFeature = clsTabFeatureBL.GetObjLst(strCondition);
            return arrSubTabFeature;
            //            throw new NotImplementedException();
        }
        internal static bool IsExistParentFeature(string strTabFeatureId)
        {
            clsvTabFeatureEN objTabFeature = clsvTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
            if (objTabFeature == null) return false;

            if (string.IsNullOrEmpty(objTabFeature.ParentFeatureId) == true) return false;
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                conTabFeature.TabId, objTabFeature.TabId,
                conTabFeature.FeatureId, objTabFeature.ParentFeatureId);
            return clsTabFeatureBL.IsExistRecord(strCondition);
            //            throw new NotImplementedException();
        }

        internal static clsTabFeatureEN GetObjByFeatureRegionFldsObj(clsFeatureRegionFldsEN objFeatureRegionFlds, string strPrjId)
        {
            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFlds.FeatureId);
            string strFeatureId4Tab = clsPrjFeatureBLEx.GetRelaFeatureId4Tab(objFeatureRegionFlds.ViewFeatureId);

            if (string.IsNullOrEmpty(strFeatureId4Tab) == true) return null;
            clsTabFeatureEN objTabFeature = new clsTabFeatureEN()
            {
                TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(strPrjId),
                FeatureId = strFeatureId4Tab,
                TabFeatureName = objPrjFeature.FeatureName,
                TabId = objFeatureRegionFlds.ReleTabId,

                InUse = true,
                UpdDate = clsDateTime.getTodayDateTimeStr(1)
            };
            return objTabFeature;
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objTabFeatureENS">源对象</param>
        /// <returns>目标对象=>clsTabFeatureEN:objTabFeatureENT</returns>
        public static clsTabFeatureENEx CopyToEx(clsTabFeatureEN objTabFeatureENS)
        {
            try
            {
                clsTabFeatureENEx objTabFeatureENT = new clsTabFeatureENEx();
                clsTabFeatureBL.TabFeatureDA.CopyTo(objTabFeatureENS, objTabFeatureENT);
                return objTabFeatureENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static string GC_DdlBindFunction4CSharp(string strTabFeatureId)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsTabFeatureENEx objTabFeature_BindDdl = clsTabFeatureBLEx.GetObjExByTabFeatureId(strTabFeatureId);
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objTabFeature_BindDdl.TabId, objTabFeature_BindDdl.PrjId);
                if (objTabFeature_BindDdl == null) return "";
                if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                {
                    throw new Exception("当前表没有名称字段，不能添加绑定下拉框功能！");
                }
                if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                {
                    throw new Exception("当前表没有关键字段，不能添加绑定下拉框功能！");
                }
                clsTabFeatureFldsEN objField_Key = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
                clsTabFeatureFldsEN objField_Name = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.NameField_03);
                clsTabFeatureFldsEN objField_OrderNum = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09);
                objField_Name.PrjId = objTabFeature_BindDdl.PrjId;
                objField_Key.PrjId = objTabFeature_BindDdl.PrjId;

                string strTextFieldName = objField_Name.ObjFieldTab().FldName;
                string strValueFieldName = objField_Key.ObjFieldTab().FldName;
                //第0步:把控件中下拉框ComboBox转换成ComboBox


                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    //				
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于语言CSharp的Web下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    IEnumerable<clsTabFeatureFldsEN> arrField_Condition = objTabFeature_BindDdl.arrTabFeatureFldsSet().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16);
                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                    foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
                    {
                        if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;
                        objInFor.PrjId = objTabFeature_BindDdl.PrjId;
                        strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", objInFor.ObjFieldTab().PrivFuncName1(), objInFor.ObjFieldTab().Caption);
                    }
                    StringBuilder sbFuncPara = new StringBuilder();

                    foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
                    {
                        if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;
                        objInFor.PrjId = objTabFeature_BindDdl.PrjId;
                        sbFuncPara.AppendFormat(", {0} {1}", objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType,
                            objInFor.ObjFieldTab().PrivFuncName1());

                    }
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL {1})",
                        strValueFieldName, sbFuncPara.ToString());
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\");",
                                      objPrjTab.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", con{0}.{1}); ",
    objPrjTab.TabName, strValueFieldName);
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                    {
                        clsTabFeatureFldsEN objField_Sort = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                        objField_Sort.PrjId = objTabFeature_BindDdl.PrjId;
                        strCodeForCs.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arrObjLst = cls{0}BL.GetObjLst(strCondition).OrderBy(x=>x.{1});",
                             objPrjTab.TabName,
                             objField_Sort.ObjFieldTab().FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arrObjLst = cls{0}BL.GetObjLst(strCondition);",
                             objPrjTab.TabName);
                    }
                    if (arrField_Condition.Count() > 0)
                    {
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.Append("x=>");
                        bool bolIsFirst = true;
                        foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
                        {
                            objInFor.PrjId = objTabFeature_BindDdl.PrjId;
                            string strValue = "";
                            if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01)
                            {
                                switch (objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType)
                                {
                                    case "bool":
                                        if (objInFor.DefaultValue == "1")
                                        {
                                            strValue = "true";
                                        }
                                        else if (objInFor.DefaultValue == "0")
                                        {
                                            strValue = "false";
                                        }
                                        else
                                        {
                                            bool bolValue = bool.Parse(objInFor.DefaultValue);
                                            strValue = bolValue ? "true" : "false";
                                        }
                                        break;
                                    case "string":
                                        strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
                                        break;
                                    case "int":
                                    case "bigint":
                                    case "short":
                                        strValue = string.Format("{0}", objInFor.DefaultValue);
                                        break;

                                    default:
                                        strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
                                        break;
                                }
                            }
                            else
                            {
                                strValue = string.Format("{0}", objInFor.ObjFieldTab().PrivFuncName1());
                            }
                            if (bolIsFirst)
                            {
                                sbCondition.AppendFormat("x.{0} == {1}",
                                     objInFor.ObjFieldTab().FldName,
                                     strValue);
                                bolIsFirst = false;
                            }
                            else
                            {
                                sbCondition.AppendFormat("&& x.{0} == {1}",
                                     objInFor.ObjFieldTab().FldName,
                                     strValue);
                            }
                        }
                        strCodeForCs.AppendFormat("\r\n" + "arrObjLst = arrObjLst.Where({1});",
                            objPrjTab.TabName, sbCondition.ToString());
                    }
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = con{0}.{1};", objPrjTab.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = con{0}.{1};", objPrjTab.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = arrObjLst;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsGeneralTab2.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public static string GC_DdlBindFunctionInDiv4TypeScript(string strTabFeatureId)
        {
            //if (objPrjTabEx.IsUseCache_TS == false) return "//该表在前台TypeScript中，不需要使用Cache;";

            StringBuilder strBuilder = new StringBuilder();
            StringBuilder sbCheckEmpty = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsTabFeatureENEx objTabFeature_BindDdl = clsTabFeatureBLEx.GetObjExByTabFeatureId(strTabFeatureId);
                clsPrjTabENEx objPrjTabEx = clsPrjTabBLEx.GetObjExByTabIdCacheEx(objTabFeature_BindDdl.TabId, objTabFeature_BindDdl.PrjId);
                objPrjTabEx.GetObjAllInfoEx();
                if (objTabFeature_BindDdl == null) return "";
                if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                {
                    throw new Exception("当前表没有名称字段，不能添加绑定下拉框功能！");
                }
                if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                {
                    throw new Exception("当前表没有关键字段，不能添加绑定下拉框功能！");
                }
                clsTabFeatureFldsEN objField_Key = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
                clsTabFeatureFldsEN objField_Name = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.NameField_03);
                clsTabFeatureFldsEN objField_OrderNum = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09);
                objField_Name.PrjId = objTabFeature_BindDdl.PrjId;
                objField_Key.PrjId = objTabFeature_BindDdl.PrjId;

                string strTextFieldName = objField_Name.ObjFieldTab().FldName;
                string strValueFieldName = objField_Key.ObjFieldTab().FldName;
                //第0步:把控件中下拉框ComboBox转换成ComboBox

                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strBuilder.Append("\r\n/**");
                    strBuilder.Append("\r\n * 绑定基于语言:TypeScript的下拉框");
                    strBuilder.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    List<clsTabFeatureFldsEN> arrField_Condition = objTabFeature_BindDdl.arrTabFeatureFldsSet().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    strBuilder.Append("\r\n * @param objDDL:需要绑定当前表的下拉框");
                    foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
                    {
                        if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;
                        objInFor.PrjId = objTabFeature_BindDdl.PrjId;
                        strBuilder.AppendFormat("\r\n * @param {0}:{1}", objInFor.ObjFieldTab().PrivFuncName1(),
                            objInFor.ObjFieldTab().Caption);
                    }
                    strBuilder.Append("\r\n*/");
                    StringBuilder sbFuncPara = new StringBuilder();
                    //string strPrivFuncName_Additional = "";
                    List<string> arrPrivFuncName_Additional = new List<string>();
                    //string strFuncName_Temp = "";
                    foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
                    {
                        if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;
                        //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);
                        objInFor.PrjId = objTabFeature_BindDdl.PrjId;
                        arrPrivFuncName_Additional.Add(objInFor.ObjFieldTab().PrivFuncName1());
                        sbFuncPara.AppendFormat(", {0}: {1}", objInFor.ObjFieldTab().PrivFuncName1(),
                            objInFor.ObjFieldTab().ObjDataTypeAbbr1().TypeScriptType);
                        if (objInFor.ObjFieldTab().ObjDataTypeAbbr1().TypeScriptType == "number")
                        {
                            sbCheckEmpty.AppendFormat("\r\n" + "if ({0} == 0)", objInFor.ObjFieldTab().PrivFuncName1());
                            sbCheckEmpty.Append("\r\n" + "{");
                            sbCheckEmpty.AppendFormat("\r\n" + "  var strMsg = clsString.Format(\"参数:[{0}]不能为空！(In {1})\");",
                                objInFor.ObjFieldTab().PrivFuncName1(), objTabFeature_BindDdl.FuncNameJs);
                            sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                            sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                            sbCheckEmpty.Append("\r\n" + "}");
                        }
                        else
                        {
                            sbCheckEmpty.AppendFormat("\r\n" + "if (clsString.IsNullOrEmpty({0}) == true)", objInFor.ObjFieldTab().PrivFuncName1());
                            sbCheckEmpty.Append("\r\n" + "{");
                            sbCheckEmpty.AppendFormat("\r\n" + "  var strMsg = clsString.Format(\"参数:[{0}]不能为空！(In {1})\");",
                                objInFor.ObjFieldTab().PrivFuncName1(), objTabFeature_BindDdl.FuncNameJs);
                            sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                            sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                            sbCheckEmpty.Append("\r\n" + "}");
                        }
                    }
                    if (objPrjTabEx.ObjCacheClassifyFld_TS != null)
                    {
                        if (arrPrivFuncName_Additional.Contains(objPrjTabEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName) == false)
                        {
                            arrPrivFuncName_Additional.Add(objPrjTabEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName);
                            //strFuncName_Temp = string.Format("BindDdl_{0}Cache", strValueFieldName);

                            sbFuncPara.AppendFormat(", {0}: {1}", objPrjTabEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName,
                                objPrjTabEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);
                            if (objPrjTabEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
                            {
                                sbCheckEmpty.AppendFormat("\r\n" + "if ({0} == 0)", objPrjTabEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName);
                                sbCheckEmpty.Append("\r\n" + "{");
                                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = clsString.Format(\"参数:[{0}]不能为空！(In {1})\");",
                                    objPrjTabEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName, objTabFeature_BindDdl.FuncNameJs);
                                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                                sbCheckEmpty.Append("\r\n" + "}");
                            }
                            else
                            {
                                sbCheckEmpty.AppendFormat("\r\n" + "if (clsString.IsNullOrEmpty({0}) == true)", objPrjTabEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName);
                                sbCheckEmpty.Append("\r\n" + "{");
                                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = clsString.Format(\"参数:[{0}]不能为空！(In {1})\");",
                                    objPrjTabEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName, objTabFeature_BindDdl.FuncNameJs);
                                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                                sbCheckEmpty.Append("\r\n" + "}");
                            }
                        }

                    }
                    if (objPrjTabEx.ObjCacheClassifyFld2_TS != null)
                    {
                        if (arrPrivFuncName_Additional.Contains(objPrjTabEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName) == false)
                        {
                            arrPrivFuncName_Additional.Add(objPrjTabEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName);
                            //strFuncName_Temp = string.Format("BindDdl_{0}Cache", strValueFieldName);

                            sbFuncPara.AppendFormat(", {0}: {1}", objPrjTabEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName,
                                objPrjTabEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);
                            if (objPrjTabEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
                            {
                                sbCheckEmpty.AppendFormat("\r\n" + "if ({0} == 0)", objPrjTabEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName);
                                sbCheckEmpty.Append("\r\n" + "{");
                                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = clsString.Format(\"参数:[{0}]不能为空！(In {1})\");",
                                    objPrjTabEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName, objTabFeature_BindDdl.FuncNameJs);
                                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                                sbCheckEmpty.Append("\r\n" + "}");
                            }
                            else
                            {
                                sbCheckEmpty.AppendFormat("\r\n" + "if (clsString.IsNullOrEmpty({0}) == true)", objPrjTabEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName);
                                sbCheckEmpty.Append("\r\n" + "{");
                                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = clsString.Format(\"参数:[{0}]不能为空！(In {1})\");",
                                    objPrjTabEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName, objTabFeature_BindDdl.FuncNameJs);
                                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                                sbCheckEmpty.Append("\r\n" + "}");
                            }
                        }
                    }
                    strBuilder.AppendFormat("\r\n" + "public static async {0}Cache(strDivName: string, strDdlName: string {1})",
                  objTabFeature_BindDdl.FuncNameJs, sbFuncPara.ToString());
                    //strFuncName_Temp = string.Format("BindDdl_{0}Cache", strValueFieldName);

                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "const strThisFuncName = this.{0}Cache.name;", objTabFeature_BindDdl.FuncNameJs,
strValueFieldName);
                    strBuilder.Append("\r\n" + "console.log('strThisFuncName', strThisFuncName);");

                    strBuilder.AppendLine(sbCheckEmpty.ToString());

                    strBuilder.AppendFormat("\r\n" + "const objDdl = document.getElementById(strDdlName);",
    objPrjTabEx.TabName, strValueFieldName, strTextFieldName);
                    strBuilder.Append("\r\n" + "if (objDdl == null)");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "const strMsg = clsString.Format(\"下拉框：{{0}} 不存在！(In {0})\", strDdlName);",
                        objTabFeature_BindDdl.FuncNameJs);
                    strBuilder.Append("\r\n" + "alert(strMsg);");
                    strBuilder.Append("\r\n" + "console.error(strMsg);");
                    strBuilder.Append("\r\n" + "throw (strMsg);");
                    strBuilder.Append("\r\n" + "}");

                    strBuilder.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                    strBuilder.AppendFormat("\r\n" + "console.log(\"开始：{0}Cache\");", objTabFeature_BindDdl.FuncNameJs);
                    //strBuilder.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\");",
                    //                  objPrjTabEx.TabCnName);

                    //                strBuilder.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", cls{0}EN.con_{1}); ",
                    //objPrjTabEx.TabName, strValueFieldName);
                    if (objPrjTabEx.ObjCacheClassifyFld_TS == null)
                    {
                        strBuilder.AppendFormat("\r\n" + "var arrObjLst_Sel: Array<cls{0}EN> = await cls{0}WApi.GetSubObjLstCache(obj{0}_Cond);", objPrjTabEx.TabName);
                    }
                    else if (objPrjTabEx.ObjCacheClassifyFld2_TS == null)
                    {
                        strBuilder.AppendFormat("\r\n" + "var arrObjLst_Sel: Array<cls{0}EN> = await cls{0}WApi.GetSubObjLstCache(obj{0}_Cond, {1});",
                            objPrjTabEx.TabName,
                            objPrjTabEx.ObjCacheClassifyFld_TS.PrivFuncName);

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "var arrObjLst_Sel: Array<cls{0}EN> = await cls{0}WApi.GetSubObjLstCache(obj{0}_Cond, {1}, {2});",
                            objPrjTabEx.TabName,
                            objPrjTabEx.ObjCacheClassifyFld_TS.PrivFuncName,
                            objPrjTabEx.ObjCacheClassifyFld2_TS.PrivFuncName);

                    }

                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                    {
                        clsTabFeatureFldsEN objField_Sort = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                        objField_Sort.PrjId = objTabFeature_BindDdl.PrjId;
                        string strTypeScriptType = objField_Sort.ObjFieldTab().ObjDataTypeAbbr1().TypeScriptType;
                        switch (strTypeScriptType)
                        {
                            case "string":
                                strBuilder.AppendFormat("\r\n" + "arrObjLst_Sel = arrObjLst_Sel.sort((x, y) => x[cls{0}EN.con_{1}].localeCompare(y[cls{0}EN.con_{1}]));",
                                    objPrjTabEx.TabName, objField_Sort.ObjFieldTab().FldName);
                                break;
                            case "number":
                            case "boolean":
                                strBuilder.AppendFormat("\r\n" + "arrObjLst_Sel = arrObjLst_Sel.sort((x, y) => x[cls{0}EN.con_{1}] - y[cls{0}EN.con_{1}]);",
                                    objPrjTabEx.TabName, objField_Sort.ObjFieldTab().FldName);
                                break;
                        }
                    }
                    if (arrField_Condition.Count() > 0)
                    {
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.Append("x=>");
                        bool bolIsFirst = true;
                        foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
                        {
                            objInFor.PrjId = objTabFeature_BindDdl.PrjId;
                            string strValue = "";
                            if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01)
                            {
                                switch (objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType)
                                {
                                    case "bool":
                                        if (objInFor.DefaultValue == "1")
                                        {
                                            strValue = "true";
                                        }
                                        else if (objInFor.DefaultValue == "0")
                                        {
                                            strValue = "false";
                                        }
                                        else
                                        {
                                            bool bolValue = bool.Parse(objInFor.DefaultValue);
                                            strValue = bolValue ? "true" : "false";
                                        }
                                        break;
                                    case "string":
                                        strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
                                        break;
                                    case "int":
                                    case "bigint":
                                    case "short":
                                        strValue = string.Format("{0}", objInFor.DefaultValue);
                                        break;

                                    default:
                                        strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
                                        break;
                                }
                            }
                            else
                            {
                                strValue = string.Format("{0}", objInFor.ObjFieldTab().PrivFuncName1());
                            }
                            if (bolIsFirst)
                            {
                                sbCondition.AppendFormat("x.{0} == {1}",
                                     objInFor.ObjFieldTab().FldName,
                                     strValue);
                                bolIsFirst = false;
                            }
                            else
                            {
                                sbCondition.AppendFormat("&& x.{0} == {1}",
                                     objInFor.ObjFieldTab().FldName,
                                     strValue);
                            }
                        }
                        strBuilder.AppendFormat("\r\n" + "arrObjLst_Sel = arrObjLst_Sel.filter({1});",
                            objPrjTabEx.TabName, sbCondition.ToString());
                    }
                    string strToolTipText = objPrjTabEx.TabCnName;
                    if (string.IsNullOrEmpty(objTabFeature_BindDdl.ToolTipText) == false) strToolTipText = objTabFeature_BindDdl.ToolTipText;

                    strBuilder.AppendFormat("\r\n" + "clsCommonFunc4Web.BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                objPrjTabEx.TabName,
                                strValueFieldName,
                                strTextFieldName,
                                strToolTipText);

                    strBuilder.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsGeneralTab2.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }

        public static Tuple<string, string> GetFuncName(clsTabFeatureEN objTabFeature)
        {
            //var objTabFeature = await clsTabFeatureWApi.GetObjByTabFeatureIdCache(strTabFeatureId, strPrjId);
            if (objTabFeature == null || String.IsNullOrEmpty(objTabFeature.TabFeatureName) == true)
            {
                throw new Exception("字段名不能为空！");
            }
            var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objTabFeature.PrjId);
            var objTabFeatureFlds_Value = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            Tuple<string, string> objFuncName;
            if (objTabFeatureFlds_Value.Count == 0)
            {
                objFuncName = new Tuple<string, string>(String.Format("BindDdl_绑定的字段出错"),
          String.Format("BindDdl_绑定的字段出错Cache"));

                return objFuncName;
            }
            var strFldId = "";
            if (objTabFeatureFlds_Value.Count > 0)
            {
                strFldId = objTabFeatureFlds_Value[0].FldId;
            }
            var objvFieldTab_Sim3 = clsvFieldTab_Sim2BL.GetObjByFldIdCache(strFldId, objTabFeature.PrjId);
            objFuncName = new Tuple<string, string>(String.Format("BindDdl_{0}", objvFieldTab_Sim3.FldName),
                String.Format("BindDdl_{0}Cache", objvFieldTab_Sim3.FldName));

            return objFuncName;
        }
        /// <summary>
        /// 添加表功能
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <param name="strFeatureId">功能Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strOpUser">操作用户</param>
        /// <returns></returns>
        public static bool AddTabFeature(string strTabId, string strFeatureId, string strPrjId, string strOpUser)
        {
            if (string.IsNullOrEmpty(strFeatureId) == true)
            {
                var strMsg = ("请选择一个功能！");
                throw new Exception(strMsg);

            }
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                var strMsg = ("请提供一个表Id！");
                throw new Exception(strMsg);
            }
            Func<string, string, clsTabFeatureFldsEN> GetTabFeatureFld1 =
                  (strTabFeatureId1, strFldId1)
                      => new clsTabFeatureFldsEN()
                      {
                          TabFeatureId = strTabFeatureId1,
                          FldId = strFldId1,
                          //FieldTypeId = strFieldTypeId1,

                      };
            //Option<int> aa = None;


            //string strFieldTypeId = "";
            string strCondition = "";

            //IEnumerable <clsTabFeatureFldsEN> arrTabFeatureFlds = null;
            //IEnumerable<string> arrFldId = null;
            K_FeatureId_PrjFeature objKey = new K_FeatureId_PrjFeature(strFeatureId);
            clsPrjFeatureEN objPrjFeatureEN = objKey.GetObj();
            switch (objPrjFeatureEN.FeatureName)
            {
                case "绑定下拉框":
                    try
                    {
                        clsTabFeatureFldsBLEx.AddBindDdl(strTabId, strPrjId, strOpUser);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("生成绑定下拉框功能时出错, 表Id:[{0}]。错误:{1}. (In {2})",
                strTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                    break;
                case "调整记录次序":
                    try
                    {
                        //List<string> arrFeatureId_Sub = clsPrjFeatureBLEx.GetSubFeatureIdLstByFeatureId(strFeatureId, enumPrjFeatureType.TabFeature_03);
                        clsTabFeatureFldsBLEx.AddAdjustOrderNum(strTabId, strFeatureId, strPrjId, strOpUser);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("生成调整记录次序功能时出错, 表Id:[{0}]。错误:{1}. (In {2})",
              strTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                    break;
                case "移顶":
                case "上移":
                case "下移":
                case "移底":
                case "重序":

                    try
                    {
                        List<string> arrFeatureId_Sub = clsPrjFeatureBLEx.GetSubFeatureIdLstByFeatureId(strFeatureId, enumPrjFeatureType.TabFeature_03);
                        clsTabFeatureFldsBLEx.AddAdjustOrderNum(strTabId, strFeatureId, strPrjId, strOpUser);
                        foreach (string strSubFeatureId in arrFeatureId_Sub)
                        {
                            clsTabFeatureFldsBLEx.AddAdjustOrderNum(strTabId, strSubFeatureId, strPrjId, strOpUser);
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("生成调整记录次序功能时出错, 表Id:[{0}]。错误:{1}. (In {2})",
                strTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                    break;

                case "设置字段值":
                    //string strFeatureId = enumPrjFeature.Tab_BindDdl_0173;
                    //string strFieldTypeId = enumFieldType.KeyField_02;

                    clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
                    //var GetTabFeatureFld6 =Apply.

                    clsTabFeatureEN objTabFeature = new clsTabFeatureEN();
                    objTabFeature.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(strPrjId);

                    if (objTabFeature.SetTabId(strTabId)
                                .SetPrjId(strPrjId)// 表ID
                        .SetTabFeatureName(objPrjFeature.FeatureName)
                        .SetFeatureId(strFeatureId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(strOpUser)
                            .SetInUse(true)
                            .SetOrderNum(1)
                            .CheckUniqueness() == true)
                    {
                        objTabFeature.AddNewRecordEx(strPrjId, strOpUser);

                    }
                    else
                    {
                        strCondition = string.Format("{0}='{1}' and {2}='{3}' and {4}='{5}'",
                            conTabFeature.TabId, objTabFeature.TabId,
                            conTabFeature.FeatureId, strFeatureId,
                            conTabFeature.TabFeatureName, objPrjFeature.FeatureName);
                        objTabFeature = clsTabFeatureBL.GetFirstObj_S(strCondition);
                    }

                    break;
                case "表相关事务操作":
                    clsTabFeatureEN obj1 = new clsTabFeatureEN();
                    obj1.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(strPrjId);

                    if (obj1.SetTabId(strTabId)
                                .SetPrjId(strPrjId)// 表ID
                        .SetTabFeatureName(objPrjFeatureEN.FeatureName)
                        .SetFeatureId(strFeatureId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(strOpUser)
                            .SetInUse(true)
                            .CheckUniqueness() == true)
                    {
                        obj1.AddNewRecordEx(strPrjId, strOpUser);
                    }

                    break;
                case "XML相关操作":
                    clsTabFeatureEN obj = new clsTabFeatureEN();
                    obj.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(strPrjId);

                    if (obj.SetTabId(strTabId)
                                .SetPrjId(strPrjId)// 表ID
                         .SetTabFeatureName(objPrjFeatureEN.FeatureName)
                        .SetFeatureId(strFeatureId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(strOpUser)
                            .SetInUse(true)
                            .CheckUniqueness() == true)
                    {
                        obj.AddNewRecordEx(strPrjId, strOpUser);
                    }

                    break;
                case "根据标志删除":
                case "恢复删除":
                    //strFieldTypeId = enumFieldType.DelSignField_12;
                    clsTabFeatureEN obj2 = new clsTabFeatureEN();
                    obj2.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(strPrjId);

                    if (obj2.SetTabId(strTabId)
                                .SetPrjId(strPrjId)// 表ID
                         .SetTabFeatureName(objPrjFeatureEN.FeatureName)
                        .SetFeatureId(strFeatureId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(strOpUser)
                            .SetInUse(true)
                            .SetOrderNum(1)
                            .CheckUniqueness() == true)
                    {
                        obj2.AddNewRecordEx(strPrjId, strOpUser);

                    }

                    //var GetTabFeatureFld2 = GetTabFeatureFld1.Apply(obj2.TabFeatureId);

                    //strCondition = string.Format("{0}='{1}' and {2}='{3}'", clsFieldTabEN.con_FieldTypeId, enumFieldType.DelSignField_12,
                    //    clsFieldTabEN.con_PrjId, clsPubVar.CurrSelPrjId);
                    //IEnumerable<clsFieldTabEN> arrObjLst = clsFieldTabBL.GetObjLst(strCondition);

                    //arrFldId = arrObjLst.Select(x=>x.FldId);

                    //arrTabFeatureFlds = arrObjLst
                    //    .Select(x=>x.FldId)
                    //    .Select(GetTabFeatureFld2)
                    //    .Where(x=>x.CheckUniqueness_TabFeatureId_FldId() == true);
                    //foreach(clsTabFeatureFldsEN objInFor in arrTabFeatureFlds)
                    //{
                    //    objInFor
                    //        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    //        .SetUpdUser(clsCommonSession.UserId)
                    //        .SetInUse(true)
                    //        .SetFieldTypeId(enumFieldType.DelSignField_12)   
                    //        .AddNewRecord();
                    //}
                    break;
            }
            clsPrjTabBLEx.SetUpdDate(strTabId, strOpUser);
            return true;
        }

        public static bool CheckTabFeatureFld(string strTabFeatureId, string strPrjId, string strUserId)
        {

            //1、获取当前区域ID的相关主表ID；
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            string strMsg = "";
            //int intErrCount = 0;
            var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
            var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(strTabFeatureId, strPrjId);
            var arrFldId = clsPrjTabFldBLEx.GetFldIdLstByTabIdCache(objTabFeature.TabId, strPrjId);

            foreach (var objInFor in arrTabFeatureFlds)
            {

                if (arrFldId.Contains(objInFor.FldId) == false)
                {
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldId, strPrjId);
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objTabFeature.TabId, strPrjId);
                    if (objPrjTab == null)
                    {
                        strMsg += $"表Id:[{objTabFeature.TabId}]在表中不存在.({clsStackTrace.GetCurrClassFunctionByLevel(2)});";
                    }
                    else
                    {
                        strMsg += $"字段:[{objFieldTab.FldName}({objFieldTab.FldId})]在表[{objPrjTab.TabName}]中不存在.({clsStackTrace.GetCurrClassFunctionByLevel(2)});";
                    }
                }

            }
            if (strMsg.Length > 0)
            {
                objTabFeature.ErrMsg = strMsg;
                objTabFeature.CheckDate = clsDateTime.getTodayDateTimeStr(0);
                objTabFeature.Update();
                return true;
            }
            if (objTabFeature.ErrMsg != null && objTabFeature.ErrMsg.Length > 0)
            {
                objTabFeature.ErrMsg = "";
                objTabFeature.CheckDate = clsDateTime.getTodayDateTimeStr(0);
                objTabFeature.Update();
                return true;
            }
            else
            {
                objTabFeature.ErrMsg = "";
                objTabFeature.CheckDate = clsDateTime.getTodayDateTimeStr(0);
                objTabFeature.Update();
                return true;
            }
            return true;
        }

    }
}