
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataBaseModuleRelaDA
 表名:vDataBaseModuleRela(00050236)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// v数据库模块关系(vDataBaseModuleRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDataBaseModuleRelaDA : clsCommBase4DA
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
 return clsvDataBaseModuleRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDataBaseModuleRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDataBaseModuleRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDataBaseModuleRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDataBaseModuleRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
strSQL = "Select * from vDataBaseModuleRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDataBaseModuleRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetDataTable_vDataBaseModuleRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
strSQL = "Select * from vDataBaseModuleRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
strSQL = "Select * from vDataBaseModuleRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataBaseModuleRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataBaseModuleRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDataBaseModuleRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDataBaseModuleRela.* " + 
$"from vDataBaseModuleRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDataBaseModuleRela.mId not in " + 
$"(Select top {intTop_In} vDataBaseModuleRela.mId from vDataBaseModuleRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataBaseModuleRela where {1} and mId not in (Select top {2} mId from vDataBaseModuleRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataBaseModuleRela where {1} and mId not in (Select top {3} mId from vDataBaseModuleRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDataBaseModuleRela.* " + 
$"from vDataBaseModuleRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDataBaseModuleRela.mId not in " + 
$"(Select top {intTop_In} vDataBaseModuleRela.mId from vDataBaseModuleRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataBaseModuleRela where {1} and mId not in (Select top {2} mId from vDataBaseModuleRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataBaseModuleRela where {1} and mId not in (Select top {3} mId from vDataBaseModuleRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDataBaseModuleRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA:GetObjLst)", objException.Message));
}
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
strSQL = "Select * from vDataBaseModuleRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = TransNullToInt(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = TransNullToInt(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = TransNullToBool(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDataBaseModuleRelaDA: GetObjLst)", objException.Message));
}
objvDataBaseModuleRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDataBaseModuleRelaEN);
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
public List<clsvDataBaseModuleRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = TransNullToInt(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = TransNullToInt(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = TransNullToBool(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDataBaseModuleRelaDA: GetObjLst)", objException.Message));
}
objvDataBaseModuleRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDataBaseModuleRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDataBaseModuleRela(ref clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
strSQL = "Select * from vDataBaseModuleRela where mId = " + ""+ objvDataBaseModuleRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDataBaseModuleRelaEN.mId = TransNullToInt(objDT.Rows[0][convDataBaseModuleRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvDataBaseModuleRelaEN.PrjId = objDT.Rows[0][convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDataBaseModuleRelaEN.PrjName = objDT.Rows[0][convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvDataBaseModuleRelaEN.PrjDataBaseId = objDT.Rows[0][convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvDataBaseModuleRelaEN.PrjDataBaseName = objDT.Rows[0][convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataBaseModuleRelaEN.FuncModuleAgcId = objDT.Rows[0][convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvDataBaseModuleRelaEN.FuncModuleName = objDT.Rows[0][convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvDataBaseModuleRelaEN.FuncModuleEnName = objDT.Rows[0][convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvDataBaseModuleRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvDataBaseModuleRelaEN.IsVisible = TransNullToBool(objDT.Rows[0][convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvDataBaseModuleRelaEN.UpdUserId = objDT.Rows[0][convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataBaseModuleRelaEN.UpdDate = objDT.Rows[0][convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataBaseModuleRelaEN.Memo = objDT.Rows[0][convDataBaseModuleRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDataBaseModuleRelaDA: GetvDataBaseModuleRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDataBaseModuleRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
strSQL = "Select * from vDataBaseModuleRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
 objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDataBaseModuleRelaDA: GetObjBymId)", objException.Message));
}
return objvDataBaseModuleRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDataBaseModuleRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
strSQL = "Select * from vDataBaseModuleRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN()
{
mId = TransNullToInt(objRow[convDataBaseModuleRela.mId].ToString().Trim()), //mId
PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(), //工程名称
PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(), //项目数据库Id
PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(), //项目数据库名
FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
OrderNum = TransNullToInt(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()), //序号
IsVisible = TransNullToBool(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()), //是否显示
UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim() //说明
};
objvDataBaseModuleRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataBaseModuleRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDataBaseModuleRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDataBaseModuleRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = TransNullToInt(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = TransNullToInt(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = TransNullToBool(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDataBaseModuleRelaDA: GetObjByDataRowvDataBaseModuleRela)", objException.Message));
}
objvDataBaseModuleRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataBaseModuleRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDataBaseModuleRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = TransNullToInt(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = TransNullToInt(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = TransNullToBool(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDataBaseModuleRelaDA: GetObjByDataRow)", objException.Message));
}
objvDataBaseModuleRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataBaseModuleRelaEN;
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
objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDataBaseModuleRelaEN._CurrTabName, convDataBaseModuleRela.mId, 8, "");
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
objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDataBaseModuleRelaEN._CurrTabName, convDataBaseModuleRela.mId, 8, strPrefix);
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
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vDataBaseModuleRela where " + strCondition;
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
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vDataBaseModuleRela where " + strCondition;
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
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDataBaseModuleRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDataBaseModuleRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDataBaseModuleRela", strCondition))
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
objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDataBaseModuleRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaENS">源对象</param>
 /// <param name = "objvDataBaseModuleRelaENT">目标对象</param>
public void CopyTo(clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENS, clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENT)
{
objvDataBaseModuleRelaENT.mId = objvDataBaseModuleRelaENS.mId; //mId
objvDataBaseModuleRelaENT.PrjId = objvDataBaseModuleRelaENS.PrjId; //工程Id
objvDataBaseModuleRelaENT.PrjName = objvDataBaseModuleRelaENS.PrjName; //工程名称
objvDataBaseModuleRelaENT.PrjDataBaseId = objvDataBaseModuleRelaENS.PrjDataBaseId; //项目数据库Id
objvDataBaseModuleRelaENT.PrjDataBaseName = objvDataBaseModuleRelaENS.PrjDataBaseName; //项目数据库名
objvDataBaseModuleRelaENT.FuncModuleAgcId = objvDataBaseModuleRelaENS.FuncModuleAgcId; //功能模块Id
objvDataBaseModuleRelaENT.FuncModuleName = objvDataBaseModuleRelaENS.FuncModuleName; //功能模块名称
objvDataBaseModuleRelaENT.FuncModuleEnName = objvDataBaseModuleRelaENS.FuncModuleEnName; //功能模块英文名称
objvDataBaseModuleRelaENT.OrderNum = objvDataBaseModuleRelaENS.OrderNum; //序号
objvDataBaseModuleRelaENT.IsVisible = objvDataBaseModuleRelaENS.IsVisible; //是否显示
objvDataBaseModuleRelaENT.UpdUserId = objvDataBaseModuleRelaENS.UpdUserId; //修改用户Id
objvDataBaseModuleRelaENT.UpdDate = objvDataBaseModuleRelaENS.UpdDate; //修改日期
objvDataBaseModuleRelaENT.Memo = objvDataBaseModuleRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.PrjId, 4, convDataBaseModuleRela.PrjId);
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.PrjName, 30, convDataBaseModuleRela.PrjName);
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.PrjDataBaseId, 4, convDataBaseModuleRela.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.PrjDataBaseName, 50, convDataBaseModuleRela.PrjDataBaseName);
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.FuncModuleAgcId, 8, convDataBaseModuleRela.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.FuncModuleName, 30, convDataBaseModuleRela.FuncModuleName);
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.FuncModuleEnName, 30, convDataBaseModuleRela.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.UpdUserId, 20, convDataBaseModuleRela.UpdUserId);
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.UpdDate, 20, convDataBaseModuleRela.UpdDate);
clsCheckSql.CheckFieldLen(objvDataBaseModuleRelaEN.Memo, 1000, convDataBaseModuleRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.PrjId, convDataBaseModuleRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.PrjName, convDataBaseModuleRela.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.PrjDataBaseId, convDataBaseModuleRela.PrjDataBaseId);
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.PrjDataBaseName, convDataBaseModuleRela.PrjDataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.FuncModuleAgcId, convDataBaseModuleRela.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.FuncModuleName, convDataBaseModuleRela.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.FuncModuleEnName, convDataBaseModuleRela.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.UpdUserId, convDataBaseModuleRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.UpdDate, convDataBaseModuleRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDataBaseModuleRelaEN.Memo, convDataBaseModuleRela.Memo);
//检查外键字段长度
 objvDataBaseModuleRelaEN._IsCheckProperty = true;
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
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
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
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
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
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDataBaseModuleRelaEN._CurrTabName);
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
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDataBaseModuleRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvDataBaseModuleRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}