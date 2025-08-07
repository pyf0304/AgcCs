
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4ErrMsgDA
 表名:vPrjTab4ErrMsg(00050206)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:49:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// vPrjTab4ErrMsg(vPrjTab4ErrMsg)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjTab4ErrMsgDA : clsCommBase4DA
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
 return clsvPrjTab4ErrMsgEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjTab4ErrMsgEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTab4ErrMsgEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjTab4ErrMsgEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjTab4ErrMsgEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTabId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTabId)
{
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vPrjTab4ErrMsg中,检查关键字,长度不正确!(clsvPrjTab4ErrMsgDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjTab4ErrMsg中,关键字不能为空 或 null!(clsvPrjTab4ErrMsgDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjTab4ErrMsgDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4ErrMsg where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjTab4ErrMsg(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetDataTable_vPrjTab4ErrMsg)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4ErrMsg where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4ErrMsg where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4ErrMsg where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4ErrMsg where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjTab4ErrMsg where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab4ErrMsg.* " + 
$"from vPrjTab4ErrMsg " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab4ErrMsg.TabId not in " + 
$"(Select top {intTop_In} vPrjTab4ErrMsg.TabId from vPrjTab4ErrMsg " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4ErrMsg where {1} and TabId not in (Select top {2} TabId from vPrjTab4ErrMsg where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4ErrMsg where {1} and TabId not in (Select top {3} TabId from vPrjTab4ErrMsg where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab4ErrMsg.* " + 
$"from vPrjTab4ErrMsg " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab4ErrMsg.TabId not in " + 
$"(Select top {intTop_In} vPrjTab4ErrMsg.TabId from vPrjTab4ErrMsg " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4ErrMsg where {1} and TabId not in (Select top {2} TabId from vPrjTab4ErrMsg where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4ErrMsg where {1} and TabId not in (Select top {3} TabId from vPrjTab4ErrMsg where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjTab4ErrMsgEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA:GetObjLst)", objException.Message));
}
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4ErrMsg where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = TransNullToBool(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = TransNullToBool(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTab4ErrMsgDA: GetObjLst)", objException.Message));
}
objvPrjTab4ErrMsgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
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
public List<clsvPrjTab4ErrMsgEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = TransNullToBool(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = TransNullToBool(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTab4ErrMsgDA: GetObjLst)", objException.Message));
}
objvPrjTab4ErrMsgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjTab4ErrMsg(ref clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4ErrMsg where TabId = " + "'"+ objvPrjTab4ErrMsgEN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjTab4ErrMsgEN.TabId = objDT.Rows[0][convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4ErrMsgEN.FldNum = TransNullToInt(objDT.Rows[0][convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab4ErrMsgEN.TabName = objDT.Rows[0][convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTab4ErrMsgEN.TabCnName = objDT.Rows[0][convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTab4ErrMsgEN.PrjId = objDT.Rows[0][convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab4ErrMsgEN.PrjName = objDT.Rows[0][convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4ErrMsgEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjTab4ErrMsgEN.SqlDsTypeId = objDT.Rows[0][convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab4ErrMsgEN.SqlDsTypeName = objDT.Rows[0][convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjTab4ErrMsgEN.TabStateId = objDT.Rows[0][convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab4ErrMsgEN.TabStateName = objDT.Rows[0][convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4ErrMsgEN.TabNameB = objDT.Rows[0][convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4ErrMsgEN.IsParaTab = TransNullToBool(objDT.Rows[0][convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.IsNationStandard = TransNullToBool(objDT.Rows[0][convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.IsArchive = TransNullToBool(objDT.Rows[0][convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.IsChecked = TransNullToBool(objDT.Rows[0][convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.ErrMsg = objDT.Rows[0][convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPrjTab4ErrMsgEN.FuncModuleAgcId = objDT.Rows[0][convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4ErrMsgEN.FuncModuleName = objDT.Rows[0][convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4ErrMsgEN.FuncModuleEnName = objDT.Rows[0][convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTab4ErrMsgEN.Owner = objDT.Rows[0][convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTab4ErrMsgEN.IsReleToSqlTab = TransNullToBool(objDT.Rows[0][convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.Keyword = objDT.Rows[0][convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4ErrMsgEN.TabTypeId = objDT.Rows[0][convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab4ErrMsgEN.TabTypeName = objDT.Rows[0][convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4ErrMsgEN.RelaTabId4View = objDT.Rows[0][convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4ErrMsgEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = TransNullToBool(objDT.Rows[0][convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.UpdUserId = objDT.Rows[0][convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4ErrMsgEN.UpdDate = objDT.Rows[0][convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4ErrMsgEN.Memo = objDT.Rows[0][convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjTab4ErrMsgEN.ErrMsg2 = objDT.Rows[0][convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPrjTab4ErrMsgEN.RelaTabName4View = objDT.Rows[0][convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View(字段类型:varchar,字段长度:100,是否可空:True)
 objvPrjTab4ErrMsgEN.DataBaseNameTab = objDT.Rows[0][convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjTab4ErrMsgDA: GetvPrjTab4ErrMsg)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjTab4ErrMsgEN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4ErrMsg where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
 objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View(字段类型:varchar,字段长度:100,是否可空:True)
 objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjTab4ErrMsgDA: GetObjByTabId)", objException.Message));
}
return objvPrjTab4ErrMsgEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjTab4ErrMsgEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4ErrMsg where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN()
{
TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(), //表ID
FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()), //字段数
TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(), //表名
TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(), //表中文名
PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(), //工程名称
IsNeedTransCode = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(), //数据源类型Id
SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(), //Sql数据源名
TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(), //表状态ID
TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(), //表状态名称
TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(), //表名_后备
IsParaTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()), //是否参数表
IsNationStandard = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()), //是否国标
IsArchive = TransNullToBool(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()), //是否存档
IsChecked = TransNullToBool(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()), //是否核实
ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(), //错误信息
FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(), //拥有者
IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()), //是否与SQL表相关
Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(), //关键字
TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(), //表类型Id
TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(), //表类型名
RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(), //视图的相关表ID
OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()), //引用序号
IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()), //是否需要生成索引器
UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(), //说明
ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(), //ErrMsg2
RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(), //RelaTabName4View
DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim() //DataBaseName_Tab
};
objvPrjTab4ErrMsgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab4ErrMsgEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjTab4ErrMsgDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjTab4ErrMsgEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = TransNullToBool(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = TransNullToBool(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjTab4ErrMsgDA: GetObjByDataRowvPrjTab4ErrMsg)", objException.Message));
}
objvPrjTab4ErrMsgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab4ErrMsgEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjTab4ErrMsgEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = TransNullToBool(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = TransNullToBool(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjTab4ErrMsgDA: GetObjByDataRow)", objException.Message));
}
objvPrjTab4ErrMsgEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab4ErrMsgEN;
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
objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTab4ErrMsgEN._CurrTabName, convPrjTab4ErrMsg.TabId, 8, "");
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
objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTab4ErrMsgEN._CurrTabName, convPrjTab4ErrMsg.TabId, 8, strPrefix);
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
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from vPrjTab4ErrMsg where " + strCondition;
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
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from vPrjTab4ErrMsg where " + strCondition;
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTabId)
{
CheckPrimaryKey(strTabId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab4ErrMsg", "TabId = " + "'"+ strTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjTab4ErrMsgDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab4ErrMsg", strCondition))
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
objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjTab4ErrMsg");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgENS">源对象</param>
 /// <param name = "objvPrjTab4ErrMsgENT">目标对象</param>
public void CopyTo(clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENS, clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENT)
{
objvPrjTab4ErrMsgENT.TabId = objvPrjTab4ErrMsgENS.TabId; //表ID
objvPrjTab4ErrMsgENT.FldNum = objvPrjTab4ErrMsgENS.FldNum; //字段数
objvPrjTab4ErrMsgENT.TabName = objvPrjTab4ErrMsgENS.TabName; //表名
objvPrjTab4ErrMsgENT.TabCnName = objvPrjTab4ErrMsgENS.TabCnName; //表中文名
objvPrjTab4ErrMsgENT.PrjId = objvPrjTab4ErrMsgENS.PrjId; //工程Id
objvPrjTab4ErrMsgENT.PrjName = objvPrjTab4ErrMsgENS.PrjName; //工程名称
objvPrjTab4ErrMsgENT.IsNeedTransCode = objvPrjTab4ErrMsgENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4ErrMsgENT.SqlDsTypeId = objvPrjTab4ErrMsgENS.SqlDsTypeId; //数据源类型Id
objvPrjTab4ErrMsgENT.SqlDsTypeName = objvPrjTab4ErrMsgENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4ErrMsgENT.TabStateId = objvPrjTab4ErrMsgENS.TabStateId; //表状态ID
objvPrjTab4ErrMsgENT.TabStateName = objvPrjTab4ErrMsgENS.TabStateName; //表状态名称
objvPrjTab4ErrMsgENT.TabNameB = objvPrjTab4ErrMsgENS.TabNameB; //表名_后备
objvPrjTab4ErrMsgENT.IsParaTab = objvPrjTab4ErrMsgENS.IsParaTab; //是否参数表
objvPrjTab4ErrMsgENT.IsNationStandard = objvPrjTab4ErrMsgENS.IsNationStandard; //是否国标
objvPrjTab4ErrMsgENT.IsArchive = objvPrjTab4ErrMsgENS.IsArchive; //是否存档
objvPrjTab4ErrMsgENT.IsChecked = objvPrjTab4ErrMsgENS.IsChecked; //是否核实
objvPrjTab4ErrMsgENT.ErrMsg = objvPrjTab4ErrMsgENS.ErrMsg; //错误信息
objvPrjTab4ErrMsgENT.FuncModuleAgcId = objvPrjTab4ErrMsgENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4ErrMsgENT.FuncModuleName = objvPrjTab4ErrMsgENS.FuncModuleName; //功能模块名称
objvPrjTab4ErrMsgENT.FuncModuleEnName = objvPrjTab4ErrMsgENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4ErrMsgENT.Owner = objvPrjTab4ErrMsgENS.Owner; //拥有者
objvPrjTab4ErrMsgENT.IsReleToSqlTab = objvPrjTab4ErrMsgENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4ErrMsgENT.Keyword = objvPrjTab4ErrMsgENS.Keyword; //关键字
objvPrjTab4ErrMsgENT.TabTypeId = objvPrjTab4ErrMsgENS.TabTypeId; //表类型Id
objvPrjTab4ErrMsgENT.TabTypeName = objvPrjTab4ErrMsgENS.TabTypeName; //表类型名
objvPrjTab4ErrMsgENT.RelaTabId4View = objvPrjTab4ErrMsgENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4ErrMsgENT.OrderNum4Refer = objvPrjTab4ErrMsgENS.OrderNum4Refer; //引用序号
objvPrjTab4ErrMsgENT.IsNeedGeneIndexer = objvPrjTab4ErrMsgENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4ErrMsgENT.UpdUserId = objvPrjTab4ErrMsgENS.UpdUserId; //修改用户Id
objvPrjTab4ErrMsgENT.UpdDate = objvPrjTab4ErrMsgENS.UpdDate; //修改日期
objvPrjTab4ErrMsgENT.Memo = objvPrjTab4ErrMsgENS.Memo; //说明
objvPrjTab4ErrMsgENT.ErrMsg2 = objvPrjTab4ErrMsgENS.ErrMsg2; //ErrMsg2
objvPrjTab4ErrMsgENT.RelaTabName4View = objvPrjTab4ErrMsgENS.RelaTabName4View; //RelaTabName4View
objvPrjTab4ErrMsgENT.DataBaseNameTab = objvPrjTab4ErrMsgENS.DataBaseNameTab; //DataBaseName_Tab
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.TabId, 8, convPrjTab4ErrMsg.TabId);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.TabName, 100, convPrjTab4ErrMsg.TabName);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.TabCnName, 200, convPrjTab4ErrMsg.TabCnName);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.PrjId, 4, convPrjTab4ErrMsg.PrjId);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.PrjName, 30, convPrjTab4ErrMsg.PrjName);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.SqlDsTypeId, 2, convPrjTab4ErrMsg.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.SqlDsTypeName, 20, convPrjTab4ErrMsg.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.TabStateId, 2, convPrjTab4ErrMsg.TabStateId);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.TabStateName, 30, convPrjTab4ErrMsg.TabStateName);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.TabNameB, 50, convPrjTab4ErrMsg.TabNameB);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.ErrMsg, 2000, convPrjTab4ErrMsg.ErrMsg);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.FuncModuleAgcId, 8, convPrjTab4ErrMsg.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.FuncModuleName, 30, convPrjTab4ErrMsg.FuncModuleName);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.FuncModuleEnName, 30, convPrjTab4ErrMsg.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.Owner, 50, convPrjTab4ErrMsg.Owner);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.Keyword, 50, convPrjTab4ErrMsg.Keyword);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.TabTypeId, 4, convPrjTab4ErrMsg.TabTypeId);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.TabTypeName, 30, convPrjTab4ErrMsg.TabTypeName);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.RelaTabId4View, 8, convPrjTab4ErrMsg.RelaTabId4View);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.UpdUserId, 20, convPrjTab4ErrMsg.UpdUserId);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.UpdDate, 20, convPrjTab4ErrMsg.UpdDate);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.Memo, 1000, convPrjTab4ErrMsg.Memo);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.ErrMsg2, 8000, convPrjTab4ErrMsg.ErrMsg2);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.RelaTabName4View, 100, convPrjTab4ErrMsg.RelaTabName4View);
clsCheckSql.CheckFieldLen(objvPrjTab4ErrMsgEN.DataBaseNameTab, 50, convPrjTab4ErrMsg.DataBaseNameTab);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.TabId, convPrjTab4ErrMsg.TabId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.TabName, convPrjTab4ErrMsg.TabName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.TabCnName, convPrjTab4ErrMsg.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.PrjId, convPrjTab4ErrMsg.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.PrjName, convPrjTab4ErrMsg.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.SqlDsTypeId, convPrjTab4ErrMsg.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.SqlDsTypeName, convPrjTab4ErrMsg.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.TabStateId, convPrjTab4ErrMsg.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.TabStateName, convPrjTab4ErrMsg.TabStateName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.TabNameB, convPrjTab4ErrMsg.TabNameB);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.ErrMsg, convPrjTab4ErrMsg.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.FuncModuleAgcId, convPrjTab4ErrMsg.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.FuncModuleName, convPrjTab4ErrMsg.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.FuncModuleEnName, convPrjTab4ErrMsg.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.Owner, convPrjTab4ErrMsg.Owner);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.Keyword, convPrjTab4ErrMsg.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.TabTypeId, convPrjTab4ErrMsg.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.TabTypeName, convPrjTab4ErrMsg.TabTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.RelaTabId4View, convPrjTab4ErrMsg.RelaTabId4View);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.UpdUserId, convPrjTab4ErrMsg.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.UpdDate, convPrjTab4ErrMsg.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.Memo, convPrjTab4ErrMsg.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.ErrMsg2, convPrjTab4ErrMsg.ErrMsg2);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.RelaTabName4View, convPrjTab4ErrMsg.RelaTabName4View);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4ErrMsgEN.DataBaseNameTab, convPrjTab4ErrMsg.DataBaseNameTab);
//检查外键字段长度
 objvPrjTab4ErrMsgEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTabId()
{
//获取某学院所有专业信息
string strSQL = "select TabId, TabName from vPrjTab4ErrMsg ";
 clsSpecSQLforSql mySql = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTab4ErrMsgEN._CurrTabName);
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
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTab4ErrMsgEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjTab4ErrMsgDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}