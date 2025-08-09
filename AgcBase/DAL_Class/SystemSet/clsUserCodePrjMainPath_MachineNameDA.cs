
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePrjMainPath_MachineNameDA
 表名:UserCodePrjMainPath_MachineName(00050614)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:29
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
 /// 用户生成项目主路径_PC(UserCodePrjMainPath_MachineName)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserCodePrjMainPath_MachineNameDA : clsCommBase4DA
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
 return clsUserCodePrjMainPath_MachineNameEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserCodePrjMainPath_MachineNameEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserCodePrjMainPath_MachineNameEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserCodePrjMainPath_MachineNameEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserCodePrjMainPath_MachineNameEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:UserCodePrjMainPath_MachineName中,检查关键字,长度不正确!(clsUserCodePrjMainPath_MachineNameDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserCodePrjMainPathId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:UserCodePrjMainPath_MachineName中,关键字不能为空 或 null!(clsUserCodePrjMainPath_MachineNameDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserCodePrjMainPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsUserCodePrjMainPath_MachineNameDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserCodePrjMainPath_MachineName(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetDataTable_UserCodePrjMainPath_MachineName)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath_MachineName where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath_MachineName where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath_MachineName where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserCodePrjMainPath_MachineName.* " + 
$"from UserCodePrjMainPath_MachineName " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserCodePrjMainPath_MachineName.UserCodePrjMainPathId not in " + 
$"(Select top {intTop_In} UserCodePrjMainPath_MachineName.UserCodePrjMainPathId from UserCodePrjMainPath_MachineName " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath_MachineName where {1} and UserCodePrjMainPathId not in (Select top {2} UserCodePrjMainPathId from UserCodePrjMainPath_MachineName where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath_MachineName where {1} and UserCodePrjMainPathId not in (Select top {3} UserCodePrjMainPathId from UserCodePrjMainPath_MachineName where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserCodePrjMainPath_MachineName.* " + 
$"from UserCodePrjMainPath_MachineName " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserCodePrjMainPath_MachineName.UserCodePrjMainPathId not in " + 
$"(Select top {intTop_In} UserCodePrjMainPath_MachineName.UserCodePrjMainPathId from UserCodePrjMainPath_MachineName " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath_MachineName where {1} and UserCodePrjMainPathId not in (Select top {2} UserCodePrjMainPathId from UserCodePrjMainPath_MachineName where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserCodePrjMainPath_MachineName where {1} and UserCodePrjMainPathId not in (Select top {3} UserCodePrjMainPathId from UserCodePrjMainPath_MachineName where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserCodePrjMainPath_MachineNameEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA:GetObjLst)", objException.Message));
}
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetObjLst)", objException.Message));
}
objUserCodePrjMainPath_MachineNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
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
public List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetObjLst)", objException.Message));
}
objUserCodePrjMainPath_MachineNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserCodePrjMainPath_MachineName(ref clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where UserCodePrjMainPathId = " + "'"+ objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId+"'" + " and MachineName = " + "'"+ objUserCodePrjMainPath_MachineNameEN.MachineName+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objDT.Rows[0][conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id(字段类型:char,字段长度:8,是否可空:False)
 objUserCodePrjMainPath_MachineNameEN.MachineName = objDT.Rows[0][conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名(字段类型:varchar,字段长度:50,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.CodePath = objDT.Rows[0][conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePrjMainPath_MachineNameEN.GcPathId = objDT.Rows[0][conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id(字段类型:char,字段长度:8,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objDT.Rows[0][conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePrjMainPath_MachineNameEN.LogPath = objDT.Rows[0][conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径(字段类型:varchar,字段长度:150,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objDT.Rows[0][conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径(字段类型:varchar,字段长度:150,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.PrjId = objDT.Rows[0][conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUserCodePrjMainPath_MachineNameEN.UpdDate = objDT.Rows[0][conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.UpdUserId = objDT.Rows[0][conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.Memo = objDT.Rows[0][conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetUserCodePrjMainPath_MachineName)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strMachineName">表关键字</param>
 /// <returns>表对象</returns>
public clsUserCodePrjMainPath_MachineNameEN GetObjByKeyLst(string strUserCodePrjMainPathId,string strMachineName)
{
CheckPrimaryKey(strUserCodePrjMainPathId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'" + " and MachineName = " + "'"+ strMachineName+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
 objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id(字段类型:char,字段长度:8,是否可空:False)
 objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名(字段类型:varchar,字段长度:50,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id(字段类型:char,字段长度:8,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径(字段类型:varchar,字段长度:200,是否可空:False)
 objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径(字段类型:varchar,字段长度:150,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径(字段类型:varchar,字段长度:150,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetObjByKeyLst)", objException.Message));
}
return objUserCodePrjMainPath_MachineNameEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserCodePrjMainPath_MachineNameEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN()
{
UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(), //生成主目录Id
MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(), //机器名
CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(), //代码路径
GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(), //GC路径Id
CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(), //备份代码路径
LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(), //日志路径
IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(), //包含表Xml路径
PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim() //说明
};
objUserCodePrjMainPath_MachineNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserCodePrjMainPath_MachineNameEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserCodePrjMainPath_MachineNameEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetObjByDataRowUserCodePrjMainPath_MachineName)", objException.Message));
}
objUserCodePrjMainPath_MachineNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserCodePrjMainPath_MachineNameEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserCodePrjMainPath_MachineNameEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: GetObjByDataRow)", objException.Message));
}
objUserCodePrjMainPath_MachineNameEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserCodePrjMainPath_MachineNameEN;
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
objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserCodePrjMainPath_MachineNameEN._CurrTabName, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, 8, "");
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
objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserCodePrjMainPath_MachineNameEN._CurrTabName, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, 8, strPrefix);
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
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserCodePrjMainPathId,MachineName from UserCodePrjMainPath_MachineName where " + strCondition;
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
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserCodePrjMainPathId,MachineName from UserCodePrjMainPath_MachineName where " + strCondition;
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
public bool IsExist(string strUserCodePrjMainPathId, string strMachineName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserCodePrjMainPath_MachineName", "UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'" + " and MachineName = " + "'"+ strMachineName+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserCodePrjMainPath_MachineName", strCondition))
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
objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserCodePrjMainPath_MachineName");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
 {
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserCodePrjMainPath_MachineName");
objRow = objDS.Tables["UserCodePrjMainPath_MachineName"].NewRow();
objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId] = objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId; //生成主目录Id
objRow[conUserCodePrjMainPath_MachineName.MachineName] = objUserCodePrjMainPath_MachineNameEN.MachineName; //机器名
objRow[conUserCodePrjMainPath_MachineName.CodePath] = objUserCodePrjMainPath_MachineNameEN.CodePath; //代码路径
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId !=  "")
 {
objRow[conUserCodePrjMainPath_MachineName.GcPathId] = objUserCodePrjMainPath_MachineNameEN.GcPathId; //GC路径Id
 }
objRow[conUserCodePrjMainPath_MachineName.CodePathBackup] = objUserCodePrjMainPath_MachineNameEN.CodePathBackup; //备份代码路径
 if (objUserCodePrjMainPath_MachineNameEN.LogPath !=  "")
 {
objRow[conUserCodePrjMainPath_MachineName.LogPath] = objUserCodePrjMainPath_MachineNameEN.LogPath; //日志路径
 }
 if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath !=  "")
 {
objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath; //包含表Xml路径
 }
objRow[conUserCodePrjMainPath_MachineName.PrjId] = objUserCodePrjMainPath_MachineNameEN.PrjId; //工程Id
 if (objUserCodePrjMainPath_MachineNameEN.UpdDate !=  "")
 {
objRow[conUserCodePrjMainPath_MachineName.UpdDate] = objUserCodePrjMainPath_MachineNameEN.UpdDate; //修改日期
 }
 if (objUserCodePrjMainPath_MachineNameEN.UpdUserId !=  "")
 {
objRow[conUserCodePrjMainPath_MachineName.UpdUserId] = objUserCodePrjMainPath_MachineNameEN.UpdUserId; //修改用户Id
 }
 if (objUserCodePrjMainPath_MachineNameEN.Memo !=  "")
 {
objRow[conUserCodePrjMainPath_MachineName.Memo] = objUserCodePrjMainPath_MachineNameEN.Memo; //说明
 }
objDS.Tables[clsUserCodePrjMainPath_MachineNameEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserCodePrjMainPath_MachineNameEN._CurrTabName);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
 var strUserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserCodePrjMainPathId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.MachineName !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.MachineName);
 var strMachineName = objUserCodePrjMainPath_MachineNameEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMachineName + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.CodePath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.CodePath);
 var strCodePath = objUserCodePrjMainPath_MachineNameEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.GcPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.GcPathId);
 var strGcPathId = objUserCodePrjMainPath_MachineNameEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.CodePathBackup !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.CodePathBackup);
 var strCodePathBackup = objUserCodePrjMainPath_MachineNameEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePathBackup + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.LogPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.LogPath);
 var strLogPath = objUserCodePrjMainPath_MachineNameEN.LogPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogPath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.IncludeXmlPath);
 var strIncludeXmlPath = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIncludeXmlPath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.PrjId);
 var strPrjId = objUserCodePrjMainPath_MachineNameEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UpdDate);
 var strUpdDate = objUserCodePrjMainPath_MachineNameEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UpdUserId);
 var strUpdUserId = objUserCodePrjMainPath_MachineNameEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.Memo);
 var strMemo = objUserCodePrjMainPath_MachineNameEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePrjMainPath_MachineName");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
 var strUserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserCodePrjMainPathId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.MachineName !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.MachineName);
 var strMachineName = objUserCodePrjMainPath_MachineNameEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMachineName + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.CodePath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.CodePath);
 var strCodePath = objUserCodePrjMainPath_MachineNameEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.GcPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.GcPathId);
 var strGcPathId = objUserCodePrjMainPath_MachineNameEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.CodePathBackup !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.CodePathBackup);
 var strCodePathBackup = objUserCodePrjMainPath_MachineNameEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePathBackup + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.LogPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.LogPath);
 var strLogPath = objUserCodePrjMainPath_MachineNameEN.LogPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogPath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.IncludeXmlPath);
 var strIncludeXmlPath = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIncludeXmlPath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.PrjId);
 var strPrjId = objUserCodePrjMainPath_MachineNameEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UpdDate);
 var strUpdDate = objUserCodePrjMainPath_MachineNameEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UpdUserId);
 var strUpdUserId = objUserCodePrjMainPath_MachineNameEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.Memo);
 var strMemo = objUserCodePrjMainPath_MachineNameEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePrjMainPath_MachineName");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
 var strUserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserCodePrjMainPathId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.MachineName !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.MachineName);
 var strMachineName = objUserCodePrjMainPath_MachineNameEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMachineName + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.CodePath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.CodePath);
 var strCodePath = objUserCodePrjMainPath_MachineNameEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.GcPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.GcPathId);
 var strGcPathId = objUserCodePrjMainPath_MachineNameEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.CodePathBackup !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.CodePathBackup);
 var strCodePathBackup = objUserCodePrjMainPath_MachineNameEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePathBackup + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.LogPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.LogPath);
 var strLogPath = objUserCodePrjMainPath_MachineNameEN.LogPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogPath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.IncludeXmlPath);
 var strIncludeXmlPath = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIncludeXmlPath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.PrjId);
 var strPrjId = objUserCodePrjMainPath_MachineNameEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UpdDate);
 var strUpdDate = objUserCodePrjMainPath_MachineNameEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UpdUserId);
 var strUpdUserId = objUserCodePrjMainPath_MachineNameEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.Memo);
 var strMemo = objUserCodePrjMainPath_MachineNameEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePrjMainPath_MachineName");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
 var strUserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserCodePrjMainPathId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.MachineName !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.MachineName);
 var strMachineName = objUserCodePrjMainPath_MachineNameEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMachineName + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.CodePath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.CodePath);
 var strCodePath = objUserCodePrjMainPath_MachineNameEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.GcPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.GcPathId);
 var strGcPathId = objUserCodePrjMainPath_MachineNameEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.CodePathBackup !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.CodePathBackup);
 var strCodePathBackup = objUserCodePrjMainPath_MachineNameEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodePathBackup + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.LogPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.LogPath);
 var strLogPath = objUserCodePrjMainPath_MachineNameEN.LogPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogPath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.IncludeXmlPath);
 var strIncludeXmlPath = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIncludeXmlPath + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.PrjId);
 var strPrjId = objUserCodePrjMainPath_MachineNameEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UpdDate);
 var strUpdDate = objUserCodePrjMainPath_MachineNameEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.UpdUserId);
 var strUpdUserId = objUserCodePrjMainPath_MachineNameEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserCodePrjMainPath_MachineName.Memo);
 var strMemo = objUserCodePrjMainPath_MachineNameEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserCodePrjMainPath_MachineName");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserCodePrjMainPath_MachineNames(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where UserCodePrjMainPathId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserCodePrjMainPath_MachineName");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strUserCodePrjMainPathId = oRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim();
string strMachineName = oRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim();
if (IsExist(strUserCodePrjMainPathId,strMachineName))
{
 string strResult = "关键字变量值为:" + string.Format("UserCodePrjMainPathId = {0},MachineName = {1}", strUserCodePrjMainPathId,strMachineName) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserCodePrjMainPath_MachineNameEN._CurrTabName ].NewRow();
objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId] = oRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objRow[conUserCodePrjMainPath_MachineName.MachineName] = oRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objRow[conUserCodePrjMainPath_MachineName.CodePath] = oRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objRow[conUserCodePrjMainPath_MachineName.GcPathId] = oRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objRow[conUserCodePrjMainPath_MachineName.CodePathBackup] = oRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objRow[conUserCodePrjMainPath_MachineName.LogPath] = oRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] = oRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objRow[conUserCodePrjMainPath_MachineName.PrjId] = oRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objRow[conUserCodePrjMainPath_MachineName.UpdDate] = oRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objRow[conUserCodePrjMainPath_MachineName.UpdUserId] = oRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conUserCodePrjMainPath_MachineName.Memo] = oRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
 objDS.Tables[clsUserCodePrjMainPath_MachineNameEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserCodePrjMainPath_MachineNameEN._CurrTabName);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPath_MachineNameEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
strSQL = "Select * from UserCodePrjMainPath_MachineName where UserCodePrjMainPathId = " + "'"+ objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId+"'" + " and MachineName = " + "'"+ objUserCodePrjMainPath_MachineNameEN.MachineName+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserCodePrjMainPath_MachineNameEN._CurrTabName);
if (objDS.Tables[clsUserCodePrjMainPath_MachineNameEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:UserCodePrjMainPathId = " + "'"+ objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId+"'" + " and MachineName = " + "'"+ objUserCodePrjMainPath_MachineNameEN.MachineName+"'");
return false;
}
objRow = objDS.Tables[clsUserCodePrjMainPath_MachineNameEN._CurrTabName].Rows[0];
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId))
 {
objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId] = objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId; //生成主目录Id
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.MachineName))
 {
objRow[conUserCodePrjMainPath_MachineName.MachineName] = objUserCodePrjMainPath_MachineNameEN.MachineName; //机器名
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePath))
 {
objRow[conUserCodePrjMainPath_MachineName.CodePath] = objUserCodePrjMainPath_MachineNameEN.CodePath; //代码路径
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.GcPathId))
 {
objRow[conUserCodePrjMainPath_MachineName.GcPathId] = objUserCodePrjMainPath_MachineNameEN.GcPathId; //GC路径Id
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePathBackup))
 {
objRow[conUserCodePrjMainPath_MachineName.CodePathBackup] = objUserCodePrjMainPath_MachineNameEN.CodePathBackup; //备份代码路径
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.LogPath))
 {
objRow[conUserCodePrjMainPath_MachineName.LogPath] = objUserCodePrjMainPath_MachineNameEN.LogPath; //日志路径
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.IncludeXmlPath))
 {
objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath; //包含表Xml路径
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.PrjId))
 {
objRow[conUserCodePrjMainPath_MachineName.PrjId] = objUserCodePrjMainPath_MachineNameEN.PrjId; //工程Id
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdDate))
 {
objRow[conUserCodePrjMainPath_MachineName.UpdDate] = objUserCodePrjMainPath_MachineNameEN.UpdDate; //修改日期
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdUserId))
 {
objRow[conUserCodePrjMainPath_MachineName.UpdUserId] = objUserCodePrjMainPath_MachineNameEN.UpdUserId; //修改用户Id
 }
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.Memo))
 {
objRow[conUserCodePrjMainPath_MachineName.Memo] = objUserCodePrjMainPath_MachineNameEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsUserCodePrjMainPath_MachineNameEN._CurrTabName);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPath_MachineNameEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserCodePrjMainPath_MachineName Set ");
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.CodePath !=  null)
 {
 var strCodePath = objUserCodePrjMainPath_MachineNameEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodePath, conUserCodePrjMainPath_MachineName.CodePath); //代码路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.CodePath); //代码路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.GcPathId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.GcPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId !=  null)
 {
 var strGcPathId = objUserCodePrjMainPath_MachineNameEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcPathId, conUserCodePrjMainPath_MachineName.GcPathId); //GC路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.GcPathId); //GC路径Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePathBackup))
 {
 if (objUserCodePrjMainPath_MachineNameEN.CodePathBackup !=  null)
 {
 var strCodePathBackup = objUserCodePrjMainPath_MachineNameEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodePathBackup, conUserCodePrjMainPath_MachineName.CodePathBackup); //备份代码路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.CodePathBackup); //备份代码路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.LogPath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.LogPath !=  null)
 {
 var strLogPath = objUserCodePrjMainPath_MachineNameEN.LogPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogPath, conUserCodePrjMainPath_MachineName.LogPath); //日志路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.LogPath); //日志路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.IncludeXmlPath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath !=  null)
 {
 var strIncludeXmlPath = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIncludeXmlPath, conUserCodePrjMainPath_MachineName.IncludeXmlPath); //包含表Xml路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.IncludeXmlPath); //包含表Xml路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.PrjId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePrjMainPath_MachineNameEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUserCodePrjMainPath_MachineName.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.PrjId); //工程Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdDate))
 {
 if (objUserCodePrjMainPath_MachineNameEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePrjMainPath_MachineNameEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserCodePrjMainPath_MachineName.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.UpdDate); //修改日期
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdUserId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePrjMainPath_MachineNameEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conUserCodePrjMainPath_MachineName.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.UpdUserId); //修改用户Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.Memo))
 {
 if (objUserCodePrjMainPath_MachineNameEN.Memo !=  null)
 {
 var strMemo = objUserCodePrjMainPath_MachineNameEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserCodePrjMainPath_MachineName.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserCodePrjMainPathId = '{0}' And MachineName = '{1}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName); 
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strCondition)
{
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPath_MachineNameEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserCodePrjMainPath_MachineName Set ");
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.CodePath !=  null)
 {
 var strCodePath = objUserCodePrjMainPath_MachineNameEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodePath = '{0}',", strCodePath); //代码路径
 }
 else
 {
 sbSQL.Append(" CodePath = null,"); //代码路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.GcPathId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.GcPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId !=  null)
 {
 var strGcPathId = objUserCodePrjMainPath_MachineNameEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcPathId = '{0}',", strGcPathId); //GC路径Id
 }
 else
 {
 sbSQL.Append(" GcPathId = null,"); //GC路径Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePathBackup))
 {
 if (objUserCodePrjMainPath_MachineNameEN.CodePathBackup !=  null)
 {
 var strCodePathBackup = objUserCodePrjMainPath_MachineNameEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodePathBackup = '{0}',", strCodePathBackup); //备份代码路径
 }
 else
 {
 sbSQL.Append(" CodePathBackup = null,"); //备份代码路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.LogPath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.LogPath !=  null)
 {
 var strLogPath = objUserCodePrjMainPath_MachineNameEN.LogPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogPath = '{0}',", strLogPath); //日志路径
 }
 else
 {
 sbSQL.Append(" LogPath = null,"); //日志路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.IncludeXmlPath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath !=  null)
 {
 var strIncludeXmlPath = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IncludeXmlPath = '{0}',", strIncludeXmlPath); //包含表Xml路径
 }
 else
 {
 sbSQL.Append(" IncludeXmlPath = null,"); //包含表Xml路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.PrjId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePrjMainPath_MachineNameEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdDate))
 {
 if (objUserCodePrjMainPath_MachineNameEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePrjMainPath_MachineNameEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdUserId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePrjMainPath_MachineNameEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.Memo))
 {
 if (objUserCodePrjMainPath_MachineNameEN.Memo !=  null)
 {
 var strMemo = objUserCodePrjMainPath_MachineNameEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPath_MachineNameEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserCodePrjMainPath_MachineName Set ");
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.CodePath !=  null)
 {
 var strCodePath = objUserCodePrjMainPath_MachineNameEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodePath = '{0}',", strCodePath); //代码路径
 }
 else
 {
 sbSQL.Append(" CodePath = null,"); //代码路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.GcPathId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.GcPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId !=  null)
 {
 var strGcPathId = objUserCodePrjMainPath_MachineNameEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcPathId = '{0}',", strGcPathId); //GC路径Id
 }
 else
 {
 sbSQL.Append(" GcPathId = null,"); //GC路径Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePathBackup))
 {
 if (objUserCodePrjMainPath_MachineNameEN.CodePathBackup !=  null)
 {
 var strCodePathBackup = objUserCodePrjMainPath_MachineNameEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodePathBackup = '{0}',", strCodePathBackup); //备份代码路径
 }
 else
 {
 sbSQL.Append(" CodePathBackup = null,"); //备份代码路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.LogPath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.LogPath !=  null)
 {
 var strLogPath = objUserCodePrjMainPath_MachineNameEN.LogPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogPath = '{0}',", strLogPath); //日志路径
 }
 else
 {
 sbSQL.Append(" LogPath = null,"); //日志路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.IncludeXmlPath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath !=  null)
 {
 var strIncludeXmlPath = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IncludeXmlPath = '{0}',", strIncludeXmlPath); //包含表Xml路径
 }
 else
 {
 sbSQL.Append(" IncludeXmlPath = null,"); //包含表Xml路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.PrjId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePrjMainPath_MachineNameEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdDate))
 {
 if (objUserCodePrjMainPath_MachineNameEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePrjMainPath_MachineNameEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdUserId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePrjMainPath_MachineNameEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.Memo))
 {
 if (objUserCodePrjMainPath_MachineNameEN.Memo !=  null)
 {
 var strMemo = objUserCodePrjMainPath_MachineNameEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserCodePrjMainPath_MachineNameEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserCodePrjMainPath_MachineNameEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserCodePrjMainPath_MachineName Set ");
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.CodePath !=  null)
 {
 var strCodePath = objUserCodePrjMainPath_MachineNameEN.CodePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodePath, conUserCodePrjMainPath_MachineName.CodePath); //代码路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.CodePath); //代码路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.GcPathId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId  ==  "")
 {
 objUserCodePrjMainPath_MachineNameEN.GcPathId = null;
 }
 if (objUserCodePrjMainPath_MachineNameEN.GcPathId !=  null)
 {
 var strGcPathId = objUserCodePrjMainPath_MachineNameEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcPathId, conUserCodePrjMainPath_MachineName.GcPathId); //GC路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.GcPathId); //GC路径Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.CodePathBackup))
 {
 if (objUserCodePrjMainPath_MachineNameEN.CodePathBackup !=  null)
 {
 var strCodePathBackup = objUserCodePrjMainPath_MachineNameEN.CodePathBackup.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodePathBackup, conUserCodePrjMainPath_MachineName.CodePathBackup); //备份代码路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.CodePathBackup); //备份代码路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.LogPath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.LogPath !=  null)
 {
 var strLogPath = objUserCodePrjMainPath_MachineNameEN.LogPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogPath, conUserCodePrjMainPath_MachineName.LogPath); //日志路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.LogPath); //日志路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.IncludeXmlPath))
 {
 if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath !=  null)
 {
 var strIncludeXmlPath = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIncludeXmlPath, conUserCodePrjMainPath_MachineName.IncludeXmlPath); //包含表Xml路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.IncludeXmlPath); //包含表Xml路径
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.PrjId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.PrjId !=  null)
 {
 var strPrjId = objUserCodePrjMainPath_MachineNameEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUserCodePrjMainPath_MachineName.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.PrjId); //工程Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdDate))
 {
 if (objUserCodePrjMainPath_MachineNameEN.UpdDate !=  null)
 {
 var strUpdDate = objUserCodePrjMainPath_MachineNameEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserCodePrjMainPath_MachineName.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.UpdDate); //修改日期
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.UpdUserId))
 {
 if (objUserCodePrjMainPath_MachineNameEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserCodePrjMainPath_MachineNameEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conUserCodePrjMainPath_MachineName.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.UpdUserId); //修改用户Id
 }
 }
 
 if (objUserCodePrjMainPath_MachineNameEN.IsUpdated(conUserCodePrjMainPath_MachineName.Memo))
 {
 if (objUserCodePrjMainPath_MachineNameEN.Memo !=  null)
 {
 var strMemo = objUserCodePrjMainPath_MachineNameEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserCodePrjMainPath_MachineName.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserCodePrjMainPath_MachineName.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserCodePrjMainPathId = '{0}' And MachineName = '{1}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName); 
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
public bool DelRecordBySP(string strUserCodePrjMainPathId,string strMachineName) 
{
CheckPrimaryKey(strUserCodePrjMainPathId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strUserCodePrjMainPathId,
 strMachineName,
};
 objSQL.ExecSP("UserCodePrjMainPath_MachineName_Delete", values);
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
public bool DelRecord(string strUserCodePrjMainPathId,string strMachineName, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strUserCodePrjMainPathId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
//删除UserCodePrjMainPath_MachineName本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserCodePrjMainPath_MachineName where UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'" + " and MachineName = " + "'"+ strMachineName+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count  == 0) return 0;
int intCount = 0;
foreach (var strKeyLst in arrKeyLsts)
{
string[] sstrKey = strKeyLst.Split('|');
string strUserCodePrjMainPathId = sstrKey[0];
string strMachineName = sstrKey[1];
 int intRecNum  = this.DelRecord(strUserCodePrjMainPathId,strMachineName);
 intCount += intRecNum;
}
 return intCount;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <param name = "strMachineName">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strUserCodePrjMainPathId,string strMachineName) 
{
CheckPrimaryKey(strUserCodePrjMainPathId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
//删除UserCodePrjMainPath_MachineName本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserCodePrjMainPath_MachineName where UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'" + " and MachineName = " + "'"+ strMachineName+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserCodePrjMainPath_MachineName(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: DelUserCodePrjMainPath_MachineName)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserCodePrjMainPath_MachineName where " + strCondition ;
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
public bool DelUserCodePrjMainPath_MachineNameWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserCodePrjMainPath_MachineNameDA: DelUserCodePrjMainPath_MachineNameWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserCodePrjMainPath_MachineName where " + strCondition ;
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
 /// <param name = "objUserCodePrjMainPath_MachineNameENS">源对象</param>
 /// <param name = "objUserCodePrjMainPath_MachineNameENT">目标对象</param>
public void CopyTo(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENS, clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENT)
{
objUserCodePrjMainPath_MachineNameENT.UserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameENS.UserCodePrjMainPathId; //生成主目录Id
objUserCodePrjMainPath_MachineNameENT.MachineName = objUserCodePrjMainPath_MachineNameENS.MachineName; //机器名
objUserCodePrjMainPath_MachineNameENT.CodePath = objUserCodePrjMainPath_MachineNameENS.CodePath; //代码路径
objUserCodePrjMainPath_MachineNameENT.GcPathId = objUserCodePrjMainPath_MachineNameENS.GcPathId; //GC路径Id
objUserCodePrjMainPath_MachineNameENT.CodePathBackup = objUserCodePrjMainPath_MachineNameENS.CodePathBackup; //备份代码路径
objUserCodePrjMainPath_MachineNameENT.LogPath = objUserCodePrjMainPath_MachineNameENS.LogPath; //日志路径
objUserCodePrjMainPath_MachineNameENT.IncludeXmlPath = objUserCodePrjMainPath_MachineNameENS.IncludeXmlPath; //包含表Xml路径
objUserCodePrjMainPath_MachineNameENT.PrjId = objUserCodePrjMainPath_MachineNameENS.PrjId; //工程Id
objUserCodePrjMainPath_MachineNameENT.UpdDate = objUserCodePrjMainPath_MachineNameENS.UpdDate; //修改日期
objUserCodePrjMainPath_MachineNameENT.UpdUserId = objUserCodePrjMainPath_MachineNameENS.UpdUserId; //修改用户Id
objUserCodePrjMainPath_MachineNameENT.Memo = objUserCodePrjMainPath_MachineNameENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserCodePrjMainPath_MachineNameEN.CodePath, conUserCodePrjMainPath_MachineName.CodePath);
clsCheckSql.CheckFieldNotNull(objUserCodePrjMainPath_MachineNameEN.CodePathBackup, conUserCodePrjMainPath_MachineName.CodePathBackup);
clsCheckSql.CheckFieldNotNull(objUserCodePrjMainPath_MachineNameEN.PrjId, conUserCodePrjMainPath_MachineName.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.MachineName, 50, conUserCodePrjMainPath_MachineName.MachineName);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.CodePath, 200, conUserCodePrjMainPath_MachineName.CodePath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.GcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.CodePathBackup, 200, conUserCodePrjMainPath_MachineName.CodePathBackup);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.LogPath, 150, conUserCodePrjMainPath_MachineName.LogPath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath, 150, conUserCodePrjMainPath_MachineName.IncludeXmlPath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.PrjId, 4, conUserCodePrjMainPath_MachineName.PrjId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.UpdDate, 20, conUserCodePrjMainPath_MachineName.UpdDate);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.UpdUserId, 20, conUserCodePrjMainPath_MachineName.UpdUserId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.Memo, 1000, conUserCodePrjMainPath_MachineName.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
clsCheckSql.CheckFieldForeignKey(objUserCodePrjMainPath_MachineNameEN.GcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
 objUserCodePrjMainPath_MachineNameEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.CodePath, 200, conUserCodePrjMainPath_MachineName.CodePath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.GcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.CodePathBackup, 200, conUserCodePrjMainPath_MachineName.CodePathBackup);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.LogPath, 150, conUserCodePrjMainPath_MachineName.LogPath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath, 150, conUserCodePrjMainPath_MachineName.IncludeXmlPath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.PrjId, 4, conUserCodePrjMainPath_MachineName.PrjId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.UpdDate, 20, conUserCodePrjMainPath_MachineName.UpdDate);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.UpdUserId, 20, conUserCodePrjMainPath_MachineName.UpdUserId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.Memo, 1000, conUserCodePrjMainPath_MachineName.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
clsCheckSql.CheckFieldForeignKey(objUserCodePrjMainPath_MachineNameEN.GcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
 objUserCodePrjMainPath_MachineNameEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.MachineName, 50, conUserCodePrjMainPath_MachineName.MachineName);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.CodePath, 200, conUserCodePrjMainPath_MachineName.CodePath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.GcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.CodePathBackup, 200, conUserCodePrjMainPath_MachineName.CodePathBackup);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.LogPath, 150, conUserCodePrjMainPath_MachineName.LogPath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath, 150, conUserCodePrjMainPath_MachineName.IncludeXmlPath);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.PrjId, 4, conUserCodePrjMainPath_MachineName.PrjId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.UpdDate, 20, conUserCodePrjMainPath_MachineName.UpdDate);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.UpdUserId, 20, conUserCodePrjMainPath_MachineName.UpdUserId);
clsCheckSql.CheckFieldLen(objUserCodePrjMainPath_MachineNameEN.Memo, 1000, conUserCodePrjMainPath_MachineName.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.MachineName, conUserCodePrjMainPath_MachineName.MachineName);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.CodePath, conUserCodePrjMainPath_MachineName.CodePath);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.GcPathId, conUserCodePrjMainPath_MachineName.GcPathId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.CodePathBackup, conUserCodePrjMainPath_MachineName.CodePathBackup);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.LogPath, conUserCodePrjMainPath_MachineName.LogPath);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath, conUserCodePrjMainPath_MachineName.IncludeXmlPath);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.PrjId, conUserCodePrjMainPath_MachineName.PrjId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.UpdDate, conUserCodePrjMainPath_MachineName.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.UpdUserId, conUserCodePrjMainPath_MachineName.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objUserCodePrjMainPath_MachineNameEN.Memo, conUserCodePrjMainPath_MachineName.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 8, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
clsCheckSql.CheckFieldForeignKey(objUserCodePrjMainPath_MachineNameEN.GcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
 objUserCodePrjMainPath_MachineNameEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UserCodePrjMainPath_MachineName(用户生成项目主路径_PC),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserCodePrjMainPath_MachineNameEN.MachineName);
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
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
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
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
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
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserCodePrjMainPath_MachineNameEN._CurrTabName);
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
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strCondition);
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
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
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
 objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}