
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVariablePrjIdRelaDA
 表名:GCVariablePrjIdRela(00050617)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:24:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// GCVariablePrjIdRela(GCVariablePrjIdRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsGCVariablePrjIdRelaDA : clsCommBase4DA
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
 return clsGCVariablePrjIdRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsGCVariablePrjIdRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCVariablePrjIdRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsGCVariablePrjIdRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsGCVariablePrjIdRelaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strVarId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strVarId)
{
strVarId = strVarId.Replace("'", "''");
if (strVarId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:GCVariablePrjIdRela中,检查关键字,长度不正确!(clsGCVariablePrjIdRelaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strVarId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:GCVariablePrjIdRela中,关键字不能为空 或 null!(clsGCVariablePrjIdRelaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strVarId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsGCVariablePrjIdRelaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_GCVariablePrjIdRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetDataTable_GCVariablePrjIdRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCVariablePrjIdRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCVariablePrjIdRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from GCVariablePrjIdRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GCVariablePrjIdRela.* " + 
$"from GCVariablePrjIdRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GCVariablePrjIdRela.VarId not in " + 
$"(Select top {intTop_In} GCVariablePrjIdRela.VarId from GCVariablePrjIdRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCVariablePrjIdRela where {1} and VarId not in (Select top {2} VarId from GCVariablePrjIdRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCVariablePrjIdRela where {1} and VarId not in (Select top {3} VarId from GCVariablePrjIdRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GCVariablePrjIdRela.* " + 
$"from GCVariablePrjIdRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GCVariablePrjIdRela.VarId not in " + 
$"(Select top {intTop_In} GCVariablePrjIdRela.VarId from GCVariablePrjIdRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCVariablePrjIdRela where {1} and VarId not in (Select top {2} VarId from GCVariablePrjIdRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCVariablePrjIdRela where {1} and VarId not in (Select top {3} VarId from GCVariablePrjIdRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsGCVariablePrjIdRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA:GetObjLst)", objException.Message));
}
List<clsGCVariablePrjIdRelaEN> arrObjLst = new List<clsGCVariablePrjIdRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN = new clsGCVariablePrjIdRelaEN();
try
{
objGCVariablePrjIdRelaEN.VarId = objRow[conGCVariablePrjIdRela.VarId].ToString().Trim(); //变量Id
objGCVariablePrjIdRelaEN.PrjId = objRow[conGCVariablePrjIdRela.PrjId].ToString().Trim(); //工程Id
objGCVariablePrjIdRelaEN.FldId = objRow[conGCVariablePrjIdRela.FldId] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.FldId].ToString().Trim(); //字段Id
objGCVariablePrjIdRelaEN.UpdUser = objRow[conGCVariablePrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdUser].ToString().Trim(); //修改者
objGCVariablePrjIdRelaEN.UpdDate = objRow[conGCVariablePrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdDate].ToString().Trim(); //修改日期
objGCVariablePrjIdRelaEN.Memo = objRow[conGCVariablePrjIdRela.Memo] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGCVariablePrjIdRelaDA: GetObjLst)", objException.Message));
}
objGCVariablePrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGCVariablePrjIdRelaEN);
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
public List<clsGCVariablePrjIdRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsGCVariablePrjIdRelaEN> arrObjLst = new List<clsGCVariablePrjIdRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN = new clsGCVariablePrjIdRelaEN();
try
{
objGCVariablePrjIdRelaEN.VarId = objRow[conGCVariablePrjIdRela.VarId].ToString().Trim(); //变量Id
objGCVariablePrjIdRelaEN.PrjId = objRow[conGCVariablePrjIdRela.PrjId].ToString().Trim(); //工程Id
objGCVariablePrjIdRelaEN.FldId = objRow[conGCVariablePrjIdRela.FldId] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.FldId].ToString().Trim(); //字段Id
objGCVariablePrjIdRelaEN.UpdUser = objRow[conGCVariablePrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdUser].ToString().Trim(); //修改者
objGCVariablePrjIdRelaEN.UpdDate = objRow[conGCVariablePrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdDate].ToString().Trim(); //修改日期
objGCVariablePrjIdRelaEN.Memo = objRow[conGCVariablePrjIdRela.Memo] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGCVariablePrjIdRelaDA: GetObjLst)", objException.Message));
}
objGCVariablePrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGCVariablePrjIdRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objGCVariablePrjIdRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetGCVariablePrjIdRela(ref clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where VarId = " + "'"+ objGCVariablePrjIdRelaEN.VarId+"'" + " and PrjId = " + "'"+ objGCVariablePrjIdRelaEN.PrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objGCVariablePrjIdRelaEN.VarId = objDT.Rows[0][conGCVariablePrjIdRela.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objGCVariablePrjIdRelaEN.PrjId = objDT.Rows[0][conGCVariablePrjIdRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objGCVariablePrjIdRelaEN.FldId = objDT.Rows[0][conGCVariablePrjIdRela.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objGCVariablePrjIdRelaEN.UpdUser = objDT.Rows[0][conGCVariablePrjIdRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVariablePrjIdRelaEN.UpdDate = objDT.Rows[0][conGCVariablePrjIdRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVariablePrjIdRelaEN.Memo = objDT.Rows[0][conGCVariablePrjIdRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsGCVariablePrjIdRelaDA: GetGCVariablePrjIdRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <param name = "strPrjId">表关键字</param>
 /// <returns>表对象</returns>
public clsGCVariablePrjIdRelaEN GetObjByKeyLst(string strVarId,string strPrjId)
{
CheckPrimaryKey(strVarId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where VarId = " + "'"+ strVarId+"'" + " and PrjId = " + "'"+ strPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN = new clsGCVariablePrjIdRelaEN();
try
{
 objGCVariablePrjIdRelaEN.VarId = objRow[conGCVariablePrjIdRela.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objGCVariablePrjIdRelaEN.PrjId = objRow[conGCVariablePrjIdRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objGCVariablePrjIdRelaEN.FldId = objRow[conGCVariablePrjIdRela.FldId] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objGCVariablePrjIdRelaEN.UpdUser = objRow[conGCVariablePrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVariablePrjIdRelaEN.UpdDate = objRow[conGCVariablePrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVariablePrjIdRelaEN.Memo = objRow[conGCVariablePrjIdRela.Memo] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsGCVariablePrjIdRelaDA: GetObjByKeyLst)", objException.Message));
}
return objGCVariablePrjIdRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsGCVariablePrjIdRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN = new clsGCVariablePrjIdRelaEN()
{
VarId = objRow[conGCVariablePrjIdRela.VarId].ToString().Trim(), //变量Id
PrjId = objRow[conGCVariablePrjIdRela.PrjId].ToString().Trim(), //工程Id
FldId = objRow[conGCVariablePrjIdRela.FldId] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.FldId].ToString().Trim(), //字段Id
UpdUser = objRow[conGCVariablePrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conGCVariablePrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conGCVariablePrjIdRela.Memo] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.Memo].ToString().Trim() //说明
};
objGCVariablePrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCVariablePrjIdRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsGCVariablePrjIdRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsGCVariablePrjIdRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN = new clsGCVariablePrjIdRelaEN();
try
{
objGCVariablePrjIdRelaEN.VarId = objRow[conGCVariablePrjIdRela.VarId].ToString().Trim(); //变量Id
objGCVariablePrjIdRelaEN.PrjId = objRow[conGCVariablePrjIdRela.PrjId].ToString().Trim(); //工程Id
objGCVariablePrjIdRelaEN.FldId = objRow[conGCVariablePrjIdRela.FldId] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.FldId].ToString().Trim(); //字段Id
objGCVariablePrjIdRelaEN.UpdUser = objRow[conGCVariablePrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdUser].ToString().Trim(); //修改者
objGCVariablePrjIdRelaEN.UpdDate = objRow[conGCVariablePrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdDate].ToString().Trim(); //修改日期
objGCVariablePrjIdRelaEN.Memo = objRow[conGCVariablePrjIdRela.Memo] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsGCVariablePrjIdRelaDA: GetObjByDataRowGCVariablePrjIdRela)", objException.Message));
}
objGCVariablePrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCVariablePrjIdRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsGCVariablePrjIdRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN = new clsGCVariablePrjIdRelaEN();
try
{
objGCVariablePrjIdRelaEN.VarId = objRow[conGCVariablePrjIdRela.VarId].ToString().Trim(); //变量Id
objGCVariablePrjIdRelaEN.PrjId = objRow[conGCVariablePrjIdRela.PrjId].ToString().Trim(); //工程Id
objGCVariablePrjIdRelaEN.FldId = objRow[conGCVariablePrjIdRela.FldId] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.FldId].ToString().Trim(); //字段Id
objGCVariablePrjIdRelaEN.UpdUser = objRow[conGCVariablePrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdUser].ToString().Trim(); //修改者
objGCVariablePrjIdRelaEN.UpdDate = objRow[conGCVariablePrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.UpdDate].ToString().Trim(); //修改日期
objGCVariablePrjIdRelaEN.Memo = objRow[conGCVariablePrjIdRela.Memo] == DBNull.Value ? null : objRow[conGCVariablePrjIdRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsGCVariablePrjIdRelaDA: GetObjByDataRow)", objException.Message));
}
objGCVariablePrjIdRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCVariablePrjIdRelaEN;
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
objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGCVariablePrjIdRelaEN._CurrTabName, conGCVariablePrjIdRela.VarId, 8, "");
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
objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGCVariablePrjIdRelaEN._CurrTabName, conGCVariablePrjIdRela.VarId, 8, strPrefix);
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
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select VarId,PrjId from GCVariablePrjIdRela where " + strCondition;
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
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select VarId,PrjId from GCVariablePrjIdRela where " + strCondition;
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strVarId, string strPrjId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GCVariablePrjIdRela", "VarId = " + "'"+ strVarId+"'" + " and PrjId = " + "'"+ strPrjId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GCVariablePrjIdRela", strCondition))
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
objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("GCVariablePrjIdRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN)
 {
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariablePrjIdRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GCVariablePrjIdRela");
objRow = objDS.Tables["GCVariablePrjIdRela"].NewRow();
objRow[conGCVariablePrjIdRela.VarId] = objGCVariablePrjIdRelaEN.VarId; //变量Id
objRow[conGCVariablePrjIdRela.PrjId] = objGCVariablePrjIdRelaEN.PrjId; //工程Id
 if (objGCVariablePrjIdRelaEN.FldId !=  "")
 {
objRow[conGCVariablePrjIdRela.FldId] = objGCVariablePrjIdRelaEN.FldId; //字段Id
 }
 if (objGCVariablePrjIdRelaEN.UpdUser !=  "")
 {
objRow[conGCVariablePrjIdRela.UpdUser] = objGCVariablePrjIdRelaEN.UpdUser; //修改者
 }
 if (objGCVariablePrjIdRelaEN.UpdDate !=  "")
 {
objRow[conGCVariablePrjIdRela.UpdDate] = objGCVariablePrjIdRelaEN.UpdDate; //修改日期
 }
 if (objGCVariablePrjIdRelaEN.Memo !=  "")
 {
objRow[conGCVariablePrjIdRela.Memo] = objGCVariablePrjIdRelaEN.Memo; //说明
 }
objDS.Tables[clsGCVariablePrjIdRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsGCVariablePrjIdRelaEN._CurrTabName);
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
 /// <param name = "objGCVariablePrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN)
{
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariablePrjIdRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVariablePrjIdRelaEN.VarId  ==  "")
 {
 objGCVariablePrjIdRelaEN.VarId = null;
 }
 if (objGCVariablePrjIdRelaEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.VarId);
 var strVarId = objGCVariablePrjIdRelaEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.PrjId);
 var strPrjId = objGCVariablePrjIdRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.FldId);
 var strFldId = objGCVariablePrjIdRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.UpdUser);
 var strUpdUser = objGCVariablePrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.UpdDate);
 var strUpdDate = objGCVariablePrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.Memo);
 var strMemo = objGCVariablePrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVariablePrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objGCVariablePrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN)
{
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariablePrjIdRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVariablePrjIdRelaEN.VarId  ==  "")
 {
 objGCVariablePrjIdRelaEN.VarId = null;
 }
 if (objGCVariablePrjIdRelaEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.VarId);
 var strVarId = objGCVariablePrjIdRelaEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.PrjId);
 var strPrjId = objGCVariablePrjIdRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.FldId);
 var strFldId = objGCVariablePrjIdRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.UpdUser);
 var strUpdUser = objGCVariablePrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.UpdDate);
 var strUpdDate = objGCVariablePrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.Memo);
 var strMemo = objGCVariablePrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVariablePrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objGCVariablePrjIdRelaEN.VarId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objGCVariablePrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariablePrjIdRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVariablePrjIdRelaEN.VarId  ==  "")
 {
 objGCVariablePrjIdRelaEN.VarId = null;
 }
 if (objGCVariablePrjIdRelaEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.VarId);
 var strVarId = objGCVariablePrjIdRelaEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.PrjId);
 var strPrjId = objGCVariablePrjIdRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.FldId);
 var strFldId = objGCVariablePrjIdRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.UpdUser);
 var strUpdUser = objGCVariablePrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.UpdDate);
 var strUpdDate = objGCVariablePrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.Memo);
 var strMemo = objGCVariablePrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVariablePrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objGCVariablePrjIdRelaEN.VarId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objGCVariablePrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariablePrjIdRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVariablePrjIdRelaEN.VarId  ==  "")
 {
 objGCVariablePrjIdRelaEN.VarId = null;
 }
 if (objGCVariablePrjIdRelaEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.VarId);
 var strVarId = objGCVariablePrjIdRelaEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.PrjId);
 var strPrjId = objGCVariablePrjIdRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.FldId);
 var strFldId = objGCVariablePrjIdRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.UpdUser);
 var strUpdUser = objGCVariablePrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.UpdDate);
 var strUpdDate = objGCVariablePrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVariablePrjIdRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVariablePrjIdRela.Memo);
 var strMemo = objGCVariablePrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVariablePrjIdRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewGCVariablePrjIdRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where VarId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GCVariablePrjIdRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strVarId = oRow[conGCVariablePrjIdRela.VarId].ToString().Trim();
string strPrjId = oRow[conGCVariablePrjIdRela.PrjId].ToString().Trim();
if (IsExist(strVarId,strPrjId))
{
 string strResult = "关键字变量值为:" + string.Format("VarId = {0},PrjId = {1}", strVarId,strPrjId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsGCVariablePrjIdRelaEN._CurrTabName ].NewRow();
objRow[conGCVariablePrjIdRela.VarId] = oRow[conGCVariablePrjIdRela.VarId].ToString().Trim(); //变量Id
objRow[conGCVariablePrjIdRela.PrjId] = oRow[conGCVariablePrjIdRela.PrjId].ToString().Trim(); //工程Id
objRow[conGCVariablePrjIdRela.FldId] = oRow[conGCVariablePrjIdRela.FldId].ToString().Trim(); //字段Id
objRow[conGCVariablePrjIdRela.UpdUser] = oRow[conGCVariablePrjIdRela.UpdUser].ToString().Trim(); //修改者
objRow[conGCVariablePrjIdRela.UpdDate] = oRow[conGCVariablePrjIdRela.UpdDate].ToString().Trim(); //修改日期
objRow[conGCVariablePrjIdRela.Memo] = oRow[conGCVariablePrjIdRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsGCVariablePrjIdRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsGCVariablePrjIdRelaEN._CurrTabName);
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
 /// <param name = "objGCVariablePrjIdRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN)
{
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariablePrjIdRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
strSQL = "Select * from GCVariablePrjIdRela where VarId = " + "'"+ objGCVariablePrjIdRelaEN.VarId+"'" + " and PrjId = " + "'"+ objGCVariablePrjIdRelaEN.PrjId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsGCVariablePrjIdRelaEN._CurrTabName);
if (objDS.Tables[clsGCVariablePrjIdRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:VarId = " + "'"+ objGCVariablePrjIdRelaEN.VarId+"'" + " and PrjId = " + "'"+ objGCVariablePrjIdRelaEN.PrjId+"'");
return false;
}
objRow = objDS.Tables[clsGCVariablePrjIdRelaEN._CurrTabName].Rows[0];
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.VarId))
 {
objRow[conGCVariablePrjIdRela.VarId] = objGCVariablePrjIdRelaEN.VarId; //变量Id
 }
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.PrjId))
 {
objRow[conGCVariablePrjIdRela.PrjId] = objGCVariablePrjIdRelaEN.PrjId; //工程Id
 }
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.FldId))
 {
objRow[conGCVariablePrjIdRela.FldId] = objGCVariablePrjIdRelaEN.FldId; //字段Id
 }
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdUser))
 {
objRow[conGCVariablePrjIdRela.UpdUser] = objGCVariablePrjIdRelaEN.UpdUser; //修改者
 }
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdDate))
 {
objRow[conGCVariablePrjIdRela.UpdDate] = objGCVariablePrjIdRelaEN.UpdDate; //修改日期
 }
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.Memo))
 {
objRow[conGCVariablePrjIdRela.Memo] = objGCVariablePrjIdRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsGCVariablePrjIdRelaEN._CurrTabName);
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
 /// <param name = "objGCVariablePrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN)
{
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariablePrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update GCVariablePrjIdRela Set ");
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.FldId))
 {
 if (objGCVariablePrjIdRelaEN.FldId !=  null)
 {
 var strFldId = objGCVariablePrjIdRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conGCVariablePrjIdRela.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariablePrjIdRela.FldId); //字段Id
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdUser))
 {
 if (objGCVariablePrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVariablePrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGCVariablePrjIdRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariablePrjIdRela.UpdUser); //修改者
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdDate))
 {
 if (objGCVariablePrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVariablePrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGCVariablePrjIdRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariablePrjIdRela.UpdDate); //修改日期
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.Memo))
 {
 if (objGCVariablePrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objGCVariablePrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGCVariablePrjIdRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariablePrjIdRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where VarId = '{0}' And PrjId = '{1}'", objGCVariablePrjIdRelaEN.VarId,objGCVariablePrjIdRelaEN.PrjId); 
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
 /// <param name = "objGCVariablePrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN, string strCondition)
{
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariablePrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCVariablePrjIdRela Set ");
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.FldId))
 {
 if (objGCVariablePrjIdRelaEN.FldId !=  null)
 {
 var strFldId = objGCVariablePrjIdRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdUser))
 {
 if (objGCVariablePrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVariablePrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdDate))
 {
 if (objGCVariablePrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVariablePrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.Memo))
 {
 if (objGCVariablePrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objGCVariablePrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGCVariablePrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariablePrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCVariablePrjIdRela Set ");
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.FldId))
 {
 if (objGCVariablePrjIdRelaEN.FldId !=  null)
 {
 var strFldId = objGCVariablePrjIdRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdUser))
 {
 if (objGCVariablePrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVariablePrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdDate))
 {
 if (objGCVariablePrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVariablePrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.Memo))
 {
 if (objGCVariablePrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objGCVariablePrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGCVariablePrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGCVariablePrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariablePrjIdRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariablePrjIdRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCVariablePrjIdRela Set ");
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.FldId))
 {
 if (objGCVariablePrjIdRelaEN.FldId !=  null)
 {
 var strFldId = objGCVariablePrjIdRelaEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conGCVariablePrjIdRela.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariablePrjIdRela.FldId); //字段Id
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdUser))
 {
 if (objGCVariablePrjIdRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVariablePrjIdRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGCVariablePrjIdRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariablePrjIdRela.UpdUser); //修改者
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.UpdDate))
 {
 if (objGCVariablePrjIdRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVariablePrjIdRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGCVariablePrjIdRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariablePrjIdRela.UpdDate); //修改日期
 }
 }
 
 if (objGCVariablePrjIdRelaEN.IsUpdated(conGCVariablePrjIdRela.Memo))
 {
 if (objGCVariablePrjIdRelaEN.Memo !=  null)
 {
 var strMemo = objGCVariablePrjIdRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGCVariablePrjIdRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariablePrjIdRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where VarId = '{0}' And PrjId = '{1}'", objGCVariablePrjIdRelaEN.VarId,objGCVariablePrjIdRelaEN.PrjId); 
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strVarId,string strPrjId) 
{
CheckPrimaryKey(strVarId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strVarId,
 strPrjId,
};
 objSQL.ExecSP("GCVariablePrjIdRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strVarId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strVarId,string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strVarId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
//删除GCVariablePrjIdRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCVariablePrjIdRela where VarId = " + "'"+ strVarId+"'" + " and PrjId = " + "'"+ strPrjId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count  == 0) return 0;
int intCount = 0;
foreach (var strKeyLst in arrKeyLsts)
{
string[] sstrKey = strKeyLst.Split('|');
string strVarId = sstrKey[0];
string strPrjId = sstrKey[1];
 int intRecNum  = this.DelRecord(strVarId,strPrjId);
 intCount += intRecNum;
}
 return intCount;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strVarId">给定的关键字值</param>
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strVarId,string strPrjId) 
{
CheckPrimaryKey(strVarId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
//删除GCVariablePrjIdRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCVariablePrjIdRela where VarId = " + "'"+ strVarId+"'" + " and PrjId = " + "'"+ strPrjId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelGCVariablePrjIdRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: DelGCVariablePrjIdRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GCVariablePrjIdRela where " + strCondition ;
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
public bool DelGCVariablePrjIdRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsGCVariablePrjIdRelaDA: DelGCVariablePrjIdRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GCVariablePrjIdRela where " + strCondition ;
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
 /// <param name = "objGCVariablePrjIdRelaENS">源对象</param>
 /// <param name = "objGCVariablePrjIdRelaENT">目标对象</param>
public void CopyTo(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaENS, clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaENT)
{
objGCVariablePrjIdRelaENT.VarId = objGCVariablePrjIdRelaENS.VarId; //变量Id
objGCVariablePrjIdRelaENT.PrjId = objGCVariablePrjIdRelaENS.PrjId; //工程Id
objGCVariablePrjIdRelaENT.FldId = objGCVariablePrjIdRelaENS.FldId; //字段Id
objGCVariablePrjIdRelaENT.UpdUser = objGCVariablePrjIdRelaENS.UpdUser; //修改者
objGCVariablePrjIdRelaENT.UpdDate = objGCVariablePrjIdRelaENS.UpdDate; //修改日期
objGCVariablePrjIdRelaENT.Memo = objGCVariablePrjIdRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.VarId, 8, conGCVariablePrjIdRela.VarId);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.PrjId, 4, conGCVariablePrjIdRela.PrjId);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.FldId, 8, conGCVariablePrjIdRela.FldId);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.UpdUser, 20, conGCVariablePrjIdRela.UpdUser);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.UpdDate, 20, conGCVariablePrjIdRela.UpdDate);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.Memo, 1000, conGCVariablePrjIdRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objGCVariablePrjIdRelaEN.VarId, 8, conGCVariablePrjIdRela.VarId);
 objGCVariablePrjIdRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.FldId, 8, conGCVariablePrjIdRela.FldId);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.UpdUser, 20, conGCVariablePrjIdRela.UpdUser);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.UpdDate, 20, conGCVariablePrjIdRela.UpdDate);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.Memo, 1000, conGCVariablePrjIdRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objGCVariablePrjIdRelaEN.VarId, 8, conGCVariablePrjIdRela.VarId);
 objGCVariablePrjIdRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsGCVariablePrjIdRelaEN objGCVariablePrjIdRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.VarId, 8, conGCVariablePrjIdRela.VarId);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.PrjId, 4, conGCVariablePrjIdRela.PrjId);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.FldId, 8, conGCVariablePrjIdRela.FldId);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.UpdUser, 20, conGCVariablePrjIdRela.UpdUser);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.UpdDate, 20, conGCVariablePrjIdRela.UpdDate);
clsCheckSql.CheckFieldLen(objGCVariablePrjIdRelaEN.Memo, 1000, conGCVariablePrjIdRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objGCVariablePrjIdRelaEN.VarId, conGCVariablePrjIdRela.VarId);
clsCheckSql.CheckSqlInjection4Field(objGCVariablePrjIdRelaEN.PrjId, conGCVariablePrjIdRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objGCVariablePrjIdRelaEN.FldId, conGCVariablePrjIdRela.FldId);
clsCheckSql.CheckSqlInjection4Field(objGCVariablePrjIdRelaEN.UpdUser, conGCVariablePrjIdRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objGCVariablePrjIdRelaEN.UpdDate, conGCVariablePrjIdRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objGCVariablePrjIdRelaEN.Memo, conGCVariablePrjIdRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objGCVariablePrjIdRelaEN.VarId, 8, conGCVariablePrjIdRela.VarId);
 objGCVariablePrjIdRelaEN._IsCheckProperty = true;
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
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
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
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
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
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGCVariablePrjIdRelaEN._CurrTabName);
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
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGCVariablePrjIdRelaEN._CurrTabName, strCondition);
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
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
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
 objSQL = clsGCVariablePrjIdRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}