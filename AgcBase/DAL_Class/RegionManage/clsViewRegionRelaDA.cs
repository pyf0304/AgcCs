
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionRelaDA
 表名:ViewRegionRela(00050573)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// 界面区域关系(ViewRegionRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewRegionRelaDA : clsCommBase4DA
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
 return clsViewRegionRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewRegionRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewRegionRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewRegionRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewRegionRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewRegionRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetDataTable_ViewRegionRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewRegionRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewRegionRela.* " + 
$"from ViewRegionRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewRegionRela.mId not in " + 
$"(Select top {intTop_In} ViewRegionRela.mId from ViewRegionRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionRela where {1} and mId not in (Select top {2} mId from ViewRegionRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionRela where {1} and mId not in (Select top {3} mId from ViewRegionRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewRegionRela.* " + 
$"from ViewRegionRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewRegionRela.mId not in " + 
$"(Select top {intTop_In} ViewRegionRela.mId from ViewRegionRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionRela where {1} and mId not in (Select top {2} mId from ViewRegionRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionRela where {1} and mId not in (Select top {3} mId from ViewRegionRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewRegionRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewRegionRelaDA:GetObjLst)", objException.Message));
}
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = TransNullToInt(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = TransNullToBool(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = TransNullToBool(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewRegionRelaDA: GetObjLst)", objException.Message));
}
objViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewRegionRelaEN);
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
public List<clsViewRegionRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewRegionRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = TransNullToInt(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = TransNullToBool(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = TransNullToBool(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewRegionRelaDA: GetObjLst)", objException.Message));
}
objViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewRegionRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewRegionRela(ref clsViewRegionRelaEN objViewRegionRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where mId = " + ""+ objViewRegionRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewRegionRelaEN.mId = TransNullToInt(objDT.Rows[0][conViewRegionRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewRegionRelaEN.RegionId = objDT.Rows[0][conViewRegionRela.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objViewRegionRelaEN.ViewId = objDT.Rows[0][conViewRegionRela.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewRegionRelaEN.InUse = TransNullToBool(objDT.Rows[0][conViewRegionRela.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objViewRegionRelaEN.IsDisp = TransNullToBool(objDT.Rows[0][conViewRegionRela.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objViewRegionRelaEN.PrjId = objDT.Rows[0][conViewRegionRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewRegionRelaEN.UpdUser = objDT.Rows[0][conViewRegionRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionRelaEN.UpdDate = objDT.Rows[0][conViewRegionRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionRelaEN.Memo = objDT.Rows[0][conViewRegionRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewRegionRelaDA: GetViewRegionRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewRegionRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
 objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewRegionRelaDA: GetObjBymId)", objException.Message));
}
return objViewRegionRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewRegionRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN()
{
mId = TransNullToInt(objRow[conViewRegionRela.mId].ToString().Trim()), //mId
RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(), //区域Id
ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(), //界面Id
InUse = TransNullToBool(objRow[conViewRegionRela.InUse].ToString().Trim()), //是否在用
IsDisp = TransNullToBool(objRow[conViewRegionRela.IsDisp].ToString().Trim()), //是否显示
PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim() //说明
};
objViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRegionRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewRegionRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewRegionRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = TransNullToInt(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = TransNullToBool(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = TransNullToBool(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewRegionRelaDA: GetObjByDataRowViewRegionRela)", objException.Message));
}
objViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRegionRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewRegionRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = TransNullToInt(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = TransNullToBool(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = TransNullToBool(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewRegionRelaDA: GetObjByDataRow)", objException.Message));
}
objViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRegionRelaEN;
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
objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewRegionRelaEN._CurrTabName, conViewRegionRela.mId, 8, "");
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
objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewRegionRelaEN._CurrTabName, conViewRegionRela.mId, 8, strPrefix);
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ViewRegionRela where " + strCondition;
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ViewRegionRela where " + strCondition;
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewRegionRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewRegionRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewRegionRela", strCondition))
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
objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewRegionRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewRegionRelaEN objViewRegionRelaEN)
 {
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewRegionRela");
objRow = objDS.Tables["ViewRegionRela"].NewRow();
objRow[conViewRegionRela.RegionId] = objViewRegionRelaEN.RegionId; //区域Id
objRow[conViewRegionRela.ViewId] = objViewRegionRelaEN.ViewId; //界面Id
objRow[conViewRegionRela.InUse] = objViewRegionRelaEN.InUse; //是否在用
objRow[conViewRegionRela.IsDisp] = objViewRegionRelaEN.IsDisp; //是否显示
objRow[conViewRegionRela.PrjId] = objViewRegionRelaEN.PrjId; //工程Id
 if (objViewRegionRelaEN.UpdUser !=  "")
 {
objRow[conViewRegionRela.UpdUser] = objViewRegionRelaEN.UpdUser; //修改者
 }
 if (objViewRegionRelaEN.UpdDate !=  "")
 {
objRow[conViewRegionRela.UpdDate] = objViewRegionRelaEN.UpdDate; //修改日期
 }
 if (objViewRegionRelaEN.Memo !=  "")
 {
objRow[conViewRegionRela.Memo] = objViewRegionRelaEN.Memo; //说明
 }
objDS.Tables[clsViewRegionRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewRegionRelaEN._CurrTabName);
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
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewRegionRelaEN objViewRegionRelaEN)
{
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewRegionRelaEN.RegionId  ==  "")
 {
 objViewRegionRelaEN.RegionId = null;
 }
 if (objViewRegionRelaEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.RegionId);
 var strRegionId = objViewRegionRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionRelaEN.ViewId  ==  "")
 {
 objViewRegionRelaEN.ViewId = null;
 }
 if (objViewRegionRelaEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.ViewId);
 var strViewId = objViewRegionRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 arrFieldListForInsert.Add(conViewRegionRela.InUse);
 arrValueListForInsert.Add("'" + (objViewRegionRelaEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewRegionRela.IsDisp);
 arrValueListForInsert.Add("'" + (objViewRegionRelaEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objViewRegionRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.PrjId);
 var strPrjId = objViewRegionRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRegionRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.UpdUser);
 var strUpdUser = objViewRegionRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.UpdDate);
 var strUpdDate = objViewRegionRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.Memo);
 var strMemo = objViewRegionRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegionRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewRegionRelaEN objViewRegionRelaEN)
{
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewRegionRelaEN.RegionId  ==  "")
 {
 objViewRegionRelaEN.RegionId = null;
 }
 if (objViewRegionRelaEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.RegionId);
 var strRegionId = objViewRegionRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionRelaEN.ViewId  ==  "")
 {
 objViewRegionRelaEN.ViewId = null;
 }
 if (objViewRegionRelaEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.ViewId);
 var strViewId = objViewRegionRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 arrFieldListForInsert.Add(conViewRegionRela.InUse);
 arrValueListForInsert.Add("'" + (objViewRegionRelaEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewRegionRela.IsDisp);
 arrValueListForInsert.Add("'" + (objViewRegionRelaEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objViewRegionRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.PrjId);
 var strPrjId = objViewRegionRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRegionRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.UpdUser);
 var strUpdUser = objViewRegionRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.UpdDate);
 var strUpdDate = objViewRegionRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.Memo);
 var strMemo = objViewRegionRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegionRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewRegionRelaEN objViewRegionRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewRegionRelaEN.RegionId  ==  "")
 {
 objViewRegionRelaEN.RegionId = null;
 }
 if (objViewRegionRelaEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.RegionId);
 var strRegionId = objViewRegionRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionRelaEN.ViewId  ==  "")
 {
 objViewRegionRelaEN.ViewId = null;
 }
 if (objViewRegionRelaEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.ViewId);
 var strViewId = objViewRegionRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 arrFieldListForInsert.Add(conViewRegionRela.InUse);
 arrValueListForInsert.Add("'" + (objViewRegionRelaEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewRegionRela.IsDisp);
 arrValueListForInsert.Add("'" + (objViewRegionRelaEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objViewRegionRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.PrjId);
 var strPrjId = objViewRegionRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRegionRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.UpdUser);
 var strUpdUser = objViewRegionRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.UpdDate);
 var strUpdDate = objViewRegionRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.Memo);
 var strMemo = objViewRegionRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegionRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewRegionRelaEN objViewRegionRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewRegionRelaEN.RegionId  ==  "")
 {
 objViewRegionRelaEN.RegionId = null;
 }
 if (objViewRegionRelaEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.RegionId);
 var strRegionId = objViewRegionRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionRelaEN.ViewId  ==  "")
 {
 objViewRegionRelaEN.ViewId = null;
 }
 if (objViewRegionRelaEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.ViewId);
 var strViewId = objViewRegionRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 arrFieldListForInsert.Add(conViewRegionRela.InUse);
 arrValueListForInsert.Add("'" + (objViewRegionRelaEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewRegionRela.IsDisp);
 arrValueListForInsert.Add("'" + (objViewRegionRelaEN.IsDisp  ==  false ? "0" : "1") + "'");
 
 if (objViewRegionRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.PrjId);
 var strPrjId = objViewRegionRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRegionRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.UpdUser);
 var strUpdUser = objViewRegionRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.UpdDate);
 var strUpdDate = objViewRegionRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionRela.Memo);
 var strMemo = objViewRegionRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegionRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewRegionRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewRegionRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conViewRegionRela.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewRegionRelaEN._CurrTabName ].NewRow();
objRow[conViewRegionRela.RegionId] = oRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objRow[conViewRegionRela.ViewId] = oRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objRow[conViewRegionRela.InUse] = oRow[conViewRegionRela.InUse].ToString().Trim(); //是否在用
objRow[conViewRegionRela.IsDisp] = oRow[conViewRegionRela.IsDisp].ToString().Trim(); //是否显示
objRow[conViewRegionRela.PrjId] = oRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objRow[conViewRegionRela.UpdUser] = oRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objRow[conViewRegionRela.UpdDate] = oRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objRow[conViewRegionRela.Memo] = oRow[conViewRegionRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsViewRegionRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewRegionRelaEN._CurrTabName);
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
 /// <param name = "objViewRegionRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewRegionRelaEN objViewRegionRelaEN)
{
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionRela where mId = " + ""+ objViewRegionRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewRegionRelaEN._CurrTabName);
if (objDS.Tables[clsViewRegionRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objViewRegionRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsViewRegionRelaEN._CurrTabName].Rows[0];
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.RegionId))
 {
objRow[conViewRegionRela.RegionId] = objViewRegionRelaEN.RegionId; //区域Id
 }
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.ViewId))
 {
objRow[conViewRegionRela.ViewId] = objViewRegionRelaEN.ViewId; //界面Id
 }
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.InUse))
 {
objRow[conViewRegionRela.InUse] = objViewRegionRelaEN.InUse; //是否在用
 }
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.IsDisp))
 {
objRow[conViewRegionRela.IsDisp] = objViewRegionRelaEN.IsDisp; //是否显示
 }
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.PrjId))
 {
objRow[conViewRegionRela.PrjId] = objViewRegionRelaEN.PrjId; //工程Id
 }
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdUser))
 {
objRow[conViewRegionRela.UpdUser] = objViewRegionRelaEN.UpdUser; //修改者
 }
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdDate))
 {
objRow[conViewRegionRela.UpdDate] = objViewRegionRelaEN.UpdDate; //修改日期
 }
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.Memo))
 {
objRow[conViewRegionRela.Memo] = objViewRegionRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsViewRegionRelaEN._CurrTabName);
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
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewRegionRelaEN objViewRegionRelaEN)
{
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewRegionRela Set ");
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.RegionId))
 {
 if (objViewRegionRelaEN.RegionId  ==  "")
 {
 objViewRegionRelaEN.RegionId = null;
 }
 if (objViewRegionRelaEN.RegionId !=  null)
 {
 var strRegionId = objViewRegionRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conViewRegionRela.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.RegionId); //区域Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.ViewId))
 {
 if (objViewRegionRelaEN.ViewId  ==  "")
 {
 objViewRegionRelaEN.ViewId = null;
 }
 if (objViewRegionRelaEN.ViewId !=  null)
 {
 var strViewId = objViewRegionRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conViewRegionRela.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.ViewId); //界面Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewRegionRelaEN.InUse == true?"1":"0", conViewRegionRela.InUse); //是否在用
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.IsDisp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewRegionRelaEN.IsDisp == true?"1":"0", conViewRegionRela.IsDisp); //是否显示
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.PrjId))
 {
 if (objViewRegionRelaEN.PrjId !=  null)
 {
 var strPrjId = objViewRegionRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewRegionRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.PrjId); //工程Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdUser))
 {
 if (objViewRegionRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewRegionRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.UpdUser); //修改者
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdDate))
 {
 if (objViewRegionRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewRegionRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.UpdDate); //修改日期
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.Memo))
 {
 if (objViewRegionRelaEN.Memo !=  null)
 {
 var strMemo = objViewRegionRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewRegionRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewRegionRelaEN.mId); 
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
 /// <param name = "objViewRegionRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewRegionRelaEN objViewRegionRelaEN, string strCondition)
{
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRegionRela Set ");
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.RegionId))
 {
 if (objViewRegionRelaEN.RegionId  ==  "")
 {
 objViewRegionRelaEN.RegionId = null;
 }
 if (objViewRegionRelaEN.RegionId !=  null)
 {
 var strRegionId = objViewRegionRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.ViewId))
 {
 if (objViewRegionRelaEN.ViewId  ==  "")
 {
 objViewRegionRelaEN.ViewId = null;
 }
 if (objViewRegionRelaEN.ViewId !=  null)
 {
 var strViewId = objViewRegionRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objViewRegionRelaEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.IsDisp))
 {
 sbSQL.AppendFormat(" IsDisp = '{0}',", objViewRegionRelaEN.IsDisp == true?"1":"0"); //是否显示
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.PrjId))
 {
 if (objViewRegionRelaEN.PrjId !=  null)
 {
 var strPrjId = objViewRegionRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdUser))
 {
 if (objViewRegionRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdDate))
 {
 if (objViewRegionRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.Memo))
 {
 if (objViewRegionRelaEN.Memo !=  null)
 {
 var strMemo = objViewRegionRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewRegionRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewRegionRelaEN objViewRegionRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRegionRela Set ");
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.RegionId))
 {
 if (objViewRegionRelaEN.RegionId  ==  "")
 {
 objViewRegionRelaEN.RegionId = null;
 }
 if (objViewRegionRelaEN.RegionId !=  null)
 {
 var strRegionId = objViewRegionRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.ViewId))
 {
 if (objViewRegionRelaEN.ViewId  ==  "")
 {
 objViewRegionRelaEN.ViewId = null;
 }
 if (objViewRegionRelaEN.ViewId !=  null)
 {
 var strViewId = objViewRegionRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objViewRegionRelaEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.IsDisp))
 {
 sbSQL.AppendFormat(" IsDisp = '{0}',", objViewRegionRelaEN.IsDisp == true?"1":"0"); //是否显示
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.PrjId))
 {
 if (objViewRegionRelaEN.PrjId !=  null)
 {
 var strPrjId = objViewRegionRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdUser))
 {
 if (objViewRegionRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdDate))
 {
 if (objViewRegionRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.Memo))
 {
 if (objViewRegionRelaEN.Memo !=  null)
 {
 var strMemo = objViewRegionRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewRegionRelaEN objViewRegionRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRegionRela Set ");
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.RegionId))
 {
 if (objViewRegionRelaEN.RegionId  ==  "")
 {
 objViewRegionRelaEN.RegionId = null;
 }
 if (objViewRegionRelaEN.RegionId !=  null)
 {
 var strRegionId = objViewRegionRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conViewRegionRela.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.RegionId); //区域Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.ViewId))
 {
 if (objViewRegionRelaEN.ViewId  ==  "")
 {
 objViewRegionRelaEN.ViewId = null;
 }
 if (objViewRegionRelaEN.ViewId !=  null)
 {
 var strViewId = objViewRegionRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conViewRegionRela.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.ViewId); //界面Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewRegionRelaEN.InUse == true?"1":"0", conViewRegionRela.InUse); //是否在用
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.IsDisp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewRegionRelaEN.IsDisp == true?"1":"0", conViewRegionRela.IsDisp); //是否显示
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.PrjId))
 {
 if (objViewRegionRelaEN.PrjId !=  null)
 {
 var strPrjId = objViewRegionRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewRegionRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.PrjId); //工程Id
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdUser))
 {
 if (objViewRegionRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewRegionRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.UpdUser); //修改者
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.UpdDate))
 {
 if (objViewRegionRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewRegionRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.UpdDate); //修改日期
 }
 }
 
 if (objViewRegionRelaEN.IsUpdated(conViewRegionRela.Memo))
 {
 if (objViewRegionRelaEN.Memo !=  null)
 {
 var strMemo = objViewRegionRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewRegionRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewRegionRelaEN.mId); 
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ViewRegionRela_Delete", values);
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
//删除ViewRegionRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRegionRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewRegionRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
//删除ViewRegionRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRegionRela where mId in (" + strKeyList + ")";
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
//删除ViewRegionRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRegionRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewRegionRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: DelViewRegionRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewRegionRela where " + strCondition ;
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
public bool DelViewRegionRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewRegionRelaDA: DelViewRegionRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewRegionRela where " + strCondition ;
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
 /// <param name = "objViewRegionRelaENS">源对象</param>
 /// <param name = "objViewRegionRelaENT">目标对象</param>
public void CopyTo(clsViewRegionRelaEN objViewRegionRelaENS, clsViewRegionRelaEN objViewRegionRelaENT)
{
objViewRegionRelaENT.mId = objViewRegionRelaENS.mId; //mId
objViewRegionRelaENT.RegionId = objViewRegionRelaENS.RegionId; //区域Id
objViewRegionRelaENT.ViewId = objViewRegionRelaENS.ViewId; //界面Id
objViewRegionRelaENT.InUse = objViewRegionRelaENS.InUse; //是否在用
objViewRegionRelaENT.IsDisp = objViewRegionRelaENS.IsDisp; //是否显示
objViewRegionRelaENT.PrjId = objViewRegionRelaENS.PrjId; //工程Id
objViewRegionRelaENT.UpdUser = objViewRegionRelaENS.UpdUser; //修改者
objViewRegionRelaENT.UpdDate = objViewRegionRelaENS.UpdDate; //修改日期
objViewRegionRelaENT.Memo = objViewRegionRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewRegionRelaEN objViewRegionRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewRegionRelaEN.RegionId, conViewRegionRela.RegionId);
clsCheckSql.CheckFieldNotNull(objViewRegionRelaEN.ViewId, conViewRegionRela.ViewId);
clsCheckSql.CheckFieldNotNull(objViewRegionRelaEN.IsDisp, conViewRegionRela.IsDisp);
clsCheckSql.CheckFieldNotNull(objViewRegionRelaEN.PrjId, conViewRegionRela.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.RegionId, 10, conViewRegionRela.RegionId);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.ViewId, 8, conViewRegionRela.ViewId);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.PrjId, 4, conViewRegionRela.PrjId);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.UpdUser, 20, conViewRegionRela.UpdUser);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.UpdDate, 20, conViewRegionRela.UpdDate);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.Memo, 1000, conViewRegionRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objViewRegionRelaEN.RegionId, 10, conViewRegionRela.RegionId);
clsCheckSql.CheckFieldForeignKey(objViewRegionRelaEN.ViewId, 8, conViewRegionRela.ViewId);
 objViewRegionRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewRegionRelaEN objViewRegionRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.RegionId, 10, conViewRegionRela.RegionId);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.ViewId, 8, conViewRegionRela.ViewId);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.PrjId, 4, conViewRegionRela.PrjId);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.UpdUser, 20, conViewRegionRela.UpdUser);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.UpdDate, 20, conViewRegionRela.UpdDate);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.Memo, 1000, conViewRegionRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewRegionRelaEN.RegionId, 10, conViewRegionRela.RegionId);
clsCheckSql.CheckFieldForeignKey(objViewRegionRelaEN.ViewId, 8, conViewRegionRela.ViewId);
 objViewRegionRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewRegionRelaEN objViewRegionRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.RegionId, 10, conViewRegionRela.RegionId);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.ViewId, 8, conViewRegionRela.ViewId);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.PrjId, 4, conViewRegionRela.PrjId);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.UpdUser, 20, conViewRegionRela.UpdUser);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.UpdDate, 20, conViewRegionRela.UpdDate);
clsCheckSql.CheckFieldLen(objViewRegionRelaEN.Memo, 1000, conViewRegionRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewRegionRelaEN.RegionId, conViewRegionRela.RegionId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionRelaEN.ViewId, conViewRegionRela.ViewId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionRelaEN.PrjId, conViewRegionRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionRelaEN.UpdUser, conViewRegionRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objViewRegionRelaEN.UpdDate, conViewRegionRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewRegionRelaEN.Memo, conViewRegionRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewRegionRelaEN.RegionId, 10, conViewRegionRela.RegionId);
clsCheckSql.CheckFieldForeignKey(objViewRegionRelaEN.ViewId, 8, conViewRegionRela.ViewId);
 objViewRegionRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewRegionRela(界面区域关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewRegionRelaEN objViewRegionRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRegionRelaEN.ViewId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objViewRegionRelaEN.RegionId);
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewRegionRelaEN._CurrTabName);
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewRegionRelaEN._CurrTabName, strCondition);
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
 objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}