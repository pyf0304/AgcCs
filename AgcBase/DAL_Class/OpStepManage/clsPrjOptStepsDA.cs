
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjOptStepsDA
 表名:PrjOptSteps(00050074)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:操作步骤管理(OpStepManage)
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
 /// PrjOptSteps(PrjOptSteps)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjOptStepsDA : clsCommBase4DA
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
 return clsPrjOptStepsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjOptStepsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjOptStepsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjOptStepsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjOptStepsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strStepId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strStepId)
{
strStepId = strStepId.Replace("'", "''");
if (strStepId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:PrjOptSteps中,检查关键字,长度不正确!(clsPrjOptStepsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strStepId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PrjOptSteps中,关键字不能为空 或 null!(clsPrjOptStepsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStepId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPrjOptStepsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjOptSteps(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetDataTable_PrjOptSteps)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjOptSteps where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjOptSteps where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjOptSteps where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjOptSteps.* " + 
$"from PrjOptSteps " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjOptSteps.StepId not in " + 
$"(Select top {intTop_In} PrjOptSteps.StepId from PrjOptSteps " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjOptSteps where {1} and StepId not in (Select top {2} StepId from PrjOptSteps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjOptSteps where {1} and StepId not in (Select top {3} StepId from PrjOptSteps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjOptSteps.* " + 
$"from PrjOptSteps " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjOptSteps.StepId not in " + 
$"(Select top {intTop_In} PrjOptSteps.StepId from PrjOptSteps " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjOptSteps where {1} and StepId not in (Select top {2} StepId from PrjOptSteps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjOptSteps where {1} and StepId not in (Select top {3} StepId from PrjOptSteps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjOptStepsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjOptStepsDA:GetObjLst)", objException.Message));
}
List<clsPrjOptStepsEN> arrObjLst = new List<clsPrjOptStepsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjOptStepsEN objPrjOptStepsEN = new clsPrjOptStepsEN();
try
{
objPrjOptStepsEN.StepId = objRow[conPrjOptSteps.StepId].ToString().Trim(); //StepId
objPrjOptStepsEN.PrjId = objRow[conPrjOptSteps.PrjId].ToString().Trim(); //工程Id
objPrjOptStepsEN.StepName = objRow[conPrjOptSteps.StepName].ToString().Trim(); //StepName
objPrjOptStepsEN.StepTypeId = objRow[conPrjOptSteps.StepTypeId].ToString().Trim(); //StepTypeId
objPrjOptStepsEN.StepDetail = objRow[conPrjOptSteps.StepDetail] == DBNull.Value ? null : objRow[conPrjOptSteps.StepDetail].ToString().Trim(); //StepDetail
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjOptStepsDA: GetObjLst)", objException.Message));
}
objPrjOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjOptStepsEN);
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
public List<clsPrjOptStepsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjOptStepsDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjOptStepsEN> arrObjLst = new List<clsPrjOptStepsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjOptStepsEN objPrjOptStepsEN = new clsPrjOptStepsEN();
try
{
objPrjOptStepsEN.StepId = objRow[conPrjOptSteps.StepId].ToString().Trim(); //StepId
objPrjOptStepsEN.PrjId = objRow[conPrjOptSteps.PrjId].ToString().Trim(); //工程Id
objPrjOptStepsEN.StepName = objRow[conPrjOptSteps.StepName].ToString().Trim(); //StepName
objPrjOptStepsEN.StepTypeId = objRow[conPrjOptSteps.StepTypeId].ToString().Trim(); //StepTypeId
objPrjOptStepsEN.StepDetail = objRow[conPrjOptSteps.StepDetail] == DBNull.Value ? null : objRow[conPrjOptSteps.StepDetail].ToString().Trim(); //StepDetail
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjOptStepsDA: GetObjLst)", objException.Message));
}
objPrjOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjOptStepsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjOptStepsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjOptSteps(ref clsPrjOptStepsEN objPrjOptStepsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where StepId = " + "'"+ objPrjOptStepsEN.StepId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjOptStepsEN.StepId = objDT.Rows[0][conPrjOptSteps.StepId].ToString().Trim(); //StepId(字段类型:varchar,字段长度:8,是否可空:False)
 objPrjOptStepsEN.PrjId = objDT.Rows[0][conPrjOptSteps.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjOptStepsEN.StepName = objDT.Rows[0][conPrjOptSteps.StepName].ToString().Trim(); //StepName(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjOptStepsEN.StepTypeId = objDT.Rows[0][conPrjOptSteps.StepTypeId].ToString().Trim(); //StepTypeId(字段类型:varchar,字段长度:2,是否可空:False)
 objPrjOptStepsEN.StepDetail = objDT.Rows[0][conPrjOptSteps.StepDetail].ToString().Trim(); //StepDetail(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjOptStepsDA: GetPrjOptSteps)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strStepId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjOptStepsEN GetObjByStepId(string strStepId)
{
CheckPrimaryKey(strStepId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where StepId = " + "'"+ strStepId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjOptStepsEN objPrjOptStepsEN = new clsPrjOptStepsEN();
try
{
 objPrjOptStepsEN.StepId = objRow[conPrjOptSteps.StepId].ToString().Trim(); //StepId(字段类型:varchar,字段长度:8,是否可空:False)
 objPrjOptStepsEN.PrjId = objRow[conPrjOptSteps.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjOptStepsEN.StepName = objRow[conPrjOptSteps.StepName].ToString().Trim(); //StepName(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjOptStepsEN.StepTypeId = objRow[conPrjOptSteps.StepTypeId].ToString().Trim(); //StepTypeId(字段类型:varchar,字段长度:2,是否可空:False)
 objPrjOptStepsEN.StepDetail = objRow[conPrjOptSteps.StepDetail] == DBNull.Value ? null : objRow[conPrjOptSteps.StepDetail].ToString().Trim(); //StepDetail(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjOptStepsDA: GetObjByStepId)", objException.Message));
}
return objPrjOptStepsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjOptStepsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjOptStepsEN objPrjOptStepsEN = new clsPrjOptStepsEN()
{
StepId = objRow[conPrjOptSteps.StepId].ToString().Trim(), //StepId
PrjId = objRow[conPrjOptSteps.PrjId].ToString().Trim(), //工程Id
StepName = objRow[conPrjOptSteps.StepName].ToString().Trim(), //StepName
StepTypeId = objRow[conPrjOptSteps.StepTypeId].ToString().Trim(), //StepTypeId
StepDetail = objRow[conPrjOptSteps.StepDetail] == DBNull.Value ? null : objRow[conPrjOptSteps.StepDetail].ToString().Trim() //StepDetail
};
objPrjOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjOptStepsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjOptStepsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjOptStepsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjOptStepsEN objPrjOptStepsEN = new clsPrjOptStepsEN();
try
{
objPrjOptStepsEN.StepId = objRow[conPrjOptSteps.StepId].ToString().Trim(); //StepId
objPrjOptStepsEN.PrjId = objRow[conPrjOptSteps.PrjId].ToString().Trim(); //工程Id
objPrjOptStepsEN.StepName = objRow[conPrjOptSteps.StepName].ToString().Trim(); //StepName
objPrjOptStepsEN.StepTypeId = objRow[conPrjOptSteps.StepTypeId].ToString().Trim(); //StepTypeId
objPrjOptStepsEN.StepDetail = objRow[conPrjOptSteps.StepDetail] == DBNull.Value ? null : objRow[conPrjOptSteps.StepDetail].ToString().Trim(); //StepDetail
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjOptStepsDA: GetObjByDataRowPrjOptSteps)", objException.Message));
}
objPrjOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjOptStepsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjOptStepsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjOptStepsEN objPrjOptStepsEN = new clsPrjOptStepsEN();
try
{
objPrjOptStepsEN.StepId = objRow[conPrjOptSteps.StepId].ToString().Trim(); //StepId
objPrjOptStepsEN.PrjId = objRow[conPrjOptSteps.PrjId].ToString().Trim(); //工程Id
objPrjOptStepsEN.StepName = objRow[conPrjOptSteps.StepName].ToString().Trim(); //StepName
objPrjOptStepsEN.StepTypeId = objRow[conPrjOptSteps.StepTypeId].ToString().Trim(); //StepTypeId
objPrjOptStepsEN.StepDetail = objRow[conPrjOptSteps.StepDetail] == DBNull.Value ? null : objRow[conPrjOptSteps.StepDetail].ToString().Trim(); //StepDetail
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjOptStepsDA: GetObjByDataRow)", objException.Message));
}
objPrjOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjOptStepsEN;
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
objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjOptStepsEN._CurrTabName, conPrjOptSteps.StepId, 8, "");
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
objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjOptStepsEN._CurrTabName, conPrjOptSteps.StepId, 8, strPrefix);
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
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select StepId from PrjOptSteps where " + strCondition;
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
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select StepId from PrjOptSteps where " + strCondition;
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
 /// <param name = "strStepId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strStepId)
{
CheckPrimaryKey(strStepId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjOptSteps", "StepId = " + "'"+ strStepId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjOptStepsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjOptSteps", strCondition))
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
objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjOptSteps");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjOptStepsEN objPrjOptStepsEN)
 {
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjOptStepsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjOptSteps");
objRow = objDS.Tables["PrjOptSteps"].NewRow();
objRow[conPrjOptSteps.StepId] = objPrjOptStepsEN.StepId; //StepId
objRow[conPrjOptSteps.PrjId] = objPrjOptStepsEN.PrjId; //工程Id
objRow[conPrjOptSteps.StepName] = objPrjOptStepsEN.StepName; //StepName
objRow[conPrjOptSteps.StepTypeId] = objPrjOptStepsEN.StepTypeId; //StepTypeId
 if (objPrjOptStepsEN.StepDetail !=  "")
 {
objRow[conPrjOptSteps.StepDetail] = objPrjOptStepsEN.StepDetail; //StepDetail
 }
objDS.Tables[clsPrjOptStepsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjOptStepsEN._CurrTabName);
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
 /// <param name = "objPrjOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjOptStepsEN objPrjOptStepsEN)
{
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjOptStepsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjOptStepsEN.StepId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepId);
 var strStepId = objPrjOptStepsEN.StepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepId + "'");
 }
 
 if (objPrjOptStepsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.PrjId);
 var strPrjId = objPrjOptStepsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjOptStepsEN.StepName !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepName);
 var strStepName = objPrjOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepName + "'");
 }
 
 if (objPrjOptStepsEN.StepTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepTypeId);
 var strStepTypeId = objPrjOptStepsEN.StepTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepTypeId + "'");
 }
 
 if (objPrjOptStepsEN.StepDetail !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepDetail);
 var strStepDetail = objPrjOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepDetail + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjOptStepsEN objPrjOptStepsEN)
{
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjOptStepsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjOptStepsEN.StepId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepId);
 var strStepId = objPrjOptStepsEN.StepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepId + "'");
 }
 
 if (objPrjOptStepsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.PrjId);
 var strPrjId = objPrjOptStepsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjOptStepsEN.StepName !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepName);
 var strStepName = objPrjOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepName + "'");
 }
 
 if (objPrjOptStepsEN.StepTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepTypeId);
 var strStepTypeId = objPrjOptStepsEN.StepTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepTypeId + "'");
 }
 
 if (objPrjOptStepsEN.StepDetail !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepDetail);
 var strStepDetail = objPrjOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepDetail + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPrjOptStepsEN.StepId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPrjOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjOptStepsEN objPrjOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjOptStepsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjOptStepsEN.StepId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepId);
 var strStepId = objPrjOptStepsEN.StepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepId + "'");
 }
 
 if (objPrjOptStepsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.PrjId);
 var strPrjId = objPrjOptStepsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjOptStepsEN.StepName !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepName);
 var strStepName = objPrjOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepName + "'");
 }
 
 if (objPrjOptStepsEN.StepTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepTypeId);
 var strStepTypeId = objPrjOptStepsEN.StepTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepTypeId + "'");
 }
 
 if (objPrjOptStepsEN.StepDetail !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepDetail);
 var strStepDetail = objPrjOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepDetail + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPrjOptStepsEN.StepId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjOptStepsEN objPrjOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjOptStepsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjOptStepsEN.StepId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepId);
 var strStepId = objPrjOptStepsEN.StepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepId + "'");
 }
 
 if (objPrjOptStepsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.PrjId);
 var strPrjId = objPrjOptStepsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjOptStepsEN.StepName !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepName);
 var strStepName = objPrjOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepName + "'");
 }
 
 if (objPrjOptStepsEN.StepTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepTypeId);
 var strStepTypeId = objPrjOptStepsEN.StepTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepTypeId + "'");
 }
 
 if (objPrjOptStepsEN.StepDetail !=  null)
 {
 arrFieldListForInsert.Add(conPrjOptSteps.StepDetail);
 var strStepDetail = objPrjOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStepDetail + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjOptStepss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where StepId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjOptSteps");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strStepId = oRow[conPrjOptSteps.StepId].ToString().Trim();
if (IsExist(strStepId))
{
 string strResult = "关键字变量值为:" + string.Format("StepId = {0}", strStepId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjOptStepsEN._CurrTabName ].NewRow();
objRow[conPrjOptSteps.StepId] = oRow[conPrjOptSteps.StepId].ToString().Trim(); //StepId
objRow[conPrjOptSteps.PrjId] = oRow[conPrjOptSteps.PrjId].ToString().Trim(); //工程Id
objRow[conPrjOptSteps.StepName] = oRow[conPrjOptSteps.StepName].ToString().Trim(); //StepName
objRow[conPrjOptSteps.StepTypeId] = oRow[conPrjOptSteps.StepTypeId].ToString().Trim(); //StepTypeId
objRow[conPrjOptSteps.StepDetail] = oRow[conPrjOptSteps.StepDetail].ToString().Trim(); //StepDetail
 objDS.Tables[clsPrjOptStepsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjOptStepsEN._CurrTabName);
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
 /// <param name = "objPrjOptStepsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjOptStepsEN objPrjOptStepsEN)
{
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjOptStepsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from PrjOptSteps where StepId = " + "'"+ objPrjOptStepsEN.StepId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjOptStepsEN._CurrTabName);
if (objDS.Tables[clsPrjOptStepsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:StepId = " + "'"+ objPrjOptStepsEN.StepId+"'");
return false;
}
objRow = objDS.Tables[clsPrjOptStepsEN._CurrTabName].Rows[0];
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepId))
 {
objRow[conPrjOptSteps.StepId] = objPrjOptStepsEN.StepId; //StepId
 }
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.PrjId))
 {
objRow[conPrjOptSteps.PrjId] = objPrjOptStepsEN.PrjId; //工程Id
 }
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepName))
 {
objRow[conPrjOptSteps.StepName] = objPrjOptStepsEN.StepName; //StepName
 }
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepTypeId))
 {
objRow[conPrjOptSteps.StepTypeId] = objPrjOptStepsEN.StepTypeId; //StepTypeId
 }
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepDetail))
 {
objRow[conPrjOptSteps.StepDetail] = objPrjOptStepsEN.StepDetail; //StepDetail
 }
try
{
objDA.Update(objDS, clsPrjOptStepsEN._CurrTabName);
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
 /// <param name = "objPrjOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjOptStepsEN objPrjOptStepsEN)
{
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjOptSteps Set ");
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.PrjId))
 {
 if (objPrjOptStepsEN.PrjId !=  null)
 {
 var strPrjId = objPrjOptStepsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjOptSteps.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjOptSteps.PrjId); //工程Id
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepName))
 {
 if (objPrjOptStepsEN.StepName !=  null)
 {
 var strStepName = objPrjOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStepName, conPrjOptSteps.StepName); //StepName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjOptSteps.StepName); //StepName
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepTypeId))
 {
 if (objPrjOptStepsEN.StepTypeId !=  null)
 {
 var strStepTypeId = objPrjOptStepsEN.StepTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStepTypeId, conPrjOptSteps.StepTypeId); //StepTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjOptSteps.StepTypeId); //StepTypeId
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepDetail))
 {
 if (objPrjOptStepsEN.StepDetail !=  null)
 {
 var strStepDetail = objPrjOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStepDetail, conPrjOptSteps.StepDetail); //StepDetail
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjOptSteps.StepDetail); //StepDetail
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StepId = '{0}'", objPrjOptStepsEN.StepId); 
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
 /// <param name = "objPrjOptStepsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjOptStepsEN objPrjOptStepsEN, string strCondition)
{
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjOptSteps Set ");
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.PrjId))
 {
 if (objPrjOptStepsEN.PrjId !=  null)
 {
 var strPrjId = objPrjOptStepsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepName))
 {
 if (objPrjOptStepsEN.StepName !=  null)
 {
 var strStepName = objPrjOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepName = '{0}',", strStepName); //StepName
 }
 else
 {
 sbSQL.Append(" StepName = null,"); //StepName
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepTypeId))
 {
 if (objPrjOptStepsEN.StepTypeId !=  null)
 {
 var strStepTypeId = objPrjOptStepsEN.StepTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepTypeId = '{0}',", strStepTypeId); //StepTypeId
 }
 else
 {
 sbSQL.Append(" StepTypeId = null,"); //StepTypeId
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepDetail))
 {
 if (objPrjOptStepsEN.StepDetail !=  null)
 {
 var strStepDetail = objPrjOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepDetail = '{0}',", strStepDetail); //StepDetail
 }
 else
 {
 sbSQL.Append(" StepDetail = null,"); //StepDetail
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
 /// <param name = "objPrjOptStepsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjOptStepsEN objPrjOptStepsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjOptSteps Set ");
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.PrjId))
 {
 if (objPrjOptStepsEN.PrjId !=  null)
 {
 var strPrjId = objPrjOptStepsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepName))
 {
 if (objPrjOptStepsEN.StepName !=  null)
 {
 var strStepName = objPrjOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepName = '{0}',", strStepName); //StepName
 }
 else
 {
 sbSQL.Append(" StepName = null,"); //StepName
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepTypeId))
 {
 if (objPrjOptStepsEN.StepTypeId !=  null)
 {
 var strStepTypeId = objPrjOptStepsEN.StepTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepTypeId = '{0}',", strStepTypeId); //StepTypeId
 }
 else
 {
 sbSQL.Append(" StepTypeId = null,"); //StepTypeId
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepDetail))
 {
 if (objPrjOptStepsEN.StepDetail !=  null)
 {
 var strStepDetail = objPrjOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepDetail = '{0}',", strStepDetail); //StepDetail
 }
 else
 {
 sbSQL.Append(" StepDetail = null,"); //StepDetail
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
 /// <param name = "objPrjOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjOptStepsEN objPrjOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPrjOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjOptSteps Set ");
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.PrjId))
 {
 if (objPrjOptStepsEN.PrjId !=  null)
 {
 var strPrjId = objPrjOptStepsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjOptSteps.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjOptSteps.PrjId); //工程Id
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepName))
 {
 if (objPrjOptStepsEN.StepName !=  null)
 {
 var strStepName = objPrjOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStepName, conPrjOptSteps.StepName); //StepName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjOptSteps.StepName); //StepName
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepTypeId))
 {
 if (objPrjOptStepsEN.StepTypeId !=  null)
 {
 var strStepTypeId = objPrjOptStepsEN.StepTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStepTypeId, conPrjOptSteps.StepTypeId); //StepTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjOptSteps.StepTypeId); //StepTypeId
 }
 }
 
 if (objPrjOptStepsEN.IsUpdated(conPrjOptSteps.StepDetail))
 {
 if (objPrjOptStepsEN.StepDetail !=  null)
 {
 var strStepDetail = objPrjOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStepDetail, conPrjOptSteps.StepDetail); //StepDetail
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjOptSteps.StepDetail); //StepDetail
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StepId = '{0}'", objPrjOptStepsEN.StepId); 
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
 /// <param name = "strStepId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strStepId) 
{
CheckPrimaryKey(strStepId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strStepId,
};
 objSQL.ExecSP("PrjOptSteps_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strStepId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strStepId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strStepId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
//删除PrjOptSteps本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjOptSteps where StepId = " + "'"+ strStepId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjOptSteps(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
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
//删除PrjOptSteps本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjOptSteps where StepId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strStepId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strStepId) 
{
CheckPrimaryKey(strStepId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
//删除PrjOptSteps本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjOptSteps where StepId = " + "'"+ strStepId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjOptSteps(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: DelPrjOptSteps)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjOptSteps where " + strCondition ;
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
public bool DelPrjOptStepsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjOptStepsDA: DelPrjOptStepsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjOptSteps where " + strCondition ;
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
 /// <param name = "objPrjOptStepsENS">源对象</param>
 /// <param name = "objPrjOptStepsENT">目标对象</param>
public void CopyTo(clsPrjOptStepsEN objPrjOptStepsENS, clsPrjOptStepsEN objPrjOptStepsENT)
{
objPrjOptStepsENT.StepId = objPrjOptStepsENS.StepId; //StepId
objPrjOptStepsENT.PrjId = objPrjOptStepsENS.PrjId; //工程Id
objPrjOptStepsENT.StepName = objPrjOptStepsENS.StepName; //StepName
objPrjOptStepsENT.StepTypeId = objPrjOptStepsENS.StepTypeId; //StepTypeId
objPrjOptStepsENT.StepDetail = objPrjOptStepsENS.StepDetail; //StepDetail
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjOptStepsEN objPrjOptStepsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjOptStepsEN.PrjId, conPrjOptSteps.PrjId);
clsCheckSql.CheckFieldNotNull(objPrjOptStepsEN.StepName, conPrjOptSteps.StepName);
clsCheckSql.CheckFieldNotNull(objPrjOptStepsEN.StepTypeId, conPrjOptSteps.StepTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepId, 8, conPrjOptSteps.StepId);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.PrjId, 4, conPrjOptSteps.PrjId);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepName, 50, conPrjOptSteps.StepName);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepTypeId, 2, conPrjOptSteps.StepTypeId);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepDetail, 1000, conPrjOptSteps.StepDetail);
//检查字段外键固定长度
 objPrjOptStepsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjOptStepsEN objPrjOptStepsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.PrjId, 4, conPrjOptSteps.PrjId);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepName, 50, conPrjOptSteps.StepName);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepTypeId, 2, conPrjOptSteps.StepTypeId);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepDetail, 1000, conPrjOptSteps.StepDetail);
//检查外键字段长度
 objPrjOptStepsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjOptStepsEN objPrjOptStepsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepId, 8, conPrjOptSteps.StepId);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.PrjId, 4, conPrjOptSteps.PrjId);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepName, 50, conPrjOptSteps.StepName);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepTypeId, 2, conPrjOptSteps.StepTypeId);
clsCheckSql.CheckFieldLen(objPrjOptStepsEN.StepDetail, 1000, conPrjOptSteps.StepDetail);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjOptStepsEN.StepId, conPrjOptSteps.StepId);
clsCheckSql.CheckSqlInjection4Field(objPrjOptStepsEN.PrjId, conPrjOptSteps.PrjId);
clsCheckSql.CheckSqlInjection4Field(objPrjOptStepsEN.StepName, conPrjOptSteps.StepName);
clsCheckSql.CheckSqlInjection4Field(objPrjOptStepsEN.StepTypeId, conPrjOptSteps.StepTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjOptStepsEN.StepDetail, conPrjOptSteps.StepDetail);
//检查外键字段长度
 objPrjOptStepsEN._IsCheckProperty = true;
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
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
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
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
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
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjOptStepsEN._CurrTabName);
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
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjOptStepsEN._CurrTabName, strCondition);
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
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
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
 objSQL = clsPrjOptStepsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}