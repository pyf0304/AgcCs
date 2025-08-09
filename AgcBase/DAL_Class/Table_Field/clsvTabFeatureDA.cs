
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureDA
 表名:vTabFeature(00050464)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// v表功能(vTabFeature)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTabFeatureDA : clsCommBase4DA
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
 return clsvTabFeatureEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTabFeatureEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFeatureEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTabFeatureEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTabFeatureEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTabFeatureId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTabFeatureId)
{
strTabFeatureId = strTabFeatureId.Replace("'", "''");
if (strTabFeatureId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vTabFeature中,检查关键字,长度不正确!(clsvTabFeatureDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTabFeature中,关键字不能为空 或 null!(clsvTabFeatureDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTabFeatureDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTabFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTabFeature(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTabFeatureDA: GetDataTable_vTabFeature)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTabFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTabFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTabFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTabFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTabFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTabFeature where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTabFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFeature.* " + 
$"from vTabFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFeature.TabFeatureId not in " + 
$"(Select top {intTop_In} vTabFeature.TabFeatureId from vTabFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature where {1} and TabFeatureId not in (Select top {2} TabFeatureId from vTabFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature where {1} and TabFeatureId not in (Select top {3} TabFeatureId from vTabFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTabFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFeature.* " + 
$"from vTabFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFeature.TabFeatureId not in " + 
$"(Select top {intTop_In} vTabFeature.TabFeatureId from vTabFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature where {1} and TabFeatureId not in (Select top {2} TabFeatureId from vTabFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature where {1} and TabFeatureId not in (Select top {3} TabFeatureId from vTabFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTabFeatureEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTabFeatureDA:GetObjLst)", objException.Message));
}
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = TransNullToInt(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = TransNullToBool(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFeatureDA: GetObjLst)", objException.Message));
}
objvTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFeatureEN);
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
public List<clsvTabFeatureEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTabFeatureDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = TransNullToInt(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = TransNullToBool(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFeatureDA: GetObjLst)", objException.Message));
}
objvTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFeatureEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTabFeature(ref clsvTabFeatureEN objvTabFeatureEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature where TabFeatureId = " + "'"+ objvTabFeatureEN.TabFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTabFeatureEN.TabFeatureId = objDT.Rows[0][convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvTabFeatureEN.TabFeatureName = objDT.Rows[0][convTabFeature.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFeatureEN.TabId = objDT.Rows[0][convTabFeature.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureEN.TabName = objDT.Rows[0][convTabFeature.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureEN.TabCnName = objDT.Rows[0][convTabFeature.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFeatureEN.PrjName = objDT.Rows[0][convTabFeature.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFeatureEN.SqlDsTypeName = objDT.Rows[0][convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabFeatureEN.FuncModuleAgcId = objDT.Rows[0][convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureEN.FuncModuleName = objDT.Rows[0][convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFeatureEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvTabFeatureEN.FeatureId = objDT.Rows[0][convTabFeature.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureEN.FeatureName = objDT.Rows[0][convTabFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureEN.ParentFeatureId = objDT.Rows[0][convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureEN.ParentFeatureName = objDT.Rows[0][convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTabFeatureEN.FuncNameCs = objDT.Rows[0][convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureEN.FuncNameJs = objDT.Rows[0][convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureEN.OrderNum = TransNullToInt(objDT.Rows[0][convTabFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvTabFeatureEN.InUse = TransNullToBool(objDT.Rows[0][convTabFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeatureEN.PrjId = objDT.Rows[0][convTabFeature.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureEN.UpdUser = objDT.Rows[0][convTabFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeatureEN.UpdDate = objDT.Rows[0][convTabFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeatureEN.Memo = objDT.Rows[0][convTabFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTabFeatureEN.FldNum = TransNullToInt(objDT.Rows[0][convTabFeature.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTabFeatureDA: GetvTabFeature)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsvTabFeatureEN GetObjByTabFeatureId(string strTabFeatureId)
{
CheckPrimaryKey(strTabFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature where TabFeatureId = " + "'"+ strTabFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
 objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTabFeatureDA: GetObjByTabFeatureId)", objException.Message));
}
return objvTabFeatureEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTabFeatureEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTabFeatureDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN()
{
TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(), //表功能Id
TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(), //表功能名
TabId = objRow[convTabFeature.TabId].ToString().Trim(), //表ID
TabName = objRow[convTabFeature.TabName].ToString().Trim(), //表名
TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(), //表中文名
PrjName = objRow[convTabFeature.PrjName].ToString().Trim(), //工程名称
SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(), //Sql数据源名
FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(), //功能模块名称
OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()), //引用序号
FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(), //功能名称
ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(), //父功能Id
ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(), //父功能名
FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(), //Cs函数名
FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(), //Js函数名
OrderNum = TransNullToInt(objRow[convTabFeature.OrderNum].ToString().Trim()), //序号
InUse = TransNullToBool(objRow[convTabFeature.InUse].ToString().Trim()), //是否在用
PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(), //说明
FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.FldNum].ToString().Trim()) //字段数
};
objvTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFeatureEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTabFeatureDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTabFeatureEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = TransNullToInt(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = TransNullToBool(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTabFeatureDA: GetObjByDataRowvTabFeature)", objException.Message));
}
objvTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFeatureEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTabFeatureEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = TransNullToInt(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = TransNullToBool(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTabFeatureDA: GetObjByDataRow)", objException.Message));
}
objvTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFeatureEN;
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
objSQL = clsvTabFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFeatureEN._CurrTabName, convTabFeature.TabFeatureId, 8, "");
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
objSQL = clsvTabFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFeatureEN._CurrTabName, convTabFeature.TabFeatureId, 8, strPrefix);
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
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabFeatureId from vTabFeature where " + strCondition;
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
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabFeatureId from vTabFeature where " + strCondition;
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
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTabFeatureId)
{
CheckPrimaryKey(strTabFeatureId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFeature", "TabFeatureId = " + "'"+ strTabFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTabFeatureDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFeature", strCondition))
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
objSQL = clsvTabFeatureDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTabFeature");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTabFeatureENS">源对象</param>
 /// <param name = "objvTabFeatureENT">目标对象</param>
public void CopyTo(clsvTabFeatureEN objvTabFeatureENS, clsvTabFeatureEN objvTabFeatureENT)
{
objvTabFeatureENT.TabFeatureId = objvTabFeatureENS.TabFeatureId; //表功能Id
objvTabFeatureENT.TabFeatureName = objvTabFeatureENS.TabFeatureName; //表功能名
objvTabFeatureENT.TabId = objvTabFeatureENS.TabId; //表ID
objvTabFeatureENT.TabName = objvTabFeatureENS.TabName; //表名
objvTabFeatureENT.TabCnName = objvTabFeatureENS.TabCnName; //表中文名
objvTabFeatureENT.PrjName = objvTabFeatureENS.PrjName; //工程名称
objvTabFeatureENT.SqlDsTypeName = objvTabFeatureENS.SqlDsTypeName; //Sql数据源名
objvTabFeatureENT.FuncModuleAgcId = objvTabFeatureENS.FuncModuleAgcId; //功能模块Id
objvTabFeatureENT.FuncModuleName = objvTabFeatureENS.FuncModuleName; //功能模块名称
objvTabFeatureENT.OrderNum4Refer = objvTabFeatureENS.OrderNum4Refer; //引用序号
objvTabFeatureENT.FeatureId = objvTabFeatureENS.FeatureId; //功能Id
objvTabFeatureENT.FeatureName = objvTabFeatureENS.FeatureName; //功能名称
objvTabFeatureENT.ParentFeatureId = objvTabFeatureENS.ParentFeatureId; //父功能Id
objvTabFeatureENT.ParentFeatureName = objvTabFeatureENS.ParentFeatureName; //父功能名
objvTabFeatureENT.FuncNameCs = objvTabFeatureENS.FuncNameCs; //Cs函数名
objvTabFeatureENT.FuncNameJs = objvTabFeatureENS.FuncNameJs; //Js函数名
objvTabFeatureENT.OrderNum = objvTabFeatureENS.OrderNum; //序号
objvTabFeatureENT.InUse = objvTabFeatureENS.InUse; //是否在用
objvTabFeatureENT.PrjId = objvTabFeatureENS.PrjId; //工程Id
objvTabFeatureENT.UpdUser = objvTabFeatureENS.UpdUser; //修改者
objvTabFeatureENT.UpdDate = objvTabFeatureENS.UpdDate; //修改日期
objvTabFeatureENT.Memo = objvTabFeatureENS.Memo; //说明
objvTabFeatureENT.FldNum = objvTabFeatureENS.FldNum; //字段数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTabFeatureEN objvTabFeatureEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTabFeatureEN.TabFeatureId, 8, convTabFeature.TabFeatureId);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.TabFeatureName, 100, convTabFeature.TabFeatureName);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.TabId, 8, convTabFeature.TabId);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.TabName, 100, convTabFeature.TabName);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.TabCnName, 200, convTabFeature.TabCnName);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.PrjName, 30, convTabFeature.PrjName);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.SqlDsTypeName, 20, convTabFeature.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.FuncModuleAgcId, 8, convTabFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.FuncModuleName, 30, convTabFeature.FuncModuleName);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.FeatureId, 4, convTabFeature.FeatureId);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.FeatureName, 100, convTabFeature.FeatureName);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.ParentFeatureId, 4, convTabFeature.ParentFeatureId);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.ParentFeatureName, 500, convTabFeature.ParentFeatureName);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.FuncNameCs, 100, convTabFeature.FuncNameCs);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.FuncNameJs, 100, convTabFeature.FuncNameJs);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.PrjId, 4, convTabFeature.PrjId);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.UpdUser, 20, convTabFeature.UpdUser);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.UpdDate, 20, convTabFeature.UpdDate);
clsCheckSql.CheckFieldLen(objvTabFeatureEN.Memo, 1000, convTabFeature.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.TabFeatureId, convTabFeature.TabFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.TabFeatureName, convTabFeature.TabFeatureName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.TabId, convTabFeature.TabId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.TabName, convTabFeature.TabName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.TabCnName, convTabFeature.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.PrjName, convTabFeature.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.SqlDsTypeName, convTabFeature.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.FuncModuleAgcId, convTabFeature.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.FuncModuleName, convTabFeature.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.FeatureId, convTabFeature.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.FeatureName, convTabFeature.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.ParentFeatureId, convTabFeature.ParentFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.ParentFeatureName, convTabFeature.ParentFeatureName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.FuncNameCs, convTabFeature.FuncNameCs);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.FuncNameJs, convTabFeature.FuncNameJs);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.PrjId, convTabFeature.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.UpdUser, convTabFeature.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.UpdDate, convTabFeature.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureEN.Memo, convTabFeature.Memo);
//检查外键字段长度
 objvTabFeatureEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTabFeatureId()
{
//获取某学院所有专业信息
string strSQL = "select TabFeatureId, TabFeatureName from vTabFeature ";
 clsSpecSQLforSql mySql = clsvTabFeatureDA.GetSpecSQLObj();
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
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
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
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
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
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFeatureEN._CurrTabName);
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
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFeatureEN._CurrTabName, strCondition);
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
 objSQL = clsvTabFeatureDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}