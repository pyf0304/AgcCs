using AGC.BusinessLogic;
using AGC.Entity;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGC.BusinessLogicEx
{

    public class FuncParaType
    {
        public bool IsFstLcase = false;
        public string FldId;
        public string FldName;
        public bool IsForExtendClass;
        public string Caption;
        public string DataTypeId;
        public enumTsValueGivingMode ValueGivingModeId;
        public int FldLen;
        public string VarName;
        public string VarName4Get;
        public tsVarType VarTypeId;
        public tsVarFunction VarFunction;
        public string FilePath;
        public string ClsName;
        public string TypeScriptType;
        public string CsType;
        public string DataTypeAbbr;//数据类型缩写，即变量前面代表类型的3个字符
        //public bool IsSession;
        //public bool IsCache;
        public bool IsStatic;
        public string DefaultValue;//缺省值
        public string Variable4InitValue { set; get; }//以变量代表的初始值
        public string InitValue;//以常量代表的初始值
        public bool IsNeedDefine;//是否需要定义
        public string CodeText;//是否需要定义
        public string ProgLangTypeId;
        public string Memo;//备注

        public string GetTsTypeStr()
        {
            switch (this.VarTypeId)
            {
                case tsVarType.tsGivingValue:
                    return "给定值";
                case tsVarType.tsStatic:
                    return "静态变量";
                case tsVarType.tsCondition:
                    return "条件";
                case tsVarType.tsOther:
                    return "其他";
                case tsVarType.tsSession:
                    return "Session存储、local存储";

                default:
                    return string.Format("在switch中未找到相关类型: {0}(in {1})", this.VarTypeId, clsStackTrace.GetCurrClassFunction());

            }
        }
        public string PropertyName
        {
            get
            {
                if (this.IsFstLcase == false)
                {
                    return this.FldName;
                }
                else
                {
                    return clsString.FstLcaseS(this.FldName);
                }
            }
        }
        public string PrivVarName
        {
            get
            {
                if (this.VarTypeId == tsVarType.tsSession)
                {
                    string strPrivVarName = this.DataTypeAbbr + this.FldName;
                    return strPrivVarName;
                }
                else return this.VarName;
            }
        }
        public string GetFuncParaText()
        {
            StringBuilder sb = new StringBuilder();
            if (this.VarTypeId == tsVarType.tsSession)
            {
                string strPrivVarName = this.DataTypeAbbr + this.FldName;
                sb.AppendFormat("{0}: {1}", strPrivVarName, this.TypeScriptType);
            }
            else sb.AppendFormat("{0}: {1}", this.VarName, this.TypeScriptType);
            this.CodeText = sb.ToString();
            return sb.ToString();
        }

        public string GetFuncParaText4CSharp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", this.CsType, this.VarName);
            this.CodeText = sb.ToString();
            return sb.ToString();
        }

        public string GetFuncParaText4TypeScript()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{1}: {0}", this.TypeScriptType, this.VarName);
            this.CodeText = sb.ToString();
            return sb.ToString();
        }

        public string Gc_CheckVarEmpty_Ts(string strClassName, string strFuncName, bool bolIsCheckLength, IImportClass objImportClass, string strBaseUrl)
        {
            //string this.VarName,  string strDataTypeId, string strClassName, string strFuncName, int intFldLen, 
            ;

            StringBuilder sbCheckEmpty = new StringBuilder();
            if (this.TypeScriptType == "number")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if ({0} == 0)", this.VarName);
                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = Format(\"参数:[{0}]不能为空！(In {1}.{2})\");",
                    this.VarName, strClassName, strFuncName);
                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
            }
            else if (this.TypeScriptType == "string")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", this.VarName);
                objImportClass.AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = Format(\"参数:[{0}]不能为空！(In {1}.{2})\");",
                    this.VarName, strClassName, strFuncName);
                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
                if (bolIsCheckLength == true && this.DataTypeId == enumDataTypeAbbr.char_04)
                {
                    sbCheckEmpty.AppendFormat("\r\n" + "if ({0}.length != {1})", this.VarName, this.FldLen);
                    sbCheckEmpty.Append("\r\n" + "{");
                    sbCheckEmpty.AppendFormat("\r\n" + "const strMsg = Format(\"缓存分类变量:[{0}]的长度:[{{0}}]不正确！({1}.{2})\", {0}.length);",
                        this.VarName, strClassName, strFuncName);
                    sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                    sbCheckEmpty.Append("\r\n" + "throw (strMsg);");
                    sbCheckEmpty.Append("\r\n" + "}");
                }
            }
            return sbCheckEmpty.ToString();
        }


        public string Gc_CheckVarEmpty_Cs(string strClassName, string strFuncName, bool bolIsCheckLength)
        {
            //string this.VarName,  string strDataTypeId, string strClassName, string strFuncName, int intFldLen,           

            StringBuilder sbCheckEmpty = new StringBuilder();
            if (this.CsType == "int" || this.CsType == "long")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if ({0} == 0)", this.VarName);
                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  var strMsg = string.Format(\"参数:[{0}]不能为空！(In {1}.{2})\");",
                    this.VarName, strClassName, strFuncName);
                //sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw new Exception  (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
            }
            else if (this.TypeScriptType == "string")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", this.VarName);

                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  var strMsg = string.Format(\"参数:[{0}]不能为空！(In {1}.{2})\");",
                    this.VarName, strClassName, strFuncName);
                //sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw new Exception  (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
                if (bolIsCheckLength == true && this.DataTypeId == enumDataTypeAbbr.char_04)
                {
                    sbCheckEmpty.AppendFormat("\r\n" + "if ({0}.Length != {1})", this.VarName, this.FldLen);
                    sbCheckEmpty.Append("\r\n" + "{");
                    sbCheckEmpty.AppendFormat("\r\n" + "var strMsg = string.Format(\"缓存分类变量:[{0}]的长度:[{{0}}]不正确！({1}.{2})\", {0}.Length);",
                        this.VarName, strClassName, strFuncName);
                    //sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                    sbCheckEmpty.Append("\r\n" + "throw new Exception (strMsg);");
                    sbCheckEmpty.Append("\r\n" + "}");
                }
            }
            return sbCheckEmpty.ToString();
        }

        public string DefVariable(string strClsName, bool bolIsInVue = false)
        {
            //clsVariable objVariable;
            string strPrivVarName = this.DataTypeAbbr + this.VarName;
            strPrivVarName = strPrivVarName.Replace(this.DataTypeAbbr + this.DataTypeAbbr, this.DataTypeAbbr);

            if (this.VarTypeId == tsVarType.tsSession)
            {
                strPrivVarName = this.DataTypeAbbr + this.FldName;
            }
            string strVariable4InitValue = this.Variable4InitValue;
            switch (this.VarTypeId)
            {
                case tsVarType.tsStatic:
                    if (bolIsInVue == true)
                    {
                        strVariable4InitValue = string.Format("{0}.value; //静态变量",
                          this.Variable4InitValue
                         .Replace("Static", "") + "Static");
                    }
                    else
                    {
                        strVariable4InitValue = string.Format("{0}.{1}; //静态变量",
                            strClsName, this.Variable4InitValue
                            .Replace("Static", "") + "Static");
                    }
                    break;
                case tsVarType.tsSession:
                    if (bolIsInVue == true)
                    {
                        strVariable4InitValue = string.Format("{0}.value; //静态变量",
                          this.Variable4InitValue);
                    }
                    else
                    {
                        strVariable4InitValue = string.Format("{0}.{1}; //静态变量",
                            strClsName, this.Variable4InitValue);
                    }
                    break;
                case tsVarType.tsCache:
                    if (bolIsInVue == true)
                    {
                        if (this.Variable4InitValue == null)
                        {
                            string strMsg = $"在类:{strClsName}中，变量:{this.VarName}(类型:tsVarType.tsCache)没有初始化变量，请检查！ ";
                            throw new Exception(strMsg);
                        }
                        strVariable4InitValue = string.Format("{0}.value; //缓存分类变量",
                      this.Variable4InitValue
                     .Replace("Cache", "") + "Cache");
                    }
                    else
                    {
                        strVariable4InitValue = string.Format("{0}.{1}; //缓存分类变量",
                        strClsName, this.Variable4InitValue
                        .Replace("Cache", "") + "Cache");
                    }
                    break;
                case tsVarType.tsDefaultValue:

                    strVariable4InitValue = string.Format("{0}; //默认值、缺省值", this.Variable4InitValue.Replace("_", "").Replace("BoolTrue", "true"));
                    break;
                default:
                    break;
            }

            StringBuilder sbBuilder = new StringBuilder();
            switch (this.ProgLangTypeId)
            {
                case enumProgLangType.JavaScript_04:// "JavaScript":
                    sbBuilder.AppendFormat("var {0}", strPrivVarName.Replace("_Cache", ""));
                    if (string.IsNullOrEmpty(this.Variable4InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};//{1}", strVariable4InitValue, this.GetTsTypeStr());
                        return sbBuilder.ToString();
                    }
                    else if (string.IsNullOrEmpty(this.InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};//{1}", this.InitValue, this.GetTsTypeStr());
                        return sbBuilder.ToString();
                    }
                    sbBuilder.Append(";");
                    return sbBuilder.ToString();
                case enumProgLangType.TypeScript_09:// "TypeScript":
                    sbBuilder.AppendFormat("const {0}", strPrivVarName.Replace("_Cache", ""));
                    if (string.IsNullOrEmpty(this.Variable4InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};//{1}", strVariable4InitValue, this.GetTsTypeStr());
                        return sbBuilder.ToString();
                    }
                    else if (string.IsNullOrEmpty(this.InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};//{1}", this.InitValue, this.GetTsTypeStr());
                        return sbBuilder.ToString();
                    }
                    sbBuilder.Append(";");
                    return sbBuilder.ToString();

                case enumProgLangType.CSharp_01:// "CSharp":
                    sbBuilder.AppendFormat("var {0}", strPrivVarName.Replace("_Cache", ""));
                    if (string.IsNullOrEmpty(this.Variable4InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};//{1}", this.Variable4InitValue, this.GetTsTypeStr());
                        return sbBuilder.ToString();
                    }
                    else if (string.IsNullOrEmpty(this.InitValue) == false)
                    {
                        sbBuilder.AppendFormat(" = {0};//{1}", this.InitValue, this.GetTsTypeStr());
                        return sbBuilder.ToString();
                    }
                    sbBuilder.Append(";");
                    return sbBuilder.ToString();

                //                    break;
                default:
                    var objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(this.ProgLangTypeId);
                    string strMsg = string.Format("在定义变量过程中，语言:{0}没有处理！", objProgLangType.ProgLangTypeName);
                    throw new Exception(strMsg);
            }
        }
    }
    public class FuncParaLst
    {
        public bool IsFstLcase = false;
        public string ParaLstName = "";
        public enumAppLevel appLevel = enumAppLevel.DefindFunc;
        private List<FuncParaType> lstFuncParaType;
        public FuncParaLst(string strParaLstName, bool bolIsFstLcase, enumAppLevel objAppLevel)
        {
            lstFuncParaType = new List<FuncParaType>();
            this.ParaLstName = strParaLstName;
            this.appLevel = objAppLevel;
            this.IsFstLcase = bolIsFstLcase;
        }
        public List<FuncParaType> GetLst
        {
            get { return lstFuncParaType; }
        }
        //public bool AddParaByVar(clsVariable objVar)
        //{
        //    if (lst == null) lst = new List<FuncParaType>();
        //    var objFuncParaType = new FuncParaType();
        //    lst.Add(objFuncParaType);
        //    return true;
        //}
        public bool AddParaByVar(string strVarId, string strProgLangTypeId, tsVarFunction strVarFunction)
        {
            if (string.IsNullOrEmpty(strVarId) == true || strVarId == "0") return false;

            if (lstFuncParaType == null) lstFuncParaType = new List<FuncParaType>();

            var objVar = clsGCVariableBL.GetObjByVarIdCache(strVarId);
            var objFuncParaType = new FuncParaType();
            objFuncParaType.IsFstLcase = this.IsFstLcase;
            objFuncParaType.VarTypeId = tsVarType.tsOther;// objVar.VarTypeId;
            objFuncParaType.VarFunction = strVarFunction;
            objFuncParaType.VarName = objVar.GetVarName4ViewInP();
            objFuncParaType.FldName = objVar.VarName;
            objFuncParaType.ProgLangTypeId = strProgLangTypeId;
            objFuncParaType.DataTypeAbbr = objVar.ObjDataTypeAbbr_PC().DataTypeAbbr;

            switch (objVar.VarTypeId)
            {
                case enumGCVariableType.localStorage_0003:
                case enumGCVariableType.sessionStorage_0004:
                    objFuncParaType.VarTypeId = tsVarType.tsSession;
                    objFuncParaType.FilePath = objVar.FilePath;
                    objFuncParaType.ClsName = objVar.ClsName;
                    objFuncParaType.Variable4InitValue = objVar.GetVarName4ViewInP();
                    break;
                case enumGCVariableType.CacheClassifyField_0007:
                    objFuncParaType.VarName = objVar.GetVarName4ViewInP()
                     .Replace("Cache", "") + "Cache";
                    objFuncParaType.VarTypeId = tsVarType.tsCache;
                    objFuncParaType.Variable4InitValue = objVar.GetVarName4ViewInP();
                    break;
                case enumGCVariableType.StaticValuable_0006:
                    objFuncParaType.VarName = objVar.GetVarName4ViewInP()
                        .Replace("Static", "") + "Static";
                    objFuncParaType.VarTypeId = tsVarType.tsStatic;
                    objFuncParaType.Variable4InitValue = objVar.GetVarName4ViewInP();
                    break;
                case enumGCVariableType.DefaultValue_0002:
                    objFuncParaType.VarTypeId = tsVarType.tsDefaultValue;
                    objFuncParaType.Variable4InitValue = "";// objVar.GetVarName4ViewInP();
                    objFuncParaType.InitValue = objVar.InitValue;
                    break;
                case enumGCVariableType.GivingValue_0001:
                    objFuncParaType.VarTypeId = tsVarType.tsGivingValue;
                    objFuncParaType.Variable4InitValue = "";// objVar.GetVarName4ViewInP();
                    objFuncParaType.InitValue = objVar.InitValue;
                    break;
                default:
                    var objVarType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objVar.VarTypeId);
                    string strMsg = string.Format("变量类型:{0}在Switch中没有被处理。(in {1})", objVarType.VarTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }

            //sbCondFldLst.AppendFormat(", {0}", objVar.VarName);
            if (objVar.IsBoolType_PC())
            {
                objFuncParaType.TypeScriptType = "boolean";
                objFuncParaType.InitValue = "false";
            }
            else if (objVar.IsNumberType_PC())
            {
                objFuncParaType.TypeScriptType = "number";
                objFuncParaType.InitValue = "0";
            }
            else
            {
                objFuncParaType.TypeScriptType = "string";
                objFuncParaType.InitValue = "\"\"";
            }
            objFuncParaType.DefaultValue = objVar.InitValue;
            return AddFuncParaType(objFuncParaType);
        }

        public string GetVarLstDefStr(string strClsName, IImportClass objImportClass, string strBaseUrl, bool bolIsInVue = false)
        {
            if (this.lstFuncParaType == null) return "";
            StringBuilder sbBuilder = new StringBuilder();

            foreach (var objVariable in this.lstFuncParaType)
            {
                var strTempCode = objVariable.DefVariable(strClsName, bolIsInVue);

                sbBuilder.AppendLine(strTempCode);
                if (string.IsNullOrEmpty(objVariable.ClsName) == false)
                {
                    objImportClass.AddImportClass("", objVariable.FilePath, objVariable.ClsName, enumImportObjType.CustomFunc, strBaseUrl);
                }
            }
            return sbBuilder.ToString();
        }


        //public bool AddPara4CacheClassifyByTabId(CacheClassify objCacheClassify_TS)
        //{
        //    if (string.IsNullOrEmpty(strTabId) == true) return false;

        //    if (lst == null) lst = new List<FuncParaType>();


        //    var objVar = clsGCVariableBL.GetObjByVarIdCache(strTabId);
        //    var objFuncParaType = new FuncParaType();
        //    objFuncParaType.VarTypeId = tsVarType.tsOther;// objVar.VarTypeId;
        //    objFuncParaType.VarName = objVar.VarExpression;
        //    objFuncParaType.FldName = objVar.VarName;
        //    //sbCondFldLst.AppendFormat(", {0}", objVar.VarName);
        //    if (objVar.IsBoolType_PC())
        //    {
        //        objFuncParaType.TypeScriptType = "boolean";
        //    }
        //    else if (objVar.IsNumberType_PC())
        //    {
        //        objFuncParaType.TypeScriptType = "number";
        //    }
        //    else
        //    {
        //        objFuncParaType.TypeScriptType = "string";
        //    }
        //    objFuncParaType.DefaultValue = objVar.InitValue;
        //    return AddFuncParaType(objFuncParaType);
        //}


        public string GetCondFldLst4Para()
        {
            if (this.lstFuncParaType == null) return "";
            this.lstFuncParaType.ForEach(x => { x.GetFuncParaText(); });
            List<string> strFuncParaText = lstFuncParaType.Select(x => x.CodeText).ToList();
            string strCodeText = string.Join(",", strFuncParaText);
            return strCodeText;
        }

        public string GetCondFldLst4Para4CSharp()
        {
            if (this.lstFuncParaType == null) return "";
            this.lstFuncParaType.ForEach(x => { x.GetFuncParaText4CSharp(); });
            List<string> strFuncParaText = lstFuncParaType.Select(x => x.CodeText).ToList();
            string strCodeText = string.Join(",", strFuncParaText);
            return strCodeText;
        }

        public string GetCondFldLst()
        {
            if (this.lstFuncParaType == null) return "";
            //this.lst.ForEach(x => { x.GetFuncParaText(); });
            List<string> strParaText = lstFuncParaType.Select(x => x.DataTypeAbbr + x.PrivVarName).ToList();
            string strCodeText = string.Join(",", strParaText);
            strCodeText = strCodeText.Replace("strstr", "str");
            return strCodeText;
        }
        public string GetCondFldLst4ViewCache(string strClassName)
        {
            if (this.lstFuncParaType == null) return "";
            //this.lst.ForEach(x => { x.GetFuncParaText(); });
            List<string> strParaText = lstFuncParaType.Select(x => $"{strClassName}.{x.FldName}Cache").ToList();
            string strCodeText = string.Join(",", strParaText);
            return strCodeText;
        }
        //CacheClassify

        public bool AddParaByTabFeature(clsTabFeatureEN objTabFeature_BindDdl, List<clsTabFeatureFldsENEx> arrFieldLst_Cond, string strProgLangTypeId)
        {
            if (objTabFeature_BindDdl == null) return false;

            if (this.appLevel == enumAppLevel.DefindFunc)
            {
                if (objTabFeature_BindDdl.IsNeedGC == false) return false;
                if (objTabFeature_BindDdl.IsExtendedClass == true) return false;

                if (objTabFeature_BindDdl.arrTabFeatureFldsSet_PC().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false) return false;
                if (objTabFeature_BindDdl.arrTabFeatureFldsSet_PC().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false) return false;
            }
            if (lstFuncParaType == null) lstFuncParaType = new List<FuncParaType>();

            //List<clsTabFeatureFldsEN> arrField_Condition = objTabFeature_BindDdl.arrTabFeatureFldsSet_PC().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
            foreach (var objInFor in arrFieldLst_Cond)
            {
                if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;

                var objFuncParaType = new FuncParaType();
                //objFuncParaType.VarTypeId = objVar.VarTypeId;
                objFuncParaType.IsFstLcase = this.IsFstLcase;
                objFuncParaType.VarName = objInFor.ObjFieldTab_PC().PrivFuncName();
                objFuncParaType.FldName = objInFor.ObjFieldTab_PC().FldName;
                objFuncParaType.IsForExtendClass = objInFor.IsForExtendClass;

                objFuncParaType.DataTypeId = objInFor.ObjFieldTab_PC().DataTypeId;
                objFuncParaType.FldLen = objInFor.ObjFieldTab_PC().FldLength;
                objFuncParaType.TypeScriptType = objInFor.ObjFieldTab_PC().ObjDataTypeAbbr_PC().TypeScriptType;
                objFuncParaType.CsType = objInFor.ObjFieldTab_PC().ObjDataTypeAbbr_PC().CsType;
                objFuncParaType.VarTypeId = tsVarType.tsCondition;
                objFuncParaType.VarFunction = tsVarFunction.tsCondition;
                objFuncParaType.ProgLangTypeId = strProgLangTypeId;
                objFuncParaType.DataTypeAbbr = objInFor.ObjFieldTab_PC().ObjDataTypeAbbr_PC().DataTypeAbbr;

                //objFuncParaType.DefaultValue = objVar.InitValue;
                AddFuncParaType(objFuncParaType);
            }
            return true;
        }
        private bool AddFuncParaType(FuncParaType objFuncParaType)
        {
            try
            {
                if (string.IsNullOrEmpty(objFuncParaType.FldName) == true)
                {
                    string strMsg = string.Format("变量名:{0}的字段名称为空！请检查", objFuncParaType.VarName);
                    throw new Exception(strMsg);
                }
                //var oldPubVarType = lst.Find(x => x.VarName == objFuncParaType.VarName);
                var oldPubVarType = lstFuncParaType.Find(x => x.FldName == objFuncParaType.FldName);
                if (oldPubVarType == null)
                {
                    lstFuncParaType.Add(objFuncParaType);
                    return true;
                }
                if (objFuncParaType.VarTypeId == tsVarType.tsCache)
                {
                    oldPubVarType.VarTypeId = tsVarType.tsCache;
                }
                if (oldPubVarType.TypeScriptType != objFuncParaType.TypeScriptType)
                {
                    var strMsg = string.Format("变量名：{0}的原变量名是:{1}，新变量的名称是:{2}，前后不一致！",
                        oldPubVarType.VarName, oldPubVarType.TypeScriptType, oldPubVarType.TypeScriptType);
                    throw new Exception(strMsg);
                }
                //if (objFuncParaType.IsCache == true) { oldPubVarType.IsCache = true; }
                //else if (objFuncParaType.IsStatic == true) { oldPubVarType.IsStatic = true; }

                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objCacheClassify_TS"></param>
        /// <param name="arrCondFldId"></param>
        /// <param name="strProgLangTypeId"></param>
        /// <param name="bolIsFrontend">是否前端</param>
        /// <returns></returns>
        public bool AddParaByCacheClassify(CacheClassify objCacheClassify_TS, List<string> arrCondFldId, string strProgLangTypeId)
        {
            if (objCacheClassify_TS == null) { return false; }
            if (objCacheClassify_TS.IsHasCacheClassfyFld == true && arrCondFldId.Contains(objCacheClassify_TS.FldId) == false)
            {
                if (lstFuncParaType == null) lstFuncParaType = new List<FuncParaType>();

                var objFuncParaType = new FuncParaType();
                objFuncParaType.IsFstLcase = this.IsFstLcase;
                objFuncParaType.VarName = objCacheClassify_TS.PriVarName;
                objFuncParaType.DataTypeId = objCacheClassify_TS.DataTypeId;
                objFuncParaType.FldLen = objCacheClassify_TS.FldLength;
                objFuncParaType.TypeScriptType = objCacheClassify_TS.TypeScriptType;
                objFuncParaType.CsType = objCacheClassify_TS.CsType;

                objFuncParaType.VarTypeId = tsVarType.tsCache;
                objFuncParaType.VarFunction = tsVarFunction.tsCache;
                objFuncParaType.FldName = objCacheClassify_TS.FldName;
                objFuncParaType.ProgLangTypeId = strProgLangTypeId;
                var objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objCacheClassify_TS.DataTypeId);
                objFuncParaType.DataTypeAbbr = objDataTypeAbbr.DataTypeAbbr;
                string strCondition = string.Format("{0}='{1}'", conGCVariable.VarName, objFuncParaType.FldName);
                var arrGCVariableCache = clsGCVariableBL.GetObjLstCache();
                var arrGCVariable = arrGCVariableCache.Where(x => x.VarName == objFuncParaType.FldName).ToList();

                SetVarProp(objFuncParaType, arrGCVariable);
                //objFuncParaType.DefaultValue = objVar.InitValue;
                AddFuncParaType(objFuncParaType);
            }

            if (objCacheClassify_TS.IsHasCacheClassfyFld2 == true && arrCondFldId.Contains(objCacheClassify_TS.FldId2) == false)
            {
                if (lstFuncParaType == null) lstFuncParaType = new List<FuncParaType>();
                var objFuncParaType = new FuncParaType();
                objFuncParaType.IsFstLcase = this.IsFstLcase;
                objFuncParaType.VarName = objCacheClassify_TS.PriVarName2;
                objFuncParaType.FldName = objCacheClassify_TS.FldName2;
                objFuncParaType.DataTypeId = objCacheClassify_TS.DataTypeId2;
                objFuncParaType.FldLen = objCacheClassify_TS.FldLength2;
                objFuncParaType.TypeScriptType = objCacheClassify_TS.TypeScriptType2;
                objFuncParaType.CsType = objCacheClassify_TS.CsType;

                objFuncParaType.VarTypeId = tsVarType.tsCache;
                objFuncParaType.ProgLangTypeId = strProgLangTypeId;
                var objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objCacheClassify_TS.DataTypeId2);
                objFuncParaType.DataTypeAbbr = objDataTypeAbbr.DataTypeAbbr;

                string strCondition = string.Format("{0}='{1}'", conGCVariable.VarName, objFuncParaType.FldName);
                //var arrGCVariable = clsGCVariableBL.GetObjLst1(strCondition);
                var arrGCVariableCache = clsGCVariableBL.GetObjLstCache();
                var arrGCVariable = arrGCVariableCache.Where(x => x.VarName == objFuncParaType.FldName).ToList();

                SetVarProp(objFuncParaType, arrGCVariable);
                //objFuncParaType.DefaultValue = objVar.InitValue;
                AddFuncParaType(objFuncParaType);
            }

            return true;
        }


        public bool AddParaByCacheClassify4View(CacheClassify objCacheClassify_TS, List<string> arrCondFldId, string strProgLangTypeId, string strViewId, string strPrjId)
        {
            if (objCacheClassify_TS == null) { return false; }
            if (objCacheClassify_TS.IsHasCacheClassfyFld == true && arrCondFldId.Contains(objCacheClassify_TS.FldId) == false)
            {
                if (lstFuncParaType == null) lstFuncParaType = new List<FuncParaType>();

                var objFuncParaType = new FuncParaType();
                objFuncParaType.IsFstLcase = this.IsFstLcase;
                objFuncParaType.VarName = objCacheClassify_TS.PriVarName;
                objFuncParaType.DataTypeId = objCacheClassify_TS.DataTypeId;
                objFuncParaType.FldLen = objCacheClassify_TS.FldLength;
                objFuncParaType.TypeScriptType = objCacheClassify_TS.TypeScriptType;
                objFuncParaType.CsType = objCacheClassify_TS.CsType;

                objFuncParaType.VarTypeId = tsVarType.tsCache;
                objFuncParaType.VarFunction = tsVarFunction.tsCache;
                objFuncParaType.FldName = objCacheClassify_TS.FldName;
                objFuncParaType.ProgLangTypeId = strProgLangTypeId;
                var objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objCacheClassify_TS.DataTypeId);
                objFuncParaType.DataTypeAbbr = objDataTypeAbbr.DataTypeAbbr;
                string strCondition = string.Format("{0}='{1}'", conGCVariable.VarName, objFuncParaType.FldName);
                var arrGCVariableCache = clsGCVariableBL.GetObjLstCache();
                var arrGCVariable = arrGCVariableCache.Where(x => x.VarName == objFuncParaType.FldName).ToList();

                SetVarProp4View(objFuncParaType, arrGCVariable, strViewId, strPrjId);
                //objFuncParaType.DefaultValue = objVar.InitValue;
                AddFuncParaType(objFuncParaType);
            }

            if (objCacheClassify_TS.IsHasCacheClassfyFld2 == true && arrCondFldId.Contains(objCacheClassify_TS.FldId2) == false)
            {
                if (lstFuncParaType == null) lstFuncParaType = new List<FuncParaType>();
                var objFuncParaType = new FuncParaType();
                objFuncParaType.IsFstLcase = this.IsFstLcase;
                objFuncParaType.VarName = objCacheClassify_TS.PriVarName2;
                objFuncParaType.FldName = objCacheClassify_TS.FldName2;
                objFuncParaType.DataTypeId = objCacheClassify_TS.DataTypeId2;
                objFuncParaType.FldLen = objCacheClassify_TS.FldLength2;
                objFuncParaType.TypeScriptType = objCacheClassify_TS.TypeScriptType2;
                objFuncParaType.VarTypeId = tsVarType.tsCache;
                objFuncParaType.ProgLangTypeId = strProgLangTypeId;
                var objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objCacheClassify_TS.DataTypeId2);
                objFuncParaType.DataTypeAbbr = objDataTypeAbbr.DataTypeAbbr;

                string strCondition = string.Format("{0}='{1}'", conGCVariable.VarName, objFuncParaType.FldName);
                //var arrGCVariable = clsGCVariableBL.GetObjLst1(strCondition);
                var arrGCVariableCache = clsGCVariableBL.GetObjLstCache();
                var arrGCVariable = arrGCVariableCache.Where(x => x.VarName == objFuncParaType.FldName).ToList();

                SetVarProp4View(objFuncParaType, arrGCVariable, strViewId, strPrjId);
                //objFuncParaType.DefaultValue = objVar.InitValue;
                AddFuncParaType(objFuncParaType);
            }

            return true;
        }

        public string Gc_CheckVarEmpty_Cs(string strClassName, string strFuncName, bool bolIsCheckLength)
        {
            if (this.lstFuncParaType == null) return "";
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.lstFuncParaType)
            {
                string strCodeText = item.Gc_CheckVarEmpty_Cs(strClassName, strFuncName, bolIsCheckLength);
                sb.Append("\r\n" + strCodeText);
            }

            return sb.ToString();

        }

        public string Gc_FuncParaDef(string strProgLangTypeId)
        {
            if (this.lstFuncParaType == null || this.lstFuncParaType.Count == 0) return "";

            StringBuilder strCodeForCs = new StringBuilder();
            foreach (var item in this.lstFuncParaType)
            {
                string strCodeText = "";
                switch (strProgLangTypeId)
                {
                    case enumProgLangType.CSharp_01:// "CSharp":
                        strCodeText = item.GetFuncParaText4CSharp();
                        strCodeForCs.Append(strCodeText + ",");
                        break;
                    case enumProgLangType.TypeScript_09:// "TypeScript":
                        strCodeText = item.GetFuncParaText4TypeScript();
                        strCodeForCs.Append(strCodeText + ",");
                        break;
                    default:
                        var objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
                        string strMsg = string.Format("在定义函数参数过程中，语言:{0}没有处理！", objProgLangType.ProgLangTypeName);
                        throw new Exception(strMsg);
                }
            }
            strCodeForCs = strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            return strCodeForCs.ToString();
        }


        public string Gc_CheckVarEmpty_Ts(string strClassName, string strFuncName, bool bolIsCheckLength, IImportClass objImportClass, string strBaseUrl)
        {
            if (this.lstFuncParaType == null) return "";
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.lstFuncParaType)
            {
                string strCodeText = item.Gc_CheckVarEmpty_Ts(strClassName, strFuncName, bolIsCheckLength, objImportClass, strBaseUrl);
                sb.Append("\r\n" + strCodeText);
            }

            return sb.ToString();

        }
        public string GetFuncRemark()
        {
            if (this.lstFuncParaType == null) return "";
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.lstFuncParaType)
            {
                //if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;
                sb.AppendFormat("\r\n * @param {0}:{1}", item.VarName, item.Caption);
            }
            return sb.ToString();
        }
        public string GetFuncRemark4CSharp()
        {
            if (this.lstFuncParaType == null) return "";
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.lstFuncParaType)
            {
                //if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;
                //sb.AppendFormat("\r\n * @param {0}:{1}", item.VarName, item.Caption);
                sb.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", item.VarName, item.Caption);

            }
            return sb.ToString();
        }

        public string GeneFilterCondition(bool bolIsForExtendedClassFld = false)
        {
            if (this.lstFuncParaType.Count == 0) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append("");
            bool bolIsFirst = true;
            foreach (var objInFor in this.lstFuncParaType)
            {
                string strPropertyName = objInFor.VarName;
                string strFldName = objInFor.FldName;

                if (objInFor.VarTypeId == tsVarType.tsCache) continue;
                if (objInFor.VarFunction != tsVarFunction.tsCondition) continue;
                if (objInFor.IsForExtendClass == true) continue;

                string strValue = "";
                if (objInFor.ValueGivingModeId == enumTsValueGivingMode.DefaultValue_01)
                {
                    switch (objInFor.TypeScriptType)
                    {
                        case "boolean":
                            strValue = string.Format("{0}", objInFor.VarName);
                            //if (objInFor.DefaultValue == "1")
                            //{
                            //    strValue = "true";
                            //}
                            //else if (objInFor.DefaultValue == "0")
                            //{
                            //    strValue = "false";
                            //}
                            //else
                            //{
                            //    bool bolValue = bool.Parse(objInFor.DefaultValue);
                            //    strValue = bolValue ? "true" : "false";
                            //}
                            break;
                        case "string":
                            strValue = string.Format("{0}", objInFor.VarName);
                            break;
                        case "number":
                            strValue = string.Format("{0}", objInFor.VarName);
                            break;
                        default:
                            strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
                            break;
                    }
                }
                else
                {
                    strValue = string.Format("{0}", objInFor.VarName);
                }
                if (bolIsFirst)
                {
                    sbCondition.AppendFormat("x=>x.{0} == {1}",
                         objInFor.PropertyName,
                         strValue);
                    bolIsFirst = false;
                }
                else
                {
                    sbCondition.AppendFormat("&& x.{0} == {1}",
                         objInFor.PropertyName,
                         strValue);
                }
            }
            if (sbCondition.Length > 0)
            {
                var strIsForExtendedClassFld = bolIsForExtendedClassFld ? "Ex" : "";
                strCodeForCs.Append("\r\n" + $"arrObj{strIsForExtendedClassFld}LstSel = arrObj{strIsForExtendedClassFld}LstSel.filter({sbCondition.ToString()});");
            }
            return strCodeForCs.ToString();


        }

        public string GeneConditionStr()
        {
            if (this.lstFuncParaType.Count == 0) return "const strCondition = `1=1`;";

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append("");
            bool bolIsFirst = true;
            foreach (var objInFor in this.lstFuncParaType)
            {
                string strPropertyName = objInFor.VarName;
                string strFldName = objInFor.FldName;

                if (objInFor.VarTypeId == tsVarType.tsCache) continue;
                if (objInFor.VarFunction != tsVarFunction.tsCondition) continue;
                if (objInFor.IsForExtendClass == true) continue;

                string strValue = "";
                if (objInFor.ValueGivingModeId == enumTsValueGivingMode.DefaultValue_01)
                {
                    switch (objInFor.TypeScriptType)
                    {
                        case "boolean":
                            strValue = string.Format("{0}", objInFor.VarName);
                            //if (objInFor.DefaultValue == "1")
                            //{
                            //    strValue = "true";
                            //}
                            //else if (objInFor.DefaultValue == "0")
                            //{
                            //    strValue = "false";
                            //}
                            //else
                            //{
                            //    bool bolValue = bool.Parse(objInFor.DefaultValue);
                            //    strValue = bolValue ? "true" : "false";
                            //}
                            break;
                        case "string":
                            strValue = string.Format("{0}", objInFor.VarName);
                            break;
                        case "number":
                            strValue = string.Format("{0}", objInFor.VarName);
                            break;
                        default:
                            strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
                            break;
                    }
                }
                else
                {
                    strValue = string.Format("{0}", objInFor.VarName);
                }
                //const strCondition = `progLangTypeId = '${strProgLangTypeId}'`;

                if (bolIsFirst)
                {
                    sbCondition.AppendFormat("const strCondition = `{0} = '${{ {1} }}'",
                         objInFor.PropertyName,
                         strValue);
                    bolIsFirst = false;
                }
                else
                {
                    sbCondition.AppendFormat("&& {0} = '${{ {1} }}'",
                         objInFor.PropertyName,
                         strValue);
                }
            }
            if (sbCondition.Length == 0) return "const strCondition = `1=1`;";
            sbCondition.Append("`;");
            return sbCondition.ToString();


        }


        public string GeneFilterCondition4CSharp(bool bolIsUseCache = true)
        {
            if (this.lstFuncParaType.Count == 0) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append("");
            bool bolIsFirst = true;
            foreach (var objInFor in this.lstFuncParaType)
            {

                string strPropertyName = objInFor.VarName;
                string strFldName = objInFor.FldName;

                if (objInFor.VarTypeId == tsVarType.tsCache) continue;
                if (objInFor.IsForExtendClass == true) continue;

                if (bolIsUseCache == true && objInFor.VarFunction != tsVarFunction.tsCondition) continue;

                string strValue = "";
                if (objInFor.ValueGivingModeId == enumTsValueGivingMode.DefaultValue_01)
                {
                    switch (objInFor.CsType)
                    {
                        case "bool":
                            if (objInFor.DefaultValue == "1")
                            {
                                strValue = "true";
                            }
                            else if (objInFor.DefaultValue == "0")
                            {
                                strValue = "false";
                            }
                            else if (objInFor.DefaultValue == null)
                            {
                                strValue = "false";
                            }
                            else
                            {
                                bool bolValue = bool.Parse(objInFor.DefaultValue);
                                strValue = bolValue ? "true" : "false";
                            }
                            break;
                        case "string":
                            strValue = string.Format("{0}", objInFor.VarName);
                            break;
                        case "int":
                        case "bigint":
                            strValue = string.Format("{0}", objInFor.VarName);
                            break;
                        default:
                            strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
                            break;
                    }
                }
                else
                {
                    strValue = string.Format("{0}", objInFor.VarName);
                }
                if (bolIsFirst)
                {
                    sbCondition.AppendFormat("x=>x.{0} == {1}",
                         objInFor.FldName,
                         strValue);
                    bolIsFirst = false;
                }
                else
                {
                    sbCondition.AppendFormat("&& x.{0} == {1}",
                         objInFor.FldName,
                         strValue);
                }
            }
            if (sbCondition.Length > 0)
            {
                strCodeForCs.AppendFormat("\r\n" + "var arrObjLstSel = arrObjLst.Where({0}).ToList();",
                     sbCondition.ToString());
            }
            return strCodeForCs.ToString();


        }
        public void SetVarProp(FuncParaType objFuncParaType, clsGCVariableEN objVar)
        {

            switch (objVar.VarTypeId)
            {
                case enumGCVariableType.localStorage_0003:
                case enumGCVariableType.sessionStorage_0004:
                    objFuncParaType.VarTypeId = tsVarType.tsSession;
                    objFuncParaType.FilePath = objVar.FilePath;
                    objFuncParaType.ClsName = objVar.ClsName;
                    objFuncParaType.Variable4InitValue = objVar.GetVarName4ViewInP();
                    break;
                case enumGCVariableType.CacheClassifyField_0007:
                    objFuncParaType.VarTypeId = tsVarType.tsCache;
                    objFuncParaType.Variable4InitValue = objVar.GetVarName4ViewInP();
                    break;
                case enumGCVariableType.StaticValuable_0006:
                    objFuncParaType.VarTypeId = tsVarType.tsStatic;
                    objFuncParaType.Variable4InitValue = objVar.GetVarName4ViewInP();
                    break;
                default:
                    var objVarType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objVar.VarTypeId);
                    string strMsg = string.Format("变量类型:{0}在Switch中没有被处理。(in {1})", objVarType.VarTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }

            //sbCondFldLst.AppendFormat(", {0}", objVar.VarName);
            if (objVar.IsBoolType_PC())
            {
                objFuncParaType.TypeScriptType = "boolean";
                objFuncParaType.InitValue = "false";
            }
            else if (objVar.IsNumberType_PC())
            {
                objFuncParaType.TypeScriptType = "number";
                objFuncParaType.InitValue = "0";
            }
            else
            {
                objFuncParaType.TypeScriptType = "string";
                objFuncParaType.InitValue = "\"\"";
            }
            objFuncParaType.DefaultValue = objVar.InitValue;
        }

        public void SetVarProp4View(FuncParaType objFuncParaType, clsGCVariableEN objVar, string strViewId, string strPrjId)
        {

            switch (objVar.VarTypeId)
            {
                case enumGCVariableType.localStorage_0003:
                case enumGCVariableType.sessionStorage_0004:
                    objFuncParaType.VarTypeId = tsVarType.tsSession;
                    objFuncParaType.FilePath = objVar.FilePath;
                    objFuncParaType.ClsName = objVar.ClsName;
                    objFuncParaType.Variable4InitValue = clsViewIdGCVariableRelaBLEx.GetViewVarName(strViewId, objVar.VarId, strPrjId);
                    break;
                case enumGCVariableType.CacheClassifyField_0007:
                    objFuncParaType.VarTypeId = tsVarType.tsCache;
                    objFuncParaType.Variable4InitValue = clsViewIdGCVariableRelaBLEx.GetViewVarName(strViewId, objVar.VarId, strPrjId);
                    break;
                case enumGCVariableType.StaticValuable_0006:
                    objFuncParaType.VarTypeId = tsVarType.tsStatic;
                    objFuncParaType.Variable4InitValue = clsViewIdGCVariableRelaBLEx.GetViewVarName(strViewId, objVar.VarId, strPrjId);
                    break;
                default:
                    var objVarType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(objVar.VarTypeId);
                    string strMsg = string.Format("变量类型:{0}在Switch中没有被处理。(in {1})", objVarType.VarTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }

            //sbCondFldLst.AppendFormat(", {0}", objVar.VarName);
            if (objVar.IsBoolType_PC())
            {
                objFuncParaType.TypeScriptType = "boolean";
                objFuncParaType.InitValue = "false";
            }
            else if (objVar.IsNumberType_PC())
            {
                objFuncParaType.TypeScriptType = "number";
                objFuncParaType.InitValue = "0";
            }
            else
            {
                objFuncParaType.TypeScriptType = "string";
                objFuncParaType.InitValue = "\"\"";
            }
            objFuncParaType.DefaultValue = objVar.InitValue;
        }


        public void SetVarProp(FuncParaType objFuncParaType, List<clsGCVariableEN> arrGCVariable)
        {
            if (arrGCVariable == null || arrGCVariable.Count == 0) return;
            List<string> validIds = new List<string> { enumGCVariableType.localStorage_0003, enumGCVariableType.sessionStorage_0004 };
            var objVar = arrGCVariable.Find(x => validIds.Contains(x.VarTypeId));
            if (objVar != null)
            {
                SetVarProp(objFuncParaType, objVar);
                return;
            }
            validIds = new List<string> { enumGCVariableType.CacheClassifyField_0007, enumGCVariableType.StaticValuable_0006 };
            objVar = arrGCVariable.Find(x => validIds.Contains(x.VarTypeId));
            if (objVar != null)
            {
                SetVarProp(objFuncParaType, objVar);
                return;
            }
            SetVarProp(objFuncParaType, arrGCVariable[0]);
            return;
        }

        public void SetVarProp4View(FuncParaType objFuncParaType, List<clsGCVariableEN> arrGCVariable, string strViewId, string strPrjId)
        {
            if (arrGCVariable == null || arrGCVariable.Count == 0) return;
            List<string> validIds = new List<string> { enumGCVariableType.localStorage_0003, enumGCVariableType.sessionStorage_0004 };
            var objVar = arrGCVariable.Find(x => validIds.Contains(x.VarTypeId));
            if (objVar != null)
            {
                SetVarProp4View(objFuncParaType, objVar, strViewId, strPrjId);
                return;
            }
            validIds = new List<string> { enumGCVariableType.CacheClassifyField_0007, enumGCVariableType.StaticValuable_0006 };
            objVar = arrGCVariable.Find(x => validIds.Contains(x.VarTypeId));
            if (objVar != null)
            {
                SetVarProp4View(objFuncParaType, objVar, strViewId, strPrjId);
                return;
            }
            SetVarProp4View(objFuncParaType, arrGCVariable[0], strViewId, strPrjId);
            return;
        }


        public void SetVariableProp(string strVariableName, string strInitValue, string strVariable4InitValue)
        {
            var objVariable = this.lstFuncParaType.Find(x => x.VarName == strVariableName);
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

        //        public string Gen_4WA_TabFeature_DdlBindFunctionInDiv()
        //        {


        //            List<string> arrCondFldName = new List<string>();


        //            List<string> arrCacheFldName = new List<string>();

        //            StringBuilder strCodeForCs = new StringBuilder();
        //            StringBuilder sbCheckEmpty = new StringBuilder();
        //            string strFuncName = "";
        //            try
        //            {

        //                    //预检查



        //                    if (objCacheClassify_TS.IsHasCacheClassfyFld == true)
        //                    {


        //                        if (arrPrivFuncName_Additional.Contains(objCacheClassify_TS.PriVarName) == false)
        //                        {
        //                            arrPrivFuncName_Additional.Add(objCacheClassify_TS.PriVarName);
        //                            //strFuncName_Temp = string.Format("BindDdl{0}InDivCache", strValueFieldName);

        //                            sbFuncPara.AppendFormat(", {0}: {1}", objCacheClassify_TS.PriVarName,
        //                                objCacheClassify_TS.TypeScriptType);
        //                            sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(objCacheClassify_TS.PriVarName,
        //                                objCacheClassify_TS.TypeScriptType,
        //                    objCacheClassify_TS.DataTypeId,
        //                                this.ClsName, objTabFeature_BindDdl.FuncNameJs,
        //                                objCacheClassify_TS.FldLength,
        //                                objCacheClassify_TS.DataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));
        //                        }
        //                    }
        //                    if (objCacheClassify_TS.IsHasCacheClassfyFld2 == true)
        //                    {

        //                        if (arrPrivFuncName_Additional.Contains(objCacheClassify_TS.PriVarName2) == false)
        //                        {
        //                            arrPrivFuncName_Additional.Add(objCacheClassify_TS.PriVarName2);
        //                            //strFuncName_Temp = string.Format("BindDdl{0}InDivCache", strValueFieldName);

        //                            sbFuncPara.AppendFormat(", {0}: {1}", objCacheClassify_TS.PriVarName2,
        //                                objCacheClassify_TS.TypeScriptType2);
        //                            sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(objCacheClassify_TS.PriVarName2,
        //objCacheClassify_TS.TypeScriptType2,
        //objCacheClassify_TS.DataTypeId2,
        //this.ClsName, objTabFeature_BindDdl.FuncNameJs,
        //objCacheClassify_TS.FldLength2,
        //objCacheClassify_TS.DataTypeId2 == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));

        //                        }
        //                    }

        //                    var strLetOrConst = "const";
        //                    if (arrField_Condition.Count() > 0)
        //                    {
        //                        strLetOrConst = "let";
        //                    }
        //                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
        //                    {
        //                        strLetOrConst = "let";
        //                    }


        //                    strCodeForCs.Append("\r\n/**");
        //                    strCodeForCs.Append("\r\n * 绑定基于Web的下拉框,在某一层下的下拉框");
        //                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

        //                    strCodeForCs.Append("\r\n * @param objDDL:需要绑定当前表的下拉框");
        //                    foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
        //                    {
        //                        if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;
        //                        strCodeForCs.AppendFormat("\r\n * @param {0}:{1}", objInFor.ObjFieldTab().PrivFuncName1(), objInFor.ObjFieldTab().Caption);
        //                    }
        //                    strCodeForCs.Append("\r\n*/");

        //                    //strFuncName_Temp = string.Format("BindDdl{0}InDivCache", strValueFieldName);

        //                    strCodeForCs.AppendFormat("\r\n" + "export async function " + this.tabNameHead + "{0}Cache(strDivName: string, strDdlName: string {1})",
        //                        objTabFeature_BindDdl.FuncNameJs.Replace("_", ""), sbFuncPara.ToString());

        //                    Re_objFunction4Code.FuncName4Code = string.Format("export async function " + this.tabNameHead + "{0}Cache(strDivName: string, strDdlName: string {1})",
        //                        objTabFeature_BindDdl.FuncNameJs, sbFuncPara.ToString());

        //                    strCodeForCs.Append("\r\n" + "{");
        //                    //              strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"{0}Cache\";", objTabFeature_BindDdl.FuncNameJs,
        //                    //objKeyField.FldName);

        //                    strCodeForCs.AppendLine(sbCheckEmpty.ToString());


        //                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(strDdlName);",
        //    ThisTabName4GC, strValueFieldName, strTextFieldName);
        //                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
        //                    strCodeForCs.Append("\r\n" + "{");
        //                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"下拉框：{{0}} 不存在！(In {0})\", strDdlName);",
        //                        objTabFeature_BindDdl.FuncNameJs);
        //                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
        //                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
        //                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
        //                    strCodeForCs.Append("\r\n" + "}");

        //                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
        //                    strCodeForCs.AppendFormat("\r\n" + "//console.log(\"开始：{0}Cache\");", objTabFeature_BindDdl.FuncNameJs);
        //                    //strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\");",
        //                    //                  objPrjTabENEx.TabCnName);

        //                    //                strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", cls{0}EN.con{1}); ",
        //                    //ThisTabName4GC, strValueFieldName);
        //                    if (objCacheClassify_TS.IsHasCacheClassfyFld == false)
        //                    {
        //                        strCodeForCs.AppendFormat("\r\n" + "{1} arrObjLstSel = await {0}GetObjLstCache();",
        //                            ThisTabName4GC, strLetOrConst);
        //                    }
        //                    else if (objCacheClassify_TS.IsHasCacheClassfyFld2 == false)
        //                    {
        //                        string strPrivFuncName = objCacheClassify_TS.PriVarName;
        //                        arrCacheFldName.Add(objCacheClassify_TS.FldName);
        //                        strCodeForCs.AppendFormat("\r\n" + "{2} arrObjLstSel = await {0}GetObjLstCache({1});",
        //                            ThisTabName4GC,
        //                            strPrivFuncName,
        //                            strLetOrConst);

        //                    }
        //                    else
        //                    {
        //                        string strPrivFuncName = objCacheClassify_TS.PriVarName;
        //                        string strPrivFuncName2 = objCacheClassify_TS.PriVarName2;
        //                        arrCacheFldName.Add(objCacheClassify_TS.FldName);
        //                        arrCacheFldName.Add(objCacheClassify_TS.FldName2);

        //                        strCodeForCs.AppendFormat("\r\n" + "{3} arrObjLstSel = await {0}GetObjLstCache({1}, {2});",
        //                            ThisTabName4GC,
        //                            objCacheClassify_TS.PriVarName,
        //                            objCacheClassify_TS.PriVarName2,
        //                            strLetOrConst);

        //                    }
        //                    strCodeForCs.Append("\r\n" + "if (arrObjLstSel == null) return;");
        //                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
        //                    {
        //                        clsTabFeatureFldsEN objField_Sort = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
        //                        switch (objField_Sort.ObjFieldTab().TypeScriptType())
        //                        {
        //                            case "string":
        //                                strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0}.localeCompare(y.{0}));",
        //                                    objField_Sort.ObjFieldTab().PropertyName());
        //                                break;
        //                            case "number":
        //                            case "boolean":
        //                                strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.sort((x, y) => x.{0} - y.{0});",
        //                                    objField_Sort.ObjFieldTab().PropertyName());
        //                                break;
        //                        }
        //                    }
        //                    if (arrField_Condition.Count() > 0)
        //                    {
        //                        StringBuilder sbCondition = new StringBuilder();
        //                        sbCondition.Append("");
        //                        bool bolIsFirst = true;
        //                        foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
        //                        {
        //                            string strPropertyName = objInFor.ObjFieldTab().PropertyName();
        //                            string strFldName = objInFor.ObjFieldTab().FldName;

        //                            if (arrCacheFldName.Contains(strFldName)) continue;
        //                            string strValue = "";
        //                            if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01)
        //                            {
        //                                switch (objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType)
        //                                {
        //                                    case "bool":
        //                                        if (objInFor.DefaultValue == "1")
        //                                        {
        //                                            strValue = "true";
        //                                        }
        //                                        else if (objInFor.DefaultValue == "0")
        //                                        {
        //                                            strValue = "false";
        //                                        }
        //                                        else
        //                                        {
        //                                            bool bolValue = bool.Parse(objInFor.DefaultValue);
        //                                            strValue = bolValue ? "true" : "false";
        //                                        }
        //                                        break;
        //                                    case "string":
        //                                        strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
        //                                        break;
        //                                    case "int":
        //                                    case "bigint":
        //                                    case "short":
        //                                        strValue = string.Format("{0}", objInFor.DefaultValue);
        //                                        break;

        //                                    default:
        //                                        strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
        //                                        break;
        //                                }
        //                            }
        //                            else
        //                            {
        //                                strValue = string.Format("{0}", objInFor.ObjFieldTab().PrivFuncName1());
        //                            }
        //                            if (bolIsFirst)
        //                            {
        //                                sbCondition.AppendFormat("x=>x.{0} == {1}",
        //                                     objInFor.ObjFieldTab().PropertyName(),
        //                                     strValue);
        //                                bolIsFirst = false;
        //                            }
        //                            else
        //                            {
        //                                sbCondition.AppendFormat("&& x.{0} == {1}",
        //                                     objInFor.ObjFieldTab().PropertyName(),
        //                                     strValue);
        //                            }
        //                        }
        //                        if (sbCondition.Length > 0)
        //                        {
        //                            strCodeForCs.AppendFormat("\r\n" + "arrObjLstSel = arrObjLstSel.filter({1});",
        //                                ThisTabName4GC, sbCondition.ToString());
        //                        }
        //                    }
        //                    if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
        //                    {
        //                        strCodeForCs.AppendFormat("\r\n" + "BindDdlObjLstInDiv(strDivName, strDdlName, arrObjLstSel, cls{0}EN.con{1}, cls{0}EN.con{2}, \"{3}\");",
        //                                    ThisTabName4GC,
        //                                    strValueFieldName,
        //                                    strTextFieldName,
        //                                    objPrjTabENEx.TabCnName);
        //                        AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "BindDdlObjLstInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

        //                    }
        //                    else
        //                    {
        //                        strCodeForCs.AppendFormat("\r\n" + "BindDdlObjLstInDivV(strDivName, strDdlName, arrObjLstSel, cls{0}EN.con{1}, cls{0}EN.con{2}, \"{3}\");",
        //                                ThisTabName4GC,
        //                                strValueFieldName,
        //                                strTextFieldName,
        //                                objPrjTabENEx.TabCnName);
        //                        AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "BindDdlObjLstInDivV", enumImportObjType.CustomFunc, this.strBaseUrl);

        //                    }

        //                    strCodeForCs.Append("\r\n" + "}");


        //            }

        //            catch (Exception ex)
        //            {
        //                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

        //                clsEntityBase.LogErrorS(ex, strMsg);
        //                throw new Exception(strMsg);
        //            }
        //            return strCodeForCs.ToString();
        //        }
       

    }
}

