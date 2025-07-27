using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsFieldTabENEx : clsFieldTabEN
    {
        public clsDataTypeAbbrENEx objDataTypeAbbrEN = null;

        public clsFieldTabENEx(string strFldID)
            : base(strFldID)
        {
        }
        /// <summary>
        /// 私有属性变量名，前面加“m”
        /// </summary>
        public string PrivPropName
        {
            get
            {
                return "m" + this.objDataTypeAbbrEN.DataTypeAbbr + this.mstrFldName;
            }
        }
        public string PrivPropNameEx
        {
            get
            {
                return "m" + this.objDataTypeAbbrEN.DataTypeAbbr + this.mstrFldName.Replace("_", "");
            }
        }
        private string mstrMemoInTab;

        public string MemoInTab
        {
            get { return mstrMemoInTab; }
            set { mstrMemoInTab = value; }
        }
        /// <summary>
        /// 私有函数变量名，前面不加“m”
        /// </summary>
        public string PrivFuncName
        {
            get
            {
                return this.objDataTypeAbbrEN.DataTypeAbbr + this.mstrFldName;
            }
        }

      
        /// <summary>
        /// 关键字的TypeScript类型
        /// </summary>
        public string TypeScriptType
        {
            get
            {
                return this.objDataTypeAbbrEN.TypeScriptType;
            }
        }
        /// <summary>
        /// 关键字变量的定义串，例如: string strUserId
        /// </summary>
        public string KeyVarDefineStr
        {
            get
            {
                return this.objDataTypeAbbrEN.CsType + " " + this.PrivFuncName;
            }
        }
        public string KeyVarDefineStr_TS
        {
            get
            {
                return  string.Format( "{0}: {1}" , this.PrivFuncName, this.objDataTypeAbbrEN.TypeScriptType);
            }
        }
        public string NotNullStr
        {
            get
            {
                return string.Format("{0}不能为空！",  this.Caption);
            }
        }

        public clsFieldTabENEx()
            : base()
        {
            this.objDataTypeAbbrEN = new clsDataTypeAbbrENEx();
        }

        private clsPubConst.LangType mstrLangType = clsPubConst.LangType.NULL;

        public clsPubConst.LangType LangType
        {
            get {
                if (mstrLangType == clsPubConst.LangType.NULL)
                {
                    throw new Exception("LangType（语言类型）不能为空！");
                }
                return mstrLangType; 
            }
            set { mstrLangType = value; }
        }
        private string mstrCodeTabName;
        //private string mstrCodeTabName;
        private string mstrCodeTabCode;

        public string DefPrivateProperty()
        {
            StringBuilder sbCode = new StringBuilder();
            switch (LangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    sbCode.Append("\r\n /// <summary> ");
                    sbCode.AppendFormat("\r\n /// {0}(字段类型:{1},字段长度:{2},是否可空:{3})", Caption, objDataTypeAbbrEN.DataTypeName, FldLength, IsNull);
                    sbCode.Append("\r\n /// </summary>");
                    sbCode.Append("\r\n " + "protected " + this.objDataTypeAbbrEN.CsType + " " + PrivPropName + ";");
                    return sbCode.ToString();
                case clsPubConst.LangType.JAVA:// "Java":
                    return "protected " + this.objDataTypeAbbrEN.JavaType + " " + PrivPropName + ";" + "    //" + Caption + string.Format("(字段类型:{1},字段长度:{2},是否可空:{3})", Caption, objDataTypeAbbrEN.DataTypeName, FldLength, IsNull);
                case clsPubConst.LangType.VB:// "VB.NET":
                    return "protected " + this.objDataTypeAbbrEN.VbNetType + " " + PrivPropName + ";" + "    //" + Caption + string.Format("(字段类型:{1},字段长度:{2},是否可空:{3})", Caption, objDataTypeAbbrEN.DataTypeName, FldLength, IsNull);
                default:
                    return "protected " + this.objDataTypeAbbrEN.CsType + " " + PrivPropName + ";" + "    //" + Caption + string.Format("(字段类型:{1},字段长度:{2},是否可空:{3})", Caption, objDataTypeAbbrEN.DataTypeName, FldLength, IsNull);
            }

        }
        public string DefPrivateProperty(string strLangType)
        {
            switch (strLangType)
            {
                case "C#.NET":
                    return "protected " + this.objDataTypeAbbrEN.CsType + " " + PrivPropName + ";" + "    //" + Caption;
                case "Java":
                    return "protected " + this.objDataTypeAbbrEN.JavaType + " " + PrivPropName + ";" + "    //" + Caption;
                case "VB.NET":
                    return "protected " + this.objDataTypeAbbrEN.VbNetType + " " + PrivPropName + ";" + "    //" + Caption;
                default:
                    return "protected " + this.objDataTypeAbbrEN.CsType + " " + PrivPropName + ";" + "    //" + Caption;
            }

        }
        public override string ToString()
        {
            bool mbolIsReadOnly = false;
            bool mbolIsWriteOnly = false;
            string PropStr = "";
            switch (LangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    if (mbolIsReadOnly == true)
                    {
                        PropStr = "/// <summary>";
                        PropStr += "\r\n/// " + Caption + string.Format("(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})", objDataTypeAbbrEN.DataTypeName, FldLength, IsNull);
                        PropStr += "\r\n/// </summary>";
                        PropStr += "\r\npublic readonly " + this.objDataTypeAbbrEN.CsType + " " + FldName;
                        PropStr += "\r\n{";
                        PropStr += "\r\nget";
                        PropStr += "\r\nreturn " + PrivPropName;
                        PropStr += "\r\n}";
                        PropStr += "\r\n}";
                    }
                    else if (mbolIsWriteOnly == true)
                    {
                        PropStr = "/// <summary>";
                        PropStr += "\r\n/// " + Caption + string.Format("(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})", objDataTypeAbbrEN.DataTypeName, FldLength, IsNull, MemoInTab);
                        PropStr += "\r\n/// </summary>";
                        PropStr += "\r\npublic writeonly " + this.objDataTypeAbbrEN.CsType + " " + FldName;
                        PropStr += "\r\n{";
                        PropStr += "\r\nset";
                        PropStr += "\r\n{";
                        PropStr += "\r\n" + PrivPropName + " = value";
                        PropStr += "\r\n" + "//记录修改过的字段";
                        PropStr += "\r\n" + string.Format("AddUpdatedFld(\"{0}\");", FldName);


                        PropStr += "\r\n}";
                        PropStr += "\r\n}";
                    }
                    else
                    {
                        PropStr = "/// <summary>";
                        PropStr += "\r\n/// " + Caption + string.Format("(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})", objDataTypeAbbrEN.DataTypeName, FldLength, IsNull, MemoInTab);
                        PropStr += "\r\n/// </summary>";
                        PropStr += "\r\npublic " + this.objDataTypeAbbrEN.CsType + " " + FldName;
                        PropStr += "\r\n{";
                        PropStr += "\r\nget";
                        PropStr += "\r\n{";
                        PropStr += "\r\nreturn " + PrivPropName + ";";
                        PropStr += "\r\n}";
                        PropStr += "\r\nset";
                        PropStr += "\r\n{";
                        if (this.objDataTypeAbbrEN.CsType == "string")
                        {
                            PropStr += "\r\nif (value == \"\")";
                            PropStr += "\r\n{";
                            PropStr += "\r\nmintErrNo = 1;";
                            PropStr += "\r\n" + PrivPropName + " = value;";
                            PropStr += "\r\n}";
                            PropStr += "\r\nelse";
                            PropStr += "\r\n{";
                            PropStr += "\r\n" + PrivPropName + " = value;";
                            PropStr += "\r\n}";
                        }
                        else
                        {
                            PropStr += "\r\n" + PrivPropName + " = value;";
                        }
                        PropStr += "\r\n" + "//记录修改过的字段";
                        PropStr += "\r\n" + string.Format("AddUpdatedFld(\"{0}\");", FldName);

                        PropStr += "\r\n}";
                        PropStr += "\r\n}";
                    }
                    break;
                case clsPubConst.LangType.JAVA:// "Java":
                    PropStr = "/// <summary>";
                    PropStr += "\r\n/// " + Caption + string.Format("(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})", objDataTypeAbbrEN.DataTypeName, FldLength, IsNull, MemoInTab);
                    PropStr += "\r\n/// </summary>";
                    PropStr += "public " + this.objDataTypeAbbrEN.JavaType + " get" + FldName + "()";
                    PropStr += "\r\n{";
                    PropStr += "\r\nreturn " + PrivPropName + ";";
                    PropStr += "\r\n}";
                    PropStr += "\r\npublic void set" + FldName + "(" + this.objDataTypeAbbrEN.JavaType + " value)";
                    PropStr += "\r\n{";
                    if (this.objDataTypeAbbrEN.JavaType == "String")
                    {
                        PropStr += "\r\nif (value == \"\")";
                        PropStr += "\r\n{";
                        PropStr += "\r\nmintErrNo = 1;";
                        PropStr += "\r\n}";
                        PropStr += "\r\nelse";
                        PropStr += "\r\n{";
                        PropStr += "\r\n" + PrivPropName + " = value;";
                        PropStr += "\r\n}";
                    }
                    else
                    {
                        PropStr += "\r\n" + PrivPropName + " = value;";
                    }

                    PropStr += "\r\n}";
                    break;
                case clsPubConst.LangType.VB:// "VB.NET":
                    break;
            }
            return PropStr;
        }
        /// <summary>
        /// 字段名，首字母大写
        /// </summary>
        public string FldName_FstUcase
        {
            get
            {
                return clsString.FirstUcaseS(mstrFldName);
            }
        }

        /// <summary>
        /// 字段名，首字母小写
        /// </summary>
        public string FldName_FstLcase0
        {
            get
            {
                return clsString.FstLcaseS(mstrFldName);
            }
        }
        /// <summary>
        /// 加上对象名的私有属性名
        /// </summary>
        /// <param name="strObjName">对象名</param>
        /// <returns>返回的加上对象名的私有属性名</returns>
        public string PrivPropNameWithObjectName(string strObjName)
        {
            return strObjName + "." + this.mstrFldName;
        }

        public string PrivPropNameWithObjectName_TS(string strObjName)
        {
            return strObjName + "." + FldName_FstLcase0;
        }

        /// <summary>
        /// 字段名，首字母小写，并且全部小写
        /// </summary>
        public string DefaultValue4Test_Swift
        {
            get
            {
                int intFldLength = this.FldLength;
                if (this.FldLength>100)
                {
                    intFldLength = 100;
                }
                switch(this.objDataTypeAbbrEN.SwiftType)
                {
                    case "String":
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                    case "Int":
                        return string.Format("{0}", 0);
                    case "double":
                        return string.Format("{0}", 0.0);
                    case "DateTime":
                        return string.Format("{0}", "2010-1-1");
                    case "Bool":
                        return string.Format("{0}", "false");
                    case "float":
                        return string.Format("{0}", "0.0");
                    case "long":
                        return string.Format("{0}", "0");
                    default:
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                }
            }
        }

        /// <summary>
        /// 字段名，首字母小写，并且全部小写
        /// </summary>
        public string DefaultValue4Test_Java
        {
            get
            {
                int intFldLength = this.FldLength;
                if (this.FldLength > 100)
                {
                    intFldLength = 100;
                }
                switch (this.objDataTypeAbbrEN.JavaType)
                {
                    case "String":
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                    case "int":
                        return string.Format("{0}", 0);
                    case "double":
                        return string.Format("{0}", 0.0);
                    case "Date":
                        return string.Format("{0}", "clsDate.StrToDate(\"2010-1-1\")");
                    case "boolean":
                        return string.Format("{0}", "false");
                    case "float":
                        return string.Format("{0}", "0.0f");
                    case "long":
                        return string.Format("{0}", "0");
                    default:
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                }
            }
        }
        public string DefaultValue4Test_CSharp
        {
            get
            {
                int intFldLength = this.FldLength;
                if (this.FldLength > 100)
                {
                    intFldLength = 100;
                }
                switch (this.objDataTypeAbbrEN.CsType)
                {
                    case "string":
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                    case "int":
                        return string.Format("{0}", 0);
                    case "double":
                        return string.Format("{0}", 0.0);
                    case "DateTime":
                        return string.Format("{0}", "clsDateTime.GetDateTimeByDateStr8(\"20010101\")");
                    case "boolean":
                    case "bool":
                        return string.Format("{0}", "false");
                    case "float":
                        return string.Format("{0}", "0.0f");
                    case "long":
                        return string.Format("{0}", "0");
                    default:
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                }
            }
        }


        /// <summary>
        /// 字段名，首字母小写，并且全部小写
        /// </summary>
        public string ToString4GC_Java
        {
            get
            {
                int intFldLength = this.FldLength;
                if (this.FldLength > 100)
                {
                    intFldLength = 100;
                }
                switch (this.objDataTypeAbbrEN.JavaType)
                {
                    case "String":
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                    case "Int":
                        return string.Format("Integer.toString({0})", this.PrivFuncName);
                    case "double":
                        return string.Format("{0}", 0.0);
                    case "DateTime":
                        return string.Format("{0}", "2010-1-1");
                    case "Bool":
                        return string.Format("{0}", "false");
                    case "float":
                        return string.Format("{0}", "0.0");
                    case "long":
                        return string.Format("Long.toString({0})", this.PrivFuncName);
                    default:
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                }
            }
        }
        /// <summary>
        /// 字段名，首字母小写，并且全部小写
        /// </summary>
        public string DefaultValue4Test_JavaScript
        {
            get
            {
                int intFldLength = this.FldLength;
                if (this.FldLength > 100)
                {
                    intFldLength = 100;
                }
                switch (this.objDataTypeAbbrEN.SwiftType)
                {
                    case "String":
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                    case "Int":
                        return string.Format("{0}", 0);
                    case "double":
                        return string.Format("{0}", 0.0);
                    case "DateTime":
                        return string.Format("{0}", "2010-1-1");
                    case "Bool":
                        return string.Format("{0}", "false");
                    case "float":
                        return string.Format("{0}", "0.0");
                    case "long":
                        return string.Format("{0}", "0");
                    default:
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                }
            }
        }
        /// <summary>
        /// 字段名，首字母小写，并且全部小写
        /// </summary>
        public string DefaultValue4Test_TypeScript
        {
            get
            {
                int intFldLength = this.FldLength;
                if (this.FldLength > 100)
                {
                    intFldLength = 100;
                }
                switch (this.objDataTypeAbbrEN.SwiftType)
                {
                    case "String":
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                    case "Int":
                        return string.Format("{0}", 0);
                    case "double":
                        return string.Format("{0}", 0.0);
                    case "DateTime":
                    case "Date":
                        return string.Format("{0}", "new Date(\"2001-1-1\")");
                    case "Bool":
                        return string.Format("{0}", "false");
                    case "float":
                        return string.Format("{0}", "0.0");
                    case "number":
                        return string.Format("{0}", "0.0");
                    case "long":
                        return string.Format("{0}", "0");
                    default:
                        return string.Format("{0}", clsString.combineStrS("1", intFldLength));
                }
            }
        }


        /// <summary>
        /// 字段名，首字母小写，并且全部小写
        /// </summary>
        public string InitValue_TypeScript
        {
            get
            {
   
                switch (this.objDataTypeAbbrEN.SwiftType)
                {
                    case "String":
                        return string.Format("\"\"");
                    case "Int":
                    case "Int32":
                    case "CShort":
                        return string.Format("{0}", 0);
                    case "double":
                    case "Double":

                        return string.Format("{0}", 0.0);
                    case "DateTime":
                        return string.Format("{0}", "2010-1-1");
                    case "Date":
                        return string.Format("{0}", "new Date()");
                    case "Bool":
                        return string.Format("{0}", "false");
                    case "float":
                    case "Float":

                        return string.Format("{0}", "0.0");
                    case "number":
                        return string.Format("{0}", "0.0");
                    case "long":
                        return string.Format("{0}", "0");
                    default:
                        return string.Format("\"\"");
                }
            }
        }
        /// <summary>
        /// 字段名，首字母小写，并且全部小写
        /// </summary>
        public string FldName_Java
        {
            get
            {
                return clsString.FstLcaseS(mstrFldName.ToLower());
            }
        }

        //public string CodeTabCode
        //{
        //    get
        //    {
        //        return mstrCodeTabCode;
        //    }

        //    set
        //    {
        //        mstrCodeTabCode = value;
        //    }
        //}

        public string CodeTabName
        {
            get
            {
                return mstrCodeTabName;
            }

            set
            {
                mstrCodeTabName = value;
            }
        }

        public string CodeTabCode
        {
            get
            {
                return mstrCodeTabCode;
            }

            set
            {
                mstrCodeTabCode = value;
            }
        }



        ///// <summary>
        ///// 字段名，首字母小写
        ///// </summary>
        //public string FldName_FstLcase
        //{
        //    get
        //    {
        //        return CommProgramSet.clsComm.FstLcaseS(mstrFldName);
        //    }
        //}
        ///// <summary>
        ///// 字段名，首字母大写
        ///// </summary>
        //public string FldName_FstUcase
        //{
        //    get
        //    {
        //        return clsString.FirstUcaseS(mstrFldName);
        //    }
        //}

    }
}
