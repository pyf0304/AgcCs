
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjDataBaseDA
 表名:vPrjDataBase(00050175)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:33
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
 /// v数据库对象(vPrjDataBase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjDataBaseDA : clsCommBase4DA
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
 return clsvPrjDataBaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjDataBaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjDataBaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjDataBaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjDataBaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPrjDataBaseId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPrjDataBaseId)
{
strPrjDataBaseId = strPrjDataBaseId.Replace("'", "''");
if (strPrjDataBaseId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vPrjDataBase中,检查关键字,长度不正确!(clsvPrjDataBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjDataBaseId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjDataBase中,关键字不能为空 或 null!(clsvPrjDataBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjDataBaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjDataBaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vPrjDataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjDataBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetDataTable_vPrjDataBase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vPrjDataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vPrjDataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjDataBase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjDataBase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjDataBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjDataBase.* " + 
$"from vPrjDataBase " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjDataBase.PrjDataBaseId not in " + 
$"(Select top {intTop_In} vPrjDataBase.PrjDataBaseId from vPrjDataBase " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjDataBase where {1} and PrjDataBaseId not in (Select top {2} PrjDataBaseId from vPrjDataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjDataBase where {1} and PrjDataBaseId not in (Select top {3} PrjDataBaseId from vPrjDataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjDataBase.* " + 
$"from vPrjDataBase " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjDataBase.PrjDataBaseId not in " + 
$"(Select top {intTop_In} vPrjDataBase.PrjDataBaseId from vPrjDataBase " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjDataBase where {1} and PrjDataBaseId not in (Select top {2} PrjDataBaseId from vPrjDataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjDataBase where {1} and PrjDataBaseId not in (Select top {3} PrjDataBaseId from vPrjDataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjDataBaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA:GetObjLst)", objException.Message));
}
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vPrjDataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjDataBaseDA: GetObjLst)", objException.Message));
}
objvPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjDataBaseEN);
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
public List<clsvPrjDataBaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjDataBaseEN> arrObjLst = new List<clsvPrjDataBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjDataBaseDA: GetObjLst)", objException.Message));
}
objvPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjDataBaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjDataBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjDataBase(ref clsvPrjDataBaseEN objvPrjDataBaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vPrjDataBase where PrjDataBaseId = " + "'"+ objvPrjDataBaseEN.PrjDataBaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjDataBaseEN.PrjDataBaseId = objDT.Rows[0][convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjDataBaseEN.PrjDataBaseName = objDT.Rows[0][convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjDataBaseEN.DataBaseTypeName = objDT.Rows[0][convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjDataBaseEN.DataBaseTypeId = objDT.Rows[0][convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjDataBaseEN.DataBaseName = objDT.Rows[0][convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjDataBaseEN.DatabaseOwner = objDT.Rows[0][convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjDataBaseEN.DataBasePwd = objDT.Rows[0][convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjDataBaseEN.DataBaseUserId = objDT.Rows[0][convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjDataBaseEN.IpAddress = objDT.Rows[0][convPrjDataBase.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objvPrjDataBaseEN.TableSpace = objDT.Rows[0][convPrjDataBase.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjDataBaseEN.UpdDate = objDT.Rows[0][convPrjDataBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjDataBaseEN.Sid = objDT.Rows[0][convPrjDataBase.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjDataBaseEN.UserId = objDT.Rows[0][convPrjDataBase.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvPrjDataBaseEN.Memo = objDT.Rows[0][convPrjDataBase.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjDataBaseEN.UseStateName = objDT.Rows[0][convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjDataBaseEN.UseStateId = objDT.Rows[0][convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjDataBaseDA: GetvPrjDataBase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjDataBaseEN GetObjByPrjDataBaseId(string strPrjDataBaseId)
{
CheckPrimaryKey(strPrjDataBaseId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vPrjDataBase where PrjDataBaseId = " + "'"+ strPrjDataBaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
 objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjDataBaseDA: GetObjByPrjDataBaseId)", objException.Message));
}
return objvPrjDataBaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjDataBaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from vPrjDataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN()
{
PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(), //项目数据库Id
PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(), //项目数据库名
DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(), //数据库类型名
DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(), //数据库类型ID
DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(), //数据库名
DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(), //数据库拥有者
DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(), //数据库的用户口令
DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(), //数据库的用户ID
IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(), //服务器
TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(), //表空间
UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(), //修改日期
Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(), //SID
UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(), //用户Id
Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(), //说明
UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(), //使用状态名称
UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim() //使用状态Id
};
objvPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjDataBaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjDataBaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjDataBaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjDataBaseDA: GetObjByDataRowvPrjDataBase)", objException.Message));
}
objvPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjDataBaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjDataBaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjDataBaseEN objvPrjDataBaseEN = new clsvPrjDataBaseEN();
try
{
objvPrjDataBaseEN.PrjDataBaseId = objRow[convPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvPrjDataBaseEN.PrjDataBaseName = objRow[convPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvPrjDataBaseEN.DataBaseTypeName = objRow[convPrjDataBase.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvPrjDataBaseEN.DataBaseTypeId = objRow[convPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvPrjDataBaseEN.DataBaseName = objRow[convPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvPrjDataBaseEN.DatabaseOwner = objRow[convPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[convPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvPrjDataBaseEN.DataBasePwd = objRow[convPrjDataBase.DataBasePwd] == DBNull.Value ? null : objRow[convPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvPrjDataBaseEN.DataBaseUserId = objRow[convPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvPrjDataBaseEN.IpAddress = objRow[convPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[convPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvPrjDataBaseEN.TableSpace = objRow[convPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[convPrjDataBase.TableSpace].ToString().Trim(); //表空间
objvPrjDataBaseEN.UpdDate = objRow[convPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvPrjDataBaseEN.Sid = objRow[convPrjDataBase.Sid] == DBNull.Value ? null : objRow[convPrjDataBase.Sid].ToString().Trim(); //SID
objvPrjDataBaseEN.UserId = objRow[convPrjDataBase.UserId] == DBNull.Value ? null : objRow[convPrjDataBase.UserId].ToString().Trim(); //用户Id
objvPrjDataBaseEN.Memo = objRow[convPrjDataBase.Memo] == DBNull.Value ? null : objRow[convPrjDataBase.Memo].ToString().Trim(); //说明
objvPrjDataBaseEN.UseStateName = objRow[convPrjDataBase.UseStateName] == DBNull.Value ? null : objRow[convPrjDataBase.UseStateName].ToString().Trim(); //使用状态名称
objvPrjDataBaseEN.UseStateId = objRow[convPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjDataBaseDA: GetObjByDataRow)", objException.Message));
}
objvPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjDataBaseEN;
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
objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjDataBaseEN._CurrTabName, convPrjDataBase.PrjDataBaseId, 4, "");
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
objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjDataBaseEN._CurrTabName, convPrjDataBase.PrjDataBaseId, 4, strPrefix);
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
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrjDataBaseId from vPrjDataBase where " + strCondition;
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
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrjDataBaseId from vPrjDataBase where " + strCondition;
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
 /// <param name = "strPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPrjDataBaseId)
{
CheckPrimaryKey(strPrjDataBaseId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjDataBase", "PrjDataBaseId = " + "'"+ strPrjDataBaseId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjDataBaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjDataBase", strCondition))
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
objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjDataBase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjDataBaseENS">源对象</param>
 /// <param name = "objvPrjDataBaseENT">目标对象</param>
public void CopyTo(clsvPrjDataBaseEN objvPrjDataBaseENS, clsvPrjDataBaseEN objvPrjDataBaseENT)
{
objvPrjDataBaseENT.PrjDataBaseId = objvPrjDataBaseENS.PrjDataBaseId; //项目数据库Id
objvPrjDataBaseENT.PrjDataBaseName = objvPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objvPrjDataBaseENT.DataBaseTypeName = objvPrjDataBaseENS.DataBaseTypeName; //数据库类型名
objvPrjDataBaseENT.DataBaseTypeId = objvPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objvPrjDataBaseENT.DataBaseName = objvPrjDataBaseENS.DataBaseName; //数据库名
objvPrjDataBaseENT.DatabaseOwner = objvPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objvPrjDataBaseENT.DataBasePwd = objvPrjDataBaseENS.DataBasePwd; //数据库的用户口令
objvPrjDataBaseENT.DataBaseUserId = objvPrjDataBaseENS.DataBaseUserId; //数据库的用户ID
objvPrjDataBaseENT.IpAddress = objvPrjDataBaseENS.IpAddress; //服务器
objvPrjDataBaseENT.TableSpace = objvPrjDataBaseENS.TableSpace; //表空间
objvPrjDataBaseENT.UpdDate = objvPrjDataBaseENS.UpdDate; //修改日期
objvPrjDataBaseENT.Sid = objvPrjDataBaseENS.Sid; //SID
objvPrjDataBaseENT.UserId = objvPrjDataBaseENS.UserId; //用户Id
objvPrjDataBaseENT.Memo = objvPrjDataBaseENS.Memo; //说明
objvPrjDataBaseENT.UseStateName = objvPrjDataBaseENS.UseStateName; //使用状态名称
objvPrjDataBaseENT.UseStateId = objvPrjDataBaseENS.UseStateId; //使用状态Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjDataBaseEN objvPrjDataBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.PrjDataBaseId, 4, convPrjDataBase.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.PrjDataBaseName, 50, convPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.DataBaseTypeName, 30, convPrjDataBase.DataBaseTypeName);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.DataBaseTypeId, 2, convPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.DataBaseName, 50, convPrjDataBase.DataBaseName);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.DatabaseOwner, 30, convPrjDataBase.DatabaseOwner);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.DataBasePwd, 30, convPrjDataBase.DataBasePwd);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.DataBaseUserId, 30, convPrjDataBase.DataBaseUserId);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.IpAddress, 25, convPrjDataBase.IpAddress);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.TableSpace, 50, convPrjDataBase.TableSpace);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.UpdDate, 20, convPrjDataBase.UpdDate);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.Sid, 50, convPrjDataBase.Sid);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.UserId, 18, convPrjDataBase.UserId);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.Memo, 1000, convPrjDataBase.Memo);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.UseStateName, 30, convPrjDataBase.UseStateName);
clsCheckSql.CheckFieldLen(objvPrjDataBaseEN.UseStateId, 4, convPrjDataBase.UseStateId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.PrjDataBaseId, convPrjDataBase.PrjDataBaseId);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.PrjDataBaseName, convPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.DataBaseTypeName, convPrjDataBase.DataBaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.DataBaseTypeId, convPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.DataBaseName, convPrjDataBase.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.DatabaseOwner, convPrjDataBase.DatabaseOwner);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.DataBasePwd, convPrjDataBase.DataBasePwd);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.DataBaseUserId, convPrjDataBase.DataBaseUserId);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.IpAddress, convPrjDataBase.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.TableSpace, convPrjDataBase.TableSpace);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.UpdDate, convPrjDataBase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.Sid, convPrjDataBase.Sid);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.UserId, convPrjDataBase.UserId);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.Memo, convPrjDataBase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.UseStateName, convPrjDataBase.UseStateName);
clsCheckSql.CheckSqlInjection4Field(objvPrjDataBaseEN.UseStateId, convPrjDataBase.UseStateId);
//检查外键字段长度
 objvPrjDataBaseEN._IsCheckProperty = true;
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
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
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
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
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
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjDataBaseEN._CurrTabName);
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
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjDataBaseEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjDataBaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}