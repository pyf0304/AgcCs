
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeTypeDA
 表名:vCodeType(00050410)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:41:30
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
 /// v代码类型(vCodeType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCodeTypeDA : clsCommBase4DA
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
 return clsvCodeTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCodeTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCodeTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCodeTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCodeTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCodeTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCodeTypeId)
{
strCodeTypeId = strCodeTypeId.Replace("'", "''");
if (strCodeTypeId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vCodeType中,检查关键字,长度不正确!(clsvCodeTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCodeTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCodeType中,关键字不能为空 或 null!(clsvCodeTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCodeTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCodeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCodeType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCodeTypeDA: GetDataTable_vCodeType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCodeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCodeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCodeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCodeTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCodeType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCodeType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCodeTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCodeType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCodeTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCodeType.* " + 
$"from vCodeType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCodeType.CodeTypeId not in " + 
$"(Select top {intTop_In} vCodeType.CodeTypeId from vCodeType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCodeType where {1} and CodeTypeId not in (Select top {2} CodeTypeId from vCodeType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCodeType where {1} and CodeTypeId not in (Select top {3} CodeTypeId from vCodeType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCodeTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCodeType.* " + 
$"from vCodeType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCodeType.CodeTypeId not in " + 
$"(Select top {intTop_In} vCodeType.CodeTypeId from vCodeType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCodeType where {1} and CodeTypeId not in (Select top {2} CodeTypeId from vCodeType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCodeType where {1} and CodeTypeId not in (Select top {3} CodeTypeId from vCodeType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCodeTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCodeTypeDA:GetObjLst)", objException.Message));
}
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = TransNullToBool(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = TransNullToBool(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = TransNullToBool(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = TransNullToBool(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = TransNullToBool(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = TransNullToBool(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = TransNullToBool(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = TransNullToBool(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = TransNullToBool(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = TransNullToBool(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = TransNullToBool(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = TransNullToBool(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = TransNullToBool(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = TransNullToInt(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = TransNullToBool(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = TransNullToBool(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = TransNullToBool(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCodeTypeDA: GetObjLst)", objException.Message));
}
objvCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCodeTypeEN);
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
public List<clsvCodeTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCodeTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = TransNullToBool(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = TransNullToBool(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = TransNullToBool(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = TransNullToBool(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = TransNullToBool(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = TransNullToBool(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = TransNullToBool(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = TransNullToBool(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = TransNullToBool(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = TransNullToBool(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = TransNullToBool(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = TransNullToBool(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = TransNullToBool(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = TransNullToInt(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = TransNullToBool(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = TransNullToBool(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = TransNullToBool(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCodeTypeDA: GetObjLst)", objException.Message));
}
objvCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCodeTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCodeType(ref clsvCodeTypeEN objvCodeTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType where CodeTypeId = " + "'"+ objvCodeTypeEN.CodeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCodeTypeEN.CodeTypeId = objDT.Rows[0][convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCodeTypeEN.CodeTypeName = objDT.Rows[0][convCodeType.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCodeTypeEN.CodeTypeSimName = objDT.Rows[0][convCodeType.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCodeTypeEN.CodeTypeENName = objDT.Rows[0][convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.GroupName = objDT.Rows[0][convCodeType.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCodeTypeEN.ProgLangTypeId = objDT.Rows[0][convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCodeTypeEN.ProgLangTypeName = objDT.Rows[0][convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCodeTypeEN.ProgLangTypeSimName = objDT.Rows[0][convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCodeTypeEN.RegionTypeId = objDT.Rows[0][convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCodeTypeEN.RegionTypeName = objDT.Rows[0][convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCodeTypeEN.Prefix = objDT.Rows[0][convCodeType.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objvCodeTypeEN.DependsOn = objDT.Rows[0][convCodeType.DependsOn].ToString().Trim(); //依赖于(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.FrontOrBack = objDT.Rows[0][convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.SqlDsTypeId = objDT.Rows[0][convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCodeTypeEN.SqlDsTypeName = objDT.Rows[0][convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvCodeTypeEN.ClassNameFormat = objDT.Rows[0][convCodeType.ClassNameFormat].ToString().Trim(); //类名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.IsCSharp = TransNullToBool(objDT.Rows[0][convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsJava = TransNullToBool(objDT.Rows[0][convCodeType.IsJava].ToString().Trim()); //是否Java语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsJavaScript = TransNullToBool(objDT.Rows[0][convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsTypeScript = TransNullToBool(objDT.Rows[0][convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsSilverLight = TransNullToBool(objDT.Rows[0][convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsSwift = TransNullToBool(objDT.Rows[0][convCodeType.IsSwift].ToString().Trim()); //是否Swift语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsVB = TransNullToBool(objDT.Rows[0][convCodeType.IsVB].ToString().Trim()); //IsVB语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsTableFldConst = TransNullToBool(objDT.Rows[0][convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objDT.Rows[0][convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsWeb = TransNullToBool(objDT.Rows[0][convCodeType.IsWeb].ToString().Trim()); //是否Web应用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsAspMvc = TransNullToBool(objDT.Rows[0][convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsWebSrvAccess = TransNullToBool(objDT.Rows[0][convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsWin = TransNullToBool(objDT.Rows[0][convCodeType.IsWin].ToString().Trim()); //是否Win应用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsMobileApp = TransNullToBool(objDT.Rows[0][convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][convCodeType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCodeTypeEN.WinOrWeb = objDT.Rows[0][convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.IsDirByTabName = TransNullToBool(objDT.Rows[0][convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.InUse = TransNullToBool(objDT.Rows[0][convCodeType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsDefaultOverride = TransNullToBool(objDT.Rows[0][convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖(字段类型:bit,字段长度:1,是否可空:False)
 objvCodeTypeEN.UpdDate = objDT.Rows[0][convCodeType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCodeTypeEN.UpdUser = objDT.Rows[0][convCodeType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCodeTypeEN.Memo = objDT.Rows[0][convCodeType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCodeTypeEN.FuncCount = TransNullToInt(objDT.Rows[0][convCodeType.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
 objvCodeTypeEN.AppCount = TransNullToInt(objDT.Rows[0][convCodeType.AppCount].ToString().Trim()); //应用数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCodeTypeDA: GetvCodeType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCodeTypeEN GetObjByCodeTypeId(string strCodeTypeId)
{
CheckPrimaryKey(strCodeTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType where CodeTypeId = " + "'"+ strCodeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
 objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖(字段类型:bit,字段长度:1,是否可空:False)
 objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
 objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCodeTypeDA: GetObjByCodeTypeId)", objException.Message));
}
return objvCodeTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCodeTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCodeTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN()
{
CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(), //简称
CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(), //代码类型英文名
GroupName = objRow[convCodeType.GroupName].ToString().Trim(), //组名
ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(), //编程语言类型名
ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(), //编程语言类型简称
RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(), //区域类型Id
RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(), //区域类型名称
Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(), //前缀
DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(), //依赖于
FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(), //前台Or后台
SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(), //数据源类型Id
SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(), //Sql数据源名
ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(), //类名格式
IsCSharp = TransNullToBool(objRow[convCodeType.IsCSharp].ToString().Trim()), //是否CSharp语言
IsJava = TransNullToBool(objRow[convCodeType.IsJava].ToString().Trim()), //是否Java语言
IsJavaScript = TransNullToBool(objRow[convCodeType.IsJavaScript].ToString().Trim()), //是否JavaScript语言
IsTypeScript = TransNullToBool(objRow[convCodeType.IsTypeScript].ToString().Trim()), //是否TypeScript语言
IsSilverLight = TransNullToBool(objRow[convCodeType.IsSilverLight].ToString().Trim()), //是否SilverLight语言
IsSwift = TransNullToBool(objRow[convCodeType.IsSwift].ToString().Trim()), //是否Swift语言
IsVB = TransNullToBool(objRow[convCodeType.IsVB].ToString().Trim()), //IsVB语言
IsTableFldConst = TransNullToBool(objRow[convCodeType.IsTableFldConst].ToString().Trim()), //IsTableFldConst
IsPubApp4WinWeb = TransNullToBool(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()), //IsPubApp4WinWeb
IsWeb = TransNullToBool(objRow[convCodeType.IsWeb].ToString().Trim()), //是否Web应用
IsAspMvc = TransNullToBool(objRow[convCodeType.IsAspMvc].ToString().Trim()), //是否AspMvc
IsWebSrvAccess = TransNullToBool(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()), //IsWebSrvAccess
IsWin = TransNullToBool(objRow[convCodeType.IsWin].ToString().Trim()), //是否Win应用
IsMobileApp = TransNullToBool(objRow[convCodeType.IsMobileApp].ToString().Trim()), //是否移动终端应用
OrderNum = TransNullToInt(objRow[convCodeType.OrderNum].ToString().Trim()), //序号
WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(), //WinOrWeb
IsDirByTabName = TransNullToBool(objRow[convCodeType.IsDirByTabName].ToString().Trim()), //是否用表名作为路径
InUse = TransNullToBool(objRow[convCodeType.InUse].ToString().Trim()), //是否在用
IsDefaultOverride = TransNullToBool(objRow[convCodeType.IsDefaultOverride].ToString().Trim()), //是否默认覆盖
UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(), //说明
FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.FuncCount].ToString().Trim()), //函数数目
AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.AppCount].ToString().Trim()) //应用数
};
objvCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCodeTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCodeTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCodeTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = TransNullToBool(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = TransNullToBool(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = TransNullToBool(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = TransNullToBool(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = TransNullToBool(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = TransNullToBool(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = TransNullToBool(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = TransNullToBool(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = TransNullToBool(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = TransNullToBool(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = TransNullToBool(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = TransNullToBool(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = TransNullToBool(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = TransNullToInt(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = TransNullToBool(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = TransNullToBool(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = TransNullToBool(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCodeTypeDA: GetObjByDataRowvCodeType)", objException.Message));
}
objvCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCodeTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCodeTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = TransNullToBool(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = TransNullToBool(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = TransNullToBool(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = TransNullToBool(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = TransNullToBool(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = TransNullToBool(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = TransNullToBool(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = TransNullToBool(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = TransNullToBool(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = TransNullToBool(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = TransNullToBool(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = TransNullToBool(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = TransNullToBool(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = TransNullToInt(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = TransNullToBool(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = TransNullToBool(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = TransNullToBool(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCodeTypeDA: GetObjByDataRow)", objException.Message));
}
objvCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCodeTypeEN;
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
objSQL = clsvCodeTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCodeTypeEN._CurrTabName, convCodeType.CodeTypeId, 4, "");
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
objSQL = clsvCodeTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCodeTypeEN._CurrTabName, convCodeType.CodeTypeId, 4, strPrefix);
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
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CodeTypeId from vCodeType where " + strCondition;
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
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CodeTypeId from vCodeType where " + strCondition;
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCodeTypeId)
{
CheckPrimaryKey(strCodeTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCodeType", "CodeTypeId = " + "'"+ strCodeTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCodeTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCodeType", strCondition))
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
objSQL = clsvCodeTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCodeType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCodeTypeENS">源对象</param>
 /// <param name = "objvCodeTypeENT">目标对象</param>
public void CopyTo(clsvCodeTypeEN objvCodeTypeENS, clsvCodeTypeEN objvCodeTypeENT)
{
objvCodeTypeENT.CodeTypeId = objvCodeTypeENS.CodeTypeId; //代码类型Id
objvCodeTypeENT.CodeTypeName = objvCodeTypeENS.CodeTypeName; //代码类型名
objvCodeTypeENT.CodeTypeSimName = objvCodeTypeENS.CodeTypeSimName; //简称
objvCodeTypeENT.CodeTypeENName = objvCodeTypeENS.CodeTypeENName; //代码类型英文名
objvCodeTypeENT.GroupName = objvCodeTypeENS.GroupName; //组名
objvCodeTypeENT.ProgLangTypeId = objvCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objvCodeTypeENT.ProgLangTypeName = objvCodeTypeENS.ProgLangTypeName; //编程语言类型名
objvCodeTypeENT.ProgLangTypeSimName = objvCodeTypeENS.ProgLangTypeSimName; //编程语言类型简称
objvCodeTypeENT.RegionTypeId = objvCodeTypeENS.RegionTypeId; //区域类型Id
objvCodeTypeENT.RegionTypeName = objvCodeTypeENS.RegionTypeName; //区域类型名称
objvCodeTypeENT.Prefix = objvCodeTypeENS.Prefix; //前缀
objvCodeTypeENT.DependsOn = objvCodeTypeENS.DependsOn; //依赖于
objvCodeTypeENT.FrontOrBack = objvCodeTypeENS.FrontOrBack; //前台Or后台
objvCodeTypeENT.SqlDsTypeId = objvCodeTypeENS.SqlDsTypeId; //数据源类型Id
objvCodeTypeENT.SqlDsTypeName = objvCodeTypeENS.SqlDsTypeName; //Sql数据源名
objvCodeTypeENT.ClassNameFormat = objvCodeTypeENS.ClassNameFormat; //类名格式
objvCodeTypeENT.IsCSharp = objvCodeTypeENS.IsCSharp; //是否CSharp语言
objvCodeTypeENT.IsJava = objvCodeTypeENS.IsJava; //是否Java语言
objvCodeTypeENT.IsJavaScript = objvCodeTypeENS.IsJavaScript; //是否JavaScript语言
objvCodeTypeENT.IsTypeScript = objvCodeTypeENS.IsTypeScript; //是否TypeScript语言
objvCodeTypeENT.IsSilverLight = objvCodeTypeENS.IsSilverLight; //是否SilverLight语言
objvCodeTypeENT.IsSwift = objvCodeTypeENS.IsSwift; //是否Swift语言
objvCodeTypeENT.IsVB = objvCodeTypeENS.IsVB; //IsVB语言
objvCodeTypeENT.IsTableFldConst = objvCodeTypeENS.IsTableFldConst; //IsTableFldConst
objvCodeTypeENT.IsPubApp4WinWeb = objvCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objvCodeTypeENT.IsWeb = objvCodeTypeENS.IsWeb; //是否Web应用
objvCodeTypeENT.IsAspMvc = objvCodeTypeENS.IsAspMvc; //是否AspMvc
objvCodeTypeENT.IsWebSrvAccess = objvCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objvCodeTypeENT.IsWin = objvCodeTypeENS.IsWin; //是否Win应用
objvCodeTypeENT.IsMobileApp = objvCodeTypeENS.IsMobileApp; //是否移动终端应用
objvCodeTypeENT.OrderNum = objvCodeTypeENS.OrderNum; //序号
objvCodeTypeENT.WinOrWeb = objvCodeTypeENS.WinOrWeb; //WinOrWeb
objvCodeTypeENT.IsDirByTabName = objvCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objvCodeTypeENT.InUse = objvCodeTypeENS.InUse; //是否在用
objvCodeTypeENT.IsDefaultOverride = objvCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objvCodeTypeENT.UpdDate = objvCodeTypeENS.UpdDate; //修改日期
objvCodeTypeENT.UpdUser = objvCodeTypeENS.UpdUser; //修改者
objvCodeTypeENT.Memo = objvCodeTypeENS.Memo; //说明
objvCodeTypeENT.FuncCount = objvCodeTypeENS.FuncCount; //函数数目
objvCodeTypeENT.AppCount = objvCodeTypeENS.AppCount; //应用数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCodeTypeEN objvCodeTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCodeTypeEN.CodeTypeId, 4, convCodeType.CodeTypeId);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.CodeTypeName, 50, convCodeType.CodeTypeName);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.CodeTypeSimName, 50, convCodeType.CodeTypeSimName);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.CodeTypeENName, 50, convCodeType.CodeTypeENName);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.GroupName, 30, convCodeType.GroupName);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.ProgLangTypeId, 2, convCodeType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.ProgLangTypeName, 30, convCodeType.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.ProgLangTypeSimName, 30, convCodeType.ProgLangTypeSimName);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.RegionTypeId, 4, convCodeType.RegionTypeId);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.RegionTypeName, 30, convCodeType.RegionTypeName);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.Prefix, 10, convCodeType.Prefix);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.DependsOn, 50, convCodeType.DependsOn);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.FrontOrBack, 50, convCodeType.FrontOrBack);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.SqlDsTypeId, 2, convCodeType.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.SqlDsTypeName, 20, convCodeType.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.ClassNameFormat, 50, convCodeType.ClassNameFormat);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.WinOrWeb, 50, convCodeType.WinOrWeb);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.UpdDate, 20, convCodeType.UpdDate);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.UpdUser, 20, convCodeType.UpdUser);
clsCheckSql.CheckFieldLen(objvCodeTypeEN.Memo, 1000, convCodeType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.CodeTypeId, convCodeType.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.CodeTypeName, convCodeType.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.CodeTypeSimName, convCodeType.CodeTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.CodeTypeENName, convCodeType.CodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.GroupName, convCodeType.GroupName);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.ProgLangTypeId, convCodeType.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.ProgLangTypeName, convCodeType.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.ProgLangTypeSimName, convCodeType.ProgLangTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.RegionTypeId, convCodeType.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.RegionTypeName, convCodeType.RegionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.Prefix, convCodeType.Prefix);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.DependsOn, convCodeType.DependsOn);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.FrontOrBack, convCodeType.FrontOrBack);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.SqlDsTypeId, convCodeType.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.SqlDsTypeName, convCodeType.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.ClassNameFormat, convCodeType.ClassNameFormat);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.WinOrWeb, convCodeType.WinOrWeb);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.UpdDate, convCodeType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.UpdUser, convCodeType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCodeTypeEN.Memo, convCodeType.Memo);
//检查外键字段长度
 objvCodeTypeEN._IsCheckProperty = true;
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
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
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
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
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
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCodeTypeEN._CurrTabName);
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
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCodeTypeEN._CurrTabName, strCondition);
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
 objSQL = clsvCodeTypeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}