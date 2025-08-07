
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewFldDA
 表名:vSqlViewFld(00050252)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
 /// vSql视图字段(vSqlViewFld)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSqlViewFldDA : clsCommBase4DA
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
 return clsvSqlViewFldEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSqlViewFldEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlViewFldEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSqlViewFldEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSqlViewFldEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSqlViewFld(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetDataTable_vSqlViewFld)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewFld where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewFld where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSqlViewFld where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlViewFld.* " + 
$"from vSqlViewFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlViewFld.mId not in " + 
$"(Select top {intTop_In} vSqlViewFld.mId from vSqlViewFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewFld where {1} and mId not in (Select top {2} mId from vSqlViewFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewFld where {1} and mId not in (Select top {3} mId from vSqlViewFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlViewFld.* " + 
$"from vSqlViewFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlViewFld.mId not in " + 
$"(Select top {intTop_In} vSqlViewFld.mId from vSqlViewFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewFld where {1} and mId not in (Select top {2} mId from vSqlViewFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewFld where {1} and mId not in (Select top {3} mId from vSqlViewFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSqlViewFldEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSqlViewFldDA:GetObjLst)", objException.Message));
}
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = TransNullToInt(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = TransNullToInt(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlViewFldDA: GetObjLst)", objException.Message));
}
objvSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlViewFldEN);
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
public List<clsvSqlViewFldEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSqlViewFldDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = TransNullToInt(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = TransNullToInt(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlViewFldDA: GetObjLst)", objException.Message));
}
objvSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlViewFldEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSqlViewFld(ref clsvSqlViewFldEN objvSqlViewFldEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewFld where mId = " + ""+ objvSqlViewFldEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSqlViewFldEN.mId = TransNullToInt(objDT.Rows[0][convSqlViewFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvSqlViewFldEN.SqlViewId = objDT.Rows[0][convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewFldEN.SqlViewName = objDT.Rows[0][convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewFldEN.SqlViewCNName = objDT.Rows[0][convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewFldEN.RelaTabId = objDT.Rows[0][convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewFldEN.TabId = objDT.Rows[0][convSqlViewFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewFldEN.TabName = objDT.Rows[0][convSqlViewFld.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewFldEN.TabCnName = objDT.Rows[0][convSqlViewFld.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewFldEN.TabAliases = objDT.Rows[0][convSqlViewFld.TabAliases].ToString().Trim(); //表别名(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewFldEN.TabRelationText = objDT.Rows[0][convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlViewFldEN.FldId = objDT.Rows[0][convSqlViewFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewFldEN.FldName = objDT.Rows[0][convSqlViewFld.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvSqlViewFldEN.FldCnName = objDT.Rows[0][convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewFldEN.FldExpression = objDT.Rows[0][convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlViewFldEN.FieldAliases = objDT.Rows[0][convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlViewFldEN.Filters = objDT.Rows[0][convSqlViewFld.Filters].ToString().Trim(); //筛选器(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlViewFldEN.OrderNum = TransNullToInt(objDT.Rows[0][convSqlViewFld.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvSqlViewFldEN.PrjId = objDT.Rows[0][convSqlViewFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlViewFldEN.UpdDate = objDT.Rows[0][convSqlViewFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewFldEN.UpdUserId = objDT.Rows[0][convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewFldEN.Memo = objDT.Rows[0][convSqlViewFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSqlViewFldEN.RelaTabId4SqlView = objDT.Rows[0][convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSqlViewFldDA: GetvSqlViewFld)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSqlViewFldEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewFld where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
 objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSqlViewFldDA: GetObjBymId)", objException.Message));
}
return objvSqlViewFldEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSqlViewFldEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSqlViewFldDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN()
{
mId = TransNullToInt(objRow[convSqlViewFld.mId].ToString().Trim()), //mId
SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(), //Sql视图Id
SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(), //数据视图名称
SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(), //Sql视图中文名
RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(), //相关表Id
TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(), //表ID
TabName = objRow[convSqlViewFld.TabName].ToString().Trim(), //表名
TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(), //表中文名
TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(), //表别名
TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(), //表关系文本
FldId = objRow[convSqlViewFld.FldId].ToString().Trim(), //字段Id
FldName = objRow[convSqlViewFld.FldName].ToString().Trim(), //字段名
FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(), //字段中文详名
FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(), //字段表达式
FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(), //字段别名
Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(), //筛选器
OrderNum = TransNullToInt(objRow[convSqlViewFld.OrderNum].ToString().Trim()), //序号
PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(), //说明
RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim() //RelaTabId4SqlView
};
objvSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlViewFldEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSqlViewFldDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSqlViewFldEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = TransNullToInt(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = TransNullToInt(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSqlViewFldDA: GetObjByDataRowvSqlViewFld)", objException.Message));
}
objvSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlViewFldEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSqlViewFldEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = TransNullToInt(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = TransNullToInt(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSqlViewFldDA: GetObjByDataRow)", objException.Message));
}
objvSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlViewFldEN;
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
objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlViewFldEN._CurrTabName, convSqlViewFld.mId, 8, "");
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
objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlViewFldEN._CurrTabName, convSqlViewFld.mId, 8, strPrefix);
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
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vSqlViewFld where " + strCondition;
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
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vSqlViewFld where " + strCondition;
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
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlViewFld", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSqlViewFldDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlViewFld", strCondition))
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
objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSqlViewFld");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSqlViewFldENS">源对象</param>
 /// <param name = "objvSqlViewFldENT">目标对象</param>
public void CopyTo(clsvSqlViewFldEN objvSqlViewFldENS, clsvSqlViewFldEN objvSqlViewFldENT)
{
objvSqlViewFldENT.mId = objvSqlViewFldENS.mId; //mId
objvSqlViewFldENT.SqlViewId = objvSqlViewFldENS.SqlViewId; //Sql视图Id
objvSqlViewFldENT.SqlViewName = objvSqlViewFldENS.SqlViewName; //数据视图名称
objvSqlViewFldENT.SqlViewCNName = objvSqlViewFldENS.SqlViewCNName; //Sql视图中文名
objvSqlViewFldENT.RelaTabId = objvSqlViewFldENS.RelaTabId; //相关表Id
objvSqlViewFldENT.TabId = objvSqlViewFldENS.TabId; //表ID
objvSqlViewFldENT.TabName = objvSqlViewFldENS.TabName; //表名
objvSqlViewFldENT.TabCnName = objvSqlViewFldENS.TabCnName; //表中文名
objvSqlViewFldENT.TabAliases = objvSqlViewFldENS.TabAliases; //表别名
objvSqlViewFldENT.TabRelationText = objvSqlViewFldENS.TabRelationText; //表关系文本
objvSqlViewFldENT.FldId = objvSqlViewFldENS.FldId; //字段Id
objvSqlViewFldENT.FldName = objvSqlViewFldENS.FldName; //字段名
objvSqlViewFldENT.FldCnName = objvSqlViewFldENS.FldCnName; //字段中文详名
objvSqlViewFldENT.FldExpression = objvSqlViewFldENS.FldExpression; //字段表达式
objvSqlViewFldENT.FieldAliases = objvSqlViewFldENS.FieldAliases; //字段别名
objvSqlViewFldENT.Filters = objvSqlViewFldENS.Filters; //筛选器
objvSqlViewFldENT.OrderNum = objvSqlViewFldENS.OrderNum; //序号
objvSqlViewFldENT.PrjId = objvSqlViewFldENS.PrjId; //工程Id
objvSqlViewFldENT.UpdDate = objvSqlViewFldENS.UpdDate; //修改日期
objvSqlViewFldENT.UpdUserId = objvSqlViewFldENS.UpdUserId; //修改用户Id
objvSqlViewFldENT.Memo = objvSqlViewFldENS.Memo; //说明
objvSqlViewFldENT.RelaTabId4SqlView = objvSqlViewFldENS.RelaTabId4SqlView; //RelaTabId4SqlView
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSqlViewFldEN objvSqlViewFldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.SqlViewId, 8, convSqlViewFld.SqlViewId);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.SqlViewName, 100, convSqlViewFld.SqlViewName);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.SqlViewCNName, 200, convSqlViewFld.SqlViewCNName);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.RelaTabId, 8, convSqlViewFld.RelaTabId);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.TabId, 8, convSqlViewFld.TabId);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.TabName, 100, convSqlViewFld.TabName);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.TabCnName, 200, convSqlViewFld.TabCnName);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.TabAliases, 100, convSqlViewFld.TabAliases);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.TabRelationText, 500, convSqlViewFld.TabRelationText);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.FldId, 8, convSqlViewFld.FldId);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.FldName, 50, convSqlViewFld.FldName);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.FldCnName, 200, convSqlViewFld.FldCnName);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.FldExpression, 500, convSqlViewFld.FldExpression);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.FieldAliases, 50, convSqlViewFld.FieldAliases);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.Filters, 50, convSqlViewFld.Filters);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.PrjId, 4, convSqlViewFld.PrjId);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.UpdDate, 20, convSqlViewFld.UpdDate);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.UpdUserId, 20, convSqlViewFld.UpdUserId);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.Memo, 1000, convSqlViewFld.Memo);
clsCheckSql.CheckFieldLen(objvSqlViewFldEN.RelaTabId4SqlView, 8, convSqlViewFld.RelaTabId4SqlView);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.SqlViewId, convSqlViewFld.SqlViewId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.SqlViewName, convSqlViewFld.SqlViewName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.SqlViewCNName, convSqlViewFld.SqlViewCNName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.RelaTabId, convSqlViewFld.RelaTabId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.TabId, convSqlViewFld.TabId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.TabName, convSqlViewFld.TabName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.TabCnName, convSqlViewFld.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.TabAliases, convSqlViewFld.TabAliases);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.TabRelationText, convSqlViewFld.TabRelationText);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.FldId, convSqlViewFld.FldId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.FldName, convSqlViewFld.FldName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.FldCnName, convSqlViewFld.FldCnName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.FldExpression, convSqlViewFld.FldExpression);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.FieldAliases, convSqlViewFld.FieldAliases);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.Filters, convSqlViewFld.Filters);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.PrjId, convSqlViewFld.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.UpdDate, convSqlViewFld.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.UpdUserId, convSqlViewFld.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.Memo, convSqlViewFld.Memo);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewFldEN.RelaTabId4SqlView, convSqlViewFld.RelaTabId4SqlView);
//检查外键字段长度
 objvSqlViewFldEN._IsCheckProperty = true;
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
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
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
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
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
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlViewFldEN._CurrTabName);
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
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlViewFldEN._CurrTabName, strCondition);
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
 objSQL = clsvSqlViewFldDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}