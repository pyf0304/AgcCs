using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.common;

namespace AgcCommBase
{
public    class clsVarManage
    {
        public string ProgLangTypeName { get; set; }
        private List<clsVariable> arrVariable = null;
        public clsVarManage(string strProgLangTypeName)
        {
            this.ProgLangTypeName = strProgLangTypeName;
            arrVariable = new List<clsVariable>();
        }
        public bool AddVariable(clsVariable objVariable)
        {
            if (string.IsNullOrEmpty(objVariable.VariableName) == true) return false;
            if (arrVariable.Find(x => x.VariableName == objVariable.VariableName) == null)
            {
                arrVariable.Add(objVariable);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<clsVariable> GetObjLst()
        {
            return arrVariable;
        }
        public clsVariable GetVariable(string strVariableName)
        {
            clsVariable obj = arrVariable.Find(x => x.VariableName == strVariableName);
            return obj;
        }

        public void SetVariableProp(string strVariableName, string strInitValue, string strVariable4InitValue)
        {
            clsVariable objVariable = arrVariable.Find(x => x.VariableName == strVariableName);
            if (objVariable == null)
            {
                string strMsg = string.Format("变量:{0}还没有添加定义！(In {1})", strVariableName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            objVariable.InitValue = strInitValue;
            if (string.IsNullOrEmpty(strVariable4InitValue) == false)
            {
                objVariable.Variable4InitValue = strVariable4InitValue;
            }
        }


        private string DefVariable(clsVariable objVariable)
        {
         
            StringBuilder sbBuilder = new StringBuilder();
            switch(this.ProgLangTypeName)
            {
                case "JavaScript":
                    sbBuilder.AppendFormat("var {0}", objVariable.VariableName);
                    if (string.IsNullOrEmpty(objVariable.Variable4InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};", objVariable.Variable4InitValue);
                        return sbBuilder.ToString();
                    }
                    if (string.IsNullOrEmpty(objVariable.InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};", objVariable.InitValue);
                        return sbBuilder.ToString();
                    }
                    sbBuilder.Append(";");
                    return sbBuilder.ToString();
                case "TypeScript":
                    sbBuilder.AppendFormat("const {0}", objVariable.VariableName);
                    if (string.IsNullOrEmpty(objVariable.Variable4InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};", objVariable.Variable4InitValue.Replace("_", ""));
                        return sbBuilder.ToString();
                    }
                    if (string.IsNullOrEmpty(objVariable.InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};", objVariable.InitValue);
                        return sbBuilder.ToString();
                    }
                    sbBuilder.Append(";");
                    return sbBuilder.ToString();

                case "CSharp":
                    sbBuilder.AppendFormat("var {0}", objVariable.VariableName);
                    if (string.IsNullOrEmpty(objVariable.Variable4InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};", objVariable.Variable4InitValue);
                        return sbBuilder.ToString();
                    }
                    if (string.IsNullOrEmpty(objVariable.InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};", objVariable.InitValue);
                        return sbBuilder.ToString();
                    }
                    sbBuilder.Append(";");
                    return sbBuilder.ToString();

                //                    break;
                default:
                    string strMsg = string.Format("在定义变量过程中，语言:{0}没有处理！", this.ProgLangTypeName);
                    throw new Exception(strMsg);                  
            }
        }

        /// <summary>
        /// 用于函数参数的变量列表
        /// </summary>
        /// <returns></returns>
        public string ParaVarDefLstStr()
        {
            StringBuilder sbBuilder = new StringBuilder();

            foreach (var objVariable in this.arrVariable)
            {
                switch (this.ProgLangTypeName)
                {
                    case "JavaScript":
                        sbBuilder.AppendFormat("{0} {1},", objVariable.VariableType, objVariable.VariableName);
                        break;
                    case "TypeScript":
                        sbBuilder.AppendFormat("{0}:{1},", objVariable.VariableName, objVariable.VariableType);
                        break;

                    case "CSharp":
                        sbBuilder.AppendFormat("{0} {1},", objVariable.VariableType, objVariable.VariableName);
                        break;
                    //                    break;
                    default:
                        string strMsg = string.Format("在定义变量过程中，语言:{0}没有处理！", this.ProgLangTypeName);
                        throw new Exception(strMsg);
                }
            }
            if (sbBuilder.Length > 3)
            {
                sbBuilder = sbBuilder.Remove(sbBuilder.Length - 1, 1);
            }
            return sbBuilder.ToString();
        }
        /// <summary>
        /// 用于函数参数的变量列表
        /// </summary>
        /// <returns></returns>
        public string ParaVarLstStr()
        {
            StringBuilder sbBuilder = new StringBuilder();

            foreach (var objVariable in this.arrVariable)
            {
                switch (this.ProgLangTypeName)
                {
                    case "JavaScript":
                        sbBuilder.AppendFormat("{0},", objVariable.VariableName);
                        break;
                    case "TypeScript":
                        sbBuilder.AppendFormat("{0},", objVariable.VariableName);
                        break;

                    case "CSharp":
                        sbBuilder.AppendFormat("{0},", objVariable.VariableName);
                        break;
                    //                    break;
                    default:
                        string strMsg = string.Format("在定义变量过程中，语言:{0}没有处理！", this.ProgLangTypeName);
                        throw new Exception(strMsg);
                }
            }
            if (sbBuilder.Length > 3)
            {
                sbBuilder = sbBuilder.Remove(sbBuilder.Length - 1, 1);
            }
            return sbBuilder.ToString();
        }

        public List<string> ParaVarLst()
        {
            List<string> arrLst = new List<string>();

            foreach (var objVariable in this.arrVariable)
            {
                switch (this.ProgLangTypeName)
                {
                    case "JavaScript":
                        arrLst.Add(objVariable.VariableName);
                        break;
                    case "TypeScript":
                        arrLst.Add(objVariable.VariableName);
                        break;

                    case "CSharp":
                        arrLst.Add(objVariable.VariableName);
                        break;
                    //                    break;
                    default:
                        string strMsg = string.Format("在定义变量过程中，语言:{0}没有处理！", this.ProgLangTypeName);
                        throw new Exception(strMsg);
                }
            }

            return arrLst;
        }



        public List<string> FldNameLst()
        {
            
            List<string> arrFldName = new List<string>();
            foreach (var objVariable in this.arrVariable)
            {
                if (string.IsNullOrEmpty(objVariable.FldName) == true) continue;
                arrFldName.Add(objVariable.FldName);
            }            
            return arrFldName;
        }


        public string ParaVarLstStr4Cache()
        {
            StringBuilder sbBuilder = new StringBuilder();

            foreach (var objVariable in this.arrVariable)
            {
                if (objVariable.VariableType != "Cache") continue;
                switch (this.ProgLangTypeName)
                {
                    case "JavaScript":
                        sbBuilder.AppendFormat("{0},", objVariable.VariableName);
                        break;
                    case "TypeScript":
                        sbBuilder.AppendFormat("{0},", objVariable.VariableName);
                        break;

                    case "CSharp":
                        sbBuilder.AppendFormat("{0},", objVariable.VariableName);
                        break;
                    //                    break;
                    default:
                        string strMsg = string.Format("在定义变量过程中，语言:{0}没有处理！", this.ProgLangTypeName);
                        throw new Exception(strMsg);
                }
            }
            if (sbBuilder.Length > 3)
            {
                sbBuilder = sbBuilder.Remove(sbBuilder.Length - 1, 1);
            }
            return sbBuilder.ToString();
        }

        public string GetVarLstDefStr(IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder sbBuilder = new StringBuilder();

            foreach (var objVariable in this.arrVariable)
            {
                var strTempCode = DefVariable(objVariable);


                sbBuilder.AppendLine(strTempCode);
                if (string.IsNullOrEmpty(objVariable.ClassName) == false)
                {
                    objImportClass.AddImportClass("", objVariable.FilePath, objVariable.ClassName, enumImportObjType.CustomFunc, strBaseUrl);
                }
            }
            return sbBuilder.ToString();
        }

    }
}
