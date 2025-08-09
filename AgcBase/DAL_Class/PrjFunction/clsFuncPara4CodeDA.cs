
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncPara4CodeDA
 表名:FuncPara4Code(00050384)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:38
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
 /// 函数参数4Code(FuncPara4Code)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFuncPara4CodeDA : clsCommBase4DA
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
 return clsFuncPara4CodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFuncPara4CodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncPara4CodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFuncPara4CodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFuncPara4CodeEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:FuncPara4Code中,检查关键字,长度不正确!(clsFuncPara4CodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncParaId4Code)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FuncPara4Code中,关键字不能为空 或 null!(clsFuncPara4CodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncParaId4Code);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFuncPara4CodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FuncPara4Code(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetDataTable_FuncPara4Code)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncPara4Code where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncPara4Code where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FuncPara4Code where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FuncPara4Code.* " + 
$"from FuncPara4Code " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FuncPara4Code.FuncParaId4Code not in " + 
$"(Select top {intTop_In} FuncPara4Code.FuncParaId4Code from FuncPara4Code " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncPara4Code where {1} and FuncParaId4Code not in (Select top {2} FuncParaId4Code from FuncPara4Code where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncPara4Code where {1} and FuncParaId4Code not in (Select top {3} FuncParaId4Code from FuncPara4Code where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FuncPara4Code.* " + 
$"from FuncPara4Code " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FuncPara4Code.FuncParaId4Code not in " + 
$"(Select top {intTop_In} FuncPara4Code.FuncParaId4Code from FuncPara4Code " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncPara4Code where {1} and FuncParaId4Code not in (Select top {2} FuncParaId4Code from FuncPara4Code where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncPara4Code where {1} and FuncParaId4Code not in (Select top {3} FuncParaId4Code from FuncPara4Code where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFuncPara4CodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA:GetObjLst)", objException.Message));
}
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = TransNullToBool(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = TransNullToBool(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncPara4CodeDA: GetObjLst)", objException.Message));
}
objFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncPara4CodeEN);
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
public List<clsFuncPara4CodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = TransNullToBool(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = TransNullToBool(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncPara4CodeDA: GetObjLst)", objException.Message));
}
objFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncPara4CodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFuncPara4Code(ref clsFuncPara4CodeEN objFuncPara4CodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where FuncParaId4Code = " + "'"+ objFuncPara4CodeEN.FuncParaId4Code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFuncPara4CodeEN.FuncParaId4Code = objDT.Rows[0][conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objFuncPara4CodeEN.ParaName = objDT.Rows[0][conFuncPara4Code.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objFuncPara4CodeEN.ParaCnName = objDT.Rows[0][conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objFuncPara4CodeEN.DataTypeId = objDT.Rows[0][conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFuncPara4CodeEN.ParameterType = objDT.Rows[0][conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objFuncPara4CodeEN.ParameterTypeFullName = objDT.Rows[0][conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objFuncPara4CodeEN.IsByRef = TransNullToBool(objDT.Rows[0][conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objFuncPara4CodeEN.PrjId = objDT.Rows[0][conFuncPara4Code.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFuncPara4CodeEN.IsTemplate = TransNullToBool(objDT.Rows[0][conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objFuncPara4CodeEN.FuncPurposeId = objDT.Rows[0][conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id(字段类型:char,字段长度:2,是否可空:False)
 objFuncPara4CodeEN.UpdDate = objDT.Rows[0][conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncPara4CodeEN.UpdUser = objDT.Rows[0][conFuncPara4Code.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncPara4CodeEN.Memo = objDT.Rows[0][conFuncPara4Code.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFuncPara4CodeDA: GetFuncPara4Code)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncParaId4Code">表关键字</param>
 /// <returns>表对象</returns>
public clsFuncPara4CodeEN GetObjByFuncParaId4Code(string strFuncParaId4Code)
{
CheckPrimaryKey(strFuncParaId4Code);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where FuncParaId4Code = " + "'"+ strFuncParaId4Code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
 objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id(字段类型:char,字段长度:2,是否可空:False)
 objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFuncPara4CodeDA: GetObjByFuncParaId4Code)", objException.Message));
}
return objFuncPara4CodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFuncPara4CodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN()
{
FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(), //函数参数Id
ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(), //参数名
ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(), //参数中文名
DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(), //数据类型Id
ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(), //参数类型
ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(), //参数类型全名
IsByRef = TransNullToBool(objRow[conFuncPara4Code.IsByRef].ToString().Trim()), //是否引用型参数
PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(), //工程Id
IsTemplate = TransNullToBool(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()), //是否模板
FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(), //函数用途Id
UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim() //说明
};
objFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncPara4CodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFuncPara4CodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFuncPara4CodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = TransNullToBool(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = TransNullToBool(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFuncPara4CodeDA: GetObjByDataRowFuncPara4Code)", objException.Message));
}
objFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncPara4CodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFuncPara4CodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = TransNullToBool(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = TransNullToBool(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFuncPara4CodeDA: GetObjByDataRow)", objException.Message));
}
objFuncPara4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncPara4CodeEN;
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
objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncPara4CodeEN._CurrTabName, conFuncPara4Code.FuncParaId4Code, 8, "");
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
objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncPara4CodeEN._CurrTabName, conFuncPara4Code.FuncParaId4Code, 8, strPrefix);
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
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncParaId4Code from FuncPara4Code where " + strCondition;
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
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncParaId4Code from FuncPara4Code where " + strCondition;
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
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncPara4Code", "FuncParaId4Code = " + "'"+ strFuncParaId4Code+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncPara4Code", strCondition))
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
objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FuncPara4Code");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFuncPara4CodeEN objFuncPara4CodeEN)
 {
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncPara4CodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncPara4Code");
objRow = objDS.Tables["FuncPara4Code"].NewRow();
objRow[conFuncPara4Code.FuncParaId4Code] = objFuncPara4CodeEN.FuncParaId4Code; //函数参数Id
objRow[conFuncPara4Code.ParaName] = objFuncPara4CodeEN.ParaName; //参数名
objRow[conFuncPara4Code.ParaCnName] = objFuncPara4CodeEN.ParaCnName; //参数中文名
objRow[conFuncPara4Code.DataTypeId] = objFuncPara4CodeEN.DataTypeId; //数据类型Id
 if (objFuncPara4CodeEN.ParameterType !=  "")
 {
objRow[conFuncPara4Code.ParameterType] = objFuncPara4CodeEN.ParameterType; //参数类型
 }
 if (objFuncPara4CodeEN.ParameterTypeFullName !=  "")
 {
objRow[conFuncPara4Code.ParameterTypeFullName] = objFuncPara4CodeEN.ParameterTypeFullName; //参数类型全名
 }
objRow[conFuncPara4Code.IsByRef] = objFuncPara4CodeEN.IsByRef; //是否引用型参数
 if (objFuncPara4CodeEN.PrjId !=  "")
 {
objRow[conFuncPara4Code.PrjId] = objFuncPara4CodeEN.PrjId; //工程Id
 }
objRow[conFuncPara4Code.IsTemplate] = objFuncPara4CodeEN.IsTemplate; //是否模板
objRow[conFuncPara4Code.FuncPurposeId] = objFuncPara4CodeEN.FuncPurposeId; //函数用途Id
 if (objFuncPara4CodeEN.UpdDate !=  "")
 {
objRow[conFuncPara4Code.UpdDate] = objFuncPara4CodeEN.UpdDate; //修改日期
 }
 if (objFuncPara4CodeEN.UpdUser !=  "")
 {
objRow[conFuncPara4Code.UpdUser] = objFuncPara4CodeEN.UpdUser; //修改者
 }
 if (objFuncPara4CodeEN.Memo !=  "")
 {
objRow[conFuncPara4Code.Memo] = objFuncPara4CodeEN.Memo; //说明
 }
objDS.Tables[clsFuncPara4CodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFuncPara4CodeEN._CurrTabName);
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncPara4CodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncPara4CodeEN.FuncParaId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.FuncParaId4Code);
 var strFuncParaId4Code = objFuncPara4CodeEN.FuncParaId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaId4Code + "'");
 }
 
 if (objFuncPara4CodeEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParaName);
 var strParaName = objFuncPara4CodeEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objFuncPara4CodeEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParaCnName);
 var strParaCnName = objFuncPara4CodeEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 if (objFuncPara4CodeEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.DataTypeId);
 var strDataTypeId = objFuncPara4CodeEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objFuncPara4CodeEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParameterType);
 var strParameterType = objFuncPara4CodeEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objFuncPara4CodeEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParameterTypeFullName);
 var strParameterTypeFullName = objFuncPara4CodeEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conFuncPara4Code.IsByRef);
 arrValueListForInsert.Add("'" + (objFuncPara4CodeEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objFuncPara4CodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.PrjId);
 var strPrjId = objFuncPara4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conFuncPara4Code.IsTemplate);
 arrValueListForInsert.Add("'" + (objFuncPara4CodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFuncPara4CodeEN.FuncPurposeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.FuncPurposeId);
 var strFuncPurposeId = objFuncPara4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncPurposeId + "'");
 }
 
 if (objFuncPara4CodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.UpdDate);
 var strUpdDate = objFuncPara4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncPara4CodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.UpdUser);
 var strUpdUser = objFuncPara4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncPara4CodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.Memo);
 var strMemo = objFuncPara4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncPara4Code");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncPara4CodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncPara4CodeEN.FuncParaId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.FuncParaId4Code);
 var strFuncParaId4Code = objFuncPara4CodeEN.FuncParaId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaId4Code + "'");
 }
 
 if (objFuncPara4CodeEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParaName);
 var strParaName = objFuncPara4CodeEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objFuncPara4CodeEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParaCnName);
 var strParaCnName = objFuncPara4CodeEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 if (objFuncPara4CodeEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.DataTypeId);
 var strDataTypeId = objFuncPara4CodeEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objFuncPara4CodeEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParameterType);
 var strParameterType = objFuncPara4CodeEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objFuncPara4CodeEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParameterTypeFullName);
 var strParameterTypeFullName = objFuncPara4CodeEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conFuncPara4Code.IsByRef);
 arrValueListForInsert.Add("'" + (objFuncPara4CodeEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objFuncPara4CodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.PrjId);
 var strPrjId = objFuncPara4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conFuncPara4Code.IsTemplate);
 arrValueListForInsert.Add("'" + (objFuncPara4CodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFuncPara4CodeEN.FuncPurposeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.FuncPurposeId);
 var strFuncPurposeId = objFuncPara4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncPurposeId + "'");
 }
 
 if (objFuncPara4CodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.UpdDate);
 var strUpdDate = objFuncPara4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncPara4CodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.UpdUser);
 var strUpdUser = objFuncPara4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncPara4CodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.Memo);
 var strMemo = objFuncPara4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncPara4Code");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFuncPara4CodeEN.FuncParaId4Code;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncPara4CodeEN objFuncPara4CodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncPara4CodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncPara4CodeEN.FuncParaId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.FuncParaId4Code);
 var strFuncParaId4Code = objFuncPara4CodeEN.FuncParaId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaId4Code + "'");
 }
 
 if (objFuncPara4CodeEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParaName);
 var strParaName = objFuncPara4CodeEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objFuncPara4CodeEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParaCnName);
 var strParaCnName = objFuncPara4CodeEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 if (objFuncPara4CodeEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.DataTypeId);
 var strDataTypeId = objFuncPara4CodeEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objFuncPara4CodeEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParameterType);
 var strParameterType = objFuncPara4CodeEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objFuncPara4CodeEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParameterTypeFullName);
 var strParameterTypeFullName = objFuncPara4CodeEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conFuncPara4Code.IsByRef);
 arrValueListForInsert.Add("'" + (objFuncPara4CodeEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objFuncPara4CodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.PrjId);
 var strPrjId = objFuncPara4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conFuncPara4Code.IsTemplate);
 arrValueListForInsert.Add("'" + (objFuncPara4CodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFuncPara4CodeEN.FuncPurposeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.FuncPurposeId);
 var strFuncPurposeId = objFuncPara4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncPurposeId + "'");
 }
 
 if (objFuncPara4CodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.UpdDate);
 var strUpdDate = objFuncPara4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncPara4CodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.UpdUser);
 var strUpdUser = objFuncPara4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncPara4CodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.Memo);
 var strMemo = objFuncPara4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncPara4Code");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFuncPara4CodeEN.FuncParaId4Code;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncPara4CodeEN objFuncPara4CodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncPara4CodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncPara4CodeEN.FuncParaId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.FuncParaId4Code);
 var strFuncParaId4Code = objFuncPara4CodeEN.FuncParaId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaId4Code + "'");
 }
 
 if (objFuncPara4CodeEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParaName);
 var strParaName = objFuncPara4CodeEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objFuncPara4CodeEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParaCnName);
 var strParaCnName = objFuncPara4CodeEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 if (objFuncPara4CodeEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.DataTypeId);
 var strDataTypeId = objFuncPara4CodeEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objFuncPara4CodeEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParameterType);
 var strParameterType = objFuncPara4CodeEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objFuncPara4CodeEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.ParameterTypeFullName);
 var strParameterTypeFullName = objFuncPara4CodeEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conFuncPara4Code.IsByRef);
 arrValueListForInsert.Add("'" + (objFuncPara4CodeEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objFuncPara4CodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.PrjId);
 var strPrjId = objFuncPara4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conFuncPara4Code.IsTemplate);
 arrValueListForInsert.Add("'" + (objFuncPara4CodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFuncPara4CodeEN.FuncPurposeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.FuncPurposeId);
 var strFuncPurposeId = objFuncPara4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncPurposeId + "'");
 }
 
 if (objFuncPara4CodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.UpdDate);
 var strUpdDate = objFuncPara4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncPara4CodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.UpdUser);
 var strUpdUser = objFuncPara4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncPara4CodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncPara4Code.Memo);
 var strMemo = objFuncPara4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncPara4Code");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFuncPara4Codes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where FuncParaId4Code = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncPara4Code");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFuncParaId4Code = oRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim();
if (IsExist(strFuncParaId4Code))
{
 string strResult = "关键字变量值为:" + string.Format("FuncParaId4Code = {0}", strFuncParaId4Code) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFuncPara4CodeEN._CurrTabName ].NewRow();
objRow[conFuncPara4Code.FuncParaId4Code] = oRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objRow[conFuncPara4Code.ParaName] = oRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objRow[conFuncPara4Code.ParaCnName] = oRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objRow[conFuncPara4Code.DataTypeId] = oRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objRow[conFuncPara4Code.ParameterType] = oRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objRow[conFuncPara4Code.ParameterTypeFullName] = oRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objRow[conFuncPara4Code.IsByRef] = oRow[conFuncPara4Code.IsByRef].ToString().Trim(); //是否引用型参数
objRow[conFuncPara4Code.PrjId] = oRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objRow[conFuncPara4Code.IsTemplate] = oRow[conFuncPara4Code.IsTemplate].ToString().Trim(); //是否模板
objRow[conFuncPara4Code.FuncPurposeId] = oRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objRow[conFuncPara4Code.UpdDate] = oRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objRow[conFuncPara4Code.UpdUser] = oRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objRow[conFuncPara4Code.Memo] = oRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFuncPara4CodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFuncPara4CodeEN._CurrTabName);
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
 /// <param name = "objFuncPara4CodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncPara4CodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
strSQL = "Select * from FuncPara4Code where FuncParaId4Code = " + "'"+ objFuncPara4CodeEN.FuncParaId4Code+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFuncPara4CodeEN._CurrTabName);
if (objDS.Tables[clsFuncPara4CodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FuncParaId4Code = " + "'"+ objFuncPara4CodeEN.FuncParaId4Code+"'");
return false;
}
objRow = objDS.Tables[clsFuncPara4CodeEN._CurrTabName].Rows[0];
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.FuncParaId4Code))
 {
objRow[conFuncPara4Code.FuncParaId4Code] = objFuncPara4CodeEN.FuncParaId4Code; //函数参数Id
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaName))
 {
objRow[conFuncPara4Code.ParaName] = objFuncPara4CodeEN.ParaName; //参数名
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaCnName))
 {
objRow[conFuncPara4Code.ParaCnName] = objFuncPara4CodeEN.ParaCnName; //参数中文名
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.DataTypeId))
 {
objRow[conFuncPara4Code.DataTypeId] = objFuncPara4CodeEN.DataTypeId; //数据类型Id
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterType))
 {
objRow[conFuncPara4Code.ParameterType] = objFuncPara4CodeEN.ParameterType; //参数类型
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterTypeFullName))
 {
objRow[conFuncPara4Code.ParameterTypeFullName] = objFuncPara4CodeEN.ParameterTypeFullName; //参数类型全名
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsByRef))
 {
objRow[conFuncPara4Code.IsByRef] = objFuncPara4CodeEN.IsByRef; //是否引用型参数
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.PrjId))
 {
objRow[conFuncPara4Code.PrjId] = objFuncPara4CodeEN.PrjId; //工程Id
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsTemplate))
 {
objRow[conFuncPara4Code.IsTemplate] = objFuncPara4CodeEN.IsTemplate; //是否模板
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.FuncPurposeId))
 {
objRow[conFuncPara4Code.FuncPurposeId] = objFuncPara4CodeEN.FuncPurposeId; //函数用途Id
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdDate))
 {
objRow[conFuncPara4Code.UpdDate] = objFuncPara4CodeEN.UpdDate; //修改日期
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdUser))
 {
objRow[conFuncPara4Code.UpdUser] = objFuncPara4CodeEN.UpdUser; //修改者
 }
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.Memo))
 {
objRow[conFuncPara4Code.Memo] = objFuncPara4CodeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFuncPara4CodeEN._CurrTabName);
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncPara4CodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FuncPara4Code Set ");
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaName))
 {
 if (objFuncPara4CodeEN.ParaName !=  null)
 {
 var strParaName = objFuncPara4CodeEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaName, conFuncPara4Code.ParaName); //参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.ParaName); //参数名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaCnName))
 {
 if (objFuncPara4CodeEN.ParaCnName !=  null)
 {
 var strParaCnName = objFuncPara4CodeEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaCnName, conFuncPara4Code.ParaCnName); //参数中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.ParaCnName); //参数中文名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.DataTypeId))
 {
 if (objFuncPara4CodeEN.DataTypeId !=  null)
 {
 var strDataTypeId = objFuncPara4CodeEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conFuncPara4Code.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.DataTypeId); //数据类型Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterType))
 {
 if (objFuncPara4CodeEN.ParameterType !=  null)
 {
 var strParameterType = objFuncPara4CodeEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterType, conFuncPara4Code.ParameterType); //参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.ParameterType); //参数类型
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterTypeFullName))
 {
 if (objFuncPara4CodeEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objFuncPara4CodeEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterTypeFullName, conFuncPara4Code.ParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.ParameterTypeFullName); //参数类型全名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsByRef))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFuncPara4CodeEN.IsByRef == true?"1":"0", conFuncPara4Code.IsByRef); //是否引用型参数
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.PrjId))
 {
 if (objFuncPara4CodeEN.PrjId !=  null)
 {
 var strPrjId = objFuncPara4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFuncPara4Code.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.PrjId); //工程Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFuncPara4CodeEN.IsTemplate == true?"1":"0", conFuncPara4Code.IsTemplate); //是否模板
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.FuncPurposeId))
 {
 if (objFuncPara4CodeEN.FuncPurposeId !=  null)
 {
 var strFuncPurposeId = objFuncPara4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncPurposeId, conFuncPara4Code.FuncPurposeId); //函数用途Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.FuncPurposeId); //函数用途Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdDate))
 {
 if (objFuncPara4CodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncPara4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFuncPara4Code.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.UpdDate); //修改日期
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdUser))
 {
 if (objFuncPara4CodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncPara4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFuncPara4Code.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.UpdUser); //修改者
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.Memo))
 {
 if (objFuncPara4CodeEN.Memo !=  null)
 {
 var strMemo = objFuncPara4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFuncPara4Code.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncParaId4Code = '{0}'", objFuncPara4CodeEN.FuncParaId4Code); 
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
 /// <param name = "objFuncPara4CodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFuncPara4CodeEN objFuncPara4CodeEN, string strCondition)
{
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncPara4CodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncPara4Code Set ");
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaName))
 {
 if (objFuncPara4CodeEN.ParaName !=  null)
 {
 var strParaName = objFuncPara4CodeEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaName = '{0}',", strParaName); //参数名
 }
 else
 {
 sbSQL.Append(" ParaName = null,"); //参数名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaCnName))
 {
 if (objFuncPara4CodeEN.ParaCnName !=  null)
 {
 var strParaCnName = objFuncPara4CodeEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaCnName = '{0}',", strParaCnName); //参数中文名
 }
 else
 {
 sbSQL.Append(" ParaCnName = null,"); //参数中文名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.DataTypeId))
 {
 if (objFuncPara4CodeEN.DataTypeId !=  null)
 {
 var strDataTypeId = objFuncPara4CodeEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterType))
 {
 if (objFuncPara4CodeEN.ParameterType !=  null)
 {
 var strParameterType = objFuncPara4CodeEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterType = '{0}',", strParameterType); //参数类型
 }
 else
 {
 sbSQL.Append(" ParameterType = null,"); //参数类型
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterTypeFullName))
 {
 if (objFuncPara4CodeEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objFuncPara4CodeEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterTypeFullName = '{0}',", strParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.Append(" ParameterTypeFullName = null,"); //参数类型全名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsByRef))
 {
 sbSQL.AppendFormat(" IsByRef = '{0}',", objFuncPara4CodeEN.IsByRef == true?"1":"0"); //是否引用型参数
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.PrjId))
 {
 if (objFuncPara4CodeEN.PrjId !=  null)
 {
 var strPrjId = objFuncPara4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objFuncPara4CodeEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.FuncPurposeId))
 {
 if (objFuncPara4CodeEN.FuncPurposeId !=  null)
 {
 var strFuncPurposeId = objFuncPara4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncPurposeId = '{0}',", strFuncPurposeId); //函数用途Id
 }
 else
 {
 sbSQL.Append(" FuncPurposeId = null,"); //函数用途Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdDate))
 {
 if (objFuncPara4CodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncPara4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdUser))
 {
 if (objFuncPara4CodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncPara4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.Memo))
 {
 if (objFuncPara4CodeEN.Memo !=  null)
 {
 var strMemo = objFuncPara4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFuncPara4CodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFuncPara4CodeEN objFuncPara4CodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncPara4CodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncPara4Code Set ");
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaName))
 {
 if (objFuncPara4CodeEN.ParaName !=  null)
 {
 var strParaName = objFuncPara4CodeEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaName = '{0}',", strParaName); //参数名
 }
 else
 {
 sbSQL.Append(" ParaName = null,"); //参数名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaCnName))
 {
 if (objFuncPara4CodeEN.ParaCnName !=  null)
 {
 var strParaCnName = objFuncPara4CodeEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaCnName = '{0}',", strParaCnName); //参数中文名
 }
 else
 {
 sbSQL.Append(" ParaCnName = null,"); //参数中文名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.DataTypeId))
 {
 if (objFuncPara4CodeEN.DataTypeId !=  null)
 {
 var strDataTypeId = objFuncPara4CodeEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterType))
 {
 if (objFuncPara4CodeEN.ParameterType !=  null)
 {
 var strParameterType = objFuncPara4CodeEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterType = '{0}',", strParameterType); //参数类型
 }
 else
 {
 sbSQL.Append(" ParameterType = null,"); //参数类型
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterTypeFullName))
 {
 if (objFuncPara4CodeEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objFuncPara4CodeEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterTypeFullName = '{0}',", strParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.Append(" ParameterTypeFullName = null,"); //参数类型全名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsByRef))
 {
 sbSQL.AppendFormat(" IsByRef = '{0}',", objFuncPara4CodeEN.IsByRef == true?"1":"0"); //是否引用型参数
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.PrjId))
 {
 if (objFuncPara4CodeEN.PrjId !=  null)
 {
 var strPrjId = objFuncPara4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objFuncPara4CodeEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.FuncPurposeId))
 {
 if (objFuncPara4CodeEN.FuncPurposeId !=  null)
 {
 var strFuncPurposeId = objFuncPara4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncPurposeId = '{0}',", strFuncPurposeId); //函数用途Id
 }
 else
 {
 sbSQL.Append(" FuncPurposeId = null,"); //函数用途Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdDate))
 {
 if (objFuncPara4CodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncPara4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdUser))
 {
 if (objFuncPara4CodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncPara4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.Memo))
 {
 if (objFuncPara4CodeEN.Memo !=  null)
 {
 var strMemo = objFuncPara4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncPara4CodeEN objFuncPara4CodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncPara4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncPara4CodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncPara4Code Set ");
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaName))
 {
 if (objFuncPara4CodeEN.ParaName !=  null)
 {
 var strParaName = objFuncPara4CodeEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaName, conFuncPara4Code.ParaName); //参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.ParaName); //参数名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParaCnName))
 {
 if (objFuncPara4CodeEN.ParaCnName !=  null)
 {
 var strParaCnName = objFuncPara4CodeEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaCnName, conFuncPara4Code.ParaCnName); //参数中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.ParaCnName); //参数中文名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.DataTypeId))
 {
 if (objFuncPara4CodeEN.DataTypeId !=  null)
 {
 var strDataTypeId = objFuncPara4CodeEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conFuncPara4Code.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.DataTypeId); //数据类型Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterType))
 {
 if (objFuncPara4CodeEN.ParameterType !=  null)
 {
 var strParameterType = objFuncPara4CodeEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterType, conFuncPara4Code.ParameterType); //参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.ParameterType); //参数类型
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.ParameterTypeFullName))
 {
 if (objFuncPara4CodeEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objFuncPara4CodeEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterTypeFullName, conFuncPara4Code.ParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.ParameterTypeFullName); //参数类型全名
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsByRef))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFuncPara4CodeEN.IsByRef == true?"1":"0", conFuncPara4Code.IsByRef); //是否引用型参数
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.PrjId))
 {
 if (objFuncPara4CodeEN.PrjId !=  null)
 {
 var strPrjId = objFuncPara4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFuncPara4Code.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.PrjId); //工程Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFuncPara4CodeEN.IsTemplate == true?"1":"0", conFuncPara4Code.IsTemplate); //是否模板
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.FuncPurposeId))
 {
 if (objFuncPara4CodeEN.FuncPurposeId !=  null)
 {
 var strFuncPurposeId = objFuncPara4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncPurposeId, conFuncPara4Code.FuncPurposeId); //函数用途Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.FuncPurposeId); //函数用途Id
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdDate))
 {
 if (objFuncPara4CodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncPara4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFuncPara4Code.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.UpdDate); //修改日期
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.UpdUser))
 {
 if (objFuncPara4CodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncPara4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFuncPara4Code.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.UpdUser); //修改者
 }
 }
 
 if (objFuncPara4CodeEN.IsUpdated(conFuncPara4Code.Memo))
 {
 if (objFuncPara4CodeEN.Memo !=  null)
 {
 var strMemo = objFuncPara4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFuncPara4Code.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncPara4Code.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncParaId4Code = '{0}'", objFuncPara4CodeEN.FuncParaId4Code); 
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
 /// <param name = "strFuncParaId4Code">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncParaId4Code) 
{
CheckPrimaryKey(strFuncParaId4Code);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFuncParaId4Code,
};
 objSQL.ExecSP("FuncPara4Code_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFuncParaId4Code">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFuncParaId4Code, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFuncParaId4Code);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
//删除FuncPara4Code本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncPara4Code where FuncParaId4Code = " + "'"+ strFuncParaId4Code+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFuncPara4Code(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
//删除FuncPara4Code本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncPara4Code where FuncParaId4Code in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFuncParaId4Code">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFuncParaId4Code) 
{
CheckPrimaryKey(strFuncParaId4Code);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
//删除FuncPara4Code本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncPara4Code where FuncParaId4Code = " + "'"+ strFuncParaId4Code+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFuncPara4Code(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: DelFuncPara4Code)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncPara4Code where " + strCondition ;
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
public bool DelFuncPara4CodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFuncPara4CodeDA: DelFuncPara4CodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncPara4Code where " + strCondition ;
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
 /// <param name = "objFuncPara4CodeENS">源对象</param>
 /// <param name = "objFuncPara4CodeENT">目标对象</param>
public void CopyTo(clsFuncPara4CodeEN objFuncPara4CodeENS, clsFuncPara4CodeEN objFuncPara4CodeENT)
{
objFuncPara4CodeENT.FuncParaId4Code = objFuncPara4CodeENS.FuncParaId4Code; //函数参数Id
objFuncPara4CodeENT.ParaName = objFuncPara4CodeENS.ParaName; //参数名
objFuncPara4CodeENT.ParaCnName = objFuncPara4CodeENS.ParaCnName; //参数中文名
objFuncPara4CodeENT.DataTypeId = objFuncPara4CodeENS.DataTypeId; //数据类型Id
objFuncPara4CodeENT.ParameterType = objFuncPara4CodeENS.ParameterType; //参数类型
objFuncPara4CodeENT.ParameterTypeFullName = objFuncPara4CodeENS.ParameterTypeFullName; //参数类型全名
objFuncPara4CodeENT.IsByRef = objFuncPara4CodeENS.IsByRef; //是否引用型参数
objFuncPara4CodeENT.PrjId = objFuncPara4CodeENS.PrjId; //工程Id
objFuncPara4CodeENT.IsTemplate = objFuncPara4CodeENS.IsTemplate; //是否模板
objFuncPara4CodeENT.FuncPurposeId = objFuncPara4CodeENS.FuncPurposeId; //函数用途Id
objFuncPara4CodeENT.UpdDate = objFuncPara4CodeENS.UpdDate; //修改日期
objFuncPara4CodeENT.UpdUser = objFuncPara4CodeENS.UpdUser; //修改者
objFuncPara4CodeENT.Memo = objFuncPara4CodeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFuncPara4CodeEN.ParaName, conFuncPara4Code.ParaName);
clsCheckSql.CheckFieldNotNull(objFuncPara4CodeEN.ParaCnName, conFuncPara4Code.ParaCnName);
clsCheckSql.CheckFieldNotNull(objFuncPara4CodeEN.DataTypeId, conFuncPara4Code.DataTypeId);
clsCheckSql.CheckFieldNotNull(objFuncPara4CodeEN.IsByRef, conFuncPara4Code.IsByRef);
clsCheckSql.CheckFieldNotNull(objFuncPara4CodeEN.FuncPurposeId, conFuncPara4Code.FuncPurposeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.FuncParaId4Code, 8, conFuncPara4Code.FuncParaId4Code);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParaName, 50, conFuncPara4Code.ParaName);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParaCnName, 50, conFuncPara4Code.ParaCnName);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.DataTypeId, 2, conFuncPara4Code.DataTypeId);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParameterType, 100, conFuncPara4Code.ParameterType);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParameterTypeFullName, 500, conFuncPara4Code.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.PrjId, 4, conFuncPara4Code.PrjId);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.FuncPurposeId, 2, conFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.UpdDate, 20, conFuncPara4Code.UpdDate);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.UpdUser, 20, conFuncPara4Code.UpdUser);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.Memo, 1000, conFuncPara4Code.Memo);
//检查字段外键固定长度
 objFuncPara4CodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParaName, 50, conFuncPara4Code.ParaName);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParaCnName, 50, conFuncPara4Code.ParaCnName);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.DataTypeId, 2, conFuncPara4Code.DataTypeId);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParameterType, 100, conFuncPara4Code.ParameterType);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParameterTypeFullName, 500, conFuncPara4Code.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.PrjId, 4, conFuncPara4Code.PrjId);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.FuncPurposeId, 2, conFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.UpdDate, 20, conFuncPara4Code.UpdDate);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.UpdUser, 20, conFuncPara4Code.UpdUser);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.Memo, 1000, conFuncPara4Code.Memo);
//检查外键字段长度
 objFuncPara4CodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.FuncParaId4Code, 8, conFuncPara4Code.FuncParaId4Code);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParaName, 50, conFuncPara4Code.ParaName);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParaCnName, 50, conFuncPara4Code.ParaCnName);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.DataTypeId, 2, conFuncPara4Code.DataTypeId);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParameterType, 100, conFuncPara4Code.ParameterType);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.ParameterTypeFullName, 500, conFuncPara4Code.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.PrjId, 4, conFuncPara4Code.PrjId);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.FuncPurposeId, 2, conFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.UpdDate, 20, conFuncPara4Code.UpdDate);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.UpdUser, 20, conFuncPara4Code.UpdUser);
clsCheckSql.CheckFieldLen(objFuncPara4CodeEN.Memo, 1000, conFuncPara4Code.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.FuncParaId4Code, conFuncPara4Code.FuncParaId4Code);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.ParaName, conFuncPara4Code.ParaName);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.ParaCnName, conFuncPara4Code.ParaCnName);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.DataTypeId, conFuncPara4Code.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.ParameterType, conFuncPara4Code.ParameterType);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.ParameterTypeFullName, conFuncPara4Code.ParameterTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.PrjId, conFuncPara4Code.PrjId);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.FuncPurposeId, conFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.UpdDate, conFuncPara4Code.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.UpdUser, conFuncPara4Code.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFuncPara4CodeEN.Memo, conFuncPara4Code.Memo);
//检查外键字段长度
 objFuncPara4CodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFuncParaId4Code()
{
//获取某学院所有专业信息
string strSQL = "select FuncParaId4Code, ParaName from FuncPara4Code ";
 clsSpecSQLforSql mySql = clsFuncPara4CodeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FuncPara4Code(函数参数4Code),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objFuncPara4CodeEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null");
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncPara4CodeEN.PrjId);
}
 sbCondition.AppendFormat(" and ParaName = '{0}'", objFuncPara4CodeEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objFuncPara4CodeEN.DataTypeId);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFuncPara4CodeEN.FuncPurposeId);
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
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncPara4CodeEN._CurrTabName);
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
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncPara4CodeEN._CurrTabName, strCondition);
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
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
 objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}