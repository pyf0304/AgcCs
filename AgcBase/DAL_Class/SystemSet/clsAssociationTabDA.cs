
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAssociationTabDA
 表名:AssociationTab(00050276)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 关联(AssociationTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsAssociationTabDA : clsCommBase4DA
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
 return clsAssociationTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsAssociationTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAssociationTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsAssociationTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsAssociationTabEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsAssociationTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_AssociationTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsAssociationTabDA: GetDataTable_AssociationTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsAssociationTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsAssociationTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsAssociationTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsAssociationTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AssociationTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AssociationTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsAssociationTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from AssociationTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsAssociationTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} AssociationTab.* " + 
$"from AssociationTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and AssociationTab.mId not in " + 
$"(Select top {intTop_In} AssociationTab.mId from AssociationTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AssociationTab where {1} and mId not in (Select top {2} mId from AssociationTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AssociationTab where {1} and mId not in (Select top {3} mId from AssociationTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsAssociationTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} AssociationTab.* " + 
$"from AssociationTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and AssociationTab.mId not in " + 
$"(Select top {intTop_In} AssociationTab.mId from AssociationTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AssociationTab where {1} and mId not in (Select top {2} mId from AssociationTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AssociationTab where {1} and mId not in (Select top {3} mId from AssociationTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsAssociationTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsAssociationTabDA:GetObjLst)", objException.Message));
}
List<clsAssociationTabEN> arrObjLst = new List<clsAssociationTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationTabEN objAssociationTabEN = new clsAssociationTabEN();
try
{
objAssociationTabEN.mId = TransNullToInt(objRow[conAssociationTab.mId].ToString().Trim()); //mId
objAssociationTabEN.PrjId = objRow[conAssociationTab.PrjId].ToString().Trim(); //工程Id
objAssociationTabEN.TabId = objRow[conAssociationTab.TabId].ToString().Trim(); //表ID
objAssociationTabEN.AssociationTabId = objRow[conAssociationTab.AssociationTabId].ToString().Trim(); //关联表Id
objAssociationTabEN.AssociationPrjId = objRow[conAssociationTab.AssociationPrjId].ToString().Trim(); //关联项目Id
objAssociationTabEN.AssociationTypeId = objRow[conAssociationTab.AssociationTypeId].ToString().Trim(); //关联类型Id
objAssociationTabEN.UpdDate = objRow[conAssociationTab.UpdDate] == DBNull.Value ? null : objRow[conAssociationTab.UpdDate].ToString().Trim(); //修改日期
objAssociationTabEN.UpdUserId = objRow[conAssociationTab.UpdUserId] == DBNull.Value ? null : objRow[conAssociationTab.UpdUserId].ToString().Trim(); //修改用户Id
objAssociationTabEN.Memo = objRow[conAssociationTab.Memo] == DBNull.Value ? null : objRow[conAssociationTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAssociationTabDA: GetObjLst)", objException.Message));
}
objAssociationTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAssociationTabEN);
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
public List<clsAssociationTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsAssociationTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsAssociationTabEN> arrObjLst = new List<clsAssociationTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationTabEN objAssociationTabEN = new clsAssociationTabEN();
try
{
objAssociationTabEN.mId = TransNullToInt(objRow[conAssociationTab.mId].ToString().Trim()); //mId
objAssociationTabEN.PrjId = objRow[conAssociationTab.PrjId].ToString().Trim(); //工程Id
objAssociationTabEN.TabId = objRow[conAssociationTab.TabId].ToString().Trim(); //表ID
objAssociationTabEN.AssociationTabId = objRow[conAssociationTab.AssociationTabId].ToString().Trim(); //关联表Id
objAssociationTabEN.AssociationPrjId = objRow[conAssociationTab.AssociationPrjId].ToString().Trim(); //关联项目Id
objAssociationTabEN.AssociationTypeId = objRow[conAssociationTab.AssociationTypeId].ToString().Trim(); //关联类型Id
objAssociationTabEN.UpdDate = objRow[conAssociationTab.UpdDate] == DBNull.Value ? null : objRow[conAssociationTab.UpdDate].ToString().Trim(); //修改日期
objAssociationTabEN.UpdUserId = objRow[conAssociationTab.UpdUserId] == DBNull.Value ? null : objRow[conAssociationTab.UpdUserId].ToString().Trim(); //修改用户Id
objAssociationTabEN.Memo = objRow[conAssociationTab.Memo] == DBNull.Value ? null : objRow[conAssociationTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAssociationTabDA: GetObjLst)", objException.Message));
}
objAssociationTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAssociationTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objAssociationTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetAssociationTab(ref clsAssociationTabEN objAssociationTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where mId = " + ""+ objAssociationTabEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objAssociationTabEN.mId = TransNullToInt(objDT.Rows[0][conAssociationTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objAssociationTabEN.PrjId = objDT.Rows[0][conAssociationTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objAssociationTabEN.TabId = objDT.Rows[0][conAssociationTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objAssociationTabEN.AssociationTabId = objDT.Rows[0][conAssociationTab.AssociationTabId].ToString().Trim(); //关联表Id(字段类型:char,字段长度:8,是否可空:False)
 objAssociationTabEN.AssociationPrjId = objDT.Rows[0][conAssociationTab.AssociationPrjId].ToString().Trim(); //关联项目Id(字段类型:char,字段长度:4,是否可空:False)
 objAssociationTabEN.AssociationTypeId = objDT.Rows[0][conAssociationTab.AssociationTypeId].ToString().Trim(); //关联类型Id(字段类型:char,字段长度:2,是否可空:False)
 objAssociationTabEN.UpdDate = objDT.Rows[0][conAssociationTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAssociationTabEN.UpdUserId = objDT.Rows[0][conAssociationTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objAssociationTabEN.Memo = objDT.Rows[0][conAssociationTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsAssociationTabDA: GetAssociationTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsAssociationTabEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsAssociationTabEN objAssociationTabEN = new clsAssociationTabEN();
try
{
 objAssociationTabEN.mId = Int32.Parse(objRow[conAssociationTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objAssociationTabEN.PrjId = objRow[conAssociationTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objAssociationTabEN.TabId = objRow[conAssociationTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objAssociationTabEN.AssociationTabId = objRow[conAssociationTab.AssociationTabId].ToString().Trim(); //关联表Id(字段类型:char,字段长度:8,是否可空:False)
 objAssociationTabEN.AssociationPrjId = objRow[conAssociationTab.AssociationPrjId].ToString().Trim(); //关联项目Id(字段类型:char,字段长度:4,是否可空:False)
 objAssociationTabEN.AssociationTypeId = objRow[conAssociationTab.AssociationTypeId].ToString().Trim(); //关联类型Id(字段类型:char,字段长度:2,是否可空:False)
 objAssociationTabEN.UpdDate = objRow[conAssociationTab.UpdDate] == DBNull.Value ? null : objRow[conAssociationTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAssociationTabEN.UpdUserId = objRow[conAssociationTab.UpdUserId] == DBNull.Value ? null : objRow[conAssociationTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objAssociationTabEN.Memo = objRow[conAssociationTab.Memo] == DBNull.Value ? null : objRow[conAssociationTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsAssociationTabDA: GetObjBymId)", objException.Message));
}
return objAssociationTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsAssociationTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsAssociationTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsAssociationTabEN objAssociationTabEN = new clsAssociationTabEN()
{
mId = TransNullToInt(objRow[conAssociationTab.mId].ToString().Trim()), //mId
PrjId = objRow[conAssociationTab.PrjId].ToString().Trim(), //工程Id
TabId = objRow[conAssociationTab.TabId].ToString().Trim(), //表ID
AssociationTabId = objRow[conAssociationTab.AssociationTabId].ToString().Trim(), //关联表Id
AssociationPrjId = objRow[conAssociationTab.AssociationPrjId].ToString().Trim(), //关联项目Id
AssociationTypeId = objRow[conAssociationTab.AssociationTypeId].ToString().Trim(), //关联类型Id
UpdDate = objRow[conAssociationTab.UpdDate] == DBNull.Value ? null : objRow[conAssociationTab.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conAssociationTab.UpdUserId] == DBNull.Value ? null : objRow[conAssociationTab.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conAssociationTab.Memo] == DBNull.Value ? null : objRow[conAssociationTab.Memo].ToString().Trim() //说明
};
objAssociationTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAssociationTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsAssociationTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsAssociationTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAssociationTabEN objAssociationTabEN = new clsAssociationTabEN();
try
{
objAssociationTabEN.mId = TransNullToInt(objRow[conAssociationTab.mId].ToString().Trim()); //mId
objAssociationTabEN.PrjId = objRow[conAssociationTab.PrjId].ToString().Trim(); //工程Id
objAssociationTabEN.TabId = objRow[conAssociationTab.TabId].ToString().Trim(); //表ID
objAssociationTabEN.AssociationTabId = objRow[conAssociationTab.AssociationTabId].ToString().Trim(); //关联表Id
objAssociationTabEN.AssociationPrjId = objRow[conAssociationTab.AssociationPrjId].ToString().Trim(); //关联项目Id
objAssociationTabEN.AssociationTypeId = objRow[conAssociationTab.AssociationTypeId].ToString().Trim(); //关联类型Id
objAssociationTabEN.UpdDate = objRow[conAssociationTab.UpdDate] == DBNull.Value ? null : objRow[conAssociationTab.UpdDate].ToString().Trim(); //修改日期
objAssociationTabEN.UpdUserId = objRow[conAssociationTab.UpdUserId] == DBNull.Value ? null : objRow[conAssociationTab.UpdUserId].ToString().Trim(); //修改用户Id
objAssociationTabEN.Memo = objRow[conAssociationTab.Memo] == DBNull.Value ? null : objRow[conAssociationTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsAssociationTabDA: GetObjByDataRowAssociationTab)", objException.Message));
}
objAssociationTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAssociationTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsAssociationTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAssociationTabEN objAssociationTabEN = new clsAssociationTabEN();
try
{
objAssociationTabEN.mId = TransNullToInt(objRow[conAssociationTab.mId].ToString().Trim()); //mId
objAssociationTabEN.PrjId = objRow[conAssociationTab.PrjId].ToString().Trim(); //工程Id
objAssociationTabEN.TabId = objRow[conAssociationTab.TabId].ToString().Trim(); //表ID
objAssociationTabEN.AssociationTabId = objRow[conAssociationTab.AssociationTabId].ToString().Trim(); //关联表Id
objAssociationTabEN.AssociationPrjId = objRow[conAssociationTab.AssociationPrjId].ToString().Trim(); //关联项目Id
objAssociationTabEN.AssociationTypeId = objRow[conAssociationTab.AssociationTypeId].ToString().Trim(); //关联类型Id
objAssociationTabEN.UpdDate = objRow[conAssociationTab.UpdDate] == DBNull.Value ? null : objRow[conAssociationTab.UpdDate].ToString().Trim(); //修改日期
objAssociationTabEN.UpdUserId = objRow[conAssociationTab.UpdUserId] == DBNull.Value ? null : objRow[conAssociationTab.UpdUserId].ToString().Trim(); //修改用户Id
objAssociationTabEN.Memo = objRow[conAssociationTab.Memo] == DBNull.Value ? null : objRow[conAssociationTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsAssociationTabDA: GetObjByDataRow)", objException.Message));
}
objAssociationTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAssociationTabEN;
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
objSQL = clsAssociationTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAssociationTabEN._CurrTabName, conAssociationTab.mId, 8, "");
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
objSQL = clsAssociationTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAssociationTabEN._CurrTabName, conAssociationTab.mId, 8, strPrefix);
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from AssociationTab where " + strCondition;
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from AssociationTab where " + strCondition;
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AssociationTab", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsAssociationTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AssociationTab", strCondition))
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
objSQL = clsAssociationTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("AssociationTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsAssociationTabEN objAssociationTabEN)
 {
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAssociationTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AssociationTab");
objRow = objDS.Tables["AssociationTab"].NewRow();
objRow[conAssociationTab.PrjId] = objAssociationTabEN.PrjId; //工程Id
objRow[conAssociationTab.TabId] = objAssociationTabEN.TabId; //表ID
objRow[conAssociationTab.AssociationTabId] = objAssociationTabEN.AssociationTabId; //关联表Id
objRow[conAssociationTab.AssociationPrjId] = objAssociationTabEN.AssociationPrjId; //关联项目Id
objRow[conAssociationTab.AssociationTypeId] = objAssociationTabEN.AssociationTypeId; //关联类型Id
 if (objAssociationTabEN.UpdDate !=  "")
 {
objRow[conAssociationTab.UpdDate] = objAssociationTabEN.UpdDate; //修改日期
 }
 if (objAssociationTabEN.UpdUserId !=  "")
 {
objRow[conAssociationTab.UpdUserId] = objAssociationTabEN.UpdUserId; //修改用户Id
 }
 if (objAssociationTabEN.Memo !=  "")
 {
objRow[conAssociationTab.Memo] = objAssociationTabEN.Memo; //说明
 }
objDS.Tables[clsAssociationTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsAssociationTabEN._CurrTabName);
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
 /// <param name = "objAssociationTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAssociationTabEN objAssociationTabEN)
{
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAssociationTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAssociationTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.PrjId);
 var strPrjId = objAssociationTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objAssociationTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.TabId);
 var strTabId = objAssociationTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objAssociationTabEN.AssociationTabId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationTabId);
 var strAssociationTabId = objAssociationTabEN.AssociationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationTabId + "'");
 }
 
 if (objAssociationTabEN.AssociationPrjId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationPrjId);
 var strAssociationPrjId = objAssociationTabEN.AssociationPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationPrjId + "'");
 }
 
 if (objAssociationTabEN.AssociationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationTypeId);
 var strAssociationTypeId = objAssociationTabEN.AssociationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationTypeId + "'");
 }
 
 if (objAssociationTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.UpdDate);
 var strUpdDate = objAssociationTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAssociationTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.UpdUserId);
 var strUpdUserId = objAssociationTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objAssociationTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.Memo);
 var strMemo = objAssociationTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AssociationTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objAssociationTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAssociationTabEN objAssociationTabEN)
{
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAssociationTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAssociationTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.PrjId);
 var strPrjId = objAssociationTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objAssociationTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.TabId);
 var strTabId = objAssociationTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objAssociationTabEN.AssociationTabId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationTabId);
 var strAssociationTabId = objAssociationTabEN.AssociationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationTabId + "'");
 }
 
 if (objAssociationTabEN.AssociationPrjId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationPrjId);
 var strAssociationPrjId = objAssociationTabEN.AssociationPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationPrjId + "'");
 }
 
 if (objAssociationTabEN.AssociationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationTypeId);
 var strAssociationTypeId = objAssociationTabEN.AssociationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationTypeId + "'");
 }
 
 if (objAssociationTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.UpdDate);
 var strUpdDate = objAssociationTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAssociationTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.UpdUserId);
 var strUpdUserId = objAssociationTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objAssociationTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.Memo);
 var strMemo = objAssociationTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AssociationTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objAssociationTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAssociationTabEN objAssociationTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAssociationTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAssociationTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.PrjId);
 var strPrjId = objAssociationTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objAssociationTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.TabId);
 var strTabId = objAssociationTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objAssociationTabEN.AssociationTabId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationTabId);
 var strAssociationTabId = objAssociationTabEN.AssociationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationTabId + "'");
 }
 
 if (objAssociationTabEN.AssociationPrjId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationPrjId);
 var strAssociationPrjId = objAssociationTabEN.AssociationPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationPrjId + "'");
 }
 
 if (objAssociationTabEN.AssociationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationTypeId);
 var strAssociationTypeId = objAssociationTabEN.AssociationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationTypeId + "'");
 }
 
 if (objAssociationTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.UpdDate);
 var strUpdDate = objAssociationTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAssociationTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.UpdUserId);
 var strUpdUserId = objAssociationTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objAssociationTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.Memo);
 var strMemo = objAssociationTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AssociationTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objAssociationTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAssociationTabEN objAssociationTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAssociationTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAssociationTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.PrjId);
 var strPrjId = objAssociationTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objAssociationTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.TabId);
 var strTabId = objAssociationTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objAssociationTabEN.AssociationTabId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationTabId);
 var strAssociationTabId = objAssociationTabEN.AssociationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationTabId + "'");
 }
 
 if (objAssociationTabEN.AssociationPrjId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationPrjId);
 var strAssociationPrjId = objAssociationTabEN.AssociationPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationPrjId + "'");
 }
 
 if (objAssociationTabEN.AssociationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.AssociationTypeId);
 var strAssociationTypeId = objAssociationTabEN.AssociationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationTypeId + "'");
 }
 
 if (objAssociationTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.UpdDate);
 var strUpdDate = objAssociationTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAssociationTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.UpdUserId);
 var strUpdUserId = objAssociationTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objAssociationTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAssociationTab.Memo);
 var strMemo = objAssociationTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AssociationTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewAssociationTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AssociationTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conAssociationTab.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsAssociationTabEN._CurrTabName ].NewRow();
objRow[conAssociationTab.PrjId] = oRow[conAssociationTab.PrjId].ToString().Trim(); //工程Id
objRow[conAssociationTab.TabId] = oRow[conAssociationTab.TabId].ToString().Trim(); //表ID
objRow[conAssociationTab.AssociationTabId] = oRow[conAssociationTab.AssociationTabId].ToString().Trim(); //关联表Id
objRow[conAssociationTab.AssociationPrjId] = oRow[conAssociationTab.AssociationPrjId].ToString().Trim(); //关联项目Id
objRow[conAssociationTab.AssociationTypeId] = oRow[conAssociationTab.AssociationTypeId].ToString().Trim(); //关联类型Id
objRow[conAssociationTab.UpdDate] = oRow[conAssociationTab.UpdDate].ToString().Trim(); //修改日期
objRow[conAssociationTab.UpdUserId] = oRow[conAssociationTab.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conAssociationTab.Memo] = oRow[conAssociationTab.Memo].ToString().Trim(); //说明
 objDS.Tables[clsAssociationTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsAssociationTabEN._CurrTabName);
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
 /// <param name = "objAssociationTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsAssociationTabEN objAssociationTabEN)
{
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAssociationTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
strSQL = "Select * from AssociationTab where mId = " + ""+ objAssociationTabEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsAssociationTabEN._CurrTabName);
if (objDS.Tables[clsAssociationTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objAssociationTabEN.mId+"");
return false;
}
objRow = objDS.Tables[clsAssociationTabEN._CurrTabName].Rows[0];
 if (objAssociationTabEN.IsUpdated(conAssociationTab.PrjId))
 {
objRow[conAssociationTab.PrjId] = objAssociationTabEN.PrjId; //工程Id
 }
 if (objAssociationTabEN.IsUpdated(conAssociationTab.TabId))
 {
objRow[conAssociationTab.TabId] = objAssociationTabEN.TabId; //表ID
 }
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTabId))
 {
objRow[conAssociationTab.AssociationTabId] = objAssociationTabEN.AssociationTabId; //关联表Id
 }
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationPrjId))
 {
objRow[conAssociationTab.AssociationPrjId] = objAssociationTabEN.AssociationPrjId; //关联项目Id
 }
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTypeId))
 {
objRow[conAssociationTab.AssociationTypeId] = objAssociationTabEN.AssociationTypeId; //关联类型Id
 }
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdDate))
 {
objRow[conAssociationTab.UpdDate] = objAssociationTabEN.UpdDate; //修改日期
 }
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdUserId))
 {
objRow[conAssociationTab.UpdUserId] = objAssociationTabEN.UpdUserId; //修改用户Id
 }
 if (objAssociationTabEN.IsUpdated(conAssociationTab.Memo))
 {
objRow[conAssociationTab.Memo] = objAssociationTabEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsAssociationTabEN._CurrTabName);
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
 /// <param name = "objAssociationTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAssociationTabEN objAssociationTabEN)
{
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAssociationTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update AssociationTab Set ");
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.PrjId))
 {
 if (objAssociationTabEN.PrjId !=  null)
 {
 var strPrjId = objAssociationTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conAssociationTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.PrjId); //工程Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.TabId))
 {
 if (objAssociationTabEN.TabId !=  null)
 {
 var strTabId = objAssociationTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conAssociationTab.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.TabId); //表ID
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTabId))
 {
 if (objAssociationTabEN.AssociationTabId !=  null)
 {
 var strAssociationTabId = objAssociationTabEN.AssociationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationTabId, conAssociationTab.AssociationTabId); //关联表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.AssociationTabId); //关联表Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationPrjId))
 {
 if (objAssociationTabEN.AssociationPrjId !=  null)
 {
 var strAssociationPrjId = objAssociationTabEN.AssociationPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationPrjId, conAssociationTab.AssociationPrjId); //关联项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.AssociationPrjId); //关联项目Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTypeId))
 {
 if (objAssociationTabEN.AssociationTypeId !=  null)
 {
 var strAssociationTypeId = objAssociationTabEN.AssociationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationTypeId, conAssociationTab.AssociationTypeId); //关联类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.AssociationTypeId); //关联类型Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdDate))
 {
 if (objAssociationTabEN.UpdDate !=  null)
 {
 var strUpdDate = objAssociationTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAssociationTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.UpdDate); //修改日期
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdUserId))
 {
 if (objAssociationTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objAssociationTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conAssociationTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.Memo))
 {
 if (objAssociationTabEN.Memo !=  null)
 {
 var strMemo = objAssociationTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAssociationTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objAssociationTabEN.mId); 
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
 /// <param name = "objAssociationTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsAssociationTabEN objAssociationTabEN, string strCondition)
{
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAssociationTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AssociationTab Set ");
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.PrjId))
 {
 if (objAssociationTabEN.PrjId !=  null)
 {
 var strPrjId = objAssociationTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.TabId))
 {
 if (objAssociationTabEN.TabId !=  null)
 {
 var strTabId = objAssociationTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTabId))
 {
 if (objAssociationTabEN.AssociationTabId !=  null)
 {
 var strAssociationTabId = objAssociationTabEN.AssociationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationTabId = '{0}',", strAssociationTabId); //关联表Id
 }
 else
 {
 sbSQL.Append(" AssociationTabId = null,"); //关联表Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationPrjId))
 {
 if (objAssociationTabEN.AssociationPrjId !=  null)
 {
 var strAssociationPrjId = objAssociationTabEN.AssociationPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationPrjId = '{0}',", strAssociationPrjId); //关联项目Id
 }
 else
 {
 sbSQL.Append(" AssociationPrjId = null,"); //关联项目Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTypeId))
 {
 if (objAssociationTabEN.AssociationTypeId !=  null)
 {
 var strAssociationTypeId = objAssociationTabEN.AssociationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationTypeId = '{0}',", strAssociationTypeId); //关联类型Id
 }
 else
 {
 sbSQL.Append(" AssociationTypeId = null,"); //关联类型Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdDate))
 {
 if (objAssociationTabEN.UpdDate !=  null)
 {
 var strUpdDate = objAssociationTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdUserId))
 {
 if (objAssociationTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objAssociationTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.Memo))
 {
 if (objAssociationTabEN.Memo !=  null)
 {
 var strMemo = objAssociationTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAssociationTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsAssociationTabEN objAssociationTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAssociationTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AssociationTab Set ");
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.PrjId))
 {
 if (objAssociationTabEN.PrjId !=  null)
 {
 var strPrjId = objAssociationTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.TabId))
 {
 if (objAssociationTabEN.TabId !=  null)
 {
 var strTabId = objAssociationTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTabId))
 {
 if (objAssociationTabEN.AssociationTabId !=  null)
 {
 var strAssociationTabId = objAssociationTabEN.AssociationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationTabId = '{0}',", strAssociationTabId); //关联表Id
 }
 else
 {
 sbSQL.Append(" AssociationTabId = null,"); //关联表Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationPrjId))
 {
 if (objAssociationTabEN.AssociationPrjId !=  null)
 {
 var strAssociationPrjId = objAssociationTabEN.AssociationPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationPrjId = '{0}',", strAssociationPrjId); //关联项目Id
 }
 else
 {
 sbSQL.Append(" AssociationPrjId = null,"); //关联项目Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTypeId))
 {
 if (objAssociationTabEN.AssociationTypeId !=  null)
 {
 var strAssociationTypeId = objAssociationTabEN.AssociationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationTypeId = '{0}',", strAssociationTypeId); //关联类型Id
 }
 else
 {
 sbSQL.Append(" AssociationTypeId = null,"); //关联类型Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdDate))
 {
 if (objAssociationTabEN.UpdDate !=  null)
 {
 var strUpdDate = objAssociationTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdUserId))
 {
 if (objAssociationTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objAssociationTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.Memo))
 {
 if (objAssociationTabEN.Memo !=  null)
 {
 var strMemo = objAssociationTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAssociationTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAssociationTabEN objAssociationTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objAssociationTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAssociationTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAssociationTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AssociationTab Set ");
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.PrjId))
 {
 if (objAssociationTabEN.PrjId !=  null)
 {
 var strPrjId = objAssociationTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conAssociationTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.PrjId); //工程Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.TabId))
 {
 if (objAssociationTabEN.TabId !=  null)
 {
 var strTabId = objAssociationTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conAssociationTab.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.TabId); //表ID
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTabId))
 {
 if (objAssociationTabEN.AssociationTabId !=  null)
 {
 var strAssociationTabId = objAssociationTabEN.AssociationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationTabId, conAssociationTab.AssociationTabId); //关联表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.AssociationTabId); //关联表Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationPrjId))
 {
 if (objAssociationTabEN.AssociationPrjId !=  null)
 {
 var strAssociationPrjId = objAssociationTabEN.AssociationPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationPrjId, conAssociationTab.AssociationPrjId); //关联项目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.AssociationPrjId); //关联项目Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.AssociationTypeId))
 {
 if (objAssociationTabEN.AssociationTypeId !=  null)
 {
 var strAssociationTypeId = objAssociationTabEN.AssociationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationTypeId, conAssociationTab.AssociationTypeId); //关联类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.AssociationTypeId); //关联类型Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdDate))
 {
 if (objAssociationTabEN.UpdDate !=  null)
 {
 var strUpdDate = objAssociationTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAssociationTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.UpdDate); //修改日期
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.UpdUserId))
 {
 if (objAssociationTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objAssociationTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conAssociationTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objAssociationTabEN.IsUpdated(conAssociationTab.Memo))
 {
 if (objAssociationTabEN.Memo !=  null)
 {
 var strMemo = objAssociationTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAssociationTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAssociationTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objAssociationTabEN.mId); 
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("AssociationTab_Delete", values);
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
//删除AssociationTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AssociationTab where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelAssociationTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
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
//删除AssociationTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AssociationTab where mId in (" + strKeyList + ")";
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
//删除AssociationTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AssociationTab where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelAssociationTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsAssociationTabDA: DelAssociationTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AssociationTab where " + strCondition ;
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
public bool DelAssociationTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsAssociationTabDA: DelAssociationTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AssociationTab where " + strCondition ;
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
 /// <param name = "objAssociationTabENS">源对象</param>
 /// <param name = "objAssociationTabENT">目标对象</param>
public void CopyTo(clsAssociationTabEN objAssociationTabENS, clsAssociationTabEN objAssociationTabENT)
{
objAssociationTabENT.mId = objAssociationTabENS.mId; //mId
objAssociationTabENT.PrjId = objAssociationTabENS.PrjId; //工程Id
objAssociationTabENT.TabId = objAssociationTabENS.TabId; //表ID
objAssociationTabENT.AssociationTabId = objAssociationTabENS.AssociationTabId; //关联表Id
objAssociationTabENT.AssociationPrjId = objAssociationTabENS.AssociationPrjId; //关联项目Id
objAssociationTabENT.AssociationTypeId = objAssociationTabENS.AssociationTypeId; //关联类型Id
objAssociationTabENT.UpdDate = objAssociationTabENS.UpdDate; //修改日期
objAssociationTabENT.UpdUserId = objAssociationTabENS.UpdUserId; //修改用户Id
objAssociationTabENT.Memo = objAssociationTabENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsAssociationTabEN objAssociationTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objAssociationTabEN.PrjId, conAssociationTab.PrjId);
clsCheckSql.CheckFieldNotNull(objAssociationTabEN.TabId, conAssociationTab.TabId);
clsCheckSql.CheckFieldNotNull(objAssociationTabEN.AssociationTabId, conAssociationTab.AssociationTabId);
clsCheckSql.CheckFieldNotNull(objAssociationTabEN.AssociationPrjId, conAssociationTab.AssociationPrjId);
clsCheckSql.CheckFieldNotNull(objAssociationTabEN.AssociationTypeId, conAssociationTab.AssociationTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objAssociationTabEN.PrjId, 4, conAssociationTab.PrjId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.TabId, 8, conAssociationTab.TabId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.AssociationTabId, 8, conAssociationTab.AssociationTabId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.AssociationPrjId, 4, conAssociationTab.AssociationPrjId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.AssociationTypeId, 2, conAssociationTab.AssociationTypeId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.UpdDate, 20, conAssociationTab.UpdDate);
clsCheckSql.CheckFieldLen(objAssociationTabEN.UpdUserId, 20, conAssociationTab.UpdUserId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.Memo, 1000, conAssociationTab.Memo);
//检查字段外键固定长度
 objAssociationTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsAssociationTabEN objAssociationTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAssociationTabEN.PrjId, 4, conAssociationTab.PrjId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.TabId, 8, conAssociationTab.TabId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.AssociationTabId, 8, conAssociationTab.AssociationTabId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.AssociationPrjId, 4, conAssociationTab.AssociationPrjId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.AssociationTypeId, 2, conAssociationTab.AssociationTypeId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.UpdDate, 20, conAssociationTab.UpdDate);
clsCheckSql.CheckFieldLen(objAssociationTabEN.UpdUserId, 20, conAssociationTab.UpdUserId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.Memo, 1000, conAssociationTab.Memo);
//检查外键字段长度
 objAssociationTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsAssociationTabEN objAssociationTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAssociationTabEN.PrjId, 4, conAssociationTab.PrjId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.TabId, 8, conAssociationTab.TabId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.AssociationTabId, 8, conAssociationTab.AssociationTabId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.AssociationPrjId, 4, conAssociationTab.AssociationPrjId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.AssociationTypeId, 2, conAssociationTab.AssociationTypeId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.UpdDate, 20, conAssociationTab.UpdDate);
clsCheckSql.CheckFieldLen(objAssociationTabEN.UpdUserId, 20, conAssociationTab.UpdUserId);
clsCheckSql.CheckFieldLen(objAssociationTabEN.Memo, 1000, conAssociationTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objAssociationTabEN.PrjId, conAssociationTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objAssociationTabEN.TabId, conAssociationTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objAssociationTabEN.AssociationTabId, conAssociationTab.AssociationTabId);
clsCheckSql.CheckSqlInjection4Field(objAssociationTabEN.AssociationPrjId, conAssociationTab.AssociationPrjId);
clsCheckSql.CheckSqlInjection4Field(objAssociationTabEN.AssociationTypeId, conAssociationTab.AssociationTypeId);
clsCheckSql.CheckSqlInjection4Field(objAssociationTabEN.UpdDate, conAssociationTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objAssociationTabEN.UpdUserId, conAssociationTab.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objAssociationTabEN.Memo, conAssociationTab.Memo);
//检查外键字段长度
 objAssociationTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--AssociationTab(关联),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAssociationTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsAssociationTabEN objAssociationTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objAssociationTabEN.PrjId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objAssociationTabEN.TabId);
 sbCondition.AppendFormat(" and AssociationPrjId = '{0}'", objAssociationTabEN.AssociationPrjId);
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAssociationTabEN._CurrTabName);
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAssociationTabEN._CurrTabName, strCondition);
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
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
 objSQL = clsAssociationTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}