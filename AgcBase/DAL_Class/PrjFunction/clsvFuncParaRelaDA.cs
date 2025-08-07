
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncParaRelaDA
 表名:vFuncParaRela(00050499)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:42
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// vFuncParaRela(vFuncParaRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFuncParaRelaDA : clsCommBase4DA
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
 return clsvFuncParaRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFuncParaRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncParaRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFuncParaRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFuncParaRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncParaRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFuncParaRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetDataTable_vFuncParaRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncParaRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncParaRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncParaRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncParaRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFuncParaRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFuncParaRela.* " + 
$"from vFuncParaRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFuncParaRela.mId not in " + 
$"(Select top {intTop_In} vFuncParaRela.mId from vFuncParaRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncParaRela where {1} and mId not in (Select top {2} mId from vFuncParaRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncParaRela where {1} and mId not in (Select top {3} mId from vFuncParaRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFuncParaRela.* " + 
$"from vFuncParaRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFuncParaRela.mId not in " + 
$"(Select top {intTop_In} vFuncParaRela.mId from vFuncParaRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncParaRela where {1} and mId not in (Select top {2} mId from vFuncParaRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncParaRela where {1} and mId not in (Select top {3} mId from vFuncParaRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFuncParaRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA:GetObjLst)", objException.Message));
}
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncParaRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = TransNullToInt(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = TransNullToBool(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = TransNullToBool(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = TransNullToBool(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = TransNullToBool(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = TransNullToInt(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFuncParaRelaDA: GetObjLst)", objException.Message));
}
objvFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFuncParaRelaEN);
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
public List<clsvFuncParaRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = TransNullToInt(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = TransNullToBool(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = TransNullToBool(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = TransNullToBool(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = TransNullToBool(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = TransNullToInt(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFuncParaRelaDA: GetObjLst)", objException.Message));
}
objvFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFuncParaRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFuncParaRela(ref clsvFuncParaRelaEN objvFuncParaRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncParaRela where mId = " + ""+ objvFuncParaRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFuncParaRelaEN.mId = TransNullToInt(objDT.Rows[0][convFuncParaRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFuncParaRelaEN.FuncParaId4Code = objDT.Rows[0][convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvFuncParaRelaEN.ParaName = objDT.Rows[0][convFuncParaRela.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFuncParaRelaEN.ParaCnName = objDT.Rows[0][convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFuncParaRelaEN.DataTypeId = objDT.Rows[0][convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFuncParaRelaEN.DataTypeName = objDT.Rows[0][convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.DataCnName = objDT.Rows[0][convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.CsType = objDT.Rows[0][convFuncParaRela.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.JavaType = objDT.Rows[0][convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.JavaObjType = objDT.Rows[0][convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.SwiftType = objDT.Rows[0][convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.IsNeedQuote = TransNullToBool(objDT.Rows[0][convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvFuncParaRelaEN.OraDbType = objDT.Rows[0][convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.MySqlType = objDT.Rows[0][convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.ParameterType = objDT.Rows[0][convFuncParaRela.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.ParameterTypeFullName = objDT.Rows[0][convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvFuncParaRelaEN.IsByRef = TransNullToBool(objDT.Rows[0][convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvFuncParaRelaEN.PrjId = objDT.Rows[0][convFuncParaRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFuncParaRelaEN.FuncId4Code = objDT.Rows[0][convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFuncParaRelaEN.FuncName4Code = objDT.Rows[0][convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.FunctionSignature = objDT.Rows[0][convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFuncParaRelaEN.IsAsyncFunc = TransNullToBool(objDT.Rows[0][convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objvFuncParaRelaEN.IsSysFunction = TransNullToBool(objDT.Rows[0][convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objvFuncParaRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convFuncParaRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFuncParaRelaEN.UpdDate = objDT.Rows[0][convFuncParaRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncParaRelaEN.UpdUser = objDT.Rows[0][convFuncParaRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncParaRelaEN.Memo = objDT.Rows[0][convFuncParaRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFuncParaRelaDA: GetvFuncParaRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFuncParaRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncParaRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
 objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFuncParaRelaDA: GetObjBymId)", objException.Message));
}
return objvFuncParaRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFuncParaRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncParaRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN()
{
mId = TransNullToInt(objRow[convFuncParaRela.mId].ToString().Trim()), //mId
FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(), //函数参数Id
ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(), //参数名
ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(), //参数中文名
DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(), //数据类型名称
DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(), //数据类型中文名称
CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(), //CS类型
JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(), //JAVA类型
JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(), //JAVA对象类型
SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(), //SwiftType
IsNeedQuote = TransNullToBool(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()), //是否需要引号
OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(), //Ora数据类型
MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(), //MySqlType
ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(), //参数类型
ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(), //参数类型全名
IsByRef = TransNullToBool(objRow[convFuncParaRela.IsByRef].ToString().Trim()), //是否引用型参数
PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(), //工程Id
FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(), //函数Id4Code
FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(), //函数名4Code
FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(), //函数签名
IsAsyncFunc = TransNullToBool(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()), //是否异步函数
IsSysFunction = TransNullToBool(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()), //是否系统函数
OrderNum = TransNullToInt(objRow[convFuncParaRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim() //说明
};
objvFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncParaRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFuncParaRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFuncParaRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = TransNullToInt(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = TransNullToBool(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = TransNullToBool(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = TransNullToBool(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = TransNullToBool(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = TransNullToInt(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFuncParaRelaDA: GetObjByDataRowvFuncParaRela)", objException.Message));
}
objvFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncParaRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFuncParaRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = TransNullToInt(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = TransNullToBool(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = TransNullToBool(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = TransNullToBool(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = TransNullToBool(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = TransNullToInt(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFuncParaRelaDA: GetObjByDataRow)", objException.Message));
}
objvFuncParaRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncParaRelaEN;
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
objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFuncParaRelaEN._CurrTabName, convFuncParaRela.mId, 8, "");
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
objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFuncParaRelaEN._CurrTabName, convFuncParaRela.mId, 8, strPrefix);
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
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFuncParaRela where " + strCondition;
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
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFuncParaRela where " + strCondition;
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
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFuncParaRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFuncParaRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFuncParaRela", strCondition))
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
objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFuncParaRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFuncParaRelaENS">源对象</param>
 /// <param name = "objvFuncParaRelaENT">目标对象</param>
public void CopyTo(clsvFuncParaRelaEN objvFuncParaRelaENS, clsvFuncParaRelaEN objvFuncParaRelaENT)
{
objvFuncParaRelaENT.mId = objvFuncParaRelaENS.mId; //mId
objvFuncParaRelaENT.FuncParaId4Code = objvFuncParaRelaENS.FuncParaId4Code; //函数参数Id
objvFuncParaRelaENT.ParaName = objvFuncParaRelaENS.ParaName; //参数名
objvFuncParaRelaENT.ParaCnName = objvFuncParaRelaENS.ParaCnName; //参数中文名
objvFuncParaRelaENT.DataTypeId = objvFuncParaRelaENS.DataTypeId; //数据类型Id
objvFuncParaRelaENT.DataTypeName = objvFuncParaRelaENS.DataTypeName; //数据类型名称
objvFuncParaRelaENT.DataCnName = objvFuncParaRelaENS.DataCnName; //数据类型中文名称
objvFuncParaRelaENT.CsType = objvFuncParaRelaENS.CsType; //CS类型
objvFuncParaRelaENT.JavaType = objvFuncParaRelaENS.JavaType; //JAVA类型
objvFuncParaRelaENT.JavaObjType = objvFuncParaRelaENS.JavaObjType; //JAVA对象类型
objvFuncParaRelaENT.SwiftType = objvFuncParaRelaENS.SwiftType; //SwiftType
objvFuncParaRelaENT.IsNeedQuote = objvFuncParaRelaENS.IsNeedQuote; //是否需要引号
objvFuncParaRelaENT.OraDbType = objvFuncParaRelaENS.OraDbType; //Ora数据类型
objvFuncParaRelaENT.MySqlType = objvFuncParaRelaENS.MySqlType; //MySqlType
objvFuncParaRelaENT.ParameterType = objvFuncParaRelaENS.ParameterType; //参数类型
objvFuncParaRelaENT.ParameterTypeFullName = objvFuncParaRelaENS.ParameterTypeFullName; //参数类型全名
objvFuncParaRelaENT.IsByRef = objvFuncParaRelaENS.IsByRef; //是否引用型参数
objvFuncParaRelaENT.PrjId = objvFuncParaRelaENS.PrjId; //工程Id
objvFuncParaRelaENT.FuncId4Code = objvFuncParaRelaENS.FuncId4Code; //函数Id4Code
objvFuncParaRelaENT.FuncName4Code = objvFuncParaRelaENS.FuncName4Code; //函数名4Code
objvFuncParaRelaENT.FunctionSignature = objvFuncParaRelaENS.FunctionSignature; //函数签名
objvFuncParaRelaENT.IsAsyncFunc = objvFuncParaRelaENS.IsAsyncFunc; //是否异步函数
objvFuncParaRelaENT.IsSysFunction = objvFuncParaRelaENS.IsSysFunction; //是否系统函数
objvFuncParaRelaENT.OrderNum = objvFuncParaRelaENS.OrderNum; //序号
objvFuncParaRelaENT.UpdDate = objvFuncParaRelaENS.UpdDate; //修改日期
objvFuncParaRelaENT.UpdUser = objvFuncParaRelaENS.UpdUser; //修改者
objvFuncParaRelaENT.Memo = objvFuncParaRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFuncParaRelaEN objvFuncParaRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.FuncParaId4Code, 8, convFuncParaRela.FuncParaId4Code);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.ParaName, 50, convFuncParaRela.ParaName);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.ParaCnName, 50, convFuncParaRela.ParaCnName);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.DataTypeId, 2, convFuncParaRela.DataTypeId);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.DataTypeName, 100, convFuncParaRela.DataTypeName);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.DataCnName, 100, convFuncParaRela.DataCnName);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.CsType, 100, convFuncParaRela.CsType);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.JavaType, 100, convFuncParaRela.JavaType);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.JavaObjType, 100, convFuncParaRela.JavaObjType);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.SwiftType, 100, convFuncParaRela.SwiftType);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.OraDbType, 100, convFuncParaRela.OraDbType);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.MySqlType, 100, convFuncParaRela.MySqlType);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.ParameterType, 100, convFuncParaRela.ParameterType);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.ParameterTypeFullName, 500, convFuncParaRela.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.PrjId, 4, convFuncParaRela.PrjId);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.FuncId4Code, 8, convFuncParaRela.FuncId4Code);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.FuncName4Code, 100, convFuncParaRela.FuncName4Code);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.FunctionSignature, 500, convFuncParaRela.FunctionSignature);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.UpdDate, 20, convFuncParaRela.UpdDate);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.UpdUser, 20, convFuncParaRela.UpdUser);
clsCheckSql.CheckFieldLen(objvFuncParaRelaEN.Memo, 1000, convFuncParaRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.FuncParaId4Code, convFuncParaRela.FuncParaId4Code);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.ParaName, convFuncParaRela.ParaName);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.ParaCnName, convFuncParaRela.ParaCnName);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.DataTypeId, convFuncParaRela.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.DataTypeName, convFuncParaRela.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.DataCnName, convFuncParaRela.DataCnName);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.CsType, convFuncParaRela.CsType);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.JavaType, convFuncParaRela.JavaType);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.JavaObjType, convFuncParaRela.JavaObjType);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.SwiftType, convFuncParaRela.SwiftType);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.OraDbType, convFuncParaRela.OraDbType);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.MySqlType, convFuncParaRela.MySqlType);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.ParameterType, convFuncParaRela.ParameterType);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.ParameterTypeFullName, convFuncParaRela.ParameterTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.PrjId, convFuncParaRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.FuncId4Code, convFuncParaRela.FuncId4Code);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.FuncName4Code, convFuncParaRela.FuncName4Code);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.FunctionSignature, convFuncParaRela.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.UpdDate, convFuncParaRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.UpdUser, convFuncParaRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFuncParaRelaEN.Memo, convFuncParaRela.Memo);
//检查外键字段长度
 objvFuncParaRelaEN._IsCheckProperty = true;
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
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFuncParaRelaEN._CurrTabName);
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
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFuncParaRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvFuncParaRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}