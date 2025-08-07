
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppCodeTypeRelaDA
 表名:vAppCodeTypeRela(00050419)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:40:58
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
 /// v应用程序代码类型关系(vAppCodeTypeRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvAppCodeTypeRelaDA : clsCommBase4DA
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
 return clsvAppCodeTypeRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvAppCodeTypeRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvAppCodeTypeRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvAppCodeTypeRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvAppCodeTypeRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vAppCodeTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vAppCodeTypeRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetDataTable_vAppCodeTypeRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vAppCodeTypeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vAppCodeTypeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vAppCodeTypeRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vAppCodeTypeRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vAppCodeTypeRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vAppCodeTypeRela.* " + 
$"from vAppCodeTypeRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vAppCodeTypeRela.mId not in " + 
$"(Select top {intTop_In} vAppCodeTypeRela.mId from vAppCodeTypeRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vAppCodeTypeRela where {1} and mId not in (Select top {2} mId from vAppCodeTypeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vAppCodeTypeRela where {1} and mId not in (Select top {3} mId from vAppCodeTypeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vAppCodeTypeRela.* " + 
$"from vAppCodeTypeRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vAppCodeTypeRela.mId not in " + 
$"(Select top {intTop_In} vAppCodeTypeRela.mId from vAppCodeTypeRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vAppCodeTypeRela where {1} and mId not in (Select top {2} mId from vAppCodeTypeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vAppCodeTypeRela where {1} and mId not in (Select top {3} mId from vAppCodeTypeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvAppCodeTypeRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA:GetObjLst)", objException.Message));
}
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vAppCodeTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = TransNullToInt(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = TransNullToBool(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = TransNullToInt(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvAppCodeTypeRelaDA: GetObjLst)", objException.Message));
}
objvAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvAppCodeTypeRelaEN);
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
public List<clsvAppCodeTypeRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = TransNullToInt(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = TransNullToBool(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = TransNullToInt(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvAppCodeTypeRelaDA: GetObjLst)", objException.Message));
}
objvAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvAppCodeTypeRela(ref clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vAppCodeTypeRela where mId = " + ""+ objvAppCodeTypeRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvAppCodeTypeRelaEN.mId = TransNullToInt(objDT.Rows[0][convAppCodeTypeRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.ApplicationTypeName = objDT.Rows[0][convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.ApplicationTypeENName = objDT.Rows[0][convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.CodeTypeId = objDT.Rows[0][convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.CodeTypeName = objDT.Rows[0][convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvAppCodeTypeRelaEN.CodeTypeSimName = objDT.Rows[0][convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvAppCodeTypeRelaEN.CodeTypeENName = objDT.Rows[0][convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvAppCodeTypeRelaEN.GroupName = objDT.Rows[0][convAppCodeTypeRela.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.ProgLangTypeId = objDT.Rows[0][convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvAppCodeTypeRelaEN.ProgLangTypeName = objDT.Rows[0][convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.ProgLangTypeSimName = objDT.Rows[0][convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvAppCodeTypeRelaEN.RegionTypeId = objDT.Rows[0][convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.RegionTypeName = objDT.Rows[0][convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.DependsOn = objDT.Rows[0][convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于(字段类型:varchar,字段长度:50,是否可空:True)
 objvAppCodeTypeRelaEN.FrontOrBack = objDT.Rows[0][convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台(字段类型:varchar,字段长度:50,是否可空:True)
 objvAppCodeTypeRelaEN.AppCount = TransNullToInt(objDT.Rows[0][convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数(字段类型:int,字段长度:4,是否可空:True)
 objvAppCodeTypeRelaEN.ViewTypeCode = TransNullToInt(objDT.Rows[0][convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.ViewTypeName = objDT.Rows[0][convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称(字段类型:varchar,字段长度:40,是否可空:False)
 objvAppCodeTypeRelaEN.TabMainTypeId = objDT.Rows[0][convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvAppCodeTypeRelaEN.TabMainTypeName = objDT.Rows[0][convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvAppCodeTypeRelaEN.IsVisible = TransNullToBool(objDT.Rows[0][convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objDT.Rows[0][convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvAppCodeTypeRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.UpdDate = objDT.Rows[0][convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvAppCodeTypeRelaEN.UpdUser = objDT.Rows[0][convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvAppCodeTypeRelaEN.Memo = objDT.Rows[0][convAppCodeTypeRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvAppCodeTypeRelaDA: GetvAppCodeTypeRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvAppCodeTypeRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vAppCodeTypeRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
 objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于(字段类型:varchar,字段长度:50,是否可空:True)
 objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台(字段类型:varchar,字段长度:50,是否可空:True)
 objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数(字段类型:int,字段长度:4,是否可空:True)
 objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称(字段类型:varchar,字段长度:40,是否可空:False)
 objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvAppCodeTypeRelaDA: GetObjBymId)", objException.Message));
}
return objvAppCodeTypeRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvAppCodeTypeRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vAppCodeTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN()
{
mId = TransNullToInt(objRow[convAppCodeTypeRela.mId].ToString().Trim()), //mId
ApplicationTypeId = TransNullToInt(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(), //简称
CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(), //代码类型英文名
GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(), //组名
ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(), //编程语言类型名
ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(), //编程语言类型简称
RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(), //区域类型Id
RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(), //区域类型名称
DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(), //依赖于
FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(), //前台Or后台
AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()), //应用数
ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()), //界面类型码
ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(), //界面类型名称
TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(), //表主类型Id
TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(), //表主类型名
IsVisible = TransNullToBool(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()), //是否显示
IsInGroupGeneCode = TransNullToBool(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()), //是否参与组生成代码
OrderNum = TransNullToInt(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim() //说明
};
objvAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvAppCodeTypeRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvAppCodeTypeRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvAppCodeTypeRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = TransNullToInt(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = TransNullToBool(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = TransNullToInt(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvAppCodeTypeRelaDA: GetObjByDataRowvAppCodeTypeRela)", objException.Message));
}
objvAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvAppCodeTypeRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvAppCodeTypeRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = TransNullToInt(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = TransNullToBool(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = TransNullToInt(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvAppCodeTypeRelaDA: GetObjByDataRow)", objException.Message));
}
objvAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvAppCodeTypeRelaEN;
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
objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvAppCodeTypeRelaEN._CurrTabName, convAppCodeTypeRela.mId, 8, "");
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
objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvAppCodeTypeRelaEN._CurrTabName, convAppCodeTypeRela.mId, 8, strPrefix);
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
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vAppCodeTypeRela where " + strCondition;
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
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vAppCodeTypeRela where " + strCondition;
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
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vAppCodeTypeRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvAppCodeTypeRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vAppCodeTypeRela", strCondition))
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
objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vAppCodeTypeRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaENS">源对象</param>
 /// <param name = "objvAppCodeTypeRelaENT">目标对象</param>
public void CopyTo(clsvAppCodeTypeRelaEN objvAppCodeTypeRelaENS, clsvAppCodeTypeRelaEN objvAppCodeTypeRelaENT)
{
objvAppCodeTypeRelaENT.mId = objvAppCodeTypeRelaENS.mId; //mId
objvAppCodeTypeRelaENT.ApplicationTypeId = objvAppCodeTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objvAppCodeTypeRelaENT.ApplicationTypeName = objvAppCodeTypeRelaENS.ApplicationTypeName; //应用程序类型名称
objvAppCodeTypeRelaENT.ApplicationTypeENName = objvAppCodeTypeRelaENS.ApplicationTypeENName; //应用类型英文名
objvAppCodeTypeRelaENT.CodeTypeId = objvAppCodeTypeRelaENS.CodeTypeId; //代码类型Id
objvAppCodeTypeRelaENT.CodeTypeName = objvAppCodeTypeRelaENS.CodeTypeName; //代码类型名
objvAppCodeTypeRelaENT.CodeTypeSimName = objvAppCodeTypeRelaENS.CodeTypeSimName; //简称
objvAppCodeTypeRelaENT.CodeTypeENName = objvAppCodeTypeRelaENS.CodeTypeENName; //代码类型英文名
objvAppCodeTypeRelaENT.GroupName = objvAppCodeTypeRelaENS.GroupName; //组名
objvAppCodeTypeRelaENT.ProgLangTypeId = objvAppCodeTypeRelaENS.ProgLangTypeId; //编程语言类型Id
objvAppCodeTypeRelaENT.ProgLangTypeName = objvAppCodeTypeRelaENS.ProgLangTypeName; //编程语言类型名
objvAppCodeTypeRelaENT.ProgLangTypeSimName = objvAppCodeTypeRelaENS.ProgLangTypeSimName; //编程语言类型简称
objvAppCodeTypeRelaENT.RegionTypeId = objvAppCodeTypeRelaENS.RegionTypeId; //区域类型Id
objvAppCodeTypeRelaENT.RegionTypeName = objvAppCodeTypeRelaENS.RegionTypeName; //区域类型名称
objvAppCodeTypeRelaENT.DependsOn = objvAppCodeTypeRelaENS.DependsOn; //依赖于
objvAppCodeTypeRelaENT.FrontOrBack = objvAppCodeTypeRelaENS.FrontOrBack; //前台Or后台
objvAppCodeTypeRelaENT.AppCount = objvAppCodeTypeRelaENS.AppCount; //应用数
objvAppCodeTypeRelaENT.ViewTypeCode = objvAppCodeTypeRelaENS.ViewTypeCode; //界面类型码
objvAppCodeTypeRelaENT.ViewTypeName = objvAppCodeTypeRelaENS.ViewTypeName; //界面类型名称
objvAppCodeTypeRelaENT.TabMainTypeId = objvAppCodeTypeRelaENS.TabMainTypeId; //表主类型Id
objvAppCodeTypeRelaENT.TabMainTypeName = objvAppCodeTypeRelaENS.TabMainTypeName; //表主类型名
objvAppCodeTypeRelaENT.IsVisible = objvAppCodeTypeRelaENS.IsVisible; //是否显示
objvAppCodeTypeRelaENT.IsInGroupGeneCode = objvAppCodeTypeRelaENS.IsInGroupGeneCode; //是否参与组生成代码
objvAppCodeTypeRelaENT.OrderNum = objvAppCodeTypeRelaENS.OrderNum; //序号
objvAppCodeTypeRelaENT.UpdDate = objvAppCodeTypeRelaENS.UpdDate; //修改日期
objvAppCodeTypeRelaENT.UpdUser = objvAppCodeTypeRelaENS.UpdUser; //修改者
objvAppCodeTypeRelaENT.Memo = objvAppCodeTypeRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.ApplicationTypeName, 30, convAppCodeTypeRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.ApplicationTypeENName, 30, convAppCodeTypeRela.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.CodeTypeId, 4, convAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.CodeTypeName, 50, convAppCodeTypeRela.CodeTypeName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.CodeTypeSimName, 50, convAppCodeTypeRela.CodeTypeSimName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.CodeTypeENName, 50, convAppCodeTypeRela.CodeTypeENName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.GroupName, 30, convAppCodeTypeRela.GroupName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.ProgLangTypeId, 2, convAppCodeTypeRela.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.ProgLangTypeName, 30, convAppCodeTypeRela.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.ProgLangTypeSimName, 30, convAppCodeTypeRela.ProgLangTypeSimName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.RegionTypeId, 4, convAppCodeTypeRela.RegionTypeId);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.RegionTypeName, 30, convAppCodeTypeRela.RegionTypeName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.DependsOn, 50, convAppCodeTypeRela.DependsOn);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.FrontOrBack, 50, convAppCodeTypeRela.FrontOrBack);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.ViewTypeName, 40, convAppCodeTypeRela.ViewTypeName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.TabMainTypeId, 4, convAppCodeTypeRela.TabMainTypeId);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.TabMainTypeName, 30, convAppCodeTypeRela.TabMainTypeName);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.UpdDate, 20, convAppCodeTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.UpdUser, 20, convAppCodeTypeRela.UpdUser);
clsCheckSql.CheckFieldLen(objvAppCodeTypeRelaEN.Memo, 1000, convAppCodeTypeRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.ApplicationTypeName, convAppCodeTypeRela.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.ApplicationTypeENName, convAppCodeTypeRela.ApplicationTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.CodeTypeId, convAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.CodeTypeName, convAppCodeTypeRela.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.CodeTypeSimName, convAppCodeTypeRela.CodeTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.CodeTypeENName, convAppCodeTypeRela.CodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.GroupName, convAppCodeTypeRela.GroupName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.ProgLangTypeId, convAppCodeTypeRela.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.ProgLangTypeName, convAppCodeTypeRela.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.ProgLangTypeSimName, convAppCodeTypeRela.ProgLangTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.RegionTypeId, convAppCodeTypeRela.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.RegionTypeName, convAppCodeTypeRela.RegionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.DependsOn, convAppCodeTypeRela.DependsOn);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.FrontOrBack, convAppCodeTypeRela.FrontOrBack);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.ViewTypeName, convAppCodeTypeRela.ViewTypeName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.TabMainTypeId, convAppCodeTypeRela.TabMainTypeId);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.TabMainTypeName, convAppCodeTypeRela.TabMainTypeName);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.UpdDate, convAppCodeTypeRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.UpdUser, convAppCodeTypeRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvAppCodeTypeRelaEN.Memo, convAppCodeTypeRela.Memo);
//检查外键字段长度
 objvAppCodeTypeRelaEN._IsCheckProperty = true;
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
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvAppCodeTypeRelaEN._CurrTabName);
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
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvAppCodeTypeRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvAppCodeTypeRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}