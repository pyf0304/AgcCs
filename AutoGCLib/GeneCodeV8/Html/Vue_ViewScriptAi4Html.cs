using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AutoGCLib.Templates;
using com.taishsoft.common;
using LaYumba.Functional;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 生成 Ai 版本的 Vue HTML 模板文件（.vue 文件）
    /// 包含 template、script 和 style 三部分
    /// 使用 Scriban 模板引擎实现代码与模板分离
    /// </summary>
    partial class Vue_ViewScriptAi4Html : clsGeneCodeBase4View
    {
        private clsFuncModule_AgcEN objFuncModule = null;
        private readonly RenderService _renderService;

        public Vue_ViewScriptAi4Html(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //base.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            objViewInfoENEx.WebFormName = string.Format("{0}Ai", ThisClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}Ai.vue",
                objViewInfoENEx.FolderName, ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;            
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModuleEN, objViewInfoENEx);
                        
            // 修改文件扩展名为 .vue
            objViewInfoENEx.WebFormFName = string.Format("{0}.vue", strRe_ClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            var model = BuildAiHtmlTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/AiHtml.sbn", model);
                
                // 🔥 后处理:替换占位符为界面变量初始化代码
                if (!string.IsNullOrEmpty(model.ViewVariablesInitCode))
                {
                    result = result.Replace("/*__VIEW_VARIABLES_INIT_CODE__*/", model.ViewVariablesInitCode);
                }
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n错误: {ex.Message}\n堆栈: {ex.StackTrace}";
                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderAiHtmlError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染AiHtml模板失败: {ex.Message}", ex);
            }

            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedAiHtml_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private ListAiHtmlTemplateModel BuildAiHtmlTemplateModel()
        {
            var model = new ListAiHtmlTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameCamel = ToCamelCase(TabName_Out4ListRegion4GC),
                TableCnName = TabCnName_In4Edit4GC,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                KeyField = objKeyField.FldName(),
                KeyFieldCamel = ToCamelCase(objKeyField.FldName()),
                ViewTitle = $"{TabCnName_In4Edit4GC}维护(Ai版-命令Schema)",
                strIsShare = objViewInfoENEx.IsShare ? "Share" : ""
            };

            // 🔥 判断是否有详细信息功能
            model.HasDetailFeature = objViewInfoENEx.arrDetailRegionFldSet4InUse != null &&
                                     objViewInfoENEx.arrDetailRegionFldSet4InUse.Count > 0;

            //model.HasExportFeature = objViewInfoENEx.arrExcelExportRegionFldSet != null &&
            //                         objViewInfoENEx.arrExcelExportRegionFldSet.Count > 0;

            // 提取查询字段
            ExtractQueryFields(model);


            // 🔥 新增：提取功能区下拉框选项信息
            ExtractFeatureOptions(model);
            ExtractFeatureOptions4DS(model);

            // 提取功能按钮
            ExtractFeatureCommands(model);

            // 🔥 提取设置字段值功能的字段变量名
            ExtractSetFieldVariables(model);

            // 🔥 新增：提取界面变量（ViewIdGCVariableRela）
            ExtractViewVariables(model);

            return model;
        }

        /// <summary>
        /// 🔥 新增：提取界面变量信息
        /// 从 ViewIdGCVariableRela 关联中获取需要在界面初始化的变量
        /// 例如：ProgLangTypeId_Static, CodeTypeId_Static, FunctionTemplateId_Static
        /// 这些变量需要从 VueShare 文件导入
        /// </summary>
        private void ExtractViewVariables(ListAiHtmlTemplateModel model)
        {
            try
            {
                var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBLEx.GetObjLstByViewId(
                    objViewInfoENEx.ViewId, 
                    objViewInfoENEx.PrjId
                );

                if (arrViewIdGCVariableRela != null && arrViewIdGCVariableRela.Count > 0)
                {
                    var viewVariables = new List<ViewVariableDetail>();
                    var vueShareVariables = new List<string>();
                    var initCodeBuilder = new StringBuilder();

                    Console.WriteLine($"=== 开始提取界面变量 (共 {arrViewIdGCVariableRela.Count} 个) ===");

                    // 🔥 检查是否需要 userStore、route 或 sessionStorage
                    bool needsUserStore = false;
                    bool needsRoute = false;
                    bool needsSessionStorage = false;

                    foreach (var varRela in arrViewIdGCVariableRela)
                    {
                        var objGCVariable = clsGCVariableBLEx.GetObjByVarIdCache(varRela.VarId);

                        if (objGCVariable != null)
                        {
                            string varName4View = objGCVariable.GetVarName4View();

                            Console.WriteLine($"变量: {objGCVariable.VarName} → {varName4View}");

                            vueShareVariables.Add(varName4View);
                            Console.WriteLine($"  ✅ 需要导入: 界面变量(ViewIdGCVariableRela) → {varName4View}");

                            string initCode = GetInitExpression(varRela, objGCVariable);
                            if (!string.IsNullOrEmpty(initCode))
                            {
                                // 🔥 检查依赖
                                if (initCode.Contains("userStore") || initCode.Contains("useUserStore"))
                                {
                                    needsUserStore = true;
                                }
                                if (initCode.Contains("route.query") || initCode.Contains("route.params"))
                                {
                                    needsRoute = true;
                                }
                                if (initCode.Contains("clsPrivateSessionStorage") || initCode.Contains("SessionStorage"))
                                {
                                    needsSessionStorage = true;
                                }

                                // 拆分并添加代码行
                                var lines = initCode.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (var line in lines)
                                {
                                    if (!string.IsNullOrWhiteSpace(line))
                                    {
                                        // 不要添加 const userStore 或 const route 行
                                        var trimmedLine = line.Trim();
                                        if (!trimmedLine.StartsWith("const userStore") && 
                                            !trimmedLine.StartsWith("const route"))
                                        {
                                            initCodeBuilder.AppendLine($"    {trimmedLine}");
                                        }
                                    }
                                }
                            }

                            var detail = new ViewVariableDetail
                            {
                                VarName = varName4View,
                                VarType = GetTypeScriptType(objGCVariable),
                                RetrievalMethod = varRela.RetrievalMethodId,
                                InitExpression = initCode,
                                NeedImport = true
                            };

                            viewVariables.Add(detail);
                        }
                    }

                    // 🔥 构建完整的初始化代码块
                    var fullInitCode = new StringBuilder();
                    
                    if (needsUserStore)
                    {
                        fullInitCode.AppendLine("    const userStore = useUserStore();");
                    }
                    if (needsRoute)
                    {
                        fullInitCode.AppendLine("    const route = useRoute();");
                    }
                    if (needsUserStore || needsRoute)
                    {
                        fullInitCode.AppendLine();
                    }
                    
                    fullInitCode.Append(initCodeBuilder.ToString().TrimEnd());

                    model.ViewVariables = vueShareVariables;
                    model.ViewVariableDetails = viewVariables;
                    model.ViewVariablesInitCode = fullInitCode.ToString();
                    model.NeedsUserStore = needsUserStore;
                    model.NeedsRoute = needsRoute;
                    model.NeedsSessionStorage = needsSessionStorage; // 🔥 新增

                    if (vueShareVariables.Count > 0)
                    {
                        model.VueShareFileName = GetVueShareFileName();
                        model.VueShareImportPath = $"@/views/{objFuncModuleEN.FuncModuleEnName}/{model.VueShareFileName}";
                    }

                    Console.WriteLine($"=== 界面变量提取完成 ===");
                    Console.WriteLine($"总变量数: {viewVariables.Count}");
                    Console.WriteLine($"需要导入的变量数: {vueShareVariables.Count}");
                    Console.WriteLine($"需要 userStore: {needsUserStore}");
                    Console.WriteLine($"需要 route: {needsRoute}");
                    Console.WriteLine($"需要 sessionStorage: {needsSessionStorage}");
                    if (!string.IsNullOrEmpty(model.ViewVariablesInitCode))
                    {
                        Console.WriteLine("初始化代码:");
                        Console.WriteLine(model.ViewVariablesInitCode);
                    }
                    Console.WriteLine("=== 结束 ===");
                }
                else
                {
                    Console.WriteLine("=== 没有找到界面变量关联记录 ===");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"提取界面变量失败: {ex.Message}");
                Console.WriteLine($"堆栈跟踪: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// 🔥 获取 VueShare 文件名
        /// 例如：FunctionTemplateRelaVueShare
        /// </summary>
        private string GetVueShareFileName()
        {
            // 使用视图关联的表名或视图名
            string strClsName = string.Format("{0}VueShare", objViewInfoENEx.TabName);
            if (objViewInfoENEx.ViewName != $"{objViewInfoENEx.TabName}CRUD")
            {
                strClsName = string.Format("{0}VueShare", objViewInfoENEx.ViewName);
            }
            return strClsName;
        }

        /// <summary>
        /// 获取 TypeScript 类型
        /// 根据变量类型ID或数据类型ID映射到 TypeScript 类型
        /// </summary>
        private string GetTypeScriptType(clsGCVariableEN objVar)
        {
          

            // 如果有数据类型ID，根据 SQL Server 类型映射
            if (!string.IsNullOrEmpty(objVar.DataTypeId))
            {
                switch (objVar.DataTypeId)
                {
                    // 数值类型 → number
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.intidentity_10:
                    case enumDataTypeAbbr.smallint_18:
                    case enumDataTypeAbbr.tinyint_22:
                    case enumDataTypeAbbr.decimal_06:
                    case enumDataTypeAbbr.numeric_14:
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.real_16:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.smallmoney_19:
                        return "number";

                    // 布尔类型 → boolean
                    case enumDataTypeAbbr.bit_03:
                        return "boolean";

                    // 字符串类型 → string
                    case enumDataTypeAbbr.char_04:
                    case enumDataTypeAbbr.nchar_12:
                    case enumDataTypeAbbr.varchar_25:
                    case enumDataTypeAbbr.nvarchar_15:
                    case enumDataTypeAbbr.text_20:
                    case enumDataTypeAbbr.ntext_13:
                    case enumDataTypeAbbr.uniqueidentifier_23:
                        return "string";

                    // 日期时间类型 → string (ISO 8601 格式) 或 Date
                    case enumDataTypeAbbr.datetime_05:
                    case enumDataTypeAbbr.smalldatetime_17:
                    case enumDataTypeAbbr.timestamp_21:
                        return "string"; // 可选：return "Date"

                    // 二进制类型 → string (Base64) 或 ArrayBuffer
                    case enumDataTypeAbbr.binary_02:
                    case enumDataTypeAbbr.varbinary_24:
                    case enumDataTypeAbbr.image_08:
                        return "string"; // 可选：return "ArrayBuffer" 或 "Uint8Array"

                    // 特殊类型
                    case enumDataTypeAbbr.void_27:
                        return "void";

                    case enumDataTypeAbbr.System_Data_DataSet_28:
                        return "any[]"; // DataSet 通常映射为数组

                    case enumDataTypeAbbr.Object_29:
                        return "any";

                    case enumDataTypeAbbr.ObjectLst_30:
                        return "any[]";

                    case enumDataTypeAbbr.Array_31:
                        return "any[]";

                    case enumDataTypeAbbr.T_32:
                        return "T"; // 泛型类型

                    case enumDataTypeAbbr.Var4Key_33:
                    case enumDataTypeAbbr.Var4Field_34:
                        return "string"; // 变量类型默认为 string

                    default:
                        return "any";
                }
            }

            return "any";
        }

        /// <summary>
        /// 获取变量的初始化表达式
        /// 优先使用 ViewIdGCVariableRela.InitValue（如果有的话）
        /// 否则调用 GetGC_InitVarValue 生成默认的初始化代码
        /// </summary>
        private string GetInitExpression(clsViewIdGCVariableRelaEN varRela, clsGCVariableEN objVar)
        {
            try
            {
                string varName4View = objVar.GetVarName4View();
                string tsType = GetTypeScriptType(objVar);

                // 🔥 优先使用 InitValue
                if (!string.IsNullOrEmpty(varRela.InitValue))
                {
                    // 根据 TypeScript 类型格式化初始值
                    string formattedInitValue = FormatInitValue(varRela.InitValue, objVar);
                    string initCode = $"{varName4View}.value = {formattedInitValue};";
                    
                    Console.WriteLine($"  🎯 使用 InitValue: '{varRela.InitValue}' → {formattedInitValue} (类型: {tsType})");
                    
                    return initCode;
                }

                // 如果没有 InitValue，调用原有的方法生成默认初始化代码
                string defaultInitCode = varRela.GetGC_InitVarValue(this, "");
                
                if (!string.IsNullOrEmpty(defaultInitCode))
                {
                    Console.WriteLine($"  🔧 使用默认初始化 (类型: {tsType})");
                }
                
                return defaultInitCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  ❌ 生成初始化表达式失败: {ex.Message}");
                return "";
            }
        }

        /// <summary>
        /// 🔥 改进：格式化初始值
        /// 根据 TypeScript 类型将 InitValue 格式化为正确的字面量
        /// </summary>
        private string FormatInitValue(string initValue, clsGCVariableEN objVar)
        {
            if (string.IsNullOrEmpty(initValue))
            {
                // 如果没有初始值,根据类型返回默认值
                return GetDefaultValueByType(objVar);
            }

            // 🔥 关键改进:如果 InitValue 包含对象引用(包含 . 或 枚举),直接返回
            // 例如: clsPrivateSessionStorage.currSelPrjId, userStore.getUserId, enumProgLangType.TypeScript_09
            if (initValue.Contains(".") || 
                initValue.StartsWith("enum", StringComparison.OrdinalIgnoreCase) ||
                initValue.Contains("Storage") ||
                initValue.Contains("Store"))
            {
                Console.WriteLine($"  🎯 使用对象引用/枚举: '{initValue}' (直接返回)");
                return initValue;
            }

            // 统一使用 GetTypeScriptType 来判断类型
            string tsType = GetTypeScriptType(objVar);

            switch (tsType)
            {
                case "number":
                    // 数字类型:直接返回,不需要引号
                    if (double.TryParse(initValue, out _))
                    {
                        return initValue;
                    }
                    return "0";

                case "boolean":
                    // 布尔类型:转换为 true 或 false
                    if (initValue.Equals("true", StringComparison.OrdinalIgnoreCase) ||
                        initValue.Equals("1", StringComparison.OrdinalIgnoreCase) ||
                        initValue.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        return "true";
                    }
                    else if (initValue.Equals("false", StringComparison.OrdinalIgnoreCase) ||
                            initValue.Equals("0", StringComparison.OrdinalIgnoreCase) ||
                            initValue.Equals("no", StringComparison.OrdinalIgnoreCase))
                    {
                        return "false";
                    }
                    return "false";

                case "void":
                    return "undefined";

                case "any":
                case "any[]":
                    if (initValue.Equals("null", StringComparison.OrdinalIgnoreCase))
                    {
                        return "null";
                    }
                    if (initValue.TrimStart().StartsWith("{") || initValue.TrimStart().StartsWith("["))
                    {
                        return initValue;
                    }
                    return $"\"{EscapeString(initValue)}\"";

                case "Date":
                    return $"new Date(\"{EscapeString(initValue)}\")";

                case "ArrayBuffer":
                case "Uint8Array":
                    return "null";

                case "T":
                    return initValue.Equals("null", StringComparison.OrdinalIgnoreCase) ? "null" : $"\"{EscapeString(initValue)}\"";

                case "string":
                default:
                    // 字符串类型:需要引号并转义
                    return $"\"{EscapeString(initValue)}\"";
            }
        }

        /// <summary>
        /// 🔥 新增：根据类型获取默认值
        /// 当 InitValue 为空时，返回类型对应的默认值
        /// </summary>
        private string GetDefaultValueByType(clsGCVariableEN objVar)
        {
            string tsType = GetTypeScriptType(objVar);

            switch (tsType)
            {
                case "number":
                    return "0";
                case "boolean":
                    return "false";
                case "void":
                    return "undefined";
                case "any":
                case "any[]":
                case "Date":
                case "ArrayBuffer":
                case "Uint8Array":
                case "T":
                    return "null";
                case "string":
                default:
                    return "\"\"";
            }
        }

        /// <summary>
        /// 🔥 新增：转义字符串中的特殊字符
        /// 用于生成正确的 JavaScript/TypeScript 字符串字面量
        /// </summary>
        private string EscapeString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input
                .Replace("\\", "\\\\")  // 反斜杠
                .Replace("\"", "\\\"")  // 双引号
                .Replace("\n", "\\n")   // 换行
                .Replace("\r", "\\r")   // 回车
                .Replace("\t", "\\t")   // 制表符
                .Replace("\b", "\\b")   // 退格
                .Replace("\f", "\\f");  // 换页
        }

        /// <summary>
        /// 提取设置字段值功能的字段变量名
        /// 例如：useStateId_f, funcModuleId_f, dataBaseTypeId_f
        /// </summary>
        private void ExtractSetFieldVariables(ListAiHtmlTemplateModel model)
        {
            var setFieldFeatures = objViewInfoENEx.arrFeatureRegionFlds
                .Where(x => x.InUse == true && x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                .ToList();

            model.HasSetFieldFeature = setFieldFeatures.Count > 0;

            foreach (var feature in setFieldFeatures)
            {
                // 从关联字段ID获取字段名
                if (!string.IsNullOrEmpty(feature.ReleFldId))
                {
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(feature.ReleFldId, feature.PrjId());
                    if (objFieldTab != null)
                    {
                        // 生成变量名：useStateId_f, funcModuleId_f 等
                        string variableName = ToCamelCase(objFieldTab.FldName) ;
                        model.SetFieldVariables.Add(variableName);
                    }
                }
            }
        }

        /// <summary>
        /// 提取查询字段信息
        /// </summary>
        private void ExtractQueryFields(ListAiHtmlTemplateModel model)
        {
            if (objViewInfoENEx.arrQryRegionFldSet4InUse == null) return;

            int rowNum = 1;
            int fieldCount = 0;
            
            // 用于收集唯一的选项数据源
            var uniqueOptions = new Dictionary<string, AiHtmlQueryOption>();

            foreach (var field in objViewInfoENEx.arrQryRegionFldSet4InUse)
            {
                var optionsKey = GetOptionsKey(field);
                var optionsWApiClass = GetOptionsWApiClass(field);
                var optionsModuleName = GetOptionsModuleName(field);
                
                // 🔥 关键修复：调用 GetDsFieldNames 获取值字段和文本字段
                var (valueFieldName, textFieldName) = GetDsFieldNames(field);
                
                var queryField = new AiHtmlQueryField
                {
                    Key = ToCamelCase(field.FldName()) + "_q",
                    Label = field.LabelCaption,
                    Id = field.CtrlId4Web,
                    ControlType = GetControlType(field),
                    Width = field.Width ?? 0,
                    OptionsKey = optionsKey,
                    OptionsWApiClass = optionsWApiClass,
                    OptionsModuleName = optionsModuleName,
                    ValueFieldName = valueFieldName,  // 🔥 修复：赋值
                    TextFieldName = textFieldName,    // 🔥 修复：赋值
                    Row = rowNum
                };

                model.QueryFields.Add(queryField);

                // 收集唯一的选项数据源
                if (IsSelectControl(field) && !string.IsNullOrEmpty(optionsKey) && !string.IsNullOrEmpty(optionsWApiClass))
                {
                    if (!uniqueOptions.ContainsKey(optionsKey))
                    {
                        uniqueOptions.Add(optionsKey, new AiHtmlQueryOption
                        {
                            ArrayVariableName = "arr" + optionsWApiClass,
                            OptionsKey = optionsKey,
                            OptionsWApiClass = optionsWApiClass,  // 🔥 新增：赋值表名
                            ModuleName = optionsModuleName,
                            ValueFieldName = valueFieldName,
                            TextFieldName = textFieldName
                        });
                    }
                }

                fieldCount++;
                if (fieldCount % 3 == 0) rowNum++;
            }
            
            // 生成查询选项数组变量信息
            foreach (var option in uniqueOptions.Values)
            {
                model.QueryOptionsArrays.Add(option);
                if (model.QueryOptionsArrays4Import.Find(x => x.OptionsWApiClass == option.OptionsWApiClass) == null)
                {
                    model.QueryOptionsArrays4Import.Add(option);
                }

            }

            // 🔥 新增：填充 OptionKeys 列表
            model.OptionKeys = model.QueryFields
                .Where(f => !string.IsNullOrEmpty(f.OptionsKey))
                .Select(f => f.OptionsKey)
                .Distinct()
                .ToList();
        }


        /// <summary>
        /// 🔥 新增：提取功能区下拉框选项信息
        /// 使用 clsDDLItemsOptionBL.GetDdlOptionInfoLst 获取下拉框数据源信息
        /// </summary>
        private void ExtractFeatureOptions(ListAiHtmlTemplateModel model)
        {
            try
            {
                // 获取所有设置字段值的功能
                var setFieldFeatures = objViewInfoENEx.arrFeatureRegionFlds
                    .Where(x => x.InUse == true && x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    .ToList();

                if (setFieldFeatures.Count == 0)
                {
                    Console.WriteLine("没有设置字段值功能");
                    return;
                }

                // 🔥 使用 GetDdlOptionInfoLst 获取下拉框选项信息
                var arrViewFeatureFldsENEx = objViewInfoENEx.arrViewFeatureFlds
                    .Where(x => x.InUse == true && x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    .Cast<clsViewFeatureFldsENEx>()
                    .ToList();

                var ddlOptionsInfoList = clsViewFeatureFldsBLEx.GetDdlOptionInfoLst(arrViewFeatureFldsENEx);

                foreach (var ddlInfo in ddlOptionsInfoList)
                {
                    // 生成选项键（如 useState, dataBaseType）
                    string optionKey = ToCamelCase(ddlInfo.Key);

                    // 检查是否已存在
                    if (model.FeatureOptions.Any(x => x.Key == optionKey))
                    {
                        continue;
                    }

                    var optionInfo = new AiOptionsInfo
                    {
                        Key = optionKey,
                        OptionsKey = optionKey ,  // 使用 WApi 类名转 camelCase 作为 OptionsKey
                        ControlType = ddlInfo.ControlType,
                        ValueFieldName = ddlInfo.ValueFieldName,
                        TextFieldName = ddlInfo.TextFieldName,
                        WApiClass = ddlInfo.WApiClass,
                        ArrayVariableName = ddlInfo.ArrayVariableName,
                        ModuleName = ddlInfo.ModuleName,
                        FunctionName = ddlInfo.FunctionName,
                        IsExtendedClass = ddlInfo.IsExtendedClass,
                        Parameters = ddlInfo.Parameters?.Select(p => new AiOptionParam
                        {
                            ParamName = p.ParamName,
                            SharedVarName = p.SharedVarName
                        }).ToList() ?? new List<AiOptionParam>()
                    };

                    model.FeatureOptions.Add(optionInfo);
                    if (optionInfo.ControlType != "select4Bool")
                    {
                        if (model.FeatureOptions4DS.Find(x => x.WApiClass == optionInfo.WApiClass) == null)
                        {
                            model.FeatureOptions4DS.Add(optionInfo);
                        }
                    }
                    Console.WriteLine($"✅ 功能区选项: {optionKey}, 函数: {ddlInfo.FunctionName}, 参数数量: {optionInfo.Parameters.Count}");
                }


                // 🔥 新增：填充 OptionKeys 列表
                model.OptionKeysInFeature = model.FeatureOptions
                    .Where(f => !string.IsNullOrEmpty(f.OptionsKey))
                    .Select(f => f.OptionsKey)
                    .Distinct()
                    .ToList();
                model.OptionKeysInFeature4DS = model.FeatureOptions
                    .Where(f => !string.IsNullOrEmpty(f.OptionsKey) && f.ControlType != "select4Bool")
                    .Select(f => f.OptionsKey)
                    .Distinct()
                    .ToList();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ 提取功能区选项失败: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void ExtractFeatureOptions4DS(ListAiHtmlTemplateModel model)
        {
            try
            {
                // 获取所有设置字段值的功能
                var setFieldFeatures = objViewInfoENEx.arrFeatureRegionFlds
                    .Where(x => x.InUse == true && x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    .ToList();

                if (setFieldFeatures.Count == 0)
                {
                    Console.WriteLine("没有设置字段值功能");
                    return;
                }

                // 🔥 使用 GetDdlOptionInfoLst 获取下拉框选项信息
                var arrViewFeatureFldsENEx = objViewInfoENEx.arrViewFeatureFlds
                    .Where(x => x.InUse == true && x.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    .Cast<clsViewFeatureFldsENEx>()
                    .ToList();

                var ddlOptionsInfoList = clsViewFeatureFldsBLEx.GetDdlOptionInfoLst(arrViewFeatureFldsENEx);

                foreach (var ddlInfo in ddlOptionsInfoList)
                {
                    // 生成选项键（如 useState, dataBaseType）
                    string optionKey = ToCamelCase(ddlInfo.Key);

                    // 检查是否已存在
                    if (model.FeatureOptions.Any(x => x.Key == optionKey))
                    {
                        continue;
                    }

                    var optionInfo = new AiOptionsInfo
                    {
                        //Key = optionKey,
                        ControlType = ddlInfo.ControlType,
                        ArrayVariableName = ddlInfo.ArrayVariableName,
                        ValueFieldName = ddlInfo.ValueFieldName,
                        TextFieldName = ddlInfo.TextFieldName,
                        WApiClass = ddlInfo.WApiClass,
                        ModuleName = ddlInfo.ModuleName,
                        FunctionName = ddlInfo.FunctionName,
                        IsExtendedClass = ddlInfo.IsExtendedClass,
                        WApiFileName = ddlInfo.WApiFileName,
                        WApiPath = ddlInfo.WApiPath,
                        Parameters = ddlInfo.Parameters?.Select(p => new AiOptionParam
                        {
                            ParamName = p.ParamName,
                            SharedVarName = p.SharedVarName
                        }).ToList() ?? new List<AiOptionParam>()
                    };
                    if (optionInfo.ControlType != "select4Bool")
                    {
                        if (model.FeatureOptions4DS.Find(x => x.WApiClass == optionInfo.WApiClass) == null)
                        {
                            model.FeatureOptions4DS.Add(optionInfo);
                        }
                    }
                    Console.WriteLine($"✅ 功能区选项: {optionKey}, 函数: {ddlInfo.FunctionName}, 参数数量: {optionInfo.Parameters.Count}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ 提取功能区选项失败: {ex.Message}\n{ex.StackTrace}");
            }
        }

        /// <summary>
        /// 🔥 新增：获取选项数据源的模块名
        /// </summary>
        private string GetOptionsModuleName(clsQryRegionFldsENEx field)
        {
            if (!IsSelectControl(field)) return null;
            if (field.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04) return null;
            try
            {
                // 如果有数据源表ID，获取表所属的模块名
                if (!string.IsNullOrEmpty(field.DsTabId))
                {
                    var objDsTab = clsPrjTabBL.GetObjByTabIdCache(field.DsTabId, field.PrjId);
                    if (objDsTab != null)
                    {
                        var objFuncModule = objDsTab.ObjFuncModule();
                        if (objFuncModule != null)
                        {
                            return objFuncModule.FuncModuleEnName;  // 返回模块名，如 PrjFunction, RegionManage
                        }
                    }
                }

                // 回退：使用当前视图的模块名
                return objFuncModuleEN.FuncModuleEnName;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取模块名失败: {ex.Message}");
                return objFuncModuleEN.FuncModuleEnName;
            }
        }

        /// <summary>
        /// 🔥 修改：获取选项数据源的 WApi 类名
        /// 需要与 Ai3Query 中的逻辑一致，基于数据源表名
        /// </summary>
        private string GetOptionsWApiClass(clsQryRegionFldsENEx field)
        {
            if (!IsSelectControl(field)) return null;
            if (field.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04) return null;
            try
            {
                // 🔥 如果有数据源表ID，使用表名作为 WApi 类名
                if (!string.IsNullOrEmpty(field.DsTabId))
                {
                    var objDsTab = clsPrjTabBL.GetObjByTabIdCache(field.DsTabId, field.PrjId);
                    if (objDsTab != null)
                    {
                        return objDsTab.TabName;  // 返回表名，如 FunctionTemplate, RegionType
                    }
                }

                // 🔥 回退逻辑：从字段名推断
                string fieldName = field.FldName();
                if (fieldName.EndsWith("Id", StringComparison.OrdinalIgnoreCase))
                {
                    fieldName = fieldName.Substring(0, fieldName.Length - 2);
                }
                return char.ToUpper(fieldName[0]) + fieldName.Substring(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取 WApi 类名失败: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// 获取选项数据源的 key
        /// 例如：FunctionTemplate → functionTemplate
        /// </summary>
        private string GetOptionsKey(clsQryRegionFldsENEx field)
        {
            if (!IsSelectControl(field)) return null;
            if (field.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04) return null;
           string strFldName =  field.ObjFieldTab().FldName;
            if (string.IsNullOrEmpty(strFldName)) return null;
            
            return ToCamelCase(strFldName) +"_q";  // 使用 WApi 类名转 camelCase
        }

        /// <summary>
        /// 判断查询字段是否为下拉框控件
        /// </summary>
        private bool IsSelectControl(clsQryRegionFldsENEx field)
        {
            if (field == null) return false;

            string ctlTypeName = field.CtlTypeENName?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(ctlTypeName)) return false;

            ctlTypeName = ctlTypeName.ToLowerInvariant();

            return ctlTypeName == "select"
                || ctlTypeName == "ddl"
                || ctlTypeName == "dropdownlist"
                || ctlTypeName == "combobox"
                || ctlTypeName == "combo";
        }

        /// <summary>
        /// 获取控件类型
        /// </summary>
        private string GetControlType(clsQryRegionFldsENEx field)
        {
            if (field.objCtlType.CtlTypeName.Contains("Text") ||
                field.objCtlType.CtlTypeName.Contains("Input"))
            {
                return "text";
            }
            if (field.objCtlType.CtlTypeName.Contains("DropDownList_Bool"))
            {
                return "select4Bool";
            }            
            return "select";
        }
        
        /// <summary>
        /// 提取功能按钮信息
        /// </summary>
        private void ExtractFeatureCommands(ListAiHtmlTemplateModel model)
        {
            // 查询区域的命令按钮
            model.QueryCommands.Add(new AiHtmlCommand
            {
                Id = "query",
                Text = "查询",
                ElementId = "btnQuery",
                BtnClass = "btn btn-primary btn-sm"
            });

            model.QueryCommands.Add(new AiHtmlCommand
            {
                Id = "clearQuery",
                Text = "清空查询",
                ElementId = "btnClearQuery",
                BtnClass = "btn btn-secondary btn-sm"
            });

            // 功能区域的命令按钮
            var arrFeatureRegionFlds = objViewInfoENEx.arrFeatureRegionFlds
                .Where(x => x.InUse == true)
                .ToList();
            model.HasExportFeature = 
                arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.ExportToFile_0196 
                || x.FeatureId == enumPrjFeature.ExportToFile_0143) == null ? false : true;
            foreach (var feature in arrFeatureRegionFlds)
            {
                var command = new AiHtmlCommand
                {
                    Id = GetCommandId(feature),
                    Text = feature.ButtonName,
                    ElementId = feature.CtrlId(),
                    BtnClass = GetButtonClass(feature),
                    NeedAuxControl = feature.FeatureId == enumPrjFeature.SetFieldValue_0148
                };

                model.FeatureCommands.Add(command);
            }
        }


        /// <summary>
        /// 获取命令ID
        /// </summary>
        private string GetCommandId(clsFeatureRegionFldsENEx feature)
        {
            // 根据功能ID映射命令ID
            if (feature.FeatureId == enumPrjFeature.AddNewRecord_0136) return "create";
            if (feature.FeatureId == enumPrjFeature.DelRecord_0138) return "delete";
            if (feature.FeatureId == enumPrjFeature.ExportToFile_0143) return "export";
            if (feature.FeatureId == enumPrjFeature.SetFieldValue_0148) return "setField";
            return ToCamelCase(feature.ButtonName);
        }

        /// <summary>
        /// 获取按钮样式类
        /// </summary>
        private string GetButtonClass(clsFeatureRegionFldsENEx feature)
        {
            if (feature.FeatureId == enumPrjFeature.AddNewRecord_0136) 
                return "btn btn-success btn-sm";
            if (feature.FeatureId == enumPrjFeature.DelRecord_0138) 
                return "btn btn-danger btn-sm";
            if (feature.FeatureId == enumPrjFeature.ExportToFile_0143) 
                return "btn btn-info btn-sm";
            return "btn btn-primary btn-sm";
        }

        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }



        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Vue_ViewScript4Html);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }

        /// <summary>
        /// 🔥 修正：获取数据源的值字段名和文本字段名
        /// 从 QryRegionFlds.TabFeatureId4Ddl → TabFeature → TabFeatureFlds 中获取
        /// </summary>
        private (string ValueFieldName, string TextFieldName) GetDsFieldNames(clsQryRegionFldsENEx field)
        {
            try
            {
                // 如果是布尔类型的下拉框，返回固定值
                if (field.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                {
                    return ("value", "text");
                }

                if (!IsSelectControl(field))
                {
                    return (null, null);
                }

                // 🔥 核心逻辑：通过 TabFeatureId4Ddl 直接找到 TabFeature
                if (string.IsNullOrEmpty(field.TabFeatureId4Ddl))
                {
                    Console.WriteLine($"  ⚠️ 字段 {field.FldName()} 未配置 TabFeatureId4Ddl");
                    return GetDefaultFieldNames(field);
                }

                // 1. 获取 TabFeature 对象（不需要通过名称查找，直接通过ID获取）
                var tabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(field.TabFeatureId4Ddl, field.PrjId);
                if (tabFeature == null)
                {
                    Console.WriteLine($"  ⚠️ 未找到 TabFeatureId: {field.TabFeatureId4Ddl}");
                    return GetDefaultFieldNames(field);
                }

                // 2. 获取该 TabFeature 的字段配置
                var arrTabFeatureFlds = clsTabFeatureFldsBL.GetObjLstCache(field.PrjId)
                    .Where(x => x.TabFeatureId == field.TabFeatureId4Ddl)
                    .ToList();

                if (arrTabFeatureFlds == null || arrTabFeatureFlds.Count == 0)
                {
                    Console.WriteLine($"  ⚠️ TabFeature {tabFeature.TabFeatureName} 未配置字段");
                    return GetDefaultFieldNames(field);
                }

                // 3. 查找值字段（KeyField_01）和文本字段（TextField_02）
                var valueFieldConfig = arrTabFeatureFlds.FirstOrDefault(x => x.FieldTypeId == enumFieldType.KeyField_02);
                var textFieldConfig = arrTabFeatureFlds.FirstOrDefault(x => x.FieldTypeId == enumFieldType.NameField_03);

                if (valueFieldConfig == null || textFieldConfig == null)
                {
                    Console.WriteLine($"  ⚠️ TabFeatureFlds 中未找到值字段或文本字段配置");
                    Console.WriteLine($"     TabFeature: {tabFeature.TabFeatureName}");
                    Console.WriteLine($"     TabFeatureFlds 数量: {arrTabFeatureFlds.Count}");
                    Console.WriteLine($"     valueFieldConfig: {valueFieldConfig != null}");
                    Console.WriteLine($"     textFieldConfig: {textFieldConfig != null}");
                    return GetDefaultFieldNames(field);
                }

                // 4. 获取字段对象
                var valueFieldObj = clsFieldTabBL.GetObjByFldIdCache(valueFieldConfig.FldId, field.PrjId);
                var textFieldObj = clsFieldTabBL.GetObjByFldIdCache(textFieldConfig.FldId, field.PrjId);

                if (valueFieldObj == null || textFieldObj == null)
                {
                    Console.WriteLine($"  ⚠️ 字段对象获取失败");
                    Console.WriteLine($"     valueFieldObj: {valueFieldObj != null} (FldId: {valueFieldConfig.FldId})");
                    Console.WriteLine($"     textFieldObj: {textFieldObj != null} (FldId: {textFieldConfig.FldId})");
                    return GetDefaultFieldNames(field);
                }

                // 5. 转换为 camelCase
                string valueFieldName = ToCamelCase(valueFieldObj.FldName);
                string textFieldName = ToCamelCase(textFieldObj.FldName);
                
                Console.WriteLine($"  ✅ 下拉框字段: {field.FldName()}");
                Console.WriteLine($"     TabFeature: {tabFeature.TabFeatureName} (ID: {field.TabFeatureId4Ddl})");
                Console.WriteLine($"     数据源表: {field.DsTabId}");
                Console.WriteLine($"     值字段: {valueFieldName} (来源: {valueFieldObj.FldName})");
                Console.WriteLine($"     文本字段: {textFieldName} (来源: {textFieldObj.FldName})");
                
                return (valueFieldName, textFieldName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  ❌ 获取数据源字段名失败: {ex.Message}");
                Console.WriteLine($"  堆栈跟踪: {ex.StackTrace}");
                return GetDefaultFieldNames(field);
            }
        }

        /// <summary>
        /// 🔥 新增：获取默认字段名（回退方案）
        /// 例如：FunctionTemplate → functionTemplateId / functionTemplateName
        /// </summary>
        private (string ValueFieldName, string TextFieldName) GetDefaultFieldNames(clsQryRegionFldsENEx field)
        {
            var wApiClass = GetOptionsWApiClass(field);
            if (!string.IsNullOrEmpty(wApiClass))
            {
                string defaultValueField = ToCamelCase(wApiClass) + "Id";
                string defaultTextField = ToCamelCase(wApiClass) + "Name";
                
                Console.WriteLine($"  ⚠️ 使用默认命名: {field.FldName()} → {defaultValueField} / {defaultTextField}");
                
                return (defaultValueField, defaultTextField);
            }

            return (null, null);
        }
    }
}