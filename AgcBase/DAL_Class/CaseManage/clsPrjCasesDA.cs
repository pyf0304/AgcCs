
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjCasesDA
 表名:PrjCases(00050071)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:30:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用例管理(CaseManage)
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
 /// 工程用例(PrjCases)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjCasesDA : clsCommBase4DA
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
 return clsPrjCasesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjCasesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjCasesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjCasesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjCasesEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCaseId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCaseId)
{
strCaseId = strCaseId.Replace("'", "''");
if (strCaseId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:PrjCases中,检查关键字,长度不正确!(clsPrjCasesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCaseId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PrjCases中,关键字不能为空 或 null!(clsPrjCasesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPrjCasesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjCasesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjCases(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjCasesDA: GetDataTable_PrjCases)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjCasesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjCasesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjCasesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjCasesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjCases where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjCases where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjCasesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjCases where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjCasesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjCases.* " + 
$"from PrjCases " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjCases.CaseId not in " + 
$"(Select top {intTop_In} PrjCases.CaseId from PrjCases " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjCases where {1} and CaseId not in (Select top {2} CaseId from PrjCases where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjCases where {1} and CaseId not in (Select top {3} CaseId from PrjCases where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjCasesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjCases.* " + 
$"from PrjCases " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjCases.CaseId not in " + 
$"(Select top {intTop_In} PrjCases.CaseId from PrjCases " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjCases where {1} and CaseId not in (Select top {2} CaseId from PrjCases where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjCases where {1} and CaseId not in (Select top {3} CaseId from PrjCases where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjCasesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjCasesDA:GetObjLst)", objException.Message));
}
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjCasesDA: GetObjLst)", objException.Message));
}
objPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjCasesEN);
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
public List<clsPrjCasesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjCasesDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjCasesDA: GetObjLst)", objException.Message));
}
objPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjCasesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjCases(ref clsPrjCasesEN objPrjCasesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where CaseId = " + "'"+ objPrjCasesEN.CaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjCasesEN.CaseId = objDT.Rows[0][conPrjCases.CaseId].ToString().Trim(); //CaseId(字段类型:varchar,字段长度:8,是否可空:False)
 objPrjCasesEN.CaseName = objDT.Rows[0][conPrjCases.CaseName].ToString().Trim(); //CaseName(字段类型:varchar,字段长度:20,是否可空:False)
 objPrjCasesEN.PrjId = objDT.Rows[0][conPrjCases.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjCasesEN.CaseContent = objDT.Rows[0][conPrjCases.CaseContent].ToString().Trim(); //CaseContent(字段类型:varchar,字段长度:1000,是否可空:False)
 objPrjCasesEN.CaseTypeId = objDT.Rows[0][conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId(字段类型:varchar,字段长度:4,是否可空:False)
 objPrjCasesEN.ImportLevelId = objDT.Rows[0][conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id(字段类型:varchar,字段长度:4,是否可空:False)
 objPrjCasesEN.UserId = objDT.Rows[0][conPrjCases.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjCasesEN.UpdDate = objDT.Rows[0][conPrjCases.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjCasesEN.Memo = objDT.Rows[0][conPrjCases.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjCasesDA: GetPrjCases)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCaseId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjCasesEN GetObjByCaseId(string strCaseId)
{
CheckPrimaryKey(strCaseId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where CaseId = " + "'"+ strCaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
 objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId(字段类型:varchar,字段长度:8,是否可空:False)
 objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName(字段类型:varchar,字段长度:20,是否可空:False)
 objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent(字段类型:varchar,字段长度:1000,是否可空:False)
 objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId(字段类型:varchar,字段长度:4,是否可空:False)
 objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id(字段类型:varchar,字段长度:4,是否可空:False)
 objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjCasesDA: GetObjByCaseId)", objException.Message));
}
return objPrjCasesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjCasesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjCasesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN()
{
CaseId = objRow[conPrjCases.CaseId].ToString().Trim(), //CaseId
CaseName = objRow[conPrjCases.CaseName].ToString().Trim(), //CaseName
PrjId = objRow[conPrjCases.PrjId].ToString().Trim(), //工程Id
CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(), //CaseContent
CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(), //CaseTypeId
ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(), //重要程度Id
UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(), //用户Id
UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim() //说明
};
objPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjCasesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjCasesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjCasesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjCasesDA: GetObjByDataRowPrjCases)", objException.Message));
}
objPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjCasesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjCasesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjCasesDA: GetObjByDataRow)", objException.Message));
}
objPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjCasesEN;
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
objSQL = clsPrjCasesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjCasesEN._CurrTabName, conPrjCases.CaseId, 8, "");
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
objSQL = clsPrjCasesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjCasesEN._CurrTabName, conPrjCases.CaseId, 8, strPrefix);
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
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CaseId from PrjCases where " + strCondition;
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
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CaseId from PrjCases where " + strCondition;
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
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCaseId)
{
CheckPrimaryKey(strCaseId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjCases", "CaseId = " + "'"+ strCaseId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjCasesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjCases", strCondition))
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
objSQL = clsPrjCasesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjCases");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjCasesEN objPrjCasesEN)
 {
 objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjCasesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjCasesEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjCases");
objRow = objDS.Tables["PrjCases"].NewRow();
objRow[conPrjCases.CaseId] = objPrjCasesEN.CaseId; //CaseId
objRow[conPrjCases.CaseName] = objPrjCasesEN.CaseName; //CaseName
objRow[conPrjCases.PrjId] = objPrjCasesEN.PrjId; //工程Id
objRow[conPrjCases.CaseContent] = objPrjCasesEN.CaseContent; //CaseContent
objRow[conPrjCases.CaseTypeId] = objPrjCasesEN.CaseTypeId; //CaseTypeId
 if (objPrjCasesEN.ImportLevelId !=  "")
 {
objRow[conPrjCases.ImportLevelId] = objPrjCasesEN.ImportLevelId; //重要程度Id
 }
 if (objPrjCasesEN.UserId !=  "")
 {
objRow[conPrjCases.UserId] = objPrjCasesEN.UserId; //用户Id
 }
 if (objPrjCasesEN.UpdDate !=  "")
 {
objRow[conPrjCases.UpdDate] = objPrjCasesEN.UpdDate; //修改日期
 }
 if (objPrjCasesEN.Memo !=  "")
 {
objRow[conPrjCases.Memo] = objPrjCasesEN.Memo; //说明
 }
objDS.Tables[clsPrjCasesEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjCasesEN._CurrTabName);
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjCasesEN objPrjCasesEN)
{
 objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjCasesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjCasesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjCasesEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseId);
 var strCaseId = objPrjCasesEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objPrjCasesEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseName);
 var strCaseName = objPrjCasesEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objPrjCasesEN.PrjId  ==  "")
 {
 objPrjCasesEN.PrjId = null;
 }
 if (objPrjCasesEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.PrjId);
 var strPrjId = objPrjCasesEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjCasesEN.CaseContent !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseContent);
 var strCaseContent = objPrjCasesEN.CaseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseContent + "'");
 }
 
 if (objPrjCasesEN.CaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseTypeId);
 var strCaseTypeId = objPrjCasesEN.CaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTypeId + "'");
 }
 
 if (objPrjCasesEN.ImportLevelId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.ImportLevelId);
 var strImportLevelId = objPrjCasesEN.ImportLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportLevelId + "'");
 }
 
 if (objPrjCasesEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.UserId);
 var strUserId = objPrjCasesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjCasesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.UpdDate);
 var strUpdDate = objPrjCasesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjCasesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.Memo);
 var strMemo = objPrjCasesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjCases");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjCasesEN objPrjCasesEN)
{
 objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjCasesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjCasesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjCasesEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseId);
 var strCaseId = objPrjCasesEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objPrjCasesEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseName);
 var strCaseName = objPrjCasesEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objPrjCasesEN.PrjId  ==  "")
 {
 objPrjCasesEN.PrjId = null;
 }
 if (objPrjCasesEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.PrjId);
 var strPrjId = objPrjCasesEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjCasesEN.CaseContent !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseContent);
 var strCaseContent = objPrjCasesEN.CaseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseContent + "'");
 }
 
 if (objPrjCasesEN.CaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseTypeId);
 var strCaseTypeId = objPrjCasesEN.CaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTypeId + "'");
 }
 
 if (objPrjCasesEN.ImportLevelId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.ImportLevelId);
 var strImportLevelId = objPrjCasesEN.ImportLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportLevelId + "'");
 }
 
 if (objPrjCasesEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.UserId);
 var strUserId = objPrjCasesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjCasesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.UpdDate);
 var strUpdDate = objPrjCasesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjCasesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.Memo);
 var strMemo = objPrjCasesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjCases");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPrjCasesEN.CaseId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjCasesEN objPrjCasesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjCasesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjCasesEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjCasesEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseId);
 var strCaseId = objPrjCasesEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objPrjCasesEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseName);
 var strCaseName = objPrjCasesEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objPrjCasesEN.PrjId  ==  "")
 {
 objPrjCasesEN.PrjId = null;
 }
 if (objPrjCasesEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.PrjId);
 var strPrjId = objPrjCasesEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjCasesEN.CaseContent !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseContent);
 var strCaseContent = objPrjCasesEN.CaseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseContent + "'");
 }
 
 if (objPrjCasesEN.CaseTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.CaseTypeId);
 var strCaseTypeId = objPrjCasesEN.CaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTypeId + "'");
 }
 
 if (objPrjCasesEN.ImportLevelId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.ImportLevelId);
 var strImportLevelId = objPrjCasesEN.ImportLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImportLevelId + "'");
 }
 
 if (objPrjCasesEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.UserId);
 var strUserId = objPrjCasesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjCasesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.UpdDate);
 var strUpdDate = objPrjCasesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjCasesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjCases.Memo);
 var strMemo = objPrjCasesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjCases");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjCasess(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where CaseId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjCases");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCaseId = oRow[conPrjCases.CaseId].ToString().Trim();
if (IsExist(strCaseId))
{
 string strResult = "关键字变量值为:" + string.Format("CaseId = {0}", strCaseId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjCasesEN._CurrTabName ].NewRow();
objRow[conPrjCases.CaseId] = oRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objRow[conPrjCases.CaseName] = oRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objRow[conPrjCases.PrjId] = oRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objRow[conPrjCases.CaseContent] = oRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objRow[conPrjCases.CaseTypeId] = oRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objRow[conPrjCases.ImportLevelId] = oRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objRow[conPrjCases.UserId] = oRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objRow[conPrjCases.UpdDate] = oRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objRow[conPrjCases.Memo] = oRow[conPrjCases.Memo].ToString().Trim(); //说明
 objDS.Tables[clsPrjCasesEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjCasesEN._CurrTabName);
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
 /// <param name = "objPrjCasesEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjCasesEN objPrjCasesEN)
{
 objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjCasesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjCasesEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from PrjCases where CaseId = " + "'"+ objPrjCasesEN.CaseId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjCasesEN._CurrTabName);
if (objDS.Tables[clsPrjCasesEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CaseId = " + "'"+ objPrjCasesEN.CaseId+"'");
return false;
}
objRow = objDS.Tables[clsPrjCasesEN._CurrTabName].Rows[0];
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseId))
 {
objRow[conPrjCases.CaseId] = objPrjCasesEN.CaseId; //CaseId
 }
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseName))
 {
objRow[conPrjCases.CaseName] = objPrjCasesEN.CaseName; //CaseName
 }
 if (objPrjCasesEN.IsUpdated(conPrjCases.PrjId))
 {
objRow[conPrjCases.PrjId] = objPrjCasesEN.PrjId; //工程Id
 }
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseContent))
 {
objRow[conPrjCases.CaseContent] = objPrjCasesEN.CaseContent; //CaseContent
 }
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseTypeId))
 {
objRow[conPrjCases.CaseTypeId] = objPrjCasesEN.CaseTypeId; //CaseTypeId
 }
 if (objPrjCasesEN.IsUpdated(conPrjCases.ImportLevelId))
 {
objRow[conPrjCases.ImportLevelId] = objPrjCasesEN.ImportLevelId; //重要程度Id
 }
 if (objPrjCasesEN.IsUpdated(conPrjCases.UserId))
 {
objRow[conPrjCases.UserId] = objPrjCasesEN.UserId; //用户Id
 }
 if (objPrjCasesEN.IsUpdated(conPrjCases.UpdDate))
 {
objRow[conPrjCases.UpdDate] = objPrjCasesEN.UpdDate; //修改日期
 }
 if (objPrjCasesEN.IsUpdated(conPrjCases.Memo))
 {
objRow[conPrjCases.Memo] = objPrjCasesEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsPrjCasesEN._CurrTabName);
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjCasesEN objPrjCasesEN)
{
 objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjCasesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjCasesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjCases Set ");
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseName))
 {
 if (objPrjCasesEN.CaseName !=  null)
 {
 var strCaseName = objPrjCasesEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conPrjCases.CaseName); //CaseName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.CaseName); //CaseName
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.PrjId))
 {
 if (objPrjCasesEN.PrjId  ==  "")
 {
 objPrjCasesEN.PrjId = null;
 }
 if (objPrjCasesEN.PrjId !=  null)
 {
 var strPrjId = objPrjCasesEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjCases.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.PrjId); //工程Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseContent))
 {
 if (objPrjCasesEN.CaseContent !=  null)
 {
 var strCaseContent = objPrjCasesEN.CaseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseContent, conPrjCases.CaseContent); //CaseContent
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.CaseContent); //CaseContent
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseTypeId))
 {
 if (objPrjCasesEN.CaseTypeId !=  null)
 {
 var strCaseTypeId = objPrjCasesEN.CaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseTypeId, conPrjCases.CaseTypeId); //CaseTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.CaseTypeId); //CaseTypeId
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.ImportLevelId))
 {
 if (objPrjCasesEN.ImportLevelId !=  null)
 {
 var strImportLevelId = objPrjCasesEN.ImportLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImportLevelId, conPrjCases.ImportLevelId); //重要程度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.ImportLevelId); //重要程度Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.UserId))
 {
 if (objPrjCasesEN.UserId !=  null)
 {
 var strUserId = objPrjCasesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjCases.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.UserId); //用户Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.UpdDate))
 {
 if (objPrjCasesEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjCasesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjCases.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.UpdDate); //修改日期
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.Memo))
 {
 if (objPrjCasesEN.Memo !=  null)
 {
 var strMemo = objPrjCasesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjCases.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CaseId = '{0}'", objPrjCasesEN.CaseId); 
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
 /// <param name = "objPrjCasesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjCasesEN objPrjCasesEN, string strCondition)
{
 objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjCasesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjCasesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjCases Set ");
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseName))
 {
 if (objPrjCasesEN.CaseName !=  null)
 {
 var strCaseName = objPrjCasesEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //CaseName
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //CaseName
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.PrjId))
 {
 if (objPrjCasesEN.PrjId  ==  "")
 {
 objPrjCasesEN.PrjId = null;
 }
 if (objPrjCasesEN.PrjId !=  null)
 {
 var strPrjId = objPrjCasesEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseContent))
 {
 if (objPrjCasesEN.CaseContent !=  null)
 {
 var strCaseContent = objPrjCasesEN.CaseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseContent = '{0}',", strCaseContent); //CaseContent
 }
 else
 {
 sbSQL.Append(" CaseContent = null,"); //CaseContent
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseTypeId))
 {
 if (objPrjCasesEN.CaseTypeId !=  null)
 {
 var strCaseTypeId = objPrjCasesEN.CaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseTypeId = '{0}',", strCaseTypeId); //CaseTypeId
 }
 else
 {
 sbSQL.Append(" CaseTypeId = null,"); //CaseTypeId
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.ImportLevelId))
 {
 if (objPrjCasesEN.ImportLevelId !=  null)
 {
 var strImportLevelId = objPrjCasesEN.ImportLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImportLevelId = '{0}',", strImportLevelId); //重要程度Id
 }
 else
 {
 sbSQL.Append(" ImportLevelId = null,"); //重要程度Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.UserId))
 {
 if (objPrjCasesEN.UserId !=  null)
 {
 var strUserId = objPrjCasesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.UpdDate))
 {
 if (objPrjCasesEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjCasesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.Memo))
 {
 if (objPrjCasesEN.Memo !=  null)
 {
 var strMemo = objPrjCasesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjCasesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjCasesEN objPrjCasesEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjCasesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjCasesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjCases Set ");
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseName))
 {
 if (objPrjCasesEN.CaseName !=  null)
 {
 var strCaseName = objPrjCasesEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //CaseName
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //CaseName
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.PrjId))
 {
 if (objPrjCasesEN.PrjId  ==  "")
 {
 objPrjCasesEN.PrjId = null;
 }
 if (objPrjCasesEN.PrjId !=  null)
 {
 var strPrjId = objPrjCasesEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseContent))
 {
 if (objPrjCasesEN.CaseContent !=  null)
 {
 var strCaseContent = objPrjCasesEN.CaseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseContent = '{0}',", strCaseContent); //CaseContent
 }
 else
 {
 sbSQL.Append(" CaseContent = null,"); //CaseContent
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseTypeId))
 {
 if (objPrjCasesEN.CaseTypeId !=  null)
 {
 var strCaseTypeId = objPrjCasesEN.CaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseTypeId = '{0}',", strCaseTypeId); //CaseTypeId
 }
 else
 {
 sbSQL.Append(" CaseTypeId = null,"); //CaseTypeId
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.ImportLevelId))
 {
 if (objPrjCasesEN.ImportLevelId !=  null)
 {
 var strImportLevelId = objPrjCasesEN.ImportLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImportLevelId = '{0}',", strImportLevelId); //重要程度Id
 }
 else
 {
 sbSQL.Append(" ImportLevelId = null,"); //重要程度Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.UserId))
 {
 if (objPrjCasesEN.UserId !=  null)
 {
 var strUserId = objPrjCasesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.UpdDate))
 {
 if (objPrjCasesEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjCasesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.Memo))
 {
 if (objPrjCasesEN.Memo !=  null)
 {
 var strMemo = objPrjCasesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjCasesEN objPrjCasesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjCasesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjCasesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjCases Set ");
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseName))
 {
 if (objPrjCasesEN.CaseName !=  null)
 {
 var strCaseName = objPrjCasesEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conPrjCases.CaseName); //CaseName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.CaseName); //CaseName
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.PrjId))
 {
 if (objPrjCasesEN.PrjId  ==  "")
 {
 objPrjCasesEN.PrjId = null;
 }
 if (objPrjCasesEN.PrjId !=  null)
 {
 var strPrjId = objPrjCasesEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjCases.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.PrjId); //工程Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseContent))
 {
 if (objPrjCasesEN.CaseContent !=  null)
 {
 var strCaseContent = objPrjCasesEN.CaseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseContent, conPrjCases.CaseContent); //CaseContent
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.CaseContent); //CaseContent
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.CaseTypeId))
 {
 if (objPrjCasesEN.CaseTypeId !=  null)
 {
 var strCaseTypeId = objPrjCasesEN.CaseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseTypeId, conPrjCases.CaseTypeId); //CaseTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.CaseTypeId); //CaseTypeId
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.ImportLevelId))
 {
 if (objPrjCasesEN.ImportLevelId !=  null)
 {
 var strImportLevelId = objPrjCasesEN.ImportLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImportLevelId, conPrjCases.ImportLevelId); //重要程度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.ImportLevelId); //重要程度Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.UserId))
 {
 if (objPrjCasesEN.UserId !=  null)
 {
 var strUserId = objPrjCasesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjCases.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.UserId); //用户Id
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.UpdDate))
 {
 if (objPrjCasesEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjCasesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjCases.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.UpdDate); //修改日期
 }
 }
 
 if (objPrjCasesEN.IsUpdated(conPrjCases.Memo))
 {
 if (objPrjCasesEN.Memo !=  null)
 {
 var strMemo = objPrjCasesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjCases.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjCases.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CaseId = '{0}'", objPrjCasesEN.CaseId); 
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
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCaseId) 
{
CheckPrimaryKey(strCaseId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCaseId,
};
 objSQL.ExecSP("PrjCases_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCaseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCaseId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
//删除PrjCases本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjCases where CaseId = " + "'"+ strCaseId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjCases(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
//删除PrjCases本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjCases where CaseId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCaseId) 
{
CheckPrimaryKey(strCaseId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
//删除PrjCases本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjCases where CaseId = " + "'"+ strCaseId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjCases(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjCasesDA: DelPrjCases)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjCases where " + strCondition ;
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
public bool DelPrjCasesWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjCasesDA: DelPrjCasesWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjCases where " + strCondition ;
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
 /// <param name = "objPrjCasesENS">源对象</param>
 /// <param name = "objPrjCasesENT">目标对象</param>
public void CopyTo(clsPrjCasesEN objPrjCasesENS, clsPrjCasesEN objPrjCasesENT)
{
objPrjCasesENT.CaseId = objPrjCasesENS.CaseId; //CaseId
objPrjCasesENT.CaseName = objPrjCasesENS.CaseName; //CaseName
objPrjCasesENT.PrjId = objPrjCasesENS.PrjId; //工程Id
objPrjCasesENT.CaseContent = objPrjCasesENS.CaseContent; //CaseContent
objPrjCasesENT.CaseTypeId = objPrjCasesENS.CaseTypeId; //CaseTypeId
objPrjCasesENT.ImportLevelId = objPrjCasesENS.ImportLevelId; //重要程度Id
objPrjCasesENT.UserId = objPrjCasesENS.UserId; //用户Id
objPrjCasesENT.UpdDate = objPrjCasesENS.UpdDate; //修改日期
objPrjCasesENT.Memo = objPrjCasesENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjCasesEN objPrjCasesEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjCasesEN.CaseName, conPrjCases.CaseName);
clsCheckSql.CheckFieldNotNull(objPrjCasesEN.PrjId, conPrjCases.PrjId);
clsCheckSql.CheckFieldNotNull(objPrjCasesEN.CaseContent, conPrjCases.CaseContent);
clsCheckSql.CheckFieldNotNull(objPrjCasesEN.CaseTypeId, conPrjCases.CaseTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseId, 8, conPrjCases.CaseId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseName, 20, conPrjCases.CaseName);
clsCheckSql.CheckFieldLen(objPrjCasesEN.PrjId, 4, conPrjCases.PrjId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseContent, 1000, conPrjCases.CaseContent);
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseTypeId, 4, conPrjCases.CaseTypeId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.ImportLevelId, 4, conPrjCases.ImportLevelId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.UserId, 18, conPrjCases.UserId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.UpdDate, 20, conPrjCases.UpdDate);
clsCheckSql.CheckFieldLen(objPrjCasesEN.Memo, 1000, conPrjCases.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPrjCasesEN.PrjId, 4, conPrjCases.PrjId);
 objPrjCasesEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjCasesEN objPrjCasesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseName, 20, conPrjCases.CaseName);
clsCheckSql.CheckFieldLen(objPrjCasesEN.PrjId, 4, conPrjCases.PrjId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseContent, 1000, conPrjCases.CaseContent);
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseTypeId, 4, conPrjCases.CaseTypeId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.ImportLevelId, 4, conPrjCases.ImportLevelId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.UserId, 18, conPrjCases.UserId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.UpdDate, 20, conPrjCases.UpdDate);
clsCheckSql.CheckFieldLen(objPrjCasesEN.Memo, 1000, conPrjCases.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjCasesEN.PrjId, 4, conPrjCases.PrjId);
 objPrjCasesEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjCasesEN objPrjCasesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseId, 8, conPrjCases.CaseId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseName, 20, conPrjCases.CaseName);
clsCheckSql.CheckFieldLen(objPrjCasesEN.PrjId, 4, conPrjCases.PrjId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseContent, 1000, conPrjCases.CaseContent);
clsCheckSql.CheckFieldLen(objPrjCasesEN.CaseTypeId, 4, conPrjCases.CaseTypeId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.ImportLevelId, 4, conPrjCases.ImportLevelId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.UserId, 18, conPrjCases.UserId);
clsCheckSql.CheckFieldLen(objPrjCasesEN.UpdDate, 20, conPrjCases.UpdDate);
clsCheckSql.CheckFieldLen(objPrjCasesEN.Memo, 1000, conPrjCases.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjCasesEN.CaseId, conPrjCases.CaseId);
clsCheckSql.CheckSqlInjection4Field(objPrjCasesEN.CaseName, conPrjCases.CaseName);
clsCheckSql.CheckSqlInjection4Field(objPrjCasesEN.PrjId, conPrjCases.PrjId);
clsCheckSql.CheckSqlInjection4Field(objPrjCasesEN.CaseContent, conPrjCases.CaseContent);
clsCheckSql.CheckSqlInjection4Field(objPrjCasesEN.CaseTypeId, conPrjCases.CaseTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjCasesEN.ImportLevelId, conPrjCases.ImportLevelId);
clsCheckSql.CheckSqlInjection4Field(objPrjCasesEN.UserId, conPrjCases.UserId);
clsCheckSql.CheckSqlInjection4Field(objPrjCasesEN.UpdDate, conPrjCases.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPrjCasesEN.Memo, conPrjCases.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjCasesEN.PrjId, 4, conPrjCases.PrjId);
 objPrjCasesEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCaseId()
{
//获取某学院所有专业信息
string strSQL = "select CaseId, CaseName from PrjCases ";
 clsSpecSQLforSql mySql = clsPrjCasesDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PrjCases(工程用例),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjCasesEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPrjCasesEN objPrjCasesEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseName = '{0}'", objPrjCasesEN.CaseName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjCasesEN.PrjId);
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
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjCasesEN._CurrTabName);
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
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjCasesEN._CurrTabName, strCondition);
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
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
 objSQL = clsPrjCasesDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}