
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFeatureDA
 表名:vPrjFeature(00050324)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:50
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
 /// v功能(vPrjFeature)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjFeatureDA : clsCommBase4DA
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
 return clsvPrjFeatureEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjFeatureEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjFeatureEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjFeatureEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjFeatureEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vPrjFeature中,检查关键字,长度不正确!(clsvPrjFeatureDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjFeature中,关键字不能为空 或 null!(clsvPrjFeatureDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjFeatureDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjFeature(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTable_vPrjFeature)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjFeature where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjFeature where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjFeature where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjFeature.* " + 
$"from vPrjFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjFeature.FeatureId not in " + 
$"(Select top {intTop_In} vPrjFeature.FeatureId from vPrjFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjFeature where {1} and FeatureId not in (Select top {2} FeatureId from vPrjFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjFeature where {1} and FeatureId not in (Select top {3} FeatureId from vPrjFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjFeature.* " + 
$"from vPrjFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjFeature.FeatureId not in " + 
$"(Select top {intTop_In} vPrjFeature.FeatureId from vPrjFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjFeature where {1} and FeatureId not in (Select top {2} FeatureId from vPrjFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjFeature where {1} and FeatureId not in (Select top {3} FeatureId from vPrjFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjFeatureEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjFeatureDA:GetObjLst)", objException.Message));
}
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = TransNullToBool(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = TransNullToBool(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = TransNullToInt(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjFeatureDA: GetObjLst)", objException.Message));
}
objvPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjFeatureEN);
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
public List<clsvPrjFeatureEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjFeatureDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjFeatureEN> arrObjLst = new List<clsvPrjFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = TransNullToBool(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = TransNullToBool(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = TransNullToInt(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjFeatureDA: GetObjLst)", objException.Message));
}
objvPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjFeatureEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjFeatureEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjFeature(ref clsvPrjFeatureEN objvPrjFeatureEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFeature where FeatureId = " + "'"+ objvPrjFeatureEN.FeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjFeatureEN.FeatureId = objDT.Rows[0][convPrjFeature.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFeatureEN.FeatureName = objDT.Rows[0][convPrjFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjFeatureEN.KeyWords = objDT.Rows[0][convPrjFeature.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvPrjFeatureEN.DefaButtonName = objDT.Rows[0][convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjFeatureEN.RegionTypeId = objDT.Rows[0][convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFeatureEN.RegionTypeName = objDT.Rows[0][convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFeatureEN.GroupName = objDT.Rows[0][convPrjFeature.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFeatureEN.FeatureDescription = objDT.Rows[0][convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvPrjFeatureEN.InOutTypeId = objDT.Rows[0][convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjFeatureEN.InOutTypeName = objDT.Rows[0][convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFeatureEN.IsNeedField = TransNullToBool(objDT.Rows[0][convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjFeatureEN.FunctionGroupId = objDT.Rows[0][convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFeatureEN.FunctionGroupName = objDT.Rows[0][convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjFeatureEN.FeatureTypeId = objDT.Rows[0][convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjFeatureEN.FeatureTypeName = objDT.Rows[0][convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFeatureEN.CreateUserId = objDT.Rows[0][convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvPrjFeatureEN.InUse = TransNullToBool(objDT.Rows[0][convPrjFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjFeatureEN.OrderNum = TransNullToInt(objDT.Rows[0][convPrjFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvPrjFeatureEN.UpdDate = objDT.Rows[0][convPrjFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFeatureEN.UpdUser = objDT.Rows[0][convPrjFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFeatureEN.Memo = objDT.Rows[0][convPrjFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjFeatureEN.FuncCount = TransNullToInt(objDT.Rows[0][convPrjFeature.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
 objvPrjFeatureEN.FeatureName2 = objDT.Rows[0][convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount(字段类型:varchar,字段长度:112,是否可空:True)
 objvPrjFeatureEN.ParentFeatureId = objDT.Rows[0][convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFeatureEN.ParentFeatureName = objDT.Rows[0][convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objDT.Rows[0][convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjFeatureDA: GetvPrjFeature)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjFeatureEN GetObjByFeatureId(string strFeatureId)
{
CheckPrimaryKey(strFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFeature where FeatureId = " + "'"+ strFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
 objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjFeatureEN.OrderNum = Int32.Parse(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
 objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount(字段类型:varchar,字段长度:112,是否可空:True)
 objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjFeatureDA: GetObjByFeatureId)", objException.Message));
}
return objvPrjFeatureEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjFeatureEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN()
{
FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(), //功能名称
KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(), //关键字
DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(), //默认按钮名
RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(), //区域类型Id
RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(), //区域类型名称
GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(), //组名
FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(), //功能说明
InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(), //INOUT类型ID
InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(), //INOUT类型名称
IsNeedField = TransNullToBool(objRow[convPrjFeature.IsNeedField].ToString().Trim()), //是否需要字段
FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(), //函数组Id
FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(), //函数组名称
FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(), //功能类型Id
FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(), //功能类型名称
CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(), //建立用户Id
InUse = TransNullToBool(objRow[convPrjFeature.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[convPrjFeature.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(), //说明
FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjFeature.FuncCount].ToString().Trim()), //函数数目
FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(), //功能名-FuncCount
ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(), //父功能Id
ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(), //父功能名
IsNeedTabFeature = TransNullToBool(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()) //是否需要表功能
};
objvPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjFeatureEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjFeatureDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjFeatureEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = TransNullToBool(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = TransNullToBool(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = TransNullToInt(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjFeatureDA: GetObjByDataRowvPrjFeature)", objException.Message));
}
objvPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjFeatureEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjFeatureEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
try
{
objvPrjFeatureEN.FeatureId = objRow[convPrjFeature.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureEN.FeatureName = objRow[convPrjFeature.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureEN.KeyWords = objRow[convPrjFeature.KeyWords] == DBNull.Value ? null : objRow[convPrjFeature.KeyWords].ToString().Trim(); //关键字
objvPrjFeatureEN.DefaButtonName = objRow[convPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[convPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objvPrjFeatureEN.RegionTypeId = objRow[convPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureEN.RegionTypeName = objRow[convPrjFeature.RegionTypeName] == DBNull.Value ? null : objRow[convPrjFeature.RegionTypeName].ToString().Trim(); //区域类型名称
objvPrjFeatureEN.GroupName = objRow[convPrjFeature.GroupName] == DBNull.Value ? null : objRow[convPrjFeature.GroupName].ToString().Trim(); //组名
objvPrjFeatureEN.FeatureDescription = objRow[convPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[convPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objvPrjFeatureEN.InOutTypeId = objRow[convPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvPrjFeatureEN.InOutTypeName = objRow[convPrjFeature.InOutTypeName] == DBNull.Value ? null : objRow[convPrjFeature.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvPrjFeatureEN.IsNeedField = TransNullToBool(objRow[convPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objvPrjFeatureEN.FunctionGroupId = objRow[convPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvPrjFeatureEN.FunctionGroupName = objRow[convPrjFeature.FunctionGroupName] == DBNull.Value ? null : objRow[convPrjFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvPrjFeatureEN.FeatureTypeId = objRow[convPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureEN.FeatureTypeName = objRow[convPrjFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvPrjFeatureEN.CreateUserId = objRow[convPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjFeatureEN.InUse = TransNullToBool(objRow[convPrjFeature.InUse].ToString().Trim()); //是否在用
objvPrjFeatureEN.OrderNum = TransNullToInt(objRow[convPrjFeature.OrderNum].ToString().Trim()); //序号
objvPrjFeatureEN.UpdDate = objRow[convPrjFeature.UpdDate] == DBNull.Value ? null : objRow[convPrjFeature.UpdDate].ToString().Trim(); //修改日期
objvPrjFeatureEN.UpdUser = objRow[convPrjFeature.UpdUser] == DBNull.Value ? null : objRow[convPrjFeature.UpdUser].ToString().Trim(); //修改者
objvPrjFeatureEN.Memo = objRow[convPrjFeature.Memo] == DBNull.Value ? null : objRow[convPrjFeature.Memo].ToString().Trim(); //说明
objvPrjFeatureEN.FuncCount = objRow[convPrjFeature.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjFeature.FuncCount].ToString().Trim()); //函数数目
objvPrjFeatureEN.FeatureName2 = objRow[convPrjFeature.FeatureName2] == DBNull.Value ? null : objRow[convPrjFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvPrjFeatureEN.ParentFeatureId = objRow[convPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvPrjFeatureEN.ParentFeatureName = objRow[convPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureEN.IsNeedTabFeature = TransNullToBool(objRow[convPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjFeatureDA: GetObjByDataRow)", objException.Message));
}
objvPrjFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjFeatureEN;
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
objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjFeatureEN._CurrTabName, convPrjFeature.FeatureId, 4, "");
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
objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjFeatureEN._CurrTabName, convPrjFeature.FeatureId, 4, strPrefix);
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
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FeatureId from vPrjFeature where " + strCondition;
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
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FeatureId from vPrjFeature where " + strCondition;
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
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjFeature", "FeatureId = " + "'"+ strFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjFeatureDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjFeature", strCondition))
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
objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjFeature");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjFeatureENS">源对象</param>
 /// <param name = "objvPrjFeatureENT">目标对象</param>
public void CopyTo(clsvPrjFeatureEN objvPrjFeatureENS, clsvPrjFeatureEN objvPrjFeatureENT)
{
objvPrjFeatureENT.FeatureId = objvPrjFeatureENS.FeatureId; //功能Id
objvPrjFeatureENT.FeatureName = objvPrjFeatureENS.FeatureName; //功能名称
objvPrjFeatureENT.KeyWords = objvPrjFeatureENS.KeyWords; //关键字
objvPrjFeatureENT.DefaButtonName = objvPrjFeatureENS.DefaButtonName; //默认按钮名
objvPrjFeatureENT.RegionTypeId = objvPrjFeatureENS.RegionTypeId; //区域类型Id
objvPrjFeatureENT.RegionTypeName = objvPrjFeatureENS.RegionTypeName; //区域类型名称
objvPrjFeatureENT.GroupName = objvPrjFeatureENS.GroupName; //组名
objvPrjFeatureENT.FeatureDescription = objvPrjFeatureENS.FeatureDescription; //功能说明
objvPrjFeatureENT.InOutTypeId = objvPrjFeatureENS.InOutTypeId; //INOUT类型ID
objvPrjFeatureENT.InOutTypeName = objvPrjFeatureENS.InOutTypeName; //INOUT类型名称
objvPrjFeatureENT.IsNeedField = objvPrjFeatureENS.IsNeedField; //是否需要字段
objvPrjFeatureENT.FunctionGroupId = objvPrjFeatureENS.FunctionGroupId; //函数组Id
objvPrjFeatureENT.FunctionGroupName = objvPrjFeatureENS.FunctionGroupName; //函数组名称
objvPrjFeatureENT.FeatureTypeId = objvPrjFeatureENS.FeatureTypeId; //功能类型Id
objvPrjFeatureENT.FeatureTypeName = objvPrjFeatureENS.FeatureTypeName; //功能类型名称
objvPrjFeatureENT.CreateUserId = objvPrjFeatureENS.CreateUserId; //建立用户Id
objvPrjFeatureENT.InUse = objvPrjFeatureENS.InUse; //是否在用
objvPrjFeatureENT.OrderNum = objvPrjFeatureENS.OrderNum; //序号
objvPrjFeatureENT.UpdDate = objvPrjFeatureENS.UpdDate; //修改日期
objvPrjFeatureENT.UpdUser = objvPrjFeatureENS.UpdUser; //修改者
objvPrjFeatureENT.Memo = objvPrjFeatureENS.Memo; //说明
objvPrjFeatureENT.FuncCount = objvPrjFeatureENS.FuncCount; //函数数目
objvPrjFeatureENT.FeatureName2 = objvPrjFeatureENS.FeatureName2; //功能名-FuncCount
objvPrjFeatureENT.ParentFeatureId = objvPrjFeatureENS.ParentFeatureId; //父功能Id
objvPrjFeatureENT.ParentFeatureName = objvPrjFeatureENS.ParentFeatureName; //父功能名
objvPrjFeatureENT.IsNeedTabFeature = objvPrjFeatureENS.IsNeedTabFeature; //是否需要表功能
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjFeatureEN objvPrjFeatureEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.FeatureId, 4, convPrjFeature.FeatureId);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.FeatureName, 100, convPrjFeature.FeatureName);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.KeyWords, 500, convPrjFeature.KeyWords);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.DefaButtonName, 30, convPrjFeature.DefaButtonName);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.RegionTypeId, 4, convPrjFeature.RegionTypeId);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.RegionTypeName, 30, convPrjFeature.RegionTypeName);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.GroupName, 30, convPrjFeature.GroupName);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.FeatureDescription, 4000, convPrjFeature.FeatureDescription);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.InOutTypeId, 2, convPrjFeature.InOutTypeId);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.InOutTypeName, 30, convPrjFeature.InOutTypeName);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.FunctionGroupId, 4, convPrjFeature.FunctionGroupId);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.FunctionGroupName, 50, convPrjFeature.FunctionGroupName);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.FeatureTypeId, 2, convPrjFeature.FeatureTypeId);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.FeatureTypeName, 30, convPrjFeature.FeatureTypeName);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.CreateUserId, 18, convPrjFeature.CreateUserId);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.UpdDate, 20, convPrjFeature.UpdDate);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.UpdUser, 20, convPrjFeature.UpdUser);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.Memo, 1000, convPrjFeature.Memo);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.FeatureName2, 112, convPrjFeature.FeatureName2);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.ParentFeatureId, 4, convPrjFeature.ParentFeatureId);
clsCheckSql.CheckFieldLen(objvPrjFeatureEN.ParentFeatureName, 500, convPrjFeature.ParentFeatureName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.FeatureId, convPrjFeature.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.FeatureName, convPrjFeature.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.KeyWords, convPrjFeature.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.DefaButtonName, convPrjFeature.DefaButtonName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.RegionTypeId, convPrjFeature.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.RegionTypeName, convPrjFeature.RegionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.GroupName, convPrjFeature.GroupName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.FeatureDescription, convPrjFeature.FeatureDescription);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.InOutTypeId, convPrjFeature.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.InOutTypeName, convPrjFeature.InOutTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.FunctionGroupId, convPrjFeature.FunctionGroupId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.FunctionGroupName, convPrjFeature.FunctionGroupName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.FeatureTypeId, convPrjFeature.FeatureTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.FeatureTypeName, convPrjFeature.FeatureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.CreateUserId, convPrjFeature.CreateUserId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.UpdDate, convPrjFeature.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.UpdUser, convPrjFeature.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.Memo, convPrjFeature.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.FeatureName2, convPrjFeature.FeatureName2);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.ParentFeatureId, convPrjFeature.ParentFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFeatureEN.ParentFeatureName, convPrjFeature.ParentFeatureName);
//检查外键字段长度
 objvPrjFeatureEN._IsCheckProperty = true;
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
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
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
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
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
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjFeatureEN._CurrTabName);
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
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjFeatureEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}