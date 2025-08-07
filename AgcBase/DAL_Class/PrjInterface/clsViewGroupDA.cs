
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewGroupDA
 表名:ViewGroup(00050134)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:58
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
 /// 界面组(ViewGroup)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewGroupDA : clsCommBase4DA
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
 return clsViewGroupEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewGroupEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewGroupEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewGroupEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewGroupEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:ViewGroup中,检查关键字,长度不正确!(clsViewGroupDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewGroupId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ViewGroup中,关键字不能为空 或 null!(clsViewGroupDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsViewGroupDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewGroupDA: GetDataTable_ViewGroup)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewGroup where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewGroup where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewGroup where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewGroup.* " + 
$"from ViewGroup " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewGroup.ViewGroupId not in " + 
$"(Select top {intTop_In} ViewGroup.ViewGroupId from ViewGroup " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewGroup where {1} and ViewGroupId not in (Select top {2} ViewGroupId from ViewGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewGroup where {1} and ViewGroupId not in (Select top {3} ViewGroupId from ViewGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewGroup.* " + 
$"from ViewGroup " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewGroup.ViewGroupId not in " + 
$"(Select top {intTop_In} ViewGroup.ViewGroupId from ViewGroup " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewGroup where {1} and ViewGroupId not in (Select top {2} ViewGroupId from ViewGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewGroup where {1} and ViewGroupId not in (Select top {3} ViewGroupId from ViewGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewGroupEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewGroupDA:GetObjLst)", objException.Message));
}
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewGroupDA: GetObjLst)", objException.Message));
}
objViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewGroupEN);
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
public List<clsViewGroupEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewGroupDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewGroupDA: GetObjLst)", objException.Message));
}
objViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewGroupEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewGroupEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewGroup(ref clsViewGroupEN objViewGroupEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where ViewGroupId = " + "'"+ objViewGroupEN.ViewGroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewGroupEN.ViewGroupId = objDT.Rows[0][conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupEN.ViewGroupName = objDT.Rows[0][conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称(字段类型:varchar,字段长度:30,是否可空:False)
 objViewGroupEN.InSqlDsTypeId = objDT.Rows[0][conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objViewGroupEN.InRelaTabId = objDT.Rows[0][conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID(字段类型:char,字段长度:8,是否可空:True)
 objViewGroupEN.OutSqlDsTypeId = objDT.Rows[0][conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objViewGroupEN.OutRelaTabId = objDT.Rows[0][conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupEN.PrjDomain = objDT.Rows[0][conViewGroup.PrjDomain].ToString().Trim(); //域/包名(字段类型:varchar,字段长度:128,是否可空:True)
 objViewGroupEN.ActionPath = objDT.Rows[0][conViewGroup.ActionPath].ToString().Trim(); //Action路径(字段类型:varchar,字段长度:100,是否可空:False)
 objViewGroupEN.PrjId = objDT.Rows[0][conViewGroup.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewGroupEN.UserId = objDT.Rows[0][conViewGroup.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objViewGroupEN.UpdDate = objDT.Rows[0][conViewGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewGroupEN.Memo = objDT.Rows[0][conViewGroup.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewGroupEN.TableNameForProg = objDT.Rows[0][conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewGroupDA: GetViewGroup)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewGroupId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewGroupEN GetObjByViewGroupId(string strViewGroupId)
{
CheckPrimaryKey(strViewGroupId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where ViewGroupId = " + "'"+ strViewGroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
 objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称(字段类型:varchar,字段长度:30,是否可空:False)
 objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID(字段类型:char,字段长度:8,是否可空:True)
 objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名(字段类型:varchar,字段长度:128,是否可空:True)
 objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径(字段类型:varchar,字段长度:100,是否可空:False)
 objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewGroupDA: GetObjByViewGroupId)", objException.Message));
}
return objViewGroupEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewGroupEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewGroupDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN()
{
ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(), //界面组ID
ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(), //界面组名称
InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(), //输入数据源类型
InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(), //输入数据源表ID
OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(), //输出数据源类型
OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(), //输出数据源表ID
PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(), //域/包名
ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(), //Action路径
PrjId = objRow[conViewGroup.PrjId].ToString().Trim(), //工程Id
UserId = objRow[conViewGroup.UserId].ToString().Trim(), //用户Id
UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(), //说明
TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim() //编程用表名
};
objViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewGroupEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewGroupDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewGroupEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewGroupDA: GetObjByDataRowViewGroup)", objException.Message));
}
objViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewGroupEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewGroupEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewGroupDA: GetObjByDataRow)", objException.Message));
}
objViewGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewGroupEN;
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
objSQL = clsViewGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewGroupEN._CurrTabName, conViewGroup.ViewGroupId, 8, "");
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
objSQL = clsViewGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewGroupEN._CurrTabName, conViewGroup.ViewGroupId, 8, strPrefix);
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
 objSQL = clsViewGroupDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewGroupId from ViewGroup where " + strCondition;
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
 objSQL = clsViewGroupDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewGroupId from ViewGroup where " + strCondition;
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
 objSQL = clsViewGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewGroup", "ViewGroupId = " + "'"+ strViewGroupId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewGroupDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewGroup", strCondition))
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
objSQL = clsViewGroupDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewGroup");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewGroupEN objViewGroupEN)
 {
 objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewGroupEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewGroup");
objRow = objDS.Tables["ViewGroup"].NewRow();
objRow[conViewGroup.ViewGroupId] = objViewGroupEN.ViewGroupId; //界面组ID
objRow[conViewGroup.ViewGroupName] = objViewGroupEN.ViewGroupName; //界面组名称
 if (objViewGroupEN.InSqlDsTypeId !=  "")
 {
objRow[conViewGroup.InSqlDsTypeId] = objViewGroupEN.InSqlDsTypeId; //输入数据源类型
 }
 if (objViewGroupEN.InRelaTabId !=  "")
 {
objRow[conViewGroup.InRelaTabId] = objViewGroupEN.InRelaTabId; //输入数据源表ID
 }
 if (objViewGroupEN.OutSqlDsTypeId !=  "")
 {
objRow[conViewGroup.OutSqlDsTypeId] = objViewGroupEN.OutSqlDsTypeId; //输出数据源类型
 }
objRow[conViewGroup.OutRelaTabId] = objViewGroupEN.OutRelaTabId; //输出数据源表ID
 if (objViewGroupEN.PrjDomain !=  "")
 {
objRow[conViewGroup.PrjDomain] = objViewGroupEN.PrjDomain; //域/包名
 }
objRow[conViewGroup.ActionPath] = objViewGroupEN.ActionPath; //Action路径
objRow[conViewGroup.PrjId] = objViewGroupEN.PrjId; //工程Id
objRow[conViewGroup.UserId] = objViewGroupEN.UserId; //用户Id
 if (objViewGroupEN.UpdDate !=  "")
 {
objRow[conViewGroup.UpdDate] = objViewGroupEN.UpdDate; //修改日期
 }
 if (objViewGroupEN.Memo !=  "")
 {
objRow[conViewGroup.Memo] = objViewGroupEN.Memo; //说明
 }
 if (objViewGroupEN.TableNameForProg !=  "")
 {
objRow[conViewGroup.TableNameForProg] = objViewGroupEN.TableNameForProg; //编程用表名
 }
objDS.Tables[clsViewGroupEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewGroupEN._CurrTabName);
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewGroupEN objViewGroupEN)
{
 objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewGroupEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.ViewGroupId);
 var strViewGroupId = objViewGroupEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewGroupId + "'");
 }
 
 if (objViewGroupEN.ViewGroupName !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.ViewGroupName);
 var strViewGroupName = objViewGroupEN.ViewGroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewGroupName + "'");
 }
 
 if (objViewGroupEN.InSqlDsTypeId  ==  "")
 {
 objViewGroupEN.InSqlDsTypeId = null;
 }
 if (objViewGroupEN.InSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.InSqlDsTypeId);
 var strInSqlDsTypeId = objViewGroupEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInSqlDsTypeId + "'");
 }
 
 if (objViewGroupEN.InRelaTabId  ==  "")
 {
 objViewGroupEN.InRelaTabId = null;
 }
 if (objViewGroupEN.InRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.InRelaTabId);
 var strInRelaTabId = objViewGroupEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInRelaTabId + "'");
 }
 
 if (objViewGroupEN.OutSqlDsTypeId  ==  "")
 {
 objViewGroupEN.OutSqlDsTypeId = null;
 }
 if (objViewGroupEN.OutSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.OutSqlDsTypeId);
 var strOutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutSqlDsTypeId + "'");
 }
 
 if (objViewGroupEN.OutRelaTabId  ==  "")
 {
 objViewGroupEN.OutRelaTabId = null;
 }
 if (objViewGroupEN.OutRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.OutRelaTabId);
 var strOutRelaTabId = objViewGroupEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutRelaTabId + "'");
 }
 
 if (objViewGroupEN.PrjDomain !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.PrjDomain);
 var strPrjDomain = objViewGroupEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDomain + "'");
 }
 
 if (objViewGroupEN.ActionPath !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.ActionPath);
 var strActionPath = objViewGroupEN.ActionPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActionPath + "'");
 }
 
 if (objViewGroupEN.PrjId  ==  "")
 {
 objViewGroupEN.PrjId = null;
 }
 if (objViewGroupEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.PrjId);
 var strPrjId = objViewGroupEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.UserId);
 var strUserId = objViewGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objViewGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.UpdDate);
 var strUpdDate = objViewGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.Memo);
 var strMemo = objViewGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objViewGroupEN.TableNameForProg !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.TableNameForProg);
 var strTableNameForProg = objViewGroupEN.TableNameForProg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameForProg + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewGroup");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewGroupEN objViewGroupEN)
{
 objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewGroupEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.ViewGroupId);
 var strViewGroupId = objViewGroupEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewGroupId + "'");
 }
 
 if (objViewGroupEN.ViewGroupName !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.ViewGroupName);
 var strViewGroupName = objViewGroupEN.ViewGroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewGroupName + "'");
 }
 
 if (objViewGroupEN.InSqlDsTypeId  ==  "")
 {
 objViewGroupEN.InSqlDsTypeId = null;
 }
 if (objViewGroupEN.InSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.InSqlDsTypeId);
 var strInSqlDsTypeId = objViewGroupEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInSqlDsTypeId + "'");
 }
 
 if (objViewGroupEN.InRelaTabId  ==  "")
 {
 objViewGroupEN.InRelaTabId = null;
 }
 if (objViewGroupEN.InRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.InRelaTabId);
 var strInRelaTabId = objViewGroupEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInRelaTabId + "'");
 }
 
 if (objViewGroupEN.OutSqlDsTypeId  ==  "")
 {
 objViewGroupEN.OutSqlDsTypeId = null;
 }
 if (objViewGroupEN.OutSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.OutSqlDsTypeId);
 var strOutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutSqlDsTypeId + "'");
 }
 
 if (objViewGroupEN.OutRelaTabId  ==  "")
 {
 objViewGroupEN.OutRelaTabId = null;
 }
 if (objViewGroupEN.OutRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.OutRelaTabId);
 var strOutRelaTabId = objViewGroupEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutRelaTabId + "'");
 }
 
 if (objViewGroupEN.PrjDomain !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.PrjDomain);
 var strPrjDomain = objViewGroupEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDomain + "'");
 }
 
 if (objViewGroupEN.ActionPath !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.ActionPath);
 var strActionPath = objViewGroupEN.ActionPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActionPath + "'");
 }
 
 if (objViewGroupEN.PrjId  ==  "")
 {
 objViewGroupEN.PrjId = null;
 }
 if (objViewGroupEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.PrjId);
 var strPrjId = objViewGroupEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.UserId);
 var strUserId = objViewGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objViewGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.UpdDate);
 var strUpdDate = objViewGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.Memo);
 var strMemo = objViewGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objViewGroupEN.TableNameForProg !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.TableNameForProg);
 var strTableNameForProg = objViewGroupEN.TableNameForProg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameForProg + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewGroup");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objViewGroupEN.ViewGroupId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewGroupEN objViewGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewGroupEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewGroupEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.ViewGroupId);
 var strViewGroupId = objViewGroupEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewGroupId + "'");
 }
 
 if (objViewGroupEN.ViewGroupName !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.ViewGroupName);
 var strViewGroupName = objViewGroupEN.ViewGroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewGroupName + "'");
 }
 
 if (objViewGroupEN.InSqlDsTypeId  ==  "")
 {
 objViewGroupEN.InSqlDsTypeId = null;
 }
 if (objViewGroupEN.InSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.InSqlDsTypeId);
 var strInSqlDsTypeId = objViewGroupEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInSqlDsTypeId + "'");
 }
 
 if (objViewGroupEN.InRelaTabId  ==  "")
 {
 objViewGroupEN.InRelaTabId = null;
 }
 if (objViewGroupEN.InRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.InRelaTabId);
 var strInRelaTabId = objViewGroupEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInRelaTabId + "'");
 }
 
 if (objViewGroupEN.OutSqlDsTypeId  ==  "")
 {
 objViewGroupEN.OutSqlDsTypeId = null;
 }
 if (objViewGroupEN.OutSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.OutSqlDsTypeId);
 var strOutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutSqlDsTypeId + "'");
 }
 
 if (objViewGroupEN.OutRelaTabId  ==  "")
 {
 objViewGroupEN.OutRelaTabId = null;
 }
 if (objViewGroupEN.OutRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.OutRelaTabId);
 var strOutRelaTabId = objViewGroupEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutRelaTabId + "'");
 }
 
 if (objViewGroupEN.PrjDomain !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.PrjDomain);
 var strPrjDomain = objViewGroupEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDomain + "'");
 }
 
 if (objViewGroupEN.ActionPath !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.ActionPath);
 var strActionPath = objViewGroupEN.ActionPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActionPath + "'");
 }
 
 if (objViewGroupEN.PrjId  ==  "")
 {
 objViewGroupEN.PrjId = null;
 }
 if (objViewGroupEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.PrjId);
 var strPrjId = objViewGroupEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewGroupEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.UserId);
 var strUserId = objViewGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objViewGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.UpdDate);
 var strUpdDate = objViewGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewGroupEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.Memo);
 var strMemo = objViewGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objViewGroupEN.TableNameForProg !=  null)
 {
 arrFieldListForInsert.Add(conViewGroup.TableNameForProg);
 var strTableNameForProg = objViewGroupEN.TableNameForProg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableNameForProg + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewGroup");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewGroups(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where ViewGroupId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewGroup");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strViewGroupId = oRow[conViewGroup.ViewGroupId].ToString().Trim();
if (IsExist(strViewGroupId))
{
 string strResult = "关键字变量值为:" + string.Format("ViewGroupId = {0}", strViewGroupId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewGroupEN._CurrTabName ].NewRow();
objRow[conViewGroup.ViewGroupId] = oRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objRow[conViewGroup.ViewGroupName] = oRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objRow[conViewGroup.InSqlDsTypeId] = oRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objRow[conViewGroup.InRelaTabId] = oRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objRow[conViewGroup.OutSqlDsTypeId] = oRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objRow[conViewGroup.OutRelaTabId] = oRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objRow[conViewGroup.PrjDomain] = oRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objRow[conViewGroup.ActionPath] = oRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objRow[conViewGroup.PrjId] = oRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objRow[conViewGroup.UserId] = oRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objRow[conViewGroup.UpdDate] = oRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objRow[conViewGroup.Memo] = oRow[conViewGroup.Memo].ToString().Trim(); //说明
objRow[conViewGroup.TableNameForProg] = oRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
 objDS.Tables[clsViewGroupEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewGroupEN._CurrTabName);
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
 /// <param name = "objViewGroupEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewGroupEN objViewGroupEN)
{
 objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroup where ViewGroupId = " + "'"+ objViewGroupEN.ViewGroupId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewGroupEN._CurrTabName);
if (objDS.Tables[clsViewGroupEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ViewGroupId = " + "'"+ objViewGroupEN.ViewGroupId+"'");
return false;
}
objRow = objDS.Tables[clsViewGroupEN._CurrTabName].Rows[0];
 if (objViewGroupEN.IsUpdated(conViewGroup.ViewGroupId))
 {
objRow[conViewGroup.ViewGroupId] = objViewGroupEN.ViewGroupId; //界面组ID
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.ViewGroupName))
 {
objRow[conViewGroup.ViewGroupName] = objViewGroupEN.ViewGroupName; //界面组名称
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.InSqlDsTypeId))
 {
objRow[conViewGroup.InSqlDsTypeId] = objViewGroupEN.InSqlDsTypeId; //输入数据源类型
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.InRelaTabId))
 {
objRow[conViewGroup.InRelaTabId] = objViewGroupEN.InRelaTabId; //输入数据源表ID
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.OutSqlDsTypeId))
 {
objRow[conViewGroup.OutSqlDsTypeId] = objViewGroupEN.OutSqlDsTypeId; //输出数据源类型
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.OutRelaTabId))
 {
objRow[conViewGroup.OutRelaTabId] = objViewGroupEN.OutRelaTabId; //输出数据源表ID
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjDomain))
 {
objRow[conViewGroup.PrjDomain] = objViewGroupEN.PrjDomain; //域/包名
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.ActionPath))
 {
objRow[conViewGroup.ActionPath] = objViewGroupEN.ActionPath; //Action路径
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjId))
 {
objRow[conViewGroup.PrjId] = objViewGroupEN.PrjId; //工程Id
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.UserId))
 {
objRow[conViewGroup.UserId] = objViewGroupEN.UserId; //用户Id
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.UpdDate))
 {
objRow[conViewGroup.UpdDate] = objViewGroupEN.UpdDate; //修改日期
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.Memo))
 {
objRow[conViewGroup.Memo] = objViewGroupEN.Memo; //说明
 }
 if (objViewGroupEN.IsUpdated(conViewGroup.TableNameForProg))
 {
objRow[conViewGroup.TableNameForProg] = objViewGroupEN.TableNameForProg; //编程用表名
 }
try
{
objDA.Update(objDS, clsViewGroupEN._CurrTabName);
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewGroupEN objViewGroupEN)
{
 objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewGroup Set ");
 
 if (objViewGroupEN.IsUpdated(conViewGroup.ViewGroupName))
 {
 if (objViewGroupEN.ViewGroupName !=  null)
 {
 var strViewGroupName = objViewGroupEN.ViewGroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewGroupName, conViewGroup.ViewGroupName); //界面组名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.ViewGroupName); //界面组名称
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.InSqlDsTypeId))
 {
 if (objViewGroupEN.InSqlDsTypeId  ==  "")
 {
 objViewGroupEN.InSqlDsTypeId = null;
 }
 if (objViewGroupEN.InSqlDsTypeId !=  null)
 {
 var strInSqlDsTypeId = objViewGroupEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInSqlDsTypeId, conViewGroup.InSqlDsTypeId); //输入数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.InSqlDsTypeId); //输入数据源类型
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.InRelaTabId))
 {
 if (objViewGroupEN.InRelaTabId  ==  "")
 {
 objViewGroupEN.InRelaTabId = null;
 }
 if (objViewGroupEN.InRelaTabId !=  null)
 {
 var strInRelaTabId = objViewGroupEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInRelaTabId, conViewGroup.InRelaTabId); //输入数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.InRelaTabId); //输入数据源表ID
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.OutSqlDsTypeId))
 {
 if (objViewGroupEN.OutSqlDsTypeId  ==  "")
 {
 objViewGroupEN.OutSqlDsTypeId = null;
 }
 if (objViewGroupEN.OutSqlDsTypeId !=  null)
 {
 var strOutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutSqlDsTypeId, conViewGroup.OutSqlDsTypeId); //输出数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.OutSqlDsTypeId); //输出数据源类型
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.OutRelaTabId))
 {
 if (objViewGroupEN.OutRelaTabId  ==  "")
 {
 objViewGroupEN.OutRelaTabId = null;
 }
 if (objViewGroupEN.OutRelaTabId !=  null)
 {
 var strOutRelaTabId = objViewGroupEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutRelaTabId, conViewGroup.OutRelaTabId); //输出数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.OutRelaTabId); //输出数据源表ID
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjDomain))
 {
 if (objViewGroupEN.PrjDomain !=  null)
 {
 var strPrjDomain = objViewGroupEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjDomain, conViewGroup.PrjDomain); //域/包名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.PrjDomain); //域/包名
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.ActionPath))
 {
 if (objViewGroupEN.ActionPath !=  null)
 {
 var strActionPath = objViewGroupEN.ActionPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strActionPath, conViewGroup.ActionPath); //Action路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.ActionPath); //Action路径
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjId))
 {
 if (objViewGroupEN.PrjId  ==  "")
 {
 objViewGroupEN.PrjId = null;
 }
 if (objViewGroupEN.PrjId !=  null)
 {
 var strPrjId = objViewGroupEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewGroup.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.PrjId); //工程Id
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.UserId))
 {
 if (objViewGroupEN.UserId !=  null)
 {
 var strUserId = objViewGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conViewGroup.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.UserId); //用户Id
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.UpdDate))
 {
 if (objViewGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objViewGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewGroup.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.UpdDate); //修改日期
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.Memo))
 {
 if (objViewGroupEN.Memo !=  null)
 {
 var strMemo = objViewGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewGroup.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.Memo); //说明
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.TableNameForProg))
 {
 if (objViewGroupEN.TableNameForProg !=  null)
 {
 var strTableNameForProg = objViewGroupEN.TableNameForProg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableNameForProg, conViewGroup.TableNameForProg); //编程用表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.TableNameForProg); //编程用表名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewGroupId = '{0}'", objViewGroupEN.ViewGroupId); 
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
 /// <param name = "objViewGroupEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewGroupEN objViewGroupEN, string strCondition)
{
 objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewGroup Set ");
 
 if (objViewGroupEN.IsUpdated(conViewGroup.ViewGroupName))
 {
 if (objViewGroupEN.ViewGroupName !=  null)
 {
 var strViewGroupName = objViewGroupEN.ViewGroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewGroupName = '{0}',", strViewGroupName); //界面组名称
 }
 else
 {
 sbSQL.Append(" ViewGroupName = null,"); //界面组名称
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.InSqlDsTypeId))
 {
 if (objViewGroupEN.InSqlDsTypeId  ==  "")
 {
 objViewGroupEN.InSqlDsTypeId = null;
 }
 if (objViewGroupEN.InSqlDsTypeId !=  null)
 {
 var strInSqlDsTypeId = objViewGroupEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InSqlDsTypeId = '{0}',", strInSqlDsTypeId); //输入数据源类型
 }
 else
 {
 sbSQL.Append(" InSqlDsTypeId = null,"); //输入数据源类型
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.InRelaTabId))
 {
 if (objViewGroupEN.InRelaTabId  ==  "")
 {
 objViewGroupEN.InRelaTabId = null;
 }
 if (objViewGroupEN.InRelaTabId !=  null)
 {
 var strInRelaTabId = objViewGroupEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InRelaTabId = '{0}',", strInRelaTabId); //输入数据源表ID
 }
 else
 {
 sbSQL.Append(" InRelaTabId = null,"); //输入数据源表ID
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.OutSqlDsTypeId))
 {
 if (objViewGroupEN.OutSqlDsTypeId  ==  "")
 {
 objViewGroupEN.OutSqlDsTypeId = null;
 }
 if (objViewGroupEN.OutSqlDsTypeId !=  null)
 {
 var strOutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutSqlDsTypeId = '{0}',", strOutSqlDsTypeId); //输出数据源类型
 }
 else
 {
 sbSQL.Append(" OutSqlDsTypeId = null,"); //输出数据源类型
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.OutRelaTabId))
 {
 if (objViewGroupEN.OutRelaTabId  ==  "")
 {
 objViewGroupEN.OutRelaTabId = null;
 }
 if (objViewGroupEN.OutRelaTabId !=  null)
 {
 var strOutRelaTabId = objViewGroupEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutRelaTabId = '{0}',", strOutRelaTabId); //输出数据源表ID
 }
 else
 {
 sbSQL.Append(" OutRelaTabId = null,"); //输出数据源表ID
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjDomain))
 {
 if (objViewGroupEN.PrjDomain !=  null)
 {
 var strPrjDomain = objViewGroupEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjDomain = '{0}',", strPrjDomain); //域/包名
 }
 else
 {
 sbSQL.Append(" PrjDomain = null,"); //域/包名
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.ActionPath))
 {
 if (objViewGroupEN.ActionPath !=  null)
 {
 var strActionPath = objViewGroupEN.ActionPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ActionPath = '{0}',", strActionPath); //Action路径
 }
 else
 {
 sbSQL.Append(" ActionPath = null,"); //Action路径
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjId))
 {
 if (objViewGroupEN.PrjId  ==  "")
 {
 objViewGroupEN.PrjId = null;
 }
 if (objViewGroupEN.PrjId !=  null)
 {
 var strPrjId = objViewGroupEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.UserId))
 {
 if (objViewGroupEN.UserId !=  null)
 {
 var strUserId = objViewGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.UpdDate))
 {
 if (objViewGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objViewGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.Memo))
 {
 if (objViewGroupEN.Memo !=  null)
 {
 var strMemo = objViewGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.TableNameForProg))
 {
 if (objViewGroupEN.TableNameForProg !=  null)
 {
 var strTableNameForProg = objViewGroupEN.TableNameForProg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableNameForProg = '{0}',", strTableNameForProg); //编程用表名
 }
 else
 {
 sbSQL.Append(" TableNameForProg = null,"); //编程用表名
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
 /// <param name = "objViewGroupEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewGroupEN objViewGroupEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewGroup Set ");
 
 if (objViewGroupEN.IsUpdated(conViewGroup.ViewGroupName))
 {
 if (objViewGroupEN.ViewGroupName !=  null)
 {
 var strViewGroupName = objViewGroupEN.ViewGroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewGroupName = '{0}',", strViewGroupName); //界面组名称
 }
 else
 {
 sbSQL.Append(" ViewGroupName = null,"); //界面组名称
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.InSqlDsTypeId))
 {
 if (objViewGroupEN.InSqlDsTypeId  ==  "")
 {
 objViewGroupEN.InSqlDsTypeId = null;
 }
 if (objViewGroupEN.InSqlDsTypeId !=  null)
 {
 var strInSqlDsTypeId = objViewGroupEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InSqlDsTypeId = '{0}',", strInSqlDsTypeId); //输入数据源类型
 }
 else
 {
 sbSQL.Append(" InSqlDsTypeId = null,"); //输入数据源类型
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.InRelaTabId))
 {
 if (objViewGroupEN.InRelaTabId  ==  "")
 {
 objViewGroupEN.InRelaTabId = null;
 }
 if (objViewGroupEN.InRelaTabId !=  null)
 {
 var strInRelaTabId = objViewGroupEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InRelaTabId = '{0}',", strInRelaTabId); //输入数据源表ID
 }
 else
 {
 sbSQL.Append(" InRelaTabId = null,"); //输入数据源表ID
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.OutSqlDsTypeId))
 {
 if (objViewGroupEN.OutSqlDsTypeId  ==  "")
 {
 objViewGroupEN.OutSqlDsTypeId = null;
 }
 if (objViewGroupEN.OutSqlDsTypeId !=  null)
 {
 var strOutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutSqlDsTypeId = '{0}',", strOutSqlDsTypeId); //输出数据源类型
 }
 else
 {
 sbSQL.Append(" OutSqlDsTypeId = null,"); //输出数据源类型
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.OutRelaTabId))
 {
 if (objViewGroupEN.OutRelaTabId  ==  "")
 {
 objViewGroupEN.OutRelaTabId = null;
 }
 if (objViewGroupEN.OutRelaTabId !=  null)
 {
 var strOutRelaTabId = objViewGroupEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutRelaTabId = '{0}',", strOutRelaTabId); //输出数据源表ID
 }
 else
 {
 sbSQL.Append(" OutRelaTabId = null,"); //输出数据源表ID
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjDomain))
 {
 if (objViewGroupEN.PrjDomain !=  null)
 {
 var strPrjDomain = objViewGroupEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjDomain = '{0}',", strPrjDomain); //域/包名
 }
 else
 {
 sbSQL.Append(" PrjDomain = null,"); //域/包名
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.ActionPath))
 {
 if (objViewGroupEN.ActionPath !=  null)
 {
 var strActionPath = objViewGroupEN.ActionPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ActionPath = '{0}',", strActionPath); //Action路径
 }
 else
 {
 sbSQL.Append(" ActionPath = null,"); //Action路径
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjId))
 {
 if (objViewGroupEN.PrjId  ==  "")
 {
 objViewGroupEN.PrjId = null;
 }
 if (objViewGroupEN.PrjId !=  null)
 {
 var strPrjId = objViewGroupEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.UserId))
 {
 if (objViewGroupEN.UserId !=  null)
 {
 var strUserId = objViewGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.UpdDate))
 {
 if (objViewGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objViewGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.Memo))
 {
 if (objViewGroupEN.Memo !=  null)
 {
 var strMemo = objViewGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.TableNameForProg))
 {
 if (objViewGroupEN.TableNameForProg !=  null)
 {
 var strTableNameForProg = objViewGroupEN.TableNameForProg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableNameForProg = '{0}',", strTableNameForProg); //编程用表名
 }
 else
 {
 sbSQL.Append(" TableNameForProg = null,"); //编程用表名
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewGroupEN objViewGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewGroup Set ");
 
 if (objViewGroupEN.IsUpdated(conViewGroup.ViewGroupName))
 {
 if (objViewGroupEN.ViewGroupName !=  null)
 {
 var strViewGroupName = objViewGroupEN.ViewGroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewGroupName, conViewGroup.ViewGroupName); //界面组名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.ViewGroupName); //界面组名称
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.InSqlDsTypeId))
 {
 if (objViewGroupEN.InSqlDsTypeId  ==  "")
 {
 objViewGroupEN.InSqlDsTypeId = null;
 }
 if (objViewGroupEN.InSqlDsTypeId !=  null)
 {
 var strInSqlDsTypeId = objViewGroupEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInSqlDsTypeId, conViewGroup.InSqlDsTypeId); //输入数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.InSqlDsTypeId); //输入数据源类型
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.InRelaTabId))
 {
 if (objViewGroupEN.InRelaTabId  ==  "")
 {
 objViewGroupEN.InRelaTabId = null;
 }
 if (objViewGroupEN.InRelaTabId !=  null)
 {
 var strInRelaTabId = objViewGroupEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInRelaTabId, conViewGroup.InRelaTabId); //输入数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.InRelaTabId); //输入数据源表ID
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.OutSqlDsTypeId))
 {
 if (objViewGroupEN.OutSqlDsTypeId  ==  "")
 {
 objViewGroupEN.OutSqlDsTypeId = null;
 }
 if (objViewGroupEN.OutSqlDsTypeId !=  null)
 {
 var strOutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutSqlDsTypeId, conViewGroup.OutSqlDsTypeId); //输出数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.OutSqlDsTypeId); //输出数据源类型
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.OutRelaTabId))
 {
 if (objViewGroupEN.OutRelaTabId  ==  "")
 {
 objViewGroupEN.OutRelaTabId = null;
 }
 if (objViewGroupEN.OutRelaTabId !=  null)
 {
 var strOutRelaTabId = objViewGroupEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutRelaTabId, conViewGroup.OutRelaTabId); //输出数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.OutRelaTabId); //输出数据源表ID
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjDomain))
 {
 if (objViewGroupEN.PrjDomain !=  null)
 {
 var strPrjDomain = objViewGroupEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjDomain, conViewGroup.PrjDomain); //域/包名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.PrjDomain); //域/包名
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.ActionPath))
 {
 if (objViewGroupEN.ActionPath !=  null)
 {
 var strActionPath = objViewGroupEN.ActionPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strActionPath, conViewGroup.ActionPath); //Action路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.ActionPath); //Action路径
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.PrjId))
 {
 if (objViewGroupEN.PrjId  ==  "")
 {
 objViewGroupEN.PrjId = null;
 }
 if (objViewGroupEN.PrjId !=  null)
 {
 var strPrjId = objViewGroupEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewGroup.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.PrjId); //工程Id
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.UserId))
 {
 if (objViewGroupEN.UserId !=  null)
 {
 var strUserId = objViewGroupEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conViewGroup.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.UserId); //用户Id
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.UpdDate))
 {
 if (objViewGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objViewGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewGroup.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.UpdDate); //修改日期
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.Memo))
 {
 if (objViewGroupEN.Memo !=  null)
 {
 var strMemo = objViewGroupEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewGroup.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.Memo); //说明
 }
 }
 
 if (objViewGroupEN.IsUpdated(conViewGroup.TableNameForProg))
 {
 if (objViewGroupEN.TableNameForProg !=  null)
 {
 var strTableNameForProg = objViewGroupEN.TableNameForProg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableNameForProg, conViewGroup.TableNameForProg); //编程用表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroup.TableNameForProg); //编程用表名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewGroupId = '{0}'", objViewGroupEN.ViewGroupId); 
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
 /// <param name = "strViewGroupId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strViewGroupId) 
{
CheckPrimaryKey(strViewGroupId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strViewGroupId,
};
 objSQL.ExecSP("ViewGroup_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strViewGroupId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strViewGroupId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strViewGroupId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
//删除ViewGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewGroup where ViewGroupId = " + "'"+ strViewGroupId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewGroup(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
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
//删除ViewGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewGroup where ViewGroupId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strViewGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strViewGroupId) 
{
CheckPrimaryKey(strViewGroupId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
//删除ViewGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewGroup where ViewGroupId = " + "'"+ strViewGroupId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewGroupDA: DelViewGroup)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewGroup where " + strCondition ;
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
public bool DelViewGroupWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewGroupDA: DelViewGroupWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewGroup where " + strCondition ;
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
 /// <param name = "objViewGroupENS">源对象</param>
 /// <param name = "objViewGroupENT">目标对象</param>
public void CopyTo(clsViewGroupEN objViewGroupENS, clsViewGroupEN objViewGroupENT)
{
objViewGroupENT.ViewGroupId = objViewGroupENS.ViewGroupId; //界面组ID
objViewGroupENT.ViewGroupName = objViewGroupENS.ViewGroupName; //界面组名称
objViewGroupENT.InSqlDsTypeId = objViewGroupENS.InSqlDsTypeId; //输入数据源类型
objViewGroupENT.InRelaTabId = objViewGroupENS.InRelaTabId; //输入数据源表ID
objViewGroupENT.OutSqlDsTypeId = objViewGroupENS.OutSqlDsTypeId; //输出数据源类型
objViewGroupENT.OutRelaTabId = objViewGroupENS.OutRelaTabId; //输出数据源表ID
objViewGroupENT.PrjDomain = objViewGroupENS.PrjDomain; //域/包名
objViewGroupENT.ActionPath = objViewGroupENS.ActionPath; //Action路径
objViewGroupENT.PrjId = objViewGroupENS.PrjId; //工程Id
objViewGroupENT.UserId = objViewGroupENS.UserId; //用户Id
objViewGroupENT.UpdDate = objViewGroupENS.UpdDate; //修改日期
objViewGroupENT.Memo = objViewGroupENS.Memo; //说明
objViewGroupENT.TableNameForProg = objViewGroupENS.TableNameForProg; //编程用表名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewGroupEN objViewGroupEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewGroupEN.ViewGroupName, conViewGroup.ViewGroupName);
clsCheckSql.CheckFieldNotNull(objViewGroupEN.OutRelaTabId, conViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldNotNull(objViewGroupEN.ActionPath, conViewGroup.ActionPath);
clsCheckSql.CheckFieldNotNull(objViewGroupEN.PrjId, conViewGroup.PrjId);
clsCheckSql.CheckFieldNotNull(objViewGroupEN.UserId, conViewGroup.UserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewGroupEN.ViewGroupId, 8, conViewGroup.ViewGroupId);
clsCheckSql.CheckFieldLen(objViewGroupEN.ViewGroupName, 30, conViewGroup.ViewGroupName);
clsCheckSql.CheckFieldLen(objViewGroupEN.InSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewGroupEN.InRelaTabId, 8, conViewGroup.InRelaTabId);
clsCheckSql.CheckFieldLen(objViewGroupEN.OutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewGroupEN.OutRelaTabId, 8, conViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldLen(objViewGroupEN.PrjDomain, 128, conViewGroup.PrjDomain);
clsCheckSql.CheckFieldLen(objViewGroupEN.ActionPath, 100, conViewGroup.ActionPath);
clsCheckSql.CheckFieldLen(objViewGroupEN.PrjId, 4, conViewGroup.PrjId);
clsCheckSql.CheckFieldLen(objViewGroupEN.UserId, 18, conViewGroup.UserId);
clsCheckSql.CheckFieldLen(objViewGroupEN.UpdDate, 20, conViewGroup.UpdDate);
clsCheckSql.CheckFieldLen(objViewGroupEN.Memo, 1000, conViewGroup.Memo);
clsCheckSql.CheckFieldLen(objViewGroupEN.TableNameForProg, 50, conViewGroup.TableNameForProg);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.InSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.InRelaTabId, 8, conViewGroup.InRelaTabId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.OutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.OutRelaTabId, 8, conViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.PrjId, 4, conViewGroup.PrjId);
 objViewGroupEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewGroupEN objViewGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewGroupEN.ViewGroupName, 30, conViewGroup.ViewGroupName);
clsCheckSql.CheckFieldLen(objViewGroupEN.InSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewGroupEN.InRelaTabId, 8, conViewGroup.InRelaTabId);
clsCheckSql.CheckFieldLen(objViewGroupEN.OutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewGroupEN.OutRelaTabId, 8, conViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldLen(objViewGroupEN.PrjDomain, 128, conViewGroup.PrjDomain);
clsCheckSql.CheckFieldLen(objViewGroupEN.ActionPath, 100, conViewGroup.ActionPath);
clsCheckSql.CheckFieldLen(objViewGroupEN.PrjId, 4, conViewGroup.PrjId);
clsCheckSql.CheckFieldLen(objViewGroupEN.UserId, 18, conViewGroup.UserId);
clsCheckSql.CheckFieldLen(objViewGroupEN.UpdDate, 20, conViewGroup.UpdDate);
clsCheckSql.CheckFieldLen(objViewGroupEN.Memo, 1000, conViewGroup.Memo);
clsCheckSql.CheckFieldLen(objViewGroupEN.TableNameForProg, 50, conViewGroup.TableNameForProg);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.InSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.InRelaTabId, 8, conViewGroup.InRelaTabId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.OutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.OutRelaTabId, 8, conViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.PrjId, 4, conViewGroup.PrjId);
 objViewGroupEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewGroupEN objViewGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewGroupEN.ViewGroupId, 8, conViewGroup.ViewGroupId);
clsCheckSql.CheckFieldLen(objViewGroupEN.ViewGroupName, 30, conViewGroup.ViewGroupName);
clsCheckSql.CheckFieldLen(objViewGroupEN.InSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewGroupEN.InRelaTabId, 8, conViewGroup.InRelaTabId);
clsCheckSql.CheckFieldLen(objViewGroupEN.OutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewGroupEN.OutRelaTabId, 8, conViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldLen(objViewGroupEN.PrjDomain, 128, conViewGroup.PrjDomain);
clsCheckSql.CheckFieldLen(objViewGroupEN.ActionPath, 100, conViewGroup.ActionPath);
clsCheckSql.CheckFieldLen(objViewGroupEN.PrjId, 4, conViewGroup.PrjId);
clsCheckSql.CheckFieldLen(objViewGroupEN.UserId, 18, conViewGroup.UserId);
clsCheckSql.CheckFieldLen(objViewGroupEN.UpdDate, 20, conViewGroup.UpdDate);
clsCheckSql.CheckFieldLen(objViewGroupEN.Memo, 1000, conViewGroup.Memo);
clsCheckSql.CheckFieldLen(objViewGroupEN.TableNameForProg, 50, conViewGroup.TableNameForProg);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.ViewGroupId, conViewGroup.ViewGroupId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.ViewGroupName, conViewGroup.ViewGroupName);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.InSqlDsTypeId, conViewGroup.InSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.InRelaTabId, conViewGroup.InRelaTabId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.OutSqlDsTypeId, conViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.OutRelaTabId, conViewGroup.OutRelaTabId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.PrjDomain, conViewGroup.PrjDomain);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.ActionPath, conViewGroup.ActionPath);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.PrjId, conViewGroup.PrjId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.UserId, conViewGroup.UserId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.UpdDate, conViewGroup.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.Memo, conViewGroup.Memo);
clsCheckSql.CheckSqlInjection4Field(objViewGroupEN.TableNameForProg, conViewGroup.TableNameForProg);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.InSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.InRelaTabId, 8, conViewGroup.InRelaTabId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.OutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.OutRelaTabId, 8, conViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldForeignKey(objViewGroupEN.PrjId, 4, conViewGroup.PrjId);
 objViewGroupEN._IsCheckProperty = true;
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
string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
 clsSpecSQLforSql mySql = clsViewGroupDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewGroup(界面组),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewGroupEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewGroupEN objViewGroupEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewGroupName = '{0}'", objViewGroupEN.ViewGroupName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewGroupEN.PrjId);
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
 objSQL = clsViewGroupDA.GetSpecSQLObj();
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
 objSQL = clsViewGroupDA.GetSpecSQLObj();
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
 objSQL = clsViewGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewGroupEN._CurrTabName);
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
 objSQL = clsViewGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewGroupEN._CurrTabName, strCondition);
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
 objSQL = clsViewGroupDA.GetSpecSQLObj();
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
 objSQL = clsViewGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}