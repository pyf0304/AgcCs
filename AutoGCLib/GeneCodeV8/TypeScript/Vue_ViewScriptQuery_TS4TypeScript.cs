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
    /// <summary>
    /// 生成 Ai3 版本的查询字段规格 TypeScript 文件
    /// </summary>
    partial class Vue_ViewScriptQuery_TS4TypeScript : Vue_ViewScriptCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        public Vue_ViewScriptQuery_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            base.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

            strRe_ClsName = strRe_ClsName + "Ai3Query";
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}";

            var model = BuildQueryTemplateModel();
            
            string result = "";
            
            try
            {
                // 🔥 放入 try-catch 块
                result = _renderService.Render("TypeScript/Ai3Query.sbn", model);
            }
            catch (Exception ex)
            {
                // 详细的错误信息
                var errorMsg = $"模板渲染失败:\n" +
                              $"错误类型: {ex.GetType().Name}\n" +
                              $"错误消息: {ex.Message}\n" +
                              $"堆栈跟踪: {ex.StackTrace}";
                
                // 如果有内部异常，也打印出来
                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}\n" +
                               $"内部异常堆栈: {ex.InnerException.StackTrace}";
                }
                
                // 记录到日志文件
                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                
                // 输出到控制台
                Console.WriteLine(errorMsg);
                
                // 重新抛出异常，保留原始堆栈
                throw new InvalidOperationException($"渲染查询模板失败: {ex.Message}", ex);
            }
            
            // 调试：写入渲染结果
            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedQuery_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private Ai3QueryTemplateModel BuildQueryTemplateModel()
        {
            var model = new Ai3QueryTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                ModuleName = objFuncModuleEN.FuncModuleEnName
            };

            // 获取查询区域字段
            var arrQueryFields = objViewInfoENEx.arrQryRegionFldSet
                .Where(x => x.InUse == true)
                .OrderBy(x => x.SeqNum)
                .ToList();

            int currentRow = 1;
            int currentOrder = 1;

            foreach (var fld in arrQueryFields)
            {
                try
                {
                    var objPrjTabFld = fld.ObjPrjTabFld();
                    if (objPrjTabFld == null) continue;

                    var objFieldTab = objPrjTabFld.ObjFieldTab();
                    if (objFieldTab == null) continue;

                    // 确定控件类型
                    string controlType = GetControlType(fld.CtlTypeId);

                    // 🔥 确定选项数据源（WApi 类名）
                    string optionsKey = null;
                    string optionsWApiClass = null;
                    
                    if (fld.CtlTypeId == enumCtlType.DropDownList_06)
                    {
                        // 提取选项键和 WApi 类信息
                        var optionInfo = GetOptionsInfo(fld, objPrjTabFld);
                        optionsKey = optionInfo.Key;
                        optionsWApiClass = optionInfo.WApiClass;
                    }

                    var queryField = new Ai3QueryField
                    {
                        Key = ToCamelCase(objPrjTabFld.FldName()) + "_q",
                        Label = fld.LabelCaption ?? objFieldTab.FldCnName,
                        Id = GetControlId(fld.CtlTypeId, objPrjTabFld.FldName()),
                        ControlType = controlType,
                        Width = 120,
                        Row = currentRow,
                        Order = currentOrder,
                        OptionsKey = optionsKey,
                        OptionsWApiClass = optionsWApiClass,  // 🔥 新增
                        DefaultValue = GetDefaultValue(controlType, fld.CtlTypeId)
                    };

                    model.QueryFields.Add(queryField);

                    currentOrder++;
                    if (currentOrder > 4)
                    {
                        currentRow++;
                        currentOrder = 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"处理查询字段时出错: {ex.Message}");
                }
            }

            // 🔥 提取选项数据源信息（包含 WApi 类信息）
            ExtractOptionsInfo(model);

            return model;
        }

        /// <summary>
        /// 根据控件类型确定前端控件类型
        /// </summary>
        private string GetControlType(string ctlTypeId)
        {
            switch (ctlTypeId)
            {
                case enumCtlType.TextBox_16:
                    return "text";
                case enumCtlType.DropDownList_06:
                    return "select";
                case enumCtlType.CheckBox_02:
                    return "checkbox";
                case enumCtlType.RadioButton_14:
                    return "radio";
                default:
                    return "text";
            }
        }

        /// <summary>
        /// 获取选项信息（键名和 WApi 类名）
        /// </summary>
        private (string Key, string WApiClass) GetOptionsInfo(clsQryRegionFldsENEx fld, clsPrjTabFldEN objPrjTabFld)
        {
            var fldName = objPrjTabFld.FldName();
            
            // 根据字段名推断选项键和对应的 WApi 类
            if (fldName.EndsWith("TypeId"))
            {
                var baseName = fldName.Substring(0, fldName.Length - 6);
                var key = ToCamelCase(baseName) + "Type";
                var wApiClass = baseName + "Type";  // 如 DataBaseType
                return (key, wApiClass);
            }
            else if (fldName.EndsWith("StateId"))
            {
                var baseName = fldName.Substring(0, fldName.Length - 7);
                var key = ToCamelCase(baseName) + "State";
                var wApiClass = baseName + "State";  // 如 UseState
                return (key, wApiClass);
            }
            else if (fldName.EndsWith("Id"))
            {
                var baseName = fldName.Substring(0, fldName.Length - 2);
                var key = ToCamelCase(baseName);
                var wApiClass = baseName;
                return (key, wApiClass);
            }

            var defaultKey = ToCamelCase(fldName);
            return (defaultKey, fldName);
        }

        /// <summary>
        /// 生成控件ID
        /// </summary>
        private string GetControlId(string ctlTypeId, string fldName)
        {
            // 🔥 修复：使用传统 switch 语句替代 switch 表达式
            string prefix;
            switch (ctlTypeId)
            {
                case enumCtlType.TextBox_16:
                    prefix = "txt";
                    break;
                case enumCtlType.DropDownList_06:
                    prefix = "ddl";
                    break;
                case enumCtlType.CheckBox_02:
                    prefix = "chk";
                    break;
                case enumCtlType.RadioButton_14:
                    prefix = "rdo";
                    break;
                default:
                    prefix = "txt";
                    break;
            }

            return prefix + fldName + "_q";
        }

        /// <summary>
        /// 获取默认值
        /// </summary>
        private string GetDefaultValue(string controlType, string ctlTypeId)
        {
            if (controlType == "select")
            {
                return "0";  // 下拉框默认 "0"
            }
            else if (controlType == "checkbox")
            {
                return "false";
            }
            else
            {
                return "";  // 文本框默认空字符串
            }
        }

        /// <summary>
        /// 提取所有唯一的选项信息
        /// </summary>
        private void ExtractOptionsInfo(Ai3QueryTemplateModel model)
        {
            var uniqueOptions = model.QueryFields
                .Where(f => !string.IsNullOrEmpty(f.OptionsKey))
                .GroupBy(f => f.OptionsKey)
                .Select(g => new Ai3OptionsInfo
                {
                    Key = g.Key,
                    WApiClass = g.First().OptionsWApiClass
                })
                .ToList();

            model.OptionsInfo.AddRange(uniqueOptions);
        }

        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }
    }
}