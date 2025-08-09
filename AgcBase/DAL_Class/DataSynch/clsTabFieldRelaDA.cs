
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFieldRelaDA
 表名:TabFieldRela(00050266)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
 /// 表字段关系(TabFieldRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTabFieldRelaDA : clsCommBase4DA
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
 return clsTabFieldRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTabFieldRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabFieldRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTabFieldRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTabFieldRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TabFieldRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetDataTable_TabFieldRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabFieldRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabFieldRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TabFieldRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabFieldRela.* " + 
$"from TabFieldRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabFieldRela.IdFieldTabRela not in " + 
$"(Select top {intTop_In} TabFieldRela.IdFieldTabRela from TabFieldRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabFieldRela where {1} and IdFieldTabRela not in (Select top {2} IdFieldTabRela from TabFieldRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabFieldRela where {1} and IdFieldTabRela not in (Select top {3} IdFieldTabRela from TabFieldRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabFieldRela.* " + 
$"from TabFieldRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabFieldRela.IdFieldTabRela not in " + 
$"(Select top {intTop_In} TabFieldRela.IdFieldTabRela from TabFieldRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabFieldRela where {1} and IdFieldTabRela not in (Select top {2} IdFieldTabRela from TabFieldRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabFieldRela where {1} and IdFieldTabRela not in (Select top {3} IdFieldTabRela from TabFieldRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTabFieldRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTabFieldRelaDA:GetObjLst)", objException.Message));
}
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = TransNullToBool(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = TransNullToBool(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = TransNullToBool(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = TransNullToBool(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = TransNullToBool(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = TransNullToBool(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = TransNullToBool(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabFieldRelaDA: GetObjLst)", objException.Message));
}
objTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabFieldRelaEN);
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
public List<clsTabFieldRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTabFieldRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = TransNullToBool(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = TransNullToBool(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = TransNullToBool(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = TransNullToBool(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = TransNullToBool(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = TransNullToBool(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = TransNullToBool(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabFieldRelaDA: GetObjLst)", objException.Message));
}
objTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabFieldRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTabFieldRela(ref clsTabFieldRelaEN objTabFieldRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where IdFieldTabRela = " + ""+ objTabFieldRelaEN.IdFieldTabRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objDT.Rows[0][conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objTabFieldRelaEN.FldId = objDT.Rows[0][conTabFieldRela.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objTabFieldRelaEN.TabId = objDT.Rows[0][conTabFieldRela.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objTabFieldRelaEN.SqlFldName = objDT.Rows[0][conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称(字段类型:varchar,字段长度:100,是否可空:True)
 objTabFieldRelaEN.ExcelFieldName = objDT.Rows[0][conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称(字段类型:varchar,字段长度:100,是否可空:False)
 objTabFieldRelaEN.DefaultValue = objDT.Rows[0][conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.IsNeedTrans = TransNullToBool(objDT.Rows[0][conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换(字段类型:bit,字段长度:1,是否可空:False)
 objTabFieldRelaEN.TransWayId = objDT.Rows[0][conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID(字段类型:char,字段长度:2,是否可空:False)
 objTabFieldRelaEN.TransTabName = objDT.Rows[0][conTabFieldRela.TransTabName].ToString().Trim(); //转换表名(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.TransInFldName = objDT.Rows[0][conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.TransOutFldName = objDT.Rows[0][conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.IsTabPrimary = TransNullToBool(objDT.Rows[0][conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键(字段类型:bit,字段长度:1,是否可空:False)
 objTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objDT.Rows[0][conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.PrimaryTypeId = objDT.Rows[0][conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objTabFieldRelaEN.IsIdentity = TransNullToBool(objDT.Rows[0][conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.IsTabUnique = TransNullToBool(objDT.Rows[0][conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.IsTabNullable = TransNullToBool(objDT.Rows[0][conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.FieldTypeId = objDT.Rows[0][conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objDT.Rows[0][conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.PrimaryKeyTabName = objDT.Rows[0][conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.PrimaryKeyFieldName = objDT.Rows[0][conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.TransMissingValue = objDT.Rows[0][conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.TransNullValue = objDT.Rows[0][conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.PrjId = objDT.Rows[0][conTabFieldRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFieldRelaEN.IsVisible = TransNullToBool(objDT.Rows[0][conTabFieldRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.SequenceNumber = TransNullToInt(objDT.Rows[0][conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号(字段类型:int,字段长度:4,是否可空:True)
 objTabFieldRelaEN.Memo = objDT.Rows[0][conTabFieldRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objTabFieldRelaEN.FieldTypeIdS = objDT.Rows[0][conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S(字段类型:char,字段长度:2,是否可空:True)
 objTabFieldRelaEN.FldLengthS = TransNullToInt(objDT.Rows[0][conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S(字段类型:int,字段长度:4,是否可空:True)
 objTabFieldRelaEN.ForeignKeyTabId = objDT.Rows[0][conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objTabFieldRelaEN.HashIndex = TransNullToInt(objDT.Rows[0][conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号(字段类型:int,字段长度:4,是否可空:True)
 objTabFieldRelaEN.IsUseHash = TransNullToBool(objDT.Rows[0][conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.Prefix = objDT.Rows[0][conTabFieldRela.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objTabFieldRelaEN.PrefixFldId = objDT.Rows[0][conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id(字段类型:char,字段长度:8,是否可空:True)
 objTabFieldRelaEN.vFieldCnName = objDT.Rows[0][conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTabFieldRelaDA: GetTabFieldRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">表关键字</param>
 /// <returns>表对象</returns>
public clsTabFieldRelaEN GetObjByIdFieldTabRela(long lngIdFieldTabRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where IdFieldTabRela = " + ""+ lngIdFieldTabRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
 objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称(字段类型:varchar,字段长度:100,是否可空:True)
 objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称(字段类型:varchar,字段长度:100,是否可空:False)
 objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换(字段类型:bit,字段长度:1,是否可空:False)
 objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID(字段类型:char,字段长度:2,是否可空:False)
 objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键(字段类型:bit,字段长度:1,是否可空:False)
 objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值(字段类型:varchar,字段长度:50,是否可空:True)
 objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号(字段类型:int,字段长度:4,是否可空:True)
 objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S(字段类型:char,字段长度:2,是否可空:True)
 objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S(字段类型:int,字段长度:4,是否可空:True)
 objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号(字段类型:int,字段长度:4,是否可空:True)
 objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表(字段类型:bit,字段长度:1,是否可空:True)
 objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id(字段类型:char,字段长度:8,是否可空:True)
 objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTabFieldRelaDA: GetObjByIdFieldTabRela)", objException.Message));
}
return objTabFieldRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTabFieldRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN()
{
IdFieldTabRela = TransNullToInt(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()), //字段表关系流水号
FldId = objRow[conTabFieldRela.FldId].ToString().Trim(), //字段Id
TabId = objRow[conTabFieldRela.TabId].ToString().Trim(), //表ID
SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(), //Sql字段名称
ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(), //Excel字段名称
DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(), //缺省值
IsNeedTrans = TransNullToBool(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()), //是否需要转换
TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(), //转换方式ID
TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(), //转换表名
TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(), //转换IN字段名
TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(), //转换Out字段名
IsTabPrimary = TransNullToBool(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()), //是否作为表中主键
IsTabForeignKey = TransNullToBool(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()), //是否表外键
PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(), //主键类型ID
IsIdentity = TransNullToBool(objRow[conTabFieldRela.IsIdentity].ToString().Trim()), //是否Identity
IsTabUnique = TransNullToBool(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()), //是否表中唯一
IsTabNullable = TransNullToBool(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()), //是否表中可空
FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(), //字段类型Id
IsNeedCheckPriForeignKey = TransNullToBool(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()), //是否检查主外键
PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(), //主键表
PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(), //主键字段名
TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(), //转换失败值
TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(), //转换空值
PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(), //工程Id
IsVisible = TransNullToBool(objRow[conTabFieldRela.IsVisible].ToString().Trim()), //是否显示
SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()), //顺序号
Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(), //说明
FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(), //FieldTypeId_S
FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.FldLengthS].ToString().Trim()), //FldLength_S
ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(), //外键表ID
HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.HashIndex].ToString().Trim()), //HASH表序号
IsUseHash = TransNullToBool(objRow[conTabFieldRela.IsUseHash].ToString().Trim()), //是否用HASH表
Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(), //前缀
PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(), //前缀字段Id
vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim() //视图字段中文名称
};
objTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabFieldRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTabFieldRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTabFieldRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = TransNullToBool(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = TransNullToBool(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = TransNullToBool(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = TransNullToBool(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = TransNullToBool(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = TransNullToBool(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = TransNullToBool(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTabFieldRelaDA: GetObjByDataRowTabFieldRela)", objException.Message));
}
objTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabFieldRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTabFieldRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = TransNullToBool(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = TransNullToBool(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = TransNullToBool(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = TransNullToBool(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = TransNullToBool(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = TransNullToBool(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = TransNullToBool(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTabFieldRelaDA: GetObjByDataRow)", objException.Message));
}
objTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabFieldRelaEN;
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
objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabFieldRelaEN._CurrTabName, conTabFieldRela.IdFieldTabRela, 8, "");
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
objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabFieldRelaEN._CurrTabName, conTabFieldRela.IdFieldTabRela, 8, strPrefix);
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
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdFieldTabRela from TabFieldRela where " + strCondition;
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
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdFieldTabRela from TabFieldRela where " + strCondition;
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
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdFieldTabRela)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabFieldRela", "IdFieldTabRela = " + ""+ lngIdFieldTabRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTabFieldRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabFieldRela", strCondition))
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
objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TabFieldRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTabFieldRelaEN objTabFieldRelaEN)
 {
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFieldRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabFieldRela");
objRow = objDS.Tables["TabFieldRela"].NewRow();
objRow[conTabFieldRela.FldId] = objTabFieldRelaEN.FldId; //字段Id
objRow[conTabFieldRela.TabId] = objTabFieldRelaEN.TabId; //表ID
 if (objTabFieldRelaEN.SqlFldName !=  "")
 {
objRow[conTabFieldRela.SqlFldName] = objTabFieldRelaEN.SqlFldName; //Sql字段名称
 }
 if (objTabFieldRelaEN.ExcelFieldName !=  "")
 {
objRow[conTabFieldRela.ExcelFieldName] = objTabFieldRelaEN.ExcelFieldName; //Excel字段名称
 }
 if (objTabFieldRelaEN.DefaultValue !=  "")
 {
objRow[conTabFieldRela.DefaultValue] = objTabFieldRelaEN.DefaultValue; //缺省值
 }
objRow[conTabFieldRela.IsNeedTrans] = objTabFieldRelaEN.IsNeedTrans; //是否需要转换
objRow[conTabFieldRela.TransWayId] = objTabFieldRelaEN.TransWayId; //转换方式ID
 if (objTabFieldRelaEN.TransTabName !=  "")
 {
objRow[conTabFieldRela.TransTabName] = objTabFieldRelaEN.TransTabName; //转换表名
 }
 if (objTabFieldRelaEN.TransInFldName !=  "")
 {
objRow[conTabFieldRela.TransInFldName] = objTabFieldRelaEN.TransInFldName; //转换IN字段名
 }
 if (objTabFieldRelaEN.TransOutFldName !=  "")
 {
objRow[conTabFieldRela.TransOutFldName] = objTabFieldRelaEN.TransOutFldName; //转换Out字段名
 }
objRow[conTabFieldRela.IsTabPrimary] = objTabFieldRelaEN.IsTabPrimary; //是否作为表中主键
objRow[conTabFieldRela.IsTabForeignKey] = objTabFieldRelaEN.IsTabForeignKey; //是否表外键
 if (objTabFieldRelaEN.PrimaryTypeId !=  "")
 {
objRow[conTabFieldRela.PrimaryTypeId] = objTabFieldRelaEN.PrimaryTypeId; //主键类型ID
 }
objRow[conTabFieldRela.IsIdentity] = objTabFieldRelaEN.IsIdentity; //是否Identity
objRow[conTabFieldRela.IsTabUnique] = objTabFieldRelaEN.IsTabUnique; //是否表中唯一
objRow[conTabFieldRela.IsTabNullable] = objTabFieldRelaEN.IsTabNullable; //是否表中可空
 if (objTabFieldRelaEN.FieldTypeId !=  "")
 {
objRow[conTabFieldRela.FieldTypeId] = objTabFieldRelaEN.FieldTypeId; //字段类型Id
 }
objRow[conTabFieldRela.IsNeedCheckPriForeignKey] = objTabFieldRelaEN.IsNeedCheckPriForeignKey; //是否检查主外键
 if (objTabFieldRelaEN.PrimaryKeyTabName !=  "")
 {
objRow[conTabFieldRela.PrimaryKeyTabName] = objTabFieldRelaEN.PrimaryKeyTabName; //主键表
 }
 if (objTabFieldRelaEN.PrimaryKeyFieldName !=  "")
 {
objRow[conTabFieldRela.PrimaryKeyFieldName] = objTabFieldRelaEN.PrimaryKeyFieldName; //主键字段名
 }
 if (objTabFieldRelaEN.TransMissingValue !=  "")
 {
objRow[conTabFieldRela.TransMissingValue] = objTabFieldRelaEN.TransMissingValue; //转换失败值
 }
 if (objTabFieldRelaEN.TransNullValue !=  "")
 {
objRow[conTabFieldRela.TransNullValue] = objTabFieldRelaEN.TransNullValue; //转换空值
 }
objRow[conTabFieldRela.PrjId] = objTabFieldRelaEN.PrjId; //工程Id
objRow[conTabFieldRela.IsVisible] = objTabFieldRelaEN.IsVisible; //是否显示
objRow[conTabFieldRela.SequenceNumber] = objTabFieldRelaEN.SequenceNumber; //顺序号
 if (objTabFieldRelaEN.Memo !=  "")
 {
objRow[conTabFieldRela.Memo] = objTabFieldRelaEN.Memo; //说明
 }
 if (objTabFieldRelaEN.FieldTypeIdS !=  "")
 {
objRow[conTabFieldRela.FieldTypeIdS] = objTabFieldRelaEN.FieldTypeIdS; //FieldTypeId_S
 }
objRow[conTabFieldRela.FldLengthS] = objTabFieldRelaEN.FldLengthS; //FldLength_S
 if (objTabFieldRelaEN.ForeignKeyTabId !=  "")
 {
objRow[conTabFieldRela.ForeignKeyTabId] = objTabFieldRelaEN.ForeignKeyTabId; //外键表ID
 }
objRow[conTabFieldRela.HashIndex] = objTabFieldRelaEN.HashIndex; //HASH表序号
objRow[conTabFieldRela.IsUseHash] = objTabFieldRelaEN.IsUseHash; //是否用HASH表
 if (objTabFieldRelaEN.Prefix !=  "")
 {
objRow[conTabFieldRela.Prefix] = objTabFieldRelaEN.Prefix; //前缀
 }
 if (objTabFieldRelaEN.PrefixFldId !=  "")
 {
objRow[conTabFieldRela.PrefixFldId] = objTabFieldRelaEN.PrefixFldId; //前缀字段Id
 }
 if (objTabFieldRelaEN.vFieldCnName !=  "")
 {
objRow[conTabFieldRela.vFieldCnName] = objTabFieldRelaEN.vFieldCnName; //视图字段中文名称
 }
objDS.Tables[clsTabFieldRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTabFieldRelaEN._CurrTabName);
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
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabFieldRelaEN objTabFieldRelaEN)
{
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFieldRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabFieldRelaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FldId);
 var strFldId = objTabFieldRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objTabFieldRelaEN.TabId  ==  "")
 {
 objTabFieldRelaEN.TabId = null;
 }
 if (objTabFieldRelaEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TabId);
 var strTabId = objTabFieldRelaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFieldRelaEN.SqlFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.SqlFldName);
 var strSqlFldName = objTabFieldRelaEN.SqlFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlFldName + "'");
 }
 
 if (objTabFieldRelaEN.ExcelFieldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.ExcelFieldName);
 var strExcelFieldName = objTabFieldRelaEN.ExcelFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcelFieldName + "'");
 }
 
 if (objTabFieldRelaEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.DefaultValue);
 var strDefaultValue = objTabFieldRelaEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsNeedTrans);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsNeedTrans  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.TransWayId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransWayId);
 var strTransWayId = objTabFieldRelaEN.TransWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransWayId + "'");
 }
 
 if (objTabFieldRelaEN.TransTabName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransTabName);
 var strTransTabName = objTabFieldRelaEN.TransTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransTabName + "'");
 }
 
 if (objTabFieldRelaEN.TransInFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransInFldName);
 var strTransInFldName = objTabFieldRelaEN.TransInFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransInFldName + "'");
 }
 
 if (objTabFieldRelaEN.TransOutFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransOutFldName);
 var strTransOutFldName = objTabFieldRelaEN.TransOutFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransOutFldName + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabPrimary);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabPrimary  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabForeignKey);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabForeignKey  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryTypeId);
 var strPrimaryTypeId = objTabFieldRelaEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsIdentity);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsIdentity  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabUnique);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabUnique  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabNullable);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabNullable  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FieldTypeId);
 var strFieldTypeId = objTabFieldRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsNeedCheckPriForeignKey);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsNeedCheckPriForeignKey  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.PrimaryKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryKeyTabName);
 var strPrimaryKeyTabName = objTabFieldRelaEN.PrimaryKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabName + "'");
 }
 
 if (objTabFieldRelaEN.PrimaryKeyFieldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryKeyFieldName);
 var strPrimaryKeyFieldName = objTabFieldRelaEN.PrimaryKeyFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFieldName + "'");
 }
 
 if (objTabFieldRelaEN.TransMissingValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransMissingValue);
 var strTransMissingValue = objTabFieldRelaEN.TransMissingValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransMissingValue + "'");
 }
 
 if (objTabFieldRelaEN.TransNullValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransNullValue);
 var strTransNullValue = objTabFieldRelaEN.TransNullValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransNullValue + "'");
 }
 
 if (objTabFieldRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrjId);
 var strPrjId = objTabFieldRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsVisible);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.SequenceNumber !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.SequenceNumber);
 arrValueListForInsert.Add(objTabFieldRelaEN.SequenceNumber.ToString());
 }
 
 if (objTabFieldRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.Memo);
 var strMemo = objTabFieldRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTabFieldRelaEN.FieldTypeIdS !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FieldTypeIdS);
 var strFieldTypeIdS = objTabFieldRelaEN.FieldTypeIdS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeIdS + "'");
 }
 
 if (objTabFieldRelaEN.FldLengthS !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FldLengthS);
 arrValueListForInsert.Add(objTabFieldRelaEN.FldLengthS.ToString());
 }
 
 if (objTabFieldRelaEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.ForeignKeyTabId);
 var strForeignKeyTabId = objTabFieldRelaEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objTabFieldRelaEN.HashIndex !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.HashIndex);
 arrValueListForInsert.Add(objTabFieldRelaEN.HashIndex.ToString());
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsUseHash);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsUseHash  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.Prefix);
 var strPrefix = objTabFieldRelaEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefix + "'");
 }
 
 if (objTabFieldRelaEN.PrefixFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrefixFldId);
 var strPrefixFldId = objTabFieldRelaEN.PrefixFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefixFldId + "'");
 }
 
 if (objTabFieldRelaEN.vFieldCnName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.vFieldCnName);
 var strvFieldCnName = objTabFieldRelaEN.vFieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strvFieldCnName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFieldRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTabFieldRelaEN objTabFieldRelaEN)
{
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFieldRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabFieldRelaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FldId);
 var strFldId = objTabFieldRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objTabFieldRelaEN.TabId  ==  "")
 {
 objTabFieldRelaEN.TabId = null;
 }
 if (objTabFieldRelaEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TabId);
 var strTabId = objTabFieldRelaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFieldRelaEN.SqlFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.SqlFldName);
 var strSqlFldName = objTabFieldRelaEN.SqlFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlFldName + "'");
 }
 
 if (objTabFieldRelaEN.ExcelFieldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.ExcelFieldName);
 var strExcelFieldName = objTabFieldRelaEN.ExcelFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcelFieldName + "'");
 }
 
 if (objTabFieldRelaEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.DefaultValue);
 var strDefaultValue = objTabFieldRelaEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsNeedTrans);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsNeedTrans  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.TransWayId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransWayId);
 var strTransWayId = objTabFieldRelaEN.TransWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransWayId + "'");
 }
 
 if (objTabFieldRelaEN.TransTabName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransTabName);
 var strTransTabName = objTabFieldRelaEN.TransTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransTabName + "'");
 }
 
 if (objTabFieldRelaEN.TransInFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransInFldName);
 var strTransInFldName = objTabFieldRelaEN.TransInFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransInFldName + "'");
 }
 
 if (objTabFieldRelaEN.TransOutFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransOutFldName);
 var strTransOutFldName = objTabFieldRelaEN.TransOutFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransOutFldName + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabPrimary);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabPrimary  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabForeignKey);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabForeignKey  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryTypeId);
 var strPrimaryTypeId = objTabFieldRelaEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsIdentity);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsIdentity  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabUnique);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabUnique  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabNullable);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabNullable  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FieldTypeId);
 var strFieldTypeId = objTabFieldRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsNeedCheckPriForeignKey);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsNeedCheckPriForeignKey  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.PrimaryKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryKeyTabName);
 var strPrimaryKeyTabName = objTabFieldRelaEN.PrimaryKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabName + "'");
 }
 
 if (objTabFieldRelaEN.PrimaryKeyFieldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryKeyFieldName);
 var strPrimaryKeyFieldName = objTabFieldRelaEN.PrimaryKeyFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFieldName + "'");
 }
 
 if (objTabFieldRelaEN.TransMissingValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransMissingValue);
 var strTransMissingValue = objTabFieldRelaEN.TransMissingValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransMissingValue + "'");
 }
 
 if (objTabFieldRelaEN.TransNullValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransNullValue);
 var strTransNullValue = objTabFieldRelaEN.TransNullValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransNullValue + "'");
 }
 
 if (objTabFieldRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrjId);
 var strPrjId = objTabFieldRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsVisible);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.SequenceNumber !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.SequenceNumber);
 arrValueListForInsert.Add(objTabFieldRelaEN.SequenceNumber.ToString());
 }
 
 if (objTabFieldRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.Memo);
 var strMemo = objTabFieldRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTabFieldRelaEN.FieldTypeIdS !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FieldTypeIdS);
 var strFieldTypeIdS = objTabFieldRelaEN.FieldTypeIdS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeIdS + "'");
 }
 
 if (objTabFieldRelaEN.FldLengthS !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FldLengthS);
 arrValueListForInsert.Add(objTabFieldRelaEN.FldLengthS.ToString());
 }
 
 if (objTabFieldRelaEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.ForeignKeyTabId);
 var strForeignKeyTabId = objTabFieldRelaEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objTabFieldRelaEN.HashIndex !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.HashIndex);
 arrValueListForInsert.Add(objTabFieldRelaEN.HashIndex.ToString());
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsUseHash);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsUseHash  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.Prefix);
 var strPrefix = objTabFieldRelaEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefix + "'");
 }
 
 if (objTabFieldRelaEN.PrefixFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrefixFldId);
 var strPrefixFldId = objTabFieldRelaEN.PrefixFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefixFldId + "'");
 }
 
 if (objTabFieldRelaEN.vFieldCnName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.vFieldCnName);
 var strvFieldCnName = objTabFieldRelaEN.vFieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strvFieldCnName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFieldRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTabFieldRelaEN objTabFieldRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFieldRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabFieldRelaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FldId);
 var strFldId = objTabFieldRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objTabFieldRelaEN.TabId  ==  "")
 {
 objTabFieldRelaEN.TabId = null;
 }
 if (objTabFieldRelaEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TabId);
 var strTabId = objTabFieldRelaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFieldRelaEN.SqlFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.SqlFldName);
 var strSqlFldName = objTabFieldRelaEN.SqlFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlFldName + "'");
 }
 
 if (objTabFieldRelaEN.ExcelFieldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.ExcelFieldName);
 var strExcelFieldName = objTabFieldRelaEN.ExcelFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcelFieldName + "'");
 }
 
 if (objTabFieldRelaEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.DefaultValue);
 var strDefaultValue = objTabFieldRelaEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsNeedTrans);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsNeedTrans  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.TransWayId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransWayId);
 var strTransWayId = objTabFieldRelaEN.TransWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransWayId + "'");
 }
 
 if (objTabFieldRelaEN.TransTabName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransTabName);
 var strTransTabName = objTabFieldRelaEN.TransTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransTabName + "'");
 }
 
 if (objTabFieldRelaEN.TransInFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransInFldName);
 var strTransInFldName = objTabFieldRelaEN.TransInFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransInFldName + "'");
 }
 
 if (objTabFieldRelaEN.TransOutFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransOutFldName);
 var strTransOutFldName = objTabFieldRelaEN.TransOutFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransOutFldName + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabPrimary);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabPrimary  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabForeignKey);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabForeignKey  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryTypeId);
 var strPrimaryTypeId = objTabFieldRelaEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsIdentity);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsIdentity  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabUnique);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabUnique  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabNullable);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabNullable  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FieldTypeId);
 var strFieldTypeId = objTabFieldRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsNeedCheckPriForeignKey);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsNeedCheckPriForeignKey  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.PrimaryKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryKeyTabName);
 var strPrimaryKeyTabName = objTabFieldRelaEN.PrimaryKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabName + "'");
 }
 
 if (objTabFieldRelaEN.PrimaryKeyFieldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryKeyFieldName);
 var strPrimaryKeyFieldName = objTabFieldRelaEN.PrimaryKeyFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFieldName + "'");
 }
 
 if (objTabFieldRelaEN.TransMissingValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransMissingValue);
 var strTransMissingValue = objTabFieldRelaEN.TransMissingValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransMissingValue + "'");
 }
 
 if (objTabFieldRelaEN.TransNullValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransNullValue);
 var strTransNullValue = objTabFieldRelaEN.TransNullValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransNullValue + "'");
 }
 
 if (objTabFieldRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrjId);
 var strPrjId = objTabFieldRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsVisible);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.SequenceNumber !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.SequenceNumber);
 arrValueListForInsert.Add(objTabFieldRelaEN.SequenceNumber.ToString());
 }
 
 if (objTabFieldRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.Memo);
 var strMemo = objTabFieldRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTabFieldRelaEN.FieldTypeIdS !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FieldTypeIdS);
 var strFieldTypeIdS = objTabFieldRelaEN.FieldTypeIdS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeIdS + "'");
 }
 
 if (objTabFieldRelaEN.FldLengthS !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FldLengthS);
 arrValueListForInsert.Add(objTabFieldRelaEN.FldLengthS.ToString());
 }
 
 if (objTabFieldRelaEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.ForeignKeyTabId);
 var strForeignKeyTabId = objTabFieldRelaEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objTabFieldRelaEN.HashIndex !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.HashIndex);
 arrValueListForInsert.Add(objTabFieldRelaEN.HashIndex.ToString());
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsUseHash);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsUseHash  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.Prefix);
 var strPrefix = objTabFieldRelaEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefix + "'");
 }
 
 if (objTabFieldRelaEN.PrefixFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrefixFldId);
 var strPrefixFldId = objTabFieldRelaEN.PrefixFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefixFldId + "'");
 }
 
 if (objTabFieldRelaEN.vFieldCnName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.vFieldCnName);
 var strvFieldCnName = objTabFieldRelaEN.vFieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strvFieldCnName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFieldRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabFieldRelaEN objTabFieldRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFieldRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabFieldRelaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FldId);
 var strFldId = objTabFieldRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objTabFieldRelaEN.TabId  ==  "")
 {
 objTabFieldRelaEN.TabId = null;
 }
 if (objTabFieldRelaEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TabId);
 var strTabId = objTabFieldRelaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFieldRelaEN.SqlFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.SqlFldName);
 var strSqlFldName = objTabFieldRelaEN.SqlFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlFldName + "'");
 }
 
 if (objTabFieldRelaEN.ExcelFieldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.ExcelFieldName);
 var strExcelFieldName = objTabFieldRelaEN.ExcelFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcelFieldName + "'");
 }
 
 if (objTabFieldRelaEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.DefaultValue);
 var strDefaultValue = objTabFieldRelaEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsNeedTrans);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsNeedTrans  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.TransWayId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransWayId);
 var strTransWayId = objTabFieldRelaEN.TransWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransWayId + "'");
 }
 
 if (objTabFieldRelaEN.TransTabName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransTabName);
 var strTransTabName = objTabFieldRelaEN.TransTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransTabName + "'");
 }
 
 if (objTabFieldRelaEN.TransInFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransInFldName);
 var strTransInFldName = objTabFieldRelaEN.TransInFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransInFldName + "'");
 }
 
 if (objTabFieldRelaEN.TransOutFldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransOutFldName);
 var strTransOutFldName = objTabFieldRelaEN.TransOutFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransOutFldName + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabPrimary);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabPrimary  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabForeignKey);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabForeignKey  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryTypeId);
 var strPrimaryTypeId = objTabFieldRelaEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsIdentity);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsIdentity  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabUnique);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabUnique  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFieldRela.IsTabNullable);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsTabNullable  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FieldTypeId);
 var strFieldTypeId = objTabFieldRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsNeedCheckPriForeignKey);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsNeedCheckPriForeignKey  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.PrimaryKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryKeyTabName);
 var strPrimaryKeyTabName = objTabFieldRelaEN.PrimaryKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabName + "'");
 }
 
 if (objTabFieldRelaEN.PrimaryKeyFieldName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrimaryKeyFieldName);
 var strPrimaryKeyFieldName = objTabFieldRelaEN.PrimaryKeyFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFieldName + "'");
 }
 
 if (objTabFieldRelaEN.TransMissingValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransMissingValue);
 var strTransMissingValue = objTabFieldRelaEN.TransMissingValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransMissingValue + "'");
 }
 
 if (objTabFieldRelaEN.TransNullValue !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.TransNullValue);
 var strTransNullValue = objTabFieldRelaEN.TransNullValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTransNullValue + "'");
 }
 
 if (objTabFieldRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrjId);
 var strPrjId = objTabFieldRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsVisible);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.SequenceNumber !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.SequenceNumber);
 arrValueListForInsert.Add(objTabFieldRelaEN.SequenceNumber.ToString());
 }
 
 if (objTabFieldRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.Memo);
 var strMemo = objTabFieldRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTabFieldRelaEN.FieldTypeIdS !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FieldTypeIdS);
 var strFieldTypeIdS = objTabFieldRelaEN.FieldTypeIdS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeIdS + "'");
 }
 
 if (objTabFieldRelaEN.FldLengthS !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.FldLengthS);
 arrValueListForInsert.Add(objTabFieldRelaEN.FldLengthS.ToString());
 }
 
 if (objTabFieldRelaEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.ForeignKeyTabId);
 var strForeignKeyTabId = objTabFieldRelaEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objTabFieldRelaEN.HashIndex !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.HashIndex);
 arrValueListForInsert.Add(objTabFieldRelaEN.HashIndex.ToString());
 }
 
 arrFieldListForInsert.Add(conTabFieldRela.IsUseHash);
 arrValueListForInsert.Add("'" + (objTabFieldRelaEN.IsUseHash  ==  false ? "0" : "1") + "'");
 
 if (objTabFieldRelaEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.Prefix);
 var strPrefix = objTabFieldRelaEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefix + "'");
 }
 
 if (objTabFieldRelaEN.PrefixFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.PrefixFldId);
 var strPrefixFldId = objTabFieldRelaEN.PrefixFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrefixFldId + "'");
 }
 
 if (objTabFieldRelaEN.vFieldCnName !=  null)
 {
 arrFieldListForInsert.Add(conTabFieldRela.vFieldCnName);
 var strvFieldCnName = objTabFieldRelaEN.vFieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strvFieldCnName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFieldRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTabFieldRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where IdFieldTabRela = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabFieldRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdFieldTabRela = TransNullToInt(oRow[conTabFieldRela.IdFieldTabRela].ToString().Trim());
if (IsExist(lngIdFieldTabRela))
{
 string strResult = "关键字变量值为:" + string.Format("IdFieldTabRela = {0}", lngIdFieldTabRela) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTabFieldRelaEN._CurrTabName ].NewRow();
objRow[conTabFieldRela.FldId] = oRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objRow[conTabFieldRela.TabId] = oRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objRow[conTabFieldRela.SqlFldName] = oRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objRow[conTabFieldRela.ExcelFieldName] = oRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objRow[conTabFieldRela.DefaultValue] = oRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objRow[conTabFieldRela.IsNeedTrans] = oRow[conTabFieldRela.IsNeedTrans].ToString().Trim(); //是否需要转换
objRow[conTabFieldRela.TransWayId] = oRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objRow[conTabFieldRela.TransTabName] = oRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objRow[conTabFieldRela.TransInFldName] = oRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objRow[conTabFieldRela.TransOutFldName] = oRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objRow[conTabFieldRela.IsTabPrimary] = oRow[conTabFieldRela.IsTabPrimary].ToString().Trim(); //是否作为表中主键
objRow[conTabFieldRela.IsTabForeignKey] = oRow[conTabFieldRela.IsTabForeignKey].ToString().Trim(); //是否表外键
objRow[conTabFieldRela.PrimaryTypeId] = oRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objRow[conTabFieldRela.IsIdentity] = oRow[conTabFieldRela.IsIdentity].ToString().Trim(); //是否Identity
objRow[conTabFieldRela.IsTabUnique] = oRow[conTabFieldRela.IsTabUnique].ToString().Trim(); //是否表中唯一
objRow[conTabFieldRela.IsTabNullable] = oRow[conTabFieldRela.IsTabNullable].ToString().Trim(); //是否表中可空
objRow[conTabFieldRela.FieldTypeId] = oRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objRow[conTabFieldRela.IsNeedCheckPriForeignKey] = oRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim(); //是否检查主外键
objRow[conTabFieldRela.PrimaryKeyTabName] = oRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objRow[conTabFieldRela.PrimaryKeyFieldName] = oRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objRow[conTabFieldRela.TransMissingValue] = oRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objRow[conTabFieldRela.TransNullValue] = oRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objRow[conTabFieldRela.PrjId] = oRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objRow[conTabFieldRela.IsVisible] = oRow[conTabFieldRela.IsVisible].ToString().Trim(); //是否显示
objRow[conTabFieldRela.SequenceNumber] = oRow[conTabFieldRela.SequenceNumber].ToString().Trim(); //顺序号
objRow[conTabFieldRela.Memo] = oRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objRow[conTabFieldRela.FieldTypeIdS] = oRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objRow[conTabFieldRela.FldLengthS] = oRow[conTabFieldRela.FldLengthS].ToString().Trim(); //FldLength_S
objRow[conTabFieldRela.ForeignKeyTabId] = oRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objRow[conTabFieldRela.HashIndex] = oRow[conTabFieldRela.HashIndex].ToString().Trim(); //HASH表序号
objRow[conTabFieldRela.IsUseHash] = oRow[conTabFieldRela.IsUseHash].ToString().Trim(); //是否用HASH表
objRow[conTabFieldRela.Prefix] = oRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objRow[conTabFieldRela.PrefixFldId] = oRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objRow[conTabFieldRela.vFieldCnName] = oRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
 objDS.Tables[clsTabFieldRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTabFieldRelaEN._CurrTabName);
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
 /// <param name = "objTabFieldRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTabFieldRelaEN objTabFieldRelaEN)
{
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFieldRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from TabFieldRela where IdFieldTabRela = " + ""+ objTabFieldRelaEN.IdFieldTabRela+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTabFieldRelaEN._CurrTabName);
if (objDS.Tables[clsTabFieldRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdFieldTabRela = " + ""+ objTabFieldRelaEN.IdFieldTabRela+"");
return false;
}
objRow = objDS.Tables[clsTabFieldRelaEN._CurrTabName].Rows[0];
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldId))
 {
objRow[conTabFieldRela.FldId] = objTabFieldRelaEN.FldId; //字段Id
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TabId))
 {
objRow[conTabFieldRela.TabId] = objTabFieldRelaEN.TabId; //表ID
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SqlFldName))
 {
objRow[conTabFieldRela.SqlFldName] = objTabFieldRelaEN.SqlFldName; //Sql字段名称
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ExcelFieldName))
 {
objRow[conTabFieldRela.ExcelFieldName] = objTabFieldRelaEN.ExcelFieldName; //Excel字段名称
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.DefaultValue))
 {
objRow[conTabFieldRela.DefaultValue] = objTabFieldRelaEN.DefaultValue; //缺省值
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedTrans))
 {
objRow[conTabFieldRela.IsNeedTrans] = objTabFieldRelaEN.IsNeedTrans; //是否需要转换
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransWayId))
 {
objRow[conTabFieldRela.TransWayId] = objTabFieldRelaEN.TransWayId; //转换方式ID
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransTabName))
 {
objRow[conTabFieldRela.TransTabName] = objTabFieldRelaEN.TransTabName; //转换表名
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransInFldName))
 {
objRow[conTabFieldRela.TransInFldName] = objTabFieldRelaEN.TransInFldName; //转换IN字段名
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransOutFldName))
 {
objRow[conTabFieldRela.TransOutFldName] = objTabFieldRelaEN.TransOutFldName; //转换Out字段名
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabPrimary))
 {
objRow[conTabFieldRela.IsTabPrimary] = objTabFieldRelaEN.IsTabPrimary; //是否作为表中主键
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabForeignKey))
 {
objRow[conTabFieldRela.IsTabForeignKey] = objTabFieldRelaEN.IsTabForeignKey; //是否表外键
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryTypeId))
 {
objRow[conTabFieldRela.PrimaryTypeId] = objTabFieldRelaEN.PrimaryTypeId; //主键类型ID
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsIdentity))
 {
objRow[conTabFieldRela.IsIdentity] = objTabFieldRelaEN.IsIdentity; //是否Identity
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabUnique))
 {
objRow[conTabFieldRela.IsTabUnique] = objTabFieldRelaEN.IsTabUnique; //是否表中唯一
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabNullable))
 {
objRow[conTabFieldRela.IsTabNullable] = objTabFieldRelaEN.IsTabNullable; //是否表中可空
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeId))
 {
objRow[conTabFieldRela.FieldTypeId] = objTabFieldRelaEN.FieldTypeId; //字段类型Id
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedCheckPriForeignKey))
 {
objRow[conTabFieldRela.IsNeedCheckPriForeignKey] = objTabFieldRelaEN.IsNeedCheckPriForeignKey; //是否检查主外键
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyTabName))
 {
objRow[conTabFieldRela.PrimaryKeyTabName] = objTabFieldRelaEN.PrimaryKeyTabName; //主键表
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyFieldName))
 {
objRow[conTabFieldRela.PrimaryKeyFieldName] = objTabFieldRelaEN.PrimaryKeyFieldName; //主键字段名
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransMissingValue))
 {
objRow[conTabFieldRela.TransMissingValue] = objTabFieldRelaEN.TransMissingValue; //转换失败值
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransNullValue))
 {
objRow[conTabFieldRela.TransNullValue] = objTabFieldRelaEN.TransNullValue; //转换空值
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrjId))
 {
objRow[conTabFieldRela.PrjId] = objTabFieldRelaEN.PrjId; //工程Id
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsVisible))
 {
objRow[conTabFieldRela.IsVisible] = objTabFieldRelaEN.IsVisible; //是否显示
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SequenceNumber))
 {
objRow[conTabFieldRela.SequenceNumber] = objTabFieldRelaEN.SequenceNumber; //顺序号
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Memo))
 {
objRow[conTabFieldRela.Memo] = objTabFieldRelaEN.Memo; //说明
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeIdS))
 {
objRow[conTabFieldRela.FieldTypeIdS] = objTabFieldRelaEN.FieldTypeIdS; //FieldTypeId_S
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldLengthS))
 {
objRow[conTabFieldRela.FldLengthS] = objTabFieldRelaEN.FldLengthS; //FldLength_S
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ForeignKeyTabId))
 {
objRow[conTabFieldRela.ForeignKeyTabId] = objTabFieldRelaEN.ForeignKeyTabId; //外键表ID
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.HashIndex))
 {
objRow[conTabFieldRela.HashIndex] = objTabFieldRelaEN.HashIndex; //HASH表序号
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsUseHash))
 {
objRow[conTabFieldRela.IsUseHash] = objTabFieldRelaEN.IsUseHash; //是否用HASH表
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Prefix))
 {
objRow[conTabFieldRela.Prefix] = objTabFieldRelaEN.Prefix; //前缀
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrefixFldId))
 {
objRow[conTabFieldRela.PrefixFldId] = objTabFieldRelaEN.PrefixFldId; //前缀字段Id
 }
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.vFieldCnName))
 {
objRow[conTabFieldRela.vFieldCnName] = objTabFieldRelaEN.vFieldCnName; //视图字段中文名称
 }
try
{
objDA.Update(objDS, clsTabFieldRelaEN._CurrTabName);
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
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabFieldRelaEN objTabFieldRelaEN)
{
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFieldRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TabFieldRela Set ");
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldId))
 {
 if (objTabFieldRelaEN.FldId !=  null)
 {
 var strFldId = objTabFieldRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conTabFieldRela.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FldId); //字段Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TabId))
 {
 if (objTabFieldRelaEN.TabId  ==  "")
 {
 objTabFieldRelaEN.TabId = null;
 }
 if (objTabFieldRelaEN.TabId !=  null)
 {
 var strTabId = objTabFieldRelaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conTabFieldRela.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TabId); //表ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SqlFldName))
 {
 if (objTabFieldRelaEN.SqlFldName !=  null)
 {
 var strSqlFldName = objTabFieldRelaEN.SqlFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlFldName, conTabFieldRela.SqlFldName); //Sql字段名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.SqlFldName); //Sql字段名称
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ExcelFieldName))
 {
 if (objTabFieldRelaEN.ExcelFieldName !=  null)
 {
 var strExcelFieldName = objTabFieldRelaEN.ExcelFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExcelFieldName, conTabFieldRela.ExcelFieldName); //Excel字段名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.ExcelFieldName); //Excel字段名称
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.DefaultValue))
 {
 if (objTabFieldRelaEN.DefaultValue !=  null)
 {
 var strDefaultValue = objTabFieldRelaEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conTabFieldRela.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.DefaultValue); //缺省值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedTrans))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsNeedTrans == true?"1":"0", conTabFieldRela.IsNeedTrans); //是否需要转换
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransWayId))
 {
 if (objTabFieldRelaEN.TransWayId !=  null)
 {
 var strTransWayId = objTabFieldRelaEN.TransWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransWayId, conTabFieldRela.TransWayId); //转换方式ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransWayId); //转换方式ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransTabName))
 {
 if (objTabFieldRelaEN.TransTabName !=  null)
 {
 var strTransTabName = objTabFieldRelaEN.TransTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransTabName, conTabFieldRela.TransTabName); //转换表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransTabName); //转换表名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransInFldName))
 {
 if (objTabFieldRelaEN.TransInFldName !=  null)
 {
 var strTransInFldName = objTabFieldRelaEN.TransInFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransInFldName, conTabFieldRela.TransInFldName); //转换IN字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransInFldName); //转换IN字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransOutFldName))
 {
 if (objTabFieldRelaEN.TransOutFldName !=  null)
 {
 var strTransOutFldName = objTabFieldRelaEN.TransOutFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransOutFldName, conTabFieldRela.TransOutFldName); //转换Out字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransOutFldName); //转换Out字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabPrimary))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsTabPrimary == true?"1":"0", conTabFieldRela.IsTabPrimary); //是否作为表中主键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabForeignKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsTabForeignKey == true?"1":"0", conTabFieldRela.IsTabForeignKey); //是否表外键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryTypeId))
 {
 if (objTabFieldRelaEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objTabFieldRelaEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeId, conTabFieldRela.PrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrimaryTypeId); //主键类型ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsIdentity))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsIdentity == true?"1":"0", conTabFieldRela.IsIdentity); //是否Identity
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabUnique))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsTabUnique == true?"1":"0", conTabFieldRela.IsTabUnique); //是否表中唯一
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabNullable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsTabNullable == true?"1":"0", conTabFieldRela.IsTabNullable); //是否表中可空
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeId))
 {
 if (objTabFieldRelaEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objTabFieldRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conTabFieldRela.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FieldTypeId); //字段类型Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedCheckPriForeignKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsNeedCheckPriForeignKey == true?"1":"0", conTabFieldRela.IsNeedCheckPriForeignKey); //是否检查主外键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyTabName))
 {
 if (objTabFieldRelaEN.PrimaryKeyTabName !=  null)
 {
 var strPrimaryKeyTabName = objTabFieldRelaEN.PrimaryKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyTabName, conTabFieldRela.PrimaryKeyTabName); //主键表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrimaryKeyTabName); //主键表
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyFieldName))
 {
 if (objTabFieldRelaEN.PrimaryKeyFieldName !=  null)
 {
 var strPrimaryKeyFieldName = objTabFieldRelaEN.PrimaryKeyFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyFieldName, conTabFieldRela.PrimaryKeyFieldName); //主键字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrimaryKeyFieldName); //主键字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransMissingValue))
 {
 if (objTabFieldRelaEN.TransMissingValue !=  null)
 {
 var strTransMissingValue = objTabFieldRelaEN.TransMissingValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransMissingValue, conTabFieldRela.TransMissingValue); //转换失败值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransMissingValue); //转换失败值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransNullValue))
 {
 if (objTabFieldRelaEN.TransNullValue !=  null)
 {
 var strTransNullValue = objTabFieldRelaEN.TransNullValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransNullValue, conTabFieldRela.TransNullValue); //转换空值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransNullValue); //转换空值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrjId))
 {
 if (objTabFieldRelaEN.PrjId !=  null)
 {
 var strPrjId = objTabFieldRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTabFieldRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrjId); //工程Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsVisible == true?"1":"0", conTabFieldRela.IsVisible); //是否显示
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SequenceNumber))
 {
 if (objTabFieldRelaEN.SequenceNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.SequenceNumber, conTabFieldRela.SequenceNumber); //顺序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.SequenceNumber); //顺序号
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Memo))
 {
 if (objTabFieldRelaEN.Memo !=  null)
 {
 var strMemo = objTabFieldRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabFieldRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.Memo); //说明
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeIdS))
 {
 if (objTabFieldRelaEN.FieldTypeIdS !=  null)
 {
 var strFieldTypeIdS = objTabFieldRelaEN.FieldTypeIdS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeIdS, conTabFieldRela.FieldTypeIdS); //FieldTypeId_S
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FieldTypeIdS); //FieldTypeId_S
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldLengthS))
 {
 if (objTabFieldRelaEN.FldLengthS !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.FldLengthS, conTabFieldRela.FldLengthS); //FldLength_S
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FldLengthS); //FldLength_S
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ForeignKeyTabId))
 {
 if (objTabFieldRelaEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objTabFieldRelaEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyTabId, conTabFieldRela.ForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.ForeignKeyTabId); //外键表ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.HashIndex))
 {
 if (objTabFieldRelaEN.HashIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.HashIndex, conTabFieldRela.HashIndex); //HASH表序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.HashIndex); //HASH表序号
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsUseHash))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsUseHash == true?"1":"0", conTabFieldRela.IsUseHash); //是否用HASH表
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Prefix))
 {
 if (objTabFieldRelaEN.Prefix !=  null)
 {
 var strPrefix = objTabFieldRelaEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrefix, conTabFieldRela.Prefix); //前缀
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.Prefix); //前缀
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrefixFldId))
 {
 if (objTabFieldRelaEN.PrefixFldId !=  null)
 {
 var strPrefixFldId = objTabFieldRelaEN.PrefixFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrefixFldId, conTabFieldRela.PrefixFldId); //前缀字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrefixFldId); //前缀字段Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.vFieldCnName))
 {
 if (objTabFieldRelaEN.vFieldCnName !=  null)
 {
 var strvFieldCnName = objTabFieldRelaEN.vFieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strvFieldCnName, conTabFieldRela.vFieldCnName); //视图字段中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.vFieldCnName); //视图字段中文名称
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdFieldTabRela = {0}", objTabFieldRelaEN.IdFieldTabRela); 
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
 /// <param name = "objTabFieldRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTabFieldRelaEN objTabFieldRelaEN, string strCondition)
{
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFieldRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabFieldRela Set ");
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldId))
 {
 if (objTabFieldRelaEN.FldId !=  null)
 {
 var strFldId = objTabFieldRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TabId))
 {
 if (objTabFieldRelaEN.TabId  ==  "")
 {
 objTabFieldRelaEN.TabId = null;
 }
 if (objTabFieldRelaEN.TabId !=  null)
 {
 var strTabId = objTabFieldRelaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SqlFldName))
 {
 if (objTabFieldRelaEN.SqlFldName !=  null)
 {
 var strSqlFldName = objTabFieldRelaEN.SqlFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlFldName = '{0}',", strSqlFldName); //Sql字段名称
 }
 else
 {
 sbSQL.Append(" SqlFldName = null,"); //Sql字段名称
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ExcelFieldName))
 {
 if (objTabFieldRelaEN.ExcelFieldName !=  null)
 {
 var strExcelFieldName = objTabFieldRelaEN.ExcelFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExcelFieldName = '{0}',", strExcelFieldName); //Excel字段名称
 }
 else
 {
 sbSQL.Append(" ExcelFieldName = null,"); //Excel字段名称
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.DefaultValue))
 {
 if (objTabFieldRelaEN.DefaultValue !=  null)
 {
 var strDefaultValue = objTabFieldRelaEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedTrans))
 {
 sbSQL.AppendFormat(" IsNeedTrans = '{0}',", objTabFieldRelaEN.IsNeedTrans == true?"1":"0"); //是否需要转换
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransWayId))
 {
 if (objTabFieldRelaEN.TransWayId !=  null)
 {
 var strTransWayId = objTabFieldRelaEN.TransWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransWayId = '{0}',", strTransWayId); //转换方式ID
 }
 else
 {
 sbSQL.Append(" TransWayId = null,"); //转换方式ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransTabName))
 {
 if (objTabFieldRelaEN.TransTabName !=  null)
 {
 var strTransTabName = objTabFieldRelaEN.TransTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransTabName = '{0}',", strTransTabName); //转换表名
 }
 else
 {
 sbSQL.Append(" TransTabName = null,"); //转换表名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransInFldName))
 {
 if (objTabFieldRelaEN.TransInFldName !=  null)
 {
 var strTransInFldName = objTabFieldRelaEN.TransInFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransInFldName = '{0}',", strTransInFldName); //转换IN字段名
 }
 else
 {
 sbSQL.Append(" TransInFldName = null,"); //转换IN字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransOutFldName))
 {
 if (objTabFieldRelaEN.TransOutFldName !=  null)
 {
 var strTransOutFldName = objTabFieldRelaEN.TransOutFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransOutFldName = '{0}',", strTransOutFldName); //转换Out字段名
 }
 else
 {
 sbSQL.Append(" TransOutFldName = null,"); //转换Out字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabPrimary))
 {
 sbSQL.AppendFormat(" IsTabPrimary = '{0}',", objTabFieldRelaEN.IsTabPrimary == true?"1":"0"); //是否作为表中主键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabForeignKey))
 {
 sbSQL.AppendFormat(" IsTabForeignKey = '{0}',", objTabFieldRelaEN.IsTabForeignKey == true?"1":"0"); //是否表外键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryTypeId))
 {
 if (objTabFieldRelaEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objTabFieldRelaEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeId = '{0}',", strPrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.Append(" PrimaryTypeId = null,"); //主键类型ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsIdentity))
 {
 sbSQL.AppendFormat(" IsIdentity = '{0}',", objTabFieldRelaEN.IsIdentity == true?"1":"0"); //是否Identity
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabUnique))
 {
 sbSQL.AppendFormat(" IsTabUnique = '{0}',", objTabFieldRelaEN.IsTabUnique == true?"1":"0"); //是否表中唯一
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabNullable))
 {
 sbSQL.AppendFormat(" IsTabNullable = '{0}',", objTabFieldRelaEN.IsTabNullable == true?"1":"0"); //是否表中可空
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeId))
 {
 if (objTabFieldRelaEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objTabFieldRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedCheckPriForeignKey))
 {
 sbSQL.AppendFormat(" IsNeedCheckPriForeignKey = '{0}',", objTabFieldRelaEN.IsNeedCheckPriForeignKey == true?"1":"0"); //是否检查主外键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyTabName))
 {
 if (objTabFieldRelaEN.PrimaryKeyTabName !=  null)
 {
 var strPrimaryKeyTabName = objTabFieldRelaEN.PrimaryKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyTabName = '{0}',", strPrimaryKeyTabName); //主键表
 }
 else
 {
 sbSQL.Append(" PrimaryKeyTabName = null,"); //主键表
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyFieldName))
 {
 if (objTabFieldRelaEN.PrimaryKeyFieldName !=  null)
 {
 var strPrimaryKeyFieldName = objTabFieldRelaEN.PrimaryKeyFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyFieldName = '{0}',", strPrimaryKeyFieldName); //主键字段名
 }
 else
 {
 sbSQL.Append(" PrimaryKeyFieldName = null,"); //主键字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransMissingValue))
 {
 if (objTabFieldRelaEN.TransMissingValue !=  null)
 {
 var strTransMissingValue = objTabFieldRelaEN.TransMissingValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransMissingValue = '{0}',", strTransMissingValue); //转换失败值
 }
 else
 {
 sbSQL.Append(" TransMissingValue = null,"); //转换失败值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransNullValue))
 {
 if (objTabFieldRelaEN.TransNullValue !=  null)
 {
 var strTransNullValue = objTabFieldRelaEN.TransNullValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransNullValue = '{0}',", strTransNullValue); //转换空值
 }
 else
 {
 sbSQL.Append(" TransNullValue = null,"); //转换空值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrjId))
 {
 if (objTabFieldRelaEN.PrjId !=  null)
 {
 var strPrjId = objTabFieldRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTabFieldRelaEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SequenceNumber))
 {
 if (objTabFieldRelaEN.SequenceNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.SequenceNumber, conTabFieldRela.SequenceNumber); //顺序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.SequenceNumber); //顺序号
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Memo))
 {
 if (objTabFieldRelaEN.Memo !=  null)
 {
 var strMemo = objTabFieldRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeIdS))
 {
 if (objTabFieldRelaEN.FieldTypeIdS !=  null)
 {
 var strFieldTypeIdS = objTabFieldRelaEN.FieldTypeIdS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeIdS = '{0}',", strFieldTypeIdS); //FieldTypeId_S
 }
 else
 {
 sbSQL.Append(" FieldTypeIdS = null,"); //FieldTypeId_S
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldLengthS))
 {
 if (objTabFieldRelaEN.FldLengthS !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.FldLengthS, conTabFieldRela.FldLengthS); //FldLength_S
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FldLengthS); //FldLength_S
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ForeignKeyTabId))
 {
 if (objTabFieldRelaEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objTabFieldRelaEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyTabId = '{0}',", strForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.Append(" ForeignKeyTabId = null,"); //外键表ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.HashIndex))
 {
 if (objTabFieldRelaEN.HashIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.HashIndex, conTabFieldRela.HashIndex); //HASH表序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.HashIndex); //HASH表序号
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsUseHash))
 {
 sbSQL.AppendFormat(" IsUseHash = '{0}',", objTabFieldRelaEN.IsUseHash == true?"1":"0"); //是否用HASH表
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Prefix))
 {
 if (objTabFieldRelaEN.Prefix !=  null)
 {
 var strPrefix = objTabFieldRelaEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Prefix = '{0}',", strPrefix); //前缀
 }
 else
 {
 sbSQL.Append(" Prefix = null,"); //前缀
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrefixFldId))
 {
 if (objTabFieldRelaEN.PrefixFldId !=  null)
 {
 var strPrefixFldId = objTabFieldRelaEN.PrefixFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrefixFldId = '{0}',", strPrefixFldId); //前缀字段Id
 }
 else
 {
 sbSQL.Append(" PrefixFldId = null,"); //前缀字段Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.vFieldCnName))
 {
 if (objTabFieldRelaEN.vFieldCnName !=  null)
 {
 var strvFieldCnName = objTabFieldRelaEN.vFieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" vFieldCnName = '{0}',", strvFieldCnName); //视图字段中文名称
 }
 else
 {
 sbSQL.Append(" vFieldCnName = null,"); //视图字段中文名称
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
 /// <param name = "objTabFieldRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTabFieldRelaEN objTabFieldRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFieldRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabFieldRela Set ");
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldId))
 {
 if (objTabFieldRelaEN.FldId !=  null)
 {
 var strFldId = objTabFieldRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TabId))
 {
 if (objTabFieldRelaEN.TabId  ==  "")
 {
 objTabFieldRelaEN.TabId = null;
 }
 if (objTabFieldRelaEN.TabId !=  null)
 {
 var strTabId = objTabFieldRelaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SqlFldName))
 {
 if (objTabFieldRelaEN.SqlFldName !=  null)
 {
 var strSqlFldName = objTabFieldRelaEN.SqlFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlFldName = '{0}',", strSqlFldName); //Sql字段名称
 }
 else
 {
 sbSQL.Append(" SqlFldName = null,"); //Sql字段名称
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ExcelFieldName))
 {
 if (objTabFieldRelaEN.ExcelFieldName !=  null)
 {
 var strExcelFieldName = objTabFieldRelaEN.ExcelFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExcelFieldName = '{0}',", strExcelFieldName); //Excel字段名称
 }
 else
 {
 sbSQL.Append(" ExcelFieldName = null,"); //Excel字段名称
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.DefaultValue))
 {
 if (objTabFieldRelaEN.DefaultValue !=  null)
 {
 var strDefaultValue = objTabFieldRelaEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedTrans))
 {
 sbSQL.AppendFormat(" IsNeedTrans = '{0}',", objTabFieldRelaEN.IsNeedTrans == true?"1":"0"); //是否需要转换
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransWayId))
 {
 if (objTabFieldRelaEN.TransWayId !=  null)
 {
 var strTransWayId = objTabFieldRelaEN.TransWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransWayId = '{0}',", strTransWayId); //转换方式ID
 }
 else
 {
 sbSQL.Append(" TransWayId = null,"); //转换方式ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransTabName))
 {
 if (objTabFieldRelaEN.TransTabName !=  null)
 {
 var strTransTabName = objTabFieldRelaEN.TransTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransTabName = '{0}',", strTransTabName); //转换表名
 }
 else
 {
 sbSQL.Append(" TransTabName = null,"); //转换表名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransInFldName))
 {
 if (objTabFieldRelaEN.TransInFldName !=  null)
 {
 var strTransInFldName = objTabFieldRelaEN.TransInFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransInFldName = '{0}',", strTransInFldName); //转换IN字段名
 }
 else
 {
 sbSQL.Append(" TransInFldName = null,"); //转换IN字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransOutFldName))
 {
 if (objTabFieldRelaEN.TransOutFldName !=  null)
 {
 var strTransOutFldName = objTabFieldRelaEN.TransOutFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransOutFldName = '{0}',", strTransOutFldName); //转换Out字段名
 }
 else
 {
 sbSQL.Append(" TransOutFldName = null,"); //转换Out字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabPrimary))
 {
 sbSQL.AppendFormat(" IsTabPrimary = '{0}',", objTabFieldRelaEN.IsTabPrimary == true?"1":"0"); //是否作为表中主键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabForeignKey))
 {
 sbSQL.AppendFormat(" IsTabForeignKey = '{0}',", objTabFieldRelaEN.IsTabForeignKey == true?"1":"0"); //是否表外键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryTypeId))
 {
 if (objTabFieldRelaEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objTabFieldRelaEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeId = '{0}',", strPrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.Append(" PrimaryTypeId = null,"); //主键类型ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsIdentity))
 {
 sbSQL.AppendFormat(" IsIdentity = '{0}',", objTabFieldRelaEN.IsIdentity == true?"1":"0"); //是否Identity
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabUnique))
 {
 sbSQL.AppendFormat(" IsTabUnique = '{0}',", objTabFieldRelaEN.IsTabUnique == true?"1":"0"); //是否表中唯一
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabNullable))
 {
 sbSQL.AppendFormat(" IsTabNullable = '{0}',", objTabFieldRelaEN.IsTabNullable == true?"1":"0"); //是否表中可空
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeId))
 {
 if (objTabFieldRelaEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objTabFieldRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedCheckPriForeignKey))
 {
 sbSQL.AppendFormat(" IsNeedCheckPriForeignKey = '{0}',", objTabFieldRelaEN.IsNeedCheckPriForeignKey == true?"1":"0"); //是否检查主外键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyTabName))
 {
 if (objTabFieldRelaEN.PrimaryKeyTabName !=  null)
 {
 var strPrimaryKeyTabName = objTabFieldRelaEN.PrimaryKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyTabName = '{0}',", strPrimaryKeyTabName); //主键表
 }
 else
 {
 sbSQL.Append(" PrimaryKeyTabName = null,"); //主键表
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyFieldName))
 {
 if (objTabFieldRelaEN.PrimaryKeyFieldName !=  null)
 {
 var strPrimaryKeyFieldName = objTabFieldRelaEN.PrimaryKeyFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyFieldName = '{0}',", strPrimaryKeyFieldName); //主键字段名
 }
 else
 {
 sbSQL.Append(" PrimaryKeyFieldName = null,"); //主键字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransMissingValue))
 {
 if (objTabFieldRelaEN.TransMissingValue !=  null)
 {
 var strTransMissingValue = objTabFieldRelaEN.TransMissingValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransMissingValue = '{0}',", strTransMissingValue); //转换失败值
 }
 else
 {
 sbSQL.Append(" TransMissingValue = null,"); //转换失败值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransNullValue))
 {
 if (objTabFieldRelaEN.TransNullValue !=  null)
 {
 var strTransNullValue = objTabFieldRelaEN.TransNullValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TransNullValue = '{0}',", strTransNullValue); //转换空值
 }
 else
 {
 sbSQL.Append(" TransNullValue = null,"); //转换空值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrjId))
 {
 if (objTabFieldRelaEN.PrjId !=  null)
 {
 var strPrjId = objTabFieldRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTabFieldRelaEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SequenceNumber))
 {
 if (objTabFieldRelaEN.SequenceNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.SequenceNumber, conTabFieldRela.SequenceNumber); //顺序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.SequenceNumber); //顺序号
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Memo))
 {
 if (objTabFieldRelaEN.Memo !=  null)
 {
 var strMemo = objTabFieldRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeIdS))
 {
 if (objTabFieldRelaEN.FieldTypeIdS !=  null)
 {
 var strFieldTypeIdS = objTabFieldRelaEN.FieldTypeIdS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeIdS = '{0}',", strFieldTypeIdS); //FieldTypeId_S
 }
 else
 {
 sbSQL.Append(" FieldTypeIdS = null,"); //FieldTypeId_S
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldLengthS))
 {
 if (objTabFieldRelaEN.FldLengthS !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.FldLengthS, conTabFieldRela.FldLengthS); //FldLength_S
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FldLengthS); //FldLength_S
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ForeignKeyTabId))
 {
 if (objTabFieldRelaEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objTabFieldRelaEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyTabId = '{0}',", strForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.Append(" ForeignKeyTabId = null,"); //外键表ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.HashIndex))
 {
 if (objTabFieldRelaEN.HashIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.HashIndex, conTabFieldRela.HashIndex); //HASH表序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.HashIndex); //HASH表序号
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsUseHash))
 {
 sbSQL.AppendFormat(" IsUseHash = '{0}',", objTabFieldRelaEN.IsUseHash == true?"1":"0"); //是否用HASH表
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Prefix))
 {
 if (objTabFieldRelaEN.Prefix !=  null)
 {
 var strPrefix = objTabFieldRelaEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Prefix = '{0}',", strPrefix); //前缀
 }
 else
 {
 sbSQL.Append(" Prefix = null,"); //前缀
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrefixFldId))
 {
 if (objTabFieldRelaEN.PrefixFldId !=  null)
 {
 var strPrefixFldId = objTabFieldRelaEN.PrefixFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrefixFldId = '{0}',", strPrefixFldId); //前缀字段Id
 }
 else
 {
 sbSQL.Append(" PrefixFldId = null,"); //前缀字段Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.vFieldCnName))
 {
 if (objTabFieldRelaEN.vFieldCnName !=  null)
 {
 var strvFieldCnName = objTabFieldRelaEN.vFieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" vFieldCnName = '{0}',", strvFieldCnName); //视图字段中文名称
 }
 else
 {
 sbSQL.Append(" vFieldCnName = null,"); //视图字段中文名称
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
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabFieldRelaEN objTabFieldRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTabFieldRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFieldRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabFieldRela Set ");
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldId))
 {
 if (objTabFieldRelaEN.FldId !=  null)
 {
 var strFldId = objTabFieldRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conTabFieldRela.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FldId); //字段Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TabId))
 {
 if (objTabFieldRelaEN.TabId  ==  "")
 {
 objTabFieldRelaEN.TabId = null;
 }
 if (objTabFieldRelaEN.TabId !=  null)
 {
 var strTabId = objTabFieldRelaEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conTabFieldRela.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TabId); //表ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SqlFldName))
 {
 if (objTabFieldRelaEN.SqlFldName !=  null)
 {
 var strSqlFldName = objTabFieldRelaEN.SqlFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlFldName, conTabFieldRela.SqlFldName); //Sql字段名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.SqlFldName); //Sql字段名称
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ExcelFieldName))
 {
 if (objTabFieldRelaEN.ExcelFieldName !=  null)
 {
 var strExcelFieldName = objTabFieldRelaEN.ExcelFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExcelFieldName, conTabFieldRela.ExcelFieldName); //Excel字段名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.ExcelFieldName); //Excel字段名称
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.DefaultValue))
 {
 if (objTabFieldRelaEN.DefaultValue !=  null)
 {
 var strDefaultValue = objTabFieldRelaEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conTabFieldRela.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.DefaultValue); //缺省值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedTrans))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsNeedTrans == true?"1":"0", conTabFieldRela.IsNeedTrans); //是否需要转换
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransWayId))
 {
 if (objTabFieldRelaEN.TransWayId !=  null)
 {
 var strTransWayId = objTabFieldRelaEN.TransWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransWayId, conTabFieldRela.TransWayId); //转换方式ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransWayId); //转换方式ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransTabName))
 {
 if (objTabFieldRelaEN.TransTabName !=  null)
 {
 var strTransTabName = objTabFieldRelaEN.TransTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransTabName, conTabFieldRela.TransTabName); //转换表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransTabName); //转换表名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransInFldName))
 {
 if (objTabFieldRelaEN.TransInFldName !=  null)
 {
 var strTransInFldName = objTabFieldRelaEN.TransInFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransInFldName, conTabFieldRela.TransInFldName); //转换IN字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransInFldName); //转换IN字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransOutFldName))
 {
 if (objTabFieldRelaEN.TransOutFldName !=  null)
 {
 var strTransOutFldName = objTabFieldRelaEN.TransOutFldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransOutFldName, conTabFieldRela.TransOutFldName); //转换Out字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransOutFldName); //转换Out字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabPrimary))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsTabPrimary == true?"1":"0", conTabFieldRela.IsTabPrimary); //是否作为表中主键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabForeignKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsTabForeignKey == true?"1":"0", conTabFieldRela.IsTabForeignKey); //是否表外键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryTypeId))
 {
 if (objTabFieldRelaEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objTabFieldRelaEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeId, conTabFieldRela.PrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrimaryTypeId); //主键类型ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsIdentity))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsIdentity == true?"1":"0", conTabFieldRela.IsIdentity); //是否Identity
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabUnique))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsTabUnique == true?"1":"0", conTabFieldRela.IsTabUnique); //是否表中唯一
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsTabNullable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsTabNullable == true?"1":"0", conTabFieldRela.IsTabNullable); //是否表中可空
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeId))
 {
 if (objTabFieldRelaEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objTabFieldRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conTabFieldRela.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FieldTypeId); //字段类型Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsNeedCheckPriForeignKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsNeedCheckPriForeignKey == true?"1":"0", conTabFieldRela.IsNeedCheckPriForeignKey); //是否检查主外键
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyTabName))
 {
 if (objTabFieldRelaEN.PrimaryKeyTabName !=  null)
 {
 var strPrimaryKeyTabName = objTabFieldRelaEN.PrimaryKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyTabName, conTabFieldRela.PrimaryKeyTabName); //主键表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrimaryKeyTabName); //主键表
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrimaryKeyFieldName))
 {
 if (objTabFieldRelaEN.PrimaryKeyFieldName !=  null)
 {
 var strPrimaryKeyFieldName = objTabFieldRelaEN.PrimaryKeyFieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyFieldName, conTabFieldRela.PrimaryKeyFieldName); //主键字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrimaryKeyFieldName); //主键字段名
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransMissingValue))
 {
 if (objTabFieldRelaEN.TransMissingValue !=  null)
 {
 var strTransMissingValue = objTabFieldRelaEN.TransMissingValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransMissingValue, conTabFieldRela.TransMissingValue); //转换失败值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransMissingValue); //转换失败值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.TransNullValue))
 {
 if (objTabFieldRelaEN.TransNullValue !=  null)
 {
 var strTransNullValue = objTabFieldRelaEN.TransNullValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTransNullValue, conTabFieldRela.TransNullValue); //转换空值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.TransNullValue); //转换空值
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrjId))
 {
 if (objTabFieldRelaEN.PrjId !=  null)
 {
 var strPrjId = objTabFieldRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTabFieldRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrjId); //工程Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsVisible == true?"1":"0", conTabFieldRela.IsVisible); //是否显示
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.SequenceNumber))
 {
 if (objTabFieldRelaEN.SequenceNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.SequenceNumber, conTabFieldRela.SequenceNumber); //顺序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.SequenceNumber); //顺序号
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Memo))
 {
 if (objTabFieldRelaEN.Memo !=  null)
 {
 var strMemo = objTabFieldRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabFieldRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.Memo); //说明
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FieldTypeIdS))
 {
 if (objTabFieldRelaEN.FieldTypeIdS !=  null)
 {
 var strFieldTypeIdS = objTabFieldRelaEN.FieldTypeIdS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeIdS, conTabFieldRela.FieldTypeIdS); //FieldTypeId_S
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FieldTypeIdS); //FieldTypeId_S
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.FldLengthS))
 {
 if (objTabFieldRelaEN.FldLengthS !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.FldLengthS, conTabFieldRela.FldLengthS); //FldLength_S
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.FldLengthS); //FldLength_S
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.ForeignKeyTabId))
 {
 if (objTabFieldRelaEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objTabFieldRelaEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyTabId, conTabFieldRela.ForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.ForeignKeyTabId); //外键表ID
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.HashIndex))
 {
 if (objTabFieldRelaEN.HashIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFieldRelaEN.HashIndex, conTabFieldRela.HashIndex); //HASH表序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.HashIndex); //HASH表序号
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.IsUseHash))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFieldRelaEN.IsUseHash == true?"1":"0", conTabFieldRela.IsUseHash); //是否用HASH表
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.Prefix))
 {
 if (objTabFieldRelaEN.Prefix !=  null)
 {
 var strPrefix = objTabFieldRelaEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrefix, conTabFieldRela.Prefix); //前缀
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.Prefix); //前缀
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.PrefixFldId))
 {
 if (objTabFieldRelaEN.PrefixFldId !=  null)
 {
 var strPrefixFldId = objTabFieldRelaEN.PrefixFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrefixFldId, conTabFieldRela.PrefixFldId); //前缀字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.PrefixFldId); //前缀字段Id
 }
 }
 
 if (objTabFieldRelaEN.IsUpdated(conTabFieldRela.vFieldCnName))
 {
 if (objTabFieldRelaEN.vFieldCnName !=  null)
 {
 var strvFieldCnName = objTabFieldRelaEN.vFieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strvFieldCnName, conTabFieldRela.vFieldCnName); //视图字段中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFieldRela.vFieldCnName); //视图字段中文名称
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdFieldTabRela = {0}", objTabFieldRelaEN.IdFieldTabRela); 
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
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdFieldTabRela) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdFieldTabRela,
};
 objSQL.ExecSP("TabFieldRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdFieldTabRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
//删除TabFieldRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabFieldRela where IdFieldTabRela = " + ""+ lngIdFieldTabRela+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTabFieldRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除TabFieldRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabFieldRela where IdFieldTabRela in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdFieldTabRela) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
//删除TabFieldRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabFieldRela where IdFieldTabRela = " + ""+ lngIdFieldTabRela+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTabFieldRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: DelTabFieldRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabFieldRela where " + strCondition ;
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
public bool DelTabFieldRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTabFieldRelaDA: DelTabFieldRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabFieldRela where " + strCondition ;
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
 /// <param name = "objTabFieldRelaENS">源对象</param>
 /// <param name = "objTabFieldRelaENT">目标对象</param>
public void CopyTo(clsTabFieldRelaEN objTabFieldRelaENS, clsTabFieldRelaEN objTabFieldRelaENT)
{
objTabFieldRelaENT.IdFieldTabRela = objTabFieldRelaENS.IdFieldTabRela; //字段表关系流水号
objTabFieldRelaENT.FldId = objTabFieldRelaENS.FldId; //字段Id
objTabFieldRelaENT.TabId = objTabFieldRelaENS.TabId; //表ID
objTabFieldRelaENT.SqlFldName = objTabFieldRelaENS.SqlFldName; //Sql字段名称
objTabFieldRelaENT.ExcelFieldName = objTabFieldRelaENS.ExcelFieldName; //Excel字段名称
objTabFieldRelaENT.DefaultValue = objTabFieldRelaENS.DefaultValue; //缺省值
objTabFieldRelaENT.IsNeedTrans = objTabFieldRelaENS.IsNeedTrans; //是否需要转换
objTabFieldRelaENT.TransWayId = objTabFieldRelaENS.TransWayId; //转换方式ID
objTabFieldRelaENT.TransTabName = objTabFieldRelaENS.TransTabName; //转换表名
objTabFieldRelaENT.TransInFldName = objTabFieldRelaENS.TransInFldName; //转换IN字段名
objTabFieldRelaENT.TransOutFldName = objTabFieldRelaENS.TransOutFldName; //转换Out字段名
objTabFieldRelaENT.IsTabPrimary = objTabFieldRelaENS.IsTabPrimary; //是否作为表中主键
objTabFieldRelaENT.IsTabForeignKey = objTabFieldRelaENS.IsTabForeignKey; //是否表外键
objTabFieldRelaENT.PrimaryTypeId = objTabFieldRelaENS.PrimaryTypeId; //主键类型ID
objTabFieldRelaENT.IsIdentity = objTabFieldRelaENS.IsIdentity; //是否Identity
objTabFieldRelaENT.IsTabUnique = objTabFieldRelaENS.IsTabUnique; //是否表中唯一
objTabFieldRelaENT.IsTabNullable = objTabFieldRelaENS.IsTabNullable; //是否表中可空
objTabFieldRelaENT.FieldTypeId = objTabFieldRelaENS.FieldTypeId; //字段类型Id
objTabFieldRelaENT.IsNeedCheckPriForeignKey = objTabFieldRelaENS.IsNeedCheckPriForeignKey; //是否检查主外键
objTabFieldRelaENT.PrimaryKeyTabName = objTabFieldRelaENS.PrimaryKeyTabName; //主键表
objTabFieldRelaENT.PrimaryKeyFieldName = objTabFieldRelaENS.PrimaryKeyFieldName; //主键字段名
objTabFieldRelaENT.TransMissingValue = objTabFieldRelaENS.TransMissingValue; //转换失败值
objTabFieldRelaENT.TransNullValue = objTabFieldRelaENS.TransNullValue; //转换空值
objTabFieldRelaENT.PrjId = objTabFieldRelaENS.PrjId; //工程Id
objTabFieldRelaENT.IsVisible = objTabFieldRelaENS.IsVisible; //是否显示
objTabFieldRelaENT.SequenceNumber = objTabFieldRelaENS.SequenceNumber; //顺序号
objTabFieldRelaENT.Memo = objTabFieldRelaENS.Memo; //说明
objTabFieldRelaENT.FieldTypeIdS = objTabFieldRelaENS.FieldTypeIdS; //FieldTypeId_S
objTabFieldRelaENT.FldLengthS = objTabFieldRelaENS.FldLengthS; //FldLength_S
objTabFieldRelaENT.ForeignKeyTabId = objTabFieldRelaENS.ForeignKeyTabId; //外键表ID
objTabFieldRelaENT.HashIndex = objTabFieldRelaENS.HashIndex; //HASH表序号
objTabFieldRelaENT.IsUseHash = objTabFieldRelaENS.IsUseHash; //是否用HASH表
objTabFieldRelaENT.Prefix = objTabFieldRelaENS.Prefix; //前缀
objTabFieldRelaENT.PrefixFldId = objTabFieldRelaENS.PrefixFldId; //前缀字段Id
objTabFieldRelaENT.vFieldCnName = objTabFieldRelaENS.vFieldCnName; //视图字段中文名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTabFieldRelaEN objTabFieldRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTabFieldRelaEN.FldId, conTabFieldRela.FldId);
clsCheckSql.CheckFieldNotNull(objTabFieldRelaEN.TabId, conTabFieldRela.TabId);
clsCheckSql.CheckFieldNotNull(objTabFieldRelaEN.TransWayId, conTabFieldRela.TransWayId);
clsCheckSql.CheckFieldNotNull(objTabFieldRelaEN.PrjId, conTabFieldRela.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.FldId, 8, conTabFieldRela.FldId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TabId, 8, conTabFieldRela.TabId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.SqlFldName, 100, conTabFieldRela.SqlFldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.ExcelFieldName, 100, conTabFieldRela.ExcelFieldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.DefaultValue, 50, conTabFieldRela.DefaultValue);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransWayId, 2, conTabFieldRela.TransWayId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransTabName, 50, conTabFieldRela.TransTabName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransInFldName, 50, conTabFieldRela.TransInFldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransOutFldName, 50, conTabFieldRela.TransOutFldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrimaryTypeId, 2, conTabFieldRela.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.FieldTypeId, 2, conTabFieldRela.FieldTypeId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrimaryKeyTabName, 50, conTabFieldRela.PrimaryKeyTabName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrimaryKeyFieldName, 50, conTabFieldRela.PrimaryKeyFieldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransMissingValue, 50, conTabFieldRela.TransMissingValue);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransNullValue, 50, conTabFieldRela.TransNullValue);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrjId, 4, conTabFieldRela.PrjId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.Memo, 1000, conTabFieldRela.Memo);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.FieldTypeIdS, 2, conTabFieldRela.FieldTypeIdS);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.ForeignKeyTabId, 8, conTabFieldRela.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.Prefix, 10, conTabFieldRela.Prefix);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrefixFldId, 8, conTabFieldRela.PrefixFldId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.vFieldCnName, 100, conTabFieldRela.vFieldCnName);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objTabFieldRelaEN.TabId, 8, conTabFieldRela.TabId);
 objTabFieldRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTabFieldRelaEN objTabFieldRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.FldId, 8, conTabFieldRela.FldId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TabId, 8, conTabFieldRela.TabId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.SqlFldName, 100, conTabFieldRela.SqlFldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.ExcelFieldName, 100, conTabFieldRela.ExcelFieldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.DefaultValue, 50, conTabFieldRela.DefaultValue);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransWayId, 2, conTabFieldRela.TransWayId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransTabName, 50, conTabFieldRela.TransTabName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransInFldName, 50, conTabFieldRela.TransInFldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransOutFldName, 50, conTabFieldRela.TransOutFldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrimaryTypeId, 2, conTabFieldRela.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.FieldTypeId, 2, conTabFieldRela.FieldTypeId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrimaryKeyTabName, 50, conTabFieldRela.PrimaryKeyTabName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrimaryKeyFieldName, 50, conTabFieldRela.PrimaryKeyFieldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransMissingValue, 50, conTabFieldRela.TransMissingValue);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransNullValue, 50, conTabFieldRela.TransNullValue);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrjId, 4, conTabFieldRela.PrjId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.Memo, 1000, conTabFieldRela.Memo);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.FieldTypeIdS, 2, conTabFieldRela.FieldTypeIdS);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.ForeignKeyTabId, 8, conTabFieldRela.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.Prefix, 10, conTabFieldRela.Prefix);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrefixFldId, 8, conTabFieldRela.PrefixFldId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.vFieldCnName, 100, conTabFieldRela.vFieldCnName);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTabFieldRelaEN.TabId, 8, conTabFieldRela.TabId);
 objTabFieldRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTabFieldRelaEN objTabFieldRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.FldId, 8, conTabFieldRela.FldId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TabId, 8, conTabFieldRela.TabId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.SqlFldName, 100, conTabFieldRela.SqlFldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.ExcelFieldName, 100, conTabFieldRela.ExcelFieldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.DefaultValue, 50, conTabFieldRela.DefaultValue);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransWayId, 2, conTabFieldRela.TransWayId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransTabName, 50, conTabFieldRela.TransTabName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransInFldName, 50, conTabFieldRela.TransInFldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransOutFldName, 50, conTabFieldRela.TransOutFldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrimaryTypeId, 2, conTabFieldRela.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.FieldTypeId, 2, conTabFieldRela.FieldTypeId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrimaryKeyTabName, 50, conTabFieldRela.PrimaryKeyTabName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrimaryKeyFieldName, 50, conTabFieldRela.PrimaryKeyFieldName);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransMissingValue, 50, conTabFieldRela.TransMissingValue);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.TransNullValue, 50, conTabFieldRela.TransNullValue);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrjId, 4, conTabFieldRela.PrjId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.Memo, 1000, conTabFieldRela.Memo);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.FieldTypeIdS, 2, conTabFieldRela.FieldTypeIdS);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.ForeignKeyTabId, 8, conTabFieldRela.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.Prefix, 10, conTabFieldRela.Prefix);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.PrefixFldId, 8, conTabFieldRela.PrefixFldId);
clsCheckSql.CheckFieldLen(objTabFieldRelaEN.vFieldCnName, 100, conTabFieldRela.vFieldCnName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.FldId, conTabFieldRela.FldId);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.TabId, conTabFieldRela.TabId);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.SqlFldName, conTabFieldRela.SqlFldName);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.ExcelFieldName, conTabFieldRela.ExcelFieldName);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.DefaultValue, conTabFieldRela.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.TransWayId, conTabFieldRela.TransWayId);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.TransTabName, conTabFieldRela.TransTabName);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.TransInFldName, conTabFieldRela.TransInFldName);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.TransOutFldName, conTabFieldRela.TransOutFldName);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.PrimaryTypeId, conTabFieldRela.PrimaryTypeId);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.FieldTypeId, conTabFieldRela.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.PrimaryKeyTabName, conTabFieldRela.PrimaryKeyTabName);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.PrimaryKeyFieldName, conTabFieldRela.PrimaryKeyFieldName);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.TransMissingValue, conTabFieldRela.TransMissingValue);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.TransNullValue, conTabFieldRela.TransNullValue);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.PrjId, conTabFieldRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.Memo, conTabFieldRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.FieldTypeIdS, conTabFieldRela.FieldTypeIdS);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.ForeignKeyTabId, conTabFieldRela.ForeignKeyTabId);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.Prefix, conTabFieldRela.Prefix);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.PrefixFldId, conTabFieldRela.PrefixFldId);
clsCheckSql.CheckSqlInjection4Field(objTabFieldRelaEN.vFieldCnName, conTabFieldRela.vFieldCnName);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTabFieldRelaEN.TabId, 8, conTabFieldRela.TabId);
 objTabFieldRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TabFieldRela(表字段关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTabFieldRelaEN objTabFieldRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabFieldRelaEN.FldId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFieldRelaEN.TabId);
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
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
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
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
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
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabFieldRelaEN._CurrTabName);
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
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabFieldRelaEN._CurrTabName, strCondition);
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
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
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
 objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}