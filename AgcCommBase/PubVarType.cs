using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{
    
    public class PubVarType
    {
        public string FldId;
        public string FldName;
        public string VarName;
        public string VarName4Get;
        public gcVarType VarType;
        public string TypeScriptType;
        //public bool IsSession;
        //public bool IsCache;
        public bool IsStatic;
        public string DefaultValue;//缺省值
        public bool IsNeedDefine;//是否需要定义
        public string Memo;//备注

    }
}
