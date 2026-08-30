
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationFileDA
 表名:UiFileRelationFile(00050653)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:49:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// UiFileRelationFile(UiFileRelationFile)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUiFileRelationFileDA : clsCommBase4DA
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
 return clsUiFileRelationFileEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUiFileRelationFileEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUiFileRelationFileEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUiFileRelationFileEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUiFileRelationFileEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UiFileRelationFile(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetDataTable_UiFileRelationFile)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationFile where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationFile where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UiFileRelationFile where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UiFileRelationFile.* " + 
$"from UiFileRelationFile " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UiFileRelationFile.FileId not in " + 
$"(Select top {intTop_In} UiFileRelationFile.FileId from UiFileRelationFile " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationFile where {1} and FileId not in (Select top {2} FileId from UiFileRelationFile where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationFile where {1} and FileId not in (Select top {3} FileId from UiFileRelationFile where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UiFileRelationFile.* " + 
$"from UiFileRelationFile " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UiFileRelationFile.FileId not in " + 
$"(Select top {intTop_In} UiFileRelationFile.FileId from UiFileRelationFile " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationFile where {1} and FileId not in (Select top {2} FileId from UiFileRelationFile where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationFile where {1} and FileId not in (Select top {3} FileId from UiFileRelationFile where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUiFileRelationFileEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA:GetObjLst)", objException.Message));
}
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = TransNullToInt(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = TransNullToInt(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = TransNullToBool(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUiFileRelationFileDA: GetObjLst)", objException.Message));
}
objUiFileRelationFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUiFileRelationFileEN);
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
public List<clsUiFileRelationFileEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA:GetObjLstByTabName)", objException.Message));
}
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = TransNullToInt(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = TransNullToInt(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = TransNullToBool(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUiFileRelationFileDA: GetObjLst)", objException.Message));
}
objUiFileRelationFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUiFileRelationFileEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUiFileRelationFile(ref clsUiFileRelationFileEN objUiFileRelationFileEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where FileId = " + ""+ objUiFileRelationFileEN.FileId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUiFileRelationFileEN.FileId = TransNullToInt(objDT.Rows[0][conUiFileRelationFile.FileId].ToString().Trim()); //FileId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationFileEN.TaskId = TransNullToInt(objDT.Rows[0][conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationFileEN.FilePath = objDT.Rows[0][conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath(字段类型:nvarchar,字段长度:1000,是否可空:False)
 objUiFileRelationFileEN.RelativePath = objDT.Rows[0][conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath(字段类型:nvarchar,字段长度:1000,是否可空:True)
 objUiFileRelationFileEN.FileName = objDT.Rows[0][conUiFileRelationFile.FileName].ToString().Trim(); //FileName(字段类型:nvarchar,字段长度:400,是否可空:False)
 objUiFileRelationFileEN.Extension = objDT.Rows[0][conUiFileRelationFile.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:20,是否可空:True)
 objUiFileRelationFileEN.FileKind = objDT.Rows[0][conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind(字段类型:varchar,字段长度:20,是否可空:False)
 objUiFileRelationFileEN.FileHash = objDT.Rows[0][conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash(字段类型:varchar,字段长度:64,是否可空:True)
 objUiFileRelationFileEN.IsEntry = TransNullToBool(objDT.Rows[0][conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry(字段类型:bit,字段长度:1,是否可空:False)
 objUiFileRelationFileEN.ParseStatus = objDT.Rows[0][conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus(字段类型:varchar,字段长度:20,是否可空:False)
 objUiFileRelationFileEN.ParseMsg = objDT.Rows[0][conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg(字段类型:ntext,字段长度:2147483646,是否可空:True)
 objUiFileRelationFileEN.CreatedAt = TransNullToDate(objDT.Rows[0][conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUiFileRelationFileDA: GetUiFileRelationFile)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngFileId">表关键字</param>
 /// <returns>表对象</returns>
public clsUiFileRelationFileEN GetObjByFileId(long lngFileId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where FileId = " + ""+ lngFileId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
 objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath(字段类型:nvarchar,字段长度:1000,是否可空:False)
 objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath(字段类型:nvarchar,字段长度:1000,是否可空:True)
 objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName(字段类型:nvarchar,字段长度:400,是否可空:False)
 objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:20,是否可空:True)
 objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind(字段类型:varchar,字段长度:20,是否可空:False)
 objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash(字段类型:varchar,字段长度:64,是否可空:True)
 objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry(字段类型:bit,字段长度:1,是否可空:False)
 objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus(字段类型:varchar,字段长度:20,是否可空:False)
 objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg(字段类型:ntext,字段长度:2147483646,是否可空:True)
 objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUiFileRelationFileDA: GetObjByFileId)", objException.Message));
}
return objUiFileRelationFileEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUiFileRelationFileEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN()
{
FileId = TransNullToInt(objRow[conUiFileRelationFile.FileId].ToString().Trim()), //FileId
TaskId = TransNullToInt(objRow[conUiFileRelationFile.TaskId].ToString().Trim()), //TaskId
FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(), //FilePath
RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(), //RelativePath
FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(), //FileName
Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(), //扩展名
FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(), //FileKind
FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(), //FileHash
IsEntry = TransNullToBool(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()), //IsEntry
ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(), //ParseStatus
ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(), //ParseMsg
CreatedAt = TransNullToDate(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()) //CreatedAt
};
objUiFileRelationFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUiFileRelationFileEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUiFileRelationFileDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUiFileRelationFileEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = TransNullToInt(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = TransNullToInt(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = TransNullToBool(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUiFileRelationFileDA: GetObjByDataRowUiFileRelationFile)", objException.Message));
}
objUiFileRelationFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUiFileRelationFileEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUiFileRelationFileEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = TransNullToInt(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = TransNullToInt(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = TransNullToBool(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUiFileRelationFileDA: GetObjByDataRow)", objException.Message));
}
objUiFileRelationFileEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUiFileRelationFileEN;
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
objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUiFileRelationFileEN._CurrTabName, conUiFileRelationFile.FileId, 8, "");
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
objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUiFileRelationFileEN._CurrTabName, conUiFileRelationFile.FileId, 8, strPrefix);
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
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FileId from UiFileRelationFile where " + strCondition;
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
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FileId from UiFileRelationFile where " + strCondition;
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
 /// <param name = "lngFileId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngFileId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UiFileRelationFile", "FileId = " + ""+ lngFileId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UiFileRelationFile", strCondition))
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
objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UiFileRelationFile");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUiFileRelationFileEN objUiFileRelationFileEN)
 {
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationFileEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UiFileRelationFile");
objRow = objDS.Tables["UiFileRelationFile"].NewRow();
objRow[conUiFileRelationFile.TaskId] = objUiFileRelationFileEN.TaskId; //TaskId
objRow[conUiFileRelationFile.FilePath] = objUiFileRelationFileEN.FilePath; //FilePath
 if (objUiFileRelationFileEN.RelativePath !=  "")
 {
objRow[conUiFileRelationFile.RelativePath] = objUiFileRelationFileEN.RelativePath; //RelativePath
 }
objRow[conUiFileRelationFile.FileName] = objUiFileRelationFileEN.FileName; //FileName
 if (objUiFileRelationFileEN.Extension !=  "")
 {
objRow[conUiFileRelationFile.Extension] = objUiFileRelationFileEN.Extension; //扩展名
 }
objRow[conUiFileRelationFile.FileKind] = objUiFileRelationFileEN.FileKind; //FileKind
 if (objUiFileRelationFileEN.FileHash !=  "")
 {
objRow[conUiFileRelationFile.FileHash] = objUiFileRelationFileEN.FileHash; //FileHash
 }
objRow[conUiFileRelationFile.IsEntry] = objUiFileRelationFileEN.IsEntry; //IsEntry
objRow[conUiFileRelationFile.ParseStatus] = objUiFileRelationFileEN.ParseStatus; //ParseStatus
 if (objUiFileRelationFileEN.ParseMsg !=  "")
 {
objRow[conUiFileRelationFile.ParseMsg] = objUiFileRelationFileEN.ParseMsg; //ParseMsg
 }
objRow[conUiFileRelationFile.CreatedAt] = objUiFileRelationFileEN.CreatedAt; //CreatedAt
objDS.Tables[clsUiFileRelationFileEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUiFileRelationFileEN._CurrTabName);
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
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationFileEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUiFileRelationFile.TaskId);
 arrValueListForInsert.Add(objUiFileRelationFileEN.TaskId.ToString());
 
 if (objUiFileRelationFileEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FilePath);
 var strFilePath = objUiFileRelationFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objUiFileRelationFileEN.RelativePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.RelativePath);
 var strRelativePath = objUiFileRelationFileEN.RelativePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelativePath + "'");
 }
 
 if (objUiFileRelationFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileName);
 var strFileName = objUiFileRelationFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objUiFileRelationFileEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.Extension);
 var strExtension = objUiFileRelationFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objUiFileRelationFileEN.FileKind !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileKind);
 var strFileKind = objUiFileRelationFileEN.FileKind.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileKind + "'");
 }
 
 if (objUiFileRelationFileEN.FileHash !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileHash);
 var strFileHash = objUiFileRelationFileEN.FileHash.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileHash + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationFile.IsEntry);
 arrValueListForInsert.Add("'" + (objUiFileRelationFileEN.IsEntry  ==  false ? "0" : "1") + "'");
 
 if (objUiFileRelationFileEN.ParseStatus !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.ParseStatus);
 var strParseStatus = objUiFileRelationFileEN.ParseStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParseStatus + "'");
 }
 
 if (objUiFileRelationFileEN.ParseMsg !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.ParseMsg);
 var strParseMsg = objUiFileRelationFileEN.ParseMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParseMsg + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationFile.CreatedAt);
 var dteCreatedAt = objUiFileRelationFileEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationFile");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationFileEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUiFileRelationFile.TaskId);
 arrValueListForInsert.Add(objUiFileRelationFileEN.TaskId.ToString());
 
 if (objUiFileRelationFileEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FilePath);
 var strFilePath = objUiFileRelationFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objUiFileRelationFileEN.RelativePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.RelativePath);
 var strRelativePath = objUiFileRelationFileEN.RelativePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelativePath + "'");
 }
 
 if (objUiFileRelationFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileName);
 var strFileName = objUiFileRelationFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objUiFileRelationFileEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.Extension);
 var strExtension = objUiFileRelationFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objUiFileRelationFileEN.FileKind !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileKind);
 var strFileKind = objUiFileRelationFileEN.FileKind.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileKind + "'");
 }
 
 if (objUiFileRelationFileEN.FileHash !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileHash);
 var strFileHash = objUiFileRelationFileEN.FileHash.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileHash + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationFile.IsEntry);
 arrValueListForInsert.Add("'" + (objUiFileRelationFileEN.IsEntry  ==  false ? "0" : "1") + "'");
 
 if (objUiFileRelationFileEN.ParseStatus !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.ParseStatus);
 var strParseStatus = objUiFileRelationFileEN.ParseStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParseStatus + "'");
 }
 
 if (objUiFileRelationFileEN.ParseMsg !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.ParseMsg);
 var strParseMsg = objUiFileRelationFileEN.ParseMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParseMsg + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationFile.CreatedAt);
 var dteCreatedAt = objUiFileRelationFileEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationFile");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUiFileRelationFileEN objUiFileRelationFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationFileEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUiFileRelationFile.TaskId);
 arrValueListForInsert.Add(objUiFileRelationFileEN.TaskId.ToString());
 
 if (objUiFileRelationFileEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FilePath);
 var strFilePath = objUiFileRelationFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objUiFileRelationFileEN.RelativePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.RelativePath);
 var strRelativePath = objUiFileRelationFileEN.RelativePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelativePath + "'");
 }
 
 if (objUiFileRelationFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileName);
 var strFileName = objUiFileRelationFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objUiFileRelationFileEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.Extension);
 var strExtension = objUiFileRelationFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objUiFileRelationFileEN.FileKind !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileKind);
 var strFileKind = objUiFileRelationFileEN.FileKind.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileKind + "'");
 }
 
 if (objUiFileRelationFileEN.FileHash !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileHash);
 var strFileHash = objUiFileRelationFileEN.FileHash.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileHash + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationFile.IsEntry);
 arrValueListForInsert.Add("'" + (objUiFileRelationFileEN.IsEntry  ==  false ? "0" : "1") + "'");
 
 if (objUiFileRelationFileEN.ParseStatus !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.ParseStatus);
 var strParseStatus = objUiFileRelationFileEN.ParseStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParseStatus + "'");
 }
 
 if (objUiFileRelationFileEN.ParseMsg !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.ParseMsg);
 var strParseMsg = objUiFileRelationFileEN.ParseMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParseMsg + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationFile.CreatedAt);
 var dteCreatedAt = objUiFileRelationFileEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationFile");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUiFileRelationFileEN objUiFileRelationFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationFileEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUiFileRelationFile.TaskId);
 arrValueListForInsert.Add(objUiFileRelationFileEN.TaskId.ToString());
 
 if (objUiFileRelationFileEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FilePath);
 var strFilePath = objUiFileRelationFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objUiFileRelationFileEN.RelativePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.RelativePath);
 var strRelativePath = objUiFileRelationFileEN.RelativePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelativePath + "'");
 }
 
 if (objUiFileRelationFileEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileName);
 var strFileName = objUiFileRelationFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objUiFileRelationFileEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.Extension);
 var strExtension = objUiFileRelationFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objUiFileRelationFileEN.FileKind !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileKind);
 var strFileKind = objUiFileRelationFileEN.FileKind.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileKind + "'");
 }
 
 if (objUiFileRelationFileEN.FileHash !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.FileHash);
 var strFileHash = objUiFileRelationFileEN.FileHash.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileHash + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationFile.IsEntry);
 arrValueListForInsert.Add("'" + (objUiFileRelationFileEN.IsEntry  ==  false ? "0" : "1") + "'");
 
 if (objUiFileRelationFileEN.ParseStatus !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.ParseStatus);
 var strParseStatus = objUiFileRelationFileEN.ParseStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParseStatus + "'");
 }
 
 if (objUiFileRelationFileEN.ParseMsg !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationFile.ParseMsg);
 var strParseMsg = objUiFileRelationFileEN.ParseMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParseMsg + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationFile.CreatedAt);
 var dteCreatedAt = objUiFileRelationFileEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationFile");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUiFileRelationFiles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where FileId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UiFileRelationFile");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngFileId = TransNullToInt(oRow[conUiFileRelationFile.FileId].ToString().Trim());
if (IsExist(lngFileId))
{
 string strResult = "关键字变量值为:" + string.Format("FileId = {0}", lngFileId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUiFileRelationFileEN._CurrTabName ].NewRow();
objRow[conUiFileRelationFile.TaskId] = oRow[conUiFileRelationFile.TaskId].ToString().Trim(); //TaskId
objRow[conUiFileRelationFile.FilePath] = oRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objRow[conUiFileRelationFile.RelativePath] = oRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objRow[conUiFileRelationFile.FileName] = oRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objRow[conUiFileRelationFile.Extension] = oRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objRow[conUiFileRelationFile.FileKind] = oRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objRow[conUiFileRelationFile.FileHash] = oRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objRow[conUiFileRelationFile.IsEntry] = oRow[conUiFileRelationFile.IsEntry].ToString().Trim(); //IsEntry
objRow[conUiFileRelationFile.ParseStatus] = oRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objRow[conUiFileRelationFile.ParseMsg] = oRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objRow[conUiFileRelationFile.CreatedAt] = oRow[conUiFileRelationFile.CreatedAt].ToString().Trim(); //CreatedAt
 objDS.Tables[clsUiFileRelationFileEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUiFileRelationFileEN._CurrTabName);
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
 /// <param name = "objUiFileRelationFileEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationFileEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationFile where FileId = " + ""+ objUiFileRelationFileEN.FileId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUiFileRelationFileEN._CurrTabName);
if (objDS.Tables[clsUiFileRelationFileEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FileId = " + ""+ objUiFileRelationFileEN.FileId+"");
return false;
}
objRow = objDS.Tables[clsUiFileRelationFileEN._CurrTabName].Rows[0];
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.TaskId))
 {
objRow[conUiFileRelationFile.TaskId] = objUiFileRelationFileEN.TaskId; //TaskId
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FilePath))
 {
objRow[conUiFileRelationFile.FilePath] = objUiFileRelationFileEN.FilePath; //FilePath
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.RelativePath))
 {
objRow[conUiFileRelationFile.RelativePath] = objUiFileRelationFileEN.RelativePath; //RelativePath
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileName))
 {
objRow[conUiFileRelationFile.FileName] = objUiFileRelationFileEN.FileName; //FileName
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.Extension))
 {
objRow[conUiFileRelationFile.Extension] = objUiFileRelationFileEN.Extension; //扩展名
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileKind))
 {
objRow[conUiFileRelationFile.FileKind] = objUiFileRelationFileEN.FileKind; //FileKind
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileHash))
 {
objRow[conUiFileRelationFile.FileHash] = objUiFileRelationFileEN.FileHash; //FileHash
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.IsEntry))
 {
objRow[conUiFileRelationFile.IsEntry] = objUiFileRelationFileEN.IsEntry; //IsEntry
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseStatus))
 {
objRow[conUiFileRelationFile.ParseStatus] = objUiFileRelationFileEN.ParseStatus; //ParseStatus
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseMsg))
 {
objRow[conUiFileRelationFile.ParseMsg] = objUiFileRelationFileEN.ParseMsg; //ParseMsg
 }
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.CreatedAt))
 {
objRow[conUiFileRelationFile.CreatedAt] = objUiFileRelationFileEN.CreatedAt; //CreatedAt
 }
try
{
objDA.Update(objDS, clsUiFileRelationFileEN._CurrTabName);
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
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UiFileRelationFile Set ");
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.TaskId))
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationFileEN.TaskId, conUiFileRelationFile.TaskId); //TaskId
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FilePath))
 {
 if (objUiFileRelationFileEN.FilePath !=  null)
 {
 var strFilePath = objUiFileRelationFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conUiFileRelationFile.FilePath); //FilePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.FilePath); //FilePath
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.RelativePath))
 {
 if (objUiFileRelationFileEN.RelativePath !=  null)
 {
 var strRelativePath = objUiFileRelationFileEN.RelativePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelativePath, conUiFileRelationFile.RelativePath); //RelativePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.RelativePath); //RelativePath
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileName))
 {
 if (objUiFileRelationFileEN.FileName !=  null)
 {
 var strFileName = objUiFileRelationFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conUiFileRelationFile.FileName); //FileName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.FileName); //FileName
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.Extension))
 {
 if (objUiFileRelationFileEN.Extension !=  null)
 {
 var strExtension = objUiFileRelationFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, conUiFileRelationFile.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.Extension); //扩展名
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileKind))
 {
 if (objUiFileRelationFileEN.FileKind !=  null)
 {
 var strFileKind = objUiFileRelationFileEN.FileKind.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileKind, conUiFileRelationFile.FileKind); //FileKind
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.FileKind); //FileKind
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileHash))
 {
 if (objUiFileRelationFileEN.FileHash !=  null)
 {
 var strFileHash = objUiFileRelationFileEN.FileHash.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileHash, conUiFileRelationFile.FileHash); //FileHash
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.FileHash); //FileHash
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.IsEntry))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUiFileRelationFileEN.IsEntry == true?"1":"0", conUiFileRelationFile.IsEntry); //IsEntry
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseStatus))
 {
 if (objUiFileRelationFileEN.ParseStatus !=  null)
 {
 var strParseStatus = objUiFileRelationFileEN.ParseStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParseStatus, conUiFileRelationFile.ParseStatus); //ParseStatus
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.ParseStatus); //ParseStatus
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseMsg))
 {
 if (objUiFileRelationFileEN.ParseMsg !=  null)
 {
 var strParseMsg = objUiFileRelationFileEN.ParseMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParseMsg, conUiFileRelationFile.ParseMsg); //ParseMsg
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.ParseMsg); //ParseMsg
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.CreatedAt))
 {
 if (objUiFileRelationFileEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationFileEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conUiFileRelationFile.CreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.CreatedAt); //CreatedAt
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FileId = {0}", objUiFileRelationFileEN.FileId); 
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
 /// <param name = "objUiFileRelationFileEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUiFileRelationFileEN objUiFileRelationFileEN, string strCondition)
{
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UiFileRelationFile Set ");
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.TaskId))
 {
 sbSQL.AppendFormat(" TaskId = {0},", objUiFileRelationFileEN.TaskId); //TaskId
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FilePath))
 {
 if (objUiFileRelationFileEN.FilePath !=  null)
 {
 var strFilePath = objUiFileRelationFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //FilePath
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //FilePath
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.RelativePath))
 {
 if (objUiFileRelationFileEN.RelativePath !=  null)
 {
 var strRelativePath = objUiFileRelationFileEN.RelativePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelativePath = '{0}',", strRelativePath); //RelativePath
 }
 else
 {
 sbSQL.Append(" RelativePath = null,"); //RelativePath
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileName))
 {
 if (objUiFileRelationFileEN.FileName !=  null)
 {
 var strFileName = objUiFileRelationFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //FileName
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //FileName
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.Extension))
 {
 if (objUiFileRelationFileEN.Extension !=  null)
 {
 var strExtension = objUiFileRelationFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileKind))
 {
 if (objUiFileRelationFileEN.FileKind !=  null)
 {
 var strFileKind = objUiFileRelationFileEN.FileKind.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileKind = '{0}',", strFileKind); //FileKind
 }
 else
 {
 sbSQL.Append(" FileKind = null,"); //FileKind
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileHash))
 {
 if (objUiFileRelationFileEN.FileHash !=  null)
 {
 var strFileHash = objUiFileRelationFileEN.FileHash.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileHash = '{0}',", strFileHash); //FileHash
 }
 else
 {
 sbSQL.Append(" FileHash = null,"); //FileHash
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.IsEntry))
 {
 sbSQL.AppendFormat(" IsEntry = '{0}',", objUiFileRelationFileEN.IsEntry == true?"1":"0"); //IsEntry
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseStatus))
 {
 if (objUiFileRelationFileEN.ParseStatus !=  null)
 {
 var strParseStatus = objUiFileRelationFileEN.ParseStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParseStatus = '{0}',", strParseStatus); //ParseStatus
 }
 else
 {
 sbSQL.Append(" ParseStatus = null,"); //ParseStatus
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseMsg))
 {
 if (objUiFileRelationFileEN.ParseMsg !=  null)
 {
 var strParseMsg = objUiFileRelationFileEN.ParseMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParseMsg = '{0}',", strParseMsg); //ParseMsg
 }
 else
 {
 sbSQL.Append(" ParseMsg = null,"); //ParseMsg
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.CreatedAt))
 {
 if (objUiFileRelationFileEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationFileEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //CreatedAt
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
 /// <param name = "objUiFileRelationFileEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUiFileRelationFileEN objUiFileRelationFileEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UiFileRelationFile Set ");
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.TaskId))
 {
 sbSQL.AppendFormat(" TaskId = {0},", objUiFileRelationFileEN.TaskId); //TaskId
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FilePath))
 {
 if (objUiFileRelationFileEN.FilePath !=  null)
 {
 var strFilePath = objUiFileRelationFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //FilePath
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //FilePath
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.RelativePath))
 {
 if (objUiFileRelationFileEN.RelativePath !=  null)
 {
 var strRelativePath = objUiFileRelationFileEN.RelativePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelativePath = '{0}',", strRelativePath); //RelativePath
 }
 else
 {
 sbSQL.Append(" RelativePath = null,"); //RelativePath
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileName))
 {
 if (objUiFileRelationFileEN.FileName !=  null)
 {
 var strFileName = objUiFileRelationFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //FileName
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //FileName
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.Extension))
 {
 if (objUiFileRelationFileEN.Extension !=  null)
 {
 var strExtension = objUiFileRelationFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileKind))
 {
 if (objUiFileRelationFileEN.FileKind !=  null)
 {
 var strFileKind = objUiFileRelationFileEN.FileKind.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileKind = '{0}',", strFileKind); //FileKind
 }
 else
 {
 sbSQL.Append(" FileKind = null,"); //FileKind
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileHash))
 {
 if (objUiFileRelationFileEN.FileHash !=  null)
 {
 var strFileHash = objUiFileRelationFileEN.FileHash.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileHash = '{0}',", strFileHash); //FileHash
 }
 else
 {
 sbSQL.Append(" FileHash = null,"); //FileHash
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.IsEntry))
 {
 sbSQL.AppendFormat(" IsEntry = '{0}',", objUiFileRelationFileEN.IsEntry == true?"1":"0"); //IsEntry
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseStatus))
 {
 if (objUiFileRelationFileEN.ParseStatus !=  null)
 {
 var strParseStatus = objUiFileRelationFileEN.ParseStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParseStatus = '{0}',", strParseStatus); //ParseStatus
 }
 else
 {
 sbSQL.Append(" ParseStatus = null,"); //ParseStatus
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseMsg))
 {
 if (objUiFileRelationFileEN.ParseMsg !=  null)
 {
 var strParseMsg = objUiFileRelationFileEN.ParseMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParseMsg = '{0}',", strParseMsg); //ParseMsg
 }
 else
 {
 sbSQL.Append(" ParseMsg = null,"); //ParseMsg
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.CreatedAt))
 {
 if (objUiFileRelationFileEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationFileEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //CreatedAt
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
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUiFileRelationFileEN objUiFileRelationFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUiFileRelationFileEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationFileEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UiFileRelationFile Set ");
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.TaskId))
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationFileEN.TaskId, conUiFileRelationFile.TaskId); //TaskId
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FilePath))
 {
 if (objUiFileRelationFileEN.FilePath !=  null)
 {
 var strFilePath = objUiFileRelationFileEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conUiFileRelationFile.FilePath); //FilePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.FilePath); //FilePath
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.RelativePath))
 {
 if (objUiFileRelationFileEN.RelativePath !=  null)
 {
 var strRelativePath = objUiFileRelationFileEN.RelativePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelativePath, conUiFileRelationFile.RelativePath); //RelativePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.RelativePath); //RelativePath
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileName))
 {
 if (objUiFileRelationFileEN.FileName !=  null)
 {
 var strFileName = objUiFileRelationFileEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conUiFileRelationFile.FileName); //FileName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.FileName); //FileName
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.Extension))
 {
 if (objUiFileRelationFileEN.Extension !=  null)
 {
 var strExtension = objUiFileRelationFileEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, conUiFileRelationFile.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.Extension); //扩展名
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileKind))
 {
 if (objUiFileRelationFileEN.FileKind !=  null)
 {
 var strFileKind = objUiFileRelationFileEN.FileKind.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileKind, conUiFileRelationFile.FileKind); //FileKind
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.FileKind); //FileKind
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.FileHash))
 {
 if (objUiFileRelationFileEN.FileHash !=  null)
 {
 var strFileHash = objUiFileRelationFileEN.FileHash.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileHash, conUiFileRelationFile.FileHash); //FileHash
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.FileHash); //FileHash
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.IsEntry))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUiFileRelationFileEN.IsEntry == true?"1":"0", conUiFileRelationFile.IsEntry); //IsEntry
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseStatus))
 {
 if (objUiFileRelationFileEN.ParseStatus !=  null)
 {
 var strParseStatus = objUiFileRelationFileEN.ParseStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParseStatus, conUiFileRelationFile.ParseStatus); //ParseStatus
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.ParseStatus); //ParseStatus
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.ParseMsg))
 {
 if (objUiFileRelationFileEN.ParseMsg !=  null)
 {
 var strParseMsg = objUiFileRelationFileEN.ParseMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParseMsg, conUiFileRelationFile.ParseMsg); //ParseMsg
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.ParseMsg); //ParseMsg
 }
 }
 
 if (objUiFileRelationFileEN.IsUpdated(conUiFileRelationFile.CreatedAt))
 {
 if (objUiFileRelationFileEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationFileEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conUiFileRelationFile.CreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationFile.CreatedAt); //CreatedAt
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FileId = {0}", objUiFileRelationFileEN.FileId); 
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
 /// <param name = "lngFileId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngFileId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngFileId,
};
 objSQL.ExecSP("UiFileRelationFile_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngFileId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngFileId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
//删除UiFileRelationFile本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UiFileRelationFile where FileId = " + ""+ lngFileId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUiFileRelationFile(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
//删除UiFileRelationFile本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UiFileRelationFile where FileId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngFileId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngFileId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
//删除UiFileRelationFile本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UiFileRelationFile where FileId = " + ""+ lngFileId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUiFileRelationFile(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: DelUiFileRelationFile)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UiFileRelationFile where " + strCondition ;
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
public bool DelUiFileRelationFileWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUiFileRelationFileDA: DelUiFileRelationFileWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UiFileRelationFile where " + strCondition ;
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
 /// <param name = "objUiFileRelationFileENS">源对象</param>
 /// <param name = "objUiFileRelationFileENT">目标对象</param>
public void CopyTo(clsUiFileRelationFileEN objUiFileRelationFileENS, clsUiFileRelationFileEN objUiFileRelationFileENT)
{
objUiFileRelationFileENT.FileId = objUiFileRelationFileENS.FileId; //FileId
objUiFileRelationFileENT.TaskId = objUiFileRelationFileENS.TaskId; //TaskId
objUiFileRelationFileENT.FilePath = objUiFileRelationFileENS.FilePath; //FilePath
objUiFileRelationFileENT.RelativePath = objUiFileRelationFileENS.RelativePath; //RelativePath
objUiFileRelationFileENT.FileName = objUiFileRelationFileENS.FileName; //FileName
objUiFileRelationFileENT.Extension = objUiFileRelationFileENS.Extension; //扩展名
objUiFileRelationFileENT.FileKind = objUiFileRelationFileENS.FileKind; //FileKind
objUiFileRelationFileENT.FileHash = objUiFileRelationFileENS.FileHash; //FileHash
objUiFileRelationFileENT.IsEntry = objUiFileRelationFileENS.IsEntry; //IsEntry
objUiFileRelationFileENT.ParseStatus = objUiFileRelationFileENS.ParseStatus; //ParseStatus
objUiFileRelationFileENT.ParseMsg = objUiFileRelationFileENS.ParseMsg; //ParseMsg
objUiFileRelationFileENT.CreatedAt = objUiFileRelationFileENS.CreatedAt; //CreatedAt
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUiFileRelationFileEN.TaskId, conUiFileRelationFile.TaskId);
clsCheckSql.CheckFieldNotNull(objUiFileRelationFileEN.FilePath, conUiFileRelationFile.FilePath);
clsCheckSql.CheckFieldNotNull(objUiFileRelationFileEN.FileName, conUiFileRelationFile.FileName);
clsCheckSql.CheckFieldNotNull(objUiFileRelationFileEN.FileKind, conUiFileRelationFile.FileKind);
clsCheckSql.CheckFieldNotNull(objUiFileRelationFileEN.IsEntry, conUiFileRelationFile.IsEntry);
clsCheckSql.CheckFieldNotNull(objUiFileRelationFileEN.ParseStatus, conUiFileRelationFile.ParseStatus);
clsCheckSql.CheckFieldNotNull(objUiFileRelationFileEN.CreatedAt, conUiFileRelationFile.CreatedAt);
//检查字段长度
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FilePath, 1000, conUiFileRelationFile.FilePath);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.RelativePath, 1000, conUiFileRelationFile.RelativePath);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FileName, 400, conUiFileRelationFile.FileName);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.Extension, 20, conUiFileRelationFile.Extension);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FileKind, 20, conUiFileRelationFile.FileKind);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FileHash, 64, conUiFileRelationFile.FileHash);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.ParseStatus, 20, conUiFileRelationFile.ParseStatus);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.ParseMsg, 2147483646, conUiFileRelationFile.ParseMsg);
//检查字段外键固定长度
 objUiFileRelationFileEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FilePath, 1000, conUiFileRelationFile.FilePath);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.RelativePath, 1000, conUiFileRelationFile.RelativePath);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FileName, 400, conUiFileRelationFile.FileName);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.Extension, 20, conUiFileRelationFile.Extension);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FileKind, 20, conUiFileRelationFile.FileKind);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FileHash, 64, conUiFileRelationFile.FileHash);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.ParseStatus, 20, conUiFileRelationFile.ParseStatus);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.ParseMsg, 2147483646, conUiFileRelationFile.ParseMsg);
//检查外键字段长度
 objUiFileRelationFileEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FilePath, 1000, conUiFileRelationFile.FilePath);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.RelativePath, 1000, conUiFileRelationFile.RelativePath);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FileName, 400, conUiFileRelationFile.FileName);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.Extension, 20, conUiFileRelationFile.Extension);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FileKind, 20, conUiFileRelationFile.FileKind);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.FileHash, 64, conUiFileRelationFile.FileHash);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.ParseStatus, 20, conUiFileRelationFile.ParseStatus);
clsCheckSql.CheckFieldLen(objUiFileRelationFileEN.ParseMsg, 2147483646, conUiFileRelationFile.ParseMsg);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationFileEN.FilePath, conUiFileRelationFile.FilePath);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationFileEN.RelativePath, conUiFileRelationFile.RelativePath);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationFileEN.FileName, conUiFileRelationFile.FileName);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationFileEN.Extension, conUiFileRelationFile.Extension);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationFileEN.FileKind, conUiFileRelationFile.FileKind);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationFileEN.FileHash, conUiFileRelationFile.FileHash);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationFileEN.ParseStatus, conUiFileRelationFile.ParseStatus);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationFileEN.ParseMsg, conUiFileRelationFile.ParseMsg);
//检查外键字段长度
 objUiFileRelationFileEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UiFileRelationFile(UiFileRelationFile),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objUiFileRelationFileEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objUiFileRelationFileEN.FilePath);
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
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUiFileRelationFileEN._CurrTabName);
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
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUiFileRelationFileEN._CurrTabName, strCondition);
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
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
 objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}