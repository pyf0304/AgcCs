using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
//pyf20250807-5
namespace AutoGCLib
{

    public abstract partial class clsGeneCodeBase4View
    {
        public List<PubVarType> pubVarTypes = null;
        public bool AddPubVarType(PubVarType pubVarType)
        {
            try
            {
                var oldPubVarType = pubVarTypes.Find(x => x.FldName == pubVarType.FldName && x.VarType == pubVarType.VarType);
                if (oldPubVarType == null)
                {
                    pubVarTypes.Add(pubVarType);
                    return true;
                }
                if (oldPubVarType.VarName != pubVarType.VarName)
                {
                    var strMsg = string.Format("字段：{0}(类型：{1})的原变量名是:{2},新变量的名称是:{3},前后不一致!",
                        oldPubVarType.FldName, oldPubVarType.VarType, oldPubVarType.VarName, pubVarType.VarName);
                    throw new Exception(strMsg);
                }
                //if (pubVarType.IsCache == true) { oldPubVarType.IsCache = true; }
                //else if (pubVarType.IsStatic == true) { oldPubVarType.IsStatic = true; }
                return true;
            }
            catch
            {
                return false;
            }
        }


        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj_PubVarType = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        /// <summary>
        /// 获取一个表中界面公共变量列表
        /// </summary>
        /// <param name="strTabId"></param>
        /// <returns></returns>
        public void GetViewIdVarRelaVarLst(string strViewId)
        {
            //StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //List<string> arrVarName = new List<string>();

            //1、列表区的缓存变量----------------------------------
            List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRela = clsViewIdGCVariableRelaBLEx.GetObjLstByViewId(strViewId, this.PrjId);
            foreach (var objInFor in arrViewIdGCVariableRela)
            {
                PubVarType myPubVar = clsGCVariableBLEx.getPubVarTypeByVarId(objInFor.VarId, ThisClsName);
                AddPubVarType(myPubVar);
            }
            //return strCodeForCs.ToString();
        }
        /// <summary>
        /// 获取一个表中界面公共变量列表
        /// </summary>
        /// <param name="strTabId"></param>
        /// <returns></returns>
        public void GetViewPubVarLst(string strTabId)
        {
            //StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //List<string> arrVarName = new List<string>();

            //1、列表区的缓存变量----------------------------------
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, objViewInfoENEx.PrjId);

            if (string.IsNullOrEmpty(objPrjTab.ParaVar1TS) == false)
            {

                PubVarType myPubVar = clsGCVariableBLEx.getPubVarTypeByVarId(objPrjTab.ParaVar1TS, ThisClsName);
                AddPubVarType(myPubVar);

            }

            if (string.IsNullOrEmpty(objPrjTab.ParaVar2TS) == false)
            {
                PubVarType myPubVar = clsGCVariableBLEx.getPubVarTypeByVarId(objPrjTab.ParaVar2TS, ThisClsName);
                AddPubVarType(myPubVar);
            }
            //========================================================
            //2、界面主表的缓存分类字段、分类变量
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                var myPubVar = new PubVarType();
                myPubVar.VarType = gcVarType.Cache;
                myPubVar.FldName = thisCacheClassify4View.FldName;
                myPubVar.VarName = string.Format("{0}Cache", thisCacheClassify4View.FldName);
                myPubVar.VarName4Get = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName);
                myPubVar.IsStatic = true;
                myPubVar.IsNeedDefine = true;
                myPubVar.DefaultValue = "\"\"";
                myPubVar.Memo = "2、界面主表的缓存分类字段变量1";
                AddPubVarType(myPubVar);
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                var myPubVar = new PubVarType();
                myPubVar.VarType = gcVarType.Cache;
                myPubVar.FldName = thisCacheClassify4View.FldName2;
                myPubVar.VarName = string.Format("{0}Cache", thisCacheClassify4View.FldName2);
                myPubVar.VarName4Get = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName2);
                myPubVar.IsStatic = true;
                myPubVar.IsNeedDefine = true;
                myPubVar.DefaultValue = "\"\"";
                myPubVar.Memo = "2、界面主表的缓存分类字段变量2";
                AddPubVarType(myPubVar);
            }
            //=========================================================

            //3、前缀变量
            if (objPrefixField != null)
            {
                var myPubVar = new PubVarType();
                myPubVar.VarType = gcVarType.Prefix;
                myPubVar.FldName = objPrefixField.FldName;
                myPubVar.VarName = string.Format("{0}4PrefixStatic", objPrefixField.FldName);
                myPubVar.VarName4Get = string.Format("{0}.{1}4PrefixStatic", ThisClsName, objPrefixField.FldName);
                myPubVar.IsStatic = true;
                myPubVar.IsNeedDefine = true;
                myPubVar.DefaultValue = "\"\"";
                myPubVar.Memo = "3、前缀变量";
                AddPubVarType(myPubVar);

            }
            //4、功能区-详细记录--------------------------------------------------------------
            List<string> arrFldName4StaticKeyId = new List<string>();
            var objFeatureRegionFlds_Detail = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.DetailRecord_0239);
            if (objFeatureRegionFlds_Detail != null && objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                if (arrFldName4StaticKeyId.Contains(objKeyField.FldName) == false)
                {
                    arrFldName4StaticKeyId.Add(objKeyField.FldName);
                }
            }
            List<string> arrFeatureId = new List<string>() { enumPrjFeature.UpdateRecord_0137, enumPrjFeature.UpdateRecord_0199 };
            var objFeatureRegionFlds_Update = objViewInfoENEx.arrFeatureRegionFlds.Find(x => arrFeatureId.Contains(x.FeatureId));

            if (objFeatureRegionFlds_Update != null && objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                if (arrFldName4StaticKeyId.Contains(objKeyField.FldName) == false)
                {
                    arrFldName4StaticKeyId.Add(objKeyField.FldName);
                }
            }


            arrFldName4StaticKeyId.ForEach(x =>
            {
                string strDefaValue = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue;
                if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";
                var strVarName = string.Format("{0}Static", x);
                var myPubVar = new PubVarType();
                myPubVar.VarType = gcVarType.Static;
                myPubVar.FldName = objKeyField.ObjFieldTabENEx.FldName;
                myPubVar.VarName = strVarName;
                myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                myPubVar.IsStatic = true;
                myPubVar.IsNeedDefine = true;
                myPubVar.DefaultValue = strDefaValue;
                myPubVar.Memo = "4、功能区-详细记录,界面静态变量";
                AddPubVarType(myPubVar);

            });
            //===================================================================

            //5、处理添加、修改记录时PutData中的特殊字段值
            List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
            if (objViewInfoENEx.objViewRegion_Edit != null)
            {
                var arrEditRegionFlds_Var = objViewInfoENEx.arrEditRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));

                foreach (var objInFor in arrEditRegionFlds_Var)
                {
                    clsGCVariableEN objVar_Cond1 = null;
                    if (string.IsNullOrEmpty(objInFor.VarIdCond1) == false && objInFor.VarIdCond1 != "0")
                    {
                        objVar_Cond1 = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarIdCond1);
                    }

                    if (objVar_Cond1 != null && objVar_Cond1.VarTypeId == enumGCVariableType.sessionStorage_0004) continue;

                    var strDefaValue = "\"\"";
                    var strVarName = "";
                    //var strDataType = "string";
                    var objField = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldId, objViewInfoENEx.PrjId);
                    if (objField.IsNumberType() == true)
                    {
                        //strDataType = "number";
                        strDefaValue = "0";
                    }
                    else if (objField.IsBoolType() == true)
                    {
                        //strDataType = "boolean";
                        strDefaValue = "false";
                    }
                    var myPubVar = new PubVarType();
                    myPubVar.FldName = objInFor.FldName;
                    switch (objInFor.CtlTypeId)
                    {
                        case enumCtlType.ViewVariable_38:
                            if (string.IsNullOrEmpty(objInFor.VarId) == true) continue;
                            var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                            strVarName = objVar.GetVarName4View();

                            //myPubVar.VarType = gcVarType.Cache;
                            myPubVar.VarName = objVar.VarName;
                            switch (objVar.VarTypeId)
                            {
                                case enumGCVariableType.StaticValuable_0006:
                                    myPubVar.VarType = gcVarType.Static;
                                    myPubVar.IsStatic = true;
                                    myPubVar.VarName = strVarName;
                                    break;
                                case enumGCVariableType.CacheClassifyField_0007:
                                    myPubVar.VarType = gcVarType.Cache;
                                    myPubVar.IsStatic = false;
                                    break;
                            }

                            myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);

                            myPubVar.IsNeedDefine = true;
                            myPubVar.DefaultValue = strDefaValue;
                            myPubVar.Memo = "5、处理添加、修改记录时PutData所用的Session缓存变量,用于获取界面编辑主表时所用的Session类字段值";
                            AddPubVarType(myPubVar);

                            break;

                        default:
                            var objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objInFor.CtlTypeId);
                            var strMsg = string.Format("控件类型：{0}({1})在相应函数中没有被处理!({2})", objCtlType.CtlTypeName, objCtlType.CtlTypeId, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                    }
                }
            }
            //======================================================================

            //6、处理与编辑区下拉框相关的静态变量
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Edit = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            try
            {
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    var strVarName = "";
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        continue;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(objInfor.VarIdCond1) == false && objInfor.VarIdCond1 != "0"
                            && string.IsNullOrEmpty(objInfor.FldIdCond1) == false)
                        {
                            string strDefaValue = "";

                            //var objField = clsFieldTabBL.GetObjByFldIdCache(objInfor.FldIdCond1, objViewInfoENEx.PrjId);

                            var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objInfor.VarIdCond1);
                            strDefaValue = objGCVariable.ObjDataTypeAbbr().GetInitValue(enumProgLangType.TypeScript_09);
                            if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";

                            var myPubVar = new PubVarType();
                            myPubVar.FldName = objGCVariable.VarName;

                            switch (objGCVariable.VarTypeId)
                            {
                                case enumGCVariableType.GivingValue_0001:

                                    strVarName = string.Format("{0}Giving", objGCVariable.VarName);
                                    myPubVar.VarType = gcVarType.Giving;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "6、定义下拉框条件给定值2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.CacheClassifyField_0007:
                                    strVarName = string.Format("{0}Cache", objGCVariable.VarName);
                                    myPubVar.VarType = gcVarType.Cache;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "6、定义下拉框条件变量1";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.StaticValuable_0006:
                                    strVarName = string.Format("{0}Static", objGCVariable.VarName);

                                    myPubVar.VarType = gcVarType.Static;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "6、定义下拉框条件变量1";
                                    AddPubVarType(myPubVar);
                                    break;
                                case enumGCVariableType.DefaultValue_0002:
                                    break;
                                case enumGCVariableType.sessionStorage_0004:
                                    break;
                                case enumGCVariableType.localStorage_0003:
                                    break;

                                default:
                                    var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objGCVariable.VarTypeId);

                                    var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理!(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
                    clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                    //break;
                            }
                        }
                        if (string.IsNullOrEmpty(objInfor.VarIdCond2) == false && string.IsNullOrEmpty(objInfor.FldIdCond2) == false)
                        {
                            var objField = clsFieldTabBL.GetObjByFldIdCache(objInfor.FldIdCond2, objViewInfoENEx.PrjId);
                            string strDefaValue = objField.ObjDataTypeAbbr().GetInitValue(enumProgLangType.TypeScript_09);
                            if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";

                            var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objInfor.VarIdCond2);
                            var myPubVar = new PubVarType();
                            myPubVar.FldName = objField.FldName;

                            switch (objGCVariable.VarTypeId)
                            {
                                case enumGCVariableType.GivingValue_0001:

                                    strVarName = string.Format("{0}Giving", objField.FldName);

                                    myPubVar.VarType = gcVarType.Giving;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "6、定义下拉框条件给定值2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.CacheClassifyField_0007:

                                    strVarName = string.Format("{0}Cache", objField.FldName);
                                    myPubVar.VarType = gcVarType.Cache;
                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "6、定义下拉框条件变量2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.StaticValuable_0006:
                                    strVarName = string.Format("{0}Static", objField.FldName);
                                    myPubVar.VarType = gcVarType.Static;
                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "6、定义下拉框条件变量2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.sessionStorage_0004:
                                    break;
                                case enumGCVariableType.localStorage_0003:
                                    break;

                                default:
                                    var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objGCVariable.VarTypeId);

                                    var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理!(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                    //break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在获取界面变量时出错。{0}. (In {1})", ex.Message, clsStackTrace.GetCurrClassFunction());
                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //==============================================================

            //7、处理与查询区下拉框相关的静态变量
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Query = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            try
            {
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    var strVarName = "";
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        continue;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(objInfor.VarIdCond1) == false && objInfor.VarIdCond1 != "0"
                            && string.IsNullOrEmpty(objInfor.FldIdCond1) == false)
                        {
                            string strDefaValue = "";

                            //var objField = clsFieldTabBL.GetObjByFldIdCache(objInfor.FldIdCond1, objViewInfoENEx.PrjId);

                            var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objInfor.VarIdCond1);
                            strDefaValue = objGCVariable.ObjDataTypeAbbr().GetInitValue(enumProgLangType.TypeScript_09);
                            if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";

                            var myPubVar = new PubVarType();
                            myPubVar.FldName = objGCVariable.VarName;

                            switch (objGCVariable.VarTypeId)
                            {
                                case enumGCVariableType.GivingValue_0001:

                                    strVarName = string.Format("{0}Giving", objGCVariable.VarName);
                                    myPubVar.VarType = gcVarType.Giving;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "7、在查询区定义下拉框条件给定值2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.CacheClassifyField_0007:
                                    strVarName = string.Format("{0}Cache", objGCVariable.VarName);
                                    myPubVar.VarType = gcVarType.Cache;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "7、在查询区定义下拉框条件变量1";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.StaticValuable_0006:
                                    strVarName = string.Format("{0}Static", objGCVariable.VarName);

                                    myPubVar.VarType = gcVarType.Static;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "7、在查询区定义下拉框条件变量1";
                                    AddPubVarType(myPubVar);
                                    break;
                                case enumGCVariableType.DefaultValue_0002:
                                    break;
                                case enumGCVariableType.sessionStorage_0004:
                                    break;
                                case enumGCVariableType.localStorage_0003:
                                    break;

                                default:
                                    var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objGCVariable.VarTypeId);

                                    var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理!(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
                    clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                    //break;
                            }
                        }
                        if (string.IsNullOrEmpty(objInfor.VarIdCond2) == false && string.IsNullOrEmpty(objInfor.FldIdCond2) == false)
                        {
                            var objField = clsFieldTabBL.GetObjByFldIdCache(objInfor.FldIdCond2, objViewInfoENEx.PrjId);
                            string strDefaValue = objField.ObjDataTypeAbbr().GetInitValue(enumProgLangType.TypeScript_09);
                            if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";

                            var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objInfor.VarIdCond2);
                            var myPubVar = new PubVarType();
                            myPubVar.FldName = objField.FldName;

                            switch (objGCVariable.VarTypeId)
                            {
                                case enumGCVariableType.GivingValue_0001:

                                    strVarName = string.Format("{0}Giving", objField.FldName);

                                    myPubVar.VarType = gcVarType.Giving;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "7、在查询区定义下拉框条件给定值2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.CacheClassifyField_0007:

                                    strVarName = string.Format("{0}Cache", objField.FldName);
                                    myPubVar.VarType = gcVarType.Cache;
                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "7、在查询区定义下拉框条件变量2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.StaticValuable_0006:
                                    strVarName = string.Format("{0}Static", objField.FldName);
                                    myPubVar.VarType = gcVarType.Static;
                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "7、在查询区定义下拉框条件变量2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.sessionStorage_0004:
                                    break;
                                default:
                                    var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objGCVariable.VarTypeId);

                                    var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理!(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                    //break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在获取界面变量时出错。{0}. (In {1})", ex.Message, clsStackTrace.GetCurrClassFunction());
                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //==============================================================


            //8、处理与功能区下拉框相关的静态变量

            List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
            IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
            List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst.Select(GetDdlObj_PubVarType).Distinct(new ASPDropDownListEx4GCComparer()).ToList();


            try
            {
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    var strVarName = "";
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        continue;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(objInfor.VarIdCond1) == false
                            && string.IsNullOrEmpty(objInfor.FldIdCond1) == false)
                        {
                            string strDefaValue = "";

                            //var objField = clsFieldTabBL.GetObjByFldIdCache(objInfor.FldIdCond1, objViewInfoENEx.PrjId);

                            var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objInfor.VarIdCond1);
                            strDefaValue = objGCVariable.ObjDataTypeAbbr().GetInitValue(enumProgLangType.TypeScript_09);
                            if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";

                            var myPubVar = new PubVarType();
                            myPubVar.FldName = objGCVariable.VarName;

                            switch (objGCVariable.VarTypeId)
                            {
                                case enumGCVariableType.GivingValue_0001:

                                    strVarName = string.Format("{0}Giving", objGCVariable.VarName);
                                    myPubVar.VarType = gcVarType.Giving;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "8、在功能区定义下拉框条件给定值2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.CacheClassifyField_0007:
                                    strVarName = string.Format("{0}Cache", objGCVariable.VarName);
                                    myPubVar.VarType = gcVarType.Cache;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "8、在功能区定义下拉框条件变量1";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.StaticValuable_0006:
                                    strVarName = string.Format("{0}Static", objGCVariable.VarName);

                                    myPubVar.VarType = gcVarType.Static;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "8、在功能区定义下拉框条件变量1";
                                    AddPubVarType(myPubVar);
                                    break;
                                case enumGCVariableType.DefaultValue_0002:
                                    break;
                                case enumGCVariableType.sessionStorage_0004:
                                    break;
                                case enumGCVariableType.localStorage_0003:
                                    break;

                                default:
                                    var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objGCVariable.VarTypeId);

                                    var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理!(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
                    clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                    //break;
                            }
                        }
                        if (string.IsNullOrEmpty(objInfor.VarIdCond2) == false && string.IsNullOrEmpty(objInfor.FldIdCond2) == false)
                        {
                            var objField = clsFieldTabBL.GetObjByFldIdCache(objInfor.FldIdCond2, objViewInfoENEx.PrjId);
                            string strDefaValue = objField.ObjDataTypeAbbr().GetInitValue(enumProgLangType.TypeScript_09);
                            if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";

                            var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objInfor.VarIdCond2);
                            var myPubVar = new PubVarType();
                            myPubVar.FldName = objField.FldName;

                            switch (objGCVariable.VarTypeId)
                            {
                                case enumGCVariableType.GivingValue_0001:

                                    strVarName = string.Format("{0}Giving", objField.FldName);

                                    myPubVar.VarType = gcVarType.Giving;

                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "8、在功能区定义下拉框条件给定值2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.CacheClassifyField_0007:

                                    strVarName = string.Format("{0}Cache", objField.FldName);
                                    myPubVar.VarType = gcVarType.Cache;
                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "8、在功能区定义下拉框条件变量2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.StaticValuable_0006:
                                    strVarName = string.Format("{0}Static", objField.FldName);
                                    myPubVar.VarType = gcVarType.Static;
                                    myPubVar.VarName = strVarName;
                                    myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                                    myPubVar.IsStatic = true;
                                    myPubVar.IsNeedDefine = true;
                                    myPubVar.DefaultValue = strDefaValue;
                                    myPubVar.Memo = "8、在功能区定义下拉框条件变量2";
                                    AddPubVarType(myPubVar);

                                    break;
                                case enumGCVariableType.sessionStorage_0004:
                                    break;
                                default:
                                    var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objGCVariable.VarTypeId);

                                    var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理!(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                    //break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在获取界面变量时出错。{0}. (In {1})", ex.Message, clsStackTrace.GetCurrClassFunction());
                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //==============================================================


            //9、编辑区的界面变量--------------------------------------------
            if (objViewInfoENEx.objViewRegion_Edit != null)
            {
                var arrEditRegionFlds = objViewInfoENEx.arrEditRegionFldSet.Where(x => x.CtlTypeId == enumCtlType.ViewVariable_38);
                if (arrEditRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrEditRegionFlds)
                    {
                        string strVarName = "";
                        string strInitValue = "";
                        if (string.IsNullOrEmpty(objInFor.VarId) == true) continue;
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004) continue;
                            strVarName = objVar.GetVarName4View();
                            if (objInFor.ObjFieldTabENEx.TypeScriptType == "number")
                            {
                                strInitValue = objVar.InitValue;
                            }
                            else
                            {
                                strInitValue = string.Format("\"{0}\"", objVar.InitValue);
                            }
                            var myPubVar = new PubVarType();
                            myPubVar.FldName = objVar.VarName;
                            myPubVar.VarType = gcVarType.Static;
                            myPubVar.VarName = objVar.VarExpression;
                            myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, strVarName);
                            myPubVar.IsStatic = true;
                            myPubVar.IsNeedDefine = true;
                            myPubVar.DefaultValue = strInitValue;
                            myPubVar.Memo = "9、编辑区的界面变量--定义编辑区默认字段变量";
                            AddPubVarType(myPubVar);
                        }
                    }
                }
            }
            //10、与排序相关的界面变量--------------------------------------------
            clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

            if (objAdjustOrderNum != null && objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum != null)
            {
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {

                        string strInitValue = "\"\"";

                        //if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004) continue;
                        //strVarName = objVar.VarExpression;
                        //if (objInFor.ObjFieldTabENEx.TypeScriptType == "number")
                        //{
                        //    strInitValue = objVar.InitValue;
                        //}
                        //else
                        //{
                        //    strInitValue = string.Format("\"{0}\"", objVar.InitValue);
                        //}
                        var myPubVar = new PubVarType();
                        //myPubVar.FldName = objInFor.VarName;
                        myPubVar.VarType = gcVarType.Static;
                        //myPubVar.VarName = objInFor.VarName;

                        myPubVar.IsStatic = true;
                        myPubVar.IsNeedDefine = true;
                        myPubVar.DefaultValue = strInitValue;
                        myPubVar.Memo = "10、与排序相关的界面变量-分类变量";

                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            myPubVar.FldName = objInFor.VarName;
                            myPubVar.VarType = gcVarType.Static;
                            myPubVar.VarName = objInFor.VarName;
                            myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, myPubVar.VarName);
                        }
                        else
                        {
                            myPubVar.FldName = objInFor.CtrlId.Substring(2);
                            myPubVar.VarType = gcVarType.Static;
                            myPubVar.VarName = objInFor.CtrlId.Substring(3);
                            myPubVar.VarName4Get = string.Format("{0}.{1}", ThisClsName, myPubVar.VarName);

                        }
                        AddPubVarType(myPubVar);

                    }
                }
            }
            //return strCodeForCs.ToString();
        }
        public string GeneViewPubVarInVue(string strFuncName, CodeElement objCodeElement_Parent)
        {
            var arrpubVarTypes = pubVarTypes.OrderBy(x => x.FldName).OrderBy(x => x.VarType).ToArray();
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            var groupedByFldName = arrpubVarTypes.GroupBy(obj => obj.FldName);
            strCodeForCs.Append("\r\n" + "//界面公共变量，可以在多个相关界面中共享");

            foreach (var group in groupedByFldName)
            {
                Console.WriteLine("Group: " + group.Key);
                var groupSort = group.OrderBy(x => x.VarType);
                foreach (var obj in groupSort)
                {
                    if (obj.IsNeedDefine == false) continue;
                    // 对每个分类进行操作
                    //Console.WriteLine(" - " + obj.FldName + ": " + obj.Value);
                    if (obj.VarType == gcVarType.Object)
                    {
                        strCodeForCs.Append("\r\n" + $"export const {obj.VarName} = ref();//{obj.Memo}");
                        objCodeElement_Parent.Children.Add(new CodeElement
                        {
                            Name = $"{obj.VarName}",
                            ElementType = CodeElementType.RefConstant,
                            CodeContent = $"export const {obj.VarName} = ref();//{obj.Memo}"
                        });
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"export const {obj.VarName} = ref({obj.DefaultValue});//{obj.Memo}");
                        objCodeElement_Parent.Children.Add(new CodeElement
                        {
                            Name = $"{obj.VarName}",
                            ElementType = CodeElementType.RefConstant,
                            CodeContent = $"export const {obj.VarName} = ref({obj.DefaultValue});//{obj.Memo}"
                        });

                    }
                    //break;
                }
            }
            return strCodeForCs.ToString();
        }

        public string GeneViewPubVar_TS(string strFuncName)
        {
            var arrpubVarTypes = pubVarTypes.OrderBy(x => x.FldName).OrderBy(x => x.VarType).ToArray();
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            var groupedByFldName = arrpubVarTypes.GroupBy(obj => obj.FldName);

            foreach (var group in groupedByFldName)
            {
                Console.WriteLine("Group: " + group.Key);
                var groupSort = group.OrderBy(x => x.VarType);
                foreach (var obj in groupSort)
                {
                    if (obj.IsNeedDefine == false) continue;
                    // 对每个分类进行操作
                    //Console.WriteLine(" - " + obj.FldName + ": " + obj.Value);
                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1} = {2};//{3}",
                     obj.IsStatic ? "static" : "", obj.VarName, obj.DefaultValue, obj.Memo);
                    //break;
                }
            }
            return strCodeForCs.ToString();
        }
    }
}
