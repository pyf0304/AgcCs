
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserLinkRelaDA
 表名:UserLinkRela(00050162)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:47
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
 /// 用户链接关系(UserLinkRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserLinkRelaDA : clsCommBase4DA
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
 return clsUserLinkRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserLinkRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserLinkRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserLinkRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserLinkRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserLinkRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetDataTable_UserLinkRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserLinkRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserLinkRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserLinkRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserLinkRela.* " + 
$"from UserLinkRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserLinkRela.mId not in " + 
$"(Select top {intTop_In} UserLinkRela.mId from UserLinkRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserLinkRela where {1} and mId not in (Select top {2} mId from UserLinkRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserLinkRela where {1} and mId not in (Select top {3} mId from UserLinkRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserLinkRela.* " + 
$"from UserLinkRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserLinkRela.mId not in " + 
$"(Select top {intTop_In} UserLinkRela.mId from UserLinkRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserLinkRela where {1} and mId not in (Select top {2} mId from UserLinkRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserLinkRela where {1} and mId not in (Select top {3} mId from UserLinkRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserLinkRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserLinkRelaDA:GetObjLst)", objException.Message));
}
List<clsUserLinkRelaEN> arrObjLst = new List<clsUserLinkRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLinkRelaEN objUserLinkRelaEN = new clsUserLinkRelaEN();
try
{
objUserLinkRelaEN.mId = TransNullToInt(objRow[conUserLinkRela.mId].ToString().Trim()); //mId
objUserLinkRelaEN.UserId = objRow[conUserLinkRela.UserId].ToString().Trim(); //用户Id
objUserLinkRelaEN.LinkName = objRow[conUserLinkRela.LinkName].ToString().Trim(); //链接名称
objUserLinkRelaEN.DataBaseTypeId = objRow[conUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objUserLinkRelaEN.IpAddress = objRow[conUserLinkRela.IpAddress].ToString().Trim(); //服务器
objUserLinkRelaEN.DataBaseName = objRow[conUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objUserLinkRelaEN.Sid = objRow[conUserLinkRela.Sid].ToString().Trim(); //SID
objUserLinkRelaEN.DataBaseUserId = objRow[conUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objUserLinkRelaEN.DataBasePwd = objRow[conUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[conUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objUserLinkRelaEN.ConnectionString = objRow[conUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objUserLinkRelaEN.Memo = objRow[conUserLinkRela.Memo] == DBNull.Value ? null : objRow[conUserLinkRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserLinkRelaDA: GetObjLst)", objException.Message));
}
objUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserLinkRelaEN);
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
public List<clsUserLinkRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserLinkRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserLinkRelaEN> arrObjLst = new List<clsUserLinkRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLinkRelaEN objUserLinkRelaEN = new clsUserLinkRelaEN();
try
{
objUserLinkRelaEN.mId = TransNullToInt(objRow[conUserLinkRela.mId].ToString().Trim()); //mId
objUserLinkRelaEN.UserId = objRow[conUserLinkRela.UserId].ToString().Trim(); //用户Id
objUserLinkRelaEN.LinkName = objRow[conUserLinkRela.LinkName].ToString().Trim(); //链接名称
objUserLinkRelaEN.DataBaseTypeId = objRow[conUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objUserLinkRelaEN.IpAddress = objRow[conUserLinkRela.IpAddress].ToString().Trim(); //服务器
objUserLinkRelaEN.DataBaseName = objRow[conUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objUserLinkRelaEN.Sid = objRow[conUserLinkRela.Sid].ToString().Trim(); //SID
objUserLinkRelaEN.DataBaseUserId = objRow[conUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objUserLinkRelaEN.DataBasePwd = objRow[conUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[conUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objUserLinkRelaEN.ConnectionString = objRow[conUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objUserLinkRelaEN.Memo = objRow[conUserLinkRela.Memo] == DBNull.Value ? null : objRow[conUserLinkRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserLinkRelaDA: GetObjLst)", objException.Message));
}
objUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserLinkRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserLinkRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserLinkRela(ref clsUserLinkRelaEN objUserLinkRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where mId = " + ""+ objUserLinkRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserLinkRelaEN.mId = TransNullToInt(objDT.Rows[0][conUserLinkRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserLinkRelaEN.UserId = objDT.Rows[0][conUserLinkRela.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserLinkRelaEN.LinkName = objDT.Rows[0][conUserLinkRela.LinkName].ToString().Trim(); //链接名称(字段类型:varchar,字段长度:30,是否可空:False)
 objUserLinkRelaEN.DataBaseTypeId = objDT.Rows[0][conUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objUserLinkRelaEN.IpAddress = objDT.Rows[0][conUserLinkRela.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objUserLinkRelaEN.DataBaseName = objDT.Rows[0][conUserLinkRela.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objUserLinkRelaEN.Sid = objDT.Rows[0][conUserLinkRela.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objUserLinkRelaEN.DataBaseUserId = objDT.Rows[0][conUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objUserLinkRelaEN.DataBasePwd = objDT.Rows[0][conUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objUserLinkRelaEN.ConnectionString = objDT.Rows[0][conUserLinkRela.ConnectionString].ToString().Trim(); //连接串(字段类型:varchar,字段长度:200,是否可空:False)
 objUserLinkRelaEN.Memo = objDT.Rows[0][conUserLinkRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserLinkRelaDA: GetUserLinkRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsUserLinkRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserLinkRelaEN objUserLinkRelaEN = new clsUserLinkRelaEN();
try
{
 objUserLinkRelaEN.mId = Int32.Parse(objRow[conUserLinkRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserLinkRelaEN.UserId = objRow[conUserLinkRela.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserLinkRelaEN.LinkName = objRow[conUserLinkRela.LinkName].ToString().Trim(); //链接名称(字段类型:varchar,字段长度:30,是否可空:False)
 objUserLinkRelaEN.DataBaseTypeId = objRow[conUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objUserLinkRelaEN.IpAddress = objRow[conUserLinkRela.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objUserLinkRelaEN.DataBaseName = objRow[conUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objUserLinkRelaEN.Sid = objRow[conUserLinkRela.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objUserLinkRelaEN.DataBaseUserId = objRow[conUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objUserLinkRelaEN.DataBasePwd = objRow[conUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[conUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objUserLinkRelaEN.ConnectionString = objRow[conUserLinkRela.ConnectionString].ToString().Trim(); //连接串(字段类型:varchar,字段长度:200,是否可空:False)
 objUserLinkRelaEN.Memo = objRow[conUserLinkRela.Memo] == DBNull.Value ? null : objRow[conUserLinkRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserLinkRelaDA: GetObjBymId)", objException.Message));
}
return objUserLinkRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserLinkRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserLinkRelaEN objUserLinkRelaEN = new clsUserLinkRelaEN()
{
mId = TransNullToInt(objRow[conUserLinkRela.mId].ToString().Trim()), //mId
UserId = objRow[conUserLinkRela.UserId].ToString().Trim(), //用户Id
LinkName = objRow[conUserLinkRela.LinkName].ToString().Trim(), //链接名称
DataBaseTypeId = objRow[conUserLinkRela.DataBaseTypeId].ToString().Trim(), //数据库类型ID
IpAddress = objRow[conUserLinkRela.IpAddress].ToString().Trim(), //服务器
DataBaseName = objRow[conUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseName].ToString().Trim(), //数据库名
Sid = objRow[conUserLinkRela.Sid].ToString().Trim(), //SID
DataBaseUserId = objRow[conUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseUserId].ToString().Trim(), //数据库的用户ID
DataBasePwd = objRow[conUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[conUserLinkRela.DataBasePwd].ToString().Trim(), //数据库的用户口令
ConnectionString = objRow[conUserLinkRela.ConnectionString].ToString().Trim(), //连接串
Memo = objRow[conUserLinkRela.Memo] == DBNull.Value ? null : objRow[conUserLinkRela.Memo].ToString().Trim() //说明
};
objUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserLinkRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserLinkRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserLinkRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserLinkRelaEN objUserLinkRelaEN = new clsUserLinkRelaEN();
try
{
objUserLinkRelaEN.mId = TransNullToInt(objRow[conUserLinkRela.mId].ToString().Trim()); //mId
objUserLinkRelaEN.UserId = objRow[conUserLinkRela.UserId].ToString().Trim(); //用户Id
objUserLinkRelaEN.LinkName = objRow[conUserLinkRela.LinkName].ToString().Trim(); //链接名称
objUserLinkRelaEN.DataBaseTypeId = objRow[conUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objUserLinkRelaEN.IpAddress = objRow[conUserLinkRela.IpAddress].ToString().Trim(); //服务器
objUserLinkRelaEN.DataBaseName = objRow[conUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objUserLinkRelaEN.Sid = objRow[conUserLinkRela.Sid].ToString().Trim(); //SID
objUserLinkRelaEN.DataBaseUserId = objRow[conUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objUserLinkRelaEN.DataBasePwd = objRow[conUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[conUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objUserLinkRelaEN.ConnectionString = objRow[conUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objUserLinkRelaEN.Memo = objRow[conUserLinkRela.Memo] == DBNull.Value ? null : objRow[conUserLinkRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserLinkRelaDA: GetObjByDataRowUserLinkRela)", objException.Message));
}
objUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserLinkRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserLinkRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserLinkRelaEN objUserLinkRelaEN = new clsUserLinkRelaEN();
try
{
objUserLinkRelaEN.mId = TransNullToInt(objRow[conUserLinkRela.mId].ToString().Trim()); //mId
objUserLinkRelaEN.UserId = objRow[conUserLinkRela.UserId].ToString().Trim(); //用户Id
objUserLinkRelaEN.LinkName = objRow[conUserLinkRela.LinkName].ToString().Trim(); //链接名称
objUserLinkRelaEN.DataBaseTypeId = objRow[conUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objUserLinkRelaEN.IpAddress = objRow[conUserLinkRela.IpAddress].ToString().Trim(); //服务器
objUserLinkRelaEN.DataBaseName = objRow[conUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objUserLinkRelaEN.Sid = objRow[conUserLinkRela.Sid].ToString().Trim(); //SID
objUserLinkRelaEN.DataBaseUserId = objRow[conUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[conUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objUserLinkRelaEN.DataBasePwd = objRow[conUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[conUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objUserLinkRelaEN.ConnectionString = objRow[conUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objUserLinkRelaEN.Memo = objRow[conUserLinkRela.Memo] == DBNull.Value ? null : objRow[conUserLinkRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserLinkRelaDA: GetObjByDataRow)", objException.Message));
}
objUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserLinkRelaEN;
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
objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserLinkRelaEN._CurrTabName, conUserLinkRela.mId, 8, "");
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
objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserLinkRelaEN._CurrTabName, conUserLinkRela.mId, 8, strPrefix);
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from UserLinkRela where " + strCondition;
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from UserLinkRela where " + strCondition;
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserLinkRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserLinkRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserLinkRela", strCondition))
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
objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserLinkRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserLinkRelaEN objUserLinkRelaEN)
 {
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLinkRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserLinkRela");
objRow = objDS.Tables["UserLinkRela"].NewRow();
objRow[conUserLinkRela.UserId] = objUserLinkRelaEN.UserId; //用户Id
objRow[conUserLinkRela.LinkName] = objUserLinkRelaEN.LinkName; //链接名称
objRow[conUserLinkRela.DataBaseTypeId] = objUserLinkRelaEN.DataBaseTypeId; //数据库类型ID
objRow[conUserLinkRela.IpAddress] = objUserLinkRelaEN.IpAddress; //服务器
 if (objUserLinkRelaEN.DataBaseName !=  "")
 {
objRow[conUserLinkRela.DataBaseName] = objUserLinkRelaEN.DataBaseName; //数据库名
 }
objRow[conUserLinkRela.Sid] = objUserLinkRelaEN.Sid; //SID
 if (objUserLinkRelaEN.DataBaseUserId !=  "")
 {
objRow[conUserLinkRela.DataBaseUserId] = objUserLinkRelaEN.DataBaseUserId; //数据库的用户ID
 }
 if (objUserLinkRelaEN.DataBasePwd !=  "")
 {
objRow[conUserLinkRela.DataBasePwd] = objUserLinkRelaEN.DataBasePwd; //数据库的用户口令
 }
objRow[conUserLinkRela.ConnectionString] = objUserLinkRelaEN.ConnectionString; //连接串
 if (objUserLinkRelaEN.Memo !=  "")
 {
objRow[conUserLinkRela.Memo] = objUserLinkRelaEN.Memo; //说明
 }
objDS.Tables[clsUserLinkRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserLinkRelaEN._CurrTabName);
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
 /// <param name = "objUserLinkRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserLinkRelaEN objUserLinkRelaEN)
{
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLinkRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserLinkRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.UserId);
 var strUserId = objUserLinkRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserLinkRelaEN.LinkName !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.LinkName);
 var strLinkName = objUserLinkRelaEN.LinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkName + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseTypeId);
 var strDataBaseTypeId = objUserLinkRelaEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseTypeId + "'");
 }
 
 if (objUserLinkRelaEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.IpAddress);
 var strIpAddress = objUserLinkRelaEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseName);
 var strDataBaseName = objUserLinkRelaEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objUserLinkRelaEN.Sid !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.Sid);
 var strSid = objUserLinkRelaEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSid + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseUserId);
 var strDataBaseUserId = objUserLinkRelaEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseUserId + "'");
 }
 
 if (objUserLinkRelaEN.DataBasePwd !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBasePwd);
 var strDataBasePwd = objUserLinkRelaEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBasePwd + "'");
 }
 
 if (objUserLinkRelaEN.ConnectionString !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.ConnectionString);
 var strConnectionString = objUserLinkRelaEN.ConnectionString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectionString + "'");
 }
 
 if (objUserLinkRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.Memo);
 var strMemo = objUserLinkRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserLinkRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserLinkRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserLinkRelaEN objUserLinkRelaEN)
{
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLinkRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserLinkRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.UserId);
 var strUserId = objUserLinkRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserLinkRelaEN.LinkName !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.LinkName);
 var strLinkName = objUserLinkRelaEN.LinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkName + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseTypeId);
 var strDataBaseTypeId = objUserLinkRelaEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseTypeId + "'");
 }
 
 if (objUserLinkRelaEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.IpAddress);
 var strIpAddress = objUserLinkRelaEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseName);
 var strDataBaseName = objUserLinkRelaEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objUserLinkRelaEN.Sid !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.Sid);
 var strSid = objUserLinkRelaEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSid + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseUserId);
 var strDataBaseUserId = objUserLinkRelaEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseUserId + "'");
 }
 
 if (objUserLinkRelaEN.DataBasePwd !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBasePwd);
 var strDataBasePwd = objUserLinkRelaEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBasePwd + "'");
 }
 
 if (objUserLinkRelaEN.ConnectionString !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.ConnectionString);
 var strConnectionString = objUserLinkRelaEN.ConnectionString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectionString + "'");
 }
 
 if (objUserLinkRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.Memo);
 var strMemo = objUserLinkRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserLinkRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserLinkRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserLinkRelaEN objUserLinkRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLinkRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserLinkRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.UserId);
 var strUserId = objUserLinkRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserLinkRelaEN.LinkName !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.LinkName);
 var strLinkName = objUserLinkRelaEN.LinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkName + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseTypeId);
 var strDataBaseTypeId = objUserLinkRelaEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseTypeId + "'");
 }
 
 if (objUserLinkRelaEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.IpAddress);
 var strIpAddress = objUserLinkRelaEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseName);
 var strDataBaseName = objUserLinkRelaEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objUserLinkRelaEN.Sid !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.Sid);
 var strSid = objUserLinkRelaEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSid + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseUserId);
 var strDataBaseUserId = objUserLinkRelaEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseUserId + "'");
 }
 
 if (objUserLinkRelaEN.DataBasePwd !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBasePwd);
 var strDataBasePwd = objUserLinkRelaEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBasePwd + "'");
 }
 
 if (objUserLinkRelaEN.ConnectionString !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.ConnectionString);
 var strConnectionString = objUserLinkRelaEN.ConnectionString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectionString + "'");
 }
 
 if (objUserLinkRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.Memo);
 var strMemo = objUserLinkRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserLinkRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserLinkRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserLinkRelaEN objUserLinkRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLinkRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserLinkRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.UserId);
 var strUserId = objUserLinkRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserLinkRelaEN.LinkName !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.LinkName);
 var strLinkName = objUserLinkRelaEN.LinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkName + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseTypeId);
 var strDataBaseTypeId = objUserLinkRelaEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseTypeId + "'");
 }
 
 if (objUserLinkRelaEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.IpAddress);
 var strIpAddress = objUserLinkRelaEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseName);
 var strDataBaseName = objUserLinkRelaEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objUserLinkRelaEN.Sid !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.Sid);
 var strSid = objUserLinkRelaEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSid + "'");
 }
 
 if (objUserLinkRelaEN.DataBaseUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBaseUserId);
 var strDataBaseUserId = objUserLinkRelaEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseUserId + "'");
 }
 
 if (objUserLinkRelaEN.DataBasePwd !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.DataBasePwd);
 var strDataBasePwd = objUserLinkRelaEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBasePwd + "'");
 }
 
 if (objUserLinkRelaEN.ConnectionString !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.ConnectionString);
 var strConnectionString = objUserLinkRelaEN.ConnectionString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectionString + "'");
 }
 
 if (objUserLinkRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserLinkRela.Memo);
 var strMemo = objUserLinkRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserLinkRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserLinkRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserLinkRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conUserLinkRela.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserLinkRelaEN._CurrTabName ].NewRow();
objRow[conUserLinkRela.UserId] = oRow[conUserLinkRela.UserId].ToString().Trim(); //用户Id
objRow[conUserLinkRela.LinkName] = oRow[conUserLinkRela.LinkName].ToString().Trim(); //链接名称
objRow[conUserLinkRela.DataBaseTypeId] = oRow[conUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objRow[conUserLinkRela.IpAddress] = oRow[conUserLinkRela.IpAddress].ToString().Trim(); //服务器
objRow[conUserLinkRela.DataBaseName] = oRow[conUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objRow[conUserLinkRela.Sid] = oRow[conUserLinkRela.Sid].ToString().Trim(); //SID
objRow[conUserLinkRela.DataBaseUserId] = oRow[conUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objRow[conUserLinkRela.DataBasePwd] = oRow[conUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objRow[conUserLinkRela.ConnectionString] = oRow[conUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objRow[conUserLinkRela.Memo] = oRow[conUserLinkRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsUserLinkRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserLinkRelaEN._CurrTabName);
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
 /// <param name = "objUserLinkRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserLinkRelaEN objUserLinkRelaEN)
{
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLinkRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from UserLinkRela where mId = " + ""+ objUserLinkRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserLinkRelaEN._CurrTabName);
if (objDS.Tables[clsUserLinkRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objUserLinkRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsUserLinkRelaEN._CurrTabName].Rows[0];
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.UserId))
 {
objRow[conUserLinkRela.UserId] = objUserLinkRelaEN.UserId; //用户Id
 }
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.LinkName))
 {
objRow[conUserLinkRela.LinkName] = objUserLinkRelaEN.LinkName; //链接名称
 }
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseTypeId))
 {
objRow[conUserLinkRela.DataBaseTypeId] = objUserLinkRelaEN.DataBaseTypeId; //数据库类型ID
 }
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.IpAddress))
 {
objRow[conUserLinkRela.IpAddress] = objUserLinkRelaEN.IpAddress; //服务器
 }
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseName))
 {
objRow[conUserLinkRela.DataBaseName] = objUserLinkRelaEN.DataBaseName; //数据库名
 }
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Sid))
 {
objRow[conUserLinkRela.Sid] = objUserLinkRelaEN.Sid; //SID
 }
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseUserId))
 {
objRow[conUserLinkRela.DataBaseUserId] = objUserLinkRelaEN.DataBaseUserId; //数据库的用户ID
 }
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBasePwd))
 {
objRow[conUserLinkRela.DataBasePwd] = objUserLinkRelaEN.DataBasePwd; //数据库的用户口令
 }
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.ConnectionString))
 {
objRow[conUserLinkRela.ConnectionString] = objUserLinkRelaEN.ConnectionString; //连接串
 }
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Memo))
 {
objRow[conUserLinkRela.Memo] = objUserLinkRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsUserLinkRelaEN._CurrTabName);
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
 /// <param name = "objUserLinkRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserLinkRelaEN objUserLinkRelaEN)
{
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLinkRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserLinkRela Set ");
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.UserId))
 {
 if (objUserLinkRelaEN.UserId !=  null)
 {
 var strUserId = objUserLinkRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserLinkRela.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.UserId); //用户Id
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.LinkName))
 {
 if (objUserLinkRelaEN.LinkName !=  null)
 {
 var strLinkName = objUserLinkRelaEN.LinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkName, conUserLinkRela.LinkName); //链接名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.LinkName); //链接名称
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseTypeId))
 {
 if (objUserLinkRelaEN.DataBaseTypeId !=  null)
 {
 var strDataBaseTypeId = objUserLinkRelaEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseTypeId, conUserLinkRela.DataBaseTypeId); //数据库类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.DataBaseTypeId); //数据库类型ID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.IpAddress))
 {
 if (objUserLinkRelaEN.IpAddress !=  null)
 {
 var strIpAddress = objUserLinkRelaEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conUserLinkRela.IpAddress); //服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.IpAddress); //服务器
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseName))
 {
 if (objUserLinkRelaEN.DataBaseName !=  null)
 {
 var strDataBaseName = objUserLinkRelaEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conUserLinkRela.DataBaseName); //数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.DataBaseName); //数据库名
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Sid))
 {
 if (objUserLinkRelaEN.Sid !=  null)
 {
 var strSid = objUserLinkRelaEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSid, conUserLinkRela.Sid); //SID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.Sid); //SID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseUserId))
 {
 if (objUserLinkRelaEN.DataBaseUserId !=  null)
 {
 var strDataBaseUserId = objUserLinkRelaEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseUserId, conUserLinkRela.DataBaseUserId); //数据库的用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.DataBaseUserId); //数据库的用户ID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBasePwd))
 {
 if (objUserLinkRelaEN.DataBasePwd !=  null)
 {
 var strDataBasePwd = objUserLinkRelaEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBasePwd, conUserLinkRela.DataBasePwd); //数据库的用户口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.DataBasePwd); //数据库的用户口令
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.ConnectionString))
 {
 if (objUserLinkRelaEN.ConnectionString !=  null)
 {
 var strConnectionString = objUserLinkRelaEN.ConnectionString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConnectionString, conUserLinkRela.ConnectionString); //连接串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.ConnectionString); //连接串
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Memo))
 {
 if (objUserLinkRelaEN.Memo !=  null)
 {
 var strMemo = objUserLinkRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserLinkRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserLinkRelaEN.mId); 
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
 /// <param name = "objUserLinkRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserLinkRelaEN objUserLinkRelaEN, string strCondition)
{
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLinkRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserLinkRela Set ");
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.UserId))
 {
 if (objUserLinkRelaEN.UserId !=  null)
 {
 var strUserId = objUserLinkRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.LinkName))
 {
 if (objUserLinkRelaEN.LinkName !=  null)
 {
 var strLinkName = objUserLinkRelaEN.LinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkName = '{0}',", strLinkName); //链接名称
 }
 else
 {
 sbSQL.Append(" LinkName = null,"); //链接名称
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseTypeId))
 {
 if (objUserLinkRelaEN.DataBaseTypeId !=  null)
 {
 var strDataBaseTypeId = objUserLinkRelaEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseTypeId = '{0}',", strDataBaseTypeId); //数据库类型ID
 }
 else
 {
 sbSQL.Append(" DataBaseTypeId = null,"); //数据库类型ID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.IpAddress))
 {
 if (objUserLinkRelaEN.IpAddress !=  null)
 {
 var strIpAddress = objUserLinkRelaEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //服务器
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //服务器
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseName))
 {
 if (objUserLinkRelaEN.DataBaseName !=  null)
 {
 var strDataBaseName = objUserLinkRelaEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Sid))
 {
 if (objUserLinkRelaEN.Sid !=  null)
 {
 var strSid = objUserLinkRelaEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Sid = '{0}',", strSid); //SID
 }
 else
 {
 sbSQL.Append(" Sid = null,"); //SID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseUserId))
 {
 if (objUserLinkRelaEN.DataBaseUserId !=  null)
 {
 var strDataBaseUserId = objUserLinkRelaEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseUserId = '{0}',", strDataBaseUserId); //数据库的用户ID
 }
 else
 {
 sbSQL.Append(" DataBaseUserId = null,"); //数据库的用户ID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBasePwd))
 {
 if (objUserLinkRelaEN.DataBasePwd !=  null)
 {
 var strDataBasePwd = objUserLinkRelaEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBasePwd = '{0}',", strDataBasePwd); //数据库的用户口令
 }
 else
 {
 sbSQL.Append(" DataBasePwd = null,"); //数据库的用户口令
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.ConnectionString))
 {
 if (objUserLinkRelaEN.ConnectionString !=  null)
 {
 var strConnectionString = objUserLinkRelaEN.ConnectionString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConnectionString = '{0}',", strConnectionString); //连接串
 }
 else
 {
 sbSQL.Append(" ConnectionString = null,"); //连接串
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Memo))
 {
 if (objUserLinkRelaEN.Memo !=  null)
 {
 var strMemo = objUserLinkRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserLinkRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserLinkRelaEN objUserLinkRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLinkRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserLinkRela Set ");
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.UserId))
 {
 if (objUserLinkRelaEN.UserId !=  null)
 {
 var strUserId = objUserLinkRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.LinkName))
 {
 if (objUserLinkRelaEN.LinkName !=  null)
 {
 var strLinkName = objUserLinkRelaEN.LinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkName = '{0}',", strLinkName); //链接名称
 }
 else
 {
 sbSQL.Append(" LinkName = null,"); //链接名称
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseTypeId))
 {
 if (objUserLinkRelaEN.DataBaseTypeId !=  null)
 {
 var strDataBaseTypeId = objUserLinkRelaEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseTypeId = '{0}',", strDataBaseTypeId); //数据库类型ID
 }
 else
 {
 sbSQL.Append(" DataBaseTypeId = null,"); //数据库类型ID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.IpAddress))
 {
 if (objUserLinkRelaEN.IpAddress !=  null)
 {
 var strIpAddress = objUserLinkRelaEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //服务器
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //服务器
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseName))
 {
 if (objUserLinkRelaEN.DataBaseName !=  null)
 {
 var strDataBaseName = objUserLinkRelaEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Sid))
 {
 if (objUserLinkRelaEN.Sid !=  null)
 {
 var strSid = objUserLinkRelaEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Sid = '{0}',", strSid); //SID
 }
 else
 {
 sbSQL.Append(" Sid = null,"); //SID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseUserId))
 {
 if (objUserLinkRelaEN.DataBaseUserId !=  null)
 {
 var strDataBaseUserId = objUserLinkRelaEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseUserId = '{0}',", strDataBaseUserId); //数据库的用户ID
 }
 else
 {
 sbSQL.Append(" DataBaseUserId = null,"); //数据库的用户ID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBasePwd))
 {
 if (objUserLinkRelaEN.DataBasePwd !=  null)
 {
 var strDataBasePwd = objUserLinkRelaEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBasePwd = '{0}',", strDataBasePwd); //数据库的用户口令
 }
 else
 {
 sbSQL.Append(" DataBasePwd = null,"); //数据库的用户口令
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.ConnectionString))
 {
 if (objUserLinkRelaEN.ConnectionString !=  null)
 {
 var strConnectionString = objUserLinkRelaEN.ConnectionString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConnectionString = '{0}',", strConnectionString); //连接串
 }
 else
 {
 sbSQL.Append(" ConnectionString = null,"); //连接串
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Memo))
 {
 if (objUserLinkRelaEN.Memo !=  null)
 {
 var strMemo = objUserLinkRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserLinkRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserLinkRelaEN objUserLinkRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUserLinkRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLinkRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserLinkRela Set ");
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.UserId))
 {
 if (objUserLinkRelaEN.UserId !=  null)
 {
 var strUserId = objUserLinkRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserLinkRela.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.UserId); //用户Id
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.LinkName))
 {
 if (objUserLinkRelaEN.LinkName !=  null)
 {
 var strLinkName = objUserLinkRelaEN.LinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkName, conUserLinkRela.LinkName); //链接名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.LinkName); //链接名称
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseTypeId))
 {
 if (objUserLinkRelaEN.DataBaseTypeId !=  null)
 {
 var strDataBaseTypeId = objUserLinkRelaEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseTypeId, conUserLinkRela.DataBaseTypeId); //数据库类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.DataBaseTypeId); //数据库类型ID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.IpAddress))
 {
 if (objUserLinkRelaEN.IpAddress !=  null)
 {
 var strIpAddress = objUserLinkRelaEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conUserLinkRela.IpAddress); //服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.IpAddress); //服务器
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseName))
 {
 if (objUserLinkRelaEN.DataBaseName !=  null)
 {
 var strDataBaseName = objUserLinkRelaEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conUserLinkRela.DataBaseName); //数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.DataBaseName); //数据库名
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Sid))
 {
 if (objUserLinkRelaEN.Sid !=  null)
 {
 var strSid = objUserLinkRelaEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSid, conUserLinkRela.Sid); //SID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.Sid); //SID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBaseUserId))
 {
 if (objUserLinkRelaEN.DataBaseUserId !=  null)
 {
 var strDataBaseUserId = objUserLinkRelaEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseUserId, conUserLinkRela.DataBaseUserId); //数据库的用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.DataBaseUserId); //数据库的用户ID
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.DataBasePwd))
 {
 if (objUserLinkRelaEN.DataBasePwd !=  null)
 {
 var strDataBasePwd = objUserLinkRelaEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBasePwd, conUserLinkRela.DataBasePwd); //数据库的用户口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.DataBasePwd); //数据库的用户口令
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.ConnectionString))
 {
 if (objUserLinkRelaEN.ConnectionString !=  null)
 {
 var strConnectionString = objUserLinkRelaEN.ConnectionString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConnectionString, conUserLinkRela.ConnectionString); //连接串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.ConnectionString); //连接串
 }
 }
 
 if (objUserLinkRelaEN.IsUpdated(conUserLinkRela.Memo))
 {
 if (objUserLinkRelaEN.Memo !=  null)
 {
 var strMemo = objUserLinkRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserLinkRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLinkRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserLinkRelaEN.mId); 
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("UserLinkRela_Delete", values);
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
//删除UserLinkRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserLinkRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUserLinkRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
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
//删除UserLinkRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserLinkRela where mId in (" + strKeyList + ")";
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
//删除UserLinkRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserLinkRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserLinkRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: DelUserLinkRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserLinkRela where " + strCondition ;
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
public bool DelUserLinkRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserLinkRelaDA: DelUserLinkRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserLinkRela where " + strCondition ;
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
 /// <param name = "objUserLinkRelaENS">源对象</param>
 /// <param name = "objUserLinkRelaENT">目标对象</param>
public void CopyTo(clsUserLinkRelaEN objUserLinkRelaENS, clsUserLinkRelaEN objUserLinkRelaENT)
{
objUserLinkRelaENT.mId = objUserLinkRelaENS.mId; //mId
objUserLinkRelaENT.UserId = objUserLinkRelaENS.UserId; //用户Id
objUserLinkRelaENT.LinkName = objUserLinkRelaENS.LinkName; //链接名称
objUserLinkRelaENT.DataBaseTypeId = objUserLinkRelaENS.DataBaseTypeId; //数据库类型ID
objUserLinkRelaENT.IpAddress = objUserLinkRelaENS.IpAddress; //服务器
objUserLinkRelaENT.DataBaseName = objUserLinkRelaENS.DataBaseName; //数据库名
objUserLinkRelaENT.Sid = objUserLinkRelaENS.Sid; //SID
objUserLinkRelaENT.DataBaseUserId = objUserLinkRelaENS.DataBaseUserId; //数据库的用户ID
objUserLinkRelaENT.DataBasePwd = objUserLinkRelaENS.DataBasePwd; //数据库的用户口令
objUserLinkRelaENT.ConnectionString = objUserLinkRelaENS.ConnectionString; //连接串
objUserLinkRelaENT.Memo = objUserLinkRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserLinkRelaEN objUserLinkRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserLinkRelaEN.UserId, conUserLinkRela.UserId);
clsCheckSql.CheckFieldNotNull(objUserLinkRelaEN.LinkName, conUserLinkRela.LinkName);
clsCheckSql.CheckFieldNotNull(objUserLinkRelaEN.DataBaseTypeId, conUserLinkRela.DataBaseTypeId);
clsCheckSql.CheckFieldNotNull(objUserLinkRelaEN.IpAddress, conUserLinkRela.IpAddress);
clsCheckSql.CheckFieldNotNull(objUserLinkRelaEN.Sid, conUserLinkRela.Sid);
clsCheckSql.CheckFieldNotNull(objUserLinkRelaEN.ConnectionString, conUserLinkRela.ConnectionString);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.UserId, 18, conUserLinkRela.UserId);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.LinkName, 30, conUserLinkRela.LinkName);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBaseTypeId, 2, conUserLinkRela.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.IpAddress, 25, conUserLinkRela.IpAddress);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBaseName, 50, conUserLinkRela.DataBaseName);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.Sid, 50, conUserLinkRela.Sid);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBaseUserId, 30, conUserLinkRela.DataBaseUserId);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBasePwd, 30, conUserLinkRela.DataBasePwd);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.ConnectionString, 200, conUserLinkRela.ConnectionString);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.Memo, 1000, conUserLinkRela.Memo);
//检查字段外键固定长度
 objUserLinkRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserLinkRelaEN objUserLinkRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.UserId, 18, conUserLinkRela.UserId);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.LinkName, 30, conUserLinkRela.LinkName);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBaseTypeId, 2, conUserLinkRela.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.IpAddress, 25, conUserLinkRela.IpAddress);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBaseName, 50, conUserLinkRela.DataBaseName);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.Sid, 50, conUserLinkRela.Sid);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBaseUserId, 30, conUserLinkRela.DataBaseUserId);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBasePwd, 30, conUserLinkRela.DataBasePwd);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.ConnectionString, 200, conUserLinkRela.ConnectionString);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.Memo, 1000, conUserLinkRela.Memo);
//检查外键字段长度
 objUserLinkRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserLinkRelaEN objUserLinkRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.UserId, 18, conUserLinkRela.UserId);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.LinkName, 30, conUserLinkRela.LinkName);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBaseTypeId, 2, conUserLinkRela.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.IpAddress, 25, conUserLinkRela.IpAddress);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBaseName, 50, conUserLinkRela.DataBaseName);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.Sid, 50, conUserLinkRela.Sid);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBaseUserId, 30, conUserLinkRela.DataBaseUserId);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.DataBasePwd, 30, conUserLinkRela.DataBasePwd);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.ConnectionString, 200, conUserLinkRela.ConnectionString);
clsCheckSql.CheckFieldLen(objUserLinkRelaEN.Memo, 1000, conUserLinkRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.UserId, conUserLinkRela.UserId);
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.LinkName, conUserLinkRela.LinkName);
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.DataBaseTypeId, conUserLinkRela.DataBaseTypeId);
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.IpAddress, conUserLinkRela.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.DataBaseName, conUserLinkRela.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.Sid, conUserLinkRela.Sid);
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.DataBaseUserId, conUserLinkRela.DataBaseUserId);
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.DataBasePwd, conUserLinkRela.DataBasePwd);
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.ConnectionString, conUserLinkRela.ConnectionString);
clsCheckSql.CheckSqlInjection4Field(objUserLinkRelaEN.Memo, conUserLinkRela.Memo);
//检查外键字段长度
 objUserLinkRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UserLinkRela(用户链接关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserLinkRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUserLinkRelaEN objUserLinkRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserLinkRelaEN.UserId);
 sbCondition.AppendFormat(" and LinkName = '{0}'", objUserLinkRelaEN.LinkName);
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserLinkRelaEN._CurrTabName);
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserLinkRelaEN._CurrTabName, strCondition);
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
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
 objSQL = clsUserLinkRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}