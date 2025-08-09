
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFuncTemplateRelaDA
 表名:vPrjFuncTemplateRela(00050318)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:56
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
 /// v工程与函数模板关系(vPrjFuncTemplateRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjFuncTemplateRelaDA : clsCommBase4DA
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
 return clsvPrjFuncTemplateRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjFuncTemplateRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjFuncTemplateRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjFuncTemplateRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjFuncTemplateRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFuncTemplateRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjFuncTemplateRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetDataTable_vPrjFuncTemplateRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFuncTemplateRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFuncTemplateRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjFuncTemplateRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjFuncTemplateRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjFuncTemplateRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjFuncTemplateRela.* " + 
$"from vPrjFuncTemplateRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjFuncTemplateRela.mId not in " + 
$"(Select top {intTop_In} vPrjFuncTemplateRela.mId from vPrjFuncTemplateRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjFuncTemplateRela where {1} and mId not in (Select top {2} mId from vPrjFuncTemplateRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjFuncTemplateRela where {1} and mId not in (Select top {3} mId from vPrjFuncTemplateRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjFuncTemplateRela.* " + 
$"from vPrjFuncTemplateRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjFuncTemplateRela.mId not in " + 
$"(Select top {intTop_In} vPrjFuncTemplateRela.mId from vPrjFuncTemplateRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjFuncTemplateRela where {1} and mId not in (Select top {2} mId from vPrjFuncTemplateRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjFuncTemplateRela where {1} and mId not in (Select top {3} mId from vPrjFuncTemplateRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjFuncTemplateRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA:GetObjLst)", objException.Message));
}
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFuncTemplateRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = TransNullToInt(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjFuncTemplateRelaDA: GetObjLst)", objException.Message));
}
objvPrjFuncTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
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
public List<clsvPrjFuncTemplateRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjFuncTemplateRelaEN> arrObjLst = new List<clsvPrjFuncTemplateRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = TransNullToInt(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjFuncTemplateRelaDA: GetObjLst)", objException.Message));
}
objvPrjFuncTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjFuncTemplateRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjFuncTemplateRela(ref clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFuncTemplateRela where mId = " + ""+ objvPrjFuncTemplateRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjFuncTemplateRelaEN.ProgLangTypeName = objDT.Rows[0][convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFuncTemplateRelaEN.FunctionTemplateName = objDT.Rows[0][convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjFuncTemplateRelaEN.CodeTypeENName = objDT.Rows[0][convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjFuncTemplateRelaEN.CodeTypeName = objDT.Rows[0][convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjFuncTemplateRelaEN.mId = TransNullToInt(objDT.Rows[0][convPrjFuncTemplateRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvPrjFuncTemplateRelaEN.PrjId = objDT.Rows[0][convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFuncTemplateRelaEN.PrjName = objDT.Rows[0][convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFuncTemplateRelaEN.CodeTypeId = objDT.Rows[0][convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFuncTemplateRelaEN.ProgLangTypeId = objDT.Rows[0][convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjFuncTemplateRelaEN.FunctionTemplateId = objDT.Rows[0][convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFuncTemplateRelaEN.UpdDate = objDT.Rows[0][convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFuncTemplateRelaEN.UpdUser = objDT.Rows[0][convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFuncTemplateRelaEN.Memo = objDT.Rows[0][convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjFuncTemplateRelaDA: GetvPrjFuncTemplateRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjFuncTemplateRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFuncTemplateRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
 objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjFuncTemplateRelaEN.mId = Int32.Parse(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjFuncTemplateRelaDA: GetObjBymId)", objException.Message));
}
return objvPrjFuncTemplateRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjFuncTemplateRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPrjFuncTemplateRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN()
{
ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(), //编程语言类型名
FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(), //函数模板名
CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(), //代码类型英文名
CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(), //代码类型名
mId = TransNullToInt(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()), //mId
PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(), //工程名称
CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(), //代码类型Id
ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(), //函数模板Id
UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim() //说明
};
objvPrjFuncTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjFuncTemplateRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjFuncTemplateRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjFuncTemplateRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = TransNullToInt(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjFuncTemplateRelaDA: GetObjByDataRowvPrjFuncTemplateRela)", objException.Message));
}
objvPrjFuncTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjFuncTemplateRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjFuncTemplateRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN = new clsvPrjFuncTemplateRelaEN();
try
{
objvPrjFuncTemplateRelaEN.ProgLangTypeName = objRow[convPrjFuncTemplateRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvPrjFuncTemplateRelaEN.FunctionTemplateName = objRow[convPrjFuncTemplateRela.FunctionTemplateName].ToString().Trim(); //函数模板名
objvPrjFuncTemplateRelaEN.CodeTypeENName = objRow[convPrjFuncTemplateRela.CodeTypeENName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvPrjFuncTemplateRelaEN.CodeTypeName = objRow[convPrjFuncTemplateRela.CodeTypeName] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeName].ToString().Trim(); //代码类型名
objvPrjFuncTemplateRelaEN.mId = TransNullToInt(objRow[convPrjFuncTemplateRela.mId].ToString().Trim()); //mId
objvPrjFuncTemplateRelaEN.PrjId = objRow[convPrjFuncTemplateRela.PrjId].ToString().Trim(); //工程Id
objvPrjFuncTemplateRelaEN.PrjName = objRow[convPrjFuncTemplateRela.PrjName].ToString().Trim(); //工程名称
objvPrjFuncTemplateRelaEN.CodeTypeId = objRow[convPrjFuncTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvPrjFuncTemplateRelaEN.ProgLangTypeId = objRow[convPrjFuncTemplateRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvPrjFuncTemplateRelaEN.FunctionTemplateId = objRow[convPrjFuncTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvPrjFuncTemplateRelaEN.UpdDate = objRow[convPrjFuncTemplateRela.UpdDate] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdDate].ToString().Trim(); //修改日期
objvPrjFuncTemplateRelaEN.UpdUser = objRow[convPrjFuncTemplateRela.UpdUser] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.UpdUser].ToString().Trim(); //修改者
objvPrjFuncTemplateRelaEN.Memo = objRow[convPrjFuncTemplateRela.Memo] == DBNull.Value ? null : objRow[convPrjFuncTemplateRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjFuncTemplateRelaDA: GetObjByDataRow)", objException.Message));
}
objvPrjFuncTemplateRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjFuncTemplateRelaEN;
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
objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjFuncTemplateRelaEN._CurrTabName, convPrjFuncTemplateRela.mId, 8, "");
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
objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjFuncTemplateRelaEN._CurrTabName, convPrjFuncTemplateRela.mId, 8, strPrefix);
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
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vPrjFuncTemplateRela where " + strCondition;
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
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vPrjFuncTemplateRela where " + strCondition;
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
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjFuncTemplateRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjFuncTemplateRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjFuncTemplateRela", strCondition))
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
objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjFuncTemplateRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaENS">源对象</param>
 /// <param name = "objvPrjFuncTemplateRelaENT">目标对象</param>
public void CopyTo(clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENS, clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENT)
{
objvPrjFuncTemplateRelaENT.ProgLangTypeName = objvPrjFuncTemplateRelaENS.ProgLangTypeName; //编程语言类型名
objvPrjFuncTemplateRelaENT.FunctionTemplateName = objvPrjFuncTemplateRelaENS.FunctionTemplateName; //函数模板名
objvPrjFuncTemplateRelaENT.CodeTypeENName = objvPrjFuncTemplateRelaENS.CodeTypeENName; //代码类型英文名
objvPrjFuncTemplateRelaENT.CodeTypeName = objvPrjFuncTemplateRelaENS.CodeTypeName; //代码类型名
objvPrjFuncTemplateRelaENT.mId = objvPrjFuncTemplateRelaENS.mId; //mId
objvPrjFuncTemplateRelaENT.PrjId = objvPrjFuncTemplateRelaENS.PrjId; //工程Id
objvPrjFuncTemplateRelaENT.PrjName = objvPrjFuncTemplateRelaENS.PrjName; //工程名称
objvPrjFuncTemplateRelaENT.CodeTypeId = objvPrjFuncTemplateRelaENS.CodeTypeId; //代码类型Id
objvPrjFuncTemplateRelaENT.ProgLangTypeId = objvPrjFuncTemplateRelaENS.ProgLangTypeId; //编程语言类型Id
objvPrjFuncTemplateRelaENT.FunctionTemplateId = objvPrjFuncTemplateRelaENS.FunctionTemplateId; //函数模板Id
objvPrjFuncTemplateRelaENT.UpdDate = objvPrjFuncTemplateRelaENS.UpdDate; //修改日期
objvPrjFuncTemplateRelaENT.UpdUser = objvPrjFuncTemplateRelaENS.UpdUser; //修改者
objvPrjFuncTemplateRelaENT.Memo = objvPrjFuncTemplateRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.ProgLangTypeName, 30, convPrjFuncTemplateRela.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.FunctionTemplateName, 50, convPrjFuncTemplateRela.FunctionTemplateName);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.CodeTypeENName, 50, convPrjFuncTemplateRela.CodeTypeENName);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.CodeTypeName, 50, convPrjFuncTemplateRela.CodeTypeName);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.PrjId, 4, convPrjFuncTemplateRela.PrjId);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.PrjName, 30, convPrjFuncTemplateRela.PrjName);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.CodeTypeId, 4, convPrjFuncTemplateRela.CodeTypeId);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.ProgLangTypeId, 2, convPrjFuncTemplateRela.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.FunctionTemplateId, 4, convPrjFuncTemplateRela.FunctionTemplateId);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.UpdDate, 20, convPrjFuncTemplateRela.UpdDate);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.UpdUser, 20, convPrjFuncTemplateRela.UpdUser);
clsCheckSql.CheckFieldLen(objvPrjFuncTemplateRelaEN.Memo, 1000, convPrjFuncTemplateRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.ProgLangTypeName, convPrjFuncTemplateRela.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.FunctionTemplateName, convPrjFuncTemplateRela.FunctionTemplateName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.CodeTypeENName, convPrjFuncTemplateRela.CodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.CodeTypeName, convPrjFuncTemplateRela.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.PrjId, convPrjFuncTemplateRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.PrjName, convPrjFuncTemplateRela.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.CodeTypeId, convPrjFuncTemplateRela.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.ProgLangTypeId, convPrjFuncTemplateRela.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.FunctionTemplateId, convPrjFuncTemplateRela.FunctionTemplateId);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.UpdDate, convPrjFuncTemplateRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.UpdUser, convPrjFuncTemplateRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvPrjFuncTemplateRelaEN.Memo, convPrjFuncTemplateRela.Memo);
//检查外键字段长度
 objvPrjFuncTemplateRelaEN._IsCheckProperty = true;
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
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
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
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
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
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjFuncTemplateRelaEN._CurrTabName);
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
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjFuncTemplateRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjFuncTemplateRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}