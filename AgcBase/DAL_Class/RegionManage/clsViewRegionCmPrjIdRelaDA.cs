
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionCmPrjIdRelaDA
 表名:ViewRegionCmPrjIdRela(00050622)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:02
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
 /// 界面区域CmPrjId关系(ViewRegionCmPrjIdRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewRegionCmPrjIdRelaDA : clsCommBase4DA
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
 return clsViewRegionCmPrjIdRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewRegionCmPrjIdRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewRegionCmPrjIdRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewRegionCmPrjIdRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewRegionCmPrjIdRelaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strRegionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strRegionId)
{
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:ViewRegionCmPrjIdRela中,检查关键字,长度不正确!(clsViewRegionCmPrjIdRelaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ViewRegionCmPrjIdRela中,关键字不能为空 或 null!(clsViewRegionCmPrjIdRelaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRegionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsViewRegionCmPrjIdRelaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewRegionCmPrjIdRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetDataTable_ViewRegionCmPrjIdRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionCmPrjIdRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionCmPrjIdRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewRegionCmPrjIdRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewRegionCmPrjIdRela.* " + 
$"from ViewRegionCmPrjIdRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewRegionCmPrjIdRela.RegionId not in " + 
$"(Select top {intTop_In} ViewRegionCmPrjIdRela.RegionId from ViewRegionCmPrjIdRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionCmPrjIdRela where {1} and RegionId not in (Select top {2} RegionId from ViewRegionCmPrjIdRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionCmPrjIdRela where {1} and RegionId not in (Select top {3} RegionId from ViewRegionCmPrjIdRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewRegionCmPrjIdRela.* " + 
$"from ViewRegionCmPrjIdRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewRegionCmPrjIdRela.RegionId not in " + 
$"(Select top {intTop_In} ViewRegionCmPrjIdRela.RegionId from ViewRegionCmPrjIdRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionCmPrjIdRela where {1} and RegionId not in (Select top {2} RegionId from ViewRegionCmPrjIdRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRegionCmPrjIdRela where {1} and RegionId not in (Select top {3} RegionId from ViewRegionCmPrjIdRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewRegionCmPrjIdRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA:GetObjLst)", objException.Message));
}
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetObjLst)", objException.Message));
}
objViewRegionCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
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
public List<clsViewRegionCmPrjIdRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetObjLst)", objException.Message));
}
objViewRegionCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewRegionCmPrjIdRela(ref clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where RegionId = " + "'"+ objViewRegionCmPrjIdRelaEN.RegionId+"'" + " and CmPrjId = " + "'"+ objViewRegionCmPrjIdRelaEN.CmPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewRegionCmPrjIdRelaEN.RegionId = objDT.Rows[0][conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objViewRegionCmPrjIdRelaEN.CmPrjId = objDT.Rows[0][conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objViewRegionCmPrjIdRelaEN.UpdUser = objDT.Rows[0][conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionCmPrjIdRelaEN.UpdDate = objDT.Rows[0][conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionCmPrjIdRelaEN.Memo = objDT.Rows[0][conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetViewRegionCmPrjIdRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewRegionCmPrjIdRelaEN GetObjByKeyLst(string strRegionId,string strCmPrjId)
{
CheckPrimaryKey(strRegionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where RegionId = " + "'"+ strRegionId+"'" + " and CmPrjId = " + "'"+ strCmPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
 objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetObjByKeyLst)", objException.Message));
}
return objViewRegionCmPrjIdRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewRegionCmPrjIdRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN()
{
RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(), //区域Id
CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(), //Cm工程Id
UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim() //说明
};
objViewRegionCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRegionCmPrjIdRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewRegionCmPrjIdRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetObjByDataRowViewRegionCmPrjIdRela)", objException.Message));
}
objViewRegionCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRegionCmPrjIdRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewRegionCmPrjIdRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewRegionCmPrjIdRelaDA: GetObjByDataRow)", objException.Message));
}
objViewRegionCmPrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRegionCmPrjIdRelaEN;
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
objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewRegionCmPrjIdRelaEN._CurrTabName, conViewRegionCmPrjIdRela.RegionId, 10, "");
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
objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewRegionCmPrjIdRelaEN._CurrTabName, conViewRegionCmPrjIdRela.RegionId, 10, strPrefix);
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
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RegionId,CmPrjId from ViewRegionCmPrjIdRela where " + strCondition;
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
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RegionId,CmPrjId from ViewRegionCmPrjIdRela where " + strCondition;
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strRegionId, string strCmPrjId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewRegionCmPrjIdRela", "RegionId = " + "'"+ strRegionId+"'" + " and CmPrjId = " + "'"+ strCmPrjId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewRegionCmPrjIdRela", strCondition))
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
objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewRegionCmPrjIdRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
 {
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionCmPrjIdRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewRegionCmPrjIdRela");
objRow = objDS.Tables["ViewRegionCmPrjIdRela"].NewRow();
objRow[conViewRegionCmPrjIdRela.RegionId] = objViewRegionCmPrjIdRelaEN.RegionId; //区域Id
objRow[conViewRegionCmPrjIdRela.CmPrjId] = objViewRegionCmPrjIdRelaEN.CmPrjId; //Cm工程Id
 if (objViewRegionCmPrjIdRelaEN.UpdUser !=  "")
 {
objRow[conViewRegionCmPrjIdRela.UpdUser] = objViewRegionCmPrjIdRelaEN.UpdUser; //修改者
 }
 if (objViewRegionCmPrjIdRelaEN.UpdDate !=  "")
 {
objRow[conViewRegionCmPrjIdRela.UpdDate] = objViewRegionCmPrjIdRelaEN.UpdDate; //修改日期
 }
 if (objViewRegionCmPrjIdRelaEN.Memo !=  "")
 {
objRow[conViewRegionCmPrjIdRela.Memo] = objViewRegionCmPrjIdRelaEN.Memo; //说明
 }
objDS.Tables[clsViewRegionCmPrjIdRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewRegionCmPrjIdRelaEN._CurrTabName);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionCmPrjIdRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewRegionCmPrjIdRelaEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.RegionId);
 var strRegionId = objViewRegionCmPrjIdRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.CmPrjId);
 var strCmPrjId = objViewRegionCmPrjIdRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.UpdUser);
 var strUpdUser = objViewRegionCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.UpdDate);
 var strUpdDate = objViewRegionCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.Memo);
 var strMemo = objViewRegionCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegionCmPrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionCmPrjIdRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewRegionCmPrjIdRelaEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.RegionId);
 var strRegionId = objViewRegionCmPrjIdRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.CmPrjId);
 var strCmPrjId = objViewRegionCmPrjIdRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.UpdUser);
 var strUpdUser = objViewRegionCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.UpdDate);
 var strUpdDate = objViewRegionCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.Memo);
 var strMemo = objViewRegionCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegionCmPrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objViewRegionCmPrjIdRelaEN.RegionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionCmPrjIdRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewRegionCmPrjIdRelaEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.RegionId);
 var strRegionId = objViewRegionCmPrjIdRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.CmPrjId);
 var strCmPrjId = objViewRegionCmPrjIdRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.UpdUser);
 var strUpdUser = objViewRegionCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.UpdDate);
 var strUpdDate = objViewRegionCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.Memo);
 var strMemo = objViewRegionCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegionCmPrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objViewRegionCmPrjIdRelaEN.RegionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionCmPrjIdRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewRegionCmPrjIdRelaEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.RegionId);
 var strRegionId = objViewRegionCmPrjIdRelaEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.CmPrjId);
 var strCmPrjId = objViewRegionCmPrjIdRelaEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmPrjId + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.UpdUser);
 var strUpdUser = objViewRegionCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.UpdDate);
 var strUpdDate = objViewRegionCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionCmPrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegionCmPrjIdRela.Memo);
 var strMemo = objViewRegionCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegionCmPrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewRegionCmPrjIdRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where RegionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewRegionCmPrjIdRela");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewRegionCmPrjIdRelaEN._CurrTabName ].NewRow();
objRow[conViewRegionCmPrjIdRela.RegionId] = oRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objRow[conViewRegionCmPrjIdRela.CmPrjId] = oRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objRow[conViewRegionCmPrjIdRela.UpdUser] = oRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objRow[conViewRegionCmPrjIdRela.UpdDate] = oRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objRow[conViewRegionCmPrjIdRela.Memo] = oRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsViewRegionCmPrjIdRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewRegionCmPrjIdRelaEN._CurrTabName);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionCmPrjIdRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegionCmPrjIdRela where RegionId = " + "'"+ objViewRegionCmPrjIdRelaEN.RegionId+"'" + " and CmPrjId = " + "'"+ objViewRegionCmPrjIdRelaEN.CmPrjId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewRegionCmPrjIdRelaEN._CurrTabName);
if (objDS.Tables[clsViewRegionCmPrjIdRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RegionId = " + "'"+ objViewRegionCmPrjIdRelaEN.RegionId+"'" + " and CmPrjId = " + "'"+ objViewRegionCmPrjIdRelaEN.CmPrjId+"'");
return false;
}
objRow = objDS.Tables[clsViewRegionCmPrjIdRelaEN._CurrTabName].Rows[0];
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.RegionId))
 {
objRow[conViewRegionCmPrjIdRela.RegionId] = objViewRegionCmPrjIdRelaEN.RegionId; //区域Id
 }
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.CmPrjId))
 {
objRow[conViewRegionCmPrjIdRela.CmPrjId] = objViewRegionCmPrjIdRelaEN.CmPrjId; //Cm工程Id
 }
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdUser))
 {
objRow[conViewRegionCmPrjIdRela.UpdUser] = objViewRegionCmPrjIdRelaEN.UpdUser; //修改者
 }
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdDate))
 {
objRow[conViewRegionCmPrjIdRela.UpdDate] = objViewRegionCmPrjIdRelaEN.UpdDate; //修改日期
 }
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.Memo))
 {
objRow[conViewRegionCmPrjIdRela.Memo] = objViewRegionCmPrjIdRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsViewRegionCmPrjIdRelaEN._CurrTabName);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionCmPrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewRegionCmPrjIdRela Set ");
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdUser))
 {
 if (objViewRegionCmPrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewRegionCmPrjIdRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionCmPrjIdRela.UpdUser); //修改者
 }
 }
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdDate))
 {
 if (objViewRegionCmPrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewRegionCmPrjIdRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionCmPrjIdRela.UpdDate); //修改日期
 }
 }
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.Memo))
 {
 if (objViewRegionCmPrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objViewRegionCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewRegionCmPrjIdRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionCmPrjIdRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RegionId = '{0}' And CmPrjId = '{1}'", objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId); 
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, string strCondition)
{
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionCmPrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRegionCmPrjIdRela Set ");
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdUser))
 {
 if (objViewRegionCmPrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdDate))
 {
 if (objViewRegionCmPrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.Memo))
 {
 if (objViewRegionCmPrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objViewRegionCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionCmPrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRegionCmPrjIdRela Set ");
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdUser))
 {
 if (objViewRegionCmPrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdDate))
 {
 if (objViewRegionCmPrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.Memo))
 {
 if (objViewRegionCmPrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objViewRegionCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionCmPrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionCmPrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRegionCmPrjIdRela Set ");
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdUser))
 {
 if (objViewRegionCmPrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionCmPrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewRegionCmPrjIdRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionCmPrjIdRela.UpdUser); //修改者
 }
 }
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.UpdDate))
 {
 if (objViewRegionCmPrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionCmPrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewRegionCmPrjIdRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionCmPrjIdRela.UpdDate); //修改日期
 }
 }
 
 if (objViewRegionCmPrjIdRelaEN.IsUpdated(conViewRegionCmPrjIdRela.Memo))
 {
 if (objViewRegionCmPrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objViewRegionCmPrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewRegionCmPrjIdRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegionCmPrjIdRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RegionId = '{0}' And CmPrjId = '{1}'", objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId); 
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strRegionId,string strCmPrjId) 
{
CheckPrimaryKey(strRegionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strRegionId,
 strCmPrjId,
};
 objSQL.ExecSP("ViewRegionCmPrjIdRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strRegionId,string strCmPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strRegionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
//删除ViewRegionCmPrjIdRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRegionCmPrjIdRela where RegionId = " + "'"+ strRegionId+"'" + " and CmPrjId = " + "'"+ strCmPrjId+"'";
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
string strRegionId = sstrKey[0];
string strCmPrjId = sstrKey[1];
 int intRecNum  = this.DelRecord(strRegionId,strCmPrjId);
 intCount += intRecNum;
}
 return intCount;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strRegionId,string strCmPrjId) 
{
CheckPrimaryKey(strRegionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
//删除ViewRegionCmPrjIdRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRegionCmPrjIdRela where RegionId = " + "'"+ strRegionId+"'" + " and CmPrjId = " + "'"+ strCmPrjId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewRegionCmPrjIdRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: DelViewRegionCmPrjIdRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewRegionCmPrjIdRela where " + strCondition ;
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
public bool DelViewRegionCmPrjIdRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewRegionCmPrjIdRelaDA: DelViewRegionCmPrjIdRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewRegionCmPrjIdRela where " + strCondition ;
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
 /// <param name = "objViewRegionCmPrjIdRelaENS">源对象</param>
 /// <param name = "objViewRegionCmPrjIdRelaENT">目标对象</param>
public void CopyTo(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENS, clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENT)
{
objViewRegionCmPrjIdRelaENT.RegionId = objViewRegionCmPrjIdRelaENS.RegionId; //区域Id
objViewRegionCmPrjIdRelaENT.CmPrjId = objViewRegionCmPrjIdRelaENS.CmPrjId; //Cm工程Id
objViewRegionCmPrjIdRelaENT.UpdUser = objViewRegionCmPrjIdRelaENS.UpdUser; //修改者
objViewRegionCmPrjIdRelaENT.UpdDate = objViewRegionCmPrjIdRelaENS.UpdDate; //修改日期
objViewRegionCmPrjIdRelaENT.Memo = objViewRegionCmPrjIdRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.RegionId, 10, conViewRegionCmPrjIdRela.RegionId);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.CmPrjId, 6, conViewRegionCmPrjIdRela.CmPrjId);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.UpdUser, 20, conViewRegionCmPrjIdRela.UpdUser);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.UpdDate, 20, conViewRegionCmPrjIdRela.UpdDate);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.Memo, 1000, conViewRegionCmPrjIdRela.Memo);
//检查字段外键固定长度
 objViewRegionCmPrjIdRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.UpdUser, 20, conViewRegionCmPrjIdRela.UpdUser);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.UpdDate, 20, conViewRegionCmPrjIdRela.UpdDate);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.Memo, 1000, conViewRegionCmPrjIdRela.Memo);
//检查外键字段长度
 objViewRegionCmPrjIdRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.RegionId, 10, conViewRegionCmPrjIdRela.RegionId);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.CmPrjId, 6, conViewRegionCmPrjIdRela.CmPrjId);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.UpdUser, 20, conViewRegionCmPrjIdRela.UpdUser);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.UpdDate, 20, conViewRegionCmPrjIdRela.UpdDate);
clsCheckSql.CheckFieldLen(objViewRegionCmPrjIdRelaEN.Memo, 1000, conViewRegionCmPrjIdRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewRegionCmPrjIdRelaEN.RegionId, conViewRegionCmPrjIdRela.RegionId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionCmPrjIdRelaEN.CmPrjId, conViewRegionCmPrjIdRela.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionCmPrjIdRelaEN.UpdUser, conViewRegionCmPrjIdRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objViewRegionCmPrjIdRelaEN.UpdDate, conViewRegionCmPrjIdRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewRegionCmPrjIdRelaEN.Memo, conViewRegionCmPrjIdRela.Memo);
//检查外键字段长度
 objViewRegionCmPrjIdRelaEN._IsCheckProperty = true;
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
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
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
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
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
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewRegionCmPrjIdRelaEN._CurrTabName);
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
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewRegionCmPrjIdRelaEN._CurrTabName, strCondition);
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
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
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
 objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}