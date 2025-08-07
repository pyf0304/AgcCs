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

namespace AutoGCLib
{
    public abstract partial class clsGeneCodeBase4Tab
    {
        /// <summary>
        /// 获取某WebApi 函数 的参数列表生成的字符串
        /// </summary>
        /// <param name="objFuncName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Tuple<string, string,string> thisWA_FP(WA_F objFuncName, string strProgLangType)
        {
            var objVarManage = new clsVarManage(strProgLangType);
            var strVariableType = "";
            string strParamVarDefLstStr = "";
            var strParamVarLst = "";
            var strParamVarLst_Cache = "";
            Tuple<string,string, string> result ;

            switch (objFuncName)
            {
                case WA_F.GetObjByKeyId_Cache:
                   
                    foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = objInFor.TypeScriptType; }
                        else { strVariableType = objInFor.CsType; }
                        objVarManage.AddVariable(new clsVariable(objInFor.PrivFuncName, strVariableType));
                    }
                    if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = thisCacheClassify_TS.TypeScriptType; }
                        else { strVariableType = thisCacheClassify_TS.CsType; }
                        objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName, strVariableType));
                    }
                    if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == true)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = thisCacheClassify_TS.TypeScriptType2; }
                        else { strVariableType = thisCacheClassify_TS.CsType2; }
                        objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName2, strVariableType));
                    }
                     strParamVarDefLstStr = objVarManage.ParaVarDefLstStr();
                     strParamVarLst = objVarManage.ParaVarLstStr();
                    strParamVarLst_Cache = objVarManage.ParaVarLstStr4Cache();

                    result = Tuple.Create<string, string, string>(strParamVarDefLstStr, strParamVarLst, strParamVarLst_Cache);
                    return result;
                case WA_F.GetRecNameByKeyCache:

                    foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = objInFor.TypeScriptType; }
                        else { strVariableType = objInFor.CsType; }
                        objVarManage.AddVariable(new clsVariable(objInFor.PrivFuncName, strVariableType));
                    }
                    if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = thisCacheClassify_TS.TypeScriptType; }
                        else { strVariableType = thisCacheClassify_TS.CsType; }
                        objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName, strVariableType));
                    }
                    if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == true)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = thisCacheClassify_TS.TypeScriptType2; }
                        else { strVariableType = thisCacheClassify_TS.CsType2; }
                        objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName2, strVariableType));
                    }
                    strParamVarDefLstStr = objVarManage.ParaVarDefLstStr();
                    strParamVarLst = objVarManage.ParaVarLstStr();
                    strParamVarLst_Cache = objVarManage.ParaVarLstStr4Cache();

                    result = Tuple.Create<string, string, string>(strParamVarDefLstStr, strParamVarLst, strParamVarLst_Cache);
                    return result;
                case WA_F.GetObjLst_Cache:
                    //return string.Format("{0}_GetObjLstCache", ThisTabName4GC);
                    if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = thisCacheClassify_TS.TypeScriptType; }
                        else { strVariableType = thisCacheClassify_TS.CsType; }
                        objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName, strVariableType));
                    }
                    if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == true)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = thisCacheClassify_TS.TypeScriptType2; }
                        else { strVariableType = thisCacheClassify_TS.CsType2; }
                        objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName2, strVariableType));
                    }

               
                     strParamVarDefLstStr = objVarManage.ParaVarDefLstStr();
                    strParamVarLst = objVarManage.ParaVarLstStr();
                    strParamVarLst_Cache = objVarManage.ParaVarLstStr4Cache();

                    result = Tuple.Create<string, string,string>(strParamVarDefLstStr, strParamVarLst, strParamVarLst_Cache);
                    return result;
                case WA_F.GetObjLst_CacheFromObjLst:
                    //return string.Format("{0}_GetObjLstCache", ThisTabName4GC);
                    if (thisCacheClassify_TS.IsHasCacheClassfyFld == true)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = thisCacheClassify_TS.TypeScriptType; }
                        else { strVariableType = thisCacheClassify_TS.CsType; }
                        objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName, strVariableType));
                    }
                    if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == true)
                    {
                        if (strProgLangType == "TypeScript") { strVariableType = thisCacheClassify_TS.TypeScriptType2; }
                        else { strVariableType = thisCacheClassify_TS.CsType2; }
                        objVarManage.AddVariable(new clsVariable(thisCacheClassify_TS.PriVarName2, strVariableType));
                    }
                    if (strProgLangType == "TypeScript")
                    {
                        strVariableType = string.Format("Array<cls{0}EN>", ThisTabName4GC);
                            }
                    else
                    {
                        strVariableType = string.Format("List<cls{0}EN>", ThisTabName4GC);
                    }
                    objVarManage.AddVariable(new clsVariable("arrObjLst_P", strVariableType));

                    strParamVarDefLstStr = objVarManage.ParaVarDefLstStr();
                    strParamVarLst = objVarManage.ParaVarLstStr();
                    strParamVarLst_Cache = objVarManage.ParaVarLstStr4Cache();

                    result = Tuple.Create<string, string, string>(strParamVarDefLstStr, strParamVarLst, strParamVarLst_Cache);
                    return result;

                //case WA_F.GetObjFromJsonObj:
                //    return string.Format("{0}_GetObjFromJsonObj", ThisTabName4GC);

                //case WA_F.GetObjByKeyId:
                //    if (objPrjTabENEx.arrKeyFldSet.Count > 1)
                //    {
                //        return string.Format($"{ThisTabName4GC}_GetObjByKeyLstAsync");
                //    }
                //    else
                //    {
                //        return string.Format($"{ThisTabName4GC}_GetObjBy{thisTabProp_TS.ByInFuncName}Async");
                //    }

                //case WA_F.ReFreshThisCache:
                //    return string.Format($"{ThisTabName4GC}_ReFreshThisCache");
                //case WA_F.ReFreshCache:
                //    return string.Format($"{ThisTabName4GC}_ReFreshCache");
                //case WA_F.GetObjLstByJSONObjLst:
                //    return string.Format($"{ThisTabName4GC}_GetObjLstByJSONObjLst");
                //case WA_F.GetSubObjLstCache:
                //    return string.Format($"{ThisTabName4GC}_GetSubObjLstCache");
                //case WA_F.GetObjLstAsync:

                //    return string.Format($"{ThisTabName4GC}_GetObjLstAsync");
                //case WA_F.GetObjLstsessionStorage:
                //    return string.Format($"{ThisTabName4GC}_GetObjLstsessionStorage");
                //case WA_F.GetObjLstlocalStorage:
                //    return string.Format($"{ThisTabName4GC}_GetObjLstlocalStorage");
                //case WA_F.GetObjLstClientCache:
                //    return string.Format($"{ThisTabName4GC}_GetObjLstClientCache");
                //case WA_F.GetObjLstsessionStoragePureCache:
                //    return string.Format($"{ThisTabName4GC}_GetObjLstsessionStoragePureCache");
                //case WA_F.GetObjLstlocalStoragePureCache:
                //    return string.Format($"{ThisTabName4GC}_GetObjLstlocalStoragePureCache");
                //case WA_F.SortFunByKey:
                //    return string.Format($"{ThisTabName4GC}_SortFunByKey");
                //case WA_F.JoinByKeyLst:
                //    return string.Format($"{ThisTabName4GC}_JoinByKeyLst");
                //case WA_F.GetUniCondStr:
                //    return string.Format($"{ThisTabName4GC}_GetUniCondStr");
                //case WA_F.GetUniCondStr4Update:
                //    return string.Format($"{ThisTabName4GC}_GetUniCondStr4Update");
                //case WA_F._CurrTabName:
                //    return string.Format($"{ThisClsName4EN}._CurrTabName");
                //case WA_F.DelRecordAsync:

                //    return string.Format($"{ThisTabName4GC}_DelRecordAsync");
                //case WA_F.DelRecKeyLstAsync:

                //    return string.Format($"{ThisTabName4GC}_DelRecKeyLstAsync");
                //case WA_F.GetMaxStrIdAsync:
                //    return string.Format($"{ThisTabName4GC}_GetMaxStrIdAsync");
                //case WA_F.GetMaxStrIdByPrefixAsync:
                //    return string.Format($"{ThisTabName4GC}_GetMaxStrIdByPrefixAsync");
                //case WA_F.DelMultiRecord:

                //    return string.Format($"{ThisTabName4GC}_Del{ThisTabName4GC}s");
                //case WA_F.DelMultiRecordAsync:
                //    return string.Format($"{ThisTabName4GC}_Del{ThisTabName4GC}sAsync");

                //case WA_F.DelMultiRecordByCond:

                //    return string.Format($"{ThisTabName4GC}_Del{ThisTabName4GC}sByCond");

                //case WA_F.DelMultiRecordByCondAsync:
                //    return string.Format($"{ThisTabName4GC}_Del{ThisTabName4GC}sByCondAsync");
                //case WA_F.DelRecKeyLstsAsync:
                //    return string.Format($"{ThisTabName4GC}_DelRecKeyLstsAsync");
                //case WA_F.GetObjLstByKeyLstAsync:
                //    return string.Format($"{ThisTabName4GC}_GetObjLstBy{objKeyField.FldName}LstAsync");
                //case WA_F.GetObjLstByKeyLstsCache://多关键字列表
                //    return string.Format($"{ThisTabName4GC}_GetObjLstByKeyLstsCache");
                //case WA_F.GetObjLstByKeyLstCache://单关键字列表
                //    return string.Format($"{ThisTabName4GC}_GetObjLstBy{objKeyField.FldName}LstCache");
                //case WA_F.GetObjLstByPagerCache://单关键字列表
                //    return string.Format($"{ThisTabName4GC}_GetObjLstByPagerCache");
                //case WA_F.GetRecCountByCondCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                //    return string.Format($"{ThisTabName4GC}_GetRecCountByCondCache");
                //case WA_F.CheckPropertyNew:
                //    return string.Format($"{ThisTabName4GC}_CheckPropertyNew");
                //case WA_F.CheckProperty4Update:
                //    return string.Format($"{ThisTabName4GC}_CheckProperty4Update");

                //case WA_F.AddNewRecordWithMaxIdAsync:
                //    return string.Format($"{ThisTabName4GC}_AddNewRecordWithMaxIdAsync");
                //case WA_F.IsExistRecordAsync:
                //    return string.Format($"{ThisTabName4GC}_IsExistRecordAsync");
                //case WA_F.GetRecCountByCondAsync:
                //    return string.Format($"{ThisTabName4GC}_GetRecCountByCondAsync");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }

        public string thisWAEx_FP(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format("{0}_GetObjFromJsonObj", ThisTabName4GC);
                case WA_F.GetObjLst_Cache:
                    ImportClass objImportClass = AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, "GetObjLstCache", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    return string.Format("{0}_GetObjLstCache", ThisTabName4GC);
                case WA_F.GetObjByKeyId:
                    return string.Format($"{ThisTabName4GC}_GetObjBy{thisTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{ThisTabName4GC}_GetObjBy{thisTabProp_TS.ByInFuncName}Cache");
                case WA_F.ReFreshThisCache:
                    return string.Format($"{ThisTabName4GC}_ReFreshThisCache");
                case WA_F.ReFreshCache:
                    return string.Format($"{ThisTabName4GC}_ReFreshCache");
                case WA_F.GetObjLstByJSONObjLst:
                    return string.Format($"{ThisTabName4GC}_GetObjLstByJSONObjLst");
                case WA_F.GetObjLstAsync:
                    ImportClass objImportClass2 = AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, "GetObjLstAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                    return string.Format($"{ThisTabName4GC}_GetObjLstAsync");
                case WA_F.GetObjLstsessionStorage:
                    return string.Format($"{ThisTabName4GC}_GetObjLstsessionStorage");
                case WA_F.GetObjLstlocalStorage:
                    return string.Format($"{ThisTabName4GC}_GetObjLstlocalStorage");
                case WA_F.GetObjLstClientCache:
                    return string.Format($"{ThisTabName4GC}_GetObjLstClientCache");
                case WA_F.GetObjLstsessionStoragePureCache:
                    return string.Format($"{ThisTabName4GC}_GetObjLstsessionStoragePureCache");
                case WA_F.GetObjLstlocalStoragePureCache:
                    return string.Format($"{ThisTabName4GC}_GetObjLstlocalStoragePureCache");
                case WA_F.SortFunByKey:
                    return string.Format($"{ThisTabName4GC}Ex_SortFunByKey");
                case WA_F.FuncMapByFldName:
                    return string.Format($"{ThisTabName4GC}Ex_FuncMapByFldName");
                case WA_F.GetObjLstByPagerCache://需要调用其他类中的分页函数
                    return string.Format($"{ThisTabName4GC}_GetObjLstByPagerCache");
                case WA_F.GetObjExLstByPagerCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                    return string.Format($"{ThisTabName4GC}Ex_GetObjExLstByPagerCache");
                case WA_F.GetObjExLstByPagerAsync://在本类中定义的分页函数,返回扩展对象列表
                    ImportClass objImportClass3 = AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("cls{0}EN", ThisTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                    return string.Format($"{ThisTabName4GC}Ex_GetObjExLstByPagerAsync");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }



    }
}
