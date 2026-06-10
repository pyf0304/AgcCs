using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using AutoGCLib.Templates;
using AGC.Entity;
using AGC.BusinessLogicEx;
using AGC.BusinessLogic;

namespace AutoGCLib
{
    partial class Vue_ViewScriptColumns_TS4TypeScript : Vue_ViewScriptCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        public Vue_ViewScriptColumns_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            base.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

            strRe_ClsName = strRe_ClsName + "AiColumns";
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}.ts";

            var model = BuildTemplateModel();
            
            // 渲染模板
            var result = _renderService.Render("TypeScript/Ai2Columns.sbn", model);
            
            // 调试：写入渲染结果
            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedTemplate_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);
            
            return result;
        }

        private AiColumnsTemplateModel BuildTemplateModel()
        {
            var model = new AiColumnsTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                HasExtendFields = objPrjTabEx_ListRegion?.arrExtendFldSet.Count > 0
            };

            // 🔥 关键：使用 arrListRegionFldSet 并正确排序
            var arrListFields = objViewInfoENEx.arrListRegionFldSet
                .OrderBy(x => x.SeqNum)
                .ToList();

            foreach (var fld in arrListFields)
            {
                try
                {
                    // 🔥 跳过没有 ObjFieldTabENEx 的字段
                    if (fld.ObjFieldTabENEx == null) continue;

                    var objPrjTabFld = fld.ObjPrjTabFld();
                    
                    if (objPrjTabFld == null)
                    {
                        continue;
                    }

                    var fldName = objPrjTabFld.FldName();
                    var objFieldTab = objPrjTabFld.ObjFieldTab();
                    
                    // 🔥 与 Gen_Vue_Ts_SortColumn 完全一致的判断逻辑
                    // 关键判断：OutFldId 不为空且不为 "0" 说明是扩展字段
                    bool isExtendField = !string.IsNullOrEmpty(fld.OutFldId) && fld.OutFldId != "0";
                    
                    // 🔥 确定字段名称（用于生成 con_XXX）
                    string fieldNameForConst;
                    
                    if (isExtendField)
                    {
                        // 扩展字段：使用 OutFldName 或 DataPropertyName
                        if (!string.IsNullOrEmpty(fld.DataPropertyName()))
                        {
                            fieldNameForConst = fld.DataPropertyName4GC();
                        }
                        else
                        {
                            fieldNameForConst = fld.OutFldName();
                        }
                    }
                    else
                    {
                        // 普通字段：使用 FldName
                        fieldNameForConst = fldName;
                    }

                    // 🔥 确定 sortBy - 与 Gen_Vue_Ts_SortColumn 一致
                    string sortBy;
                    if (!string.IsNullOrEmpty(fld.SortExpression))
                    {
                        // 使用明确指定的排序表达式
                        sortBy = fld.SortExpression_FstLcase(this.IsFstLcase);
                    }
                    else
                    {
                        sortBy = ToCamelCase(fieldNameForConst);
                    }
                    
                    // 🔥 关键修复：扩展字段统一添加 |Ex 后缀
                    // 参考 Gen_Vue_Ts_SortColumn 的逻辑：
                    // if (string.IsNullOrEmpty(objDGRegionFldsENEx.OutFldId) == true || objDGRegionFldsENEx.OutFldId == "0") continue;
                    // 即：OutFldId 不为空且不为 "0" 的字段才加 |Ex
                    if (isExtendField)
                    {
                        sortBy += "|Ex";
                    }

                    var field = new AiColumnField
                    {
                        Name = fieldNameForConst,
                        EntityClass = TabName_Out4ListRegion4GC,
                        ExSuffix = isExtendField ? "Ex" : "",
                        Source = isExtendField ? "related" : "entity",
                        Header = fld.HeaderText ?? objFieldTab?.FldCnName ?? "",
                        SortBy = sortBy,
                        TdClass = GetTdClassByDataType(objFieldTab?.DataTypeId ?? ""),
                        OrderNum = fld.SeqNum + 1,
                        IncludeInList = fld.InUse,
                        IncludeInExport = fld.InUse
                    };

                    model.Fields.Add(field);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"处理字段时出错: {ex.Message}");
                }
            }

            return model;
        }

        private string ToCamelCase(string fldName)
        {
            if (string.IsNullOrEmpty(fldName)) return fldName;
            return char.ToLower(fldName[0]) + fldName.Substring(1);
        }

        private string GetTdClassByDataType(string dataTypeId)
        {
            // 数值类型右对齐
            var numericTypes = new[] { 
                enumDataTypeAbbr.int_09,
                enumDataTypeAbbr.decimal_06,
                enumDataTypeAbbr.money_11,
                enumDataTypeAbbr.float_07,
                enumDataTypeAbbr.smallint_18,
                enumDataTypeAbbr.bigint_01
            };
            
            if (numericTypes.Contains(dataTypeId))
                return "text-right";

            // 日期类型居中
            var dateTypes = new[] {
                enumDataTypeAbbr.datetime_05 
            };
            
            if (dateTypes.Contains(dataTypeId))
                return "text-center";

            return "text-left";
        }
    }
}