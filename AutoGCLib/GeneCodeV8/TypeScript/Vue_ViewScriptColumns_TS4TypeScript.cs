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
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}";

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
                    // 🔥 跳过没有 ObjFieldTabENEx 的字段（与原代码一致）
                    if (fld.ObjFieldTabENEx == null) continue;

                    var objPrjTabFld = fld.ObjPrjTabFld();
                    
                    if (objPrjTabFld == null)
                    {
                        continue;
                    }

                    var fldName = objPrjTabFld.FldName();
                    var objFieldTab = objPrjTabFld.ObjFieldTab();
                    
                    // 🔥 确定字段名称（用于生成 con_XXX）
                    string fieldNameForConst;
                    bool isExtendField = false;
                    
                    // 判断是否是扩展字段（与原代码逻辑一致）
                    if (!string.IsNullOrEmpty(fld.DataPropertyName()))
                    {
                        // 有 DataPropertyName，使用扩展类
                        fieldNameForConst = fld.DataPropertyName4GC();
                        isExtendField = true;
                    }
                    else if (objPrjTabFld.IsForExtendClass)
                    {
                        // 标记为扩展类字段
                        fieldNameForConst = fldName;
                        isExtendField = true;
                    }
                    else
                    {
                        // 普通字段
                        fieldNameForConst = fldName;
                        isExtendField = false;
                    }

                    // 🔥 确定 sortBy
                    string sortBy;
                    if (!string.IsNullOrEmpty(fld.SortExpression))
                    {
                        // 使用明确指定的排序表达式
                        sortBy = fld.SortExpression_FstLcase(this.IsFstLcase);
                    }
                    else if (isExtendField)
                    {
                        // 扩展字段使用字段名
                        sortBy = ToCamelCase(fieldNameForConst);
                    }
                    else
                    {
                        // 普通字段使用字段名
                        sortBy = ToCamelCase(fldName);
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
                        // 🔥 修复：使用 InUse 判断是否包含在列表中
                        // InUse = true 表示字段启用，应该包含在列表定义中
                        // IsVisible 只控制前端是否显示，不影响列定义
                        IncludeInList = fld.InUse,
                        // 🔥 修复：所有启用的字段都应该可以导出（包括扩展字段）
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