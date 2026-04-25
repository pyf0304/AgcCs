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
    /// 生成 Ai4 版本的命令配置 TypeScript 文件
    /// 用于定义查询区和功能区的按钮
    /// </summary>
    partial class Vue_ViewScriptCommands_TS4TypeScript : Vue_ViewScriptCS_TS4TypeScript
    {
        private readonly RenderService _renderService;

        public Vue_ViewScriptCommands_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            _renderService = new RenderService();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            base.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

            strRe_ClsName = strRe_ClsName + "Ai4Command";
            strRe_FileNameWithModuleName = $"{objFuncModuleEN.FuncModuleEnName}/{strRe_ClsName}";

            var model = BuildCommandTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/Ai4Command.sbn", model);
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n" +
                              $"错误类型: {ex.GetType().Name}\n" +
                              $"错误消息: {ex.Message}\n" +
                              $"堆栈跟踪: {ex.StackTrace}";

                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderCommandError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染命令模板失败: {ex.Message}", ex);
            }

            // 调试：写入渲染结果
            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedCommand_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private Ai4CommandTemplateModel BuildCommandTemplateModel()
        {
            var model = new Ai4CommandTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameUpper = ConvertToSnakeCase(TabName_Out4ListRegion4GC).ToUpper()
            };

            // 添加查询区按钮
            AddQueryCommands(model);

            // 添加功能区按钮
            AddFeatureCommands(model);

            return model;
        }

        /// <summary>
        /// 添加查询区命令
        /// </summary>
        private void AddQueryCommands(Ai4CommandTemplateModel model)
        {
            // 查询按钮（默认存在）
            model.Commands.Add(new Ai4Command
            {
                Id = "query",
                Region = "query",
                Text = "查询",
                ElementId = "btnQuery_Ai4",
                BtnClass = "btn btn-outline-warning text-nowrap",
                NeedAuxControl = false
            });

            // 导出按钮（如果启用了导出功能）
            if (objViewInfoENEx.arrViewFeatureFlds.Any(x => x.FeatureId == enumPrjFeature.SetExportExcel4User_0144))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "export",
                    Region = "query",
                    Text = "导出Excel",
                    ElementId = "btnExportExcel_Ai4",
                    BtnClass = "btn btn-outline-warning text-nowrap",
                    NeedAuxControl = false
                });
            }
        }

        /// <summary>
        /// 添加功能区命令
        /// </summary>
        private void AddFeatureCommands(Ai4CommandTemplateModel model)
        {
            var featureRegionFlds = objViewInfoENEx.arrFeatureRegionFlds
                //.Where(x => x.RegionTypeId() == enumRegionType.FeatureRegion_0008)
                .ToList();

            // 添加新记录
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.AddNewRecord_0136))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "create",
                    Region = "feature",
                    Text = "添加",
                    ElementId = "btnCreate_Ai4",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 修改记录
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.UpdateRecord_0137))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "update",
                    Region = "feature",
                    Text = "修改",
                    ElementId = "btnUpdate_Ai4",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 删除记录
            if (featureRegionFlds.Any(x => x.FeatureId == enumPrjFeature.DelRecord_0138))
            {
                model.Commands.Add(new Ai4Command
                {
                    Id = "delete",
                    Region = "feature",
                    Text = "删除",
                    ElementId = "btnDelete_Ai4",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = false
                });
            }

            // 设置字段值（如设置使用状态）
            var setFieldFeatures = featureRegionFlds.Where(x => x.FeatureId == enumPrjFeature.SetFieldValue_0148).ToList();
            foreach (var feature in setFieldFeatures)
            {
                var commandId = ToCamelCase("set" + feature.CommandName);
                model.Commands.Add(new Ai4Command
                {
                    Id = commandId,
                    Region = "feature",
                    Text = feature.CommandName,
                    ElementId = $"btn{feature.CommandName}_Ai4",
                    BtnClass = "btn btn-outline-info btn-sm text-nowrap",
                    NeedAuxControl = true  // 需要辅助控件（如下拉框）
                });
            }
        }

        /// <summary>
        /// 将 PascalCase 转换为 SNAKE_CASE
        /// </summary>
        private string ConvertToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var result = new StringBuilder();
            result.Append(char.ToUpper(input[0]));

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    result.Append('_');
                }
                result.Append(char.ToUpper(input[i]));
            }

            return result.ToString();
        }

        private string ToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }
    }
}