
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProjectDatabaseRelDA
 表名:vProjectDatabaseRel(00050193)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
 /// v工程数据库关系(vProjectDatabaseRel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvProjectDatabaseRelDA : clsCommBase4DA
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
 return clsvProjectDatabaseRelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvProjectDatabaseRelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvProjectDatabaseRelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvProjectDatabaseRelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvProjectDatabaseRelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
strSQL = "Select * from vProjectDatabaseRel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vProjectDatabaseRel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetDataTable_vProjectDatabaseRel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
strSQL = "Select * from vProjectDatabaseRel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
strSQL = "Select * from vProjectDatabaseRel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vProjectDatabaseRel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vProjectDatabaseRel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vProjectDatabaseRel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vProjectDatabaseRel.* " + 
$"from vProjectDatabaseRel " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vProjectDatabaseRel.mId not in " + 
$"(Select top {intTop_In} vProjectDatabaseRel.mId from vProjectDatabaseRel " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vProjectDatabaseRel where {1} and mId not in (Select top {2} mId from vProjectDatabaseRel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vProjectDatabaseRel where {1} and mId not in (Select top {3} mId from vProjectDatabaseRel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vProjectDatabaseRel.* " + 
$"from vProjectDatabaseRel " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vProjectDatabaseRel.mId not in " + 
$"(Select top {intTop_In} vProjectDatabaseRel.mId from vProjectDatabaseRel " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vProjectDatabaseRel where {1} and mId not in (Select top {2} mId from vProjectDatabaseRel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vProjectDatabaseRel where {1} and mId not in (Select top {3} mId from vProjectDatabaseRel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvProjectDatabaseRelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA:GetObjLst)", objException.Message));
}
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
strSQL = "Select * from vProjectDatabaseRel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = TransNullToInt(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程Id
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvProjectDatabaseRelDA: GetObjLst)", objException.Message));
}
objvProjectDatabaseRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvProjectDatabaseRelEN);
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
public List<clsvProjectDatabaseRelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = TransNullToInt(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程Id
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvProjectDatabaseRelDA: GetObjLst)", objException.Message));
}
objvProjectDatabaseRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvProjectDatabaseRelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvProjectDatabaseRel(ref clsvProjectDatabaseRelEN objvProjectDatabaseRelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
strSQL = "Select * from vProjectDatabaseRel where mId = " + ""+ objvProjectDatabaseRelEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvProjectDatabaseRelEN.mId = TransNullToInt(objDT.Rows[0][convProjectDatabaseRel.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvProjectDatabaseRelEN.PrjId = objDT.Rows[0][convProjectDatabaseRel.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectDatabaseRelEN.PrjName = objDT.Rows[0][convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectDatabaseRelEN.IpAddress = objDT.Rows[0][convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objvProjectDatabaseRelEN.PrjDataBaseId = objDT.Rows[0][convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectDatabaseRelEN.PrjDataBaseName = objDT.Rows[0][convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvProjectDatabaseRelEN.DataBaseName = objDT.Rows[0][convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvProjectDatabaseRelEN.DataBasePwd = objDT.Rows[0][convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objvProjectDatabaseRelEN.DataBaseUserId = objDT.Rows[0][convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objvProjectDatabaseRelEN.DatabaseOwner = objDT.Rows[0][convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objvProjectDatabaseRelEN.DataBaseTypeId = objDT.Rows[0][convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvProjectDatabaseRelEN.DataBaseTypeName = objDT.Rows[0][convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectDatabaseRelEN.Sid = objDT.Rows[0][convProjectDatabaseRel.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objvProjectDatabaseRelEN.TableSpace = objDT.Rows[0][convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:50,是否可空:True)
 objvProjectDatabaseRelEN.UseStateId = objDT.Rows[0][convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectDatabaseRelEN.UseStateName = objDT.Rows[0][convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvProjectDatabaseRelDA: GetvProjectDatabaseRel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvProjectDatabaseRelEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
strSQL = "Select * from vProjectDatabaseRel where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
 objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:50,是否可空:True)
 objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvProjectDatabaseRelDA: GetObjBymId)", objException.Message));
}
return objvProjectDatabaseRelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvProjectDatabaseRelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
strSQL = "Select * from vProjectDatabaseRel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN()
{
mId = TransNullToInt(objRow[convProjectDatabaseRel.mId].ToString().Trim()), //mId
PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(), //工程名称
IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(), //服务器
PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(), //项目数据库Id
PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(), //项目数据库名
DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(), //数据库名
DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(), //数据库的用户口令
DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(), //数据库的用户ID
DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(), //数据库拥有者
DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(), //数据库类型ID
DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(), //数据库类型名
Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(), //SID
TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(), //表空间
UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(), //使用状态Id
UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim() //使用状态名称
};
objvProjectDatabaseRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvProjectDatabaseRelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvProjectDatabaseRelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvProjectDatabaseRelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = TransNullToInt(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程Id
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvProjectDatabaseRelDA: GetObjByDataRowvProjectDatabaseRel)", objException.Message));
}
objvProjectDatabaseRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvProjectDatabaseRelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvProjectDatabaseRelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = TransNullToInt(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程Id
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvProjectDatabaseRelDA: GetObjByDataRow)", objException.Message));
}
objvProjectDatabaseRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvProjectDatabaseRelEN;
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
objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvProjectDatabaseRelEN._CurrTabName, convProjectDatabaseRel.mId, 8, "");
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
objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvProjectDatabaseRelEN._CurrTabName, convProjectDatabaseRel.mId, 8, strPrefix);
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
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vProjectDatabaseRel where " + strCondition;
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
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vProjectDatabaseRel where " + strCondition;
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
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vProjectDatabaseRel", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvProjectDatabaseRelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vProjectDatabaseRel", strCondition))
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
objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vProjectDatabaseRel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelENS">源对象</param>
 /// <param name = "objvProjectDatabaseRelENT">目标对象</param>
public void CopyTo(clsvProjectDatabaseRelEN objvProjectDatabaseRelENS, clsvProjectDatabaseRelEN objvProjectDatabaseRelENT)
{
objvProjectDatabaseRelENT.mId = objvProjectDatabaseRelENS.mId; //mId
objvProjectDatabaseRelENT.PrjId = objvProjectDatabaseRelENS.PrjId; //工程Id
objvProjectDatabaseRelENT.PrjName = objvProjectDatabaseRelENS.PrjName; //工程名称
objvProjectDatabaseRelENT.IpAddress = objvProjectDatabaseRelENS.IpAddress; //服务器
objvProjectDatabaseRelENT.PrjDataBaseId = objvProjectDatabaseRelENS.PrjDataBaseId; //项目数据库Id
objvProjectDatabaseRelENT.PrjDataBaseName = objvProjectDatabaseRelENS.PrjDataBaseName; //项目数据库名
objvProjectDatabaseRelENT.DataBaseName = objvProjectDatabaseRelENS.DataBaseName; //数据库名
objvProjectDatabaseRelENT.DataBasePwd = objvProjectDatabaseRelENS.DataBasePwd; //数据库的用户口令
objvProjectDatabaseRelENT.DataBaseUserId = objvProjectDatabaseRelENS.DataBaseUserId; //数据库的用户ID
objvProjectDatabaseRelENT.DatabaseOwner = objvProjectDatabaseRelENS.DatabaseOwner; //数据库拥有者
objvProjectDatabaseRelENT.DataBaseTypeId = objvProjectDatabaseRelENS.DataBaseTypeId; //数据库类型ID
objvProjectDatabaseRelENT.DataBaseTypeName = objvProjectDatabaseRelENS.DataBaseTypeName; //数据库类型名
objvProjectDatabaseRelENT.Sid = objvProjectDatabaseRelENS.Sid; //SID
objvProjectDatabaseRelENT.TableSpace = objvProjectDatabaseRelENS.TableSpace; //表空间
objvProjectDatabaseRelENT.UseStateId = objvProjectDatabaseRelENS.UseStateId; //使用状态Id
objvProjectDatabaseRelENT.UseStateName = objvProjectDatabaseRelENS.UseStateName; //使用状态名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvProjectDatabaseRelEN objvProjectDatabaseRelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.PrjId, 4, convProjectDatabaseRel.PrjId);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.PrjName, 30, convProjectDatabaseRel.PrjName);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.IpAddress, 25, convProjectDatabaseRel.IpAddress);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.PrjDataBaseId, 4, convProjectDatabaseRel.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.PrjDataBaseName, 50, convProjectDatabaseRel.PrjDataBaseName);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.DataBaseName, 50, convProjectDatabaseRel.DataBaseName);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.DataBasePwd, 30, convProjectDatabaseRel.DataBasePwd);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.DataBaseUserId, 30, convProjectDatabaseRel.DataBaseUserId);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.DatabaseOwner, 30, convProjectDatabaseRel.DatabaseOwner);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.DataBaseTypeId, 2, convProjectDatabaseRel.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.DataBaseTypeName, 30, convProjectDatabaseRel.DataBaseTypeName);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.Sid, 50, convProjectDatabaseRel.Sid);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.TableSpace, 50, convProjectDatabaseRel.TableSpace);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.UseStateId, 4, convProjectDatabaseRel.UseStateId);
clsCheckSql.CheckFieldLen(objvProjectDatabaseRelEN.UseStateName, 30, convProjectDatabaseRel.UseStateName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.PrjId, convProjectDatabaseRel.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.PrjName, convProjectDatabaseRel.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.IpAddress, convProjectDatabaseRel.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.PrjDataBaseId, convProjectDatabaseRel.PrjDataBaseId);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.PrjDataBaseName, convProjectDatabaseRel.PrjDataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.DataBaseName, convProjectDatabaseRel.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.DataBasePwd, convProjectDatabaseRel.DataBasePwd);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.DataBaseUserId, convProjectDatabaseRel.DataBaseUserId);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.DatabaseOwner, convProjectDatabaseRel.DatabaseOwner);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.DataBaseTypeId, convProjectDatabaseRel.DataBaseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.DataBaseTypeName, convProjectDatabaseRel.DataBaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.Sid, convProjectDatabaseRel.Sid);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.TableSpace, convProjectDatabaseRel.TableSpace);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.UseStateId, convProjectDatabaseRel.UseStateId);
clsCheckSql.CheckSqlInjection4Field(objvProjectDatabaseRelEN.UseStateName, convProjectDatabaseRel.UseStateName);
//检查外键字段长度
 objvProjectDatabaseRelEN._IsCheckProperty = true;
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
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
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
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
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
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvProjectDatabaseRelEN._CurrTabName);
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
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvProjectDatabaseRelEN._CurrTabName, strCondition);
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
 objSQL = clsvProjectDatabaseRelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}