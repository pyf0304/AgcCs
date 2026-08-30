using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AutoGCLib.Templates;
using com.taishsoft.common;
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
    partial class Vue_ViewScript_ListAi4Html : clsGeneCodeBase4View
    {
        private clsFuncModule_AgcEN objFuncModule = null;
        private readonly RenderService _renderService;

        public Vue_ViewScript_ListAi4Html(string strViewId, string strPrjDataBaseId, string strPrjId)
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

            var model = BuildListAiHtmlTemplateModel();

            string result = "";

            try
            {
                result = _renderService.Render("TypeScript/ListAiHtml.sbn", model);
            }
            catch (Exception ex)
            {
                var errorMsg = $"模板渲染失败:\n错误: {ex.Message}\n堆栈: {ex.StackTrace}";
                if (ex.InnerException != null)
                {
                    errorMsg += $"\n内部异常: {ex.InnerException.Message}";
                }

                var errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderListAiHtmlError_Debug.log");
                File.WriteAllText(errorLogFile, errorMsg, Encoding.UTF8);
                Console.WriteLine(errorMsg);

                throw new InvalidOperationException($"渲染ListAiHtml模板失败: {ex.Message}", ex);
            }

            var debugFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RenderedListAiHtml_Debug.txt");
            File.WriteAllText(debugFile, result, Encoding.UTF8);

            return result;
        }

        private ListAiHtmlTemplateModel BuildListAiHtmlTemplateModel()
        {
            var model = new ListAiHtmlTemplateModel
            {
                TableName = TabName_Out4ListRegion4GC,
                TableNameCamel = ToCamelCase(TabName_Out4ListRegion4GC),
                TableCnName = TabCnName_In4Edit4GC,
                ModuleName = objFuncModuleEN.FuncModuleEnName,
                KeyField = objKeyField.FldName(),
                KeyFieldCamel = ToCamelCase(objKeyField.FldName()),
                ViewTitle = $"{TabCnName_In4Edit4GC}维护(Ai版-命令Schema)"
            };

            // 🔥 新增：处理多关键字字段
            if (PrjTabEx_ListRegion != null && PrjTabEx_ListRegion.arrKeyFldSet != null)
            {
                model.IsMultiKey = PrjTabEx_ListRegion.arrKeyFldSet.Count > 1;
                
                foreach (var keyFld in PrjTabEx_ListRegion.arrKeyFldSet)
                {
                    var fieldTab = keyFld.ObjFieldTabENEx;
                    model.KeyFields.Add(new KeyFieldInfo
                    {
                        FieldName = fieldTab.FldName,
                        FieldNameCamel = ToCamelCase(fieldTab.FldName),
                        PropertyName = fieldTab.PrivPropName,
                        IsNumber = fieldTab.IsNumberType(),
                        TypeScriptType = fieldTab.TypeScriptType(),
                        InitValue = fieldTab.IsNumberType() ? "0" : "''"
                    });
                }
            }

            // 🔥 提取设置字段值功能的字段变量名
            ExtractSetFieldVariables(model);

            return model;
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
                        string variableName = ToCamelCase(objFieldTab.FldName) + "_f";
                        model.SetFieldVariables.Add(variableName);
                    }
                }
            }
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
        /// 获取选项数据源的 key
        /// 例如：DataBaseTypeId → dataBaseType
        /// </summary>
        private string GetOptionsKey(clsQryRegionFldsENEx field)
        {
            if (!IsSelectControl(field)) return null;
            string fieldName = field.FldName();

            // 移除 Id 后缀并转为驼峰式
            if (fieldName.EndsWith("Id", StringComparison.OrdinalIgnoreCase))
            {
                fieldName = fieldName.Substring(0, fieldName.Length - 2);
            }

            return ToCamelCase(fieldName);
        }

        /// <summary>
        /// 获取选项数据源的 WApi 类名
        /// 例如：DataBaseTypeId → DataBaseType
        /// </summary>
        private string GetOptionsWApiClass(clsQryRegionFldsENEx field)
        {
            string fieldName = field.FldName();

            // 移除 Id 后缀
            if (fieldName.EndsWith("Id", StringComparison.OrdinalIgnoreCase))
            {
                fieldName = fieldName.Substring(0, fieldName.Length - 2);
            }

            // 首字母大写
            return char.ToUpper(fieldName[0]) + fieldName.Substring(1);
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
            return "select";
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
        public override void GetClsName()
        {
            string strClassName = string.Format("{0}_ListAi", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = strClassName;
            objViewInfoENEx.ClsName = this.ClsName;
        }
    }
}