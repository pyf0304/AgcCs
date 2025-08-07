
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewTypeCodeTabDA
 表名:vViewTypeCodeTab(00050133)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:46:57
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
 /// v界面类型码(vViewTypeCodeTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewTypeCodeTabDA : clsCommBase4DA
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
 return clsvViewTypeCodeTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewTypeCodeTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewTypeCodeTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewTypeCodeTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewTypeCodeTabEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from vViewTypeCodeTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewTypeCodeTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetDataTable_vViewTypeCodeTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from vViewTypeCodeTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from vViewTypeCodeTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewTypeCodeTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewTypeCodeTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewTypeCodeTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewTypeCodeTab.* " + 
$"from vViewTypeCodeTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewTypeCodeTab.ViewTypeCode not in " + 
$"(Select top {intTop_In} vViewTypeCodeTab.ViewTypeCode from vViewTypeCodeTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewTypeCodeTab where {1} and ViewTypeCode not in (Select top {2} ViewTypeCode from vViewTypeCodeTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewTypeCodeTab where {1} and ViewTypeCode not in (Select top {3} ViewTypeCode from vViewTypeCodeTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewTypeCodeTab.* " + 
$"from vViewTypeCodeTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewTypeCodeTab.ViewTypeCode not in " + 
$"(Select top {intTop_In} vViewTypeCodeTab.ViewTypeCode from vViewTypeCodeTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewTypeCodeTab where {1} and ViewTypeCode not in (Select top {2} ViewTypeCode from vViewTypeCodeTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewTypeCodeTab where {1} and ViewTypeCode not in (Select top {3} ViewTypeCode from vViewTypeCodeTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewTypeCodeTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA:GetObjLst)", objException.Message));
}
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from vViewTypeCodeTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = TransNullToBool(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewTypeCodeTabDA: GetObjLst)", objException.Message));
}
objvViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewTypeCodeTabEN);
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
public List<clsvViewTypeCodeTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewTypeCodeTabEN> arrObjLst = new List<clsvViewTypeCodeTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = TransNullToBool(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewTypeCodeTabDA: GetObjLst)", objException.Message));
}
objvViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewTypeCodeTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewTypeCodeTab(ref clsvViewTypeCodeTabEN objvViewTypeCodeTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from vViewTypeCodeTab where ViewTypeCode = " + ""+ objvViewTypeCodeTabEN.ViewTypeCode+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objDT.Rows[0][convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objvViewTypeCodeTabEN.ViewTypeName = objDT.Rows[0][convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称(字段类型:varchar,字段长度:40,是否可空:False)
 objvViewTypeCodeTabEN.ViewTypeENName = objDT.Rows[0][convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewTypeCodeTabEN.IsWinApp = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.IsWebApp = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.ViewFunction = objDT.Rows[0][convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewTypeCodeTabEN.OptProcess = objDT.Rows[0][convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewTypeCodeTabEN.ViewDetail = objDT.Rows[0][convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewTypeCodeTabEN.ApplicationTypeName = objDT.Rows[0][convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.OrderNum = TransNullToInt(objDT.Rows[0][convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvViewTypeCodeTabEN.IsUsed = TransNullToBool(objDT.Rows[0][convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewTypeCodeTabDA: GetvViewTypeCodeTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "intViewTypeCode">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewTypeCodeTabEN GetObjByViewTypeCode(int intViewTypeCode)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from vViewTypeCodeTab where ViewTypeCode = " + ""+ intViewTypeCode+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
 objvViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称(字段类型:varchar,字段长度:40,是否可空:False)
 objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改(字段类型:bit,字段长度:1,是否可空:True)
 objvViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面(字段类型:bit,字段长度:1,是否可空:False)
 objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewTypeCodeTabDA: GetObjByViewTypeCode)", objException.Message));
}
return objvViewTypeCodeTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewTypeCodeTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
strSQL = "Select * from vViewTypeCodeTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN()
{
ViewTypeCode = TransNullToInt(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()), //界面类型码
ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(), //界面类型名称
ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(), //ViewTypeENName
IsWinApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()), //IsWinApp
IsMobileApp = TransNullToBool(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()), //是否移动终端应用
IsWebApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()), //IsWebApp
ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(), //界面功能
OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(), //操作流程
ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(), //界面说明
ApplicationTypeId = TransNullToInt(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
IsHaveAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()), //是否有添加
IsHaveUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()), //是否有修改
IsHaveDel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()), //是否有删除
IsHaveQuery = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()), //是否有查询
IsHaveExcelExport = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()), //是否EXCEL导出
IsHaveSetExportExcel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()), //是否有设置EXCEL导出
IsHaveDetail = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()), //是否有详细
IsHaveExeAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()), //是否有调用添加
IsHaveExeUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()), //是否有调用修改
IsHaveMainView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()), //是否有主界面
IsHaveSubView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()), //是否有子界面
OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()), //序号
IsUsed = TransNullToBool(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()) //IsUsed
};
objvViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewTypeCodeTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewTypeCodeTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewTypeCodeTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = TransNullToBool(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewTypeCodeTabDA: GetObjByDataRowvViewTypeCodeTab)", objException.Message));
}
objvViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewTypeCodeTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewTypeCodeTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewTypeCodeTabEN objvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
try
{
objvViewTypeCodeTabEN.ViewTypeCode = TransNullToInt(objRow[convViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewTypeCodeTabEN.ViewTypeName = objRow[convViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewTypeCodeTabEN.ViewTypeENName = objRow[convViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objvViewTypeCodeTabEN.IsWinApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objvViewTypeCodeTabEN.IsMobileApp = TransNullToBool(objRow[convViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvViewTypeCodeTabEN.IsWebApp = TransNullToBool(objRow[convViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objvViewTypeCodeTabEN.ViewFunction = objRow[convViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objvViewTypeCodeTabEN.OptProcess = objRow[convViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[convViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objvViewTypeCodeTabEN.ViewDetail = objRow[convViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[convViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objvViewTypeCodeTabEN.ApplicationTypeId = TransNullToInt(objRow[convViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewTypeCodeTabEN.ApplicationTypeName = objRow[convViewTypeCodeTab.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewTypeCodeTabEN.IsHaveAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objvViewTypeCodeTabEN.IsHaveUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objvViewTypeCodeTabEN.IsHaveDel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objvViewTypeCodeTabEN.IsHaveQuery = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objvViewTypeCodeTabEN.IsHaveExcelExport = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objvViewTypeCodeTabEN.IsHaveSetExportExcel = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objvViewTypeCodeTabEN.IsHaveDetail = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objvViewTypeCodeTabEN.IsHaveExeAdd = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objvViewTypeCodeTabEN.IsHaveExeUpdate = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objvViewTypeCodeTabEN.IsHaveMainView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objvViewTypeCodeTabEN.IsHaveSubView = TransNullToBool(objRow[convViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objvViewTypeCodeTabEN.OrderNum = objRow[convViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objvViewTypeCodeTabEN.IsUsed = TransNullToBool(objRow[convViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewTypeCodeTabDA: GetObjByDataRow)", objException.Message));
}
objvViewTypeCodeTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewTypeCodeTabEN;
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
objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewTypeCodeTabEN._CurrTabName, convViewTypeCodeTab.ViewTypeCode, 4, "");
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
objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewTypeCodeTabEN._CurrTabName, convViewTypeCodeTab.ViewTypeCode, 4, strPrefix);
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
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewTypeCode from vViewTypeCodeTab where " + strCondition;
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
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewTypeCode from vViewTypeCodeTab where " + strCondition;
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
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewTypeCodeTab", "ViewTypeCode = " + ""+ intViewTypeCode+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewTypeCodeTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewTypeCodeTab", strCondition))
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
objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewTypeCodeTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabENS">源对象</param>
 /// <param name = "objvViewTypeCodeTabENT">目标对象</param>
public void CopyTo(clsvViewTypeCodeTabEN objvViewTypeCodeTabENS, clsvViewTypeCodeTabEN objvViewTypeCodeTabENT)
{
objvViewTypeCodeTabENT.ViewTypeCode = objvViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objvViewTypeCodeTabENT.ViewTypeName = objvViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objvViewTypeCodeTabENT.ViewTypeENName = objvViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objvViewTypeCodeTabENT.IsWinApp = objvViewTypeCodeTabENS.IsWinApp; //IsWinApp
objvViewTypeCodeTabENT.IsMobileApp = objvViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objvViewTypeCodeTabENT.IsWebApp = objvViewTypeCodeTabENS.IsWebApp; //IsWebApp
objvViewTypeCodeTabENT.ViewFunction = objvViewTypeCodeTabENS.ViewFunction; //界面功能
objvViewTypeCodeTabENT.OptProcess = objvViewTypeCodeTabENS.OptProcess; //操作流程
objvViewTypeCodeTabENT.ViewDetail = objvViewTypeCodeTabENS.ViewDetail; //界面说明
objvViewTypeCodeTabENT.ApplicationTypeId = objvViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objvViewTypeCodeTabENT.ApplicationTypeName = objvViewTypeCodeTabENS.ApplicationTypeName; //应用程序类型名称
objvViewTypeCodeTabENT.IsHaveAdd = objvViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objvViewTypeCodeTabENT.IsHaveUpdate = objvViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objvViewTypeCodeTabENT.IsHaveDel = objvViewTypeCodeTabENS.IsHaveDel; //是否有删除
objvViewTypeCodeTabENT.IsHaveQuery = objvViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objvViewTypeCodeTabENT.IsHaveExcelExport = objvViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objvViewTypeCodeTabENT.IsHaveSetExportExcel = objvViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objvViewTypeCodeTabENT.IsHaveDetail = objvViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objvViewTypeCodeTabENT.IsHaveExeAdd = objvViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objvViewTypeCodeTabENT.IsHaveExeUpdate = objvViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objvViewTypeCodeTabENT.IsHaveMainView = objvViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objvViewTypeCodeTabENT.IsHaveSubView = objvViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objvViewTypeCodeTabENT.OrderNum = objvViewTypeCodeTabENS.OrderNum; //序号
objvViewTypeCodeTabENT.IsUsed = objvViewTypeCodeTabENS.IsUsed; //IsUsed
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewTypeCodeTabEN objvViewTypeCodeTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewTypeCodeTabEN.ViewTypeName, 40, convViewTypeCodeTab.ViewTypeName);
clsCheckSql.CheckFieldLen(objvViewTypeCodeTabEN.ViewTypeENName, 40, convViewTypeCodeTab.ViewTypeENName);
clsCheckSql.CheckFieldLen(objvViewTypeCodeTabEN.ViewFunction, 100, convViewTypeCodeTab.ViewFunction);
clsCheckSql.CheckFieldLen(objvViewTypeCodeTabEN.OptProcess, 1000, convViewTypeCodeTab.OptProcess);
clsCheckSql.CheckFieldLen(objvViewTypeCodeTabEN.ViewDetail, 1000, convViewTypeCodeTab.ViewDetail);
clsCheckSql.CheckFieldLen(objvViewTypeCodeTabEN.ApplicationTypeName, 30, convViewTypeCodeTab.ApplicationTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewTypeCodeTabEN.ViewTypeName, convViewTypeCodeTab.ViewTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewTypeCodeTabEN.ViewTypeENName, convViewTypeCodeTab.ViewTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvViewTypeCodeTabEN.ViewFunction, convViewTypeCodeTab.ViewFunction);
clsCheckSql.CheckSqlInjection4Field(objvViewTypeCodeTabEN.OptProcess, convViewTypeCodeTab.OptProcess);
clsCheckSql.CheckSqlInjection4Field(objvViewTypeCodeTabEN.ViewDetail, convViewTypeCodeTab.ViewDetail);
clsCheckSql.CheckSqlInjection4Field(objvViewTypeCodeTabEN.ApplicationTypeName, convViewTypeCodeTab.ApplicationTypeName);
//检查外键字段长度
 objvViewTypeCodeTabEN._IsCheckProperty = true;
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
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
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
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
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
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewTypeCodeTabEN._CurrTabName);
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
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewTypeCodeTabEN._CurrTabName, strCondition);
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
 objSQL = clsvViewTypeCodeTabDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}