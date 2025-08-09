
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCmProjectPrjTabDA
 表名:vCmProjectPrjTab(00050531)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// vCmProjectPrjTab(vCmProjectPrjTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCmProjectPrjTabDA : clsCommBase4DA
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
 return clsvCmProjectPrjTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCmProjectPrjTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCmProjectPrjTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCmProjectPrjTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCmProjectPrjTabEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCmProjectPrjTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetDataTable_vCmProjectPrjTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectPrjTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectPrjTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCmProjectPrjTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCmProjectPrjTab.* " + 
$"from vCmProjectPrjTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCmProjectPrjTab.mId not in " + 
$"(Select top {intTop_In} vCmProjectPrjTab.mId from vCmProjectPrjTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectPrjTab where {1} and mId not in (Select top {2} mId from vCmProjectPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectPrjTab where {1} and mId not in (Select top {3} mId from vCmProjectPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCmProjectPrjTab.* " + 
$"from vCmProjectPrjTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCmProjectPrjTab.mId not in " + 
$"(Select top {intTop_In} vCmProjectPrjTab.mId from vCmProjectPrjTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectPrjTab where {1} and mId not in (Select top {2} mId from vCmProjectPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCmProjectPrjTab where {1} and mId not in (Select top {3} mId from vCmProjectPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCmProjectPrjTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA:GetObjLst)", objException.Message));
}
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = TransNullToInt(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = TransNullToInt(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCmProjectPrjTabDA: GetObjLst)", objException.Message));
}
objvCmProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCmProjectPrjTabEN);
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
public List<clsvCmProjectPrjTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = TransNullToInt(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = TransNullToInt(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCmProjectPrjTabDA: GetObjLst)", objException.Message));
}
objvCmProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCmProjectPrjTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCmProjectPrjTab(ref clsvCmProjectPrjTabEN objvCmProjectPrjTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectPrjTab where mId = " + ""+ objvCmProjectPrjTabEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCmProjectPrjTabEN.mId = TransNullToInt(objDT.Rows[0][convCmProjectPrjTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCmProjectPrjTabEN.CmPrjId = objDT.Rows[0][convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCmProjectPrjTabEN.CmPrjName = objDT.Rows[0][convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCmProjectPrjTabEN.PrjId = objDT.Rows[0][convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCmProjectPrjTabEN.TabId = objDT.Rows[0][convCmProjectPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvCmProjectPrjTabEN.TabName = objDT.Rows[0][convCmProjectPrjTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCmProjectPrjTabEN.FuncModuleAgcId = objDT.Rows[0][convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCmProjectPrjTabEN.FuncModuleName = objDT.Rows[0][convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCmProjectPrjTabEN.OrderNum = TransNullToInt(objDT.Rows[0][convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCmProjectPrjTabEN.UpdDate = objDT.Rows[0][convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCmProjectPrjTabEN.UpdUser = objDT.Rows[0][convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCmProjectPrjTabEN.Memo = objDT.Rows[0][convCmProjectPrjTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCmProjectPrjTabEN.SqlDsTypeId = objDT.Rows[0][convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCmProjectPrjTabEN.SqlDsTypeName = objDT.Rows[0][convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvCmProjectPrjTabEN.TabRecNum = TransNullToInt(objDT.Rows[0][convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数(字段类型:int,字段长度:4,是否可空:True)
 objvCmProjectPrjTabEN.TabTypeId = objDT.Rows[0][convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCmProjectPrjTabEN.TabStateId = objDT.Rows[0][convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCmProjectPrjTabDA: GetvCmProjectPrjTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCmProjectPrjTabEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectPrjTab where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
 objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数(字段类型:int,字段长度:4,是否可空:True)
 objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCmProjectPrjTabDA: GetObjBymId)", objException.Message));
}
return objvCmProjectPrjTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCmProjectPrjTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCmProjectPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN()
{
mId = TransNullToInt(objRow[convCmProjectPrjTab.mId].ToString().Trim()), //mId
CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(), //Cm工程Id
CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(), //CM工程名
PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(), //工程Id
TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(), //表ID
TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(), //表名
FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(), //功能模块名称
OrderNum = TransNullToInt(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(), //说明
SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(), //数据源类型Id
SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(), //Sql数据源名
TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()), //记录数
TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(), //表类型Id
TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim() //表状态ID
};
objvCmProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCmProjectPrjTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCmProjectPrjTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCmProjectPrjTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = TransNullToInt(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = TransNullToInt(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCmProjectPrjTabDA: GetObjByDataRowvCmProjectPrjTab)", objException.Message));
}
objvCmProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCmProjectPrjTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCmProjectPrjTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = TransNullToInt(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = TransNullToInt(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCmProjectPrjTabDA: GetObjByDataRow)", objException.Message));
}
objvCmProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCmProjectPrjTabEN;
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
objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCmProjectPrjTabEN._CurrTabName, convCmProjectPrjTab.mId, 8, "");
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
objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCmProjectPrjTabEN._CurrTabName, convCmProjectPrjTab.mId, 8, strPrefix);
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
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vCmProjectPrjTab where " + strCondition;
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
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vCmProjectPrjTab where " + strCondition;
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
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCmProjectPrjTab", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCmProjectPrjTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCmProjectPrjTab", strCondition))
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
objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCmProjectPrjTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabENS">源对象</param>
 /// <param name = "objvCmProjectPrjTabENT">目标对象</param>
public void CopyTo(clsvCmProjectPrjTabEN objvCmProjectPrjTabENS, clsvCmProjectPrjTabEN objvCmProjectPrjTabENT)
{
objvCmProjectPrjTabENT.mId = objvCmProjectPrjTabENS.mId; //mId
objvCmProjectPrjTabENT.CmPrjId = objvCmProjectPrjTabENS.CmPrjId; //Cm工程Id
objvCmProjectPrjTabENT.CmPrjName = objvCmProjectPrjTabENS.CmPrjName; //CM工程名
objvCmProjectPrjTabENT.PrjId = objvCmProjectPrjTabENS.PrjId; //工程Id
objvCmProjectPrjTabENT.TabId = objvCmProjectPrjTabENS.TabId; //表ID
objvCmProjectPrjTabENT.TabName = objvCmProjectPrjTabENS.TabName; //表名
objvCmProjectPrjTabENT.FuncModuleAgcId = objvCmProjectPrjTabENS.FuncModuleAgcId; //功能模块Id
objvCmProjectPrjTabENT.FuncModuleName = objvCmProjectPrjTabENS.FuncModuleName; //功能模块名称
objvCmProjectPrjTabENT.OrderNum = objvCmProjectPrjTabENS.OrderNum; //序号
objvCmProjectPrjTabENT.UpdDate = objvCmProjectPrjTabENS.UpdDate; //修改日期
objvCmProjectPrjTabENT.UpdUser = objvCmProjectPrjTabENS.UpdUser; //修改者
objvCmProjectPrjTabENT.Memo = objvCmProjectPrjTabENS.Memo; //说明
objvCmProjectPrjTabENT.SqlDsTypeId = objvCmProjectPrjTabENS.SqlDsTypeId; //数据源类型Id
objvCmProjectPrjTabENT.SqlDsTypeName = objvCmProjectPrjTabENS.SqlDsTypeName; //Sql数据源名
objvCmProjectPrjTabENT.TabRecNum = objvCmProjectPrjTabENS.TabRecNum; //记录数
objvCmProjectPrjTabENT.TabTypeId = objvCmProjectPrjTabENS.TabTypeId; //表类型Id
objvCmProjectPrjTabENT.TabStateId = objvCmProjectPrjTabENS.TabStateId; //表状态ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCmProjectPrjTabEN objvCmProjectPrjTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.CmPrjId, 6, convCmProjectPrjTab.CmPrjId);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.CmPrjName, 50, convCmProjectPrjTab.CmPrjName);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.PrjId, 4, convCmProjectPrjTab.PrjId);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.TabId, 8, convCmProjectPrjTab.TabId);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.TabName, 100, convCmProjectPrjTab.TabName);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.FuncModuleAgcId, 8, convCmProjectPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.FuncModuleName, 30, convCmProjectPrjTab.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.UpdDate, 20, convCmProjectPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.UpdUser, 20, convCmProjectPrjTab.UpdUser);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.Memo, 1000, convCmProjectPrjTab.Memo);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.SqlDsTypeId, 2, convCmProjectPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.SqlDsTypeName, 20, convCmProjectPrjTab.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.TabTypeId, 4, convCmProjectPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objvCmProjectPrjTabEN.TabStateId, 2, convCmProjectPrjTab.TabStateId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.CmPrjId, convCmProjectPrjTab.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.CmPrjName, convCmProjectPrjTab.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.PrjId, convCmProjectPrjTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.TabId, convCmProjectPrjTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.TabName, convCmProjectPrjTab.TabName);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.FuncModuleAgcId, convCmProjectPrjTab.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.FuncModuleName, convCmProjectPrjTab.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.UpdDate, convCmProjectPrjTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.UpdUser, convCmProjectPrjTab.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.Memo, convCmProjectPrjTab.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.SqlDsTypeId, convCmProjectPrjTab.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.SqlDsTypeName, convCmProjectPrjTab.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.TabTypeId, convCmProjectPrjTab.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCmProjectPrjTabEN.TabStateId, convCmProjectPrjTab.TabStateId);
//检查外键字段长度
 objvCmProjectPrjTabEN._IsCheckProperty = true;
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
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCmProjectPrjTabEN._CurrTabName);
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
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCmProjectPrjTabEN._CurrTabName, strCondition);
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
 objSQL = clsvCmProjectPrjTabDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}