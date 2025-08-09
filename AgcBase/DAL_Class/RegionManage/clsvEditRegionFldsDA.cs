
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEditRegionFldsDA
 表名:vEditRegionFlds(00050126)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:10
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
 /// v编辑区域字段(vEditRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvEditRegionFldsDA : clsCommBase4DA
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
 return clsvEditRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvEditRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvEditRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvEditRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvEditRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vEditRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vEditRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetDataTable_vEditRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vEditRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vEditRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEditRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEditRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vEditRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vEditRegionFlds.* " + 
$"from vEditRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vEditRegionFlds.mId not in " + 
$"(Select top {intTop_In} vEditRegionFlds.mId from vEditRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEditRegionFlds where {1} and mId not in (Select top {2} mId from vEditRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEditRegionFlds where {1} and mId not in (Select top {3} mId from vEditRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vEditRegionFlds.* " + 
$"from vEditRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vEditRegionFlds.mId not in " + 
$"(Select top {intTop_In} vEditRegionFlds.mId from vEditRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEditRegionFlds where {1} and mId not in (Select top {2} mId from vEditRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEditRegionFlds where {1} and mId not in (Select top {3} mId from vEditRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvEditRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vEditRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = TransNullToInt(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = TransNullToBool(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = TransNullToInt(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = TransNullToBool(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEditRegionFldsDA: GetObjLst)", objException.Message));
}
objvEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEditRegionFldsEN);
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
public List<clsvEditRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvEditRegionFldsEN> arrObjLst = new List<clsvEditRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = TransNullToInt(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = TransNullToBool(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = TransNullToInt(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = TransNullToBool(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEditRegionFldsDA: GetObjLst)", objException.Message));
}
objvEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEditRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvEditRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvEditRegionFlds(ref clsvEditRegionFldsEN objvEditRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vEditRegionFlds where mId = " + ""+ objvEditRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvEditRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][convEditRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvEditRegionFldsEN.RegionId = objDT.Rows[0][convEditRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvEditRegionFldsEN.RegionTypeId = objDT.Rows[0][convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvEditRegionFldsEN.TabId = objDT.Rows[0][convEditRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvEditRegionFldsEN.TabName = objDT.Rows[0][convEditRegionFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvEditRegionFldsEN.FldId = objDT.Rows[0][convEditRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvEditRegionFldsEN.FldName = objDT.Rows[0][convEditRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvEditRegionFldsEN.LabelCaption = objDT.Rows[0][convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objvEditRegionFldsEN.CtlTypeId = objDT.Rows[0][convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvEditRegionFldsEN.CtlTypeName = objDT.Rows[0][convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvEditRegionFldsEN.CtlCnName = objDT.Rows[0][convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvEditRegionFldsEN.CtlTypeAbbr = objDT.Rows[0][convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvEditRegionFldsEN.CallTabFeatureId = objDT.Rows[0][convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvEditRegionFldsEN.VarId = objDT.Rows[0][convEditRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objvEditRegionFldsEN.DdlItemsOptionId = objDT.Rows[0][convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objvEditRegionFldsEN.DdlItemsOptionName = objDT.Rows[0][convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名(字段类型:varchar,字段长度:20,是否可空:True)
 objvEditRegionFldsEN.DsTabId = objDT.Rows[0][convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objvEditRegionFldsEN.DsCondStr = objDT.Rows[0][convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objvEditRegionFldsEN.DsSqlStr = objDT.Rows[0][convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objvEditRegionFldsEN.ItemsString = objDT.Rows[0][convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objvEditRegionFldsEN.ColSpan = TransNullToInt(objDT.Rows[0][convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objvEditRegionFldsEN.ColIndex = TransNullToInt(objDT.Rows[0][convEditRegionFlds.ColIndex].ToString().Trim()); //列序号(字段类型:int,字段长度:4,是否可空:False)
 objvEditRegionFldsEN.Width = TransNullToInt(objDT.Rows[0][convEditRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvEditRegionFldsEN.IsMultiRow = TransNullToBool(objDT.Rows[0][convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行(字段类型:bit,字段长度:1,是否可空:True)
 objvEditRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvEditRegionFldsEN.InOutTypeId = objDT.Rows[0][convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvEditRegionFldsEN.InOutTypeName = objDT.Rows[0][convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEditRegionFldsEN.ClickEvent = objDT.Rows[0][convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvEditRegionFldsEN.ChangeEvent = objDT.Rows[0][convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvEditRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][convEditRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvEditRegionFldsEN.UpdUser = objDT.Rows[0][convEditRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvEditRegionFldsEN.UpdDate = objDT.Rows[0][convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvEditRegionFldsEN.Memo = objDT.Rows[0][convEditRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEditRegionFldsEN.PrjId = objDT.Rows[0][convEditRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvEditRegionFldsDA: GetvEditRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvEditRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vEditRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
 objvEditRegionFldsEN.mId = Int32.Parse(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名(字段类型:varchar,字段长度:20,是否可空:True)
 objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号(字段类型:int,字段长度:4,是否可空:False)
 objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行(字段类型:bit,字段长度:1,是否可空:True)
 objvEditRegionFldsEN.SeqNum = Int32.Parse(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvEditRegionFldsDA: GetObjBymId)", objException.Message));
}
return objvEditRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvEditRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vEditRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN()
{
mId = TransNullToInt(objRow[convEditRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(), //区域Id
RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(), //区域类型Id
TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(), //表ID
TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(), //表名
FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(), //字段Id
FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(), //字段名
LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(), //标签标题
CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(), //控件类型名
CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(), //控件类型中文名
CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(), //控件类型缩写
CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(), //调用表功能Id
VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(), //变量Id
DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(), //下拉框列表选项ID
DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(), //下拉选项名
DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(), //数据源表ID
DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(), //数据源条件串
DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(), //数据源SQL串
ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(), //列表项串
ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColSpan].ToString().Trim()), //跨列数
ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColIndex].ToString().Trim()), //列序号
Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.Width].ToString().Trim()), //宽
IsMultiRow = TransNullToBool(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()), //是否多行
SeqNum = TransNullToInt(objRow[convEditRegionFlds.SeqNum].ToString().Trim()), //字段序号
InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(), //INOUT类型ID
InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(), //INOUT类型名称
ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(), //Click事件
ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(), //Change事件
InUse = TransNullToBool(objRow[convEditRegionFlds.InUse].ToString().Trim()), //是否在用
UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(), //说明
PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim() //工程Id
};
objvEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEditRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvEditRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvEditRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = TransNullToInt(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = TransNullToBool(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = TransNullToInt(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = TransNullToBool(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvEditRegionFldsDA: GetObjByDataRowvEditRegionFlds)", objException.Message));
}
objvEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEditRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvEditRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEditRegionFldsEN objvEditRegionFldsEN = new clsvEditRegionFldsEN();
try
{
objvEditRegionFldsEN.mId = TransNullToInt(objRow[convEditRegionFlds.mId].ToString().Trim()); //mId
objvEditRegionFldsEN.RegionId = objRow[convEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objvEditRegionFldsEN.RegionTypeId = objRow[convEditRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvEditRegionFldsEN.TabId = objRow[convEditRegionFlds.TabId].ToString().Trim(); //表ID
objvEditRegionFldsEN.TabName = objRow[convEditRegionFlds.TabName].ToString().Trim(); //表名
objvEditRegionFldsEN.FldId = objRow[convEditRegionFlds.FldId].ToString().Trim(); //字段Id
objvEditRegionFldsEN.FldName = objRow[convEditRegionFlds.FldName].ToString().Trim(); //字段名
objvEditRegionFldsEN.LabelCaption = objRow[convEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvEditRegionFldsEN.CtlTypeId = objRow[convEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvEditRegionFldsEN.CtlTypeName = objRow[convEditRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvEditRegionFldsEN.CtlCnName = objRow[convEditRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvEditRegionFldsEN.CtlTypeAbbr = objRow[convEditRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convEditRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvEditRegionFldsEN.CallTabFeatureId = objRow[convEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[convEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objvEditRegionFldsEN.VarId = objRow[convEditRegionFlds.VarId] == DBNull.Value ? null : objRow[convEditRegionFlds.VarId].ToString().Trim(); //变量Id
objvEditRegionFldsEN.DdlItemsOptionId = objRow[convEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvEditRegionFldsEN.DdlItemsOptionName = objRow[convEditRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convEditRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvEditRegionFldsEN.DsTabId = objRow[convEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[convEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvEditRegionFldsEN.DsCondStr = objRow[convEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvEditRegionFldsEN.DsSqlStr = objRow[convEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvEditRegionFldsEN.ItemsString = objRow[convEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvEditRegionFldsEN.ColSpan = objRow[convEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvEditRegionFldsEN.ColIndex = objRow[convEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objvEditRegionFldsEN.Width = objRow[convEditRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEditRegionFlds.Width].ToString().Trim()); //宽
objvEditRegionFldsEN.IsMultiRow = TransNullToBool(objRow[convEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvEditRegionFldsEN.SeqNum = TransNullToInt(objRow[convEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvEditRegionFldsEN.InOutTypeId = objRow[convEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvEditRegionFldsEN.InOutTypeName = objRow[convEditRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convEditRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvEditRegionFldsEN.ClickEvent = objRow[convEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvEditRegionFldsEN.ChangeEvent = objRow[convEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvEditRegionFldsEN.InUse = TransNullToBool(objRow[convEditRegionFlds.InUse].ToString().Trim()); //是否在用
objvEditRegionFldsEN.UpdUser = objRow[convEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objvEditRegionFldsEN.UpdDate = objRow[convEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvEditRegionFldsEN.Memo = objRow[convEditRegionFlds.Memo].ToString().Trim(); //说明
objvEditRegionFldsEN.PrjId = objRow[convEditRegionFlds.PrjId] == DBNull.Value ? null : objRow[convEditRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvEditRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objvEditRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEditRegionFldsEN;
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
objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEditRegionFldsEN._CurrTabName, convEditRegionFlds.mId, 8, "");
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
objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEditRegionFldsEN._CurrTabName, convEditRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vEditRegionFlds where " + strCondition;
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
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vEditRegionFlds where " + strCondition;
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
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEditRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvEditRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEditRegionFlds", strCondition))
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
objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vEditRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvEditRegionFldsENS">源对象</param>
 /// <param name = "objvEditRegionFldsENT">目标对象</param>
public void CopyTo(clsvEditRegionFldsEN objvEditRegionFldsENS, clsvEditRegionFldsEN objvEditRegionFldsENT)
{
objvEditRegionFldsENT.mId = objvEditRegionFldsENS.mId; //mId
objvEditRegionFldsENT.RegionId = objvEditRegionFldsENS.RegionId; //区域Id
objvEditRegionFldsENT.RegionTypeId = objvEditRegionFldsENS.RegionTypeId; //区域类型Id
objvEditRegionFldsENT.TabId = objvEditRegionFldsENS.TabId; //表ID
objvEditRegionFldsENT.TabName = objvEditRegionFldsENS.TabName; //表名
objvEditRegionFldsENT.FldId = objvEditRegionFldsENS.FldId; //字段Id
objvEditRegionFldsENT.FldName = objvEditRegionFldsENS.FldName; //字段名
objvEditRegionFldsENT.LabelCaption = objvEditRegionFldsENS.LabelCaption; //标签标题
objvEditRegionFldsENT.CtlTypeId = objvEditRegionFldsENS.CtlTypeId; //控件类型号
objvEditRegionFldsENT.CtlTypeName = objvEditRegionFldsENS.CtlTypeName; //控件类型名
objvEditRegionFldsENT.CtlCnName = objvEditRegionFldsENS.CtlCnName; //控件类型中文名
objvEditRegionFldsENT.CtlTypeAbbr = objvEditRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvEditRegionFldsENT.CallTabFeatureId = objvEditRegionFldsENS.CallTabFeatureId; //调用表功能Id
objvEditRegionFldsENT.VarId = objvEditRegionFldsENS.VarId; //变量Id
objvEditRegionFldsENT.DdlItemsOptionId = objvEditRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objvEditRegionFldsENT.DdlItemsOptionName = objvEditRegionFldsENS.DdlItemsOptionName; //下拉选项名
objvEditRegionFldsENT.DsTabId = objvEditRegionFldsENS.DsTabId; //数据源表ID
objvEditRegionFldsENT.DsCondStr = objvEditRegionFldsENS.DsCondStr; //数据源条件串
objvEditRegionFldsENT.DsSqlStr = objvEditRegionFldsENS.DsSqlStr; //数据源SQL串
objvEditRegionFldsENT.ItemsString = objvEditRegionFldsENS.ItemsString; //列表项串
objvEditRegionFldsENT.ColSpan = objvEditRegionFldsENS.ColSpan; //跨列数
objvEditRegionFldsENT.ColIndex = objvEditRegionFldsENS.ColIndex; //列序号
objvEditRegionFldsENT.Width = objvEditRegionFldsENS.Width; //宽
objvEditRegionFldsENT.IsMultiRow = objvEditRegionFldsENS.IsMultiRow; //是否多行
objvEditRegionFldsENT.SeqNum = objvEditRegionFldsENS.SeqNum; //字段序号
objvEditRegionFldsENT.InOutTypeId = objvEditRegionFldsENS.InOutTypeId; //INOUT类型ID
objvEditRegionFldsENT.InOutTypeName = objvEditRegionFldsENS.InOutTypeName; //INOUT类型名称
objvEditRegionFldsENT.ClickEvent = objvEditRegionFldsENS.ClickEvent; //Click事件
objvEditRegionFldsENT.ChangeEvent = objvEditRegionFldsENS.ChangeEvent; //Change事件
objvEditRegionFldsENT.InUse = objvEditRegionFldsENS.InUse; //是否在用
objvEditRegionFldsENT.UpdUser = objvEditRegionFldsENS.UpdUser; //修改者
objvEditRegionFldsENT.UpdDate = objvEditRegionFldsENS.UpdDate; //修改日期
objvEditRegionFldsENT.Memo = objvEditRegionFldsENS.Memo; //说明
objvEditRegionFldsENT.PrjId = objvEditRegionFldsENS.PrjId; //工程Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvEditRegionFldsEN objvEditRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.RegionId, 10, convEditRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.RegionTypeId, 4, convEditRegionFlds.RegionTypeId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.TabId, 8, convEditRegionFlds.TabId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.TabName, 100, convEditRegionFlds.TabName);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.FldId, 8, convEditRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.FldName, 50, convEditRegionFlds.FldName);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.LabelCaption, 150, convEditRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.CtlTypeId, 2, convEditRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.CtlTypeName, 30, convEditRegionFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.CtlCnName, 50, convEditRegionFlds.CtlCnName);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.CtlTypeAbbr, 5, convEditRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.CallTabFeatureId, 8, convEditRegionFlds.CallTabFeatureId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.VarId, 8, convEditRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.DdlItemsOptionId, 2, convEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.DdlItemsOptionName, 20, convEditRegionFlds.DdlItemsOptionName);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.DsTabId, 8, convEditRegionFlds.DsTabId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.DsCondStr, 50, convEditRegionFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.DsSqlStr, 200, convEditRegionFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.ItemsString, 200, convEditRegionFlds.ItemsString);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.InOutTypeId, 2, convEditRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.InOutTypeName, 30, convEditRegionFlds.InOutTypeName);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.ClickEvent, 50, convEditRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.ChangeEvent, 50, convEditRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.UpdUser, 20, convEditRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.UpdDate, 20, convEditRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.Memo, 1000, convEditRegionFlds.Memo);
clsCheckSql.CheckFieldLen(objvEditRegionFldsEN.PrjId, 4, convEditRegionFlds.PrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.RegionId, convEditRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.RegionTypeId, convEditRegionFlds.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.TabId, convEditRegionFlds.TabId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.TabName, convEditRegionFlds.TabName);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.FldId, convEditRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.FldName, convEditRegionFlds.FldName);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.LabelCaption, convEditRegionFlds.LabelCaption);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.CtlTypeId, convEditRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.CtlTypeName, convEditRegionFlds.CtlTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.CtlCnName, convEditRegionFlds.CtlCnName);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.CtlTypeAbbr, convEditRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.CallTabFeatureId, convEditRegionFlds.CallTabFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.VarId, convEditRegionFlds.VarId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.DdlItemsOptionId, convEditRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.DdlItemsOptionName, convEditRegionFlds.DdlItemsOptionName);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.DsTabId, convEditRegionFlds.DsTabId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.DsCondStr, convEditRegionFlds.DsCondStr);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.DsSqlStr, convEditRegionFlds.DsSqlStr);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.ItemsString, convEditRegionFlds.ItemsString);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.InOutTypeId, convEditRegionFlds.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.InOutTypeName, convEditRegionFlds.InOutTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.ClickEvent, convEditRegionFlds.ClickEvent);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.ChangeEvent, convEditRegionFlds.ChangeEvent);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.UpdUser, convEditRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.UpdDate, convEditRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.Memo, convEditRegionFlds.Memo);
clsCheckSql.CheckSqlInjection4Field(objvEditRegionFldsEN.PrjId, convEditRegionFlds.PrjId);
//检查外键字段长度
 objvEditRegionFldsEN._IsCheckProperty = true;
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
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEditRegionFldsEN._CurrTabName);
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
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEditRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsvEditRegionFldsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}