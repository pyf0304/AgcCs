
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureRegionFldsDA
 表名:FeatureRegionFlds(00050452)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:03
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
 /// 功能区域字段(FeatureRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFeatureRegionFldsDA : clsCommBase4DA
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
 return clsFeatureRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFeatureRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFeatureRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFeatureRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFeatureRegionFldsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strViewFeatureId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strViewFeatureId)
{
strViewFeatureId = strViewFeatureId.Replace("'", "''");
if (strViewFeatureId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:FeatureRegionFlds中,检查关键字,长度不正确!(clsFeatureRegionFldsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FeatureRegionFlds中,关键字不能为空 或 null!(clsFeatureRegionFldsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFeatureRegionFldsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FeatureRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetDataTable_FeatureRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FeatureRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FeatureRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FeatureRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FeatureRegionFlds.* " + 
$"from FeatureRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FeatureRegionFlds.ViewFeatureId not in " + 
$"(Select top {intTop_In} FeatureRegionFlds.ViewFeatureId from FeatureRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FeatureRegionFlds where {1} and ViewFeatureId not in (Select top {2} ViewFeatureId from FeatureRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FeatureRegionFlds where {1} and ViewFeatureId not in (Select top {3} ViewFeatureId from FeatureRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FeatureRegionFlds.* " + 
$"from FeatureRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FeatureRegionFlds.ViewFeatureId not in " + 
$"(Select top {intTop_In} FeatureRegionFlds.ViewFeatureId from FeatureRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FeatureRegionFlds where {1} and ViewFeatureId not in (Select top {2} ViewFeatureId from FeatureRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FeatureRegionFlds where {1} and ViewFeatureId not in (Select top {3} ViewFeatureId from FeatureRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFeatureRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = TransNullToBool(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFeatureRegionFldsDA: GetObjLst)", objException.Message));
}
objFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFeatureRegionFldsEN);
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
public List<clsFeatureRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = TransNullToBool(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFeatureRegionFldsDA: GetObjLst)", objException.Message));
}
objFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFeatureRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFeatureRegionFlds(ref clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where ViewFeatureId = " + "'"+ objFeatureRegionFldsEN.ViewFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFeatureRegionFldsEN.ViewFeatureId = objDT.Rows[0][conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objFeatureRegionFldsEN.RegionId = objDT.Rows[0][conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objFeatureRegionFldsEN.FeatureId = objDT.Rows[0][conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objFeatureRegionFldsEN.TabFeatureId = objDT.Rows[0][conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objFeatureRegionFldsEN.CheckTabFeature = objDT.Rows[0][conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能(字段类型:varchar,字段长度:50,是否可空:True)
 objFeatureRegionFldsEN.FeatureDescription = objDT.Rows[0][conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objFeatureRegionFldsEN.ButtonName = objDT.Rows[0][conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objFeatureRegionFldsEN.ButtonName4Mvc = objDT.Rows[0][conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc(字段类型:varchar,字段长度:30,是否可空:False)
 objFeatureRegionFldsEN.CommandName = objDT.Rows[0][conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名(字段类型:varchar,字段长度:30,是否可空:True)
 objFeatureRegionFldsEN.ValueGivingModeId = objDT.Rows[0][conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objFeatureRegionFldsEN.FuncName = objDT.Rows[0][conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objFeatureRegionFldsEN.DefaultValue = objDT.Rows[0][conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objFeatureRegionFldsEN.KeyIdGetModeId = objDT.Rows[0][conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id(字段类型:char,字段长度:4,是否可空:True)
 objFeatureRegionFldsEN.Text = objDT.Rows[0][conFeatureRegionFlds.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objFeatureRegionFldsEN.GroupName = objDT.Rows[0][conFeatureRegionFlds.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objFeatureRegionFldsEN.ReleTabId = objDT.Rows[0][conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:True)
 objFeatureRegionFldsEN.ReleFldId = objDT.Rows[0][conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objFeatureRegionFldsEN.EventFuncName = objDT.Rows[0][conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objFeatureRegionFldsEN.FieldTypeId = objDT.Rows[0][conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objFeatureRegionFldsEN.ViewImplId = objDT.Rows[0][conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objFeatureRegionFldsEN.CtlTypeId = objDT.Rows[0][conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objFeatureRegionFldsEN.Height = TransNullToInt(objDT.Rows[0][conFeatureRegionFlds.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objFeatureRegionFldsEN.Width = TransNullToInt(objDT.Rows[0][conFeatureRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objFeatureRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objFeatureRegionFldsEN.CssClass = objDT.Rows[0][conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objFeatureRegionFldsEN.ImageUrl = objDT.Rows[0][conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源(字段类型:varchar,字段长度:100,是否可空:True)
 objFeatureRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objFeatureRegionFldsEN.ErrMsg = objDT.Rows[0][conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objFeatureRegionFldsEN.PrjId = objDT.Rows[0][conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFeatureRegionFldsEN.UpdUser = objDT.Rows[0][conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFeatureRegionFldsEN.UpdDate = objDT.Rows[0][conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFeatureRegionFldsEN.Memo = objDT.Rows[0][conFeatureRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFeatureRegionFldsDA: GetFeatureRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsFeatureRegionFldsEN GetObjByViewFeatureId(string strViewFeatureId)
{
CheckPrimaryKey(strViewFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where ViewFeatureId = " + "'"+ strViewFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
 objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能(字段类型:varchar,字段长度:50,是否可空:True)
 objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc(字段类型:varchar,字段长度:30,是否可空:False)
 objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名(字段类型:varchar,字段长度:30,是否可空:True)
 objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id(字段类型:char,字段长度:4,是否可空:True)
 objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:True)
 objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源(字段类型:varchar,字段长度:100,是否可空:True)
 objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFeatureRegionFldsDA: GetObjByViewFeatureId)", objException.Message));
}
return objFeatureRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFeatureRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN()
{
ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(), //界面功能Id
RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(), //区域Id
FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(), //功能Id
TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(), //表功能Id
CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(), //检查表功能
FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(), //功能说明
ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(), //按钮名称
ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(), //按钮名称4Mvc
CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(), //命令名
ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(), //给值方式Id
FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(), //函数名
DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(), //缺省值
KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(), //GC关键字获取方式Id
Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(), //文本
GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(), //组名
ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(), //相关表Id
ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(), //相关字段Id
EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(), //事件函数名
FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(), //字段类型Id
ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(), //界面实现Id
CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Height].ToString().Trim()), //高度
Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Width].ToString().Trim()), //宽
SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()), //字段序号
CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(), //样式表
ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(), //图片资源
InUse = TransNullToBool(objRow[conFeatureRegionFlds.InUse].ToString().Trim()), //是否在用
ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim() //说明
};
objFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFeatureRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFeatureRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFeatureRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = TransNullToBool(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFeatureRegionFldsDA: GetObjByDataRowFeatureRegionFlds)", objException.Message));
}
objFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFeatureRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFeatureRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = TransNullToBool(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFeatureRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFeatureRegionFldsEN;
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
objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFeatureRegionFldsEN._CurrTabName, conFeatureRegionFlds.ViewFeatureId, 8, "");
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
objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFeatureRegionFldsEN._CurrTabName, conFeatureRegionFlds.ViewFeatureId, 8, strPrefix);
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
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewFeatureId from FeatureRegionFlds where " + strCondition;
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
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewFeatureId from FeatureRegionFlds where " + strCondition;
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
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strViewFeatureId)
{
CheckPrimaryKey(strViewFeatureId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FeatureRegionFlds", "ViewFeatureId = " + "'"+ strViewFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FeatureRegionFlds", strCondition))
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
objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FeatureRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
 {
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureRegionFldsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FeatureRegionFlds");
objRow = objDS.Tables["FeatureRegionFlds"].NewRow();
objRow[conFeatureRegionFlds.ViewFeatureId] = objFeatureRegionFldsEN.ViewFeatureId; //界面功能Id
objRow[conFeatureRegionFlds.RegionId] = objFeatureRegionFldsEN.RegionId; //区域Id
objRow[conFeatureRegionFlds.FeatureId] = objFeatureRegionFldsEN.FeatureId; //功能Id
 if (objFeatureRegionFldsEN.TabFeatureId !=  "")
 {
objRow[conFeatureRegionFlds.TabFeatureId] = objFeatureRegionFldsEN.TabFeatureId; //表功能Id
 }
 if (objFeatureRegionFldsEN.CheckTabFeature !=  "")
 {
objRow[conFeatureRegionFlds.CheckTabFeature] = objFeatureRegionFldsEN.CheckTabFeature; //检查表功能
 }
 if (objFeatureRegionFldsEN.FeatureDescription !=  "")
 {
objRow[conFeatureRegionFlds.FeatureDescription] = objFeatureRegionFldsEN.FeatureDescription; //功能说明
 }
objRow[conFeatureRegionFlds.ButtonName] = objFeatureRegionFldsEN.ButtonName; //按钮名称
objRow[conFeatureRegionFlds.ButtonName4Mvc] = objFeatureRegionFldsEN.ButtonName4Mvc; //按钮名称4Mvc
 if (objFeatureRegionFldsEN.CommandName !=  "")
 {
objRow[conFeatureRegionFlds.CommandName] = objFeatureRegionFldsEN.CommandName; //命令名
 }
 if (objFeatureRegionFldsEN.ValueGivingModeId !=  "")
 {
objRow[conFeatureRegionFlds.ValueGivingModeId] = objFeatureRegionFldsEN.ValueGivingModeId; //给值方式Id
 }
 if (objFeatureRegionFldsEN.FuncName !=  "")
 {
objRow[conFeatureRegionFlds.FuncName] = objFeatureRegionFldsEN.FuncName; //函数名
 }
 if (objFeatureRegionFldsEN.DefaultValue !=  "")
 {
objRow[conFeatureRegionFlds.DefaultValue] = objFeatureRegionFldsEN.DefaultValue; //缺省值
 }
 if (objFeatureRegionFldsEN.KeyIdGetModeId !=  "")
 {
objRow[conFeatureRegionFlds.KeyIdGetModeId] = objFeatureRegionFldsEN.KeyIdGetModeId; //GC关键字获取方式Id
 }
objRow[conFeatureRegionFlds.Text] = objFeatureRegionFldsEN.Text; //文本
 if (objFeatureRegionFldsEN.GroupName !=  "")
 {
objRow[conFeatureRegionFlds.GroupName] = objFeatureRegionFldsEN.GroupName; //组名
 }
objRow[conFeatureRegionFlds.ReleTabId] = objFeatureRegionFldsEN.ReleTabId; //相关表Id
 if (objFeatureRegionFldsEN.ReleFldId !=  "")
 {
objRow[conFeatureRegionFlds.ReleFldId] = objFeatureRegionFldsEN.ReleFldId; //相关字段Id
 }
 if (objFeatureRegionFldsEN.EventFuncName !=  "")
 {
objRow[conFeatureRegionFlds.EventFuncName] = objFeatureRegionFldsEN.EventFuncName; //事件函数名
 }
 if (objFeatureRegionFldsEN.FieldTypeId !=  "")
 {
objRow[conFeatureRegionFlds.FieldTypeId] = objFeatureRegionFldsEN.FieldTypeId; //字段类型Id
 }
objRow[conFeatureRegionFlds.ViewImplId] = objFeatureRegionFldsEN.ViewImplId; //界面实现Id
 if (objFeatureRegionFldsEN.CtlTypeId !=  "")
 {
objRow[conFeatureRegionFlds.CtlTypeId] = objFeatureRegionFldsEN.CtlTypeId; //控件类型号
 }
objRow[conFeatureRegionFlds.Height] = objFeatureRegionFldsEN.Height; //高度
objRow[conFeatureRegionFlds.Width] = objFeatureRegionFldsEN.Width; //宽
objRow[conFeatureRegionFlds.SeqNum] = objFeatureRegionFldsEN.SeqNum; //字段序号
 if (objFeatureRegionFldsEN.CssClass !=  "")
 {
objRow[conFeatureRegionFlds.CssClass] = objFeatureRegionFldsEN.CssClass; //样式表
 }
 if (objFeatureRegionFldsEN.ImageUrl !=  "")
 {
objRow[conFeatureRegionFlds.ImageUrl] = objFeatureRegionFldsEN.ImageUrl; //图片资源
 }
objRow[conFeatureRegionFlds.InUse] = objFeatureRegionFldsEN.InUse; //是否在用
 if (objFeatureRegionFldsEN.ErrMsg !=  "")
 {
objRow[conFeatureRegionFlds.ErrMsg] = objFeatureRegionFldsEN.ErrMsg; //错误信息
 }
objRow[conFeatureRegionFlds.PrjId] = objFeatureRegionFldsEN.PrjId; //工程Id
objRow[conFeatureRegionFlds.UpdUser] = objFeatureRegionFldsEN.UpdUser; //修改者
 if (objFeatureRegionFldsEN.UpdDate !=  "")
 {
objRow[conFeatureRegionFlds.UpdDate] = objFeatureRegionFldsEN.UpdDate; //修改日期
 }
 if (objFeatureRegionFldsEN.Memo !=  "")
 {
objRow[conFeatureRegionFlds.Memo] = objFeatureRegionFldsEN.Memo; //说明
 }
objDS.Tables[clsFeatureRegionFldsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFeatureRegionFldsEN._CurrTabName);
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
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFeatureRegionFldsEN.ViewFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ViewFeatureId);
 var strViewFeatureId = objFeatureRegionFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.RegionId  ==  "")
 {
 objFeatureRegionFldsEN.RegionId = null;
 }
 if (objFeatureRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.RegionId);
 var strRegionId = objFeatureRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objFeatureRegionFldsEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FeatureId);
 var strFeatureId = objFeatureRegionFldsEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.TabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.TabFeatureId);
 var strTabFeatureId = objFeatureRegionFldsEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.CheckTabFeature !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CheckTabFeature);
 var strCheckTabFeature = objFeatureRegionFldsEN.CheckTabFeature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTabFeature + "'");
 }
 
 if (objFeatureRegionFldsEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FeatureDescription);
 var strFeatureDescription = objFeatureRegionFldsEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objFeatureRegionFldsEN.ButtonName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ButtonName);
 var strButtonName = objFeatureRegionFldsEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName + "'");
 }
 
 if (objFeatureRegionFldsEN.ButtonName4Mvc !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ButtonName4Mvc);
 var strButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName4Mvc + "'");
 }
 
 if (objFeatureRegionFldsEN.CommandName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CommandName);
 var strCommandName = objFeatureRegionFldsEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommandName + "'");
 }
 
 if (objFeatureRegionFldsEN.ValueGivingModeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ValueGivingModeId);
 var strValueGivingModeId = objFeatureRegionFldsEN.ValueGivingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strValueGivingModeId + "'");
 }
 
 if (objFeatureRegionFldsEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FuncName);
 var strFuncName = objFeatureRegionFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objFeatureRegionFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.DefaultValue);
 var strDefaultValue = objFeatureRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objFeatureRegionFldsEN.KeyIdGetModeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.KeyIdGetModeId);
 var strKeyIdGetModeId = objFeatureRegionFldsEN.KeyIdGetModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyIdGetModeId + "'");
 }
 
 if (objFeatureRegionFldsEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Text);
 var strText = objFeatureRegionFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objFeatureRegionFldsEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.GroupName);
 var strGroupName = objFeatureRegionFldsEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objFeatureRegionFldsEN.ReleTabId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ReleTabId);
 var strReleTabId = objFeatureRegionFldsEN.ReleTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleTabId + "'");
 }
 
 if (objFeatureRegionFldsEN.ReleFldId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ReleFldId);
 var strReleFldId = objFeatureRegionFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleFldId + "'");
 }
 
 if (objFeatureRegionFldsEN.EventFuncName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.EventFuncName);
 var strEventFuncName = objFeatureRegionFldsEN.EventFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventFuncName + "'");
 }
 
 if (objFeatureRegionFldsEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FieldTypeId);
 var strFieldTypeId = objFeatureRegionFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFeatureRegionFldsEN.ViewImplId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ViewImplId);
 var strViewImplId = objFeatureRegionFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewImplId + "'");
 }
 
 if (objFeatureRegionFldsEN.CtlTypeId  ==  "")
 {
 objFeatureRegionFldsEN.CtlTypeId = null;
 }
 if (objFeatureRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CtlTypeId);
 var strCtlTypeId = objFeatureRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objFeatureRegionFldsEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Height);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.Height.ToString());
 }
 
 if (objFeatureRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Width);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.Width.ToString());
 }
 
 if (objFeatureRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.SeqNum);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.SeqNum.ToString());
 }
 
 if (objFeatureRegionFldsEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CssClass);
 var strCssClass = objFeatureRegionFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objFeatureRegionFldsEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ImageUrl);
 var strImageUrl = objFeatureRegionFldsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 arrFieldListForInsert.Add(conFeatureRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objFeatureRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFeatureRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ErrMsg);
 var strErrMsg = objFeatureRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objFeatureRegionFldsEN.PrjId  ==  "")
 {
 objFeatureRegionFldsEN.PrjId = null;
 }
 if (objFeatureRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.PrjId);
 var strPrjId = objFeatureRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFeatureRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.UpdUser);
 var strUpdUser = objFeatureRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFeatureRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.UpdDate);
 var strUpdDate = objFeatureRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFeatureRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Memo);
 var strMemo = objFeatureRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FeatureRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFeatureRegionFldsEN.ViewFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ViewFeatureId);
 var strViewFeatureId = objFeatureRegionFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.RegionId  ==  "")
 {
 objFeatureRegionFldsEN.RegionId = null;
 }
 if (objFeatureRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.RegionId);
 var strRegionId = objFeatureRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objFeatureRegionFldsEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FeatureId);
 var strFeatureId = objFeatureRegionFldsEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.TabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.TabFeatureId);
 var strTabFeatureId = objFeatureRegionFldsEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.CheckTabFeature !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CheckTabFeature);
 var strCheckTabFeature = objFeatureRegionFldsEN.CheckTabFeature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTabFeature + "'");
 }
 
 if (objFeatureRegionFldsEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FeatureDescription);
 var strFeatureDescription = objFeatureRegionFldsEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objFeatureRegionFldsEN.ButtonName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ButtonName);
 var strButtonName = objFeatureRegionFldsEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName + "'");
 }
 
 if (objFeatureRegionFldsEN.ButtonName4Mvc !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ButtonName4Mvc);
 var strButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName4Mvc + "'");
 }
 
 if (objFeatureRegionFldsEN.CommandName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CommandName);
 var strCommandName = objFeatureRegionFldsEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommandName + "'");
 }
 
 if (objFeatureRegionFldsEN.ValueGivingModeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ValueGivingModeId);
 var strValueGivingModeId = objFeatureRegionFldsEN.ValueGivingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strValueGivingModeId + "'");
 }
 
 if (objFeatureRegionFldsEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FuncName);
 var strFuncName = objFeatureRegionFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objFeatureRegionFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.DefaultValue);
 var strDefaultValue = objFeatureRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objFeatureRegionFldsEN.KeyIdGetModeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.KeyIdGetModeId);
 var strKeyIdGetModeId = objFeatureRegionFldsEN.KeyIdGetModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyIdGetModeId + "'");
 }
 
 if (objFeatureRegionFldsEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Text);
 var strText = objFeatureRegionFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objFeatureRegionFldsEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.GroupName);
 var strGroupName = objFeatureRegionFldsEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objFeatureRegionFldsEN.ReleTabId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ReleTabId);
 var strReleTabId = objFeatureRegionFldsEN.ReleTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleTabId + "'");
 }
 
 if (objFeatureRegionFldsEN.ReleFldId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ReleFldId);
 var strReleFldId = objFeatureRegionFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleFldId + "'");
 }
 
 if (objFeatureRegionFldsEN.EventFuncName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.EventFuncName);
 var strEventFuncName = objFeatureRegionFldsEN.EventFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventFuncName + "'");
 }
 
 if (objFeatureRegionFldsEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FieldTypeId);
 var strFieldTypeId = objFeatureRegionFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFeatureRegionFldsEN.ViewImplId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ViewImplId);
 var strViewImplId = objFeatureRegionFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewImplId + "'");
 }
 
 if (objFeatureRegionFldsEN.CtlTypeId  ==  "")
 {
 objFeatureRegionFldsEN.CtlTypeId = null;
 }
 if (objFeatureRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CtlTypeId);
 var strCtlTypeId = objFeatureRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objFeatureRegionFldsEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Height);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.Height.ToString());
 }
 
 if (objFeatureRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Width);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.Width.ToString());
 }
 
 if (objFeatureRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.SeqNum);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.SeqNum.ToString());
 }
 
 if (objFeatureRegionFldsEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CssClass);
 var strCssClass = objFeatureRegionFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objFeatureRegionFldsEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ImageUrl);
 var strImageUrl = objFeatureRegionFldsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 arrFieldListForInsert.Add(conFeatureRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objFeatureRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFeatureRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ErrMsg);
 var strErrMsg = objFeatureRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objFeatureRegionFldsEN.PrjId  ==  "")
 {
 objFeatureRegionFldsEN.PrjId = null;
 }
 if (objFeatureRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.PrjId);
 var strPrjId = objFeatureRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFeatureRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.UpdUser);
 var strUpdUser = objFeatureRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFeatureRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.UpdDate);
 var strUpdDate = objFeatureRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFeatureRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Memo);
 var strMemo = objFeatureRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FeatureRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFeatureRegionFldsEN.ViewFeatureId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFeatureRegionFldsEN objFeatureRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFeatureRegionFldsEN.ViewFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ViewFeatureId);
 var strViewFeatureId = objFeatureRegionFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.RegionId  ==  "")
 {
 objFeatureRegionFldsEN.RegionId = null;
 }
 if (objFeatureRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.RegionId);
 var strRegionId = objFeatureRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objFeatureRegionFldsEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FeatureId);
 var strFeatureId = objFeatureRegionFldsEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.TabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.TabFeatureId);
 var strTabFeatureId = objFeatureRegionFldsEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.CheckTabFeature !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CheckTabFeature);
 var strCheckTabFeature = objFeatureRegionFldsEN.CheckTabFeature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTabFeature + "'");
 }
 
 if (objFeatureRegionFldsEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FeatureDescription);
 var strFeatureDescription = objFeatureRegionFldsEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objFeatureRegionFldsEN.ButtonName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ButtonName);
 var strButtonName = objFeatureRegionFldsEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName + "'");
 }
 
 if (objFeatureRegionFldsEN.ButtonName4Mvc !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ButtonName4Mvc);
 var strButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName4Mvc + "'");
 }
 
 if (objFeatureRegionFldsEN.CommandName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CommandName);
 var strCommandName = objFeatureRegionFldsEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommandName + "'");
 }
 
 if (objFeatureRegionFldsEN.ValueGivingModeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ValueGivingModeId);
 var strValueGivingModeId = objFeatureRegionFldsEN.ValueGivingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strValueGivingModeId + "'");
 }
 
 if (objFeatureRegionFldsEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FuncName);
 var strFuncName = objFeatureRegionFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objFeatureRegionFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.DefaultValue);
 var strDefaultValue = objFeatureRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objFeatureRegionFldsEN.KeyIdGetModeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.KeyIdGetModeId);
 var strKeyIdGetModeId = objFeatureRegionFldsEN.KeyIdGetModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyIdGetModeId + "'");
 }
 
 if (objFeatureRegionFldsEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Text);
 var strText = objFeatureRegionFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objFeatureRegionFldsEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.GroupName);
 var strGroupName = objFeatureRegionFldsEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objFeatureRegionFldsEN.ReleTabId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ReleTabId);
 var strReleTabId = objFeatureRegionFldsEN.ReleTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleTabId + "'");
 }
 
 if (objFeatureRegionFldsEN.ReleFldId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ReleFldId);
 var strReleFldId = objFeatureRegionFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleFldId + "'");
 }
 
 if (objFeatureRegionFldsEN.EventFuncName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.EventFuncName);
 var strEventFuncName = objFeatureRegionFldsEN.EventFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventFuncName + "'");
 }
 
 if (objFeatureRegionFldsEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FieldTypeId);
 var strFieldTypeId = objFeatureRegionFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFeatureRegionFldsEN.ViewImplId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ViewImplId);
 var strViewImplId = objFeatureRegionFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewImplId + "'");
 }
 
 if (objFeatureRegionFldsEN.CtlTypeId  ==  "")
 {
 objFeatureRegionFldsEN.CtlTypeId = null;
 }
 if (objFeatureRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CtlTypeId);
 var strCtlTypeId = objFeatureRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objFeatureRegionFldsEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Height);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.Height.ToString());
 }
 
 if (objFeatureRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Width);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.Width.ToString());
 }
 
 if (objFeatureRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.SeqNum);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.SeqNum.ToString());
 }
 
 if (objFeatureRegionFldsEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CssClass);
 var strCssClass = objFeatureRegionFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objFeatureRegionFldsEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ImageUrl);
 var strImageUrl = objFeatureRegionFldsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 arrFieldListForInsert.Add(conFeatureRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objFeatureRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFeatureRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ErrMsg);
 var strErrMsg = objFeatureRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objFeatureRegionFldsEN.PrjId  ==  "")
 {
 objFeatureRegionFldsEN.PrjId = null;
 }
 if (objFeatureRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.PrjId);
 var strPrjId = objFeatureRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFeatureRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.UpdUser);
 var strUpdUser = objFeatureRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFeatureRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.UpdDate);
 var strUpdDate = objFeatureRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFeatureRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Memo);
 var strMemo = objFeatureRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FeatureRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFeatureRegionFldsEN.ViewFeatureId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFeatureRegionFldsEN objFeatureRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureRegionFldsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFeatureRegionFldsEN.ViewFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ViewFeatureId);
 var strViewFeatureId = objFeatureRegionFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.RegionId  ==  "")
 {
 objFeatureRegionFldsEN.RegionId = null;
 }
 if (objFeatureRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.RegionId);
 var strRegionId = objFeatureRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objFeatureRegionFldsEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FeatureId);
 var strFeatureId = objFeatureRegionFldsEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.TabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.TabFeatureId);
 var strTabFeatureId = objFeatureRegionFldsEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId + "'");
 }
 
 if (objFeatureRegionFldsEN.CheckTabFeature !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CheckTabFeature);
 var strCheckTabFeature = objFeatureRegionFldsEN.CheckTabFeature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTabFeature + "'");
 }
 
 if (objFeatureRegionFldsEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FeatureDescription);
 var strFeatureDescription = objFeatureRegionFldsEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objFeatureRegionFldsEN.ButtonName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ButtonName);
 var strButtonName = objFeatureRegionFldsEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName + "'");
 }
 
 if (objFeatureRegionFldsEN.ButtonName4Mvc !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ButtonName4Mvc);
 var strButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName4Mvc + "'");
 }
 
 if (objFeatureRegionFldsEN.CommandName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CommandName);
 var strCommandName = objFeatureRegionFldsEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommandName + "'");
 }
 
 if (objFeatureRegionFldsEN.ValueGivingModeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ValueGivingModeId);
 var strValueGivingModeId = objFeatureRegionFldsEN.ValueGivingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strValueGivingModeId + "'");
 }
 
 if (objFeatureRegionFldsEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FuncName);
 var strFuncName = objFeatureRegionFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objFeatureRegionFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.DefaultValue);
 var strDefaultValue = objFeatureRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objFeatureRegionFldsEN.KeyIdGetModeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.KeyIdGetModeId);
 var strKeyIdGetModeId = objFeatureRegionFldsEN.KeyIdGetModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyIdGetModeId + "'");
 }
 
 if (objFeatureRegionFldsEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Text);
 var strText = objFeatureRegionFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objFeatureRegionFldsEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.GroupName);
 var strGroupName = objFeatureRegionFldsEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objFeatureRegionFldsEN.ReleTabId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ReleTabId);
 var strReleTabId = objFeatureRegionFldsEN.ReleTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleTabId + "'");
 }
 
 if (objFeatureRegionFldsEN.ReleFldId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ReleFldId);
 var strReleFldId = objFeatureRegionFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleFldId + "'");
 }
 
 if (objFeatureRegionFldsEN.EventFuncName !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.EventFuncName);
 var strEventFuncName = objFeatureRegionFldsEN.EventFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventFuncName + "'");
 }
 
 if (objFeatureRegionFldsEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.FieldTypeId);
 var strFieldTypeId = objFeatureRegionFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFeatureRegionFldsEN.ViewImplId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ViewImplId);
 var strViewImplId = objFeatureRegionFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewImplId + "'");
 }
 
 if (objFeatureRegionFldsEN.CtlTypeId  ==  "")
 {
 objFeatureRegionFldsEN.CtlTypeId = null;
 }
 if (objFeatureRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CtlTypeId);
 var strCtlTypeId = objFeatureRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objFeatureRegionFldsEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Height);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.Height.ToString());
 }
 
 if (objFeatureRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Width);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.Width.ToString());
 }
 
 if (objFeatureRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.SeqNum);
 arrValueListForInsert.Add(objFeatureRegionFldsEN.SeqNum.ToString());
 }
 
 if (objFeatureRegionFldsEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.CssClass);
 var strCssClass = objFeatureRegionFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objFeatureRegionFldsEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ImageUrl);
 var strImageUrl = objFeatureRegionFldsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 arrFieldListForInsert.Add(conFeatureRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objFeatureRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFeatureRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.ErrMsg);
 var strErrMsg = objFeatureRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objFeatureRegionFldsEN.PrjId  ==  "")
 {
 objFeatureRegionFldsEN.PrjId = null;
 }
 if (objFeatureRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.PrjId);
 var strPrjId = objFeatureRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFeatureRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.UpdUser);
 var strUpdUser = objFeatureRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFeatureRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.UpdDate);
 var strUpdDate = objFeatureRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFeatureRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFeatureRegionFlds.Memo);
 var strMemo = objFeatureRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FeatureRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFeatureRegionFldss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where ViewFeatureId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FeatureRegionFlds");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strViewFeatureId = oRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim();
if (IsExist(strViewFeatureId))
{
 string strResult = "关键字变量值为:" + string.Format("ViewFeatureId = {0}", strViewFeatureId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFeatureRegionFldsEN._CurrTabName ].NewRow();
objRow[conFeatureRegionFlds.ViewFeatureId] = oRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objRow[conFeatureRegionFlds.RegionId] = oRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objRow[conFeatureRegionFlds.FeatureId] = oRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objRow[conFeatureRegionFlds.TabFeatureId] = oRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objRow[conFeatureRegionFlds.CheckTabFeature] = oRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objRow[conFeatureRegionFlds.FeatureDescription] = oRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objRow[conFeatureRegionFlds.ButtonName] = oRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objRow[conFeatureRegionFlds.ButtonName4Mvc] = oRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objRow[conFeatureRegionFlds.CommandName] = oRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objRow[conFeatureRegionFlds.ValueGivingModeId] = oRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objRow[conFeatureRegionFlds.FuncName] = oRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objRow[conFeatureRegionFlds.DefaultValue] = oRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objRow[conFeatureRegionFlds.KeyIdGetModeId] = oRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objRow[conFeatureRegionFlds.Text] = oRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objRow[conFeatureRegionFlds.GroupName] = oRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objRow[conFeatureRegionFlds.ReleTabId] = oRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objRow[conFeatureRegionFlds.ReleFldId] = oRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objRow[conFeatureRegionFlds.EventFuncName] = oRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objRow[conFeatureRegionFlds.FieldTypeId] = oRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objRow[conFeatureRegionFlds.ViewImplId] = oRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objRow[conFeatureRegionFlds.CtlTypeId] = oRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objRow[conFeatureRegionFlds.Height] = oRow[conFeatureRegionFlds.Height].ToString().Trim(); //高度
objRow[conFeatureRegionFlds.Width] = oRow[conFeatureRegionFlds.Width].ToString().Trim(); //宽
objRow[conFeatureRegionFlds.SeqNum] = oRow[conFeatureRegionFlds.SeqNum].ToString().Trim(); //字段序号
objRow[conFeatureRegionFlds.CssClass] = oRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objRow[conFeatureRegionFlds.ImageUrl] = oRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objRow[conFeatureRegionFlds.InUse] = oRow[conFeatureRegionFlds.InUse].ToString().Trim(); //是否在用
objRow[conFeatureRegionFlds.ErrMsg] = oRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objRow[conFeatureRegionFlds.PrjId] = oRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objRow[conFeatureRegionFlds.UpdUser] = oRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objRow[conFeatureRegionFlds.UpdDate] = oRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objRow[conFeatureRegionFlds.Memo] = oRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFeatureRegionFldsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFeatureRegionFldsEN._CurrTabName);
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
 /// <param name = "objFeatureRegionFldsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureRegionFldsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from FeatureRegionFlds where ViewFeatureId = " + "'"+ objFeatureRegionFldsEN.ViewFeatureId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFeatureRegionFldsEN._CurrTabName);
if (objDS.Tables[clsFeatureRegionFldsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ViewFeatureId = " + "'"+ objFeatureRegionFldsEN.ViewFeatureId+"'");
return false;
}
objRow = objDS.Tables[clsFeatureRegionFldsEN._CurrTabName].Rows[0];
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ViewFeatureId))
 {
objRow[conFeatureRegionFlds.ViewFeatureId] = objFeatureRegionFldsEN.ViewFeatureId; //界面功能Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.RegionId))
 {
objRow[conFeatureRegionFlds.RegionId] = objFeatureRegionFldsEN.RegionId; //区域Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureId))
 {
objRow[conFeatureRegionFlds.FeatureId] = objFeatureRegionFldsEN.FeatureId; //功能Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.TabFeatureId))
 {
objRow[conFeatureRegionFlds.TabFeatureId] = objFeatureRegionFldsEN.TabFeatureId; //表功能Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CheckTabFeature))
 {
objRow[conFeatureRegionFlds.CheckTabFeature] = objFeatureRegionFldsEN.CheckTabFeature; //检查表功能
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureDescription))
 {
objRow[conFeatureRegionFlds.FeatureDescription] = objFeatureRegionFldsEN.FeatureDescription; //功能说明
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName))
 {
objRow[conFeatureRegionFlds.ButtonName] = objFeatureRegionFldsEN.ButtonName; //按钮名称
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName4Mvc))
 {
objRow[conFeatureRegionFlds.ButtonName4Mvc] = objFeatureRegionFldsEN.ButtonName4Mvc; //按钮名称4Mvc
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CommandName))
 {
objRow[conFeatureRegionFlds.CommandName] = objFeatureRegionFldsEN.CommandName; //命令名
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ValueGivingModeId))
 {
objRow[conFeatureRegionFlds.ValueGivingModeId] = objFeatureRegionFldsEN.ValueGivingModeId; //给值方式Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FuncName))
 {
objRow[conFeatureRegionFlds.FuncName] = objFeatureRegionFldsEN.FuncName; //函数名
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.DefaultValue))
 {
objRow[conFeatureRegionFlds.DefaultValue] = objFeatureRegionFldsEN.DefaultValue; //缺省值
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.KeyIdGetModeId))
 {
objRow[conFeatureRegionFlds.KeyIdGetModeId] = objFeatureRegionFldsEN.KeyIdGetModeId; //GC关键字获取方式Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Text))
 {
objRow[conFeatureRegionFlds.Text] = objFeatureRegionFldsEN.Text; //文本
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.GroupName))
 {
objRow[conFeatureRegionFlds.GroupName] = objFeatureRegionFldsEN.GroupName; //组名
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleTabId))
 {
objRow[conFeatureRegionFlds.ReleTabId] = objFeatureRegionFldsEN.ReleTabId; //相关表Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleFldId))
 {
objRow[conFeatureRegionFlds.ReleFldId] = objFeatureRegionFldsEN.ReleFldId; //相关字段Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.EventFuncName))
 {
objRow[conFeatureRegionFlds.EventFuncName] = objFeatureRegionFldsEN.EventFuncName; //事件函数名
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FieldTypeId))
 {
objRow[conFeatureRegionFlds.FieldTypeId] = objFeatureRegionFldsEN.FieldTypeId; //字段类型Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ViewImplId))
 {
objRow[conFeatureRegionFlds.ViewImplId] = objFeatureRegionFldsEN.ViewImplId; //界面实现Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CtlTypeId))
 {
objRow[conFeatureRegionFlds.CtlTypeId] = objFeatureRegionFldsEN.CtlTypeId; //控件类型号
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Height))
 {
objRow[conFeatureRegionFlds.Height] = objFeatureRegionFldsEN.Height; //高度
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Width))
 {
objRow[conFeatureRegionFlds.Width] = objFeatureRegionFldsEN.Width; //宽
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.SeqNum))
 {
objRow[conFeatureRegionFlds.SeqNum] = objFeatureRegionFldsEN.SeqNum; //字段序号
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CssClass))
 {
objRow[conFeatureRegionFlds.CssClass] = objFeatureRegionFldsEN.CssClass; //样式表
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ImageUrl))
 {
objRow[conFeatureRegionFlds.ImageUrl] = objFeatureRegionFldsEN.ImageUrl; //图片资源
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.InUse))
 {
objRow[conFeatureRegionFlds.InUse] = objFeatureRegionFldsEN.InUse; //是否在用
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ErrMsg))
 {
objRow[conFeatureRegionFlds.ErrMsg] = objFeatureRegionFldsEN.ErrMsg; //错误信息
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.PrjId))
 {
objRow[conFeatureRegionFlds.PrjId] = objFeatureRegionFldsEN.PrjId; //工程Id
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdUser))
 {
objRow[conFeatureRegionFlds.UpdUser] = objFeatureRegionFldsEN.UpdUser; //修改者
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdDate))
 {
objRow[conFeatureRegionFlds.UpdDate] = objFeatureRegionFldsEN.UpdDate; //修改日期
 }
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Memo))
 {
objRow[conFeatureRegionFlds.Memo] = objFeatureRegionFldsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFeatureRegionFldsEN._CurrTabName);
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
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FeatureRegionFlds Set ");
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.RegionId))
 {
 if (objFeatureRegionFldsEN.RegionId  ==  "")
 {
 objFeatureRegionFldsEN.RegionId = null;
 }
 if (objFeatureRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objFeatureRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conFeatureRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureId))
 {
 if (objFeatureRegionFldsEN.FeatureId !=  null)
 {
 var strFeatureId = objFeatureRegionFldsEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureId, conFeatureRegionFlds.FeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.FeatureId); //功能Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.TabFeatureId))
 {
 if (objFeatureRegionFldsEN.TabFeatureId !=  null)
 {
 var strTabFeatureId = objFeatureRegionFldsEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureId, conFeatureRegionFlds.TabFeatureId); //表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.TabFeatureId); //表功能Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CheckTabFeature))
 {
 if (objFeatureRegionFldsEN.CheckTabFeature !=  null)
 {
 var strCheckTabFeature = objFeatureRegionFldsEN.CheckTabFeature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckTabFeature, conFeatureRegionFlds.CheckTabFeature); //检查表功能
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.CheckTabFeature); //检查表功能
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureDescription))
 {
 if (objFeatureRegionFldsEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objFeatureRegionFldsEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureDescription, conFeatureRegionFlds.FeatureDescription); //功能说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.FeatureDescription); //功能说明
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName))
 {
 if (objFeatureRegionFldsEN.ButtonName !=  null)
 {
 var strButtonName = objFeatureRegionFldsEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strButtonName, conFeatureRegionFlds.ButtonName); //按钮名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ButtonName); //按钮名称
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName4Mvc))
 {
 if (objFeatureRegionFldsEN.ButtonName4Mvc !=  null)
 {
 var strButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strButtonName4Mvc, conFeatureRegionFlds.ButtonName4Mvc); //按钮名称4Mvc
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ButtonName4Mvc); //按钮名称4Mvc
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CommandName))
 {
 if (objFeatureRegionFldsEN.CommandName !=  null)
 {
 var strCommandName = objFeatureRegionFldsEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCommandName, conFeatureRegionFlds.CommandName); //命令名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.CommandName); //命令名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ValueGivingModeId))
 {
 if (objFeatureRegionFldsEN.ValueGivingModeId !=  null)
 {
 var strValueGivingModeId = objFeatureRegionFldsEN.ValueGivingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strValueGivingModeId, conFeatureRegionFlds.ValueGivingModeId); //给值方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ValueGivingModeId); //给值方式Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FuncName))
 {
 if (objFeatureRegionFldsEN.FuncName !=  null)
 {
 var strFuncName = objFeatureRegionFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName, conFeatureRegionFlds.FuncName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.FuncName); //函数名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.DefaultValue))
 {
 if (objFeatureRegionFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objFeatureRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conFeatureRegionFlds.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.DefaultValue); //缺省值
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.KeyIdGetModeId))
 {
 if (objFeatureRegionFldsEN.KeyIdGetModeId !=  null)
 {
 var strKeyIdGetModeId = objFeatureRegionFldsEN.KeyIdGetModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyIdGetModeId, conFeatureRegionFlds.KeyIdGetModeId); //GC关键字获取方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.KeyIdGetModeId); //GC关键字获取方式Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Text))
 {
 if (objFeatureRegionFldsEN.Text !=  null)
 {
 var strText = objFeatureRegionFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strText, conFeatureRegionFlds.Text); //文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Text); //文本
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.GroupName))
 {
 if (objFeatureRegionFldsEN.GroupName !=  null)
 {
 var strGroupName = objFeatureRegionFldsEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupName, conFeatureRegionFlds.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.GroupName); //组名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleTabId))
 {
 if (objFeatureRegionFldsEN.ReleTabId !=  null)
 {
 var strReleTabId = objFeatureRegionFldsEN.ReleTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReleTabId, conFeatureRegionFlds.ReleTabId); //相关表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ReleTabId); //相关表Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleFldId))
 {
 if (objFeatureRegionFldsEN.ReleFldId !=  null)
 {
 var strReleFldId = objFeatureRegionFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReleFldId, conFeatureRegionFlds.ReleFldId); //相关字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ReleFldId); //相关字段Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.EventFuncName))
 {
 if (objFeatureRegionFldsEN.EventFuncName !=  null)
 {
 var strEventFuncName = objFeatureRegionFldsEN.EventFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEventFuncName, conFeatureRegionFlds.EventFuncName); //事件函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.EventFuncName); //事件函数名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FieldTypeId))
 {
 if (objFeatureRegionFldsEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFeatureRegionFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conFeatureRegionFlds.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.FieldTypeId); //字段类型Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ViewImplId))
 {
 if (objFeatureRegionFldsEN.ViewImplId !=  null)
 {
 var strViewImplId = objFeatureRegionFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewImplId, conFeatureRegionFlds.ViewImplId); //界面实现Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ViewImplId); //界面实现Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CtlTypeId))
 {
 if (objFeatureRegionFldsEN.CtlTypeId  ==  "")
 {
 objFeatureRegionFldsEN.CtlTypeId = null;
 }
 if (objFeatureRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objFeatureRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conFeatureRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Height))
 {
 if (objFeatureRegionFldsEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.Height, conFeatureRegionFlds.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Height); //高度
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Width))
 {
 if (objFeatureRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.Width, conFeatureRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Width); //宽
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.SeqNum))
 {
 if (objFeatureRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.SeqNum, conFeatureRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CssClass))
 {
 if (objFeatureRegionFldsEN.CssClass !=  null)
 {
 var strCssClass = objFeatureRegionFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCssClass, conFeatureRegionFlds.CssClass); //样式表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.CssClass); //样式表
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ImageUrl))
 {
 if (objFeatureRegionFldsEN.ImageUrl !=  null)
 {
 var strImageUrl = objFeatureRegionFldsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conFeatureRegionFlds.ImageUrl); //图片资源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ImageUrl); //图片资源
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFeatureRegionFldsEN.InUse == true?"1":"0", conFeatureRegionFlds.InUse); //是否在用
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ErrMsg))
 {
 if (objFeatureRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objFeatureRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conFeatureRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.PrjId))
 {
 if (objFeatureRegionFldsEN.PrjId  ==  "")
 {
 objFeatureRegionFldsEN.PrjId = null;
 }
 if (objFeatureRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objFeatureRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFeatureRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdUser))
 {
 if (objFeatureRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objFeatureRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFeatureRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdDate))
 {
 if (objFeatureRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objFeatureRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFeatureRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Memo))
 {
 if (objFeatureRegionFldsEN.Memo !=  null)
 {
 var strMemo = objFeatureRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFeatureRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewFeatureId = '{0}'", objFeatureRegionFldsEN.ViewFeatureId); 
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
 /// <param name = "objFeatureRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCondition)
{
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FeatureRegionFlds Set ");
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.RegionId))
 {
 if (objFeatureRegionFldsEN.RegionId  ==  "")
 {
 objFeatureRegionFldsEN.RegionId = null;
 }
 if (objFeatureRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objFeatureRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureId))
 {
 if (objFeatureRegionFldsEN.FeatureId !=  null)
 {
 var strFeatureId = objFeatureRegionFldsEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureId = '{0}',", strFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" FeatureId = null,"); //功能Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.TabFeatureId))
 {
 if (objFeatureRegionFldsEN.TabFeatureId !=  null)
 {
 var strTabFeatureId = objFeatureRegionFldsEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureId = '{0}',", strTabFeatureId); //表功能Id
 }
 else
 {
 sbSQL.Append(" TabFeatureId = null,"); //表功能Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CheckTabFeature))
 {
 if (objFeatureRegionFldsEN.CheckTabFeature !=  null)
 {
 var strCheckTabFeature = objFeatureRegionFldsEN.CheckTabFeature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckTabFeature = '{0}',", strCheckTabFeature); //检查表功能
 }
 else
 {
 sbSQL.Append(" CheckTabFeature = null,"); //检查表功能
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureDescription))
 {
 if (objFeatureRegionFldsEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objFeatureRegionFldsEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureDescription = '{0}',", strFeatureDescription); //功能说明
 }
 else
 {
 sbSQL.Append(" FeatureDescription = null,"); //功能说明
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName))
 {
 if (objFeatureRegionFldsEN.ButtonName !=  null)
 {
 var strButtonName = objFeatureRegionFldsEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ButtonName = '{0}',", strButtonName); //按钮名称
 }
 else
 {
 sbSQL.Append(" ButtonName = null,"); //按钮名称
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName4Mvc))
 {
 if (objFeatureRegionFldsEN.ButtonName4Mvc !=  null)
 {
 var strButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ButtonName4Mvc = '{0}',", strButtonName4Mvc); //按钮名称4Mvc
 }
 else
 {
 sbSQL.Append(" ButtonName4Mvc = null,"); //按钮名称4Mvc
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CommandName))
 {
 if (objFeatureRegionFldsEN.CommandName !=  null)
 {
 var strCommandName = objFeatureRegionFldsEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CommandName = '{0}',", strCommandName); //命令名
 }
 else
 {
 sbSQL.Append(" CommandName = null,"); //命令名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ValueGivingModeId))
 {
 if (objFeatureRegionFldsEN.ValueGivingModeId !=  null)
 {
 var strValueGivingModeId = objFeatureRegionFldsEN.ValueGivingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ValueGivingModeId = '{0}',", strValueGivingModeId); //给值方式Id
 }
 else
 {
 sbSQL.Append(" ValueGivingModeId = null,"); //给值方式Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FuncName))
 {
 if (objFeatureRegionFldsEN.FuncName !=  null)
 {
 var strFuncName = objFeatureRegionFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName = '{0}',", strFuncName); //函数名
 }
 else
 {
 sbSQL.Append(" FuncName = null,"); //函数名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.DefaultValue))
 {
 if (objFeatureRegionFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objFeatureRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.KeyIdGetModeId))
 {
 if (objFeatureRegionFldsEN.KeyIdGetModeId !=  null)
 {
 var strKeyIdGetModeId = objFeatureRegionFldsEN.KeyIdGetModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyIdGetModeId = '{0}',", strKeyIdGetModeId); //GC关键字获取方式Id
 }
 else
 {
 sbSQL.Append(" KeyIdGetModeId = null,"); //GC关键字获取方式Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Text))
 {
 if (objFeatureRegionFldsEN.Text !=  null)
 {
 var strText = objFeatureRegionFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Text = '{0}',", strText); //文本
 }
 else
 {
 sbSQL.Append(" Text = null,"); //文本
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.GroupName))
 {
 if (objFeatureRegionFldsEN.GroupName !=  null)
 {
 var strGroupName = objFeatureRegionFldsEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", strGroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleTabId))
 {
 if (objFeatureRegionFldsEN.ReleTabId !=  null)
 {
 var strReleTabId = objFeatureRegionFldsEN.ReleTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReleTabId = '{0}',", strReleTabId); //相关表Id
 }
 else
 {
 sbSQL.Append(" ReleTabId = null,"); //相关表Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleFldId))
 {
 if (objFeatureRegionFldsEN.ReleFldId !=  null)
 {
 var strReleFldId = objFeatureRegionFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReleFldId = '{0}',", strReleFldId); //相关字段Id
 }
 else
 {
 sbSQL.Append(" ReleFldId = null,"); //相关字段Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.EventFuncName))
 {
 if (objFeatureRegionFldsEN.EventFuncName !=  null)
 {
 var strEventFuncName = objFeatureRegionFldsEN.EventFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EventFuncName = '{0}',", strEventFuncName); //事件函数名
 }
 else
 {
 sbSQL.Append(" EventFuncName = null,"); //事件函数名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FieldTypeId))
 {
 if (objFeatureRegionFldsEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFeatureRegionFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ViewImplId))
 {
 if (objFeatureRegionFldsEN.ViewImplId !=  null)
 {
 var strViewImplId = objFeatureRegionFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewImplId = '{0}',", strViewImplId); //界面实现Id
 }
 else
 {
 sbSQL.Append(" ViewImplId = null,"); //界面实现Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CtlTypeId))
 {
 if (objFeatureRegionFldsEN.CtlTypeId  ==  "")
 {
 objFeatureRegionFldsEN.CtlTypeId = null;
 }
 if (objFeatureRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objFeatureRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Height))
 {
 if (objFeatureRegionFldsEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.Height, conFeatureRegionFlds.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Height); //高度
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Width))
 {
 if (objFeatureRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.Width, conFeatureRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Width); //宽
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.SeqNum))
 {
 if (objFeatureRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.SeqNum, conFeatureRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CssClass))
 {
 if (objFeatureRegionFldsEN.CssClass !=  null)
 {
 var strCssClass = objFeatureRegionFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CssClass = '{0}',", strCssClass); //样式表
 }
 else
 {
 sbSQL.Append(" CssClass = null,"); //样式表
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ImageUrl))
 {
 if (objFeatureRegionFldsEN.ImageUrl !=  null)
 {
 var strImageUrl = objFeatureRegionFldsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //图片资源
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //图片资源
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objFeatureRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ErrMsg))
 {
 if (objFeatureRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objFeatureRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.PrjId))
 {
 if (objFeatureRegionFldsEN.PrjId  ==  "")
 {
 objFeatureRegionFldsEN.PrjId = null;
 }
 if (objFeatureRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objFeatureRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdUser))
 {
 if (objFeatureRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objFeatureRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdDate))
 {
 if (objFeatureRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objFeatureRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Memo))
 {
 if (objFeatureRegionFldsEN.Memo !=  null)
 {
 var strMemo = objFeatureRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFeatureRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FeatureRegionFlds Set ");
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.RegionId))
 {
 if (objFeatureRegionFldsEN.RegionId  ==  "")
 {
 objFeatureRegionFldsEN.RegionId = null;
 }
 if (objFeatureRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objFeatureRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureId))
 {
 if (objFeatureRegionFldsEN.FeatureId !=  null)
 {
 var strFeatureId = objFeatureRegionFldsEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureId = '{0}',", strFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" FeatureId = null,"); //功能Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.TabFeatureId))
 {
 if (objFeatureRegionFldsEN.TabFeatureId !=  null)
 {
 var strTabFeatureId = objFeatureRegionFldsEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureId = '{0}',", strTabFeatureId); //表功能Id
 }
 else
 {
 sbSQL.Append(" TabFeatureId = null,"); //表功能Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CheckTabFeature))
 {
 if (objFeatureRegionFldsEN.CheckTabFeature !=  null)
 {
 var strCheckTabFeature = objFeatureRegionFldsEN.CheckTabFeature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckTabFeature = '{0}',", strCheckTabFeature); //检查表功能
 }
 else
 {
 sbSQL.Append(" CheckTabFeature = null,"); //检查表功能
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureDescription))
 {
 if (objFeatureRegionFldsEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objFeatureRegionFldsEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureDescription = '{0}',", strFeatureDescription); //功能说明
 }
 else
 {
 sbSQL.Append(" FeatureDescription = null,"); //功能说明
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName))
 {
 if (objFeatureRegionFldsEN.ButtonName !=  null)
 {
 var strButtonName = objFeatureRegionFldsEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ButtonName = '{0}',", strButtonName); //按钮名称
 }
 else
 {
 sbSQL.Append(" ButtonName = null,"); //按钮名称
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName4Mvc))
 {
 if (objFeatureRegionFldsEN.ButtonName4Mvc !=  null)
 {
 var strButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ButtonName4Mvc = '{0}',", strButtonName4Mvc); //按钮名称4Mvc
 }
 else
 {
 sbSQL.Append(" ButtonName4Mvc = null,"); //按钮名称4Mvc
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CommandName))
 {
 if (objFeatureRegionFldsEN.CommandName !=  null)
 {
 var strCommandName = objFeatureRegionFldsEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CommandName = '{0}',", strCommandName); //命令名
 }
 else
 {
 sbSQL.Append(" CommandName = null,"); //命令名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ValueGivingModeId))
 {
 if (objFeatureRegionFldsEN.ValueGivingModeId !=  null)
 {
 var strValueGivingModeId = objFeatureRegionFldsEN.ValueGivingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ValueGivingModeId = '{0}',", strValueGivingModeId); //给值方式Id
 }
 else
 {
 sbSQL.Append(" ValueGivingModeId = null,"); //给值方式Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FuncName))
 {
 if (objFeatureRegionFldsEN.FuncName !=  null)
 {
 var strFuncName = objFeatureRegionFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName = '{0}',", strFuncName); //函数名
 }
 else
 {
 sbSQL.Append(" FuncName = null,"); //函数名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.DefaultValue))
 {
 if (objFeatureRegionFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objFeatureRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.KeyIdGetModeId))
 {
 if (objFeatureRegionFldsEN.KeyIdGetModeId !=  null)
 {
 var strKeyIdGetModeId = objFeatureRegionFldsEN.KeyIdGetModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyIdGetModeId = '{0}',", strKeyIdGetModeId); //GC关键字获取方式Id
 }
 else
 {
 sbSQL.Append(" KeyIdGetModeId = null,"); //GC关键字获取方式Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Text))
 {
 if (objFeatureRegionFldsEN.Text !=  null)
 {
 var strText = objFeatureRegionFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Text = '{0}',", strText); //文本
 }
 else
 {
 sbSQL.Append(" Text = null,"); //文本
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.GroupName))
 {
 if (objFeatureRegionFldsEN.GroupName !=  null)
 {
 var strGroupName = objFeatureRegionFldsEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", strGroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleTabId))
 {
 if (objFeatureRegionFldsEN.ReleTabId !=  null)
 {
 var strReleTabId = objFeatureRegionFldsEN.ReleTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReleTabId = '{0}',", strReleTabId); //相关表Id
 }
 else
 {
 sbSQL.Append(" ReleTabId = null,"); //相关表Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleFldId))
 {
 if (objFeatureRegionFldsEN.ReleFldId !=  null)
 {
 var strReleFldId = objFeatureRegionFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReleFldId = '{0}',", strReleFldId); //相关字段Id
 }
 else
 {
 sbSQL.Append(" ReleFldId = null,"); //相关字段Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.EventFuncName))
 {
 if (objFeatureRegionFldsEN.EventFuncName !=  null)
 {
 var strEventFuncName = objFeatureRegionFldsEN.EventFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EventFuncName = '{0}',", strEventFuncName); //事件函数名
 }
 else
 {
 sbSQL.Append(" EventFuncName = null,"); //事件函数名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FieldTypeId))
 {
 if (objFeatureRegionFldsEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFeatureRegionFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ViewImplId))
 {
 if (objFeatureRegionFldsEN.ViewImplId !=  null)
 {
 var strViewImplId = objFeatureRegionFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewImplId = '{0}',", strViewImplId); //界面实现Id
 }
 else
 {
 sbSQL.Append(" ViewImplId = null,"); //界面实现Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CtlTypeId))
 {
 if (objFeatureRegionFldsEN.CtlTypeId  ==  "")
 {
 objFeatureRegionFldsEN.CtlTypeId = null;
 }
 if (objFeatureRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objFeatureRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Height))
 {
 if (objFeatureRegionFldsEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.Height, conFeatureRegionFlds.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Height); //高度
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Width))
 {
 if (objFeatureRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.Width, conFeatureRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Width); //宽
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.SeqNum))
 {
 if (objFeatureRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.SeqNum, conFeatureRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CssClass))
 {
 if (objFeatureRegionFldsEN.CssClass !=  null)
 {
 var strCssClass = objFeatureRegionFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CssClass = '{0}',", strCssClass); //样式表
 }
 else
 {
 sbSQL.Append(" CssClass = null,"); //样式表
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ImageUrl))
 {
 if (objFeatureRegionFldsEN.ImageUrl !=  null)
 {
 var strImageUrl = objFeatureRegionFldsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //图片资源
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //图片资源
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objFeatureRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ErrMsg))
 {
 if (objFeatureRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objFeatureRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.PrjId))
 {
 if (objFeatureRegionFldsEN.PrjId  ==  "")
 {
 objFeatureRegionFldsEN.PrjId = null;
 }
 if (objFeatureRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objFeatureRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdUser))
 {
 if (objFeatureRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objFeatureRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdDate))
 {
 if (objFeatureRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objFeatureRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Memo))
 {
 if (objFeatureRegionFldsEN.Memo !=  null)
 {
 var strMemo = objFeatureRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFeatureRegionFldsEN objFeatureRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FeatureRegionFlds Set ");
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.RegionId))
 {
 if (objFeatureRegionFldsEN.RegionId  ==  "")
 {
 objFeatureRegionFldsEN.RegionId = null;
 }
 if (objFeatureRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objFeatureRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conFeatureRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureId))
 {
 if (objFeatureRegionFldsEN.FeatureId !=  null)
 {
 var strFeatureId = objFeatureRegionFldsEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureId, conFeatureRegionFlds.FeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.FeatureId); //功能Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.TabFeatureId))
 {
 if (objFeatureRegionFldsEN.TabFeatureId !=  null)
 {
 var strTabFeatureId = objFeatureRegionFldsEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureId, conFeatureRegionFlds.TabFeatureId); //表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.TabFeatureId); //表功能Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CheckTabFeature))
 {
 if (objFeatureRegionFldsEN.CheckTabFeature !=  null)
 {
 var strCheckTabFeature = objFeatureRegionFldsEN.CheckTabFeature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckTabFeature, conFeatureRegionFlds.CheckTabFeature); //检查表功能
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.CheckTabFeature); //检查表功能
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FeatureDescription))
 {
 if (objFeatureRegionFldsEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objFeatureRegionFldsEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureDescription, conFeatureRegionFlds.FeatureDescription); //功能说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.FeatureDescription); //功能说明
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName))
 {
 if (objFeatureRegionFldsEN.ButtonName !=  null)
 {
 var strButtonName = objFeatureRegionFldsEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strButtonName, conFeatureRegionFlds.ButtonName); //按钮名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ButtonName); //按钮名称
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ButtonName4Mvc))
 {
 if (objFeatureRegionFldsEN.ButtonName4Mvc !=  null)
 {
 var strButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strButtonName4Mvc, conFeatureRegionFlds.ButtonName4Mvc); //按钮名称4Mvc
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ButtonName4Mvc); //按钮名称4Mvc
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CommandName))
 {
 if (objFeatureRegionFldsEN.CommandName !=  null)
 {
 var strCommandName = objFeatureRegionFldsEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCommandName, conFeatureRegionFlds.CommandName); //命令名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.CommandName); //命令名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ValueGivingModeId))
 {
 if (objFeatureRegionFldsEN.ValueGivingModeId !=  null)
 {
 var strValueGivingModeId = objFeatureRegionFldsEN.ValueGivingModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strValueGivingModeId, conFeatureRegionFlds.ValueGivingModeId); //给值方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ValueGivingModeId); //给值方式Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FuncName))
 {
 if (objFeatureRegionFldsEN.FuncName !=  null)
 {
 var strFuncName = objFeatureRegionFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName, conFeatureRegionFlds.FuncName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.FuncName); //函数名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.DefaultValue))
 {
 if (objFeatureRegionFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objFeatureRegionFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conFeatureRegionFlds.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.DefaultValue); //缺省值
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.KeyIdGetModeId))
 {
 if (objFeatureRegionFldsEN.KeyIdGetModeId !=  null)
 {
 var strKeyIdGetModeId = objFeatureRegionFldsEN.KeyIdGetModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyIdGetModeId, conFeatureRegionFlds.KeyIdGetModeId); //GC关键字获取方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.KeyIdGetModeId); //GC关键字获取方式Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Text))
 {
 if (objFeatureRegionFldsEN.Text !=  null)
 {
 var strText = objFeatureRegionFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strText, conFeatureRegionFlds.Text); //文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Text); //文本
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.GroupName))
 {
 if (objFeatureRegionFldsEN.GroupName !=  null)
 {
 var strGroupName = objFeatureRegionFldsEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupName, conFeatureRegionFlds.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.GroupName); //组名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleTabId))
 {
 if (objFeatureRegionFldsEN.ReleTabId !=  null)
 {
 var strReleTabId = objFeatureRegionFldsEN.ReleTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReleTabId, conFeatureRegionFlds.ReleTabId); //相关表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ReleTabId); //相关表Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ReleFldId))
 {
 if (objFeatureRegionFldsEN.ReleFldId !=  null)
 {
 var strReleFldId = objFeatureRegionFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReleFldId, conFeatureRegionFlds.ReleFldId); //相关字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ReleFldId); //相关字段Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.EventFuncName))
 {
 if (objFeatureRegionFldsEN.EventFuncName !=  null)
 {
 var strEventFuncName = objFeatureRegionFldsEN.EventFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEventFuncName, conFeatureRegionFlds.EventFuncName); //事件函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.EventFuncName); //事件函数名
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.FieldTypeId))
 {
 if (objFeatureRegionFldsEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFeatureRegionFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conFeatureRegionFlds.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.FieldTypeId); //字段类型Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ViewImplId))
 {
 if (objFeatureRegionFldsEN.ViewImplId !=  null)
 {
 var strViewImplId = objFeatureRegionFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewImplId, conFeatureRegionFlds.ViewImplId); //界面实现Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ViewImplId); //界面实现Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CtlTypeId))
 {
 if (objFeatureRegionFldsEN.CtlTypeId  ==  "")
 {
 objFeatureRegionFldsEN.CtlTypeId = null;
 }
 if (objFeatureRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objFeatureRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conFeatureRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Height))
 {
 if (objFeatureRegionFldsEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.Height, conFeatureRegionFlds.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Height); //高度
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Width))
 {
 if (objFeatureRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.Width, conFeatureRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Width); //宽
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.SeqNum))
 {
 if (objFeatureRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureRegionFldsEN.SeqNum, conFeatureRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.CssClass))
 {
 if (objFeatureRegionFldsEN.CssClass !=  null)
 {
 var strCssClass = objFeatureRegionFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCssClass, conFeatureRegionFlds.CssClass); //样式表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.CssClass); //样式表
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ImageUrl))
 {
 if (objFeatureRegionFldsEN.ImageUrl !=  null)
 {
 var strImageUrl = objFeatureRegionFldsEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conFeatureRegionFlds.ImageUrl); //图片资源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ImageUrl); //图片资源
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFeatureRegionFldsEN.InUse == true?"1":"0", conFeatureRegionFlds.InUse); //是否在用
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.ErrMsg))
 {
 if (objFeatureRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objFeatureRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conFeatureRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.PrjId))
 {
 if (objFeatureRegionFldsEN.PrjId  ==  "")
 {
 objFeatureRegionFldsEN.PrjId = null;
 }
 if (objFeatureRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objFeatureRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFeatureRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdUser))
 {
 if (objFeatureRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objFeatureRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFeatureRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.UpdDate))
 {
 if (objFeatureRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objFeatureRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFeatureRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objFeatureRegionFldsEN.IsUpdated(conFeatureRegionFlds.Memo))
 {
 if (objFeatureRegionFldsEN.Memo !=  null)
 {
 var strMemo = objFeatureRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFeatureRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewFeatureId = '{0}'", objFeatureRegionFldsEN.ViewFeatureId); 
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
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strViewFeatureId) 
{
CheckPrimaryKey(strViewFeatureId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strViewFeatureId,
};
 objSQL.ExecSP("FeatureRegionFlds_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strViewFeatureId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strViewFeatureId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
//删除FeatureRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FeatureRegionFlds where ViewFeatureId = " + "'"+ strViewFeatureId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFeatureRegionFlds(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
//删除FeatureRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FeatureRegionFlds where ViewFeatureId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strViewFeatureId) 
{
CheckPrimaryKey(strViewFeatureId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
//删除FeatureRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FeatureRegionFlds where ViewFeatureId = " + "'"+ strViewFeatureId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFeatureRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: DelFeatureRegionFlds)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FeatureRegionFlds where " + strCondition ;
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
public bool DelFeatureRegionFldsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFeatureRegionFldsDA: DelFeatureRegionFldsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FeatureRegionFlds where " + strCondition ;
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
 /// <param name = "objFeatureRegionFldsENS">源对象</param>
 /// <param name = "objFeatureRegionFldsENT">目标对象</param>
public void CopyTo(clsFeatureRegionFldsEN objFeatureRegionFldsENS, clsFeatureRegionFldsEN objFeatureRegionFldsENT)
{
objFeatureRegionFldsENT.ViewFeatureId = objFeatureRegionFldsENS.ViewFeatureId; //界面功能Id
objFeatureRegionFldsENT.RegionId = objFeatureRegionFldsENS.RegionId; //区域Id
objFeatureRegionFldsENT.FeatureId = objFeatureRegionFldsENS.FeatureId; //功能Id
objFeatureRegionFldsENT.TabFeatureId = objFeatureRegionFldsENS.TabFeatureId; //表功能Id
objFeatureRegionFldsENT.CheckTabFeature = objFeatureRegionFldsENS.CheckTabFeature; //检查表功能
objFeatureRegionFldsENT.FeatureDescription = objFeatureRegionFldsENS.FeatureDescription; //功能说明
objFeatureRegionFldsENT.ButtonName = objFeatureRegionFldsENS.ButtonName; //按钮名称
objFeatureRegionFldsENT.ButtonName4Mvc = objFeatureRegionFldsENS.ButtonName4Mvc; //按钮名称4Mvc
objFeatureRegionFldsENT.CommandName = objFeatureRegionFldsENS.CommandName; //命令名
objFeatureRegionFldsENT.ValueGivingModeId = objFeatureRegionFldsENS.ValueGivingModeId; //给值方式Id
objFeatureRegionFldsENT.FuncName = objFeatureRegionFldsENS.FuncName; //函数名
objFeatureRegionFldsENT.DefaultValue = objFeatureRegionFldsENS.DefaultValue; //缺省值
objFeatureRegionFldsENT.KeyIdGetModeId = objFeatureRegionFldsENS.KeyIdGetModeId; //GC关键字获取方式Id
objFeatureRegionFldsENT.Text = objFeatureRegionFldsENS.Text; //文本
objFeatureRegionFldsENT.GroupName = objFeatureRegionFldsENS.GroupName; //组名
objFeatureRegionFldsENT.ReleTabId = objFeatureRegionFldsENS.ReleTabId; //相关表Id
objFeatureRegionFldsENT.ReleFldId = objFeatureRegionFldsENS.ReleFldId; //相关字段Id
objFeatureRegionFldsENT.EventFuncName = objFeatureRegionFldsENS.EventFuncName; //事件函数名
objFeatureRegionFldsENT.FieldTypeId = objFeatureRegionFldsENS.FieldTypeId; //字段类型Id
objFeatureRegionFldsENT.ViewImplId = objFeatureRegionFldsENS.ViewImplId; //界面实现Id
objFeatureRegionFldsENT.CtlTypeId = objFeatureRegionFldsENS.CtlTypeId; //控件类型号
objFeatureRegionFldsENT.Height = objFeatureRegionFldsENS.Height; //高度
objFeatureRegionFldsENT.Width = objFeatureRegionFldsENS.Width; //宽
objFeatureRegionFldsENT.SeqNum = objFeatureRegionFldsENS.SeqNum; //字段序号
objFeatureRegionFldsENT.CssClass = objFeatureRegionFldsENS.CssClass; //样式表
objFeatureRegionFldsENT.ImageUrl = objFeatureRegionFldsENS.ImageUrl; //图片资源
objFeatureRegionFldsENT.InUse = objFeatureRegionFldsENS.InUse; //是否在用
objFeatureRegionFldsENT.ErrMsg = objFeatureRegionFldsENS.ErrMsg; //错误信息
objFeatureRegionFldsENT.PrjId = objFeatureRegionFldsENS.PrjId; //工程Id
objFeatureRegionFldsENT.UpdUser = objFeatureRegionFldsENS.UpdUser; //修改者
objFeatureRegionFldsENT.UpdDate = objFeatureRegionFldsENS.UpdDate; //修改日期
objFeatureRegionFldsENT.Memo = objFeatureRegionFldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFeatureRegionFldsEN.RegionId, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldNotNull(objFeatureRegionFldsEN.FeatureId, conFeatureRegionFlds.FeatureId);
clsCheckSql.CheckFieldNotNull(objFeatureRegionFldsEN.ButtonName, conFeatureRegionFlds.ButtonName);
clsCheckSql.CheckFieldNotNull(objFeatureRegionFldsEN.ButtonName4Mvc, conFeatureRegionFlds.ButtonName4Mvc);
clsCheckSql.CheckFieldNotNull(objFeatureRegionFldsEN.Text, conFeatureRegionFlds.Text);
clsCheckSql.CheckFieldNotNull(objFeatureRegionFldsEN.ReleTabId, conFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckFieldNotNull(objFeatureRegionFldsEN.ViewImplId, conFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckFieldNotNull(objFeatureRegionFldsEN.PrjId, conFeatureRegionFlds.PrjId);
clsCheckSql.CheckFieldNotNull(objFeatureRegionFldsEN.UpdUser, conFeatureRegionFlds.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ViewFeatureId, 8, conFeatureRegionFlds.ViewFeatureId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.RegionId, 10, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FeatureId, 4, conFeatureRegionFlds.FeatureId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.TabFeatureId, 8, conFeatureRegionFlds.TabFeatureId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CheckTabFeature, 50, conFeatureRegionFlds.CheckTabFeature);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FeatureDescription, 4000, conFeatureRegionFlds.FeatureDescription);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ButtonName, 30, conFeatureRegionFlds.ButtonName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ButtonName4Mvc, 30, conFeatureRegionFlds.ButtonName4Mvc);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CommandName, 30, conFeatureRegionFlds.CommandName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ValueGivingModeId, 2, conFeatureRegionFlds.ValueGivingModeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FuncName, 100, conFeatureRegionFlds.FuncName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.DefaultValue, 50, conFeatureRegionFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.KeyIdGetModeId, 4, conFeatureRegionFlds.KeyIdGetModeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.Text, 30, conFeatureRegionFlds.Text);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.GroupName, 30, conFeatureRegionFlds.GroupName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ReleTabId, 8, conFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ReleFldId, 8, conFeatureRegionFlds.ReleFldId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.EventFuncName, 50, conFeatureRegionFlds.EventFuncName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FieldTypeId, 2, conFeatureRegionFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ViewImplId, 4, conFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CssClass, 50, conFeatureRegionFlds.CssClass);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ImageUrl, 100, conFeatureRegionFlds.ImageUrl);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ErrMsg, 2000, conFeatureRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.PrjId, 4, conFeatureRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.UpdUser, 20, conFeatureRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.UpdDate, 20, conFeatureRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.Memo, 1000, conFeatureRegionFlds.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objFeatureRegionFldsEN.RegionId, 10, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objFeatureRegionFldsEN.CtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objFeatureRegionFldsEN.PrjId, 4, conFeatureRegionFlds.PrjId);
 objFeatureRegionFldsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.RegionId, 10, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FeatureId, 4, conFeatureRegionFlds.FeatureId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.TabFeatureId, 8, conFeatureRegionFlds.TabFeatureId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CheckTabFeature, 50, conFeatureRegionFlds.CheckTabFeature);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FeatureDescription, 4000, conFeatureRegionFlds.FeatureDescription);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ButtonName, 30, conFeatureRegionFlds.ButtonName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ButtonName4Mvc, 30, conFeatureRegionFlds.ButtonName4Mvc);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CommandName, 30, conFeatureRegionFlds.CommandName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ValueGivingModeId, 2, conFeatureRegionFlds.ValueGivingModeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FuncName, 100, conFeatureRegionFlds.FuncName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.DefaultValue, 50, conFeatureRegionFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.KeyIdGetModeId, 4, conFeatureRegionFlds.KeyIdGetModeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.Text, 30, conFeatureRegionFlds.Text);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.GroupName, 30, conFeatureRegionFlds.GroupName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ReleTabId, 8, conFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ReleFldId, 8, conFeatureRegionFlds.ReleFldId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.EventFuncName, 50, conFeatureRegionFlds.EventFuncName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FieldTypeId, 2, conFeatureRegionFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ViewImplId, 4, conFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CssClass, 50, conFeatureRegionFlds.CssClass);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ImageUrl, 100, conFeatureRegionFlds.ImageUrl);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ErrMsg, 2000, conFeatureRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.PrjId, 4, conFeatureRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.UpdUser, 20, conFeatureRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.UpdDate, 20, conFeatureRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.Memo, 1000, conFeatureRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objFeatureRegionFldsEN.RegionId, 10, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objFeatureRegionFldsEN.CtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objFeatureRegionFldsEN.PrjId, 4, conFeatureRegionFlds.PrjId);
 objFeatureRegionFldsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ViewFeatureId, 8, conFeatureRegionFlds.ViewFeatureId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.RegionId, 10, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FeatureId, 4, conFeatureRegionFlds.FeatureId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.TabFeatureId, 8, conFeatureRegionFlds.TabFeatureId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CheckTabFeature, 50, conFeatureRegionFlds.CheckTabFeature);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FeatureDescription, 4000, conFeatureRegionFlds.FeatureDescription);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ButtonName, 30, conFeatureRegionFlds.ButtonName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ButtonName4Mvc, 30, conFeatureRegionFlds.ButtonName4Mvc);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CommandName, 30, conFeatureRegionFlds.CommandName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ValueGivingModeId, 2, conFeatureRegionFlds.ValueGivingModeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FuncName, 100, conFeatureRegionFlds.FuncName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.DefaultValue, 50, conFeatureRegionFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.KeyIdGetModeId, 4, conFeatureRegionFlds.KeyIdGetModeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.Text, 30, conFeatureRegionFlds.Text);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.GroupName, 30, conFeatureRegionFlds.GroupName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ReleTabId, 8, conFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ReleFldId, 8, conFeatureRegionFlds.ReleFldId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.EventFuncName, 50, conFeatureRegionFlds.EventFuncName);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.FieldTypeId, 2, conFeatureRegionFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ViewImplId, 4, conFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.CssClass, 50, conFeatureRegionFlds.CssClass);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ImageUrl, 100, conFeatureRegionFlds.ImageUrl);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.ErrMsg, 2000, conFeatureRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.PrjId, 4, conFeatureRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.UpdUser, 20, conFeatureRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.UpdDate, 20, conFeatureRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objFeatureRegionFldsEN.Memo, 1000, conFeatureRegionFlds.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.ViewFeatureId, conFeatureRegionFlds.ViewFeatureId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.RegionId, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.FeatureId, conFeatureRegionFlds.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.TabFeatureId, conFeatureRegionFlds.TabFeatureId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.CheckTabFeature, conFeatureRegionFlds.CheckTabFeature);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.FeatureDescription, conFeatureRegionFlds.FeatureDescription);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.ButtonName, conFeatureRegionFlds.ButtonName);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.ButtonName4Mvc, conFeatureRegionFlds.ButtonName4Mvc);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.CommandName, conFeatureRegionFlds.CommandName);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.ValueGivingModeId, conFeatureRegionFlds.ValueGivingModeId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.FuncName, conFeatureRegionFlds.FuncName);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.DefaultValue, conFeatureRegionFlds.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.KeyIdGetModeId, conFeatureRegionFlds.KeyIdGetModeId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.Text, conFeatureRegionFlds.Text);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.GroupName, conFeatureRegionFlds.GroupName);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.ReleTabId, conFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.ReleFldId, conFeatureRegionFlds.ReleFldId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.EventFuncName, conFeatureRegionFlds.EventFuncName);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.FieldTypeId, conFeatureRegionFlds.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.ViewImplId, conFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.CtlTypeId, conFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.CssClass, conFeatureRegionFlds.CssClass);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.ImageUrl, conFeatureRegionFlds.ImageUrl);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.ErrMsg, conFeatureRegionFlds.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.PrjId, conFeatureRegionFlds.PrjId);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.UpdUser, conFeatureRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.UpdDate, conFeatureRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFeatureRegionFldsEN.Memo, conFeatureRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objFeatureRegionFldsEN.RegionId, 10, conFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objFeatureRegionFldsEN.CtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objFeatureRegionFldsEN.PrjId, 4, conFeatureRegionFlds.PrjId);
 objFeatureRegionFldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FeatureRegionFlds(功能区域字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objFeatureRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objFeatureRegionFldsEN.ButtonName);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureRegionFldsEN.FeatureId);
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
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFeatureRegionFldsEN._CurrTabName);
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
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFeatureRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}