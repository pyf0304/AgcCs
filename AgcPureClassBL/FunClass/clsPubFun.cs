using AGC.BusinessLogic;
using AgcCommBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agc.PureClassEx
{
    public class clsPubFun
    {
        /// <summary>
        /// 生成与
        /// </summary>
        /// <param name="strVarName"></param>
        /// <param name="strTypeScriptType"></param>
        /// <param name="strDataTypeId"></param>
        /// <param name="strClassName"></param>
        /// <param name="strFuncName"></param>
        /// <param name="intFldLen"></param>
        /// <param name="bolIsCheckLength"></param>
        /// <param name="objImportClass"></param>
        /// <param name="strBaseUrl"></param>
        /// <returns></returns>
        public static string Gc_CheckVarEmpty_Ts(string strVarName, string strTypeScriptType, string strDataTypeId, string strClassName, string strFuncName, int intFldLen, bool bolIsCheckLength, IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder sbCheckEmpty = new StringBuilder();
            if (strTypeScriptType == "number")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if ({0} == 0)", strVarName);
                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = Format(\"参数:[{0}]不能为空!(In {1}.{2})\");",
                    strVarName, strClassName, strFuncName);
                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
            }
            else if (strTypeScriptType == "string")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", strVarName);
                objImportClass.AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = Format(\"参数:[{0}]不能为空!(In {1}.{2})\");",
                    strVarName, strClassName, strFuncName);
                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
                if (bolIsCheckLength == true && strDataTypeId == enumDataTypeAbbr.char_04)
                {
                    sbCheckEmpty.AppendFormat("\r\n" + "if ({0}.length != {1})", strVarName, intFldLen);
                    sbCheckEmpty.Append("\r\n" + "{");
                    sbCheckEmpty.AppendFormat("\r\n" + "const strMsg = Format(\"缓存分类变量:[{0}]的长度:[{{0}}]不正确!({1}.{2})\", {0}.length);",
                        strVarName, strClassName, strFuncName);
                    sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                    sbCheckEmpty.Append("\r\n" + "throw (strMsg);");
                    sbCheckEmpty.Append("\r\n" + "}");
                }
            }
            return sbCheckEmpty.ToString();
        }

    }
}
