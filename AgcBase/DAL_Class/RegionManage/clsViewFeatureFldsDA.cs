
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewFeatureFldsDA
 表名:ViewFeatureFlds(00050453)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:46
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
 /// 界面功能字段(ViewFeatureFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewFeatureFldsDA : clsCommBase4DA
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
 return clsViewFeatureFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewFeatureFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewFeatureFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewFeatureFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewFeatureFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewFeatureFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetDataTable_ViewFeatureFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewFeatureFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewFeatureFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewFeatureFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewFeatureFlds.* " + 
$"from ViewFeatureFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewFeatureFlds.mId not in " + 
$"(Select top {intTop_In} ViewFeatureFlds.mId from ViewFeatureFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewFeatureFlds where {1} and mId not in (Select top {2} mId from ViewFeatureFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewFeatureFlds where {1} and mId not in (Select top {3} mId from ViewFeatureFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewFeatureFlds.* " + 
$"from ViewFeatureFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewFeatureFlds.mId not in " + 
$"(Select top {intTop_In} ViewFeatureFlds.mId from ViewFeatureFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewFeatureFlds where {1} and mId not in (Select top {2} mId from ViewFeatureFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewFeatureFlds where {1} and mId not in (Select top {3} mId from ViewFeatureFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewFeatureFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA:GetObjLst)", objException.Message));
}
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = TransNullToInt(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = TransNullToBool(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewFeatureFldsDA: GetObjLst)", objException.Message));
}
objViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewFeatureFldsEN);
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
public List<clsViewFeatureFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = TransNullToInt(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = TransNullToBool(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewFeatureFldsDA: GetObjLst)", objException.Message));
}
objViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewFeatureFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewFeatureFlds(ref clsViewFeatureFldsEN objViewFeatureFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where mId = " + ""+ objViewFeatureFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewFeatureFldsEN.mId = TransNullToInt(objDT.Rows[0][conViewFeatureFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewFeatureFldsEN.ViewFeatureId = objDT.Rows[0][conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objViewFeatureFldsEN.FieldTypeId = objDT.Rows[0][conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objViewFeatureFldsEN.ReleFldId = objDT.Rows[0][conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.FuncName = objDT.Rows[0][conViewFeatureFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objViewFeatureFldsEN.LabelCaption = objDT.Rows[0][conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objViewFeatureFldsEN.CtlTypeId = objDT.Rows[0][conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objViewFeatureFldsEN.VarId = objDT.Rows[0][conViewFeatureFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.CtrlId = objDT.Rows[0][conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id(字段类型:varchar,字段长度:50,是否可空:False)
 objViewFeatureFldsEN.DefaultValue = objDT.Rows[0][conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objViewFeatureFldsEN.OrderNum = TransNullToInt(objDT.Rows[0][conViewFeatureFlds.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objViewFeatureFldsEN.CssClass = objDT.Rows[0][conViewFeatureFlds.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objViewFeatureFldsEN.DdlItemsOptionId = objDT.Rows[0][conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objViewFeatureFldsEN.DsTabId = objDT.Rows[0][conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewFeatureFldsEN.FldIdCond2 = objDT.Rows[0][conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.FldIdCond1 = objDT.Rows[0][conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.VarIdCond2 = objDT.Rows[0][conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.VarIdCond1 = objDT.Rows[0][conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.TabFeatureId4Ddl = objDT.Rows[0][conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.ViewImplId = objDT.Rows[0][conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objViewFeatureFldsEN.Text = objDT.Rows[0][conViewFeatureFlds.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objViewFeatureFldsEN.DsCondStr = objDT.Rows[0][conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objViewFeatureFldsEN.DsSqlStr = objDT.Rows[0][conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewFeatureFldsEN.ItemsString = objDT.Rows[0][conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewFeatureFldsEN.PrjId = objDT.Rows[0][conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewFeatureFldsEN.UpdUser = objDT.Rows[0][conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewFeatureFldsEN.UpdDate = objDT.Rows[0][conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewFeatureFldsEN.InUse = TransNullToBool(objDT.Rows[0][conViewFeatureFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objViewFeatureFldsEN.Memo = objDT.Rows[0][conViewFeatureFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewFeatureFldsDA: GetViewFeatureFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewFeatureFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
 objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id(字段类型:varchar,字段长度:50,是否可空:False)
 objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewFeatureFldsDA: GetObjBymId)", objException.Message));
}
return objViewFeatureFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewFeatureFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN()
{
mId = TransNullToInt(objRow[conViewFeatureFlds.mId].ToString().Trim()), //mId
ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(), //界面功能Id
FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(), //字段类型Id
ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(), //相关字段Id
FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(), //函数名
LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(), //标签标题
CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(), //控件类型号
VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(), //变量Id
CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(), //控件Id
DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(), //缺省值
OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()), //序号
CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(), //样式表
DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(), //下拉框列表选项ID
DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(), //数据源表ID
FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(), //字段Id_条件2
FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(), //字段Id_条件1
VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(), //数据源字段_条件1
VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(), //变量Id_条件1
TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(), //下拉框表功能Id
ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(), //界面实现Id
Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(), //文本
DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(), //数据源条件串
DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(), //数据源SQL串
ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(), //列表项串
PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(), //修改日期
InUse = TransNullToBool(objRow[conViewFeatureFlds.InUse].ToString().Trim()), //是否在用
Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim() //说明
};
objViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewFeatureFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewFeatureFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewFeatureFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = TransNullToInt(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = TransNullToBool(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewFeatureFldsDA: GetObjByDataRowViewFeatureFlds)", objException.Message));
}
objViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewFeatureFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewFeatureFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = TransNullToInt(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = TransNullToBool(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewFeatureFldsDA: GetObjByDataRow)", objException.Message));
}
objViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewFeatureFldsEN;
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
objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewFeatureFldsEN._CurrTabName, conViewFeatureFlds.mId, 8, "");
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
objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewFeatureFldsEN._CurrTabName, conViewFeatureFlds.mId, 8, strPrefix);
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ViewFeatureFlds where " + strCondition;
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ViewFeatureFlds where " + strCondition;
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewFeatureFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewFeatureFlds", strCondition))
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
objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewFeatureFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewFeatureFldsEN objViewFeatureFldsEN)
 {
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewFeatureFldsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewFeatureFlds");
objRow = objDS.Tables["ViewFeatureFlds"].NewRow();
objRow[conViewFeatureFlds.ViewFeatureId] = objViewFeatureFldsEN.ViewFeatureId; //界面功能Id
objRow[conViewFeatureFlds.FieldTypeId] = objViewFeatureFldsEN.FieldTypeId; //字段类型Id
 if (objViewFeatureFldsEN.ReleFldId !=  "")
 {
objRow[conViewFeatureFlds.ReleFldId] = objViewFeatureFldsEN.ReleFldId; //相关字段Id
 }
 if (objViewFeatureFldsEN.FuncName !=  "")
 {
objRow[conViewFeatureFlds.FuncName] = objViewFeatureFldsEN.FuncName; //函数名
 }
 if (objViewFeatureFldsEN.LabelCaption !=  "")
 {
objRow[conViewFeatureFlds.LabelCaption] = objViewFeatureFldsEN.LabelCaption; //标签标题
 }
 if (objViewFeatureFldsEN.CtlTypeId !=  "")
 {
objRow[conViewFeatureFlds.CtlTypeId] = objViewFeatureFldsEN.CtlTypeId; //控件类型号
 }
 if (objViewFeatureFldsEN.VarId !=  "")
 {
objRow[conViewFeatureFlds.VarId] = objViewFeatureFldsEN.VarId; //变量Id
 }
 if (objViewFeatureFldsEN.CtrlId !=  "")
 {
objRow[conViewFeatureFlds.CtrlId] = objViewFeatureFldsEN.CtrlId; //控件Id
 }
 if (objViewFeatureFldsEN.DefaultValue !=  "")
 {
objRow[conViewFeatureFlds.DefaultValue] = objViewFeatureFldsEN.DefaultValue; //缺省值
 }
objRow[conViewFeatureFlds.OrderNum] = objViewFeatureFldsEN.OrderNum; //序号
 if (objViewFeatureFldsEN.CssClass !=  "")
 {
objRow[conViewFeatureFlds.CssClass] = objViewFeatureFldsEN.CssClass; //样式表
 }
 if (objViewFeatureFldsEN.DdlItemsOptionId !=  "")
 {
objRow[conViewFeatureFlds.DdlItemsOptionId] = objViewFeatureFldsEN.DdlItemsOptionId; //下拉框列表选项ID
 }
 if (objViewFeatureFldsEN.DsTabId !=  "")
 {
objRow[conViewFeatureFlds.DsTabId] = objViewFeatureFldsEN.DsTabId; //数据源表ID
 }
 if (objViewFeatureFldsEN.FldIdCond2 !=  "")
 {
objRow[conViewFeatureFlds.FldIdCond2] = objViewFeatureFldsEN.FldIdCond2; //字段Id_条件2
 }
 if (objViewFeatureFldsEN.FldIdCond1 !=  "")
 {
objRow[conViewFeatureFlds.FldIdCond1] = objViewFeatureFldsEN.FldIdCond1; //字段Id_条件1
 }
 if (objViewFeatureFldsEN.VarIdCond2 !=  "")
 {
objRow[conViewFeatureFlds.VarIdCond2] = objViewFeatureFldsEN.VarIdCond2; //数据源字段_条件1
 }
 if (objViewFeatureFldsEN.VarIdCond1 !=  "")
 {
objRow[conViewFeatureFlds.VarIdCond1] = objViewFeatureFldsEN.VarIdCond1; //变量Id_条件1
 }
 if (objViewFeatureFldsEN.TabFeatureId4Ddl !=  "")
 {
objRow[conViewFeatureFlds.TabFeatureId4Ddl] = objViewFeatureFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
 }
 if (objViewFeatureFldsEN.ViewImplId !=  "")
 {
objRow[conViewFeatureFlds.ViewImplId] = objViewFeatureFldsEN.ViewImplId; //界面实现Id
 }
 if (objViewFeatureFldsEN.Text !=  "")
 {
objRow[conViewFeatureFlds.Text] = objViewFeatureFldsEN.Text; //文本
 }
 if (objViewFeatureFldsEN.DsCondStr !=  "")
 {
objRow[conViewFeatureFlds.DsCondStr] = objViewFeatureFldsEN.DsCondStr; //数据源条件串
 }
 if (objViewFeatureFldsEN.DsSqlStr !=  "")
 {
objRow[conViewFeatureFlds.DsSqlStr] = objViewFeatureFldsEN.DsSqlStr; //数据源SQL串
 }
 if (objViewFeatureFldsEN.ItemsString !=  "")
 {
objRow[conViewFeatureFlds.ItemsString] = objViewFeatureFldsEN.ItemsString; //列表项串
 }
objRow[conViewFeatureFlds.PrjId] = objViewFeatureFldsEN.PrjId; //工程Id
objRow[conViewFeatureFlds.UpdUser] = objViewFeatureFldsEN.UpdUser; //修改者
 if (objViewFeatureFldsEN.UpdDate !=  "")
 {
objRow[conViewFeatureFlds.UpdDate] = objViewFeatureFldsEN.UpdDate; //修改日期
 }
objRow[conViewFeatureFlds.InUse] = objViewFeatureFldsEN.InUse; //是否在用
 if (objViewFeatureFldsEN.Memo !=  "")
 {
objRow[conViewFeatureFlds.Memo] = objViewFeatureFldsEN.Memo; //说明
 }
objDS.Tables[clsViewFeatureFldsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewFeatureFldsEN._CurrTabName);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewFeatureFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewFeatureFldsEN.ViewFeatureId  ==  "")
 {
 objViewFeatureFldsEN.ViewFeatureId = null;
 }
 if (objViewFeatureFldsEN.ViewFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ViewFeatureId);
 var strViewFeatureId = objViewFeatureFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFeatureId + "'");
 }
 
 if (objViewFeatureFldsEN.FieldTypeId  ==  "")
 {
 objViewFeatureFldsEN.FieldTypeId = null;
 }
 if (objViewFeatureFldsEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FieldTypeId);
 var strFieldTypeId = objViewFeatureFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objViewFeatureFldsEN.ReleFldId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ReleFldId);
 var strReleFldId = objViewFeatureFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleFldId + "'");
 }
 
 if (objViewFeatureFldsEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FuncName);
 var strFuncName = objViewFeatureFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objViewFeatureFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.LabelCaption);
 var strLabelCaption = objViewFeatureFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objViewFeatureFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CtlTypeId);
 var strCtlTypeId = objViewFeatureFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objViewFeatureFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarId);
 var strVarId = objViewFeatureFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objViewFeatureFldsEN.CtrlId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CtrlId);
 var strCtrlId = objViewFeatureFldsEN.CtrlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtrlId + "'");
 }
 
 if (objViewFeatureFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DefaultValue);
 var strDefaultValue = objViewFeatureFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objViewFeatureFldsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.OrderNum);
 arrValueListForInsert.Add(objViewFeatureFldsEN.OrderNum.ToString());
 }
 
 if (objViewFeatureFldsEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CssClass);
 var strCssClass = objViewFeatureFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objViewFeatureFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objViewFeatureFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objViewFeatureFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsTabId);
 var strDsTabId = objViewFeatureFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objViewFeatureFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FldIdCond2);
 var strFldIdCond2 = objViewFeatureFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objViewFeatureFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FldIdCond1);
 var strFldIdCond1 = objViewFeatureFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objViewFeatureFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarIdCond2);
 var strVarIdCond2 = objViewFeatureFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objViewFeatureFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarIdCond1);
 var strVarIdCond1 = objViewFeatureFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objViewFeatureFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objViewFeatureFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objViewFeatureFldsEN.ViewImplId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ViewImplId);
 var strViewImplId = objViewFeatureFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewImplId + "'");
 }
 
 if (objViewFeatureFldsEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.Text);
 var strText = objViewFeatureFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objViewFeatureFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsCondStr);
 var strDsCondStr = objViewFeatureFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objViewFeatureFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsSqlStr);
 var strDsSqlStr = objViewFeatureFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objViewFeatureFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ItemsString);
 var strItemsString = objViewFeatureFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objViewFeatureFldsEN.PrjId  ==  "")
 {
 objViewFeatureFldsEN.PrjId = null;
 }
 if (objViewFeatureFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.PrjId);
 var strPrjId = objViewFeatureFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewFeatureFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.UpdUser);
 var strUpdUser = objViewFeatureFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewFeatureFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.UpdDate);
 var strUpdDate = objViewFeatureFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conViewFeatureFlds.InUse);
 arrValueListForInsert.Add("'" + (objViewFeatureFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objViewFeatureFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.Memo);
 var strMemo = objViewFeatureFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewFeatureFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewFeatureFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewFeatureFldsEN.ViewFeatureId  ==  "")
 {
 objViewFeatureFldsEN.ViewFeatureId = null;
 }
 if (objViewFeatureFldsEN.ViewFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ViewFeatureId);
 var strViewFeatureId = objViewFeatureFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFeatureId + "'");
 }
 
 if (objViewFeatureFldsEN.FieldTypeId  ==  "")
 {
 objViewFeatureFldsEN.FieldTypeId = null;
 }
 if (objViewFeatureFldsEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FieldTypeId);
 var strFieldTypeId = objViewFeatureFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objViewFeatureFldsEN.ReleFldId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ReleFldId);
 var strReleFldId = objViewFeatureFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleFldId + "'");
 }
 
 if (objViewFeatureFldsEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FuncName);
 var strFuncName = objViewFeatureFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objViewFeatureFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.LabelCaption);
 var strLabelCaption = objViewFeatureFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objViewFeatureFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CtlTypeId);
 var strCtlTypeId = objViewFeatureFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objViewFeatureFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarId);
 var strVarId = objViewFeatureFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objViewFeatureFldsEN.CtrlId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CtrlId);
 var strCtrlId = objViewFeatureFldsEN.CtrlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtrlId + "'");
 }
 
 if (objViewFeatureFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DefaultValue);
 var strDefaultValue = objViewFeatureFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objViewFeatureFldsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.OrderNum);
 arrValueListForInsert.Add(objViewFeatureFldsEN.OrderNum.ToString());
 }
 
 if (objViewFeatureFldsEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CssClass);
 var strCssClass = objViewFeatureFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objViewFeatureFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objViewFeatureFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objViewFeatureFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsTabId);
 var strDsTabId = objViewFeatureFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objViewFeatureFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FldIdCond2);
 var strFldIdCond2 = objViewFeatureFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objViewFeatureFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FldIdCond1);
 var strFldIdCond1 = objViewFeatureFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objViewFeatureFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarIdCond2);
 var strVarIdCond2 = objViewFeatureFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objViewFeatureFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarIdCond1);
 var strVarIdCond1 = objViewFeatureFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objViewFeatureFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objViewFeatureFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objViewFeatureFldsEN.ViewImplId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ViewImplId);
 var strViewImplId = objViewFeatureFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewImplId + "'");
 }
 
 if (objViewFeatureFldsEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.Text);
 var strText = objViewFeatureFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objViewFeatureFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsCondStr);
 var strDsCondStr = objViewFeatureFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objViewFeatureFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsSqlStr);
 var strDsSqlStr = objViewFeatureFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objViewFeatureFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ItemsString);
 var strItemsString = objViewFeatureFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objViewFeatureFldsEN.PrjId  ==  "")
 {
 objViewFeatureFldsEN.PrjId = null;
 }
 if (objViewFeatureFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.PrjId);
 var strPrjId = objViewFeatureFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewFeatureFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.UpdUser);
 var strUpdUser = objViewFeatureFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewFeatureFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.UpdDate);
 var strUpdDate = objViewFeatureFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conViewFeatureFlds.InUse);
 arrValueListForInsert.Add("'" + (objViewFeatureFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objViewFeatureFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.Memo);
 var strMemo = objViewFeatureFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewFeatureFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewFeatureFldsEN objViewFeatureFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewFeatureFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewFeatureFldsEN.ViewFeatureId  ==  "")
 {
 objViewFeatureFldsEN.ViewFeatureId = null;
 }
 if (objViewFeatureFldsEN.ViewFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ViewFeatureId);
 var strViewFeatureId = objViewFeatureFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFeatureId + "'");
 }
 
 if (objViewFeatureFldsEN.FieldTypeId  ==  "")
 {
 objViewFeatureFldsEN.FieldTypeId = null;
 }
 if (objViewFeatureFldsEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FieldTypeId);
 var strFieldTypeId = objViewFeatureFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objViewFeatureFldsEN.ReleFldId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ReleFldId);
 var strReleFldId = objViewFeatureFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleFldId + "'");
 }
 
 if (objViewFeatureFldsEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FuncName);
 var strFuncName = objViewFeatureFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objViewFeatureFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.LabelCaption);
 var strLabelCaption = objViewFeatureFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objViewFeatureFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CtlTypeId);
 var strCtlTypeId = objViewFeatureFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objViewFeatureFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarId);
 var strVarId = objViewFeatureFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objViewFeatureFldsEN.CtrlId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CtrlId);
 var strCtrlId = objViewFeatureFldsEN.CtrlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtrlId + "'");
 }
 
 if (objViewFeatureFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DefaultValue);
 var strDefaultValue = objViewFeatureFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objViewFeatureFldsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.OrderNum);
 arrValueListForInsert.Add(objViewFeatureFldsEN.OrderNum.ToString());
 }
 
 if (objViewFeatureFldsEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CssClass);
 var strCssClass = objViewFeatureFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objViewFeatureFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objViewFeatureFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objViewFeatureFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsTabId);
 var strDsTabId = objViewFeatureFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objViewFeatureFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FldIdCond2);
 var strFldIdCond2 = objViewFeatureFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objViewFeatureFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FldIdCond1);
 var strFldIdCond1 = objViewFeatureFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objViewFeatureFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarIdCond2);
 var strVarIdCond2 = objViewFeatureFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objViewFeatureFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarIdCond1);
 var strVarIdCond1 = objViewFeatureFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objViewFeatureFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objViewFeatureFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objViewFeatureFldsEN.ViewImplId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ViewImplId);
 var strViewImplId = objViewFeatureFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewImplId + "'");
 }
 
 if (objViewFeatureFldsEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.Text);
 var strText = objViewFeatureFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objViewFeatureFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsCondStr);
 var strDsCondStr = objViewFeatureFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objViewFeatureFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsSqlStr);
 var strDsSqlStr = objViewFeatureFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objViewFeatureFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ItemsString);
 var strItemsString = objViewFeatureFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objViewFeatureFldsEN.PrjId  ==  "")
 {
 objViewFeatureFldsEN.PrjId = null;
 }
 if (objViewFeatureFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.PrjId);
 var strPrjId = objViewFeatureFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewFeatureFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.UpdUser);
 var strUpdUser = objViewFeatureFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewFeatureFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.UpdDate);
 var strUpdDate = objViewFeatureFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conViewFeatureFlds.InUse);
 arrValueListForInsert.Add("'" + (objViewFeatureFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objViewFeatureFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.Memo);
 var strMemo = objViewFeatureFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewFeatureFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewFeatureFldsEN objViewFeatureFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewFeatureFldsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewFeatureFldsEN.ViewFeatureId  ==  "")
 {
 objViewFeatureFldsEN.ViewFeatureId = null;
 }
 if (objViewFeatureFldsEN.ViewFeatureId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ViewFeatureId);
 var strViewFeatureId = objViewFeatureFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFeatureId + "'");
 }
 
 if (objViewFeatureFldsEN.FieldTypeId  ==  "")
 {
 objViewFeatureFldsEN.FieldTypeId = null;
 }
 if (objViewFeatureFldsEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FieldTypeId);
 var strFieldTypeId = objViewFeatureFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objViewFeatureFldsEN.ReleFldId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ReleFldId);
 var strReleFldId = objViewFeatureFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReleFldId + "'");
 }
 
 if (objViewFeatureFldsEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FuncName);
 var strFuncName = objViewFeatureFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objViewFeatureFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.LabelCaption);
 var strLabelCaption = objViewFeatureFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objViewFeatureFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CtlTypeId);
 var strCtlTypeId = objViewFeatureFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objViewFeatureFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarId);
 var strVarId = objViewFeatureFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objViewFeatureFldsEN.CtrlId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CtrlId);
 var strCtrlId = objViewFeatureFldsEN.CtrlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtrlId + "'");
 }
 
 if (objViewFeatureFldsEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DefaultValue);
 var strDefaultValue = objViewFeatureFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objViewFeatureFldsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.OrderNum);
 arrValueListForInsert.Add(objViewFeatureFldsEN.OrderNum.ToString());
 }
 
 if (objViewFeatureFldsEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.CssClass);
 var strCssClass = objViewFeatureFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objViewFeatureFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DdlItemsOptionId);
 var strDdlItemsOptionId = objViewFeatureFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDdlItemsOptionId + "'");
 }
 
 if (objViewFeatureFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsTabId);
 var strDsTabId = objViewFeatureFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsTabId + "'");
 }
 
 if (objViewFeatureFldsEN.FldIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FldIdCond2);
 var strFldIdCond2 = objViewFeatureFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond2 + "'");
 }
 
 if (objViewFeatureFldsEN.FldIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.FldIdCond1);
 var strFldIdCond1 = objViewFeatureFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldIdCond1 + "'");
 }
 
 if (objViewFeatureFldsEN.VarIdCond2 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarIdCond2);
 var strVarIdCond2 = objViewFeatureFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond2 + "'");
 }
 
 if (objViewFeatureFldsEN.VarIdCond1 !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.VarIdCond1);
 var strVarIdCond1 = objViewFeatureFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarIdCond1 + "'");
 }
 
 if (objViewFeatureFldsEN.TabFeatureId4Ddl !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.TabFeatureId4Ddl);
 var strTabFeatureId4Ddl = objViewFeatureFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabFeatureId4Ddl + "'");
 }
 
 if (objViewFeatureFldsEN.ViewImplId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ViewImplId);
 var strViewImplId = objViewFeatureFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewImplId + "'");
 }
 
 if (objViewFeatureFldsEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.Text);
 var strText = objViewFeatureFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objViewFeatureFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsCondStr);
 var strDsCondStr = objViewFeatureFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsCondStr + "'");
 }
 
 if (objViewFeatureFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.DsSqlStr);
 var strDsSqlStr = objViewFeatureFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDsSqlStr + "'");
 }
 
 if (objViewFeatureFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.ItemsString);
 var strItemsString = objViewFeatureFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strItemsString + "'");
 }
 
 if (objViewFeatureFldsEN.PrjId  ==  "")
 {
 objViewFeatureFldsEN.PrjId = null;
 }
 if (objViewFeatureFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.PrjId);
 var strPrjId = objViewFeatureFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewFeatureFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.UpdUser);
 var strUpdUser = objViewFeatureFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewFeatureFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.UpdDate);
 var strUpdDate = objViewFeatureFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 arrFieldListForInsert.Add(conViewFeatureFlds.InUse);
 arrValueListForInsert.Add("'" + (objViewFeatureFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objViewFeatureFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewFeatureFlds.Memo);
 var strMemo = objViewFeatureFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewFeatureFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewFeatureFldss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewFeatureFlds");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conViewFeatureFlds.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewFeatureFldsEN._CurrTabName ].NewRow();
objRow[conViewFeatureFlds.ViewFeatureId] = oRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objRow[conViewFeatureFlds.FieldTypeId] = oRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objRow[conViewFeatureFlds.ReleFldId] = oRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objRow[conViewFeatureFlds.FuncName] = oRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objRow[conViewFeatureFlds.LabelCaption] = oRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objRow[conViewFeatureFlds.CtlTypeId] = oRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objRow[conViewFeatureFlds.VarId] = oRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objRow[conViewFeatureFlds.CtrlId] = oRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objRow[conViewFeatureFlds.DefaultValue] = oRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objRow[conViewFeatureFlds.OrderNum] = oRow[conViewFeatureFlds.OrderNum].ToString().Trim(); //序号
objRow[conViewFeatureFlds.CssClass] = oRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objRow[conViewFeatureFlds.DdlItemsOptionId] = oRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objRow[conViewFeatureFlds.DsTabId] = oRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objRow[conViewFeatureFlds.FldIdCond2] = oRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objRow[conViewFeatureFlds.FldIdCond1] = oRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objRow[conViewFeatureFlds.VarIdCond2] = oRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objRow[conViewFeatureFlds.VarIdCond1] = oRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objRow[conViewFeatureFlds.TabFeatureId4Ddl] = oRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objRow[conViewFeatureFlds.ViewImplId] = oRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objRow[conViewFeatureFlds.Text] = oRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objRow[conViewFeatureFlds.DsCondStr] = oRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objRow[conViewFeatureFlds.DsSqlStr] = oRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objRow[conViewFeatureFlds.ItemsString] = oRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objRow[conViewFeatureFlds.PrjId] = oRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objRow[conViewFeatureFlds.UpdUser] = oRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objRow[conViewFeatureFlds.UpdDate] = oRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objRow[conViewFeatureFlds.InUse] = oRow[conViewFeatureFlds.InUse].ToString().Trim(); //是否在用
objRow[conViewFeatureFlds.Memo] = oRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
 objDS.Tables[clsViewFeatureFldsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewFeatureFldsEN._CurrTabName);
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
 /// <param name = "objViewFeatureFldsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewFeatureFldsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewFeatureFlds where mId = " + ""+ objViewFeatureFldsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewFeatureFldsEN._CurrTabName);
if (objDS.Tables[clsViewFeatureFldsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objViewFeatureFldsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsViewFeatureFldsEN._CurrTabName].Rows[0];
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewFeatureId))
 {
objRow[conViewFeatureFlds.ViewFeatureId] = objViewFeatureFldsEN.ViewFeatureId; //界面功能Id
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FieldTypeId))
 {
objRow[conViewFeatureFlds.FieldTypeId] = objViewFeatureFldsEN.FieldTypeId; //字段类型Id
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ReleFldId))
 {
objRow[conViewFeatureFlds.ReleFldId] = objViewFeatureFldsEN.ReleFldId; //相关字段Id
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FuncName))
 {
objRow[conViewFeatureFlds.FuncName] = objViewFeatureFldsEN.FuncName; //函数名
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.LabelCaption))
 {
objRow[conViewFeatureFlds.LabelCaption] = objViewFeatureFldsEN.LabelCaption; //标签标题
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtlTypeId))
 {
objRow[conViewFeatureFlds.CtlTypeId] = objViewFeatureFldsEN.CtlTypeId; //控件类型号
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarId))
 {
objRow[conViewFeatureFlds.VarId] = objViewFeatureFldsEN.VarId; //变量Id
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtrlId))
 {
objRow[conViewFeatureFlds.CtrlId] = objViewFeatureFldsEN.CtrlId; //控件Id
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DefaultValue))
 {
objRow[conViewFeatureFlds.DefaultValue] = objViewFeatureFldsEN.DefaultValue; //缺省值
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.OrderNum))
 {
objRow[conViewFeatureFlds.OrderNum] = objViewFeatureFldsEN.OrderNum; //序号
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CssClass))
 {
objRow[conViewFeatureFlds.CssClass] = objViewFeatureFldsEN.CssClass; //样式表
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DdlItemsOptionId))
 {
objRow[conViewFeatureFlds.DdlItemsOptionId] = objViewFeatureFldsEN.DdlItemsOptionId; //下拉框列表选项ID
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsTabId))
 {
objRow[conViewFeatureFlds.DsTabId] = objViewFeatureFldsEN.DsTabId; //数据源表ID
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond2))
 {
objRow[conViewFeatureFlds.FldIdCond2] = objViewFeatureFldsEN.FldIdCond2; //字段Id_条件2
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond1))
 {
objRow[conViewFeatureFlds.FldIdCond1] = objViewFeatureFldsEN.FldIdCond1; //字段Id_条件1
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond2))
 {
objRow[conViewFeatureFlds.VarIdCond2] = objViewFeatureFldsEN.VarIdCond2; //数据源字段_条件1
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond1))
 {
objRow[conViewFeatureFlds.VarIdCond1] = objViewFeatureFldsEN.VarIdCond1; //变量Id_条件1
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.TabFeatureId4Ddl))
 {
objRow[conViewFeatureFlds.TabFeatureId4Ddl] = objViewFeatureFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewImplId))
 {
objRow[conViewFeatureFlds.ViewImplId] = objViewFeatureFldsEN.ViewImplId; //界面实现Id
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Text))
 {
objRow[conViewFeatureFlds.Text] = objViewFeatureFldsEN.Text; //文本
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsCondStr))
 {
objRow[conViewFeatureFlds.DsCondStr] = objViewFeatureFldsEN.DsCondStr; //数据源条件串
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsSqlStr))
 {
objRow[conViewFeatureFlds.DsSqlStr] = objViewFeatureFldsEN.DsSqlStr; //数据源SQL串
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ItemsString))
 {
objRow[conViewFeatureFlds.ItemsString] = objViewFeatureFldsEN.ItemsString; //列表项串
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.PrjId))
 {
objRow[conViewFeatureFlds.PrjId] = objViewFeatureFldsEN.PrjId; //工程Id
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdUser))
 {
objRow[conViewFeatureFlds.UpdUser] = objViewFeatureFldsEN.UpdUser; //修改者
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdDate))
 {
objRow[conViewFeatureFlds.UpdDate] = objViewFeatureFldsEN.UpdDate; //修改日期
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.InUse))
 {
objRow[conViewFeatureFlds.InUse] = objViewFeatureFldsEN.InUse; //是否在用
 }
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Memo))
 {
objRow[conViewFeatureFlds.Memo] = objViewFeatureFldsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsViewFeatureFldsEN._CurrTabName);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewFeatureFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewFeatureFlds Set ");
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewFeatureId))
 {
 if (objViewFeatureFldsEN.ViewFeatureId  ==  "")
 {
 objViewFeatureFldsEN.ViewFeatureId = null;
 }
 if (objViewFeatureFldsEN.ViewFeatureId !=  null)
 {
 var strViewFeatureId = objViewFeatureFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewFeatureId, conViewFeatureFlds.ViewFeatureId); //界面功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.ViewFeatureId); //界面功能Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FieldTypeId))
 {
 if (objViewFeatureFldsEN.FieldTypeId  ==  "")
 {
 objViewFeatureFldsEN.FieldTypeId = null;
 }
 if (objViewFeatureFldsEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objViewFeatureFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conViewFeatureFlds.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.FieldTypeId); //字段类型Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ReleFldId))
 {
 if (objViewFeatureFldsEN.ReleFldId !=  null)
 {
 var strReleFldId = objViewFeatureFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReleFldId, conViewFeatureFlds.ReleFldId); //相关字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.ReleFldId); //相关字段Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FuncName))
 {
 if (objViewFeatureFldsEN.FuncName !=  null)
 {
 var strFuncName = objViewFeatureFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName, conViewFeatureFlds.FuncName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.FuncName); //函数名
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.LabelCaption))
 {
 if (objViewFeatureFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objViewFeatureFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelCaption, conViewFeatureFlds.LabelCaption); //标签标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.LabelCaption); //标签标题
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtlTypeId))
 {
 if (objViewFeatureFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objViewFeatureFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conViewFeatureFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarId))
 {
 if (objViewFeatureFldsEN.VarId !=  null)
 {
 var strVarId = objViewFeatureFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarId, conViewFeatureFlds.VarId); //变量Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.VarId); //变量Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtrlId))
 {
 if (objViewFeatureFldsEN.CtrlId !=  null)
 {
 var strCtrlId = objViewFeatureFldsEN.CtrlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtrlId, conViewFeatureFlds.CtrlId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.CtrlId); //控件Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DefaultValue))
 {
 if (objViewFeatureFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objViewFeatureFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conViewFeatureFlds.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DefaultValue); //缺省值
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.OrderNum))
 {
 if (objViewFeatureFldsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewFeatureFldsEN.OrderNum, conViewFeatureFlds.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.OrderNum); //序号
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CssClass))
 {
 if (objViewFeatureFldsEN.CssClass !=  null)
 {
 var strCssClass = objViewFeatureFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCssClass, conViewFeatureFlds.CssClass); //样式表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.CssClass); //样式表
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DdlItemsOptionId))
 {
 if (objViewFeatureFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objViewFeatureFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDdlItemsOptionId, conViewFeatureFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsTabId))
 {
 if (objViewFeatureFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objViewFeatureFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsTabId, conViewFeatureFlds.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DsTabId); //数据源表ID
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond2))
 {
 if (objViewFeatureFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objViewFeatureFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond2, conViewFeatureFlds.FldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.FldIdCond2); //字段Id_条件2
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond1))
 {
 if (objViewFeatureFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objViewFeatureFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond1, conViewFeatureFlds.FldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.FldIdCond1); //字段Id_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond2))
 {
 if (objViewFeatureFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objViewFeatureFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond2, conViewFeatureFlds.VarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.VarIdCond2); //数据源字段_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond1))
 {
 if (objViewFeatureFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objViewFeatureFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond1, conViewFeatureFlds.VarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.VarIdCond1); //变量Id_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.TabFeatureId4Ddl))
 {
 if (objViewFeatureFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objViewFeatureFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureId4Ddl, conViewFeatureFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewImplId))
 {
 if (objViewFeatureFldsEN.ViewImplId !=  null)
 {
 var strViewImplId = objViewFeatureFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewImplId, conViewFeatureFlds.ViewImplId); //界面实现Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.ViewImplId); //界面实现Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Text))
 {
 if (objViewFeatureFldsEN.Text !=  null)
 {
 var strText = objViewFeatureFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strText, conViewFeatureFlds.Text); //文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.Text); //文本
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsCondStr))
 {
 if (objViewFeatureFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objViewFeatureFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsCondStr, conViewFeatureFlds.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DsCondStr); //数据源条件串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsSqlStr))
 {
 if (objViewFeatureFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objViewFeatureFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsSqlStr, conViewFeatureFlds.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DsSqlStr); //数据源SQL串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ItemsString))
 {
 if (objViewFeatureFldsEN.ItemsString !=  null)
 {
 var strItemsString = objViewFeatureFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strItemsString, conViewFeatureFlds.ItemsString); //列表项串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.ItemsString); //列表项串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.PrjId))
 {
 if (objViewFeatureFldsEN.PrjId  ==  "")
 {
 objViewFeatureFldsEN.PrjId = null;
 }
 if (objViewFeatureFldsEN.PrjId !=  null)
 {
 var strPrjId = objViewFeatureFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewFeatureFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.PrjId); //工程Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdUser))
 {
 if (objViewFeatureFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objViewFeatureFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewFeatureFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.UpdUser); //修改者
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdDate))
 {
 if (objViewFeatureFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objViewFeatureFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewFeatureFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.UpdDate); //修改日期
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewFeatureFldsEN.InUse == true?"1":"0", conViewFeatureFlds.InUse); //是否在用
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Memo))
 {
 if (objViewFeatureFldsEN.Memo !=  null)
 {
 var strMemo = objViewFeatureFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewFeatureFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewFeatureFldsEN.mId); 
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
 /// <param name = "objViewFeatureFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewFeatureFldsEN objViewFeatureFldsEN, string strCondition)
{
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewFeatureFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewFeatureFlds Set ");
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewFeatureId))
 {
 if (objViewFeatureFldsEN.ViewFeatureId  ==  "")
 {
 objViewFeatureFldsEN.ViewFeatureId = null;
 }
 if (objViewFeatureFldsEN.ViewFeatureId !=  null)
 {
 var strViewFeatureId = objViewFeatureFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewFeatureId = '{0}',", strViewFeatureId); //界面功能Id
 }
 else
 {
 sbSQL.Append(" ViewFeatureId = null,"); //界面功能Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FieldTypeId))
 {
 if (objViewFeatureFldsEN.FieldTypeId  ==  "")
 {
 objViewFeatureFldsEN.FieldTypeId = null;
 }
 if (objViewFeatureFldsEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objViewFeatureFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ReleFldId))
 {
 if (objViewFeatureFldsEN.ReleFldId !=  null)
 {
 var strReleFldId = objViewFeatureFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReleFldId = '{0}',", strReleFldId); //相关字段Id
 }
 else
 {
 sbSQL.Append(" ReleFldId = null,"); //相关字段Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FuncName))
 {
 if (objViewFeatureFldsEN.FuncName !=  null)
 {
 var strFuncName = objViewFeatureFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName = '{0}',", strFuncName); //函数名
 }
 else
 {
 sbSQL.Append(" FuncName = null,"); //函数名
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.LabelCaption))
 {
 if (objViewFeatureFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objViewFeatureFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelCaption = '{0}',", strLabelCaption); //标签标题
 }
 else
 {
 sbSQL.Append(" LabelCaption = null,"); //标签标题
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtlTypeId))
 {
 if (objViewFeatureFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objViewFeatureFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarId))
 {
 if (objViewFeatureFldsEN.VarId !=  null)
 {
 var strVarId = objViewFeatureFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarId = '{0}',", strVarId); //变量Id
 }
 else
 {
 sbSQL.Append(" VarId = null,"); //变量Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtrlId))
 {
 if (objViewFeatureFldsEN.CtrlId !=  null)
 {
 var strCtrlId = objViewFeatureFldsEN.CtrlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtrlId = '{0}',", strCtrlId); //控件Id
 }
 else
 {
 sbSQL.Append(" CtrlId = null,"); //控件Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DefaultValue))
 {
 if (objViewFeatureFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objViewFeatureFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.OrderNum))
 {
 if (objViewFeatureFldsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewFeatureFldsEN.OrderNum, conViewFeatureFlds.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.OrderNum); //序号
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CssClass))
 {
 if (objViewFeatureFldsEN.CssClass !=  null)
 {
 var strCssClass = objViewFeatureFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CssClass = '{0}',", strCssClass); //样式表
 }
 else
 {
 sbSQL.Append(" CssClass = null,"); //样式表
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DdlItemsOptionId))
 {
 if (objViewFeatureFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objViewFeatureFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DdlItemsOptionId = '{0}',", strDdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.Append(" DdlItemsOptionId = null,"); //下拉框列表选项ID
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsTabId))
 {
 if (objViewFeatureFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objViewFeatureFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsTabId = '{0}',", strDsTabId); //数据源表ID
 }
 else
 {
 sbSQL.Append(" DsTabId = null,"); //数据源表ID
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond2))
 {
 if (objViewFeatureFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objViewFeatureFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond2 = '{0}',", strFldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.Append(" FldIdCond2 = null,"); //字段Id_条件2
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond1))
 {
 if (objViewFeatureFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objViewFeatureFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond1 = '{0}',", strFldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.Append(" FldIdCond1 = null,"); //字段Id_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond2))
 {
 if (objViewFeatureFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objViewFeatureFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond2 = '{0}',", strVarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond2 = null,"); //数据源字段_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond1))
 {
 if (objViewFeatureFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objViewFeatureFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond1 = '{0}',", strVarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond1 = null,"); //变量Id_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.TabFeatureId4Ddl))
 {
 if (objViewFeatureFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objViewFeatureFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureId4Ddl = '{0}',", strTabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.Append(" TabFeatureId4Ddl = null,"); //下拉框表功能Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewImplId))
 {
 if (objViewFeatureFldsEN.ViewImplId !=  null)
 {
 var strViewImplId = objViewFeatureFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewImplId = '{0}',", strViewImplId); //界面实现Id
 }
 else
 {
 sbSQL.Append(" ViewImplId = null,"); //界面实现Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Text))
 {
 if (objViewFeatureFldsEN.Text !=  null)
 {
 var strText = objViewFeatureFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Text = '{0}',", strText); //文本
 }
 else
 {
 sbSQL.Append(" Text = null,"); //文本
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsCondStr))
 {
 if (objViewFeatureFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objViewFeatureFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsCondStr = '{0}',", strDsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.Append(" DsCondStr = null,"); //数据源条件串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsSqlStr))
 {
 if (objViewFeatureFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objViewFeatureFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsSqlStr = '{0}',", strDsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.Append(" DsSqlStr = null,"); //数据源SQL串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ItemsString))
 {
 if (objViewFeatureFldsEN.ItemsString !=  null)
 {
 var strItemsString = objViewFeatureFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ItemsString = '{0}',", strItemsString); //列表项串
 }
 else
 {
 sbSQL.Append(" ItemsString = null,"); //列表项串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.PrjId))
 {
 if (objViewFeatureFldsEN.PrjId  ==  "")
 {
 objViewFeatureFldsEN.PrjId = null;
 }
 if (objViewFeatureFldsEN.PrjId !=  null)
 {
 var strPrjId = objViewFeatureFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdUser))
 {
 if (objViewFeatureFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objViewFeatureFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdDate))
 {
 if (objViewFeatureFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objViewFeatureFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objViewFeatureFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Memo))
 {
 if (objViewFeatureFldsEN.Memo !=  null)
 {
 var strMemo = objViewFeatureFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewFeatureFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewFeatureFldsEN objViewFeatureFldsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewFeatureFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewFeatureFlds Set ");
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewFeatureId))
 {
 if (objViewFeatureFldsEN.ViewFeatureId  ==  "")
 {
 objViewFeatureFldsEN.ViewFeatureId = null;
 }
 if (objViewFeatureFldsEN.ViewFeatureId !=  null)
 {
 var strViewFeatureId = objViewFeatureFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewFeatureId = '{0}',", strViewFeatureId); //界面功能Id
 }
 else
 {
 sbSQL.Append(" ViewFeatureId = null,"); //界面功能Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FieldTypeId))
 {
 if (objViewFeatureFldsEN.FieldTypeId  ==  "")
 {
 objViewFeatureFldsEN.FieldTypeId = null;
 }
 if (objViewFeatureFldsEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objViewFeatureFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ReleFldId))
 {
 if (objViewFeatureFldsEN.ReleFldId !=  null)
 {
 var strReleFldId = objViewFeatureFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReleFldId = '{0}',", strReleFldId); //相关字段Id
 }
 else
 {
 sbSQL.Append(" ReleFldId = null,"); //相关字段Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FuncName))
 {
 if (objViewFeatureFldsEN.FuncName !=  null)
 {
 var strFuncName = objViewFeatureFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName = '{0}',", strFuncName); //函数名
 }
 else
 {
 sbSQL.Append(" FuncName = null,"); //函数名
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.LabelCaption))
 {
 if (objViewFeatureFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objViewFeatureFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelCaption = '{0}',", strLabelCaption); //标签标题
 }
 else
 {
 sbSQL.Append(" LabelCaption = null,"); //标签标题
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtlTypeId))
 {
 if (objViewFeatureFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objViewFeatureFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarId))
 {
 if (objViewFeatureFldsEN.VarId !=  null)
 {
 var strVarId = objViewFeatureFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarId = '{0}',", strVarId); //变量Id
 }
 else
 {
 sbSQL.Append(" VarId = null,"); //变量Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtrlId))
 {
 if (objViewFeatureFldsEN.CtrlId !=  null)
 {
 var strCtrlId = objViewFeatureFldsEN.CtrlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtrlId = '{0}',", strCtrlId); //控件Id
 }
 else
 {
 sbSQL.Append(" CtrlId = null,"); //控件Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DefaultValue))
 {
 if (objViewFeatureFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objViewFeatureFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.OrderNum))
 {
 if (objViewFeatureFldsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewFeatureFldsEN.OrderNum, conViewFeatureFlds.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.OrderNum); //序号
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CssClass))
 {
 if (objViewFeatureFldsEN.CssClass !=  null)
 {
 var strCssClass = objViewFeatureFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CssClass = '{0}',", strCssClass); //样式表
 }
 else
 {
 sbSQL.Append(" CssClass = null,"); //样式表
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DdlItemsOptionId))
 {
 if (objViewFeatureFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objViewFeatureFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DdlItemsOptionId = '{0}',", strDdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.Append(" DdlItemsOptionId = null,"); //下拉框列表选项ID
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsTabId))
 {
 if (objViewFeatureFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objViewFeatureFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsTabId = '{0}',", strDsTabId); //数据源表ID
 }
 else
 {
 sbSQL.Append(" DsTabId = null,"); //数据源表ID
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond2))
 {
 if (objViewFeatureFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objViewFeatureFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond2 = '{0}',", strFldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.Append(" FldIdCond2 = null,"); //字段Id_条件2
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond1))
 {
 if (objViewFeatureFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objViewFeatureFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldIdCond1 = '{0}',", strFldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.Append(" FldIdCond1 = null,"); //字段Id_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond2))
 {
 if (objViewFeatureFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objViewFeatureFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond2 = '{0}',", strVarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond2 = null,"); //数据源字段_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond1))
 {
 if (objViewFeatureFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objViewFeatureFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarIdCond1 = '{0}',", strVarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.Append(" VarIdCond1 = null,"); //变量Id_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.TabFeatureId4Ddl))
 {
 if (objViewFeatureFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objViewFeatureFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabFeatureId4Ddl = '{0}',", strTabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.Append(" TabFeatureId4Ddl = null,"); //下拉框表功能Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewImplId))
 {
 if (objViewFeatureFldsEN.ViewImplId !=  null)
 {
 var strViewImplId = objViewFeatureFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewImplId = '{0}',", strViewImplId); //界面实现Id
 }
 else
 {
 sbSQL.Append(" ViewImplId = null,"); //界面实现Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Text))
 {
 if (objViewFeatureFldsEN.Text !=  null)
 {
 var strText = objViewFeatureFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Text = '{0}',", strText); //文本
 }
 else
 {
 sbSQL.Append(" Text = null,"); //文本
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsCondStr))
 {
 if (objViewFeatureFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objViewFeatureFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsCondStr = '{0}',", strDsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.Append(" DsCondStr = null,"); //数据源条件串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsSqlStr))
 {
 if (objViewFeatureFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objViewFeatureFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsSqlStr = '{0}',", strDsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.Append(" DsSqlStr = null,"); //数据源SQL串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ItemsString))
 {
 if (objViewFeatureFldsEN.ItemsString !=  null)
 {
 var strItemsString = objViewFeatureFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ItemsString = '{0}',", strItemsString); //列表项串
 }
 else
 {
 sbSQL.Append(" ItemsString = null,"); //列表项串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.PrjId))
 {
 if (objViewFeatureFldsEN.PrjId  ==  "")
 {
 objViewFeatureFldsEN.PrjId = null;
 }
 if (objViewFeatureFldsEN.PrjId !=  null)
 {
 var strPrjId = objViewFeatureFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdUser))
 {
 if (objViewFeatureFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objViewFeatureFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdDate))
 {
 if (objViewFeatureFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objViewFeatureFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objViewFeatureFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Memo))
 {
 if (objViewFeatureFldsEN.Memo !=  null)
 {
 var strMemo = objViewFeatureFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewFeatureFldsEN objViewFeatureFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewFeatureFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewFeatureFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewFeatureFlds Set ");
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewFeatureId))
 {
 if (objViewFeatureFldsEN.ViewFeatureId  ==  "")
 {
 objViewFeatureFldsEN.ViewFeatureId = null;
 }
 if (objViewFeatureFldsEN.ViewFeatureId !=  null)
 {
 var strViewFeatureId = objViewFeatureFldsEN.ViewFeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewFeatureId, conViewFeatureFlds.ViewFeatureId); //界面功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.ViewFeatureId); //界面功能Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FieldTypeId))
 {
 if (objViewFeatureFldsEN.FieldTypeId  ==  "")
 {
 objViewFeatureFldsEN.FieldTypeId = null;
 }
 if (objViewFeatureFldsEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objViewFeatureFldsEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conViewFeatureFlds.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.FieldTypeId); //字段类型Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ReleFldId))
 {
 if (objViewFeatureFldsEN.ReleFldId !=  null)
 {
 var strReleFldId = objViewFeatureFldsEN.ReleFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReleFldId, conViewFeatureFlds.ReleFldId); //相关字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.ReleFldId); //相关字段Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FuncName))
 {
 if (objViewFeatureFldsEN.FuncName !=  null)
 {
 var strFuncName = objViewFeatureFldsEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName, conViewFeatureFlds.FuncName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.FuncName); //函数名
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.LabelCaption))
 {
 if (objViewFeatureFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objViewFeatureFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelCaption, conViewFeatureFlds.LabelCaption); //标签标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.LabelCaption); //标签标题
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtlTypeId))
 {
 if (objViewFeatureFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objViewFeatureFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conViewFeatureFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarId))
 {
 if (objViewFeatureFldsEN.VarId !=  null)
 {
 var strVarId = objViewFeatureFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarId, conViewFeatureFlds.VarId); //变量Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.VarId); //变量Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CtrlId))
 {
 if (objViewFeatureFldsEN.CtrlId !=  null)
 {
 var strCtrlId = objViewFeatureFldsEN.CtrlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtrlId, conViewFeatureFlds.CtrlId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.CtrlId); //控件Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DefaultValue))
 {
 if (objViewFeatureFldsEN.DefaultValue !=  null)
 {
 var strDefaultValue = objViewFeatureFldsEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conViewFeatureFlds.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DefaultValue); //缺省值
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.OrderNum))
 {
 if (objViewFeatureFldsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewFeatureFldsEN.OrderNum, conViewFeatureFlds.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.OrderNum); //序号
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.CssClass))
 {
 if (objViewFeatureFldsEN.CssClass !=  null)
 {
 var strCssClass = objViewFeatureFldsEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCssClass, conViewFeatureFlds.CssClass); //样式表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.CssClass); //样式表
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DdlItemsOptionId))
 {
 if (objViewFeatureFldsEN.DdlItemsOptionId !=  null)
 {
 var strDdlItemsOptionId = objViewFeatureFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDdlItemsOptionId, conViewFeatureFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsTabId))
 {
 if (objViewFeatureFldsEN.DsTabId !=  null)
 {
 var strDsTabId = objViewFeatureFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsTabId, conViewFeatureFlds.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DsTabId); //数据源表ID
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond2))
 {
 if (objViewFeatureFldsEN.FldIdCond2 !=  null)
 {
 var strFldIdCond2 = objViewFeatureFldsEN.FldIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond2, conViewFeatureFlds.FldIdCond2); //字段Id_条件2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.FldIdCond2); //字段Id_条件2
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.FldIdCond1))
 {
 if (objViewFeatureFldsEN.FldIdCond1 !=  null)
 {
 var strFldIdCond1 = objViewFeatureFldsEN.FldIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldIdCond1, conViewFeatureFlds.FldIdCond1); //字段Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.FldIdCond1); //字段Id_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond2))
 {
 if (objViewFeatureFldsEN.VarIdCond2 !=  null)
 {
 var strVarIdCond2 = objViewFeatureFldsEN.VarIdCond2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond2, conViewFeatureFlds.VarIdCond2); //数据源字段_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.VarIdCond2); //数据源字段_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.VarIdCond1))
 {
 if (objViewFeatureFldsEN.VarIdCond1 !=  null)
 {
 var strVarIdCond1 = objViewFeatureFldsEN.VarIdCond1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarIdCond1, conViewFeatureFlds.VarIdCond1); //变量Id_条件1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.VarIdCond1); //变量Id_条件1
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.TabFeatureId4Ddl))
 {
 if (objViewFeatureFldsEN.TabFeatureId4Ddl !=  null)
 {
 var strTabFeatureId4Ddl = objViewFeatureFldsEN.TabFeatureId4Ddl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabFeatureId4Ddl, conViewFeatureFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.TabFeatureId4Ddl); //下拉框表功能Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ViewImplId))
 {
 if (objViewFeatureFldsEN.ViewImplId !=  null)
 {
 var strViewImplId = objViewFeatureFldsEN.ViewImplId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewImplId, conViewFeatureFlds.ViewImplId); //界面实现Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.ViewImplId); //界面实现Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Text))
 {
 if (objViewFeatureFldsEN.Text !=  null)
 {
 var strText = objViewFeatureFldsEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strText, conViewFeatureFlds.Text); //文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.Text); //文本
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsCondStr))
 {
 if (objViewFeatureFldsEN.DsCondStr !=  null)
 {
 var strDsCondStr = objViewFeatureFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsCondStr, conViewFeatureFlds.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DsCondStr); //数据源条件串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.DsSqlStr))
 {
 if (objViewFeatureFldsEN.DsSqlStr !=  null)
 {
 var strDsSqlStr = objViewFeatureFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDsSqlStr, conViewFeatureFlds.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.DsSqlStr); //数据源SQL串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.ItemsString))
 {
 if (objViewFeatureFldsEN.ItemsString !=  null)
 {
 var strItemsString = objViewFeatureFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strItemsString, conViewFeatureFlds.ItemsString); //列表项串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.ItemsString); //列表项串
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.PrjId))
 {
 if (objViewFeatureFldsEN.PrjId  ==  "")
 {
 objViewFeatureFldsEN.PrjId = null;
 }
 if (objViewFeatureFldsEN.PrjId !=  null)
 {
 var strPrjId = objViewFeatureFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewFeatureFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.PrjId); //工程Id
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdUser))
 {
 if (objViewFeatureFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objViewFeatureFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewFeatureFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.UpdUser); //修改者
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.UpdDate))
 {
 if (objViewFeatureFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objViewFeatureFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewFeatureFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.UpdDate); //修改日期
 }
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewFeatureFldsEN.InUse == true?"1":"0", conViewFeatureFlds.InUse); //是否在用
 }
 
 if (objViewFeatureFldsEN.IsUpdated(conViewFeatureFlds.Memo))
 {
 if (objViewFeatureFldsEN.Memo !=  null)
 {
 var strMemo = objViewFeatureFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewFeatureFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewFeatureFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewFeatureFldsEN.mId); 
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ViewFeatureFlds_Delete", values);
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
//删除ViewFeatureFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewFeatureFlds where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewFeatureFlds(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
//删除ViewFeatureFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewFeatureFlds where mId in (" + strKeyList + ")";
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
//删除ViewFeatureFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewFeatureFlds where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewFeatureFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: DelViewFeatureFlds)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewFeatureFlds where " + strCondition ;
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
public bool DelViewFeatureFldsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewFeatureFldsDA: DelViewFeatureFldsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewFeatureFlds where " + strCondition ;
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
 /// <param name = "objViewFeatureFldsENS">源对象</param>
 /// <param name = "objViewFeatureFldsENT">目标对象</param>
public void CopyTo(clsViewFeatureFldsEN objViewFeatureFldsENS, clsViewFeatureFldsEN objViewFeatureFldsENT)
{
objViewFeatureFldsENT.mId = objViewFeatureFldsENS.mId; //mId
objViewFeatureFldsENT.ViewFeatureId = objViewFeatureFldsENS.ViewFeatureId; //界面功能Id
objViewFeatureFldsENT.FieldTypeId = objViewFeatureFldsENS.FieldTypeId; //字段类型Id
objViewFeatureFldsENT.ReleFldId = objViewFeatureFldsENS.ReleFldId; //相关字段Id
objViewFeatureFldsENT.FuncName = objViewFeatureFldsENS.FuncName; //函数名
objViewFeatureFldsENT.LabelCaption = objViewFeatureFldsENS.LabelCaption; //标签标题
objViewFeatureFldsENT.CtlTypeId = objViewFeatureFldsENS.CtlTypeId; //控件类型号
objViewFeatureFldsENT.VarId = objViewFeatureFldsENS.VarId; //变量Id
objViewFeatureFldsENT.CtrlId = objViewFeatureFldsENS.CtrlId; //控件Id
objViewFeatureFldsENT.DefaultValue = objViewFeatureFldsENS.DefaultValue; //缺省值
objViewFeatureFldsENT.OrderNum = objViewFeatureFldsENS.OrderNum; //序号
objViewFeatureFldsENT.CssClass = objViewFeatureFldsENS.CssClass; //样式表
objViewFeatureFldsENT.DdlItemsOptionId = objViewFeatureFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objViewFeatureFldsENT.DsTabId = objViewFeatureFldsENS.DsTabId; //数据源表ID
objViewFeatureFldsENT.FldIdCond2 = objViewFeatureFldsENS.FldIdCond2; //字段Id_条件2
objViewFeatureFldsENT.FldIdCond1 = objViewFeatureFldsENS.FldIdCond1; //字段Id_条件1
objViewFeatureFldsENT.VarIdCond2 = objViewFeatureFldsENS.VarIdCond2; //数据源字段_条件1
objViewFeatureFldsENT.VarIdCond1 = objViewFeatureFldsENS.VarIdCond1; //变量Id_条件1
objViewFeatureFldsENT.TabFeatureId4Ddl = objViewFeatureFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objViewFeatureFldsENT.ViewImplId = objViewFeatureFldsENS.ViewImplId; //界面实现Id
objViewFeatureFldsENT.Text = objViewFeatureFldsENS.Text; //文本
objViewFeatureFldsENT.DsCondStr = objViewFeatureFldsENS.DsCondStr; //数据源条件串
objViewFeatureFldsENT.DsSqlStr = objViewFeatureFldsENS.DsSqlStr; //数据源SQL串
objViewFeatureFldsENT.ItemsString = objViewFeatureFldsENS.ItemsString; //列表项串
objViewFeatureFldsENT.PrjId = objViewFeatureFldsENS.PrjId; //工程Id
objViewFeatureFldsENT.UpdUser = objViewFeatureFldsENS.UpdUser; //修改者
objViewFeatureFldsENT.UpdDate = objViewFeatureFldsENS.UpdDate; //修改日期
objViewFeatureFldsENT.InUse = objViewFeatureFldsENS.InUse; //是否在用
objViewFeatureFldsENT.Memo = objViewFeatureFldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewFeatureFldsEN.ViewFeatureId, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldNotNull(objViewFeatureFldsEN.FieldTypeId, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldNotNull(objViewFeatureFldsEN.PrjId, conViewFeatureFlds.PrjId);
clsCheckSql.CheckFieldNotNull(objViewFeatureFldsEN.UpdUser, conViewFeatureFlds.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ReleFldId, 8, conViewFeatureFlds.ReleFldId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FuncName, 100, conViewFeatureFlds.FuncName);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.LabelCaption, 150, conViewFeatureFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.CtlTypeId, 2, conViewFeatureFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.VarId, 8, conViewFeatureFlds.VarId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.CtrlId, 50, conViewFeatureFlds.CtrlId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DefaultValue, 50, conViewFeatureFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.CssClass, 50, conViewFeatureFlds.CssClass);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DdlItemsOptionId, 2, conViewFeatureFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DsTabId, 8, conViewFeatureFlds.DsTabId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FldIdCond2, 8, conViewFeatureFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FldIdCond1, 8, conViewFeatureFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.VarIdCond2, 8, conViewFeatureFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.VarIdCond1, 8, conViewFeatureFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.TabFeatureId4Ddl, 8, conViewFeatureFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ViewImplId, 4, conViewFeatureFlds.ViewImplId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.Text, 30, conViewFeatureFlds.Text);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DsCondStr, 50, conViewFeatureFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DsSqlStr, 200, conViewFeatureFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ItemsString, 200, conViewFeatureFlds.ItemsString);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.PrjId, 4, conViewFeatureFlds.PrjId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.UpdUser, 20, conViewFeatureFlds.UpdUser);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.UpdDate, 20, conViewFeatureFlds.UpdDate);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.Memo, 1000, conViewFeatureFlds.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objViewFeatureFldsEN.ViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldForeignKey(objViewFeatureFldsEN.FieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(objViewFeatureFldsEN.PrjId, 4, conViewFeatureFlds.PrjId);
 objViewFeatureFldsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ReleFldId, 8, conViewFeatureFlds.ReleFldId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FuncName, 100, conViewFeatureFlds.FuncName);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.LabelCaption, 150, conViewFeatureFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.CtlTypeId, 2, conViewFeatureFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.VarId, 8, conViewFeatureFlds.VarId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.CtrlId, 50, conViewFeatureFlds.CtrlId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DefaultValue, 50, conViewFeatureFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.CssClass, 50, conViewFeatureFlds.CssClass);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DdlItemsOptionId, 2, conViewFeatureFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DsTabId, 8, conViewFeatureFlds.DsTabId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FldIdCond2, 8, conViewFeatureFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FldIdCond1, 8, conViewFeatureFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.VarIdCond2, 8, conViewFeatureFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.VarIdCond1, 8, conViewFeatureFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.TabFeatureId4Ddl, 8, conViewFeatureFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ViewImplId, 4, conViewFeatureFlds.ViewImplId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.Text, 30, conViewFeatureFlds.Text);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DsCondStr, 50, conViewFeatureFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DsSqlStr, 200, conViewFeatureFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ItemsString, 200, conViewFeatureFlds.ItemsString);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.PrjId, 4, conViewFeatureFlds.PrjId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.UpdUser, 20, conViewFeatureFlds.UpdUser);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.UpdDate, 20, conViewFeatureFlds.UpdDate);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.Memo, 1000, conViewFeatureFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewFeatureFldsEN.ViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldForeignKey(objViewFeatureFldsEN.FieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(objViewFeatureFldsEN.PrjId, 4, conViewFeatureFlds.PrjId);
 objViewFeatureFldsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ReleFldId, 8, conViewFeatureFlds.ReleFldId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FuncName, 100, conViewFeatureFlds.FuncName);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.LabelCaption, 150, conViewFeatureFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.CtlTypeId, 2, conViewFeatureFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.VarId, 8, conViewFeatureFlds.VarId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.CtrlId, 50, conViewFeatureFlds.CtrlId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DefaultValue, 50, conViewFeatureFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.CssClass, 50, conViewFeatureFlds.CssClass);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DdlItemsOptionId, 2, conViewFeatureFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DsTabId, 8, conViewFeatureFlds.DsTabId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FldIdCond2, 8, conViewFeatureFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.FldIdCond1, 8, conViewFeatureFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.VarIdCond2, 8, conViewFeatureFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.VarIdCond1, 8, conViewFeatureFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.TabFeatureId4Ddl, 8, conViewFeatureFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ViewImplId, 4, conViewFeatureFlds.ViewImplId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.Text, 30, conViewFeatureFlds.Text);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DsCondStr, 50, conViewFeatureFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.DsSqlStr, 200, conViewFeatureFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.ItemsString, 200, conViewFeatureFlds.ItemsString);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.PrjId, 4, conViewFeatureFlds.PrjId);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.UpdUser, 20, conViewFeatureFlds.UpdUser);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.UpdDate, 20, conViewFeatureFlds.UpdDate);
clsCheckSql.CheckFieldLen(objViewFeatureFldsEN.Memo, 1000, conViewFeatureFlds.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.ViewFeatureId, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.FieldTypeId, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.ReleFldId, conViewFeatureFlds.ReleFldId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.FuncName, conViewFeatureFlds.FuncName);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.LabelCaption, conViewFeatureFlds.LabelCaption);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.CtlTypeId, conViewFeatureFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.VarId, conViewFeatureFlds.VarId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.CtrlId, conViewFeatureFlds.CtrlId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.DefaultValue, conViewFeatureFlds.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.CssClass, conViewFeatureFlds.CssClass);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.DdlItemsOptionId, conViewFeatureFlds.DdlItemsOptionId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.DsTabId, conViewFeatureFlds.DsTabId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.FldIdCond2, conViewFeatureFlds.FldIdCond2);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.FldIdCond1, conViewFeatureFlds.FldIdCond1);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.VarIdCond2, conViewFeatureFlds.VarIdCond2);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.VarIdCond1, conViewFeatureFlds.VarIdCond1);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.TabFeatureId4Ddl, conViewFeatureFlds.TabFeatureId4Ddl);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.ViewImplId, conViewFeatureFlds.ViewImplId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.Text, conViewFeatureFlds.Text);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.DsCondStr, conViewFeatureFlds.DsCondStr);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.DsSqlStr, conViewFeatureFlds.DsSqlStr);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.ItemsString, conViewFeatureFlds.ItemsString);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.PrjId, conViewFeatureFlds.PrjId);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.UpdUser, conViewFeatureFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.UpdDate, conViewFeatureFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewFeatureFldsEN.Memo, conViewFeatureFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewFeatureFldsEN.ViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldForeignKey(objViewFeatureFldsEN.FieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(objViewFeatureFldsEN.PrjId, 4, conViewFeatureFlds.PrjId);
 objViewFeatureFldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewFeatureFlds(界面功能字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewFeatureId = '{0}'", objViewFeatureFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objViewFeatureFldsEN.FieldTypeId);
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewFeatureFldsEN._CurrTabName);
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewFeatureFldsEN._CurrTabName, strCondition);
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
 objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}