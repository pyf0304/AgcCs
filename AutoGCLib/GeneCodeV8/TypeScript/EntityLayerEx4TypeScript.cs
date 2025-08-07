using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 
    /// </summary>
    class EntityLayerEx4TypeScript : clsGeneCodeBase4Tab
    {
        //protected CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
        private string strIsShare_GC = "";

        //public string ClsName;
        private bool mbolIsHaveImageField;
        private string mstrImageFieldName;
        protected string mstrFolderName; // '文件目录名
        protected string mstrFileName;

        #region 构造函数

        public EntityLayerEx4TypeScript(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {

            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../..";
            this.arrImportClass = new List<ImportClass>();
        }
        #endregion

        public string FileName
        {
            get
            {
                return mstrFileName;
            }
            set
            {
                mstrFileName = value;
            }
        }
        public bool IsHaveImageField
        {
            get
            {
                return mbolIsHaveImageField; // '文件目录名
            }
            set
            {
                mbolIsHaveImageField = value;
            }
        }

        public string ImageFieldName
        {
            get
            {
                return mstrImageFieldName; // '文件目录名
            }
            set
            {
                mstrImageFieldName = value;
            }
        }



        public string FolderName
        {
            get
            {
                return mstrFolderName; // '文件目录名
            }
            set
            {
                mstrFolderName = value;
            }
        }



        /// <summary>
        /// 类的私有变量,用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string gfunClsPrivateVar()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n protected {0} {1};	//{2}",
                objField.JavaType,
                clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java),
                objField.ColCaption);
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string GenClsProperty()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strTemp = objField.ObjFieldTabENEx.FldName_Java;
                clsString.FstUcase_S(ref strTemp);
                strBuilder.AppendFormat("\r\n //获取{0}({1})的值", objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public {0} get{1}()", objField.JavaType, strTemp);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n return objViewInfoENEx.{0};", objField.ObjFieldTabENEx.FldName_Java);
                strBuilder.Append("\r\n }");
                strBuilder.AppendFormat("\r\n //设置{0}({1})的值", objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objField.JavaType);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = value;", objField.ObjFieldTabENEx.FldName_Java);
                strBuilder.AppendFormat("\r\n hmProperty.put(\"{0}\", \"true\");",
                objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// 类索引器
        /// </summary>
        /// <returns></returns>
        public string gfunClsIndexer()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic static int AttributeCount");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn _AttributeCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            //类索引器,字符串参数
            strBuilder.Append("\r\npublic object this[string strAttributeName]");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), AccessNull("value.toString()", objField.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), AccessNull("value.toString()", objField.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            //类索引器,整型(INT)序号参数

            strBuilder.Append("\r\npublic object this[int intIndex]");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (\"{0}\" == _AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\" == _AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (\"{0}\" == _AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), AccessNull("value.toString()", objField.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\" == _AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), AccessNull("value.toString()", objField.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }

        public string gfunpErrNo()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///属性过程;
            ///每个表类都应该有的错误代码类;
            strBuilder.Append("\r\npublic int ErrNo");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return mintErrNo;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n mintErrNo = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunDispErrMsg()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///每个表类都应该有的对外显示的错误信息;
            strBuilder.Append("\r\npublic string DispErrMsg //对外显示的错误信息");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return objViewInfoENEx.DispErrMsg;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objViewInfoENEx.DispErrMsg = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunClassConstructor3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, boolean bolIsGet{2})",
              objPrjTabENEx.ClsName, GetKeyPara(), ThisTabName4GC);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n hmProperty = new HashMap<String, String>();");
            strBuilder.AppendFormat("\r\n{0}", GetKeyAssign() + ";");
            strBuilder.Append("\r\nSetInit();");
            strBuilder.AppendFormat("\r\nif (bolIsGet{0} == true)", ThisTabName4GC);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nGet{0}();", ThisTabName4GC);
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", ThisTabName4GC);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string gfunClassConstructorEx1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n public " + strClsNameEx + "()" + ": base()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunClassConstructorEx2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic " + strClsNameEx + "(" + GetKeyPara() + ")" + ": base(" + objKeyField.PrivFuncName + ")");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunClassConstructorEx3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, boolean bolIsGet{2}) : base({3},bolIsGet{2})",
            strClsNameEx, GetKeyPara(), ThisTabName4GC, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string gfunSetInit()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 设置类的有些属性初始值");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\nprivate void SetInit()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjViewInfoENEx.ModuleName = objViewInfoENEx.GetType().toString();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.JavaType == "Date")
                {
                    strBuilder.Append("\r\n" + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase) + " = System.DateTime.Parse(\"01/01/1900\");	");
                }
            }
            strBuilder.Append("\r\n}");
            ///类构造器 == == == = ;
            return strBuilder.ToString();
        }

        public string gfunfunSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n/// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n/// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.SetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, fltValue, strCondition);",
            ThisTabName4GC);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n/// <param name = \"intValue\">值</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n/// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.SetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, intValue, strCondition);",
            ThisTabName4GC);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n/// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n/// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.SetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, strValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n/// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n/// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.SetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, intValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n/// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n/// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.SetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:获取当前表中的符合条件的某字段的值,以列表返回");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n/// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic ArrayList clsGeneralTab2.GetFldValue(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nArrayList arrList = objSQL.GetFldDataOfTable(\"{0}\", strFldName, strCondition);",
            ThisTabName4GC);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:获取给定表中的符合条件的某字段的值,以列表返回");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n/// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic static ArrayList clsGeneralTab2.GetFldValue(string strTabName, string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nArrayList arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///设置/获取表中的符合条件的某字段的值 == = ;
            return strBuilder.ToString();
        }
        public string gfunDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\npublic int DelRecord() ");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n String strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			if ( objFKSet.GetDelFKTab != \")
            //										 {
            //											 strBuilder.Append("\r\n//删除与" + ThisTabName4GC + "表有关的外键表中的内容");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//删除" + ThisTabName4GC + "本表中与当前对象有关的记录");
            strBuilder.AppendFormat("\r\n strSQL = strSQL + \"Delete from {0} \";",
            ThisTabName4GC,
            objPrjTabENEx.TabSpace);
            strBuilder.AppendFormat(" strSQL += \" where {0} = ?\";", objKeyField.FldName);
            strBuilder.Append("\r\n PreparedStatement objPS = objSQL.getPreparedStmt(strSQL);");
            strBuilder.Append("\r\n // PreparedStatement objPS = objSQL.getCallableStmt(strSQL);");
            strBuilder.Append("\r\n objPS.clearParameters();");

            int intFieldNo = 1;
            string strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            if (strTemp == "Long")
            {
                strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
                strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.FldName_Java));
            }
            else if (strTemp == "Int")
            {
                strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
                strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.FldName_Java));
            }
            else
            {
                strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
                strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.FldName_Java));
            }
            intFieldNo += 1;
            strBuilder.Append("\r\n int iResult = 0;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n iResult = objPS.executeUpdate();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException e)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw e;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objPS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return iResult;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }
        public string gfunDelMultiRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除一些记录------------------;
            strBuilder.Append("\r\n//同时删除多条记录");
            string strTemp = string.Format("public static int Del{0}(List<string> lstKey)",
            ThisTabName4GC);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n String strKeyList;");
            strBuilder.Append("\r\n if (lstKey.size() == 0) return 0;");
            strBuilder.Append("\r\n strKeyList = \"\";");
            strBuilder.Append("\r\n int i = 0;");
            strBuilder.Append("\r\n Iterator e = lstKey.iterator();");
            strBuilder.Append("\r\n while(e.hasNext())");
            strBuilder.Append("\r\n {");
            ///				if ( (i == 0) strKeyList += "'" + lstKey[i].ToString() + "'";
            ///				else strKeyList += ", " + "'" + lstKey[i].ToString() + "'";
            if (objPrjTabENEx.arrKeyFldSet.Count == 0)
            {
                strBuilder.Append("\r\n//你的表" + ThisTabName4GC + " 中没有关键字,请你设置一个关键字!");
            }
            else
            {
                strBuilder.Append("\r\nif (i == 0) strKeyList = strKeyList + " + Mark(objPrjTabENEx.objKeyField0) + " + e.toString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\nelse strKeyList += \",\" + " + Mark(objPrjTabENEx.objKeyField0) + " + e.toString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\n i++;");
                strBuilder.Append("\r\n}");
            }
            strBuilder.Append("\r\nstrSQL = \"\";");
            //				if ( objFKSet.GetDelFKTab != \")
            //											 {
            //												 strBuilder.Append("\r\n//删除与" + ThisTabName4GC + "表有关的外键表中的内容");
            //					foreach(clsForeignKey objForeignKey in arrForeignKeySet)
            //					{	 
            //						strBuilder.Append("\r\nstrSQL = strSQL + \"Delete " + objFK.FKTABLE_NAME + " where " + objKeyField.ColumnName + " in (\" + strKeyList + \")"";");
            //					}
            //			}
            strBuilder.Append("\r\n//删除" + ThisTabName4GC + "本表中与当前对象有关的记录");
            if (objPrjTabENEx.arrKeyFldSet.Count == 0)
            {
                strBuilder.Append("\r\n//你的表" + ThisTabName4GC + " 中没有关键字,请你设置一个关键字!");
                strBuilder.Append("\r\nreturn false;");
            }
            else
            {
                strBuilder.AppendFormat("\r\nstrSQL = strSQL + \"Delete from {0} where " + objKeyField.FldName + " in (\" + strKeyList + \")\";",
                ThisTabName4GC,
                objPrjTabENEx.TabSpace);
                strBuilder.Append("\r\n int iResult = 0;");
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n iResult = objSQL.execSQL(strSQL);");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n catch (SQLException e1)");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n throw e1;");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n finally");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n objSQL.close();");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n return iResult;");
            }
            strBuilder.Append("\r\n}");
            ///删除一些记录 == = ;
            return strBuilder.ToString();
        }

        public string gfunDelMultiRec_neusoft()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除一些记录------------------;
            strBuilder.Append("\r\n//同时删除多条记录");
            string strTemp = string.Format("public int[] Del{0}s_neusoft(List lstKey)",
            ThisTabName4GC);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n throws OPException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n int[] rows;");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.AppendFormat("\r\n strSQL = \"Delete from {0} where {1} = ? \";",
            ThisTabName4GC, objKeyField.FldName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n rows = pm.executeUpdateBatch(strSQL, lstKey);");
            strBuilder.Append("\r\n return rows;");
            strBuilder.Append("\r\n }");

            ///删除一些记录 == = ;
            return strBuilder.ToString();
        }


        public string gfunDelRecord_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除一条记录-----------------;
            strBuilder.Append("\r\n" + string.Format("public static int DelRecord({0} {1}) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.PrivFuncName));
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//删除单条记录");
            strBuilder.Append("\r\n String strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			if ( objFKSet.GetDelFKTab != \")
            //			{
            //				strBuilder.Append("\r\n//删除与" + ThisTabName4GC + "表有关的外键表中的内容");
            //				strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            string strTemp = string.Format("//删除{0}本表中与当前对象有关的记录",
            ThisTabName4GC);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.AppendFormat("\r\nstrSQL = strSQL + \"Delete from {0} where " + KeyWhereStr(false, objPrjTabENEx) + ";",
            ThisTabName4GC,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n int iResult = 0;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n iResult = objSQL.execSQL(strSQL);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException e1)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw e1;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return iResult;");
            strBuilder.Append("\r\n}");
            ///删除一条记录 == = ;
            return strBuilder.ToString();
        }
        public string gfunDelCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除多条记录,删除带条件的记录------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:删除多条记录,带条件的删除");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n/// <returns>返回删除的记录数。</returns>");
            strBuilder.AppendFormat("\r\npublic static int Del{0}(String strCondition)",
            ThisTabName4GC);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException , NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n if (strCondition == \"\")");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return 0;	//表示删除0条记录,实际上是不能该表的所有记录");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
            ThisTabName4GC,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n int iResult = 0;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n iResult = objSQL.execSQL(strSQL);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException e1)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw e1;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return iResult;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n ");
            ///删除多条记录,删除带条件的记录 == = ;
            return strBuilder.ToString();
        }


        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            //if (objPrjTabENEx.IsShare) strIsShare_GC = "_1Share";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                                  ThisTabName4GC, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                  ThisTabName4GC, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = "cls" + ThisTabName4GC + "ENEx";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".ts";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".ts";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            this.objCodeElement_Root = new CodeElement { Name = "Root", ElementType = CodeElementType.Root };

            this.objCodeElement_Imports = new CodeElement { Name = "imports", ElementType = CodeElementType.Import, Modifiers = "export abstract" };
            this.objCodeElement_Root.Children.Add(this.objCodeElement_Imports);

            this.objCodeElement_Class = new CodeElement { Name = ThisClsName, ElementType = CodeElementType.Class, Modifiers = "export abstract" };
            this.objCodeElement_Root.Children.Add(this.objCodeElement_Class);
            try
            {


                //生成所有的函数

                //foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                //{
                //    strFuncName = objvFunction4GeneCodeEN.FuncName;
                //    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                //    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                //    if (string.IsNullOrEmpty(strTemp) == false)
                //    {
                //        strCodeForCs.Append("\r\n" + strTemp);
                //    }

                //}
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    objvFunction4GeneCodeEN.CodeText = strTemp;
                }


                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));


                strCodeForCs.Append("\r\n /**");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// {0}({1}),专门针对SilverLight的实体类", objPrjTabENEx.TabCnName, ThisTabName4GC);
                //}
                //else
                //{
                strCodeForCs.AppendFormat("\r\n * {0}({1})", objPrjTabENEx.TabCnName, ThisTabName4GC);
                //}
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                //StringBuilder sbImport = new StringBuilder();

                //sbImport.AppendFormat("\r\n" + "import {{ cls{1}EN }} from \"../../L0Entity/{0}/cls{1}EN.js\";",
                // objFuncModule.FuncModuleEnName4GC()
                // ThisTabName4GC);

                GetImportClassLst(objFuncModule);
                StringBuilder sbImport = new StringBuilder();
                foreach (var objInFor in arrImportClass)
                {
                    sbImport.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClsName,
                        objInFor.FilePath);
                }

                foreach (var objInFor in arrImportClass)
                {
                    CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objInFor);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);
                }
                if (objPrjTabENEx.ApplicationTypeId == (int)enumApplicationType.VueAppInCore_TS_30)
                {
                    sbImport = sbImport.Replace(".js", "")
                        .Replace("../../L0Entity", "@/ts/L0Entity");
                }
                strCodeForCs.AppendLine(sbImport.ToString());

                strCodeForCs.AppendFormat("\r\n" + "export class  {1} extends {0}",
                    ThisClsName4EN, ThisClsName4ENEx,
                    this.objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.Append("\r\n" + "//以下是属性变量");

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }


                strCodeForCs.Append("\r\n" + Gen_ENEx_hasProperty());

                //strCodeForCs.Append("\r\n" + "this.init();");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);

            }
            objCodeElement_Root.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public new string GenClassConstructor1()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("constructor() ", "");

            Re_objFunction4Code.FuncCHName4Code = "构造函数.";

            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strBuilder.Append("\r\n/**");
            strBuilder.Append("\r\n * 构造函数");
            strBuilder.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n **/");
            strBuilder.AppendFormat("\r\n constructor()",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n super();");
            //strBuilder.Append("\r\n this.hmProperty =  new collections.Dictionary <string, boolean>();");
            //strBuilder.Append("\r\n this.SetInit();");

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 生成表字段名常量
        /// </summary>
        /// <returns></returns>
        public string A_GenTableFldConstCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                                  ThisTabName4GC, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                  ThisTabName4GC, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = "con" + ThisTabName4GC;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));


                strCodeForCs.Append("\r\n /// <summary>");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// {0}({1}),专门针对SilverLight的实体类", objPrjTabENEx.TabCnName, ThisTabName4GC);
                //}
                //else
                //{
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, ThisTabName4GC);
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                //  strCodeForCs.Append("\r\n" + "[Serializable]");
                //}
                strCodeForCs.AppendFormat("\r\n" + "/// <reference path=\"../PubFun/jsGeneralTab.js\" />");

                strCodeForCs.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中");

                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsGeneralTab.js\");");

                strCodeForCs.AppendFormat("\r\n" + "const const{0} = function({1})",
                    ThisTabName4GC,
                    this.objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN.prototype = new clsGeneralTab();", ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n" + "clsGeneralTab.call(this);", ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1} || {2};",
                                this.objKeyField.FldName,
                                this.objKeyField.PrivFuncName,
                                 (this.objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true ? "\"\"" : "0")
                );
                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n" + "const CurrTabName_S = \"" + ThisTabName4GC + "\"; //当前表名,与该类相关的表名");
                strCodeForCs.Append("\r\n" + "const CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
                //与属性名称相关的常量代码

                //与属性名称相关的代码
                strCodeForCs.AppendFormat("\r\n" + "const mintAttributeCount = {0};",
                objPrjTabENEx.arrFldSet.Count);
                strTemp = "";
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp == "")
                    {
                        strTemp += "\"" + objField.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp += ", \"" + objField.ObjFieldTabENEx.FldName + "\"";
                    }
                }

                strCodeForCs.AppendFormat("\r\n" + "const AttributeName = new Array({0});",
                strTemp);

                strCodeForCs.Append("\r\n" + "//以下是属性变量");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "this.init();");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);

            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(EntityLayerEx4TypeScript);
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
                    Re_objFunction4Code.FuncName4Code = this.Re_objFunction4Code.FuncName4Code;
                    Re_objFunction4Code.FuncCHName4Code = this.Re_objFunction4Code.FuncCHName4Code;

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
            this.ClsName = string.Format("cls{0}ENEx", ThisTabName4GC);
            objPrjTabENEx.ClsName = this.ClsName;
        }

        public string Gen_ENEx_SetFldValue()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * 设置对象中某字段名的值.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param strFldName:字段名", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @param strValue:字段值", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns 字段值");
            strCodeForCs.AppendFormat("\r\n*/");

            //类索引器,字符串参数
            strCodeForCs.Append("\r\npublic SetFldValue(strFldName: string, strValue:string)");
            strCodeForCs.Append("\r\n{");
            strFuncName = "SetFldValue";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"SetFldValue\";", ThisTabName4GC,
objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");
            strCodeForCs.Append("\r\n" + "switch (strFldName)");
            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetEx)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (objField.IsGeneProp == false) continue;
                strCodeForCs.AppendFormat("\r\ncase cls{0}ENEx.con_{1}:",
                    ThisTabName4GC,
                objField.ObjFieldTabENEx.FldName);
                switch (objField.ObjFieldTabENEx.TypeScriptType)
                {
                    case "string":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = strValue;",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        break;
                    case "number":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = Number(strValue);",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        break;
                    case "boolean":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = Boolean(strValue);",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        break;
                    case "any":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = strValue;",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                        break;
                    case "Date":
                        strCodeForCs.AppendFormat("\r\n" + "this.{0} = new Date(Date.parse(strValue));",
                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                        break;

                    default:
                        var strMsg = string.Format("TypeScript:[{0}]在函数中没有被处理。(in {1})", objField.ObjFieldTabENEx.TypeScriptType, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                        //break;
                }
                if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
                {
                    strCodeForCs.AppendFormat("\r\n    this.hmProperty[\"{0}\"] = true;",
           objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                }
                strCodeForCs.Append("\r\n" + "break;");

            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.Append("\r\ncase \"sfUpdFldSetStr\":");
                strCodeForCs.AppendFormat("\r\n" + "this.sfUpdFldSetStr = strValue;");
                strCodeForCs.Append("\r\n" + "break;");
            }
            strCodeForCs.Append("\r\ncase \"sfFldComparisonOp\":");
            strCodeForCs.AppendFormat("\r\n" + "this.sfFldComparisonOp = strValue;");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = `字段名:[${{strFldName}}]在表对象:[{0}]中不存在!(in ${{this.constructor.name}}.${{strThisFuncName}})`;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 类的字段名称常量,用于类属性名称的引用
        /// </summary>
        /// <returns></returns>
        public string Gen_ENEx_PropertyNameConst()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            //定义类中属性名称常量
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetEx)
            {
                if (objField.IsGeneProp == false) continue;
                
                string strTemp = clsPrjTabFldBLEx.DefPropertyNameConst(objPrjTabENEx.LangType, objField, this.IsFstLcase, clsStackTrace.GetCurrClassFunction());
                strFuncName = $"con_{objField.FldName}";
                strCodeForCs.Append("\r\n" + strTemp);
                clsPubFun4GC.AddCodeElement_Property(this.objCodeElement_Class, new CodeElement
                {
                    Name = strFuncName,
                    CodeContent = strTemp,
                    ElementType = CodeElementType.Constant,
                    Modifiers = "public async",
                    ReturnType = "void",
                });
                if (strFuncName == "")
                {
                    string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
            }
            //clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            //{
            //    Name = strFuncName,
            //    CodeContent = strCodeForCs.ToString(),
            //    ElementType = CodeElementType.Method,
            //    Modifiers = "public async",
            //    ReturnType = "void",
            //});
            //if (strFuncName == "")
            //{
            //    string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 类索引器
        /// </summary>
        /// <returns></returns>
        public string Gen_ENEx_GetFldValue()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * 根据字段名获取对象中某字段的值.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param strFldName:字段名", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns 字段值");
            strCodeForCs.AppendFormat("\r\n*/");

            //类索引器,字符串参数
            strCodeForCs.Append("\r\npublic GetFldValue(strFldName: string):any");
            strFuncName = $"GetFldValue";
            strCodeForCs.Append("\r\n{");
            //            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetFldValue\";", ThisTabName4GC,
            //objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "let strValue;");

            strCodeForCs.Append("\r\n" + "switch (strFldName)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case \"CtrlId\":");
            strCodeForCs.Append("\r\n" + "return \"\";");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetEx)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (objField.IsGeneProp == false) continue;
                strCodeForCs.AppendFormat("\r\ncase cls{0}ENEx.con_{1}:",
                    ThisTabName4GC,
                objField.ObjFieldTabENEx.FldName);

                strCodeForCs.AppendFormat("\r\nreturn this.{0};",
                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

            }
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "strValue = super.GetFldValue(strFldName);");
            strCodeForCs.Append("\r\n" + "return strValue;");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 类的私有变量,用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string Gen_ENEx_ClsPublicVar()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetEx)
            {
                if (objField.IsGeneProp == false) continue;
                //strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPublicProperty(objPrjTabENEx.LangType, objField, this.IsFstLcase, this, this.strBaseUrl));
                string strTemp = clsPrjTabFldBLEx.DefPublicProperty(objPrjTabENEx.LangType, objField, this.IsFstLcase, this, "@/ts");
                strFuncName = objField.PropertyName(this.isFstLcase);
                strCodeForCs.Append("\r\n" + strTemp);
                clsPubFun4GC.AddCodeElement_Property(this.objCodeElement_Class, new CodeElement
                {
                    Name = strFuncName,
                    CodeContent = strTemp,
                    ElementType = CodeElementType.Property,
                    Modifiers = "public async",
                    ReturnType = "void",
                });
                if (strFuncName == "")
                {
                    string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
            }
            //clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            //{
            //    Name = strFuncName,
            //    CodeContent = strCodeForCs.ToString(),
            //    ElementType = CodeElementType.Method,
            //    Modifiers = "public async",
            //    ReturnType = "void",
            //});
            //if (strFuncName == "")
            //{
            //    string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}
            return strCodeForCs.ToString();
        }
        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("{0}", ThisClsName4EN),
                FilePath = string.Format("../../L0Entity/{0}{2}/cls{1}EN.js", objFuncModule.FuncModuleEnName4GC(),
                   ThisTabName4GC, strIsShare_GC)
            });

            arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
            return arrImportClass;
        }

        //public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        //{
        //    return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, objPrjTabENEx.PrjId);
        //}

        public string Gen_ENEx_hasProperty()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            ///定义类中私有属性

            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "* 判断一个字符串是否是类的属性");
            strCodeForCs.Append("\r\n" + "* @param propName: 属性名");
            strCodeForCs.Append("\r\n" + "* @returns 是否是属性");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public static hasProperty(propName: string) : boolean {");
            strFuncName = "hasProperty";
            strCodeForCs.Append("\r\n" + $"//return propName in new {ThisClsName4ENEx}();");
            strCodeForCs.Append("\r\n" + $"const instance = new {ThisClsName4ENEx}();");
            strCodeForCs.Append("\r\n" + "return Object.prototype.hasOwnProperty.call(instance, propName);");
            strCodeForCs.Append("\r\n" + "}");


            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

    }
}
