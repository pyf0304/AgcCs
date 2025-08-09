
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePrjMainPathDA
 表名:UserCodePrjMainPath(00050338)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 用户生成项目主路径(UserCodePrjMainPath)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserCodePrjMainPathDA : clsCommBase4DA
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
 return clsUserCodePrjMainPathEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserCodePrjMainPathEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserCodePrjMainPathEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserCodePrjMainPathEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserCodePrjMainPathEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strUserCodePrjMainPathId)
{
strUserCodePrjMainPathId = strUserCodePrjMainPathId.Replace("'", "''");
if (strUserCodePrjMainPathId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:UserCodePrjMainPath中,检查关键字,长度不正确!(clsUserCodePrjMainPathDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserCodePrjMainPathId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:UserCodePrjMainPath中,关键字不能为空 或 null!(clsUserCodePrjMainPathDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserCodePrjMainPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsUserCodePrjMainPathDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserCodePrjMainPath(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetDataTable_UserCodePrjMainPath)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserCodePrjMainPath.* " + 
$"from UserCodePrjMainPath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserCodePrjMainPath.UserCodePrjMainPathId not in " + 
$"(Select top {intTop_In} UserCodePrjMainPath.UserCodePrjMainPathId from UserCodePrjMainPath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath where {1} and UserCodePrjMainPathId not in (Select top {2} UserCodePrjMainPathId from UserCodePrjMainPath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath where {1} and UserCodePrjMainPathId not in (Select top {3} UserCodePrjMainPathId from UserCodePrjMainPath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserCodePrjMainPath.* " + 
$"from UserCodePrjMainPath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserCodePrjMainPath.UserCodePrjMainPathId not in " + 
$"(Select top {intTop_In} UserCodePrjMainPath.UserCodePrjMainPathId from UserCodePrjMainPath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath where {1} and UserCodePrjMainPathId not in (Select top {2} UserCodePrjMainPathId from UserCodePrjMainPath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath where {1} and UserCodePrjMainPathId not in (Select top {3} UserCodePrjMainPathId from UserCodePrjMainPath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserCodePrjMainPathEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA:GetObjLst)", objException.Message));
}
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = TransNullToBool(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserCodePrjMainPathDA: GetObjLst)", objException.Message));
}
objUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserCodePrjMainPathEN);
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
public List<clsUserCodePrjMainPathEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = TransNullToBool(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserCodePrjMainPathDA: GetObjLst)", objException.Message));
}
objUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserCodePrjMainPath(ref clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where UserCodePrjMainPathId = " + "'"+ objUserCodePrjMainPathEN.UserCodePrjMainPathId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserCodePrjMainPathEN.UserCodePrjMainPathId = objDT.Rows[0][conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id(字段类型:char,字段长度:8,是否可空:False)
 objUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objDT.Rows[0][conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objUserCodePrjMainPathEN.PrjId = objDT.Rows[0][conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUserCodePrjMainPathEN.ProgLangTypeId = objDT.Rows[0][conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objUserCodePrjMainPathEN.UserId = objDT.Rows[0][conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objDT.Rows[0][conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径(字段类型:bit,字段长度:1,是否可空:False)
 objUserCodePrjMainPathEN.IncludeXmlPath = objDT.Rows[0][conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径(字段类型:varchar,字段长度:150,是否可空:True)
 objUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objDT.Rows[0][conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objUserCodePrjMainPathEN.InUse = TransNullToBool(objDT.Rows[0][conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objUserCodePrjMainPathEN.UpdDate = objDT.Rows[0][conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePrjMainPathEN.UpdUserId = objDT.Rows[0][conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePrjMainPathEN.Memo = objDT.Rows[0][conUserCodePrjMainPath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserCodePrjMainPathDA: GetUserCodePrjMainPath)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <returns>表对象</returns>
public clsUserCodePrjMainPathEN GetObjByUserCodePrjMainPathId(string strUserCodePrjMainPathId)
{
CheckPrimaryKey(strUserCodePrjMainPathId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
 objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id(字段类型:char,字段长度:8,是否可空:False)
 objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径(字段类型:bit,字段长度:1,是否可空:False)
 objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径(字段类型:varchar,字段长度:150,是否可空:True)
 objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserCodePrjMainPathDA: GetObjByUserCodePrjMainPathId)", objException.Message));
}
return objUserCodePrjMainPathEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserCodePrjMainPathEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN()
{
UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(), //生成主目录Id
CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()), //Cm工程应用关系Id
PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(), //工程Id
ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(), //用户Id
IsUsePrjMainPath = TransNullToBool(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()), //是否使用主路径
IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(), //包含表Xml路径
IsTemplate = TransNullToBool(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()), //是否模板
InUse = TransNullToBool(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim() //说明
};
objUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserCodePrjMainPathEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserCodePrjMainPathDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserCodePrjMainPathEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = TransNullToBool(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserCodePrjMainPathDA: GetObjByDataRowUserCodePrjMainPath)", objException.Message));
}
objUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserCodePrjMainPathEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserCodePrjMainPathEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = TransNullToBool(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserCodePrjMainPathDA: GetObjByDataRow)", objException.Message));
}
objUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserCodePrjMainPathEN;
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
objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserCodePrjMainPathEN._CurrTabName, conUserCodePrjMainPath.UserCodePrjMainPathId, 8, "");
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
objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserCodePrjMainPathEN._CurrTabName, conUserCodePrjMainPath.UserCodePrjMainPathId, 8, strPrefix);
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
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserCodePrjMainPathId from UserCodePrjMainPath where " + strCondition;
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
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserCodePrjMainPathId from UserCodePrjMainPath where " + strCondition;
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
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strUserCodePrjMainPathId)
{
CheckPrimaryKey(strUserCodePrjMainPathId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserCodePrjMainPath", "UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserCodePrjMainPath", strCondition))
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
objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserCodePrjMainPath");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
 {
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPathEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserCodePrjMainPath");
objRow = objDS.Tables["UserCodePrjMainPath"].NewRow();
objRow[conUserCodePrjMainPath.UserCodePrjMainPathId] = objUserCodePrjMainPathEN.UserCodePrjMainPathId; //生成主目录Id
objRow[conUserCodePrjMainPath.CMProjectAppRelaId] = objUserCodePrjMainPathEN.CMProjectAppRelaId; //Cm工程应用关系Id
objRow[conUserCodePrjMainPath.PrjId] = objUserCodePrjMainPathEN.PrjId; //工程Id
 if (objUserCodePrjMainPathEN.ProgLangTypeId !=  "")
 {
objRow[conUserCodePrjMainPath.ProgLangTypeId] = objUserCodePrjMainPathEN.ProgLangTypeId; //编程语言类型Id
 }
objRow[conUserCodePrjMainPath.UserId] = objUserCodePrjMainPathEN.UserId; //用户Id
objRow[conUserCodePrjMainPath.IsUsePrjMainPath] = objUserCodePrjMainPathEN.IsUsePrjMainPath; //是否使用主路径
 if (objUserCodePrjMainPathEN.IncludeXmlPath !=  "")
 {
objRow[conUserCodePrjMainPath.IncludeXmlPath] = objUserCodePrjMainPathEN.IncludeXmlPath; //包含表Xml路径
 }
objRow[conUserCodePrjMainPath.IsTemplate] = objUserCodePrjMainPathEN.IsTemplate; //是否模板
objRow[conUserCodePrjMainPath.InUse] = objUserCodePrjMainPathEN.InUse; //是否在用
 if (objUserCodePrjMainPathEN.UpdDate !=  "")
 {
objRow[conUserCodePrjMainPath.UpdDate] = objUserCodePrjMainPathEN.UpdDate; //修改日期
 }
 if (objUserCodePrjMainPathEN.UpdUserId !=  "")
 {
objRow[conUserCodePrjMainPath.UpdUserId] = objUserCodePrjMainPathEN.UpdUserId; //修改用户Id
 }
 if (objUserCodePrjMainPathEN.Memo !=  "")
 {
objRow[conUserCodePrjMainPath.Memo] = objUserCodePrjMainPathEN.Memo; //说明
 }
objDS.Tables[clsUserCodePrjMainPathEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserCodePrjMainPathEN._CurrTabName);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPathEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserCodePrjMainPathEN.UserCodePrjMainPathId  ==  "")
 {
 objUserCodePrjMainPathEN.UserCodePrjMainPathId = null;
 }
 if (objUserCodePrjMainPathEN.UserCodePrjMainPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UserCodePrjMainPathId);
 var strUserCodePrjMainPathId = objUserCodePrjMainPathEN.UserCodePrjMainPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserCodePrjMainPathId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.CMProjectAppRelaId);
 arrValueListForInsert.Add(objUserCodePrjMainPathEN.CMProjectAppRelaId.ToString());
 
 if (objUserCodePrjMainPathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.PrjId);
 var strPrjId = objUserCodePrjMainPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePrjMainPathEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.ProgLangTypeId);
 var strProgLangTypeId = objUserCodePrjMainPathEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objUserCodePrjMainPathEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UserId);
 var strUserId = objUserCodePrjMainPathEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IsUsePrjMainPath);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.IsUsePrjMainPath  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePrjMainPathEN.IncludeXmlPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IncludeXmlPath);
 var strIncludeXmlPath = objUserCodePrjMainPathEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIncludeXmlPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.InUse);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePrjMainPathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UpdDate);
 var strUpdDate = objUserCodePrjMainPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePrjMainPathEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UpdUserId);
 var strUpdUserId = objUserCodePrjMainPathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePrjMainPathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.Memo);
 var strMemo = objUserCodePrjMainPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePrjMainPath");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPathEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserCodePrjMainPathEN.UserCodePrjMainPathId  ==  "")
 {
 objUserCodePrjMainPathEN.UserCodePrjMainPathId = null;
 }
 if (objUserCodePrjMainPathEN.UserCodePrjMainPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UserCodePrjMainPathId);
 var strUserCodePrjMainPathId = objUserCodePrjMainPathEN.UserCodePrjMainPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserCodePrjMainPathId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.CMProjectAppRelaId);
 arrValueListForInsert.Add(objUserCodePrjMainPathEN.CMProjectAppRelaId.ToString());
 
 if (objUserCodePrjMainPathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.PrjId);
 var strPrjId = objUserCodePrjMainPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePrjMainPathEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.ProgLangTypeId);
 var strProgLangTypeId = objUserCodePrjMainPathEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objUserCodePrjMainPathEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UserId);
 var strUserId = objUserCodePrjMainPathEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IsUsePrjMainPath);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.IsUsePrjMainPath  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePrjMainPathEN.IncludeXmlPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IncludeXmlPath);
 var strIncludeXmlPath = objUserCodePrjMainPathEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIncludeXmlPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.InUse);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePrjMainPathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UpdDate);
 var strUpdDate = objUserCodePrjMainPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePrjMainPathEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UpdUserId);
 var strUpdUserId = objUserCodePrjMainPathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePrjMainPathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.Memo);
 var strMemo = objUserCodePrjMainPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePrjMainPath");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objUserCodePrjMainPathEN.UserCodePrjMainPathId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPathEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserCodePrjMainPathEN.UserCodePrjMainPathId  ==  "")
 {
 objUserCodePrjMainPathEN.UserCodePrjMainPathId = null;
 }
 if (objUserCodePrjMainPathEN.UserCodePrjMainPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UserCodePrjMainPathId);
 var strUserCodePrjMainPathId = objUserCodePrjMainPathEN.UserCodePrjMainPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserCodePrjMainPathId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.CMProjectAppRelaId);
 arrValueListForInsert.Add(objUserCodePrjMainPathEN.CMProjectAppRelaId.ToString());
 
 if (objUserCodePrjMainPathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.PrjId);
 var strPrjId = objUserCodePrjMainPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePrjMainPathEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.ProgLangTypeId);
 var strProgLangTypeId = objUserCodePrjMainPathEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objUserCodePrjMainPathEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UserId);
 var strUserId = objUserCodePrjMainPathEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IsUsePrjMainPath);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.IsUsePrjMainPath  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePrjMainPathEN.IncludeXmlPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IncludeXmlPath);
 var strIncludeXmlPath = objUserCodePrjMainPathEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIncludeXmlPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.InUse);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePrjMainPathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UpdDate);
 var strUpdDate = objUserCodePrjMainPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePrjMainPathEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UpdUserId);
 var strUpdUserId = objUserCodePrjMainPathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePrjMainPathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.Memo);
 var strMemo = objUserCodePrjMainPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePrjMainPath");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objUserCodePrjMainPathEN.UserCodePrjMainPathId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPathEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserCodePrjMainPathEN.UserCodePrjMainPathId  ==  "")
 {
 objUserCodePrjMainPathEN.UserCodePrjMainPathId = null;
 }
 if (objUserCodePrjMainPathEN.UserCodePrjMainPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UserCodePrjMainPathId);
 var strUserCodePrjMainPathId = objUserCodePrjMainPathEN.UserCodePrjMainPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserCodePrjMainPathId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.CMProjectAppRelaId);
 arrValueListForInsert.Add(objUserCodePrjMainPathEN.CMProjectAppRelaId.ToString());
 
 if (objUserCodePrjMainPathEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.PrjId);
 var strPrjId = objUserCodePrjMainPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePrjMainPathEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.ProgLangTypeId);
 var strProgLangTypeId = objUserCodePrjMainPathEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objUserCodePrjMainPathEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UserId);
 var strUserId = objUserCodePrjMainPathEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IsUsePrjMainPath);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.IsUsePrjMainPath  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePrjMainPathEN.IncludeXmlPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IncludeXmlPath);
 var strIncludeXmlPath = objUserCodePrjMainPathEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIncludeXmlPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserCodePrjMainPath.InUse);
 arrValueListForInsert.Add("'" + (objUserCodePrjMainPathEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objUserCodePrjMainPathEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UpdDate);
 var strUpdDate = objUserCodePrjMainPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePrjMainPathEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.UpdUserId);
 var strUpdUserId = objUserCodePrjMainPathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePrjMainPathEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath.Memo);
 var strMemo = objUserCodePrjMainPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePrjMainPath");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserCodePrjMainPaths(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where UserCodePrjMainPathId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserCodePrjMainPath");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strUserCodePrjMainPathId = oRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim();
if (IsExist(strUserCodePrjMainPathId))
{
 string strResult = "关键字变量值为:" + string.Format("UserCodePrjMainPathId = {0}", strUserCodePrjMainPathId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserCodePrjMainPathEN._CurrTabName ].NewRow();
objRow[conUserCodePrjMainPath.UserCodePrjMainPathId] = oRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objRow[conUserCodePrjMainPath.CMProjectAppRelaId] = oRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim(); //Cm工程应用关系Id
objRow[conUserCodePrjMainPath.PrjId] = oRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objRow[conUserCodePrjMainPath.ProgLangTypeId] = oRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objRow[conUserCodePrjMainPath.UserId] = oRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objRow[conUserCodePrjMainPath.IsUsePrjMainPath] = oRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim(); //是否使用主路径
objRow[conUserCodePrjMainPath.IncludeXmlPath] = oRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objRow[conUserCodePrjMainPath.IsTemplate] = oRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim(); //是否模板
objRow[conUserCodePrjMainPath.InUse] = oRow[conUserCodePrjMainPath.InUse].ToString().Trim(); //是否在用
objRow[conUserCodePrjMainPath.UpdDate] = oRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objRow[conUserCodePrjMainPath.UpdUserId] = oRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conUserCodePrjMainPath.Memo] = oRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
 objDS.Tables[clsUserCodePrjMainPathEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserCodePrjMainPathEN._CurrTabName);
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
 /// <param name = "objUserCodePrjMainPathEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPathEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath where UserCodePrjMainPathId = " + "'"+ objUserCodePrjMainPathEN.UserCodePrjMainPathId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserCodePrjMainPathEN._CurrTabName);
if (objDS.Tables[clsUserCodePrjMainPathEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:UserCodePrjMainPathId = " + "'"+ objUserCodePrjMainPathEN.UserCodePrjMainPathId+"'");
return false;
}
objRow = objDS.Tables[clsUserCodePrjMainPathEN._CurrTabName].Rows[0];
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UserCodePrjMainPathId))
 {
objRow[conUserCodePrjMainPath.UserCodePrjMainPathId] = objUserCodePrjMainPathEN.UserCodePrjMainPathId; //生成主目录Id
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.CMProjectAppRelaId))
 {
objRow[conUserCodePrjMainPath.CMProjectAppRelaId] = objUserCodePrjMainPathEN.CMProjectAppRelaId; //Cm工程应用关系Id
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.PrjId))
 {
objRow[conUserCodePrjMainPath.PrjId] = objUserCodePrjMainPathEN.PrjId; //工程Id
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.ProgLangTypeId))
 {
objRow[conUserCodePrjMainPath.ProgLangTypeId] = objUserCodePrjMainPathEN.ProgLangTypeId; //编程语言类型Id
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UserId))
 {
objRow[conUserCodePrjMainPath.UserId] = objUserCodePrjMainPathEN.UserId; //用户Id
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsUsePrjMainPath))
 {
objRow[conUserCodePrjMainPath.IsUsePrjMainPath] = objUserCodePrjMainPathEN.IsUsePrjMainPath; //是否使用主路径
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IncludeXmlPath))
 {
objRow[conUserCodePrjMainPath.IncludeXmlPath] = objUserCodePrjMainPathEN.IncludeXmlPath; //包含表Xml路径
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsTemplate))
 {
objRow[conUserCodePrjMainPath.IsTemplate] = objUserCodePrjMainPathEN.IsTemplate; //是否模板
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.InUse))
 {
objRow[conUserCodePrjMainPath.InUse] = objUserCodePrjMainPathEN.InUse; //是否在用
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdDate))
 {
objRow[conUserCodePrjMainPath.UpdDate] = objUserCodePrjMainPathEN.UpdDate; //修改日期
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdUserId))
 {
objRow[conUserCodePrjMainPath.UpdUserId] = objUserCodePrjMainPathEN.UpdUserId; //修改用户Id
 }
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.Memo))
 {
objRow[conUserCodePrjMainPath.Memo] = objUserCodePrjMainPathEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsUserCodePrjMainPathEN._CurrTabName);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserCodePrjMainPath Set ");
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.CMProjectAppRelaId))
 {
 sbSQL.AppendFormat("{1} = {0},",objUserCodePrjMainPathEN.CMProjectAppRelaId, conUserCodePrjMainPath.CMProjectAppRelaId); //Cm工程应用关系Id
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.PrjId))
 {
 if (objUserCodePrjMainPathEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePrjMainPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUserCodePrjMainPath.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.PrjId); //工程Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.ProgLangTypeId))
 {
 if (objUserCodePrjMainPathEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objUserCodePrjMainPathEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conUserCodePrjMainPath.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UserId))
 {
 if (objUserCodePrjMainPathEN.UserId !=  null)
 {
 var strUserId = objUserCodePrjMainPathEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserCodePrjMainPath.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.UserId); //用户Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsUsePrjMainPath))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePrjMainPathEN.IsUsePrjMainPath == true?"1":"0", conUserCodePrjMainPath.IsUsePrjMainPath); //是否使用主路径
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IncludeXmlPath))
 {
 if (objUserCodePrjMainPathEN.IncludeXmlPath !=  null)
 {
 var strIncludeXmlPath = objUserCodePrjMainPathEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIncludeXmlPath, conUserCodePrjMainPath.IncludeXmlPath); //包含表Xml路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.IncludeXmlPath); //包含表Xml路径
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePrjMainPathEN.IsTemplate == true?"1":"0", conUserCodePrjMainPath.IsTemplate); //是否模板
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePrjMainPathEN.InUse == true?"1":"0", conUserCodePrjMainPath.InUse); //是否在用
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdDate))
 {
 if (objUserCodePrjMainPathEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePrjMainPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserCodePrjMainPath.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.UpdDate); //修改日期
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdUserId))
 {
 if (objUserCodePrjMainPathEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePrjMainPathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conUserCodePrjMainPath.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.UpdUserId); //修改用户Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.Memo))
 {
 if (objUserCodePrjMainPathEN.Memo !=  null)
 {
 var strMemo = objUserCodePrjMainPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserCodePrjMainPath.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPathEN.UserCodePrjMainPathId); 
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
 /// <param name = "objUserCodePrjMainPathEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strCondition)
{
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserCodePrjMainPath Set ");
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.CMProjectAppRelaId))
 {
 sbSQL.AppendFormat(" CMProjectAppRelaId = {0},", objUserCodePrjMainPathEN.CMProjectAppRelaId); //Cm工程应用关系Id
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.PrjId))
 {
 if (objUserCodePrjMainPathEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePrjMainPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.ProgLangTypeId))
 {
 if (objUserCodePrjMainPathEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objUserCodePrjMainPathEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UserId))
 {
 if (objUserCodePrjMainPathEN.UserId !=  null)
 {
 var strUserId = objUserCodePrjMainPathEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsUsePrjMainPath))
 {
 sbSQL.AppendFormat(" IsUsePrjMainPath = '{0}',", objUserCodePrjMainPathEN.IsUsePrjMainPath == true?"1":"0"); //是否使用主路径
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IncludeXmlPath))
 {
 if (objUserCodePrjMainPathEN.IncludeXmlPath !=  null)
 {
 var strIncludeXmlPath = objUserCodePrjMainPathEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IncludeXmlPath = '{0}',", strIncludeXmlPath); //包含表Xml路径
 }
 else
 {
 sbSQL.Append(" IncludeXmlPath = null,"); //包含表Xml路径
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objUserCodePrjMainPathEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objUserCodePrjMainPathEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdDate))
 {
 if (objUserCodePrjMainPathEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePrjMainPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdUserId))
 {
 if (objUserCodePrjMainPathEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePrjMainPathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.Memo))
 {
 if (objUserCodePrjMainPathEN.Memo !=  null)
 {
 var strMemo = objUserCodePrjMainPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserCodePrjMainPathEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserCodePrjMainPath Set ");
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.CMProjectAppRelaId))
 {
 sbSQL.AppendFormat(" CMProjectAppRelaId = {0},", objUserCodePrjMainPathEN.CMProjectAppRelaId); //Cm工程应用关系Id
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.PrjId))
 {
 if (objUserCodePrjMainPathEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePrjMainPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.ProgLangTypeId))
 {
 if (objUserCodePrjMainPathEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objUserCodePrjMainPathEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UserId))
 {
 if (objUserCodePrjMainPathEN.UserId !=  null)
 {
 var strUserId = objUserCodePrjMainPathEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsUsePrjMainPath))
 {
 sbSQL.AppendFormat(" IsUsePrjMainPath = '{0}',", objUserCodePrjMainPathEN.IsUsePrjMainPath == true?"1":"0"); //是否使用主路径
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IncludeXmlPath))
 {
 if (objUserCodePrjMainPathEN.IncludeXmlPath !=  null)
 {
 var strIncludeXmlPath = objUserCodePrjMainPathEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IncludeXmlPath = '{0}',", strIncludeXmlPath); //包含表Xml路径
 }
 else
 {
 sbSQL.Append(" IncludeXmlPath = null,"); //包含表Xml路径
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objUserCodePrjMainPathEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objUserCodePrjMainPathEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdDate))
 {
 if (objUserCodePrjMainPathEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePrjMainPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdUserId))
 {
 if (objUserCodePrjMainPathEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePrjMainPathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.Memo))
 {
 if (objUserCodePrjMainPathEN.Memo !=  null)
 {
 var strMemo = objUserCodePrjMainPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPathEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPathEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserCodePrjMainPath Set ");
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.CMProjectAppRelaId))
 {
 sbSQL.AppendFormat("{1} = {0},",objUserCodePrjMainPathEN.CMProjectAppRelaId, conUserCodePrjMainPath.CMProjectAppRelaId); //Cm工程应用关系Id
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.PrjId))
 {
 if (objUserCodePrjMainPathEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePrjMainPathEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUserCodePrjMainPath.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.PrjId); //工程Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.ProgLangTypeId))
 {
 if (objUserCodePrjMainPathEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objUserCodePrjMainPathEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conUserCodePrjMainPath.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UserId))
 {
 if (objUserCodePrjMainPathEN.UserId !=  null)
 {
 var strUserId = objUserCodePrjMainPathEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserCodePrjMainPath.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.UserId); //用户Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsUsePrjMainPath))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePrjMainPathEN.IsUsePrjMainPath == true?"1":"0", conUserCodePrjMainPath.IsUsePrjMainPath); //是否使用主路径
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IncludeXmlPath))
 {
 if (objUserCodePrjMainPathEN.IncludeXmlPath !=  null)
 {
 var strIncludeXmlPath = objUserCodePrjMainPathEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIncludeXmlPath, conUserCodePrjMainPath.IncludeXmlPath); //包含表Xml路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.IncludeXmlPath); //包含表Xml路径
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePrjMainPathEN.IsTemplate == true?"1":"0", conUserCodePrjMainPath.IsTemplate); //是否模板
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserCodePrjMainPathEN.InUse == true?"1":"0", conUserCodePrjMainPath.InUse); //是否在用
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdDate))
 {
 if (objUserCodePrjMainPathEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePrjMainPathEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserCodePrjMainPath.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.UpdDate); //修改日期
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.UpdUserId))
 {
 if (objUserCodePrjMainPathEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePrjMainPathEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conUserCodePrjMainPath.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.UpdUserId); //修改用户Id
 }
 }
 
 if (objUserCodePrjMainPathEN.IsUpdated(conUserCodePrjMainPath.Memo))
 {
 if (objUserCodePrjMainPathEN.Memo !=  null)
 {
 var strMemo = objUserCodePrjMainPathEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserCodePrjMainPath.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPathEN.UserCodePrjMainPathId); 
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
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strUserCodePrjMainPathId) 
{
CheckPrimaryKey(strUserCodePrjMainPathId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strUserCodePrjMainPathId,
};
 objSQL.ExecSP("UserCodePrjMainPath_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strUserCodePrjMainPathId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strUserCodePrjMainPathId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
//删除UserCodePrjMainPath本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserCodePrjMainPath where UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUserCodePrjMainPath(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
//删除UserCodePrjMainPath本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserCodePrjMainPath where UserCodePrjMainPathId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strUserCodePrjMainPathId) 
{
CheckPrimaryKey(strUserCodePrjMainPathId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
//删除UserCodePrjMainPath本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserCodePrjMainPath where UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserCodePrjMainPath(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: DelUserCodePrjMainPath)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserCodePrjMainPath where " + strCondition ;
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
public bool DelUserCodePrjMainPathWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserCodePrjMainPathDA: DelUserCodePrjMainPathWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserCodePrjMainPath where " + strCondition ;
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
 /// <param name = "objUserCodePrjMainPathENS">源对象</param>
 /// <param name = "objUserCodePrjMainPathENT">目标对象</param>
public void CopyTo(clsUserCodePrjMainPathEN objUserCodePrjMainPathENS, clsUserCodePrjMainPathEN objUserCodePrjMainPathENT)
{
objUserCodePrjMainPathENT.UserCodePrjMainPathId = objUserCodePrjMainPathENS.UserCodePrjMainPathId; //生成主目录Id
objUserCodePrjMainPathENT.CMProjectAppRelaId = objUserCodePrjMainPathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objUserCodePrjMainPathENT.PrjId = objUserCodePrjMainPathENS.PrjId; //工程Id
objUserCodePrjMainPathENT.ProgLangTypeId = objUserCodePrjMainPathENS.ProgLangTypeId; //编程语言类型Id
objUserCodePrjMainPathENT.UserId = objUserCodePrjMainPathENS.UserId; //用户Id
objUserCodePrjMainPathENT.IsUsePrjMainPath = objUserCodePrjMainPathENS.IsUsePrjMainPath; //是否使用主路径
objUserCodePrjMainPathENT.IncludeXmlPath = objUserCodePrjMainPathENS.IncludeXmlPath; //包含表Xml路径
objUserCodePrjMainPathENT.IsTemplate = objUserCodePrjMainPathENS.IsTemplate; //是否模板
objUserCodePrjMainPathENT.InUse = objUserCodePrjMainPathENS.InUse; //是否在用
objUserCodePrjMainPathENT.UpdDate = objUserCodePrjMainPathENS.UpdDate; //修改日期
objUserCodePrjMainPathENT.UpdUserId = objUserCodePrjMainPathENS.UpdUserId; //修改用户Id
objUserCodePrjMainPathENT.Memo = objUserCodePrjMainPathENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserCodePrjMainPathEN.CMProjectAppRelaId, conUserCodePrjMainPath.CMProjectAppRelaId);
clsCheckSql.CheckFieldNotNull(objUserCodePrjMainPathEN.PrjId, conUserCodePrjMainPath.PrjId);
clsCheckSql.CheckFieldNotNull(objUserCodePrjMainPathEN.UserId, conUserCodePrjMainPath.UserId);
clsCheckSql.CheckFieldNotNull(objUserCodePrjMainPathEN.IsUsePrjMainPath, conUserCodePrjMainPath.IsUsePrjMainPath);
clsCheckSql.CheckFieldNotNull(objUserCodePrjMainPathEN.IsTemplate, conUserCodePrjMainPath.IsTemplate);
clsCheckSql.CheckFieldNotNull(objUserCodePrjMainPathEN.InUse, conUserCodePrjMainPath.InUse);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath.UserCodePrjMainPathId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.PrjId, 4, conUserCodePrjMainPath.PrjId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.ProgLangTypeId, 2, conUserCodePrjMainPath.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UserId, 18, conUserCodePrjMainPath.UserId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.IncludeXmlPath, 150, conUserCodePrjMainPath.IncludeXmlPath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UpdDate, 20, conUserCodePrjMainPath.UpdDate);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UpdUserId, 20, conUserCodePrjMainPath.UpdUserId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.Memo, 1000, conUserCodePrjMainPath.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objUserCodePrjMainPathEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath.UserCodePrjMainPathId);
 objUserCodePrjMainPathEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.PrjId, 4, conUserCodePrjMainPath.PrjId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.ProgLangTypeId, 2, conUserCodePrjMainPath.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UserId, 18, conUserCodePrjMainPath.UserId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.IncludeXmlPath, 150, conUserCodePrjMainPath.IncludeXmlPath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UpdDate, 20, conUserCodePrjMainPath.UpdDate);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UpdUserId, 20, conUserCodePrjMainPath.UpdUserId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.Memo, 1000, conUserCodePrjMainPath.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserCodePrjMainPathEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath.UserCodePrjMainPathId);
 objUserCodePrjMainPathEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath.UserCodePrjMainPathId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.PrjId, 4, conUserCodePrjMainPath.PrjId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.ProgLangTypeId, 2, conUserCodePrjMainPath.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UserId, 18, conUserCodePrjMainPath.UserId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.IncludeXmlPath, 150, conUserCodePrjMainPath.IncludeXmlPath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UpdDate, 20, conUserCodePrjMainPath.UpdDate);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.UpdUserId, 20, conUserCodePrjMainPath.UpdUserId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPathEN.Memo, 1000, conUserCodePrjMainPath.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPathEN.UserCodePrjMainPathId, conUserCodePrjMainPath.UserCodePrjMainPathId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPathEN.PrjId, conUserCodePrjMainPath.PrjId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPathEN.ProgLangTypeId, conUserCodePrjMainPath.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPathEN.UserId, conUserCodePrjMainPath.UserId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPathEN.IncludeXmlPath, conUserCodePrjMainPath.IncludeXmlPath);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPathEN.UpdDate, conUserCodePrjMainPath.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPathEN.UpdUserId, conUserCodePrjMainPath.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPathEN.Memo, conUserCodePrjMainPath.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserCodePrjMainPathEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath.UserCodePrjMainPathId);
 objUserCodePrjMainPathEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UserCodePrjMainPath(用户生成项目主路径),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePrjMainPathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserCodePrjMainPathEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserCodePrjMainPathEN.UserId);
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
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserCodePrjMainPathEN._CurrTabName);
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
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserCodePrjMainPathEN._CurrTabName, strCondition);
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
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
 objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}