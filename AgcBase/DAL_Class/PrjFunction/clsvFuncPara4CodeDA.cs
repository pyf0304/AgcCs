
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncPara4CodeDA
 表名:vFuncPara4Code(00050385)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:54
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
 /// v函数参数4Code(vFuncPara4Code)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFuncPara4CodeDA : clsCommBase4DA
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
 return clsvFuncPara4CodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFuncPara4CodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncPara4CodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFuncPara4CodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFuncPara4CodeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncParaId4Code">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncParaId4Code)
{
strFuncParaId4Code = strFuncParaId4Code.Replace("'", "''");
if (strFuncParaId4Code.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vFuncPara4Code中,检查关键字,长度不正确!(clsvFuncPara4CodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncParaId4Code)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFuncPara4Code中,关键字不能为空 或 null!(clsvFuncPara4CodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncParaId4Code);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFuncPara4CodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFuncPara4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFuncPara4Code(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetDataTable_vFuncPara4Code)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFuncPara4Code where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFuncPara4Code where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncPara4Code where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncPara4Code where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFuncPara4Code where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFuncPara4Code.* " + 
$"from vFuncPara4Code " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFuncPara4Code.FuncParaId4Code not in " + 
$"(Select top {intTop_In} vFuncPara4Code.FuncParaId4Code from vFuncPara4Code " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncPara4Code where {1} and FuncParaId4Code not in (Select top {2} FuncParaId4Code from vFuncPara4Code where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncPara4Code where {1} and FuncParaId4Code not in (Select top {3} FuncParaId4Code from vFuncPara4Code where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFuncPara4Code.* " + 
$"from vFuncPara4Code " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFuncPara4Code.FuncParaId4Code not in " + 
$"(Select top {intTop_In} vFuncPara4Code.FuncParaId4Code from vFuncPara4Code " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncPara4Code where {1} and FuncParaId4Code not in (Select top {2} FuncParaId4Code from vFuncPara4Code where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncPara4Code where {1} and FuncParaId4Code not in (Select top {3} FuncParaId4Code from vFuncPara4Code where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFuncPara4CodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA:GetObjLst)", objException.Message));
}
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFuncPara4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = TransNullToBool(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = TransNullToBool(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFuncPara4CodeDA: GetObjLst)", objException.Message));
}
objvFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFuncPara4CodeEN);
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
public List<clsvFuncPara4CodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = TransNullToBool(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = TransNullToBool(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFuncPara4CodeDA: GetObjLst)", objException.Message));
}
objvFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFuncPara4CodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFuncPara4Code(ref clsvFuncPara4CodeEN objvFuncPara4CodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFuncPara4Code where FuncParaId4Code = " + "'"+ objvFuncPara4CodeEN.FuncParaId4Code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFuncPara4CodeEN.FuncParaId4Code = objDT.Rows[0][convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvFuncPara4CodeEN.ParaName = objDT.Rows[0][convFuncPara4Code.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFuncPara4CodeEN.ParaCnName = objDT.Rows[0][convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFuncPara4CodeEN.DataTypeId = objDT.Rows[0][convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFuncPara4CodeEN.DataTypeName = objDT.Rows[0][convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.DataCnName = objDT.Rows[0][convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncPara4CodeEN.CsType = objDT.Rows[0][convFuncPara4Code.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncPara4CodeEN.JavaType = objDT.Rows[0][convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncPara4CodeEN.JavaObjType = objDT.Rows[0][convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.SwiftType = objDT.Rows[0][convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.IsNeedQuote = TransNullToBool(objDT.Rows[0][convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvFuncPara4CodeEN.OraDbType = objDT.Rows[0][convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncPara4CodeEN.MySqlType = objDT.Rows[0][convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.ParameterType = objDT.Rows[0][convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.ParameterTypeFullName = objDT.Rows[0][convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvFuncPara4CodeEN.IsByRef = TransNullToBool(objDT.Rows[0][convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvFuncPara4CodeEN.PrjId = objDT.Rows[0][convFuncPara4Code.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFuncPara4CodeEN.FuncPurposeId = objDT.Rows[0][convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id(字段类型:char,字段长度:2,是否可空:False)
 objvFuncPara4CodeEN.UpdDate = objDT.Rows[0][convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncPara4CodeEN.UpdUser = objDT.Rows[0][convFuncPara4Code.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncPara4CodeEN.Memo = objDT.Rows[0][convFuncPara4Code.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncPara4CodeEN.FuncCount = TransNullToInt(objDT.Rows[0][convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFuncPara4CodeDA: GetvFuncPara4Code)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncParaId4Code">表关键字</param>
 /// <returns>表对象</returns>
public clsvFuncPara4CodeEN GetObjByFuncParaId4Code(string strFuncParaId4Code)
{
CheckPrimaryKey(strFuncParaId4Code);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFuncPara4Code where FuncParaId4Code = " + "'"+ strFuncParaId4Code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
 objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id(字段类型:char,字段长度:2,是否可空:False)
 objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFuncPara4CodeDA: GetObjByFuncParaId4Code)", objException.Message));
}
return objvFuncPara4CodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFuncPara4CodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFuncPara4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN()
{
FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(), //函数参数Id
ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(), //参数名
ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(), //参数中文名
DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(), //数据类型名称
DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(), //数据类型中文名称
CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(), //CS类型
JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(), //JAVA类型
JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(), //JAVA对象类型
SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(), //SwiftType
IsNeedQuote = TransNullToBool(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()), //是否需要引号
OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(), //Ora数据类型
MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(), //MySqlType
ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(), //参数类型
ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(), //参数类型全名
IsByRef = TransNullToBool(objRow[convFuncPara4Code.IsByRef].ToString().Trim()), //是否引用型参数
PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(), //工程Id
FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(), //函数用途Id
UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(), //说明
FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncPara4Code.FuncCount].ToString().Trim()) //函数数目
};
objvFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncPara4CodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFuncPara4CodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFuncPara4CodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = TransNullToBool(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = TransNullToBool(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFuncPara4CodeDA: GetObjByDataRowvFuncPara4Code)", objException.Message));
}
objvFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncPara4CodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFuncPara4CodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = TransNullToBool(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = TransNullToBool(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFuncPara4CodeDA: GetObjByDataRow)", objException.Message));
}
objvFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncPara4CodeEN;
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
objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFuncPara4CodeEN._CurrTabName, convFuncPara4Code.FuncParaId4Code, 8, "");
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
objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFuncPara4CodeEN._CurrTabName, convFuncPara4Code.FuncParaId4Code, 8, strPrefix);
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
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncParaId4Code from vFuncPara4Code where " + strCondition;
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
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncParaId4Code from vFuncPara4Code where " + strCondition;
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
 /// <param name = "strFuncParaId4Code">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncParaId4Code)
{
CheckPrimaryKey(strFuncParaId4Code);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFuncPara4Code", "FuncParaId4Code = " + "'"+ strFuncParaId4Code+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFuncPara4CodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFuncPara4Code", strCondition))
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
objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFuncPara4Code");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFuncPara4CodeENS">源对象</param>
 /// <param name = "objvFuncPara4CodeENT">目标对象</param>
public void CopyTo(clsvFuncPara4CodeEN objvFuncPara4CodeENS, clsvFuncPara4CodeEN objvFuncPara4CodeENT)
{
objvFuncPara4CodeENT.FuncParaId4Code = objvFuncPara4CodeENS.FuncParaId4Code; //函数参数Id
objvFuncPara4CodeENT.ParaName = objvFuncPara4CodeENS.ParaName; //参数名
objvFuncPara4CodeENT.ParaCnName = objvFuncPara4CodeENS.ParaCnName; //参数中文名
objvFuncPara4CodeENT.DataTypeId = objvFuncPara4CodeENS.DataTypeId; //数据类型Id
objvFuncPara4CodeENT.DataTypeName = objvFuncPara4CodeENS.DataTypeName; //数据类型名称
objvFuncPara4CodeENT.DataCnName = objvFuncPara4CodeENS.DataCnName; //数据类型中文名称
objvFuncPara4CodeENT.CsType = objvFuncPara4CodeENS.CsType; //CS类型
objvFuncPara4CodeENT.JavaType = objvFuncPara4CodeENS.JavaType; //JAVA类型
objvFuncPara4CodeENT.JavaObjType = objvFuncPara4CodeENS.JavaObjType; //JAVA对象类型
objvFuncPara4CodeENT.SwiftType = objvFuncPara4CodeENS.SwiftType; //SwiftType
objvFuncPara4CodeENT.IsNeedQuote = objvFuncPara4CodeENS.IsNeedQuote; //是否需要引号
objvFuncPara4CodeENT.OraDbType = objvFuncPara4CodeENS.OraDbType; //Ora数据类型
objvFuncPara4CodeENT.MySqlType = objvFuncPara4CodeENS.MySqlType; //MySqlType
objvFuncPara4CodeENT.ParameterType = objvFuncPara4CodeENS.ParameterType; //参数类型
objvFuncPara4CodeENT.ParameterTypeFullName = objvFuncPara4CodeENS.ParameterTypeFullName; //参数类型全名
objvFuncPara4CodeENT.IsByRef = objvFuncPara4CodeENS.IsByRef; //是否引用型参数
objvFuncPara4CodeENT.PrjId = objvFuncPara4CodeENS.PrjId; //工程Id
objvFuncPara4CodeENT.FuncPurposeId = objvFuncPara4CodeENS.FuncPurposeId; //函数用途Id
objvFuncPara4CodeENT.UpdDate = objvFuncPara4CodeENS.UpdDate; //修改日期
objvFuncPara4CodeENT.UpdUser = objvFuncPara4CodeENS.UpdUser; //修改者
objvFuncPara4CodeENT.Memo = objvFuncPara4CodeENS.Memo; //说明
objvFuncPara4CodeENT.FuncCount = objvFuncPara4CodeENS.FuncCount; //函数数目
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFuncPara4CodeEN objvFuncPara4CodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.FuncParaId4Code, 8, convFuncPara4Code.FuncParaId4Code);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.ParaName, 50, convFuncPara4Code.ParaName);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.ParaCnName, 50, convFuncPara4Code.ParaCnName);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.DataTypeId, 2, convFuncPara4Code.DataTypeId);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.DataTypeName, 100, convFuncPara4Code.DataTypeName);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.DataCnName, 100, convFuncPara4Code.DataCnName);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.CsType, 100, convFuncPara4Code.CsType);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.JavaType, 100, convFuncPara4Code.JavaType);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.JavaObjType, 100, convFuncPara4Code.JavaObjType);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.SwiftType, 100, convFuncPara4Code.SwiftType);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.OraDbType, 100, convFuncPara4Code.OraDbType);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.MySqlType, 100, convFuncPara4Code.MySqlType);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.ParameterType, 100, convFuncPara4Code.ParameterType);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.ParameterTypeFullName, 500, convFuncPara4Code.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.PrjId, 4, convFuncPara4Code.PrjId);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.FuncPurposeId, 2, convFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.UpdDate, 20, convFuncPara4Code.UpdDate);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.UpdUser, 20, convFuncPara4Code.UpdUser);
clsCheckSql.CheckFieldLen(objvFuncPara4CodeEN.Memo, 1000, convFuncPara4Code.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.FuncParaId4Code, convFuncPara4Code.FuncParaId4Code);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.ParaName, convFuncPara4Code.ParaName);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.ParaCnName, convFuncPara4Code.ParaCnName);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.DataTypeId, convFuncPara4Code.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.DataTypeName, convFuncPara4Code.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.DataCnName, convFuncPara4Code.DataCnName);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.CsType, convFuncPara4Code.CsType);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.JavaType, convFuncPara4Code.JavaType);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.JavaObjType, convFuncPara4Code.JavaObjType);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.SwiftType, convFuncPara4Code.SwiftType);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.OraDbType, convFuncPara4Code.OraDbType);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.MySqlType, convFuncPara4Code.MySqlType);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.ParameterType, convFuncPara4Code.ParameterType);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.ParameterTypeFullName, convFuncPara4Code.ParameterTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.PrjId, convFuncPara4Code.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.FuncPurposeId, convFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.UpdDate, convFuncPara4Code.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.UpdUser, convFuncPara4Code.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFuncPara4CodeEN.Memo, convFuncPara4Code.Memo);
//检查外键字段长度
 objvFuncPara4CodeEN._IsCheckProperty = true;
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
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
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
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
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
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFuncPara4CodeEN._CurrTabName);
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
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFuncPara4CodeEN._CurrTabName, strCondition);
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
 objSQL = clsvFuncPara4CodeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}