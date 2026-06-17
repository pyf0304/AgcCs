using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgcCommBase
{
    public class clsVariable
    {
        /// <summary>
        /// 变量名
        /// </summary>
        public string VariableName { get; set; }
        /// <summary>
        /// 字段名
        /// </summary>
        public string FldName { get; set; }
        public string ClassName { get; set; }
        public string FilePath { get; set; }

        /// <summary>
        /// 变量类型
        /// </summary>
        public string VariableType { get; set; }
        public string Variable4InitValue { get; set; }
        public string InitValue { get; set; }
        public clsVariable(string strVariableName, string strVariableType = "", string strFldName = "", string strClassName="", string strFilePath="")
        {
            this.VariableName = strVariableName;
            this.VariableType = strVariableType;
            this.FldName = strFldName;
            this.ClassName = strClassName;
            this.FilePath = strFilePath;
        }
    }

    public class clsViewVariable
    {
        public string ParamName { get; set; }        // 参数名，如 strProgLangTypeId
        public string SharedVarName { get; set; }    // 共享变量名，如 strProgLangTypeId_Static
        public string FldId { get; set; }            // 条件字段ID
        public bool IsNumberType { get; set; } 
        public string VarId { get; set; }
        public string ViewName { get; set; }
        /// <summary>
        /// 变量名
        /// </summary>
        public string VariableName { get; set; }
        /// <summary>
        /// 字段名
        /// </summary>
        public string FldName { get; set; }
        public string ClassName { get; set; }
        public string FilePath { get; set; }

        /// <summary>
        /// 变量类型
        /// </summary>
        public string VariableType { get; set; }
        public string Variable4InitValue { get; set; }
        public string InitValue { get; set; }
     
    }
}
