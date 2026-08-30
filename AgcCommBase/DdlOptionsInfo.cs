using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{
    /// <summary>
    /// 🔥 新增：选项函数参数信息
    /// </summary>
    public class DdlOptionParam
    {
        public string ParamName { get; set; }        // 参数名，如 strProgLangTypeId
        public string SharedVarName { get; set; }    // 共享变量名，如 strProgLangTypeId_Static
        public string FldId { get; set; }            // 条件字段ID
        public string VarId { get; set; }            // 界面变量ID
    }
    public class DdlOptionsInfo
    {
        public string FldId { get; set; }             // 如 DataBaseTypeOptions
        public string Key { get; set; }              // 如 dataBaseType
        public bool IsNumberType { get; set; }
        public string FldDataType { get; set; }
        public string ControlType { get; set; }
        public string OptionsKey { get; set; }
        public string WApiClass { get; set; }        // 如 DataBaseType
        public string ArrayVariableName { get; set; }  // 如 arrFunctionTemplate
        public string AuxControlId { get; set; }
        public string AuxControlType { get; set; }
        public string AuxControlOptionsKey { get; set; }
        public string AuxControlLabel { get; set; }
        public bool IsNeedAuxControlLabel { get; set; }=false;
        public string ValueFieldName { get; set; }
        public string TextFieldName { get; set; }

        public string ModuleName { get; set; }       // 如 SysPara
        public string GetDdlDataFuncName { get; set; }     // 获取DdlData完整函数名
        public bool IsExtendedClass { get; set; }    // 是否在扩展类
        public string WApiPath { get; set; }         // WApi 路径
        public string WApiFileName { get; set; }     // WApi 文件名
        public List<DdlOptionParam> Parameters { get; set; } = new List<DdlOptionParam>();  // 🔥 新增：函数参数列表
    }

   

}
