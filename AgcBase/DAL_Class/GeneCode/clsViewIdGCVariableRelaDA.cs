
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewIdGCVariableRelaDA
 表名:ViewIdGCVariableRela(00050631)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:24:21
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
 /// 界面变量关系(ViewIdGCVariableRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewIdGCVariableRelaDA : clsCommBase4DA
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
 return clsViewIdGCVariableRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewIdGCVariableRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewIdGCVariableRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewIdGCVariableRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewIdGCVariableRelaEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:ViewIdGCVariableRela中,检查关键字,长度不正确!(clsViewIdGCVariableRelaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strVarId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ViewIdGCVariableRela中,关键字不能为空 或 null!(clsViewIdGCVariableRelaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strVarId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsViewIdGCVariableRelaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewIdGCVariableRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetDataTable_ViewIdGCVariableRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewIdGCVariableRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewIdGCVariableRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewIdGCVariableRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewIdGCVariableRela.* " + 
$"from ViewIdGCVariableRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewIdGCVariableRela.VarId not in " + 
$"(Select top {intTop_In} ViewIdGCVariableRela.VarId from ViewIdGCVariableRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewIdGCVariableRela where {1} and VarId not in (Select top {2} VarId from ViewIdGCVariableRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewIdGCVariableRela where {1} and VarId not in (Select top {3} VarId from ViewIdGCVariableRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewIdGCVariableRela.* " + 
$"from ViewIdGCVariableRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewIdGCVariableRela.VarId not in " + 
$"(Select top {intTop_In} ViewIdGCVariableRela.VarId from ViewIdGCVariableRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewIdGCVariableRela where {1} and VarId not in (Select top {2} VarId from ViewIdGCVariableRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewIdGCVariableRela where {1} and VarId not in (Select top {3} VarId from ViewIdGCVariableRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewIdGCVariableRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA:GetObjLst)", objException.Message));
}
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = TransNullToBool(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewIdGCVariableRelaDA: GetObjLst)", objException.Message));
}
objViewIdGCVariableRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewIdGCVariableRelaEN);
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
public List<clsViewIdGCVariableRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = TransNullToBool(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewIdGCVariableRelaDA: GetObjLst)", objException.Message));
}
objViewIdGCVariableRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewIdGCVariableRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewIdGCVariableRela(ref clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where VarId = " + "'"+ objViewIdGCVariableRelaEN.VarId+"'" + " and ViewId = " + "'"+ objViewIdGCVariableRelaEN.ViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewIdGCVariableRelaEN.IsUseInRegion = TransNullToBool(objDT.Rows[0][conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用(字段类型:bit,字段长度:1,是否可空:True)
 objViewIdGCVariableRelaEN.VarId = objDT.Rows[0][conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objViewIdGCVariableRelaEN.ViewId = objDT.Rows[0][conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewIdGCVariableRelaEN.RetrievalMethodId = objDT.Rows[0][conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id(字段类型:char,字段长度:2,是否可空:False)
 objViewIdGCVariableRelaEN.RegionTypeNames = objDT.Rows[0][conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s(字段类型:varchar,字段长度:100,是否可空:True)
 objViewIdGCVariableRelaEN.ErrMsg = objDT.Rows[0][conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objViewIdGCVariableRelaEN.PrjId = objDT.Rows[0][conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewIdGCVariableRelaEN.UpdUser = objDT.Rows[0][conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewIdGCVariableRelaEN.UpdDate = objDT.Rows[0][conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewIdGCVariableRelaEN.Memo = objDT.Rows[0][conViewIdGCVariableRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewIdGCVariableRelaDA: GetViewIdGCVariableRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewIdGCVariableRelaEN GetObjByKeyLst(string strVarId,string strViewId)
{
CheckPrimaryKey(strVarId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where VarId = " + "'"+ strVarId+"'" + " and ViewId = " + "'"+ strViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
 objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用(字段类型:bit,字段长度:1,是否可空:True)
 objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id(字段类型:char,字段长度:2,是否可空:False)
 objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s(字段类型:varchar,字段长度:100,是否可空:True)
 objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewIdGCVariableRelaDA: GetObjByKeyLst)", objException.Message));
}
return objViewIdGCVariableRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewIdGCVariableRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN()
{
IsUseInRegion = TransNullToBool(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()), //是否在区域中使用
VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(), //变量Id
ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(), //界面Id
RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(), //获取方式Id
RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(), //区域类型名s
ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim() //说明
};
objViewIdGCVariableRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewIdGCVariableRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewIdGCVariableRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewIdGCVariableRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = TransNullToBool(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewIdGCVariableRelaDA: GetObjByDataRowViewIdGCVariableRela)", objException.Message));
}
objViewIdGCVariableRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewIdGCVariableRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewIdGCVariableRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = TransNullToBool(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewIdGCVariableRelaDA: GetObjByDataRow)", objException.Message));
}
objViewIdGCVariableRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewIdGCVariableRelaEN;
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
objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewIdGCVariableRelaEN._CurrTabName, conViewIdGCVariableRela.VarId, 8, "");
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
objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewIdGCVariableRelaEN._CurrTabName, conViewIdGCVariableRela.VarId, 8, strPrefix);
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
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select VarId,ViewId from ViewIdGCVariableRela where " + strCondition;
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
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select VarId,ViewId from ViewIdGCVariableRela where " + strCondition;
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
public bool IsExist(string strVarId, string strViewId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewIdGCVariableRela", "VarId = " + "'"+ strVarId+"'" + " and ViewId = " + "'"+ strViewId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewIdGCVariableRela", strCondition))
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
objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewIdGCVariableRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
 {
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewIdGCVariableRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewIdGCVariableRela");
objRow = objDS.Tables["ViewIdGCVariableRela"].NewRow();
objRow[conViewIdGCVariableRela.IsUseInRegion] = objViewIdGCVariableRelaEN.IsUseInRegion; //是否在区域中使用
objRow[conViewIdGCVariableRela.VarId] = objViewIdGCVariableRelaEN.VarId; //变量Id
objRow[conViewIdGCVariableRela.ViewId] = objViewIdGCVariableRelaEN.ViewId; //界面Id
objRow[conViewIdGCVariableRela.RetrievalMethodId] = objViewIdGCVariableRelaEN.RetrievalMethodId; //获取方式Id
 if (objViewIdGCVariableRelaEN.RegionTypeNames !=  "")
 {
objRow[conViewIdGCVariableRela.RegionTypeNames] = objViewIdGCVariableRelaEN.RegionTypeNames; //区域类型名s
 }
 if (objViewIdGCVariableRelaEN.ErrMsg !=  "")
 {
objRow[conViewIdGCVariableRela.ErrMsg] = objViewIdGCVariableRelaEN.ErrMsg; //错误信息
 }
objRow[conViewIdGCVariableRela.PrjId] = objViewIdGCVariableRelaEN.PrjId; //工程Id
 if (objViewIdGCVariableRelaEN.UpdUser !=  "")
 {
objRow[conViewIdGCVariableRela.UpdUser] = objViewIdGCVariableRelaEN.UpdUser; //修改者
 }
 if (objViewIdGCVariableRelaEN.UpdDate !=  "")
 {
objRow[conViewIdGCVariableRela.UpdDate] = objViewIdGCVariableRelaEN.UpdDate; //修改日期
 }
 if (objViewIdGCVariableRelaEN.Memo !=  "")
 {
objRow[conViewIdGCVariableRela.Memo] = objViewIdGCVariableRelaEN.Memo; //说明
 }
objDS.Tables[clsViewIdGCVariableRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewIdGCVariableRelaEN._CurrTabName);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewIdGCVariableRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conViewIdGCVariableRela.IsUseInRegion);
 arrValueListForInsert.Add("'" + (objViewIdGCVariableRelaEN.IsUseInRegion  ==  false ? "0" : "1") + "'");
 
 if (objViewIdGCVariableRelaEN.VarId  ==  "")
 {
 objViewIdGCVariableRelaEN.VarId = null;
 }
 if (objViewIdGCVariableRelaEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.VarId);
 var strVarId = objViewIdGCVariableRelaEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.ViewId);
 var strViewId = objViewIdGCVariableRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.RetrievalMethodId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.RetrievalMethodId);
 var strRetrievalMethodId = objViewIdGCVariableRelaEN.RetrievalMethodId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRetrievalMethodId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.RegionTypeNames !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.RegionTypeNames);
 var strRegionTypeNames = objViewIdGCVariableRelaEN.RegionTypeNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeNames + "'");
 }
 
 if (objViewIdGCVariableRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.ErrMsg);
 var strErrMsg = objViewIdGCVariableRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewIdGCVariableRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.PrjId);
 var strPrjId = objViewIdGCVariableRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.UpdUser);
 var strUpdUser = objViewIdGCVariableRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewIdGCVariableRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.UpdDate);
 var strUpdDate = objViewIdGCVariableRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewIdGCVariableRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.Memo);
 var strMemo = objViewIdGCVariableRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewIdGCVariableRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewIdGCVariableRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conViewIdGCVariableRela.IsUseInRegion);
 arrValueListForInsert.Add("'" + (objViewIdGCVariableRelaEN.IsUseInRegion  ==  false ? "0" : "1") + "'");
 
 if (objViewIdGCVariableRelaEN.VarId  ==  "")
 {
 objViewIdGCVariableRelaEN.VarId = null;
 }
 if (objViewIdGCVariableRelaEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.VarId);
 var strVarId = objViewIdGCVariableRelaEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.ViewId);
 var strViewId = objViewIdGCVariableRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.RetrievalMethodId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.RetrievalMethodId);
 var strRetrievalMethodId = objViewIdGCVariableRelaEN.RetrievalMethodId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRetrievalMethodId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.RegionTypeNames !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.RegionTypeNames);
 var strRegionTypeNames = objViewIdGCVariableRelaEN.RegionTypeNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeNames + "'");
 }
 
 if (objViewIdGCVariableRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.ErrMsg);
 var strErrMsg = objViewIdGCVariableRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewIdGCVariableRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.PrjId);
 var strPrjId = objViewIdGCVariableRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.UpdUser);
 var strUpdUser = objViewIdGCVariableRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewIdGCVariableRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.UpdDate);
 var strUpdDate = objViewIdGCVariableRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewIdGCVariableRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.Memo);
 var strMemo = objViewIdGCVariableRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewIdGCVariableRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objViewIdGCVariableRelaEN.VarId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewIdGCVariableRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conViewIdGCVariableRela.IsUseInRegion);
 arrValueListForInsert.Add("'" + (objViewIdGCVariableRelaEN.IsUseInRegion  ==  false ? "0" : "1") + "'");
 
 if (objViewIdGCVariableRelaEN.VarId  ==  "")
 {
 objViewIdGCVariableRelaEN.VarId = null;
 }
 if (objViewIdGCVariableRelaEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.VarId);
 var strVarId = objViewIdGCVariableRelaEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.ViewId);
 var strViewId = objViewIdGCVariableRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.RetrievalMethodId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.RetrievalMethodId);
 var strRetrievalMethodId = objViewIdGCVariableRelaEN.RetrievalMethodId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRetrievalMethodId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.RegionTypeNames !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.RegionTypeNames);
 var strRegionTypeNames = objViewIdGCVariableRelaEN.RegionTypeNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeNames + "'");
 }
 
 if (objViewIdGCVariableRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.ErrMsg);
 var strErrMsg = objViewIdGCVariableRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewIdGCVariableRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.PrjId);
 var strPrjId = objViewIdGCVariableRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.UpdUser);
 var strUpdUser = objViewIdGCVariableRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewIdGCVariableRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.UpdDate);
 var strUpdDate = objViewIdGCVariableRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewIdGCVariableRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.Memo);
 var strMemo = objViewIdGCVariableRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewIdGCVariableRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objViewIdGCVariableRelaEN.VarId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewIdGCVariableRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conViewIdGCVariableRela.IsUseInRegion);
 arrValueListForInsert.Add("'" + (objViewIdGCVariableRelaEN.IsUseInRegion  ==  false ? "0" : "1") + "'");
 
 if (objViewIdGCVariableRelaEN.VarId  ==  "")
 {
 objViewIdGCVariableRelaEN.VarId = null;
 }
 if (objViewIdGCVariableRelaEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.VarId);
 var strVarId = objViewIdGCVariableRelaEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.ViewId);
 var strViewId = objViewIdGCVariableRelaEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.RetrievalMethodId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.RetrievalMethodId);
 var strRetrievalMethodId = objViewIdGCVariableRelaEN.RetrievalMethodId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRetrievalMethodId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.RegionTypeNames !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.RegionTypeNames);
 var strRegionTypeNames = objViewIdGCVariableRelaEN.RegionTypeNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeNames + "'");
 }
 
 if (objViewIdGCVariableRelaEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.ErrMsg);
 var strErrMsg = objViewIdGCVariableRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewIdGCVariableRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.PrjId);
 var strPrjId = objViewIdGCVariableRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewIdGCVariableRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.UpdUser);
 var strUpdUser = objViewIdGCVariableRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewIdGCVariableRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.UpdDate);
 var strUpdDate = objViewIdGCVariableRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewIdGCVariableRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewIdGCVariableRela.Memo);
 var strMemo = objViewIdGCVariableRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewIdGCVariableRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewIdGCVariableRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where VarId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewIdGCVariableRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strVarId = oRow[conViewIdGCVariableRela.VarId].ToString().Trim();
string strViewId = oRow[conViewIdGCVariableRela.ViewId].ToString().Trim();
if (IsExist(strVarId,strViewId))
{
 string strResult = "关键字变量值为:" + string.Format("VarId = {0},ViewId = {1}", strVarId,strViewId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewIdGCVariableRelaEN._CurrTabName ].NewRow();
objRow[conViewIdGCVariableRela.IsUseInRegion] = oRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim(); //是否在区域中使用
objRow[conViewIdGCVariableRela.VarId] = oRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objRow[conViewIdGCVariableRela.ViewId] = oRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objRow[conViewIdGCVariableRela.RetrievalMethodId] = oRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRow[conViewIdGCVariableRela.RegionTypeNames] = oRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objRow[conViewIdGCVariableRela.ErrMsg] = oRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objRow[conViewIdGCVariableRela.PrjId] = oRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objRow[conViewIdGCVariableRela.UpdUser] = oRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objRow[conViewIdGCVariableRela.UpdDate] = oRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objRow[conViewIdGCVariableRela.Memo] = oRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsViewIdGCVariableRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewIdGCVariableRelaEN._CurrTabName);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewIdGCVariableRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
strSQL = "Select * from ViewIdGCVariableRela where VarId = " + "'"+ objViewIdGCVariableRelaEN.VarId+"'" + " and ViewId = " + "'"+ objViewIdGCVariableRelaEN.ViewId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewIdGCVariableRelaEN._CurrTabName);
if (objDS.Tables[clsViewIdGCVariableRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:VarId = " + "'"+ objViewIdGCVariableRelaEN.VarId+"'" + " and ViewId = " + "'"+ objViewIdGCVariableRelaEN.ViewId+"'");
return false;
}
objRow = objDS.Tables[clsViewIdGCVariableRelaEN._CurrTabName].Rows[0];
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.IsUseInRegion))
 {
objRow[conViewIdGCVariableRela.IsUseInRegion] = objViewIdGCVariableRelaEN.IsUseInRegion; //是否在区域中使用
 }
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.VarId))
 {
objRow[conViewIdGCVariableRela.VarId] = objViewIdGCVariableRelaEN.VarId; //变量Id
 }
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.ViewId))
 {
objRow[conViewIdGCVariableRela.ViewId] = objViewIdGCVariableRelaEN.ViewId; //界面Id
 }
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RetrievalMethodId))
 {
objRow[conViewIdGCVariableRela.RetrievalMethodId] = objViewIdGCVariableRelaEN.RetrievalMethodId; //获取方式Id
 }
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RegionTypeNames))
 {
objRow[conViewIdGCVariableRela.RegionTypeNames] = objViewIdGCVariableRelaEN.RegionTypeNames; //区域类型名s
 }
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.ErrMsg))
 {
objRow[conViewIdGCVariableRela.ErrMsg] = objViewIdGCVariableRelaEN.ErrMsg; //错误信息
 }
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.PrjId))
 {
objRow[conViewIdGCVariableRela.PrjId] = objViewIdGCVariableRelaEN.PrjId; //工程Id
 }
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdUser))
 {
objRow[conViewIdGCVariableRela.UpdUser] = objViewIdGCVariableRelaEN.UpdUser; //修改者
 }
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdDate))
 {
objRow[conViewIdGCVariableRela.UpdDate] = objViewIdGCVariableRelaEN.UpdDate; //修改日期
 }
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.Memo))
 {
objRow[conViewIdGCVariableRela.Memo] = objViewIdGCVariableRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsViewIdGCVariableRelaEN._CurrTabName);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewIdGCVariableRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewIdGCVariableRela Set ");
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.IsUseInRegion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewIdGCVariableRelaEN.IsUseInRegion == true?"1":"0", conViewIdGCVariableRela.IsUseInRegion); //是否在区域中使用
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RetrievalMethodId))
 {
 if (objViewIdGCVariableRelaEN.RetrievalMethodId !=  null)
 {
 var strRetrievalMethodId = objViewIdGCVariableRelaEN.RetrievalMethodId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRetrievalMethodId, conViewIdGCVariableRela.RetrievalMethodId); //获取方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.RetrievalMethodId); //获取方式Id
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RegionTypeNames))
 {
 if (objViewIdGCVariableRelaEN.RegionTypeNames !=  null)
 {
 var strRegionTypeNames = objViewIdGCVariableRelaEN.RegionTypeNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionTypeNames, conViewIdGCVariableRela.RegionTypeNames); //区域类型名s
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.RegionTypeNames); //区域类型名s
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.ErrMsg))
 {
 if (objViewIdGCVariableRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewIdGCVariableRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conViewIdGCVariableRela.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.ErrMsg); //错误信息
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.PrjId))
 {
 if (objViewIdGCVariableRelaEN.PrjId !=  null)
 {
 var strPrjId = objViewIdGCVariableRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewIdGCVariableRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.PrjId); //工程Id
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdUser))
 {
 if (objViewIdGCVariableRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewIdGCVariableRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewIdGCVariableRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.UpdUser); //修改者
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdDate))
 {
 if (objViewIdGCVariableRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewIdGCVariableRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewIdGCVariableRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.UpdDate); //修改日期
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.Memo))
 {
 if (objViewIdGCVariableRelaEN.Memo !=  null)
 {
 var strMemo = objViewIdGCVariableRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewIdGCVariableRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where VarId = '{0}' And ViewId = '{1}'", objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId); 
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
 /// <param name = "objViewIdGCVariableRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strCondition)
{
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewIdGCVariableRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewIdGCVariableRela Set ");
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.IsUseInRegion))
 {
 sbSQL.AppendFormat(" IsUseInRegion = '{0}',", objViewIdGCVariableRelaEN.IsUseInRegion == true?"1":"0"); //是否在区域中使用
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RetrievalMethodId))
 {
 if (objViewIdGCVariableRelaEN.RetrievalMethodId !=  null)
 {
 var strRetrievalMethodId = objViewIdGCVariableRelaEN.RetrievalMethodId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RetrievalMethodId = '{0}',", strRetrievalMethodId); //获取方式Id
 }
 else
 {
 sbSQL.Append(" RetrievalMethodId = null,"); //获取方式Id
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RegionTypeNames))
 {
 if (objViewIdGCVariableRelaEN.RegionTypeNames !=  null)
 {
 var strRegionTypeNames = objViewIdGCVariableRelaEN.RegionTypeNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionTypeNames = '{0}',", strRegionTypeNames); //区域类型名s
 }
 else
 {
 sbSQL.Append(" RegionTypeNames = null,"); //区域类型名s
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.ErrMsg))
 {
 if (objViewIdGCVariableRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewIdGCVariableRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.PrjId))
 {
 if (objViewIdGCVariableRelaEN.PrjId !=  null)
 {
 var strPrjId = objViewIdGCVariableRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdUser))
 {
 if (objViewIdGCVariableRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewIdGCVariableRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdDate))
 {
 if (objViewIdGCVariableRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewIdGCVariableRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.Memo))
 {
 if (objViewIdGCVariableRelaEN.Memo !=  null)
 {
 var strMemo = objViewIdGCVariableRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewIdGCVariableRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewIdGCVariableRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewIdGCVariableRela Set ");
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.IsUseInRegion))
 {
 sbSQL.AppendFormat(" IsUseInRegion = '{0}',", objViewIdGCVariableRelaEN.IsUseInRegion == true?"1":"0"); //是否在区域中使用
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RetrievalMethodId))
 {
 if (objViewIdGCVariableRelaEN.RetrievalMethodId !=  null)
 {
 var strRetrievalMethodId = objViewIdGCVariableRelaEN.RetrievalMethodId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RetrievalMethodId = '{0}',", strRetrievalMethodId); //获取方式Id
 }
 else
 {
 sbSQL.Append(" RetrievalMethodId = null,"); //获取方式Id
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RegionTypeNames))
 {
 if (objViewIdGCVariableRelaEN.RegionTypeNames !=  null)
 {
 var strRegionTypeNames = objViewIdGCVariableRelaEN.RegionTypeNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionTypeNames = '{0}',", strRegionTypeNames); //区域类型名s
 }
 else
 {
 sbSQL.Append(" RegionTypeNames = null,"); //区域类型名s
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.ErrMsg))
 {
 if (objViewIdGCVariableRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewIdGCVariableRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.PrjId))
 {
 if (objViewIdGCVariableRelaEN.PrjId !=  null)
 {
 var strPrjId = objViewIdGCVariableRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdUser))
 {
 if (objViewIdGCVariableRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewIdGCVariableRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdDate))
 {
 if (objViewIdGCVariableRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewIdGCVariableRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.Memo))
 {
 if (objViewIdGCVariableRelaEN.Memo !=  null)
 {
 var strMemo = objViewIdGCVariableRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewIdGCVariableRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewIdGCVariableRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewIdGCVariableRela Set ");
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.IsUseInRegion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewIdGCVariableRelaEN.IsUseInRegion == true?"1":"0", conViewIdGCVariableRela.IsUseInRegion); //是否在区域中使用
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RetrievalMethodId))
 {
 if (objViewIdGCVariableRelaEN.RetrievalMethodId !=  null)
 {
 var strRetrievalMethodId = objViewIdGCVariableRelaEN.RetrievalMethodId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRetrievalMethodId, conViewIdGCVariableRela.RetrievalMethodId); //获取方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.RetrievalMethodId); //获取方式Id
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.RegionTypeNames))
 {
 if (objViewIdGCVariableRelaEN.RegionTypeNames !=  null)
 {
 var strRegionTypeNames = objViewIdGCVariableRelaEN.RegionTypeNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionTypeNames, conViewIdGCVariableRela.RegionTypeNames); //区域类型名s
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.RegionTypeNames); //区域类型名s
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.ErrMsg))
 {
 if (objViewIdGCVariableRelaEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewIdGCVariableRelaEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conViewIdGCVariableRela.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.ErrMsg); //错误信息
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.PrjId))
 {
 if (objViewIdGCVariableRelaEN.PrjId !=  null)
 {
 var strPrjId = objViewIdGCVariableRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewIdGCVariableRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.PrjId); //工程Id
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdUser))
 {
 if (objViewIdGCVariableRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objViewIdGCVariableRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewIdGCVariableRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.UpdUser); //修改者
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.UpdDate))
 {
 if (objViewIdGCVariableRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objViewIdGCVariableRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewIdGCVariableRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.UpdDate); //修改日期
 }
 }
 
 if (objViewIdGCVariableRelaEN.IsUpdated(conViewIdGCVariableRela.Memo))
 {
 if (objViewIdGCVariableRelaEN.Memo !=  null)
 {
 var strMemo = objViewIdGCVariableRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewIdGCVariableRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewIdGCVariableRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where VarId = '{0}' And ViewId = '{1}'", objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId); 
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
public bool DelRecordBySP(string strVarId,string strViewId) 
{
CheckPrimaryKey(strVarId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strVarId,
 strViewId,
};
 objSQL.ExecSP("ViewIdGCVariableRela_Delete", values);
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
public bool DelRecord(string strVarId,string strViewId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strVarId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
//删除ViewIdGCVariableRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewIdGCVariableRela where VarId = " + "'"+ strVarId+"'" + " and ViewId = " + "'"+ strViewId+"'";
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
string strViewId = sstrKey[1];
 int intRecNum  = this.DelRecord(strVarId,strViewId);
 intCount += intRecNum;
}
 return intCount;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strVarId">给定的关键字值</param>
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strVarId,string strViewId) 
{
CheckPrimaryKey(strVarId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
//删除ViewIdGCVariableRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewIdGCVariableRela where VarId = " + "'"+ strVarId+"'" + " and ViewId = " + "'"+ strViewId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewIdGCVariableRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: DelViewIdGCVariableRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewIdGCVariableRela where " + strCondition ;
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
public bool DelViewIdGCVariableRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewIdGCVariableRelaDA: DelViewIdGCVariableRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewIdGCVariableRela where " + strCondition ;
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
 /// <param name = "objViewIdGCVariableRelaENS">源对象</param>
 /// <param name = "objViewIdGCVariableRelaENT">目标对象</param>
public void CopyTo(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENS, clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENT)
{
objViewIdGCVariableRelaENT.IsUseInRegion = objViewIdGCVariableRelaENS.IsUseInRegion; //是否在区域中使用
objViewIdGCVariableRelaENT.VarId = objViewIdGCVariableRelaENS.VarId; //变量Id
objViewIdGCVariableRelaENT.ViewId = objViewIdGCVariableRelaENS.ViewId; //界面Id
objViewIdGCVariableRelaENT.RetrievalMethodId = objViewIdGCVariableRelaENS.RetrievalMethodId; //获取方式Id
objViewIdGCVariableRelaENT.RegionTypeNames = objViewIdGCVariableRelaENS.RegionTypeNames; //区域类型名s
objViewIdGCVariableRelaENT.ErrMsg = objViewIdGCVariableRelaENS.ErrMsg; //错误信息
objViewIdGCVariableRelaENT.PrjId = objViewIdGCVariableRelaENS.PrjId; //工程Id
objViewIdGCVariableRelaENT.UpdUser = objViewIdGCVariableRelaENS.UpdUser; //修改者
objViewIdGCVariableRelaENT.UpdDate = objViewIdGCVariableRelaENS.UpdDate; //修改日期
objViewIdGCVariableRelaENT.Memo = objViewIdGCVariableRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewIdGCVariableRelaEN.RetrievalMethodId, conViewIdGCVariableRela.RetrievalMethodId);
clsCheckSql.CheckFieldNotNull(objViewIdGCVariableRelaEN.PrjId, conViewIdGCVariableRela.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.VarId, 8, conViewIdGCVariableRela.VarId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.ViewId, 8, conViewIdGCVariableRela.ViewId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.RetrievalMethodId, 2, conViewIdGCVariableRela.RetrievalMethodId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.RegionTypeNames, 100, conViewIdGCVariableRela.RegionTypeNames);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.ErrMsg, 2000, conViewIdGCVariableRela.ErrMsg);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.PrjId, 4, conViewIdGCVariableRela.PrjId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.UpdUser, 20, conViewIdGCVariableRela.UpdUser);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.UpdDate, 20, conViewIdGCVariableRela.UpdDate);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.Memo, 1000, conViewIdGCVariableRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objViewIdGCVariableRelaEN.VarId, 8, conViewIdGCVariableRela.VarId);
 objViewIdGCVariableRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.RetrievalMethodId, 2, conViewIdGCVariableRela.RetrievalMethodId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.RegionTypeNames, 100, conViewIdGCVariableRela.RegionTypeNames);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.ErrMsg, 2000, conViewIdGCVariableRela.ErrMsg);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.PrjId, 4, conViewIdGCVariableRela.PrjId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.UpdUser, 20, conViewIdGCVariableRela.UpdUser);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.UpdDate, 20, conViewIdGCVariableRela.UpdDate);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.Memo, 1000, conViewIdGCVariableRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewIdGCVariableRelaEN.VarId, 8, conViewIdGCVariableRela.VarId);
 objViewIdGCVariableRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.VarId, 8, conViewIdGCVariableRela.VarId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.ViewId, 8, conViewIdGCVariableRela.ViewId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.RetrievalMethodId, 2, conViewIdGCVariableRela.RetrievalMethodId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.RegionTypeNames, 100, conViewIdGCVariableRela.RegionTypeNames);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.ErrMsg, 2000, conViewIdGCVariableRela.ErrMsg);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.PrjId, 4, conViewIdGCVariableRela.PrjId);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.UpdUser, 20, conViewIdGCVariableRela.UpdUser);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.UpdDate, 20, conViewIdGCVariableRela.UpdDate);
clsCheckSql.CheckFieldLen(objViewIdGCVariableRelaEN.Memo, 1000, conViewIdGCVariableRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewIdGCVariableRelaEN.VarId, conViewIdGCVariableRela.VarId);
clsCheckSql.CheckSqlInjection4Field(objViewIdGCVariableRelaEN.ViewId, conViewIdGCVariableRela.ViewId);
clsCheckSql.CheckSqlInjection4Field(objViewIdGCVariableRelaEN.RetrievalMethodId, conViewIdGCVariableRela.RetrievalMethodId);
clsCheckSql.CheckSqlInjection4Field(objViewIdGCVariableRelaEN.RegionTypeNames, conViewIdGCVariableRela.RegionTypeNames);
clsCheckSql.CheckSqlInjection4Field(objViewIdGCVariableRelaEN.ErrMsg, conViewIdGCVariableRela.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objViewIdGCVariableRelaEN.PrjId, conViewIdGCVariableRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objViewIdGCVariableRelaEN.UpdUser, conViewIdGCVariableRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objViewIdGCVariableRelaEN.UpdDate, conViewIdGCVariableRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewIdGCVariableRelaEN.Memo, conViewIdGCVariableRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewIdGCVariableRelaEN.VarId, 8, conViewIdGCVariableRela.VarId);
 objViewIdGCVariableRelaEN._IsCheckProperty = true;
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
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
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
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
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
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewIdGCVariableRelaEN._CurrTabName);
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
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewIdGCVariableRelaEN._CurrTabName, strCondition);
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
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
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
 objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}