
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFeatureDA
 表名:PrjFeature(00050322)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:24:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 功能(PrjFeature)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjFeatureDA : clsCommBase4DA
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
 return clsPrjFeatureEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjFeatureEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjFeatureEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjFeatureEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjFeatureEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFeatureId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFeatureId)
{
strFeatureId = strFeatureId.Replace("'", "''");
if (strFeatureId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:PrjFeature中,检查关键字,长度不正确!(clsPrjFeatureDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PrjFeature中,关键字不能为空 或 null!(clsPrjFeatureDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPrjFeatureDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjFeature(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjFeatureDA: GetDataTable_PrjFeature)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFeature where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFeature where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjFeature where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjFeature.* " + 
$"from PrjFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjFeature.FeatureId not in " + 
$"(Select top {intTop_In} PrjFeature.FeatureId from PrjFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFeature where {1} and FeatureId not in (Select top {2} FeatureId from PrjFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFeature where {1} and FeatureId not in (Select top {3} FeatureId from PrjFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjFeature.* " + 
$"from PrjFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjFeature.FeatureId not in " + 
$"(Select top {intTop_In} PrjFeature.FeatureId from PrjFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFeature where {1} and FeatureId not in (Select top {2} FeatureId from PrjFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFeature where {1} and FeatureId not in (Select top {3} FeatureId from PrjFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjFeatureEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjFeatureDA:GetObjLst)", objException.Message));
}
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = TransNullToBool(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = TransNullToBool(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = TransNullToInt(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjFeatureDA: GetObjLst)", objException.Message));
}
objPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjFeatureEN);
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
public List<clsPrjFeatureEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjFeatureDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = TransNullToBool(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = TransNullToBool(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = TransNullToInt(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjFeatureDA: GetObjLst)", objException.Message));
}
objPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjFeatureEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjFeature(ref clsPrjFeatureEN objPrjFeatureEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where FeatureId = " + "'"+ objPrjFeatureEN.FeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjFeatureEN.FeatureId = objDT.Rows[0][conPrjFeature.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFeatureEN.FeatureName = objDT.Rows[0][conPrjFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objPrjFeatureEN.FeatureENName = objDT.Rows[0][conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objPrjFeatureEN.KeyWords = objDT.Rows[0][conPrjFeature.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objPrjFeatureEN.DefaButtonName = objDT.Rows[0][conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjFeatureEN.DefaButtonName4Mvc = objDT.Rows[0][conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjFeatureEN.RegionTypeId = objDT.Rows[0][conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFeatureEN.GroupName = objDT.Rows[0][conPrjFeature.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objPrjFeatureEN.FeatureDescription = objDT.Rows[0][conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objPrjFeatureEN.InOutTypeId = objDT.Rows[0][conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objPrjFeatureEN.IsNeedField = TransNullToBool(objDT.Rows[0][conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段(字段类型:bit,字段长度:1,是否可空:True)
 objPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objDT.Rows[0][conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能(字段类型:bit,字段长度:1,是否可空:True)
 objPrjFeatureEN.ParentFeatureId = objDT.Rows[0][conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFeatureEN.ParentFeatureName = objDT.Rows[0][conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objPrjFeatureEN.FunctionGroupId = objDT.Rows[0][conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFeatureEN.FeatureTypeId = objDT.Rows[0][conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjFeatureEN.CreateUserId = objDT.Rows[0][conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objPrjFeatureEN.InUse = TransNullToBool(objDT.Rows[0][conPrjFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objPrjFeatureEN.OrderNum = TransNullToInt(objDT.Rows[0][conPrjFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objPrjFeatureEN.UpdDate = objDT.Rows[0][conPrjFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFeatureEN.UpdUser = objDT.Rows[0][conPrjFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFeatureEN.Memo = objDT.Rows[0][conPrjFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjFeatureDA: GetPrjFeature)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjFeatureEN GetObjByFeatureId(string strFeatureId)
{
CheckPrimaryKey(strFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where FeatureId = " + "'"+ strFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
 objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc(字段类型:varchar,字段长度:30,是否可空:True)
 objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段(字段类型:bit,字段长度:1,是否可空:True)
 objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能(字段类型:bit,字段长度:1,是否可空:True)
 objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjFeatureDA: GetObjByFeatureId)", objException.Message));
}
return objPrjFeatureEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjFeatureEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjFeatureDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN()
{
FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(), //功能名称
FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(), //功能英文名
KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(), //关键字
DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(), //默认按钮名
DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(), //默认按钮名4Mvc
RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(), //区域类型Id
GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(), //组名
FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(), //功能说明
InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(), //INOUT类型ID
IsNeedField = TransNullToBool(objRow[conPrjFeature.IsNeedField].ToString().Trim()), //是否需要字段
IsNeedTabFeature = TransNullToBool(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()), //是否需要表功能
ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(), //父功能Id
ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(), //父功能名
FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(), //函数组Id
FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(), //功能类型Id
CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(), //建立用户Id
InUse = TransNullToBool(objRow[conPrjFeature.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[conPrjFeature.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim() //说明
};
objPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFeatureEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjFeatureDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjFeatureEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = TransNullToBool(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = TransNullToBool(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = TransNullToInt(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjFeatureDA: GetObjByDataRowPrjFeature)", objException.Message));
}
objPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFeatureEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjFeatureEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = TransNullToBool(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = TransNullToBool(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = TransNullToInt(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjFeatureDA: GetObjByDataRow)", objException.Message));
}
objPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFeatureEN;
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
objSQL = clsPrjFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjFeatureEN._CurrTabName, conPrjFeature.FeatureId, 4, "");
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
objSQL = clsPrjFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjFeatureEN._CurrTabName, conPrjFeature.FeatureId, 4, strPrefix);
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
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FeatureId from PrjFeature where " + strCondition;
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
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FeatureId from PrjFeature where " + strCondition;
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
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFeatureId)
{
CheckPrimaryKey(strFeatureId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjFeature", "FeatureId = " + "'"+ strFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjFeatureDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjFeature", strCondition))
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
objSQL = clsPrjFeatureDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjFeature");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjFeatureEN objPrjFeatureEN)
 {
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFeatureEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjFeature");
objRow = objDS.Tables["PrjFeature"].NewRow();
objRow[conPrjFeature.FeatureId] = objPrjFeatureEN.FeatureId; //功能Id
objRow[conPrjFeature.FeatureName] = objPrjFeatureEN.FeatureName; //功能名称
 if (objPrjFeatureEN.FeatureENName !=  "")
 {
objRow[conPrjFeature.FeatureENName] = objPrjFeatureEN.FeatureENName; //功能英文名
 }
 if (objPrjFeatureEN.KeyWords !=  "")
 {
objRow[conPrjFeature.KeyWords] = objPrjFeatureEN.KeyWords; //关键字
 }
 if (objPrjFeatureEN.DefaButtonName !=  "")
 {
objRow[conPrjFeature.DefaButtonName] = objPrjFeatureEN.DefaButtonName; //默认按钮名
 }
 if (objPrjFeatureEN.DefaButtonName4Mvc !=  "")
 {
objRow[conPrjFeature.DefaButtonName4Mvc] = objPrjFeatureEN.DefaButtonName4Mvc; //默认按钮名4Mvc
 }
 if (objPrjFeatureEN.RegionTypeId !=  "")
 {
objRow[conPrjFeature.RegionTypeId] = objPrjFeatureEN.RegionTypeId; //区域类型Id
 }
 if (objPrjFeatureEN.GroupName !=  "")
 {
objRow[conPrjFeature.GroupName] = objPrjFeatureEN.GroupName; //组名
 }
 if (objPrjFeatureEN.FeatureDescription !=  "")
 {
objRow[conPrjFeature.FeatureDescription] = objPrjFeatureEN.FeatureDescription; //功能说明
 }
objRow[conPrjFeature.InOutTypeId] = objPrjFeatureEN.InOutTypeId; //INOUT类型ID
objRow[conPrjFeature.IsNeedField] = objPrjFeatureEN.IsNeedField; //是否需要字段
objRow[conPrjFeature.IsNeedTabFeature] = objPrjFeatureEN.IsNeedTabFeature; //是否需要表功能
 if (objPrjFeatureEN.ParentFeatureId !=  "")
 {
objRow[conPrjFeature.ParentFeatureId] = objPrjFeatureEN.ParentFeatureId; //父功能Id
 }
 if (objPrjFeatureEN.ParentFeatureName !=  "")
 {
objRow[conPrjFeature.ParentFeatureName] = objPrjFeatureEN.ParentFeatureName; //父功能名
 }
objRow[conPrjFeature.FunctionGroupId] = objPrjFeatureEN.FunctionGroupId; //函数组Id
objRow[conPrjFeature.FeatureTypeId] = objPrjFeatureEN.FeatureTypeId; //功能类型Id
objRow[conPrjFeature.CreateUserId] = objPrjFeatureEN.CreateUserId; //建立用户Id
objRow[conPrjFeature.InUse] = objPrjFeatureEN.InUse; //是否在用
objRow[conPrjFeature.OrderNum] = objPrjFeatureEN.OrderNum; //序号
 if (objPrjFeatureEN.UpdDate !=  "")
 {
objRow[conPrjFeature.UpdDate] = objPrjFeatureEN.UpdDate; //修改日期
 }
 if (objPrjFeatureEN.UpdUser !=  "")
 {
objRow[conPrjFeature.UpdUser] = objPrjFeatureEN.UpdUser; //修改者
 }
 if (objPrjFeatureEN.Memo !=  "")
 {
objRow[conPrjFeature.Memo] = objPrjFeatureEN.Memo; //说明
 }
objDS.Tables[clsPrjFeatureEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjFeatureEN._CurrTabName);
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjFeatureEN objPrjFeatureEN)
{
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFeatureEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFeatureEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureId);
 var strFeatureId = objPrjFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objPrjFeatureEN.FeatureName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureName);
 var strFeatureName = objPrjFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureName + "'");
 }
 
 if (objPrjFeatureEN.FeatureENName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureENName);
 var strFeatureENName = objPrjFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureENName + "'");
 }
 
 if (objPrjFeatureEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.KeyWords);
 var strKeyWords = objPrjFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objPrjFeatureEN.DefaButtonName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.DefaButtonName);
 var strDefaButtonName = objPrjFeatureEN.DefaButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaButtonName + "'");
 }
 
 if (objPrjFeatureEN.DefaButtonName4Mvc !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.DefaButtonName4Mvc);
 var strDefaButtonName4Mvc = objPrjFeatureEN.DefaButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaButtonName4Mvc + "'");
 }
 
 if (objPrjFeatureEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.RegionTypeId);
 var strRegionTypeId = objPrjFeatureEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeId + "'");
 }
 
 if (objPrjFeatureEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.GroupName);
 var strGroupName = objPrjFeatureEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objPrjFeatureEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureDescription);
 var strFeatureDescription = objPrjFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objPrjFeatureEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.InOutTypeId);
 var strInOutTypeId = objPrjFeatureEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFeature.IsNeedField);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.IsNeedField  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjFeature.IsNeedTabFeature);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.IsNeedTabFeature  ==  false ? "0" : "1") + "'");
 
 if (objPrjFeatureEN.ParentFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.ParentFeatureId);
 var strParentFeatureId = objPrjFeatureEN.ParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureId + "'");
 }
 
 if (objPrjFeatureEN.ParentFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.ParentFeatureName);
 var strParentFeatureName = objPrjFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureName + "'");
 }
 
 if (objPrjFeatureEN.FunctionGroupId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FunctionGroupId);
 var strFunctionGroupId = objPrjFeatureEN.FunctionGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionGroupId + "'");
 }
 
 if (objPrjFeatureEN.FeatureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureTypeId);
 var strFeatureTypeId = objPrjFeatureEN.FeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureTypeId + "'");
 }
 
 if (objPrjFeatureEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.CreateUserId);
 var strCreateUserId = objPrjFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFeature.InUse);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjFeature.OrderNum);
 arrValueListForInsert.Add(objPrjFeatureEN.OrderNum.ToString());
 
 if (objPrjFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.UpdDate);
 var strUpdDate = objPrjFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.UpdUser);
 var strUpdUser = objPrjFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.Memo);
 var strMemo = objPrjFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFeature");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjFeatureEN objPrjFeatureEN)
{
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFeatureEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFeatureEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureId);
 var strFeatureId = objPrjFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objPrjFeatureEN.FeatureName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureName);
 var strFeatureName = objPrjFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureName + "'");
 }
 
 if (objPrjFeatureEN.FeatureENName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureENName);
 var strFeatureENName = objPrjFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureENName + "'");
 }
 
 if (objPrjFeatureEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.KeyWords);
 var strKeyWords = objPrjFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objPrjFeatureEN.DefaButtonName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.DefaButtonName);
 var strDefaButtonName = objPrjFeatureEN.DefaButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaButtonName + "'");
 }
 
 if (objPrjFeatureEN.DefaButtonName4Mvc !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.DefaButtonName4Mvc);
 var strDefaButtonName4Mvc = objPrjFeatureEN.DefaButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaButtonName4Mvc + "'");
 }
 
 if (objPrjFeatureEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.RegionTypeId);
 var strRegionTypeId = objPrjFeatureEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeId + "'");
 }
 
 if (objPrjFeatureEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.GroupName);
 var strGroupName = objPrjFeatureEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objPrjFeatureEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureDescription);
 var strFeatureDescription = objPrjFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objPrjFeatureEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.InOutTypeId);
 var strInOutTypeId = objPrjFeatureEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFeature.IsNeedField);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.IsNeedField  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjFeature.IsNeedTabFeature);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.IsNeedTabFeature  ==  false ? "0" : "1") + "'");
 
 if (objPrjFeatureEN.ParentFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.ParentFeatureId);
 var strParentFeatureId = objPrjFeatureEN.ParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureId + "'");
 }
 
 if (objPrjFeatureEN.ParentFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.ParentFeatureName);
 var strParentFeatureName = objPrjFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureName + "'");
 }
 
 if (objPrjFeatureEN.FunctionGroupId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FunctionGroupId);
 var strFunctionGroupId = objPrjFeatureEN.FunctionGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionGroupId + "'");
 }
 
 if (objPrjFeatureEN.FeatureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureTypeId);
 var strFeatureTypeId = objPrjFeatureEN.FeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureTypeId + "'");
 }
 
 if (objPrjFeatureEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.CreateUserId);
 var strCreateUserId = objPrjFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFeature.InUse);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjFeature.OrderNum);
 arrValueListForInsert.Add(objPrjFeatureEN.OrderNum.ToString());
 
 if (objPrjFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.UpdDate);
 var strUpdDate = objPrjFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.UpdUser);
 var strUpdUser = objPrjFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.Memo);
 var strMemo = objPrjFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFeature");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPrjFeatureEN.FeatureId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjFeatureEN objPrjFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFeatureEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFeatureEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureId);
 var strFeatureId = objPrjFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objPrjFeatureEN.FeatureName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureName);
 var strFeatureName = objPrjFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureName + "'");
 }
 
 if (objPrjFeatureEN.FeatureENName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureENName);
 var strFeatureENName = objPrjFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureENName + "'");
 }
 
 if (objPrjFeatureEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.KeyWords);
 var strKeyWords = objPrjFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objPrjFeatureEN.DefaButtonName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.DefaButtonName);
 var strDefaButtonName = objPrjFeatureEN.DefaButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaButtonName + "'");
 }
 
 if (objPrjFeatureEN.DefaButtonName4Mvc !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.DefaButtonName4Mvc);
 var strDefaButtonName4Mvc = objPrjFeatureEN.DefaButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaButtonName4Mvc + "'");
 }
 
 if (objPrjFeatureEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.RegionTypeId);
 var strRegionTypeId = objPrjFeatureEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeId + "'");
 }
 
 if (objPrjFeatureEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.GroupName);
 var strGroupName = objPrjFeatureEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objPrjFeatureEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureDescription);
 var strFeatureDescription = objPrjFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objPrjFeatureEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.InOutTypeId);
 var strInOutTypeId = objPrjFeatureEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFeature.IsNeedField);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.IsNeedField  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjFeature.IsNeedTabFeature);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.IsNeedTabFeature  ==  false ? "0" : "1") + "'");
 
 if (objPrjFeatureEN.ParentFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.ParentFeatureId);
 var strParentFeatureId = objPrjFeatureEN.ParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureId + "'");
 }
 
 if (objPrjFeatureEN.ParentFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.ParentFeatureName);
 var strParentFeatureName = objPrjFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureName + "'");
 }
 
 if (objPrjFeatureEN.FunctionGroupId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FunctionGroupId);
 var strFunctionGroupId = objPrjFeatureEN.FunctionGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionGroupId + "'");
 }
 
 if (objPrjFeatureEN.FeatureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureTypeId);
 var strFeatureTypeId = objPrjFeatureEN.FeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureTypeId + "'");
 }
 
 if (objPrjFeatureEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.CreateUserId);
 var strCreateUserId = objPrjFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFeature.InUse);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjFeature.OrderNum);
 arrValueListForInsert.Add(objPrjFeatureEN.OrderNum.ToString());
 
 if (objPrjFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.UpdDate);
 var strUpdDate = objPrjFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.UpdUser);
 var strUpdUser = objPrjFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.Memo);
 var strMemo = objPrjFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFeature");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPrjFeatureEN.FeatureId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjFeatureEN objPrjFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFeatureEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFeatureEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureId);
 var strFeatureId = objPrjFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objPrjFeatureEN.FeatureName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureName);
 var strFeatureName = objPrjFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureName + "'");
 }
 
 if (objPrjFeatureEN.FeatureENName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureENName);
 var strFeatureENName = objPrjFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureENName + "'");
 }
 
 if (objPrjFeatureEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.KeyWords);
 var strKeyWords = objPrjFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objPrjFeatureEN.DefaButtonName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.DefaButtonName);
 var strDefaButtonName = objPrjFeatureEN.DefaButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaButtonName + "'");
 }
 
 if (objPrjFeatureEN.DefaButtonName4Mvc !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.DefaButtonName4Mvc);
 var strDefaButtonName4Mvc = objPrjFeatureEN.DefaButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaButtonName4Mvc + "'");
 }
 
 if (objPrjFeatureEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.RegionTypeId);
 var strRegionTypeId = objPrjFeatureEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeId + "'");
 }
 
 if (objPrjFeatureEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.GroupName);
 var strGroupName = objPrjFeatureEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objPrjFeatureEN.FeatureDescription !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureDescription);
 var strFeatureDescription = objPrjFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureDescription + "'");
 }
 
 if (objPrjFeatureEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.InOutTypeId);
 var strInOutTypeId = objPrjFeatureEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFeature.IsNeedField);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.IsNeedField  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjFeature.IsNeedTabFeature);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.IsNeedTabFeature  ==  false ? "0" : "1") + "'");
 
 if (objPrjFeatureEN.ParentFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.ParentFeatureId);
 var strParentFeatureId = objPrjFeatureEN.ParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureId + "'");
 }
 
 if (objPrjFeatureEN.ParentFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.ParentFeatureName);
 var strParentFeatureName = objPrjFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentFeatureName + "'");
 }
 
 if (objPrjFeatureEN.FunctionGroupId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FunctionGroupId);
 var strFunctionGroupId = objPrjFeatureEN.FunctionGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionGroupId + "'");
 }
 
 if (objPrjFeatureEN.FeatureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.FeatureTypeId);
 var strFeatureTypeId = objPrjFeatureEN.FeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureTypeId + "'");
 }
 
 if (objPrjFeatureEN.CreateUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.CreateUserId);
 var strCreateUserId = objPrjFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFeature.InUse);
 arrValueListForInsert.Add("'" + (objPrjFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjFeature.OrderNum);
 arrValueListForInsert.Add(objPrjFeatureEN.OrderNum.ToString());
 
 if (objPrjFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.UpdDate);
 var strUpdDate = objPrjFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.UpdUser);
 var strUpdUser = objPrjFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFeature.Memo);
 var strMemo = objPrjFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFeature");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjFeatures(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where FeatureId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjFeature");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFeatureId = oRow[conPrjFeature.FeatureId].ToString().Trim();
if (IsExist(strFeatureId))
{
 string strResult = "关键字变量值为:" + string.Format("FeatureId = {0}", strFeatureId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjFeatureEN._CurrTabName ].NewRow();
objRow[conPrjFeature.FeatureId] = oRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objRow[conPrjFeature.FeatureName] = oRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objRow[conPrjFeature.FeatureENName] = oRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objRow[conPrjFeature.KeyWords] = oRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objRow[conPrjFeature.DefaButtonName] = oRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objRow[conPrjFeature.DefaButtonName4Mvc] = oRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objRow[conPrjFeature.RegionTypeId] = oRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objRow[conPrjFeature.GroupName] = oRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objRow[conPrjFeature.FeatureDescription] = oRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objRow[conPrjFeature.InOutTypeId] = oRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objRow[conPrjFeature.IsNeedField] = oRow[conPrjFeature.IsNeedField].ToString().Trim(); //是否需要字段
objRow[conPrjFeature.IsNeedTabFeature] = oRow[conPrjFeature.IsNeedTabFeature].ToString().Trim(); //是否需要表功能
objRow[conPrjFeature.ParentFeatureId] = oRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objRow[conPrjFeature.ParentFeatureName] = oRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objRow[conPrjFeature.FunctionGroupId] = oRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objRow[conPrjFeature.FeatureTypeId] = oRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objRow[conPrjFeature.CreateUserId] = oRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objRow[conPrjFeature.InUse] = oRow[conPrjFeature.InUse].ToString().Trim(); //是否在用
objRow[conPrjFeature.OrderNum] = oRow[conPrjFeature.OrderNum].ToString().Trim(); //序号
objRow[conPrjFeature.UpdDate] = oRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objRow[conPrjFeature.UpdUser] = oRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objRow[conPrjFeature.Memo] = oRow[conPrjFeature.Memo].ToString().Trim(); //说明
 objDS.Tables[clsPrjFeatureEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjFeatureEN._CurrTabName);
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
 /// <param name = "objPrjFeatureEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjFeatureEN objPrjFeatureEN)
{
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFeatureEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from PrjFeature where FeatureId = " + "'"+ objPrjFeatureEN.FeatureId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjFeatureEN._CurrTabName);
if (objDS.Tables[clsPrjFeatureEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FeatureId = " + "'"+ objPrjFeatureEN.FeatureId+"'");
return false;
}
objRow = objDS.Tables[clsPrjFeatureEN._CurrTabName].Rows[0];
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureId))
 {
objRow[conPrjFeature.FeatureId] = objPrjFeatureEN.FeatureId; //功能Id
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureName))
 {
objRow[conPrjFeature.FeatureName] = objPrjFeatureEN.FeatureName; //功能名称
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureENName))
 {
objRow[conPrjFeature.FeatureENName] = objPrjFeatureEN.FeatureENName; //功能英文名
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.KeyWords))
 {
objRow[conPrjFeature.KeyWords] = objPrjFeatureEN.KeyWords; //关键字
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName))
 {
objRow[conPrjFeature.DefaButtonName] = objPrjFeatureEN.DefaButtonName; //默认按钮名
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName4Mvc))
 {
objRow[conPrjFeature.DefaButtonName4Mvc] = objPrjFeatureEN.DefaButtonName4Mvc; //默认按钮名4Mvc
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.RegionTypeId))
 {
objRow[conPrjFeature.RegionTypeId] = objPrjFeatureEN.RegionTypeId; //区域类型Id
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.GroupName))
 {
objRow[conPrjFeature.GroupName] = objPrjFeatureEN.GroupName; //组名
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureDescription))
 {
objRow[conPrjFeature.FeatureDescription] = objPrjFeatureEN.FeatureDescription; //功能说明
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InOutTypeId))
 {
objRow[conPrjFeature.InOutTypeId] = objPrjFeatureEN.InOutTypeId; //INOUT类型ID
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedField))
 {
objRow[conPrjFeature.IsNeedField] = objPrjFeatureEN.IsNeedField; //是否需要字段
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedTabFeature))
 {
objRow[conPrjFeature.IsNeedTabFeature] = objPrjFeatureEN.IsNeedTabFeature; //是否需要表功能
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureId))
 {
objRow[conPrjFeature.ParentFeatureId] = objPrjFeatureEN.ParentFeatureId; //父功能Id
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureName))
 {
objRow[conPrjFeature.ParentFeatureName] = objPrjFeatureEN.ParentFeatureName; //父功能名
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FunctionGroupId))
 {
objRow[conPrjFeature.FunctionGroupId] = objPrjFeatureEN.FunctionGroupId; //函数组Id
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureTypeId))
 {
objRow[conPrjFeature.FeatureTypeId] = objPrjFeatureEN.FeatureTypeId; //功能类型Id
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.CreateUserId))
 {
objRow[conPrjFeature.CreateUserId] = objPrjFeatureEN.CreateUserId; //建立用户Id
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InUse))
 {
objRow[conPrjFeature.InUse] = objPrjFeatureEN.InUse; //是否在用
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.OrderNum))
 {
objRow[conPrjFeature.OrderNum] = objPrjFeatureEN.OrderNum; //序号
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdDate))
 {
objRow[conPrjFeature.UpdDate] = objPrjFeatureEN.UpdDate; //修改日期
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdUser))
 {
objRow[conPrjFeature.UpdUser] = objPrjFeatureEN.UpdUser; //修改者
 }
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.Memo))
 {
objRow[conPrjFeature.Memo] = objPrjFeatureEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsPrjFeatureEN._CurrTabName);
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjFeatureEN objPrjFeatureEN)
{
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjFeature Set ");
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureName))
 {
 if (objPrjFeatureEN.FeatureName !=  null)
 {
 var strFeatureName = objPrjFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureName, conPrjFeature.FeatureName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FeatureName); //功能名称
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureENName))
 {
 if (objPrjFeatureEN.FeatureENName !=  null)
 {
 var strFeatureENName = objPrjFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureENName, conPrjFeature.FeatureENName); //功能英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FeatureENName); //功能英文名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.KeyWords))
 {
 if (objPrjFeatureEN.KeyWords !=  null)
 {
 var strKeyWords = objPrjFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyWords, conPrjFeature.KeyWords); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.KeyWords); //关键字
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName))
 {
 if (objPrjFeatureEN.DefaButtonName !=  null)
 {
 var strDefaButtonName = objPrjFeatureEN.DefaButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaButtonName, conPrjFeature.DefaButtonName); //默认按钮名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.DefaButtonName); //默认按钮名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName4Mvc))
 {
 if (objPrjFeatureEN.DefaButtonName4Mvc !=  null)
 {
 var strDefaButtonName4Mvc = objPrjFeatureEN.DefaButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaButtonName4Mvc, conPrjFeature.DefaButtonName4Mvc); //默认按钮名4Mvc
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.DefaButtonName4Mvc); //默认按钮名4Mvc
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.RegionTypeId))
 {
 if (objPrjFeatureEN.RegionTypeId !=  null)
 {
 var strRegionTypeId = objPrjFeatureEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionTypeId, conPrjFeature.RegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.RegionTypeId); //区域类型Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.GroupName))
 {
 if (objPrjFeatureEN.GroupName !=  null)
 {
 var strGroupName = objPrjFeatureEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupName, conPrjFeature.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.GroupName); //组名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureDescription))
 {
 if (objPrjFeatureEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objPrjFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureDescription, conPrjFeature.FeatureDescription); //功能说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FeatureDescription); //功能说明
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InOutTypeId))
 {
 if (objPrjFeatureEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objPrjFeatureEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conPrjFeature.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedField))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFeatureEN.IsNeedField == true?"1":"0", conPrjFeature.IsNeedField); //是否需要字段
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedTabFeature))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFeatureEN.IsNeedTabFeature == true?"1":"0", conPrjFeature.IsNeedTabFeature); //是否需要表功能
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureId))
 {
 if (objPrjFeatureEN.ParentFeatureId !=  null)
 {
 var strParentFeatureId = objPrjFeatureEN.ParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentFeatureId, conPrjFeature.ParentFeatureId); //父功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.ParentFeatureId); //父功能Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureName))
 {
 if (objPrjFeatureEN.ParentFeatureName !=  null)
 {
 var strParentFeatureName = objPrjFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentFeatureName, conPrjFeature.ParentFeatureName); //父功能名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.ParentFeatureName); //父功能名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FunctionGroupId))
 {
 if (objPrjFeatureEN.FunctionGroupId !=  null)
 {
 var strFunctionGroupId = objPrjFeatureEN.FunctionGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionGroupId, conPrjFeature.FunctionGroupId); //函数组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FunctionGroupId); //函数组Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureTypeId))
 {
 if (objPrjFeatureEN.FeatureTypeId !=  null)
 {
 var strFeatureTypeId = objPrjFeatureEN.FeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureTypeId, conPrjFeature.FeatureTypeId); //功能类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FeatureTypeId); //功能类型Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.CreateUserId))
 {
 if (objPrjFeatureEN.CreateUserId !=  null)
 {
 var strCreateUserId = objPrjFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserId, conPrjFeature.CreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.CreateUserId); //建立用户Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFeatureEN.InUse == true?"1":"0", conPrjFeature.InUse); //是否在用
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjFeatureEN.OrderNum, conPrjFeature.OrderNum); //序号
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdDate))
 {
 if (objPrjFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjFeature.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.UpdDate); //修改日期
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdUser))
 {
 if (objPrjFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPrjFeature.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.UpdUser); //修改者
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.Memo))
 {
 if (objPrjFeatureEN.Memo !=  null)
 {
 var strMemo = objPrjFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjFeature.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FeatureId = '{0}'", objPrjFeatureEN.FeatureId); 
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
 /// <param name = "objPrjFeatureEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjFeatureEN objPrjFeatureEN, string strCondition)
{
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFeature Set ");
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureName))
 {
 if (objPrjFeatureEN.FeatureName !=  null)
 {
 var strFeatureName = objPrjFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureName = '{0}',", strFeatureName); //功能名称
 }
 else
 {
 sbSQL.Append(" FeatureName = null,"); //功能名称
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureENName))
 {
 if (objPrjFeatureEN.FeatureENName !=  null)
 {
 var strFeatureENName = objPrjFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureENName = '{0}',", strFeatureENName); //功能英文名
 }
 else
 {
 sbSQL.Append(" FeatureENName = null,"); //功能英文名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.KeyWords))
 {
 if (objPrjFeatureEN.KeyWords !=  null)
 {
 var strKeyWords = objPrjFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyWords = '{0}',", strKeyWords); //关键字
 }
 else
 {
 sbSQL.Append(" KeyWords = null,"); //关键字
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName))
 {
 if (objPrjFeatureEN.DefaButtonName !=  null)
 {
 var strDefaButtonName = objPrjFeatureEN.DefaButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaButtonName = '{0}',", strDefaButtonName); //默认按钮名
 }
 else
 {
 sbSQL.Append(" DefaButtonName = null,"); //默认按钮名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName4Mvc))
 {
 if (objPrjFeatureEN.DefaButtonName4Mvc !=  null)
 {
 var strDefaButtonName4Mvc = objPrjFeatureEN.DefaButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaButtonName4Mvc = '{0}',", strDefaButtonName4Mvc); //默认按钮名4Mvc
 }
 else
 {
 sbSQL.Append(" DefaButtonName4Mvc = null,"); //默认按钮名4Mvc
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.RegionTypeId))
 {
 if (objPrjFeatureEN.RegionTypeId !=  null)
 {
 var strRegionTypeId = objPrjFeatureEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionTypeId = '{0}',", strRegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.Append(" RegionTypeId = null,"); //区域类型Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.GroupName))
 {
 if (objPrjFeatureEN.GroupName !=  null)
 {
 var strGroupName = objPrjFeatureEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", strGroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureDescription))
 {
 if (objPrjFeatureEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objPrjFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureDescription = '{0}',", strFeatureDescription); //功能说明
 }
 else
 {
 sbSQL.Append(" FeatureDescription = null,"); //功能说明
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InOutTypeId))
 {
 if (objPrjFeatureEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objPrjFeatureEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedField))
 {
 sbSQL.AppendFormat(" IsNeedField = '{0}',", objPrjFeatureEN.IsNeedField == true?"1":"0"); //是否需要字段
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedTabFeature))
 {
 sbSQL.AppendFormat(" IsNeedTabFeature = '{0}',", objPrjFeatureEN.IsNeedTabFeature == true?"1":"0"); //是否需要表功能
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureId))
 {
 if (objPrjFeatureEN.ParentFeatureId !=  null)
 {
 var strParentFeatureId = objPrjFeatureEN.ParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentFeatureId = '{0}',", strParentFeatureId); //父功能Id
 }
 else
 {
 sbSQL.Append(" ParentFeatureId = null,"); //父功能Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureName))
 {
 if (objPrjFeatureEN.ParentFeatureName !=  null)
 {
 var strParentFeatureName = objPrjFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentFeatureName = '{0}',", strParentFeatureName); //父功能名
 }
 else
 {
 sbSQL.Append(" ParentFeatureName = null,"); //父功能名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FunctionGroupId))
 {
 if (objPrjFeatureEN.FunctionGroupId !=  null)
 {
 var strFunctionGroupId = objPrjFeatureEN.FunctionGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionGroupId = '{0}',", strFunctionGroupId); //函数组Id
 }
 else
 {
 sbSQL.Append(" FunctionGroupId = null,"); //函数组Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureTypeId))
 {
 if (objPrjFeatureEN.FeatureTypeId !=  null)
 {
 var strFeatureTypeId = objPrjFeatureEN.FeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureTypeId = '{0}',", strFeatureTypeId); //功能类型Id
 }
 else
 {
 sbSQL.Append(" FeatureTypeId = null,"); //功能类型Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.CreateUserId))
 {
 if (objPrjFeatureEN.CreateUserId !=  null)
 {
 var strCreateUserId = objPrjFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserId = '{0}',", strCreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.Append(" CreateUserId = null,"); //建立用户Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objPrjFeatureEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objPrjFeatureEN.OrderNum); //序号
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdDate))
 {
 if (objPrjFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdUser))
 {
 if (objPrjFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.Memo))
 {
 if (objPrjFeatureEN.Memo !=  null)
 {
 var strMemo = objPrjFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjFeatureEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjFeatureEN objPrjFeatureEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFeature Set ");
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureName))
 {
 if (objPrjFeatureEN.FeatureName !=  null)
 {
 var strFeatureName = objPrjFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureName = '{0}',", strFeatureName); //功能名称
 }
 else
 {
 sbSQL.Append(" FeatureName = null,"); //功能名称
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureENName))
 {
 if (objPrjFeatureEN.FeatureENName !=  null)
 {
 var strFeatureENName = objPrjFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureENName = '{0}',", strFeatureENName); //功能英文名
 }
 else
 {
 sbSQL.Append(" FeatureENName = null,"); //功能英文名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.KeyWords))
 {
 if (objPrjFeatureEN.KeyWords !=  null)
 {
 var strKeyWords = objPrjFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyWords = '{0}',", strKeyWords); //关键字
 }
 else
 {
 sbSQL.Append(" KeyWords = null,"); //关键字
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName))
 {
 if (objPrjFeatureEN.DefaButtonName !=  null)
 {
 var strDefaButtonName = objPrjFeatureEN.DefaButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaButtonName = '{0}',", strDefaButtonName); //默认按钮名
 }
 else
 {
 sbSQL.Append(" DefaButtonName = null,"); //默认按钮名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName4Mvc))
 {
 if (objPrjFeatureEN.DefaButtonName4Mvc !=  null)
 {
 var strDefaButtonName4Mvc = objPrjFeatureEN.DefaButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaButtonName4Mvc = '{0}',", strDefaButtonName4Mvc); //默认按钮名4Mvc
 }
 else
 {
 sbSQL.Append(" DefaButtonName4Mvc = null,"); //默认按钮名4Mvc
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.RegionTypeId))
 {
 if (objPrjFeatureEN.RegionTypeId !=  null)
 {
 var strRegionTypeId = objPrjFeatureEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionTypeId = '{0}',", strRegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.Append(" RegionTypeId = null,"); //区域类型Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.GroupName))
 {
 if (objPrjFeatureEN.GroupName !=  null)
 {
 var strGroupName = objPrjFeatureEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", strGroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureDescription))
 {
 if (objPrjFeatureEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objPrjFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureDescription = '{0}',", strFeatureDescription); //功能说明
 }
 else
 {
 sbSQL.Append(" FeatureDescription = null,"); //功能说明
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InOutTypeId))
 {
 if (objPrjFeatureEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objPrjFeatureEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedField))
 {
 sbSQL.AppendFormat(" IsNeedField = '{0}',", objPrjFeatureEN.IsNeedField == true?"1":"0"); //是否需要字段
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedTabFeature))
 {
 sbSQL.AppendFormat(" IsNeedTabFeature = '{0}',", objPrjFeatureEN.IsNeedTabFeature == true?"1":"0"); //是否需要表功能
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureId))
 {
 if (objPrjFeatureEN.ParentFeatureId !=  null)
 {
 var strParentFeatureId = objPrjFeatureEN.ParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentFeatureId = '{0}',", strParentFeatureId); //父功能Id
 }
 else
 {
 sbSQL.Append(" ParentFeatureId = null,"); //父功能Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureName))
 {
 if (objPrjFeatureEN.ParentFeatureName !=  null)
 {
 var strParentFeatureName = objPrjFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentFeatureName = '{0}',", strParentFeatureName); //父功能名
 }
 else
 {
 sbSQL.Append(" ParentFeatureName = null,"); //父功能名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FunctionGroupId))
 {
 if (objPrjFeatureEN.FunctionGroupId !=  null)
 {
 var strFunctionGroupId = objPrjFeatureEN.FunctionGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionGroupId = '{0}',", strFunctionGroupId); //函数组Id
 }
 else
 {
 sbSQL.Append(" FunctionGroupId = null,"); //函数组Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureTypeId))
 {
 if (objPrjFeatureEN.FeatureTypeId !=  null)
 {
 var strFeatureTypeId = objPrjFeatureEN.FeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureTypeId = '{0}',", strFeatureTypeId); //功能类型Id
 }
 else
 {
 sbSQL.Append(" FeatureTypeId = null,"); //功能类型Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.CreateUserId))
 {
 if (objPrjFeatureEN.CreateUserId !=  null)
 {
 var strCreateUserId = objPrjFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserId = '{0}',", strCreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.Append(" CreateUserId = null,"); //建立用户Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objPrjFeatureEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objPrjFeatureEN.OrderNum); //序号
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdDate))
 {
 if (objPrjFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdUser))
 {
 if (objPrjFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.Memo))
 {
 if (objPrjFeatureEN.Memo !=  null)
 {
 var strMemo = objPrjFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjFeatureEN objPrjFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFeature Set ");
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureName))
 {
 if (objPrjFeatureEN.FeatureName !=  null)
 {
 var strFeatureName = objPrjFeatureEN.FeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureName, conPrjFeature.FeatureName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FeatureName); //功能名称
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureENName))
 {
 if (objPrjFeatureEN.FeatureENName !=  null)
 {
 var strFeatureENName = objPrjFeatureEN.FeatureENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureENName, conPrjFeature.FeatureENName); //功能英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FeatureENName); //功能英文名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.KeyWords))
 {
 if (objPrjFeatureEN.KeyWords !=  null)
 {
 var strKeyWords = objPrjFeatureEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyWords, conPrjFeature.KeyWords); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.KeyWords); //关键字
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName))
 {
 if (objPrjFeatureEN.DefaButtonName !=  null)
 {
 var strDefaButtonName = objPrjFeatureEN.DefaButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaButtonName, conPrjFeature.DefaButtonName); //默认按钮名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.DefaButtonName); //默认按钮名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.DefaButtonName4Mvc))
 {
 if (objPrjFeatureEN.DefaButtonName4Mvc !=  null)
 {
 var strDefaButtonName4Mvc = objPrjFeatureEN.DefaButtonName4Mvc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaButtonName4Mvc, conPrjFeature.DefaButtonName4Mvc); //默认按钮名4Mvc
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.DefaButtonName4Mvc); //默认按钮名4Mvc
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.RegionTypeId))
 {
 if (objPrjFeatureEN.RegionTypeId !=  null)
 {
 var strRegionTypeId = objPrjFeatureEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionTypeId, conPrjFeature.RegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.RegionTypeId); //区域类型Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.GroupName))
 {
 if (objPrjFeatureEN.GroupName !=  null)
 {
 var strGroupName = objPrjFeatureEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupName, conPrjFeature.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.GroupName); //组名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureDescription))
 {
 if (objPrjFeatureEN.FeatureDescription !=  null)
 {
 var strFeatureDescription = objPrjFeatureEN.FeatureDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureDescription, conPrjFeature.FeatureDescription); //功能说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FeatureDescription); //功能说明
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InOutTypeId))
 {
 if (objPrjFeatureEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objPrjFeatureEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conPrjFeature.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedField))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFeatureEN.IsNeedField == true?"1":"0", conPrjFeature.IsNeedField); //是否需要字段
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.IsNeedTabFeature))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFeatureEN.IsNeedTabFeature == true?"1":"0", conPrjFeature.IsNeedTabFeature); //是否需要表功能
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureId))
 {
 if (objPrjFeatureEN.ParentFeatureId !=  null)
 {
 var strParentFeatureId = objPrjFeatureEN.ParentFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentFeatureId, conPrjFeature.ParentFeatureId); //父功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.ParentFeatureId); //父功能Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.ParentFeatureName))
 {
 if (objPrjFeatureEN.ParentFeatureName !=  null)
 {
 var strParentFeatureName = objPrjFeatureEN.ParentFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentFeatureName, conPrjFeature.ParentFeatureName); //父功能名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.ParentFeatureName); //父功能名
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FunctionGroupId))
 {
 if (objPrjFeatureEN.FunctionGroupId !=  null)
 {
 var strFunctionGroupId = objPrjFeatureEN.FunctionGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionGroupId, conPrjFeature.FunctionGroupId); //函数组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FunctionGroupId); //函数组Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.FeatureTypeId))
 {
 if (objPrjFeatureEN.FeatureTypeId !=  null)
 {
 var strFeatureTypeId = objPrjFeatureEN.FeatureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureTypeId, conPrjFeature.FeatureTypeId); //功能类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.FeatureTypeId); //功能类型Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.CreateUserId))
 {
 if (objPrjFeatureEN.CreateUserId !=  null)
 {
 var strCreateUserId = objPrjFeatureEN.CreateUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserId, conPrjFeature.CreateUserId); //建立用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.CreateUserId); //建立用户Id
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFeatureEN.InUse == true?"1":"0", conPrjFeature.InUse); //是否在用
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjFeatureEN.OrderNum, conPrjFeature.OrderNum); //序号
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdDate))
 {
 if (objPrjFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjFeature.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.UpdDate); //修改日期
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.UpdUser))
 {
 if (objPrjFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPrjFeature.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.UpdUser); //修改者
 }
 }
 
 if (objPrjFeatureEN.IsUpdated(conPrjFeature.Memo))
 {
 if (objPrjFeatureEN.Memo !=  null)
 {
 var strMemo = objPrjFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjFeature.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFeature.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FeatureId = '{0}'", objPrjFeatureEN.FeatureId); 
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
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFeatureId) 
{
CheckPrimaryKey(strFeatureId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFeatureId,
};
 objSQL.ExecSP("PrjFeature_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFeatureId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFeatureId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
//删除PrjFeature本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFeature where FeatureId = " + "'"+ strFeatureId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjFeature(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
//删除PrjFeature本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFeature where FeatureId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFeatureId) 
{
CheckPrimaryKey(strFeatureId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
//删除PrjFeature本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFeature where FeatureId = " + "'"+ strFeatureId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjFeature(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjFeatureDA: DelPrjFeature)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjFeature where " + strCondition ;
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
public bool DelPrjFeatureWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjFeatureDA: DelPrjFeatureWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjFeature where " + strCondition ;
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
 /// <param name = "objPrjFeatureENS">源对象</param>
 /// <param name = "objPrjFeatureENT">目标对象</param>
public void CopyTo(clsPrjFeatureEN objPrjFeatureENS, clsPrjFeatureEN objPrjFeatureENT)
{
objPrjFeatureENT.FeatureId = objPrjFeatureENS.FeatureId; //功能Id
objPrjFeatureENT.FeatureName = objPrjFeatureENS.FeatureName; //功能名称
objPrjFeatureENT.FeatureENName = objPrjFeatureENS.FeatureENName; //功能英文名
objPrjFeatureENT.KeyWords = objPrjFeatureENS.KeyWords; //关键字
objPrjFeatureENT.DefaButtonName = objPrjFeatureENS.DefaButtonName; //默认按钮名
objPrjFeatureENT.DefaButtonName4Mvc = objPrjFeatureENS.DefaButtonName4Mvc; //默认按钮名4Mvc
objPrjFeatureENT.RegionTypeId = objPrjFeatureENS.RegionTypeId; //区域类型Id
objPrjFeatureENT.GroupName = objPrjFeatureENS.GroupName; //组名
objPrjFeatureENT.FeatureDescription = objPrjFeatureENS.FeatureDescription; //功能说明
objPrjFeatureENT.InOutTypeId = objPrjFeatureENS.InOutTypeId; //INOUT类型ID
objPrjFeatureENT.IsNeedField = objPrjFeatureENS.IsNeedField; //是否需要字段
objPrjFeatureENT.IsNeedTabFeature = objPrjFeatureENS.IsNeedTabFeature; //是否需要表功能
objPrjFeatureENT.ParentFeatureId = objPrjFeatureENS.ParentFeatureId; //父功能Id
objPrjFeatureENT.ParentFeatureName = objPrjFeatureENS.ParentFeatureName; //父功能名
objPrjFeatureENT.FunctionGroupId = objPrjFeatureENS.FunctionGroupId; //函数组Id
objPrjFeatureENT.FeatureTypeId = objPrjFeatureENS.FeatureTypeId; //功能类型Id
objPrjFeatureENT.CreateUserId = objPrjFeatureENS.CreateUserId; //建立用户Id
objPrjFeatureENT.InUse = objPrjFeatureENS.InUse; //是否在用
objPrjFeatureENT.OrderNum = objPrjFeatureENS.OrderNum; //序号
objPrjFeatureENT.UpdDate = objPrjFeatureENS.UpdDate; //修改日期
objPrjFeatureENT.UpdUser = objPrjFeatureENS.UpdUser; //修改者
objPrjFeatureENT.Memo = objPrjFeatureENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjFeatureEN objPrjFeatureEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjFeatureEN.FeatureName, conPrjFeature.FeatureName);
clsCheckSql.CheckFieldNotNull(objPrjFeatureEN.InOutTypeId, conPrjFeature.InOutTypeId);
clsCheckSql.CheckFieldNotNull(objPrjFeatureEN.FunctionGroupId, conPrjFeature.FunctionGroupId);
clsCheckSql.CheckFieldNotNull(objPrjFeatureEN.FeatureTypeId, conPrjFeature.FeatureTypeId);
clsCheckSql.CheckFieldNotNull(objPrjFeatureEN.CreateUserId, conPrjFeature.CreateUserId);
clsCheckSql.CheckFieldNotNull(objPrjFeatureEN.OrderNum, conPrjFeature.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureId, 4, conPrjFeature.FeatureId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureName, 100, conPrjFeature.FeatureName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureENName, 100, conPrjFeature.FeatureENName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.KeyWords, 500, conPrjFeature.KeyWords);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.DefaButtonName, 30, conPrjFeature.DefaButtonName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.DefaButtonName4Mvc, 30, conPrjFeature.DefaButtonName4Mvc);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.RegionTypeId, 4, conPrjFeature.RegionTypeId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.GroupName, 30, conPrjFeature.GroupName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureDescription, 4000, conPrjFeature.FeatureDescription);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.InOutTypeId, 2, conPrjFeature.InOutTypeId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.ParentFeatureId, 4, conPrjFeature.ParentFeatureId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.ParentFeatureName, 500, conPrjFeature.ParentFeatureName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FunctionGroupId, 4, conPrjFeature.FunctionGroupId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureTypeId, 2, conPrjFeature.FeatureTypeId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.CreateUserId, 18, conPrjFeature.CreateUserId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.UpdDate, 20, conPrjFeature.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.UpdUser, 20, conPrjFeature.UpdUser);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.Memo, 1000, conPrjFeature.Memo);
//检查字段外键固定长度
 objPrjFeatureEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjFeatureEN objPrjFeatureEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureName, 100, conPrjFeature.FeatureName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureENName, 100, conPrjFeature.FeatureENName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.KeyWords, 500, conPrjFeature.KeyWords);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.DefaButtonName, 30, conPrjFeature.DefaButtonName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.DefaButtonName4Mvc, 30, conPrjFeature.DefaButtonName4Mvc);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.RegionTypeId, 4, conPrjFeature.RegionTypeId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.GroupName, 30, conPrjFeature.GroupName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureDescription, 4000, conPrjFeature.FeatureDescription);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.InOutTypeId, 2, conPrjFeature.InOutTypeId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.ParentFeatureId, 4, conPrjFeature.ParentFeatureId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.ParentFeatureName, 500, conPrjFeature.ParentFeatureName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FunctionGroupId, 4, conPrjFeature.FunctionGroupId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureTypeId, 2, conPrjFeature.FeatureTypeId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.CreateUserId, 18, conPrjFeature.CreateUserId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.UpdDate, 20, conPrjFeature.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.UpdUser, 20, conPrjFeature.UpdUser);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.Memo, 1000, conPrjFeature.Memo);
//检查外键字段长度
 objPrjFeatureEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjFeatureEN objPrjFeatureEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureId, 4, conPrjFeature.FeatureId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureName, 100, conPrjFeature.FeatureName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureENName, 100, conPrjFeature.FeatureENName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.KeyWords, 500, conPrjFeature.KeyWords);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.DefaButtonName, 30, conPrjFeature.DefaButtonName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.DefaButtonName4Mvc, 30, conPrjFeature.DefaButtonName4Mvc);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.RegionTypeId, 4, conPrjFeature.RegionTypeId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.GroupName, 30, conPrjFeature.GroupName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureDescription, 4000, conPrjFeature.FeatureDescription);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.InOutTypeId, 2, conPrjFeature.InOutTypeId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.ParentFeatureId, 4, conPrjFeature.ParentFeatureId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.ParentFeatureName, 500, conPrjFeature.ParentFeatureName);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FunctionGroupId, 4, conPrjFeature.FunctionGroupId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.FeatureTypeId, 2, conPrjFeature.FeatureTypeId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.CreateUserId, 18, conPrjFeature.CreateUserId);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.UpdDate, 20, conPrjFeature.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.UpdUser, 20, conPrjFeature.UpdUser);
clsCheckSql.CheckFieldLen(objPrjFeatureEN.Memo, 1000, conPrjFeature.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.FeatureId, conPrjFeature.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.FeatureName, conPrjFeature.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.FeatureENName, conPrjFeature.FeatureENName);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.KeyWords, conPrjFeature.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.DefaButtonName, conPrjFeature.DefaButtonName);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.DefaButtonName4Mvc, conPrjFeature.DefaButtonName4Mvc);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.RegionTypeId, conPrjFeature.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.GroupName, conPrjFeature.GroupName);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.FeatureDescription, conPrjFeature.FeatureDescription);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.InOutTypeId, conPrjFeature.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.ParentFeatureId, conPrjFeature.ParentFeatureId);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.ParentFeatureName, conPrjFeature.ParentFeatureName);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.FunctionGroupId, conPrjFeature.FunctionGroupId);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.FeatureTypeId, conPrjFeature.FeatureTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.CreateUserId, conPrjFeature.CreateUserId);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.UpdDate, conPrjFeature.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.UpdUser, conPrjFeature.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objPrjFeatureEN.Memo, conPrjFeature.Memo);
//检查外键字段长度
 objPrjFeatureEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFeatureId()
{
//获取某学院所有专业信息
string strSQL = "select FeatureId, FeatureName from PrjFeature ";
 clsSpecSQLforSql mySql = clsPrjFeatureDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PrjFeature(功能),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjFeatureEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPrjFeatureEN objPrjFeatureEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objPrjFeatureEN.FeatureName);
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
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjFeatureEN._CurrTabName);
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
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjFeatureEN._CurrTabName, strCondition);
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
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
 objSQL = clsPrjFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}