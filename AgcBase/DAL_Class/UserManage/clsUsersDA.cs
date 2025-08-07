
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersDA
 表名:Users(00050001)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 用于用户管理(Users)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUsersDA : clsCommBase4DA
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
 return clsUsersEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUsersEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUsersEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUsersEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUsersEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strUserId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strUserId)
{
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("(errid:Data000001)在表:Users中,检查关键字,长度不正确!(clsUsersDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Users中,关键字不能为空 或 null!(clsUsersDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsUsersDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Users(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable_Users)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Users where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Users where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Users.* " + 
$"from Users " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Users.UserId not in " + 
$"(Select top {intTop_In} Users.UserId from Users " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} and UserId not in (Select top {2} UserId from Users where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} and UserId not in (Select top {3} UserId from Users where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Users.* " + 
$"from Users " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Users.UserId not in " + 
$"(Select top {intTop_In} Users.UserId from Users " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} and UserId not in (Select top {2} UserId from Users where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Users where {1} and UserId not in (Select top {3} UserId from Users where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUsersEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUsersDA:GetObjLst)", objException.Message));
}
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户Id
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objUsersEN.UserStateId = objRow[conUsers.UserStateId] == DBNull.Value ? null : objRow[conUsers.UserStateId].ToString().Trim(); //用户状态号
objUsersEN.RoleId = objRow[conUsers.RoleId] == DBNull.Value ? null : objRow[conUsers.RoleId].ToString().Trim(); //角色ID
objUsersEN.qxdj = objRow[conUsers.qxdj] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUsers.qxdj].ToString().Trim()); //权限等级
objUsersEN.EffectiveDate = objRow[conUsers.EffectiveDate] == DBNull.Value ? null : objRow[conUsers.EffectiveDate].ToString().Trim(); //有效日期
objUsersEN.EffitiveBeginDate = objRow[conUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objUsersEN.EffitiveEndDate = objRow[conUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objUsersEN.Password = objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IdentityID = objRow[conUsers.IdentityID] == DBNull.Value ? null : objRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.IsGpUser = TransNullToBool(objRow[conUsers.IsGpUser].ToString().Trim()); //是否平台用户
objUsersEN.RegisterPassword = objRow[conUsers.RegisterPassword] == DBNull.Value ? null : objRow[conUsers.RegisterPassword].ToString().Trim(); //注册密码
objUsersEN.IsRegister = TransNullToBool(objRow[conUsers.IsRegister].ToString().Trim()); //是否注册
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //注册日期
objUsersEN.IsAudit = TransNullToBool(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //审核人
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //审核日期
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改者
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUsersDA: GetObjLst)", objException.Message));
}
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUsersEN);
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
public List<clsUsersEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUsersDA:GetObjLstByTabName)", objException.Message));
}
List<clsUsersEN> arrObjLst = new List<clsUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户Id
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objUsersEN.UserStateId = objRow[conUsers.UserStateId] == DBNull.Value ? null : objRow[conUsers.UserStateId].ToString().Trim(); //用户状态号
objUsersEN.RoleId = objRow[conUsers.RoleId] == DBNull.Value ? null : objRow[conUsers.RoleId].ToString().Trim(); //角色ID
objUsersEN.qxdj = objRow[conUsers.qxdj] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUsers.qxdj].ToString().Trim()); //权限等级
objUsersEN.EffectiveDate = objRow[conUsers.EffectiveDate] == DBNull.Value ? null : objRow[conUsers.EffectiveDate].ToString().Trim(); //有效日期
objUsersEN.EffitiveBeginDate = objRow[conUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objUsersEN.EffitiveEndDate = objRow[conUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objUsersEN.Password = objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IdentityID = objRow[conUsers.IdentityID] == DBNull.Value ? null : objRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.IsGpUser = TransNullToBool(objRow[conUsers.IsGpUser].ToString().Trim()); //是否平台用户
objUsersEN.RegisterPassword = objRow[conUsers.RegisterPassword] == DBNull.Value ? null : objRow[conUsers.RegisterPassword].ToString().Trim(); //注册密码
objUsersEN.IsRegister = TransNullToBool(objRow[conUsers.IsRegister].ToString().Trim()); //是否注册
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //注册日期
objUsersEN.IsAudit = TransNullToBool(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //审核人
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //审核日期
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改者
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUsersDA: GetObjLst)", objException.Message));
}
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUsersEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUsers(ref clsUsersEN objUsersEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where UserId = " + "'"+ objUsersEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUsersEN.UserId = objDT.Rows[0][conUsers.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUsersEN.UserName = objDT.Rows[0][conUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objUsersEN.DepartmentId = objDT.Rows[0][conUsers.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objUsersEN.UserStateId = objDT.Rows[0][conUsers.UserStateId].ToString().Trim(); //用户状态号(字段类型:char,字段长度:2,是否可空:True)
 objUsersEN.RoleId = objDT.Rows[0][conUsers.RoleId].ToString().Trim(); //角色ID(字段类型:char,字段长度:8,是否可空:True)
 objUsersEN.qxdj = TransNullToInt(objDT.Rows[0][conUsers.qxdj].ToString().Trim()); //权限等级(字段类型:int,字段长度:4,是否可空:False)
 objUsersEN.EffectiveDate = objDT.Rows[0][conUsers.EffectiveDate].ToString().Trim(); //有效日期(字段类型:varchar,字段长度:8,是否可空:True)
 objUsersEN.EffitiveBeginDate = objDT.Rows[0][conUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objUsersEN.EffitiveEndDate = objDT.Rows[0][conUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objUsersEN.Password = objDT.Rows[0][conUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objUsersEN.IdentityID = objDT.Rows[0][conUsers.IdentityID].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objUsersEN.Email = objDT.Rows[0][conUsers.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:50,是否可空:True)
 objUsersEN.IsGpUser = TransNullToBool(objDT.Rows[0][conUsers.IsGpUser].ToString().Trim()); //是否平台用户(字段类型:bit,字段长度:1,是否可空:True)
 objUsersEN.RegisterPassword = objDT.Rows[0][conUsers.RegisterPassword].ToString().Trim(); //注册密码(字段类型:varchar,字段长度:30,是否可空:True)
 objUsersEN.IsRegister = TransNullToBool(objDT.Rows[0][conUsers.IsRegister].ToString().Trim()); //是否注册(字段类型:bit,字段长度:1,是否可空:True)
 objUsersEN.RegisterDate = objDT.Rows[0][conUsers.RegisterDate].ToString().Trim(); //注册日期(字段类型:varchar,字段长度:14,是否可空:True)
 objUsersEN.IsAudit = TransNullToBool(objDT.Rows[0][conUsers.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objUsersEN.AuditUser = objDT.Rows[0][conUsers.AuditUser].ToString().Trim(); //审核人(字段类型:varchar,字段长度:18,是否可空:True)
 objUsersEN.AuditDate = objDT.Rows[0][conUsers.AuditDate].ToString().Trim(); //审核日期(字段类型:varchar,字段长度:14,是否可空:True)
 objUsersEN.UpdDate = objDT.Rows[0][conUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUsersEN.UpdUser = objDT.Rows[0][conUsers.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objUsersEN.Memo = objDT.Rows[0][conUsers.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUsersDA: GetUsers)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsUsersEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUsersEN objUsersEN = new clsUsersEN();
try
{
 objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objUsersEN.DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objUsersEN.UserStateId = objRow[conUsers.UserStateId] == DBNull.Value ? null : objRow[conUsers.UserStateId].ToString().Trim(); //用户状态号(字段类型:char,字段长度:2,是否可空:True)
 objUsersEN.RoleId = objRow[conUsers.RoleId] == DBNull.Value ? null : objRow[conUsers.RoleId].ToString().Trim(); //角色ID(字段类型:char,字段长度:8,是否可空:True)
 objUsersEN.qxdj = objRow[conUsers.qxdj] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUsers.qxdj].ToString().Trim()); //权限等级(字段类型:int,字段长度:4,是否可空:False)
 objUsersEN.EffectiveDate = objRow[conUsers.EffectiveDate] == DBNull.Value ? null : objRow[conUsers.EffectiveDate].ToString().Trim(); //有效日期(字段类型:varchar,字段长度:8,是否可空:True)
 objUsersEN.EffitiveBeginDate = objRow[conUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objUsersEN.EffitiveEndDate = objRow[conUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objUsersEN.Password = objRow[conUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objUsersEN.IdentityID = objRow[conUsers.IdentityID] == DBNull.Value ? null : objRow[conUsers.IdentityID].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:50,是否可空:True)
 objUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsGpUser].ToString().Trim()); //是否平台用户(字段类型:bit,字段长度:1,是否可空:True)
 objUsersEN.RegisterPassword = objRow[conUsers.RegisterPassword] == DBNull.Value ? null : objRow[conUsers.RegisterPassword].ToString().Trim(); //注册密码(字段类型:varchar,字段长度:30,是否可空:True)
 objUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsRegister].ToString().Trim()); //是否注册(字段类型:bit,字段长度:1,是否可空:True)
 objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //注册日期(字段类型:varchar,字段长度:14,是否可空:True)
 objUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //审核人(字段类型:varchar,字段长度:18,是否可空:True)
 objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //审核日期(字段类型:varchar,字段长度:14,是否可空:True)
 objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUsersDA: GetObjByUserId)", objException.Message));
}
return objUsersEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUsersEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUsersDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUsersEN objUsersEN = new clsUsersEN()
{
UserId = objRow[conUsers.UserId].ToString().Trim(), //用户Id
UserName = objRow[conUsers.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(), //部门ID
UserStateId = objRow[conUsers.UserStateId] == DBNull.Value ? null : objRow[conUsers.UserStateId].ToString().Trim(), //用户状态号
RoleId = objRow[conUsers.RoleId] == DBNull.Value ? null : objRow[conUsers.RoleId].ToString().Trim(), //角色ID
qxdj = objRow[conUsers.qxdj] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUsers.qxdj].ToString().Trim()), //权限等级
EffectiveDate = objRow[conUsers.EffectiveDate] == DBNull.Value ? null : objRow[conUsers.EffectiveDate].ToString().Trim(), //有效日期
EffitiveBeginDate = objRow[conUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conUsers.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[conUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conUsers.EffitiveEndDate].ToString().Trim(), //有效结束日期
Password = objRow[conUsers.Password].ToString().Trim(), //口令
IdentityID = objRow[conUsers.IdentityID] == DBNull.Value ? null : objRow[conUsers.IdentityID].ToString().Trim(), //身份编号
Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(), //电子邮箱
IsGpUser = TransNullToBool(objRow[conUsers.IsGpUser].ToString().Trim()), //是否平台用户
RegisterPassword = objRow[conUsers.RegisterPassword] == DBNull.Value ? null : objRow[conUsers.RegisterPassword].ToString().Trim(), //注册密码
IsRegister = TransNullToBool(objRow[conUsers.IsRegister].ToString().Trim()), //是否注册
RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(), //注册日期
IsAudit = TransNullToBool(objRow[conUsers.IsAudit].ToString().Trim()), //是否审核
AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(), //审核人
AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(), //审核日期
UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim() //说明
};
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUsersEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUsersDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUsersEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户Id
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objUsersEN.UserStateId = objRow[conUsers.UserStateId] == DBNull.Value ? null : objRow[conUsers.UserStateId].ToString().Trim(); //用户状态号
objUsersEN.RoleId = objRow[conUsers.RoleId] == DBNull.Value ? null : objRow[conUsers.RoleId].ToString().Trim(); //角色ID
objUsersEN.qxdj = objRow[conUsers.qxdj] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUsers.qxdj].ToString().Trim()); //权限等级
objUsersEN.EffectiveDate = objRow[conUsers.EffectiveDate] == DBNull.Value ? null : objRow[conUsers.EffectiveDate].ToString().Trim(); //有效日期
objUsersEN.EffitiveBeginDate = objRow[conUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objUsersEN.EffitiveEndDate = objRow[conUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objUsersEN.Password = objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IdentityID = objRow[conUsers.IdentityID] == DBNull.Value ? null : objRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.IsGpUser = TransNullToBool(objRow[conUsers.IsGpUser].ToString().Trim()); //是否平台用户
objUsersEN.RegisterPassword = objRow[conUsers.RegisterPassword] == DBNull.Value ? null : objRow[conUsers.RegisterPassword].ToString().Trim(); //注册密码
objUsersEN.IsRegister = TransNullToBool(objRow[conUsers.IsRegister].ToString().Trim()); //是否注册
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //注册日期
objUsersEN.IsAudit = TransNullToBool(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //审核人
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //审核日期
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改者
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUsersDA: GetObjByDataRowUsers)", objException.Message));
}
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUsersEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUsersEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUsersEN objUsersEN = new clsUsersEN();
try
{
objUsersEN.UserId = objRow[conUsers.UserId].ToString().Trim(); //用户Id
objUsersEN.UserName = objRow[conUsers.UserName].ToString().Trim(); //用户名
objUsersEN.DepartmentId = objRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objUsersEN.UserStateId = objRow[conUsers.UserStateId] == DBNull.Value ? null : objRow[conUsers.UserStateId].ToString().Trim(); //用户状态号
objUsersEN.RoleId = objRow[conUsers.RoleId] == DBNull.Value ? null : objRow[conUsers.RoleId].ToString().Trim(); //角色ID
objUsersEN.qxdj = objRow[conUsers.qxdj] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUsers.qxdj].ToString().Trim()); //权限等级
objUsersEN.EffectiveDate = objRow[conUsers.EffectiveDate] == DBNull.Value ? null : objRow[conUsers.EffectiveDate].ToString().Trim(); //有效日期
objUsersEN.EffitiveBeginDate = objRow[conUsers.EffitiveBeginDate] == DBNull.Value ? null : objRow[conUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objUsersEN.EffitiveEndDate = objRow[conUsers.EffitiveEndDate] == DBNull.Value ? null : objRow[conUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objUsersEN.Password = objRow[conUsers.Password].ToString().Trim(); //口令
objUsersEN.IdentityID = objRow[conUsers.IdentityID] == DBNull.Value ? null : objRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objUsersEN.Email = objRow[conUsers.Email] == DBNull.Value ? null : objRow[conUsers.Email].ToString().Trim(); //电子邮箱
objUsersEN.IsGpUser = TransNullToBool(objRow[conUsers.IsGpUser].ToString().Trim()); //是否平台用户
objUsersEN.RegisterPassword = objRow[conUsers.RegisterPassword] == DBNull.Value ? null : objRow[conUsers.RegisterPassword].ToString().Trim(); //注册密码
objUsersEN.IsRegister = TransNullToBool(objRow[conUsers.IsRegister].ToString().Trim()); //是否注册
objUsersEN.RegisterDate = objRow[conUsers.RegisterDate] == DBNull.Value ? null : objRow[conUsers.RegisterDate].ToString().Trim(); //注册日期
objUsersEN.IsAudit = TransNullToBool(objRow[conUsers.IsAudit].ToString().Trim()); //是否审核
objUsersEN.AuditUser = objRow[conUsers.AuditUser] == DBNull.Value ? null : objRow[conUsers.AuditUser].ToString().Trim(); //审核人
objUsersEN.AuditDate = objRow[conUsers.AuditDate] == DBNull.Value ? null : objRow[conUsers.AuditDate].ToString().Trim(); //审核日期
objUsersEN.UpdDate = objRow[conUsers.UpdDate] == DBNull.Value ? null : objRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objUsersEN.UpdUser = objRow[conUsers.UpdUser] == DBNull.Value ? null : objRow[conUsers.UpdUser].ToString().Trim(); //修改者
objUsersEN.Memo = objRow[conUsers.Memo] == DBNull.Value ? null : objRow[conUsers.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUsersDA: GetObjByDataRow)", objException.Message));
}
objUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUsersEN;
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
objSQL = clsUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUsersEN._CurrTabName, conUsers.UserId, 18, "");
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
objSQL = clsUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUsersEN._CurrTabName, conUsers.UserId, 18, strPrefix);
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
 objSQL = clsUsersDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from Users where " + strCondition;
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
 objSQL = clsUsersDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from Users where " + strCondition;
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strUserId)
{
CheckPrimaryKey(strUserId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Users", "UserId = " + "'"+ strUserId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUsersDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Users", strCondition))
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
objSQL = clsUsersDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Users");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUsersEN objUsersEN)
 {
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Users");
objRow = objDS.Tables["Users"].NewRow();
objRow[conUsers.UserId] = objUsersEN.UserId; //用户Id
objRow[conUsers.UserName] = objUsersEN.UserName; //用户名
objRow[conUsers.DepartmentId] = objUsersEN.DepartmentId; //部门ID
 if (objUsersEN.UserStateId !=  "")
 {
objRow[conUsers.UserStateId] = objUsersEN.UserStateId; //用户状态号
 }
 if (objUsersEN.RoleId !=  "")
 {
objRow[conUsers.RoleId] = objUsersEN.RoleId; //角色ID
 }
objRow[conUsers.qxdj] = objUsersEN.qxdj; //权限等级
 if (objUsersEN.EffectiveDate !=  "")
 {
objRow[conUsers.EffectiveDate] = objUsersEN.EffectiveDate; //有效日期
 }
 if (objUsersEN.EffitiveBeginDate !=  "")
 {
objRow[conUsers.EffitiveBeginDate] = objUsersEN.EffitiveBeginDate; //有效开始日期
 }
 if (objUsersEN.EffitiveEndDate !=  "")
 {
objRow[conUsers.EffitiveEndDate] = objUsersEN.EffitiveEndDate; //有效结束日期
 }
objRow[conUsers.Password] = objUsersEN.Password; //口令
 if (objUsersEN.IdentityID !=  "")
 {
objRow[conUsers.IdentityID] = objUsersEN.IdentityID; //身份编号
 }
 if (objUsersEN.Email !=  "")
 {
objRow[conUsers.Email] = objUsersEN.Email; //电子邮箱
 }
objRow[conUsers.IsGpUser] = objUsersEN.IsGpUser; //是否平台用户
 if (objUsersEN.RegisterPassword !=  "")
 {
objRow[conUsers.RegisterPassword] = objUsersEN.RegisterPassword; //注册密码
 }
objRow[conUsers.IsRegister] = objUsersEN.IsRegister; //是否注册
 if (objUsersEN.RegisterDate !=  "")
 {
objRow[conUsers.RegisterDate] = objUsersEN.RegisterDate; //注册日期
 }
objRow[conUsers.IsAudit] = objUsersEN.IsAudit; //是否审核
 if (objUsersEN.AuditUser !=  "")
 {
objRow[conUsers.AuditUser] = objUsersEN.AuditUser; //审核人
 }
 if (objUsersEN.AuditDate !=  "")
 {
objRow[conUsers.AuditDate] = objUsersEN.AuditDate; //审核日期
 }
 if (objUsersEN.UpdDate !=  "")
 {
objRow[conUsers.UpdDate] = objUsersEN.UpdDate; //修改日期
 }
 if (objUsersEN.UpdUser !=  "")
 {
objRow[conUsers.UpdUser] = objUsersEN.UpdUser; //修改者
 }
 if (objUsersEN.Memo !=  "")
 {
objRow[conUsers.Memo] = objUsersEN.Memo; //说明
 }
objDS.Tables[clsUsersEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUsersEN._CurrTabName);
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUsersEN objUsersEN)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserId);
 var strUserId = objUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserName);
 var strUserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.DepartmentId);
 var strDepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objUsersEN.UserStateId  ==  "")
 {
 objUsersEN.UserStateId = null;
 }
 if (objUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserStateId);
 var strUserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objUsersEN.RoleId  ==  "")
 {
 objUsersEN.RoleId = null;
 }
 if (objUsersEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RoleId);
 var strRoleId = objUsersEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objUsersEN.qxdj !=  null)
 {
 arrFieldListForInsert.Add(conUsers.qxdj);
 arrValueListForInsert.Add(objUsersEN.qxdj.ToString());
 }
 
 if (objUsersEN.EffectiveDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffectiveDate);
 var strEffectiveDate = objUsersEN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffectiveDate + "'");
 }
 
 if (objUsersEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffitiveBeginDate);
 var strEffitiveBeginDate = objUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objUsersEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffitiveEndDate);
 var strEffitiveEndDate = objUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Password);
 var strPassword = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objUsersEN.IdentityID !=  null)
 {
 arrFieldListForInsert.Add(conUsers.IdentityID);
 var strIdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityID + "'");
 }
 
 if (objUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Email);
 var strEmail = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsGpUser);
 arrValueListForInsert.Add("'" + (objUsersEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RegisterPassword);
 var strRegisterPassword = objUsersEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsRegister);
 arrValueListForInsert.Add("'" + (objUsersEN.IsRegister  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.RegisterDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RegisterDate);
 var strRegisterDate = objUsersEN.RegisterDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterDate + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsAudit);
 arrValueListForInsert.Add("'" + (objUsersEN.IsAudit  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.AuditUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.AuditUser);
 var strAuditUser = objUsersEN.AuditUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuditUser + "'");
 }
 
 if (objUsersEN.AuditDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.AuditDate);
 var strAuditDate = objUsersEN.AuditDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuditDate + "'");
 }
 
 if (objUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdDate);
 var strUpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdUser);
 var strUpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Memo);
 var strMemo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUsersEN objUsersEN)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserId);
 var strUserId = objUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserName);
 var strUserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.DepartmentId);
 var strDepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objUsersEN.UserStateId  ==  "")
 {
 objUsersEN.UserStateId = null;
 }
 if (objUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserStateId);
 var strUserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objUsersEN.RoleId  ==  "")
 {
 objUsersEN.RoleId = null;
 }
 if (objUsersEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RoleId);
 var strRoleId = objUsersEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objUsersEN.qxdj !=  null)
 {
 arrFieldListForInsert.Add(conUsers.qxdj);
 arrValueListForInsert.Add(objUsersEN.qxdj.ToString());
 }
 
 if (objUsersEN.EffectiveDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffectiveDate);
 var strEffectiveDate = objUsersEN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffectiveDate + "'");
 }
 
 if (objUsersEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffitiveBeginDate);
 var strEffitiveBeginDate = objUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objUsersEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffitiveEndDate);
 var strEffitiveEndDate = objUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Password);
 var strPassword = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objUsersEN.IdentityID !=  null)
 {
 arrFieldListForInsert.Add(conUsers.IdentityID);
 var strIdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityID + "'");
 }
 
 if (objUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Email);
 var strEmail = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsGpUser);
 arrValueListForInsert.Add("'" + (objUsersEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RegisterPassword);
 var strRegisterPassword = objUsersEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsRegister);
 arrValueListForInsert.Add("'" + (objUsersEN.IsRegister  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.RegisterDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RegisterDate);
 var strRegisterDate = objUsersEN.RegisterDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterDate + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsAudit);
 arrValueListForInsert.Add("'" + (objUsersEN.IsAudit  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.AuditUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.AuditUser);
 var strAuditUser = objUsersEN.AuditUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuditUser + "'");
 }
 
 if (objUsersEN.AuditDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.AuditDate);
 var strAuditDate = objUsersEN.AuditDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuditDate + "'");
 }
 
 if (objUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdDate);
 var strUpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdUser);
 var strUpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Memo);
 var strMemo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objUsersEN.UserId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUsersEN objUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserId);
 var strUserId = objUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserName);
 var strUserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.DepartmentId);
 var strDepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objUsersEN.UserStateId  ==  "")
 {
 objUsersEN.UserStateId = null;
 }
 if (objUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserStateId);
 var strUserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objUsersEN.RoleId  ==  "")
 {
 objUsersEN.RoleId = null;
 }
 if (objUsersEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RoleId);
 var strRoleId = objUsersEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objUsersEN.qxdj !=  null)
 {
 arrFieldListForInsert.Add(conUsers.qxdj);
 arrValueListForInsert.Add(objUsersEN.qxdj.ToString());
 }
 
 if (objUsersEN.EffectiveDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffectiveDate);
 var strEffectiveDate = objUsersEN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffectiveDate + "'");
 }
 
 if (objUsersEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffitiveBeginDate);
 var strEffitiveBeginDate = objUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objUsersEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffitiveEndDate);
 var strEffitiveEndDate = objUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Password);
 var strPassword = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objUsersEN.IdentityID !=  null)
 {
 arrFieldListForInsert.Add(conUsers.IdentityID);
 var strIdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityID + "'");
 }
 
 if (objUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Email);
 var strEmail = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsGpUser);
 arrValueListForInsert.Add("'" + (objUsersEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RegisterPassword);
 var strRegisterPassword = objUsersEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsRegister);
 arrValueListForInsert.Add("'" + (objUsersEN.IsRegister  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.RegisterDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RegisterDate);
 var strRegisterDate = objUsersEN.RegisterDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterDate + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsAudit);
 arrValueListForInsert.Add("'" + (objUsersEN.IsAudit  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.AuditUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.AuditUser);
 var strAuditUser = objUsersEN.AuditUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuditUser + "'");
 }
 
 if (objUsersEN.AuditDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.AuditDate);
 var strAuditDate = objUsersEN.AuditDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuditDate + "'");
 }
 
 if (objUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdDate);
 var strUpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdUser);
 var strUpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Memo);
 var strMemo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objUsersEN.UserId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUsersEN objUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUsersEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objUsersEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserId);
 var strUserId = objUsersEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUsersEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserName);
 var strUserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objUsersEN.DepartmentId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.DepartmentId);
 var strDepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDepartmentId + "'");
 }
 
 if (objUsersEN.UserStateId  ==  "")
 {
 objUsersEN.UserStateId = null;
 }
 if (objUsersEN.UserStateId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UserStateId);
 var strUserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserStateId + "'");
 }
 
 if (objUsersEN.RoleId  ==  "")
 {
 objUsersEN.RoleId = null;
 }
 if (objUsersEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RoleId);
 var strRoleId = objUsersEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objUsersEN.qxdj !=  null)
 {
 arrFieldListForInsert.Add(conUsers.qxdj);
 arrValueListForInsert.Add(objUsersEN.qxdj.ToString());
 }
 
 if (objUsersEN.EffectiveDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffectiveDate);
 var strEffectiveDate = objUsersEN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffectiveDate + "'");
 }
 
 if (objUsersEN.EffitiveBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffitiveBeginDate);
 var strEffitiveBeginDate = objUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveBeginDate + "'");
 }
 
 if (objUsersEN.EffitiveEndDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.EffitiveEndDate);
 var strEffitiveEndDate = objUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEffitiveEndDate + "'");
 }
 
 if (objUsersEN.Password !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Password);
 var strPassword = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPassword + "'");
 }
 
 if (objUsersEN.IdentityID !=  null)
 {
 arrFieldListForInsert.Add(conUsers.IdentityID);
 var strIdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdentityID + "'");
 }
 
 if (objUsersEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Email);
 var strEmail = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsGpUser);
 arrValueListForInsert.Add("'" + (objUsersEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RegisterPassword);
 var strRegisterPassword = objUsersEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsRegister);
 arrValueListForInsert.Add("'" + (objUsersEN.IsRegister  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.RegisterDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.RegisterDate);
 var strRegisterDate = objUsersEN.RegisterDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterDate + "'");
 }
 
 arrFieldListForInsert.Add(conUsers.IsAudit);
 arrValueListForInsert.Add("'" + (objUsersEN.IsAudit  ==  false ? "0" : "1") + "'");
 
 if (objUsersEN.AuditUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.AuditUser);
 var strAuditUser = objUsersEN.AuditUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuditUser + "'");
 }
 
 if (objUsersEN.AuditDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.AuditDate);
 var strAuditDate = objUsersEN.AuditDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuditDate + "'");
 }
 
 if (objUsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdDate);
 var strUpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUsersEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUsers.UpdUser);
 var strUpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUsers.Memo);
 var strMemo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Users");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where UserId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Users");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strUserId = oRow[conUsers.UserId].ToString().Trim();
if (IsExist(strUserId))
{
 string strResult = "关键字变量值为:" + string.Format("UserId = {0}", strUserId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUsersEN._CurrTabName ].NewRow();
objRow[conUsers.UserId] = oRow[conUsers.UserId].ToString().Trim(); //用户Id
objRow[conUsers.UserName] = oRow[conUsers.UserName].ToString().Trim(); //用户名
objRow[conUsers.DepartmentId] = oRow[conUsers.DepartmentId].ToString().Trim(); //部门ID
objRow[conUsers.UserStateId] = oRow[conUsers.UserStateId].ToString().Trim(); //用户状态号
objRow[conUsers.RoleId] = oRow[conUsers.RoleId].ToString().Trim(); //角色ID
objRow[conUsers.qxdj] = oRow[conUsers.qxdj].ToString().Trim(); //权限等级
objRow[conUsers.EffectiveDate] = oRow[conUsers.EffectiveDate].ToString().Trim(); //有效日期
objRow[conUsers.EffitiveBeginDate] = oRow[conUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objRow[conUsers.EffitiveEndDate] = oRow[conUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objRow[conUsers.Password] = oRow[conUsers.Password].ToString().Trim(); //口令
objRow[conUsers.IdentityID] = oRow[conUsers.IdentityID].ToString().Trim(); //身份编号
objRow[conUsers.Email] = oRow[conUsers.Email].ToString().Trim(); //电子邮箱
objRow[conUsers.IsGpUser] = oRow[conUsers.IsGpUser].ToString().Trim(); //是否平台用户
objRow[conUsers.RegisterPassword] = oRow[conUsers.RegisterPassword].ToString().Trim(); //注册密码
objRow[conUsers.IsRegister] = oRow[conUsers.IsRegister].ToString().Trim(); //是否注册
objRow[conUsers.RegisterDate] = oRow[conUsers.RegisterDate].ToString().Trim(); //注册日期
objRow[conUsers.IsAudit] = oRow[conUsers.IsAudit].ToString().Trim(); //是否审核
objRow[conUsers.AuditUser] = oRow[conUsers.AuditUser].ToString().Trim(); //审核人
objRow[conUsers.AuditDate] = oRow[conUsers.AuditDate].ToString().Trim(); //审核日期
objRow[conUsers.UpdDate] = oRow[conUsers.UpdDate].ToString().Trim(); //修改日期
objRow[conUsers.UpdUser] = oRow[conUsers.UpdUser].ToString().Trim(); //修改者
objRow[conUsers.Memo] = oRow[conUsers.Memo].ToString().Trim(); //说明
 objDS.Tables[clsUsersEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUsersEN._CurrTabName);
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
 /// <param name = "objUsersEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUsersEN objUsersEN)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
strSQL = "Select * from Users where UserId = " + "'"+ objUsersEN.UserId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUsersEN._CurrTabName);
if (objDS.Tables[clsUsersEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:UserId = " + "'"+ objUsersEN.UserId+"'");
return false;
}
objRow = objDS.Tables[clsUsersEN._CurrTabName].Rows[0];
 if (objUsersEN.IsUpdated(conUsers.UserId))
 {
objRow[conUsers.UserId] = objUsersEN.UserId; //用户Id
 }
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
objRow[conUsers.UserName] = objUsersEN.UserName; //用户名
 }
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
objRow[conUsers.DepartmentId] = objUsersEN.DepartmentId; //部门ID
 }
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
objRow[conUsers.UserStateId] = objUsersEN.UserStateId; //用户状态号
 }
 if (objUsersEN.IsUpdated(conUsers.RoleId))
 {
objRow[conUsers.RoleId] = objUsersEN.RoleId; //角色ID
 }
 if (objUsersEN.IsUpdated(conUsers.qxdj))
 {
objRow[conUsers.qxdj] = objUsersEN.qxdj; //权限等级
 }
 if (objUsersEN.IsUpdated(conUsers.EffectiveDate))
 {
objRow[conUsers.EffectiveDate] = objUsersEN.EffectiveDate; //有效日期
 }
 if (objUsersEN.IsUpdated(conUsers.EffitiveBeginDate))
 {
objRow[conUsers.EffitiveBeginDate] = objUsersEN.EffitiveBeginDate; //有效开始日期
 }
 if (objUsersEN.IsUpdated(conUsers.EffitiveEndDate))
 {
objRow[conUsers.EffitiveEndDate] = objUsersEN.EffitiveEndDate; //有效结束日期
 }
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
objRow[conUsers.Password] = objUsersEN.Password; //口令
 }
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
objRow[conUsers.IdentityID] = objUsersEN.IdentityID; //身份编号
 }
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
objRow[conUsers.Email] = objUsersEN.Email; //电子邮箱
 }
 if (objUsersEN.IsUpdated(conUsers.IsGpUser))
 {
objRow[conUsers.IsGpUser] = objUsersEN.IsGpUser; //是否平台用户
 }
 if (objUsersEN.IsUpdated(conUsers.RegisterPassword))
 {
objRow[conUsers.RegisterPassword] = objUsersEN.RegisterPassword; //注册密码
 }
 if (objUsersEN.IsUpdated(conUsers.IsRegister))
 {
objRow[conUsers.IsRegister] = objUsersEN.IsRegister; //是否注册
 }
 if (objUsersEN.IsUpdated(conUsers.RegisterDate))
 {
objRow[conUsers.RegisterDate] = objUsersEN.RegisterDate; //注册日期
 }
 if (objUsersEN.IsUpdated(conUsers.IsAudit))
 {
objRow[conUsers.IsAudit] = objUsersEN.IsAudit; //是否审核
 }
 if (objUsersEN.IsUpdated(conUsers.AuditUser))
 {
objRow[conUsers.AuditUser] = objUsersEN.AuditUser; //审核人
 }
 if (objUsersEN.IsUpdated(conUsers.AuditDate))
 {
objRow[conUsers.AuditDate] = objUsersEN.AuditDate; //审核日期
 }
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
objRow[conUsers.UpdDate] = objUsersEN.UpdDate; //修改日期
 }
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
objRow[conUsers.UpdUser] = objUsersEN.UpdUser; //修改者
 }
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
objRow[conUsers.Memo] = objUsersEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsUsersEN._CurrTabName);
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUsersEN objUsersEN)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Users Set ");
 
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
 if (objUsersEN.UserName !=  null)
 {
 var strUserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conUsers.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UserName); //用户名
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
 if (objUsersEN.DepartmentId !=  null)
 {
 var strDepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentId, conUsers.DepartmentId); //部门ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.DepartmentId); //部门ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
 if (objUsersEN.UserStateId  ==  "")
 {
 objUsersEN.UserStateId = null;
 }
 if (objUsersEN.UserStateId !=  null)
 {
 var strUserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserStateId, conUsers.UserStateId); //用户状态号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UserStateId); //用户状态号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.RoleId))
 {
 if (objUsersEN.RoleId  ==  "")
 {
 objUsersEN.RoleId = null;
 }
 if (objUsersEN.RoleId !=  null)
 {
 var strRoleId = objUsersEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conUsers.RoleId); //角色ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.RoleId); //角色ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.qxdj))
 {
 if (objUsersEN.qxdj !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUsersEN.qxdj, conUsers.qxdj); //权限等级
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.qxdj); //权限等级
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffectiveDate))
 {
 if (objUsersEN.EffectiveDate !=  null)
 {
 var strEffectiveDate = objUsersEN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffectiveDate, conUsers.EffectiveDate); //有效日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.EffectiveDate); //有效日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffitiveBeginDate))
 {
 if (objUsersEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveBeginDate, conUsers.EffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.EffitiveBeginDate); //有效开始日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffitiveEndDate))
 {
 if (objUsersEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveEndDate, conUsers.EffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.EffitiveEndDate); //有效结束日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
 if (objUsersEN.Password !=  null)
 {
 var strPassword = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPassword, conUsers.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Password); //口令
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
 if (objUsersEN.IdentityID !=  null)
 {
 var strIdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdentityID, conUsers.IdentityID); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.IdentityID); //身份编号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
 if (objUsersEN.Email !=  null)
 {
 var strEmail = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conUsers.Email); //电子邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Email); //电子邮箱
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsGpUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUsersEN.IsGpUser == true?"1":"0", conUsers.IsGpUser); //是否平台用户
 }
 
 if (objUsersEN.IsUpdated(conUsers.RegisterPassword))
 {
 if (objUsersEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objUsersEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegisterPassword, conUsers.RegisterPassword); //注册密码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.RegisterPassword); //注册密码
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsRegister))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUsersEN.IsRegister == true?"1":"0", conUsers.IsRegister); //是否注册
 }
 
 if (objUsersEN.IsUpdated(conUsers.RegisterDate))
 {
 if (objUsersEN.RegisterDate !=  null)
 {
 var strRegisterDate = objUsersEN.RegisterDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegisterDate, conUsers.RegisterDate); //注册日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.RegisterDate); //注册日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsAudit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUsersEN.IsAudit == true?"1":"0", conUsers.IsAudit); //是否审核
 }
 
 if (objUsersEN.IsUpdated(conUsers.AuditUser))
 {
 if (objUsersEN.AuditUser !=  null)
 {
 var strAuditUser = objUsersEN.AuditUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuditUser, conUsers.AuditUser); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.AuditUser); //审核人
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.AuditDate))
 {
 if (objUsersEN.AuditDate !=  null)
 {
 var strAuditDate = objUsersEN.AuditDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuditDate, conUsers.AuditDate); //审核日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.AuditDate); //审核日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
 if (objUsersEN.UpdDate !=  null)
 {
 var strUpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUsers.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UpdDate); //修改日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
 if (objUsersEN.UpdUser !=  null)
 {
 var strUpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conUsers.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UpdUser); //修改者
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
 if (objUsersEN.Memo !=  null)
 {
 var strMemo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUsers.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserId = '{0}'", objUsersEN.UserId); 
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
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUsersEN objUsersEN, string strCondition)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Users Set ");
 
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
 if (objUsersEN.UserName !=  null)
 {
 var strUserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
 if (objUsersEN.DepartmentId !=  null)
 {
 var strDepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentId = '{0}',", strDepartmentId); //部门ID
 }
 else
 {
 sbSQL.Append(" DepartmentId = null,"); //部门ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
 if (objUsersEN.UserStateId  ==  "")
 {
 objUsersEN.UserStateId = null;
 }
 if (objUsersEN.UserStateId !=  null)
 {
 var strUserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserStateId = '{0}',", strUserStateId); //用户状态号
 }
 else
 {
 sbSQL.Append(" UserStateId = null,"); //用户状态号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.RoleId))
 {
 if (objUsersEN.RoleId  ==  "")
 {
 objUsersEN.RoleId = null;
 }
 if (objUsersEN.RoleId !=  null)
 {
 var strRoleId = objUsersEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色ID
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.qxdj))
 {
 if (objUsersEN.qxdj !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUsersEN.qxdj, conUsers.qxdj); //权限等级
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.qxdj); //权限等级
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffectiveDate))
 {
 if (objUsersEN.EffectiveDate !=  null)
 {
 var strEffectiveDate = objUsersEN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffectiveDate = '{0}',", strEffectiveDate); //有效日期
 }
 else
 {
 sbSQL.Append(" EffectiveDate = null,"); //有效日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffitiveBeginDate))
 {
 if (objUsersEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveBeginDate = '{0}',", strEffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.Append(" EffitiveBeginDate = null,"); //有效开始日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffitiveEndDate))
 {
 if (objUsersEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveEndDate = '{0}',", strEffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.Append(" EffitiveEndDate = null,"); //有效结束日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
 if (objUsersEN.Password !=  null)
 {
 var strPassword = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", strPassword); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
 if (objUsersEN.IdentityID !=  null)
 {
 var strIdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityID = '{0}',", strIdentityID); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityID = null,"); //身份编号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
 if (objUsersEN.Email !=  null)
 {
 var strEmail = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //电子邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //电子邮箱
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsGpUser))
 {
 sbSQL.AppendFormat(" IsGpUser = '{0}',", objUsersEN.IsGpUser == true?"1":"0"); //是否平台用户
 }
 
 if (objUsersEN.IsUpdated(conUsers.RegisterPassword))
 {
 if (objUsersEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objUsersEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegisterPassword = '{0}',", strRegisterPassword); //注册密码
 }
 else
 {
 sbSQL.Append(" RegisterPassword = null,"); //注册密码
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsRegister))
 {
 sbSQL.AppendFormat(" IsRegister = '{0}',", objUsersEN.IsRegister == true?"1":"0"); //是否注册
 }
 
 if (objUsersEN.IsUpdated(conUsers.RegisterDate))
 {
 if (objUsersEN.RegisterDate !=  null)
 {
 var strRegisterDate = objUsersEN.RegisterDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegisterDate = '{0}',", strRegisterDate); //注册日期
 }
 else
 {
 sbSQL.Append(" RegisterDate = null,"); //注册日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsAudit))
 {
 sbSQL.AppendFormat(" IsAudit = '{0}',", objUsersEN.IsAudit == true?"1":"0"); //是否审核
 }
 
 if (objUsersEN.IsUpdated(conUsers.AuditUser))
 {
 if (objUsersEN.AuditUser !=  null)
 {
 var strAuditUser = objUsersEN.AuditUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AuditUser = '{0}',", strAuditUser); //审核人
 }
 else
 {
 sbSQL.Append(" AuditUser = null,"); //审核人
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.AuditDate))
 {
 if (objUsersEN.AuditDate !=  null)
 {
 var strAuditDate = objUsersEN.AuditDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AuditDate = '{0}',", strAuditDate); //审核日期
 }
 else
 {
 sbSQL.Append(" AuditDate = null,"); //审核日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
 if (objUsersEN.UpdDate !=  null)
 {
 var strUpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
 if (objUsersEN.UpdUser !=  null)
 {
 var strUpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
 if (objUsersEN.Memo !=  null)
 {
 var strMemo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUsersEN objUsersEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Users Set ");
 
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
 if (objUsersEN.UserName !=  null)
 {
 var strUserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
 if (objUsersEN.DepartmentId !=  null)
 {
 var strDepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DepartmentId = '{0}',", strDepartmentId); //部门ID
 }
 else
 {
 sbSQL.Append(" DepartmentId = null,"); //部门ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
 if (objUsersEN.UserStateId  ==  "")
 {
 objUsersEN.UserStateId = null;
 }
 if (objUsersEN.UserStateId !=  null)
 {
 var strUserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserStateId = '{0}',", strUserStateId); //用户状态号
 }
 else
 {
 sbSQL.Append(" UserStateId = null,"); //用户状态号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.RoleId))
 {
 if (objUsersEN.RoleId  ==  "")
 {
 objUsersEN.RoleId = null;
 }
 if (objUsersEN.RoleId !=  null)
 {
 var strRoleId = objUsersEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色ID
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.qxdj))
 {
 if (objUsersEN.qxdj !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUsersEN.qxdj, conUsers.qxdj); //权限等级
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.qxdj); //权限等级
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffectiveDate))
 {
 if (objUsersEN.EffectiveDate !=  null)
 {
 var strEffectiveDate = objUsersEN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffectiveDate = '{0}',", strEffectiveDate); //有效日期
 }
 else
 {
 sbSQL.Append(" EffectiveDate = null,"); //有效日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffitiveBeginDate))
 {
 if (objUsersEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveBeginDate = '{0}',", strEffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.Append(" EffitiveBeginDate = null,"); //有效开始日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffitiveEndDate))
 {
 if (objUsersEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EffitiveEndDate = '{0}',", strEffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.Append(" EffitiveEndDate = null,"); //有效结束日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
 if (objUsersEN.Password !=  null)
 {
 var strPassword = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Password = '{0}',", strPassword); //口令
 }
 else
 {
 sbSQL.Append(" Password = null,"); //口令
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
 if (objUsersEN.IdentityID !=  null)
 {
 var strIdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdentityID = '{0}',", strIdentityID); //身份编号
 }
 else
 {
 sbSQL.Append(" IdentityID = null,"); //身份编号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
 if (objUsersEN.Email !=  null)
 {
 var strEmail = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //电子邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //电子邮箱
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsGpUser))
 {
 sbSQL.AppendFormat(" IsGpUser = '{0}',", objUsersEN.IsGpUser == true?"1":"0"); //是否平台用户
 }
 
 if (objUsersEN.IsUpdated(conUsers.RegisterPassword))
 {
 if (objUsersEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objUsersEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegisterPassword = '{0}',", strRegisterPassword); //注册密码
 }
 else
 {
 sbSQL.Append(" RegisterPassword = null,"); //注册密码
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsRegister))
 {
 sbSQL.AppendFormat(" IsRegister = '{0}',", objUsersEN.IsRegister == true?"1":"0"); //是否注册
 }
 
 if (objUsersEN.IsUpdated(conUsers.RegisterDate))
 {
 if (objUsersEN.RegisterDate !=  null)
 {
 var strRegisterDate = objUsersEN.RegisterDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegisterDate = '{0}',", strRegisterDate); //注册日期
 }
 else
 {
 sbSQL.Append(" RegisterDate = null,"); //注册日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsAudit))
 {
 sbSQL.AppendFormat(" IsAudit = '{0}',", objUsersEN.IsAudit == true?"1":"0"); //是否审核
 }
 
 if (objUsersEN.IsUpdated(conUsers.AuditUser))
 {
 if (objUsersEN.AuditUser !=  null)
 {
 var strAuditUser = objUsersEN.AuditUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AuditUser = '{0}',", strAuditUser); //审核人
 }
 else
 {
 sbSQL.Append(" AuditUser = null,"); //审核人
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.AuditDate))
 {
 if (objUsersEN.AuditDate !=  null)
 {
 var strAuditDate = objUsersEN.AuditDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AuditDate = '{0}',", strAuditDate); //审核日期
 }
 else
 {
 sbSQL.Append(" AuditDate = null,"); //审核日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
 if (objUsersEN.UpdDate !=  null)
 {
 var strUpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
 if (objUsersEN.UpdUser !=  null)
 {
 var strUpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
 if (objUsersEN.Memo !=  null)
 {
 var strMemo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUsersEN objUsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Users Set ");
 
 if (objUsersEN.IsUpdated(conUsers.UserName))
 {
 if (objUsersEN.UserName !=  null)
 {
 var strUserName = objUsersEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conUsers.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UserName); //用户名
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.DepartmentId))
 {
 if (objUsersEN.DepartmentId !=  null)
 {
 var strDepartmentId = objUsersEN.DepartmentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDepartmentId, conUsers.DepartmentId); //部门ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.DepartmentId); //部门ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UserStateId))
 {
 if (objUsersEN.UserStateId  ==  "")
 {
 objUsersEN.UserStateId = null;
 }
 if (objUsersEN.UserStateId !=  null)
 {
 var strUserStateId = objUsersEN.UserStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserStateId, conUsers.UserStateId); //用户状态号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UserStateId); //用户状态号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.RoleId))
 {
 if (objUsersEN.RoleId  ==  "")
 {
 objUsersEN.RoleId = null;
 }
 if (objUsersEN.RoleId !=  null)
 {
 var strRoleId = objUsersEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conUsers.RoleId); //角色ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.RoleId); //角色ID
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.qxdj))
 {
 if (objUsersEN.qxdj !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUsersEN.qxdj, conUsers.qxdj); //权限等级
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.qxdj); //权限等级
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffectiveDate))
 {
 if (objUsersEN.EffectiveDate !=  null)
 {
 var strEffectiveDate = objUsersEN.EffectiveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffectiveDate, conUsers.EffectiveDate); //有效日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.EffectiveDate); //有效日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffitiveBeginDate))
 {
 if (objUsersEN.EffitiveBeginDate !=  null)
 {
 var strEffitiveBeginDate = objUsersEN.EffitiveBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveBeginDate, conUsers.EffitiveBeginDate); //有效开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.EffitiveBeginDate); //有效开始日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.EffitiveEndDate))
 {
 if (objUsersEN.EffitiveEndDate !=  null)
 {
 var strEffitiveEndDate = objUsersEN.EffitiveEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEffitiveEndDate, conUsers.EffitiveEndDate); //有效结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.EffitiveEndDate); //有效结束日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Password))
 {
 if (objUsersEN.Password !=  null)
 {
 var strPassword = objUsersEN.Password.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPassword, conUsers.Password); //口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Password); //口令
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IdentityID))
 {
 if (objUsersEN.IdentityID !=  null)
 {
 var strIdentityID = objUsersEN.IdentityID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdentityID, conUsers.IdentityID); //身份编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.IdentityID); //身份编号
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Email))
 {
 if (objUsersEN.Email !=  null)
 {
 var strEmail = objUsersEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conUsers.Email); //电子邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Email); //电子邮箱
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsGpUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUsersEN.IsGpUser == true?"1":"0", conUsers.IsGpUser); //是否平台用户
 }
 
 if (objUsersEN.IsUpdated(conUsers.RegisterPassword))
 {
 if (objUsersEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objUsersEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegisterPassword, conUsers.RegisterPassword); //注册密码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.RegisterPassword); //注册密码
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsRegister))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUsersEN.IsRegister == true?"1":"0", conUsers.IsRegister); //是否注册
 }
 
 if (objUsersEN.IsUpdated(conUsers.RegisterDate))
 {
 if (objUsersEN.RegisterDate !=  null)
 {
 var strRegisterDate = objUsersEN.RegisterDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegisterDate, conUsers.RegisterDate); //注册日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.RegisterDate); //注册日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.IsAudit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUsersEN.IsAudit == true?"1":"0", conUsers.IsAudit); //是否审核
 }
 
 if (objUsersEN.IsUpdated(conUsers.AuditUser))
 {
 if (objUsersEN.AuditUser !=  null)
 {
 var strAuditUser = objUsersEN.AuditUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuditUser, conUsers.AuditUser); //审核人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.AuditUser); //审核人
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.AuditDate))
 {
 if (objUsersEN.AuditDate !=  null)
 {
 var strAuditDate = objUsersEN.AuditDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuditDate, conUsers.AuditDate); //审核日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.AuditDate); //审核日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdDate))
 {
 if (objUsersEN.UpdDate !=  null)
 {
 var strUpdDate = objUsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUsers.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UpdDate); //修改日期
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.UpdUser))
 {
 if (objUsersEN.UpdUser !=  null)
 {
 var strUpdUser = objUsersEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conUsers.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.UpdUser); //修改者
 }
 }
 
 if (objUsersEN.IsUpdated(conUsers.Memo))
 {
 if (objUsersEN.Memo !=  null)
 {
 var strMemo = objUsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUsers.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUsers.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where UserId = '{0}'", objUsersEN.UserId); 
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
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strUserId) 
{
CheckPrimaryKey(strUserId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strUserId,
};
 objSQL.ExecSP("Users_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strUserId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
//删除Users本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Users where UserId = " + "'"+ strUserId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUsers(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
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
//删除Users本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Users where UserId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strUserId) 
{
CheckPrimaryKey(strUserId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
//删除Users本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Users where UserId = " + "'"+ strUserId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUsers(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUsersDA: DelUsers)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Users where " + strCondition ;
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
public bool DelUsersWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUsersDA: DelUsersWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUsersDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Users where " + strCondition ;
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
 /// <param name = "objUsersENS">源对象</param>
 /// <param name = "objUsersENT">目标对象</param>
public void CopyTo(clsUsersEN objUsersENS, clsUsersEN objUsersENT)
{
objUsersENT.UserId = objUsersENS.UserId; //用户Id
objUsersENT.UserName = objUsersENS.UserName; //用户名
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门ID
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态号
objUsersENT.RoleId = objUsersENS.RoleId; //角色ID
objUsersENT.qxdj = objUsersENS.qxdj; //权限等级
objUsersENT.EffectiveDate = objUsersENS.EffectiveDate; //有效日期
objUsersENT.EffitiveBeginDate = objUsersENS.EffitiveBeginDate; //有效开始日期
objUsersENT.EffitiveEndDate = objUsersENS.EffitiveEndDate; //有效结束日期
objUsersENT.Password = objUsersENS.Password; //口令
objUsersENT.IdentityID = objUsersENS.IdentityID; //身份编号
objUsersENT.Email = objUsersENS.Email; //电子邮箱
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否平台用户
objUsersENT.RegisterPassword = objUsersENS.RegisterPassword; //注册密码
objUsersENT.IsRegister = objUsersENS.IsRegister; //是否注册
objUsersENT.RegisterDate = objUsersENS.RegisterDate; //注册日期
objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
objUsersENT.AuditUser = objUsersENS.AuditUser; //审核人
objUsersENT.AuditDate = objUsersENS.AuditDate; //审核日期
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改者
objUsersENT.Memo = objUsersENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUsersEN objUsersEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUsersEN.UserName, conUsers.UserName);
clsCheckSql.CheckFieldNotNull(objUsersEN.DepartmentId, conUsers.DepartmentId);
clsCheckSql.CheckFieldNotNull(objUsersEN.Password, conUsers.Password);
//检查字段长度
clsCheckSql.CheckFieldLen(objUsersEN.UserId, 18, conUsers.UserId);
clsCheckSql.CheckFieldLen(objUsersEN.UserName, 30, conUsers.UserName);
clsCheckSql.CheckFieldLen(objUsersEN.DepartmentId, 6, conUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objUsersEN.UserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldLen(objUsersEN.RoleId, 8, conUsers.RoleId);
clsCheckSql.CheckFieldLen(objUsersEN.EffectiveDate, 8, conUsers.EffectiveDate);
clsCheckSql.CheckFieldLen(objUsersEN.EffitiveBeginDate, 14, conUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objUsersEN.EffitiveEndDate, 14, conUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objUsersEN.Password, 20, conUsers.Password);
clsCheckSql.CheckFieldLen(objUsersEN.IdentityID, 2, conUsers.IdentityID);
clsCheckSql.CheckFieldLen(objUsersEN.Email, 50, conUsers.Email);
clsCheckSql.CheckFieldLen(objUsersEN.RegisterPassword, 30, conUsers.RegisterPassword);
clsCheckSql.CheckFieldLen(objUsersEN.RegisterDate, 14, conUsers.RegisterDate);
clsCheckSql.CheckFieldLen(objUsersEN.AuditUser, 18, conUsers.AuditUser);
clsCheckSql.CheckFieldLen(objUsersEN.AuditDate, 14, conUsers.AuditDate);
clsCheckSql.CheckFieldLen(objUsersEN.UpdDate, 20, conUsers.UpdDate);
clsCheckSql.CheckFieldLen(objUsersEN.UpdUser, 20, conUsers.UpdUser);
clsCheckSql.CheckFieldLen(objUsersEN.Memo, 1000, conUsers.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objUsersEN.UserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(objUsersEN.RoleId, 8, conUsers.RoleId);
 objUsersEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUsersEN objUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUsersEN.UserName, 30, conUsers.UserName);
clsCheckSql.CheckFieldLen(objUsersEN.DepartmentId, 6, conUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objUsersEN.UserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldLen(objUsersEN.RoleId, 8, conUsers.RoleId);
clsCheckSql.CheckFieldLen(objUsersEN.EffectiveDate, 8, conUsers.EffectiveDate);
clsCheckSql.CheckFieldLen(objUsersEN.EffitiveBeginDate, 14, conUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objUsersEN.EffitiveEndDate, 14, conUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objUsersEN.Password, 20, conUsers.Password);
clsCheckSql.CheckFieldLen(objUsersEN.IdentityID, 2, conUsers.IdentityID);
clsCheckSql.CheckFieldLen(objUsersEN.Email, 50, conUsers.Email);
clsCheckSql.CheckFieldLen(objUsersEN.RegisterPassword, 30, conUsers.RegisterPassword);
clsCheckSql.CheckFieldLen(objUsersEN.RegisterDate, 14, conUsers.RegisterDate);
clsCheckSql.CheckFieldLen(objUsersEN.AuditUser, 18, conUsers.AuditUser);
clsCheckSql.CheckFieldLen(objUsersEN.AuditDate, 14, conUsers.AuditDate);
clsCheckSql.CheckFieldLen(objUsersEN.UpdDate, 20, conUsers.UpdDate);
clsCheckSql.CheckFieldLen(objUsersEN.UpdUser, 20, conUsers.UpdUser);
clsCheckSql.CheckFieldLen(objUsersEN.Memo, 1000, conUsers.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUsersEN.UserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(objUsersEN.RoleId, 8, conUsers.RoleId);
 objUsersEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUsersEN objUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUsersEN.UserId, 18, conUsers.UserId);
clsCheckSql.CheckFieldLen(objUsersEN.UserName, 30, conUsers.UserName);
clsCheckSql.CheckFieldLen(objUsersEN.DepartmentId, 6, conUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objUsersEN.UserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldLen(objUsersEN.RoleId, 8, conUsers.RoleId);
clsCheckSql.CheckFieldLen(objUsersEN.EffectiveDate, 8, conUsers.EffectiveDate);
clsCheckSql.CheckFieldLen(objUsersEN.EffitiveBeginDate, 14, conUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objUsersEN.EffitiveEndDate, 14, conUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objUsersEN.Password, 20, conUsers.Password);
clsCheckSql.CheckFieldLen(objUsersEN.IdentityID, 2, conUsers.IdentityID);
clsCheckSql.CheckFieldLen(objUsersEN.Email, 50, conUsers.Email);
clsCheckSql.CheckFieldLen(objUsersEN.RegisterPassword, 30, conUsers.RegisterPassword);
clsCheckSql.CheckFieldLen(objUsersEN.RegisterDate, 14, conUsers.RegisterDate);
clsCheckSql.CheckFieldLen(objUsersEN.AuditUser, 18, conUsers.AuditUser);
clsCheckSql.CheckFieldLen(objUsersEN.AuditDate, 14, conUsers.AuditDate);
clsCheckSql.CheckFieldLen(objUsersEN.UpdDate, 20, conUsers.UpdDate);
clsCheckSql.CheckFieldLen(objUsersEN.UpdUser, 20, conUsers.UpdUser);
clsCheckSql.CheckFieldLen(objUsersEN.Memo, 1000, conUsers.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UserId, conUsers.UserId);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UserName, conUsers.UserName);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.DepartmentId, conUsers.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UserStateId, conUsers.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.RoleId, conUsers.RoleId);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.EffectiveDate, conUsers.EffectiveDate);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.EffitiveBeginDate, conUsers.EffitiveBeginDate);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.EffitiveEndDate, conUsers.EffitiveEndDate);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.Password, conUsers.Password);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.IdentityID, conUsers.IdentityID);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.Email, conUsers.Email);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.RegisterPassword, conUsers.RegisterPassword);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.RegisterDate, conUsers.RegisterDate);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.AuditUser, conUsers.AuditUser);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.AuditDate, conUsers.AuditDate);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UpdDate, conUsers.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.UpdUser, conUsers.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objUsersEN.Memo, conUsers.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUsersEN.UserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(objUsersEN.RoleId, 8, conUsers.RoleId);
 objUsersEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetUserId()
{
//获取某学院所有专业信息
string strSQL = "select UserId, UserName from Users ";
 clsSpecSQLforSql mySql = clsUsersDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsUsersDA.GetSpecSQLObj();
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
 objSQL = clsUsersDA.GetSpecSQLObj();
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
 objSQL = clsUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUsersEN._CurrTabName);
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
 objSQL = clsUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUsersEN._CurrTabName, strCondition);
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
 objSQL = clsUsersDA.GetSpecSQLObj();
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
 objSQL = clsUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}