
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPrjTabExWApi
表名:PrjTab(00050009)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:25
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using System.Linq;
using com.taishsoft.datetime;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace AGC4WApi
{
    public static class clsPrjTabExWApi_Static
    {
        public static List<clsvTabFeature_SimEN> arrTabFeatureSet(this clsPrjTabENEx objPrjTabEx, string strCmPrjId)
        {
            List<clsvTabFeature_SimEN> arrTabFeature_Cache = clsvTabFeature_SimWApi.GetObjLstCache(strCmPrjId);
            var arrTabFeature_Sel = arrTabFeature_Cache.Where(x => x.TabId == objPrjTabEx.TabId).ToList();

            return arrTabFeature_Sel;
        }

        public static int KeyFldNum(this clsPrjTabENEx objPrjTabEx, List<clsPrjTabFldEN> arrObjLst_P)
        {
            var arrPrjTabFld = clsPrjTabFldWApi.GetObjLstCacheFromObjLst(objPrjTabEx.TabId, arrObjLst_P);
            var arrPrjTabFld_Key = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldTypeWA.KeyField_02).ToList();
            return arrPrjTabFld_Key.Count;
        }
        /// <summary>
        /// 获取对象扩展信息
        /// </summary>
        /// <param name="objUserCodePathEx"></param>
        /// <returns></returns>
        public static void GetObjExInfo1(this clsPrjTabENEx objPrjTabEx, clsUserCodePathENEx objUserCodePathEx)
        {
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeWApi.GetObjByCodeTypeId(objUserCodePathEx.CodeTypeId);
            objPrjTabEx.CodeTypeId = objUserCodePathEx.CodeTypeId;
            objPrjTabEx.ObjFuncModule = clsFuncModule_AgcWApi.GetObjByFuncModuleAgcIdCache(objPrjTabEx.FuncModuleAgcId, objPrjTabEx.PrjId);
            objPrjTabEx.FileName = string.Format(objCodeTypeEN.FileNameFormat, objPrjTabEx.TabName);
            //this.ObjGCPrjRelaFile.PrjInnerCodePath = objUserCodePathEx.GetPrjInnerCodePath();
            objPrjTabEx.PrjInnerFileName = clsPrjTabExWApi.GetFileNameInPrj(objUserCodePathEx.PrjInnerCodePath,
                objPrjTabEx.ObjFuncModule.FuncModuleEnName, objPrjTabEx.FileName);

            //this.ObjGCPrjRelaFile.FullProjectPath = objUserCodePathEx.GetFullProjectPath(this.ObjUserCodePrjMainPath);
            objPrjTabEx.FullFileName = string.Format("{0}\\{1}\\{2}", objUserCodePathEx.NewCodePath,
                objPrjTabEx.ObjFuncModule.FuncModuleEnName, objPrjTabEx.FileName);
            objPrjTabEx.FullFileName = objPrjTabEx.FullFileName.Replace("\\/\\", "\\")
                              .Replace("/", "\\").Replace("\\\\", "\\");

            objPrjTabEx.SuffixPath = objUserCodePathEx.SuffixPath;
            objPrjTabEx.TabSpace = objPrjTabEx.DataBaseName;
            objPrjTabEx.objProjectsEN = clsProjectsWApi.GetObjByPrjIdCache(objPrjTabEx.PrjId);
        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsPrjTabEN:objPrjTabENT</returns>
        public static clsPrjTabENEx CopyToEx(this clsPrjTabEN objPrjTabENS)
        {
            try
            {
                clsPrjTabENEx objPrjTabENT = new clsPrjTabENEx();
                clsPrjTabWApi.CopyTo(objPrjTabENS, objPrjTabENT);
                return objPrjTabENT;
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
        /// <param name = "objPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsPrjTabEN:objPrjTabENT</returns>
        public static clsPrjTabEN CopyTo(this clsPrjTabENEx objPrjTabENS)
        {
            try
            {
                clsPrjTabEN objPrjTabENT = new clsPrjTabEN();
                clsPrjTabWApi.CopyTo(objPrjTabENS, objPrjTabENT);
                return objPrjTabENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string ProgLangTypeId(this clsPrjTabENEx objPrjTabENEx)
        {
            clsvCodeType_SimEN objCodeType = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId);
            if (objCodeType == null) return enumProgLangTypeWA.CSharp_01;
            return objCodeType.ProgLangTypeId;
        }

        public static bool GetObjAllInfoEx(this clsPrjTabENEx objPrjTabENEx, string strCmPrjId)
        {
            //clsPrjTabDAEx objPrjTabDA = new clsPrjTabDAEx();
            //clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabENEx.TabId);

            //bool bolResult = objPrjTabDA.GetPrjTab(ref objPrjTabEN);
            //objPrjTabENEx = new clsPrjTabENEx(objPrjTabEN);
            //bool bolResult = objPrjTabDA.GetPrjTabEx(ref objPrjTabENEx);
            //string strCondition = string.Format("TabId = '{0}' Order by SequenceNumber", objPrjTabENEx.TabId);
            //objPrjTabENEx.arrPrjTabFldENExObjLst = new clsPrjTabFldDAEx().GetPrjTabFldENExObjList(strCondition);
            objPrjTabENEx.arrPrjTabFldENExObjLst = clsPrjTabFldExWApi.GetPrjTabFldENExObjListOrderBySequence(objPrjTabENEx.TabId);

            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrPrjTabFldENExObjLst)
            {
                //objPrjTabFldENEx.SequenceNumber
                //objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabExWApi.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabENEx.PrjId);
                //clsPrjTabFldExWApi.InitFieldTab(objPrjTabFldENEx);
                objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabExWApi.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);

                objPrjTabFldENEx.ObjFieldTabENEx.LangType = objPrjTabENEx.LangType;
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrWApi.GetObjByDataTypeIdCache(objPrjTabFldENEx.ObjFieldTabENEx.DataTypeId);
                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN = objDataTypeAbbrEN.CopyToEx();
                objPrjTabFldENEx.objFieldTypeEN = clsFieldTypeWApi.GetObjByFieldTypeIdCache(objPrjTabFldENEx.FieldTypeId);
                objPrjTabFldENEx.objPrimaryTypeEN = clsPrimaryTypeWApi.GetObjByPrimaryTypeIdCache(objPrjTabFldENEx.PrimaryTypeId);
            }
            //intTabFldNum = 0;
            //intKeyFldNum = 0;
            //objViewInfoENEx.TabId = strTabId;
            objPrjTabENEx.TabSpace = objPrjTabENEx.DataBaseName;
            objPrjTabENEx.objProjectsEN = clsProjectsWApi.GetObjByPrjIdCache(objPrjTabENEx.PrjId);
            objPrjTabENEx.ObjFuncModule = clsFuncModule_AgcWApi.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            //objPrjTabENEx.arrFldSet = new ArrayList();
            //objPrjTabENEx.arrFldSetAll = new ArrayList();
            //objPrjTabENEx.arrKeyFldSet = new ArrayList();
            try
            {
                objPrjTabENEx.initFldSet(strCmPrjId);
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return true;
        }



        /// <summary>
        /// 初始化字段结合
        /// </summary>
        private static bool initFldSet(this clsPrjTabENEx objPrjTabENEx, string strCmPrjId)
        {
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //		然后存到集合中
            //3、


            objPrjTabENEx.arrFldSetAll = new List<clsPrjTabFldENEx>();
            objPrjTabENEx.arrFldSet = new List<clsPrjTabFldENEx>();
            objPrjTabENEx.arrKeyFldSet = new List<clsPrjTabFldENEx>();
            string strCondition = string.Format("{0}='{1}' and {2}='1'", conPrjConstraint.TabId, objPrjTabENEx.TabId, conPrjConstraint.InUse);
            //objPrjTabENEx.arrPrjConstraintSet = clsPrjConstraintExWApi.GetObjExLst(strCondition);
            strCondition = string.Format("{0}='{1}' and {2}='1'", conConstraintFields.TabId, objPrjTabENEx.TabId, conConstraintFields.InUse);
            //objPrjTabENEx.arrConstraintFieldsSet = clsConstraintFieldsExWApi.GetObjExLst(strCondition);
            //strCondition = string.Format("{0}='{1}' and {2}='1'", conTabFeature.TabId, objPrjTabENEx.TabId, conTabFeature.InUse);
            //objPrjTabENEx.arrTabFeatureSet = clsTabFeatureExWApi.GetObjExLst(strCondition);

            strCondition = string.Format("{0}='{1}'", conTabFunctionProp.TabId, objPrjTabENEx.TabId);
            objPrjTabENEx.arrTabFunctionProp = clsTabFunctionPropWApi.GetObjLst(strCondition);


            //foreach (clsConstraintFieldsENEx objField in objPrjTabENEx.arrConstraintFieldsSet)
            //{
            //    try
            //    {
            //        objField.ObjFieldTabENEx = clsFieldTabExWApi.GetObjExByFldIDCache(objField.FldId, objPrjTabENEx.PrjId);
            //    }
            //    catch (Exception objException)
            //    {
            //        string strMsg = string.Format("在表：[{2}]中，约束字段:{0}不存在！错误：{3}。(In {1})", 
            //            objField.FldId, clsStackTrace.GetCurrClassFunction(), objPrjTabENEx.TabName, objException.Message);
            //        throw new Exception(strMsg);
            //    }
            //    objField.ObjFieldTabENEx.objDataTypeAbbrEN = clsDataTypeAbbrWApi
            //        .GetObjByDataTypeIdCache(objField.ObjFieldTabENEx.DataTypeId)
            //        .CopyToEx();
            //}
            var arrTabFeature = objPrjTabENEx.arrTabFeatureSet(strCmPrjId);
            foreach (var objTabFeatureENEx in arrTabFeature)
            {
                //objTabFeatureENEx.arrTabFeatureFldsSet = clsTabFeatureFldsExWApi.GetObjExLstByTabFeatureId(objTabFeatureENEx.TabFeatureId);
                var arrTabFeatureFlds = objTabFeatureENEx.arrTabFeatureFldsSet(objPrjTabENEx.PrjId);
                //foreach (clsTabFeatureFldsENEx objField in arrTabFeatureFlds)
                //{
                //    if (string.IsNullOrEmpty(objField.FldId) == true) continue;
                //    objField.ObjFieldTabENEx = clsFieldTabExWApi.GetObjExByFldIDCache(objField.FldId, objPrjTabENEx.PrjId);
                //    objField.ObjFieldTabENEx.objDataTypeAbbrEN = clsDataTypeAbbrWApi
                //        .GetObjByDataTypeIdCache(objField.ObjFieldTabENEx.DataTypeId)
                //        .CopyToEx();
                //}
            }
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //  然后存到集合中
            //arrMId = clsPrjTabFldENEx.funGetFldValue2("PrjTabFld", "Mid", "TabId = '" + objViewInfoENEx.TabId + "'", "SequenceNumber");

            List<string> arrTabId = objPrjTabENEx.arrPrjTabFldENExObjLst.Select(x=>x.TabId).ToList();
            List<clsPrjTabFldEN> arrPrjTabFld_P = clsPrjTabFldExWApi.GetObjLstByTabIdLst(arrTabId);

            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrPrjTabFldENExObjLst)
            {

                objPrjTabENEx.arrFldSetAll.Add(objPrjTabFldENEx);
                if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "timestamp")
                {
                    objPrjTabENEx.arrFldSet.Add(objPrjTabFldENEx);
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldTypeWA.KeyField_02)
                {
                    objPrjTabENEx.arrKeyFldSet.Add(objPrjTabFldENEx);

                }

                if (objPrjTabFldENEx.FieldTypeId == enumFieldTypeWA.NameField_03)
                {
                    objPrjTabENEx.objNameField = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldTypeWA.OrderNumField_09)
                {
                    objPrjTabENEx.objOrderNumField = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldTypeWA.DelSignField_12)
                {
                    objPrjTabENEx.objDelSignField = objPrjTabFldENEx;
                }
                var objFieldTab4CodeConv = clsFieldTab4CodeConvWApi.GetObjByFldIdCache(objPrjTabFldENEx.ObjFieldTabENEx.FldId, objPrjTabFldENEx.ObjFieldTabENEx.PrjId);
                if (objFieldTab4CodeConv != null)
                {
                    objPrjTabENEx.IsNeedTransCode = true;
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldTypeWA.NameField_03)
                {
                    objPrjTabENEx.objPrjTabFld4NameFld = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.IsSortFld == true)
                {
                    objPrjTabENEx.objSortField = clsFieldTabExWApi.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
                }
                //objPrjTabENEx.TabFldNum++;
            }
            if (objPrjTabENEx.KeyFldNum(arrPrjTabFld_P) == 0)
            {
                return false;
            }
            objPrjTabENEx.objKeyField0 = (clsPrjTabFldENEx)objPrjTabENEx.arrKeyFldSet[0];

            return true;
        }

        public static bool GetPrjTabFldENExObjLst(this clsPrjTabENEx objPrjTabENEx)
        {
            //string strCondition = string.Format("TabId = '{0}'", objPrjTabENEx.TabId);
            objPrjTabENEx.arrPrjTabFldENExObjLst = clsPrjTabFldExWApi.GetPrjTabFldENExObjListOrderBySequence(objPrjTabENEx.TabId);
            return true;
        }


    }


    /// <summary>
    /// 工程表(PrjTab)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsPrjTabExWApi
    {
        private static readonly string mstrApiControllerName = "PrjTabExApi";
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsPrjTabExWApi()
        {
        }
        public static clsvPrjTab_SimENEx GetObjExByTabId_CacheEx(string strTabId, string strPrjId)
        {
            string strMsg = "";
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                strMsg = string.Format("表Id不能为空！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            if (strPrjId.Length != 4)
            {
                throw new Exception("字段[strPrjId]的长度应该等于4!");
            }
            intFindFailCount = 0;

            List<clsvPrjTab_SimEN> arrPrjTabObjLst_Cache = clsvPrjTab_SimWApi.GetObjLstCache(strPrjId);
            while (intFindFailCount <= 1)
            {

                IEnumerable<clsvPrjTab_SimEN> arrPrjTabObjLst_Sel1 =
                    from objPrjTabEN in arrPrjTabObjLst_Cache
                    where objPrjTabEN.TabId == strTabId
                    select objPrjTabEN;

                //在缓存中找到数据，就返回第一条数据
                if (arrPrjTabObjLst_Sel1.Count() > 0)
                {
                    intFindFailCount = 0;
                    clsvPrjTab_SimEN objPrjTab = arrPrjTabObjLst_Sel1.First();
                    clsvPrjTab_SimENEx objPrjTabEx = objPrjTab.CopyToEx();
                    return objPrjTabEx;
                }
                //如果在缓存中找不到数据，就重新加载缓存，再试一次
                intFindFailCount++;
                string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
                CacheHelper.Remove(strKey);
            }

            strMsg = string.Format("表Id:[{0}]，项目Id:[{1}]找不到相关对象！(intFindFailCount={2})(当前对象数:{3})({4})",
                strTabId, strPrjId, intFindFailCount,
                arrPrjTabObjLst_Cache.Count,
                clsStackTrace.GetCurrClassFunction());

            throw new Exception(strMsg);

        }

        /// <summary>
        /// 获取在工程中的文件名
        /// </summary>
        /// <param name="strCodePath">在工程中的代码路径</param>
        /// <param name="strFuncModuleEnName">模块名</param>
        /// <param name="strFileName">文件名</param>
        /// <returns></returns>
        public static string GetFileNameInPrj(string strCodePath, string strFuncModuleEnName, string strFileName)
        {
            string strFileName_InPrj = string.Format("{0}/{1}/{2}", strCodePath, strFuncModuleEnName, strFileName);
            strFileName_InPrj = strFileName_InPrj.Replace("\\/\\", "\\")
                .Replace("/", "\\");
            if (strFileName_InPrj.Substring(0, 2) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(2);
            }
            if (strFileName_InPrj.Substring(0, 1) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(1);
            }
            return strFileName_InPrj;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strTabId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvPrjTab_SimEN GetObjByTabId_CacheExBak(string strTabId, string strPrjId)
        {
            string strMsg = "";
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                strMsg = string.Format("表Id不能为空！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (strPrjId.Length != 4)
            {
                throw new Exception("字段[strPrjId]的长度应该等于4!");
            }
            List<clsvPrjTab_SimEN> arrPrjTabObjLst_Cache = clsvPrjTab_SimWApi.GetObjLstCache(strPrjId);
            var objvPrjTab_Sim = arrPrjTabObjLst_Cache.Find(x => x.TabId == strTabId);
            if (objvPrjTab_Sim != null)
            {
                return objvPrjTab_Sim;
            }
            intFindFailCount = 0;
            //List<clsPrjTabEN> arrPrjTabObjLst_Sel = null;

            string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
            CacheHelper.Remove(strKey);


            strMsg = string.Format("表Id:[{0}]，项目Id:[{1}]找不到相关对象！(当前对象数:{3})({4})",
                strTabId, strPrjId, intFindFailCount,
               arrPrjTabObjLst_Cache.Count,
                clsStackTrace.GetCurrClassFunction());

            throw new Exception(strMsg);

        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <param name = "strTabName">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvPrjTab_SimEN GetObjByTabNameExCache(string strPrjId, string strTabName)
        {
            List<clsvPrjTab_SimEN> arrPrjTabObjLst_Cache = clsvPrjTab_SimWApi.GetObjLstCache(strPrjId);
            IEnumerable<clsvPrjTab_SimEN> arrPrjTabObjLst_Sel1 =
                from objPrjTabEN in arrPrjTabObjLst_Cache
                where objPrjTabEN.TabName == strTabName
                select objPrjTabEN;
            List<clsvPrjTab_SimEN> arrPrjTabObjLst_Sel = new List<clsvPrjTab_SimEN>();

            foreach (clsvPrjTab_SimEN obj in arrPrjTabObjLst_Sel1)
            {
                arrPrjTabObjLst_Sel.Add(obj);
            }
            if (arrPrjTabObjLst_Sel.Count == 0)
            {
                return null;
            }
            string strMsg = string.Format("PrjId:[{0}({1})] + TabName:[{2}]==>TabId:[{3}].({4})",
                strPrjId, strPrjId, strTabName,
                    arrPrjTabObjLst_Sel[0].TabId, clsStackTrace.GetCurrClassFunction());
            clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
            return arrPrjTabObjLst_Sel[0];

        }


        /// <summary>
        /// p_Init_Log4GeneTabCode
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">strUserId</param>
        /// <returns>返回对象列表</returns>
        public static bool p_Init_Log4GeneTabCode(string strPrjId, string strUserId)
        {
            string strAction = "p_Init_Log4GeneTabCode";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
                ["strUserId"] = strUserId,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("p_Init_Log4GeneTabCode出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// GetObjExLstByPrjIdEx
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回对象列表</returns>
        public static List<clsPrjTabENEx> GetObjExLstByPrjIdEx(string strPrjId)
        {
            string strAction = "GetObjExLstByPrjIdEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        string strJson = JsonConvert.SerializeObject(jobjReturn["returnObjLst"]);
                        var varResult = JsonConvert.DeserializeObject<List<clsPrjTabENEx>>(strJson);

                        //var varResult1 = clsJSON.GetObjLstFromJson<clsPrjTabENEx>((string1)jobjReturn["returnObjLst"]);
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("GetObjExLstByPrjIdEx出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// IsExistTabNameInCommonTable
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strTabName">表名</param>
        /// <returns>返回对象列表</returns>
        public static bool IsExistTabNameInCommonTable(string strTabName)
        {
            string strAction = "IsExistTabNameInCommonTable";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strTabName"] = strTabName,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("IsExistTabNameInCommonTable出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        public static bool IsAppliedInViewList(string strTabId, string strPrjId)
        {
            string strAction = "IsAppiedInViewList";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strTabId"] = strTabId,
                ["strPrjId"] = strPrjId,

            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("IsExistTabNameInCommonTable出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
        public static bool IsAppiedInViewList4CmPrjId(string strTabId, string strCmPrjId)
        {
            string strAction = "IsAppiedInViewList4CmPrjId";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strTabId"] = strTabId,
                ["strCmPrjId"] = strCmPrjId,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("IsExistTabNameInCommonTable出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <param name = "strTabName">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetTabIdByTabNameExCache(string strPrjId, string strTabName)
        {
            List<clsvPrjTab_SimEN> arrPrjTabObjLst_Cache = clsvPrjTab_SimWApi.GetObjLstCache(strPrjId);
            IEnumerable<clsvPrjTab_SimEN> arrPrjTabObjLst_Sel1 =
                from objPrjTabEN in arrPrjTabObjLst_Cache
                where objPrjTabEN.TabName == strTabName
                select objPrjTabEN;
            List<clsvPrjTab_SimEN> arrPrjTabObjLst_Sel = new List<clsvPrjTab_SimEN>();
            foreach (clsvPrjTab_SimEN obj in arrPrjTabObjLst_Sel1)
            {
                arrPrjTabObjLst_Sel.Add(obj);
            }
            if (arrPrjTabObjLst_Sel.Count == 0)
            {
                return "";
            }
            string strMsg = string.Format("PrjId:[{0}({1})] + TabName:[{2}]==>TabId:[{3}].({4})",
                strPrjId, strPrjId, strTabName,
                    arrPrjTabObjLst_Sel[0].TabId, clsStackTrace.GetCurrClassFunction());
            clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
            return arrPrjTabObjLst_Sel[0].TabId;

        }


        /// <summary>
        /// SetPrjTabFldNullBySQLTab
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strPrjDataBaseId">strPrjDataBaseId</param>
        /// <param name = "strUserId">strUserId</param>
        /// <returns>返回对象列表</returns>
        public static bool SetPrjTabFldNullBySQLTab(string strTabId, string strPrjId, string strPrjDataBaseId, string strUserId)
        {
            string strAction = "SetPrjTabFldNullBySQLTab";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strTabId"] = strTabId,
                ["strPrjId"] = strPrjId,
                ["strPrjDataBaseId"] = strPrjDataBaseId,
                ["strUserId"] = strUserId,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("SetPrjTabFldNullBySQLTab出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
        public static clsPrjTabENEx CopyToEx(clsPrjTabEN objPrjTabENS)
        {
            try
            {
                clsPrjTabENEx objPrjTabENT = new clsPrjTabENEx();
                clsPrjTabWApi.CopyTo(objPrjTabENS, objPrjTabENT);
                return objPrjTabENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}