using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
                    
                    // 如果是集合类型（如 List<Ai2ColumnField>）
                    if (propValue is IList list)
                    {
                        var scriptArray = new ScriptArray();
                        
                        foreach (var item in list)
                        {
                            // 为每个列表项创建 ScriptObject
                            var itemObject = new ScriptObject();
                            
                            if (item != null)
                            {
                                foreach (var itemProp in item.GetType().GetProperties())
                                {
                                    if (itemProp.GetIndexParameters().Length > 0)
                                    {
                                        continue;
                                    }

                                    try
                                    {
                                        var itemPropValue = itemProp.GetValue(item);
                                        itemObject[itemProp.Name] = itemPropValue;
                                    }
                                    catch
                                    {
                                        // 静默跳过无法访问的属性
                                    }
                                }
                            }
                            
                            scriptArray.Add(itemObject);
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

    public class Ai2ColumnsTemplateModel
    {
        public string TableName { get; set; }
        public string ModuleName { get; set; }
        public bool HasExtendFields { get; set; }
        public List<Ai2ColumnField> Fields { get; set; } = new List<Ai2ColumnField>();
    }

    public class Ai2ColumnField
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
    /// Ai3 查询字段模板数据模型
    /// </summary>
    public class Ai3QueryTemplateModel
    {
        public string TableName { get; set; }
        public string ModuleName { get; set; }
        public List<Ai3QueryField> QueryFields { get; set; } = new List<Ai3QueryField>();
        public List<Ai3OptionsInfo> OptionsInfo { get; set; } = new List<Ai3OptionsInfo>();  // 🔥 替换 OptionsKeys
    }

    /// <summary>
    /// 查询字段定义
    /// </summary>
    public class Ai3QueryField
    {
        public string Key { get; set; }
        public string Label { get; set; }
        public string Id { get; set; }
        public string ControlType { get; set; }
        public int Width { get; set; }
        public int Row { get; set; }
        public int Order { get; set; }
        public string OptionsKey { get; set; }
        public string OptionsWApiClass { get; set; }  // 🔥 新增：WApi 类名
        public string DefaultValue { get; set; }
    }

    /// <summary>
    /// 选项数据源信息
    /// </summary>
    public class Ai3OptionsInfo
    {
        public string Key { get; set; }           // 如 dataBaseType
        public string WApiClass { get; set; }     // 如 DataBaseType
    }

    /// <summary>
    /// Ai4 命令配置模板数据模型
    /// </summary>
    public class Ai4CommandTemplateModel
    {
        public string TableName { get; set; }
        public string TableNameUpper { get; set; }
        public List<Ai4Command> Commands { get; set; } = new List<Ai4Command>();
    }

    /// <summary>
    /// 命令定义
    /// </summary>
    public class Ai4Command
    {
        public string Id { get; set; }
        public string Region { get; set; }
        public string Text { get; set; }
        public string ElementId { get; set; }
        public string BtnClass { get; set; }
        public bool NeedAuxControl { get; set; }
    }

    /// <summary>
    /// Ai4 基类模板数据模型
    /// </summary>
    public class Ai4BaseTemplateModel
    {
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableNameUpper { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        
        public bool HasDeleteFeature { get; set; }
        public bool HasExportFeature { get; set; }
        
        public List<Ai4SetFieldFeature> SetFieldFeatures { get; set; } = new List<Ai4SetFieldFeature>();
    }

    /// <summary>
    /// 设置字段值功能定义
    /// </summary>
    public class Ai4SetFieldFeature
    {
        public string MethodName { get; set; }           // SetUseStateId
        public string MethodNameCamel { get; set; }      // setUseStateId
        public string ButtonMethodName { get; set; }     // btnSetUseStateId_Click
        public string FieldName { get; set; }            // UseStateId
        public string FieldNameCamel { get; set; }       // useStateId
        public string FieldCnName { get; set; }          // 使用状态Id
        public string DdlId { get; set; }                // ddlUseStateId
        public string RelatedTableName { get; set; }     // 🔥 添加这个属性：UseState
    }

    /// <summary>
    /// Edit 编辑区模板数据模型
    /// </summary>
    public class EditAiTemplateModel
    {
        public string TableName { get; set; }
        public string TableNameCamel { get; set; }
        public string TableCnName { get; set; }
        public string ModuleName { get; set; }
        public string KeyField { get; set; }
        public string KeyFieldCamel { get; set; }
        public string PrimaryTypeId { get; set; }
        public string ViewId { get; set; }
        public string ViewName { get; set; }
        public string GenerateDate { get; set; }  // 🔥 添加
        public string ServerName { get; set; }    // 🔥 添加
    }

    #endregion
}
