
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQryRegionFldsDA
 表名:QryRegionFlds(00050115)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:59
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
 /// 查询区域字段(QryRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQryRegionFldsDA : clsCommBase4DA
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
 return clsQryRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQryRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQryRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQryRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQryRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QryRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetDataTable_QryRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QryRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QryRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QryRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} QryRegionFlds.* " + 
$"from QryRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and QryRegionFlds.mId not in " + 
$"(Select top {intTop_In} QryRegionFlds.mId from QryRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QryRegionFlds where {1} and mId not in (Select top {2} mId from QryRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QryRegionFlds where {1} and mId not in (Select top {3} mId from QryRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} QryRegionFlds.* " + 
$"from QryRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and QryRegionFlds.mId not in " + 
$"(Select top {intTop_In} QryRegionFlds.mId from QryRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QryRegionFlds where {1} and mId not in (Select top {2} mId from QryRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QryRegionFlds where {1} and mId not in (Select top {3} mId from QryRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsQryRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQryRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = TransNullToInt(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = TransNullToBool(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQryRegionFldsDA: GetObjLst)", objException.Message));
}
objQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQryRegionFldsEN);
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
public List<clsQryRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQryRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = TransNullToInt(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = TransNullToBool(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQryRegionFldsDA: GetObjLst)", objException.Message));
}
objQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQryRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQryRegionFlds(ref clsQryRegionFldsEN objQryRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where mId = " + ""+ objQryRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQryRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][conQryRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objQryRegionFldsEN.RegionId = objDT.Rows[0][conQryRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objQryRegionFldsEN.FldId = objDT.Rows[0][conQryRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objQryRegionFldsEN.OutFldId = objDT.Rows[0][conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.LabelCaption = objDT.Rows[0][conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objQryRegionFldsEN.CtlTypeId = objDT.Rows[0][conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objQryRegionFldsEN.VarId = objDT.Rows[0][conQryRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.DsTabId = objDT.Rows[0][conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objQryRegionFldsEN.TabFeatureId4Ddl = objDT.Rows[0][conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.FldIdCond1 = objDT.Rows[0][conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.VarIdCond1 = objDT.Rows[0][conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.FldIdCond2 = objDT.Rows[0][conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.VarIdCond2 = objDT.Rows[0][conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.QueryOptionId = objDT.Rows[0][conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id(字段类型:varchar,字段长度:2,是否可空:False)
 objQryRegionFldsEN.DdlItemsOptionId = objDT.Rows[0][conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objQryRegionFldsEN.DsSqlStr = objDT.Rows[0][conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objQryRegionFldsEN.ItemsString = objDT.Rows[0][conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objQryRegionFldsEN.DsCondStr = objDT.Rows[0][conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objQryRegionFldsEN.ColSpan = TransNullToInt(objDT.Rows[0][conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objQryRegionFldsEN.Width = TransNullToInt(objDT.Rows[0][conQryRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objQryRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objQryRegionFldsEN.ChangeEvent = objDT.Rows[0][conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objQryRegionFldsEN.ClickEvent = objDT.Rows[0][conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objQryRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][conQryRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQryRegionFldsEN.ErrMsg = objDT.Rows[0][conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objQryRegionFldsEN.PrjId = objDT.Rows[0][conQryRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objQryRegionFldsEN.UpdUser = objDT.Rows[0][conQryRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objQryRegionFldsEN.UpdDate = objDT.Rows[0][conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQryRegionFldsEN.Memo = objDT.Rows[0][conQryRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQryRegionFldsDA: GetQryRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsQryRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
 objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1(字段类型:char,字段长度:8,是否可空:True)
 objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id(字段类型:varchar,字段长度:2,是否可空:False)
 objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQryRegionFldsDA: GetObjBymId)", objException.Message));
}
return objQryRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQryRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN()
{
mId = TransNullToInt(objRow[conQryRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(), //区域Id
FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(), //字段Id
OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(), //OutFldId
LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(), //标签标题
CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(), //变量Id
DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(), //数据源表ID
TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(), //下拉框表功能Id
FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(), //字段Id_条件1
VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(), //变量Id_条件1
FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(), //字段Id_条件2
VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(), //数据源字段_条件1
QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(), //查询方式Id
DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(), //下拉框列表选项ID
DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(), //数据源SQL串
ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(), //列表项串
DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(), //数据源条件串
ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.ColSpan].ToString().Trim()), //跨列数
Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.Width].ToString().Trim()), //宽
SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.SeqNum].ToString().Trim()), //字段序号
ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(), //Change事件
ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(), //Click事件
InUse = TransNullToBool(objRow[conQryRegionFlds.InUse].ToString().Trim()), //是否在用
ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim() //说明
};
objQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQryRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQryRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQryRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = TransNullToInt(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = TransNullToBool(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQryRegionFldsDA: GetObjByDataRowQryRegionFlds)", objException.Message));
}
objQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQryRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQryRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = TransNullToInt(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = TransNullToBool(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQryRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQryRegionFldsEN;
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
objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQryRegionFldsEN._CurrTabName, conQryRegionFlds.mId, 8, "");
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
objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQryRegionFldsEN._CurrTabName, conQryRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from QryRegionFlds where " + strCondition;
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from QryRegionFlds where " + strCondition;
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QryRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQryRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QryRegionFlds", strCondition))
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
objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QryRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQryRegionFldsEN objQryRegionFldsEN)
 {
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQryRegionFldsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QryRegionFlds");
objRow = objDS.Tables["QryRegionFlds"].NewRow();
objRow[conQryRegionFlds.RegionId] = objQryRegionFldsEN.RegionId; //区域Id
 if (objQryRegionFldsEN.FldId !=  "")
 {
objRow[conQryRegionFlds.FldId] = objQryRegionFldsEN.FldId; //字段Id
 }
 if (objQryRegionFldsEN.OutFldId !=  "")
 {
objRow[conQryRegionFlds.OutFldId] = objQryRegionFldsEN.OutFldId; //OutFldId
 }
 if (objQryRegionFldsEN.LabelCaption !=  "")
 {
objRow[conQryRegionFlds.LabelCaption] = objQryRegionFldsEN.LabelCaption; //标签标题
 }
 if (objQryRegionFldsEN.CtlTypeId !=  "")
 {
objRow[conQryRegionFlds.CtlTypeId] = objQryRegionFldsEN.CtlTypeId; //控件类型号
 }
 if (objQryRegionFldsEN.VarId !=  "")
 {
objRow[conQryRegionFlds.VarId] = objQryRegionFldsEN.VarId; //变量Id
 }
 if (objQryRegionFldsEN.DsTabId !=  "")
 {
objRow[conQryRegionFlds.DsTabId] = objQryRegionFldsEN.DsTabId; //数据源表ID
 }
 if (objQryRegionFldsEN.TabFeatureId4Ddl !=  "")
 {
objRow[conQryRegionFlds.TabFeatureId4Ddl] = objQryRegionFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
 }
 if (objQryRegionFldsEN.FldIdCond1 !=  "")
 {
objRow[conQryRegionFlds.FldIdCond1] = objQryRegionFldsEN.FldIdCond1; //字段Id_条件1
 }
 if (objQryRegionFldsEN.VarIdCond1 !=  "")
 {
objRow[conQryRegionFlds.VarIdCond1] = objQryRegionFldsEN.VarIdCond1; //变量Id_条件1
 }
 if (objQryRegionFldsEN.FldIdCond2 !=  "")
 {
objRow[conQryRegionFlds.FldIdCond2] = objQryRegionFldsEN.FldIdCond2; //字段Id_条件2
 }
 if (objQryRegionFldsEN.VarIdCond2 !=  "")
 {
objRow[conQryRegionFlds.VarIdCond2] = objQryRegionFldsEN.VarIdCond2; //数据源字段_条件1
 }
 if (objQryRegionFldsEN.QueryOptionId !=  "")
 {
objRow[conQryRegionFlds.QueryOptionId] = objQryRegionFldsEN.QueryOptionId; //查询方式Id
 }
 if (objQryRegionFldsEN.DdlItemsOptionId !=  "")
 {
objRow[conQryRegionFlds.DdlItemsOptionId] = objQryRegionFldsEN.DdlItemsOptionId; //下拉框列表选项ID
 }
 if (objQryRegionFldsEN.DsSqlStr !=  "")
 {
objRow[conQryRegionFlds.DsSqlStr] = objQryRegionFldsEN.DsSqlStr; //数据源SQL串
 }
 if (objQryRegionFldsEN.ItemsString !=  "")
 {
objRow[conQryRegionFlds.ItemsString] = objQryRegionFldsEN.ItemsString; //列表项串
 }
 if (objQryRegionFldsEN.DsCondStr !=  "")
 {
objRow[conQryRegionFlds.DsCondStr] = objQryRegionFldsEN.DsCondStr; //数据源条件串
 }
objRow[conQryRegionFlds.ColSpan] = objQryRegionFldsEN.ColSpan; //跨列数
objRow[conQryRegionFlds.Width] = objQryRegionFldsEN.Width; //宽
objRow[conQryRegionFlds.SeqNum] = objQryRegionFldsEN.SeqNum; //字段序号
 if (objQryRegionFldsEN.ChangeEvent !=  "")
 {
objRow[conQryRegionFlds.ChangeEvent] = objQryRegionFldsEN.ChangeEvent; //Change事件
 }
 if (objQryRegionFldsEN.ClickEvent !=  "")
 {
objRow[conQryRegionFlds.ClickEvent] = objQryRegionFldsEN.ClickEvent; //Click事件
 }
objRow[conQryRegionFlds.InUse] = objQryRegionFldsEN.InUse; //是否在用
 if (objQryRegionFldsEN.ErrMsg !=  "")
 {
objRow[conQryRegionFlds.ErrMsg] = objQryRegionFldsEN.ErrMsg; //错误信息
 }
objRow[conQryRegionFlds.PrjId] = objQryRegionFldsEN.PrjId; //工程Id
objRow[conQryRegionFlds.UpdUser] = objQryRegionFldsEN.UpdUser; //修改者
 if (objQryRegionFldsEN.UpdDate !=  "")
 {
objRow[conQryRegionFlds.UpdDate] = objQryRegionFldsEN.UpdDate; //修改日期
 }
 if (objQryRegionFldsEN.Memo !=  "")
 {
objRow[conQryRegionFlds.Memo] = objQryRegionFldsEN.Memo; //说明
 }
objDS.Tables[clsQryRegionFldsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQryRegionFldsEN._CurrTabName);
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
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQryRegionFldsEN objQryRegionFldsEN)
{
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQryRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQryRegionFldsEN.RegionId  ==  "")
 {
 objQryRegionFldsEN.RegionId = null;
 }
 if (objQryRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.RegionId);
 var strRegionId = objQryRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objQryRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldId);
 var strFldId = objQryRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objQryRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.OutFldId);
 var strOutFldId = objQryRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objQryRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.LabelCaption);
 var strLabelCaption = objQryRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objQryRegionFldsEN.CtlTypeId  ==  "")
 {
 objQryRegionFldsEN.CtlTypeId = null;
 }
 if (objQryRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.CtlTypeId);
 var strCtlTypeId = objQryRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objQryRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarId);
 var strVarId = objQryRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objQryRegionFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsTabId);
 var strDsTabId = objQryRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objQryRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objQryRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objQryRegionFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldIdCond1);
 var strFldIdCond1 = objQryRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objQryRegionFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarIdCond1);
 var strVarIdCond1 = objQryRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objQryRegionFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldIdCond2);
 var strFldIdCond2 = objQryRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objQryRegionFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarIdCond2);
 var strVarIdCond2 = objQryRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objQryRegionFldsEN.QueryOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.QueryOptionId);
 var strQueryOptionId = objQryRegionFldsEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionId + "'");
 }
 
 if (objQryRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objQryRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objQryRegionFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objQryRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objQryRegionFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsSqlStr);
 var strDsSqlStr = objQryRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objQryRegionFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ItemsString);
 var strItemsString = objQryRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objQryRegionFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsCondStr);
 var strDsCondStr = objQryRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objQryRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ColSpan);
 arrValueListForInsert.Add(objQryRegionFldsEN.ColSpan.ToString());
 }
 
 if (objQryRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.Width);
 arrValueListForInsert.Add(objQryRegionFldsEN.Width.ToString());
 }
 
 if (objQryRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.SeqNum);
 arrValueListForInsert.Add(objQryRegionFldsEN.SeqNum.ToString());
 }
 
 if (objQryRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ChangeEvent);
 var strChangeEvent = objQryRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 if (objQryRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ClickEvent);
 var strClickEvent = objQryRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQryRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objQryRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQryRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ErrMsg);
 var strErrMsg = objQryRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objQryRegionFldsEN.PrjId  ==  "")
 {
 objQryRegionFldsEN.PrjId = null;
 }
 if (objQryRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.PrjId);
 var strPrjId = objQryRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objQryRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.UpdUser);
 var strUpdUser = objQryRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQryRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.UpdDate);
 var strUpdDate = objQryRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQryRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.Memo);
 var strMemo = objQryRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QryRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQryRegionFldsEN objQryRegionFldsEN)
{
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQryRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQryRegionFldsEN.RegionId  ==  "")
 {
 objQryRegionFldsEN.RegionId = null;
 }
 if (objQryRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.RegionId);
 var strRegionId = objQryRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objQryRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldId);
 var strFldId = objQryRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objQryRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.OutFldId);
 var strOutFldId = objQryRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objQryRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.LabelCaption);
 var strLabelCaption = objQryRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objQryRegionFldsEN.CtlTypeId  ==  "")
 {
 objQryRegionFldsEN.CtlTypeId = null;
 }
 if (objQryRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.CtlTypeId);
 var strCtlTypeId = objQryRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objQryRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarId);
 var strVarId = objQryRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objQryRegionFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsTabId);
 var strDsTabId = objQryRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objQryRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objQryRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objQryRegionFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldIdCond1);
 var strFldIdCond1 = objQryRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objQryRegionFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarIdCond1);
 var strVarIdCond1 = objQryRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objQryRegionFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldIdCond2);
 var strFldIdCond2 = objQryRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objQryRegionFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarIdCond2);
 var strVarIdCond2 = objQryRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objQryRegionFldsEN.QueryOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.QueryOptionId);
 var strQueryOptionId = objQryRegionFldsEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionId + "'");
 }
 
 if (objQryRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objQryRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objQryRegionFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objQryRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objQryRegionFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsSqlStr);
 var strDsSqlStr = objQryRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objQryRegionFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ItemsString);
 var strItemsString = objQryRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objQryRegionFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsCondStr);
 var strDsCondStr = objQryRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objQryRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ColSpan);
 arrValueListForInsert.Add(objQryRegionFldsEN.ColSpan.ToString());
 }
 
 if (objQryRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.Width);
 arrValueListForInsert.Add(objQryRegionFldsEN.Width.ToString());
 }
 
 if (objQryRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.SeqNum);
 arrValueListForInsert.Add(objQryRegionFldsEN.SeqNum.ToString());
 }
 
 if (objQryRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ChangeEvent);
 var strChangeEvent = objQryRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 if (objQryRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ClickEvent);
 var strClickEvent = objQryRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQryRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objQryRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQryRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ErrMsg);
 var strErrMsg = objQryRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objQryRegionFldsEN.PrjId  ==  "")
 {
 objQryRegionFldsEN.PrjId = null;
 }
 if (objQryRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.PrjId);
 var strPrjId = objQryRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objQryRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.UpdUser);
 var strUpdUser = objQryRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQryRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.UpdDate);
 var strUpdDate = objQryRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQryRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.Memo);
 var strMemo = objQryRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QryRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQryRegionFldsEN objQryRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQryRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQryRegionFldsEN.RegionId  ==  "")
 {
 objQryRegionFldsEN.RegionId = null;
 }
 if (objQryRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.RegionId);
 var strRegionId = objQryRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objQryRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldId);
 var strFldId = objQryRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objQryRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.OutFldId);
 var strOutFldId = objQryRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objQryRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.LabelCaption);
 var strLabelCaption = objQryRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objQryRegionFldsEN.CtlTypeId  ==  "")
 {
 objQryRegionFldsEN.CtlTypeId = null;
 }
 if (objQryRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.CtlTypeId);
 var strCtlTypeId = objQryRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objQryRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarId);
 var strVarId = objQryRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objQryRegionFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsTabId);
 var strDsTabId = objQryRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objQryRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objQryRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objQryRegionFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldIdCond1);
 var strFldIdCond1 = objQryRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objQryRegionFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarIdCond1);
 var strVarIdCond1 = objQryRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objQryRegionFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldIdCond2);
 var strFldIdCond2 = objQryRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objQryRegionFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarIdCond2);
 var strVarIdCond2 = objQryRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objQryRegionFldsEN.QueryOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.QueryOptionId);
 var strQueryOptionId = objQryRegionFldsEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionId + "'");
 }
 
 if (objQryRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objQryRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objQryRegionFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objQryRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objQryRegionFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsSqlStr);
 var strDsSqlStr = objQryRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objQryRegionFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ItemsString);
 var strItemsString = objQryRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objQryRegionFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsCondStr);
 var strDsCondStr = objQryRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objQryRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ColSpan);
 arrValueListForInsert.Add(objQryRegionFldsEN.ColSpan.ToString());
 }
 
 if (objQryRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.Width);
 arrValueListForInsert.Add(objQryRegionFldsEN.Width.ToString());
 }
 
 if (objQryRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.SeqNum);
 arrValueListForInsert.Add(objQryRegionFldsEN.SeqNum.ToString());
 }
 
 if (objQryRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ChangeEvent);
 var strChangeEvent = objQryRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 if (objQryRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ClickEvent);
 var strClickEvent = objQryRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQryRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objQryRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQryRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ErrMsg);
 var strErrMsg = objQryRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objQryRegionFldsEN.PrjId  ==  "")
 {
 objQryRegionFldsEN.PrjId = null;
 }
 if (objQryRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.PrjId);
 var strPrjId = objQryRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objQryRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.UpdUser);
 var strUpdUser = objQryRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQryRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.UpdDate);
 var strUpdDate = objQryRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQryRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.Memo);
 var strMemo = objQryRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QryRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQryRegionFldsEN objQryRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQryRegionFldsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQryRegionFldsEN.RegionId  ==  "")
 {
 objQryRegionFldsEN.RegionId = null;
 }
 if (objQryRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.RegionId);
 var strRegionId = objQryRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objQryRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldId);
 var strFldId = objQryRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objQryRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.OutFldId);
 var strOutFldId = objQryRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objQryRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.LabelCaption);
 var strLabelCaption = objQryRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objQryRegionFldsEN.CtlTypeId  ==  "")
 {
 objQryRegionFldsEN.CtlTypeId = null;
 }
 if (objQryRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.CtlTypeId);
 var strCtlTypeId = objQryRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objQryRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarId);
 var strVarId = objQryRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objQryRegionFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsTabId);
 var strDsTabId = objQryRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objQryRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objQryRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objQryRegionFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldIdCond1);
 var strFldIdCond1 = objQryRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objQryRegionFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarIdCond1);
 var strVarIdCond1 = objQryRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objQryRegionFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.FldIdCond2);
 var strFldIdCond2 = objQryRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objQryRegionFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.VarIdCond2);
 var strVarIdCond2 = objQryRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objQryRegionFldsEN.QueryOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.QueryOptionId);
 var strQueryOptionId = objQryRegionFldsEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionId + "'");
 }
 
 if (objQryRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objQryRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objQryRegionFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objQryRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objQryRegionFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsSqlStr);
 var strDsSqlStr = objQryRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objQryRegionFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ItemsString);
 var strItemsString = objQryRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objQryRegionFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.DsCondStr);
 var strDsCondStr = objQryRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objQryRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ColSpan);
 arrValueListForInsert.Add(objQryRegionFldsEN.ColSpan.ToString());
 }
 
 if (objQryRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.Width);
 arrValueListForInsert.Add(objQryRegionFldsEN.Width.ToString());
 }
 
 if (objQryRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.SeqNum);
 arrValueListForInsert.Add(objQryRegionFldsEN.SeqNum.ToString());
 }
 
 if (objQryRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ChangeEvent);
 var strChangeEvent = objQryRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 if (objQryRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ClickEvent);
 var strClickEvent = objQryRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQryRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objQryRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objQryRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.ErrMsg);
 var strErrMsg = objQryRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objQryRegionFldsEN.PrjId  ==  "")
 {
 objQryRegionFldsEN.PrjId = null;
 }
 if (objQryRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.PrjId);
 var strPrjId = objQryRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objQryRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.UpdUser);
 var strUpdUser = objQryRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQryRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.UpdDate);
 var strUpdDate = objQryRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQryRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQryRegionFlds.Memo);
 var strMemo = objQryRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QryRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQryRegionFldss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QryRegionFlds");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conQryRegionFlds.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQryRegionFldsEN._CurrTabName ].NewRow();
objRow[conQryRegionFlds.RegionId] = oRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objRow[conQryRegionFlds.FldId] = oRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objRow[conQryRegionFlds.OutFldId] = oRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objRow[conQryRegionFlds.LabelCaption] = oRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objRow[conQryRegionFlds.CtlTypeId] = oRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objRow[conQryRegionFlds.VarId] = oRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objRow[conQryRegionFlds.DsTabId] = oRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objRow[conQryRegionFlds.TabFeatureId4Ddl] = oRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objRow[conQryRegionFlds.FldIdCond1] = oRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objRow[conQryRegionFlds.VarIdCond1] = oRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objRow[conQryRegionFlds.FldIdCond2] = oRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objRow[conQryRegionFlds.VarIdCond2] = oRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objRow[conQryRegionFlds.QueryOptionId] = oRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objRow[conQryRegionFlds.DdlItemsOptionId] = oRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objRow[conQryRegionFlds.DsSqlStr] = oRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objRow[conQryRegionFlds.ItemsString] = oRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objRow[conQryRegionFlds.DsCondStr] = oRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objRow[conQryRegionFlds.ColSpan] = oRow[conQryRegionFlds.ColSpan].ToString().Trim(); //跨列数
objRow[conQryRegionFlds.Width] = oRow[conQryRegionFlds.Width].ToString().Trim(); //宽
objRow[conQryRegionFlds.SeqNum] = oRow[conQryRegionFlds.SeqNum].ToString().Trim(); //字段序号
objRow[conQryRegionFlds.ChangeEvent] = oRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objRow[conQryRegionFlds.ClickEvent] = oRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objRow[conQryRegionFlds.InUse] = oRow[conQryRegionFlds.InUse].ToString().Trim(); //是否在用
objRow[conQryRegionFlds.ErrMsg] = oRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objRow[conQryRegionFlds.PrjId] = oRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objRow[conQryRegionFlds.UpdUser] = oRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objRow[conQryRegionFlds.UpdDate] = oRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objRow[conQryRegionFlds.Memo] = oRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
 objDS.Tables[clsQryRegionFldsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQryRegionFldsEN._CurrTabName);
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
 /// <param name = "objQryRegionFldsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQryRegionFldsEN objQryRegionFldsEN)
{
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQryRegionFldsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from QryRegionFlds where mId = " + ""+ objQryRegionFldsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQryRegionFldsEN._CurrTabName);
if (objDS.Tables[clsQryRegionFldsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objQryRegionFldsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsQryRegionFldsEN._CurrTabName].Rows[0];
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.RegionId))
 {
objRow[conQryRegionFlds.RegionId] = objQryRegionFldsEN.RegionId; //区域Id
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldId))
 {
objRow[conQryRegionFlds.FldId] = objQryRegionFldsEN.FldId; //字段Id
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.OutFldId))
 {
objRow[conQryRegionFlds.OutFldId] = objQryRegionFldsEN.OutFldId; //OutFldId
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.LabelCaption))
 {
objRow[conQryRegionFlds.LabelCaption] = objQryRegionFldsEN.LabelCaption; //标签标题
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.CtlTypeId))
 {
objRow[conQryRegionFlds.CtlTypeId] = objQryRegionFldsEN.CtlTypeId; //控件类型号
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarId))
 {
objRow[conQryRegionFlds.VarId] = objQryRegionFldsEN.VarId; //变量Id
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsTabId))
 {
objRow[conQryRegionFlds.DsTabId] = objQryRegionFldsEN.DsTabId; //数据源表ID
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.TabFeatureId4Ddl))
 {
objRow[conQryRegionFlds.TabFeatureId4Ddl] = objQryRegionFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond1))
 {
objRow[conQryRegionFlds.FldIdCond1] = objQryRegionFldsEN.FldIdCond1; //字段Id_条件1
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond1))
 {
objRow[conQryRegionFlds.VarIdCond1] = objQryRegionFldsEN.VarIdCond1; //变量Id_条件1
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond2))
 {
objRow[conQryRegionFlds.FldIdCond2] = objQryRegionFldsEN.FldIdCond2; //字段Id_条件2
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond2))
 {
objRow[conQryRegionFlds.VarIdCond2] = objQryRegionFldsEN.VarIdCond2; //数据源字段_条件1
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.QueryOptionId))
 {
objRow[conQryRegionFlds.QueryOptionId] = objQryRegionFldsEN.QueryOptionId; //查询方式Id
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DdlItemsOptionId))
 {
objRow[conQryRegionFlds.DdlItemsOptionId] = objQryRegionFldsEN.DdlItemsOptionId; //下拉框列表选项ID
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsSqlStr))
 {
objRow[conQryRegionFlds.DsSqlStr] = objQryRegionFldsEN.DsSqlStr; //数据源SQL串
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ItemsString))
 {
objRow[conQryRegionFlds.ItemsString] = objQryRegionFldsEN.ItemsString; //列表项串
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsCondStr))
 {
objRow[conQryRegionFlds.DsCondStr] = objQryRegionFldsEN.DsCondStr; //数据源条件串
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ColSpan))
 {
objRow[conQryRegionFlds.ColSpan] = objQryRegionFldsEN.ColSpan; //跨列数
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Width))
 {
objRow[conQryRegionFlds.Width] = objQryRegionFldsEN.Width; //宽
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.SeqNum))
 {
objRow[conQryRegionFlds.SeqNum] = objQryRegionFldsEN.SeqNum; //字段序号
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ChangeEvent))
 {
objRow[conQryRegionFlds.ChangeEvent] = objQryRegionFldsEN.ChangeEvent; //Change事件
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ClickEvent))
 {
objRow[conQryRegionFlds.ClickEvent] = objQryRegionFldsEN.ClickEvent; //Click事件
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.InUse))
 {
objRow[conQryRegionFlds.InUse] = objQryRegionFldsEN.InUse; //是否在用
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ErrMsg))
 {
objRow[conQryRegionFlds.ErrMsg] = objQryRegionFldsEN.ErrMsg; //错误信息
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.PrjId))
 {
objRow[conQryRegionFlds.PrjId] = objQryRegionFldsEN.PrjId; //工程Id
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdUser))
 {
objRow[conQryRegionFlds.UpdUser] = objQryRegionFldsEN.UpdUser; //修改者
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdDate))
 {
objRow[conQryRegionFlds.UpdDate] = objQryRegionFldsEN.UpdDate; //修改日期
 }
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Memo))
 {
objRow[conQryRegionFlds.Memo] = objQryRegionFldsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsQryRegionFldsEN._CurrTabName);
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
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQryRegionFldsEN objQryRegionFldsEN)
{
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQryRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QryRegionFlds Set ");
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.RegionId))
 {
 if (objQryRegionFldsEN.RegionId  ==  "")
 {
 objQryRegionFldsEN.RegionId = null;
 }
 if (objQryRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objQryRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conQryRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldId))
 {
 if (objQryRegionFldsEN.FldId !=  null)
 {
 var strFldId = objQryRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conQryRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.FldId); //字段Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.OutFldId))
 {
 if (objQryRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objQryRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldId, conQryRegionFlds.OutFldId); //OutFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.OutFldId); //OutFldId
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.LabelCaption))
 {
 if (objQryRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objQryRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelCaption, conQryRegionFlds.LabelCaption); //标签标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.LabelCaption); //标签标题
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.CtlTypeId))
 {
 if (objQryRegionFldsEN.CtlTypeId  ==  "")
 {
 objQryRegionFldsEN.CtlTypeId = null;
 }
 if (objQryRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objQryRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conQryRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarId))
 {
 if (objQryRegionFldsEN.VarId !=  null)
 {
 var strVarId = objQryRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarId, conQryRegionFlds.VarId); //变量Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.VarId); //变量Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsTabId))
 {
 if (objQryRegionFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objQryRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsTabId, conQryRegionFlds.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.DsTabId); //数据源表ID
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.TabFeatureId4Ddl))
 {
 if (objQryRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objQryRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureId4Ddl, conQryRegionFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond1))
 {
 if (objQryRegionFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objQryRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond1, conQryRegionFlds.FldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.FldIdCond1); //字段Id_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond1))
 {
 if (objQryRegionFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objQryRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond1, conQryRegionFlds.VarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.VarIdCond1); //变量Id_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond2))
 {
 if (objQryRegionFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objQryRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond2, conQryRegionFlds.FldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.FldIdCond2); //字段Id_条件2
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond2))
 {
 if (objQryRegionFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objQryRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond2, conQryRegionFlds.VarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.VarIdCond2); //数据源字段_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.QueryOptionId))
 {
 if (objQryRegionFldsEN.QueryOptionId !=  null)
 {
 var strQueryOptionId = objQryRegionFldsEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQueryOptionId, conQryRegionFlds.QueryOptionId); //查询方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.QueryOptionId); //查询方式Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DdlItemsOptionId))
 {
 if (objQryRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objQryRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objQryRegionFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objQryRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDdlItemsOptionId, conQryRegionFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsSqlStr))
 {
 if (objQryRegionFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objQryRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsSqlStr, conQryRegionFlds.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.DsSqlStr); //数据源SQL串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ItemsString))
 {
 if (objQryRegionFldsEN.ItemsString !=  null)
 {
 var strItemsString = objQryRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strItemsString, conQryRegionFlds.ItemsString); //列表项串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ItemsString); //列表项串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsCondStr))
 {
 if (objQryRegionFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objQryRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsCondStr, conQryRegionFlds.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.DsCondStr); //数据源条件串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ColSpan))
 {
 if (objQryRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.ColSpan, conQryRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Width))
 {
 if (objQryRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.Width, conQryRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.Width); //宽
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.SeqNum))
 {
 if (objQryRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.SeqNum, conQryRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ChangeEvent))
 {
 if (objQryRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objQryRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChangeEvent, conQryRegionFlds.ChangeEvent); //Change事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ChangeEvent); //Change事件
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ClickEvent))
 {
 if (objQryRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objQryRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClickEvent, conQryRegionFlds.ClickEvent); //Click事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ClickEvent); //Click事件
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQryRegionFldsEN.InUse == true?"1":"0", conQryRegionFlds.InUse); //是否在用
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ErrMsg))
 {
 if (objQryRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objQryRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conQryRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.PrjId))
 {
 if (objQryRegionFldsEN.PrjId  ==  "")
 {
 objQryRegionFldsEN.PrjId = null;
 }
 if (objQryRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objQryRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conQryRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdUser))
 {
 if (objQryRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objQryRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQryRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdDate))
 {
 if (objQryRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objQryRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQryRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Memo))
 {
 if (objQryRegionFldsEN.Memo !=  null)
 {
 var strMemo = objQryRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQryRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQryRegionFldsEN.mId); 
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
 /// <param name = "objQryRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQryRegionFldsEN objQryRegionFldsEN, string strCondition)
{
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQryRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QryRegionFlds Set ");
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.RegionId))
 {
 if (objQryRegionFldsEN.RegionId  ==  "")
 {
 objQryRegionFldsEN.RegionId = null;
 }
 if (objQryRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objQryRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldId))
 {
 if (objQryRegionFldsEN.FldId !=  null)
 {
 var strFldId = objQryRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.OutFldId))
 {
 if (objQryRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objQryRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldId = '{0}',", strOutFldId); //OutFldId
 }
 else
 {
 sbSQL.Append(" OutFldId = null,"); //OutFldId
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.LabelCaption))
 {
 if (objQryRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objQryRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelCaption = '{0}',", strLabelCaption); //标签标题
 }
 else
 {
 sbSQL.Append(" LabelCaption = null,"); //标签标题
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.CtlTypeId))
 {
 if (objQryRegionFldsEN.CtlTypeId  ==  "")
 {
 objQryRegionFldsEN.CtlTypeId = null;
 }
 if (objQryRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objQryRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarId))
 {
 if (objQryRegionFldsEN.VarId !=  null)
 {
 var strVarId = objQryRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarId = '{0}',", strVarId); //变量Id
 }
 else
 {
 sbSQL.Append(" VarId = null,"); //变量Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsTabId))
 {
 if (objQryRegionFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objQryRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsTabId = '{0}',", strDsTabId); //数据源表ID
 }
 else
 {
 sbSQL.Append(" DsTabId = null,"); //数据源表ID
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.TabFeatureId4Ddl))
 {
 if (objQryRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objQryRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureId4Ddl = '{0}',", strTabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.Append(" TabFeatureId4Ddl = null,"); //下拉框表功能Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond1))
 {
 if (objQryRegionFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objQryRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond1 = '{0}',", strFldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.Append(" FldIdCond1 = null,"); //字段Id_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond1))
 {
 if (objQryRegionFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objQryRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond1 = '{0}',", strVarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond1 = null,"); //变量Id_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond2))
 {
 if (objQryRegionFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objQryRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond2 = '{0}',", strFldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.Append(" FldIdCond2 = null,"); //字段Id_条件2
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond2))
 {
 if (objQryRegionFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objQryRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond2 = '{0}',", strVarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond2 = null,"); //数据源字段_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.QueryOptionId))
 {
 if (objQryRegionFldsEN.QueryOptionId !=  null)
 {
 var strQueryOptionId = objQryRegionFldsEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QueryOptionId = '{0}',", strQueryOptionId); //查询方式Id
 }
 else
 {
 sbSQL.Append(" QueryOptionId = null,"); //查询方式Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DdlItemsOptionId))
 {
 if (objQryRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objQryRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objQryRegionFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objQryRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DdlItemsOptionId = '{0}',", strDdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.Append(" DdlItemsOptionId = null,"); //下拉框列表选项ID
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsSqlStr))
 {
 if (objQryRegionFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objQryRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsSqlStr = '{0}',", strDsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.Append(" DsSqlStr = null,"); //数据源SQL串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ItemsString))
 {
 if (objQryRegionFldsEN.ItemsString !=  null)
 {
 var strItemsString = objQryRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ItemsString = '{0}',", strItemsString); //列表项串
 }
 else
 {
 sbSQL.Append(" ItemsString = null,"); //列表项串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsCondStr))
 {
 if (objQryRegionFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objQryRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsCondStr = '{0}',", strDsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.Append(" DsCondStr = null,"); //数据源条件串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ColSpan))
 {
 if (objQryRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.ColSpan, conQryRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Width))
 {
 if (objQryRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.Width, conQryRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.Width); //宽
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.SeqNum))
 {
 if (objQryRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.SeqNum, conQryRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ChangeEvent))
 {
 if (objQryRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objQryRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChangeEvent = '{0}',", strChangeEvent); //Change事件
 }
 else
 {
 sbSQL.Append(" ChangeEvent = null,"); //Change事件
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ClickEvent))
 {
 if (objQryRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objQryRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClickEvent = '{0}',", strClickEvent); //Click事件
 }
 else
 {
 sbSQL.Append(" ClickEvent = null,"); //Click事件
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQryRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ErrMsg))
 {
 if (objQryRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objQryRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.PrjId))
 {
 if (objQryRegionFldsEN.PrjId  ==  "")
 {
 objQryRegionFldsEN.PrjId = null;
 }
 if (objQryRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objQryRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdUser))
 {
 if (objQryRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objQryRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdDate))
 {
 if (objQryRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objQryRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Memo))
 {
 if (objQryRegionFldsEN.Memo !=  null)
 {
 var strMemo = objQryRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQryRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQryRegionFldsEN objQryRegionFldsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQryRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QryRegionFlds Set ");
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.RegionId))
 {
 if (objQryRegionFldsEN.RegionId  ==  "")
 {
 objQryRegionFldsEN.RegionId = null;
 }
 if (objQryRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objQryRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldId))
 {
 if (objQryRegionFldsEN.FldId !=  null)
 {
 var strFldId = objQryRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.OutFldId))
 {
 if (objQryRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objQryRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldId = '{0}',", strOutFldId); //OutFldId
 }
 else
 {
 sbSQL.Append(" OutFldId = null,"); //OutFldId
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.LabelCaption))
 {
 if (objQryRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objQryRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelCaption = '{0}',", strLabelCaption); //标签标题
 }
 else
 {
 sbSQL.Append(" LabelCaption = null,"); //标签标题
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.CtlTypeId))
 {
 if (objQryRegionFldsEN.CtlTypeId  ==  "")
 {
 objQryRegionFldsEN.CtlTypeId = null;
 }
 if (objQryRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objQryRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarId))
 {
 if (objQryRegionFldsEN.VarId !=  null)
 {
 var strVarId = objQryRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarId = '{0}',", strVarId); //变量Id
 }
 else
 {
 sbSQL.Append(" VarId = null,"); //变量Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsTabId))
 {
 if (objQryRegionFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objQryRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsTabId = '{0}',", strDsTabId); //数据源表ID
 }
 else
 {
 sbSQL.Append(" DsTabId = null,"); //数据源表ID
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.TabFeatureId4Ddl))
 {
 if (objQryRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objQryRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureId4Ddl = '{0}',", strTabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.Append(" TabFeatureId4Ddl = null,"); //下拉框表功能Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond1))
 {
 if (objQryRegionFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objQryRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond1 = '{0}',", strFldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.Append(" FldIdCond1 = null,"); //字段Id_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond1))
 {
 if (objQryRegionFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objQryRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond1 = '{0}',", strVarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond1 = null,"); //变量Id_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond2))
 {
 if (objQryRegionFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objQryRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond2 = '{0}',", strFldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.Append(" FldIdCond2 = null,"); //字段Id_条件2
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond2))
 {
 if (objQryRegionFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objQryRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond2 = '{0}',", strVarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond2 = null,"); //数据源字段_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.QueryOptionId))
 {
 if (objQryRegionFldsEN.QueryOptionId !=  null)
 {
 var strQueryOptionId = objQryRegionFldsEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QueryOptionId = '{0}',", strQueryOptionId); //查询方式Id
 }
 else
 {
 sbSQL.Append(" QueryOptionId = null,"); //查询方式Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DdlItemsOptionId))
 {
 if (objQryRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objQryRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objQryRegionFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objQryRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DdlItemsOptionId = '{0}',", strDdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.Append(" DdlItemsOptionId = null,"); //下拉框列表选项ID
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsSqlStr))
 {
 if (objQryRegionFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objQryRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsSqlStr = '{0}',", strDsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.Append(" DsSqlStr = null,"); //数据源SQL串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ItemsString))
 {
 if (objQryRegionFldsEN.ItemsString !=  null)
 {
 var strItemsString = objQryRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ItemsString = '{0}',", strItemsString); //列表项串
 }
 else
 {
 sbSQL.Append(" ItemsString = null,"); //列表项串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsCondStr))
 {
 if (objQryRegionFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objQryRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsCondStr = '{0}',", strDsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.Append(" DsCondStr = null,"); //数据源条件串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ColSpan))
 {
 if (objQryRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.ColSpan, conQryRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Width))
 {
 if (objQryRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.Width, conQryRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.Width); //宽
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.SeqNum))
 {
 if (objQryRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.SeqNum, conQryRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ChangeEvent))
 {
 if (objQryRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objQryRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChangeEvent = '{0}',", strChangeEvent); //Change事件
 }
 else
 {
 sbSQL.Append(" ChangeEvent = null,"); //Change事件
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ClickEvent))
 {
 if (objQryRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objQryRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClickEvent = '{0}',", strClickEvent); //Click事件
 }
 else
 {
 sbSQL.Append(" ClickEvent = null,"); //Click事件
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objQryRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ErrMsg))
 {
 if (objQryRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objQryRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.PrjId))
 {
 if (objQryRegionFldsEN.PrjId  ==  "")
 {
 objQryRegionFldsEN.PrjId = null;
 }
 if (objQryRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objQryRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdUser))
 {
 if (objQryRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objQryRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdDate))
 {
 if (objQryRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objQryRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Memo))
 {
 if (objQryRegionFldsEN.Memo !=  null)
 {
 var strMemo = objQryRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQryRegionFldsEN objQryRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQryRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQryRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QryRegionFlds Set ");
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.RegionId))
 {
 if (objQryRegionFldsEN.RegionId  ==  "")
 {
 objQryRegionFldsEN.RegionId = null;
 }
 if (objQryRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objQryRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conQryRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldId))
 {
 if (objQryRegionFldsEN.FldId !=  null)
 {
 var strFldId = objQryRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conQryRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.FldId); //字段Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.OutFldId))
 {
 if (objQryRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objQryRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldId, conQryRegionFlds.OutFldId); //OutFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.OutFldId); //OutFldId
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.LabelCaption))
 {
 if (objQryRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objQryRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelCaption, conQryRegionFlds.LabelCaption); //标签标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.LabelCaption); //标签标题
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.CtlTypeId))
 {
 if (objQryRegionFldsEN.CtlTypeId  ==  "")
 {
 objQryRegionFldsEN.CtlTypeId = null;
 }
 if (objQryRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objQryRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conQryRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarId))
 {
 if (objQryRegionFldsEN.VarId !=  null)
 {
 var strVarId = objQryRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarId, conQryRegionFlds.VarId); //变量Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.VarId); //变量Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsTabId))
 {
 if (objQryRegionFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objQryRegionFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsTabId, conQryRegionFlds.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.DsTabId); //数据源表ID
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.TabFeatureId4Ddl))
 {
 if (objQryRegionFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objQryRegionFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureId4Ddl, conQryRegionFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond1))
 {
 if (objQryRegionFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objQryRegionFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond1, conQryRegionFlds.FldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.FldIdCond1); //字段Id_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond1))
 {
 if (objQryRegionFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objQryRegionFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond1, conQryRegionFlds.VarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.VarIdCond1); //变量Id_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.FldIdCond2))
 {
 if (objQryRegionFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objQryRegionFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond2, conQryRegionFlds.FldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.FldIdCond2); //字段Id_条件2
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.VarIdCond2))
 {
 if (objQryRegionFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objQryRegionFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond2, conQryRegionFlds.VarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.VarIdCond2); //数据源字段_条件1
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.QueryOptionId))
 {
 if (objQryRegionFldsEN.QueryOptionId !=  null)
 {
 var strQueryOptionId = objQryRegionFldsEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQueryOptionId, conQryRegionFlds.QueryOptionId); //查询方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.QueryOptionId); //查询方式Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DdlItemsOptionId))
 {
 if (objQryRegionFldsEN.DdlItemsOptionId  ==  "")
 {
 objQryRegionFldsEN.DdlItemsOptionId = null;
 }
 if (objQryRegionFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objQryRegionFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDdlItemsOptionId, conQryRegionFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsSqlStr))
 {
 if (objQryRegionFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objQryRegionFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsSqlStr, conQryRegionFlds.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.DsSqlStr); //数据源SQL串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ItemsString))
 {
 if (objQryRegionFldsEN.ItemsString !=  null)
 {
 var strItemsString = objQryRegionFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strItemsString, conQryRegionFlds.ItemsString); //列表项串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ItemsString); //列表项串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.DsCondStr))
 {
 if (objQryRegionFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objQryRegionFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsCondStr, conQryRegionFlds.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.DsCondStr); //数据源条件串
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ColSpan))
 {
 if (objQryRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.ColSpan, conQryRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Width))
 {
 if (objQryRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.Width, conQryRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.Width); //宽
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.SeqNum))
 {
 if (objQryRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQryRegionFldsEN.SeqNum, conQryRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ChangeEvent))
 {
 if (objQryRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objQryRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChangeEvent, conQryRegionFlds.ChangeEvent); //Change事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ChangeEvent); //Change事件
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ClickEvent))
 {
 if (objQryRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objQryRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClickEvent, conQryRegionFlds.ClickEvent); //Click事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ClickEvent); //Click事件
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQryRegionFldsEN.InUse == true?"1":"0", conQryRegionFlds.InUse); //是否在用
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.ErrMsg))
 {
 if (objQryRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objQryRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conQryRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.PrjId))
 {
 if (objQryRegionFldsEN.PrjId  ==  "")
 {
 objQryRegionFldsEN.PrjId = null;
 }
 if (objQryRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objQryRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conQryRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdUser))
 {
 if (objQryRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objQryRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQryRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.UpdDate))
 {
 if (objQryRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objQryRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQryRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objQryRegionFldsEN.IsUpdated(conQryRegionFlds.Memo))
 {
 if (objQryRegionFldsEN.Memo !=  null)
 {
 var strMemo = objQryRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQryRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQryRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objQryRegionFldsEN.mId); 
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("QryRegionFlds_Delete", values);
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
//删除QryRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QryRegionFlds where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQryRegionFlds(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
//删除QryRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QryRegionFlds where mId in (" + strKeyList + ")";
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
//删除QryRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QryRegionFlds where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQryRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: DelQryRegionFlds)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QryRegionFlds where " + strCondition ;
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
public bool DelQryRegionFldsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQryRegionFldsDA: DelQryRegionFldsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QryRegionFlds where " + strCondition ;
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
 /// <param name = "objQryRegionFldsENS">源对象</param>
 /// <param name = "objQryRegionFldsENT">目标对象</param>
public void CopyTo(clsQryRegionFldsEN objQryRegionFldsENS, clsQryRegionFldsEN objQryRegionFldsENT)
{
objQryRegionFldsENT.mId = objQryRegionFldsENS.mId; //mId
objQryRegionFldsENT.RegionId = objQryRegionFldsENS.RegionId; //区域Id
objQryRegionFldsENT.FldId = objQryRegionFldsENS.FldId; //字段Id
objQryRegionFldsENT.OutFldId = objQryRegionFldsENS.OutFldId; //OutFldId
objQryRegionFldsENT.LabelCaption = objQryRegionFldsENS.LabelCaption; //标签标题
objQryRegionFldsENT.CtlTypeId = objQryRegionFldsENS.CtlTypeId; //控件类型号
objQryRegionFldsENT.VarId = objQryRegionFldsENS.VarId; //变量Id
objQryRegionFldsENT.DsTabId = objQryRegionFldsENS.DsTabId; //数据源表ID
objQryRegionFldsENT.TabFeatureId4Ddl = objQryRegionFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objQryRegionFldsENT.FldIdCond1 = objQryRegionFldsENS.FldIdCond1; //字段Id_条件1
objQryRegionFldsENT.VarIdCond1 = objQryRegionFldsENS.VarIdCond1; //变量Id_条件1
objQryRegionFldsENT.FldIdCond2 = objQryRegionFldsENS.FldIdCond2; //字段Id_条件2
objQryRegionFldsENT.VarIdCond2 = objQryRegionFldsENS.VarIdCond2; //数据源字段_条件1
objQryRegionFldsENT.QueryOptionId = objQryRegionFldsENS.QueryOptionId; //查询方式Id
objQryRegionFldsENT.DdlItemsOptionId = objQryRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objQryRegionFldsENT.DsSqlStr = objQryRegionFldsENS.DsSqlStr; //数据源SQL串
objQryRegionFldsENT.ItemsString = objQryRegionFldsENS.ItemsString; //列表项串
objQryRegionFldsENT.DsCondStr = objQryRegionFldsENS.DsCondStr; //数据源条件串
objQryRegionFldsENT.ColSpan = objQryRegionFldsENS.ColSpan; //跨列数
objQryRegionFldsENT.Width = objQryRegionFldsENS.Width; //宽
objQryRegionFldsENT.SeqNum = objQryRegionFldsENS.SeqNum; //字段序号
objQryRegionFldsENT.ChangeEvent = objQryRegionFldsENS.ChangeEvent; //Change事件
objQryRegionFldsENT.ClickEvent = objQryRegionFldsENS.ClickEvent; //Click事件
objQryRegionFldsENT.InUse = objQryRegionFldsENS.InUse; //是否在用
objQryRegionFldsENT.ErrMsg = objQryRegionFldsENS.ErrMsg; //错误信息
objQryRegionFldsENT.PrjId = objQryRegionFldsENS.PrjId; //工程Id
objQryRegionFldsENT.UpdUser = objQryRegionFldsENS.UpdUser; //修改者
objQryRegionFldsENT.UpdDate = objQryRegionFldsENS.UpdDate; //修改日期
objQryRegionFldsENT.Memo = objQryRegionFldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQryRegionFldsEN objQryRegionFldsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQryRegionFldsEN.RegionId, conQryRegionFlds.RegionId);
clsCheckSql.CheckFieldNotNull(objQryRegionFldsEN.PrjId, conQryRegionFlds.PrjId);
clsCheckSql.CheckFieldNotNull(objQryRegionFldsEN.UpdUser, conQryRegionFlds.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.RegionId, 10, conQryRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.FldId, 8, conQryRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.OutFldId, 8, conQryRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.LabelCaption, 150, conQryRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.CtlTypeId, 2, conQryRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.VarId, 8, conQryRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DsTabId, 8, conQryRegionFlds.DsTabId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.TabFeatureId4Ddl, 8, conQryRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.FldIdCond1, 8, conQryRegionFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.VarIdCond1, 8, conQryRegionFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.FldIdCond2, 8, conQryRegionFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.VarIdCond2, 8, conQryRegionFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.QueryOptionId, 2, conQryRegionFlds.QueryOptionId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DsSqlStr, 200, conQryRegionFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ItemsString, 200, conQryRegionFlds.ItemsString);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DsCondStr, 50, conQryRegionFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ChangeEvent, 50, conQryRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ClickEvent, 50, conQryRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ErrMsg, 2000, conQryRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.PrjId, 4, conQryRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.UpdUser, 20, conQryRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.UpdDate, 20, conQryRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.Memo, 1000, conQryRegionFlds.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.RegionId, 10, conQryRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.CtlTypeId, 2, conQryRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.DdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.PrjId, 4, conQryRegionFlds.PrjId);
 objQryRegionFldsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQryRegionFldsEN objQryRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.RegionId, 10, conQryRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.FldId, 8, conQryRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.OutFldId, 8, conQryRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.LabelCaption, 150, conQryRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.CtlTypeId, 2, conQryRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.VarId, 8, conQryRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DsTabId, 8, conQryRegionFlds.DsTabId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.TabFeatureId4Ddl, 8, conQryRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.FldIdCond1, 8, conQryRegionFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.VarIdCond1, 8, conQryRegionFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.FldIdCond2, 8, conQryRegionFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.VarIdCond2, 8, conQryRegionFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.QueryOptionId, 2, conQryRegionFlds.QueryOptionId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DsSqlStr, 200, conQryRegionFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ItemsString, 200, conQryRegionFlds.ItemsString);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DsCondStr, 50, conQryRegionFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ChangeEvent, 50, conQryRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ClickEvent, 50, conQryRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ErrMsg, 2000, conQryRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.PrjId, 4, conQryRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.UpdUser, 20, conQryRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.UpdDate, 20, conQryRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.Memo, 1000, conQryRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.RegionId, 10, conQryRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.CtlTypeId, 2, conQryRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.DdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.PrjId, 4, conQryRegionFlds.PrjId);
 objQryRegionFldsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQryRegionFldsEN objQryRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.RegionId, 10, conQryRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.FldId, 8, conQryRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.OutFldId, 8, conQryRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.LabelCaption, 150, conQryRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.CtlTypeId, 2, conQryRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.VarId, 8, conQryRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DsTabId, 8, conQryRegionFlds.DsTabId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.TabFeatureId4Ddl, 8, conQryRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.FldIdCond1, 8, conQryRegionFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.VarIdCond1, 8, conQryRegionFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.FldIdCond2, 8, conQryRegionFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.VarIdCond2, 8, conQryRegionFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.QueryOptionId, 2, conQryRegionFlds.QueryOptionId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DsSqlStr, 200, conQryRegionFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ItemsString, 200, conQryRegionFlds.ItemsString);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.DsCondStr, 50, conQryRegionFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ChangeEvent, 50, conQryRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ClickEvent, 50, conQryRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.ErrMsg, 2000, conQryRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.PrjId, 4, conQryRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.UpdUser, 20, conQryRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.UpdDate, 20, conQryRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objQryRegionFldsEN.Memo, 1000, conQryRegionFlds.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.RegionId, conQryRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.FldId, conQryRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.OutFldId, conQryRegionFlds.OutFldId);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.LabelCaption, conQryRegionFlds.LabelCaption);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.CtlTypeId, conQryRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.VarId, conQryRegionFlds.VarId);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.DsTabId, conQryRegionFlds.DsTabId);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.TabFeatureId4Ddl, conQryRegionFlds.TabFeatureId4Ddl);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.FldIdCond1, conQryRegionFlds.FldIdCond1);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.VarIdCond1, conQryRegionFlds.VarIdCond1);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.FldIdCond2, conQryRegionFlds.FldIdCond2);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.VarIdCond2, conQryRegionFlds.VarIdCond2);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.QueryOptionId, conQryRegionFlds.QueryOptionId);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.DdlItemsOptionId, conQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.DsSqlStr, conQryRegionFlds.DsSqlStr);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.ItemsString, conQryRegionFlds.ItemsString);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.DsCondStr, conQryRegionFlds.DsCondStr);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.ChangeEvent, conQryRegionFlds.ChangeEvent);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.ClickEvent, conQryRegionFlds.ClickEvent);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.ErrMsg, conQryRegionFlds.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.PrjId, conQryRegionFlds.PrjId);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.UpdUser, conQryRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.UpdDate, conQryRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQryRegionFldsEN.Memo, conQryRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.RegionId, 10, conQryRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.CtlTypeId, 2, conQryRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.DdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldForeignKey(objQryRegionFldsEN.PrjId, 4, conQryRegionFlds.PrjId);
 objQryRegionFldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QryRegionFlds(查询区域字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQryRegionFldsEN objQryRegionFldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objQryRegionFldsEN.RegionId);
 if (objQryRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null");
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objQryRegionFldsEN.FldId);
}
 if (objQryRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null");
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objQryRegionFldsEN.OutFldId);
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQryRegionFldsEN._CurrTabName);
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQryRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}