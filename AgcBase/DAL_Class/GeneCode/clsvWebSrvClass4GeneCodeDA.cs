
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvClass4GeneCodeDA
 表名:vWebSrvClass4GeneCode(00050372)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:43:47
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
 /// vWebSrvClass4GeneCode(vWebSrvClass4GeneCode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvWebSrvClass4GeneCodeDA : clsCommBase4DA
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
 return clsvWebSrvClass4GeneCodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvWebSrvClass4GeneCodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWebSrvClass4GeneCodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvWebSrvClass4GeneCodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvWebSrvClass4GeneCodeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strWebSrvClassId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strWebSrvClassId)
{
strWebSrvClassId = strWebSrvClassId.Replace("'", "''");
if (strWebSrvClassId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vWebSrvClass4GeneCode中,检查关键字,长度不正确!(clsvWebSrvClass4GeneCodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strWebSrvClassId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vWebSrvClass4GeneCode中,关键字不能为空 或 null!(clsvWebSrvClass4GeneCodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvClassId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvWebSrvClass4GeneCodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vWebSrvClass4GeneCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetDataTable_vWebSrvClass4GeneCode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass4GeneCode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass4GeneCode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vWebSrvClass4GeneCode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vWebSrvClass4GeneCode.* " + 
$"from vWebSrvClass4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vWebSrvClass4GeneCode.WebSrvClassId not in " + 
$"(Select top {intTop_In} vWebSrvClass4GeneCode.WebSrvClassId from vWebSrvClass4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass4GeneCode where {1} and WebSrvClassId not in (Select top {2} WebSrvClassId from vWebSrvClass4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass4GeneCode where {1} and WebSrvClassId not in (Select top {3} WebSrvClassId from vWebSrvClass4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vWebSrvClass4GeneCode.* " + 
$"from vWebSrvClass4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vWebSrvClass4GeneCode.WebSrvClassId not in " + 
$"(Select top {intTop_In} vWebSrvClass4GeneCode.WebSrvClassId from vWebSrvClass4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass4GeneCode where {1} and WebSrvClassId not in (Select top {2} WebSrvClassId from vWebSrvClass4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvClass4GeneCode where {1} and WebSrvClassId not in (Select top {3} WebSrvClassId from vWebSrvClass4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvWebSrvClass4GeneCodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA:GetObjLst)", objException.Message));
}
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = TransNullToBool(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetObjLst)", objException.Message));
}
objvWebSrvClass4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
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
public List<clsvWebSrvClass4GeneCodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = TransNullToBool(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetObjLst)", objException.Message));
}
objvWebSrvClass4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvWebSrvClass4GeneCode(ref clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass4GeneCode where WebSrvClassId = " + "'"+ objvWebSrvClass4GeneCodeEN.WebSrvClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvWebSrvClass4GeneCodeEN.WebSrvClassId = objDT.Rows[0][convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvClass4GeneCodeEN.UserName = objDT.Rows[0][convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClass4GeneCodeEN.FuncNum = TransNullToInt(objDT.Rows[0][convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数(字段类型:int,字段长度:4,是否可空:True)
 objvWebSrvClass4GeneCodeEN.GeneCodeDate = objDT.Rows[0][convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvClass4GeneCodeEN.VersionGeneCode = objDT.Rows[0][convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClass4GeneCodeEN.NameSpace = objDT.Rows[0][convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWebSrvClass4GeneCodeEN.WebSrvUrl = objDT.Rows[0][convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objvWebSrvClass4GeneCodeEN.PageName = objDT.Rows[0][convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objDT.Rows[0][convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvClass4GeneCodeEN.FuncModuleName = objDT.Rows[0][convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objDT.Rows[0][convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvWebSrvClass4GeneCodeEN.IsNeedGene = TransNullToBool(objDT.Rows[0][convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvClass4GeneCodeEN.PrjId = objDT.Rows[0][convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvWebSrvClass4GeneCodeEN.PrjName = objDT.Rows[0][convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClass4GeneCodeEN.UpdDate = objDT.Rows[0][convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvClass4GeneCodeEN.Memo = objDT.Rows[0][convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objDT.Rows[0][convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode(字段类型:varchar,字段长度:18,是否可空:True)
 objvWebSrvClass4GeneCodeEN.ClsName = objDT.Rows[0][convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetvWebSrvClass4GeneCode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public clsvWebSrvClass4GeneCodeEN GetObjByWebSrvClassId(string strWebSrvClassId)
{
CheckPrimaryKey(strWebSrvClassId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass4GeneCode where WebSrvClassId = " + "'"+ strWebSrvClassId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
 objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数(字段类型:int,字段长度:4,是否可空:True)
 objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode(字段类型:varchar,字段长度:18,是否可空:True)
 objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetObjByWebSrvClassId)", objException.Message));
}
return objvWebSrvClass4GeneCodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvWebSrvClass4GeneCodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvClass4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN()
{
WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(), //类Id
UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(), //用户名
FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()), //函数个数
GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(), //生成代码日期
VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(), //生成代码版本
NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(), //域名
WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(), //WebSrv地址
PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(), //页面名称
FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
IsNeedGene = TransNullToBool(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()), //是否需要生成
PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(), //工程名称
UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(), //说明
UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(), //UserId4GeneCode
ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim() //类名
};
objvWebSrvClass4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvClass4GeneCodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvWebSrvClass4GeneCodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = TransNullToBool(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetObjByDataRowvWebSrvClass4GeneCode)", objException.Message));
}
objvWebSrvClass4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvClass4GeneCodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvWebSrvClass4GeneCodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = TransNullToBool(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvWebSrvClass4GeneCodeDA: GetObjByDataRow)", objException.Message));
}
objvWebSrvClass4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvClass4GeneCodeEN;
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
objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWebSrvClass4GeneCodeEN._CurrTabName, convWebSrvClass4GeneCode.WebSrvClassId, 8, "");
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
objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWebSrvClass4GeneCodeEN._CurrTabName, convWebSrvClass4GeneCode.WebSrvClassId, 8, strPrefix);
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
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WebSrvClassId from vWebSrvClass4GeneCode where " + strCondition;
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
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WebSrvClassId from vWebSrvClass4GeneCode where " + strCondition;
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
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strWebSrvClassId)
{
CheckPrimaryKey(strWebSrvClassId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWebSrvClass4GeneCode", "WebSrvClassId = " + "'"+ strWebSrvClassId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWebSrvClass4GeneCode", strCondition))
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
objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vWebSrvClass4GeneCode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeENS">源对象</param>
 /// <param name = "objvWebSrvClass4GeneCodeENT">目标对象</param>
public void CopyTo(clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeENS, clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeENT)
{
objvWebSrvClass4GeneCodeENT.WebSrvClassId = objvWebSrvClass4GeneCodeENS.WebSrvClassId; //类Id
objvWebSrvClass4GeneCodeENT.UserName = objvWebSrvClass4GeneCodeENS.UserName; //用户名
objvWebSrvClass4GeneCodeENT.FuncNum = objvWebSrvClass4GeneCodeENS.FuncNum; //函数个数
objvWebSrvClass4GeneCodeENT.GeneCodeDate = objvWebSrvClass4GeneCodeENS.GeneCodeDate; //生成代码日期
objvWebSrvClass4GeneCodeENT.VersionGeneCode = objvWebSrvClass4GeneCodeENS.VersionGeneCode; //生成代码版本
objvWebSrvClass4GeneCodeENT.NameSpace = objvWebSrvClass4GeneCodeENS.NameSpace; //域名
objvWebSrvClass4GeneCodeENT.WebSrvUrl = objvWebSrvClass4GeneCodeENS.WebSrvUrl; //WebSrv地址
objvWebSrvClass4GeneCodeENT.PageName = objvWebSrvClass4GeneCodeENS.PageName; //页面名称
objvWebSrvClass4GeneCodeENT.FuncModuleAgcId = objvWebSrvClass4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvWebSrvClass4GeneCodeENT.FuncModuleName = objvWebSrvClass4GeneCodeENS.FuncModuleName; //功能模块名称
objvWebSrvClass4GeneCodeENT.FuncModuleEnName = objvWebSrvClass4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvWebSrvClass4GeneCodeENT.IsNeedGene = objvWebSrvClass4GeneCodeENS.IsNeedGene; //是否需要生成
objvWebSrvClass4GeneCodeENT.PrjId = objvWebSrvClass4GeneCodeENS.PrjId; //工程Id
objvWebSrvClass4GeneCodeENT.PrjName = objvWebSrvClass4GeneCodeENS.PrjName; //工程名称
objvWebSrvClass4GeneCodeENT.UpdDate = objvWebSrvClass4GeneCodeENS.UpdDate; //修改日期
objvWebSrvClass4GeneCodeENT.Memo = objvWebSrvClass4GeneCodeENS.Memo; //说明
objvWebSrvClass4GeneCodeENT.UserId4GeneCode = objvWebSrvClass4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
objvWebSrvClass4GeneCodeENT.ClsName = objvWebSrvClass4GeneCodeENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.WebSrvClassId, 8, convWebSrvClass4GeneCode.WebSrvClassId);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.UserName, 30, convWebSrvClass4GeneCode.UserName);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.GeneCodeDate, 20, convWebSrvClass4GeneCode.GeneCodeDate);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.VersionGeneCode, 30, convWebSrvClass4GeneCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.NameSpace, 50, convWebSrvClass4GeneCode.NameSpace);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.WebSrvUrl, 300, convWebSrvClass4GeneCode.WebSrvUrl);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.PageName, 100, convWebSrvClass4GeneCode.PageName);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.FuncModuleAgcId, 8, convWebSrvClass4GeneCode.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.FuncModuleName, 30, convWebSrvClass4GeneCode.FuncModuleName);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.FuncModuleEnName, 30, convWebSrvClass4GeneCode.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.PrjId, 4, convWebSrvClass4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.PrjName, 30, convWebSrvClass4GeneCode.PrjName);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.UpdDate, 20, convWebSrvClass4GeneCode.UpdDate);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.Memo, 1000, convWebSrvClass4GeneCode.Memo);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.UserId4GeneCode, 18, convWebSrvClass4GeneCode.UserId4GeneCode);
clsCheckSql.CheckFieldLen(objvWebSrvClass4GeneCodeEN.ClsName, 100, convWebSrvClass4GeneCode.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.WebSrvClassId, convWebSrvClass4GeneCode.WebSrvClassId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.UserName, convWebSrvClass4GeneCode.UserName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.GeneCodeDate, convWebSrvClass4GeneCode.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.VersionGeneCode, convWebSrvClass4GeneCode.VersionGeneCode);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.NameSpace, convWebSrvClass4GeneCode.NameSpace);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.WebSrvUrl, convWebSrvClass4GeneCode.WebSrvUrl);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.PageName, convWebSrvClass4GeneCode.PageName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.FuncModuleAgcId, convWebSrvClass4GeneCode.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.FuncModuleName, convWebSrvClass4GeneCode.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.FuncModuleEnName, convWebSrvClass4GeneCode.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.PrjId, convWebSrvClass4GeneCode.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.PrjName, convWebSrvClass4GeneCode.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.UpdDate, convWebSrvClass4GeneCode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.Memo, convWebSrvClass4GeneCode.Memo);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.UserId4GeneCode, convWebSrvClass4GeneCode.UserId4GeneCode);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvClass4GeneCodeEN.ClsName, convWebSrvClass4GeneCode.ClsName);
//检查外键字段长度
 objvWebSrvClass4GeneCodeEN._IsCheckProperty = true;
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
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWebSrvClass4GeneCodeEN._CurrTabName);
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
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWebSrvClass4GeneCodeEN._CurrTabName, strCondition);
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
 objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}