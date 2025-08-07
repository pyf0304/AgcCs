
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsApplicationTypeDA
 表名:ApplicationType(00050127)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 应用程序类型(ApplicationType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsApplicationTypeDA : clsCommBase4DA
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
 return clsApplicationTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsApplicationTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsApplicationTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsApplicationTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsApplicationTypeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ApplicationType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsApplicationTypeDA: GetDataTable_ApplicationType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsApplicationTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsApplicationTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ApplicationType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ApplicationType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsApplicationTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ApplicationType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsApplicationTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ApplicationType.* " + 
$"from ApplicationType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ApplicationType.ApplicationTypeId not in " + 
$"(Select top {intTop_In} ApplicationType.ApplicationTypeId from ApplicationType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ApplicationType where {1} and ApplicationTypeId not in (Select top {2} ApplicationTypeId from ApplicationType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ApplicationType where {1} and ApplicationTypeId not in (Select top {3} ApplicationTypeId from ApplicationType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsApplicationTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ApplicationType.* " + 
$"from ApplicationType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ApplicationType.ApplicationTypeId not in " + 
$"(Select top {intTop_In} ApplicationType.ApplicationTypeId from ApplicationType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ApplicationType where {1} and ApplicationTypeId not in (Select top {2} ApplicationTypeId from ApplicationType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ApplicationType where {1} and ApplicationTypeId not in (Select top {3} ApplicationTypeId from ApplicationType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsApplicationTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsApplicationTypeDA:GetObjLst)", objException.Message));
}
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = TransNullToBool(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = TransNullToInt(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsApplicationTypeDA: GetObjLst)", objException.Message));
}
objApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objApplicationTypeEN);
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
public List<clsApplicationTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsApplicationTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = TransNullToBool(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = TransNullToInt(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsApplicationTypeDA: GetObjLst)", objException.Message));
}
objApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objApplicationTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetApplicationType(ref clsApplicationTypeEN objApplicationTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where ApplicationTypeId = " + ""+ objApplicationTypeEN.ApplicationTypeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objApplicationTypeEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objApplicationTypeEN.ApplicationTypeName = objDT.Rows[0][conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objApplicationTypeEN.ApplicationTypeSimName = objDT.Rows[0][conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objApplicationTypeEN.ApplicationTypeENName = objDT.Rows[0][conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objApplicationTypeEN.ProgLangTypeId = objDT.Rows[0][conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objApplicationTypeEN.ProgLangTypeId2 = objDT.Rows[0][conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2(字段类型:char,字段长度:2,是否可空:True)
 objApplicationTypeEN.ProgLangTypeId3 = objDT.Rows[0][conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3(字段类型:char,字段长度:2,是否可空:True)
 objApplicationTypeEN.ProgLangTypeId4 = objDT.Rows[0][conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4(字段类型:char,字段长度:2,是否可空:True)
 objApplicationTypeEN.ProgLangTypeId5 = objDT.Rows[0][conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5(字段类型:char,字段长度:2,是否可空:True)
 objApplicationTypeEN.IsVisible = TransNullToBool(objDT.Rows[0][conApplicationType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objApplicationTypeEN.VisitedNum = TransNullToInt(objDT.Rows[0][conApplicationType.VisitedNum].ToString().Trim()); //访问数(字段类型:int,字段长度:4,是否可空:True)
 objApplicationTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conApplicationType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objApplicationTypeEN.Memo = objDT.Rows[0][conApplicationType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsApplicationTypeDA: GetApplicationType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsApplicationTypeEN GetObjByApplicationTypeId(int intApplicationTypeId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where ApplicationTypeId = " + ""+ intApplicationTypeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
 objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2(字段类型:char,字段长度:2,是否可空:True)
 objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3(字段类型:char,字段长度:2,是否可空:True)
 objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4(字段类型:char,字段长度:2,是否可空:True)
 objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5(字段类型:char,字段长度:2,是否可空:True)
 objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数(字段类型:int,字段长度:4,是否可空:True)
 objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsApplicationTypeDA: GetObjByApplicationTypeId)", objException.Message));
}
return objApplicationTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsApplicationTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsApplicationTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN()
{
ApplicationTypeId = TransNullToInt(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(), //编程语言类型Id2
ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(), //编程语言类型Id3
ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(), //编程语言类型Id4
ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(), //编程语言类型Id5
IsVisible = TransNullToBool(objRow[conApplicationType.IsVisible].ToString().Trim()), //是否显示
VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conApplicationType.VisitedNum].ToString().Trim()), //访问数
OrderNum = TransNullToInt(objRow[conApplicationType.OrderNum].ToString().Trim()), //序号
Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim() //说明
};
objApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objApplicationTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsApplicationTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsApplicationTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = TransNullToBool(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = TransNullToInt(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsApplicationTypeDA: GetObjByDataRowApplicationType)", objException.Message));
}
objApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objApplicationTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsApplicationTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = TransNullToInt(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = TransNullToBool(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = TransNullToInt(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsApplicationTypeDA: GetObjByDataRow)", objException.Message));
}
objApplicationTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objApplicationTypeEN;
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
objSQL = clsApplicationTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsApplicationTypeEN._CurrTabName, conApplicationType.ApplicationTypeId, 4, "");
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
objSQL = clsApplicationTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsApplicationTypeEN._CurrTabName, conApplicationType.ApplicationTypeId, 4, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public int GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ApplicationTypeId from ApplicationType where " + strCondition;
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
return int.Parse(strKeyValue);
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
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ApplicationTypeId from ApplicationType where " + strCondition;
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
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intApplicationTypeId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ApplicationType", "ApplicationTypeId = " + ""+ intApplicationTypeId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsApplicationTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ApplicationType", strCondition))
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
objSQL = clsApplicationTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ApplicationType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsApplicationTypeEN objApplicationTypeEN)
 {
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objApplicationTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ApplicationType");
objRow = objDS.Tables["ApplicationType"].NewRow();
objRow[conApplicationType.ApplicationTypeName] = objApplicationTypeEN.ApplicationTypeName; //应用程序类型名称
 if (objApplicationTypeEN.ApplicationTypeSimName !=  "")
 {
objRow[conApplicationType.ApplicationTypeSimName] = objApplicationTypeEN.ApplicationTypeSimName; //应用程序类型简称
 }
objRow[conApplicationType.ApplicationTypeENName] = objApplicationTypeEN.ApplicationTypeENName; //应用类型英文名
 if (objApplicationTypeEN.ProgLangTypeId !=  "")
 {
objRow[conApplicationType.ProgLangTypeId] = objApplicationTypeEN.ProgLangTypeId; //编程语言类型Id
 }
 if (objApplicationTypeEN.ProgLangTypeId2 !=  "")
 {
objRow[conApplicationType.ProgLangTypeId2] = objApplicationTypeEN.ProgLangTypeId2; //编程语言类型Id2
 }
 if (objApplicationTypeEN.ProgLangTypeId3 !=  "")
 {
objRow[conApplicationType.ProgLangTypeId3] = objApplicationTypeEN.ProgLangTypeId3; //编程语言类型Id3
 }
 if (objApplicationTypeEN.ProgLangTypeId4 !=  "")
 {
objRow[conApplicationType.ProgLangTypeId4] = objApplicationTypeEN.ProgLangTypeId4; //编程语言类型Id4
 }
 if (objApplicationTypeEN.ProgLangTypeId5 !=  "")
 {
objRow[conApplicationType.ProgLangTypeId5] = objApplicationTypeEN.ProgLangTypeId5; //编程语言类型Id5
 }
objRow[conApplicationType.IsVisible] = objApplicationTypeEN.IsVisible; //是否显示
objRow[conApplicationType.VisitedNum] = objApplicationTypeEN.VisitedNum; //访问数
objRow[conApplicationType.OrderNum] = objApplicationTypeEN.OrderNum; //序号
 if (objApplicationTypeEN.Memo !=  "")
 {
objRow[conApplicationType.Memo] = objApplicationTypeEN.Memo; //说明
 }
objDS.Tables[clsApplicationTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsApplicationTypeEN._CurrTabName);
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
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsApplicationTypeEN objApplicationTypeEN)
{
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objApplicationTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objApplicationTypeEN.ApplicationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeName);
 var strApplicationTypeName = objApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeName + "'");
 }
 
 if (objApplicationTypeEN.ApplicationTypeSimName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeSimName);
 var strApplicationTypeSimName = objApplicationTypeEN.ApplicationTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeSimName + "'");
 }
 
 if (objApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeENName);
 var strApplicationTypeENName = objApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeENName + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId);
 var strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId2);
 var strProgLangTypeId2 = objApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId2 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId3);
 var strProgLangTypeId3 = objApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId3 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId4);
 var strProgLangTypeId4 = objApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId4 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId5);
 var strProgLangTypeId5 = objApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId5 + "'");
 }
 
 arrFieldListForInsert.Add(conApplicationType.IsVisible);
 arrValueListForInsert.Add("'" + (objApplicationTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objApplicationTypeEN.VisitedNum !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.VisitedNum);
 arrValueListForInsert.Add(objApplicationTypeEN.VisitedNum.ToString());
 }
 
 arrFieldListForInsert.Add(conApplicationType.OrderNum);
 arrValueListForInsert.Add(objApplicationTypeEN.OrderNum.ToString());
 
 if (objApplicationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.Memo);
 var strMemo = objApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ApplicationType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsApplicationTypeEN objApplicationTypeEN)
{
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objApplicationTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objApplicationTypeEN.ApplicationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeName);
 var strApplicationTypeName = objApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeName + "'");
 }
 
 if (objApplicationTypeEN.ApplicationTypeSimName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeSimName);
 var strApplicationTypeSimName = objApplicationTypeEN.ApplicationTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeSimName + "'");
 }
 
 if (objApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeENName);
 var strApplicationTypeENName = objApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeENName + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId);
 var strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId2);
 var strProgLangTypeId2 = objApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId2 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId3);
 var strProgLangTypeId3 = objApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId3 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId4);
 var strProgLangTypeId4 = objApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId4 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId5);
 var strProgLangTypeId5 = objApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId5 + "'");
 }
 
 arrFieldListForInsert.Add(conApplicationType.IsVisible);
 arrValueListForInsert.Add("'" + (objApplicationTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objApplicationTypeEN.VisitedNum !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.VisitedNum);
 arrValueListForInsert.Add(objApplicationTypeEN.VisitedNum.ToString());
 }
 
 arrFieldListForInsert.Add(conApplicationType.OrderNum);
 arrValueListForInsert.Add(objApplicationTypeEN.OrderNum.ToString());
 
 if (objApplicationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.Memo);
 var strMemo = objApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ApplicationType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsApplicationTypeEN objApplicationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objApplicationTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objApplicationTypeEN.ApplicationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeName);
 var strApplicationTypeName = objApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeName + "'");
 }
 
 if (objApplicationTypeEN.ApplicationTypeSimName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeSimName);
 var strApplicationTypeSimName = objApplicationTypeEN.ApplicationTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeSimName + "'");
 }
 
 if (objApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeENName);
 var strApplicationTypeENName = objApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeENName + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId);
 var strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId2);
 var strProgLangTypeId2 = objApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId2 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId3);
 var strProgLangTypeId3 = objApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId3 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId4);
 var strProgLangTypeId4 = objApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId4 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId5);
 var strProgLangTypeId5 = objApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId5 + "'");
 }
 
 arrFieldListForInsert.Add(conApplicationType.IsVisible);
 arrValueListForInsert.Add("'" + (objApplicationTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objApplicationTypeEN.VisitedNum !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.VisitedNum);
 arrValueListForInsert.Add(objApplicationTypeEN.VisitedNum.ToString());
 }
 
 arrFieldListForInsert.Add(conApplicationType.OrderNum);
 arrValueListForInsert.Add(objApplicationTypeEN.OrderNum.ToString());
 
 if (objApplicationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.Memo);
 var strMemo = objApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ApplicationType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsApplicationTypeEN objApplicationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objApplicationTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objApplicationTypeEN.ApplicationTypeName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeName);
 var strApplicationTypeName = objApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeName + "'");
 }
 
 if (objApplicationTypeEN.ApplicationTypeSimName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeSimName);
 var strApplicationTypeSimName = objApplicationTypeEN.ApplicationTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeSimName + "'");
 }
 
 if (objApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ApplicationTypeENName);
 var strApplicationTypeENName = objApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strApplicationTypeENName + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId);
 var strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId2);
 var strProgLangTypeId2 = objApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId2 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId3);
 var strProgLangTypeId3 = objApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId3 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId4);
 var strProgLangTypeId4 = objApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId4 + "'");
 }
 
 if (objApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.ProgLangTypeId5);
 var strProgLangTypeId5 = objApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId5 + "'");
 }
 
 arrFieldListForInsert.Add(conApplicationType.IsVisible);
 arrValueListForInsert.Add("'" + (objApplicationTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objApplicationTypeEN.VisitedNum !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.VisitedNum);
 arrValueListForInsert.Add(objApplicationTypeEN.VisitedNum.ToString());
 }
 
 arrFieldListForInsert.Add(conApplicationType.OrderNum);
 arrValueListForInsert.Add(objApplicationTypeEN.OrderNum.ToString());
 
 if (objApplicationTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conApplicationType.Memo);
 var strMemo = objApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ApplicationType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewApplicationTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where ApplicationTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ApplicationType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
int intApplicationTypeId = TransNullToInt(oRow[conApplicationType.ApplicationTypeId].ToString().Trim());
if (IsExist(intApplicationTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("ApplicationTypeId = {0}", intApplicationTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsApplicationTypeEN._CurrTabName ].NewRow();
objRow[conApplicationType.ApplicationTypeName] = oRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objRow[conApplicationType.ApplicationTypeSimName] = oRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objRow[conApplicationType.ApplicationTypeENName] = oRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objRow[conApplicationType.ProgLangTypeId] = oRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objRow[conApplicationType.ProgLangTypeId2] = oRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objRow[conApplicationType.ProgLangTypeId3] = oRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objRow[conApplicationType.ProgLangTypeId4] = oRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objRow[conApplicationType.ProgLangTypeId5] = oRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objRow[conApplicationType.IsVisible] = oRow[conApplicationType.IsVisible].ToString().Trim(); //是否显示
objRow[conApplicationType.VisitedNum] = oRow[conApplicationType.VisitedNum].ToString().Trim(); //访问数
objRow[conApplicationType.OrderNum] = oRow[conApplicationType.OrderNum].ToString().Trim(); //序号
objRow[conApplicationType.Memo] = oRow[conApplicationType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsApplicationTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsApplicationTypeEN._CurrTabName);
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
 /// <param name = "objApplicationTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsApplicationTypeEN objApplicationTypeEN)
{
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objApplicationTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
strSQL = "Select * from ApplicationType where ApplicationTypeId = " + ""+ objApplicationTypeEN.ApplicationTypeId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsApplicationTypeEN._CurrTabName);
if (objDS.Tables[clsApplicationTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ApplicationTypeId = " + ""+ objApplicationTypeEN.ApplicationTypeId+"");
return false;
}
objRow = objDS.Tables[clsApplicationTypeEN._CurrTabName].Rows[0];
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeName))
 {
objRow[conApplicationType.ApplicationTypeName] = objApplicationTypeEN.ApplicationTypeName; //应用程序类型名称
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeSimName))
 {
objRow[conApplicationType.ApplicationTypeSimName] = objApplicationTypeEN.ApplicationTypeSimName; //应用程序类型简称
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeENName))
 {
objRow[conApplicationType.ApplicationTypeENName] = objApplicationTypeEN.ApplicationTypeENName; //应用类型英文名
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId))
 {
objRow[conApplicationType.ProgLangTypeId] = objApplicationTypeEN.ProgLangTypeId; //编程语言类型Id
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId2))
 {
objRow[conApplicationType.ProgLangTypeId2] = objApplicationTypeEN.ProgLangTypeId2; //编程语言类型Id2
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId3))
 {
objRow[conApplicationType.ProgLangTypeId3] = objApplicationTypeEN.ProgLangTypeId3; //编程语言类型Id3
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId4))
 {
objRow[conApplicationType.ProgLangTypeId4] = objApplicationTypeEN.ProgLangTypeId4; //编程语言类型Id4
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId5))
 {
objRow[conApplicationType.ProgLangTypeId5] = objApplicationTypeEN.ProgLangTypeId5; //编程语言类型Id5
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.IsVisible))
 {
objRow[conApplicationType.IsVisible] = objApplicationTypeEN.IsVisible; //是否显示
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.VisitedNum))
 {
objRow[conApplicationType.VisitedNum] = objApplicationTypeEN.VisitedNum; //访问数
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.OrderNum))
 {
objRow[conApplicationType.OrderNum] = objApplicationTypeEN.OrderNum; //序号
 }
 if (objApplicationTypeEN.IsUpdated(conApplicationType.Memo))
 {
objRow[conApplicationType.Memo] = objApplicationTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsApplicationTypeEN._CurrTabName);
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
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsApplicationTypeEN objApplicationTypeEN)
{
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objApplicationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ApplicationType Set ");
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeName))
 {
 if (objApplicationTypeEN.ApplicationTypeName !=  null)
 {
 var strApplicationTypeName = objApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeName, conApplicationType.ApplicationTypeName); //应用程序类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ApplicationTypeName); //应用程序类型名称
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeSimName))
 {
 if (objApplicationTypeEN.ApplicationTypeSimName !=  null)
 {
 var strApplicationTypeSimName = objApplicationTypeEN.ApplicationTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeSimName, conApplicationType.ApplicationTypeSimName); //应用程序类型简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ApplicationTypeSimName); //应用程序类型简称
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeENName))
 {
 if (objApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 var strApplicationTypeENName = objApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeENName, conApplicationType.ApplicationTypeENName); //应用类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ApplicationTypeENName); //应用类型英文名
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId))
 {
 if (objApplicationTypeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conApplicationType.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId2))
 {
 if (objApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 var strProgLangTypeId2 = objApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId2, conApplicationType.ProgLangTypeId2); //编程语言类型Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId2); //编程语言类型Id2
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId3))
 {
 if (objApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 var strProgLangTypeId3 = objApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId3, conApplicationType.ProgLangTypeId3); //编程语言类型Id3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId3); //编程语言类型Id3
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId4))
 {
 if (objApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 var strProgLangTypeId4 = objApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId4, conApplicationType.ProgLangTypeId4); //编程语言类型Id4
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId4); //编程语言类型Id4
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId5))
 {
 if (objApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 var strProgLangTypeId5 = objApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId5, conApplicationType.ProgLangTypeId5); //编程语言类型Id5
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId5); //编程语言类型Id5
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objApplicationTypeEN.IsVisible == true?"1":"0", conApplicationType.IsVisible); //是否显示
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.VisitedNum))
 {
 if (objApplicationTypeEN.VisitedNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objApplicationTypeEN.VisitedNum, conApplicationType.VisitedNum); //访问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.VisitedNum); //访问数
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objApplicationTypeEN.OrderNum, conApplicationType.OrderNum); //序号
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.Memo))
 {
 if (objApplicationTypeEN.Memo !=  null)
 {
 var strMemo = objApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conApplicationType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ApplicationTypeId = {0}", objApplicationTypeEN.ApplicationTypeId); 
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
 /// <param name = "objApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsApplicationTypeEN objApplicationTypeEN, string strCondition)
{
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objApplicationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ApplicationType Set ");
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeName))
 {
 if (objApplicationTypeEN.ApplicationTypeName !=  null)
 {
 var strApplicationTypeName = objApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeName = '{0}',", strApplicationTypeName); //应用程序类型名称
 }
 else
 {
 sbSQL.Append(" ApplicationTypeName = null,"); //应用程序类型名称
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeSimName))
 {
 if (objApplicationTypeEN.ApplicationTypeSimName !=  null)
 {
 var strApplicationTypeSimName = objApplicationTypeEN.ApplicationTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeSimName = '{0}',", strApplicationTypeSimName); //应用程序类型简称
 }
 else
 {
 sbSQL.Append(" ApplicationTypeSimName = null,"); //应用程序类型简称
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeENName))
 {
 if (objApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 var strApplicationTypeENName = objApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeENName = '{0}',", strApplicationTypeENName); //应用类型英文名
 }
 else
 {
 sbSQL.Append(" ApplicationTypeENName = null,"); //应用类型英文名
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId))
 {
 if (objApplicationTypeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId2))
 {
 if (objApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 var strProgLangTypeId2 = objApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId2 = '{0}',", strProgLangTypeId2); //编程语言类型Id2
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId2 = null,"); //编程语言类型Id2
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId3))
 {
 if (objApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 var strProgLangTypeId3 = objApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId3 = '{0}',", strProgLangTypeId3); //编程语言类型Id3
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId3 = null,"); //编程语言类型Id3
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId4))
 {
 if (objApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 var strProgLangTypeId4 = objApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId4 = '{0}',", strProgLangTypeId4); //编程语言类型Id4
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId4 = null,"); //编程语言类型Id4
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId5))
 {
 if (objApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 var strProgLangTypeId5 = objApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId5 = '{0}',", strProgLangTypeId5); //编程语言类型Id5
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId5 = null,"); //编程语言类型Id5
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objApplicationTypeEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.VisitedNum))
 {
 if (objApplicationTypeEN.VisitedNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objApplicationTypeEN.VisitedNum, conApplicationType.VisitedNum); //访问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.VisitedNum); //访问数
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objApplicationTypeEN.OrderNum); //序号
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.Memo))
 {
 if (objApplicationTypeEN.Memo !=  null)
 {
 var strMemo = objApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsApplicationTypeEN objApplicationTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objApplicationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ApplicationType Set ");
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeName))
 {
 if (objApplicationTypeEN.ApplicationTypeName !=  null)
 {
 var strApplicationTypeName = objApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeName = '{0}',", strApplicationTypeName); //应用程序类型名称
 }
 else
 {
 sbSQL.Append(" ApplicationTypeName = null,"); //应用程序类型名称
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeSimName))
 {
 if (objApplicationTypeEN.ApplicationTypeSimName !=  null)
 {
 var strApplicationTypeSimName = objApplicationTypeEN.ApplicationTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeSimName = '{0}',", strApplicationTypeSimName); //应用程序类型简称
 }
 else
 {
 sbSQL.Append(" ApplicationTypeSimName = null,"); //应用程序类型简称
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeENName))
 {
 if (objApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 var strApplicationTypeENName = objApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ApplicationTypeENName = '{0}',", strApplicationTypeENName); //应用类型英文名
 }
 else
 {
 sbSQL.Append(" ApplicationTypeENName = null,"); //应用类型英文名
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId))
 {
 if (objApplicationTypeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId2))
 {
 if (objApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 var strProgLangTypeId2 = objApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId2 = '{0}',", strProgLangTypeId2); //编程语言类型Id2
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId2 = null,"); //编程语言类型Id2
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId3))
 {
 if (objApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 var strProgLangTypeId3 = objApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId3 = '{0}',", strProgLangTypeId3); //编程语言类型Id3
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId3 = null,"); //编程语言类型Id3
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId4))
 {
 if (objApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 var strProgLangTypeId4 = objApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId4 = '{0}',", strProgLangTypeId4); //编程语言类型Id4
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId4 = null,"); //编程语言类型Id4
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId5))
 {
 if (objApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 var strProgLangTypeId5 = objApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId5 = '{0}',", strProgLangTypeId5); //编程语言类型Id5
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId5 = null,"); //编程语言类型Id5
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objApplicationTypeEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.VisitedNum))
 {
 if (objApplicationTypeEN.VisitedNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objApplicationTypeEN.VisitedNum, conApplicationType.VisitedNum); //访问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.VisitedNum); //访问数
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objApplicationTypeEN.OrderNum); //序号
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.Memo))
 {
 if (objApplicationTypeEN.Memo !=  null)
 {
 var strMemo = objApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsApplicationTypeEN objApplicationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objApplicationTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objApplicationTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ApplicationType Set ");
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeName))
 {
 if (objApplicationTypeEN.ApplicationTypeName !=  null)
 {
 var strApplicationTypeName = objApplicationTypeEN.ApplicationTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeName, conApplicationType.ApplicationTypeName); //应用程序类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ApplicationTypeName); //应用程序类型名称
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeSimName))
 {
 if (objApplicationTypeEN.ApplicationTypeSimName !=  null)
 {
 var strApplicationTypeSimName = objApplicationTypeEN.ApplicationTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeSimName, conApplicationType.ApplicationTypeSimName); //应用程序类型简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ApplicationTypeSimName); //应用程序类型简称
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ApplicationTypeENName))
 {
 if (objApplicationTypeEN.ApplicationTypeENName !=  null)
 {
 var strApplicationTypeENName = objApplicationTypeEN.ApplicationTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strApplicationTypeENName, conApplicationType.ApplicationTypeENName); //应用类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ApplicationTypeENName); //应用类型英文名
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId))
 {
 if (objApplicationTypeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objApplicationTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conApplicationType.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId2))
 {
 if (objApplicationTypeEN.ProgLangTypeId2 !=  null)
 {
 var strProgLangTypeId2 = objApplicationTypeEN.ProgLangTypeId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId2, conApplicationType.ProgLangTypeId2); //编程语言类型Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId2); //编程语言类型Id2
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId3))
 {
 if (objApplicationTypeEN.ProgLangTypeId3 !=  null)
 {
 var strProgLangTypeId3 = objApplicationTypeEN.ProgLangTypeId3.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId3, conApplicationType.ProgLangTypeId3); //编程语言类型Id3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId3); //编程语言类型Id3
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId4))
 {
 if (objApplicationTypeEN.ProgLangTypeId4 !=  null)
 {
 var strProgLangTypeId4 = objApplicationTypeEN.ProgLangTypeId4.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId4, conApplicationType.ProgLangTypeId4); //编程语言类型Id4
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId4); //编程语言类型Id4
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.ProgLangTypeId5))
 {
 if (objApplicationTypeEN.ProgLangTypeId5 !=  null)
 {
 var strProgLangTypeId5 = objApplicationTypeEN.ProgLangTypeId5.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId5, conApplicationType.ProgLangTypeId5); //编程语言类型Id5
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.ProgLangTypeId5); //编程语言类型Id5
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objApplicationTypeEN.IsVisible == true?"1":"0", conApplicationType.IsVisible); //是否显示
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.VisitedNum))
 {
 if (objApplicationTypeEN.VisitedNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objApplicationTypeEN.VisitedNum, conApplicationType.VisitedNum); //访问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.VisitedNum); //访问数
 }
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objApplicationTypeEN.OrderNum, conApplicationType.OrderNum); //序号
 }
 
 if (objApplicationTypeEN.IsUpdated(conApplicationType.Memo))
 {
 if (objApplicationTypeEN.Memo !=  null)
 {
 var strMemo = objApplicationTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conApplicationType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conApplicationType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ApplicationTypeId = {0}", objApplicationTypeEN.ApplicationTypeId); 
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
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intApplicationTypeId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 intApplicationTypeId,
};
 objSQL.ExecSP("ApplicationType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(int intApplicationTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
//删除ApplicationType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ApplicationType where ApplicationTypeId = " + ""+ intApplicationTypeId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelApplicationType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
//删除ApplicationType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ApplicationType where ApplicationTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(int intApplicationTypeId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
//删除ApplicationType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ApplicationType where ApplicationTypeId = " + ""+ intApplicationTypeId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelApplicationType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsApplicationTypeDA: DelApplicationType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ApplicationType where " + strCondition ;
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
public bool DelApplicationTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsApplicationTypeDA: DelApplicationTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ApplicationType where " + strCondition ;
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
 /// <param name = "objApplicationTypeENS">源对象</param>
 /// <param name = "objApplicationTypeENT">目标对象</param>
public void CopyTo(clsApplicationTypeEN objApplicationTypeENS, clsApplicationTypeEN objApplicationTypeENT)
{
objApplicationTypeENT.ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objApplicationTypeENT.ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objApplicationTypeENT.ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objApplicationTypeENT.ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objApplicationTypeENT.ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objApplicationTypeENT.ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objApplicationTypeENT.ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objApplicationTypeENT.ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objApplicationTypeENT.ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objApplicationTypeENT.IsVisible = objApplicationTypeENS.IsVisible; //是否显示
objApplicationTypeENT.VisitedNum = objApplicationTypeENS.VisitedNum; //访问数
objApplicationTypeENT.OrderNum = objApplicationTypeENS.OrderNum; //序号
objApplicationTypeENT.Memo = objApplicationTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsApplicationTypeEN objApplicationTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objApplicationTypeEN.ApplicationTypeName, conApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldNotNull(objApplicationTypeEN.ApplicationTypeENName, conApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldNotNull(objApplicationTypeEN.OrderNum, conApplicationType.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ApplicationTypeName, 30, conApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ApplicationTypeSimName, 30, conApplicationType.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ApplicationTypeENName, 30, conApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId, 2, conApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId2, 2, conApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId3, 2, conApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId4, 2, conApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId5, 2, conApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.Memo, 1000, conApplicationType.Memo);
//检查字段外键固定长度
 objApplicationTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsApplicationTypeEN objApplicationTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ApplicationTypeName, 30, conApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ApplicationTypeSimName, 30, conApplicationType.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ApplicationTypeENName, 30, conApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId, 2, conApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId2, 2, conApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId3, 2, conApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId4, 2, conApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId5, 2, conApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.Memo, 1000, conApplicationType.Memo);
//检查外键字段长度
 objApplicationTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsApplicationTypeEN objApplicationTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ApplicationTypeName, 30, conApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ApplicationTypeSimName, 30, conApplicationType.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ApplicationTypeENName, 30, conApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId, 2, conApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId2, 2, conApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId3, 2, conApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId4, 2, conApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.ProgLangTypeId5, 2, conApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldLen(objApplicationTypeEN.Memo, 1000, conApplicationType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objApplicationTypeEN.ApplicationTypeName, conApplicationType.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objApplicationTypeEN.ApplicationTypeSimName, conApplicationType.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objApplicationTypeEN.ApplicationTypeENName, conApplicationType.ApplicationTypeENName);
clsCheckSql.CheckSqlInjection4Field(objApplicationTypeEN.ProgLangTypeId, conApplicationType.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objApplicationTypeEN.ProgLangTypeId2, conApplicationType.ProgLangTypeId2);
clsCheckSql.CheckSqlInjection4Field(objApplicationTypeEN.ProgLangTypeId3, conApplicationType.ProgLangTypeId3);
clsCheckSql.CheckSqlInjection4Field(objApplicationTypeEN.ProgLangTypeId4, conApplicationType.ProgLangTypeId4);
clsCheckSql.CheckSqlInjection4Field(objApplicationTypeEN.ProgLangTypeId5, conApplicationType.ProgLangTypeId5);
clsCheckSql.CheckSqlInjection4Field(objApplicationTypeEN.Memo, conApplicationType.Memo);
//检查外键字段长度
 objApplicationTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetApplicationTypeId()
{
//获取某学院所有专业信息
string strSQL = "select ApplicationTypeId, ApplicationTypeName from ApplicationType ";
 clsSpecSQLforSql mySql = clsApplicationTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ApplicationType(应用程序类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objApplicationTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsApplicationTypeEN objApplicationTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objApplicationTypeEN.ApplicationTypeName);
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
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsApplicationTypeEN._CurrTabName);
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
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsApplicationTypeEN._CurrTabName, strCondition);
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
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
 objSQL = clsApplicationTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}