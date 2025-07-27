using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.common;


namespace AutoGCLib
{
    public abstract partial class clsGeneCodeBase4View
    {

        public string thisWA_FP_InEdit(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{TabName_In4Edit4GC}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{TabName_In4Edit4GC}_GetObjLstCache");
                case WA_F.GetObjByKeyId:
                    ImportClass objImportClass = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, string.Format("GetObjBy{0}Async", thisEditTabProp_TS.ByInFuncName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    return string.Format($"{TabName_In4Edit4GC}_GetObjBy{thisEditTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{TabName_In4Edit4GC}_GetObjBy{thisEditTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetUniCondStr:
                    return string.Format($"{TabName_In4Edit4GC}_GetUniCondStr");
                case WA_F.GetUniCondStr4Update:
                    return string.Format($"{TabName_In4Edit4GC}_GetUniCondStr4Update");
                case WA_F.GetMaxStrIdAsync:
                    ImportClass objImportClass2 = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "GetMaxStrIdAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                    return string.Format($"{TabName_In4Edit4GC}_GetMaxStrIdAsync");
                case WA_F.GetMaxStrIdByPrefixAsync:
                    ImportClass objImportClass3 = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "GetMaxStrIdByPrefixAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                    return string.Format($"{TabName_In4Edit4GC}_GetMaxStrIdByPrefixAsync");
                case WA_F.AddNewRecordAsync:
                    ImportClass objImportClass4 = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "AddNewRecordAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

                    return string.Format($"{TabName_In4Edit4GC}_AddNewRecordAsync");
                case WA_F.UpdateRecordAsync:
                    ImportClass objImportClass5 = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "UpdateRecordAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);

                    return string.Format($"{TabName_In4Edit4GC}_UpdateRecordAsync");
                case WA_F.CheckPropertyNew:
                    ImportClass objImportClass6 = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "CheckPropertyNew", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import6 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass6);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import6);

                    return string.Format($"{TabName_In4Edit4GC}_CheckPropertyNew");

                case WA_F.CheckProperty4Update:
                    ImportClass objImportClass7 = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "CheckProperty4Update", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import7 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass7);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import7);

                    return string.Format($"{TabName_In4Edit4GC}_CheckProperty4Update");

                case WA_F.AddNewRecordWithMaxIdAsync:
                    ImportClass objImportClass8 = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "AddNewRecordWithMaxIdAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import8 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass8);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import8);

                    return string.Format($"{TabName_In4Edit4GC}_AddNewRecordWithMaxIdAsync");
                case WA_F.IsExistRecordAsync:
                    ImportClass objImportClass9 = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "IsExistRecordAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import9 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass9);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import9);

                    return string.Format($"{TabName_In4Edit4GC}_IsExistRecordAsync");
                case WA_F.IsExistAsync:
                    ImportClass objImportClassA = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, "IsExistAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportA = clsPubFun4GC.GetCodeElementByImportClass(objImportClassA);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportA);

                    return string.Format($"{TabName_In4Edit4GC}_IsExistAsync");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }
        public string thisWA_FP_InView(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{ViewMainTabName4GC}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{ViewMainTabName4GC}_GetObjLstCache");
                case WA_F.GetObjByKeyId:
                    return string.Format($"{ViewMainTabName4GC}_GetObjBy{thisViewTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{ViewMainTabName4GC}_GetObjBy{thisExcelExportTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetObjLstByJSONObjLst:
                    return string.Format($"{ViewMainTabName4GC}_GetObjLstByJSONObjLst");
                case WA_F.GetObjLstAsync:
                    return string.Format($"{ViewMainTabName4GC}_GetObjLstAsync");
                case WA_F.GetRecCountByCondAsync:
                    return string.Format($"{ViewMainTabName4GC}_GetRecCountByCondAsync");
                case WA_F.DelRecKeyLstAsync:
                    ImportClass objImportClass = AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("DelRecKeyLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    return string.Format($"{ViewMainTabName4GC}_DelRecKeyLstAsync");
                case WA_F.DelRecordAsync:
                    ImportClass objImportClass2 = AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("DelRecordAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                    return string.Format($"{ViewMainTabName4GC}_DelRecordAsync");
                case WA_F.GoBottomAsync:
                    ImportClass objImportClass3 = AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("GoBottomAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                    return string.Format($"{ViewMainTabName4GC}_GoBottomAsync");
                case WA_F.GoTopAsync:
                    ImportClass objImportClass4 = AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("GoTopAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

                    return string.Format($"{ViewMainTabName4GC}_GoTopAsync");
                case WA_F.ReOrderAsync:
                    ImportClass objImportClass5 = AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("ReOrderAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);

                    return string.Format($"{ViewMainTabName4GC}_ReOrderAsync");
                case WA_F.DownMoveAsync:
                    ImportClass objImportClass6 = AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("DownMoveAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import6 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass6);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import6);

                    return string.Format($"{ViewMainTabName4GC}_DownMoveAsync");
                case WA_F.UpMoveAsync:
                    ImportClass objImportClass7 = AddImportClass(ViewMainTabId4GC, ViewMainTabName4GC, string.Format("UpMoveAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import7 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass7);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import7);

                    return string.Format($"{ViewMainTabName4GC}_UpMoveAsync");


                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }
        public string thisWA_FP_InList(WA_F objFuncName)
        {
            string strTabName_Copy = TabName_Out4ListRegion4GC;
            string strTabId_Copy = TabId_Out4ListRegion;

            if (objPrjTabEx_ListRegion.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                if (strTabName_Copy.Substring(0, 1) != "v")
                {
                    string strMsg = $"界面列表区的表名：{strTabName_Copy}，起始字符不是'v'，请修正！";
                    throw new Exception(strMsg);
                }
                strTabName_Copy = strTabName_Copy.Substring(1);
                var objPrjTab = clsPrjTabBLEx.GetObjByTabNameExCache(objViewInfoENEx.PrjId, strTabName_Copy);
                if (objPrjTab == null)
                {
                    string strMsg = $"界面列表区的视图名的相关表名：{strTabName_Copy}在数据库中不存在，请检查！";
                    throw new Exception(strMsg);
                }
                strTabId_Copy = objPrjTab.TabId;

            }
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstCache");
                case WA_F.GetSubObjLstCache:
                    ImportClass objImportClass = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("GetSubObjLstCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    return string.Format($"{TabName_Out4ListRegion4GC}_GetSubObjLstCache");
                case WA_F.GetObjByKeyLstAsync:
                    ImportClass objImportClass2 = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("GetObjByKeyLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjByKeyLstAsync");

                case WA_F.GetObjByKeyId:
                    ImportClass objImportClass3 = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format($"GetObjBy{thisListTabProp_TS.ByInFuncName}Async"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjBy{thisListTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjBy{thisListTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetObjLstByJSONObjLst:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstByJSONObjLst");
                case WA_F.GetObjLstAsync:
                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstAsync");
                case WA_F.GetRecCountByCondAsync:
                    ImportClass objImportClass4 = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, "GetRecCountByCondAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);


                    return string.Format($"{TabName_Out4ListRegion4GC}_GetRecCountByCondAsync");

                case WA_F.DelRecordAsync:
                    ImportClass objImportClass5 = AddImportClass(strTabId_Copy, strTabName_Copy, string.Format("DelRecordAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);


                    return string.Format($"{strTabName_Copy}_DelRecordAsync");
                case WA_F.DelRecKeyLstAsync:
                    ImportClass objImportClass6 = AddImportClass(strTabId_Copy, strTabName_Copy, string.Format("DelRecKeyLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import6 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass6);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import6);


                    return string.Format($"{strTabName_Copy}_DelRecKeyLstAsync");
                case WA_F.GetObjLstByPagerAsync:
                    ImportClass objImportClass7 = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("GetObjLstByPagerAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import7 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass7);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import7);


                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstByPagerAsync");
                case WA_F.DelMultiRecordAsync:
                    ImportClass objImportClass8 = AddImportClass(strTabId_Copy, strTabName_Copy, string.Format($"Del{strTabName_Copy}sAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import8 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass8);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import8);

                    return string.Format($"{strTabName_Copy}_Del{strTabName_Copy}sAsync");

                case WA_F.DelMultiRecordByCondAsync:
                    ImportClass objImportClass9 = AddImportClass(strTabId_Copy, strTabName_Copy, string.Format($"Del{strTabName_Copy}sByCondAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import9 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass9);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import9);

                    return string.Format($"{strTabName_Copy}_Del{strTabName_Copy}sByCondAsync");

                case WA_F.DelRecKeyLstsAsync:
                    ImportClass objImportClassA = AddImportClass(strTabId_Copy, strTabName_Copy, string.Format($"DelRecKeyLstsAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportA = clsPubFun4GC.GetCodeElementByImportClass(objImportClassA);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportA);

                    return string.Format($"{strTabName_Copy}_DelRecKeyLstsAsync");
                case WA_F.FuncMapByFldName:
                    ImportClass objImportClassB = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", "FuncMapByFldName", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportB = clsPubFun4GC.GetCodeElementByImportClass(objImportClassB);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportB);

                    return string.Format($"{TabName_Out4ListRegion4GC}Ex_FuncMapByFldName");
                case WA_F.GetMaxStrIdAsync:
                    ImportClass objImportClassC = AddImportClass(strTabId_Copy, strTabName_Copy, "GetMaxStrIdAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportC = clsPubFun4GC.GetCodeElementByImportClass(objImportClassC);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportC);

                    return string.Format($"{strTabName_Copy}_GetMaxStrIdAsync");
                case WA_F.GetMaxStrIdByPrefixAsync:
                    ImportClass objImportClassD = AddImportClass(TabId_Out4ListRegion, strTabName_Copy, "GetMaxStrIdByPrefixAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportD = clsPubFun4GC.GetCodeElementByImportClass(objImportClassD);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportD);

                    return string.Format($"{strTabName_Copy}_GetMaxStrIdByPrefixAsync");

                case WA_F.AddNewRecordAsync:
                    ImportClass objImportClassE = AddImportClass(strTabId_Copy, strTabName_Copy, "AddNewRecordAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportE = clsPubFun4GC.GetCodeElementByImportClass(objImportClassE);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportE);

                    return string.Format($"{strTabName_Copy}_AddNewRecordAsync");
                case WA_F.GetObjLstByKeyLstAsync:
                    ImportClass objImportClassF = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format($"GetObjLstBy{objKeyField.FldName}LstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportF = clsPubFun4GC.GetCodeElementByImportClass(objImportClassF);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportF);

                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstBy{objKeyField.FldName}LstAsync");

                case WA_F.GetObjLstByKeyLstAsync_SqlTab:
                    ImportClass objImportClassG = AddImportClass(strTabId_Copy, strTabName_Copy, string.Format($"GetObjLstBy{objKeyField.FldName}LstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportG = clsPubFun4GC.GetCodeElementByImportClass(objImportClassG);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportG);

                    return string.Format($"{strTabName_Copy}_GetObjLstBy{objKeyField.FldName}LstAsync");

                case WA_F.GetObjLstByPagerCache://单关键字列表
                    ImportClass objImportClassH = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format($"GetObjLstByPagerCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportH = clsPubFun4GC.GetCodeElementByImportClass(objImportClassH);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportH);

                    return string.Format($"{TabName_Out4ListRegion4GC}_GetObjLstByPagerCache");
                case WA_F.GetObjExLstByPagerCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                    ImportClass objImportClassI = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", string.Format($"GetObjExLstByPagerCache"), enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportI = clsPubFun4GC.GetCodeElementByImportClass(objImportClassI);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportI);

                    return string.Format($"{TabName_Out4ListRegion4GC}Ex_GetObjExLstByPagerCache");
                case WA_F.GetObjExLstByPagerAsync://在本类中定义的分页函数,返回扩展对象列表,Cache
                    ImportClass objImportClassJ = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", string.Format($"GetObjExLstByPagerAsync"), enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportJ = clsPubFun4GC.GetCodeElementByImportClass(objImportClassJ);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportJ);

                    return string.Format($"{TabName_Out4ListRegion4GC}Ex_GetObjExLstByPagerAsync");

                case WA_F.GetRecCountByCondCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                    ImportClass objImportClassK = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format($"GetRecCountByCondCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportK = clsPubFun4GC.GetCodeElementByImportClass(objImportClassK);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportK);

                    return string.Format($"{TabName_Out4ListRegion4GC}_GetRecCountByCondCache");
                case WA_F.CopyToEx:
                    ImportClass objImportClassL = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", "CopyToEx", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportL = clsPubFun4GC.GetCodeElementByImportClass(objImportClassL);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportL);

                    return string.Format($"{TabName_Out4ListRegion4GC}Ex_CopyToEx");
                case WA_F.SortFunDefa:
                    ImportClass objImportClassM = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, "SortFunDefa", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_ImportM = clsPubFun4GC.GetCodeElementByImportClass(objImportClassM);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_ImportM);

                    return string.Format($"{TabName_Out4ListRegion4GC}_SortFunDefa");


                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }


        public string thisWA_FP_InExportExcel(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjLstCache");
                case WA_F.GetSubObjLstCache:
                    ImportClass objImportClass = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("GetSubObjLstCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    return string.Format($"{TabName_Out4ExportExcel}_GetSubObjLstCache");

                case WA_F.GetObjByKeyId:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjBy{thisExcelExportTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjBy{thisExcelExportTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetObjLstByJSONObjLst:
                    return string.Format($"{TabName_Out4ExportExcel}_GetObjLstByJSONObjLst");
                case WA_F.GetObjLstAsync:
                    ImportClass objImportClass2 = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("GetObjLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);


                    return string.Format($"{TabName_Out4ExportExcel}_GetObjLstAsync");
                case WA_F.GetRecCountByCondAsync:
                    ImportClass objImportClass3 = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("GetRecCountByCondAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);


                    return string.Format($"{TabName_Out4ExportExcel}_GetRecCountByCondAsync");
                case WA_F.GetRecCountByCondCache://在本类中定义的分页函数,返回扩展对象列表,Cache
                    ImportClass objImportClass4 = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format($"GetRecCountByCondCache"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

                    return string.Format($"{TabName_Out4ExportExcel4GC}_GetRecCountByCondCache");
                case WA_F.CopyToEx:
                    ImportClass objImportClass5 = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC + "Ex", "CopyToEx", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);

                    return string.Format($"{TabName_Out4ExportExcel4GC}Ex_CopyToEx");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }

        public string thisWA_FP_InDetail(WA_F objFuncName)
        {
            switch (objFuncName)
            {
                case WA_F.FldId:
                    return "FldId";
                case WA_F.GetObjFromJsonObj:
                    return string.Format($"{TabName_Out4DetailRegion}_GetObjFromJsonObj");
                case WA_F.GetObjLst_Cache:
                    return string.Format($"{TabName_Out4DetailRegion}_GetObjLstCache");
                case WA_F.GetObjByKeyId:
                    ImportClass objImportClass = AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion, string.Format("GetObjBy{0}Async", thisDetailTabProp_TS.ByInFuncName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    return string.Format($"{TabName_Out4DetailRegion}_GetObjBy{thisDetailTabProp_TS.ByInFuncName}Async");
                case WA_F.GetObjByKeyId_Cache:
                    return string.Format($"{TabName_Out4DetailRegion}_GetObjBy{thisDetailTabProp_TS.ByInFuncName}Cache");
                case WA_F.GetObjByKeyLstAsync:
                    ImportClass objImportClass2 = AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion, string.Format("GetObjByKeyLstAsync"), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                    return string.Format($"{TabName_Out4DetailRegion}_GetObjByKeyLstAsync");
                case WA_F.FuncMapByFldName:
                    ImportClass objImportClass3 = AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion + "Ex", "FuncMapByFldName", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                    return string.Format($"{TabName_Out4DetailRegion}Ex_FuncMapByFldName");
                case WA_F.IsExistAsync:
                    ImportClass objImportClass4 = AddImportClass(TabId_Out4DetailRegion, TabName_Out4DetailRegion, "IsExistAsync", enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

                    return string.Format($"{TabName_Out4DetailRegion}_IsExistAsync");

                default:
                    string strMsg = string.Format($"类型:{objFuncName}在Switch中没有被处理.(in {clsStackTrace.GetCurrClassFunction()})");
                    throw new Exception(strMsg);
            }
        }
    }
}
