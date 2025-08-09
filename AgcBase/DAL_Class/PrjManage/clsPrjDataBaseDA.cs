
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjDataBaseDA
 表名:PrjDataBase(00050176)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:07
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
 /// 数据库对象(PrjDataBase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjDataBaseDA : clsCommBase4DA
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
 return clsPrjDataBaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjDataBaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjDataBaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjDataBaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjDataBaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:PrjDataBase中,检查关键字,长度不正确!(clsPrjDataBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjDataBaseId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PrjDataBase中,关键字不能为空 或 null!(clsPrjDataBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjDataBaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPrjDataBaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjDataBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetDataTable_PrjDataBase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjDataBase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjDataBase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjDataBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjDataBase.* " + 
$"from PrjDataBase " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjDataBase.PrjDataBaseId not in " + 
$"(Select top {intTop_In} PrjDataBase.PrjDataBaseId from PrjDataBase " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjDataBase where {1} and PrjDataBaseId not in (Select top {2} PrjDataBaseId from PrjDataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjDataBase where {1} and PrjDataBaseId not in (Select top {3} PrjDataBaseId from PrjDataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjDataBase.* " + 
$"from PrjDataBase " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjDataBase.PrjDataBaseId not in " + 
$"(Select top {intTop_In} PrjDataBase.PrjDataBaseId from PrjDataBase " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjDataBase where {1} and PrjDataBaseId not in (Select top {2} PrjDataBaseId from PrjDataBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjDataBase where {1} and PrjDataBaseId not in (Select top {3} PrjDataBaseId from PrjDataBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjDataBaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjDataBaseDA:GetObjLst)", objException.Message));
}
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjDataBaseDA: GetObjLst)", objException.Message));
}
objPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjDataBaseEN);
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
public List<clsPrjDataBaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjDataBaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjDataBaseDA: GetObjLst)", objException.Message));
}
objPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjDataBaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjDataBase(ref clsPrjDataBaseEN objPrjDataBaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where PrjDataBaseId = " + "'"+ objPrjDataBaseEN.PrjDataBaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjDataBaseEN.PrjDataBaseId = objDT.Rows[0][conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjDataBaseEN.PrjDataBaseName = objDT.Rows[0][conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjDataBaseEN.DataBaseName = objDT.Rows[0][conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjDataBaseEN.DatabaseOwner = objDT.Rows[0][conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjDataBaseEN.DataBasePwd = objDT.Rows[0][conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjDataBaseEN.DataBaseTypeId = objDT.Rows[0][conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objPrjDataBaseEN.DataBaseUserId = objDT.Rows[0][conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjDataBaseEN.IpAddress = objDT.Rows[0][conPrjDataBase.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objPrjDataBaseEN.Sid = objDT.Rows[0][conPrjDataBase.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjDataBaseEN.TableSpace = objDT.Rows[0][conPrjDataBase.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjDataBaseEN.UseStateId = objDT.Rows[0][conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjDataBaseEN.UserId = objDT.Rows[0][conPrjDataBase.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjDataBaseEN.UpdDate = objDT.Rows[0][conPrjDataBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjDataBaseEN.Memo = objDT.Rows[0][conPrjDataBase.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjDataBaseDA: GetPrjDataBase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjDataBaseEN GetObjByPrjDataBaseId(string strPrjDataBaseId)
{
CheckPrimaryKey(strPrjDataBaseId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where PrjDataBaseId = " + "'"+ strPrjDataBaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
 objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID(字段类型:char,字段长度:2,是否可空:False)
 objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjDataBaseDA: GetObjByPrjDataBaseId)", objException.Message));
}
return objPrjDataBaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjDataBaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN()
{
PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(), //项目数据库Id
PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(), //项目数据库名
DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(), //数据库名
DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(), //数据库拥有者
DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(), //数据库的用户口令
DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(), //数据库类型ID
DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(), //数据库的用户ID
IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(), //服务器
Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(), //SID
TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(), //表空间
UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(), //使用状态Id
UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(), //用户Id
UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim() //说明
};
objPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjDataBaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjDataBaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjDataBaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjDataBaseDA: GetObjByDataRowPrjDataBase)", objException.Message));
}
objPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjDataBaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjDataBaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjDataBaseDA: GetObjByDataRow)", objException.Message));
}
objPrjDataBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjDataBaseEN;
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
objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjDataBaseEN._CurrTabName, conPrjDataBase.PrjDataBaseId, 4, "");
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
objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjDataBaseEN._CurrTabName, conPrjDataBase.PrjDataBaseId, 4, strPrefix);
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
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrjDataBaseId from PrjDataBase where " + strCondition;
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
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrjDataBaseId from PrjDataBase where " + strCondition;
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
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjDataBase", "PrjDataBaseId = " + "'"+ strPrjDataBaseId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjDataBaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjDataBase", strCondition))
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
objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjDataBase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjDataBaseEN objPrjDataBaseEN)
 {
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjDataBaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjDataBase");
objRow = objDS.Tables["PrjDataBase"].NewRow();
objRow[conPrjDataBase.PrjDataBaseId] = objPrjDataBaseEN.PrjDataBaseId; //项目数据库Id
objRow[conPrjDataBase.PrjDataBaseName] = objPrjDataBaseEN.PrjDataBaseName; //项目数据库名
 if (objPrjDataBaseEN.DataBaseName !=  "")
 {
objRow[conPrjDataBase.DataBaseName] = objPrjDataBaseEN.DataBaseName; //数据库名
 }
 if (objPrjDataBaseEN.DatabaseOwner !=  "")
 {
objRow[conPrjDataBase.DatabaseOwner] = objPrjDataBaseEN.DatabaseOwner; //数据库拥有者
 }
objRow[conPrjDataBase.DataBasePwd] = objPrjDataBaseEN.DataBasePwd; //数据库的用户口令
 if (objPrjDataBaseEN.DataBaseTypeId !=  "")
 {
objRow[conPrjDataBase.DataBaseTypeId] = objPrjDataBaseEN.DataBaseTypeId; //数据库类型ID
 }
 if (objPrjDataBaseEN.DataBaseUserId !=  "")
 {
objRow[conPrjDataBase.DataBaseUserId] = objPrjDataBaseEN.DataBaseUserId; //数据库的用户ID
 }
 if (objPrjDataBaseEN.IpAddress !=  "")
 {
objRow[conPrjDataBase.IpAddress] = objPrjDataBaseEN.IpAddress; //服务器
 }
 if (objPrjDataBaseEN.Sid !=  "")
 {
objRow[conPrjDataBase.Sid] = objPrjDataBaseEN.Sid; //SID
 }
 if (objPrjDataBaseEN.TableSpace !=  "")
 {
objRow[conPrjDataBase.TableSpace] = objPrjDataBaseEN.TableSpace; //表空间
 }
objRow[conPrjDataBase.UseStateId] = objPrjDataBaseEN.UseStateId; //使用状态Id
 if (objPrjDataBaseEN.UserId !=  "")
 {
objRow[conPrjDataBase.UserId] = objPrjDataBaseEN.UserId; //用户Id
 }
 if (objPrjDataBaseEN.UpdDate !=  "")
 {
objRow[conPrjDataBase.UpdDate] = objPrjDataBaseEN.UpdDate; //修改日期
 }
 if (objPrjDataBaseEN.Memo !=  "")
 {
objRow[conPrjDataBase.Memo] = objPrjDataBaseEN.Memo; //说明
 }
objDS.Tables[clsPrjDataBaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjDataBaseEN._CurrTabName);
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjDataBaseEN objPrjDataBaseEN)
{
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjDataBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjDataBaseEN.PrjDataBaseId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.PrjDataBaseId);
 var strPrjDataBaseId = objPrjDataBaseEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseId + "'");
 }
 
 if (objPrjDataBaseEN.PrjDataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.PrjDataBaseName);
 var strPrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseName + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseName);
 var strDataBaseName = objPrjDataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objPrjDataBaseEN.DatabaseOwner !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DatabaseOwner);
 var strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDatabaseOwner + "'");
 }
 
 if (objPrjDataBaseEN.DataBasePwd !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBasePwd);
 var strDataBasePwd = objPrjDataBaseEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBasePwd + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseTypeId  ==  "")
 {
 objPrjDataBaseEN.DataBaseTypeId = null;
 }
 if (objPrjDataBaseEN.DataBaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseTypeId);
 var strDataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseTypeId + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseUserId);
 var strDataBaseUserId = objPrjDataBaseEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseUserId + "'");
 }
 
 if (objPrjDataBaseEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.IpAddress);
 var strIpAddress = objPrjDataBaseEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objPrjDataBaseEN.Sid !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.Sid);
 var strSid = objPrjDataBaseEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSid + "'");
 }
 
 if (objPrjDataBaseEN.TableSpace !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.TableSpace);
 var strTableSpace = objPrjDataBaseEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableSpace + "'");
 }
 
 if (objPrjDataBaseEN.UseStateId  ==  "")
 {
 objPrjDataBaseEN.UseStateId = null;
 }
 if (objPrjDataBaseEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UseStateId);
 var strUseStateId = objPrjDataBaseEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objPrjDataBaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UserId);
 var strUserId = objPrjDataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjDataBaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UpdDate);
 var strUpdDate = objPrjDataBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjDataBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.Memo);
 var strMemo = objPrjDataBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjDataBase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjDataBaseEN objPrjDataBaseEN)
{
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjDataBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjDataBaseEN.PrjDataBaseId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.PrjDataBaseId);
 var strPrjDataBaseId = objPrjDataBaseEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseId + "'");
 }
 
 if (objPrjDataBaseEN.PrjDataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.PrjDataBaseName);
 var strPrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseName + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseName);
 var strDataBaseName = objPrjDataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objPrjDataBaseEN.DatabaseOwner !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DatabaseOwner);
 var strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDatabaseOwner + "'");
 }
 
 if (objPrjDataBaseEN.DataBasePwd !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBasePwd);
 var strDataBasePwd = objPrjDataBaseEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBasePwd + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseTypeId  ==  "")
 {
 objPrjDataBaseEN.DataBaseTypeId = null;
 }
 if (objPrjDataBaseEN.DataBaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseTypeId);
 var strDataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseTypeId + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseUserId);
 var strDataBaseUserId = objPrjDataBaseEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseUserId + "'");
 }
 
 if (objPrjDataBaseEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.IpAddress);
 var strIpAddress = objPrjDataBaseEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objPrjDataBaseEN.Sid !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.Sid);
 var strSid = objPrjDataBaseEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSid + "'");
 }
 
 if (objPrjDataBaseEN.TableSpace !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.TableSpace);
 var strTableSpace = objPrjDataBaseEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableSpace + "'");
 }
 
 if (objPrjDataBaseEN.UseStateId  ==  "")
 {
 objPrjDataBaseEN.UseStateId = null;
 }
 if (objPrjDataBaseEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UseStateId);
 var strUseStateId = objPrjDataBaseEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objPrjDataBaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UserId);
 var strUserId = objPrjDataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjDataBaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UpdDate);
 var strUpdDate = objPrjDataBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjDataBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.Memo);
 var strMemo = objPrjDataBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjDataBase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPrjDataBaseEN.PrjDataBaseId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjDataBaseEN objPrjDataBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjDataBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjDataBaseEN.PrjDataBaseId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.PrjDataBaseId);
 var strPrjDataBaseId = objPrjDataBaseEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseId + "'");
 }
 
 if (objPrjDataBaseEN.PrjDataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.PrjDataBaseName);
 var strPrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseName + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseName);
 var strDataBaseName = objPrjDataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objPrjDataBaseEN.DatabaseOwner !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DatabaseOwner);
 var strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDatabaseOwner + "'");
 }
 
 if (objPrjDataBaseEN.DataBasePwd !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBasePwd);
 var strDataBasePwd = objPrjDataBaseEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBasePwd + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseTypeId  ==  "")
 {
 objPrjDataBaseEN.DataBaseTypeId = null;
 }
 if (objPrjDataBaseEN.DataBaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseTypeId);
 var strDataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseTypeId + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseUserId);
 var strDataBaseUserId = objPrjDataBaseEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseUserId + "'");
 }
 
 if (objPrjDataBaseEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.IpAddress);
 var strIpAddress = objPrjDataBaseEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objPrjDataBaseEN.Sid !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.Sid);
 var strSid = objPrjDataBaseEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSid + "'");
 }
 
 if (objPrjDataBaseEN.TableSpace !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.TableSpace);
 var strTableSpace = objPrjDataBaseEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableSpace + "'");
 }
 
 if (objPrjDataBaseEN.UseStateId  ==  "")
 {
 objPrjDataBaseEN.UseStateId = null;
 }
 if (objPrjDataBaseEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UseStateId);
 var strUseStateId = objPrjDataBaseEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objPrjDataBaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UserId);
 var strUserId = objPrjDataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjDataBaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UpdDate);
 var strUpdDate = objPrjDataBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjDataBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.Memo);
 var strMemo = objPrjDataBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjDataBase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPrjDataBaseEN.PrjDataBaseId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjDataBaseEN objPrjDataBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjDataBaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjDataBaseEN.PrjDataBaseId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.PrjDataBaseId);
 var strPrjDataBaseId = objPrjDataBaseEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseId + "'");
 }
 
 if (objPrjDataBaseEN.PrjDataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.PrjDataBaseName);
 var strPrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseName + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseName);
 var strDataBaseName = objPrjDataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objPrjDataBaseEN.DatabaseOwner !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DatabaseOwner);
 var strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDatabaseOwner + "'");
 }
 
 if (objPrjDataBaseEN.DataBasePwd !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBasePwd);
 var strDataBasePwd = objPrjDataBaseEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBasePwd + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseTypeId  ==  "")
 {
 objPrjDataBaseEN.DataBaseTypeId = null;
 }
 if (objPrjDataBaseEN.DataBaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseTypeId);
 var strDataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseTypeId + "'");
 }
 
 if (objPrjDataBaseEN.DataBaseUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.DataBaseUserId);
 var strDataBaseUserId = objPrjDataBaseEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseUserId + "'");
 }
 
 if (objPrjDataBaseEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.IpAddress);
 var strIpAddress = objPrjDataBaseEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objPrjDataBaseEN.Sid !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.Sid);
 var strSid = objPrjDataBaseEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSid + "'");
 }
 
 if (objPrjDataBaseEN.TableSpace !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.TableSpace);
 var strTableSpace = objPrjDataBaseEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableSpace + "'");
 }
 
 if (objPrjDataBaseEN.UseStateId  ==  "")
 {
 objPrjDataBaseEN.UseStateId = null;
 }
 if (objPrjDataBaseEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UseStateId);
 var strUseStateId = objPrjDataBaseEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objPrjDataBaseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UserId);
 var strUserId = objPrjDataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjDataBaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.UpdDate);
 var strUpdDate = objPrjDataBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjDataBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjDataBase.Memo);
 var strMemo = objPrjDataBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjDataBase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjDataBases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where PrjDataBaseId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjDataBase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPrjDataBaseId = oRow[conPrjDataBase.PrjDataBaseId].ToString().Trim();
if (IsExist(strPrjDataBaseId))
{
 string strResult = "关键字变量值为:" + string.Format("PrjDataBaseId = {0}", strPrjDataBaseId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjDataBaseEN._CurrTabName ].NewRow();
objRow[conPrjDataBase.PrjDataBaseId] = oRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objRow[conPrjDataBase.PrjDataBaseName] = oRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objRow[conPrjDataBase.DataBaseName] = oRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objRow[conPrjDataBase.DatabaseOwner] = oRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objRow[conPrjDataBase.DataBasePwd] = oRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objRow[conPrjDataBase.DataBaseTypeId] = oRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objRow[conPrjDataBase.DataBaseUserId] = oRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objRow[conPrjDataBase.IpAddress] = oRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objRow[conPrjDataBase.Sid] = oRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objRow[conPrjDataBase.TableSpace] = oRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objRow[conPrjDataBase.UseStateId] = oRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objRow[conPrjDataBase.UserId] = oRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objRow[conPrjDataBase.UpdDate] = oRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objRow[conPrjDataBase.Memo] = oRow[conPrjDataBase.Memo].ToString().Trim(); //说明
 objDS.Tables[clsPrjDataBaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjDataBaseEN._CurrTabName);
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
 /// <param name = "objPrjDataBaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjDataBaseEN objPrjDataBaseEN)
{
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjDataBaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
strSQL = "Select * from PrjDataBase where PrjDataBaseId = " + "'"+ objPrjDataBaseEN.PrjDataBaseId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjDataBaseEN._CurrTabName);
if (objDS.Tables[clsPrjDataBaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PrjDataBaseId = " + "'"+ objPrjDataBaseEN.PrjDataBaseId+"'");
return false;
}
objRow = objDS.Tables[clsPrjDataBaseEN._CurrTabName].Rows[0];
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.PrjDataBaseId))
 {
objRow[conPrjDataBase.PrjDataBaseId] = objPrjDataBaseEN.PrjDataBaseId; //项目数据库Id
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.PrjDataBaseName))
 {
objRow[conPrjDataBase.PrjDataBaseName] = objPrjDataBaseEN.PrjDataBaseName; //项目数据库名
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseName))
 {
objRow[conPrjDataBase.DataBaseName] = objPrjDataBaseEN.DataBaseName; //数据库名
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DatabaseOwner))
 {
objRow[conPrjDataBase.DatabaseOwner] = objPrjDataBaseEN.DatabaseOwner; //数据库拥有者
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBasePwd))
 {
objRow[conPrjDataBase.DataBasePwd] = objPrjDataBaseEN.DataBasePwd; //数据库的用户口令
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseTypeId))
 {
objRow[conPrjDataBase.DataBaseTypeId] = objPrjDataBaseEN.DataBaseTypeId; //数据库类型ID
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseUserId))
 {
objRow[conPrjDataBase.DataBaseUserId] = objPrjDataBaseEN.DataBaseUserId; //数据库的用户ID
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.IpAddress))
 {
objRow[conPrjDataBase.IpAddress] = objPrjDataBaseEN.IpAddress; //服务器
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Sid))
 {
objRow[conPrjDataBase.Sid] = objPrjDataBaseEN.Sid; //SID
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.TableSpace))
 {
objRow[conPrjDataBase.TableSpace] = objPrjDataBaseEN.TableSpace; //表空间
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UseStateId))
 {
objRow[conPrjDataBase.UseStateId] = objPrjDataBaseEN.UseStateId; //使用状态Id
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UserId))
 {
objRow[conPrjDataBase.UserId] = objPrjDataBaseEN.UserId; //用户Id
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UpdDate))
 {
objRow[conPrjDataBase.UpdDate] = objPrjDataBaseEN.UpdDate; //修改日期
 }
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Memo))
 {
objRow[conPrjDataBase.Memo] = objPrjDataBaseEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsPrjDataBaseEN._CurrTabName);
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjDataBaseEN objPrjDataBaseEN)
{
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjDataBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjDataBase Set ");
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.PrjDataBaseName))
 {
 if (objPrjDataBaseEN.PrjDataBaseName !=  null)
 {
 var strPrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjDataBaseName, conPrjDataBase.PrjDataBaseName); //项目数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.PrjDataBaseName); //项目数据库名
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseName))
 {
 if (objPrjDataBaseEN.DataBaseName !=  null)
 {
 var strDataBaseName = objPrjDataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conPrjDataBase.DataBaseName); //数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DataBaseName); //数据库名
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DatabaseOwner))
 {
 if (objPrjDataBaseEN.DatabaseOwner !=  null)
 {
 var strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDatabaseOwner, conPrjDataBase.DatabaseOwner); //数据库拥有者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DatabaseOwner); //数据库拥有者
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBasePwd))
 {
 if (objPrjDataBaseEN.DataBasePwd !=  null)
 {
 var strDataBasePwd = objPrjDataBaseEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBasePwd, conPrjDataBase.DataBasePwd); //数据库的用户口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DataBasePwd); //数据库的用户口令
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseTypeId))
 {
 if (objPrjDataBaseEN.DataBaseTypeId  ==  "")
 {
 objPrjDataBaseEN.DataBaseTypeId = null;
 }
 if (objPrjDataBaseEN.DataBaseTypeId !=  null)
 {
 var strDataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseTypeId, conPrjDataBase.DataBaseTypeId); //数据库类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DataBaseTypeId); //数据库类型ID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseUserId))
 {
 if (objPrjDataBaseEN.DataBaseUserId !=  null)
 {
 var strDataBaseUserId = objPrjDataBaseEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseUserId, conPrjDataBase.DataBaseUserId); //数据库的用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DataBaseUserId); //数据库的用户ID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.IpAddress))
 {
 if (objPrjDataBaseEN.IpAddress !=  null)
 {
 var strIpAddress = objPrjDataBaseEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conPrjDataBase.IpAddress); //服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.IpAddress); //服务器
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Sid))
 {
 if (objPrjDataBaseEN.Sid !=  null)
 {
 var strSid = objPrjDataBaseEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSid, conPrjDataBase.Sid); //SID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.Sid); //SID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.TableSpace))
 {
 if (objPrjDataBaseEN.TableSpace !=  null)
 {
 var strTableSpace = objPrjDataBaseEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableSpace, conPrjDataBase.TableSpace); //表空间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.TableSpace); //表空间
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UseStateId))
 {
 if (objPrjDataBaseEN.UseStateId  ==  "")
 {
 objPrjDataBaseEN.UseStateId = null;
 }
 if (objPrjDataBaseEN.UseStateId !=  null)
 {
 var strUseStateId = objPrjDataBaseEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conPrjDataBase.UseStateId); //使用状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.UseStateId); //使用状态Id
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UserId))
 {
 if (objPrjDataBaseEN.UserId !=  null)
 {
 var strUserId = objPrjDataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjDataBase.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.UserId); //用户Id
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UpdDate))
 {
 if (objPrjDataBaseEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjDataBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjDataBase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.UpdDate); //修改日期
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Memo))
 {
 if (objPrjDataBaseEN.Memo !=  null)
 {
 var strMemo = objPrjDataBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjDataBase.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjDataBaseId = '{0}'", objPrjDataBaseEN.PrjDataBaseId); 
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
 /// <param name = "objPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjDataBaseEN objPrjDataBaseEN, string strCondition)
{
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjDataBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjDataBase Set ");
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.PrjDataBaseName))
 {
 if (objPrjDataBaseEN.PrjDataBaseName !=  null)
 {
 var strPrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjDataBaseName = '{0}',", strPrjDataBaseName); //项目数据库名
 }
 else
 {
 sbSQL.Append(" PrjDataBaseName = null,"); //项目数据库名
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseName))
 {
 if (objPrjDataBaseEN.DataBaseName !=  null)
 {
 var strDataBaseName = objPrjDataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DatabaseOwner))
 {
 if (objPrjDataBaseEN.DatabaseOwner !=  null)
 {
 var strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DatabaseOwner = '{0}',", strDatabaseOwner); //数据库拥有者
 }
 else
 {
 sbSQL.Append(" DatabaseOwner = null,"); //数据库拥有者
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBasePwd))
 {
 if (objPrjDataBaseEN.DataBasePwd !=  null)
 {
 var strDataBasePwd = objPrjDataBaseEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBasePwd = '{0}',", strDataBasePwd); //数据库的用户口令
 }
 else
 {
 sbSQL.Append(" DataBasePwd = null,"); //数据库的用户口令
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseTypeId))
 {
 if (objPrjDataBaseEN.DataBaseTypeId  ==  "")
 {
 objPrjDataBaseEN.DataBaseTypeId = null;
 }
 if (objPrjDataBaseEN.DataBaseTypeId !=  null)
 {
 var strDataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseTypeId = '{0}',", strDataBaseTypeId); //数据库类型ID
 }
 else
 {
 sbSQL.Append(" DataBaseTypeId = null,"); //数据库类型ID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseUserId))
 {
 if (objPrjDataBaseEN.DataBaseUserId !=  null)
 {
 var strDataBaseUserId = objPrjDataBaseEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseUserId = '{0}',", strDataBaseUserId); //数据库的用户ID
 }
 else
 {
 sbSQL.Append(" DataBaseUserId = null,"); //数据库的用户ID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.IpAddress))
 {
 if (objPrjDataBaseEN.IpAddress !=  null)
 {
 var strIpAddress = objPrjDataBaseEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //服务器
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //服务器
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Sid))
 {
 if (objPrjDataBaseEN.Sid !=  null)
 {
 var strSid = objPrjDataBaseEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Sid = '{0}',", strSid); //SID
 }
 else
 {
 sbSQL.Append(" Sid = null,"); //SID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.TableSpace))
 {
 if (objPrjDataBaseEN.TableSpace !=  null)
 {
 var strTableSpace = objPrjDataBaseEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableSpace = '{0}',", strTableSpace); //表空间
 }
 else
 {
 sbSQL.Append(" TableSpace = null,"); //表空间
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UseStateId))
 {
 if (objPrjDataBaseEN.UseStateId  ==  "")
 {
 objPrjDataBaseEN.UseStateId = null;
 }
 if (objPrjDataBaseEN.UseStateId !=  null)
 {
 var strUseStateId = objPrjDataBaseEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //使用状态Id
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //使用状态Id
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UserId))
 {
 if (objPrjDataBaseEN.UserId !=  null)
 {
 var strUserId = objPrjDataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UpdDate))
 {
 if (objPrjDataBaseEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjDataBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Memo))
 {
 if (objPrjDataBaseEN.Memo !=  null)
 {
 var strMemo = objPrjDataBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjDataBaseEN objPrjDataBaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjDataBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjDataBase Set ");
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.PrjDataBaseName))
 {
 if (objPrjDataBaseEN.PrjDataBaseName !=  null)
 {
 var strPrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjDataBaseName = '{0}',", strPrjDataBaseName); //项目数据库名
 }
 else
 {
 sbSQL.Append(" PrjDataBaseName = null,"); //项目数据库名
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseName))
 {
 if (objPrjDataBaseEN.DataBaseName !=  null)
 {
 var strDataBaseName = objPrjDataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DatabaseOwner))
 {
 if (objPrjDataBaseEN.DatabaseOwner !=  null)
 {
 var strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DatabaseOwner = '{0}',", strDatabaseOwner); //数据库拥有者
 }
 else
 {
 sbSQL.Append(" DatabaseOwner = null,"); //数据库拥有者
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBasePwd))
 {
 if (objPrjDataBaseEN.DataBasePwd !=  null)
 {
 var strDataBasePwd = objPrjDataBaseEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBasePwd = '{0}',", strDataBasePwd); //数据库的用户口令
 }
 else
 {
 sbSQL.Append(" DataBasePwd = null,"); //数据库的用户口令
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseTypeId))
 {
 if (objPrjDataBaseEN.DataBaseTypeId  ==  "")
 {
 objPrjDataBaseEN.DataBaseTypeId = null;
 }
 if (objPrjDataBaseEN.DataBaseTypeId !=  null)
 {
 var strDataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseTypeId = '{0}',", strDataBaseTypeId); //数据库类型ID
 }
 else
 {
 sbSQL.Append(" DataBaseTypeId = null,"); //数据库类型ID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseUserId))
 {
 if (objPrjDataBaseEN.DataBaseUserId !=  null)
 {
 var strDataBaseUserId = objPrjDataBaseEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseUserId = '{0}',", strDataBaseUserId); //数据库的用户ID
 }
 else
 {
 sbSQL.Append(" DataBaseUserId = null,"); //数据库的用户ID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.IpAddress))
 {
 if (objPrjDataBaseEN.IpAddress !=  null)
 {
 var strIpAddress = objPrjDataBaseEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //服务器
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //服务器
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Sid))
 {
 if (objPrjDataBaseEN.Sid !=  null)
 {
 var strSid = objPrjDataBaseEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Sid = '{0}',", strSid); //SID
 }
 else
 {
 sbSQL.Append(" Sid = null,"); //SID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.TableSpace))
 {
 if (objPrjDataBaseEN.TableSpace !=  null)
 {
 var strTableSpace = objPrjDataBaseEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableSpace = '{0}',", strTableSpace); //表空间
 }
 else
 {
 sbSQL.Append(" TableSpace = null,"); //表空间
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UseStateId))
 {
 if (objPrjDataBaseEN.UseStateId  ==  "")
 {
 objPrjDataBaseEN.UseStateId = null;
 }
 if (objPrjDataBaseEN.UseStateId !=  null)
 {
 var strUseStateId = objPrjDataBaseEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //使用状态Id
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //使用状态Id
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UserId))
 {
 if (objPrjDataBaseEN.UserId !=  null)
 {
 var strUserId = objPrjDataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UpdDate))
 {
 if (objPrjDataBaseEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjDataBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Memo))
 {
 if (objPrjDataBaseEN.Memo !=  null)
 {
 var strMemo = objPrjDataBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjDataBaseEN objPrjDataBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjDataBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjDataBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjDataBase Set ");
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.PrjDataBaseName))
 {
 if (objPrjDataBaseEN.PrjDataBaseName !=  null)
 {
 var strPrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjDataBaseName, conPrjDataBase.PrjDataBaseName); //项目数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.PrjDataBaseName); //项目数据库名
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseName))
 {
 if (objPrjDataBaseEN.DataBaseName !=  null)
 {
 var strDataBaseName = objPrjDataBaseEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conPrjDataBase.DataBaseName); //数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DataBaseName); //数据库名
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DatabaseOwner))
 {
 if (objPrjDataBaseEN.DatabaseOwner !=  null)
 {
 var strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDatabaseOwner, conPrjDataBase.DatabaseOwner); //数据库拥有者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DatabaseOwner); //数据库拥有者
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBasePwd))
 {
 if (objPrjDataBaseEN.DataBasePwd !=  null)
 {
 var strDataBasePwd = objPrjDataBaseEN.DataBasePwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBasePwd, conPrjDataBase.DataBasePwd); //数据库的用户口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DataBasePwd); //数据库的用户口令
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseTypeId))
 {
 if (objPrjDataBaseEN.DataBaseTypeId  ==  "")
 {
 objPrjDataBaseEN.DataBaseTypeId = null;
 }
 if (objPrjDataBaseEN.DataBaseTypeId !=  null)
 {
 var strDataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseTypeId, conPrjDataBase.DataBaseTypeId); //数据库类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DataBaseTypeId); //数据库类型ID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.DataBaseUserId))
 {
 if (objPrjDataBaseEN.DataBaseUserId !=  null)
 {
 var strDataBaseUserId = objPrjDataBaseEN.DataBaseUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseUserId, conPrjDataBase.DataBaseUserId); //数据库的用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.DataBaseUserId); //数据库的用户ID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.IpAddress))
 {
 if (objPrjDataBaseEN.IpAddress !=  null)
 {
 var strIpAddress = objPrjDataBaseEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conPrjDataBase.IpAddress); //服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.IpAddress); //服务器
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Sid))
 {
 if (objPrjDataBaseEN.Sid !=  null)
 {
 var strSid = objPrjDataBaseEN.Sid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSid, conPrjDataBase.Sid); //SID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.Sid); //SID
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.TableSpace))
 {
 if (objPrjDataBaseEN.TableSpace !=  null)
 {
 var strTableSpace = objPrjDataBaseEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableSpace, conPrjDataBase.TableSpace); //表空间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.TableSpace); //表空间
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UseStateId))
 {
 if (objPrjDataBaseEN.UseStateId  ==  "")
 {
 objPrjDataBaseEN.UseStateId = null;
 }
 if (objPrjDataBaseEN.UseStateId !=  null)
 {
 var strUseStateId = objPrjDataBaseEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conPrjDataBase.UseStateId); //使用状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.UseStateId); //使用状态Id
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UserId))
 {
 if (objPrjDataBaseEN.UserId !=  null)
 {
 var strUserId = objPrjDataBaseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjDataBase.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.UserId); //用户Id
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.UpdDate))
 {
 if (objPrjDataBaseEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjDataBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjDataBase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.UpdDate); //修改日期
 }
 }
 
 if (objPrjDataBaseEN.IsUpdated(conPrjDataBase.Memo))
 {
 if (objPrjDataBaseEN.Memo !=  null)
 {
 var strMemo = objPrjDataBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjDataBase.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjDataBase.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjDataBaseId = '{0}'", objPrjDataBaseEN.PrjDataBaseId); 
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
 /// <param name = "strPrjDataBaseId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPrjDataBaseId) 
{
CheckPrimaryKey(strPrjDataBaseId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPrjDataBaseId,
};
 objSQL.ExecSP("PrjDataBase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPrjDataBaseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPrjDataBaseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPrjDataBaseId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
//删除PrjDataBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjDataBase where PrjDataBaseId = " + "'"+ strPrjDataBaseId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjDataBase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
//删除PrjDataBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjDataBase where PrjDataBaseId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPrjDataBaseId) 
{
CheckPrimaryKey(strPrjDataBaseId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
//删除PrjDataBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjDataBase where PrjDataBaseId = " + "'"+ strPrjDataBaseId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjDataBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: DelPrjDataBase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjDataBase where " + strCondition ;
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
public bool DelPrjDataBaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjDataBaseDA: DelPrjDataBaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjDataBase where " + strCondition ;
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
 /// <param name = "objPrjDataBaseENS">源对象</param>
 /// <param name = "objPrjDataBaseENT">目标对象</param>
public void CopyTo(clsPrjDataBaseEN objPrjDataBaseENS, clsPrjDataBaseEN objPrjDataBaseENT)
{
objPrjDataBaseENT.PrjDataBaseId = objPrjDataBaseENS.PrjDataBaseId; //项目数据库Id
objPrjDataBaseENT.PrjDataBaseName = objPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objPrjDataBaseENT.DataBaseName = objPrjDataBaseENS.DataBaseName; //数据库名
objPrjDataBaseENT.DatabaseOwner = objPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objPrjDataBaseENT.DataBasePwd = objPrjDataBaseENS.DataBasePwd; //数据库的用户口令
objPrjDataBaseENT.DataBaseTypeId = objPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objPrjDataBaseENT.DataBaseUserId = objPrjDataBaseENS.DataBaseUserId; //数据库的用户ID
objPrjDataBaseENT.IpAddress = objPrjDataBaseENS.IpAddress; //服务器
objPrjDataBaseENT.Sid = objPrjDataBaseENS.Sid; //SID
objPrjDataBaseENT.TableSpace = objPrjDataBaseENS.TableSpace; //表空间
objPrjDataBaseENT.UseStateId = objPrjDataBaseENS.UseStateId; //使用状态Id
objPrjDataBaseENT.UserId = objPrjDataBaseENS.UserId; //用户Id
objPrjDataBaseENT.UpdDate = objPrjDataBaseENS.UpdDate; //修改日期
objPrjDataBaseENT.Memo = objPrjDataBaseENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjDataBaseEN objPrjDataBaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjDataBaseEN.PrjDataBaseName, conPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckFieldNotNull(objPrjDataBaseEN.DataBasePwd, conPrjDataBase.DataBasePwd);
clsCheckSql.CheckFieldNotNull(objPrjDataBaseEN.UseStateId, conPrjDataBase.UseStateId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.PrjDataBaseId, 4, conPrjDataBase.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.PrjDataBaseName, 50, conPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBaseName, 50, conPrjDataBase.DataBaseName);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DatabaseOwner, 30, conPrjDataBase.DatabaseOwner);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBasePwd, 30, conPrjDataBase.DataBasePwd);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBaseUserId, 30, conPrjDataBase.DataBaseUserId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.IpAddress, 25, conPrjDataBase.IpAddress);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.Sid, 50, conPrjDataBase.Sid);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.TableSpace, 50, conPrjDataBase.TableSpace);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.UseStateId, 4, conPrjDataBase.UseStateId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.UserId, 18, conPrjDataBase.UserId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.UpdDate, 20, conPrjDataBase.UpdDate);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.Memo, 1000, conPrjDataBase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPrjDataBaseEN.DataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldForeignKey(objPrjDataBaseEN.UseStateId, 4, conPrjDataBase.UseStateId);
 objPrjDataBaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjDataBaseEN objPrjDataBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.PrjDataBaseName, 50, conPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBaseName, 50, conPrjDataBase.DataBaseName);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DatabaseOwner, 30, conPrjDataBase.DatabaseOwner);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBasePwd, 30, conPrjDataBase.DataBasePwd);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBaseUserId, 30, conPrjDataBase.DataBaseUserId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.IpAddress, 25, conPrjDataBase.IpAddress);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.Sid, 50, conPrjDataBase.Sid);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.TableSpace, 50, conPrjDataBase.TableSpace);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.UseStateId, 4, conPrjDataBase.UseStateId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.UserId, 18, conPrjDataBase.UserId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.UpdDate, 20, conPrjDataBase.UpdDate);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.Memo, 1000, conPrjDataBase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjDataBaseEN.DataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldForeignKey(objPrjDataBaseEN.UseStateId, 4, conPrjDataBase.UseStateId);
 objPrjDataBaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjDataBaseEN objPrjDataBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.PrjDataBaseId, 4, conPrjDataBase.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.PrjDataBaseName, 50, conPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBaseName, 50, conPrjDataBase.DataBaseName);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DatabaseOwner, 30, conPrjDataBase.DatabaseOwner);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBasePwd, 30, conPrjDataBase.DataBasePwd);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.DataBaseUserId, 30, conPrjDataBase.DataBaseUserId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.IpAddress, 25, conPrjDataBase.IpAddress);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.Sid, 50, conPrjDataBase.Sid);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.TableSpace, 50, conPrjDataBase.TableSpace);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.UseStateId, 4, conPrjDataBase.UseStateId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.UserId, 18, conPrjDataBase.UserId);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.UpdDate, 20, conPrjDataBase.UpdDate);
clsCheckSql.CheckFieldLen(objPrjDataBaseEN.Memo, 1000, conPrjDataBase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.PrjDataBaseId, conPrjDataBase.PrjDataBaseId);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.PrjDataBaseName, conPrjDataBase.PrjDataBaseName);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.DataBaseName, conPrjDataBase.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.DatabaseOwner, conPrjDataBase.DatabaseOwner);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.DataBasePwd, conPrjDataBase.DataBasePwd);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.DataBaseTypeId, conPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.DataBaseUserId, conPrjDataBase.DataBaseUserId);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.IpAddress, conPrjDataBase.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.Sid, conPrjDataBase.Sid);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.TableSpace, conPrjDataBase.TableSpace);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.UseStateId, conPrjDataBase.UseStateId);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.UserId, conPrjDataBase.UserId);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.UpdDate, conPrjDataBase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPrjDataBaseEN.Memo, conPrjDataBase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjDataBaseEN.DataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
clsCheckSql.CheckFieldForeignKey(objPrjDataBaseEN.UseStateId, 4, conPrjDataBase.UseStateId);
 objPrjDataBaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPrjDataBaseId()
{
//获取某学院所有专业信息
string strSQL = "select PrjDataBaseId, PrjDataBaseName from PrjDataBase ";
 clsSpecSQLforSql mySql = clsPrjDataBaseDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PrjDataBase(数据库对象),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPrjDataBaseEN objPrjDataBaseEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objPrjDataBaseEN.PrjDataBaseName);
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
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjDataBaseEN._CurrTabName);
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
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjDataBaseEN._CurrTabName, strCondition);
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
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
 objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}