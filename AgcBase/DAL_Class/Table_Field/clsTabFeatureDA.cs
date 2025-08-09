
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFeatureDA
 表名:TabFeature(00050463)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:38
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
 /// 表功能(TabFeature)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTabFeatureDA : clsCommBase4DA
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
 return clsTabFeatureEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTabFeatureEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabFeatureEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTabFeatureEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTabFeatureEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:TabFeature中,检查关键字,长度不正确!(clsTabFeatureDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TabFeature中,关键字不能为空 或 null!(clsTabFeatureDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTabFeatureDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTabFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TabFeature(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTabFeatureDA: GetDataTable_TabFeature)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTabFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTabFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTabFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTabFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabFeature where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabFeature where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTabFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TabFeature where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTabFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabFeature.* " + 
$"from TabFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabFeature.TabFeatureId not in " + 
$"(Select top {intTop_In} TabFeature.TabFeatureId from TabFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabFeature where {1} and TabFeatureId not in (Select top {2} TabFeatureId from TabFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabFeature where {1} and TabFeatureId not in (Select top {3} TabFeatureId from TabFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTabFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabFeature.* " + 
$"from TabFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabFeature.TabFeatureId not in " + 
$"(Select top {intTop_In} TabFeature.TabFeatureId from TabFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabFeature where {1} and TabFeatureId not in (Select top {2} TabFeatureId from TabFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabFeature where {1} and TabFeatureId not in (Select top {3} TabFeatureId from TabFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTabFeatureEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTabFeatureDA:GetObjLst)", objException.Message));
}
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = TransNullToBool(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = TransNullToBool(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = TransNullToBool(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = TransNullToBool(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = TransNullToBool(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = TransNullToBool(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = TransNullToBool(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabFeatureDA: GetObjLst)", objException.Message));
}
objTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabFeatureEN);
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
public List<clsTabFeatureEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTabFeatureDA:GetObjLstByTabName)", objException.Message));
}
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = TransNullToBool(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = TransNullToBool(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = TransNullToBool(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = TransNullToBool(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = TransNullToBool(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = TransNullToBool(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = TransNullToBool(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabFeatureDA: GetObjLst)", objException.Message));
}
objTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabFeatureEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTabFeature(ref clsTabFeatureEN objTabFeatureEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where TabFeatureId = " + "'"+ objTabFeatureEN.TabFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTabFeatureEN.TabFeatureId = objDT.Rows[0][conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objTabFeatureEN.TabFeatureName = objDT.Rows[0][conTabFeature.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objTabFeatureEN.TabId = objDT.Rows[0][conTabFeature.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objTabFeatureEN.FeatureId = objDT.Rows[0][conTabFeature.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFeatureEN.FuncNameCs = objDT.Rows[0][conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objTabFeatureEN.IsExtendedClass = TransNullToBool(objDT.Rows[0][conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.FuncNameJs = objDT.Rows[0][conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objTabFeatureEN.GetDdlDataFuncName4Ex = objDT.Rows[0][conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objTabFeatureEN.IsForCSharp = TransNullToBool(objDT.Rows[0][conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.IsForTypeScript = TransNullToBool(objDT.Rows[0][conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.IsForDiv = TransNullToBool(objDT.Rows[0][conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件(字段类型:bit,字段长度:1,是否可空:False)
 objTabFeatureEN.IsNeedGC = TransNullToBool(objDT.Rows[0][conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.UseTimes = TransNullToInt(objDT.Rows[0][conTabFeature.UseTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:False)
 objTabFeatureEN.OrderNum = TransNullToInt(objDT.Rows[0][conTabFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objTabFeatureEN.IsNullable = TransNullToBool(objDT.Rows[0][conTabFeature.IsNullable].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objTabFeatureEN.InUse = TransNullToBool(objDT.Rows[0][conTabFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.CheckDate = objDT.Rows[0][conTabFeature.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objTabFeatureEN.ToolTipText = objDT.Rows[0][conTabFeature.ToolTipText].ToString().Trim(); //提示文字(字段类型:varchar,字段长度:150,是否可空:True)
 objTabFeatureEN.ErrMsg = objDT.Rows[0][conTabFeature.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objTabFeatureEN.PrjId = objDT.Rows[0][conTabFeature.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFeatureEN.UpdUser = objDT.Rows[0][conTabFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objTabFeatureEN.UpdDate = objDT.Rows[0][conTabFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTabFeatureEN.Memo = objDT.Rows[0][conTabFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTabFeatureDA: GetTabFeature)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsTabFeatureEN GetObjByTabFeatureId(string strTabFeatureId)
{
CheckPrimaryKey(strTabFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where TabFeatureId = " + "'"+ strTabFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
 objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件(字段类型:bit,字段长度:1,是否可空:False)
 objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:False)
 objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字(字段类型:varchar,字段长度:150,是否可空:True)
 objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTabFeatureDA: GetObjByTabFeatureId)", objException.Message));
}
return objTabFeatureEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTabFeatureEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTabFeatureDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN()
{
TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(), //表功能Id
TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(), //表功能名
TabId = objRow[conTabFeature.TabId].ToString().Trim(), //表ID
FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(), //功能Id
FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(), //Cs函数名
IsExtendedClass = TransNullToBool(objRow[conTabFeature.IsExtendedClass].ToString().Trim()), //是否在扩展类
FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(), //Js函数名
GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(), //获取Ddl函数名
IsForCSharp = TransNullToBool(objRow[conTabFeature.IsForCSharp].ToString().Trim()), //是否ForCSharp
IsForTypeScript = TransNullToBool(objRow[conTabFeature.IsForTypeScript].ToString().Trim()), //是否ForTypeScript
IsForDiv = TransNullToBool(objRow[conTabFeature.IsForDiv].ToString().Trim()), //是否针对Div内控件
IsNeedGC = TransNullToBool(objRow[conTabFeature.IsNeedGC].ToString().Trim()), //是否需要生成代码
UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.UseTimes].ToString().Trim()), //使用次数
OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.OrderNum].ToString().Trim()), //序号
IsNullable = TransNullToBool(objRow[conTabFeature.IsNullable].ToString().Trim()), //是否可空
InUse = TransNullToBool(objRow[conTabFeature.InUse].ToString().Trim()), //是否在用
CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(), //检查日期
ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(), //提示文字
ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conTabFeature.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim() //说明
};
objTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabFeatureEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTabFeatureDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTabFeatureEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = TransNullToBool(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = TransNullToBool(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = TransNullToBool(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = TransNullToBool(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = TransNullToBool(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = TransNullToBool(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = TransNullToBool(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTabFeatureDA: GetObjByDataRowTabFeature)", objException.Message));
}
objTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabFeatureEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTabFeatureEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = TransNullToBool(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = TransNullToBool(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = TransNullToBool(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = TransNullToBool(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = TransNullToBool(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = TransNullToBool(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = TransNullToBool(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTabFeatureDA: GetObjByDataRow)", objException.Message));
}
objTabFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabFeatureEN;
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
objSQL = clsTabFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabFeatureEN._CurrTabName, conTabFeature.TabFeatureId, 8, "");
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
objSQL = clsTabFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabFeatureEN._CurrTabName, conTabFeature.TabFeatureId, 8, strPrefix);
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
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabFeatureId from TabFeature where " + strCondition;
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
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabFeatureId from TabFeature where " + strCondition;
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
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabFeature", "TabFeatureId = " + "'"+ strTabFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTabFeatureDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabFeature", strCondition))
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
objSQL = clsTabFeatureDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TabFeature");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTabFeatureEN objTabFeatureEN)
 {
 objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFeatureEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabFeature");
objRow = objDS.Tables["TabFeature"].NewRow();
objRow[conTabFeature.TabFeatureId] = objTabFeatureEN.TabFeatureId; //表功能Id
objRow[conTabFeature.TabFeatureName] = objTabFeatureEN.TabFeatureName; //表功能名
objRow[conTabFeature.TabId] = objTabFeatureEN.TabId; //表ID
objRow[conTabFeature.FeatureId] = objTabFeatureEN.FeatureId; //功能Id
 if (objTabFeatureEN.FuncNameCs !=  "")
 {
objRow[conTabFeature.FuncNameCs] = objTabFeatureEN.FuncNameCs; //Cs函数名
 }
objRow[conTabFeature.IsExtendedClass] = objTabFeatureEN.IsExtendedClass; //是否在扩展类
 if (objTabFeatureEN.FuncNameJs !=  "")
 {
objRow[conTabFeature.FuncNameJs] = objTabFeatureEN.FuncNameJs; //Js函数名
 }
 if (objTabFeatureEN.GetDdlDataFuncName4Ex !=  "")
 {
objRow[conTabFeature.GetDdlDataFuncName4Ex] = objTabFeatureEN.GetDdlDataFuncName4Ex; //获取Ddl函数名
 }
objRow[conTabFeature.IsForCSharp] = objTabFeatureEN.IsForCSharp; //是否ForCSharp
objRow[conTabFeature.IsForTypeScript] = objTabFeatureEN.IsForTypeScript; //是否ForTypeScript
objRow[conTabFeature.IsForDiv] = objTabFeatureEN.IsForDiv; //是否针对Div内控件
objRow[conTabFeature.IsNeedGC] = objTabFeatureEN.IsNeedGC; //是否需要生成代码
objRow[conTabFeature.UseTimes] = objTabFeatureEN.UseTimes; //使用次数
objRow[conTabFeature.OrderNum] = objTabFeatureEN.OrderNum; //序号
objRow[conTabFeature.IsNullable] = objTabFeatureEN.IsNullable; //是否可空
objRow[conTabFeature.InUse] = objTabFeatureEN.InUse; //是否在用
 if (objTabFeatureEN.CheckDate !=  "")
 {
objRow[conTabFeature.CheckDate] = objTabFeatureEN.CheckDate; //检查日期
 }
 if (objTabFeatureEN.ToolTipText !=  "")
 {
objRow[conTabFeature.ToolTipText] = objTabFeatureEN.ToolTipText; //提示文字
 }
 if (objTabFeatureEN.ErrMsg !=  "")
 {
objRow[conTabFeature.ErrMsg] = objTabFeatureEN.ErrMsg; //错误信息
 }
objRow[conTabFeature.PrjId] = objTabFeatureEN.PrjId; //工程Id
objRow[conTabFeature.UpdUser] = objTabFeatureEN.UpdUser; //修改者
 if (objTabFeatureEN.UpdDate !=  "")
 {
objRow[conTabFeature.UpdDate] = objTabFeatureEN.UpdDate; //修改日期
 }
 if (objTabFeatureEN.Memo !=  "")
 {
objRow[conTabFeature.Memo] = objTabFeatureEN.Memo; //说明
 }
objDS.Tables[clsTabFeatureEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTabFeatureEN._CurrTabName);
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabFeatureEN objTabFeatureEN)
{
 objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFeatureEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTabFeatureEN.TabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.TabFeatureId);
 var strTabFeatureId = objTabFeatureEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId + "'");
 }
 
 if (objTabFeatureEN.TabFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.TabFeatureName);
 var strTabFeatureName = objTabFeatureEN.TabFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureName + "'");
 }
 
 if (objTabFeatureEN.TabId  ==  "")
 {
 objTabFeatureEN.TabId = null;
 }
 if (objTabFeatureEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.TabId);
 var strTabId = objTabFeatureEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFeatureEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.FeatureId);
 var strFeatureId = objTabFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objTabFeatureEN.FuncNameCs !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.FuncNameCs);
 var strFuncNameCs = objTabFeatureEN.FuncNameCs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncNameCs + "'");
 }
 
 arrFieldListForInsert.Add(conTabFeature.IsExtendedClass);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsExtendedClass  ==  false ? "0" : "1") + "'");
 
 if (objTabFeatureEN.FuncNameJs !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.FuncNameJs);
 var strFuncNameJs = objTabFeatureEN.FuncNameJs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncNameJs + "'");
 }
 
 if (objTabFeatureEN.GetDdlDataFuncName4Ex !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.GetDdlDataFuncName4Ex);
 var strGetDdlDataFuncName4Ex = objTabFeatureEN.GetDdlDataFuncName4Ex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDdlDataFuncName4Ex + "'");
 }
 
 arrFieldListForInsert.Add(conTabFeature.IsForCSharp);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsForCSharp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.IsForTypeScript);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsForTypeScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.IsForDiv);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsForDiv  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.IsNeedGC);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsNeedGC  ==  false ? "0" : "1") + "'");
 
 if (objTabFeatureEN.UseTimes !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.UseTimes);
 arrValueListForInsert.Add(objTabFeatureEN.UseTimes.ToString());
 }
 
 if (objTabFeatureEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.OrderNum);
 arrValueListForInsert.Add(objTabFeatureEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conTabFeature.IsNullable);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.InUse);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objTabFeatureEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.CheckDate);
 var strCheckDate = objTabFeatureEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objTabFeatureEN.ToolTipText !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.ToolTipText);
 var strToolTipText = objTabFeatureEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strToolTipText + "'");
 }
 
 if (objTabFeatureEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.ErrMsg);
 var strErrMsg = objTabFeatureEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objTabFeatureEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.PrjId);
 var strPrjId = objTabFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.UpdUser);
 var strUpdUser = objTabFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.UpdDate);
 var strUpdDate = objTabFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.Memo);
 var strMemo = objTabFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFeature");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTabFeatureEN objTabFeatureEN)
{
 objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFeatureEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTabFeatureEN.TabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.TabFeatureId);
 var strTabFeatureId = objTabFeatureEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId + "'");
 }
 
 if (objTabFeatureEN.TabFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.TabFeatureName);
 var strTabFeatureName = objTabFeatureEN.TabFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureName + "'");
 }
 
 if (objTabFeatureEN.TabId  ==  "")
 {
 objTabFeatureEN.TabId = null;
 }
 if (objTabFeatureEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.TabId);
 var strTabId = objTabFeatureEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFeatureEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.FeatureId);
 var strFeatureId = objTabFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objTabFeatureEN.FuncNameCs !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.FuncNameCs);
 var strFuncNameCs = objTabFeatureEN.FuncNameCs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncNameCs + "'");
 }
 
 arrFieldListForInsert.Add(conTabFeature.IsExtendedClass);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsExtendedClass  ==  false ? "0" : "1") + "'");
 
 if (objTabFeatureEN.FuncNameJs !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.FuncNameJs);
 var strFuncNameJs = objTabFeatureEN.FuncNameJs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncNameJs + "'");
 }
 
 if (objTabFeatureEN.GetDdlDataFuncName4Ex !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.GetDdlDataFuncName4Ex);
 var strGetDdlDataFuncName4Ex = objTabFeatureEN.GetDdlDataFuncName4Ex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDdlDataFuncName4Ex + "'");
 }
 
 arrFieldListForInsert.Add(conTabFeature.IsForCSharp);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsForCSharp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.IsForTypeScript);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsForTypeScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.IsForDiv);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsForDiv  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.IsNeedGC);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsNeedGC  ==  false ? "0" : "1") + "'");
 
 if (objTabFeatureEN.UseTimes !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.UseTimes);
 arrValueListForInsert.Add(objTabFeatureEN.UseTimes.ToString());
 }
 
 if (objTabFeatureEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.OrderNum);
 arrValueListForInsert.Add(objTabFeatureEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conTabFeature.IsNullable);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.InUse);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objTabFeatureEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.CheckDate);
 var strCheckDate = objTabFeatureEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objTabFeatureEN.ToolTipText !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.ToolTipText);
 var strToolTipText = objTabFeatureEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strToolTipText + "'");
 }
 
 if (objTabFeatureEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.ErrMsg);
 var strErrMsg = objTabFeatureEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objTabFeatureEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.PrjId);
 var strPrjId = objTabFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.UpdUser);
 var strUpdUser = objTabFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.UpdDate);
 var strUpdDate = objTabFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.Memo);
 var strMemo = objTabFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFeature");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTabFeatureEN.TabFeatureId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabFeatureEN objTabFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFeatureEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFeatureEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTabFeatureEN.TabFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.TabFeatureId);
 var strTabFeatureId = objTabFeatureEN.TabFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId + "'");
 }
 
 if (objTabFeatureEN.TabFeatureName !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.TabFeatureName);
 var strTabFeatureName = objTabFeatureEN.TabFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureName + "'");
 }
 
 if (objTabFeatureEN.TabId  ==  "")
 {
 objTabFeatureEN.TabId = null;
 }
 if (objTabFeatureEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.TabId);
 var strTabId = objTabFeatureEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFeatureEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.FeatureId);
 var strFeatureId = objTabFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objTabFeatureEN.FuncNameCs !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.FuncNameCs);
 var strFuncNameCs = objTabFeatureEN.FuncNameCs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncNameCs + "'");
 }
 
 arrFieldListForInsert.Add(conTabFeature.IsExtendedClass);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsExtendedClass  ==  false ? "0" : "1") + "'");
 
 if (objTabFeatureEN.FuncNameJs !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.FuncNameJs);
 var strFuncNameJs = objTabFeatureEN.FuncNameJs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncNameJs + "'");
 }
 
 if (objTabFeatureEN.GetDdlDataFuncName4Ex !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.GetDdlDataFuncName4Ex);
 var strGetDdlDataFuncName4Ex = objTabFeatureEN.GetDdlDataFuncName4Ex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDdlDataFuncName4Ex + "'");
 }
 
 arrFieldListForInsert.Add(conTabFeature.IsForCSharp);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsForCSharp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.IsForTypeScript);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsForTypeScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.IsForDiv);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsForDiv  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.IsNeedGC);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsNeedGC  ==  false ? "0" : "1") + "'");
 
 if (objTabFeatureEN.UseTimes !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.UseTimes);
 arrValueListForInsert.Add(objTabFeatureEN.UseTimes.ToString());
 }
 
 if (objTabFeatureEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.OrderNum);
 arrValueListForInsert.Add(objTabFeatureEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conTabFeature.IsNullable);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.IsNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFeature.InUse);
 arrValueListForInsert.Add("'" + (objTabFeatureEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objTabFeatureEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.CheckDate);
 var strCheckDate = objTabFeatureEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objTabFeatureEN.ToolTipText !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.ToolTipText);
 var strToolTipText = objTabFeatureEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strToolTipText + "'");
 }
 
 if (objTabFeatureEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.ErrMsg);
 var strErrMsg = objTabFeatureEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objTabFeatureEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.PrjId);
 var strPrjId = objTabFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabFeatureEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.UpdUser);
 var strUpdUser = objTabFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabFeatureEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.UpdDate);
 var strUpdDate = objTabFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabFeatureEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFeature.Memo);
 var strMemo = objTabFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFeature");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTabFeatures(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where TabFeatureId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabFeature");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTabFeatureId = oRow[conTabFeature.TabFeatureId].ToString().Trim();
if (IsExist(strTabFeatureId))
{
 string strResult = "关键字变量值为:" + string.Format("TabFeatureId = {0}", strTabFeatureId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTabFeatureEN._CurrTabName ].NewRow();
objRow[conTabFeature.TabFeatureId] = oRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objRow[conTabFeature.TabFeatureName] = oRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objRow[conTabFeature.TabId] = oRow[conTabFeature.TabId].ToString().Trim(); //表ID
objRow[conTabFeature.FeatureId] = oRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objRow[conTabFeature.FuncNameCs] = oRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objRow[conTabFeature.IsExtendedClass] = oRow[conTabFeature.IsExtendedClass].ToString().Trim(); //是否在扩展类
objRow[conTabFeature.FuncNameJs] = oRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objRow[conTabFeature.GetDdlDataFuncName4Ex] = oRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objRow[conTabFeature.IsForCSharp] = oRow[conTabFeature.IsForCSharp].ToString().Trim(); //是否ForCSharp
objRow[conTabFeature.IsForTypeScript] = oRow[conTabFeature.IsForTypeScript].ToString().Trim(); //是否ForTypeScript
objRow[conTabFeature.IsForDiv] = oRow[conTabFeature.IsForDiv].ToString().Trim(); //是否针对Div内控件
objRow[conTabFeature.IsNeedGC] = oRow[conTabFeature.IsNeedGC].ToString().Trim(); //是否需要生成代码
objRow[conTabFeature.UseTimes] = oRow[conTabFeature.UseTimes].ToString().Trim(); //使用次数
objRow[conTabFeature.OrderNum] = oRow[conTabFeature.OrderNum].ToString().Trim(); //序号
objRow[conTabFeature.IsNullable] = oRow[conTabFeature.IsNullable].ToString().Trim(); //是否可空
objRow[conTabFeature.InUse] = oRow[conTabFeature.InUse].ToString().Trim(); //是否在用
objRow[conTabFeature.CheckDate] = oRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objRow[conTabFeature.ToolTipText] = oRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objRow[conTabFeature.ErrMsg] = oRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objRow[conTabFeature.PrjId] = oRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objRow[conTabFeature.UpdUser] = oRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objRow[conTabFeature.UpdDate] = oRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objRow[conTabFeature.Memo] = oRow[conTabFeature.Memo].ToString().Trim(); //说明
 objDS.Tables[clsTabFeatureEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTabFeatureEN._CurrTabName);
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
 /// <param name = "objTabFeatureEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTabFeatureEN objTabFeatureEN)
{
 objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFeatureEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
strSQL = "Select * from TabFeature where TabFeatureId = " + "'"+ objTabFeatureEN.TabFeatureId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTabFeatureEN._CurrTabName);
if (objDS.Tables[clsTabFeatureEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TabFeatureId = " + "'"+ objTabFeatureEN.TabFeatureId+"'");
return false;
}
objRow = objDS.Tables[clsTabFeatureEN._CurrTabName].Rows[0];
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabFeatureId))
 {
objRow[conTabFeature.TabFeatureId] = objTabFeatureEN.TabFeatureId; //表功能Id
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabFeatureName))
 {
objRow[conTabFeature.TabFeatureName] = objTabFeatureEN.TabFeatureName; //表功能名
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabId))
 {
objRow[conTabFeature.TabId] = objTabFeatureEN.TabId; //表ID
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.FeatureId))
 {
objRow[conTabFeature.FeatureId] = objTabFeatureEN.FeatureId; //功能Id
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameCs))
 {
objRow[conTabFeature.FuncNameCs] = objTabFeatureEN.FuncNameCs; //Cs函数名
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsExtendedClass))
 {
objRow[conTabFeature.IsExtendedClass] = objTabFeatureEN.IsExtendedClass; //是否在扩展类
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameJs))
 {
objRow[conTabFeature.FuncNameJs] = objTabFeatureEN.FuncNameJs; //Js函数名
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.GetDdlDataFuncName4Ex))
 {
objRow[conTabFeature.GetDdlDataFuncName4Ex] = objTabFeatureEN.GetDdlDataFuncName4Ex; //获取Ddl函数名
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForCSharp))
 {
objRow[conTabFeature.IsForCSharp] = objTabFeatureEN.IsForCSharp; //是否ForCSharp
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForTypeScript))
 {
objRow[conTabFeature.IsForTypeScript] = objTabFeatureEN.IsForTypeScript; //是否ForTypeScript
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForDiv))
 {
objRow[conTabFeature.IsForDiv] = objTabFeatureEN.IsForDiv; //是否针对Div内控件
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNeedGC))
 {
objRow[conTabFeature.IsNeedGC] = objTabFeatureEN.IsNeedGC; //是否需要生成代码
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.UseTimes))
 {
objRow[conTabFeature.UseTimes] = objTabFeatureEN.UseTimes; //使用次数
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.OrderNum))
 {
objRow[conTabFeature.OrderNum] = objTabFeatureEN.OrderNum; //序号
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNullable))
 {
objRow[conTabFeature.IsNullable] = objTabFeatureEN.IsNullable; //是否可空
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.InUse))
 {
objRow[conTabFeature.InUse] = objTabFeatureEN.InUse; //是否在用
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.CheckDate))
 {
objRow[conTabFeature.CheckDate] = objTabFeatureEN.CheckDate; //检查日期
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.ToolTipText))
 {
objRow[conTabFeature.ToolTipText] = objTabFeatureEN.ToolTipText; //提示文字
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.ErrMsg))
 {
objRow[conTabFeature.ErrMsg] = objTabFeatureEN.ErrMsg; //错误信息
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.PrjId))
 {
objRow[conTabFeature.PrjId] = objTabFeatureEN.PrjId; //工程Id
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdUser))
 {
objRow[conTabFeature.UpdUser] = objTabFeatureEN.UpdUser; //修改者
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdDate))
 {
objRow[conTabFeature.UpdDate] = objTabFeatureEN.UpdDate; //修改日期
 }
 if (objTabFeatureEN.IsUpdated(conTabFeature.Memo))
 {
objRow[conTabFeature.Memo] = objTabFeatureEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsTabFeatureEN._CurrTabName);
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabFeatureEN objTabFeatureEN)
{
 objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TabFeature Set ");
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabFeatureName))
 {
 if (objTabFeatureEN.TabFeatureName !=  null)
 {
 var strTabFeatureName = objTabFeatureEN.TabFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureName, conTabFeature.TabFeatureName); //表功能名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.TabFeatureName); //表功能名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabId))
 {
 if (objTabFeatureEN.TabId  ==  "")
 {
 objTabFeatureEN.TabId = null;
 }
 if (objTabFeatureEN.TabId !=  null)
 {
 var strTabId = objTabFeatureEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conTabFeature.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.TabId); //表ID
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FeatureId))
 {
 if (objTabFeatureEN.FeatureId !=  null)
 {
 var strFeatureId = objTabFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureId, conTabFeature.FeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.FeatureId); //功能Id
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameCs))
 {
 if (objTabFeatureEN.FuncNameCs !=  null)
 {
 var strFuncNameCs = objTabFeatureEN.FuncNameCs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncNameCs, conTabFeature.FuncNameCs); //Cs函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.FuncNameCs); //Cs函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsExtendedClass))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsExtendedClass == true?"1":"0", conTabFeature.IsExtendedClass); //是否在扩展类
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameJs))
 {
 if (objTabFeatureEN.FuncNameJs !=  null)
 {
 var strFuncNameJs = objTabFeatureEN.FuncNameJs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncNameJs, conTabFeature.FuncNameJs); //Js函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.FuncNameJs); //Js函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.GetDdlDataFuncName4Ex))
 {
 if (objTabFeatureEN.GetDdlDataFuncName4Ex !=  null)
 {
 var strGetDdlDataFuncName4Ex = objTabFeatureEN.GetDdlDataFuncName4Ex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetDdlDataFuncName4Ex, conTabFeature.GetDdlDataFuncName4Ex); //获取Ddl函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.GetDdlDataFuncName4Ex); //获取Ddl函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForCSharp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsForCSharp == true?"1":"0", conTabFeature.IsForCSharp); //是否ForCSharp
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForTypeScript))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsForTypeScript == true?"1":"0", conTabFeature.IsForTypeScript); //是否ForTypeScript
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForDiv))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsForDiv == true?"1":"0", conTabFeature.IsForDiv); //是否针对Div内控件
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNeedGC))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsNeedGC == true?"1":"0", conTabFeature.IsNeedGC); //是否需要生成代码
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UseTimes))
 {
 if (objTabFeatureEN.UseTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFeatureEN.UseTimes, conTabFeature.UseTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.UseTimes); //使用次数
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.OrderNum))
 {
 if (objTabFeatureEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFeatureEN.OrderNum, conTabFeature.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.OrderNum); //序号
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNullable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsNullable == true?"1":"0", conTabFeature.IsNullable); //是否可空
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.InUse == true?"1":"0", conTabFeature.InUse); //是否在用
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.CheckDate))
 {
 if (objTabFeatureEN.CheckDate !=  null)
 {
 var strCheckDate = objTabFeatureEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDate, conTabFeature.CheckDate); //检查日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.CheckDate); //检查日期
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.ToolTipText))
 {
 if (objTabFeatureEN.ToolTipText !=  null)
 {
 var strToolTipText = objTabFeatureEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strToolTipText, conTabFeature.ToolTipText); //提示文字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.ToolTipText); //提示文字
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.ErrMsg))
 {
 if (objTabFeatureEN.ErrMsg !=  null)
 {
 var strErrMsg = objTabFeatureEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conTabFeature.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.ErrMsg); //错误信息
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.PrjId))
 {
 if (objTabFeatureEN.PrjId !=  null)
 {
 var strPrjId = objTabFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTabFeature.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.PrjId); //工程Id
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdUser))
 {
 if (objTabFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objTabFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTabFeature.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.UpdUser); //修改者
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdDate))
 {
 if (objTabFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objTabFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTabFeature.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.UpdDate); //修改日期
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.Memo))
 {
 if (objTabFeatureEN.Memo !=  null)
 {
 var strMemo = objTabFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabFeature.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TabFeatureId = '{0}'", objTabFeatureEN.TabFeatureId); 
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
 /// <param name = "objTabFeatureEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTabFeatureEN objTabFeatureEN, string strCondition)
{
 objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabFeature Set ");
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabFeatureName))
 {
 if (objTabFeatureEN.TabFeatureName !=  null)
 {
 var strTabFeatureName = objTabFeatureEN.TabFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureName = '{0}',", strTabFeatureName); //表功能名
 }
 else
 {
 sbSQL.Append(" TabFeatureName = null,"); //表功能名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabId))
 {
 if (objTabFeatureEN.TabId  ==  "")
 {
 objTabFeatureEN.TabId = null;
 }
 if (objTabFeatureEN.TabId !=  null)
 {
 var strTabId = objTabFeatureEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FeatureId))
 {
 if (objTabFeatureEN.FeatureId !=  null)
 {
 var strFeatureId = objTabFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureId = '{0}',", strFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" FeatureId = null,"); //功能Id
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameCs))
 {
 if (objTabFeatureEN.FuncNameCs !=  null)
 {
 var strFuncNameCs = objTabFeatureEN.FuncNameCs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncNameCs = '{0}',", strFuncNameCs); //Cs函数名
 }
 else
 {
 sbSQL.Append(" FuncNameCs = null,"); //Cs函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsExtendedClass))
 {
 sbSQL.AppendFormat(" IsExtendedClass = '{0}',", objTabFeatureEN.IsExtendedClass == true?"1":"0"); //是否在扩展类
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameJs))
 {
 if (objTabFeatureEN.FuncNameJs !=  null)
 {
 var strFuncNameJs = objTabFeatureEN.FuncNameJs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncNameJs = '{0}',", strFuncNameJs); //Js函数名
 }
 else
 {
 sbSQL.Append(" FuncNameJs = null,"); //Js函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.GetDdlDataFuncName4Ex))
 {
 if (objTabFeatureEN.GetDdlDataFuncName4Ex !=  null)
 {
 var strGetDdlDataFuncName4Ex = objTabFeatureEN.GetDdlDataFuncName4Ex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetDdlDataFuncName4Ex = '{0}',", strGetDdlDataFuncName4Ex); //获取Ddl函数名
 }
 else
 {
 sbSQL.Append(" GetDdlDataFuncName4Ex = null,"); //获取Ddl函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForCSharp))
 {
 sbSQL.AppendFormat(" IsForCSharp = '{0}',", objTabFeatureEN.IsForCSharp == true?"1":"0"); //是否ForCSharp
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForTypeScript))
 {
 sbSQL.AppendFormat(" IsForTypeScript = '{0}',", objTabFeatureEN.IsForTypeScript == true?"1":"0"); //是否ForTypeScript
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForDiv))
 {
 sbSQL.AppendFormat(" IsForDiv = '{0}',", objTabFeatureEN.IsForDiv == true?"1":"0"); //是否针对Div内控件
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNeedGC))
 {
 sbSQL.AppendFormat(" IsNeedGC = '{0}',", objTabFeatureEN.IsNeedGC == true?"1":"0"); //是否需要生成代码
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UseTimes))
 {
 if (objTabFeatureEN.UseTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFeatureEN.UseTimes, conTabFeature.UseTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.UseTimes); //使用次数
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.OrderNum))
 {
 if (objTabFeatureEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFeatureEN.OrderNum, conTabFeature.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.OrderNum); //序号
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNullable))
 {
 sbSQL.AppendFormat(" IsNullable = '{0}',", objTabFeatureEN.IsNullable == true?"1":"0"); //是否可空
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objTabFeatureEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.CheckDate))
 {
 if (objTabFeatureEN.CheckDate !=  null)
 {
 var strCheckDate = objTabFeatureEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDate = '{0}',", strCheckDate); //检查日期
 }
 else
 {
 sbSQL.Append(" CheckDate = null,"); //检查日期
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.ToolTipText))
 {
 if (objTabFeatureEN.ToolTipText !=  null)
 {
 var strToolTipText = objTabFeatureEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ToolTipText = '{0}',", strToolTipText); //提示文字
 }
 else
 {
 sbSQL.Append(" ToolTipText = null,"); //提示文字
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.ErrMsg))
 {
 if (objTabFeatureEN.ErrMsg !=  null)
 {
 var strErrMsg = objTabFeatureEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.PrjId))
 {
 if (objTabFeatureEN.PrjId !=  null)
 {
 var strPrjId = objTabFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdUser))
 {
 if (objTabFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objTabFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdDate))
 {
 if (objTabFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objTabFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.Memo))
 {
 if (objTabFeatureEN.Memo !=  null)
 {
 var strMemo = objTabFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTabFeatureEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTabFeatureEN objTabFeatureEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabFeature Set ");
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabFeatureName))
 {
 if (objTabFeatureEN.TabFeatureName !=  null)
 {
 var strTabFeatureName = objTabFeatureEN.TabFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureName = '{0}',", strTabFeatureName); //表功能名
 }
 else
 {
 sbSQL.Append(" TabFeatureName = null,"); //表功能名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabId))
 {
 if (objTabFeatureEN.TabId  ==  "")
 {
 objTabFeatureEN.TabId = null;
 }
 if (objTabFeatureEN.TabId !=  null)
 {
 var strTabId = objTabFeatureEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FeatureId))
 {
 if (objTabFeatureEN.FeatureId !=  null)
 {
 var strFeatureId = objTabFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureId = '{0}',", strFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" FeatureId = null,"); //功能Id
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameCs))
 {
 if (objTabFeatureEN.FuncNameCs !=  null)
 {
 var strFuncNameCs = objTabFeatureEN.FuncNameCs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncNameCs = '{0}',", strFuncNameCs); //Cs函数名
 }
 else
 {
 sbSQL.Append(" FuncNameCs = null,"); //Cs函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsExtendedClass))
 {
 sbSQL.AppendFormat(" IsExtendedClass = '{0}',", objTabFeatureEN.IsExtendedClass == true?"1":"0"); //是否在扩展类
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameJs))
 {
 if (objTabFeatureEN.FuncNameJs !=  null)
 {
 var strFuncNameJs = objTabFeatureEN.FuncNameJs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncNameJs = '{0}',", strFuncNameJs); //Js函数名
 }
 else
 {
 sbSQL.Append(" FuncNameJs = null,"); //Js函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.GetDdlDataFuncName4Ex))
 {
 if (objTabFeatureEN.GetDdlDataFuncName4Ex !=  null)
 {
 var strGetDdlDataFuncName4Ex = objTabFeatureEN.GetDdlDataFuncName4Ex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetDdlDataFuncName4Ex = '{0}',", strGetDdlDataFuncName4Ex); //获取Ddl函数名
 }
 else
 {
 sbSQL.Append(" GetDdlDataFuncName4Ex = null,"); //获取Ddl函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForCSharp))
 {
 sbSQL.AppendFormat(" IsForCSharp = '{0}',", objTabFeatureEN.IsForCSharp == true?"1":"0"); //是否ForCSharp
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForTypeScript))
 {
 sbSQL.AppendFormat(" IsForTypeScript = '{0}',", objTabFeatureEN.IsForTypeScript == true?"1":"0"); //是否ForTypeScript
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForDiv))
 {
 sbSQL.AppendFormat(" IsForDiv = '{0}',", objTabFeatureEN.IsForDiv == true?"1":"0"); //是否针对Div内控件
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNeedGC))
 {
 sbSQL.AppendFormat(" IsNeedGC = '{0}',", objTabFeatureEN.IsNeedGC == true?"1":"0"); //是否需要生成代码
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UseTimes))
 {
 if (objTabFeatureEN.UseTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFeatureEN.UseTimes, conTabFeature.UseTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.UseTimes); //使用次数
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.OrderNum))
 {
 if (objTabFeatureEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFeatureEN.OrderNum, conTabFeature.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.OrderNum); //序号
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNullable))
 {
 sbSQL.AppendFormat(" IsNullable = '{0}',", objTabFeatureEN.IsNullable == true?"1":"0"); //是否可空
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objTabFeatureEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.CheckDate))
 {
 if (objTabFeatureEN.CheckDate !=  null)
 {
 var strCheckDate = objTabFeatureEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDate = '{0}',", strCheckDate); //检查日期
 }
 else
 {
 sbSQL.Append(" CheckDate = null,"); //检查日期
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.ToolTipText))
 {
 if (objTabFeatureEN.ToolTipText !=  null)
 {
 var strToolTipText = objTabFeatureEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ToolTipText = '{0}',", strToolTipText); //提示文字
 }
 else
 {
 sbSQL.Append(" ToolTipText = null,"); //提示文字
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.ErrMsg))
 {
 if (objTabFeatureEN.ErrMsg !=  null)
 {
 var strErrMsg = objTabFeatureEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.PrjId))
 {
 if (objTabFeatureEN.PrjId !=  null)
 {
 var strPrjId = objTabFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdUser))
 {
 if (objTabFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objTabFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdDate))
 {
 if (objTabFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objTabFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.Memo))
 {
 if (objTabFeatureEN.Memo !=  null)
 {
 var strMemo = objTabFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabFeatureEN objTabFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFeatureEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFeatureEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabFeature Set ");
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabFeatureName))
 {
 if (objTabFeatureEN.TabFeatureName !=  null)
 {
 var strTabFeatureName = objTabFeatureEN.TabFeatureName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureName, conTabFeature.TabFeatureName); //表功能名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.TabFeatureName); //表功能名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.TabId))
 {
 if (objTabFeatureEN.TabId  ==  "")
 {
 objTabFeatureEN.TabId = null;
 }
 if (objTabFeatureEN.TabId !=  null)
 {
 var strTabId = objTabFeatureEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conTabFeature.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.TabId); //表ID
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FeatureId))
 {
 if (objTabFeatureEN.FeatureId !=  null)
 {
 var strFeatureId = objTabFeatureEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureId, conTabFeature.FeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.FeatureId); //功能Id
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameCs))
 {
 if (objTabFeatureEN.FuncNameCs !=  null)
 {
 var strFuncNameCs = objTabFeatureEN.FuncNameCs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncNameCs, conTabFeature.FuncNameCs); //Cs函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.FuncNameCs); //Cs函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsExtendedClass))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsExtendedClass == true?"1":"0", conTabFeature.IsExtendedClass); //是否在扩展类
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.FuncNameJs))
 {
 if (objTabFeatureEN.FuncNameJs !=  null)
 {
 var strFuncNameJs = objTabFeatureEN.FuncNameJs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncNameJs, conTabFeature.FuncNameJs); //Js函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.FuncNameJs); //Js函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.GetDdlDataFuncName4Ex))
 {
 if (objTabFeatureEN.GetDdlDataFuncName4Ex !=  null)
 {
 var strGetDdlDataFuncName4Ex = objTabFeatureEN.GetDdlDataFuncName4Ex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetDdlDataFuncName4Ex, conTabFeature.GetDdlDataFuncName4Ex); //获取Ddl函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.GetDdlDataFuncName4Ex); //获取Ddl函数名
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForCSharp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsForCSharp == true?"1":"0", conTabFeature.IsForCSharp); //是否ForCSharp
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForTypeScript))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsForTypeScript == true?"1":"0", conTabFeature.IsForTypeScript); //是否ForTypeScript
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsForDiv))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsForDiv == true?"1":"0", conTabFeature.IsForDiv); //是否针对Div内控件
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNeedGC))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsNeedGC == true?"1":"0", conTabFeature.IsNeedGC); //是否需要生成代码
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UseTimes))
 {
 if (objTabFeatureEN.UseTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFeatureEN.UseTimes, conTabFeature.UseTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.UseTimes); //使用次数
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.OrderNum))
 {
 if (objTabFeatureEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFeatureEN.OrderNum, conTabFeature.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.OrderNum); //序号
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.IsNullable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.IsNullable == true?"1":"0", conTabFeature.IsNullable); //是否可空
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFeatureEN.InUse == true?"1":"0", conTabFeature.InUse); //是否在用
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.CheckDate))
 {
 if (objTabFeatureEN.CheckDate !=  null)
 {
 var strCheckDate = objTabFeatureEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDate, conTabFeature.CheckDate); //检查日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.CheckDate); //检查日期
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.ToolTipText))
 {
 if (objTabFeatureEN.ToolTipText !=  null)
 {
 var strToolTipText = objTabFeatureEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strToolTipText, conTabFeature.ToolTipText); //提示文字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.ToolTipText); //提示文字
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.ErrMsg))
 {
 if (objTabFeatureEN.ErrMsg !=  null)
 {
 var strErrMsg = objTabFeatureEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conTabFeature.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.ErrMsg); //错误信息
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.PrjId))
 {
 if (objTabFeatureEN.PrjId !=  null)
 {
 var strPrjId = objTabFeatureEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTabFeature.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.PrjId); //工程Id
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdUser))
 {
 if (objTabFeatureEN.UpdUser !=  null)
 {
 var strUpdUser = objTabFeatureEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTabFeature.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.UpdUser); //修改者
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.UpdDate))
 {
 if (objTabFeatureEN.UpdDate !=  null)
 {
 var strUpdDate = objTabFeatureEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTabFeature.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.UpdDate); //修改日期
 }
 }
 
 if (objTabFeatureEN.IsUpdated(conTabFeature.Memo))
 {
 if (objTabFeatureEN.Memo !=  null)
 {
 var strMemo = objTabFeatureEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabFeature.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFeature.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TabFeatureId = '{0}'", objTabFeatureEN.TabFeatureId); 
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
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTabFeatureId) 
{
CheckPrimaryKey(strTabFeatureId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTabFeatureId,
};
 objSQL.ExecSP("TabFeature_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTabFeatureId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTabFeatureId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
//删除TabFeature本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabFeature where TabFeatureId = " + "'"+ strTabFeatureId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTabFeature(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
//删除TabFeature本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabFeature where TabFeatureId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTabFeatureId) 
{
CheckPrimaryKey(strTabFeatureId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
//删除TabFeature本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabFeature where TabFeatureId = " + "'"+ strTabFeatureId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTabFeature(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTabFeatureDA: DelTabFeature)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabFeature where " + strCondition ;
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
public bool DelTabFeatureWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTabFeatureDA: DelTabFeatureWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabFeature where " + strCondition ;
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
 /// <param name = "objTabFeatureENS">源对象</param>
 /// <param name = "objTabFeatureENT">目标对象</param>
public void CopyTo(clsTabFeatureEN objTabFeatureENS, clsTabFeatureEN objTabFeatureENT)
{
objTabFeatureENT.TabFeatureId = objTabFeatureENS.TabFeatureId; //表功能Id
objTabFeatureENT.TabFeatureName = objTabFeatureENS.TabFeatureName; //表功能名
objTabFeatureENT.TabId = objTabFeatureENS.TabId; //表ID
objTabFeatureENT.FeatureId = objTabFeatureENS.FeatureId; //功能Id
objTabFeatureENT.FuncNameCs = objTabFeatureENS.FuncNameCs; //Cs函数名
objTabFeatureENT.IsExtendedClass = objTabFeatureENS.IsExtendedClass; //是否在扩展类
objTabFeatureENT.FuncNameJs = objTabFeatureENS.FuncNameJs; //Js函数名
objTabFeatureENT.GetDdlDataFuncName4Ex = objTabFeatureENS.GetDdlDataFuncName4Ex; //获取Ddl函数名
objTabFeatureENT.IsForCSharp = objTabFeatureENS.IsForCSharp; //是否ForCSharp
objTabFeatureENT.IsForTypeScript = objTabFeatureENS.IsForTypeScript; //是否ForTypeScript
objTabFeatureENT.IsForDiv = objTabFeatureENS.IsForDiv; //是否针对Div内控件
objTabFeatureENT.IsNeedGC = objTabFeatureENS.IsNeedGC; //是否需要生成代码
objTabFeatureENT.UseTimes = objTabFeatureENS.UseTimes; //使用次数
objTabFeatureENT.OrderNum = objTabFeatureENS.OrderNum; //序号
objTabFeatureENT.IsNullable = objTabFeatureENS.IsNullable; //是否可空
objTabFeatureENT.InUse = objTabFeatureENS.InUse; //是否在用
objTabFeatureENT.CheckDate = objTabFeatureENS.CheckDate; //检查日期
objTabFeatureENT.ToolTipText = objTabFeatureENS.ToolTipText; //提示文字
objTabFeatureENT.ErrMsg = objTabFeatureENS.ErrMsg; //错误信息
objTabFeatureENT.PrjId = objTabFeatureENS.PrjId; //工程Id
objTabFeatureENT.UpdUser = objTabFeatureENS.UpdUser; //修改者
objTabFeatureENT.UpdDate = objTabFeatureENS.UpdDate; //修改日期
objTabFeatureENT.Memo = objTabFeatureENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTabFeatureEN objTabFeatureEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTabFeatureEN.TabFeatureName, conTabFeature.TabFeatureName);
clsCheckSql.CheckFieldNotNull(objTabFeatureEN.TabId, conTabFeature.TabId);
clsCheckSql.CheckFieldNotNull(objTabFeatureEN.FeatureId, conTabFeature.FeatureId);
clsCheckSql.CheckFieldNotNull(objTabFeatureEN.PrjId, conTabFeature.PrjId);
clsCheckSql.CheckFieldNotNull(objTabFeatureEN.UpdUser, conTabFeature.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objTabFeatureEN.TabFeatureId, 8, conTabFeature.TabFeatureId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.TabFeatureName, 100, conTabFeature.TabFeatureName);
clsCheckSql.CheckFieldLen(objTabFeatureEN.TabId, 8, conTabFeature.TabId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.FeatureId, 4, conTabFeature.FeatureId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.FuncNameCs, 100, conTabFeature.FuncNameCs);
clsCheckSql.CheckFieldLen(objTabFeatureEN.FuncNameJs, 100, conTabFeature.FuncNameJs);
clsCheckSql.CheckFieldLen(objTabFeatureEN.GetDdlDataFuncName4Ex, 100, conTabFeature.GetDdlDataFuncName4Ex);
clsCheckSql.CheckFieldLen(objTabFeatureEN.CheckDate, 20, conTabFeature.CheckDate);
clsCheckSql.CheckFieldLen(objTabFeatureEN.ToolTipText, 150, conTabFeature.ToolTipText);
clsCheckSql.CheckFieldLen(objTabFeatureEN.ErrMsg, 2000, conTabFeature.ErrMsg);
clsCheckSql.CheckFieldLen(objTabFeatureEN.PrjId, 4, conTabFeature.PrjId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.UpdUser, 20, conTabFeature.UpdUser);
clsCheckSql.CheckFieldLen(objTabFeatureEN.UpdDate, 20, conTabFeature.UpdDate);
clsCheckSql.CheckFieldLen(objTabFeatureEN.Memo, 1000, conTabFeature.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objTabFeatureEN.TabId, 8, conTabFeature.TabId);
 objTabFeatureEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTabFeatureEN objTabFeatureEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabFeatureEN.TabFeatureName, 100, conTabFeature.TabFeatureName);
clsCheckSql.CheckFieldLen(objTabFeatureEN.TabId, 8, conTabFeature.TabId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.FeatureId, 4, conTabFeature.FeatureId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.FuncNameCs, 100, conTabFeature.FuncNameCs);
clsCheckSql.CheckFieldLen(objTabFeatureEN.FuncNameJs, 100, conTabFeature.FuncNameJs);
clsCheckSql.CheckFieldLen(objTabFeatureEN.GetDdlDataFuncName4Ex, 100, conTabFeature.GetDdlDataFuncName4Ex);
clsCheckSql.CheckFieldLen(objTabFeatureEN.CheckDate, 20, conTabFeature.CheckDate);
clsCheckSql.CheckFieldLen(objTabFeatureEN.ToolTipText, 150, conTabFeature.ToolTipText);
clsCheckSql.CheckFieldLen(objTabFeatureEN.ErrMsg, 2000, conTabFeature.ErrMsg);
clsCheckSql.CheckFieldLen(objTabFeatureEN.PrjId, 4, conTabFeature.PrjId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.UpdUser, 20, conTabFeature.UpdUser);
clsCheckSql.CheckFieldLen(objTabFeatureEN.UpdDate, 20, conTabFeature.UpdDate);
clsCheckSql.CheckFieldLen(objTabFeatureEN.Memo, 1000, conTabFeature.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTabFeatureEN.TabId, 8, conTabFeature.TabId);
 objTabFeatureEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTabFeatureEN objTabFeatureEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabFeatureEN.TabFeatureId, 8, conTabFeature.TabFeatureId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.TabFeatureName, 100, conTabFeature.TabFeatureName);
clsCheckSql.CheckFieldLen(objTabFeatureEN.TabId, 8, conTabFeature.TabId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.FeatureId, 4, conTabFeature.FeatureId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.FuncNameCs, 100, conTabFeature.FuncNameCs);
clsCheckSql.CheckFieldLen(objTabFeatureEN.FuncNameJs, 100, conTabFeature.FuncNameJs);
clsCheckSql.CheckFieldLen(objTabFeatureEN.GetDdlDataFuncName4Ex, 100, conTabFeature.GetDdlDataFuncName4Ex);
clsCheckSql.CheckFieldLen(objTabFeatureEN.CheckDate, 20, conTabFeature.CheckDate);
clsCheckSql.CheckFieldLen(objTabFeatureEN.ToolTipText, 150, conTabFeature.ToolTipText);
clsCheckSql.CheckFieldLen(objTabFeatureEN.ErrMsg, 2000, conTabFeature.ErrMsg);
clsCheckSql.CheckFieldLen(objTabFeatureEN.PrjId, 4, conTabFeature.PrjId);
clsCheckSql.CheckFieldLen(objTabFeatureEN.UpdUser, 20, conTabFeature.UpdUser);
clsCheckSql.CheckFieldLen(objTabFeatureEN.UpdDate, 20, conTabFeature.UpdDate);
clsCheckSql.CheckFieldLen(objTabFeatureEN.Memo, 1000, conTabFeature.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.TabFeatureId, conTabFeature.TabFeatureId);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.TabFeatureName, conTabFeature.TabFeatureName);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.TabId, conTabFeature.TabId);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.FeatureId, conTabFeature.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.FuncNameCs, conTabFeature.FuncNameCs);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.FuncNameJs, conTabFeature.FuncNameJs);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.GetDdlDataFuncName4Ex, conTabFeature.GetDdlDataFuncName4Ex);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.CheckDate, conTabFeature.CheckDate);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.ToolTipText, conTabFeature.ToolTipText);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.ErrMsg, conTabFeature.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.PrjId, conTabFeature.PrjId);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.UpdUser, conTabFeature.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.UpdDate, conTabFeature.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTabFeatureEN.Memo, conTabFeature.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTabFeatureEN.TabId, 8, conTabFeature.TabId);
 objTabFeatureEN._IsCheckProperty = true;
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
string strSQL = "select TabFeatureId, TabFeatureName from TabFeature ";
 clsSpecSQLforSql mySql = clsTabFeatureDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TabFeature(表功能),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabFeatureEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTabFeatureEN objTabFeatureEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and TabFeatureName = '{0}'", objTabFeatureEN.TabFeatureName);
return sbCondition.ToString();
}
 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TabFeature(表功能),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabFeatureEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr_V2(clsTabFeatureEN objTabFeatureEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 if (objTabFeatureEN.FuncNameCs == null)
{
 sbCondition.AppendFormat(" and FuncNameCs is null");
}
else
{
 sbCondition.AppendFormat(" and FuncNameCs = '{0}'", objTabFeatureEN.FuncNameCs);
}
 if (objTabFeatureEN.FuncNameJs == null)
{
 sbCondition.AppendFormat(" and FuncNameJs is null");
}
else
{
 sbCondition.AppendFormat(" and FuncNameJs = '{0}'", objTabFeatureEN.FuncNameJs);
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
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabFeatureEN._CurrTabName);
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
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabFeatureEN._CurrTabName, strCondition);
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
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
 objSQL = clsTabFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}