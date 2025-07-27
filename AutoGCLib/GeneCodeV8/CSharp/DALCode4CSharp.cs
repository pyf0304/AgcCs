using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
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
    class DALCode4CSharp : clsGeneCodeBase4Tab
    {


        #region 构造函数

        public DALCode4CSharp(string strTabId,  string strPrjDataBaseId, string strPrjId)
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
                strBuilder.AppendFormat("\r\n" + "if (dicFldComparisonOp.ContainsKey(con{0}.{1}) == false)", objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp.Add(con{0}.{1}, strComparisonOp);", objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp[con{0}.{1}] = strComparisonOp;", objField.ObjFieldTabENEx.FldName);
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
clsvFunction4GeneCodeBLEx.GetObjLstByPrjTabEx(objPrjTabENEx, this.CmPrjId);

            //          IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst = null;

            //          IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sub1 =
            //                          clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
            //                          objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
            //              .OrderBy(x => x.OrderNum);

            //          //添加与表-功能相关的函数
            //          IEnumerable<string> arrFeatureId = objPrjTabENEx.arrTabFeatureSet().Select(x => x.FeatureId);
            //          IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeatureCache
            //= clsvFunction4GeneCodeBLEx.GetObjLst4FeatureIdLst(arrFeatureId);
            //          IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeature = null;
            //          if (arrvFunction4GeneCodeObjLst4TabFeatureCache != null)
            //          {
            //              arrvFunction4GeneCodeObjLst4TabFeature = arrvFunction4GeneCodeObjLst4TabFeatureCache.
            //                  Where(x => x.CodeTypeId == objPrjTabENEx.CodeTypeId);
            //          }

            //          if (arrvFunction4GeneCodeObjLst4TabFeature !=null && arrvFunction4GeneCodeObjLst4TabFeature.Count() > 0)
            //          {

            //              arrvFunction4GeneCodeObjLst = arrvFunction4GeneCodeObjLst_Sub1.Union(arrvFunction4GeneCodeObjLst4TabFeature, new VFunction4GeneCodeComparer());
            //          }
            //          else
            //          {
            //              arrvFunction4GeneCodeObjLst = arrvFunction4GeneCodeObjLst_Sub1;
            //          }
            //          int intCount4 = arrvFunction4GeneCodeObjLst.Count();

            //          arrvFunction4GeneCodeObjLst = arrvFunction4GeneCodeObjLst.OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "DA";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.DataAccessLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objPrjTabENEx);

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
                //strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");                
                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
                strCodeForCs.Append("\r\n" + "using PrjCommBase;"); //
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

                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : clsCommBase4DA", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 错误信息");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected const string EXCEPTION_MSG = \"出错:\"; //there was an error in the method. please see the Application Log for details.\";");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 模块名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string mstrModuleName;");


                strCodeForCs.Append("\r\n" + "//以下是属性变量");


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
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"请初始化用于记录日志的clsSysParaEN.objLog对象!\");");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objErrorLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!\");");
            strBuilder.Append("\r\n" + "}");

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
                Type t = typeof(DALCode4CSharp);
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
            this.ClsName = string.Format("cls{0}DA", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public virtual string GenAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///公共过程--------------------------------------;
            ///添加新记录----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>添加是否成功?</returns>");

            strBuilder.AppendFormat("\r\n public bool AddNewRecord(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);

                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB ; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            /// Dim objSQL As new IKData.SQLServer();
            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where 1 = 2\";");
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.Append("\r\nobjDA.Fill(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].NewRow();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.FldOpTypeId == "0003") //只写
                {
                    if (objField.IsTabNullable == true && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", strPrivPropNameWithObjectName);
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\nobjRow[\"{1}\"] = {2}; //{0}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName);
                        strBuilder.Append("\r\n }");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nobjRow[\"{1}\"] = {2}; //{0}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName);
                    }

                    continue;
                }
                if (objField.IsTabNullable == true && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                {
                    strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", strPrivPropNameWithObjectName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\nobjRow[con{1}.{2}] = {3}; //{0}",
                        objField.ColCaption,
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName);
                    strBuilder.Append("\r\n }");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nobjRow[con{1}.{2}] = {3}; //{0}",
                        objField.ColCaption,
                          objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName);
                }
            }
            strBuilder.AppendFormat("\r\nobjDS.Tables[cls{0}EN._CurrTabName].Rows.Add(objRow);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjDA.Update(objDS, cls{0}EN._CurrTabName);",
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
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}" + "\r\n");
            ///添加新记录 == = ;
            return strBuilder.ToString();
        }
        public virtual string GenAddNewRecordBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objPrjTabENEx.Stdid, objPrjTabENEx.FileName);");
            StringBuilder strFieldLst = new StringBuilder();
            StringBuilder strValueLsd = new StringBuilder();
            string strParaIndex = "";
            bool bolIsFirst = true;
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.FldOpTypeId == "0003") //只写
                {
                    if (bolIsFirst == true)
                    {
                        strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                        {
                            strValueLsd.AppendFormat(" {0} == true?\"1\":\"0\"", strPrivPropNameWithObjectName4Get);
                        }
                        else
                        {
                            strValueLsd.AppendFormat(" {0}", strPrivPropNameWithObjectName4Get);
                        }
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                        {
                            strParaIndex = "'{" + intIndex.ToString() + "}'";
                        }
                        else
                        {
                            strParaIndex = "{" + intIndex.ToString() + "}";
                        }
                        bolIsFirst = false;
                    }
                    else
                    {
                        strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                        {
                            strValueLsd.AppendFormat(", {0} == true?\"1\":\"0\"", strPrivPropNameWithObjectName4Get);
                        }
                        else
                        {
                            strValueLsd.AppendFormat(", {0}", strPrivPropNameWithObjectName4Get);
                        }
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                        {
                            strParaIndex += ", '{" + intIndex.ToString() + "}'";
                        }
                        else
                        {
                            strParaIndex += ", {" + intIndex.ToString() + "}";
                        }
                    }
                    continue;
                }
                if (bolIsFirst == true)
                {
                    strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                    {
                        strValueLsd.AppendFormat(" {0} == true?\"1\":\"0\"", strPrivPropNameWithObjectName);
                    }
                    else
                    {
                        strValueLsd.AppendFormat(" {0}", strPrivPropNameWithObjectName);
                    }
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                    {
                        strParaIndex = "'{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex = "{" + intIndex.ToString() + "}";
                    }
                    bolIsFirst = false;
                }
                else
                {
                    strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                    {
                        strValueLsd.AppendFormat(", {0} == true?\"1\":\"0\"", strPrivPropNameWithObjectName);
                    }
                    else
                    {
                        strValueLsd.AppendFormat(", {0}", strPrivPropNameWithObjectName);
                    }
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                    {
                        strParaIndex += ", '{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex += ", {" + intIndex.ToString() + "}";
                    }
                }
                intIndex = intIndex + 1;

            }
            strBuilder.AppendFormat("\r\nstrSQL.AppendFormat(\"insert into {3} ({0}) values ({1})\", {2});", strFieldLst.ToString(), strParaIndex, strValueLsd.ToString(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public virtual string GenAddNewRecordBySQL2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }

            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //需要插入表的字段列表");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //需要插入表的值列表");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInAddNewRecordBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);
            }

            strBuilder.Append("\r\n //组织插入记录SQL串");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({{0}}) values ({{1}}) \", strFieldListCode, strValuesListCode);",
            "{", "}");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());");


            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }
        public virtual string GenAddNewRecordBySQL2WithReturnKey()
        {
            List<string> arrKey = new List<string>() { enumPrimaryType.Identity_02, enumPrimaryType.StringAutoAddPrimaryKey_03,
                enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06, enumPrimaryType.PrimaryKey_01 };
            if (arrKey.Contains(objKeyField.PrimaryTypeId) == false) return "";

            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\npublic string AddNewRecordBySQL2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //需要插入表的字段列表");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //需要插入表的值列表");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInAddNewRecordBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }

            strBuilder.Append("\r\n //组织插入记录SQL串");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({{0}}) values ({{1}}); \", strFieldListCode, strValuesListCode);",
            "{", "}");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());");

            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\n strSQL.Append(\" select @@identity;\");");
            }
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();");
            }
            else
            {
                strBuilder.Append("\r\n objSQL.ExecSql(strSQL.ToString());");
                strBuilder.AppendFormat("\r\nreturn obj{0}EN.{1};", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }


        public virtual string GenAddNewRecordBySQL2WithReturnKeyAndTransaction()
        {

            List<string> arrKey = new List<string>() { enumPrimaryType.Identity_02, enumPrimaryType.StringAutoAddPrimaryKey_03, enumPrimaryType.PrimaryKey_01 };
            if (arrKey.Contains(objKeyField.PrimaryTypeId) == false) return "";
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\npublic string AddNewRecordBySQL2WithReturnKey(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //需要插入表的字段列表");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //需要插入表的值列表");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInAddNewRecordBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }

            strBuilder.Append("\r\n //组织插入记录SQL串");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({{0}}) values ({{1}}); \", strFieldListCode, strValuesListCode);",
            "{", "}");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());");

            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\n strSQL.Append(\" select @@identity;\");");
            }
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();");

            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();");
            }
            else
            {
                strBuilder.Append("\r\n    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);");
                strBuilder.AppendFormat("\r\nreturn obj{0}EN.{1};", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public virtual string GenAddNewRecordBySQLWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录.(带事务处理)");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objPrjTabENEx.Stdid, objPrjTabENEx.FileName);");
            StringBuilder strFieldLst = new StringBuilder();
            StringBuilder strValueLsd = new StringBuilder();
            string strParaIndex = "";
            bool bolIsFirst = true;
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.FldOpTypeId == "0003") //只写
                {
                    if (bolIsFirst == true)
                    {
                        strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                        strValueLsd.AppendFormat("{0}", strPrivPropNameWithObjectName4Get);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strParaIndex = "'{" + intIndex.ToString() + "}'";
                        }
                        else
                        {
                            strParaIndex = "{" + intIndex.ToString() + "}";
                        }
                        bolIsFirst = false;
                    }
                    else
                    {
                        strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                        strValueLsd.AppendFormat(", {0}", strPrivPropNameWithObjectName4Get);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strParaIndex += ", '{" + intIndex.ToString() + "}'";
                        }
                        else
                        {
                            strParaIndex += ", {" + intIndex.ToString() + "}";
                        }

                    }

                    continue;
                }
                if (bolIsFirst == true)
                {
                    strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                    strValueLsd.AppendFormat("{0}", strPrivPropNameWithObjectName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strParaIndex = "'{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex = "{" + intIndex.ToString() + "}";
                    }
                    bolIsFirst = false;
                }
                else
                {
                    strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                    strValueLsd.AppendFormat(", {0}", strPrivPropNameWithObjectName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strParaIndex += ", '{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex += ", {" + intIndex.ToString() + "}";
                    }

                }
                intIndex = intIndex + 1;
            }

            strBuilder.AppendFormat("\r\nstrSQL.AppendFormat(\"insert into {3} ({0}) values ({1})\", {2});", strFieldLst.ToString(), strParaIndex, strValueLsd.ToString(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public virtual string GenAddNewRecordBySQLWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n StringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //需要插入表的字段列表");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //需要插入表的值列表");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInAddNewRecordBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }

            strBuilder.Append("\r\n //组织插入记录SQL串");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({{0}}) values ({{1}}) \", strFieldListCode, strValuesListCode);",
            "{", "}");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public virtual string GenAddnewRecBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            string strTemp = "";
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过存储过程来插入记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加到数据库中的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");

            strTemp = string.Format("public bool Addnew{0}BySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                intCount++;
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n{0},", strPrivPropNameWithObjectName4Get);
                    continue;
                }
                if (intCount == objPrjTabENEx.arrFldSet.Count)
                {
                    strBuilder.AppendFormat("\r\n{0}", strPrivPropNameWithObjectName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n {0},", strPrivPropNameWithObjectName);
                }
            }
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Add\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySP()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过存储过程(StoreProcedure)来修改记录");
            strBuilder.Append("\r\n /// /// 缺点:1、不能支持事务处理.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strTemp = string.Format("public bool UpdateBySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                intCount++;
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.FldOpTypeId == "0003")
                {
                    strBuilder.AppendFormat("\r\n {0},", strPrivPropNameWithObjectName4Get);
                    continue;
                }
                if (intCount == objPrjTabENEx.arrFldSet.Count)
                {
                    strBuilder.AppendFormat("\r\n {0}", strPrivPropNameWithObjectName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n {0},", strPrivPropNameWithObjectName);
                }
            }
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Update\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }



        public virtual string GenDelRecordBySP()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            strTemp = string.Format("public bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                intCount++;
                if (intCount == objPrjTabENEx.arrFldSet.Count)
                {
                    strBuilder.Append("\r\n " + objField.ObjFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strBuilder.Append("\r\n " + objField.ObjFieldTabENEx.PrivFuncName + ",");
                }
            }
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }
        public virtual string GenAddnewMultiRec()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///添加多条新记录---------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把多条记录同时插入到表中!");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"oDT\"></param>");
            //            strBuilder.Append("\r\n /// <param name = \"strResult\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strTemp = string.Format("public bool Addnew{0}s(System.Data.DataTable oDT) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + objKeyField.FldName + " = '111'\";");
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
                    foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
                    {
                        strTT = string.Format("oRow[con{1}.{0}].ToString().Trim()",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName);
                        strTemp = string.Format("{0} {1} = " + AccessNull(strTT, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable) + ";",
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.ObjFieldTabENEx.PrivFuncName);
                        strBuilder.Append("\r\n" + strTemp);
                    }
                    strBuilder.Append("\r\nif (IsExist(" + objPrjTabENEx.KeyPrivFuncFldNameLstStr + "))");
                    strBuilder.Append("\r\n{");
                    ArrayList arrKeyVarLst = new ArrayList();
                    ArrayList arrKeyValueLst = new ArrayList();
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
                    {
                        string strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                        arrKeyVarLst.Add(strKeyVar);
                        arrKeyValueLst.Add(objField.ObjFieldTabENEx.PrivFuncName);
                        intKeyIndex++;
                    }
                    string strKeyVarLst = clsArray.GetSqlInStrByArray(arrKeyVarLst, false);
                    string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);
                    string strKeyVarValueLst = string.Format("string.Format(\"{0}\", {1})", strKeyVarLst, strKeyValueLst);
                    clsArray.GetSqlInStrByArray(arrKeyVarLst, false);
                    strBuilder.Append("\r\n string strResult = \"关键字变量值为:\" + " + strKeyVarValueLst + " + \"的记录已存在,不能重复插入!\" ;");
                    strBuilder.Append("\r\n throw new Exception(strResult);");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n//把多条记录插入到表中");
            strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjRow = objDS.Tables[cls{0}EN._CurrTabName ].NewRow();",
                 objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                strBuilder.AppendFormat("\r\nobjRow[con{1}.{2}] = oRow[con{1}.{2}].ToString().Trim(); //{0}",
                    objField.ColCaption,
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
            }
            strBuilder.AppendFormat("\r\n objDS.Tables[cls{0}EN._CurrTabName].Rows.Add(objRow);",
                            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjDA.Update(objDS, cls{0}EN._CurrTabName);",
                 objPrjTabENEx.TabName);
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
            ///添加多条新记录 ==  ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenUpdate()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过ADO修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改到数据库中的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool Update(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\n System.Data.SqlClient.SqlCommandBuilder objCB ;");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where {1};",
            objPrjTabENEx.TabName, KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN"));
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, cls{0}EN._CurrTabName);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nif (objDS.Tables[cls{0}EN._CurrTabName].Rows.Count  ==  0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//MsgBox(\"没有相应的ID号:" + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN") + ");");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nobjRow = objDS.Tables[cls{0}EN._CurrTabName].Rows[0];",
                        objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //if ((objField.Is1Identity  ==  false) && (objField.IsTabPrimary  ==  false))
                //{
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.FldOpTypeId == "0003")
                {
                    strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
               objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\nobjRow[con{1}.{2}] = {3}; //{0}",
                        objField.ColCaption,
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                    strPrivPropNameWithObjectName4Get);
                    strBuilder.Append("\r\n }");
                    continue;
                }

                strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
                objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\nobjRow[con{1}.{2}] = {3}; //{0}",
                    objField.ColCaption,
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName);
                strBuilder.Append("\r\n }");

            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjDA.Update(objDS, cls{0}EN._CurrTabName);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");




            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySql()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //if ((objField.Is1Identity  ==  false) && (objField.IsTabPrimary  ==  false))
                //{
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                string strTemp = GetCode4FieldInUpdateBySql(objField, ref bolIsFirst);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }


            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            strKeyVarLst,
            strKeyValueLst);

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySqlWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySqlWithCondition(objField, ref bolIsFirst);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

                //}

            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");


            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.Append("\r\n sbSQL.AppendFormat(\" Where {0}\", strCondition); ");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");

            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySqlWithConditionTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySqlWithConditionTransaction(cls{0}EN obj{0}EN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySqlWithCondition(objField, ref bolIsFirst);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

                //}

            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");


            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.Append("\r\n sbSQL.AppendFormat(\" Where {0}\", strCondition); ");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");

            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }


        public virtual string GenUpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            ///
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

                //}

            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");


            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            strKeyVarLst,
            strKeyValueLst);

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");

            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"发生错误:[{{0}}].SQL:[{{1}}].({{2}})\",", "{", "}");
            strBuilder.Append("\r\n" + "     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

            //            strBuilder.Append("\r\nclsGeneralTab2.LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(strMsg);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySqlWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、支持事务处理.");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// /// 2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySql(objField, ref bolIsFirst);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }

            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            strKeyVarLst,
            strKeyValueLst);

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySqlWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// /// 3、支持事务处理.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.Log_UpdDate_13) continue;
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objPrjTabENEx.PrjId);
                strBuilder.AppendFormat("\r\n obj{0}EN.{1} = {2};", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), strCurrDateTimeExpress);

            }
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);


            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");

            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            strKeyVarLst,
            strKeyValueLst);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }


        public virtual string GenUpdateMultiRec()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///按条件修改多条记录------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:修改多条记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic int UpdateMultiRec(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("UpdateMultiRec", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:UpdateMultiRec)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB ;");
            strBuilder.Append("\r\n//			System.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount;");
            strBuilder.Append("\r\nif (strCondition  ==  \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0; //表示删除0条记录,实际上是不能该表的所有记录");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where \" + strCondition;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nif (objDS.Tables[\"{0}\"].Rows.Count  ==  0)",
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
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if ((objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY) && (objField.FieldTypeId == enumFieldType.KeyField_02))
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                strBuilder.AppendFormat("\r\nobjRow[\"{0}\"] = {1}; //{2}",
                objField.ObjFieldTabENEx.FldName, strPrivPropNameWithObjectName4Get, objField.ColCaption);
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
        public virtual string GenGetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取表中的记录数---------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数.该表与当前类相关。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\n public static int GetRecCount()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.GetRecCount(cls{0}EN._CurrTabName);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public virtual string GenGetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数, 该表与当前类不相关。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public virtual string GenGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\n public static int GetRecCountByCond(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.GetRecCount(cls{0}EN._CurrTabName, strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenGetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCountByCond(string strTabName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 ==  ==  == ;
            return strBuilder.ToString();
        }
        public virtual string GenfunSetFldValue4String()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///设置/获取表中的符合条件的某字段的值------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");



            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, strValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();

        }

        public virtual string GenfunSetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///设置/获取表中的符合条件的某字段的值------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"varValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue<T>(string strFldName, T varValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, varValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public virtual string GenfunSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, fltValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenfunSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, intValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }

        public virtual string GenfunSetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"varValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }


        public virtual string GenfunSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, strValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenfunSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, intValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenfunSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public virtual string GenGetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表中的符合条件的某字段的值,以列表返回");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic List<string> GetFldValue(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n List<string> arrList = objSQL.GetFldDataOfTable(\"{0}\", strFldName, strCondition);",
                         objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenGetFldValueNoDistinct()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表中的符合条件的某字段的值,以列表返回");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic List<string> GetFldValueNoDistinct(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n List<string> arrList = objSQL.GetFldDataOfTableNoDistinct(\"{0}\", strFldName, strCondition);",
                         objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public virtual string GenGetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中的符合条件的某字段的值,以列表返回");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///设置/获取表中的符合条件的某字段的值 == = ;
            return strBuilder.ToString();
        }
        public override string GenDelRecord()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///删除一条记录-----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            foreach (var objKeyFld in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            strBuilder.Append("\r\n" + string.Format("public int DelRecord({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strBuilder.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strBuilder.Append("\r\n//删除单条记录");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab !=  \")
            //			{
            //				strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //				strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            strTemp = string.Format("//删除{0}本表中与当前对象有关的记录",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\n return objSQL.ExecSql2(strSQL);");
            strBuilder.Append("\r\n}");
            ///删除一条记录 == = ;
            return strBuilder.ToString();
        }


        public string GenDelRecordBySign()
        {
            string strTemp = "";
            if (objDelSignField == null) return "";
            StringBuilder strBuilder = new StringBuilder();
            ///删除一条记录-----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:根据标志删除关键字所指定的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            strBuilder.Append("\r\n" + string.Format("public int DelRecordBySign({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strBuilder.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strBuilder.Append("\r\n//删除单条记录");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab !=  \")
            //			{
            //				strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //				strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            strTemp = string.Format("//删除{0}本表中与当前对象有关的记录",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);

            if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
            {
                strBuilder.AppendFormat("\r\n" + "strSQL = strSQL + string.Format(\"Update {0} Set {{0}}='1', {{1}} = '{{2}}' where {1} = {{3}}\",",
                 objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "con{0}.IsDeleted, con{0}.DeletedDate, clsDateTime.getTodayDateTimeStr(0), {1});",
                   objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "strSQL = strSQL + string.Format(\"Update {0} Set {{0}}='1', {{1}} = '{{2}}' where {1} = '{{3}}'\",",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "con{0}.IsDeleted, con{0}.DeletedDate, clsDateTime.getTodayDateTimeStr(0), {1});",
                   objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n return objSQL.ExecSql2(strSQL);");
            strBuilder.Append("\r\n}");
            ///删除一条记录 == = ;
            return strBuilder.ToString();
        }

        public string GenUnDelRecordBySign()
        {
            string strTemp = "";
            if (objDelSignField == null) return "";
            StringBuilder strBuilder = new StringBuilder();
            ///删除一条记录-----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:恢复被删除的记录,针对有删除标志的表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回恢复删除的记录数</returns>");
            strBuilder.Append("\r\n" + string.Format("public int UnDelRecordBySign({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strBuilder.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strBuilder.Append("\r\n//删除单条记录");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab !=  \")
            //			{
            //				strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //				strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            strTemp = string.Format("//删除{0}本表中与当前对象有关的记录",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
            {
                strBuilder.AppendFormat("\r\n" + "strSQL = strSQL + string.Format(\"Update {0} Set {{0}}='0', {{1}} = '{{2}}' where {1} = {{3}}\",",
                 objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "con{0}.IsDeleted, con{0}.DeletedDate, clsDateTime.getTodayDateTimeStr(0), {1});",
                   objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "strSQL = strSQL + string.Format(\"Update {0} Set {{0}}='0', {{1}} = '{{2}}' where {1} = '{{3}}'\",",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "con{0}.IsDeleted, con{0}.DeletedDate, clsDateTime.getTodayDateTimeStr(0), {1});",
                   objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n return objSQL.ExecSql2(strSQL);");
            strBuilder.Append("\r\n}");
            ///删除一条记录 == = ;
            return strBuilder.ToString();
        }


        private string GetCode4FieldInUpdateBySqlWithCondition(clsPrjTabFldENEx objField, ref bool bolIsFirst)
        {
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return sbCodeForCs.ToString();
            }
            if (objField.FldOpTypeId == enumFldOperationType.OnlyRead_0002 || objField.FldOpTypeId == enumFldOperationType.CannotReadWrite_0004) return sbCodeForCs.ToString();//只读就不需要检查
            if (objField.FldOpTypeId == enumFldOperationType.OnlyWrite_0003)
            {
                sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                sbCodeForCs.Append("\r\n {");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "bool":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4} == true?\"1\":\"0\"); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName);
                            break;
                        case "byte":
                        case "byte[]":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\",{4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                            objField.ObjFieldTabENEx.FldName,
                            strPrivPropNameWithObjectName);
                            break;
                        default:
                            if (objField.IsTabForeignKey == true)
                            {
                                sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n {");
                                sbCodeForCs.AppendFormat("\r\n {0} = null;",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n }");
                            }
                            sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                            strPrivPropNameWithObjectName4Get);
                            sbCodeForCs.Append("\r\n {");

                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName4Get}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"");
                            }
                            else
                            {
                                sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName4Get}");
                            }
                            sbCodeForCs.Append($"\r\n sbSQL.AppendFormat(\" {objField.ObjFieldTabENEx.FldName} = '{{0}}',\", {objField.ObjFieldTabENEx.PrivFuncName}); //{objField.ColCaption}");

                            sbCodeForCs.Append("\r\n }");
                            sbCodeForCs.Append("\r\n else");
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n sbSQL.Append(\" " + objField.ObjFieldTabENEx.FldName + " = null,\"); //{2}",
                            "{", "}",
                            objField.ColCaption);

                            sbCodeForCs.Append("\r\n }");
                            break;
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}},\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName4Get);
                }
                sbCodeForCs.Append("\r\n }");

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
            objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
            sbCodeForCs.Append("\r\n {");

            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "bool":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4} == true?\"1\":\"0\"); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                        break;
                    case "byte":
                    case "byte[]":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                        break;
                    default:
                        if (objField.IsTabForeignKey == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n {0} = null;",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }
                        sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        {
                            sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"");
                        }
                        else
                        {
                            sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName};");
                        }
                        sbCodeForCs.Append($"\r\n sbSQL.AppendFormat(\" {objField.ObjFieldTabENEx.FldName} = '{{0}}',\", {objField.ObjFieldTabENEx.PrivFuncName}); //{objField.ColCaption}");

                        sbCodeForCs.Append("\r\n }");
                        sbCodeForCs.Append("\r\n else");
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n sbSQL.Append(\" " + objField.ObjFieldTabENEx.FldName + " = null,\"); //{2}",
                        "{", "}",
                        objField.ColCaption);

                        sbCodeForCs.Append("\r\n }");
                        break;
                }
            }
            else
            {
                if (objField.IsTabNullable == true)
                {
                    sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                   strPrivPropNameWithObjectName);
                    sbCodeForCs.Append("\r\n {");
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = {{0}},\",{1}, con{2}.{3}); //{0}",
                    objField.ColCaption,
                    strPrivPropNameWithObjectName,
                     objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);
                    sbCodeForCs.Append("\r\n }");
                    sbCodeForCs.Append("\r\n else");
                    sbCodeForCs.Append("\r\n {");
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{0}} = null,\",con{1}.{2}); //{0}",
                    objField.ColCaption,
                     objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);

                    sbCodeForCs.Append("\r\n }");
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}},\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName);
                }
            }
            sbCodeForCs.Append("\r\n }");

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInUpdateBySql(clsPrjTabFldENEx objField, ref bool bolIsFirst)
        {
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return sbCodeForCs.ToString();
            }
            if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return sbCodeForCs.ToString();//只读就不需要检查
            if (objField.FldOpTypeId == "0003")
            {
                if (bolIsFirst == true)
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        // sbSQL.AppendFormat("LoginTime = 'objPrjTabENEx.LoginTime' //登陆时间
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}'\", {4} == true?\"1\":\"0\"); //{2}",
                            "{", "}",
                            objField.ColCaption,
                            objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get);
                        }
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = {{0}}\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                         strPrivPropNameWithObjectName4Get);
                    }
                    bolIsFirst = false;
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4} == true?\"1\":\"0\"); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get);
                        }
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = {{0}}\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                         strPrivPropNameWithObjectName4Get);
                    }
                }

                return sbCodeForCs.ToString();
            }
            if (bolIsFirst == true)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    // sbSQL.AppendFormat("LoginTime = 'objPrjTabENEx.LoginTime' //登陆时间
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}'\", {4} == true?\"1\":\"0\"); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}'\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}}\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName,
                      strPrivPropNameWithObjectName);
                }
                bolIsFirst = false;
            }
            else
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4} == true?\"1\":\"0\"); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3}= '{{0}}'\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = {{0}}\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName,
                      strPrivPropNameWithObjectName);
                }
            }
            //}

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInAddNewRecordBySql2(clsPrjTabFldENEx objField)
        {
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return sbCodeForCs.ToString();
            }
            if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return sbCodeForCs.ToString();//只读就不需要检查

            if (objField.FldOpTypeId == "0003") //只写
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "byte[]":
                    case "byte":
                        break;
                    case "string":

                        if (objField.IsTabForeignKey == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n {0} = null;",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }

                        sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                        strPrivPropNameWithObjectName,
                        strPrivPropNameWithObjectName
                       );
                        //if (clsSysParaEN.bolIsAccessSqlInjection  ==  true)
                        //{
                        // sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"delete\", \" \"); //删除SQL注入中的DELETE,使之成为空格\"",
                        // strPrivPropNameWithObjectName);
                        // string ss = "";
                        // string ss1 = ss.Replace(
                        //}
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n }");
                        break;
                    case "bool":
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0}  ==  false ? \"0\" : \"1\") + \"'\");",
                        strPrivPropNameWithObjectName);
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":
                        if (objField.IsTabNullable == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                       strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                                  objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                            sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                                  objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                            sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                            strPrivPropNameWithObjectName);
                        }
                        //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                        //objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                        //strPrivPropNameWithObjectName);
                        break;
                    default:
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {

                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"");
                            }
                            else
                            {
                                sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName};");
                            }

                            sbCodeForCs.Append($"\r\n arrValueListForInsert.Add('{objField.ObjFieldTabENEx.PrivFuncName}');");
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                            strPrivPropNameWithObjectName);
                        }
                        break;
                }

                return sbCodeForCs.ToString();
            }

            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":

                    if (objField.IsTabForeignKey == true)
                    {
                        sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n {0} = null;",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n }");
                    }

                    sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                    strPrivPropNameWithObjectName);
                    sbCodeForCs.Append("\r\n {");
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                          objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);

                    sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"");

                    //if (clsSysParaEN.bolIsAccessSqlInjection  ==  true)
                    //{
                    // sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"delete\", \" \"); //删除SQL注入中的DELETE,使之成为空格\"",
                    // strPrivPropNameWithObjectName);
                    // string ss = "";
                    // string ss1 = ss.Replace(
                    //}
                    sbCodeForCs.Append($"\r\n arrValueListForInsert.Add(\"'\" + {objField.ObjFieldTabENEx.PrivFuncName} + \"'\");");
                    sbCodeForCs.Append("\r\n }");
                    break;
                case "bool":
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0}  ==  false ? \"0\" : \"1\") + \"'\");",
                    strPrivPropNameWithObjectName);
                    break;
                case "int":
                case "long":
                case "float":
                case "double":
                case "short":
                case "Int16":
                case "Int32":

                    //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                    //objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                    //strPrivPropNameWithObjectName);
                    if (objField.IsTabNullable == true)
                    {
                        sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                    strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                              objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n }");
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                              objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                        strPrivPropNameWithObjectName);
                    }
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        {
                            sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"");
                        }
                        else
                        {
                            sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName};");
                        }
                        sbCodeForCs.Append($"\r\n arrValueListForInsert.Add(\"'\" + {objField.ObjFieldTabENEx.PrivFuncName} + \"'\");");

                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                        strPrivPropNameWithObjectName);
                    }
                    break;
            }
            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInUpdateBySql2(clsPrjTabFldENEx objField)
        {
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return ""; ;//只读就不需要检查
            if (objField.FldOpTypeId == "0003") //只写
            {
                sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                sbCodeForCs.Append("\r\n {");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "bool":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4} == true?\"1\":\"0\"); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get);
                            break;
                        case "byte":
                        case "byte[]":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get);
                            break;
                        default:
                            if (objField.IsTabForeignKey == true)
                            {
                                sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n {");
                                sbCodeForCs.AppendFormat("\r\n {0} = null;",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n }");
                            }
                            sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                            strPrivPropNameWithObjectName4Get);
                            sbCodeForCs.Append("\r\n {");
                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName4Get}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"");
                            }
                            else
                            {
                                sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName4Get}");
                            }
                            sbCodeForCs.Append($"\r\n sbSQL.AppendFormat(\" {objField.ObjFieldTabENEx.FldName} = '{{0}}',\", {objField.ObjFieldTabENEx.PrivFuncName}); //{objField.ColCaption}");
                            sbCodeForCs.Append("\r\n }");
                            sbCodeForCs.Append("\r\n else");
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.Append($"\r\n sbSQL.Append(\"{objField.ObjFieldTabENEx.FldName} = null,\"); //{objField.ColCaption}");
                            sbCodeForCs.Append("\r\n }");
                            break;
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}},\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                    objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName4Get);
                }
                sbCodeForCs.Append("\r\n }");
                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
            objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
            sbCodeForCs.Append("\r\n {");

            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "bool":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {{1}} = '{{0}}',\", {3} == true?\"1\":\"0\", con{4}.{5}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        strPrivPropNameWithObjectName,
                         objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                        break;
                    case "byte":
                    case "byte[]":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = '{{0}}',\", {3}, con{4}.{5}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        strPrivPropNameWithObjectName,
                         objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                        break;
                    default:
                        if (objField.IsTabForeignKey == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n {0} = null;",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }
                        sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        {
                            sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"");
                        }
                        else
                        {
                            sbCodeForCs.Append($"\r\n var {objField.ObjFieldTabENEx.PrivFuncName} = {strPrivPropNameWithObjectName};");
                        }
                        sbCodeForCs.Append($"\r\n sbSQL.AppendFormat(\"{{1}} = '{{0}}',\", {objField.ObjFieldTabENEx.PrivFuncName}, con{objPrjTabENEx.TabName}.{objField.ObjFieldTabENEx.FldName}); //{objField.ColCaption}");
                        sbCodeForCs.Append("\r\n }");
                        sbCodeForCs.Append("\r\n else");
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{0}} = null,\",con{3}.{4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);

                        sbCodeForCs.Append("\r\n }");
                        break;
                }
            }
            else
            {
                if (objField.IsTabNullable == true)
                {
                    sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                   strPrivPropNameWithObjectName);
                    sbCodeForCs.Append("\r\n {");
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = {{0}},\",{1}, con{2}.{3}); //{0}",
                    objField.ColCaption,
                    strPrivPropNameWithObjectName,
                     objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);
                    sbCodeForCs.Append("\r\n }");
                    sbCodeForCs.Append("\r\n else");
                    sbCodeForCs.Append("\r\n {");
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{0}} = null,\",con{1}.{2}); //{0}",
                    objField.ColCaption,
                     objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);

                    sbCodeForCs.Append("\r\n }");
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = {{0}},\",{1}, con{2}.{3}); //{0}",
objField.ColCaption,
strPrivPropNameWithObjectName,
 objPrjTabENEx.TabName,
        objField.ObjFieldTabENEx.FldName);
                }
            }
            sbCodeForCs.Append("\r\n }");
            return sbCodeForCs.ToString();
        }

        public virtual string GenGetRecValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一关键值的记录-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加到数据库中的对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\npublic bool Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN") + ";");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull(objField) + "); //{2}",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n {4} = {5}; //{0}(字段类型:{1},字段长度:{2},是否可空:{3})",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objField.ObjFieldTabENEx.FldLength,
                        objField.ObjFieldTabENEx.IsNull,
                         strPrivPropNameWithObjectName,
                          AccessNull(objField));
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"在根据关键字获取对象时,发生:{{0}},请检查!({1}: Get{0})\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            //获取某一关键值的记录 ==  == = ;
            return strBuilder.ToString();
        }
        public string GenTransNullToStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///私有函数Begin-------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把Null数据转换成String型,如果给定的对象不是Null,就直接返回。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">给定的对象</param>");
            strBuilder.Append("\r\n /// <returns>返回String型数据</returns>");
            strBuilder.Append("\r\nprotected string TransNullToStr(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return \"\";");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn \"\";");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn obj.ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenTransNullToInt()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把Null数据转换成Int型,如果给定的对象不是Null,就直接返回。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">给定的对象</param>");
            strBuilder.Append("\r\n /// <returns>返回Int型数据</returns>");
            strBuilder.Append("\r\nprotected int TransNullToInt(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return 0;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn Int32.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenTransNullToLong()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把Null数据转换成Long型,如果给定的对象不是Null,就直接返回。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">给定的对象</param>");
            strBuilder.Append("\r\n /// <returns>返回Long型数据</returns>");
            strBuilder.Append("\r\nprotected long TransNullToLong(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return 0;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn Int64.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenTransNullToShort()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把Null数据转换成short型,如果给定的对象不是Null,就直接返回。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">给定的对象</param>");
            strBuilder.Append("\r\n /// <returns>返回short型数据</returns>");
            strBuilder.Append("\r\nprotected short TransNullToShort(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return 0;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn short.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }

        public string GenTransNullToDate()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把Null数据转换成DateTime型,如果给定的对象不是Null,就直接返回。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">给定的对象</param>");
            strBuilder.Append("\r\n /// <returns>返回DateTime型数据</returns>");
            strBuilder.Append("\r\nprotected DateTime TransNullToDate(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return DateTime.Parse(\"#1/1/1900#\");");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn DateTime.Parse(\"#1/1/1900#\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn DateTime.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenTransNullToFloat()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把Null数据转换成Float型,如果给定的对象不是Null,就直接返回。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">给定的对象</param>");
            strBuilder.Append("\r\n /// <returns>返回Float型数据</returns>");
            strBuilder.Append("\r\nprotected float TransNullToFloat(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n float f1 = 0.0f;");
            strBuilder.Append("\r\n if (obj  ==  null) return f1;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0.0f;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn float.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenTransNullToDouble()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把Null数据转换成Double型,如果给定的对象不是Null,就直接返回。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">给定的对象</param>");
            strBuilder.Append("\r\n /// <returns>返回Double型数据</returns>");
            strBuilder.Append("\r\nprotected double TransNullToDouble(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n double d1 = 0.0;");
            strBuilder.Append("\r\n if (obj  ==  null) return d1;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0.0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn double.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenTransNullToBool()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把Null数据转换成布尔型,如果给定的对象不是Null,就直接返回。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">给定的对象</param>");
            strBuilder.Append("\r\n /// <returns>返回布尔型数据</returns>");
            strBuilder.Append("\r\nprotected bool TransNullToBool(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return false;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn bool.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }

        public string Gen_GetObjByKeyId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            //获取某一关键值的记录-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象,用对象的形式表示.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
            }
            strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\npublic cls{0}EN GetObjByKeyLst({1})",
             objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            }
            else
            {
                strBuilder.AppendFormat("\r\npublic cls{0}EN GetObjBy{1}({2})",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
            }
            strBuilder.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n DataRow objRow = objDT.Rows[0];");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull_Static(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n {4} = {5}; //{0}(字段类型:{1},字段长度:{2},是否可空:{3})",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objField.ObjFieldTabENEx.FldLength,
                        objField.ObjFieldTabENEx.IsNull,
                         strPrivPropNameWithObjectName,
                         AccessNull_Static(objField));
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"根据关键字获取相关对象时,发生:{{0}},请检查!({1}: GetObjByKeyLst)\", objException.Message));",
                        objKeyField.FldName, objPrjTabENEx.ClsName);
            }
            else
            {
                strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"根据关键字获取相关对象时,发生:{{0}},请检查!({1}: GetObjBy{0})\", objException.Message));",
            objKeyField.FldName, objPrjTabENEx.ClsName);
            }
            strBuilder.Append("\r\n}");

            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            //获取某一关键值的记录 ==  == = ;
            return strBuilder.ToString();
        }
    }
}
