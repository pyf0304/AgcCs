
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureFldsDA
 表名:vTabFeatureFlds(00050456)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:02
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
 /// v表功能字段(vTabFeatureFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTabFeatureFldsDA : clsCommBase4DA
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
 return clsvTabFeatureFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTabFeatureFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFeatureFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTabFeatureFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTabFeatureFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeatureFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTabFeatureFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetDataTable_vTabFeatureFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeatureFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeatureFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFeatureFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFeatureFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTabFeatureFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFeatureFlds.* " + 
$"from vTabFeatureFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFeatureFlds.mId not in " + 
$"(Select top {intTop_In} vTabFeatureFlds.mId from vTabFeatureFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFeatureFlds where {1} and mId not in (Select top {2} mId from vTabFeatureFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFeatureFlds where {1} and mId not in (Select top {3} mId from vTabFeatureFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFeatureFlds.* " + 
$"from vTabFeatureFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFeatureFlds.mId not in " + 
$"(Select top {intTop_In} vTabFeatureFlds.mId from vTabFeatureFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFeatureFlds where {1} and mId not in (Select top {2} mId from vTabFeatureFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFeatureFlds where {1} and mId not in (Select top {3} mId from vTabFeatureFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTabFeatureFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA:GetObjLst)", objException.Message));
}
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeatureFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = TransNullToInt(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = TransNullToBool(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = TransNullToInt(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = TransNullToBool(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFeatureFldsDA: GetObjLst)", objException.Message));
}
objvTabFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFeatureFldsEN);
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
public List<clsvTabFeatureFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = TransNullToInt(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = TransNullToBool(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = TransNullToInt(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = TransNullToBool(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFeatureFldsDA: GetObjLst)", objException.Message));
}
objvTabFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFeatureFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTabFeatureFlds(ref clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeatureFlds where mId = " + ""+ objvTabFeatureFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTabFeatureFldsEN.mId = TransNullToInt(objDT.Rows[0][convTabFeatureFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvTabFeatureFldsEN.TabFeatureId = objDT.Rows[0][convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvTabFeatureFldsEN.TabFeatureName = objDT.Rows[0][convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFeatureFldsEN.TabId = objDT.Rows[0][convTabFeatureFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureFldsEN.TabName = objDT.Rows[0][convTabFeatureFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureFldsEN.TabCnName = objDT.Rows[0][convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFeatureFldsEN.PrjName = objDT.Rows[0][convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFeatureFldsEN.SqlDsTypeName = objDT.Rows[0][convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabFeatureFldsEN.FuncModuleAgcId = objDT.Rows[0][convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureFldsEN.FuncModuleName = objDT.Rows[0][convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFeatureFldsEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvTabFeatureFldsEN.FeatureId = objDT.Rows[0][convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureFldsEN.FeatureName = objDT.Rows[0][convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureFldsEN.ParentFeatureId = objDT.Rows[0][convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureFldsEN.ParentFeatureName = objDT.Rows[0][convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTabFeatureFldsEN.FldId = objDT.Rows[0][convTabFeatureFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureFldsEN.FldName = objDT.Rows[0][convTabFeatureFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabFeatureFldsEN.Caption = objDT.Rows[0][convTabFeatureFlds.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvTabFeatureFldsEN.DataTypeId = objDT.Rows[0][convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabFeatureFldsEN.DataTypeName = objDT.Rows[0][convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFeatureFldsEN.IsNull = TransNullToBool(objDT.Rows[0][convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objvTabFeatureFldsEN.FieldTypeId = objDT.Rows[0][convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvTabFeatureFldsEN.FieldTypeName = objDT.Rows[0][convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTabFeatureFldsEN.FuncName = objDT.Rows[0][convTabFeatureFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureFldsEN.ValueGivingModeId = objDT.Rows[0][convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabFeatureFldsEN.ValueGivingModeName = objDT.Rows[0][convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFeatureFldsEN.DefaultValue = objDT.Rows[0][convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFeatureFldsEN.PrjId = objDT.Rows[0][convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureFldsEN.OrderNum = TransNullToInt(objDT.Rows[0][convTabFeatureFlds.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvTabFeatureFldsEN.InUse = TransNullToBool(objDT.Rows[0][convTabFeatureFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeatureFldsEN.UpdUser = objDT.Rows[0][convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeatureFldsEN.UpdDate = objDT.Rows[0][convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeatureFldsEN.Memo = objDT.Rows[0][convTabFeatureFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTabFeatureFldsDA: GetvTabFeatureFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvTabFeatureFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeatureFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
 objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTabFeatureFldsDA: GetObjBymId)", objException.Message));
}
return objvTabFeatureFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTabFeatureFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeatureFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN()
{
mId = TransNullToInt(objRow[convTabFeatureFlds.mId].ToString().Trim()), //mId
TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(), //表功能Id
TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(), //表功能名
TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(), //表ID
TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(), //表名
TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(), //表中文名
PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(), //工程名称
SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(), //Sql数据源名
FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(), //功能模块名称
OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()), //引用序号
FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(), //功能名称
ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(), //父功能Id
ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(), //父功能名
FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(), //字段Id
FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(), //字段名
Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(), //标题
DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(), //数据类型名称
IsNull = TransNullToBool(objRow[convTabFeatureFlds.IsNull].ToString().Trim()), //是否可空
FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(), //字段类型Id
FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(), //字段类型名
FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(), //函数名
ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(), //给值方式Id
ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(), //给值方式名
DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(), //缺省值
PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(), //工程Id
OrderNum = TransNullToInt(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()), //序号
InUse = TransNullToBool(objRow[convTabFeatureFlds.InUse].ToString().Trim()), //是否在用
UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim() //说明
};
objvTabFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFeatureFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTabFeatureFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTabFeatureFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = TransNullToInt(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = TransNullToBool(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = TransNullToInt(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = TransNullToBool(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTabFeatureFldsDA: GetObjByDataRowvTabFeatureFlds)", objException.Message));
}
objvTabFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFeatureFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTabFeatureFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = TransNullToInt(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = TransNullToBool(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = TransNullToInt(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = TransNullToBool(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTabFeatureFldsDA: GetObjByDataRow)", objException.Message));
}
objvTabFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFeatureFldsEN;
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
objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFeatureFldsEN._CurrTabName, convTabFeatureFlds.mId, 8, "");
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
objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFeatureFldsEN._CurrTabName, convTabFeatureFlds.mId, 8, strPrefix);
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
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vTabFeatureFlds where " + strCondition;
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
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vTabFeatureFlds where " + strCondition;
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
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFeatureFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTabFeatureFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFeatureFlds", strCondition))
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
objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTabFeatureFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTabFeatureFldsENS">源对象</param>
 /// <param name = "objvTabFeatureFldsENT">目标对象</param>
public void CopyTo(clsvTabFeatureFldsEN objvTabFeatureFldsENS, clsvTabFeatureFldsEN objvTabFeatureFldsENT)
{
objvTabFeatureFldsENT.mId = objvTabFeatureFldsENS.mId; //mId
objvTabFeatureFldsENT.TabFeatureId = objvTabFeatureFldsENS.TabFeatureId; //表功能Id
objvTabFeatureFldsENT.TabFeatureName = objvTabFeatureFldsENS.TabFeatureName; //表功能名
objvTabFeatureFldsENT.TabId = objvTabFeatureFldsENS.TabId; //表ID
objvTabFeatureFldsENT.TabName = objvTabFeatureFldsENS.TabName; //表名
objvTabFeatureFldsENT.TabCnName = objvTabFeatureFldsENS.TabCnName; //表中文名
objvTabFeatureFldsENT.PrjName = objvTabFeatureFldsENS.PrjName; //工程名称
objvTabFeatureFldsENT.SqlDsTypeName = objvTabFeatureFldsENS.SqlDsTypeName; //Sql数据源名
objvTabFeatureFldsENT.FuncModuleAgcId = objvTabFeatureFldsENS.FuncModuleAgcId; //功能模块Id
objvTabFeatureFldsENT.FuncModuleName = objvTabFeatureFldsENS.FuncModuleName; //功能模块名称
objvTabFeatureFldsENT.OrderNum4Refer = objvTabFeatureFldsENS.OrderNum4Refer; //引用序号
objvTabFeatureFldsENT.FeatureId = objvTabFeatureFldsENS.FeatureId; //功能Id
objvTabFeatureFldsENT.FeatureName = objvTabFeatureFldsENS.FeatureName; //功能名称
objvTabFeatureFldsENT.ParentFeatureId = objvTabFeatureFldsENS.ParentFeatureId; //父功能Id
objvTabFeatureFldsENT.ParentFeatureName = objvTabFeatureFldsENS.ParentFeatureName; //父功能名
objvTabFeatureFldsENT.FldId = objvTabFeatureFldsENS.FldId; //字段Id
objvTabFeatureFldsENT.FldName = objvTabFeatureFldsENS.FldName; //字段名
objvTabFeatureFldsENT.Caption = objvTabFeatureFldsENS.Caption; //标题
objvTabFeatureFldsENT.DataTypeId = objvTabFeatureFldsENS.DataTypeId; //数据类型Id
objvTabFeatureFldsENT.DataTypeName = objvTabFeatureFldsENS.DataTypeName; //数据类型名称
objvTabFeatureFldsENT.IsNull = objvTabFeatureFldsENS.IsNull; //是否可空
objvTabFeatureFldsENT.FieldTypeId = objvTabFeatureFldsENS.FieldTypeId; //字段类型Id
objvTabFeatureFldsENT.FieldTypeName = objvTabFeatureFldsENS.FieldTypeName; //字段类型名
objvTabFeatureFldsENT.FuncName = objvTabFeatureFldsENS.FuncName; //函数名
objvTabFeatureFldsENT.ValueGivingModeId = objvTabFeatureFldsENS.ValueGivingModeId; //给值方式Id
objvTabFeatureFldsENT.ValueGivingModeName = objvTabFeatureFldsENS.ValueGivingModeName; //给值方式名
objvTabFeatureFldsENT.DefaultValue = objvTabFeatureFldsENS.DefaultValue; //缺省值
objvTabFeatureFldsENT.PrjId = objvTabFeatureFldsENS.PrjId; //工程Id
objvTabFeatureFldsENT.OrderNum = objvTabFeatureFldsENS.OrderNum; //序号
objvTabFeatureFldsENT.InUse = objvTabFeatureFldsENS.InUse; //是否在用
objvTabFeatureFldsENT.UpdUser = objvTabFeatureFldsENS.UpdUser; //修改者
objvTabFeatureFldsENT.UpdDate = objvTabFeatureFldsENS.UpdDate; //修改日期
objvTabFeatureFldsENT.Memo = objvTabFeatureFldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.TabFeatureId, 8, convTabFeatureFlds.TabFeatureId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.TabFeatureName, 100, convTabFeatureFlds.TabFeatureName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.TabId, 8, convTabFeatureFlds.TabId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.TabName, 100, convTabFeatureFlds.TabName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.TabCnName, 200, convTabFeatureFlds.TabCnName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.PrjName, 30, convTabFeatureFlds.PrjName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.SqlDsTypeName, 20, convTabFeatureFlds.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.FuncModuleAgcId, 8, convTabFeatureFlds.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.FuncModuleName, 30, convTabFeatureFlds.FuncModuleName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.FeatureId, 4, convTabFeatureFlds.FeatureId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.FeatureName, 100, convTabFeatureFlds.FeatureName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.ParentFeatureId, 4, convTabFeatureFlds.ParentFeatureId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.ParentFeatureName, 500, convTabFeatureFlds.ParentFeatureName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.FldId, 8, convTabFeatureFlds.FldId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.FldName, 50, convTabFeatureFlds.FldName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.Caption, 200, convTabFeatureFlds.Caption);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.DataTypeId, 2, convTabFeatureFlds.DataTypeId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.DataTypeName, 100, convTabFeatureFlds.DataTypeName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.FieldTypeId, 2, convTabFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.FieldTypeName, 30, convTabFeatureFlds.FieldTypeName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.FuncName, 100, convTabFeatureFlds.FuncName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.ValueGivingModeId, 2, convTabFeatureFlds.ValueGivingModeId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.ValueGivingModeName, 50, convTabFeatureFlds.ValueGivingModeName);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.DefaultValue, 50, convTabFeatureFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.PrjId, 4, convTabFeatureFlds.PrjId);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.UpdUser, 20, convTabFeatureFlds.UpdUser);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.UpdDate, 20, convTabFeatureFlds.UpdDate);
clsCheckSql.CheckFieldLen(objvTabFeatureFldsEN.Memo, 1000, convTabFeatureFlds.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.TabFeatureId, convTabFeatureFlds.TabFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.TabFeatureName, convTabFeatureFlds.TabFeatureName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.TabId, convTabFeatureFlds.TabId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.TabName, convTabFeatureFlds.TabName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.TabCnName, convTabFeatureFlds.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.PrjName, convTabFeatureFlds.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.SqlDsTypeName, convTabFeatureFlds.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.FuncModuleAgcId, convTabFeatureFlds.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.FuncModuleName, convTabFeatureFlds.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.FeatureId, convTabFeatureFlds.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.FeatureName, convTabFeatureFlds.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.ParentFeatureId, convTabFeatureFlds.ParentFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.ParentFeatureName, convTabFeatureFlds.ParentFeatureName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.FldId, convTabFeatureFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.FldName, convTabFeatureFlds.FldName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.Caption, convTabFeatureFlds.Caption);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.DataTypeId, convTabFeatureFlds.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.DataTypeName, convTabFeatureFlds.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.FieldTypeId, convTabFeatureFlds.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.FieldTypeName, convTabFeatureFlds.FieldTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.FuncName, convTabFeatureFlds.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.ValueGivingModeId, convTabFeatureFlds.ValueGivingModeId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.ValueGivingModeName, convTabFeatureFlds.ValueGivingModeName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.DefaultValue, convTabFeatureFlds.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.PrjId, convTabFeatureFlds.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.UpdUser, convTabFeatureFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.UpdDate, convTabFeatureFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvTabFeatureFldsEN.Memo, convTabFeatureFlds.Memo);
//检查外键字段长度
 objvTabFeatureFldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vTabFeatureFlds(v表功能字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objvTabFeatureFldsEN.TabFeatureId == null)
{
 sbCondition.AppendFormat(" and TabFeatureId is null");
}
else
{
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFldsEN.TabFeatureId);
}
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFldsEN.FldId);
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
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
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
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
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
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFeatureFldsEN._CurrTabName);
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
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFeatureFldsEN._CurrTabName, strCondition);
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
 objSQL = clsvTabFeatureFldsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}