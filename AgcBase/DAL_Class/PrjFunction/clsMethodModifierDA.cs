
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMethodModifierDA
 表名:MethodModifier(00050523)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:31
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
 /// 函数修饰语(MethodModifier)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsMethodModifierDA : clsCommBase4DA
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
 return clsMethodModifierEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsMethodModifierEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMethodModifierEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsMethodModifierEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsMethodModifierEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strMethodModifierId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strMethodModifierId)
{
strMethodModifierId = strMethodModifierId.Replace("'", "''");
if (strMethodModifierId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:MethodModifier中,检查关键字,长度不正确!(clsMethodModifierDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMethodModifierId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:MethodModifier中,关键字不能为空 或 null!(clsMethodModifierDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMethodModifierId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsMethodModifierDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsMethodModifierDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_MethodModifier(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsMethodModifierDA: GetDataTable_MethodModifier)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsMethodModifierDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsMethodModifierDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsMethodModifierDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsMethodModifierDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MethodModifier where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MethodModifier where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsMethodModifierDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from MethodModifier where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsMethodModifierDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} MethodModifier.* " + 
$"from MethodModifier " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and MethodModifier.MethodModifierId not in " + 
$"(Select top {intTop_In} MethodModifier.MethodModifierId from MethodModifier " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MethodModifier where {1} and MethodModifierId not in (Select top {2} MethodModifierId from MethodModifier where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MethodModifier where {1} and MethodModifierId not in (Select top {3} MethodModifierId from MethodModifier where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsMethodModifierDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} MethodModifier.* " + 
$"from MethodModifier " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and MethodModifier.MethodModifierId not in " + 
$"(Select top {intTop_In} MethodModifier.MethodModifierId from MethodModifier " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MethodModifier where {1} and MethodModifierId not in (Select top {2} MethodModifierId from MethodModifier where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MethodModifier where {1} and MethodModifierId not in (Select top {3} MethodModifierId from MethodModifier where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsMethodModifierEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsMethodModifierDA:GetObjLst)", objException.Message));
}
List<clsMethodModifierEN> arrObjLst = new List<clsMethodModifierEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMethodModifierEN objMethodModifierEN = new clsMethodModifierEN();
try
{
objMethodModifierEN.MethodModifierId = objRow[conMethodModifier.MethodModifierId].ToString().Trim(); //函数修饰语Id
objMethodModifierEN.MethodModifierName = objRow[conMethodModifier.MethodModifierName].ToString().Trim(); //函数修饰语名称
objMethodModifierEN.OrderNum = TransNullToInt(objRow[conMethodModifier.OrderNum].ToString().Trim()); //序号
objMethodModifierEN.Memo = objRow[conMethodModifier.Memo] == DBNull.Value ? null : objRow[conMethodModifier.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMethodModifierDA: GetObjLst)", objException.Message));
}
objMethodModifierEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMethodModifierEN);
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
public List<clsMethodModifierEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsMethodModifierDA:GetObjLstByTabName)", objException.Message));
}
List<clsMethodModifierEN> arrObjLst = new List<clsMethodModifierEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMethodModifierEN objMethodModifierEN = new clsMethodModifierEN();
try
{
objMethodModifierEN.MethodModifierId = objRow[conMethodModifier.MethodModifierId].ToString().Trim(); //函数修饰语Id
objMethodModifierEN.MethodModifierName = objRow[conMethodModifier.MethodModifierName].ToString().Trim(); //函数修饰语名称
objMethodModifierEN.OrderNum = TransNullToInt(objRow[conMethodModifier.OrderNum].ToString().Trim()); //序号
objMethodModifierEN.Memo = objRow[conMethodModifier.Memo] == DBNull.Value ? null : objRow[conMethodModifier.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMethodModifierDA: GetObjLst)", objException.Message));
}
objMethodModifierEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMethodModifierEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objMethodModifierEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetMethodModifier(ref clsMethodModifierEN objMethodModifierEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where MethodModifierId = " + "'"+ objMethodModifierEN.MethodModifierId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objMethodModifierEN.MethodModifierId = objDT.Rows[0][conMethodModifier.MethodModifierId].ToString().Trim(); //函数修饰语Id(字段类型:char,字段长度:2,是否可空:True)
 objMethodModifierEN.MethodModifierName = objDT.Rows[0][conMethodModifier.MethodModifierName].ToString().Trim(); //函数修饰语名称(字段类型:varchar,字段长度:50,是否可空:True)
 objMethodModifierEN.OrderNum = TransNullToInt(objDT.Rows[0][conMethodModifier.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objMethodModifierEN.Memo = objDT.Rows[0][conMethodModifier.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsMethodModifierDA: GetMethodModifier)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMethodModifierId">表关键字</param>
 /// <returns>表对象</returns>
public clsMethodModifierEN GetObjByMethodModifierId(string strMethodModifierId)
{
CheckPrimaryKey(strMethodModifierId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where MethodModifierId = " + "'"+ strMethodModifierId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsMethodModifierEN objMethodModifierEN = new clsMethodModifierEN();
try
{
 objMethodModifierEN.MethodModifierId = objRow[conMethodModifier.MethodModifierId].ToString().Trim(); //函数修饰语Id(字段类型:char,字段长度:2,是否可空:True)
 objMethodModifierEN.MethodModifierName = objRow[conMethodModifier.MethodModifierName].ToString().Trim(); //函数修饰语名称(字段类型:varchar,字段长度:50,是否可空:True)
 objMethodModifierEN.OrderNum = Int32.Parse(objRow[conMethodModifier.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objMethodModifierEN.Memo = objRow[conMethodModifier.Memo] == DBNull.Value ? null : objRow[conMethodModifier.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsMethodModifierDA: GetObjByMethodModifierId)", objException.Message));
}
return objMethodModifierEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsMethodModifierEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsMethodModifierDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsMethodModifierEN objMethodModifierEN = new clsMethodModifierEN()
{
MethodModifierId = objRow[conMethodModifier.MethodModifierId].ToString().Trim(), //函数修饰语Id
MethodModifierName = objRow[conMethodModifier.MethodModifierName].ToString().Trim(), //函数修饰语名称
OrderNum = TransNullToInt(objRow[conMethodModifier.OrderNum].ToString().Trim()), //序号
Memo = objRow[conMethodModifier.Memo] == DBNull.Value ? null : objRow[conMethodModifier.Memo].ToString().Trim() //说明
};
objMethodModifierEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMethodModifierEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsMethodModifierDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsMethodModifierEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMethodModifierEN objMethodModifierEN = new clsMethodModifierEN();
try
{
objMethodModifierEN.MethodModifierId = objRow[conMethodModifier.MethodModifierId].ToString().Trim(); //函数修饰语Id
objMethodModifierEN.MethodModifierName = objRow[conMethodModifier.MethodModifierName].ToString().Trim(); //函数修饰语名称
objMethodModifierEN.OrderNum = TransNullToInt(objRow[conMethodModifier.OrderNum].ToString().Trim()); //序号
objMethodModifierEN.Memo = objRow[conMethodModifier.Memo] == DBNull.Value ? null : objRow[conMethodModifier.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsMethodModifierDA: GetObjByDataRowMethodModifier)", objException.Message));
}
objMethodModifierEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMethodModifierEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsMethodModifierEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMethodModifierEN objMethodModifierEN = new clsMethodModifierEN();
try
{
objMethodModifierEN.MethodModifierId = objRow[conMethodModifier.MethodModifierId].ToString().Trim(); //函数修饰语Id
objMethodModifierEN.MethodModifierName = objRow[conMethodModifier.MethodModifierName].ToString().Trim(); //函数修饰语名称
objMethodModifierEN.OrderNum = TransNullToInt(objRow[conMethodModifier.OrderNum].ToString().Trim()); //序号
objMethodModifierEN.Memo = objRow[conMethodModifier.Memo] == DBNull.Value ? null : objRow[conMethodModifier.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsMethodModifierDA: GetObjByDataRow)", objException.Message));
}
objMethodModifierEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMethodModifierEN;
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
objSQL = clsMethodModifierDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMethodModifierEN._CurrTabName, conMethodModifier.MethodModifierId, 2, "");
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
objSQL = clsMethodModifierDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMethodModifierEN._CurrTabName, conMethodModifier.MethodModifierId, 2, strPrefix);
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
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MethodModifierId from MethodModifier where " + strCondition;
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
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MethodModifierId from MethodModifier where " + strCondition;
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
 /// <param name = "strMethodModifierId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strMethodModifierId)
{
CheckPrimaryKey(strMethodModifierId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MethodModifier", "MethodModifierId = " + "'"+ strMethodModifierId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsMethodModifierDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MethodModifier", strCondition))
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
objSQL = clsMethodModifierDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("MethodModifier");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsMethodModifierEN objMethodModifierEN)
 {
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMethodModifierEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MethodModifier");
objRow = objDS.Tables["MethodModifier"].NewRow();
objRow[conMethodModifier.MethodModifierId] = objMethodModifierEN.MethodModifierId; //函数修饰语Id
objRow[conMethodModifier.MethodModifierName] = objMethodModifierEN.MethodModifierName; //函数修饰语名称
objRow[conMethodModifier.OrderNum] = objMethodModifierEN.OrderNum; //序号
 if (objMethodModifierEN.Memo !=  "")
 {
objRow[conMethodModifier.Memo] = objMethodModifierEN.Memo; //说明
 }
objDS.Tables[clsMethodModifierEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsMethodModifierEN._CurrTabName);
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
 /// <param name = "objMethodModifierEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMethodModifierEN objMethodModifierEN)
{
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMethodModifierEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMethodModifierEN.MethodModifierId !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.MethodModifierId);
 var strMethodModifierId = objMethodModifierEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierId + "'");
 }
 
 if (objMethodModifierEN.MethodModifierName !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.MethodModifierName);
 var strMethodModifierName = objMethodModifierEN.MethodModifierName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierName + "'");
 }
 
 arrFieldListForInsert.Add(conMethodModifier.OrderNum);
 arrValueListForInsert.Add(objMethodModifierEN.OrderNum.ToString());
 
 if (objMethodModifierEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.Memo);
 var strMemo = objMethodModifierEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MethodModifier");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objMethodModifierEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMethodModifierEN objMethodModifierEN)
{
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMethodModifierEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMethodModifierEN.MethodModifierId !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.MethodModifierId);
 var strMethodModifierId = objMethodModifierEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierId + "'");
 }
 
 if (objMethodModifierEN.MethodModifierName !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.MethodModifierName);
 var strMethodModifierName = objMethodModifierEN.MethodModifierName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierName + "'");
 }
 
 arrFieldListForInsert.Add(conMethodModifier.OrderNum);
 arrValueListForInsert.Add(objMethodModifierEN.OrderNum.ToString());
 
 if (objMethodModifierEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.Memo);
 var strMemo = objMethodModifierEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MethodModifier");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objMethodModifierEN.MethodModifierId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objMethodModifierEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMethodModifierEN objMethodModifierEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMethodModifierEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMethodModifierEN.MethodModifierId !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.MethodModifierId);
 var strMethodModifierId = objMethodModifierEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierId + "'");
 }
 
 if (objMethodModifierEN.MethodModifierName !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.MethodModifierName);
 var strMethodModifierName = objMethodModifierEN.MethodModifierName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierName + "'");
 }
 
 arrFieldListForInsert.Add(conMethodModifier.OrderNum);
 arrValueListForInsert.Add(objMethodModifierEN.OrderNum.ToString());
 
 if (objMethodModifierEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.Memo);
 var strMemo = objMethodModifierEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MethodModifier");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objMethodModifierEN.MethodModifierId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objMethodModifierEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMethodModifierEN objMethodModifierEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMethodModifierEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMethodModifierEN.MethodModifierId !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.MethodModifierId);
 var strMethodModifierId = objMethodModifierEN.MethodModifierId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierId + "'");
 }
 
 if (objMethodModifierEN.MethodModifierName !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.MethodModifierName);
 var strMethodModifierName = objMethodModifierEN.MethodModifierName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMethodModifierName + "'");
 }
 
 arrFieldListForInsert.Add(conMethodModifier.OrderNum);
 arrValueListForInsert.Add(objMethodModifierEN.OrderNum.ToString());
 
 if (objMethodModifierEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMethodModifier.Memo);
 var strMemo = objMethodModifierEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MethodModifier");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewMethodModifiers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where MethodModifierId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MethodModifier");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strMethodModifierId = oRow[conMethodModifier.MethodModifierId].ToString().Trim();
if (IsExist(strMethodModifierId))
{
 string strResult = "关键字变量值为:" + string.Format("MethodModifierId = {0}", strMethodModifierId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsMethodModifierEN._CurrTabName ].NewRow();
objRow[conMethodModifier.MethodModifierId] = oRow[conMethodModifier.MethodModifierId].ToString().Trim(); //函数修饰语Id
objRow[conMethodModifier.MethodModifierName] = oRow[conMethodModifier.MethodModifierName].ToString().Trim(); //函数修饰语名称
objRow[conMethodModifier.OrderNum] = oRow[conMethodModifier.OrderNum].ToString().Trim(); //序号
objRow[conMethodModifier.Memo] = oRow[conMethodModifier.Memo].ToString().Trim(); //说明
 objDS.Tables[clsMethodModifierEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsMethodModifierEN._CurrTabName);
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
 /// <param name = "objMethodModifierEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsMethodModifierEN objMethodModifierEN)
{
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMethodModifierEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
strSQL = "Select * from MethodModifier where MethodModifierId = " + "'"+ objMethodModifierEN.MethodModifierId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsMethodModifierEN._CurrTabName);
if (objDS.Tables[clsMethodModifierEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:MethodModifierId = " + "'"+ objMethodModifierEN.MethodModifierId+"'");
return false;
}
objRow = objDS.Tables[clsMethodModifierEN._CurrTabName].Rows[0];
 if (objMethodModifierEN.IsUpdated(conMethodModifier.MethodModifierId))
 {
objRow[conMethodModifier.MethodModifierId] = objMethodModifierEN.MethodModifierId; //函数修饰语Id
 }
 if (objMethodModifierEN.IsUpdated(conMethodModifier.MethodModifierName))
 {
objRow[conMethodModifier.MethodModifierName] = objMethodModifierEN.MethodModifierName; //函数修饰语名称
 }
 if (objMethodModifierEN.IsUpdated(conMethodModifier.OrderNum))
 {
objRow[conMethodModifier.OrderNum] = objMethodModifierEN.OrderNum; //序号
 }
 if (objMethodModifierEN.IsUpdated(conMethodModifier.Memo))
 {
objRow[conMethodModifier.Memo] = objMethodModifierEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsMethodModifierEN._CurrTabName);
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
 /// <param name = "objMethodModifierEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMethodModifierEN objMethodModifierEN)
{
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMethodModifierEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update MethodModifier Set ");
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.MethodModifierName))
 {
 if (objMethodModifierEN.MethodModifierName !=  null)
 {
 var strMethodModifierName = objMethodModifierEN.MethodModifierName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMethodModifierName, conMethodModifier.MethodModifierName); //函数修饰语名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMethodModifier.MethodModifierName); //函数修饰语名称
 }
 }
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objMethodModifierEN.OrderNum, conMethodModifier.OrderNum); //序号
 }
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.Memo))
 {
 if (objMethodModifierEN.Memo !=  null)
 {
 var strMemo = objMethodModifierEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMethodModifier.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMethodModifier.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MethodModifierId = '{0}'", objMethodModifierEN.MethodModifierId); 
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
 /// <param name = "objMethodModifierEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsMethodModifierEN objMethodModifierEN, string strCondition)
{
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMethodModifierEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MethodModifier Set ");
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.MethodModifierName))
 {
 if (objMethodModifierEN.MethodModifierName !=  null)
 {
 var strMethodModifierName = objMethodModifierEN.MethodModifierName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MethodModifierName = '{0}',", strMethodModifierName); //函数修饰语名称
 }
 else
 {
 sbSQL.Append(" MethodModifierName = null,"); //函数修饰语名称
 }
 }
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objMethodModifierEN.OrderNum); //序号
 }
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.Memo))
 {
 if (objMethodModifierEN.Memo !=  null)
 {
 var strMemo = objMethodModifierEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMethodModifierEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsMethodModifierEN objMethodModifierEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMethodModifierEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MethodModifier Set ");
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.MethodModifierName))
 {
 if (objMethodModifierEN.MethodModifierName !=  null)
 {
 var strMethodModifierName = objMethodModifierEN.MethodModifierName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MethodModifierName = '{0}',", strMethodModifierName); //函数修饰语名称
 }
 else
 {
 sbSQL.Append(" MethodModifierName = null,"); //函数修饰语名称
 }
 }
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objMethodModifierEN.OrderNum); //序号
 }
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.Memo))
 {
 if (objMethodModifierEN.Memo !=  null)
 {
 var strMemo = objMethodModifierEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMethodModifierEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMethodModifierEN objMethodModifierEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objMethodModifierEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMethodModifierEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MethodModifier Set ");
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.MethodModifierName))
 {
 if (objMethodModifierEN.MethodModifierName !=  null)
 {
 var strMethodModifierName = objMethodModifierEN.MethodModifierName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMethodModifierName, conMethodModifier.MethodModifierName); //函数修饰语名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMethodModifier.MethodModifierName); //函数修饰语名称
 }
 }
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objMethodModifierEN.OrderNum, conMethodModifier.OrderNum); //序号
 }
 
 if (objMethodModifierEN.IsUpdated(conMethodModifier.Memo))
 {
 if (objMethodModifierEN.Memo !=  null)
 {
 var strMemo = objMethodModifierEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMethodModifier.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMethodModifier.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MethodModifierId = '{0}'", objMethodModifierEN.MethodModifierId); 
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
 /// <param name = "strMethodModifierId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strMethodModifierId) 
{
CheckPrimaryKey(strMethodModifierId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strMethodModifierId,
};
 objSQL.ExecSP("MethodModifier_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strMethodModifierId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strMethodModifierId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strMethodModifierId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
//删除MethodModifier本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MethodModifier where MethodModifierId = " + "'"+ strMethodModifierId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelMethodModifier(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
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
//删除MethodModifier本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MethodModifier where MethodModifierId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strMethodModifierId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strMethodModifierId) 
{
CheckPrimaryKey(strMethodModifierId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
//删除MethodModifier本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MethodModifier where MethodModifierId = " + "'"+ strMethodModifierId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelMethodModifier(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsMethodModifierDA: DelMethodModifier)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MethodModifier where " + strCondition ;
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
public bool DelMethodModifierWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsMethodModifierDA: DelMethodModifierWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MethodModifier where " + strCondition ;
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
 /// <param name = "objMethodModifierENS">源对象</param>
 /// <param name = "objMethodModifierENT">目标对象</param>
public void CopyTo(clsMethodModifierEN objMethodModifierENS, clsMethodModifierEN objMethodModifierENT)
{
objMethodModifierENT.MethodModifierId = objMethodModifierENS.MethodModifierId; //函数修饰语Id
objMethodModifierENT.MethodModifierName = objMethodModifierENS.MethodModifierName; //函数修饰语名称
objMethodModifierENT.OrderNum = objMethodModifierENS.OrderNum; //序号
objMethodModifierENT.Memo = objMethodModifierENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsMethodModifierEN objMethodModifierEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objMethodModifierEN.MethodModifierName, conMethodModifier.MethodModifierName);
clsCheckSql.CheckFieldNotNull(objMethodModifierEN.OrderNum, conMethodModifier.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objMethodModifierEN.MethodModifierId, 2, conMethodModifier.MethodModifierId);
clsCheckSql.CheckFieldLen(objMethodModifierEN.MethodModifierName, 50, conMethodModifier.MethodModifierName);
clsCheckSql.CheckFieldLen(objMethodModifierEN.Memo, 1000, conMethodModifier.Memo);
//检查字段外键固定长度
 objMethodModifierEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsMethodModifierEN objMethodModifierEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMethodModifierEN.MethodModifierName, 50, conMethodModifier.MethodModifierName);
clsCheckSql.CheckFieldLen(objMethodModifierEN.Memo, 1000, conMethodModifier.Memo);
//检查外键字段长度
 objMethodModifierEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsMethodModifierEN objMethodModifierEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMethodModifierEN.MethodModifierId, 2, conMethodModifier.MethodModifierId);
clsCheckSql.CheckFieldLen(objMethodModifierEN.MethodModifierName, 50, conMethodModifier.MethodModifierName);
clsCheckSql.CheckFieldLen(objMethodModifierEN.Memo, 1000, conMethodModifier.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objMethodModifierEN.MethodModifierId, conMethodModifier.MethodModifierId);
clsCheckSql.CheckSqlInjection4Field(objMethodModifierEN.MethodModifierName, conMethodModifier.MethodModifierName);
clsCheckSql.CheckSqlInjection4Field(objMethodModifierEN.Memo, conMethodModifier.Memo);
//检查外键字段长度
 objMethodModifierEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetMethodModifierId()
{
//获取某学院所有专业信息
string strSQL = "select MethodModifierId, MethodModifierName from MethodModifier ";
 clsSpecSQLforSql mySql = clsMethodModifierDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--MethodModifier(函数修饰语),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMethodModifierEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsMethodModifierEN objMethodModifierEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MethodModifierName = '{0}'", objMethodModifierEN.MethodModifierName);
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
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
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
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
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
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMethodModifierEN._CurrTabName);
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
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMethodModifierEN._CurrTabName, strCondition);
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
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
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
 objSQL = clsMethodModifierDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}