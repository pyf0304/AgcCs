using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.sql;



using AGC.Entity;

using AGC.BusinessLogic;
using AgcCommBase;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
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
    class DALExCode4CSharp : clsGeneCodeBase4Tab
    {


        #region 构造函数

        public DALExCode4CSharp(string strTabId,  string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion


     
        /// <summary>
        /// 为字段设置条件字段值
        /// </summary>
        /// <returns></returns>
        public override string GenSetCondFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();



            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //获取某一条件值的记录集-----------------------------;
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 根据条件获取对象列表-{0}[{1}]", objField.ObjFieldTabENEx.FldCnName, objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">字段条件值</param>", objField.ObjFieldTabENEx.PrivPropName);
                strBuilder.Append("\r\n /// <param name = \"strComparisonOp\">比较运算符</param>");
                strBuilder.Append("\r\n /// <returns>void</returns>");
                strBuilder.AppendFormat("\r\npublic void SetCond_{0}({1} {2}, string strComparisonOp)",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n" + "this.{0} = {1};", objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.PrivFuncName);
                strBuilder.AppendFormat("\r\n" + "if (dicFldComparisonOp.ContainsKey(con{0}) == false)", objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp.Add(con{0}, strComparisonOp);", objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp[con{0}] = strComparisonOp;", objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n}");

            }

            //获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

      
      
        /// <summary>
        /// 生成DAL(数据处理层)代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
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

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "DAEx";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.DataAccessLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
                objProject.PrjDomain); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.DAL",
                objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : cls{1}DA", 
                    objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                             

                //生成所有的函数
                
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
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
        /// <summary>
        /// 生成构造函数1
        /// </summary>
        /// <returns></returns>
        public string Gen_DAEx_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 构造函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

      

        public string A_GenSQLCode4CreateTab(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
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
            string strFldPrecision;
            ArrayList arrFieldCodes = new ArrayList();

            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {
                //				strBuilder.Append("\r\n" +clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));

                ///计算字段名
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///计算字段类型
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///计算字段长度
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                strFldPrecision = objField.ObjFieldTabENEx.FldPrecision.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else if (strFieldType == "decimal" || strFieldType == "numeric")
                {
                    strFieldLength = string.Format("({0},{1})", strFieldLength0, strFldPrecision);
                }
                else
                {
                    strFieldLength = "(" + strFieldLength0 + ")";
                }
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
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                    if (strFieldType == "bigint identity")
                    {
                        strFieldType = "bigint";
                    }
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
        public override string Gen_GetSpecSQLObj()
        {
            //return "";
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取SQL服务器连接对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");

            strBuilder.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
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
                Type t = typeof(DALExCode4CSharp);
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
            this.ClsName = string.Format("cls{0}DAEx", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
