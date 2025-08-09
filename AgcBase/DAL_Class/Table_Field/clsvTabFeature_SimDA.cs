
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeature_SimDA
 表名:vTabFeature_Sim(00050613)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:49
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
 /// v表功能_Sim(vTabFeature_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTabFeature_SimDA : clsCommBase4DA
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
 return clsvTabFeature_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTabFeature_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFeature_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTabFeature_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTabFeature_SimEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vTabFeature_Sim中,检查关键字,长度不正确!(clsvTabFeature_SimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTabFeature_Sim中,关键字不能为空 或 null!(clsvTabFeature_SimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTabFeature_SimDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTabFeature_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetDataTable_vTabFeature_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTabFeature_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFeature_Sim.* " + 
$"from vTabFeature_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFeature_Sim.TabFeatureId not in " + 
$"(Select top {intTop_In} vTabFeature_Sim.TabFeatureId from vTabFeature_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature_Sim where {1} and TabFeatureId not in (Select top {2} TabFeatureId from vTabFeature_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature_Sim where {1} and TabFeatureId not in (Select top {3} TabFeatureId from vTabFeature_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFeature_Sim.* " + 
$"from vTabFeature_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFeature_Sim.TabFeatureId not in " + 
$"(Select top {intTop_In} vTabFeature_Sim.TabFeatureId from vTabFeature_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature_Sim where {1} and TabFeatureId not in (Select top {2} TabFeatureId from vTabFeature_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFeature_Sim where {1} and TabFeatureId not in (Select top {3} TabFeatureId from vTabFeature_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTabFeature_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA:GetObjLst)", objException.Message));
}
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = TransNullToInt(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = TransNullToBool(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = TransNullToBool(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = TransNullToBool(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = TransNullToBool(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = TransNullToBool(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = TransNullToBool(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFeature_SimDA: GetObjLst)", objException.Message));
}
objvTabFeature_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFeature_SimEN);
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
public List<clsvTabFeature_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = TransNullToInt(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = TransNullToBool(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = TransNullToBool(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = TransNullToBool(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = TransNullToBool(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = TransNullToBool(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = TransNullToBool(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFeature_SimDA: GetObjLst)", objException.Message));
}
objvTabFeature_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFeature_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTabFeature_Sim(ref clsvTabFeature_SimEN objvTabFeature_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature_Sim where TabFeatureId = " + "'"+ objvTabFeature_SimEN.TabFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTabFeature_SimEN.TabFeatureId = objDT.Rows[0][convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvTabFeature_SimEN.TabFeatureName = objDT.Rows[0][convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFeature_SimEN.TabId = objDT.Rows[0][convTabFeature_Sim.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeature_SimEN.OrderNum = TransNullToInt(objDT.Rows[0][convTabFeature_Sim.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvTabFeature_SimEN.InUse = TransNullToBool(objDT.Rows[0][convTabFeature_Sim.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.UpdUser = objDT.Rows[0][convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeature_SimEN.UpdDate = objDT.Rows[0][convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeature_SimEN.Memo = objDT.Rows[0][convTabFeature_Sim.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTabFeature_SimEN.FeatureId = objDT.Rows[0][convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeature_SimEN.FuncNameCs = objDT.Rows[0][convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objDT.Rows[0][convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeature_SimEN.CmPrjId = objDT.Rows[0][convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvTabFeature_SimEN.FuncNameJs = objDT.Rows[0][convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeature_SimEN.IsForDiv = TransNullToBool(objDT.Rows[0][convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件(字段类型:bit,字段长度:1,是否可空:False)
 objvTabFeature_SimEN.IsForCSharp = TransNullToBool(objDT.Rows[0][convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.IsForTypeScript = TransNullToBool(objDT.Rows[0][convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.IsExtendedClass = TransNullToBool(objDT.Rows[0][convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.IsNeedGC = TransNullToBool(objDT.Rows[0][convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.ToolTipText = objDT.Rows[0][convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字(字段类型:varchar,字段长度:150,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTabFeature_SimDA: GetvTabFeature_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsvTabFeature_SimEN GetObjByTabFeatureId(string strTabFeatureId)
{
CheckPrimaryKey(strTabFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature_Sim where TabFeatureId = " + "'"+ strTabFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
 objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件(字段类型:bit,字段长度:1,是否可空:False)
 objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字(字段类型:varchar,字段长度:150,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTabFeature_SimDA: GetObjByTabFeatureId)", objException.Message));
}
return objvTabFeature_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTabFeature_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
strSQL = "Select * from vTabFeature_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN()
{
TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(), //表功能Id
TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(), //表功能名
TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(), //表ID
OrderNum = TransNullToInt(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()), //序号
InUse = TransNullToBool(objRow[convTabFeature_Sim.InUse].ToString().Trim()), //是否在用
UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(), //说明
FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(), //功能Id
FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(), //Cs函数名
GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(), //获取Ddl函数名
CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(), //Cm工程Id
FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(), //Js函数名
IsForDiv = TransNullToBool(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()), //是否针对Div内控件
IsForCSharp = TransNullToBool(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()), //是否ForCSharp
IsForTypeScript = TransNullToBool(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()), //是否ForTypeScript
IsExtendedClass = TransNullToBool(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()), //是否在扩展类
IsNeedGC = TransNullToBool(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()), //是否需要生成代码
ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim() //提示文字
};
objvTabFeature_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFeature_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTabFeature_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTabFeature_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = TransNullToInt(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = TransNullToBool(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = TransNullToBool(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = TransNullToBool(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = TransNullToBool(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = TransNullToBool(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = TransNullToBool(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTabFeature_SimDA: GetObjByDataRowvTabFeature_Sim)", objException.Message));
}
objvTabFeature_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFeature_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTabFeature_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = TransNullToInt(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = TransNullToBool(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = TransNullToBool(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = TransNullToBool(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = TransNullToBool(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = TransNullToBool(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = TransNullToBool(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTabFeature_SimDA: GetObjByDataRow)", objException.Message));
}
objvTabFeature_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFeature_SimEN;
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
objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFeature_SimEN._CurrTabName, convTabFeature_Sim.TabFeatureId, 8, "");
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
objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFeature_SimEN._CurrTabName, convTabFeature_Sim.TabFeatureId, 8, strPrefix);
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
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabFeatureId from vTabFeature_Sim where " + strCondition;
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
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabFeatureId from vTabFeature_Sim where " + strCondition;
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
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFeature_Sim", "TabFeatureId = " + "'"+ strTabFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTabFeature_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFeature_Sim", strCondition))
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
objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTabFeature_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTabFeature_SimENS">源对象</param>
 /// <param name = "objvTabFeature_SimENT">目标对象</param>
public void CopyTo(clsvTabFeature_SimEN objvTabFeature_SimENS, clsvTabFeature_SimEN objvTabFeature_SimENT)
{
objvTabFeature_SimENT.TabFeatureId = objvTabFeature_SimENS.TabFeatureId; //表功能Id
objvTabFeature_SimENT.TabFeatureName = objvTabFeature_SimENS.TabFeatureName; //表功能名
objvTabFeature_SimENT.TabId = objvTabFeature_SimENS.TabId; //表ID
objvTabFeature_SimENT.OrderNum = objvTabFeature_SimENS.OrderNum; //序号
objvTabFeature_SimENT.InUse = objvTabFeature_SimENS.InUse; //是否在用
objvTabFeature_SimENT.UpdUser = objvTabFeature_SimENS.UpdUser; //修改者
objvTabFeature_SimENT.UpdDate = objvTabFeature_SimENS.UpdDate; //修改日期
objvTabFeature_SimENT.Memo = objvTabFeature_SimENS.Memo; //说明
objvTabFeature_SimENT.FeatureId = objvTabFeature_SimENS.FeatureId; //功能Id
objvTabFeature_SimENT.FuncNameCs = objvTabFeature_SimENS.FuncNameCs; //Cs函数名
objvTabFeature_SimENT.GetDdlDataFuncName4Ex = objvTabFeature_SimENS.GetDdlDataFuncName4Ex; //获取Ddl函数名
objvTabFeature_SimENT.CmPrjId = objvTabFeature_SimENS.CmPrjId; //Cm工程Id
objvTabFeature_SimENT.FuncNameJs = objvTabFeature_SimENS.FuncNameJs; //Js函数名
objvTabFeature_SimENT.IsForDiv = objvTabFeature_SimENS.IsForDiv; //是否针对Div内控件
objvTabFeature_SimENT.IsForCSharp = objvTabFeature_SimENS.IsForCSharp; //是否ForCSharp
objvTabFeature_SimENT.IsForTypeScript = objvTabFeature_SimENS.IsForTypeScript; //是否ForTypeScript
objvTabFeature_SimENT.IsExtendedClass = objvTabFeature_SimENS.IsExtendedClass; //是否在扩展类
objvTabFeature_SimENT.IsNeedGC = objvTabFeature_SimENS.IsNeedGC; //是否需要生成代码
objvTabFeature_SimENT.ToolTipText = objvTabFeature_SimENS.ToolTipText; //提示文字
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTabFeature_SimEN objvTabFeature_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.TabFeatureId, 8, convTabFeature_Sim.TabFeatureId);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.TabFeatureName, 100, convTabFeature_Sim.TabFeatureName);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.TabId, 8, convTabFeature_Sim.TabId);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.UpdUser, 20, convTabFeature_Sim.UpdUser);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.UpdDate, 20, convTabFeature_Sim.UpdDate);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.Memo, 1000, convTabFeature_Sim.Memo);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.FeatureId, 4, convTabFeature_Sim.FeatureId);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.FuncNameCs, 100, convTabFeature_Sim.FuncNameCs);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.GetDdlDataFuncName4Ex, 100, convTabFeature_Sim.GetDdlDataFuncName4Ex);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.CmPrjId, 6, convTabFeature_Sim.CmPrjId);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.FuncNameJs, 100, convTabFeature_Sim.FuncNameJs);
clsCheckSql.CheckFieldLen(objvTabFeature_SimEN.ToolTipText, 150, convTabFeature_Sim.ToolTipText);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.TabFeatureId, convTabFeature_Sim.TabFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.TabFeatureName, convTabFeature_Sim.TabFeatureName);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.TabId, convTabFeature_Sim.TabId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.UpdUser, convTabFeature_Sim.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.UpdDate, convTabFeature_Sim.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.Memo, convTabFeature_Sim.Memo);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.FeatureId, convTabFeature_Sim.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.FuncNameCs, convTabFeature_Sim.FuncNameCs);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.GetDdlDataFuncName4Ex, convTabFeature_Sim.GetDdlDataFuncName4Ex);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.CmPrjId, convTabFeature_Sim.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.FuncNameJs, convTabFeature_Sim.FuncNameJs);
clsCheckSql.CheckSqlInjection4Field(objvTabFeature_SimEN.ToolTipText, convTabFeature_Sim.ToolTipText);
//检查外键字段长度
 objvTabFeature_SimEN._IsCheckProperty = true;
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
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
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
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
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
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFeature_SimEN._CurrTabName);
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
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFeature_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvTabFeature_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}