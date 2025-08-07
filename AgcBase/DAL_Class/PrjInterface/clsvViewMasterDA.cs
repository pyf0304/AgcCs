
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewMasterDA
 表名:vViewMaster(00050558)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// vViewMaster(vViewMaster)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewMasterDA : clsCommBase4DA
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
 return clsvViewMasterEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewMasterEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewMasterEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewMasterEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewMasterEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vViewMaster中,检查关键字,长度不正确!(clsvViewMasterDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewMasterId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vViewMaster中,关键字不能为空 或 null!(clsvViewMasterDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewMasterId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvViewMasterDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from vViewMaster where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewMaster(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewMasterDA: GetDataTable_vViewMaster)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from vViewMaster where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from vViewMaster where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewMasterDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewMaster where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewMaster where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewMasterDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewMaster where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewMasterDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewMaster.* " + 
$"from vViewMaster " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewMaster.ViewMasterId not in " + 
$"(Select top {intTop_In} vViewMaster.ViewMasterId from vViewMaster " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewMaster where {1} and ViewMasterId not in (Select top {2} ViewMasterId from vViewMaster where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewMaster where {1} and ViewMasterId not in (Select top {3} ViewMasterId from vViewMaster where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewMasterDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewMaster.* " + 
$"from vViewMaster " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewMaster.ViewMasterId not in " + 
$"(Select top {intTop_In} vViewMaster.ViewMasterId from vViewMaster " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewMaster where {1} and ViewMasterId not in (Select top {2} ViewMasterId from vViewMaster where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewMaster where {1} and ViewMasterId not in (Select top {3} ViewMasterId from vViewMaster where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewMasterEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewMasterDA:GetObjLst)", objException.Message));
}
List<clsvViewMasterEN> arrObjLst = new List<clsvViewMasterEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from vViewMaster where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewMasterEN objvViewMasterEN = new clsvViewMasterEN();
try
{
objvViewMasterEN.ViewMasterId = objRow[convViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewMasterEN.ViewMasterName = objRow[convViewMaster.ViewMasterName] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objvViewMasterEN.ViewMasterPath = objRow[convViewMaster.ViewMasterPath] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objvViewMasterEN.ApplicationTypeId = TransNullToInt(objRow[convViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewMasterEN.ApplicationTypeName = objRow[convViewMaster.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewMasterEN.ApplicationTypeSimName = objRow[convViewMaster.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewMaster.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewMasterEN.PrjId = objRow[convViewMaster.PrjId].ToString().Trim(); //工程Id
objvViewMasterEN.UpdDate = objRow[convViewMaster.UpdDate] == DBNull.Value ? null : objRow[convViewMaster.UpdDate].ToString().Trim(); //修改日期
objvViewMasterEN.UpdUser = objRow[convViewMaster.UpdUser] == DBNull.Value ? null : objRow[convViewMaster.UpdUser].ToString().Trim(); //修改者
objvViewMasterEN.Memo = objRow[convViewMaster.Memo] == DBNull.Value ? null : objRow[convViewMaster.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewMasterDA: GetObjLst)", objException.Message));
}
objvViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewMasterEN);
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
public List<clsvViewMasterEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewMasterDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewMasterEN> arrObjLst = new List<clsvViewMasterEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewMasterEN objvViewMasterEN = new clsvViewMasterEN();
try
{
objvViewMasterEN.ViewMasterId = objRow[convViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewMasterEN.ViewMasterName = objRow[convViewMaster.ViewMasterName] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objvViewMasterEN.ViewMasterPath = objRow[convViewMaster.ViewMasterPath] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objvViewMasterEN.ApplicationTypeId = TransNullToInt(objRow[convViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewMasterEN.ApplicationTypeName = objRow[convViewMaster.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewMasterEN.ApplicationTypeSimName = objRow[convViewMaster.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewMaster.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewMasterEN.PrjId = objRow[convViewMaster.PrjId].ToString().Trim(); //工程Id
objvViewMasterEN.UpdDate = objRow[convViewMaster.UpdDate] == DBNull.Value ? null : objRow[convViewMaster.UpdDate].ToString().Trim(); //修改日期
objvViewMasterEN.UpdUser = objRow[convViewMaster.UpdUser] == DBNull.Value ? null : objRow[convViewMaster.UpdUser].ToString().Trim(); //修改者
objvViewMasterEN.Memo = objRow[convViewMaster.Memo] == DBNull.Value ? null : objRow[convViewMaster.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewMasterDA: GetObjLst)", objException.Message));
}
objvViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewMasterEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewMasterEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewMaster(ref clsvViewMasterEN objvViewMasterEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from vViewMaster where ViewMasterId = " + "'"+ objvViewMasterEN.ViewMasterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewMasterEN.ViewMasterId = objDT.Rows[0][convViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewMasterEN.ViewMasterName = objDT.Rows[0][convViewMaster.ViewMasterName].ToString().Trim(); //界面母版名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewMasterEN.ViewMasterPath = objDT.Rows[0][convViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewMasterEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewMasterEN.ApplicationTypeName = objDT.Rows[0][convViewMaster.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewMasterEN.ApplicationTypeSimName = objDT.Rows[0][convViewMaster.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewMasterEN.PrjId = objDT.Rows[0][convViewMaster.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewMasterEN.UpdDate = objDT.Rows[0][convViewMaster.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewMasterEN.UpdUser = objDT.Rows[0][convViewMaster.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewMasterEN.Memo = objDT.Rows[0][convViewMaster.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewMasterDA: GetvViewMaster)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewMasterId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewMasterEN GetObjByViewMasterId(string strViewMasterId)
{
CheckPrimaryKey(strViewMasterId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from vViewMaster where ViewMasterId = " + "'"+ strViewMasterId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewMasterEN objvViewMasterEN = new clsvViewMasterEN();
try
{
 objvViewMasterEN.ViewMasterId = objRow[convViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewMasterEN.ViewMasterName = objRow[convViewMaster.ViewMasterName] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterName].ToString().Trim(); //界面母版名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewMasterEN.ViewMasterPath = objRow[convViewMaster.ViewMasterPath] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[convViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewMasterEN.ApplicationTypeName = objRow[convViewMaster.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewMasterEN.ApplicationTypeSimName = objRow[convViewMaster.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewMaster.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewMasterEN.PrjId = objRow[convViewMaster.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewMasterEN.UpdDate = objRow[convViewMaster.UpdDate] == DBNull.Value ? null : objRow[convViewMaster.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewMasterEN.UpdUser = objRow[convViewMaster.UpdUser] == DBNull.Value ? null : objRow[convViewMaster.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewMasterEN.Memo = objRow[convViewMaster.Memo] == DBNull.Value ? null : objRow[convViewMaster.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewMasterDA: GetObjByViewMasterId)", objException.Message));
}
return objvViewMasterEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewMasterEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewMasterDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
strSQL = "Select * from vViewMaster where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewMasterEN objvViewMasterEN = new clsvViewMasterEN()
{
ViewMasterId = objRow[convViewMaster.ViewMasterId].ToString().Trim(), //界面母版Id
ViewMasterName = objRow[convViewMaster.ViewMasterName] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterName].ToString().Trim(), //界面母版名
ViewMasterPath = objRow[convViewMaster.ViewMasterPath] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterPath].ToString().Trim(), //界面母版路径
ApplicationTypeId = TransNullToInt(objRow[convViewMaster.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convViewMaster.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeSimName = objRow[convViewMaster.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewMaster.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
PrjId = objRow[convViewMaster.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convViewMaster.UpdDate] == DBNull.Value ? null : objRow[convViewMaster.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convViewMaster.UpdUser] == DBNull.Value ? null : objRow[convViewMaster.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convViewMaster.Memo] == DBNull.Value ? null : objRow[convViewMaster.Memo].ToString().Trim() //说明
};
objvViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewMasterEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewMasterDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewMasterEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewMasterEN objvViewMasterEN = new clsvViewMasterEN();
try
{
objvViewMasterEN.ViewMasterId = objRow[convViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewMasterEN.ViewMasterName = objRow[convViewMaster.ViewMasterName] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objvViewMasterEN.ViewMasterPath = objRow[convViewMaster.ViewMasterPath] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objvViewMasterEN.ApplicationTypeId = TransNullToInt(objRow[convViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewMasterEN.ApplicationTypeName = objRow[convViewMaster.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewMasterEN.ApplicationTypeSimName = objRow[convViewMaster.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewMaster.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewMasterEN.PrjId = objRow[convViewMaster.PrjId].ToString().Trim(); //工程Id
objvViewMasterEN.UpdDate = objRow[convViewMaster.UpdDate] == DBNull.Value ? null : objRow[convViewMaster.UpdDate].ToString().Trim(); //修改日期
objvViewMasterEN.UpdUser = objRow[convViewMaster.UpdUser] == DBNull.Value ? null : objRow[convViewMaster.UpdUser].ToString().Trim(); //修改者
objvViewMasterEN.Memo = objRow[convViewMaster.Memo] == DBNull.Value ? null : objRow[convViewMaster.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewMasterDA: GetObjByDataRowvViewMaster)", objException.Message));
}
objvViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewMasterEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewMasterEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewMasterEN objvViewMasterEN = new clsvViewMasterEN();
try
{
objvViewMasterEN.ViewMasterId = objRow[convViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewMasterEN.ViewMasterName = objRow[convViewMaster.ViewMasterName] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objvViewMasterEN.ViewMasterPath = objRow[convViewMaster.ViewMasterPath] == DBNull.Value ? null : objRow[convViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objvViewMasterEN.ApplicationTypeId = TransNullToInt(objRow[convViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewMasterEN.ApplicationTypeName = objRow[convViewMaster.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvViewMasterEN.ApplicationTypeSimName = objRow[convViewMaster.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewMaster.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewMasterEN.PrjId = objRow[convViewMaster.PrjId].ToString().Trim(); //工程Id
objvViewMasterEN.UpdDate = objRow[convViewMaster.UpdDate] == DBNull.Value ? null : objRow[convViewMaster.UpdDate].ToString().Trim(); //修改日期
objvViewMasterEN.UpdUser = objRow[convViewMaster.UpdUser] == DBNull.Value ? null : objRow[convViewMaster.UpdUser].ToString().Trim(); //修改者
objvViewMasterEN.Memo = objRow[convViewMaster.Memo] == DBNull.Value ? null : objRow[convViewMaster.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewMasterDA: GetObjByDataRow)", objException.Message));
}
objvViewMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewMasterEN;
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
objSQL = clsvViewMasterDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewMasterEN._CurrTabName, convViewMaster.ViewMasterId, 8, "");
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
objSQL = clsvViewMasterDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewMasterEN._CurrTabName, convViewMaster.ViewMasterId, 8, strPrefix);
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
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewMasterId from vViewMaster where " + strCondition;
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
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewMasterId from vViewMaster where " + strCondition;
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
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewMaster", "ViewMasterId = " + "'"+ strViewMasterId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewMasterDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewMaster", strCondition))
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
objSQL = clsvViewMasterDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewMaster");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewMasterENS">源对象</param>
 /// <param name = "objvViewMasterENT">目标对象</param>
public void CopyTo(clsvViewMasterEN objvViewMasterENS, clsvViewMasterEN objvViewMasterENT)
{
objvViewMasterENT.ViewMasterId = objvViewMasterENS.ViewMasterId; //界面母版Id
objvViewMasterENT.ViewMasterName = objvViewMasterENS.ViewMasterName; //界面母版名
objvViewMasterENT.ViewMasterPath = objvViewMasterENS.ViewMasterPath; //界面母版路径
objvViewMasterENT.ApplicationTypeId = objvViewMasterENS.ApplicationTypeId; //应用程序类型ID
objvViewMasterENT.ApplicationTypeName = objvViewMasterENS.ApplicationTypeName; //应用程序类型名称
objvViewMasterENT.ApplicationTypeSimName = objvViewMasterENS.ApplicationTypeSimName; //应用程序类型简称
objvViewMasterENT.PrjId = objvViewMasterENS.PrjId; //工程Id
objvViewMasterENT.UpdDate = objvViewMasterENS.UpdDate; //修改日期
objvViewMasterENT.UpdUser = objvViewMasterENS.UpdUser; //修改者
objvViewMasterENT.Memo = objvViewMasterENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewMasterEN objvViewMasterEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewMasterEN.ViewMasterId, 8, convViewMaster.ViewMasterId);
clsCheckSql.CheckFieldLen(objvViewMasterEN.ViewMasterName, 50, convViewMaster.ViewMasterName);
clsCheckSql.CheckFieldLen(objvViewMasterEN.ViewMasterPath, 100, convViewMaster.ViewMasterPath);
clsCheckSql.CheckFieldLen(objvViewMasterEN.ApplicationTypeName, 30, convViewMaster.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvViewMasterEN.ApplicationTypeSimName, 30, convViewMaster.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvViewMasterEN.PrjId, 4, convViewMaster.PrjId);
clsCheckSql.CheckFieldLen(objvViewMasterEN.UpdDate, 20, convViewMaster.UpdDate);
clsCheckSql.CheckFieldLen(objvViewMasterEN.UpdUser, 20, convViewMaster.UpdUser);
clsCheckSql.CheckFieldLen(objvViewMasterEN.Memo, 1000, convViewMaster.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewMasterEN.ViewMasterId, convViewMaster.ViewMasterId);
clsCheckSql.CheckSqlInjection4Field(objvViewMasterEN.ViewMasterName, convViewMaster.ViewMasterName);
clsCheckSql.CheckSqlInjection4Field(objvViewMasterEN.ViewMasterPath, convViewMaster.ViewMasterPath);
clsCheckSql.CheckSqlInjection4Field(objvViewMasterEN.ApplicationTypeName, convViewMaster.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewMasterEN.ApplicationTypeSimName, convViewMaster.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvViewMasterEN.PrjId, convViewMaster.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvViewMasterEN.UpdDate, convViewMaster.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewMasterEN.UpdUser, convViewMaster.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvViewMasterEN.Memo, convViewMaster.Memo);
//检查外键字段长度
 objvViewMasterEN._IsCheckProperty = true;
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
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
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
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
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
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewMasterEN._CurrTabName);
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
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewMasterEN._CurrTabName, strCondition);
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
 objSQL = clsvViewMasterDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}