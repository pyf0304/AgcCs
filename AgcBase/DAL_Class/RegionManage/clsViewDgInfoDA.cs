
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewDgInfoDA
 表名:ViewDgInfo(00050012)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 视图Dg(ViewDgInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewDgInfoDA : clsCommBase4DA
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
 return clsViewDgInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewDgInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewDgInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewDgInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewDgInfoEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strViewDgID">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strViewDgID)
{
strViewDgID = strViewDgID.Replace("'", "''");
if (strViewDgID.Length > 10)
{
throw new Exception("(errid:Data000001)在表:ViewDgInfo中,检查关键字,长度不正确!(clsViewDgInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewDgID)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ViewDgInfo中,关键字不能为空 或 null!(clsViewDgInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewDgID);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsViewDgInfoDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewDgInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewDgInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewDgInfoDA: GetDataTable_ViewDgInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewDgInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewDgInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewDgInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewDgInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewDgInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewDgInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewDgInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewDgInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewDgInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewDgInfo.* " + 
$"from ViewDgInfo " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewDgInfo.ViewDgID not in " + 
$"(Select top {intTop_In} ViewDgInfo.ViewDgID from ViewDgInfo " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewDgInfo where {1} and ViewDgID not in (Select top {2} ViewDgID from ViewDgInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewDgInfo where {1} and ViewDgID not in (Select top {3} ViewDgID from ViewDgInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewDgInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewDgInfo.* " + 
$"from ViewDgInfo " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewDgInfo.ViewDgID not in " + 
$"(Select top {intTop_In} ViewDgInfo.ViewDgID from ViewDgInfo " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewDgInfo where {1} and ViewDgID not in (Select top {2} ViewDgID from ViewDgInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewDgInfo where {1} and ViewDgID not in (Select top {3} ViewDgID from ViewDgInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewDgInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewDgInfoDA:GetObjLst)", objException.Message));
}
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = TransNullToBool(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = TransNullToBool(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = TransNullToBool(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = TransNullToBool(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = TransNullToBool(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = TransNullToBool(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = TransNullToBool(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewDgInfoDA: GetObjLst)", objException.Message));
}
objViewDgInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewDgInfoEN);
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
public List<clsViewDgInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewDgInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = TransNullToBool(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = TransNullToBool(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = TransNullToBool(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = TransNullToBool(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = TransNullToBool(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = TransNullToBool(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = TransNullToBool(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewDgInfoDA: GetObjLst)", objException.Message));
}
objViewDgInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewDgInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewDgInfo(ref clsViewDgInfoEN objViewDgInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where ViewDgID = " + "'"+ objViewDgInfoEN.ViewDgID+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewDgInfoEN.ViewDgID = objDT.Rows[0][conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId(字段类型:varchar,字段长度:10,是否可空:False)
 objViewDgInfoEN.ViewDgName = objDT.Rows[0][conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称(字段类型:varchar,字段长度:100,是否可空:False)
 objViewDgInfoEN.ViewId = objDT.Rows[0][conViewDgInfo.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewDgInfoEN.SqlDsId = objDT.Rows[0][conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id(字段类型:varchar,字段长度:8,是否可空:True)
 objViewDgInfoEN.DgStyleId = objDT.Rows[0][conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID(字段类型:varchar,字段长度:4,是否可空:False)
 objViewDgInfoEN.Style = objDT.Rows[0][conViewDgInfo.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objViewDgInfoEN.Runat = objDT.Rows[0][conViewDgInfo.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objViewDgInfoEN.FontSize = objDT.Rows[0][conViewDgInfo.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objViewDgInfoEN.FontName = objDT.Rows[0][conViewDgInfo.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objViewDgInfoEN.Width = TransNullToInt(objDT.Rows[0][conViewDgInfo.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.Height = TransNullToInt(objDT.Rows[0][conViewDgInfo.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.AllowPaging = TransNullToBool(objDT.Rows[0][conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页(字段类型:bit,字段长度:1,是否可空:False)
 objViewDgInfoEN.PageSize = TransNullToInt(objDT.Rows[0][conViewDgInfo.PageSize].ToString().Trim()); //页大小(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.AutoGenerateColumns = TransNullToBool(objDT.Rows[0][conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列(字段类型:bit,字段长度:1,是否可空:False)
 objViewDgInfoEN.AllowSorting = TransNullToBool(objDT.Rows[0][conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序(字段类型:bit,字段长度:1,是否可空:False)
 objViewDgInfoEN.IsRadio = TransNullToBool(objDT.Rows[0][conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsCheck = TransNullToBool(objDT.Rows[0][conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsHaveUpdBtn = TransNullToBool(objDT.Rows[0][conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsHaveDelBtn = TransNullToBool(objDT.Rows[0][conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsHaveDetailBtn = TransNullToBool(objDT.Rows[0][conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsJumpPage = TransNullToBool(objDT.Rows[0][conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsInTab = TransNullToBool(objDT.Rows[0][conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.StyleZindex = TransNullToInt(objDT.Rows[0][conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.StyleLeft = TransNullToInt(objDT.Rows[0][conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.StylePosition = objDT.Rows[0][conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objViewDgInfoEN.StyleTop = TransNullToInt(objDT.Rows[0][conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.SqlDsTypeId = objDT.Rows[0][conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewDgInfoDA: GetViewDgInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewDgID">表关键字</param>
 /// <returns>表对象</returns>
public clsViewDgInfoEN GetObjByViewDgID(string strViewDgID)
{
CheckPrimaryKey(strViewDgID);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where ViewDgID = " + "'"+ strViewDgID+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
 objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId(字段类型:varchar,字段长度:10,是否可空:False)
 objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称(字段类型:varchar,字段长度:100,是否可空:False)
 objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id(字段类型:varchar,字段长度:8,是否可空:True)
 objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID(字段类型:varchar,字段长度:4,是否可空:False)
 objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页(字段类型:bit,字段长度:1,是否可空:False)
 objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列(字段类型:bit,字段长度:1,是否可空:False)
 objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序(字段类型:bit,字段长度:1,是否可空:False)
 objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中(字段类型:bit,字段长度:1,是否可空:True)
 objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
 objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewDgInfoDA: GetObjByViewDgID)", objException.Message));
}
return objViewDgInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewDgInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewDgInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN()
{
ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(), //界面DgId
ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(), //界面Dg名称
ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(), //界面Id
SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(), //数据源表/视图Id
DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(), //DG模式ID
Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(), //类型
Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(), //运行在
FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(), //字号
FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(), //字体
Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Width].ToString().Trim()), //宽
Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Height].ToString().Trim()), //高度
AllowPaging = TransNullToBool(objRow[conViewDgInfo.AllowPaging].ToString().Trim()), //允许分页
PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.PageSize].ToString().Trim()), //页大小
AutoGenerateColumns = TransNullToBool(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()), //自动生成列
AllowSorting = TransNullToBool(objRow[conViewDgInfo.AllowSorting].ToString().Trim()), //允许排序
IsRadio = TransNullToBool(objRow[conViewDgInfo.IsRadio].ToString().Trim()), //是否单选框
IsCheck = TransNullToBool(objRow[conViewDgInfo.IsCheck].ToString().Trim()), //是否复选框
IsHaveUpdBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()), //是否有修改按钮
IsHaveDelBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()), //是否有删除按钮
IsHaveDetailBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()), //是否有详细按钮
IsJumpPage = TransNullToBool(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()), //是否跳页
IsInTab = TransNullToBool(objRow[conViewDgInfo.IsInTab].ToString().Trim()), //是否生成DG在表中
StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleZindex].ToString().Trim()), //Style_Zindex
StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleLeft].ToString().Trim()), //Style_Left
StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(), //Style_Position
StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleTop].ToString().Trim()), //Style_Top
SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim() //数据源类型Id
};
objViewDgInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewDgInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewDgInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewDgInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = TransNullToBool(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = TransNullToBool(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = TransNullToBool(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = TransNullToBool(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = TransNullToBool(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = TransNullToBool(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = TransNullToBool(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewDgInfoDA: GetObjByDataRowViewDgInfo)", objException.Message));
}
objViewDgInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewDgInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewDgInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = TransNullToBool(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = TransNullToBool(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = TransNullToBool(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = TransNullToBool(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = TransNullToBool(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = TransNullToBool(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = TransNullToBool(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = TransNullToBool(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewDgInfoDA: GetObjByDataRow)", objException.Message));
}
objViewDgInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewDgInfoEN;
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
objSQL = clsViewDgInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewDgInfoEN._CurrTabName, conViewDgInfo.ViewDgID, 10, "");
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
objSQL = clsViewDgInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewDgInfoEN._CurrTabName, conViewDgInfo.ViewDgID, 10, strPrefix);
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
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewDgID from ViewDgInfo where " + strCondition;
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
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewDgID from ViewDgInfo where " + strCondition;
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
 /// <param name = "strViewDgID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strViewDgID)
{
CheckPrimaryKey(strViewDgID);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewDgInfo", "ViewDgID = " + "'"+ strViewDgID+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewDgInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewDgInfo", strCondition))
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
objSQL = clsViewDgInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewDgInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewDgInfoEN objViewDgInfoEN)
 {
 if (objViewDgInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewDgInfoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewDgInfo");
objRow = objDS.Tables["ViewDgInfo"].NewRow();
objRow[conViewDgInfo.ViewDgID] = objViewDgInfoEN.ViewDgID; //界面DgId
objRow[conViewDgInfo.ViewDgName] = objViewDgInfoEN.ViewDgName; //界面Dg名称
objRow[conViewDgInfo.ViewId] = objViewDgInfoEN.ViewId; //界面Id
 if (objViewDgInfoEN.SqlDsId !=  "")
 {
objRow[conViewDgInfo.SqlDsId] = objViewDgInfoEN.SqlDsId; //数据源表/视图Id
 }
objRow[conViewDgInfo.DgStyleId] = objViewDgInfoEN.DgStyleId; //DG模式ID
 if (objViewDgInfoEN.Style !=  "")
 {
objRow[conViewDgInfo.Style] = objViewDgInfoEN.Style; //类型
 }
 if (objViewDgInfoEN.Runat !=  "")
 {
objRow[conViewDgInfo.Runat] = objViewDgInfoEN.Runat; //运行在
 }
 if (objViewDgInfoEN.FontSize !=  "")
 {
objRow[conViewDgInfo.FontSize] = objViewDgInfoEN.FontSize; //字号
 }
 if (objViewDgInfoEN.FontName !=  "")
 {
objRow[conViewDgInfo.FontName] = objViewDgInfoEN.FontName; //字体
 }
objRow[conViewDgInfo.Width] = objViewDgInfoEN.Width; //宽
objRow[conViewDgInfo.Height] = objViewDgInfoEN.Height; //高度
objRow[conViewDgInfo.AllowPaging] = objViewDgInfoEN.AllowPaging; //允许分页
objRow[conViewDgInfo.PageSize] = objViewDgInfoEN.PageSize; //页大小
objRow[conViewDgInfo.AutoGenerateColumns] = objViewDgInfoEN.AutoGenerateColumns; //自动生成列
objRow[conViewDgInfo.AllowSorting] = objViewDgInfoEN.AllowSorting; //允许排序
objRow[conViewDgInfo.IsRadio] = objViewDgInfoEN.IsRadio; //是否单选框
objRow[conViewDgInfo.IsCheck] = objViewDgInfoEN.IsCheck; //是否复选框
objRow[conViewDgInfo.IsHaveUpdBtn] = objViewDgInfoEN.IsHaveUpdBtn; //是否有修改按钮
objRow[conViewDgInfo.IsHaveDelBtn] = objViewDgInfoEN.IsHaveDelBtn; //是否有删除按钮
objRow[conViewDgInfo.IsHaveDetailBtn] = objViewDgInfoEN.IsHaveDetailBtn; //是否有详细按钮
objRow[conViewDgInfo.IsJumpPage] = objViewDgInfoEN.IsJumpPage; //是否跳页
objRow[conViewDgInfo.IsInTab] = objViewDgInfoEN.IsInTab; //是否生成DG在表中
objRow[conViewDgInfo.StyleZindex] = objViewDgInfoEN.StyleZindex; //Style_Zindex
objRow[conViewDgInfo.StyleLeft] = objViewDgInfoEN.StyleLeft; //Style_Left
 if (objViewDgInfoEN.StylePosition !=  "")
 {
objRow[conViewDgInfo.StylePosition] = objViewDgInfoEN.StylePosition; //Style_Position
 }
objRow[conViewDgInfo.StyleTop] = objViewDgInfoEN.StyleTop; //Style_Top
objRow[conViewDgInfo.SqlDsTypeId] = objViewDgInfoEN.SqlDsTypeId; //数据源类型Id
objDS.Tables[clsViewDgInfoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewDgInfoEN._CurrTabName);
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewDgInfoEN objViewDgInfoEN)
{
 if (objViewDgInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewDgInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewDgInfoEN.ViewDgID !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.ViewDgID);
 var strViewDgID = objViewDgInfoEN.ViewDgID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDgID + "'");
 }
 
 if (objViewDgInfoEN.ViewDgName !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.ViewDgName);
 var strViewDgName = objViewDgInfoEN.ViewDgName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDgName + "'");
 }
 
 if (objViewDgInfoEN.ViewId  ==  "")
 {
 objViewDgInfoEN.ViewId = null;
 }
 if (objViewDgInfoEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.ViewId);
 var strViewId = objViewDgInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewDgInfoEN.SqlDsId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.SqlDsId);
 var strSqlDsId = objViewDgInfoEN.SqlDsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsId + "'");
 }
 
 if (objViewDgInfoEN.DgStyleId  ==  "")
 {
 objViewDgInfoEN.DgStyleId = null;
 }
 if (objViewDgInfoEN.DgStyleId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.DgStyleId);
 var strDgStyleId = objViewDgInfoEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleId + "'");
 }
 
 if (objViewDgInfoEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Style);
 var strStyle = objViewDgInfoEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objViewDgInfoEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Runat);
 var strRunat = objViewDgInfoEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objViewDgInfoEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.FontSize);
 var strFontSize = objViewDgInfoEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objViewDgInfoEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.FontName);
 var strFontName = objViewDgInfoEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objViewDgInfoEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Width);
 arrValueListForInsert.Add(objViewDgInfoEN.Width.ToString());
 }
 
 if (objViewDgInfoEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Height);
 arrValueListForInsert.Add(objViewDgInfoEN.Height.ToString());
 }
 
 arrFieldListForInsert.Add(conViewDgInfo.AllowPaging);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.AllowPaging  ==  false ? "0" : "1") + "'");
 
 if (objViewDgInfoEN.PageSize !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.PageSize);
 arrValueListForInsert.Add(objViewDgInfoEN.PageSize.ToString());
 }
 
 arrFieldListForInsert.Add(conViewDgInfo.AutoGenerateColumns);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.AutoGenerateColumns  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.AllowSorting);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.AllowSorting  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsRadio);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsRadio  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsCheck);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsCheck  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsHaveUpdBtn);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsHaveUpdBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsHaveDelBtn);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsHaveDelBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsHaveDetailBtn);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsHaveDetailBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsJumpPage);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsJumpPage  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsInTab);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsInTab  ==  false ? "0" : "1") + "'");
 
 if (objViewDgInfoEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StyleZindex);
 arrValueListForInsert.Add(objViewDgInfoEN.StyleZindex.ToString());
 }
 
 if (objViewDgInfoEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StyleLeft);
 arrValueListForInsert.Add(objViewDgInfoEN.StyleLeft.ToString());
 }
 
 if (objViewDgInfoEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StylePosition);
 var strStylePosition = objViewDgInfoEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objViewDgInfoEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StyleTop);
 arrValueListForInsert.Add(objViewDgInfoEN.StyleTop.ToString());
 }
 
 if (objViewDgInfoEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.SqlDsTypeId);
 var strSqlDsTypeId = objViewDgInfoEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewDgInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewDgInfoEN objViewDgInfoEN)
{
 if (objViewDgInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewDgInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewDgInfoEN.ViewDgID !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.ViewDgID);
 var strViewDgID = objViewDgInfoEN.ViewDgID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDgID + "'");
 }
 
 if (objViewDgInfoEN.ViewDgName !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.ViewDgName);
 var strViewDgName = objViewDgInfoEN.ViewDgName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDgName + "'");
 }
 
 if (objViewDgInfoEN.ViewId  ==  "")
 {
 objViewDgInfoEN.ViewId = null;
 }
 if (objViewDgInfoEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.ViewId);
 var strViewId = objViewDgInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewDgInfoEN.SqlDsId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.SqlDsId);
 var strSqlDsId = objViewDgInfoEN.SqlDsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsId + "'");
 }
 
 if (objViewDgInfoEN.DgStyleId  ==  "")
 {
 objViewDgInfoEN.DgStyleId = null;
 }
 if (objViewDgInfoEN.DgStyleId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.DgStyleId);
 var strDgStyleId = objViewDgInfoEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleId + "'");
 }
 
 if (objViewDgInfoEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Style);
 var strStyle = objViewDgInfoEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objViewDgInfoEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Runat);
 var strRunat = objViewDgInfoEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objViewDgInfoEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.FontSize);
 var strFontSize = objViewDgInfoEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objViewDgInfoEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.FontName);
 var strFontName = objViewDgInfoEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objViewDgInfoEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Width);
 arrValueListForInsert.Add(objViewDgInfoEN.Width.ToString());
 }
 
 if (objViewDgInfoEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Height);
 arrValueListForInsert.Add(objViewDgInfoEN.Height.ToString());
 }
 
 arrFieldListForInsert.Add(conViewDgInfo.AllowPaging);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.AllowPaging  ==  false ? "0" : "1") + "'");
 
 if (objViewDgInfoEN.PageSize !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.PageSize);
 arrValueListForInsert.Add(objViewDgInfoEN.PageSize.ToString());
 }
 
 arrFieldListForInsert.Add(conViewDgInfo.AutoGenerateColumns);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.AutoGenerateColumns  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.AllowSorting);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.AllowSorting  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsRadio);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsRadio  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsCheck);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsCheck  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsHaveUpdBtn);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsHaveUpdBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsHaveDelBtn);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsHaveDelBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsHaveDetailBtn);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsHaveDetailBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsJumpPage);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsJumpPage  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsInTab);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsInTab  ==  false ? "0" : "1") + "'");
 
 if (objViewDgInfoEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StyleZindex);
 arrValueListForInsert.Add(objViewDgInfoEN.StyleZindex.ToString());
 }
 
 if (objViewDgInfoEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StyleLeft);
 arrValueListForInsert.Add(objViewDgInfoEN.StyleLeft.ToString());
 }
 
 if (objViewDgInfoEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StylePosition);
 var strStylePosition = objViewDgInfoEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objViewDgInfoEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StyleTop);
 arrValueListForInsert.Add(objViewDgInfoEN.StyleTop.ToString());
 }
 
 if (objViewDgInfoEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.SqlDsTypeId);
 var strSqlDsTypeId = objViewDgInfoEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewDgInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objViewDgInfoEN.ViewDgID;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewDgInfoEN objViewDgInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objViewDgInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewDgInfoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewDgInfoEN.ViewDgID !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.ViewDgID);
 var strViewDgID = objViewDgInfoEN.ViewDgID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDgID + "'");
 }
 
 if (objViewDgInfoEN.ViewDgName !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.ViewDgName);
 var strViewDgName = objViewDgInfoEN.ViewDgName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDgName + "'");
 }
 
 if (objViewDgInfoEN.ViewId  ==  "")
 {
 objViewDgInfoEN.ViewId = null;
 }
 if (objViewDgInfoEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.ViewId);
 var strViewId = objViewDgInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewDgInfoEN.SqlDsId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.SqlDsId);
 var strSqlDsId = objViewDgInfoEN.SqlDsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsId + "'");
 }
 
 if (objViewDgInfoEN.DgStyleId  ==  "")
 {
 objViewDgInfoEN.DgStyleId = null;
 }
 if (objViewDgInfoEN.DgStyleId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.DgStyleId);
 var strDgStyleId = objViewDgInfoEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleId + "'");
 }
 
 if (objViewDgInfoEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Style);
 var strStyle = objViewDgInfoEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objViewDgInfoEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Runat);
 var strRunat = objViewDgInfoEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objViewDgInfoEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.FontSize);
 var strFontSize = objViewDgInfoEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objViewDgInfoEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.FontName);
 var strFontName = objViewDgInfoEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objViewDgInfoEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Width);
 arrValueListForInsert.Add(objViewDgInfoEN.Width.ToString());
 }
 
 if (objViewDgInfoEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.Height);
 arrValueListForInsert.Add(objViewDgInfoEN.Height.ToString());
 }
 
 arrFieldListForInsert.Add(conViewDgInfo.AllowPaging);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.AllowPaging  ==  false ? "0" : "1") + "'");
 
 if (objViewDgInfoEN.PageSize !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.PageSize);
 arrValueListForInsert.Add(objViewDgInfoEN.PageSize.ToString());
 }
 
 arrFieldListForInsert.Add(conViewDgInfo.AutoGenerateColumns);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.AutoGenerateColumns  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.AllowSorting);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.AllowSorting  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsRadio);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsRadio  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsCheck);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsCheck  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsHaveUpdBtn);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsHaveUpdBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsHaveDelBtn);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsHaveDelBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsHaveDetailBtn);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsHaveDetailBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsJumpPage);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsJumpPage  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewDgInfo.IsInTab);
 arrValueListForInsert.Add("'" + (objViewDgInfoEN.IsInTab  ==  false ? "0" : "1") + "'");
 
 if (objViewDgInfoEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StyleZindex);
 arrValueListForInsert.Add(objViewDgInfoEN.StyleZindex.ToString());
 }
 
 if (objViewDgInfoEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StyleLeft);
 arrValueListForInsert.Add(objViewDgInfoEN.StyleLeft.ToString());
 }
 
 if (objViewDgInfoEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StylePosition);
 var strStylePosition = objViewDgInfoEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objViewDgInfoEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.StyleTop);
 arrValueListForInsert.Add(objViewDgInfoEN.StyleTop.ToString());
 }
 
 if (objViewDgInfoEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewDgInfo.SqlDsTypeId);
 var strSqlDsTypeId = objViewDgInfoEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewDgInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewDgInfos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where ViewDgID = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewDgInfo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strViewDgID = oRow[conViewDgInfo.ViewDgID].ToString().Trim();
if (IsExist(strViewDgID))
{
 string strResult = "关键字变量值为:" + string.Format("ViewDgID = {0}", strViewDgID) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewDgInfoEN._CurrTabName ].NewRow();
objRow[conViewDgInfo.ViewDgID] = oRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objRow[conViewDgInfo.ViewDgName] = oRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objRow[conViewDgInfo.ViewId] = oRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objRow[conViewDgInfo.SqlDsId] = oRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objRow[conViewDgInfo.DgStyleId] = oRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objRow[conViewDgInfo.Style] = oRow[conViewDgInfo.Style].ToString().Trim(); //类型
objRow[conViewDgInfo.Runat] = oRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objRow[conViewDgInfo.FontSize] = oRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objRow[conViewDgInfo.FontName] = oRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objRow[conViewDgInfo.Width] = oRow[conViewDgInfo.Width].ToString().Trim(); //宽
objRow[conViewDgInfo.Height] = oRow[conViewDgInfo.Height].ToString().Trim(); //高度
objRow[conViewDgInfo.AllowPaging] = oRow[conViewDgInfo.AllowPaging].ToString().Trim(); //允许分页
objRow[conViewDgInfo.PageSize] = oRow[conViewDgInfo.PageSize].ToString().Trim(); //页大小
objRow[conViewDgInfo.AutoGenerateColumns] = oRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim(); //自动生成列
objRow[conViewDgInfo.AllowSorting] = oRow[conViewDgInfo.AllowSorting].ToString().Trim(); //允许排序
objRow[conViewDgInfo.IsRadio] = oRow[conViewDgInfo.IsRadio].ToString().Trim(); //是否单选框
objRow[conViewDgInfo.IsCheck] = oRow[conViewDgInfo.IsCheck].ToString().Trim(); //是否复选框
objRow[conViewDgInfo.IsHaveUpdBtn] = oRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim(); //是否有修改按钮
objRow[conViewDgInfo.IsHaveDelBtn] = oRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim(); //是否有删除按钮
objRow[conViewDgInfo.IsHaveDetailBtn] = oRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim(); //是否有详细按钮
objRow[conViewDgInfo.IsJumpPage] = oRow[conViewDgInfo.IsJumpPage].ToString().Trim(); //是否跳页
objRow[conViewDgInfo.IsInTab] = oRow[conViewDgInfo.IsInTab].ToString().Trim(); //是否生成DG在表中
objRow[conViewDgInfo.StyleZindex] = oRow[conViewDgInfo.StyleZindex].ToString().Trim(); //Style_Zindex
objRow[conViewDgInfo.StyleLeft] = oRow[conViewDgInfo.StyleLeft].ToString().Trim(); //Style_Left
objRow[conViewDgInfo.StylePosition] = oRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objRow[conViewDgInfo.StyleTop] = oRow[conViewDgInfo.StyleTop].ToString().Trim(); //Style_Top
objRow[conViewDgInfo.SqlDsTypeId] = oRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
 objDS.Tables[clsViewDgInfoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewDgInfoEN._CurrTabName);
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
 /// <param name = "objViewDgInfoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewDgInfoEN objViewDgInfoEN)
{
 if (objViewDgInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewDgInfoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewDgInfo where ViewDgID = " + "'"+ objViewDgInfoEN.ViewDgID+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewDgInfoEN._CurrTabName);
if (objDS.Tables[clsViewDgInfoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ViewDgID = " + "'"+ objViewDgInfoEN.ViewDgID+"'");
return false;
}
objRow = objDS.Tables[clsViewDgInfoEN._CurrTabName].Rows[0];
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewDgID))
 {
objRow[conViewDgInfo.ViewDgID] = objViewDgInfoEN.ViewDgID; //界面DgId
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewDgName))
 {
objRow[conViewDgInfo.ViewDgName] = objViewDgInfoEN.ViewDgName; //界面Dg名称
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewId))
 {
objRow[conViewDgInfo.ViewId] = objViewDgInfoEN.ViewId; //界面Id
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsId))
 {
objRow[conViewDgInfo.SqlDsId] = objViewDgInfoEN.SqlDsId; //数据源表/视图Id
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.DgStyleId))
 {
objRow[conViewDgInfo.DgStyleId] = objViewDgInfoEN.DgStyleId; //DG模式ID
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Style))
 {
objRow[conViewDgInfo.Style] = objViewDgInfoEN.Style; //类型
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Runat))
 {
objRow[conViewDgInfo.Runat] = objViewDgInfoEN.Runat; //运行在
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontSize))
 {
objRow[conViewDgInfo.FontSize] = objViewDgInfoEN.FontSize; //字号
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontName))
 {
objRow[conViewDgInfo.FontName] = objViewDgInfoEN.FontName; //字体
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Width))
 {
objRow[conViewDgInfo.Width] = objViewDgInfoEN.Width; //宽
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Height))
 {
objRow[conViewDgInfo.Height] = objViewDgInfoEN.Height; //高度
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowPaging))
 {
objRow[conViewDgInfo.AllowPaging] = objViewDgInfoEN.AllowPaging; //允许分页
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.PageSize))
 {
objRow[conViewDgInfo.PageSize] = objViewDgInfoEN.PageSize; //页大小
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AutoGenerateColumns))
 {
objRow[conViewDgInfo.AutoGenerateColumns] = objViewDgInfoEN.AutoGenerateColumns; //自动生成列
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowSorting))
 {
objRow[conViewDgInfo.AllowSorting] = objViewDgInfoEN.AllowSorting; //允许排序
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsRadio))
 {
objRow[conViewDgInfo.IsRadio] = objViewDgInfoEN.IsRadio; //是否单选框
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsCheck))
 {
objRow[conViewDgInfo.IsCheck] = objViewDgInfoEN.IsCheck; //是否复选框
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveUpdBtn))
 {
objRow[conViewDgInfo.IsHaveUpdBtn] = objViewDgInfoEN.IsHaveUpdBtn; //是否有修改按钮
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDelBtn))
 {
objRow[conViewDgInfo.IsHaveDelBtn] = objViewDgInfoEN.IsHaveDelBtn; //是否有删除按钮
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDetailBtn))
 {
objRow[conViewDgInfo.IsHaveDetailBtn] = objViewDgInfoEN.IsHaveDetailBtn; //是否有详细按钮
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsJumpPage))
 {
objRow[conViewDgInfo.IsJumpPage] = objViewDgInfoEN.IsJumpPage; //是否跳页
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsInTab))
 {
objRow[conViewDgInfo.IsInTab] = objViewDgInfoEN.IsInTab; //是否生成DG在表中
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleZindex))
 {
objRow[conViewDgInfo.StyleZindex] = objViewDgInfoEN.StyleZindex; //Style_Zindex
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleLeft))
 {
objRow[conViewDgInfo.StyleLeft] = objViewDgInfoEN.StyleLeft; //Style_Left
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StylePosition))
 {
objRow[conViewDgInfo.StylePosition] = objViewDgInfoEN.StylePosition; //Style_Position
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleTop))
 {
objRow[conViewDgInfo.StyleTop] = objViewDgInfoEN.StyleTop; //Style_Top
 }
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsTypeId))
 {
objRow[conViewDgInfo.SqlDsTypeId] = objViewDgInfoEN.SqlDsTypeId; //数据源类型Id
 }
try
{
objDA.Update(objDS, clsViewDgInfoEN._CurrTabName);
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewDgInfoEN objViewDgInfoEN)
{
 if (objViewDgInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewDgInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewDgInfo Set ");
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewDgName))
 {
 if (objViewDgInfoEN.ViewDgName !=  null)
 {
 var strViewDgName = objViewDgInfoEN.ViewDgName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewDgName, conViewDgInfo.ViewDgName); //界面Dg名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.ViewDgName); //界面Dg名称
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewId))
 {
 if (objViewDgInfoEN.ViewId  ==  "")
 {
 objViewDgInfoEN.ViewId = null;
 }
 if (objViewDgInfoEN.ViewId !=  null)
 {
 var strViewId = objViewDgInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conViewDgInfo.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.ViewId); //界面Id
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsId))
 {
 if (objViewDgInfoEN.SqlDsId !=  null)
 {
 var strSqlDsId = objViewDgInfoEN.SqlDsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlDsId, conViewDgInfo.SqlDsId); //数据源表/视图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.SqlDsId); //数据源表/视图Id
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.DgStyleId))
 {
 if (objViewDgInfoEN.DgStyleId  ==  "")
 {
 objViewDgInfoEN.DgStyleId = null;
 }
 if (objViewDgInfoEN.DgStyleId !=  null)
 {
 var strDgStyleId = objViewDgInfoEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDgStyleId, conViewDgInfo.DgStyleId); //DG模式ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.DgStyleId); //DG模式ID
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Style))
 {
 if (objViewDgInfoEN.Style !=  null)
 {
 var strStyle = objViewDgInfoEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conViewDgInfo.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Style); //类型
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Runat))
 {
 if (objViewDgInfoEN.Runat !=  null)
 {
 var strRunat = objViewDgInfoEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conViewDgInfo.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Runat); //运行在
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontSize))
 {
 if (objViewDgInfoEN.FontSize !=  null)
 {
 var strFontSize = objViewDgInfoEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conViewDgInfo.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.FontSize); //字号
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontName))
 {
 if (objViewDgInfoEN.FontName !=  null)
 {
 var strFontName = objViewDgInfoEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conViewDgInfo.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.FontName); //字体
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Width))
 {
 if (objViewDgInfoEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.Width, conViewDgInfo.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Width); //宽
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Height))
 {
 if (objViewDgInfoEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.Height, conViewDgInfo.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Height); //高度
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowPaging))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.AllowPaging == true?"1":"0", conViewDgInfo.AllowPaging); //允许分页
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.PageSize))
 {
 if (objViewDgInfoEN.PageSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.PageSize, conViewDgInfo.PageSize); //页大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.PageSize); //页大小
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AutoGenerateColumns))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.AutoGenerateColumns == true?"1":"0", conViewDgInfo.AutoGenerateColumns); //自动生成列
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowSorting))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.AllowSorting == true?"1":"0", conViewDgInfo.AllowSorting); //允许排序
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsRadio))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsRadio == true?"1":"0", conViewDgInfo.IsRadio); //是否单选框
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsCheck == true?"1":"0", conViewDgInfo.IsCheck); //是否复选框
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveUpdBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsHaveUpdBtn == true?"1":"0", conViewDgInfo.IsHaveUpdBtn); //是否有修改按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDelBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsHaveDelBtn == true?"1":"0", conViewDgInfo.IsHaveDelBtn); //是否有删除按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDetailBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsHaveDetailBtn == true?"1":"0", conViewDgInfo.IsHaveDetailBtn); //是否有详细按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsJumpPage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsJumpPage == true?"1":"0", conViewDgInfo.IsJumpPage); //是否跳页
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsInTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsInTab == true?"1":"0", conViewDgInfo.IsInTab); //是否生成DG在表中
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleZindex))
 {
 if (objViewDgInfoEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleZindex, conViewDgInfo.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleZindex); //Style_Zindex
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleLeft))
 {
 if (objViewDgInfoEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleLeft, conViewDgInfo.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleLeft); //Style_Left
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StylePosition))
 {
 if (objViewDgInfoEN.StylePosition !=  null)
 {
 var strStylePosition = objViewDgInfoEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conViewDgInfo.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StylePosition); //Style_Position
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleTop))
 {
 if (objViewDgInfoEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleTop, conViewDgInfo.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleTop); //Style_Top
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsTypeId))
 {
 if (objViewDgInfoEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objViewDgInfoEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlDsTypeId, conViewDgInfo.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.SqlDsTypeId); //数据源类型Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewDgID = '{0}'", objViewDgInfoEN.ViewDgID); 
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
 /// <param name = "objViewDgInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewDgInfoEN objViewDgInfoEN, string strCondition)
{
 if (objViewDgInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewDgInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewDgInfo Set ");
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewDgName))
 {
 if (objViewDgInfoEN.ViewDgName !=  null)
 {
 var strViewDgName = objViewDgInfoEN.ViewDgName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewDgName = '{0}',", strViewDgName); //界面Dg名称
 }
 else
 {
 sbSQL.Append(" ViewDgName = null,"); //界面Dg名称
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewId))
 {
 if (objViewDgInfoEN.ViewId  ==  "")
 {
 objViewDgInfoEN.ViewId = null;
 }
 if (objViewDgInfoEN.ViewId !=  null)
 {
 var strViewId = objViewDgInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsId))
 {
 if (objViewDgInfoEN.SqlDsId !=  null)
 {
 var strSqlDsId = objViewDgInfoEN.SqlDsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsId = '{0}',", strSqlDsId); //数据源表/视图Id
 }
 else
 {
 sbSQL.Append(" SqlDsId = null,"); //数据源表/视图Id
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.DgStyleId))
 {
 if (objViewDgInfoEN.DgStyleId  ==  "")
 {
 objViewDgInfoEN.DgStyleId = null;
 }
 if (objViewDgInfoEN.DgStyleId !=  null)
 {
 var strDgStyleId = objViewDgInfoEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DgStyleId = '{0}',", strDgStyleId); //DG模式ID
 }
 else
 {
 sbSQL.Append(" DgStyleId = null,"); //DG模式ID
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Style))
 {
 if (objViewDgInfoEN.Style !=  null)
 {
 var strStyle = objViewDgInfoEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Runat))
 {
 if (objViewDgInfoEN.Runat !=  null)
 {
 var strRunat = objViewDgInfoEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontSize))
 {
 if (objViewDgInfoEN.FontSize !=  null)
 {
 var strFontSize = objViewDgInfoEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontName))
 {
 if (objViewDgInfoEN.FontName !=  null)
 {
 var strFontName = objViewDgInfoEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Width))
 {
 if (objViewDgInfoEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.Width, conViewDgInfo.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Width); //宽
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Height))
 {
 if (objViewDgInfoEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.Height, conViewDgInfo.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Height); //高度
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowPaging))
 {
 sbSQL.AppendFormat(" AllowPaging = '{0}',", objViewDgInfoEN.AllowPaging == true?"1":"0"); //允许分页
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.PageSize))
 {
 if (objViewDgInfoEN.PageSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.PageSize, conViewDgInfo.PageSize); //页大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.PageSize); //页大小
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AutoGenerateColumns))
 {
 sbSQL.AppendFormat(" AutoGenerateColumns = '{0}',", objViewDgInfoEN.AutoGenerateColumns == true?"1":"0"); //自动生成列
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowSorting))
 {
 sbSQL.AppendFormat(" AllowSorting = '{0}',", objViewDgInfoEN.AllowSorting == true?"1":"0"); //允许排序
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsRadio))
 {
 sbSQL.AppendFormat(" IsRadio = '{0}',", objViewDgInfoEN.IsRadio == true?"1":"0"); //是否单选框
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsCheck))
 {
 sbSQL.AppendFormat(" IsCheck = '{0}',", objViewDgInfoEN.IsCheck == true?"1":"0"); //是否复选框
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveUpdBtn))
 {
 sbSQL.AppendFormat(" IsHaveUpdBtn = '{0}',", objViewDgInfoEN.IsHaveUpdBtn == true?"1":"0"); //是否有修改按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDelBtn))
 {
 sbSQL.AppendFormat(" IsHaveDelBtn = '{0}',", objViewDgInfoEN.IsHaveDelBtn == true?"1":"0"); //是否有删除按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDetailBtn))
 {
 sbSQL.AppendFormat(" IsHaveDetailBtn = '{0}',", objViewDgInfoEN.IsHaveDetailBtn == true?"1":"0"); //是否有详细按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsJumpPage))
 {
 sbSQL.AppendFormat(" IsJumpPage = '{0}',", objViewDgInfoEN.IsJumpPage == true?"1":"0"); //是否跳页
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsInTab))
 {
 sbSQL.AppendFormat(" IsInTab = '{0}',", objViewDgInfoEN.IsInTab == true?"1":"0"); //是否生成DG在表中
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleZindex))
 {
 if (objViewDgInfoEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleZindex, conViewDgInfo.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleZindex); //Style_Zindex
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleLeft))
 {
 if (objViewDgInfoEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleLeft, conViewDgInfo.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleLeft); //Style_Left
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StylePosition))
 {
 if (objViewDgInfoEN.StylePosition !=  null)
 {
 var strStylePosition = objViewDgInfoEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleTop))
 {
 if (objViewDgInfoEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleTop, conViewDgInfo.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleTop); //Style_Top
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsTypeId))
 {
 if (objViewDgInfoEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objViewDgInfoEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeId = '{0}',", strSqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.Append(" SqlDsTypeId = null,"); //数据源类型Id
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
 /// <param name = "objViewDgInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewDgInfoEN objViewDgInfoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewDgInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewDgInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewDgInfo Set ");
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewDgName))
 {
 if (objViewDgInfoEN.ViewDgName !=  null)
 {
 var strViewDgName = objViewDgInfoEN.ViewDgName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewDgName = '{0}',", strViewDgName); //界面Dg名称
 }
 else
 {
 sbSQL.Append(" ViewDgName = null,"); //界面Dg名称
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewId))
 {
 if (objViewDgInfoEN.ViewId  ==  "")
 {
 objViewDgInfoEN.ViewId = null;
 }
 if (objViewDgInfoEN.ViewId !=  null)
 {
 var strViewId = objViewDgInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsId))
 {
 if (objViewDgInfoEN.SqlDsId !=  null)
 {
 var strSqlDsId = objViewDgInfoEN.SqlDsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsId = '{0}',", strSqlDsId); //数据源表/视图Id
 }
 else
 {
 sbSQL.Append(" SqlDsId = null,"); //数据源表/视图Id
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.DgStyleId))
 {
 if (objViewDgInfoEN.DgStyleId  ==  "")
 {
 objViewDgInfoEN.DgStyleId = null;
 }
 if (objViewDgInfoEN.DgStyleId !=  null)
 {
 var strDgStyleId = objViewDgInfoEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DgStyleId = '{0}',", strDgStyleId); //DG模式ID
 }
 else
 {
 sbSQL.Append(" DgStyleId = null,"); //DG模式ID
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Style))
 {
 if (objViewDgInfoEN.Style !=  null)
 {
 var strStyle = objViewDgInfoEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Runat))
 {
 if (objViewDgInfoEN.Runat !=  null)
 {
 var strRunat = objViewDgInfoEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontSize))
 {
 if (objViewDgInfoEN.FontSize !=  null)
 {
 var strFontSize = objViewDgInfoEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontName))
 {
 if (objViewDgInfoEN.FontName !=  null)
 {
 var strFontName = objViewDgInfoEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Width))
 {
 if (objViewDgInfoEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.Width, conViewDgInfo.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Width); //宽
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Height))
 {
 if (objViewDgInfoEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.Height, conViewDgInfo.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Height); //高度
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowPaging))
 {
 sbSQL.AppendFormat(" AllowPaging = '{0}',", objViewDgInfoEN.AllowPaging == true?"1":"0"); //允许分页
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.PageSize))
 {
 if (objViewDgInfoEN.PageSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.PageSize, conViewDgInfo.PageSize); //页大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.PageSize); //页大小
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AutoGenerateColumns))
 {
 sbSQL.AppendFormat(" AutoGenerateColumns = '{0}',", objViewDgInfoEN.AutoGenerateColumns == true?"1":"0"); //自动生成列
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowSorting))
 {
 sbSQL.AppendFormat(" AllowSorting = '{0}',", objViewDgInfoEN.AllowSorting == true?"1":"0"); //允许排序
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsRadio))
 {
 sbSQL.AppendFormat(" IsRadio = '{0}',", objViewDgInfoEN.IsRadio == true?"1":"0"); //是否单选框
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsCheck))
 {
 sbSQL.AppendFormat(" IsCheck = '{0}',", objViewDgInfoEN.IsCheck == true?"1":"0"); //是否复选框
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveUpdBtn))
 {
 sbSQL.AppendFormat(" IsHaveUpdBtn = '{0}',", objViewDgInfoEN.IsHaveUpdBtn == true?"1":"0"); //是否有修改按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDelBtn))
 {
 sbSQL.AppendFormat(" IsHaveDelBtn = '{0}',", objViewDgInfoEN.IsHaveDelBtn == true?"1":"0"); //是否有删除按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDetailBtn))
 {
 sbSQL.AppendFormat(" IsHaveDetailBtn = '{0}',", objViewDgInfoEN.IsHaveDetailBtn == true?"1":"0"); //是否有详细按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsJumpPage))
 {
 sbSQL.AppendFormat(" IsJumpPage = '{0}',", objViewDgInfoEN.IsJumpPage == true?"1":"0"); //是否跳页
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsInTab))
 {
 sbSQL.AppendFormat(" IsInTab = '{0}',", objViewDgInfoEN.IsInTab == true?"1":"0"); //是否生成DG在表中
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleZindex))
 {
 if (objViewDgInfoEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleZindex, conViewDgInfo.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleZindex); //Style_Zindex
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleLeft))
 {
 if (objViewDgInfoEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleLeft, conViewDgInfo.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleLeft); //Style_Left
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StylePosition))
 {
 if (objViewDgInfoEN.StylePosition !=  null)
 {
 var strStylePosition = objViewDgInfoEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleTop))
 {
 if (objViewDgInfoEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleTop, conViewDgInfo.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleTop); //Style_Top
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsTypeId))
 {
 if (objViewDgInfoEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objViewDgInfoEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeId = '{0}',", strSqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.Append(" SqlDsTypeId = null,"); //数据源类型Id
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewDgInfoEN objViewDgInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objViewDgInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewDgInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewDgInfo Set ");
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewDgName))
 {
 if (objViewDgInfoEN.ViewDgName !=  null)
 {
 var strViewDgName = objViewDgInfoEN.ViewDgName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewDgName, conViewDgInfo.ViewDgName); //界面Dg名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.ViewDgName); //界面Dg名称
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.ViewId))
 {
 if (objViewDgInfoEN.ViewId  ==  "")
 {
 objViewDgInfoEN.ViewId = null;
 }
 if (objViewDgInfoEN.ViewId !=  null)
 {
 var strViewId = objViewDgInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conViewDgInfo.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.ViewId); //界面Id
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsId))
 {
 if (objViewDgInfoEN.SqlDsId !=  null)
 {
 var strSqlDsId = objViewDgInfoEN.SqlDsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlDsId, conViewDgInfo.SqlDsId); //数据源表/视图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.SqlDsId); //数据源表/视图Id
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.DgStyleId))
 {
 if (objViewDgInfoEN.DgStyleId  ==  "")
 {
 objViewDgInfoEN.DgStyleId = null;
 }
 if (objViewDgInfoEN.DgStyleId !=  null)
 {
 var strDgStyleId = objViewDgInfoEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDgStyleId, conViewDgInfo.DgStyleId); //DG模式ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.DgStyleId); //DG模式ID
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Style))
 {
 if (objViewDgInfoEN.Style !=  null)
 {
 var strStyle = objViewDgInfoEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conViewDgInfo.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Style); //类型
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Runat))
 {
 if (objViewDgInfoEN.Runat !=  null)
 {
 var strRunat = objViewDgInfoEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conViewDgInfo.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Runat); //运行在
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontSize))
 {
 if (objViewDgInfoEN.FontSize !=  null)
 {
 var strFontSize = objViewDgInfoEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conViewDgInfo.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.FontSize); //字号
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.FontName))
 {
 if (objViewDgInfoEN.FontName !=  null)
 {
 var strFontName = objViewDgInfoEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conViewDgInfo.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.FontName); //字体
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Width))
 {
 if (objViewDgInfoEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.Width, conViewDgInfo.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Width); //宽
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.Height))
 {
 if (objViewDgInfoEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.Height, conViewDgInfo.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.Height); //高度
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowPaging))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.AllowPaging == true?"1":"0", conViewDgInfo.AllowPaging); //允许分页
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.PageSize))
 {
 if (objViewDgInfoEN.PageSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.PageSize, conViewDgInfo.PageSize); //页大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.PageSize); //页大小
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AutoGenerateColumns))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.AutoGenerateColumns == true?"1":"0", conViewDgInfo.AutoGenerateColumns); //自动生成列
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.AllowSorting))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.AllowSorting == true?"1":"0", conViewDgInfo.AllowSorting); //允许排序
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsRadio))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsRadio == true?"1":"0", conViewDgInfo.IsRadio); //是否单选框
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsCheck == true?"1":"0", conViewDgInfo.IsCheck); //是否复选框
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveUpdBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsHaveUpdBtn == true?"1":"0", conViewDgInfo.IsHaveUpdBtn); //是否有修改按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDelBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsHaveDelBtn == true?"1":"0", conViewDgInfo.IsHaveDelBtn); //是否有删除按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsHaveDetailBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsHaveDetailBtn == true?"1":"0", conViewDgInfo.IsHaveDetailBtn); //是否有详细按钮
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsJumpPage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsJumpPage == true?"1":"0", conViewDgInfo.IsJumpPage); //是否跳页
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.IsInTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewDgInfoEN.IsInTab == true?"1":"0", conViewDgInfo.IsInTab); //是否生成DG在表中
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleZindex))
 {
 if (objViewDgInfoEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleZindex, conViewDgInfo.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleZindex); //Style_Zindex
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleLeft))
 {
 if (objViewDgInfoEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleLeft, conViewDgInfo.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleLeft); //Style_Left
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StylePosition))
 {
 if (objViewDgInfoEN.StylePosition !=  null)
 {
 var strStylePosition = objViewDgInfoEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conViewDgInfo.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StylePosition); //Style_Position
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.StyleTop))
 {
 if (objViewDgInfoEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewDgInfoEN.StyleTop, conViewDgInfo.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.StyleTop); //Style_Top
 }
 }
 
 if (objViewDgInfoEN.IsUpdated(conViewDgInfo.SqlDsTypeId))
 {
 if (objViewDgInfoEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objViewDgInfoEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlDsTypeId, conViewDgInfo.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewDgInfo.SqlDsTypeId); //数据源类型Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewDgID = '{0}'", objViewDgInfoEN.ViewDgID); 
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
 /// <param name = "strViewDgID">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strViewDgID) 
{
CheckPrimaryKey(strViewDgID);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strViewDgID,
};
 objSQL.ExecSP("ViewDgInfo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strViewDgID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strViewDgID, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strViewDgID);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
//删除ViewDgInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewDgInfo where ViewDgID = " + "'"+ strViewDgID+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewDgInfo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
//删除ViewDgInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewDgInfo where ViewDgID in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strViewDgID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strViewDgID) 
{
CheckPrimaryKey(strViewDgID);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
//删除ViewDgInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewDgInfo where ViewDgID = " + "'"+ strViewDgID+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewDgInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewDgInfoDA: DelViewDgInfo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewDgInfo where " + strCondition ;
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
public bool DelViewDgInfoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewDgInfoDA: DelViewDgInfoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewDgInfo where " + strCondition ;
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
 /// <param name = "objViewDgInfoENS">源对象</param>
 /// <param name = "objViewDgInfoENT">目标对象</param>
public void CopyTo(clsViewDgInfoEN objViewDgInfoENS, clsViewDgInfoEN objViewDgInfoENT)
{
objViewDgInfoENT.ViewDgID = objViewDgInfoENS.ViewDgID; //界面DgId
objViewDgInfoENT.ViewDgName = objViewDgInfoENS.ViewDgName; //界面Dg名称
objViewDgInfoENT.ViewId = objViewDgInfoENS.ViewId; //界面Id
objViewDgInfoENT.SqlDsId = objViewDgInfoENS.SqlDsId; //数据源表/视图Id
objViewDgInfoENT.DgStyleId = objViewDgInfoENS.DgStyleId; //DG模式ID
objViewDgInfoENT.Style = objViewDgInfoENS.Style; //类型
objViewDgInfoENT.Runat = objViewDgInfoENS.Runat; //运行在
objViewDgInfoENT.FontSize = objViewDgInfoENS.FontSize; //字号
objViewDgInfoENT.FontName = objViewDgInfoENS.FontName; //字体
objViewDgInfoENT.Width = objViewDgInfoENS.Width; //宽
objViewDgInfoENT.Height = objViewDgInfoENS.Height; //高度
objViewDgInfoENT.AllowPaging = objViewDgInfoENS.AllowPaging; //允许分页
objViewDgInfoENT.PageSize = objViewDgInfoENS.PageSize; //页大小
objViewDgInfoENT.AutoGenerateColumns = objViewDgInfoENS.AutoGenerateColumns; //自动生成列
objViewDgInfoENT.AllowSorting = objViewDgInfoENS.AllowSorting; //允许排序
objViewDgInfoENT.IsRadio = objViewDgInfoENS.IsRadio; //是否单选框
objViewDgInfoENT.IsCheck = objViewDgInfoENS.IsCheck; //是否复选框
objViewDgInfoENT.IsHaveUpdBtn = objViewDgInfoENS.IsHaveUpdBtn; //是否有修改按钮
objViewDgInfoENT.IsHaveDelBtn = objViewDgInfoENS.IsHaveDelBtn; //是否有删除按钮
objViewDgInfoENT.IsHaveDetailBtn = objViewDgInfoENS.IsHaveDetailBtn; //是否有详细按钮
objViewDgInfoENT.IsJumpPage = objViewDgInfoENS.IsJumpPage; //是否跳页
objViewDgInfoENT.IsInTab = objViewDgInfoENS.IsInTab; //是否生成DG在表中
objViewDgInfoENT.StyleZindex = objViewDgInfoENS.StyleZindex; //Style_Zindex
objViewDgInfoENT.StyleLeft = objViewDgInfoENS.StyleLeft; //Style_Left
objViewDgInfoENT.StylePosition = objViewDgInfoENS.StylePosition; //Style_Position
objViewDgInfoENT.StyleTop = objViewDgInfoENS.StyleTop; //Style_Top
objViewDgInfoENT.SqlDsTypeId = objViewDgInfoENS.SqlDsTypeId; //数据源类型Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewDgInfoEN objViewDgInfoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewDgInfoEN.ViewDgName, conViewDgInfo.ViewDgName);
clsCheckSql.CheckFieldNotNull(objViewDgInfoEN.ViewId, conViewDgInfo.ViewId);
clsCheckSql.CheckFieldNotNull(objViewDgInfoEN.DgStyleId, conViewDgInfo.DgStyleId);
clsCheckSql.CheckFieldNotNull(objViewDgInfoEN.AllowPaging, conViewDgInfo.AllowPaging);
clsCheckSql.CheckFieldNotNull(objViewDgInfoEN.AutoGenerateColumns, conViewDgInfo.AutoGenerateColumns);
clsCheckSql.CheckFieldNotNull(objViewDgInfoEN.AllowSorting, conViewDgInfo.AllowSorting);
clsCheckSql.CheckFieldNotNull(objViewDgInfoEN.SqlDsTypeId, conViewDgInfo.SqlDsTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewDgInfoEN.ViewDgID, 10, conViewDgInfo.ViewDgID);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.ViewDgName, 100, conViewDgInfo.ViewDgName);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.ViewId, 8, conViewDgInfo.ViewId);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.SqlDsId, 8, conViewDgInfo.SqlDsId);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.DgStyleId, 4, conViewDgInfo.DgStyleId);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.Style, 800, conViewDgInfo.Style);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.Runat, 30, conViewDgInfo.Runat);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.FontSize, 20, conViewDgInfo.FontSize);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.FontName, 20, conViewDgInfo.FontName);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.StylePosition, 20, conViewDgInfo.StylePosition);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.SqlDsTypeId, 2, conViewDgInfo.SqlDsTypeId);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objViewDgInfoEN.ViewId, 8, conViewDgInfo.ViewId);
 objViewDgInfoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewDgInfoEN objViewDgInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewDgInfoEN.ViewDgName, 100, conViewDgInfo.ViewDgName);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.ViewId, 8, conViewDgInfo.ViewId);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.SqlDsId, 8, conViewDgInfo.SqlDsId);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.DgStyleId, 4, conViewDgInfo.DgStyleId);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.Style, 800, conViewDgInfo.Style);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.Runat, 30, conViewDgInfo.Runat);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.FontSize, 20, conViewDgInfo.FontSize);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.FontName, 20, conViewDgInfo.FontName);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.StylePosition, 20, conViewDgInfo.StylePosition);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.SqlDsTypeId, 2, conViewDgInfo.SqlDsTypeId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewDgInfoEN.ViewId, 8, conViewDgInfo.ViewId);
 objViewDgInfoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewDgInfoEN objViewDgInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewDgInfoEN.ViewDgID, 10, conViewDgInfo.ViewDgID);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.ViewDgName, 100, conViewDgInfo.ViewDgName);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.ViewId, 8, conViewDgInfo.ViewId);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.SqlDsId, 8, conViewDgInfo.SqlDsId);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.DgStyleId, 4, conViewDgInfo.DgStyleId);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.Style, 800, conViewDgInfo.Style);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.Runat, 30, conViewDgInfo.Runat);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.FontSize, 20, conViewDgInfo.FontSize);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.FontName, 20, conViewDgInfo.FontName);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.StylePosition, 20, conViewDgInfo.StylePosition);
clsCheckSql.CheckFieldLen(objViewDgInfoEN.SqlDsTypeId, 2, conViewDgInfo.SqlDsTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.ViewDgID, conViewDgInfo.ViewDgID);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.ViewDgName, conViewDgInfo.ViewDgName);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.ViewId, conViewDgInfo.ViewId);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.SqlDsId, conViewDgInfo.SqlDsId);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.DgStyleId, conViewDgInfo.DgStyleId);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.Style, conViewDgInfo.Style);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.Runat, conViewDgInfo.Runat);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.FontSize, conViewDgInfo.FontSize);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.FontName, conViewDgInfo.FontName);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.StylePosition, conViewDgInfo.StylePosition);
clsCheckSql.CheckSqlInjection4Field(objViewDgInfoEN.SqlDsTypeId, conViewDgInfo.SqlDsTypeId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewDgInfoEN.ViewId, 8, conViewDgInfo.ViewId);
 objViewDgInfoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewDgInfo(视图Dg),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewDgInfoEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewDgInfoEN objViewDgInfoEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewDgName = '{0}'", objViewDgInfoEN.ViewDgName);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewDgInfoEN.ViewId);
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
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewDgInfoEN._CurrTabName);
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
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewDgInfoEN._CurrTabName, strCondition);
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
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
 objSQL = clsViewDgInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}