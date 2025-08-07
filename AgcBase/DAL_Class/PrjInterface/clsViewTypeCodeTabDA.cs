
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTypeCodeTabDA
 表名:ViewTypeCodeTab(00050104)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:04
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
 /// 界面类型码(ViewTypeCodeTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewTypeCodeTabDA : clsCommBase4DA
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
 return clsViewTypeCodeTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewTypeCodeTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewTypeCodeTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewTypeCodeTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewTypeCodeTabEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewTypeCodeTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetDataTable_ViewTypeCodeTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewTypeCodeTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewTypeCodeTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewTypeCodeTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewTypeCodeTab.* " + 
$"from ViewTypeCodeTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewTypeCodeTab.ViewTypeCode not in " + 
$"(Select top {intTop_In} ViewTypeCodeTab.ViewTypeCode from ViewTypeCodeTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewTypeCodeTab where {1} and ViewTypeCode not in (Select top {2} ViewTypeCode from ViewTypeCodeTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewTypeCodeTab where {1} and ViewTypeCode not in (Select top {3} ViewTypeCode from ViewTypeCodeTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewTypeCodeTab.* " + 
$"from ViewTypeCodeTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewTypeCodeTab.ViewTypeCode not in " + 
$"(Select top {intTop_In} ViewTypeCodeTab.ViewTypeCode from ViewTypeCodeTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewTypeCodeTab where {1} and ViewTypeCode not in (Select top {2} ViewTypeCode from ViewTypeCodeTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewTypeCodeTab where {1} and ViewTypeCode not in (Select top {3} ViewTypeCode from ViewTypeCodeTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewTypeCodeTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA:GetObjLst)", objException.Message));
}
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = TransNullToBool(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewTypeCodeTabDA: GetObjLst)", objException.Message));
}
objViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewTypeCodeTabEN);
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
public List<clsViewTypeCodeTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = TransNullToBool(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewTypeCodeTabDA: GetObjLst)", objException.Message));
}
objViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewTypeCodeTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewTypeCodeTab(ref clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where ViewTypeCode = " + ""+ objViewTypeCodeTabEN.ViewTypeCode+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objDT.Rows[0][conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objViewTypeCodeTabEN.ViewTypeName = objDT.Rows[0][conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称(字段类型:varchar,字段长度:40,是否可空:False)
 objViewTypeCodeTabEN.ViewTypeENName = objDT.Rows[0][conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName(字段类型:varchar,字段长度:40,是否可空:True)
 objViewTypeCodeTabEN.IsWinApp = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.IsWebApp = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.ViewFunction = objDT.Rows[0][conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objViewTypeCodeTabEN.OptProcess = objDT.Rows[0][conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewTypeCodeTabEN.ViewDetail = objDT.Rows[0][conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.OrderNum = TransNullToInt(objDT.Rows[0][conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objViewTypeCodeTabEN.IsUsed = TransNullToBool(objDT.Rows[0][conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewTypeCodeTabDA: GetViewTypeCodeTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intViewTypeCode">表关键字</param>
 /// <returns>表对象</returns>
public clsViewTypeCodeTabEN GetObjByViewTypeCode(int intViewTypeCode)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where ViewTypeCode = " + ""+ intViewTypeCode+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
 objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称(字段类型:varchar,字段长度:40,是否可空:False)
 objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName(字段类型:varchar,字段长度:40,是否可空:True)
 objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改(字段类型:bit,字段长度:1,是否可空:True)
 objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面(字段类型:bit,字段长度:1,是否可空:False)
 objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewTypeCodeTabDA: GetObjByViewTypeCode)", objException.Message));
}
return objViewTypeCodeTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewTypeCodeTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN()
{
ViewTypeCode = TransNullToInt(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()), //界面类型码
ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(), //界面类型名称
ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(), //ViewTypeENName
IsWinApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()), //IsWinApp
IsMobileApp = TransNullToBool(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()), //是否移动终端应用
IsWebApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()), //IsWebApp
ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(), //界面功能
OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(), //操作流程
ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(), //界面说明
ApplicationTypeId = TransNullToInt(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
IsHaveAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()), //是否有添加
IsHaveUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()), //是否有修改
IsHaveDel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()), //是否有删除
IsHaveQuery = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()), //是否有查询
IsHaveExcelExport = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()), //是否EXCEL导出
IsHaveSetExportExcel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()), //是否有设置EXCEL导出
IsHaveDetail = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()), //是否有详细
IsHaveExeAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()), //是否有调用添加
IsHaveExeUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()), //是否有调用修改
IsHaveMainView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()), //是否有主界面
IsHaveSubView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()), //是否有子界面
OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()), //序号
IsUsed = TransNullToBool(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()) //IsUsed
};
objViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewTypeCodeTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewTypeCodeTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewTypeCodeTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = TransNullToBool(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewTypeCodeTabDA: GetObjByDataRowViewTypeCodeTab)", objException.Message));
}
objViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewTypeCodeTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewTypeCodeTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = TransNullToBool(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = TransNullToBool(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewTypeCodeTabDA: GetObjByDataRow)", objException.Message));
}
objViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewTypeCodeTabEN;
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
objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewTypeCodeTabEN._CurrTabName, conViewTypeCodeTab.ViewTypeCode, 4, "");
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
objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewTypeCodeTabEN._CurrTabName, conViewTypeCodeTab.ViewTypeCode, 4, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public int GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewTypeCode from ViewTypeCodeTab where " + strCondition;
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
return int.Parse(strKeyValue);
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
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewTypeCode from ViewTypeCodeTab where " + strCondition;
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
 /// <param name = "intViewTypeCode">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(int intViewTypeCode)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewTypeCodeTab", "ViewTypeCode = " + ""+ intViewTypeCode+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewTypeCodeTab", strCondition))
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
objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewTypeCodeTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
 {
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewTypeCodeTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewTypeCodeTab");
objRow = objDS.Tables["ViewTypeCodeTab"].NewRow();
objRow[conViewTypeCodeTab.ViewTypeName] = objViewTypeCodeTabEN.ViewTypeName; //界面类型名称
 if (objViewTypeCodeTabEN.ViewTypeENName !=  "")
 {
objRow[conViewTypeCodeTab.ViewTypeENName] = objViewTypeCodeTabEN.ViewTypeENName; //ViewTypeENName
 }
objRow[conViewTypeCodeTab.IsWinApp] = objViewTypeCodeTabEN.IsWinApp; //IsWinApp
objRow[conViewTypeCodeTab.IsMobileApp] = objViewTypeCodeTabEN.IsMobileApp; //是否移动终端应用
objRow[conViewTypeCodeTab.IsWebApp] = objViewTypeCodeTabEN.IsWebApp; //IsWebApp
 if (objViewTypeCodeTabEN.ViewFunction !=  "")
 {
objRow[conViewTypeCodeTab.ViewFunction] = objViewTypeCodeTabEN.ViewFunction; //界面功能
 }
 if (objViewTypeCodeTabEN.OptProcess !=  "")
 {
objRow[conViewTypeCodeTab.OptProcess] = objViewTypeCodeTabEN.OptProcess; //操作流程
 }
 if (objViewTypeCodeTabEN.ViewDetail !=  "")
 {
objRow[conViewTypeCodeTab.ViewDetail] = objViewTypeCodeTabEN.ViewDetail; //界面说明
 }
objRow[conViewTypeCodeTab.ApplicationTypeId] = objViewTypeCodeTabEN.ApplicationTypeId; //应用程序类型ID
objRow[conViewTypeCodeTab.IsHaveAdd] = objViewTypeCodeTabEN.IsHaveAdd; //是否有添加
objRow[conViewTypeCodeTab.IsHaveUpdate] = objViewTypeCodeTabEN.IsHaveUpdate; //是否有修改
objRow[conViewTypeCodeTab.IsHaveDel] = objViewTypeCodeTabEN.IsHaveDel; //是否有删除
objRow[conViewTypeCodeTab.IsHaveQuery] = objViewTypeCodeTabEN.IsHaveQuery; //是否有查询
objRow[conViewTypeCodeTab.IsHaveExcelExport] = objViewTypeCodeTabEN.IsHaveExcelExport; //是否EXCEL导出
objRow[conViewTypeCodeTab.IsHaveSetExportExcel] = objViewTypeCodeTabEN.IsHaveSetExportExcel; //是否有设置EXCEL导出
objRow[conViewTypeCodeTab.IsHaveDetail] = objViewTypeCodeTabEN.IsHaveDetail; //是否有详细
objRow[conViewTypeCodeTab.IsHaveExeAdd] = objViewTypeCodeTabEN.IsHaveExeAdd; //是否有调用添加
objRow[conViewTypeCodeTab.IsHaveExeUpdate] = objViewTypeCodeTabEN.IsHaveExeUpdate; //是否有调用修改
objRow[conViewTypeCodeTab.IsHaveMainView] = objViewTypeCodeTabEN.IsHaveMainView; //是否有主界面
objRow[conViewTypeCodeTab.IsHaveSubView] = objViewTypeCodeTabEN.IsHaveSubView; //是否有子界面
objRow[conViewTypeCodeTab.OrderNum] = objViewTypeCodeTabEN.OrderNum; //序号
objRow[conViewTypeCodeTab.IsUsed] = objViewTypeCodeTabEN.IsUsed; //IsUsed
objDS.Tables[clsViewTypeCodeTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewTypeCodeTabEN._CurrTabName);
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewTypeCodeTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewTypeCodeTabEN.ViewTypeName !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewTypeName);
 var strViewTypeName = objViewTypeCodeTabEN.ViewTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeName + "'");
 }
 
 if (objViewTypeCodeTabEN.ViewTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewTypeENName);
 var strViewTypeENName = objViewTypeCodeTabEN.ViewTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeENName + "'");
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsWinApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsWinApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsMobileApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsMobileApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsWebApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsWebApp  ==  false ? "0" : "1") + "'");
 
 if (objViewTypeCodeTabEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewFunction);
 var strViewFunction = objViewTypeCodeTabEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objViewTypeCodeTabEN.OptProcess !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.OptProcess);
 var strOptProcess = objViewTypeCodeTabEN.OptProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptProcess + "'");
 }
 
 if (objViewTypeCodeTabEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewDetail);
 var strViewDetail = objViewTypeCodeTabEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.ApplicationTypeId);
 arrValueListForInsert.Add(objViewTypeCodeTabEN.ApplicationTypeId.ToString());
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveAdd);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveAdd  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveUpdate);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveUpdate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveDel);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveDel  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveQuery);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveQuery  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExcelExport);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExcelExport  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveSetExportExcel);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveSetExportExcel  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveDetail);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveDetail  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExeAdd);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExeAdd  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExeUpdate);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExeUpdate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveMainView);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveMainView  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveSubView);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveSubView  ==  false ? "0" : "1") + "'");
 
 if (objViewTypeCodeTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.OrderNum);
 arrValueListForInsert.Add(objViewTypeCodeTabEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsUsed);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsUsed  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewTypeCodeTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewTypeCodeTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewTypeCodeTabEN.ViewTypeName !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewTypeName);
 var strViewTypeName = objViewTypeCodeTabEN.ViewTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeName + "'");
 }
 
 if (objViewTypeCodeTabEN.ViewTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewTypeENName);
 var strViewTypeENName = objViewTypeCodeTabEN.ViewTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeENName + "'");
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsWinApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsWinApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsMobileApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsMobileApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsWebApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsWebApp  ==  false ? "0" : "1") + "'");
 
 if (objViewTypeCodeTabEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewFunction);
 var strViewFunction = objViewTypeCodeTabEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objViewTypeCodeTabEN.OptProcess !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.OptProcess);
 var strOptProcess = objViewTypeCodeTabEN.OptProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptProcess + "'");
 }
 
 if (objViewTypeCodeTabEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewDetail);
 var strViewDetail = objViewTypeCodeTabEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.ApplicationTypeId);
 arrValueListForInsert.Add(objViewTypeCodeTabEN.ApplicationTypeId.ToString());
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveAdd);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveAdd  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveUpdate);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveUpdate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveDel);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveDel  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveQuery);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveQuery  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExcelExport);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExcelExport  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveSetExportExcel);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveSetExportExcel  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveDetail);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveDetail  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExeAdd);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExeAdd  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExeUpdate);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExeUpdate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveMainView);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveMainView  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveSubView);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveSubView  ==  false ? "0" : "1") + "'");
 
 if (objViewTypeCodeTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.OrderNum);
 arrValueListForInsert.Add(objViewTypeCodeTabEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsUsed);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsUsed  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewTypeCodeTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewTypeCodeTabEN objViewTypeCodeTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewTypeCodeTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewTypeCodeTabEN.ViewTypeName !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewTypeName);
 var strViewTypeName = objViewTypeCodeTabEN.ViewTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeName + "'");
 }
 
 if (objViewTypeCodeTabEN.ViewTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewTypeENName);
 var strViewTypeENName = objViewTypeCodeTabEN.ViewTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeENName + "'");
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsWinApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsWinApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsMobileApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsMobileApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsWebApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsWebApp  ==  false ? "0" : "1") + "'");
 
 if (objViewTypeCodeTabEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewFunction);
 var strViewFunction = objViewTypeCodeTabEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objViewTypeCodeTabEN.OptProcess !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.OptProcess);
 var strOptProcess = objViewTypeCodeTabEN.OptProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptProcess + "'");
 }
 
 if (objViewTypeCodeTabEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewDetail);
 var strViewDetail = objViewTypeCodeTabEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.ApplicationTypeId);
 arrValueListForInsert.Add(objViewTypeCodeTabEN.ApplicationTypeId.ToString());
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveAdd);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveAdd  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveUpdate);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveUpdate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveDel);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveDel  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveQuery);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveQuery  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExcelExport);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExcelExport  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveSetExportExcel);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveSetExportExcel  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveDetail);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveDetail  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExeAdd);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExeAdd  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExeUpdate);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExeUpdate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveMainView);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveMainView  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveSubView);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveSubView  ==  false ? "0" : "1") + "'");
 
 if (objViewTypeCodeTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.OrderNum);
 arrValueListForInsert.Add(objViewTypeCodeTabEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsUsed);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsUsed  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewTypeCodeTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewTypeCodeTabEN objViewTypeCodeTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewTypeCodeTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewTypeCodeTabEN.ViewTypeName !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewTypeName);
 var strViewTypeName = objViewTypeCodeTabEN.ViewTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeName + "'");
 }
 
 if (objViewTypeCodeTabEN.ViewTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewTypeENName);
 var strViewTypeENName = objViewTypeCodeTabEN.ViewTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewTypeENName + "'");
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsWinApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsWinApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsMobileApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsMobileApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsWebApp);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsWebApp  ==  false ? "0" : "1") + "'");
 
 if (objViewTypeCodeTabEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewFunction);
 var strViewFunction = objViewTypeCodeTabEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objViewTypeCodeTabEN.OptProcess !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.OptProcess);
 var strOptProcess = objViewTypeCodeTabEN.OptProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptProcess + "'");
 }
 
 if (objViewTypeCodeTabEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.ViewDetail);
 var strViewDetail = objViewTypeCodeTabEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.ApplicationTypeId);
 arrValueListForInsert.Add(objViewTypeCodeTabEN.ApplicationTypeId.ToString());
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveAdd);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveAdd  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveUpdate);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveUpdate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveDel);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveDel  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveQuery);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveQuery  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExcelExport);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExcelExport  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveSetExportExcel);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveSetExportExcel  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveDetail);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveDetail  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExeAdd);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExeAdd  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveExeUpdate);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveExeUpdate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveMainView);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveMainView  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsHaveSubView);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsHaveSubView  ==  false ? "0" : "1") + "'");
 
 if (objViewTypeCodeTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conViewTypeCodeTab.OrderNum);
 arrValueListForInsert.Add(objViewTypeCodeTabEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conViewTypeCodeTab.IsUsed);
 arrValueListForInsert.Add("'" + (objViewTypeCodeTabEN.IsUsed  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewTypeCodeTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewTypeCodeTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where ViewTypeCode = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewTypeCodeTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
int intViewTypeCode = TransNullToInt(oRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim());
if (IsExist(intViewTypeCode))
{
 string strResult = "关键字变量值为:" + string.Format("ViewTypeCode = {0}", intViewTypeCode) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewTypeCodeTabEN._CurrTabName ].NewRow();
objRow[conViewTypeCodeTab.ViewTypeName] = oRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objRow[conViewTypeCodeTab.ViewTypeENName] = oRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objRow[conViewTypeCodeTab.IsWinApp] = oRow[conViewTypeCodeTab.IsWinApp].ToString().Trim(); //IsWinApp
objRow[conViewTypeCodeTab.IsMobileApp] = oRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim(); //是否移动终端应用
objRow[conViewTypeCodeTab.IsWebApp] = oRow[conViewTypeCodeTab.IsWebApp].ToString().Trim(); //IsWebApp
objRow[conViewTypeCodeTab.ViewFunction] = oRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objRow[conViewTypeCodeTab.OptProcess] = oRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objRow[conViewTypeCodeTab.ViewDetail] = oRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objRow[conViewTypeCodeTab.ApplicationTypeId] = oRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conViewTypeCodeTab.IsHaveAdd] = oRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim(); //是否有添加
objRow[conViewTypeCodeTab.IsHaveUpdate] = oRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim(); //是否有修改
objRow[conViewTypeCodeTab.IsHaveDel] = oRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim(); //是否有删除
objRow[conViewTypeCodeTab.IsHaveQuery] = oRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim(); //是否有查询
objRow[conViewTypeCodeTab.IsHaveExcelExport] = oRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim(); //是否EXCEL导出
objRow[conViewTypeCodeTab.IsHaveSetExportExcel] = oRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim(); //是否有设置EXCEL导出
objRow[conViewTypeCodeTab.IsHaveDetail] = oRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim(); //是否有详细
objRow[conViewTypeCodeTab.IsHaveExeAdd] = oRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim(); //是否有调用添加
objRow[conViewTypeCodeTab.IsHaveExeUpdate] = oRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim(); //是否有调用修改
objRow[conViewTypeCodeTab.IsHaveMainView] = oRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim(); //是否有主界面
objRow[conViewTypeCodeTab.IsHaveSubView] = oRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim(); //是否有子界面
objRow[conViewTypeCodeTab.OrderNum] = oRow[conViewTypeCodeTab.OrderNum].ToString().Trim(); //序号
objRow[conViewTypeCodeTab.IsUsed] = oRow[conViewTypeCodeTab.IsUsed].ToString().Trim(); //IsUsed
 objDS.Tables[clsViewTypeCodeTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewTypeCodeTabEN._CurrTabName);
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
 /// <param name = "objViewTypeCodeTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewTypeCodeTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from ViewTypeCodeTab where ViewTypeCode = " + ""+ objViewTypeCodeTabEN.ViewTypeCode+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewTypeCodeTabEN._CurrTabName);
if (objDS.Tables[clsViewTypeCodeTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ViewTypeCode = " + ""+ objViewTypeCodeTabEN.ViewTypeCode+"");
return false;
}
objRow = objDS.Tables[clsViewTypeCodeTabEN._CurrTabName].Rows[0];
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeName))
 {
objRow[conViewTypeCodeTab.ViewTypeName] = objViewTypeCodeTabEN.ViewTypeName; //界面类型名称
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeENName))
 {
objRow[conViewTypeCodeTab.ViewTypeENName] = objViewTypeCodeTabEN.ViewTypeENName; //ViewTypeENName
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWinApp))
 {
objRow[conViewTypeCodeTab.IsWinApp] = objViewTypeCodeTabEN.IsWinApp; //IsWinApp
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsMobileApp))
 {
objRow[conViewTypeCodeTab.IsMobileApp] = objViewTypeCodeTabEN.IsMobileApp; //是否移动终端应用
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWebApp))
 {
objRow[conViewTypeCodeTab.IsWebApp] = objViewTypeCodeTabEN.IsWebApp; //IsWebApp
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewFunction))
 {
objRow[conViewTypeCodeTab.ViewFunction] = objViewTypeCodeTabEN.ViewFunction; //界面功能
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OptProcess))
 {
objRow[conViewTypeCodeTab.OptProcess] = objViewTypeCodeTabEN.OptProcess; //操作流程
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewDetail))
 {
objRow[conViewTypeCodeTab.ViewDetail] = objViewTypeCodeTabEN.ViewDetail; //界面说明
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ApplicationTypeId))
 {
objRow[conViewTypeCodeTab.ApplicationTypeId] = objViewTypeCodeTabEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveAdd))
 {
objRow[conViewTypeCodeTab.IsHaveAdd] = objViewTypeCodeTabEN.IsHaveAdd; //是否有添加
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveUpdate))
 {
objRow[conViewTypeCodeTab.IsHaveUpdate] = objViewTypeCodeTabEN.IsHaveUpdate; //是否有修改
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDel))
 {
objRow[conViewTypeCodeTab.IsHaveDel] = objViewTypeCodeTabEN.IsHaveDel; //是否有删除
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveQuery))
 {
objRow[conViewTypeCodeTab.IsHaveQuery] = objViewTypeCodeTabEN.IsHaveQuery; //是否有查询
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExcelExport))
 {
objRow[conViewTypeCodeTab.IsHaveExcelExport] = objViewTypeCodeTabEN.IsHaveExcelExport; //是否EXCEL导出
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSetExportExcel))
 {
objRow[conViewTypeCodeTab.IsHaveSetExportExcel] = objViewTypeCodeTabEN.IsHaveSetExportExcel; //是否有设置EXCEL导出
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDetail))
 {
objRow[conViewTypeCodeTab.IsHaveDetail] = objViewTypeCodeTabEN.IsHaveDetail; //是否有详细
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeAdd))
 {
objRow[conViewTypeCodeTab.IsHaveExeAdd] = objViewTypeCodeTabEN.IsHaveExeAdd; //是否有调用添加
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeUpdate))
 {
objRow[conViewTypeCodeTab.IsHaveExeUpdate] = objViewTypeCodeTabEN.IsHaveExeUpdate; //是否有调用修改
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveMainView))
 {
objRow[conViewTypeCodeTab.IsHaveMainView] = objViewTypeCodeTabEN.IsHaveMainView; //是否有主界面
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSubView))
 {
objRow[conViewTypeCodeTab.IsHaveSubView] = objViewTypeCodeTabEN.IsHaveSubView; //是否有子界面
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OrderNum))
 {
objRow[conViewTypeCodeTab.OrderNum] = objViewTypeCodeTabEN.OrderNum; //序号
 }
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsUsed))
 {
objRow[conViewTypeCodeTab.IsUsed] = objViewTypeCodeTabEN.IsUsed; //IsUsed
 }
try
{
objDA.Update(objDS, clsViewTypeCodeTabEN._CurrTabName);
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewTypeCodeTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewTypeCodeTab Set ");
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeName))
 {
 if (objViewTypeCodeTabEN.ViewTypeName !=  null)
 {
 var strViewTypeName = objViewTypeCodeTabEN.ViewTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewTypeName, conViewTypeCodeTab.ViewTypeName); //界面类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.ViewTypeName); //界面类型名称
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeENName))
 {
 if (objViewTypeCodeTabEN.ViewTypeENName !=  null)
 {
 var strViewTypeENName = objViewTypeCodeTabEN.ViewTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewTypeENName, conViewTypeCodeTab.ViewTypeENName); //ViewTypeENName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.ViewTypeENName); //ViewTypeENName
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWinApp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsWinApp == true?"1":"0", conViewTypeCodeTab.IsWinApp); //IsWinApp
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsMobileApp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsMobileApp == true?"1":"0", conViewTypeCodeTab.IsMobileApp); //是否移动终端应用
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWebApp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsWebApp == true?"1":"0", conViewTypeCodeTab.IsWebApp); //IsWebApp
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewFunction))
 {
 if (objViewTypeCodeTabEN.ViewFunction !=  null)
 {
 var strViewFunction = objViewTypeCodeTabEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewFunction, conViewTypeCodeTab.ViewFunction); //界面功能
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.ViewFunction); //界面功能
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OptProcess))
 {
 if (objViewTypeCodeTabEN.OptProcess !=  null)
 {
 var strOptProcess = objViewTypeCodeTabEN.OptProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOptProcess, conViewTypeCodeTab.OptProcess); //操作流程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.OptProcess); //操作流程
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewDetail))
 {
 if (objViewTypeCodeTabEN.ViewDetail !=  null)
 {
 var strViewDetail = objViewTypeCodeTabEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewDetail, conViewTypeCodeTab.ViewDetail); //界面说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.ViewDetail); //界面说明
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewTypeCodeTabEN.ApplicationTypeId, conViewTypeCodeTab.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveAdd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveAdd == true?"1":"0", conViewTypeCodeTab.IsHaveAdd); //是否有添加
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveUpdate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveUpdate == true?"1":"0", conViewTypeCodeTab.IsHaveUpdate); //是否有修改
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDel))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveDel == true?"1":"0", conViewTypeCodeTab.IsHaveDel); //是否有删除
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveQuery))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveQuery == true?"1":"0", conViewTypeCodeTab.IsHaveQuery); //是否有查询
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExcelExport))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveExcelExport == true?"1":"0", conViewTypeCodeTab.IsHaveExcelExport); //是否EXCEL导出
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSetExportExcel))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveSetExportExcel == true?"1":"0", conViewTypeCodeTab.IsHaveSetExportExcel); //是否有设置EXCEL导出
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDetail))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveDetail == true?"1":"0", conViewTypeCodeTab.IsHaveDetail); //是否有详细
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeAdd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveExeAdd == true?"1":"0", conViewTypeCodeTab.IsHaveExeAdd); //是否有调用添加
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeUpdate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveExeUpdate == true?"1":"0", conViewTypeCodeTab.IsHaveExeUpdate); //是否有调用修改
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveMainView))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveMainView == true?"1":"0", conViewTypeCodeTab.IsHaveMainView); //是否有主界面
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSubView))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveSubView == true?"1":"0", conViewTypeCodeTab.IsHaveSubView); //是否有子界面
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OrderNum))
 {
 if (objViewTypeCodeTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewTypeCodeTabEN.OrderNum, conViewTypeCodeTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.OrderNum); //序号
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsUsed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsUsed == true?"1":"0", conViewTypeCodeTab.IsUsed); //IsUsed
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewTypeCode = {0}", objViewTypeCodeTabEN.ViewTypeCode); 
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
 /// <param name = "objViewTypeCodeTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strCondition)
{
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewTypeCodeTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewTypeCodeTab Set ");
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeName))
 {
 if (objViewTypeCodeTabEN.ViewTypeName !=  null)
 {
 var strViewTypeName = objViewTypeCodeTabEN.ViewTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewTypeName = '{0}',", strViewTypeName); //界面类型名称
 }
 else
 {
 sbSQL.Append(" ViewTypeName = null,"); //界面类型名称
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeENName))
 {
 if (objViewTypeCodeTabEN.ViewTypeENName !=  null)
 {
 var strViewTypeENName = objViewTypeCodeTabEN.ViewTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewTypeENName = '{0}',", strViewTypeENName); //ViewTypeENName
 }
 else
 {
 sbSQL.Append(" ViewTypeENName = null,"); //ViewTypeENName
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWinApp))
 {
 sbSQL.AppendFormat(" IsWinApp = '{0}',", objViewTypeCodeTabEN.IsWinApp == true?"1":"0"); //IsWinApp
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsMobileApp))
 {
 sbSQL.AppendFormat(" IsMobileApp = '{0}',", objViewTypeCodeTabEN.IsMobileApp == true?"1":"0"); //是否移动终端应用
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWebApp))
 {
 sbSQL.AppendFormat(" IsWebApp = '{0}',", objViewTypeCodeTabEN.IsWebApp == true?"1":"0"); //IsWebApp
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewFunction))
 {
 if (objViewTypeCodeTabEN.ViewFunction !=  null)
 {
 var strViewFunction = objViewTypeCodeTabEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewFunction = '{0}',", strViewFunction); //界面功能
 }
 else
 {
 sbSQL.Append(" ViewFunction = null,"); //界面功能
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OptProcess))
 {
 if (objViewTypeCodeTabEN.OptProcess !=  null)
 {
 var strOptProcess = objViewTypeCodeTabEN.OptProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OptProcess = '{0}',", strOptProcess); //操作流程
 }
 else
 {
 sbSQL.Append(" OptProcess = null,"); //操作流程
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewDetail))
 {
 if (objViewTypeCodeTabEN.ViewDetail !=  null)
 {
 var strViewDetail = objViewTypeCodeTabEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewDetail = '{0}',", strViewDetail); //界面说明
 }
 else
 {
 sbSQL.Append(" ViewDetail = null,"); //界面说明
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objViewTypeCodeTabEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveAdd))
 {
 sbSQL.AppendFormat(" IsHaveAdd = '{0}',", objViewTypeCodeTabEN.IsHaveAdd == true?"1":"0"); //是否有添加
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveUpdate))
 {
 sbSQL.AppendFormat(" IsHaveUpdate = '{0}',", objViewTypeCodeTabEN.IsHaveUpdate == true?"1":"0"); //是否有修改
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDel))
 {
 sbSQL.AppendFormat(" IsHaveDel = '{0}',", objViewTypeCodeTabEN.IsHaveDel == true?"1":"0"); //是否有删除
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveQuery))
 {
 sbSQL.AppendFormat(" IsHaveQuery = '{0}',", objViewTypeCodeTabEN.IsHaveQuery == true?"1":"0"); //是否有查询
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExcelExport))
 {
 sbSQL.AppendFormat(" IsHaveExcelExport = '{0}',", objViewTypeCodeTabEN.IsHaveExcelExport == true?"1":"0"); //是否EXCEL导出
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSetExportExcel))
 {
 sbSQL.AppendFormat(" IsHaveSetExportExcel = '{0}',", objViewTypeCodeTabEN.IsHaveSetExportExcel == true?"1":"0"); //是否有设置EXCEL导出
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDetail))
 {
 sbSQL.AppendFormat(" IsHaveDetail = '{0}',", objViewTypeCodeTabEN.IsHaveDetail == true?"1":"0"); //是否有详细
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeAdd))
 {
 sbSQL.AppendFormat(" IsHaveExeAdd = '{0}',", objViewTypeCodeTabEN.IsHaveExeAdd == true?"1":"0"); //是否有调用添加
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeUpdate))
 {
 sbSQL.AppendFormat(" IsHaveExeUpdate = '{0}',", objViewTypeCodeTabEN.IsHaveExeUpdate == true?"1":"0"); //是否有调用修改
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveMainView))
 {
 sbSQL.AppendFormat(" IsHaveMainView = '{0}',", objViewTypeCodeTabEN.IsHaveMainView == true?"1":"0"); //是否有主界面
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSubView))
 {
 sbSQL.AppendFormat(" IsHaveSubView = '{0}',", objViewTypeCodeTabEN.IsHaveSubView == true?"1":"0"); //是否有子界面
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OrderNum))
 {
 if (objViewTypeCodeTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewTypeCodeTabEN.OrderNum, conViewTypeCodeTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.OrderNum); //序号
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsUsed))
 {
 sbSQL.AppendFormat(" IsUsed = '{0}',", objViewTypeCodeTabEN.IsUsed == true?"1":"0"); //IsUsed
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
 /// <param name = "objViewTypeCodeTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewTypeCodeTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewTypeCodeTab Set ");
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeName))
 {
 if (objViewTypeCodeTabEN.ViewTypeName !=  null)
 {
 var strViewTypeName = objViewTypeCodeTabEN.ViewTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewTypeName = '{0}',", strViewTypeName); //界面类型名称
 }
 else
 {
 sbSQL.Append(" ViewTypeName = null,"); //界面类型名称
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeENName))
 {
 if (objViewTypeCodeTabEN.ViewTypeENName !=  null)
 {
 var strViewTypeENName = objViewTypeCodeTabEN.ViewTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewTypeENName = '{0}',", strViewTypeENName); //ViewTypeENName
 }
 else
 {
 sbSQL.Append(" ViewTypeENName = null,"); //ViewTypeENName
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWinApp))
 {
 sbSQL.AppendFormat(" IsWinApp = '{0}',", objViewTypeCodeTabEN.IsWinApp == true?"1":"0"); //IsWinApp
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsMobileApp))
 {
 sbSQL.AppendFormat(" IsMobileApp = '{0}',", objViewTypeCodeTabEN.IsMobileApp == true?"1":"0"); //是否移动终端应用
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWebApp))
 {
 sbSQL.AppendFormat(" IsWebApp = '{0}',", objViewTypeCodeTabEN.IsWebApp == true?"1":"0"); //IsWebApp
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewFunction))
 {
 if (objViewTypeCodeTabEN.ViewFunction !=  null)
 {
 var strViewFunction = objViewTypeCodeTabEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewFunction = '{0}',", strViewFunction); //界面功能
 }
 else
 {
 sbSQL.Append(" ViewFunction = null,"); //界面功能
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OptProcess))
 {
 if (objViewTypeCodeTabEN.OptProcess !=  null)
 {
 var strOptProcess = objViewTypeCodeTabEN.OptProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OptProcess = '{0}',", strOptProcess); //操作流程
 }
 else
 {
 sbSQL.Append(" OptProcess = null,"); //操作流程
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewDetail))
 {
 if (objViewTypeCodeTabEN.ViewDetail !=  null)
 {
 var strViewDetail = objViewTypeCodeTabEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewDetail = '{0}',", strViewDetail); //界面说明
 }
 else
 {
 sbSQL.Append(" ViewDetail = null,"); //界面说明
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objViewTypeCodeTabEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveAdd))
 {
 sbSQL.AppendFormat(" IsHaveAdd = '{0}',", objViewTypeCodeTabEN.IsHaveAdd == true?"1":"0"); //是否有添加
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveUpdate))
 {
 sbSQL.AppendFormat(" IsHaveUpdate = '{0}',", objViewTypeCodeTabEN.IsHaveUpdate == true?"1":"0"); //是否有修改
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDel))
 {
 sbSQL.AppendFormat(" IsHaveDel = '{0}',", objViewTypeCodeTabEN.IsHaveDel == true?"1":"0"); //是否有删除
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveQuery))
 {
 sbSQL.AppendFormat(" IsHaveQuery = '{0}',", objViewTypeCodeTabEN.IsHaveQuery == true?"1":"0"); //是否有查询
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExcelExport))
 {
 sbSQL.AppendFormat(" IsHaveExcelExport = '{0}',", objViewTypeCodeTabEN.IsHaveExcelExport == true?"1":"0"); //是否EXCEL导出
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSetExportExcel))
 {
 sbSQL.AppendFormat(" IsHaveSetExportExcel = '{0}',", objViewTypeCodeTabEN.IsHaveSetExportExcel == true?"1":"0"); //是否有设置EXCEL导出
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDetail))
 {
 sbSQL.AppendFormat(" IsHaveDetail = '{0}',", objViewTypeCodeTabEN.IsHaveDetail == true?"1":"0"); //是否有详细
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeAdd))
 {
 sbSQL.AppendFormat(" IsHaveExeAdd = '{0}',", objViewTypeCodeTabEN.IsHaveExeAdd == true?"1":"0"); //是否有调用添加
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeUpdate))
 {
 sbSQL.AppendFormat(" IsHaveExeUpdate = '{0}',", objViewTypeCodeTabEN.IsHaveExeUpdate == true?"1":"0"); //是否有调用修改
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveMainView))
 {
 sbSQL.AppendFormat(" IsHaveMainView = '{0}',", objViewTypeCodeTabEN.IsHaveMainView == true?"1":"0"); //是否有主界面
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSubView))
 {
 sbSQL.AppendFormat(" IsHaveSubView = '{0}',", objViewTypeCodeTabEN.IsHaveSubView == true?"1":"0"); //是否有子界面
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OrderNum))
 {
 if (objViewTypeCodeTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewTypeCodeTabEN.OrderNum, conViewTypeCodeTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.OrderNum); //序号
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsUsed))
 {
 sbSQL.AppendFormat(" IsUsed = '{0}',", objViewTypeCodeTabEN.IsUsed == true?"1":"0"); //IsUsed
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewTypeCodeTabEN objViewTypeCodeTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objViewTypeCodeTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewTypeCodeTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewTypeCodeTab Set ");
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeName))
 {
 if (objViewTypeCodeTabEN.ViewTypeName !=  null)
 {
 var strViewTypeName = objViewTypeCodeTabEN.ViewTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewTypeName, conViewTypeCodeTab.ViewTypeName); //界面类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.ViewTypeName); //界面类型名称
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewTypeENName))
 {
 if (objViewTypeCodeTabEN.ViewTypeENName !=  null)
 {
 var strViewTypeENName = objViewTypeCodeTabEN.ViewTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewTypeENName, conViewTypeCodeTab.ViewTypeENName); //ViewTypeENName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.ViewTypeENName); //ViewTypeENName
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWinApp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsWinApp == true?"1":"0", conViewTypeCodeTab.IsWinApp); //IsWinApp
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsMobileApp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsMobileApp == true?"1":"0", conViewTypeCodeTab.IsMobileApp); //是否移动终端应用
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsWebApp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsWebApp == true?"1":"0", conViewTypeCodeTab.IsWebApp); //IsWebApp
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewFunction))
 {
 if (objViewTypeCodeTabEN.ViewFunction !=  null)
 {
 var strViewFunction = objViewTypeCodeTabEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewFunction, conViewTypeCodeTab.ViewFunction); //界面功能
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.ViewFunction); //界面功能
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OptProcess))
 {
 if (objViewTypeCodeTabEN.OptProcess !=  null)
 {
 var strOptProcess = objViewTypeCodeTabEN.OptProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOptProcess, conViewTypeCodeTab.OptProcess); //操作流程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.OptProcess); //操作流程
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ViewDetail))
 {
 if (objViewTypeCodeTabEN.ViewDetail !=  null)
 {
 var strViewDetail = objViewTypeCodeTabEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewDetail, conViewTypeCodeTab.ViewDetail); //界面说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.ViewDetail); //界面说明
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewTypeCodeTabEN.ApplicationTypeId, conViewTypeCodeTab.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveAdd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveAdd == true?"1":"0", conViewTypeCodeTab.IsHaveAdd); //是否有添加
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveUpdate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveUpdate == true?"1":"0", conViewTypeCodeTab.IsHaveUpdate); //是否有修改
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDel))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveDel == true?"1":"0", conViewTypeCodeTab.IsHaveDel); //是否有删除
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveQuery))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveQuery == true?"1":"0", conViewTypeCodeTab.IsHaveQuery); //是否有查询
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExcelExport))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveExcelExport == true?"1":"0", conViewTypeCodeTab.IsHaveExcelExport); //是否EXCEL导出
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSetExportExcel))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveSetExportExcel == true?"1":"0", conViewTypeCodeTab.IsHaveSetExportExcel); //是否有设置EXCEL导出
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveDetail))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveDetail == true?"1":"0", conViewTypeCodeTab.IsHaveDetail); //是否有详细
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeAdd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveExeAdd == true?"1":"0", conViewTypeCodeTab.IsHaveExeAdd); //是否有调用添加
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveExeUpdate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveExeUpdate == true?"1":"0", conViewTypeCodeTab.IsHaveExeUpdate); //是否有调用修改
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveMainView))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveMainView == true?"1":"0", conViewTypeCodeTab.IsHaveMainView); //是否有主界面
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsHaveSubView))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsHaveSubView == true?"1":"0", conViewTypeCodeTab.IsHaveSubView); //是否有子界面
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.OrderNum))
 {
 if (objViewTypeCodeTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewTypeCodeTabEN.OrderNum, conViewTypeCodeTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewTypeCodeTab.OrderNum); //序号
 }
 }
 
 if (objViewTypeCodeTabEN.IsUpdated(conViewTypeCodeTab.IsUsed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewTypeCodeTabEN.IsUsed == true?"1":"0", conViewTypeCodeTab.IsUsed); //IsUsed
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewTypeCode = {0}", objViewTypeCodeTabEN.ViewTypeCode); 
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
 /// <param name = "intViewTypeCode">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(int intViewTypeCode) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 intViewTypeCode,
};
 objSQL.ExecSP("ViewTypeCodeTab_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "intViewTypeCode">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(int intViewTypeCode, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
//删除ViewTypeCodeTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewTypeCodeTab where ViewTypeCode = " + ""+ intViewTypeCode+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewTypeCodeTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
//删除ViewTypeCodeTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewTypeCodeTab where ViewTypeCode in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "intViewTypeCode">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(int intViewTypeCode) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
//删除ViewTypeCodeTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewTypeCodeTab where ViewTypeCode = " + ""+ intViewTypeCode+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewTypeCodeTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: DelViewTypeCodeTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewTypeCodeTab where " + strCondition ;
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
public bool DelViewTypeCodeTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewTypeCodeTabDA: DelViewTypeCodeTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewTypeCodeTab where " + strCondition ;
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
 /// <param name = "objViewTypeCodeTabENS">源对象</param>
 /// <param name = "objViewTypeCodeTabENT">目标对象</param>
public void CopyTo(clsViewTypeCodeTabEN objViewTypeCodeTabENS, clsViewTypeCodeTabEN objViewTypeCodeTabENT)
{
objViewTypeCodeTabENT.ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objViewTypeCodeTabENT.ViewTypeName = objViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objViewTypeCodeTabENT.ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objViewTypeCodeTabENT.IsWinApp = objViewTypeCodeTabENS.IsWinApp; //IsWinApp
objViewTypeCodeTabENT.IsMobileApp = objViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objViewTypeCodeTabENT.IsWebApp = objViewTypeCodeTabENS.IsWebApp; //IsWebApp
objViewTypeCodeTabENT.ViewFunction = objViewTypeCodeTabENS.ViewFunction; //界面功能
objViewTypeCodeTabENT.OptProcess = objViewTypeCodeTabENS.OptProcess; //操作流程
objViewTypeCodeTabENT.ViewDetail = objViewTypeCodeTabENS.ViewDetail; //界面说明
objViewTypeCodeTabENT.ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objViewTypeCodeTabENT.IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objViewTypeCodeTabENT.IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objViewTypeCodeTabENT.IsHaveDel = objViewTypeCodeTabENS.IsHaveDel; //是否有删除
objViewTypeCodeTabENT.IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objViewTypeCodeTabENT.IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objViewTypeCodeTabENT.IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objViewTypeCodeTabENT.IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objViewTypeCodeTabENT.IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objViewTypeCodeTabENT.IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objViewTypeCodeTabENT.IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objViewTypeCodeTabENT.IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objViewTypeCodeTabENT.OrderNum = objViewTypeCodeTabENS.OrderNum; //序号
objViewTypeCodeTabENT.IsUsed = objViewTypeCodeTabENS.IsUsed; //IsUsed
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.ViewTypeName, conViewTypeCodeTab.ViewTypeName);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.ApplicationTypeId, conViewTypeCodeTab.ApplicationTypeId);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveAdd, conViewTypeCodeTab.IsHaveAdd);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveUpdate, conViewTypeCodeTab.IsHaveUpdate);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveDel, conViewTypeCodeTab.IsHaveDel);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveQuery, conViewTypeCodeTab.IsHaveQuery);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveExcelExport, conViewTypeCodeTab.IsHaveExcelExport);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveSetExportExcel, conViewTypeCodeTab.IsHaveSetExportExcel);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveDetail, conViewTypeCodeTab.IsHaveDetail);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveExeAdd, conViewTypeCodeTab.IsHaveExeAdd);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveExeUpdate, conViewTypeCodeTab.IsHaveExeUpdate);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveMainView, conViewTypeCodeTab.IsHaveMainView);
clsCheckSql.CheckFieldNotNull(objViewTypeCodeTabEN.IsHaveSubView, conViewTypeCodeTab.IsHaveSubView);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewTypeName, 40, conViewTypeCodeTab.ViewTypeName);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewTypeENName, 40, conViewTypeCodeTab.ViewTypeENName);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewFunction, 100, conViewTypeCodeTab.ViewFunction);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.OptProcess, 1000, conViewTypeCodeTab.OptProcess);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewDetail, 1000, conViewTypeCodeTab.ViewDetail);
//检查字段外键固定长度
 objViewTypeCodeTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewTypeName, 40, conViewTypeCodeTab.ViewTypeName);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewTypeENName, 40, conViewTypeCodeTab.ViewTypeENName);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewFunction, 100, conViewTypeCodeTab.ViewFunction);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.OptProcess, 1000, conViewTypeCodeTab.OptProcess);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewDetail, 1000, conViewTypeCodeTab.ViewDetail);
//检查外键字段长度
 objViewTypeCodeTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewTypeName, 40, conViewTypeCodeTab.ViewTypeName);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewTypeENName, 40, conViewTypeCodeTab.ViewTypeENName);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewFunction, 100, conViewTypeCodeTab.ViewFunction);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.OptProcess, 1000, conViewTypeCodeTab.OptProcess);
clsCheckSql.CheckFieldLen(objViewTypeCodeTabEN.ViewDetail, 1000, conViewTypeCodeTab.ViewDetail);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewTypeCodeTabEN.ViewTypeName, conViewTypeCodeTab.ViewTypeName);
clsCheckSql.CheckSqlInjection4Field(objViewTypeCodeTabEN.ViewTypeENName, conViewTypeCodeTab.ViewTypeENName);
clsCheckSql.CheckSqlInjection4Field(objViewTypeCodeTabEN.ViewFunction, conViewTypeCodeTab.ViewFunction);
clsCheckSql.CheckSqlInjection4Field(objViewTypeCodeTabEN.OptProcess, conViewTypeCodeTab.OptProcess);
clsCheckSql.CheckSqlInjection4Field(objViewTypeCodeTabEN.ViewDetail, conViewTypeCodeTab.ViewDetail);
//检查外键字段长度
 objViewTypeCodeTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetViewTypeCode()
{
//获取某学院所有专业信息
string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
 clsSpecSQLforSql mySql = clsViewTypeCodeTabDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewTypeCodeTab(界面类型码),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewTypeName = '{0}'", objViewTypeCodeTabEN.ViewTypeName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewTypeCodeTabEN.ApplicationTypeId);
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
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewTypeCodeTabEN._CurrTabName);
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
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewTypeCodeTabEN._CurrTabName, strCondition);
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
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
 objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}