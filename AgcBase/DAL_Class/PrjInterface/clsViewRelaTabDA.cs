
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRelaTabDA
 表名:ViewRelaTab(00050100)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 界面相关表(ViewRelaTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewRelaTabDA : clsCommBase4DA
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
 return clsViewRelaTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewRelaTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewRelaTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewRelaTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewRelaTabEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewRelaTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewRelaTabDA: GetDataTable_ViewRelaTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewRelaTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRelaTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRelaTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewRelaTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewRelaTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewRelaTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewRelaTab.* " + 
$"from ViewRelaTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewRelaTab.mId not in " + 
$"(Select top {intTop_In} ViewRelaTab.mId from ViewRelaTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRelaTab where {1} and mId not in (Select top {2} mId from ViewRelaTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRelaTab where {1} and mId not in (Select top {3} mId from ViewRelaTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewRelaTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewRelaTab.* " + 
$"from ViewRelaTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewRelaTab.mId not in " + 
$"(Select top {intTop_In} ViewRelaTab.mId from ViewRelaTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRelaTab where {1} and mId not in (Select top {2} mId from ViewRelaTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRelaTab where {1} and mId not in (Select top {3} mId from ViewRelaTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewRelaTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewRelaTabDA:GetObjLst)", objException.Message));
}
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = TransNullToInt(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程Id
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewRelaTabDA: GetObjLst)", objException.Message));
}
objViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewRelaTabEN);
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
public List<clsViewRelaTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewRelaTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = TransNullToInt(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程Id
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewRelaTabDA: GetObjLst)", objException.Message));
}
objViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewRelaTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewRelaTab(ref clsViewRelaTabEN objViewRelaTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where mId = " + ""+ objViewRelaTabEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewRelaTabEN.mId = TransNullToInt(objDT.Rows[0][conViewRelaTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewRelaTabEN.ViewId = objDT.Rows[0][conViewRelaTab.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewRelaTabEN.RegionId = objDT.Rows[0][conViewRelaTab.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objViewRelaTabEN.InOutTypeId = objDT.Rows[0][conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objViewRelaTabEN.ViewTabTypeId = objDT.Rows[0][conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码(字段类型:varchar,字段长度:4,是否可空:False)
 objViewRelaTabEN.TabId = objDT.Rows[0][conViewRelaTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewRelaTabEN.TabFunction = objDT.Rows[0][conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明(字段类型:varchar,字段长度:500,是否可空:True)
 objViewRelaTabEN.PrjId = objDT.Rows[0][conViewRelaTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewRelaTabEN.UpdDate = objDT.Rows[0][conViewRelaTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRelaTabEN.UpdUser = objDT.Rows[0][conViewRelaTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRelaTabEN.Memo = objDT.Rows[0][conViewRelaTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewRelaTabDA: GetViewRelaTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewRelaTabEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
 objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码(字段类型:varchar,字段长度:4,是否可空:False)
 objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明(字段类型:varchar,字段长度:500,是否可空:True)
 objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewRelaTabDA: GetObjBymId)", objException.Message));
}
return objViewRelaTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewRelaTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewRelaTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN()
{
mId = TransNullToInt(objRow[conViewRelaTab.mId].ToString().Trim()), //mId
ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(), //界面Id
RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(), //区域Id
InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(), //INOUT类型ID
ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(), //界面表类型码
TabId = objRow[conViewRelaTab.TabId].ToString().Trim(), //表ID
TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(), //表功能说明
PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim() //说明
};
objViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRelaTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewRelaTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewRelaTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = TransNullToInt(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程Id
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewRelaTabDA: GetObjByDataRowViewRelaTab)", objException.Message));
}
objViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRelaTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewRelaTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = TransNullToInt(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程Id
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewRelaTabDA: GetObjByDataRow)", objException.Message));
}
objViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRelaTabEN;
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
objSQL = clsViewRelaTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewRelaTabEN._CurrTabName, conViewRelaTab.mId, 8, "");
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
objSQL = clsViewRelaTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewRelaTabEN._CurrTabName, conViewRelaTab.mId, 8, strPrefix);
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ViewRelaTab where " + strCondition;
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ViewRelaTab where " + strCondition;
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewRelaTab", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewRelaTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewRelaTab", strCondition))
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
objSQL = clsViewRelaTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewRelaTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewRelaTabEN objViewRelaTabEN)
 {
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRelaTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewRelaTab");
objRow = objDS.Tables["ViewRelaTab"].NewRow();
objRow[conViewRelaTab.ViewId] = objViewRelaTabEN.ViewId; //界面Id
objRow[conViewRelaTab.RegionId] = objViewRelaTabEN.RegionId; //区域Id
objRow[conViewRelaTab.InOutTypeId] = objViewRelaTabEN.InOutTypeId; //INOUT类型ID
objRow[conViewRelaTab.ViewTabTypeId] = objViewRelaTabEN.ViewTabTypeId; //界面表类型码
objRow[conViewRelaTab.TabId] = objViewRelaTabEN.TabId; //表ID
 if (objViewRelaTabEN.TabFunction !=  "")
 {
objRow[conViewRelaTab.TabFunction] = objViewRelaTabEN.TabFunction; //表功能说明
 }
objRow[conViewRelaTab.PrjId] = objViewRelaTabEN.PrjId; //工程Id
 if (objViewRelaTabEN.UpdDate !=  "")
 {
objRow[conViewRelaTab.UpdDate] = objViewRelaTabEN.UpdDate; //修改日期
 }
 if (objViewRelaTabEN.UpdUser !=  "")
 {
objRow[conViewRelaTab.UpdUser] = objViewRelaTabEN.UpdUser; //修改者
 }
 if (objViewRelaTabEN.Memo !=  "")
 {
objRow[conViewRelaTab.Memo] = objViewRelaTabEN.Memo; //说明
 }
objDS.Tables[clsViewRelaTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewRelaTabEN._CurrTabName);
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
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewRelaTabEN objViewRelaTabEN)
{
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRelaTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewRelaTabEN.ViewId  ==  "")
 {
 objViewRelaTabEN.ViewId = null;
 }
 if (objViewRelaTabEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.ViewId);
 var strViewId = objViewRelaTabEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewRelaTabEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.RegionId);
 var strRegionId = objViewRelaTabEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRelaTabEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.InOutTypeId);
 var strInOutTypeId = objViewRelaTabEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objViewRelaTabEN.ViewTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.ViewTabTypeId);
 var strViewTabTypeId = objViewRelaTabEN.ViewTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTabTypeId + "'");
 }
 
 if (objViewRelaTabEN.TabId  ==  "")
 {
 objViewRelaTabEN.TabId = null;
 }
 if (objViewRelaTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.TabId);
 var strTabId = objViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objViewRelaTabEN.TabFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.TabFunction);
 var strTabFunction = objViewRelaTabEN.TabFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFunction + "'");
 }
 
 if (objViewRelaTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.PrjId);
 var strPrjId = objViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRelaTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.UpdDate);
 var strUpdDate = objViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRelaTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.UpdUser);
 var strUpdUser = objViewRelaTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRelaTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.Memo);
 var strMemo = objViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRelaTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewRelaTabEN objViewRelaTabEN)
{
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRelaTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewRelaTabEN.ViewId  ==  "")
 {
 objViewRelaTabEN.ViewId = null;
 }
 if (objViewRelaTabEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.ViewId);
 var strViewId = objViewRelaTabEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewRelaTabEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.RegionId);
 var strRegionId = objViewRelaTabEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRelaTabEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.InOutTypeId);
 var strInOutTypeId = objViewRelaTabEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objViewRelaTabEN.ViewTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.ViewTabTypeId);
 var strViewTabTypeId = objViewRelaTabEN.ViewTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTabTypeId + "'");
 }
 
 if (objViewRelaTabEN.TabId  ==  "")
 {
 objViewRelaTabEN.TabId = null;
 }
 if (objViewRelaTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.TabId);
 var strTabId = objViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objViewRelaTabEN.TabFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.TabFunction);
 var strTabFunction = objViewRelaTabEN.TabFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFunction + "'");
 }
 
 if (objViewRelaTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.PrjId);
 var strPrjId = objViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRelaTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.UpdDate);
 var strUpdDate = objViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRelaTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.UpdUser);
 var strUpdUser = objViewRelaTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRelaTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.Memo);
 var strMemo = objViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRelaTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewRelaTabEN objViewRelaTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRelaTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewRelaTabEN.ViewId  ==  "")
 {
 objViewRelaTabEN.ViewId = null;
 }
 if (objViewRelaTabEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.ViewId);
 var strViewId = objViewRelaTabEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewRelaTabEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.RegionId);
 var strRegionId = objViewRelaTabEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRelaTabEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.InOutTypeId);
 var strInOutTypeId = objViewRelaTabEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objViewRelaTabEN.ViewTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.ViewTabTypeId);
 var strViewTabTypeId = objViewRelaTabEN.ViewTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTabTypeId + "'");
 }
 
 if (objViewRelaTabEN.TabId  ==  "")
 {
 objViewRelaTabEN.TabId = null;
 }
 if (objViewRelaTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.TabId);
 var strTabId = objViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objViewRelaTabEN.TabFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.TabFunction);
 var strTabFunction = objViewRelaTabEN.TabFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFunction + "'");
 }
 
 if (objViewRelaTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.PrjId);
 var strPrjId = objViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRelaTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.UpdDate);
 var strUpdDate = objViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRelaTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.UpdUser);
 var strUpdUser = objViewRelaTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRelaTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.Memo);
 var strMemo = objViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRelaTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewRelaTabEN objViewRelaTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRelaTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewRelaTabEN.ViewId  ==  "")
 {
 objViewRelaTabEN.ViewId = null;
 }
 if (objViewRelaTabEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.ViewId);
 var strViewId = objViewRelaTabEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewRelaTabEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.RegionId);
 var strRegionId = objViewRelaTabEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRelaTabEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.InOutTypeId);
 var strInOutTypeId = objViewRelaTabEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objViewRelaTabEN.ViewTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.ViewTabTypeId);
 var strViewTabTypeId = objViewRelaTabEN.ViewTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTabTypeId + "'");
 }
 
 if (objViewRelaTabEN.TabId  ==  "")
 {
 objViewRelaTabEN.TabId = null;
 }
 if (objViewRelaTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.TabId);
 var strTabId = objViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objViewRelaTabEN.TabFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.TabFunction);
 var strTabFunction = objViewRelaTabEN.TabFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFunction + "'");
 }
 
 if (objViewRelaTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.PrjId);
 var strPrjId = objViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRelaTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.UpdDate);
 var strUpdDate = objViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRelaTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.UpdUser);
 var strUpdUser = objViewRelaTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRelaTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRelaTab.Memo);
 var strMemo = objViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRelaTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewRelaTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewRelaTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conViewRelaTab.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewRelaTabEN._CurrTabName ].NewRow();
objRow[conViewRelaTab.ViewId] = oRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objRow[conViewRelaTab.RegionId] = oRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objRow[conViewRelaTab.InOutTypeId] = oRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objRow[conViewRelaTab.ViewTabTypeId] = oRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objRow[conViewRelaTab.TabId] = oRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objRow[conViewRelaTab.TabFunction] = oRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objRow[conViewRelaTab.PrjId] = oRow[conViewRelaTab.PrjId].ToString().Trim(); //工程Id
objRow[conViewRelaTab.UpdDate] = oRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objRow[conViewRelaTab.UpdUser] = oRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objRow[conViewRelaTab.Memo] = oRow[conViewRelaTab.Memo].ToString().Trim(); //说明
 objDS.Tables[clsViewRelaTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewRelaTabEN._CurrTabName);
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
 /// <param name = "objViewRelaTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewRelaTabEN objViewRelaTabEN)
{
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRelaTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewRelaTab where mId = " + ""+ objViewRelaTabEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewRelaTabEN._CurrTabName);
if (objDS.Tables[clsViewRelaTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objViewRelaTabEN.mId+"");
return false;
}
objRow = objDS.Tables[clsViewRelaTabEN._CurrTabName].Rows[0];
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewId))
 {
objRow[conViewRelaTab.ViewId] = objViewRelaTabEN.ViewId; //界面Id
 }
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.RegionId))
 {
objRow[conViewRelaTab.RegionId] = objViewRelaTabEN.RegionId; //区域Id
 }
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.InOutTypeId))
 {
objRow[conViewRelaTab.InOutTypeId] = objViewRelaTabEN.InOutTypeId; //INOUT类型ID
 }
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewTabTypeId))
 {
objRow[conViewRelaTab.ViewTabTypeId] = objViewRelaTabEN.ViewTabTypeId; //界面表类型码
 }
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabId))
 {
objRow[conViewRelaTab.TabId] = objViewRelaTabEN.TabId; //表ID
 }
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabFunction))
 {
objRow[conViewRelaTab.TabFunction] = objViewRelaTabEN.TabFunction; //表功能说明
 }
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.PrjId))
 {
objRow[conViewRelaTab.PrjId] = objViewRelaTabEN.PrjId; //工程Id
 }
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdDate))
 {
objRow[conViewRelaTab.UpdDate] = objViewRelaTabEN.UpdDate; //修改日期
 }
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdUser))
 {
objRow[conViewRelaTab.UpdUser] = objViewRelaTabEN.UpdUser; //修改者
 }
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.Memo))
 {
objRow[conViewRelaTab.Memo] = objViewRelaTabEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsViewRelaTabEN._CurrTabName);
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
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewRelaTabEN objViewRelaTabEN)
{
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRelaTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewRelaTab Set ");
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewId))
 {
 if (objViewRelaTabEN.ViewId  ==  "")
 {
 objViewRelaTabEN.ViewId = null;
 }
 if (objViewRelaTabEN.ViewId !=  null)
 {
 var strViewId = objViewRelaTabEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conViewRelaTab.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.ViewId); //界面Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.RegionId))
 {
 if (objViewRelaTabEN.RegionId !=  null)
 {
 var strRegionId = objViewRelaTabEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conViewRelaTab.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.RegionId); //区域Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.InOutTypeId))
 {
 if (objViewRelaTabEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objViewRelaTabEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conViewRelaTab.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewTabTypeId))
 {
 if (objViewRelaTabEN.ViewTabTypeId !=  null)
 {
 var strViewTabTypeId = objViewRelaTabEN.ViewTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewTabTypeId, conViewRelaTab.ViewTabTypeId); //界面表类型码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.ViewTabTypeId); //界面表类型码
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabId))
 {
 if (objViewRelaTabEN.TabId  ==  "")
 {
 objViewRelaTabEN.TabId = null;
 }
 if (objViewRelaTabEN.TabId !=  null)
 {
 var strTabId = objViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conViewRelaTab.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.TabId); //表ID
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabFunction))
 {
 if (objViewRelaTabEN.TabFunction !=  null)
 {
 var strTabFunction = objViewRelaTabEN.TabFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFunction, conViewRelaTab.TabFunction); //表功能说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.TabFunction); //表功能说明
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.PrjId))
 {
 if (objViewRelaTabEN.PrjId !=  null)
 {
 var strPrjId = objViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewRelaTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.PrjId); //工程Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdDate))
 {
 if (objViewRelaTabEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewRelaTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.UpdDate); //修改日期
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdUser))
 {
 if (objViewRelaTabEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRelaTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewRelaTab.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.UpdUser); //修改者
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.Memo))
 {
 if (objViewRelaTabEN.Memo !=  null)
 {
 var strMemo = objViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewRelaTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewRelaTabEN.mId); 
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
 /// <param name = "objViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewRelaTabEN objViewRelaTabEN, string strCondition)
{
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRelaTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRelaTab Set ");
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewId))
 {
 if (objViewRelaTabEN.ViewId  ==  "")
 {
 objViewRelaTabEN.ViewId = null;
 }
 if (objViewRelaTabEN.ViewId !=  null)
 {
 var strViewId = objViewRelaTabEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.RegionId))
 {
 if (objViewRelaTabEN.RegionId !=  null)
 {
 var strRegionId = objViewRelaTabEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.InOutTypeId))
 {
 if (objViewRelaTabEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objViewRelaTabEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewTabTypeId))
 {
 if (objViewRelaTabEN.ViewTabTypeId !=  null)
 {
 var strViewTabTypeId = objViewRelaTabEN.ViewTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewTabTypeId = '{0}',", strViewTabTypeId); //界面表类型码
 }
 else
 {
 sbSQL.Append(" ViewTabTypeId = null,"); //界面表类型码
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabId))
 {
 if (objViewRelaTabEN.TabId  ==  "")
 {
 objViewRelaTabEN.TabId = null;
 }
 if (objViewRelaTabEN.TabId !=  null)
 {
 var strTabId = objViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabFunction))
 {
 if (objViewRelaTabEN.TabFunction !=  null)
 {
 var strTabFunction = objViewRelaTabEN.TabFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFunction = '{0}',", strTabFunction); //表功能说明
 }
 else
 {
 sbSQL.Append(" TabFunction = null,"); //表功能说明
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.PrjId))
 {
 if (objViewRelaTabEN.PrjId !=  null)
 {
 var strPrjId = objViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdDate))
 {
 if (objViewRelaTabEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdUser))
 {
 if (objViewRelaTabEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRelaTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.Memo))
 {
 if (objViewRelaTabEN.Memo !=  null)
 {
 var strMemo = objViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewRelaTabEN objViewRelaTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRelaTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRelaTab Set ");
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewId))
 {
 if (objViewRelaTabEN.ViewId  ==  "")
 {
 objViewRelaTabEN.ViewId = null;
 }
 if (objViewRelaTabEN.ViewId !=  null)
 {
 var strViewId = objViewRelaTabEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.RegionId))
 {
 if (objViewRelaTabEN.RegionId !=  null)
 {
 var strRegionId = objViewRelaTabEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.InOutTypeId))
 {
 if (objViewRelaTabEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objViewRelaTabEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewTabTypeId))
 {
 if (objViewRelaTabEN.ViewTabTypeId !=  null)
 {
 var strViewTabTypeId = objViewRelaTabEN.ViewTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewTabTypeId = '{0}',", strViewTabTypeId); //界面表类型码
 }
 else
 {
 sbSQL.Append(" ViewTabTypeId = null,"); //界面表类型码
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabId))
 {
 if (objViewRelaTabEN.TabId  ==  "")
 {
 objViewRelaTabEN.TabId = null;
 }
 if (objViewRelaTabEN.TabId !=  null)
 {
 var strTabId = objViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabFunction))
 {
 if (objViewRelaTabEN.TabFunction !=  null)
 {
 var strTabFunction = objViewRelaTabEN.TabFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFunction = '{0}',", strTabFunction); //表功能说明
 }
 else
 {
 sbSQL.Append(" TabFunction = null,"); //表功能说明
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.PrjId))
 {
 if (objViewRelaTabEN.PrjId !=  null)
 {
 var strPrjId = objViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdDate))
 {
 if (objViewRelaTabEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdUser))
 {
 if (objViewRelaTabEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRelaTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.Memo))
 {
 if (objViewRelaTabEN.Memo !=  null)
 {
 var strMemo = objViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewRelaTabEN objViewRelaTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRelaTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRelaTab Set ");
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewId))
 {
 if (objViewRelaTabEN.ViewId  ==  "")
 {
 objViewRelaTabEN.ViewId = null;
 }
 if (objViewRelaTabEN.ViewId !=  null)
 {
 var strViewId = objViewRelaTabEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conViewRelaTab.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.ViewId); //界面Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.RegionId))
 {
 if (objViewRelaTabEN.RegionId !=  null)
 {
 var strRegionId = objViewRelaTabEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conViewRelaTab.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.RegionId); //区域Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.InOutTypeId))
 {
 if (objViewRelaTabEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objViewRelaTabEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conViewRelaTab.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.ViewTabTypeId))
 {
 if (objViewRelaTabEN.ViewTabTypeId !=  null)
 {
 var strViewTabTypeId = objViewRelaTabEN.ViewTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewTabTypeId, conViewRelaTab.ViewTabTypeId); //界面表类型码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.ViewTabTypeId); //界面表类型码
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabId))
 {
 if (objViewRelaTabEN.TabId  ==  "")
 {
 objViewRelaTabEN.TabId = null;
 }
 if (objViewRelaTabEN.TabId !=  null)
 {
 var strTabId = objViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conViewRelaTab.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.TabId); //表ID
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.TabFunction))
 {
 if (objViewRelaTabEN.TabFunction !=  null)
 {
 var strTabFunction = objViewRelaTabEN.TabFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFunction, conViewRelaTab.TabFunction); //表功能说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.TabFunction); //表功能说明
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.PrjId))
 {
 if (objViewRelaTabEN.PrjId !=  null)
 {
 var strPrjId = objViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewRelaTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.PrjId); //工程Id
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdDate))
 {
 if (objViewRelaTabEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewRelaTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.UpdDate); //修改日期
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.UpdUser))
 {
 if (objViewRelaTabEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRelaTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewRelaTab.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.UpdUser); //修改者
 }
 }
 
 if (objViewRelaTabEN.IsUpdated(conViewRelaTab.Memo))
 {
 if (objViewRelaTabEN.Memo !=  null)
 {
 var strMemo = objViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewRelaTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRelaTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewRelaTabEN.mId); 
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ViewRelaTab_Delete", values);
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
//删除ViewRelaTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRelaTab where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewRelaTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
//删除ViewRelaTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRelaTab where mId in (" + strKeyList + ")";
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
//删除ViewRelaTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRelaTab where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewRelaTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewRelaTabDA: DelViewRelaTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewRelaTab where " + strCondition ;
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
public bool DelViewRelaTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewRelaTabDA: DelViewRelaTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewRelaTab where " + strCondition ;
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
 /// <param name = "objViewRelaTabENS">源对象</param>
 /// <param name = "objViewRelaTabENT">目标对象</param>
public void CopyTo(clsViewRelaTabEN objViewRelaTabENS, clsViewRelaTabEN objViewRelaTabENT)
{
objViewRelaTabENT.mId = objViewRelaTabENS.mId; //mId
objViewRelaTabENT.ViewId = objViewRelaTabENS.ViewId; //界面Id
objViewRelaTabENT.RegionId = objViewRelaTabENS.RegionId; //区域Id
objViewRelaTabENT.InOutTypeId = objViewRelaTabENS.InOutTypeId; //INOUT类型ID
objViewRelaTabENT.ViewTabTypeId = objViewRelaTabENS.ViewTabTypeId; //界面表类型码
objViewRelaTabENT.TabId = objViewRelaTabENS.TabId; //表ID
objViewRelaTabENT.TabFunction = objViewRelaTabENS.TabFunction; //表功能说明
objViewRelaTabENT.PrjId = objViewRelaTabENS.PrjId; //工程Id
objViewRelaTabENT.UpdDate = objViewRelaTabENS.UpdDate; //修改日期
objViewRelaTabENT.UpdUser = objViewRelaTabENS.UpdUser; //修改者
objViewRelaTabENT.Memo = objViewRelaTabENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewRelaTabEN objViewRelaTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewRelaTabEN.ViewId, conViewRelaTab.ViewId);
clsCheckSql.CheckFieldNotNull(objViewRelaTabEN.RegionId, conViewRelaTab.RegionId);
clsCheckSql.CheckFieldNotNull(objViewRelaTabEN.InOutTypeId, conViewRelaTab.InOutTypeId);
clsCheckSql.CheckFieldNotNull(objViewRelaTabEN.ViewTabTypeId, conViewRelaTab.ViewTabTypeId);
clsCheckSql.CheckFieldNotNull(objViewRelaTabEN.TabId, conViewRelaTab.TabId);
clsCheckSql.CheckFieldNotNull(objViewRelaTabEN.PrjId, conViewRelaTab.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRelaTabEN.ViewId, 8, conViewRelaTab.ViewId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.RegionId, 10, conViewRelaTab.RegionId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.InOutTypeId, 2, conViewRelaTab.InOutTypeId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.ViewTabTypeId, 4, conViewRelaTab.ViewTabTypeId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.TabId, 8, conViewRelaTab.TabId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.TabFunction, 500, conViewRelaTab.TabFunction);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.PrjId, 4, conViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.UpdDate, 20, conViewRelaTab.UpdDate);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.UpdUser, 20, conViewRelaTab.UpdUser);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.Memo, 1000, conViewRelaTab.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objViewRelaTabEN.ViewId, 8, conViewRelaTab.ViewId);
clsCheckSql.CheckFieldForeignKey(objViewRelaTabEN.TabId, 8, conViewRelaTab.TabId);
 objViewRelaTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewRelaTabEN objViewRelaTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRelaTabEN.ViewId, 8, conViewRelaTab.ViewId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.RegionId, 10, conViewRelaTab.RegionId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.InOutTypeId, 2, conViewRelaTab.InOutTypeId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.ViewTabTypeId, 4, conViewRelaTab.ViewTabTypeId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.TabId, 8, conViewRelaTab.TabId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.TabFunction, 500, conViewRelaTab.TabFunction);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.PrjId, 4, conViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.UpdDate, 20, conViewRelaTab.UpdDate);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.UpdUser, 20, conViewRelaTab.UpdUser);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.Memo, 1000, conViewRelaTab.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewRelaTabEN.ViewId, 8, conViewRelaTab.ViewId);
clsCheckSql.CheckFieldForeignKey(objViewRelaTabEN.TabId, 8, conViewRelaTab.TabId);
 objViewRelaTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewRelaTabEN objViewRelaTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRelaTabEN.ViewId, 8, conViewRelaTab.ViewId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.RegionId, 10, conViewRelaTab.RegionId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.InOutTypeId, 2, conViewRelaTab.InOutTypeId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.ViewTabTypeId, 4, conViewRelaTab.ViewTabTypeId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.TabId, 8, conViewRelaTab.TabId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.TabFunction, 500, conViewRelaTab.TabFunction);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.PrjId, 4, conViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.UpdDate, 20, conViewRelaTab.UpdDate);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.UpdUser, 20, conViewRelaTab.UpdUser);
clsCheckSql.CheckFieldLen(objViewRelaTabEN.Memo, 1000, conViewRelaTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.ViewId, conViewRelaTab.ViewId);
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.RegionId, conViewRelaTab.RegionId);
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.InOutTypeId, conViewRelaTab.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.ViewTabTypeId, conViewRelaTab.ViewTabTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.TabId, conViewRelaTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.TabFunction, conViewRelaTab.TabFunction);
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.PrjId, conViewRelaTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.UpdDate, conViewRelaTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.UpdUser, conViewRelaTab.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objViewRelaTabEN.Memo, conViewRelaTab.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewRelaTabEN.ViewId, 8, conViewRelaTab.ViewId);
clsCheckSql.CheckFieldForeignKey(objViewRelaTabEN.TabId, 8, conViewRelaTab.TabId);
 objViewRelaTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewRelaTab(界面相关表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewRelaTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewRelaTabEN objViewRelaTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRelaTabEN.ViewId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objViewRelaTabEN.TabId);
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewRelaTabEN._CurrTabName);
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewRelaTabEN._CurrTabName, strCondition);
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
 objSQL = clsViewRelaTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}