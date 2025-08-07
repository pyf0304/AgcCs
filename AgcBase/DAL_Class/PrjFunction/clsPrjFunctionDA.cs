
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFunctionDA
 表名:PrjFunction(00050072)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 工程函数(PrjFunction)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjFunctionDA : clsCommBase4DA
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
 return clsPrjFunctionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjFunctionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjFunctionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjFunctionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjFunctionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncId)
{
strFuncId = strFuncId.Replace("'", "''");
if (strFuncId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:PrjFunction中,检查关键字,长度不正确!(clsPrjFunctionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PrjFunction中,关键字不能为空 或 null!(clsPrjFunctionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPrjFunctionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjFunctionDA: GetDataTable_PrjFunction)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFunction where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFunction where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjFunction where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjFunction.* " + 
$"from PrjFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjFunction.FuncId not in " + 
$"(Select top {intTop_In} PrjFunction.FuncId from PrjFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFunction where {1} and FuncId not in (Select top {2} FuncId from PrjFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFunction where {1} and FuncId not in (Select top {3} FuncId from PrjFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjFunction.* " + 
$"from PrjFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjFunction.FuncId not in " + 
$"(Select top {intTop_In} PrjFunction.FuncId from PrjFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFunction where {1} and FuncId not in (Select top {2} FuncId from PrjFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFunction where {1} and FuncId not in (Select top {3} FuncId from PrjFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjFunctionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjFunctionDA:GetObjLst)", objException.Message));
}
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = TransNullToBool(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjFunctionDA: GetObjLst)", objException.Message));
}
objPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjFunctionEN);
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
public List<clsPrjFunctionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjFunctionDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = TransNullToBool(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjFunctionDA: GetObjLst)", objException.Message));
}
objPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjFunctionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjFunction(ref clsPrjFunctionEN objPrjFunctionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where FuncId = " + "'"+ objPrjFunctionEN.FuncId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjFunctionEN.FuncId = objDT.Rows[0][conPrjFunction.FuncId].ToString().Trim(); //函数ID(字段类型:varchar,字段长度:10,是否可空:False)
 objPrjFunctionEN.FuncName = objDT.Rows[0][conPrjFunction.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objPrjFunctionEN.PrjId = objDT.Rows[0][conPrjFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFunctionEN.ReturnTypeId = objDT.Rows[0][conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objPrjFunctionEN.FuncTypeId = objDT.Rows[0][conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjFunctionEN.IsTemplate = TransNullToBool(objDT.Rows[0][conPrjFunction.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objPrjFunctionEN.FuncCode = objDT.Rows[0][conPrjFunction.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objPrjFunctionEN.UserId = objDT.Rows[0][conPrjFunction.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjFunctionEN.UpdDate = objDT.Rows[0][conPrjFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFunctionEN.UpdUser = objDT.Rows[0][conPrjFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFunctionEN.Memo = objDT.Rows[0][conPrjFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjFunctionDA: GetPrjFunction)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjFunctionEN GetObjByFuncId(string strFuncId)
{
CheckPrimaryKey(strFuncId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where FuncId = " + "'"+ strFuncId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
 objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID(字段类型:varchar,字段长度:10,是否可空:False)
 objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjFunctionDA: GetObjByFuncId)", objException.Message));
}
return objPrjFunctionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjFunctionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjFunctionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN()
{
FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(), //函数ID
FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(), //函数名
PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(), //工程Id
ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(), //返回类型ID
FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(), //函数类型Id
IsTemplate = TransNullToBool(objRow[conPrjFunction.IsTemplate].ToString().Trim()), //是否模板
FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(), //函数代码
UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(), //用户Id
UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim() //说明
};
objPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFunctionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjFunctionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjFunctionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = TransNullToBool(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjFunctionDA: GetObjByDataRowPrjFunction)", objException.Message));
}
objPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFunctionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjFunctionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = TransNullToBool(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjFunctionDA: GetObjByDataRow)", objException.Message));
}
objPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFunctionEN;
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
objSQL = clsPrjFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjFunctionEN._CurrTabName, conPrjFunction.FuncId, 10, "");
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
objSQL = clsPrjFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjFunctionEN._CurrTabName, conPrjFunction.FuncId, 10, strPrefix);
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
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncId from PrjFunction where " + strCondition;
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
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncId from PrjFunction where " + strCondition;
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
 /// <param name = "strFuncId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncId)
{
CheckPrimaryKey(strFuncId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjFunction", "FuncId = " + "'"+ strFuncId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjFunctionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjFunction", strCondition))
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
objSQL = clsPrjFunctionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjFunction");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjFunctionEN objPrjFunctionEN)
 {
 objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFunctionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjFunction");
objRow = objDS.Tables["PrjFunction"].NewRow();
objRow[conPrjFunction.FuncId] = objPrjFunctionEN.FuncId; //函数ID
objRow[conPrjFunction.FuncName] = objPrjFunctionEN.FuncName; //函数名
objRow[conPrjFunction.PrjId] = objPrjFunctionEN.PrjId; //工程Id
objRow[conPrjFunction.ReturnTypeId] = objPrjFunctionEN.ReturnTypeId; //返回类型ID
objRow[conPrjFunction.FuncTypeId] = objPrjFunctionEN.FuncTypeId; //函数类型Id
objRow[conPrjFunction.IsTemplate] = objPrjFunctionEN.IsTemplate; //是否模板
 if (objPrjFunctionEN.FuncCode !=  "")
 {
objRow[conPrjFunction.FuncCode] = objPrjFunctionEN.FuncCode; //函数代码
 }
 if (objPrjFunctionEN.UserId !=  "")
 {
objRow[conPrjFunction.UserId] = objPrjFunctionEN.UserId; //用户Id
 }
 if (objPrjFunctionEN.UpdDate !=  "")
 {
objRow[conPrjFunction.UpdDate] = objPrjFunctionEN.UpdDate; //修改日期
 }
 if (objPrjFunctionEN.UpdUser !=  "")
 {
objRow[conPrjFunction.UpdUser] = objPrjFunctionEN.UpdUser; //修改者
 }
 if (objPrjFunctionEN.Memo !=  "")
 {
objRow[conPrjFunction.Memo] = objPrjFunctionEN.Memo; //说明
 }
objDS.Tables[clsPrjFunctionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjFunctionEN._CurrTabName);
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjFunctionEN objPrjFunctionEN)
{
 objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFunctionEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncId);
 var strFuncId = objPrjFunctionEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId + "'");
 }
 
 if (objPrjFunctionEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncName);
 var strFuncName = objPrjFunctionEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objPrjFunctionEN.PrjId  ==  "")
 {
 objPrjFunctionEN.PrjId = null;
 }
 if (objPrjFunctionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.PrjId);
 var strPrjId = objPrjFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjFunctionEN.ReturnTypeId  ==  "")
 {
 objPrjFunctionEN.ReturnTypeId = null;
 }
 if (objPrjFunctionEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.ReturnTypeId);
 var strReturnTypeId = objPrjFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objPrjFunctionEN.FuncTypeId  ==  "")
 {
 objPrjFunctionEN.FuncTypeId = null;
 }
 if (objPrjFunctionEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncTypeId);
 var strFuncTypeId = objPrjFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFunction.IsTemplate);
 arrValueListForInsert.Add("'" + (objPrjFunctionEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objPrjFunctionEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncCode);
 var strFuncCode = objPrjFunctionEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objPrjFunctionEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.UserId);
 var strUserId = objPrjFunctionEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.UpdDate);
 var strUpdDate = objPrjFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.UpdUser);
 var strUpdUser = objPrjFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.Memo);
 var strMemo = objPrjFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFunction");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjFunctionEN objPrjFunctionEN)
{
 objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFunctionEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncId);
 var strFuncId = objPrjFunctionEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId + "'");
 }
 
 if (objPrjFunctionEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncName);
 var strFuncName = objPrjFunctionEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objPrjFunctionEN.PrjId  ==  "")
 {
 objPrjFunctionEN.PrjId = null;
 }
 if (objPrjFunctionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.PrjId);
 var strPrjId = objPrjFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjFunctionEN.ReturnTypeId  ==  "")
 {
 objPrjFunctionEN.ReturnTypeId = null;
 }
 if (objPrjFunctionEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.ReturnTypeId);
 var strReturnTypeId = objPrjFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objPrjFunctionEN.FuncTypeId  ==  "")
 {
 objPrjFunctionEN.FuncTypeId = null;
 }
 if (objPrjFunctionEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncTypeId);
 var strFuncTypeId = objPrjFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFunction.IsTemplate);
 arrValueListForInsert.Add("'" + (objPrjFunctionEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objPrjFunctionEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncCode);
 var strFuncCode = objPrjFunctionEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objPrjFunctionEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.UserId);
 var strUserId = objPrjFunctionEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.UpdDate);
 var strUpdDate = objPrjFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.UpdUser);
 var strUpdUser = objPrjFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.Memo);
 var strMemo = objPrjFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFunction");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPrjFunctionEN.FuncId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjFunctionEN objPrjFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFunctionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFunctionEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncId);
 var strFuncId = objPrjFunctionEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId + "'");
 }
 
 if (objPrjFunctionEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncName);
 var strFuncName = objPrjFunctionEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objPrjFunctionEN.PrjId  ==  "")
 {
 objPrjFunctionEN.PrjId = null;
 }
 if (objPrjFunctionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.PrjId);
 var strPrjId = objPrjFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjFunctionEN.ReturnTypeId  ==  "")
 {
 objPrjFunctionEN.ReturnTypeId = null;
 }
 if (objPrjFunctionEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.ReturnTypeId);
 var strReturnTypeId = objPrjFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objPrjFunctionEN.FuncTypeId  ==  "")
 {
 objPrjFunctionEN.FuncTypeId = null;
 }
 if (objPrjFunctionEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncTypeId);
 var strFuncTypeId = objPrjFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFunction.IsTemplate);
 arrValueListForInsert.Add("'" + (objPrjFunctionEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objPrjFunctionEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.FuncCode);
 var strFuncCode = objPrjFunctionEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objPrjFunctionEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.UserId);
 var strUserId = objPrjFunctionEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.UpdDate);
 var strUpdDate = objPrjFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.UpdUser);
 var strUpdUser = objPrjFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunction.Memo);
 var strMemo = objPrjFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFunction");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjFunctions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where FuncId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjFunction");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFuncId = oRow[conPrjFunction.FuncId].ToString().Trim();
if (IsExist(strFuncId))
{
 string strResult = "关键字变量值为:" + string.Format("FuncId = {0}", strFuncId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjFunctionEN._CurrTabName ].NewRow();
objRow[conPrjFunction.FuncId] = oRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objRow[conPrjFunction.FuncName] = oRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objRow[conPrjFunction.PrjId] = oRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objRow[conPrjFunction.ReturnTypeId] = oRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objRow[conPrjFunction.FuncTypeId] = oRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objRow[conPrjFunction.IsTemplate] = oRow[conPrjFunction.IsTemplate].ToString().Trim(); //是否模板
objRow[conPrjFunction.FuncCode] = oRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objRow[conPrjFunction.UserId] = oRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objRow[conPrjFunction.UpdDate] = oRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objRow[conPrjFunction.UpdUser] = oRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objRow[conPrjFunction.Memo] = oRow[conPrjFunction.Memo].ToString().Trim(); //说明
 objDS.Tables[clsPrjFunctionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjFunctionEN._CurrTabName);
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
 /// <param name = "objPrjFunctionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjFunctionEN objPrjFunctionEN)
{
 objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunction where FuncId = " + "'"+ objPrjFunctionEN.FuncId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjFunctionEN._CurrTabName);
if (objDS.Tables[clsPrjFunctionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FuncId = " + "'"+ objPrjFunctionEN.FuncId+"'");
return false;
}
objRow = objDS.Tables[clsPrjFunctionEN._CurrTabName].Rows[0];
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncId))
 {
objRow[conPrjFunction.FuncId] = objPrjFunctionEN.FuncId; //函数ID
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncName))
 {
objRow[conPrjFunction.FuncName] = objPrjFunctionEN.FuncName; //函数名
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.PrjId))
 {
objRow[conPrjFunction.PrjId] = objPrjFunctionEN.PrjId; //工程Id
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.ReturnTypeId))
 {
objRow[conPrjFunction.ReturnTypeId] = objPrjFunctionEN.ReturnTypeId; //返回类型ID
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncTypeId))
 {
objRow[conPrjFunction.FuncTypeId] = objPrjFunctionEN.FuncTypeId; //函数类型Id
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.IsTemplate))
 {
objRow[conPrjFunction.IsTemplate] = objPrjFunctionEN.IsTemplate; //是否模板
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncCode))
 {
objRow[conPrjFunction.FuncCode] = objPrjFunctionEN.FuncCode; //函数代码
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UserId))
 {
objRow[conPrjFunction.UserId] = objPrjFunctionEN.UserId; //用户Id
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdDate))
 {
objRow[conPrjFunction.UpdDate] = objPrjFunctionEN.UpdDate; //修改日期
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdUser))
 {
objRow[conPrjFunction.UpdUser] = objPrjFunctionEN.UpdUser; //修改者
 }
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.Memo))
 {
objRow[conPrjFunction.Memo] = objPrjFunctionEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsPrjFunctionEN._CurrTabName);
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjFunctionEN objPrjFunctionEN)
{
 objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjFunction Set ");
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncName))
 {
 if (objPrjFunctionEN.FuncName !=  null)
 {
 var strFuncName = objPrjFunctionEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName, conPrjFunction.FuncName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.FuncName); //函数名
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.PrjId))
 {
 if (objPrjFunctionEN.PrjId  ==  "")
 {
 objPrjFunctionEN.PrjId = null;
 }
 if (objPrjFunctionEN.PrjId !=  null)
 {
 var strPrjId = objPrjFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjFunction.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.PrjId); //工程Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.ReturnTypeId))
 {
 if (objPrjFunctionEN.ReturnTypeId  ==  "")
 {
 objPrjFunctionEN.ReturnTypeId = null;
 }
 if (objPrjFunctionEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objPrjFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conPrjFunction.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncTypeId))
 {
 if (objPrjFunctionEN.FuncTypeId  ==  "")
 {
 objPrjFunctionEN.FuncTypeId = null;
 }
 if (objPrjFunctionEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objPrjFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conPrjFunction.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.FuncTypeId); //函数类型Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFunctionEN.IsTemplate == true?"1":"0", conPrjFunction.IsTemplate); //是否模板
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncCode))
 {
 if (objPrjFunctionEN.FuncCode !=  null)
 {
 var strFuncCode = objPrjFunctionEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCode, conPrjFunction.FuncCode); //函数代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.FuncCode); //函数代码
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UserId))
 {
 if (objPrjFunctionEN.UserId !=  null)
 {
 var strUserId = objPrjFunctionEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjFunction.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.UserId); //用户Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdDate))
 {
 if (objPrjFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjFunction.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.UpdDate); //修改日期
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdUser))
 {
 if (objPrjFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPrjFunction.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.UpdUser); //修改者
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.Memo))
 {
 if (objPrjFunctionEN.Memo !=  null)
 {
 var strMemo = objPrjFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjFunction.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncId = '{0}'", objPrjFunctionEN.FuncId); 
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
 /// <param name = "objPrjFunctionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjFunctionEN objPrjFunctionEN, string strCondition)
{
 objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFunction Set ");
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncName))
 {
 if (objPrjFunctionEN.FuncName !=  null)
 {
 var strFuncName = objPrjFunctionEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName = '{0}',", strFuncName); //函数名
 }
 else
 {
 sbSQL.Append(" FuncName = null,"); //函数名
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.PrjId))
 {
 if (objPrjFunctionEN.PrjId  ==  "")
 {
 objPrjFunctionEN.PrjId = null;
 }
 if (objPrjFunctionEN.PrjId !=  null)
 {
 var strPrjId = objPrjFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.ReturnTypeId))
 {
 if (objPrjFunctionEN.ReturnTypeId  ==  "")
 {
 objPrjFunctionEN.ReturnTypeId = null;
 }
 if (objPrjFunctionEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objPrjFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncTypeId))
 {
 if (objPrjFunctionEN.FuncTypeId  ==  "")
 {
 objPrjFunctionEN.FuncTypeId = null;
 }
 if (objPrjFunctionEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objPrjFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objPrjFunctionEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncCode))
 {
 if (objPrjFunctionEN.FuncCode !=  null)
 {
 var strFuncCode = objPrjFunctionEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCode = '{0}',", strFuncCode); //函数代码
 }
 else
 {
 sbSQL.Append(" FuncCode = null,"); //函数代码
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UserId))
 {
 if (objPrjFunctionEN.UserId !=  null)
 {
 var strUserId = objPrjFunctionEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdDate))
 {
 if (objPrjFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdUser))
 {
 if (objPrjFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.Memo))
 {
 if (objPrjFunctionEN.Memo !=  null)
 {
 var strMemo = objPrjFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjFunctionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjFunctionEN objPrjFunctionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFunction Set ");
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncName))
 {
 if (objPrjFunctionEN.FuncName !=  null)
 {
 var strFuncName = objPrjFunctionEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName = '{0}',", strFuncName); //函数名
 }
 else
 {
 sbSQL.Append(" FuncName = null,"); //函数名
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.PrjId))
 {
 if (objPrjFunctionEN.PrjId  ==  "")
 {
 objPrjFunctionEN.PrjId = null;
 }
 if (objPrjFunctionEN.PrjId !=  null)
 {
 var strPrjId = objPrjFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.ReturnTypeId))
 {
 if (objPrjFunctionEN.ReturnTypeId  ==  "")
 {
 objPrjFunctionEN.ReturnTypeId = null;
 }
 if (objPrjFunctionEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objPrjFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncTypeId))
 {
 if (objPrjFunctionEN.FuncTypeId  ==  "")
 {
 objPrjFunctionEN.FuncTypeId = null;
 }
 if (objPrjFunctionEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objPrjFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objPrjFunctionEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncCode))
 {
 if (objPrjFunctionEN.FuncCode !=  null)
 {
 var strFuncCode = objPrjFunctionEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCode = '{0}',", strFuncCode); //函数代码
 }
 else
 {
 sbSQL.Append(" FuncCode = null,"); //函数代码
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UserId))
 {
 if (objPrjFunctionEN.UserId !=  null)
 {
 var strUserId = objPrjFunctionEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdDate))
 {
 if (objPrjFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdUser))
 {
 if (objPrjFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.Memo))
 {
 if (objPrjFunctionEN.Memo !=  null)
 {
 var strMemo = objPrjFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjFunctionEN objPrjFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFunction Set ");
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncName))
 {
 if (objPrjFunctionEN.FuncName !=  null)
 {
 var strFuncName = objPrjFunctionEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName, conPrjFunction.FuncName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.FuncName); //函数名
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.PrjId))
 {
 if (objPrjFunctionEN.PrjId  ==  "")
 {
 objPrjFunctionEN.PrjId = null;
 }
 if (objPrjFunctionEN.PrjId !=  null)
 {
 var strPrjId = objPrjFunctionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjFunction.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.PrjId); //工程Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.ReturnTypeId))
 {
 if (objPrjFunctionEN.ReturnTypeId  ==  "")
 {
 objPrjFunctionEN.ReturnTypeId = null;
 }
 if (objPrjFunctionEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objPrjFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conPrjFunction.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncTypeId))
 {
 if (objPrjFunctionEN.FuncTypeId  ==  "")
 {
 objPrjFunctionEN.FuncTypeId = null;
 }
 if (objPrjFunctionEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objPrjFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conPrjFunction.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.FuncTypeId); //函数类型Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFunctionEN.IsTemplate == true?"1":"0", conPrjFunction.IsTemplate); //是否模板
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.FuncCode))
 {
 if (objPrjFunctionEN.FuncCode !=  null)
 {
 var strFuncCode = objPrjFunctionEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCode, conPrjFunction.FuncCode); //函数代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.FuncCode); //函数代码
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UserId))
 {
 if (objPrjFunctionEN.UserId !=  null)
 {
 var strUserId = objPrjFunctionEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjFunction.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.UserId); //用户Id
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdDate))
 {
 if (objPrjFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjFunction.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.UpdDate); //修改日期
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.UpdUser))
 {
 if (objPrjFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPrjFunction.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.UpdUser); //修改者
 }
 }
 
 if (objPrjFunctionEN.IsUpdated(conPrjFunction.Memo))
 {
 if (objPrjFunctionEN.Memo !=  null)
 {
 var strMemo = objPrjFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjFunction.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunction.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncId = '{0}'", objPrjFunctionEN.FuncId); 
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
 /// <param name = "strFuncId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncId) 
{
CheckPrimaryKey(strFuncId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFuncId,
};
 objSQL.ExecSP("PrjFunction_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFuncId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFuncId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFuncId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
//删除PrjFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFunction where FuncId = " + "'"+ strFuncId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjFunction(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
//删除PrjFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFunction where FuncId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFuncId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFuncId) 
{
CheckPrimaryKey(strFuncId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
//删除PrjFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFunction where FuncId = " + "'"+ strFuncId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjFunctionDA: DelPrjFunction)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjFunction where " + strCondition ;
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
public bool DelPrjFunctionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjFunctionDA: DelPrjFunctionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjFunction where " + strCondition ;
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
 /// <param name = "objPrjFunctionENS">源对象</param>
 /// <param name = "objPrjFunctionENT">目标对象</param>
public void CopyTo(clsPrjFunctionEN objPrjFunctionENS, clsPrjFunctionEN objPrjFunctionENT)
{
objPrjFunctionENT.FuncId = objPrjFunctionENS.FuncId; //函数ID
objPrjFunctionENT.FuncName = objPrjFunctionENS.FuncName; //函数名
objPrjFunctionENT.PrjId = objPrjFunctionENS.PrjId; //工程Id
objPrjFunctionENT.ReturnTypeId = objPrjFunctionENS.ReturnTypeId; //返回类型ID
objPrjFunctionENT.FuncTypeId = objPrjFunctionENS.FuncTypeId; //函数类型Id
objPrjFunctionENT.IsTemplate = objPrjFunctionENS.IsTemplate; //是否模板
objPrjFunctionENT.FuncCode = objPrjFunctionENS.FuncCode; //函数代码
objPrjFunctionENT.UserId = objPrjFunctionENS.UserId; //用户Id
objPrjFunctionENT.UpdDate = objPrjFunctionENS.UpdDate; //修改日期
objPrjFunctionENT.UpdUser = objPrjFunctionENS.UpdUser; //修改者
objPrjFunctionENT.Memo = objPrjFunctionENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjFunctionEN objPrjFunctionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjFunctionEN.FuncName, conPrjFunction.FuncName);
clsCheckSql.CheckFieldNotNull(objPrjFunctionEN.PrjId, conPrjFunction.PrjId);
clsCheckSql.CheckFieldNotNull(objPrjFunctionEN.ReturnTypeId, conPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldNotNull(objPrjFunctionEN.FuncTypeId, conPrjFunction.FuncTypeId);
clsCheckSql.CheckFieldNotNull(objPrjFunctionEN.IsTemplate, conPrjFunction.IsTemplate);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFunctionEN.FuncId, 10, conPrjFunction.FuncId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.FuncName, 100, conPrjFunction.FuncName);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.PrjId, 4, conPrjFunction.PrjId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.ReturnTypeId, 2, conPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.FuncTypeId, 2, conPrjFunction.FuncTypeId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.UserId, 18, conPrjFunction.UserId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.UpdDate, 20, conPrjFunction.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.UpdUser, 20, conPrjFunction.UpdUser);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.Memo, 1000, conPrjFunction.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPrjFunctionEN.PrjId, 4, conPrjFunction.PrjId);
clsCheckSql.CheckFieldForeignKey(objPrjFunctionEN.ReturnTypeId, 2, conPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(objPrjFunctionEN.FuncTypeId, 2, conPrjFunction.FuncTypeId);
 objPrjFunctionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjFunctionEN objPrjFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFunctionEN.FuncName, 100, conPrjFunction.FuncName);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.PrjId, 4, conPrjFunction.PrjId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.ReturnTypeId, 2, conPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.FuncTypeId, 2, conPrjFunction.FuncTypeId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.UserId, 18, conPrjFunction.UserId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.UpdDate, 20, conPrjFunction.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.UpdUser, 20, conPrjFunction.UpdUser);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.Memo, 1000, conPrjFunction.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjFunctionEN.PrjId, 4, conPrjFunction.PrjId);
clsCheckSql.CheckFieldForeignKey(objPrjFunctionEN.ReturnTypeId, 2, conPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(objPrjFunctionEN.FuncTypeId, 2, conPrjFunction.FuncTypeId);
 objPrjFunctionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjFunctionEN objPrjFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFunctionEN.FuncId, 10, conPrjFunction.FuncId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.FuncName, 100, conPrjFunction.FuncName);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.PrjId, 4, conPrjFunction.PrjId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.ReturnTypeId, 2, conPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.FuncTypeId, 2, conPrjFunction.FuncTypeId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.UserId, 18, conPrjFunction.UserId);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.UpdDate, 20, conPrjFunction.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.UpdUser, 20, conPrjFunction.UpdUser);
clsCheckSql.CheckFieldLen(objPrjFunctionEN.Memo, 1000, conPrjFunction.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionEN.FuncId, conPrjFunction.FuncId);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionEN.FuncName, conPrjFunction.FuncName);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionEN.PrjId, conPrjFunction.PrjId);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionEN.ReturnTypeId, conPrjFunction.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionEN.FuncTypeId, conPrjFunction.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionEN.UserId, conPrjFunction.UserId);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionEN.UpdDate, conPrjFunction.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionEN.UpdUser, conPrjFunction.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionEN.Memo, conPrjFunction.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjFunctionEN.PrjId, 4, conPrjFunction.PrjId);
clsCheckSql.CheckFieldForeignKey(objPrjFunctionEN.ReturnTypeId, 2, conPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(objPrjFunctionEN.FuncTypeId, 2, conPrjFunction.FuncTypeId);
 objPrjFunctionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFuncId()
{
//获取某学院所有专业信息
string strSQL = "select FuncId, FuncName from PrjFunction ";
 clsSpecSQLforSql mySql = clsPrjFunctionDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PrjFunction(工程函数),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjFunctionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPrjFunctionEN objPrjFunctionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName = '{0}'", objPrjFunctionEN.FuncName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjFunctionEN.PrjId);
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
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjFunctionEN._CurrTabName);
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
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjFunctionEN._CurrTabName, strCondition);
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
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
 objSQL = clsPrjFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}