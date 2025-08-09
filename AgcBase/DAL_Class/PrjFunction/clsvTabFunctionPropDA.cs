
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFunctionPropDA
 表名:vTabFunctionProp(00050524)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// vTabFunctionProp(vTabFunctionProp)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTabFunctionPropDA : clsCommBase4DA
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
 return clsvTabFunctionPropEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTabFunctionPropEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFunctionPropEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTabFunctionPropEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTabFunctionPropEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from vTabFunctionProp where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTabFunctionProp(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetDataTable_vTabFunctionProp)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from vTabFunctionProp where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from vTabFunctionProp where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFunctionProp where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFunctionProp where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTabFunctionProp where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFunctionProp.* " + 
$"from vTabFunctionProp " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFunctionProp.mId not in " + 
$"(Select top {intTop_In} vTabFunctionProp.mId from vTabFunctionProp " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFunctionProp where {1} and mId not in (Select top {2} mId from vTabFunctionProp where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFunctionProp where {1} and mId not in (Select top {3} mId from vTabFunctionProp where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFunctionProp.* " + 
$"from vTabFunctionProp " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFunctionProp.mId not in " + 
$"(Select top {intTop_In} vTabFunctionProp.mId from vTabFunctionProp " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFunctionProp where {1} and mId not in (Select top {2} mId from vTabFunctionProp where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFunctionProp where {1} and mId not in (Select top {3} mId from vTabFunctionProp where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTabFunctionPropEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA:GetObjLst)", objException.Message));
}
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from vTabFunctionProp where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = TransNullToInt(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFunctionPropDA: GetObjLst)", objException.Message));
}
objvTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFunctionPropEN);
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
public List<clsvTabFunctionPropEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = TransNullToInt(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFunctionPropDA: GetObjLst)", objException.Message));
}
objvTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTabFunctionProp(ref clsvTabFunctionPropEN objvTabFunctionPropEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from vTabFunctionProp where mId = " + ""+ objvTabFunctionPropEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTabFunctionPropEN.mId = TransNullToInt(objDT.Rows[0][convTabFunctionProp.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvTabFunctionPropEN.TabId = objDT.Rows[0][convTabFunctionProp.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFunctionPropEN.TabName = objDT.Rows[0][convTabFunctionProp.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFunctionPropEN.TabCnName = objDT.Rows[0][convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFunctionPropEN.FunctionTemplateId = objDT.Rows[0][convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFunctionPropEN.FunctionTemplateName = objDT.Rows[0][convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabFunctionPropEN.CodeTypeId = objDT.Rows[0][convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFunctionPropEN.CodeTypeName = objDT.Rows[0][convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabFunctionPropEN.CodeTypeENName = objDT.Rows[0][convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFunctionPropEN.FuncId4GC = objDT.Rows[0][convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvTabFunctionPropEN.FuncName = objDT.Rows[0][convTabFunctionProp.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFunctionPropEN.FuncId4Code = objDT.Rows[0][convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvTabFunctionPropEN.FuncName4Code = objDT.Rows[0][convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFunctionPropEN.FuncCHName4Code = objDT.Rows[0][convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFunctionPropEN.ProgLangTypeId = objDT.Rows[0][convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabFunctionPropEN.ProgLangTypeName = objDT.Rows[0][convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFunctionPropEN.MethodModifierId = objDT.Rows[0][convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id(字段类型:char,字段长度:2,是否可空:True)
 objvTabFunctionPropEN.MethodModifierName = objDT.Rows[0][convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objDT.Rows[0][convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFunctionPropEN.PrjId = objDT.Rows[0][convTabFunctionProp.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFunctionPropEN.UpdDate = objDT.Rows[0][convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFunctionPropEN.UpdUser = objDT.Rows[0][convTabFunctionProp.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFunctionPropEN.Memo = objDT.Rows[0][convTabFunctionProp.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTabFunctionPropEN.Order4Func = TransNullToInt(objDT.Rows[0][convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTabFunctionPropDA: GetvTabFunctionProp)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvTabFunctionPropEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from vTabFunctionProp where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
 objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id(字段类型:char,字段长度:2,是否可空:True)
 objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTabFunctionPropDA: GetObjBymId)", objException.Message));
}
return objvTabFunctionPropEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTabFunctionPropEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
strSQL = "Select * from vTabFunctionProp where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN()
{
mId = TransNullToInt(objRow[convTabFunctionProp.mId].ToString().Trim()), //mId
TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(), //表ID
TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(), //表名
TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(), //表中文名
FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(), //函数模板Id
FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(), //函数模板名
CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(), //代码类型英文名
FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(), //函数ID
FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(), //函数名
FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(), //函数Id4Code
FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(), //函数名4Code
FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(), //函数中文名4Code
ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(), //编程语言类型名
MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(), //函数修饰语Id
MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(), //函数修饰语名称
IsForAllTemplate = TransNullToBool(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()), //是否针对所有模板
PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(), //说明
Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFunctionProp.Order4Func].ToString().Trim()) //Order4函数
};
objvTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFunctionPropEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTabFunctionPropDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTabFunctionPropEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = TransNullToInt(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTabFunctionPropDA: GetObjByDataRowvTabFunctionProp)", objException.Message));
}
objvTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFunctionPropEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTabFunctionPropEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = TransNullToInt(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = TransNullToBool(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTabFunctionPropDA: GetObjByDataRow)", objException.Message));
}
objvTabFunctionPropEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFunctionPropEN;
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
objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFunctionPropEN._CurrTabName, convTabFunctionProp.mId, 8, "");
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
objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFunctionPropEN._CurrTabName, convTabFunctionProp.mId, 8, strPrefix);
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
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vTabFunctionProp where " + strCondition;
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
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vTabFunctionProp where " + strCondition;
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
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFunctionProp", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTabFunctionPropDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFunctionProp", strCondition))
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
objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTabFunctionProp");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTabFunctionPropENS">源对象</param>
 /// <param name = "objvTabFunctionPropENT">目标对象</param>
public void CopyTo(clsvTabFunctionPropEN objvTabFunctionPropENS, clsvTabFunctionPropEN objvTabFunctionPropENT)
{
objvTabFunctionPropENT.mId = objvTabFunctionPropENS.mId; //mId
objvTabFunctionPropENT.TabId = objvTabFunctionPropENS.TabId; //表ID
objvTabFunctionPropENT.TabName = objvTabFunctionPropENS.TabName; //表名
objvTabFunctionPropENT.TabCnName = objvTabFunctionPropENS.TabCnName; //表中文名
objvTabFunctionPropENT.FunctionTemplateId = objvTabFunctionPropENS.FunctionTemplateId; //函数模板Id
objvTabFunctionPropENT.FunctionTemplateName = objvTabFunctionPropENS.FunctionTemplateName; //函数模板名
objvTabFunctionPropENT.CodeTypeId = objvTabFunctionPropENS.CodeTypeId; //代码类型Id
objvTabFunctionPropENT.CodeTypeName = objvTabFunctionPropENS.CodeTypeName; //代码类型名
objvTabFunctionPropENT.CodeTypeENName = objvTabFunctionPropENS.CodeTypeENName; //代码类型英文名
objvTabFunctionPropENT.FuncId4GC = objvTabFunctionPropENS.FuncId4GC; //函数ID
objvTabFunctionPropENT.FuncName = objvTabFunctionPropENS.FuncName; //函数名
objvTabFunctionPropENT.FuncId4Code = objvTabFunctionPropENS.FuncId4Code; //函数Id4Code
objvTabFunctionPropENT.FuncName4Code = objvTabFunctionPropENS.FuncName4Code; //函数名4Code
objvTabFunctionPropENT.FuncCHName4Code = objvTabFunctionPropENS.FuncCHName4Code; //函数中文名4Code
objvTabFunctionPropENT.ProgLangTypeId = objvTabFunctionPropENS.ProgLangTypeId; //编程语言类型Id
objvTabFunctionPropENT.ProgLangTypeName = objvTabFunctionPropENS.ProgLangTypeName; //编程语言类型名
objvTabFunctionPropENT.MethodModifierId = objvTabFunctionPropENS.MethodModifierId; //函数修饰语Id
objvTabFunctionPropENT.MethodModifierName = objvTabFunctionPropENS.MethodModifierName; //函数修饰语名称
objvTabFunctionPropENT.IsForAllTemplate = objvTabFunctionPropENS.IsForAllTemplate; //是否针对所有模板
objvTabFunctionPropENT.PrjId = objvTabFunctionPropENS.PrjId; //工程Id
objvTabFunctionPropENT.UpdDate = objvTabFunctionPropENS.UpdDate; //修改日期
objvTabFunctionPropENT.UpdUser = objvTabFunctionPropENS.UpdUser; //修改者
objvTabFunctionPropENT.Memo = objvTabFunctionPropENS.Memo; //说明
objvTabFunctionPropENT.Order4Func = objvTabFunctionPropENS.Order4Func; //Order4函数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTabFunctionPropEN objvTabFunctionPropEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.TabId, 8, convTabFunctionProp.TabId);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.TabName, 100, convTabFunctionProp.TabName);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.TabCnName, 200, convTabFunctionProp.TabCnName);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.FunctionTemplateId, 4, convTabFunctionProp.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.FunctionTemplateName, 50, convTabFunctionProp.FunctionTemplateName);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.CodeTypeId, 4, convTabFunctionProp.CodeTypeId);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.CodeTypeName, 50, convTabFunctionProp.CodeTypeName);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.CodeTypeENName, 50, convTabFunctionProp.CodeTypeENName);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.FuncId4GC, 10, convTabFunctionProp.FuncId4GC);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.FuncName, 100, convTabFunctionProp.FuncName);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.FuncId4Code, 8, convTabFunctionProp.FuncId4Code);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.FuncName4Code, 100, convTabFunctionProp.FuncName4Code);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.FuncCHName4Code, 200, convTabFunctionProp.FuncCHName4Code);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.ProgLangTypeId, 2, convTabFunctionProp.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.ProgLangTypeName, 30, convTabFunctionProp.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.MethodModifierId, 2, convTabFunctionProp.MethodModifierId);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.MethodModifierName, 50, convTabFunctionProp.MethodModifierName);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.PrjId, 4, convTabFunctionProp.PrjId);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.UpdDate, 20, convTabFunctionProp.UpdDate);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.UpdUser, 20, convTabFunctionProp.UpdUser);
clsCheckSql.CheckFieldLen(objvTabFunctionPropEN.Memo, 1000, convTabFunctionProp.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.TabId, convTabFunctionProp.TabId);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.TabName, convTabFunctionProp.TabName);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.TabCnName, convTabFunctionProp.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.FunctionTemplateId, convTabFunctionProp.FunctionTemplateId);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.FunctionTemplateName, convTabFunctionProp.FunctionTemplateName);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.CodeTypeId, convTabFunctionProp.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.CodeTypeName, convTabFunctionProp.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.CodeTypeENName, convTabFunctionProp.CodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.FuncId4GC, convTabFunctionProp.FuncId4GC);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.FuncName, convTabFunctionProp.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.FuncId4Code, convTabFunctionProp.FuncId4Code);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.FuncName4Code, convTabFunctionProp.FuncName4Code);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.FuncCHName4Code, convTabFunctionProp.FuncCHName4Code);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.ProgLangTypeId, convTabFunctionProp.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.ProgLangTypeName, convTabFunctionProp.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.MethodModifierId, convTabFunctionProp.MethodModifierId);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.MethodModifierName, convTabFunctionProp.MethodModifierName);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.PrjId, convTabFunctionProp.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.UpdDate, convTabFunctionProp.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.UpdUser, convTabFunctionProp.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvTabFunctionPropEN.Memo, convTabFunctionProp.Memo);
//检查外键字段长度
 objvTabFunctionPropEN._IsCheckProperty = true;
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
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
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
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
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
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFunctionPropEN._CurrTabName);
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
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFunctionPropEN._CurrTabName, strCondition);
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
 objSQL = clsvTabFunctionPropDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}