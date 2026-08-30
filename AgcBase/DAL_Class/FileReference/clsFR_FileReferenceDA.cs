
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFR_FileReferenceDA
 表名:FR_FileReference(00050658)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/23 22:47:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件引用(FileReference)
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
 /// FR_FileReference(FR_FileReference)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFR_FileReferenceDA : clsCommBase4DA
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
 return clsFR_FileReferenceEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFR_FileReferenceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFR_FileReferenceEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFR_FileReferenceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFR_FileReferenceEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FR_FileReference(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetDataTable_FR_FileReference)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FR_FileReference where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FR_FileReference where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FR_FileReference where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FR_FileReference.* " + 
$"from FR_FileReference " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FR_FileReference.mId not in " + 
$"(Select top {intTop_In} FR_FileReference.mId from FR_FileReference " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FR_FileReference where {1} and mId not in (Select top {2} mId from FR_FileReference where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FR_FileReference where {1} and mId not in (Select top {3} mId from FR_FileReference where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FR_FileReference.* " + 
$"from FR_FileReference " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FR_FileReference.mId not in " + 
$"(Select top {intTop_In} FR_FileReference.mId from FR_FileReference " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FR_FileReference where {1} and mId not in (Select top {2} mId from FR_FileReference where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FR_FileReference where {1} and mId not in (Select top {3} mId from FR_FileReference where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFR_FileReferenceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA:GetObjLst)", objException.Message));
}
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = TransNullToInt(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = TransNullToInt(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = TransNullToInt(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = TransNullToDate(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFR_FileReferenceDA: GetObjLst)", objException.Message));
}
objFR_FileReferenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFR_FileReferenceEN);
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
public List<clsFR_FileReferenceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA:GetObjLstByTabName)", objException.Message));
}
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = TransNullToInt(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = TransNullToInt(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = TransNullToInt(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = TransNullToDate(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFR_FileReferenceDA: GetObjLst)", objException.Message));
}
objFR_FileReferenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFR_FileReferenceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFR_FileReference(ref clsFR_FileReferenceEN objFR_FileReferenceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where mId = " + ""+ objFR_FileReferenceEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFR_FileReferenceEN.mId = TransNullToInt(objDT.Rows[0][conFR_FileReference.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_FileReferenceEN.SourceFileId = TransNullToInt(objDT.Rows[0][conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_FileReferenceEN.TargetFileId = TransNullToInt(objDT.Rows[0][conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_FileReferenceEN.SourceSymbolId = TransNullToInt(objDT.Rows[0][conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id(字段类型:bigint,字段长度:8,是否可空:True)
 objFR_FileReferenceEN.TargetSymbolId = TransNullToInt(objDT.Rows[0][conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id(字段类型:bigint,字段长度:8,是否可空:True)
 objFR_FileReferenceEN.RefType = objDT.Rows[0][conFR_FileReference.RefType].ToString().Trim(); //引用类型(字段类型:varchar,字段长度:50,是否可空:False)
 objFR_FileReferenceEN.RefName = objDT.Rows[0][conFR_FileReference.RefName].ToString().Trim(); //引用名(字段类型:varchar,字段长度:100,是否可空:False)
 objFR_FileReferenceEN.RefAlias = objDT.Rows[0][conFR_FileReference.RefAlias].ToString().Trim(); //别名(字段类型:varchar,字段长度:100,是否可空:True)
 objFR_FileReferenceEN.LineStart = TransNullToInt(objDT.Rows[0][conFR_FileReference.LineStart].ToString().Trim()); //开始行(字段类型:int,字段长度:4,是否可空:True)
 objFR_FileReferenceEN.LineEnd = TransNullToInt(objDT.Rows[0][conFR_FileReference.LineEnd].ToString().Trim()); //结束行(字段类型:int,字段长度:4,是否可空:True)
 objFR_FileReferenceEN.ColumnStart = TransNullToInt(objDT.Rows[0][conFR_FileReference.ColumnStart].ToString().Trim()); //开始列(字段类型:int,字段长度:4,是否可空:True)
 objFR_FileReferenceEN.ColumnEnd = TransNullToInt(objDT.Rows[0][conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列(字段类型:int,字段长度:4,是否可空:True)
 objFR_FileReferenceEN.RefStatement = objDT.Rows[0][conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句(字段类型:varchar,字段长度:500,是否可空:True)
 objFR_FileReferenceEN.CreatedAt = TransNullToDate(objDT.Rows[0][conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFR_FileReferenceDA: GetFR_FileReference)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsFR_FileReferenceEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
 objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id(字段类型:bigint,字段长度:8,是否可空:True)
 objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id(字段类型:bigint,字段长度:8,是否可空:True)
 objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型(字段类型:varchar,字段长度:50,是否可空:False)
 objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名(字段类型:varchar,字段长度:100,是否可空:False)
 objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名(字段类型:varchar,字段长度:100,是否可空:True)
 objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行(字段类型:int,字段长度:4,是否可空:True)
 objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行(字段类型:int,字段长度:4,是否可空:True)
 objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列(字段类型:int,字段长度:4,是否可空:True)
 objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列(字段类型:int,字段长度:4,是否可空:True)
 objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句(字段类型:varchar,字段长度:500,是否可空:True)
 objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFR_FileReferenceDA: GetObjBymId)", objException.Message));
}
return objFR_FileReferenceEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFR_FileReferenceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN()
{
mId = TransNullToInt(objRow[conFR_FileReference.mId].ToString().Trim()), //mId
SourceFileId = TransNullToInt(objRow[conFR_FileReference.SourceFileId].ToString().Trim()), //源文件Id
TargetFileId = TransNullToInt(objRow[conFR_FileReference.TargetFileId].ToString().Trim()), //目标文件Id
SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()), //源符号Id
TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()), //目标符号Id
RefType = objRow[conFR_FileReference.RefType].ToString().Trim(), //引用类型
RefName = objRow[conFR_FileReference.RefName].ToString().Trim(), //引用名
RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(), //别名
LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineStart].ToString().Trim()), //开始行
LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineEnd].ToString().Trim()), //结束行
ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnStart].ToString().Trim()), //开始列
ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()), //结束列
RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(), //原始引用语句
CreatedAt = TransNullToDate(objRow[conFR_FileReference.CreatedAt].ToString().Trim()) //建立时间
};
objFR_FileReferenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFR_FileReferenceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFR_FileReferenceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFR_FileReferenceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = TransNullToInt(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = TransNullToInt(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = TransNullToInt(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = TransNullToDate(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFR_FileReferenceDA: GetObjByDataRowFR_FileReference)", objException.Message));
}
objFR_FileReferenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFR_FileReferenceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFR_FileReferenceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = TransNullToInt(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = TransNullToInt(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = TransNullToInt(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = TransNullToDate(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFR_FileReferenceDA: GetObjByDataRow)", objException.Message));
}
objFR_FileReferenceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFR_FileReferenceEN;
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
objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFR_FileReferenceEN._CurrTabName, conFR_FileReference.mId, 8, "");
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
objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFR_FileReferenceEN._CurrTabName, conFR_FileReference.mId, 8, strPrefix);
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
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from FR_FileReference where " + strCondition;
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
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from FR_FileReference where " + strCondition;
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
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FR_FileReference", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FR_FileReference", strCondition))
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
objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FR_FileReference");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFR_FileReferenceEN objFR_FileReferenceEN)
 {
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_FileReferenceEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FR_FileReference");
objRow = objDS.Tables["FR_FileReference"].NewRow();
objRow[conFR_FileReference.mId] = objFR_FileReferenceEN.mId; //mId
objRow[conFR_FileReference.SourceFileId] = objFR_FileReferenceEN.SourceFileId; //源文件Id
objRow[conFR_FileReference.TargetFileId] = objFR_FileReferenceEN.TargetFileId; //目标文件Id
objRow[conFR_FileReference.SourceSymbolId] = objFR_FileReferenceEN.SourceSymbolId; //源符号Id
objRow[conFR_FileReference.TargetSymbolId] = objFR_FileReferenceEN.TargetSymbolId; //目标符号Id
objRow[conFR_FileReference.RefType] = objFR_FileReferenceEN.RefType; //引用类型
objRow[conFR_FileReference.RefName] = objFR_FileReferenceEN.RefName; //引用名
 if (objFR_FileReferenceEN.RefAlias !=  "")
 {
objRow[conFR_FileReference.RefAlias] = objFR_FileReferenceEN.RefAlias; //别名
 }
objRow[conFR_FileReference.LineStart] = objFR_FileReferenceEN.LineStart; //开始行
objRow[conFR_FileReference.LineEnd] = objFR_FileReferenceEN.LineEnd; //结束行
objRow[conFR_FileReference.ColumnStart] = objFR_FileReferenceEN.ColumnStart; //开始列
objRow[conFR_FileReference.ColumnEnd] = objFR_FileReferenceEN.ColumnEnd; //结束列
 if (objFR_FileReferenceEN.RefStatement !=  "")
 {
objRow[conFR_FileReference.RefStatement] = objFR_FileReferenceEN.RefStatement; //原始引用语句
 }
objRow[conFR_FileReference.CreatedAt] = objFR_FileReferenceEN.CreatedAt; //建立时间
objDS.Tables[clsFR_FileReferenceEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFR_FileReferenceEN._CurrTabName);
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
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_FileReferenceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conFR_FileReference.mId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.mId.ToString());
 
 arrFieldListForInsert.Add(conFR_FileReference.SourceFileId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.SourceFileId.ToString());
 
 arrFieldListForInsert.Add(conFR_FileReference.TargetFileId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.TargetFileId.ToString());
 
 if (objFR_FileReferenceEN.SourceSymbolId !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.SourceSymbolId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.SourceSymbolId.ToString());
 }
 
 if (objFR_FileReferenceEN.TargetSymbolId !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.TargetSymbolId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.TargetSymbolId.ToString());
 }
 
 if (objFR_FileReferenceEN.RefType !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefType);
 var strRefType = objFR_FileReferenceEN.RefType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefType + "'");
 }
 
 if (objFR_FileReferenceEN.RefName !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefName);
 var strRefName = objFR_FileReferenceEN.RefName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefName + "'");
 }
 
 if (objFR_FileReferenceEN.RefAlias !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefAlias);
 var strRefAlias = objFR_FileReferenceEN.RefAlias.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefAlias + "'");
 }
 
 if (objFR_FileReferenceEN.LineStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.LineStart);
 arrValueListForInsert.Add(objFR_FileReferenceEN.LineStart.ToString());
 }
 
 if (objFR_FileReferenceEN.LineEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.LineEnd);
 arrValueListForInsert.Add(objFR_FileReferenceEN.LineEnd.ToString());
 }
 
 if (objFR_FileReferenceEN.ColumnStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.ColumnStart);
 arrValueListForInsert.Add(objFR_FileReferenceEN.ColumnStart.ToString());
 }
 
 if (objFR_FileReferenceEN.ColumnEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.ColumnEnd);
 arrValueListForInsert.Add(objFR_FileReferenceEN.ColumnEnd.ToString());
 }
 
 if (objFR_FileReferenceEN.RefStatement !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefStatement);
 var strRefStatement = objFR_FileReferenceEN.RefStatement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefStatement + "'");
 }
 
 arrFieldListForInsert.Add(conFR_FileReference.CreatedAt);
 var dteCreatedAt = objFR_FileReferenceEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FR_FileReference");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_FileReferenceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conFR_FileReference.mId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.mId.ToString());
 
 arrFieldListForInsert.Add(conFR_FileReference.SourceFileId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.SourceFileId.ToString());
 
 arrFieldListForInsert.Add(conFR_FileReference.TargetFileId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.TargetFileId.ToString());
 
 if (objFR_FileReferenceEN.SourceSymbolId !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.SourceSymbolId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.SourceSymbolId.ToString());
 }
 
 if (objFR_FileReferenceEN.TargetSymbolId !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.TargetSymbolId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.TargetSymbolId.ToString());
 }
 
 if (objFR_FileReferenceEN.RefType !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefType);
 var strRefType = objFR_FileReferenceEN.RefType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefType + "'");
 }
 
 if (objFR_FileReferenceEN.RefName !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefName);
 var strRefName = objFR_FileReferenceEN.RefName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefName + "'");
 }
 
 if (objFR_FileReferenceEN.RefAlias !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefAlias);
 var strRefAlias = objFR_FileReferenceEN.RefAlias.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefAlias + "'");
 }
 
 if (objFR_FileReferenceEN.LineStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.LineStart);
 arrValueListForInsert.Add(objFR_FileReferenceEN.LineStart.ToString());
 }
 
 if (objFR_FileReferenceEN.LineEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.LineEnd);
 arrValueListForInsert.Add(objFR_FileReferenceEN.LineEnd.ToString());
 }
 
 if (objFR_FileReferenceEN.ColumnStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.ColumnStart);
 arrValueListForInsert.Add(objFR_FileReferenceEN.ColumnStart.ToString());
 }
 
 if (objFR_FileReferenceEN.ColumnEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.ColumnEnd);
 arrValueListForInsert.Add(objFR_FileReferenceEN.ColumnEnd.ToString());
 }
 
 if (objFR_FileReferenceEN.RefStatement !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefStatement);
 var strRefStatement = objFR_FileReferenceEN.RefStatement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefStatement + "'");
 }
 
 arrFieldListForInsert.Add(conFR_FileReference.CreatedAt);
 var dteCreatedAt = objFR_FileReferenceEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FR_FileReference");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFR_FileReferenceEN objFR_FileReferenceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_FileReferenceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conFR_FileReference.mId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.mId.ToString());
 
 arrFieldListForInsert.Add(conFR_FileReference.SourceFileId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.SourceFileId.ToString());
 
 arrFieldListForInsert.Add(conFR_FileReference.TargetFileId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.TargetFileId.ToString());
 
 if (objFR_FileReferenceEN.SourceSymbolId !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.SourceSymbolId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.SourceSymbolId.ToString());
 }
 
 if (objFR_FileReferenceEN.TargetSymbolId !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.TargetSymbolId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.TargetSymbolId.ToString());
 }
 
 if (objFR_FileReferenceEN.RefType !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefType);
 var strRefType = objFR_FileReferenceEN.RefType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefType + "'");
 }
 
 if (objFR_FileReferenceEN.RefName !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefName);
 var strRefName = objFR_FileReferenceEN.RefName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefName + "'");
 }
 
 if (objFR_FileReferenceEN.RefAlias !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefAlias);
 var strRefAlias = objFR_FileReferenceEN.RefAlias.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefAlias + "'");
 }
 
 if (objFR_FileReferenceEN.LineStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.LineStart);
 arrValueListForInsert.Add(objFR_FileReferenceEN.LineStart.ToString());
 }
 
 if (objFR_FileReferenceEN.LineEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.LineEnd);
 arrValueListForInsert.Add(objFR_FileReferenceEN.LineEnd.ToString());
 }
 
 if (objFR_FileReferenceEN.ColumnStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.ColumnStart);
 arrValueListForInsert.Add(objFR_FileReferenceEN.ColumnStart.ToString());
 }
 
 if (objFR_FileReferenceEN.ColumnEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.ColumnEnd);
 arrValueListForInsert.Add(objFR_FileReferenceEN.ColumnEnd.ToString());
 }
 
 if (objFR_FileReferenceEN.RefStatement !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefStatement);
 var strRefStatement = objFR_FileReferenceEN.RefStatement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefStatement + "'");
 }
 
 arrFieldListForInsert.Add(conFR_FileReference.CreatedAt);
 var dteCreatedAt = objFR_FileReferenceEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FR_FileReference");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFR_FileReferenceEN objFR_FileReferenceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_FileReferenceEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conFR_FileReference.mId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.mId.ToString());
 
 arrFieldListForInsert.Add(conFR_FileReference.SourceFileId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.SourceFileId.ToString());
 
 arrFieldListForInsert.Add(conFR_FileReference.TargetFileId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.TargetFileId.ToString());
 
 if (objFR_FileReferenceEN.SourceSymbolId !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.SourceSymbolId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.SourceSymbolId.ToString());
 }
 
 if (objFR_FileReferenceEN.TargetSymbolId !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.TargetSymbolId);
 arrValueListForInsert.Add(objFR_FileReferenceEN.TargetSymbolId.ToString());
 }
 
 if (objFR_FileReferenceEN.RefType !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefType);
 var strRefType = objFR_FileReferenceEN.RefType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefType + "'");
 }
 
 if (objFR_FileReferenceEN.RefName !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefName);
 var strRefName = objFR_FileReferenceEN.RefName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefName + "'");
 }
 
 if (objFR_FileReferenceEN.RefAlias !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefAlias);
 var strRefAlias = objFR_FileReferenceEN.RefAlias.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefAlias + "'");
 }
 
 if (objFR_FileReferenceEN.LineStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.LineStart);
 arrValueListForInsert.Add(objFR_FileReferenceEN.LineStart.ToString());
 }
 
 if (objFR_FileReferenceEN.LineEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.LineEnd);
 arrValueListForInsert.Add(objFR_FileReferenceEN.LineEnd.ToString());
 }
 
 if (objFR_FileReferenceEN.ColumnStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.ColumnStart);
 arrValueListForInsert.Add(objFR_FileReferenceEN.ColumnStart.ToString());
 }
 
 if (objFR_FileReferenceEN.ColumnEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.ColumnEnd);
 arrValueListForInsert.Add(objFR_FileReferenceEN.ColumnEnd.ToString());
 }
 
 if (objFR_FileReferenceEN.RefStatement !=  null)
 {
 arrFieldListForInsert.Add(conFR_FileReference.RefStatement);
 var strRefStatement = objFR_FileReferenceEN.RefStatement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRefStatement + "'");
 }
 
 arrFieldListForInsert.Add(conFR_FileReference.CreatedAt);
 var dteCreatedAt = objFR_FileReferenceEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FR_FileReference");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFR_FileReferences(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FR_FileReference");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conFR_FileReference.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFR_FileReferenceEN._CurrTabName ].NewRow();
objRow[conFR_FileReference.mId] = oRow[conFR_FileReference.mId].ToString().Trim(); //mId
objRow[conFR_FileReference.SourceFileId] = oRow[conFR_FileReference.SourceFileId].ToString().Trim(); //源文件Id
objRow[conFR_FileReference.TargetFileId] = oRow[conFR_FileReference.TargetFileId].ToString().Trim(); //目标文件Id
objRow[conFR_FileReference.SourceSymbolId] = oRow[conFR_FileReference.SourceSymbolId].ToString().Trim(); //源符号Id
objRow[conFR_FileReference.TargetSymbolId] = oRow[conFR_FileReference.TargetSymbolId].ToString().Trim(); //目标符号Id
objRow[conFR_FileReference.RefType] = oRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objRow[conFR_FileReference.RefName] = oRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objRow[conFR_FileReference.RefAlias] = oRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objRow[conFR_FileReference.LineStart] = oRow[conFR_FileReference.LineStart].ToString().Trim(); //开始行
objRow[conFR_FileReference.LineEnd] = oRow[conFR_FileReference.LineEnd].ToString().Trim(); //结束行
objRow[conFR_FileReference.ColumnStart] = oRow[conFR_FileReference.ColumnStart].ToString().Trim(); //开始列
objRow[conFR_FileReference.ColumnEnd] = oRow[conFR_FileReference.ColumnEnd].ToString().Trim(); //结束列
objRow[conFR_FileReference.RefStatement] = oRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objRow[conFR_FileReference.CreatedAt] = oRow[conFR_FileReference.CreatedAt].ToString().Trim(); //建立时间
 objDS.Tables[clsFR_FileReferenceEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFR_FileReferenceEN._CurrTabName);
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
 /// <param name = "objFR_FileReferenceEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_FileReferenceEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
strSQL = "Select * from FR_FileReference where mId = " + ""+ objFR_FileReferenceEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFR_FileReferenceEN._CurrTabName);
if (objDS.Tables[clsFR_FileReferenceEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objFR_FileReferenceEN.mId+"");
return false;
}
objRow = objDS.Tables[clsFR_FileReferenceEN._CurrTabName].Rows[0];
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.mId))
 {
objRow[conFR_FileReference.mId] = objFR_FileReferenceEN.mId; //mId
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceFileId))
 {
objRow[conFR_FileReference.SourceFileId] = objFR_FileReferenceEN.SourceFileId; //源文件Id
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetFileId))
 {
objRow[conFR_FileReference.TargetFileId] = objFR_FileReferenceEN.TargetFileId; //目标文件Id
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceSymbolId))
 {
objRow[conFR_FileReference.SourceSymbolId] = objFR_FileReferenceEN.SourceSymbolId; //源符号Id
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetSymbolId))
 {
objRow[conFR_FileReference.TargetSymbolId] = objFR_FileReferenceEN.TargetSymbolId; //目标符号Id
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefType))
 {
objRow[conFR_FileReference.RefType] = objFR_FileReferenceEN.RefType; //引用类型
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefName))
 {
objRow[conFR_FileReference.RefName] = objFR_FileReferenceEN.RefName; //引用名
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefAlias))
 {
objRow[conFR_FileReference.RefAlias] = objFR_FileReferenceEN.RefAlias; //别名
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineStart))
 {
objRow[conFR_FileReference.LineStart] = objFR_FileReferenceEN.LineStart; //开始行
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineEnd))
 {
objRow[conFR_FileReference.LineEnd] = objFR_FileReferenceEN.LineEnd; //结束行
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnStart))
 {
objRow[conFR_FileReference.ColumnStart] = objFR_FileReferenceEN.ColumnStart; //开始列
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnEnd))
 {
objRow[conFR_FileReference.ColumnEnd] = objFR_FileReferenceEN.ColumnEnd; //结束列
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefStatement))
 {
objRow[conFR_FileReference.RefStatement] = objFR_FileReferenceEN.RefStatement; //原始引用语句
 }
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.CreatedAt))
 {
objRow[conFR_FileReference.CreatedAt] = objFR_FileReferenceEN.CreatedAt; //建立时间
 }
try
{
objDA.Update(objDS, clsFR_FileReferenceEN._CurrTabName);
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
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_FileReferenceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FR_FileReference Set ");
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceFileId))
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.SourceFileId, conFR_FileReference.SourceFileId); //源文件Id
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetFileId))
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.TargetFileId, conFR_FileReference.TargetFileId); //目标文件Id
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceSymbolId))
 {
 if (objFR_FileReferenceEN.SourceSymbolId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.SourceSymbolId, conFR_FileReference.SourceSymbolId); //源符号Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.SourceSymbolId); //源符号Id
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetSymbolId))
 {
 if (objFR_FileReferenceEN.TargetSymbolId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.TargetSymbolId, conFR_FileReference.TargetSymbolId); //目标符号Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.TargetSymbolId); //目标符号Id
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefType))
 {
 if (objFR_FileReferenceEN.RefType !=  null)
 {
 var strRefType = objFR_FileReferenceEN.RefType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRefType, conFR_FileReference.RefType); //引用类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.RefType); //引用类型
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefName))
 {
 if (objFR_FileReferenceEN.RefName !=  null)
 {
 var strRefName = objFR_FileReferenceEN.RefName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRefName, conFR_FileReference.RefName); //引用名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.RefName); //引用名
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefAlias))
 {
 if (objFR_FileReferenceEN.RefAlias !=  null)
 {
 var strRefAlias = objFR_FileReferenceEN.RefAlias.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRefAlias, conFR_FileReference.RefAlias); //别名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.RefAlias); //别名
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineStart))
 {
 if (objFR_FileReferenceEN.LineStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.LineStart, conFR_FileReference.LineStart); //开始行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.LineStart); //开始行
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineEnd))
 {
 if (objFR_FileReferenceEN.LineEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.LineEnd, conFR_FileReference.LineEnd); //结束行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.LineEnd); //结束行
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnStart))
 {
 if (objFR_FileReferenceEN.ColumnStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.ColumnStart, conFR_FileReference.ColumnStart); //开始列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.ColumnStart); //开始列
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnEnd))
 {
 if (objFR_FileReferenceEN.ColumnEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.ColumnEnd, conFR_FileReference.ColumnEnd); //结束列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.ColumnEnd); //结束列
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefStatement))
 {
 if (objFR_FileReferenceEN.RefStatement !=  null)
 {
 var strRefStatement = objFR_FileReferenceEN.RefStatement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRefStatement, conFR_FileReference.RefStatement); //原始引用语句
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.RefStatement); //原始引用语句
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.CreatedAt))
 {
 if (objFR_FileReferenceEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objFR_FileReferenceEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conFR_FileReference.CreatedAt); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.CreatedAt); //建立时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFR_FileReferenceEN.mId); 
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
 /// <param name = "objFR_FileReferenceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFR_FileReferenceEN objFR_FileReferenceEN, string strCondition)
{
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_FileReferenceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FR_FileReference Set ");
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceFileId))
 {
 sbSQL.AppendFormat(" SourceFileId = {0},", objFR_FileReferenceEN.SourceFileId); //源文件Id
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetFileId))
 {
 sbSQL.AppendFormat(" TargetFileId = {0},", objFR_FileReferenceEN.TargetFileId); //目标文件Id
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceSymbolId))
 {
 if (objFR_FileReferenceEN.SourceSymbolId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.SourceSymbolId, conFR_FileReference.SourceSymbolId); //源符号Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.SourceSymbolId); //源符号Id
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetSymbolId))
 {
 if (objFR_FileReferenceEN.TargetSymbolId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.TargetSymbolId, conFR_FileReference.TargetSymbolId); //目标符号Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.TargetSymbolId); //目标符号Id
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefType))
 {
 if (objFR_FileReferenceEN.RefType !=  null)
 {
 var strRefType = objFR_FileReferenceEN.RefType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RefType = '{0}',", strRefType); //引用类型
 }
 else
 {
 sbSQL.Append(" RefType = null,"); //引用类型
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefName))
 {
 if (objFR_FileReferenceEN.RefName !=  null)
 {
 var strRefName = objFR_FileReferenceEN.RefName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RefName = '{0}',", strRefName); //引用名
 }
 else
 {
 sbSQL.Append(" RefName = null,"); //引用名
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefAlias))
 {
 if (objFR_FileReferenceEN.RefAlias !=  null)
 {
 var strRefAlias = objFR_FileReferenceEN.RefAlias.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RefAlias = '{0}',", strRefAlias); //别名
 }
 else
 {
 sbSQL.Append(" RefAlias = null,"); //别名
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineStart))
 {
 if (objFR_FileReferenceEN.LineStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.LineStart, conFR_FileReference.LineStart); //开始行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.LineStart); //开始行
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineEnd))
 {
 if (objFR_FileReferenceEN.LineEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.LineEnd, conFR_FileReference.LineEnd); //结束行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.LineEnd); //结束行
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnStart))
 {
 if (objFR_FileReferenceEN.ColumnStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.ColumnStart, conFR_FileReference.ColumnStart); //开始列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.ColumnStart); //开始列
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnEnd))
 {
 if (objFR_FileReferenceEN.ColumnEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.ColumnEnd, conFR_FileReference.ColumnEnd); //结束列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.ColumnEnd); //结束列
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefStatement))
 {
 if (objFR_FileReferenceEN.RefStatement !=  null)
 {
 var strRefStatement = objFR_FileReferenceEN.RefStatement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RefStatement = '{0}',", strRefStatement); //原始引用语句
 }
 else
 {
 sbSQL.Append(" RefStatement = null,"); //原始引用语句
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.CreatedAt))
 {
 if (objFR_FileReferenceEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objFR_FileReferenceEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //建立时间
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //建立时间
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
 /// <param name = "objFR_FileReferenceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFR_FileReferenceEN objFR_FileReferenceEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_FileReferenceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FR_FileReference Set ");
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceFileId))
 {
 sbSQL.AppendFormat(" SourceFileId = {0},", objFR_FileReferenceEN.SourceFileId); //源文件Id
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetFileId))
 {
 sbSQL.AppendFormat(" TargetFileId = {0},", objFR_FileReferenceEN.TargetFileId); //目标文件Id
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceSymbolId))
 {
 if (objFR_FileReferenceEN.SourceSymbolId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.SourceSymbolId, conFR_FileReference.SourceSymbolId); //源符号Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.SourceSymbolId); //源符号Id
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetSymbolId))
 {
 if (objFR_FileReferenceEN.TargetSymbolId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.TargetSymbolId, conFR_FileReference.TargetSymbolId); //目标符号Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.TargetSymbolId); //目标符号Id
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefType))
 {
 if (objFR_FileReferenceEN.RefType !=  null)
 {
 var strRefType = objFR_FileReferenceEN.RefType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RefType = '{0}',", strRefType); //引用类型
 }
 else
 {
 sbSQL.Append(" RefType = null,"); //引用类型
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefName))
 {
 if (objFR_FileReferenceEN.RefName !=  null)
 {
 var strRefName = objFR_FileReferenceEN.RefName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RefName = '{0}',", strRefName); //引用名
 }
 else
 {
 sbSQL.Append(" RefName = null,"); //引用名
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefAlias))
 {
 if (objFR_FileReferenceEN.RefAlias !=  null)
 {
 var strRefAlias = objFR_FileReferenceEN.RefAlias.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RefAlias = '{0}',", strRefAlias); //别名
 }
 else
 {
 sbSQL.Append(" RefAlias = null,"); //别名
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineStart))
 {
 if (objFR_FileReferenceEN.LineStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.LineStart, conFR_FileReference.LineStart); //开始行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.LineStart); //开始行
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineEnd))
 {
 if (objFR_FileReferenceEN.LineEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.LineEnd, conFR_FileReference.LineEnd); //结束行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.LineEnd); //结束行
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnStart))
 {
 if (objFR_FileReferenceEN.ColumnStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.ColumnStart, conFR_FileReference.ColumnStart); //开始列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.ColumnStart); //开始列
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnEnd))
 {
 if (objFR_FileReferenceEN.ColumnEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.ColumnEnd, conFR_FileReference.ColumnEnd); //结束列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.ColumnEnd); //结束列
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefStatement))
 {
 if (objFR_FileReferenceEN.RefStatement !=  null)
 {
 var strRefStatement = objFR_FileReferenceEN.RefStatement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RefStatement = '{0}',", strRefStatement); //原始引用语句
 }
 else
 {
 sbSQL.Append(" RefStatement = null,"); //原始引用语句
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.CreatedAt))
 {
 if (objFR_FileReferenceEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objFR_FileReferenceEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //建立时间
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //建立时间
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
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFR_FileReferenceEN objFR_FileReferenceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFR_FileReferenceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_FileReferenceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FR_FileReference Set ");
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceFileId))
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.SourceFileId, conFR_FileReference.SourceFileId); //源文件Id
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetFileId))
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.TargetFileId, conFR_FileReference.TargetFileId); //目标文件Id
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.SourceSymbolId))
 {
 if (objFR_FileReferenceEN.SourceSymbolId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.SourceSymbolId, conFR_FileReference.SourceSymbolId); //源符号Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.SourceSymbolId); //源符号Id
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.TargetSymbolId))
 {
 if (objFR_FileReferenceEN.TargetSymbolId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.TargetSymbolId, conFR_FileReference.TargetSymbolId); //目标符号Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.TargetSymbolId); //目标符号Id
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefType))
 {
 if (objFR_FileReferenceEN.RefType !=  null)
 {
 var strRefType = objFR_FileReferenceEN.RefType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRefType, conFR_FileReference.RefType); //引用类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.RefType); //引用类型
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefName))
 {
 if (objFR_FileReferenceEN.RefName !=  null)
 {
 var strRefName = objFR_FileReferenceEN.RefName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRefName, conFR_FileReference.RefName); //引用名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.RefName); //引用名
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefAlias))
 {
 if (objFR_FileReferenceEN.RefAlias !=  null)
 {
 var strRefAlias = objFR_FileReferenceEN.RefAlias.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRefAlias, conFR_FileReference.RefAlias); //别名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.RefAlias); //别名
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineStart))
 {
 if (objFR_FileReferenceEN.LineStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.LineStart, conFR_FileReference.LineStart); //开始行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.LineStart); //开始行
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.LineEnd))
 {
 if (objFR_FileReferenceEN.LineEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.LineEnd, conFR_FileReference.LineEnd); //结束行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.LineEnd); //结束行
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnStart))
 {
 if (objFR_FileReferenceEN.ColumnStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.ColumnStart, conFR_FileReference.ColumnStart); //开始列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.ColumnStart); //开始列
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.ColumnEnd))
 {
 if (objFR_FileReferenceEN.ColumnEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_FileReferenceEN.ColumnEnd, conFR_FileReference.ColumnEnd); //结束列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.ColumnEnd); //结束列
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.RefStatement))
 {
 if (objFR_FileReferenceEN.RefStatement !=  null)
 {
 var strRefStatement = objFR_FileReferenceEN.RefStatement.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRefStatement, conFR_FileReference.RefStatement); //原始引用语句
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.RefStatement); //原始引用语句
 }
 }
 
 if (objFR_FileReferenceEN.IsUpdated(conFR_FileReference.CreatedAt))
 {
 if (objFR_FileReferenceEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objFR_FileReferenceEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conFR_FileReference.CreatedAt); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_FileReference.CreatedAt); //建立时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFR_FileReferenceEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("FR_FileReference_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
//删除FR_FileReference本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FR_FileReference where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFR_FileReference(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
//删除FR_FileReference本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FR_FileReference where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
//删除FR_FileReference本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FR_FileReference where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFR_FileReference(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: DelFR_FileReference)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FR_FileReference where " + strCondition ;
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
public bool DelFR_FileReferenceWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFR_FileReferenceDA: DelFR_FileReferenceWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FR_FileReference where " + strCondition ;
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
 /// <param name = "objFR_FileReferenceENS">源对象</param>
 /// <param name = "objFR_FileReferenceENT">目标对象</param>
public void CopyTo(clsFR_FileReferenceEN objFR_FileReferenceENS, clsFR_FileReferenceEN objFR_FileReferenceENT)
{
objFR_FileReferenceENT.mId = objFR_FileReferenceENS.mId; //mId
objFR_FileReferenceENT.SourceFileId = objFR_FileReferenceENS.SourceFileId; //源文件Id
objFR_FileReferenceENT.TargetFileId = objFR_FileReferenceENS.TargetFileId; //目标文件Id
objFR_FileReferenceENT.SourceSymbolId = objFR_FileReferenceENS.SourceSymbolId; //源符号Id
objFR_FileReferenceENT.TargetSymbolId = objFR_FileReferenceENS.TargetSymbolId; //目标符号Id
objFR_FileReferenceENT.RefType = objFR_FileReferenceENS.RefType; //引用类型
objFR_FileReferenceENT.RefName = objFR_FileReferenceENS.RefName; //引用名
objFR_FileReferenceENT.RefAlias = objFR_FileReferenceENS.RefAlias; //别名
objFR_FileReferenceENT.LineStart = objFR_FileReferenceENS.LineStart; //开始行
objFR_FileReferenceENT.LineEnd = objFR_FileReferenceENS.LineEnd; //结束行
objFR_FileReferenceENT.ColumnStart = objFR_FileReferenceENS.ColumnStart; //开始列
objFR_FileReferenceENT.ColumnEnd = objFR_FileReferenceENS.ColumnEnd; //结束列
objFR_FileReferenceENT.RefStatement = objFR_FileReferenceENS.RefStatement; //原始引用语句
objFR_FileReferenceENT.CreatedAt = objFR_FileReferenceENS.CreatedAt; //建立时间
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFR_FileReferenceEN.SourceFileId, conFR_FileReference.SourceFileId);
clsCheckSql.CheckFieldNotNull(objFR_FileReferenceEN.TargetFileId, conFR_FileReference.TargetFileId);
clsCheckSql.CheckFieldNotNull(objFR_FileReferenceEN.RefType, conFR_FileReference.RefType);
clsCheckSql.CheckFieldNotNull(objFR_FileReferenceEN.RefName, conFR_FileReference.RefName);
//检查字段长度
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefType, 50, conFR_FileReference.RefType);
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefName, 100, conFR_FileReference.RefName);
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefAlias, 100, conFR_FileReference.RefAlias);
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefStatement, 500, conFR_FileReference.RefStatement);
//检查字段外键固定长度
 objFR_FileReferenceEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefType, 50, conFR_FileReference.RefType);
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefName, 100, conFR_FileReference.RefName);
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefAlias, 100, conFR_FileReference.RefAlias);
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefStatement, 500, conFR_FileReference.RefStatement);
//检查外键字段长度
 objFR_FileReferenceEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefType, 50, conFR_FileReference.RefType);
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefName, 100, conFR_FileReference.RefName);
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefAlias, 100, conFR_FileReference.RefAlias);
clsCheckSql.CheckFieldLen(objFR_FileReferenceEN.RefStatement, 500, conFR_FileReference.RefStatement);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFR_FileReferenceEN.RefType, conFR_FileReference.RefType);
clsCheckSql.CheckSqlInjection4Field(objFR_FileReferenceEN.RefName, conFR_FileReference.RefName);
clsCheckSql.CheckSqlInjection4Field(objFR_FileReferenceEN.RefAlias, conFR_FileReference.RefAlias);
clsCheckSql.CheckSqlInjection4Field(objFR_FileReferenceEN.RefStatement, conFR_FileReference.RefStatement);
//检查外键字段长度
 objFR_FileReferenceEN._IsCheckProperty = true;
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
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFR_FileReferenceEN._CurrTabName);
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
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFR_FileReferenceEN._CurrTabName, strCondition);
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
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
 objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}