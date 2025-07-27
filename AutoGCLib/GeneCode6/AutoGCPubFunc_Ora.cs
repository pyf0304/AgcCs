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

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Reflection;
using System.Collections.Generic;

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
    class AutoGCPubFunc_Ora : clsGeneCodeBase4Tab
    {
       

        #region 构造函数


        public AutoGCPubFunc_Ora(string strTabId,  string strPrjDataBaseId, string strPrjId)
          : base(strTabId,  strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion

      
        public override string GenSQLCode( string strPrjDataBaseId)
        {
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
                    strRemark = "/**" + strRemark0 + " **/";

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

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
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
            //clsSpecSQLforOra objSQL = null;
            //objSQL = new clsSpecSQLforOra(objProjects.ConnectString); 
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

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
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
            //clsSpecSQLforOra objSQL = null;
            //objSQL = new clsSpecSQLforOra(objProjects.ConnectString); 
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

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
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
            //clsSpecSQLforOra objSQL = null;
            //objSQL = new clsSpecSQLforOra(objProjects.ConnectString); 
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

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
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

            strCodeForCs.AppendFormat("\r\n" + "Select * from {0} ",
            objPrjTabENEx.TabName);
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
            //clsSpecSQLforOra objSQL = null;
            //objSQL = new clsSpecSQLforOra(objProjects.ConnectString); 
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

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
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

            strCodeForCs.AppendFormat("\r\n" + "Select * from {0} ",
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
            //clsSpecSQLforOra objSQL = null;
            //objSQL = new clsSpecSQLforOra(objProjects.ConnectString); 
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

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
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

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
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
            //clsSpecSQLforOra objSQL = null;
            //objSQL = new clsSpecSQLforOra(objProjects.ConnectString); 
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

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
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

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select * from {0} ';",
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
            //clsSpecSQLforOra objSQL = null;
            //objSQL = new clsSpecSQLforOra(objProjects.ConnectString); 
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

            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--== == == == == == == == == == == == == == == == == == == == == == = ");
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
            //clsSpecSQLforOra objSQL = null;
            //objSQL = new clsSpecSQLforOra(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public override string GenSQLCode4CreateTab(string strPrjDataBaseId)
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
                    strRemark = "/**" + strRemark0 + " **/";

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


        public  string GenAddNewRecord()
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
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.OracleClient.OracleDataAdapter objDA ; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.OracleClient.OracleCommandBuilder objCB ; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            /// Dim objSQL As new IKData.SQLServer();
            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where 1 = 2\";");
            strBuilder.Append("\r\nobjDA = new System.Data.OracleClient.OracleDataAdapter(strSQL, objSQL.OracleConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.OracleClient.OracleCommandBuilder(objDA);");
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
                        strBuilder.AppendFormat("\r\n if ({0} != \"\")", strPrivPropNameWithObjectName);
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
                    strBuilder.AppendFormat("\r\n if ({0} != \"\")", strPrivPropNameWithObjectName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = {3}; //{0}",
                      objField.ColCaption,
                      objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                    strPrivPropNameWithObjectName);
                    strBuilder.Append("\r\n }");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = {3}; //{0}",
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
        public  string GenAddNewRecordBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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

        public  string GenAddNewRecordBySQL2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
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

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }
        public  string GenAddNewRecordBySQL2WithReturnKey()
        {
            List<string> arrPrimaryTypeId = new List<string>() { enumPrimaryType.Identity_02, enumPrimaryType.StringAutoAddPrimaryKey_03, enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06 };
            if (arrPrimaryTypeId.Contains( objKeyField.PrimaryTypeId ) == false) return "";
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\npublic string AddNewRecordBySQL2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
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
            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\n strSQL.Append(\" select @@identity;\");");
            }
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int"
                     || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bigint")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();");
            }
            else
            {
                strBuilder.Append("\r\n objSQL.ExecSql(strSQL.ToString());");
                strBuilder.AppendFormat("\r\nreturn obj{0}EN.{1};", objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }


        public  string GenAddNewRecordBySQL2WithReturnKeyAndTransaction()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\npublic string AddNewRecordBySQL2WithReturnKey(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
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
            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\n strSQL.Append(\" select @@identity;\");");
            }
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString(), objOracleConnection, objOracleTransaction).Rows[0][0].ToString();");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int" 
                || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bigint")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString(), objOracleConnection, objOracleTransaction).Rows[0][0].ToString();");
            }
            else
            {
                strBuilder.Append("\r\n  objSQL.ExecSql(strSQL.ToString(), objOracleConnection, objOracleTransaction);");
                strBuilder.AppendFormat("\r\nreturn obj{0}EN.{1};", objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public  string GenAddNewRecordBySQLWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录.(带事务处理)");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objOracleConnection, objOracleTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public  string GenAddNewRecordBySQLWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
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

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objOracleConnection, objOracleTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public  string GenAddnewRecBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过存储过程来插入记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加到数据库中的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");

            string strTemp = string.Format("public bool Addnew{0}BySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName4Get);
                    continue;
                }
                strBuilder.AppendFormat("\r\nvalues.Add({0});",
                    strPrivPropNameWithObjectName);
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Add\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == == ;
            return strBuilder.ToString();
        }

        public  string GenUpdateBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过存储过程(StoreProcedure)来修改记录");
            strBuilder.Append("\r\n /// /// 缺点:1、不能支持事务处理.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            string strTemp = string.Format("public bool Update{0}BySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.FldOpTypeId == "0003")
                {
                    strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName4Get);
                    continue;
                }

                strBuilder.AppendFormat("\r\nvalues.Add({0});",
                    strPrivPropNameWithObjectName);
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Update\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == == ;
            return strBuilder.ToString();
        }

        public  string GenDelRecordBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除当前对象所指的记录,通过存储过程来实现");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");

            string strTemp = string.Format("public bool DelRecordBySP() ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objKeyField in objPrjTabENEx.arrKeyFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objKeyField, "obj" + objPrjTabENEx.TabName + "EN");

                strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName4Get );
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == == ;
            return strBuilder.ToString();
        }


        public  string GenDelRecordBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            string strTemp = string.Format("public static bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}DA.CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///public bool Addnew {TabName}BySP() == == ;
            return strBuilder.ToString();
        }
        public  string GenAddnewMultiRec()
        {

            StringBuilder strBuilder = new StringBuilder();
            ///添加多条新记录---------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把多条记录同时插入到表中!");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"oDT\"></param>");
            strBuilder.Append("\r\n /// <param name = \"strResult\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            string strTemp = string.Format("public bool Addnew{0}s(System.Data.DataTable oDT, ref string strResult) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nSystem.Data.OracleClient.OracleDataAdapter objDA;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.OracleClient.OracleCommandBuilder objCB; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow;");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + objKeyField.FldName + " = '111'\";");
            strBuilder.Append("\r\nobjDA = new System.Data.OracleClient.OracleDataAdapter(strSQL, objSQL.OracleConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.OracleClient.OracleCommandBuilder(objDA);");
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
                        strTT = string.Format("oRow[cls{1}EN.con_{0}].ToString().Trim()",
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
                    strBuilder.Append("\r\nstrResult = \"关键字变量值为:\" + " + strKeyVarValueLst + " + \"的记录已存在,不能重复插入!\" ;");
                    strBuilder.Append("\r\nreturn false;");
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
                strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = oRow[cls{1}EN.con_{2}].ToString().Trim(); //{0}",
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
            
            
            
            
            strBuilder.Append("\r\nobjSQL.OracleConnect.Close();");
            
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///添加多条新记录 == == == = ;
            return strBuilder.ToString();
        }
        public  string GenUpdate()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:修改记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改到数据库中的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool Update(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.OracleClient.OracleDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\n System.Data.OracleClient.OracleCommandBuilder objCB ;");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where {1};",
            objPrjTabENEx.TabName, KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN"));
            strBuilder.Append("\r\nobjDA = new System.Data.OracleClient.OracleDataAdapter(strSQL, objSQL.OracleConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.OracleClient.OracleCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, cls{0}EN._CurrTabName);",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nif (objDS.Tables[cls{0}EN._CurrTabName].Rows.Count == 0)",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//MsgBox(\"没有相应的ID号:" + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN") + ");");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nobjRow = objDS.Tables[cls{0}EN._CurrTabName].Rows[0];",
                  objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //if ((objField.Is1Identity == false) && (objField.FieldTypeId != enumFieldType.KeyField_02))
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
                    strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
                  objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = {3}; //{0}",
                      objField.ColCaption,
                      objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                    strPrivPropNameWithObjectName4Get);
                    strBuilder.Append("\r\n }");
                    continue;
                }

                strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
                objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = {3}; //{0}",
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

        public  string GenUpdateBySql()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //if ((objField.Is1Identity == false) && (objField.FieldTypeId != enumFieldType.KeyField_02))
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

        public  string GenUpdateBySqlWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
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

        public  string GenUpdateBySqlWithConditionTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySqlWithConditionTransaction(cls{0}EN obj{0}EN, string strCondition, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
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
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objOracleConnection, objOracleTransaction);");
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


        public  string GenUpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            ///
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

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
        
        public  string GenUpdateBySqlWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、支持事务处理.");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// /// 2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
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
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objOracleConnection, objOracleTransaction);");
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

        public  string GenUpdateBySqlWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// /// 3、支持事务处理.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
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
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objOracleConnection, objOracleTransaction);");
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


        public  string GenUpdateMultiRec()
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
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("UpdateMultiRec", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "修改多条记录出错,请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:UpdateMultiRec)\", objException.Message));",
                objPrjTabENEx.TabName,
                objPrjTabENEx.ClsName,
                "{", "}",
                strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.OracleClient.OracleDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.OracleClient.OracleCommandBuilder objCB ;");
            strBuilder.Append("\r\n//			System.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount;");
            strBuilder.Append("\r\nif (strCondition == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0; //表示删除0条记录,实际上是不能该表的所有记录");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where \" + strCondition;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjDA = new System.Data.OracleClient.OracleDataAdapter(strSQL, objSQL.OracleConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.OracleClient.OracleCommandBuilder(objDA);");
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
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if ((objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY) && (objField.FieldTypeId == enumFieldType.KeyField_02))
                {
                    continue;
                }
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
        public  string GenGetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取表中的记录数---------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数.该表与当前类相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\n public static int GetRecCount()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.GetRecCount(cls{0}EN._CurrTabName);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public  string GenGetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数, 该表与当前类不相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public  string GenGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\n public static int GetRecCountByCond(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.GetRecCount(cls{0}EN._CurrTabName, strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public  string GenGetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCountByCond(string strTabName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 == == == ;
            return strBuilder.ToString();
        }
        public  string GenfunSetFldValue4String()
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
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");



            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, strValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public  string GenfunSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, fltValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public  string GenfunSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, intValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public  string GenfunSetFldValue4String_S()
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
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, strValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public  string GenfunSetFldValue4Int_S()
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
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, intValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public  string GenfunSetFldValue4Float_S()
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
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public  string GenGetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表中的符合条件的某字段的值,以列表返回");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic List<string> GetFldValue(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n List<string> arrList = objSQL.GetFldDataOfTable(\"{0}\", strFldName, strCondition);",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public  string GenGetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中的符合条件的某字段的值,以列表返回");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///设置/获取表中的符合条件的某字段的值 == = ;
            return strBuilder.ToString();
        }
        public  string GenDelRecordBak()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\npublic bool DelRecord() ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///删除记录 == = ;
            return strBuilder.ToString();
        }

        public override string Gen_GetSpecSQLObj()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取SQL服务器连接对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforOra GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");

            strBuilder.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforOra();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforOra(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }
        public override string Gen_GetSpecSQLObj_Obj()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取SQL服务器连接对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strBuilder.Append("\r\n public clsSpecSQLforOra GetSpecSQLObj_Obj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //1. 如果当前对象有指定的连接串,就用对象连接串");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj) == false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(this.ConnectString_Obj);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //3. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //4. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}EN._ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n objSQL = new clsSpecSQLforOra(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }


        public override string Gen_GetSpecSQLObjV5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取SQL服务器连接对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforOra GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");

            strBuilder.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforOra();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforOra(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }
        public override string Gen_GetSpecSQLObj_ObjV5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取SQL服务器连接对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strBuilder.Append("\r\n public clsSpecSQLforOra GetSpecSQLObj_Obj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //1. 如果当前对象有指定的连接串,就用对象连接串");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj) == false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(this.ConnectString_Obj);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysPara.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(clsSysPara.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //3. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //4. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}.ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n objSQL = new clsSpecSQLforOra(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }


        public override string Gen_GetSpecSQLObj5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取SQL服务器连接对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforOra GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");

            strBuilder.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysPara.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(clsSysPara.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}.ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforOra();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforOra(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }
        public override string Gen_GetSpecSQLObj_Obj5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取SQL服务器连接对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strBuilder.Append("\r\n public clsSpecSQLforOra GetSpecSQLObj_Obj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //1. 如果当前对象有指定的连接串,就用对象连接串");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj) == false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(this.ConnectString_Obj);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysPara.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(clsSysPara.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //3. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //4. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}.ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n objSQL = new clsSpecSQLforOra(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }

        public override string GenDelRecordWithTransaction()
        {

            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:当前对象所指的记录.(带事务处理)");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>返回删除是否成功?。</returns>");

            strBuilder.Append("\r\npublic bool DelRecord(OracleConnection objOracleConnection, OracleTransaction objOracleTransaction) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab != \")
            //										 {
            //											 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objOracleConnection, objOracleTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }
        public override string GenDelRecordWithTransactionBak()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指的记录,使用事务");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>返回删除是否成功?。</returns>");
            strBuilder.AppendFormat("\r\npublic static bool DelRecord({0}, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction) ",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}DA.CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab != \")
            //										 {
            //											 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objOracleConnection, objOracleTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }

        public override string GenDelMultiRec()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除一些记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:同时删除多条记录,删除给定关键字列表的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lstKey\">给定的关键字值列表</param>");
            strBuilder.Append("\r\n /// <returns>返回删除是否成功?</returns>");
            string strTemp = string.Format("public static bool Del{0}(List<string> lstKey)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///删除一些记录 == = ;
            return strBuilder.ToString();
        }
        public override string GenDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除一条记录-----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.Append("\r\n" + string.Format("public static bool DelRecord({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strBuilder.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}DA.CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strBuilder.Append("\r\n//删除单条记录");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab != \")
            //			{
            //				strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //				strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            string strTemp = string.Format("//删除{0}本表中与当前对象有关的记录",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\n return objSQL.ExecSql(strSQL);");
            strBuilder.Append("\r\n}");
            ///删除一条记录 == = ;
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
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("Del{0}", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "删除满足条件的多条记录出错,请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Del{0})\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///删除多条记录,删除带条件的记录 == = ;
            return strBuilder.ToString();
        }

        public override string GenDelCondRecWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除多条记录,删除带条件的记录------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除满足条件的多条记录,同时处理事务");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>返回是否删除成功。</returns>");
            strBuilder.AppendFormat("\r\npublic static bool Del{0}WithTransaction_S(string strCondition, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("Del{0}WithTransaction_S", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "删除满足条件的多条记录,同时处理事务出错,请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Del{0}WithTransaction_S)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nif (strCondition == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;	//表示删除0条记录,实际上是不能该表的所有记录");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n bool bolResult = objSQL.ExecSql(strSQL, objOracleConnection, objOracleTransaction);");
            strBuilder.Append("\r\nreturn bolResult;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除多条记录,删除带条件的记录 == = ;
            return strBuilder.ToString();
        }


        public  string GenGetRecValue()
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

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN") + ";");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
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
            //获取某一关键值的记录 == == = ;
            return strBuilder.ToString();
        }

        public string Gen_GetObjByKeyId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            //获取某一关键值的记录-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");
            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetObjBy{1}({2})",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}DA.CheckPrimaryKey_Sim({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
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
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"获取当前关键字的记录对象时,发生:{{0}},请检查!({1}: GetObjBy{0})\", objException.Message));",
                 objKeyField.FldName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            //获取某一关键值的记录 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetRecValueBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一关键值的记录-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程{0}_SelectOne来获取。", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加到数据库中的对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\npublic bool Get{0}OneBySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            //获取某一关键值的记录 == == = ;
            return strBuilder.ToString();
        }


        public override string GenGetDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTable_" + objPrjTabENEx.TabName + "(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("Get{0}", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查,请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
                objPrjTabENEx.TabName,
                objPrjTabENEx.ClsName,
                "{", "}",
                strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "(string strCondition, List<string> lstExclude)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strFunctionName = string.Format("Get{0}(string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查,请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
               objPrjTabENEx.TabName,
               objPrjTabENEx.ClsName,
               "{", "}",
               strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "(string strCondition, bool bolIsCheckSQLAttack)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strFunctionName = string.Format("Get{0}(string strCondition, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击,请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 "{", "}",
                 strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetDataTableByRange_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取一定范围数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTableByRange(string strCondition, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("Get{0}ByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "根据条件获取一定范围数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查,请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTableByRange)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                   "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTableByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strFunctionName = string.Format("GetDataTableByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0}ByRange)\", objException.Message));",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 "{", "}",
                 strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTableByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            strFunctionName = string.Format("Get{0}ByRangeByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0}ByRange)\", objException.Message));",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 "{", "}",
                 strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetDataTableByRangeV_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取一定范围数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "VByRange(string strCondition, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("Get{0}VByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0}VByRange)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                   "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "VByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strFunctionName = string.Format("Get{0}VByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0}VByRange)\", objException.Message));",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 "{", "}",
                 strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "VByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strFunctionName = string.Format("Get{0}V(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0}VByRange)\", objException.Message));",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 "{", "}",
                 strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
               "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetDataTableBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTableByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("Get{0}ByCondBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0}ByCondBySP)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }
        public override string GenGetCondRecDataSetBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回数据表DataSet</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet Get" + objPrjTabENEx.TabName + "DataSetByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("Get{0}DataSetByCondBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");


            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0}DataSetByCondBySP)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }
        public override string GenGetDataSetByCondBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查,用存储过程来获取。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByCondBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0}ByCondBySP)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }
        public override string GenGetDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSet", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSet)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n strSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetDataSetByCondByRange_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取一定范围数据集,DataSet,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetByRange(string strCondition, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                   "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取一定范围的数据集,DataSet,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            strFunctionName = string.Format("GetDataSetByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 "{", "}",
                 strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");



            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取一定范围内的数据集,DataSet,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            strFunctionName = string.Format("GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");



            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\n System.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
              "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");



            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }


        public override string GenGetDataSetByCond_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取当前表视图的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetV(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetV", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSetV)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n strSQL = \"Select * from v" + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"v{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetDataSetByCondByRange_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取当前表视图的一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetVByRange(string strCondition, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                   "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetVByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            strFunctionName = string.Format("GetDataSetVByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 "{", "}",
                 strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");



            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetVByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n   if (intMinNum <= 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            strFunctionName = string.Format("GetDataSetVByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0})\", objException.Message));",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 "{", "}",
                 strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
              "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");



            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic List<cls{0}EN> GetObjLst(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLst", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:GetObjLst)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"在根据条件获取对象列表时,发生:{{0}},请检查!({1}: GetObjLst)\", objException.Message));",
          objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetObjLstByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic List<cls{0}EN> GetObjLst(string strCondition, string strTabName)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLst", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:GetObjLst)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL = string.format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"在根据条件获取对象列表时,发生:{{0}},请检查!({1}: GetObjLst)\", objException.Message));",
          objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetObjLstBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件用SP获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic List<cls{0}EN> GetObjLstBySP(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLstBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "根据条件用SP获取对象列表出错,请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:GetObjLstBySP)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"根据条件用SP获取对象列表时,发生:{{0}},请检查!({1}: GetObjLstBySP)\", objException.Message));",
          objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetFirstCondRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取第一条满足条件的记录,以对象形式表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件的第一个对象</returns>");
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirst{0}(string strCondition)",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetFirst{0}", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetFirst{0})\", objException.Message));",
                objPrjTabENEx.TabName,
                objPrjTabENEx.ClsName,
                "{", "}",
                strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nDataRow objRow = objDT.Rows[0];");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append(Gen_4BL_GC_GetObjFromDataRow());
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"在根据条件获取第一个对象时,发生:{{0}},请检查!({1}: GetFirst{0})\", objException.Message));",
          objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == == = ;
            return strBuilder.ToString();
        }

        public override string GenGetFirstCondRecObjBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通过SP获取第一条满足条件的记录,以对象形式表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件的第一个对象</returns>");
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirst{0}BySP(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetFirst{0}BySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "通过SP获取第一条满足条件的记录,以对象形式表示,请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:GetFirst{0}BySP)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);

            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == == = ;
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
                strBuilder.Append("\r\ntry");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
                strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\ncatch (Exception objException)");
                strBuilder.Append("\r\n{");

                string strFunctionName = string.Format("Get{0}T", objPrjTabENEx.TabName, objKeyField.FldName);
                string strExplanation = "获取某一条件的DataTable,其中的代码转换成相应的名称,请检查!";
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

                strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:Get{0}T)\", objException.Message));",
                      objPrjTabENEx.TabName,
                      objPrjTabENEx.ClsName,
                      "{", "}",
                      strErrId);
                strBuilder.Append("\r\n}");

                strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
                strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

                strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
                            objPrjTabENEx.TabName, 
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" where {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, 
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                            bolIsFirst = false;
                        }
                        else
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" , {0} \");",
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" && {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, 
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
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
            ///获取某一条件的DataTable,其中的代码转换成相应的名称 == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// 从视图(SQL View)中获取信息生成 == >DataTable
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
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("Get{0}V", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "获取某一条件的相关表视图(View),请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Get{0}V)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);

            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取某一条件的相关表视图(View)");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.Append("\r\n /// <returns>返回已经转换代码的DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic static System.Data.DataTable Get{0}V(string strCondition, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strFunctionName = string.Format("Get{0}V(string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "获取某一条件的相关表视图(View),请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
             objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:Get{0}V)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///获取某一条件的DataTable,其中的代码转换成相应的名称 == = ;
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
            strBuilder.Append("\r\npublic static List<string> GetPrimaryKeyID(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");
            strBuilder.Append("\r\nList<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///获取某一条件的关键字列表 == == == ;
            return strBuilder.ToString();
        }
        public override string GenGetFileFromTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///上传文件以及下载文件相关代码------------------------------------ ;
            if (objPrjTabENEx.IsHaveImageField == true)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 功能:从数据库表字段中获取内容,并且存放在文件中。");
                strBuilder.Append("\r\n ///		说明:表记录条件为当前对象所对应的记录。");
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <param name = \"strDownLoadFileName\">获取内容后,所存了的文件名。</param>");
                strBuilder.Append("\r\n /// <returns>如果成功获取就返回TRUE,否则为FALSE</returns>");
                strBuilder.Append("\r\npublic bool GetFileFromTabField(string strDownLoadFileName)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nSpecData.clsSpecSQLforOra objSQL = new SpecData.clsSpecSQLforOra();");
                strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", objPrjTabENEx.ImageFieldName);
                strBuilder.Append("\r\nStringBuilder strCondition = new StringBuilder();");
                /// strBuilder.Append("\r\nstrCondition.AppendFormat(\"Stdid = '{0}'\", objPrjTabENEx.Stdid);");
                strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
                strBuilder.AppendFormat("{0}", objKeyField.FldName);
                strBuilder.Append(" = '{0}'\", ");
                strBuilder.AppendFormat("{0});", clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
                strBuilder.Append("\r\nobjSQL.GetFile(strDownLoadFileName,strTabName, strFldName, strCondition.ToString());");
                strBuilder.Append("\r\nreturn true;");
                strBuilder.Append("\r\n}");
            }
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
            strBuilder.AppendFormat("{0});", clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
            strBuilder.Append("\r\nSpecData.clsSpecSQLforOra objSQL = new SpecData.clsSpecSQLforOra();");
            strBuilder.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.ToString());");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public override string GenShowPic_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:显示图片。显示与关键字相关记录的图片");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"imgPic\">需要显示图片的image控件</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">记录关键字的值</param>",
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"strWebFileDir\">用于WEB显示的文件路径,即URL</param>");
            strBuilder.Append("\r\n /// <param name = \"strDownloadFileDir\">用于下载文件时,在WEB服务器上文件的目录</param>");
            strBuilder.Append("\r\npublic static void ShowPic(System.Web.UI.WebControls.Image imgPic, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\nstring strWebFileDir, ");
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nimgPic.ImageUrl = \"\";");
            strBuilder.AppendFormat("\r\nif (cls{0}BL.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}EN.FileName;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}EN.GetFileFromTabField(strDownLoadFileName);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nimgPic.ImageUrl = strWebFileDir + strFileName;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public override string GenGetFileFromTabField_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:从数据库表字段中下载文件内容。该函数是静态(static)函数。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strDownLoadFileName\">返回下载的文件名</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">记录关键字的值</param>",
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"strDownloadFileDir\">用于下载文件时,在WEB服务器上文件的目录</param>");
            strBuilder.Append("\r\npublic static bool GetFileFromTabField(ref string strDownLoadFileName, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nif (cls{0}BL.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}EN.FileName;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}EN.GetFileFromTabField(strDownLoadFileName);",
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
        public override string GenGetDataTable_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一SQL串的DataTable---------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据Sql语句获取DataTable");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strSql\">Sql语句</param>");
            strBuilder.Append("\r\n /// <returns>返回用于绑定下拉框的DataTable</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTable(string strSql)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSql);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///获取某一SQL串的DataTable == == ;
            return strBuilder.ToString();
        }
        public override string GenIsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strBuilder.Append("\r\npublic bool IsExist()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///在数据库中是否存在当前对象 == == ;
            return strBuilder.ToString();
        }
        public override string GenIsExistBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 判断当前表中是否存在给定关键字值的记录, 用存储过程来获取");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回是否存在?</returns>");
            strBuilder.AppendFormat("\r\npublic static bool IsExistBySP({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}DA.CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///在数据库中是否存在当前对象 == == ;
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
            if (objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                {
                    strBuilder.AppendFormat("\r\n" + "cls{0}DA.CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
                }
            }
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///在数据库中是否存在当前对象(共享过程函数) == == ;
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

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("IsExistCondRec", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "判断是否存在某一条件的记录出错,请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:IsExistCondRec)\", objException.Message));",
                  objPrjTabENEx.TabName,
                  objPrjTabENEx.ClsName,
                  "{", "}",
                  strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
  
  
    


        public override string GenGetPrimaryKeyID()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的所有记录的关键字值列表");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的关键字值列表</returns>");

            strBuilder.Append("\r\npublic List<string> GetID(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\nList<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            //			strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"+ " + KeyWhereStr(true) + "))");
            //			strBuilder.Append("\r\nreturn arrList;");
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
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }


        public override string GenGetMaxStrID()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表最大字符型关键字ID");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>返回的最大关键字值ID</returns>");
            strBuilder.Append("\r\npublic static string GetMaxStrId()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n//获取连接对象");
            strBuilder.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strMaxValue = objSQL.GetMaxStrId(cls{0}EN._CurrTabName, cls{0}EN.con_{1}, {2}, \"\");",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.Append("\r\nreturn strMaxValue;");
            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        public override string GenIsExistTable()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查是否存在当前表");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>存在就返回True,否则返回False</returns>");
            strBuilder.Append("\r\npublic static bool IsExistTable()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n//获取连接对象");
            strBuilder.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nbool bolIsExist = objSQL.IsExistTable(\"{0}\");",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn bolIsExist;");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查是否存在给定表");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">给定表</param>");
            strBuilder.Append("\r\n /// <returns>存在就返回True,否则返回FalseD</returns>");
            strBuilder.Append("\r\npublic static bool IsExistTable(string strTabName)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n//获取连接对象");
            strBuilder.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nbool bolIsExist = objSQL.IsExistTable(strTabName);",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn bolIsExist;");
            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
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
            strBuilder.Append("\r\n List<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\nreturn \"\";");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strBuilder.Append("\r\nreturn 0;");
            }
            else
            {
                strBuilder.AppendFormat("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";",
                objPrjTabENEx.TabName);
            }
            //strBuilder.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");

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
            strBuilder.Append("\r\n List<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            //{
            // strBuilder.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");
            //}
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\nreturn \"\";");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strBuilder.Append("\r\nreturn 0;");
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
            strBuilder.Append("\r\npublic System.Data.OracleClient.SqlDataReader GetReader(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.OracleClient.SqlDataReader objDR ;");

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + string.Format("strSQL = \"Select * from {0} where \" + strCondition;", objPrjTabENEx.TabName));
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

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
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

            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
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
            ///GetTableBySQL(根据SQL语句获取数据表) == == == ;
            ///公共过程END == == == ;
            return strBuilder.ToString();
        }
 
        public override string GenComboBoxBindFunction5()
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
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <returns>返回用于绑定下拉框的DataTable</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
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

                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforOra mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

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


                    strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0};",
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

                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                   objPrjTabENEx.TabName);
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
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <returns>返回用于绑定下拉框的DataTable</returns>");
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

                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforOra mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

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


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                    objPrjTabENEx.TabName, strValueFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"选[{2}]...\";",
              objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");
                    strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");

                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                   objPrjTabENEx.TabName);
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
 
      
        private string GetCode4FieldInUpdateBySqlWithCondition(clsPrjTabFldENEx objField, ref bool bolIsFirst)
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
                sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
            objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                sbCodeForCs.Append("\r\n {");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "bool":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\",{4} == true?\"1\":\"0\"); //{2}",
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
                                sbCodeForCs.AppendFormat("\r\n if ({0} == \"\")",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n {");
                                sbCodeForCs.AppendFormat("\r\n {0} = null;",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n }");
                            }
                            sbCodeForCs.AppendFormat("\r\n if ({0} != null)",
                            strPrivPropNameWithObjectName4Get);
                            sbCodeForCs.Append("\r\n {");
                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                strPrivPropNameWithObjectName4Get,
                                strPrivPropNameWithObjectName4Get
                               );
                            }
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName ,
                              strPrivPropNameWithObjectName4Get );
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
                     strPrivPropNameWithObjectName4Get );
                }
                sbCodeForCs.Append("\r\n }");

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
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
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}',\",{4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldName,
                        strPrivPropNameWithObjectName);
                        break;
                    default:
                        if (objField.IsTabForeignKey == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n if ({0} == \"\")",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n {0} = null;",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }
                        sbCodeForCs.AppendFormat("\r\n if ({0} != null)",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        {
                            sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                            strPrivPropNameWithObjectName);
                        }
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldName,
                        strPrivPropNameWithObjectName);
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
                strPrivPropNameWithObjectName);
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
                            objField.ObjFieldTabENEx.FldName ,
                             strPrivPropNameWithObjectName4Get);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName ,
                              strPrivPropNameWithObjectName4Get );
                        }
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = {{0}}\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName ,
                          strPrivPropNameWithObjectName4Get );
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
                             objField.ObjFieldTabENEx.FldName ,
                              strPrivPropNameWithObjectName4Get );
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get );
                        }
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = {{0}}\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName ,
                          strPrivPropNameWithObjectName4Get );
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
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}'\", {4} == true?\"1\":\"0\"); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldName,
                        strPrivPropNameWithObjectName );
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}'\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldName,
                        strPrivPropNameWithObjectName);
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = {{0}}\", {4}); //{2}",
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
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4}); //{2}",
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
                            sbCodeForCs.AppendFormat("\r\n if ({0} == \"\")",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n {0} = null;",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }

                        sbCodeForCs.AppendFormat("\r\n if ({0} != null)",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                        strPrivPropNameWithObjectName,
                        strPrivPropNameWithObjectName
                       );
                        //if (clsSysParaEN.bolIsAccessSqlInjection == true)
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
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} == false ? \"0\" : \"1\") + \"'\");",
                        strPrivPropNameWithObjectName);
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":

                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                        strPrivPropNameWithObjectName);
                        break;
                    default:
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                strPrivPropNameWithObjectName,
                                strPrivPropNameWithObjectName
                               );
                            }
                            sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                            strPrivPropNameWithObjectName);
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
                        sbCodeForCs.AppendFormat("\r\n if ({0} == \"\")",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n {0} = null;",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n }");
                    }

                    sbCodeForCs.AppendFormat("\r\n if ({0} != null)",
                    strPrivPropNameWithObjectName);
                    sbCodeForCs.Append("\r\n {");
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                       objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                    strPrivPropNameWithObjectName);
                    //if (clsSysParaEN.bolIsAccessSqlInjection == true)
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
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} == false ? \"0\" : \"1\") + \"'\");",
                    strPrivPropNameWithObjectName);
                    break;
                case "int":
                case "long":
                case "float":
                case "double":
                case "short":
                case "Int16":
                case "Int32":

                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                    strPrivPropNameWithObjectName);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        {
                            sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                            strPrivPropNameWithObjectName);
                        }
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                        strPrivPropNameWithObjectName);
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
                sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
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
                            objField.ObjFieldTabENEx.FldName ,
                            strPrivPropNameWithObjectName4Get);
                            break;
                        case "byte":
                        case "byte[]":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get );
                            break;
                        default:
                            if (objField.IsTabForeignKey == true)
                            {
                                sbCodeForCs.AppendFormat("\r\n if ({0} == \"\")",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n {");
                                sbCodeForCs.AppendFormat("\r\n {0} = null;",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n }");
                            }
                            sbCodeForCs.AppendFormat("\r\n if ({0} != null)",
                            strPrivPropNameWithObjectName4Get);
                            sbCodeForCs.Append("\r\n {");
                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                strPrivPropNameWithObjectName4Get,
                                strPrivPropNameWithObjectName4Get
                               );
                            }
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get );
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
                     objField.ObjFieldTabENEx.FldName ,
                     strPrivPropNameWithObjectName4Get);
                }
                sbCodeForCs.Append("\r\n }");
                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
            objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
            sbCodeForCs.Append("\r\n {");

            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "bool":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {{1}} = '{{0}}',\", {3} == true?\"1\":\"0\", cls{4}EN.con_{5}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        strPrivPropNameWithObjectName,
                         objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                        break;
                    case "byte":
                    case "byte[]":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = '{{0}}',\", {3}, cls{4}EN.con_{5}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        strPrivPropNameWithObjectName,
                         objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                        break;
                    default:
                        if (objField.IsTabForeignKey == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n if ({0} == \"\")",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n {0} = null;",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }
                        sbCodeForCs.AppendFormat("\r\n if ({0} != null)",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        {
                            sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                            strPrivPropNameWithObjectName);
                        }
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = '{{0}}',\", {3}, cls{4}EN.con_{5}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        strPrivPropNameWithObjectName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                        sbCodeForCs.Append("\r\n }");
                        sbCodeForCs.Append("\r\n else");
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{0}} = null,\",cls{3}EN.con_{4}); //{2}",
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
                sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = {{0}},\",{3}, cls{4}EN.con_{5}); //{2}",
                "{", "}",
                objField.ColCaption,
                strPrivPropNameWithObjectName,
                 objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
            }
            sbCodeForCs.Append("\r\n }");
            return sbCodeForCs.ToString();
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
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AutoGCPubFunc_Ora);
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
