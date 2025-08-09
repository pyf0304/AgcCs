
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateRelaDA
 表名:vFunctionTemplateRela(00050317)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:36
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
 框架-层名:数据处理层(CS)(DALCode,0002)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using PrjCommBase;
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// v函数与模板关系(vFunctionTemplateRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFunctionTemplateRelaDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsvFunctionTemplateRelaEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvFunctionTemplateRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionTemplateRelaEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsvFunctionTemplateRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFunctionTemplateRelaEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionTemplateRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFunctionTemplateRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetDataTable_vFunctionTemplateRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionTemplateRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionTemplateRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunctionTemplateRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunctionTemplateRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFunctionTemplateRela where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var sortInfo = clsSortLinkStrParse.ParseSortString(strOrderBy);
if (sortInfo.SortDirection == "" || sortInfo.SortField == "")
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]格式不正确,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strLeftLinkStr = clsSortLinkStrParse.BuildLeftJoinClause(sortInfo.JoinTables, sortInfo.JoinConditions);
strSQL = $"Select Top {intPageSize} vFunctionTemplateRela.* " + 
$"from vFunctionTemplateRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunctionTemplateRela.mId not in " + 
$"(Select top {intTop_In} vFunctionTemplateRela.mId from vFunctionTemplateRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunctionTemplateRela where {1} and mId not in (Select top {2} mId from vFunctionTemplateRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunctionTemplateRela where {1} and mId not in (Select top {3} mId from vFunctionTemplateRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var sortInfo = clsSortLinkStrParse.ParseSortString(strOrderBy);
if (sortInfo.SortDirection == "" || sortInfo.SortField == "")
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]格式不正确,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strLeftLinkStr = clsSortLinkStrParse.BuildLeftJoinClause(sortInfo.JoinTables, sortInfo.JoinConditions);
strSQL = $"Select Top {intPageSize} vFunctionTemplateRela.* " + 
$"from vFunctionTemplateRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunctionTemplateRela.mId not in " + 
$"(Select top {intTop_In} vFunctionTemplateRela.mId from vFunctionTemplateRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunctionTemplateRela where {1} and mId not in (Select top {2} mId from vFunctionTemplateRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunctionTemplateRela where {1} and mId not in (Select top {3} mId from vFunctionTemplateRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvFunctionTemplateRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA:GetObjLst)", objException.Message));
}
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionTemplateRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = TransNullToInt(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = TransNullToBool(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = TransNullToBool(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = TransNullToInt(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunctionTemplateRelaDA: GetObjLst)", objException.Message));
}
objvFunctionTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsvFunctionTemplateRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFunctionTemplateRelaEN> arrObjLst = new List<clsvFunctionTemplateRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = TransNullToInt(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = TransNullToBool(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = TransNullToBool(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = TransNullToInt(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunctionTemplateRelaDA: GetObjLst)", objException.Message));
}
objvFunctionTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFunctionTemplateRela(ref clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionTemplateRela where mId = " + ""+ objvFunctionTemplateRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFunctionTemplateRelaEN.mId = TransNullToInt(objDT.Rows[0][convFunctionTemplateRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFunctionTemplateRelaEN.FunctionTemplateId = objDT.Rows[0][convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunctionTemplateRelaEN.FunctionTemplateName = objDT.Rows[0][convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunctionTemplateRelaEN.CreateUserId = objDT.Rows[0][convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvFunctionTemplateRelaEN.CodeTypeId = objDT.Rows[0][convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunctionTemplateRelaEN.CodeTypeName = objDT.Rows[0][convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunctionTemplateRelaEN.CodeTypeENName = objDT.Rows[0][convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunctionTemplateRelaEN.RegionTypeId = objDT.Rows[0][convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunctionTemplateRelaEN.RegionTypeName = objDT.Rows[0][convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunctionTemplateRelaEN.FuncId4GC = objDT.Rows[0][convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvFunctionTemplateRelaEN.FuncName = objDT.Rows[0][convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunctionTemplateRelaEN.FuncId4Code = objDT.Rows[0][convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFunctionTemplateRelaEN.FuncName4Code = objDT.Rows[0][convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunctionTemplateRelaEN.FuncCHName4Code = objDT.Rows[0][convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objvFunctionTemplateRelaEN.ProgLangTypeId = objDT.Rows[0][convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionTemplateRelaEN.ProgLangTypeName = objDT.Rows[0][convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunctionTemplateRelaEN.SqlDsTypeId = objDT.Rows[0][convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionTemplateRelaEN.SqlDsTypeName = objDT.Rows[0][convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunctionTemplateRelaEN.ReturnTypeId = objDT.Rows[0][convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvFunctionTemplateRelaEN.FuncTypeId = objDT.Rows[0][convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionTemplateRelaEN.FuncTypeName = objDT.Rows[0][convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunctionTemplateRelaEN.IsTemplate = TransNullToBool(objDT.Rows[0][convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvFunctionTemplateRelaEN.FunctionSignature = objDT.Rows[0][convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunctionTemplateRelaEN.ReturnTypeName = objDT.Rows[0][convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunctionTemplateRelaEN.IsGeneCode = TransNullToBool(objDT.Rows[0][convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvFunctionTemplateRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFunctionTemplateRelaEN.UpdDate = objDT.Rows[0][convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionTemplateRelaEN.UpdUser = objDT.Rows[0][convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionTemplateRelaEN.Memo = objDT.Rows[0][convFunctionTemplateRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFunctionTemplateRelaEN.Order4FuncNum = TransNullToInt(objDT.Rows[0][convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFunctionTemplateRelaDA: GetvFunctionTemplateRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFunctionTemplateRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionTemplateRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
 objvFunctionTemplateRelaEN.mId = Int32.Parse(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunctionTemplateRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFunctionTemplateRelaDA: GetObjBymId)", objException.Message));
}
return objvFunctionTemplateRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFunctionTemplateRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionTemplateRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN()
{
mId = TransNullToInt(objRow[convFunctionTemplateRela.mId].ToString().Trim()), //mId
FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(), //函数模板Id
FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(), //函数模板名
CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(), //建立用户Id
CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(), //代码类型英文名
RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(), //区域类型Id
RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(), //区域类型名称
FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(), //函数ID
FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(), //函数名
FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(), //函数Id4Code
FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(), //函数名4Code
FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(), //函数中文名4Code
ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(), //编程语言类型名
SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(), //数据源类型Id
SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(), //Sql数据源名
ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(), //返回类型ID
FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(), //函数类型Id
FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(), //函数类型名
IsTemplate = TransNullToBool(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()), //是否模板
FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(), //函数签名
ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(), //返回类型名
IsGeneCode = TransNullToBool(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()), //是否生成代码
OrderNum = TransNullToInt(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(), //说明
Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()) //Order4FuncNum
};
objvFunctionTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunctionTemplateRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFunctionTemplateRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFunctionTemplateRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = TransNullToInt(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = TransNullToBool(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = TransNullToBool(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = TransNullToInt(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFunctionTemplateRelaDA: GetObjByDataRowvFunctionTemplateRela)", objException.Message));
}
objvFunctionTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunctionTemplateRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFunctionTemplateRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN = new clsvFunctionTemplateRelaEN();
try
{
objvFunctionTemplateRelaEN.mId = TransNullToInt(objRow[convFunctionTemplateRela.mId].ToString().Trim()); //mId
objvFunctionTemplateRelaEN.FunctionTemplateId = objRow[convFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvFunctionTemplateRelaEN.FunctionTemplateName = objRow[convFunctionTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvFunctionTemplateRelaEN.CreateUserId = objRow[convFunctionTemplateRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionTemplateRelaEN.CodeTypeId = objRow[convFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTemplateRelaEN.CodeTypeName = objRow[convFunctionTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTemplateRelaEN.CodeTypeENName = objRow[convFunctionTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTemplateRelaEN.RegionTypeId = objRow[convFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvFunctionTemplateRelaEN.RegionTypeName = objRow[convFunctionTemplateRela.RegionTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvFunctionTemplateRelaEN.FuncId4GC = objRow[convFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionTemplateRelaEN.FuncName = objRow[convFunctionTemplateRela.FuncName].ToString().Trim(); //函数名
objvFunctionTemplateRelaEN.FuncId4Code = objRow[convFunctionTemplateRela.FuncId4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunctionTemplateRelaEN.FuncName4Code = objRow[convFunctionTemplateRela.FuncName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunctionTemplateRelaEN.FuncCHName4Code = objRow[convFunctionTemplateRela.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunctionTemplateRelaEN.ProgLangTypeId = objRow[convFunctionTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionTemplateRelaEN.ProgLangTypeName = objRow[convFunctionTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionTemplateRelaEN.SqlDsTypeId = objRow[convFunctionTemplateRela.SqlDsTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunctionTemplateRelaEN.SqlDsTypeName = objRow[convFunctionTemplateRela.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunctionTemplateRelaEN.ReturnTypeId = objRow[convFunctionTemplateRela.ReturnTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunctionTemplateRelaEN.FuncTypeId = objRow[convFunctionTemplateRela.FuncTypeId] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTemplateRelaEN.FuncTypeName = objRow[convFunctionTemplateRela.FuncTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTemplateRelaEN.IsTemplate = TransNullToBool(objRow[convFunctionTemplateRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionTemplateRelaEN.FunctionSignature = objRow[convFunctionTemplateRela.FunctionSignature] == DBNull.Value ? null : objRow[convFunctionTemplateRela.FunctionSignature].ToString().Trim(); //函数签名
objvFunctionTemplateRelaEN.ReturnTypeName = objRow[convFunctionTemplateRela.ReturnTypeName] == DBNull.Value ? null : objRow[convFunctionTemplateRela.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunctionTemplateRelaEN.IsGeneCode = TransNullToBool(objRow[convFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objvFunctionTemplateRelaEN.OrderNum = TransNullToInt(objRow[convFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objvFunctionTemplateRelaEN.UpdDate = objRow[convFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionTemplateRelaEN.UpdUser = objRow[convFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objvFunctionTemplateRelaEN.Memo = objRow[convFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[convFunctionTemplateRela.Memo].ToString().Trim(); //说明
objvFunctionTemplateRelaEN.Order4FuncNum = objRow[convFunctionTemplateRela.Order4FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunctionTemplateRela.Order4FuncNum].ToString().Trim()); //Order4FuncNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFunctionTemplateRelaDA: GetObjByDataRow)", objException.Message));
}
objvFunctionTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunctionTemplateRelaEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunctionTemplateRelaEN._CurrTabName, convFunctionTemplateRela.mId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunctionTemplateRelaEN._CurrTabName, convFunctionTemplateRela.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFunctionTemplateRela where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFunctionTemplateRela where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExist_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunctionTemplateRela", "mId = " + ""+ lngmId+""))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFunctionTemplateRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunctionTemplateRela", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFunctionTemplateRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaENS">源对象</param>
 /// <param name = "objvFunctionTemplateRelaENT">目标对象</param>
public void CopyTo(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENS, clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENT)
{
objvFunctionTemplateRelaENT.mId = objvFunctionTemplateRelaENS.mId; //mId
objvFunctionTemplateRelaENT.FunctionTemplateId = objvFunctionTemplateRelaENS.FunctionTemplateId; //函数模板Id
objvFunctionTemplateRelaENT.FunctionTemplateName = objvFunctionTemplateRelaENS.FunctionTemplateName; //函数模板名
objvFunctionTemplateRelaENT.CreateUserId = objvFunctionTemplateRelaENS.CreateUserId; //建立用户Id
objvFunctionTemplateRelaENT.CodeTypeId = objvFunctionTemplateRelaENS.CodeTypeId; //代码类型Id
objvFunctionTemplateRelaENT.CodeTypeName = objvFunctionTemplateRelaENS.CodeTypeName; //代码类型名
objvFunctionTemplateRelaENT.CodeTypeENName = objvFunctionTemplateRelaENS.CodeTypeENName; //代码类型英文名
objvFunctionTemplateRelaENT.RegionTypeId = objvFunctionTemplateRelaENS.RegionTypeId; //区域类型Id
objvFunctionTemplateRelaENT.RegionTypeName = objvFunctionTemplateRelaENS.RegionTypeName; //区域类型名称
objvFunctionTemplateRelaENT.FuncId4GC = objvFunctionTemplateRelaENS.FuncId4GC; //函数ID
objvFunctionTemplateRelaENT.FuncName = objvFunctionTemplateRelaENS.FuncName; //函数名
objvFunctionTemplateRelaENT.FuncId4Code = objvFunctionTemplateRelaENS.FuncId4Code; //函数Id4Code
objvFunctionTemplateRelaENT.FuncName4Code = objvFunctionTemplateRelaENS.FuncName4Code; //函数名4Code
objvFunctionTemplateRelaENT.FuncCHName4Code = objvFunctionTemplateRelaENS.FuncCHName4Code; //函数中文名4Code
objvFunctionTemplateRelaENT.ProgLangTypeId = objvFunctionTemplateRelaENS.ProgLangTypeId; //编程语言类型Id
objvFunctionTemplateRelaENT.ProgLangTypeName = objvFunctionTemplateRelaENS.ProgLangTypeName; //编程语言类型名
objvFunctionTemplateRelaENT.SqlDsTypeId = objvFunctionTemplateRelaENS.SqlDsTypeId; //数据源类型Id
objvFunctionTemplateRelaENT.SqlDsTypeName = objvFunctionTemplateRelaENS.SqlDsTypeName; //Sql数据源名
objvFunctionTemplateRelaENT.ReturnTypeId = objvFunctionTemplateRelaENS.ReturnTypeId; //返回类型ID
objvFunctionTemplateRelaENT.FuncTypeId = objvFunctionTemplateRelaENS.FuncTypeId; //函数类型Id
objvFunctionTemplateRelaENT.FuncTypeName = objvFunctionTemplateRelaENS.FuncTypeName; //函数类型名
objvFunctionTemplateRelaENT.IsTemplate = objvFunctionTemplateRelaENS.IsTemplate; //是否模板
objvFunctionTemplateRelaENT.FunctionSignature = objvFunctionTemplateRelaENS.FunctionSignature; //函数签名
objvFunctionTemplateRelaENT.ReturnTypeName = objvFunctionTemplateRelaENS.ReturnTypeName; //返回类型名
objvFunctionTemplateRelaENT.IsGeneCode = objvFunctionTemplateRelaENS.IsGeneCode; //是否生成代码
objvFunctionTemplateRelaENT.OrderNum = objvFunctionTemplateRelaENS.OrderNum; //序号
objvFunctionTemplateRelaENT.UpdDate = objvFunctionTemplateRelaENS.UpdDate; //修改日期
objvFunctionTemplateRelaENT.UpdUser = objvFunctionTemplateRelaENS.UpdUser; //修改者
objvFunctionTemplateRelaENT.Memo = objvFunctionTemplateRelaENS.Memo; //说明
objvFunctionTemplateRelaENT.Order4FuncNum = objvFunctionTemplateRelaENS.Order4FuncNum; //Order4FuncNum
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FunctionTemplateId, 4, convFunctionTemplateRela.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FunctionTemplateName, 50, convFunctionTemplateRela.FunctionTemplateName);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.CreateUserId, 18, convFunctionTemplateRela.CreateUserId);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.CodeTypeId, 4, convFunctionTemplateRela.CodeTypeId);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.CodeTypeName, 50, convFunctionTemplateRela.CodeTypeName);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.CodeTypeENName, 50, convFunctionTemplateRela.CodeTypeENName);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.RegionTypeId, 4, convFunctionTemplateRela.RegionTypeId);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.RegionTypeName, 30, convFunctionTemplateRela.RegionTypeName);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FuncId4GC, 10, convFunctionTemplateRela.FuncId4GC);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FuncName, 100, convFunctionTemplateRela.FuncName);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FuncId4Code, 8, convFunctionTemplateRela.FuncId4Code);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FuncName4Code, 100, convFunctionTemplateRela.FuncName4Code);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FuncCHName4Code, 200, convFunctionTemplateRela.FuncCHName4Code);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.ProgLangTypeId, 2, convFunctionTemplateRela.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.ProgLangTypeName, 30, convFunctionTemplateRela.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.SqlDsTypeId, 2, convFunctionTemplateRela.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.SqlDsTypeName, 20, convFunctionTemplateRela.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.ReturnTypeId, 2, convFunctionTemplateRela.ReturnTypeId);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FuncTypeId, 2, convFunctionTemplateRela.FuncTypeId);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FuncTypeName, 20, convFunctionTemplateRela.FuncTypeName);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.FunctionSignature, 500, convFunctionTemplateRela.FunctionSignature);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.ReturnTypeName, 100, convFunctionTemplateRela.ReturnTypeName);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.UpdDate, 20, convFunctionTemplateRela.UpdDate);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.UpdUser, 20, convFunctionTemplateRela.UpdUser);
clsCheckSql.CheckFieldLen(objvFunctionTemplateRelaEN.Memo, 1000, convFunctionTemplateRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FunctionTemplateId, convFunctionTemplateRela.FunctionTemplateId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FunctionTemplateName, convFunctionTemplateRela.FunctionTemplateName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.CreateUserId, convFunctionTemplateRela.CreateUserId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.CodeTypeId, convFunctionTemplateRela.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.CodeTypeName, convFunctionTemplateRela.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.CodeTypeENName, convFunctionTemplateRela.CodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.RegionTypeId, convFunctionTemplateRela.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.RegionTypeName, convFunctionTemplateRela.RegionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FuncId4GC, convFunctionTemplateRela.FuncId4GC);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FuncName, convFunctionTemplateRela.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FuncId4Code, convFunctionTemplateRela.FuncId4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FuncName4Code, convFunctionTemplateRela.FuncName4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FuncCHName4Code, convFunctionTemplateRela.FuncCHName4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.ProgLangTypeId, convFunctionTemplateRela.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.ProgLangTypeName, convFunctionTemplateRela.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.SqlDsTypeId, convFunctionTemplateRela.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.SqlDsTypeName, convFunctionTemplateRela.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.ReturnTypeId, convFunctionTemplateRela.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FuncTypeId, convFunctionTemplateRela.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FuncTypeName, convFunctionTemplateRela.FuncTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.FunctionSignature, convFunctionTemplateRela.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.ReturnTypeName, convFunctionTemplateRela.ReturnTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.UpdDate, convFunctionTemplateRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.UpdUser, convFunctionTemplateRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFunctionTemplateRelaEN.Memo, convFunctionTemplateRela.Memo);
//检查外键字段长度
 objvFunctionTemplateRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunctionTemplateRelaEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunctionTemplateRelaEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionTemplateRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}