
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewMasterDA
 表名:ViewMaster(00050557)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 界面母版(ViewMaster)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewMasterDA : clsCommBase4DA
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
 return clsViewMasterEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewMasterEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewMasterEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewMasterEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewMasterEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strViewMasterId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strViewMasterId)
{
strViewMasterId = strViewMasterId.Replace("'", "''");
if (strViewMasterId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:ViewMaster中,检查关键字,长度不正确!(clsViewMasterDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewMasterId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ViewMaster中,关键字不能为空 或 null!(clsViewMasterDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewMasterId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsViewMasterDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewMaster(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewMasterDA: GetDataTable_ViewMaster)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewMasterDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewMaster where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewMaster where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewMasterDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewMaster where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewMasterDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewMaster.* " + 
$"from ViewMaster " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewMaster.ViewMasterId not in " + 
$"(Select top {intTop_In} ViewMaster.ViewMasterId from ViewMaster " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewMaster where {1} and ViewMasterId not in (Select top {2} ViewMasterId from ViewMaster where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewMaster where {1} and ViewMasterId not in (Select top {3} ViewMasterId from ViewMaster where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewMasterDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewMaster.* " + 
$"from ViewMaster " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewMaster.ViewMasterId not in " + 
$"(Select top {intTop_In} ViewMaster.ViewMasterId from ViewMaster " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewMaster where {1} and ViewMasterId not in (Select top {2} ViewMasterId from ViewMaster where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewMaster where {1} and ViewMasterId not in (Select top {3} ViewMasterId from ViewMaster where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewMasterEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewMasterDA:GetObjLst)", objException.Message));
}
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = TransNullToInt(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewMasterDA: GetObjLst)", objException.Message));
}
objViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewMasterEN);
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
public List<clsViewMasterEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewMasterDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = TransNullToInt(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewMasterDA: GetObjLst)", objException.Message));
}
objViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewMasterEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewMasterEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewMaster(ref clsViewMasterEN objViewMasterEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where ViewMasterId = " + "'"+ objViewMasterEN.ViewMasterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewMasterEN.ViewMasterId = objDT.Rows[0][conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id(字段类型:char,字段长度:8,是否可空:True)
 objViewMasterEN.ViewMasterName = objDT.Rows[0][conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名(字段类型:varchar,字段长度:50,是否可空:True)
 objViewMasterEN.ViewMasterPath = objDT.Rows[0][conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径(字段类型:varchar,字段长度:100,是否可空:True)
 objViewMasterEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objViewMasterEN.PrjId = objDT.Rows[0][conViewMaster.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewMasterEN.UpdDate = objDT.Rows[0][conViewMaster.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewMasterEN.UpdUser = objDT.Rows[0][conViewMaster.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewMasterEN.Memo = objDT.Rows[0][conViewMaster.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewMasterDA: GetViewMaster)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewMasterId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewMasterEN GetObjByViewMasterId(string strViewMasterId)
{
CheckPrimaryKey(strViewMasterId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where ViewMasterId = " + "'"+ strViewMasterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
 objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id(字段类型:char,字段长度:8,是否可空:True)
 objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名(字段类型:varchar,字段长度:50,是否可空:True)
 objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径(字段类型:varchar,字段长度:100,是否可空:True)
 objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewMasterDA: GetObjByViewMasterId)", objException.Message));
}
return objViewMasterEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewMasterEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewMasterDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN()
{
ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(), //界面母版Id
ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(), //界面母版名
ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(), //界面母版路径
ApplicationTypeId = TransNullToInt(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
PrjId = objRow[conViewMaster.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim() //说明
};
objViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewMasterEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewMasterDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewMasterEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = TransNullToInt(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewMasterDA: GetObjByDataRowViewMaster)", objException.Message));
}
objViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewMasterEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewMasterEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = TransNullToInt(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewMasterDA: GetObjByDataRow)", objException.Message));
}
objViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewMasterEN;
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
objSQL = clsViewMasterDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewMasterEN._CurrTabName, conViewMaster.ViewMasterId, 8, "");
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
objSQL = clsViewMasterDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewMasterEN._CurrTabName, conViewMaster.ViewMasterId, 8, strPrefix);
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
 objSQL = clsViewMasterDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewMasterId from ViewMaster where " + strCondition;
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
 objSQL = clsViewMasterDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewMasterId from ViewMaster where " + strCondition;
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
 /// <param name = "strViewMasterId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strViewMasterId)
{
CheckPrimaryKey(strViewMasterId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewMaster", "ViewMasterId = " + "'"+ strViewMasterId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewMasterDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewMaster", strCondition))
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
objSQL = clsViewMasterDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewMaster");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewMasterEN objViewMasterEN)
 {
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewMasterEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewMaster");
objRow = objDS.Tables["ViewMaster"].NewRow();
objRow[conViewMaster.ViewMasterId] = objViewMasterEN.ViewMasterId; //界面母版Id
objRow[conViewMaster.ViewMasterName] = objViewMasterEN.ViewMasterName; //界面母版名
objRow[conViewMaster.ViewMasterPath] = objViewMasterEN.ViewMasterPath; //界面母版路径
objRow[conViewMaster.ApplicationTypeId] = objViewMasterEN.ApplicationTypeId; //应用程序类型ID
objRow[conViewMaster.PrjId] = objViewMasterEN.PrjId; //工程Id
 if (objViewMasterEN.UpdDate !=  "")
 {
objRow[conViewMaster.UpdDate] = objViewMasterEN.UpdDate; //修改日期
 }
 if (objViewMasterEN.UpdUser !=  "")
 {
objRow[conViewMaster.UpdUser] = objViewMasterEN.UpdUser; //修改者
 }
 if (objViewMasterEN.Memo !=  "")
 {
objRow[conViewMaster.Memo] = objViewMasterEN.Memo; //说明
 }
objDS.Tables[clsViewMasterEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewMasterEN._CurrTabName);
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewMasterEN objViewMasterEN)
{
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewMasterEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewMasterEN.ViewMasterId !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterId);
 var strViewMasterId = objViewMasterEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterId + "'");
 }
 
 if (objViewMasterEN.ViewMasterName !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterName);
 var strViewMasterName = objViewMasterEN.ViewMasterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterName + "'");
 }
 
 if (objViewMasterEN.ViewMasterPath !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterPath);
 var strViewMasterPath = objViewMasterEN.ViewMasterPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterPath + "'");
 }
 
 arrFieldListForInsert.Add(conViewMaster.ApplicationTypeId);
 arrValueListForInsert.Add(objViewMasterEN.ApplicationTypeId.ToString());
 
 if (objViewMasterEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.PrjId);
 var strPrjId = objViewMasterEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewMasterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.UpdDate);
 var strUpdDate = objViewMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewMasterEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.UpdUser);
 var strUpdUser = objViewMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewMasterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.Memo);
 var strMemo = objViewMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewMaster");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewMasterEN objViewMasterEN)
{
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewMasterEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewMasterEN.ViewMasterId !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterId);
 var strViewMasterId = objViewMasterEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterId + "'");
 }
 
 if (objViewMasterEN.ViewMasterName !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterName);
 var strViewMasterName = objViewMasterEN.ViewMasterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterName + "'");
 }
 
 if (objViewMasterEN.ViewMasterPath !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterPath);
 var strViewMasterPath = objViewMasterEN.ViewMasterPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterPath + "'");
 }
 
 arrFieldListForInsert.Add(conViewMaster.ApplicationTypeId);
 arrValueListForInsert.Add(objViewMasterEN.ApplicationTypeId.ToString());
 
 if (objViewMasterEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.PrjId);
 var strPrjId = objViewMasterEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewMasterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.UpdDate);
 var strUpdDate = objViewMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewMasterEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.UpdUser);
 var strUpdUser = objViewMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewMasterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.Memo);
 var strMemo = objViewMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewMaster");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objViewMasterEN.ViewMasterId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewMasterEN objViewMasterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewMasterEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewMasterEN.ViewMasterId !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterId);
 var strViewMasterId = objViewMasterEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterId + "'");
 }
 
 if (objViewMasterEN.ViewMasterName !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterName);
 var strViewMasterName = objViewMasterEN.ViewMasterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterName + "'");
 }
 
 if (objViewMasterEN.ViewMasterPath !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterPath);
 var strViewMasterPath = objViewMasterEN.ViewMasterPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterPath + "'");
 }
 
 arrFieldListForInsert.Add(conViewMaster.ApplicationTypeId);
 arrValueListForInsert.Add(objViewMasterEN.ApplicationTypeId.ToString());
 
 if (objViewMasterEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.PrjId);
 var strPrjId = objViewMasterEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewMasterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.UpdDate);
 var strUpdDate = objViewMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewMasterEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.UpdUser);
 var strUpdUser = objViewMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewMasterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.Memo);
 var strMemo = objViewMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewMaster");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objViewMasterEN.ViewMasterId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewMasterEN objViewMasterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewMasterEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewMasterEN.ViewMasterId !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterId);
 var strViewMasterId = objViewMasterEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterId + "'");
 }
 
 if (objViewMasterEN.ViewMasterName !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterName);
 var strViewMasterName = objViewMasterEN.ViewMasterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterName + "'");
 }
 
 if (objViewMasterEN.ViewMasterPath !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.ViewMasterPath);
 var strViewMasterPath = objViewMasterEN.ViewMasterPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterPath + "'");
 }
 
 arrFieldListForInsert.Add(conViewMaster.ApplicationTypeId);
 arrValueListForInsert.Add(objViewMasterEN.ApplicationTypeId.ToString());
 
 if (objViewMasterEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.PrjId);
 var strPrjId = objViewMasterEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewMasterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.UpdDate);
 var strUpdDate = objViewMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewMasterEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.UpdUser);
 var strUpdUser = objViewMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewMasterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewMaster.Memo);
 var strMemo = objViewMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewMaster");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewMasters(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where ViewMasterId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewMaster");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strViewMasterId = oRow[conViewMaster.ViewMasterId].ToString().Trim();
if (IsExist(strViewMasterId))
{
 string strResult = "关键字变量值为:" + string.Format("ViewMasterId = {0}", strViewMasterId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewMasterEN._CurrTabName ].NewRow();
objRow[conViewMaster.ViewMasterId] = oRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objRow[conViewMaster.ViewMasterName] = oRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objRow[conViewMaster.ViewMasterPath] = oRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objRow[conViewMaster.ApplicationTypeId] = oRow[conViewMaster.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conViewMaster.PrjId] = oRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objRow[conViewMaster.UpdDate] = oRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objRow[conViewMaster.UpdUser] = oRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objRow[conViewMaster.Memo] = oRow[conViewMaster.Memo].ToString().Trim(); //说明
 objDS.Tables[clsViewMasterEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewMasterEN._CurrTabName);
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
 /// <param name = "objViewMasterEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewMasterEN objViewMasterEN)
{
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewMasterEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from ViewMaster where ViewMasterId = " + "'"+ objViewMasterEN.ViewMasterId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewMasterEN._CurrTabName);
if (objDS.Tables[clsViewMasterEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ViewMasterId = " + "'"+ objViewMasterEN.ViewMasterId+"'");
return false;
}
objRow = objDS.Tables[clsViewMasterEN._CurrTabName].Rows[0];
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterId))
 {
objRow[conViewMaster.ViewMasterId] = objViewMasterEN.ViewMasterId; //界面母版Id
 }
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterName))
 {
objRow[conViewMaster.ViewMasterName] = objViewMasterEN.ViewMasterName; //界面母版名
 }
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterPath))
 {
objRow[conViewMaster.ViewMasterPath] = objViewMasterEN.ViewMasterPath; //界面母版路径
 }
 if (objViewMasterEN.IsUpdated(conViewMaster.ApplicationTypeId))
 {
objRow[conViewMaster.ApplicationTypeId] = objViewMasterEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objViewMasterEN.IsUpdated(conViewMaster.PrjId))
 {
objRow[conViewMaster.PrjId] = objViewMasterEN.PrjId; //工程Id
 }
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdDate))
 {
objRow[conViewMaster.UpdDate] = objViewMasterEN.UpdDate; //修改日期
 }
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdUser))
 {
objRow[conViewMaster.UpdUser] = objViewMasterEN.UpdUser; //修改者
 }
 if (objViewMasterEN.IsUpdated(conViewMaster.Memo))
 {
objRow[conViewMaster.Memo] = objViewMasterEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsViewMasterEN._CurrTabName);
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewMasterEN objViewMasterEN)
{
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewMasterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewMaster Set ");
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterName))
 {
 if (objViewMasterEN.ViewMasterName !=  null)
 {
 var strViewMasterName = objViewMasterEN.ViewMasterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewMasterName, conViewMaster.ViewMasterName); //界面母版名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.ViewMasterName); //界面母版名
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterPath))
 {
 if (objViewMasterEN.ViewMasterPath !=  null)
 {
 var strViewMasterPath = objViewMasterEN.ViewMasterPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewMasterPath, conViewMaster.ViewMasterPath); //界面母版路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.ViewMasterPath); //界面母版路径
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewMasterEN.ApplicationTypeId, conViewMaster.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.PrjId))
 {
 if (objViewMasterEN.PrjId !=  null)
 {
 var strPrjId = objViewMasterEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewMaster.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.PrjId); //工程Id
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdDate))
 {
 if (objViewMasterEN.UpdDate !=  null)
 {
 var strUpdDate = objViewMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewMaster.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.UpdDate); //修改日期
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdUser))
 {
 if (objViewMasterEN.UpdUser !=  null)
 {
 var strUpdUser = objViewMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewMaster.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.UpdUser); //修改者
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.Memo))
 {
 if (objViewMasterEN.Memo !=  null)
 {
 var strMemo = objViewMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewMaster.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewMasterId = '{0}'", objViewMasterEN.ViewMasterId); 
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
 /// <param name = "objViewMasterEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewMasterEN objViewMasterEN, string strCondition)
{
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewMasterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewMaster Set ");
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterName))
 {
 if (objViewMasterEN.ViewMasterName !=  null)
 {
 var strViewMasterName = objViewMasterEN.ViewMasterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewMasterName = '{0}',", strViewMasterName); //界面母版名
 }
 else
 {
 sbSQL.Append(" ViewMasterName = null,"); //界面母版名
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterPath))
 {
 if (objViewMasterEN.ViewMasterPath !=  null)
 {
 var strViewMasterPath = objViewMasterEN.ViewMasterPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewMasterPath = '{0}',", strViewMasterPath); //界面母版路径
 }
 else
 {
 sbSQL.Append(" ViewMasterPath = null,"); //界面母版路径
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objViewMasterEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.PrjId))
 {
 if (objViewMasterEN.PrjId !=  null)
 {
 var strPrjId = objViewMasterEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdDate))
 {
 if (objViewMasterEN.UpdDate !=  null)
 {
 var strUpdDate = objViewMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdUser))
 {
 if (objViewMasterEN.UpdUser !=  null)
 {
 var strUpdUser = objViewMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.Memo))
 {
 if (objViewMasterEN.Memo !=  null)
 {
 var strMemo = objViewMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewMasterEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewMasterEN objViewMasterEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewMasterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewMaster Set ");
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterName))
 {
 if (objViewMasterEN.ViewMasterName !=  null)
 {
 var strViewMasterName = objViewMasterEN.ViewMasterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewMasterName = '{0}',", strViewMasterName); //界面母版名
 }
 else
 {
 sbSQL.Append(" ViewMasterName = null,"); //界面母版名
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterPath))
 {
 if (objViewMasterEN.ViewMasterPath !=  null)
 {
 var strViewMasterPath = objViewMasterEN.ViewMasterPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewMasterPath = '{0}',", strViewMasterPath); //界面母版路径
 }
 else
 {
 sbSQL.Append(" ViewMasterPath = null,"); //界面母版路径
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objViewMasterEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.PrjId))
 {
 if (objViewMasterEN.PrjId !=  null)
 {
 var strPrjId = objViewMasterEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdDate))
 {
 if (objViewMasterEN.UpdDate !=  null)
 {
 var strUpdDate = objViewMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdUser))
 {
 if (objViewMasterEN.UpdUser !=  null)
 {
 var strUpdUser = objViewMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.Memo))
 {
 if (objViewMasterEN.Memo !=  null)
 {
 var strMemo = objViewMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewMasterEN objViewMasterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewMasterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewMaster Set ");
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterName))
 {
 if (objViewMasterEN.ViewMasterName !=  null)
 {
 var strViewMasterName = objViewMasterEN.ViewMasterName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewMasterName, conViewMaster.ViewMasterName); //界面母版名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.ViewMasterName); //界面母版名
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ViewMasterPath))
 {
 if (objViewMasterEN.ViewMasterPath !=  null)
 {
 var strViewMasterPath = objViewMasterEN.ViewMasterPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewMasterPath, conViewMaster.ViewMasterPath); //界面母版路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.ViewMasterPath); //界面母版路径
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewMasterEN.ApplicationTypeId, conViewMaster.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.PrjId))
 {
 if (objViewMasterEN.PrjId !=  null)
 {
 var strPrjId = objViewMasterEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewMaster.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.PrjId); //工程Id
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdDate))
 {
 if (objViewMasterEN.UpdDate !=  null)
 {
 var strUpdDate = objViewMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewMaster.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.UpdDate); //修改日期
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.UpdUser))
 {
 if (objViewMasterEN.UpdUser !=  null)
 {
 var strUpdUser = objViewMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewMaster.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.UpdUser); //修改者
 }
 }
 
 if (objViewMasterEN.IsUpdated(conViewMaster.Memo))
 {
 if (objViewMasterEN.Memo !=  null)
 {
 var strMemo = objViewMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewMaster.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewMaster.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewMasterId = '{0}'", objViewMasterEN.ViewMasterId); 
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
 /// <param name = "strViewMasterId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strViewMasterId) 
{
CheckPrimaryKey(strViewMasterId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strViewMasterId,
};
 objSQL.ExecSP("ViewMaster_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strViewMasterId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strViewMasterId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strViewMasterId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
//删除ViewMaster本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewMaster where ViewMasterId = " + "'"+ strViewMasterId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewMaster(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
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
//删除ViewMaster本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewMaster where ViewMasterId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strViewMasterId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strViewMasterId) 
{
CheckPrimaryKey(strViewMasterId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
//删除ViewMaster本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewMaster where ViewMasterId = " + "'"+ strViewMasterId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewMaster(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewMasterDA: DelViewMaster)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewMaster where " + strCondition ;
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
public bool DelViewMasterWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewMasterDA: DelViewMasterWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewMasterDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewMaster where " + strCondition ;
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
 /// <param name = "objViewMasterENS">源对象</param>
 /// <param name = "objViewMasterENT">目标对象</param>
public void CopyTo(clsViewMasterEN objViewMasterENS, clsViewMasterEN objViewMasterENT)
{
objViewMasterENT.ViewMasterId = objViewMasterENS.ViewMasterId; //界面母版Id
objViewMasterENT.ViewMasterName = objViewMasterENS.ViewMasterName; //界面母版名
objViewMasterENT.ViewMasterPath = objViewMasterENS.ViewMasterPath; //界面母版路径
objViewMasterENT.ApplicationTypeId = objViewMasterENS.ApplicationTypeId; //应用程序类型ID
objViewMasterENT.PrjId = objViewMasterENS.PrjId; //工程Id
objViewMasterENT.UpdDate = objViewMasterENS.UpdDate; //修改日期
objViewMasterENT.UpdUser = objViewMasterENS.UpdUser; //修改者
objViewMasterENT.Memo = objViewMasterENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewMasterEN objViewMasterEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewMasterEN.ViewMasterName, conViewMaster.ViewMasterName);
clsCheckSql.CheckFieldNotNull(objViewMasterEN.ViewMasterPath, conViewMaster.ViewMasterPath);
clsCheckSql.CheckFieldNotNull(objViewMasterEN.ApplicationTypeId, conViewMaster.ApplicationTypeId);
clsCheckSql.CheckFieldNotNull(objViewMasterEN.PrjId, conViewMaster.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewMasterEN.ViewMasterId, 8, conViewMaster.ViewMasterId);
clsCheckSql.CheckFieldLen(objViewMasterEN.ViewMasterName, 50, conViewMaster.ViewMasterName);
clsCheckSql.CheckFieldLen(objViewMasterEN.ViewMasterPath, 100, conViewMaster.ViewMasterPath);
clsCheckSql.CheckFieldLen(objViewMasterEN.PrjId, 4, conViewMaster.PrjId);
clsCheckSql.CheckFieldLen(objViewMasterEN.UpdDate, 20, conViewMaster.UpdDate);
clsCheckSql.CheckFieldLen(objViewMasterEN.UpdUser, 20, conViewMaster.UpdUser);
clsCheckSql.CheckFieldLen(objViewMasterEN.Memo, 1000, conViewMaster.Memo);
//检查字段外键固定长度
 objViewMasterEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewMasterEN objViewMasterEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewMasterEN.ViewMasterName, 50, conViewMaster.ViewMasterName);
clsCheckSql.CheckFieldLen(objViewMasterEN.ViewMasterPath, 100, conViewMaster.ViewMasterPath);
clsCheckSql.CheckFieldLen(objViewMasterEN.PrjId, 4, conViewMaster.PrjId);
clsCheckSql.CheckFieldLen(objViewMasterEN.UpdDate, 20, conViewMaster.UpdDate);
clsCheckSql.CheckFieldLen(objViewMasterEN.UpdUser, 20, conViewMaster.UpdUser);
clsCheckSql.CheckFieldLen(objViewMasterEN.Memo, 1000, conViewMaster.Memo);
//检查外键字段长度
 objViewMasterEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewMasterEN objViewMasterEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewMasterEN.ViewMasterId, 8, conViewMaster.ViewMasterId);
clsCheckSql.CheckFieldLen(objViewMasterEN.ViewMasterName, 50, conViewMaster.ViewMasterName);
clsCheckSql.CheckFieldLen(objViewMasterEN.ViewMasterPath, 100, conViewMaster.ViewMasterPath);
clsCheckSql.CheckFieldLen(objViewMasterEN.PrjId, 4, conViewMaster.PrjId);
clsCheckSql.CheckFieldLen(objViewMasterEN.UpdDate, 20, conViewMaster.UpdDate);
clsCheckSql.CheckFieldLen(objViewMasterEN.UpdUser, 20, conViewMaster.UpdUser);
clsCheckSql.CheckFieldLen(objViewMasterEN.Memo, 1000, conViewMaster.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewMasterEN.ViewMasterId, conViewMaster.ViewMasterId);
clsCheckSql.CheckSqlInjection4Field(objViewMasterEN.ViewMasterName, conViewMaster.ViewMasterName);
clsCheckSql.CheckSqlInjection4Field(objViewMasterEN.ViewMasterPath, conViewMaster.ViewMasterPath);
clsCheckSql.CheckSqlInjection4Field(objViewMasterEN.PrjId, conViewMaster.PrjId);
clsCheckSql.CheckSqlInjection4Field(objViewMasterEN.UpdDate, conViewMaster.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewMasterEN.UpdUser, conViewMaster.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objViewMasterEN.Memo, conViewMaster.Memo);
//检查外键字段长度
 objViewMasterEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetViewMasterId()
{
//获取某学院所有专业信息
string strSQL = "select ViewMasterId, ViewMasterName from ViewMaster ";
 clsSpecSQLforSql mySql = clsViewMasterDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewMaster(界面母版),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewMasterEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewMasterEN objViewMasterEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewMasterEN.PrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewMasterEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ViewMasterName = '{0}'", objViewMasterEN.ViewMasterName);
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
 objSQL = clsViewMasterDA.GetSpecSQLObj();
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
 objSQL = clsViewMasterDA.GetSpecSQLObj();
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
 objSQL = clsViewMasterDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewMasterEN._CurrTabName);
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
 objSQL = clsViewMasterDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewMasterEN._CurrTabName, strCondition);
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
 objSQL = clsViewMasterDA.GetSpecSQLObj();
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
 objSQL = clsViewMasterDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}