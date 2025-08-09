
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEditRegionFldsDA
 表名:EditRegionFlds(00050116)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:01
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
 /// 编辑区域字段(EditRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsEditRegionFldsDA : clsCommBase4DA
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
 return clsEditRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsEditRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsEditRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsEditRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsEditRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_EditRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetDataTable_EditRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from EditRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from EditRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from EditRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} EditRegionFlds.* " + 
$"from EditRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and EditRegionFlds.mId not in " + 
$"(Select top {intTop_In} EditRegionFlds.mId from EditRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from EditRegionFlds where {1} and mId not in (Select top {2} mId from EditRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from EditRegionFlds where {1} and mId not in (Select top {3} mId from EditRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} EditRegionFlds.* " + 
$"from EditRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and EditRegionFlds.mId not in " + 
$"(Select top {intTop_In} EditRegionFlds.mId from EditRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from EditRegionFlds where {1} and mId not in (Select top {2} mId from EditRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from EditRegionFlds where {1} and mId not in (Select top {3} mId from EditRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsEditRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsEditRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = TransNullToInt(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = TransNullToBool(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = TransNullToBool(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsEditRegionFldsDA: GetObjLst)", objException.Message));
}
objEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objEditRegionFldsEN);
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
public List<clsEditRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsEditRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = TransNullToInt(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = TransNullToBool(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = TransNullToBool(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsEditRegionFldsDA: GetObjLst)", objException.Message));
}
objEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objEditRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetEditRegionFlds(ref clsEditRegionFldsEN objEditRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where mId = " + ""+ objEditRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objEditRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][conEditRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objEditRegionFldsEN.RegionId = objDT.Rows[0][conEditRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objEditRegionFldsEN.FldId = objDT.Rows[0][conEditRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objEditRegionFldsEN.LabelCaption = objDT.Rows[0][conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objEditRegionFldsEN.CtlTypeId = objDT.Rows[0][conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objEditRegionFldsEN.CallTabFeatureId = objDT.Rows[0][conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.VarId = objDT.Rows[0][conEditRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.DefaultValue = objDT.Rows[0][conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objEditRegionFldsEN.DdlItemsOptionId = objDT.Rows[0][conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objEditRegionFldsEN.DsTabId = objDT.Rows[0][conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objEditRegionFldsEN.TabFeatureId4Ddl = objDT.Rows[0][conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.FldIdCond1 = objDT.Rows[0][conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.VarIdCond1 = objDT.Rows[0][conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.FldIdCond2 = objDT.Rows[0][conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.VarIdCond2 = objDT.Rows[0][conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.DsCondStr = objDT.Rows[0][conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objEditRegionFldsEN.DsSqlStr = objDT.Rows[0][conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objEditRegionFldsEN.ItemsString = objDT.Rows[0][conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objEditRegionFldsEN.ColSpan = TransNullToInt(objDT.Rows[0][conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objEditRegionFldsEN.ColIndex = TransNullToInt(objDT.Rows[0][conEditRegionFlds.ColIndex].ToString().Trim()); //列序号(字段类型:int,字段长度:4,是否可空:False)
 objEditRegionFldsEN.Width = TransNullToInt(objDT.Rows[0][conEditRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objEditRegionFldsEN.IsMultiRow = TransNullToBool(objDT.Rows[0][conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行(字段类型:bit,字段长度:1,是否可空:True)
 objEditRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objEditRegionFldsEN.InOutTypeId = objDT.Rows[0][conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objEditRegionFldsEN.ClickEvent = objDT.Rows[0][conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objEditRegionFldsEN.ChangeEvent = objDT.Rows[0][conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objEditRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][conEditRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objEditRegionFldsEN.ErrMsg = objDT.Rows[0][conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objEditRegionFldsEN.PrjId = objDT.Rows[0][conEditRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objEditRegionFldsEN.UpdUser = objDT.Rows[0][conEditRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objEditRegionFldsEN.UpdDate = objDT.Rows[0][conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objEditRegionFldsEN.Memo = objDT.Rows[0][conEditRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsEditRegionFldsDA: GetEditRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsEditRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
 objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1(字段类型:char,字段长度:8,是否可空:True)
 objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号(字段类型:int,字段长度:4,是否可空:False)
 objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行(字段类型:bit,字段长度:1,是否可空:True)
 objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsEditRegionFldsDA: GetObjBymId)", objException.Message));
}
return objEditRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsEditRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN()
{
mId = TransNullToInt(objRow[conEditRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(), //区域Id
FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(), //字段Id
LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(), //标签标题
CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(), //调用表功能Id
VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(), //变量Id
DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(), //缺省值
DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(), //下拉框列表选项ID
DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(), //数据源表ID
TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(), //下拉框表功能Id
FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(), //字段Id_条件1
VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(), //变量Id_条件1
FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(), //字段Id_条件2
VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(), //数据源字段_条件1
DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(), //数据源条件串
DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(), //数据源SQL串
ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(), //列表项串
ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColSpan].ToString().Trim()), //跨列数
ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColIndex].ToString().Trim()), //列序号
Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.Width].ToString().Trim()), //宽
IsMultiRow = TransNullToBool(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()), //是否多行
SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.SeqNum].ToString().Trim()), //字段序号
InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(), //INOUT类型ID
ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(), //Click事件
ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(), //Change事件
InUse = TransNullToBool(objRow[conEditRegionFlds.InUse].ToString().Trim()), //是否在用
ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim() //说明
};
objEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objEditRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsEditRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsEditRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = TransNullToInt(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = TransNullToBool(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = TransNullToBool(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsEditRegionFldsDA: GetObjByDataRowEditRegionFlds)", objException.Message));
}
objEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objEditRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsEditRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = TransNullToInt(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = TransNullToBool(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = TransNullToBool(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsEditRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objEditRegionFldsEN;
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
objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsEditRegionFldsEN._CurrTabName, conEditRegionFlds.mId, 8, "");
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
objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsEditRegionFldsEN._CurrTabName, conEditRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from EditRegionFlds where " + strCondition;
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from EditRegionFlds where " + strCondition;
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("EditRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsEditRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("EditRegionFlds", strCondition))
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
objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("EditRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsEditRegionFldsEN objEditRegionFldsEN)
 {
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEditRegionFldsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "EditRegionFlds");
objRow = objDS.Tables["EditRegionFlds"].NewRow();
objRow[conEditRegionFlds.RegionId] = objEditRegionFldsEN.RegionId; //区域Id
 if (objEditRegionFldsEN.FldId !=  "")
 {
objRow[conEditRegionFlds.FldId] = objEditRegionFldsEN.FldId; //字段Id
 }
 if (objEditRegionFldsEN.LabelCaption !=  "")
 {
objRow[conEditRegionFlds.LabelCaption] = objEditRegionFldsEN.LabelCaption; //标签标题
 }
objRow[conEditRegionFlds.CtlTypeId] = objEditRegionFldsEN.CtlTypeId; //控件类型号
 if (objEditRegionFldsEN.CallTabFeatureId !=  "")
 {
objRow[conEditRegionFlds.CallTabFeatureId] = objEditRegionFldsEN.CallTabFeatureId; //调用表功能Id
 }
 if (objEditRegionFldsEN.VarId !=  "")
 {
objRow[conEditRegionFlds.VarId] = objEditRegionFldsEN.VarId; //变量Id
 }
 if (objEditRegionFldsEN.DefaultValue !=  "")
 {
objRow[conEditRegionFlds.DefaultValue] = objEditRegionFldsEN.DefaultValue; //缺省值
 }
 if (objEditRegionFldsEN.DdlItemsOptionId !=  "")
 {
objRow[conEditRegionFlds.DdlItemsOptionId] = objEditRegionFldsEN.DdlItemsOptionId; //下拉框列表选项ID
 }
 if (objEditRegionFldsEN.DsTabId !=  "")
 {
objRow[conEditRegionFlds.DsTabId] = objEditRegionFldsEN.DsTabId; //数据源表ID
 }
 if (objEditRegionFldsEN.TabFeatureId4Ddl !=  "")
 {
objRow[conEditRegionFlds.TabFeatureId4Ddl] = objEditRegionFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
 }
 if (objEditRegionFldsEN.FldIdCond1 !=  "")
 {
objRow[conEditRegionFlds.FldIdCond1] = objEditRegionFldsEN.FldIdCond1; //字段Id_条件1
 }
 if (objEditRegionFldsEN.VarIdCond1 !=  "")
 {
objRow[conEditRegionFlds.VarIdCond1] = objEditRegionFldsEN.VarIdCond1; //变量Id_条件1
 }
 if (objEditRegionFldsEN.FldIdCond2 !=  "")
 {
objRow[conEditRegionFlds.FldIdCond2] = objEditRegionFldsEN.FldIdCond2; //字段Id_条件2
 }
 if (objEditRegionFldsEN.VarIdCond2 !=  "")
 {
objRow[conEditRegionFlds.VarIdCond2] = objEditRegionFldsEN.VarIdCond2; //数据源字段_条件1
 }
 if (objEditRegionFldsEN.DsCondStr !=  "")
 {
objRow[conEditRegionFlds.DsCondStr] = objEditRegionFldsEN.DsCondStr; //数据源条件串
 }
 if (objEditRegionFldsEN.DsSqlStr !=  "")
 {
objRow[conEditRegionFlds.DsSqlStr] = objEditRegionFldsEN.DsSqlStr; //数据源SQL串
 }
 if (objEditRegionFldsEN.ItemsString !=  "")
 {
objRow[conEditRegionFlds.ItemsString] = objEditRegionFldsEN.ItemsString; //列表项串
 }
objRow[conEditRegionFlds.ColSpan] = objEditRegionFldsEN.ColSpan; //跨列数
objRow[conEditRegionFlds.ColIndex] = objEditRegionFldsEN.ColIndex; //列序号
objRow[conEditRegionFlds.Width] = objEditRegionFldsEN.Width; //宽
objRow[conEditRegionFlds.IsMultiRow] = objEditRegionFldsEN.IsMultiRow; //是否多行
objRow[conEditRegionFlds.SeqNum] = objEditRegionFldsEN.SeqNum; //字段序号
 if (objEditRegionFldsEN.InOutTypeId !=  "")
 {
objRow[conEditRegionFlds.InOutTypeId] = objEditRegionFldsEN.InOutTypeId; //INOUT类型ID
 }
 if (objEditRegionFldsEN.ClickEvent !=  "")
 {
objRow[conEditRegionFlds.ClickEvent] = objEditRegionFldsEN.ClickEvent; //Click事件
 }
 if (objEditRegionFldsEN.ChangeEvent !=  "")
 {
objRow[conEditRegionFlds.ChangeEvent] = objEditRegionFldsEN.ChangeEvent; //Change事件
 }
objRow[conEditRegionFlds.InUse] = objEditRegionFldsEN.InUse; //是否在用
 if (objEditRegionFldsEN.ErrMsg !=  "")
 {
objRow[conEditRegionFlds.ErrMsg] = objEditRegionFldsEN.ErrMsg; //错误信息
 }
objRow[conEditRegionFlds.PrjId] = objEditRegionFldsEN.PrjId; //工程Id
objRow[conEditRegionFlds.UpdUser] = objEditRegionFldsEN.UpdUser; //修改者
 if (objEditRegionFldsEN.UpdDate !=  "")
 {
objRow[conEditRegionFlds.UpdDate] = objEditRegionFldsEN.UpdDate; //修改日期
 }
 if (objEditRegionFldsEN.Memo !=  "")
 {
objRow[conEditRegionFlds.Memo] = objEditRegionFldsEN.Memo; //说明
 }
objDS.Tables[clsEditRegionFldsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsEditRegionFldsEN._CurrTabName);
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
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsEditRegionFldsEN objEditRegionFldsEN)
{
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEditRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objEditRegionFldsEN.RegionId  ==  "")
 {
 objEditRegionFldsEN.RegionId = null;
 }
 if (objEditRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.RegionId);
 var strRegionId = objEditRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objEditRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldId);
 var strFldId = objEditRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objEditRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.LabelCaption);
 var strLabelCaption = objEditRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objEditRegionFldsEN.CtlTypeId  ==  "")
 {
 objEditRegionFldsEN.CtlTypeId = null;
 }
 if (objEditRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.CtlTypeId);
 var strCtlTypeId = objEditRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objEditRegionFldsEN.CallTabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.CallTabFeatureId);
 var strCallTabFeatureId = objEditRegionFldsEN.CallTabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCallTabFeatureId + "'");
 }
 
 if (objEditRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarId);
 var strVarId = objEditRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objEditRegionFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DefaultValue);
 var strDefaultValue = objEditRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objEditRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objEditRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objEditRegionFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objEditRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objEditRegionFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsTabId);
 var strDsTabId = objEditRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objEditRegionFldsEN.TabFeatureId4Ddl  ==  "")
 {
 objEditRegionFldsEN.TabFeatureId4Ddl = null;
 }
 if (objEditRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objEditRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objEditRegionFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldIdCond1);
 var strFldIdCond1 = objEditRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objEditRegionFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarIdCond1);
 var strVarIdCond1 = objEditRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objEditRegionFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldIdCond2);
 var strFldIdCond2 = objEditRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objEditRegionFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarIdCond2);
 var strVarIdCond2 = objEditRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objEditRegionFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsCondStr);
 var strDsCondStr = objEditRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objEditRegionFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsSqlStr);
 var strDsSqlStr = objEditRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objEditRegionFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ItemsString);
 var strItemsString = objEditRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objEditRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ColSpan);
 arrValueListForInsert.Add(objEditRegionFldsEN.ColSpan.ToString());
 }
 
 if (objEditRegionFldsEN.ColIndex !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ColIndex);
 arrValueListForInsert.Add(objEditRegionFldsEN.ColIndex.ToString());
 }
 
 if (objEditRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.Width);
 arrValueListForInsert.Add(objEditRegionFldsEN.Width.ToString());
 }
 
 arrFieldListForInsert.Add(conEditRegionFlds.IsMultiRow);
 arrValueListForInsert.Add("'" + (objEditRegionFldsEN.IsMultiRow  ==  false ? "0" : "1") + "'");
 
 if (objEditRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.SeqNum);
 arrValueListForInsert.Add(objEditRegionFldsEN.SeqNum.ToString());
 }
 
 if (objEditRegionFldsEN.InOutTypeId  ==  "")
 {
 objEditRegionFldsEN.InOutTypeId = null;
 }
 if (objEditRegionFldsEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.InOutTypeId);
 var strInOutTypeId = objEditRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objEditRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ClickEvent);
 var strClickEvent = objEditRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 if (objEditRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ChangeEvent);
 var strChangeEvent = objEditRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 arrFieldListForInsert.Add(conEditRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objEditRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objEditRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ErrMsg);
 var strErrMsg = objEditRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objEditRegionFldsEN.PrjId  ==  "")
 {
 objEditRegionFldsEN.PrjId = null;
 }
 if (objEditRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.PrjId);
 var strPrjId = objEditRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objEditRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.UpdUser);
 var strUpdUser = objEditRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objEditRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.UpdDate);
 var strUpdDate = objEditRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEditRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.Memo);
 var strMemo = objEditRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EditRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsEditRegionFldsEN objEditRegionFldsEN)
{
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEditRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objEditRegionFldsEN.RegionId  ==  "")
 {
 objEditRegionFldsEN.RegionId = null;
 }
 if (objEditRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.RegionId);
 var strRegionId = objEditRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objEditRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldId);
 var strFldId = objEditRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objEditRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.LabelCaption);
 var strLabelCaption = objEditRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objEditRegionFldsEN.CtlTypeId  ==  "")
 {
 objEditRegionFldsEN.CtlTypeId = null;
 }
 if (objEditRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.CtlTypeId);
 var strCtlTypeId = objEditRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objEditRegionFldsEN.CallTabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.CallTabFeatureId);
 var strCallTabFeatureId = objEditRegionFldsEN.CallTabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCallTabFeatureId + "'");
 }
 
 if (objEditRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarId);
 var strVarId = objEditRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objEditRegionFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DefaultValue);
 var strDefaultValue = objEditRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objEditRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objEditRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objEditRegionFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objEditRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objEditRegionFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsTabId);
 var strDsTabId = objEditRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objEditRegionFldsEN.TabFeatureId4Ddl  ==  "")
 {
 objEditRegionFldsEN.TabFeatureId4Ddl = null;
 }
 if (objEditRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objEditRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objEditRegionFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldIdCond1);
 var strFldIdCond1 = objEditRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objEditRegionFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarIdCond1);
 var strVarIdCond1 = objEditRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objEditRegionFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldIdCond2);
 var strFldIdCond2 = objEditRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objEditRegionFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarIdCond2);
 var strVarIdCond2 = objEditRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objEditRegionFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsCondStr);
 var strDsCondStr = objEditRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objEditRegionFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsSqlStr);
 var strDsSqlStr = objEditRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objEditRegionFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ItemsString);
 var strItemsString = objEditRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objEditRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ColSpan);
 arrValueListForInsert.Add(objEditRegionFldsEN.ColSpan.ToString());
 }
 
 if (objEditRegionFldsEN.ColIndex !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ColIndex);
 arrValueListForInsert.Add(objEditRegionFldsEN.ColIndex.ToString());
 }
 
 if (objEditRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.Width);
 arrValueListForInsert.Add(objEditRegionFldsEN.Width.ToString());
 }
 
 arrFieldListForInsert.Add(conEditRegionFlds.IsMultiRow);
 arrValueListForInsert.Add("'" + (objEditRegionFldsEN.IsMultiRow  ==  false ? "0" : "1") + "'");
 
 if (objEditRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.SeqNum);
 arrValueListForInsert.Add(objEditRegionFldsEN.SeqNum.ToString());
 }
 
 if (objEditRegionFldsEN.InOutTypeId  ==  "")
 {
 objEditRegionFldsEN.InOutTypeId = null;
 }
 if (objEditRegionFldsEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.InOutTypeId);
 var strInOutTypeId = objEditRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objEditRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ClickEvent);
 var strClickEvent = objEditRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 if (objEditRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ChangeEvent);
 var strChangeEvent = objEditRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 arrFieldListForInsert.Add(conEditRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objEditRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objEditRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ErrMsg);
 var strErrMsg = objEditRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objEditRegionFldsEN.PrjId  ==  "")
 {
 objEditRegionFldsEN.PrjId = null;
 }
 if (objEditRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.PrjId);
 var strPrjId = objEditRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objEditRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.UpdUser);
 var strUpdUser = objEditRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objEditRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.UpdDate);
 var strUpdDate = objEditRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEditRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.Memo);
 var strMemo = objEditRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EditRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsEditRegionFldsEN objEditRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEditRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objEditRegionFldsEN.RegionId  ==  "")
 {
 objEditRegionFldsEN.RegionId = null;
 }
 if (objEditRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.RegionId);
 var strRegionId = objEditRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objEditRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldId);
 var strFldId = objEditRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objEditRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.LabelCaption);
 var strLabelCaption = objEditRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objEditRegionFldsEN.CtlTypeId  ==  "")
 {
 objEditRegionFldsEN.CtlTypeId = null;
 }
 if (objEditRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.CtlTypeId);
 var strCtlTypeId = objEditRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objEditRegionFldsEN.CallTabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.CallTabFeatureId);
 var strCallTabFeatureId = objEditRegionFldsEN.CallTabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCallTabFeatureId + "'");
 }
 
 if (objEditRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarId);
 var strVarId = objEditRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objEditRegionFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DefaultValue);
 var strDefaultValue = objEditRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objEditRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objEditRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objEditRegionFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objEditRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objEditRegionFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsTabId);
 var strDsTabId = objEditRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objEditRegionFldsEN.TabFeatureId4Ddl  ==  "")
 {
 objEditRegionFldsEN.TabFeatureId4Ddl = null;
 }
 if (objEditRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objEditRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objEditRegionFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldIdCond1);
 var strFldIdCond1 = objEditRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objEditRegionFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarIdCond1);
 var strVarIdCond1 = objEditRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objEditRegionFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldIdCond2);
 var strFldIdCond2 = objEditRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objEditRegionFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarIdCond2);
 var strVarIdCond2 = objEditRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objEditRegionFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsCondStr);
 var strDsCondStr = objEditRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objEditRegionFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsSqlStr);
 var strDsSqlStr = objEditRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objEditRegionFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ItemsString);
 var strItemsString = objEditRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objEditRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ColSpan);
 arrValueListForInsert.Add(objEditRegionFldsEN.ColSpan.ToString());
 }
 
 if (objEditRegionFldsEN.ColIndex !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ColIndex);
 arrValueListForInsert.Add(objEditRegionFldsEN.ColIndex.ToString());
 }
 
 if (objEditRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.Width);
 arrValueListForInsert.Add(objEditRegionFldsEN.Width.ToString());
 }
 
 arrFieldListForInsert.Add(conEditRegionFlds.IsMultiRow);
 arrValueListForInsert.Add("'" + (objEditRegionFldsEN.IsMultiRow  ==  false ? "0" : "1") + "'");
 
 if (objEditRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.SeqNum);
 arrValueListForInsert.Add(objEditRegionFldsEN.SeqNum.ToString());
 }
 
 if (objEditRegionFldsEN.InOutTypeId  ==  "")
 {
 objEditRegionFldsEN.InOutTypeId = null;
 }
 if (objEditRegionFldsEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.InOutTypeId);
 var strInOutTypeId = objEditRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objEditRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ClickEvent);
 var strClickEvent = objEditRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 if (objEditRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ChangeEvent);
 var strChangeEvent = objEditRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 arrFieldListForInsert.Add(conEditRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objEditRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objEditRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ErrMsg);
 var strErrMsg = objEditRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objEditRegionFldsEN.PrjId  ==  "")
 {
 objEditRegionFldsEN.PrjId = null;
 }
 if (objEditRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.PrjId);
 var strPrjId = objEditRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objEditRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.UpdUser);
 var strUpdUser = objEditRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objEditRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.UpdDate);
 var strUpdDate = objEditRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEditRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.Memo);
 var strMemo = objEditRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EditRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsEditRegionFldsEN objEditRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEditRegionFldsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objEditRegionFldsEN.RegionId  ==  "")
 {
 objEditRegionFldsEN.RegionId = null;
 }
 if (objEditRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.RegionId);
 var strRegionId = objEditRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objEditRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldId);
 var strFldId = objEditRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objEditRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.LabelCaption);
 var strLabelCaption = objEditRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objEditRegionFldsEN.CtlTypeId  ==  "")
 {
 objEditRegionFldsEN.CtlTypeId = null;
 }
 if (objEditRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.CtlTypeId);
 var strCtlTypeId = objEditRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objEditRegionFldsEN.CallTabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.CallTabFeatureId);
 var strCallTabFeatureId = objEditRegionFldsEN.CallTabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCallTabFeatureId + "'");
 }
 
 if (objEditRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarId);
 var strVarId = objEditRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objEditRegionFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DefaultValue);
 var strDefaultValue = objEditRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objEditRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objEditRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objEditRegionFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objEditRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objEditRegionFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsTabId);
 var strDsTabId = objEditRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objEditRegionFldsEN.TabFeatureId4Ddl  ==  "")
 {
 objEditRegionFldsEN.TabFeatureId4Ddl = null;
 }
 if (objEditRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objEditRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objEditRegionFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldIdCond1);
 var strFldIdCond1 = objEditRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objEditRegionFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarIdCond1);
 var strVarIdCond1 = objEditRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objEditRegionFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.FldIdCond2);
 var strFldIdCond2 = objEditRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objEditRegionFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.VarIdCond2);
 var strVarIdCond2 = objEditRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objEditRegionFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsCondStr);
 var strDsCondStr = objEditRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objEditRegionFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.DsSqlStr);
 var strDsSqlStr = objEditRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objEditRegionFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ItemsString);
 var strItemsString = objEditRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objEditRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ColSpan);
 arrValueListForInsert.Add(objEditRegionFldsEN.ColSpan.ToString());
 }
 
 if (objEditRegionFldsEN.ColIndex !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ColIndex);
 arrValueListForInsert.Add(objEditRegionFldsEN.ColIndex.ToString());
 }
 
 if (objEditRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.Width);
 arrValueListForInsert.Add(objEditRegionFldsEN.Width.ToString());
 }
 
 arrFieldListForInsert.Add(conEditRegionFlds.IsMultiRow);
 arrValueListForInsert.Add("'" + (objEditRegionFldsEN.IsMultiRow  ==  false ? "0" : "1") + "'");
 
 if (objEditRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.SeqNum);
 arrValueListForInsert.Add(objEditRegionFldsEN.SeqNum.ToString());
 }
 
 if (objEditRegionFldsEN.InOutTypeId  ==  "")
 {
 objEditRegionFldsEN.InOutTypeId = null;
 }
 if (objEditRegionFldsEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.InOutTypeId);
 var strInOutTypeId = objEditRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objEditRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ClickEvent);
 var strClickEvent = objEditRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 if (objEditRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ChangeEvent);
 var strChangeEvent = objEditRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 arrFieldListForInsert.Add(conEditRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objEditRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objEditRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.ErrMsg);
 var strErrMsg = objEditRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objEditRegionFldsEN.PrjId  ==  "")
 {
 objEditRegionFldsEN.PrjId = null;
 }
 if (objEditRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.PrjId);
 var strPrjId = objEditRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objEditRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.UpdUser);
 var strUpdUser = objEditRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objEditRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.UpdDate);
 var strUpdDate = objEditRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEditRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEditRegionFlds.Memo);
 var strMemo = objEditRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EditRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewEditRegionFldss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "EditRegionFlds");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conEditRegionFlds.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsEditRegionFldsEN._CurrTabName ].NewRow();
objRow[conEditRegionFlds.RegionId] = oRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objRow[conEditRegionFlds.FldId] = oRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objRow[conEditRegionFlds.LabelCaption] = oRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objRow[conEditRegionFlds.CtlTypeId] = oRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objRow[conEditRegionFlds.CallTabFeatureId] = oRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objRow[conEditRegionFlds.VarId] = oRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objRow[conEditRegionFlds.DefaultValue] = oRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objRow[conEditRegionFlds.DdlItemsOptionId] = oRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objRow[conEditRegionFlds.DsTabId] = oRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objRow[conEditRegionFlds.TabFeatureId4Ddl] = oRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objRow[conEditRegionFlds.FldIdCond1] = oRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objRow[conEditRegionFlds.VarIdCond1] = oRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objRow[conEditRegionFlds.FldIdCond2] = oRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objRow[conEditRegionFlds.VarIdCond2] = oRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objRow[conEditRegionFlds.DsCondStr] = oRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objRow[conEditRegionFlds.DsSqlStr] = oRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objRow[conEditRegionFlds.ItemsString] = oRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objRow[conEditRegionFlds.ColSpan] = oRow[conEditRegionFlds.ColSpan].ToString().Trim(); //跨列数
objRow[conEditRegionFlds.ColIndex] = oRow[conEditRegionFlds.ColIndex].ToString().Trim(); //列序号
objRow[conEditRegionFlds.Width] = oRow[conEditRegionFlds.Width].ToString().Trim(); //宽
objRow[conEditRegionFlds.IsMultiRow] = oRow[conEditRegionFlds.IsMultiRow].ToString().Trim(); //是否多行
objRow[conEditRegionFlds.SeqNum] = oRow[conEditRegionFlds.SeqNum].ToString().Trim(); //字段序号
objRow[conEditRegionFlds.InOutTypeId] = oRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objRow[conEditRegionFlds.ClickEvent] = oRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objRow[conEditRegionFlds.ChangeEvent] = oRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objRow[conEditRegionFlds.InUse] = oRow[conEditRegionFlds.InUse].ToString().Trim(); //是否在用
objRow[conEditRegionFlds.ErrMsg] = oRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objRow[conEditRegionFlds.PrjId] = oRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objRow[conEditRegionFlds.UpdUser] = oRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objRow[conEditRegionFlds.UpdDate] = oRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objRow[conEditRegionFlds.Memo] = oRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
 objDS.Tables[clsEditRegionFldsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsEditRegionFldsEN._CurrTabName);
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
 /// <param name = "objEditRegionFldsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsEditRegionFldsEN objEditRegionFldsEN)
{
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEditRegionFldsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from EditRegionFlds where mId = " + ""+ objEditRegionFldsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsEditRegionFldsEN._CurrTabName);
if (objDS.Tables[clsEditRegionFldsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objEditRegionFldsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsEditRegionFldsEN._CurrTabName].Rows[0];
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.RegionId))
 {
objRow[conEditRegionFlds.RegionId] = objEditRegionFldsEN.RegionId; //区域Id
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldId))
 {
objRow[conEditRegionFlds.FldId] = objEditRegionFldsEN.FldId; //字段Id
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.LabelCaption))
 {
objRow[conEditRegionFlds.LabelCaption] = objEditRegionFldsEN.LabelCaption; //标签标题
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CtlTypeId))
 {
objRow[conEditRegionFlds.CtlTypeId] = objEditRegionFldsEN.CtlTypeId; //控件类型号
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CallTabFeatureId))
 {
objRow[conEditRegionFlds.CallTabFeatureId] = objEditRegionFldsEN.CallTabFeatureId; //调用表功能Id
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarId))
 {
objRow[conEditRegionFlds.VarId] = objEditRegionFldsEN.VarId; //变量Id
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DefaultValue))
 {
objRow[conEditRegionFlds.DefaultValue] = objEditRegionFldsEN.DefaultValue; //缺省值
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DdlItemsOptionId))
 {
objRow[conEditRegionFlds.DdlItemsOptionId] = objEditRegionFldsEN.DdlItemsOptionId; //下拉框列表选项ID
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsTabId))
 {
objRow[conEditRegionFlds.DsTabId] = objEditRegionFldsEN.DsTabId; //数据源表ID
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.TabFeatureId4Ddl))
 {
objRow[conEditRegionFlds.TabFeatureId4Ddl] = objEditRegionFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond1))
 {
objRow[conEditRegionFlds.FldIdCond1] = objEditRegionFldsEN.FldIdCond1; //字段Id_条件1
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond1))
 {
objRow[conEditRegionFlds.VarIdCond1] = objEditRegionFldsEN.VarIdCond1; //变量Id_条件1
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond2))
 {
objRow[conEditRegionFlds.FldIdCond2] = objEditRegionFldsEN.FldIdCond2; //字段Id_条件2
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond2))
 {
objRow[conEditRegionFlds.VarIdCond2] = objEditRegionFldsEN.VarIdCond2; //数据源字段_条件1
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsCondStr))
 {
objRow[conEditRegionFlds.DsCondStr] = objEditRegionFldsEN.DsCondStr; //数据源条件串
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsSqlStr))
 {
objRow[conEditRegionFlds.DsSqlStr] = objEditRegionFldsEN.DsSqlStr; //数据源SQL串
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ItemsString))
 {
objRow[conEditRegionFlds.ItemsString] = objEditRegionFldsEN.ItemsString; //列表项串
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColSpan))
 {
objRow[conEditRegionFlds.ColSpan] = objEditRegionFldsEN.ColSpan; //跨列数
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColIndex))
 {
objRow[conEditRegionFlds.ColIndex] = objEditRegionFldsEN.ColIndex; //列序号
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Width))
 {
objRow[conEditRegionFlds.Width] = objEditRegionFldsEN.Width; //宽
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.IsMultiRow))
 {
objRow[conEditRegionFlds.IsMultiRow] = objEditRegionFldsEN.IsMultiRow; //是否多行
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.SeqNum))
 {
objRow[conEditRegionFlds.SeqNum] = objEditRegionFldsEN.SeqNum; //字段序号
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InOutTypeId))
 {
objRow[conEditRegionFlds.InOutTypeId] = objEditRegionFldsEN.InOutTypeId; //INOUT类型ID
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ClickEvent))
 {
objRow[conEditRegionFlds.ClickEvent] = objEditRegionFldsEN.ClickEvent; //Click事件
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ChangeEvent))
 {
objRow[conEditRegionFlds.ChangeEvent] = objEditRegionFldsEN.ChangeEvent; //Change事件
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InUse))
 {
objRow[conEditRegionFlds.InUse] = objEditRegionFldsEN.InUse; //是否在用
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ErrMsg))
 {
objRow[conEditRegionFlds.ErrMsg] = objEditRegionFldsEN.ErrMsg; //错误信息
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.PrjId))
 {
objRow[conEditRegionFlds.PrjId] = objEditRegionFldsEN.PrjId; //工程Id
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdUser))
 {
objRow[conEditRegionFlds.UpdUser] = objEditRegionFldsEN.UpdUser; //修改者
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdDate))
 {
objRow[conEditRegionFlds.UpdDate] = objEditRegionFldsEN.UpdDate; //修改日期
 }
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Memo))
 {
objRow[conEditRegionFlds.Memo] = objEditRegionFldsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsEditRegionFldsEN._CurrTabName);
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
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsEditRegionFldsEN objEditRegionFldsEN)
{
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEditRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update EditRegionFlds Set ");
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.RegionId))
 {
 if (objEditRegionFldsEN.RegionId  ==  "")
 {
 objEditRegionFldsEN.RegionId = null;
 }
 if (objEditRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objEditRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conEditRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldId))
 {
 if (objEditRegionFldsEN.FldId !=  null)
 {
 var strFldId = objEditRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conEditRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.FldId); //字段Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.LabelCaption))
 {
 if (objEditRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objEditRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelCaption, conEditRegionFlds.LabelCaption); //标签标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.LabelCaption); //标签标题
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CtlTypeId))
 {
 if (objEditRegionFldsEN.CtlTypeId  ==  "")
 {
 objEditRegionFldsEN.CtlTypeId = null;
 }
 if (objEditRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objEditRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conEditRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CallTabFeatureId))
 {
 if (objEditRegionFldsEN.CallTabFeatureId !=  null)
 {
 var strCallTabFeatureId = objEditRegionFldsEN.CallTabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCallTabFeatureId, conEditRegionFlds.CallTabFeatureId); //调用表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.CallTabFeatureId); //调用表功能Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarId))
 {
 if (objEditRegionFldsEN.VarId !=  null)
 {
 var strVarId = objEditRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarId, conEditRegionFlds.VarId); //变量Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.VarId); //变量Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DefaultValue))
 {
 if (objEditRegionFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objEditRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conEditRegionFlds.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DefaultValue); //缺省值
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DdlItemsOptionId))
 {
 if (objEditRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objEditRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objEditRegionFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objEditRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDdlItemsOptionId, conEditRegionFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsTabId))
 {
 if (objEditRegionFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objEditRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsTabId, conEditRegionFlds.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DsTabId); //数据源表ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.TabFeatureId4Ddl))
 {
 if (objEditRegionFldsEN.TabFeatureId4Ddl  ==  "")
 {
 objEditRegionFldsEN.TabFeatureId4Ddl = null;
 }
 if (objEditRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objEditRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureId4Ddl, conEditRegionFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond1))
 {
 if (objEditRegionFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objEditRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond1, conEditRegionFlds.FldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.FldIdCond1); //字段Id_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond1))
 {
 if (objEditRegionFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objEditRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond1, conEditRegionFlds.VarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.VarIdCond1); //变量Id_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond2))
 {
 if (objEditRegionFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objEditRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond2, conEditRegionFlds.FldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.FldIdCond2); //字段Id_条件2
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond2))
 {
 if (objEditRegionFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objEditRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond2, conEditRegionFlds.VarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.VarIdCond2); //数据源字段_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsCondStr))
 {
 if (objEditRegionFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objEditRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsCondStr, conEditRegionFlds.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DsCondStr); //数据源条件串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsSqlStr))
 {
 if (objEditRegionFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objEditRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsSqlStr, conEditRegionFlds.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DsSqlStr); //数据源SQL串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ItemsString))
 {
 if (objEditRegionFldsEN.ItemsString !=  null)
 {
 var strItemsString = objEditRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strItemsString, conEditRegionFlds.ItemsString); //列表项串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ItemsString); //列表项串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColSpan))
 {
 if (objEditRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.ColSpan, conEditRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColIndex))
 {
 if (objEditRegionFldsEN.ColIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.ColIndex, conEditRegionFlds.ColIndex); //列序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ColIndex); //列序号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Width))
 {
 if (objEditRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.Width, conEditRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.Width); //宽
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.IsMultiRow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEditRegionFldsEN.IsMultiRow == true?"1":"0", conEditRegionFlds.IsMultiRow); //是否多行
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.SeqNum))
 {
 if (objEditRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.SeqNum, conEditRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InOutTypeId))
 {
 if (objEditRegionFldsEN.InOutTypeId  ==  "")
 {
 objEditRegionFldsEN.InOutTypeId = null;
 }
 if (objEditRegionFldsEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objEditRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conEditRegionFlds.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ClickEvent))
 {
 if (objEditRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objEditRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClickEvent, conEditRegionFlds.ClickEvent); //Click事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ClickEvent); //Click事件
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ChangeEvent))
 {
 if (objEditRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objEditRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChangeEvent, conEditRegionFlds.ChangeEvent); //Change事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ChangeEvent); //Change事件
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEditRegionFldsEN.InUse == true?"1":"0", conEditRegionFlds.InUse); //是否在用
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ErrMsg))
 {
 if (objEditRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objEditRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conEditRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.PrjId))
 {
 if (objEditRegionFldsEN.PrjId  ==  "")
 {
 objEditRegionFldsEN.PrjId = null;
 }
 if (objEditRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objEditRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conEditRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdUser))
 {
 if (objEditRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objEditRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conEditRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdDate))
 {
 if (objEditRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objEditRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conEditRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Memo))
 {
 if (objEditRegionFldsEN.Memo !=  null)
 {
 var strMemo = objEditRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conEditRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objEditRegionFldsEN.mId); 
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
 /// <param name = "objEditRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsEditRegionFldsEN objEditRegionFldsEN, string strCondition)
{
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEditRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update EditRegionFlds Set ");
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.RegionId))
 {
 if (objEditRegionFldsEN.RegionId  ==  "")
 {
 objEditRegionFldsEN.RegionId = null;
 }
 if (objEditRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objEditRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldId))
 {
 if (objEditRegionFldsEN.FldId !=  null)
 {
 var strFldId = objEditRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.LabelCaption))
 {
 if (objEditRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objEditRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelCaption = '{0}',", strLabelCaption); //标签标题
 }
 else
 {
 sbSQL.Append(" LabelCaption = null,"); //标签标题
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CtlTypeId))
 {
 if (objEditRegionFldsEN.CtlTypeId  ==  "")
 {
 objEditRegionFldsEN.CtlTypeId = null;
 }
 if (objEditRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objEditRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CallTabFeatureId))
 {
 if (objEditRegionFldsEN.CallTabFeatureId !=  null)
 {
 var strCallTabFeatureId = objEditRegionFldsEN.CallTabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CallTabFeatureId = '{0}',", strCallTabFeatureId); //调用表功能Id
 }
 else
 {
 sbSQL.Append(" CallTabFeatureId = null,"); //调用表功能Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarId))
 {
 if (objEditRegionFldsEN.VarId !=  null)
 {
 var strVarId = objEditRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarId = '{0}',", strVarId); //变量Id
 }
 else
 {
 sbSQL.Append(" VarId = null,"); //变量Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DefaultValue))
 {
 if (objEditRegionFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objEditRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DdlItemsOptionId))
 {
 if (objEditRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objEditRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objEditRegionFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objEditRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DdlItemsOptionId = '{0}',", strDdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.Append(" DdlItemsOptionId = null,"); //下拉框列表选项ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsTabId))
 {
 if (objEditRegionFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objEditRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsTabId = '{0}',", strDsTabId); //数据源表ID
 }
 else
 {
 sbSQL.Append(" DsTabId = null,"); //数据源表ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.TabFeatureId4Ddl))
 {
 if (objEditRegionFldsEN.TabFeatureId4Ddl  ==  "")
 {
 objEditRegionFldsEN.TabFeatureId4Ddl = null;
 }
 if (objEditRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objEditRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureId4Ddl = '{0}',", strTabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.Append(" TabFeatureId4Ddl = null,"); //下拉框表功能Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond1))
 {
 if (objEditRegionFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objEditRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond1 = '{0}',", strFldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.Append(" FldIdCond1 = null,"); //字段Id_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond1))
 {
 if (objEditRegionFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objEditRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond1 = '{0}',", strVarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond1 = null,"); //变量Id_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond2))
 {
 if (objEditRegionFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objEditRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond2 = '{0}',", strFldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.Append(" FldIdCond2 = null,"); //字段Id_条件2
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond2))
 {
 if (objEditRegionFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objEditRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond2 = '{0}',", strVarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond2 = null,"); //数据源字段_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsCondStr))
 {
 if (objEditRegionFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objEditRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsCondStr = '{0}',", strDsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.Append(" DsCondStr = null,"); //数据源条件串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsSqlStr))
 {
 if (objEditRegionFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objEditRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsSqlStr = '{0}',", strDsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.Append(" DsSqlStr = null,"); //数据源SQL串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ItemsString))
 {
 if (objEditRegionFldsEN.ItemsString !=  null)
 {
 var strItemsString = objEditRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ItemsString = '{0}',", strItemsString); //列表项串
 }
 else
 {
 sbSQL.Append(" ItemsString = null,"); //列表项串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColSpan))
 {
 if (objEditRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.ColSpan, conEditRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColIndex))
 {
 if (objEditRegionFldsEN.ColIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.ColIndex, conEditRegionFlds.ColIndex); //列序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ColIndex); //列序号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Width))
 {
 if (objEditRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.Width, conEditRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.Width); //宽
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.IsMultiRow))
 {
 sbSQL.AppendFormat(" IsMultiRow = '{0}',", objEditRegionFldsEN.IsMultiRow == true?"1":"0"); //是否多行
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.SeqNum))
 {
 if (objEditRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.SeqNum, conEditRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InOutTypeId))
 {
 if (objEditRegionFldsEN.InOutTypeId  ==  "")
 {
 objEditRegionFldsEN.InOutTypeId = null;
 }
 if (objEditRegionFldsEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objEditRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ClickEvent))
 {
 if (objEditRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objEditRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClickEvent = '{0}',", strClickEvent); //Click事件
 }
 else
 {
 sbSQL.Append(" ClickEvent = null,"); //Click事件
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ChangeEvent))
 {
 if (objEditRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objEditRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChangeEvent = '{0}',", strChangeEvent); //Change事件
 }
 else
 {
 sbSQL.Append(" ChangeEvent = null,"); //Change事件
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objEditRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ErrMsg))
 {
 if (objEditRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objEditRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.PrjId))
 {
 if (objEditRegionFldsEN.PrjId  ==  "")
 {
 objEditRegionFldsEN.PrjId = null;
 }
 if (objEditRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objEditRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdUser))
 {
 if (objEditRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objEditRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdDate))
 {
 if (objEditRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objEditRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Memo))
 {
 if (objEditRegionFldsEN.Memo !=  null)
 {
 var strMemo = objEditRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objEditRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsEditRegionFldsEN objEditRegionFldsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEditRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update EditRegionFlds Set ");
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.RegionId))
 {
 if (objEditRegionFldsEN.RegionId  ==  "")
 {
 objEditRegionFldsEN.RegionId = null;
 }
 if (objEditRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objEditRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldId))
 {
 if (objEditRegionFldsEN.FldId !=  null)
 {
 var strFldId = objEditRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.LabelCaption))
 {
 if (objEditRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objEditRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelCaption = '{0}',", strLabelCaption); //标签标题
 }
 else
 {
 sbSQL.Append(" LabelCaption = null,"); //标签标题
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CtlTypeId))
 {
 if (objEditRegionFldsEN.CtlTypeId  ==  "")
 {
 objEditRegionFldsEN.CtlTypeId = null;
 }
 if (objEditRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objEditRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CallTabFeatureId))
 {
 if (objEditRegionFldsEN.CallTabFeatureId !=  null)
 {
 var strCallTabFeatureId = objEditRegionFldsEN.CallTabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CallTabFeatureId = '{0}',", strCallTabFeatureId); //调用表功能Id
 }
 else
 {
 sbSQL.Append(" CallTabFeatureId = null,"); //调用表功能Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarId))
 {
 if (objEditRegionFldsEN.VarId !=  null)
 {
 var strVarId = objEditRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarId = '{0}',", strVarId); //变量Id
 }
 else
 {
 sbSQL.Append(" VarId = null,"); //变量Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DefaultValue))
 {
 if (objEditRegionFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objEditRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DdlItemsOptionId))
 {
 if (objEditRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objEditRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objEditRegionFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objEditRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DdlItemsOptionId = '{0}',", strDdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.Append(" DdlItemsOptionId = null,"); //下拉框列表选项ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsTabId))
 {
 if (objEditRegionFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objEditRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsTabId = '{0}',", strDsTabId); //数据源表ID
 }
 else
 {
 sbSQL.Append(" DsTabId = null,"); //数据源表ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.TabFeatureId4Ddl))
 {
 if (objEditRegionFldsEN.TabFeatureId4Ddl  ==  "")
 {
 objEditRegionFldsEN.TabFeatureId4Ddl = null;
 }
 if (objEditRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objEditRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureId4Ddl = '{0}',", strTabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.Append(" TabFeatureId4Ddl = null,"); //下拉框表功能Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond1))
 {
 if (objEditRegionFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objEditRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond1 = '{0}',", strFldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.Append(" FldIdCond1 = null,"); //字段Id_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond1))
 {
 if (objEditRegionFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objEditRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond1 = '{0}',", strVarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond1 = null,"); //变量Id_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond2))
 {
 if (objEditRegionFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objEditRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond2 = '{0}',", strFldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.Append(" FldIdCond2 = null,"); //字段Id_条件2
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond2))
 {
 if (objEditRegionFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objEditRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond2 = '{0}',", strVarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond2 = null,"); //数据源字段_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsCondStr))
 {
 if (objEditRegionFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objEditRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsCondStr = '{0}',", strDsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.Append(" DsCondStr = null,"); //数据源条件串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsSqlStr))
 {
 if (objEditRegionFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objEditRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsSqlStr = '{0}',", strDsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.Append(" DsSqlStr = null,"); //数据源SQL串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ItemsString))
 {
 if (objEditRegionFldsEN.ItemsString !=  null)
 {
 var strItemsString = objEditRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ItemsString = '{0}',", strItemsString); //列表项串
 }
 else
 {
 sbSQL.Append(" ItemsString = null,"); //列表项串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColSpan))
 {
 if (objEditRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.ColSpan, conEditRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColIndex))
 {
 if (objEditRegionFldsEN.ColIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.ColIndex, conEditRegionFlds.ColIndex); //列序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ColIndex); //列序号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Width))
 {
 if (objEditRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.Width, conEditRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.Width); //宽
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.IsMultiRow))
 {
 sbSQL.AppendFormat(" IsMultiRow = '{0}',", objEditRegionFldsEN.IsMultiRow == true?"1":"0"); //是否多行
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.SeqNum))
 {
 if (objEditRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.SeqNum, conEditRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InOutTypeId))
 {
 if (objEditRegionFldsEN.InOutTypeId  ==  "")
 {
 objEditRegionFldsEN.InOutTypeId = null;
 }
 if (objEditRegionFldsEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objEditRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ClickEvent))
 {
 if (objEditRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objEditRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClickEvent = '{0}',", strClickEvent); //Click事件
 }
 else
 {
 sbSQL.Append(" ClickEvent = null,"); //Click事件
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ChangeEvent))
 {
 if (objEditRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objEditRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChangeEvent = '{0}',", strChangeEvent); //Change事件
 }
 else
 {
 sbSQL.Append(" ChangeEvent = null,"); //Change事件
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objEditRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ErrMsg))
 {
 if (objEditRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objEditRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.PrjId))
 {
 if (objEditRegionFldsEN.PrjId  ==  "")
 {
 objEditRegionFldsEN.PrjId = null;
 }
 if (objEditRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objEditRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdUser))
 {
 if (objEditRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objEditRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdDate))
 {
 if (objEditRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objEditRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Memo))
 {
 if (objEditRegionFldsEN.Memo !=  null)
 {
 var strMemo = objEditRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsEditRegionFldsEN objEditRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEditRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEditRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update EditRegionFlds Set ");
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.RegionId))
 {
 if (objEditRegionFldsEN.RegionId  ==  "")
 {
 objEditRegionFldsEN.RegionId = null;
 }
 if (objEditRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objEditRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conEditRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldId))
 {
 if (objEditRegionFldsEN.FldId !=  null)
 {
 var strFldId = objEditRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conEditRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.FldId); //字段Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.LabelCaption))
 {
 if (objEditRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objEditRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelCaption, conEditRegionFlds.LabelCaption); //标签标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.LabelCaption); //标签标题
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CtlTypeId))
 {
 if (objEditRegionFldsEN.CtlTypeId  ==  "")
 {
 objEditRegionFldsEN.CtlTypeId = null;
 }
 if (objEditRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objEditRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conEditRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.CallTabFeatureId))
 {
 if (objEditRegionFldsEN.CallTabFeatureId !=  null)
 {
 var strCallTabFeatureId = objEditRegionFldsEN.CallTabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCallTabFeatureId, conEditRegionFlds.CallTabFeatureId); //调用表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.CallTabFeatureId); //调用表功能Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarId))
 {
 if (objEditRegionFldsEN.VarId !=  null)
 {
 var strVarId = objEditRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarId, conEditRegionFlds.VarId); //变量Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.VarId); //变量Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DefaultValue))
 {
 if (objEditRegionFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objEditRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conEditRegionFlds.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DefaultValue); //缺省值
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DdlItemsOptionId))
 {
 if (objEditRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objEditRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objEditRegionFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objEditRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDdlItemsOptionId, conEditRegionFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsTabId))
 {
 if (objEditRegionFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objEditRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsTabId, conEditRegionFlds.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DsTabId); //数据源表ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.TabFeatureId4Ddl))
 {
 if (objEditRegionFldsEN.TabFeatureId4Ddl  ==  "")
 {
 objEditRegionFldsEN.TabFeatureId4Ddl = null;
 }
 if (objEditRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objEditRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureId4Ddl, conEditRegionFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond1))
 {
 if (objEditRegionFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objEditRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond1, conEditRegionFlds.FldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.FldIdCond1); //字段Id_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond1))
 {
 if (objEditRegionFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objEditRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond1, conEditRegionFlds.VarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.VarIdCond1); //变量Id_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.FldIdCond2))
 {
 if (objEditRegionFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objEditRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond2, conEditRegionFlds.FldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.FldIdCond2); //字段Id_条件2
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.VarIdCond2))
 {
 if (objEditRegionFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objEditRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond2, conEditRegionFlds.VarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.VarIdCond2); //数据源字段_条件1
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsCondStr))
 {
 if (objEditRegionFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objEditRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsCondStr, conEditRegionFlds.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DsCondStr); //数据源条件串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.DsSqlStr))
 {
 if (objEditRegionFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objEditRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsSqlStr, conEditRegionFlds.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.DsSqlStr); //数据源SQL串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ItemsString))
 {
 if (objEditRegionFldsEN.ItemsString !=  null)
 {
 var strItemsString = objEditRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strItemsString, conEditRegionFlds.ItemsString); //列表项串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ItemsString); //列表项串
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColSpan))
 {
 if (objEditRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.ColSpan, conEditRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ColIndex))
 {
 if (objEditRegionFldsEN.ColIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.ColIndex, conEditRegionFlds.ColIndex); //列序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ColIndex); //列序号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Width))
 {
 if (objEditRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.Width, conEditRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.Width); //宽
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.IsMultiRow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEditRegionFldsEN.IsMultiRow == true?"1":"0", conEditRegionFlds.IsMultiRow); //是否多行
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.SeqNum))
 {
 if (objEditRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEditRegionFldsEN.SeqNum, conEditRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InOutTypeId))
 {
 if (objEditRegionFldsEN.InOutTypeId  ==  "")
 {
 objEditRegionFldsEN.InOutTypeId = null;
 }
 if (objEditRegionFldsEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objEditRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conEditRegionFlds.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ClickEvent))
 {
 if (objEditRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objEditRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClickEvent, conEditRegionFlds.ClickEvent); //Click事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ClickEvent); //Click事件
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ChangeEvent))
 {
 if (objEditRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objEditRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChangeEvent, conEditRegionFlds.ChangeEvent); //Change事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ChangeEvent); //Change事件
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEditRegionFldsEN.InUse == true?"1":"0", conEditRegionFlds.InUse); //是否在用
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.ErrMsg))
 {
 if (objEditRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objEditRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conEditRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.PrjId))
 {
 if (objEditRegionFldsEN.PrjId  ==  "")
 {
 objEditRegionFldsEN.PrjId = null;
 }
 if (objEditRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objEditRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conEditRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdUser))
 {
 if (objEditRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objEditRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conEditRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.UpdDate))
 {
 if (objEditRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objEditRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conEditRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objEditRegionFldsEN.IsUpdated(conEditRegionFlds.Memo))
 {
 if (objEditRegionFldsEN.Memo !=  null)
 {
 var strMemo = objEditRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conEditRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEditRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objEditRegionFldsEN.mId); 
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("EditRegionFlds_Delete", values);
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
//删除EditRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from EditRegionFlds where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelEditRegionFlds(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
//删除EditRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from EditRegionFlds where mId in (" + strKeyList + ")";
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
//删除EditRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from EditRegionFlds where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelEditRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: DelEditRegionFlds)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from EditRegionFlds where " + strCondition ;
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
public bool DelEditRegionFldsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsEditRegionFldsDA: DelEditRegionFldsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from EditRegionFlds where " + strCondition ;
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
 /// <param name = "objEditRegionFldsENS">源对象</param>
 /// <param name = "objEditRegionFldsENT">目标对象</param>
public void CopyTo(clsEditRegionFldsEN objEditRegionFldsENS, clsEditRegionFldsEN objEditRegionFldsENT)
{
objEditRegionFldsENT.mId = objEditRegionFldsENS.mId; //mId
objEditRegionFldsENT.RegionId = objEditRegionFldsENS.RegionId; //区域Id
objEditRegionFldsENT.FldId = objEditRegionFldsENS.FldId; //字段Id
objEditRegionFldsENT.LabelCaption = objEditRegionFldsENS.LabelCaption; //标签标题
objEditRegionFldsENT.CtlTypeId = objEditRegionFldsENS.CtlTypeId; //控件类型号
objEditRegionFldsENT.CallTabFeatureId = objEditRegionFldsENS.CallTabFeatureId; //调用表功能Id
objEditRegionFldsENT.VarId = objEditRegionFldsENS.VarId; //变量Id
objEditRegionFldsENT.DefaultValue = objEditRegionFldsENS.DefaultValue; //缺省值
objEditRegionFldsENT.DdlItemsOptionId = objEditRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objEditRegionFldsENT.DsTabId = objEditRegionFldsENS.DsTabId; //数据源表ID
objEditRegionFldsENT.TabFeatureId4Ddl = objEditRegionFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objEditRegionFldsENT.FldIdCond1 = objEditRegionFldsENS.FldIdCond1; //字段Id_条件1
objEditRegionFldsENT.VarIdCond1 = objEditRegionFldsENS.VarIdCond1; //变量Id_条件1
objEditRegionFldsENT.FldIdCond2 = objEditRegionFldsENS.FldIdCond2; //字段Id_条件2
objEditRegionFldsENT.VarIdCond2 = objEditRegionFldsENS.VarIdCond2; //数据源字段_条件1
objEditRegionFldsENT.DsCondStr = objEditRegionFldsENS.DsCondStr; //数据源条件串
objEditRegionFldsENT.DsSqlStr = objEditRegionFldsENS.DsSqlStr; //数据源SQL串
objEditRegionFldsENT.ItemsString = objEditRegionFldsENS.ItemsString; //列表项串
objEditRegionFldsENT.ColSpan = objEditRegionFldsENS.ColSpan; //跨列数
objEditRegionFldsENT.ColIndex = objEditRegionFldsENS.ColIndex; //列序号
objEditRegionFldsENT.Width = objEditRegionFldsENS.Width; //宽
objEditRegionFldsENT.IsMultiRow = objEditRegionFldsENS.IsMultiRow; //是否多行
objEditRegionFldsENT.SeqNum = objEditRegionFldsENS.SeqNum; //字段序号
objEditRegionFldsENT.InOutTypeId = objEditRegionFldsENS.InOutTypeId; //INOUT类型ID
objEditRegionFldsENT.ClickEvent = objEditRegionFldsENS.ClickEvent; //Click事件
objEditRegionFldsENT.ChangeEvent = objEditRegionFldsENS.ChangeEvent; //Change事件
objEditRegionFldsENT.InUse = objEditRegionFldsENS.InUse; //是否在用
objEditRegionFldsENT.ErrMsg = objEditRegionFldsENS.ErrMsg; //错误信息
objEditRegionFldsENT.PrjId = objEditRegionFldsENS.PrjId; //工程Id
objEditRegionFldsENT.UpdUser = objEditRegionFldsENS.UpdUser; //修改者
objEditRegionFldsENT.UpdDate = objEditRegionFldsENS.UpdDate; //修改日期
objEditRegionFldsENT.Memo = objEditRegionFldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsEditRegionFldsEN objEditRegionFldsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objEditRegionFldsEN.RegionId, conEditRegionFlds.RegionId);
clsCheckSql.CheckFieldNotNull(objEditRegionFldsEN.CtlTypeId, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldNotNull(objEditRegionFldsEN.PrjId, conEditRegionFlds.PrjId);
clsCheckSql.CheckFieldNotNull(objEditRegionFldsEN.UpdUser, conEditRegionFlds.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.RegionId, 10, conEditRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.FldId, 8, conEditRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.LabelCaption, 150, conEditRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.CtlTypeId, 2, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.CallTabFeatureId, 8, conEditRegionFlds.CallTabFeatureId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.VarId, 8, conEditRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DefaultValue, 50, conEditRegionFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DsTabId, 8, conEditRegionFlds.DsTabId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.TabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.FldIdCond1, 8, conEditRegionFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.VarIdCond1, 8, conEditRegionFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.FldIdCond2, 8, conEditRegionFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.VarIdCond2, 8, conEditRegionFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DsCondStr, 50, conEditRegionFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DsSqlStr, 200, conEditRegionFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ItemsString, 200, conEditRegionFlds.ItemsString);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.InOutTypeId, 2, conEditRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ClickEvent, 50, conEditRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ChangeEvent, 50, conEditRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ErrMsg, 2000, conEditRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.PrjId, 4, conEditRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.UpdUser, 20, conEditRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.UpdDate, 20, conEditRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.Memo, 1000, conEditRegionFlds.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.RegionId, 10, conEditRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.CtlTypeId, 2, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.DdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.TabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.InOutTypeId, 2, conEditRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.PrjId, 4, conEditRegionFlds.PrjId);
 objEditRegionFldsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsEditRegionFldsEN objEditRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.RegionId, 10, conEditRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.FldId, 8, conEditRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.LabelCaption, 150, conEditRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.CtlTypeId, 2, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.CallTabFeatureId, 8, conEditRegionFlds.CallTabFeatureId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.VarId, 8, conEditRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DefaultValue, 50, conEditRegionFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DsTabId, 8, conEditRegionFlds.DsTabId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.TabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.FldIdCond1, 8, conEditRegionFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.VarIdCond1, 8, conEditRegionFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.FldIdCond2, 8, conEditRegionFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.VarIdCond2, 8, conEditRegionFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DsCondStr, 50, conEditRegionFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DsSqlStr, 200, conEditRegionFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ItemsString, 200, conEditRegionFlds.ItemsString);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.InOutTypeId, 2, conEditRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ClickEvent, 50, conEditRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ChangeEvent, 50, conEditRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ErrMsg, 2000, conEditRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.PrjId, 4, conEditRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.UpdUser, 20, conEditRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.UpdDate, 20, conEditRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.Memo, 1000, conEditRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.RegionId, 10, conEditRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.CtlTypeId, 2, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.DdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.TabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.InOutTypeId, 2, conEditRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.PrjId, 4, conEditRegionFlds.PrjId);
 objEditRegionFldsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsEditRegionFldsEN objEditRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.RegionId, 10, conEditRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.FldId, 8, conEditRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.LabelCaption, 150, conEditRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.CtlTypeId, 2, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.CallTabFeatureId, 8, conEditRegionFlds.CallTabFeatureId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.VarId, 8, conEditRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DefaultValue, 50, conEditRegionFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DsTabId, 8, conEditRegionFlds.DsTabId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.TabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.FldIdCond1, 8, conEditRegionFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.VarIdCond1, 8, conEditRegionFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.FldIdCond2, 8, conEditRegionFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.VarIdCond2, 8, conEditRegionFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DsCondStr, 50, conEditRegionFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.DsSqlStr, 200, conEditRegionFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ItemsString, 200, conEditRegionFlds.ItemsString);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.InOutTypeId, 2, conEditRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ClickEvent, 50, conEditRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ChangeEvent, 50, conEditRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.ErrMsg, 2000, conEditRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.PrjId, 4, conEditRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.UpdUser, 20, conEditRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.UpdDate, 20, conEditRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objEditRegionFldsEN.Memo, 1000, conEditRegionFlds.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.RegionId, conEditRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.FldId, conEditRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.LabelCaption, conEditRegionFlds.LabelCaption);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.CtlTypeId, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.CallTabFeatureId, conEditRegionFlds.CallTabFeatureId);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.VarId, conEditRegionFlds.VarId);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.DefaultValue, conEditRegionFlds.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.DdlItemsOptionId, conEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.DsTabId, conEditRegionFlds.DsTabId);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.TabFeatureId4Ddl, conEditRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.FldIdCond1, conEditRegionFlds.FldIdCond1);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.VarIdCond1, conEditRegionFlds.VarIdCond1);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.FldIdCond2, conEditRegionFlds.FldIdCond2);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.VarIdCond2, conEditRegionFlds.VarIdCond2);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.DsCondStr, conEditRegionFlds.DsCondStr);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.DsSqlStr, conEditRegionFlds.DsSqlStr);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.ItemsString, conEditRegionFlds.ItemsString);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.InOutTypeId, conEditRegionFlds.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.ClickEvent, conEditRegionFlds.ClickEvent);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.ChangeEvent, conEditRegionFlds.ChangeEvent);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.ErrMsg, conEditRegionFlds.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.PrjId, conEditRegionFlds.PrjId);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.UpdUser, conEditRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.UpdDate, conEditRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objEditRegionFldsEN.Memo, conEditRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.RegionId, 10, conEditRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.CtlTypeId, 2, conEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.DdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.TabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.InOutTypeId, 2, conEditRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(objEditRegionFldsEN.PrjId, 4, conEditRegionFlds.PrjId);
 objEditRegionFldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--EditRegionFlds(编辑区域字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsEditRegionFldsEN objEditRegionFldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objEditRegionFldsEN.RegionId);
 if (objEditRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null");
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objEditRegionFldsEN.FldId);
}
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsEditRegionFldsEN._CurrTabName);
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsEditRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}