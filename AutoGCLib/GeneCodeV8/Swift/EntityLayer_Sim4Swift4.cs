using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.sql;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace AutoGCLib
{
    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层,专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层,即通用数据层,专门用于操作数据库的一些操作,以及操作表的一些通用操作
    /// </summary>
    class EntityLayer_Sim4Swift4 : clsGeneCodeBase4Tab
    {
        //internal CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        //public string ClsName;
    
        private bool mbolIsHaveImageField;
        private string mstrImageFieldName;
        protected string mstrFolderName; // '文件目录名
        protected string mstrFileName;

        #region 构造函数

        public EntityLayer_Sim4Swift4(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
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



        public string GenSQLCode(string strPrjDataBaseId, clsPrjTabENEx objPrjTabENEx)
        {
            string strResult = "";
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseId(strPrjDataBaseId);
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                         objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                      objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;    //数据库拥有者
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;       //, strIsNullable0;		// = " null ";
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度

            ArrayList arrFieldCodes = new ArrayList();

            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {

                ///计算字段名
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///计算字段类型
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///计算字段长度
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///计算字段注释(即字段中文名称)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + "*/";

                ///计算是否可空

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///计算主键

                if (objField.ObjFieldTabENEx.IsIdentity == true)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }
            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        public string GenSQLCode4CreateTab(string strPrjDataBaseId, clsPrjTabENEx objPrjTabENEx)
        {
            string strResult = "";
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseId(strPrjDataBaseId);
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                            objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;       //, strIsNullable0;		// = " null ";
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度

            ArrayList arrFieldCodes = new ArrayList();

            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {
               
                ///计算字段名
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///计算字段类型
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///计算字段长度
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///计算字段注释(即字段中文名称)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + "*/";

                ///计算是否可空

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///计算主键

                if (objField.ObjFieldTabENEx.IsIdentity == true)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

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
                strBuilder.AppendFormat("\r\n internal {0} {1};	//{2}",
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
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName_Java;
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
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
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
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName), AccessNull("value.toString()", objField.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName), AccessNull("value.toString()", objField.JavaType, true));
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
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\" == _AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
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
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName), AccessNull("value.toString()", objField.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\" == _AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName), AccessNull("value.toString()", objField.JavaType, true));
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
              objPrjTabENEx.ClsName, GetKeyPara(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n{0}", GetKeyAssign() + ";");
            strBuilder.Append("\r\nSetInit();");
            strBuilder.AppendFormat("\r\nif (bolIsGet{0} == true)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nGet{0}();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
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
            strClsNameEx, GetKeyPara(), objPrjTabENEx.TabName, objKeyField.PrivFuncName);
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
                    strBuilder.Append("\r\n" + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName) + " = System.DateTime.Parse(\"01/01/1900\");	");
                }
            }
            strBuilder.Append("\r\n}");
            ///类构造器 == == == = ;
            return strBuilder.ToString();
        }
        public string gfunAddNewRecord()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///公共过程--------------------------------------;
            ///添加新记录----------------;
            ///
            strBuilder.Append("\r\n public int AddNewRecord()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n strSQL = \"insert into " + objPrjTabENEx.TabName + "\";");
            strBuilder.Append("\r\n strSQL += \" (");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.Append(objField.ObjFieldTabENEx.FldName);
                }
                else
                {
                    strBuilder.Append(", " + objField.ObjFieldTabENEx.FldName);
                }
            }
            strBuilder.Append(") \" ;");
            bolIsFirst = true;
            int intFldNum = objPrjTabENEx.arrFldSet.Count;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.Append("\r\n strSQL += \" values (?");
                }
                else
                {
                    strBuilder.Append(", ?");
                }
            }
            strBuilder.Append(")\";");
            strBuilder.Append("\r\n PreparedStatement objPS = objSQL.getPreparedStmt(strSQL);");
            strBuilder.Append("\r\n // PreparedStatement objPS = objSQL.getCallableStmt(strSQL);");
            strBuilder.Append("\r\n objPS.clearParameters();");

            int intFieldNo = 1;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strTemp = objField.JavaType;
                clsString.FstUcase_S(ref strTemp);
                strBuilder.AppendFormat("\r\n objPS.set" + strTemp + "(" + intFieldNo.ToString().Trim() + ", objViewInfoENEx." + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java) + "); //{0} ",
                objField.ColCaption);
                intFieldNo += 1;
            }
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
            ///添加新记录 == = ;
            return strBuilder.ToString();
        }

        public string gfunAddNewRecord_neusoft()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///公共过程--------------------------------------;
            ///添加新记录----------------;
            ///
            strBuilder.Append("\r\n public int AddNewRecord_neusoft()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, OPException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\n strSQL = \"insert into {0} \";",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n strSQL += \" (");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.Append(objField.ObjFieldTabENEx.FldName);
                }
                else
                {
                    strBuilder.Append(", " + objField.ObjFieldTabENEx.FldName);
                }
            }
            strBuilder.Append(") \" ;");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.ObjFieldTabENEx.IsIdentity)
                    {
                        strBuilder.AppendFormat("\r\n strSQL += \" values ({0}_SEQUENCE.NEXTVAL",
                        objPrjTabENEx.TabName.ToUpper());
                    }
                    else
                    {
                        strBuilder.Append("\r\n strSQL += \" values (? ");
                    }
                }
                else
                {
                    if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.ObjFieldTabENEx.IsIdentity)
                    {
                        strBuilder.AppendFormat("\r\n , {0}_SEQUENCE.NEXTVAL",
                        objPrjTabENEx.TabName.ToUpper());
                    }
                    else
                    {
                        strBuilder.Append(", ?");
                    }
                }
            }
            strBuilder.Append(")\";");
            strBuilder.Append("\r\n Object[] params = {");

            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.ObjFieldTabENEx.IsIdentity)
                    {
                    }
                    else
                    {
                        bolIsFirst = false;

                        strBuilder.AppendFormat("\r\n {0}	//{1}",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName),
                        objField.ColCaption);
                    }
                }
                else
                {
                    if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.ObjFieldTabENEx.IsIdentity)
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n , {0}			//{1}",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName),
                        objField.ColCaption);
                    }
                }
            }

            strBuilder.Append("\r\n };");
            strBuilder.Append("\r\n int iResult = pm.executeUpdate(strSQL, params);");
            strBuilder.Append("\r\n return iResult;");

            strBuilder.Append("\r\n }");
            ///添加新记录 == = ;
            return strBuilder.ToString();
        }


        public string gfunAddNewRecordBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            if (mbolIsHaveImageField == true)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n");
                strBuilder.Append("\r\n/// <summary>");
                strBuilder.Append("\r\n/// 功能:通过SQL命令来插入记录");
                strBuilder.Append("\r\n/// 主要用于上传文件时。");
                strBuilder.Append("\r\n/// </summary>");
                strBuilder.Append("\r\n/// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
                strBuilder.Append("\r\npublic boolean Addnew RecordBySQL() ");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nStringBuffer strSQL = new StringBuffer();");
                strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
                ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objViewInfoENEx.Stdid, mstrFileName);");
                StringBuilder strFieldLst = new StringBuilder();
                StringBuilder strValueLsd = new StringBuilder();
                string strParaIndex = "";
                bool bolIsFirst = true;
                int intIndex = 0;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.ObjFieldTabENEx.IsIdentity == false)
                    {
                        if (bolIsFirst == true)
                        {
                            strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                            strValueLsd.AppendFormat("{0}", clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                            strParaIndex = "'{" + intIndex.ToString() + "}'";
                            bolIsFirst = false;
                        }
                        else
                        {
                            strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                            strValueLsd.AppendFormat(", {0}", clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                            strParaIndex += ", '{" + intIndex.ToString() + "}'";
                        }
                        intIndex = intIndex + 1;
                    }
                }
                strBuilder.AppendFormat("\r\nstrSQL.AppendFormat(\"insert into {3} ({0}) values ({1})\", {2});", strFieldLst.ToString(), strParaIndex, strValueLsd.ToString(), objPrjTabENEx.TabName);
                strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.toString());");
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }


        public string gfunAddnewRecBySP()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strTemp = string.Format("public boolean Addnew{0}BySP() ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");
            strBuilder.Append("\r\n			if ( mintErrNo != 0) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//MsgBox(objViewInfoENEx.text-warning(mintErrNo))");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nobjSQL.setSPConfigXMLFile(\"..\\\\XML\\\\XMLSP.xml\");");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                }
                else
                {
                    strBuilder.Append("\r\nvalues.add(" + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName) + ");");
                }
            }
            strBuilder.Append("\r\nobjSQL.ExecSP(\"Addnew" + objPrjTabENEx.TabName + "\",values);");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == == ;
            return strBuilder.ToString();
        }
        public string gfunAddnewMultiRec()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///添加多条新记录---------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 把多条记录同时插入到表中!");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"oDT\"></param>");
            strBuilder.Append("\r\n/// <param name = \"strResult\"></param>");
            strBuilder.Append("\r\n/// <returns></returns>");
            strTemp = string.Format("public boolean Addnew{0}s(ResultSet oDT, string strResult) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nif (mintErrNo != 0) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrResult = \"错误号为:\" + mintErrNo.ToString();");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where " + objKeyField.FldName + " = '111'\";",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n//检查关键字的唯一性");
            ///如果该表的关键不是顺序递增型;
            if (objKeyField.ObjFieldTabENEx.IsIdentity == false)
            {
                if (objPrjTabENEx.arrKeyFldSet.Count == 0)
                {
                    strBuilder.Append("\r\n//你的表" + objPrjTabENEx.TabName + " 中没有关键字,请你设置一个关键字!");

                    /// MsgBox("你的表中没有关键字");
                }
                else
                {
                    strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
                    strBuilder.Append("\r\n{");
                    string strTT;
                    strTT = string.Format("oRow[\"{0}\"].toString().Trim()", objKeyField.FldName);
                    strTemp = string.Format("{0} {1} = " + AccessNull(strTT, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.IsTabNullable) + ";",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.PrivFuncName);
                    strBuilder.Append("\r\n" + strTemp);

                    strBuilder.Append("\r\nif (IsExist(" + objKeyField.PrivFuncName + "))");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nstrResult = \"关键字" + objKeyField.FldName + "为:\" + " + objKeyField.PrivFuncName + " + \"的记录已存在,不能重复插入!\" ;");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n//把多条记录插入到表中");
            strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].NewRow();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                }
                else
                {
                    strBuilder.Append("\r\nobjRow[\"" + objField.ObjFieldTabENEx.FldName + "\"] = oRow[\"" + objField.ObjFieldTabENEx.FldName + "\"].toString().Trim();");
                }
            }
            strBuilder.Append("\r\nobjDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows.Add(objRow);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA.Update(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch(Exception objException) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            
            
            
            
            strBuilder.Append("\r\nobjSQL.SQLConnect.Close();");
            
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///添加多条新记录 == == == = ;
            return strBuilder.ToString();
        }
        public string gfunUpdate()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n public int Update()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\n strSQL = \"update {0} set \";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //if (bolIsFirst == true)
                //{
                // bolIsFirst = false;
                // strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";", objField.ObjFieldTabENEx.FldName);
                //}
                //else
                //{
                // strBuilder.AppendFormat("\r\n strSQL += \", {0} = ? \";", objField.ObjFieldTabENEx.FldName);
                //}
                strBuilder.AppendFormat("\r\n //{0}",
                objField.ColCaption);

                if (objField.FieldTypeId != enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?, \";",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\n strSQL = strSQL.substring(0, strSQL.length()-2);");
            strBuilder.AppendFormat("strSQL += \" where {0} = ?\";", objKeyField.FldName);


            strBuilder.Append("\r\n PreparedStatement objPS = objSQL.getPreparedStmt(strSQL);");
            strBuilder.Append("\r\n // PreparedStatement objPS = objSQL.getCallableStmt(strSQL);");
            strBuilder.Append("\r\n //初始化参数");
            strBuilder.Append("\r\n objPS.clearParameters();");
            strBuilder.Append("\r\n int intFieldNo = 1;");

            //int intFieldNo = 1;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");

                    strTemp = objField.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    strBuilder.Append("\r\n objPS.set" + strTemp + "(intFieldNo++, objViewInfoENEx." + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java) + ");");
                    strBuilder.Append("\r\n }");
                }
                //strBuilder.Append("\r\n objPS.set" + strTemp + "(" + intFieldNo.ToString().Trim() + ", objViewInfoENEx." + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName) + ");");
            }
            //strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            //clsString.FstUcase_S(ref strTemp);
            //strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
            // strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.FldName));
            //intFieldNo += 1;

            strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.AppendFormat("\r\n objPS.set{0}(intFieldNo++, objViewInfoENEx.{1}); ",
            strTemp, clsString.FstLcaseS(objKeyField.FldName_Java));

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
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public string gfunUpdate_neusoft()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n public int Update_neusoft()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, OPException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n boolean bolIsFirst = true;");
            strBuilder.Append("\r\n ArrayList paramList = new ArrayList();");
            strBuilder.AppendFormat("\r\n strSQL = \"update {0} set \";", objPrjTabENEx.TabName, objPrjTabENEx.TabSpace);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");
                    strBuilder.Append("\r\n if (bolIsFirst == true)");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n bolIsFirst = false;");
                    strBuilder.Append("\r\n }");
                    strBuilder.Append("\r\n else");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \", {0} = ?\";",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n }");
                    strBuilder.AppendFormat("\r\n paramList.add({0});",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                    strBuilder.Append("\r\n }");

                    //					if (bolIsFirst == true)
                    //					{
                    //						bolIsFirst = false;
                    //						strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";", objField.ObjFieldTabENEx.FldName);
                    //					}
                    //					else
                    //					{
                    //						strBuilder.AppendFormat("\r\n strSQL += \", {0} = ? \";", objField.ObjFieldTabENEx.FldName);
                    //					}
                }
            }
            strBuilder.AppendFormat("\r\n strSQL += \" where {0} = ?\";", objKeyField.FldName);

           
            strBuilder.AppendFormat("\r\n paramList.add({0});",
            clsString.FstLcaseS(objKeyField.FldName));

            strBuilder.Append("\r\n Object[] params = new Object[paramList.size()];");
            strBuilder.Append("\r\n paramList.toArray(params);");
            strBuilder.Append("\r\n int iResult = pm.executeUpdate(strSQL, params);");
            strBuilder.Append("\r\n return iResult;");

            strBuilder.Append("\r\n }");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }
        public string gfunUpdateBatch_neusoft()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n public int[] UpdateBatch_neusoft(List lstKey, String strCondition)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, OPException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n boolean bolIsFirst = true;");
            strBuilder.Append("\r\n int[] rows;");

            strBuilder.AppendFormat("\r\n strSQL = \"update {0} set \";", objPrjTabENEx.TabName, objPrjTabENEx.TabSpace);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");
                    strBuilder.Append("\r\n if (bolIsFirst == true)");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \"{0} = {1}\";",
                    objField.ObjFieldTabENEx.FldName,
                    getValueStr(objField));
                    strBuilder.Append("\r\n bolIsFirst = false;");
                    strBuilder.Append("\r\n }");
                    strBuilder.Append("\r\n else");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \", {0} = {1}\";",
                    objField.ObjFieldTabENEx.FldName,
                    getValueStr(objField));
                    strBuilder.Append("\r\n }");
                    strBuilder.Append("\r\n }");

                    //					if (bolIsFirst == true)
                    //					{
                    //						bolIsFirst = false;
                    //						strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";", objField.ObjFieldTabENEx.FldName);
                    //					}
                    //					else
                    //					{
                    //						strBuilder.AppendFormat("\r\n strSQL += \", {0} = ? \";", objField.ObjFieldTabENEx.FldName);
                    //					}
                }
            }


            strBuilder.Append("\r\n if (strCondition == \"\")");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL += \" where {0} = ?\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL += \" where \" + strCondition + \" and {0} = ?\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\n rows = pm.executeUpdateBatch(strSQL, lstKey);");
            strBuilder.Append("\r\n return rows;");

            strBuilder.Append("\r\n }");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public string gfunUpdateMultiRec()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///按条件修改多条记录------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:修改多条记录");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\"></param>");
            strBuilder.Append("\r\n/// <returns></returns>");
            strBuilder.Append("\r\npublic int UpdateMultiRec(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB ;");
            strBuilder.Append("\r\n//			System.Data.DataRow objRow ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount;");
            strBuilder.Append("\r\nif (strCondition == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0; //表示删除0条记录,实际上是不能该表的所有记录");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where \" + strCondition;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nif (objDS.Tables[\"{0}\"].Rows.Count == 0)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nintRecCount = objDS.Tables[\"{0}\"].Rows.Count;",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nforeach(System.Data.DataRow objRow in objDS.Tables[\"{0}\"].Rows)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if ((objField.ObjFieldTabENEx.IsIdentity == false) && (objField.FieldTypeId != enumFieldType.KeyField_02))
                {
                    strBuilder.AppendFormat("\r\nobjRow[\"{0}\"] = {1};",
                    objField.ObjFieldTabENEx.FldName, clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjDA.Update(objDS, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            
            
            
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///按条件修改多条记录 == = ;
            return strBuilder.ToString();
        }
        public string gGetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取表中的记录数---------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:获取当前表的记录数.该表与当前类相关。");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic int GetRecCount()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(CurrTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:获取当前表的记录数.该表与当前类相关。");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n/// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:获取当前表中满足条件的记录数");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondtion\">所给定的记录条件</param>");
            strBuilder.Append("\r\n/// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.GetRecCountByCond(string strCondtion)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(CurrTabName, strCondtion);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gGetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:获取给定表中满足条件的记录数");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondtion\">所给定的记录条件</param>");
            strBuilder.Append("\r\n/// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.GetRecCountByCond(string strTabName, string strCondtion)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName, strCondtion);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 == == == ;
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4String()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///设置/获取表中的符合条件的某字段的值------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n/// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n/// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.SetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, strValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
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
            objPrjTabENEx.TabName);
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
            objPrjTabENEx.TabName);
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
            objPrjTabENEx.TabName);
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
        
        public string gfunStoreFileToTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:存储文件。把文件存储到数据库表字段中。");
            strBuilder.Append("\r\n///		说明:表记录条件为当前对象所对应的记录。");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strUpLoadFileName\">所要存储的文件名</param>");
            strBuilder.Append("\r\n/// <returns>如果成功就返回TRUE,否则返回FALSE</returns>");
            strBuilder.Append("\r\npublic boolean StoreFileToTabField(string strUpLoadFileName)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", mstrImageFieldName);
            strBuilder.Append("\r\nStringBuffer strCondition = new StringBuffer();");
            strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
            strBuilder.AppendFormat("{0}", objKeyField.FldName);
            strBuilder.Append(" = '{0}'\", ");
            strBuilder.AppendFormat("{0});", clsString.FstLcaseS(objKeyField.FldName));
            strBuilder.Append("\r\nSpecData.clsSpecSQL objSQL = new SpecData.clsSpecSQL();");
            strBuilder.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.toString());");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunShowPic_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:显示图片。显示与关键字相关记录的图片");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"imgPic\">需要显示图片的image控件</param>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">记录关键字的值</param>",
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n/// <param name = \"strWebFileDir\">用于WEB显示的文件路径,即URL</param>");
            strBuilder.Append("\r\n/// <param name = \"strDownloadFileDir\">用于下载文件时,在WEB服务器上文件的目录</param>");
            strBuilder.Append("\r\npublic static void ShowPic(System.Web.UI.WebControls.Image imgPic, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\nstring strWebFileDir, ");
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nimgPic.ImageUrl = \"\";");
            strBuilder.AppendFormat("\r\nif (cls{0}.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0} obj{0} = new cls{0}({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}.FileName;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}.GetFileFromTabField(strDownLoadFileName);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nimgPic.ImageUrl = strWebFileDir + strFileName;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetFileFromTabField_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:从数据库表字段中下载文件内容。该函数是静态(static)函数。");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strDownLoadFileName\">返回下载的文件名</param>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">记录关键字的值</param>",
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n/// <param name = \"strDownloadFileDir\">用于下载文件时,在WEB服务器上文件的目录</param>");
            strBuilder.Append("\r\npublic static boolean GetFileFromTabField(string strDownLoadFileName, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nif (cls{0}.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0} obj{0} = new cls{0}({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}.FileName;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}.GetFileFromTabField(strDownLoadFileName);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///上传文件以及下载文件相关代码 == == == ;
            return strBuilder.ToString();
        }
        public string gGetDataTable_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一SQL串的DataTable---------------------------;
            strBuilder.Append("\r\npublic static ResultSet GetResultSet(string strSql)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nResultSet objRS; ");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nobjRS = objSQL.GetResultSet(strSql);");
            strBuilder.Append("\r\nreturn objRS;");
            strBuilder.Append("\r\n}");
            ///获取某一SQL串的DataTable == == ;
            return strBuilder.ToString();
        }
        public string gfunIsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strBuilder.Append("\r\n public boolean IsExist()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr() + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///在数据库中是否存在当前对象 == == ;
            return strBuilder.ToString();
        }
        public string gfunIsExist_S()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象(共享过程函数)-----------------------;
            ///objField.ObjFieldTabENEx.PrivFuncName;
            int i = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                if (i == 0)    //是否是第一次
                {
                    strTemp = objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else
                {
                    strTemp += ", " + objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                i++;
            }
            strBuilder.Append("\r\npublic static boolean IsExist(" + strTemp + ")");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr(false, objPrjTabENEx) + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///在数据库中是否存在当前对象(共享过程函数) == == ;
            return strBuilder.ToString();
        }
        public string gfunIsExistCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 功能:判断是否存在某一条件的记录");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n/// <returns>如果存在就返回TRUE,否则返回FALSE</returns>");
            strBuilder.Append("\r\npublic static boolean IsExistCondRec(string strCondition)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", strCondition))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunCheckProperty()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\npublic boolean CheckProperty(String strResult)");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    if (objField.JavaType != "int" && objField.JavaType != "boolean")
                    {
                        strBuilder.AppendFormat("\r\n if ((null == {0}) || (null != {0}) && ({0}.toString() == \"\")",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java));
                        if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                        {
                            strBuilder.AppendFormat("\r\n || (null != {0}) && ({0}.toString() == \"0\")",
                            clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java));
                        }
                        strBuilder.Append(")");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\nstrResult = \"字段[" + objField.ColCaption + "]不能为空(NULL)!\";");
                        strBuilder.Append("\r\nreturn false;");
                        strBuilder.Append("\r\n}");
                    }
                }
            }
            ///检查属性长度代码;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType == "String" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\nif ((null != {0}) && (GetStrLen({0}) > {1})",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java), objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n strResult = \"字段[{0}]的长度不能超过{1}!\";",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n return false;");
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///检查类中属性是否正确 == == == = ;
            return strBuilder.ToString();
        }

        public string gfunCheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\npublic void CheckProperty() throws dbobjexception ");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType != "Integer"
                    && objField.JavaType != "boolean"
                    && objField.JavaType != "float"
                    && objField.JavaType != "double"
                    && objField.JavaType != "long")
                    {
                        strBuilder.AppendFormat("\r\n if ((null == {0}) || (null != {0}) && ({0}.toString() == \"\")",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java));
                        if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                        {
                            strBuilder.AppendFormat("\r\n || (null != {0}) && ({0}.toString() == \"0\")",
                            clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java));
                        }
                        strBuilder.Append(")");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n throw new dbobjexception(\"字段[" + objField.ColCaption + "]不能为空(NULL)!\");");
                        strBuilder.Append("\r\n}");
                    }
                }
            }
            ///检查属性长度代码;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                && objField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType == "String"
                && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\nif ((null != {0}) && (GetStrLen({0}) > {1})",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java), objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new dbobjexception(\"字段[{0}]的长度不能超过{1}!\");",
                    objField.ColCaption,
                    objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\n}");
            ///检查类中属性是否正确 == == == = ;
            return strBuilder.ToString();
        }

        public string gGetID()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n public ArrayList GetID(String strCondtion) ");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS = null ;");
            strBuilder.Append("\r\n ArrayList<String> arrList = new ArrayList<String> ();");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n int iCol; ");
            strBuilder.Append("\r\n String strKeyValue; ");
            // strBuilder.AppendFormat("\r\n if (objSQL.IsExistRecord(\"{0}\", \"{1}))",
            //				objPrjTabENEx.TabName, KeyWhereStr(true));
            // strBuilder.Append("\r\n return arrList;");
            strBuilder.AppendFormat("\r\n strSQL = \"Select {0} from {1} where \" + strCondtion;",
            objKeyField.FldName, objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n ResultSetMetaData metaData = objRS.getMetaData();");
            strBuilder.Append("\r\n int intColumns = metaData.getColumnCount(); //用来存放结果集的列数 ");
            strBuilder.Append("\r\n int intRsCount = objSQL.GetCount(objRS);//用来存放当结果集的记录数");
            strBuilder.Append("\r\n if (intRsCount == 0)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n return null;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n while(objRS.next())");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n strKeyValue = \"\";");
            strBuilder.Append("\r\n for (iCol = 0; iCol<= intColumns - 1;iCol++)");
            strBuilder.Append("\r\n {");
            strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.Append("\r\n if (iCol == 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strKeyValue += String.valueOf(objRS.get" + strTemp + "(\"{0}\"));",
            objKeyField.FldName_Java);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strKeyValue += \"//\" + String.valueOf(objRS.get" + strTemp + "(\"{0}\"));",
            objKeyField.FldName_Java);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n arrList.add(strKeyValue);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw objException;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return arrList;");
            strBuilder.Append("\r\n }");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string gGetFirstID()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.AppendFormat("\r\n public {0} GetFirstID(String strCondtion) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.AppendFormat("\r\n {0} {1}KeyValue; ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.AppendFormat("\r\n strSQL = \"Select " + objPrjTabENEx.Keys + " from {0} where \" + strCondtion;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS.next()) ");
            strBuilder.Append("\r\n {");
            strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.AppendFormat("\r\n {2}KeyValue = objRS.get{0}(\"{1}\");",
            strTemp,
            objKeyField.FldName_Java,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType)
            {
                case "Integer":
                    strBuilder.Append("\r\n" + "return 0;");
                    break;
                case "Double":
                    strBuilder.Append("\r\n" + "return 0.0;");
                    break;
                case "Date":
                    strBuilder.Append("\r\n" + "return Date.Parse(strKeyValue);");
                    break;
                case "Boolean":
                    strBuilder.Append("\r\n" + "return Boolean.ParseBoolean(strKeyValue);");
                    break;
                case "Float":
                    strBuilder.Append("\r\n" + "return 0.0f;");
                    break;
                case "Long":
                    strBuilder.Append("\r\n" + "return 0l;");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return \"\";");
                    break;
            }

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n System.out.println(objException.getMessage());");
            strBuilder.Append("\r\n throw objException;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\n return {0}KeyValue;",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n ");

            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string gGetFirstID_S()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(String strCondtion) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.AppendFormat("\r\n {0} {1}KeyValue; ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.AppendFormat("\r\n strSQL = \"Select " + objPrjTabENEx.Keys + " from {0} where \" + strCondtion;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS.next()) ");
            strBuilder.Append("\r\n {");
            strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.AppendFormat("\r\n {2}KeyValue = objRS.get{0}(\"{1}\");",
            strTemp,
            objKeyField.FldName_Java,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType)
            {
                case "Integer":
                    strBuilder.Append("\r\n" + "return 0;");
                    break;
                case "Double":
                    strBuilder.Append("\r\n" + "return 0.0;");
                    break;
                case "Date":
                    strBuilder.Append("\r\n" + "return Date.Parse(strKeyValue);");
                    break;
                case "Boolean":
                    strBuilder.Append("\r\n" + "return Boolean.ParseBoolean(strKeyValue);");
                    break;
                case "Float":
                    strBuilder.Append("\r\n" + "return 0.0f;");
                    break;
                case "Long":
                    strBuilder.Append("\r\n" + "return 0l;");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return \"\";");
                    break;
            }

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n System.out.println(objException.getMessage());");
            strBuilder.Append("\r\n throw objException;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\n return {0}KeyValue;",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n ");

            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }


        public string gGetReader()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic System.Data.SqlClient.SqlDataReader GetReader(string strCondtion) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataReader objDR ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n" + string.Format("strSQL = \"Select * from {0} where \" + strCondtion;", objPrjTabENEx.TabName));
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDR = objSQL.GetSqlDataReader(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            /// strBuilder.Append("\r\nobjDR = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDR;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gGetTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTable(根据条件获取数据表);

            strBuilder.Append("\r\n public ResultSet GetResultSet(String strCondtion, String strResult)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n strSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondtion;");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL, strResult);");
            strBuilder.Append("\r\n return objRS;");
            strBuilder.Append("\r\n }");

            //'GetTable(根据条件获取数据表)
            strBuilder.Append("\r\n public static ResultSet GetResultSet1(String strCondtion, String strResult)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n strSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondtion;");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL, strResult);");
            strBuilder.Append("\r\n return objRS;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }


        public string gGetTableBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTableBySQL(根据SQL语句获取数据表)----------------------------------;
            strBuilder.Append("\r\npublic ResultSet GetResultSetBySQL(String strSQL, String strResult) ");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nResultSet objRS ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nobjRS = objSQL.GetResultSet(strSQL, strResult);");
            strBuilder.Append("\r\nreturn objRS;");
            strBuilder.Append("\r\n}");
            ///GetTableBySQL(根据SQL语句获取数据表) == == == ;
            return strBuilder.ToString();
        }

        public string gfungetStrLen()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取字符串长度,其中汉字为2个字节,英文为1个字节---------;
            strBuilder.Append("\r\npublic int GetStrLen(String strTemp)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nint len ;");
            strBuilder.Append("\r\n//byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);");
            strBuilder.Append("\r\nlen = strTemp.getBytes().length;//will output as 3+3*2 = 9");
            strBuilder.Append("\r\nreturn len;");
            strBuilder.Append("\r\n}");
            ///获取字符串长度,其中汉字为2个字节,英文为1个;
            ///私有函数 == == == ;
            return strBuilder.ToString();
        }
        public string gfunDispose()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///类中析构函数---------------------------------------;
            strBuilder.Append("\r\n public void Dispose()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (mblnDisposed == false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Free up the database connection resource by ");
            strBuilder.Append("\r\n //calling its Dispose method");
            strBuilder.Append("\r\n //mobjConnection.Dispose()");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Because this Dispose method has done the necessary cleanup,");
            strBuilder.Append("\r\n //prevent the Finalize method from being called.");
            strBuilder.Append("\r\n GC.SuppressFinalize(this);");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Let our class know that Dispose() has been called");
            strBuilder.Append("\r\n mblnDisposed = true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            ///类中析构函数 == == == ;
            return strBuilder.ToString();
        }
        public string gfunLogError()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取字符串长度,其中汉字为2个字节,英文为1个字节 == ;
            ///错误日志;
            strBuilder.Append("\r\ninternal void LogError" + "(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n //Log the error information to the Application Log");
            strBuilder.Append("\r\n string strLogMsg ;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strBuilder.Append("\r\n+ objViewInfoENEx.ModuleName + \"Source: \" + objException.Source \r\n");
            strBuilder.Append("\r\n+ \"Message: \" + objException.Message ");
            strBuilder.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strBuilder.Append("\r\n+ \"Target Site: \" + objException.TargetSite.toString();");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Write error to event log");
            strBuilder.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(objViewInfoENEx.ModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }

      
        public string gGetTabDict()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///删除一条记录-----------------;
            ///
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            ///生成仅有变量;
            //绑定下拉框的函数 代码;
            //第0步:把控件中下拉框ComboBox转换成ComboBox
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")//主键字段
                {
                    strValueFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")//名称字段
                {
                    strTextFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            strBuilder.AppendFormat("\r\n public ArrayList<cls{0}> get{0}Dict() throws Exception ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n 		{");
            strBuilder.AppendFormat("\r\nArrayList<cls{0}> arrObjLst = new ArrayList<cls{0}>(); ",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.AppendFormat("\r\n strSQL = \"select {0}, {1} from {2} \";",
            strValueFieldName,
            strTextFieldName,
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n clsSpecSQL objSQL = null;");
            strBuilder.Append("\r\n try ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQL();");

            strBuilder.Append("\r\n objRS = GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS == null) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new RuntimeException(\"objRS 对象为null\");");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n while(objRS.next())");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n	cls{0} obj{0} = new cls{0}();",
            objPrjTabENEx.TabName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.FldName == strValueFieldName ||
                objField.ObjFieldTabENEx.FldName == strTextFieldName)
                {
                    strTemp = objField.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    //if (strTemp == "Int" || strTemp == "Double" || strTemp == "Long")
                    //{
                    // strBuilder.AppendFormat("\r\n {4} {0}{1} = objRS.get{2}(\"{3}\");",
                    // objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName), 
                    // strTemp, 
                    // objField.ObjFieldTabENEx.FldName,
                    // objField.JavaType);
                    // strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(new {2}({3}{4}));",
                    // objPrjTabENEx.TabName, 
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName),
                    // objField.JavaType,
                    // objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName));
                    //}
                    //else
                    //{
                    strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(objRS.get{2}(\"{3}\"));",
                    objPrjTabENEx.TabName,
                    clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName_Java),
                    strTemp,
                    objField.ObjFieldTabENEx.FldName);
                }
                //}

            }
            strBuilder.AppendFormat("\r\n	arrObjLst.add(obj{0});",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException ex) ");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new SQLException(String.format(\"表（{0}）没有记录!\\r\\n\") + ex.getMessage());",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }


        public string gGetTabDictWithCond()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///删除一条记录-----------------;
            ///
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            ///生成仅有变量;
            //绑定下拉框的函数 代码;
            //第0步:把控件中下拉框ComboBox转换成ComboBox
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            strBuilder.AppendFormat("\r\n ArrayList<cls{0}> get{0}Dict(String strWhere) throws Exception ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n 		{");
            strBuilder.AppendFormat("\r\nArrayList<cls{0}> arrObjLst = new ArrayList<cls{0}>(); ",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.AppendFormat("\r\n strSQL = \"select {0}, {1} from {2} Where \" + strWhere;",
            strValueFieldName,
            strTextFieldName,
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n clsSpecSQL objSQL = null;");
            strBuilder.Append("\r\n try ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQL();");

            strBuilder.Append("\r\n objRS = GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS == null) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new RuntimeException(\"objRS 对象为null\");");
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\n while(objRS.next())");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n	cls{0} obj{0} = new cls{0}();",
            objPrjTabENEx.TabName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.FldName == strValueFieldName ||
                objField.ObjFieldTabENEx.FldName == strTextFieldName)
                {
                    strTemp = objField.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    //if (strTemp == "Int" || strTemp == "Double" || strTemp == "Long")
                    //{
                    // strBuilder.AppendFormat("\r\n {4} {0}{1} = objRS.get{2}(\"{3}\");",
                    // objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName), 
                    // strTemp, 
                    // objField.ObjFieldTabENEx.FldName,
                    // objField.JavaType);
                    // strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(new {2}({3}{4}));",
                    // objPrjTabENEx.TabName, 
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName),
                    // objField.JavaType,
                    // objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName));
                    //}
                    //else
                    //{
                    strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(objRS.get{2}(\"{3}\"));",
                    objPrjTabENEx.TabName,
                    clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName_Java),
                    strTemp,
                    objField.ObjFieldTabENEx.FldName);
                }
                //}

            }
            strBuilder.AppendFormat("\r\n	arrObjLst.add(obj{0});",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException ex) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new SQLException(String.format(\"条件为:'{0}'记录不存在!\\r\\n\", strWhere) + ex.getMessage());");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        
        /// <summary>
        /// 生成Entity层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                               objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                      objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;
           
            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "EN_Sim";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));
                strCodeForCs.Append("\r\n" + "import Foundation"); //

              
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                              strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                            
                strCodeForCs.AppendFormat("\r\n" + "public class  {0}: Codable ", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

              
                strCodeForCs.Append("\r\n" + "//以下是属性变量");

                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                             clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                             objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

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
                strCodeForCs.Append("\r\n" + "}");       

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
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
                Type t = typeof(EntityLayer_Sim4Swift4);
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
            this.ClsName = string.Format("cls{0}EN", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
