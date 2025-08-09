
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionDA
 表名:vViewRegion(00050199)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:00
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
 /// v界面区域(vViewRegion)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewRegionDA : clsCommBase4DA
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
 return clsvViewRegionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewRegionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewRegionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewRegionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewRegionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strRegionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strRegionId)
{
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vViewRegion中,检查关键字,长度不正确!(clsvViewRegionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vViewRegion中,关键字不能为空 或 null!(clsvViewRegionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRegionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvViewRegionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewRegion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewRegionDA: GetDataTable_vViewRegion)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewRegionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewRegion where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewRegion where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewRegionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewRegion where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewRegionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewRegion.* " + 
$"from vViewRegion " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewRegion.RegionId not in " + 
$"(Select top {intTop_In} vViewRegion.RegionId from vViewRegion " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewRegion where {1} and RegionId not in (Select top {2} RegionId from vViewRegion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewRegion where {1} and RegionId not in (Select top {3} RegionId from vViewRegion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewRegionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewRegion.* " + 
$"from vViewRegion " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewRegion.RegionId not in " + 
$"(Select top {intTop_In} vViewRegion.RegionId from vViewRegion " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewRegion where {1} and RegionId not in (Select top {2} RegionId from vViewRegion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewRegion where {1} and RegionId not in (Select top {3} RegionId from vViewRegion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewRegionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewRegionDA:GetObjLst)", objException.Message));
}
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewRegionDA: GetObjLst)", objException.Message));
}
objvViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewRegionEN);
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
public List<clsvViewRegionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewRegionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewRegionEN> arrObjLst = new List<clsvViewRegionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewRegionDA: GetObjLst)", objException.Message));
}
objvViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewRegionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewRegionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewRegion(ref clsvViewRegionEN objvViewRegionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegion where RegionId = " + "'"+ objvViewRegionEN.RegionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewRegionEN.RegionId = objDT.Rows[0][convViewRegion.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvViewRegionEN.RegionName = objDT.Rows[0][convViewRegion.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewRegionEN.RegionTypeId = objDT.Rows[0][convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewRegionEN.FileName = objDT.Rows[0][convViewRegion.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewRegionEN.Height = TransNullToInt(objDT.Rows[0][convViewRegion.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionEN.Width = TransNullToInt(objDT.Rows[0][convViewRegion.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionEN.ColNum = TransNullToInt(objDT.Rows[0][convViewRegion.ColNum].ToString().Trim()); //列数(字段类型:int,字段长度:4,是否可空:False)
 objvViewRegionEN.ContainerTypeId = objDT.Rows[0][convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewRegionEN.PageDispModeId = objDT.Rows[0][convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewRegionEN.InOutTypeId = objDT.Rows[0][convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvViewRegionEN.InOutTypeENName = objDT.Rows[0][convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewRegionEN.TabId = objDT.Rows[0][convViewRegion.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewRegionEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewRegionEN.KeyId4Test = objDT.Rows[0][convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionEN.PrjId = objDT.Rows[0][convViewRegion.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewRegionEN.UpdUser = objDT.Rows[0][convViewRegion.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewRegionEN.UpdDate = objDT.Rows[0][convViewRegion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewRegionEN.Memo = objDT.Rows[0][convViewRegion.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewRegionEN.RegionTypeSimName = objDT.Rows[0][convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名(字段类型:varchar,字段长度:10,是否可空:True)
 objvViewRegionEN.ContainerTypeName = objDT.Rows[0][convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionEN.PageDispModeName = objDT.Rows[0][convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionEN.InOutTypeName = objDT.Rows[0][convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewRegionEN.TabName = objDT.Rows[0][convViewRegion.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewRegionEN.ApplicationTypeSimName = objDT.Rows[0][convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewRegionEN.RegionTypeOrderNum = TransNullToInt(objDT.Rows[0][convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionEN.RegionTypeName = objDT.Rows[0][convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewRegionEN.ClsName = objDT.Rows[0][convViewRegion.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewRegionDA: GetvViewRegion)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewRegionEN GetObjByRegionId(string strRegionId)
{
CheckPrimaryKey(strRegionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegion where RegionId = " + "'"+ strRegionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
 objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ColNum].ToString().Trim()); //列数(字段类型:int,字段长度:4,是否可空:False)
 objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名(字段类型:varchar,字段长度:10,是否可空:True)
 objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewRegionDA: GetObjByRegionId)", objException.Message));
}
return objvViewRegionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewRegionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewRegionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN()
{
RegionId = objRow[convViewRegion.RegionId].ToString().Trim(), //区域Id
RegionName = objRow[convViewRegion.RegionName].ToString().Trim(), //区域名称
RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(), //区域类型Id
FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(), //文件名
Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Height].ToString().Trim()), //高度
Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Width].ToString().Trim()), //宽
ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ColNum].ToString().Trim()), //列数
ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(), //容器类型Id
PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(), //页面显示模式Id
InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(), //INOUT类型ID
InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(), //INOUT类型英文名
TabId = objRow[convViewRegion.TabId].ToString().Trim(), //表ID
ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(), //测试关键字Id
PrjId = objRow[convViewRegion.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(), //说明
RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(), //区域类型简名
ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(), //容器类型名
PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(), //页面显示模式名称
InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(), //INOUT类型名称
TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(), //表名
ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()), //区域类型序号
RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(), //区域类型名称
ClsName = objRow[convViewRegion.ClsName].ToString().Trim() //类名
};
objvViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewRegionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewRegionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewRegionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewRegionDA: GetObjByDataRowvViewRegion)", objException.Message));
}
objvViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewRegionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewRegionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewRegionEN objvViewRegionEN = new clsvViewRegionEN();
try
{
objvViewRegionEN.RegionId = objRow[convViewRegion.RegionId].ToString().Trim(); //区域Id
objvViewRegionEN.RegionName = objRow[convViewRegion.RegionName].ToString().Trim(); //区域名称
objvViewRegionEN.RegionTypeId = objRow[convViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionEN.FileName = objRow[convViewRegion.FileName] == DBNull.Value ? null : objRow[convViewRegion.FileName].ToString().Trim(); //文件名
objvViewRegionEN.Height = objRow[convViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Height].ToString().Trim()); //高度
objvViewRegionEN.Width = objRow[convViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.Width].ToString().Trim()); //宽
objvViewRegionEN.ColNum = objRow[convViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ColNum].ToString().Trim()); //列数
objvViewRegionEN.ContainerTypeId = objRow[convViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionEN.PageDispModeId = objRow[convViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionEN.InOutTypeId = objRow[convViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvViewRegionEN.InOutTypeENName = objRow[convViewRegion.InOutTypeENName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeENName].ToString().Trim(); //INOUT类型英文名
objvViewRegionEN.TabId = objRow[convViewRegion.TabId].ToString().Trim(); //表ID
objvViewRegionEN.ApplicationTypeId = objRow[convViewRegion.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionEN.KeyId4Test = objRow[convViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[convViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewRegionEN.PrjId = objRow[convViewRegion.PrjId].ToString().Trim(); //工程Id
objvViewRegionEN.UpdUser = objRow[convViewRegion.UpdUser] == DBNull.Value ? null : objRow[convViewRegion.UpdUser].ToString().Trim(); //修改者
objvViewRegionEN.UpdDate = objRow[convViewRegion.UpdDate] == DBNull.Value ? null : objRow[convViewRegion.UpdDate].ToString().Trim(); //修改日期
objvViewRegionEN.Memo = objRow[convViewRegion.Memo] == DBNull.Value ? null : objRow[convViewRegion.Memo].ToString().Trim(); //说明
objvViewRegionEN.RegionTypeSimName = objRow[convViewRegion.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionEN.ContainerTypeName = objRow[convViewRegion.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegion.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionEN.PageDispModeName = objRow[convViewRegion.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegion.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionEN.InOutTypeName = objRow[convViewRegion.InOutTypeName] == DBNull.Value ? null : objRow[convViewRegion.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvViewRegionEN.TabName = objRow[convViewRegion.TabName] == DBNull.Value ? null : objRow[convViewRegion.TabName].ToString().Trim(); //表名
objvViewRegionEN.ApplicationTypeSimName = objRow[convViewRegion.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewRegion.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewRegionEN.RegionTypeOrderNum = objRow[convViewRegion.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegion.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionEN.RegionTypeName = objRow[convViewRegion.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionEN.ClsName = objRow[convViewRegion.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewRegionDA: GetObjByDataRow)", objException.Message));
}
objvViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewRegionEN;
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
objSQL = clsvViewRegionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewRegionEN._CurrTabName, convViewRegion.RegionId, 10, "");
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
objSQL = clsvViewRegionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewRegionEN._CurrTabName, convViewRegion.RegionId, 10, strPrefix);
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
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RegionId from vViewRegion where " + strCondition;
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
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RegionId from vViewRegion where " + strCondition;
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strRegionId)
{
CheckPrimaryKey(strRegionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewRegion", "RegionId = " + "'"+ strRegionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewRegionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewRegion", strCondition))
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
objSQL = clsvViewRegionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewRegion");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewRegionENS">源对象</param>
 /// <param name = "objvViewRegionENT">目标对象</param>
public void CopyTo(clsvViewRegionEN objvViewRegionENS, clsvViewRegionEN objvViewRegionENT)
{
objvViewRegionENT.RegionId = objvViewRegionENS.RegionId; //区域Id
objvViewRegionENT.RegionName = objvViewRegionENS.RegionName; //区域名称
objvViewRegionENT.RegionTypeId = objvViewRegionENS.RegionTypeId; //区域类型Id
objvViewRegionENT.FileName = objvViewRegionENS.FileName; //文件名
objvViewRegionENT.Height = objvViewRegionENS.Height; //高度
objvViewRegionENT.Width = objvViewRegionENS.Width; //宽
objvViewRegionENT.ColNum = objvViewRegionENS.ColNum; //列数
objvViewRegionENT.ContainerTypeId = objvViewRegionENS.ContainerTypeId; //容器类型Id
objvViewRegionENT.PageDispModeId = objvViewRegionENS.PageDispModeId; //页面显示模式Id
objvViewRegionENT.InOutTypeId = objvViewRegionENS.InOutTypeId; //INOUT类型ID
objvViewRegionENT.InOutTypeENName = objvViewRegionENS.InOutTypeENName; //INOUT类型英文名
objvViewRegionENT.TabId = objvViewRegionENS.TabId; //表ID
objvViewRegionENT.ApplicationTypeId = objvViewRegionENS.ApplicationTypeId; //应用程序类型ID
objvViewRegionENT.KeyId4Test = objvViewRegionENS.KeyId4Test; //测试关键字Id
objvViewRegionENT.PrjId = objvViewRegionENS.PrjId; //工程Id
objvViewRegionENT.UpdUser = objvViewRegionENS.UpdUser; //修改者
objvViewRegionENT.UpdDate = objvViewRegionENS.UpdDate; //修改日期
objvViewRegionENT.Memo = objvViewRegionENS.Memo; //说明
objvViewRegionENT.RegionTypeSimName = objvViewRegionENS.RegionTypeSimName; //区域类型简名
objvViewRegionENT.ContainerTypeName = objvViewRegionENS.ContainerTypeName; //容器类型名
objvViewRegionENT.PageDispModeName = objvViewRegionENS.PageDispModeName; //页面显示模式名称
objvViewRegionENT.InOutTypeName = objvViewRegionENS.InOutTypeName; //INOUT类型名称
objvViewRegionENT.TabName = objvViewRegionENS.TabName; //表名
objvViewRegionENT.ApplicationTypeSimName = objvViewRegionENS.ApplicationTypeSimName; //应用程序类型简称
objvViewRegionENT.RegionTypeOrderNum = objvViewRegionENS.RegionTypeOrderNum; //区域类型序号
objvViewRegionENT.RegionTypeName = objvViewRegionENS.RegionTypeName; //区域类型名称
objvViewRegionENT.ClsName = objvViewRegionENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewRegionEN objvViewRegionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewRegionEN.RegionId, 10, convViewRegion.RegionId);
clsCheckSql.CheckFieldLen(objvViewRegionEN.RegionName, 50, convViewRegion.RegionName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.RegionTypeId, 4, convViewRegion.RegionTypeId);
clsCheckSql.CheckFieldLen(objvViewRegionEN.FileName, 150, convViewRegion.FileName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.ContainerTypeId, 4, convViewRegion.ContainerTypeId);
clsCheckSql.CheckFieldLen(objvViewRegionEN.PageDispModeId, 2, convViewRegion.PageDispModeId);
clsCheckSql.CheckFieldLen(objvViewRegionEN.InOutTypeId, 2, convViewRegion.InOutTypeId);
clsCheckSql.CheckFieldLen(objvViewRegionEN.InOutTypeENName, 30, convViewRegion.InOutTypeENName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.TabId, 8, convViewRegion.TabId);
clsCheckSql.CheckFieldLen(objvViewRegionEN.KeyId4Test, 50, convViewRegion.KeyId4Test);
clsCheckSql.CheckFieldLen(objvViewRegionEN.PrjId, 4, convViewRegion.PrjId);
clsCheckSql.CheckFieldLen(objvViewRegionEN.UpdUser, 20, convViewRegion.UpdUser);
clsCheckSql.CheckFieldLen(objvViewRegionEN.UpdDate, 20, convViewRegion.UpdDate);
clsCheckSql.CheckFieldLen(objvViewRegionEN.Memo, 1000, convViewRegion.Memo);
clsCheckSql.CheckFieldLen(objvViewRegionEN.RegionTypeSimName, 10, convViewRegion.RegionTypeSimName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.ContainerTypeName, 50, convViewRegion.ContainerTypeName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.PageDispModeName, 50, convViewRegion.PageDispModeName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.InOutTypeName, 30, convViewRegion.InOutTypeName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.TabName, 100, convViewRegion.TabName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.ApplicationTypeSimName, 30, convViewRegion.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.RegionTypeName, 30, convViewRegion.RegionTypeName);
clsCheckSql.CheckFieldLen(objvViewRegionEN.ClsName, 100, convViewRegion.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.RegionId, convViewRegion.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.RegionName, convViewRegion.RegionName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.RegionTypeId, convViewRegion.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.FileName, convViewRegion.FileName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.ContainerTypeId, convViewRegion.ContainerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.PageDispModeId, convViewRegion.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.InOutTypeId, convViewRegion.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.InOutTypeENName, convViewRegion.InOutTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.TabId, convViewRegion.TabId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.KeyId4Test, convViewRegion.KeyId4Test);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.PrjId, convViewRegion.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.UpdUser, convViewRegion.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.UpdDate, convViewRegion.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.Memo, convViewRegion.Memo);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.RegionTypeSimName, convViewRegion.RegionTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.ContainerTypeName, convViewRegion.ContainerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.PageDispModeName, convViewRegion.PageDispModeName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.InOutTypeName, convViewRegion.InOutTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.TabName, convViewRegion.TabName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.ApplicationTypeSimName, convViewRegion.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.RegionTypeName, convViewRegion.RegionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionEN.ClsName, convViewRegion.ClsName);
//检查外键字段长度
 objvViewRegionEN._IsCheckProperty = true;
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
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
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
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
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
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewRegionEN._CurrTabName);
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
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewRegionEN._CurrTabName, strCondition);
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
 objSQL = clsvViewRegionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}