
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncMapModeDA
 表名:FuncMapMode(00050551)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 函数映射模式(FuncMapMode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFuncMapModeDA : clsCommBase4DA
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
 return clsFuncMapModeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFuncMapModeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncMapModeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFuncMapModeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFuncMapModeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncMapModeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncMapModeId)
{
strFuncMapModeId = strFuncMapModeId.Replace("'", "''");
if (strFuncMapModeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:FuncMapMode中,检查关键字,长度不正确!(clsFuncMapModeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncMapModeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FuncMapMode中,关键字不能为空 或 null!(clsFuncMapModeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncMapModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFuncMapModeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFuncMapModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FuncMapMode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFuncMapModeDA: GetDataTable_FuncMapMode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFuncMapModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFuncMapModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFuncMapModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFuncMapModeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncMapMode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncMapMode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFuncMapModeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FuncMapMode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFuncMapModeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FuncMapMode.* " + 
$"from FuncMapMode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FuncMapMode.FuncMapModeId not in " + 
$"(Select top {intTop_In} FuncMapMode.FuncMapModeId from FuncMapMode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncMapMode where {1} and FuncMapModeId not in (Select top {2} FuncMapModeId from FuncMapMode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncMapMode where {1} and FuncMapModeId not in (Select top {3} FuncMapModeId from FuncMapMode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFuncMapModeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FuncMapMode.* " + 
$"from FuncMapMode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FuncMapMode.FuncMapModeId not in " + 
$"(Select top {intTop_In} FuncMapMode.FuncMapModeId from FuncMapMode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncMapMode where {1} and FuncMapModeId not in (Select top {2} FuncMapModeId from FuncMapMode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncMapMode where {1} and FuncMapModeId not in (Select top {3} FuncMapModeId from FuncMapMode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFuncMapModeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFuncMapModeDA:GetObjLst)", objException.Message));
}
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncMapModeDA: GetObjLst)", objException.Message));
}
objFuncMapModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncMapModeEN);
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
public List<clsFuncMapModeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFuncMapModeDA:GetObjLstByTabName)", objException.Message));
}
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncMapModeDA: GetObjLst)", objException.Message));
}
objFuncMapModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncMapModeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFuncMapMode(ref clsFuncMapModeEN objFuncMapModeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where FuncMapModeId = " + "'"+ objFuncMapModeEN.FuncMapModeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFuncMapModeEN.FuncMapModeId = objDT.Rows[0][conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objFuncMapModeEN.FuncMapModeName = objDT.Rows[0][conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名(字段类型:varchar,字段长度:50,是否可空:True)
 objFuncMapModeEN.FuncMapModeENName = objDT.Rows[0][conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objFuncMapModeEN.UpdDate = objDT.Rows[0][conFuncMapMode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncMapModeEN.UpdUser = objDT.Rows[0][conFuncMapMode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncMapModeEN.Memo = objDT.Rows[0][conFuncMapMode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFuncMapModeDA: GetFuncMapMode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncMapModeId">表关键字</param>
 /// <returns>表对象</returns>
public clsFuncMapModeEN GetObjByFuncMapModeId(string strFuncMapModeId)
{
CheckPrimaryKey(strFuncMapModeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where FuncMapModeId = " + "'"+ strFuncMapModeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
 objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名(字段类型:varchar,字段长度:50,是否可空:True)
 objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFuncMapModeDA: GetObjByFuncMapModeId)", objException.Message));
}
return objFuncMapModeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFuncMapModeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFuncMapModeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN()
{
FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(), //函数映射模式Id
FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(), //函数映射模式名
FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(), //函数映射模式英文名
UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim() //说明
};
objFuncMapModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncMapModeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFuncMapModeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFuncMapModeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFuncMapModeDA: GetObjByDataRowFuncMapMode)", objException.Message));
}
objFuncMapModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncMapModeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFuncMapModeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFuncMapModeDA: GetObjByDataRow)", objException.Message));
}
objFuncMapModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncMapModeEN;
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
objSQL = clsFuncMapModeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncMapModeEN._CurrTabName, conFuncMapMode.FuncMapModeId, 2, "");
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
objSQL = clsFuncMapModeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncMapModeEN._CurrTabName, conFuncMapMode.FuncMapModeId, 2, strPrefix);
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
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncMapModeId from FuncMapMode where " + strCondition;
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
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncMapModeId from FuncMapMode where " + strCondition;
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
 /// <param name = "strFuncMapModeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncMapModeId)
{
CheckPrimaryKey(strFuncMapModeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncMapMode", "FuncMapModeId = " + "'"+ strFuncMapModeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFuncMapModeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncMapMode", strCondition))
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
objSQL = clsFuncMapModeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FuncMapMode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFuncMapModeEN objFuncMapModeEN)
 {
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncMapModeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncMapMode");
objRow = objDS.Tables["FuncMapMode"].NewRow();
objRow[conFuncMapMode.FuncMapModeId] = objFuncMapModeEN.FuncMapModeId; //函数映射模式Id
 if (objFuncMapModeEN.FuncMapModeName !=  "")
 {
objRow[conFuncMapMode.FuncMapModeName] = objFuncMapModeEN.FuncMapModeName; //函数映射模式名
 }
 if (objFuncMapModeEN.FuncMapModeENName !=  "")
 {
objRow[conFuncMapMode.FuncMapModeENName] = objFuncMapModeEN.FuncMapModeENName; //函数映射模式英文名
 }
 if (objFuncMapModeEN.UpdDate !=  "")
 {
objRow[conFuncMapMode.UpdDate] = objFuncMapModeEN.UpdDate; //修改日期
 }
 if (objFuncMapModeEN.UpdUser !=  "")
 {
objRow[conFuncMapMode.UpdUser] = objFuncMapModeEN.UpdUser; //修改者
 }
 if (objFuncMapModeEN.Memo !=  "")
 {
objRow[conFuncMapMode.Memo] = objFuncMapModeEN.Memo; //说明
 }
objDS.Tables[clsFuncMapModeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFuncMapModeEN._CurrTabName);
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncMapModeEN objFuncMapModeEN)
{
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncMapModeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncMapModeEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeId);
 var strFuncMapModeId = objFuncMapModeEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objFuncMapModeEN.FuncMapModeName !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeName);
 var strFuncMapModeName = objFuncMapModeEN.FuncMapModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeName + "'");
 }
 
 if (objFuncMapModeEN.FuncMapModeENName !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeENName);
 var strFuncMapModeENName = objFuncMapModeEN.FuncMapModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeENName + "'");
 }
 
 if (objFuncMapModeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.UpdDate);
 var strUpdDate = objFuncMapModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncMapModeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.UpdUser);
 var strUpdUser = objFuncMapModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncMapModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.Memo);
 var strMemo = objFuncMapModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncMapMode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncMapModeEN objFuncMapModeEN)
{
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncMapModeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncMapModeEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeId);
 var strFuncMapModeId = objFuncMapModeEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objFuncMapModeEN.FuncMapModeName !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeName);
 var strFuncMapModeName = objFuncMapModeEN.FuncMapModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeName + "'");
 }
 
 if (objFuncMapModeEN.FuncMapModeENName !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeENName);
 var strFuncMapModeENName = objFuncMapModeEN.FuncMapModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeENName + "'");
 }
 
 if (objFuncMapModeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.UpdDate);
 var strUpdDate = objFuncMapModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncMapModeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.UpdUser);
 var strUpdUser = objFuncMapModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncMapModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.Memo);
 var strMemo = objFuncMapModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncMapMode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFuncMapModeEN.FuncMapModeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncMapModeEN objFuncMapModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncMapModeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncMapModeEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeId);
 var strFuncMapModeId = objFuncMapModeEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objFuncMapModeEN.FuncMapModeName !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeName);
 var strFuncMapModeName = objFuncMapModeEN.FuncMapModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeName + "'");
 }
 
 if (objFuncMapModeEN.FuncMapModeENName !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeENName);
 var strFuncMapModeENName = objFuncMapModeEN.FuncMapModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeENName + "'");
 }
 
 if (objFuncMapModeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.UpdDate);
 var strUpdDate = objFuncMapModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncMapModeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.UpdUser);
 var strUpdUser = objFuncMapModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncMapModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.Memo);
 var strMemo = objFuncMapModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncMapMode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFuncMapModeEN.FuncMapModeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncMapModeEN objFuncMapModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncMapModeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFuncMapModeEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeId);
 var strFuncMapModeId = objFuncMapModeEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objFuncMapModeEN.FuncMapModeName !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeName);
 var strFuncMapModeName = objFuncMapModeEN.FuncMapModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeName + "'");
 }
 
 if (objFuncMapModeEN.FuncMapModeENName !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.FuncMapModeENName);
 var strFuncMapModeENName = objFuncMapModeEN.FuncMapModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeENName + "'");
 }
 
 if (objFuncMapModeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.UpdDate);
 var strUpdDate = objFuncMapModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncMapModeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.UpdUser);
 var strUpdUser = objFuncMapModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncMapModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncMapMode.Memo);
 var strMemo = objFuncMapModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncMapMode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFuncMapModes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where FuncMapModeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncMapMode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFuncMapModeId = oRow[conFuncMapMode.FuncMapModeId].ToString().Trim();
if (IsExist(strFuncMapModeId))
{
 string strResult = "关键字变量值为:" + string.Format("FuncMapModeId = {0}", strFuncMapModeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFuncMapModeEN._CurrTabName ].NewRow();
objRow[conFuncMapMode.FuncMapModeId] = oRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objRow[conFuncMapMode.FuncMapModeName] = oRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objRow[conFuncMapMode.FuncMapModeENName] = oRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objRow[conFuncMapMode.UpdDate] = oRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objRow[conFuncMapMode.UpdUser] = oRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objRow[conFuncMapMode.Memo] = oRow[conFuncMapMode.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFuncMapModeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFuncMapModeEN._CurrTabName);
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
 /// <param name = "objFuncMapModeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFuncMapModeEN objFuncMapModeEN)
{
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncMapModeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
strSQL = "Select * from FuncMapMode where FuncMapModeId = " + "'"+ objFuncMapModeEN.FuncMapModeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFuncMapModeEN._CurrTabName);
if (objDS.Tables[clsFuncMapModeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FuncMapModeId = " + "'"+ objFuncMapModeEN.FuncMapModeId+"'");
return false;
}
objRow = objDS.Tables[clsFuncMapModeEN._CurrTabName].Rows[0];
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeId))
 {
objRow[conFuncMapMode.FuncMapModeId] = objFuncMapModeEN.FuncMapModeId; //函数映射模式Id
 }
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeName))
 {
objRow[conFuncMapMode.FuncMapModeName] = objFuncMapModeEN.FuncMapModeName; //函数映射模式名
 }
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeENName))
 {
objRow[conFuncMapMode.FuncMapModeENName] = objFuncMapModeEN.FuncMapModeENName; //函数映射模式英文名
 }
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdDate))
 {
objRow[conFuncMapMode.UpdDate] = objFuncMapModeEN.UpdDate; //修改日期
 }
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdUser))
 {
objRow[conFuncMapMode.UpdUser] = objFuncMapModeEN.UpdUser; //修改者
 }
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.Memo))
 {
objRow[conFuncMapMode.Memo] = objFuncMapModeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFuncMapModeEN._CurrTabName);
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncMapModeEN objFuncMapModeEN)
{
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncMapModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FuncMapMode Set ");
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeName))
 {
 if (objFuncMapModeEN.FuncMapModeName !=  null)
 {
 var strFuncMapModeName = objFuncMapModeEN.FuncMapModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncMapModeName, conFuncMapMode.FuncMapModeName); //函数映射模式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.FuncMapModeName); //函数映射模式名
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeENName))
 {
 if (objFuncMapModeEN.FuncMapModeENName !=  null)
 {
 var strFuncMapModeENName = objFuncMapModeEN.FuncMapModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncMapModeENName, conFuncMapMode.FuncMapModeENName); //函数映射模式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.FuncMapModeENName); //函数映射模式英文名
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdDate))
 {
 if (objFuncMapModeEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncMapModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFuncMapMode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.UpdDate); //修改日期
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdUser))
 {
 if (objFuncMapModeEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncMapModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFuncMapMode.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.UpdUser); //修改者
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.Memo))
 {
 if (objFuncMapModeEN.Memo !=  null)
 {
 var strMemo = objFuncMapModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFuncMapMode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncMapModeId = '{0}'", objFuncMapModeEN.FuncMapModeId); 
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
 /// <param name = "objFuncMapModeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFuncMapModeEN objFuncMapModeEN, string strCondition)
{
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncMapModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncMapMode Set ");
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeName))
 {
 if (objFuncMapModeEN.FuncMapModeName !=  null)
 {
 var strFuncMapModeName = objFuncMapModeEN.FuncMapModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeName = '{0}',", strFuncMapModeName); //函数映射模式名
 }
 else
 {
 sbSQL.Append(" FuncMapModeName = null,"); //函数映射模式名
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeENName))
 {
 if (objFuncMapModeEN.FuncMapModeENName !=  null)
 {
 var strFuncMapModeENName = objFuncMapModeEN.FuncMapModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeENName = '{0}',", strFuncMapModeENName); //函数映射模式英文名
 }
 else
 {
 sbSQL.Append(" FuncMapModeENName = null,"); //函数映射模式英文名
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdDate))
 {
 if (objFuncMapModeEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncMapModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdUser))
 {
 if (objFuncMapModeEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncMapModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.Memo))
 {
 if (objFuncMapModeEN.Memo !=  null)
 {
 var strMemo = objFuncMapModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFuncMapModeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFuncMapModeEN objFuncMapModeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncMapModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncMapMode Set ");
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeName))
 {
 if (objFuncMapModeEN.FuncMapModeName !=  null)
 {
 var strFuncMapModeName = objFuncMapModeEN.FuncMapModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeName = '{0}',", strFuncMapModeName); //函数映射模式名
 }
 else
 {
 sbSQL.Append(" FuncMapModeName = null,"); //函数映射模式名
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeENName))
 {
 if (objFuncMapModeEN.FuncMapModeENName !=  null)
 {
 var strFuncMapModeENName = objFuncMapModeEN.FuncMapModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeENName = '{0}',", strFuncMapModeENName); //函数映射模式英文名
 }
 else
 {
 sbSQL.Append(" FuncMapModeENName = null,"); //函数映射模式英文名
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdDate))
 {
 if (objFuncMapModeEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncMapModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdUser))
 {
 if (objFuncMapModeEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncMapModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.Memo))
 {
 if (objFuncMapModeEN.Memo !=  null)
 {
 var strMemo = objFuncMapModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncMapModeEN objFuncMapModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncMapModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncMapModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncMapMode Set ");
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeName))
 {
 if (objFuncMapModeEN.FuncMapModeName !=  null)
 {
 var strFuncMapModeName = objFuncMapModeEN.FuncMapModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncMapModeName, conFuncMapMode.FuncMapModeName); //函数映射模式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.FuncMapModeName); //函数映射模式名
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.FuncMapModeENName))
 {
 if (objFuncMapModeEN.FuncMapModeENName !=  null)
 {
 var strFuncMapModeENName = objFuncMapModeEN.FuncMapModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncMapModeENName, conFuncMapMode.FuncMapModeENName); //函数映射模式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.FuncMapModeENName); //函数映射模式英文名
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdDate))
 {
 if (objFuncMapModeEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncMapModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFuncMapMode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.UpdDate); //修改日期
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.UpdUser))
 {
 if (objFuncMapModeEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncMapModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFuncMapMode.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.UpdUser); //修改者
 }
 }
 
 if (objFuncMapModeEN.IsUpdated(conFuncMapMode.Memo))
 {
 if (objFuncMapModeEN.Memo !=  null)
 {
 var strMemo = objFuncMapModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFuncMapMode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncMapMode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncMapModeId = '{0}'", objFuncMapModeEN.FuncMapModeId); 
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
 /// <param name = "strFuncMapModeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncMapModeId) 
{
CheckPrimaryKey(strFuncMapModeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFuncMapModeId,
};
 objSQL.ExecSP("FuncMapMode_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFuncMapModeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFuncMapModeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFuncMapModeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
//删除FuncMapMode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncMapMode where FuncMapModeId = " + "'"+ strFuncMapModeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFuncMapMode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
//删除FuncMapMode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncMapMode where FuncMapModeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFuncMapModeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFuncMapModeId) 
{
CheckPrimaryKey(strFuncMapModeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
//删除FuncMapMode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncMapMode where FuncMapModeId = " + "'"+ strFuncMapModeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFuncMapMode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFuncMapModeDA: DelFuncMapMode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncMapMode where " + strCondition ;
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
public bool DelFuncMapModeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFuncMapModeDA: DelFuncMapModeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncMapMode where " + strCondition ;
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
 /// <param name = "objFuncMapModeENS">源对象</param>
 /// <param name = "objFuncMapModeENT">目标对象</param>
public void CopyTo(clsFuncMapModeEN objFuncMapModeENS, clsFuncMapModeEN objFuncMapModeENT)
{
objFuncMapModeENT.FuncMapModeId = objFuncMapModeENS.FuncMapModeId; //函数映射模式Id
objFuncMapModeENT.FuncMapModeName = objFuncMapModeENS.FuncMapModeName; //函数映射模式名
objFuncMapModeENT.FuncMapModeENName = objFuncMapModeENS.FuncMapModeENName; //函数映射模式英文名
objFuncMapModeENT.UpdDate = objFuncMapModeENS.UpdDate; //修改日期
objFuncMapModeENT.UpdUser = objFuncMapModeENS.UpdUser; //修改者
objFuncMapModeENT.Memo = objFuncMapModeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFuncMapModeEN objFuncMapModeEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncMapModeEN.FuncMapModeId, 2, conFuncMapMode.FuncMapModeId);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.FuncMapModeName, 50, conFuncMapMode.FuncMapModeName);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.FuncMapModeENName, 50, conFuncMapMode.FuncMapModeENName);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.UpdDate, 20, conFuncMapMode.UpdDate);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.UpdUser, 20, conFuncMapMode.UpdUser);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.Memo, 1000, conFuncMapMode.Memo);
//检查字段外键固定长度
 objFuncMapModeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFuncMapModeEN objFuncMapModeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncMapModeEN.FuncMapModeName, 50, conFuncMapMode.FuncMapModeName);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.FuncMapModeENName, 50, conFuncMapMode.FuncMapModeENName);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.UpdDate, 20, conFuncMapMode.UpdDate);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.UpdUser, 20, conFuncMapMode.UpdUser);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.Memo, 1000, conFuncMapMode.Memo);
//检查外键字段长度
 objFuncMapModeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFuncMapModeEN objFuncMapModeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncMapModeEN.FuncMapModeId, 2, conFuncMapMode.FuncMapModeId);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.FuncMapModeName, 50, conFuncMapMode.FuncMapModeName);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.FuncMapModeENName, 50, conFuncMapMode.FuncMapModeENName);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.UpdDate, 20, conFuncMapMode.UpdDate);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.UpdUser, 20, conFuncMapMode.UpdUser);
clsCheckSql.CheckFieldLen(objFuncMapModeEN.Memo, 1000, conFuncMapMode.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFuncMapModeEN.FuncMapModeId, conFuncMapMode.FuncMapModeId);
clsCheckSql.CheckSqlInjection4Field(objFuncMapModeEN.FuncMapModeName, conFuncMapMode.FuncMapModeName);
clsCheckSql.CheckSqlInjection4Field(objFuncMapModeEN.FuncMapModeENName, conFuncMapMode.FuncMapModeENName);
clsCheckSql.CheckSqlInjection4Field(objFuncMapModeEN.UpdDate, conFuncMapMode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFuncMapModeEN.UpdUser, conFuncMapMode.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFuncMapModeEN.Memo, conFuncMapMode.Memo);
//检查外键字段长度
 objFuncMapModeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFuncMapModeId()
{
//获取某学院所有专业信息
string strSQL = "select FuncMapModeId, FuncMapModeName from FuncMapMode ";
 clsSpecSQLforSql mySql = clsFuncMapModeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FuncMapMode(函数映射模式),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFuncMapModeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFuncMapModeEN objFuncMapModeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objFuncMapModeEN.FuncMapModeName == null)
{
 sbCondition.AppendFormat(" and FuncMapModeName is null");
}
else
{
 sbCondition.AppendFormat(" and FuncMapModeName = '{0}'", objFuncMapModeEN.FuncMapModeName);
}
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
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncMapModeEN._CurrTabName);
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
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncMapModeEN._CurrTabName, strCondition);
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
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
 objSQL = clsFuncMapModeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}