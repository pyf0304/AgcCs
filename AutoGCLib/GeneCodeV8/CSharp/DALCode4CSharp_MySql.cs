using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.sql;



using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AgcCommBase;
using AGC.BusinessLogicEx;
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
    class DALCode4CSharp_MySql : clsGeneCodeBase4Tab
    {

        #region 构造函数

        public DALCode4CSharp_MySql(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MySql;
        }
        #endregion


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
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
            objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using MySql.Data.MySqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.CommdbforMySql;"); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
                objProject.PrjDomain); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.DAL",
                objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n" + "public const string _CurrTabName = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
                strCodeForCs.Append("\r\n" + "public const string _CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
                //与属性名称相关的代码
                strCodeForCs.AppendFormat("\r\n" + "protected const int _AttributeCount = {0};",
                objPrjTabENEx.arrFldSet.Count);
                strCodeForCs.AppendFormat("\r\n" + "protected const string EXCEPTION_MSG = \"出错:\"; //there was an error in the method. please see the Application Log for details.\";");
                strCodeForCs.AppendFormat("\r\n" + "protected string mstrModuleName;");

                strTemp = "{";
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp == "{")
                    {
                        strTemp += "\"" + objField.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp += ", \"" + objField.ObjFieldTabENEx.FldName + "\"";
                    }
                }
                strTemp += "}";
                strCodeForCs.AppendFormat("\r\n" + "public static string[] _AttributeName = new string[] {0};",
                strTemp);

                strCodeForCs.Append("\r\n" + "//以下是属性变量");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

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



        public override string GenSQLCode(string strPrjDataBaseId)
        {
            //string strFuncName = "";
            string strResult = "";
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
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
                //				strBuilder.Append("\r\n" +clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));

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

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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

        public override string GenStoreProcedure_Add(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Add ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,

                    objField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);

                }
            }
            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            //需要插入表的字段列表
            ArrayList arrFieldListForInsert = new ArrayList();
            //需要插入表的值列表
            ArrayList arrValueListForInsert = new ArrayList();


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if ((objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY) && (objField.FieldTypeId == enumFieldType.KeyField_02))
                {
                    continue;
                }
                arrFieldListForInsert.Add(objField.ObjFieldTabENEx.FldName);
                arrValueListForInsert.Add("@" + objField.ObjFieldTabENEx.FldName);
            }

            //组织插入记录SQL串
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);

            strCodeForCs.AppendFormat("\r\n" + "insert into {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "({0}) values ({1}) ;", strFieldListCode, strValuesListCode);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }



        public override string GenStoreProcedure_Update(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Update ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
                {

                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);
                }
            }
            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "update {0} set ",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "{0} = @{0},", objField.ObjFieldTabENEx.FldName);
            }

            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public override string GenStoreProcedure_Delete(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Delete ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "delete from {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public override string GenStoreProcedure_Select(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Select ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            //if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            //{
            // strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
            // objKeyField.FldName,
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            // objKeyField.ObjFieldTabENEx.FldLength);
            //}
            //else
            //{
            // strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
            // objKeyField.FldName,
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            // objKeyField.ObjFieldTabENEx.FldLength);
            //}

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "Select {1} from {0} ",
            objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr);
            strCodeForCs.AppendFormat("\r\n" + "-- Where {0} = @{0};", objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public override string GenStoreProcedure_SelectOne(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectOne ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "Select {1} from {0} ",
            objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public override string GenStoreProcedure_IsExist(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "-- Run Example:");
            strCodeForCs.Append("\r\n" + "-- declare @Exist char(1)");
            strCodeForCs.Append("\r\n" + "-- exec Student_IsExist '1005', @Exist out");
            strCodeForCs.Append("\r\n" + "-- select @Exist;");

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_IsExist ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            strCodeForCs.Append("\r\n" + "@IsExist char(1) out");
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.AppendFormat("\r\n" + "if (Exists(select * from {1} Where {0} = @{0}))",
            objKeyField.FldName,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '1';");
            strCodeForCs.Append("\r\n" + "return 1;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '0'");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public override string GenStoreProcedure_SelectByCond(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectByCond ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");

            strCodeForCs.Append("\r\n" + "declare @ret int, -- return value of sp call");
            strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select {1} from {0} ';",
            objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr);
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public override string GenStoreProcedure_SelectTop1ByCond(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectTop1ByCond ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");

            strCodeForCs.Append("\r\n" + "declare @ret int, -- return value of sp call");
            strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select Top 1 * from {0} ';",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public override string GenSQLCode4CreateTab(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
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
                //				strBuilder.Append("\r\n" +clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));

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
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(DALCode4CSharp_MySql);
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


        public string GenAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///公共过程--------------------------------------;
            ///添加新记录----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>添加是否成功?</returns>");

            strBuilder.AppendFormat("\r\n public bool AddNewRecord(cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlDataAdapter objDA ; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlCommandBuilder objCB ; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            /// Dim objSQL As new IKData.SQLServer();
            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where 1 = 2\";", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDA = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, objSQL.MySqlConnect);");
            strBuilder.Append("\r\nobjCB = new MySql.Data.MySqlClient.MySqlCommandBuilder(objDA);");
            strBuilder.Append("\r\nobjDA.Fill(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].NewRow();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);

                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                }
                else
                {
                    if (objField.IsTabNullable == true && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strBuilder.AppendFormat("\r\n if ({0} != \"\")", strPrivPropNameWithObjectName4Get5EN);
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\nobjRow[\"{1}\"] = {2}; //{0}",
                            objField.ColCaption,
                            objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get5EN);
                        strBuilder.Append("\r\n }");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nobjRow[\"{1}\"] = {2}; //{0}",
                            objField.ColCaption,
                            objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get5EN);
                    }
                }
            }
            strBuilder.Append("\r\nobjDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows.Add(objRow);");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA.Update(objDS, \"" + objPrjTabENEx.TabName + "\");");
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
            ///添加新记录 == ;
            return strBuilder.ToString();
        }
        public string gfunAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///公共过程--------------------------------------;
            ///添加新记录----------------;
            ///
            strBuilder.Append("\r\n public int AddNewRecord()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n strSQL = \"insert into " + objPrjTabENEx.TabName + "\";");
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
            int intFldNum = objPrjTabENEx.arrFldSet.Count;
            for (int i = 0; i < intFldNum; i++)
            {
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
                string strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType;
                clsString.FstUcase_S(ref strTemp);
                strBuilder.Append("\r\n objPS.set" + strTemp + "(" + intFieldNo.ToString().Trim() + ", objPrjTabENEx." + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase) + ");");
                intFieldNo += 1;
            }
            strBuilder.Append("\r\n int iResult = objPS.executeUpdate();");
            strBuilder.Append("\r\n objPS.close();");
            strBuilder.Append("\r\n return iResult;");
            strBuilder.Append("\r\n }");
            ///添加新记录 == ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n MySqlConnection myConnection = null;");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objPrjTabENEx.Stdid, objPrjTabENEx.FileName);");
            string strFieldLst = "";
            string strParaLst = "";
            // StringBuilder strValueLst = new StringBuilder();
            List<string> lstField = new List<string>();//字段列表
            List<string> lstPara = new List<string>();//？参数
            List<string> lstParaStatement = new List<string>();//参数语句
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                lstField.Add(objField.ObjFieldTabENEx.FldName);
                lstPara.Add("?" + objField.ObjFieldTabENEx.FldName);
                StringBuilder sbTemp = new StringBuilder();
                sbTemp.AppendFormat("\r\n //定义参数,并设置参数值.字段:{0}({1})",
                objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                sbTemp.AppendFormat("\r\n myCommand.Parameters.Add(new MySqlParameter(\"?{0}\", MySqlDbType.{1}, {2}));",
                objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.objDataTypeAbbrEN.MySqlType, objField.ObjFieldTabENEx.FldLength);
                sbTemp.AppendFormat("\r\n myCommand.Parameters[\"?{0}\"].Value = obj{1}.{0};",
                objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);

                lstParaStatement.Add(sbTemp.ToString());
                intIndex = intIndex + 1;
            }
            strFieldLst = clsArray.GetSqlInStrByArray(lstField, false);
            strParaLst = clsArray.GetSqlInStrByArray(lstPara, false);

            strBuilder.AppendFormat("\r\n strSQL.Append(\"insert into {0}\");",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"({0}) \");",
            strFieldLst);

            strBuilder.Append("\r\nstrSQL.Append(\"values \");");

            strBuilder.AppendFormat("\r\nstrSQL.Append(\" ({0})\");",
            strParaLst);

            strBuilder.Append("\r\n int intFlag = 0;//标志");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n myConnection = objSQL.getConnectObj(objSQL.ConnectionString);");
            //myConnection.ConnectionString = objSQL.ConnectionString
            strBuilder.Append("\r\n MySqlCommand myCommand = new MySqlCommand(strSQL.ToString(), myConnection);");
            foreach (string strPara in lstParaStatement)
            {
                strBuilder.Append(strPara);
            }

            strBuilder.Append("\r\n intFlag = myCommand.ExecuteNonQuery();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            //ErrorInformation.
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\n return false;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (myConnection != null)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n myConnection.Close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intFlag > 0)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return false;");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n ");

            ///添加新记录,BySQL == ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQL2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //需要插入表的字段列表");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //需要插入表的值列表");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "string":
                        strBuilder.AppendFormat("\r\n if ({0} != null)",
                        strPrivPropNameWithObjectName4Get5EN);
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                        strPrivPropNameWithObjectName4Get5EN);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                        strPrivPropNameWithObjectName4Get5EN);
                        strBuilder.Append("\r\n }");
                        break;
                    case "bool":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                        strPrivPropNameWithObjectName4Get5EN);
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":
                    case "byte":
                    case "byte[]":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                        strPrivPropNameWithObjectName4Get5EN);
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                strPrivPropNameWithObjectName4Get5EN);
                            }
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                            strPrivPropNameWithObjectName4Get5EN);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                            strPrivPropNameWithObjectName4Get5EN);
                        }
                        break;
                }

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

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQLWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录.(带事务处理)");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}, MySqlConnection objSqlConnection, MySqlTransaction objMySqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
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
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                    strValueLsd.AppendFormat("{0}", strPrivPropNameWithObjectName4Get5EN);
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
                    strValueLsd.AppendFormat(", {0}", strPrivPropNameWithObjectName4Get5EN);
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
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQLWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}, MySqlConnection objSqlConnection, MySqlTransaction objMySqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n StringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //需要插入表的字段列表");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //需要插入表的值列表");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "string":
                        strBuilder.AppendFormat("\r\n if ({0} != null)",
                        strPrivPropNameWithObjectName4Get5EN);
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                        strPrivPropNameWithObjectName4Get5EN);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                        strPrivPropNameWithObjectName4Get5EN);
                        strBuilder.Append("\r\n }");
                        break;
                    case "bool":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                        strPrivPropNameWithObjectName4Get5EN);
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":
                    case "byte":
                    case "byte[]":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                        strPrivPropNameWithObjectName4Get5EN);
                        break;

                    default:
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                            strPrivPropNameWithObjectName4Get5EN);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                            strPrivPropNameWithObjectName4Get5EN);
                        }
                        break;
                }

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

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == ;
            return strBuilder.ToString();
        }

        public string GenAddnewRecBySP()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strTemp = string.Format("public bool Addnew{0}BySP(cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                }
                else
                {
                    strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName4Get5EN);
                }
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Add\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == ;
            return strBuilder.ToString();
        }

        public string GenUpdateBySP()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过存储过程(StoreProcedure)来修改记录");
            strBuilder.Append("\r\n /// /// 缺点:1、不能支持事务处理.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strTemp = string.Format("public bool Update{0}BySP(cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName4Get5EN);
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Update\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == ;
            return strBuilder.ToString();
        }

        public string GenDelRecordBySP()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strTemp = string.Format("public bool DelRecordBySP() ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objKeyField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + clsFieldTabBLEx.PrivPropNameWithObjectName(objKeyField, "obj" + objPrjTabENEx.TabName, this.IsFstLcase) + ");");
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == ;
            return strBuilder.ToString();
        }


        public string GenDelRecordBySP_S()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strTemp = string.Format("public static bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objField.ObjFieldTabENEx.PrivFuncName + ");");
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == ;
            return strBuilder.ToString();
        }
        public string GenAddnewMultiRec()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///添加多条新记录---------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把多条记录同时插入到表中!");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"oDT\"></param>");
            strBuilder.Append("\r\n /// <param name = \"strResult\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strTemp = string.Format("public bool Addnew{0}s(System.Data.DataTable oDT, ref string strResult) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlDataAdapter objDA;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlCommandBuilder objCB; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where " + objKeyField.FldName + " = '111'\";", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDA = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, objSQL.MySqlConnect);");
            strBuilder.Append("\r\nobjCB = new MySql.Data.MySqlClient.MySqlCommandBuilder(objDA);");
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
                        strTT = string.Format("oRow[\"{0}\"].ToString().Trim()", objField.ObjFieldTabENEx.FldName);
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
                    strBuilder.Append("\r\nstrResult = \"关键字变量值为:\" + " + strKeyVarValueLst + " + \"的记录已存在,不能重复插入!\" ;");
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
                    strBuilder.AppendFormat("\r\nobjRow[\"" + objField.ObjFieldTabENEx.FldName + "\"] = oRow[\"" + objField.ObjFieldTabENEx.FldName + "\"].ToString().Trim(); //{0}", objField.ColCaption);
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




            strBuilder.Append("\r\nobjSQL.MySqlConnect.Close();");

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///添加多条新记录 == == ;
            return strBuilder.ToString();
        }
        public string GenUpdate()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.AppendFormat("\r\npublic bool Update(cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\n MySql.Data.MySqlClient.MySqlCommandBuilder objCB ;");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {2} from {0} where {1};",
            objPrjTabENEx.TabName, KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName), objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDA = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, objSQL.MySqlConnect);");
            strBuilder.Append("\r\nobjCB = new MySql.Data.MySqlClient.MySqlCommandBuilder(objDA);");
            strBuilder.Append("\r\nobjDA.Fill(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\nif (objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//MsgBox(\"没有相应的ID号:" + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName) + ");");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows[0];");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                if ((objField.ObjFieldTabENEx.IsIdentity == false) && (objField.FieldTypeId != enumFieldType.KeyField_02))
                {
                    strBuilder.AppendFormat("\r\n if (obj{1}.IsUpdated(cls{1}EN.con_{0}))",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\nobjRow[\"{1}\"] = {2}; //{0}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName4Get5EN);
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA.Update(objDS, \"" + objPrjTabENEx.TabName + "\");");
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
            ///修改记录 == ;
            return strBuilder.ToString();
        }

        public string GenUpdateBySql()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n MySqlConnection myConnection = null;");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objPrjTabENEx.Stdid, objPrjTabENEx.FileName);");
            string strFieldParaLst = "";
            // StringBuilder strValueLst = new StringBuilder();
            List<string> lstFieldPara = new List<string>();//字段列表
            List<string> lstPara = new List<string>();//？参数
            List<string> lstParaStatement = new List<string>();//参数语句
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId != enumFieldType.KeyField_02)
                {
                    lstFieldPara.Add(objField.ObjFieldTabENEx.FldName + " = ?" + objField.ObjFieldTabENEx.FldName);
                }
                StringBuilder sbTemp = new StringBuilder();
                sbTemp.AppendFormat("\r\n //定义参数,并设置参数值.字段:{0}({1})",
                objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                sbTemp.AppendFormat("\r\n myCommand.Parameters.Add(new MySqlParameter(\"?{0}\", MySqlDbType.{1}, {2}));",
                objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.objDataTypeAbbrEN.MySqlType, objField.ObjFieldTabENEx.FldLength);
                sbTemp.AppendFormat("\r\n myCommand.Parameters[\"?{0}\"].Value = obj{1}.{0};",
                objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);

                lstParaStatement.Add(sbTemp.ToString());
                intIndex = intIndex + 1;
            }
            strFieldParaLst = clsArray.GetSqlInStrByArray(lstFieldPara, false);

            strBuilder.AppendFormat("\r\n strSQL.Append(\"update {0} set \");",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"{0} \");",
            strFieldParaLst);


            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\"Where {0} = ?{0}\"); ",
            objKeyField.FldName);
            strBuilder.Append("\r\n int intFlag = 0;//标志");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n myConnection = objSQL.getConnectObj(objSQL.ConnectionString);");
            //myConnection.ConnectionString = objSQL.ConnectionString
            strBuilder.Append("\r\n MySqlCommand myCommand = new MySqlCommand(strSQL.ToString(), myConnection);");
            foreach (string strPara in lstParaStatement)
            {
                strBuilder.Append(strPara);
            }

            strBuilder.Append("\r\n intFlag = myCommand.ExecuteNonQuery();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            //ErrorInformation.
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\n return false;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (myConnection != null)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n myConnection.Close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intFlag > 0)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return false;");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n ");

            //修改记录 == ;
            return strBuilder.ToString();
        }

        public string GenUpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            ///
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                if ((objField.ObjFieldTabENEx.IsIdentity == false) && (objField.FieldTypeId != enumFieldType.KeyField_02))
                {

                    strBuilder.AppendFormat("\r\n if (obj{1}.IsUpdated(cls{1}EN.con_{0}))",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n {");

                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "bool":
                                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4} = true?\"1\":\"0\"); //{2}",
                                "{", "}",
                                objField.ColCaption,
                                 objField.ObjFieldTabENEx.FldName,
                                 strPrivPropNameWithObjectName4Get5EN);
                                break;
                            case "byte":
                            case "byte[]":
                                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                                "{", "}",
                                objField.ColCaption,
                                 objField.ObjFieldTabENEx.FldName,
                                  strPrivPropNameWithObjectName4Get5EN);
                                break;
                            default:
                                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                                {
                                    strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                    strPrivPropNameWithObjectName4Get5EN);
                                }
                                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                                "{", "}",
                                objField.ColCaption,
                                 objField.ObjFieldTabENEx.FldName,
                                  strPrivPropNameWithObjectName4Get5EN);
                                break;
                        }
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}},\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName4Get5EN);
                    }
                    strBuilder.Append("\r\n }");

                }
                //}

            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0} = '{{0}}'\",{3}); ",
                objKeyField.FldName,
                "{", "}",
              clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName, this.IsFstLcase));
            }
            else
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0} = {{0}}\", {3}); ",
                objKeyField.FldName,
                "{", "}",
              clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName, this.IsFstLcase));
            }
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
            ///修改记录 == ;
            return strBuilder.ToString();
        }

        public string GenUpdateBySqlWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、支持事务处理.");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// /// 2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}, MySqlConnection objSqlConnection, MySqlTransaction objMySqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                if ((objField.ObjFieldTabENEx.IsIdentity == false) && (objField.FieldTypeId != enumFieldType.KeyField_02))
                {
                    if (bolIsFirst == true)
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            // sbSQL.AppendFormat("LoginTime = 'objPrjTabENEx.LoginTime' //登陆时间

                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get5EN);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = {{0}}\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get5EN);
                        }
                        bolIsFirst = false;
                    }
                    else
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get5EN);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = {{0}}\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get5EN);
                        }
                    }
                    //}
                }
            }
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"Where {0} = '{{0}}'\",{3}); ",
                objKeyField.FldName,
                "{", "}",
             clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName, this.IsFstLcase));
            }
            else
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"Where {0} = {{0}}\", {3}); ",
                objKeyField.FldName,
                "{", "}",
                clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName, this.IsFstLcase));
            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objMySqlTransaction);");
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
            ///修改记录 == ;
            return strBuilder.ToString();
        }

        public string GenUpdateBySqlWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// /// 3、支持事务处理.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}, MySqlConnection objSqlConnection, MySqlTransaction objMySqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                if ((objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY) && (objField.FieldTypeId == enumFieldType.KeyField_02))
                {
                    continue;
                }
                strBuilder.AppendFormat("\r\n if (obj{1}.IsUpdated(cls{1}EN.con_{0}))",
                objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                strBuilder.Append("\r\n {");


                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "bool":
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4} = true?\"1\":\"0\"); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get5EN);
                            break;
                        case "byte":
                        case "byte[]":
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                           strPrivPropNameWithObjectName4Get5EN);
                            break;
                        default:
                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                strPrivPropNameWithObjectName4Get5EN);
                            }
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get5EN);
                            break;
                    }
                }
                else
                {
                    strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}},\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName,
                      strPrivPropNameWithObjectName4Get5EN);
                }
                strBuilder.Append("\r\n }");


            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0} = '{{0}}'\",{3}); ",
                objKeyField.FldName,
                "{", "}",
                clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName, this.IsFstLcase));
            }
            else
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0} = {{0}}\", {3}); ",
                objKeyField.FldName,
                "{", "}",
                clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName, this.IsFstLcase));
            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objMySqlTransaction);");
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
            ///修改记录 == ;
            return strBuilder.ToString();
        }


        public string GenUpdateMultiRec()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///按条件修改多条记录------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:修改多条记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic int UpdateMultiRec(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlCommandBuilder objCB ;");
            strBuilder.Append("\r\n//			System.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount;");
            strBuilder.Append("\r\nif (strCondition == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0; //表示删除0条记录,实际上是不能该表的所有记录");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select {1} from {0} where \" + strCondition;",
            objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDA = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, objSQL.MySqlConnect);");
            strBuilder.Append("\r\nobjCB = new MySql.Data.MySqlClient.MySqlCommandBuilder(objDA);");
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
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                if ((objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY) && (objField.FieldTypeId == enumFieldType.KeyField_02))
                {
                    continue;
                }
                strBuilder.AppendFormat("\r\nobjRow[\"{0}\"] = {1}; //{2}",
                objField.ObjFieldTabENEx.FldName, strPrivPropNameWithObjectName4Get5EN, objField.ColCaption);
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
            ///按条件修改多条记录 == ;
            return strBuilder.ToString();
        }
        public string GenGetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取表中的记录数---------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数.该表与当前类相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic int GetRecCount()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(CurrTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenGetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数.该表与当前类相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表中满足条件的记录数");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.GetRecCountByCond(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(CurrTabName, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenGetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.GetRecCountByCond(string strTabName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 == = ;
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4String()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///设置/获取表中的符合条件的某字段的值------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.SetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, strValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.SetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, fltValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.SetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, intValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.SetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, strValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.SetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, intValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.SetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenGetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表中的符合条件的某字段的值,以列表返回");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic ArrayList clsGeneralTab2.GetFldValue(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nArrayList arrList = objSQL.GetFldDataOfTable(\"{0}\", strFldName, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenGetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中的符合条件的某字段的值,以列表返回");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic static ArrayList clsGeneralTab2.GetFldValue(string strTabName, string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nArrayList arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///设置/获取表中的符合条件的某字段的值 == ;
            return strBuilder.ToString();
        }
        public string GenDelRecordBak()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\npublic bool DelRecord() ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab != \")
            //										 {
            //											 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == ;
            return strBuilder.ToString();
        }


        public override string Gen_GetSpecSQLObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\n public static clsSpecSQLforMySql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforMySql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}.ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforMySql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforMySql(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == ;
            return strBuilder.ToString();
        }

        public override string GenDelRecordWithTransactionBak()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\npublic bool DelRecord(MySqlConnection objSqlConnection, MySqlTransaction objMySqlTransaction) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab != \")
            //										 {
            //											 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnection, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == ;
            return strBuilder.ToString();
        }
        public override string GenDelRecordWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.AppendFormat("\r\npublic static bool DelRecord({0}, MySqlConnection objSqlConnection, MySqlTransaction objMySqlTransaction) ",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab != \")
            //										 {
            //											 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnection, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == ;
            return strBuilder.ToString();
        }

        public override string GenDelMultiRec()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///删除一些记录------------------;
            strBuilder.Append("\r\n//同时删除多条记录");
            strTemp = string.Format("public static bool Del{0}(List<string> lstKey)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nstring strKeyList;");
            strBuilder.Append("\r\nif (lstKey.Count == 0) return true;");
            strBuilder.Append("\r\nstrKeyList = \"\";");
            strBuilder.Append("\r\nfor (int i = 0; i<lstKey.Count; i++)");
            strBuilder.Append("\r\n{");
            ///				if ( (i == 0) strKeyList += "'" + lstKey[i].ToString() + "'";
            ///				else strKeyList += ", " + "'" + lstKey[i].ToString() + "'";
            if (objPrjTabENEx.arrKeyFldSet.Count == 0)
            {
                strBuilder.Append("\r\n//你的表" + objPrjTabENEx.TabName + " 中没有关键字,请你设置一个关键字!");
            }
            else
            {
                strBuilder.Append("\r\nif (i == 0) strKeyList = strKeyList + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\nelse strKeyList += \",\" + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\n}");
            }
            strBuilder.Append("\r\nstrSQL = \"\";");
            //				if ( objFKSet.GetDelFKTab != \")
            //											 {
            //												 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //					foreach(clsForeignKey objForeignKey in arrForeignKeySet)
            //					{	 
            //						strBuilder.Append("\r\nstrSQL = strSQL + \"Delete " + objFK.FKTABLE_NAME + " where " + objKeyField.ColumnName + " in (\" + strKeyList + \")"";");
            //					}
            //			}
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            if (objPrjTabENEx.arrKeyFldSet.Count == 0)
            {
                strBuilder.Append("\r\n//你的表" + objPrjTabENEx.TabName + " 中没有关键字,请你设置一个关键字!");
                strBuilder.Append("\r\nreturn false;");
            }
            else
            {
                strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + objKeyField.FldName + " in (\" + strKeyList + \")\";");
                strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL);");
            }
            strBuilder.Append("\r\n}");
            ///删除一些记录 == ;
            return strBuilder.ToString();
        }
        public override string GenDelRecord()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///删除一条记录-----------------;
            ///
            ///获取表关键字变量的定义列表串
            ///

            strBuilder.Append("\r\n" + string.Format("public static bool DelRecord({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//删除单条记录");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab != \")
            //			{
            //				strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //				strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            strTemp = string.Format("//删除{0}本表中与当前对象有关的记录",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\n return objSQL.ExecSql(strSQL);");
            strBuilder.Append("\r\n}");
            ///删除一条记录 == ;
            return strBuilder.ToString();
        }
        public override string GenDelCondRec()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除多条记录,删除带条件的记录------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除满足条件的多条记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>返回删除的记录数。</returns>");
            strBuilder.AppendFormat("\r\npublic static int Del{0}(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nif (strCondition == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;	//表示删除0条记录,实际上是不能该表的所有记录");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nint intRecoCount = objSQL.ExecSql2(strSQL);");
            strBuilder.Append("\r\nreturn intRecoCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除多条记录,删除带条件的记录 == ;
            return strBuilder.ToString();
        }
        public string GenGetRecValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一关键值的记录-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据对象的关键字值,获取对象的全部属性");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">相关对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\npublic bool Get{0}(ref cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where " + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName) + ";", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n {1} = {2}; //{0}",
                    objField.ColCaption,
                     strPrivPropNameWithObjectName4Get5EN,
                      AccessNull(objField));
            }

            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            //获取某一关键值的记录 == = ;
            return strBuilder.ToString();
        }

        public override string GenGetRecValueBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一关键值的记录-----------------------------;
            strBuilder.AppendFormat("\r\npublic bool Get{0}OneBySP(cls{0}EN obj{0})",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");

            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n " + clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName, this.IsFstLcase));
            strBuilder.Append("\r\n};");


            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectOne\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get5EN = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n {1} = {2}; //{0}",
                    objField.ColCaption,
                     strPrivPropNameWithObjectName4Get5EN,
                      AccessNull(objField));
            }

            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            //获取某一关键值的记录 == = ;
            return strBuilder.ToString();
        }

        public override string GenGetDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTable_" + objPrjTabENEx.TabName + "(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public override string GenGetDataTableBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTableByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public override string GenGetCondRecDataSetBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet Get" + objPrjTabENEx.TabName + "DataSetByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public override string GenGetDataSetByCondBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public override string GenGetDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n strSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public override string GenGetTopDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetTopDataSet_" + objPrjTabENEx.TabName + "(int intTopSize, string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.AppendFormat("\r\n strSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} {3} from {0} where {{1}}\", intTopSize, strCondition);",
        objPrjTabENEx.TabName, "{", "}", objPrjTabENEx.FieldNameLstStr);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public override string GenGetDataSetByCond_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetV(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n strSQL = \"Select * from v" + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"v{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public override string GenGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic ArrayList GetObjLst(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nArrayList arrObjLst = new ArrayList(); ");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0} = new cls{0}();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = " + AccessNull2(objField) + "; //{2}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0});",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");


            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public override string GenGetObjLstBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic ArrayList GetObjLstBySP(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nArrayList arrObjLst = new ArrayList(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0} = new cls{0}();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = " + AccessNull2(objField) + "; //{2}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0});",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");


            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public override string GenGetFirstCondRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirst{0}(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strBuilder.Append(Gen_4BL_GC_GetObjFromDataRow());
            strBuilder.AppendFormat("\r\n" + "obj{0}.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nreturn obj{0};", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public override string GenGetFirstCondRecObjBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirst{0}BySP(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectTop1ByCond\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strBuilder.Append(Gen_4BL_GC_GetObjFromDataRow());
            strBuilder.AppendFormat("\r\n" + "obj{0}.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nreturn obj{0};", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public override string GenGetDataTableT_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件的DataTable,其中的代码转换成相应的名称------------------------;
            if (objPrjTabENEx.IsNeedTransCode)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n");
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 功能:获取某一条件的DataTable,其中的代码转换成相应的名称");
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
                strBuilder.Append("\r\n /// <returns>返回已经转换代码的DataTable</returns>");
                strBuilder.AppendFormat("\r\npublic static System.Data.DataTable Get{0}T(string strCondition)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
                strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

                strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
                strBuilder.Append("\r\n //获取连接对象");
                strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\nstrSQL.Append(\"Select {0}.* \");", objPrjTabENEx.TabName);
                bool bolIsFirst;
                StringBuilder sbTabName = new StringBuilder();
                StringBuilder sbWhereStr = new StringBuilder();
                StringBuilder sbFldStr = new StringBuilder();
                StringBuilder sbLeftJoinStr = new StringBuilder();
                bool bolIsSelfLink = false;
                bolIsFirst = true;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.ObjFieldTab4CodeConv() != null)
                    {
                        if (objPrjTabENEx.TabId == objField.ObjFieldTab4CodeConv().CodeTabId)
                        {
                            bolIsSelfLink = true;
                        }
                        else
                        {
                            bolIsSelfLink = false;
                        }
                        if (bolIsFirst)
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" from {0}, {1}\");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" where {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabCode);
                            bolIsFirst = false;
                        }
                        else
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" , {0} \");",
                           objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" && {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        if (bolIsSelfLink == true)
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}Self.{1} {2}{3} \");",
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} {2}Self on {0}.{1} = {2}Self.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        else
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}.{1} {2}{3} \");",
                           objField.ObjFieldTabENEx.CodeTabName,
                           objField.ObjFieldTabENEx.CodeTabName,
                           objField.ObjFieldTabENEx.CodeTabName,
                           objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} on {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabCode);
                        }
                    }
                }

                strBuilder.Append(sbFldStr.ToString());
                strBuilder.AppendFormat("\r\nstrSQL.Append(\" from {0} \");",
                objPrjTabENEx.TabName);
                strBuilder.Append(sbLeftJoinStr.ToString());
                /// strBuilder.Append(sbTabName.ToString());
                /// strBuilder.Append(sbWhereStr.ToString());
                strBuilder.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
                strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
                strBuilder.Append("\r\nreturn objDT;");
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            ///获取某一条件的DataTable,其中的代码转换成相应的名称 == ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// 从视图(SQL View)中获取信息生成 = >DataTable
        /// </summary>
        /// <returns></returns>
        public override string GenGetDataTableV_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件的相关表视图(View)------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取某一条件的相关表视图(View)");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回已经转换代码的DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic static System.Data.DataTable Get{0}V(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取某一条件的DataTable,其中的代码转换成相应的名称 == ;
            return strBuilder.ToString();
        }


        public override string GenGetPrimaryKeyID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件的关键字列表-----------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取某一条件的关键字列表");
            strBuilder.Append("\r\n ///		 如果表关键字是多个,则多个关键字之间用\"//\"隔开");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>关键字列表</returns>");
            strBuilder.Append("\r\npublic static ArrayList GetPrimaryKeyID(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");
            strBuilder.Append("\r\nArrayList arrList = new ArrayList();");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from {1} where \" + strCondition;",
            objKeyField.FldName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				clsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				objDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfor (iRow = 0; iRow<= objDT.Rows.Count - 1;iRow++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue = \"\";");
            strBuilder.Append("\r\nfor (iCol = 0; iCol<= objDT.Columns.Count - 1;iCol++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (iCol == 0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue += objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue += \"//\" + objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\narrList.Add(strKeyValue);");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取某一条件的关键字列表 == = ;
            return strBuilder.ToString();
        }

        public override string GenStoreFileToTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:存储文件。把文件存储到数据库表字段中。");
            strBuilder.Append("\r\n ///		说明:表记录条件为当前对象所对应的记录。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strUpLoadFileName\">所要存储的文件名</param>");
            strBuilder.Append("\r\n /// <returns>如果成功就返回TRUE,否则返回FALSE</returns>");
            strBuilder.Append("\r\npublic bool StoreFileToTabField(string strUpLoadFileName)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", objPrjTabENEx.ImageFieldName);
            strBuilder.Append("\r\nStringBuilder strCondition = new StringBuilder();");
            strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
            strBuilder.AppendFormat("{0}", objKeyField.FldName);
            strBuilder.Append(" = '{0}'\", ");
            strBuilder.AppendFormat("{0});", clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName, this.IsFstLcase));
            strBuilder.Append("\r\nSpecData.clsSpecSQLforMySql objSQL = new SpecData.clsSpecSQLforMySql();");
            strBuilder.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.ToString());");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public override string GenGetDataTable_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一SQL串的DataTable---------------------------;

            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTable(string strSql)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSql);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///获取某一SQL串的DataTable == ;
            return strBuilder.ToString();
        }
        public override string GenIsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strBuilder.Append("\r\npublic bool IsExist()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr() + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///在数据库中是否存在当前对象 == ;
            return strBuilder.ToString();
        }
        public override string GenIsExistBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strBuilder.AppendFormat("\r\npublic static bool IsExistBySP({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objField.ObjFieldTabENEx.PrivFuncName + ");");
            }
            strBuilder.Append("\r\n" + "string strIsExist = \"\";");
            strBuilder.Append("\r\n" + "values.Add(strIsExist);");
            strBuilder.AppendFormat("\r\n" + "ArrayList arrReturn = objSQL.ExecSpWithOutPut(\"{0}_IsExist\", values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (arrReturn[0].ToString() == \"1\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///在数据库中是否存在当前对象 == ;
            return strBuilder.ToString();
        }
        public override string GenIsExist_S()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象(共享过程函数)-----------------------;
            ///objField.ObjFieldTabENEx.PrivFuncName;
            int i = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {

                if (i == 0) //是否是第一次
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else
                {
                    strTemp += ", " + objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                i++;
            }
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 判断当前表中是否存在给定关键字值的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回是否存在?</returns>");

            strBuilder.Append("\r\npublic static bool IsExist(" + strTemp + ")");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr(false) + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///在数据库中是否存在当前对象(共享过程函数) == ;
            return strBuilder.ToString();
        }
        public override string GenIsExistCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:判断是否存在某一条件的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>");
            strBuilder.Append("\r\npublic static bool IsExistCondRec(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

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


        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public override string GenGetFirstID()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");

            strBuilder.AppendFormat("\r\npublic {0} GetFirstID(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\nArrayList arrList = new ArrayList();");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");

            ;
            strBuilder.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");

            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "int":
                    strBuilder.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strBuilder.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strBuilder.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strBuilder.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strBuilder.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strBuilder.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strBuilder.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public override string GenGetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");

            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\nArrayList arrList = new ArrayList();");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nLogErrorS(objException, \"cls{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");
            }
            else
            {
                strBuilder.AppendFormat("\r\nreturn new cls{0}DA()." + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";",
                objPrjTabENEx.TabName);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");

            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "int":
                    strBuilder.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strBuilder.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strBuilder.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strBuilder.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strBuilder.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strBuilder.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strBuilder.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }


        public override string GenGetReader()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic System.Data.SqlClient.SqlDataReader GetReader(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataReader objDR ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + string.Format("strSQL = \"Select {1} from {0} where \" + strCondition;", objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr));
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
        public override string GenGetTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTable(根据条件获取数据表);
            strBuilder.Append("\r\npublic DataTable GetTable(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            /// 
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public override string GenGetTableBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTableBySQL(根据SQL语句获取数据表)----------------------------------;
            strBuilder.Append("\r\npublic DataTable GetTableBySQL(string strSQL) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///GetTableBySQL(根据SQL语句获取数据表) == = ;
            ///公共过程END == = ;
            return strBuilder.ToString();
        }


        public override string GenComboBoxBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                    strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						if (objField.DsCondStr.Trim() == "")
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    //						}
                    strCodeForCs.Append("\r\n" + "clsSpecSQLforMySql mySql = new clsSpecSQLforMySql();");
                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objDT;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Win的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objComboBox\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源为表的下拉框设置内容");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                    strValueFieldName);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0};",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"0\";",
                    objPrjTabENEx.TabName, strValueFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"选[{2}]...\";",
              objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");
                    strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
                     objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
                     objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
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
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}DA", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
