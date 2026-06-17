using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AGC.Entity;
using AgcCommBase;
using Scriban;
using Scriban.Runtime;

namespace AutoGCLib.Templates
{
    public class RenderService
    {
        private readonly string _templateBasePath;
        private readonly Dictionary<string, Template> _templateCache;

        public RenderService(string templateBasePath = null)
        {
            _templateBasePath = templateBasePath ?? 
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates");
            _templateCache = new Dictionary<string, Template>();
        }

        public string Render(string templatePath, object model)
        {
            var template = GetTemplate(templatePath);
            
            var scriptObject = new ScriptObject();
            ImportObjectRecursive(scriptObject, model);
            
            var context = new TemplateContext();
            context.StrictVariables = false;
            context.PushGlobal(scriptObject);
            
            // 🔥 修复：渲染并返回结果
            var result = template.Render(context);
            
            return result;
        }

        /// <summary>
        /// 递归导入对象及其嵌套属性到 ScriptObject
        /// 跳过索引器属性避免参数不匹配错误
        /// </summary>
        private void ImportObjectRecursive(ScriptObject scriptObject, object obj)
        {
            if (obj == null) return;

            var type = obj.GetType();
            
            // 遍历所有公共属性
            foreach (var prop in type.GetProperties())
            {
                // 跳过索引器属性（带参数的属性）
                if (prop.GetIndexParameters().Length > 0)
                {
                    continue;
                }

                try
                {
                    var propName = prop.Name;
                    var propValue = prop.GetValue(obj);
                    
                    // 如果是集合类型（如 List<AiColumnField>）
                    if (propValue is IList list)
                    {
                        var scriptArray = new ScriptArray();
                        
                        foreach (var item in list)
                        {
                            if (item == null)
                            {
                                scriptArray.Add(null);
                                continue;
                            }

                            // 🔥 检查列表项的类型
                            var itemType = item.GetType();
                            
                            // 如果是简单类型（string, int等），直接添加
                            if (itemType.IsPrimitive || itemType == typeof(string) || itemType == typeof(decimal))
                            {
                                scriptArray.Add(item);
                            }
                            else
                            {
                                // 🔥 为复杂对象创建 ScriptObject 并递归处理
                                var itemObject = new ScriptObject();
                                ImportObjectPropertiesToScriptObject(itemObject, item);
                                scriptArray.Add(itemObject);
                            }
                        }
                        
                        scriptObject[propName] = scriptArray;
                    }
                    else
                    {
                        // 普通属性直接赋值
                        scriptObject[propName] = propValue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"跳过属性 {prop.Name}: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// 🔥 新增：将对象的属性导入到 ScriptObject 中（支持嵌套）
        /// </summary>
        private void ImportObjectPropertiesToScriptObject(ScriptObject scriptObject, object obj)
        {
            if (obj == null) return;

            foreach (var itemProp in obj.GetType().GetProperties())
            {
                if (itemProp.GetIndexParameters().Length > 0)
                {
                    continue;
                }

                try
                {
                    var itemPropValue = itemProp.GetValue(obj);
                    
                    // 🔥 如果属性值也是列表，递归处理
                    if (itemPropValue is IList nestedList)
                    {
                        var nestedArray = new ScriptArray();
                        
                        foreach (var nestedItem in nestedList)
                        {
                            if (nestedItem == null)
                            {
                                nestedArray.Add(null);
                                continue;
                            }

                            var nestedItemType = nestedItem.GetType();
                            
                            if (nestedItemType.IsPrimitive || nestedItemType == typeof(string) || nestedItemType == typeof(decimal))
                            {
                                nestedArray.Add(nestedItem);
                            }
                            else
                            {
                                var nestedObject = new ScriptObject();
                                ImportObjectPropertiesToScriptObject(nestedObject, nestedItem);
                                nestedArray.Add(nestedObject);
                            }
                        }
                        
                        scriptObject[itemProp.Name] = nestedArray;
                    }
                    else
                    {
                        scriptObject[itemProp.Name] = itemPropValue;
                    }
                }
                catch
                {
                    // 静默跳过无法访问的属性
                }
            }
        }

        public string RenderFromString(string templateContent, object model)
        {
            var template = Template.Parse(templateContent);
            
            if (template.HasErrors)
            {
                throw new InvalidOperationException(
                    $"模板解析错误: {string.Join(", ", template.Messages)}");
            }
            
            var scriptObject = new ScriptObject();
            ImportObjectRecursive(scriptObject, model);
            
            var context = new TemplateContext();
            context.StrictVariables = false;
            context.PushGlobal(scriptObject);
            
            return template.Render(context);
        }

        private Template GetTemplate(string templatePath) 
        {
            var fullPath = Path.Combine(_templateBasePath, templatePath);
            
            if (_templateCache.ContainsKey(fullPath))
            {
                return _templateCache[fullPath];
            }

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException($"模板文件不存在: {fullPath}");
            }

            var templateContent = File.ReadAllText(fullPath, Encoding.UTF8);
            var template = Template.Parse(templateContent);

            if (template.HasErrors)
            {
                throw new InvalidOperationException(
                    $"模板解析错误: {string.Join(", ", template.Messages)}");
            }

            _templateCache[fullPath] = template;
            return template;
        }

        public void ClearCache()
        {
            _templateCache.Clear();
        }
    }

    #region 数据模型定义

    /// <summary>
    /// 代码生成注释详细程度枚举
    /// 控制生成的 TypeScript 代码中注释的详细程度
    /// </summary>
    public enum CommentVerbosity
    {
        /// <summary>
        /// 精简模式：只保留必要注释（默认，推荐用于生产代码）
        /// 适用场景：生成的代码用于实际项目
        /// </summary>
        Compact = 0,
        
        /// <summary>
        /// 详细模式：包含完整元数据和 AutoGCLib 生成标记（推荐用于学习参考）
        /// 适用场景：生成示例代码、文档、学习材料
        /// </summary>
        Verbose = 1
    }

    public class AiColumnsTemplateModel
    {
        public string TableName { get; set; }
        public string ModuleName { get; set; }
        public bool HasExtendFields { get; set; }
        public List<AiColumnField> Fields { get; set; } = new List<AiColumnField>();
    }

    public class AiColumnField
    {
        public string Name { get; set; }
        public string EntityClass { get; set; }
        public string ExSuffix { get; set; } = "";
        public string Source { get; set; }
        public string Header { get; set; }
        public string SortBy { get; set; }
        public string TdClass { get; set; }
        public int OrderNum { get; set; }
        public bool IncludeInList { get; set; }
        public bool IncludeInExport { get; set; }
    }

    /// <summary>
    /// Ai 查询字段模板数据模型
    /// </summary>
    public class AiQueryTemplateModel
    {
        public string TableName { get; set; }
        public string ModuleName { get; set; }
        public List<AiQueryField> QueryFields { get; set; } = new List<AiQueryField>();
        public List<AiOptionsInfo> OptionsInfo { get; set; } = new List<AiOptionsInfo>();  // 🔥 替换 OptionsKeys
        public List<AiOptionsInfo> OptionsInfo4DS { get; set; } = new List<AiOptionsInfo>();  // 🔥 替换 OptionsKeys
    }

    /// <summary>
    /// 选项数据源信息
    /// </summary>
    public class AiOptionsInfo
    {
        public string Key { get; set; }              // 如 dataBaseType
        public string ControlType { get; set; }
        public string ArrayVariableName { get; set; }  // 如 arrFunctionTemplate
        public string ValueFieldName { get; set; }
        public string TextFieldName { get; set; }
        public string OptionsKey { get; set; }       // 如 dataBaseType
        public string WApiClass { get; set; }        // 如 DataBaseType
        public string ModuleName { get; set; }       // 如 SysPara
        public string GetDdlDataFuncName { get; set; }     // 完整函数名
        public bool IsExtendedClass { get; set; }    // 是否在扩展类
        public string WApiPath { get; set; }         // WApi 路径
        public string WApiFileName { get; set; }     // WApi 文件名
        public List<DdlOptionParam> Parameters { get; set; } = new List<DdlOptionParam>();  // 🔥 新增：函数参数列表
    }

    public class AiOptionsInfo4DSBak
    {
        public string ArrayVariableName { get; set; }  // 如 arrFunctionTemplate
        public string WApiClass { get; set; }        // 如 DataBaseType
        public string ModuleName { get; set; }       // 如 SysPara
        public string FunctionName { get; set; }     // 完整函数名
        public bool IsExtendedClass { get; set; }    // 是否在扩展类
        public string WApiPath { get; set; }         // WApi 路径
        public string WApiFileName { get; set; }     // WApi 文件名
        public List<DdlOptionParam> Parameters { get; set; } = new List<DdlOptionParam>();  // 🔥 新增：函数参数列表
    }
    /// <summary>
    /// 🔥 新增：选项函数参数信息
    /// </summary>


    /// <summary>
    /// 查询字段定义
    /// </summary>
    public class AiQueryField
    {
        public string Key { get; set; }
        public string Label { get; set; }
        public string Id { get; set; }
        public string ControlType { get; set; }
        public int Width { get; set; }
        public int Row { get; set; }
        public int Order { get; set; }
        public string OptionsKey { get; set; }
        public string OptionsWApiClass { get; set; }
        public string OptionsModuleName { get; set; }
        public string GetDdlDataFuncName { get; set; }
        public bool OptionsIsExtendedClass { get; set; }
        public List<DdlOptionParam> OptionsParameters { get; set; } = new List<DdlOptionParam>();  // 🔥 新增
        public string DefaultValue { get; set; }
    }

    /// <summary>
    /// Ai 命令配置模板数据模型
    /// </summary>
    public class AiCommandTemplateModel
    {
        public string TableName { get; set; }
        public string TableNameUpper { get; set; }
        public List<AiCommand> Commands { get; set; } = new List<AiCommand>();

        /// <summary>
        /// 🔥 新增：功能区下拉框选项信息
        /// </summary>
        public List<AiOptionsInfo> FeatureOptions { get; set; } = new List<AiOptionsInfo>();
        public List<AiOptionsInfo> FeatureOptions4DS { get; set; } = new List<AiOptionsInfo>();
        public bool HasAdjustOrderNum { get; set; }
    }

    /// <summary>
    /// 命令定义
    /// </summary>
    public class AiCommand
    {
        public string Id { get; set; }
        public string Region { get; set; }
        public string Text { get; set; }
        public string ElementId { get; set; }
        public string BtnClass { get; set; }
        public bool NeedAuxControl { get; set; }
        
        /// <summary>
        /// 🔥 新增：辅助控件ID（如：ddlInUse_SetFldValue）
        /// </summary>
        public string AuxControlId { get; set; }
        
        /// <summary>
        /// 🔥 新增：辅助控件类型（select4Bool、select、text）
        /// </summary>
        public string AuxControlType { get; set; }

        /// <summary>
        /// 🔥 新增：辅助控件选项键（用于获取下拉框数据源）
        /// </summary>
        public string AuxControlOptionsKey { get; set; }

        public string AuxControlLabel { get; set; }
        public bool IsNeedAuxControlLabel { get; set; } = false;
        /// <summary>
        /// 🔥 新增：字段名（用于关联 VueShare 中的响应式变量）
        /// </summary>
        public string FieldName { get; set; }
        
        /// <summary>
        /// 🔥 新增：驼峰式字段名（如：inUse）
        /// </summary>
        public string FieldNameCamel { get; set; }
    }

    /// <summary>
    /// Ai 基类模板数据模型
    /// </summary>
    public class AiBaseTemplateModel
    {
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableNameUpper { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public string NameFieldCamel { get; set; }
        public bool HasCacheMode { get; set; }              // 是否使用缓存模式（CacheModeId='03'或'04'）
                                                            // 🔥 新增：缓存分类字段信息
        public bool HasCacheClassifyField { get; set; }          // 是否有缓存分类字段
        public string CacheClassifyFieldName { get; set; }       // 缓存分类字段名（如：PrjId）
        public string CacheClassifyFieldCamel { get; set; }      // 缓存分类字段名（驼峰，如：prjId）


        public bool IsUseFunc { get; set; }                 // 🔥 新增：是否有字段映射转换（需要Ex函数）
        public bool IsMultiKey { get; set; }                // 🔥 新增：是否为多关键字
        public string strIsShare { get; set; }
        public bool HasDeleteFeature { get; set; }          // 是否有删除功能（功能区按钮）
        public bool HasExportFeature { get; set; }          // 是否有导出功能
        public bool HasCopyFeature { get; set; }            // 🔥 新增：是否有复制记录功能
        public bool HasDeleteInTabFeature { get; set; }     // 🔥 新增：是否有表格内删除功能
        public bool HasSelectInTabFeature { get; set; }     // 🔥 新增：是否有表格内选择功能
        
        public List<AiSetFieldFeature> SetFieldFeatures { get; set; } = new List<AiSetFieldFeature>();
        
        // 🔥 排序示例字段（从导出区域字段中选择前两个）
        public string SortField1 { get; set; }
        public string SortField1Type { get; set; }
        public string SortField1CompareExpr { get; set; }
        public string SortField2 { get; set; }
        public string SortField2Type { get; set; }
        public string SortField2CompareExpr { get; set; }
        public List<FieldInfo> AvailableFields { get; set; } = new List<FieldInfo>();
        public List<string> CacheCondVarLst { get; set; }
        public List<string> CacheImportVarLst { get; set; }
        public string CacheImportVars { get; set; }
        public string CacheCondVars { get; set; }
        public string CacheCondVars4Fst { get; set; }

        public bool HasCacheCondVar { get; set; }
        public bool HasCacheImportVar { get; set; }
        public string KeyTypeName { get; set; }
    }

    /// <summary>
    /// Edit 编辑区模板数据模型
    /// </summary>
    public class EditAiTemplateModel
    {
        // 基础字段
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public string KeyFieldWithPrefix { get; set; }
        public string KeyFieldTypeScript { get; set; }
        public string KeyFieldPrefixOnly { get; set; }
        public string KeyFieldInitValue { get; set; }
        public bool IsKeyFieldNumeric { get; set; }
        public bool IsMultiKey { get; set; }
        public string strIsShare { get; set; }
        public List<KeyFieldInfo> KeyFields { get; set; }
        public bool NeedCheckKeyExist { get; set; }
        public bool NeedUniCheck { get; set; }

        public bool NeedReturnKeyMethod { get; set; }
        public bool IsStringAutoIncrement { get; set; }
        public string ReturnKeyMethodReturnType { get; set; }
        public bool NeedRefreshCache { get; set; }
        
        // 🔥 新增：缓存分类字段信息
        public bool HasCacheClassifyField { get; set; }          // 是否有缓存分类字段
        public string CacheClassifyFieldName { get; set; }       // 缓存分类字段名（如：PrjId）
        public string CacheClassifyFieldCamel { get; set; }      // 缓存分类字段名（驼峰，如：prjId）
        
        public string PrimaryTypeId { get; set; }
        public string ViewId { get; set; }
        public string ViewName { get; set; }
        
        // 详细注释字段
        public string GenerateDate { get; set; }
        public string GenerateDateShort { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string PrjDataBaseId { get; set; }
        public string PrjId { get; set; }
        public string FrameworkLayer { get; set; }
        public string Generator { get; set; }
        
        public CommentVerbosity CommentMode { get; set; } = CommentVerbosity.Compact;
    }

    /// <summary>
    /// Edit 编辑区模板数据模型
    /// </summary>
    public class EditAiHTemplateModel
    {
        // 基础字段
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public string KeyFieldWithPrefix { get; set; }
        public string KeyFieldTypeScript { get; set; }
        public string KeyFieldPrefixOnly { get; set; }
        public string KeyFieldInitValue { get; set; }
        public bool IsKeyFieldNumeric { get; set; }
        public bool IsMultiKey { get; set; }
        public bool IsNeedImportIsNullOrEmpty { get; set; }
        public string strIsShare { get; set; }
        public List<KeyFieldInfo> KeyFields { get; set; }
        public bool NeedCheckKeyExist { get; set; }
        public bool NeedUniCheck { get; set; }

        public bool NeedReturnKeyMethod { get; set; }
        public bool NeedUseCurrUser { get; set; }
        public bool IsStringAutoIncrement { get; set; }
        public string ReturnKeyMethodReturnType { get; set; }
        public bool NeedRefreshCache { get; set; }

        // 🔥 新增：缓存分类字段信息
        public bool HasCacheClassifyField { get; set; }          // 是否有缓存分类字段
        public string CacheClassifyFieldName { get; set; }       // 缓存分类字段名（如：PrjId）
        public string CacheClassifyFieldCamel { get; set; }      // 缓存分类字段名（驼峰，如：prjId）

        public string PrimaryTypeId { get; set; }
        public string ViewId { get; set; }
        public string ViewName { get; set; }

        // 详细注释字段
        public string GenerateDate { get; set; }
        public string GenerateDateShort { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string PrjDataBaseId { get; set; }
        public string PrjId { get; set; }
        public string FrameworkLayer { get; set; }
        public string Generator { get; set; }

        public CommentVerbosity CommentMode { get; set; } = CommentVerbosity.Compact;
    }

    /// <summary>
    /// EditEx 编辑区扩展类模板数据模型
    /// </summary>
    public class EditExTemplateModel
    {
        // 基础字段
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public bool IsKeyFieldNumeric { get; set; }         // 🔥 关键字段是否为数字类型
        public bool IsMultiKey { get; set; }                // 🔥 新增：是否为多关键字段（复合主键）
        public List<KeyFieldInfo> KeyFields { get; set; }   // 🔥 新增：关键字段列表
        public string PrimaryTypeId { get; set; }
        public string ViewId { get; set; }
        public string ViewName { get; set; }
        
        // 详细注释字段
        public string GenerateDate { get; set; }
        public string GenerateDateShort { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseServer { get; set; }
        public string PrjDataBaseId { get; set; }
        public string PrjId { get; set; }
        public string PrjName { get; set; }
        public string CMProjectId { get; set; }
        public string CMProjectName { get; set; }
        public string FrameworkLayer { get; set; }
        public string Generator { get; set; }
        public CommentVerbosity CommentMode { get; set; } = CommentVerbosity.Verbose;
    }

    /// <summary>
    /// 🔥 NEW: 关键字字段信息
    /// </summary>
    public class KeyFieldInfo
    {
        /// <summary>
        /// 字段名：ConstId, PrjId
        /// </summary>
        public string FieldName { get; set; }
        
        /// <summary>
        /// 驼峰式字段名：constId, prjId
        /// </summary>
        public string FieldNameCamel { get; set; }
        
        /// <summary>
        /// 属性名（根据 IsFstLcase）：constId 或 ConstId
        /// </summary>
        public string PropertyName { get; set; }
        
        /// <summary>
        /// 是否为数字类型
        /// </summary>
        public bool IsNumeric { get; set; }
        
        /// <summary>
        /// TypeScript 类型：string, number, boolean
        /// </summary>
        public string TypeScriptType { get; set; }
        
        /// <summary>
        /// 初始值：'0' 或 "''"
        /// </summary>
        public string InitValue { get; set; }
    }

    /// <summary>
    /// 字段信息（用于模板中显示可用字段列表）
    /// </summary>
    public class FieldInfo
    {
        /// <summary>
        /// 字段名称（如：userId, dataBaseName）
        /// </summary>
        public string FieldName { get; set; }
        
        /// <summary>
        /// TypeScript 类型（string/number/boolean/any）
        /// </summary>
        public string TypeScriptType { get; set; }
        
        /// <summary>
        /// C# 类型（如：string, int, bool）
        /// </summary>
        public string CSharpType { get; set; }
    }

    /// <summary>
    /// 字段排序信息（包含比较表达式）
    /// 用于生成 SortFunExportExcel 方法
    /// </summary>
    public class FieldSortInfo
    {
        /// <summary>
        /// 字段名称（如：userId, dataBaseName）
        /// </summary>
        public string FieldName { get; set; }
        
        /// <summary>
        /// TypeScript 类型（string/number/boolean/any）
        /// </summary>
        public string TypeScriptType { get; set; }
        
        /// <summary>
        /// C# 类型（如：string, int, bool）
        /// </summary>
        public string CSharpType { get; set; }
        
        /// <summary>
        /// 比较表达式（如：a.field.localeCompare(b.field) 或 a.field - b.field）
        /// 根据字段类型自动生成
        /// </summary>
        public string CompareExpression { get; set; }
    }

    /// <summary>
    /// 设置字段值功能定义（用于 AiBase 模板）
    /// 在列表中批量设置某个字段的值
    /// </summary>
    public class AiSetFieldFeature
    {
        /// <summary>
        /// 方法名（如：SetUseStateId）
        /// </summary>
        public string MethodName { get; set; }
        
        /// <summary>
        /// 驼峰式方法名（如：setUseStateId）
        /// </summary>
        public string MethodNameCamel { get; set; }
        
        /// <summary>
        /// 按钮方法名（如：btnSetUseStateId_Click）
        /// </summary>
        public string ButtonMethodName { get; set; }
        
        /// <summary>
        /// 字段名（如：UseStateId）
        /// </summary>
        public string FieldName { get; set; }
        
        /// <summary>
        /// 驼峰式字段名（如：useStateId）
        /// </summary>
        public string FieldNameCamel { get; set; }
        
        /// <summary>
        /// 字段中文名（如：使用状态Id）
        /// </summary>
        public string FieldCnName { get; set; }
        
        /// <summary>
        /// 下拉框控件ID（如：ddlUseStateId）
        /// </summary>
        public string DdlId { get; set; }
        
        /// <summary>
        /// 关联表名（如：UseState）
        /// </summary>
        public string RelatedTableName { get; set; }
        
        /// <summary>
        /// 🔥 新增：关联表所属模块名（如：SysPara, PrjFunction）
        /// </summary>
        public string RelatedModuleName { get; set; }
        
        /// <summary>
        /// 🔥 新增：字段的 TypeScript 类型（如：string, number, boolean）
        /// </summary>
        public string FieldTypeScript { get; set; }
        
        /// <summary>
        /// 🔥 新增：参数前缀（如：str, bol, num）
        /// </summary>
        public string ParamPrefix { get; set; }
        
        /// <summary>
        /// 🔥 新增：是否需要空值验证（布尔类型不需要）
        /// </summary>
        public bool NeedsValidation { get; set; }
    }

    /// <summary>
    /// Ai HTML 模板数据模型（用于生成 .vue 文件）
    /// </summary>
    public class AiHtmlTemplateModel
    {
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public string ViewTitle { get; set; }

        /// <summary>
        /// 是否有设置字段值功能
        /// </summary>
        public bool HasSetFieldFeature { get; set; }

        /// <summary>
        /// 设置字段值功能的字段列表（如 useStateId_f, funcModuleId_f）
        /// </summary>
        public List<string> SetFieldVariables { get; set; } = new List<string>();

        /// <summary>
        /// 🔥 新增：界面变量初始化代码（完整的 TypeScript 代码）
        /// </summary>
        public string ViewVariablesInitCode { get; set; } = string.Empty;
    }
    /// <summary>
    /// Ai 查询选项数组信息
    /// </summary>
    public class AiHtmlQueryOption
    {
        public string ArrayVariableName { get; set; }  // 如 arrFunctionTemplate
        public string OptionsKey { get; set; }         // 如 functionTemplate
        public string OptionsWApiClass { get; set; }   // 🔥 新增：WApi 类名，如 FunctionTemplate, vCodeType_Sim
        public string ModuleName { get; set; }         // 🔥 新增：模块名，如 PrjFunction
        
        /// <summary>
        /// 🔥 新增：值字段名（如 functionTemplateId, codeTypeId）
        /// 从 TabFeatureFlds 中获取的实际值字段名
        /// </summary>
        public string ValueFieldName { get; set; }
        
        /// <summary>
        /// 🔥 新增：文本字段名（如 functionTemplateName, codeTypeName）
        /// 从 TabFeatureFlds 中获取的实际文本字段名
        /// </summary>
        public string TextFieldName { get; set; }
    }

    /// <summary>
    /// Ai HTML 查询字段
    /// </summary>
    public class AiHtmlQueryField
    {
        public string Key { get; set; }
        public string Label { get; set; }
        public string Id { get; set; }
        public string ControlType { get; set; }
        public int Width { get; set; }
        public string OptionsKey { get; set; }
        public string OptionsWApiClass { get; set; }
        public string OptionsModuleName { get; set; }  // 模块名
        
        /// <summary>
        /// 🔥 新增：值字段名（如 functionTemplateId, codeTypeId）
        /// 从 TabFeatureFlds 中获取的实际值字段名
        /// </summary>
        public string ValueFieldName { get; set; }
        
        /// <summary>
        /// 🔥 新增：文本字段名（如 functionTemplateName, codeTypeName）
        /// 从 TabFeatureFlds 中获取的实际文本字段名
        /// </summary>
        public string TextFieldName { get; set; }
        
        public int Row { get; set; }
    }

    /// <summary>
    /// Ai HTML 命令按钮定义
    /// </summary>
    public class AiHtmlCommand
    {
        public string Id { get; set; }              // query / create / delete
        public string Text { get; set; }            // 查询 / 添加 / 删除
        public string ElementId { get; set; }       // btnQuery / btnCreate
        public string BtnClass { get; set; }        // btn btn-primary btn-sm
        public bool NeedAuxControl { get; set; }    // 是否需要辅助控件（如下拉框）
    }

    /// <summary>
    /// ExAi 扩展类模板数据模型
    /// </summary>
    public class ExAiTemplateModel
    {
        public string strIsShare { get; set; }
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public bool HasCacheMode { get; set; }
        public bool IsKeyFieldNumeric { get; set; }
        public string KeyFieldInitValue { get; set; }

        public bool IsUseFunc { get; set; }                 // 🔥 新增：是否有字段映射转换（需要Ex函数）
        public bool IsMultiKey { get; set; }  // 🔥 NEW: 是否为多关键字表

        // 绑定函数名称
        public string BindGvFuncName { get; set; }

        // 🔥 CRUD 功能标志
        public bool HasQueryFeature { get; set; }
        public bool HasCreateFeature { get; set; }
        public bool HasDetailFeature { get; set; }
        public bool HasUpdateFeature { get; set; }
        public bool HasDeleteFeature { get; set; }
        public bool HasExportFeature { get; set; }
        public bool HasCopyFeature { get; set; }
        public bool HasAdjustOrderNum { get; set; }


        public List<ExAiSortColumn> SortColumns { get; set; } = new List<ExAiSortColumn>();
        public List<ExAiCommandMapping> CommandMappings { get; set; } = new List<ExAiCommandMapping>();
        public List<KeyFieldInfo> KeyFields { get; set; } = new List<KeyFieldInfo>();  // 🔥 NEW: 多关键字字段列表
    }

    /// <summary>
    /// 排序列配置
    /// </summary>
    public class ExAiSortColumn
    {
        public string ColumnKey { get; set; }           // 列键名（如 "functionTemplateName|Ex"）
        public string SortExpression { get; set; }      // 排序表达式（包含关联信息）
    }

    /// <summary>
    /// ExAi 命令映射定义
    /// </summary>
    public class ExAiCommandMapping
    {
        public string CommandName { get; set; }         // SetUseStateId / SetFuncModuleId
        public string CommandId { get; set; }           // setUseState / setFuncModule
        public string FeatureId { get; set; }           // 0148
        public string MethodName { get; set; }          // SetUseStateId / SetFuncModuleId（用于调用方法）
    }

    /// <summary>
    /// 界面变量详细信息
    /// </summary>
    public class ViewVariableDetail
    {
        public string VarName { get; set; }              // 变量名：ProgLangTypeId_Static
        public string VarType { get; set; }              // 变量类型：string/number/boolean
        public string RetrievalMethod { get; set; }      // 获取方式：Undefined_01/RouteParameters_02等
        public string InitExpression { get; set; }       // 初始化表达式
        public bool NeedImport { get; set; }             // 🔥 新增：是否需要从 VueShare 导入
    }

    #endregion
 
    /// <summary>
    /// 🔥 Ai HTML 列表模板数据模型（用于生成完整的 .vue 文件，包含列表功能）
    /// </summary>
    public class ListAiHtmlTemplateModelBak
    {
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public string ViewTitle { get; set; }
        
        /// <summary>
        /// 是否需要 userStore
        /// </summary>
        public bool NeedsUserStore { get; set; } = false;

        /// <summary>
        /// 是否需要 route (useRoute)
        /// </summary>
        public bool NeedsRoute { get; set; } = false;
        /// <summary>
        /// 是否有设置字段值功能
        /// </summary>
        public bool HasSetFieldFeature { get; set; }

        /// <summary>
        /// 设置字段值功能的字段列表（如 useStateId_f, funcModuleId_f）
        /// </summary>
        public List<string> SetFieldVariables { get; set; } = new List<string>();

        /// <summary>
        /// 界面变量列表（需要从 VueShare 导入的变量名）
        /// </summary>
        public List<string> ViewVariables { get; set; } = new List<string>();

        /// <summary>
        /// 界面变量详细信息列表
        /// </summary>
        public List<ViewVariableDetail> ViewVariableDetails { get; set; } = new List<ViewVariableDetail>();

        /// <summary>
        /// 🔥 界面变量初始化代码（字符串形式 - 已废弃，使用 ViewVariablesInitCodeLines）
        /// </summary>
        [Obsolete("使用 ViewVariablesInitCodeLines 替代")]
        public string ViewVariablesInitCode { get; set; } = string.Empty;

        /// <summary>
        /// 🔥 界面变量初始化代码行数组（用于模板逐行输出）
        /// </summary>
        public List<string> ViewVariablesInitCodeLines { get; set; } = new List<string>();

        /// <summary>
        /// VueShare 文件名
        /// </summary>
        public string VueShareFileName { get; set; } = string.Empty;

        /// <summary>
        /// VueShare 导入路径
        /// </summary>
        public string VueShareImportPath { get; set; } = string.Empty;

        /// <summary>
        /// 查询选项数组列表
        /// </summary>
        public List<AiHtmlQueryOption> QueryOptionsArrays { get; set; } = new List<AiHtmlQueryOption>();

        /// <summary>
        /// 查询字段列表
        /// </summary>
        public List<AiHtmlQueryField> QueryFields { get; set; } = new List<AiHtmlQueryField>();

        /// <summary>
        /// 查询命令按钮列表
        /// </summary>
        public List<AiHtmlCommand> QueryCommands { get; set; } = new List<AiHtmlCommand>();

        /// <summary>
        /// 功能命令按钮列表
        /// </summary>
        public List<AiHtmlCommand> FeatureCommands { get; set; } = new List<AiHtmlCommand>();

        /// <summary>
        /// 选项键列表
        /// </summary>
        public List<string> OptionKeys { get; set; } = new List<string>();
    }

    public class ListAiHtmlTemplateModel
    {
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public string ViewTitle { get; set; }
        public string strIsShare { get; set; }
        // 🔥 新增：多关键字支持
        public bool IsMultiKey { get; set; }
        public List<KeyFieldInfo> KeyFields { get; set; } = new List<KeyFieldInfo>();

        /// <summary>
        /// 是否有设置字段值功能
        /// </summary>
        public bool HasSetFieldFeature { get; set; }

        /// <summary>
        /// 🔥 是否有详细信息功能
        /// </summary>
        public bool HasDetailFeature { get; set; }
        public bool HasExportFeature { get; set; }
        public bool HasAdjustOrderNum { get; set; }

        public List<string> SetFieldVariables { get; set; } = new List<string>();
        public List<string> ViewVariables { get; set; } = new List<string>();
        public List<ViewVariableDetail> ViewVariableDetails { get; set; } = new List<ViewVariableDetail>();

        public string ViewVariablesInitCode { get; set; } = string.Empty;
        public bool NeedsUserStore { get; set; } = false;
        public bool NeedsRoute { get; set; } = false;
        public bool NeedsSessionStorage { get; set; } = false;

        public string VueShareFileName { get; set; } = string.Empty;
        public string VueShareImportPath { get; set; } = string.Empty;

        public List<AiHtmlQueryOption> QueryOptionsArrays { get; set; } = new List<AiHtmlQueryOption>();
        public List<AiHtmlQueryOption> QueryOptionsArrays4Import { get; set; } = new List<AiHtmlQueryOption>();

        public List<AiHtmlQueryOption> FeatureOptionsArrays { get; set; } = new List<AiHtmlQueryOption>();
        public List<AiHtmlQueryOption> FeatureOptionsArrays4Import { get; set; } = new List<AiHtmlQueryOption>();


        public List<AiHtmlQueryField> QueryFields { get; set; } = new List<AiHtmlQueryField>();

        /// <summary>
        /// 🔥 新增：功能区下拉框选项信息
        /// </summary>
        public List<AiOptionsInfo> FeatureOptions { get; set; } = new List<AiOptionsInfo>();
        public List<AiOptionsInfo> FeatureOptions4DS { get; set; } = new List<AiOptionsInfo>();


        public List<AiHtmlCommand> QueryCommands { get; set; } = new List<AiHtmlCommand>();
        public List<AiHtmlCommand> FeatureCommands { get; set; } = new List<AiHtmlCommand>();
        public List<string> OptionKeys { get; set; } = new List<string>();
        public List<string> OptionKeysInFeature { get; set; } = new List<string>();
        public List<string> OptionKeysInFeature4DS { get; set; } = new List<string>();

    }
    /// <summary>
    /// DetailEx 扩展类模板数据模型
    /// </summary>
    public class DetailExTemplateModel
    {
        // 基础字段
        public string TableName { get; set; }
        public string TableId { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string ViewId { get; set; }
        public string ViewName { get; set; }
        public bool IsMultiKey { get; set; }  // 🔥 是否为多关键字表
        
        // 详细注释字段（Verbose 模式）
        public string GenerateDate { get; set; }
        public string GenerateDateShort { get; set; }
        public string ServerName { get; set; }
        public string DatabaseServer { get; set; }
        public string DatabaseName { get; set; }
        public string PrjDataBaseId { get; set; }
        public string PrjId { get; set; }
        public string PrjName { get; set; }
        public string CMProjectId { get; set; }
        public string CMProjectName { get; set; }
        public string FrameworkLayer { get; set; }
        public string Generator { get; set; }
        
        public CommentVerbosity CommentMode { get; set; } = CommentVerbosity.Compact;
    }
}
