
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserLinkRelaDA
 表名:vUserLinkRela(00050166)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:55
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
 /// v用户链接关系(vUserLinkRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUserLinkRelaDA : clsCommBase4DA
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
 return clsvUserLinkRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUserLinkRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserLinkRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUserLinkRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUserLinkRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from vUserLinkRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUserLinkRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetDataTable_vUserLinkRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from vUserLinkRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from vUserLinkRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserLinkRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserLinkRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUserLinkRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUserLinkRela.* " + 
$"from vUserLinkRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUserLinkRela.mId not in " + 
$"(Select top {intTop_In} vUserLinkRela.mId from vUserLinkRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserLinkRela where {1} and mId not in (Select top {2} mId from vUserLinkRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserLinkRela where {1} and mId not in (Select top {3} mId from vUserLinkRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUserLinkRela.* " + 
$"from vUserLinkRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUserLinkRela.mId not in " + 
$"(Select top {intTop_In} vUserLinkRela.mId from vUserLinkRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserLinkRela where {1} and mId not in (Select top {2} mId from vUserLinkRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserLinkRela where {1} and mId not in (Select top {3} mId from vUserLinkRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUserLinkRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA:GetObjLst)", objException.Message));
}
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from vUserLinkRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = TransNullToInt(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserLinkRelaDA: GetObjLst)", objException.Message));
}
objvUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserLinkRelaEN);
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
public List<clsvUserLinkRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUserLinkRelaEN> arrObjLst = new List<clsvUserLinkRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = TransNullToInt(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserLinkRelaDA: GetObjLst)", objException.Message));
}
objvUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserLinkRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUserLinkRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUserLinkRela(ref clsvUserLinkRelaEN objvUserLinkRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from vUserLinkRela where mId = " + ""+ objvUserLinkRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUserLinkRelaEN.mId = TransNullToInt(objDT.Rows[0][convUserLinkRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserLinkRelaEN.UserId = objDT.Rows[0][convUserLinkRela.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserLinkRelaEN.LinkName = objDT.Rows[0][convUserLinkRela.LinkName].ToString().Trim(); //链接名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserLinkRelaEN.DataBaseTypeName = objDT.Rows[0][convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserLinkRelaEN.DataBaseTypeId = objDT.Rows[0][convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvUserLinkRelaEN.IpAddress = objDT.Rows[0][convUserLinkRela.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objvUserLinkRelaEN.DataBasePwd = objDT.Rows[0][convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserLinkRelaEN.DataBaseUserId = objDT.Rows[0][convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserLinkRelaEN.DataBaseName = objDT.Rows[0][convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvUserLinkRelaEN.Sid = objDT.Rows[0][convUserLinkRela.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objvUserLinkRelaEN.ConnectionString = objDT.Rows[0][convUserLinkRela.ConnectionString].ToString().Trim(); //连接串(字段类型:varchar,字段长度:200,是否可空:False)
 objvUserLinkRelaEN.Memo = objDT.Rows[0][convUserLinkRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUserLinkRelaDA: GetvUserLinkRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUserLinkRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from vUserLinkRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
 objvUserLinkRelaEN.mId = Int32.Parse(objRow[convUserLinkRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串(字段类型:varchar,字段长度:200,是否可空:False)
 objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUserLinkRelaDA: GetObjBymId)", objException.Message));
}
return objvUserLinkRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUserLinkRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
strSQL = "Select * from vUserLinkRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN()
{
mId = TransNullToInt(objRow[convUserLinkRela.mId].ToString().Trim()), //mId
UserId = objRow[convUserLinkRela.UserId].ToString().Trim(), //用户Id
LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(), //链接名称
DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(), //数据库类型名
DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(), //数据库类型ID
IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(), //服务器
DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(), //数据库的用户口令
DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(), //数据库的用户ID
DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(), //数据库名
Sid = objRow[convUserLinkRela.Sid].ToString().Trim(), //SID
ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(), //连接串
Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim() //说明
};
objvUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserLinkRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUserLinkRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUserLinkRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = TransNullToInt(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUserLinkRelaDA: GetObjByDataRowvUserLinkRela)", objException.Message));
}
objvUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserLinkRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUserLinkRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserLinkRelaEN objvUserLinkRelaEN = new clsvUserLinkRelaEN();
try
{
objvUserLinkRelaEN.mId = TransNullToInt(objRow[convUserLinkRela.mId].ToString().Trim()); //mId
objvUserLinkRelaEN.UserId = objRow[convUserLinkRela.UserId].ToString().Trim(); //用户Id
objvUserLinkRelaEN.LinkName = objRow[convUserLinkRela.LinkName].ToString().Trim(); //链接名称
objvUserLinkRelaEN.DataBaseTypeName = objRow[convUserLinkRela.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvUserLinkRelaEN.DataBaseTypeId = objRow[convUserLinkRela.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvUserLinkRelaEN.IpAddress = objRow[convUserLinkRela.IpAddress].ToString().Trim(); //服务器
objvUserLinkRelaEN.DataBasePwd = objRow[convUserLinkRela.DataBasePwd] == DBNull.Value ? null : objRow[convUserLinkRela.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvUserLinkRelaEN.DataBaseUserId = objRow[convUserLinkRela.DataBaseUserId] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserLinkRelaEN.DataBaseName = objRow[convUserLinkRela.DataBaseName] == DBNull.Value ? null : objRow[convUserLinkRela.DataBaseName].ToString().Trim(); //数据库名
objvUserLinkRelaEN.Sid = objRow[convUserLinkRela.Sid].ToString().Trim(); //SID
objvUserLinkRelaEN.ConnectionString = objRow[convUserLinkRela.ConnectionString].ToString().Trim(); //连接串
objvUserLinkRelaEN.Memo = objRow[convUserLinkRela.Memo] == DBNull.Value ? null : objRow[convUserLinkRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUserLinkRelaDA: GetObjByDataRow)", objException.Message));
}
objvUserLinkRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserLinkRelaEN;
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
objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserLinkRelaEN._CurrTabName, convUserLinkRela.mId, 8, "");
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
objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserLinkRelaEN._CurrTabName, convUserLinkRela.mId, 8, strPrefix);
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
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vUserLinkRela where " + strCondition;
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
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vUserLinkRela where " + strCondition;
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
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserLinkRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUserLinkRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserLinkRela", strCondition))
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
objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUserLinkRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUserLinkRelaENS">源对象</param>
 /// <param name = "objvUserLinkRelaENT">目标对象</param>
public void CopyTo(clsvUserLinkRelaEN objvUserLinkRelaENS, clsvUserLinkRelaEN objvUserLinkRelaENT)
{
objvUserLinkRelaENT.mId = objvUserLinkRelaENS.mId; //mId
objvUserLinkRelaENT.UserId = objvUserLinkRelaENS.UserId; //用户Id
objvUserLinkRelaENT.LinkName = objvUserLinkRelaENS.LinkName; //链接名称
objvUserLinkRelaENT.DataBaseTypeName = objvUserLinkRelaENS.DataBaseTypeName; //数据库类型名
objvUserLinkRelaENT.DataBaseTypeId = objvUserLinkRelaENS.DataBaseTypeId; //数据库类型ID
objvUserLinkRelaENT.IpAddress = objvUserLinkRelaENS.IpAddress; //服务器
objvUserLinkRelaENT.DataBasePwd = objvUserLinkRelaENS.DataBasePwd; //数据库的用户口令
objvUserLinkRelaENT.DataBaseUserId = objvUserLinkRelaENS.DataBaseUserId; //数据库的用户ID
objvUserLinkRelaENT.DataBaseName = objvUserLinkRelaENS.DataBaseName; //数据库名
objvUserLinkRelaENT.Sid = objvUserLinkRelaENS.Sid; //SID
objvUserLinkRelaENT.ConnectionString = objvUserLinkRelaENS.ConnectionString; //连接串
objvUserLinkRelaENT.Memo = objvUserLinkRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUserLinkRelaEN objvUserLinkRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.UserId, 18, convUserLinkRela.UserId);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.LinkName, 30, convUserLinkRela.LinkName);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.DataBaseTypeName, 30, convUserLinkRela.DataBaseTypeName);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.DataBaseTypeId, 2, convUserLinkRela.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.IpAddress, 25, convUserLinkRela.IpAddress);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.DataBasePwd, 30, convUserLinkRela.DataBasePwd);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.DataBaseUserId, 30, convUserLinkRela.DataBaseUserId);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.DataBaseName, 50, convUserLinkRela.DataBaseName);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.Sid, 50, convUserLinkRela.Sid);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.ConnectionString, 200, convUserLinkRela.ConnectionString);
clsCheckSql.CheckFieldLen(objvUserLinkRelaEN.Memo, 1000, convUserLinkRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.UserId, convUserLinkRela.UserId);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.LinkName, convUserLinkRela.LinkName);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.DataBaseTypeName, convUserLinkRela.DataBaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.DataBaseTypeId, convUserLinkRela.DataBaseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.IpAddress, convUserLinkRela.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.DataBasePwd, convUserLinkRela.DataBasePwd);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.DataBaseUserId, convUserLinkRela.DataBaseUserId);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.DataBaseName, convUserLinkRela.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.Sid, convUserLinkRela.Sid);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.ConnectionString, convUserLinkRela.ConnectionString);
clsCheckSql.CheckSqlInjection4Field(objvUserLinkRelaEN.Memo, convUserLinkRela.Memo);
//检查外键字段长度
 objvUserLinkRelaEN._IsCheckProperty = true;
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
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
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
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
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
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserLinkRelaEN._CurrTabName);
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
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserLinkRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvUserLinkRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}