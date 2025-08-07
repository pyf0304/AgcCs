
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFunctionPropDA
 表名:TabFunctionProp(00050522)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:37
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
 /// 表函数属性(TabFunctionProp)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTabFunctionPropDA : clsCommBase4DA
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
 return clsTabFunctionPropEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTabFunctionPropEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabFunctionPropEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTabFunctionPropEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTabFunctionPropEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TabFunctionProp(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetDataTable_TabFunctionProp)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabFunctionProp where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabFunctionProp where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TabFunctionProp where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabFunctionProp.* " + 
$"from TabFunctionProp " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabFunctionProp.mId not in " + 
$"(Select top {intTop_In} TabFunctionProp.mId from TabFunctionProp " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabFunctionProp where {1} and mId not in (Select top {2} mId from TabFunctionProp where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabFunctionProp where {1} and mId not in (Select top {3} mId from TabFunctionProp where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabFunctionProp.* " + 
$"from TabFunctionProp " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabFunctionProp.mId not in " + 
$"(Select top {intTop_In} TabFunctionProp.mId from TabFunctionProp " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabFunctionProp where {1} and mId not in (Select top {2} mId from TabFunctionProp where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabFunctionProp where {1} and mId not in (Select top {3} mId from TabFunctionProp where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTabFunctionPropEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTabFunctionPropDA:GetObjLst)", objException.Message));
}
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = TransNullToInt(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = TransNullToInt(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabFunctionPropDA: GetObjLst)", objException.Message));
}
objTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabFunctionPropEN);
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
public List<clsTabFunctionPropEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTabFunctionPropDA:GetObjLstByTabName)", objException.Message));
}
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = TransNullToInt(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = TransNullToInt(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabFunctionPropDA: GetObjLst)", objException.Message));
}
objTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabFunctionPropEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTabFunctionProp(ref clsTabFunctionPropEN objTabFunctionPropEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where mId = " + ""+ objTabFunctionPropEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTabFunctionPropEN.mId = TransNullToInt(objDT.Rows[0][conTabFunctionProp.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objTabFunctionPropEN.TabId = objDT.Rows[0][conTabFunctionProp.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objTabFunctionPropEN.FunctionTemplateId = objDT.Rows[0][conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFunctionPropEN.CodeTypeId = objDT.Rows[0][conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFunctionPropEN.FuncId4GC = objDT.Rows[0][conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objTabFunctionPropEN.MethodModifierId = objDT.Rows[0][conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id(字段类型:char,字段长度:2,是否可空:True)
 objTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objDT.Rows[0][conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板(字段类型:bit,字段长度:1,是否可空:True)
 objTabFunctionPropEN.OrderNum = TransNullToInt(objDT.Rows[0][conTabFunctionProp.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objTabFunctionPropEN.PrjId = objDT.Rows[0][conTabFunctionProp.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFunctionPropEN.UpdDate = objDT.Rows[0][conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTabFunctionPropEN.UpdUser = objDT.Rows[0][conTabFunctionProp.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objTabFunctionPropEN.Memo = objDT.Rows[0][conTabFunctionProp.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTabFunctionPropDA: GetTabFunctionProp)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsTabFunctionPropEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
 objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id(字段类型:char,字段长度:2,是否可空:True)
 objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板(字段类型:bit,字段长度:1,是否可空:True)
 objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTabFunctionPropDA: GetObjBymId)", objException.Message));
}
return objTabFunctionPropEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTabFunctionPropEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN()
{
mId = TransNullToInt(objRow[conTabFunctionProp.mId].ToString().Trim()), //mId
TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(), //表ID
FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(), //函数模板Id
CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(), //代码类型Id
FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(), //函数ID
MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(), //函数修饰语Id
IsForAllTemplate = TransNullToBool(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()), //是否针对所有模板
OrderNum = TransNullToInt(objRow[conTabFunctionProp.OrderNum].ToString().Trim()), //序号
PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim() //说明
};
objTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabFunctionPropEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTabFunctionPropDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTabFunctionPropEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = TransNullToInt(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = TransNullToInt(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTabFunctionPropDA: GetObjByDataRowTabFunctionProp)", objException.Message));
}
objTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabFunctionPropEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTabFunctionPropEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = TransNullToInt(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = TransNullToInt(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTabFunctionPropDA: GetObjByDataRow)", objException.Message));
}
objTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabFunctionPropEN;
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
objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabFunctionPropEN._CurrTabName, conTabFunctionProp.mId, 8, "");
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
objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabFunctionPropEN._CurrTabName, conTabFunctionProp.mId, 8, strPrefix);
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
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from TabFunctionProp where " + strCondition;
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
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from TabFunctionProp where " + strCondition;
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
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabFunctionProp", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTabFunctionPropDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabFunctionProp", strCondition))
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
objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TabFunctionProp");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTabFunctionPropEN objTabFunctionPropEN)
 {
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFunctionPropEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabFunctionProp");
objRow = objDS.Tables["TabFunctionProp"].NewRow();
objRow[conTabFunctionProp.TabId] = objTabFunctionPropEN.TabId; //表ID
 if (objTabFunctionPropEN.FunctionTemplateId !=  "")
 {
objRow[conTabFunctionProp.FunctionTemplateId] = objTabFunctionPropEN.FunctionTemplateId; //函数模板Id
 }
 if (objTabFunctionPropEN.CodeTypeId !=  "")
 {
objRow[conTabFunctionProp.CodeTypeId] = objTabFunctionPropEN.CodeTypeId; //代码类型Id
 }
objRow[conTabFunctionProp.FuncId4GC] = objTabFunctionPropEN.FuncId4GC; //函数ID
 if (objTabFunctionPropEN.MethodModifierId !=  "")
 {
objRow[conTabFunctionProp.MethodModifierId] = objTabFunctionPropEN.MethodModifierId; //函数修饰语Id
 }
objRow[conTabFunctionProp.IsForAllTemplate] = objTabFunctionPropEN.IsForAllTemplate; //是否针对所有模板
objRow[conTabFunctionProp.OrderNum] = objTabFunctionPropEN.OrderNum; //序号
 if (objTabFunctionPropEN.PrjId !=  "")
 {
objRow[conTabFunctionProp.PrjId] = objTabFunctionPropEN.PrjId; //工程Id
 }
 if (objTabFunctionPropEN.UpdDate !=  "")
 {
objRow[conTabFunctionProp.UpdDate] = objTabFunctionPropEN.UpdDate; //修改日期
 }
 if (objTabFunctionPropEN.UpdUser !=  "")
 {
objRow[conTabFunctionProp.UpdUser] = objTabFunctionPropEN.UpdUser; //修改者
 }
 if (objTabFunctionPropEN.Memo !=  "")
 {
objRow[conTabFunctionProp.Memo] = objTabFunctionPropEN.Memo; //说明
 }
objDS.Tables[clsTabFunctionPropEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTabFunctionPropEN._CurrTabName);
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
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabFunctionPropEN objTabFunctionPropEN)
{
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFunctionPropEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabFunctionPropEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.TabId);
 var strTabId = objTabFunctionPropEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFunctionPropEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.FunctionTemplateId);
 var strFunctionTemplateId = objTabFunctionPropEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objTabFunctionPropEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.CodeTypeId);
 var strCodeTypeId = objTabFunctionPropEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objTabFunctionPropEN.FuncId4GC !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.FuncId4GC);
 var strFuncId4GC = objTabFunctionPropEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4GC + "'");
 }
 
 if (objTabFunctionPropEN.MethodModifierId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.MethodModifierId);
 var strMethodModifierId = objTabFunctionPropEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFunctionProp.IsForAllTemplate);
 arrValueListForInsert.Add("'" + (objTabFunctionPropEN.IsForAllTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFunctionProp.OrderNum);
 arrValueListForInsert.Add(objTabFunctionPropEN.OrderNum.ToString());
 
 if (objTabFunctionPropEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.PrjId);
 var strPrjId = objTabFunctionPropEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabFunctionPropEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.UpdDate);
 var strUpdDate = objTabFunctionPropEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabFunctionPropEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.UpdUser);
 var strUpdUser = objTabFunctionPropEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabFunctionPropEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.Memo);
 var strMemo = objTabFunctionPropEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFunctionProp");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTabFunctionPropEN objTabFunctionPropEN)
{
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFunctionPropEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabFunctionPropEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.TabId);
 var strTabId = objTabFunctionPropEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFunctionPropEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.FunctionTemplateId);
 var strFunctionTemplateId = objTabFunctionPropEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objTabFunctionPropEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.CodeTypeId);
 var strCodeTypeId = objTabFunctionPropEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objTabFunctionPropEN.FuncId4GC !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.FuncId4GC);
 var strFuncId4GC = objTabFunctionPropEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4GC + "'");
 }
 
 if (objTabFunctionPropEN.MethodModifierId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.MethodModifierId);
 var strMethodModifierId = objTabFunctionPropEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFunctionProp.IsForAllTemplate);
 arrValueListForInsert.Add("'" + (objTabFunctionPropEN.IsForAllTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFunctionProp.OrderNum);
 arrValueListForInsert.Add(objTabFunctionPropEN.OrderNum.ToString());
 
 if (objTabFunctionPropEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.PrjId);
 var strPrjId = objTabFunctionPropEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabFunctionPropEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.UpdDate);
 var strUpdDate = objTabFunctionPropEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabFunctionPropEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.UpdUser);
 var strUpdUser = objTabFunctionPropEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabFunctionPropEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.Memo);
 var strMemo = objTabFunctionPropEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFunctionProp");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTabFunctionPropEN objTabFunctionPropEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFunctionPropEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabFunctionPropEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.TabId);
 var strTabId = objTabFunctionPropEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFunctionPropEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.FunctionTemplateId);
 var strFunctionTemplateId = objTabFunctionPropEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objTabFunctionPropEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.CodeTypeId);
 var strCodeTypeId = objTabFunctionPropEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objTabFunctionPropEN.FuncId4GC !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.FuncId4GC);
 var strFuncId4GC = objTabFunctionPropEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4GC + "'");
 }
 
 if (objTabFunctionPropEN.MethodModifierId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.MethodModifierId);
 var strMethodModifierId = objTabFunctionPropEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFunctionProp.IsForAllTemplate);
 arrValueListForInsert.Add("'" + (objTabFunctionPropEN.IsForAllTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFunctionProp.OrderNum);
 arrValueListForInsert.Add(objTabFunctionPropEN.OrderNum.ToString());
 
 if (objTabFunctionPropEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.PrjId);
 var strPrjId = objTabFunctionPropEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabFunctionPropEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.UpdDate);
 var strUpdDate = objTabFunctionPropEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabFunctionPropEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.UpdUser);
 var strUpdUser = objTabFunctionPropEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabFunctionPropEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.Memo);
 var strMemo = objTabFunctionPropEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFunctionProp");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabFunctionPropEN objTabFunctionPropEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabFunctionPropEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabFunctionPropEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.TabId);
 var strTabId = objTabFunctionPropEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objTabFunctionPropEN.FunctionTemplateId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.FunctionTemplateId);
 var strFunctionTemplateId = objTabFunctionPropEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionTemplateId + "'");
 }
 
 if (objTabFunctionPropEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.CodeTypeId);
 var strCodeTypeId = objTabFunctionPropEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objTabFunctionPropEN.FuncId4GC !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.FuncId4GC);
 var strFuncId4GC = objTabFunctionPropEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4GC + "'");
 }
 
 if (objTabFunctionPropEN.MethodModifierId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.MethodModifierId);
 var strMethodModifierId = objTabFunctionPropEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierId + "'");
 }
 
 arrFieldListForInsert.Add(conTabFunctionProp.IsForAllTemplate);
 arrValueListForInsert.Add("'" + (objTabFunctionPropEN.IsForAllTemplate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabFunctionProp.OrderNum);
 arrValueListForInsert.Add(objTabFunctionPropEN.OrderNum.ToString());
 
 if (objTabFunctionPropEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.PrjId);
 var strPrjId = objTabFunctionPropEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabFunctionPropEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.UpdDate);
 var strUpdDate = objTabFunctionPropEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabFunctionPropEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.UpdUser);
 var strUpdUser = objTabFunctionPropEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabFunctionPropEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabFunctionProp.Memo);
 var strMemo = objTabFunctionPropEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabFunctionProp");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTabFunctionProps(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabFunctionProp");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conTabFunctionProp.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTabFunctionPropEN._CurrTabName ].NewRow();
objRow[conTabFunctionProp.TabId] = oRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objRow[conTabFunctionProp.FunctionTemplateId] = oRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objRow[conTabFunctionProp.CodeTypeId] = oRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conTabFunctionProp.FuncId4GC] = oRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objRow[conTabFunctionProp.MethodModifierId] = oRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objRow[conTabFunctionProp.IsForAllTemplate] = oRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim(); //是否针对所有模板
objRow[conTabFunctionProp.OrderNum] = oRow[conTabFunctionProp.OrderNum].ToString().Trim(); //序号
objRow[conTabFunctionProp.PrjId] = oRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objRow[conTabFunctionProp.UpdDate] = oRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objRow[conTabFunctionProp.UpdUser] = oRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objRow[conTabFunctionProp.Memo] = oRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
 objDS.Tables[clsTabFunctionPropEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTabFunctionPropEN._CurrTabName);
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
 /// <param name = "objTabFunctionPropEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTabFunctionPropEN objTabFunctionPropEN)
{
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFunctionPropEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from TabFunctionProp where mId = " + ""+ objTabFunctionPropEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTabFunctionPropEN._CurrTabName);
if (objDS.Tables[clsTabFunctionPropEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objTabFunctionPropEN.mId+"");
return false;
}
objRow = objDS.Tables[clsTabFunctionPropEN._CurrTabName].Rows[0];
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.TabId))
 {
objRow[conTabFunctionProp.TabId] = objTabFunctionPropEN.TabId; //表ID
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FunctionTemplateId))
 {
objRow[conTabFunctionProp.FunctionTemplateId] = objTabFunctionPropEN.FunctionTemplateId; //函数模板Id
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.CodeTypeId))
 {
objRow[conTabFunctionProp.CodeTypeId] = objTabFunctionPropEN.CodeTypeId; //代码类型Id
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FuncId4GC))
 {
objRow[conTabFunctionProp.FuncId4GC] = objTabFunctionPropEN.FuncId4GC; //函数ID
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.MethodModifierId))
 {
objRow[conTabFunctionProp.MethodModifierId] = objTabFunctionPropEN.MethodModifierId; //函数修饰语Id
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.IsForAllTemplate))
 {
objRow[conTabFunctionProp.IsForAllTemplate] = objTabFunctionPropEN.IsForAllTemplate; //是否针对所有模板
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.OrderNum))
 {
objRow[conTabFunctionProp.OrderNum] = objTabFunctionPropEN.OrderNum; //序号
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.PrjId))
 {
objRow[conTabFunctionProp.PrjId] = objTabFunctionPropEN.PrjId; //工程Id
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdDate))
 {
objRow[conTabFunctionProp.UpdDate] = objTabFunctionPropEN.UpdDate; //修改日期
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdUser))
 {
objRow[conTabFunctionProp.UpdUser] = objTabFunctionPropEN.UpdUser; //修改者
 }
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.Memo))
 {
objRow[conTabFunctionProp.Memo] = objTabFunctionPropEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsTabFunctionPropEN._CurrTabName);
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
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabFunctionPropEN objTabFunctionPropEN)
{
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFunctionPropEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TabFunctionProp Set ");
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.TabId))
 {
 if (objTabFunctionPropEN.TabId !=  null)
 {
 var strTabId = objTabFunctionPropEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conTabFunctionProp.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.TabId); //表ID
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FunctionTemplateId))
 {
 if (objTabFunctionPropEN.FunctionTemplateId !=  null)
 {
 var strFunctionTemplateId = objTabFunctionPropEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionTemplateId, conTabFunctionProp.FunctionTemplateId); //函数模板Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.FunctionTemplateId); //函数模板Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.CodeTypeId))
 {
 if (objTabFunctionPropEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objTabFunctionPropEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conTabFunctionProp.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.CodeTypeId); //代码类型Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FuncId4GC))
 {
 if (objTabFunctionPropEN.FuncId4GC !=  null)
 {
 var strFuncId4GC = objTabFunctionPropEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncId4GC, conTabFunctionProp.FuncId4GC); //函数ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.FuncId4GC); //函数ID
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.MethodModifierId))
 {
 if (objTabFunctionPropEN.MethodModifierId !=  null)
 {
 var strMethodModifierId = objTabFunctionPropEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMethodModifierId, conTabFunctionProp.MethodModifierId); //函数修饰语Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.MethodModifierId); //函数修饰语Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.IsForAllTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFunctionPropEN.IsForAllTemplate == true?"1":"0", conTabFunctionProp.IsForAllTemplate); //是否针对所有模板
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFunctionPropEN.OrderNum, conTabFunctionProp.OrderNum); //序号
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.PrjId))
 {
 if (objTabFunctionPropEN.PrjId !=  null)
 {
 var strPrjId = objTabFunctionPropEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTabFunctionProp.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.PrjId); //工程Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdDate))
 {
 if (objTabFunctionPropEN.UpdDate !=  null)
 {
 var strUpdDate = objTabFunctionPropEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTabFunctionProp.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.UpdDate); //修改日期
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdUser))
 {
 if (objTabFunctionPropEN.UpdUser !=  null)
 {
 var strUpdUser = objTabFunctionPropEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTabFunctionProp.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.UpdUser); //修改者
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.Memo))
 {
 if (objTabFunctionPropEN.Memo !=  null)
 {
 var strMemo = objTabFunctionPropEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabFunctionProp.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objTabFunctionPropEN.mId); 
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
 /// <param name = "objTabFunctionPropEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTabFunctionPropEN objTabFunctionPropEN, string strCondition)
{
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFunctionPropEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabFunctionProp Set ");
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.TabId))
 {
 if (objTabFunctionPropEN.TabId !=  null)
 {
 var strTabId = objTabFunctionPropEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FunctionTemplateId))
 {
 if (objTabFunctionPropEN.FunctionTemplateId !=  null)
 {
 var strFunctionTemplateId = objTabFunctionPropEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionTemplateId = '{0}',", strFunctionTemplateId); //函数模板Id
 }
 else
 {
 sbSQL.Append(" FunctionTemplateId = null,"); //函数模板Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.CodeTypeId))
 {
 if (objTabFunctionPropEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objTabFunctionPropEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FuncId4GC))
 {
 if (objTabFunctionPropEN.FuncId4GC !=  null)
 {
 var strFuncId4GC = objTabFunctionPropEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncId4GC = '{0}',", strFuncId4GC); //函数ID
 }
 else
 {
 sbSQL.Append(" FuncId4GC = null,"); //函数ID
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.MethodModifierId))
 {
 if (objTabFunctionPropEN.MethodModifierId !=  null)
 {
 var strMethodModifierId = objTabFunctionPropEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MethodModifierId = '{0}',", strMethodModifierId); //函数修饰语Id
 }
 else
 {
 sbSQL.Append(" MethodModifierId = null,"); //函数修饰语Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.IsForAllTemplate))
 {
 sbSQL.AppendFormat(" IsForAllTemplate = '{0}',", objTabFunctionPropEN.IsForAllTemplate == true?"1":"0"); //是否针对所有模板
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objTabFunctionPropEN.OrderNum); //序号
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.PrjId))
 {
 if (objTabFunctionPropEN.PrjId !=  null)
 {
 var strPrjId = objTabFunctionPropEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdDate))
 {
 if (objTabFunctionPropEN.UpdDate !=  null)
 {
 var strUpdDate = objTabFunctionPropEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdUser))
 {
 if (objTabFunctionPropEN.UpdUser !=  null)
 {
 var strUpdUser = objTabFunctionPropEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.Memo))
 {
 if (objTabFunctionPropEN.Memo !=  null)
 {
 var strMemo = objTabFunctionPropEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTabFunctionPropEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTabFunctionPropEN objTabFunctionPropEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFunctionPropEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabFunctionProp Set ");
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.TabId))
 {
 if (objTabFunctionPropEN.TabId !=  null)
 {
 var strTabId = objTabFunctionPropEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FunctionTemplateId))
 {
 if (objTabFunctionPropEN.FunctionTemplateId !=  null)
 {
 var strFunctionTemplateId = objTabFunctionPropEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionTemplateId = '{0}',", strFunctionTemplateId); //函数模板Id
 }
 else
 {
 sbSQL.Append(" FunctionTemplateId = null,"); //函数模板Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.CodeTypeId))
 {
 if (objTabFunctionPropEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objTabFunctionPropEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FuncId4GC))
 {
 if (objTabFunctionPropEN.FuncId4GC !=  null)
 {
 var strFuncId4GC = objTabFunctionPropEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncId4GC = '{0}',", strFuncId4GC); //函数ID
 }
 else
 {
 sbSQL.Append(" FuncId4GC = null,"); //函数ID
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.MethodModifierId))
 {
 if (objTabFunctionPropEN.MethodModifierId !=  null)
 {
 var strMethodModifierId = objTabFunctionPropEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MethodModifierId = '{0}',", strMethodModifierId); //函数修饰语Id
 }
 else
 {
 sbSQL.Append(" MethodModifierId = null,"); //函数修饰语Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.IsForAllTemplate))
 {
 sbSQL.AppendFormat(" IsForAllTemplate = '{0}',", objTabFunctionPropEN.IsForAllTemplate == true?"1":"0"); //是否针对所有模板
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objTabFunctionPropEN.OrderNum); //序号
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.PrjId))
 {
 if (objTabFunctionPropEN.PrjId !=  null)
 {
 var strPrjId = objTabFunctionPropEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdDate))
 {
 if (objTabFunctionPropEN.UpdDate !=  null)
 {
 var strUpdDate = objTabFunctionPropEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdUser))
 {
 if (objTabFunctionPropEN.UpdUser !=  null)
 {
 var strUpdUser = objTabFunctionPropEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.Memo))
 {
 if (objTabFunctionPropEN.Memo !=  null)
 {
 var strMemo = objTabFunctionPropEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabFunctionPropEN objTabFunctionPropEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabFunctionPropEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabFunctionPropEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabFunctionProp Set ");
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.TabId))
 {
 if (objTabFunctionPropEN.TabId !=  null)
 {
 var strTabId = objTabFunctionPropEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conTabFunctionProp.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.TabId); //表ID
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FunctionTemplateId))
 {
 if (objTabFunctionPropEN.FunctionTemplateId !=  null)
 {
 var strFunctionTemplateId = objTabFunctionPropEN.FunctionTemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionTemplateId, conTabFunctionProp.FunctionTemplateId); //函数模板Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.FunctionTemplateId); //函数模板Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.CodeTypeId))
 {
 if (objTabFunctionPropEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objTabFunctionPropEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conTabFunctionProp.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.CodeTypeId); //代码类型Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.FuncId4GC))
 {
 if (objTabFunctionPropEN.FuncId4GC !=  null)
 {
 var strFuncId4GC = objTabFunctionPropEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncId4GC, conTabFunctionProp.FuncId4GC); //函数ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.FuncId4GC); //函数ID
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.MethodModifierId))
 {
 if (objTabFunctionPropEN.MethodModifierId !=  null)
 {
 var strMethodModifierId = objTabFunctionPropEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMethodModifierId, conTabFunctionProp.MethodModifierId); //函数修饰语Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.MethodModifierId); //函数修饰语Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.IsForAllTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabFunctionPropEN.IsForAllTemplate == true?"1":"0", conTabFunctionProp.IsForAllTemplate); //是否针对所有模板
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objTabFunctionPropEN.OrderNum, conTabFunctionProp.OrderNum); //序号
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.PrjId))
 {
 if (objTabFunctionPropEN.PrjId !=  null)
 {
 var strPrjId = objTabFunctionPropEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTabFunctionProp.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.PrjId); //工程Id
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdDate))
 {
 if (objTabFunctionPropEN.UpdDate !=  null)
 {
 var strUpdDate = objTabFunctionPropEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTabFunctionProp.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.UpdDate); //修改日期
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.UpdUser))
 {
 if (objTabFunctionPropEN.UpdUser !=  null)
 {
 var strUpdUser = objTabFunctionPropEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTabFunctionProp.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.UpdUser); //修改者
 }
 }
 
 if (objTabFunctionPropEN.IsUpdated(conTabFunctionProp.Memo))
 {
 if (objTabFunctionPropEN.Memo !=  null)
 {
 var strMemo = objTabFunctionPropEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabFunctionProp.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabFunctionProp.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objTabFunctionPropEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("TabFunctionProp_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
//删除TabFunctionProp本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabFunctionProp where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTabFunctionProp(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除TabFunctionProp本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabFunctionProp where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
//删除TabFunctionProp本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabFunctionProp where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTabFunctionProp(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: DelTabFunctionProp)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabFunctionProp where " + strCondition ;
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
public bool DelTabFunctionPropWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTabFunctionPropDA: DelTabFunctionPropWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabFunctionProp where " + strCondition ;
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
 /// <param name = "objTabFunctionPropENS">源对象</param>
 /// <param name = "objTabFunctionPropENT">目标对象</param>
public void CopyTo(clsTabFunctionPropEN objTabFunctionPropENS, clsTabFunctionPropEN objTabFunctionPropENT)
{
objTabFunctionPropENT.mId = objTabFunctionPropENS.mId; //mId
objTabFunctionPropENT.TabId = objTabFunctionPropENS.TabId; //表ID
objTabFunctionPropENT.FunctionTemplateId = objTabFunctionPropENS.FunctionTemplateId; //函数模板Id
objTabFunctionPropENT.CodeTypeId = objTabFunctionPropENS.CodeTypeId; //代码类型Id
objTabFunctionPropENT.FuncId4GC = objTabFunctionPropENS.FuncId4GC; //函数ID
objTabFunctionPropENT.MethodModifierId = objTabFunctionPropENS.MethodModifierId; //函数修饰语Id
objTabFunctionPropENT.IsForAllTemplate = objTabFunctionPropENS.IsForAllTemplate; //是否针对所有模板
objTabFunctionPropENT.OrderNum = objTabFunctionPropENS.OrderNum; //序号
objTabFunctionPropENT.PrjId = objTabFunctionPropENS.PrjId; //工程Id
objTabFunctionPropENT.UpdDate = objTabFunctionPropENS.UpdDate; //修改日期
objTabFunctionPropENT.UpdUser = objTabFunctionPropENS.UpdUser; //修改者
objTabFunctionPropENT.Memo = objTabFunctionPropENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTabFunctionPropEN objTabFunctionPropEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTabFunctionPropEN.TabId, conTabFunctionProp.TabId);
clsCheckSql.CheckFieldNotNull(objTabFunctionPropEN.FuncId4GC, conTabFunctionProp.FuncId4GC);
clsCheckSql.CheckFieldNotNull(objTabFunctionPropEN.IsForAllTemplate, conTabFunctionProp.IsForAllTemplate);
clsCheckSql.CheckFieldNotNull(objTabFunctionPropEN.OrderNum, conTabFunctionProp.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.TabId, 8, conTabFunctionProp.TabId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.FunctionTemplateId, 4, conTabFunctionProp.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.CodeTypeId, 4, conTabFunctionProp.CodeTypeId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.FuncId4GC, 10, conTabFunctionProp.FuncId4GC);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.MethodModifierId, 2, conTabFunctionProp.MethodModifierId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.PrjId, 4, conTabFunctionProp.PrjId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.UpdDate, 20, conTabFunctionProp.UpdDate);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.UpdUser, 20, conTabFunctionProp.UpdUser);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.Memo, 1000, conTabFunctionProp.Memo);
//检查字段外键固定长度
 objTabFunctionPropEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTabFunctionPropEN objTabFunctionPropEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.TabId, 8, conTabFunctionProp.TabId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.FunctionTemplateId, 4, conTabFunctionProp.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.CodeTypeId, 4, conTabFunctionProp.CodeTypeId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.FuncId4GC, 10, conTabFunctionProp.FuncId4GC);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.MethodModifierId, 2, conTabFunctionProp.MethodModifierId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.PrjId, 4, conTabFunctionProp.PrjId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.UpdDate, 20, conTabFunctionProp.UpdDate);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.UpdUser, 20, conTabFunctionProp.UpdUser);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.Memo, 1000, conTabFunctionProp.Memo);
//检查外键字段长度
 objTabFunctionPropEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTabFunctionPropEN objTabFunctionPropEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.TabId, 8, conTabFunctionProp.TabId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.FunctionTemplateId, 4, conTabFunctionProp.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.CodeTypeId, 4, conTabFunctionProp.CodeTypeId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.FuncId4GC, 10, conTabFunctionProp.FuncId4GC);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.MethodModifierId, 2, conTabFunctionProp.MethodModifierId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.PrjId, 4, conTabFunctionProp.PrjId);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.UpdDate, 20, conTabFunctionProp.UpdDate);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.UpdUser, 20, conTabFunctionProp.UpdUser);
clsCheckSql.CheckFieldLen(objTabFunctionPropEN.Memo, 1000, conTabFunctionProp.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTabFunctionPropEN.TabId, conTabFunctionProp.TabId);
clsCheckSql.CheckSqlInjection4Field(objTabFunctionPropEN.FunctionTemplateId, conTabFunctionProp.FunctionTemplateId);
clsCheckSql.CheckSqlInjection4Field(objTabFunctionPropEN.CodeTypeId, conTabFunctionProp.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objTabFunctionPropEN.FuncId4GC, conTabFunctionProp.FuncId4GC);
clsCheckSql.CheckSqlInjection4Field(objTabFunctionPropEN.MethodModifierId, conTabFunctionProp.MethodModifierId);
clsCheckSql.CheckSqlInjection4Field(objTabFunctionPropEN.PrjId, conTabFunctionProp.PrjId);
clsCheckSql.CheckSqlInjection4Field(objTabFunctionPropEN.UpdDate, conTabFunctionProp.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTabFunctionPropEN.UpdUser, conTabFunctionProp.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objTabFunctionPropEN.Memo, conTabFunctionProp.Memo);
//检查外键字段长度
 objTabFunctionPropEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TabFunctionProp(表函数属性),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTabFunctionPropEN objTabFunctionPropEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objTabFunctionPropEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null");
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabFunctionPropEN.PrjId);
}
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFunctionPropEN.TabId);
 if (objTabFunctionPropEN.CodeTypeId == null)
{
 sbCondition.AppendFormat(" and CodeTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objTabFunctionPropEN.CodeTypeId);
}
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objTabFunctionPropEN.FuncId4GC);
 if (objTabFunctionPropEN.FunctionTemplateId == null)
{
 sbCondition.AppendFormat(" and FunctionTemplateId is null");
}
else
{
 sbCondition.AppendFormat(" and FunctionTemplateId = '{0}'", objTabFunctionPropEN.FunctionTemplateId);
}
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
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
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
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
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
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabFunctionPropEN._CurrTabName);
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
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabFunctionPropEN._CurrTabName, strCondition);
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
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
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
 objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}