
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersDA
 表名:vUsers(00050261)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:12
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
 /// v用于用户管理(vUsers)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUsersDA : clsCommBase4DA
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
 return clsvUsersEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUsersEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUsersEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUsersEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUsersEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vUsers中,检查关键字,长度不正确!(clsvUsersDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vUsers中,关键字不能为空 或 null!(clsvUsersDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvUsersDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUsers(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable_vUsers)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUsers where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUsers.* " + 
$"from vUsers " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUsers.UserId not in " + 
$"(Select top {intTop_In} vUsers.UserId from vUsers " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} and UserId not in (Select top {2} UserId from vUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} and UserId not in (Select top {3} UserId from vUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUsers.* " + 
$"from vUsers " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUsers.UserId not in " + 
$"(Select top {intTop_In} vUsers.UserId from vUsers " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} and UserId not in (Select top {2} UserId from vUsers where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUsers where {1} and UserId not in (Select top {3} UserId from vUsers where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUsersEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUsersDA:GetObjLst)", objException.Message));
}
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户Id
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName] == DBNull.Value ? null : objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.DepartmentAbbrName = objRow[convUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convUsers.DepartmentAbbrName].ToString().Trim(); //部门简称
objvUsersEN.DepartmentTypeId = objRow[convUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvUsersEN.UpDepartmentId = objRow[convUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convUsers.UpDepartmentId].ToString().Trim(); //上级部门Id
objvUsersEN.DepartmentTypeName = objRow[convUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeName].ToString().Trim(); //部门类型
objvUsersEN.UpDepartmentName = objRow[convUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convUsers.UpDepartmentName].ToString().Trim(); //上级部门名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId] == DBNull.Value ? null : objRow[convUsers.UserStateId].ToString().Trim(); //用户状态号
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.EffectiveDate = objRow[convUsers.EffectiveDate] == DBNull.Value ? null : objRow[convUsers.EffectiveDate].ToString().Trim(); //有效日期
objvUsersEN.EffitiveBeginDate = objRow[convUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvUsersEN.EffitiveEndDate = objRow[convUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IdentityID = objRow[convUsers.IdentityID] == DBNull.Value ? null : objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()); //是否平台用户
objvUsersEN.RegisterPassword = objRow[convUsers.RegisterPassword] == DBNull.Value ? null : objRow[convUsers.RegisterPassword].ToString().Trim(); //注册密码
objvUsersEN.IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()); //是否注册
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //注册日期
objvUsersEN.IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //审核人
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //审核日期
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改者
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUsersDA: GetObjLst)", objException.Message));
}
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUsersEN);
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
public List<clsvUsersEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUsersDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUsersEN> arrObjLst = new List<clsvUsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户Id
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName] == DBNull.Value ? null : objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.DepartmentAbbrName = objRow[convUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convUsers.DepartmentAbbrName].ToString().Trim(); //部门简称
objvUsersEN.DepartmentTypeId = objRow[convUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvUsersEN.UpDepartmentId = objRow[convUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convUsers.UpDepartmentId].ToString().Trim(); //上级部门Id
objvUsersEN.DepartmentTypeName = objRow[convUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeName].ToString().Trim(); //部门类型
objvUsersEN.UpDepartmentName = objRow[convUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convUsers.UpDepartmentName].ToString().Trim(); //上级部门名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId] == DBNull.Value ? null : objRow[convUsers.UserStateId].ToString().Trim(); //用户状态号
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.EffectiveDate = objRow[convUsers.EffectiveDate] == DBNull.Value ? null : objRow[convUsers.EffectiveDate].ToString().Trim(); //有效日期
objvUsersEN.EffitiveBeginDate = objRow[convUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvUsersEN.EffitiveEndDate = objRow[convUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IdentityID = objRow[convUsers.IdentityID] == DBNull.Value ? null : objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()); //是否平台用户
objvUsersEN.RegisterPassword = objRow[convUsers.RegisterPassword] == DBNull.Value ? null : objRow[convUsers.RegisterPassword].ToString().Trim(); //注册密码
objvUsersEN.IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()); //是否注册
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //注册日期
objvUsersEN.IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //审核人
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //审核日期
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改者
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUsersDA: GetObjLst)", objException.Message));
}
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUsersEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUsers(ref clsvUsersEN objvUsersEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where UserId = " + "'"+ objvUsersEN.UserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUsersEN.UserId = objDT.Rows[0][convUsers.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsersEN.UserName = objDT.Rows[0][convUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUsersEN.DepartmentId = objDT.Rows[0][convUsers.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objvUsersEN.DepartmentName = objDT.Rows[0][convUsers.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUsersEN.DepartmentAbbrName = objDT.Rows[0][convUsers.DepartmentAbbrName].ToString().Trim(); //部门简称(字段类型:varchar,字段长度:8,是否可空:True)
 objvUsersEN.DepartmentTypeId = objDT.Rows[0][convUsers.DepartmentTypeId].ToString().Trim(); //部门类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvUsersEN.UpDepartmentId = objDT.Rows[0][convUsers.UpDepartmentId].ToString().Trim(); //上级部门Id(字段类型:varchar,字段长度:6,是否可空:True)
 objvUsersEN.DepartmentTypeName = objDT.Rows[0][convUsers.DepartmentTypeName].ToString().Trim(); //部门类型(字段类型:varchar,字段长度:50,是否可空:True)
 objvUsersEN.UpDepartmentName = objDT.Rows[0][convUsers.UpDepartmentName].ToString().Trim(); //上级部门名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUsersEN.UserStateId = objDT.Rows[0][convUsers.UserStateId].ToString().Trim(); //用户状态号(字段类型:char,字段长度:2,是否可空:True)
 objvUsersEN.UserStateName = objDT.Rows[0][convUsers.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvUsersEN.EffectiveDate = objDT.Rows[0][convUsers.EffectiveDate].ToString().Trim(); //有效日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvUsersEN.EffitiveBeginDate = objDT.Rows[0][convUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvUsersEN.EffitiveEndDate = objDT.Rows[0][convUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvUsersEN.Password = objDT.Rows[0][convUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvUsersEN.IdentityID = objDT.Rows[0][convUsers.IdentityID].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvUsersEN.IdentityDesc = objDT.Rows[0][convUsers.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvUsersEN.Email = objDT.Rows[0][convUsers.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:50,是否可空:True)
 objvUsersEN.IsGpUser = TransNullToBool(objDT.Rows[0][convUsers.IsGpUser].ToString().Trim()); //是否平台用户(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.RegisterPassword = objDT.Rows[0][convUsers.RegisterPassword].ToString().Trim(); //注册密码(字段类型:varchar,字段长度:30,是否可空:True)
 objvUsersEN.IsRegister = TransNullToBool(objDT.Rows[0][convUsers.IsRegister].ToString().Trim()); //是否注册(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.RegisterDate = objDT.Rows[0][convUsers.RegisterDate].ToString().Trim(); //注册日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsersEN.IsAudit = TransNullToBool(objDT.Rows[0][convUsers.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.AuditUser = objDT.Rows[0][convUsers.AuditUser].ToString().Trim(); //审核人(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsersEN.AuditDate = objDT.Rows[0][convUsers.AuditDate].ToString().Trim(); //审核日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsersEN.UpdDate = objDT.Rows[0][convUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.UpdUser = objDT.Rows[0][convUsers.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.Memo = objDT.Rows[0][convUsers.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUsersDA: GetvUsers)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUsersEN GetObjByUserId(string strUserId)
{
CheckPrimaryKey(strUserId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where UserId = " + "'"+ strUserId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
 objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName] == DBNull.Value ? null : objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUsersEN.DepartmentAbbrName = objRow[convUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convUsers.DepartmentAbbrName].ToString().Trim(); //部门简称(字段类型:varchar,字段长度:8,是否可空:True)
 objvUsersEN.DepartmentTypeId = objRow[convUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeId].ToString().Trim(); //部门类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvUsersEN.UpDepartmentId = objRow[convUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convUsers.UpDepartmentId].ToString().Trim(); //上级部门Id(字段类型:varchar,字段长度:6,是否可空:True)
 objvUsersEN.DepartmentTypeName = objRow[convUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeName].ToString().Trim(); //部门类型(字段类型:varchar,字段长度:50,是否可空:True)
 objvUsersEN.UpDepartmentName = objRow[convUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convUsers.UpDepartmentName].ToString().Trim(); //上级部门名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUsersEN.UserStateId = objRow[convUsers.UserStateId] == DBNull.Value ? null : objRow[convUsers.UserStateId].ToString().Trim(); //用户状态号(字段类型:char,字段长度:2,是否可空:True)
 objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvUsersEN.EffectiveDate = objRow[convUsers.EffectiveDate] == DBNull.Value ? null : objRow[convUsers.EffectiveDate].ToString().Trim(); //有效日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvUsersEN.EffitiveBeginDate = objRow[convUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvUsersEN.EffitiveEndDate = objRow[convUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期(字段类型:varchar,字段长度:14,是否可空:False)
 objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:False)
 objvUsersEN.IdentityID = objRow[convUsers.IdentityID] == DBNull.Value ? null : objRow[convUsers.IdentityID].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:50,是否可空:True)
 objvUsersEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsGpUser].ToString().Trim()); //是否平台用户(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.RegisterPassword = objRow[convUsers.RegisterPassword] == DBNull.Value ? null : objRow[convUsers.RegisterPassword].ToString().Trim(); //注册密码(字段类型:varchar,字段长度:30,是否可空:True)
 objvUsersEN.IsRegister = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsRegister].ToString().Trim()); //是否注册(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //注册日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsersEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核(字段类型:bit,字段长度:1,是否可空:True)
 objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //审核人(字段类型:varchar,字段长度:18,是否可空:True)
 objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //审核日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUsersDA: GetObjByUserId)", objException.Message));
}
return objvUsersEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUsersEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUsersDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
strSQL = "Select * from vUsers where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUsersEN objvUsersEN = new clsvUsersEN()
{
UserId = objRow[convUsers.UserId].ToString().Trim(), //用户Id
UserName = objRow[convUsers.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(), //部门ID
DepartmentName = objRow[convUsers.DepartmentName] == DBNull.Value ? null : objRow[convUsers.DepartmentName].ToString().Trim(), //部门名称
DepartmentAbbrName = objRow[convUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convUsers.DepartmentAbbrName].ToString().Trim(), //部门简称
DepartmentTypeId = objRow[convUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeId].ToString().Trim(), //部门类型Id
UpDepartmentId = objRow[convUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convUsers.UpDepartmentId].ToString().Trim(), //上级部门Id
DepartmentTypeName = objRow[convUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeName].ToString().Trim(), //部门类型
UpDepartmentName = objRow[convUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convUsers.UpDepartmentName].ToString().Trim(), //上级部门名
UserStateId = objRow[convUsers.UserStateId] == DBNull.Value ? null : objRow[convUsers.UserStateId].ToString().Trim(), //用户状态号
UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(), //用户状态名
EffectiveDate = objRow[convUsers.EffectiveDate] == DBNull.Value ? null : objRow[convUsers.EffectiveDate].ToString().Trim(), //有效日期
EffitiveBeginDate = objRow[convUsers.EffitiveBeginDate].ToString().Trim(), //有效开始日期
EffitiveEndDate = objRow[convUsers.EffitiveEndDate].ToString().Trim(), //有效结束日期
Password = objRow[convUsers.Password].ToString().Trim(), //口令
IdentityID = objRow[convUsers.IdentityID] == DBNull.Value ? null : objRow[convUsers.IdentityID].ToString().Trim(), //身份编号
IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(), //身份描述
Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(), //电子邮箱
IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()), //是否平台用户
RegisterPassword = objRow[convUsers.RegisterPassword] == DBNull.Value ? null : objRow[convUsers.RegisterPassword].ToString().Trim(), //注册密码
IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()), //是否注册
RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(), //注册日期
IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()), //是否审核
AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(), //审核人
AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(), //审核日期
UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim() //说明
};
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUsersEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUsersDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUsersEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户Id
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName] == DBNull.Value ? null : objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.DepartmentAbbrName = objRow[convUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convUsers.DepartmentAbbrName].ToString().Trim(); //部门简称
objvUsersEN.DepartmentTypeId = objRow[convUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvUsersEN.UpDepartmentId = objRow[convUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convUsers.UpDepartmentId].ToString().Trim(); //上级部门Id
objvUsersEN.DepartmentTypeName = objRow[convUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeName].ToString().Trim(); //部门类型
objvUsersEN.UpDepartmentName = objRow[convUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convUsers.UpDepartmentName].ToString().Trim(); //上级部门名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId] == DBNull.Value ? null : objRow[convUsers.UserStateId].ToString().Trim(); //用户状态号
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.EffectiveDate = objRow[convUsers.EffectiveDate] == DBNull.Value ? null : objRow[convUsers.EffectiveDate].ToString().Trim(); //有效日期
objvUsersEN.EffitiveBeginDate = objRow[convUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvUsersEN.EffitiveEndDate = objRow[convUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IdentityID = objRow[convUsers.IdentityID] == DBNull.Value ? null : objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()); //是否平台用户
objvUsersEN.RegisterPassword = objRow[convUsers.RegisterPassword] == DBNull.Value ? null : objRow[convUsers.RegisterPassword].ToString().Trim(); //注册密码
objvUsersEN.IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()); //是否注册
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //注册日期
objvUsersEN.IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //审核人
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //审核日期
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改者
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUsersDA: GetObjByDataRowvUsers)", objException.Message));
}
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUsersEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUsersEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUsersEN objvUsersEN = new clsvUsersEN();
try
{
objvUsersEN.UserId = objRow[convUsers.UserId].ToString().Trim(); //用户Id
objvUsersEN.UserName = objRow[convUsers.UserName].ToString().Trim(); //用户名
objvUsersEN.DepartmentId = objRow[convUsers.DepartmentId].ToString().Trim(); //部门ID
objvUsersEN.DepartmentName = objRow[convUsers.DepartmentName] == DBNull.Value ? null : objRow[convUsers.DepartmentName].ToString().Trim(); //部门名称
objvUsersEN.DepartmentAbbrName = objRow[convUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convUsers.DepartmentAbbrName].ToString().Trim(); //部门简称
objvUsersEN.DepartmentTypeId = objRow[convUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvUsersEN.UpDepartmentId = objRow[convUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convUsers.UpDepartmentId].ToString().Trim(); //上级部门Id
objvUsersEN.DepartmentTypeName = objRow[convUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convUsers.DepartmentTypeName].ToString().Trim(); //部门类型
objvUsersEN.UpDepartmentName = objRow[convUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convUsers.UpDepartmentName].ToString().Trim(); //上级部门名
objvUsersEN.UserStateId = objRow[convUsers.UserStateId] == DBNull.Value ? null : objRow[convUsers.UserStateId].ToString().Trim(); //用户状态号
objvUsersEN.UserStateName = objRow[convUsers.UserStateName] == DBNull.Value ? null : objRow[convUsers.UserStateName].ToString().Trim(); //用户状态名
objvUsersEN.EffectiveDate = objRow[convUsers.EffectiveDate] == DBNull.Value ? null : objRow[convUsers.EffectiveDate].ToString().Trim(); //有效日期
objvUsersEN.EffitiveBeginDate = objRow[convUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvUsersEN.EffitiveEndDate = objRow[convUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvUsersEN.Password = objRow[convUsers.Password].ToString().Trim(); //口令
objvUsersEN.IdentityID = objRow[convUsers.IdentityID] == DBNull.Value ? null : objRow[convUsers.IdentityID].ToString().Trim(); //身份编号
objvUsersEN.IdentityDesc = objRow[convUsers.IdentityDesc] == DBNull.Value ? null : objRow[convUsers.IdentityDesc].ToString().Trim(); //身份描述
objvUsersEN.Email = objRow[convUsers.Email] == DBNull.Value ? null : objRow[convUsers.Email].ToString().Trim(); //电子邮箱
objvUsersEN.IsGpUser = TransNullToBool(objRow[convUsers.IsGpUser].ToString().Trim()); //是否平台用户
objvUsersEN.RegisterPassword = objRow[convUsers.RegisterPassword] == DBNull.Value ? null : objRow[convUsers.RegisterPassword].ToString().Trim(); //注册密码
objvUsersEN.IsRegister = TransNullToBool(objRow[convUsers.IsRegister].ToString().Trim()); //是否注册
objvUsersEN.RegisterDate = objRow[convUsers.RegisterDate] == DBNull.Value ? null : objRow[convUsers.RegisterDate].ToString().Trim(); //注册日期
objvUsersEN.IsAudit = TransNullToBool(objRow[convUsers.IsAudit].ToString().Trim()); //是否审核
objvUsersEN.AuditUser = objRow[convUsers.AuditUser] == DBNull.Value ? null : objRow[convUsers.AuditUser].ToString().Trim(); //审核人
objvUsersEN.AuditDate = objRow[convUsers.AuditDate] == DBNull.Value ? null : objRow[convUsers.AuditDate].ToString().Trim(); //审核日期
objvUsersEN.UpdDate = objRow[convUsers.UpdDate] == DBNull.Value ? null : objRow[convUsers.UpdDate].ToString().Trim(); //修改日期
objvUsersEN.UpdUser = objRow[convUsers.UpdUser] == DBNull.Value ? null : objRow[convUsers.UpdUser].ToString().Trim(); //修改者
objvUsersEN.Memo = objRow[convUsers.Memo] == DBNull.Value ? null : objRow[convUsers.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUsersDA: GetObjByDataRow)", objException.Message));
}
objvUsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUsersEN;
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
objSQL = clsvUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUsersEN._CurrTabName, convUsers.UserId, 18, "");
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
objSQL = clsvUsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUsersEN._CurrTabName, convUsers.UserId, 18, strPrefix);
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserId from vUsers where " + strCondition;
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserId from vUsers where " + strCondition;
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUsers", "UserId = " + "'"+ strUserId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUsersDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUsers", strCondition))
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
objSQL = clsvUsersDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUsers");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUsersENS">源对象</param>
 /// <param name = "objvUsersENT">目标对象</param>
public void CopyTo(clsvUsersEN objvUsersENS, clsvUsersEN objvUsersENT)
{
objvUsersENT.UserId = objvUsersENS.UserId; //用户Id
objvUsersENT.UserName = objvUsersENS.UserName; //用户名
objvUsersENT.DepartmentId = objvUsersENS.DepartmentId; //部门ID
objvUsersENT.DepartmentName = objvUsersENS.DepartmentName; //部门名称
objvUsersENT.DepartmentAbbrName = objvUsersENS.DepartmentAbbrName; //部门简称
objvUsersENT.DepartmentTypeId = objvUsersENS.DepartmentTypeId; //部门类型Id
objvUsersENT.UpDepartmentId = objvUsersENS.UpDepartmentId; //上级部门Id
objvUsersENT.DepartmentTypeName = objvUsersENS.DepartmentTypeName; //部门类型
objvUsersENT.UpDepartmentName = objvUsersENS.UpDepartmentName; //上级部门名
objvUsersENT.UserStateId = objvUsersENS.UserStateId; //用户状态号
objvUsersENT.UserStateName = objvUsersENS.UserStateName; //用户状态名
objvUsersENT.EffectiveDate = objvUsersENS.EffectiveDate; //有效日期
objvUsersENT.EffitiveBeginDate = objvUsersENS.EffitiveBeginDate; //有效开始日期
objvUsersENT.EffitiveEndDate = objvUsersENS.EffitiveEndDate; //有效结束日期
objvUsersENT.Password = objvUsersENS.Password; //口令
objvUsersENT.IdentityID = objvUsersENS.IdentityID; //身份编号
objvUsersENT.IdentityDesc = objvUsersENS.IdentityDesc; //身份描述
objvUsersENT.Email = objvUsersENS.Email; //电子邮箱
objvUsersENT.IsGpUser = objvUsersENS.IsGpUser; //是否平台用户
objvUsersENT.RegisterPassword = objvUsersENS.RegisterPassword; //注册密码
objvUsersENT.IsRegister = objvUsersENS.IsRegister; //是否注册
objvUsersENT.RegisterDate = objvUsersENS.RegisterDate; //注册日期
objvUsersENT.IsAudit = objvUsersENS.IsAudit; //是否审核
objvUsersENT.AuditUser = objvUsersENS.AuditUser; //审核人
objvUsersENT.AuditDate = objvUsersENS.AuditDate; //审核日期
objvUsersENT.UpdDate = objvUsersENS.UpdDate; //修改日期
objvUsersENT.UpdUser = objvUsersENS.UpdUser; //修改者
objvUsersENT.Memo = objvUsersENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUsersEN objvUsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUsersEN.UserId, 18, convUsers.UserId);
clsCheckSql.CheckFieldLen(objvUsersEN.UserName, 30, convUsers.UserName);
clsCheckSql.CheckFieldLen(objvUsersEN.DepartmentId, 6, convUsers.DepartmentId);
clsCheckSql.CheckFieldLen(objvUsersEN.DepartmentName, 30, convUsers.DepartmentName);
clsCheckSql.CheckFieldLen(objvUsersEN.DepartmentAbbrName, 8, convUsers.DepartmentAbbrName);
clsCheckSql.CheckFieldLen(objvUsersEN.DepartmentTypeId, 2, convUsers.DepartmentTypeId);
clsCheckSql.CheckFieldLen(objvUsersEN.UpDepartmentId, 6, convUsers.UpDepartmentId);
clsCheckSql.CheckFieldLen(objvUsersEN.DepartmentTypeName, 50, convUsers.DepartmentTypeName);
clsCheckSql.CheckFieldLen(objvUsersEN.UpDepartmentName, 30, convUsers.UpDepartmentName);
clsCheckSql.CheckFieldLen(objvUsersEN.UserStateId, 2, convUsers.UserStateId);
clsCheckSql.CheckFieldLen(objvUsersEN.UserStateName, 20, convUsers.UserStateName);
clsCheckSql.CheckFieldLen(objvUsersEN.EffectiveDate, 8, convUsers.EffectiveDate);
clsCheckSql.CheckFieldLen(objvUsersEN.EffitiveBeginDate, 14, convUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(objvUsersEN.EffitiveEndDate, 14, convUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(objvUsersEN.Password, 20, convUsers.Password);
clsCheckSql.CheckFieldLen(objvUsersEN.IdentityID, 2, convUsers.IdentityID);
clsCheckSql.CheckFieldLen(objvUsersEN.IdentityDesc, 20, convUsers.IdentityDesc);
clsCheckSql.CheckFieldLen(objvUsersEN.Email, 50, convUsers.Email);
clsCheckSql.CheckFieldLen(objvUsersEN.RegisterPassword, 30, convUsers.RegisterPassword);
clsCheckSql.CheckFieldLen(objvUsersEN.RegisterDate, 14, convUsers.RegisterDate);
clsCheckSql.CheckFieldLen(objvUsersEN.AuditUser, 18, convUsers.AuditUser);
clsCheckSql.CheckFieldLen(objvUsersEN.AuditDate, 14, convUsers.AuditDate);
clsCheckSql.CheckFieldLen(objvUsersEN.UpdDate, 20, convUsers.UpdDate);
clsCheckSql.CheckFieldLen(objvUsersEN.UpdUser, 20, convUsers.UpdUser);
clsCheckSql.CheckFieldLen(objvUsersEN.Memo, 1000, convUsers.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UserId, convUsers.UserId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UserName, convUsers.UserName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.DepartmentId, convUsers.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.DepartmentName, convUsers.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.DepartmentAbbrName, convUsers.DepartmentAbbrName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.DepartmentTypeId, convUsers.DepartmentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UpDepartmentId, convUsers.UpDepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.DepartmentTypeName, convUsers.DepartmentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UpDepartmentName, convUsers.UpDepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UserStateId, convUsers.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UserStateName, convUsers.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.EffectiveDate, convUsers.EffectiveDate);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.EffitiveBeginDate, convUsers.EffitiveBeginDate);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.EffitiveEndDate, convUsers.EffitiveEndDate);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.Password, convUsers.Password);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.IdentityID, convUsers.IdentityID);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.IdentityDesc, convUsers.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.Email, convUsers.Email);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.RegisterPassword, convUsers.RegisterPassword);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.RegisterDate, convUsers.RegisterDate);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.AuditUser, convUsers.AuditUser);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.AuditDate, convUsers.AuditDate);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UpdDate, convUsers.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.UpdUser, convUsers.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvUsersEN.Memo, convUsers.Memo);
//检查外键字段长度
 objvUsersEN._IsCheckProperty = true;
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUsersEN._CurrTabName);
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUsersEN._CurrTabName, strCondition);
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
 objSQL = clsvUsersDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}