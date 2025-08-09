
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionTypeDA
 表名:FunctionType(00050063)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:38
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
 /// 函数类型(FunctionType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFunctionTypeDA : clsCommBase4DA
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
 return clsFunctionTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFunctionTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFunctionTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFunctionTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncTypeId)
{
strFuncTypeId = strFuncTypeId.Replace("'", "''");
if (strFuncTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:FunctionType中,检查关键字,长度不正确!(clsFunctionTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FunctionType中,关键字不能为空 或 null!(clsFunctionTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFunctionTypeDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFunctionTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FunctionType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFunctionTypeDA: GetDataTable_FunctionType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFunctionTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFunctionTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFunctionTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFunctionTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFunctionTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FunctionType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFunctionTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FunctionType.* " + 
$"from FunctionType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FunctionType.FuncTypeId not in " + 
$"(Select top {intTop_In} FunctionType.FuncTypeId from FunctionType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionType where {1} and FuncTypeId not in (Select top {2} FuncTypeId from FunctionType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionType where {1} and FuncTypeId not in (Select top {3} FuncTypeId from FunctionType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFunctionTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FunctionType.* " + 
$"from FunctionType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FunctionType.FuncTypeId not in " + 
$"(Select top {intTop_In} FunctionType.FuncTypeId from FunctionType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionType where {1} and FuncTypeId not in (Select top {2} FuncTypeId from FunctionType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionType where {1} and FuncTypeId not in (Select top {3} FuncTypeId from FunctionType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFunctionTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFunctionTypeDA:GetObjLst)", objException.Message));
}
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionTypeDA: GetObjLst)", objException.Message));
}
objFunctionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionTypeEN);
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
public List<clsFunctionTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFunctionTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionTypeDA: GetObjLst)", objException.Message));
}
objFunctionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFunctionType(ref clsFunctionTypeEN objFunctionTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where FuncTypeId = " + "'"+ objFunctionTypeEN.FuncTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFunctionTypeEN.FuncTypeId = objDT.Rows[0][conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunctionTypeEN.FuncTypeName = objDT.Rows[0][conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objFunctionTypeEN.FuncTypeENName = objDT.Rows[0][conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objFunctionTypeEN.CodeTypeId = objDT.Rows[0][conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objFunctionTypeEN.Memo = objDT.Rows[0][conFunctionType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFunctionTypeDA: GetFunctionType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsFunctionTypeEN GetObjByFuncTypeId(string strFuncTypeId)
{
CheckPrimaryKey(strFuncTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where FuncTypeId = " + "'"+ strFuncTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
 objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFunctionTypeDA: GetObjByFuncTypeId)", objException.Message));
}
return objFunctionTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFunctionTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFunctionTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN()
{
FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(), //函数类型Id
FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(), //函数类型名
FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(), //函数类型英文名
CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(), //代码类型Id
Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim() //说明
};
objFunctionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFunctionTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFunctionTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFunctionTypeDA: GetObjByDataRowFunctionType)", objException.Message));
}
objFunctionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFunctionTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFunctionTypeDA: GetObjByDataRow)", objException.Message));
}
objFunctionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionTypeEN;
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
objSQL = clsFunctionTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionTypeEN._CurrTabName, conFunctionType.FuncTypeId, 2, "");
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
objSQL = clsFunctionTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionTypeEN._CurrTabName, conFunctionType.FuncTypeId, 2, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncTypeId from FunctionType where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
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
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncTypeId from FunctionType where " + strCondition;
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
 /// <param name = "strFuncTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncTypeId)
{
CheckPrimaryKey(strFuncTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionType", "FuncTypeId = " + "'"+ strFuncTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFunctionTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionType", strCondition))
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
objSQL = clsFunctionTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FunctionType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFunctionTypeEN objFunctionTypeEN)
 {
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionType");
objRow = objDS.Tables["FunctionType"].NewRow();
objRow[conFunctionType.FuncTypeId] = objFunctionTypeEN.FuncTypeId; //函数类型Id
objRow[conFunctionType.FuncTypeName] = objFunctionTypeEN.FuncTypeName; //函数类型名
 if (objFunctionTypeEN.FuncTypeENName !=  "")
 {
objRow[conFunctionType.FuncTypeENName] = objFunctionTypeEN.FuncTypeENName; //函数类型英文名
 }
 if (objFunctionTypeEN.CodeTypeId !=  "")
 {
objRow[conFunctionType.CodeTypeId] = objFunctionTypeEN.CodeTypeId; //代码类型Id
 }
 if (objFunctionTypeEN.Memo !=  "")
 {
objRow[conFunctionType.Memo] = objFunctionTypeEN.Memo; //说明
 }
objDS.Tables[clsFunctionTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFunctionTypeEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionTypeEN objFunctionTypeEN)
{
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionTypeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeId);
 var strFuncTypeId = objFunctionTypeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objFunctionTypeEN.FuncTypeName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeName);
 var strFuncTypeName = objFunctionTypeEN.FuncTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeName + "'");
 }
 
 if (objFunctionTypeEN.FuncTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeENName);
 var strFuncTypeENName = objFunctionTypeEN.FuncTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeENName + "'");
 }
 
 if (objFunctionTypeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.CodeTypeId);
 var strCodeTypeId = objFunctionTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objFunctionTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.Memo);
 var strMemo = objFunctionTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionTypeEN objFunctionTypeEN)
{
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionTypeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeId);
 var strFuncTypeId = objFunctionTypeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objFunctionTypeEN.FuncTypeName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeName);
 var strFuncTypeName = objFunctionTypeEN.FuncTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeName + "'");
 }
 
 if (objFunctionTypeEN.FuncTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeENName);
 var strFuncTypeENName = objFunctionTypeEN.FuncTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeENName + "'");
 }
 
 if (objFunctionTypeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.CodeTypeId);
 var strCodeTypeId = objFunctionTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objFunctionTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.Memo);
 var strMemo = objFunctionTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFunctionTypeEN.FuncTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionTypeEN objFunctionTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionTypeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeId);
 var strFuncTypeId = objFunctionTypeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objFunctionTypeEN.FuncTypeName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeName);
 var strFuncTypeName = objFunctionTypeEN.FuncTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeName + "'");
 }
 
 if (objFunctionTypeEN.FuncTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeENName);
 var strFuncTypeENName = objFunctionTypeEN.FuncTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeENName + "'");
 }
 
 if (objFunctionTypeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.CodeTypeId);
 var strCodeTypeId = objFunctionTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objFunctionTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.Memo);
 var strMemo = objFunctionTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFunctionTypeEN.FuncTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionTypeEN objFunctionTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionTypeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeId);
 var strFuncTypeId = objFunctionTypeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objFunctionTypeEN.FuncTypeName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeName);
 var strFuncTypeName = objFunctionTypeEN.FuncTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeName + "'");
 }
 
 if (objFunctionTypeEN.FuncTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.FuncTypeENName);
 var strFuncTypeENName = objFunctionTypeEN.FuncTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeENName + "'");
 }
 
 if (objFunctionTypeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.CodeTypeId);
 var strCodeTypeId = objFunctionTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objFunctionTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionType.Memo);
 var strMemo = objFunctionTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFunctionTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where FuncTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFuncTypeId = oRow[conFunctionType.FuncTypeId].ToString().Trim();
if (IsExist(strFuncTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("FuncTypeId = {0}", strFuncTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFunctionTypeEN._CurrTabName ].NewRow();
objRow[conFunctionType.FuncTypeId] = oRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objRow[conFunctionType.FuncTypeName] = oRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objRow[conFunctionType.FuncTypeENName] = oRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objRow[conFunctionType.CodeTypeId] = oRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conFunctionType.Memo] = oRow[conFunctionType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFunctionTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFunctionTypeEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFunctionTypeEN objFunctionTypeEN)
{
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionType where FuncTypeId = " + "'"+ objFunctionTypeEN.FuncTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFunctionTypeEN._CurrTabName);
if (objDS.Tables[clsFunctionTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FuncTypeId = " + "'"+ objFunctionTypeEN.FuncTypeId+"'");
return false;
}
objRow = objDS.Tables[clsFunctionTypeEN._CurrTabName].Rows[0];
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeId))
 {
objRow[conFunctionType.FuncTypeId] = objFunctionTypeEN.FuncTypeId; //函数类型Id
 }
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeName))
 {
objRow[conFunctionType.FuncTypeName] = objFunctionTypeEN.FuncTypeName; //函数类型名
 }
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeENName))
 {
objRow[conFunctionType.FuncTypeENName] = objFunctionTypeEN.FuncTypeENName; //函数类型英文名
 }
 if (objFunctionTypeEN.IsUpdated(conFunctionType.CodeTypeId))
 {
objRow[conFunctionType.CodeTypeId] = objFunctionTypeEN.CodeTypeId; //代码类型Id
 }
 if (objFunctionTypeEN.IsUpdated(conFunctionType.Memo))
 {
objRow[conFunctionType.Memo] = objFunctionTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFunctionTypeEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionTypeEN objFunctionTypeEN)
{
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FunctionType Set ");
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeName))
 {
 if (objFunctionTypeEN.FuncTypeName !=  null)
 {
 var strFuncTypeName = objFunctionTypeEN.FuncTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeName, conFunctionType.FuncTypeName); //函数类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionType.FuncTypeName); //函数类型名
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeENName))
 {
 if (objFunctionTypeEN.FuncTypeENName !=  null)
 {
 var strFuncTypeENName = objFunctionTypeEN.FuncTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeENName, conFunctionType.FuncTypeENName); //函数类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionType.FuncTypeENName); //函数类型英文名
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.CodeTypeId))
 {
 if (objFunctionTypeEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objFunctionTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conFunctionType.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionType.CodeTypeId); //代码类型Id
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.Memo))
 {
 if (objFunctionTypeEN.Memo !=  null)
 {
 var strMemo = objFunctionTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunctionType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncTypeId = '{0}'", objFunctionTypeEN.FuncTypeId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFunctionTypeEN objFunctionTypeEN, string strCondition)
{
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionType Set ");
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeName))
 {
 if (objFunctionTypeEN.FuncTypeName !=  null)
 {
 var strFuncTypeName = objFunctionTypeEN.FuncTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeName = '{0}',", strFuncTypeName); //函数类型名
 }
 else
 {
 sbSQL.Append(" FuncTypeName = null,"); //函数类型名
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeENName))
 {
 if (objFunctionTypeEN.FuncTypeENName !=  null)
 {
 var strFuncTypeENName = objFunctionTypeEN.FuncTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeENName = '{0}',", strFuncTypeENName); //函数类型英文名
 }
 else
 {
 sbSQL.Append(" FuncTypeENName = null,"); //函数类型英文名
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.CodeTypeId))
 {
 if (objFunctionTypeEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objFunctionTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.Memo))
 {
 if (objFunctionTypeEN.Memo !=  null)
 {
 var strMemo = objFunctionTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFunctionTypeEN objFunctionTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionType Set ");
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeName))
 {
 if (objFunctionTypeEN.FuncTypeName !=  null)
 {
 var strFuncTypeName = objFunctionTypeEN.FuncTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeName = '{0}',", strFuncTypeName); //函数类型名
 }
 else
 {
 sbSQL.Append(" FuncTypeName = null,"); //函数类型名
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeENName))
 {
 if (objFunctionTypeEN.FuncTypeENName !=  null)
 {
 var strFuncTypeENName = objFunctionTypeEN.FuncTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeENName = '{0}',", strFuncTypeENName); //函数类型英文名
 }
 else
 {
 sbSQL.Append(" FuncTypeENName = null,"); //函数类型英文名
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.CodeTypeId))
 {
 if (objFunctionTypeEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objFunctionTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.Memo))
 {
 if (objFunctionTypeEN.Memo !=  null)
 {
 var strMemo = objFunctionTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionTypeEN objFunctionTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFunctionTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionType Set ");
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeName))
 {
 if (objFunctionTypeEN.FuncTypeName !=  null)
 {
 var strFuncTypeName = objFunctionTypeEN.FuncTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeName, conFunctionType.FuncTypeName); //函数类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionType.FuncTypeName); //函数类型名
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.FuncTypeENName))
 {
 if (objFunctionTypeEN.FuncTypeENName !=  null)
 {
 var strFuncTypeENName = objFunctionTypeEN.FuncTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeENName, conFunctionType.FuncTypeENName); //函数类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionType.FuncTypeENName); //函数类型英文名
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.CodeTypeId))
 {
 if (objFunctionTypeEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objFunctionTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conFunctionType.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionType.CodeTypeId); //代码类型Id
 }
 }
 
 if (objFunctionTypeEN.IsUpdated(conFunctionType.Memo))
 {
 if (objFunctionTypeEN.Memo !=  null)
 {
 var strMemo = objFunctionTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunctionType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncTypeId = '{0}'", objFunctionTypeEN.FuncTypeId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "strFuncTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncTypeId) 
{
CheckPrimaryKey(strFuncTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFuncTypeId,
};
 objSQL.ExecSP("FunctionType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFuncTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFuncTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFuncTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
//删除FunctionType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionType where FuncTypeId = " + "'"+ strFuncTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFunctionType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除FunctionType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionType where FuncTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFuncTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFuncTypeId) 
{
CheckPrimaryKey(strFuncTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
//删除FunctionType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionType where FuncTypeId = " + "'"+ strFuncTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFunctionType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFunctionTypeDA: DelFunctionType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionType where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelFunctionTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFunctionTypeDA: DelFunctionTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionType where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objFunctionTypeENS">源对象</param>
 /// <param name = "objFunctionTypeENT">目标对象</param>
public void CopyTo(clsFunctionTypeEN objFunctionTypeENS, clsFunctionTypeEN objFunctionTypeENT)
{
objFunctionTypeENT.FuncTypeId = objFunctionTypeENS.FuncTypeId; //函数类型Id
objFunctionTypeENT.FuncTypeName = objFunctionTypeENS.FuncTypeName; //函数类型名
objFunctionTypeENT.FuncTypeENName = objFunctionTypeENS.FuncTypeENName; //函数类型英文名
objFunctionTypeENT.CodeTypeId = objFunctionTypeENS.CodeTypeId; //代码类型Id
objFunctionTypeENT.Memo = objFunctionTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFunctionTypeEN objFunctionTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFunctionTypeEN.FuncTypeName, conFunctionType.FuncTypeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionTypeEN.FuncTypeId, 2, conFunctionType.FuncTypeId);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.FuncTypeName, 20, conFunctionType.FuncTypeName);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.FuncTypeENName, 50, conFunctionType.FuncTypeENName);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.CodeTypeId, 4, conFunctionType.CodeTypeId);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.Memo, 1000, conFunctionType.Memo);
//检查字段外键固定长度
 objFunctionTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFunctionTypeEN objFunctionTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionTypeEN.FuncTypeName, 20, conFunctionType.FuncTypeName);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.FuncTypeENName, 50, conFunctionType.FuncTypeENName);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.CodeTypeId, 4, conFunctionType.CodeTypeId);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.Memo, 1000, conFunctionType.Memo);
//检查外键字段长度
 objFunctionTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFunctionTypeEN objFunctionTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionTypeEN.FuncTypeId, 2, conFunctionType.FuncTypeId);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.FuncTypeName, 20, conFunctionType.FuncTypeName);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.FuncTypeENName, 50, conFunctionType.FuncTypeENName);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.CodeTypeId, 4, conFunctionType.CodeTypeId);
clsCheckSql.CheckFieldLen(objFunctionTypeEN.Memo, 1000, conFunctionType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFunctionTypeEN.FuncTypeId, conFunctionType.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunctionTypeEN.FuncTypeName, conFunctionType.FuncTypeName);
clsCheckSql.CheckSqlInjection4Field(objFunctionTypeEN.FuncTypeENName, conFunctionType.FuncTypeENName);
clsCheckSql.CheckSqlInjection4Field(objFunctionTypeEN.CodeTypeId, conFunctionType.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunctionTypeEN.Memo, conFunctionType.Memo);
//检查外键字段长度
 objFunctionTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFuncTypeId()
{
//获取某学院所有专业信息
string strSQL = "select FuncTypeId, FuncTypeName from FunctionType ";
 clsSpecSQLforSql mySql = clsFunctionTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FunctionType(函数类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunctionTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFunctionTypeEN objFunctionTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objFunctionTypeEN.FuncTypeName);
return sbCondition.ToString();
}

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
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
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
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
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
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionTypeEN._CurrTabName);
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
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionTypeEN._CurrTabName, strCondition);
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
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}