
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnMappingModeDA
 表名:DnMappingMode(00050571)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:24
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
 /// 结点映射模式(DnMappingMode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDnMappingModeDA : clsCommBase4DA
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
 return clsDnMappingModeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDnMappingModeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDnMappingModeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDnMappingModeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDnMappingModeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strMappingModeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strMappingModeId)
{
strMappingModeId = strMappingModeId.Replace("'", "''");
if (strMappingModeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:DnMappingMode中,检查关键字,长度不正确!(clsDnMappingModeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMappingModeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DnMappingMode中,关键字不能为空 或 null!(clsDnMappingModeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMappingModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDnMappingModeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDnMappingModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DnMappingMode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDnMappingModeDA: GetDataTable_DnMappingMode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDnMappingModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDnMappingModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDnMappingModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDnMappingModeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnMappingMode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnMappingMode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDnMappingModeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DnMappingMode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDnMappingModeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnMappingMode.* " + 
$"from DnMappingMode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnMappingMode.MappingModeId not in " + 
$"(Select top {intTop_In} DnMappingMode.MappingModeId from DnMappingMode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnMappingMode where {1} and MappingModeId not in (Select top {2} MappingModeId from DnMappingMode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnMappingMode where {1} and MappingModeId not in (Select top {3} MappingModeId from DnMappingMode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDnMappingModeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnMappingMode.* " + 
$"from DnMappingMode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnMappingMode.MappingModeId not in " + 
$"(Select top {intTop_In} DnMappingMode.MappingModeId from DnMappingMode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnMappingMode where {1} and MappingModeId not in (Select top {2} MappingModeId from DnMappingMode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnMappingMode where {1} and MappingModeId not in (Select top {3} MappingModeId from DnMappingMode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDnMappingModeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDnMappingModeDA:GetObjLst)", objException.Message));
}
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnMappingModeDA: GetObjLst)", objException.Message));
}
objDnMappingModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnMappingModeEN);
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
public List<clsDnMappingModeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDnMappingModeDA:GetObjLstByTabName)", objException.Message));
}
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnMappingModeDA: GetObjLst)", objException.Message));
}
objDnMappingModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnMappingModeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDnMappingMode(ref clsDnMappingModeEN objDnMappingModeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where MappingModeId = " + "'"+ objDnMappingModeEN.MappingModeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDnMappingModeEN.MappingModeId = objDT.Rows[0][conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objDnMappingModeEN.MappingModeName = objDT.Rows[0][conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名(字段类型:varchar,字段长度:50,是否可空:True)
 objDnMappingModeEN.MappingModeENName = objDT.Rows[0][conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objDnMappingModeEN.UpdDate = objDT.Rows[0][conDnMappingMode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnMappingModeEN.UpdUser = objDT.Rows[0][conDnMappingMode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnMappingModeEN.Memo = objDT.Rows[0][conDnMappingMode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDnMappingModeDA: GetDnMappingMode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMappingModeId">表关键字</param>
 /// <returns>表对象</returns>
public clsDnMappingModeEN GetObjByMappingModeId(string strMappingModeId)
{
CheckPrimaryKey(strMappingModeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where MappingModeId = " + "'"+ strMappingModeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
 objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名(字段类型:varchar,字段长度:50,是否可空:True)
 objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDnMappingModeDA: GetObjByMappingModeId)", objException.Message));
}
return objDnMappingModeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDnMappingModeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDnMappingModeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN()
{
MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(), //映射模式Id
MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(), //映射模式名
MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(), //映射模式英文名
UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim() //说明
};
objDnMappingModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnMappingModeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDnMappingModeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDnMappingModeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDnMappingModeDA: GetObjByDataRowDnMappingMode)", objException.Message));
}
objDnMappingModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnMappingModeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDnMappingModeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDnMappingModeDA: GetObjByDataRow)", objException.Message));
}
objDnMappingModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnMappingModeEN;
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
objSQL = clsDnMappingModeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnMappingModeEN._CurrTabName, conDnMappingMode.MappingModeId, 2, "");
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
objSQL = clsDnMappingModeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnMappingModeEN._CurrTabName, conDnMappingMode.MappingModeId, 2, strPrefix);
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
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MappingModeId from DnMappingMode where " + strCondition;
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
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MappingModeId from DnMappingMode where " + strCondition;
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
 /// <param name = "strMappingModeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strMappingModeId)
{
CheckPrimaryKey(strMappingModeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnMappingMode", "MappingModeId = " + "'"+ strMappingModeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDnMappingModeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnMappingMode", strCondition))
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
objSQL = clsDnMappingModeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DnMappingMode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDnMappingModeEN objDnMappingModeEN)
 {
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnMappingModeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnMappingMode");
objRow = objDS.Tables["DnMappingMode"].NewRow();
objRow[conDnMappingMode.MappingModeId] = objDnMappingModeEN.MappingModeId; //映射模式Id
 if (objDnMappingModeEN.MappingModeName !=  "")
 {
objRow[conDnMappingMode.MappingModeName] = objDnMappingModeEN.MappingModeName; //映射模式名
 }
 if (objDnMappingModeEN.MappingModeENName !=  "")
 {
objRow[conDnMappingMode.MappingModeENName] = objDnMappingModeEN.MappingModeENName; //映射模式英文名
 }
 if (objDnMappingModeEN.UpdDate !=  "")
 {
objRow[conDnMappingMode.UpdDate] = objDnMappingModeEN.UpdDate; //修改日期
 }
 if (objDnMappingModeEN.UpdUser !=  "")
 {
objRow[conDnMappingMode.UpdUser] = objDnMappingModeEN.UpdUser; //修改者
 }
 if (objDnMappingModeEN.Memo !=  "")
 {
objRow[conDnMappingMode.Memo] = objDnMappingModeEN.Memo; //说明
 }
objDS.Tables[clsDnMappingModeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDnMappingModeEN._CurrTabName);
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnMappingModeEN objDnMappingModeEN)
{
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnMappingModeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnMappingModeEN.MappingModeId !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeId);
 var strMappingModeId = objDnMappingModeEN.MappingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeId + "'");
 }
 
 if (objDnMappingModeEN.MappingModeName !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeName);
 var strMappingModeName = objDnMappingModeEN.MappingModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeName + "'");
 }
 
 if (objDnMappingModeEN.MappingModeENName !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeENName);
 var strMappingModeENName = objDnMappingModeEN.MappingModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeENName + "'");
 }
 
 if (objDnMappingModeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.UpdDate);
 var strUpdDate = objDnMappingModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnMappingModeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.UpdUser);
 var strUpdUser = objDnMappingModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnMappingModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.Memo);
 var strMemo = objDnMappingModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnMappingMode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnMappingModeEN objDnMappingModeEN)
{
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnMappingModeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnMappingModeEN.MappingModeId !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeId);
 var strMappingModeId = objDnMappingModeEN.MappingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeId + "'");
 }
 
 if (objDnMappingModeEN.MappingModeName !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeName);
 var strMappingModeName = objDnMappingModeEN.MappingModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeName + "'");
 }
 
 if (objDnMappingModeEN.MappingModeENName !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeENName);
 var strMappingModeENName = objDnMappingModeEN.MappingModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeENName + "'");
 }
 
 if (objDnMappingModeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.UpdDate);
 var strUpdDate = objDnMappingModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnMappingModeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.UpdUser);
 var strUpdUser = objDnMappingModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnMappingModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.Memo);
 var strMemo = objDnMappingModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnMappingMode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDnMappingModeEN.MappingModeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnMappingModeEN objDnMappingModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnMappingModeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnMappingModeEN.MappingModeId !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeId);
 var strMappingModeId = objDnMappingModeEN.MappingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeId + "'");
 }
 
 if (objDnMappingModeEN.MappingModeName !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeName);
 var strMappingModeName = objDnMappingModeEN.MappingModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeName + "'");
 }
 
 if (objDnMappingModeEN.MappingModeENName !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeENName);
 var strMappingModeENName = objDnMappingModeEN.MappingModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeENName + "'");
 }
 
 if (objDnMappingModeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.UpdDate);
 var strUpdDate = objDnMappingModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnMappingModeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.UpdUser);
 var strUpdUser = objDnMappingModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnMappingModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.Memo);
 var strMemo = objDnMappingModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnMappingMode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDnMappingModeEN.MappingModeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnMappingModeEN objDnMappingModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnMappingModeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnMappingModeEN.MappingModeId !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeId);
 var strMappingModeId = objDnMappingModeEN.MappingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeId + "'");
 }
 
 if (objDnMappingModeEN.MappingModeName !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeName);
 var strMappingModeName = objDnMappingModeEN.MappingModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeName + "'");
 }
 
 if (objDnMappingModeEN.MappingModeENName !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.MappingModeENName);
 var strMappingModeENName = objDnMappingModeEN.MappingModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMappingModeENName + "'");
 }
 
 if (objDnMappingModeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.UpdDate);
 var strUpdDate = objDnMappingModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnMappingModeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.UpdUser);
 var strUpdUser = objDnMappingModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnMappingModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnMappingMode.Memo);
 var strMemo = objDnMappingModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnMappingMode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDnMappingModes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where MappingModeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnMappingMode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strMappingModeId = oRow[conDnMappingMode.MappingModeId].ToString().Trim();
if (IsExist(strMappingModeId))
{
 string strResult = "关键字变量值为:" + string.Format("MappingModeId = {0}", strMappingModeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDnMappingModeEN._CurrTabName ].NewRow();
objRow[conDnMappingMode.MappingModeId] = oRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objRow[conDnMappingMode.MappingModeName] = oRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objRow[conDnMappingMode.MappingModeENName] = oRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objRow[conDnMappingMode.UpdDate] = oRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objRow[conDnMappingMode.UpdUser] = oRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objRow[conDnMappingMode.Memo] = oRow[conDnMappingMode.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDnMappingModeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDnMappingModeEN._CurrTabName);
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
 /// <param name = "objDnMappingModeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDnMappingModeEN objDnMappingModeEN)
{
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnMappingModeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
strSQL = "Select * from DnMappingMode where MappingModeId = " + "'"+ objDnMappingModeEN.MappingModeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDnMappingModeEN._CurrTabName);
if (objDS.Tables[clsDnMappingModeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:MappingModeId = " + "'"+ objDnMappingModeEN.MappingModeId+"'");
return false;
}
objRow = objDS.Tables[clsDnMappingModeEN._CurrTabName].Rows[0];
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeId))
 {
objRow[conDnMappingMode.MappingModeId] = objDnMappingModeEN.MappingModeId; //映射模式Id
 }
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeName))
 {
objRow[conDnMappingMode.MappingModeName] = objDnMappingModeEN.MappingModeName; //映射模式名
 }
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeENName))
 {
objRow[conDnMappingMode.MappingModeENName] = objDnMappingModeEN.MappingModeENName; //映射模式英文名
 }
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdDate))
 {
objRow[conDnMappingMode.UpdDate] = objDnMappingModeEN.UpdDate; //修改日期
 }
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdUser))
 {
objRow[conDnMappingMode.UpdUser] = objDnMappingModeEN.UpdUser; //修改者
 }
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.Memo))
 {
objRow[conDnMappingMode.Memo] = objDnMappingModeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDnMappingModeEN._CurrTabName);
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnMappingModeEN objDnMappingModeEN)
{
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnMappingModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DnMappingMode Set ");
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeName))
 {
 if (objDnMappingModeEN.MappingModeName !=  null)
 {
 var strMappingModeName = objDnMappingModeEN.MappingModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMappingModeName, conDnMappingMode.MappingModeName); //映射模式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.MappingModeName); //映射模式名
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeENName))
 {
 if (objDnMappingModeEN.MappingModeENName !=  null)
 {
 var strMappingModeENName = objDnMappingModeEN.MappingModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMappingModeENName, conDnMappingMode.MappingModeENName); //映射模式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.MappingModeENName); //映射模式英文名
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdDate))
 {
 if (objDnMappingModeEN.UpdDate !=  null)
 {
 var strUpdDate = objDnMappingModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnMappingMode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.UpdDate); //修改日期
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdUser))
 {
 if (objDnMappingModeEN.UpdUser !=  null)
 {
 var strUpdUser = objDnMappingModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnMappingMode.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.UpdUser); //修改者
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.Memo))
 {
 if (objDnMappingModeEN.Memo !=  null)
 {
 var strMemo = objDnMappingModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnMappingMode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MappingModeId = '{0}'", objDnMappingModeEN.MappingModeId); 
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
 /// <param name = "objDnMappingModeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDnMappingModeEN objDnMappingModeEN, string strCondition)
{
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnMappingModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnMappingMode Set ");
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeName))
 {
 if (objDnMappingModeEN.MappingModeName !=  null)
 {
 var strMappingModeName = objDnMappingModeEN.MappingModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MappingModeName = '{0}',", strMappingModeName); //映射模式名
 }
 else
 {
 sbSQL.Append(" MappingModeName = null,"); //映射模式名
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeENName))
 {
 if (objDnMappingModeEN.MappingModeENName !=  null)
 {
 var strMappingModeENName = objDnMappingModeEN.MappingModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MappingModeENName = '{0}',", strMappingModeENName); //映射模式英文名
 }
 else
 {
 sbSQL.Append(" MappingModeENName = null,"); //映射模式英文名
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdDate))
 {
 if (objDnMappingModeEN.UpdDate !=  null)
 {
 var strUpdDate = objDnMappingModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdUser))
 {
 if (objDnMappingModeEN.UpdUser !=  null)
 {
 var strUpdUser = objDnMappingModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.Memo))
 {
 if (objDnMappingModeEN.Memo !=  null)
 {
 var strMemo = objDnMappingModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnMappingModeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDnMappingModeEN objDnMappingModeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnMappingModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnMappingMode Set ");
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeName))
 {
 if (objDnMappingModeEN.MappingModeName !=  null)
 {
 var strMappingModeName = objDnMappingModeEN.MappingModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MappingModeName = '{0}',", strMappingModeName); //映射模式名
 }
 else
 {
 sbSQL.Append(" MappingModeName = null,"); //映射模式名
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeENName))
 {
 if (objDnMappingModeEN.MappingModeENName !=  null)
 {
 var strMappingModeENName = objDnMappingModeEN.MappingModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MappingModeENName = '{0}',", strMappingModeENName); //映射模式英文名
 }
 else
 {
 sbSQL.Append(" MappingModeENName = null,"); //映射模式英文名
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdDate))
 {
 if (objDnMappingModeEN.UpdDate !=  null)
 {
 var strUpdDate = objDnMappingModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdUser))
 {
 if (objDnMappingModeEN.UpdUser !=  null)
 {
 var strUpdUser = objDnMappingModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.Memo))
 {
 if (objDnMappingModeEN.Memo !=  null)
 {
 var strMemo = objDnMappingModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnMappingModeEN objDnMappingModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnMappingModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnMappingModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnMappingMode Set ");
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeName))
 {
 if (objDnMappingModeEN.MappingModeName !=  null)
 {
 var strMappingModeName = objDnMappingModeEN.MappingModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMappingModeName, conDnMappingMode.MappingModeName); //映射模式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.MappingModeName); //映射模式名
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.MappingModeENName))
 {
 if (objDnMappingModeEN.MappingModeENName !=  null)
 {
 var strMappingModeENName = objDnMappingModeEN.MappingModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMappingModeENName, conDnMappingMode.MappingModeENName); //映射模式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.MappingModeENName); //映射模式英文名
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdDate))
 {
 if (objDnMappingModeEN.UpdDate !=  null)
 {
 var strUpdDate = objDnMappingModeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnMappingMode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.UpdDate); //修改日期
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.UpdUser))
 {
 if (objDnMappingModeEN.UpdUser !=  null)
 {
 var strUpdUser = objDnMappingModeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnMappingMode.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.UpdUser); //修改者
 }
 }
 
 if (objDnMappingModeEN.IsUpdated(conDnMappingMode.Memo))
 {
 if (objDnMappingModeEN.Memo !=  null)
 {
 var strMemo = objDnMappingModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnMappingMode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnMappingMode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MappingModeId = '{0}'", objDnMappingModeEN.MappingModeId); 
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
 /// <param name = "strMappingModeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strMappingModeId) 
{
CheckPrimaryKey(strMappingModeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strMappingModeId,
};
 objSQL.ExecSP("DnMappingMode_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strMappingModeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strMappingModeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strMappingModeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
//删除DnMappingMode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnMappingMode where MappingModeId = " + "'"+ strMappingModeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDnMappingMode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
//删除DnMappingMode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnMappingMode where MappingModeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strMappingModeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strMappingModeId) 
{
CheckPrimaryKey(strMappingModeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
//删除DnMappingMode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnMappingMode where MappingModeId = " + "'"+ strMappingModeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDnMappingMode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDnMappingModeDA: DelDnMappingMode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnMappingMode where " + strCondition ;
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
public bool DelDnMappingModeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDnMappingModeDA: DelDnMappingModeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnMappingMode where " + strCondition ;
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
 /// <param name = "objDnMappingModeENS">源对象</param>
 /// <param name = "objDnMappingModeENT">目标对象</param>
public void CopyTo(clsDnMappingModeEN objDnMappingModeENS, clsDnMappingModeEN objDnMappingModeENT)
{
objDnMappingModeENT.MappingModeId = objDnMappingModeENS.MappingModeId; //映射模式Id
objDnMappingModeENT.MappingModeName = objDnMappingModeENS.MappingModeName; //映射模式名
objDnMappingModeENT.MappingModeENName = objDnMappingModeENS.MappingModeENName; //映射模式英文名
objDnMappingModeENT.UpdDate = objDnMappingModeENS.UpdDate; //修改日期
objDnMappingModeENT.UpdUser = objDnMappingModeENS.UpdUser; //修改者
objDnMappingModeENT.Memo = objDnMappingModeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDnMappingModeEN objDnMappingModeEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objDnMappingModeEN.MappingModeId, 2, conDnMappingMode.MappingModeId);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.MappingModeName, 50, conDnMappingMode.MappingModeName);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.MappingModeENName, 50, conDnMappingMode.MappingModeENName);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.UpdDate, 20, conDnMappingMode.UpdDate);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.UpdUser, 20, conDnMappingMode.UpdUser);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.Memo, 1000, conDnMappingMode.Memo);
//检查字段外键固定长度
 objDnMappingModeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDnMappingModeEN objDnMappingModeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnMappingModeEN.MappingModeName, 50, conDnMappingMode.MappingModeName);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.MappingModeENName, 50, conDnMappingMode.MappingModeENName);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.UpdDate, 20, conDnMappingMode.UpdDate);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.UpdUser, 20, conDnMappingMode.UpdUser);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.Memo, 1000, conDnMappingMode.Memo);
//检查外键字段长度
 objDnMappingModeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDnMappingModeEN objDnMappingModeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnMappingModeEN.MappingModeId, 2, conDnMappingMode.MappingModeId);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.MappingModeName, 50, conDnMappingMode.MappingModeName);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.MappingModeENName, 50, conDnMappingMode.MappingModeENName);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.UpdDate, 20, conDnMappingMode.UpdDate);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.UpdUser, 20, conDnMappingMode.UpdUser);
clsCheckSql.CheckFieldLen(objDnMappingModeEN.Memo, 1000, conDnMappingMode.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDnMappingModeEN.MappingModeId, conDnMappingMode.MappingModeId);
clsCheckSql.CheckSqlInjection4Field(objDnMappingModeEN.MappingModeName, conDnMappingMode.MappingModeName);
clsCheckSql.CheckSqlInjection4Field(objDnMappingModeEN.MappingModeENName, conDnMappingMode.MappingModeENName);
clsCheckSql.CheckSqlInjection4Field(objDnMappingModeEN.UpdDate, conDnMappingMode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDnMappingModeEN.UpdUser, conDnMappingMode.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDnMappingModeEN.Memo, conDnMappingMode.Memo);
//检查外键字段长度
 objDnMappingModeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetMappingModeId()
{
//获取某学院所有专业信息
string strSQL = "select MappingModeId, MappingModeName from DnMappingMode ";
 clsSpecSQLforSql mySql = clsDnMappingModeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DnMappingMode(结点映射模式),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDnMappingModeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDnMappingModeEN objDnMappingModeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objDnMappingModeEN.MappingModeName == null)
{
 sbCondition.AppendFormat(" and MappingModeName is null");
}
else
{
 sbCondition.AppendFormat(" and MappingModeName = '{0}'", objDnMappingModeEN.MappingModeName);
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
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnMappingModeEN._CurrTabName);
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
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnMappingModeEN._CurrTabName, strCondition);
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
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
 objSQL = clsDnMappingModeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}