using AGC.BusinessLogic;
using AGC.Entity;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGCLib
{
    public partial class  clsGeneCodeBase4View: clsGCBase
    {

        public string GetVueShareClsName()
        {
            string strClsName = string.Format("{0}VueShare", objViewInfoENEx.TabName);
            if (objViewInfoENEx.ViewName != $"{objViewInfoENEx.TabName}CRUD")
            {
                strClsName = string.Format("{0}VueShare", objViewInfoENEx.ViewName);
            }
           return strClsName;
        }

        public (string, bool) GC_WhereCondition(string strRegionTypeId, bool bolIsUse4Vue = false)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            var arrCacheMode0 = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
            var arrCacheMode1 = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
            string strIsShare = "";
            bool bolIsUseObjCond = false;
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            if (arrCacheMode1.Contains( PrjTabEx_ListRegion.CacheModeId) == true)
            {
                switch(strRegionTypeId)
                {
                    case enumRegionType.ListRegion_0002:
                        bolIsUseObjCond = true;
                        strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = await Combine{0}ConditionObj();", TabName_Out4ListRegion4GC);
                        if (bolIsUse4Vue == true)
                        {
                            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ListRegion4GC}ConditionObj4ExportExcel", enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        else
                        {
                            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{ThisClsName}.vue", $"Combine{TabName_Out4ListRegion4GC}ConditionObj4ExportExcel", enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        break;
                    case enumRegionType.ExcelExportRegion_0007:
                        bolIsUseObjCond = true;
                        strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = await Combine{0}ConditionObj4ExportExcel();", TabName_Out4ExportExcel4GC);
                        if (bolIsUse4Vue == true)
                        {
                            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel", enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        else
                        {
                            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{ThisClsName}.vue", $"Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel", enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        break;
                }
            }
            else
            {
                 switch(strRegionTypeId)
                {
                    case enumRegionType.ListRegion_0002:
                        strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = await Combine{0}Condition();", TabName_Out4ListRegion4GC);
                        if (bolIsUse4Vue == true)
                        {
                            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ListRegion4GC}Condition", enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        else
                        {
                            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{ThisClsName}.vue", $"Combine{TabName_Out4ListRegion4GC}Condition", enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        break;
                    case enumRegionType.ExcelExportRegion_0007:                        
                        strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = await Combine{0}Condition();", TabName_Out4ExportExcel4GC);
                        if (bolIsUse4Vue == true)
                        {
                            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ExportExcel4GC}Condition", enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        else
                        {
                            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{ThisClsName}.vue", $"Combine{TabName_Out4ExportExcel4GC}Condition", enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        break;
                }

            }
            return  (strCodeForCs.ToString(), bolIsUseObjCond);
        }

        public string GC_RecCount(string strRegionTypeId, string strCondFldLst_Cache, bool bolIsForVue = false)
        {
            var arrCacheMode0 = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
            //var arrCacheMode1 = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };

            StringBuilder strCodeForCs = new StringBuilder();
            if (arrCacheMode0.Contains(PrjTabEx_ListRegion.CacheModeId) == true)
            {
                switch(strRegionTypeId)
                {
                    case enumRegionType.ListRegion_0002:
                        strCodeForCs.Append("\r\n" + $"this.recCount = await {thisWA_F_InList(WA_F.GetRecCountByCondCache)}(obj{TabName_Out4ListRegion4GC}Cond {strCondFldLst_Cache});");
                        ImportClass objImportClass = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("GetRecCountByCondCache", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        break;
                    case enumRegionType.ExcelExportRegion_0007:
                        strCodeForCs.Append("\r\n" + $"this.recCount = await {thisWA_F_InExportExcel(WA_F.GetRecCountByCondCache)}(obj{TabName_Out4ExportExcel4GC}Cond {strCondFldLst_Cache});");
                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "if (this.recCount == 0)", TabName_Out4ListRegion4GC);
                strCodeForCs.Append("\r\n" + "{");
                switch (strRegionTypeId)
                {
                    case enumRegionType.ListRegion_0002:
                        strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
                        strCodeForCs.AppendFormat("\r\n" + "lblMsg.innerHTML = Format(\"根据条件:[{{0}}]获取的对象列表数为0!\", obj{0}Cond.whereCond);", TabName_Out4ListRegion4GC);
                        //strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById(\"divDataLst\");");
                        if (bolIsForVue == false)
                        {
                            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
                            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
                            strCodeForCs.Append("\r\n" + "}");
                        }
                        strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在绑定GvCache过程中,根据条件:[{{0}}]获取的对象列表数为0!\", obj{0}Cond.whereCond);", TabName_Out4ListRegion4GC);
                        break;

                    case enumRegionType.ExcelExportRegion_0007:
                        strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在绑定GvCache过程中,根据条件:[{{0}}]获取的对象列表数为0!\", obj{0}Cond.whereCond);", TabName_Out4ExportExcel4GC);
                        break;
                }
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                if (strRegionTypeId != enumRegionType.ExcelExportRegion_0007)
                {
                    strCodeForCs.Append("\r\n" + $"BindTabByList(arr{TabName_Out4ListRegion4GC}ExObjLst, true);");
                    strCodeForCs.Append("\r\n" + "return;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
                }
                strCodeForCs.Append("\r\n" + "}");

            }
            else
            {
                switch (strRegionTypeId)
                {
                    case enumRegionType.ListRegion_0002:
                        strCodeForCs.Append("\r\n" + $"this.recCount = await {thisWA_F_InList(WA_F.GetRecCountByCondAsync)}(strWhereCond);");
                        break;
                    case enumRegionType.ExcelExportRegion_0007:
                        strCodeForCs.Append("\r\n" + $"this.recCount = await {thisWA_F_InExportExcel(WA_F.GetRecCountByCondAsync)}(strWhereCond);");

                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "if (this.recCount == 0)", TabName_Out4ListRegion4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
                strCodeForCs.Append("\r\n" + "lblMsg.innerHTML = Format(\"根据条件:[{0}]获取的对象列表数为0!\", strWhereCond);");
                //strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divDataLst\");");
                if (strRegionTypeId == enumRegionType.ListRegion_0002 && bolIsForVue == false)
                {
                    strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
                    strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"在绑定Gv过程中,根据条件:[{0}]获取的对象列表数为0!\", strWhereCond);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                if (strRegionTypeId != enumRegionType.ExcelExportRegion_0007)
                {
                    strCodeForCs.Append("\r\n" + $"BindTabByList(arr{TabName_Out4ListRegion4GC}ExObjLst, true);");
                    strCodeForCs.Append("\r\n" + "return;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
                }
                strCodeForCs.Append("\r\n" + "}");

            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 获取满足条件的对象列表
        /// </summary>
        /// <returns></returns>
        public string GC_GetObjExLst(string strRegionTypeId, string strCondFldLst_Cache, bool bolIsUseObjCond)
        {
            var arrCacheMode0 = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
            //var arrCacheMode1 = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };

            StringBuilder strCodeForCs = new StringBuilder();
            if (arrCacheMode0.Contains(PrjTabEx_ListRegion.CacheModeId) == true)
            {
                switch (strRegionTypeId)
                {
                    case enumRegionType.ListRegion_0002:
                        strCodeForCs.Append("\r\n" + "let strSortFun = (x: any, y: any) => { console.log(x,y); return 0};");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.sortFunStatic != undefined)", ThisClsName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "strSortFun = {0}.sortFunStatic(viewVarSet.ascOrDesc4SortFun);", ThisClsName);
                        strCodeForCs.Append("\r\n" + "}");

                        strCodeForCs.Append("\r\n" + "const objPagerPara: stuPagerPara = {");
                        strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
                        strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
                        strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
                        if (bolIsUseObjCond) strCodeForCs.Append("\r\n" + $"conditionCollection: obj{TabName_Out4ListRegion4GC}Cond,");
                        strCodeForCs.AppendFormat("\r\n" + "orderBy: viewVarSet.sort{0}By,", TabName_Out4ListRegion4GC, ThisClsName);
                        strCodeForCs.Append("\r\n" + "sortFun: strSortFun");
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + $"arr{TabName_Out4ListRegion4GC}ExObjLst = await {thisWA_F_InList(WA_F.GetObjExLstByPagerCache)}(objPagerPara {strCondFldLst_Cache});");
                        break;
                    case enumRegionType.ExcelExportRegion_0007:
                        if (IsUseFunc4ExcelExport == true)
                        {
                            strCodeForCs.Append("\r\n" + $"const arr{TabName_Out4ExportExcel4GC}ObjLst = await {thisWA_F_InExportExcel(WA_F.GetSubObjLstCache)}(obj{TabName_Out4ExportExcel4GC}Cond {strCondFldLst_Cache});");
                            strCodeForCs.Append("\r\n" + $"arr{TabName_Out4ExportExcel4GC}ExObjLst = arr{TabName_Out4ExportExcel4GC}ObjLst.map({thisWA_F_InExportExcel(WA_F.CopyToEx)});");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"arr{TabName_Out4ExportExcel4GC}ObjLst = await {thisWA_F_InExportExcel(WA_F.GetSubObjLstCache)}(obj{TabName_Out4ExportExcel4GC}Cond {strCondFldLst_Cache});");
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (strRegionTypeId)
                {
                    case enumRegionType.ListRegion_0002:

                        strCodeForCs.Append("\r\n" + "const objPagerPara: stuPagerPara = {");
                        strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
                        strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
                        strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
                        strCodeForCs.AppendFormat("\r\n" + "orderBy: viewVarSet.sort{0}By,//如果该字段为空,就使用下面的排序函数", TabName_Out4ListRegion4GC, ThisClsName);
                        strCodeForCs.Append("\r\n" + "sortFun: (x, y) => { console.log(x,y);return 0;}");

                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + $"arr{TabName_Out4ListRegion4GC}ExObjLst = await {thisWA_F_InList(WA_F.GetObjExLstByPagerAsync)}(objPagerPara);");
                        break;
                    case enumRegionType.ExcelExportRegion_0007:
                        if (IsUseFunc4ExcelExport == true)
                        {
                            strCodeForCs.Append("\r\n" + $"const arr{TabName_Out4ExportExcel4GC}ObjLst = await {thisWA_F_InExportExcel(WA_F.GetObjLstAsync)}(strWhereCond);");
                            strCodeForCs.Append("\r\n" + $"arr{TabName_Out4ExportExcel4GC}ExObjLst = arr{TabName_Out4ExportExcel4GC}ObjLst.map({thisWA_F_InExportExcel(WA_F.CopyToEx)});");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"arr{TabName_Out4ExportExcel4GC}ObjLst = await {thisWA_F_InExportExcel(WA_F.GetObjLstAsync)}(strWhereCond);");
                        }
                        break;

                }
            }
            return strCodeForCs.ToString();
        }

        public string GC_Sam()
        {
            var arrCacheMode0 = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
            //var arrCacheMode1 = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };

            StringBuilder strCodeForCs = new StringBuilder();
            if (arrCacheMode0.Contains(PrjTabEx_ListRegion.CacheModeId) == true)
            {
            }
            else
            {

            }

            return strCodeForCs.ToString();
        }

       

        //public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        //{
        //    throw new NotImplementedException();
        //}

        //public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    throw new NotImplementedException();
        //}

        //public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        //{
        //    throw new NotImplementedException();
        //}

        //public override void GetClsName()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
