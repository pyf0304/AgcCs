
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab_SimV2DA
 表名:vPrjTab_SimV2(00050610)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// v工程表_SimV2(vPrjTab_SimV2)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjTab_SimV2DA : clsCommBase4DA
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
 return clsvPrjTab_SimV2EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjTab_SimV2EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTab_SimV2EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjTab_SimV2EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjTab_SimV2EN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTabId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTabId)
{
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vPrjTab_SimV2中,检查关键字,长度不正确!(clsvPrjTab_SimV2DA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjTab_SimV2中,关键字不能为空 或 null!(clsvPrjTab_SimV2DA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjTab_SimV2DA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_SimV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjTab_SimV2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetDataTable_vPrjTab_SimV2)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_SimV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_SimV2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_SimV2 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_SimV2 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjTab_SimV2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab_SimV2.* " + 
$"from vPrjTab_SimV2 " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab_SimV2.TabId not in " + 
$"(Select top {intTop_In} vPrjTab_SimV2.TabId from vPrjTab_SimV2 " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_SimV2 where {1} and TabId not in (Select top {2} TabId from vPrjTab_SimV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_SimV2 where {1} and TabId not in (Select top {3} TabId from vPrjTab_SimV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab_SimV2.* " + 
$"from vPrjTab_SimV2 " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab_SimV2.TabId not in " + 
$"(Select top {intTop_In} vPrjTab_SimV2.TabId from vPrjTab_SimV2 " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_SimV2 where {1} and TabId not in (Select top {2} TabId from vPrjTab_SimV2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_SimV2 where {1} and TabId not in (Select top {3} TabId from vPrjTab_SimV2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjTab_SimV2EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA:GetObjLst)", objException.Message));
}
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_SimV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTab_SimV2DA: GetObjLst)", objException.Message));
}
objvPrjTab_SimV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTab_SimV2EN);
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
public List<clsvPrjTab_SimV2EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTab_SimV2DA: GetObjLst)", objException.Message));
}
objvPrjTab_SimV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTab_SimV2EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjTab_SimV2(ref clsvPrjTab_SimV2EN objvPrjTab_SimV2EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_SimV2 where TabId = " + "'"+ objvPrjTab_SimV2EN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjTab_SimV2EN.TabId = objDT.Rows[0][convPrjTab_SimV2.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab_SimV2EN.TabName = objDT.Rows[0][convPrjTab_SimV2.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTab_SimV2EN.SqlDsTypeId = objDT.Rows[0][convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab_SimV2EN.FuncModuleAgcId = objDT.Rows[0][convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab_SimV2EN.TabTypeId = objDT.Rows[0][convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab_SimV2EN.CacheModeId = objDT.Rows[0][convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvPrjTab_SimV2EN.TabStateId = objDT.Rows[0][convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab_SimV2EN.CmPrjId = objDT.Rows[0][convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjTab_SimV2DA: GetvPrjTab_SimV2)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjTab_SimV2EN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_SimV2 where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
 objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjTab_SimV2DA: GetObjByTabId)", objException.Message));
}
return objvPrjTab_SimV2EN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjTab_SimV2EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_SimV2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN()
{
TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(), //表ID
TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(), //表名
SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(), //数据源类型Id
FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(), //功能模块Id
TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(), //表类型Id
CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(), //缓存方式Id
TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(), //表状态ID
CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim() //Cm工程Id
};
objvPrjTab_SimV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab_SimV2EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjTab_SimV2DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjTab_SimV2EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjTab_SimV2DA: GetObjByDataRowvPrjTab_SimV2)", objException.Message));
}
objvPrjTab_SimV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab_SimV2EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjTab_SimV2EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjTab_SimV2DA: GetObjByDataRow)", objException.Message));
}
objvPrjTab_SimV2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab_SimV2EN;
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
objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTab_SimV2EN._CurrTabName, convPrjTab_SimV2.TabId, 8, "");
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
objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTab_SimV2EN._CurrTabName, convPrjTab_SimV2.TabId, 8, strPrefix);
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
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from vPrjTab_SimV2 where " + strCondition;
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
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from vPrjTab_SimV2 where " + strCondition;
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTabId)
{
CheckPrimaryKey(strTabId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab_SimV2", "TabId = " + "'"+ strTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjTab_SimV2DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab_SimV2", strCondition))
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
objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjTab_SimV2");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2ENS">源对象</param>
 /// <param name = "objvPrjTab_SimV2ENT">目标对象</param>
public void CopyTo(clsvPrjTab_SimV2EN objvPrjTab_SimV2ENS, clsvPrjTab_SimV2EN objvPrjTab_SimV2ENT)
{
objvPrjTab_SimV2ENT.TabId = objvPrjTab_SimV2ENS.TabId; //表ID
objvPrjTab_SimV2ENT.TabName = objvPrjTab_SimV2ENS.TabName; //表名
objvPrjTab_SimV2ENT.SqlDsTypeId = objvPrjTab_SimV2ENS.SqlDsTypeId; //数据源类型Id
objvPrjTab_SimV2ENT.FuncModuleAgcId = objvPrjTab_SimV2ENS.FuncModuleAgcId; //功能模块Id
objvPrjTab_SimV2ENT.TabTypeId = objvPrjTab_SimV2ENS.TabTypeId; //表类型Id
objvPrjTab_SimV2ENT.CacheModeId = objvPrjTab_SimV2ENS.CacheModeId; //缓存方式Id
objvPrjTab_SimV2ENT.TabStateId = objvPrjTab_SimV2ENS.TabStateId; //表状态ID
objvPrjTab_SimV2ENT.CmPrjId = objvPrjTab_SimV2ENS.CmPrjId; //Cm工程Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjTab_SimV2EN objvPrjTab_SimV2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjTab_SimV2EN.TabId, 8, convPrjTab_SimV2.TabId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimV2EN.TabName, 100, convPrjTab_SimV2.TabName);
clsCheckSql.CheckFieldLen(objvPrjTab_SimV2EN.SqlDsTypeId, 2, convPrjTab_SimV2.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimV2EN.FuncModuleAgcId, 8, convPrjTab_SimV2.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimV2EN.TabTypeId, 4, convPrjTab_SimV2.TabTypeId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimV2EN.CacheModeId, 2, convPrjTab_SimV2.CacheModeId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimV2EN.TabStateId, 2, convPrjTab_SimV2.TabStateId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimV2EN.CmPrjId, 6, convPrjTab_SimV2.CmPrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimV2EN.TabId, convPrjTab_SimV2.TabId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimV2EN.TabName, convPrjTab_SimV2.TabName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimV2EN.SqlDsTypeId, convPrjTab_SimV2.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimV2EN.FuncModuleAgcId, convPrjTab_SimV2.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimV2EN.TabTypeId, convPrjTab_SimV2.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimV2EN.CacheModeId, convPrjTab_SimV2.CacheModeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimV2EN.TabStateId, convPrjTab_SimV2.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimV2EN.CmPrjId, convPrjTab_SimV2.CmPrjId);
//检查外键字段长度
 objvPrjTab_SimV2EN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTabId()
{
//获取某学院所有专业信息
string strSQL = "select TabId, TabName from vPrjTab_SimV2 ";
 clsSpecSQLforSql mySql = clsvPrjTab_SimV2DA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTab_SimV2EN._CurrTabName);
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
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTab_SimV2EN._CurrTabName, strCondition);
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
 objSQL = clsvPrjTab_SimV2DA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}