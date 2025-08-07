
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewGroupDA
 表名:vViewGroup(00050158)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:07
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// v界面组(vViewGroup)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewGroupDA : clsCommBase4DA
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
 return clsvViewGroupEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewGroupEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewGroupEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewGroupEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewGroupEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strViewGroupId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strViewGroupId)
{
strViewGroupId = strViewGroupId.Replace("'", "''");
if (strViewGroupId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vViewGroup中,检查关键字,长度不正确!(clsvViewGroupDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewGroupId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vViewGroup中,关键字不能为空 或 null!(clsvViewGroupDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvViewGroupDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from vViewGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewGroupDA: GetDataTable_vViewGroup)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from vViewGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from vViewGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewGroup where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewGroup where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewGroup where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewGroup.* " + 
$"from vViewGroup " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewGroup.ViewGroupId not in " + 
$"(Select top {intTop_In} vViewGroup.ViewGroupId from vViewGroup " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewGroup where {1} and ViewGroupId not in (Select top {2} ViewGroupId from vViewGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewGroup where {1} and ViewGroupId not in (Select top {3} ViewGroupId from vViewGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewGroup.* " + 
$"from vViewGroup " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewGroup.ViewGroupId not in " + 
$"(Select top {intTop_In} vViewGroup.ViewGroupId from vViewGroup " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewGroup where {1} and ViewGroupId not in (Select top {2} ViewGroupId from vViewGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewGroup where {1} and ViewGroupId not in (Select top {3} ViewGroupId from vViewGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewGroupEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewGroupDA:GetObjLst)", objException.Message));
}
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from vViewGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewGroupDA: GetObjLst)", objException.Message));
}
objvViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewGroupEN);
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
public List<clsvViewGroupEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewGroupDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewGroupEN> arrObjLst = new List<clsvViewGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewGroupDA: GetObjLst)", objException.Message));
}
objvViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewGroupEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewGroupEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewGroup(ref clsvViewGroupEN objvViewGroupEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from vViewGroup where ViewGroupId = " + "'"+ objvViewGroupEN.ViewGroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewGroupEN.UserId = objDT.Rows[0][convViewGroup.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvViewGroupEN.PrjId = objDT.Rows[0][convViewGroup.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewGroupEN.Memo = objDT.Rows[0][convViewGroup.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewGroupEN.PrjDomain = objDT.Rows[0][convViewGroup.PrjDomain].ToString().Trim(); //域/包名(字段类型:varchar,字段长度:128,是否可空:True)
 objvViewGroupEN.UpdDate = objDT.Rows[0][convViewGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewGroupEN.OutRelaTabId = objDT.Rows[0][convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewGroupEN.InSqlDsTypeId = objDT.Rows[0][convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewGroupEN.InRelaTabId = objDT.Rows[0][convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID(字段类型:char,字段长度:8,是否可空:True)
 objvViewGroupEN.ViewGroupId = objDT.Rows[0][convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewGroupEN.ViewGroupName = objDT.Rows[0][convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewGroupEN.ActionPath = objDT.Rows[0][convViewGroup.ActionPath].ToString().Trim(); //Action路径(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewGroupEN.OutSqlDsTypeId = objDT.Rows[0][convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewGroupEN.OutSqlDsTypeName = objDT.Rows[0][convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewGroupEN.OutTabName = objDT.Rows[0][convViewGroup.OutTabName].ToString().Trim(); //OUT表(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewGroupEN.InSqlDsTypeName = objDT.Rows[0][convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewGroupEN.InTabName = objDT.Rows[0][convViewGroup.InTabName].ToString().Trim(); //IN表(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewGroupEN.TableNameForProg = objDT.Rows[0][convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewGroupDA: GetvViewGroup)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewGroupId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewGroupEN GetObjByViewGroupId(string strViewGroupId)
{
CheckPrimaryKey(strViewGroupId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from vViewGroup where ViewGroupId = " + "'"+ strViewGroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
 objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名(字段类型:varchar,字段长度:128,是否可空:True)
 objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID(字段类型:char,字段长度:8,是否可空:True)
 objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewGroupDA: GetObjByViewGroupId)", objException.Message));
}
return objvViewGroupEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewGroupEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewGroupDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from vViewGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN()
{
UserId = objRow[convViewGroup.UserId].ToString().Trim(), //用户Id
PrjId = objRow[convViewGroup.PrjId].ToString().Trim(), //工程Id
Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(), //说明
PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(), //域/包名
UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(), //修改日期
OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(), //输出数据源表ID
InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(), //输入数据源类型
InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(), //输入数据源表ID
ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(), //界面组ID
ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(), //界面组名称
ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(), //Action路径
OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(), //输出数据源类型
OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(), //OUT数据源类型
OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(), //OUT表
InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(), //IN数据源类型
InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(), //IN表
TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim() //编程用表名
};
objvViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewGroupEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewGroupDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewGroupEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewGroupDA: GetObjByDataRowvViewGroup)", objException.Message));
}
objvViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewGroupEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewGroupEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewGroupEN objvViewGroupEN = new clsvViewGroupEN();
try
{
objvViewGroupEN.UserId = objRow[convViewGroup.UserId].ToString().Trim(); //用户Id
objvViewGroupEN.PrjId = objRow[convViewGroup.PrjId].ToString().Trim(); //工程Id
objvViewGroupEN.Memo = objRow[convViewGroup.Memo] == DBNull.Value ? null : objRow[convViewGroup.Memo].ToString().Trim(); //说明
objvViewGroupEN.PrjDomain = objRow[convViewGroup.PrjDomain] == DBNull.Value ? null : objRow[convViewGroup.PrjDomain].ToString().Trim(); //域/包名
objvViewGroupEN.UpdDate = objRow[convViewGroup.UpdDate] == DBNull.Value ? null : objRow[convViewGroup.UpdDate].ToString().Trim(); //修改日期
objvViewGroupEN.OutRelaTabId = objRow[convViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objvViewGroupEN.InSqlDsTypeId = objRow[convViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewGroupEN.InRelaTabId = objRow[convViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[convViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objvViewGroupEN.ViewGroupId = objRow[convViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objvViewGroupEN.ViewGroupName = objRow[convViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objvViewGroupEN.ActionPath = objRow[convViewGroup.ActionPath].ToString().Trim(); //Action路径
objvViewGroupEN.OutSqlDsTypeId = objRow[convViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewGroupEN.OutSqlDsTypeName = objRow[convViewGroup.OutSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.OutSqlDsTypeName].ToString().Trim(); //OUT数据源类型
objvViewGroupEN.OutTabName = objRow[convViewGroup.OutTabName] == DBNull.Value ? null : objRow[convViewGroup.OutTabName].ToString().Trim(); //OUT表
objvViewGroupEN.InSqlDsTypeName = objRow[convViewGroup.InSqlDsTypeName] == DBNull.Value ? null : objRow[convViewGroup.InSqlDsTypeName].ToString().Trim(); //IN数据源类型
objvViewGroupEN.InTabName = objRow[convViewGroup.InTabName] == DBNull.Value ? null : objRow[convViewGroup.InTabName].ToString().Trim(); //IN表
objvViewGroupEN.TableNameForProg = objRow[convViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[convViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewGroupDA: GetObjByDataRow)", objException.Message));
}
objvViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewGroupEN;
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
objSQL = clsvViewGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewGroupEN._CurrTabName, convViewGroup.ViewGroupId, 8, "");
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
objSQL = clsvViewGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewGroupEN._CurrTabName, convViewGroup.ViewGroupId, 8, strPrefix);
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
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewGroupId from vViewGroup where " + strCondition;
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
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewGroupId from vViewGroup where " + strCondition;
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
 /// <param name = "strViewGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strViewGroupId)
{
CheckPrimaryKey(strViewGroupId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewGroup", "ViewGroupId = " + "'"+ strViewGroupId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewGroupDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewGroup", strCondition))
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
objSQL = clsvViewGroupDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewGroup");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewGroupENS">源对象</param>
 /// <param name = "objvViewGroupENT">目标对象</param>
public void CopyTo(clsvViewGroupEN objvViewGroupENS, clsvViewGroupEN objvViewGroupENT)
{
objvViewGroupENT.UserId = objvViewGroupENS.UserId; //用户Id
objvViewGroupENT.PrjId = objvViewGroupENS.PrjId; //工程Id
objvViewGroupENT.Memo = objvViewGroupENS.Memo; //说明
objvViewGroupENT.PrjDomain = objvViewGroupENS.PrjDomain; //域/包名
objvViewGroupENT.UpdDate = objvViewGroupENS.UpdDate; //修改日期
objvViewGroupENT.OutRelaTabId = objvViewGroupENS.OutRelaTabId; //输出数据源表ID
objvViewGroupENT.InSqlDsTypeId = objvViewGroupENS.InSqlDsTypeId; //输入数据源类型
objvViewGroupENT.InRelaTabId = objvViewGroupENS.InRelaTabId; //输入数据源表ID
objvViewGroupENT.ViewGroupId = objvViewGroupENS.ViewGroupId; //界面组ID
objvViewGroupENT.ViewGroupName = objvViewGroupENS.ViewGroupName; //界面组名称
objvViewGroupENT.ActionPath = objvViewGroupENS.ActionPath; //Action路径
objvViewGroupENT.OutSqlDsTypeId = objvViewGroupENS.OutSqlDsTypeId; //输出数据源类型
objvViewGroupENT.OutSqlDsTypeName = objvViewGroupENS.OutSqlDsTypeName; //OUT数据源类型
objvViewGroupENT.OutTabName = objvViewGroupENS.OutTabName; //OUT表
objvViewGroupENT.InSqlDsTypeName = objvViewGroupENS.InSqlDsTypeName; //IN数据源类型
objvViewGroupENT.InTabName = objvViewGroupENS.InTabName; //IN表
objvViewGroupENT.TableNameForProg = objvViewGroupENS.TableNameForProg; //编程用表名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewGroupEN objvViewGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewGroupEN.UserId, 18, convViewGroup.UserId);
clsCheckSql.CheckFieldLen(objvViewGroupEN.PrjId, 4, convViewGroup.PrjId);
clsCheckSql.CheckFieldLen(objvViewGroupEN.Memo, 1000, convViewGroup.Memo);
clsCheckSql.CheckFieldLen(objvViewGroupEN.PrjDomain, 128, convViewGroup.PrjDomain);
clsCheckSql.CheckFieldLen(objvViewGroupEN.UpdDate, 20, convViewGroup.UpdDate);
clsCheckSql.CheckFieldLen(objvViewGroupEN.OutRelaTabId, 8, convViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldLen(objvViewGroupEN.InSqlDsTypeId, 2, convViewGroup.InSqlDsTypeId);
clsCheckSql.CheckFieldLen(objvViewGroupEN.InRelaTabId, 8, convViewGroup.InRelaTabId);
clsCheckSql.CheckFieldLen(objvViewGroupEN.ViewGroupId, 8, convViewGroup.ViewGroupId);
clsCheckSql.CheckFieldLen(objvViewGroupEN.ViewGroupName, 30, convViewGroup.ViewGroupName);
clsCheckSql.CheckFieldLen(objvViewGroupEN.ActionPath, 100, convViewGroup.ActionPath);
clsCheckSql.CheckFieldLen(objvViewGroupEN.OutSqlDsTypeId, 2, convViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckFieldLen(objvViewGroupEN.OutSqlDsTypeName, 20, convViewGroup.OutSqlDsTypeName);
clsCheckSql.CheckFieldLen(objvViewGroupEN.OutTabName, 40, convViewGroup.OutTabName);
clsCheckSql.CheckFieldLen(objvViewGroupEN.InSqlDsTypeName, 20, convViewGroup.InSqlDsTypeName);
clsCheckSql.CheckFieldLen(objvViewGroupEN.InTabName, 40, convViewGroup.InTabName);
clsCheckSql.CheckFieldLen(objvViewGroupEN.TableNameForProg, 50, convViewGroup.TableNameForProg);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.UserId, convViewGroup.UserId);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.PrjId, convViewGroup.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.Memo, convViewGroup.Memo);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.PrjDomain, convViewGroup.PrjDomain);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.UpdDate, convViewGroup.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.OutRelaTabId, convViewGroup.OutRelaTabId);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.InSqlDsTypeId, convViewGroup.InSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.InRelaTabId, convViewGroup.InRelaTabId);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.ViewGroupId, convViewGroup.ViewGroupId);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.ViewGroupName, convViewGroup.ViewGroupName);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.ActionPath, convViewGroup.ActionPath);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.OutSqlDsTypeId, convViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.OutSqlDsTypeName, convViewGroup.OutSqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.OutTabName, convViewGroup.OutTabName);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.InSqlDsTypeName, convViewGroup.InSqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.InTabName, convViewGroup.InTabName);
clsCheckSql.CheckSqlInjection4Field(objvViewGroupEN.TableNameForProg, convViewGroup.TableNameForProg);
//检查外键字段长度
 objvViewGroupEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetViewGroupId()
{
//获取某学院所有专业信息
string strSQL = "select ViewGroupId, ViewGroupName from vViewGroup ";
 clsSpecSQLforSql mySql = clsvViewGroupDA.GetSpecSQLObj();
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
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
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
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
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
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewGroupEN._CurrTabName);
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
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewGroupEN._CurrTabName, strCondition);
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
 objSQL = clsvViewGroupDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}