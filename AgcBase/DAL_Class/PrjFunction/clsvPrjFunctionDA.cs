
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFunctionDA
 表名:vPrjFunction(00050259)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:53
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
 /// v工程函数(vPrjFunction)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjFunctionDA : clsCommBase4DA
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
 return clsvPrjFunctionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjFunctionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjFunctionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjFunctionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjFunctionEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vPrjFunction中,检查关键字,长度不正确!(clsvPrjFunctionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjFunction中,关键字不能为空 或 null!(clsvPrjFunctionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjFunctionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetDataTable_vPrjFunction)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjFunction where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjFunction where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjFunction where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjFunction.* " + 
$"from vPrjFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjFunction.FuncId not in " + 
$"(Select top {intTop_In} vPrjFunction.FuncId from vPrjFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjFunction where {1} and FuncId not in (Select top {2} FuncId from vPrjFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjFunction where {1} and FuncId not in (Select top {3} FuncId from vPrjFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjFunction.* " + 
$"from vPrjFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjFunction.FuncId not in " + 
$"(Select top {intTop_In} vPrjFunction.FuncId from vPrjFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjFunction where {1} and FuncId not in (Select top {2} FuncId from vPrjFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjFunction where {1} and FuncId not in (Select top {3} FuncId from vPrjFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjFunctionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjFunctionDA:GetObjLst)", objException.Message));
}
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = TransNullToBool(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjFunctionDA: GetObjLst)", objException.Message));
}
objvPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjFunctionEN);
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
public List<clsvPrjFunctionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjFunctionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = TransNullToBool(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjFunctionDA: GetObjLst)", objException.Message));
}
objvPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjFunctionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjFunction(ref clsvPrjFunctionEN objvPrjFunctionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFunction where FuncId = " + "'"+ objvPrjFunctionEN.FuncId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjFunctionEN.FuncId = objDT.Rows[0][convPrjFunction.FuncId].ToString().Trim(); //函数ID(字段类型:varchar,字段长度:10,是否可空:False)
 objvPrjFunctionEN.FuncName = objDT.Rows[0][convPrjFunction.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjFunctionEN.PrjId = objDT.Rows[0][convPrjFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFunctionEN.ReturnTypeId = objDT.Rows[0][convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvPrjFunctionEN.DataTypeName = objDT.Rows[0][convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvPrjFunctionEN.DataCnName = objDT.Rows[0][convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjFunctionEN.CsType = objDT.Rows[0][convPrjFunction.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjFunctionEN.FuncTypeId = objDT.Rows[0][convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjFunctionEN.FuncTypeName = objDT.Rows[0][convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjFunctionEN.IsTemplate = TransNullToBool(objDT.Rows[0][convPrjFunction.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjFunctionEN.FuncCode = objDT.Rows[0][convPrjFunction.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPrjFunctionEN.UserId = objDT.Rows[0][convPrjFunction.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvPrjFunctionEN.UpdDate = objDT.Rows[0][convPrjFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFunctionEN.UpdUser = objDT.Rows[0][convPrjFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFunctionEN.Memo = objDT.Rows[0][convPrjFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjFunctionDA: GetvPrjFunction)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjFunctionEN GetObjByFuncId(string strFuncId)
{
CheckPrimaryKey(strFuncId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFunction where FuncId = " + "'"+ strFuncId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
 objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID(字段类型:varchar,字段长度:10,是否可空:False)
 objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjFunctionDA: GetObjByFuncId)", objException.Message));
}
return objvPrjFunctionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjFunctionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjFunctionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN()
{
FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(), //函数ID
FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(), //函数名
PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(), //工程Id
ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(), //返回类型ID
DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(), //数据类型名称
DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(), //数据类型中文名称
CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(), //CS类型
FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(), //函数类型Id
FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(), //函数类型名
IsTemplate = TransNullToBool(objRow[convPrjFunction.IsTemplate].ToString().Trim()), //是否模板
FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(), //函数代码
UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(), //用户Id
UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim() //说明
};
objvPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjFunctionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjFunctionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjFunctionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = TransNullToBool(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjFunctionDA: GetObjByDataRowvPrjFunction)", objException.Message));
}
objvPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjFunctionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjFunctionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = TransNullToBool(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjFunctionDA: GetObjByDataRow)", objException.Message));
}
objvPrjFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjFunctionEN;
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
objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjFunctionEN._CurrTabName, convPrjFunction.FuncId, 10, "");
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
objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjFunctionEN._CurrTabName, convPrjFunction.FuncId, 10, strPrefix);
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
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncId from vPrjFunction where " + strCondition;
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
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncId from vPrjFunction where " + strCondition;
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
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjFunction", "FuncId = " + "'"+ strFuncId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjFunctionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjFunction", strCondition))
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
objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjFunction");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjFunctionENS">源对象</param>
 /// <param name = "objvPrjFunctionENT">目标对象</param>
public void CopyTo(clsvPrjFunctionEN objvPrjFunctionENS, clsvPrjFunctionEN objvPrjFunctionENT)
{
objvPrjFunctionENT.FuncId = objvPrjFunctionENS.FuncId; //函数ID
objvPrjFunctionENT.FuncName = objvPrjFunctionENS.FuncName; //函数名
objvPrjFunctionENT.PrjId = objvPrjFunctionENS.PrjId; //工程Id
objvPrjFunctionENT.ReturnTypeId = objvPrjFunctionENS.ReturnTypeId; //返回类型ID
objvPrjFunctionENT.DataTypeName = objvPrjFunctionENS.DataTypeName; //数据类型名称
objvPrjFunctionENT.DataCnName = objvPrjFunctionENS.DataCnName; //数据类型中文名称
objvPrjFunctionENT.CsType = objvPrjFunctionENS.CsType; //CS类型
objvPrjFunctionENT.FuncTypeId = objvPrjFunctionENS.FuncTypeId; //函数类型Id
objvPrjFunctionENT.FuncTypeName = objvPrjFunctionENS.FuncTypeName; //函数类型名
objvPrjFunctionENT.IsTemplate = objvPrjFunctionENS.IsTemplate; //是否模板
objvPrjFunctionENT.FuncCode = objvPrjFunctionENS.FuncCode; //函数代码
objvPrjFunctionENT.UserId = objvPrjFunctionENS.UserId; //用户Id
objvPrjFunctionENT.UpdDate = objvPrjFunctionENS.UpdDate; //修改日期
objvPrjFunctionENT.UpdUser = objvPrjFunctionENS.UpdUser; //修改者
objvPrjFunctionENT.Memo = objvPrjFunctionENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjFunctionEN objvPrjFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.FuncId, 10, convPrjFunction.FuncId);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.FuncName, 100, convPrjFunction.FuncName);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.PrjId, 4, convPrjFunction.PrjId);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.ReturnTypeId, 2, convPrjFunction.ReturnTypeId);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.DataTypeName, 100, convPrjFunction.DataTypeName);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.DataCnName, 100, convPrjFunction.DataCnName);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.CsType, 100, convPrjFunction.CsType);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.FuncTypeId, 2, convPrjFunction.FuncTypeId);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.FuncTypeName, 20, convPrjFunction.FuncTypeName);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.UserId, 18, convPrjFunction.UserId);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.UpdDate, 20, convPrjFunction.UpdDate);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.UpdUser, 20, convPrjFunction.UpdUser);
clsCheckSql.CheckFieldLen(objvPrjFunctionEN.Memo, 1000, convPrjFunction.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.FuncId, convPrjFunction.FuncId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.FuncName, convPrjFunction.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.PrjId, convPrjFunction.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.ReturnTypeId, convPrjFunction.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.DataTypeName, convPrjFunction.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.DataCnName, convPrjFunction.DataCnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.CsType, convPrjFunction.CsType);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.FuncTypeId, convPrjFunction.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.FuncTypeName, convPrjFunction.FuncTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.UserId, convPrjFunction.UserId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.UpdDate, convPrjFunction.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.UpdUser, convPrjFunction.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvPrjFunctionEN.Memo, convPrjFunction.Memo);
//检查外键字段长度
 objvPrjFunctionEN._IsCheckProperty = true;
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
string strSQL = "select FuncId, FuncName from vPrjFunction ";
 clsSpecSQLforSql mySql = clsvPrjFunctionDA.GetSpecSQLObj();
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
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
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
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
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
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjFunctionEN._CurrTabName);
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
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjFunctionEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjFunctionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}