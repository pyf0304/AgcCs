
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfo4GeneCodeDA
 表名:vViewInfo4GeneCode(00050283)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// vViewInfo4GeneCode(vViewInfo4GeneCode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewInfo4GeneCodeDA : clsCommBase4DA
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
 return clsvViewInfo4GeneCodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewInfo4GeneCodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewInfo4GeneCodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewInfo4GeneCodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewInfo4GeneCodeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strViewId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strViewId)
{
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vViewInfo4GeneCode中,检查关键字,长度不正确!(clsvViewInfo4GeneCodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vViewInfo4GeneCode中,关键字不能为空 或 null!(clsvViewInfo4GeneCodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvViewInfo4GeneCodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewInfo4GeneCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetDataTable_vViewInfo4GeneCode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo4GeneCode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo4GeneCode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewInfo4GeneCode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewInfo4GeneCode.* " + 
$"from vViewInfo4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewInfo4GeneCode.ViewId not in " + 
$"(Select top {intTop_In} vViewInfo4GeneCode.ViewId from vViewInfo4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo4GeneCode where {1} and ViewId not in (Select top {2} ViewId from vViewInfo4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo4GeneCode where {1} and ViewId not in (Select top {3} ViewId from vViewInfo4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewInfo4GeneCode.* " + 
$"from vViewInfo4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewInfo4GeneCode.ViewId not in " + 
$"(Select top {intTop_In} vViewInfo4GeneCode.ViewId from vViewInfo4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo4GeneCode where {1} and ViewId not in (Select top {2} ViewId from vViewInfo4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo4GeneCode where {1} and ViewId not in (Select top {3} ViewId from vViewInfo4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewInfo4GeneCodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA:GetObjLst)", objException.Message));
}
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = TransNullToInt(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewInfo4GeneCodeDA: GetObjLst)", objException.Message));
}
objvViewInfo4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
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
public List<clsvViewInfo4GeneCodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewInfo4GeneCodeEN> arrObjLst = new List<clsvViewInfo4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = TransNullToInt(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewInfo4GeneCodeDA: GetObjLst)", objException.Message));
}
objvViewInfo4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewInfo4GeneCodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewInfo4GeneCode(ref clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo4GeneCode where ViewId = " + "'"+ objvViewInfo4GeneCodeEN.ViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewInfo4GeneCodeEN.ViewId = objDT.Rows[0][convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewInfo4GeneCodeEN.TitleStyleId = objDT.Rows[0][convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvViewInfo4GeneCodeEN.TitleStyleName = objDT.Rows[0][convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvViewInfo4GeneCodeEN.DgStyleId = objDT.Rows[0][convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvViewInfo4GeneCodeEN.DgStyleName = objDT.Rows[0][convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.VersionGeneCode = objDT.Rows[0][convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewName = objDT.Rows[0][convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewTypeCode = TransNullToInt(objDT.Rows[0][convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewTypeName = objDT.Rows[0][convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称(字段类型:varchar,字段长度:40,是否可空:False)
 objvViewInfo4GeneCodeEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewInfo4GeneCodeEN.ApplicationTypeName = objDT.Rows[0][convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.FuncModuleAgcId = objDT.Rows[0][convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvViewInfo4GeneCodeEN.FuncModuleName = objDT.Rows[0][convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.FuncModuleEnName = objDT.Rows[0][convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewInfo4GeneCodeEN.DataBaseName = objDT.Rows[0][convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewInfo4GeneCodeEN.KeyForMainTab = objDT.Rows[0][convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfo4GeneCodeEN.KeyForDetailTab = objDT.Rows[0][convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfo4GeneCodeEN.IsNeedSort = TransNullToBool(objDT.Rows[0][convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfo4GeneCodeEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfo4GeneCodeEN.UserId = objDT.Rows[0][convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvViewInfo4GeneCodeEN.PrjId = objDT.Rows[0][convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewInfo4GeneCodeEN.PrjName = objDT.Rows[0][convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewFunction = objDT.Rows[0][convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfo4GeneCodeEN.ViewDetail = objDT.Rows[0][convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewInfo4GeneCodeEN.DefaMenuName = objDT.Rows[0][convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewInfo4GeneCodeEN.DetailTabId = objDT.Rows[0][convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objvViewInfo4GeneCodeEN.FileName = objDT.Rows[0][convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewInfo4GeneCodeEN.FilePath = objDT.Rows[0][convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewInfo4GeneCodeEN.MainTabId = objDT.Rows[0][convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objvViewInfo4GeneCodeEN.ViewCnName = objDT.Rows[0][convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfo4GeneCodeEN.ViewGroupId = objDT.Rows[0][convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewGroupName = objDT.Rows[0][convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.InSqlDsTypeId = objDT.Rows[0][convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objDT.Rows[0][convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewInfo4GeneCodeEN.GeneCodeDate = objDT.Rows[0][convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfo4GeneCodeEN.RegionNum = TransNullToInt(objDT.Rows[0][convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数(字段类型:int,字段长度:4,是否可空:True)
 objvViewInfo4GeneCodeEN.UpdDate = objDT.Rows[0][convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfo4GeneCodeEN.MainTabName = objDT.Rows[0][convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfo4GeneCodeEN.DetailTabName = objDT.Rows[0][convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewInfo4GeneCodeEN.MainTabKeyFld = objDT.Rows[0][convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfo4GeneCodeEN.DetailTabKeyFld = objDT.Rows[0][convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfo4GeneCodeEN.UserId4GeneCode = objDT.Rows[0][convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewInfo4GeneCodeDA: GetvViewInfo4GeneCode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewInfo4GeneCodeEN GetObjByViewId(string strViewId)
{
CheckPrimaryKey(strViewId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo4GeneCode where ViewId = " + "'"+ strViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
 objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewTypeCode = Int32.Parse(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称(字段类型:varchar,字段长度:40,是否可空:False)
 objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfo4GeneCodeEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfo4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数(字段类型:int,字段长度:4,是否可空:True)
 objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewInfo4GeneCodeDA: GetObjByViewId)", objException.Message));
}
return objvViewInfo4GeneCodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewInfo4GeneCodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN()
{
ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(), //界面Id
TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(), //标题类型Id
TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(), //标题类型名
DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(), //DG模式ID
DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(), //DG模式名
VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(), //生成代码版本
ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(), //界面名称
ViewTypeCode = TransNullToInt(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()), //界面类型码
ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(), //界面类型名称
ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(), //数据库名
KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(), //主表关键字
KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(), //明细表关键字
IsNeedSort = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()), //是否需要排序
IsNeedTransCode = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(), //用户Id
PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(), //工程名称
ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(), //界面功能
ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(), //界面说明
DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(), //缺省菜单名
DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(), //明细表ID
FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(), //文件名
FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(), //文件路径
MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(), //主表ID
ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(), //视图中文名
ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(), //界面组ID
ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(), //界面组名称
InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(), //输入数据源类型
OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(), //输出数据源类型
GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(), //生成代码日期
RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()), //区域数
UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(), //修改日期
MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(), //主表
DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(), //详细表
MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(), //主表关键字
DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(), //详细表关键字
UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim() //UserId4GeneCode
};
objvViewInfo4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewInfo4GeneCodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewInfo4GeneCodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewInfo4GeneCodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = TransNullToInt(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewInfo4GeneCodeDA: GetObjByDataRowvViewInfo4GeneCode)", objException.Message));
}
objvViewInfo4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewInfo4GeneCodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewInfo4GeneCodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
try
{
objvViewInfo4GeneCodeEN.ViewId = objRow[convViewInfo4GeneCode.ViewId].ToString().Trim(); //界面Id
objvViewInfo4GeneCodeEN.TitleStyleId = objRow[convViewInfo4GeneCode.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfo4GeneCodeEN.TitleStyleName = objRow[convViewInfo4GeneCode.TitleStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfo4GeneCodeEN.DgStyleId = objRow[convViewInfo4GeneCode.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfo4GeneCodeEN.DgStyleName = objRow[convViewInfo4GeneCode.DgStyleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfo4GeneCodeEN.VersionGeneCode = objRow[convViewInfo4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvViewInfo4GeneCodeEN.ViewName = objRow[convViewInfo4GeneCode.ViewName].ToString().Trim(); //界面名称
objvViewInfo4GeneCodeEN.ViewTypeCode = TransNullToInt(objRow[convViewInfo4GeneCode.ViewTypeCode].ToString().Trim()); //界面类型码
objvViewInfo4GeneCodeEN.ViewTypeName = objRow[convViewInfo4GeneCode.ViewTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewTypeName].ToString().Trim(); //界面类型名称
objvViewInfo4GeneCodeEN.ApplicationTypeId = objRow[convViewInfo4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfo4GeneCodeEN.ApplicationTypeName = objRow[convViewInfo4GeneCode.ApplicationTypeName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewInfo4GeneCodeEN.FuncModuleAgcId = objRow[convViewInfo4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfo4GeneCodeEN.FuncModuleName = objRow[convViewInfo4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfo4GeneCodeEN.FuncModuleEnName = objRow[convViewInfo4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfo4GeneCodeEN.DataBaseName = objRow[convViewInfo4GeneCode.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DataBaseName].ToString().Trim(); //数据库名
objvViewInfo4GeneCodeEN.KeyForMainTab = objRow[convViewInfo4GeneCode.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.KeyForDetailTab = objRow[convViewInfo4GeneCode.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfo4GeneCodeEN.IsNeedSort = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfo4GeneCodeEN.IsNeedTransCode = TransNullToBool(objRow[convViewInfo4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfo4GeneCodeEN.UserId = objRow[convViewInfo4GeneCode.UserId].ToString().Trim(); //用户Id
objvViewInfo4GeneCodeEN.PrjId = objRow[convViewInfo4GeneCode.PrjId].ToString().Trim(); //工程Id
objvViewInfo4GeneCodeEN.PrjName = objRow[convViewInfo4GeneCode.PrjName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.PrjName].ToString().Trim(); //工程名称
objvViewInfo4GeneCodeEN.ViewFunction = objRow[convViewInfo4GeneCode.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewFunction].ToString().Trim(); //界面功能
objvViewInfo4GeneCodeEN.ViewDetail = objRow[convViewInfo4GeneCode.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewDetail].ToString().Trim(); //界面说明
objvViewInfo4GeneCodeEN.DefaMenuName = objRow[convViewInfo4GeneCode.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfo4GeneCodeEN.DetailTabId = objRow[convViewInfo4GeneCode.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfo4GeneCodeEN.FileName = objRow[convViewInfo4GeneCode.FileName].ToString().Trim(); //文件名
objvViewInfo4GeneCodeEN.FilePath = objRow[convViewInfo4GeneCode.FilePath].ToString().Trim(); //文件路径
objvViewInfo4GeneCodeEN.MainTabId = objRow[convViewInfo4GeneCode.MainTabId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabId].ToString().Trim(); //主表ID
objvViewInfo4GeneCodeEN.ViewCnName = objRow[convViewInfo4GeneCode.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfo4GeneCodeEN.ViewGroupId = objRow[convViewInfo4GeneCode.ViewGroupId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfo4GeneCodeEN.ViewGroupName = objRow[convViewInfo4GeneCode.ViewGroupName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfo4GeneCodeEN.InSqlDsTypeId = objRow[convViewInfo4GeneCode.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfo4GeneCodeEN.OutSqlDsTypeId = objRow[convViewInfo4GeneCode.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfo4GeneCodeEN.GeneCodeDate = objRow[convViewInfo4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfo4GeneCodeEN.RegionNum = objRow[convViewInfo4GeneCode.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo4GeneCode.RegionNum].ToString().Trim()); //区域数
objvViewInfo4GeneCodeEN.UpdDate = objRow[convViewInfo4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvViewInfo4GeneCodeEN.MainTabName = objRow[convViewInfo4GeneCode.MainTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabName].ToString().Trim(); //主表
objvViewInfo4GeneCodeEN.DetailTabName = objRow[convViewInfo4GeneCode.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabName].ToString().Trim(); //详细表
objvViewInfo4GeneCodeEN.MainTabKeyFld = objRow[convViewInfo4GeneCode.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfo4GeneCodeEN.DetailTabKeyFld = objRow[convViewInfo4GeneCode.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.DetailTabKeyFld].ToString().Trim(); //详细表关键字
objvViewInfo4GeneCodeEN.UserId4GeneCode = objRow[convViewInfo4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convViewInfo4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewInfo4GeneCodeDA: GetObjByDataRow)", objException.Message));
}
objvViewInfo4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewInfo4GeneCodeEN;
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
objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewInfo4GeneCodeEN._CurrTabName, convViewInfo4GeneCode.ViewId, 8, "");
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
objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewInfo4GeneCodeEN._CurrTabName, convViewInfo4GeneCode.ViewId, 8, strPrefix);
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
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewId from vViewInfo4GeneCode where " + strCondition;
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
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewId from vViewInfo4GeneCode where " + strCondition;
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strViewId)
{
CheckPrimaryKey(strViewId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewInfo4GeneCode", "ViewId = " + "'"+ strViewId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewInfo4GeneCode", strCondition))
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
objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewInfo4GeneCode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeENS">源对象</param>
 /// <param name = "objvViewInfo4GeneCodeENT">目标对象</param>
public void CopyTo(clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeENS, clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeENT)
{
objvViewInfo4GeneCodeENT.ViewId = objvViewInfo4GeneCodeENS.ViewId; //界面Id
objvViewInfo4GeneCodeENT.TitleStyleId = objvViewInfo4GeneCodeENS.TitleStyleId; //标题类型Id
objvViewInfo4GeneCodeENT.TitleStyleName = objvViewInfo4GeneCodeENS.TitleStyleName; //标题类型名
objvViewInfo4GeneCodeENT.DgStyleId = objvViewInfo4GeneCodeENS.DgStyleId; //DG模式ID
objvViewInfo4GeneCodeENT.DgStyleName = objvViewInfo4GeneCodeENS.DgStyleName; //DG模式名
objvViewInfo4GeneCodeENT.VersionGeneCode = objvViewInfo4GeneCodeENS.VersionGeneCode; //生成代码版本
objvViewInfo4GeneCodeENT.ViewName = objvViewInfo4GeneCodeENS.ViewName; //界面名称
objvViewInfo4GeneCodeENT.ViewTypeCode = objvViewInfo4GeneCodeENS.ViewTypeCode; //界面类型码
objvViewInfo4GeneCodeENT.ViewTypeName = objvViewInfo4GeneCodeENS.ViewTypeName; //界面类型名称
objvViewInfo4GeneCodeENT.ApplicationTypeId = objvViewInfo4GeneCodeENS.ApplicationTypeId; //应用程序类型ID
objvViewInfo4GeneCodeENT.ApplicationTypeName = objvViewInfo4GeneCodeENS.ApplicationTypeName; //应用程序类型名称
objvViewInfo4GeneCodeENT.FuncModuleAgcId = objvViewInfo4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvViewInfo4GeneCodeENT.FuncModuleName = objvViewInfo4GeneCodeENS.FuncModuleName; //功能模块名称
objvViewInfo4GeneCodeENT.FuncModuleEnName = objvViewInfo4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvViewInfo4GeneCodeENT.DataBaseName = objvViewInfo4GeneCodeENS.DataBaseName; //数据库名
objvViewInfo4GeneCodeENT.KeyForMainTab = objvViewInfo4GeneCodeENS.KeyForMainTab; //主表关键字
objvViewInfo4GeneCodeENT.KeyForDetailTab = objvViewInfo4GeneCodeENS.KeyForDetailTab; //明细表关键字
objvViewInfo4GeneCodeENT.IsNeedSort = objvViewInfo4GeneCodeENS.IsNeedSort; //是否需要排序
objvViewInfo4GeneCodeENT.IsNeedTransCode = objvViewInfo4GeneCodeENS.IsNeedTransCode; //是否需要转换代码
objvViewInfo4GeneCodeENT.UserId = objvViewInfo4GeneCodeENS.UserId; //用户Id
objvViewInfo4GeneCodeENT.PrjId = objvViewInfo4GeneCodeENS.PrjId; //工程Id
objvViewInfo4GeneCodeENT.PrjName = objvViewInfo4GeneCodeENS.PrjName; //工程名称
objvViewInfo4GeneCodeENT.ViewFunction = objvViewInfo4GeneCodeENS.ViewFunction; //界面功能
objvViewInfo4GeneCodeENT.ViewDetail = objvViewInfo4GeneCodeENS.ViewDetail; //界面说明
objvViewInfo4GeneCodeENT.DefaMenuName = objvViewInfo4GeneCodeENS.DefaMenuName; //缺省菜单名
objvViewInfo4GeneCodeENT.DetailTabId = objvViewInfo4GeneCodeENS.DetailTabId; //明细表ID
objvViewInfo4GeneCodeENT.FileName = objvViewInfo4GeneCodeENS.FileName; //文件名
objvViewInfo4GeneCodeENT.FilePath = objvViewInfo4GeneCodeENS.FilePath; //文件路径
objvViewInfo4GeneCodeENT.MainTabId = objvViewInfo4GeneCodeENS.MainTabId; //主表ID
objvViewInfo4GeneCodeENT.ViewCnName = objvViewInfo4GeneCodeENS.ViewCnName; //视图中文名
objvViewInfo4GeneCodeENT.ViewGroupId = objvViewInfo4GeneCodeENS.ViewGroupId; //界面组ID
objvViewInfo4GeneCodeENT.ViewGroupName = objvViewInfo4GeneCodeENS.ViewGroupName; //界面组名称
objvViewInfo4GeneCodeENT.InSqlDsTypeId = objvViewInfo4GeneCodeENS.InSqlDsTypeId; //输入数据源类型
objvViewInfo4GeneCodeENT.OutSqlDsTypeId = objvViewInfo4GeneCodeENS.OutSqlDsTypeId; //输出数据源类型
objvViewInfo4GeneCodeENT.GeneCodeDate = objvViewInfo4GeneCodeENS.GeneCodeDate; //生成代码日期
objvViewInfo4GeneCodeENT.RegionNum = objvViewInfo4GeneCodeENS.RegionNum; //区域数
objvViewInfo4GeneCodeENT.UpdDate = objvViewInfo4GeneCodeENS.UpdDate; //修改日期
objvViewInfo4GeneCodeENT.MainTabName = objvViewInfo4GeneCodeENS.MainTabName; //主表
objvViewInfo4GeneCodeENT.DetailTabName = objvViewInfo4GeneCodeENS.DetailTabName; //详细表
objvViewInfo4GeneCodeENT.MainTabKeyFld = objvViewInfo4GeneCodeENS.MainTabKeyFld; //主表关键字
objvViewInfo4GeneCodeENT.DetailTabKeyFld = objvViewInfo4GeneCodeENS.DetailTabKeyFld; //详细表关键字
objvViewInfo4GeneCodeENT.UserId4GeneCode = objvViewInfo4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewInfo4GeneCodeEN objvViewInfo4GeneCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.ViewId, 8, convViewInfo4GeneCode.ViewId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.TitleStyleId, 8, convViewInfo4GeneCode.TitleStyleId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.TitleStyleName, 20, convViewInfo4GeneCode.TitleStyleName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.DgStyleId, 4, convViewInfo4GeneCode.DgStyleId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.DgStyleName, 30, convViewInfo4GeneCode.DgStyleName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.VersionGeneCode, 30, convViewInfo4GeneCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.ViewName, 100, convViewInfo4GeneCode.ViewName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.ViewTypeName, 40, convViewInfo4GeneCode.ViewTypeName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.ApplicationTypeName, 30, convViewInfo4GeneCode.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.FuncModuleAgcId, 8, convViewInfo4GeneCode.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.FuncModuleName, 30, convViewInfo4GeneCode.FuncModuleName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.FuncModuleEnName, 30, convViewInfo4GeneCode.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.DataBaseName, 50, convViewInfo4GeneCode.DataBaseName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.KeyForMainTab, 50, convViewInfo4GeneCode.KeyForMainTab);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.KeyForDetailTab, 50, convViewInfo4GeneCode.KeyForDetailTab);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.UserId, 18, convViewInfo4GeneCode.UserId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.PrjId, 4, convViewInfo4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.PrjName, 30, convViewInfo4GeneCode.PrjName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.ViewFunction, 100, convViewInfo4GeneCode.ViewFunction);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.ViewDetail, 1000, convViewInfo4GeneCode.ViewDetail);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.DefaMenuName, 100, convViewInfo4GeneCode.DefaMenuName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.DetailTabId, 8, convViewInfo4GeneCode.DetailTabId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.FileName, 150, convViewInfo4GeneCode.FileName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.FilePath, 500, convViewInfo4GeneCode.FilePath);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.MainTabId, 8, convViewInfo4GeneCode.MainTabId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.ViewCnName, 100, convViewInfo4GeneCode.ViewCnName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.ViewGroupId, 8, convViewInfo4GeneCode.ViewGroupId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.ViewGroupName, 30, convViewInfo4GeneCode.ViewGroupName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.InSqlDsTypeId, 2, convViewInfo4GeneCode.InSqlDsTypeId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.OutSqlDsTypeId, 2, convViewInfo4GeneCode.OutSqlDsTypeId);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.GeneCodeDate, 20, convViewInfo4GeneCode.GeneCodeDate);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.UpdDate, 20, convViewInfo4GeneCode.UpdDate);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.MainTabName, 100, convViewInfo4GeneCode.MainTabName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.DetailTabName, 40, convViewInfo4GeneCode.DetailTabName);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.MainTabKeyFld, 50, convViewInfo4GeneCode.MainTabKeyFld);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.DetailTabKeyFld, 50, convViewInfo4GeneCode.DetailTabKeyFld);
clsCheckSql.CheckFieldLen(objvViewInfo4GeneCodeEN.UserId4GeneCode, 18, convViewInfo4GeneCode.UserId4GeneCode);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.ViewId, convViewInfo4GeneCode.ViewId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.TitleStyleId, convViewInfo4GeneCode.TitleStyleId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.TitleStyleName, convViewInfo4GeneCode.TitleStyleName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.DgStyleId, convViewInfo4GeneCode.DgStyleId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.DgStyleName, convViewInfo4GeneCode.DgStyleName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.VersionGeneCode, convViewInfo4GeneCode.VersionGeneCode);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.ViewName, convViewInfo4GeneCode.ViewName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.ViewTypeName, convViewInfo4GeneCode.ViewTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.ApplicationTypeName, convViewInfo4GeneCode.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.FuncModuleAgcId, convViewInfo4GeneCode.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.FuncModuleName, convViewInfo4GeneCode.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.FuncModuleEnName, convViewInfo4GeneCode.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.DataBaseName, convViewInfo4GeneCode.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.KeyForMainTab, convViewInfo4GeneCode.KeyForMainTab);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.KeyForDetailTab, convViewInfo4GeneCode.KeyForDetailTab);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.UserId, convViewInfo4GeneCode.UserId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.PrjId, convViewInfo4GeneCode.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.PrjName, convViewInfo4GeneCode.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.ViewFunction, convViewInfo4GeneCode.ViewFunction);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.ViewDetail, convViewInfo4GeneCode.ViewDetail);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.DefaMenuName, convViewInfo4GeneCode.DefaMenuName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.DetailTabId, convViewInfo4GeneCode.DetailTabId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.FileName, convViewInfo4GeneCode.FileName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.FilePath, convViewInfo4GeneCode.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.MainTabId, convViewInfo4GeneCode.MainTabId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.ViewCnName, convViewInfo4GeneCode.ViewCnName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.ViewGroupId, convViewInfo4GeneCode.ViewGroupId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.ViewGroupName, convViewInfo4GeneCode.ViewGroupName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.InSqlDsTypeId, convViewInfo4GeneCode.InSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.OutSqlDsTypeId, convViewInfo4GeneCode.OutSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.GeneCodeDate, convViewInfo4GeneCode.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.UpdDate, convViewInfo4GeneCode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.MainTabName, convViewInfo4GeneCode.MainTabName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.DetailTabName, convViewInfo4GeneCode.DetailTabName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.MainTabKeyFld, convViewInfo4GeneCode.MainTabKeyFld);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.DetailTabKeyFld, convViewInfo4GeneCode.DetailTabKeyFld);
clsCheckSql.CheckSqlInjection4Field(objvViewInfo4GeneCodeEN.UserId4GeneCode, convViewInfo4GeneCode.UserId4GeneCode);
//检查外键字段长度
 objvViewInfo4GeneCodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetViewId()
{
//获取某学院所有专业信息
string strSQL = "select ViewId, ViewName from vViewInfo4GeneCode ";
 clsSpecSQLforSql mySql = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewInfo4GeneCodeEN._CurrTabName);
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
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewInfo4GeneCodeEN._CurrTabName, strCondition);
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
 objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}