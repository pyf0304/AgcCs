
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFuncMapCmPrjIdRelaDA
 表名:DnFuncMapCmPrjIdRela(00050619)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 结点函数映射CmPrjId关系(DnFuncMapCmPrjIdRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDnFuncMapCmPrjIdRelaDA : clsCommBase4DA
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
 return clsDnFuncMapCmPrjIdRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDnFuncMapCmPrjIdRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDnFuncMapCmPrjIdRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDnFuncMapCmPrjIdRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDnFuncMapCmPrjIdRelaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDnFuncMapId)
{
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:DnFuncMapCmPrjIdRela中,检查关键字,长度不正确!(clsDnFuncMapCmPrjIdRelaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DnFuncMapCmPrjIdRela中,关键字不能为空 或 null!(clsDnFuncMapCmPrjIdRelaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFuncMapId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDnFuncMapCmPrjIdRelaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DnFuncMapCmPrjIdRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDataTable_DnFuncMapCmPrjIdRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMapCmPrjIdRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMapCmPrjIdRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DnFuncMapCmPrjIdRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnFuncMapCmPrjIdRela.* " + 
$"from DnFuncMapCmPrjIdRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnFuncMapCmPrjIdRela.DnFuncMapId not in " + 
$"(Select top {intTop_In} DnFuncMapCmPrjIdRela.DnFuncMapId from DnFuncMapCmPrjIdRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMapCmPrjIdRela where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from DnFuncMapCmPrjIdRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMapCmPrjIdRela where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from DnFuncMapCmPrjIdRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DnFuncMapCmPrjIdRela.* " + 
$"from DnFuncMapCmPrjIdRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DnFuncMapCmPrjIdRela.DnFuncMapId not in " + 
$"(Select top {intTop_In} DnFuncMapCmPrjIdRela.DnFuncMapId from DnFuncMapCmPrjIdRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMapCmPrjIdRela where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from DnFuncMapCmPrjIdRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DnFuncMapCmPrjIdRela where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from DnFuncMapCmPrjIdRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDnFuncMapCmPrjIdRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA:GetObjLst)", objException.Message));
}
List<clsDnFuncMapCmPrjIdRelaEN> arrObjLst = new List<clsDnFuncMapCmPrjIdRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN = new clsDnFuncMapCmPrjIdRelaEN();
try
{
objDnFuncMapCmPrjIdRelaEN.DnFuncMapId = objRow[conDnFuncMapCmPrjIdRela.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapCmPrjIdRelaEN.CmPrjId = objRow[conDnFuncMapCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objDnFuncMapCmPrjIdRelaEN.UpdDate = objRow[conDnFuncMapCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapCmPrjIdRelaEN.UpdUser = objRow[conDnFuncMapCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objDnFuncMapCmPrjIdRelaEN.Memo = objRow[conDnFuncMapCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetObjLst)", objException.Message));
}
objDnFuncMapCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnFuncMapCmPrjIdRelaEN);
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
public List<clsDnFuncMapCmPrjIdRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsDnFuncMapCmPrjIdRelaEN> arrObjLst = new List<clsDnFuncMapCmPrjIdRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN = new clsDnFuncMapCmPrjIdRelaEN();
try
{
objDnFuncMapCmPrjIdRelaEN.DnFuncMapId = objRow[conDnFuncMapCmPrjIdRela.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapCmPrjIdRelaEN.CmPrjId = objRow[conDnFuncMapCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objDnFuncMapCmPrjIdRelaEN.UpdDate = objRow[conDnFuncMapCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapCmPrjIdRelaEN.UpdUser = objRow[conDnFuncMapCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objDnFuncMapCmPrjIdRelaEN.Memo = objRow[conDnFuncMapCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetObjLst)", objException.Message));
}
objDnFuncMapCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDnFuncMapCmPrjIdRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDnFuncMapCmPrjIdRela(ref clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where DnFuncMapId = " + "'"+ objDnFuncMapCmPrjIdRelaEN.DnFuncMapId+"'" + " and CmPrjId = " + "'"+ objDnFuncMapCmPrjIdRelaEN.CmPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDnFuncMapCmPrjIdRelaEN.DnFuncMapId = objDT.Rows[0][conDnFuncMapCmPrjIdRela.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objDnFuncMapCmPrjIdRelaEN.CmPrjId = objDT.Rows[0][conDnFuncMapCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objDnFuncMapCmPrjIdRelaEN.UpdDate = objDT.Rows[0][conDnFuncMapCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFuncMapCmPrjIdRelaEN.UpdUser = objDT.Rows[0][conDnFuncMapCmPrjIdRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFuncMapCmPrjIdRelaEN.Memo = objDT.Rows[0][conDnFuncMapCmPrjIdRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetDnFuncMapCmPrjIdRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public clsDnFuncMapCmPrjIdRelaEN GetObjByKeyLst(string strDnFuncMapId,string strCmPrjId)
{
CheckPrimaryKey(strDnFuncMapId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where DnFuncMapId = " + "'"+ strDnFuncMapId+"'" + " and CmPrjId = " + "'"+ strCmPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN = new clsDnFuncMapCmPrjIdRelaEN();
try
{
 objDnFuncMapCmPrjIdRelaEN.DnFuncMapId = objRow[conDnFuncMapCmPrjIdRela.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objDnFuncMapCmPrjIdRelaEN.CmPrjId = objRow[conDnFuncMapCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objDnFuncMapCmPrjIdRelaEN.UpdDate = objRow[conDnFuncMapCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFuncMapCmPrjIdRelaEN.UpdUser = objRow[conDnFuncMapCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDnFuncMapCmPrjIdRelaEN.Memo = objRow[conDnFuncMapCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetObjByKeyLst)", objException.Message));
}
return objDnFuncMapCmPrjIdRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDnFuncMapCmPrjIdRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN = new clsDnFuncMapCmPrjIdRelaEN()
{
DnFuncMapId = objRow[conDnFuncMapCmPrjIdRela.DnFuncMapId].ToString().Trim(), //函数映射Id
CmPrjId = objRow[conDnFuncMapCmPrjIdRela.CmPrjId].ToString().Trim(), //Cm工程Id
UpdDate = objRow[conDnFuncMapCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDnFuncMapCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDnFuncMapCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.Memo].ToString().Trim() //说明
};
objDnFuncMapCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnFuncMapCmPrjIdRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDnFuncMapCmPrjIdRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN = new clsDnFuncMapCmPrjIdRelaEN();
try
{
objDnFuncMapCmPrjIdRelaEN.DnFuncMapId = objRow[conDnFuncMapCmPrjIdRela.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapCmPrjIdRelaEN.CmPrjId = objRow[conDnFuncMapCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objDnFuncMapCmPrjIdRelaEN.UpdDate = objRow[conDnFuncMapCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapCmPrjIdRelaEN.UpdUser = objRow[conDnFuncMapCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objDnFuncMapCmPrjIdRelaEN.Memo = objRow[conDnFuncMapCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetObjByDataRowDnFuncMapCmPrjIdRela)", objException.Message));
}
objDnFuncMapCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnFuncMapCmPrjIdRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDnFuncMapCmPrjIdRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN = new clsDnFuncMapCmPrjIdRelaEN();
try
{
objDnFuncMapCmPrjIdRelaEN.DnFuncMapId = objRow[conDnFuncMapCmPrjIdRela.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapCmPrjIdRelaEN.CmPrjId = objRow[conDnFuncMapCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objDnFuncMapCmPrjIdRelaEN.UpdDate = objRow[conDnFuncMapCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapCmPrjIdRelaEN.UpdUser = objRow[conDnFuncMapCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objDnFuncMapCmPrjIdRelaEN.Memo = objRow[conDnFuncMapCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conDnFuncMapCmPrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: GetObjByDataRow)", objException.Message));
}
objDnFuncMapCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDnFuncMapCmPrjIdRelaEN;
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
objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnFuncMapCmPrjIdRelaEN._CurrTabName, conDnFuncMapCmPrjIdRela.DnFuncMapId, 8, "");
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
objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDnFuncMapCmPrjIdRelaEN._CurrTabName, conDnFuncMapCmPrjIdRela.DnFuncMapId, 8, strPrefix);
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
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DnFuncMapId,CmPrjId from DnFuncMapCmPrjIdRela where " + strCondition;
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
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DnFuncMapId,CmPrjId from DnFuncMapCmPrjIdRela where " + strCondition;
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDnFuncMapId, string strCmPrjId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnFuncMapCmPrjIdRela", "DnFuncMapId = " + "'"+ strDnFuncMapId+"'" + " and CmPrjId = " + "'"+ strCmPrjId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DnFuncMapCmPrjIdRela", strCondition))
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
objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DnFuncMapCmPrjIdRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN)
 {
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapCmPrjIdRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnFuncMapCmPrjIdRela");
objRow = objDS.Tables["DnFuncMapCmPrjIdRela"].NewRow();
objRow[conDnFuncMapCmPrjIdRela.DnFuncMapId] = objDnFuncMapCmPrjIdRelaEN.DnFuncMapId; //函数映射Id
objRow[conDnFuncMapCmPrjIdRela.CmPrjId] = objDnFuncMapCmPrjIdRelaEN.CmPrjId; //Cm工程Id
 if (objDnFuncMapCmPrjIdRelaEN.UpdDate !=  "")
 {
objRow[conDnFuncMapCmPrjIdRela.UpdDate] = objDnFuncMapCmPrjIdRelaEN.UpdDate; //修改日期
 }
 if (objDnFuncMapCmPrjIdRelaEN.UpdUser !=  "")
 {
objRow[conDnFuncMapCmPrjIdRela.UpdUser] = objDnFuncMapCmPrjIdRelaEN.UpdUser; //修改者
 }
 if (objDnFuncMapCmPrjIdRelaEN.Memo !=  "")
 {
objRow[conDnFuncMapCmPrjIdRela.Memo] = objDnFuncMapCmPrjIdRelaEN.Memo; //说明
 }
objDS.Tables[clsDnFuncMapCmPrjIdRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDnFuncMapCmPrjIdRelaEN._CurrTabName);
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
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN)
{
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapCmPrjIdRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFuncMapCmPrjIdRelaEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.DnFuncMapId);
 var strDnFuncMapId = objDnFuncMapCmPrjIdRelaEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFuncMapId + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.CmPrjId);
 var strCmPrjId = objDnFuncMapCmPrjIdRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.UpdDate);
 var strUpdDate = objDnFuncMapCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.UpdUser);
 var strUpdUser = objDnFuncMapCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.Memo);
 var strMemo = objDnFuncMapCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFuncMapCmPrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN)
{
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapCmPrjIdRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFuncMapCmPrjIdRelaEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.DnFuncMapId);
 var strDnFuncMapId = objDnFuncMapCmPrjIdRelaEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFuncMapId + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.CmPrjId);
 var strCmPrjId = objDnFuncMapCmPrjIdRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.UpdDate);
 var strUpdDate = objDnFuncMapCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.UpdUser);
 var strUpdUser = objDnFuncMapCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.Memo);
 var strMemo = objDnFuncMapCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFuncMapCmPrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDnFuncMapCmPrjIdRelaEN.DnFuncMapId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapCmPrjIdRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFuncMapCmPrjIdRelaEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.DnFuncMapId);
 var strDnFuncMapId = objDnFuncMapCmPrjIdRelaEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFuncMapId + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.CmPrjId);
 var strCmPrjId = objDnFuncMapCmPrjIdRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.UpdDate);
 var strUpdDate = objDnFuncMapCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.UpdUser);
 var strUpdUser = objDnFuncMapCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.Memo);
 var strMemo = objDnFuncMapCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFuncMapCmPrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDnFuncMapCmPrjIdRelaEN.DnFuncMapId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDnFuncMapCmPrjIdRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDnFuncMapCmPrjIdRelaEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.DnFuncMapId);
 var strDnFuncMapId = objDnFuncMapCmPrjIdRelaEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFuncMapId + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.CmPrjId);
 var strCmPrjId = objDnFuncMapCmPrjIdRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.UpdDate);
 var strUpdDate = objDnFuncMapCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.UpdUser);
 var strUpdUser = objDnFuncMapCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDnFuncMapCmPrjIdRela.Memo);
 var strMemo = objDnFuncMapCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DnFuncMapCmPrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDnFuncMapCmPrjIdRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where DnFuncMapId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DnFuncMapCmPrjIdRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDnFuncMapId = oRow[conDnFuncMapCmPrjIdRela.DnFuncMapId].ToString().Trim();
string strCmPrjId = oRow[conDnFuncMapCmPrjIdRela.CmPrjId].ToString().Trim();
if (IsExist(strDnFuncMapId,strCmPrjId))
{
 string strResult = "关键字变量值为:" + string.Format("DnFuncMapId = {0},CmPrjId = {1}", strDnFuncMapId,strCmPrjId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDnFuncMapCmPrjIdRelaEN._CurrTabName ].NewRow();
objRow[conDnFuncMapCmPrjIdRela.DnFuncMapId] = oRow[conDnFuncMapCmPrjIdRela.DnFuncMapId].ToString().Trim(); //函数映射Id
objRow[conDnFuncMapCmPrjIdRela.CmPrjId] = oRow[conDnFuncMapCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objRow[conDnFuncMapCmPrjIdRela.UpdDate] = oRow[conDnFuncMapCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objRow[conDnFuncMapCmPrjIdRela.UpdUser] = oRow[conDnFuncMapCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objRow[conDnFuncMapCmPrjIdRela.Memo] = oRow[conDnFuncMapCmPrjIdRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDnFuncMapCmPrjIdRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDnFuncMapCmPrjIdRelaEN._CurrTabName);
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
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN)
{
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapCmPrjIdRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from DnFuncMapCmPrjIdRela where DnFuncMapId = " + "'"+ objDnFuncMapCmPrjIdRelaEN.DnFuncMapId+"'" + " and CmPrjId = " + "'"+ objDnFuncMapCmPrjIdRelaEN.CmPrjId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDnFuncMapCmPrjIdRelaEN._CurrTabName);
if (objDS.Tables[clsDnFuncMapCmPrjIdRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DnFuncMapId = " + "'"+ objDnFuncMapCmPrjIdRelaEN.DnFuncMapId+"'" + " and CmPrjId = " + "'"+ objDnFuncMapCmPrjIdRelaEN.CmPrjId+"'");
return false;
}
objRow = objDS.Tables[clsDnFuncMapCmPrjIdRelaEN._CurrTabName].Rows[0];
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.DnFuncMapId))
 {
objRow[conDnFuncMapCmPrjIdRela.DnFuncMapId] = objDnFuncMapCmPrjIdRelaEN.DnFuncMapId; //函数映射Id
 }
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.CmPrjId))
 {
objRow[conDnFuncMapCmPrjIdRela.CmPrjId] = objDnFuncMapCmPrjIdRelaEN.CmPrjId; //Cm工程Id
 }
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdDate))
 {
objRow[conDnFuncMapCmPrjIdRela.UpdDate] = objDnFuncMapCmPrjIdRelaEN.UpdDate; //修改日期
 }
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdUser))
 {
objRow[conDnFuncMapCmPrjIdRela.UpdUser] = objDnFuncMapCmPrjIdRelaEN.UpdUser; //修改者
 }
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.Memo))
 {
objRow[conDnFuncMapCmPrjIdRela.Memo] = objDnFuncMapCmPrjIdRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDnFuncMapCmPrjIdRelaEN._CurrTabName);
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
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN)
{
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapCmPrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DnFuncMapCmPrjIdRela Set ");
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdDate))
 {
 if (objDnFuncMapCmPrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFuncMapCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnFuncMapCmPrjIdRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMapCmPrjIdRela.UpdDate); //修改日期
 }
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdUser))
 {
 if (objDnFuncMapCmPrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFuncMapCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnFuncMapCmPrjIdRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMapCmPrjIdRela.UpdUser); //修改者
 }
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.Memo))
 {
 if (objDnFuncMapCmPrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objDnFuncMapCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnFuncMapCmPrjIdRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMapCmPrjIdRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnFuncMapId = '{0}' And CmPrjId = '{1}'", objDnFuncMapCmPrjIdRelaEN.DnFuncMapId,objDnFuncMapCmPrjIdRelaEN.CmPrjId); 
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
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN, string strCondition)
{
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapCmPrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnFuncMapCmPrjIdRela Set ");
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdDate))
 {
 if (objDnFuncMapCmPrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFuncMapCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdUser))
 {
 if (objDnFuncMapCmPrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFuncMapCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.Memo))
 {
 if (objDnFuncMapCmPrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objDnFuncMapCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapCmPrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnFuncMapCmPrjIdRela Set ");
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdDate))
 {
 if (objDnFuncMapCmPrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFuncMapCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdUser))
 {
 if (objDnFuncMapCmPrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFuncMapCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.Memo))
 {
 if (objDnFuncMapCmPrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objDnFuncMapCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDnFuncMapCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDnFuncMapCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDnFuncMapCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDnFuncMapCmPrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DnFuncMapCmPrjIdRela Set ");
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdDate))
 {
 if (objDnFuncMapCmPrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objDnFuncMapCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDnFuncMapCmPrjIdRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMapCmPrjIdRela.UpdDate); //修改日期
 }
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.UpdUser))
 {
 if (objDnFuncMapCmPrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objDnFuncMapCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDnFuncMapCmPrjIdRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMapCmPrjIdRela.UpdUser); //修改者
 }
 }
 
 if (objDnFuncMapCmPrjIdRelaEN.IsUpdated(conDnFuncMapCmPrjIdRela.Memo))
 {
 if (objDnFuncMapCmPrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objDnFuncMapCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDnFuncMapCmPrjIdRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDnFuncMapCmPrjIdRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnFuncMapId = '{0}' And CmPrjId = '{1}'", objDnFuncMapCmPrjIdRelaEN.DnFuncMapId,objDnFuncMapCmPrjIdRelaEN.CmPrjId); 
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDnFuncMapId,string strCmPrjId) 
{
CheckPrimaryKey(strDnFuncMapId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDnFuncMapId,
 strCmPrjId,
};
 objSQL.ExecSP("DnFuncMapCmPrjIdRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDnFuncMapId,string strCmPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDnFuncMapId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
//删除DnFuncMapCmPrjIdRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnFuncMapCmPrjIdRela where DnFuncMapId = " + "'"+ strDnFuncMapId+"'" + " and CmPrjId = " + "'"+ strCmPrjId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count  == 0) return 0;
int intCount = 0;
foreach (var strKeyLst in arrKeyLsts)
{
string[] sstrKey = strKeyLst.Split('|');
string strDnFuncMapId = sstrKey[0];
string strCmPrjId = sstrKey[1];
 int intRecNum  = this.DelRecord(strDnFuncMapId,strCmPrjId);
 intCount += intRecNum;
}
 return intCount;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDnFuncMapId,string strCmPrjId) 
{
CheckPrimaryKey(strDnFuncMapId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
//删除DnFuncMapCmPrjIdRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DnFuncMapCmPrjIdRela where DnFuncMapId = " + "'"+ strDnFuncMapId+"'" + " and CmPrjId = " + "'"+ strCmPrjId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDnFuncMapCmPrjIdRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: DelDnFuncMapCmPrjIdRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnFuncMapCmPrjIdRela where " + strCondition ;
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
public bool DelDnFuncMapCmPrjIdRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDnFuncMapCmPrjIdRelaDA: DelDnFuncMapCmPrjIdRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DnFuncMapCmPrjIdRela where " + strCondition ;
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
 /// <param name = "objDnFuncMapCmPrjIdRelaENS">源对象</param>
 /// <param name = "objDnFuncMapCmPrjIdRelaENT">目标对象</param>
public void CopyTo(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaENS, clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaENT)
{
objDnFuncMapCmPrjIdRelaENT.DnFuncMapId = objDnFuncMapCmPrjIdRelaENS.DnFuncMapId; //函数映射Id
objDnFuncMapCmPrjIdRelaENT.CmPrjId = objDnFuncMapCmPrjIdRelaENS.CmPrjId; //Cm工程Id
objDnFuncMapCmPrjIdRelaENT.UpdDate = objDnFuncMapCmPrjIdRelaENS.UpdDate; //修改日期
objDnFuncMapCmPrjIdRelaENT.UpdUser = objDnFuncMapCmPrjIdRelaENS.UpdUser; //修改者
objDnFuncMapCmPrjIdRelaENT.Memo = objDnFuncMapCmPrjIdRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.DnFuncMapId, 8, conDnFuncMapCmPrjIdRela.DnFuncMapId);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.CmPrjId, 6, conDnFuncMapCmPrjIdRela.CmPrjId);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.UpdDate, 20, conDnFuncMapCmPrjIdRela.UpdDate);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.UpdUser, 20, conDnFuncMapCmPrjIdRela.UpdUser);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.Memo, 1000, conDnFuncMapCmPrjIdRela.Memo);
//检查字段外键固定长度
 objDnFuncMapCmPrjIdRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.UpdDate, 20, conDnFuncMapCmPrjIdRela.UpdDate);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.UpdUser, 20, conDnFuncMapCmPrjIdRela.UpdUser);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.Memo, 1000, conDnFuncMapCmPrjIdRela.Memo);
//检查外键字段长度
 objDnFuncMapCmPrjIdRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDnFuncMapCmPrjIdRelaEN objDnFuncMapCmPrjIdRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.DnFuncMapId, 8, conDnFuncMapCmPrjIdRela.DnFuncMapId);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.CmPrjId, 6, conDnFuncMapCmPrjIdRela.CmPrjId);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.UpdDate, 20, conDnFuncMapCmPrjIdRela.UpdDate);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.UpdUser, 20, conDnFuncMapCmPrjIdRela.UpdUser);
clsCheckSql.CheckFieldLen(objDnFuncMapCmPrjIdRelaEN.Memo, 1000, conDnFuncMapCmPrjIdRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapCmPrjIdRelaEN.DnFuncMapId, conDnFuncMapCmPrjIdRela.DnFuncMapId);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapCmPrjIdRelaEN.CmPrjId, conDnFuncMapCmPrjIdRela.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapCmPrjIdRelaEN.UpdDate, conDnFuncMapCmPrjIdRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapCmPrjIdRelaEN.UpdUser, conDnFuncMapCmPrjIdRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDnFuncMapCmPrjIdRelaEN.Memo, conDnFuncMapCmPrjIdRela.Memo);
//检查外键字段长度
 objDnFuncMapCmPrjIdRelaEN._IsCheckProperty = true;
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
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
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
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
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
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnFuncMapCmPrjIdRelaEN._CurrTabName);
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
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDnFuncMapCmPrjIdRelaEN._CurrTabName, strCondition);
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
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
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
 objSQL = clsDnFuncMapCmPrjIdRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}